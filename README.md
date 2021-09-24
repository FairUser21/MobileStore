# MobileStore
Курсовая работа / Колледж КГУСТА 

Работает только в /dev режиме.

Для работы необходимо указывать вручную указать абсолютный путь соединения БД - (
  
  Необходимо во всех компонентах испавить абсолютные пути 
  
  SqlConnection Connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=/* ПУТЬ БД */;Integrated Security=True;Connect Timeout=30");

)
