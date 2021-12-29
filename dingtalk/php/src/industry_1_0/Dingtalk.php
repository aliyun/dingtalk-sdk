<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureCostRecordListGetHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureCostRecordListGetRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureCostRecordListGetResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureFeeListGetHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureFeeListGetRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureFeeListGetResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureLabourCostHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureLabourCostRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureLabourCostResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureMaterialListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureMaterialListRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureMaterialListResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryMmanufactureMaterialCostGetHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryMmanufactureMaterialCostGetRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryMmanufactureMaterialCostGetResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllDepartmentHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllDepartmentRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllDepartmentResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllDoctorsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllDoctorsRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllDoctorsResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllGroupsInDeptHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllGroupsInDeptRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllGroupsInDeptResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllMemberByDeptHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllMemberByDeptRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllMemberByDeptResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllMemberByGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllMemberByGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllMemberByGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryBizOptLogHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryBizOptLogRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryBizOptLogResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryDepartmentInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryDepartmentInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryGroupInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryGroupInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryHospitalDistrictInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryHospitalDistrictInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryHospitalDistrictInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryHospitalRolesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryHospitalRolesResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryHospitalRoleUserInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryHospitalRoleUserInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryHospitalRoleUserInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryJobCodeDictionaryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryJobCodeDictionaryResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryJobStatusCodeDictionaryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryJobStatusCodeDictionaryResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserExtInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserExtInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserProbCodeDictionaryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserProbCodeDictionaryResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserRolesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserRolesResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\UpdateUserExtendInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\UpdateUserExtendInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\UpdateUserExtendInfoResponse;
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
     * @param QueryHospitalDistrictInfoRequest $request
     *
     * @return QueryHospitalDistrictInfoResponse
     */
    public function queryHospitalDistrictInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryHospitalDistrictInfoHeaders([]);

        return $this->queryHospitalDistrictInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryHospitalDistrictInfoRequest $request
     * @param QueryHospitalDistrictInfoHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return QueryHospitalDistrictInfoResponse
     */
    public function queryHospitalDistrictInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            @$query['pageNumber'] = $request->pageNumber;
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

        return QueryHospitalDistrictInfoResponse::fromMap($this->doROARequest('QueryHospitalDistrictInfo', 'industry_1.0', 'HTTP', 'GET', 'AK', '/v1.0/industry/medicals/districts', 'json', $req, $runtime));
    }

    /**
     * @param string $userId
     *
     * @return QueryUserInfoResponse
     */
    public function queryUserInfo($userId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryUserInfoHeaders([]);

        return $this->queryUserInfoWithOptions($userId, $headers, $runtime);
    }

    /**
     * @param string               $userId
     * @param QueryUserInfoHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return QueryUserInfoResponse
     */
    public function queryUserInfoWithOptions($userId, $headers, $runtime)
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

        return QueryUserInfoResponse::fromMap($this->doROARequest('QueryUserInfo', 'industry_1.0', 'HTTP', 'GET', 'AK', '/v1.0/industry/medicals/users/' . $userId . '', 'json', $req, $runtime));
    }

    /**
     * @param IndustryManufactureCostRecordListGetRequest $request
     *
     * @return IndustryManufactureCostRecordListGetResponse
     */
    public function industryManufactureCostRecordListGet($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new IndustryManufactureCostRecordListGetHeaders([]);

        return $this->industryManufactureCostRecordListGetWithOptions($request, $headers, $runtime);
    }

    /**
     * @param IndustryManufactureCostRecordListGetRequest $request
     * @param IndustryManufactureCostRecordListGetHeaders $headers
     * @param RuntimeOptions                              $runtime
     *
     * @return IndustryManufactureCostRecordListGetResponse
     */
    public function industryManufactureCostRecordListGetWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->instanceId)) {
            @$body['instanceId'] = $request->instanceId;
        }
        if (!Utils::isUnset($request->materialNo)) {
            @$body['materialNo'] = $request->materialNo;
        }
        if (!Utils::isUnset($request->orderNo)) {
            @$body['orderNo'] = $request->orderNo;
        }
        if (!Utils::isUnset($request->productionTaskNo)) {
            @$body['productionTaskNo'] = $request->productionTaskNo;
        }
        if (!Utils::isUnset($request->startTime)) {
            @$body['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->endTime)) {
            @$body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->cursor)) {
            @$body['cursor'] = $request->cursor;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            @$body['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->tokenGrantType)) {
            @$body['tokenGrantType'] = $request->tokenGrantType;
        }
        if (!Utils::isUnset($request->orgId)) {
            @$body['orgId'] = $request->orgId;
        }
        if (!Utils::isUnset($request->corpId)) {
            @$body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->isvOrgId)) {
            @$body['isvOrgId'] = $request->isvOrgId;
        }
        if (!Utils::isUnset($request->suiteKey)) {
            @$body['suiteKey'] = $request->suiteKey;
        }
        if (!Utils::isUnset($request->microappAgentId)) {
            @$body['microappAgentId'] = $request->microappAgentId;
        }
        if (!Utils::isUnset($request->appIds)) {
            @$body['appIds'] = $request->appIds;
        }
        if (!Utils::isUnset($request->appId)) {
            @$body['appId'] = $request->appId;
        }
        if (!Utils::isUnset($request->appName)) {
            @$body['appName'] = $request->appName;
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

        return IndustryManufactureCostRecordListGetResponse::fromMap($this->doROARequest('IndustryManufactureCostRecordListGet', 'industry_1.0', 'HTTP', 'POST', 'AK', '/v1.0/industry/manufactures/materialCostRecords/query', 'json', $req, $runtime));
    }

    /**
     * @param string                      $deptId
     * @param QueryAllMemberByDeptRequest $request
     *
     * @return QueryAllMemberByDeptResponse
     */
    public function queryAllMemberByDept($deptId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryAllMemberByDeptHeaders([]);

        return $this->queryAllMemberByDeptWithOptions($deptId, $request, $headers, $runtime);
    }

    /**
     * @param string                      $deptId
     * @param QueryAllMemberByDeptRequest $request
     * @param QueryAllMemberByDeptHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return QueryAllMemberByDeptResponse
     */
    public function queryAllMemberByDeptWithOptions($deptId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            @$query['pageNumber'] = $request->pageNumber;
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

        return QueryAllMemberByDeptResponse::fromMap($this->doROARequest('QueryAllMemberByDept', 'industry_1.0', 'HTTP', 'GET', 'AK', '/v1.0/industry/medicals/departments/' . $deptId . '/members', 'json', $req, $runtime));
    }

    /**
     * @param string                       $groupId
     * @param QueryAllMemberByGroupRequest $request
     *
     * @return QueryAllMemberByGroupResponse
     */
    public function queryAllMemberByGroup($groupId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryAllMemberByGroupHeaders([]);

        return $this->queryAllMemberByGroupWithOptions($groupId, $request, $headers, $runtime);
    }

    /**
     * @param string                       $groupId
     * @param QueryAllMemberByGroupRequest $request
     * @param QueryAllMemberByGroupHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return QueryAllMemberByGroupResponse
     */
    public function queryAllMemberByGroupWithOptions($groupId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            @$query['pageNumber'] = $request->pageNumber;
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

        return QueryAllMemberByGroupResponse::fromMap($this->doROARequest('QueryAllMemberByGroup', 'industry_1.0', 'HTTP', 'GET', 'AK', '/v1.0/industry/medicals/groups/' . $groupId . '/members', 'json', $req, $runtime));
    }

    /**
     * @param string $userId
     *
     * @return QueryUserRolesResponse
     */
    public function queryUserRoles($userId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryUserRolesHeaders([]);

        return $this->queryUserRolesWithOptions($userId, $headers, $runtime);
    }

    /**
     * @param string                $userId
     * @param QueryUserRolesHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return QueryUserRolesResponse
     */
    public function queryUserRolesWithOptions($userId, $headers, $runtime)
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

        return QueryUserRolesResponse::fromMap($this->doROARequest('QueryUserRoles', 'industry_1.0', 'HTTP', 'GET', 'AK', '/v1.0/industry/medicals/users/' . $userId . '/roles', 'json', $req, $runtime));
    }

    /**
     * @return QueryHospitalRolesResponse
     */
    public function queryHospitalRoles()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryHospitalRolesHeaders([]);

        return $this->queryHospitalRolesWithOptions($headers, $runtime);
    }

    /**
     * @param QueryHospitalRolesHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return QueryHospitalRolesResponse
     */
    public function queryHospitalRolesWithOptions($headers, $runtime)
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

        return QueryHospitalRolesResponse::fromMap($this->doROARequest('QueryHospitalRoles', 'industry_1.0', 'HTTP', 'GET', 'AK', '/v1.0/industry/medicals/roles', 'json', $req, $runtime));
    }

    /**
     * @param QueryAllGroupRequest $request
     *
     * @return QueryAllGroupResponse
     */
    public function queryAllGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryAllGroupHeaders([]);

        return $this->queryAllGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryAllGroupRequest $request
     * @param QueryAllGroupHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return QueryAllGroupResponse
     */
    public function queryAllGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            @$query['pageNumber'] = $request->pageNumber;
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

        return QueryAllGroupResponse::fromMap($this->doROARequest('QueryAllGroup', 'industry_1.0', 'HTTP', 'GET', 'AK', '/v1.0/industry/medicals/groups', 'json', $req, $runtime));
    }

    /**
     * @param string                      $deptId
     * @param QueryAllGroupsInDeptRequest $request
     *
     * @return QueryAllGroupsInDeptResponse
     */
    public function queryAllGroupsInDept($deptId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryAllGroupsInDeptHeaders([]);

        return $this->queryAllGroupsInDeptWithOptions($deptId, $request, $headers, $runtime);
    }

    /**
     * @param string                      $deptId
     * @param QueryAllGroupsInDeptRequest $request
     * @param QueryAllGroupsInDeptHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return QueryAllGroupsInDeptResponse
     */
    public function queryAllGroupsInDeptWithOptions($deptId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            @$query['pageNumber'] = $request->pageNumber;
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

        return QueryAllGroupsInDeptResponse::fromMap($this->doROARequest('QueryAllGroupsInDept', 'industry_1.0', 'HTTP', 'GET', 'AK', '/v1.0/industry/medicals/departments/' . $deptId . '/groups', 'json', $req, $runtime));
    }

    /**
     * @param QueryBizOptLogRequest $request
     *
     * @return QueryBizOptLogResponse
     */
    public function queryBizOptLog($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryBizOptLogHeaders([]);

        return $this->queryBizOptLogWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryBizOptLogRequest $request
     * @param QueryBizOptLogHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return QueryBizOptLogResponse
     */
    public function queryBizOptLogWithOptions($request, $headers, $runtime)
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

        return QueryBizOptLogResponse::fromMap($this->doROARequest('QueryBizOptLog', 'industry_1.0', 'HTTP', 'GET', 'AK', '/v1.0/industry/medicals/bizOptLogs', 'json', $req, $runtime));
    }

    /**
     * @param QueryHospitalRoleUserInfoRequest $request
     *
     * @return QueryHospitalRoleUserInfoResponse
     */
    public function queryHospitalRoleUserInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryHospitalRoleUserInfoHeaders([]);

        return $this->queryHospitalRoleUserInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryHospitalRoleUserInfoRequest $request
     * @param QueryHospitalRoleUserInfoHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return QueryHospitalRoleUserInfoResponse
     */
    public function queryHospitalRoleUserInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            @$query['pageNumber'] = $request->pageNumber;
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

        return QueryHospitalRoleUserInfoResponse::fromMap($this->doROARequest('QueryHospitalRoleUserInfo', 'industry_1.0', 'HTTP', 'GET', 'AK', '/v1.0/industry/medicals/roles/userInfos', 'json', $req, $runtime));
    }

    /**
     * @return QueryUserProbCodeDictionaryResponse
     */
    public function queryUserProbCodeDictionary()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryUserProbCodeDictionaryHeaders([]);

        return $this->queryUserProbCodeDictionaryWithOptions($headers, $runtime);
    }

    /**
     * @param QueryUserProbCodeDictionaryHeaders $headers
     * @param RuntimeOptions                     $runtime
     *
     * @return QueryUserProbCodeDictionaryResponse
     */
    public function queryUserProbCodeDictionaryWithOptions($headers, $runtime)
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

        return QueryUserProbCodeDictionaryResponse::fromMap($this->doROARequest('QueryUserProbCodeDictionary', 'industry_1.0', 'HTTP', 'GET', 'AK', '/v1.0/industry/medicals/userProbCodes', 'json', $req, $runtime));
    }

    /**
     * @return QueryJobStatusCodeDictionaryResponse
     */
    public function queryJobStatusCodeDictionary()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryJobStatusCodeDictionaryHeaders([]);

        return $this->queryJobStatusCodeDictionaryWithOptions($headers, $runtime);
    }

    /**
     * @param QueryJobStatusCodeDictionaryHeaders $headers
     * @param RuntimeOptions                      $runtime
     *
     * @return QueryJobStatusCodeDictionaryResponse
     */
    public function queryJobStatusCodeDictionaryWithOptions($headers, $runtime)
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

        return QueryJobStatusCodeDictionaryResponse::fromMap($this->doROARequest('QueryJobStatusCodeDictionary', 'industry_1.0', 'HTTP', 'GET', 'AK', '/v1.0/industry/medicals/jobStatusCodes', 'json', $req, $runtime));
    }

    /**
     * @param string $deptId
     *
     * @return QueryDepartmentInfoResponse
     */
    public function queryDepartmentInfo($deptId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryDepartmentInfoHeaders([]);

        return $this->queryDepartmentInfoWithOptions($deptId, $headers, $runtime);
    }

    /**
     * @param string                     $deptId
     * @param QueryDepartmentInfoHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return QueryDepartmentInfoResponse
     */
    public function queryDepartmentInfoWithOptions($deptId, $headers, $runtime)
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

        return QueryDepartmentInfoResponse::fromMap($this->doROARequest('QueryDepartmentInfo', 'industry_1.0', 'HTTP', 'GET', 'AK', '/v1.0/industry/medicals/departments/' . $deptId . '', 'json', $req, $runtime));
    }

    /**
     * @param IndustryManufactureMaterialListRequest $request
     *
     * @return IndustryManufactureMaterialListResponse
     */
    public function industryManufactureMaterialList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new IndustryManufactureMaterialListHeaders([]);

        return $this->industryManufactureMaterialListWithOptions($request, $headers, $runtime);
    }

    /**
     * @param IndustryManufactureMaterialListRequest $request
     * @param IndustryManufactureMaterialListHeaders $headers
     * @param RuntimeOptions                         $runtime
     *
     * @return IndustryManufactureMaterialListResponse
     */
    public function industryManufactureMaterialListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->tokenGrantType)) {
            @$body['tokenGrantType'] = $request->tokenGrantType;
        }
        if (!Utils::isUnset($request->corpId)) {
            @$body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->endTime)) {
            @$body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->instanceId)) {
            @$body['instanceId'] = $request->instanceId;
        }
        if (!Utils::isUnset($request->materialNo)) {
            @$body['materialNo'] = $request->materialNo;
        }
        if (!Utils::isUnset($request->startTime)) {
            @$body['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->microappAgentId)) {
            @$body['microappAgentId'] = $request->microappAgentId;
        }
        if (!Utils::isUnset($request->cursor)) {
            @$body['cursor'] = $request->cursor;
        }
        if (!Utils::isUnset($request->appName)) {
            @$body['appName'] = $request->appName;
        }
        if (!Utils::isUnset($request->orgId)) {
            @$body['orgId'] = $request->orgId;
        }
        if (!Utils::isUnset($request->appId)) {
            @$body['appId'] = $request->appId;
        }
        if (!Utils::isUnset($request->suiteKey)) {
            @$body['suiteKey'] = $request->suiteKey;
        }
        if (!Utils::isUnset($request->appIds)) {
            @$body['appIds'] = $request->appIds;
        }
        if (!Utils::isUnset($request->currentPage)) {
            @$body['currentPage'] = $request->currentPage;
        }
        if (!Utils::isUnset($request->isvOrgId)) {
            @$body['isvOrgId'] = $request->isvOrgId;
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

        return IndustryManufactureMaterialListResponse::fromMap($this->doROARequest('IndustryManufactureMaterialList', 'industry_1.0', 'HTTP', 'POST', 'AK', '/v1.0/industry/manufactures/materials/query', 'json', $req, $runtime));
    }

    /**
     * @param string                      $userId
     * @param UpdateUserExtendInfoRequest $request
     *
     * @return UpdateUserExtendInfoResponse
     */
    public function updateUserExtendInfo($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateUserExtendInfoHeaders([]);

        return $this->updateUserExtendInfoWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @param string                      $userId
     * @param UpdateUserExtendInfoRequest $request
     * @param UpdateUserExtendInfoHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return UpdateUserExtendInfoResponse
     */
    public function updateUserExtendInfoWithOptions($userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->jobCode)) {
            @$body['jobCode'] = $request->jobCode;
        }
        if (!Utils::isUnset($request->userProbCode)) {
            @$body['userProbCode'] = $request->userProbCode;
        }
        if (!Utils::isUnset($request->jobStatusCode)) {
            @$body['jobStatusCode'] = $request->jobStatusCode;
        }
        if (!Utils::isUnset($request->comments)) {
            @$body['comments'] = $request->comments;
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

        return UpdateUserExtendInfoResponse::fromMap($this->doROARequest('UpdateUserExtendInfo', 'industry_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/industry/medicals/users/' . $userId . '/extInfos', 'none', $req, $runtime));
    }

    /**
     * @param IndustryMmanufactureMaterialCostGetRequest $request
     *
     * @return IndustryMmanufactureMaterialCostGetResponse
     */
    public function industryMmanufactureMaterialCostGet($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new IndustryMmanufactureMaterialCostGetHeaders([]);

        return $this->industryMmanufactureMaterialCostGetWithOptions($request, $headers, $runtime);
    }

    /**
     * @param IndustryMmanufactureMaterialCostGetRequest $request
     * @param IndustryMmanufactureMaterialCostGetHeaders $headers
     * @param RuntimeOptions                             $runtime
     *
     * @return IndustryMmanufactureMaterialCostGetResponse
     */
    public function industryMmanufactureMaterialCostGetWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->instanceId)) {
            @$body['instanceId'] = $request->instanceId;
        }
        if (!Utils::isUnset($request->materialNo)) {
            @$body['materialNo'] = $request->materialNo;
        }
        if (!Utils::isUnset($request->startTime)) {
            @$body['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->endTime)) {
            @$body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->cursor)) {
            @$body['cursor'] = $request->cursor;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            @$body['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->tokenGrantType)) {
            @$body['tokenGrantType'] = $request->tokenGrantType;
        }
        if (!Utils::isUnset($request->orgId)) {
            @$body['orgId'] = $request->orgId;
        }
        if (!Utils::isUnset($request->corpId)) {
            @$body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->isvOrgId)) {
            @$body['isvOrgId'] = $request->isvOrgId;
        }
        if (!Utils::isUnset($request->suiteKey)) {
            @$body['suiteKey'] = $request->suiteKey;
        }
        if (!Utils::isUnset($request->microappAgentId)) {
            @$body['microappAgentId'] = $request->microappAgentId;
        }
        if (!Utils::isUnset($request->appIds)) {
            @$body['appIds'] = $request->appIds;
        }
        if (!Utils::isUnset($request->appId)) {
            @$body['appId'] = $request->appId;
        }
        if (!Utils::isUnset($request->appName)) {
            @$body['appName'] = $request->appName;
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

        return IndustryMmanufactureMaterialCostGetResponse::fromMap($this->doROARequest('IndustryMmanufactureMaterialCostGet', 'industry_1.0', 'HTTP', 'POST', 'AK', '/v1.0/industry/manufactures/base/materialCosts/query', 'json', $req, $runtime));
    }

    /**
     * @param IndustryManufactureFeeListGetRequest $request
     *
     * @return IndustryManufactureFeeListGetResponse
     */
    public function industryManufactureFeeListGet($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new IndustryManufactureFeeListGetHeaders([]);

        return $this->industryManufactureFeeListGetWithOptions($request, $headers, $runtime);
    }

    /**
     * @param IndustryManufactureFeeListGetRequest $request
     * @param IndustryManufactureFeeListGetHeaders $headers
     * @param RuntimeOptions                       $runtime
     *
     * @return IndustryManufactureFeeListGetResponse
     */
    public function industryManufactureFeeListGetWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->productionTaskNo)) {
            @$body['productionTaskNo'] = $request->productionTaskNo;
        }
        if (!Utils::isUnset($request->materialNo)) {
            @$body['materialNo'] = $request->materialNo;
        }
        if (!Utils::isUnset($request->type)) {
            @$body['type'] = $request->type;
        }
        if (!Utils::isUnset($request->startTime)) {
            @$body['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->endTime)) {
            @$body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->cursor)) {
            @$body['cursor'] = $request->cursor;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            @$body['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->tokenGrantType)) {
            @$body['tokenGrantType'] = $request->tokenGrantType;
        }
        if (!Utils::isUnset($request->orgId)) {
            @$body['orgId'] = $request->orgId;
        }
        if (!Utils::isUnset($request->corpId)) {
            @$body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->isvOrgId)) {
            @$body['isvOrgId'] = $request->isvOrgId;
        }
        if (!Utils::isUnset($request->suiteKey)) {
            @$body['suiteKey'] = $request->suiteKey;
        }
        if (!Utils::isUnset($request->microappAgentId)) {
            @$body['microappAgentId'] = $request->microappAgentId;
        }
        if (!Utils::isUnset($request->appIds)) {
            @$body['appIds'] = $request->appIds;
        }
        if (!Utils::isUnset($request->appId)) {
            @$body['appId'] = $request->appId;
        }
        if (!Utils::isUnset($request->appName)) {
            @$body['appName'] = $request->appName;
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

        return IndustryManufactureFeeListGetResponse::fromMap($this->doROARequest('IndustryManufactureFeeListGet', 'industry_1.0', 'HTTP', 'POST', 'AK', '/v1.0/industry/manufactures/fees/query', 'json', $req, $runtime));
    }

    /**
     * @param QueryAllDoctorsRequest $request
     *
     * @return QueryAllDoctorsResponse
     */
    public function queryAllDoctors($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryAllDoctorsHeaders([]);

        return $this->queryAllDoctorsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryAllDoctorsRequest $request
     * @param QueryAllDoctorsHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return QueryAllDoctorsResponse
     */
    public function queryAllDoctorsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->pageNum)) {
            @$query['pageNum'] = $request->pageNum;
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

        return QueryAllDoctorsResponse::fromMap($this->doROARequest('QueryAllDoctors', 'industry_1.0', 'HTTP', 'GET', 'AK', '/v1.0/industry/medicals/doctors', 'json', $req, $runtime));
    }

    /**
     * @param string $userId
     *
     * @return QueryUserExtInfoResponse
     */
    public function queryUserExtInfo($userId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryUserExtInfoHeaders([]);

        return $this->queryUserExtInfoWithOptions($userId, $headers, $runtime);
    }

    /**
     * @param string                  $userId
     * @param QueryUserExtInfoHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return QueryUserExtInfoResponse
     */
    public function queryUserExtInfoWithOptions($userId, $headers, $runtime)
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

        return QueryUserExtInfoResponse::fromMap($this->doROARequest('QueryUserExtInfo', 'industry_1.0', 'HTTP', 'GET', 'AK', '/v1.0/industry/medicals/users/' . $userId . '/extInfos', 'json', $req, $runtime));
    }

    /**
     * @return QueryJobCodeDictionaryResponse
     */
    public function queryJobCodeDictionary()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryJobCodeDictionaryHeaders([]);

        return $this->queryJobCodeDictionaryWithOptions($headers, $runtime);
    }

    /**
     * @param QueryJobCodeDictionaryHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return QueryJobCodeDictionaryResponse
     */
    public function queryJobCodeDictionaryWithOptions($headers, $runtime)
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

        return QueryJobCodeDictionaryResponse::fromMap($this->doROARequest('QueryJobCodeDictionary', 'industry_1.0', 'HTTP', 'GET', 'AK', '/v1.0/industry/medicals/jobCodes', 'json', $req, $runtime));
    }

    /**
     * @param QueryAllDepartmentRequest $request
     *
     * @return QueryAllDepartmentResponse
     */
    public function queryAllDepartment($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryAllDepartmentHeaders([]);

        return $this->queryAllDepartmentWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryAllDepartmentRequest $request
     * @param QueryAllDepartmentHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return QueryAllDepartmentResponse
     */
    public function queryAllDepartmentWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            @$query['pageNumber'] = $request->pageNumber;
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

        return QueryAllDepartmentResponse::fromMap($this->doROARequest('QueryAllDepartment', 'industry_1.0', 'HTTP', 'GET', 'AK', '/v1.0/industry/medicals/departments', 'json', $req, $runtime));
    }

    /**
     * @param IndustryManufactureLabourCostRequest $request
     *
     * @return IndustryManufactureLabourCostResponse
     */
    public function industryManufactureLabourCost($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new IndustryManufactureLabourCostHeaders([]);

        return $this->industryManufactureLabourCostWithOptions($request, $headers, $runtime);
    }

    /**
     * @param IndustryManufactureLabourCostRequest $request
     * @param IndustryManufactureLabourCostHeaders $headers
     * @param RuntimeOptions                       $runtime
     *
     * @return IndustryManufactureLabourCostResponse
     */
    public function industryManufactureLabourCostWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->processNo)) {
            @$body['processNo'] = $request->processNo;
        }
        if (!Utils::isUnset($request->materialNo)) {
            @$body['materialNo'] = $request->materialNo;
        }
        if (!Utils::isUnset($request->startTime)) {
            @$body['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->endTime)) {
            @$body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->cursor)) {
            @$body['cursor'] = $request->cursor;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            @$body['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->tokenGrantType)) {
            @$body['tokenGrantType'] = $request->tokenGrantType;
        }
        if (!Utils::isUnset($request->orgId)) {
            @$body['orgId'] = $request->orgId;
        }
        if (!Utils::isUnset($request->corpId)) {
            @$body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->isvOrgId)) {
            @$body['isvOrgId'] = $request->isvOrgId;
        }
        if (!Utils::isUnset($request->suiteKey)) {
            @$body['suiteKey'] = $request->suiteKey;
        }
        if (!Utils::isUnset($request->microappAgentId)) {
            @$body['microappAgentId'] = $request->microappAgentId;
        }
        if (!Utils::isUnset($request->appIds)) {
            @$body['appIds'] = $request->appIds;
        }
        if (!Utils::isUnset($request->appId)) {
            @$body['appId'] = $request->appId;
        }
        if (!Utils::isUnset($request->appName)) {
            @$body['appName'] = $request->appName;
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

        return IndustryManufactureLabourCostResponse::fromMap($this->doROARequest('IndustryManufactureLabourCost', 'industry_1.0', 'HTTP', 'POST', 'AK', '/v1.0/industry/manufactures/labourCosts/query', 'json', $req, $runtime));
    }

    /**
     * @param string $groupId
     *
     * @return QueryGroupInfoResponse
     */
    public function queryGroupInfo($groupId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryGroupInfoHeaders([]);

        return $this->queryGroupInfoWithOptions($groupId, $headers, $runtime);
    }

    /**
     * @param string                $groupId
     * @param QueryGroupInfoHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return QueryGroupInfoResponse
     */
    public function queryGroupInfoWithOptions($groupId, $headers, $runtime)
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

        return QueryGroupInfoResponse::fromMap($this->doROARequest('QueryGroupInfo', 'industry_1.0', 'HTTP', 'GET', 'AK', '/v1.0/industry/medicals/groups/' . $groupId . '', 'json', $req, $runtime));
    }
}
