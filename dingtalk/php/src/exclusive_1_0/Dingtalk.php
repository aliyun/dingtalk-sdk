<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\AddOrgHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\AddOrgRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\AddOrgResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\BanOrOpenGroupWordsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\BanOrOpenGroupWordsRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\BanOrOpenGroupWordsResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetOaOperatorLogListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetOaOperatorLogListRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetOaOperatorLogListResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\PublishFileChangeNoticeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\PublishFileChangeNoticeRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\PublishFileChangeNoticeResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SaveAcrossCloudStroageConfigsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SaveAcrossCloudStroageConfigsRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SaveAcrossCloudStroageConfigsResponse;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SaveAndSubmitAuthInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SaveAndSubmitAuthInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SaveAndSubmitAuthInfoResponse;
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
use Darabonba\OpenApi\Models\OpenApiRequest;
use Darabonba\OpenApi\OpenApiClient;

class Dingtalk extends OpenApiClient
{
    public function __construct($config)
    {
        parent::__construct($config);
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
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
            @$body['mobileNum'] = $request->mobileNum;
        }
        if (!Utils::isUnset($request->name)) {
            @$body['name'] = $request->name;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return AddOrgResponse::fromMap($this->doROARequest('AddOrg', 'exclusive_1.0', 'HTTP', 'POST', 'AK', '/v1.0/exclusive/orgnizations', 'json', $req, $runtime));
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
            @$body['banWordsType'] = $request->banWordsType;
        }
        if (!Utils::isUnset($request->openConverationId)) {
            @$body['openConverationId'] = $request->openConverationId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return BanOrOpenGroupWordsResponse::fromMap($this->doROARequest('BanOrOpenGroupWords', 'exclusive_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/exclusive/enterpriseSecurities/banOrOpenGroupWords', 'json', $req, $runtime));
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
            @$body['did'] = $request->did;
        }
        if (!Utils::isUnset($request->macAddress)) {
            @$body['macAddress'] = $request->macAddress;
        }
        if (!Utils::isUnset($request->platform)) {
            @$body['platform'] = $request->platform;
        }
        if (!Utils::isUnset($request->status)) {
            @$body['status'] = $request->status;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return CreateTrustedDeviceResponse::fromMap($this->doROARequest('CreateTrustedDevice', 'exclusive_1.0', 'HTTP', 'POST', 'AK', '/v1.0/exclusive/trustedDevices', 'json', $req, $runtime));
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
            @$body['macAddressList'] = $request->macAddressList;
        }
        if (!Utils::isUnset($request->platform)) {
            @$body['platform'] = $request->platform;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return CreateTrustedDeviceBatchResponse::fromMap($this->doROARequest('CreateTrustedDeviceBatch', 'exclusive_1.0', 'HTTP', 'POST', 'AK', '/v1.0/exclusive/trusts/devices', 'json', $req, $runtime));
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
     * @param string                                 $targetCorpId
     * @param DeleteAcrossCloudStroageConfigsHeaders $headers
     * @param RuntimeOptions                         $runtime
     *
     * @return DeleteAcrossCloudStroageConfigsResponse
     */
    public function deleteAcrossCloudStroageConfigsWithOptions($targetCorpId, $headers, $runtime)
    {
        $targetCorpId = OpenApiUtilClient::getEncodeParam($targetCorpId);
        $realHeaders  = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return DeleteAcrossCloudStroageConfigsResponse::fromMap($this->doROARequest('DeleteAcrossCloudStroageConfigs', 'exclusive_1.0', 'HTTP', 'DELETE', 'AK', '/v1.0/exclusive/fileStorages/acrossClouds/configurations/' . $targetCorpId . '', 'json', $req, $runtime));
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
     * @param string               $publisherId
     * @param string               $commentId
     * @param DeleteCommentHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return DeleteCommentResponse
     */
    public function deleteCommentWithOptions($publisherId, $commentId, $headers, $runtime)
    {
        $publisherId = OpenApiUtilClient::getEncodeParam($publisherId);
        $commentId   = OpenApiUtilClient::getEncodeParam($commentId);
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return DeleteCommentResponse::fromMap($this->doROARequest('DeleteComment', 'exclusive_1.0', 'HTTP', 'DELETE', 'AK', '/v1.0/exclusive/publishers/' . $publisherId . '/comments/' . $commentId . '', 'boolean', $req, $runtime));
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
            @$body['kickOff'] = $request->kickOff;
        }
        if (!Utils::isUnset($request->macAddress)) {
            @$body['macAddress'] = $request->macAddress;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return DeleteTrustedDeviceResponse::fromMap($this->doROARequest('DeleteTrustedDevice', 'exclusive_1.0', 'HTTP', 'POST', 'AK', '/v1.0/exclusive/trustedDevices/remove', 'json', $req, $runtime));
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
            @$body['appId'] = $request->appId;
        }
        if (!Utils::isUnset($request->deptId)) {
            @$body['deptId'] = $request->deptId;
        }
        if (!Utils::isUnset($request->subCorpId)) {
            @$body['subCorpId'] = $request->subCorpId;
        }
        if (!Utils::isUnset($request->type)) {
            @$body['type'] = $request->type;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return DistributePartnerAppResponse::fromMap($this->doROARequest('DistributePartnerApp', 'exclusive_1.0', 'HTTP', 'POST', 'AK', '/v1.0/exclusive/partners/applications/distribute', 'json', $req, $runtime));
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
            @$body['dingPortalName'] = $request->dingPortalName;
        }
        if (!Utils::isUnset($request->targetCorpId)) {
            @$body['targetCorpId'] = $request->targetCorpId;
        }
        if (!Utils::isUnset($request->templateAppUuid)) {
            @$body['templateAppUuid'] = $request->templateAppUuid;
        }
        if (!Utils::isUnset($request->templateCorpId)) {
            @$body['templateCorpId'] = $request->templateCorpId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return ExclusiveCreateDingPortalResponse::fromMap($this->doROARequest('ExclusiveCreateDingPortal', 'exclusive_1.0', 'HTTP', 'POST', 'AK', '/v1.0/exclusive/workbenches/templates/spread', 'json', $req, $runtime));
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
            @$body['accessKeyId'] = $request->accessKeyId;
        }
        if (!Utils::isUnset($request->accessKeySecret)) {
            @$body['accessKeySecret'] = $request->accessKeySecret;
        }
        if (!Utils::isUnset($request->oss)) {
            @$body['oss'] = $request->oss;
        }
        if (!Utils::isUnset($request->targetCorpId)) {
            @$body['targetCorpId'] = $request->targetCorpId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return FileStorageActiveStorageResponse::fromMap($this->doROARequest('FileStorageActiveStorage', 'exclusive_1.0', 'HTTP', 'POST', 'AK', '/v1.0/exclusive/fileStorages/active', 'json', $req, $runtime));
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
            @$body['accessKeyId'] = $request->accessKeyId;
        }
        if (!Utils::isUnset($request->accessKeySecret)) {
            @$body['accessKeySecret'] = $request->accessKeySecret;
        }
        if (!Utils::isUnset($request->oss)) {
            @$body['oss'] = $request->oss;
        }
        if (!Utils::isUnset($request->targetCorpId)) {
            @$body['targetCorpId'] = $request->targetCorpId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return FileStorageCheckConnectionResponse::fromMap($this->doROARequest('FileStorageCheckConnection', 'exclusive_1.0', 'HTTP', 'POST', 'AK', '/v1.0/exclusive/fileStorages/connections/check', 'json', $req, $runtime));
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
            @$query['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->startTime)) {
            @$query['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->targetCorpId)) {
            @$query['targetCorpId'] = $request->targetCorpId;
        }
        if (!Utils::isUnset($request->type)) {
            @$query['type'] = $request->type;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return FileStorageGetQuotaDataResponse::fromMap($this->doROARequest('FileStorageGetQuotaData', 'exclusive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/exclusive/fileStorages/quotaDatas', 'json', $req, $runtime));
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
            @$query['targetCorpId'] = $request->targetCorpId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return FileStorageGetStorageStateResponse::fromMap($this->doROARequest('FileStorageGetStorageState', 'exclusive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/exclusive/fileStorages/states', 'json', $req, $runtime));
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
            @$body['accessKeyId'] = $request->accessKeyId;
        }
        if (!Utils::isUnset($request->accessKeySecret)) {
            @$body['accessKeySecret'] = $request->accessKeySecret;
        }
        if (!Utils::isUnset($request->targetCorpId)) {
            @$body['targetCorpId'] = $request->targetCorpId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return FileStorageUpdateStorageResponse::fromMap($this->doROARequest('FileStorageUpdateStorage', 'exclusive_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/exclusive/fileStorages/configurations', 'json', $req, $runtime));
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
            @$body['userIdList'] = $request->userIdList;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return GenerateDarkWaterMarkResponse::fromMap($this->doROARequest('GenerateDarkWaterMark', 'exclusive_1.0', 'HTTP', 'POST', 'AK', '/v1.0/exclusive/enterpriseSecurities/darkWatermarks/generate', 'json', $req, $runtime));
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
            @$query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->status)) {
            @$query['status'] = $request->status;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetAccountTransferListResponse::fromMap($this->doROARequest('GetAccountTransferList', 'exclusive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/exclusive/dataTransfer/accounts', 'json', $req, $runtime));
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
     * @param string                      $dataId
     * @param GetActiveUserSummaryHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return GetActiveUserSummaryResponse
     */
    public function getActiveUserSummaryWithOptions($dataId, $headers, $runtime)
    {
        $dataId      = OpenApiUtilClient::getEncodeParam($dataId);
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return GetActiveUserSummaryResponse::fromMap($this->doROARequest('GetActiveUserSummary', 'exclusive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/exclusive/data/dau/org/' . $dataId . '', 'json', $req, $runtime));
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
            @$query['appId'] = $request->appId;
        }
        if (!Utils::isUnset($request->targetCorpId)) {
            @$query['targetCorpId'] = $request->targetCorpId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetAgentIdByRelatedAppIdResponse::fromMap($this->doROARequest('GetAgentIdByRelatedAppId', 'exclusive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/exclusive/exclusiveDesigns/agentId', 'json', $req, $runtime));
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
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return GetAllLabelableDeptsResponse::fromMap($this->doROARequest('GetAllLabelableDepts', 'exclusive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/exclusive/partnerDepartments', 'json', $req, $runtime));
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
            @$query['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->startTime)) {
            @$query['startTime'] = $request->startTime;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetAppDispatchInfoResponse::fromMap($this->doROARequest('GetAppDispatchInfo', 'exclusive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/exclusive/apps/distributionInfos', 'json', $req, $runtime));
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
     * @param string                    $dataId
     * @param GetCalenderSummaryHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return GetCalenderSummaryResponse
     */
    public function getCalenderSummaryWithOptions($dataId, $headers, $runtime)
    {
        $dataId      = OpenApiUtilClient::getEncodeParam($dataId);
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return GetCalenderSummaryResponse::fromMap($this->doROARequest('GetCalenderSummary', 'exclusive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/exclusive/data/calendar/org/' . $dataId . '', 'json', $req, $runtime));
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
        $publisherId = OpenApiUtilClient::getEncodeParam($publisherId);
        $query       = [];
        if (!Utils::isUnset($request->pageNumber)) {
            @$query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetCommentListResponse::fromMap($this->doROARequest('GetCommentList', 'exclusive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/exclusive/publishers/' . $publisherId . '/comments/list', 'json', $req, $runtime));
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
            @$query['logicalConferenceId'] = $request->logicalConferenceId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetConfBaseInfoByLogicalIdResponse::fromMap($this->doROARequest('GetConfBaseInfoByLogicalId', 'exclusive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/exclusive/data/conferences', 'json', $req, $runtime));
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
     * @param string                     $conferenceId
     * @param GetConferenceDetailHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return GetConferenceDetailResponse
     */
    public function getConferenceDetailWithOptions($conferenceId, $headers, $runtime)
    {
        $conferenceId = OpenApiUtilClient::getEncodeParam($conferenceId);
        $realHeaders  = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return GetConferenceDetailResponse::fromMap($this->doROARequest('GetConferenceDetail', 'exclusive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/exclusive/data/conferences/' . $conferenceId . '', 'json', $req, $runtime));
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
        $dataId = OpenApiUtilClient::getEncodeParam($dataId);
        $query  = [];
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetDingReportDeptSummaryResponse::fromMap($this->doROARequest('GetDingReportDeptSummary', 'exclusive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/exclusive/data/report/dept/' . $dataId . '', 'json', $req, $runtime));
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
     * @param string                      $dataId
     * @param GetDingReportSummaryHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return GetDingReportSummaryResponse
     */
    public function getDingReportSummaryWithOptions($dataId, $headers, $runtime)
    {
        $dataId      = OpenApiUtilClient::getEncodeParam($dataId);
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return GetDingReportSummaryResponse::fromMap($this->doROARequest('GetDingReportSummary', 'exclusive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/exclusive/datas/' . $dataId . '/reports/organizations', 'json', $req, $runtime));
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
        $dataId = OpenApiUtilClient::getEncodeParam($dataId);
        $query  = [];
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetDocCreatedDeptSummaryResponse::fromMap($this->doROARequest('GetDocCreatedDeptSummary', 'exclusive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/exclusive/data/doc/dept/' . $dataId . '', 'json', $req, $runtime));
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
     * @param string                      $dataId
     * @param GetDocCreatedSummaryHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return GetDocCreatedSummaryResponse
     */
    public function getDocCreatedSummaryWithOptions($dataId, $headers, $runtime)
    {
        $dataId      = OpenApiUtilClient::getEncodeParam($dataId);
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return GetDocCreatedSummaryResponse::fromMap($this->doROARequest('GetDocCreatedSummary', 'exclusive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/exclusive/data/doc/org/' . $dataId . '', 'json', $req, $runtime));
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
            @$query['unionId'] = $request->unionId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetExclusiveAccountAllOrgListResponse::fromMap($this->doROARequest('GetExclusiveAccountAllOrgList', 'exclusive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/exclusive/exclusiveAccounts/organizations', 'json', $req, $runtime));
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
        $dataId = OpenApiUtilClient::getEncodeParam($dataId);
        $query  = [];
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetGeneralFormCreatedDeptSummaryResponse::fromMap($this->doROARequest('GetGeneralFormCreatedDeptSummary', 'exclusive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/exclusive/data/generalForm/dept/' . $dataId . '', 'json', $req, $runtime));
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
     * @param string                              $dataId
     * @param GetGeneralFormCreatedSummaryHeaders $headers
     * @param RuntimeOptions                      $runtime
     *
     * @return GetGeneralFormCreatedSummaryResponse
     */
    public function getGeneralFormCreatedSummaryWithOptions($dataId, $headers, $runtime)
    {
        $dataId      = OpenApiUtilClient::getEncodeParam($dataId);
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return GetGeneralFormCreatedSummaryResponse::fromMap($this->doROARequest('GetGeneralFormCreatedSummary', 'exclusive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/exclusive/data/generalForm/org/' . $dataId . '', 'json', $req, $runtime));
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
            @$query['dingGroupId'] = $request->dingGroupId;
        }
        if (!Utils::isUnset($request->groupType)) {
            @$query['groupType'] = $request->groupType;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            @$query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->statDate)) {
            @$query['statDate'] = $request->statDate;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetGroupActiveInfoResponse::fromMap($this->doROARequest('GetGroupActiveInfo', 'exclusive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/exclusive/data/activeGroups', 'json', $req, $runtime));
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
            @$body['deptIds'] = $request->deptIds;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            @$body['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->statDate)) {
            @$body['statDate'] = $request->statDate;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return GetInActiveUserListResponse::fromMap($this->doROARequest('GetInActiveUserList', 'exclusive_1.0', 'HTTP', 'POST', 'AK', '/v1.0/exclusive/inactives/users/query', 'json', $req, $runtime));
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
            @$query['targetCorpId'] = $request->targetCorpId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetLastOrgAuthDataResponse::fromMap($this->doROARequest('GetLastOrgAuthData', 'exclusive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/exclusive/organizations/authInfos', 'json', $req, $runtime));
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
            @$body['categoryList'] = $request->categoryList;
        }
        if (!Utils::isUnset($request->endTime)) {
            @$body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->opUserId)) {
            @$body['opUserId'] = $request->opUserId;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            @$body['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->startTime)) {
            @$body['startTime'] = $request->startTime;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return GetOaOperatorLogListResponse::fromMap($this->doROARequest('GetOaOperatorLogList', 'exclusive_1.0', 'HTTP', 'POST', 'AK', '/v1.0/exclusive/oaOperatorLogs/query', 'json', $req, $runtime));
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
     * @param string                          $parentId
     * @param GetPartnerTypeByParentIdHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return GetPartnerTypeByParentIdResponse
     */
    public function getPartnerTypeByParentIdWithOptions($parentId, $headers, $runtime)
    {
        $parentId    = OpenApiUtilClient::getEncodeParam($parentId);
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return GetPartnerTypeByParentIdResponse::fromMap($this->doROARequest('GetPartnerTypeByParentId', 'exclusive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/exclusive/partnerLabels/' . $parentId . '', 'json', $req, $runtime));
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
            @$query['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->macAddress)) {
            @$query['macAddress'] = $request->macAddress;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            @$query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->platform)) {
            @$query['platform'] = $request->platform;
        }
        if (!Utils::isUnset($request->startTime)) {
            @$query['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->title)) {
            @$query['title'] = $request->title;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetPublicDevicesResponse::fromMap($this->doROARequest('GetPublicDevices', 'exclusive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/exclusive/trusts/publicDevices', 'json', $req, $runtime));
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
        $dataId = OpenApiUtilClient::getEncodeParam($dataId);
        $query  = [];
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetPublisherSummaryResponse::fromMap($this->doROARequest('GetPublisherSummary', 'exclusive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/exclusive/data/publisher/' . $dataId . '', 'json', $req, $runtime));
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
            @$body['agentId'] = $request->agentId;
        }
        if (!Utils::isUnset($request->fromTime)) {
            @$body['fromTime'] = $request->fromTime;
        }
        if (!Utils::isUnset($request->maxResults)) {
            @$body['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$body['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->personIdentification)) {
            @$body['personIdentification'] = $request->personIdentification;
        }
        if (!Utils::isUnset($request->scene)) {
            @$body['scene'] = $request->scene;
        }
        if (!Utils::isUnset($request->toTime)) {
            @$body['toTime'] = $request->toTime;
        }
        if (!Utils::isUnset($request->userIds)) {
            @$body['userIds'] = $request->userIds;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return GetRealPeopleRecordsResponse::fromMap($this->doROARequest('GetRealPeopleRecords', 'exclusive_1.0', 'HTTP', 'POST', 'AK', '/v1.0/exclusive/persons/identificationRecords/query', 'json', $req, $runtime));
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
            @$body['agentId'] = $request->agentId;
        }
        if (!Utils::isUnset($request->faceCompareResult)) {
            @$body['faceCompareResult'] = $request->faceCompareResult;
        }
        if (!Utils::isUnset($request->fromTime)) {
            @$body['fromTime'] = $request->fromTime;
        }
        if (!Utils::isUnset($request->maxResults)) {
            @$body['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$body['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->toTime)) {
            @$body['toTime'] = $request->toTime;
        }
        if (!Utils::isUnset($request->userIds)) {
            @$body['userIds'] = $request->userIds;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return GetRecognizeRecordsResponse::fromMap($this->doROARequest('GetRecognizeRecords', 'exclusive_1.0', 'HTTP', 'POST', 'AK', '/v1.0/exclusive/faces/recognizeRecords/query', 'json', $req, $runtime));
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
            @$query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->signStatus)) {
            @$query['signStatus'] = $request->signStatus;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetSignedDetailByPageResponse::fromMap($this->doROARequest('GetSignedDetailByPage', 'exclusive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/exclusive/audits/users', 'json', $req, $runtime));
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
            @$body['userIds'] = $request->userIds;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return GetTrustDeviceListResponse::fromMap($this->doROARequest('GetTrustDeviceList', 'exclusive_1.0', 'HTTP', 'POST', 'AK', '/v1.0/exclusive/trustedDevices/query', 'json', $req, $runtime));
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
        $dataId = OpenApiUtilClient::getEncodeParam($dataId);
        $query  = [];
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetUserAppVersionSummaryResponse::fromMap($this->doROARequest('GetUserAppVersionSummary', 'exclusive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/exclusive/data/appVersion/org/' . $dataId . '', 'json', $req, $runtime));
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
            @$body['userIds'] = $request->userIds;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return GetUserFaceStateResponse::fromMap($this->doROARequest('GetUserFaceState', 'exclusive_1.0', 'HTTP', 'POST', 'AK', '/v1.0/exclusive/faces/recognizeStates/query', 'json', $req, $runtime));
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
            @$body['userIds'] = $request->userIds;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return GetUserRealPeopleStateResponse::fromMap($this->doROARequest('GetUserRealPeopleState', 'exclusive_1.0', 'HTTP', 'POST', 'AK', '/v1.0/exclusive/persons/identificationStates/query', 'json', $req, $runtime));
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
            @$query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->statDate)) {
            @$query['statDate'] = $request->statDate;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetUserStayLengthResponse::fromMap($this->doROARequest('GetUserStayLength', 'exclusive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/exclusive/data/users/stayTimes', 'json', $req, $runtime));
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
            @$query['endDate'] = $request->endDate;
        }
        if (!Utils::isUnset($request->nextBizId)) {
            @$query['nextBizId'] = $request->nextBizId;
        }
        if (!Utils::isUnset($request->nextGmtCreate)) {
            @$query['nextGmtCreate'] = $request->nextGmtCreate;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->startDate)) {
            @$query['startDate'] = $request->startDate;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return ListAuditLogResponse::fromMap($this->doROARequest('ListAuditLog', 'exclusive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/exclusive/fileAuditLogs', 'json', $req, $runtime));
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
            @$query['mobile'] = $request->mobile;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return ListJoinOrgInfoResponse::fromMap($this->doROARequest('ListJoinOrgInfo', 'exclusive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/exclusive/exclusiveAccounts/organizations/infos', 'json', $req, $runtime));
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
            @$body['miniAppId'] = $request->miniAppId;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            @$body['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->versionTypeSet)) {
            @$body['versionTypeSet'] = $request->versionTypeSet;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return ListMiniAppAvailableVersionResponse::fromMap($this->doROARequest('ListMiniAppAvailableVersion', 'exclusive_1.0', 'HTTP', 'POST', 'AK', '/v1.0/exclusive/miniApps/versions/availableLists', 'json', $req, $runtime));
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
            @$query['miniAppId'] = $request->miniAppId;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            @$query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return ListMiniAppHistoryVersionResponse::fromMap($this->doROARequest('ListMiniAppHistoryVersion', 'exclusive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/exclusive/miniApps/versions/historyLists', 'json', $req, $runtime));
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
     * @param string                  $parentId
     * @param ListPartnerRolesHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return ListPartnerRolesResponse
     */
    public function listPartnerRolesWithOptions($parentId, $headers, $runtime)
    {
        $parentId    = OpenApiUtilClient::getEncodeParam($parentId);
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return ListPartnerRolesResponse::fromMap($this->doROARequest('ListPartnerRoles', 'exclusive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/exclusive/partners/roles/' . $parentId . '', 'json', $req, $runtime));
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
            @$body['bizInstanceId'] = $request->bizInstanceId;
        }
        if (!Utils::isUnset($request->maxResults)) {
            @$body['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$body['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->scheduleDateEnd)) {
            @$body['scheduleDateEnd'] = $request->scheduleDateEnd;
        }
        if (!Utils::isUnset($request->scheduleDateStart)) {
            @$body['scheduleDateStart'] = $request->scheduleDateStart;
        }
        if (!Utils::isUnset($request->userIdList)) {
            @$body['userIdList'] = $request->userIdList;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return ListPunchScheduleByConditionWithPagingResponse::fromMap($this->doROARequest('ListPunchScheduleByConditionWithPaging', 'exclusive_1.0', 'HTTP', 'POST', 'AK', '/v1.0/exclusive/punchSchedules/query', 'json', $req, $runtime));
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
            @$body['fileId'] = $request->fileId;
        }
        if (!Utils::isUnset($request->operateType)) {
            @$body['operateType'] = $request->operateType;
        }
        if (!Utils::isUnset($request->operatorUnionId)) {
            @$body['operatorUnionId'] = $request->operatorUnionId;
        }
        if (!Utils::isUnset($request->spaceId)) {
            @$body['spaceId'] = $request->spaceId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return PublishFileChangeNoticeResponse::fromMap($this->doROARequest('PublishFileChangeNotice', 'exclusive_1.0', 'HTTP', 'POST', 'AK', '/v1.0/exclusive/comments/send', 'none', $req, $runtime));
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
            @$body['agentId'] = $request->agentId;
        }
        if (!Utils::isUnset($request->badgeItems)) {
            @$body['badgeItems'] = $request->badgeItems;
        }
        if (!Utils::isUnset($request->pushType)) {
            @$body['pushType'] = $request->pushType;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return PushBadgeResponse::fromMap($this->doROARequest('PushBadge', 'exclusive_1.0', 'HTTP', 'POST', 'AK', '/v1.0/exclusive/exclusiveDesigns/redPoints/push', 'json', $req, $runtime));
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
            @$query['targetCloudType'] = $request->targetCloudType;
        }
        if (!Utils::isUnset($request->targetCorpId)) {
            @$query['targetCorpId'] = $request->targetCorpId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return QueryAcrossCloudStroageConfigsResponse::fromMap($this->doROARequest('QueryAcrossCloudStroageConfigs', 'exclusive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/exclusive/fileStorages/acrossClouds/configurations', 'json', $req, $runtime));
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
     * @param string                  $userId
     * @param QueryPartnerInfoHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return QueryPartnerInfoResponse
     */
    public function queryPartnerInfoWithOptions($userId, $headers, $runtime)
    {
        $userId      = OpenApiUtilClient::getEncodeParam($userId);
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return QueryPartnerInfoResponse::fromMap($this->doROARequest('QueryPartnerInfo', 'exclusive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/exclusive/partners/users/' . $userId . '', 'json', $req, $runtime));
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
            @$body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            @$body['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->platform)) {
            @$body['platform'] = $request->platform;
        }
        if (!Utils::isUnset($request->startTime)) {
            @$body['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->type)) {
            @$body['type'] = $request->type;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return QueryUserBehaviorResponse::fromMap($this->doROARequest('QueryUserBehavior', 'exclusive_1.0', 'HTTP', 'POST', 'AK', '/v1.0/exclusive/enterpriseSecurities/userBehaviors/screenshots/query', 'json', $req, $runtime));
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
            @$body['miniAppId'] = $request->miniAppId;
        }
        if (!Utils::isUnset($request->rollbackVersion)) {
            @$body['rollbackVersion'] = $request->rollbackVersion;
        }
        if (!Utils::isUnset($request->targetVersion)) {
            @$body['targetVersion'] = $request->targetVersion;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return RollbackMiniAppVersionResponse::fromMap($this->doROARequest('RollbackMiniAppVersion', 'exclusive_1.0', 'HTTP', 'POST', 'AK', '/v1.0/exclusive/miniApps/versions/rollback', 'json', $req, $runtime));
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
            @$body['accessKeyId'] = $request->accessKeyId;
        }
        if (!Utils::isUnset($request->accessKeySecret)) {
            @$body['accessKeySecret'] = $request->accessKeySecret;
        }
        if (!Utils::isUnset($request->bucketName)) {
            @$body['bucketName'] = $request->bucketName;
        }
        if (!Utils::isUnset($request->cloudType)) {
            @$body['cloudType'] = $request->cloudType;
        }
        if (!Utils::isUnset($request->endpoint)) {
            @$body['endpoint'] = $request->endpoint;
        }
        if (!Utils::isUnset($request->targetCorpId)) {
            @$body['targetCorpId'] = $request->targetCorpId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return SaveAcrossCloudStroageConfigsResponse::fromMap($this->doROARequest('SaveAcrossCloudStroageConfigs', 'exclusive_1.0', 'HTTP', 'POST', 'AK', '/v1.0/exclusive/fileStorages/acrossClouds/configurations', 'json', $req, $runtime));
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
            @$body['applyRemark'] = $request->applyRemark;
        }
        if (!Utils::isUnset($request->authorizeMediaId)) {
            @$body['authorizeMediaId'] = $request->authorizeMediaId;
        }
        if (!Utils::isUnset($request->industry)) {
            @$body['industry'] = $request->industry;
        }
        if (!Utils::isUnset($request->legalPerson)) {
            @$body['legalPerson'] = $request->legalPerson;
        }
        if (!Utils::isUnset($request->legalPersonIdCard)) {
            @$body['legalPersonIdCard'] = $request->legalPersonIdCard;
        }
        if (!Utils::isUnset($request->licenseMediaId)) {
            @$body['licenseMediaId'] = $request->licenseMediaId;
        }
        if (!Utils::isUnset($request->locCity)) {
            @$body['locCity'] = $request->locCity;
        }
        if (!Utils::isUnset($request->locCityName)) {
            @$body['locCityName'] = $request->locCityName;
        }
        if (!Utils::isUnset($request->locProvince)) {
            @$body['locProvince'] = $request->locProvince;
        }
        if (!Utils::isUnset($request->locProvinceName)) {
            @$body['locProvinceName'] = $request->locProvinceName;
        }
        if (!Utils::isUnset($request->mobileNum)) {
            @$body['mobileNum'] = $request->mobileNum;
        }
        if (!Utils::isUnset($request->orgName)) {
            @$body['orgName'] = $request->orgName;
        }
        if (!Utils::isUnset($request->organizationCode)) {
            @$body['organizationCode'] = $request->organizationCode;
        }
        if (!Utils::isUnset($request->organizationCodeMediaId)) {
            @$body['organizationCodeMediaId'] = $request->organizationCodeMediaId;
        }
        if (!Utils::isUnset($request->registLocation)) {
            @$body['registLocation'] = $request->registLocation;
        }
        if (!Utils::isUnset($request->registNum)) {
            @$body['registNum'] = $request->registNum;
        }
        if (!Utils::isUnset($request->targetCorpId)) {
            @$body['targetCorpId'] = $request->targetCorpId;
        }
        if (!Utils::isUnset($request->unifiedSocialCredit)) {
            @$body['unifiedSocialCredit'] = $request->unifiedSocialCredit;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return SaveAndSubmitAuthInfoResponse::fromMap($this->doROARequest('SaveAndSubmitAuthInfo', 'exclusive_1.0', 'HTTP', 'POST', 'AK', '/v1.0/exclusive/ognizations/authInfos/saveAndSubmit', 'json', $req, $runtime));
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
            @$query['createTimeEnd'] = $request->createTimeEnd;
        }
        if (!Utils::isUnset($request->createTimeStart)) {
            @$query['createTimeStart'] = $request->createTimeStart;
        }
        if (!Utils::isUnset($request->groupMembersCountEnd)) {
            @$query['groupMembersCountEnd'] = $request->groupMembersCountEnd;
        }
        if (!Utils::isUnset($request->groupMembersCountStart)) {
            @$query['groupMembersCountStart'] = $request->groupMembersCountStart;
        }
        if (!Utils::isUnset($request->groupName)) {
            @$query['groupName'] = $request->groupName;
        }
        if (!Utils::isUnset($request->groupOwner)) {
            @$query['groupOwner'] = $request->groupOwner;
        }
        if (!Utils::isUnset($request->lastActiveTimeEnd)) {
            @$query['lastActiveTimeEnd'] = $request->lastActiveTimeEnd;
        }
        if (!Utils::isUnset($request->lastActiveTimeStart)) {
            @$query['lastActiveTimeStart'] = $request->lastActiveTimeStart;
        }
        if (!Utils::isUnset($request->operatorUserId)) {
            @$query['operatorUserId'] = $request->operatorUserId;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->pageStart)) {
            @$query['pageStart'] = $request->pageStart;
        }
        if (!Utils::isUnset($request->syncToDingpan)) {
            @$query['syncToDingpan'] = $request->syncToDingpan;
        }
        if (!Utils::isUnset($request->uuid)) {
            @$query['uuid'] = $request->uuid;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return SearchOrgInnerGroupInfoResponse::fromMap($this->doROARequest('SearchOrgInnerGroupInfo', 'exclusive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/exclusive/securities/orgGroupInfos', 'json', $req, $runtime));
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
            @$body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->userids)) {
            @$body['userids'] = $request->userids;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return SendAppDingResponse::fromMap($this->doROARequest('SendAppDing', 'exclusive_1.0', 'HTTP', 'POST', 'AK', '/v1.0/exclusive/appDings/send', 'none', $req, $runtime));
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
            @$body['deptId'] = $request->deptId;
        }
        if (!Utils::isUnset($request->orgAlias)) {
            @$body['orgAlias'] = $request->orgAlias;
        }
        if (!Utils::isUnset($request->partnerLabelId)) {
            @$body['partnerLabelId'] = $request->partnerLabelId;
        }
        if (!Utils::isUnset($request->partnerNum)) {
            @$body['partnerNum'] = $request->partnerNum;
        }
        if (!Utils::isUnset($request->phone)) {
            @$body['phone'] = $request->phone;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return SendInvitationResponse::fromMap($this->doROARequest('SendInvitation', 'exclusive_1.0', 'HTTP', 'POST', 'AK', '/v1.0/exclusive/partnerDepartments/invitations/send', 'none', $req, $runtime));
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
            @$body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->userids)) {
            @$body['userids'] = $request->userids;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return SendPhoneDingResponse::fromMap($this->doROARequest('SendPhoneDing', 'exclusive_1.0', 'HTTP', 'POST', 'AK', '/v1.0/exclusive/phoneDings/send', 'json', $req, $runtime));
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
            @$body['deptId'] = $request->deptId;
        }
        if (!Utils::isUnset($request->labelIds)) {
            @$body['labelIds'] = $request->labelIds;
        }
        if (!Utils::isUnset($request->partnerNum)) {
            @$body['partnerNum'] = $request->partnerNum;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return SetDeptPartnerTypeAndNumResponse::fromMap($this->doROARequest('SetDeptPartnerTypeAndNum', 'exclusive_1.0', 'HTTP', 'POST', 'AK', '/v1.0/exclusive/partnerDepartments', 'none', $req, $runtime));
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
            @$body['requestIds'] = $request->requestIds;
        }
        if (!Utils::isUnset($request->status)) {
            @$body['status'] = $request->status;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return UpdateFileStatusResponse::fromMap($this->doROARequest('UpdateFileStatus', 'exclusive_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/exclusive/sending/files/status', 'json', $req, $runtime));
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
            @$body['miniAppId'] = $request->miniAppId;
        }
        if (!Utils::isUnset($request->version)) {
            @$body['version'] = $request->version;
        }
        if (!Utils::isUnset($request->versionType)) {
            @$body['versionType'] = $request->versionType;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return UpdateMiniAppVersionStatusResponse::fromMap($this->doROARequest('UpdateMiniAppVersionStatus', 'exclusive_1.0', 'HTTP', 'POST', 'AK', '/v1.0/exclusive/miniApps/versions/versionStatus', 'json', $req, $runtime));
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
            @$body['deptIds'] = $request->deptIds;
        }
        if (!Utils::isUnset($request->labelId)) {
            @$body['labelId'] = $request->labelId;
        }
        if (!Utils::isUnset($request->userIds)) {
            @$body['userIds'] = $request->userIds;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return UpdatePartnerVisibilityResponse::fromMap($this->doROARequest('UpdatePartnerVisibility', 'exclusive_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/exclusive/partnerDepartments/visibilityPartners', 'boolean', $req, $runtime));
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
            @$body['deptIds'] = $request->deptIds;
        }
        if (!Utils::isUnset($request->labelId)) {
            @$body['labelId'] = $request->labelId;
        }
        if (!Utils::isUnset($request->userIds)) {
            @$body['userIds'] = $request->userIds;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return UpdateRoleVisibilityResponse::fromMap($this->doROARequest('UpdateRoleVisibility', 'exclusive_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/exclusive/partnerDepartments/visibilityRoles', 'boolean', $req, $runtime));
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
            @$body['fileStorageMode'] = $request->fileStorageMode;
        }
        if (!Utils::isUnset($request->targetCorpId)) {
            @$body['targetCorpId'] = $request->targetCorpId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return UpdateStorageModeResponse::fromMap($this->doROARequest('UpdateStorageMode', 'exclusive_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/exclusive/fileStorages/acrossClouds/storageModes', 'json', $req, $runtime));
    }
}
