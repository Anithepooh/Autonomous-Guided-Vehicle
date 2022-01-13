#!/usr/bin/env python  
import roslib; roslib.load_manifest('movetest')
import pymysql  
import rospy  
import actionlib
import pymysql  


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

if __name__ == '__main__':

    host = '192.168.50.59'
    port = 3306
    user = 'pallet'
    password = '12345678'
    database = 'agx'
    charset = 'utf8'
    Status_q = 'Go_Home_Start'
    #Status_q='1234'        
    #write_data(Status_q)
#    try:
    write_data(Status_q)
#   except rospy.ROSInterruptException:
#       rospy.loginfo("Navigation test finished.")
