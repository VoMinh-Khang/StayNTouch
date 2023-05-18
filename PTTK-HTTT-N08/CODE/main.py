import sys
from app.views import app
import cx_Oracle

def main():

    lib_dir = r"D:\Download\instantclient-basic-windows.x64-21.9.0.0.0dbru\instantclient_21_9"
    # lib_dir = r"C:\thong\instantclient-basic-windows.x64-21.9.0.0.0dbru\instantclient_21_9"
    global oracle_client_initialized
    oracle_client_initialized = False
    if not oracle_client_initialized:
        try:
            cx_Oracle.init_oracle_client(lib_dir=lib_dir)
            oracle_client_initialized = True
            print("vaof dday roi")
        except Exception as err:
            print("Error initializing Oracle Client:", err)
            sys.exit(1)


    app.run(debug=True)

if __name__ == '__main__':
    main()
