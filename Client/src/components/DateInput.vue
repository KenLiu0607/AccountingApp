<template>
    <div class="date-input">
        <label for="date">選擇日期：</label>
        <Datepicker v-model="selectedDate" :format="dateFormat" @change="emitDate" />
    </div>
</template>

<script setup>
import { ref, defineEmits } from "vue";
import Datepicker from "vue3-datepicker"; // 匯入 vue3-datepicker

const selectedDate = ref("");
const emit = defineEmits(["update:date"]);
const dateFormat = "YYYY-MM-DD"; // 設定日期格式

function emitDate() {
    emit("update:date", selectedDate.value);
}
</script>

<style scoped>
.date-input {
    margin: 1rem 0;
}

label {
    margin-right: 0.5rem;
}
</style>