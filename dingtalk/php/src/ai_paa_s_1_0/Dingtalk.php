<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vai_paa_s_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vai_paa_s_1_0\Models\ExecuteAgentHeaders;
use AlibabaCloud\SDK\Dingtalk\Vai_paa_s_1_0\Models\ExecuteAgentRequest;
use AlibabaCloud\SDK\Dingtalk\Vai_paa_s_1_0\Models\ExecuteAgentResponse;
use AlibabaCloud\SDK\Dingtalk\Vai_paa_s_1_0\Models\LiandanluExclusiveModelHeaders;
use AlibabaCloud\SDK\Dingtalk\Vai_paa_s_1_0\Models\LiandanluExclusiveModelRequest;
use AlibabaCloud\SDK\Dingtalk\Vai_paa_s_1_0\Models\LiandanluExclusiveModelResponse;
use AlibabaCloud\SDK\Dingtalk\Vai_paa_s_1_0\Models\LiandanluTextToImageModelHeaders;
use AlibabaCloud\SDK\Dingtalk\Vai_paa_s_1_0\Models\LiandanluTextToImageModelRequest;
use AlibabaCloud\SDK\Dingtalk\Vai_paa_s_1_0\Models\LiandanluTextToImageModelResponse;
use AlibabaCloud\SDK\Dingtalk\Vai_paa_s_1_0\Models\LiandanTextImageGetHeaders;
use AlibabaCloud\SDK\Dingtalk\Vai_paa_s_1_0\Models\LiandanTextImageGetRequest;
use AlibabaCloud\SDK\Dingtalk\Vai_paa_s_1_0\Models\LiandanTextImageGetResponse;
use AlibabaCloud\SDK\Dingtalk\Vai_paa_s_1_0\Models\NLToFrameServiceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vai_paa_s_1_0\Models\NLToFrameServiceRequest;
use AlibabaCloud\SDK\Dingtalk\Vai_paa_s_1_0\Models\NLToFrameServiceResponse;
use AlibabaCloud\SDK\Dingtalk\Vai_paa_s_1_0\Models\QueryBaymaxSkillLogHeaders;
use AlibabaCloud\SDK\Dingtalk\Vai_paa_s_1_0\Models\QueryBaymaxSkillLogRequest;
use AlibabaCloud\SDK\Dingtalk\Vai_paa_s_1_0\Models\QueryBaymaxSkillLogResponse;
use AlibabaCloud\SDK\Dingtalk\Vai_paa_s_1_0\Models\QueryConversationMessageForAIHeaders;
use AlibabaCloud\SDK\Dingtalk\Vai_paa_s_1_0\Models\QueryConversationMessageForAIRequest;
use AlibabaCloud\SDK\Dingtalk\Vai_paa_s_1_0\Models\QueryConversationMessageForAIResponse;
use AlibabaCloud\SDK\Dingtalk\Vai_paa_s_1_0\Models\QueryConversationMessageForAIShrinkRequest;
use AlibabaCloud\SDK\Dingtalk\Vai_paa_s_1_0\Models\QueryMemoryLearningTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vai_paa_s_1_0\Models\QueryMemoryLearningTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vai_paa_s_1_0\Models\QueryMemoryLearningTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vai_paa_s_1_0\Models\SmartQuoteDataServiceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vai_paa_s_1_0\Models\SmartQuoteDataServiceRequest;
use AlibabaCloud\SDK\Dingtalk\Vai_paa_s_1_0\Models\SmartQuoteDataServiceResponse;
use AlibabaCloud\SDK\Dingtalk\Vai_paa_s_1_0\Models\SmartQuoteQueryServiceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vai_paa_s_1_0\Models\SmartQuoteQueryServiceRequest;
use AlibabaCloud\SDK\Dingtalk\Vai_paa_s_1_0\Models\SmartQuoteQueryServiceResponse;
use AlibabaCloud\SDK\Dingtalk\Vai_paa_s_1_0\Models\SubmitMemoryLearningTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vai_paa_s_1_0\Models\SubmitMemoryLearningTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vai_paa_s_1_0\Models\SubmitMemoryLearningTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vai_paa_s_1_0\Models\SubmitMemoryLearningTaskShrinkRequest;
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
     * @summary 执行AI技能
     *  *
     * @param ExecuteAgentRequest $request ExecuteAgentRequest
     * @param ExecuteAgentHeaders $headers ExecuteAgentHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return ExecuteAgentResponse ExecuteAgentResponse
     */
    public function executeAgentWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->agentCode)) {
            $body['agentCode'] = $request->agentCode;
        }
        if (!Utils::isUnset($request->inputs)) {
            $body['inputs'] = $request->inputs;
        }
        if (!Utils::isUnset($request->scenarioCode)) {
            $body['scenarioCode'] = $request->scenarioCode;
        }
        if (!Utils::isUnset($request->scenarioInstanceId)) {
            $body['scenarioInstanceId'] = $request->scenarioInstanceId;
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
            'action'      => 'ExecuteAgent',
            'version'     => 'aiPaaS_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/aiPaaS/me/agents/execute',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ExecuteAgentResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 执行AI技能
     *  *
     * @param ExecuteAgentRequest $request ExecuteAgentRequest
     *
     * @return ExecuteAgentResponse ExecuteAgentResponse
     */
    public function executeAgent($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ExecuteAgentHeaders([]);

        return $this->executeAgentWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 炼丹炉文生图任务结果获取
     *  *
     * @param LiandanTextImageGetRequest $request LiandanTextImageGetRequest
     * @param LiandanTextImageGetHeaders $headers LiandanTextImageGetHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return LiandanTextImageGetResponse LiandanTextImageGetResponse
     */
    public function liandanTextImageGetWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->module)) {
            $body['module'] = $request->module;
        }
        if (!Utils::isUnset($request->taskId)) {
            $body['taskId'] = $request->taskId;
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
            'action'      => 'LiandanTextImageGet',
            'version'     => 'aiPaaS_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/aiPaaS/ai/textToImage/results/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return LiandanTextImageGetResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 炼丹炉文生图任务结果获取
     *  *
     * @param LiandanTextImageGetRequest $request LiandanTextImageGetRequest
     *
     * @return LiandanTextImageGetResponse LiandanTextImageGetResponse
     */
    public function liandanTextImageGet($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new LiandanTextImageGetHeaders([]);

        return $this->liandanTextImageGetWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 炼丹炉专属模型接口
     *  *
     * @param LiandanluExclusiveModelRequest $request LiandanluExclusiveModelRequest
     * @param LiandanluExclusiveModelHeaders $headers LiandanluExclusiveModelHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return LiandanluExclusiveModelResponse LiandanluExclusiveModelResponse
     */
    public function liandanluExclusiveModelWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->modelId)) {
            $body['modelId'] = $request->modelId;
        }
        if (!Utils::isUnset($request->module)) {
            $body['module'] = $request->module;
        }
        if (!Utils::isUnset($request->prompt)) {
            $body['prompt'] = $request->prompt;
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
            'action'      => 'LiandanluExclusiveModel',
            'version'     => 'aiPaaS_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/aiPaaS/ai/generate',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return LiandanluExclusiveModelResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 炼丹炉专属模型接口
     *  *
     * @param LiandanluExclusiveModelRequest $request LiandanluExclusiveModelRequest
     *
     * @return LiandanluExclusiveModelResponse LiandanluExclusiveModelResponse
     */
    public function liandanluExclusiveModel($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new LiandanluExclusiveModelHeaders([]);

        return $this->liandanluExclusiveModelWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 炼丹炉通过提示词生成图片
     *  *
     * @param LiandanluTextToImageModelRequest $request LiandanluTextToImageModelRequest
     * @param LiandanluTextToImageModelHeaders $headers LiandanluTextToImageModelHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return LiandanluTextToImageModelResponse LiandanluTextToImageModelResponse
     */
    public function liandanluTextToImageModelWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->module)) {
            $body['module'] = $request->module;
        }
        if (!Utils::isUnset($request->number)) {
            $body['number'] = $request->number;
        }
        if (!Utils::isUnset($request->parameters)) {
            $body['parameters'] = $request->parameters;
        }
        if (!Utils::isUnset($request->prompt)) {
            $body['prompt'] = $request->prompt;
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
            'action'      => 'LiandanluTextToImageModel',
            'version'     => 'aiPaaS_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/aiPaaS/ai/textToImage/generate',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return LiandanluTextToImageModelResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 炼丹炉通过提示词生成图片
     *  *
     * @param LiandanluTextToImageModelRequest $request LiandanluTextToImageModelRequest
     *
     * @return LiandanluTextToImageModelResponse LiandanluTextToImageModelResponse
     */
    public function liandanluTextToImageModel($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new LiandanluTextToImageModelHeaders([]);

        return $this->liandanluTextToImageModelWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 通过配置的指令，连接用户和系统，训练大模型
     *  *
     * @param NLToFrameServiceRequest $request NLToFrameServiceRequest
     * @param NLToFrameServiceHeaders $headers NLToFrameServiceHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return NLToFrameServiceResponse NLToFrameServiceResponse
     */
    public function nLToFrameServiceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->extensionStr)) {
            $body['extensionStr'] = $request->extensionStr;
        }
        if (!Utils::isUnset($request->isNewModel)) {
            $body['isNewModel'] = $request->isNewModel;
        }
        if (!Utils::isUnset($request->modelId)) {
            $body['modelId'] = $request->modelId;
        }
        if (!Utils::isUnset($request->modelName)) {
            $body['modelName'] = $request->modelName;
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
            'action'      => 'NLToFrameService',
            'version'     => 'aiPaaS_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/aiPaaS/ai/nl2frame',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return NLToFrameServiceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 通过配置的指令，连接用户和系统，训练大模型
     *  *
     * @param NLToFrameServiceRequest $request NLToFrameServiceRequest
     *
     * @return NLToFrameServiceResponse NLToFrameServiceResponse
     */
    public function nLToFrameService($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new NLToFrameServiceHeaders([]);

        return $this->nLToFrameServiceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary Baymax技能执行日志
     *  *
     * @param QueryBaymaxSkillLogRequest $request QueryBaymaxSkillLogRequest
     * @param QueryBaymaxSkillLogHeaders $headers QueryBaymaxSkillLogHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryBaymaxSkillLogResponse QueryBaymaxSkillLogResponse
     */
    public function queryBaymaxSkillLogWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->from)) {
            $query['from'] = $request->from;
        }
        if (!Utils::isUnset($request->logLevel)) {
            $query['logLevel'] = $request->logLevel;
        }
        if (!Utils::isUnset($request->skillExecuteId)) {
            $query['skillExecuteId'] = $request->skillExecuteId;
        }
        if (!Utils::isUnset($request->to)) {
            $query['to'] = $request->to;
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
            'action'      => 'QueryBaymaxSkillLog',
            'version'     => 'aiPaaS_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/aiPaaS/skills/logs',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryBaymaxSkillLogResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary Baymax技能执行日志
     *  *
     * @param QueryBaymaxSkillLogRequest $request QueryBaymaxSkillLogRequest
     *
     * @return QueryBaymaxSkillLogResponse QueryBaymaxSkillLogResponse
     */
    public function queryBaymaxSkillLog($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryBaymaxSkillLogHeaders([]);

        return $this->queryBaymaxSkillLogWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询会话消息并以大模型友好的协议返回
     *  *
     * @param string                               $cid
     * @param QueryConversationMessageForAIRequest $tmpReq  QueryConversationMessageForAIRequest
     * @param QueryConversationMessageForAIHeaders $headers QueryConversationMessageForAIHeaders
     * @param RuntimeOptions                       $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryConversationMessageForAIResponse QueryConversationMessageForAIResponse
     */
    public function queryConversationMessageForAIWithOptions($cid, $tmpReq, $headers, $runtime)
    {
        Utils::validateModel($tmpReq);
        $request = new QueryConversationMessageForAIShrinkRequest([]);
        OpenApiUtilClient::convert($tmpReq, $request);
        if (!Utils::isUnset($tmpReq->openMsgIds)) {
            $request->openMsgIdsShrink = OpenApiUtilClient::arrayToStringWithSpecifiedStyle($tmpReq->openMsgIds, 'openMsgIds', 'json');
        }
        $query = [];
        if (!Utils::isUnset($request->openMsgIdsShrink)) {
            $query['openMsgIds'] = $request->openMsgIdsShrink;
        }
        if (!Utils::isUnset($request->recentDays)) {
            $query['recentDays'] = $request->recentDays;
        }
        if (!Utils::isUnset($request->recentHours)) {
            $query['recentHours'] = $request->recentHours;
        }
        if (!Utils::isUnset($request->recentN)) {
            $query['recentN'] = $request->recentN;
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
            'action'      => 'QueryConversationMessageForAI',
            'version'     => 'aiPaaS_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/aiPaaS/me/memory/im/' . $cid . '/messages',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryConversationMessageForAIResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询会话消息并以大模型友好的协议返回
     *  *
     * @param string                               $cid
     * @param QueryConversationMessageForAIRequest $request QueryConversationMessageForAIRequest
     *
     * @return QueryConversationMessageForAIResponse QueryConversationMessageForAIResponse
     */
    public function queryConversationMessageForAI($cid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryConversationMessageForAIHeaders([]);

        return $this->queryConversationMessageForAIWithOptions($cid, $request, $headers, $runtime);
    }

    /**
     * @summary 查询记忆学习进度
     *  *
     * @param QueryMemoryLearningTaskRequest $request QueryMemoryLearningTaskRequest
     * @param QueryMemoryLearningTaskHeaders $headers QueryMemoryLearningTaskHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryMemoryLearningTaskResponse QueryMemoryLearningTaskResponse
     */
    public function queryMemoryLearningTaskWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->agentCode)) {
            $query['agentCode'] = $request->agentCode;
        }
        if (!Utils::isUnset($request->learningCode)) {
            $query['learningCode'] = $request->learningCode;
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
            'action'      => 'QueryMemoryLearningTask',
            'version'     => 'aiPaaS_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/aiPaaS/me/memory/learningTask/get',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryMemoryLearningTaskResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询记忆学习进度
     *  *
     * @param QueryMemoryLearningTaskRequest $request QueryMemoryLearningTaskRequest
     *
     * @return QueryMemoryLearningTaskResponse QueryMemoryLearningTaskResponse
     */
    public function queryMemoryLearningTask($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryMemoryLearningTaskHeaders([]);

        return $this->queryMemoryLearningTaskWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 添加智能报价数据
     *  *
     * @param SmartQuoteDataServiceRequest $request SmartQuoteDataServiceRequest
     * @param SmartQuoteDataServiceHeaders $headers SmartQuoteDataServiceHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return SmartQuoteDataServiceResponse SmartQuoteDataServiceResponse
     */
    public function smartQuoteDataServiceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->request)) {
            $body['request'] = $request->request;
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
            'action'      => 'SmartQuoteDataService',
            'version'     => 'aiPaaS_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/aiPaaS/nl2x/smartQuotations/datas',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SmartQuoteDataServiceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 添加智能报价数据
     *  *
     * @param SmartQuoteDataServiceRequest $request SmartQuoteDataServiceRequest
     *
     * @return SmartQuoteDataServiceResponse SmartQuoteDataServiceResponse
     */
    public function smartQuoteDataService($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SmartQuoteDataServiceHeaders([]);

        return $this->smartQuoteDataServiceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询智能报价
     *  *
     * @param SmartQuoteQueryServiceRequest $request SmartQuoteQueryServiceRequest
     * @param SmartQuoteQueryServiceHeaders $headers SmartQuoteQueryServiceHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return SmartQuoteQueryServiceResponse SmartQuoteQueryServiceResponse
     */
    public function smartQuoteQueryServiceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->request)) {
            $body['request'] = $request->request;
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
            'action'      => 'SmartQuoteQueryService',
            'version'     => 'aiPaaS_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/aiPaaS/nl2x/smartQuotations/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SmartQuoteQueryServiceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询智能报价
     *  *
     * @param SmartQuoteQueryServiceRequest $request SmartQuoteQueryServiceRequest
     *
     * @return SmartQuoteQueryServiceResponse SmartQuoteQueryServiceResponse
     */
    public function smartQuoteQueryService($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SmartQuoteQueryServiceHeaders([]);

        return $this->smartQuoteQueryServiceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 提交记忆学习任务
     *  *
     * @param SubmitMemoryLearningTaskRequest $tmpReq  SubmitMemoryLearningTaskRequest
     * @param SubmitMemoryLearningTaskHeaders $headers SubmitMemoryLearningTaskHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return SubmitMemoryLearningTaskResponse SubmitMemoryLearningTaskResponse
     */
    public function submitMemoryLearningTaskWithOptions($tmpReq, $headers, $runtime)
    {
        Utils::validateModel($tmpReq);
        $request = new SubmitMemoryLearningTaskShrinkRequest([]);
        OpenApiUtilClient::convert($tmpReq, $request);
        if (!Utils::isUnset($tmpReq->content)) {
            $request->contentShrink = OpenApiUtilClient::arrayToStringWithSpecifiedStyle($tmpReq->content, 'content', 'json');
        }
        $query = [];
        if (!Utils::isUnset($request->agentCode)) {
            $query['agentCode'] = $request->agentCode;
        }
        if (!Utils::isUnset($request->contentShrink)) {
            $query['content'] = $request->contentShrink;
        }
        if (!Utils::isUnset($request->learningMode)) {
            $query['learningMode'] = $request->learningMode;
        }
        if (!Utils::isUnset($request->memoryKey)) {
            $query['memoryKey'] = $request->memoryKey;
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
            'action'      => 'SubmitMemoryLearningTask',
            'version'     => 'aiPaaS_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/aiPaaS/me/memory/learningTask/put',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SubmitMemoryLearningTaskResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 提交记忆学习任务
     *  *
     * @param SubmitMemoryLearningTaskRequest $request SubmitMemoryLearningTaskRequest
     *
     * @return SubmitMemoryLearningTaskResponse SubmitMemoryLearningTaskResponse
     */
    public function submitMemoryLearningTask($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SubmitMemoryLearningTaskHeaders([]);

        return $this->submitMemoryLearningTaskWithOptions($request, $headers, $runtime);
    }
}
