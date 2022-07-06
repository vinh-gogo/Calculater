
## Solution

```cpp
void slpit2(char str[], char left[], char right[], char dau) {
	int index=0;
	for(index; index<strlen(str) ; index++) {
		if(isdigita(str[index])) {
			left[index] = str[index];
			cout<<"lesft: "<<str[index];
		} else {
			index += 1;
			int inj = 0;
			for(index; index<strlen(str);index++){
				right[inj] = str[index];
				inj += 1;
			}
			return;
		}	
	}
}
```