<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valgo_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Valgo_1_0\Models\NlpWordDistinguishHeaders;
use AlibabaCloud\SDK\Dingtalk\Valgo_1_0\Models\NlpWordDistinguishRequest;
use AlibabaCloud\SDK\Dingtalk\Valgo_1_0\Models\NlpWordDistinguishResponse;
use AlibabaCloud\SDK\Dingtalk\Valgo_1_0\Models\OkrOpenRecommendHeaders;
use AlibabaCloud\SDK\Dingtalk\Valgo_1_0\Models\OkrOpenRecommendRequest;
use AlibabaCloud\SDK\Dingtalk\Valgo_1_0\Models\OkrOpenRecommendResponse;
use AlibabaCloud\SDK\Dingtalk\Valgo_1_0\Models\WeiqiaoAluminumQueryHeaders;
use AlibabaCloud\SDK\Dingtalk\Valgo_1_0\Models\WeiqiaoAluminumQueryRequest;
use AlibabaCloud\SDK\Dingtalk\Valgo_1_0\Models\WeiqiaoAluminumQueryResponse;
use AlibabaCloud\SDK\Dingtalk\Valgo_1_0\Models\WeiqiaoAluminumSubmitHeaders;
use AlibabaCloud\SDK\Dingtalk\Valgo_1_0\Models\WeiqiaoAluminumSubmitRequest;
use AlibabaCloud\SDK\Dingtalk\Valgo_1_0\Models\WeiqiaoAluminumSubmitResponse;
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
     * @summary 自然语言处理之关键词识别
     *  *
     * @param NlpWordDistinguishRequest $request NlpWordDistinguishRequest
     * @param NlpWordDistinguishHeaders $headers NlpWordDistinguishHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return NlpWordDistinguishResponse NlpWordDistinguishResponse
     */
    public function nlpWordDistinguishWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->attachExtractDecisionInfo)) {
            $body['attachExtractDecisionInfo'] = $request->attachExtractDecisionInfo;
        }
        if (!Utils::isUnset($request->isvAppId)) {
            $body['isvAppId'] = $request->isvAppId;
        }
        if (!Utils::isUnset($request->text)) {
            $body['text'] = $request->text;
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
            'action' => 'NlpWordDistinguish',
            'version' => 'algo_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/algo/okrs/keywords/extract',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return NlpWordDistinguishResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 自然语言处理之关键词识别
     *  *
     * @param NlpWordDistinguishRequest $request NlpWordDistinguishRequest
     *
     * @return NlpWordDistinguishResponse NlpWordDistinguishResponse
     */
    public function nlpWordDistinguish($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new NlpWordDistinguishHeaders([]);

        return $this->nlpWordDistinguishWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary Okr内容推荐
     *  *
     * @param OkrOpenRecommendRequest $request OkrOpenRecommendRequest
     * @param OkrOpenRecommendHeaders $headers OkrOpenRecommendHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return OkrOpenRecommendResponse OkrOpenRecommendResponse
     */
    public function okrOpenRecommendWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->candidateOkrItems)) {
            $body['candidateOkrItems'] = $request->candidateOkrItems;
        }
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->deptIds)) {
            $body['deptIds'] = $request->deptIds;
        }
        if (!Utils::isUnset($request->isvAppId)) {
            $body['isvAppId'] = $request->isvAppId;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->words)) {
            $body['words'] = $request->words;
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
            'action' => 'OkrOpenRecommend',
            'version' => 'algo_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/algo/okrs/recommend',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return OkrOpenRecommendResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary Okr内容推荐
     *  *
     * @param OkrOpenRecommendRequest $request OkrOpenRecommendRequest
     *
     * @return OkrOpenRecommendResponse OkrOpenRecommendResponse
     */
    public function okrOpenRecommend($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new OkrOpenRecommendHeaders([]);

        return $this->okrOpenRecommendWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 魏桥铝原料预测任务查询
     *  *
     * @param WeiqiaoAluminumQueryRequest $request WeiqiaoAluminumQueryRequest
     * @param WeiqiaoAluminumQueryHeaders $headers WeiqiaoAluminumQueryHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return WeiqiaoAluminumQueryResponse WeiqiaoAluminumQueryResponse
     */
    public function weiqiaoAluminumQueryWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->taskId)) {
            $body['task_id'] = $request->taskId;
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
            'action' => 'WeiqiaoAluminumQuery',
            'version' => 'algo_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/algo/industry/weiqiao/aluminum/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return WeiqiaoAluminumQueryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 魏桥铝原料预测任务查询
     *  *
     * @param WeiqiaoAluminumQueryRequest $request WeiqiaoAluminumQueryRequest
     *
     * @return WeiqiaoAluminumQueryResponse WeiqiaoAluminumQueryResponse
     */
    public function weiqiaoAluminumQuery($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new WeiqiaoAluminumQueryHeaders([]);

        return $this->weiqiaoAluminumQueryWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 魏桥铝原料预测任务提交
     *  *
     * @param WeiqiaoAluminumSubmitRequest $request WeiqiaoAluminumSubmitRequest
     * @param WeiqiaoAluminumSubmitHeaders $headers WeiqiaoAluminumSubmitHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return WeiqiaoAluminumSubmitResponse WeiqiaoAluminumSubmitResponse
     */
    public function weiqiaoAluminumSubmitWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->currentFurnace)) {
            $body['current_furnace'] = $request->currentFurnace;
        }
        if (!Utils::isUnset($request->dilutionConfig)) {
            $body['dilution_config'] = $request->dilutionConfig;
        }
        if (!Utils::isUnset($request->historyFurnace)) {
            $body['history_furnace'] = $request->historyFurnace;
        }
        if (!Utils::isUnset($request->rawMaterials)) {
            $body['raw_materials'] = $request->rawMaterials;
        }
        if (!Utils::isUnset($request->target)) {
            $body['target'] = $request->target;
        }
        if (!Utils::isUnset($request->targetRanges)) {
            $body['target_ranges'] = $request->targetRanges;
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
            'action' => 'WeiqiaoAluminumSubmit',
            'version' => 'algo_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/algo/industry/weiqiao/aluminum/submit',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return WeiqiaoAluminumSubmitResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 魏桥铝原料预测任务提交
     *  *
     * @param WeiqiaoAluminumSubmitRequest $request WeiqiaoAluminumSubmitRequest
     *
     * @return WeiqiaoAluminumSubmitResponse WeiqiaoAluminumSubmitResponse
     */
    public function weiqiaoAluminumSubmit($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new WeiqiaoAluminumSubmitHeaders([]);

        return $this->weiqiaoAluminumSubmitWithOptions($request, $headers, $runtime);
    }
}
