<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\CreateManagementGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\CreateManagementGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\CreateManagementGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\DeleteManagementGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\DeleteManagementGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetApplyInviteInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetApplyInviteInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetApplyInviteInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetBranchAuthDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetBranchAuthDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetBranchAuthDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetLatestDingIndexHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetLatestDingIndexResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetUserHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetUserResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListManagementGroupsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListManagementGroupsRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListManagementGroupsResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\QueryResourceManagementMembersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\QueryResourceManagementMembersResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\QueryUserManagementResourcesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\QueryUserManagementResourcesResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\UpdateManagementGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\UpdateManagementGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\UpdateManagementGroupResponse;
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

        return UpdateManagementGroupResponse::fromMap($this->doROARequest('UpdateManagementGroup', 'contact_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/contact/managementGroups/' . $groupId . '', 'none', $req, $runtime));
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
}
