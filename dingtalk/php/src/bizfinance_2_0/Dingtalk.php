<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\BankGatewayInvokeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\BankGatewayInvokeRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\BankGatewayInvokeResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\BatchDeleteReceiptHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\BatchDeleteReceiptRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\BatchDeleteReceiptResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\BatchSyncBankReceiptHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\BatchSyncBankReceiptRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\BatchSyncBankReceiptResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\GetCategoryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\GetCategoryRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\GetCategoryResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\GetFinanceAccountHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\GetFinanceAccountRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\GetFinanceAccountResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\GetProjectHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\GetProjectRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\GetProjectResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\GetReceiptHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\GetReceiptRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\GetReceiptResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\GetSupplierHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\GetSupplierRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\GetSupplierResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\LinkCommonInvokeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\LinkCommonInvokeRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\LinkCommonInvokeResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\OrderBillingHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\OrderBillingRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\OrderBillingResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryCategoryByPageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryCategoryByPageRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryCategoryByPageResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryCustomerByPageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryCustomerByPageRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryCustomerByPageResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryEnterpriseAccountByPageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryEnterpriseAccountByPageRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryEnterpriseAccountByPageResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryInstancePaymentOrderDetailHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryInstancePaymentOrderDetailRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryInstancePaymentOrderDetailResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryPaymentRecallFileHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryPaymentRecallFileRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryPaymentRecallFileResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryPaymentStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryPaymentStatusRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryPaymentStatusResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryProjectByPageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryProjectByPageRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryProjectByPageResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QuerySupplierByPageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QuerySupplierByPageRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QuerySupplierByPageResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryUseNewInvoiceAppHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryUseNewInvoiceAppResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryUserRoleListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryUserRoleListRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryUserRoleListResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\SignEnterpriseAccountHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\SignEnterpriseAccountRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\SignEnterpriseAccountResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\SyncReceiptRecallHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\SyncReceiptRecallRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\SyncReceiptRecallResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\UpdateInstanceOrderInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\UpdateInstanceOrderInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\UpdateInstanceOrderInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\UpdateInstanceOrderInfoShrinkRequest;
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
        $this->_productId    = 'dingtalk';
        $gatewayClient       = new Client();
        $this->_spi          = $gatewayClient;
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @summary 银行接入层通用接口
     *  *
     * @param BankGatewayInvokeRequest $request BankGatewayInvokeRequest
     * @param BankGatewayInvokeHeaders $headers BankGatewayInvokeHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return BankGatewayInvokeResponse BankGatewayInvokeResponse
     */
    public function bankGatewayInvokeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->actionType)) {
            $body['actionType'] = $request->actionType;
        }
        if (!Utils::isUnset($request->inputData)) {
            $body['inputData'] = $request->inputData;
        }
        if (!Utils::isUnset($request->url)) {
            $body['url'] = $request->url;
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
            'action'      => 'BankGatewayInvoke',
            'version'     => 'bizfinance_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/bizfinance/bankGateways/invoke',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BankGatewayInvokeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 银行接入层通用接口
     *  *
     * @param BankGatewayInvokeRequest $request BankGatewayInvokeRequest
     *
     * @return BankGatewayInvokeResponse BankGatewayInvokeResponse
     */
    public function bankGatewayInvoke($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BankGatewayInvokeHeaders([]);

        return $this->bankGatewayInvokeWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量删除智能财务单据
     *  *
     * @param BatchDeleteReceiptRequest $request BatchDeleteReceiptRequest
     * @param BatchDeleteReceiptHeaders $headers BatchDeleteReceiptHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return BatchDeleteReceiptResponse BatchDeleteReceiptResponse
     */
    public function batchDeleteReceiptWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->instanceIdList)) {
            $body['instanceIdList'] = $request->instanceIdList;
        }
        if (!Utils::isUnset($request->operator)) {
            $body['operator'] = $request->operator;
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
            'action'      => 'BatchDeleteReceipt',
            'version'     => 'bizfinance_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/bizfinance/instances/remove',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BatchDeleteReceiptResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量删除智能财务单据
     *  *
     * @param BatchDeleteReceiptRequest $request BatchDeleteReceiptRequest
     *
     * @return BatchDeleteReceiptResponse BatchDeleteReceiptResponse
     */
    public function batchDeleteReceipt($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchDeleteReceiptHeaders([]);

        return $this->batchDeleteReceiptWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量同步银行回单
     *  *
     * @param BatchSyncBankReceiptRequest $request BatchSyncBankReceiptRequest
     * @param BatchSyncBankReceiptHeaders $headers BatchSyncBankReceiptHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return BatchSyncBankReceiptResponse BatchSyncBankReceiptResponse
     */
    public function batchSyncBankReceiptWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => Utils::toArray($request->body),
        ]);
        $params = new Params([
            'action'      => 'BatchSyncBankReceipt',
            'version'     => 'bizfinance_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/bizfinance/receipts/batchSync',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BatchSyncBankReceiptResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量同步银行回单
     *  *
     * @param BatchSyncBankReceiptRequest $request BatchSyncBankReceiptRequest
     *
     * @return BatchSyncBankReceiptResponse BatchSyncBankReceiptResponse
     */
    public function batchSyncBankReceipt($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchSyncBankReceiptHeaders([]);

        return $this->batchSyncBankReceiptWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取费用类别
     *  *
     * @param GetCategoryRequest $request GetCategoryRequest
     * @param GetCategoryHeaders $headers GetCategoryHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return GetCategoryResponse GetCategoryResponse
     */
    public function getCategoryWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->code)) {
            $query['code'] = $request->code;
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
            'action'      => 'GetCategory',
            'version'     => 'bizfinance_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/bizfinance/categories',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetCategoryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取费用类别
     *  *
     * @param GetCategoryRequest $request GetCategoryRequest
     *
     * @return GetCategoryResponse GetCategoryResponse
     */
    public function getCategory($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetCategoryHeaders([]);

        return $this->getCategoryWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取企业账户
     *  *
     * @param GetFinanceAccountRequest $request GetFinanceAccountRequest
     * @param GetFinanceAccountHeaders $headers GetFinanceAccountHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return GetFinanceAccountResponse GetFinanceAccountResponse
     */
    public function getFinanceAccountWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->accountCode)) {
            $query['accountCode'] = $request->accountCode;
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
            'action'      => 'GetFinanceAccount',
            'version'     => 'bizfinance_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/bizfinance/financeAccounts',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetFinanceAccountResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取企业账户
     *  *
     * @param GetFinanceAccountRequest $request GetFinanceAccountRequest
     *
     * @return GetFinanceAccountResponse GetFinanceAccountResponse
     */
    public function getFinanceAccount($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetFinanceAccountHeaders([]);

        return $this->getFinanceAccountWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取单条项目
     *  *
     * @param GetProjectRequest $request GetProjectRequest
     * @param GetProjectHeaders $headers GetProjectHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return GetProjectResponse GetProjectResponse
     */
    public function getProjectWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->code)) {
            $query['code'] = $request->code;
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
            'action'      => 'GetProject',
            'version'     => 'bizfinance_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/bizfinance/projects',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetProjectResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取单条项目
     *  *
     * @param GetProjectRequest $request GetProjectRequest
     *
     * @return GetProjectResponse GetProjectResponse
     */
    public function getProject($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetProjectHeaders([]);

        return $this->getProjectWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取智能财务单据详情
     *  *
     * @param GetReceiptRequest $request GetReceiptRequest
     * @param GetReceiptHeaders $headers GetReceiptHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return GetReceiptResponse GetReceiptResponse
     */
    public function getReceiptWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->code)) {
            $query['code'] = $request->code;
        }
        if (!Utils::isUnset($request->modelId)) {
            $query['modelId'] = $request->modelId;
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
            'action'      => 'GetReceipt',
            'version'     => 'bizfinance_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/bizfinance/receipts/details',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetReceiptResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取智能财务单据详情
     *  *
     * @param GetReceiptRequest $request GetReceiptRequest
     *
     * @return GetReceiptResponse GetReceiptResponse
     */
    public function getReceipt($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetReceiptHeaders([]);

        return $this->getReceiptWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取智能财务应用内维护的供应商信息
     *  *
     * @param GetSupplierRequest $request GetSupplierRequest
     * @param GetSupplierHeaders $headers GetSupplierHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return GetSupplierResponse GetSupplierResponse
     */
    public function getSupplierWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->code)) {
            $query['code'] = $request->code;
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
            'action'      => 'GetSupplier',
            'version'     => 'bizfinance_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/bizfinance/suppliers/details',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetSupplierResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取智能财务应用内维护的供应商信息
     *  *
     * @param GetSupplierRequest $request GetSupplierRequest
     *
     * @return GetSupplierResponse GetSupplierResponse
     */
    public function getSupplier($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSupplierHeaders([]);

        return $this->getSupplierWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 根据不同的bizType查询不同的数据
     *  *
     * @param LinkCommonInvokeRequest $request LinkCommonInvokeRequest
     * @param LinkCommonInvokeHeaders $headers LinkCommonInvokeHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return LinkCommonInvokeResponse LinkCommonInvokeResponse
     */
    public function linkCommonInvokeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizType)) {
            $body['bizType'] = $request->bizType;
        }
        if (!Utils::isUnset($request->data)) {
            $body['data'] = $request->data;
        }
        if (!Utils::isUnset($request->invokeId)) {
            $body['invokeId'] = $request->invokeId;
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
            'action'      => 'LinkCommonInvoke',
            'version'     => 'bizfinance_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/bizfinance/link/bizTypes/invoke',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return LinkCommonInvokeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据不同的bizType查询不同的数据
     *  *
     * @param LinkCommonInvokeRequest $request LinkCommonInvokeRequest
     *
     * @return LinkCommonInvokeResponse LinkCommonInvokeResponse
     */
    public function linkCommonInvoke($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new LinkCommonInvokeHeaders([]);

        return $this->linkCommonInvokeWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 订单开票
     *  *
     * @param OrderBillingRequest $request OrderBillingRequest
     * @param OrderBillingHeaders $headers OrderBillingHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return OrderBillingResponse OrderBillingResponse
     */
    public function orderBillingWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->additionInfos)) {
            $body['additionInfos'] = $request->additionInfos;
        }
        if (!Utils::isUnset($request->appKey)) {
            $body['appKey'] = $request->appKey;
        }
        if (!Utils::isUnset($request->applyPerson)) {
            $body['applyPerson'] = $request->applyPerson;
        }
        if (!Utils::isUnset($request->invoiceRemark)) {
            $body['invoiceRemark'] = $request->invoiceRemark;
        }
        if (!Utils::isUnset($request->invoiceType)) {
            $body['invoiceType'] = $request->invoiceType;
        }
        if (!Utils::isUnset($request->isNaturalPerson)) {
            $body['isNaturalPerson'] = $request->isNaturalPerson;
        }
        if (!Utils::isUnset($request->operator)) {
            $body['operator'] = $request->operator;
        }
        if (!Utils::isUnset($request->orderId)) {
            $body['orderId'] = $request->orderId;
        }
        if (!Utils::isUnset($request->payee)) {
            $body['payee'] = $request->payee;
        }
        if (!Utils::isUnset($request->phone)) {
            $body['phone'] = $request->phone;
        }
        if (!Utils::isUnset($request->products)) {
            $body['products'] = $request->products;
        }
        if (!Utils::isUnset($request->purchaserAddress)) {
            $body['purchaserAddress'] = $request->purchaserAddress;
        }
        if (!Utils::isUnset($request->purchaserBankAccount)) {
            $body['purchaserBankAccount'] = $request->purchaserBankAccount;
        }
        if (!Utils::isUnset($request->purchaserBankName)) {
            $body['purchaserBankName'] = $request->purchaserBankName;
        }
        if (!Utils::isUnset($request->purchaserName)) {
            $body['purchaserName'] = $request->purchaserName;
        }
        if (!Utils::isUnset($request->purchaserTaxNo)) {
            $body['purchaserTaxNo'] = $request->purchaserTaxNo;
        }
        if (!Utils::isUnset($request->purchaserTel)) {
            $body['purchaserTel'] = $request->purchaserTel;
        }
        if (!Utils::isUnset($request->remark)) {
            $body['remark'] = $request->remark;
        }
        if (!Utils::isUnset($request->reviewer)) {
            $body['reviewer'] = $request->reviewer;
        }
        if (!Utils::isUnset($request->signature)) {
            $body['signature'] = $request->signature;
        }
        if (!Utils::isUnset($request->taxSign)) {
            $body['taxSign'] = $request->taxSign;
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
            'action'      => 'OrderBilling',
            'version'     => 'bizfinance_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/bizfinance/billings/order',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return OrderBillingResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 订单开票
     *  *
     * @param OrderBillingRequest $request OrderBillingRequest
     *
     * @return OrderBillingResponse OrderBillingResponse
     */
    public function orderBilling($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new OrderBillingHeaders([]);

        return $this->orderBillingWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量获取费用类别
     *  *
     * @param QueryCategoryByPageRequest $request QueryCategoryByPageRequest
     * @param QueryCategoryByPageHeaders $headers QueryCategoryByPageHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryCategoryByPageResponse QueryCategoryByPageResponse
     */
    public function queryCategoryByPageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->type)) {
            $query['type'] = $request->type;
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
            'action'      => 'QueryCategoryByPage',
            'version'     => 'bizfinance_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/bizfinance/categories/batch',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryCategoryByPageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量获取费用类别
     *  *
     * @param QueryCategoryByPageRequest $request QueryCategoryByPageRequest
     *
     * @return QueryCategoryByPageResponse QueryCategoryByPageResponse
     */
    public function queryCategoryByPage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryCategoryByPageHeaders([]);

        return $this->queryCategoryByPageWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 分页批量获取智能财务应用内维护的客户信息
     *  *
     * @param QueryCustomerByPageRequest $request QueryCustomerByPageRequest
     * @param QueryCustomerByPageHeaders $headers QueryCustomerByPageHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryCustomerByPageResponse QueryCustomerByPageResponse
     */
    public function queryCustomerByPageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
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
            'action'      => 'QueryCustomerByPage',
            'version'     => 'bizfinance_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/bizfinance/customers/batch',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryCustomerByPageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 分页批量获取智能财务应用内维护的客户信息
     *  *
     * @param QueryCustomerByPageRequest $request QueryCustomerByPageRequest
     *
     * @return QueryCustomerByPageResponse QueryCustomerByPageResponse
     */
    public function queryCustomerByPage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryCustomerByPageHeaders([]);

        return $this->queryCustomerByPageWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量获取企业账户
     *  *
     * @param QueryEnterpriseAccountByPageRequest $request QueryEnterpriseAccountByPageRequest
     * @param QueryEnterpriseAccountByPageHeaders $headers QueryEnterpriseAccountByPageHeaders
     * @param RuntimeOptions                      $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryEnterpriseAccountByPageResponse QueryEnterpriseAccountByPageResponse
     */
    public function queryEnterpriseAccountByPageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
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
            'action'      => 'QueryEnterpriseAccountByPage',
            'version'     => 'bizfinance_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/bizfinance/financeAccounts/batch',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryEnterpriseAccountByPageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量获取企业账户
     *  *
     * @param QueryEnterpriseAccountByPageRequest $request QueryEnterpriseAccountByPageRequest
     *
     * @return QueryEnterpriseAccountByPageResponse QueryEnterpriseAccountByPageResponse
     */
    public function queryEnterpriseAccountByPage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryEnterpriseAccountByPageHeaders([]);

        return $this->queryEnterpriseAccountByPageWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询支付订单详情
     *  *
     * @param string                                 $instanceId
     * @param QueryInstancePaymentOrderDetailRequest $request    QueryInstancePaymentOrderDetailRequest
     * @param QueryInstancePaymentOrderDetailHeaders $headers    QueryInstancePaymentOrderDetailHeaders
     * @param RuntimeOptions                         $runtime    runtime options for this request RuntimeOptions
     *
     * @return QueryInstancePaymentOrderDetailResponse QueryInstancePaymentOrderDetailResponse
     */
    public function queryInstancePaymentOrderDetailWithOptions($instanceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->orderNo)) {
            $query['orderNo'] = $request->orderNo;
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
            'action'      => 'QueryInstancePaymentOrderDetail',
            'version'     => 'bizfinance_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/bizfinance/instances/' . $instanceId . '/paymentOrders/details',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryInstancePaymentOrderDetailResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询支付订单详情
     *  *
     * @param string                                 $instanceId
     * @param QueryInstancePaymentOrderDetailRequest $request    QueryInstancePaymentOrderDetailRequest
     *
     * @return QueryInstancePaymentOrderDetailResponse QueryInstancePaymentOrderDetailResponse
     */
    public function queryInstancePaymentOrderDetail($instanceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryInstancePaymentOrderDetailHeaders([]);

        return $this->queryInstancePaymentOrderDetailWithOptions($instanceId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询支付回单信息
     *  *
     * @param string                        $instanceId
     * @param QueryPaymentRecallFileRequest $request    QueryPaymentRecallFileRequest
     * @param QueryPaymentRecallFileHeaders $headers    QueryPaymentRecallFileHeaders
     * @param RuntimeOptions                $runtime    runtime options for this request RuntimeOptions
     *
     * @return QueryPaymentRecallFileResponse QueryPaymentRecallFileResponse
     */
    public function queryPaymentRecallFileWithOptions($instanceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
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
            'action'      => 'QueryPaymentRecallFile',
            'version'     => 'bizfinance_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/bizfinance/payments/recallFiles/' . $instanceId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryPaymentRecallFileResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询支付回单信息
     *  *
     * @param string                        $instanceId
     * @param QueryPaymentRecallFileRequest $request    QueryPaymentRecallFileRequest
     *
     * @return QueryPaymentRecallFileResponse QueryPaymentRecallFileResponse
     */
    public function queryPaymentRecallFile($instanceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryPaymentRecallFileHeaders([]);

        return $this->queryPaymentRecallFileWithOptions($instanceId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询支付订单的状态
     *  *
     * @param QueryPaymentStatusRequest $request QueryPaymentStatusRequest
     * @param QueryPaymentStatusHeaders $headers QueryPaymentStatusHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryPaymentStatusResponse QueryPaymentStatusResponse
     */
    public function queryPaymentStatusWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->instanceId)) {
            $query['instanceId'] = $request->instanceId;
        }
        if (!Utils::isUnset($request->orderNo)) {
            $query['orderNo'] = $request->orderNo;
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
            'action'      => 'QueryPaymentStatus',
            'version'     => 'bizfinance_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/bizfinance/payments/statuses',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryPaymentStatusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询支付订单的状态
     *  *
     * @param QueryPaymentStatusRequest $request QueryPaymentStatusRequest
     *
     * @return QueryPaymentStatusResponse QueryPaymentStatusResponse
     */
    public function queryPaymentStatus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryPaymentStatusHeaders([]);

        return $this->queryPaymentStatusWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量获取项目信息
     *  *
     * @param QueryProjectByPageRequest $request QueryProjectByPageRequest
     * @param QueryProjectByPageHeaders $headers QueryProjectByPageHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryProjectByPageResponse QueryProjectByPageResponse
     */
    public function queryProjectByPageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
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
            'action'      => 'QueryProjectByPage',
            'version'     => 'bizfinance_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/bizfinance/projects/batch',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryProjectByPageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量获取项目信息
     *  *
     * @param QueryProjectByPageRequest $request QueryProjectByPageRequest
     *
     * @return QueryProjectByPageResponse QueryProjectByPageResponse
     */
    public function queryProjectByPage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryProjectByPageHeaders([]);

        return $this->queryProjectByPageWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 分页批量获取智能财务应用内维护的供应商信息
     *  *
     * @param QuerySupplierByPageRequest $request QuerySupplierByPageRequest
     * @param QuerySupplierByPageHeaders $headers QuerySupplierByPageHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return QuerySupplierByPageResponse QuerySupplierByPageResponse
     */
    public function querySupplierByPageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
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
            'action'      => 'QuerySupplierByPage',
            'version'     => 'bizfinance_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/bizfinance/suppliers',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QuerySupplierByPageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 分页批量获取智能财务应用内维护的供应商信息
     *  *
     * @param QuerySupplierByPageRequest $request QuerySupplierByPageRequest
     *
     * @return QuerySupplierByPageResponse QuerySupplierByPageResponse
     */
    public function querySupplierByPage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QuerySupplierByPageHeaders([]);

        return $this->querySupplierByPageWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询组织是否命中走新发票应用
     *  *
     * @param QueryUseNewInvoiceAppHeaders $headers QueryUseNewInvoiceAppHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryUseNewInvoiceAppResponse QueryUseNewInvoiceAppResponse
     */
    public function queryUseNewInvoiceAppWithOptions($headers, $runtime)
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
            'action'      => 'QueryUseNewInvoiceApp',
            'version'     => 'bizfinance_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/bizfinance/invoice/appGray',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryUseNewInvoiceAppResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询组织是否命中走新发票应用
     *  *
     * @return QueryUseNewInvoiceAppResponse QueryUseNewInvoiceAppResponse
     */
    public function queryUseNewInvoiceApp()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryUseNewInvoiceAppHeaders([]);

        return $this->queryUseNewInvoiceAppWithOptions($headers, $runtime);
    }

    /**
     * @summary 查询用户角色成员，支持分页，可获取某个企业主体下的角色成员
     *  *
     * @param QueryUserRoleListRequest $request QueryUserRoleListRequest
     * @param QueryUserRoleListHeaders $headers QueryUserRoleListHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryUserRoleListResponse QueryUserRoleListResponse
     */
    public function queryUserRoleListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->companyCode)) {
            $query['companyCode'] = $request->companyCode;
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
            'action'      => 'QueryUserRoleList',
            'version'     => 'bizfinance_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/bizfinance/users/roles',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryUserRoleListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询用户角色成员，支持分页，可获取某个企业主体下的角色成员
     *  *
     * @param QueryUserRoleListRequest $request QueryUserRoleListRequest
     *
     * @return QueryUserRoleListResponse QueryUserRoleListResponse
     */
    public function queryUserRoleList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryUserRoleListHeaders([]);

        return $this->queryUserRoleListWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 签约企业账户
     *  *
     * @param SignEnterpriseAccountRequest $request SignEnterpriseAccountRequest
     * @param SignEnterpriseAccountHeaders $headers SignEnterpriseAccountHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return SignEnterpriseAccountResponse SignEnterpriseAccountResponse
     */
    public function signEnterpriseAccountWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->bankCardNo)) {
            $query['bankCardNo'] = $request->bankCardNo;
        }
        if (!Utils::isUnset($request->bankOpenId)) {
            $query['bankOpenId'] = $request->bankOpenId;
        }
        if (!Utils::isUnset($request->channelType)) {
            $query['channelType'] = $request->channelType;
        }
        if (!Utils::isUnset($request->operator)) {
            $query['operator'] = $request->operator;
        }
        if (!Utils::isUnset($request->signOperateType)) {
            $query['signOperateType'] = $request->signOperateType;
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
            'action'      => 'SignEnterpriseAccount',
            'version'     => 'bizfinance_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/bizfinance/enterpriseAccounts/sign',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SignEnterpriseAccountResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 签约企业账户
     *  *
     * @param SignEnterpriseAccountRequest $request SignEnterpriseAccountRequest
     *
     * @return SignEnterpriseAccountResponse SignEnterpriseAccountResponse
     */
    public function signEnterpriseAccount($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SignEnterpriseAccountHeaders([]);

        return $this->signEnterpriseAccountWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 发送银企支付回单文件信息
     *  *
     * @param SyncReceiptRecallRequest $request SyncReceiptRecallRequest
     * @param SyncReceiptRecallHeaders $headers SyncReceiptRecallHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return SyncReceiptRecallResponse SyncReceiptRecallResponse
     */
    public function syncReceiptRecallWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->fileDownloadUrl)) {
            $query['fileDownloadUrl'] = $request->fileDownloadUrl;
        }
        if (!Utils::isUnset($request->fileName)) {
            $query['fileName'] = $request->fileName;
        }
        if (!Utils::isUnset($request->orderNo)) {
            $query['orderNo'] = $request->orderNo;
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
            'action'      => 'SyncReceiptRecall',
            'version'     => 'bizfinance_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/bizfinance/receipts/syncRecall',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SyncReceiptRecallResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 发送银企支付回单文件信息
     *  *
     * @param SyncReceiptRecallRequest $request SyncReceiptRecallRequest
     *
     * @return SyncReceiptRecallResponse SyncReceiptRecallResponse
     */
    public function syncReceiptRecall($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SyncReceiptRecallHeaders([]);

        return $this->syncReceiptRecallWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新单据的支付状态
     *  *
     * @param string                         $instanceId
     * @param UpdateInstanceOrderInfoRequest $tmpReq     UpdateInstanceOrderInfoRequest
     * @param UpdateInstanceOrderInfoHeaders $headers    UpdateInstanceOrderInfoHeaders
     * @param RuntimeOptions                 $runtime    runtime options for this request RuntimeOptions
     *
     * @return UpdateInstanceOrderInfoResponse UpdateInstanceOrderInfoResponse
     */
    public function updateInstanceOrderInfoWithOptions($instanceId, $tmpReq, $headers, $runtime)
    {
        Utils::validateModel($tmpReq);
        $request = new UpdateInstanceOrderInfoShrinkRequest([]);
        OpenApiUtilClient::convert($tmpReq, $request);
        if (!Utils::isUnset($tmpReq->payerBank)) {
            $request->payerBankShrink = OpenApiUtilClient::arrayToStringWithSpecifiedStyle($tmpReq->payerBank, 'payerBank', 'json');
        }
        $query = [];
        if (!Utils::isUnset($request->failReason)) {
            $query['failReason'] = $request->failReason;
        }
        if (!Utils::isUnset($request->orderNo)) {
            $query['orderNo'] = $request->orderNo;
        }
        if (!Utils::isUnset($request->outOrderNo)) {
            $query['outOrderNo'] = $request->outOrderNo;
        }
        if (!Utils::isUnset($request->payerBankShrink)) {
            $query['payerBank'] = $request->payerBankShrink;
        }
        if (!Utils::isUnset($request->paymentTime)) {
            $query['paymentTime'] = $request->paymentTime;
        }
        if (!Utils::isUnset($request->status)) {
            $query['status'] = $request->status;
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
            'action'      => 'UpdateInstanceOrderInfo',
            'version'     => 'bizfinance_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/bizfinance/instances/' . $instanceId . '/paymentOrders/states',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateInstanceOrderInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新单据的支付状态
     *  *
     * @param string                         $instanceId
     * @param UpdateInstanceOrderInfoRequest $request    UpdateInstanceOrderInfoRequest
     *
     * @return UpdateInstanceOrderInfoResponse UpdateInstanceOrderInfoResponse
     */
    public function updateInstanceOrderInfo($instanceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateInstanceOrderInfoHeaders([]);

        return $this->updateInstanceOrderInfoWithOptions($instanceId, $request, $headers, $runtime);
    }
}
