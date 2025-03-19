<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\AddAppRolesToMemberHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\AddAppRolesToMemberRequest;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\AddAppRolesToMemberResponse;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\AddAppToWorkBenchGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\AddAppToWorkBenchGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\AddAppToWorkBenchGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\AddMemberToAppRoleHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\AddMemberToAppRoleRequest;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\AddMemberToAppRoleResponse;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\AnheiPResponse;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\AnheiTest888Response;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\AnheiTestBResponse;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\AnheiTestNineResponse;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\AppStatusManagerTestRequest;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\AppStatusManagerTestResponse;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\AyunTestOnlineResponse;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\AyunTestResponse;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\CreateApaasAppHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\CreateApaasAppRequest;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\CreateApaasAppResponse;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\CreateInnerAppHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\CreateInnerAppRequest;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\CreateInnerAppResponse;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\DeleteAppRoleHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\DeleteAppRoleRequest;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\DeleteAppRoleResponse;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\DeleteInnerAppHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\DeleteInnerAppRequest;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\DeleteInnerAppResponse;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\GetApaasAppHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\GetApaasAppResponse;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\GetAppResourceUseInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\GetAppResourceUseInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\GetAppResourceUseInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\GetAppRoleScopeByRoleIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\GetAppRoleScopeByRoleIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\GetInnerAppHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\GetInnerAppRequest;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\GetInnerAppResponse;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\GetMicroAppScopeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\GetMicroAppScopeResponse;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\GetMicroAppUserAccessHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\GetMicroAppUserAccessResponse;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\GetUserAppDevAccessHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\GetUserAppDevAccessResponse;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\ListAllAppHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\ListAllAppResponse;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\ListAllInnerAppsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\ListAllInnerAppsResponse;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\ListAppRoleScopesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\ListAppRoleScopesRequest;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\ListAppRoleScopesResponse;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\ListInnerAppHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\ListInnerAppRequest;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\ListInnerAppResponse;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\ListInnerAppVersionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\ListInnerAppVersionResponse;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\ListRoleInfoByUserHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\ListRoleInfoByUserResponse;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\ListUserVilebleAppHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\ListUserVilebleAppResponse;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\PageInnerAppHistoryVersionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\PageInnerAppHistoryVersionRequest;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\PageInnerAppHistoryVersionResponse;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\PublishInnerAppVersionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\PublishInnerAppVersionRequest;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\PublishInnerAppVersionResponse;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\RebuildRoleScopeForAppRoleHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\RebuildRoleScopeForAppRoleRequest;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\RebuildRoleScopeForAppRoleResponse;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\RegisterCustomAppRoleHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\RegisterCustomAppRoleRequest;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\RegisterCustomAppRoleResponse;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\RemoveApaasAppHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\RemoveApaasAppRequest;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\RemoveApaasAppResponse;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\RemoveMemberForAppRoleHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\RemoveMemberForAppRoleRequest;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\RemoveMemberForAppRoleResponse;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\RollbackInnerAppVersionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\RollbackInnerAppVersionRequest;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\RollbackInnerAppVersionResponse;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\SetMicroAppScopeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\SetMicroAppScopeRequest;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\SetMicroAppScopeResponse;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\UpdateApaasAppHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\UpdateApaasAppRequest;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\UpdateApaasAppResponse;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\UpdateAppRoleInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\UpdateAppRoleInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\UpdateAppRoleInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\UpdateInnerAppHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\UpdateInnerAppRequest;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\UpdateInnerAppResponse;
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
        $this->_signatureAlgorithm = 'v2';
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @summary 给指定成员添加角色
     *  *
     * @param string                     $agentId
     * @param AddAppRolesToMemberRequest $request AddAppRolesToMemberRequest
     * @param AddAppRolesToMemberHeaders $headers AddAppRolesToMemberHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return AddAppRolesToMemberResponse AddAppRolesToMemberResponse
     */
    public function addAppRolesToMemberWithOptions($agentId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->memberId)) {
            $body['memberId'] = $request->memberId;
        }
        if (!Utils::isUnset($request->memberType)) {
            $body['memberType'] = $request->memberType;
        }
        if (!Utils::isUnset($request->opUserId)) {
            $body['opUserId'] = $request->opUserId;
        }
        if (!Utils::isUnset($request->roleList)) {
            $body['roleList'] = $request->roleList;
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
            'action' => 'AddAppRolesToMember',
            'version' => 'microApp_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/microApp/apps/' . $agentId . '/members/roles',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return AddAppRolesToMemberResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 给指定成员添加角色
     *  *
     * @param string                     $agentId
     * @param AddAppRolesToMemberRequest $request AddAppRolesToMemberRequest
     *
     * @return AddAppRolesToMemberResponse AddAppRolesToMemberResponse
     */
    public function addAppRolesToMember($agentId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddAppRolesToMemberHeaders([]);

        return $this->addAppRolesToMemberWithOptions($agentId, $request, $headers, $runtime);
    }

    /**
     * @summary 添加应用到工作台分组
     *  *
     * @param string                        $agentId
     * @param AddAppToWorkBenchGroupRequest $request AddAppToWorkBenchGroupRequest
     * @param AddAppToWorkBenchGroupHeaders $headers AddAppToWorkBenchGroupHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return AddAppToWorkBenchGroupResponse AddAppToWorkBenchGroupResponse
     */
    public function addAppToWorkBenchGroupWithOptions($agentId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->componentId)) {
            $body['componentId'] = $request->componentId;
        }
        if (!Utils::isUnset($request->ecologicalCorpId)) {
            $body['ecologicalCorpId'] = $request->ecologicalCorpId;
        }
        if (!Utils::isUnset($request->opUnionId)) {
            $body['opUnionId'] = $request->opUnionId;
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
            'action' => 'AddAppToWorkBenchGroup',
            'version' => 'microApp_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/microApp/apps/' . $agentId . '/addToWorkBenchGroup',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return AddAppToWorkBenchGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 添加应用到工作台分组
     *  *
     * @param string                        $agentId
     * @param AddAppToWorkBenchGroupRequest $request AddAppToWorkBenchGroupRequest
     *
     * @return AddAppToWorkBenchGroupResponse AddAppToWorkBenchGroupResponse
     */
    public function addAppToWorkBenchGroup($agentId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddAppToWorkBenchGroupHeaders([]);

        return $this->addAppToWorkBenchGroupWithOptions($agentId, $request, $headers, $runtime);
    }

    /**
     * @summary 给指定角色添加人员
     *  *
     * @param string                    $agentId
     * @param string                    $roleId
     * @param AddMemberToAppRoleRequest $request AddMemberToAppRoleRequest
     * @param AddMemberToAppRoleHeaders $headers AddMemberToAppRoleHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return AddMemberToAppRoleResponse AddMemberToAppRoleResponse
     */
    public function addMemberToAppRoleWithOptions($agentId, $roleId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->deptIdList)) {
            $body['deptIdList'] = $request->deptIdList;
        }
        if (!Utils::isUnset($request->opUserId)) {
            $body['opUserId'] = $request->opUserId;
        }
        if (!Utils::isUnset($request->scopeVersion)) {
            $body['scopeVersion'] = $request->scopeVersion;
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
            'action' => 'AddMemberToAppRole',
            'version' => 'microApp_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/microApp/apps/' . $agentId . '/roles/' . $roleId . '/members',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return AddMemberToAppRoleResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 给指定角色添加人员
     *  *
     * @param string                    $agentId
     * @param string                    $roleId
     * @param AddMemberToAppRoleRequest $request AddMemberToAppRoleRequest
     *
     * @return AddMemberToAppRoleResponse AddMemberToAppRoleResponse
     */
    public function addMemberToAppRole($agentId, $roleId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddMemberToAppRoleHeaders([]);

        return $this->addMemberToAppRoleWithOptions($agentId, $roleId, $request, $headers, $runtime);
    }

    /**
     * @summary AnheiP
     *  *
     * @param string[]       $headers map
     * @param RuntimeOptions $runtime runtime options for this request RuntimeOptions
     *
     * @return AnheiPResponse AnheiPResponse
     */
    public function anheiPWithOptions($headers, $runtime)
    {
        $req = new OpenApiRequest([
            'headers' => $headers,
        ]);
        $params = new Params([
            'action' => 'AnheiP',
            'version' => 'microApp_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/microApp/anheiP',
            'method' => 'GET',
            'authType' => 'Anonymous',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return AnheiPResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary AnheiP
     *  *
     * @return AnheiPResponse AnheiPResponse
     */
    public function anheiP()
    {
        $runtime = new RuntimeOptions([]);
        $headers = [];

        return $this->anheiPWithOptions($headers, $runtime);
    }

    /**
     * @summary AnheiTest888
     *  *
     * @param string[]       $headers map
     * @param RuntimeOptions $runtime runtime options for this request RuntimeOptions
     *
     * @return AnheiTest888Response AnheiTest888Response
     */
    public function anheiTest888WithOptions($headers, $runtime)
    {
        $req = new OpenApiRequest([
            'headers' => $headers,
        ]);
        $params = new Params([
            'action' => 'AnheiTest888',
            'version' => 'microApp_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/microApp/anheiTest888',
            'method' => 'POST',
            'authType' => 'Anonymous',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return AnheiTest888Response::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary AnheiTest888
     *  *
     * @return AnheiTest888Response AnheiTest888Response
     */
    public function anheiTest888()
    {
        $runtime = new RuntimeOptions([]);
        $headers = [];

        return $this->anheiTest888WithOptions($headers, $runtime);
    }

    /**
     * @summary AnheiTestB
     *  *
     * @param string[]       $headers map
     * @param RuntimeOptions $runtime runtime options for this request RuntimeOptions
     *
     * @return AnheiTestBResponse AnheiTestBResponse
     */
    public function anheiTestBWithOptions($headers, $runtime)
    {
        $req = new OpenApiRequest([
            'headers' => $headers,
        ]);
        $params = new Params([
            'action' => 'AnheiTestB',
            'version' => 'microApp_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/microApp/anheiTestB',
            'method' => 'PUT',
            'authType' => 'Anonymous',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return AnheiTestBResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary AnheiTestB
     *  *
     * @return AnheiTestBResponse AnheiTestBResponse
     */
    public function anheiTestB()
    {
        $runtime = new RuntimeOptions([]);
        $headers = [];

        return $this->anheiTestBWithOptions($headers, $runtime);
    }

    /**
     * @summary 暗黑测试
     *  *
     * @param string[]       $headers map
     * @param RuntimeOptions $runtime runtime options for this request RuntimeOptions
     *
     * @return AnheiTestNineResponse AnheiTestNineResponse
     */
    public function anheiTestNineWithOptions($headers, $runtime)
    {
        $req = new OpenApiRequest([
            'headers' => $headers,
        ]);
        $params = new Params([
            'action' => 'AnheiTestNine',
            'version' => 'microApp_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/microApp/anheiTestNine',
            'method' => 'POST',
            'authType' => 'Anonymous',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return AnheiTestNineResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 暗黑测试
     *  *
     * @return AnheiTestNineResponse AnheiTestNineResponse
     */
    public function anheiTestNine()
    {
        $runtime = new RuntimeOptions([]);
        $headers = [];

        return $this->anheiTestNineWithOptions($headers, $runtime);
    }

    /**
     * @summary 应用状态管理测试
     *  *
     * @param AppStatusManagerTestRequest $request AppStatusManagerTestRequest
     * @param string[]                    $headers map
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return AppStatusManagerTestResponse AppStatusManagerTestResponse
     */
    public function appStatusManagerTestWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->requestId)) {
            $query['requestId'] = $request->requestId;
        }
        $req = new OpenApiRequest([
            'headers' => $headers,
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'AppStatusManagerTest',
            'version' => 'microApp_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/microApp/manager/test',
            'method' => 'GET',
            'authType' => 'Anonymous',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return AppStatusManagerTestResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 应用状态管理测试
     *  *
     * @param AppStatusManagerTestRequest $request AppStatusManagerTestRequest
     *
     * @return AppStatusManagerTestResponse AppStatusManagerTestResponse
     */
    public function appStatusManagerTest($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = [];

        return $this->appStatusManagerTestWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 能力开放中心录入测试数据
     *  *
     * @param string[]       $headers map
     * @param RuntimeOptions $runtime runtime options for this request RuntimeOptions
     *
     * @return AyunTestResponse AyunTestResponse
     */
    public function ayunTestWithOptions($headers, $runtime)
    {
        $req = new OpenApiRequest([
            'headers' => $headers,
        ]);
        $params = new Params([
            'action' => 'AyunTest',
            'version' => 'microApp_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/microApp/ayun/test',
            'method' => 'GET',
            'authType' => 'Anonymous',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return AyunTestResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 能力开放中心录入测试数据
     *  *
     * @return AyunTestResponse AyunTestResponse
     */
    public function ayunTest()
    {
        $runtime = new RuntimeOptions([]);
        $headers = [];

        return $this->ayunTestWithOptions($headers, $runtime);
    }

    /**
     * @summary openAPI录入上线后的测试
     *  *
     * @param string[]       $headers map
     * @param RuntimeOptions $runtime runtime options for this request RuntimeOptions
     *
     * @return AyunTestOnlineResponse AyunTestOnlineResponse
     */
    public function ayunTestOnlineWithOptions($headers, $runtime)
    {
        $req = new OpenApiRequest([
            'headers' => $headers,
        ]);
        $params = new Params([
            'action' => 'AyunTestOnline',
            'version' => 'microApp_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/microApp/ayunTest',
            'method' => 'GET',
            'authType' => 'Anonymous',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return AyunTestOnlineResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary openAPI录入上线后的测试
     *  *
     * @return AyunTestOnlineResponse AyunTestOnlineResponse
     */
    public function ayunTestOnline()
    {
        $runtime = new RuntimeOptions([]);
        $headers = [];

        return $this->ayunTestOnlineWithOptions($headers, $runtime);
    }

    /**
     * @summary 创建Apaas应用
     *  *
     * @param CreateApaasAppRequest $request CreateApaasAppRequest
     * @param CreateApaasAppHeaders $headers CreateApaasAppHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateApaasAppResponse CreateApaasAppResponse
     */
    public function createApaasAppWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appDesc)) {
            $body['appDesc'] = $request->appDesc;
        }
        if (!Utils::isUnset($request->appIcon)) {
            $body['appIcon'] = $request->appIcon;
        }
        if (!Utils::isUnset($request->appName)) {
            $body['appName'] = $request->appName;
        }
        if (!Utils::isUnset($request->bizAppId)) {
            $body['bizAppId'] = $request->bizAppId;
        }
        if (!Utils::isUnset($request->homepageEditLink)) {
            $body['homepageEditLink'] = $request->homepageEditLink;
        }
        if (!Utils::isUnset($request->homepageLink)) {
            $body['homepageLink'] = $request->homepageLink;
        }
        if (!Utils::isUnset($request->isShortCut)) {
            $body['isShortCut'] = $request->isShortCut;
        }
        if (!Utils::isUnset($request->ompLink)) {
            $body['ompLink'] = $request->ompLink;
        }
        if (!Utils::isUnset($request->opUserId)) {
            $body['opUserId'] = $request->opUserId;
        }
        if (!Utils::isUnset($request->pcHomepageEditLink)) {
            $body['pcHomepageEditLink'] = $request->pcHomepageEditLink;
        }
        if (!Utils::isUnset($request->pcHomepageLink)) {
            $body['pcHomepageLink'] = $request->pcHomepageLink;
        }
        if (!Utils::isUnset($request->templateKey)) {
            $body['templateKey'] = $request->templateKey;
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
            'action' => 'CreateApaasApp',
            'version' => 'microApp_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/microApp/apaasApps',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateApaasAppResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建Apaas应用
     *  *
     * @param CreateApaasAppRequest $request CreateApaasAppRequest
     *
     * @return CreateApaasAppResponse CreateApaasAppResponse
     */
    public function createApaasApp($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateApaasAppHeaders([]);

        return $this->createApaasAppWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建企业内部应用
     *  *
     * @param CreateInnerAppRequest $request CreateInnerAppRequest
     * @param CreateInnerAppHeaders $headers CreateInnerAppHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateInnerAppResponse CreateInnerAppResponse
     */
    public function createInnerAppWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->desc)) {
            $body['desc'] = $request->desc;
        }
        if (!Utils::isUnset($request->developType)) {
            $body['developType'] = $request->developType;
        }
        if (!Utils::isUnset($request->homepageLink)) {
            $body['homepageLink'] = $request->homepageLink;
        }
        if (!Utils::isUnset($request->icon)) {
            $body['icon'] = $request->icon;
        }
        if (!Utils::isUnset($request->ipWhiteList)) {
            $body['ipWhiteList'] = $request->ipWhiteList;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->ompLink)) {
            $body['ompLink'] = $request->ompLink;
        }
        if (!Utils::isUnset($request->opUnionId)) {
            $body['opUnionId'] = $request->opUnionId;
        }
        if (!Utils::isUnset($request->pcHomepageLink)) {
            $body['pcHomepageLink'] = $request->pcHomepageLink;
        }
        if (!Utils::isUnset($request->scopeType)) {
            $body['scopeType'] = $request->scopeType;
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
            'action' => 'CreateInnerApp',
            'version' => 'microApp_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/microApp/apps',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateInnerAppResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建企业内部应用
     *  *
     * @param CreateInnerAppRequest $request CreateInnerAppRequest
     *
     * @return CreateInnerAppResponse CreateInnerAppResponse
     */
    public function createInnerApp($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateInnerAppHeaders([]);

        return $this->createInnerAppWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除应用角色
     *  *
     * @param string               $agentId
     * @param string               $roleId
     * @param DeleteAppRoleRequest $request DeleteAppRoleRequest
     * @param DeleteAppRoleHeaders $headers DeleteAppRoleHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteAppRoleResponse DeleteAppRoleResponse
     */
    public function deleteAppRoleWithOptions($agentId, $roleId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->opUserId)) {
            $query['opUserId'] = $request->opUserId;
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
            'action' => 'DeleteAppRole',
            'version' => 'microApp_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/microApp/apps/' . $agentId . '/roles/' . $roleId . '',
            'method' => 'DELETE',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return DeleteAppRoleResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除应用角色
     *  *
     * @param string               $agentId
     * @param string               $roleId
     * @param DeleteAppRoleRequest $request DeleteAppRoleRequest
     *
     * @return DeleteAppRoleResponse DeleteAppRoleResponse
     */
    public function deleteAppRole($agentId, $roleId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteAppRoleHeaders([]);

        return $this->deleteAppRoleWithOptions($agentId, $roleId, $request, $headers, $runtime);
    }

    /**
     * @summary 删除企业内部应用
     *  *
     * @param string                $agentId
     * @param DeleteInnerAppRequest $request DeleteInnerAppRequest
     * @param DeleteInnerAppHeaders $headers DeleteInnerAppHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteInnerAppResponse DeleteInnerAppResponse
     */
    public function deleteInnerAppWithOptions($agentId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->opUnionId)) {
            $query['opUnionId'] = $request->opUnionId;
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
            'action' => 'DeleteInnerApp',
            'version' => 'microApp_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/microApp/apps/' . $agentId . '',
            'method' => 'DELETE',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return DeleteInnerAppResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除企业内部应用
     *  *
     * @param string                $agentId
     * @param DeleteInnerAppRequest $request DeleteInnerAppRequest
     *
     * @return DeleteInnerAppResponse DeleteInnerAppResponse
     */
    public function deleteInnerApp($agentId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteInnerAppHeaders([]);

        return $this->deleteInnerAppWithOptions($agentId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询Apaas应用
     *  *
     * @param string             $bizAppId
     * @param GetApaasAppHeaders $headers  GetApaasAppHeaders
     * @param RuntimeOptions     $runtime  runtime options for this request RuntimeOptions
     *
     * @return GetApaasAppResponse GetApaasAppResponse
     */
    public function getApaasAppWithOptions($bizAppId, $headers, $runtime)
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
            'action' => 'GetApaasApp',
            'version' => 'microApp_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/microApp/apaasApps/' . $bizAppId . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetApaasAppResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询Apaas应用
     *  *
     * @param string $bizAppId
     *
     * @return GetApaasAppResponse GetApaasAppResponse
     */
    public function getApaasApp($bizAppId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetApaasAppHeaders([]);

        return $this->getApaasAppWithOptions($bizAppId, $headers, $runtime);
    }

    /**
     * @summary 获取应用资源用量信息
     *  *
     * @param GetAppResourceUseInfoRequest $request GetAppResourceUseInfoRequest
     * @param GetAppResourceUseInfoHeaders $headers GetAppResourceUseInfoHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return GetAppResourceUseInfoResponse GetAppResourceUseInfoResponse
     */
    public function getAppResourceUseInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->benefitCode)) {
            $query['benefitCode'] = $request->benefitCode;
        }
        if (!Utils::isUnset($request->endTime)) {
            $query['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->periodType)) {
            $query['periodType'] = $request->periodType;
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'GetAppResourceUseInfo',
            'version' => 'microApp_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/microApp/resources/useInfos',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'array',
        ]);

        return GetAppResourceUseInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取应用资源用量信息
     *  *
     * @param GetAppResourceUseInfoRequest $request GetAppResourceUseInfoRequest
     *
     * @return GetAppResourceUseInfoResponse GetAppResourceUseInfoResponse
     */
    public function getAppResourceUseInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetAppResourceUseInfoHeaders([]);

        return $this->getAppResourceUseInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询指定角色的角色范围
     *  *
     * @param string                         $agentId
     * @param string                         $roleId
     * @param GetAppRoleScopeByRoleIdHeaders $headers GetAppRoleScopeByRoleIdHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return GetAppRoleScopeByRoleIdResponse GetAppRoleScopeByRoleIdResponse
     */
    public function getAppRoleScopeByRoleIdWithOptions($agentId, $roleId, $headers, $runtime)
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
            'action' => 'GetAppRoleScopeByRoleId',
            'version' => 'microApp_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/microApp/apps/' . $agentId . '/roles/' . $roleId . '/scopes',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return GetAppRoleScopeByRoleIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询指定角色的角色范围
     *  *
     * @param string $agentId
     * @param string $roleId
     *
     * @return GetAppRoleScopeByRoleIdResponse GetAppRoleScopeByRoleIdResponse
     */
    public function getAppRoleScopeByRoleId($agentId, $roleId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetAppRoleScopeByRoleIdHeaders([]);

        return $this->getAppRoleScopeByRoleIdWithOptions($agentId, $roleId, $headers, $runtime);
    }

    /**
     * @summary 获取企业内部H5应用
     *  *
     * @param string             $agentId
     * @param GetInnerAppRequest $request GetInnerAppRequest
     * @param GetInnerAppHeaders $headers GetInnerAppHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return GetInnerAppResponse GetInnerAppResponse
     */
    public function getInnerAppWithOptions($agentId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->ecologicalCorpId)) {
            $query['ecologicalCorpId'] = $request->ecologicalCorpId;
        }
        if (!Utils::isUnset($request->opUnionId)) {
            $query['opUnionId'] = $request->opUnionId;
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
            'action' => 'GetInnerApp',
            'version' => 'microApp_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/microApp/apps/' . $agentId . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetInnerAppResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取企业内部H5应用
     *  *
     * @param string             $agentId
     * @param GetInnerAppRequest $request GetInnerAppRequest
     *
     * @return GetInnerAppResponse GetInnerAppResponse
     */
    public function getInnerApp($agentId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetInnerAppHeaders([]);

        return $this->getInnerAppWithOptions($agentId, $request, $headers, $runtime);
    }

    /**
     * @summary 获取应用可见范围
     *  *
     * @param string                  $agentId
     * @param GetMicroAppScopeHeaders $headers GetMicroAppScopeHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return GetMicroAppScopeResponse GetMicroAppScopeResponse
     */
    public function getMicroAppScopeWithOptions($agentId, $headers, $runtime)
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
            'action' => 'GetMicroAppScope',
            'version' => 'microApp_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/microApp/apps/' . $agentId . '/scopes',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetMicroAppScopeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取应用可见范围
     *  *
     * @param string $agentId
     *
     * @return GetMicroAppScopeResponse GetMicroAppScopeResponse
     */
    public function getMicroAppScope($agentId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetMicroAppScopeHeaders([]);

        return $this->getMicroAppScopeWithOptions($agentId, $headers, $runtime);
    }

    /**
     * @summary 获取用户对应用的管理权限
     *  *
     * @param string                       $agentId
     * @param string                       $userId
     * @param GetMicroAppUserAccessHeaders $headers GetMicroAppUserAccessHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return GetMicroAppUserAccessResponse GetMicroAppUserAccessResponse
     */
    public function getMicroAppUserAccessWithOptions($agentId, $userId, $headers, $runtime)
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
            'action' => 'GetMicroAppUserAccess',
            'version' => 'microApp_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/microApp/apps/' . $agentId . '/users/' . $userId . '/adminAccess',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetMicroAppUserAccessResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取用户对应用的管理权限
     *  *
     * @param string $agentId
     * @param string $userId
     *
     * @return GetMicroAppUserAccessResponse GetMicroAppUserAccessResponse
     */
    public function getMicroAppUserAccess($agentId, $userId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetMicroAppUserAccessHeaders([]);

        return $this->getMicroAppUserAccessWithOptions($agentId, $userId, $headers, $runtime);
    }

    /**
     * @summary 用户是否拥有开发者权限
     *  *
     * @param string                     $userId
     * @param GetUserAppDevAccessHeaders $headers GetUserAppDevAccessHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return GetUserAppDevAccessResponse GetUserAppDevAccessResponse
     */
    public function getUserAppDevAccessWithOptions($userId, $headers, $runtime)
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
            'action' => 'GetUserAppDevAccess',
            'version' => 'microApp_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/microApp/users/' . $userId . '/devAccesses',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetUserAppDevAccessResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 用户是否拥有开发者权限
     *  *
     * @param string $userId
     *
     * @return GetUserAppDevAccessResponse GetUserAppDevAccessResponse
     */
    public function getUserAppDevAccess($userId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetUserAppDevAccessHeaders([]);

        return $this->getUserAppDevAccessWithOptions($userId, $headers, $runtime);
    }

    /**
     * @summary 获取企业所有应用列表
     *  *
     * @param ListAllAppHeaders $headers ListAllAppHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return ListAllAppResponse ListAllAppResponse
     */
    public function listAllAppWithOptions($headers, $runtime)
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
            'action' => 'ListAllApp',
            'version' => 'microApp_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/microApp/allApps',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ListAllAppResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取企业所有应用列表
     *  *
     * @return ListAllAppResponse ListAllAppResponse
     */
    public function listAllApp()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListAllAppHeaders([]);

        return $this->listAllAppWithOptions($headers, $runtime);
    }

    /**
     * @summary 获取企业所有内部应用列表
     *  *
     * @param ListAllInnerAppsHeaders $headers ListAllInnerAppsHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return ListAllInnerAppsResponse ListAllInnerAppsResponse
     */
    public function listAllInnerAppsWithOptions($headers, $runtime)
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
            'action' => 'ListAllInnerApps',
            'version' => 'microApp_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/microApp/allInnerApps',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ListAllInnerAppsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取企业所有内部应用列表
     *  *
     * @return ListAllInnerAppsResponse ListAllInnerAppsResponse
     */
    public function listAllInnerApps()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListAllInnerAppsHeaders([]);

        return $this->listAllInnerAppsWithOptions($headers, $runtime);
    }

    /**
     * @summary 获取企业应用的角色完整信息
     *  *
     * @param string                   $agentId
     * @param ListAppRoleScopesRequest $request ListAppRoleScopesRequest
     * @param ListAppRoleScopesHeaders $headers ListAppRoleScopesHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return ListAppRoleScopesResponse ListAppRoleScopesResponse
     */
    public function listAppRoleScopesWithOptions($agentId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->size)) {
            $query['size'] = $request->size;
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
            'action' => 'ListAppRoleScopes',
            'version' => 'microApp_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/microApp/apps/' . $agentId . '/roles',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return ListAppRoleScopesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取企业应用的角色完整信息
     *  *
     * @param string                   $agentId
     * @param ListAppRoleScopesRequest $request ListAppRoleScopesRequest
     *
     * @return ListAppRoleScopesResponse ListAppRoleScopesResponse
     */
    public function listAppRoleScopes($agentId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListAppRoleScopesHeaders([]);

        return $this->listAppRoleScopesWithOptions($agentId, $request, $headers, $runtime);
    }

    /**
     * @summary 列出企业内部H5应用
     *  *
     * @param ListInnerAppRequest $request ListInnerAppRequest
     * @param ListInnerAppHeaders $headers ListInnerAppHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return ListInnerAppResponse ListInnerAppResponse
     */
    public function listInnerAppWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->ecologicalCorpId)) {
            $query['ecologicalCorpId'] = $request->ecologicalCorpId;
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
            'action' => 'ListInnerApp',
            'version' => 'microApp_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/microApp/apps',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ListInnerAppResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 列出企业内部H5应用
     *  *
     * @param ListInnerAppRequest $request ListInnerAppRequest
     *
     * @return ListInnerAppResponse ListInnerAppResponse
     */
    public function listInnerApp($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListInnerAppHeaders([]);

        return $this->listInnerAppWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取企业内部小程序的版本列表
     *  *
     * @param string                     $agentId
     * @param ListInnerAppVersionHeaders $headers ListInnerAppVersionHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return ListInnerAppVersionResponse ListInnerAppVersionResponse
     */
    public function listInnerAppVersionWithOptions($agentId, $headers, $runtime)
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
            'action' => 'ListInnerAppVersion',
            'version' => 'microApp_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/microApp/innerMiniApps/' . $agentId . '/versions',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ListInnerAppVersionResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取企业内部小程序的版本列表
     *  *
     * @param string $agentId
     *
     * @return ListInnerAppVersionResponse ListInnerAppVersionResponse
     */
    public function listInnerAppVersion($agentId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListInnerAppVersionHeaders([]);

        return $this->listInnerAppVersionWithOptions($agentId, $headers, $runtime);
    }

    /**
     * @summary 获取用户在应用中的角色信息列表
     *  *
     * @param string                    $agentId
     * @param string                    $userId
     * @param ListRoleInfoByUserHeaders $headers ListRoleInfoByUserHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return ListRoleInfoByUserResponse ListRoleInfoByUserResponse
     */
    public function listRoleInfoByUserWithOptions($agentId, $userId, $headers, $runtime)
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
            'action' => 'ListRoleInfoByUser',
            'version' => 'microApp_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/microApp/apps/' . $agentId . '/users/' . $userId . '/roles',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return ListRoleInfoByUserResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取用户在应用中的角色信息列表
     *  *
     * @param string $agentId
     * @param string $userId
     *
     * @return ListRoleInfoByUserResponse ListRoleInfoByUserResponse
     */
    public function listRoleInfoByUser($agentId, $userId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListRoleInfoByUserHeaders([]);

        return $this->listRoleInfoByUserWithOptions($agentId, $userId, $headers, $runtime);
    }

    /**
     * @summary 列出用户可见的企业应用
     *  *
     * @param string                    $userId
     * @param ListUserVilebleAppHeaders $headers ListUserVilebleAppHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return ListUserVilebleAppResponse ListUserVilebleAppResponse
     */
    public function listUserVilebleAppWithOptions($userId, $headers, $runtime)
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
            'action' => 'ListUserVilebleApp',
            'version' => 'microApp_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/microApp/users/' . $userId . '/apps',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ListUserVilebleAppResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 列出用户可见的企业应用
     *  *
     * @param string $userId
     *
     * @return ListUserVilebleAppResponse ListUserVilebleAppResponse
     */
    public function listUserVilebleApp($userId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListUserVilebleAppHeaders([]);

        return $this->listUserVilebleAppWithOptions($userId, $headers, $runtime);
    }

    /**
     * @summary 获取企业内部小程序历史版本列表
     *  *
     * @param string                            $agentId
     * @param PageInnerAppHistoryVersionRequest $request PageInnerAppHistoryVersionRequest
     * @param PageInnerAppHistoryVersionHeaders $headers PageInnerAppHistoryVersionHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return PageInnerAppHistoryVersionResponse PageInnerAppHistoryVersionResponse
     */
    public function pageInnerAppHistoryVersionWithOptions($agentId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
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
            'action' => 'PageInnerAppHistoryVersion',
            'version' => 'microApp_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/microApp/innerMiniApps/' . $agentId . '/historyVersions',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return PageInnerAppHistoryVersionResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取企业内部小程序历史版本列表
     *  *
     * @param string                            $agentId
     * @param PageInnerAppHistoryVersionRequest $request PageInnerAppHistoryVersionRequest
     *
     * @return PageInnerAppHistoryVersionResponse PageInnerAppHistoryVersionResponse
     */
    public function pageInnerAppHistoryVersion($agentId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PageInnerAppHistoryVersionHeaders([]);

        return $this->pageInnerAppHistoryVersionWithOptions($agentId, $request, $headers, $runtime);
    }

    /**
     * @summary 发布企业内部小程序版本
     *  *
     * @param string                        $agentId
     * @param PublishInnerAppVersionRequest $request PublishInnerAppVersionRequest
     * @param PublishInnerAppVersionHeaders $headers PublishInnerAppVersionHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return PublishInnerAppVersionResponse PublishInnerAppVersionResponse
     */
    public function publishInnerAppVersionWithOptions($agentId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appVersionId)) {
            $body['appVersionId'] = $request->appVersionId;
        }
        if (!Utils::isUnset($request->miniAppOnPc)) {
            $body['miniAppOnPc'] = $request->miniAppOnPc;
        }
        if (!Utils::isUnset($request->opUnionId)) {
            $body['opUnionId'] = $request->opUnionId;
        }
        if (!Utils::isUnset($request->publishType)) {
            $body['publishType'] = $request->publishType;
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
            'action' => 'PublishInnerAppVersion',
            'version' => 'microApp_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/microApp/innerMiniApps/' . $agentId . '/versions/publish',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return PublishInnerAppVersionResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 发布企业内部小程序版本
     *  *
     * @param string                        $agentId
     * @param PublishInnerAppVersionRequest $request PublishInnerAppVersionRequest
     *
     * @return PublishInnerAppVersionResponse PublishInnerAppVersionResponse
     */
    public function publishInnerAppVersion($agentId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PublishInnerAppVersionHeaders([]);

        return $this->publishInnerAppVersionWithOptions($agentId, $request, $headers, $runtime);
    }

    /**
     * @summary 重设角色范围
     *  *
     * @param string                            $agentId
     * @param string                            $roleId
     * @param RebuildRoleScopeForAppRoleRequest $request RebuildRoleScopeForAppRoleRequest
     * @param RebuildRoleScopeForAppRoleHeaders $headers RebuildRoleScopeForAppRoleHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return RebuildRoleScopeForAppRoleResponse RebuildRoleScopeForAppRoleResponse
     */
    public function rebuildRoleScopeForAppRoleWithOptions($agentId, $roleId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->deptIdList)) {
            $body['deptIdList'] = $request->deptIdList;
        }
        if (!Utils::isUnset($request->opUserId)) {
            $body['opUserId'] = $request->opUserId;
        }
        if (!Utils::isUnset($request->scopeType)) {
            $body['scopeType'] = $request->scopeType;
        }
        if (!Utils::isUnset($request->scopeVersion)) {
            $body['scopeVersion'] = $request->scopeVersion;
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
            'action' => 'RebuildRoleScopeForAppRole',
            'version' => 'microApp_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/microApp/apps/' . $agentId . '/roles/' . $roleId . '/scopes/rebuild',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return RebuildRoleScopeForAppRoleResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 重设角色范围
     *  *
     * @param string                            $agentId
     * @param string                            $roleId
     * @param RebuildRoleScopeForAppRoleRequest $request RebuildRoleScopeForAppRoleRequest
     *
     * @return RebuildRoleScopeForAppRoleResponse RebuildRoleScopeForAppRoleResponse
     */
    public function rebuildRoleScopeForAppRole($agentId, $roleId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RebuildRoleScopeForAppRoleHeaders([]);

        return $this->rebuildRoleScopeForAppRoleWithOptions($agentId, $roleId, $request, $headers, $runtime);
    }

    /**
     * @summary 注册自定义应用角色
     *  *
     * @param string                       $agentId
     * @param RegisterCustomAppRoleRequest $request RegisterCustomAppRoleRequest
     * @param RegisterCustomAppRoleHeaders $headers RegisterCustomAppRoleHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return RegisterCustomAppRoleResponse RegisterCustomAppRoleResponse
     */
    public function registerCustomAppRoleWithOptions($agentId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->canManageRole)) {
            $body['canManageRole'] = $request->canManageRole;
        }
        if (!Utils::isUnset($request->opUserId)) {
            $body['opUserId'] = $request->opUserId;
        }
        if (!Utils::isUnset($request->roleName)) {
            $body['roleName'] = $request->roleName;
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
            'action' => 'RegisterCustomAppRole',
            'version' => 'microApp_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/microApp/apps/' . $agentId . '/roles',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return RegisterCustomAppRoleResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 注册自定义应用角色
     *  *
     * @param string                       $agentId
     * @param RegisterCustomAppRoleRequest $request RegisterCustomAppRoleRequest
     *
     * @return RegisterCustomAppRoleResponse RegisterCustomAppRoleResponse
     */
    public function registerCustomAppRole($agentId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RegisterCustomAppRoleHeaders([]);

        return $this->registerCustomAppRoleWithOptions($agentId, $request, $headers, $runtime);
    }

    /**
     * @summary 删除apaas应用
     *  *
     * @param RemoveApaasAppRequest $request RemoveApaasAppRequest
     * @param RemoveApaasAppHeaders $headers RemoveApaasAppHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return RemoveApaasAppResponse RemoveApaasAppResponse
     */
    public function removeApaasAppWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizAppId)) {
            $body['bizAppId'] = $request->bizAppId;
        }
        if (!Utils::isUnset($request->opUserId)) {
            $body['opUserId'] = $request->opUserId;
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
            'action' => 'RemoveApaasApp',
            'version' => 'microApp_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/microApp/apaasApps/remove',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return RemoveApaasAppResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除apaas应用
     *  *
     * @param RemoveApaasAppRequest $request RemoveApaasAppRequest
     *
     * @return RemoveApaasAppResponse RemoveApaasAppResponse
     */
    public function removeApaasApp($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RemoveApaasAppHeaders([]);

        return $this->removeApaasAppWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除指定角色下的成员
     *  *
     * @param string                        $agentId
     * @param string                        $roleId
     * @param RemoveMemberForAppRoleRequest $request RemoveMemberForAppRoleRequest
     * @param RemoveMemberForAppRoleHeaders $headers RemoveMemberForAppRoleHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return RemoveMemberForAppRoleResponse RemoveMemberForAppRoleResponse
     */
    public function removeMemberForAppRoleWithOptions($agentId, $roleId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->deptIdList)) {
            $body['deptIdList'] = $request->deptIdList;
        }
        if (!Utils::isUnset($request->opUserId)) {
            $body['opUserId'] = $request->opUserId;
        }
        if (!Utils::isUnset($request->scopeVersion)) {
            $body['scopeVersion'] = $request->scopeVersion;
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
            'action' => 'RemoveMemberForAppRole',
            'version' => 'microApp_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/microApp/apps/' . $agentId . '/roles/' . $roleId . '/members/batchRemove',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return RemoveMemberForAppRoleResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除指定角色下的成员
     *  *
     * @param string                        $agentId
     * @param string                        $roleId
     * @param RemoveMemberForAppRoleRequest $request RemoveMemberForAppRoleRequest
     *
     * @return RemoveMemberForAppRoleResponse RemoveMemberForAppRoleResponse
     */
    public function removeMemberForAppRole($agentId, $roleId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RemoveMemberForAppRoleHeaders([]);

        return $this->removeMemberForAppRoleWithOptions($agentId, $roleId, $request, $headers, $runtime);
    }

    /**
     * @summary 回滚企业内部小程序版本
     *  *
     * @param string                         $agentId
     * @param RollbackInnerAppVersionRequest $request RollbackInnerAppVersionRequest
     * @param RollbackInnerAppVersionHeaders $headers RollbackInnerAppVersionHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return RollbackInnerAppVersionResponse RollbackInnerAppVersionResponse
     */
    public function rollbackInnerAppVersionWithOptions($agentId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appVersionId)) {
            $body['appVersionId'] = $request->appVersionId;
        }
        if (!Utils::isUnset($request->opUnionId)) {
            $body['opUnionId'] = $request->opUnionId;
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
            'action' => 'RollbackInnerAppVersion',
            'version' => 'microApp_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/microApp/innerMiniApps/' . $agentId . '/versions/rollback',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return RollbackInnerAppVersionResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 回滚企业内部小程序版本
     *  *
     * @param string                         $agentId
     * @param RollbackInnerAppVersionRequest $request RollbackInnerAppVersionRequest
     *
     * @return RollbackInnerAppVersionResponse RollbackInnerAppVersionResponse
     */
    public function rollbackInnerAppVersion($agentId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RollbackInnerAppVersionHeaders([]);

        return $this->rollbackInnerAppVersionWithOptions($agentId, $request, $headers, $runtime);
    }

    /**
     * @summary 设置应用可见范围
     *  *
     * @param string                  $agentId
     * @param SetMicroAppScopeRequest $request SetMicroAppScopeRequest
     * @param SetMicroAppScopeHeaders $headers SetMicroAppScopeHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return SetMicroAppScopeResponse SetMicroAppScopeResponse
     */
    public function setMicroAppScopeWithOptions($agentId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->addDeptIds)) {
            $body['addDeptIds'] = $request->addDeptIds;
        }
        if (!Utils::isUnset($request->addRoleIds)) {
            $body['addRoleIds'] = $request->addRoleIds;
        }
        if (!Utils::isUnset($request->addUserIds)) {
            $body['addUserIds'] = $request->addUserIds;
        }
        if (!Utils::isUnset($request->delDeptIds)) {
            $body['delDeptIds'] = $request->delDeptIds;
        }
        if (!Utils::isUnset($request->delRoleIds)) {
            $body['delRoleIds'] = $request->delRoleIds;
        }
        if (!Utils::isUnset($request->delUserIds)) {
            $body['delUserIds'] = $request->delUserIds;
        }
        if (!Utils::isUnset($request->onlyAdminVisible)) {
            $body['onlyAdminVisible'] = $request->onlyAdminVisible;
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
            'action' => 'SetMicroAppScope',
            'version' => 'microApp_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/microApp/apps/' . $agentId . '/scopes',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SetMicroAppScopeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 设置应用可见范围
     *  *
     * @param string                  $agentId
     * @param SetMicroAppScopeRequest $request SetMicroAppScopeRequest
     *
     * @return SetMicroAppScopeResponse SetMicroAppScopeResponse
     */
    public function setMicroAppScope($agentId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SetMicroAppScopeHeaders([]);

        return $this->setMicroAppScopeWithOptions($agentId, $request, $headers, $runtime);
    }

    /**
     * @summary 更新apaas应用
     *  *
     * @param UpdateApaasAppRequest $request UpdateApaasAppRequest
     * @param UpdateApaasAppHeaders $headers UpdateApaasAppHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateApaasAppResponse UpdateApaasAppResponse
     */
    public function updateApaasAppWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appIcon)) {
            $body['appIcon'] = $request->appIcon;
        }
        if (!Utils::isUnset($request->appName)) {
            $body['appName'] = $request->appName;
        }
        if (!Utils::isUnset($request->appStatus)) {
            $body['appStatus'] = $request->appStatus;
        }
        if (!Utils::isUnset($request->bizAppId)) {
            $body['bizAppId'] = $request->bizAppId;
        }
        if (!Utils::isUnset($request->opUserId)) {
            $body['opUserId'] = $request->opUserId;
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
            'action' => 'UpdateApaasApp',
            'version' => 'microApp_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/microApp/apaasApps',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateApaasAppResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新apaas应用
     *  *
     * @param UpdateApaasAppRequest $request UpdateApaasAppRequest
     *
     * @return UpdateApaasAppResponse UpdateApaasAppResponse
     */
    public function updateApaasApp($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateApaasAppHeaders([]);

        return $this->updateApaasAppWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新应用角色信息
     *  *
     * @param string                   $agentId
     * @param string                   $roleId
     * @param UpdateAppRoleInfoRequest $request UpdateAppRoleInfoRequest
     * @param UpdateAppRoleInfoHeaders $headers UpdateAppRoleInfoHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateAppRoleInfoResponse UpdateAppRoleInfoResponse
     */
    public function updateAppRoleInfoWithOptions($agentId, $roleId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->canManageRole)) {
            $body['canManageRole'] = $request->canManageRole;
        }
        if (!Utils::isUnset($request->newRoleName)) {
            $body['newRoleName'] = $request->newRoleName;
        }
        if (!Utils::isUnset($request->opUserId)) {
            $body['opUserId'] = $request->opUserId;
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
            'action' => 'UpdateAppRoleInfo',
            'version' => 'microApp_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/microApp/apps/' . $agentId . '/roles/' . $roleId . '',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return UpdateAppRoleInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新应用角色信息
     *  *
     * @param string                   $agentId
     * @param string                   $roleId
     * @param UpdateAppRoleInfoRequest $request UpdateAppRoleInfoRequest
     *
     * @return UpdateAppRoleInfoResponse UpdateAppRoleInfoResponse
     */
    public function updateAppRoleInfo($agentId, $roleId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateAppRoleInfoHeaders([]);

        return $this->updateAppRoleInfoWithOptions($agentId, $roleId, $request, $headers, $runtime);
    }

    /**
     * @summary 更新企业内部应用
     *  *
     * @param string                $agentId
     * @param UpdateInnerAppRequest $request UpdateInnerAppRequest
     * @param UpdateInnerAppHeaders $headers UpdateInnerAppHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateInnerAppResponse UpdateInnerAppResponse
     */
    public function updateInnerAppWithOptions($agentId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->desc)) {
            $body['desc'] = $request->desc;
        }
        if (!Utils::isUnset($request->homepageLink)) {
            $body['homepageLink'] = $request->homepageLink;
        }
        if (!Utils::isUnset($request->icon)) {
            $body['icon'] = $request->icon;
        }
        if (!Utils::isUnset($request->ipWhiteList)) {
            $body['ipWhiteList'] = $request->ipWhiteList;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->ompLink)) {
            $body['ompLink'] = $request->ompLink;
        }
        if (!Utils::isUnset($request->opUnionId)) {
            $body['opUnionId'] = $request->opUnionId;
        }
        if (!Utils::isUnset($request->pcHomepageLink)) {
            $body['pcHomepageLink'] = $request->pcHomepageLink;
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
            'action' => 'UpdateInnerApp',
            'version' => 'microApp_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/microApp/apps/' . $agentId . '',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateInnerAppResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新企业内部应用
     *  *
     * @param string                $agentId
     * @param UpdateInnerAppRequest $request UpdateInnerAppRequest
     *
     * @return UpdateInnerAppResponse UpdateInnerAppResponse
     */
    public function updateInnerApp($agentId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateInnerAppHeaders([]);

        return $this->updateInnerAppWithOptions($agentId, $request, $headers, $runtime);
    }
}
