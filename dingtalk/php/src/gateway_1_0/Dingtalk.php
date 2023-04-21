<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vgateway_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vgateway_1_0\Models\OpenConnectionRequest;
use AlibabaCloud\SDK\Dingtalk\Vgateway_1_0\Models\OpenConnectionResponse;
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
     * @param OpenConnectionRequest $request
     *
     * @return OpenConnectionResponse
     */
    public function openConnection($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = [];

        return $this->openConnectionWithOptions($request, $headers, $runtime);
    }

    /**
     * @param OpenConnectionRequest $request
     * @param string[]              $headers
     * @param RuntimeOptions        $runtime
     *
     * @return OpenConnectionResponse
     */
    public function openConnectionWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->clientId)) {
            @$body['clientId'] = $request->clientId;
        }
        if (!Utils::isUnset($request->clientSecret)) {
            @$body['clientSecret'] = $request->clientSecret;
        }
        if (!Utils::isUnset($request->subscriptions)) {
            @$body['subscriptions'] = $request->subscriptions;
        }
        $req = new OpenApiRequest([
            'headers' => $headers,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return OpenConnectionResponse::fromMap($this->doROARequest('OpenConnection', 'gateway_1.0', 'HTTP', 'POST', 'AK', '/v1.0/gateway/connections/open', 'json', $req, $runtime));
    }
}
