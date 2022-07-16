import React from 'react'
import { GetStaticProps, NextPage } from 'next'
import Layout from '../../components/Layout';
import Bio from '../../components/Bio';
import Link from 'next/link';
import { API_HOST_URL } from '../../config';

interface PageProp {
    Post: PostType
}

const Post: NextPage<PageProp> = ({ Post }): JSX.Element => {
    return (
        <Layout>
            <h1 className="text-3xl font-extrabold mt-14 dark:text-white">{Post.title}</h1>
            <p className="font-normal mt-5 dark:text-gray-300">{Post.body}</p>
            <Bio />
            <Link href="/" >
                <div className="mt-5 text-primary underline cursor-pointer hover:no-underline dark:text-darkprimary">
                    Return To HomePage
                </div>
            </Link>
        </Layout>
    )
}
export default Post

export async function getStaticPaths() {
    const response = await fetch(`${API_HOST_URL}/api/blog/posts`)
    const posts: PostType[] = await response.json();
    const paths = posts.map((post) => { return { params: { id: `${post.id}` } } });
    return { paths, fallback: false }
}

export const getStaticProps: GetStaticProps = async ({ params }) => {
    const response = await fetch(`${API_HOST_URL}/api/blog/post/` + params?.id)
    const post: PostType[] = await response.json();
    return { props: { Post: post || null } }
}
