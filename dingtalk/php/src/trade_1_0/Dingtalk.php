<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrade_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
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
        if (!Utils::isUnset($request->outerOrderId)) {
            @$body['outerOrderId'] = $request->outerOrderId;
        }
        if (!Utils::isUnset($request->orderId)) {
            @$body['orderId'] = $request->orderId;
        }
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            @$body['dingIsvOrgId'] = $request->dingIsvOrgId;
        }
        if (!Utils::isUnset($request->dingSuiteKey)) {
            @$body['dingSuiteKey'] = $request->dingSuiteKey;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return QueryTradeOrderResponse::fromMap($this->doROARequest('QueryTradeOrder', 'trade_1.0', 'HTTP', 'POST', 'AK', '/v1.0/trade/orders/query', 'json', $req, $runtime));
    }
}
