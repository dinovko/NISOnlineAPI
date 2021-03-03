//const App = {
//    data: () => ({
//        myHtml: '<h1>Vue 3 App</h1>',
//        title: 'Я есть Грут',
//        person: {
//            firstName: 'Ravil',
//            lastName: 'Garayev',
//            age: 32
//        },
//        info: "Tom",
//        items: [1, 2]
//    }),
//    methods: {
//        addItem() {
//            this.items.unshift(this.$refs.myInput.value)
//            this.$refs.myInput.value = ''
//        },
//        remove(i) {
//            this.items.splice(i, 1)
//        },
//        log(item) {

//        },
//        getBankName() {
//            alert("aaaaa");

//            const response = fetch("/api/users", {
//                method: "GET",
//                headers: { "Accept": "application/json" }
//            });
//            console.log(response);
//            // если запрос прошел нормально
//            if (response.ok === true) {
//                // получаем данные
//                const users = response.json();  
//                var aaa = response.json();

//                console.log(aaa);
//                info = aaa;
//                let rows = document.querySelector("tbody");
//                users.forEach(user => {
//                    // добавляем полученные элементы в таблицу
                    
//                    rows.append(row(user));
//                });
//            }
//        }
//    },
//    computed: {
//        evenItems() {
//            return this.items.filter(i => i % 2 == 0)
//        }
//    }
//}

//Vue.createApp(App).mount('#app')