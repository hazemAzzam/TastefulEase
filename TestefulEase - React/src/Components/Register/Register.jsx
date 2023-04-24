import axios from 'axios';
import React, { useState } from 'react';
import {useNavigate} from 'react-router-dom';
import Joi from 'joi';

export default function Register() {

  let navigate = useNavigate();
  const [errorList, setErrorList] = useState([]);
  const [isLoading, setIsLoading] = useState(false);
  const [error, setError] = useState('');
  const [user, setUser] = useState({
    first_name: '',
    last_name: '',
    phone_number: 0,
    password:''
  })

function getUserData(e){
  let myUser = {...user};
  myUser[e.target.name] = e.target.value;
  setUser(myUser);
}

async function sendRegisterDataToApi(){
  let {data} = await axios.post(`http://localhost:8000/api/customers/`, user);
  console.log(data);
  if(data.message == 'success'){
    setIsLoading(false);
    //Login
    navigate('/login');
  }
  else {
    setError(data.message);
    setIsLoading(false);
  }
}
function submitRegisterForm(e){
  e.preventDefault();
  setIsLoading(true);
  let validation = validateRegisterForm();
  if(validation.error){
    setIsLoading(false);
    setErrorList(validation.error.details);
  }
  else{
    sendRegisterDataToApi();
  }
}

function validateRegisterForm(){
 const schema = Joi.object({
    first_name:Joi.string().min(3).max(10).required(),
    last_name:Joi.string().min(3).max(10).required(),
    phone_number:Joi.number().min(11).required(),
    password:Joi.string().pattern(/^[A-Z][a-z]{3,6}/),
  })
  return schema.validate(user,{abortEarly:false});
}

  return <>

  {errorList.map((err,index)=> {
    if(err.context.label === 'password'){
      return <div key={index} className="alert alert-danger my-2">Password invalid</div>
    }
    else {
      return <div key={index} className="alert alert-danger my-2">{err.message}</div>
    }
  } )} 


  {error.length > 0 ? <div className="alert alert-danger my-2">{error}</div>: ''}
  
  <form onSubmit={submitRegisterForm}  className='px-5'>
    <label htmlFor="first_name" className='fw-bolder fs-5'>First_name :</label>
    <input onChange={getUserData} type="text" placeholder='Enter Your First_name' className='form-control my-input my-3' name='first_name' id='first_name' />

    <label htmlFor="last_name" className='fw-bolder fs-5'>Last_name :</label>
    <input onChange={getUserData} type="text" placeholder='Enter Your Last_name' className='form-control my-input my-3' name='last_name' id='last_name' />

    <label htmlFor="phone_number" className='fw-bolder fs-5'>phone_number :</label>
    <input onChange={getUserData} type="text" placeholder='Enter Your Phone Number' className='form-control my-input my-3' name='phone_number' id='phone_number' />

    <label htmlFor="password" className='fw-bolder fs-5'>Password :</label>
    <input onChange={getUserData} type="password" placeholder='Enter Your Password' className='form-control my-input my-3' name='password' id='password' />

    <button type='submit' className='btn btn-danger my-2'>
      {isLoading == true? <i className='fas fa-spinner fa-spin'></i>:'Register'}
    </button>

  </form>
  
  </>
}
