import React, {useState} from 'react'
import { Container, FormWrap, Icon, FormContent, Form, FormInput, FormH1, FormLabel, FormButton } from './RegistrationElements' 


const Register = () => {
  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');
  const [navigate, setNavigate] = useState('');

  return (
    <>
      <Container>
        <FormWrap>
          <Icon to='/'>Timber</Icon>
          <FormContent>
            <Form action='#'>
              <FormH1>Załóż swoje konto</FormH1>
              <FormLabel htmlFor='for'>Email</FormLabel>
                <FormInput htmlFor='email'/>
              <FormLabel htmlFor='for'>Hasło</FormLabel>
                <FormInput htmlFor='password'/>
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