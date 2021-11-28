const routes=[
    { path:'/my-games',component:games},
    { path: '/user', component: user },
    { path: '/gift-card', component: giftCard }
]

const router=new VueRouter({
    routes
})

const app = new Vue({
    router
}).$mount('#app')