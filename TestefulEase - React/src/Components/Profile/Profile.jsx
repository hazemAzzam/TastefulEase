import React from 'react';

export default function Profile({userData}) {

  let {first_name , last_name , phone_number } = userData;
  return <>

    <h4 className='py-3 mt-5'>Name : {first_name} {last_name}</h4>
    <h4 className='py-3'>Phone Number : {phone_number}</h4>
  
  </>
}
