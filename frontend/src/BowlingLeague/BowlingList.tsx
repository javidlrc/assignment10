import { useEffect, useState } from 'react';
import { Bowlers } from '../types/BowlingLeague';

function BowlingList() {
  const [BowlingData, setBowlingData] = useState<Bowlers[]>([]);

  useEffect(() => {
    const fetchBowlers = async () => {
      const rsp = await fetch('http://localhost:5095/api/bowlingleague');
      const b = await rsp.json();
      setBowlingData(b);
    };
    fetchBowlers();
  }, []);

  return (
    <div>
      <div className="row">
        <h4 className="text-center">Bowling List:</h4>
      </div>
      <table className="table table-bordered">
        <thead>
          <tr>
            <th>Bowler Last Name</th>
            <th>Bowler First Name</th>
            <th>Bowler Middle Name</th>
            <th>Bowler Address</th>
            <th>Bowler City</th>
            <th>Bowler State</th>
            <th>Bowler Zip</th>
            <th>Bowler Phone Number</th>
            <th>Bowler Team</th>
          </tr>
        </thead>
        <tbody>
          {BowlingData.map((b) => (
            <tr key={b.bowlerID}>
              <td>{b.bowlerLastName}</td>
              <td>{b.bowlerFirstName}</td>
              <td>{b.bowlerMiddleInit}</td>
              <td>{b.bowlerAddress}</td>
              <td>{b.bowlerCity}</td>
              <td>{b.bowlerState}</td>
              <td>{b.bowlerZip}</td>
              <td>{b.bowlerPhoneNumber}</td>
              <td>{b.team.teamName}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}

export default BowlingList;
