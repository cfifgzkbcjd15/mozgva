const routes=[
    { path:'/product',component:product}
]

const router=new VueRouter({
    routes
})

const app = new Vue({
    router
}).$mount('#app')