<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Voauth2_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Voauth2_1_0\Models\GetUserTokenRequest;
use AlibabaCloud\SDK\Dingtalk\Voauth2_1_0\Models\GetUserTokenResponse;
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
     * @param GetUserTokenRequest $request
     *
     * @return GetUserTokenResponse
     */
    public function getUserToken($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = [];

        return $this->getUserTokenWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetUserTokenRequest $request
     * @param string[]            $headers
     * @param RuntimeOptions      $runtime
     *
     * @return GetUserTokenResponse
     */
    public function getUserTokenWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->clientId)) {
            @$body['clientId'] = $request->clientId;
        }
        if (!Utils::isUnset($request->clientSecret)) {
            @$body['clientSecret'] = $request->clientSecret;
        }
        if (!Utils::isUnset($request->code)) {
            @$body['code'] = $request->code;
        }
        if (!Utils::isUnset($request->refreshToken)) {
            @$body['refreshToken'] = $request->refreshToken;
        }
        if (!Utils::isUnset($request->grantType)) {
            @$body['grantType'] = $request->grantType;
        }
        $req = new OpenApiRequest([
            'headers' => $headers,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return GetUserTokenResponse::fromMap($this->doROARequest('GetUserToken', 'oauth2_1.0', 'HTTP', 'POST', 'AK', '/v1.0/oauth2/userAccessToken', 'json', $req, $runtime));
    }
}
