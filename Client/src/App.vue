<script setup>
    import HelloWorld from "./components/HelloWorld.vue";
    import TheWelcome from "./components/TheWelcome.vue";
    import AiChatInput from "./components/AiChatInput.vue";
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
