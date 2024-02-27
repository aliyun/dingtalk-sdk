<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\AddOrgHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\AddOrgRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\AddOrgResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ApproveProcessCallbackHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ApproveProcessCallbackRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ApproveProcessCallbackResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\BanOrOpenGroupWordsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\BanOrOpenGroupWordsRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\BanOrOpenGroupWordsResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\CreateCategoryAndBindingGroupsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\CreateCategoryAndBindingGroupsRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\CreateCategoryAndBindingGroupsResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\CreateMessageCategoryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\CreateMessageCategoryRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\CreateMessageCategoryResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\CreateRuleHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\CreateRuleRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\CreateRuleResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\CreateTrustedDeviceBatchHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\CreateTrustedDeviceBatchRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\CreateTrustedDeviceBatchResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\CreateTrustedDeviceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\CreateTrustedDeviceRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\CreateTrustedDeviceResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\DeleteAcrossCloudStroageConfigsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\DeleteAcrossCloudStroageConfigsResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\DeleteCommentHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\DeleteCommentResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\DeleteTrustedDeviceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\DeleteTrustedDeviceRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\DeleteTrustedDeviceResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\DistributePartnerAppHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\DistributePartnerAppRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\DistributePartnerAppResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ExclusiveCreateDingPortalHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ExclusiveCreateDingPortalRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ExclusiveCreateDingPortalResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\FileStorageActiveStorageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\FileStorageActiveStorageRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\FileStorageActiveStorageResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\FileStorageCheckConnectionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\FileStorageCheckConnectionRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\FileStorageCheckConnectionResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\FileStorageGetQuotaDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\FileStorageGetQuotaDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\FileStorageGetQuotaDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\FileStorageGetStorageStateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\FileStorageGetStorageStateRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\FileStorageGetStorageStateResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\FileStorageUpdateStorageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\FileStorageUpdateStorageRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\FileStorageUpdateStorageResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GenerateDarkWaterMarkHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GenerateDarkWaterMarkRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GenerateDarkWaterMarkResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetAccountTransferListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetAccountTransferListRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetAccountTransferListResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetActiveUserSummaryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetActiveUserSummaryResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetAgentIdByRelatedAppIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetAgentIdByRelatedAppIdRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetAgentIdByRelatedAppIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetAllLabelableDeptsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetAllLabelableDeptsResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetAppDispatchInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetAppDispatchInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetAppDispatchInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetCalenderSummaryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetCalenderSummaryResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetCommentListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetCommentListRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetCommentListResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetConfBaseInfoByLogicalIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetConfBaseInfoByLogicalIdRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetConfBaseInfoByLogicalIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetConferenceDetailHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetConferenceDetailResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetDingReportDeptSummaryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetDingReportDeptSummaryRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetDingReportDeptSummaryResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetDingReportSummaryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetDingReportSummaryResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetDocCreatedDeptSummaryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetDocCreatedDeptSummaryRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetDocCreatedDeptSummaryResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetDocCreatedSummaryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetDocCreatedSummaryResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetExclusiveAccountAllOrgListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetExclusiveAccountAllOrgListRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetExclusiveAccountAllOrgListResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetGeneralFormCreatedDeptSummaryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetGeneralFormCreatedDeptSummaryRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetGeneralFormCreatedDeptSummaryResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetGeneralFormCreatedSummaryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetGeneralFormCreatedSummaryResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetGroupActiveInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetGroupActiveInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetGroupActiveInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetInActiveUserListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetInActiveUserListRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetInActiveUserListResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetLastOrgAuthDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetLastOrgAuthDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetLastOrgAuthDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetMsgConfigHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetMsgConfigRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetMsgConfigResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetOaOperatorLogListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetOaOperatorLogListRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetOaOperatorLogListResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetOutGroupsByPageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetOutGroupsByPageRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetOutGroupsByPageResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetOutsideAuditGroupMessageByPageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetOutsideAuditGroupMessageByPageRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetOutsideAuditGroupMessageByPageResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetPartnerTypeByParentIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetPartnerTypeByParentIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetPublicDevicesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetPublicDevicesRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetPublicDevicesResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetPublisherSummaryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetPublisherSummaryRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetPublisherSummaryResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetRealPeopleRecordsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetRealPeopleRecordsRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetRealPeopleRecordsResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetRecognizeRecordsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetRecognizeRecordsRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetRecognizeRecordsResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetSignedDetailByPageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetSignedDetailByPageRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetSignedDetailByPageResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetTrustDeviceListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetTrustDeviceListRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetTrustDeviceListResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetUserAppVersionSummaryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetUserAppVersionSummaryRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetUserAppVersionSummaryResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetUserFaceStateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetUserFaceStateRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetUserFaceStateResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetUserRealPeopleStateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetUserRealPeopleStateRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetUserRealPeopleStateResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetUserStayLengthHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetUserStayLengthRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetUserStayLengthResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListAuditLogHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListAuditLogRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListAuditLogResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListCategorysHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListCategorysRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListCategorysResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListCategorysShrinkRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListJoinOrgInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListJoinOrgInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListJoinOrgInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListMiniAppAvailableVersionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListMiniAppAvailableVersionRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListMiniAppAvailableVersionResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListMiniAppHistoryVersionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListMiniAppHistoryVersionRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListMiniAppHistoryVersionResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListPartnerRolesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListPartnerRolesResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListPunchScheduleByConditionWithPagingHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListPunchScheduleByConditionWithPagingRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListPunchScheduleByConditionWithPagingResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListRulesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListRulesRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListRulesResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListRulesShrinkRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\LogoutHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\LogoutRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\LogoutResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\PreventCheatingCheckRiskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\PreventCheatingCheckRiskRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\PreventCheatingCheckRiskResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\PublishFileChangeNoticeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\PublishFileChangeNoticeRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\PublishFileChangeNoticeResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\PublishRuleHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\PublishRuleRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\PublishRuleResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\PushBadgeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\PushBadgeRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\PushBadgeResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\QueryAcrossCloudStroageConfigsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\QueryAcrossCloudStroageConfigsRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\QueryAcrossCloudStroageConfigsResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\QueryPartnerInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\QueryPartnerInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\QueryUserBehaviorHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\QueryUserBehaviorRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\QueryUserBehaviorResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\RollbackMiniAppVersionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\RollbackMiniAppVersionRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\RollbackMiniAppVersionResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\RuleBatchReceiverHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\RuleBatchReceiverRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\RuleBatchReceiverResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SaveAcrossCloudStroageConfigsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SaveAcrossCloudStroageConfigsRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SaveAcrossCloudStroageConfigsResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SaveAndSubmitAuthInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SaveAndSubmitAuthInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SaveAndSubmitAuthInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SaveOpenTerminalInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SaveOpenTerminalInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SaveOpenTerminalInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SaveWhiteAppHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SaveWhiteAppRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SaveWhiteAppResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SearchOrgInnerGroupInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SearchOrgInnerGroupInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SearchOrgInnerGroupInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SendAppDingHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SendAppDingRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SendAppDingResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SendInvitationHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SendInvitationRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SendInvitationResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SendPhoneDingHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SendPhoneDingRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SendPhoneDingResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SetDeptPartnerTypeAndNumHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SetDeptPartnerTypeAndNumRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SetDeptPartnerTypeAndNumResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SpecialRuleBatchReceiverHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SpecialRuleBatchReceiverRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SpecialRuleBatchReceiverResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\UpdateCategoryNameHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\UpdateCategoryNameRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\UpdateCategoryNameResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\UpdateFileStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\UpdateFileStatusRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\UpdateFileStatusResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\UpdateMiniAppVersionStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\UpdateMiniAppVersionStatusRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\UpdateMiniAppVersionStatusResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\UpdatePartnerVisibilityHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\UpdatePartnerVisibilityRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\UpdatePartnerVisibilityResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\UpdateRoleVisibilityHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\UpdateRoleVisibilityRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\UpdateRoleVisibilityResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\UpdateStorageModeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\UpdateStorageModeRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\UpdateStorageModeResponse;
use AlibabaCloud\Tea\Utils\Utils;
use AlibabaCloud\Tea\Utils\Utils\RuntimeOptions;
use Darabonba\GatewayDingTalk\Client as DarabonbaGatewayDingTalkClient;
use Darabonba\OpenApi\Models\OpenApiRequest;
use Darabonba\OpenApi\Models\Params;
use Darabonba\OpenApi\OpenApiClient;

class Dingtalk extends OpenApiClient
{
    protected $_client;

    public function __construct($config)
    {
        parent::__construct($config);
        $this->_client       = new DarabonbaGatewayDingTalkClient();
        $this->_spi          = $this->_client;
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @param AddOrgRequest  $request
     * @param AddOrgHeaders  $headers
     * @param RuntimeOptions $runtime
     *
     * @return AddOrgResponse
     */
    public function addOrgWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->mobileNum)) {
            $body['mobileNum'] = $request->mobileNum;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'AddOrg',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/orgnizations',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AddOrgResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param AddOrgRequest $request
     *
     * @return AddOrgResponse
     */
    public function addOrg($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddOrgHeaders([]);

        return $this->addOrgWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ApproveProcessCallbackRequest $request
     * @param ApproveProcessCallbackHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return ApproveProcessCallbackResponse
     */
    public function approveProcessCallbackWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->accessKeyId)) {
            $body['accessKeyId'] = $request->accessKeyId;
        }
        if (!Utils::isUnset($request->accessKeySecret)) {
            $body['accessKeySecret'] = $request->accessKeySecret;
        }
        if (!Utils::isUnset($request->request)) {
            $body['request'] = $request->request;
        }
        if (!Utils::isUnset($request->targetCorpId)) {
            $body['targetCorpId'] = $request->targetCorpId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'ApproveProcessCallback',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/approvalResults/callback',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ApproveProcessCallbackResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ApproveProcessCallbackRequest $request
     *
     * @return ApproveProcessCallbackResponse
     */
    public function approveProcessCallback($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ApproveProcessCallbackHeaders([]);

        return $this->approveProcessCallbackWithOptions($request, $headers, $runtime);
    }

    /**
     * @param BanOrOpenGroupWordsRequest $request
     * @param BanOrOpenGroupWordsHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return BanOrOpenGroupWordsResponse
     */
    public function banOrOpenGroupWordsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->banWordsType)) {
            $body['banWordsType'] = $request->banWordsType;
        }
        if (!Utils::isUnset($request->openConverationId)) {
            $body['openConverationId'] = $request->openConverationId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'BanOrOpenGroupWords',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/enterpriseSecurities/banOrOpenGroupWords',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BanOrOpenGroupWordsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param BanOrOpenGroupWordsRequest $request
     *
     * @return BanOrOpenGroupWordsResponse
     */
    public function banOrOpenGroupWords($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BanOrOpenGroupWordsHeaders([]);

        return $this->banOrOpenGroupWordsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateCategoryAndBindingGroupsRequest $request
     * @param CreateCategoryAndBindingGroupsHeaders $headers
     * @param RuntimeOptions                        $runtime
     *
     * @return CreateCategoryAndBindingGroupsResponse
     */
    public function createCategoryAndBindingGroupsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->categoryName)) {
            $body['categoryName'] = $request->categoryName;
        }
        if (!Utils::isUnset($request->groupIds)) {
            $body['groupIds'] = $request->groupIds;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'CreateCategoryAndBindingGroups',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/messageCategories/categories/createAndBind',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateCategoryAndBindingGroupsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CreateCategoryAndBindingGroupsRequest $request
     *
     * @return CreateCategoryAndBindingGroupsResponse
     */
    public function createCategoryAndBindingGroups($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateCategoryAndBindingGroupsHeaders([]);

        return $this->createCategoryAndBindingGroupsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateMessageCategoryRequest $request
     * @param CreateMessageCategoryHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return CreateMessageCategoryResponse
     */
    public function createMessageCategoryWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->categoryName)) {
            $body['categoryName'] = $request->categoryName;
        }
        if (!Utils::isUnset($request->groupIds)) {
            $body['groupIds'] = $request->groupIds;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'CreateMessageCategory',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/messageCategories/categories/create',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateMessageCategoryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CreateMessageCategoryRequest $request
     *
     * @return CreateMessageCategoryResponse
     */
    public function createMessageCategory($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateMessageCategoryHeaders([]);

        return $this->createMessageCategoryWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateRuleRequest $request
     * @param CreateRuleHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return CreateRuleResponse
     */
    public function createRuleWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->customPlan)) {
            $body['customPlan'] = $request->customPlan;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'CreateRule',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/messageCategories/rules',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateRuleResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CreateRuleRequest $request
     *
     * @return CreateRuleResponse
     */
    public function createRule($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateRuleHeaders([]);

        return $this->createRuleWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateTrustedDeviceRequest $request
     * @param CreateTrustedDeviceHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return CreateTrustedDeviceResponse
     */
    public function createTrustedDeviceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->did)) {
            $body['did'] = $request->did;
        }
        if (!Utils::isUnset($request->macAddress)) {
            $body['macAddress'] = $request->macAddress;
        }
        if (!Utils::isUnset($request->platform)) {
            $body['platform'] = $request->platform;
        }
        if (!Utils::isUnset($request->status)) {
            $body['status'] = $request->status;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'CreateTrustedDevice',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/trustedDevices',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateTrustedDeviceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CreateTrustedDeviceRequest $request
     *
     * @return CreateTrustedDeviceResponse
     */
    public function createTrustedDevice($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateTrustedDeviceHeaders([]);

        return $this->createTrustedDeviceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateTrustedDeviceBatchRequest $request
     * @param CreateTrustedDeviceBatchHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return CreateTrustedDeviceBatchResponse
     */
    public function createTrustedDeviceBatchWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->macAddressList)) {
            $body['macAddressList'] = $request->macAddressList;
        }
        if (!Utils::isUnset($request->platform)) {
            $body['platform'] = $request->platform;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'CreateTrustedDeviceBatch',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/trusts/devices',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateTrustedDeviceBatchResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CreateTrustedDeviceBatchRequest $request
     *
     * @return CreateTrustedDeviceBatchResponse
     */
    public function createTrustedDeviceBatch($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateTrustedDeviceBatchHeaders([]);

        return $this->createTrustedDeviceBatchWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                                 $targetCorpId
     * @param DeleteAcrossCloudStroageConfigsHeaders $headers
     * @param RuntimeOptions                         $runtime
     *
     * @return DeleteAcrossCloudStroageConfigsResponse
     */
    public function deleteAcrossCloudStroageConfigsWithOptions($targetCorpId, $headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);
        $params = new Params([
            'action'      => 'DeleteAcrossCloudStroageConfigs',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/fileStorages/acrossClouds/configurations/' . $targetCorpId . '',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DeleteAcrossCloudStroageConfigsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string $targetCorpId
     *
     * @return DeleteAcrossCloudStroageConfigsResponse
     */
    public function deleteAcrossCloudStroageConfigs($targetCorpId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteAcrossCloudStroageConfigsHeaders([]);

        return $this->deleteAcrossCloudStroageConfigsWithOptions($targetCorpId, $headers, $runtime);
    }

    /**
     * @param string               $publisherId
     * @param string               $commentId
     * @param DeleteCommentHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return DeleteCommentResponse
     */
    public function deleteCommentWithOptions($publisherId, $commentId, $headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);
        $params = new Params([
            'action'      => 'DeleteComment',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/publishers/' . $publisherId . '/comments/' . $commentId . '',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'boolean',
        ]);

        return DeleteCommentResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string $publisherId
     * @param string $commentId
     *
     * @return DeleteCommentResponse
     */
    public function deleteComment($publisherId, $commentId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteCommentHeaders([]);

        return $this->deleteCommentWithOptions($publisherId, $commentId, $headers, $runtime);
    }

    /**
     * @param DeleteTrustedDeviceRequest $request
     * @param DeleteTrustedDeviceHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return DeleteTrustedDeviceResponse
     */
    public function deleteTrustedDeviceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->kickOff)) {
            $body['kickOff'] = $request->kickOff;
        }
        if (!Utils::isUnset($request->macAddress)) {
            $body['macAddress'] = $request->macAddress;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'DeleteTrustedDevice',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/trustedDevices/remove',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DeleteTrustedDeviceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param DeleteTrustedDeviceRequest $request
     *
     * @return DeleteTrustedDeviceResponse
     */
    public function deleteTrustedDevice($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteTrustedDeviceHeaders([]);

        return $this->deleteTrustedDeviceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DistributePartnerAppRequest $request
     * @param DistributePartnerAppHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return DistributePartnerAppResponse
     */
    public function distributePartnerAppWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appId)) {
            $body['appId'] = $request->appId;
        }
        if (!Utils::isUnset($request->deptId)) {
            $body['deptId'] = $request->deptId;
        }
        if (!Utils::isUnset($request->subCorpId)) {
            $body['subCorpId'] = $request->subCorpId;
        }
        if (!Utils::isUnset($request->type)) {
            $body['type'] = $request->type;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'DistributePartnerApp',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/partners/applications/distribute',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DistributePartnerAppResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param DistributePartnerAppRequest $request
     *
     * @return DistributePartnerAppResponse
     */
    public function distributePartnerApp($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DistributePartnerAppHeaders([]);

        return $this->distributePartnerAppWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ExclusiveCreateDingPortalRequest $request
     * @param ExclusiveCreateDingPortalHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return ExclusiveCreateDingPortalResponse
     */
    public function exclusiveCreateDingPortalWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->dingPortalName)) {
            $body['dingPortalName'] = $request->dingPortalName;
        }
        if (!Utils::isUnset($request->targetCorpId)) {
            $body['targetCorpId'] = $request->targetCorpId;
        }
        if (!Utils::isUnset($request->templateAppUuid)) {
            $body['templateAppUuid'] = $request->templateAppUuid;
        }
        if (!Utils::isUnset($request->templateCorpId)) {
            $body['templateCorpId'] = $request->templateCorpId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'ExclusiveCreateDingPortal',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/workbenches/templates/spread',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ExclusiveCreateDingPortalResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ExclusiveCreateDingPortalRequest $request
     *
     * @return ExclusiveCreateDingPortalResponse
     */
    public function exclusiveCreateDingPortal($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ExclusiveCreateDingPortalHeaders([]);

        return $this->exclusiveCreateDingPortalWithOptions($request, $headers, $runtime);
    }

    /**
     * @param FileStorageActiveStorageRequest $request
     * @param FileStorageActiveStorageHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return FileStorageActiveStorageResponse
     */
    public function fileStorageActiveStorageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->accessKeyId)) {
            $body['accessKeyId'] = $request->accessKeyId;
        }
        if (!Utils::isUnset($request->accessKeySecret)) {
            $body['accessKeySecret'] = $request->accessKeySecret;
        }
        if (!Utils::isUnset($request->oss)) {
            $body['oss'] = $request->oss;
        }
        if (!Utils::isUnset($request->targetCorpId)) {
            $body['targetCorpId'] = $request->targetCorpId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'FileStorageActiveStorage',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/fileStorages/active',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return FileStorageActiveStorageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param FileStorageActiveStorageRequest $request
     *
     * @return FileStorageActiveStorageResponse
     */
    public function fileStorageActiveStorage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new FileStorageActiveStorageHeaders([]);

        return $this->fileStorageActiveStorageWithOptions($request, $headers, $runtime);
    }

    /**
     * @param FileStorageCheckConnectionRequest $request
     * @param FileStorageCheckConnectionHeaders $headers
     * @param RuntimeOptions                    $runtime
     *
     * @return FileStorageCheckConnectionResponse
     */
    public function fileStorageCheckConnectionWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->accessKeyId)) {
            $body['accessKeyId'] = $request->accessKeyId;
        }
        if (!Utils::isUnset($request->accessKeySecret)) {
            $body['accessKeySecret'] = $request->accessKeySecret;
        }
        if (!Utils::isUnset($request->oss)) {
            $body['oss'] = $request->oss;
        }
        if (!Utils::isUnset($request->targetCorpId)) {
            $body['targetCorpId'] = $request->targetCorpId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'FileStorageCheckConnection',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/fileStorages/connections/check',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return FileStorageCheckConnectionResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param FileStorageCheckConnectionRequest $request
     *
     * @return FileStorageCheckConnectionResponse
     */
    public function fileStorageCheckConnection($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new FileStorageCheckConnectionHeaders([]);

        return $this->fileStorageCheckConnectionWithOptions($request, $headers, $runtime);
    }

    /**
     * @param FileStorageGetQuotaDataRequest $request
     * @param FileStorageGetQuotaDataHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return FileStorageGetQuotaDataResponse
     */
    public function fileStorageGetQuotaDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->endTime)) {
            $query['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->startTime)) {
            $query['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->targetCorpId)) {
            $query['targetCorpId'] = $request->targetCorpId;
        }
        if (!Utils::isUnset($request->type)) {
            $query['type'] = $request->type;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'FileStorageGetQuotaData',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/fileStorages/quotaDatas',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return FileStorageGetQuotaDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param FileStorageGetQuotaDataRequest $request
     *
     * @return FileStorageGetQuotaDataResponse
     */
    public function fileStorageGetQuotaData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new FileStorageGetQuotaDataHeaders([]);

        return $this->fileStorageGetQuotaDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param FileStorageGetStorageStateRequest $request
     * @param FileStorageGetStorageStateHeaders $headers
     * @param RuntimeOptions                    $runtime
     *
     * @return FileStorageGetStorageStateResponse
     */
    public function fileStorageGetStorageStateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->targetCorpId)) {
            $query['targetCorpId'] = $request->targetCorpId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'FileStorageGetStorageState',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/fileStorages/states',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return FileStorageGetStorageStateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param FileStorageGetStorageStateRequest $request
     *
     * @return FileStorageGetStorageStateResponse
     */
    public function fileStorageGetStorageState($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new FileStorageGetStorageStateHeaders([]);

        return $this->fileStorageGetStorageStateWithOptions($request, $headers, $runtime);
    }

    /**
     * @param FileStorageUpdateStorageRequest $request
     * @param FileStorageUpdateStorageHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return FileStorageUpdateStorageResponse
     */
    public function fileStorageUpdateStorageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->accessKeyId)) {
            $body['accessKeyId'] = $request->accessKeyId;
        }
        if (!Utils::isUnset($request->accessKeySecret)) {
            $body['accessKeySecret'] = $request->accessKeySecret;
        }
        if (!Utils::isUnset($request->targetCorpId)) {
            $body['targetCorpId'] = $request->targetCorpId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'FileStorageUpdateStorage',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/fileStorages/configurations',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return FileStorageUpdateStorageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param FileStorageUpdateStorageRequest $request
     *
     * @return FileStorageUpdateStorageResponse
     */
    public function fileStorageUpdateStorage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new FileStorageUpdateStorageHeaders([]);

        return $this->fileStorageUpdateStorageWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GenerateDarkWaterMarkRequest $request
     * @param GenerateDarkWaterMarkHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return GenerateDarkWaterMarkResponse
     */
    public function generateDarkWaterMarkWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->userIdList)) {
            $body['userIdList'] = $request->userIdList;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'GenerateDarkWaterMark',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/enterpriseSecurities/darkWatermarks/generate',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GenerateDarkWaterMarkResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GenerateDarkWaterMarkRequest $request
     *
     * @return GenerateDarkWaterMarkResponse
     */
    public function generateDarkWaterMark($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GenerateDarkWaterMarkHeaders([]);

        return $this->generateDarkWaterMarkWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetAccountTransferListRequest $request
     * @param GetAccountTransferListHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return GetAccountTransferListResponse
     */
    public function getAccountTransferListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->status)) {
            $query['status'] = $request->status;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetAccountTransferList',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/dataTransfer/accounts',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetAccountTransferListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetAccountTransferListRequest $request
     *
     * @return GetAccountTransferListResponse
     */
    public function getAccountTransferList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetAccountTransferListHeaders([]);

        return $this->getAccountTransferListWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                      $dataId
     * @param GetActiveUserSummaryHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return GetActiveUserSummaryResponse
     */
    public function getActiveUserSummaryWithOptions($dataId, $headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);
        $params = new Params([
            'action'      => 'GetActiveUserSummary',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/data/dau/org/' . $dataId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return GetActiveUserSummaryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string $dataId
     *
     * @return GetActiveUserSummaryResponse
     */
    public function getActiveUserSummary($dataId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetActiveUserSummaryHeaders([]);

        return $this->getActiveUserSummaryWithOptions($dataId, $headers, $runtime);
    }

    /**
     * @param GetAgentIdByRelatedAppIdRequest $request
     * @param GetAgentIdByRelatedAppIdHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return GetAgentIdByRelatedAppIdResponse
     */
    public function getAgentIdByRelatedAppIdWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->appId)) {
            $query['appId'] = $request->appId;
        }
        if (!Utils::isUnset($request->targetCorpId)) {
            $query['targetCorpId'] = $request->targetCorpId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetAgentIdByRelatedAppId',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/exclusiveDesigns/agentId',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetAgentIdByRelatedAppIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetAgentIdByRelatedAppIdRequest $request
     *
     * @return GetAgentIdByRelatedAppIdResponse
     */
    public function getAgentIdByRelatedAppId($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetAgentIdByRelatedAppIdHeaders([]);

        return $this->getAgentIdByRelatedAppIdWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetAllLabelableDeptsHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return GetAllLabelableDeptsResponse
     */
    public function getAllLabelableDeptsWithOptions($headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);
        $params = new Params([
            'action'      => 'GetAllLabelableDepts',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/partnerDepartments',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return GetAllLabelableDeptsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @return GetAllLabelableDeptsResponse
     */
    public function getAllLabelableDepts()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetAllLabelableDeptsHeaders([]);

        return $this->getAllLabelableDeptsWithOptions($headers, $runtime);
    }

    /**
     * @param GetAppDispatchInfoRequest $request
     * @param GetAppDispatchInfoHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return GetAppDispatchInfoResponse
     */
    public function getAppDispatchInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->endTime)) {
            $query['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->startTime)) {
            $query['startTime'] = $request->startTime;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetAppDispatchInfo',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/apps/distributionInfos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetAppDispatchInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetAppDispatchInfoRequest $request
     *
     * @return GetAppDispatchInfoResponse
     */
    public function getAppDispatchInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetAppDispatchInfoHeaders([]);

        return $this->getAppDispatchInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                    $dataId
     * @param GetCalenderSummaryHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return GetCalenderSummaryResponse
     */
    public function getCalenderSummaryWithOptions($dataId, $headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);
        $params = new Params([
            'action'      => 'GetCalenderSummary',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/data/calendar/org/' . $dataId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetCalenderSummaryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string $dataId
     *
     * @return GetCalenderSummaryResponse
     */
    public function getCalenderSummary($dataId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetCalenderSummaryHeaders([]);

        return $this->getCalenderSummaryWithOptions($dataId, $headers, $runtime);
    }

    /**
     * @param string                $publisherId
     * @param GetCommentListRequest $request
     * @param GetCommentListHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return GetCommentListResponse
     */
    public function getCommentListWithOptions($publisherId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetCommentList',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/publishers/' . $publisherId . '/comments/list',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return GetCommentListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                $publisherId
     * @param GetCommentListRequest $request
     *
     * @return GetCommentListResponse
     */
    public function getCommentList($publisherId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetCommentListHeaders([]);

        return $this->getCommentListWithOptions($publisherId, $request, $headers, $runtime);
    }

    /**
     * @param GetConfBaseInfoByLogicalIdRequest $request
     * @param GetConfBaseInfoByLogicalIdHeaders $headers
     * @param RuntimeOptions                    $runtime
     *
     * @return GetConfBaseInfoByLogicalIdResponse
     */
    public function getConfBaseInfoByLogicalIdWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->logicalConferenceId)) {
            $query['logicalConferenceId'] = $request->logicalConferenceId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetConfBaseInfoByLogicalId',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/data/conferences',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetConfBaseInfoByLogicalIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetConfBaseInfoByLogicalIdRequest $request
     *
     * @return GetConfBaseInfoByLogicalIdResponse
     */
    public function getConfBaseInfoByLogicalId($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetConfBaseInfoByLogicalIdHeaders([]);

        return $this->getConfBaseInfoByLogicalIdWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                     $conferenceId
     * @param GetConferenceDetailHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return GetConferenceDetailResponse
     */
    public function getConferenceDetailWithOptions($conferenceId, $headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);
        $params = new Params([
            'action'      => 'GetConferenceDetail',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/data/conferences/' . $conferenceId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return GetConferenceDetailResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string $conferenceId
     *
     * @return GetConferenceDetailResponse
     */
    public function getConferenceDetail($conferenceId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetConferenceDetailHeaders([]);

        return $this->getConferenceDetailWithOptions($conferenceId, $headers, $runtime);
    }

    /**
     * @param string                          $dataId
     * @param GetDingReportDeptSummaryRequest $request
     * @param GetDingReportDeptSummaryHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return GetDingReportDeptSummaryResponse
     */
    public function getDingReportDeptSummaryWithOptions($dataId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetDingReportDeptSummary',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/data/report/dept/' . $dataId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return GetDingReportDeptSummaryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                          $dataId
     * @param GetDingReportDeptSummaryRequest $request
     *
     * @return GetDingReportDeptSummaryResponse
     */
    public function getDingReportDeptSummary($dataId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetDingReportDeptSummaryHeaders([]);

        return $this->getDingReportDeptSummaryWithOptions($dataId, $request, $headers, $runtime);
    }

    /**
     * @param string                      $dataId
     * @param GetDingReportSummaryHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return GetDingReportSummaryResponse
     */
    public function getDingReportSummaryWithOptions($dataId, $headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);
        $params = new Params([
            'action'      => 'GetDingReportSummary',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/datas/' . $dataId . '/reports/organizations',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetDingReportSummaryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string $dataId
     *
     * @return GetDingReportSummaryResponse
     */
    public function getDingReportSummary($dataId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetDingReportSummaryHeaders([]);

        return $this->getDingReportSummaryWithOptions($dataId, $headers, $runtime);
    }

    /**
     * @param string                          $dataId
     * @param GetDocCreatedDeptSummaryRequest $request
     * @param GetDocCreatedDeptSummaryHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return GetDocCreatedDeptSummaryResponse
     */
    public function getDocCreatedDeptSummaryWithOptions($dataId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetDocCreatedDeptSummary',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/data/doc/dept/' . $dataId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetDocCreatedDeptSummaryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                          $dataId
     * @param GetDocCreatedDeptSummaryRequest $request
     *
     * @return GetDocCreatedDeptSummaryResponse
     */
    public function getDocCreatedDeptSummary($dataId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetDocCreatedDeptSummaryHeaders([]);

        return $this->getDocCreatedDeptSummaryWithOptions($dataId, $request, $headers, $runtime);
    }

    /**
     * @param string                      $dataId
     * @param GetDocCreatedSummaryHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return GetDocCreatedSummaryResponse
     */
    public function getDocCreatedSummaryWithOptions($dataId, $headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);
        $params = new Params([
            'action'      => 'GetDocCreatedSummary',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/data/doc/org/' . $dataId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetDocCreatedSummaryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string $dataId
     *
     * @return GetDocCreatedSummaryResponse
     */
    public function getDocCreatedSummary($dataId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetDocCreatedSummaryHeaders([]);

        return $this->getDocCreatedSummaryWithOptions($dataId, $headers, $runtime);
    }

    /**
     * @param GetExclusiveAccountAllOrgListRequest $request
     * @param GetExclusiveAccountAllOrgListHeaders $headers
     * @param RuntimeOptions                       $runtime
     *
     * @return GetExclusiveAccountAllOrgListResponse
     */
    public function getExclusiveAccountAllOrgListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetExclusiveAccountAllOrgList',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/exclusiveAccounts/organizations',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetExclusiveAccountAllOrgListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetExclusiveAccountAllOrgListRequest $request
     *
     * @return GetExclusiveAccountAllOrgListResponse
     */
    public function getExclusiveAccountAllOrgList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetExclusiveAccountAllOrgListHeaders([]);

        return $this->getExclusiveAccountAllOrgListWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                                  $dataId
     * @param GetGeneralFormCreatedDeptSummaryRequest $request
     * @param GetGeneralFormCreatedDeptSummaryHeaders $headers
     * @param RuntimeOptions                          $runtime
     *
     * @return GetGeneralFormCreatedDeptSummaryResponse
     */
    public function getGeneralFormCreatedDeptSummaryWithOptions($dataId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetGeneralFormCreatedDeptSummary',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/data/generalForm/dept/' . $dataId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetGeneralFormCreatedDeptSummaryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                                  $dataId
     * @param GetGeneralFormCreatedDeptSummaryRequest $request
     *
     * @return GetGeneralFormCreatedDeptSummaryResponse
     */
    public function getGeneralFormCreatedDeptSummary($dataId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetGeneralFormCreatedDeptSummaryHeaders([]);

        return $this->getGeneralFormCreatedDeptSummaryWithOptions($dataId, $request, $headers, $runtime);
    }

    /**
     * @param string                              $dataId
     * @param GetGeneralFormCreatedSummaryHeaders $headers
     * @param RuntimeOptions                      $runtime
     *
     * @return GetGeneralFormCreatedSummaryResponse
     */
    public function getGeneralFormCreatedSummaryWithOptions($dataId, $headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);
        $params = new Params([
            'action'      => 'GetGeneralFormCreatedSummary',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/data/generalForm/org/' . $dataId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetGeneralFormCreatedSummaryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string $dataId
     *
     * @return GetGeneralFormCreatedSummaryResponse
     */
    public function getGeneralFormCreatedSummary($dataId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetGeneralFormCreatedSummaryHeaders([]);

        return $this->getGeneralFormCreatedSummaryWithOptions($dataId, $headers, $runtime);
    }

    /**
     * @param GetGroupActiveInfoRequest $request
     * @param GetGroupActiveInfoHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return GetGroupActiveInfoResponse
     */
    public function getGroupActiveInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->dingGroupId)) {
            $query['dingGroupId'] = $request->dingGroupId;
        }
        if (!Utils::isUnset($request->groupType)) {
            $query['groupType'] = $request->groupType;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetGroupActiveInfo',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/data/activeGroups',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetGroupActiveInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetGroupActiveInfoRequest $request
     *
     * @return GetGroupActiveInfoResponse
     */
    public function getGroupActiveInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetGroupActiveInfoHeaders([]);

        return $this->getGroupActiveInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetInActiveUserListRequest $request
     * @param GetInActiveUserListHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return GetInActiveUserListResponse
     */
    public function getInActiveUserListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->deptIds)) {
            $body['deptIds'] = $request->deptIds;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $body['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->statDate)) {
            $body['statDate'] = $request->statDate;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'GetInActiveUserList',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/inactives/users/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return GetInActiveUserListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetInActiveUserListRequest $request
     *
     * @return GetInActiveUserListResponse
     */
    public function getInActiveUserList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetInActiveUserListHeaders([]);

        return $this->getInActiveUserListWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetLastOrgAuthDataRequest $request
     * @param GetLastOrgAuthDataHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return GetLastOrgAuthDataResponse
     */
    public function getLastOrgAuthDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->targetCorpId)) {
            $query['targetCorpId'] = $request->targetCorpId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetLastOrgAuthData',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/organizations/authInfos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetLastOrgAuthDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetLastOrgAuthDataRequest $request
     *
     * @return GetLastOrgAuthDataResponse
     */
    public function getLastOrgAuthData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetLastOrgAuthDataHeaders([]);

        return $this->getLastOrgAuthDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetMsgConfigRequest $request
     * @param GetMsgConfigHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return GetMsgConfigResponse
     */
    public function getMsgConfigWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->groupTopic)) {
            $body['groupTopic'] = $request->groupTopic;
        }
        if (!Utils::isUnset($request->groupType)) {
            $body['groupType'] = $request->groupType;
        }
        if (!Utils::isUnset($request->listDynamicAttr)) {
            $body['listDynamicAttr'] = $request->listDynamicAttr;
        }
        if (!Utils::isUnset($request->listEmployeeCode)) {
            $body['listEmployeeCode'] = $request->listEmployeeCode;
        }
        if (!Utils::isUnset($request->listUnitId)) {
            $body['listUnitId'] = $request->listUnitId;
        }
        if (!Utils::isUnset($request->ownerJobNo)) {
            $body['ownerJobNo'] = $request->ownerJobNo;
        }
        if (!Utils::isUnset($request->ruleBusinessCode)) {
            $body['ruleBusinessCode'] = $request->ruleBusinessCode;
        }
        if (!Utils::isUnset($request->ruleCategory)) {
            $body['ruleCategory'] = $request->ruleCategory;
        }
        if (!Utils::isUnset($request->ruleCode)) {
            $body['ruleCode'] = $request->ruleCode;
        }
        if (!Utils::isUnset($request->secretKey)) {
            $body['secretKey'] = $request->secretKey;
        }
        if (!Utils::isUnset($request->sysCode)) {
            $body['sysCode'] = $request->sysCode;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'GetMsgConfig',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/portals/msgConfigs/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetMsgConfigResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetMsgConfigRequest $request
     *
     * @return GetMsgConfigResponse
     */
    public function getMsgConfig($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetMsgConfigHeaders([]);

        return $this->getMsgConfigWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetOaOperatorLogListRequest $request
     * @param GetOaOperatorLogListHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return GetOaOperatorLogListResponse
     */
    public function getOaOperatorLogListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->categoryList)) {
            $body['categoryList'] = $request->categoryList;
        }
        if (!Utils::isUnset($request->endTime)) {
            $body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->opUserId)) {
            $body['opUserId'] = $request->opUserId;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $body['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->startTime)) {
            $body['startTime'] = $request->startTime;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'GetOaOperatorLogList',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/oaOperatorLogs/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return GetOaOperatorLogListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetOaOperatorLogListRequest $request
     *
     * @return GetOaOperatorLogListResponse
     */
    public function getOaOperatorLogList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetOaOperatorLogListHeaders([]);

        return $this->getOaOperatorLogListWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetOutGroupsByPageRequest $request
     * @param GetOutGroupsByPageHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return GetOutGroupsByPageResponse
     */
    public function getOutGroupsByPageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->pageNumber)) {
            $body['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $body['pageSize'] = $request->pageSize;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'GetOutGroupsByPage',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/audits/outsideGroups/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetOutGroupsByPageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetOutGroupsByPageRequest $request
     *
     * @return GetOutGroupsByPageResponse
     */
    public function getOutGroupsByPage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetOutGroupsByPageHeaders([]);

        return $this->getOutGroupsByPageWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetOutsideAuditGroupMessageByPageRequest $request
     * @param GetOutsideAuditGroupMessageByPageHeaders $headers
     * @param RuntimeOptions                           $runtime
     *
     * @return GetOutsideAuditGroupMessageByPageResponse
     */
    public function getOutsideAuditGroupMessageByPageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->maxResults)) {
            $body['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $body['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'GetOutsideAuditGroupMessageByPage',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/audits/outsideGroups/messages/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetOutsideAuditGroupMessageByPageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetOutsideAuditGroupMessageByPageRequest $request
     *
     * @return GetOutsideAuditGroupMessageByPageResponse
     */
    public function getOutsideAuditGroupMessageByPage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetOutsideAuditGroupMessageByPageHeaders([]);

        return $this->getOutsideAuditGroupMessageByPageWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                          $parentId
     * @param GetPartnerTypeByParentIdHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return GetPartnerTypeByParentIdResponse
     */
    public function getPartnerTypeByParentIdWithOptions($parentId, $headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);
        $params = new Params([
            'action'      => 'GetPartnerTypeByParentId',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/partnerLabels/' . $parentId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetPartnerTypeByParentIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string $parentId
     *
     * @return GetPartnerTypeByParentIdResponse
     */
    public function getPartnerTypeByParentId($parentId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetPartnerTypeByParentIdHeaders([]);

        return $this->getPartnerTypeByParentIdWithOptions($parentId, $headers, $runtime);
    }

    /**
     * @param GetPublicDevicesRequest $request
     * @param GetPublicDevicesHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return GetPublicDevicesResponse
     */
    public function getPublicDevicesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->endTime)) {
            $query['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->macAddress)) {
            $query['macAddress'] = $request->macAddress;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->platform)) {
            $query['platform'] = $request->platform;
        }
        if (!Utils::isUnset($request->startTime)) {
            $query['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->title)) {
            $query['title'] = $request->title;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetPublicDevices',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/trusts/publicDevices',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetPublicDevicesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetPublicDevicesRequest $request
     *
     * @return GetPublicDevicesResponse
     */
    public function getPublicDevices($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetPublicDevicesHeaders([]);

        return $this->getPublicDevicesWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                     $dataId
     * @param GetPublisherSummaryRequest $request
     * @param GetPublisherSummaryHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return GetPublisherSummaryResponse
     */
    public function getPublisherSummaryWithOptions($dataId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetPublisherSummary',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/data/publisher/' . $dataId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return GetPublisherSummaryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                     $dataId
     * @param GetPublisherSummaryRequest $request
     *
     * @return GetPublisherSummaryResponse
     */
    public function getPublisherSummary($dataId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetPublisherSummaryHeaders([]);

        return $this->getPublisherSummaryWithOptions($dataId, $request, $headers, $runtime);
    }

    /**
     * @param GetRealPeopleRecordsRequest $request
     * @param GetRealPeopleRecordsHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return GetRealPeopleRecordsResponse
     */
    public function getRealPeopleRecordsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->agentId)) {
            $body['agentId'] = $request->agentId;
        }
        if (!Utils::isUnset($request->fromTime)) {
            $body['fromTime'] = $request->fromTime;
        }
        if (!Utils::isUnset($request->maxResults)) {
            $body['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $body['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->personIdentification)) {
            $body['personIdentification'] = $request->personIdentification;
        }
        if (!Utils::isUnset($request->scene)) {
            $body['scene'] = $request->scene;
        }
        if (!Utils::isUnset($request->toTime)) {
            $body['toTime'] = $request->toTime;
        }
        if (!Utils::isUnset($request->userIds)) {
            $body['userIds'] = $request->userIds;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'GetRealPeopleRecords',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/persons/identificationRecords/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetRealPeopleRecordsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetRealPeopleRecordsRequest $request
     *
     * @return GetRealPeopleRecordsResponse
     */
    public function getRealPeopleRecords($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetRealPeopleRecordsHeaders([]);

        return $this->getRealPeopleRecordsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetRecognizeRecordsRequest $request
     * @param GetRecognizeRecordsHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return GetRecognizeRecordsResponse
     */
    public function getRecognizeRecordsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->agentId)) {
            $body['agentId'] = $request->agentId;
        }
        if (!Utils::isUnset($request->faceCompareResult)) {
            $body['faceCompareResult'] = $request->faceCompareResult;
        }
        if (!Utils::isUnset($request->fromTime)) {
            $body['fromTime'] = $request->fromTime;
        }
        if (!Utils::isUnset($request->maxResults)) {
            $body['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $body['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->toTime)) {
            $body['toTime'] = $request->toTime;
        }
        if (!Utils::isUnset($request->userIds)) {
            $body['userIds'] = $request->userIds;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'GetRecognizeRecords',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/faces/recognizeRecords/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetRecognizeRecordsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetRecognizeRecordsRequest $request
     *
     * @return GetRecognizeRecordsResponse
     */
    public function getRecognizeRecords($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetRecognizeRecordsHeaders([]);

        return $this->getRecognizeRecordsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetSignedDetailByPageRequest $request
     * @param GetSignedDetailByPageHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return GetSignedDetailByPageResponse
     */
    public function getSignedDetailByPageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->signStatus)) {
            $query['signStatus'] = $request->signStatus;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetSignedDetailByPage',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/audits/users',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetSignedDetailByPageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetSignedDetailByPageRequest $request
     *
     * @return GetSignedDetailByPageResponse
     */
    public function getSignedDetailByPage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSignedDetailByPageHeaders([]);

        return $this->getSignedDetailByPageWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetTrustDeviceListRequest $request
     * @param GetTrustDeviceListHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return GetTrustDeviceListResponse
     */
    public function getTrustDeviceListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->userIds)) {
            $body['userIds'] = $request->userIds;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'GetTrustDeviceList',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/trustedDevices/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetTrustDeviceListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetTrustDeviceListRequest $request
     *
     * @return GetTrustDeviceListResponse
     */
    public function getTrustDeviceList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetTrustDeviceListHeaders([]);

        return $this->getTrustDeviceListWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                          $dataId
     * @param GetUserAppVersionSummaryRequest $request
     * @param GetUserAppVersionSummaryHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return GetUserAppVersionSummaryResponse
     */
    public function getUserAppVersionSummaryWithOptions($dataId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetUserAppVersionSummary',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/data/appVersion/org/' . $dataId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return GetUserAppVersionSummaryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                          $dataId
     * @param GetUserAppVersionSummaryRequest $request
     *
     * @return GetUserAppVersionSummaryResponse
     */
    public function getUserAppVersionSummary($dataId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetUserAppVersionSummaryHeaders([]);

        return $this->getUserAppVersionSummaryWithOptions($dataId, $request, $headers, $runtime);
    }

    /**
     * @param GetUserFaceStateRequest $request
     * @param GetUserFaceStateHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return GetUserFaceStateResponse
     */
    public function getUserFaceStateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->userIds)) {
            $body['userIds'] = $request->userIds;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'GetUserFaceState',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/faces/recognizeStates/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetUserFaceStateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetUserFaceStateRequest $request
     *
     * @return GetUserFaceStateResponse
     */
    public function getUserFaceState($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetUserFaceStateHeaders([]);

        return $this->getUserFaceStateWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetUserRealPeopleStateRequest $request
     * @param GetUserRealPeopleStateHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return GetUserRealPeopleStateResponse
     */
    public function getUserRealPeopleStateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->userIds)) {
            $body['userIds'] = $request->userIds;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'GetUserRealPeopleState',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/persons/identificationStates/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetUserRealPeopleStateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetUserRealPeopleStateRequest $request
     *
     * @return GetUserRealPeopleStateResponse
     */
    public function getUserRealPeopleState($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetUserRealPeopleStateHeaders([]);

        return $this->getUserRealPeopleStateWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetUserStayLengthRequest $request
     * @param GetUserStayLengthHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return GetUserStayLengthResponse
     */
    public function getUserStayLengthWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetUserStayLength',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/data/users/stayTimes',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetUserStayLengthResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetUserStayLengthRequest $request
     *
     * @return GetUserStayLengthResponse
     */
    public function getUserStayLength($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetUserStayLengthHeaders([]);

        return $this->getUserStayLengthWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ListAuditLogRequest $request
     * @param ListAuditLogHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return ListAuditLogResponse
     */
    public function listAuditLogWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->endDate)) {
            $query['endDate'] = $request->endDate;
        }
        if (!Utils::isUnset($request->nextBizId)) {
            $query['nextBizId'] = $request->nextBizId;
        }
        if (!Utils::isUnset($request->nextGmtCreate)) {
            $query['nextGmtCreate'] = $request->nextGmtCreate;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->startDate)) {
            $query['startDate'] = $request->startDate;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'ListAuditLog',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/fileAuditLogs',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListAuditLogResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ListAuditLogRequest $request
     *
     * @return ListAuditLogResponse
     */
    public function listAuditLog($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListAuditLogHeaders([]);

        return $this->listAuditLogWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ListCategorysRequest $tmpReq
     * @param ListCategorysHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return ListCategorysResponse
     */
    public function listCategorysWithOptions($tmpReq, $headers, $runtime)
    {
        Utils::validateModel($tmpReq);
        $request = new ListCategorysShrinkRequest([]);
        OpenApiUtilClient::convert($tmpReq, $request);
        if (!Utils::isUnset($tmpReq->body)) {
            $request->bodyShrink = OpenApiUtilClient::arrayToStringWithSpecifiedStyle($tmpReq->body, 'body', 'json');
        }
        $query = [];
        if (!Utils::isUnset($request->bodyShrink)) {
            $query['body'] = $request->bodyShrink;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'ListCategorys',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/messageCategories/categories/listCategories',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListCategorysResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ListCategorysRequest $request
     *
     * @return ListCategorysResponse
     */
    public function listCategorys($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListCategorysHeaders([]);

        return $this->listCategorysWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ListJoinOrgInfoRequest $request
     * @param ListJoinOrgInfoHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return ListJoinOrgInfoResponse
     */
    public function listJoinOrgInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->mobile)) {
            $query['mobile'] = $request->mobile;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'ListJoinOrgInfo',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/exclusiveAccounts/organizations/infos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListJoinOrgInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ListJoinOrgInfoRequest $request
     *
     * @return ListJoinOrgInfoResponse
     */
    public function listJoinOrgInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListJoinOrgInfoHeaders([]);

        return $this->listJoinOrgInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ListMiniAppAvailableVersionRequest $request
     * @param ListMiniAppAvailableVersionHeaders $headers
     * @param RuntimeOptions                     $runtime
     *
     * @return ListMiniAppAvailableVersionResponse
     */
    public function listMiniAppAvailableVersionWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->miniAppId)) {
            $body['miniAppId'] = $request->miniAppId;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $body['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->versionTypeSet)) {
            $body['versionTypeSet'] = $request->versionTypeSet;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'ListMiniAppAvailableVersion',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/miniApps/versions/availableLists',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return ListMiniAppAvailableVersionResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ListMiniAppAvailableVersionRequest $request
     *
     * @return ListMiniAppAvailableVersionResponse
     */
    public function listMiniAppAvailableVersion($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListMiniAppAvailableVersionHeaders([]);

        return $this->listMiniAppAvailableVersionWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ListMiniAppHistoryVersionRequest $request
     * @param ListMiniAppHistoryVersionHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return ListMiniAppHistoryVersionResponse
     */
    public function listMiniAppHistoryVersionWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->miniAppId)) {
            $query['miniAppId'] = $request->miniAppId;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'ListMiniAppHistoryVersion',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/miniApps/versions/historyLists',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return ListMiniAppHistoryVersionResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ListMiniAppHistoryVersionRequest $request
     *
     * @return ListMiniAppHistoryVersionResponse
     */
    public function listMiniAppHistoryVersion($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListMiniAppHistoryVersionHeaders([]);

        return $this->listMiniAppHistoryVersionWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                  $parentId
     * @param ListPartnerRolesHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return ListPartnerRolesResponse
     */
    public function listPartnerRolesWithOptions($parentId, $headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);
        $params = new Params([
            'action'      => 'ListPartnerRoles',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/partners/roles/' . $parentId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListPartnerRolesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string $parentId
     *
     * @return ListPartnerRolesResponse
     */
    public function listPartnerRoles($parentId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListPartnerRolesHeaders([]);

        return $this->listPartnerRolesWithOptions($parentId, $headers, $runtime);
    }

    /**
     * @param ListPunchScheduleByConditionWithPagingRequest $request
     * @param ListPunchScheduleByConditionWithPagingHeaders $headers
     * @param RuntimeOptions                                $runtime
     *
     * @return ListPunchScheduleByConditionWithPagingResponse
     */
    public function listPunchScheduleByConditionWithPagingWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizInstanceId)) {
            $body['bizInstanceId'] = $request->bizInstanceId;
        }
        if (!Utils::isUnset($request->maxResults)) {
            $body['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $body['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->scheduleDateEnd)) {
            $body['scheduleDateEnd'] = $request->scheduleDateEnd;
        }
        if (!Utils::isUnset($request->scheduleDateStart)) {
            $body['scheduleDateStart'] = $request->scheduleDateStart;
        }
        if (!Utils::isUnset($request->userIdList)) {
            $body['userIdList'] = $request->userIdList;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'ListPunchScheduleByConditionWithPaging',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/punchSchedules/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListPunchScheduleByConditionWithPagingResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ListPunchScheduleByConditionWithPagingRequest $request
     *
     * @return ListPunchScheduleByConditionWithPagingResponse
     */
    public function listPunchScheduleByConditionWithPaging($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListPunchScheduleByConditionWithPagingHeaders([]);

        return $this->listPunchScheduleByConditionWithPagingWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ListRulesRequest $tmpReq
     * @param ListRulesHeaders $headers
     * @param RuntimeOptions   $runtime
     *
     * @return ListRulesResponse
     */
    public function listRulesWithOptions($tmpReq, $headers, $runtime)
    {
        Utils::validateModel($tmpReq);
        $request = new ListRulesShrinkRequest([]);
        OpenApiUtilClient::convert($tmpReq, $request);
        if (!Utils::isUnset($tmpReq->body)) {
            $request->bodyShrink = OpenApiUtilClient::arrayToStringWithSpecifiedStyle($tmpReq->body, 'body', 'json');
        }
        $query = [];
        if (!Utils::isUnset($request->bodyShrink)) {
            $query['body'] = $request->bodyShrink;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'ListRules',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/messageCategories/rules/listRules',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListRulesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ListRulesRequest $request
     *
     * @return ListRulesResponse
     */
    public function listRules($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListRulesHeaders([]);

        return $this->listRulesWithOptions($request, $headers, $runtime);
    }

    /**
     * @param LogoutRequest  $request
     * @param LogoutHeaders  $headers
     * @param RuntimeOptions $runtime
     *
     * @return LogoutResponse
     */
    public function logoutWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->deviceType)) {
            $body['deviceType'] = $request->deviceType;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'Logout',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/users/logout',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return LogoutResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param LogoutRequest $request
     *
     * @return LogoutResponse
     */
    public function logout($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new LogoutHeaders([]);

        return $this->logoutWithOptions($request, $headers, $runtime);
    }

    /**
     * @param PreventCheatingCheckRiskRequest $request
     * @param PreventCheatingCheckRiskHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return PreventCheatingCheckRiskResponse
     */
    public function preventCheatingCheckRiskWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->clientVer)) {
            $body['clientVer'] = $request->clientVer;
        }
        if (!Utils::isUnset($request->platform)) {
            $body['platform'] = $request->platform;
        }
        if (!Utils::isUnset($request->platformVer)) {
            $body['platformVer'] = $request->platformVer;
        }
        if (!Utils::isUnset($request->sec)) {
            $body['sec'] = $request->sec;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'PreventCheatingCheckRisk',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/preventCheats/risks/check',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return PreventCheatingCheckRiskResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param PreventCheatingCheckRiskRequest $request
     *
     * @return PreventCheatingCheckRiskResponse
     */
    public function preventCheatingCheckRisk($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PreventCheatingCheckRiskHeaders([]);

        return $this->preventCheatingCheckRiskWithOptions($request, $headers, $runtime);
    }

    /**
     * @param PublishFileChangeNoticeRequest $request
     * @param PublishFileChangeNoticeHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return PublishFileChangeNoticeResponse
     */
    public function publishFileChangeNoticeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->fileId)) {
            $body['fileId'] = $request->fileId;
        }
        if (!Utils::isUnset($request->operateType)) {
            $body['operateType'] = $request->operateType;
        }
        if (!Utils::isUnset($request->operatorUnionId)) {
            $body['operatorUnionId'] = $request->operatorUnionId;
        }
        if (!Utils::isUnset($request->spaceId)) {
            $body['spaceId'] = $request->spaceId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'PublishFileChangeNotice',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/comments/send',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'none',
        ]);

        return PublishFileChangeNoticeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param PublishFileChangeNoticeRequest $request
     *
     * @return PublishFileChangeNoticeResponse
     */
    public function publishFileChangeNotice($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PublishFileChangeNoticeHeaders([]);

        return $this->publishFileChangeNoticeWithOptions($request, $headers, $runtime);
    }

    /**
     * @param PublishRuleRequest $request
     * @param PublishRuleHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return PublishRuleResponse
     */
    public function publishRuleWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->status)) {
            $body['status'] = $request->status;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'PublishRule',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/messageCategories/rules/publish',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return PublishRuleResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param PublishRuleRequest $request
     *
     * @return PublishRuleResponse
     */
    public function publishRule($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PublishRuleHeaders([]);

        return $this->publishRuleWithOptions($request, $headers, $runtime);
    }

    /**
     * @param PushBadgeRequest $request
     * @param PushBadgeHeaders $headers
     * @param RuntimeOptions   $runtime
     *
     * @return PushBadgeResponse
     */
    public function pushBadgeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->agentId)) {
            $body['agentId'] = $request->agentId;
        }
        if (!Utils::isUnset($request->badgeItems)) {
            $body['badgeItems'] = $request->badgeItems;
        }
        if (!Utils::isUnset($request->pushType)) {
            $body['pushType'] = $request->pushType;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'PushBadge',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/exclusiveDesigns/redPoints/push',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return PushBadgeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param PushBadgeRequest $request
     *
     * @return PushBadgeResponse
     */
    public function pushBadge($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PushBadgeHeaders([]);

        return $this->pushBadgeWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryAcrossCloudStroageConfigsRequest $request
     * @param QueryAcrossCloudStroageConfigsHeaders $headers
     * @param RuntimeOptions                        $runtime
     *
     * @return QueryAcrossCloudStroageConfigsResponse
     */
    public function queryAcrossCloudStroageConfigsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->targetCloudType)) {
            $query['targetCloudType'] = $request->targetCloudType;
        }
        if (!Utils::isUnset($request->targetCorpId)) {
            $query['targetCorpId'] = $request->targetCorpId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'QueryAcrossCloudStroageConfigs',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/fileStorages/acrossClouds/configurations',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryAcrossCloudStroageConfigsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryAcrossCloudStroageConfigsRequest $request
     *
     * @return QueryAcrossCloudStroageConfigsResponse
     */
    public function queryAcrossCloudStroageConfigs($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryAcrossCloudStroageConfigsHeaders([]);

        return $this->queryAcrossCloudStroageConfigsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                  $userId
     * @param QueryPartnerInfoHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return QueryPartnerInfoResponse
     */
    public function queryPartnerInfoWithOptions($userId, $headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);
        $params = new Params([
            'action'      => 'QueryPartnerInfo',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/partners/users/' . $userId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryPartnerInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string $userId
     *
     * @return QueryPartnerInfoResponse
     */
    public function queryPartnerInfo($userId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryPartnerInfoHeaders([]);

        return $this->queryPartnerInfoWithOptions($userId, $headers, $runtime);
    }

    /**
     * @param QueryUserBehaviorRequest $request
     * @param QueryUserBehaviorHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return QueryUserBehaviorResponse
     */
    public function queryUserBehaviorWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->endTime)) {
            $body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $body['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->platform)) {
            $body['platform'] = $request->platform;
        }
        if (!Utils::isUnset($request->startTime)) {
            $body['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->type)) {
            $body['type'] = $request->type;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'QueryUserBehavior',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/enterpriseSecurities/userBehaviors/screenshots/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryUserBehaviorResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryUserBehaviorRequest $request
     *
     * @return QueryUserBehaviorResponse
     */
    public function queryUserBehavior($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryUserBehaviorHeaders([]);

        return $this->queryUserBehaviorWithOptions($request, $headers, $runtime);
    }

    /**
     * @param RollbackMiniAppVersionRequest $request
     * @param RollbackMiniAppVersionHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return RollbackMiniAppVersionResponse
     */
    public function rollbackMiniAppVersionWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->miniAppId)) {
            $body['miniAppId'] = $request->miniAppId;
        }
        if (!Utils::isUnset($request->rollbackVersion)) {
            $body['rollbackVersion'] = $request->rollbackVersion;
        }
        if (!Utils::isUnset($request->targetVersion)) {
            $body['targetVersion'] = $request->targetVersion;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'RollbackMiniAppVersion',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/miniApps/versions/rollback',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return RollbackMiniAppVersionResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param RollbackMiniAppVersionRequest $request
     *
     * @return RollbackMiniAppVersionResponse
     */
    public function rollbackMiniAppVersion($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RollbackMiniAppVersionHeaders([]);

        return $this->rollbackMiniAppVersionWithOptions($request, $headers, $runtime);
    }

    /**
     * @param RuleBatchReceiverRequest $request
     * @param RuleBatchReceiverHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return RuleBatchReceiverResponse
     */
    public function ruleBatchReceiverWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->batchNo)) {
            $body['batchNo'] = $request->batchNo;
        }
        if (!Utils::isUnset($request->cardOptions)) {
            $body['cardOptions'] = $request->cardOptions;
        }
        if (!Utils::isUnset($request->data)) {
            $body['data'] = $request->data;
        }
        if (!Utils::isUnset($request->ruleCode)) {
            $body['ruleCode'] = $request->ruleCode;
        }
        if (!Utils::isUnset($request->secretKey)) {
            $body['secretKey'] = $request->secretKey;
        }
        if (!Utils::isUnset($request->specialStrategy)) {
            $body['specialStrategy'] = $request->specialStrategy;
        }
        if (!Utils::isUnset($request->taskBatchNo)) {
            $body['taskBatchNo'] = $request->taskBatchNo;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'RuleBatchReceiver',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/dmc/rules/messages/batchSend',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return RuleBatchReceiverResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param RuleBatchReceiverRequest $request
     *
     * @return RuleBatchReceiverResponse
     */
    public function ruleBatchReceiver($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RuleBatchReceiverHeaders([]);

        return $this->ruleBatchReceiverWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SaveAcrossCloudStroageConfigsRequest $request
     * @param SaveAcrossCloudStroageConfigsHeaders $headers
     * @param RuntimeOptions                       $runtime
     *
     * @return SaveAcrossCloudStroageConfigsResponse
     */
    public function saveAcrossCloudStroageConfigsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->accessKeyId)) {
            $body['accessKeyId'] = $request->accessKeyId;
        }
        if (!Utils::isUnset($request->accessKeySecret)) {
            $body['accessKeySecret'] = $request->accessKeySecret;
        }
        if (!Utils::isUnset($request->bucketName)) {
            $body['bucketName'] = $request->bucketName;
        }
        if (!Utils::isUnset($request->cloudType)) {
            $body['cloudType'] = $request->cloudType;
        }
        if (!Utils::isUnset($request->endpoint)) {
            $body['endpoint'] = $request->endpoint;
        }
        if (!Utils::isUnset($request->targetCorpId)) {
            $body['targetCorpId'] = $request->targetCorpId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'SaveAcrossCloudStroageConfigs',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/fileStorages/acrossClouds/configurations',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SaveAcrossCloudStroageConfigsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SaveAcrossCloudStroageConfigsRequest $request
     *
     * @return SaveAcrossCloudStroageConfigsResponse
     */
    public function saveAcrossCloudStroageConfigs($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SaveAcrossCloudStroageConfigsHeaders([]);

        return $this->saveAcrossCloudStroageConfigsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SaveAndSubmitAuthInfoRequest $request
     * @param SaveAndSubmitAuthInfoHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return SaveAndSubmitAuthInfoResponse
     */
    public function saveAndSubmitAuthInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->applyRemark)) {
            $body['applyRemark'] = $request->applyRemark;
        }
        if (!Utils::isUnset($request->authorizeMediaId)) {
            $body['authorizeMediaId'] = $request->authorizeMediaId;
        }
        if (!Utils::isUnset($request->industry)) {
            $body['industry'] = $request->industry;
        }
        if (!Utils::isUnset($request->legalPerson)) {
            $body['legalPerson'] = $request->legalPerson;
        }
        if (!Utils::isUnset($request->legalPersonIdCard)) {
            $body['legalPersonIdCard'] = $request->legalPersonIdCard;
        }
        if (!Utils::isUnset($request->licenseMediaId)) {
            $body['licenseMediaId'] = $request->licenseMediaId;
        }
        if (!Utils::isUnset($request->locCity)) {
            $body['locCity'] = $request->locCity;
        }
        if (!Utils::isUnset($request->locCityName)) {
            $body['locCityName'] = $request->locCityName;
        }
        if (!Utils::isUnset($request->locProvince)) {
            $body['locProvince'] = $request->locProvince;
        }
        if (!Utils::isUnset($request->locProvinceName)) {
            $body['locProvinceName'] = $request->locProvinceName;
        }
        if (!Utils::isUnset($request->mobileNum)) {
            $body['mobileNum'] = $request->mobileNum;
        }
        if (!Utils::isUnset($request->orgName)) {
            $body['orgName'] = $request->orgName;
        }
        if (!Utils::isUnset($request->organizationCode)) {
            $body['organizationCode'] = $request->organizationCode;
        }
        if (!Utils::isUnset($request->organizationCodeMediaId)) {
            $body['organizationCodeMediaId'] = $request->organizationCodeMediaId;
        }
        if (!Utils::isUnset($request->registLocation)) {
            $body['registLocation'] = $request->registLocation;
        }
        if (!Utils::isUnset($request->registNum)) {
            $body['registNum'] = $request->registNum;
        }
        if (!Utils::isUnset($request->targetCorpId)) {
            $body['targetCorpId'] = $request->targetCorpId;
        }
        if (!Utils::isUnset($request->unifiedSocialCredit)) {
            $body['unifiedSocialCredit'] = $request->unifiedSocialCredit;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'SaveAndSubmitAuthInfo',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/ognizations/authInfos/saveAndSubmit',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SaveAndSubmitAuthInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SaveAndSubmitAuthInfoRequest $request
     *
     * @return SaveAndSubmitAuthInfoResponse
     */
    public function saveAndSubmitAuthInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SaveAndSubmitAuthInfoHeaders([]);

        return $this->saveAndSubmitAuthInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SaveOpenTerminalInfoRequest $request
     * @param SaveOpenTerminalInfoHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return SaveOpenTerminalInfoResponse
     */
    public function saveOpenTerminalInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->logSource)) {
            $body['logSource'] = $request->logSource;
        }
        if (!Utils::isUnset($request->logType)) {
            $body['logType'] = $request->logType;
        }
        if (!Utils::isUnset($request->openExt)) {
            $body['openExt'] = $request->openExt;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'SaveOpenTerminalInfo',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/externalLogs/terminalInfos/save',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SaveOpenTerminalInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SaveOpenTerminalInfoRequest $request
     *
     * @return SaveOpenTerminalInfoResponse
     */
    public function saveOpenTerminalInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SaveOpenTerminalInfoHeaders([]);

        return $this->saveOpenTerminalInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SaveWhiteAppRequest $request
     * @param SaveWhiteAppHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return SaveWhiteAppResponse
     */
    public function saveWhiteAppWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->agentIdList)) {
            $body['agentIdList'] = $request->agentIdList;
        }
        if (!Utils::isUnset($request->agentIdMap)) {
            $body['agentIdMap'] = $request->agentIdMap;
        }
        if (!Utils::isUnset($request->operation)) {
            $body['operation'] = $request->operation;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'SaveWhiteApp',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/miniApps/whiteLists/save',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SaveWhiteAppResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SaveWhiteAppRequest $request
     *
     * @return SaveWhiteAppResponse
     */
    public function saveWhiteApp($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SaveWhiteAppHeaders([]);

        return $this->saveWhiteAppWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SearchOrgInnerGroupInfoRequest $request
     * @param SearchOrgInnerGroupInfoHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return SearchOrgInnerGroupInfoResponse
     */
    public function searchOrgInnerGroupInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->createTimeEnd)) {
            $query['createTimeEnd'] = $request->createTimeEnd;
        }
        if (!Utils::isUnset($request->createTimeStart)) {
            $query['createTimeStart'] = $request->createTimeStart;
        }
        if (!Utils::isUnset($request->groupMembersCountEnd)) {
            $query['groupMembersCountEnd'] = $request->groupMembersCountEnd;
        }
        if (!Utils::isUnset($request->groupMembersCountStart)) {
            $query['groupMembersCountStart'] = $request->groupMembersCountStart;
        }
        if (!Utils::isUnset($request->groupName)) {
            $query['groupName'] = $request->groupName;
        }
        if (!Utils::isUnset($request->groupOwner)) {
            $query['groupOwner'] = $request->groupOwner;
        }
        if (!Utils::isUnset($request->lastActiveTimeEnd)) {
            $query['lastActiveTimeEnd'] = $request->lastActiveTimeEnd;
        }
        if (!Utils::isUnset($request->lastActiveTimeStart)) {
            $query['lastActiveTimeStart'] = $request->lastActiveTimeStart;
        }
        if (!Utils::isUnset($request->operatorUserId)) {
            $query['operatorUserId'] = $request->operatorUserId;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->pageStart)) {
            $query['pageStart'] = $request->pageStart;
        }
        if (!Utils::isUnset($request->syncToDingpan)) {
            $query['syncToDingpan'] = $request->syncToDingpan;
        }
        if (!Utils::isUnset($request->uuid)) {
            $query['uuid'] = $request->uuid;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'SearchOrgInnerGroupInfo',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/securities/orgGroupInfos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SearchOrgInnerGroupInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SearchOrgInnerGroupInfoRequest $request
     *
     * @return SearchOrgInnerGroupInfoResponse
     */
    public function searchOrgInnerGroupInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchOrgInnerGroupInfoHeaders([]);

        return $this->searchOrgInnerGroupInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SendAppDingRequest $request
     * @param SendAppDingHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return SendAppDingResponse
     */
    public function sendAppDingWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->content)) {
            $body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->userids)) {
            $body['userids'] = $request->userids;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'SendAppDing',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/appDings/send',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'none',
        ]);

        return SendAppDingResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SendAppDingRequest $request
     *
     * @return SendAppDingResponse
     */
    public function sendAppDing($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendAppDingHeaders([]);

        return $this->sendAppDingWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SendInvitationRequest $request
     * @param SendInvitationHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return SendInvitationResponse
     */
    public function sendInvitationWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->deptId)) {
            $body['deptId'] = $request->deptId;
        }
        if (!Utils::isUnset($request->orgAlias)) {
            $body['orgAlias'] = $request->orgAlias;
        }
        if (!Utils::isUnset($request->partnerLabelId)) {
            $body['partnerLabelId'] = $request->partnerLabelId;
        }
        if (!Utils::isUnset($request->partnerNum)) {
            $body['partnerNum'] = $request->partnerNum;
        }
        if (!Utils::isUnset($request->phone)) {
            $body['phone'] = $request->phone;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'SendInvitation',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/partnerDepartments/invitations/send',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'none',
        ]);

        return SendInvitationResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SendInvitationRequest $request
     *
     * @return SendInvitationResponse
     */
    public function sendInvitation($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendInvitationHeaders([]);

        return $this->sendInvitationWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SendPhoneDingRequest $request
     * @param SendPhoneDingHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return SendPhoneDingResponse
     */
    public function sendPhoneDingWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->content)) {
            $body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->userids)) {
            $body['userids'] = $request->userids;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'SendPhoneDing',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/phoneDings/send',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SendPhoneDingResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SendPhoneDingRequest $request
     *
     * @return SendPhoneDingResponse
     */
    public function sendPhoneDing($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendPhoneDingHeaders([]);

        return $this->sendPhoneDingWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SetDeptPartnerTypeAndNumRequest $request
     * @param SetDeptPartnerTypeAndNumHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return SetDeptPartnerTypeAndNumResponse
     */
    public function setDeptPartnerTypeAndNumWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->deptId)) {
            $body['deptId'] = $request->deptId;
        }
        if (!Utils::isUnset($request->labelIds)) {
            $body['labelIds'] = $request->labelIds;
        }
        if (!Utils::isUnset($request->partnerNum)) {
            $body['partnerNum'] = $request->partnerNum;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'SetDeptPartnerTypeAndNum',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/partnerDepartments',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return SetDeptPartnerTypeAndNumResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SetDeptPartnerTypeAndNumRequest $request
     *
     * @return SetDeptPartnerTypeAndNumResponse
     */
    public function setDeptPartnerTypeAndNum($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SetDeptPartnerTypeAndNumHeaders([]);

        return $this->setDeptPartnerTypeAndNumWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SpecialRuleBatchReceiverRequest $request
     * @param SpecialRuleBatchReceiverHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return SpecialRuleBatchReceiverResponse
     */
    public function specialRuleBatchReceiverWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->batchNo)) {
            $body['batchNo'] = $request->batchNo;
        }
        if (!Utils::isUnset($request->cardOptions)) {
            $body['cardOptions'] = $request->cardOptions;
        }
        if (!Utils::isUnset($request->data)) {
            $body['data'] = $request->data;
        }
        if (!Utils::isUnset($request->ruleCode)) {
            $body['ruleCode'] = $request->ruleCode;
        }
        if (!Utils::isUnset($request->secretKey)) {
            $body['secretKey'] = $request->secretKey;
        }
        if (!Utils::isUnset($request->specialStrategy)) {
            $body['specialStrategy'] = $request->specialStrategy;
        }
        if (!Utils::isUnset($request->taskBatchNo)) {
            $body['taskBatchNo'] = $request->taskBatchNo;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'SpecialRuleBatchReceiver',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/dmc/rules/specialMessages/batchSend',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SpecialRuleBatchReceiverResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SpecialRuleBatchReceiverRequest $request
     *
     * @return SpecialRuleBatchReceiverResponse
     */
    public function specialRuleBatchReceiver($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SpecialRuleBatchReceiverHeaders([]);

        return $this->specialRuleBatchReceiverWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateCategoryNameRequest $request
     * @param UpdateCategoryNameHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return UpdateCategoryNameResponse
     */
    public function updateCategoryNameWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->currentCategoryName)) {
            $body['currentCategoryName'] = $request->currentCategoryName;
        }
        if (!Utils::isUnset($request->targetCategoryName)) {
            $body['targetCategoryName'] = $request->targetCategoryName;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'UpdateCategoryName',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/messageCategories/categories/names',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateCategoryNameResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param UpdateCategoryNameRequest $request
     *
     * @return UpdateCategoryNameResponse
     */
    public function updateCategoryName($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateCategoryNameHeaders([]);

        return $this->updateCategoryNameWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateFileStatusRequest $request
     * @param UpdateFileStatusHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return UpdateFileStatusResponse
     */
    public function updateFileStatusWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->requestIds)) {
            $body['requestIds'] = $request->requestIds;
        }
        if (!Utils::isUnset($request->status)) {
            $body['status'] = $request->status;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'UpdateFileStatus',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/sending/files/status',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateFileStatusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param UpdateFileStatusRequest $request
     *
     * @return UpdateFileStatusResponse
     */
    public function updateFileStatus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateFileStatusHeaders([]);

        return $this->updateFileStatusWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateMiniAppVersionStatusRequest $request
     * @param UpdateMiniAppVersionStatusHeaders $headers
     * @param RuntimeOptions                    $runtime
     *
     * @return UpdateMiniAppVersionStatusResponse
     */
    public function updateMiniAppVersionStatusWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->miniAppId)) {
            $body['miniAppId'] = $request->miniAppId;
        }
        if (!Utils::isUnset($request->version)) {
            $body['version'] = $request->version;
        }
        if (!Utils::isUnset($request->versionType)) {
            $body['versionType'] = $request->versionType;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'UpdateMiniAppVersionStatus',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/miniApps/versions/versionStatus',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return UpdateMiniAppVersionStatusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param UpdateMiniAppVersionStatusRequest $request
     *
     * @return UpdateMiniAppVersionStatusResponse
     */
    public function updateMiniAppVersionStatus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateMiniAppVersionStatusHeaders([]);

        return $this->updateMiniAppVersionStatusWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdatePartnerVisibilityRequest $request
     * @param UpdatePartnerVisibilityHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return UpdatePartnerVisibilityResponse
     */
    public function updatePartnerVisibilityWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->deptIds)) {
            $body['deptIds'] = $request->deptIds;
        }
        if (!Utils::isUnset($request->labelId)) {
            $body['labelId'] = $request->labelId;
        }
        if (!Utils::isUnset($request->userIds)) {
            $body['userIds'] = $request->userIds;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'UpdatePartnerVisibility',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/partnerDepartments/visibilityPartners',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'boolean',
        ]);

        return UpdatePartnerVisibilityResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param UpdatePartnerVisibilityRequest $request
     *
     * @return UpdatePartnerVisibilityResponse
     */
    public function updatePartnerVisibility($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdatePartnerVisibilityHeaders([]);

        return $this->updatePartnerVisibilityWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateRoleVisibilityRequest $request
     * @param UpdateRoleVisibilityHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return UpdateRoleVisibilityResponse
     */
    public function updateRoleVisibilityWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->deptIds)) {
            $body['deptIds'] = $request->deptIds;
        }
        if (!Utils::isUnset($request->labelId)) {
            $body['labelId'] = $request->labelId;
        }
        if (!Utils::isUnset($request->userIds)) {
            $body['userIds'] = $request->userIds;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'UpdateRoleVisibility',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/partnerDepartments/visibilityRoles',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'boolean',
        ]);

        return UpdateRoleVisibilityResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param UpdateRoleVisibilityRequest $request
     *
     * @return UpdateRoleVisibilityResponse
     */
    public function updateRoleVisibility($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateRoleVisibilityHeaders([]);

        return $this->updateRoleVisibilityWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateStorageModeRequest $request
     * @param UpdateStorageModeHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return UpdateStorageModeResponse
     */
    public function updateStorageModeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->fileStorageMode)) {
            $body['fileStorageMode'] = $request->fileStorageMode;
        }
        if (!Utils::isUnset($request->targetCorpId)) {
            $body['targetCorpId'] = $request->targetCorpId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'UpdateStorageMode',
            'version'     => 'exclusive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/exclusive/fileStorages/acrossClouds/storageModes',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateStorageModeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param UpdateStorageModeRequest $request
     *
     * @return UpdateStorageModeResponse
     */
    public function updateStorageMode($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateStorageModeHeaders([]);

        return $this->updateStorageModeWithOptions($request, $headers, $runtime);
    }
}
