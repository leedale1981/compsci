const sort = (list) => {
    for (let index = 0; index < list.length; index++) {
        let currentValue = list[index];
        let position = index;

        while (position > 0 && list[position -1] > currentValue) {
            list[position] = list[position -1];
            position = position - 1;
        }

        list[position] = currentValue;
    }
}