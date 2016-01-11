import React from 'react'
import AddTodo from './AddTodo'
import TodoList from './TodoList'

export default class TodoApp extends React.Component {
  render() {
    return (
      <div>
        <h1>flux</h1>
        <AddTodo/>
        <TodoList/>
      </div>
    )
  }
}
