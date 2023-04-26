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
     * @param string         $departmentId
     * @param GetDeptRequest $request
     * @param GetDeptHeaders $headers
     * @param RuntimeOptions $runtime
     *
     * @return GetDeptResponse
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
     * @param string         $departmentId
     * @param GetDeptRequest $request
     *
     * @return GetDeptResponse
     */
    public function getDept($departmentId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetDeptHeaders([]);

        return $this->getDeptWithOptions($departmentId, $request, $headers, $runtime);
    }

    /**
     * @param string                 $departmentId
     * @param GetResidentDeptRequest $request
     * @param GetResidentDeptHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return GetResidentDeptResponse
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
     * @param string                 $departmentId
     * @param GetResidentDeptRequest $request
     *
     * @return GetResidentDeptResponse
     */
    public function getResidentDept($departmentId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetResidentDeptHeaders([]);

        return $this->getResidentDeptWithOptions($departmentId, $request, $headers, $runtime);
    }

    /**
     * @param string                     $departmentId
     * @param string                     $userId
     * @param GetResidentUserInfoRequest $request
     * @param GetResidentUserInfoHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return GetResidentUserInfoResponse
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
     * @param string                     $departmentId
     * @param string                     $userId
     * @param GetResidentUserInfoRequest $request
     *
     * @return GetResidentUserInfoResponse
     */
    public function getResidentUserInfo($departmentId, $userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetResidentUserInfoHeaders([]);

        return $this->getResidentUserInfoWithOptions($departmentId, $userId, $request, $headers, $runtime);
    }

    /**
     * @param string         $userId
     * @param GetUserRequest $request
     * @param GetUserHeaders $headers
     * @param RuntimeOptions $runtime
     *
     * @return GetUserResponse
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
     * @param string         $userId
     * @param GetUserRequest $request
     *
     * @return GetUserResponse
     */
    public function getUser($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetUserHeaders([]);

        return $this->getUserWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @param GetUserByUnionIdRequest $request
     * @param GetUserByUnionIdHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return GetUserByUnionIdResponse
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
     * @param GetUserByUnionIdRequest $request
     *
     * @return GetUserByUnionIdResponse
     */
    public function getUserByUnionId($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetUserByUnionIdHeaders([]);

        return $this->getUserByUnionIdWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                   $subCorpId
     * @param GetVillageOrgInfoHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return GetVillageOrgInfoResponse
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
     * @param string $subCorpId
     *
     * @return GetVillageOrgInfoResponse
     */
    public function getVillageOrgInfo($subCorpId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetVillageOrgInfoHeaders([]);

        return $this->getVillageOrgInfoWithOptions($subCorpId, $headers, $runtime);
    }

    /**
     * @param string                     $departmentId
     * @param ListDeptSimpleUsersRequest $request
     * @param ListDeptSimpleUsersHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return ListDeptSimpleUsersResponse
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
     * @param string                     $departmentId
     * @param ListDeptSimpleUsersRequest $request
     *
     * @return ListDeptSimpleUsersResponse
     */
    public function listDeptSimpleUsers($departmentId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListDeptSimpleUsersHeaders([]);

        return $this->listDeptSimpleUsersWithOptions($departmentId, $request, $headers, $runtime);
    }

    /**
     * @param string                 $departmentId
     * @param ListDeptUserIdsRequest $request
     * @param ListDeptUserIdsHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return ListDeptUserIdsResponse
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
     * @param string                 $departmentId
     * @param ListDeptUserIdsRequest $request
     *
     * @return ListDeptUserIdsResponse
     */
    public function listDeptUserIds($departmentId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListDeptUserIdsHeaders([]);

        return $this->listDeptUserIdsWithOptions($departmentId, $request, $headers, $runtime);
    }

    /**
     * @param string               $departmentId
     * @param ListDeptUsersRequest $request
     * @param ListDeptUsersHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return ListDeptUsersResponse
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
     * @param string               $departmentId
     * @param ListDeptUsersRequest $request
     *
     * @return ListDeptUsersResponse
     */
    public function listDeptUsers($departmentId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListDeptUsersHeaders([]);

        return $this->listDeptUsersWithOptions($departmentId, $request, $headers, $runtime);
    }

    /**
     * @param ListParentByDeptRequest $request
     * @param ListParentByDeptHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return ListParentByDeptResponse
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
     * @param ListParentByDeptRequest $request
     *
     * @return ListParentByDeptResponse
     */
    public function listParentByDept($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListParentByDeptHeaders([]);

        return $this->listParentByDeptWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ListParentByUserRequest $request
     * @param ListParentByUserHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return ListParentByUserResponse
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
     * @param ListParentByUserRequest $request
     *
     * @return ListParentByUserResponse
     */
    public function listParentByUser($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListParentByUserHeaders([]);

        return $this->listParentByUserWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                       $departmentId
     * @param ListResidentDeptUsersRequest $request
     * @param ListResidentDeptUsersHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return ListResidentDeptUsersResponse
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
     * @param string                       $departmentId
     * @param ListResidentDeptUsersRequest $request
     *
     * @return ListResidentDeptUsersResponse
     */
    public function listResidentDeptUsers($departmentId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListResidentDeptUsersHeaders([]);

        return $this->listResidentDeptUsersWithOptions($departmentId, $request, $headers, $runtime);
    }

    /**
     * @param string                      $departmentId
     * @param ListResidentSubDeptsRequest $request
     * @param ListResidentSubDeptsHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return ListResidentSubDeptsResponse
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
     * @param string                      $departmentId
     * @param ListResidentSubDeptsRequest $request
     *
     * @return ListResidentSubDeptsResponse
     */
    public function listResidentSubDepts($departmentId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListResidentSubDeptsHeaders([]);

        return $this->listResidentSubDeptsWithOptions($departmentId, $request, $headers, $runtime);
    }

    /**
     * @param ListResidentUserInfosRequest $tmpReq
     * @param ListResidentUserInfosHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return ListResidentUserInfosResponse
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
     * @param ListResidentUserInfosRequest $request
     *
     * @return ListResidentUserInfosResponse
     */
    public function listResidentUserInfos($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListResidentUserInfosHeaders([]);

        return $this->listResidentUserInfosWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ListSimpleUsersByRoleRequest $request
     * @param ListSimpleUsersByRoleHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return ListSimpleUsersByRoleResponse
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
     * @param ListSimpleUsersByRoleRequest $request
     *
     * @return ListSimpleUsersByRoleResponse
     */
    public function listSimpleUsersByRole($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListSimpleUsersByRoleHeaders([]);

        return $this->listSimpleUsersByRoleWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ListSubCorpsRequest $request
     * @param ListSubCorpsHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return ListSubCorpsResponse
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
     * @param ListSubCorpsRequest $request
     *
     * @return ListSubCorpsResponse
     */
    public function listSubCorps($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListSubCorpsHeaders([]);

        return $this->listSubCorpsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string             $departmentId
     * @param ListSubDeptRequest $request
     * @param ListSubDeptHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return ListSubDeptResponse
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
     * @param string             $departmentId
     * @param ListSubDeptRequest $request
     *
     * @return ListSubDeptResponse
     */
    public function listSubDept($departmentId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListSubDeptHeaders([]);

        return $this->listSubDeptWithOptions($departmentId, $request, $headers, $runtime);
    }

    /**
     * @param string                $departmentId
     * @param ListSubDeptIdsRequest $request
     * @param ListSubDeptIdsHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return ListSubDeptIdsResponse
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
     * @param string                $departmentId
     * @param ListSubDeptIdsRequest $request
     *
     * @return ListSubDeptIdsResponse
     */
    public function listSubDeptIds($departmentId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListSubDeptIdsHeaders([]);

        return $this->listSubDeptIdsWithOptions($departmentId, $request, $headers, $runtime);
    }
}
