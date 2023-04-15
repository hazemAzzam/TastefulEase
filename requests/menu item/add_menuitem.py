import requests
import json 

headers = {
    "Content-Type": "application/json"
}

data = {
        "name": "Twister Chilla Box",
        "description": "3 twister sandwiches, 6 pieces of chicken, family french fries and pepsi liter.",
        "price": 385,
        "image": "https://kfcprodnecmsimage.azureedge.net/cmsimages/egy/desktop/imagestemp/1-Combo.png",
        "categories": [
            {"name": "Burgers"},
            {"name": "Classics"}
        ]
    }

res = requests.post("http://127.0.0.1:8000/api/menu_items/", data=json.dumps(data), headers=headers)
print(res.content)