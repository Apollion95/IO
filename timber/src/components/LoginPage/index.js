import React from 'react'
import { Container, FormWrap, Icon, FormContent, Form, FormInput, FormH1, FormLabel, FormButton, Text } from './LoginInElements' 
import React, {useState} from 'react'

const Login = (props) => {
const [email, setEmail] = useState('');


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