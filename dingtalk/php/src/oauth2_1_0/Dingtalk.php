<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Voauth2_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Voauth2_1_0\Models\GetAccessTokenRequest;
use AlibabaCloud\SDK\Dingtalk\Voauth2_1_0\Models\GetAccessTokenResponse;
use AlibabaCloud\SDK\Dingtalk\Voauth2_1_0\Models\GetCorpAccessTokenRequest;
use AlibabaCloud\SDK\Dingtalk\Voauth2_1_0\Models\GetCorpAccessTokenResponse;
use AlibabaCloud\SDK\Dingtalk\Voauth2_1_0\Models\GetSuiteAccessTokenRequest;
use AlibabaCloud\SDK\Dingtalk\Voauth2_1_0\Models\GetSuiteAccessTokenResponse;
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

    /**
     * @param GetAccessTokenRequest $request
     *
     * @return GetAccessTokenResponse
     */
    public function getAccessToken($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = [];

        return $this->getAccessTokenWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetAccessTokenRequest $request
     * @param string[]              $headers
     * @param RuntimeOptions        $runtime
     *
     * @return GetAccessTokenResponse
     */
    public function getAccessTokenWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appKey)) {
            @$body['appKey'] = $request->appKey;
        }
        if (!Utils::isUnset($request->appSecret)) {
            @$body['appSecret'] = $request->appSecret;
        }
        $req = new OpenApiRequest([
            'headers' => $headers,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return GetAccessTokenResponse::fromMap($this->doROARequest('GetAccessToken', 'oauth2_1.0', 'HTTP', 'POST', 'AK', '/v1.0/oauth2/accessToken', 'json', $req, $runtime));
    }

    /**
     * @param GetSuiteAccessTokenRequest $request
     *
     * @return GetSuiteAccessTokenResponse
     */
    public function getSuiteAccessToken($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = [];

        return $this->getSuiteAccessTokenWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetSuiteAccessTokenRequest $request
     * @param string[]                   $headers
     * @param RuntimeOptions             $runtime
     *
     * @return GetSuiteAccessTokenResponse
     */
    public function getSuiteAccessTokenWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->suiteKey)) {
            @$body['suiteKey'] = $request->suiteKey;
        }
        if (!Utils::isUnset($request->suiteSecret)) {
            @$body['suiteSecret'] = $request->suiteSecret;
        }
        if (!Utils::isUnset($request->suiteTicket)) {
            @$body['suiteTicket'] = $request->suiteTicket;
        }
        $req = new OpenApiRequest([
            'headers' => $headers,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return GetSuiteAccessTokenResponse::fromMap($this->doROARequest('GetSuiteAccessToken', 'oauth2_1.0', 'HTTP', 'POST', 'AK', '/v1.0/oauth2/suiteAccessToken', 'json', $req, $runtime));
    }

    /**
     * @param GetCorpAccessTokenRequest $request
     *
     * @return GetCorpAccessTokenResponse
     */
    public function getCorpAccessToken($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = [];

        return $this->getCorpAccessTokenWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetCorpAccessTokenRequest $request
     * @param string[]                  $headers
     * @param RuntimeOptions            $runtime
     *
     * @return GetCorpAccessTokenResponse
     */
    public function getCorpAccessTokenWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->suiteKey)) {
            @$body['suiteKey'] = $request->suiteKey;
        }
        if (!Utils::isUnset($request->suiteSecret)) {
            @$body['suiteSecret'] = $request->suiteSecret;
        }
        if (!Utils::isUnset($request->authCorpId)) {
            @$body['authCorpId'] = $request->authCorpId;
        }
        if (!Utils::isUnset($request->suiteTicket)) {
            @$body['suiteTicket'] = $request->suiteTicket;
        }
        $req = new OpenApiRequest([
            'headers' => $headers,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return GetCorpAccessTokenResponse::fromMap($this->doROARequest('GetCorpAccessToken', 'oauth2_1.0', 'HTTP', 'POST', 'AK', '/v1.0/oauth2/corpAccessToken', 'json', $req, $runtime));
    }
}
