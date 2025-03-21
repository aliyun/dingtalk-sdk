<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrade_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vtrade_1_0\Models\CheckOpportunityResultHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtrade_1_0\Models\CheckOpportunityResultRequest;
use AlibabaCloud\SDK\Dingtalk\Vtrade_1_0\Models\CheckOpportunityResultResponse;
use AlibabaCloud\SDK\Dingtalk\Vtrade_1_0\Models\CreateClueTempHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtrade_1_0\Models\CreateClueTempRequest;
use AlibabaCloud\SDK\Dingtalk\Vtrade_1_0\Models\CreateClueTempResponse;
use AlibabaCloud\SDK\Dingtalk\Vtrade_1_0\Models\CreateNoteForIsvHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtrade_1_0\Models\CreateNoteForIsvRequest;
use AlibabaCloud\SDK\Dingtalk\Vtrade_1_0\Models\CreateNoteForIsvResponse;
use AlibabaCloud\SDK\Dingtalk\Vtrade_1_0\Models\CreateOpportunityHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtrade_1_0\Models\CreateOpportunityRequest;
use AlibabaCloud\SDK\Dingtalk\Vtrade_1_0\Models\CreateOpportunityResponse;
use AlibabaCloud\SDK\Dingtalk\Vtrade_1_0\Models\QueryTradeOrderHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtrade_1_0\Models\QueryTradeOrderRequest;
use AlibabaCloud\SDK\Dingtalk\Vtrade_1_0\Models\QueryTradeOrderResponse;
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
     * @summary isv检查商机创建是否符合预期
     *  *
     * @param CheckOpportunityResultRequest $request CheckOpportunityResultRequest
     * @param CheckOpportunityResultHeaders $headers CheckOpportunityResultHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return CheckOpportunityResultResponse CheckOpportunityResultResponse
     */
    public function checkOpportunityResultWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->belongToPhoneNum)) {
            $query['belongToPhoneNum'] = $request->belongToPhoneNum;
        }
        if (!Utils::isUnset($request->contactPhoneNum)) {
            $query['contactPhoneNum'] = $request->contactPhoneNum;
        }
        if (!Utils::isUnset($request->corpId)) {
            $query['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->deptId)) {
            $query['deptId'] = $request->deptId;
        }
        if (!Utils::isUnset($request->marketCode)) {
            $query['marketCode'] = $request->marketCode;
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
            'action' => 'CheckOpportunityResult',
            'version' => 'trade_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/trade/opportunity/check',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return CheckOpportunityResultResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary isv检查商机创建是否符合预期
     *  *
     * @param CheckOpportunityResultRequest $request CheckOpportunityResultRequest
     *
     * @return CheckOpportunityResultResponse CheckOpportunityResultResponse
     */
    public function checkOpportunityResult($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CheckOpportunityResultHeaders([]);

        return $this->checkOpportunityResultWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 用于客户跟进线索创建
     *  *
     * @param CreateClueTempRequest $request CreateClueTempRequest
     * @param CreateClueTempHeaders $headers CreateClueTempHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateClueTempResponse CreateClueTempResponse
     */
    public function createClueTempWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->address)) {
            $body['address'] = $request->address;
        }
        if (!Utils::isUnset($request->contactName)) {
            $body['contactName'] = $request->contactName;
        }
        if (!Utils::isUnset($request->deptId)) {
            $body['deptId'] = $request->deptId;
        }
        if (!Utils::isUnset($request->ext)) {
            $body['ext'] = $request->ext;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->phoneNum)) {
            $body['phoneNum'] = $request->phoneNum;
        }
        if (!Utils::isUnset($request->position)) {
            $body['position'] = $request->position;
        }
        if (!Utils::isUnset($request->productCode)) {
            $body['productCode'] = $request->productCode;
        }
        if (!Utils::isUnset($request->salesId)) {
            $body['salesId'] = $request->salesId;
        }
        if (!Utils::isUnset($request->source)) {
            $body['source'] = $request->source;
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
            'action' => 'CreateClueTemp',
            'version' => 'trade_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/trade/clueTemps',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateClueTempResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 用于客户跟进线索创建
     *  *
     * @param CreateClueTempRequest $request CreateClueTempRequest
     *
     * @return CreateClueTempResponse CreateClueTempResponse
     */
    public function createClueTemp($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateClueTempHeaders([]);

        return $this->createClueTempWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建小记
     *  *
     * @param CreateNoteForIsvRequest $request CreateNoteForIsvRequest
     * @param CreateNoteForIsvHeaders $headers CreateNoteForIsvHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateNoteForIsvResponse CreateNoteForIsvResponse
     */
    public function createNoteForIsvWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->contactName)) {
            $body['contactName'] = $request->contactName;
        }
        if (!Utils::isUnset($request->contactPhoneNum)) {
            $body['contactPhoneNum'] = $request->contactPhoneNum;
        }
        if (!Utils::isUnset($request->contactTitle)) {
            $body['contactTitle'] = $request->contactTitle;
        }
        if (!Utils::isUnset($request->content)) {
            $body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->inputPhoneNum)) {
            $body['inputPhoneNum'] = $request->inputPhoneNum;
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
            'action' => 'CreateNoteForIsv',
            'version' => 'trade_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/trade/notes',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateNoteForIsvResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建小记
     *  *
     * @param CreateNoteForIsvRequest $request CreateNoteForIsvRequest
     *
     * @return CreateNoteForIsvResponse CreateNoteForIsvResponse
     */
    public function createNoteForIsv($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateNoteForIsvHeaders([]);

        return $this->createNoteForIsvWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary isv创建商机
     *  *
     * @param CreateOpportunityRequest $request CreateOpportunityRequest
     * @param CreateOpportunityHeaders $headers CreateOpportunityHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateOpportunityResponse CreateOpportunityResponse
     */
    public function createOpportunityWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->belongToPhoneNum)) {
            $body['belongToPhoneNum'] = $request->belongToPhoneNum;
        }
        if (!Utils::isUnset($request->contactPhoneNum)) {
            $body['contactPhoneNum'] = $request->contactPhoneNum;
        }
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->deptId)) {
            $body['deptId'] = $request->deptId;
        }
        if (!Utils::isUnset($request->marketCode)) {
            $body['marketCode'] = $request->marketCode;
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
            'action' => 'CreateOpportunity',
            'version' => 'trade_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/trade/opportunities',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return CreateOpportunityResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary isv创建商机
     *  *
     * @param CreateOpportunityRequest $request CreateOpportunityRequest
     *
     * @return CreateOpportunityResponse CreateOpportunityResponse
     */
    public function createOpportunity($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateOpportunityHeaders([]);

        return $this->createOpportunityWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询订单信息
     *  *
     * @param QueryTradeOrderRequest $request QueryTradeOrderRequest
     * @param QueryTradeOrderHeaders $headers QueryTradeOrderHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryTradeOrderResponse QueryTradeOrderResponse
     */
    public function queryTradeOrderWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->orderId)) {
            $body['orderId'] = $request->orderId;
        }
        if (!Utils::isUnset($request->outerOrderId)) {
            $body['outerOrderId'] = $request->outerOrderId;
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
            'action' => 'QueryTradeOrder',
            'version' => 'trade_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/trade/orders/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return QueryTradeOrderResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询订单信息
     *  *
     * @param QueryTradeOrderRequest $request QueryTradeOrderRequest
     *
     * @return QueryTradeOrderResponse QueryTradeOrderResponse
     */
    public function queryTradeOrder($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryTradeOrderHeaders([]);

        return $this->queryTradeOrderWithOptions($request, $headers, $runtime);
    }
}
