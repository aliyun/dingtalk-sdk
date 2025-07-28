<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\AddPointHeaders;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\AddPointRequest;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\AddPointResponse;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\AddResidentDepartmentHeaders;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\AddResidentDepartmentRequest;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\AddResidentDepartmentResponse;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\AddResidentMemberHeaders;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\AddResidentMemberRequest;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\AddResidentMemberResponse;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\AddResidentUsersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\AddResidentUsersRequest;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\AddResidentUsersResponse;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\CreateResidentBlackBoardHeaders;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\CreateResidentBlackBoardRequest;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\CreateResidentBlackBoardResponse;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\CreateSpaceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\CreateSpaceRequest;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\CreateSpaceResponse;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\DeleteResidentBlackBoardHeaders;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\DeleteResidentBlackBoardRequest;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\DeleteResidentBlackBoardResponse;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\DeleteResidentDepartmentHeaders;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\DeleteResidentDepartmentRequest;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\DeleteResidentDepartmentResponse;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\DeleteSpaceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\DeleteSpaceRequest;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\DeleteSpaceResponse;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\GetConversationIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\GetConversationIdRequest;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\GetConversationIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\GetIndustryTypeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\GetIndustryTypeResponse;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\GetPropertyInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\GetPropertyInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\GetPropertyInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\GetResidentInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\GetResidentInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\GetResidentInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\GetResidentMembersInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\GetResidentMembersInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\GetResidentMembersInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\GetSpaceIdByTypeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\GetSpaceIdByTypeRequest;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\GetSpaceIdByTypeResponse;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\GetSpacesInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\GetSpacesInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\GetSpacesInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\ListIndustryRoleUsersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\ListIndustryRoleUsersRequest;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\ListIndustryRoleUsersResponse;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\ListPointRulesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\ListPointRulesRequest;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\ListPointRulesResponse;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\ListSubSpaceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\ListSubSpaceRequest;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\ListSubSpaceResponse;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\ListUncheckUsersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\ListUncheckUsersRequest;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\ListUncheckUsersResponse;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\ListUserIndustryRolesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\ListUserIndustryRolesRequest;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\ListUserIndustryRolesResponse;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\PagePointHistoryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\PagePointHistoryRequest;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\PagePointHistoryResponse;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\RemoveResidentMemberHeaders;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\RemoveResidentMemberRequest;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\RemoveResidentMemberResponse;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\RemoveResidentUserHeaders;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\RemoveResidentUserRequest;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\RemoveResidentUserResponse;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\SearchResidentHeaders;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\SearchResidentRequest;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\SearchResidentResponse;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\UpdateResideceGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\UpdateResideceGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\UpdateResideceGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\UpdateResidenceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\UpdateResidenceRequest;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\UpdateResidenceResponse;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\UpdateResidentBlackBoardHeaders;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\UpdateResidentBlackBoardRequest;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\UpdateResidentBlackBoardResponse;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\UpdateResidentInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\UpdateResidentInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\UpdateResidentInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\UpdateResidentMemberHeaders;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\UpdateResidentMemberRequest;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\UpdateResidentMemberResponse;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\UpdateResidentUserHeaders;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\UpdateResidentUserRequest;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\UpdateResidentUserResponse;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\UpdateSpaceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\UpdateSpaceRequest;
use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\UpdateSpaceResponse;
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
     * @summary 增加积分
     *  *
     * @param AddPointRequest $request AddPointRequest
     * @param AddPointHeaders $headers AddPointHeaders
     * @param RuntimeOptions  $runtime runtime options for this request RuntimeOptions
     *
     * @return AddPointResponse AddPointResponse
     */
    public function addPointWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->actionTime)) {
            $query['actionTime'] = $request->actionTime;
        }
        if (!Utils::isUnset($request->isCircle)) {
            $query['isCircle'] = $request->isCircle;
        }
        if (!Utils::isUnset($request->ruleCode)) {
            $query['ruleCode'] = $request->ruleCode;
        }
        if (!Utils::isUnset($request->ruleName)) {
            $query['ruleName'] = $request->ruleName;
        }
        if (!Utils::isUnset($request->score)) {
            $query['score'] = $request->score;
        }
        if (!Utils::isUnset($request->userId)) {
            $query['userId'] = $request->userId;
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
            'action' => 'AddPoint',
            'version' => 'resident_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/resident/points',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return AddPointResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 增加积分
     *  *
     * @param AddPointRequest $request AddPointRequest
     *
     * @return AddPointResponse AddPointResponse
     */
    public function addPoint($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddPointHeaders([]);

        return $this->addPointWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 增加组户
     *  *
     * @param AddResidentDepartmentRequest $request AddResidentDepartmentRequest
     * @param AddResidentDepartmentHeaders $headers AddResidentDepartmentHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return AddResidentDepartmentResponse AddResidentDepartmentResponse
     */
    public function addResidentDepartmentWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->departmentName)) {
            $query['departmentName'] = $request->departmentName;
        }
        if (!Utils::isUnset($request->isResidenceGroup)) {
            $query['isResidenceGroup'] = $request->isResidenceGroup;
        }
        if (!Utils::isUnset($request->parentDepartmentId)) {
            $query['parentDepartmentId'] = $request->parentDepartmentId;
        }
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
            'action' => 'AddResidentDepartment',
            'version' => 'resident_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/resident/departments',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return AddResidentDepartmentResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 增加组户
     *  *
     * @param AddResidentDepartmentRequest $request AddResidentDepartmentRequest
     *
     * @return AddResidentDepartmentResponse AddResidentDepartmentResponse
     */
    public function addResidentDepartment($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddResidentDepartmentHeaders([]);

        return $this->addResidentDepartmentWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 添加小区成员
     *  *
     * @param AddResidentMemberRequest $request AddResidentMemberRequest
     * @param AddResidentMemberHeaders $headers AddResidentMemberHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return AddResidentMemberResponse AddResidentMemberResponse
     */
    public function addResidentMemberWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->residentAddInfo)) {
            $body['residentAddInfo'] = $request->residentAddInfo;
        }
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
            'action' => 'AddResidentMember',
            'version' => 'resident_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/resident/members',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return AddResidentMemberResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 添加小区成员
     *  *
     * @param AddResidentMemberRequest $request AddResidentMemberRequest
     *
     * @return AddResidentMemberResponse AddResidentMemberResponse
     */
    public function addResidentMember($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddResidentMemberHeaders([]);

        return $this->addResidentMemberWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 新增居民
     *  *
     * @param AddResidentUsersRequest $request AddResidentUsersRequest
     * @param AddResidentUsersHeaders $headers AddResidentUsersHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return AddResidentUsersResponse AddResidentUsersResponse
     */
    public function addResidentUsersWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->address)) {
            $query['address'] = $request->address;
        }
        if (!Utils::isUnset($request->departmentId)) {
            $query['departmentId'] = $request->departmentId;
        }
        if (!Utils::isUnset($request->extField)) {
            $query['extField'] = $request->extField;
        }
        if (!Utils::isUnset($request->isLeaseholder)) {
            $query['isLeaseholder'] = $request->isLeaseholder;
        }
        if (!Utils::isUnset($request->mobile)) {
            $query['mobile'] = $request->mobile;
        }
        if (!Utils::isUnset($request->relateType)) {
            $query['relateType'] = $request->relateType;
        }
        if (!Utils::isUnset($request->userName)) {
            $query['userName'] = $request->userName;
        }
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
            'action' => 'AddResidentUsers',
            'version' => 'resident_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/resident/users',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return AddResidentUsersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 新增居民
     *  *
     * @param AddResidentUsersRequest $request AddResidentUsersRequest
     *
     * @return AddResidentUsersResponse AddResidentUsersResponse
     */
    public function addResidentUsers($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddResidentUsersHeaders([]);

        return $this->addResidentUsersWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建小区公告
     *  *
     * @param CreateResidentBlackBoardRequest $request CreateResidentBlackBoardRequest
     * @param CreateResidentBlackBoardHeaders $headers CreateResidentBlackBoardHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateResidentBlackBoardResponse CreateResidentBlackBoardResponse
     */
    public function createResidentBlackBoardWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->context)) {
            $body['context'] = $request->context;
        }
        if (!Utils::isUnset($request->mediaId)) {
            $body['mediaId'] = $request->mediaId;
        }
        if (!Utils::isUnset($request->sendTime)) {
            $body['sendTime'] = $request->sendTime;
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
            'action' => 'CreateResidentBlackBoard',
            'version' => 'resident_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/resident/blackboards',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateResidentBlackBoardResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建小区公告
     *  *
     * @param CreateResidentBlackBoardRequest $request CreateResidentBlackBoardRequest
     *
     * @return CreateResidentBlackBoardResponse CreateResidentBlackBoardResponse
     */
    public function createResidentBlackBoard($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateResidentBlackBoardHeaders([]);

        return $this->createResidentBlackBoardWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建小区空间，含分区，楼栋，单元，房屋等
     *  *
     * @param CreateSpaceRequest $request CreateSpaceRequest
     * @param CreateSpaceHeaders $headers CreateSpaceHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateSpaceResponse CreateSpaceResponse
     */
    public function createSpaceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->billingArea)) {
            $body['billingArea'] = $request->billingArea;
        }
        if (!Utils::isUnset($request->buildingArea)) {
            $body['buildingArea'] = $request->buildingArea;
        }
        if (!Utils::isUnset($request->floor)) {
            $body['floor'] = $request->floor;
        }
        if (!Utils::isUnset($request->houseState)) {
            $body['houseState'] = $request->houseState;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->parentDeptId)) {
            $body['parentDeptId'] = $request->parentDeptId;
        }
        if (!Utils::isUnset($request->tagCode)) {
            $body['tagCode'] = $request->tagCode;
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
            'action' => 'CreateSpace',
            'version' => 'resident_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/resident/spaces',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateSpaceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建小区空间，含分区，楼栋，单元，房屋等
     *  *
     * @param CreateSpaceRequest $request CreateSpaceRequest
     *
     * @return CreateSpaceResponse CreateSpaceResponse
     */
    public function createSpace($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateSpaceHeaders([]);

        return $this->createSpaceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除小区公告
     *  *
     * @param DeleteResidentBlackBoardRequest $request DeleteResidentBlackBoardRequest
     * @param DeleteResidentBlackBoardHeaders $headers DeleteResidentBlackBoardHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteResidentBlackBoardResponse DeleteResidentBlackBoardResponse
     */
    public function deleteResidentBlackBoardWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->blackboardId)) {
            $query['blackboardId'] = $request->blackboardId;
        }
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
            'action' => 'DeleteResidentBlackBoard',
            'version' => 'resident_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/resident/blackboards',
            'method' => 'DELETE',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return DeleteResidentBlackBoardResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除小区公告
     *  *
     * @param DeleteResidentBlackBoardRequest $request DeleteResidentBlackBoardRequest
     *
     * @return DeleteResidentBlackBoardResponse DeleteResidentBlackBoardResponse
     */
    public function deleteResidentBlackBoard($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteResidentBlackBoardHeaders([]);

        return $this->deleteResidentBlackBoardWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除组户信息
     *  *
     * @param DeleteResidentDepartmentRequest $request DeleteResidentDepartmentRequest
     * @param DeleteResidentDepartmentHeaders $headers DeleteResidentDepartmentHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteResidentDepartmentResponse DeleteResidentDepartmentResponse
     */
    public function deleteResidentDepartmentWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->departmentId)) {
            $query['departmentId'] = $request->departmentId;
        }
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
            'action' => 'DeleteResidentDepartment',
            'version' => 'resident_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/resident/departments',
            'method' => 'DELETE',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return DeleteResidentDepartmentResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除组户信息
     *  *
     * @param DeleteResidentDepartmentRequest $request DeleteResidentDepartmentRequest
     *
     * @return DeleteResidentDepartmentResponse DeleteResidentDepartmentResponse
     */
    public function deleteResidentDepartment($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteResidentDepartmentHeaders([]);

        return $this->deleteResidentDepartmentWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除小区空间，含分区，楼栋，单元，房屋
     *  *
     * @param DeleteSpaceRequest $request DeleteSpaceRequest
     * @param DeleteSpaceHeaders $headers DeleteSpaceHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteSpaceResponse DeleteSpaceResponse
     */
    public function deleteSpaceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->deptIds)) {
            $body['deptIds'] = $request->deptIds;
        }
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
            'action' => 'DeleteSpace',
            'version' => 'resident_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/resident/spaces/remove',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return DeleteSpaceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除小区空间，含分区，楼栋，单元，房屋
     *  *
     * @param DeleteSpaceRequest $request DeleteSpaceRequest
     *
     * @return DeleteSpaceResponse DeleteSpaceResponse
     */
    public function deleteSpace($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteSpaceHeaders([]);

        return $this->deleteSpaceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取指定群的openConversationId
     *  *
     * @param GetConversationIdRequest $request GetConversationIdRequest
     * @param GetConversationIdHeaders $headers GetConversationIdHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return GetConversationIdResponse GetConversationIdResponse
     */
    public function getConversationIdWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->chatId)) {
            $query['chatId'] = $request->chatId;
        }
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
            'action' => 'GetConversationId',
            'version' => 'resident_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/resident/conversations',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetConversationIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取指定群的openConversationId
     *  *
     * @param GetConversationIdRequest $request GetConversationIdRequest
     *
     * @return GetConversationIdResponse GetConversationIdResponse
     */
    public function getConversationId($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetConversationIdHeaders([]);

        return $this->getConversationIdWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取组织的行业类型
     *  *
     * @param GetIndustryTypeHeaders $headers GetIndustryTypeHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return GetIndustryTypeResponse GetIndustryTypeResponse
     */
    public function getIndustryTypeWithOptions($headers, $runtime)
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
            'action' => 'GetIndustryType',
            'version' => 'resident_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/resident/organizations/industryTypes',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetIndustryTypeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取组织的行业类型
     *  *
     * @return GetIndustryTypeResponse GetIndustryTypeResponse
     */
    public function getIndustryType()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetIndustryTypeHeaders([]);

        return $this->getIndustryTypeWithOptions($headers, $runtime);
    }

    /**
     * @summary 获取物业公司信息
     *  *
     * @param GetPropertyInfoRequest $request GetPropertyInfoRequest
     * @param GetPropertyInfoHeaders $headers GetPropertyInfoHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return GetPropertyInfoResponse GetPropertyInfoResponse
     */
    public function getPropertyInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->propertyCorpId)) {
            $query['propertyCorpId'] = $request->propertyCorpId;
        }
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
            'action' => 'GetPropertyInfo',
            'version' => 'resident_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/resident/propertyInfos',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetPropertyInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取物业公司信息
     *  *
     * @param GetPropertyInfoRequest $request GetPropertyInfoRequest
     *
     * @return GetPropertyInfoResponse GetPropertyInfoResponse
     */
    public function getPropertyInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetPropertyInfoHeaders([]);

        return $this->getPropertyInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取小区信息
     *  *
     * @param GetResidentInfoRequest $request GetResidentInfoRequest
     * @param GetResidentInfoHeaders $headers GetResidentInfoHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return GetResidentInfoResponse GetResidentInfoResponse
     */
    public function getResidentInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->residentCorpId)) {
            $query['residentCorpId'] = $request->residentCorpId;
        }
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
            'action' => 'GetResidentInfo',
            'version' => 'resident_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/resident/residentInfos',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetResidentInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取小区信息
     *  *
     * @param GetResidentInfoRequest $request GetResidentInfoRequest
     *
     * @return GetResidentInfoResponse GetResidentInfoResponse
     */
    public function getResidentInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetResidentInfoHeaders([]);

        return $this->getResidentInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取小区人员信息，包括居民和物业人员
     *  *
     * @param GetResidentMembersInfoRequest $request GetResidentMembersInfoRequest
     * @param GetResidentMembersInfoHeaders $headers GetResidentMembersInfoHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return GetResidentMembersInfoResponse GetResidentMembersInfoResponse
     */
    public function getResidentMembersInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->residentCropId)) {
            $body['residentCropId'] = $request->residentCropId;
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
            'action' => 'GetResidentMembersInfo',
            'version' => 'resident_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/resident/residences/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetResidentMembersInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取小区人员信息，包括居民和物业人员
     *  *
     * @param GetResidentMembersInfoRequest $request GetResidentMembersInfoRequest
     *
     * @return GetResidentMembersInfoResponse GetResidentMembersInfoResponse
     */
    public function getResidentMembersInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetResidentMembersInfoHeaders([]);

        return $this->getResidentMembersInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 根据类型获取部门id
     *  *
     * @param GetSpaceIdByTypeRequest $request GetSpaceIdByTypeRequest
     * @param GetSpaceIdByTypeHeaders $headers GetSpaceIdByTypeHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return GetSpaceIdByTypeResponse GetSpaceIdByTypeResponse
     */
    public function getSpaceIdByTypeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->departmentType)) {
            $query['departmentType'] = $request->departmentType;
        }
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
            'action' => 'GetSpaceIdByType',
            'version' => 'resident_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/resident/spaces/types',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetSpaceIdByTypeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据类型获取部门id
     *  *
     * @param GetSpaceIdByTypeRequest $request GetSpaceIdByTypeRequest
     *
     * @return GetSpaceIdByTypeResponse GetSpaceIdByTypeResponse
     */
    public function getSpaceIdByType($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSpaceIdByTypeHeaders([]);

        return $this->getSpaceIdByTypeWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取空间信息
     *  *
     * @param GetSpacesInfoRequest $request GetSpacesInfoRequest
     * @param GetSpacesInfoHeaders $headers GetSpacesInfoHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return GetSpacesInfoResponse GetSpacesInfoResponse
     */
    public function getSpacesInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->referIds)) {
            $body['referIds'] = $request->referIds;
        }
        if (!Utils::isUnset($request->residentCorpId)) {
            $body['residentCorpId'] = $request->residentCorpId;
        }
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
            'action' => 'GetSpacesInfo',
            'version' => 'resident_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/resident/spaces/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetSpacesInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取空间信息
     *  *
     * @param GetSpacesInfoRequest $request GetSpacesInfoRequest
     *
     * @return GetSpacesInfoResponse GetSpacesInfoResponse
     */
    public function getSpacesInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSpacesInfoHeaders([]);

        return $this->getSpacesInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取行业角色下的用户列表
     *  *
     * @param ListIndustryRoleUsersRequest $request ListIndustryRoleUsersRequest
     * @param ListIndustryRoleUsersHeaders $headers ListIndustryRoleUsersHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return ListIndustryRoleUsersResponse ListIndustryRoleUsersResponse
     */
    public function listIndustryRoleUsersWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
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
            'action' => 'ListIndustryRoleUsers',
            'version' => 'resident_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/resident/industryRoles/users',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ListIndustryRoleUsersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取行业角色下的用户列表
     *  *
     * @param ListIndustryRoleUsersRequest $request ListIndustryRoleUsersRequest
     *
     * @return ListIndustryRoleUsersResponse ListIndustryRoleUsersResponse
     */
    public function listIndustryRoleUsers($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListIndustryRoleUsersHeaders([]);

        return $this->listIndustryRoleUsersWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询组织维度配置的的积分规则
     *  *
     * @param ListPointRulesRequest $request ListPointRulesRequest
     * @param ListPointRulesHeaders $headers ListPointRulesHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return ListPointRulesResponse ListPointRulesResponse
     */
    public function listPointRulesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->isCircle)) {
            $query['isCircle'] = $request->isCircle;
        }
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
            'action' => 'ListPointRules',
            'version' => 'resident_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/resident/points/rules',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ListPointRulesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询组织维度配置的的积分规则
     *  *
     * @param ListPointRulesRequest $request ListPointRulesRequest
     *
     * @return ListPointRulesResponse ListPointRulesResponse
     */
    public function listPointRules($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListPointRulesHeaders([]);

        return $this->listPointRulesWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取子空间信息
     *  *
     * @param ListSubSpaceRequest $request ListSubSpaceRequest
     * @param ListSubSpaceHeaders $headers ListSubSpaceHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return ListSubSpaceResponse ListSubSpaceResponse
     */
    public function listSubSpaceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->referId)) {
            $query['referId'] = $request->referId;
        }
        if (!Utils::isUnset($request->residentCorpId)) {
            $query['residentCorpId'] = $request->residentCorpId;
        }
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
            'action' => 'ListSubSpace',
            'version' => 'resident_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/resident/spaces/subSpaces',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ListSubSpaceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取子空间信息
     *  *
     * @param ListSubSpaceRequest $request ListSubSpaceRequest
     *
     * @return ListSubSpaceResponse ListSubSpaceResponse
     */
    public function listSubSpace($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListSubSpaceHeaders([]);

        return $this->listSubSpaceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取未确认加入组织的用户
     *  *
     * @param ListUncheckUsersRequest $request ListUncheckUsersRequest
     * @param ListUncheckUsersHeaders $headers ListUncheckUsersHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return ListUncheckUsersResponse ListUncheckUsersResponse
     */
    public function listUncheckUsersWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->startTime)) {
            $query['startTime'] = $request->startTime;
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
            'action' => 'ListUncheckUsers',
            'version' => 'resident_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/resident/organizations/noJoinUsers',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ListUncheckUsersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取未确认加入组织的用户
     *  *
     * @param ListUncheckUsersRequest $request ListUncheckUsersRequest
     *
     * @return ListUncheckUsersResponse ListUncheckUsersResponse
     */
    public function listUncheckUsers($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListUncheckUsersHeaders([]);

        return $this->listUncheckUsersWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取用户行业化角色
     *  *
     * @param ListUserIndustryRolesRequest $request ListUserIndustryRolesRequest
     * @param ListUserIndustryRolesHeaders $headers ListUserIndustryRolesHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return ListUserIndustryRolesResponse ListUserIndustryRolesResponse
     */
    public function listUserIndustryRolesWithOptions($request, $headers, $runtime)
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'ListUserIndustryRoles',
            'version' => 'resident_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/resident/users/industryRoles',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ListUserIndustryRolesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取用户行业化角色
     *  *
     * @param ListUserIndustryRolesRequest $request ListUserIndustryRolesRequest
     *
     * @return ListUserIndustryRolesResponse ListUserIndustryRolesResponse
     */
    public function listUserIndustryRoles($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListUserIndustryRolesHeaders([]);

        return $this->listUserIndustryRolesWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询数字区县居民积分流水
     *  *
     * @param PagePointHistoryRequest $request PagePointHistoryRequest
     * @param PagePointHistoryHeaders $headers PagePointHistoryHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return PagePointHistoryResponse PagePointHistoryResponse
     */
    public function pagePointHistoryWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->endTime)) {
            $query['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->isCircle)) {
            $query['isCircle'] = $request->isCircle;
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
            'action' => 'PagePointHistory',
            'version' => 'resident_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/resident/points/records',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return PagePointHistoryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询数字区县居民积分流水
     *  *
     * @param PagePointHistoryRequest $request PagePointHistoryRequest
     *
     * @return PagePointHistoryResponse PagePointHistoryResponse
     */
    public function pagePointHistory($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PagePointHistoryHeaders([]);

        return $this->pagePointHistoryWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 从空间中删除人员
     *  *
     * @param RemoveResidentMemberRequest $request RemoveResidentMemberRequest
     * @param RemoveResidentMemberHeaders $headers RemoveResidentMemberHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return RemoveResidentMemberResponse RemoveResidentMemberResponse
     */
    public function removeResidentMemberWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->deptId)) {
            $body['deptId'] = $request->deptId;
        }
        if (!Utils::isUnset($request->unionId)) {
            $body['unionId'] = $request->unionId;
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
            'action' => 'RemoveResidentMember',
            'version' => 'resident_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/resident/members/remove',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return RemoveResidentMemberResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 从空间中删除人员
     *  *
     * @param RemoveResidentMemberRequest $request RemoveResidentMemberRequest
     *
     * @return RemoveResidentMemberResponse RemoveResidentMemberResponse
     */
    public function removeResidentMember($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RemoveResidentMemberHeaders([]);

        return $this->removeResidentMemberWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 从户内移除居民
     *  *
     * @param RemoveResidentUserRequest $request RemoveResidentUserRequest
     * @param RemoveResidentUserHeaders $headers RemoveResidentUserHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return RemoveResidentUserResponse RemoveResidentUserResponse
     */
    public function removeResidentUserWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->departmentId)) {
            $query['departmentId'] = $request->departmentId;
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
            'action' => 'RemoveResidentUser',
            'version' => 'resident_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/resident/users/remove',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return RemoveResidentUserResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 从户内移除居民
     *  *
     * @param RemoveResidentUserRequest $request RemoveResidentUserRequest
     *
     * @return RemoveResidentUserResponse RemoveResidentUserResponse
     */
    public function removeResidentUser($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RemoveResidentUserHeaders([]);

        return $this->removeResidentUserWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 搜索指定人员
     *  *
     * @param SearchResidentRequest $request SearchResidentRequest
     * @param SearchResidentHeaders $headers SearchResidentHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return SearchResidentResponse SearchResidentResponse
     */
    public function searchResidentWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->residentCropId)) {
            $query['residentCropId'] = $request->residentCropId;
        }
        if (!Utils::isUnset($request->searchWord)) {
            $query['searchWord'] = $request->searchWord;
        }
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
            'action' => 'SearchResident',
            'version' => 'resident_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/resident/residences',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SearchResidentResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 搜索指定人员
     *  *
     * @param SearchResidentRequest $request SearchResidentRequest
     *
     * @return SearchResidentResponse SearchResidentResponse
     */
    public function searchResident($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchResidentHeaders([]);

        return $this->searchResidentWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新组信息
     *  *
     * @param UpdateResideceGroupRequest $request UpdateResideceGroupRequest
     * @param UpdateResideceGroupHeaders $headers UpdateResideceGroupHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateResideceGroupResponse UpdateResideceGroupResponse
     */
    public function updateResideceGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->departmentId)) {
            $query['departmentId'] = $request->departmentId;
        }
        if (!Utils::isUnset($request->departmentName)) {
            $query['departmentName'] = $request->departmentName;
        }
        if (!Utils::isUnset($request->managerUserId)) {
            $query['managerUserId'] = $request->managerUserId;
        }
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
            'action' => 'UpdateResideceGroup',
            'version' => 'resident_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/resident/departments/updateResideceGroup',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return UpdateResideceGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新组信息
     *  *
     * @param UpdateResideceGroupRequest $request UpdateResideceGroupRequest
     *
     * @return UpdateResideceGroupResponse UpdateResideceGroupResponse
     */
    public function updateResideceGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateResideceGroupHeaders([]);

        return $this->updateResideceGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新户信息
     *  *
     * @param UpdateResidenceRequest $request UpdateResidenceRequest
     * @param UpdateResidenceHeaders $headers UpdateResidenceHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateResidenceResponse UpdateResidenceResponse
     */
    public function updateResidenceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->departmentId)) {
            $query['departmentId'] = $request->departmentId;
        }
        if (!Utils::isUnset($request->departmentName)) {
            $query['departmentName'] = $request->departmentName;
        }
        if (!Utils::isUnset($request->destitute)) {
            $query['destitute'] = $request->destitute;
        }
        if (!Utils::isUnset($request->grid)) {
            $query['grid'] = $request->grid;
        }
        if (!Utils::isUnset($request->homeTel)) {
            $query['homeTel'] = $request->homeTel;
        }
        if (!Utils::isUnset($request->managerUserId)) {
            $query['managerUserId'] = $request->managerUserId;
        }
        if (!Utils::isUnset($request->parentDepartmentId)) {
            $query['parentDepartmentId'] = $request->parentDepartmentId;
        }
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
            'action' => 'UpdateResidence',
            'version' => 'resident_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/resident/departments/updateResidece',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return UpdateResidenceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新户信息
     *  *
     * @param UpdateResidenceRequest $request UpdateResidenceRequest
     *
     * @return UpdateResidenceResponse UpdateResidenceResponse
     */
    public function updateResidence($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateResidenceHeaders([]);

        return $this->updateResidenceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新小区公告
     *  *
     * @param UpdateResidentBlackBoardRequest $request UpdateResidentBlackBoardRequest
     * @param UpdateResidentBlackBoardHeaders $headers UpdateResidentBlackBoardHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateResidentBlackBoardResponse UpdateResidentBlackBoardResponse
     */
    public function updateResidentBlackBoardWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->blackboardId)) {
            $body['blackboardId'] = $request->blackboardId;
        }
        if (!Utils::isUnset($request->context)) {
            $body['context'] = $request->context;
        }
        if (!Utils::isUnset($request->mediaId)) {
            $body['mediaId'] = $request->mediaId;
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
            'action' => 'UpdateResidentBlackBoard',
            'version' => 'resident_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/resident/blackboards',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateResidentBlackBoardResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新小区公告
     *  *
     * @param UpdateResidentBlackBoardRequest $request UpdateResidentBlackBoardRequest
     *
     * @return UpdateResidentBlackBoardResponse UpdateResidentBlackBoardResponse
     */
    public function updateResidentBlackBoard($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateResidentBlackBoardHeaders([]);

        return $this->updateResidentBlackBoardWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新小区信息
     *  *
     * @param UpdateResidentInfoRequest $request UpdateResidentInfoRequest
     * @param UpdateResidentInfoHeaders $headers UpdateResidentInfoHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateResidentInfoResponse UpdateResidentInfoResponse
     */
    public function updateResidentInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->address)) {
            $body['address'] = $request->address;
        }
        if (!Utils::isUnset($request->buildingArea)) {
            $body['buildingArea'] = $request->buildingArea;
        }
        if (!Utils::isUnset($request->cityName)) {
            $body['cityName'] = $request->cityName;
        }
        if (!Utils::isUnset($request->communityType)) {
            $body['communityType'] = $request->communityType;
        }
        if (!Utils::isUnset($request->countyName)) {
            $body['countyName'] = $request->countyName;
        }
        if (!Utils::isUnset($request->location)) {
            $body['location'] = $request->location;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->provName)) {
            $body['provName'] = $request->provName;
        }
        if (!Utils::isUnset($request->state)) {
            $body['state'] = $request->state;
        }
        if (!Utils::isUnset($request->telephone)) {
            $body['telephone'] = $request->telephone;
        }
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
            'action' => 'UpdateResidentInfo',
            'version' => 'resident_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/resident/residences',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateResidentInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新小区信息
     *  *
     * @param UpdateResidentInfoRequest $request UpdateResidentInfoRequest
     *
     * @return UpdateResidentInfoResponse UpdateResidentInfoResponse
     */
    public function updateResidentInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateResidentInfoHeaders([]);

        return $this->updateResidentInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新小区成员
     *  *
     * @param UpdateResidentMemberRequest $request UpdateResidentMemberRequest
     * @param UpdateResidentMemberHeaders $headers UpdateResidentMemberHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateResidentMemberResponse UpdateResidentMemberResponse
     */
    public function updateResidentMemberWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->residentUpdateInfo)) {
            $body['residentUpdateInfo'] = $request->residentUpdateInfo;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'UpdateResidentMember',
            'version' => 'resident_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/resident/members',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateResidentMemberResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新小区成员
     *  *
     * @param UpdateResidentMemberRequest $request UpdateResidentMemberRequest
     *
     * @return UpdateResidentMemberResponse UpdateResidentMemberResponse
     */
    public function updateResidentMember($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateResidentMemberHeaders([]);

        return $this->updateResidentMemberWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新居民信息
     *  *
     * @param UpdateResidentUserRequest $request UpdateResidentUserRequest
     * @param UpdateResidentUserHeaders $headers UpdateResidentUserHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateResidentUserResponse UpdateResidentUserResponse
     */
    public function updateResidentUserWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->address)) {
            $query['address'] = $request->address;
        }
        if (!Utils::isUnset($request->departmentId)) {
            $query['departmentId'] = $request->departmentId;
        }
        if (!Utils::isUnset($request->extField)) {
            $query['extField'] = $request->extField;
        }
        if (!Utils::isUnset($request->isRetainOldDept)) {
            $query['isRetainOldDept'] = $request->isRetainOldDept;
        }
        if (!Utils::isUnset($request->mobile)) {
            $query['mobile'] = $request->mobile;
        }
        if (!Utils::isUnset($request->oldDepartmentId)) {
            $query['oldDepartmentId'] = $request->oldDepartmentId;
        }
        if (!Utils::isUnset($request->relateType)) {
            $query['relateType'] = $request->relateType;
        }
        if (!Utils::isUnset($request->userId)) {
            $query['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->userName)) {
            $query['userName'] = $request->userName;
        }
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
            'action' => 'UpdateResidentUser',
            'version' => 'resident_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/resident/users',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return UpdateResidentUserResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新居民信息
     *  *
     * @param UpdateResidentUserRequest $request UpdateResidentUserRequest
     *
     * @return UpdateResidentUserResponse UpdateResidentUserResponse
     */
    public function updateResidentUser($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateResidentUserHeaders([]);

        return $this->updateResidentUserWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新小区空间，含分区，楼栋，单元，房屋等信息
     *  *
     * @param UpdateSpaceRequest $request UpdateSpaceRequest
     * @param UpdateSpaceHeaders $headers UpdateSpaceHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateSpaceResponse UpdateSpaceResponse
     */
    public function updateSpaceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->spaceInfoVOList)) {
            $body['spaceInfoVOList'] = $request->spaceInfoVOList;
        }
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
            'action' => 'UpdateSpace',
            'version' => 'resident_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/resident/spaces',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateSpaceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新小区空间，含分区，楼栋，单元，房屋等信息
     *  *
     * @param UpdateSpaceRequest $request UpdateSpaceRequest
     *
     * @return UpdateSpaceResponse UpdateSpaceResponse
     */
    public function updateSpace($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateSpaceHeaders([]);

        return $this->updateSpaceWithOptions($request, $headers, $runtime);
    }
}
