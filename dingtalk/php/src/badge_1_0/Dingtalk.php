<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbadge_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vbadge_1_0\Models\CreateBadgeCodeUserInstanceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbadge_1_0\Models\CreateBadgeCodeUserInstanceRequest;
use AlibabaCloud\SDK\Dingtalk\Vbadge_1_0\Models\CreateBadgeCodeUserInstanceResponse;
use AlibabaCloud\SDK\Dingtalk\Vbadge_1_0\Models\CreateBadgeNotifyHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbadge_1_0\Models\CreateBadgeNotifyRequest;
use AlibabaCloud\SDK\Dingtalk\Vbadge_1_0\Models\CreateBadgeNotifyResponse;
use AlibabaCloud\SDK\Dingtalk\Vbadge_1_0\Models\DecodeBadgeCodeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbadge_1_0\Models\DecodeBadgeCodeRequest;
use AlibabaCloud\SDK\Dingtalk\Vbadge_1_0\Models\DecodeBadgeCodeResponse;
use AlibabaCloud\SDK\Dingtalk\Vbadge_1_0\Models\NotifyBadgeCodePayResultHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbadge_1_0\Models\NotifyBadgeCodePayResultRequest;
use AlibabaCloud\SDK\Dingtalk\Vbadge_1_0\Models\NotifyBadgeCodePayResultResponse;
use AlibabaCloud\SDK\Dingtalk\Vbadge_1_0\Models\NotifyBadgeCodeRefundResultHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbadge_1_0\Models\NotifyBadgeCodeRefundResultRequest;
use AlibabaCloud\SDK\Dingtalk\Vbadge_1_0\Models\NotifyBadgeCodeRefundResultResponse;
use AlibabaCloud\SDK\Dingtalk\Vbadge_1_0\Models\NotifyBadgeCodeVerifyResultHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbadge_1_0\Models\NotifyBadgeCodeVerifyResultRequest;
use AlibabaCloud\SDK\Dingtalk\Vbadge_1_0\Models\NotifyBadgeCodeVerifyResultResponse;
use AlibabaCloud\SDK\Dingtalk\Vbadge_1_0\Models\SaveBadgeCodeCorpInstanceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbadge_1_0\Models\SaveBadgeCodeCorpInstanceRequest;
use AlibabaCloud\SDK\Dingtalk\Vbadge_1_0\Models\SaveBadgeCodeCorpInstanceResponse;
use AlibabaCloud\SDK\Dingtalk\Vbadge_1_0\Models\UpdateBadgeCodeUserInstanceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbadge_1_0\Models\UpdateBadgeCodeUserInstanceRequest;
use AlibabaCloud\SDK\Dingtalk\Vbadge_1_0\Models\UpdateBadgeCodeUserInstanceResponse;
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
     * @param CreateBadgeCodeUserInstanceRequest $request
     *
     * @return CreateBadgeCodeUserInstanceResponse
     */
    public function createBadgeCodeUserInstance($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateBadgeCodeUserInstanceHeaders([]);

        return $this->createBadgeCodeUserInstanceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateBadgeCodeUserInstanceRequest $request
     * @param CreateBadgeCodeUserInstanceHeaders $headers
     * @param RuntimeOptions                     $runtime
     *
     * @return CreateBadgeCodeUserInstanceResponse
     */
    public function createBadgeCodeUserInstanceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->availableTimes)) {
            @$body['availableTimes'] = $request->availableTimes;
        }
        if (!Utils::isUnset($request->codeIdentity)) {
            @$body['codeIdentity'] = $request->codeIdentity;
        }
        if (!Utils::isUnset($request->codeValue)) {
            @$body['codeValue'] = $request->codeValue;
        }
        if (!Utils::isUnset($request->codeValueType)) {
            @$body['codeValueType'] = $request->codeValueType;
        }
        if (!Utils::isUnset($request->corpId)) {
            @$body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->extInfo)) {
            @$body['extInfo'] = $request->extInfo;
        }
        if (!Utils::isUnset($request->gmtExpired)) {
            @$body['gmtExpired'] = $request->gmtExpired;
        }
        if (!Utils::isUnset($request->requestId)) {
            @$body['requestId'] = $request->requestId;
        }
        if (!Utils::isUnset($request->status)) {
            @$body['status'] = $request->status;
        }
        if (!Utils::isUnset($request->userCorpRelationType)) {
            @$body['userCorpRelationType'] = $request->userCorpRelationType;
        }
        if (!Utils::isUnset($request->userIdentity)) {
            @$body['userIdentity'] = $request->userIdentity;
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

        return CreateBadgeCodeUserInstanceResponse::fromMap($this->doROARequest('CreateBadgeCodeUserInstance', 'badge_1.0', 'HTTP', 'POST', 'AK', '/v1.0/badge/codes/userInstances', 'json', $req, $runtime));
    }

    /**
     * @param CreateBadgeNotifyRequest $request
     *
     * @return CreateBadgeNotifyResponse
     */
    public function createBadgeNotify($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateBadgeNotifyHeaders([]);

        return $this->createBadgeNotifyWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateBadgeNotifyRequest $request
     * @param CreateBadgeNotifyHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return CreateBadgeNotifyResponse
     */
    public function createBadgeNotifyWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->content)) {
            @$body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->msgId)) {
            @$body['msgId'] = $request->msgId;
        }
        if (!Utils::isUnset($request->msgType)) {
            @$body['msgType'] = $request->msgType;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
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

        return CreateBadgeNotifyResponse::fromMap($this->doROARequest('CreateBadgeNotify', 'badge_1.0', 'HTTP', 'POST', 'AK', '/v1.0/badge/notices', 'json', $req, $runtime));
    }

    /**
     * @param DecodeBadgeCodeRequest $request
     *
     * @return DecodeBadgeCodeResponse
     */
    public function decodeBadgeCode($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DecodeBadgeCodeHeaders([]);

        return $this->decodeBadgeCodeWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DecodeBadgeCodeRequest $request
     * @param DecodeBadgeCodeHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return DecodeBadgeCodeResponse
     */
    public function decodeBadgeCodeWithOptions($request, $headers, $runtime)
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
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return DecodeBadgeCodeResponse::fromMap($this->doROARequest('DecodeBadgeCode', 'badge_1.0', 'HTTP', 'POST', 'AK', '/v1.0/badge/codes/decode', 'json', $req, $runtime));
    }

    /**
     * @param NotifyBadgeCodePayResultRequest $request
     *
     * @return NotifyBadgeCodePayResultResponse
     */
    public function notifyBadgeCodePayResult($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new NotifyBadgeCodePayResultHeaders([]);

        return $this->notifyBadgeCodePayResultWithOptions($request, $headers, $runtime);
    }

    /**
     * @param NotifyBadgeCodePayResultRequest $request
     * @param NotifyBadgeCodePayResultHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return NotifyBadgeCodePayResultResponse
     */
    public function notifyBadgeCodePayResultWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->amount)) {
            @$body['amount'] = $request->amount;
        }
        if (!Utils::isUnset($request->chargeAmount)) {
            @$body['chargeAmount'] = $request->chargeAmount;
        }
        if (!Utils::isUnset($request->corpId)) {
            @$body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->extInfo)) {
            @$body['extInfo'] = $request->extInfo;
        }
        if (!Utils::isUnset($request->gmtTradeCreate)) {
            @$body['gmtTradeCreate'] = $request->gmtTradeCreate;
        }
        if (!Utils::isUnset($request->gmtTradeFinish)) {
            @$body['gmtTradeFinish'] = $request->gmtTradeFinish;
        }
        if (!Utils::isUnset($request->merchantName)) {
            @$body['merchantName'] = $request->merchantName;
        }
        if (!Utils::isUnset($request->payChannelDetailList)) {
            @$body['payChannelDetailList'] = $request->payChannelDetailList;
        }
        if (!Utils::isUnset($request->payCode)) {
            @$body['payCode'] = $request->payCode;
        }
        if (!Utils::isUnset($request->promotionAmount)) {
            @$body['promotionAmount'] = $request->promotionAmount;
        }
        if (!Utils::isUnset($request->remark)) {
            @$body['remark'] = $request->remark;
        }
        if (!Utils::isUnset($request->title)) {
            @$body['title'] = $request->title;
        }
        if (!Utils::isUnset($request->tradeErrorCode)) {
            @$body['tradeErrorCode'] = $request->tradeErrorCode;
        }
        if (!Utils::isUnset($request->tradeErrorMsg)) {
            @$body['tradeErrorMsg'] = $request->tradeErrorMsg;
        }
        if (!Utils::isUnset($request->tradeNo)) {
            @$body['tradeNo'] = $request->tradeNo;
        }
        if (!Utils::isUnset($request->tradeStatus)) {
            @$body['tradeStatus'] = $request->tradeStatus;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
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

        return NotifyBadgeCodePayResultResponse::fromMap($this->doROARequest('NotifyBadgeCodePayResult', 'badge_1.0', 'HTTP', 'POST', 'AK', '/v1.0/badge/codes/payResults', 'json', $req, $runtime));
    }

    /**
     * @param NotifyBadgeCodeRefundResultRequest $request
     *
     * @return NotifyBadgeCodeRefundResultResponse
     */
    public function notifyBadgeCodeRefundResult($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new NotifyBadgeCodeRefundResultHeaders([]);

        return $this->notifyBadgeCodeRefundResultWithOptions($request, $headers, $runtime);
    }

    /**
     * @param NotifyBadgeCodeRefundResultRequest $request
     * @param NotifyBadgeCodeRefundResultHeaders $headers
     * @param RuntimeOptions                     $runtime
     *
     * @return NotifyBadgeCodeRefundResultResponse
     */
    public function notifyBadgeCodeRefundResultWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->corpId)) {
            @$body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->gmtRefund)) {
            @$body['gmtRefund'] = $request->gmtRefund;
        }
        if (!Utils::isUnset($request->payChannelDetailList)) {
            @$body['payChannelDetailList'] = $request->payChannelDetailList;
        }
        if (!Utils::isUnset($request->payCode)) {
            @$body['payCode'] = $request->payCode;
        }
        if (!Utils::isUnset($request->refundAmount)) {
            @$body['refundAmount'] = $request->refundAmount;
        }
        if (!Utils::isUnset($request->refundOrderNo)) {
            @$body['refundOrderNo'] = $request->refundOrderNo;
        }
        if (!Utils::isUnset($request->refundPromotionAmount)) {
            @$body['refundPromotionAmount'] = $request->refundPromotionAmount;
        }
        if (!Utils::isUnset($request->remark)) {
            @$body['remark'] = $request->remark;
        }
        if (!Utils::isUnset($request->tradeNo)) {
            @$body['tradeNo'] = $request->tradeNo;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
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

        return NotifyBadgeCodeRefundResultResponse::fromMap($this->doROARequest('NotifyBadgeCodeRefundResult', 'badge_1.0', 'HTTP', 'POST', 'AK', '/v1.0/badge/codes/refundResults', 'json', $req, $runtime));
    }

    /**
     * @param NotifyBadgeCodeVerifyResultRequest $request
     *
     * @return NotifyBadgeCodeVerifyResultResponse
     */
    public function notifyBadgeCodeVerifyResult($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new NotifyBadgeCodeVerifyResultHeaders([]);

        return $this->notifyBadgeCodeVerifyResultWithOptions($request, $headers, $runtime);
    }

    /**
     * @param NotifyBadgeCodeVerifyResultRequest $request
     * @param NotifyBadgeCodeVerifyResultHeaders $headers
     * @param RuntimeOptions                     $runtime
     *
     * @return NotifyBadgeCodeVerifyResultResponse
     */
    public function notifyBadgeCodeVerifyResultWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->corpId)) {
            @$body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->payCode)) {
            @$body['payCode'] = $request->payCode;
        }
        if (!Utils::isUnset($request->remark)) {
            @$body['remark'] = $request->remark;
        }
        if (!Utils::isUnset($request->userCorpRelationType)) {
            @$body['userCorpRelationType'] = $request->userCorpRelationType;
        }
        if (!Utils::isUnset($request->userIdentity)) {
            @$body['userIdentity'] = $request->userIdentity;
        }
        if (!Utils::isUnset($request->verifyEvent)) {
            @$body['verifyEvent'] = $request->verifyEvent;
        }
        if (!Utils::isUnset($request->verifyLocation)) {
            @$body['verifyLocation'] = $request->verifyLocation;
        }
        if (!Utils::isUnset($request->verifyNo)) {
            @$body['verifyNo'] = $request->verifyNo;
        }
        if (!Utils::isUnset($request->verifyResult)) {
            @$body['verifyResult'] = $request->verifyResult;
        }
        if (!Utils::isUnset($request->verifyTime)) {
            @$body['verifyTime'] = $request->verifyTime;
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

        return NotifyBadgeCodeVerifyResultResponse::fromMap($this->doROARequest('NotifyBadgeCodeVerifyResult', 'badge_1.0', 'HTTP', 'POST', 'AK', '/v1.0/badge/codes/verifyResults', 'json', $req, $runtime));
    }

    /**
     * @param SaveBadgeCodeCorpInstanceRequest $request
     *
     * @return SaveBadgeCodeCorpInstanceResponse
     */
    public function saveBadgeCodeCorpInstance($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SaveBadgeCodeCorpInstanceHeaders([]);

        return $this->saveBadgeCodeCorpInstanceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SaveBadgeCodeCorpInstanceRequest $request
     * @param SaveBadgeCodeCorpInstanceHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return SaveBadgeCodeCorpInstanceResponse
     */
    public function saveBadgeCodeCorpInstanceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->codeIdentity)) {
            @$body['codeIdentity'] = $request->codeIdentity;
        }
        if (!Utils::isUnset($request->corpId)) {
            @$body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->extInfo)) {
            @$body['extInfo'] = $request->extInfo;
        }
        if (!Utils::isUnset($request->status)) {
            @$body['status'] = $request->status;
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

        return SaveBadgeCodeCorpInstanceResponse::fromMap($this->doROARequest('SaveBadgeCodeCorpInstance', 'badge_1.0', 'HTTP', 'POST', 'AK', '/v1.0/badge/codes/corpInstances', 'json', $req, $runtime));
    }

    /**
     * @param UpdateBadgeCodeUserInstanceRequest $request
     *
     * @return UpdateBadgeCodeUserInstanceResponse
     */
    public function updateBadgeCodeUserInstance($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateBadgeCodeUserInstanceHeaders([]);

        return $this->updateBadgeCodeUserInstanceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateBadgeCodeUserInstanceRequest $request
     * @param UpdateBadgeCodeUserInstanceHeaders $headers
     * @param RuntimeOptions                     $runtime
     *
     * @return UpdateBadgeCodeUserInstanceResponse
     */
    public function updateBadgeCodeUserInstanceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->availableTimes)) {
            @$body['availableTimes'] = $request->availableTimes;
        }
        if (!Utils::isUnset($request->codeId)) {
            @$body['codeId'] = $request->codeId;
        }
        if (!Utils::isUnset($request->codeIdentity)) {
            @$body['codeIdentity'] = $request->codeIdentity;
        }
        if (!Utils::isUnset($request->codeValue)) {
            @$body['codeValue'] = $request->codeValue;
        }
        if (!Utils::isUnset($request->corpId)) {
            @$body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->extInfo)) {
            @$body['extInfo'] = $request->extInfo;
        }
        if (!Utils::isUnset($request->gmtExpired)) {
            @$body['gmtExpired'] = $request->gmtExpired;
        }
        if (!Utils::isUnset($request->status)) {
            @$body['status'] = $request->status;
        }
        if (!Utils::isUnset($request->userCorpRelationType)) {
            @$body['userCorpRelationType'] = $request->userCorpRelationType;
        }
        if (!Utils::isUnset($request->userIdentity)) {
            @$body['userIdentity'] = $request->userIdentity;
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

        return UpdateBadgeCodeUserInstanceResponse::fromMap($this->doROARequest('UpdateBadgeCodeUserInstance', 'badge_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/badge/codes/userInstances', 'json', $req, $runtime));
    }
}
