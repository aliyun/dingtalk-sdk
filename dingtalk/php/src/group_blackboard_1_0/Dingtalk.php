<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vgroup_blackboard_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vgroup_blackboard_1_0\Models\CreateGroupBlackboardHeaders;
use AlibabaCloud\SDK\Dingtalk\Vgroup_blackboard_1_0\Models\CreateGroupBlackboardRequest;
use AlibabaCloud\SDK\Dingtalk\Vgroup_blackboard_1_0\Models\CreateGroupBlackboardResponse;
use AlibabaCloud\SDK\Dingtalk\Vgroup_blackboard_1_0\Models\DeleteGroupBlackboardHeaders;
use AlibabaCloud\SDK\Dingtalk\Vgroup_blackboard_1_0\Models\DeleteGroupBlackboardRequest;
use AlibabaCloud\SDK\Dingtalk\Vgroup_blackboard_1_0\Models\DeleteGroupBlackboardResponse;
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
        $gatewayClient       = new Client();
        $this->_spi          = $gatewayClient;
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @summary 创建群公告
     *  *
     * @param CreateGroupBlackboardRequest $request CreateGroupBlackboardRequest
     * @param CreateGroupBlackboardHeaders $headers CreateGroupBlackboardHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateGroupBlackboardResponse CreateGroupBlackboardResponse
     */
    public function createGroupBlackboardWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->content)) {
            $body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->sendDing)) {
            $body['sendDing'] = $request->sendDing;
        }
        if (!Utils::isUnset($request->sticky)) {
            $body['sticky'] = $request->sticky;
        }
        if (!Utils::isUnset($request->uniqueId)) {
            $body['uniqueId'] = $request->uniqueId;
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
            'action'      => 'CreateGroupBlackboard',
            'version'     => 'groupBlackboard_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/groupBlackboard/blackboards',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateGroupBlackboardResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建群公告
     *  *
     * @param CreateGroupBlackboardRequest $request CreateGroupBlackboardRequest
     *
     * @return CreateGroupBlackboardResponse CreateGroupBlackboardResponse
     */
    public function createGroupBlackboard($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateGroupBlackboardHeaders([]);

        return $this->createGroupBlackboardWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除群公告
     *  *
     * @param DeleteGroupBlackboardRequest $request DeleteGroupBlackboardRequest
     * @param DeleteGroupBlackboardHeaders $headers DeleteGroupBlackboardHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteGroupBlackboardResponse DeleteGroupBlackboardResponse
     */
    public function deleteGroupBlackboardWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->dataId)) {
            $body['dataId'] = $request->dataId;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
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
            'action'      => 'DeleteGroupBlackboard',
            'version'     => 'groupBlackboard_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/groupBlackboard/blackboards/remove',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DeleteGroupBlackboardResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除群公告
     *  *
     * @param DeleteGroupBlackboardRequest $request DeleteGroupBlackboardRequest
     *
     * @return DeleteGroupBlackboardResponse DeleteGroupBlackboardResponse
     */
    public function deleteGroupBlackboard($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteGroupBlackboardHeaders([]);

        return $this->deleteGroupBlackboardWithOptions($request, $headers, $runtime);
    }
}
