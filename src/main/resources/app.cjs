const express = require('express')
const mysql = require('mysql')

const app = express()
const port = process.env.PORT || 5000

const pool = mysql.createPool({
    connectionLimit : 10,
    host            : 'localhost',
    user            : 'root',
    password        : '',
    database        : 'nodejs_beers'
})

TestFunction()
var data;
function TestFunction(){
    pool.getConnection((err, connection) => {
        if(err) throw err
        console.log(`connected as id ${connection.threadId}`)

        connection.query('SELECT description, id FROM beers', (err, rows) => {
            connection.release()
            data = rows;
            if(!err){
                console.log(rows);
            }else{
                console.log(err)
            }
                
        })
    })
}

module.export; {data};