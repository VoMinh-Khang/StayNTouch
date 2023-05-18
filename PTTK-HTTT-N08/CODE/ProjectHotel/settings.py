import sys
import cx_Oracle

def execute_query(username, password, queryString):
    print(username)
    print(password)
    print(queryString)
    try:
        con = cx_Oracle.connect(username, password, 'localhost:1521/XE')   #XEPDB1

    except cx_Oracle.DatabaseError as er:
        print('There is an error in the Oracle database:', er)

    else:
        try:
            cur = con.cursor()

            # fetchall() is used to fetch all records from result set
            cur.execute(queryString)
            con.commit()
            rows = cur.fetchall()
            if cur:
                cur.close()
            return rows

        except cx_Oracle.DatabaseError as er:
            error_obj, = er.args
            print('There is an error in the Oracle database:', er)
            if cur:
                cur.close()
            return False, error_obj.code

        except Exception as er:
            error_obj, = er.args
            print('Error:'+str(er))
            if cur:
                cur.close()
            return False, error_obj.code

