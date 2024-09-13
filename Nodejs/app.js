let express = require('express') 
let app = express() 
app.use(express.json())

//primer endpoint
app.get('/', (request, response)=> {
    console.log(request)
    response.send('hola mundo')
}) // esta barrita indica que vamos a acceder a otro recurso dentro del dominio (en nuestro caso es local) --> localhost:3000/

app.post('/', (request, response) => {
    console.log(request.body)
    response.send('hola mundo')
})

let alumnos =[
    {id: 1, nombre:"mariangel"},
    {id: 2, nombre:"taylor"},
    {id: 3, nombre:"aurora"}
]
app.get('/alumno', (req, res)=>{
    res.send(alumnos)
})

//agregar a un alumno nuevo
app.post('/alumno', (req, res)=>{
    let alumno = req.body
    alumnos.push(alumno)
    res.send(alumnos)
})

app.listen(3000)
