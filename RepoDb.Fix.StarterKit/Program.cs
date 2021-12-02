﻿using RepoDb.Fix.StarterKit.Repositories;

var repository = new TesterRepository();
repository.Test();

var cancellationToken = new CancellationToken();
await repository.TestAsync(cancellationToken).ConfigureAwait(false);
