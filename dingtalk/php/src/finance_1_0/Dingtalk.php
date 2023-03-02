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
        if (!Utils::isUnset($request->accountId)) {
            @$body['accountId'] = $request->accountId;
        }
        if (!Utils::isUnset($request->orderNo)) {
            @$body['orderNo'] = $request->orderNo;
        }
        if (!Utils::isUnset($request->passBackParams)) {
            @$body['passBackParams'] = $request->passBackParams;
        }
        if (!Utils::isUnset($request->payTerminal)) {
            @$body['payTerminal'] = $request->payTerminal;
        }
        if (!Utils::isUnset($request->returnUrl)) {
            @$body['returnUrl'] = $request->returnUrl;
        }
        if (!Utils::isUnset($request->staffId)) {
            @$body['staffId'] = $request->staffId;
        }
        if (!Utils::isUnset($request->transAmount)) {
            @$body['transAmount'] = $request->transAmount;
        }
        if (!Utils::isUnset($request->transExpireTime)) {
            @$body['transExpireTime'] = $request->transExpireTime;
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

        return ApplyBatchPayResponse::fromMap($this->doROARequest('ApplyBatchPay', 'finance_1.0', 'HTTP', 'POST', 'AK', '/v1.0/finance/batchTrades/orders/pay', 'json', $req, $runtime));
    }

    /**
     * @param CloseLoanEntranceRequest $request
     *
     * @return CloseLoanEntranceResponse
     */
    public function closeLoanEntrance($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CloseLoanEntranceHeaders([]);

        return $this->closeLoanEntranceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CloseLoanEntranceRequest $request
     * @param CloseLoanEntranceHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return CloseLoanEntranceResponse
     */
    public function closeLoanEntranceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
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

        return CloseLoanEntranceResponse::fromMap($this->doROARequest('CloseLoanEntrance', 'finance_1.0', 'HTTP', 'POST', 'AK', '/v1.0/finance/loans/entrances/close', 'json', $req, $runtime));
    }

    /**
     * @param ConsultCreateSubInstitutionRequest $request
     *
     * @return ConsultCreateSubInstitutionResponse
     */
    public function consultCreateSubInstitution($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ConsultCreateSubInstitutionHeaders([]);

        return $this->consultCreateSubInstitutionWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ConsultCreateSubInstitutionRequest $request
     * @param ConsultCreateSubInstitutionHeaders $headers
     * @param RuntimeOptions                     $runtime
     *
     * @return ConsultCreateSubInstitutionResponse
     */
    public function consultCreateSubInstitutionWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bindingAlipayLogonId)) {
            @$body['bindingAlipayLogonId'] = $request->bindingAlipayLogonId;
        }
        if (!Utils::isUnset($request->contactInfo)) {
            @$body['contactInfo'] = $request->contactInfo;
        }
        if (!Utils::isUnset($request->instId)) {
            @$body['instId'] = $request->instId;
        }
        if (!Utils::isUnset($request->legalPersonCertInfo)) {
            @$body['legalPersonCertInfo'] = $request->legalPersonCertInfo;
        }
        if (!Utils::isUnset($request->outTradeNo)) {
            @$body['outTradeNo'] = $request->outTradeNo;
        }
        if (!Utils::isUnset($request->payChannel)) {
            @$body['payChannel'] = $request->payChannel;
        }
        if (!Utils::isUnset($request->qualificationInfos)) {
            @$body['qualificationInfos'] = $request->qualificationInfos;
        }
        if (!Utils::isUnset($request->services)) {
            @$body['services'] = $request->services;
        }
        if (!Utils::isUnset($request->settleInfo)) {
            @$body['settleInfo'] = $request->settleInfo;
        }
        if (!Utils::isUnset($request->solution)) {
            @$body['solution'] = $request->solution;
        }
        if (!Utils::isUnset($request->subInstAddressInfo)) {
            @$body['subInstAddressInfo'] = $request->subInstAddressInfo;
        }
        if (!Utils::isUnset($request->subInstAuthInfo)) {
            @$body['subInstAuthInfo'] = $request->subInstAuthInfo;
        }
        if (!Utils::isUnset($request->subInstBasicInfo)) {
            @$body['subInstBasicInfo'] = $request->subInstBasicInfo;
        }
        if (!Utils::isUnset($request->subInstCertifyInfo)) {
            @$body['subInstCertifyInfo'] = $request->subInstCertifyInfo;
        }
        if (!Utils::isUnset($request->subInstId)) {
            @$body['subInstId'] = $request->subInstId;
        }
        if (!Utils::isUnset($request->subInstInvoiceInfo)) {
            @$body['subInstInvoiceInfo'] = $request->subInstInvoiceInfo;
        }
        if (!Utils::isUnset($request->subInstShopInfo)) {
            @$body['subInstShopInfo'] = $request->subInstShopInfo;
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

        return ConsultCreateSubInstitutionResponse::fromMap($this->doROARequest('ConsultCreateSubInstitution', 'finance_1.0', 'HTTP', 'POST', 'AK', '/v1.0/finance/institutions/subInstitutions/consult', 'json', $req, $runtime));
    }

    /**
     * @param CreatWithholdingOrderAndPayRequest $request
     *
     * @return CreatWithholdingOrderAndPayResponse
     */
    public function creatWithholdingOrderAndPay($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreatWithholdingOrderAndPayHeaders([]);

        return $this->creatWithholdingOrderAndPayWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreatWithholdingOrderAndPayRequest $request
     * @param CreatWithholdingOrderAndPayHeaders $headers
     * @param RuntimeOptions                     $runtime
     *
     * @return CreatWithholdingOrderAndPayResponse
     */
    public function creatWithholdingOrderAndPayWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->amount)) {
            @$body['amount'] = $request->amount;
        }
        if (!Utils::isUnset($request->instId)) {
            @$body['instId'] = $request->instId;
        }
        if (!Utils::isUnset($request->otherPayChannelDetailInfoList)) {
            @$body['otherPayChannelDetailInfoList'] = $request->otherPayChannelDetailInfoList;
        }
        if (!Utils::isUnset($request->outTradeNo)) {
            @$body['outTradeNo'] = $request->outTradeNo;
        }
        if (!Utils::isUnset($request->payChannel)) {
            @$body['payChannel'] = $request->payChannel;
        }
        if (!Utils::isUnset($request->payerUserId)) {
            @$body['payerUserId'] = $request->payerUserId;
        }
        if (!Utils::isUnset($request->remark)) {
            @$body['remark'] = $request->remark;
        }
        if (!Utils::isUnset($request->subInstId)) {
            @$body['subInstId'] = $request->subInstId;
        }
        if (!Utils::isUnset($request->timeOutExpress)) {
            @$body['timeOutExpress'] = $request->timeOutExpress;
        }
        if (!Utils::isUnset($request->title)) {
            @$body['title'] = $request->title;
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

        return CreatWithholdingOrderAndPayResponse::fromMap($this->doROARequest('CreatWithholdingOrderAndPay', 'finance_1.0', 'HTTP', 'POST', 'AK', '/v1.0/finance/withholdingOrders', 'json', $req, $runtime));
    }

    /**
     * @param CreateAcquireRefundOrderRequest $request
     *
     * @return CreateAcquireRefundOrderResponse
     */
    public function createAcquireRefundOrder($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateAcquireRefundOrderHeaders([]);

        return $this->createAcquireRefundOrderWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateAcquireRefundOrderRequest $request
     * @param CreateAcquireRefundOrderHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return CreateAcquireRefundOrderResponse
     */
    public function createAcquireRefundOrderWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->instId)) {
            @$body['instId'] = $request->instId;
        }
        if (!Utils::isUnset($request->operatorUserId)) {
            @$body['operatorUserId'] = $request->operatorUserId;
        }
        if (!Utils::isUnset($request->originOutTradeNo)) {
            @$body['originOutTradeNo'] = $request->originOutTradeNo;
        }
        if (!Utils::isUnset($request->otherPayChannelDetailInfoList)) {
            @$body['otherPayChannelDetailInfoList'] = $request->otherPayChannelDetailInfoList;
        }
        if (!Utils::isUnset($request->outRefundNo)) {
            @$body['outRefundNo'] = $request->outRefundNo;
        }
        if (!Utils::isUnset($request->refundAmount)) {
            @$body['refundAmount'] = $request->refundAmount;
        }
        if (!Utils::isUnset($request->remark)) {
            @$body['remark'] = $request->remark;
        }
        if (!Utils::isUnset($request->subInstId)) {
            @$body['subInstId'] = $request->subInstId;
        }
        if (!Utils::isUnset($request->title)) {
            @$body['title'] = $request->title;
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

        return CreateAcquireRefundOrderResponse::fromMap($this->doROARequest('CreateAcquireRefundOrder', 'finance_1.0', 'HTTP', 'POST', 'AK', '/v1.0/finance/acquireOrders/refund', 'json', $req, $runtime));
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
        if (!Utils::isUnset($request->accountId)) {
            @$body['accountId'] = $request->accountId;
        }
        if (!Utils::isUnset($request->accountNo)) {
            @$body['accountNo'] = $request->accountNo;
        }
        if (!Utils::isUnset($request->batchRemark)) {
            @$body['batchRemark'] = $request->batchRemark;
        }
        if (!Utils::isUnset($request->batchTradeDetails)) {
            @$body['batchTradeDetails'] = $request->batchTradeDetails;
        }
        if (!Utils::isUnset($request->outBatchNo)) {
            @$body['outBatchNo'] = $request->outBatchNo;
        }
        if (!Utils::isUnset($request->staffId)) {
            @$body['staffId'] = $request->staffId;
        }
        if (!Utils::isUnset($request->totalAmount)) {
            @$body['totalAmount'] = $request->totalAmount;
        }
        if (!Utils::isUnset($request->totalCount)) {
            @$body['totalCount'] = $request->totalCount;
        }
        if (!Utils::isUnset($request->tradeTitle)) {
            @$body['tradeTitle'] = $request->tradeTitle;
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

        return CreateBatchTradeOrderResponse::fromMap($this->doROARequest('CreateBatchTradeOrder', 'finance_1.0', 'HTTP', 'POST', 'AK', '/v1.0/finance/batchTrades/orders', 'json', $req, $runtime));
    }

    /**
     * @param CreateSubInstitutionRequest $request
     *
     * @return CreateSubInstitutionResponse
     */
    public function createSubInstitution($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateSubInstitutionHeaders([]);

        return $this->createSubInstitutionWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateSubInstitutionRequest $request
     * @param CreateSubInstitutionHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return CreateSubInstitutionResponse
     */
    public function createSubInstitutionWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bindingAlipayLogonId)) {
            @$body['bindingAlipayLogonId'] = $request->bindingAlipayLogonId;
        }
        if (!Utils::isUnset($request->contactInfo)) {
            @$body['contactInfo'] = $request->contactInfo;
        }
        if (!Utils::isUnset($request->instId)) {
            @$body['instId'] = $request->instId;
        }
        if (!Utils::isUnset($request->legalPersonCertInfo)) {
            @$body['legalPersonCertInfo'] = $request->legalPersonCertInfo;
        }
        if (!Utils::isUnset($request->outTradeNo)) {
            @$body['outTradeNo'] = $request->outTradeNo;
        }
        if (!Utils::isUnset($request->payChannel)) {
            @$body['payChannel'] = $request->payChannel;
        }
        if (!Utils::isUnset($request->qualificationInfos)) {
            @$body['qualificationInfos'] = $request->qualificationInfos;
        }
        if (!Utils::isUnset($request->services)) {
            @$body['services'] = $request->services;
        }
        if (!Utils::isUnset($request->settleInfo)) {
            @$body['settleInfo'] = $request->settleInfo;
        }
        if (!Utils::isUnset($request->solution)) {
            @$body['solution'] = $request->solution;
        }
        if (!Utils::isUnset($request->subInstAddressInfo)) {
            @$body['subInstAddressInfo'] = $request->subInstAddressInfo;
        }
        if (!Utils::isUnset($request->subInstAuthInfo)) {
            @$body['subInstAuthInfo'] = $request->subInstAuthInfo;
        }
        if (!Utils::isUnset($request->subInstBasicInfo)) {
            @$body['subInstBasicInfo'] = $request->subInstBasicInfo;
        }
        if (!Utils::isUnset($request->subInstCertifyInfo)) {
            @$body['subInstCertifyInfo'] = $request->subInstCertifyInfo;
        }
        if (!Utils::isUnset($request->subInstId)) {
            @$body['subInstId'] = $request->subInstId;
        }
        if (!Utils::isUnset($request->subInstInvoiceInfo)) {
            @$body['subInstInvoiceInfo'] = $request->subInstInvoiceInfo;
        }
        if (!Utils::isUnset($request->subInstShopInfo)) {
            @$body['subInstShopInfo'] = $request->subInstShopInfo;
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

        return CreateSubInstitutionResponse::fromMap($this->doROARequest('CreateSubInstitution', 'finance_1.0', 'HTTP', 'POST', 'AK', '/v1.0/finance/institutions/subInstitutions', 'json', $req, $runtime));
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

        return CreateUserCodeInstanceResponse::fromMap($this->doROARequest('CreateUserCodeInstance', 'finance_1.0', 'HTTP', 'POST', 'AK', '/v1.0/finance/payCodes/userInstances', 'json', $req, $runtime));
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
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return DecodePayCodeResponse::fromMap($this->doROARequest('DecodePayCode', 'finance_1.0', 'HTTP', 'POST', 'AK', '/v1.0/finance/payCodes/decode', 'json', $req, $runtime));
    }

    /**
     * @param ModifySubInstitutionRequest $request
     *
     * @return ModifySubInstitutionResponse
     */
    public function modifySubInstitution($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ModifySubInstitutionHeaders([]);

        return $this->modifySubInstitutionWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ModifySubInstitutionRequest $request
     * @param ModifySubInstitutionHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return ModifySubInstitutionResponse
     */
    public function modifySubInstitutionWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bindingAlipayLogonId)) {
            @$body['bindingAlipayLogonId'] = $request->bindingAlipayLogonId;
        }
        if (!Utils::isUnset($request->contactInfo)) {
            @$body['contactInfo'] = $request->contactInfo;
        }
        if (!Utils::isUnset($request->instId)) {
            @$body['instId'] = $request->instId;
        }
        if (!Utils::isUnset($request->legalPersonCertInfo)) {
            @$body['legalPersonCertInfo'] = $request->legalPersonCertInfo;
        }
        if (!Utils::isUnset($request->outTradeNo)) {
            @$body['outTradeNo'] = $request->outTradeNo;
        }
        if (!Utils::isUnset($request->payChannel)) {
            @$body['payChannel'] = $request->payChannel;
        }
        if (!Utils::isUnset($request->qualificationInfos)) {
            @$body['qualificationInfos'] = $request->qualificationInfos;
        }
        if (!Utils::isUnset($request->services)) {
            @$body['services'] = $request->services;
        }
        if (!Utils::isUnset($request->settleInfo)) {
            @$body['settleInfo'] = $request->settleInfo;
        }
        if (!Utils::isUnset($request->subInstAddressInfo)) {
            @$body['subInstAddressInfo'] = $request->subInstAddressInfo;
        }
        if (!Utils::isUnset($request->subInstAuthInfo)) {
            @$body['subInstAuthInfo'] = $request->subInstAuthInfo;
        }
        if (!Utils::isUnset($request->subInstBasicInfo)) {
            @$body['subInstBasicInfo'] = $request->subInstBasicInfo;
        }
        if (!Utils::isUnset($request->subInstCertifyInfo)) {
            @$body['subInstCertifyInfo'] = $request->subInstCertifyInfo;
        }
        if (!Utils::isUnset($request->subInstId)) {
            @$body['subInstId'] = $request->subInstId;
        }
        if (!Utils::isUnset($request->subInstInvoiceInfo)) {
            @$body['subInstInvoiceInfo'] = $request->subInstInvoiceInfo;
        }
        if (!Utils::isUnset($request->subInstShopInfo)) {
            @$body['subInstShopInfo'] = $request->subInstShopInfo;
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

        return ModifySubInstitutionResponse::fromMap($this->doROARequest('ModifySubInstitution', 'finance_1.0', 'HTTP', 'POST', 'AK', '/v1.0/finance/institutions/subInstitutions/modify', 'json', $req, $runtime));
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

        return NotifyPayCodeRefundResultResponse::fromMap($this->doROARequest('NotifyPayCodeRefundResult', 'finance_1.0', 'HTTP', 'POST', 'AK', '/v1.0/finance/payCodes/refundResults/notify', 'json', $req, $runtime));
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

        return NotifyVerifyResultResponse::fromMap($this->doROARequest('NotifyVerifyResult', 'finance_1.0', 'HTTP', 'POST', 'AK', '/v1.0/finance/payCodes/verifyResults/notify', 'json', $req, $runtime));
    }

    /**
     * @param QueryAcquireRefundOrderRequest $request
     *
     * @return QueryAcquireRefundOrderResponse
     */
    public function queryAcquireRefundOrder($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryAcquireRefundOrderHeaders([]);

        return $this->queryAcquireRefundOrderWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryAcquireRefundOrderRequest $request
     * @param QueryAcquireRefundOrderHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return QueryAcquireRefundOrderResponse
     */
    public function queryAcquireRefundOrderWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->outRefundNo)) {
            @$query['outRefundNo'] = $request->outRefundNo;
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

        return QueryAcquireRefundOrderResponse::fromMap($this->doROARequest('QueryAcquireRefundOrder', 'finance_1.0', 'HTTP', 'GET', 'AK', '/v1.0/finance/acquireOrders/refunds', 'json', $req, $runtime));
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
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return QueryBatchTradeDetailListResponse::fromMap($this->doROARequest('QueryBatchTradeDetailList', 'finance_1.0', 'HTTP', 'GET', 'AK', '/v1.0/finance/batchTrades/details', 'json', $req, $runtime));
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
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return QueryBatchTradeOrderResponse::fromMap($this->doROARequest('QueryBatchTradeOrder', 'finance_1.0', 'HTTP', 'POST', 'AK', '/v1.0/finance/batchTrades/orders/query', 'json', $req, $runtime));
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
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return QueryPayAccountListResponse::fromMap($this->doROARequest('QueryPayAccountList', 'finance_1.0', 'HTTP', 'GET', 'AK', '/v1.0/finance/payAccounts', 'json', $req, $runtime));
    }

    /**
     * @param QueryRegisterOrderRequest $request
     *
     * @return QueryRegisterOrderResponse
     */
    public function queryRegisterOrder($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryRegisterOrderHeaders([]);

        return $this->queryRegisterOrderWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryRegisterOrderRequest $request
     * @param QueryRegisterOrderHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return QueryRegisterOrderResponse
     */
    public function queryRegisterOrderWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->instId)) {
            @$query['instId'] = $request->instId;
        }
        if (!Utils::isUnset($request->orderId)) {
            @$query['orderId'] = $request->orderId;
        }
        if (!Utils::isUnset($request->outTradeNo)) {
            @$query['outTradeNo'] = $request->outTradeNo;
        }
        if (!Utils::isUnset($request->subInstId)) {
            @$query['subInstId'] = $request->subInstId;
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

        return QueryRegisterOrderResponse::fromMap($this->doROARequest('QueryRegisterOrder', 'finance_1.0', 'HTTP', 'GET', 'AK', '/v1.0/finance/institutions/subInstitutions/orders', 'json', $req, $runtime));
    }

    /**
     * @param QueryUserAgreementRequest $request
     *
     * @return QueryUserAgreementResponse
     */
    public function queryUserAgreement($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryUserAgreementHeaders([]);

        return $this->queryUserAgreementWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryUserAgreementRequest $request
     * @param QueryUserAgreementHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return QueryUserAgreementResponse
     */
    public function queryUserAgreementWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->bizCode)) {
            @$query['bizCode'] = $request->bizCode;
        }
        if (!Utils::isUnset($request->bizScene)) {
            @$query['bizScene'] = $request->bizScene;
        }
        if (!Utils::isUnset($request->instId)) {
            @$query['instId'] = $request->instId;
        }
        if (!Utils::isUnset($request->subInstId)) {
            @$query['subInstId'] = $request->subInstId;
        }
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
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

        return QueryUserAgreementResponse::fromMap($this->doROARequest('QueryUserAgreement', 'finance_1.0', 'HTTP', 'GET', 'AK', '/v1.0/finance/userAgreements', 'json', $req, $runtime));
    }

    /**
     * @return QueryUserAlipayAccountResponse
     */
    public function queryUserAlipayAccount()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryUserAlipayAccountHeaders([]);

        return $this->queryUserAlipayAccountWithOptions($headers, $runtime);
    }

    /**
     * @param QueryUserAlipayAccountHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return QueryUserAlipayAccountResponse
     */
    public function queryUserAlipayAccountWithOptions($headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return QueryUserAlipayAccountResponse::fromMap($this->doROARequest('QueryUserAlipayAccount', 'finance_1.0', 'HTTP', 'GET', 'AK', '/v1.0/finance/userAlipayAccounts', 'json', $req, $runtime));
    }

    /**
     * @param QueryWithholdingOrderRequest $request
     *
     * @return QueryWithholdingOrderResponse
     */
    public function queryWithholdingOrder($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryWithholdingOrderHeaders([]);

        return $this->queryWithholdingOrderWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryWithholdingOrderRequest $request
     * @param QueryWithholdingOrderHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return QueryWithholdingOrderResponse
     */
    public function queryWithholdingOrderWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->outTradeNo)) {
            @$query['outTradeNo'] = $request->outTradeNo;
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

        return QueryWithholdingOrderResponse::fromMap($this->doROARequest('QueryWithholdingOrder', 'finance_1.0', 'HTTP', 'GET', 'AK', '/v1.0/finance/withholdingOrders', 'json', $req, $runtime));
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

        return SaveCorpPayCodeResponse::fromMap($this->doROARequest('SaveCorpPayCode', 'finance_1.0', 'HTTP', 'POST', 'AK', '/v1.0/finance/payCodes/corpSettings', 'json', $req, $runtime));
    }

    /**
     * @param UnsignUserAgreementRequest $request
     *
     * @return UnsignUserAgreementResponse
     */
    public function unsignUserAgreement($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UnsignUserAgreementHeaders([]);

        return $this->unsignUserAgreementWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UnsignUserAgreementRequest $request
     * @param UnsignUserAgreementHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return UnsignUserAgreementResponse
     */
    public function unsignUserAgreementWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->agreementNo)) {
            @$body['agreementNo'] = $request->agreementNo;
        }
        if (!Utils::isUnset($request->bizCode)) {
            @$body['bizCode'] = $request->bizCode;
        }
        if (!Utils::isUnset($request->bizScene)) {
            @$body['bizScene'] = $request->bizScene;
        }
        if (!Utils::isUnset($request->instId)) {
            @$body['instId'] = $request->instId;
        }
        if (!Utils::isUnset($request->subInstId)) {
            @$body['subInstId'] = $request->subInstId;
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

        return UnsignUserAgreementResponse::fromMap($this->doROARequest('UnsignUserAgreement', 'finance_1.0', 'HTTP', 'POST', 'AK', '/v1.0/finance/userAgreements/unsign', 'none', $req, $runtime));
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

        return UpateUserCodeInstanceResponse::fromMap($this->doROARequest('UpateUserCodeInstance', 'finance_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/finance/payCodes/userInstances', 'json', $req, $runtime));
    }

    /**
     * @param UpdateInvoiceVerifyStatusRequest $request
     *
     * @return UpdateInvoiceVerifyStatusResponse
     */
    public function updateInvoiceVerifyStatus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateInvoiceVerifyStatusHeaders([]);

        return $this->updateInvoiceVerifyStatusWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateInvoiceVerifyStatusRequest $request
     * @param UpdateInvoiceVerifyStatusHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return UpdateInvoiceVerifyStatusResponse
     */
    public function updateInvoiceVerifyStatusWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizId)) {
            @$body['bizId'] = $request->bizId;
        }
        if (!Utils::isUnset($request->checkingResult)) {
            @$body['checkingResult'] = $request->checkingResult;
        }
        if (!Utils::isUnset($request->checkingStatus)) {
            @$body['checkingStatus'] = $request->checkingStatus;
        }
        if (!Utils::isUnset($request->code)) {
            @$body['code'] = $request->code;
        }
        if (!Utils::isUnset($request->corpId)) {
            @$body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->extension)) {
            @$body['extension'] = $request->extension;
        }
        if (!Utils::isUnset($request->invoiceCode)) {
            @$body['invoiceCode'] = $request->invoiceCode;
        }
        if (!Utils::isUnset($request->invoiceNo)) {
            @$body['invoiceNo'] = $request->invoiceNo;
        }
        if (!Utils::isUnset($request->invoiceStatus)) {
            @$body['invoiceStatus'] = $request->invoiceStatus;
        }
        if (!Utils::isUnset($request->invoiceVerifyId)) {
            @$body['invoiceVerifyId'] = $request->invoiceVerifyId;
        }
        if (!Utils::isUnset($request->msg)) {
            @$body['msg'] = $request->msg;
        }
        if (!Utils::isUnset($request->unionId)) {
            @$body['unionId'] = $request->unionId;
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

        return UpdateInvoiceVerifyStatusResponse::fromMap($this->doROARequest('UpdateInvoiceVerifyStatus', 'finance_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/finance/invoices/verifyStatus', 'json', $req, $runtime));
    }

    /**
     * @param UploadInvoiceRequest $request
     *
     * @return UploadInvoiceResponse
     */
    public function uploadInvoice($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UploadInvoiceHeaders([]);

        return $this->uploadInvoiceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UploadInvoiceRequest $request
     * @param UploadInvoiceHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return UploadInvoiceResponse
     */
    public function uploadInvoiceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->extension)) {
            @$body['extension'] = $request->extension;
        }
        if (!Utils::isUnset($request->invoices)) {
            @$body['invoices'] = $request->invoices;
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

        return UploadInvoiceResponse::fromMap($this->doROARequest('UploadInvoice', 'finance_1.0', 'HTTP', 'POST', 'AK', '/v1.0/finance/invoices/upload', 'json', $req, $runtime));
    }

    /**
     * @param UploadInvoiceByAuthRequest $request
     *
     * @return UploadInvoiceByAuthResponse
     */
    public function uploadInvoiceByAuth($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UploadInvoiceByAuthHeaders([]);

        return $this->uploadInvoiceByAuthWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UploadInvoiceByAuthRequest $request
     * @param UploadInvoiceByAuthHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return UploadInvoiceByAuthResponse
     */
    public function uploadInvoiceByAuthWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->extension)) {
            @$body['extension'] = $request->extension;
        }
        if (!Utils::isUnset($request->invoices)) {
            @$body['invoices'] = $request->invoices;
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

        return UploadInvoiceByAuthResponse::fromMap($this->doROARequest('UploadInvoiceByAuth', 'finance_1.0', 'HTTP', 'POST', 'AK', '/v1.0/finance/invoices/authorizations/upload', 'json', $req, $runtime));
    }

    /**
     * @param UploadInvoiceByMobileRequest $request
     *
     * @return UploadInvoiceByMobileResponse
     */
    public function uploadInvoiceByMobile($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UploadInvoiceByMobileHeaders([]);

        return $this->uploadInvoiceByMobileWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UploadInvoiceByMobileRequest $request
     * @param UploadInvoiceByMobileHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return UploadInvoiceByMobileResponse
     */
    public function uploadInvoiceByMobileWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->invoices)) {
            @$body['invoices'] = $request->invoices;
        }
        if (!Utils::isUnset($request->mobile)) {
            @$body['mobile'] = $request->mobile;
        }
        if (!Utils::isUnset($request->mobileStateCode)) {
            @$body['mobileStateCode'] = $request->mobileStateCode;
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

        return UploadInvoiceByMobileResponse::fromMap($this->doROARequest('UploadInvoiceByMobile', 'finance_1.0', 'HTTP', 'POST', 'AK', '/v1.0/finance/invoices/mobiles/upload', 'json', $req, $runtime));
    }

    /**
     * @param UploadRegisterImageRequest $request
     *
     * @return UploadRegisterImageResponse
     */
    public function uploadRegisterImage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UploadRegisterImageHeaders([]);

        return $this->uploadRegisterImageWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UploadRegisterImageRequest $request
     * @param UploadRegisterImageHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return UploadRegisterImageResponse
     */
    public function uploadRegisterImageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->imageContent)) {
            @$body['imageContent'] = $request->imageContent;
        }
        if (!Utils::isUnset($request->imageName)) {
            @$body['imageName'] = $request->imageName;
        }
        if (!Utils::isUnset($request->imageType)) {
            @$body['imageType'] = $request->imageType;
        }
        if (!Utils::isUnset($request->instId)) {
            @$body['instId'] = $request->instId;
        }
        if (!Utils::isUnset($request->payChannel)) {
            @$body['payChannel'] = $request->payChannel;
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

        return UploadRegisterImageResponse::fromMap($this->doROARequest('UploadRegisterImage', 'finance_1.0', 'HTTP', 'POST', 'AK', '/v1.0/finance/institutions/images', 'json', $req, $runtime));
    }

    /**
     * @param UserAgreementPageSignRequest $request
     *
     * @return UserAgreementPageSignResponse
     */
    public function userAgreementPageSign($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UserAgreementPageSignHeaders([]);

        return $this->userAgreementPageSignWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UserAgreementPageSignRequest $request
     * @param UserAgreementPageSignHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return UserAgreementPageSignResponse
     */
    public function userAgreementPageSignWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizCode)) {
            @$body['bizCode'] = $request->bizCode;
        }
        if (!Utils::isUnset($request->bizScene)) {
            @$body['bizScene'] = $request->bizScene;
        }
        if (!Utils::isUnset($request->instId)) {
            @$body['instId'] = $request->instId;
        }
        if (!Utils::isUnset($request->payChannel)) {
            @$body['payChannel'] = $request->payChannel;
        }
        if (!Utils::isUnset($request->remark)) {
            @$body['remark'] = $request->remark;
        }
        if (!Utils::isUnset($request->returnUrl)) {
            @$body['returnUrl'] = $request->returnUrl;
        }
        if (!Utils::isUnset($request->signScene)) {
            @$body['signScene'] = $request->signScene;
        }
        if (!Utils::isUnset($request->subInstId)) {
            @$body['subInstId'] = $request->subInstId;
        }
        if (!Utils::isUnset($request->subMerchantName)) {
            @$body['subMerchantName'] = $request->subMerchantName;
        }
        if (!Utils::isUnset($request->subMerchantServiceDesc)) {
            @$body['subMerchantServiceDesc'] = $request->subMerchantServiceDesc;
        }
        if (!Utils::isUnset($request->subMerchantServiceName)) {
            @$body['subMerchantServiceName'] = $request->subMerchantServiceName;
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

        return UserAgreementPageSignResponse::fromMap($this->doROARequest('UserAgreementPageSign', 'finance_1.0', 'HTTP', 'POST', 'AK', '/v1.0/finance/userAgreements', 'json', $req, $runtime));
    }
}
