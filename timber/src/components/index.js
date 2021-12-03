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
                        <SidebarLink to='about'>About</SidebarLink>
                        <SidebarLink to='discover'>Discover</SidebarLink>
                        <SidebarLink to='services'>Services</SidebarLink>
                        <SidebarLink to='signup'>Sign up</SidebarLink>
                    </SidebarMenu>
                    <SideBtnWrap>
                        <SidebarRoute to='/signin'>Sign in</SidebarRoute>
                    </SideBtnWrap>
                </SidebarWrapper>
            </SidebarContainer> 
        </>
    )
}

export default Sidebar