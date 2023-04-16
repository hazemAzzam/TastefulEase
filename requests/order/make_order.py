import requests
import json
from datetime import datetime

headers = {
    "Content-Type": "application/json"
}

data = {
    "order_date": datetime.now().isoformat(),
    "customer": 1,
    "coupon": 2,
    "order_items": [
        {
            "menu_item": 1,
            "quantity": 2
        }
    ]
}


res = requests.post("http://127.0.0.1:8000/api/orders/", data=json.dumps(data), headers=headers)
print(res.status_code)