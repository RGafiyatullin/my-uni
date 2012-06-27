#!/bin/bash

ARITH_TYPES="Int16 Int32 Int64 Single Double Decimal"

function generate_for_op() {
	local op=$1
	for t in $ARITH_TYPES; do 
		echo -e "\t\t\tif ( t == typeof(${t}) ) return (T) Convert.ChangeType( (${t})a ${op} (${t})b, typeof(T) );"
	done
}

: > src/ArithHack.cs
cat src/ArithHack.cs.template.1 >> src/ArithHack.cs
generate_for_op '+' >> src/ArithHack.cs
cat src/ArithHack.cs.template.2 >> src/ArithHack.cs
generate_for_op '*' >> src/ArithHack.cs
cat src/ArithHack.cs.template.3 >> src/ArithHack.cs
generate_for_op '-' >> src/ArithHack.cs
cat src/ArithHack.cs.template.4 >> src/ArithHack.cs