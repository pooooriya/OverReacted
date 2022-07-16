import type { GetStaticProps, NextPage } from 'next'
import Bio from '../components/Bio'
import Layout from '../components/Layout'
import Post from '../components/Post'
import { API_HOST_URL } from '../config'

interface PageProp {
  Posts: PostType[]
}

const Home: NextPage<PageProp> = ({ Posts }) => {
  return (
    <Layout>
      <Bio />
      <div className="mt-5">
        {Posts.map(post => (
          <Post id={post.id} datail={post.createdAt} headline={post.title} description={post.shortDescription} key={post.id} time={post.estimationReadTime}/>
        ))}
      </div>
    </Layout>
  )
}

export const getStaticProps: GetStaticProps = async () => {
  const response = await fetch(`${API_HOST_URL}/api/blog/posts`)
  const posts: PostType[] = await response.json();
  return {
    props: {
      Posts: posts || null
    }
  }
}


export default Home
