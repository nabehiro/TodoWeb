import React from 'react'

export default class AddTodo extends React.Component {
  render() {
    return (
      <div>
        <h2>Add Todo</h2>
        <form id="add-form">
          <input type="text" name="title" id="title" />
          <input type="submit" value="add" />
        </form>
      </div>
    )
  }
}
