namespace Niobium.AI.Ecommerce.Contracts;

public record MarketStrategyOutput
{
    public ProductDetails ProductDetails { get; init; } = new();
    public PricingEconomicsAndOffers PricingEconomicsAndOffers { get; init; } = new();
    public MobileFirstLandingPagePlan MobileFirstLandingPagePlan { get; init; } = new();
    public List<CustomerSegment> CustomerSegments { get; init; } = [];
}

public record ProductDetails
{
    public string WorkingProductDefinition { get; init; } = String.Empty;
    public string CoreProblemSolved { get; init; } = String.Empty;
    public List<string> PrimaryUseCases { get; init; } = [];
    public string MaterialsOrConstructionSummary { get; init; } = String.Empty;
    public string FulfillmentAndRefundAssumptions { get; init; } = String.Empty;
}

public record PricingEconomicsAndOffers
{
    public List<string> GivenInputs { get; init; } = [];
    public List<string> ModeledAssumptions { get; init; } = [];
    public string LandedCostModel { get; init; } = String.Empty;
    public string RecommendedSingleUnitSellingPrice { get; init; } = String.Empty;
    public string? OptionalCompareAtOrAnchorPrice { get; init; }
    public DirectPurchaseFunnelModel DirectPurchaseFunnelModel { get; init; } = new();
    public DiagnosticMetrics? DiagnosticMetrics { get; init; }
    public OfferStack OfferStack { get; init; } = new();
    public string BundleRationale { get; init; } = String.Empty;
    public string RecommendedPrimaryOffer { get; init; } = String.Empty;
    public string RecommendedPrimaryOfferRationale { get; init; } = String.Empty;
}

public record DirectPurchaseFunnelModel
{
    public string AssumedCpc { get; init; } = String.Empty;
    public string AssumedLpvRate { get; init; } = String.Empty;
    public string AssumedCheckoutStartRate { get; init; } = String.Empty;
    public string AssumedPurchaseRate { get; init; } = String.Empty;
    public string DerivedClickToPurchaseRate { get; init; } = String.Empty;
    public string EstimatedBlendedCpa { get; init; } = String.Empty;
    public string BreakEvenBlendedCpa { get; init; } = String.Empty;
    public string RecommendedTargetBlendedCpa { get; init; } = String.Empty;
    public string FunnelLogicExplanation { get; init; } = String.Empty;
}

public record DiagnosticMetrics
{
    public string EstimatedCostPerLpv { get; init; } = String.Empty;
    public string EstimatedCostPerCheckoutStart { get; init; } = String.Empty;
}

public record OfferStack
{
    public Offer SingleUnitOffer { get; init; } = new();
    public Offer BestSellerBundle { get; init; } = new();
    public Offer HigherAovBundle { get; init; } = new();
}

public record Offer
{
    public string Name { get; init; } = String.Empty;
    public string PricePoint { get; init; } = String.Empty;
    public string Description { get; init; } = String.Empty;
}

public record MobileFirstLandingPagePlan
{
    public string RoleInDirectPurchaseFunnel { get; init; } = String.Empty;
    public List<string> MobileFirstSectionOrder { get; init; } = [];
    public List<LandingPageSectionAssetPlan> CreativeAssetsNeededForEachSection { get; init; } = [];
    public string ProofStrategyWithoutReviewsOrRealSocialProof { get; init; } = String.Empty;
    public string ShippingAndGuaranteeMessagingGuidance { get; init; } = String.Empty;
    public List<string> FaqAndObjectionHandlingPriorities { get; init; } = [];
    public string AlignmentWithCustomerSegmentsAndAngleTriggerMatrix { get; init; } = String.Empty;
    public string MobileUxNotes { get; init; } = String.Empty;
}

public record LandingPageSectionAssetPlan
{
    public string SectionName { get; init; } = String.Empty;
    public List<LandingPageAssetNeeds> AssetNeeds { get; init; } = [];
}

public record LandingPageAssetNeeds
{
    public string AssetId { get; init; } = Guid.NewGuid().ToString();

    public string AssetDetailedDescription { get; init; } = String.Empty;
}

public record CustomerSegment
{
    public int SegmentNumber { get; init; }
    public string SegmentName { get; init; } = String.Empty;
    public SharedContextSnapshot SharedContextSnapshot { get; init; } = new();
    public SegmentRating SegmentRating { get; init; } = new();
    public SegmentSummary SegmentSummary { get; init; } = new();
    public List<AngleTrigger> AngleAndTriggerMatrix { get; init; } = [];
    public SegmentLandingPageAdaptation SegmentLandingPageAdaptation { get; init; } = new();
}

public record SharedContextSnapshot
{
    public string RecommendedProductName { get; init; } = String.Empty;
    public string CoreOfferStack { get; init; } = String.Empty;
    public List<string> KeyPricePoints { get; init; } = [];
    public string ShippingReality { get; init; } = String.Empty;
    public string GuaranteeOrRefundFraming { get; init; } = String.Empty;
    public string LandingPageRoleInFunnel { get; init; } = String.Empty;
}

public record SegmentRating
{
    public int OverallPriorityRating { get; init; }
    public int ProfitPotentialRating { get; init; }
    public int TriggerIntensityRating { get; init; }
    public int CreativeClarityRating { get; init; }
    public int FunnelFitRating { get; init; }
    public string Rationale { get; init; } = String.Empty;
}

public record SegmentSummary
{
    public string WhoThisSegmentIs { get; init; } = String.Empty;
    public string NeedState { get; init; } = String.Empty;
    public string PurchaseMomentOrTriggerCondition { get; init; } = String.Empty;
    public string EmotionalDriver { get; init; } = String.Empty;
    public List<string> MainObjections { get; init; } = [];
    public string EconomicAttractiveness { get; init; } = String.Empty;
}

public record AngleTrigger
{
    public int AngleNumber { get; init; }
    public string AngleName { get; init; } = String.Empty;
    public string Trigger { get; init; } = String.Empty;
    public List<string> SuggestedProductNamesForThisAngle { get; init; } = [];
    public string RecommendedProductNameForThisAngle { get; init; } = String.Empty;
    public string RecommendedProductNameForThisAngleRationale { get; init; } = String.Empty;
    public string RecommendedShortProductCode { get; init; } = String.Empty;
    public string RecommendedWebsitePrimaryColorForThisAngle { get; init; } = String.Empty;
    public string RecommendedWebsiteSecondaryColorForThisAngle { get; init; } = String.Empty;
    public string RecommendedWebsiteAccentColorForThisAngle { get; init; } = String.Empty;
    public string RecommendedWebsiteColorThemeForThisAngleRationale { get; init; } = String.Empty;
    public string CorePromise { get; init; } = String.Empty;
    public string MessageTerritory { get; init; } = String.Empty;
    public string WhyThisAngleShouldConvertOnMeta { get; init; } = String.Empty;
    public List<string> ObjectionsToPreHandle { get; init; } = [];
    public List<string> ProofOrDemoAssetsRequired { get; init; } = [];
    public string RecommendedCtaOrRoasTarget { get; init; } = String.Empty;
    public CreativeHandoffs CreativeHandoffs { get; init; } = new();
}

public record CreativeHandoffs
{
    public List<string> StaticImageDirections { get; init; } = [];
    public List<string> ShortFormVideoOrUgcDirections { get; init; } = [];
    public string FirstFrameOrThumbStopDirection { get; init; } = String.Empty;
    public List<string> CopyHookTerritories { get; init; } = [];
    public List<string> HeadlineTerritories { get; init; } = [];
    public List<string> VisualProofMoments { get; init; } = [];
    public string ContinuityNotesForLandingPage { get; init; } = String.Empty;
}

public record SegmentLandingPageAdaptation
{
    public string HeroDirection { get; init; } = String.Empty;
    public List<string> BenefitOrder { get; init; } = [];
    public List<string> FaqEmphasis { get; init; } = [];
    public List<string> SectionEmphasis { get; init; } = [];
    public string MobileUxNotes { get; init; } = String.Empty;
    public List<string> AssetNeedsSpecificToThisSegment { get; init; } = [];
}
