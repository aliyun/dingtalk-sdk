<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\ApplyBatchPayHeaders;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\ApplyBatchPayRequest;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\ApplyBatchPayResponse;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\CloseLoanEntranceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\CloseLoanEntranceRequest;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\CloseLoanEntranceResponse;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\ConsultCreateSubInstitutionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\ConsultCreateSubInstitutionRequest;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\ConsultCreateSubInstitutionResponse;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\CreateAcquireRefundOrderHeaders;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\CreateAcquireRefundOrderRequest;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\CreateAcquireRefundOrderResponse;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\CreateBatchTradeOrderHeaders;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\CreateBatchTradeOrderRequest;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\CreateBatchTradeOrderResponse;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\CreateSubInstitutionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\CreateSubInstitutionRequest;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\CreateSubInstitutionResponse;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\CreateUserCodeInstanceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\CreateUserCodeInstanceRequest;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\CreateUserCodeInstanceResponse;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\CreatWithholdingOrderAndPayHeaders;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\CreatWithholdingOrderAndPayRequest;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\CreatWithholdingOrderAndPayResponse;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\DecodePayCodeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\DecodePayCodeRequest;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\DecodePayCodeResponse;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\ModifySubInstitutionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\ModifySubInstitutionRequest;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\ModifySubInstitutionResponse;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\NotifyPayCodePayResultHeaders;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\NotifyPayCodePayResultRequest;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\NotifyPayCodePayResultResponse;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\NotifyPayCodeRefundResultHeaders;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\NotifyPayCodeRefundResultRequest;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\NotifyPayCodeRefundResultResponse;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\NotifyVerifyResultHeaders;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\NotifyVerifyResultRequest;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\NotifyVerifyResultResponse;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\PreCreateGroupBillOrderHeaders;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\PreCreateGroupBillOrderRequest;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\PreCreateGroupBillOrderResponse;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\QueryAcquireRefundOrderHeaders;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\QueryAcquireRefundOrderRequest;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\QueryAcquireRefundOrderResponse;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\QueryBatchTradeDetailListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\QueryBatchTradeDetailListRequest;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\QueryBatchTradeDetailListResponse;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\QueryBatchTradeOrderHeaders;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\QueryBatchTradeOrderRequest;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\QueryBatchTradeOrderResponse;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\QueryPayAccountListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\QueryPayAccountListResponse;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\QueryRegisterOrderHeaders;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\QueryRegisterOrderRequest;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\QueryRegisterOrderResponse;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\QueryUserAgreementHeaders;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\QueryUserAgreementRequest;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\QueryUserAgreementResponse;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\QueryUserAlipayAccountHeaders;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\QueryUserAlipayAccountResponse;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\QueryWithholdingOrderHeaders;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\QueryWithholdingOrderRequest;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\QueryWithholdingOrderResponse;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\SaveCorpPayCodeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\SaveCorpPayCodeRequest;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\SaveCorpPayCodeResponse;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\UnsignUserAgreementHeaders;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\UnsignUserAgreementRequest;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\UnsignUserAgreementResponse;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\UpateUserCodeInstanceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\UpateUserCodeInstanceRequest;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\UpateUserCodeInstanceResponse;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\UpdateInvoiceVerifyStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\UpdateInvoiceVerifyStatusRequest;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\UpdateInvoiceVerifyStatusResponse;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\UploadInvoiceByAuthHeaders;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\UploadInvoiceByAuthRequest;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\UploadInvoiceByAuthResponse;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\UploadInvoiceByMobileHeaders;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\UploadInvoiceByMobileRequest;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\UploadInvoiceByMobileResponse;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\UploadInvoiceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\UploadInvoiceRequest;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\UploadInvoiceResponse;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\UploadRegisterImageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\UploadRegisterImageRequest;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\UploadRegisterImageResponse;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\UserAgreementPageSignHeaders;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\UserAgreementPageSignRequest;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\UserAgreementPageSignResponse;
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
     * @summary 批量付款
     *  *
     * @param ApplyBatchPayRequest $request ApplyBatchPayRequest
     * @param ApplyBatchPayHeaders $headers ApplyBatchPayHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return ApplyBatchPayResponse ApplyBatchPayResponse
     */
    public function applyBatchPayWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->accountId)) {
            $body['accountId'] = $request->accountId;
        }
        if (!Utils::isUnset($request->orderNo)) {
            $body['orderNo'] = $request->orderNo;
        }
        if (!Utils::isUnset($request->passBackParams)) {
            $body['passBackParams'] = $request->passBackParams;
        }
        if (!Utils::isUnset($request->payTerminal)) {
            $body['payTerminal'] = $request->payTerminal;
        }
        if (!Utils::isUnset($request->returnUrl)) {
            $body['returnUrl'] = $request->returnUrl;
        }
        if (!Utils::isUnset($request->staffId)) {
            $body['staffId'] = $request->staffId;
        }
        if (!Utils::isUnset($request->transAmount)) {
            $body['transAmount'] = $request->transAmount;
        }
        if (!Utils::isUnset($request->transExpireTime)) {
            $body['transExpireTime'] = $request->transExpireTime;
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
            'action'      => 'ApplyBatchPay',
            'version'     => 'finance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/finance/batchTrades/orders/pay',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return ApplyBatchPayResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量付款
     *  *
     * @param ApplyBatchPayRequest $request ApplyBatchPayRequest
     *
     * @return ApplyBatchPayResponse ApplyBatchPayResponse
     */
    public function applyBatchPay($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ApplyBatchPayHeaders([]);

        return $this->applyBatchPayWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 助贷业务关闭借款入口
     *  *
     * @param CloseLoanEntranceRequest $request CloseLoanEntranceRequest
     * @param CloseLoanEntranceHeaders $headers CloseLoanEntranceHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return CloseLoanEntranceResponse CloseLoanEntranceResponse
     */
    public function closeLoanEntranceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
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
            'action'      => 'CloseLoanEntrance',
            'version'     => 'finance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/finance/loans/entrances/close',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CloseLoanEntranceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 助贷业务关闭借款入口
     *  *
     * @param CloseLoanEntranceRequest $request CloseLoanEntranceRequest
     *
     * @return CloseLoanEntranceResponse CloseLoanEntranceResponse
     */
    public function closeLoanEntrance($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CloseLoanEntranceHeaders([]);

        return $this->closeLoanEntranceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 子机构创建进件预校验
     *  *
     * @param ConsultCreateSubInstitutionRequest $request ConsultCreateSubInstitutionRequest
     * @param ConsultCreateSubInstitutionHeaders $headers ConsultCreateSubInstitutionHeaders
     * @param RuntimeOptions                     $runtime runtime options for this request RuntimeOptions
     *
     * @return ConsultCreateSubInstitutionResponse ConsultCreateSubInstitutionResponse
     */
    public function consultCreateSubInstitutionWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bindingAlipayLogonId)) {
            $body['bindingAlipayLogonId'] = $request->bindingAlipayLogonId;
        }
        if (!Utils::isUnset($request->contactInfo)) {
            $body['contactInfo'] = $request->contactInfo;
        }
        if (!Utils::isUnset($request->instId)) {
            $body['instId'] = $request->instId;
        }
        if (!Utils::isUnset($request->legalPersonCertInfo)) {
            $body['legalPersonCertInfo'] = $request->legalPersonCertInfo;
        }
        if (!Utils::isUnset($request->outTradeNo)) {
            $body['outTradeNo'] = $request->outTradeNo;
        }
        if (!Utils::isUnset($request->payChannel)) {
            $body['payChannel'] = $request->payChannel;
        }
        if (!Utils::isUnset($request->qualificationInfos)) {
            $body['qualificationInfos'] = $request->qualificationInfos;
        }
        if (!Utils::isUnset($request->services)) {
            $body['services'] = $request->services;
        }
        if (!Utils::isUnset($request->settleInfo)) {
            $body['settleInfo'] = $request->settleInfo;
        }
        if (!Utils::isUnset($request->solution)) {
            $body['solution'] = $request->solution;
        }
        if (!Utils::isUnset($request->subInstAddressInfo)) {
            $body['subInstAddressInfo'] = $request->subInstAddressInfo;
        }
        if (!Utils::isUnset($request->subInstAuthInfo)) {
            $body['subInstAuthInfo'] = $request->subInstAuthInfo;
        }
        if (!Utils::isUnset($request->subInstBasicInfo)) {
            $body['subInstBasicInfo'] = $request->subInstBasicInfo;
        }
        if (!Utils::isUnset($request->subInstCertifyInfo)) {
            $body['subInstCertifyInfo'] = $request->subInstCertifyInfo;
        }
        if (!Utils::isUnset($request->subInstId)) {
            $body['subInstId'] = $request->subInstId;
        }
        if (!Utils::isUnset($request->subInstInvoiceInfo)) {
            $body['subInstInvoiceInfo'] = $request->subInstInvoiceInfo;
        }
        if (!Utils::isUnset($request->subInstShopInfo)) {
            $body['subInstShopInfo'] = $request->subInstShopInfo;
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
            'action'      => 'ConsultCreateSubInstitution',
            'version'     => 'finance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/finance/institutions/subInstitutions/consult',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ConsultCreateSubInstitutionResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 子机构创建进件预校验
     *  *
     * @param ConsultCreateSubInstitutionRequest $request ConsultCreateSubInstitutionRequest
     *
     * @return ConsultCreateSubInstitutionResponse ConsultCreateSubInstitutionResponse
     */
    public function consultCreateSubInstitution($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ConsultCreateSubInstitutionHeaders([]);

        return $this->consultCreateSubInstitutionWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 发起代扣交易
     *  *
     * @param CreatWithholdingOrderAndPayRequest $request CreatWithholdingOrderAndPayRequest
     * @param CreatWithholdingOrderAndPayHeaders $headers CreatWithholdingOrderAndPayHeaders
     * @param RuntimeOptions                     $runtime runtime options for this request RuntimeOptions
     *
     * @return CreatWithholdingOrderAndPayResponse CreatWithholdingOrderAndPayResponse
     */
    public function creatWithholdingOrderAndPayWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->amount)) {
            $body['amount'] = $request->amount;
        }
        if (!Utils::isUnset($request->instId)) {
            $body['instId'] = $request->instId;
        }
        if (!Utils::isUnset($request->otherPayChannelDetailInfoList)) {
            $body['otherPayChannelDetailInfoList'] = $request->otherPayChannelDetailInfoList;
        }
        if (!Utils::isUnset($request->outTradeNo)) {
            $body['outTradeNo'] = $request->outTradeNo;
        }
        if (!Utils::isUnset($request->payChannel)) {
            $body['payChannel'] = $request->payChannel;
        }
        if (!Utils::isUnset($request->payerUserId)) {
            $body['payerUserId'] = $request->payerUserId;
        }
        if (!Utils::isUnset($request->remark)) {
            $body['remark'] = $request->remark;
        }
        if (!Utils::isUnset($request->subInstId)) {
            $body['subInstId'] = $request->subInstId;
        }
        if (!Utils::isUnset($request->timeOutExpress)) {
            $body['timeOutExpress'] = $request->timeOutExpress;
        }
        if (!Utils::isUnset($request->title)) {
            $body['title'] = $request->title;
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
            'action'      => 'CreatWithholdingOrderAndPay',
            'version'     => 'finance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/finance/withholdingOrders',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreatWithholdingOrderAndPayResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 发起代扣交易
     *  *
     * @param CreatWithholdingOrderAndPayRequest $request CreatWithholdingOrderAndPayRequest
     *
     * @return CreatWithholdingOrderAndPayResponse CreatWithholdingOrderAndPayResponse
     */
    public function creatWithholdingOrderAndPay($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreatWithholdingOrderAndPayHeaders([]);

        return $this->creatWithholdingOrderAndPayWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 收单退款交易
     *  *
     * @param CreateAcquireRefundOrderRequest $request CreateAcquireRefundOrderRequest
     * @param CreateAcquireRefundOrderHeaders $headers CreateAcquireRefundOrderHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateAcquireRefundOrderResponse CreateAcquireRefundOrderResponse
     */
    public function createAcquireRefundOrderWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->instId)) {
            $body['instId'] = $request->instId;
        }
        if (!Utils::isUnset($request->operatorUserId)) {
            $body['operatorUserId'] = $request->operatorUserId;
        }
        if (!Utils::isUnset($request->originOutTradeNo)) {
            $body['originOutTradeNo'] = $request->originOutTradeNo;
        }
        if (!Utils::isUnset($request->otherPayChannelDetailInfoList)) {
            $body['otherPayChannelDetailInfoList'] = $request->otherPayChannelDetailInfoList;
        }
        if (!Utils::isUnset($request->outRefundNo)) {
            $body['outRefundNo'] = $request->outRefundNo;
        }
        if (!Utils::isUnset($request->refundAmount)) {
            $body['refundAmount'] = $request->refundAmount;
        }
        if (!Utils::isUnset($request->remark)) {
            $body['remark'] = $request->remark;
        }
        if (!Utils::isUnset($request->subInstId)) {
            $body['subInstId'] = $request->subInstId;
        }
        if (!Utils::isUnset($request->title)) {
            $body['title'] = $request->title;
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
            'action'      => 'CreateAcquireRefundOrder',
            'version'     => 'finance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/finance/acquireOrders/refund',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateAcquireRefundOrderResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 收单退款交易
     *  *
     * @param CreateAcquireRefundOrderRequest $request CreateAcquireRefundOrderRequest
     *
     * @return CreateAcquireRefundOrderResponse CreateAcquireRefundOrderResponse
     */
    public function createAcquireRefundOrder($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateAcquireRefundOrderHeaders([]);

        return $this->createAcquireRefundOrderWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建批量支付单
     *  *
     * @param CreateBatchTradeOrderRequest $request CreateBatchTradeOrderRequest
     * @param CreateBatchTradeOrderHeaders $headers CreateBatchTradeOrderHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateBatchTradeOrderResponse CreateBatchTradeOrderResponse
     */
    public function createBatchTradeOrderWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->accountId)) {
            $body['accountId'] = $request->accountId;
        }
        if (!Utils::isUnset($request->accountNo)) {
            $body['accountNo'] = $request->accountNo;
        }
        if (!Utils::isUnset($request->batchRemark)) {
            $body['batchRemark'] = $request->batchRemark;
        }
        if (!Utils::isUnset($request->batchTradeDetails)) {
            $body['batchTradeDetails'] = $request->batchTradeDetails;
        }
        if (!Utils::isUnset($request->outBatchNo)) {
            $body['outBatchNo'] = $request->outBatchNo;
        }
        if (!Utils::isUnset($request->staffId)) {
            $body['staffId'] = $request->staffId;
        }
        if (!Utils::isUnset($request->totalAmount)) {
            $body['totalAmount'] = $request->totalAmount;
        }
        if (!Utils::isUnset($request->totalCount)) {
            $body['totalCount'] = $request->totalCount;
        }
        if (!Utils::isUnset($request->tradeTitle)) {
            $body['tradeTitle'] = $request->tradeTitle;
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
            'action'      => 'CreateBatchTradeOrder',
            'version'     => 'finance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/finance/batchTrades/orders',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return CreateBatchTradeOrderResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建批量支付单
     *  *
     * @param CreateBatchTradeOrderRequest $request CreateBatchTradeOrderRequest
     *
     * @return CreateBatchTradeOrderResponse CreateBatchTradeOrderResponse
     */
    public function createBatchTradeOrder($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateBatchTradeOrderHeaders([]);

        return $this->createBatchTradeOrderWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建子机构
     *  *
     * @param CreateSubInstitutionRequest $request CreateSubInstitutionRequest
     * @param CreateSubInstitutionHeaders $headers CreateSubInstitutionHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateSubInstitutionResponse CreateSubInstitutionResponse
     */
    public function createSubInstitutionWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bindingAlipayLogonId)) {
            $body['bindingAlipayLogonId'] = $request->bindingAlipayLogonId;
        }
        if (!Utils::isUnset($request->contactInfo)) {
            $body['contactInfo'] = $request->contactInfo;
        }
        if (!Utils::isUnset($request->instId)) {
            $body['instId'] = $request->instId;
        }
        if (!Utils::isUnset($request->legalPersonCertInfo)) {
            $body['legalPersonCertInfo'] = $request->legalPersonCertInfo;
        }
        if (!Utils::isUnset($request->outTradeNo)) {
            $body['outTradeNo'] = $request->outTradeNo;
        }
        if (!Utils::isUnset($request->payChannel)) {
            $body['payChannel'] = $request->payChannel;
        }
        if (!Utils::isUnset($request->qualificationInfos)) {
            $body['qualificationInfos'] = $request->qualificationInfos;
        }
        if (!Utils::isUnset($request->services)) {
            $body['services'] = $request->services;
        }
        if (!Utils::isUnset($request->settleInfo)) {
            $body['settleInfo'] = $request->settleInfo;
        }
        if (!Utils::isUnset($request->solution)) {
            $body['solution'] = $request->solution;
        }
        if (!Utils::isUnset($request->subInstAddressInfo)) {
            $body['subInstAddressInfo'] = $request->subInstAddressInfo;
        }
        if (!Utils::isUnset($request->subInstAuthInfo)) {
            $body['subInstAuthInfo'] = $request->subInstAuthInfo;
        }
        if (!Utils::isUnset($request->subInstBasicInfo)) {
            $body['subInstBasicInfo'] = $request->subInstBasicInfo;
        }
        if (!Utils::isUnset($request->subInstCertifyInfo)) {
            $body['subInstCertifyInfo'] = $request->subInstCertifyInfo;
        }
        if (!Utils::isUnset($request->subInstId)) {
            $body['subInstId'] = $request->subInstId;
        }
        if (!Utils::isUnset($request->subInstInvoiceInfo)) {
            $body['subInstInvoiceInfo'] = $request->subInstInvoiceInfo;
        }
        if (!Utils::isUnset($request->subInstShopInfo)) {
            $body['subInstShopInfo'] = $request->subInstShopInfo;
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
            'action'      => 'CreateSubInstitution',
            'version'     => 'finance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/finance/institutions/subInstitutions',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateSubInstitutionResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建子机构
     *  *
     * @param CreateSubInstitutionRequest $request CreateSubInstitutionRequest
     *
     * @return CreateSubInstitutionResponse CreateSubInstitutionResponse
     */
    public function createSubInstitution($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateSubInstitutionHeaders([]);

        return $this->createSubInstitutionWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建用户码实例
     *  *
     * @param CreateUserCodeInstanceRequest $request CreateUserCodeInstanceRequest
     * @param CreateUserCodeInstanceHeaders $headers CreateUserCodeInstanceHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateUserCodeInstanceResponse CreateUserCodeInstanceResponse
     */
    public function createUserCodeInstanceWithOptions($request, $headers, $runtime)
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
            'action'      => 'CreateUserCodeInstance',
            'version'     => 'finance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/finance/payCodes/userInstances',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateUserCodeInstanceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建用户码实例
     *  *
     * @param CreateUserCodeInstanceRequest $request CreateUserCodeInstanceRequest
     *
     * @return CreateUserCodeInstanceResponse CreateUserCodeInstanceResponse
     */
    public function createUserCodeInstance($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateUserCodeInstanceHeaders([]);

        return $this->createUserCodeInstanceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 解码付款码
     *  *
     * @param DecodePayCodeRequest $request DecodePayCodeRequest
     * @param DecodePayCodeHeaders $headers DecodePayCodeHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return DecodePayCodeResponse DecodePayCodeResponse
     */
    public function decodePayCodeWithOptions($request, $headers, $runtime)
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
            'action'      => 'DecodePayCode',
            'version'     => 'finance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/finance/payCodes/decode',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DecodePayCodeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 解码付款码
     *  *
     * @param DecodePayCodeRequest $request DecodePayCodeRequest
     *
     * @return DecodePayCodeResponse DecodePayCodeResponse
     */
    public function decodePayCode($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DecodePayCodeHeaders([]);

        return $this->decodePayCodeWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 修改子机构信息
     *  *
     * @param ModifySubInstitutionRequest $request ModifySubInstitutionRequest
     * @param ModifySubInstitutionHeaders $headers ModifySubInstitutionHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return ModifySubInstitutionResponse ModifySubInstitutionResponse
     */
    public function modifySubInstitutionWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bindingAlipayLogonId)) {
            $body['bindingAlipayLogonId'] = $request->bindingAlipayLogonId;
        }
        if (!Utils::isUnset($request->contactInfo)) {
            $body['contactInfo'] = $request->contactInfo;
        }
        if (!Utils::isUnset($request->instId)) {
            $body['instId'] = $request->instId;
        }
        if (!Utils::isUnset($request->legalPersonCertInfo)) {
            $body['legalPersonCertInfo'] = $request->legalPersonCertInfo;
        }
        if (!Utils::isUnset($request->outTradeNo)) {
            $body['outTradeNo'] = $request->outTradeNo;
        }
        if (!Utils::isUnset($request->payChannel)) {
            $body['payChannel'] = $request->payChannel;
        }
        if (!Utils::isUnset($request->qualificationInfos)) {
            $body['qualificationInfos'] = $request->qualificationInfos;
        }
        if (!Utils::isUnset($request->services)) {
            $body['services'] = $request->services;
        }
        if (!Utils::isUnset($request->settleInfo)) {
            $body['settleInfo'] = $request->settleInfo;
        }
        if (!Utils::isUnset($request->subInstAddressInfo)) {
            $body['subInstAddressInfo'] = $request->subInstAddressInfo;
        }
        if (!Utils::isUnset($request->subInstAuthInfo)) {
            $body['subInstAuthInfo'] = $request->subInstAuthInfo;
        }
        if (!Utils::isUnset($request->subInstBasicInfo)) {
            $body['subInstBasicInfo'] = $request->subInstBasicInfo;
        }
        if (!Utils::isUnset($request->subInstCertifyInfo)) {
            $body['subInstCertifyInfo'] = $request->subInstCertifyInfo;
        }
        if (!Utils::isUnset($request->subInstId)) {
            $body['subInstId'] = $request->subInstId;
        }
        if (!Utils::isUnset($request->subInstInvoiceInfo)) {
            $body['subInstInvoiceInfo'] = $request->subInstInvoiceInfo;
        }
        if (!Utils::isUnset($request->subInstShopInfo)) {
            $body['subInstShopInfo'] = $request->subInstShopInfo;
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
            'action'      => 'ModifySubInstitution',
            'version'     => 'finance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/finance/institutions/subInstitutions/modify',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ModifySubInstitutionResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 修改子机构信息
     *  *
     * @param ModifySubInstitutionRequest $request ModifySubInstitutionRequest
     *
     * @return ModifySubInstitutionResponse ModifySubInstitutionResponse
     */
    public function modifySubInstitution($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ModifySubInstitutionHeaders([]);

        return $this->modifySubInstitutionWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 通知付款码支付结果
     *  *
     * @param NotifyPayCodePayResultRequest $request NotifyPayCodePayResultRequest
     * @param NotifyPayCodePayResultHeaders $headers NotifyPayCodePayResultHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return NotifyPayCodePayResultResponse NotifyPayCodePayResultResponse
     */
    public function notifyPayCodePayResultWithOptions($request, $headers, $runtime)
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
            'action'      => 'NotifyPayCodePayResult',
            'version'     => 'finance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/finance/payCodes/payResults/notify',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return NotifyPayCodePayResultResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 通知付款码支付结果
     *  *
     * @param NotifyPayCodePayResultRequest $request NotifyPayCodePayResultRequest
     *
     * @return NotifyPayCodePayResultResponse NotifyPayCodePayResultResponse
     */
    public function notifyPayCodePayResult($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new NotifyPayCodePayResultHeaders([]);

        return $this->notifyPayCodePayResultWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 通知付款码退款结果
     *  *
     * @param NotifyPayCodeRefundResultRequest $request NotifyPayCodeRefundResultRequest
     * @param NotifyPayCodeRefundResultHeaders $headers NotifyPayCodeRefundResultHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return NotifyPayCodeRefundResultResponse NotifyPayCodeRefundResultResponse
     */
    public function notifyPayCodeRefundResultWithOptions($request, $headers, $runtime)
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
            'action'      => 'NotifyPayCodeRefundResult',
            'version'     => 'finance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/finance/payCodes/refundResults/notify',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return NotifyPayCodeRefundResultResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 通知付款码退款结果
     *  *
     * @param NotifyPayCodeRefundResultRequest $request NotifyPayCodeRefundResultRequest
     *
     * @return NotifyPayCodeRefundResultResponse NotifyPayCodeRefundResultResponse
     */
    public function notifyPayCodeRefundResult($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new NotifyPayCodeRefundResultHeaders([]);

        return $this->notifyPayCodeRefundResultWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 上报码验证结果
     *  *
     * @param NotifyVerifyResultRequest $request NotifyVerifyResultRequest
     * @param NotifyVerifyResultHeaders $headers NotifyVerifyResultHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return NotifyVerifyResultResponse NotifyVerifyResultResponse
     */
    public function notifyVerifyResultWithOptions($request, $headers, $runtime)
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
            'action'      => 'NotifyVerifyResult',
            'version'     => 'finance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/finance/payCodes/verifyResults/notify',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return NotifyVerifyResultResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 上报码验证结果
     *  *
     * @param NotifyVerifyResultRequest $request NotifyVerifyResultRequest
     *
     * @return NotifyVerifyResultResponse NotifyVerifyResultResponse
     */
    public function notifyVerifyResult($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new NotifyVerifyResultHeaders([]);

        return $this->notifyVerifyResultWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 预创建群收款订单返回订单号
     *  *
     * @param PreCreateGroupBillOrderRequest $request PreCreateGroupBillOrderRequest
     * @param PreCreateGroupBillOrderHeaders $headers PreCreateGroupBillOrderHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return PreCreateGroupBillOrderResponse PreCreateGroupBillOrderResponse
     */
    public function preCreateGroupBillOrderWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->billItemList)) {
            $body['billItemList'] = $request->billItemList;
        }
        if (!Utils::isUnset($request->extParams)) {
            $body['extParams'] = $request->extParams;
        }
        if (!Utils::isUnset($request->headCount)) {
            $body['headCount'] = $request->headCount;
        }
        if (!Utils::isUnset($request->isAverageAmount)) {
            $body['isAverageAmount'] = $request->isAverageAmount;
        }
        if (!Utils::isUnset($request->merchantId)) {
            $body['merchantId'] = $request->merchantId;
        }
        if (!Utils::isUnset($request->openCid)) {
            $body['openCid'] = $request->openCid;
        }
        if (!Utils::isUnset($request->outBizNo)) {
            $body['outBizNo'] = $request->outBizNo;
        }
        if (!Utils::isUnset($request->payeeCorpId)) {
            $body['payeeCorpId'] = $request->payeeCorpId;
        }
        if (!Utils::isUnset($request->payeeUnionId)) {
            $body['payeeUnionId'] = $request->payeeUnionId;
        }
        if (!Utils::isUnset($request->remark)) {
            $body['remark'] = $request->remark;
        }
        if (!Utils::isUnset($request->totalAmount)) {
            $body['totalAmount'] = $request->totalAmount;
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
            'action'      => 'PreCreateGroupBillOrder',
            'version'     => 'finance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/finance/groupbills/preCreate',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return PreCreateGroupBillOrderResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 预创建群收款订单返回订单号
     *  *
     * @param PreCreateGroupBillOrderRequest $request PreCreateGroupBillOrderRequest
     *
     * @return PreCreateGroupBillOrderResponse PreCreateGroupBillOrderResponse
     */
    public function preCreateGroupBillOrder($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PreCreateGroupBillOrderHeaders([]);

        return $this->preCreateGroupBillOrderWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询收单退款交易
     *  *
     * @param QueryAcquireRefundOrderRequest $request QueryAcquireRefundOrderRequest
     * @param QueryAcquireRefundOrderHeaders $headers QueryAcquireRefundOrderHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryAcquireRefundOrderResponse QueryAcquireRefundOrderResponse
     */
    public function queryAcquireRefundOrderWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->outRefundNo)) {
            $query['outRefundNo'] = $request->outRefundNo;
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'QueryAcquireRefundOrder',
            'version'     => 'finance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/finance/acquireOrders/refunds',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryAcquireRefundOrderResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询收单退款交易
     *  *
     * @param QueryAcquireRefundOrderRequest $request QueryAcquireRefundOrderRequest
     *
     * @return QueryAcquireRefundOrderResponse QueryAcquireRefundOrderResponse
     */
    public function queryAcquireRefundOrder($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryAcquireRefundOrderHeaders([]);

        return $this->queryAcquireRefundOrderWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询批量付款明细列表
     *  *
     * @param QueryBatchTradeDetailListRequest $request QueryBatchTradeDetailListRequest
     * @param QueryBatchTradeDetailListHeaders $headers QueryBatchTradeDetailListHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryBatchTradeDetailListResponse QueryBatchTradeDetailListResponse
     */
    public function queryBatchTradeDetailListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->outBatchNo)) {
            $query['outBatchNo'] = $request->outBatchNo;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'QueryBatchTradeDetailList',
            'version'     => 'finance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/finance/batchTrades/details',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QueryBatchTradeDetailListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询批量付款明细列表
     *  *
     * @param QueryBatchTradeDetailListRequest $request QueryBatchTradeDetailListRequest
     *
     * @return QueryBatchTradeDetailListResponse QueryBatchTradeDetailListResponse
     */
    public function queryBatchTradeDetailList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryBatchTradeDetailListHeaders([]);

        return $this->queryBatchTradeDetailListWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 根据请求对象查询批量交易订单信息
     *  *
     * @param QueryBatchTradeOrderRequest $request QueryBatchTradeOrderRequest
     * @param QueryBatchTradeOrderHeaders $headers QueryBatchTradeOrderHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryBatchTradeOrderResponse QueryBatchTradeOrderResponse
     */
    public function queryBatchTradeOrderWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->outBatchNos)) {
            $body['outBatchNos'] = $request->outBatchNos;
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
            'action'      => 'QueryBatchTradeOrder',
            'version'     => 'finance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/finance/batchTrades/orders/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QueryBatchTradeOrderResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据请求对象查询批量交易订单信息
     *  *
     * @param QueryBatchTradeOrderRequest $request QueryBatchTradeOrderRequest
     *
     * @return QueryBatchTradeOrderResponse QueryBatchTradeOrderResponse
     */
    public function queryBatchTradeOrder($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryBatchTradeOrderHeaders([]);

        return $this->queryBatchTradeOrderWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询付款账号列表
     *  *
     * @param QueryPayAccountListHeaders $headers QueryPayAccountListHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryPayAccountListResponse QueryPayAccountListResponse
     */
    public function queryPayAccountListWithOptions($headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);
        $params = new Params([
            'action'      => 'QueryPayAccountList',
            'version'     => 'finance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/finance/payAccounts',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QueryPayAccountListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询付款账号列表
     *  *
     * @return QueryPayAccountListResponse QueryPayAccountListResponse
     */
    public function queryPayAccountList()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryPayAccountListHeaders([]);

        return $this->queryPayAccountListWithOptions($headers, $runtime);
    }

    /**
     * @summary 查询子机构申请单状态
     *  *
     * @param QueryRegisterOrderRequest $request QueryRegisterOrderRequest
     * @param QueryRegisterOrderHeaders $headers QueryRegisterOrderHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryRegisterOrderResponse QueryRegisterOrderResponse
     */
    public function queryRegisterOrderWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->instId)) {
            $query['instId'] = $request->instId;
        }
        if (!Utils::isUnset($request->orderId)) {
            $query['orderId'] = $request->orderId;
        }
        if (!Utils::isUnset($request->outTradeNo)) {
            $query['outTradeNo'] = $request->outTradeNo;
        }
        if (!Utils::isUnset($request->subInstId)) {
            $query['subInstId'] = $request->subInstId;
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'QueryRegisterOrder',
            'version'     => 'finance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/finance/institutions/subInstitutions/orders',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryRegisterOrderResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询子机构申请单状态
     *  *
     * @param QueryRegisterOrderRequest $request QueryRegisterOrderRequest
     *
     * @return QueryRegisterOrderResponse QueryRegisterOrderResponse
     */
    public function queryRegisterOrder($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryRegisterOrderHeaders([]);

        return $this->queryRegisterOrderWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询用户协议
     *  *
     * @param QueryUserAgreementRequest $request QueryUserAgreementRequest
     * @param QueryUserAgreementHeaders $headers QueryUserAgreementHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryUserAgreementResponse QueryUserAgreementResponse
     */
    public function queryUserAgreementWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->bizCode)) {
            $query['bizCode'] = $request->bizCode;
        }
        if (!Utils::isUnset($request->bizScene)) {
            $query['bizScene'] = $request->bizScene;
        }
        if (!Utils::isUnset($request->instId)) {
            $query['instId'] = $request->instId;
        }
        if (!Utils::isUnset($request->subInstId)) {
            $query['subInstId'] = $request->subInstId;
        }
        if (!Utils::isUnset($request->userId)) {
            $query['userId'] = $request->userId;
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'QueryUserAgreement',
            'version'     => 'finance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/finance/userAgreements',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryUserAgreementResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询用户协议
     *  *
     * @param QueryUserAgreementRequest $request QueryUserAgreementRequest
     *
     * @return QueryUserAgreementResponse QueryUserAgreementResponse
     */
    public function queryUserAgreement($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryUserAgreementHeaders([]);

        return $this->queryUserAgreementWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取用户绑定支付宝信息
     *  *
     * @param QueryUserAlipayAccountHeaders $headers QueryUserAlipayAccountHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryUserAlipayAccountResponse QueryUserAlipayAccountResponse
     */
    public function queryUserAlipayAccountWithOptions($headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);
        $params = new Params([
            'action'      => 'QueryUserAlipayAccount',
            'version'     => 'finance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/finance/userAlipayAccounts',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryUserAlipayAccountResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取用户绑定支付宝信息
     *  *
     * @return QueryUserAlipayAccountResponse QueryUserAlipayAccountResponse
     */
    public function queryUserAlipayAccount()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryUserAlipayAccountHeaders([]);

        return $this->queryUserAlipayAccountWithOptions($headers, $runtime);
    }

    /**
     * @summary 查询代扣交易订单信息
     *  *
     * @param QueryWithholdingOrderRequest $request QueryWithholdingOrderRequest
     * @param QueryWithholdingOrderHeaders $headers QueryWithholdingOrderHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryWithholdingOrderResponse QueryWithholdingOrderResponse
     */
    public function queryWithholdingOrderWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->outTradeNo)) {
            $query['outTradeNo'] = $request->outTradeNo;
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'QueryWithholdingOrder',
            'version'     => 'finance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/finance/withholdingOrders',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryWithholdingOrderResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询代扣交易订单信息
     *  *
     * @param QueryWithholdingOrderRequest $request QueryWithholdingOrderRequest
     *
     * @return QueryWithholdingOrderResponse QueryWithholdingOrderResponse
     */
    public function queryWithholdingOrder($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryWithholdingOrderHeaders([]);

        return $this->queryWithholdingOrderWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 保存付款码企业配置信息
     *  *
     * @param SaveCorpPayCodeRequest $request SaveCorpPayCodeRequest
     * @param SaveCorpPayCodeHeaders $headers SaveCorpPayCodeHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return SaveCorpPayCodeResponse SaveCorpPayCodeResponse
     */
    public function saveCorpPayCodeWithOptions($request, $headers, $runtime)
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
            'action'      => 'SaveCorpPayCode',
            'version'     => 'finance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/finance/payCodes/corpSettings',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SaveCorpPayCodeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 保存付款码企业配置信息
     *  *
     * @param SaveCorpPayCodeRequest $request SaveCorpPayCodeRequest
     *
     * @return SaveCorpPayCodeResponse SaveCorpPayCodeResponse
     */
    public function saveCorpPayCode($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SaveCorpPayCodeHeaders([]);

        return $this->saveCorpPayCodeWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 解约用户协议
     *  *
     * @param UnsignUserAgreementRequest $request UnsignUserAgreementRequest
     * @param UnsignUserAgreementHeaders $headers UnsignUserAgreementHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return UnsignUserAgreementResponse UnsignUserAgreementResponse
     */
    public function unsignUserAgreementWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->agreementNo)) {
            $body['agreementNo'] = $request->agreementNo;
        }
        if (!Utils::isUnset($request->bizCode)) {
            $body['bizCode'] = $request->bizCode;
        }
        if (!Utils::isUnset($request->bizScene)) {
            $body['bizScene'] = $request->bizScene;
        }
        if (!Utils::isUnset($request->instId)) {
            $body['instId'] = $request->instId;
        }
        if (!Utils::isUnset($request->subInstId)) {
            $body['subInstId'] = $request->subInstId;
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
            'action'      => 'UnsignUserAgreement',
            'version'     => 'finance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/finance/userAgreements/unsign',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'none',
        ]);

        return UnsignUserAgreementResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 解约用户协议
     *  *
     * @param UnsignUserAgreementRequest $request UnsignUserAgreementRequest
     *
     * @return UnsignUserAgreementResponse UnsignUserAgreementResponse
     */
    public function unsignUserAgreement($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UnsignUserAgreementHeaders([]);

        return $this->unsignUserAgreementWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新用户码实例
     *  *
     * @param UpateUserCodeInstanceRequest $request UpateUserCodeInstanceRequest
     * @param UpateUserCodeInstanceHeaders $headers UpateUserCodeInstanceHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return UpateUserCodeInstanceResponse UpateUserCodeInstanceResponse
     */
    public function upateUserCodeInstanceWithOptions($request, $headers, $runtime)
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
            'action'      => 'UpateUserCodeInstance',
            'version'     => 'finance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/finance/payCodes/userInstances',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return UpateUserCodeInstanceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新用户码实例
     *  *
     * @param UpateUserCodeInstanceRequest $request UpateUserCodeInstanceRequest
     *
     * @return UpateUserCodeInstanceResponse UpateUserCodeInstanceResponse
     */
    public function upateUserCodeInstance($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpateUserCodeInstanceHeaders([]);

        return $this->upateUserCodeInstanceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 用来给第三方企业提供发票验真结果更新的oapi
     *  *
     * @param UpdateInvoiceVerifyStatusRequest $request UpdateInvoiceVerifyStatusRequest
     * @param UpdateInvoiceVerifyStatusHeaders $headers UpdateInvoiceVerifyStatusHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateInvoiceVerifyStatusResponse UpdateInvoiceVerifyStatusResponse
     */
    public function updateInvoiceVerifyStatusWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizId)) {
            $body['bizId'] = $request->bizId;
        }
        if (!Utils::isUnset($request->checkingResult)) {
            $body['checkingResult'] = $request->checkingResult;
        }
        if (!Utils::isUnset($request->checkingStatus)) {
            $body['checkingStatus'] = $request->checkingStatus;
        }
        if (!Utils::isUnset($request->code)) {
            $body['code'] = $request->code;
        }
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->extension)) {
            $body['extension'] = $request->extension;
        }
        if (!Utils::isUnset($request->invoiceCode)) {
            $body['invoiceCode'] = $request->invoiceCode;
        }
        if (!Utils::isUnset($request->invoiceNo)) {
            $body['invoiceNo'] = $request->invoiceNo;
        }
        if (!Utils::isUnset($request->invoiceStatus)) {
            $body['invoiceStatus'] = $request->invoiceStatus;
        }
        if (!Utils::isUnset($request->invoiceVerifyId)) {
            $body['invoiceVerifyId'] = $request->invoiceVerifyId;
        }
        if (!Utils::isUnset($request->msg)) {
            $body['msg'] = $request->msg;
        }
        if (!Utils::isUnset($request->unionId)) {
            $body['unionId'] = $request->unionId;
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
            'action'      => 'UpdateInvoiceVerifyStatus',
            'version'     => 'finance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/finance/invoices/verifyStatus',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateInvoiceVerifyStatusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 用来给第三方企业提供发票验真结果更新的oapi
     *  *
     * @param UpdateInvoiceVerifyStatusRequest $request UpdateInvoiceVerifyStatusRequest
     *
     * @return UpdateInvoiceVerifyStatusResponse UpdateInvoiceVerifyStatusResponse
     */
    public function updateInvoiceVerifyStatus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateInvoiceVerifyStatusHeaders([]);

        return $this->updateInvoiceVerifyStatusWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 上传发票
     *  *
     * @param UploadInvoiceRequest $request UploadInvoiceRequest
     * @param UploadInvoiceHeaders $headers UploadInvoiceHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return UploadInvoiceResponse UploadInvoiceResponse
     */
    public function uploadInvoiceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->extension)) {
            $body['extension'] = $request->extension;
        }
        if (!Utils::isUnset($request->invoices)) {
            $body['invoices'] = $request->invoices;
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
            'action'      => 'UploadInvoice',
            'version'     => 'finance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/finance/invoices/upload',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UploadInvoiceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 上传发票
     *  *
     * @param UploadInvoiceRequest $request UploadInvoiceRequest
     *
     * @return UploadInvoiceResponse UploadInvoiceResponse
     */
    public function uploadInvoice($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UploadInvoiceHeaders([]);

        return $this->uploadInvoiceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 用户授权上传发票oapi
     *  *
     * @param UploadInvoiceByAuthRequest $request UploadInvoiceByAuthRequest
     * @param UploadInvoiceByAuthHeaders $headers UploadInvoiceByAuthHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return UploadInvoiceByAuthResponse UploadInvoiceByAuthResponse
     */
    public function uploadInvoiceByAuthWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->extension)) {
            $body['extension'] = $request->extension;
        }
        if (!Utils::isUnset($request->invoices)) {
            $body['invoices'] = $request->invoices;
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
            'action'      => 'UploadInvoiceByAuth',
            'version'     => 'finance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/finance/invoices/authorizations/upload',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UploadInvoiceByAuthResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 用户授权上传发票oapi
     *  *
     * @param UploadInvoiceByAuthRequest $request UploadInvoiceByAuthRequest
     *
     * @return UploadInvoiceByAuthResponse UploadInvoiceByAuthResponse
     */
    public function uploadInvoiceByAuth($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UploadInvoiceByAuthHeaders([]);

        return $this->uploadInvoiceByAuthWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 通过手机号上传发票
     *  *
     * @param UploadInvoiceByMobileRequest $request UploadInvoiceByMobileRequest
     * @param UploadInvoiceByMobileHeaders $headers UploadInvoiceByMobileHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return UploadInvoiceByMobileResponse UploadInvoiceByMobileResponse
     */
    public function uploadInvoiceByMobileWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->invoices)) {
            $body['invoices'] = $request->invoices;
        }
        if (!Utils::isUnset($request->mobile)) {
            $body['mobile'] = $request->mobile;
        }
        if (!Utils::isUnset($request->mobileStateCode)) {
            $body['mobileStateCode'] = $request->mobileStateCode;
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
            'action'      => 'UploadInvoiceByMobile',
            'version'     => 'finance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/finance/invoices/mobiles/upload',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UploadInvoiceByMobileResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 通过手机号上传发票
     *  *
     * @param UploadInvoiceByMobileRequest $request UploadInvoiceByMobileRequest
     *
     * @return UploadInvoiceByMobileResponse UploadInvoiceByMobileResponse
     */
    public function uploadInvoiceByMobile($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UploadInvoiceByMobileHeaders([]);

        return $this->uploadInvoiceByMobileWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 上传进件中的图片获得图片链接
     *  *
     * @param UploadRegisterImageRequest $request UploadRegisterImageRequest
     * @param UploadRegisterImageHeaders $headers UploadRegisterImageHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return UploadRegisterImageResponse UploadRegisterImageResponse
     */
    public function uploadRegisterImageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->imageContent)) {
            $body['imageContent'] = $request->imageContent;
        }
        if (!Utils::isUnset($request->imageName)) {
            $body['imageName'] = $request->imageName;
        }
        if (!Utils::isUnset($request->imageType)) {
            $body['imageType'] = $request->imageType;
        }
        if (!Utils::isUnset($request->instId)) {
            $body['instId'] = $request->instId;
        }
        if (!Utils::isUnset($request->payChannel)) {
            $body['payChannel'] = $request->payChannel;
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
            'action'      => 'UploadRegisterImage',
            'version'     => 'finance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/finance/institutions/images',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UploadRegisterImageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 上传进件中的图片获得图片链接
     *  *
     * @param UploadRegisterImageRequest $request UploadRegisterImageRequest
     *
     * @return UploadRegisterImageResponse UploadRegisterImageResponse
     */
    public function uploadRegisterImage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UploadRegisterImageHeaders([]);

        return $this->uploadRegisterImageWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 用户协议签约
     *  *
     * @param UserAgreementPageSignRequest $request UserAgreementPageSignRequest
     * @param UserAgreementPageSignHeaders $headers UserAgreementPageSignHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return UserAgreementPageSignResponse UserAgreementPageSignResponse
     */
    public function userAgreementPageSignWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizCode)) {
            $body['bizCode'] = $request->bizCode;
        }
        if (!Utils::isUnset($request->bizScene)) {
            $body['bizScene'] = $request->bizScene;
        }
        if (!Utils::isUnset($request->instId)) {
            $body['instId'] = $request->instId;
        }
        if (!Utils::isUnset($request->payChannel)) {
            $body['payChannel'] = $request->payChannel;
        }
        if (!Utils::isUnset($request->remark)) {
            $body['remark'] = $request->remark;
        }
        if (!Utils::isUnset($request->returnUrl)) {
            $body['returnUrl'] = $request->returnUrl;
        }
        if (!Utils::isUnset($request->signScene)) {
            $body['signScene'] = $request->signScene;
        }
        if (!Utils::isUnset($request->subInstId)) {
            $body['subInstId'] = $request->subInstId;
        }
        if (!Utils::isUnset($request->subMerchantName)) {
            $body['subMerchantName'] = $request->subMerchantName;
        }
        if (!Utils::isUnset($request->subMerchantServiceDesc)) {
            $body['subMerchantServiceDesc'] = $request->subMerchantServiceDesc;
        }
        if (!Utils::isUnset($request->subMerchantServiceName)) {
            $body['subMerchantServiceName'] = $request->subMerchantServiceName;
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
            'action'      => 'UserAgreementPageSign',
            'version'     => 'finance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/finance/userAgreements',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UserAgreementPageSignResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 用户协议签约
     *  *
     * @param UserAgreementPageSignRequest $request UserAgreementPageSignRequest
     *
     * @return UserAgreementPageSignResponse UserAgreementPageSignResponse
     */
    public function userAgreementPageSign($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UserAgreementPageSignHeaders([]);

        return $this->userAgreementPageSignWithOptions($request, $headers, $runtime);
    }
}
