<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\CreateCooperateOrgHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\CreateCooperateOrgRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\CreateCooperateOrgResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\CreateManagementGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\CreateManagementGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\CreateManagementGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\DeleteContactHideSettingHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\DeleteContactHideSettingResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetCooperateOrgInviteInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetCooperateOrgInviteInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetDingIdByMigrationDingIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetDingIdByMigrationDingIdRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetDingIdByMigrationDingIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetLatestDingIndexHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetLatestDingIndexResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetMigrationDingIdByDingIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetMigrationDingIdByDingIdRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetMigrationDingIdByDingIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetMigrationUnionIdByUnionIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetMigrationUnionIdByUnionIdRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetMigrationUnionIdByUnionIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetTranslateFileJobResultHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetTranslateFileJobResultRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetTranslateFileJobResultResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetUnionIdByMigrationUnionIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetUnionIdByMigrationUnionIdRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetUnionIdByMigrationUnionIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetUserHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetUserResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListContactHideSettingsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListContactHideSettingsRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListContactHideSettingsResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListEmpAttributeVisibilityHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListEmpAttributeVisibilityRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListEmpAttributeVisibilityResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListManagementGroupsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListManagementGroupsRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListManagementGroupsResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListSeniorSettingsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListSeniorSettingsRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListSeniorSettingsResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\QueryResourceManagementMembersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\QueryResourceManagementMembersResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\QueryUserManagementResourcesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\QueryUserManagementResourcesResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\SearchDepartmentHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\SearchDepartmentRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\SearchDepartmentResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\SearchUserHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\SearchUserRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\SearchUserResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\SortUserHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\SortUserRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\SortUserResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\TransformToExclusiveAccountHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\TransformToExclusiveAccountRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\TransformToExclusiveAccountResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\TranslateFileHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\TranslateFileRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\TranslateFileResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\UpdateContactHideSettingHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\UpdateContactHideSettingRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\UpdateContactHideSettingResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\UpdateEmpAttrbuteVisibilitySettingHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\UpdateEmpAttrbuteVisibilitySettingRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\UpdateEmpAttrbuteVisibilitySettingResponse;
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
        if (!Utils::isUnset($request->dingOrgId)) {
            @$body['dingOrgId'] = $request->dingOrgId;
        }
        if (!Utils::isUnset($request->userIdList)) {
            @$body['userIdList'] = $request->userIdList;
        }
        if (!Utils::isUnset($request->sortType)) {
            @$body['sortType'] = $request->sortType;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return SortUserResponse::fromMap($this->doROARequest('SortUser', 'contact_1.0', 'HTTP', 'POST', 'AK', '/v1.0/contact/users/sort', 'json', $req, $runtime));
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
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return ListContactHideSettingsResponse::fromMap($this->doROARequest('ListContactHideSettings', 'contact_1.0', 'HTTP', 'GET', 'AK', '/v1.0/contact/contactHideSettings', 'json', $req, $runtime));
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
        if (!Utils::isUnset($request->name)) {
            @$body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->description)) {
            @$body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->objectStaffIds)) {
            @$body['objectStaffIds'] = $request->objectStaffIds;
        }
        if (!Utils::isUnset($request->objectDeptIds)) {
            @$body['objectDeptIds'] = $request->objectDeptIds;
        }
        if (!Utils::isUnset($request->objectTagIds)) {
            @$body['objectTagIds'] = $request->objectTagIds;
        }
        if (!Utils::isUnset($request->excludeStaffIds)) {
            @$body['excludeStaffIds'] = $request->excludeStaffIds;
        }
        if (!Utils::isUnset($request->excludeDeptIds)) {
            @$body['excludeDeptIds'] = $request->excludeDeptIds;
        }
        if (!Utils::isUnset($request->excludeTagIds)) {
            @$body['excludeTagIds'] = $request->excludeTagIds;
        }
        if (!Utils::isUnset($request->active)) {
            @$body['active'] = $request->active;
        }
        if (!Utils::isUnset($request->id)) {
            @$body['id'] = $request->id;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return UpdateContactHideSettingResponse::fromMap($this->doROARequest('UpdateContactHideSetting', 'contact_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/contact/contactHideSettings', 'json', $req, $runtime));
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
        if (!Utils::isUnset($request->id)) {
            @$body['id'] = $request->id;
        }
        if (!Utils::isUnset($request->name)) {
            @$body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->description)) {
            @$body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->objectStaffIds)) {
            @$body['objectStaffIds'] = $request->objectStaffIds;
        }
        if (!Utils::isUnset($request->objectDeptIds)) {
            @$body['objectDeptIds'] = $request->objectDeptIds;
        }
        if (!Utils::isUnset($request->objectTagIds)) {
            @$body['objectTagIds'] = $request->objectTagIds;
        }
        if (!Utils::isUnset($request->hideFields)) {
            @$body['hideFields'] = $request->hideFields;
        }
        if (!Utils::isUnset($request->excludeStaffIds)) {
            @$body['excludeStaffIds'] = $request->excludeStaffIds;
        }
        if (!Utils::isUnset($request->excludeDeptIds)) {
            @$body['excludeDeptIds'] = $request->excludeDeptIds;
        }
        if (!Utils::isUnset($request->excludeTagIds)) {
            @$body['excludeTagIds'] = $request->excludeTagIds;
        }
        if (!Utils::isUnset($request->active)) {
            @$body['active'] = $request->active;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return UpdateEmpAttrbuteVisibilitySettingResponse::fromMap($this->doROARequest('UpdateEmpAttrbuteVisibilitySetting', 'contact_1.0', 'HTTP', 'POST', 'AK', '/v1.0/contact/staffAttributes/visibilitySettings', 'json', $req, $runtime));
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
     * @param string                              $settingId
     * @param DeleteEmpAttributeVisibilityHeaders $headers
     * @param RuntimeOptions                      $runtime
     *
     * @return DeleteEmpAttributeVisibilityResponse
     */
    public function deleteEmpAttributeVisibilityWithOptions($settingId, $headers, $runtime)
    {
        $settingId   = OpenApiUtilClient::getEncodeParam($settingId);
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return DeleteEmpAttributeVisibilityResponse::fromMap($this->doROARequest('DeleteEmpAttributeVisibility', 'contact_1.0', 'HTTP', 'DELETE', 'AK', '/v1.0/contact/staffAttributes/visibilitySettings/' . $settingId . '', 'none', $req, $runtime));
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
        if (!Utils::isUnset($request->dingOrgId)) {
            @$body['dingOrgId'] = $request->dingOrgId;
        }
        if (!Utils::isUnset($request->queryWord)) {
            @$body['queryWord'] = $request->queryWord;
        }
        if (!Utils::isUnset($request->offset)) {
            @$body['offset'] = $request->offset;
        }
        if (!Utils::isUnset($request->size)) {
            @$body['size'] = $request->size;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return SearchDepartmentResponse::fromMap($this->doROARequest('SearchDepartment', 'contact_1.0', 'HTTP', 'POST', 'AK', '/v1.0/contact/departments/search', 'json', $req, $runtime));
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
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return ListManagementGroupsResponse::fromMap($this->doROARequest('ListManagementGroups', 'contact_1.0', 'HTTP', 'GET', 'AK', '/v1.0/contact/managementGroups', 'json', $req, $runtime));
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
            @$query['seniorStaffId'] = $request->seniorStaffId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return ListSeniorSettingsResponse::fromMap($this->doROARequest('ListSeniorSettings', 'contact_1.0', 'HTTP', 'GET', 'AK', '/v1.0/contact/seniorSettings', 'json', $req, $runtime));
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
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return ListEmpAttributeVisibilityResponse::fromMap($this->doROARequest('ListEmpAttributeVisibility', 'contact_1.0', 'HTTP', 'GET', 'AK', '/v1.0/contact/staffAttributes/visibilitySettings', 'json', $req, $runtime));
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
        if (!Utils::isUnset($request->dingOrgId)) {
            @$body['dingOrgId'] = $request->dingOrgId;
        }
        if (!Utils::isUnset($request->queryWord)) {
            @$body['queryWord'] = $request->queryWord;
        }
        if (!Utils::isUnset($request->offset)) {
            @$body['offset'] = $request->offset;
        }
        if (!Utils::isUnset($request->size)) {
            @$body['size'] = $request->size;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return SearchUserResponse::fromMap($this->doROARequest('SearchUser', 'contact_1.0', 'HTTP', 'POST', 'AK', '/v1.0/contact/users/search', 'json', $req, $runtime));
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
            @$query['jobId'] = $request->jobId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetTranslateFileJobResultResponse::fromMap($this->doROARequest('GetTranslateFileJobResult', 'contact_1.0', 'HTTP', 'GET', 'AK', '/v1.0/contact/files/translateResults', 'json', $req, $runtime));
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
     * @param string                              $userId
     * @param QueryUserManagementResourcesHeaders $headers
     * @param RuntimeOptions                      $runtime
     *
     * @return QueryUserManagementResourcesResponse
     */
    public function queryUserManagementResourcesWithOptions($userId, $headers, $runtime)
    {
        $userId      = OpenApiUtilClient::getEncodeParam($userId);
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return QueryUserManagementResourcesResponse::fromMap($this->doROARequest('QueryUserManagementResources', 'contact_1.0', 'HTTP', 'GET', 'AK', '/v1.0/contact/users/' . $userId . '/managemementResources', 'json', $req, $runtime));
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
     * @param string                          $settingId
     * @param DeleteContactHideSettingHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return DeleteContactHideSettingResponse
     */
    public function deleteContactHideSettingWithOptions($settingId, $headers, $runtime)
    {
        $settingId   = OpenApiUtilClient::getEncodeParam($settingId);
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return DeleteContactHideSettingResponse::fromMap($this->doROARequest('DeleteContactHideSetting', 'contact_1.0', 'HTTP', 'DELETE', 'AK', '/v1.0/contact/contactHideSettings/' . $settingId . '', 'none', $req, $runtime));
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
        $userId = OpenApiUtilClient::getEncodeParam($userId);
        $body   = [];
        if (!Utils::isUnset($request->ownenssType)) {
            @$body['ownenssType'] = $request->ownenssType;
        }
        if (!Utils::isUnset($request->id)) {
            @$body['id'] = $request->id;
        }
        if (!Utils::isUnset($request->startTime)) {
            @$body['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->endTime)) {
            @$body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->deletedFlag)) {
            @$body['deletedFlag'] = $request->deletedFlag;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return UpdateUserOwnnessResponse::fromMap($this->doROARequest('UpdateUserOwnness', 'contact_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/contact/user/' . $userId . '/ownness', 'json', $req, $runtime));
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
            @$query['unionId'] = $request->unionId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetMigrationUnionIdByUnionIdResponse::fromMap($this->doROARequest('GetMigrationUnionIdByUnionId', 'contact_1.0', 'HTTP', 'GET', 'AK', '/v1.0/contact/orgAccount/getMigrationUnionIdByUnionIds', 'json', $req, $runtime));
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
            @$query['migrationDingId'] = $request->migrationDingId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetDingIdByMigrationDingIdResponse::fromMap($this->doROARequest('GetDingIdByMigrationDingId', 'contact_1.0', 'HTTP', 'GET', 'AK', '/v1.0/contact/orgAccount/getDingIdByMigrationDingIds', 'json', $req, $runtime));
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
     * @param string                           $cooperateCorpId
     * @param GetCooperateOrgInviteInfoHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return GetCooperateOrgInviteInfoResponse
     */
    public function getCooperateOrgInviteInfoWithOptions($cooperateCorpId, $headers, $runtime)
    {
        $cooperateCorpId = OpenApiUtilClient::getEncodeParam($cooperateCorpId);
        $realHeaders     = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return GetCooperateOrgInviteInfoResponse::fromMap($this->doROARequest('GetCooperateOrgInviteInfo', 'contact_1.0', 'HTTP', 'GET', 'AK', '/v1.0/contact/cooperateCorps/' . $cooperateCorpId . '/inviteInfos', 'json', $req, $runtime));
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
        $groupId = OpenApiUtilClient::getEncodeParam($groupId);
        $body    = [];
        if (!Utils::isUnset($request->groupName)) {
            @$body['groupName'] = $request->groupName;
        }
        if (!Utils::isUnset($request->members)) {
            @$body['members'] = $request->members;
        }
        if (!Utils::isUnset($request->scope)) {
            @$body['scope'] = $request->scope;
        }
        if (!Utils::isUnset($request->resourceIds)) {
            @$body['resourceIds'] = $request->resourceIds;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return UpdateManagementGroupResponse::fromMap($this->doROARequest('UpdateManagementGroup', 'contact_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/contact/managementGroups/' . $groupId . '', 'none', $req, $runtime));
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
            @$query['branchCorpId'] = $request->branchCorpId;
        }
        if (!Utils::isUnset($request->code)) {
            @$query['code'] = $request->code;
        }
        $body = [];
        if (!Utils::isUnset($request->body)) {
            $body = $request->body;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return GetBranchAuthDataResponse::fromMap($this->doROARequest('GetBranchAuthData', 'contact_1.0', 'HTTP', 'POST', 'AK', '/v1.0/contact/branchAuthDatas/search', 'json', $req, $runtime));
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
     * @param string         $unionId
     * @param GetUserHeaders $headers
     * @param RuntimeOptions $runtime
     *
     * @return GetUserResponse
     */
    public function getUserWithOptions($unionId, $headers, $runtime)
    {
        $unionId     = OpenApiUtilClient::getEncodeParam($unionId);
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return GetUserResponse::fromMap($this->doROARequest('GetUser', 'contact_1.0', 'HTTP', 'GET', 'AK', '/v1.0/contact/users/' . $unionId . '', 'json', $req, $runtime));
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
     * @param string                                $resourceId
     * @param QueryResourceManagementMembersHeaders $headers
     * @param RuntimeOptions                        $runtime
     *
     * @return QueryResourceManagementMembersResponse
     */
    public function queryResourceManagementMembersWithOptions($resourceId, $headers, $runtime)
    {
        $resourceId  = OpenApiUtilClient::getEncodeParam($resourceId);
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return QueryResourceManagementMembersResponse::fromMap($this->doROARequest('QueryResourceManagementMembers', 'contact_1.0', 'HTTP', 'GET', 'AK', '/v1.0/contact/resources/' . $resourceId . '/managementMembers', 'json', $req, $runtime));
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
        if (!Utils::isUnset($request->dingTokenGrantType)) {
            @$body['dingTokenGrantType'] = $request->dingTokenGrantType;
        }
        if (!Utils::isUnset($request->dingOrgId)) {
            @$body['dingOrgId'] = $request->dingOrgId;
        }
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            @$body['dingIsvOrgId'] = $request->dingIsvOrgId;
        }
        if (!Utils::isUnset($request->dingSuiteKey)) {
            @$body['dingSuiteKey'] = $request->dingSuiteKey;
        }
        if (!Utils::isUnset($request->medias)) {
            @$body['medias'] = $request->medias;
        }
        if (!Utils::isUnset($request->outputFileName)) {
            @$body['outputFileName'] = $request->outputFileName;
        }
        if (!Utils::isUnset($request->unionId)) {
            @$body['unionId'] = $request->unionId;
        }
        if (!Utils::isUnset($request->requestId)) {
            @$body['RequestId'] = $request->requestId;
        }
        if (!Utils::isUnset($request->eagleEyeTraceId)) {
            @$body['eagleEyeTraceId'] = $request->eagleEyeTraceId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return TranslateFileResponse::fromMap($this->doROARequest('TranslateFile', 'contact_1.0', 'HTTP', 'POST', 'AK', '/v1.0/contact/files/translate', 'json', $req, $runtime));
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
        if (!Utils::isUnset($request->seniorStaffId)) {
            @$body['seniorStaffId'] = $request->seniorStaffId;
        }
        if (!Utils::isUnset($request->open)) {
            @$body['open'] = $request->open;
        }
        if (!Utils::isUnset($request->permitStaffIds)) {
            @$body['permitStaffIds'] = $request->permitStaffIds;
        }
        if (!Utils::isUnset($request->permitDeptIds)) {
            @$body['permitDeptIds'] = $request->permitDeptIds;
        }
        if (!Utils::isUnset($request->permitTagIds)) {
            @$body['permitTagIds'] = $request->permitTagIds;
        }
        if (!Utils::isUnset($request->protectScenes)) {
            @$body['protectScenes'] = $request->protectScenes;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return UpdateSeniorSettingResponse::fromMap($this->doROARequest('UpdateSeniorSetting', 'contact_1.0', 'HTTP', 'POST', 'AK', '/v1.0/contact/seniorSettings', 'none', $req, $runtime));
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
        if (!Utils::isUnset($request->inviterUserId)) {
            @$query['inviterUserId'] = $request->inviterUserId;
        }
        if (!Utils::isUnset($request->deptId)) {
            @$query['deptId'] = $request->deptId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetApplyInviteInfoResponse::fromMap($this->doROARequest('GetApplyInviteInfo', 'contact_1.0', 'HTTP', 'GET', 'AK', '/v1.0/contact/invites/infos', 'json', $req, $runtime));
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
        if (!Utils::isUnset($request->orgName)) {
            @$body['orgName'] = $request->orgName;
        }
        if (!Utils::isUnset($request->logoMediaId)) {
            @$body['logoMediaId'] = $request->logoMediaId;
        }
        if (!Utils::isUnset($request->industryCode)) {
            @$body['industryCode'] = $request->industryCode;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return CreateCooperateOrgResponse::fromMap($this->doROARequest('CreateCooperateOrg', 'contact_1.0', 'HTTP', 'POST', 'AK', '/v1.0/contact/cooperateCorps', 'json', $req, $runtime));
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
            @$query['dingId'] = $request->dingId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetMigrationDingIdByDingIdResponse::fromMap($this->doROARequest('GetMigrationDingIdByDingId', 'contact_1.0', 'HTTP', 'GET', 'AK', '/v1.0/contact/orgAccount/getMigrationDingIdByDingIds', 'json', $req, $runtime));
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
            @$body['groupName'] = $request->groupName;
        }
        if (!Utils::isUnset($request->members)) {
            @$body['members'] = $request->members;
        }
        if (!Utils::isUnset($request->scope)) {
            @$body['scope'] = $request->scope;
        }
        if (!Utils::isUnset($request->resourceIds)) {
            @$body['resourceIds'] = $request->resourceIds;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return CreateManagementGroupResponse::fromMap($this->doROARequest('CreateManagementGroup', 'contact_1.0', 'HTTP', 'POST', 'AK', '/v1.0/contact/managementGroups', 'json', $req, $runtime));
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
     * @param string                       $groupId
     * @param DeleteManagementGroupHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return DeleteManagementGroupResponse
     */
    public function deleteManagementGroupWithOptions($groupId, $headers, $runtime)
    {
        $groupId     = OpenApiUtilClient::getEncodeParam($groupId);
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return DeleteManagementGroupResponse::fromMap($this->doROARequest('DeleteManagementGroup', 'contact_1.0', 'HTTP', 'DELETE', 'AK', '/v1.0/contact/managementGroups/' . $groupId . '', 'none', $req, $runtime));
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
        if (!Utils::isUnset($request->transformType)) {
            @$body['transformType'] = $request->transformType;
        }
        if (!Utils::isUnset($request->idpDingTalk)) {
            @$body['idpDingTalk'] = $request->idpDingTalk;
        }
        if (!Utils::isUnset($request->loginId)) {
            @$body['loginId'] = $request->loginId;
        }
        if (!Utils::isUnset($request->initPassword)) {
            @$body['initPassword'] = $request->initPassword;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return TransformToExclusiveAccountResponse::fromMap($this->doROARequest('TransformToExclusiveAccount', 'contact_1.0', 'HTTP', 'POST', 'AK', '/v1.0/contact/orgAccount/transformToExclusiveAccounts', 'none', $req, $runtime));
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
            @$query['migrationUnionId'] = $request->migrationUnionId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetUnionIdByMigrationUnionIdResponse::fromMap($this->doROARequest('GetUnionIdByMigrationUnionId', 'contact_1.0', 'HTTP', 'GET', 'AK', '/v1.0/contact/orgAccount/getUnionIdByMigrationUnionIds', 'json', $req, $runtime));
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
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return GetLatestDingIndexResponse::fromMap($this->doROARequest('GetLatestDingIndex', 'contact_1.0', 'HTTP', 'GET', 'AK', '/v1.0/contact/dingIndexs', 'json', $req, $runtime));
    }
}
