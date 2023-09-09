import React, { useEffect, useState } from 'react';

function EmployeeList() {
  const [employees, setEmployees] = useState([]);
const url='https://localhost:7054/Home/employee';

useEffect(() => {
        async function getData() {
            const response = await fetch(url)
            const data = await response.json()
            setEmployees(data)
        }
        getData();
    }, []);

  return (
    <div class="container">
      <h1 class="text-center">Employee List</h1>

    <table class="table table-bordered">
      <thead>
        <tr>
          <th>ID</th>
          <th>First Name</th>
          <th>Last Name</th>
          <th>Emmail Address</th>
        </tr>
      </thead>
      <tbody>
      {employees.map(employee => (
        <tr>
          <td>{employee.id}</td>
          <td>{employee.first_name}</td>
          <td>{employee.last_name}</td>
          <td>{employee.address}</td>
        </tr>
        ))}
      </tbody>
    </table>
    </div>
  );
}

export default EmployeeList;