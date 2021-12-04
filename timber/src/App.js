import React, { useState }  from 'react'
import './App.css'
import {BrowserRouter as Router, Routes, Route} from 'react-router-dom'
import Sidebar from './components/Sidebar'
import Navbar from './components/Navbar'
import Home from './pages'
import About from './pages/about'
import Discover from './pages/discover'
import LoginIn from './components/LoginPage'
import Register from './components/RegistrationPage'

function App() {
  const [isOpen, setIsOpen] = useState(false);

  const toggle = () =>{
    setIsOpen(!isOpen);
  }

  return (
    <>
      <Router>
        <Sidebar isOpen={isOpen} toggle={toggle} />
        <Navbar toggle={toggle}/>
        <Routes>
          <Route path='/' element={<Home />} />
          <Route path='/about' element={<About />} />
          <Route path='/discover' element={<Discover />} />
          <Route path='/signup' element={<Register />} />
          <Route path='/signin' element={<LoginIn />} />
        </Routes>
      </Router>
    </>
  )
}

export default App
