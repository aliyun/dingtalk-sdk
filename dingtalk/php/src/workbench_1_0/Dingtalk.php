<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkbench_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
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
use AlibabaCloud\SDK\Dingtalk\Vworkbench_1_0\Models\QueryComponentScopesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkbench_1_0\Models\QueryComponentScopesResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkbench_1_0\Models\QueryShortcutScopesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkbench_1_0\Models\QueryShortcutScopesResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkbench_1_0\Models\UpdateDingPortalPageScopeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkbench_1_0\Models\UpdateDingPortalPageScopeRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkbench_1_0\Models\UpdateDingPortalPageScopeResponse;
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
     * @param string $appUuid
     *
     * @return GetDingPortalDetailResponse
     */
    public function getDingPortalDetail($appUuid)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetDingPortalDetailHeaders([]);

        return $this->getDingPortalDetailWithOptions($appUuid, $headers, $runtime);
    }

    /**
     * @param string                     $appUuid
     * @param GetDingPortalDetailHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return GetDingPortalDetailResponse
     */
    public function getDingPortalDetailWithOptions($appUuid, $headers, $runtime)
    {
        $appUuid     = OpenApiUtilClient::getEncodeParam($appUuid);
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

        return GetDingPortalDetailResponse::fromMap($this->doROARequest('GetDingPortalDetail', 'workbench_1.0', 'HTTP', 'GET', 'AK', '/v1.0/workbench/dingPortals/' . $appUuid . '', 'json', $req, $runtime));
    }

    /**
     * @param GetPluginPermissionPointRequest $request
     *
     * @return GetPluginPermissionPointResponse
     */
    public function getPluginPermissionPoint($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetPluginPermissionPointHeaders([]);

        return $this->getPluginPermissionPointWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetPluginPermissionPointRequest $request
     * @param GetPluginPermissionPointHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return GetPluginPermissionPointResponse
     */
    public function getPluginPermissionPointWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->miniAppId)) {
            @$query['miniAppId'] = $request->miniAppId;
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

        return GetPluginPermissionPointResponse::fromMap($this->doROARequest('GetPluginPermissionPoint', 'workbench_1.0', 'HTTP', 'GET', 'AK', '/v1.0/workbench/plugins/permissions', 'json', $req, $runtime));
    }

    /**
     * @param GetPluginRuleCheckInfoRequest $request
     *
     * @return GetPluginRuleCheckInfoResponse
     */
    public function getPluginRuleCheckInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetPluginRuleCheckInfoHeaders([]);

        return $this->getPluginRuleCheckInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetPluginRuleCheckInfoRequest $request
     * @param GetPluginRuleCheckInfoHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return GetPluginRuleCheckInfoResponse
     */
    public function getPluginRuleCheckInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->miniAppId)) {
            @$query['miniAppId'] = $request->miniAppId;
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

        return GetPluginRuleCheckInfoResponse::fromMap($this->doROARequest('GetPluginRuleCheckInfo', 'workbench_1.0', 'HTTP', 'GET', 'AK', '/v1.0/workbench/plugins/validationRules', 'json', $req, $runtime));
    }

    /**
     * @param ListWorkBenchGroupRequest $request
     *
     * @return ListWorkBenchGroupResponse
     */
    public function listWorkBenchGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListWorkBenchGroupHeaders([]);

        return $this->listWorkBenchGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ListWorkBenchGroupRequest $request
     * @param ListWorkBenchGroupHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return ListWorkBenchGroupResponse
     */
    public function listWorkBenchGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->ecologicalCorpId)) {
            @$query['ecologicalCorpId'] = $request->ecologicalCorpId;
        }
        if (!Utils::isUnset($request->groupType)) {
            @$query['groupType'] = $request->groupType;
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

        return ListWorkBenchGroupResponse::fromMap($this->doROARequest('ListWorkBenchGroup', 'workbench_1.0', 'HTTP', 'GET', 'AK', '/v1.0/workbench/groups', 'json', $req, $runtime));
    }

    /**
     * @param string $componentId
     *
     * @return QueryComponentScopesResponse
     */
    public function queryComponentScopes($componentId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryComponentScopesHeaders([]);

        return $this->queryComponentScopesWithOptions($componentId, $headers, $runtime);
    }

    /**
     * @param string                      $componentId
     * @param QueryComponentScopesHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return QueryComponentScopesResponse
     */
    public function queryComponentScopesWithOptions($componentId, $headers, $runtime)
    {
        $componentId = OpenApiUtilClient::getEncodeParam($componentId);
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

        return QueryComponentScopesResponse::fromMap($this->doROARequest('QueryComponentScopes', 'workbench_1.0', 'HTTP', 'GET', 'AK', '/v1.0/workbench/components/' . $componentId . '/scopes', 'json', $req, $runtime));
    }

    /**
     * @param string $shortcutKey
     *
     * @return QueryShortcutScopesResponse
     */
    public function queryShortcutScopes($shortcutKey)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryShortcutScopesHeaders([]);

        return $this->queryShortcutScopesWithOptions($shortcutKey, $headers, $runtime);
    }

    /**
     * @param string                     $shortcutKey
     * @param QueryShortcutScopesHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return QueryShortcutScopesResponse
     */
    public function queryShortcutScopesWithOptions($shortcutKey, $headers, $runtime)
    {
        $shortcutKey = OpenApiUtilClient::getEncodeParam($shortcutKey);
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

        return QueryShortcutScopesResponse::fromMap($this->doROARequest('QueryShortcutScopes', 'workbench_1.0', 'HTTP', 'GET', 'AK', '/v1.0/workbench/shortcuts/' . $shortcutKey . '/scopes', 'json', $req, $runtime));
    }

    /**
     * @param string                           $pageUuid
     * @param string                           $appUuid
     * @param UpdateDingPortalPageScopeRequest $request
     *
     * @return UpdateDingPortalPageScopeResponse
     */
    public function updateDingPortalPageScope($pageUuid, $appUuid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateDingPortalPageScopeHeaders([]);

        return $this->updateDingPortalPageScopeWithOptions($pageUuid, $appUuid, $request, $headers, $runtime);
    }

    /**
     * @param string                           $pageUuid
     * @param string                           $appUuid
     * @param UpdateDingPortalPageScopeRequest $request
     * @param UpdateDingPortalPageScopeHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return UpdateDingPortalPageScopeResponse
     */
    public function updateDingPortalPageScopeWithOptions($pageUuid, $appUuid, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $pageUuid = OpenApiUtilClient::getEncodeParam($pageUuid);
        $appUuid  = OpenApiUtilClient::getEncodeParam($appUuid);
        $body     = [];
        if (!Utils::isUnset($request->allVisible)) {
            @$body['allVisible'] = $request->allVisible;
        }
        if (!Utils::isUnset($request->deptIds)) {
            @$body['deptIds'] = $request->deptIds;
        }
        if (!Utils::isUnset($request->roleIds)) {
            @$body['roleIds'] = $request->roleIds;
        }
        if (!Utils::isUnset($request->userids)) {
            @$body['userids'] = $request->userids;
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

        return UpdateDingPortalPageScopeResponse::fromMap($this->doROARequest('UpdateDingPortalPageScope', 'workbench_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/workbench/dingPortals/' . $appUuid . '/pageScopes/' . $pageUuid . '', 'none', $req, $runtime));
    }
}
