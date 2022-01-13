#!/usr/bin/env python  
import rospy   
import pymysql
import numpy as np
import time


host = '192.168.1.177'
port = 3306
user = 'pi'
password = '12345678'
database = 'agx'
charset = 'utf8'
def write_data(Status):
    db = pymysql.connect(host=host, port=port, user=user, password=password, db=database, charset=charset)
    cursor = db.cursor()
    
    try:
        add_data = "INSERT INTO agv(Status) VALUES ('"+ Status + "')"

        cursor.execute(add_data)
        db.commit()
    except Exception as msg:
        db.rollback()
        print(msg)
    finally:
        cursor.close()
        db.close()
if __name__ == '__main__':
	Status_q='456'        
	write_data(Status_q)




















       
