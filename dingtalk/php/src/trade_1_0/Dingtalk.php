<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrade_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vtrade_1_0\Models\CheckOpportunityResultHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtrade_1_0\Models\CheckOpportunityResultRequest;
use AlibabaCloud\SDK\Dingtalk\Vtrade_1_0\Models\CheckOpportunityResultResponse;
use AlibabaCloud\SDK\Dingtalk\Vtrade_1_0\Models\CreateOpportunityHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtrade_1_0\Models\CreateOpportunityRequest;
use AlibabaCloud\SDK\Dingtalk\Vtrade_1_0\Models\CreateOpportunityResponse;
use AlibabaCloud\SDK\Dingtalk\Vtrade_1_0\Models\QueryTradeOrderHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtrade_1_0\Models\QueryTradeOrderRequest;
use AlibabaCloud\SDK\Dingtalk\Vtrade_1_0\Models\QueryTradeOrderResponse;
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
     * @param CheckOpportunityResultRequest $request
     *
     * @return CheckOpportunityResultResponse
     */
    public function checkOpportunityResult($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CheckOpportunityResultHeaders([]);

        return $this->checkOpportunityResultWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CheckOpportunityResultRequest $request
     * @param CheckOpportunityResultHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return CheckOpportunityResultResponse
     */
    public function checkOpportunityResultWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->belongToPhoneNum)) {
            @$query['belongToPhoneNum'] = $request->belongToPhoneNum;
        }
        if (!Utils::isUnset($request->contactPhoneNum)) {
            @$query['contactPhoneNum'] = $request->contactPhoneNum;
        }
        if (!Utils::isUnset($request->corpId)) {
            @$query['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->deptId)) {
            @$query['deptId'] = $request->deptId;
        }
        if (!Utils::isUnset($request->marketCode)) {
            @$query['marketCode'] = $request->marketCode;
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

        return CheckOpportunityResultResponse::fromMap($this->doROARequest('CheckOpportunityResult', 'trade_1.0', 'HTTP', 'GET', 'AK', '/v1.0/trade/opportunity/check', 'json', $req, $runtime));
    }

    /**
     * @param CreateOpportunityRequest $request
     *
     * @return CreateOpportunityResponse
     */
    public function createOpportunity($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateOpportunityHeaders([]);

        return $this->createOpportunityWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateOpportunityRequest $request
     * @param CreateOpportunityHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return CreateOpportunityResponse
     */
    public function createOpportunityWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->belongToPhoneNum)) {
            @$body['belongToPhoneNum'] = $request->belongToPhoneNum;
        }
        if (!Utils::isUnset($request->contactPhoneNum)) {
            @$body['contactPhoneNum'] = $request->contactPhoneNum;
        }
        if (!Utils::isUnset($request->corpId)) {
            @$body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->deptId)) {
            @$body['deptId'] = $request->deptId;
        }
        if (!Utils::isUnset($request->marketCode)) {
            @$body['marketCode'] = $request->marketCode;
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

        return CreateOpportunityResponse::fromMap($this->doROARequest('CreateOpportunity', 'trade_1.0', 'HTTP', 'POST', 'AK', '/v1.0/trade/opportunities', 'none', $req, $runtime));
    }

    /**
     * @param QueryTradeOrderRequest $request
     *
     * @return QueryTradeOrderResponse
     */
    public function queryTradeOrder($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryTradeOrderHeaders([]);

        return $this->queryTradeOrderWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryTradeOrderRequest $request
     * @param QueryTradeOrderHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return QueryTradeOrderResponse
     */
    public function queryTradeOrderWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->orderId)) {
            @$body['orderId'] = $request->orderId;
        }
        if (!Utils::isUnset($request->outerOrderId)) {
            @$body['outerOrderId'] = $request->outerOrderId;
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

        return QueryTradeOrderResponse::fromMap($this->doROARequest('QueryTradeOrder', 'trade_1.0', 'HTTP', 'POST', 'AK', '/v1.0/trade/orders/query', 'json', $req, $runtime));
    }
}
