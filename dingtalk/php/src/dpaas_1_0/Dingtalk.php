<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdpaas_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vdpaas_1_0\Models\InstallCoolAppOrderToGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdpaas_1_0\Models\InstallCoolAppOrderToGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vdpaas_1_0\Models\InstallCoolAppOrderToGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vdpaas_1_0\Models\InstallCoolAppToGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdpaas_1_0\Models\InstallCoolAppToGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vdpaas_1_0\Models\InstallCoolAppToGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vdpaas_1_0\Models\QueryCoolAppShortcutOrderHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdpaas_1_0\Models\QueryCoolAppShortcutOrderRequest;
use AlibabaCloud\SDK\Dingtalk\Vdpaas_1_0\Models\QueryCoolAppShortcutOrderResponse;
use AlibabaCloud\SDK\Dingtalk\Vdpaas_1_0\Models\UninstallCoolAppFromGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdpaas_1_0\Models\UninstallCoolAppFromGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vdpaas_1_0\Models\UninstallCoolAppFromGroupResponse;
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
     * @summary 群酷应用排序
     *  *
     * @param InstallCoolAppOrderToGroupRequest $request InstallCoolAppOrderToGroupRequest
     * @param InstallCoolAppOrderToGroupHeaders $headers InstallCoolAppOrderToGroupHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return InstallCoolAppOrderToGroupResponse InstallCoolAppOrderToGroupResponse
     */
    public function installCoolAppOrderToGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->conversationId)) {
            $body['conversationId'] = $request->conversationId;
        }
        if (!Utils::isUnset($request->sortedPluginIdList)) {
            $body['sortedPluginIdList'] = $request->sortedPluginIdList;
        }
        if (!Utils::isUnset($request->templateId)) {
            $body['templateId'] = $request->templateId;
        }
        if (!Utils::isUnset($request->unsortedPluginIdList)) {
            $body['unsortedPluginIdList'] = $request->unsortedPluginIdList;
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
            'action'      => 'InstallCoolAppOrderToGroup',
            'version'     => 'dpaas_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/dpaas/coolApps/shortcuts/plugins/order',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return InstallCoolAppOrderToGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 群酷应用排序
     *  *
     * @param InstallCoolAppOrderToGroupRequest $request InstallCoolAppOrderToGroupRequest
     *
     * @return InstallCoolAppOrderToGroupResponse InstallCoolAppOrderToGroupResponse
     */
    public function installCoolAppOrderToGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new InstallCoolAppOrderToGroupHeaders([]);

        return $this->installCoolAppOrderToGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 安装酷应用到群
     *  *
     * @param InstallCoolAppToGroupRequest $request InstallCoolAppToGroupRequest
     * @param InstallCoolAppToGroupHeaders $headers InstallCoolAppToGroupHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return InstallCoolAppToGroupResponse InstallCoolAppToGroupResponse
     */
    public function installCoolAppToGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->conversationId)) {
            $body['conversationId'] = $request->conversationId;
        }
        if (!Utils::isUnset($request->operateCoolAppCode)) {
            $body['operateCoolAppCode'] = $request->operateCoolAppCode;
        }
        if (!Utils::isUnset($request->operatorId)) {
            $body['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->templateId)) {
            $body['templateId'] = $request->templateId;
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
            'action'      => 'InstallCoolAppToGroup',
            'version'     => 'dpaas_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/dpaas/coolApps/shortcuts/plugins/install',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return InstallCoolAppToGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 安装酷应用到群
     *  *
     * @param InstallCoolAppToGroupRequest $request InstallCoolAppToGroupRequest
     *
     * @return InstallCoolAppToGroupResponse InstallCoolAppToGroupResponse
     */
    public function installCoolAppToGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new InstallCoolAppToGroupHeaders([]);

        return $this->installCoolAppToGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询群插件栏
     *  *
     * @param QueryCoolAppShortcutOrderRequest $request QueryCoolAppShortcutOrderRequest
     * @param QueryCoolAppShortcutOrderHeaders $headers QueryCoolAppShortcutOrderHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryCoolAppShortcutOrderResponse QueryCoolAppShortcutOrderResponse
     */
    public function queryCoolAppShortcutOrderWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->conversationId)) {
            $body['conversationId'] = $request->conversationId;
        }
        if (!Utils::isUnset($request->operatorId)) {
            $body['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->templateId)) {
            $body['templateId'] = $request->templateId;
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
            'action'      => 'QueryCoolAppShortcutOrder',
            'version'     => 'dpaas_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/dpaas/coolApps/shortcuts/plugins/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryCoolAppShortcutOrderResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询群插件栏
     *  *
     * @param QueryCoolAppShortcutOrderRequest $request QueryCoolAppShortcutOrderRequest
     *
     * @return QueryCoolAppShortcutOrderResponse QueryCoolAppShortcutOrderResponse
     */
    public function queryCoolAppShortcutOrder($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryCoolAppShortcutOrderHeaders([]);

        return $this->queryCoolAppShortcutOrderWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 从群内卸载酷应用
     *  *
     * @param UninstallCoolAppFromGroupRequest $request UninstallCoolAppFromGroupRequest
     * @param UninstallCoolAppFromGroupHeaders $headers UninstallCoolAppFromGroupHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return UninstallCoolAppFromGroupResponse UninstallCoolAppFromGroupResponse
     */
    public function uninstallCoolAppFromGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->conversationId)) {
            $body['conversationId'] = $request->conversationId;
        }
        if (!Utils::isUnset($request->operateCoolAppCode)) {
            $body['operateCoolAppCode'] = $request->operateCoolAppCode;
        }
        if (!Utils::isUnset($request->operatorId)) {
            $body['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->templateId)) {
            $body['templateId'] = $request->templateId;
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
            'action'      => 'UninstallCoolAppFromGroup',
            'version'     => 'dpaas_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/dpaas/coolApps/shortcuts/plugins/uninstall',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UninstallCoolAppFromGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 从群内卸载酷应用
     *  *
     * @param UninstallCoolAppFromGroupRequest $request UninstallCoolAppFromGroupRequest
     *
     * @return UninstallCoolAppFromGroupResponse UninstallCoolAppFromGroupResponse
     */
    public function uninstallCoolAppFromGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UninstallCoolAppFromGroupHeaders([]);

        return $this->uninstallCoolAppFromGroupWithOptions($request, $headers, $runtime);
    }
}
