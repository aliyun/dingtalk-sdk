<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\AddContactHideBySceneSettingHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\AddContactHideBySceneSettingRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\AddContactHideBySceneSettingResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\AddEmpAttributeHideBySceneSettingHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\AddEmpAttributeHideBySceneSettingRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\AddEmpAttributeHideBySceneSettingResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\AnnualCertificationAuditHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\AnnualCertificationAuditRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\AnnualCertificationAuditResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\BatchApproveUnionApplyHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\BatchApproveUnionApplyRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\BatchApproveUnionApplyResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ChangeMainAdminHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ChangeMainAdminRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ChangeMainAdminResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\CreateCooperateOrgHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\CreateCooperateOrgRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\CreateCooperateOrgResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\CreateManagementGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\CreateManagementGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\CreateManagementGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\CreateSecondaryManagementGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\CreateSecondaryManagementGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\CreateSecondaryManagementGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\DeleteContactHideBySceneSettingHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\DeleteContactHideBySceneSettingResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\DeleteContactHideSettingHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\DeleteContactHideSettingResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\DeleteContactRestrictSettingHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\DeleteContactRestrictSettingResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\DeleteEmpAttributeHideBySceneSettingHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\DeleteEmpAttributeHideBySceneSettingResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\DeleteEmpAttributeVisibilityHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\DeleteEmpAttributeVisibilityResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\DeleteManagementGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\DeleteManagementGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetApplyInviteInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetApplyInviteInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetApplyInviteInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetBranchAuthDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetBranchAuthDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetBranchAuthDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetCardInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetCardInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetCardInUserHolderHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetCardInUserHolderResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetContactHideBySceneSettingHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetContactHideBySceneSettingResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetCooperateOrgInviteInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetCooperateOrgInviteInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetCorpCardStyleListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetCorpCardStyleListResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetDingIdByMigrationDingIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetDingIdByMigrationDingIdRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetDingIdByMigrationDingIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetEmpAttributeHideBySceneSettingHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetEmpAttributeHideBySceneSettingResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetLatestDingIndexHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetLatestDingIndexResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetMigrationDingIdByDingIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetMigrationDingIdByDingIdRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetMigrationDingIdByDingIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetMigrationUnionIdByUnionIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetMigrationUnionIdByUnionIdRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetMigrationUnionIdByUnionIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetOrgAuthInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetOrgAuthInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetOrgAuthInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetTranslateFileJobResultHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetTranslateFileJobResultRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetTranslateFileJobResultResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetUnionIdByMigrationUnionIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetUnionIdByMigrationUnionIdRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetUnionIdByMigrationUnionIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetUserCardHolderListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetUserCardHolderListRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetUserCardHolderListResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetUserHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetUserResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\IsFriendHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\IsFriendRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\IsFriendResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\IsvCardEventPushHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\IsvCardEventPushRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\IsvCardEventPushResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListBasicRoleInPageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListBasicRoleInPageRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListBasicRoleInPageResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListContactHideSettingsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListContactHideSettingsRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListContactHideSettingsResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListContactRestrictSettingHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListContactRestrictSettingRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListContactRestrictSettingResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListEmpAttributeVisibilityHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListEmpAttributeVisibilityRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListEmpAttributeVisibilityResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListEmpLeaveRecordsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListEmpLeaveRecordsRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListEmpLeaveRecordsResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListManagementGroupsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListManagementGroupsRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListManagementGroupsResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListOwnedOrgByStaffIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListOwnedOrgByStaffIdRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListOwnedOrgByStaffIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListSeniorSettingsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListSeniorSettingsRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListSeniorSettingsResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\MultiOrgPermissionGrantHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\MultiOrgPermissionGrantRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\MultiOrgPermissionGrantResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\QueryCardVisitorStatisticDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\QueryCardVisitorStatisticDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\QueryCardVisitorStatisticDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\QueryCorpStatisticDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\QueryCorpStatisticDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\QueryCorpStatisticDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\QueryCorpUserStatisticHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\QueryCorpUserStatisticRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\QueryCorpUserStatisticResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\QueryResourceManagementMembersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\QueryResourceManagementMembersResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\QueryStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\QueryStatusRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\QueryStatusResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\QueryUserManagementResourcesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\QueryUserManagementResourcesResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\QueryVerifyResultHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\QueryVerifyResultRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\QueryVerifyResultResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\SearchDepartmentHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\SearchDepartmentRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\SearchDepartmentResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\SearchUserHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\SearchUserRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\SearchUserResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\SeparateBranchOrgHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\SeparateBranchOrgRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\SeparateBranchOrgResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\SetDisableHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\SetDisableRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\SetDisableResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\SetEnableHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\SetEnableRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\SetEnableResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\SignOutHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\SignOutRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\SignOutResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\SortUserHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\SortUserRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\SortUserResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\TransformToExclusiveAccountHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\TransformToExclusiveAccountRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\TransformToExclusiveAccountResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\TranslateFileHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\TranslateFileRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\TranslateFileResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\UniqueQueryUserCardHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\UniqueQueryUserCardRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\UniqueQueryUserCardResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\UpdateBranchAttributesInCooperateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\UpdateBranchAttributesInCooperateRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\UpdateBranchAttributesInCooperateResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\UpdateBranchVisibleSettingInCooperateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\UpdateBranchVisibleSettingInCooperateRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\UpdateBranchVisibleSettingInCooperateResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\UpdateContactHideBySceneSettingHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\UpdateContactHideBySceneSettingRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\UpdateContactHideBySceneSettingResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\UpdateContactHideSettingHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\UpdateContactHideSettingRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\UpdateContactHideSettingResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\UpdateContactRestrictSettingHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\UpdateContactRestrictSettingRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\UpdateContactRestrictSettingResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\UpdateDeptSettngTailFirstHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\UpdateDeptSettngTailFirstRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\UpdateDeptSettngTailFirstResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\UpdateEmpAttrbuteVisibilitySettingHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\UpdateEmpAttrbuteVisibilitySettingRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\UpdateEmpAttrbuteVisibilitySettingResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\UpdateEmpAttributeHideBySceneSettingHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\UpdateEmpAttributeHideBySceneSettingRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\UpdateEmpAttributeHideBySceneSettingResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\UpdateManagementGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\UpdateManagementGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\UpdateManagementGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\UpdateSeniorSettingHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\UpdateSeniorSettingRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\UpdateSeniorSettingResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\UpdateUserOwnnessHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\UpdateUserOwnnessRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\UpdateUserOwnnessResponse;
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
     * @param AddContactHideBySceneSettingRequest $request
     * @param AddContactHideBySceneSettingHeaders $headers
     * @param RuntimeOptions                      $runtime
     *
     * @return AddContactHideBySceneSettingResponse
     */
    public function addContactHideBySceneSettingWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->description)) {
            $body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->excludeDeptIds)) {
            $body['excludeDeptIds'] = $request->excludeDeptIds;
        }
        if (!Utils::isUnset($request->excludeTagIds)) {
            $body['excludeTagIds'] = $request->excludeTagIds;
        }
        if (!Utils::isUnset($request->excludeUserIds)) {
            $body['excludeUserIds'] = $request->excludeUserIds;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->nodeListSceneConfig)) {
            $body['nodeListSceneConfig'] = $request->nodeListSceneConfig;
        }
        if (!Utils::isUnset($request->objectDeptIds)) {
            $body['objectDeptIds'] = $request->objectDeptIds;
        }
        if (!Utils::isUnset($request->objectTagIds)) {
            $body['objectTagIds'] = $request->objectTagIds;
        }
        if (!Utils::isUnset($request->objectUserIds)) {
            $body['objectUserIds'] = $request->objectUserIds;
        }
        if (!Utils::isUnset($request->profileSceneConfig)) {
            $body['profileSceneConfig'] = $request->profileSceneConfig;
        }
        if (!Utils::isUnset($request->searchSceneConfig)) {
            $body['searchSceneConfig'] = $request->searchSceneConfig;
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
            'action'      => 'AddContactHideBySceneSetting',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/organizations/hides/settings',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AddContactHideBySceneSettingResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param AddContactHideBySceneSettingRequest $request
     *
     * @return AddContactHideBySceneSettingResponse
     */
    public function addContactHideBySceneSetting($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddContactHideBySceneSettingHeaders([]);

        return $this->addContactHideBySceneSettingWithOptions($request, $headers, $runtime);
    }

    /**
     * @param AddEmpAttributeHideBySceneSettingRequest $request
     * @param AddEmpAttributeHideBySceneSettingHeaders $headers
     * @param RuntimeOptions                           $runtime
     *
     * @return AddEmpAttributeHideBySceneSettingResponse
     */
    public function addEmpAttributeHideBySceneSettingWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->chatSubtitleConfig)) {
            $body['chatSubtitleConfig'] = $request->chatSubtitleConfig;
        }
        if (!Utils::isUnset($request->description)) {
            $body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->excludeDeptIds)) {
            $body['excludeDeptIds'] = $request->excludeDeptIds;
        }
        if (!Utils::isUnset($request->excludeTagIds)) {
            $body['excludeTagIds'] = $request->excludeTagIds;
        }
        if (!Utils::isUnset($request->excludeUserIds)) {
            $body['excludeUserIds'] = $request->excludeUserIds;
        }
        if (!Utils::isUnset($request->hideFields)) {
            $body['hideFields'] = $request->hideFields;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->objectDeptIds)) {
            $body['objectDeptIds'] = $request->objectDeptIds;
        }
        if (!Utils::isUnset($request->objectTagIds)) {
            $body['objectTagIds'] = $request->objectTagIds;
        }
        if (!Utils::isUnset($request->objectUserIds)) {
            $body['objectUserIds'] = $request->objectUserIds;
        }
        if (!Utils::isUnset($request->profileSceneConfig)) {
            $body['profileSceneConfig'] = $request->profileSceneConfig;
        }
        if (!Utils::isUnset($request->searchSceneConfig)) {
            $body['searchSceneConfig'] = $request->searchSceneConfig;
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
            'action'      => 'AddEmpAttributeHideBySceneSetting',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/empAttributes/hides/settings',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AddEmpAttributeHideBySceneSettingResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param AddEmpAttributeHideBySceneSettingRequest $request
     *
     * @return AddEmpAttributeHideBySceneSettingResponse
     */
    public function addEmpAttributeHideBySceneSetting($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddEmpAttributeHideBySceneSettingHeaders([]);

        return $this->addEmpAttributeHideBySceneSettingWithOptions($request, $headers, $runtime);
    }

    /**
     * @param AnnualCertificationAuditRequest $request
     * @param AnnualCertificationAuditHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return AnnualCertificationAuditResponse
     */
    public function annualCertificationAuditWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->applicantMobile)) {
            $body['applicantMobile'] = $request->applicantMobile;
        }
        if (!Utils::isUnset($request->applicantName)) {
            $body['applicantName'] = $request->applicantName;
        }
        if (!Utils::isUnset($request->applicationLetter)) {
            $body['applicationLetter'] = $request->applicationLetter;
        }
        if (!Utils::isUnset($request->authStatus)) {
            $body['authStatus'] = $request->authStatus;
        }
        if (!Utils::isUnset($request->certificateType)) {
            $body['certificateType'] = $request->certificateType;
        }
        if (!Utils::isUnset($request->corpName)) {
            $body['corpName'] = $request->corpName;
        }
        if (!Utils::isUnset($request->depositaryBank)) {
            $body['depositaryBank'] = $request->depositaryBank;
        }
        if (!Utils::isUnset($request->extension)) {
            $body['extension'] = $request->extension;
        }
        if (!Utils::isUnset($request->legalPerson)) {
            $body['legalPerson'] = $request->legalPerson;
        }
        if (!Utils::isUnset($request->licenseNumber)) {
            $body['licenseNumber'] = $request->licenseNumber;
        }
        if (!Utils::isUnset($request->licenseUrl)) {
            $body['licenseUrl'] = $request->licenseUrl;
        }
        if (!Utils::isUnset($request->orderId)) {
            $body['orderId'] = $request->orderId;
        }
        if (!Utils::isUnset($request->publicAccount)) {
            $body['publicAccount'] = $request->publicAccount;
        }
        if (!Utils::isUnset($request->reasonCode)) {
            $body['reasonCode'] = $request->reasonCode;
        }
        if (!Utils::isUnset($request->reasonMsg)) {
            $body['reasonMsg'] = $request->reasonMsg;
        }
        if (!Utils::isUnset($request->tag)) {
            $body['tag'] = $request->tag;
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
            'action'      => 'AnnualCertificationAudit',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/organizations/authorities/audit',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AnnualCertificationAuditResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param AnnualCertificationAuditRequest $request
     *
     * @return AnnualCertificationAuditResponse
     */
    public function annualCertificationAudit($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AnnualCertificationAuditHeaders([]);

        return $this->annualCertificationAuditWithOptions($request, $headers, $runtime);
    }

    /**
     * @param BatchApproveUnionApplyRequest $request
     * @param BatchApproveUnionApplyHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return BatchApproveUnionApplyResponse
     */
    public function batchApproveUnionApplyWithOptions($request, $headers, $runtime)
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
            'body'    => Utils::toArray($request->body),
        ]);
        $params = new Params([
            'action'      => 'BatchApproveUnionApply',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/cooperateCorps/unionApplications/approve',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BatchApproveUnionApplyResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param BatchApproveUnionApplyRequest $request
     *
     * @return BatchApproveUnionApplyResponse
     */
    public function batchApproveUnionApply($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchApproveUnionApplyHeaders([]);

        return $this->batchApproveUnionApplyWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ChangeMainAdminRequest $request
     * @param ChangeMainAdminHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return ChangeMainAdminResponse
     */
    public function changeMainAdminWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->effectCorpId)) {
            $body['effectCorpId'] = $request->effectCorpId;
        }
        if (!Utils::isUnset($request->sourceUserId)) {
            $body['sourceUserId'] = $request->sourceUserId;
        }
        if (!Utils::isUnset($request->targetUserId)) {
            $body['targetUserId'] = $request->targetUserId;
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
            'action'      => 'ChangeMainAdmin',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/orgAccounts/mainAdministrators/change',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'none',
        ]);

        return ChangeMainAdminResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ChangeMainAdminRequest $request
     *
     * @return ChangeMainAdminResponse
     */
    public function changeMainAdmin($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ChangeMainAdminHeaders([]);

        return $this->changeMainAdminWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateCooperateOrgRequest $request
     * @param CreateCooperateOrgHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return CreateCooperateOrgResponse
     */
    public function createCooperateOrgWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->industryCode)) {
            $body['industryCode'] = $request->industryCode;
        }
        if (!Utils::isUnset($request->logoMediaId)) {
            $body['logoMediaId'] = $request->logoMediaId;
        }
        if (!Utils::isUnset($request->orgName)) {
            $body['orgName'] = $request->orgName;
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
            'action'      => 'CreateCooperateOrg',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/cooperateCorps',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return CreateCooperateOrgResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CreateCooperateOrgRequest $request
     *
     * @return CreateCooperateOrgResponse
     */
    public function createCooperateOrg($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateCooperateOrgHeaders([]);

        return $this->createCooperateOrgWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateManagementGroupRequest $request
     * @param CreateManagementGroupHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return CreateManagementGroupResponse
     */
    public function createManagementGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->groupName)) {
            $body['groupName'] = $request->groupName;
        }
        if (!Utils::isUnset($request->members)) {
            $body['members'] = $request->members;
        }
        if (!Utils::isUnset($request->resourceIds)) {
            $body['resourceIds'] = $request->resourceIds;
        }
        if (!Utils::isUnset($request->scope)) {
            $body['scope'] = $request->scope;
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
            'action'      => 'CreateManagementGroup',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/managementGroups',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return CreateManagementGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CreateManagementGroupRequest $request
     *
     * @return CreateManagementGroupResponse
     */
    public function createManagementGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateManagementGroupHeaders([]);

        return $this->createManagementGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateSecondaryManagementGroupRequest $request
     * @param CreateSecondaryManagementGroupHeaders $headers
     * @param RuntimeOptions                        $runtime
     *
     * @return CreateSecondaryManagementGroupResponse
     */
    public function createSecondaryManagementGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->userId)) {
            $query['userId'] = $request->userId;
        }
        $body = [];
        if (!Utils::isUnset($request->groupName)) {
            $body['groupName'] = $request->groupName;
        }
        if (!Utils::isUnset($request->members)) {
            $body['members'] = $request->members;
        }
        if (!Utils::isUnset($request->resourceIds)) {
            $body['resourceIds'] = $request->resourceIds;
        }
        if (!Utils::isUnset($request->scope)) {
            $body['scope'] = $request->scope;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'CreateSecondaryManagementGroup',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/secondaryAdministrators/managementGroups',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateSecondaryManagementGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CreateSecondaryManagementGroupRequest $request
     *
     * @return CreateSecondaryManagementGroupResponse
     */
    public function createSecondaryManagementGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateSecondaryManagementGroupHeaders([]);

        return $this->createSecondaryManagementGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                                 $settingId
     * @param DeleteContactHideBySceneSettingHeaders $headers
     * @param RuntimeOptions                         $runtime
     *
     * @return DeleteContactHideBySceneSettingResponse
     */
    public function deleteContactHideBySceneSettingWithOptions($settingId, $headers, $runtime)
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
            'action'      => 'DeleteContactHideBySceneSetting',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/organizations/hides/settings/' . $settingId . '',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DeleteContactHideBySceneSettingResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string $settingId
     *
     * @return DeleteContactHideBySceneSettingResponse
     */
    public function deleteContactHideBySceneSetting($settingId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteContactHideBySceneSettingHeaders([]);

        return $this->deleteContactHideBySceneSettingWithOptions($settingId, $headers, $runtime);
    }

    /**
     * @param string                          $settingId
     * @param DeleteContactHideSettingHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return DeleteContactHideSettingResponse
     */
    public function deleteContactHideSettingWithOptions($settingId, $headers, $runtime)
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
            'action'      => 'DeleteContactHideSetting',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/contactHideSettings/' . $settingId . '',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return DeleteContactHideSettingResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string $settingId
     *
     * @return DeleteContactHideSettingResponse
     */
    public function deleteContactHideSetting($settingId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteContactHideSettingHeaders([]);

        return $this->deleteContactHideSettingWithOptions($settingId, $headers, $runtime);
    }

    /**
     * @param string                              $settingId
     * @param DeleteContactRestrictSettingHeaders $headers
     * @param RuntimeOptions                      $runtime
     *
     * @return DeleteContactRestrictSettingResponse
     */
    public function deleteContactRestrictSettingWithOptions($settingId, $headers, $runtime)
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
            'action'      => 'DeleteContactRestrictSetting',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/restrictions/settings/' . $settingId . '',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DeleteContactRestrictSettingResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string $settingId
     *
     * @return DeleteContactRestrictSettingResponse
     */
    public function deleteContactRestrictSetting($settingId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteContactRestrictSettingHeaders([]);

        return $this->deleteContactRestrictSettingWithOptions($settingId, $headers, $runtime);
    }

    /**
     * @param string                                      $settingId
     * @param DeleteEmpAttributeHideBySceneSettingHeaders $headers
     * @param RuntimeOptions                              $runtime
     *
     * @return DeleteEmpAttributeHideBySceneSettingResponse
     */
    public function deleteEmpAttributeHideBySceneSettingWithOptions($settingId, $headers, $runtime)
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
            'action'      => 'DeleteEmpAttributeHideBySceneSetting',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/empAttributes/hides/settings/' . $settingId . '',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DeleteEmpAttributeHideBySceneSettingResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string $settingId
     *
     * @return DeleteEmpAttributeHideBySceneSettingResponse
     */
    public function deleteEmpAttributeHideBySceneSetting($settingId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteEmpAttributeHideBySceneSettingHeaders([]);

        return $this->deleteEmpAttributeHideBySceneSettingWithOptions($settingId, $headers, $runtime);
    }

    /**
     * @param string                              $settingId
     * @param DeleteEmpAttributeVisibilityHeaders $headers
     * @param RuntimeOptions                      $runtime
     *
     * @return DeleteEmpAttributeVisibilityResponse
     */
    public function deleteEmpAttributeVisibilityWithOptions($settingId, $headers, $runtime)
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
            'action'      => 'DeleteEmpAttributeVisibility',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/staffAttributes/visibilitySettings/' . $settingId . '',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return DeleteEmpAttributeVisibilityResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string $settingId
     *
     * @return DeleteEmpAttributeVisibilityResponse
     */
    public function deleteEmpAttributeVisibility($settingId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteEmpAttributeVisibilityHeaders([]);

        return $this->deleteEmpAttributeVisibilityWithOptions($settingId, $headers, $runtime);
    }

    /**
     * @param string                       $groupId
     * @param DeleteManagementGroupHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return DeleteManagementGroupResponse
     */
    public function deleteManagementGroupWithOptions($groupId, $headers, $runtime)
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
            'action'      => 'DeleteManagementGroup',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/managementGroups/' . $groupId . '',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return DeleteManagementGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string $groupId
     *
     * @return DeleteManagementGroupResponse
     */
    public function deleteManagementGroup($groupId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteManagementGroupHeaders([]);

        return $this->deleteManagementGroupWithOptions($groupId, $headers, $runtime);
    }

    /**
     * @param GetApplyInviteInfoRequest $request
     * @param GetApplyInviteInfoHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return GetApplyInviteInfoResponse
     */
    public function getApplyInviteInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->deptId)) {
            $query['deptId'] = $request->deptId;
        }
        if (!Utils::isUnset($request->inviterUserId)) {
            $query['inviterUserId'] = $request->inviterUserId;
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
            'action'      => 'GetApplyInviteInfo',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/invites/infos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return GetApplyInviteInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetApplyInviteInfoRequest $request
     *
     * @return GetApplyInviteInfoResponse
     */
    public function getApplyInviteInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetApplyInviteInfoHeaders([]);

        return $this->getApplyInviteInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetBranchAuthDataRequest $request
     * @param GetBranchAuthDataHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return GetBranchAuthDataResponse
     */
    public function getBranchAuthDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->branchCorpId)) {
            $query['branchCorpId'] = $request->branchCorpId;
        }
        if (!Utils::isUnset($request->code)) {
            $query['code'] = $request->code;
        }
        $body = [];
        if (!Utils::isUnset($request->body)) {
            $body['body'] = $request->body;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'GetBranchAuthData',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/branchAuthDatas/search',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return GetBranchAuthDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetBranchAuthDataRequest $request
     *
     * @return GetBranchAuthDataResponse
     */
    public function getBranchAuthData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetBranchAuthDataHeaders([]);

        return $this->getBranchAuthDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                     $cardId
     * @param GetCardInUserHolderHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return GetCardInUserHolderResponse
     */
    public function getCardInUserHolderWithOptions($cardId, $headers, $runtime)
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
            'action'      => 'GetCardInUserHolder',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/cards/holders/infos/' . $cardId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetCardInUserHolderResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string $cardId
     *
     * @return GetCardInUserHolderResponse
     */
    public function getCardInUserHolder($cardId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetCardInUserHolderHeaders([]);

        return $this->getCardInUserHolderWithOptions($cardId, $headers, $runtime);
    }

    /**
     * @param string             $cardId
     * @param GetCardInfoHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return GetCardInfoResponse
     */
    public function getCardInfoWithOptions($cardId, $headers, $runtime)
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
            'action'      => 'GetCardInfo',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/cards/infos/' . $cardId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetCardInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string $cardId
     *
     * @return GetCardInfoResponse
     */
    public function getCardInfo($cardId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetCardInfoHeaders([]);

        return $this->getCardInfoWithOptions($cardId, $headers, $runtime);
    }

    /**
     * @param string                              $settingId
     * @param GetContactHideBySceneSettingHeaders $headers
     * @param RuntimeOptions                      $runtime
     *
     * @return GetContactHideBySceneSettingResponse
     */
    public function getContactHideBySceneSettingWithOptions($settingId, $headers, $runtime)
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
            'action'      => 'GetContactHideBySceneSetting',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/organizations/hides/settings/' . $settingId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetContactHideBySceneSettingResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string $settingId
     *
     * @return GetContactHideBySceneSettingResponse
     */
    public function getContactHideBySceneSetting($settingId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetContactHideBySceneSettingHeaders([]);

        return $this->getContactHideBySceneSettingWithOptions($settingId, $headers, $runtime);
    }

    /**
     * @param string                           $cooperateCorpId
     * @param GetCooperateOrgInviteInfoHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return GetCooperateOrgInviteInfoResponse
     */
    public function getCooperateOrgInviteInfoWithOptions($cooperateCorpId, $headers, $runtime)
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
            'action'      => 'GetCooperateOrgInviteInfo',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/cooperateCorps/' . $cooperateCorpId . '/inviteInfos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetCooperateOrgInviteInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string $cooperateCorpId
     *
     * @return GetCooperateOrgInviteInfoResponse
     */
    public function getCooperateOrgInviteInfo($cooperateCorpId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetCooperateOrgInviteInfoHeaders([]);

        return $this->getCooperateOrgInviteInfoWithOptions($cooperateCorpId, $headers, $runtime);
    }

    /**
     * @param GetCorpCardStyleListHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return GetCorpCardStyleListResponse
     */
    public function getCorpCardStyleListWithOptions($headers, $runtime)
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
            'action'      => 'GetCorpCardStyleList',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/cards/styles/lists',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetCorpCardStyleListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @return GetCorpCardStyleListResponse
     */
    public function getCorpCardStyleList()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetCorpCardStyleListHeaders([]);

        return $this->getCorpCardStyleListWithOptions($headers, $runtime);
    }

    /**
     * @param GetDingIdByMigrationDingIdRequest $request
     * @param GetDingIdByMigrationDingIdHeaders $headers
     * @param RuntimeOptions                    $runtime
     *
     * @return GetDingIdByMigrationDingIdResponse
     */
    public function getDingIdByMigrationDingIdWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->migrationDingId)) {
            $query['migrationDingId'] = $request->migrationDingId;
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
            'action'      => 'GetDingIdByMigrationDingId',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/orgAccount/getDingIdByMigrationDingIds',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetDingIdByMigrationDingIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetDingIdByMigrationDingIdRequest $request
     *
     * @return GetDingIdByMigrationDingIdResponse
     */
    public function getDingIdByMigrationDingId($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetDingIdByMigrationDingIdHeaders([]);

        return $this->getDingIdByMigrationDingIdWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                                   $settingId
     * @param GetEmpAttributeHideBySceneSettingHeaders $headers
     * @param RuntimeOptions                           $runtime
     *
     * @return GetEmpAttributeHideBySceneSettingResponse
     */
    public function getEmpAttributeHideBySceneSettingWithOptions($settingId, $headers, $runtime)
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
            'action'      => 'GetEmpAttributeHideBySceneSetting',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/empAttributes/hides/settings/' . $settingId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetEmpAttributeHideBySceneSettingResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string $settingId
     *
     * @return GetEmpAttributeHideBySceneSettingResponse
     */
    public function getEmpAttributeHideBySceneSetting($settingId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetEmpAttributeHideBySceneSettingHeaders([]);

        return $this->getEmpAttributeHideBySceneSettingWithOptions($settingId, $headers, $runtime);
    }

    /**
     * @param GetLatestDingIndexHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return GetLatestDingIndexResponse
     */
    public function getLatestDingIndexWithOptions($headers, $runtime)
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
            'action'      => 'GetLatestDingIndex',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/dingIndexs',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return GetLatestDingIndexResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @return GetLatestDingIndexResponse
     */
    public function getLatestDingIndex()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetLatestDingIndexHeaders([]);

        return $this->getLatestDingIndexWithOptions($headers, $runtime);
    }

    /**
     * @param GetMigrationDingIdByDingIdRequest $request
     * @param GetMigrationDingIdByDingIdHeaders $headers
     * @param RuntimeOptions                    $runtime
     *
     * @return GetMigrationDingIdByDingIdResponse
     */
    public function getMigrationDingIdByDingIdWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->dingId)) {
            $query['dingId'] = $request->dingId;
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
            'action'      => 'GetMigrationDingIdByDingId',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/orgAccount/getMigrationDingIdByDingIds',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetMigrationDingIdByDingIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetMigrationDingIdByDingIdRequest $request
     *
     * @return GetMigrationDingIdByDingIdResponse
     */
    public function getMigrationDingIdByDingId($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetMigrationDingIdByDingIdHeaders([]);

        return $this->getMigrationDingIdByDingIdWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetMigrationUnionIdByUnionIdRequest $request
     * @param GetMigrationUnionIdByUnionIdHeaders $headers
     * @param RuntimeOptions                      $runtime
     *
     * @return GetMigrationUnionIdByUnionIdResponse
     */
    public function getMigrationUnionIdByUnionIdWithOptions($request, $headers, $runtime)
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
            'action'      => 'GetMigrationUnionIdByUnionId',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/orgAccount/getMigrationUnionIdByUnionIds',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetMigrationUnionIdByUnionIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetMigrationUnionIdByUnionIdRequest $request
     *
     * @return GetMigrationUnionIdByUnionIdResponse
     */
    public function getMigrationUnionIdByUnionId($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetMigrationUnionIdByUnionIdHeaders([]);

        return $this->getMigrationUnionIdByUnionIdWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetOrgAuthInfoRequest $request
     * @param GetOrgAuthInfoHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return GetOrgAuthInfoResponse
     */
    public function getOrgAuthInfoWithOptions($request, $headers, $runtime)
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
            'action'      => 'GetOrgAuthInfo',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/organizations/authInfos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetOrgAuthInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetOrgAuthInfoRequest $request
     *
     * @return GetOrgAuthInfoResponse
     */
    public function getOrgAuthInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetOrgAuthInfoHeaders([]);

        return $this->getOrgAuthInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetTranslateFileJobResultRequest $request
     * @param GetTranslateFileJobResultHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return GetTranslateFileJobResultResponse
     */
    public function getTranslateFileJobResultWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->jobId)) {
            $query['jobId'] = $request->jobId;
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
            'action'      => 'GetTranslateFileJobResult',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/files/translateResults',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetTranslateFileJobResultResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetTranslateFileJobResultRequest $request
     *
     * @return GetTranslateFileJobResultResponse
     */
    public function getTranslateFileJobResult($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetTranslateFileJobResultHeaders([]);

        return $this->getTranslateFileJobResultWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetUnionIdByMigrationUnionIdRequest $request
     * @param GetUnionIdByMigrationUnionIdHeaders $headers
     * @param RuntimeOptions                      $runtime
     *
     * @return GetUnionIdByMigrationUnionIdResponse
     */
    public function getUnionIdByMigrationUnionIdWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->migrationUnionId)) {
            $query['migrationUnionId'] = $request->migrationUnionId;
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
            'action'      => 'GetUnionIdByMigrationUnionId',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/orgAccount/getUnionIdByMigrationUnionIds',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetUnionIdByMigrationUnionIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetUnionIdByMigrationUnionIdRequest $request
     *
     * @return GetUnionIdByMigrationUnionIdResponse
     */
    public function getUnionIdByMigrationUnionId($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetUnionIdByMigrationUnionIdHeaders([]);

        return $this->getUnionIdByMigrationUnionIdWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string         $unionId
     * @param GetUserHeaders $headers
     * @param RuntimeOptions $runtime
     *
     * @return GetUserResponse
     */
    public function getUserWithOptions($unionId, $headers, $runtime)
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
            'action'      => 'GetUser',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/users/' . $unionId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return GetUserResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string $unionId
     *
     * @return GetUserResponse
     */
    public function getUser($unionId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetUserHeaders([]);

        return $this->getUserWithOptions($unionId, $headers, $runtime);
    }

    /**
     * @param GetUserCardHolderListRequest $request
     * @param GetUserCardHolderListHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return GetUserCardHolderListResponse
     */
    public function getUserCardHolderListWithOptions($request, $headers, $runtime)
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
            'action'      => 'GetUserCardHolderList',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/cards/holders/lists',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetUserCardHolderListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetUserCardHolderListRequest $request
     *
     * @return GetUserCardHolderListResponse
     */
    public function getUserCardHolderList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetUserCardHolderListHeaders([]);

        return $this->getUserCardHolderListWithOptions($request, $headers, $runtime);
    }

    /**
     * @param IsFriendRequest $request
     * @param IsFriendHeaders $headers
     * @param RuntimeOptions  $runtime
     *
     * @return IsFriendResponse
     */
    public function isFriendWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->mobileNo)) {
            $body['mobileNo'] = $request->mobileNo;
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
            'action'      => 'IsFriend',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/relationships/friends/judge',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return IsFriendResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param IsFriendRequest $request
     *
     * @return IsFriendResponse
     */
    public function isFriend($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new IsFriendHeaders([]);

        return $this->isFriendWithOptions($request, $headers, $runtime);
    }

    /**
     * @param IsvCardEventPushRequest $request
     * @param IsvCardEventPushHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return IsvCardEventPushResponse
     */
    public function isvCardEventPushWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->isvCardId)) {
            $query['isvCardId'] = $request->isvCardId;
        }
        if (!Utils::isUnset($request->isvToken)) {
            $query['isvToken'] = $request->isvToken;
        }
        if (!Utils::isUnset($request->isvUid)) {
            $query['isvUid'] = $request->isvUid;
        }
        $body = [];
        if (!Utils::isUnset($request->eventParams)) {
            $body['eventParams'] = $request->eventParams;
        }
        if (!Utils::isUnset($request->eventType)) {
            $body['eventType'] = $request->eventType;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'IsvCardEventPush',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/cards/events/push',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return IsvCardEventPushResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param IsvCardEventPushRequest $request
     *
     * @return IsvCardEventPushResponse
     */
    public function isvCardEventPush($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new IsvCardEventPushHeaders([]);

        return $this->isvCardEventPushWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ListBasicRoleInPageRequest $request
     * @param ListBasicRoleInPageHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return ListBasicRoleInPageResponse
     */
    public function listBasicRoleInPageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->agentId)) {
            $query['agentId'] = $request->agentId;
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'ListBasicRoleInPage',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/rbac/administrativeGroups/baseInfos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListBasicRoleInPageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ListBasicRoleInPageRequest $request
     *
     * @return ListBasicRoleInPageResponse
     */
    public function listBasicRoleInPage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListBasicRoleInPageHeaders([]);

        return $this->listBasicRoleInPageWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ListContactHideSettingsRequest $request
     * @param ListContactHideSettingsHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return ListContactHideSettingsResponse
     */
    public function listContactHideSettingsWithOptions($request, $headers, $runtime)
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
            'action'      => 'ListContactHideSettings',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/contactHideSettings',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return ListContactHideSettingsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ListContactHideSettingsRequest $request
     *
     * @return ListContactHideSettingsResponse
     */
    public function listContactHideSettings($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListContactHideSettingsHeaders([]);

        return $this->listContactHideSettingsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ListContactRestrictSettingRequest $request
     * @param ListContactRestrictSettingHeaders $headers
     * @param RuntimeOptions                    $runtime
     *
     * @return ListContactRestrictSettingResponse
     */
    public function listContactRestrictSettingWithOptions($request, $headers, $runtime)
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
            'action'      => 'ListContactRestrictSetting',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/restrictions/settings',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListContactRestrictSettingResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ListContactRestrictSettingRequest $request
     *
     * @return ListContactRestrictSettingResponse
     */
    public function listContactRestrictSetting($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListContactRestrictSettingHeaders([]);

        return $this->listContactRestrictSettingWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ListEmpAttributeVisibilityRequest $request
     * @param ListEmpAttributeVisibilityHeaders $headers
     * @param RuntimeOptions                    $runtime
     *
     * @return ListEmpAttributeVisibilityResponse
     */
    public function listEmpAttributeVisibilityWithOptions($request, $headers, $runtime)
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
            'action'      => 'ListEmpAttributeVisibility',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/staffAttributes/visibilitySettings',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListEmpAttributeVisibilityResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ListEmpAttributeVisibilityRequest $request
     *
     * @return ListEmpAttributeVisibilityResponse
     */
    public function listEmpAttributeVisibility($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListEmpAttributeVisibilityHeaders([]);

        return $this->listEmpAttributeVisibilityWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ListEmpLeaveRecordsRequest $request
     * @param ListEmpLeaveRecordsHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return ListEmpLeaveRecordsResponse
     */
    public function listEmpLeaveRecordsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->endTime)) {
            $query['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
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
            'action'      => 'ListEmpLeaveRecords',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/empLeaveRecords',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListEmpLeaveRecordsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ListEmpLeaveRecordsRequest $request
     *
     * @return ListEmpLeaveRecordsResponse
     */
    public function listEmpLeaveRecords($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListEmpLeaveRecordsHeaders([]);

        return $this->listEmpLeaveRecordsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ListManagementGroupsRequest $request
     * @param ListManagementGroupsHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return ListManagementGroupsResponse
     */
    public function listManagementGroupsWithOptions($request, $headers, $runtime)
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
            'action'      => 'ListManagementGroups',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/managementGroups',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return ListManagementGroupsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ListManagementGroupsRequest $request
     *
     * @return ListManagementGroupsResponse
     */
    public function listManagementGroups($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListManagementGroupsHeaders([]);

        return $this->listManagementGroupsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ListOwnedOrgByStaffIdRequest $request
     * @param ListOwnedOrgByStaffIdHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return ListOwnedOrgByStaffIdResponse
     */
    public function listOwnedOrgByStaffIdWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'ListOwnedOrgByStaffId',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/orgAccounts/ownedOrganizations',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListOwnedOrgByStaffIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ListOwnedOrgByStaffIdRequest $request
     *
     * @return ListOwnedOrgByStaffIdResponse
     */
    public function listOwnedOrgByStaffId($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListOwnedOrgByStaffIdHeaders([]);

        return $this->listOwnedOrgByStaffIdWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ListSeniorSettingsRequest $request
     * @param ListSeniorSettingsHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return ListSeniorSettingsResponse
     */
    public function listSeniorSettingsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->seniorStaffId)) {
            $query['seniorStaffId'] = $request->seniorStaffId;
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
            'action'      => 'ListSeniorSettings',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/seniorSettings',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return ListSeniorSettingsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ListSeniorSettingsRequest $request
     *
     * @return ListSeniorSettingsResponse
     */
    public function listSeniorSettings($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListSeniorSettingsHeaders([]);

        return $this->listSeniorSettingsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param MultiOrgPermissionGrantRequest $request
     * @param MultiOrgPermissionGrantHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return MultiOrgPermissionGrantResponse
     */
    public function multiOrgPermissionGrantWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->grantDeptIdList)) {
            $body['grantDeptIdList'] = $request->grantDeptIdList;
        }
        if (!Utils::isUnset($request->joinCorpId)) {
            $body['joinCorpId'] = $request->joinCorpId;
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
            'action'      => 'MultiOrgPermissionGrant',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/orgAccounts/multiOrgPermissions/auth',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'none',
        ]);

        return MultiOrgPermissionGrantResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param MultiOrgPermissionGrantRequest $request
     *
     * @return MultiOrgPermissionGrantResponse
     */
    public function multiOrgPermissionGrant($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new MultiOrgPermissionGrantHeaders([]);

        return $this->multiOrgPermissionGrantWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryCardVisitorStatisticDataRequest $request
     * @param QueryCardVisitorStatisticDataHeaders $headers
     * @param RuntimeOptions                       $runtime
     *
     * @return QueryCardVisitorStatisticDataResponse
     */
    public function queryCardVisitorStatisticDataWithOptions($request, $headers, $runtime)
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
            'action'      => 'QueryCardVisitorStatisticData',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/cards/visitors/statistics',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryCardVisitorStatisticDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryCardVisitorStatisticDataRequest $request
     *
     * @return QueryCardVisitorStatisticDataResponse
     */
    public function queryCardVisitorStatisticData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryCardVisitorStatisticDataHeaders([]);

        return $this->queryCardVisitorStatisticDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryCorpStatisticDataRequest $request
     * @param QueryCorpStatisticDataHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return QueryCorpStatisticDataResponse
     */
    public function queryCorpStatisticDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->endTime)) {
            $body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->startTime)) {
            $body['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->templateIds)) {
            $body['templateIds'] = $request->templateIds;
        }
        if (!Utils::isUnset($request->unionId)) {
            $body['unionId'] = $request->unionId;
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
            'action'      => 'QueryCorpStatisticData',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/cards/templates/statistics/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryCorpStatisticDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryCorpStatisticDataRequest $request
     *
     * @return QueryCorpStatisticDataResponse
     */
    public function queryCorpStatisticData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryCorpStatisticDataHeaders([]);

        return $this->queryCorpStatisticDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryCorpUserStatisticRequest $request
     * @param QueryCorpUserStatisticHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return QueryCorpUserStatisticResponse
     */
    public function queryCorpUserStatisticWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->endTime)) {
            $body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->maxResults)) {
            $body['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $body['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->startTime)) {
            $body['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->templateIds)) {
            $body['templateIds'] = $request->templateIds;
        }
        if (!Utils::isUnset($request->unionId)) {
            $body['unionId'] = $request->unionId;
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
            'action'      => 'QueryCorpUserStatistic',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/cards/users/statistics/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryCorpUserStatisticResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryCorpUserStatisticRequest $request
     *
     * @return QueryCorpUserStatisticResponse
     */
    public function queryCorpUserStatistic($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryCorpUserStatisticHeaders([]);

        return $this->queryCorpUserStatisticWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                                $resourceId
     * @param QueryResourceManagementMembersHeaders $headers
     * @param RuntimeOptions                        $runtime
     *
     * @return QueryResourceManagementMembersResponse
     */
    public function queryResourceManagementMembersWithOptions($resourceId, $headers, $runtime)
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
            'action'      => 'QueryResourceManagementMembers',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/resources/' . $resourceId . '/managementMembers',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QueryResourceManagementMembersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string $resourceId
     *
     * @return QueryResourceManagementMembersResponse
     */
    public function queryResourceManagementMembers($resourceId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryResourceManagementMembersHeaders([]);

        return $this->queryResourceManagementMembersWithOptions($resourceId, $headers, $runtime);
    }

    /**
     * @param QueryStatusRequest $request
     * @param QueryStatusHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return QueryStatusResponse
     */
    public function queryStatusWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'QueryStatus',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/orgAccounts/status',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QueryStatusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryStatusRequest $request
     *
     * @return QueryStatusResponse
     */
    public function queryStatus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryStatusHeaders([]);

        return $this->queryStatusWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                              $userId
     * @param QueryUserManagementResourcesHeaders $headers
     * @param RuntimeOptions                      $runtime
     *
     * @return QueryUserManagementResourcesResponse
     */
    public function queryUserManagementResourcesWithOptions($userId, $headers, $runtime)
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
            'action'      => 'QueryUserManagementResources',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/users/' . $userId . '/managemementResources',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QueryUserManagementResourcesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string $userId
     *
     * @return QueryUserManagementResourcesResponse
     */
    public function queryUserManagementResources($userId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryUserManagementResourcesHeaders([]);

        return $this->queryUserManagementResourcesWithOptions($userId, $headers, $runtime);
    }

    /**
     * @param QueryVerifyResultRequest $request
     * @param QueryVerifyResultHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return QueryVerifyResultResponse
     */
    public function queryVerifyResultWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->verifyId)) {
            $query['verifyId'] = $request->verifyId;
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
            'action'      => 'QueryVerifyResult',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/verifyIdentitys/verifyResults',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryVerifyResultResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryVerifyResultRequest $request
     *
     * @return QueryVerifyResultResponse
     */
    public function queryVerifyResult($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryVerifyResultHeaders([]);

        return $this->queryVerifyResultWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SearchDepartmentRequest $request
     * @param SearchDepartmentHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return SearchDepartmentResponse
     */
    public function searchDepartmentWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->offset)) {
            $body['offset'] = $request->offset;
        }
        if (!Utils::isUnset($request->queryWord)) {
            $body['queryWord'] = $request->queryWord;
        }
        if (!Utils::isUnset($request->size)) {
            $body['size'] = $request->size;
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
            'action'      => 'SearchDepartment',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/departments/search',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SearchDepartmentResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SearchDepartmentRequest $request
     *
     * @return SearchDepartmentResponse
     */
    public function searchDepartment($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchDepartmentHeaders([]);

        return $this->searchDepartmentWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SearchUserRequest $request
     * @param SearchUserHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return SearchUserResponse
     */
    public function searchUserWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->fullMatchField)) {
            $body['fullMatchField'] = $request->fullMatchField;
        }
        if (!Utils::isUnset($request->offset)) {
            $body['offset'] = $request->offset;
        }
        if (!Utils::isUnset($request->queryWord)) {
            $body['queryWord'] = $request->queryWord;
        }
        if (!Utils::isUnset($request->size)) {
            $body['size'] = $request->size;
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
            'action'      => 'SearchUser',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/users/search',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SearchUserResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SearchUserRequest $request
     *
     * @return SearchUserResponse
     */
    public function searchUser($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchUserHeaders([]);

        return $this->searchUserWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SeparateBranchOrgRequest $request
     * @param SeparateBranchOrgHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return SeparateBranchOrgResponse
     */
    public function separateBranchOrgWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->attachDeptId)) {
            $body['attachDeptId'] = $request->attachDeptId;
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
            'action'      => 'SeparateBranchOrg',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/cooperateCorps/separate',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SeparateBranchOrgResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SeparateBranchOrgRequest $request
     *
     * @return SeparateBranchOrgResponse
     */
    public function separateBranchOrg($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SeparateBranchOrgHeaders([]);

        return $this->separateBranchOrgWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SetDisableRequest $request
     * @param SetDisableHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return SetDisableResponse
     */
    public function setDisableWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->reason)) {
            $body['reason'] = $request->reason;
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
            'action'      => 'SetDisable',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/orgAccounts/disable',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SetDisableResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SetDisableRequest $request
     *
     * @return SetDisableResponse
     */
    public function setDisable($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SetDisableHeaders([]);

        return $this->setDisableWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SetEnableRequest $request
     * @param SetEnableHeaders $headers
     * @param RuntimeOptions   $runtime
     *
     * @return SetEnableResponse
     */
    public function setEnableWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
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
            'action'      => 'SetEnable',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/orgAccounts/enable',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SetEnableResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SetEnableRequest $request
     *
     * @return SetEnableResponse
     */
    public function setEnable($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SetEnableHeaders([]);

        return $this->setEnableWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SignOutRequest $request
     * @param SignOutHeaders $headers
     * @param RuntimeOptions $runtime
     *
     * @return SignOutResponse
     */
    public function signOutWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->reason)) {
            $body['reason'] = $request->reason;
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
            'action'      => 'SignOut',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/orgAccounts/signOut',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SignOutResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SignOutRequest $request
     *
     * @return SignOutResponse
     */
    public function signOut($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SignOutHeaders([]);

        return $this->signOutWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SortUserRequest $request
     * @param SortUserHeaders $headers
     * @param RuntimeOptions  $runtime
     *
     * @return SortUserResponse
     */
    public function sortUserWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->sortType)) {
            $body['sortType'] = $request->sortType;
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
            'action'      => 'SortUser',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/users/sort',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SortUserResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SortUserRequest $request
     *
     * @return SortUserResponse
     */
    public function sortUser($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SortUserHeaders([]);

        return $this->sortUserWithOptions($request, $headers, $runtime);
    }

    /**
     * @param TransformToExclusiveAccountRequest $request
     * @param TransformToExclusiveAccountHeaders $headers
     * @param RuntimeOptions                     $runtime
     *
     * @return TransformToExclusiveAccountResponse
     */
    public function transformToExclusiveAccountWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->idpDingTalk)) {
            $body['idpDingTalk'] = $request->idpDingTalk;
        }
        if (!Utils::isUnset($request->initPassword)) {
            $body['initPassword'] = $request->initPassword;
        }
        if (!Utils::isUnset($request->loginId)) {
            $body['loginId'] = $request->loginId;
        }
        if (!Utils::isUnset($request->transformType)) {
            $body['transformType'] = $request->transformType;
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
            'action'      => 'TransformToExclusiveAccount',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/orgAccount/transformToExclusiveAccounts',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return TransformToExclusiveAccountResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param TransformToExclusiveAccountRequest $request
     *
     * @return TransformToExclusiveAccountResponse
     */
    public function transformToExclusiveAccount($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new TransformToExclusiveAccountHeaders([]);

        return $this->transformToExclusiveAccountWithOptions($request, $headers, $runtime);
    }

    /**
     * @param TranslateFileRequest $request
     * @param TranslateFileHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return TranslateFileResponse
     */
    public function translateFileWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->medias)) {
            $body['medias'] = $request->medias;
        }
        if (!Utils::isUnset($request->outputFileName)) {
            $body['outputFileName'] = $request->outputFileName;
        }
        if (!Utils::isUnset($request->unionId)) {
            $body['unionId'] = $request->unionId;
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
            'action'      => 'TranslateFile',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/files/translate',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return TranslateFileResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param TranslateFileRequest $request
     *
     * @return TranslateFileResponse
     */
    public function translateFile($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new TranslateFileHeaders([]);

        return $this->translateFileWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UniqueQueryUserCardRequest $request
     * @param UniqueQueryUserCardHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return UniqueQueryUserCardResponse
     */
    public function uniqueQueryUserCardWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->templateId)) {
            $query['templateId'] = $request->templateId;
        }
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
            'action'      => 'UniqueQueryUserCard',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/uniques/cards',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UniqueQueryUserCardResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param UniqueQueryUserCardRequest $request
     *
     * @return UniqueQueryUserCardResponse
     */
    public function uniqueQueryUserCard($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UniqueQueryUserCardHeaders([]);

        return $this->uniqueQueryUserCardWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateBranchAttributesInCooperateRequest $request
     * @param UpdateBranchAttributesInCooperateHeaders $headers
     * @param RuntimeOptions                           $runtime
     *
     * @return UpdateBranchAttributesInCooperateResponse
     */
    public function updateBranchAttributesInCooperateWithOptions($request, $headers, $runtime)
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
            'body'    => Utils::toArray($request->body),
        ]);
        $params = new Params([
            'action'      => 'UpdateBranchAttributesInCooperate',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/cooperateCorps/branchAttributes',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return UpdateBranchAttributesInCooperateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param UpdateBranchAttributesInCooperateRequest $request
     *
     * @return UpdateBranchAttributesInCooperateResponse
     */
    public function updateBranchAttributesInCooperate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateBranchAttributesInCooperateHeaders([]);

        return $this->updateBranchAttributesInCooperateWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateBranchVisibleSettingInCooperateRequest $request
     * @param UpdateBranchVisibleSettingInCooperateHeaders $headers
     * @param RuntimeOptions                               $runtime
     *
     * @return UpdateBranchVisibleSettingInCooperateResponse
     */
    public function updateBranchVisibleSettingInCooperateWithOptions($request, $headers, $runtime)
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
            'body'    => Utils::toArray($request->body),
        ]);
        $params = new Params([
            'action'      => 'UpdateBranchVisibleSettingInCooperate',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/cooperateCorps/branchVisibleSettings',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'none',
        ]);

        return UpdateBranchVisibleSettingInCooperateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param UpdateBranchVisibleSettingInCooperateRequest $request
     *
     * @return UpdateBranchVisibleSettingInCooperateResponse
     */
    public function updateBranchVisibleSettingInCooperate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateBranchVisibleSettingInCooperateHeaders([]);

        return $this->updateBranchVisibleSettingInCooperateWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                                 $settingId
     * @param UpdateContactHideBySceneSettingRequest $request
     * @param UpdateContactHideBySceneSettingHeaders $headers
     * @param RuntimeOptions                         $runtime
     *
     * @return UpdateContactHideBySceneSettingResponse
     */
    public function updateContactHideBySceneSettingWithOptions($settingId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->description)) {
            $body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->excludeDeptIds)) {
            $body['excludeDeptIds'] = $request->excludeDeptIds;
        }
        if (!Utils::isUnset($request->excludeTagIds)) {
            $body['excludeTagIds'] = $request->excludeTagIds;
        }
        if (!Utils::isUnset($request->excludeUserIds)) {
            $body['excludeUserIds'] = $request->excludeUserIds;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->nodeListSceneConfig)) {
            $body['nodeListSceneConfig'] = $request->nodeListSceneConfig;
        }
        if (!Utils::isUnset($request->objectDeptIds)) {
            $body['objectDeptIds'] = $request->objectDeptIds;
        }
        if (!Utils::isUnset($request->objectTagIds)) {
            $body['objectTagIds'] = $request->objectTagIds;
        }
        if (!Utils::isUnset($request->objectUserIds)) {
            $body['objectUserIds'] = $request->objectUserIds;
        }
        if (!Utils::isUnset($request->profileSceneConfig)) {
            $body['profileSceneConfig'] = $request->profileSceneConfig;
        }
        if (!Utils::isUnset($request->searchSceneConfig)) {
            $body['searchSceneConfig'] = $request->searchSceneConfig;
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
            'action'      => 'UpdateContactHideBySceneSetting',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/organizations/hides/settings/' . $settingId . '',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateContactHideBySceneSettingResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                                 $settingId
     * @param UpdateContactHideBySceneSettingRequest $request
     *
     * @return UpdateContactHideBySceneSettingResponse
     */
    public function updateContactHideBySceneSetting($settingId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateContactHideBySceneSettingHeaders([]);

        return $this->updateContactHideBySceneSettingWithOptions($settingId, $request, $headers, $runtime);
    }

    /**
     * @param UpdateContactHideSettingRequest $request
     * @param UpdateContactHideSettingHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return UpdateContactHideSettingResponse
     */
    public function updateContactHideSettingWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->active)) {
            $body['active'] = $request->active;
        }
        if (!Utils::isUnset($request->description)) {
            $body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->excludeDeptIds)) {
            $body['excludeDeptIds'] = $request->excludeDeptIds;
        }
        if (!Utils::isUnset($request->excludeStaffIds)) {
            $body['excludeStaffIds'] = $request->excludeStaffIds;
        }
        if (!Utils::isUnset($request->excludeTagIds)) {
            $body['excludeTagIds'] = $request->excludeTagIds;
        }
        if (!Utils::isUnset($request->hideInSearch)) {
            $body['hideInSearch'] = $request->hideInSearch;
        }
        if (!Utils::isUnset($request->hideInUserProfile)) {
            $body['hideInUserProfile'] = $request->hideInUserProfile;
        }
        if (!Utils::isUnset($request->id)) {
            $body['id'] = $request->id;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->objectDeptIds)) {
            $body['objectDeptIds'] = $request->objectDeptIds;
        }
        if (!Utils::isUnset($request->objectStaffIds)) {
            $body['objectStaffIds'] = $request->objectStaffIds;
        }
        if (!Utils::isUnset($request->objectTagIds)) {
            $body['objectTagIds'] = $request->objectTagIds;
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
            'action'      => 'UpdateContactHideSetting',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/contactHideSettings',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateContactHideSettingResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param UpdateContactHideSettingRequest $request
     *
     * @return UpdateContactHideSettingResponse
     */
    public function updateContactHideSetting($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateContactHideSettingHeaders([]);

        return $this->updateContactHideSettingWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateContactRestrictSettingRequest $request
     * @param UpdateContactRestrictSettingHeaders $headers
     * @param RuntimeOptions                      $runtime
     *
     * @return UpdateContactRestrictSettingResponse
     */
    public function updateContactRestrictSettingWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->active)) {
            $body['active'] = $request->active;
        }
        if (!Utils::isUnset($request->description)) {
            $body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->excludeDeptIds)) {
            $body['excludeDeptIds'] = $request->excludeDeptIds;
        }
        if (!Utils::isUnset($request->excludeTagIds)) {
            $body['excludeTagIds'] = $request->excludeTagIds;
        }
        if (!Utils::isUnset($request->excludeUserIds)) {
            $body['excludeUserIds'] = $request->excludeUserIds;
        }
        if (!Utils::isUnset($request->id)) {
            $body['id'] = $request->id;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->restrictInSearch)) {
            $body['restrictInSearch'] = $request->restrictInSearch;
        }
        if (!Utils::isUnset($request->restrictInUserProfile)) {
            $body['restrictInUserProfile'] = $request->restrictInUserProfile;
        }
        if (!Utils::isUnset($request->subjectDeptIds)) {
            $body['subjectDeptIds'] = $request->subjectDeptIds;
        }
        if (!Utils::isUnset($request->subjectTagIds)) {
            $body['subjectTagIds'] = $request->subjectTagIds;
        }
        if (!Utils::isUnset($request->subjectUserIds)) {
            $body['subjectUserIds'] = $request->subjectUserIds;
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
            'action'      => 'UpdateContactRestrictSetting',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/restrictions/settings',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateContactRestrictSettingResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param UpdateContactRestrictSettingRequest $request
     *
     * @return UpdateContactRestrictSettingResponse
     */
    public function updateContactRestrictSetting($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateContactRestrictSettingHeaders([]);

        return $this->updateContactRestrictSettingWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateDeptSettngTailFirstRequest $request
     * @param UpdateDeptSettngTailFirstHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return UpdateDeptSettngTailFirstResponse
     */
    public function updateDeptSettngTailFirstWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->enable)) {
            $body['enable'] = $request->enable;
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
            'action'      => 'UpdateDeptSettngTailFirst',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/depts/settings/priorities',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'formData',
            'bodyType'    => 'json',
        ]);

        return UpdateDeptSettngTailFirstResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param UpdateDeptSettngTailFirstRequest $request
     *
     * @return UpdateDeptSettngTailFirstResponse
     */
    public function updateDeptSettngTailFirst($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateDeptSettngTailFirstHeaders([]);

        return $this->updateDeptSettngTailFirstWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateEmpAttrbuteVisibilitySettingRequest $request
     * @param UpdateEmpAttrbuteVisibilitySettingHeaders $headers
     * @param RuntimeOptions                            $runtime
     *
     * @return UpdateEmpAttrbuteVisibilitySettingResponse
     */
    public function updateEmpAttrbuteVisibilitySettingWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->active)) {
            $body['active'] = $request->active;
        }
        if (!Utils::isUnset($request->description)) {
            $body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->excludeDeptIds)) {
            $body['excludeDeptIds'] = $request->excludeDeptIds;
        }
        if (!Utils::isUnset($request->excludeStaffIds)) {
            $body['excludeStaffIds'] = $request->excludeStaffIds;
        }
        if (!Utils::isUnset($request->excludeTagIds)) {
            $body['excludeTagIds'] = $request->excludeTagIds;
        }
        if (!Utils::isUnset($request->hideFields)) {
            $body['hideFields'] = $request->hideFields;
        }
        if (!Utils::isUnset($request->id)) {
            $body['id'] = $request->id;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->objectDeptIds)) {
            $body['objectDeptIds'] = $request->objectDeptIds;
        }
        if (!Utils::isUnset($request->objectStaffIds)) {
            $body['objectStaffIds'] = $request->objectStaffIds;
        }
        if (!Utils::isUnset($request->objectTagIds)) {
            $body['objectTagIds'] = $request->objectTagIds;
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
            'action'      => 'UpdateEmpAttrbuteVisibilitySetting',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/staffAttributes/visibilitySettings',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return UpdateEmpAttrbuteVisibilitySettingResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param UpdateEmpAttrbuteVisibilitySettingRequest $request
     *
     * @return UpdateEmpAttrbuteVisibilitySettingResponse
     */
    public function updateEmpAttrbuteVisibilitySetting($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateEmpAttrbuteVisibilitySettingHeaders([]);

        return $this->updateEmpAttrbuteVisibilitySettingWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                                      $settingId
     * @param UpdateEmpAttributeHideBySceneSettingRequest $request
     * @param UpdateEmpAttributeHideBySceneSettingHeaders $headers
     * @param RuntimeOptions                              $runtime
     *
     * @return UpdateEmpAttributeHideBySceneSettingResponse
     */
    public function updateEmpAttributeHideBySceneSettingWithOptions($settingId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->chatSubtitleConfig)) {
            $body['chatSubtitleConfig'] = $request->chatSubtitleConfig;
        }
        if (!Utils::isUnset($request->description)) {
            $body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->excludeDeptIds)) {
            $body['excludeDeptIds'] = $request->excludeDeptIds;
        }
        if (!Utils::isUnset($request->excludeTagIds)) {
            $body['excludeTagIds'] = $request->excludeTagIds;
        }
        if (!Utils::isUnset($request->excludeUserIds)) {
            $body['excludeUserIds'] = $request->excludeUserIds;
        }
        if (!Utils::isUnset($request->hideFields)) {
            $body['hideFields'] = $request->hideFields;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->objectDeptIds)) {
            $body['objectDeptIds'] = $request->objectDeptIds;
        }
        if (!Utils::isUnset($request->objectTagIds)) {
            $body['objectTagIds'] = $request->objectTagIds;
        }
        if (!Utils::isUnset($request->objectUserIds)) {
            $body['objectUserIds'] = $request->objectUserIds;
        }
        if (!Utils::isUnset($request->profileSceneConfig)) {
            $body['profileSceneConfig'] = $request->profileSceneConfig;
        }
        if (!Utils::isUnset($request->searchSceneConfig)) {
            $body['searchSceneConfig'] = $request->searchSceneConfig;
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
            'action'      => 'UpdateEmpAttributeHideBySceneSetting',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/empAttributes/hides/settings/' . $settingId . '',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateEmpAttributeHideBySceneSettingResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                                      $settingId
     * @param UpdateEmpAttributeHideBySceneSettingRequest $request
     *
     * @return UpdateEmpAttributeHideBySceneSettingResponse
     */
    public function updateEmpAttributeHideBySceneSetting($settingId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateEmpAttributeHideBySceneSettingHeaders([]);

        return $this->updateEmpAttributeHideBySceneSettingWithOptions($settingId, $request, $headers, $runtime);
    }

    /**
     * @param string                       $groupId
     * @param UpdateManagementGroupRequest $request
     * @param UpdateManagementGroupHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return UpdateManagementGroupResponse
     */
    public function updateManagementGroupWithOptions($groupId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->groupName)) {
            $body['groupName'] = $request->groupName;
        }
        if (!Utils::isUnset($request->members)) {
            $body['members'] = $request->members;
        }
        if (!Utils::isUnset($request->resourceIds)) {
            $body['resourceIds'] = $request->resourceIds;
        }
        if (!Utils::isUnset($request->scope)) {
            $body['scope'] = $request->scope;
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
            'action'      => 'UpdateManagementGroup',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/managementGroups/' . $groupId . '',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return UpdateManagementGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                       $groupId
     * @param UpdateManagementGroupRequest $request
     *
     * @return UpdateManagementGroupResponse
     */
    public function updateManagementGroup($groupId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateManagementGroupHeaders([]);

        return $this->updateManagementGroupWithOptions($groupId, $request, $headers, $runtime);
    }

    /**
     * @param UpdateSeniorSettingRequest $request
     * @param UpdateSeniorSettingHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return UpdateSeniorSettingResponse
     */
    public function updateSeniorSettingWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->open)) {
            $body['open'] = $request->open;
        }
        if (!Utils::isUnset($request->permitDeptIds)) {
            $body['permitDeptIds'] = $request->permitDeptIds;
        }
        if (!Utils::isUnset($request->permitStaffIds)) {
            $body['permitStaffIds'] = $request->permitStaffIds;
        }
        if (!Utils::isUnset($request->permitTagIds)) {
            $body['permitTagIds'] = $request->permitTagIds;
        }
        if (!Utils::isUnset($request->protectScenes)) {
            $body['protectScenes'] = $request->protectScenes;
        }
        if (!Utils::isUnset($request->seniorStaffId)) {
            $body['seniorStaffId'] = $request->seniorStaffId;
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
            'action'      => 'UpdateSeniorSetting',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/seniorSettings',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'none',
        ]);

        return UpdateSeniorSettingResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param UpdateSeniorSettingRequest $request
     *
     * @return UpdateSeniorSettingResponse
     */
    public function updateSeniorSetting($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateSeniorSettingHeaders([]);

        return $this->updateSeniorSettingWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                   $userId
     * @param UpdateUserOwnnessRequest $request
     * @param UpdateUserOwnnessHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return UpdateUserOwnnessResponse
     */
    public function updateUserOwnnessWithOptions($userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->deletedFlag)) {
            $body['deletedFlag'] = $request->deletedFlag;
        }
        if (!Utils::isUnset($request->endTime)) {
            $body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->id)) {
            $body['id'] = $request->id;
        }
        if (!Utils::isUnset($request->ownenssType)) {
            $body['ownenssType'] = $request->ownenssType;
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
            'action'      => 'UpdateUserOwnness',
            'version'     => 'contact_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contact/user/' . $userId . '/ownness',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateUserOwnnessResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                   $userId
     * @param UpdateUserOwnnessRequest $request
     *
     * @return UpdateUserOwnnessResponse
     */
    public function updateUserOwnness($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateUserOwnnessHeaders([]);

        return $this->updateUserOwnnessWithOptions($userId, $request, $headers, $runtime);
    }
}
