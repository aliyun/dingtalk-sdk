<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\AddCustomSignConfigHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\AddCustomSignConfigRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\AddCustomSignConfigResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\AddOrgHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\AddOrgRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\AddOrgResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ApproveProcessCallbackHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ApproveProcessCallbackRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ApproveProcessCallbackResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\BanOrOpenGroupWordsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\BanOrOpenGroupWordsRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\BanOrOpenGroupWordsResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\BusinessEventUpdateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\BusinessEventUpdateRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\BusinessEventUpdateResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\CheckControlHitStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\CheckControlHitStatusRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\CheckControlHitStatusResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\CreateCategoryAndBindingGroupsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\CreateCategoryAndBindingGroupsRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\CreateCategoryAndBindingGroupsResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\CreateDlpTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\CreateDlpTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\CreateDlpTaskResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\CreateVirusScanTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\CreateVirusScanTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\CreateVirusScanTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\DataSyncHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\DataSyncRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\DataSyncResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\EditSecurityConfigMemberHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\EditSecurityConfigMemberRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\EditSecurityConfigMemberResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ExchangeMainAdminHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ExchangeMainAdminRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ExchangeMainAdminResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetCidsByBotCodeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetCidsByBotCodeRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetCidsByBotCodeResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetClassTagHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetClassTagRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetClassTagResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetCommentListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetCommentListRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetCommentListResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetConfBaseInfoByLogicalIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetConfBaseInfoByLogicalIdRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetConfBaseInfoByLogicalIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetConferenceDetailHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetConferenceDetailResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetConversationCategoryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetConversationCategoryResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetConversationDetailHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetConversationDetailRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetConversationDetailResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetGroupInfoByCidHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetGroupInfoByCidRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetGroupInfoByCidResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetGroupOrgByCidHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetGroupOrgByCidRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetGroupOrgByCidResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetInActiveUserListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetInActiveUserListRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetInActiveUserListResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetLastOrgAuthDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetLastOrgAuthDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetLastOrgAuthDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetMsgConfigHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetMsgConfigRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetMsgConfigResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetMsgLocationHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetMsgLocationRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetMsgLocationResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetPrivateStoreCapacityUsageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetPrivateStoreCapacityUsageRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetPrivateStoreCapacityUsageResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetPrivateStoreFileInfosByPageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetPrivateStoreFileInfosByPageRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetPrivateStoreFileInfosByPageResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetPrivateStoreFilePathHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetPrivateStoreFilePathRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetPrivateStoreFilePathResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetRobotInfoByCodeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetRobotInfoByCodeRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetRobotInfoByCodeResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetSecurityConfigMemberHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetSecurityConfigMemberRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetSecurityConfigMemberResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetVirusScanResultHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetVirusScanResultRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetVirusScanResultResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GroupQueryByAttrHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GroupQueryByAttrRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GroupQueryByAttrResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GroupQueryByOpenIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GroupQueryByOpenIdRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GroupQueryByOpenIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListAuditLogHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListAuditLogRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListAuditLogResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListByCodesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListByCodesRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListByCodesResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListByPluginIdsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListByPluginIdsRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListByPluginIdsResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\OpenBenefitPackageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\OpenBenefitPackageRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\OpenBenefitPackageResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\OpportunitySearchHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\OpportunitySearchRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\OpportunitySearchResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\QueryChannelStaffInfoByMobileHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\QueryChannelStaffInfoByMobileRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\QueryChannelStaffInfoByMobileResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\QueryConversationPageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\QueryConversationPageRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\QueryConversationPageResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\QueryExclusiveBenefitsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\QueryExclusiveBenefitsResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\QueryPartnerInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\QueryPartnerInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\QueryTemplateInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\QueryTemplateInfoResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SaveStorageFunctionSwitchHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SaveStorageFunctionSwitchRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SaveStorageFunctionSwitchResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SaveStorageSwitchHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SaveStorageSwitchRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SaveStorageSwitchResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SetConversationCategoryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SetConversationCategoryRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SetConversationCategoryResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SetConversationSubtitleHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SetConversationSubtitleRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SetConversationSubtitleResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SetConversationTopCategoryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SetConversationTopCategoryRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SetConversationTopCategoryResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SetDeptPartnerTypeAndNumHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SetDeptPartnerTypeAndNumRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SetDeptPartnerTypeAndNumResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SetOrgTopConversationCategoryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SetOrgTopConversationCategoryRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SetOrgTopConversationCategoryResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SpecialRuleBatchReceiverHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SpecialRuleBatchReceiverRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SpecialRuleBatchReceiverResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\TaskInfoAddDelTaskPersonHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\TaskInfoAddDelTaskPersonRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\TaskInfoAddDelTaskPersonResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\TaskInfoCancelOrDelTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\TaskInfoCancelOrDelTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\TaskInfoCancelOrDelTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\TaskInfoCreateAndStartTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\TaskInfoCreateAndStartTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\TaskInfoCreateAndStartTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\TaskInfoFinishTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\TaskInfoFinishTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\TaskInfoFinishTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\TaskInfoUpdateTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\TaskInfoUpdateTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\TaskInfoUpdateTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\TransferExclusiveAccountOrgHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\TransferExclusiveAccountOrgRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\TransferExclusiveAccountOrgResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\UpdateCategoryNameHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\UpdateCategoryNameRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\UpdateCategoryNameResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\UpdateConversationTypeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\UpdateConversationTypeRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\UpdateConversationTypeResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\UpdateFileStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\UpdateFileStatusRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\UpdateFileStatusResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\UpdateMiniAppVersionStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\UpdateMiniAppVersionStatusRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\UpdateMiniAppVersionStatusResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\UpdatePartnerVisibilityHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\UpdatePartnerVisibilityRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\UpdatePartnerVisibilityResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\UpdateRealmLicenseHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\UpdateRealmLicenseRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\UpdateRealmLicenseResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\UpdateRoleVisibilityHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\UpdateRoleVisibilityRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\UpdateRoleVisibilityResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\UpdateStorageModeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\UpdateStorageModeRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\UpdateStorageModeResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\UpdateTrustedDeviceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\UpdateTrustedDeviceRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\UpdateTrustedDeviceResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\UpdateVoiceMsgCtrlStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\UpdateVoiceMsgCtrlStatusRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\UpdateVoiceMsgCtrlStatusResponse;
use AlibabaCloud\Tea\Utils\Utils;
use AlibabaCloud\Tea\Utils\Utils\RuntimeOptions;
use Darabonba\GatewayDingTalk\Client;
use Darabonba\OpenApi\Models\OpenApiRequest;
use Darabonba\OpenApi\Models\Params;
use Darabonba\OpenApi\OpenApiClient;

class Dingtalk extends OpenApiClient
{
    public function __construct($config)
    {
        parent::__construct($config);
        $gatewayClient = new Client();
        $this->_spi = $gatewayClient;
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @summary 添加自主协议
     *  *
     * @param AddCustomSignConfigRequest $request AddCustomSignConfigRequest
     * @param AddCustomSignConfigHeaders $headers AddCustomSignConfigHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return AddCustomSignConfigResponse AddCustomSignConfigResponse
     */
    public function addCustomSignConfigWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->allEffect)) {
            $body['allEffect'] = $request->allEffect;
        }
        if (!Utils::isUnset($request->canDownload)) {
            $body['canDownload'] = $request->canDownload;
        }
        if (!Utils::isUnset($request->protocolName)) {
            $body['protocolName'] = $request->protocolName;
        }
        if (!Utils::isUnset($request->pushDeptIds)) {
            $body['pushDeptIds'] = $request->pushDeptIds;
        }
        if (!Utils::isUnset($request->pushStaffIds)) {
            $body['pushStaffIds'] = $request->pushStaffIds;
        }
        if (!Utils::isUnset($request->signTermFiles)) {
            $body['signTermFiles'] = $request->signTermFiles;
        }
        if (!Utils::isUnset($request->termMessage)) {
            $body['termMessage'] = $request->termMessage;
        }
        if (!Utils::isUnset($request->unpushDeptIds)) {
            $body['unpushDeptIds'] = $request->unpushDeptIds;
        }
        if (!Utils::isUnset($request->unpushStaffIds)) {
            $body['unpushStaffIds'] = $request->unpushStaffIds;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'AddCustomSignConfig',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/sign/addCustomSignConfig',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return AddCustomSignConfigResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 添加自主协议
     *  *
     * @param AddCustomSignConfigRequest $request AddCustomSignConfigRequest
     *
     * @return AddCustomSignConfigResponse AddCustomSignConfigResponse
     */
    public function addCustomSignConfig($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddCustomSignConfigHeaders([]);

        return $this->addCustomSignConfigWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 新增企业
     *  *
     * @param AddOrgRequest  $request AddOrgRequest
     * @param AddOrgHeaders  $headers AddOrgHeaders
     * @param RuntimeOptions $runtime runtime options for this request RuntimeOptions
     *
     * @return AddOrgResponse AddOrgResponse
     */
    public function addOrgWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->city)) {
            $body['city'] = $request->city;
        }
        if (!Utils::isUnset($request->industry)) {
            $body['industry'] = $request->industry;
        }
        if (!Utils::isUnset($request->industryCode)) {
            $body['industryCode'] = $request->industryCode;
        }
        if (!Utils::isUnset($request->mobileNum)) {
            $body['mobileNum'] = $request->mobileNum;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->province)) {
            $body['province'] = $request->province;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'AddOrg',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/orgnizations',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return AddOrgResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 新增企业
     *  *
     * @param AddOrgRequest $request AddOrgRequest
     *
     * @return AddOrgResponse AddOrgResponse
     */
    public function addOrg($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddOrgHeaders([]);

        return $this->addOrgWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 专属审批结果回调
     *  *
     * @param ApproveProcessCallbackRequest $request ApproveProcessCallbackRequest
     * @param ApproveProcessCallbackHeaders $headers ApproveProcessCallbackHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return ApproveProcessCallbackResponse ApproveProcessCallbackResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'ApproveProcessCallback',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/approvalResults/callback',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ApproveProcessCallbackResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 专属审批结果回调
     *  *
     * @param ApproveProcessCallbackRequest $request ApproveProcessCallbackRequest
     *
     * @return ApproveProcessCallbackResponse ApproveProcessCallbackResponse
     */
    public function approveProcessCallback($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ApproveProcessCallbackHeaders([]);

        return $this->approveProcessCallbackWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 群禁言或解禁
     *  *
     * @param BanOrOpenGroupWordsRequest $request BanOrOpenGroupWordsRequest
     * @param BanOrOpenGroupWordsHeaders $headers BanOrOpenGroupWordsHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return BanOrOpenGroupWordsResponse BanOrOpenGroupWordsResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'BanOrOpenGroupWords',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/enterpriseSecurities/banOrOpenGroupWords',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return BanOrOpenGroupWordsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 群禁言或解禁
     *  *
     * @param BanOrOpenGroupWordsRequest $request BanOrOpenGroupWordsRequest
     *
     * @return BanOrOpenGroupWordsResponse BanOrOpenGroupWordsResponse
     */
    public function banOrOpenGroupWords($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BanOrOpenGroupWordsHeaders([]);

        return $this->banOrOpenGroupWordsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 业务融合群业务事件变更
     *  *
     * @param BusinessEventUpdateRequest $request BusinessEventUpdateRequest
     * @param BusinessEventUpdateHeaders $headers BusinessEventUpdateHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return BusinessEventUpdateResponse BusinessEventUpdateResponse
     */
    public function businessEventUpdateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->businessData)) {
            $body['businessData'] = $request->businessData;
        }
        if (!Utils::isUnset($request->eventType)) {
            $body['eventType'] = $request->eventType;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->updateByKey)) {
            $body['updateByKey'] = $request->updateByKey;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'BusinessEventUpdate',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/businessGroups/events',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return BusinessEventUpdateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 业务融合群业务事件变更
     *  *
     * @param BusinessEventUpdateRequest $request BusinessEventUpdateRequest
     *
     * @return BusinessEventUpdateResponse BusinessEventUpdateResponse
     */
    public function businessEventUpdate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BusinessEventUpdateHeaders([]);

        return $this->businessEventUpdateWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 检测安全管控功能命中状态
     *  *
     * @param CheckControlHitStatusRequest $request CheckControlHitStatusRequest
     * @param CheckControlHitStatusHeaders $headers CheckControlHitStatusHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return CheckControlHitStatusResponse CheckControlHitStatusResponse
     */
    public function checkControlHitStatusWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->needMissedFunction)) {
            $query['needMissedFunction'] = $request->needMissedFunction;
        }
        if (!Utils::isUnset($request->userId)) {
            $query['userId'] = $request->userId;
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'CheckControlHitStatus',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/soc/functionHitStatuses/check',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CheckControlHitStatusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 检测安全管控功能命中状态
     *  *
     * @param CheckControlHitStatusRequest $request CheckControlHitStatusRequest
     *
     * @return CheckControlHitStatusResponse CheckControlHitStatusResponse
     */
    public function checkControlHitStatus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CheckControlHitStatusHeaders([]);

        return $this->checkControlHitStatusWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建分组并绑定会话
     *  *
     * @param CreateCategoryAndBindingGroupsRequest $request CreateCategoryAndBindingGroupsRequest
     * @param CreateCategoryAndBindingGroupsHeaders $headers CreateCategoryAndBindingGroupsHeaders
     * @param RuntimeOptions                        $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateCategoryAndBindingGroupsResponse CreateCategoryAndBindingGroupsResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CreateCategoryAndBindingGroups',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/messageCategories/categories/createAndBind',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateCategoryAndBindingGroupsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建分组并绑定会话
     *  *
     * @param CreateCategoryAndBindingGroupsRequest $request CreateCategoryAndBindingGroupsRequest
     *
     * @return CreateCategoryAndBindingGroupsResponse CreateCategoryAndBindingGroupsResponse
     */
    public function createCategoryAndBindingGroups($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateCategoryAndBindingGroupsHeaders([]);

        return $this->createCategoryAndBindingGroupsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建文件检测任务
     *  *
     * @param CreateDlpTaskRequest $request CreateDlpTaskRequest
     * @param CreateDlpTaskHeaders $headers CreateDlpTaskHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateDlpTaskResponse CreateDlpTaskResponse
     */
    public function createDlpTaskWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->dentryId)) {
            $body['dentryId'] = $request->dentryId;
        }
        if (!Utils::isUnset($request->spaceId)) {
            $body['spaceId'] = $request->spaceId;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CreateDlpTask',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/dlpTasks',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateDlpTaskResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建文件检测任务
     *  *
     * @param CreateDlpTaskRequest $request CreateDlpTaskRequest
     *
     * @return CreateDlpTaskResponse CreateDlpTaskResponse
     */
    public function createDlpTask($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateDlpTaskHeaders([]);

        return $this->createDlpTaskWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建分组并绑定会话
     *  *
     * @param CreateMessageCategoryRequest $request CreateMessageCategoryRequest
     * @param CreateMessageCategoryHeaders $headers CreateMessageCategoryHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateMessageCategoryResponse CreateMessageCategoryResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CreateMessageCategory',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/messageCategories/categories/create',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateMessageCategoryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建分组并绑定会话
     *  *
     * @param CreateMessageCategoryRequest $request CreateMessageCategoryRequest
     *
     * @return CreateMessageCategoryResponse CreateMessageCategoryResponse
     */
    public function createMessageCategory($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateMessageCategoryHeaders([]);

        return $this->createMessageCategoryWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建规则
     *  *
     * @param CreateRuleRequest $request CreateRuleRequest
     * @param CreateRuleHeaders $headers CreateRuleHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateRuleResponse CreateRuleResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CreateRule',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/messageCategories/rules',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateRuleResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建规则
     *  *
     * @param CreateRuleRequest $request CreateRuleRequest
     *
     * @return CreateRuleResponse CreateRuleResponse
     */
    public function createRule($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateRuleHeaders([]);

        return $this->createRuleWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 存入可信设备信息
     *  *
     * @param CreateTrustedDeviceRequest $request CreateTrustedDeviceRequest
     * @param CreateTrustedDeviceHeaders $headers CreateTrustedDeviceHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateTrustedDeviceResponse CreateTrustedDeviceResponse
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
        if (!Utils::isUnset($request->title)) {
            $body['title'] = $request->title;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CreateTrustedDevice',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/trustedDevices',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateTrustedDeviceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 存入可信设备信息
     *  *
     * @param CreateTrustedDeviceRequest $request CreateTrustedDeviceRequest
     *
     * @return CreateTrustedDeviceResponse CreateTrustedDeviceResponse
     */
    public function createTrustedDevice($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateTrustedDeviceHeaders([]);

        return $this->createTrustedDeviceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量新增可信设备
     *  *
     * @param CreateTrustedDeviceBatchRequest $request CreateTrustedDeviceBatchRequest
     * @param CreateTrustedDeviceBatchHeaders $headers CreateTrustedDeviceBatchHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateTrustedDeviceBatchResponse CreateTrustedDeviceBatchResponse
     */
    public function createTrustedDeviceBatchWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->detailList)) {
            $body['detailList'] = $request->detailList;
        }
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CreateTrustedDeviceBatch',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/trusts/devices',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateTrustedDeviceBatchResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量新增可信设备
     *  *
     * @param CreateTrustedDeviceBatchRequest $request CreateTrustedDeviceBatchRequest
     *
     * @return CreateTrustedDeviceBatchResponse CreateTrustedDeviceBatchResponse
     */
    public function createTrustedDeviceBatch($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateTrustedDeviceBatchHeaders([]);

        return $this->createTrustedDeviceBatchWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 触发文件病毒扫描任务
     *  *
     * @param CreateVirusScanTaskRequest $request CreateVirusScanTaskRequest
     * @param CreateVirusScanTaskHeaders $headers CreateVirusScanTaskHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateVirusScanTaskResponse CreateVirusScanTaskResponse
     */
    public function createVirusScanTaskWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->dentryId)) {
            $body['dentryId'] = $request->dentryId;
        }
        if (!Utils::isUnset($request->downloadUrl)) {
            $body['downloadUrl'] = $request->downloadUrl;
        }
        if (!Utils::isUnset($request->fileMd5)) {
            $body['fileMd5'] = $request->fileMd5;
        }
        if (!Utils::isUnset($request->fileName)) {
            $body['fileName'] = $request->fileName;
        }
        if (!Utils::isUnset($request->fileSize)) {
            $body['fileSize'] = $request->fileSize;
        }
        if (!Utils::isUnset($request->source)) {
            $body['source'] = $request->source;
        }
        if (!Utils::isUnset($request->spaceId)) {
            $body['spaceId'] = $request->spaceId;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CreateVirusScanTask',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/virusScanTasks',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateVirusScanTaskResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 触发文件病毒扫描任务
     *  *
     * @param CreateVirusScanTaskRequest $request CreateVirusScanTaskRequest
     *
     * @return CreateVirusScanTaskResponse CreateVirusScanTaskResponse
     */
    public function createVirusScanTask($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateVirusScanTaskHeaders([]);

        return $this->createVirusScanTaskWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 为应用同步数据到专属存储
     *  *
     * @param DataSyncRequest $request DataSyncRequest
     * @param DataSyncHeaders $headers DataSyncHeaders
     * @param RuntimeOptions  $runtime runtime options for this request RuntimeOptions
     *
     * @return DataSyncResponse DataSyncResponse
     */
    public function dataSyncWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->sql)) {
            $body['sql'] = $request->sql;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'DataSync',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/datas/sync',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return DataSyncResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 为应用同步数据到专属存储
     *  *
     * @param DataSyncRequest $request DataSyncRequest
     *
     * @return DataSyncResponse DataSyncResponse
     */
    public function dataSync($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DataSyncHeaders([]);

        return $this->dataSyncWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除跨云存储配置
     *  *
     * @param string                                 $targetCorpId
     * @param DeleteAcrossCloudStroageConfigsHeaders $headers      DeleteAcrossCloudStroageConfigsHeaders
     * @param RuntimeOptions                         $runtime      runtime options for this request RuntimeOptions
     *
     * @return DeleteAcrossCloudStroageConfigsResponse DeleteAcrossCloudStroageConfigsResponse
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
            'action' => 'DeleteAcrossCloudStroageConfigs',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/fileStorages/acrossClouds/configurations/' . $targetCorpId . '',
            'method' => 'DELETE',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return DeleteAcrossCloudStroageConfigsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除跨云存储配置
     *  *
     * @param string $targetCorpId
     *
     * @return DeleteAcrossCloudStroageConfigsResponse DeleteAcrossCloudStroageConfigsResponse
     */
    public function deleteAcrossCloudStroageConfigs($targetCorpId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteAcrossCloudStroageConfigsHeaders([]);

        return $this->deleteAcrossCloudStroageConfigsWithOptions($targetCorpId, $headers, $runtime);
    }

    /**
     * @summary 删除评论
     *  *
     * @param string               $publisherId
     * @param string               $commentId
     * @param DeleteCommentHeaders $headers     DeleteCommentHeaders
     * @param RuntimeOptions       $runtime     runtime options for this request RuntimeOptions
     *
     * @return DeleteCommentResponse DeleteCommentResponse
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
            'action' => 'DeleteComment',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/publishers/' . $publisherId . '/comments/' . $commentId . '',
            'method' => 'DELETE',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'boolean',
        ]);

        return DeleteCommentResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除评论
     *  *
     * @param string $publisherId
     * @param string $commentId
     *
     * @return DeleteCommentResponse DeleteCommentResponse
     */
    public function deleteComment($publisherId, $commentId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteCommentHeaders([]);

        return $this->deleteCommentWithOptions($publisherId, $commentId, $headers, $runtime);
    }

    /**
     * @summary 删除指定可信设备
     *  *
     * @param DeleteTrustedDeviceRequest $request DeleteTrustedDeviceRequest
     * @param DeleteTrustedDeviceHeaders $headers DeleteTrustedDeviceHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteTrustedDeviceResponse DeleteTrustedDeviceResponse
     */
    public function deleteTrustedDeviceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->id)) {
            $body['id'] = $request->id;
        }
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'DeleteTrustedDevice',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/trustedDevices/remove',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return DeleteTrustedDeviceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除指定可信设备
     *  *
     * @param DeleteTrustedDeviceRequest $request DeleteTrustedDeviceRequest
     *
     * @return DeleteTrustedDeviceResponse DeleteTrustedDeviceResponse
     */
    public function deleteTrustedDevice($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteTrustedDeviceHeaders([]);

        return $this->deleteTrustedDeviceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 分发伙伴应用
     *  *
     * @param DistributePartnerAppRequest $request DistributePartnerAppRequest
     * @param DistributePartnerAppHeaders $headers DistributePartnerAppHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return DistributePartnerAppResponse DistributePartnerAppResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'DistributePartnerApp',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/partners/applications/distribute',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return DistributePartnerAppResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 分发伙伴应用
     *  *
     * @param DistributePartnerAppRequest $request DistributePartnerAppRequest
     *
     * @return DistributePartnerAppResponse DistributePartnerAppResponse
     */
    public function distributePartnerApp($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DistributePartnerAppHeaders([]);

        return $this->distributePartnerAppWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 编辑安全卡片管控成员
     *  *
     * @param EditSecurityConfigMemberRequest $request EditSecurityConfigMemberRequest
     * @param EditSecurityConfigMemberHeaders $headers EditSecurityConfigMemberHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return EditSecurityConfigMemberResponse EditSecurityConfigMemberResponse
     */
    public function editSecurityConfigMemberWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->configKey)) {
            $body['configKey'] = $request->configKey;
        }
        if (!Utils::isUnset($request->operateType)) {
            $body['operateType'] = $request->operateType;
        }
        if (!Utils::isUnset($request->operateUserId)) {
            $body['operateUserId'] = $request->operateUserId;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'EditSecurityConfigMember',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/securities/configs/members',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return EditSecurityConfigMemberResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 编辑安全卡片管控成员
     *  *
     * @param EditSecurityConfigMemberRequest $request EditSecurityConfigMemberRequest
     *
     * @return EditSecurityConfigMemberResponse EditSecurityConfigMemberResponse
     */
    public function editSecurityConfigMember($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new EditSecurityConfigMemberHeaders([]);

        return $this->editSecurityConfigMemberWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更换组织主管理员
     *  *
     * @param ExchangeMainAdminRequest $request ExchangeMainAdminRequest
     * @param ExchangeMainAdminHeaders $headers ExchangeMainAdminHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return ExchangeMainAdminResponse ExchangeMainAdminResponse
     */
    public function exchangeMainAdminWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->newAdminUserId)) {
            $body['newAdminUserId'] = $request->newAdminUserId;
        }
        if (!Utils::isUnset($request->oldAdminUserId)) {
            $body['oldAdminUserId'] = $request->oldAdminUserId;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'ExchangeMainAdmin',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/orgnizations/mainAdministrators/exchange',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ExchangeMainAdminResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更换组织主管理员
     *  *
     * @param ExchangeMainAdminRequest $request ExchangeMainAdminRequest
     *
     * @return ExchangeMainAdminResponse ExchangeMainAdminResponse
     */
    public function exchangeMainAdmin($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ExchangeMainAdminHeaders([]);

        return $this->exchangeMainAdminWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 分发工作台模版
     *  *
     * @param ExclusiveCreateDingPortalRequest $request ExclusiveCreateDingPortalRequest
     * @param ExclusiveCreateDingPortalHeaders $headers ExclusiveCreateDingPortalHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return ExclusiveCreateDingPortalResponse ExclusiveCreateDingPortalResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'ExclusiveCreateDingPortal',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/workbenches/templates/spread',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ExclusiveCreateDingPortalResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 分发工作台模版
     *  *
     * @param ExclusiveCreateDingPortalRequest $request ExclusiveCreateDingPortalRequest
     *
     * @return ExclusiveCreateDingPortalResponse ExclusiveCreateDingPortalResponse
     */
    public function exclusiveCreateDingPortal($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ExclusiveCreateDingPortalHeaders([]);

        return $this->exclusiveCreateDingPortalWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 专属文件第一次设置，激活配置
     *  *
     * @param FileStorageActiveStorageRequest $request FileStorageActiveStorageRequest
     * @param FileStorageActiveStorageHeaders $headers FileStorageActiveStorageHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return FileStorageActiveStorageResponse FileStorageActiveStorageResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'FileStorageActiveStorage',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/fileStorages/active',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return FileStorageActiveStorageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 专属文件第一次设置，激活配置
     *  *
     * @param FileStorageActiveStorageRequest $request FileStorageActiveStorageRequest
     *
     * @return FileStorageActiveStorageResponse FileStorageActiveStorageResponse
     */
    public function fileStorageActiveStorage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new FileStorageActiveStorageHeaders([]);

        return $this->fileStorageActiveStorageWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 检查专属存储OSS连接
     *  *
     * @param FileStorageCheckConnectionRequest $request FileStorageCheckConnectionRequest
     * @param FileStorageCheckConnectionHeaders $headers FileStorageCheckConnectionHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return FileStorageCheckConnectionResponse FileStorageCheckConnectionResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'FileStorageCheckConnection',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/fileStorages/connections/check',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return FileStorageCheckConnectionResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 检查专属存储OSS连接
     *  *
     * @param FileStorageCheckConnectionRequest $request FileStorageCheckConnectionRequest
     *
     * @return FileStorageCheckConnectionResponse FileStorageCheckConnectionResponse
     */
    public function fileStorageCheckConnection($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new FileStorageCheckConnectionHeaders([]);

        return $this->fileStorageCheckConnectionWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 专属文件存储获取存储情况(按时间区间)
     *  *
     * @param FileStorageGetQuotaDataRequest $request FileStorageGetQuotaDataRequest
     * @param FileStorageGetQuotaDataHeaders $headers FileStorageGetQuotaDataHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return FileStorageGetQuotaDataResponse FileStorageGetQuotaDataResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'FileStorageGetQuotaData',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/fileStorages/quotaDatas',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return FileStorageGetQuotaDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 专属文件存储获取存储情况(按时间区间)
     *  *
     * @param FileStorageGetQuotaDataRequest $request FileStorageGetQuotaDataRequest
     *
     * @return FileStorageGetQuotaDataResponse FileStorageGetQuotaDataResponse
     */
    public function fileStorageGetQuotaData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new FileStorageGetQuotaDataHeaders([]);

        return $this->fileStorageGetQuotaDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 专属文件存储获取存储情况和配置
     *  *
     * @param FileStorageGetStorageStateRequest $request FileStorageGetStorageStateRequest
     * @param FileStorageGetStorageStateHeaders $headers FileStorageGetStorageStateHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return FileStorageGetStorageStateResponse FileStorageGetStorageStateResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'FileStorageGetStorageState',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/fileStorages/states',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return FileStorageGetStorageStateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 专属文件存储获取存储情况和配置
     *  *
     * @param FileStorageGetStorageStateRequest $request FileStorageGetStorageStateRequest
     *
     * @return FileStorageGetStorageStateResponse FileStorageGetStorageStateResponse
     */
    public function fileStorageGetStorageState($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new FileStorageGetStorageStateHeaders([]);

        return $this->fileStorageGetStorageStateWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新文件专属存储配置
     *  *
     * @param FileStorageUpdateStorageRequest $request FileStorageUpdateStorageRequest
     * @param FileStorageUpdateStorageHeaders $headers FileStorageUpdateStorageHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return FileStorageUpdateStorageResponse FileStorageUpdateStorageResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'FileStorageUpdateStorage',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/fileStorages/configurations',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return FileStorageUpdateStorageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新文件专属存储配置
     *  *
     * @param FileStorageUpdateStorageRequest $request FileStorageUpdateStorageRequest
     *
     * @return FileStorageUpdateStorageResponse FileStorageUpdateStorageResponse
     */
    public function fileStorageUpdateStorage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new FileStorageUpdateStorageHeaders([]);

        return $this->fileStorageUpdateStorageWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 生成暗水印
     *  *
     * @param GenerateDarkWaterMarkRequest $request GenerateDarkWaterMarkRequest
     * @param GenerateDarkWaterMarkHeaders $headers GenerateDarkWaterMarkHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return GenerateDarkWaterMarkResponse GenerateDarkWaterMarkResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'GenerateDarkWaterMark',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/enterpriseSecurities/darkWatermarks/generate',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GenerateDarkWaterMarkResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 生成暗水印
     *  *
     * @param GenerateDarkWaterMarkRequest $request GenerateDarkWaterMarkRequest
     *
     * @return GenerateDarkWaterMarkResponse GenerateDarkWaterMarkResponse
     */
    public function generateDarkWaterMark($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GenerateDarkWaterMarkHeaders([]);

        return $this->generateDarkWaterMarkWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取专属钉钉账号数据迁移结果
     *  *
     * @param GetAccountTransferListRequest $request GetAccountTransferListRequest
     * @param GetAccountTransferListHeaders $headers GetAccountTransferListHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return GetAccountTransferListResponse GetAccountTransferListResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'GetAccountTransferList',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/dataTransfer/accounts',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetAccountTransferListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取专属钉钉账号数据迁移结果
     *  *
     * @param GetAccountTransferListRequest $request GetAccountTransferListRequest
     *
     * @return GetAccountTransferListResponse GetAccountTransferListResponse
     */
    public function getAccountTransferList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetAccountTransferListHeaders([]);

        return $this->getAccountTransferListWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获得组织维度的用户dau
     *  *
     * @param string                      $dataId
     * @param GetActiveUserSummaryHeaders $headers GetActiveUserSummaryHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return GetActiveUserSummaryResponse GetActiveUserSummaryResponse
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
            'action' => 'GetActiveUserSummary',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/data/dau/org/' . $dataId . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return GetActiveUserSummaryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获得组织维度的用户dau
     *  *
     * @param string $dataId
     *
     * @return GetActiveUserSummaryResponse GetActiveUserSummaryResponse
     */
    public function getActiveUserSummary($dataId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetActiveUserSummaryHeaders([]);

        return $this->getActiveUserSummaryWithOptions($dataId, $headers, $runtime);
    }

    /**
     * @summary 根据AppId获取微应用在该组织下的agentId
     *  *
     * @param GetAgentIdByRelatedAppIdRequest $request GetAgentIdByRelatedAppIdRequest
     * @param GetAgentIdByRelatedAppIdHeaders $headers GetAgentIdByRelatedAppIdHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return GetAgentIdByRelatedAppIdResponse GetAgentIdByRelatedAppIdResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'GetAgentIdByRelatedAppId',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/exclusiveDesigns/agentId',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetAgentIdByRelatedAppIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据AppId获取微应用在该组织下的agentId
     *  *
     * @param GetAgentIdByRelatedAppIdRequest $request GetAgentIdByRelatedAppIdRequest
     *
     * @return GetAgentIdByRelatedAppIdResponse GetAgentIdByRelatedAppIdResponse
     */
    public function getAgentIdByRelatedAppId($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetAgentIdByRelatedAppIdHeaders([]);

        return $this->getAgentIdByRelatedAppIdWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 伙伴钉可打标签部门查询
     *  *
     * @param GetAllLabelableDeptsHeaders $headers GetAllLabelableDeptsHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return GetAllLabelableDeptsResponse GetAllLabelableDeptsResponse
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
            'action' => 'GetAllLabelableDepts',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/partnerDepartments',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return GetAllLabelableDeptsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 伙伴钉可打标签部门查询
     *  *
     * @return GetAllLabelableDeptsResponse GetAllLabelableDeptsResponse
     */
    public function getAllLabelableDepts()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetAllLabelableDeptsHeaders([]);

        return $this->getAllLabelableDeptsWithOptions($headers, $runtime);
    }

    /**
     * @summary 获得app分发信息
     *  *
     * @param GetAppDispatchInfoRequest $request GetAppDispatchInfoRequest
     * @param GetAppDispatchInfoHeaders $headers GetAppDispatchInfoHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return GetAppDispatchInfoResponse GetAppDispatchInfoResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'GetAppDispatchInfo',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/apps/distributionInfos',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetAppDispatchInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获得app分发信息
     *  *
     * @param GetAppDispatchInfoRequest $request GetAppDispatchInfoRequest
     *
     * @return GetAppDispatchInfoResponse GetAppDispatchInfoResponse
     */
    public function getAppDispatchInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetAppDispatchInfoHeaders([]);

        return $this->getAppDispatchInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获得组织维度日程相关信息
     *  *
     * @param string                    $dataId
     * @param GetCalenderSummaryHeaders $headers GetCalenderSummaryHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return GetCalenderSummaryResponse GetCalenderSummaryResponse
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
            'action' => 'GetCalenderSummary',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/data/calendar/org/' . $dataId . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetCalenderSummaryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获得组织维度日程相关信息
     *  *
     * @param string $dataId
     *
     * @return GetCalenderSummaryResponse GetCalenderSummaryResponse
     */
    public function getCalenderSummary($dataId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetCalenderSummaryHeaders([]);

        return $this->getCalenderSummaryWithOptions($dataId, $headers, $runtime);
    }

    /**
     * @summary 根据机器人code获取群openConversationId列表
     *  *
     * @param GetCidsByBotCodeRequest $request GetCidsByBotCodeRequest
     * @param GetCidsByBotCodeHeaders $headers GetCidsByBotCodeHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return GetCidsByBotCodeResponse GetCidsByBotCodeResponse
     */
    public function getCidsByBotCodeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->robotCode)) {
            $query['robotCode'] = $request->robotCode;
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'GetCidsByBotCode',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/groups/openConversationIds',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetCidsByBotCodeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据机器人code获取群openConversationId列表
     *  *
     * @param GetCidsByBotCodeRequest $request GetCidsByBotCodeRequest
     *
     * @return GetCidsByBotCodeResponse GetCidsByBotCodeResponse
     */
    public function getCidsByBotCode($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetCidsByBotCodeHeaders([]);

        return $this->getCidsByBotCodeWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取密级标签
     *  *
     * @param GetClassTagRequest $request GetClassTagRequest
     * @param GetClassTagHeaders $headers GetClassTagHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return GetClassTagResponse GetClassTagResponse
     */
    public function getClassTagWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->entityId)) {
            $query['entityId'] = $request->entityId;
        }
        if (!Utils::isUnset($request->tagCode)) {
            $query['tagCode'] = $request->tagCode;
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'GetClassTag',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/classes/entities/tags',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetClassTagResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取密级标签
     *  *
     * @param GetClassTagRequest $request GetClassTagRequest
     *
     * @return GetClassTagResponse GetClassTagResponse
     */
    public function getClassTag($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetClassTagHeaders([]);

        return $this->getClassTagWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取发布号的评论列表
     *  *
     * @param string                $publisherId
     * @param GetCommentListRequest $request     GetCommentListRequest
     * @param GetCommentListHeaders $headers     GetCommentListHeaders
     * @param RuntimeOptions        $runtime     runtime options for this request RuntimeOptions
     *
     * @return GetCommentListResponse GetCommentListResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'GetCommentList',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/publishers/' . $publisherId . '/comments/list',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return GetCommentListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取发布号的评论列表
     *  *
     * @param string                $publisherId
     * @param GetCommentListRequest $request     GetCommentListRequest
     *
     * @return GetCommentListResponse GetCommentListResponse
     */
    public function getCommentList($publisherId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetCommentListHeaders([]);

        return $this->getCommentListWithOptions($publisherId, $request, $headers, $runtime);
    }

    /**
     * @summary 根据逻辑会议id获取会议基本信息
     *  *
     * @param GetConfBaseInfoByLogicalIdRequest $request GetConfBaseInfoByLogicalIdRequest
     * @param GetConfBaseInfoByLogicalIdHeaders $headers GetConfBaseInfoByLogicalIdHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return GetConfBaseInfoByLogicalIdResponse GetConfBaseInfoByLogicalIdResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'GetConfBaseInfoByLogicalId',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/data/conferences',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetConfBaseInfoByLogicalIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据逻辑会议id获取会议基本信息
     *  *
     * @param GetConfBaseInfoByLogicalIdRequest $request GetConfBaseInfoByLogicalIdRequest
     *
     * @return GetConfBaseInfoByLogicalIdResponse GetConfBaseInfoByLogicalIdResponse
     */
    public function getConfBaseInfoByLogicalId($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetConfBaseInfoByLogicalIdHeaders([]);

        return $this->getConfBaseInfoByLogicalIdWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取视频会议明细
     *  *
     * @param string                     $conferenceId
     * @param GetConferenceDetailHeaders $headers      GetConferenceDetailHeaders
     * @param RuntimeOptions             $runtime      runtime options for this request RuntimeOptions
     *
     * @return GetConferenceDetailResponse GetConferenceDetailResponse
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
            'action' => 'GetConferenceDetail',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/data/conferences/' . $conferenceId . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return GetConferenceDetailResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取视频会议明细
     *  *
     * @param string $conferenceId
     *
     * @return GetConferenceDetailResponse GetConferenceDetailResponse
     */
    public function getConferenceDetail($conferenceId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetConferenceDetailHeaders([]);

        return $this->getConferenceDetailWithOptions($conferenceId, $headers, $runtime);
    }

    /**
     * @summary 获取会话分组数据
     *  *
     * @param GetConversationCategoryHeaders $headers GetConversationCategoryHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return GetConversationCategoryResponse GetConversationCategoryResponse
     */
    public function getConversationCategoryWithOptions($headers, $runtime)
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
            'action' => 'GetConversationCategory',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/conversationCategories',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetConversationCategoryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取会话分组数据
     *  *
     * @return GetConversationCategoryResponse GetConversationCategoryResponse
     */
    public function getConversationCategory()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetConversationCategoryHeaders([]);

        return $this->getConversationCategoryWithOptions($headers, $runtime);
    }

    /**
     * @summary 获取会话分组详情
     *  *
     * @param GetConversationDetailRequest $request GetConversationDetailRequest
     * @param GetConversationDetailHeaders $headers GetConversationDetailHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return GetConversationDetailResponse GetConversationDetailResponse
     */
    public function getConversationDetailWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'GetConversationDetail',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/categories/conversations/details/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetConversationDetailResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取会话分组详情
     *  *
     * @param GetConversationDetailRequest $request GetConversationDetailRequest
     *
     * @return GetConversationDetailResponse GetConversationDetailResponse
     */
    public function getConversationDetail($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetConversationDetailHeaders([]);

        return $this->getConversationDetailWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取部门维度发布日志信息
     *  *
     * @param string                          $dataId
     * @param GetDingReportDeptSummaryRequest $request GetDingReportDeptSummaryRequest
     * @param GetDingReportDeptSummaryHeaders $headers GetDingReportDeptSummaryHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return GetDingReportDeptSummaryResponse GetDingReportDeptSummaryResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'GetDingReportDeptSummary',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/data/report/dept/' . $dataId . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return GetDingReportDeptSummaryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取部门维度发布日志信息
     *  *
     * @param string                          $dataId
     * @param GetDingReportDeptSummaryRequest $request GetDingReportDeptSummaryRequest
     *
     * @return GetDingReportDeptSummaryResponse GetDingReportDeptSummaryResponse
     */
    public function getDingReportDeptSummary($dataId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetDingReportDeptSummaryHeaders([]);

        return $this->getDingReportDeptSummaryWithOptions($dataId, $request, $headers, $runtime);
    }

    /**
     * @summary 获取组织维度发布日志信息
     *  *
     * @param string                      $dataId
     * @param GetDingReportSummaryHeaders $headers GetDingReportSummaryHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return GetDingReportSummaryResponse GetDingReportSummaryResponse
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
            'action' => 'GetDingReportSummary',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/datas/' . $dataId . '/reports/organizations',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetDingReportSummaryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取组织维度发布日志信息
     *  *
     * @param string $dataId
     *
     * @return GetDingReportSummaryResponse GetDingReportSummaryResponse
     */
    public function getDingReportSummary($dataId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetDingReportSummaryHeaders([]);

        return $this->getDingReportSummaryWithOptions($dataId, $headers, $runtime);
    }

    /**
     * @summary 获得部门维度用户创建文档数和创建文档人数
     *  *
     * @param string                          $dataId
     * @param GetDocCreatedDeptSummaryRequest $request GetDocCreatedDeptSummaryRequest
     * @param GetDocCreatedDeptSummaryHeaders $headers GetDocCreatedDeptSummaryHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return GetDocCreatedDeptSummaryResponse GetDocCreatedDeptSummaryResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'GetDocCreatedDeptSummary',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/data/doc/dept/' . $dataId . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetDocCreatedDeptSummaryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获得部门维度用户创建文档数和创建文档人数
     *  *
     * @param string                          $dataId
     * @param GetDocCreatedDeptSummaryRequest $request GetDocCreatedDeptSummaryRequest
     *
     * @return GetDocCreatedDeptSummaryResponse GetDocCreatedDeptSummaryResponse
     */
    public function getDocCreatedDeptSummary($dataId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetDocCreatedDeptSummaryHeaders([]);

        return $this->getDocCreatedDeptSummaryWithOptions($dataId, $request, $headers, $runtime);
    }

    /**
     * @summary 获取组织维度用户创建文档数和创建文档人数
     *  *
     * @param string                      $dataId
     * @param GetDocCreatedSummaryHeaders $headers GetDocCreatedSummaryHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return GetDocCreatedSummaryResponse GetDocCreatedSummaryResponse
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
            'action' => 'GetDocCreatedSummary',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/data/doc/org/' . $dataId . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetDocCreatedSummaryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取组织维度用户创建文档数和创建文档人数
     *  *
     * @param string $dataId
     *
     * @return GetDocCreatedSummaryResponse GetDocCreatedSummaryResponse
     */
    public function getDocCreatedSummary($dataId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetDocCreatedSummaryHeaders([]);

        return $this->getDocCreatedSummaryWithOptions($dataId, $headers, $runtime);
    }

    /**
     * @summary 获取专属账号所有组织列表
     *  *
     * @param GetExclusiveAccountAllOrgListRequest $request GetExclusiveAccountAllOrgListRequest
     * @param GetExclusiveAccountAllOrgListHeaders $headers GetExclusiveAccountAllOrgListHeaders
     * @param RuntimeOptions                       $runtime runtime options for this request RuntimeOptions
     *
     * @return GetExclusiveAccountAllOrgListResponse GetExclusiveAccountAllOrgListResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'GetExclusiveAccountAllOrgList',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/exclusiveAccounts/organizations',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetExclusiveAccountAllOrgListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取专属账号所有组织列表
     *  *
     * @param GetExclusiveAccountAllOrgListRequest $request GetExclusiveAccountAllOrgListRequest
     *
     * @return GetExclusiveAccountAllOrgListResponse GetExclusiveAccountAllOrgListResponse
     */
    public function getExclusiveAccountAllOrgList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetExclusiveAccountAllOrgListHeaders([]);

        return $this->getExclusiveAccountAllOrgListWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取部门维度发布智能填表数量和使用智能填表人数
     *  *
     * @param string                                  $dataId
     * @param GetGeneralFormCreatedDeptSummaryRequest $request GetGeneralFormCreatedDeptSummaryRequest
     * @param GetGeneralFormCreatedDeptSummaryHeaders $headers GetGeneralFormCreatedDeptSummaryHeaders
     * @param RuntimeOptions                          $runtime runtime options for this request RuntimeOptions
     *
     * @return GetGeneralFormCreatedDeptSummaryResponse GetGeneralFormCreatedDeptSummaryResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'GetGeneralFormCreatedDeptSummary',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/data/generalForm/dept/' . $dataId . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetGeneralFormCreatedDeptSummaryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取部门维度发布智能填表数量和使用智能填表人数
     *  *
     * @param string                                  $dataId
     * @param GetGeneralFormCreatedDeptSummaryRequest $request GetGeneralFormCreatedDeptSummaryRequest
     *
     * @return GetGeneralFormCreatedDeptSummaryResponse GetGeneralFormCreatedDeptSummaryResponse
     */
    public function getGeneralFormCreatedDeptSummary($dataId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetGeneralFormCreatedDeptSummaryHeaders([]);

        return $this->getGeneralFormCreatedDeptSummaryWithOptions($dataId, $request, $headers, $runtime);
    }

    /**
     * @summary 获取组织维度发布智能填表数量和使用智能填表人数
     *  *
     * @param string                              $dataId
     * @param GetGeneralFormCreatedSummaryHeaders $headers GetGeneralFormCreatedSummaryHeaders
     * @param RuntimeOptions                      $runtime runtime options for this request RuntimeOptions
     *
     * @return GetGeneralFormCreatedSummaryResponse GetGeneralFormCreatedSummaryResponse
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
            'action' => 'GetGeneralFormCreatedSummary',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/data/generalForm/org/' . $dataId . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetGeneralFormCreatedSummaryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取组织维度发布智能填表数量和使用智能填表人数
     *  *
     * @param string $dataId
     *
     * @return GetGeneralFormCreatedSummaryResponse GetGeneralFormCreatedSummaryResponse
     */
    public function getGeneralFormCreatedSummary($dataId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetGeneralFormCreatedSummaryHeaders([]);

        return $this->getGeneralFormCreatedSummaryWithOptions($dataId, $headers, $runtime);
    }

    /**
     * @summary 获取群活跃明细
     *  *
     * @param GetGroupActiveInfoRequest $request GetGroupActiveInfoRequest
     * @param GetGroupActiveInfoHeaders $headers GetGroupActiveInfoHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return GetGroupActiveInfoResponse GetGroupActiveInfoResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'GetGroupActiveInfo',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/data/activeGroups',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetGroupActiveInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取群活跃明细
     *  *
     * @param GetGroupActiveInfoRequest $request GetGroupActiveInfoRequest
     *
     * @return GetGroupActiveInfoResponse GetGroupActiveInfoResponse
     */
    public function getGroupActiveInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetGroupActiveInfoHeaders([]);

        return $this->getGroupActiveInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 根据群会话id获取群相关信息
     *  *
     * @param GetGroupInfoByCidRequest $request GetGroupInfoByCidRequest
     * @param GetGroupInfoByCidHeaders $headers GetGroupInfoByCidHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return GetGroupInfoByCidResponse GetGroupInfoByCidResponse
     */
    public function getGroupInfoByCidWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->openConversationId)) {
            $query['openConversationId'] = $request->openConversationId;
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'GetGroupInfoByCid',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/groups/infos/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetGroupInfoByCidResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据群会话id获取群相关信息
     *  *
     * @param GetGroupInfoByCidRequest $request GetGroupInfoByCidRequest
     *
     * @return GetGroupInfoByCidResponse GetGroupInfoByCidResponse
     */
    public function getGroupInfoByCid($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetGroupInfoByCidHeaders([]);

        return $this->getGroupInfoByCidWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 根据群会话id获取组织cropid
     *  *
     * @param GetGroupOrgByCidRequest $request GetGroupOrgByCidRequest
     * @param GetGroupOrgByCidHeaders $headers GetGroupOrgByCidHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return GetGroupOrgByCidResponse GetGroupOrgByCidResponse
     */
    public function getGroupOrgByCidWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->openConversationId)) {
            $query['openConversationId'] = $request->openConversationId;
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'GetGroupOrgByCid',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/groups/organizations/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetGroupOrgByCidResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据群会话id获取组织cropid
     *  *
     * @param GetGroupOrgByCidRequest $request GetGroupOrgByCidRequest
     *
     * @return GetGroupOrgByCidResponse GetGroupOrgByCidResponse
     */
    public function getGroupOrgByCid($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetGroupOrgByCidHeaders([]);

        return $this->getGroupOrgByCidWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取未活跃用户登陆统计明细
     *  *
     * @param GetInActiveUserListRequest $request GetInActiveUserListRequest
     * @param GetInActiveUserListHeaders $headers GetInActiveUserListHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return GetInActiveUserListResponse GetInActiveUserListResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'GetInActiveUserList',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/inactives/users/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return GetInActiveUserListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取未活跃用户登陆统计明细
     *  *
     * @param GetInActiveUserListRequest $request GetInActiveUserListRequest
     *
     * @return GetInActiveUserListResponse GetInActiveUserListResponse
     */
    public function getInActiveUserList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetInActiveUserListHeaders([]);

        return $this->getInActiveUserListWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取最后一次验证通过的企业认证信息
     *  *
     * @param GetLastOrgAuthDataRequest $request GetLastOrgAuthDataRequest
     * @param GetLastOrgAuthDataHeaders $headers GetLastOrgAuthDataHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return GetLastOrgAuthDataResponse GetLastOrgAuthDataResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'GetLastOrgAuthData',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/organizations/authInfos',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetLastOrgAuthDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取最后一次验证通过的企业认证信息
     *  *
     * @param GetLastOrgAuthDataRequest $request GetLastOrgAuthDataRequest
     *
     * @return GetLastOrgAuthDataResponse GetLastOrgAuthDataResponse
     */
    public function getLastOrgAuthData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetLastOrgAuthDataHeaders([]);

        return $this->getLastOrgAuthDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 消息规则配置和群属性接口
     *  *
     * @param GetMsgConfigRequest $request GetMsgConfigRequest
     * @param GetMsgConfigHeaders $headers GetMsgConfigHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return GetMsgConfigResponse GetMsgConfigResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'GetMsgConfig',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/portals/msgConfigs/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetMsgConfigResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 消息规则配置和群属性接口
     *  *
     * @param GetMsgConfigRequest $request GetMsgConfigRequest
     *
     * @return GetMsgConfigResponse GetMsgConfigResponse
     */
    public function getMsgConfig($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetMsgConfigHeaders([]);

        return $this->getMsgConfigWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取消息定位链接
     *  *
     * @param GetMsgLocationRequest $request GetMsgLocationRequest
     * @param GetMsgLocationHeaders $headers GetMsgLocationHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return GetMsgLocationResponse GetMsgLocationResponse
     */
    public function getMsgLocationWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->openMsgId)) {
            $body['openMsgId'] = $request->openMsgId;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'GetMsgLocation',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/messageLocations/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetMsgLocationResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取消息定位链接
     *  *
     * @param GetMsgLocationRequest $request GetMsgLocationRequest
     *
     * @return GetMsgLocationResponse GetMsgLocationResponse
     */
    public function getMsgLocation($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetMsgLocationHeaders([]);

        return $this->getMsgLocationWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取oa后台操作日志记录
     *  *
     * @param GetOaOperatorLogListRequest $request GetOaOperatorLogListRequest
     * @param GetOaOperatorLogListHeaders $headers GetOaOperatorLogListHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return GetOaOperatorLogListResponse GetOaOperatorLogListResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'GetOaOperatorLogList',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/oaOperatorLogs/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return GetOaOperatorLogListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取oa后台操作日志记录
     *  *
     * @param GetOaOperatorLogListRequest $request GetOaOperatorLogListRequest
     *
     * @return GetOaOperatorLogListResponse GetOaOperatorLogListResponse
     */
    public function getOaOperatorLogList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetOaOperatorLogListHeaders([]);

        return $this->getOaOperatorLogListWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取企业的外部审计群列表
     *  *
     * @param GetOutGroupsByPageRequest $request GetOutGroupsByPageRequest
     * @param GetOutGroupsByPageHeaders $headers GetOutGroupsByPageHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return GetOutGroupsByPageResponse GetOutGroupsByPageResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'GetOutGroupsByPage',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/audits/outsideGroups/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetOutGroupsByPageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取企业的外部审计群列表
     *  *
     * @param GetOutGroupsByPageRequest $request GetOutGroupsByPageRequest
     *
     * @return GetOutGroupsByPageResponse GetOutGroupsByPageResponse
     */
    public function getOutGroupsByPage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetOutGroupsByPageHeaders([]);

        return $this->getOutGroupsByPageWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取外部审计群消息记录
     *  *
     * @param GetOutsideAuditGroupMessageByPageRequest $request GetOutsideAuditGroupMessageByPageRequest
     * @param GetOutsideAuditGroupMessageByPageHeaders $headers GetOutsideAuditGroupMessageByPageHeaders
     * @param RuntimeOptions                           $runtime runtime options for this request RuntimeOptions
     *
     * @return GetOutsideAuditGroupMessageByPageResponse GetOutsideAuditGroupMessageByPageResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'GetOutsideAuditGroupMessageByPage',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/audits/outsideGroups/messages/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetOutsideAuditGroupMessageByPageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取外部审计群消息记录
     *  *
     * @param GetOutsideAuditGroupMessageByPageRequest $request GetOutsideAuditGroupMessageByPageRequest
     *
     * @return GetOutsideAuditGroupMessageByPageResponse GetOutsideAuditGroupMessageByPageResponse
     */
    public function getOutsideAuditGroupMessageByPage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetOutsideAuditGroupMessageByPageHeaders([]);

        return $this->getOutsideAuditGroupMessageByPageWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 伙伴钉根据父标签查询子标签
     *  *
     * @param string                          $parentId
     * @param GetPartnerTypeByParentIdHeaders $headers  GetPartnerTypeByParentIdHeaders
     * @param RuntimeOptions                  $runtime  runtime options for this request RuntimeOptions
     *
     * @return GetPartnerTypeByParentIdResponse GetPartnerTypeByParentIdResponse
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
            'action' => 'GetPartnerTypeByParentId',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/partnerLabels/' . $parentId . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetPartnerTypeByParentIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 伙伴钉根据父标签查询子标签
     *  *
     * @param string $parentId
     *
     * @return GetPartnerTypeByParentIdResponse GetPartnerTypeByParentIdResponse
     */
    public function getPartnerTypeByParentId($parentId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetPartnerTypeByParentIdHeaders([]);

        return $this->getPartnerTypeByParentIdWithOptions($parentId, $headers, $runtime);
    }

    /**
     * @summary 获取专属存储容量信息
     *  *
     * @param GetPrivateStoreCapacityUsageRequest $request GetPrivateStoreCapacityUsageRequest
     * @param GetPrivateStoreCapacityUsageHeaders $headers GetPrivateStoreCapacityUsageHeaders
     * @param RuntimeOptions                      $runtime runtime options for this request RuntimeOptions
     *
     * @return GetPrivateStoreCapacityUsageResponse GetPrivateStoreCapacityUsageResponse
     */
    public function getPrivateStoreCapacityUsageWithOptions($request, $headers, $runtime)
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'GetPrivateStoreCapacityUsage',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/privateStores/capacityUsages/infos',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetPrivateStoreCapacityUsageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取专属存储容量信息
     *  *
     * @param GetPrivateStoreCapacityUsageRequest $request GetPrivateStoreCapacityUsageRequest
     *
     * @return GetPrivateStoreCapacityUsageResponse GetPrivateStoreCapacityUsageResponse
     */
    public function getPrivateStoreCapacityUsage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetPrivateStoreCapacityUsageHeaders([]);

        return $this->getPrivateStoreCapacityUsageWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 分页获取专属存储文件信息
     *  *
     * @param GetPrivateStoreFileInfosByPageRequest $request GetPrivateStoreFileInfosByPageRequest
     * @param GetPrivateStoreFileInfosByPageHeaders $headers GetPrivateStoreFileInfosByPageHeaders
     * @param RuntimeOptions                        $runtime runtime options for this request RuntimeOptions
     *
     * @return GetPrivateStoreFileInfosByPageResponse GetPrivateStoreFileInfosByPageResponse
     */
    public function getPrivateStoreFileInfosByPageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->fileCreateTime)) {
            $body['fileCreateTime'] = $request->fileCreateTime;
        }
        if (!Utils::isUnset($request->fileStatus)) {
            $body['fileStatus'] = $request->fileStatus;
        }
        if (!Utils::isUnset($request->maxResults)) {
            $body['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $body['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->order)) {
            $body['order'] = $request->order;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'GetPrivateStoreFileInfosByPage',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/privateStores/fileInfos/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetPrivateStoreFileInfosByPageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 分页获取专属存储文件信息
     *  *
     * @param GetPrivateStoreFileInfosByPageRequest $request GetPrivateStoreFileInfosByPageRequest
     *
     * @return GetPrivateStoreFileInfosByPageResponse GetPrivateStoreFileInfosByPageResponse
     */
    public function getPrivateStoreFileInfosByPage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetPrivateStoreFileInfosByPageHeaders([]);

        return $this->getPrivateStoreFileInfosByPageWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取专属存储文件路径
     *  *
     * @param GetPrivateStoreFilePathRequest $request GetPrivateStoreFilePathRequest
     * @param GetPrivateStoreFilePathHeaders $headers GetPrivateStoreFilePathHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return GetPrivateStoreFilePathResponse GetPrivateStoreFilePathResponse
     */
    public function getPrivateStoreFilePathWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->dentryId)) {
            $body['dentryId'] = $request->dentryId;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'GetPrivateStoreFilePath',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/privateStores/filePaths/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetPrivateStoreFilePathResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取专属存储文件路径
     *  *
     * @param GetPrivateStoreFilePathRequest $request GetPrivateStoreFilePathRequest
     *
     * @return GetPrivateStoreFilePathResponse GetPrivateStoreFilePathResponse
     */
    public function getPrivateStoreFilePath($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetPrivateStoreFilePathHeaders([]);

        return $this->getPrivateStoreFilePathWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取公共设备列表。
     *  *
     * @param GetPublicDevicesRequest $request GetPublicDevicesRequest
     * @param GetPublicDevicesHeaders $headers GetPublicDevicesHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return GetPublicDevicesResponse GetPublicDevicesResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'GetPublicDevices',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/trusts/publicDevices',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetPublicDevicesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取公共设备列表。
     *  *
     * @param GetPublicDevicesRequest $request GetPublicDevicesRequest
     *
     * @return GetPublicDevicesResponse GetPublicDevicesResponse
     */
    public function getPublicDevices($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetPublicDevicesHeaders([]);

        return $this->getPublicDevicesWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取互动服务窗相关数据
     *  *
     * @param string                     $dataId
     * @param GetPublisherSummaryRequest $request GetPublisherSummaryRequest
     * @param GetPublisherSummaryHeaders $headers GetPublisherSummaryHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return GetPublisherSummaryResponse GetPublisherSummaryResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'GetPublisherSummary',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/data/publisher/' . $dataId . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return GetPublisherSummaryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取互动服务窗相关数据
     *  *
     * @param string                     $dataId
     * @param GetPublisherSummaryRequest $request GetPublisherSummaryRequest
     *
     * @return GetPublisherSummaryResponse GetPublisherSummaryResponse
     */
    public function getPublisherSummary($dataId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetPublisherSummaryHeaders([]);

        return $this->getPublisherSummaryWithOptions($dataId, $request, $headers, $runtime);
    }

    /**
     * @summary 获取实人认证接口调用记录
     *  *
     * @param GetRealPeopleRecordsRequest $request GetRealPeopleRecordsRequest
     * @param GetRealPeopleRecordsHeaders $headers GetRealPeopleRecordsHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return GetRealPeopleRecordsResponse GetRealPeopleRecordsResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'GetRealPeopleRecords',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/persons/identificationRecords/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetRealPeopleRecordsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取实人认证接口调用记录
     *  *
     * @param GetRealPeopleRecordsRequest $request GetRealPeopleRecordsRequest
     *
     * @return GetRealPeopleRecordsResponse GetRealPeopleRecordsResponse
     */
    public function getRealPeopleRecords($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetRealPeopleRecordsHeaders([]);

        return $this->getRealPeopleRecordsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取人脸对比接口调用记录
     *  *
     * @param GetRecognizeRecordsRequest $request GetRecognizeRecordsRequest
     * @param GetRecognizeRecordsHeaders $headers GetRecognizeRecordsHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return GetRecognizeRecordsResponse GetRecognizeRecordsResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'GetRecognizeRecords',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/faces/recognizeRecords/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetRecognizeRecordsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取人脸对比接口调用记录
     *  *
     * @param GetRecognizeRecordsRequest $request GetRecognizeRecordsRequest
     *
     * @return GetRecognizeRecordsResponse GetRecognizeRecordsResponse
     */
    public function getRecognizeRecords($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetRecognizeRecordsHeaders([]);

        return $this->getRecognizeRecordsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 根据机器人标识查询机器人信息
     *  *
     * @param GetRobotInfoByCodeRequest $request GetRobotInfoByCodeRequest
     * @param GetRobotInfoByCodeHeaders $headers GetRobotInfoByCodeHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return GetRobotInfoByCodeResponse GetRobotInfoByCodeResponse
     */
    public function getRobotInfoByCodeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->robotCode)) {
            $query['robotCode'] = $request->robotCode;
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'GetRobotInfoByCode',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/robots/infos',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetRobotInfoByCodeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据机器人标识查询机器人信息
     *  *
     * @param GetRobotInfoByCodeRequest $request GetRobotInfoByCodeRequest
     *
     * @return GetRobotInfoByCodeResponse GetRobotInfoByCodeResponse
     */
    public function getRobotInfoByCode($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetRobotInfoByCodeHeaders([]);

        return $this->getRobotInfoByCodeWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取安全管控卡片成员
     *  *
     * @param GetSecurityConfigMemberRequest $request GetSecurityConfigMemberRequest
     * @param GetSecurityConfigMemberHeaders $headers GetSecurityConfigMemberHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return GetSecurityConfigMemberResponse GetSecurityConfigMemberResponse
     */
    public function getSecurityConfigMemberWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->configKey)) {
            $body['configKey'] = $request->configKey;
        }
        if (!Utils::isUnset($request->maxResults)) {
            $body['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $body['nextToken'] = $request->nextToken;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'GetSecurityConfigMember',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/securities/configs/members/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetSecurityConfigMemberResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取安全管控卡片成员
     *  *
     * @param GetSecurityConfigMemberRequest $request GetSecurityConfigMemberRequest
     *
     * @return GetSecurityConfigMemberResponse GetSecurityConfigMemberResponse
     */
    public function getSecurityConfigMember($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSecurityConfigMemberHeaders([]);

        return $this->getSecurityConfigMemberWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取审计协议签署人员信息
     *  *
     * @param GetSignedDetailByPageRequest $request GetSignedDetailByPageRequest
     * @param GetSignedDetailByPageHeaders $headers GetSignedDetailByPageHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return GetSignedDetailByPageResponse GetSignedDetailByPageResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'GetSignedDetailByPage',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/audits/users',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetSignedDetailByPageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取审计协议签署人员信息
     *  *
     * @param GetSignedDetailByPageRequest $request GetSignedDetailByPageRequest
     *
     * @return GetSignedDetailByPageResponse GetSignedDetailByPageResponse
     */
    public function getSignedDetailByPage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSignedDetailByPageHeaders([]);

        return $this->getSignedDetailByPageWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取多个可信设备信息，包括mac地址、staffId、platform
     *  *
     * @param GetTrustDeviceListRequest $request GetTrustDeviceListRequest
     * @param GetTrustDeviceListHeaders $headers GetTrustDeviceListHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return GetTrustDeviceListResponse GetTrustDeviceListResponse
     */
    public function getTrustDeviceListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->gmtCreateEnd)) {
            $body['gmtCreateEnd'] = $request->gmtCreateEnd;
        }
        if (!Utils::isUnset($request->gmtCreateStart)) {
            $body['gmtCreateStart'] = $request->gmtCreateStart;
        }
        if (!Utils::isUnset($request->gmtModifiedEnd)) {
            $body['gmtModifiedEnd'] = $request->gmtModifiedEnd;
        }
        if (!Utils::isUnset($request->gmtModifiedStart)) {
            $body['gmtModifiedStart'] = $request->gmtModifiedStart;
        }
        if (!Utils::isUnset($request->macAddress)) {
            $body['macAddress'] = $request->macAddress;
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
        if (!Utils::isUnset($request->status)) {
            $body['status'] = $request->status;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'GetTrustDeviceList',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/trustedDevices/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetTrustDeviceListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取多个可信设备信息，包括mac地址、staffId、platform
     *  *
     * @param GetTrustDeviceListRequest $request GetTrustDeviceListRequest
     *
     * @return GetTrustDeviceListResponse GetTrustDeviceListResponse
     */
    public function getTrustDeviceList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetTrustDeviceListHeaders([]);

        return $this->getTrustDeviceListWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获得组织维度用户版本分布情况
     *  *
     * @param string                          $dataId
     * @param GetUserAppVersionSummaryRequest $request GetUserAppVersionSummaryRequest
     * @param GetUserAppVersionSummaryHeaders $headers GetUserAppVersionSummaryHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return GetUserAppVersionSummaryResponse GetUserAppVersionSummaryResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'GetUserAppVersionSummary',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/data/appVersion/org/' . $dataId . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return GetUserAppVersionSummaryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获得组织维度用户版本分布情况
     *  *
     * @param string                          $dataId
     * @param GetUserAppVersionSummaryRequest $request GetUserAppVersionSummaryRequest
     *
     * @return GetUserAppVersionSummaryResponse GetUserAppVersionSummaryResponse
     */
    public function getUserAppVersionSummary($dataId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetUserAppVersionSummaryHeaders([]);

        return $this->getUserAppVersionSummaryWithOptions($dataId, $request, $headers, $runtime);
    }

    /**
     * @summary 人脸录入状态查询
     *  *
     * @param GetUserFaceStateRequest $request GetUserFaceStateRequest
     * @param GetUserFaceStateHeaders $headers GetUserFaceStateHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return GetUserFaceStateResponse GetUserFaceStateResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'GetUserFaceState',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/faces/recognizeStates/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetUserFaceStateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 人脸录入状态查询
     *  *
     * @param GetUserFaceStateRequest $request GetUserFaceStateRequest
     *
     * @return GetUserFaceStateResponse GetUserFaceStateResponse
     */
    public function getUserFaceState($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetUserFaceStateHeaders([]);

        return $this->getUserFaceStateWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 实人认证状态查询
     *  *
     * @param GetUserRealPeopleStateRequest $request GetUserRealPeopleStateRequest
     * @param GetUserRealPeopleStateHeaders $headers GetUserRealPeopleStateHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return GetUserRealPeopleStateResponse GetUserRealPeopleStateResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'GetUserRealPeopleState',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/persons/identificationStates/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetUserRealPeopleStateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 实人认证状态查询
     *  *
     * @param GetUserRealPeopleStateRequest $request GetUserRealPeopleStateRequest
     *
     * @return GetUserRealPeopleStateResponse GetUserRealPeopleStateResponse
     */
    public function getUserRealPeopleState($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetUserRealPeopleStateHeaders([]);

        return $this->getUserRealPeopleStateWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取用户停留时长
     *  *
     * @param GetUserStayLengthRequest $request GetUserStayLengthRequest
     * @param GetUserStayLengthHeaders $headers GetUserStayLengthHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return GetUserStayLengthResponse GetUserStayLengthResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'GetUserStayLength',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/data/users/stayTimes',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetUserStayLengthResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取用户停留时长
     *  *
     * @param GetUserStayLengthRequest $request GetUserStayLengthRequest
     *
     * @return GetUserStayLengthResponse GetUserStayLengthResponse
     */
    public function getUserStayLength($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetUserStayLengthHeaders([]);

        return $this->getUserStayLengthWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取文件病毒扫描结果
     *  *
     * @param GetVirusScanResultRequest $request GetVirusScanResultRequest
     * @param GetVirusScanResultHeaders $headers GetVirusScanResultHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return GetVirusScanResultResponse GetVirusScanResultResponse
     */
    public function getVirusScanResultWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->taskId)) {
            $body['taskId'] = $request->taskId;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'GetVirusScanResult',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/virusScanTasks/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetVirusScanResultResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取文件病毒扫描结果
     *  *
     * @param GetVirusScanResultRequest $request GetVirusScanResultRequest
     *
     * @return GetVirusScanResultResponse GetVirusScanResultResponse
     */
    public function getVirusScanResult($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetVirusScanResultHeaders([]);

        return $this->getVirusScanResultWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 根据群属性查询群ID
     *  *
     * @param GroupQueryByAttrRequest $request GroupQueryByAttrRequest
     * @param GroupQueryByAttrHeaders $headers GroupQueryByAttrHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return GroupQueryByAttrResponse GroupQueryByAttrResponse
     */
    public function groupQueryByAttrWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->groupTopic)) {
            $body['groupTopic'] = $request->groupTopic;
        }
        if (!Utils::isUnset($request->groupType)) {
            $body['groupType'] = $request->groupType;
        }
        if (!Utils::isUnset($request->listDynamicAttr)) {
            $body['listDynamicAttr'] = $request->listDynamicAttr;
        }
        if (!Utils::isUnset($request->pageIndex)) {
            $body['pageIndex'] = $request->pageIndex;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->secretKey)) {
            $body['secretKey'] = $request->secretKey;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'GroupQueryByAttr',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/portals/groups/queryGroup',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GroupQueryByAttrResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据群属性查询群ID
     *  *
     * @param GroupQueryByAttrRequest $request GroupQueryByAttrRequest
     *
     * @return GroupQueryByAttrResponse GroupQueryByAttrResponse
     */
    public function groupQueryByAttr($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GroupQueryByAttrHeaders([]);

        return $this->groupQueryByAttrWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 根据群ID查询群属性
     *  *
     * @param GroupQueryByOpenIdRequest $request GroupQueryByOpenIdRequest
     * @param GroupQueryByOpenIdHeaders $headers GroupQueryByOpenIdHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return GroupQueryByOpenIdResponse GroupQueryByOpenIdResponse
     */
    public function groupQueryByOpenIdWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->secretKey)) {
            $body['secretKey'] = $request->secretKey;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'GroupQueryByOpenId',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/portals/groups/getGroupByOpenConversationId',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GroupQueryByOpenIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据群ID查询群属性
     *  *
     * @param GroupQueryByOpenIdRequest $request GroupQueryByOpenIdRequest
     *
     * @return GroupQueryByOpenIdResponse GroupQueryByOpenIdResponse
     */
    public function groupQueryByOpenId($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GroupQueryByOpenIdHeaders([]);

        return $this->groupQueryByOpenIdWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取企业文件审计日志
     *  *
     * @param ListAuditLogRequest $request ListAuditLogRequest
     * @param ListAuditLogHeaders $headers ListAuditLogHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return ListAuditLogResponse ListAuditLogResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'ListAuditLog',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/fileAuditLogs',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ListAuditLogResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取企业文件审计日志
     *  *
     * @param ListAuditLogRequest $request ListAuditLogRequest
     *
     * @return ListAuditLogResponse ListAuditLogResponse
     */
    public function listAuditLog($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListAuditLogHeaders([]);

        return $this->listAuditLogWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 根据机器人code列表查询机器人信息
     *  *
     * @param ListByCodesRequest $request ListByCodesRequest
     * @param ListByCodesHeaders $headers ListByCodesHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return ListByCodesResponse ListByCodesResponse
     */
    public function listByCodesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body' => $request->body,
        ]);
        $params = new Params([
            'action' => 'ListByCodes',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/sceneGroups/robotInfos/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ListByCodesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据机器人code列表查询机器人信息
     *  *
     * @param ListByCodesRequest $request ListByCodesRequest
     *
     * @return ListByCodesResponse ListByCodesResponse
     */
    public function listByCodes($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListByCodesHeaders([]);

        return $this->listByCodesWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 根据插件id列表查询插件信息
     *  *
     * @param ListByPluginIdsRequest $request ListByPluginIdsRequest
     * @param ListByPluginIdsHeaders $headers ListByPluginIdsHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return ListByPluginIdsResponse ListByPluginIdsResponse
     */
    public function listByPluginIdsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body' => $request->body,
        ]);
        $params = new Params([
            'action' => 'ListByPluginIds',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/sceneGroups/pluginInfos/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ListByPluginIdsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据插件id列表查询插件信息
     *  *
     * @param ListByPluginIdsRequest $request ListByPluginIdsRequest
     *
     * @return ListByPluginIdsResponse ListByPluginIdsResponse
     */
    public function listByPluginIds($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListByPluginIdsHeaders([]);

        return $this->listByPluginIdsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询分组列表
     *  *
     * @param ListCategorysRequest $tmpReq  ListCategorysRequest
     * @param ListCategorysHeaders $headers ListCategorysHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return ListCategorysResponse ListCategorysResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'ListCategorys',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/messageCategories/categories/listCategories',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ListCategorysResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询分组列表
     *  *
     * @param ListCategorysRequest $request ListCategorysRequest
     *
     * @return ListCategorysResponse ListCategorysResponse
     */
    public function listCategorys($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListCategorysHeaders([]);

        return $this->listCategorysWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 通过手机号获取已加入的属于渠道组织的列表信息
     *  *
     * @param ListJoinOrgInfoRequest $request ListJoinOrgInfoRequest
     * @param ListJoinOrgInfoHeaders $headers ListJoinOrgInfoHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return ListJoinOrgInfoResponse ListJoinOrgInfoResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'ListJoinOrgInfo',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/exclusiveAccounts/organizations/infos',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ListJoinOrgInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 通过手机号获取已加入的属于渠道组织的列表信息
     *  *
     * @param ListJoinOrgInfoRequest $request ListJoinOrgInfoRequest
     *
     * @return ListJoinOrgInfoResponse ListJoinOrgInfoResponse
     */
    public function listJoinOrgInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListJoinOrgInfoHeaders([]);

        return $this->listJoinOrgInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取小程序版本列表
     *  *
     * @param ListMiniAppAvailableVersionRequest $request ListMiniAppAvailableVersionRequest
     * @param ListMiniAppAvailableVersionHeaders $headers ListMiniAppAvailableVersionHeaders
     * @param RuntimeOptions                     $runtime runtime options for this request RuntimeOptions
     *
     * @return ListMiniAppAvailableVersionResponse ListMiniAppAvailableVersionResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'ListMiniAppAvailableVersion',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/miniApps/versions/availableLists',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return ListMiniAppAvailableVersionResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取小程序版本列表
     *  *
     * @param ListMiniAppAvailableVersionRequest $request ListMiniAppAvailableVersionRequest
     *
     * @return ListMiniAppAvailableVersionResponse ListMiniAppAvailableVersionResponse
     */
    public function listMiniAppAvailableVersion($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListMiniAppAvailableVersionHeaders([]);

        return $this->listMiniAppAvailableVersionWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取小程序历史版本列表
     *  *
     * @param ListMiniAppHistoryVersionRequest $request ListMiniAppHistoryVersionRequest
     * @param ListMiniAppHistoryVersionHeaders $headers ListMiniAppHistoryVersionHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return ListMiniAppHistoryVersionResponse ListMiniAppHistoryVersionResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'ListMiniAppHistoryVersion',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/miniApps/versions/historyLists',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return ListMiniAppHistoryVersionResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取小程序历史版本列表
     *  *
     * @param ListMiniAppHistoryVersionRequest $request ListMiniAppHistoryVersionRequest
     *
     * @return ListMiniAppHistoryVersionResponse ListMiniAppHistoryVersionResponse
     */
    public function listMiniAppHistoryVersion($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListMiniAppHistoryVersionHeaders([]);

        return $this->listMiniAppHistoryVersionWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询伙伴角色
     *  *
     * @param string                  $parentId
     * @param ListPartnerRolesHeaders $headers  ListPartnerRolesHeaders
     * @param RuntimeOptions          $runtime  runtime options for this request RuntimeOptions
     *
     * @return ListPartnerRolesResponse ListPartnerRolesResponse
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
            'action' => 'ListPartnerRoles',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/partners/roles/' . $parentId . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ListPartnerRolesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询伙伴角色
     *  *
     * @param string $parentId
     *
     * @return ListPartnerRolesResponse ListPartnerRolesResponse
     */
    public function listPartnerRoles($parentId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListPartnerRolesHeaders([]);

        return $this->listPartnerRolesWithOptions($parentId, $headers, $runtime);
    }

    /**
     * @summary 获取巡点信息列表
     *  *
     * @param ListPunchScheduleByConditionWithPagingRequest $request ListPunchScheduleByConditionWithPagingRequest
     * @param ListPunchScheduleByConditionWithPagingHeaders $headers ListPunchScheduleByConditionWithPagingHeaders
     * @param RuntimeOptions                                $runtime runtime options for this request RuntimeOptions
     *
     * @return ListPunchScheduleByConditionWithPagingResponse ListPunchScheduleByConditionWithPagingResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'ListPunchScheduleByConditionWithPaging',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/punchSchedules/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ListPunchScheduleByConditionWithPagingResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取巡点信息列表
     *  *
     * @param ListPunchScheduleByConditionWithPagingRequest $request ListPunchScheduleByConditionWithPagingRequest
     *
     * @return ListPunchScheduleByConditionWithPagingResponse ListPunchScheduleByConditionWithPagingResponse
     */
    public function listPunchScheduleByConditionWithPaging($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListPunchScheduleByConditionWithPagingHeaders([]);

        return $this->listPunchScheduleByConditionWithPagingWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询规则列表
     *  *
     * @param ListRulesRequest $tmpReq  ListRulesRequest
     * @param ListRulesHeaders $headers ListRulesHeaders
     * @param RuntimeOptions   $runtime runtime options for this request RuntimeOptions
     *
     * @return ListRulesResponse ListRulesResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'ListRules',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/messageCategories/rules/listRules',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ListRulesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询规则列表
     *  *
     * @param ListRulesRequest $request ListRulesRequest
     *
     * @return ListRulesResponse ListRulesResponse
     */
    public function listRules($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListRulesHeaders([]);

        return $this->listRulesWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 指定用户强制下线
     *  *
     * @param LogoutRequest  $request LogoutRequest
     * @param LogoutHeaders  $headers LogoutHeaders
     * @param RuntimeOptions $runtime runtime options for this request RuntimeOptions
     *
     * @return LogoutResponse LogoutResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'Logout',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/users/logout',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return LogoutResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 指定用户强制下线
     *  *
     * @param LogoutRequest $request LogoutRequest
     *
     * @return LogoutResponse LogoutResponse
     */
    public function logout($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new LogoutHeaders([]);

        return $this->logoutWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 购买权益包
     *  *
     * @param OpenBenefitPackageRequest $request OpenBenefitPackageRequest
     * @param OpenBenefitPackageHeaders $headers OpenBenefitPackageHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return OpenBenefitPackageResponse OpenBenefitPackageResponse
     */
    public function openBenefitPackageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->benefitPackage)) {
            $body['benefitPackage'] = $request->benefitPackage;
        }
        if (!Utils::isUnset($request->endDate)) {
            $body['endDate'] = $request->endDate;
        }
        if (!Utils::isUnset($request->startDate)) {
            $body['startDate'] = $request->startDate;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'OpenBenefitPackage',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/benefitPackages/purchase',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return OpenBenefitPackageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 购买权益包
     *  *
     * @param OpenBenefitPackageRequest $request OpenBenefitPackageRequest
     *
     * @return OpenBenefitPackageResponse OpenBenefitPackageResponse
     */
    public function openBenefitPackage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new OpenBenefitPackageHeaders([]);

        return $this->openBenefitPackageWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 商机冲突检测
     *  *
     * @param OpportunitySearchRequest $request OpportunitySearchRequest
     * @param OpportunitySearchHeaders $headers OpportunitySearchHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return OpportunitySearchResponse OpportunitySearchResponse
     */
    public function opportunitySearchWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'OpportunitySearch',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/opportunities/check',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return OpportunitySearchResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 商机冲突检测
     *  *
     * @param OpportunitySearchRequest $request OpportunitySearchRequest
     *
     * @return OpportunitySearchResponse OpportunitySearchResponse
     */
    public function opportunitySearch($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new OpportunitySearchHeaders([]);

        return $this->opportunitySearchWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 防作弊风险检测
     *  *
     * @param PreventCheatingCheckRiskRequest $request PreventCheatingCheckRiskRequest
     * @param PreventCheatingCheckRiskHeaders $headers PreventCheatingCheckRiskHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return PreventCheatingCheckRiskResponse PreventCheatingCheckRiskResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'PreventCheatingCheckRisk',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/preventCheats/risks/check',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return PreventCheatingCheckRiskResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 防作弊风险检测
     *  *
     * @param PreventCheatingCheckRiskRequest $request PreventCheatingCheckRiskRequest
     *
     * @return PreventCheatingCheckRiskResponse PreventCheatingCheckRiskResponse
     */
    public function preventCheatingCheckRisk($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PreventCheatingCheckRiskHeaders([]);

        return $this->preventCheatingCheckRiskWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 发送文件更改的评论
     *  *
     * @param PublishFileChangeNoticeRequest $request PublishFileChangeNoticeRequest
     * @param PublishFileChangeNoticeHeaders $headers PublishFileChangeNoticeHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return PublishFileChangeNoticeResponse PublishFileChangeNoticeResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'PublishFileChangeNotice',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/comments/send',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'none',
        ]);

        return PublishFileChangeNoticeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 发送文件更改的评论
     *  *
     * @param PublishFileChangeNoticeRequest $request PublishFileChangeNoticeRequest
     *
     * @return PublishFileChangeNoticeResponse PublishFileChangeNoticeResponse
     */
    public function publishFileChangeNotice($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PublishFileChangeNoticeHeaders([]);

        return $this->publishFileChangeNoticeWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 发布规则
     *  *
     * @param PublishRuleRequest $request PublishRuleRequest
     * @param PublishRuleHeaders $headers PublishRuleHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return PublishRuleResponse PublishRuleResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'PublishRule',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/messageCategories/rules/publish',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return PublishRuleResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 发布规则
     *  *
     * @param PublishRuleRequest $request PublishRuleRequest
     *
     * @return PublishRuleResponse PublishRuleResponse
     */
    public function publishRule($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PublishRuleHeaders([]);

        return $this->publishRuleWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 推送专属设计中自建/第三方应用的小红点
     *  *
     * @param PushBadgeRequest $request PushBadgeRequest
     * @param PushBadgeHeaders $headers PushBadgeHeaders
     * @param RuntimeOptions   $runtime runtime options for this request RuntimeOptions
     *
     * @return PushBadgeResponse PushBadgeResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'PushBadge',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/exclusiveDesigns/redPoints/push',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return PushBadgeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 推送专属设计中自建/第三方应用的小红点
     *  *
     * @param PushBadgeRequest $request PushBadgeRequest
     *
     * @return PushBadgeResponse PushBadgeResponse
     */
    public function pushBadge($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PushBadgeHeaders([]);

        return $this->pushBadgeWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询跨云存储配置
     *  *
     * @param QueryAcrossCloudStroageConfigsRequest $request QueryAcrossCloudStroageConfigsRequest
     * @param QueryAcrossCloudStroageConfigsHeaders $headers QueryAcrossCloudStroageConfigsHeaders
     * @param RuntimeOptions                        $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryAcrossCloudStroageConfigsResponse QueryAcrossCloudStroageConfigsResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'QueryAcrossCloudStroageConfigs',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/fileStorages/acrossClouds/configurations',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryAcrossCloudStroageConfigsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询跨云存储配置
     *  *
     * @param QueryAcrossCloudStroageConfigsRequest $request QueryAcrossCloudStroageConfigsRequest
     *
     * @return QueryAcrossCloudStroageConfigsResponse QueryAcrossCloudStroageConfigsResponse
     */
    public function queryAcrossCloudStroageConfigs($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryAcrossCloudStroageConfigsHeaders([]);

        return $this->queryAcrossCloudStroageConfigsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 根据手机号查询渠道组织中的员工信息
     *  *
     * @param QueryChannelStaffInfoByMobileRequest $request QueryChannelStaffInfoByMobileRequest
     * @param QueryChannelStaffInfoByMobileHeaders $headers QueryChannelStaffInfoByMobileHeaders
     * @param RuntimeOptions                       $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryChannelStaffInfoByMobileResponse QueryChannelStaffInfoByMobileResponse
     */
    public function queryChannelStaffInfoByMobileWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->mobile)) {
            $query['mobile'] = $request->mobile;
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'QueryChannelStaffInfoByMobile',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/channelOrganizations/users',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryChannelStaffInfoByMobileResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据手机号查询渠道组织中的员工信息
     *  *
     * @param QueryChannelStaffInfoByMobileRequest $request QueryChannelStaffInfoByMobileRequest
     *
     * @return QueryChannelStaffInfoByMobileResponse QueryChannelStaffInfoByMobileResponse
     */
    public function queryChannelStaffInfoByMobile($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryChannelStaffInfoByMobileHeaders([]);

        return $this->queryChannelStaffInfoByMobileWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取分组下会话列表
     *  *
     * @param QueryConversationPageRequest $request QueryConversationPageRequest
     * @param QueryConversationPageHeaders $headers QueryConversationPageHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryConversationPageResponse QueryConversationPageResponse
     */
    public function queryConversationPageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->categoryId)) {
            $query['categoryId'] = $request->categoryId;
        }
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'QueryConversationPage',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/categories/conversations',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryConversationPageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取分组下会话列表
     *  *
     * @param QueryConversationPageRequest $request QueryConversationPageRequest
     *
     * @return QueryConversationPageResponse QueryConversationPageResponse
     */
    public function queryConversationPage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryConversationPageHeaders([]);

        return $this->queryConversationPageWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询专属版权益
     *  *
     * @param QueryExclusiveBenefitsHeaders $headers QueryExclusiveBenefitsHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryExclusiveBenefitsResponse QueryExclusiveBenefitsResponse
     */
    public function queryExclusiveBenefitsWithOptions($headers, $runtime)
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
            'action' => 'QueryExclusiveBenefits',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/benefits',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryExclusiveBenefitsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询专属版权益
     *  *
     * @return QueryExclusiveBenefitsResponse QueryExclusiveBenefitsResponse
     */
    public function queryExclusiveBenefits()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryExclusiveBenefitsHeaders([]);

        return $this->queryExclusiveBenefitsWithOptions($headers, $runtime);
    }

    /**
     * @summary 伙伴钉根据uid查询人员的标签信息
     *  *
     * @param string                  $userId
     * @param QueryPartnerInfoHeaders $headers QueryPartnerInfoHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryPartnerInfoResponse QueryPartnerInfoResponse
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
            'action' => 'QueryPartnerInfo',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/partners/users/' . $userId . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryPartnerInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 伙伴钉根据uid查询人员的标签信息
     *  *
     * @param string $userId
     *
     * @return QueryPartnerInfoResponse QueryPartnerInfoResponse
     */
    public function queryPartnerInfo($userId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryPartnerInfoHeaders([]);

        return $this->queryPartnerInfoWithOptions($userId, $headers, $runtime);
    }

    /**
     * @summary 根据templateId查询模版信息
     *  *
     * @param string                   $templateId
     * @param QueryTemplateInfoHeaders $headers    QueryTemplateInfoHeaders
     * @param RuntimeOptions           $runtime    runtime options for this request RuntimeOptions
     *
     * @return QueryTemplateInfoResponse QueryTemplateInfoResponse
     */
    public function queryTemplateInfoWithOptions($templateId, $headers, $runtime)
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
            'action' => 'QueryTemplateInfo',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/sceneGroups/templates/' . $templateId . '/infos',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryTemplateInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据templateId查询模版信息
     *  *
     * @param string $templateId
     *
     * @return QueryTemplateInfoResponse QueryTemplateInfoResponse
     */
    public function queryTemplateInfo($templateId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryTemplateInfoHeaders([]);

        return $this->queryTemplateInfoWithOptions($templateId, $headers, $runtime);
    }

    /**
     * @summary 获取用户截屏操作记录
     *  *
     * @param QueryUserBehaviorRequest $request QueryUserBehaviorRequest
     * @param QueryUserBehaviorHeaders $headers QueryUserBehaviorHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryUserBehaviorResponse QueryUserBehaviorResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'QueryUserBehavior',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/enterpriseSecurities/userBehaviors/screenshots/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryUserBehaviorResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取用户截屏操作记录
     *  *
     * @param QueryUserBehaviorRequest $request QueryUserBehaviorRequest
     *
     * @return QueryUserBehaviorResponse QueryUserBehaviorResponse
     */
    public function queryUserBehavior($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryUserBehaviorHeaders([]);

        return $this->queryUserBehaviorWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 小程序版本回滚
     *  *
     * @param RollbackMiniAppVersionRequest $request RollbackMiniAppVersionRequest
     * @param RollbackMiniAppVersionHeaders $headers RollbackMiniAppVersionHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return RollbackMiniAppVersionResponse RollbackMiniAppVersionResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'RollbackMiniAppVersion',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/miniApps/versions/rollback',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return RollbackMiniAppVersionResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 小程序版本回滚
     *  *
     * @param RollbackMiniAppVersionRequest $request RollbackMiniAppVersionRequest
     *
     * @return RollbackMiniAppVersionResponse RollbackMiniAppVersionResponse
     */
    public function rollbackMiniAppVersion($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RollbackMiniAppVersionHeaders([]);

        return $this->rollbackMiniAppVersionWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 按规则批量发消息
     *  *
     * @param RuleBatchReceiverRequest $request RuleBatchReceiverRequest
     * @param RuleBatchReceiverHeaders $headers RuleBatchReceiverHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return RuleBatchReceiverResponse RuleBatchReceiverResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'RuleBatchReceiver',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/dmc/rules/messages/batchSend',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return RuleBatchReceiverResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 按规则批量发消息
     *  *
     * @param RuleBatchReceiverRequest $request RuleBatchReceiverRequest
     *
     * @return RuleBatchReceiverResponse RuleBatchReceiverResponse
     */
    public function ruleBatchReceiver($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RuleBatchReceiverHeaders([]);

        return $this->ruleBatchReceiverWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 新增跨云存储配置
     *  *
     * @param SaveAcrossCloudStroageConfigsRequest $request SaveAcrossCloudStroageConfigsRequest
     * @param SaveAcrossCloudStroageConfigsHeaders $headers SaveAcrossCloudStroageConfigsHeaders
     * @param RuntimeOptions                       $runtime runtime options for this request RuntimeOptions
     *
     * @return SaveAcrossCloudStroageConfigsResponse SaveAcrossCloudStroageConfigsResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'SaveAcrossCloudStroageConfigs',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/fileStorages/acrossClouds/configurations',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SaveAcrossCloudStroageConfigsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 新增跨云存储配置
     *  *
     * @param SaveAcrossCloudStroageConfigsRequest $request SaveAcrossCloudStroageConfigsRequest
     *
     * @return SaveAcrossCloudStroageConfigsResponse SaveAcrossCloudStroageConfigsResponse
     */
    public function saveAcrossCloudStroageConfigs($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SaveAcrossCloudStroageConfigsHeaders([]);

        return $this->saveAcrossCloudStroageConfigsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 保存并提交认证信息
     *  *
     * @param SaveAndSubmitAuthInfoRequest $request SaveAndSubmitAuthInfoRequest
     * @param SaveAndSubmitAuthInfoHeaders $headers SaveAndSubmitAuthInfoHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return SaveAndSubmitAuthInfoResponse SaveAndSubmitAuthInfoResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'SaveAndSubmitAuthInfo',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/ognizations/authInfos/saveAndSubmit',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SaveAndSubmitAuthInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 保存并提交认证信息
     *  *
     * @param SaveAndSubmitAuthInfoRequest $request SaveAndSubmitAuthInfoRequest
     *
     * @return SaveAndSubmitAuthInfoResponse SaveAndSubmitAuthInfoResponse
     */
    public function saveAndSubmitAuthInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SaveAndSubmitAuthInfoHeaders([]);

        return $this->saveAndSubmitAuthInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 亿格云能力结合
     *  *
     * @param SaveOpenTerminalInfoRequest $request SaveOpenTerminalInfoRequest
     * @param SaveOpenTerminalInfoHeaders $headers SaveOpenTerminalInfoHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return SaveOpenTerminalInfoResponse SaveOpenTerminalInfoResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'SaveOpenTerminalInfo',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/externalLogs/terminalInfos/save',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SaveOpenTerminalInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 亿格云能力结合
     *  *
     * @param SaveOpenTerminalInfoRequest $request SaveOpenTerminalInfoRequest
     *
     * @return SaveOpenTerminalInfoResponse SaveOpenTerminalInfoResponse
     */
    public function saveOpenTerminalInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SaveOpenTerminalInfoHeaders([]);

        return $this->saveOpenTerminalInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 保存专属文件存储的功能项
     *  *
     * @param SaveStorageFunctionSwitchRequest $request SaveStorageFunctionSwitchRequest
     * @param SaveStorageFunctionSwitchHeaders $headers SaveStorageFunctionSwitchHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return SaveStorageFunctionSwitchResponse SaveStorageFunctionSwitchResponse
     */
    public function saveStorageFunctionSwitchWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->functionList)) {
            $body['functionList'] = $request->functionList;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'SaveStorageFunctionSwitch',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/storages/functions/save',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SaveStorageFunctionSwitchResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 保存专属文件存储的功能项
     *  *
     * @param SaveStorageFunctionSwitchRequest $request SaveStorageFunctionSwitchRequest
     *
     * @return SaveStorageFunctionSwitchResponse SaveStorageFunctionSwitchResponse
     */
    public function saveStorageFunctionSwitch($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SaveStorageFunctionSwitchHeaders([]);

        return $this->saveStorageFunctionSwitchWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 保存专属文件存储整体开关
     *  *
     * @param SaveStorageSwitchRequest $request SaveStorageSwitchRequest
     * @param SaveStorageSwitchHeaders $headers SaveStorageSwitchHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return SaveStorageSwitchResponse SaveStorageSwitchResponse
     */
    public function saveStorageSwitchWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->openStorage)) {
            $body['openStorage'] = $request->openStorage;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'SaveStorageSwitch',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/storages/switches/save',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SaveStorageSwitchResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 保存专属文件存储整体开关
     *  *
     * @param SaveStorageSwitchRequest $request SaveStorageSwitchRequest
     *
     * @return SaveStorageSwitchResponse SaveStorageSwitchResponse
     */
    public function saveStorageSwitch($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SaveStorageSwitchHeaders([]);

        return $this->saveStorageSwitchWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 用于提供mdm微应用白名单配置能力
     *  *
     * @param SaveWhiteAppRequest $request SaveWhiteAppRequest
     * @param SaveWhiteAppHeaders $headers SaveWhiteAppHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return SaveWhiteAppResponse SaveWhiteAppResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'SaveWhiteApp',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/miniApps/whiteLists/save',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SaveWhiteAppResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 用于提供mdm微应用白名单配置能力
     *  *
     * @param SaveWhiteAppRequest $request SaveWhiteAppRequest
     *
     * @return SaveWhiteAppResponse SaveWhiteAppResponse
     */
    public function saveWhiteApp($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SaveWhiteAppHeaders([]);

        return $this->saveWhiteAppWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询企业内部群信息
     *  *
     * @param SearchOrgInnerGroupInfoRequest $request SearchOrgInnerGroupInfoRequest
     * @param SearchOrgInnerGroupInfoHeaders $headers SearchOrgInnerGroupInfoHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return SearchOrgInnerGroupInfoResponse SearchOrgInnerGroupInfoResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'SearchOrgInnerGroupInfo',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/securities/orgGroupInfos',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SearchOrgInnerGroupInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询企业内部群信息
     *  *
     * @param SearchOrgInnerGroupInfoRequest $request SearchOrgInnerGroupInfoRequest
     *
     * @return SearchOrgInnerGroupInfoResponse SearchOrgInnerGroupInfoResponse
     */
    public function searchOrgInnerGroupInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchOrgInnerGroupInfoHeaders([]);

        return $this->searchOrgInnerGroupInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 通过接口发送应用内DING
     *  *
     * @param SendAppDingRequest $request SendAppDingRequest
     * @param SendAppDingHeaders $headers SendAppDingHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return SendAppDingResponse SendAppDingResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'SendAppDing',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/appDings/send',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'none',
        ]);

        return SendAppDingResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 通过接口发送应用内DING
     *  *
     * @param SendAppDingRequest $request SendAppDingRequest
     *
     * @return SendAppDingResponse SendAppDingResponse
     */
    public function sendAppDing($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendAppDingHeaders([]);

        return $this->sendAppDingWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 发送邀请函
     *  *
     * @param SendInvitationRequest $request SendInvitationRequest
     * @param SendInvitationHeaders $headers SendInvitationHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return SendInvitationResponse SendInvitationResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'SendInvitation',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/partnerDepartments/invitations/send',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'none',
        ]);

        return SendInvitationResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 发送邀请函
     *  *
     * @param SendInvitationRequest $request SendInvitationRequest
     *
     * @return SendInvitationResponse SendInvitationResponse
     */
    public function sendInvitation($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendInvitationHeaders([]);

        return $this->sendInvitationWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 通过接口发送电话DING
     *  *
     * @param SendPhoneDingRequest $request SendPhoneDingRequest
     * @param SendPhoneDingHeaders $headers SendPhoneDingHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return SendPhoneDingResponse SendPhoneDingResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'SendPhoneDing',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/phoneDings/send',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SendPhoneDingResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 通过接口发送电话DING
     *  *
     * @param SendPhoneDingRequest $request SendPhoneDingRequest
     *
     * @return SendPhoneDingResponse SendPhoneDingResponse
     */
    public function sendPhoneDing($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendPhoneDingHeaders([]);

        return $this->sendPhoneDingWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 设置会话所属分组
     *  *
     * @param SetConversationCategoryRequest $request SetConversationCategoryRequest
     * @param SetConversationCategoryHeaders $headers SetConversationCategoryHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return SetConversationCategoryResponse SetConversationCategoryResponse
     */
    public function setConversationCategoryWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->categoryId)) {
            $body['categoryId'] = $request->categoryId;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'SetConversationCategory',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/conversationCategories/set',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SetConversationCategoryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 设置会话所属分组
     *  *
     * @param SetConversationCategoryRequest $request SetConversationCategoryRequest
     *
     * @return SetConversationCategoryResponse SetConversationCategoryResponse
     */
    public function setConversationCategory($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SetConversationCategoryHeaders([]);

        return $this->setConversationCategoryWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 设置会话副标题
     *  *
     * @param SetConversationSubtitleRequest $request SetConversationSubtitleRequest
     * @param SetConversationSubtitleHeaders $headers SetConversationSubtitleHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return SetConversationSubtitleResponse SetConversationSubtitleResponse
     */
    public function setConversationSubtitleWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->subtitle)) {
            $body['subtitle'] = $request->subtitle;
        }
        if (!Utils::isUnset($request->subtitleColor)) {
            $body['subtitleColor'] = $request->subtitleColor;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'SetConversationSubtitle',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/conversations/subtitles/set',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SetConversationSubtitleResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 设置会话副标题
     *  *
     * @param SetConversationSubtitleRequest $request SetConversationSubtitleRequest
     *
     * @return SetConversationSubtitleResponse SetConversationSubtitleResponse
     */
    public function setConversationSubtitle($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SetConversationSubtitleHeaders([]);

        return $this->setConversationSubtitleWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 设置会话所属顶部分组
     *  *
     * @param SetConversationTopCategoryRequest $request SetConversationTopCategoryRequest
     * @param SetConversationTopCategoryHeaders $headers SetConversationTopCategoryHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return SetConversationTopCategoryResponse SetConversationTopCategoryResponse
     */
    public function setConversationTopCategoryWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->setCategoryList)) {
            $body['setCategoryList'] = $request->setCategoryList;
        }
        if (!Utils::isUnset($request->sign)) {
            $body['sign'] = $request->sign;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'SetConversationTopCategory',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/conversations/topCategories/set',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SetConversationTopCategoryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 设置会话所属顶部分组
     *  *
     * @param SetConversationTopCategoryRequest $request SetConversationTopCategoryRequest
     *
     * @return SetConversationTopCategoryResponse SetConversationTopCategoryResponse
     */
    public function setConversationTopCategory($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SetConversationTopCategoryHeaders([]);

        return $this->setConversationTopCategoryWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 伙伴钉设置部门伙伴编码和伙伴类型
     *  *
     * @param SetDeptPartnerTypeAndNumRequest $request SetDeptPartnerTypeAndNumRequest
     * @param SetDeptPartnerTypeAndNumHeaders $headers SetDeptPartnerTypeAndNumHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return SetDeptPartnerTypeAndNumResponse SetDeptPartnerTypeAndNumResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'SetDeptPartnerTypeAndNum',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/partnerDepartments',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return SetDeptPartnerTypeAndNumResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 伙伴钉设置部门伙伴编码和伙伴类型
     *  *
     * @param SetDeptPartnerTypeAndNumRequest $request SetDeptPartnerTypeAndNumRequest
     *
     * @return SetDeptPartnerTypeAndNumResponse SetDeptPartnerTypeAndNumResponse
     */
    public function setDeptPartnerTypeAndNum($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SetDeptPartnerTypeAndNumHeaders([]);

        return $this->setDeptPartnerTypeAndNumWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 设置企业全局顶部会话分组
     *  *
     * @param SetOrgTopConversationCategoryRequest $request SetOrgTopConversationCategoryRequest
     * @param SetOrgTopConversationCategoryHeaders $headers SetOrgTopConversationCategoryHeaders
     * @param RuntimeOptions                       $runtime runtime options for this request RuntimeOptions
     *
     * @return SetOrgTopConversationCategoryResponse SetOrgTopConversationCategoryResponse
     */
    public function setOrgTopConversationCategoryWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body' => Utils::toArray($request->body),
        ]);
        $params = new Params([
            'action' => 'SetOrgTopConversationCategory',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/topConversations/categories/set',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SetOrgTopConversationCategoryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 设置企业全局顶部会话分组
     *  *
     * @param SetOrgTopConversationCategoryRequest $request SetOrgTopConversationCategoryRequest
     *
     * @return SetOrgTopConversationCategoryResponse SetOrgTopConversationCategoryResponse
     */
    public function setOrgTopConversationCategory($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SetOrgTopConversationCategoryHeaders([]);

        return $this->setOrgTopConversationCategoryWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 千人千面按规则批量发消息
     *  *
     * @param SpecialRuleBatchReceiverRequest $request SpecialRuleBatchReceiverRequest
     * @param SpecialRuleBatchReceiverHeaders $headers SpecialRuleBatchReceiverHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return SpecialRuleBatchReceiverResponse SpecialRuleBatchReceiverResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'SpecialRuleBatchReceiver',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/dmc/rules/specialMessages/batchSend',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SpecialRuleBatchReceiverResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 千人千面按规则批量发消息
     *  *
     * @param SpecialRuleBatchReceiverRequest $request SpecialRuleBatchReceiverRequest
     *
     * @return SpecialRuleBatchReceiverResponse SpecialRuleBatchReceiverResponse
     */
    public function specialRuleBatchReceiver($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SpecialRuleBatchReceiverHeaders([]);

        return $this->specialRuleBatchReceiverWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 增加/删除任务人员
     *  *
     * @param TaskInfoAddDelTaskPersonRequest $request TaskInfoAddDelTaskPersonRequest
     * @param TaskInfoAddDelTaskPersonHeaders $headers TaskInfoAddDelTaskPersonHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return TaskInfoAddDelTaskPersonResponse TaskInfoAddDelTaskPersonResponse
     */
    public function taskInfoAddDelTaskPersonWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->operateType)) {
            $body['operateType'] = $request->operateType;
        }
        if (!Utils::isUnset($request->operatorAccount)) {
            $body['operatorAccount'] = $request->operatorAccount;
        }
        if (!Utils::isUnset($request->outTaskId)) {
            $body['outTaskId'] = $request->outTaskId;
        }
        if (!Utils::isUnset($request->projId)) {
            $body['projId'] = $request->projId;
        }
        if (!Utils::isUnset($request->secretKey)) {
            $body['secretKey'] = $request->secretKey;
        }
        if (!Utils::isUnset($request->taskExecutePersonDTOS)) {
            $body['taskExecutePersonDTOS'] = $request->taskExecutePersonDTOS;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'TaskInfoAddDelTaskPerson',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/taskCenters/taskInfos/addDelTaskPerson',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return TaskInfoAddDelTaskPersonResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 增加/删除任务人员
     *  *
     * @param TaskInfoAddDelTaskPersonRequest $request TaskInfoAddDelTaskPersonRequest
     *
     * @return TaskInfoAddDelTaskPersonResponse TaskInfoAddDelTaskPersonResponse
     */
    public function taskInfoAddDelTaskPerson($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new TaskInfoAddDelTaskPersonHeaders([]);

        return $this->taskInfoAddDelTaskPersonWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除任务
     *  *
     * @param TaskInfoCancelOrDelTaskRequest $request TaskInfoCancelOrDelTaskRequest
     * @param TaskInfoCancelOrDelTaskHeaders $headers TaskInfoCancelOrDelTaskHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return TaskInfoCancelOrDelTaskResponse TaskInfoCancelOrDelTaskResponse
     */
    public function taskInfoCancelOrDelTaskWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->cardDTO)) {
            $body['cardDTO'] = $request->cardDTO;
        }
        if (!Utils::isUnset($request->operatorAccount)) {
            $body['operatorAccount'] = $request->operatorAccount;
        }
        if (!Utils::isUnset($request->outTaskId)) {
            $body['outTaskId'] = $request->outTaskId;
        }
        if (!Utils::isUnset($request->projId)) {
            $body['projId'] = $request->projId;
        }
        if (!Utils::isUnset($request->secretKey)) {
            $body['secretKey'] = $request->secretKey;
        }
        if (!Utils::isUnset($request->sendMsgFlag)) {
            $body['sendMsgFlag'] = $request->sendMsgFlag;
        }
        if (!Utils::isUnset($request->taskExecutePersonDTOS)) {
            $body['taskExecutePersonDTOS'] = $request->taskExecutePersonDTOS;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'TaskInfoCancelOrDelTask',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/taskCenters/taskInfos/cancelOrDelTask',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return TaskInfoCancelOrDelTaskResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除任务
     *  *
     * @param TaskInfoCancelOrDelTaskRequest $request TaskInfoCancelOrDelTaskRequest
     *
     * @return TaskInfoCancelOrDelTaskResponse TaskInfoCancelOrDelTaskResponse
     */
    public function taskInfoCancelOrDelTask($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new TaskInfoCancelOrDelTaskHeaders([]);

        return $this->taskInfoCancelOrDelTaskWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建并启动任务
     *  *
     * @param TaskInfoCreateAndStartTaskRequest $request TaskInfoCreateAndStartTaskRequest
     * @param TaskInfoCreateAndStartTaskHeaders $headers TaskInfoCreateAndStartTaskHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return TaskInfoCreateAndStartTaskResponse TaskInfoCreateAndStartTaskResponse
     */
    public function taskInfoCreateAndStartTaskWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->attr)) {
            $body['attr'] = $request->attr;
        }
        if (!Utils::isUnset($request->backlogDTO)) {
            $body['backlogDTO'] = $request->backlogDTO;
        }
        if (!Utils::isUnset($request->backlogGenerateFlag)) {
            $body['backlogGenerateFlag'] = $request->backlogGenerateFlag;
        }
        if (!Utils::isUnset($request->businessCode)) {
            $body['businessCode'] = $request->businessCode;
        }
        if (!Utils::isUnset($request->canceldelTaskCardId)) {
            $body['canceldelTaskCardId'] = $request->canceldelTaskCardId;
        }
        if (!Utils::isUnset($request->cardDTO)) {
            $body['cardDTO'] = $request->cardDTO;
        }
        if (!Utils::isUnset($request->customFlag)) {
            $body['customFlag'] = $request->customFlag;
        }
        if (!Utils::isUnset($request->detailUrl)) {
            $body['detailUrl'] = $request->detailUrl;
        }
        if (!Utils::isUnset($request->finishTaskCardId)) {
            $body['finishTaskCardId'] = $request->finishTaskCardId;
        }
        if (!Utils::isUnset($request->operatorAccount)) {
            $body['operatorAccount'] = $request->operatorAccount;
        }
        if (!Utils::isUnset($request->outTaskId)) {
            $body['outTaskId'] = $request->outTaskId;
        }
        if (!Utils::isUnset($request->projId)) {
            $body['projId'] = $request->projId;
        }
        if (!Utils::isUnset($request->robotCode)) {
            $body['robotCode'] = $request->robotCode;
        }
        if (!Utils::isUnset($request->secretKey)) {
            $body['secretKey'] = $request->secretKey;
        }
        if (!Utils::isUnset($request->sendMsgFlag)) {
            $body['sendMsgFlag'] = $request->sendMsgFlag;
        }
        if (!Utils::isUnset($request->sort)) {
            $body['sort'] = $request->sort;
        }
        if (!Utils::isUnset($request->startTaskCardId)) {
            $body['startTaskCardId'] = $request->startTaskCardId;
        }
        if (!Utils::isUnset($request->state)) {
            $body['state'] = $request->state;
        }
        if (!Utils::isUnset($request->taskContent)) {
            $body['taskContent'] = $request->taskContent;
        }
        if (!Utils::isUnset($request->taskEndTime)) {
            $body['taskEndTime'] = $request->taskEndTime;
        }
        if (!Utils::isUnset($request->taskExecutePersonDTOS)) {
            $body['taskExecutePersonDTOS'] = $request->taskExecutePersonDTOS;
        }
        if (!Utils::isUnset($request->taskGroupDTOList)) {
            $body['taskGroupDTOList'] = $request->taskGroupDTOList;
        }
        if (!Utils::isUnset($request->taskSystem)) {
            $body['taskSystem'] = $request->taskSystem;
        }
        if (!Utils::isUnset($request->taskTemplCode)) {
            $body['taskTemplCode'] = $request->taskTemplCode;
        }
        if (!Utils::isUnset($request->taskTitle)) {
            $body['taskTitle'] = $request->taskTitle;
        }
        if (!Utils::isUnset($request->taskType)) {
            $body['taskType'] = $request->taskType;
        }
        if (!Utils::isUnset($request->taskUrlMobile)) {
            $body['taskUrlMobile'] = $request->taskUrlMobile;
        }
        if (!Utils::isUnset($request->taskUrlPc)) {
            $body['taskUrlPc'] = $request->taskUrlPc;
        }
        if (!Utils::isUnset($request->updateTaskCardId)) {
            $body['updateTaskCardId'] = $request->updateTaskCardId;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'TaskInfoCreateAndStartTask',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/taskCenters/taskInfos/createAndStart',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return TaskInfoCreateAndStartTaskResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建并启动任务
     *  *
     * @param TaskInfoCreateAndStartTaskRequest $request TaskInfoCreateAndStartTaskRequest
     *
     * @return TaskInfoCreateAndStartTaskResponse TaskInfoCreateAndStartTaskResponse
     */
    public function taskInfoCreateAndStartTask($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new TaskInfoCreateAndStartTaskHeaders([]);

        return $this->taskInfoCreateAndStartTaskWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 完成任务
     *  *
     * @param TaskInfoFinishTaskRequest $request TaskInfoFinishTaskRequest
     * @param TaskInfoFinishTaskHeaders $headers TaskInfoFinishTaskHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return TaskInfoFinishTaskResponse TaskInfoFinishTaskResponse
     */
    public function taskInfoFinishTaskWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->cardDTO)) {
            $body['cardDTO'] = $request->cardDTO;
        }
        if (!Utils::isUnset($request->operatorAccount)) {
            $body['operatorAccount'] = $request->operatorAccount;
        }
        if (!Utils::isUnset($request->outTaskId)) {
            $body['outTaskId'] = $request->outTaskId;
        }
        if (!Utils::isUnset($request->projId)) {
            $body['projId'] = $request->projId;
        }
        if (!Utils::isUnset($request->secretKey)) {
            $body['secretKey'] = $request->secretKey;
        }
        if (!Utils::isUnset($request->sendMsgFlag)) {
            $body['sendMsgFlag'] = $request->sendMsgFlag;
        }
        if (!Utils::isUnset($request->taskExecutePersonDTOS)) {
            $body['taskExecutePersonDTOS'] = $request->taskExecutePersonDTOS;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'TaskInfoFinishTask',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/taskCenters/taskInfos/finishTask',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return TaskInfoFinishTaskResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 完成任务
     *  *
     * @param TaskInfoFinishTaskRequest $request TaskInfoFinishTaskRequest
     *
     * @return TaskInfoFinishTaskResponse TaskInfoFinishTaskResponse
     */
    public function taskInfoFinishTask($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new TaskInfoFinishTaskHeaders([]);

        return $this->taskInfoFinishTaskWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新任务
     *  *
     * @param TaskInfoUpdateTaskRequest $request TaskInfoUpdateTaskRequest
     * @param TaskInfoUpdateTaskHeaders $headers TaskInfoUpdateTaskHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return TaskInfoUpdateTaskResponse TaskInfoUpdateTaskResponse
     */
    public function taskInfoUpdateTaskWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->attr)) {
            $body['attr'] = $request->attr;
        }
        if (!Utils::isUnset($request->canceldelTaskCardId)) {
            $body['canceldelTaskCardId'] = $request->canceldelTaskCardId;
        }
        if (!Utils::isUnset($request->cardDTO)) {
            $body['cardDTO'] = $request->cardDTO;
        }
        if (!Utils::isUnset($request->detailUrl)) {
            $body['detailUrl'] = $request->detailUrl;
        }
        if (!Utils::isUnset($request->finishTaskCardId)) {
            $body['finishTaskCardId'] = $request->finishTaskCardId;
        }
        if (!Utils::isUnset($request->listOpenConversationId)) {
            $body['listOpenConversationId'] = $request->listOpenConversationId;
        }
        if (!Utils::isUnset($request->operateType)) {
            $body['operateType'] = $request->operateType;
        }
        if (!Utils::isUnset($request->operatorAccount)) {
            $body['operatorAccount'] = $request->operatorAccount;
        }
        if (!Utils::isUnset($request->outTaskId)) {
            $body['outTaskId'] = $request->outTaskId;
        }
        if (!Utils::isUnset($request->projId)) {
            $body['projId'] = $request->projId;
        }
        if (!Utils::isUnset($request->secretKey)) {
            $body['secretKey'] = $request->secretKey;
        }
        if (!Utils::isUnset($request->sendMsgFlag)) {
            $body['sendMsgFlag'] = $request->sendMsgFlag;
        }
        if (!Utils::isUnset($request->startTaskCardId)) {
            $body['startTaskCardId'] = $request->startTaskCardId;
        }
        if (!Utils::isUnset($request->taskContent)) {
            $body['taskContent'] = $request->taskContent;
        }
        if (!Utils::isUnset($request->taskEndTime)) {
            $body['taskEndTime'] = $request->taskEndTime;
        }
        if (!Utils::isUnset($request->taskExecutePersonDTOS)) {
            $body['taskExecutePersonDTOS'] = $request->taskExecutePersonDTOS;
        }
        if (!Utils::isUnset($request->taskTitle)) {
            $body['taskTitle'] = $request->taskTitle;
        }
        if (!Utils::isUnset($request->taskUrlMobile)) {
            $body['taskUrlMobile'] = $request->taskUrlMobile;
        }
        if (!Utils::isUnset($request->taskUrlPc)) {
            $body['taskUrlPc'] = $request->taskUrlPc;
        }
        if (!Utils::isUnset($request->updateTaskCardId)) {
            $body['updateTaskCardId'] = $request->updateTaskCardId;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'TaskInfoUpdateTask',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/taskCenters/taskInfos/update',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return TaskInfoUpdateTaskResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新任务
     *  *
     * @param TaskInfoUpdateTaskRequest $request TaskInfoUpdateTaskRequest
     *
     * @return TaskInfoUpdateTaskResponse TaskInfoUpdateTaskResponse
     */
    public function taskInfoUpdateTask($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new TaskInfoUpdateTaskHeaders([]);

        return $this->taskInfoUpdateTaskWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 切换组织归属
     *  *
     * @param TransferExclusiveAccountOrgRequest $request TransferExclusiveAccountOrgRequest
     * @param TransferExclusiveAccountOrgHeaders $headers TransferExclusiveAccountOrgHeaders
     * @param RuntimeOptions                     $runtime runtime options for this request RuntimeOptions
     *
     * @return TransferExclusiveAccountOrgResponse TransferExclusiveAccountOrgResponse
     */
    public function transferExclusiveAccountOrgWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->isSettingMainOrg)) {
            $body['isSettingMainOrg'] = $request->isSettingMainOrg;
        }
        if (!Utils::isUnset($request->targetCorpId)) {
            $body['targetCorpId'] = $request->targetCorpId;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'TransferExclusiveAccountOrg',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/organizations/transfer',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return TransferExclusiveAccountOrgResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 切换组织归属
     *  *
     * @param TransferExclusiveAccountOrgRequest $request TransferExclusiveAccountOrgRequest
     *
     * @return TransferExclusiveAccountOrgResponse TransferExclusiveAccountOrgResponse
     */
    public function transferExclusiveAccountOrg($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new TransferExclusiveAccountOrgHeaders([]);

        return $this->transferExclusiveAccountOrgWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更改分组名称
     *  *
     * @param UpdateCategoryNameRequest $request UpdateCategoryNameRequest
     * @param UpdateCategoryNameHeaders $headers UpdateCategoryNameHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateCategoryNameResponse UpdateCategoryNameResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'UpdateCategoryName',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/messageCategories/categories/names',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateCategoryNameResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更改分组名称
     *  *
     * @param UpdateCategoryNameRequest $request UpdateCategoryNameRequest
     *
     * @return UpdateCategoryNameResponse UpdateCategoryNameResponse
     */
    public function updateCategoryName($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateCategoryNameHeaders([]);

        return $this->updateCategoryNameWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 变更群聊类型
     *  *
     * @param UpdateConversationTypeRequest $request UpdateConversationTypeRequest
     * @param UpdateConversationTypeHeaders $headers UpdateConversationTypeHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateConversationTypeResponse UpdateConversationTypeResponse
     */
    public function updateConversationTypeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->manageSign)) {
            $body['manageSign'] = $request->manageSign;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'UpdateConversationType',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/conversationTypes',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateConversationTypeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 变更群聊类型
     *  *
     * @param UpdateConversationTypeRequest $request UpdateConversationTypeRequest
     *
     * @return UpdateConversationTypeResponse UpdateConversationTypeResponse
     */
    public function updateConversationType($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateConversationTypeHeaders([]);

        return $this->updateConversationTypeWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新发送文件的检测状态
     *  *
     * @param UpdateFileStatusRequest $request UpdateFileStatusRequest
     * @param UpdateFileStatusHeaders $headers UpdateFileStatusHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateFileStatusResponse UpdateFileStatusResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'UpdateFileStatus',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/sending/files/status',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateFileStatusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新发送文件的检测状态
     *  *
     * @param UpdateFileStatusRequest $request UpdateFileStatusRequest
     *
     * @return UpdateFileStatusResponse UpdateFileStatusResponse
     */
    public function updateFileStatus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateFileStatusHeaders([]);

        return $this->updateFileStatusWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 发布版本
     *  *
     * @param UpdateMiniAppVersionStatusRequest $request UpdateMiniAppVersionStatusRequest
     * @param UpdateMiniAppVersionStatusHeaders $headers UpdateMiniAppVersionStatusHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateMiniAppVersionStatusResponse UpdateMiniAppVersionStatusResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'UpdateMiniAppVersionStatus',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/miniApps/versions/versionStatus',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return UpdateMiniAppVersionStatusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 发布版本
     *  *
     * @param UpdateMiniAppVersionStatusRequest $request UpdateMiniAppVersionStatusRequest
     *
     * @return UpdateMiniAppVersionStatusResponse UpdateMiniAppVersionStatusResponse
     */
    public function updateMiniAppVersionStatus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateMiniAppVersionStatusHeaders([]);

        return $this->updateMiniAppVersionStatusWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 修改伙伴类型可见性
     *  *
     * @param UpdatePartnerVisibilityRequest $request UpdatePartnerVisibilityRequest
     * @param UpdatePartnerVisibilityHeaders $headers UpdatePartnerVisibilityHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdatePartnerVisibilityResponse UpdatePartnerVisibilityResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'UpdatePartnerVisibility',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/partnerDepartments/visibilityPartners',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'boolean',
        ]);

        return UpdatePartnerVisibilityResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 修改伙伴类型可见性
     *  *
     * @param UpdatePartnerVisibilityRequest $request UpdatePartnerVisibilityRequest
     *
     * @return UpdatePartnerVisibilityResponse UpdatePartnerVisibilityResponse
     */
    public function updatePartnerVisibility($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdatePartnerVisibilityHeaders([]);

        return $this->updatePartnerVisibilityWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 专属一线版-企业修改员工license
     *  *
     * @param UpdateRealmLicenseRequest $request UpdateRealmLicenseRequest
     * @param UpdateRealmLicenseHeaders $headers UpdateRealmLicenseHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateRealmLicenseResponse UpdateRealmLicenseResponse
     */
    public function updateRealmLicenseWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->detailList)) {
            $body['detailList'] = $request->detailList;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'UpdateRealmLicense',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/frontLines/licenses',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateRealmLicenseResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 专属一线版-企业修改员工license
     *  *
     * @param UpdateRealmLicenseRequest $request UpdateRealmLicenseRequest
     *
     * @return UpdateRealmLicenseResponse UpdateRealmLicenseResponse
     */
    public function updateRealmLicense($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateRealmLicenseHeaders([]);

        return $this->updateRealmLicenseWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 修改角色可见性
     *  *
     * @param UpdateRoleVisibilityRequest $request UpdateRoleVisibilityRequest
     * @param UpdateRoleVisibilityHeaders $headers UpdateRoleVisibilityHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateRoleVisibilityResponse UpdateRoleVisibilityResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'UpdateRoleVisibility',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/partnerDepartments/visibilityRoles',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'boolean',
        ]);

        return UpdateRoleVisibilityResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 修改角色可见性
     *  *
     * @param UpdateRoleVisibilityRequest $request UpdateRoleVisibilityRequest
     *
     * @return UpdateRoleVisibilityResponse UpdateRoleVisibilityResponse
     */
    public function updateRoleVisibility($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateRoleVisibilityHeaders([]);

        return $this->updateRoleVisibilityWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新组织专属存储模式
     *  *
     * @param UpdateStorageModeRequest $request UpdateStorageModeRequest
     * @param UpdateStorageModeHeaders $headers UpdateStorageModeHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateStorageModeResponse UpdateStorageModeResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'UpdateStorageMode',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/fileStorages/acrossClouds/storageModes',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateStorageModeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新组织专属存储模式
     *  *
     * @param UpdateStorageModeRequest $request UpdateStorageModeRequest
     *
     * @return UpdateStorageModeResponse UpdateStorageModeResponse
     */
    public function updateStorageMode($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateStorageModeHeaders([]);

        return $this->updateStorageModeWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 通过设备编号修改设备信息。
     *  *
     * @param string                     $deviceId
     * @param UpdateTrustedDeviceRequest $request  UpdateTrustedDeviceRequest
     * @param UpdateTrustedDeviceHeaders $headers  UpdateTrustedDeviceHeaders
     * @param RuntimeOptions             $runtime  runtime options for this request RuntimeOptions
     *
     * @return UpdateTrustedDeviceResponse UpdateTrustedDeviceResponse
     */
    public function updateTrustedDeviceWithOptions($deviceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->status)) {
            $body['status'] = $request->status;
        }
        if (!Utils::isUnset($request->title)) {
            $body['title'] = $request->title;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'UpdateTrustedDevice',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/trustedDevices/' . $deviceId . '',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateTrustedDeviceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 通过设备编号修改设备信息。
     *  *
     * @param string                     $deviceId
     * @param UpdateTrustedDeviceRequest $request  UpdateTrustedDeviceRequest
     *
     * @return UpdateTrustedDeviceResponse UpdateTrustedDeviceResponse
     */
    public function updateTrustedDevice($deviceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateTrustedDeviceHeaders([]);

        return $this->updateTrustedDeviceWithOptions($deviceId, $request, $headers, $runtime);
    }

    /**
     * @summary 允许三方调用该API，决定对应的语音消息管控状态
     *  *
     * @param UpdateVoiceMsgCtrlStatusRequest $request UpdateVoiceMsgCtrlStatusRequest
     * @param UpdateVoiceMsgCtrlStatusHeaders $headers UpdateVoiceMsgCtrlStatusHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateVoiceMsgCtrlStatusResponse UpdateVoiceMsgCtrlStatusResponse
     */
    public function updateVoiceMsgCtrlStatusWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->status)) {
            $body['status'] = $request->status;
        }
        if (!Utils::isUnset($request->voiceMsgCtrlInfo)) {
            $body['voiceMsgCtrlInfo'] = $request->voiceMsgCtrlInfo;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'UpdateVoiceMsgCtrlStatus',
            'version' => 'exclusive_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/exclusive/voiceMessages/ctrlStatuses',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateVoiceMsgCtrlStatusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 允许三方调用该API，决定对应的语音消息管控状态
     *  *
     * @param UpdateVoiceMsgCtrlStatusRequest $request UpdateVoiceMsgCtrlStatusRequest
     *
     * @return UpdateVoiceMsgCtrlStatusResponse UpdateVoiceMsgCtrlStatusResponse
     */
    public function updateVoiceMsgCtrlStatus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateVoiceMsgCtrlStatusHeaders([]);

        return $this->updateVoiceMsgCtrlStatusWithOptions($request, $headers, $runtime);
    }
}
