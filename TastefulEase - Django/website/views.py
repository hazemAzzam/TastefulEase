from django.shortcuts import render
from database.models import MenuItem
import requests
from .forms import Home_Form
from django.views import View
from django.http import JsonResponse


class ManuItem_Add_View(View):
    template_name = 'home.html'

    def get(self, request):
        form = Home_Form()
        return render(request, self.template_name, { 'form': form })
    
    def post(self, request):
        form = Home_Form(request.POST)
        if form.is_valid():
            form.save()
        return render(request, self.template_name, {'form': form})
    

class Home_View(View):
    template_name = 'home.html'
    api_url = 'http://127.0.0.1:8000/api/menu-items/'

    def get(self, request):
        response = requests.get(self.api_url)
        menu_items = response.json()
        return render(request, self.template_name, {'menu_items': menu_items})
    
    def post(self, request):
        menu_item = request.POST.get('menu_item')
        
        # Process the menu_item_id as needed
        cart_items = request.session.get('cart_items', [])
        cart_items.append(menu_item)
        request.session['cart_items'] = cart_items
        
        print(cart_items)

        response = {
            'status': 'success',
            'message': 'Item added to cart!',
            'number_of_items': len(cart_items),
        }
        
        return JsonResponse(response)