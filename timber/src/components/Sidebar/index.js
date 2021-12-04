import React from 'react'
import { 
    SidebarContainer, 
    Icon, 
    CloseIcon, 
    SidebarWrapper, 
    SidebarMenu, 
    SidebarLink, 
    SidebarRoute, 
    SideBtnWrap 
} from './SidebarElements'

const Sidebar = ({ isOpen, toggle }) => {
    return (
        <>
            <SidebarContainer isOpen = {isOpen} onClick={toggle}>
                <Icon onClick={toggle}>
                    <CloseIcon />
                </Icon>
                <SidebarWrapper>
                    <SidebarMenu>
                        <SidebarLink to='about' onClick={toggle}>O APLIKACJI</SidebarLink>
                        <SidebarLink to='discover' onClick={toggle}>ODKRYWAJ</SidebarLink>
                        <SidebarLink to='signup' onClick={toggle}>REJESTRACJA</SidebarLink>
                    </SidebarMenu>
                    <SideBtnWrap>
                        <SidebarRoute to='/signin'>LOGOWANIE</SidebarRoute>
                    </SideBtnWrap>
                </SidebarWrapper>
            </SidebarContainer> 
        </>
    )
}

export default Sidebar