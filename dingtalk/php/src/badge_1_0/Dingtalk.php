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
use Darabonba\GatewayDingTalk\Client as DarabonbaGatewayDingTalkClient;
use Darabonba\OpenApi\Models\OpenApiRequest;
use Darabonba\OpenApi\Models\Params;
use Darabonba\OpenApi\OpenApiClient;

class Dingtalk extends OpenApiClient
{
    protected $_client;

    public function __construct($config)
    {
        parent::__construct($config);
        $this->_client       = new DarabonbaGatewayDingTalkClient();
        $this->_spi          = $this->_client;
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @summary 创建钉工牌码用户实例
     *  *
     * @param CreateBadgeCodeUserInstanceRequest $request CreateBadgeCodeUserInstanceRequest
     * @param CreateBadgeCodeUserInstanceHeaders $headers CreateBadgeCodeUserInstanceHeaders
     * @param RuntimeOptions                     $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateBadgeCodeUserInstanceResponse CreateBadgeCodeUserInstanceResponse
     */
    public function createBadgeCodeUserInstanceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->availableTimes)) {
            $body['availableTimes'] = $request->availableTimes;
        }
        if (!Utils::isUnset($request->codeIdentity)) {
            $body['codeIdentity'] = $request->codeIdentity;
        }
        if (!Utils::isUnset($request->codeValue)) {
            $body['codeValue'] = $request->codeValue;
        }
        if (!Utils::isUnset($request->codeValueType)) {
            $body['codeValueType'] = $request->codeValueType;
        }
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->extInfo)) {
            $body['extInfo'] = $request->extInfo;
        }
        if (!Utils::isUnset($request->gmtExpired)) {
            $body['gmtExpired'] = $request->gmtExpired;
        }
        if (!Utils::isUnset($request->requestId)) {
            $body['requestId'] = $request->requestId;
        }
        if (!Utils::isUnset($request->status)) {
            $body['status'] = $request->status;
        }
        if (!Utils::isUnset($request->userCorpRelationType)) {
            $body['userCorpRelationType'] = $request->userCorpRelationType;
        }
        if (!Utils::isUnset($request->userIdentity)) {
            $body['userIdentity'] = $request->userIdentity;
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
            'action'      => 'CreateBadgeCodeUserInstance',
            'version'     => 'badge_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/badge/codes/userInstances',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateBadgeCodeUserInstanceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建钉工牌码用户实例
     *  *
     * @param CreateBadgeCodeUserInstanceRequest $request CreateBadgeCodeUserInstanceRequest
     *
     * @return CreateBadgeCodeUserInstanceResponse CreateBadgeCodeUserInstanceResponse
     */
    public function createBadgeCodeUserInstance($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateBadgeCodeUserInstanceHeaders([]);

        return $this->createBadgeCodeUserInstanceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建钉工牌通知消息
     *  *
     * @param CreateBadgeNotifyRequest $request CreateBadgeNotifyRequest
     * @param CreateBadgeNotifyHeaders $headers CreateBadgeNotifyHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateBadgeNotifyResponse CreateBadgeNotifyResponse
     */
    public function createBadgeNotifyWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->content)) {
            $body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->msgId)) {
            $body['msgId'] = $request->msgId;
        }
        if (!Utils::isUnset($request->msgType)) {
            $body['msgType'] = $request->msgType;
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
            'action'      => 'CreateBadgeNotify',
            'version'     => 'badge_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/badge/notices',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateBadgeNotifyResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建钉工牌通知消息
     *  *
     * @param CreateBadgeNotifyRequest $request CreateBadgeNotifyRequest
     *
     * @return CreateBadgeNotifyResponse CreateBadgeNotifyResponse
     */
    public function createBadgeNotify($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateBadgeNotifyHeaders([]);

        return $this->createBadgeNotifyWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 钉工牌解码
     *  *
     * @param DecodeBadgeCodeRequest $request DecodeBadgeCodeRequest
     * @param DecodeBadgeCodeHeaders $headers DecodeBadgeCodeHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return DecodeBadgeCodeResponse DecodeBadgeCodeResponse
     */
    public function decodeBadgeCodeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->payCode)) {
            $body['payCode'] = $request->payCode;
        }
        if (!Utils::isUnset($request->requestId)) {
            $body['requestId'] = $request->requestId;
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
            'action'      => 'DecodeBadgeCode',
            'version'     => 'badge_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/badge/codes/decode',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DecodeBadgeCodeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 钉工牌解码
     *  *
     * @param DecodeBadgeCodeRequest $request DecodeBadgeCodeRequest
     *
     * @return DecodeBadgeCodeResponse DecodeBadgeCodeResponse
     */
    public function decodeBadgeCode($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DecodeBadgeCodeHeaders([]);

        return $this->decodeBadgeCodeWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 通知钉工牌码付款结果
     *  *
     * @param NotifyBadgeCodePayResultRequest $request NotifyBadgeCodePayResultRequest
     * @param NotifyBadgeCodePayResultHeaders $headers NotifyBadgeCodePayResultHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return NotifyBadgeCodePayResultResponse NotifyBadgeCodePayResultResponse
     */
    public function notifyBadgeCodePayResultWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->amount)) {
            $body['amount'] = $request->amount;
        }
        if (!Utils::isUnset($request->chargeAmount)) {
            $body['chargeAmount'] = $request->chargeAmount;
        }
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->extInfo)) {
            $body['extInfo'] = $request->extInfo;
        }
        if (!Utils::isUnset($request->gmtTradeCreate)) {
            $body['gmtTradeCreate'] = $request->gmtTradeCreate;
        }
        if (!Utils::isUnset($request->gmtTradeFinish)) {
            $body['gmtTradeFinish'] = $request->gmtTradeFinish;
        }
        if (!Utils::isUnset($request->merchantName)) {
            $body['merchantName'] = $request->merchantName;
        }
        if (!Utils::isUnset($request->payChannelDetailList)) {
            $body['payChannelDetailList'] = $request->payChannelDetailList;
        }
        if (!Utils::isUnset($request->payCode)) {
            $body['payCode'] = $request->payCode;
        }
        if (!Utils::isUnset($request->promotionAmount)) {
            $body['promotionAmount'] = $request->promotionAmount;
        }
        if (!Utils::isUnset($request->remark)) {
            $body['remark'] = $request->remark;
        }
        if (!Utils::isUnset($request->title)) {
            $body['title'] = $request->title;
        }
        if (!Utils::isUnset($request->tradeErrorCode)) {
            $body['tradeErrorCode'] = $request->tradeErrorCode;
        }
        if (!Utils::isUnset($request->tradeErrorMsg)) {
            $body['tradeErrorMsg'] = $request->tradeErrorMsg;
        }
        if (!Utils::isUnset($request->tradeNo)) {
            $body['tradeNo'] = $request->tradeNo;
        }
        if (!Utils::isUnset($request->tradeStatus)) {
            $body['tradeStatus'] = $request->tradeStatus;
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
            'action'      => 'NotifyBadgeCodePayResult',
            'version'     => 'badge_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/badge/codes/payResults',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return NotifyBadgeCodePayResultResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 通知钉工牌码付款结果
     *  *
     * @param NotifyBadgeCodePayResultRequest $request NotifyBadgeCodePayResultRequest
     *
     * @return NotifyBadgeCodePayResultResponse NotifyBadgeCodePayResultResponse
     */
    public function notifyBadgeCodePayResult($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new NotifyBadgeCodePayResultHeaders([]);

        return $this->notifyBadgeCodePayResultWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 通知钉工牌码退款结果
     *  *
     * @param NotifyBadgeCodeRefundResultRequest $request NotifyBadgeCodeRefundResultRequest
     * @param NotifyBadgeCodeRefundResultHeaders $headers NotifyBadgeCodeRefundResultHeaders
     * @param RuntimeOptions                     $runtime runtime options for this request RuntimeOptions
     *
     * @return NotifyBadgeCodeRefundResultResponse NotifyBadgeCodeRefundResultResponse
     */
    public function notifyBadgeCodeRefundResultWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->gmtRefund)) {
            $body['gmtRefund'] = $request->gmtRefund;
        }
        if (!Utils::isUnset($request->payChannelDetailList)) {
            $body['payChannelDetailList'] = $request->payChannelDetailList;
        }
        if (!Utils::isUnset($request->payCode)) {
            $body['payCode'] = $request->payCode;
        }
        if (!Utils::isUnset($request->refundAmount)) {
            $body['refundAmount'] = $request->refundAmount;
        }
        if (!Utils::isUnset($request->refundOrderNo)) {
            $body['refundOrderNo'] = $request->refundOrderNo;
        }
        if (!Utils::isUnset($request->refundPromotionAmount)) {
            $body['refundPromotionAmount'] = $request->refundPromotionAmount;
        }
        if (!Utils::isUnset($request->remark)) {
            $body['remark'] = $request->remark;
        }
        if (!Utils::isUnset($request->tradeNo)) {
            $body['tradeNo'] = $request->tradeNo;
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
            'action'      => 'NotifyBadgeCodeRefundResult',
            'version'     => 'badge_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/badge/codes/refundResults',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return NotifyBadgeCodeRefundResultResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 通知钉工牌码退款结果
     *  *
     * @param NotifyBadgeCodeRefundResultRequest $request NotifyBadgeCodeRefundResultRequest
     *
     * @return NotifyBadgeCodeRefundResultResponse NotifyBadgeCodeRefundResultResponse
     */
    public function notifyBadgeCodeRefundResult($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new NotifyBadgeCodeRefundResultHeaders([]);

        return $this->notifyBadgeCodeRefundResultWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 通知钉工牌码验证结果
     *  *
     * @param NotifyBadgeCodeVerifyResultRequest $request NotifyBadgeCodeVerifyResultRequest
     * @param NotifyBadgeCodeVerifyResultHeaders $headers NotifyBadgeCodeVerifyResultHeaders
     * @param RuntimeOptions                     $runtime runtime options for this request RuntimeOptions
     *
     * @return NotifyBadgeCodeVerifyResultResponse NotifyBadgeCodeVerifyResultResponse
     */
    public function notifyBadgeCodeVerifyResultWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->payCode)) {
            $body['payCode'] = $request->payCode;
        }
        if (!Utils::isUnset($request->remark)) {
            $body['remark'] = $request->remark;
        }
        if (!Utils::isUnset($request->userCorpRelationType)) {
            $body['userCorpRelationType'] = $request->userCorpRelationType;
        }
        if (!Utils::isUnset($request->userIdentity)) {
            $body['userIdentity'] = $request->userIdentity;
        }
        if (!Utils::isUnset($request->verifyEvent)) {
            $body['verifyEvent'] = $request->verifyEvent;
        }
        if (!Utils::isUnset($request->verifyLocation)) {
            $body['verifyLocation'] = $request->verifyLocation;
        }
        if (!Utils::isUnset($request->verifyNo)) {
            $body['verifyNo'] = $request->verifyNo;
        }
        if (!Utils::isUnset($request->verifyResult)) {
            $body['verifyResult'] = $request->verifyResult;
        }
        if (!Utils::isUnset($request->verifyTime)) {
            $body['verifyTime'] = $request->verifyTime;
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
            'action'      => 'NotifyBadgeCodeVerifyResult',
            'version'     => 'badge_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/badge/codes/verifyResults',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return NotifyBadgeCodeVerifyResultResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 通知钉工牌码验证结果
     *  *
     * @param NotifyBadgeCodeVerifyResultRequest $request NotifyBadgeCodeVerifyResultRequest
     *
     * @return NotifyBadgeCodeVerifyResultResponse NotifyBadgeCodeVerifyResultResponse
     */
    public function notifyBadgeCodeVerifyResult($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new NotifyBadgeCodeVerifyResultHeaders([]);

        return $this->notifyBadgeCodeVerifyResultWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 保存钉工牌企业实例
     *  *
     * @param SaveBadgeCodeCorpInstanceRequest $request SaveBadgeCodeCorpInstanceRequest
     * @param SaveBadgeCodeCorpInstanceHeaders $headers SaveBadgeCodeCorpInstanceHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return SaveBadgeCodeCorpInstanceResponse SaveBadgeCodeCorpInstanceResponse
     */
    public function saveBadgeCodeCorpInstanceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->codeIdentity)) {
            $body['codeIdentity'] = $request->codeIdentity;
        }
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->extInfo)) {
            $body['extInfo'] = $request->extInfo;
        }
        if (!Utils::isUnset($request->status)) {
            $body['status'] = $request->status;
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
            'action'      => 'SaveBadgeCodeCorpInstance',
            'version'     => 'badge_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/badge/codes/corpInstances',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SaveBadgeCodeCorpInstanceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 保存钉工牌企业实例
     *  *
     * @param SaveBadgeCodeCorpInstanceRequest $request SaveBadgeCodeCorpInstanceRequest
     *
     * @return SaveBadgeCodeCorpInstanceResponse SaveBadgeCodeCorpInstanceResponse
     */
    public function saveBadgeCodeCorpInstance($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SaveBadgeCodeCorpInstanceHeaders([]);

        return $this->saveBadgeCodeCorpInstanceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新钉工牌码用户实例
     *  *
     * @param UpdateBadgeCodeUserInstanceRequest $request UpdateBadgeCodeUserInstanceRequest
     * @param UpdateBadgeCodeUserInstanceHeaders $headers UpdateBadgeCodeUserInstanceHeaders
     * @param RuntimeOptions                     $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateBadgeCodeUserInstanceResponse UpdateBadgeCodeUserInstanceResponse
     */
    public function updateBadgeCodeUserInstanceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->availableTimes)) {
            $body['availableTimes'] = $request->availableTimes;
        }
        if (!Utils::isUnset($request->codeId)) {
            $body['codeId'] = $request->codeId;
        }
        if (!Utils::isUnset($request->codeIdentity)) {
            $body['codeIdentity'] = $request->codeIdentity;
        }
        if (!Utils::isUnset($request->codeValue)) {
            $body['codeValue'] = $request->codeValue;
        }
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->extInfo)) {
            $body['extInfo'] = $request->extInfo;
        }
        if (!Utils::isUnset($request->gmtExpired)) {
            $body['gmtExpired'] = $request->gmtExpired;
        }
        if (!Utils::isUnset($request->status)) {
            $body['status'] = $request->status;
        }
        if (!Utils::isUnset($request->userCorpRelationType)) {
            $body['userCorpRelationType'] = $request->userCorpRelationType;
        }
        if (!Utils::isUnset($request->userIdentity)) {
            $body['userIdentity'] = $request->userIdentity;
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
            'action'      => 'UpdateBadgeCodeUserInstance',
            'version'     => 'badge_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/badge/codes/userInstances',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return UpdateBadgeCodeUserInstanceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新钉工牌码用户实例
     *  *
     * @param UpdateBadgeCodeUserInstanceRequest $request UpdateBadgeCodeUserInstanceRequest
     *
     * @return UpdateBadgeCodeUserInstanceResponse UpdateBadgeCodeUserInstanceResponse
     */
    public function updateBadgeCodeUserInstance($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateBadgeCodeUserInstanceHeaders([]);

        return $this->updateBadgeCodeUserInstanceWithOptions($request, $headers, $runtime);
    }
}
