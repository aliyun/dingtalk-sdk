<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\ApplyBatchPayHeaders;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\ApplyBatchPayRequest;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\ApplyBatchPayResponse;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\CreateBatchTradeOrderHeaders;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\CreateBatchTradeOrderRequest;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\CreateBatchTradeOrderResponse;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\CreateUserCodeInstanceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\CreateUserCodeInstanceRequest;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\CreateUserCodeInstanceResponse;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\DecodePayCodeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\DecodePayCodeRequest;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\DecodePayCodeResponse;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\NotifyPayCodePayResultHeaders;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\NotifyPayCodePayResultRequest;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\NotifyPayCodePayResultResponse;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\NotifyPayCodeRefundResultHeaders;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\NotifyPayCodeRefundResultRequest;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\NotifyPayCodeRefundResultResponse;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\NotifyVerifyResultHeaders;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\NotifyVerifyResultRequest;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\NotifyVerifyResultResponse;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\QueryBatchTradeDetailListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\QueryBatchTradeDetailListRequest;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\QueryBatchTradeDetailListResponse;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\QueryBatchTradeOrderHeaders;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\QueryBatchTradeOrderRequest;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\QueryBatchTradeOrderResponse;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\QueryPayAccountListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\QueryPayAccountListResponse;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\SaveCorpPayCodeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\SaveCorpPayCodeRequest;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\SaveCorpPayCodeResponse;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\UpateUserCodeInstanceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\UpateUserCodeInstanceRequest;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\UpateUserCodeInstanceResponse;
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
     * @param UpateUserCodeInstanceRequest $request
     *
     * @return UpateUserCodeInstanceResponse
     */
    public function upateUserCodeInstance($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpateUserCodeInstanceHeaders([]);

        return $this->upateUserCodeInstanceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpateUserCodeInstanceRequest $request
     * @param UpateUserCodeInstanceHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return UpateUserCodeInstanceResponse
     */
    public function upateUserCodeInstanceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->codeId)) {
            @$body['codeId'] = $request->codeId;
        }
        if (!Utils::isUnset($request->codeIdentity)) {
            @$body['codeIdentity'] = $request->codeIdentity;
        }
        if (!Utils::isUnset($request->codeValue)) {
            @$body['codeValue'] = $request->codeValue;
        }
        if (!Utils::isUnset($request->status)) {
            @$body['status'] = $request->status;
        }
        if (!Utils::isUnset($request->corpId)) {
            @$body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->userCorpRelationType)) {
            @$body['userCorpRelationType'] = $request->userCorpRelationType;
        }
        if (!Utils::isUnset($request->userIdentity)) {
            @$body['userIdentity'] = $request->userIdentity;
        }
        if (!Utils::isUnset($request->gmtExpired)) {
            @$body['gmtExpired'] = $request->gmtExpired;
        }
        if (!Utils::isUnset($request->availableTimes)) {
            @$body['availableTimes'] = $request->availableTimes;
        }
        if (!Utils::isUnset($request->extInfo)) {
            @$body['extInfo'] = $request->extInfo;
        }
        if (!Utils::isUnset($request->dingOrgId)) {
            @$body['dingOrgId'] = $request->dingOrgId;
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

        return UpateUserCodeInstanceResponse::fromMap($this->doROARequest('UpateUserCodeInstance', 'finance_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/finance/payCodes/userInstances', 'json', $req, $runtime));
    }

    /**
     * @param ApplyBatchPayRequest $request
     *
     * @return ApplyBatchPayResponse
     */
    public function applyBatchPay($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ApplyBatchPayHeaders([]);

        return $this->applyBatchPayWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ApplyBatchPayRequest $request
     * @param ApplyBatchPayHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return ApplyBatchPayResponse
     */
    public function applyBatchPayWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->staffId)) {
            @$body['staffId'] = $request->staffId;
        }
        if (!Utils::isUnset($request->accountId)) {
            @$body['accountId'] = $request->accountId;
        }
        if (!Utils::isUnset($request->orderNo)) {
            @$body['orderNo'] = $request->orderNo;
        }
        if (!Utils::isUnset($request->transAmount)) {
            @$body['transAmount'] = $request->transAmount;
        }
        if (!Utils::isUnset($request->returnUrl)) {
            @$body['returnUrl'] = $request->returnUrl;
        }
        if (!Utils::isUnset($request->passBackParams)) {
            @$body['passBackParams'] = $request->passBackParams;
        }
        if (!Utils::isUnset($request->payTerminal)) {
            @$body['payTerminal'] = $request->payTerminal;
        }
        if (!Utils::isUnset($request->transExpireTime)) {
            @$body['transExpireTime'] = $request->transExpireTime;
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

        return ApplyBatchPayResponse::fromMap($this->doROARequest('ApplyBatchPay', 'finance_1.0', 'HTTP', 'POST', 'AK', '/v1.0/finance/batchTrades/orders/pay', 'json', $req, $runtime));
    }

    /**
     * @param QueryBatchTradeOrderRequest $request
     *
     * @return QueryBatchTradeOrderResponse
     */
    public function queryBatchTradeOrder($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryBatchTradeOrderHeaders([]);

        return $this->queryBatchTradeOrderWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryBatchTradeOrderRequest $request
     * @param QueryBatchTradeOrderHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return QueryBatchTradeOrderResponse
     */
    public function queryBatchTradeOrderWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->outBatchNos)) {
            @$body['outBatchNos'] = $request->outBatchNos;
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

        return QueryBatchTradeOrderResponse::fromMap($this->doROARequest('QueryBatchTradeOrder', 'finance_1.0', 'HTTP', 'POST', 'AK', '/v1.0/finance/batchTrades/orders/query', 'json', $req, $runtime));
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

    /**
     * @param NotifyVerifyResultRequest $request
     *
     * @return NotifyVerifyResultResponse
     */
    public function notifyVerifyResult($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new NotifyVerifyResultHeaders([]);

        return $this->notifyVerifyResultWithOptions($request, $headers, $runtime);
    }

    /**
     * @param NotifyVerifyResultRequest $request
     * @param NotifyVerifyResultHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return NotifyVerifyResultResponse
     */
    public function notifyVerifyResultWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->payCode)) {
            @$body['payCode'] = $request->payCode;
        }
        if (!Utils::isUnset($request->corpId)) {
            @$body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->userCorpRelationType)) {
            @$body['userCorpRelationType'] = $request->userCorpRelationType;
        }
        if (!Utils::isUnset($request->userIdentity)) {
            @$body['userIdentity'] = $request->userIdentity;
        }
        if (!Utils::isUnset($request->verifyTime)) {
            @$body['verifyTime'] = $request->verifyTime;
        }
        if (!Utils::isUnset($request->verifyResult)) {
            @$body['verifyResult'] = $request->verifyResult;
        }
        if (!Utils::isUnset($request->verifyLocation)) {
            @$body['verifyLocation'] = $request->verifyLocation;
        }
        if (!Utils::isUnset($request->dingOrgId)) {
            @$body['dingOrgId'] = $request->dingOrgId;
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

        return NotifyVerifyResultResponse::fromMap($this->doROARequest('NotifyVerifyResult', 'finance_1.0', 'HTTP', 'POST', 'AK', '/v1.0/finance/payCodes/verifyResults/notify', 'json', $req, $runtime));
    }

    /**
     * @param CreateBatchTradeOrderRequest $request
     *
     * @return CreateBatchTradeOrderResponse
     */
    public function createBatchTradeOrder($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateBatchTradeOrderHeaders([]);

        return $this->createBatchTradeOrderWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateBatchTradeOrderRequest $request
     * @param CreateBatchTradeOrderHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return CreateBatchTradeOrderResponse
     */
    public function createBatchTradeOrderWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->suiteId)) {
            @$body['suiteId'] = $request->suiteId;
        }
        if (!Utils::isUnset($request->corpId)) {
            @$body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->staffId)) {
            @$body['staffId'] = $request->staffId;
        }
        if (!Utils::isUnset($request->accountId)) {
            @$body['accountId'] = $request->accountId;
        }
        if (!Utils::isUnset($request->accountNo)) {
            @$body['accountNo'] = $request->accountNo;
        }
        if (!Utils::isUnset($request->tradeTitle)) {
            @$body['tradeTitle'] = $request->tradeTitle;
        }
        if (!Utils::isUnset($request->outBatchNo)) {
            @$body['outBatchNo'] = $request->outBatchNo;
        }
        if (!Utils::isUnset($request->batchRemark)) {
            @$body['batchRemark'] = $request->batchRemark;
        }
        if (!Utils::isUnset($request->totalCount)) {
            @$body['totalCount'] = $request->totalCount;
        }
        if (!Utils::isUnset($request->totalAmount)) {
            @$body['totalAmount'] = $request->totalAmount;
        }
        if (!Utils::isUnset($request->batchTradeDetails)) {
            @$body['batchTradeDetails'] = $request->batchTradeDetails;
        }
        if (!Utils::isUnset($request->isvCorpId)) {
            @$body['isvCorpId'] = $request->isvCorpId;
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

        return CreateBatchTradeOrderResponse::fromMap($this->doROARequest('CreateBatchTradeOrder', 'finance_1.0', 'HTTP', 'POST', 'AK', '/v1.0/finance/batchTrades/orders', 'json', $req, $runtime));
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
     * @param QueryBatchTradeDetailListRequest $request
     *
     * @return QueryBatchTradeDetailListResponse
     */
    public function queryBatchTradeDetailList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryBatchTradeDetailListHeaders([]);

        return $this->queryBatchTradeDetailListWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryBatchTradeDetailListRequest $request
     * @param QueryBatchTradeDetailListHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return QueryBatchTradeDetailListResponse
     */
    public function queryBatchTradeDetailListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->outBatchNo)) {
            @$query['outBatchNo'] = $request->outBatchNo;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            @$query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
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
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return QueryBatchTradeDetailListResponse::fromMap($this->doROARequest('QueryBatchTradeDetailList', 'finance_1.0', 'HTTP', 'GET', 'AK', '/v1.0/finance/batchTrades/details', 'json', $req, $runtime));
    }

    /**
     * @return QueryPayAccountListResponse
     */
    public function queryPayAccountList()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryPayAccountListHeaders([]);

        return $this->queryPayAccountListWithOptions($headers, $runtime);
    }

    /**
     * @param QueryPayAccountListHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return QueryPayAccountListResponse
     */
    public function queryPayAccountListWithOptions($headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return QueryPayAccountListResponse::fromMap($this->doROARequest('QueryPayAccountList', 'finance_1.0', 'HTTP', 'GET', 'AK', '/v1.0/finance/payAccounts', 'json', $req, $runtime));
    }

    /**
     * @param CreateUserCodeInstanceRequest $request
     *
     * @return CreateUserCodeInstanceResponse
     */
    public function createUserCodeInstance($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateUserCodeInstanceHeaders([]);

        return $this->createUserCodeInstanceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateUserCodeInstanceRequest $request
     * @param CreateUserCodeInstanceHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return CreateUserCodeInstanceResponse
     */
    public function createUserCodeInstanceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->requestId)) {
            @$body['requestId'] = $request->requestId;
        }
        if (!Utils::isUnset($request->codeIdentity)) {
            @$body['codeIdentity'] = $request->codeIdentity;
        }
        if (!Utils::isUnset($request->codeValue)) {
            @$body['codeValue'] = $request->codeValue;
        }
        if (!Utils::isUnset($request->status)) {
            @$body['status'] = $request->status;
        }
        if (!Utils::isUnset($request->corpId)) {
            @$body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->userCorpRelationType)) {
            @$body['userCorpRelationType'] = $request->userCorpRelationType;
        }
        if (!Utils::isUnset($request->userIdentity)) {
            @$body['userIdentity'] = $request->userIdentity;
        }
        if (!Utils::isUnset($request->gmtExpired)) {
            @$body['gmtExpired'] = $request->gmtExpired;
        }
        if (!Utils::isUnset($request->availableTimes)) {
            @$body['availableTimes'] = $request->availableTimes;
        }
        if (!Utils::isUnset($request->extInfo)) {
            @$body['extInfo'] = $request->extInfo;
        }
        if (!Utils::isUnset($request->dingOrgId)) {
            @$body['dingOrgId'] = $request->dingOrgId;
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

        return CreateUserCodeInstanceResponse::fromMap($this->doROARequest('CreateUserCodeInstance', 'finance_1.0', 'HTTP', 'POST', 'AK', '/v1.0/finance/payCodes/userInstances', 'json', $req, $runtime));
    }
}
