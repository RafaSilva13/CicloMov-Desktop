<?php
include 'bootstrap/header.php';
include 'conexao.php'; ?>

<div class="container">
    <div class="d-flex justify-content-center flex-wrap gap-3">

        <?php

        if (!$conn) {
            die("Connection failed: " . mysqli_connect_error());
        }

        $sql = "SELECT cod_ponto, vagas_livres_ponto, vagas_totais_ponto, descricao, mapa FROM pontos";
        $result = mysqli_query($conn, $sql);

        if (mysqli_num_rows($result) > 0) {
            // output data of each row
            while ($row = mysqli_fetch_assoc($result)) { ?>



                <div class="card" style="width: 16rem; margin-top: 30px;">
                    <iframe src="<?php echo $row['mapa']; ?>" style="border:0; whidt=100% " allowfullscreen="" loading="fast" referrerpolicy="no-referrer-when-downgrade"></iframe>
                    <div class="card-body">
                        <h6 class="card-text" style="font-size: 20px; color: rgb(62, 122, 122); text-align: center;"><?php echo $row['descricao']; ?></h6>
                    </div>
                </div>



        <?php }
        } else {
            echo "0 results";
        }

        mysqli_close($conn);
        ?>
    </div>
</div>

<?php
include 'bootstrap/footer.php';
?>