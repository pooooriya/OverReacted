import React from 'react'
import Header from './Header'

interface Props {
    children: React.ReactNode
}

const Layout = ({ children }: Props): JSX.Element => {
    return (
        <div className="dark:bg-gray-800" style={{ transition: "background .3s" }}>
            <div className='w-[42rem] max-w-full mx-auto py-10 px-5 md:px-0 min-h-screen '>
                <Header />
                {children}
            </div>
        </div>
    )
}

export default Layout