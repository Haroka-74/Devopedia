// Association: A loose relationship where two classes know each other but exist independently

using _02_Association.Models;

var doctor = new Doctor();
var patient = new Patient("John");

doctor.Treat(patient);