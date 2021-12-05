using RepoDb.Fix.StarterKit;
using RepoDb.Fix.StarterKit.Repositories;

Initializer.Initialize();

var repository = new TesterRepository();
repository.Test();

// var cancellationToken = new CancellationToken();
// await repository.TestAsync(cancellationToken).ConfigureAwait(false);
