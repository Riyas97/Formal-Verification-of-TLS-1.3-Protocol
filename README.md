# Formal-Verification-of-TLS-1.3-Protocol
Formal Verification of TLS 1.3 (Key Exchange) Protocol using Process Analysis Toolkit (PAT)

## Project Description

Transport Layer Security, TLS is a protocol designed to build a secure communication channel
between the Client and the Server. The communication is secure because symmetric
cryptography is used to encrypt the data transmitted. The keys are uniquely generated for each
connection and are based on a shared secret, negotiated at the beginning of the session, also
known as a TLS handshake.

Overall, the Client and Server shall use an asymmetric encryption technique (e.g., RSA and DH
key exchange protocol) to create a shared secret during each session. With the shared secret, both
peers use a symmetric encryption technique (e.g., AES) to build the encrypted communication
channel.

In this project, the main aim is to construct a CSP concurrent model comprising of a parallel & concurrent running server and client to simulate the diffie-hellan key exchange protocol and verify the given properties:

- Client & server should establish the same session key after key exchange
- If the client/server believes it has established a session key with an authenticated peer, then the attacker does not know the session key when it is being used
- Even if the private key of the server (of the time being) is stolen, the attacker cannot compromise the communication in the next phase, 
i.e perfect forward secrecy.

Besides verifying the above properites, attackers' capabilities were also studied and simulated. For instance, several attackers (with increasing capabilities) were mimicked to evaluate the damage that these attackers can cause to the concurrent system. These attackers were:
- Dolev-Yao (DY) attacker (has complete control of the network, and can 
intercept, send, replay, and delete any message)
- Dolev-Yao (DY) attacker with the extra ability to compromise the private key of protocol participants
- Dolev-Yao (DY) attacker with the extra ability to compromise the random keys

We used the Process Analysis Toolkit (a simulator, model checker and refinement checker for concurrent and real-time systems) to implement the requirements.

## Requirements
- Please ensure you have downloaded [Process Analysis Toolkit](https://pat.comp.nus.edu.sg/?page_id=2587). The user guide can be downloaded from [here](https://pat.comp.nus.edu.sg/?page_id=2611)

#### For more details, please refer to the `Final Report.pdf` document.
