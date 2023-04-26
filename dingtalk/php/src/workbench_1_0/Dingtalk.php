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
     * @param string                     $appUuid
     * @param GetDingPortalDetailHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return GetDingPortalDetailResponse
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
     * @param string                      $componentId
     * @param QueryComponentScopesHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return QueryComponentScopesResponse
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
     * @param string                     $shortcutKey
     * @param QueryShortcutScopesHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return QueryShortcutScopesResponse
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
}
