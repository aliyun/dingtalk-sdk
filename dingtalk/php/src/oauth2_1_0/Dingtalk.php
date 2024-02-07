<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Voauth2_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Voauth2_1_0\Models\CreateJsapiTicketHeaders;
use AlibabaCloud\SDK\Dingtalk\Voauth2_1_0\Models\CreateJsapiTicketResponse;
use AlibabaCloud\SDK\Dingtalk\Voauth2_1_0\Models\GetAccessTokenRequest;
use AlibabaCloud\SDK\Dingtalk\Voauth2_1_0\Models\GetAccessTokenResponse;
use AlibabaCloud\SDK\Dingtalk\Voauth2_1_0\Models\GetAuthInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Voauth2_1_0\Models\GetAuthInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Voauth2_1_0\Models\GetAuthInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Voauth2_1_0\Models\GetCorpAccessTokenRequest;
use AlibabaCloud\SDK\Dingtalk\Voauth2_1_0\Models\GetCorpAccessTokenResponse;
use AlibabaCloud\SDK\Dingtalk\Voauth2_1_0\Models\GetPersonalAuthRuleHeaders;
use AlibabaCloud\SDK\Dingtalk\Voauth2_1_0\Models\GetPersonalAuthRuleResponse;
use AlibabaCloud\SDK\Dingtalk\Voauth2_1_0\Models\GetSsoAccessTokenRequest;
use AlibabaCloud\SDK\Dingtalk\Voauth2_1_0\Models\GetSsoAccessTokenResponse;
use AlibabaCloud\SDK\Dingtalk\Voauth2_1_0\Models\GetSsoUserInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Voauth2_1_0\Models\GetSsoUserInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Voauth2_1_0\Models\GetSsoUserInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Voauth2_1_0\Models\GetSuiteAccessTokenRequest;
use AlibabaCloud\SDK\Dingtalk\Voauth2_1_0\Models\GetSuiteAccessTokenResponse;
use AlibabaCloud\SDK\Dingtalk\Voauth2_1_0\Models\GetTokenRequest;
use AlibabaCloud\SDK\Dingtalk\Voauth2_1_0\Models\GetTokenResponse;
use AlibabaCloud\SDK\Dingtalk\Voauth2_1_0\Models\GetUserTokenRequest;
use AlibabaCloud\SDK\Dingtalk\Voauth2_1_0\Models\GetUserTokenResponse;
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
        $this->_client             = new DarabonbaGatewayDingTalkClient();
        $this->_spi                = $this->_client;
        $this->_signatureAlgorithm = 'v2';
        $this->_endpointRule       = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @param CreateJsapiTicketHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return CreateJsapiTicketResponse
     */
    public function createJsapiTicketWithOptions($headers, $runtime)
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
            'action'      => 'CreateJsapiTicket',
            'version'     => 'oauth2_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/oauth2/jsapiTickets',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateJsapiTicketResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @return CreateJsapiTicketResponse
     */
    public function createJsapiTicket()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateJsapiTicketHeaders([]);

        return $this->createJsapiTicketWithOptions($headers, $runtime);
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
            $body['appKey'] = $request->appKey;
        }
        if (!Utils::isUnset($request->appSecret)) {
            $body['appSecret'] = $request->appSecret;
        }
        $req = new OpenApiRequest([
            'headers' => $headers,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'GetAccessToken',
            'version'     => 'oauth2_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/oauth2/accessToken',
            'method'      => 'POST',
            'authType'    => 'Anonymous',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetAccessTokenResponse::fromMap($this->execute($params, $req, $runtime));
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
     * @param GetAuthInfoRequest $request
     * @param GetAuthInfoHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return GetAuthInfoResponse
     */
    public function getAuthInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->authCorpId)) {
            $query['authCorpId'] = $request->authCorpId;
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
            'action'      => 'GetAuthInfo',
            'version'     => 'oauth2_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/oauth2/apps/authInfo',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return GetAuthInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetAuthInfoRequest $request
     *
     * @return GetAuthInfoResponse
     */
    public function getAuthInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetAuthInfoHeaders([]);

        return $this->getAuthInfoWithOptions($request, $headers, $runtime);
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
        if (!Utils::isUnset($request->authCorpId)) {
            $body['authCorpId'] = $request->authCorpId;
        }
        if (!Utils::isUnset($request->suiteKey)) {
            $body['suiteKey'] = $request->suiteKey;
        }
        if (!Utils::isUnset($request->suiteSecret)) {
            $body['suiteSecret'] = $request->suiteSecret;
        }
        if (!Utils::isUnset($request->suiteTicket)) {
            $body['suiteTicket'] = $request->suiteTicket;
        }
        $req = new OpenApiRequest([
            'headers' => $headers,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'GetCorpAccessToken',
            'version'     => 'oauth2_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/oauth2/corpAccessToken',
            'method'      => 'POST',
            'authType'    => 'Anonymous',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetCorpAccessTokenResponse::fromMap($this->execute($params, $req, $runtime));
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
     * @param GetPersonalAuthRuleHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return GetPersonalAuthRuleResponse
     */
    public function getPersonalAuthRuleWithOptions($headers, $runtime)
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
            'action'      => 'GetPersonalAuthRule',
            'version'     => 'oauth2_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/oauth2/authRules/user',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return GetPersonalAuthRuleResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @return GetPersonalAuthRuleResponse
     */
    public function getPersonalAuthRule()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetPersonalAuthRuleHeaders([]);

        return $this->getPersonalAuthRuleWithOptions($headers, $runtime);
    }

    /**
     * @param GetSsoAccessTokenRequest $request
     * @param string[]                 $headers
     * @param RuntimeOptions           $runtime
     *
     * @return GetSsoAccessTokenResponse
     */
    public function getSsoAccessTokenWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->corpid)) {
            $body['corpid'] = $request->corpid;
        }
        if (!Utils::isUnset($request->ssoSecret)) {
            $body['ssoSecret'] = $request->ssoSecret;
        }
        $req = new OpenApiRequest([
            'headers' => $headers,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'GetSsoAccessToken',
            'version'     => 'oauth2_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/oauth2/ssoAccessToken',
            'method'      => 'POST',
            'authType'    => 'Anonymous',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return GetSsoAccessTokenResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetSsoAccessTokenRequest $request
     *
     * @return GetSsoAccessTokenResponse
     */
    public function getSsoAccessToken($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = [];

        return $this->getSsoAccessTokenWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetSsoUserInfoRequest $request
     * @param GetSsoUserInfoHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return GetSsoUserInfoResponse
     */
    public function getSsoUserInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->code)) {
            $query['code'] = $request->code;
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
            'action'      => 'GetSsoUserInfo',
            'version'     => 'oauth2_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/oauth2/ssoUserInfo',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetSsoUserInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetSsoUserInfoRequest $request
     *
     * @return GetSsoUserInfoResponse
     */
    public function getSsoUserInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSsoUserInfoHeaders([]);

        return $this->getSsoUserInfoWithOptions($request, $headers, $runtime);
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
            $body['suiteKey'] = $request->suiteKey;
        }
        if (!Utils::isUnset($request->suiteSecret)) {
            $body['suiteSecret'] = $request->suiteSecret;
        }
        if (!Utils::isUnset($request->suiteTicket)) {
            $body['suiteTicket'] = $request->suiteTicket;
        }
        $req = new OpenApiRequest([
            'headers' => $headers,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'GetSuiteAccessToken',
            'version'     => 'oauth2_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/oauth2/suiteAccessToken',
            'method'      => 'POST',
            'authType'    => 'Anonymous',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return GetSuiteAccessTokenResponse::fromMap($this->execute($params, $req, $runtime));
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
     * @param string          $corpId
     * @param GetTokenRequest $request
     * @param string[]        $headers
     * @param RuntimeOptions  $runtime
     *
     * @return GetTokenResponse
     */
    public function getTokenWithOptions($corpId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->clientId)) {
            $body['client_id'] = $request->clientId;
        }
        if (!Utils::isUnset($request->clientSecret)) {
            $body['client_secret'] = $request->clientSecret;
        }
        if (!Utils::isUnset($request->grantType)) {
            $body['grant_type'] = $request->grantType;
        }
        $req = new OpenApiRequest([
            'headers' => $headers,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'GetToken',
            'version'     => 'oauth2_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/oauth2/' . $corpId . '/token',
            'method'      => 'POST',
            'authType'    => 'Anonymous',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetTokenResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string          $corpId
     * @param GetTokenRequest $request
     *
     * @return GetTokenResponse
     */
    public function getToken($corpId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = [];

        return $this->getTokenWithOptions($corpId, $request, $headers, $runtime);
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
            $body['clientId'] = $request->clientId;
        }
        if (!Utils::isUnset($request->clientSecret)) {
            $body['clientSecret'] = $request->clientSecret;
        }
        if (!Utils::isUnset($request->code)) {
            $body['code'] = $request->code;
        }
        if (!Utils::isUnset($request->grantType)) {
            $body['grantType'] = $request->grantType;
        }
        if (!Utils::isUnset($request->refreshToken)) {
            $body['refreshToken'] = $request->refreshToken;
        }
        $req = new OpenApiRequest([
            'headers' => $headers,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'GetUserToken',
            'version'     => 'oauth2_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/oauth2/userAccessToken',
            'method'      => 'POST',
            'authType'    => 'Anonymous',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return GetUserTokenResponse::fromMap($this->execute($params, $req, $runtime));
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
}
