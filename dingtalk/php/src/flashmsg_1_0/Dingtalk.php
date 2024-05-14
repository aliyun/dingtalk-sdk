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
     * @summary 添加插件规则
     *  *
     * @param AddPluginRuleRequest $request AddPluginRuleRequest
     * @param AddPluginRuleHeaders $headers AddPluginRuleHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return AddPluginRuleResponse AddPluginRuleResponse
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
     * @summary 添加插件规则
     *  *
     * @param AddPluginRuleRequest $request AddPluginRuleRequest
     *
     * @return AddPluginRuleResponse AddPluginRuleResponse
     */
    public function addPluginRule($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddPluginRuleHeaders([]);

        return $this->addPluginRuleWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除插件规则
     *  *
     * @param DeletePlguinRuleRequest $request DeletePlguinRuleRequest
     * @param DeletePlguinRuleHeaders $headers DeletePlguinRuleHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return DeletePlguinRuleResponse DeletePlguinRuleResponse
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
     * @summary 删除插件规则
     *  *
     * @param DeletePlguinRuleRequest $request DeletePlguinRuleRequest
     *
     * @return DeletePlguinRuleResponse DeletePlguinRuleResponse
     */
    public function deletePlguinRule($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeletePlguinRuleHeaders([]);

        return $this->deletePlguinRuleWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 闪读用户基础信息查询
     *  *
     * @param GetBaseProfileListRequest $request GetBaseProfileListRequest
     * @param GetBaseProfileListHeaders $headers GetBaseProfileListHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return GetBaseProfileListResponse GetBaseProfileListResponse
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
     * @summary 闪读用户基础信息查询
     *  *
     * @param GetBaseProfileListRequest $request GetBaseProfileListRequest
     *
     * @return GetBaseProfileListResponse GetBaseProfileListResponse
     */
    public function getBaseProfileList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetBaseProfileListHeaders([]);

        return $this->getBaseProfileListWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获得闪读会话信息
     *  *
     * @param GetConversationRequest $request GetConversationRequest
     * @param GetConversationHeaders $headers GetConversationHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return GetConversationResponse GetConversationResponse
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
     * @summary 获得闪读会话信息
     *  *
     * @param GetConversationRequest $request GetConversationRequest
     *
     * @return GetConversationResponse GetConversationResponse
     */
    public function getConversation($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetConversationHeaders([]);

        return $this->getConversationWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获得成员ID列表
     *  *
     * @param GetMemberListRequest $request GetMemberListRequest
     * @param GetMemberListHeaders $headers GetMemberListHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return GetMemberListResponse GetMemberListResponse
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
     * @summary 获得成员ID列表
     *  *
     * @param GetMemberListRequest $request GetMemberListRequest
     *
     * @return GetMemberListResponse GetMemberListResponse
     */
    public function getMemberList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetMemberListHeaders([]);

        return $this->getMemberListWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询插件规则
     *  *
     * @param QueryPluginRuleRequest $request QueryPluginRuleRequest
     * @param QueryPluginRuleHeaders $headers QueryPluginRuleHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryPluginRuleResponse QueryPluginRuleResponse
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
     * @summary 查询插件规则
     *  *
     * @param QueryPluginRuleRequest $request QueryPluginRuleRequest
     *
     * @return QueryPluginRuleResponse QueryPluginRuleResponse
     */
    public function queryPluginRule($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryPluginRuleHeaders([]);

        return $this->queryPluginRuleWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 发送Ding提示消息
     *  *
     * @param SendDingTipRequest $request SendDingTipRequest
     * @param SendDingTipHeaders $headers SendDingTipHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return SendDingTipResponse SendDingTipResponse
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
     * @summary 发送Ding提示消息
     *  *
     * @param SendDingTipRequest $request SendDingTipRequest
     *
     * @return SendDingTipResponse SendDingTipResponse
     */
    public function sendDingTip($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendDingTipHeaders([]);

        return $this->sendDingTipWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 发送闪读消息提示
     *  *
     * @param SendMessageTipRequest $request SendMessageTipRequest
     * @param SendMessageTipHeaders $headers SendMessageTipHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return SendMessageTipResponse SendMessageTipResponse
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
     * @summary 发送闪读消息提示
     *  *
     * @param SendMessageTipRequest $request SendMessageTipRequest
     *
     * @return SendMessageTipResponse SendMessageTipResponse
     */
    public function sendMessageTip($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendMessageTipHeaders([]);

        return $this->sendMessageTipWithOptions($request, $headers, $runtime);
    }
}
