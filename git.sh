#!/bin/sh
git status
echo "\n\nコミットコメントを入力>>\n"
read comment
git add .
git commit -m "$comment"
git push

