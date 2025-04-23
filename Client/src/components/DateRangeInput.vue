<template>
    <div class="date-range-input">
        <label for="start-date">選擇起始日期：</label>
        <Datepicker 
            v-model="startDate" 
            :multi-calendars="2"
            :range="true"
            :inline="true"
            @change="emitDateRange" 
        />
        <label for="end-date">選擇結束日期：</label>
        <Datepicker 
            v-model="endDate" 
            :multi-calendars="2"
            :range="true"
            :inline="true"
            @change="emitDateRange" 
        />
    </div>
</template>

<script setup>
import { ref, defineEmits } from "vue";
import Datepicker from "vue3-datepicker"; // 匯入 vue3-datepicker

const startDate = ref("");
const endDate = ref("");
const emit = defineEmits(["update:dateRange"]);
const dateFormat = "YYYY-MM-DD"; // 設定日期格式

// 禁用今天之前的日期
const disablePastDates = {
    to: new Date(new Date().setDate(new Date().getDate() - 1)),
};

function emitDateRange() {
    emit("update:dateRange", { startDate: startDate.value, endDate: endDate.value });
}
</script>

<style scoped>
.date-range-input {
    margin: 1rem 0;
    display: flex;
    align-items: center;
    gap: 1rem;
}

label {
    margin-right: 0.5rem;
}
</style>