/** @type {import('next').NextConfig} */
const nextConfig = {
    experimental: {
        serverActions: true
    },
    images: {
        domains: [
            "cdn.pixabay.com",
            "upload.wikimedia.org"
        ]
    },
    output: "standalone"
}

module.exports = nextConfig
