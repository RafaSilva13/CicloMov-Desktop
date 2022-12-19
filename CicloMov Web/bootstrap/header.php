<!doctype html>
<html lang="pt-br">

<head>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <title>Ciclomov</title>
  <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-rbsA2VBKQhggwzxH7pPCaAqO46MgnOM80zW1RWuH61DGLwZJEdK2Kadq2F9CUG65" crossorigin="anonymous">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js"></script>
  <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-iYQeCzEYFbKjA/T2uDLTpkwGzCiq6soy8tYaI1GyVh/UjpbCx/TYkiZhlZB6+fzT" crossorigin="anonymous">
  <link rel="stylesheet" href="css/style.css">
</head>

<body>
  <!-- navbar  -->
  <nav class="navbar navbar-expand-lg " style="background-color: rgb(42, 79, 102);">
    <div class="container-fluid">
      <a class="navbar-brand" href="index.php"><img src="img/logo.png" alt="" style="width:37px;"></a>
      <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
        <span class="navbar-toggler-icon"></span>
      </button>
      <div class="collapse navbar-collapse" id="navbarSupportedContent">
        <ul class="navbar-nav me-auto mb-2 mb-lg-0">
          <li class="nav-item">
            <a class="nav-link active" aria-current="page" href="index.php" style="color: white;">Home</a>
          </li>
          <li class="nav-item">
            <a class="nav-link active" aria-current="page" href="pontos.php" style="color: white;">Pontos</a>
          </li>
          <li class="nav-item">
            <a class="nav-link active" href="sobre.php" style="color: white;">Sobre nós</a>
          </li>
        </ul>

        <?php
          session_start();
            if(!isset($_SESSION["login"]) || $_SESSION["login"] == 0) {
        ?>
          <div class="d-flex gap-4" role="search">
            <a class="btn btn-light btn-sm btnlogin" href="login.php" type="button">Login</a>
          </div>
        <?php
          } 
          else {
        ?>

          <div class="d-flex gap-4" role="search">
            <a class="btn btn-danger btn-sm btnsair" href="login.php" type="button">Sair</a>
          </div>

        <?php
          }
        ?>
      </div>
    </div>
  </nav>

</html>
<!-- fim da navbar  -->
