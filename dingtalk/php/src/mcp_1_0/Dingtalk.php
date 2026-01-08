<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmcp_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vmcp_1_0\Models\ActivateMcpHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmcp_1_0\Models\ActivateMcpRequest;
use AlibabaCloud\SDK\Dingtalk\Vmcp_1_0\Models\ActivateMcpResponse;
use AlibabaCloud\SDK\Dingtalk\Vmcp_1_0\Models\DeleteMcpHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmcp_1_0\Models\DeleteMcpRequest;
use AlibabaCloud\SDK\Dingtalk\Vmcp_1_0\Models\DeleteMcpResponse;
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
     * @summary 激活MCP
     *  *
     * @param ActivateMcpRequest $request ActivateMcpRequest
     * @param ActivateMcpHeaders $headers ActivateMcpHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return ActivateMcpResponse ActivateMcpResponse
     */
    public function activateMcpWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->mcpId)) {
            $body['mcpId'] = $request->mcpId;
        }
        if (!Utils::isUnset($request->source)) {
            $body['source'] = $request->source;
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
            'action' => 'ActivateMcp',
            'version' => 'mcp_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/mcp/activate',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ActivateMcpResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 激活MCP
     *  *
     * @param ActivateMcpRequest $request ActivateMcpRequest
     *
     * @return ActivateMcpResponse ActivateMcpResponse
     */
    public function activateMcp($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ActivateMcpHeaders([]);

        return $this->activateMcpWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除MCP实例
     *  *
     * @param DeleteMcpRequest $request DeleteMcpRequest
     * @param DeleteMcpHeaders $headers DeleteMcpHeaders
     * @param RuntimeOptions   $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteMcpResponse DeleteMcpResponse
     */
    public function deleteMcpWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->instanceId)) {
            $body['instanceId'] = $request->instanceId;
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
            'action' => 'DeleteMcp',
            'version' => 'mcp_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/mcp/delete',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return DeleteMcpResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除MCP实例
     *  *
     * @param DeleteMcpRequest $request DeleteMcpRequest
     *
     * @return DeleteMcpResponse DeleteMcpResponse
     */
    public function deleteMcp($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteMcpHeaders([]);

        return $this->deleteMcpWithOptions($request, $headers, $runtime);
    }
}
