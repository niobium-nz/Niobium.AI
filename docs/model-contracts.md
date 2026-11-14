# Model names and data contract ownership

The owner's rule of 14 November 2026 applies to all Niobium projects and their
examples. Read the [framework guide](https://github.com/niobium-nz/Niobium/blob/main/docs/model-contracts.md)
for detailed mapping examples, the responsibility table and the legacy inventory.

This repository contains AI agent applications and generated-project guidance. No
Niobium Table model was found in the inspected source at `386e506`.

When introducing Table models, name properties for the actual business values,
then apply `[EntityKey(EntityKeyKind.PartitionKey)]` and
`[EntityKey(EntityKeyKind.RowKey)]`. The framework repository handles physical
column names. Composite values need a name that describes the whole value.
Infrastructure types and protocol fields are distinct from business Table models.

The owning data contract privately defines IDs, canonical fingerprints, key/path
formats and serialized shape. Expose small meaningful factory/lookup/comparison
operations, rather than public implementation helpers that callers must repeat.
Domains own business rules, authorization and transitions; flows coordinate;
adapters perform backend mapping and I/O.

Application and generated-code examples must preserve external API contracts.
Do not rename fields returned by Store, Identity or another service merely to
make a client conform to a future server-model convention.

The owner selected Notification's refactor now and a separate rollout for legacy
public contract renames. Preserve existing keys, ordering, wire values and
suppression identities until that rollout is explicitly scoped. A private helper
localizes future edits but does not make incompatible format changes safe.

## Documentation delivery boundary

The existing production workflow runs on both main pushes and PR events. Its
publish job now requires a push to main so opening a documentation PR cannot
deploy unreviewed source. There is no feature test-deployment job in this workflow;
a skipped PR publication is not test or deployment evidence. Verify documentation
locally, native review and the independent decision before merging, then inspect
the actual main publication result. No agent application behavior changes here.
