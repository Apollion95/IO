import { Container, FormWrap, Icon, FormContent, Form, FormInput, FormH1, FormLabel, FormButton, Text } from './LoginInElements' 
import React, {useState} from 'react'

const Login = (props) => {
const [email, setEmail] = useState('');
const [password, setPassword] = useState('');
const [navigate, setNavigate] = useState('');

const submit = async (e) =>
{
  e.preventDefault(); 

  await fetch('http://localhost:8000/home/login', {
    method: 'POST',
    headers: {'Content-Type': 'application/json'},
    credentials: 'include',
    body: JSON.stringify({
      email,
      password
    })
  });
  props.setName('');

  setNavigate(true); 
}
    if(navigate) {
      return <Navigate to="/"/>
    }


const LoginIn = () => {
  return (
    <>
      <Container>
        <FormWrap>
          <Icon to='/'>Timber</Icon>
          <FormContent>
            <Form action='#'>
              <FormH1>Zaloguj się do swojego konta</FormH1>
              <FormLabel htmlFor='for'>Email</FormLabel>
                <FormInput htmlFor='email'/>
              <FormLabel htmlFor='for'>Hasło</FormLabel>
                <FormInput htmlFor='password'/>
              <FormButton  type='submit'>Zaloguj się</FormButton>
              <Text>Zapomniałeś Hasła?</Text>
            </Form>
          </FormContent>
        </FormWrap>
      </Container>
    </>
  )
}

export default LoginIn