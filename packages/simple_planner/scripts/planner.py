#!/usr/bin/env python
#-*- coding:utf-8   -*-

import threading,math
import rospy,tf
from geometry_msgs.msg import Twist
from std_msgs.msg import *

planner_status = False
steering_last = 0.0


def start_planner_sub(data):
    global planner_status
    planner_status = data.data
    print 'planner_status = ',planner_status

def planner_publisher():
    global planner_status
    global steering_last
    throttle_control = 0
    steering_control = 0
    throttle_limit = 100
    steering_limit = 20
    stop_dist = 0.5
    target_x_dist_limit = 0.2
    throttle_speed = 50

    target_x_dist = 0
    linear = 0
    angular = 0

    angular_P_gain = 1.0
    linear_P_gain = 1.0

    steering_angle_pub = rospy.Publisher('/steering_angle', Int16, queue_size=5)
    throttle_pub = rospy.Publisher('/throttle', Int16, queue_size=5)

    tf_listener = tf.TransformListener()
    pose = []

    rate = rospy.Rate(3)

    throttle_msg = Int16()
    steering_angle_msg = Int16()
    throttle_msg.data = 0
    steering_angle_msg.data = 0

    while not rospy.is_shutdown():
        try:
            (trans, rot) = tf_listener.lookupTransform('/footprint_head', '/target', rospy.Time(0))
            angular = 1.0 * math.atan2(trans[1], trans[0])
            linear = 1.0 * math.sqrt(trans[0] ** 2 + trans[1] ** 2)

            if linear > 2.0:
                angular_P_gain = 2.0/linear
            else:
                angular_P_gain = 1.0

            angular = angular_P_gain * angular
            linear = linear_P_gain * linear
            
            steering_last = steering_last*0.5 + math.degrees(-angular)*0.5

            target_x_dist = trans[0]
            # print 'x = ',target_x_dist

            if linear > stop_dist and abs(target_x_dist) > target_x_dist_limit:
                throttle_control = throttle_speed
                steering_control = int(steering_last)
            
            if linear > stop_dist and abs(target_x_dist) <= target_x_dist_limit:
                print 'Position Shift! cannot be reached'
                throttle_control = 0
                steering_control = 0

            if linear <= stop_dist: #distance limit
                throttle_control = 0

        except (tf.LookupException, tf.ConnectivityException, tf.ExtrapolationException) as e:
            throttle_control = 0
            steering_control = 0
            planner_status = False
            print e

        if throttle_control >= throttle_limit:
            throttle_control = throttle_limit
        elif throttle_control <= -throttle_limit:
            throttle_control = -throttle_limit
        if steering_control >= steering_limit:
            steering_control = steering_limit
        elif steering_control <= -steering_limit:
            steering_control = -steering_limit

        # print 'target_dist = ',linear
        # print 'target_angle_degree = ',math.degrees(-angular)
        
        if planner_status:
            print 'steering_control_degree = ',steering_control
            throttle_msg.data = throttle_control
            steering_angle_msg.data = steering_control
            throttle_pub.publish(throttle_msg),
            steering_angle_pub.publish(steering_angle_msg)
        rate.sleep()

if __name__ == '__main__':
    rospy.init_node('simple_planner', anonymous=False)
    
    rospy.Subscriber('start_planner', Bool, start_planner_sub)

    rate = rospy.Rate(3)

    
    # t = threading.Thread(target=start_planner_loop)
    # t.daemon = True
    # t.start()

    planner_publisher()