from django import forms
from database.models import MenuItem

class Home_Form(forms.ModelForm):
    class Meta:
        model = MenuItem
        fields = '__all__'
