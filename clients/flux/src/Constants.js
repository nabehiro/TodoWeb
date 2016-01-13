const ActionTypes = [
  'LOAD',
  'COMPLETE',
  'DESTROY',
  'ADD'
].reduce((obj, str) => {
  obj[str] = str
  return obj
}, {})

export { ActionTypes }
