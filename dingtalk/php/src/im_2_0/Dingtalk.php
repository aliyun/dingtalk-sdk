<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_2_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vim_2_0\Models\CloseTopboxHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_2_0\Models\CloseTopboxRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_2_0\Models\CloseTopboxResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_2_0\Models\CreateCoupleGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_2_0\Models\CreateCoupleGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_2_0\Models\CreateCoupleGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_2_0\Models\CreateGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_2_0\Models\CreateGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_2_0\Models\CreateGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_2_0\Models\CreateTopboxHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_2_0\Models\CreateTopboxRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_2_0\Models\CreateTopboxResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_2_0\Models\GroupManagerDeviceMarketResponse;
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
     * @summary 关闭互动卡片吊顶
     *  *
     * @param CloseTopboxRequest $request CloseTopboxRequest
     * @param CloseTopboxHeaders $headers CloseTopboxHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return CloseTopboxResponse CloseTopboxResponse
     */
    public function closeTopboxWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->conversationType)) {
            $body['conversationType'] = $request->conversationType;
        }
        if (!Utils::isUnset($request->coolAppCode)) {
            $body['coolAppCode'] = $request->coolAppCode;
        }
        if (!Utils::isUnset($request->groupTemplateId)) {
            $body['groupTemplateId'] = $request->groupTemplateId;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->outTrackId)) {
            $body['outTrackId'] = $request->outTrackId;
        }
        if (!Utils::isUnset($request->robotCode)) {
            $body['robotCode'] = $request->robotCode;
        }
        if (!Utils::isUnset($request->unoinId)) {
            $body['unoinId'] = $request->unoinId;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
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
            'action'      => 'CloseTopbox',
            'version'     => 'im_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/im/topBoxes/close',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CloseTopboxResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 关闭互动卡片吊顶
     *  *
     * @param CloseTopboxRequest $request CloseTopboxRequest
     *
     * @return CloseTopboxResponse CloseTopboxResponse
     */
    public function closeTopbox($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CloseTopboxHeaders([]);

        return $this->closeTopboxWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建两人群
     *  *
     * @param CreateCoupleGroupRequest $request CreateCoupleGroupRequest
     * @param CreateCoupleGroupHeaders $headers CreateCoupleGroupHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateCoupleGroupResponse CreateCoupleGroupResponse
     */
    public function createCoupleGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->groupTemplateId)) {
            $body['groupTemplateId'] = $request->groupTemplateId;
        }
        if (!Utils::isUnset($request->operatorId)) {
            $body['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->users)) {
            $body['users'] = $request->users;
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
            'action'      => 'CreateCoupleGroup',
            'version'     => 'im_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/im/interconnections/couples/groups',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateCoupleGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建两人群
     *  *
     * @param CreateCoupleGroupRequest $request CreateCoupleGroupRequest
     *
     * @return CreateCoupleGroupResponse CreateCoupleGroupResponse
     */
    public function createCoupleGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateCoupleGroupHeaders([]);

        return $this->createCoupleGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建普通群
     *  *
     * @param CreateGroupRequest $request CreateGroupRequest
     * @param CreateGroupHeaders $headers CreateGroupHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateGroupResponse CreateGroupResponse
     */
    public function createGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->groupAvatar)) {
            $body['groupAvatar'] = $request->groupAvatar;
        }
        if (!Utils::isUnset($request->groupName)) {
            $body['groupName'] = $request->groupName;
        }
        if (!Utils::isUnset($request->groupTemplateId)) {
            $body['groupTemplateId'] = $request->groupTemplateId;
        }
        if (!Utils::isUnset($request->operatorId)) {
            $body['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->users)) {
            $body['users'] = $request->users;
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
            'action'      => 'CreateGroup',
            'version'     => 'im_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/im/interconnections/groups',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建普通群
     *  *
     * @param CreateGroupRequest $request CreateGroupRequest
     *
     * @return CreateGroupResponse CreateGroupResponse
     */
    public function createGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateGroupHeaders([]);

        return $this->createGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建并开启互动卡片吊顶
     *  *
     * @param CreateTopboxRequest $request CreateTopboxRequest
     * @param CreateTopboxHeaders $headers CreateTopboxHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateTopboxResponse CreateTopboxResponse
     */
    public function createTopboxWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->callbackRouteKey)) {
            $body['callbackRouteKey'] = $request->callbackRouteKey;
        }
        if (!Utils::isUnset($request->cardData)) {
            $body['cardData'] = $request->cardData;
        }
        if (!Utils::isUnset($request->cardSettings)) {
            $body['cardSettings'] = $request->cardSettings;
        }
        if (!Utils::isUnset($request->cardTemplateId)) {
            $body['cardTemplateId'] = $request->cardTemplateId;
        }
        if (!Utils::isUnset($request->conversationType)) {
            $body['conversationType'] = $request->conversationType;
        }
        if (!Utils::isUnset($request->coolAppCode)) {
            $body['coolAppCode'] = $request->coolAppCode;
        }
        if (!Utils::isUnset($request->expiredTime)) {
            $body['expiredTime'] = $request->expiredTime;
        }
        if (!Utils::isUnset($request->groupTemplateId)) {
            $body['groupTemplateId'] = $request->groupTemplateId;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->outTrackId)) {
            $body['outTrackId'] = $request->outTrackId;
        }
        if (!Utils::isUnset($request->platforms)) {
            $body['platforms'] = $request->platforms;
        }
        if (!Utils::isUnset($request->receiverUnionIdList)) {
            $body['receiverUnionIdList'] = $request->receiverUnionIdList;
        }
        if (!Utils::isUnset($request->receiverUserIdList)) {
            $body['receiverUserIdList'] = $request->receiverUserIdList;
        }
        if (!Utils::isUnset($request->robotCode)) {
            $body['robotCode'] = $request->robotCode;
        }
        if (!Utils::isUnset($request->unionIdPrivateDataMap)) {
            $body['unionIdPrivateDataMap'] = $request->unionIdPrivateDataMap;
        }
        if (!Utils::isUnset($request->unoinId)) {
            $body['unoinId'] = $request->unoinId;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->userIdPrivateDataMap)) {
            $body['userIdPrivateDataMap'] = $request->userIdPrivateDataMap;
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
            'action'      => 'CreateTopbox',
            'version'     => 'im_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/im/topBoxes',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateTopboxResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建并开启互动卡片吊顶
     *  *
     * @param CreateTopboxRequest $request CreateTopboxRequest
     *
     * @return CreateTopboxResponse CreateTopboxResponse
     */
    public function createTopbox($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateTopboxHeaders([]);

        return $this->createTopboxWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 群设备市场管理
     *  *
     * @param string[]       $headers map
     * @param RuntimeOptions $runtime runtime options for this request RuntimeOptions
     *
     * @return GroupManagerDeviceMarketResponse GroupManagerDeviceMarketResponse
     */
    public function groupManagerDeviceMarketWithOptions($headers, $runtime)
    {
        $req = new OpenApiRequest([
            'headers' => $headers,
        ]);
        $params = new Params([
            'action'      => 'GroupManagerDeviceMarket',
            'version'     => 'im_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/im/group/device/market/manager',
            'method'      => 'GET',
            'authType'    => 'Anonymous',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GroupManagerDeviceMarketResponse::fromMap($this->doROARequestWithForm($params->action, $params->version, $params->protocol, $params->method, $params->authType, $params->pathname, $params->bodyType, $req, $runtime));
    }

    /**
     * @summary 群设备市场管理
     *  *
     * @return GroupManagerDeviceMarketResponse GroupManagerDeviceMarketResponse
     */
    public function groupManagerDeviceMarket()
    {
        $runtime = new RuntimeOptions([]);
        $headers = [];

        return $this->groupManagerDeviceMarketWithOptions($headers, $runtime);
    }
}
