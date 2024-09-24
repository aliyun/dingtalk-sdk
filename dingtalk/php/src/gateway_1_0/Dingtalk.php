<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vgateway_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vgateway_1_0\Models\OpenConnectionRequest;
use AlibabaCloud\SDK\Dingtalk\Vgateway_1_0\Models\OpenConnectionResponse;
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
     * @summary 云上网关注册长连接
     *  *
     * @param OpenConnectionRequest $request OpenConnectionRequest
     * @param string[]              $headers map
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return OpenConnectionResponse OpenConnectionResponse
     */
    public function openConnectionWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->clientId)) {
            $body['clientId'] = $request->clientId;
        }
        if (!Utils::isUnset($request->clientSecret)) {
            $body['clientSecret'] = $request->clientSecret;
        }
        if (!Utils::isUnset($request->extras)) {
            $body['extras'] = $request->extras;
        }
        if (!Utils::isUnset($request->localIp)) {
            $body['localIp'] = $request->localIp;
        }
        if (!Utils::isUnset($request->subscriptions)) {
            $body['subscriptions'] = $request->subscriptions;
        }
        $req = new OpenApiRequest([
            'headers' => $headers,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'OpenConnection',
            'version'     => 'gateway_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/gateway/connections/open',
            'method'      => 'POST',
            'authType'    => 'Anonymous',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return OpenConnectionResponse::fromMap($this->doROARequestWithForm($params->action, $params->version, $params->protocol, $params->method, $params->authType, $params->pathname, $params->bodyType, $req, $runtime));
    }

    /**
     * @summary 云上网关注册长连接
     *  *
     * @param OpenConnectionRequest $request OpenConnectionRequest
     *
     * @return OpenConnectionResponse OpenConnectionResponse
     */
    public function openConnection($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = [];

        return $this->openConnectionWithOptions($request, $headers, $runtime);
    }
}
