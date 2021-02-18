const App = {
    data: () => ({
        myHtml: '<h1>Vue 3 App</h1>',
        title: 'Я есть Грут',
        person: {
            firstName: 'Ravil',
            lastName: 'Garayev',
            age: 32
        },
        info: null,
        items: [1, 2]
    }),
    methods: {
        addItem() {
            this.items.unshift(this.$refs.myInput.value)
            this.$refs.myInput.value = ''
        },
        remove(i) {
            this.items.splice(i, 1)
        },
        log(item) {

        },
        test() {
            alert("asdasdasdasd");
        },
        getBankName() {
            alert("aaaaa");
            axios.get('http://localhost:56026/api/users').then(res => {
                console.log(res); // Результат ответа от сервера
            });
        }
    },
    computed: {
        evenItems() {
            return this.items.filter(i => i % 2 == 0)
        }
    }
}

Vue.createApp(App).mount('#app')

