<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrip_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\SyncTripOrderHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\SyncTripOrderRequest;
use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\SyncTripOrderResponse;
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
     * @param SyncTripOrderRequest $request
     *
     * @return SyncTripOrderResponse
     */
    public function syncTripOrder($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SyncTripOrderHeaders([]);

        return $this->syncTripOrderWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SyncTripOrderRequest $request
     * @param SyncTripOrderHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return SyncTripOrderResponse
     */
    public function syncTripOrderWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->currency)) {
            @$body['currency'] = $request->currency;
        }
        if (!Utils::isUnset($request->dingUserId)) {
            @$body['dingUserId'] = $request->dingUserId;
        }
        if (!Utils::isUnset($request->discountAmount)) {
            @$body['discountAmount'] = $request->discountAmount;
        }
        if (!Utils::isUnset($request->endorseFlag)) {
            @$body['endorseFlag'] = $request->endorseFlag;
        }
        if (!Utils::isUnset($request->event)) {
            @$body['event'] = $request->event;
        }
        if (!Utils::isUnset($request->gmtOrder)) {
            @$body['gmtOrder'] = $request->gmtOrder;
        }
        if (!Utils::isUnset($request->gmtPay)) {
            @$body['gmtPay'] = $request->gmtPay;
        }
        if (!Utils::isUnset($request->gmtRefund)) {
            @$body['gmtRefund'] = $request->gmtRefund;
        }
        if (!Utils::isUnset($request->invoiceApplyUrl)) {
            @$body['invoiceApplyUrl'] = $request->invoiceApplyUrl;
        }
        if (!Utils::isUnset($request->journeyBizNo)) {
            @$body['journeyBizNo'] = $request->journeyBizNo;
        }
        if (!Utils::isUnset($request->orderDetails)) {
            @$body['orderDetails'] = $request->orderDetails;
        }
        if (!Utils::isUnset($request->orderNo)) {
            @$body['orderNo'] = $request->orderNo;
        }
        if (!Utils::isUnset($request->orderUrl)) {
            @$body['orderUrl'] = $request->orderUrl;
        }
        if (!Utils::isUnset($request->realAmount)) {
            @$body['realAmount'] = $request->realAmount;
        }
        if (!Utils::isUnset($request->refundAmount)) {
            @$body['refundAmount'] = $request->refundAmount;
        }
        if (!Utils::isUnset($request->relativeOrderNo)) {
            @$body['relativeOrderNo'] = $request->relativeOrderNo;
        }
        if (!Utils::isUnset($request->targetCorpId)) {
            @$body['targetCorpId'] = $request->targetCorpId;
        }
        if (!Utils::isUnset($request->totalAmount)) {
            @$body['totalAmount'] = $request->totalAmount;
        }
        if (!Utils::isUnset($request->type)) {
            @$body['type'] = $request->type;
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

        return SyncTripOrderResponse::fromMap($this->doROARequest('SyncTripOrder', 'trip_1.0', 'HTTP', 'POST', 'AK', '/v1.0/trip/tripOrders/sync', 'json', $req, $runtime));
    }
}
