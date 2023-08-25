import random
from datetime import timedelta
import datetime
import uuid



# Alabama US cityes list 
cityes = ['AlexanderCity','Andalusia','Anniston','Athens','Atmore','Auburn','Bessemer','Birmingham',
'Chickasaw','Clanton','Cullman','Decatur','Demopolis','Dothan','Enterprise','Eufaula',
'Florence','FortPayne','Gadsden','Greenville','Guntersville','Huntsville','Jasper','Marion',
'Mobile','Montgomery','Opelika','Ozark','Phenix City','Prichard','Scottsboro','Selma','Sheffield',
'Sylacauga','Talladega','Troy','Tuscaloosa','Tuscumbia','Tuskegee']

addresses = ['address_1','address_2','address_3','address_4','address_5','address_6','address_7','address_8','address_9','address_10',
             'address_11','address_12','address_13','address_14','address_15','address_16','address_17','address_18','address_19','address_20',
             'address_21','address_22','address_23','address_24','address_25','address_26','address_27','address_28','address_29','address_30',
             'address_31','address_32','address_33','address_34','address_35','address_36','address_37','address_38','address_39','address_40',
             'address_41','address_42','address_43','address_44','address_45','address_46','address_47','address_48','address_49','address_50' ]


def get_city():
    result = {}
    city_from = random.choice(cityes)
    city_to = random.choice(cityes)
    if city_to == city_from:
        city_to = random.choice(cityes)
    result['city_from'] = city_from
    result['city_to'] = city_to
    return result
    
def get_address():
    result = {}
    address_from = random.choice(addresses)
    address_to = random.choice(addresses)
    if address_to == address_from:
        address_to = random.choice(addresses)
    result['address_from'] = address_from
    result['address_to'] = address_to
    return result

def generate_weight(start, stop, step):
    return random.randrange(start, stop, step)


def generate_date():
    start_dt = datetime.date(2023, 8, 1)
    end_dt = datetime.date(2024, 3, 31)
    time_between_dates = end_dt - start_dt
    days_between_dates = time_between_dates.days
    random_number_of_days = random.randrange(days_between_dates)
    date = str(start_dt + datetime.timedelta(days=random_number_of_days))
    return date

def generate_unigue_id():
    result = str(uuid.uuid4())
    return result
    
    
