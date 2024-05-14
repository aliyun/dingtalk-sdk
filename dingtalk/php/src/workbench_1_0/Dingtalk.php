<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkbench_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vworkbench_1_0\Models\AddRecentUserAppListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkbench_1_0\Models\AddRecentUserAppListRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkbench_1_0\Models\AddRecentUserAppListResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkbench_1_0\Models\GetDingPortalDetailHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkbench_1_0\Models\GetDingPortalDetailResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkbench_1_0\Models\GetPluginPermissionPointHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkbench_1_0\Models\GetPluginPermissionPointRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkbench_1_0\Models\GetPluginPermissionPointResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkbench_1_0\Models\GetPluginRuleCheckInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkbench_1_0\Models\GetPluginRuleCheckInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkbench_1_0\Models\GetPluginRuleCheckInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkbench_1_0\Models\ListWorkBenchGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkbench_1_0\Models\ListWorkBenchGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkbench_1_0\Models\ListWorkBenchGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkbench_1_0\Models\ModifyWorkbenchBadgeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkbench_1_0\Models\ModifyWorkbenchBadgeRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkbench_1_0\Models\ModifyWorkbenchBadgeResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkbench_1_0\Models\QueryComponentScopesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkbench_1_0\Models\QueryComponentScopesResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkbench_1_0\Models\QueryShortcutScopesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkbench_1_0\Models\QueryShortcutScopesResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkbench_1_0\Models\UndoDeletionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkbench_1_0\Models\UndoDeletionRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkbench_1_0\Models\UndoDeletionResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkbench_1_0\Models\UpdateDingPortalPageScopeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkbench_1_0\Models\UpdateDingPortalPageScopeRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkbench_1_0\Models\UpdateDingPortalPageScopeResponse;
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
     * @summary 批量添加最近使用记录
     *  *
     * @param AddRecentUserAppListRequest $request AddRecentUserAppListRequest
     * @param AddRecentUserAppListHeaders $headers AddRecentUserAppListHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return AddRecentUserAppListResponse AddRecentUserAppListResponse
     */
    public function addRecentUserAppListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->usedAppDetailList)) {
            $body['usedAppDetailList'] = $request->usedAppDetailList;
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
            'action'      => 'AddRecentUserAppList',
            'version'     => 'workbench_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workbench/components/recentUsed/batch',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AddRecentUserAppListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量添加最近使用记录
     *  *
     * @param AddRecentUserAppListRequest $request AddRecentUserAppListRequest
     *
     * @return AddRecentUserAppListResponse AddRecentUserAppListResponse
     */
    public function addRecentUserAppList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddRecentUserAppListHeaders([]);

        return $this->addRecentUserAppListWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询自定义工作台
     *  *
     * @param string                     $appUuid
     * @param GetDingPortalDetailHeaders $headers GetDingPortalDetailHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return GetDingPortalDetailResponse GetDingPortalDetailResponse
     */
    public function getDingPortalDetailWithOptions($appUuid, $headers, $runtime)
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
            'action'      => 'GetDingPortalDetail',
            'version'     => 'workbench_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workbench/dingPortals/' . $appUuid . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return GetDingPortalDetailResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询自定义工作台
     *  *
     * @param string $appUuid
     *
     * @return GetDingPortalDetailResponse GetDingPortalDetailResponse
     */
    public function getDingPortalDetail($appUuid)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetDingPortalDetailHeaders([]);

        return $this->getDingPortalDetailWithOptions($appUuid, $headers, $runtime);
    }

    /**
     * @summary 获取工作台插件的权限点
     *  *
     * @param GetPluginPermissionPointRequest $request GetPluginPermissionPointRequest
     * @param GetPluginPermissionPointHeaders $headers GetPluginPermissionPointHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return GetPluginPermissionPointResponse GetPluginPermissionPointResponse
     */
    public function getPluginPermissionPointWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->miniAppId)) {
            $query['miniAppId'] = $request->miniAppId;
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
            'action'      => 'GetPluginPermissionPoint',
            'version'     => 'workbench_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workbench/plugins/permissions',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return GetPluginPermissionPointResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取工作台插件的权限点
     *  *
     * @param GetPluginPermissionPointRequest $request GetPluginPermissionPointRequest
     *
     * @return GetPluginPermissionPointResponse GetPluginPermissionPointResponse
     */
    public function getPluginPermissionPoint($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetPluginPermissionPointHeaders([]);

        return $this->getPluginPermissionPointWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取插件的校验规则
     *  *
     * @param GetPluginRuleCheckInfoRequest $request GetPluginRuleCheckInfoRequest
     * @param GetPluginRuleCheckInfoHeaders $headers GetPluginRuleCheckInfoHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return GetPluginRuleCheckInfoResponse GetPluginRuleCheckInfoResponse
     */
    public function getPluginRuleCheckInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->miniAppId)) {
            $query['miniAppId'] = $request->miniAppId;
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
            'action'      => 'GetPluginRuleCheckInfo',
            'version'     => 'workbench_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workbench/plugins/validationRules',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return GetPluginRuleCheckInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取插件的校验规则
     *  *
     * @param GetPluginRuleCheckInfoRequest $request GetPluginRuleCheckInfoRequest
     *
     * @return GetPluginRuleCheckInfoResponse GetPluginRuleCheckInfoResponse
     */
    public function getPluginRuleCheckInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetPluginRuleCheckInfoHeaders([]);

        return $this->getPluginRuleCheckInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取工作台分组列表
     *  *
     * @param ListWorkBenchGroupRequest $request ListWorkBenchGroupRequest
     * @param ListWorkBenchGroupHeaders $headers ListWorkBenchGroupHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return ListWorkBenchGroupResponse ListWorkBenchGroupResponse
     */
    public function listWorkBenchGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->ecologicalCorpId)) {
            $query['ecologicalCorpId'] = $request->ecologicalCorpId;
        }
        if (!Utils::isUnset($request->groupType)) {
            $query['groupType'] = $request->groupType;
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'ListWorkBenchGroup',
            'version'     => 'workbench_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workbench/groups',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListWorkBenchGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取工作台分组列表
     *  *
     * @param ListWorkBenchGroupRequest $request ListWorkBenchGroupRequest
     *
     * @return ListWorkBenchGroupResponse ListWorkBenchGroupResponse
     */
    public function listWorkBenchGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListWorkBenchGroupHeaders([]);

        return $this->listWorkBenchGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 工作台支持数字红点
     *  *
     * @param ModifyWorkbenchBadgeRequest $request ModifyWorkbenchBadgeRequest
     * @param ModifyWorkbenchBadgeHeaders $headers ModifyWorkbenchBadgeHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return ModifyWorkbenchBadgeResponse ModifyWorkbenchBadgeResponse
     */
    public function modifyWorkbenchBadgeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizIdList)) {
            $body['bizIdList'] = $request->bizIdList;
        }
        if (!Utils::isUnset($request->isAdded)) {
            $body['isAdded'] = $request->isAdded;
        }
        if (!Utils::isUnset($request->modifyMode)) {
            $body['modifyMode'] = $request->modifyMode;
        }
        if (!Utils::isUnset($request->redDotRelationId)) {
            $body['redDotRelationId'] = $request->redDotRelationId;
        }
        if (!Utils::isUnset($request->redDotType)) {
            $body['redDotType'] = $request->redDotType;
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
            'action'      => 'ModifyWorkbenchBadge',
            'version'     => 'workbench_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workbench/badges/modify',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ModifyWorkbenchBadgeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 工作台支持数字红点
     *  *
     * @param ModifyWorkbenchBadgeRequest $request ModifyWorkbenchBadgeRequest
     *
     * @return ModifyWorkbenchBadgeResponse ModifyWorkbenchBadgeResponse
     */
    public function modifyWorkbenchBadge($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ModifyWorkbenchBadgeHeaders([]);

        return $this->modifyWorkbenchBadgeWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 工作台组件授权范围查询
     *  *
     * @param string                      $componentId
     * @param QueryComponentScopesHeaders $headers     QueryComponentScopesHeaders
     * @param RuntimeOptions              $runtime     runtime options for this request RuntimeOptions
     *
     * @return QueryComponentScopesResponse QueryComponentScopesResponse
     */
    public function queryComponentScopesWithOptions($componentId, $headers, $runtime)
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
            'action'      => 'QueryComponentScopes',
            'version'     => 'workbench_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workbench/components/' . $componentId . '/scopes',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QueryComponentScopesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 工作台组件授权范围查询
     *  *
     * @param string $componentId
     *
     * @return QueryComponentScopesResponse QueryComponentScopesResponse
     */
    public function queryComponentScopes($componentId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryComponentScopesHeaders([]);

        return $this->queryComponentScopesWithOptions($componentId, $headers, $runtime);
    }

    /**
     * @summary 查询快捷方式可见范围
     *  *
     * @param string                     $shortcutKey
     * @param QueryShortcutScopesHeaders $headers     QueryShortcutScopesHeaders
     * @param RuntimeOptions             $runtime     runtime options for this request RuntimeOptions
     *
     * @return QueryShortcutScopesResponse QueryShortcutScopesResponse
     */
    public function queryShortcutScopesWithOptions($shortcutKey, $headers, $runtime)
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
            'action'      => 'QueryShortcutScopes',
            'version'     => 'workbench_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workbench/shortcuts/' . $shortcutKey . '/scopes',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QueryShortcutScopesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询快捷方式可见范围
     *  *
     * @param string $shortcutKey
     *
     * @return QueryShortcutScopesResponse QueryShortcutScopesResponse
     */
    public function queryShortcutScopes($shortcutKey)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryShortcutScopesHeaders([]);

        return $this->queryShortcutScopesWithOptions($shortcutKey, $headers, $runtime);
    }

    /**
     * @summary 工作台数字红点支持撤销已被删除的资源
     *  *
     * @param UndoDeletionRequest $request UndoDeletionRequest
     * @param UndoDeletionHeaders $headers UndoDeletionHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return UndoDeletionResponse UndoDeletionResponse
     */
    public function undoDeletionWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizIdList)) {
            $body['bizIdList'] = $request->bizIdList;
        }
        if (!Utils::isUnset($request->redDotRelationId)) {
            $body['redDotRelationId'] = $request->redDotRelationId;
        }
        if (!Utils::isUnset($request->redDotType)) {
            $body['redDotType'] = $request->redDotType;
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
            'action'      => 'UndoDeletion',
            'version'     => 'workbench_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workbench/badges/undoDeleted',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UndoDeletionResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 工作台数字红点支持撤销已被删除的资源
     *  *
     * @param UndoDeletionRequest $request UndoDeletionRequest
     *
     * @return UndoDeletionResponse UndoDeletionResponse
     */
    public function undoDeletion($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UndoDeletionHeaders([]);

        return $this->undoDeletionWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新自定义工作台页面可见性
     *  *
     * @param string                           $pageUuid
     * @param string                           $appUuid
     * @param UpdateDingPortalPageScopeRequest $request  UpdateDingPortalPageScopeRequest
     * @param UpdateDingPortalPageScopeHeaders $headers  UpdateDingPortalPageScopeHeaders
     * @param RuntimeOptions                   $runtime  runtime options for this request RuntimeOptions
     *
     * @return UpdateDingPortalPageScopeResponse UpdateDingPortalPageScopeResponse
     */
    public function updateDingPortalPageScopeWithOptions($pageUuid, $appUuid, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->allVisible)) {
            $body['allVisible'] = $request->allVisible;
        }
        if (!Utils::isUnset($request->deptIds)) {
            $body['deptIds'] = $request->deptIds;
        }
        if (!Utils::isUnset($request->roleIds)) {
            $body['roleIds'] = $request->roleIds;
        }
        if (!Utils::isUnset($request->userids)) {
            $body['userids'] = $request->userids;
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
            'action'      => 'UpdateDingPortalPageScope',
            'version'     => 'workbench_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workbench/dingPortals/' . $appUuid . '/pageScopes/' . $pageUuid . '',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return UpdateDingPortalPageScopeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新自定义工作台页面可见性
     *  *
     * @param string                           $pageUuid
     * @param string                           $appUuid
     * @param UpdateDingPortalPageScopeRequest $request  UpdateDingPortalPageScopeRequest
     *
     * @return UpdateDingPortalPageScopeResponse UpdateDingPortalPageScopeResponse
     */
    public function updateDingPortalPageScope($pageUuid, $appUuid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateDingPortalPageScopeHeaders([]);

        return $this->updateDingPortalPageScopeWithOptions($pageUuid, $appUuid, $request, $headers, $runtime);
    }
}
