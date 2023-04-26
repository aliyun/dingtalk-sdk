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
     * @param AddPointRequest $request
     * @param AddPointHeaders $headers
     * @param RuntimeOptions  $runtime
     *
     * @return AddPointResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'AddPoint',
            'version'     => 'resident_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/resident/points',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return AddPointResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param AddPointRequest $request
     *
     * @return AddPointResponse
     */
    public function addPoint($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddPointHeaders([]);

        return $this->addPointWithOptions($request, $headers, $runtime);
    }

    /**
     * @param AddResidentDepartmentRequest $request
     * @param AddResidentDepartmentHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return AddResidentDepartmentResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'AddResidentDepartment',
            'version'     => 'resident_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/resident/departments',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return AddResidentDepartmentResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param AddResidentDepartmentRequest $request
     *
     * @return AddResidentDepartmentResponse
     */
    public function addResidentDepartment($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddResidentDepartmentHeaders([]);

        return $this->addResidentDepartmentWithOptions($request, $headers, $runtime);
    }

    /**
     * @param AddResidentMemberRequest $request
     * @param AddResidentMemberHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return AddResidentMemberResponse
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'AddResidentMember',
            'version'     => 'resident_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/resident/members',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AddResidentMemberResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param AddResidentMemberRequest $request
     *
     * @return AddResidentMemberResponse
     */
    public function addResidentMember($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddResidentMemberHeaders([]);

        return $this->addResidentMemberWithOptions($request, $headers, $runtime);
    }

    /**
     * @param AddResidentUsersRequest $request
     * @param AddResidentUsersHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return AddResidentUsersResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'AddResidentUsers',
            'version'     => 'resident_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/resident/users',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return AddResidentUsersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param AddResidentUsersRequest $request
     *
     * @return AddResidentUsersResponse
     */
    public function addResidentUsers($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddResidentUsersHeaders([]);

        return $this->addResidentUsersWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateResidentBlackBoardRequest $request
     * @param CreateResidentBlackBoardHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return CreateResidentBlackBoardResponse
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'CreateResidentBlackBoard',
            'version'     => 'resident_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/resident/blackboards',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateResidentBlackBoardResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CreateResidentBlackBoardRequest $request
     *
     * @return CreateResidentBlackBoardResponse
     */
    public function createResidentBlackBoard($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateResidentBlackBoardHeaders([]);

        return $this->createResidentBlackBoardWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateSpaceRequest $request
     * @param CreateSpaceHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return CreateSpaceResponse
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'CreateSpace',
            'version'     => 'resident_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/resident/spaces',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateSpaceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CreateSpaceRequest $request
     *
     * @return CreateSpaceResponse
     */
    public function createSpace($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateSpaceHeaders([]);

        return $this->createSpaceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DeleteResidentBlackBoardRequest $request
     * @param DeleteResidentBlackBoardHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return DeleteResidentBlackBoardResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'DeleteResidentBlackBoard',
            'version'     => 'resident_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/resident/blackboards',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DeleteResidentBlackBoardResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param DeleteResidentBlackBoardRequest $request
     *
     * @return DeleteResidentBlackBoardResponse
     */
    public function deleteResidentBlackBoard($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteResidentBlackBoardHeaders([]);

        return $this->deleteResidentBlackBoardWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DeleteResidentDepartmentRequest $request
     * @param DeleteResidentDepartmentHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return DeleteResidentDepartmentResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'DeleteResidentDepartment',
            'version'     => 'resident_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/resident/departments',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return DeleteResidentDepartmentResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param DeleteResidentDepartmentRequest $request
     *
     * @return DeleteResidentDepartmentResponse
     */
    public function deleteResidentDepartment($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteResidentDepartmentHeaders([]);

        return $this->deleteResidentDepartmentWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DeleteSpaceRequest $request
     * @param DeleteSpaceHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return DeleteSpaceResponse
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'DeleteSpace',
            'version'     => 'resident_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/resident/spaces/remove',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DeleteSpaceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param DeleteSpaceRequest $request
     *
     * @return DeleteSpaceResponse
     */
    public function deleteSpace($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteSpaceHeaders([]);

        return $this->deleteSpaceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetConversationIdRequest $request
     * @param GetConversationIdHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return GetConversationIdResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetConversationId',
            'version'     => 'resident_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/resident/conversations',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetConversationIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetConversationIdRequest $request
     *
     * @return GetConversationIdResponse
     */
    public function getConversationId($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetConversationIdHeaders([]);

        return $this->getConversationIdWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetIndustryTypeHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return GetIndustryTypeResponse
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
            'action'      => 'GetIndustryType',
            'version'     => 'resident_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/resident/organizations/industryTypes',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetIndustryTypeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @return GetIndustryTypeResponse
     */
    public function getIndustryType()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetIndustryTypeHeaders([]);

        return $this->getIndustryTypeWithOptions($headers, $runtime);
    }

    /**
     * @param GetPropertyInfoRequest $request
     * @param GetPropertyInfoHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return GetPropertyInfoResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetPropertyInfo',
            'version'     => 'resident_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/resident/propertyInfos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetPropertyInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetPropertyInfoRequest $request
     *
     * @return GetPropertyInfoResponse
     */
    public function getPropertyInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetPropertyInfoHeaders([]);

        return $this->getPropertyInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetResidentInfoRequest $request
     * @param GetResidentInfoHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return GetResidentInfoResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetResidentInfo',
            'version'     => 'resident_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/resident/residentInfos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetResidentInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetResidentInfoRequest $request
     *
     * @return GetResidentInfoResponse
     */
    public function getResidentInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetResidentInfoHeaders([]);

        return $this->getResidentInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetResidentMembersInfoRequest $request
     * @param GetResidentMembersInfoHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return GetResidentMembersInfoResponse
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'GetResidentMembersInfo',
            'version'     => 'resident_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/resident/residences/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetResidentMembersInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetResidentMembersInfoRequest $request
     *
     * @return GetResidentMembersInfoResponse
     */
    public function getResidentMembersInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetResidentMembersInfoHeaders([]);

        return $this->getResidentMembersInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetSpaceIdByTypeRequest $request
     * @param GetSpaceIdByTypeHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return GetSpaceIdByTypeResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetSpaceIdByType',
            'version'     => 'resident_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/resident/spaces/types',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetSpaceIdByTypeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetSpaceIdByTypeRequest $request
     *
     * @return GetSpaceIdByTypeResponse
     */
    public function getSpaceIdByType($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSpaceIdByTypeHeaders([]);

        return $this->getSpaceIdByTypeWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetSpacesInfoRequest $request
     * @param GetSpacesInfoHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return GetSpacesInfoResponse
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'GetSpacesInfo',
            'version'     => 'resident_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/resident/spaces/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetSpacesInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetSpacesInfoRequest $request
     *
     * @return GetSpacesInfoResponse
     */
    public function getSpacesInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSpacesInfoHeaders([]);

        return $this->getSpacesInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ListIndustryRoleUsersRequest $request
     * @param ListIndustryRoleUsersHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return ListIndustryRoleUsersResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'ListIndustryRoleUsers',
            'version'     => 'resident_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/resident/industryRoles/users',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListIndustryRoleUsersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ListIndustryRoleUsersRequest $request
     *
     * @return ListIndustryRoleUsersResponse
     */
    public function listIndustryRoleUsers($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListIndustryRoleUsersHeaders([]);

        return $this->listIndustryRoleUsersWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ListPointRulesRequest $request
     * @param ListPointRulesHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return ListPointRulesResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'ListPointRules',
            'version'     => 'resident_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/resident/points/rules',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListPointRulesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ListPointRulesRequest $request
     *
     * @return ListPointRulesResponse
     */
    public function listPointRules($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListPointRulesHeaders([]);

        return $this->listPointRulesWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ListSubSpaceRequest $request
     * @param ListSubSpaceHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return ListSubSpaceResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'ListSubSpace',
            'version'     => 'resident_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/resident/spaces/subSpaces',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListSubSpaceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ListSubSpaceRequest $request
     *
     * @return ListSubSpaceResponse
     */
    public function listSubSpace($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListSubSpaceHeaders([]);

        return $this->listSubSpaceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ListUncheckUsersRequest $request
     * @param ListUncheckUsersHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return ListUncheckUsersResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'ListUncheckUsers',
            'version'     => 'resident_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/resident/organizations/noJoinUsers',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListUncheckUsersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ListUncheckUsersRequest $request
     *
     * @return ListUncheckUsersResponse
     */
    public function listUncheckUsers($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListUncheckUsersHeaders([]);

        return $this->listUncheckUsersWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ListUserIndustryRolesRequest $request
     * @param ListUserIndustryRolesHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return ListUserIndustryRolesResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'ListUserIndustryRoles',
            'version'     => 'resident_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/resident/users/industryRoles',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListUserIndustryRolesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ListUserIndustryRolesRequest $request
     *
     * @return ListUserIndustryRolesResponse
     */
    public function listUserIndustryRoles($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListUserIndustryRolesHeaders([]);

        return $this->listUserIndustryRolesWithOptions($request, $headers, $runtime);
    }

    /**
     * @param PagePointHistoryRequest $request
     * @param PagePointHistoryHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return PagePointHistoryResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'PagePointHistory',
            'version'     => 'resident_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/resident/points/records',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return PagePointHistoryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param PagePointHistoryRequest $request
     *
     * @return PagePointHistoryResponse
     */
    public function pagePointHistory($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PagePointHistoryHeaders([]);

        return $this->pagePointHistoryWithOptions($request, $headers, $runtime);
    }

    /**
     * @param RemoveResidentMemberRequest $request
     * @param RemoveResidentMemberHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return RemoveResidentMemberResponse
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'RemoveResidentMember',
            'version'     => 'resident_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/resident/members/remove',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return RemoveResidentMemberResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param RemoveResidentMemberRequest $request
     *
     * @return RemoveResidentMemberResponse
     */
    public function removeResidentMember($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RemoveResidentMemberHeaders([]);

        return $this->removeResidentMemberWithOptions($request, $headers, $runtime);
    }

    /**
     * @param RemoveResidentUserRequest $request
     * @param RemoveResidentUserHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return RemoveResidentUserResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'RemoveResidentUser',
            'version'     => 'resident_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/resident/users/remove',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return RemoveResidentUserResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param RemoveResidentUserRequest $request
     *
     * @return RemoveResidentUserResponse
     */
    public function removeResidentUser($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RemoveResidentUserHeaders([]);

        return $this->removeResidentUserWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SearchResidentRequest $request
     * @param SearchResidentHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return SearchResidentResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'SearchResident',
            'version'     => 'resident_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/resident/residences',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SearchResidentResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SearchResidentRequest $request
     *
     * @return SearchResidentResponse
     */
    public function searchResident($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchResidentHeaders([]);

        return $this->searchResidentWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateResideceGroupRequest $request
     * @param UpdateResideceGroupHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return UpdateResideceGroupResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'UpdateResideceGroup',
            'version'     => 'resident_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/resident/departments/updateResideceGroup',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return UpdateResideceGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param UpdateResideceGroupRequest $request
     *
     * @return UpdateResideceGroupResponse
     */
    public function updateResideceGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateResideceGroupHeaders([]);

        return $this->updateResideceGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateResidenceRequest $request
     * @param UpdateResidenceHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return UpdateResidenceResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'UpdateResidence',
            'version'     => 'resident_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/resident/departments/updateResidece',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return UpdateResidenceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param UpdateResidenceRequest $request
     *
     * @return UpdateResidenceResponse
     */
    public function updateResidence($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateResidenceHeaders([]);

        return $this->updateResidenceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateResidentBlackBoardRequest $request
     * @param UpdateResidentBlackBoardHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return UpdateResidentBlackBoardResponse
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'UpdateResidentBlackBoard',
            'version'     => 'resident_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/resident/blackboards',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateResidentBlackBoardResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param UpdateResidentBlackBoardRequest $request
     *
     * @return UpdateResidentBlackBoardResponse
     */
    public function updateResidentBlackBoard($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateResidentBlackBoardHeaders([]);

        return $this->updateResidentBlackBoardWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateResidentInfoRequest $request
     * @param UpdateResidentInfoHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return UpdateResidentInfoResponse
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'UpdateResidentInfo',
            'version'     => 'resident_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/resident/residences',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateResidentInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param UpdateResidentInfoRequest $request
     *
     * @return UpdateResidentInfoResponse
     */
    public function updateResidentInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateResidentInfoHeaders([]);

        return $this->updateResidentInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateResidentMemberRequest $request
     * @param UpdateResidentMemberHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return UpdateResidentMemberResponse
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'UpdateResidentMember',
            'version'     => 'resident_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/resident/members',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateResidentMemberResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param UpdateResidentMemberRequest $request
     *
     * @return UpdateResidentMemberResponse
     */
    public function updateResidentMember($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateResidentMemberHeaders([]);

        return $this->updateResidentMemberWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateResidentUserRequest $request
     * @param UpdateResidentUserHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return UpdateResidentUserResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'UpdateResidentUser',
            'version'     => 'resident_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/resident/users',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return UpdateResidentUserResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param UpdateResidentUserRequest $request
     *
     * @return UpdateResidentUserResponse
     */
    public function updateResidentUser($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateResidentUserHeaders([]);

        return $this->updateResidentUserWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateSpaceRequest $request
     * @param UpdateSpaceHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return UpdateSpaceResponse
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'UpdateSpace',
            'version'     => 'resident_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/resident/spaces',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateSpaceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param UpdateSpaceRequest $request
     *
     * @return UpdateSpaceResponse
     */
    public function updateSpace($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateSpaceHeaders([]);

        return $this->updateSpaceWithOptions($request, $headers, $runtime);
    }
}
