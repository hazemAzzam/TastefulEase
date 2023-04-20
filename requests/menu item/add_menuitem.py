import requests
import json 

headers = {
    "Content-Type": "application/json"
}

data = {
        "name": "Mega Rizo",
        "description": "1 Rizo + 3 pcs of Strips + Sauce",
        "price": 110,
        "image": "https://kfcprodnecmsimage.azureedge.net/cmsimages/egy/desktop/imagestemp/148-Combo.png",
        "categories": [
            {"name": "Burgers"},
            {"name": "Classics"}
        ]
    }

res = requests.post("http://127.0.0.1:8000/api/menu-items/", data=json.dumps(data), headers=headers)
print(res.content)