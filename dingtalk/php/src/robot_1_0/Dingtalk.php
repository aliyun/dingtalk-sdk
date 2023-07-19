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
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\BatchRecallPrivateChatHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\BatchRecallPrivateChatRequest;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\BatchRecallPrivateChatResponse;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\BatchSendOTOHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\BatchSendOTORequest;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\BatchSendOTOResponse;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\ClearRobotPluginHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\ClearRobotPluginRequest;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\ClearRobotPluginResponse;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\ExecuteRobotAiSkillHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\ExecuteRobotAiSkillRequest;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\ExecuteRobotAiSkillResponse;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\GetBotListInGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\GetBotListInGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\GetBotListInGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\ManageSingleChatRobotStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\ManageSingleChatRobotStatusRequest;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\ManageSingleChatRobotStatusResponse;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\OrgGroupQueryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\OrgGroupQueryRequest;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\OrgGroupQueryResponse;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\OrgGroupRecallHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\OrgGroupRecallRequest;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\OrgGroupRecallResponse;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\OrgGroupSendHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\OrgGroupSendRequest;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\OrgGroupSendResponse;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\PrivateChatQueryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\PrivateChatQueryRequest;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\PrivateChatQueryResponse;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\PrivateChatSendHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\PrivateChatSendRequest;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\PrivateChatSendResponse;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\QueryBotInstanceInGroupInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\QueryBotInstanceInGroupInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\QueryBotInstanceInGroupInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\QueryRobotPluginHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\QueryRobotPluginRequest;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\QueryRobotPluginResponse;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\RobotMessageFileDownloadHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\RobotMessageFileDownloadRequest;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\RobotMessageFileDownloadResponse;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\RobotRecallDingHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\RobotRecallDingRequest;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\RobotRecallDingResponse;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\RobotSendDingHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\RobotSendDingRequest;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\RobotSendDingResponse;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\SendRobotDingMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\SendRobotDingMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\SendRobotDingMessageResponse;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\SetRobotPluginHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\SetRobotPluginRequest;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\SetRobotPluginResponse;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\UpdateInstalledRobotHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\UpdateInstalledRobotRequest;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\UpdateInstalledRobotResponse;
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
            $query['processQueryKey'] = $request->processQueryKey;
        }
        if (!Utils::isUnset($request->robotCode)) {
            $query['robotCode'] = $request->robotCode;
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
            'action'      => 'BatchOTOQuery',
            'version'     => 'robot_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/robot/oToMessages/readStatus',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BatchOTOQueryResponse::fromMap($this->execute($params, $req, $runtime));
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
            $body['chatbotId'] = $request->chatbotId;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->processQueryKeys)) {
            $body['processQueryKeys'] = $request->processQueryKeys;
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
            'action'      => 'BatchRecallGroup',
            'version'     => 'robot_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/robot/groupMessages/batchRecall',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BatchRecallGroupResponse::fromMap($this->execute($params, $req, $runtime));
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
            $body['processQueryKeys'] = $request->processQueryKeys;
        }
        if (!Utils::isUnset($request->robotCode)) {
            $body['robotCode'] = $request->robotCode;
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
            'action'      => 'BatchRecallOTO',
            'version'     => 'robot_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/robot/otoMessages/batchRecall',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BatchRecallOTOResponse::fromMap($this->execute($params, $req, $runtime));
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
     * @param BatchRecallPrivateChatRequest $request
     * @param BatchRecallPrivateChatHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return BatchRecallPrivateChatResponse
     */
    public function batchRecallPrivateChatWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->processQueryKeys)) {
            $body['processQueryKeys'] = $request->processQueryKeys;
        }
        if (!Utils::isUnset($request->robotCode)) {
            $body['robotCode'] = $request->robotCode;
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
            'action'      => 'BatchRecallPrivateChat',
            'version'     => 'robot_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/robot/privateChatMessages/batchRecall',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BatchRecallPrivateChatResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param BatchRecallPrivateChatRequest $request
     *
     * @return BatchRecallPrivateChatResponse
     */
    public function batchRecallPrivateChat($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchRecallPrivateChatHeaders([]);

        return $this->batchRecallPrivateChatWithOptions($request, $headers, $runtime);
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
            $body['msgKey'] = $request->msgKey;
        }
        if (!Utils::isUnset($request->msgParam)) {
            $body['msgParam'] = $request->msgParam;
        }
        if (!Utils::isUnset($request->robotCode)) {
            $body['robotCode'] = $request->robotCode;
        }
        if (!Utils::isUnset($request->userIds)) {
            $body['userIds'] = $request->userIds;
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
            'action'      => 'BatchSendOTO',
            'version'     => 'robot_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/robot/oToMessages/batchSend',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BatchSendOTOResponse::fromMap($this->execute($params, $req, $runtime));
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
     * @param ClearRobotPluginRequest $request
     * @param ClearRobotPluginHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return ClearRobotPluginResponse
     */
    public function clearRobotPluginWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->robotCode)) {
            $body['robotCode'] = $request->robotCode;
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
            'action'      => 'ClearRobotPlugin',
            'version'     => 'robot_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/robot/plugins/clear',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ClearRobotPluginResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ClearRobotPluginRequest $request
     *
     * @return ClearRobotPluginResponse
     */
    public function clearRobotPlugin($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ClearRobotPluginHeaders([]);

        return $this->clearRobotPluginWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ExecuteRobotAiSkillRequest $request
     * @param ExecuteRobotAiSkillHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return ExecuteRobotAiSkillResponse
     */
    public function executeRobotAiSkillWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->context)) {
            $body['context'] = $request->context;
        }
        if (!Utils::isUnset($request->input)) {
            $body['input'] = $request->input;
        }
        if (!Utils::isUnset($request->robotCode)) {
            $body['robotCode'] = $request->robotCode;
        }
        if (!Utils::isUnset($request->skillId)) {
            $body['skillId'] = $request->skillId;
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
            'action'      => 'ExecuteRobotAiSkill',
            'version'     => 'robot_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/robot/aiSkill/execute',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ExecuteRobotAiSkillResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ExecuteRobotAiSkillRequest $request
     *
     * @return ExecuteRobotAiSkillResponse
     */
    public function executeRobotAiSkill($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ExecuteRobotAiSkillHeaders([]);

        return $this->executeRobotAiSkillWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetBotListInGroupRequest $request
     * @param GetBotListInGroupHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return GetBotListInGroupResponse
     */
    public function getBotListInGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
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
            'action'      => 'GetBotListInGroup',
            'version'     => 'robot_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/robot/groups/robots/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetBotListInGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetBotListInGroupRequest $request
     *
     * @return GetBotListInGroupResponse
     */
    public function getBotListInGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetBotListInGroupHeaders([]);

        return $this->getBotListInGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ManageSingleChatRobotStatusRequest $request
     * @param ManageSingleChatRobotStatusHeaders $headers
     * @param RuntimeOptions                     $runtime
     *
     * @return ManageSingleChatRobotStatusResponse
     */
    public function manageSingleChatRobotStatusWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->robotCode)) {
            $body['robotCode'] = $request->robotCode;
        }
        if (!Utils::isUnset($request->status)) {
            $body['status'] = $request->status;
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
            'action'      => 'ManageSingleChatRobotStatus',
            'version'     => 'robot_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/robot/statuses/manage',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ManageSingleChatRobotStatusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ManageSingleChatRobotStatusRequest $request
     *
     * @return ManageSingleChatRobotStatusResponse
     */
    public function manageSingleChatRobotStatus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ManageSingleChatRobotStatusHeaders([]);

        return $this->manageSingleChatRobotStatusWithOptions($request, $headers, $runtime);
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
            $body['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $body['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->processQueryKey)) {
            $body['processQueryKey'] = $request->processQueryKey;
        }
        if (!Utils::isUnset($request->robotCode)) {
            $body['robotCode'] = $request->robotCode;
        }
        if (!Utils::isUnset($request->token)) {
            $body['token'] = $request->token;
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
            'action'      => 'OrgGroupQuery',
            'version'     => 'robot_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/robot/groupMessages/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return OrgGroupQueryResponse::fromMap($this->execute($params, $req, $runtime));
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
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->processQueryKeys)) {
            $body['processQueryKeys'] = $request->processQueryKeys;
        }
        if (!Utils::isUnset($request->robotCode)) {
            $body['robotCode'] = $request->robotCode;
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
            'action'      => 'OrgGroupRecall',
            'version'     => 'robot_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/robot/groupMessages/recall',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return OrgGroupRecallResponse::fromMap($this->execute($params, $req, $runtime));
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
            $body['coolAppCode'] = $request->coolAppCode;
        }
        if (!Utils::isUnset($request->msgKey)) {
            $body['msgKey'] = $request->msgKey;
        }
        if (!Utils::isUnset($request->msgParam)) {
            $body['msgParam'] = $request->msgParam;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->robotCode)) {
            $body['robotCode'] = $request->robotCode;
        }
        if (!Utils::isUnset($request->token)) {
            $body['token'] = $request->token;
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
            'action'      => 'OrgGroupSend',
            'version'     => 'robot_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/robot/groupMessages/send',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return OrgGroupSendResponse::fromMap($this->execute($params, $req, $runtime));
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
     * @param PrivateChatQueryRequest $request
     * @param PrivateChatQueryHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return PrivateChatQueryResponse
     */
    public function privateChatQueryWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->maxResults)) {
            $body['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $body['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->processQueryKey)) {
            $body['processQueryKey'] = $request->processQueryKey;
        }
        if (!Utils::isUnset($request->robotCode)) {
            $body['robotCode'] = $request->robotCode;
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
            'action'      => 'PrivateChatQuery',
            'version'     => 'robot_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/robot/privateChatMessages/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return PrivateChatQueryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param PrivateChatQueryRequest $request
     *
     * @return PrivateChatQueryResponse
     */
    public function privateChatQuery($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PrivateChatQueryHeaders([]);

        return $this->privateChatQueryWithOptions($request, $headers, $runtime);
    }

    /**
     * @param PrivateChatSendRequest $request
     * @param PrivateChatSendHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return PrivateChatSendResponse
     */
    public function privateChatSendWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->coolAppCode)) {
            $body['coolAppCode'] = $request->coolAppCode;
        }
        if (!Utils::isUnset($request->msgKey)) {
            $body['msgKey'] = $request->msgKey;
        }
        if (!Utils::isUnset($request->msgParam)) {
            $body['msgParam'] = $request->msgParam;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->robotCode)) {
            $body['robotCode'] = $request->robotCode;
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
            'action'      => 'PrivateChatSend',
            'version'     => 'robot_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/robot/privateChatMessages/send',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return PrivateChatSendResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param PrivateChatSendRequest $request
     *
     * @return PrivateChatSendResponse
     */
    public function privateChatSend($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PrivateChatSendHeaders([]);

        return $this->privateChatSendWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryBotInstanceInGroupInfoRequest $request
     * @param QueryBotInstanceInGroupInfoHeaders $headers
     * @param RuntimeOptions                     $runtime
     *
     * @return QueryBotInstanceInGroupInfoResponse
     */
    public function queryBotInstanceInGroupInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->pageNumber)) {
            $body['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->robotCode)) {
            $body['robotCode'] = $request->robotCode;
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
            'action'      => 'QueryBotInstanceInGroupInfo',
            'version'     => 'robot_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/robot/groups/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryBotInstanceInGroupInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryBotInstanceInGroupInfoRequest $request
     *
     * @return QueryBotInstanceInGroupInfoResponse
     */
    public function queryBotInstanceInGroupInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryBotInstanceInGroupInfoHeaders([]);

        return $this->queryBotInstanceInGroupInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryRobotPluginRequest $request
     * @param QueryRobotPluginHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return QueryRobotPluginResponse
     */
    public function queryRobotPluginWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->robotCode)) {
            $body['robotCode'] = $request->robotCode;
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
            'action'      => 'QueryRobotPlugin',
            'version'     => 'robot_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/robot/plugins/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryRobotPluginResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryRobotPluginRequest $request
     *
     * @return QueryRobotPluginResponse
     */
    public function queryRobotPlugin($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryRobotPluginHeaders([]);

        return $this->queryRobotPluginWithOptions($request, $headers, $runtime);
    }

    /**
     * @param RobotMessageFileDownloadRequest $request
     * @param RobotMessageFileDownloadHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return RobotMessageFileDownloadResponse
     */
    public function robotMessageFileDownloadWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->downloadCode)) {
            $body['downloadCode'] = $request->downloadCode;
        }
        if (!Utils::isUnset($request->robotCode)) {
            $body['robotCode'] = $request->robotCode;
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
            'action'      => 'RobotMessageFileDownload',
            'version'     => 'robot_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/robot/messageFiles/download',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return RobotMessageFileDownloadResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param RobotMessageFileDownloadRequest $request
     *
     * @return RobotMessageFileDownloadResponse
     */
    public function robotMessageFileDownload($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RobotMessageFileDownloadHeaders([]);

        return $this->robotMessageFileDownloadWithOptions($request, $headers, $runtime);
    }

    /**
     * @param RobotRecallDingRequest $request
     * @param RobotRecallDingHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return RobotRecallDingResponse
     */
    public function robotRecallDingWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->openDingId)) {
            $body['openDingId'] = $request->openDingId;
        }
        if (!Utils::isUnset($request->robotCode)) {
            $body['robotCode'] = $request->robotCode;
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
            'action'      => 'RobotRecallDing',
            'version'     => 'robot_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/robot/ding/recall',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return RobotRecallDingResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param RobotRecallDingRequest $request
     *
     * @return RobotRecallDingResponse
     */
    public function robotRecallDing($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RobotRecallDingHeaders([]);

        return $this->robotRecallDingWithOptions($request, $headers, $runtime);
    }

    /**
     * @param RobotSendDingRequest $request
     * @param RobotSendDingHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return RobotSendDingResponse
     */
    public function robotSendDingWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->content)) {
            $body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->receiverUserIdList)) {
            $body['receiverUserIdList'] = $request->receiverUserIdList;
        }
        if (!Utils::isUnset($request->remindType)) {
            $body['remindType'] = $request->remindType;
        }
        if (!Utils::isUnset($request->robotCode)) {
            $body['robotCode'] = $request->robotCode;
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
            'action'      => 'RobotSendDing',
            'version'     => 'robot_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/robot/ding/send',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return RobotSendDingResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param RobotSendDingRequest $request
     *
     * @return RobotSendDingResponse
     */
    public function robotSendDing($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RobotSendDingHeaders([]);

        return $this->robotSendDingWithOptions($request, $headers, $runtime);
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
            $body['contentParams'] = $request->contentParams;
        }
        if (!Utils::isUnset($request->dingTemplateId)) {
            $body['dingTemplateId'] = $request->dingTemplateId;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->receiverUserIdList)) {
            $body['receiverUserIdList'] = $request->receiverUserIdList;
        }
        if (!Utils::isUnset($request->robotCode)) {
            $body['robotCode'] = $request->robotCode;
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
            'action'      => 'SendRobotDingMessage',
            'version'     => 'robot_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/robot/dingMessages/send',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return SendRobotDingMessageResponse::fromMap($this->execute($params, $req, $runtime));
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
     * @param SetRobotPluginRequest $request
     * @param SetRobotPluginHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return SetRobotPluginResponse
     */
    public function setRobotPluginWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->pluginInfoList)) {
            $body['pluginInfoList'] = $request->pluginInfoList;
        }
        if (!Utils::isUnset($request->robotCode)) {
            $body['robotCode'] = $request->robotCode;
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
            'action'      => 'SetRobotPlugin',
            'version'     => 'robot_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/robot/plugins/set',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SetRobotPluginResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SetRobotPluginRequest $request
     *
     * @return SetRobotPluginResponse
     */
    public function setRobotPlugin($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SetRobotPluginHeaders([]);

        return $this->setRobotPluginWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateInstalledRobotRequest $request
     * @param UpdateInstalledRobotHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return UpdateInstalledRobotResponse
     */
    public function updateInstalledRobotWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->brief)) {
            $body['brief'] = $request->brief;
        }
        if (!Utils::isUnset($request->description)) {
            $body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->icon)) {
            $body['icon'] = $request->icon;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->robotCode)) {
            $body['robotCode'] = $request->robotCode;
        }
        if (!Utils::isUnset($request->updateType)) {
            $body['updateType'] = $request->updateType;
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
            'action'      => 'UpdateInstalledRobot',
            'version'     => 'robot_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/robot/managements/infos',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateInstalledRobotResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param UpdateInstalledRobotRequest $request
     *
     * @return UpdateInstalledRobotResponse
     */
    public function updateInstalledRobot($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateInstalledRobotHeaders([]);

        return $this->updateInstalledRobotWithOptions($request, $headers, $runtime);
    }
}
