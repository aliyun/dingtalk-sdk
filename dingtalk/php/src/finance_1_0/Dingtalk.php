<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\DecodePayCodeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\DecodePayCodeRequest;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\DecodePayCodeResponse;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\NotifyPayCodePayResultHeaders;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\NotifyPayCodePayResultRequest;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\NotifyPayCodePayResultResponse;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\NotifyPayCodeRefundResultHeaders;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\NotifyPayCodeRefundResultRequest;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\NotifyPayCodeRefundResultResponse;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\SaveCorpPayCodeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\SaveCorpPayCodeRequest;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\SaveCorpPayCodeResponse;
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
     * @param NotifyPayCodePayResultRequest $request
     *
     * @return NotifyPayCodePayResultResponse
     */
    public function notifyPayCodePayResult($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new NotifyPayCodePayResultHeaders([]);

        return $this->notifyPayCodePayResultWithOptions($request, $headers, $runtime);
    }

    /**
     * @param NotifyPayCodePayResultRequest $request
     * @param NotifyPayCodePayResultHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return NotifyPayCodePayResultResponse
     */
    public function notifyPayCodePayResultWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->payCode)) {
            @$body['payCode'] = $request->payCode;
        }
        if (!Utils::isUnset($request->corpId)) {
            @$body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->gmtTradeCreate)) {
            @$body['gmtTradeCreate'] = $request->gmtTradeCreate;
        }
        if (!Utils::isUnset($request->gmtTradeFinish)) {
            @$body['gmtTradeFinish'] = $request->gmtTradeFinish;
        }
        if (!Utils::isUnset($request->tradeNo)) {
            @$body['tradeNo'] = $request->tradeNo;
        }
        if (!Utils::isUnset($request->tradeStatus)) {
            @$body['tradeStatus'] = $request->tradeStatus;
        }
        if (!Utils::isUnset($request->title)) {
            @$body['title'] = $request->title;
        }
        if (!Utils::isUnset($request->remark)) {
            @$body['remark'] = $request->remark;
        }
        if (!Utils::isUnset($request->amount)) {
            @$body['amount'] = $request->amount;
        }
        if (!Utils::isUnset($request->promotionAmount)) {
            @$body['promotionAmount'] = $request->promotionAmount;
        }
        if (!Utils::isUnset($request->chargeAmount)) {
            @$body['chargeAmount'] = $request->chargeAmount;
        }
        if (!Utils::isUnset($request->payChannelDetailList)) {
            @$body['payChannelDetailList'] = $request->payChannelDetailList;
        }
        if (!Utils::isUnset($request->tradeErrorCode)) {
            @$body['tradeErrorCode'] = $request->tradeErrorCode;
        }
        if (!Utils::isUnset($request->tradeErrorMsg)) {
            @$body['tradeErrorMsg'] = $request->tradeErrorMsg;
        }
        if (!Utils::isUnset($request->extInfo)) {
            @$body['extInfo'] = $request->extInfo;
        }
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            @$body['dingIsvOrgId'] = $request->dingIsvOrgId;
        }
        if (!Utils::isUnset($request->merchantName)) {
            @$body['merchantName'] = $request->merchantName;
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

        return NotifyPayCodePayResultResponse::fromMap($this->doROARequest('NotifyPayCodePayResult', 'finance_1.0', 'HTTP', 'POST', 'AK', '/v1.0/finance/payCodes/payResults/notify', 'json', $req, $runtime));
    }

    /**
     * @param NotifyPayCodeRefundResultRequest $request
     *
     * @return NotifyPayCodeRefundResultResponse
     */
    public function notifyPayCodeRefundResult($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new NotifyPayCodeRefundResultHeaders([]);

        return $this->notifyPayCodeRefundResultWithOptions($request, $headers, $runtime);
    }

    /**
     * @param NotifyPayCodeRefundResultRequest $request
     * @param NotifyPayCodeRefundResultHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return NotifyPayCodeRefundResultResponse
     */
    public function notifyPayCodeRefundResultWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->corpId)) {
            @$body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->tradeNo)) {
            @$body['tradeNo'] = $request->tradeNo;
        }
        if (!Utils::isUnset($request->refundOrderNo)) {
            @$body['refundOrderNo'] = $request->refundOrderNo;
        }
        if (!Utils::isUnset($request->remark)) {
            @$body['remark'] = $request->remark;
        }
        if (!Utils::isUnset($request->refundAmount)) {
            @$body['refundAmount'] = $request->refundAmount;
        }
        if (!Utils::isUnset($request->refundPromotionAmount)) {
            @$body['refundPromotionAmount'] = $request->refundPromotionAmount;
        }
        if (!Utils::isUnset($request->gmtRefund)) {
            @$body['gmtRefund'] = $request->gmtRefund;
        }
        if (!Utils::isUnset($request->payChannelDetailList)) {
            @$body['payChannelDetailList'] = $request->payChannelDetailList;
        }
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            @$body['dingIsvOrgId'] = $request->dingIsvOrgId;
        }
        if (!Utils::isUnset($request->payCode)) {
            @$body['payCode'] = $request->payCode;
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

        return NotifyPayCodeRefundResultResponse::fromMap($this->doROARequest('NotifyPayCodeRefundResult', 'finance_1.0', 'HTTP', 'POST', 'AK', '/v1.0/finance/payCodes/refundResults/notify', 'json', $req, $runtime));
    }

    /**
     * @param DecodePayCodeRequest $request
     *
     * @return DecodePayCodeResponse
     */
    public function decodePayCode($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DecodePayCodeHeaders([]);

        return $this->decodePayCodeWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DecodePayCodeRequest $request
     * @param DecodePayCodeHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return DecodePayCodeResponse
     */
    public function decodePayCodeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->payCode)) {
            @$body['payCode'] = $request->payCode;
        }
        if (!Utils::isUnset($request->requestId)) {
            @$body['requestId'] = $request->requestId;
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

        return DecodePayCodeResponse::fromMap($this->doROARequest('DecodePayCode', 'finance_1.0', 'HTTP', 'POST', 'AK', '/v1.0/finance/payCodes/decode', 'json', $req, $runtime));
    }

    /**
     * @param SaveCorpPayCodeRequest $request
     *
     * @return SaveCorpPayCodeResponse
     */
    public function saveCorpPayCode($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SaveCorpPayCodeHeaders([]);

        return $this->saveCorpPayCodeWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SaveCorpPayCodeRequest $request
     * @param SaveCorpPayCodeHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return SaveCorpPayCodeResponse
     */
    public function saveCorpPayCodeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->codeIdentity)) {
            @$body['codeIdentity'] = $request->codeIdentity;
        }
        if (!Utils::isUnset($request->corpId)) {
            @$body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->status)) {
            @$body['status'] = $request->status;
        }
        if (!Utils::isUnset($request->extInfo)) {
            @$body['extInfo'] = $request->extInfo;
        }
        if (!Utils::isUnset($request->dingOrgId)) {
            @$body['dingOrgId'] = $request->dingOrgId;
        }
        if (!Utils::isUnset($request->dingClientId)) {
            @$body['dingClientId'] = $request->dingClientId;
        }
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            @$body['dingIsvOrgId'] = $request->dingIsvOrgId;
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

        return SaveCorpPayCodeResponse::fromMap($this->doROARequest('SaveCorpPayCode', 'finance_1.0', 'HTTP', 'POST', 'AK', '/v1.0/finance/payCodes/corpSettings', 'json', $req, $runtime));
    }
}
