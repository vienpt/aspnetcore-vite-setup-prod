<template>
  <img alt="Vue logo" src="./assets/logo.png" />
  <HelloWorld msg="Hello Vue 3 + Vite" />
  <span> Message here: {{ state.message }}</span>
  <!-- <span> Custom message here: {{ state.customMessage }}</span> -->
</template>

<script setup>
import HelloWorld from './components/HelloWorld.vue'
import { reactive } from "vue";

// This starter template is using Vue 3 experimental <script setup> SFCs
// Check out https://github.com/vuejs/rfcs/blob/master/active-rfcs/0040-script-setup.md

const state = reactive({
  message: '',
  customMessage: '',
})


fetch('/api/message')
  .then(res => res.text())
  .then(t => state.message = t)


</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
