<?php

fatorial(2);
public function fatorial($n) {
  $n = $n;
  while ($n !== 0) {
    $n = $n * ($n - 1);
  }
}