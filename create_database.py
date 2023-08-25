import sqlite3
from synthetic_date import *



class Order:
    def __init__(self):  
        #self.number_orders = 100       # всего заказов
        self.order_index = None       
        self.city_from = ''  
        self.address_from = ''                 
        self.city_to = ''
        self.address_to = ''
        self.weight = None
        self.date = ''
        self.database_path = "Versta/Database/OrdersDB.db"


    # -------------------------database-----------------------------
    def create_db(self):
        sqliteConnection = sqlite3.connect(self.database_path)
        cursor = sqliteConnection.cursor()
        cursor.execute("""CREATE TABLE IF NOT EXISTS ordersdb(
        id INTEGER PRIMARY KEY AUTOINCREMENT,
        unique_id TEXT,
        city_from TEXT,
        address_from TEXT,
        city_to TEXT,
        address_to TEXT,
        weight INTEGER,
        date TEXT)
                        """)
        cursor.close()


    def insert_date_db(self, _unique_id, _city_from, _address_from, _city_to, _address_to, _date, _weight):
        sqliteConnection = sqlite3.connect(self.database_path)
        cursor = sqliteConnection.cursor()
        add_to_table = "INSERT INTO ordersdb (unique_id, city_from, address_from, city_to, address_to, weight, date) values (?, ?, ?, ?, ?, ?, ?)"
        cursor.execute(add_to_table, (_unique_id, _city_from, _address_from, _city_to, _address_to, _date, _weight))
        sqliteConnection.commit()
        cursor.close()

                              
    # -------------- data creation --------------------    
    # Индекс сквозной нумерации
    def index_func(self):
        if self.employe_index == None:
            self.employe_index = 1               
        else:
            self.employe_index += 1 
        return self.employe_index    


    # Собираем результат
    def main(self):
        self.create_db()
        for i in range(1,101,1):
            city = get_city()
            address = get_address()
            w = generate_weight(1,100,1)
            d = generate_date()
            uniq_id = generate_unigue_id()
            self.insert_date_db(uniq_id, city['city_from'], address['address_from'],
                                city['city_to'], address['address_to'], w, d)
        print('done')
        


my_var = Order()
my_var.main()

