#!/bin/bash -e

./build.sh Debug

if hash fsharpi &> /dev/null ; then
  rlwrap -t dumb fsharpi --use:Infers.Toys.fsx
else
  rlwrap -t dumb fsianycpu.exe --use:Infers.Toys.fsx
fi
