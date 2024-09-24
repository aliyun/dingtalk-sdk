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
     * @summary 生成jsapi ticket
     *  *
     * @param CreateJsapiTicketHeaders $headers CreateJsapiTicketHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateJsapiTicketResponse CreateJsapiTicketResponse
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
     * @summary 生成jsapi ticket
     *  *
     * @return CreateJsapiTicketResponse CreateJsapiTicketResponse
     */
    public function createJsapiTicket()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateJsapiTicketHeaders([]);

        return $this->createJsapiTicketWithOptions($headers, $runtime);
    }

    /**
     * @summary 获取企业accessToken(企业内部应用)
     *  *
     * @param GetAccessTokenRequest $request GetAccessTokenRequest
     * @param string[]              $headers map
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return GetAccessTokenResponse GetAccessTokenResponse
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

        return GetAccessTokenResponse::fromMap($this->doROARequestWithForm($params->action, $params->version, $params->protocol, $params->method, $params->authType, $params->pathname, $params->bodyType, $req, $runtime));
    }

    /**
     * @summary 获取企业accessToken(企业内部应用)
     *  *
     * @param GetAccessTokenRequest $request GetAccessTokenRequest
     *
     * @return GetAccessTokenResponse GetAccessTokenResponse
     */
    public function getAccessToken($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = [];

        return $this->getAccessTokenWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取企业开通应用后的授权信息
     *  *
     * @param GetAuthInfoRequest $request GetAuthInfoRequest
     * @param GetAuthInfoHeaders $headers GetAuthInfoHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return GetAuthInfoResponse GetAuthInfoResponse
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
     * @summary 获取企业开通应用后的授权信息
     *  *
     * @param GetAuthInfoRequest $request GetAuthInfoRequest
     *
     * @return GetAuthInfoResponse GetAuthInfoResponse
     */
    public function getAuthInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetAuthInfoHeaders([]);

        return $this->getAuthInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取企业accessToken(应用商店应用)
     *  *
     * @param GetCorpAccessTokenRequest $request GetCorpAccessTokenRequest
     * @param string[]                  $headers map
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return GetCorpAccessTokenResponse GetCorpAccessTokenResponse
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

        return GetCorpAccessTokenResponse::fromMap($this->doROARequestWithForm($params->action, $params->version, $params->protocol, $params->method, $params->authType, $params->pathname, $params->bodyType, $req, $runtime));
    }

    /**
     * @summary 获取企业accessToken(应用商店应用)
     *  *
     * @param GetCorpAccessTokenRequest $request GetCorpAccessTokenRequest
     *
     * @return GetCorpAccessTokenResponse GetCorpAccessTokenResponse
     */
    public function getCorpAccessToken($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = [];

        return $this->getCorpAccessTokenWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询个人授权记录
     *  *
     * @param GetPersonalAuthRuleHeaders $headers GetPersonalAuthRuleHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return GetPersonalAuthRuleResponse GetPersonalAuthRuleResponse
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
     * @summary 查询个人授权记录
     *  *
     * @return GetPersonalAuthRuleResponse GetPersonalAuthRuleResponse
     */
    public function getPersonalAuthRule()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetPersonalAuthRuleHeaders([]);

        return $this->getPersonalAuthRuleWithOptions($headers, $runtime);
    }

    /**
     * @summary 生成微应用管理后台accessToken
     *  *
     * @param GetSsoAccessTokenRequest $request GetSsoAccessTokenRequest
     * @param string[]                 $headers map
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return GetSsoAccessTokenResponse GetSsoAccessTokenResponse
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

        return GetSsoAccessTokenResponse::fromMap($this->doROARequest($params->action, $params->version, $params->protocol, $params->method, $params->authType, $params->pathname, $params->bodyType, $req, $runtime));
    }

    /**
     * @summary 生成微应用管理后台accessToken
     *  *
     * @param GetSsoAccessTokenRequest $request GetSsoAccessTokenRequest
     *
     * @return GetSsoAccessTokenResponse GetSsoAccessTokenResponse
     */
    public function getSsoAccessToken($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = [];

        return $this->getSsoAccessTokenWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询微应用后台免登的用户信息
     *  *
     * @param GetSsoUserInfoRequest $request GetSsoUserInfoRequest
     * @param GetSsoUserInfoHeaders $headers GetSsoUserInfoHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return GetSsoUserInfoResponse GetSsoUserInfoResponse
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
     * @summary 查询微应用后台免登的用户信息
     *  *
     * @param GetSsoUserInfoRequest $request GetSsoUserInfoRequest
     *
     * @return GetSsoUserInfoResponse GetSsoUserInfoResponse
     */
    public function getSsoUserInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSsoUserInfoHeaders([]);

        return $this->getSsoUserInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取isvAccessToken（三方企业应用）
     *  *
     * @param GetSuiteAccessTokenRequest $request GetSuiteAccessTokenRequest
     * @param string[]                   $headers map
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return GetSuiteAccessTokenResponse GetSuiteAccessTokenResponse
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

        return GetSuiteAccessTokenResponse::fromMap($this->doROARequest($params->action, $params->version, $params->protocol, $params->method, $params->authType, $params->pathname, $params->bodyType, $req, $runtime));
    }

    /**
     * @summary 获取isvAccessToken（三方企业应用）
     *  *
     * @param GetSuiteAccessTokenRequest $request GetSuiteAccessTokenRequest
     *
     * @return GetSuiteAccessTokenResponse GetSuiteAccessTokenResponse
     */
    public function getSuiteAccessToken($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = [];

        return $this->getSuiteAccessTokenWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取Access Token
     *  *
     * @param string          $corpId
     * @param GetTokenRequest $request GetTokenRequest
     * @param string[]        $headers map
     * @param RuntimeOptions  $runtime runtime options for this request RuntimeOptions
     *
     * @return GetTokenResponse GetTokenResponse
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

        return GetTokenResponse::fromMap($this->doROARequestWithForm($params->action, $params->version, $params->protocol, $params->method, $params->authType, $params->pathname, $params->bodyType, $req, $runtime));
    }

    /**
     * @summary 获取Access Token
     *  *
     * @param string          $corpId
     * @param GetTokenRequest $request GetTokenRequest
     *
     * @return GetTokenResponse GetTokenResponse
     */
    public function getToken($corpId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = [];

        return $this->getTokenWithOptions($corpId, $request, $headers, $runtime);
    }

    /**
     * @summary 获取用户token
     *  *
     * @param GetUserTokenRequest $request GetUserTokenRequest
     * @param string[]            $headers map
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return GetUserTokenResponse GetUserTokenResponse
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

        return GetUserTokenResponse::fromMap($this->doROARequest($params->action, $params->version, $params->protocol, $params->method, $params->authType, $params->pathname, $params->bodyType, $req, $runtime));
    }

    /**
     * @summary 获取用户token
     *  *
     * @param GetUserTokenRequest $request GetUserTokenRequest
     *
     * @return GetUserTokenResponse GetUserTokenResponse
     */
    public function getUserToken($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = [];

        return $this->getUserTokenWithOptions($request, $headers, $runtime);
    }
}
