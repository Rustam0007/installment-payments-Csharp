<p>Для начала убедитесь что у вас установлен Postgres. После этого откройте терминал и выполните следующие действия:</p>

<span>1) <code>psql -U postgres</code></span><br>
<span>2) <code>CREATE DATABASE northwind;</code></span><br>
<span>3) <code>CREATE USER postgres WITH PASSWORD '007012002'</code></span><br>
<span>4) <code>GRANT ALL PRIVILEGES ON DATABASE northwind TO postgres;
</code></span><br>
<span>5) <code>Выйдите из интерактивной оболочки PostgreSQL, введя команду: "\q"</code></span><br>

<p>После этих действии зайдите на проект который брали с Github и запустите SQL скрипт <b>"create_db.sql"</b> чтобы создать нужные для работы таблицы</p>
<p>Теперь можно запустить файл из Main класса в файле Program.cs</p>


