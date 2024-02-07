<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vflashmsg_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vflashmsg_1_0\Models\AddPluginRuleHeaders;
use AlibabaCloud\SDK\Dingtalk\Vflashmsg_1_0\Models\AddPluginRuleRequest;
use AlibabaCloud\SDK\Dingtalk\Vflashmsg_1_0\Models\AddPluginRuleResponse;
use AlibabaCloud\SDK\Dingtalk\Vflashmsg_1_0\Models\DeletePlguinRuleHeaders;
use AlibabaCloud\SDK\Dingtalk\Vflashmsg_1_0\Models\DeletePlguinRuleRequest;
use AlibabaCloud\SDK\Dingtalk\Vflashmsg_1_0\Models\DeletePlguinRuleResponse;
use AlibabaCloud\SDK\Dingtalk\Vflashmsg_1_0\Models\GetBaseProfileListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vflashmsg_1_0\Models\GetBaseProfileListRequest;
use AlibabaCloud\SDK\Dingtalk\Vflashmsg_1_0\Models\GetBaseProfileListResponse;
use AlibabaCloud\SDK\Dingtalk\Vflashmsg_1_0\Models\GetConversationHeaders;
use AlibabaCloud\SDK\Dingtalk\Vflashmsg_1_0\Models\GetConversationRequest;
use AlibabaCloud\SDK\Dingtalk\Vflashmsg_1_0\Models\GetConversationResponse;
use AlibabaCloud\SDK\Dingtalk\Vflashmsg_1_0\Models\GetMemberListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vflashmsg_1_0\Models\GetMemberListRequest;
use AlibabaCloud\SDK\Dingtalk\Vflashmsg_1_0\Models\GetMemberListResponse;
use AlibabaCloud\SDK\Dingtalk\Vflashmsg_1_0\Models\QueryPluginRuleHeaders;
use AlibabaCloud\SDK\Dingtalk\Vflashmsg_1_0\Models\QueryPluginRuleRequest;
use AlibabaCloud\SDK\Dingtalk\Vflashmsg_1_0\Models\QueryPluginRuleResponse;
use AlibabaCloud\SDK\Dingtalk\Vflashmsg_1_0\Models\SendDingTipHeaders;
use AlibabaCloud\SDK\Dingtalk\Vflashmsg_1_0\Models\SendDingTipRequest;
use AlibabaCloud\SDK\Dingtalk\Vflashmsg_1_0\Models\SendDingTipResponse;
use AlibabaCloud\SDK\Dingtalk\Vflashmsg_1_0\Models\SendMessageTipHeaders;
use AlibabaCloud\SDK\Dingtalk\Vflashmsg_1_0\Models\SendMessageTipRequest;
use AlibabaCloud\SDK\Dingtalk\Vflashmsg_1_0\Models\SendMessageTipResponse;
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
     * @param AddPluginRuleRequest $request
     * @param AddPluginRuleHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return AddPluginRuleResponse
     */
    public function addPluginRuleWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->chatType)) {
            $body['chatType'] = $request->chatType;
        }
        if (!Utils::isUnset($request->code)) {
            $body['code'] = $request->code;
        }
        if (!Utils::isUnset($request->itemType)) {
            $body['itemType'] = $request->itemType;
        }
        if (!Utils::isUnset($request->rules)) {
            $body['rules'] = $request->rules;
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
            'action'      => 'AddPluginRule',
            'version'     => 'flashmsg_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/flashmsg/plugins',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AddPluginRuleResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param AddPluginRuleRequest $request
     *
     * @return AddPluginRuleResponse
     */
    public function addPluginRule($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddPluginRuleHeaders([]);

        return $this->addPluginRuleWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DeletePlguinRuleRequest $request
     * @param DeletePlguinRuleHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return DeletePlguinRuleResponse
     */
    public function deletePlguinRuleWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizIdList)) {
            $body['bizIdList'] = $request->bizIdList;
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
            'action'      => 'DeletePlguinRule',
            'version'     => 'flashmsg_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/flashmsg/plugins/remove',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DeletePlguinRuleResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param DeletePlguinRuleRequest $request
     *
     * @return DeletePlguinRuleResponse
     */
    public function deletePlguinRule($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeletePlguinRuleHeaders([]);

        return $this->deletePlguinRuleWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetBaseProfileListRequest $request
     * @param GetBaseProfileListHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return GetBaseProfileListResponse
     */
    public function getBaseProfileListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => $request->body,
        ]);
        $params = new Params([
            'action'      => 'GetBaseProfileList',
            'version'     => 'flashmsg_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/flashmsg/users/baseInfos/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetBaseProfileListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetBaseProfileListRequest $request
     *
     * @return GetBaseProfileListResponse
     */
    public function getBaseProfileList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetBaseProfileListHeaders([]);

        return $this->getBaseProfileListWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetConversationRequest $request
     * @param GetConversationHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return GetConversationResponse
     */
    public function getConversationWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->openConversationId)) {
            $query['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->userId)) {
            $query['userId'] = $request->userId;
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
            'action'      => 'GetConversation',
            'version'     => 'flashmsg_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/flashmsg/conversations/infos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetConversationResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetConversationRequest $request
     *
     * @return GetConversationResponse
     */
    public function getConversation($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetConversationHeaders([]);

        return $this->getConversationWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetMemberListRequest $request
     * @param GetMemberListHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return GetMemberListResponse
     */
    public function getMemberListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->openConversationId)) {
            $query['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->userId)) {
            $query['userId'] = $request->userId;
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
            'action'      => 'GetMemberList',
            'version'     => 'flashmsg_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/flashmsg/conversations/memberIdLists',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetMemberListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetMemberListRequest $request
     *
     * @return GetMemberListResponse
     */
    public function getMemberList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetMemberListHeaders([]);

        return $this->getMemberListWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryPluginRuleRequest $request
     * @param QueryPluginRuleHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return QueryPluginRuleResponse
     */
    public function queryPluginRuleWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->chatType)) {
            $query['chatType'] = $request->chatType;
        }
        if (!Utils::isUnset($request->code)) {
            $query['code'] = $request->code;
        }
        if (!Utils::isUnset($request->itemId)) {
            $query['itemId'] = $request->itemId;
        }
        if (!Utils::isUnset($request->itemType)) {
            $query['itemType'] = $request->itemType;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
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
            'action'      => 'QueryPluginRule',
            'version'     => 'flashmsg_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/flashmsg/plugins',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryPluginRuleResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryPluginRuleRequest $request
     *
     * @return QueryPluginRuleResponse
     */
    public function queryPluginRule($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryPluginRuleHeaders([]);

        return $this->queryPluginRuleWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SendDingTipRequest $request
     * @param SendDingTipHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return SendDingTipResponse
     */
    public function sendDingTipWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->extension)) {
            $body['extension'] = $request->extension;
        }
        if (!Utils::isUnset($request->link)) {
            $body['link'] = $request->link;
        }
        if (!Utils::isUnset($request->messageId)) {
            $body['messageId'] = $request->messageId;
        }
        if (!Utils::isUnset($request->receiverUserId)) {
            $body['receiverUserId'] = $request->receiverUserId;
        }
        if (!Utils::isUnset($request->senderUserId)) {
            $body['senderUserId'] = $request->senderUserId;
        }
        if (!Utils::isUnset($request->textContent)) {
            $body['textContent'] = $request->textContent;
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
            'action'      => 'SendDingTip',
            'version'     => 'flashmsg_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/flashmsg/ding/messages/send',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SendDingTipResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SendDingTipRequest $request
     *
     * @return SendDingTipResponse
     */
    public function sendDingTip($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendDingTipHeaders([]);

        return $this->sendDingTipWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SendMessageTipRequest $request
     * @param SendMessageTipHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return SendMessageTipResponse
     */
    public function sendMessageTipWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->defaultView)) {
            $body['defaultView'] = $request->defaultView;
        }
        if (!Utils::isUnset($request->messageId)) {
            $body['messageId'] = $request->messageId;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->privateFieldMap)) {
            $body['privateFieldMap'] = $request->privateFieldMap;
        }
        if (!Utils::isUnset($request->publicField)) {
            $body['publicField'] = $request->publicField;
        }
        if (!Utils::isUnset($request->receiverUserId)) {
            $body['receiverUserId'] = $request->receiverUserId;
        }
        if (!Utils::isUnset($request->senderUserId)) {
            $body['senderUserId'] = $request->senderUserId;
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
            'action'      => 'SendMessageTip',
            'version'     => 'flashmsg_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/flashmsg/messages/send',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SendMessageTipResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SendMessageTipRequest $request
     *
     * @return SendMessageTipResponse
     */
    public function sendMessageTip($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendMessageTipHeaders([]);

        return $this->sendMessageTipWithOptions($request, $headers, $runtime);
    }
}
