// using Argus.Sync.Data.Models;
// using PallasDotnet;

// namespace Argus.Sync.Tests;

// public class CardanoNodeClientTests
// {
//     [Fact]
//     public async Task GetUtxosByAddressTest()
//     {
//         var address = "addr1q8nrqg4s73skqfyyj69mzr7clpe8s7ux9t8z6l55x2f2xuqra34p9pswlrq86nq63hna7p4vkrcrxznqslkta9eqs2nscfavlf";
//         var nodeSocketPath = "/tmp/mainnet-node.socket";
//         var client = new CardanoNodeClient();
//         await client.ConnectAsync(nodeSocketPath, NetworkMagic.MAINNET);
//         var utxosByAddress = await client.GetUtxosByAddressAsync(address);
//         var utxosByAddressCborHex = Convert.ToHexString(CborConverter.Serialize(utxosByAddress)).ToLowerInvariant();
//         Assert.Equal("a7825820094d9608d93de0f889fbceef759f599285d479b00ab5a77974f6f27e760a61c80082583901e63022b0f461602484968bb10fd8f872787b862ace2d7e943292a37003ec6a12860ef8c07d4c1a8de7df06acb0f0330a6087ecbe972082a7821a002dc6c0a1581cc27600f3aff3d94043464a33786429b78e6ab9df5e1d23b774acb34ca144434e43541a00100590825820094d9608d93de0f889fbceef759f599285d479b00ab5a77974f6f27e760a61c80182583901e63022b0f461602484968bb10fd8f872787b862ace2d7e943292a37003ec6a12860ef8c07d4c1a8de7df06acb0f0330a6087ecbe972082a71a00103be482582018df76ceb9decacea4b4b35f78a15e478461cc7c7a3b2db6f36a724fc02d530d0082583901e63022b0f461602484968bb10fd8f872787b862ace2d7e943292a37003ec6a12860ef8c07d4c1a8de7df06acb0f0330a6087ecbe972082a7821a01292451a2581c0e378bd85b5c6283a2c214594468d40258b7351f17e76e9613d88f70a144434849501b0005af3107a40000581c30d2ebdb2fec06142ee84e5120c2717b4d68a91bffd924420d94ddeaa144434849501b0005af3107a400008258205aae02fa962693670af84b7ac9aa2929bdba6ae8196162deb015df782890d5000082583901e63022b0f461602484968bb10fd8f872787b862ace2d7e943292a37003ec6a12860ef8c07d4c1a8de7df06acb0f0330a6087ecbe972082a71a004c4b40825820d1dec89008e63c087ce46d481e721d7568c293592cad72e65b8027ba1ff4e0e80282583901e63022b0f461602484968bb10fd8f872787b862ace2d7e943292a37003ec6a12860ef8c07d4c1a8de7df06acb0f0330a6087ecbe972082a7821a0016e360a1581c61b3802ce748ed1fdaad2d6c744b19f104285f7d318172a5d4f06a4ea15820000de140bbc3181d1dde9108563ff2872fd4d2443c3e842879f38da34c6471b601825820e35737928075c3bc18dea861af9f6f44d30111206bb3bcfe5bd22ad380eb9cbb0182583901e63022b0f461602484968bb10fd8f872787b862ace2d7e943292a37003ec6a12860ef8c07d4c1a8de7df06acb0f0330a6087ecbe972082a7821a002ad032a6581c61b3802ce748ed1fdaad2d6c744b19f104285f7d318172a5d4f06a4ea35820000de1400c424d508e014278fa3091562fb7a75464a99fb368a41da083887b94015820000de140222b0ed9cc8232d5089310ad31decc8a18a4dc0ed455c65385c730bb015820000de1409ff47e7fc3c700c38327ec0d589ffeef131b508f159a0a97fc30cdae01581c6f37a98bd0c9ced4e302ec2fb3a2f19ffba1b5c0c2bedee3dac30e56a45148595045534b554c4c535f56545f505f45015148595045534b554c4c535f56545f565f43015248595045534b554c4c535f56545f4d5f4545015348595045534b554c4c535f56545f41435f454501581c9fea1584045acc5f989bd80bf1d380d2bbb1ca9f4ef1a1ef43a7a777a14953505f724d5951353702581cc27600f3aff3d94043464a33786429b78e6ab9df5e1d23b774acb34ca144434e43541a000b6dc8581ccecd82e1ee377c52d81d233d7e81d26d9f01c32c99f9f0ef6dc3dfbba14953505f69436c74593602581cf9c811825adb28f42d82391b900ca6962fa94a1d51739fbaa52f4b06a150434e43545f43455254494649434154451a000f423b825820e35737928075c3bc18dea861af9f6f44d30111206bb3bcfe5bd22ad380eb9cbb0282583901e63022b0f461602484968bb10fd8f872787b862ace2d7e943292a37003ec6a12860ef8c07d4c1a8de7df06acb0f0330a6087ecbe972082a71a00ecc075", utxosByAddressCborHex);
//     }
// }