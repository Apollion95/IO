import React, {useState} from 'react'
import { Container, FormWrap, Icon, FormContent, Form, FormInput, FormH1, FormLabel, FormButton } from './RegistrationElements' 


const Register = () => {
  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');
  const [navigate, setNavigate] = useState('');

  const submit = async (e) =>
  {
    e.preventDefault(); 

    await fetch('http://localhost:8000/api/register', {
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

  return (
    <>
      <Container>
        <FormWrap>
          <Icon to='/'>Timber</Icon>
          <FormContent>
            <Form onSubmit={submit}>
              <FormH1>Załóż swoje konto</FormH1>
              <FormLabel htmlFor='for'>Email</FormLabel>
              <FormInput type="email" required 
                onChange={e => setEmail(e.target.value)} />
              <FormLabel htmlFor='for'>Hasło</FormLabel>
              <FormInput type="password" required 
                onChange={e => setPassword(e.target.value)} />
              <FormLabel htmlFor='for'>Powtórz Hasło</FormLabel>
                <FormInput htmlFor='password'/>
              <FormButton  type='submit'>Zarejestruj się</FormButton>
            </Form>
          </FormContent>
        </FormWrap>
      </Container>
    </>
  )
}

export default Register