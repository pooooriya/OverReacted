import Image from 'next/image'
import React from 'react'

const Bio = (): JSX.Element => {
    return (
        <div className='flex mt-10'>
            <div className='relative w-[50px] h-[50px] rounded-full overflow-hidden'>
                <Image layout='fill' src='/danabramov.jpg' />
            </div>
            <div className='ml-2 font-normal text-md dark:text-gray-300 '>
                <h2>Personal blog <a className='text-red-500 underline hover:no-underline dark:text-darkprimary' href='https://mobile.twitter.com/dan_abramov' target='_blank' rel="noreferrer">by Dan Abramov.</a></h2>
                <h2>I explain with words and code.</h2>
            </div>
        </div>
    )
}

export default Bio