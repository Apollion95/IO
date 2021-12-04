import React from 'react'
import {FaBars} from 'react-icons/fa'
import {
    Nav, 
    NavbarContainer, 
    NavLogo, 
    MobileIcon, 
    NavMenu, 
    NavItem, 
    NavLinks,
    NavBtn,
    NavBtnLink
} from './NavbarElements'

const Navbar = ({ isOpen,toggle }) => {
    return (
        <>
            <Nav>
                <NavbarContainer>
                    <NavLogo to='/'>TIMBER</NavLogo>
                    <MobileIcon onClick={toggle}>
                        <FaBars />
                    </MobileIcon>
                    <NavMenu>
                        <NavItem>
                            <NavLinks to="/about">O APLIKACJI</NavLinks>
                        </NavItem>
                        <NavItem>
                            <NavLinks to="/discover">ODKRYWAJ</NavLinks>
                        </NavItem>
                        <NavItem>
                            <NavLinks to="/signup">REJESTRACJA</NavLinks>
                        </NavItem>
                    </NavMenu>
                        <NavBtn>
                            <NavBtnLink to="/signin">LOGOWANIE</NavBtnLink>
                        </NavBtn>
                </NavbarContainer>
            </Nav>
        </>
    )
}

export default Navbar
