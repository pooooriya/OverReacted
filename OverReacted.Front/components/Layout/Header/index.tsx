import Link from 'next/link'
import React, { useEffect, useState } from 'react'
import Toggle from 'react-toggle'
import { BsFillSunFill, BsFillMoonFill } from "react-icons/bs";
import { useRouter } from 'next/router';
import { useDispatch, useSelector } from 'react-redux';
import { RootState } from '../../../redux/store';
import { themeSwitcher } from '../../../redux/feature/themeSlice';
const Header = (): JSX.Element => {
    const currentTheme = useSelector((state: RootState) => state.theme);
    const [themes, setthemes] = useState(() => currentTheme?.value == 'light')

    const router = useRouter();
    const dispatch = useDispatch()
    const handleToggle = (e: any) => {
        if (e.target.checked) {
            dispatch(themeSwitcher({ value: 'light' }))
        } else {
            dispatch(themeSwitcher({ value: 'dark' }))
        }
        setthemes(e.target.checked)
    }

    return (
        <div className='flex flex-1 justify-between items-baseline'>
            <Link href='/'>
                <h1 className='font-extrabold text-4xl dark:text-white' style={{ color: `${router.pathname != '/' && "#d23669"}` }}>Overreacted</h1>
            </Link>
            <Toggle
                defaultChecked={themes}
                icons={{ checked: <BsFillSunFill color='#FFFF00' />, unchecked: <BsFillMoonFill color='#FFFF00' size={12} /> }}
                onChange={handleToggle}
                id='cheese-status'
            />
        </div>
    )
}

export default Header