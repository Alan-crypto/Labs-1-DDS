﻿<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
   <title>EliminarNum</title>
   <link href="C:\Users\Raya2\Documents\MVCPlantilla\Content\Site.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form action="/Principal/EliminarNum" method="post">
    <fieldset>
    <legend>Eliminar x numero de reproducciones</legend>
    <label for = "reproducciones">reproducciones</label>
    <input type="text" name="reproducciones" />
    <input type="submit"  value="Eliminar" />
    </fieldset>
    </form>
</body>
</html>
