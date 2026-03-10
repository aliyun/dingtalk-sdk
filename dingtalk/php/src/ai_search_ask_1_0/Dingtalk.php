<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vai_search_ask_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vai_search_ask_1_0\Models\FetchLoginStatusDevicesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vai_search_ask_1_0\Models\FetchLoginStatusDevicesRequest;
use AlibabaCloud\SDK\Dingtalk\Vai_search_ask_1_0\Models\FetchLoginStatusDevicesResponse;
use AlibabaCloud\SDK\Dingtalk\Vai_search_ask_1_0\Models\GetAiTaskResultHeaders;
use AlibabaCloud\SDK\Dingtalk\Vai_search_ask_1_0\Models\GetAiTaskResultRequest;
use AlibabaCloud\SDK\Dingtalk\Vai_search_ask_1_0\Models\GetAiTaskResultResponse;
use AlibabaCloud\SDK\Dingtalk\Vai_search_ask_1_0\Models\RetrieveHeaders;
use AlibabaCloud\SDK\Dingtalk\Vai_search_ask_1_0\Models\RetrieveRequest;
use AlibabaCloud\SDK\Dingtalk\Vai_search_ask_1_0\Models\RetrieveResponse;
use AlibabaCloud\SDK\Dingtalk\Vai_search_ask_1_0\Models\SubmitAiTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vai_search_ask_1_0\Models\SubmitAiTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vai_search_ask_1_0\Models\SubmitAiTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vai_search_ask_1_0\Models\SubmitAiTaskShrinkRequest;
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
     * @summary 查询指定用户的全部已登录设备及其状态
     *  *
     * @param FetchLoginStatusDevicesRequest $request FetchLoginStatusDevicesRequest
     * @param FetchLoginStatusDevicesHeaders $headers FetchLoginStatusDevicesHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return FetchLoginStatusDevicesResponse FetchLoginStatusDevicesResponse
     */
    public function fetchLoginStatusDevicesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->domain)) {
            $body['domain'] = $request->domain;
        }
        if (!Utils::isUnset($request->userIdList)) {
            $body['userIdList'] = $request->userIdList;
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
            'action' => 'FetchLoginStatusDevices',
            'version' => 'aiSearchAsk_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/aiSearchAsk/fetchLoginStatusDevices',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return FetchLoginStatusDevicesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询指定用户的全部已登录设备及其状态
     *  *
     * @param FetchLoginStatusDevicesRequest $request FetchLoginStatusDevicesRequest
     *
     * @return FetchLoginStatusDevicesResponse FetchLoginStatusDevicesResponse
     */
    public function fetchLoginStatusDevices($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new FetchLoginStatusDevicesHeaders([]);

        return $this->fetchLoginStatusDevicesWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获得ai任务结果
     *  *
     * @param GetAiTaskResultRequest $request GetAiTaskResultRequest
     * @param GetAiTaskResultHeaders $headers GetAiTaskResultHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return GetAiTaskResultResponse GetAiTaskResultResponse
     */
    public function getAiTaskResultWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->taskId)) {
            $query['taskId'] = $request->taskId;
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
            'action' => 'GetAiTaskResult',
            'version' => 'aiSearchAsk_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/aiSearchAsk/getAiTaskResult',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetAiTaskResultResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获得ai任务结果
     *  *
     * @param GetAiTaskResultRequest $request GetAiTaskResultRequest
     *
     * @return GetAiTaskResultResponse GetAiTaskResultResponse
     */
    public function getAiTaskResult($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetAiTaskResultHeaders([]);

        return $this->getAiTaskResultWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 多数据源召回接口
     *  *
     * @param RetrieveRequest $request RetrieveRequest
     * @param RetrieveHeaders $headers RetrieveHeaders
     * @param RuntimeOptions  $runtime runtime options for this request RuntimeOptions
     *
     * @return RetrieveResponse RetrieveResponse
     */
    public function retrieveWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->answerer)) {
            $body['answerer'] = $request->answerer;
        }
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->dragRequestContext)) {
            $body['dragRequestContext'] = $request->dragRequestContext;
        }
        if (!Utils::isUnset($request->keywordList)) {
            $body['keywordList'] = $request->keywordList;
        }
        if (!Utils::isUnset($request->limit)) {
            $body['limit'] = $request->limit;
        }
        if (!Utils::isUnset($request->question)) {
            $body['question'] = $request->question;
        }
        if (!Utils::isUnset($request->questioner)) {
            $body['questioner'] = $request->questioner;
        }
        if (!Utils::isUnset($request->retrievalExtendParams)) {
            $body['retrievalExtendParams'] = $request->retrievalExtendParams;
        }
        if (!Utils::isUnset($request->retrieveScoreThreshold)) {
            $body['retrieveScoreThreshold'] = $request->retrieveScoreThreshold;
        }
        if (!Utils::isUnset($request->scene)) {
            $body['scene'] = $request->scene;
        }
        if (!Utils::isUnset($request->tenant)) {
            $body['tenant'] = $request->tenant;
        }
        if (!Utils::isUnset($request->tokenLimit)) {
            $body['tokenLimit'] = $request->tokenLimit;
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
            'action' => 'Retrieve',
            'version' => 'aiSearchAsk_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/aiSearchAsk/retrieve',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return RetrieveResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 多数据源召回接口
     *  *
     * @param RetrieveRequest $request RetrieveRequest
     *
     * @return RetrieveResponse RetrieveResponse
     */
    public function retrieve($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RetrieveHeaders([]);

        return $this->retrieveWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 提交ai任务
     *  *
     * @param SubmitAiTaskRequest $tmpReq  SubmitAiTaskRequest
     * @param SubmitAiTaskHeaders $headers SubmitAiTaskHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return SubmitAiTaskResponse SubmitAiTaskResponse
     */
    public function submitAiTaskWithOptions($tmpReq, $headers, $runtime)
    {
        Utils::validateModel($tmpReq);
        $request = new SubmitAiTaskShrinkRequest([]);
        OpenApiUtilClient::convert($tmpReq, $request);
        if (!Utils::isUnset($tmpReq->messages)) {
            $request->messagesShrink = OpenApiUtilClient::arrayToStringWithSpecifiedStyle($tmpReq->messages, 'messages', 'json');
        }
        $query = [];
        if (!Utils::isUnset($request->messagesShrink)) {
            $query['messages'] = $request->messagesShrink;
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
            'action' => 'SubmitAiTask',
            'version' => 'aiSearchAsk_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/aiSearchAsk/submitAiTask',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SubmitAiTaskResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 提交ai任务
     *  *
     * @param SubmitAiTaskRequest $request SubmitAiTaskRequest
     *
     * @return SubmitAiTaskResponse SubmitAiTaskResponse
     */
    public function submitAiTask($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SubmitAiTaskHeaders([]);

        return $this->submitAiTaskWithOptions($request, $headers, $runtime);
    }
}
