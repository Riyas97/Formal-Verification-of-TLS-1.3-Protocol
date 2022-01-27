# Formal-Verification-of-TLS-1.3-Protocol
Formal Verification of TLS 1.3 (Key Exchange) Protocol using Process Analysis Toolkit (PAT)


## Introduction
Transport Layer Security, TLS is a protocol designed to build a secure communication channel
between the Client and the Server. The communication is secure because symmetric
cryptography is used to encrypt the data transmitted. The keys are uniquely generated for each
connection and are based on a shared secret, negotiated at the beginning of the session, also
known as a TLS handshake.

Overall, the Client and Server shall use an asymmetric encryption technique (e.g., RSA and DH
key exchange protocol) to create a shared secret during each session. With the shared secret, both
peers use a symmetric encryption technique (e.g., AES) to build the encrypted communication
channel. In this project, our group modeled a key exchange protocol based on the Diffie-Hellman
Ephemeral key exchange protocol.

In this project, the main aim is to construct a CSP concurrent model to simulate the diffie-hellan key exchange protocol
and verify the given properties:

- Client & server should establish the same session key after key exchange
- If the client/server believes it has established a session key with an authenticated peer, then the 
attacker does not know the session key when it is being used
- Even if the private key of the server (of the time being) is stolen, the attacker cannot compromise the communication in the next phase, 
i.e perfect forward secrecy.

Besides verifying the above properites, 
