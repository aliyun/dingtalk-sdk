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
     * @param CreateGroupBlackboardRequest $request
     *
     * @return CreateGroupBlackboardResponse
     */
    public function createGroupBlackboard($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateGroupBlackboardHeaders([]);

        return $this->createGroupBlackboardWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateGroupBlackboardRequest $request
     * @param CreateGroupBlackboardHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return CreateGroupBlackboardResponse
     */
    public function createGroupBlackboardWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->content)) {
            @$body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            @$body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->sendDing)) {
            @$body['sendDing'] = $request->sendDing;
        }
        if (!Utils::isUnset($request->sticky)) {
            @$body['sticky'] = $request->sticky;
        }
        if (!Utils::isUnset($request->uniqueId)) {
            @$body['uniqueId'] = $request->uniqueId;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return CreateGroupBlackboardResponse::fromMap($this->doROARequest('CreateGroupBlackboard', 'groupBlackboard_1.0', 'HTTP', 'POST', 'AK', '/v1.0/groupBlackboard/blackboards', 'json', $req, $runtime));
    }

    /**
     * @param DeleteGroupBlackboardRequest $request
     *
     * @return DeleteGroupBlackboardResponse
     */
    public function deleteGroupBlackboard($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteGroupBlackboardHeaders([]);

        return $this->deleteGroupBlackboardWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DeleteGroupBlackboardRequest $request
     * @param DeleteGroupBlackboardHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return DeleteGroupBlackboardResponse
     */
    public function deleteGroupBlackboardWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->dataId)) {
            @$body['dataId'] = $request->dataId;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            @$body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return DeleteGroupBlackboardResponse::fromMap($this->doROARequest('DeleteGroupBlackboard', 'groupBlackboard_1.0', 'HTTP', 'POST', 'AK', '/v1.0/groupBlackboard/blackboards/remove', 'json', $req, $runtime));
    }
}
