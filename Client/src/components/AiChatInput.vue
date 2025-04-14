<template>
    <div class="p-4 border rounded-lg shadow-md max-w-md mx-auto space-y-4">
      
        <textarea v-model="message" placeholder="輸入記帳語句，例如：今天花了 60 元買早餐" class="w-full p-2 border rounded" rows="3"></textarea>
        <div>
            <button @click="sendMessage" :disabled="loading || !message.trim()">
                {{ loading ? "處理中..." : "送出" }}
            </button>
        </div>
        <div v-if="response" class="bg-gray-100 p-3 rounded">
            <strong>AI 回覆：</strong>
            <p>{{ response }}</p>
        </div>
    </div>
</template>

<script setup>
    import { ref } from "vue";
    import axios from "axios";

    const message = ref("");
    const response = ref("");
    const loading = ref(false);

    async function getTransactions() {
        try {
            const result = await axios.get("/api/Accounting/Transactions");
            console.log(result.data);
        } catch (err) {
            console.error(err);
            return null;
        }
    }
    getTransactions();
    // const sendMessage = async () => {
    //     if (!message.value.trim()) return;

    //     loading.value = true;
    //     response.value = "";
    //     try {
    //         const res = await axios.post("/api/chat", { message: message.value });
    //         response.value = res.data.reply;
    //     } catch (err) {
    //         response.value = "發生錯誤，請稍後再試。";
    //         console.error(err);
    //     } finally {
    //         loading.value = false;
    //     }
    // };
</script>
