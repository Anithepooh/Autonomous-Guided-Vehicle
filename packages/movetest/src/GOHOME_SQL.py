#!/usr/bin/env python  
import roslib; roslib.load_manifest('movetest')
import pymysql  
import rospy  
import actionlib
import pymysql  
from actionlib_msgs.msg import *  
from geometry_msgs.msg import Pose, Point, Quaternion, Twist  
from move_base_msgs.msg import MoveBaseAction, MoveBaseGoal  
from tf.transformations import quaternion_from_euler  
from visualization_msgs.msg import Marker  
from math import radians, pi  


def write_data(Status):
   db = pymysql.connect(host=host, port=port, user=user, password=password, db=database, charset=charset)
   cursor = db.cursor()    
   try:
     	add_data = "INSERT INTO agv(Status) VALUES ('"+ Status +"')"
        print("123")
      	cursor.execute(add_data)
      	db.commit()
   except Exception as msg:
        db.rollback()
        print(msg)
   finally:
        cursor.close()
        db.close()
        print("OK")
  
class MoveBaseSquare():  
    def __init__(self):  
        rospy.init_node('nav_test', anonymous=False)  
          
        rospy.on_shutdown(self.shutdown)  
          
        # How big is the square we want the robot to navigate?  
          
        square_size = rospy.get_param("~square_size", 1.0) # meters  
          
        # Create a list to hold the target quaternions (orientations)  
        
        quaternions = list()  
          
        # First define the corner orientations as Euler angles  
        
        euler_angles = ((pi/2-0.17), (pi-0.17), (3*pi/2-0.17), (0))  
          
        # Then convert the angles to quaternions  
        
        for angle in euler_angles:  
            q_angle = quaternion_from_euler(0, 0, angle, axes='sxyz')  
            q = Quaternion(*q_angle)  
            quaternions.append(q)  
          
        # Create a list to hold the waypoint poses  
        
        waypoints = list()  
          
        # Append each of the four waypoints to the list.  Each waypoint  
        # is a pose consisting of a position and orientation in the map frame.  
        
        waypoints.append(Pose(Point(2.24, 1.28, 0.0), quaternions[0]))   
          
        # Initialize the visualization markers for RViz  
        
        self.init_markers()  
          
        # Set a visualization marker at each waypoint   
        
        for waypoint in waypoints:             
            p = Point()  
            p = waypoint.position  
            self.markers.points.append(p)  
              
        # Publisher to manually control the robot (e.g. to stop it)  
        
        self.cmd_vel_pub = rospy.Publisher('cmd_vel', Twist)  
          
        # Subscribe to the move_base action server  
        
        self.move_base = actionlib.SimpleActionClient("move_base", MoveBaseAction)  
          
        rospy.loginfo("Waiting for move_base action server...")  
          
        # Wait 60 seconds for the action server to become available  
        
        self.move_base.wait_for_server(rospy.Duration(60))  
          
        rospy.loginfo("Connected to move base server")  
        rospy.loginfo("Starting navigation test")  
          
        # Initialize a counter to track waypoints  
        
        i = 0  
          
        # Cycle through the four waypoints  
        
        while i < 1 and not rospy.is_shutdown():  
            # Update the marker display  
            
            self.marker_pub.publish(self.markers)  
              
            # Intialize the waypoint goal  
            
            goal = MoveBaseGoal()  
              
            # Use the map frame to define goal poses  
            
            goal.target_pose.header.frame_id = 'map'  
              
            # Set the time stamp to "now"  
            
            goal.target_pose.header.stamp = rospy.Time.now()  
              
            # Set the goal pose to the i-th waypoint  
            
            goal.target_pose.pose = waypoints[i]  
              
            # Start the robot moving toward the goal  
            
            self.move(goal)  
              
            i += 1  
          
    def move(self, goal):  
            # Send the goal pose to the MoveBaseAction server  
            
            self.move_base.send_goal(goal)  
              
            # Allow 1 minute to get there  
            
            finished_within_time = self.move_base.wait_for_result(rospy.Duration(60))   
              
            # If we don't get there in time, abort the goal  
            
            if not finished_within_time:  
                self.move_base.cancel_goal()  
                rospy.loginfo("Timed out achieving goal")
		Status_q='Unreachable_Home'        
		write_data(Status_q)  
            else:  
                # We made it!  
                state = self.move_base.get_state()  
                if state == GoalStatus.SUCCEEDED:  
                    rospy.loginfo("Goal succeeded!")
		    Status_q='arrival_HOME'        
		    write_data(Status_q)  
                      
    def init_markers(self):  
        # Set up our waypoint markers  
        
        marker_scale = 0.2  
        marker_lifetime = 0 # 0 is forever  
        marker_ns = 'waypoints'  
        marker_id = 0  
        marker_color = {'r': 1.0, 'g': 0.7, 'b': 1.0, 'a': 1.0}  
          
        # Define a marker publisher.  
        
        self.marker_pub = rospy.Publisher('waypoint_markers', Marker)  
          
        # Initialize the marker points list.  
        
        self.markers = Marker()  
        self.markers.ns = marker_ns  
        self.markers.id = marker_id  
        self.markers.type = Marker.SPHERE_LIST  
        self.markers.action = Marker.ADD  
        self.markers.lifetime = rospy.Duration(marker_lifetime)  
        self.markers.scale.x = marker_scale  
        self.markers.scale.y = marker_scale  
        self.markers.color.r = marker_color['r']  
        self.markers.color.g = marker_color['g']  
        self.markers.color.b = marker_color['b']  
        self.markers.color.a = marker_color['a']  
          
        self.markers.header.frame_id = 'map'  
        self.markers.header.stamp = rospy.Time.now()  
        self.markers.points = list()  
  
    def shutdown(self):  
        rospy.loginfo("Stopping the robot...")  
        # Cancel any active goals  
        #self.move_base.cancel_goal()  
        #rospy.sleep(2)  
        # Stop the robot  
        #self.cmd_vel_pub.publish(Twist())  
        #rospy.sleep(1)


	  
  
if __name__ == '__main__':

    host = '192.168.21.137'
    port = 3306
    user = 'pallet'
    password = '40227000'
    database = 'agvkw'
    charset = 'utf8'
    Status_q='Go_Home_Start'        
    write_data(Status_q)  
    try:  
        MoveBaseSquare()  
    except rospy.ROSInterruptException:  
        rospy.loginfo("Navigation test finished.")
