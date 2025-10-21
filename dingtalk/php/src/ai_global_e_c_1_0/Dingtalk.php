<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vai_global_e_c_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vai_global_e_c_1_0\Models\ConnectionOmniChannelTiktokMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vai_global_e_c_1_0\Models\ConnectionOmniChannelTiktokMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vai_global_e_c_1_0\Models\ConnectionOmniChannelTiktokMessageResponse;
use AlibabaCloud\SDK\Dingtalk\Vai_global_e_c_1_0\Models\GetLoginUserHeaders;
use AlibabaCloud\SDK\Dingtalk\Vai_global_e_c_1_0\Models\GetLoginUserRequest;
use AlibabaCloud\SDK\Dingtalk\Vai_global_e_c_1_0\Models\GetLoginUserResponse;
use AlibabaCloud\SDK\Dingtalk\Vai_global_e_c_1_0\Models\LaunchHeaders;
use AlibabaCloud\SDK\Dingtalk\Vai_global_e_c_1_0\Models\LaunchRequest;
use AlibabaCloud\SDK\Dingtalk\Vai_global_e_c_1_0\Models\LaunchResponse;
use AlibabaCloud\SDK\Dingtalk\Vai_global_e_c_1_0\Models\QueryNotableInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vai_global_e_c_1_0\Models\QueryNotableInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vai_global_e_c_1_0\Models\QueryNotableInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vai_global_e_c_1_0\Models\TiktokShopAuthCallbackHeaders;
use AlibabaCloud\SDK\Dingtalk\Vai_global_e_c_1_0\Models\TiktokShopAuthCallbackRequest;
use AlibabaCloud\SDK\Dingtalk\Vai_global_e_c_1_0\Models\TiktokShopAuthCallbackResponse;
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
     * @summary 全渠道运营客服tiktok消息接入
     *  *
     * @param ConnectionOmniChannelTiktokMessageRequest $request ConnectionOmniChannelTiktokMessageRequest
     * @param ConnectionOmniChannelTiktokMessageHeaders $headers ConnectionOmniChannelTiktokMessageHeaders
     * @param RuntimeOptions                            $runtime runtime options for this request RuntimeOptions
     *
     * @return ConnectionOmniChannelTiktokMessageResponse ConnectionOmniChannelTiktokMessageResponse
     */
    public function connectionOmniChannelTiktokMessageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->tiktokContentJsonString)) {
            $body['tiktokContentJsonString'] = $request->tiktokContentJsonString;
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
            'action' => 'ConnectionOmniChannelTiktokMessage',
            'version' => 'aiGlobalEC_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/aiGlobalEC/omniChannel/tiktok/im/message/process',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ConnectionOmniChannelTiktokMessageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 全渠道运营客服tiktok消息接入
     *  *
     * @param ConnectionOmniChannelTiktokMessageRequest $request ConnectionOmniChannelTiktokMessageRequest
     *
     * @return ConnectionOmniChannelTiktokMessageResponse ConnectionOmniChannelTiktokMessageResponse
     */
    public function connectionOmniChannelTiktokMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ConnectionOmniChannelTiktokMessageHeaders([]);

        return $this->connectionOmniChannelTiktokMessageWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取当前登录用户版本信息
     *  *
     * @param GetLoginUserRequest $request GetLoginUserRequest
     * @param GetLoginUserHeaders $headers GetLoginUserHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return GetLoginUserResponse GetLoginUserResponse
     */
    public function getLoginUserWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->authCode)) {
            $body['authCode'] = $request->authCode;
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
            'action' => 'GetLoginUser',
            'version' => 'aiGlobalEC_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/aiGlobalEC/authCode/getLoginUser',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetLoginUserResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取当前登录用户版本信息
     *  *
     * @param GetLoginUserRequest $request GetLoginUserRequest
     *
     * @return GetLoginUserResponse GetLoginUserResponse
     */
    public function getLoginUser($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetLoginUserHeaders([]);

        return $this->getLoginUserWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 刊登的对外开放Api
     *  *
     * @param LaunchRequest  $request LaunchRequest
     * @param LaunchHeaders  $headers LaunchHeaders
     * @param RuntimeOptions $runtime runtime options for this request RuntimeOptions
     *
     * @return LaunchResponse LaunchResponse
     */
    public function launchWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->dingAgentId)) {
            $query['dingAgentId'] = $request->dingAgentId;
        }
        if (!Utils::isUnset($request->dingClientId)) {
            $query['dingClientId'] = $request->dingClientId;
        }
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            $query['dingIsvOrgId'] = $request->dingIsvOrgId;
        }
        if (!Utils::isUnset($request->dingOrgId)) {
            $query['dingOrgId'] = $request->dingOrgId;
        }
        if (!Utils::isUnset($request->dingSuiteKey)) {
            $query['dingSuiteKey'] = $request->dingSuiteKey;
        }
        if (!Utils::isUnset($request->dingTokenGrantType)) {
            $query['dingTokenGrantType'] = $request->dingTokenGrantType;
        }
        if (!Utils::isUnset($request->dingUid)) {
            $query['dingUid'] = $request->dingUid;
        }
        $body = [];
        if (!Utils::isUnset($request->description)) {
            $body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->imageUrls)) {
            $body['imageUrls'] = $request->imageUrls;
        }
        if (!Utils::isUnset($request->platform)) {
            $body['platform'] = $request->platform;
        }
        if (!Utils::isUnset($request->productName)) {
            $body['productName'] = $request->productName;
        }
        if (!Utils::isUnset($request->sellingPoints)) {
            $body['sellingPoints'] = $request->sellingPoints;
        }
        if (!Utils::isUnset($request->sourceData)) {
            $body['sourceData'] = $request->sourceData;
        }
        if (!Utils::isUnset($request->variants)) {
            $body['variants'] = $request->variants;
        }
        if (!Utils::isUnset($request->videoUrls)) {
            $body['videoUrls'] = $request->videoUrls;
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
            'query' => OpenApiUtilClient::query($query),
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'Launch',
            'version' => 'aiGlobalEC_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/aiGlobalEC/launch',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return LaunchResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 刊登的对外开放Api
     *  *
     * @param LaunchRequest $request LaunchRequest
     *
     * @return LaunchResponse LaunchResponse
     */
    public function launch($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new LaunchHeaders([]);

        return $this->launchWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 全渠道AI表格业务信息
     *  *
     * @param QueryNotableInfoRequest $request QueryNotableInfoRequest
     * @param QueryNotableInfoHeaders $headers QueryNotableInfoHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryNotableInfoResponse QueryNotableInfoResponse
     */
    public function queryNotableInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->sceneCode)) {
            $query['sceneCode'] = $request->sceneCode;
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'QueryNotableInfo',
            'version' => 'aiGlobalEC_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/aiGlobalEC/omniChannel/notable',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryNotableInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 全渠道AI表格业务信息
     *  *
     * @param QueryNotableInfoRequest $request QueryNotableInfoRequest
     *
     * @return QueryNotableInfoResponse QueryNotableInfoResponse
     */
    public function queryNotableInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryNotableInfoHeaders([]);

        return $this->queryNotableInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 平台店铺授权回调
     *  *
     * @param TiktokShopAuthCallbackRequest $request TiktokShopAuthCallbackRequest
     * @param TiktokShopAuthCallbackHeaders $headers TiktokShopAuthCallbackHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return TiktokShopAuthCallbackResponse TiktokShopAuthCallbackResponse
     */
    public function tiktokShopAuthCallbackWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->sellerType)) {
            $body['sellerType'] = $request->sellerType;
        }
        if (!Utils::isUnset($request->shopId)) {
            $body['shopId'] = $request->shopId;
        }
        if (!Utils::isUnset($request->shopName)) {
            $body['shopName'] = $request->shopName;
        }
        if (!Utils::isUnset($request->shopRegion)) {
            $body['shopRegion'] = $request->shopRegion;
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
            'action' => 'TiktokShopAuthCallback',
            'version' => 'aiGlobalEC_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/aiGlobalEC/omniChannel/tiktok/shop/authCallback',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return TiktokShopAuthCallbackResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 平台店铺授权回调
     *  *
     * @param TiktokShopAuthCallbackRequest $request TiktokShopAuthCallbackRequest
     *
     * @return TiktokShopAuthCallbackResponse TiktokShopAuthCallbackResponse
     */
    public function tiktokShopAuthCallback($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new TiktokShopAuthCallbackHeaders([]);

        return $this->tiktokShopAuthCallbackWithOptions($request, $headers, $runtime);
    }
}
