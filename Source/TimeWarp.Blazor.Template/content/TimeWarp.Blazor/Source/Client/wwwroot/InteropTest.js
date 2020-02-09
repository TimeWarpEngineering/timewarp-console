const dispatchIncrementCountAction = () => {
  console.log("%cdispatchIncrementCountAction", "color: green");
  const IncrementCountActionName = "TimeWarp.Blazor.CounterFeature.CounterState+IncrementCounterAction, TimeWarp.Blazor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null";
  const blazorState = window["BlazorState"];
  blazorState.DispatchRequest(IncrementCountActionName, { amount: 7 });
};

function initialize() {
  console.log("Initialize InteropTest.js");
  window["InteropTest"] = dispatchIncrementCountAction;
}

initialize();