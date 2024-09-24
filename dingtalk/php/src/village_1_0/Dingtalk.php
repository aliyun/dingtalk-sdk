<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\GetDeptHeaders;
use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\GetDeptRequest;
use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\GetDeptResponse;
use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\GetResidentDeptHeaders;
use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\GetResidentDeptRequest;
use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\GetResidentDeptResponse;
use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\GetResidentUserInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\GetResidentUserInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\GetResidentUserInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\GetUserByUnionIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\GetUserByUnionIdRequest;
use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\GetUserByUnionIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\GetUserHeaders;
use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\GetUserRequest;
use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\GetUserResponse;
use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\GetVillageOrgInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\GetVillageOrgInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\ListDeptSimpleUsersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\ListDeptSimpleUsersRequest;
use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\ListDeptSimpleUsersResponse;
use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\ListDeptUserIdsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\ListDeptUserIdsRequest;
use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\ListDeptUserIdsResponse;
use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\ListDeptUsersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\ListDeptUsersRequest;
use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\ListDeptUsersResponse;
use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\ListParentByDeptHeaders;
use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\ListParentByDeptRequest;
use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\ListParentByDeptResponse;
use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\ListParentByUserHeaders;
use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\ListParentByUserRequest;
use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\ListParentByUserResponse;
use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\ListResidentDeptUsersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\ListResidentDeptUsersRequest;
use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\ListResidentDeptUsersResponse;
use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\ListResidentSubDeptsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\ListResidentSubDeptsRequest;
use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\ListResidentSubDeptsResponse;
use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\ListResidentUserInfosHeaders;
use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\ListResidentUserInfosRequest;
use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\ListResidentUserInfosResponse;
use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\ListResidentUserInfosShrinkRequest;
use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\ListSimpleUsersByRoleHeaders;
use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\ListSimpleUsersByRoleRequest;
use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\ListSimpleUsersByRoleResponse;
use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\ListSubCorpsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\ListSubCorpsRequest;
use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\ListSubCorpsResponse;
use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\ListSubDeptHeaders;
use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\ListSubDeptIdsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\ListSubDeptIdsRequest;
use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\ListSubDeptIdsResponse;
use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\ListSubDeptRequest;
use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\ListSubDeptResponse;
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
        $this->_productId    = 'dingtalk';
        $gatewayClient       = new Client();
        $this->_spi          = $gatewayClient;
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @summary 获取部门详情
     *  *
     * @param string         $departmentId
     * @param GetDeptRequest $request      GetDeptRequest
     * @param GetDeptHeaders $headers      GetDeptHeaders
     * @param RuntimeOptions $runtime      runtime options for this request RuntimeOptions
     *
     * @return GetDeptResponse GetDeptResponse
     */
    public function getDeptWithOptions($departmentId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->language)) {
            $query['language'] = $request->language;
        }
        if (!Utils::isUnset($request->subCorpId)) {
            $query['subCorpId'] = $request->subCorpId;
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
            'action'      => 'GetDept',
            'version'     => 'village_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/village/deptartments/' . $departmentId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return GetDeptResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取部门详情
     *  *
     * @param string         $departmentId
     * @param GetDeptRequest $request      GetDeptRequest
     *
     * @return GetDeptResponse GetDeptResponse
     */
    public function getDept($departmentId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetDeptHeaders([]);

        return $this->getDeptWithOptions($departmentId, $request, $headers, $runtime);
    }

    /**
     * @summary 居民通讯录获取部门信息
     *  *
     * @param string                 $departmentId
     * @param GetResidentDeptRequest $request      GetResidentDeptRequest
     * @param GetResidentDeptHeaders $headers      GetResidentDeptHeaders
     * @param RuntimeOptions         $runtime      runtime options for this request RuntimeOptions
     *
     * @return GetResidentDeptResponse GetResidentDeptResponse
     */
    public function getResidentDeptWithOptions($departmentId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->subCorpId)) {
            $query['subCorpId'] = $request->subCorpId;
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
            'action'      => 'GetResidentDept',
            'version'     => 'village_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/village/residentDepartments/departments/' . $departmentId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return GetResidentDeptResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 居民通讯录获取部门信息
     *  *
     * @param string                 $departmentId
     * @param GetResidentDeptRequest $request      GetResidentDeptRequest
     *
     * @return GetResidentDeptResponse GetResidentDeptResponse
     */
    public function getResidentDept($departmentId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetResidentDeptHeaders([]);

        return $this->getResidentDeptWithOptions($departmentId, $request, $headers, $runtime);
    }

    /**
     * @summary 居民通讯录获取部门下某个人的详细信息
     *  *
     * @param string                     $departmentId
     * @param string                     $userId
     * @param GetResidentUserInfoRequest $request      GetResidentUserInfoRequest
     * @param GetResidentUserInfoHeaders $headers      GetResidentUserInfoHeaders
     * @param RuntimeOptions             $runtime      runtime options for this request RuntimeOptions
     *
     * @return GetResidentUserInfoResponse GetResidentUserInfoResponse
     */
    public function getResidentUserInfoWithOptions($departmentId, $userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->subCorpId)) {
            $query['subCorpId'] = $request->subCorpId;
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
            'action'      => 'GetResidentUserInfo',
            'version'     => 'village_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/village/residentDepartments/' . $departmentId . '/users/' . $userId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return GetResidentUserInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 居民通讯录获取部门下某个人的详细信息
     *  *
     * @param string                     $departmentId
     * @param string                     $userId
     * @param GetResidentUserInfoRequest $request      GetResidentUserInfoRequest
     *
     * @return GetResidentUserInfoResponse GetResidentUserInfoResponse
     */
    public function getResidentUserInfo($departmentId, $userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetResidentUserInfoHeaders([]);

        return $this->getResidentUserInfoWithOptions($departmentId, $userId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询用户详情
     *  *
     * @param string         $userId
     * @param GetUserRequest $request GetUserRequest
     * @param GetUserHeaders $headers GetUserHeaders
     * @param RuntimeOptions $runtime runtime options for this request RuntimeOptions
     *
     * @return GetUserResponse GetUserResponse
     */
    public function getUserWithOptions($userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->language)) {
            $query['language'] = $request->language;
        }
        if (!Utils::isUnset($request->subCorpId)) {
            $query['subCorpId'] = $request->subCorpId;
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
            'action'      => 'GetUser',
            'version'     => 'village_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/village/users/getByUserId',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return GetUserResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询用户详情
     *  *
     * @param string         $userId
     * @param GetUserRequest $request GetUserRequest
     *
     * @return GetUserResponse GetUserResponse
     */
    public function getUser($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetUserHeaders([]);

        return $this->getUserWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @summary 根据unionId查询用户详情
     *  *
     * @param GetUserByUnionIdRequest $request GetUserByUnionIdRequest
     * @param GetUserByUnionIdHeaders $headers GetUserByUnionIdHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return GetUserByUnionIdResponse GetUserByUnionIdResponse
     */
    public function getUserByUnionIdWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->language)) {
            $query['language'] = $request->language;
        }
        if (!Utils::isUnset($request->subCorpId)) {
            $query['subCorpId'] = $request->subCorpId;
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
            'action'      => 'GetUserByUnionId',
            'version'     => 'village_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/village/users/getByUnionId',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return GetUserByUnionIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据unionId查询用户详情
     *  *
     * @param GetUserByUnionIdRequest $request GetUserByUnionIdRequest
     *
     * @return GetUserByUnionIdResponse GetUserByUnionIdResponse
     */
    public function getUserByUnionId($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetUserByUnionIdHeaders([]);

        return $this->getUserByUnionIdWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取对外开放的企业信息
     *  *
     * @param string                   $subCorpId
     * @param GetVillageOrgInfoHeaders $headers   GetVillageOrgInfoHeaders
     * @param RuntimeOptions           $runtime   runtime options for this request RuntimeOptions
     *
     * @return GetVillageOrgInfoResponse GetVillageOrgInfoResponse
     */
    public function getVillageOrgInfoWithOptions($subCorpId, $headers, $runtime)
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
            'action'      => 'GetVillageOrgInfo',
            'version'     => 'village_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/village/corps/' . $subCorpId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return GetVillageOrgInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取对外开放的企业信息
     *  *
     * @param string $subCorpId
     *
     * @return GetVillageOrgInfoResponse GetVillageOrgInfoResponse
     */
    public function getVillageOrgInfo($subCorpId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetVillageOrgInfoHeaders([]);

        return $this->getVillageOrgInfoWithOptions($subCorpId, $headers, $runtime);
    }

    /**
     * @summary 查询部门下简略用户列表
     *  *
     * @param string                     $departmentId
     * @param ListDeptSimpleUsersRequest $request      ListDeptSimpleUsersRequest
     * @param ListDeptSimpleUsersHeaders $headers      ListDeptSimpleUsersHeaders
     * @param RuntimeOptions             $runtime      runtime options for this request RuntimeOptions
     *
     * @return ListDeptSimpleUsersResponse ListDeptSimpleUsersResponse
     */
    public function listDeptSimpleUsersWithOptions($departmentId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->containAccessLimit)) {
            $query['containAccessLimit'] = $request->containAccessLimit;
        }
        if (!Utils::isUnset($request->cursor)) {
            $query['cursor'] = $request->cursor;
        }
        if (!Utils::isUnset($request->language)) {
            $query['language'] = $request->language;
        }
        if (!Utils::isUnset($request->orderField)) {
            $query['orderField'] = $request->orderField;
        }
        if (!Utils::isUnset($request->size)) {
            $query['size'] = $request->size;
        }
        if (!Utils::isUnset($request->subCorpId)) {
            $query['subCorpId'] = $request->subCorpId;
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
            'action'      => 'ListDeptSimpleUsers',
            'version'     => 'village_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/village/departments/' . $departmentId . '/simpleUsers',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return ListDeptSimpleUsersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询部门下简略用户列表
     *  *
     * @param string                     $departmentId
     * @param ListDeptSimpleUsersRequest $request      ListDeptSimpleUsersRequest
     *
     * @return ListDeptSimpleUsersResponse ListDeptSimpleUsersResponse
     */
    public function listDeptSimpleUsers($departmentId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListDeptSimpleUsersHeaders([]);

        return $this->listDeptSimpleUsersWithOptions($departmentId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询部门下userid列表
     *  *
     * @param string                 $departmentId
     * @param ListDeptUserIdsRequest $request      ListDeptUserIdsRequest
     * @param ListDeptUserIdsHeaders $headers      ListDeptUserIdsHeaders
     * @param RuntimeOptions         $runtime      runtime options for this request RuntimeOptions
     *
     * @return ListDeptUserIdsResponse ListDeptUserIdsResponse
     */
    public function listDeptUserIdsWithOptions($departmentId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->subCorpId)) {
            $query['subCorpId'] = $request->subCorpId;
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
            'action'      => 'ListDeptUserIds',
            'version'     => 'village_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/village/departments/' . $departmentId . '/userIds',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return ListDeptUserIdsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询部门下userid列表
     *  *
     * @param string                 $departmentId
     * @param ListDeptUserIdsRequest $request      ListDeptUserIdsRequest
     *
     * @return ListDeptUserIdsResponse ListDeptUserIdsResponse
     */
    public function listDeptUserIds($departmentId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListDeptUserIdsHeaders([]);

        return $this->listDeptUserIdsWithOptions($departmentId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询部门下user完整信息
     *  *
     * @param string               $departmentId
     * @param ListDeptUsersRequest $request      ListDeptUsersRequest
     * @param ListDeptUsersHeaders $headers      ListDeptUsersHeaders
     * @param RuntimeOptions       $runtime      runtime options for this request RuntimeOptions
     *
     * @return ListDeptUsersResponse ListDeptUsersResponse
     */
    public function listDeptUsersWithOptions($departmentId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->containAccessLimit)) {
            $query['containAccessLimit'] = $request->containAccessLimit;
        }
        if (!Utils::isUnset($request->cursor)) {
            $query['cursor'] = $request->cursor;
        }
        if (!Utils::isUnset($request->language)) {
            $query['language'] = $request->language;
        }
        if (!Utils::isUnset($request->orderField)) {
            $query['orderField'] = $request->orderField;
        }
        if (!Utils::isUnset($request->size)) {
            $query['size'] = $request->size;
        }
        if (!Utils::isUnset($request->subCorpId)) {
            $query['subCorpId'] = $request->subCorpId;
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
            'action'      => 'ListDeptUsers',
            'version'     => 'village_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/village/departments/' . $departmentId . '/users',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return ListDeptUsersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询部门下user完整信息
     *  *
     * @param string               $departmentId
     * @param ListDeptUsersRequest $request      ListDeptUsersRequest
     *
     * @return ListDeptUsersResponse ListDeptUsersResponse
     */
    public function listDeptUsers($departmentId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListDeptUsersHeaders([]);

        return $this->listDeptUsersWithOptions($departmentId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询部门所有父部门列表
     *  *
     * @param ListParentByDeptRequest $request ListParentByDeptRequest
     * @param ListParentByDeptHeaders $headers ListParentByDeptHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return ListParentByDeptResponse ListParentByDeptResponse
     */
    public function listParentByDeptWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->departmentId)) {
            $query['departmentId'] = $request->departmentId;
        }
        if (!Utils::isUnset($request->subCorpId)) {
            $query['subCorpId'] = $request->subCorpId;
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
            'action'      => 'ListParentByDept',
            'version'     => 'village_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/village/departments/listParentByDepartment',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return ListParentByDeptResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询部门所有父部门列表
     *  *
     * @param ListParentByDeptRequest $request ListParentByDeptRequest
     *
     * @return ListParentByDeptResponse ListParentByDeptResponse
     */
    public function listParentByDept($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListParentByDeptHeaders([]);

        return $this->listParentByDeptWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询用户所有父部门列表
     *  *
     * @param ListParentByUserRequest $request ListParentByUserRequest
     * @param ListParentByUserHeaders $headers ListParentByUserHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return ListParentByUserResponse ListParentByUserResponse
     */
    public function listParentByUserWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->subCorpId)) {
            $query['subCorpId'] = $request->subCorpId;
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'ListParentByUser',
            'version'     => 'village_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/village/departments/listParentByUser',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return ListParentByUserResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询用户所有父部门列表
     *  *
     * @param ListParentByUserRequest $request ListParentByUserRequest
     *
     * @return ListParentByUserResponse ListParentByUserResponse
     */
    public function listParentByUser($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListParentByUserHeaders([]);

        return $this->listParentByUserWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 居民通讯录获取部门下人员信息
     *  *
     * @param string                       $departmentId
     * @param ListResidentDeptUsersRequest $request      ListResidentDeptUsersRequest
     * @param ListResidentDeptUsersHeaders $headers      ListResidentDeptUsersHeaders
     * @param RuntimeOptions               $runtime      runtime options for this request RuntimeOptions
     *
     * @return ListResidentDeptUsersResponse ListResidentDeptUsersResponse
     */
    public function listResidentDeptUsersWithOptions($departmentId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->cursor)) {
            $query['cursor'] = $request->cursor;
        }
        if (!Utils::isUnset($request->role)) {
            $query['role'] = $request->role;
        }
        if (!Utils::isUnset($request->size)) {
            $query['size'] = $request->size;
        }
        if (!Utils::isUnset($request->subCorpId)) {
            $query['subCorpId'] = $request->subCorpId;
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
            'action'      => 'ListResidentDeptUsers',
            'version'     => 'village_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/village/residentDepartments/' . $departmentId . '/users',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return ListResidentDeptUsersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 居民通讯录获取部门下人员信息
     *  *
     * @param string                       $departmentId
     * @param ListResidentDeptUsersRequest $request      ListResidentDeptUsersRequest
     *
     * @return ListResidentDeptUsersResponse ListResidentDeptUsersResponse
     */
    public function listResidentDeptUsers($departmentId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListResidentDeptUsersHeaders([]);

        return $this->listResidentDeptUsersWithOptions($departmentId, $request, $headers, $runtime);
    }

    /**
     * @summary 居民通讯录获取子部门列表
     *  *
     * @param string                      $departmentId
     * @param ListResidentSubDeptsRequest $request      ListResidentSubDeptsRequest
     * @param ListResidentSubDeptsHeaders $headers      ListResidentSubDeptsHeaders
     * @param RuntimeOptions              $runtime      runtime options for this request RuntimeOptions
     *
     * @return ListResidentSubDeptsResponse ListResidentSubDeptsResponse
     */
    public function listResidentSubDeptsWithOptions($departmentId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->cursor)) {
            $query['cursor'] = $request->cursor;
        }
        if (!Utils::isUnset($request->size)) {
            $query['size'] = $request->size;
        }
        if (!Utils::isUnset($request->subCorpId)) {
            $query['subCorpId'] = $request->subCorpId;
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
            'action'      => 'ListResidentSubDepts',
            'version'     => 'village_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/village/residentDepartments/' . $departmentId . '/subDepartments',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return ListResidentSubDeptsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 居民通讯录获取子部门列表
     *  *
     * @param string                      $departmentId
     * @param ListResidentSubDeptsRequest $request      ListResidentSubDeptsRequest
     *
     * @return ListResidentSubDeptsResponse ListResidentSubDeptsResponse
     */
    public function listResidentSubDepts($departmentId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListResidentSubDeptsHeaders([]);

        return $this->listResidentSubDeptsWithOptions($departmentId, $request, $headers, $runtime);
    }

    /**
     * @summary 居民通讯录批量获取用户详细信息
     *  *
     * @param ListResidentUserInfosRequest $tmpReq  ListResidentUserInfosRequest
     * @param ListResidentUserInfosHeaders $headers ListResidentUserInfosHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return ListResidentUserInfosResponse ListResidentUserInfosResponse
     */
    public function listResidentUserInfosWithOptions($tmpReq, $headers, $runtime)
    {
        Utils::validateModel($tmpReq);
        $request = new ListResidentUserInfosShrinkRequest([]);
        OpenApiUtilClient::convert($tmpReq, $request);
        if (!Utils::isUnset($tmpReq->userIds)) {
            $request->userIdsShrink = OpenApiUtilClient::arrayToStringWithSpecifiedStyle($tmpReq->userIds, 'userIds', 'json');
        }
        $query = [];
        if (!Utils::isUnset($request->subCorpId)) {
            $query['subCorpId'] = $request->subCorpId;
        }
        if (!Utils::isUnset($request->userIdsShrink)) {
            $query['userIds'] = $request->userIdsShrink;
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
            'action'      => 'ListResidentUserInfos',
            'version'     => 'village_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/village/residentUsers/getByUserIds',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return ListResidentUserInfosResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 居民通讯录批量获取用户详细信息
     *  *
     * @param ListResidentUserInfosRequest $request ListResidentUserInfosRequest
     *
     * @return ListResidentUserInfosResponse ListResidentUserInfosResponse
     */
    public function listResidentUserInfos($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListResidentUserInfosHeaders([]);

        return $this->listResidentUserInfosWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 根据角色获取用户列表
     *  *
     * @param ListSimpleUsersByRoleRequest $request ListSimpleUsersByRoleRequest
     * @param ListSimpleUsersByRoleHeaders $headers ListSimpleUsersByRoleHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return ListSimpleUsersByRoleResponse ListSimpleUsersByRoleResponse
     */
    public function listSimpleUsersByRoleWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->offset)) {
            $query['offset'] = $request->offset;
        }
        if (!Utils::isUnset($request->roleId)) {
            $query['roleId'] = $request->roleId;
        }
        if (!Utils::isUnset($request->size)) {
            $query['size'] = $request->size;
        }
        if (!Utils::isUnset($request->subCorpId)) {
            $query['subCorpId'] = $request->subCorpId;
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
            'action'      => 'ListSimpleUsersByRole',
            'version'     => 'village_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/village/users/listByRole',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return ListSimpleUsersByRoleResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据角色获取用户列表
     *  *
     * @param ListSimpleUsersByRoleRequest $request ListSimpleUsersByRoleRequest
     *
     * @return ListSimpleUsersByRoleResponse ListSimpleUsersByRoleResponse
     */
    public function listSimpleUsersByRole($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListSimpleUsersByRoleHeaders([]);

        return $this->listSimpleUsersByRoleWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取下级指定区域层级组织
     *  *
     * @param ListSubCorpsRequest $request ListSubCorpsRequest
     * @param ListSubCorpsHeaders $headers ListSubCorpsHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return ListSubCorpsResponse ListSubCorpsResponse
     */
    public function listSubCorpsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->isOnlyDirect)) {
            $query['isOnlyDirect'] = $request->isOnlyDirect;
        }
        if (!Utils::isUnset($request->subCorpId)) {
            $query['subCorpId'] = $request->subCorpId;
        }
        if (!Utils::isUnset($request->types)) {
            $query['types'] = $request->types;
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
            'action'      => 'ListSubCorps',
            'version'     => 'village_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/village/corps/subCorps',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return ListSubCorpsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取下级指定区域层级组织
     *  *
     * @param ListSubCorpsRequest $request ListSubCorpsRequest
     *
     * @return ListSubCorpsResponse ListSubCorpsResponse
     */
    public function listSubCorps($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListSubCorpsHeaders([]);

        return $this->listSubCorpsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询子部门列表
     *  *
     * @param string             $departmentId
     * @param ListSubDeptRequest $request      ListSubDeptRequest
     * @param ListSubDeptHeaders $headers      ListSubDeptHeaders
     * @param RuntimeOptions     $runtime      runtime options for this request RuntimeOptions
     *
     * @return ListSubDeptResponse ListSubDeptResponse
     */
    public function listSubDeptWithOptions($departmentId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->language)) {
            $query['language'] = $request->language;
        }
        if (!Utils::isUnset($request->subCorpId)) {
            $query['subCorpId'] = $request->subCorpId;
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
            'action'      => 'ListSubDept',
            'version'     => 'village_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/village/departments/' . $departmentId . '/subDepartments',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return ListSubDeptResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询子部门列表
     *  *
     * @param string             $departmentId
     * @param ListSubDeptRequest $request      ListSubDeptRequest
     *
     * @return ListSubDeptResponse ListSubDeptResponse
     */
    public function listSubDept($departmentId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListSubDeptHeaders([]);

        return $this->listSubDeptWithOptions($departmentId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询部门下的子部门ID列表，不会递归查询，只包含ID
     *  *
     * @param string                $departmentId
     * @param ListSubDeptIdsRequest $request      ListSubDeptIdsRequest
     * @param ListSubDeptIdsHeaders $headers      ListSubDeptIdsHeaders
     * @param RuntimeOptions        $runtime      runtime options for this request RuntimeOptions
     *
     * @return ListSubDeptIdsResponse ListSubDeptIdsResponse
     */
    public function listSubDeptIdsWithOptions($departmentId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->subCorpId)) {
            $query['subCorpId'] = $request->subCorpId;
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
            'action'      => 'ListSubDeptIds',
            'version'     => 'village_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/village/departments/' . $departmentId . '/subDepartmentIds',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return ListSubDeptIdsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询部门下的子部门ID列表，不会递归查询，只包含ID
     *  *
     * @param string                $departmentId
     * @param ListSubDeptIdsRequest $request      ListSubDeptIdsRequest
     *
     * @return ListSubDeptIdsResponse ListSubDeptIdsResponse
     */
    public function listSubDeptIds($departmentId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListSubDeptIdsHeaders([]);

        return $this->listSubDeptIdsWithOptions($departmentId, $request, $headers, $runtime);
    }
}
