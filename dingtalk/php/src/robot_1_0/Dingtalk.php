<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrobot_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\BatchOTOQueryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\BatchOTOQueryRequest;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\BatchOTOQueryResponse;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\BatchRecallGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\BatchRecallGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\BatchRecallGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\BatchRecallOTOHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\BatchRecallOTORequest;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\BatchRecallOTOResponse;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\BatchSendOTOHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\BatchSendOTORequest;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\BatchSendOTOResponse;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\OrgGroupQueryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\OrgGroupQueryRequest;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\OrgGroupQueryResponse;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\OrgGroupRecallHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\OrgGroupRecallRequest;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\OrgGroupRecallResponse;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\OrgGroupSendHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\OrgGroupSendRequest;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\OrgGroupSendResponse;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\SendRobotDingMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\SendRobotDingMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\SendRobotDingMessageResponse;
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
     * @param BatchOTOQueryRequest $request
     *
     * @return BatchOTOQueryResponse
     */
    public function batchOTOQuery($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchOTOQueryHeaders([]);

        return $this->batchOTOQueryWithOptions($request, $headers, $runtime);
    }

    /**
     * @param BatchOTOQueryRequest $request
     * @param BatchOTOQueryHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return BatchOTOQueryResponse
     */
    public function batchOTOQueryWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->processQueryKey)) {
            @$query['processQueryKey'] = $request->processQueryKey;
        }
        if (!Utils::isUnset($request->robotCode)) {
            @$query['robotCode'] = $request->robotCode;
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
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return BatchOTOQueryResponse::fromMap($this->doROARequest('BatchOTOQuery', 'robot_1.0', 'HTTP', 'GET', 'AK', '/v1.0/robot/oToMessages/readStatus', 'json', $req, $runtime));
    }

    /**
     * @param BatchRecallGroupRequest $request
     *
     * @return BatchRecallGroupResponse
     */
    public function batchRecallGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchRecallGroupHeaders([]);

        return $this->batchRecallGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @param BatchRecallGroupRequest $request
     * @param BatchRecallGroupHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return BatchRecallGroupResponse
     */
    public function batchRecallGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->chatbotId)) {
            @$body['chatbotId'] = $request->chatbotId;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            @$body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->processQueryKeys)) {
            @$body['processQueryKeys'] = $request->processQueryKeys;
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

        return BatchRecallGroupResponse::fromMap($this->doROARequest('BatchRecallGroup', 'robot_1.0', 'HTTP', 'POST', 'AK', '/v1.0/robot/groupMessages/batchRecall', 'json', $req, $runtime));
    }

    /**
     * @param BatchRecallOTORequest $request
     *
     * @return BatchRecallOTOResponse
     */
    public function batchRecallOTO($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchRecallOTOHeaders([]);

        return $this->batchRecallOTOWithOptions($request, $headers, $runtime);
    }

    /**
     * @param BatchRecallOTORequest $request
     * @param BatchRecallOTOHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return BatchRecallOTOResponse
     */
    public function batchRecallOTOWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->processQueryKeys)) {
            @$body['processQueryKeys'] = $request->processQueryKeys;
        }
        if (!Utils::isUnset($request->robotCode)) {
            @$body['robotCode'] = $request->robotCode;
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

        return BatchRecallOTOResponse::fromMap($this->doROARequest('BatchRecallOTO', 'robot_1.0', 'HTTP', 'POST', 'AK', '/v1.0/robot/otoMessages/batchRecall', 'json', $req, $runtime));
    }

    /**
     * @param BatchSendOTORequest $request
     *
     * @return BatchSendOTOResponse
     */
    public function batchSendOTO($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchSendOTOHeaders([]);

        return $this->batchSendOTOWithOptions($request, $headers, $runtime);
    }

    /**
     * @param BatchSendOTORequest $request
     * @param BatchSendOTOHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return BatchSendOTOResponse
     */
    public function batchSendOTOWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->msgKey)) {
            @$body['msgKey'] = $request->msgKey;
        }
        if (!Utils::isUnset($request->msgParam)) {
            @$body['msgParam'] = $request->msgParam;
        }
        if (!Utils::isUnset($request->robotCode)) {
            @$body['robotCode'] = $request->robotCode;
        }
        if (!Utils::isUnset($request->userIds)) {
            @$body['userIds'] = $request->userIds;
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

        return BatchSendOTOResponse::fromMap($this->doROARequest('BatchSendOTO', 'robot_1.0', 'HTTP', 'POST', 'AK', '/v1.0/robot/oToMessages/batchSend', 'json', $req, $runtime));
    }

    /**
     * @param OrgGroupQueryRequest $request
     *
     * @return OrgGroupQueryResponse
     */
    public function orgGroupQuery($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new OrgGroupQueryHeaders([]);

        return $this->orgGroupQueryWithOptions($request, $headers, $runtime);
    }

    /**
     * @param OrgGroupQueryRequest $request
     * @param OrgGroupQueryHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return OrgGroupQueryResponse
     */
    public function orgGroupQueryWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->maxResults)) {
            @$body['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$body['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            @$body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->processQueryKey)) {
            @$body['processQueryKey'] = $request->processQueryKey;
        }
        if (!Utils::isUnset($request->robotCode)) {
            @$body['robotCode'] = $request->robotCode;
        }
        if (!Utils::isUnset($request->token)) {
            @$body['token'] = $request->token;
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

        return OrgGroupQueryResponse::fromMap($this->doROARequest('OrgGroupQuery', 'robot_1.0', 'HTTP', 'POST', 'AK', '/v1.0/robot/groupMessages/query', 'json', $req, $runtime));
    }

    /**
     * @param OrgGroupRecallRequest $request
     *
     * @return OrgGroupRecallResponse
     */
    public function orgGroupRecall($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new OrgGroupRecallHeaders([]);

        return $this->orgGroupRecallWithOptions($request, $headers, $runtime);
    }

    /**
     * @param OrgGroupRecallRequest $request
     * @param OrgGroupRecallHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return OrgGroupRecallResponse
     */
    public function orgGroupRecallWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->openConversationId)) {
            @$body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->processQueryKeys)) {
            @$body['processQueryKeys'] = $request->processQueryKeys;
        }
        if (!Utils::isUnset($request->robotCode)) {
            @$body['robotCode'] = $request->robotCode;
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

        return OrgGroupRecallResponse::fromMap($this->doROARequest('OrgGroupRecall', 'robot_1.0', 'HTTP', 'POST', 'AK', '/v1.0/robot/groupMessages/recall', 'json', $req, $runtime));
    }

    /**
     * @param OrgGroupSendRequest $request
     *
     * @return OrgGroupSendResponse
     */
    public function orgGroupSend($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new OrgGroupSendHeaders([]);

        return $this->orgGroupSendWithOptions($request, $headers, $runtime);
    }

    /**
     * @param OrgGroupSendRequest $request
     * @param OrgGroupSendHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return OrgGroupSendResponse
     */
    public function orgGroupSendWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->coolAppCode)) {
            @$body['coolAppCode'] = $request->coolAppCode;
        }
        if (!Utils::isUnset($request->msgKey)) {
            @$body['msgKey'] = $request->msgKey;
        }
        if (!Utils::isUnset($request->msgParam)) {
            @$body['msgParam'] = $request->msgParam;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            @$body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->robotCode)) {
            @$body['robotCode'] = $request->robotCode;
        }
        if (!Utils::isUnset($request->token)) {
            @$body['token'] = $request->token;
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

        return OrgGroupSendResponse::fromMap($this->doROARequest('OrgGroupSend', 'robot_1.0', 'HTTP', 'POST', 'AK', '/v1.0/robot/groupMessages/send', 'json', $req, $runtime));
    }

    /**
     * @param SendRobotDingMessageRequest $request
     *
     * @return SendRobotDingMessageResponse
     */
    public function sendRobotDingMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendRobotDingMessageHeaders([]);

        return $this->sendRobotDingMessageWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SendRobotDingMessageRequest $request
     * @param SendRobotDingMessageHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return SendRobotDingMessageResponse
     */
    public function sendRobotDingMessageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->contentParams)) {
            @$body['contentParams'] = $request->contentParams;
        }
        if (!Utils::isUnset($request->dingTemplateId)) {
            @$body['dingTemplateId'] = $request->dingTemplateId;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            @$body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->receiverUserIdList)) {
            @$body['receiverUserIdList'] = $request->receiverUserIdList;
        }
        if (!Utils::isUnset($request->robotCode)) {
            @$body['robotCode'] = $request->robotCode;
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

        return SendRobotDingMessageResponse::fromMap($this->doROARequest('SendRobotDingMessage', 'robot_1.0', 'HTTP', 'POST', 'AK', '/v1.0/robot/dingMessages/send', 'json', $req, $runtime));
    }
}
