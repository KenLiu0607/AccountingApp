<script setup>
    import HelloWorld from "./components/HelloWorld.vue";
    import TheWelcome from "./components/TheWelcome.vue";
    import AiChatInput from "./components/AiChatInput.vue";
    import DateInput from "./components/DateInput.vue";
    import DateRangeInput from "./components/DateRangeInput.vue"; // 新增組件匯入

    import { ref } from "vue";

    const selectedDate = ref("");
    const selectedDateRange = ref({ startDate: "", endDate: "" });

    function handleDateChange(date) {
        selectedDate.value = date;
        console.log("選擇的日期是：", date);
    }

    function handleDateRangeChange(dateRange) {
        selectedDateRange.value = dateRange;
        console.log("選擇的日期範圍是：", dateRange);
    }
</script>

<template>
    <header>
        <img alt="AI logo" class="logo" src="./assets/1744645610665.png" width="125" height="125" />
        <h2 class="text-lg font-semibold">與AI對話💬</h2>
        <!-- <div class="wrapper">
            <HelloWorld msg="You did it!" />
        </div> -->
    </header>
    <br />
    <main>
        <!-- <TheWelcome /> -->
        <AiChatInput />
        <DateInput @update:date="handleDateChange" />
        <p v-if="selectedDate">您選擇的日期是：{{ selectedDate }}</p>
        <DateRangeInput @update:dateRange="handleDateRangeChange" /> <!-- 新增日期範圍選擇器 -->
        <p v-if="selectedDateRange.startDate && selectedDateRange.endDate" style="color:aliceblue">
            您選擇的日期範圍是：{{ selectedDateRange.startDate }} 至 {{ selectedDateRange.endDate }}
        </p>
    </main>
</template>

<style scoped>
    header {
        line-height: 1.5;
    }

    .logo {
        display: block;
        margin: 0 auto 2rem;
    }

    @media (min-width: 1024px) {
        header {
            display: flex;
            place-items: center;
            padding-right: calc(var(--section-gap) / 2);
        }

        .logo {
            margin: 0 2rem 0 0;
        }

        header .wrapper {
            display: flex;
            place-items: flex-start;
            flex-wrap: wrap;
        }
    }
</style>
