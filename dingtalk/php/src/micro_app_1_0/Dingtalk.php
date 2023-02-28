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
     * @param string                     $agentId
     * @param AddAppRolesToMemberRequest $request
     *
     * @return AddAppRolesToMemberResponse
     */
    public function addAppRolesToMember($agentId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddAppRolesToMemberHeaders([]);

        return $this->addAppRolesToMemberWithOptions($agentId, $request, $headers, $runtime);
    }

    /**
     * @param string                     $agentId
     * @param AddAppRolesToMemberRequest $request
     * @param AddAppRolesToMemberHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return AddAppRolesToMemberResponse
     */
    public function addAppRolesToMemberWithOptions($agentId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $agentId = OpenApiUtilClient::getEncodeParam($agentId);
        $body    = [];
        if (!Utils::isUnset($request->memberId)) {
            @$body['memberId'] = $request->memberId;
        }
        if (!Utils::isUnset($request->memberType)) {
            @$body['memberType'] = $request->memberType;
        }
        if (!Utils::isUnset($request->opUserId)) {
            @$body['opUserId'] = $request->opUserId;
        }
        if (!Utils::isUnset($request->roleList)) {
            @$body['roleList'] = $request->roleList;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return AddAppRolesToMemberResponse::fromMap($this->doROARequest('AddAppRolesToMember', 'microApp_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/microApp/apps/' . $agentId . '/members/roles', 'json', $req, $runtime));
    }

    /**
     * @param string                        $agentId
     * @param AddAppToWorkBenchGroupRequest $request
     *
     * @return AddAppToWorkBenchGroupResponse
     */
    public function addAppToWorkBenchGroup($agentId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddAppToWorkBenchGroupHeaders([]);

        return $this->addAppToWorkBenchGroupWithOptions($agentId, $request, $headers, $runtime);
    }

    /**
     * @param string                        $agentId
     * @param AddAppToWorkBenchGroupRequest $request
     * @param AddAppToWorkBenchGroupHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return AddAppToWorkBenchGroupResponse
     */
    public function addAppToWorkBenchGroupWithOptions($agentId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $agentId = OpenApiUtilClient::getEncodeParam($agentId);
        $body    = [];
        if (!Utils::isUnset($request->componentId)) {
            @$body['componentId'] = $request->componentId;
        }
        if (!Utils::isUnset($request->ecologicalCorpId)) {
            @$body['ecologicalCorpId'] = $request->ecologicalCorpId;
        }
        if (!Utils::isUnset($request->opUnionId)) {
            @$body['opUnionId'] = $request->opUnionId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return AddAppToWorkBenchGroupResponse::fromMap($this->doROARequest('AddAppToWorkBenchGroup', 'microApp_1.0', 'HTTP', 'POST', 'AK', '/v1.0/microApp/apps/' . $agentId . '/addToWorkBenchGroup', 'json', $req, $runtime));
    }

    /**
     * @param string                    $agentId
     * @param string                    $roleId
     * @param AddMemberToAppRoleRequest $request
     *
     * @return AddMemberToAppRoleResponse
     */
    public function addMemberToAppRole($agentId, $roleId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddMemberToAppRoleHeaders([]);

        return $this->addMemberToAppRoleWithOptions($agentId, $roleId, $request, $headers, $runtime);
    }

    /**
     * @param string                    $agentId
     * @param string                    $roleId
     * @param AddMemberToAppRoleRequest $request
     * @param AddMemberToAppRoleHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return AddMemberToAppRoleResponse
     */
    public function addMemberToAppRoleWithOptions($agentId, $roleId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $agentId = OpenApiUtilClient::getEncodeParam($agentId);
        $roleId  = OpenApiUtilClient::getEncodeParam($roleId);
        $body    = [];
        if (!Utils::isUnset($request->deptIdList)) {
            @$body['deptIdList'] = $request->deptIdList;
        }
        if (!Utils::isUnset($request->opUserId)) {
            @$body['opUserId'] = $request->opUserId;
        }
        if (!Utils::isUnset($request->scopeVersion)) {
            @$body['scopeVersion'] = $request->scopeVersion;
        }
        if (!Utils::isUnset($request->userIdList)) {
            @$body['userIdList'] = $request->userIdList;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return AddMemberToAppRoleResponse::fromMap($this->doROARequest('AddMemberToAppRole', 'microApp_1.0', 'HTTP', 'POST', 'AK', '/v1.0/microApp/apps/' . $agentId . '/roles/' . $roleId . '/members', 'json', $req, $runtime));
    }

    /**
     * @param CreateApaasAppRequest $request
     *
     * @return CreateApaasAppResponse
     */
    public function createApaasApp($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateApaasAppHeaders([]);

        return $this->createApaasAppWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateApaasAppRequest $request
     * @param CreateApaasAppHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return CreateApaasAppResponse
     */
    public function createApaasAppWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appDesc)) {
            @$body['appDesc'] = $request->appDesc;
        }
        if (!Utils::isUnset($request->appIcon)) {
            @$body['appIcon'] = $request->appIcon;
        }
        if (!Utils::isUnset($request->appName)) {
            @$body['appName'] = $request->appName;
        }
        if (!Utils::isUnset($request->bizAppId)) {
            @$body['bizAppId'] = $request->bizAppId;
        }
        if (!Utils::isUnset($request->homepageEditLink)) {
            @$body['homepageEditLink'] = $request->homepageEditLink;
        }
        if (!Utils::isUnset($request->homepageLink)) {
            @$body['homepageLink'] = $request->homepageLink;
        }
        if (!Utils::isUnset($request->isShortCut)) {
            @$body['isShortCut'] = $request->isShortCut;
        }
        if (!Utils::isUnset($request->ompLink)) {
            @$body['ompLink'] = $request->ompLink;
        }
        if (!Utils::isUnset($request->opUserId)) {
            @$body['opUserId'] = $request->opUserId;
        }
        if (!Utils::isUnset($request->pcHomepageEditLink)) {
            @$body['pcHomepageEditLink'] = $request->pcHomepageEditLink;
        }
        if (!Utils::isUnset($request->pcHomepageLink)) {
            @$body['pcHomepageLink'] = $request->pcHomepageLink;
        }
        if (!Utils::isUnset($request->templateKey)) {
            @$body['templateKey'] = $request->templateKey;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return CreateApaasAppResponse::fromMap($this->doROARequest('CreateApaasApp', 'microApp_1.0', 'HTTP', 'POST', 'AK', '/v1.0/microApp/apaasApps', 'json', $req, $runtime));
    }

    /**
     * @param CreateInnerAppRequest $request
     *
     * @return CreateInnerAppResponse
     */
    public function createInnerApp($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateInnerAppHeaders([]);

        return $this->createInnerAppWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateInnerAppRequest $request
     * @param CreateInnerAppHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return CreateInnerAppResponse
     */
    public function createInnerAppWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->desc)) {
            @$body['desc'] = $request->desc;
        }
        if (!Utils::isUnset($request->developType)) {
            @$body['developType'] = $request->developType;
        }
        if (!Utils::isUnset($request->homepageLink)) {
            @$body['homepageLink'] = $request->homepageLink;
        }
        if (!Utils::isUnset($request->icon)) {
            @$body['icon'] = $request->icon;
        }
        if (!Utils::isUnset($request->ipWhiteList)) {
            @$body['ipWhiteList'] = $request->ipWhiteList;
        }
        if (!Utils::isUnset($request->name)) {
            @$body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->ompLink)) {
            @$body['ompLink'] = $request->ompLink;
        }
        if (!Utils::isUnset($request->opUnionId)) {
            @$body['opUnionId'] = $request->opUnionId;
        }
        if (!Utils::isUnset($request->pcHomepageLink)) {
            @$body['pcHomepageLink'] = $request->pcHomepageLink;
        }
        if (!Utils::isUnset($request->scopeType)) {
            @$body['scopeType'] = $request->scopeType;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return CreateInnerAppResponse::fromMap($this->doROARequest('CreateInnerApp', 'microApp_1.0', 'HTTP', 'POST', 'AK', '/v1.0/microApp/apps', 'json', $req, $runtime));
    }

    /**
     * @param string               $agentId
     * @param string               $roleId
     * @param DeleteAppRoleRequest $request
     *
     * @return DeleteAppRoleResponse
     */
    public function deleteAppRole($agentId, $roleId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteAppRoleHeaders([]);

        return $this->deleteAppRoleWithOptions($agentId, $roleId, $request, $headers, $runtime);
    }

    /**
     * @param string               $agentId
     * @param string               $roleId
     * @param DeleteAppRoleRequest $request
     * @param DeleteAppRoleHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return DeleteAppRoleResponse
     */
    public function deleteAppRoleWithOptions($agentId, $roleId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $agentId = OpenApiUtilClient::getEncodeParam($agentId);
        $roleId  = OpenApiUtilClient::getEncodeParam($roleId);
        $query   = [];
        if (!Utils::isUnset($request->opUserId)) {
            @$query['opUserId'] = $request->opUserId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return DeleteAppRoleResponse::fromMap($this->doROARequest('DeleteAppRole', 'microApp_1.0', 'HTTP', 'DELETE', 'AK', '/v1.0/microApp/apps/' . $agentId . '/roles/' . $roleId . '', 'json', $req, $runtime));
    }

    /**
     * @param string                $agentId
     * @param DeleteInnerAppRequest $request
     *
     * @return DeleteInnerAppResponse
     */
    public function deleteInnerApp($agentId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteInnerAppHeaders([]);

        return $this->deleteInnerAppWithOptions($agentId, $request, $headers, $runtime);
    }

    /**
     * @param string                $agentId
     * @param DeleteInnerAppRequest $request
     * @param DeleteInnerAppHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return DeleteInnerAppResponse
     */
    public function deleteInnerAppWithOptions($agentId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $agentId = OpenApiUtilClient::getEncodeParam($agentId);
        $query   = [];
        if (!Utils::isUnset($request->opUnionId)) {
            @$query['opUnionId'] = $request->opUnionId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return DeleteInnerAppResponse::fromMap($this->doROARequest('DeleteInnerApp', 'microApp_1.0', 'HTTP', 'DELETE', 'AK', '/v1.0/microApp/apps/' . $agentId . '', 'json', $req, $runtime));
    }

    /**
     * @param string $bizAppId
     *
     * @return GetApaasAppResponse
     */
    public function getApaasApp($bizAppId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetApaasAppHeaders([]);

        return $this->getApaasAppWithOptions($bizAppId, $headers, $runtime);
    }

    /**
     * @param string             $bizAppId
     * @param GetApaasAppHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return GetApaasAppResponse
     */
    public function getApaasAppWithOptions($bizAppId, $headers, $runtime)
    {
        $bizAppId    = OpenApiUtilClient::getEncodeParam($bizAppId);
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return GetApaasAppResponse::fromMap($this->doROARequest('GetApaasApp', 'microApp_1.0', 'HTTP', 'GET', 'AK', '/v1.0/microApp/apaasApps/' . $bizAppId . '', 'json', $req, $runtime));
    }

    /**
     * @param string $agentId
     * @param string $roleId
     *
     * @return GetAppRoleScopeByRoleIdResponse
     */
    public function getAppRoleScopeByRoleId($agentId, $roleId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetAppRoleScopeByRoleIdHeaders([]);

        return $this->getAppRoleScopeByRoleIdWithOptions($agentId, $roleId, $headers, $runtime);
    }

    /**
     * @param string                         $agentId
     * @param string                         $roleId
     * @param GetAppRoleScopeByRoleIdHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return GetAppRoleScopeByRoleIdResponse
     */
    public function getAppRoleScopeByRoleIdWithOptions($agentId, $roleId, $headers, $runtime)
    {
        $agentId     = OpenApiUtilClient::getEncodeParam($agentId);
        $roleId      = OpenApiUtilClient::getEncodeParam($roleId);
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return GetAppRoleScopeByRoleIdResponse::fromMap($this->doROARequest('GetAppRoleScopeByRoleId', 'microApp_1.0', 'HTTP', 'GET', 'AK', '/v1.0/microApp/apps/' . $agentId . '/roles/' . $roleId . '/scopes', 'json', $req, $runtime));
    }

    /**
     * @param string             $agentId
     * @param GetInnerAppRequest $request
     *
     * @return GetInnerAppResponse
     */
    public function getInnerApp($agentId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetInnerAppHeaders([]);

        return $this->getInnerAppWithOptions($agentId, $request, $headers, $runtime);
    }

    /**
     * @param string             $agentId
     * @param GetInnerAppRequest $request
     * @param GetInnerAppHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return GetInnerAppResponse
     */
    public function getInnerAppWithOptions($agentId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $agentId = OpenApiUtilClient::getEncodeParam($agentId);
        $query   = [];
        if (!Utils::isUnset($request->ecologicalCorpId)) {
            @$query['ecologicalCorpId'] = $request->ecologicalCorpId;
        }
        if (!Utils::isUnset($request->opUnionId)) {
            @$query['opUnionId'] = $request->opUnionId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetInnerAppResponse::fromMap($this->doROARequest('GetInnerApp', 'microApp_1.0', 'HTTP', 'GET', 'AK', '/v1.0/microApp/apps/' . $agentId . '', 'json', $req, $runtime));
    }

    /**
     * @param string $agentId
     *
     * @return GetMicroAppScopeResponse
     */
    public function getMicroAppScope($agentId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetMicroAppScopeHeaders([]);

        return $this->getMicroAppScopeWithOptions($agentId, $headers, $runtime);
    }

    /**
     * @param string                  $agentId
     * @param GetMicroAppScopeHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return GetMicroAppScopeResponse
     */
    public function getMicroAppScopeWithOptions($agentId, $headers, $runtime)
    {
        $agentId     = OpenApiUtilClient::getEncodeParam($agentId);
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return GetMicroAppScopeResponse::fromMap($this->doROARequest('GetMicroAppScope', 'microApp_1.0', 'HTTP', 'GET', 'AK', '/v1.0/microApp/apps/' . $agentId . '/scopes', 'json', $req, $runtime));
    }

    /**
     * @param string $agentId
     * @param string $userId
     *
     * @return GetMicroAppUserAccessResponse
     */
    public function getMicroAppUserAccess($agentId, $userId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetMicroAppUserAccessHeaders([]);

        return $this->getMicroAppUserAccessWithOptions($agentId, $userId, $headers, $runtime);
    }

    /**
     * @param string                       $agentId
     * @param string                       $userId
     * @param GetMicroAppUserAccessHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return GetMicroAppUserAccessResponse
     */
    public function getMicroAppUserAccessWithOptions($agentId, $userId, $headers, $runtime)
    {
        $agentId     = OpenApiUtilClient::getEncodeParam($agentId);
        $userId      = OpenApiUtilClient::getEncodeParam($userId);
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return GetMicroAppUserAccessResponse::fromMap($this->doROARequest('GetMicroAppUserAccess', 'microApp_1.0', 'HTTP', 'GET', 'AK', '/v1.0/microApp/apps/' . $agentId . '/users/' . $userId . '/adminAccess', 'json', $req, $runtime));
    }

    /**
     * @param string $userId
     *
     * @return GetUserAppDevAccessResponse
     */
    public function getUserAppDevAccess($userId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetUserAppDevAccessHeaders([]);

        return $this->getUserAppDevAccessWithOptions($userId, $headers, $runtime);
    }

    /**
     * @param string                     $userId
     * @param GetUserAppDevAccessHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return GetUserAppDevAccessResponse
     */
    public function getUserAppDevAccessWithOptions($userId, $headers, $runtime)
    {
        $userId      = OpenApiUtilClient::getEncodeParam($userId);
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return GetUserAppDevAccessResponse::fromMap($this->doROARequest('GetUserAppDevAccess', 'microApp_1.0', 'HTTP', 'GET', 'AK', '/v1.0/microApp/users/' . $userId . '/devAccesses', 'json', $req, $runtime));
    }

    /**
     * @return ListAllAppResponse
     */
    public function listAllApp()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListAllAppHeaders([]);

        return $this->listAllAppWithOptions($headers, $runtime);
    }

    /**
     * @param ListAllAppHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return ListAllAppResponse
     */
    public function listAllAppWithOptions($headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return ListAllAppResponse::fromMap($this->doROARequest('ListAllApp', 'microApp_1.0', 'HTTP', 'GET', 'AK', '/v1.0/microApp/allApps', 'json', $req, $runtime));
    }

    /**
     * @return ListAllInnerAppsResponse
     */
    public function listAllInnerApps()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListAllInnerAppsHeaders([]);

        return $this->listAllInnerAppsWithOptions($headers, $runtime);
    }

    /**
     * @param ListAllInnerAppsHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return ListAllInnerAppsResponse
     */
    public function listAllInnerAppsWithOptions($headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return ListAllInnerAppsResponse::fromMap($this->doROARequest('ListAllInnerApps', 'microApp_1.0', 'HTTP', 'GET', 'AK', '/v1.0/microApp/allInnerApps', 'json', $req, $runtime));
    }

    /**
     * @param string                   $agentId
     * @param ListAppRoleScopesRequest $request
     *
     * @return ListAppRoleScopesResponse
     */
    public function listAppRoleScopes($agentId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListAppRoleScopesHeaders([]);

        return $this->listAppRoleScopesWithOptions($agentId, $request, $headers, $runtime);
    }

    /**
     * @param string                   $agentId
     * @param ListAppRoleScopesRequest $request
     * @param ListAppRoleScopesHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return ListAppRoleScopesResponse
     */
    public function listAppRoleScopesWithOptions($agentId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $agentId = OpenApiUtilClient::getEncodeParam($agentId);
        $query   = [];
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->size)) {
            @$query['size'] = $request->size;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return ListAppRoleScopesResponse::fromMap($this->doROARequest('ListAppRoleScopes', 'microApp_1.0', 'HTTP', 'GET', 'AK', '/v1.0/microApp/apps/' . $agentId . '/roles', 'json', $req, $runtime));
    }

    /**
     * @param ListInnerAppRequest $request
     *
     * @return ListInnerAppResponse
     */
    public function listInnerApp($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListInnerAppHeaders([]);

        return $this->listInnerAppWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ListInnerAppRequest $request
     * @param ListInnerAppHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return ListInnerAppResponse
     */
    public function listInnerAppWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->ecologicalCorpId)) {
            @$query['ecologicalCorpId'] = $request->ecologicalCorpId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return ListInnerAppResponse::fromMap($this->doROARequest('ListInnerApp', 'microApp_1.0', 'HTTP', 'GET', 'AK', '/v1.0/microApp/apps', 'json', $req, $runtime));
    }

    /**
     * @param string $agentId
     *
     * @return ListInnerAppVersionResponse
     */
    public function listInnerAppVersion($agentId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListInnerAppVersionHeaders([]);

        return $this->listInnerAppVersionWithOptions($agentId, $headers, $runtime);
    }

    /**
     * @param string                     $agentId
     * @param ListInnerAppVersionHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return ListInnerAppVersionResponse
     */
    public function listInnerAppVersionWithOptions($agentId, $headers, $runtime)
    {
        $agentId     = OpenApiUtilClient::getEncodeParam($agentId);
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return ListInnerAppVersionResponse::fromMap($this->doROARequest('ListInnerAppVersion', 'microApp_1.0', 'HTTP', 'GET', 'AK', '/v1.0/microApp/innerMiniApps/' . $agentId . '/versions', 'json', $req, $runtime));
    }

    /**
     * @param string $agentId
     * @param string $userId
     *
     * @return ListRoleInfoByUserResponse
     */
    public function listRoleInfoByUser($agentId, $userId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListRoleInfoByUserHeaders([]);

        return $this->listRoleInfoByUserWithOptions($agentId, $userId, $headers, $runtime);
    }

    /**
     * @param string                    $agentId
     * @param string                    $userId
     * @param ListRoleInfoByUserHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return ListRoleInfoByUserResponse
     */
    public function listRoleInfoByUserWithOptions($agentId, $userId, $headers, $runtime)
    {
        $agentId     = OpenApiUtilClient::getEncodeParam($agentId);
        $userId      = OpenApiUtilClient::getEncodeParam($userId);
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return ListRoleInfoByUserResponse::fromMap($this->doROARequest('ListRoleInfoByUser', 'microApp_1.0', 'HTTP', 'GET', 'AK', '/v1.0/microApp/apps/' . $agentId . '/users/' . $userId . '/roles', 'json', $req, $runtime));
    }

    /**
     * @param string $userId
     *
     * @return ListUserVilebleAppResponse
     */
    public function listUserVilebleApp($userId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListUserVilebleAppHeaders([]);

        return $this->listUserVilebleAppWithOptions($userId, $headers, $runtime);
    }

    /**
     * @param string                    $userId
     * @param ListUserVilebleAppHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return ListUserVilebleAppResponse
     */
    public function listUserVilebleAppWithOptions($userId, $headers, $runtime)
    {
        $userId      = OpenApiUtilClient::getEncodeParam($userId);
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return ListUserVilebleAppResponse::fromMap($this->doROARequest('ListUserVilebleApp', 'microApp_1.0', 'HTTP', 'GET', 'AK', '/v1.0/microApp/users/' . $userId . '/apps', 'json', $req, $runtime));
    }

    /**
     * @param string                            $agentId
     * @param PageInnerAppHistoryVersionRequest $request
     *
     * @return PageInnerAppHistoryVersionResponse
     */
    public function pageInnerAppHistoryVersion($agentId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PageInnerAppHistoryVersionHeaders([]);

        return $this->pageInnerAppHistoryVersionWithOptions($agentId, $request, $headers, $runtime);
    }

    /**
     * @param string                            $agentId
     * @param PageInnerAppHistoryVersionRequest $request
     * @param PageInnerAppHistoryVersionHeaders $headers
     * @param RuntimeOptions                    $runtime
     *
     * @return PageInnerAppHistoryVersionResponse
     */
    public function pageInnerAppHistoryVersionWithOptions($agentId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $agentId = OpenApiUtilClient::getEncodeParam($agentId);
        $query   = [];
        if (!Utils::isUnset($request->pageNumber)) {
            @$query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return PageInnerAppHistoryVersionResponse::fromMap($this->doROARequest('PageInnerAppHistoryVersion', 'microApp_1.0', 'HTTP', 'GET', 'AK', '/v1.0/microApp/innerMiniApps/' . $agentId . '/historyVersions', 'json', $req, $runtime));
    }

    /**
     * @param string                        $agentId
     * @param PublishInnerAppVersionRequest $request
     *
     * @return PublishInnerAppVersionResponse
     */
    public function publishInnerAppVersion($agentId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PublishInnerAppVersionHeaders([]);

        return $this->publishInnerAppVersionWithOptions($agentId, $request, $headers, $runtime);
    }

    /**
     * @param string                        $agentId
     * @param PublishInnerAppVersionRequest $request
     * @param PublishInnerAppVersionHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return PublishInnerAppVersionResponse
     */
    public function publishInnerAppVersionWithOptions($agentId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $agentId = OpenApiUtilClient::getEncodeParam($agentId);
        $body    = [];
        if (!Utils::isUnset($request->appVersionId)) {
            @$body['appVersionId'] = $request->appVersionId;
        }
        if (!Utils::isUnset($request->miniAppOnPc)) {
            @$body['miniAppOnPc'] = $request->miniAppOnPc;
        }
        if (!Utils::isUnset($request->opUnionId)) {
            @$body['opUnionId'] = $request->opUnionId;
        }
        if (!Utils::isUnset($request->publishType)) {
            @$body['publishType'] = $request->publishType;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return PublishInnerAppVersionResponse::fromMap($this->doROARequest('PublishInnerAppVersion', 'microApp_1.0', 'HTTP', 'POST', 'AK', '/v1.0/microApp/innerMiniApps/' . $agentId . '/versions/publish', 'json', $req, $runtime));
    }

    /**
     * @param string                            $agentId
     * @param string                            $roleId
     * @param RebuildRoleScopeForAppRoleRequest $request
     *
     * @return RebuildRoleScopeForAppRoleResponse
     */
    public function rebuildRoleScopeForAppRole($agentId, $roleId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RebuildRoleScopeForAppRoleHeaders([]);

        return $this->rebuildRoleScopeForAppRoleWithOptions($agentId, $roleId, $request, $headers, $runtime);
    }

    /**
     * @param string                            $agentId
     * @param string                            $roleId
     * @param RebuildRoleScopeForAppRoleRequest $request
     * @param RebuildRoleScopeForAppRoleHeaders $headers
     * @param RuntimeOptions                    $runtime
     *
     * @return RebuildRoleScopeForAppRoleResponse
     */
    public function rebuildRoleScopeForAppRoleWithOptions($agentId, $roleId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $agentId = OpenApiUtilClient::getEncodeParam($agentId);
        $roleId  = OpenApiUtilClient::getEncodeParam($roleId);
        $body    = [];
        if (!Utils::isUnset($request->deptIdList)) {
            @$body['deptIdList'] = $request->deptIdList;
        }
        if (!Utils::isUnset($request->opUserId)) {
            @$body['opUserId'] = $request->opUserId;
        }
        if (!Utils::isUnset($request->scopeType)) {
            @$body['scopeType'] = $request->scopeType;
        }
        if (!Utils::isUnset($request->scopeVersion)) {
            @$body['scopeVersion'] = $request->scopeVersion;
        }
        if (!Utils::isUnset($request->userIdList)) {
            @$body['userIdList'] = $request->userIdList;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return RebuildRoleScopeForAppRoleResponse::fromMap($this->doROARequest('RebuildRoleScopeForAppRole', 'microApp_1.0', 'HTTP', 'POST', 'AK', '/v1.0/microApp/apps/' . $agentId . '/roles/' . $roleId . '/scopes/rebuild', 'json', $req, $runtime));
    }

    /**
     * @param string                       $agentId
     * @param RegisterCustomAppRoleRequest $request
     *
     * @return RegisterCustomAppRoleResponse
     */
    public function registerCustomAppRole($agentId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RegisterCustomAppRoleHeaders([]);

        return $this->registerCustomAppRoleWithOptions($agentId, $request, $headers, $runtime);
    }

    /**
     * @param string                       $agentId
     * @param RegisterCustomAppRoleRequest $request
     * @param RegisterCustomAppRoleHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return RegisterCustomAppRoleResponse
     */
    public function registerCustomAppRoleWithOptions($agentId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $agentId = OpenApiUtilClient::getEncodeParam($agentId);
        $body    = [];
        if (!Utils::isUnset($request->canManageRole)) {
            @$body['canManageRole'] = $request->canManageRole;
        }
        if (!Utils::isUnset($request->opUserId)) {
            @$body['opUserId'] = $request->opUserId;
        }
        if (!Utils::isUnset($request->roleName)) {
            @$body['roleName'] = $request->roleName;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return RegisterCustomAppRoleResponse::fromMap($this->doROARequest('RegisterCustomAppRole', 'microApp_1.0', 'HTTP', 'POST', 'AK', '/v1.0/microApp/apps/' . $agentId . '/roles', 'json', $req, $runtime));
    }

    /**
     * @param RemoveApaasAppRequest $request
     *
     * @return RemoveApaasAppResponse
     */
    public function removeApaasApp($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RemoveApaasAppHeaders([]);

        return $this->removeApaasAppWithOptions($request, $headers, $runtime);
    }

    /**
     * @param RemoveApaasAppRequest $request
     * @param RemoveApaasAppHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return RemoveApaasAppResponse
     */
    public function removeApaasAppWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizAppId)) {
            @$body['bizAppId'] = $request->bizAppId;
        }
        if (!Utils::isUnset($request->opUserId)) {
            @$body['opUserId'] = $request->opUserId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return RemoveApaasAppResponse::fromMap($this->doROARequest('RemoveApaasApp', 'microApp_1.0', 'HTTP', 'POST', 'AK', '/v1.0/microApp/apaasApps/remove', 'json', $req, $runtime));
    }

    /**
     * @param string                        $agentId
     * @param string                        $roleId
     * @param RemoveMemberForAppRoleRequest $request
     *
     * @return RemoveMemberForAppRoleResponse
     */
    public function removeMemberForAppRole($agentId, $roleId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RemoveMemberForAppRoleHeaders([]);

        return $this->removeMemberForAppRoleWithOptions($agentId, $roleId, $request, $headers, $runtime);
    }

    /**
     * @param string                        $agentId
     * @param string                        $roleId
     * @param RemoveMemberForAppRoleRequest $request
     * @param RemoveMemberForAppRoleHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return RemoveMemberForAppRoleResponse
     */
    public function removeMemberForAppRoleWithOptions($agentId, $roleId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $agentId = OpenApiUtilClient::getEncodeParam($agentId);
        $roleId  = OpenApiUtilClient::getEncodeParam($roleId);
        $body    = [];
        if (!Utils::isUnset($request->deptIdList)) {
            @$body['deptIdList'] = $request->deptIdList;
        }
        if (!Utils::isUnset($request->opUserId)) {
            @$body['opUserId'] = $request->opUserId;
        }
        if (!Utils::isUnset($request->scopeVersion)) {
            @$body['scopeVersion'] = $request->scopeVersion;
        }
        if (!Utils::isUnset($request->userIdList)) {
            @$body['userIdList'] = $request->userIdList;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return RemoveMemberForAppRoleResponse::fromMap($this->doROARequest('RemoveMemberForAppRole', 'microApp_1.0', 'HTTP', 'POST', 'AK', '/v1.0/microApp/apps/' . $agentId . '/roles/' . $roleId . '/members/batchRemove', 'json', $req, $runtime));
    }

    /**
     * @param string                         $agentId
     * @param RollbackInnerAppVersionRequest $request
     *
     * @return RollbackInnerAppVersionResponse
     */
    public function rollbackInnerAppVersion($agentId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RollbackInnerAppVersionHeaders([]);

        return $this->rollbackInnerAppVersionWithOptions($agentId, $request, $headers, $runtime);
    }

    /**
     * @param string                         $agentId
     * @param RollbackInnerAppVersionRequest $request
     * @param RollbackInnerAppVersionHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return RollbackInnerAppVersionResponse
     */
    public function rollbackInnerAppVersionWithOptions($agentId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $agentId = OpenApiUtilClient::getEncodeParam($agentId);
        $body    = [];
        if (!Utils::isUnset($request->appVersionId)) {
            @$body['appVersionId'] = $request->appVersionId;
        }
        if (!Utils::isUnset($request->opUnionId)) {
            @$body['opUnionId'] = $request->opUnionId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return RollbackInnerAppVersionResponse::fromMap($this->doROARequest('RollbackInnerAppVersion', 'microApp_1.0', 'HTTP', 'POST', 'AK', '/v1.0/microApp/innerMiniApps/' . $agentId . '/versions/rollback', 'json', $req, $runtime));
    }

    /**
     * @param string                  $agentId
     * @param SetMicroAppScopeRequest $request
     *
     * @return SetMicroAppScopeResponse
     */
    public function setMicroAppScope($agentId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SetMicroAppScopeHeaders([]);

        return $this->setMicroAppScopeWithOptions($agentId, $request, $headers, $runtime);
    }

    /**
     * @param string                  $agentId
     * @param SetMicroAppScopeRequest $request
     * @param SetMicroAppScopeHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return SetMicroAppScopeResponse
     */
    public function setMicroAppScopeWithOptions($agentId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $agentId = OpenApiUtilClient::getEncodeParam($agentId);
        $body    = [];
        if (!Utils::isUnset($request->addDeptIds)) {
            @$body['addDeptIds'] = $request->addDeptIds;
        }
        if (!Utils::isUnset($request->addRoleIds)) {
            @$body['addRoleIds'] = $request->addRoleIds;
        }
        if (!Utils::isUnset($request->addUserIds)) {
            @$body['addUserIds'] = $request->addUserIds;
        }
        if (!Utils::isUnset($request->delDeptIds)) {
            @$body['delDeptIds'] = $request->delDeptIds;
        }
        if (!Utils::isUnset($request->delRoleIds)) {
            @$body['delRoleIds'] = $request->delRoleIds;
        }
        if (!Utils::isUnset($request->delUserIds)) {
            @$body['delUserIds'] = $request->delUserIds;
        }
        if (!Utils::isUnset($request->onlyAdminVisible)) {
            @$body['onlyAdminVisible'] = $request->onlyAdminVisible;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return SetMicroAppScopeResponse::fromMap($this->doROARequest('SetMicroAppScope', 'microApp_1.0', 'HTTP', 'POST', 'AK', '/v1.0/microApp/apps/' . $agentId . '/scopes', 'json', $req, $runtime));
    }

    /**
     * @param UpdateApaasAppRequest $request
     *
     * @return UpdateApaasAppResponse
     */
    public function updateApaasApp($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateApaasAppHeaders([]);

        return $this->updateApaasAppWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateApaasAppRequest $request
     * @param UpdateApaasAppHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return UpdateApaasAppResponse
     */
    public function updateApaasAppWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appIcon)) {
            @$body['appIcon'] = $request->appIcon;
        }
        if (!Utils::isUnset($request->appName)) {
            @$body['appName'] = $request->appName;
        }
        if (!Utils::isUnset($request->appStatus)) {
            @$body['appStatus'] = $request->appStatus;
        }
        if (!Utils::isUnset($request->bizAppId)) {
            @$body['bizAppId'] = $request->bizAppId;
        }
        if (!Utils::isUnset($request->opUserId)) {
            @$body['opUserId'] = $request->opUserId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return UpdateApaasAppResponse::fromMap($this->doROARequest('UpdateApaasApp', 'microApp_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/microApp/apaasApps', 'json', $req, $runtime));
    }

    /**
     * @param string                   $agentId
     * @param string                   $roleId
     * @param UpdateAppRoleInfoRequest $request
     *
     * @return UpdateAppRoleInfoResponse
     */
    public function updateAppRoleInfo($agentId, $roleId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateAppRoleInfoHeaders([]);

        return $this->updateAppRoleInfoWithOptions($agentId, $roleId, $request, $headers, $runtime);
    }

    /**
     * @param string                   $agentId
     * @param string                   $roleId
     * @param UpdateAppRoleInfoRequest $request
     * @param UpdateAppRoleInfoHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return UpdateAppRoleInfoResponse
     */
    public function updateAppRoleInfoWithOptions($agentId, $roleId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $agentId = OpenApiUtilClient::getEncodeParam($agentId);
        $roleId  = OpenApiUtilClient::getEncodeParam($roleId);
        $body    = [];
        if (!Utils::isUnset($request->canManageRole)) {
            @$body['canManageRole'] = $request->canManageRole;
        }
        if (!Utils::isUnset($request->newRoleName)) {
            @$body['newRoleName'] = $request->newRoleName;
        }
        if (!Utils::isUnset($request->opUserId)) {
            @$body['opUserId'] = $request->opUserId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return UpdateAppRoleInfoResponse::fromMap($this->doROARequest('UpdateAppRoleInfo', 'microApp_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/microApp/apps/' . $agentId . '/roles/' . $roleId . '', 'json', $req, $runtime));
    }

    /**
     * @param string                $agentId
     * @param UpdateInnerAppRequest $request
     *
     * @return UpdateInnerAppResponse
     */
    public function updateInnerApp($agentId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateInnerAppHeaders([]);

        return $this->updateInnerAppWithOptions($agentId, $request, $headers, $runtime);
    }

    /**
     * @param string                $agentId
     * @param UpdateInnerAppRequest $request
     * @param UpdateInnerAppHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return UpdateInnerAppResponse
     */
    public function updateInnerAppWithOptions($agentId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $agentId = OpenApiUtilClient::getEncodeParam($agentId);
        $body    = [];
        if (!Utils::isUnset($request->desc)) {
            @$body['desc'] = $request->desc;
        }
        if (!Utils::isUnset($request->homepageLink)) {
            @$body['homepageLink'] = $request->homepageLink;
        }
        if (!Utils::isUnset($request->icon)) {
            @$body['icon'] = $request->icon;
        }
        if (!Utils::isUnset($request->ipWhiteList)) {
            @$body['ipWhiteList'] = $request->ipWhiteList;
        }
        if (!Utils::isUnset($request->name)) {
            @$body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->ompLink)) {
            @$body['ompLink'] = $request->ompLink;
        }
        if (!Utils::isUnset($request->opUnionId)) {
            @$body['opUnionId'] = $request->opUnionId;
        }
        if (!Utils::isUnset($request->pcHomepageLink)) {
            @$body['pcHomepageLink'] = $request->pcHomepageLink;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return UpdateInnerAppResponse::fromMap($this->doROARequest('UpdateInnerApp', 'microApp_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/microApp/apps/' . $agentId . '', 'json', $req, $runtime));
    }
}
