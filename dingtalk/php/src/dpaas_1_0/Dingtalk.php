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
     * @param InstallCoolAppOrderToGroupRequest $request
     * @param InstallCoolAppOrderToGroupHeaders $headers
     * @param RuntimeOptions                    $runtime
     *
     * @return InstallCoolAppOrderToGroupResponse
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
     * @param InstallCoolAppOrderToGroupRequest $request
     *
     * @return InstallCoolAppOrderToGroupResponse
     */
    public function installCoolAppOrderToGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new InstallCoolAppOrderToGroupHeaders([]);

        return $this->installCoolAppOrderToGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @param InstallCoolAppToGroupRequest $request
     * @param InstallCoolAppToGroupHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return InstallCoolAppToGroupResponse
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
     * @param InstallCoolAppToGroupRequest $request
     *
     * @return InstallCoolAppToGroupResponse
     */
    public function installCoolAppToGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new InstallCoolAppToGroupHeaders([]);

        return $this->installCoolAppToGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryCoolAppShortcutOrderRequest $request
     * @param QueryCoolAppShortcutOrderHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return QueryCoolAppShortcutOrderResponse
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
     * @param QueryCoolAppShortcutOrderRequest $request
     *
     * @return QueryCoolAppShortcutOrderResponse
     */
    public function queryCoolAppShortcutOrder($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryCoolAppShortcutOrderHeaders([]);

        return $this->queryCoolAppShortcutOrderWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UninstallCoolAppFromGroupRequest $request
     * @param UninstallCoolAppFromGroupHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return UninstallCoolAppFromGroupResponse
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
     * @param UninstallCoolAppFromGroupRequest $request
     *
     * @return UninstallCoolAppFromGroupResponse
     */
    public function uninstallCoolAppFromGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UninstallCoolAppFromGroupHeaders([]);

        return $this->uninstallCoolAppFromGroupWithOptions($request, $headers, $runtime);
    }
}
