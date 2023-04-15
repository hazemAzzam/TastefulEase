import requests
import json 

headers = {
    "Content-Type": "application/json"
}

data = {
   "first_name":"hazem",
   "last_name":"azzam",
   "phone_number":"01142221039",
   "password": "admin",
   "delivery_addresses": [
      {
         "street":"طريق المشير محمد عبد الحليم أبو غزالة",
         "city":"Badr City",
         "state":"Cairo",
         "zip_code": "11829"
      },
      {
         "street":"Villa 59",
         "city":"Badr City",
         "state":"Cairo",
         "zip_code": "11829"
      }
   ]
}

res = requests.post("http://127.0.0.1:8000/api/customers/", data=json.dumps(data), headers=headers)
print(res)

res = requests.get("http://127.0.0.1:8000/api/customers/")
print(res)