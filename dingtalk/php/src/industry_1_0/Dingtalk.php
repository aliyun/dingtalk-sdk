<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
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
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserExtInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserExtInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserRolesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserRolesResponse;
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
