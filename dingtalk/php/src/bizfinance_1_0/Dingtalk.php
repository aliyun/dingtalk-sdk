<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\BatchAddInvoiceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\BatchAddInvoiceRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\BatchAddInvoiceResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\BatchCreateCustomerHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\BatchCreateCustomerRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\BatchCreateCustomerResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\CheckVoucherStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\CheckVoucherStatusRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\CheckVoucherStatusResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\CreateCustomerHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\CreateCustomerRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\CreateCustomerResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\CreateReceiptHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\CreateReceiptRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\CreateReceiptResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\DeleteReceiptHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\DeleteReceiptRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\DeleteReceiptResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\GetBookkeepingUserListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\GetBookkeepingUserListResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\GetCategoryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\GetCategoryRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\GetCategoryResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\GetCustomerHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\GetCustomerRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\GetCustomerResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\GetFinanceAccountHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\GetFinanceAccountRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\GetFinanceAccountResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\GetInvoiceByPageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\GetInvoiceByPageRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\GetInvoiceByPageResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\GetInvoiceByPageShrinkRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\GetIsNewVersionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\GetIsNewVersionResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\GetProductHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\GetProductRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\GetProductResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\GetProjectHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\GetProjectRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\GetProjectResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\GetReceiptHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\GetReceiptRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\GetReceiptResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\GetSupplierHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\GetSupplierRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\GetSupplierResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\ProfessionBenefitConsumeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\ProfessionBenefitConsumeRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\ProfessionBenefitConsumeResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryCategoryByPageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryCategoryByPageRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryCategoryByPageResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryCustomerByPageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryCustomerByPageRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryCustomerByPageResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryCustomerInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryCustomerInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryCustomerInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryEnterpriseAccountByPageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryEnterpriseAccountByPageRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryEnterpriseAccountByPageResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryFinanceCompanyInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryFinanceCompanyInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryInvoiceRelationCountHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryInvoiceRelationCountResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryPermissionByUserIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryPermissionByUserIdRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryPermissionByUserIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryPermissionRoleMemberHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryPermissionRoleMemberRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryPermissionRoleMemberResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryProductByPageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryProductByPageRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryProductByPageResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryProjectByPageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryProjectByPageRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryProjectByPageResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryReceiptForInvoiceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryReceiptForInvoiceRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryReceiptForInvoiceResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryReceiptsBaseInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryReceiptsBaseInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryReceiptsBaseInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryReceiptsByPageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryReceiptsByPageRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryReceiptsByPageResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QuerySupplierByPageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QuerySupplierByPageRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QuerySupplierByPageResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryUserRoleListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryUserRoleListRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryUserRoleListResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UnbindApplyReceiptAndInvoiceRelatedHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UnbindApplyReceiptAndInvoiceRelatedRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UnbindApplyReceiptAndInvoiceRelatedResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateApplyReceiptAndInvoiceRelatedHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateApplyReceiptAndInvoiceRelatedRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateApplyReceiptAndInvoiceRelatedResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateDigitalInvoiceOrgInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateDigitalInvoiceOrgInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateDigitalInvoiceOrgInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateFinanceCompanyInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateFinanceCompanyInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateFinanceCompanyInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceAbandonStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceAbandonStatusRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceAbandonStatusResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceAccountingPeriodDateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceAccountingPeriodDateRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceAccountingPeriodDateResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceAccountingStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceAccountingStatusRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceAccountingStatusResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceAccountPeriodHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceAccountPeriodRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceAccountPeriodResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceAndReceiptRelatedHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceAndReceiptRelatedRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceAndReceiptRelatedResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceIgnoreStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceIgnoreStatusRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceIgnoreStatusResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceVerifyStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceVerifyStatusRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceVerifyStatusResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceVoucherStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceVoucherStatusRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceVoucherStatusResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateReceiptHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateReceiptRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateReceiptResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateReceiptVoucherStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateReceiptVoucherStatusRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateReceiptVoucherStatusResponse;
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
     * @param BatchAddInvoiceRequest $request
     *
     * @return BatchAddInvoiceResponse
     */
    public function batchAddInvoice($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchAddInvoiceHeaders([]);

        return $this->batchAddInvoiceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param BatchAddInvoiceRequest $request
     * @param BatchAddInvoiceHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return BatchAddInvoiceResponse
     */
    public function batchAddInvoiceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->generalInvoiceVOList)) {
            @$body['generalInvoiceVOList'] = $request->generalInvoiceVOList;
        }
        if (!Utils::isUnset($request->operator)) {
            @$body['operator'] = $request->operator;
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

        return BatchAddInvoiceResponse::fromMap($this->doROARequest('BatchAddInvoice', 'bizfinance_1.0', 'HTTP', 'POST', 'AK', '/v1.0/bizfinance/invoices/batch', 'json', $req, $runtime));
    }

    /**
     * @param BatchCreateCustomerRequest $request
     *
     * @return BatchCreateCustomerResponse
     */
    public function batchCreateCustomer($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchCreateCustomerHeaders([]);

        return $this->batchCreateCustomerWithOptions($request, $headers, $runtime);
    }

    /**
     * @param BatchCreateCustomerRequest $request
     * @param BatchCreateCustomerHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return BatchCreateCustomerResponse
     */
    public function batchCreateCustomerWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->createCustomerRequestList)) {
            @$body['createCustomerRequestList'] = $request->createCustomerRequestList;
        }
        if (!Utils::isUnset($request->operator)) {
            @$body['operator'] = $request->operator;
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

        return BatchCreateCustomerResponse::fromMap($this->doROARequest('BatchCreateCustomer', 'bizfinance_1.0', 'HTTP', 'POST', 'AK', '/v1.0/bizfinance/auxiliaries/batch', 'json', $req, $runtime));
    }

    /**
     * @param CheckVoucherStatusRequest $request
     *
     * @return CheckVoucherStatusResponse
     */
    public function checkVoucherStatus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CheckVoucherStatusHeaders([]);

        return $this->checkVoucherStatusWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CheckVoucherStatusRequest $request
     * @param CheckVoucherStatusHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return CheckVoucherStatusResponse
     */
    public function checkVoucherStatusWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->endTime)) {
            @$body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->financeType)) {
            @$body['financeType'] = $request->financeType;
        }
        if (!Utils::isUnset($request->invoiceCode)) {
            @$body['invoiceCode'] = $request->invoiceCode;
        }
        if (!Utils::isUnset($request->invoiceNo)) {
            @$body['invoiceNo'] = $request->invoiceNo;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            @$body['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->startTime)) {
            @$body['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->taxNo)) {
            @$body['taxNo'] = $request->taxNo;
        }
        if (!Utils::isUnset($request->verifyStatus)) {
            @$body['verifyStatus'] = $request->verifyStatus;
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

        return CheckVoucherStatusResponse::fromMap($this->doROARequest('CheckVoucherStatus', 'bizfinance_1.0', 'HTTP', 'POST', 'AK', '/v1.0/bizfinance/invoices/checkVoucherStatus/query', 'json', $req, $runtime));
    }

    /**
     * @param CreateCustomerRequest $request
     *
     * @return CreateCustomerResponse
     */
    public function createCustomer($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateCustomerHeaders([]);

        return $this->createCustomerWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateCustomerRequest $request
     * @param CreateCustomerHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return CreateCustomerResponse
     */
    public function createCustomerWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->creator)) {
            @$body['creator'] = $request->creator;
        }
        if (!Utils::isUnset($request->description)) {
            @$body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->name)) {
            @$body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->purchaserAccount)) {
            @$body['purchaserAccount'] = $request->purchaserAccount;
        }
        if (!Utils::isUnset($request->purchaserAddress)) {
            @$body['purchaserAddress'] = $request->purchaserAddress;
        }
        if (!Utils::isUnset($request->purchaserBankName)) {
            @$body['purchaserBankName'] = $request->purchaserBankName;
        }
        if (!Utils::isUnset($request->purchaserName)) {
            @$body['purchaserName'] = $request->purchaserName;
        }
        if (!Utils::isUnset($request->purchaserTaxNo)) {
            @$body['purchaserTaxNo'] = $request->purchaserTaxNo;
        }
        if (!Utils::isUnset($request->purchaserTel)) {
            @$body['purchaserTel'] = $request->purchaserTel;
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

        return CreateCustomerResponse::fromMap($this->doROARequest('CreateCustomer', 'bizfinance_1.0', 'HTTP', 'POST', 'AK', '/v1.0/bizfinance/auxiliaries/customers', 'json', $req, $runtime));
    }

    /**
     * @param CreateReceiptRequest $request
     *
     * @return CreateReceiptResponse
     */
    public function createReceipt($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateReceiptHeaders([]);

        return $this->createReceiptWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateReceiptRequest $request
     * @param CreateReceiptHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return CreateReceiptResponse
     */
    public function createReceiptWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->receipts)) {
            @$body['receipts'] = $request->receipts;
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

        return CreateReceiptResponse::fromMap($this->doROARequest('CreateReceipt', 'bizfinance_1.0', 'HTTP', 'POST', 'AK', '/v1.0/bizfinance/receipts', 'json', $req, $runtime));
    }

    /**
     * @param DeleteReceiptRequest $request
     *
     * @return DeleteReceiptResponse
     */
    public function deleteReceipt($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteReceiptHeaders([]);

        return $this->deleteReceiptWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DeleteReceiptRequest $request
     * @param DeleteReceiptHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return DeleteReceiptResponse
     */
    public function deleteReceiptWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->receipts)) {
            @$body['receipts'] = $request->receipts;
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

        return DeleteReceiptResponse::fromMap($this->doROARequest('DeleteReceipt', 'bizfinance_1.0', 'HTTP', 'POST', 'AK', '/v1.0/bizfinance/receipts/remove', 'json', $req, $runtime));
    }

    /**
     * @return GetBookkeepingUserListResponse
     */
    public function getBookkeepingUserList()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetBookkeepingUserListHeaders([]);

        return $this->getBookkeepingUserListWithOptions($headers, $runtime);
    }

    /**
     * @param GetBookkeepingUserListHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return GetBookkeepingUserListResponse
     */
    public function getBookkeepingUserListWithOptions($headers, $runtime)
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

        return GetBookkeepingUserListResponse::fromMap($this->doROARequest('GetBookkeepingUserList', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', '/v1.0/bizfinance/bookkeeping/users', 'json', $req, $runtime));
    }

    /**
     * @param GetCategoryRequest $request
     *
     * @return GetCategoryResponse
     */
    public function getCategory($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetCategoryHeaders([]);

        return $this->getCategoryWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetCategoryRequest $request
     * @param GetCategoryHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return GetCategoryResponse
     */
    public function getCategoryWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->code)) {
            @$query['code'] = $request->code;
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

        return GetCategoryResponse::fromMap($this->doROARequest('GetCategory', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', '/v1.0/bizfinance/categories/get', 'json', $req, $runtime));
    }

    /**
     * @param GetCustomerRequest $request
     *
     * @return GetCustomerResponse
     */
    public function getCustomer($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetCustomerHeaders([]);

        return $this->getCustomerWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetCustomerRequest $request
     * @param GetCustomerHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return GetCustomerResponse
     */
    public function getCustomerWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->code)) {
            @$query['code'] = $request->code;
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

        return GetCustomerResponse::fromMap($this->doROARequest('GetCustomer', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', '/v1.0/bizfinance/customers/details', 'json', $req, $runtime));
    }

    /**
     * @param GetFinanceAccountRequest $request
     *
     * @return GetFinanceAccountResponse
     */
    public function getFinanceAccount($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetFinanceAccountHeaders([]);

        return $this->getFinanceAccountWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetFinanceAccountRequest $request
     * @param GetFinanceAccountHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return GetFinanceAccountResponse
     */
    public function getFinanceAccountWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->accountCode)) {
            @$query['accountCode'] = $request->accountCode;
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

        return GetFinanceAccountResponse::fromMap($this->doROARequest('GetFinanceAccount', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', '/v1.0/bizfinance/financeAccounts/get', 'json', $req, $runtime));
    }

    /**
     * @param GetInvoiceByPageRequest $request
     *
     * @return GetInvoiceByPageResponse
     */
    public function getInvoiceByPage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetInvoiceByPageHeaders([]);

        return $this->getInvoiceByPageWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetInvoiceByPageRequest $tmpReq
     * @param GetInvoiceByPageHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return GetInvoiceByPageResponse
     */
    public function getInvoiceByPageWithOptions($tmpReq, $headers, $runtime)
    {
        Utils::validateModel($tmpReq);
        $request = new GetInvoiceByPageShrinkRequest([]);
        OpenApiUtilClient::convert($tmpReq, $request);
        if (!Utils::isUnset($tmpReq->request)) {
            $request->requestShrink = OpenApiUtilClient::arrayToStringWithSpecifiedStyle($tmpReq->request, 'request', 'json');
        }
        $query = [];
        if (!Utils::isUnset($request->requestShrink)) {
            @$query['request'] = $request->requestShrink;
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

        return GetInvoiceByPageResponse::fromMap($this->doROARequest('GetInvoiceByPage', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', '/v1.0/bizfinance/invoices', 'json', $req, $runtime));
    }

    /**
     * @return GetIsNewVersionResponse
     */
    public function getIsNewVersion()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetIsNewVersionHeaders([]);

        return $this->getIsNewVersionWithOptions($headers, $runtime);
    }

    /**
     * @param GetIsNewVersionHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return GetIsNewVersionResponse
     */
    public function getIsNewVersionWithOptions($headers, $runtime)
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

        return GetIsNewVersionResponse::fromMap($this->doROARequest('GetIsNewVersion', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', '/v1.0/bizfinance/accounts/uses', 'json', $req, $runtime));
    }

    /**
     * @param GetProductRequest $request
     *
     * @return GetProductResponse
     */
    public function getProduct($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetProductHeaders([]);

        return $this->getProductWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetProductRequest $request
     * @param GetProductHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return GetProductResponse
     */
    public function getProductWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->code)) {
            @$query['code'] = $request->code;
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

        return GetProductResponse::fromMap($this->doROARequest('GetProduct', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', '/v1.0/bizfinance/products', 'json', $req, $runtime));
    }

    /**
     * @param GetProjectRequest $request
     *
     * @return GetProjectResponse
     */
    public function getProject($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetProjectHeaders([]);

        return $this->getProjectWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetProjectRequest $request
     * @param GetProjectHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return GetProjectResponse
     */
    public function getProjectWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->code)) {
            @$query['code'] = $request->code;
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

        return GetProjectResponse::fromMap($this->doROARequest('GetProject', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', '/v1.0/bizfinance/projects/get', 'json', $req, $runtime));
    }

    /**
     * @param GetReceiptRequest $request
     *
     * @return GetReceiptResponse
     */
    public function getReceipt($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetReceiptHeaders([]);

        return $this->getReceiptWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetReceiptRequest $request
     * @param GetReceiptHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return GetReceiptResponse
     */
    public function getReceiptWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->code)) {
            @$query['code'] = $request->code;
        }
        if (!Utils::isUnset($request->modelId)) {
            @$query['modelId'] = $request->modelId;
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

        return GetReceiptResponse::fromMap($this->doROARequest('GetReceipt', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', '/v1.0/bizfinance/receipts/details', 'json', $req, $runtime));
    }

    /**
     * @param GetSupplierRequest $request
     *
     * @return GetSupplierResponse
     */
    public function getSupplier($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSupplierHeaders([]);

        return $this->getSupplierWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetSupplierRequest $request
     * @param GetSupplierHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return GetSupplierResponse
     */
    public function getSupplierWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->code)) {
            @$query['code'] = $request->code;
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

        return GetSupplierResponse::fromMap($this->doROARequest('GetSupplier', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', '/v1.0/bizfinance/suppliers/details', 'json', $req, $runtime));
    }

    /**
     * @param ProfessionBenefitConsumeRequest $request
     *
     * @return ProfessionBenefitConsumeResponse
     */
    public function professionBenefitConsume($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ProfessionBenefitConsumeHeaders([]);

        return $this->professionBenefitConsumeWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ProfessionBenefitConsumeRequest $request
     * @param ProfessionBenefitConsumeHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return ProfessionBenefitConsumeResponse
     */
    public function professionBenefitConsumeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->benefitCode)) {
            @$body['benefitCode'] = $request->benefitCode;
        }
        if (!Utils::isUnset($request->bizRequestId)) {
            @$body['bizRequestId'] = $request->bizRequestId;
        }
        if (!Utils::isUnset($request->quota)) {
            @$body['quota'] = $request->quota;
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

        return ProfessionBenefitConsumeResponse::fromMap($this->doROARequest('ProfessionBenefitConsume', 'bizfinance_1.0', 'HTTP', 'POST', 'AK', '/v1.0/bizfinance/professions/benefits/consume', 'json', $req, $runtime));
    }

    /**
     * @param QueryCategoryByPageRequest $request
     *
     * @return QueryCategoryByPageResponse
     */
    public function queryCategoryByPage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryCategoryByPageHeaders([]);

        return $this->queryCategoryByPageWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryCategoryByPageRequest $request
     * @param QueryCategoryByPageHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return QueryCategoryByPageResponse
     */
    public function queryCategoryByPageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNumber)) {
            @$query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->type)) {
            @$query['type'] = $request->type;
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

        return QueryCategoryByPageResponse::fromMap($this->doROARequest('QueryCategoryByPage', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', '/v1.0/bizfinance/categories/list', 'json', $req, $runtime));
    }

    /**
     * @param QueryCustomerByPageRequest $request
     *
     * @return QueryCustomerByPageResponse
     */
    public function queryCustomerByPage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryCustomerByPageHeaders([]);

        return $this->queryCustomerByPageWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryCustomerByPageRequest $request
     * @param QueryCustomerByPageHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return QueryCustomerByPageResponse
     */
    public function queryCustomerByPageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
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

        return QueryCustomerByPageResponse::fromMap($this->doROARequest('QueryCustomerByPage', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', '/v1.0/bizfinance/customers', 'json', $req, $runtime));
    }

    /**
     * @param QueryCustomerInfoRequest $request
     *
     * @return QueryCustomerInfoResponse
     */
    public function queryCustomerInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryCustomerInfoHeaders([]);

        return $this->queryCustomerInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryCustomerInfoRequest $request
     * @param QueryCustomerInfoHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return QueryCustomerInfoResponse
     */
    public function queryCustomerInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->keyword)) {
            @$query['keyword'] = $request->keyword;
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

        return QueryCustomerInfoResponse::fromMap($this->doROARequest('QueryCustomerInfo', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', '/v1.0/bizfinance/auxiliaries/customers', 'json', $req, $runtime));
    }

    /**
     * @param QueryEnterpriseAccountByPageRequest $request
     *
     * @return QueryEnterpriseAccountByPageResponse
     */
    public function queryEnterpriseAccountByPage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryEnterpriseAccountByPageHeaders([]);

        return $this->queryEnterpriseAccountByPageWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryEnterpriseAccountByPageRequest $request
     * @param QueryEnterpriseAccountByPageHeaders $headers
     * @param RuntimeOptions                      $runtime
     *
     * @return QueryEnterpriseAccountByPageResponse
     */
    public function queryEnterpriseAccountByPageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
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

        return QueryEnterpriseAccountByPageResponse::fromMap($this->doROARequest('QueryEnterpriseAccountByPage', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', '/v1.0/bizfinance/financeAccounts/list', 'json', $req, $runtime));
    }

    /**
     * @return QueryFinanceCompanyInfoResponse
     */
    public function queryFinanceCompanyInfo()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryFinanceCompanyInfoHeaders([]);

        return $this->queryFinanceCompanyInfoWithOptions($headers, $runtime);
    }

    /**
     * @param QueryFinanceCompanyInfoHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return QueryFinanceCompanyInfoResponse
     */
    public function queryFinanceCompanyInfoWithOptions($headers, $runtime)
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

        return QueryFinanceCompanyInfoResponse::fromMap($this->doROARequest('QueryFinanceCompanyInfo', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', '/v1.0/bizfinance/companies', 'json', $req, $runtime));
    }

    /**
     * @return QueryInvoiceRelationCountResponse
     */
    public function queryInvoiceRelationCount()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryInvoiceRelationCountHeaders([]);

        return $this->queryInvoiceRelationCountWithOptions($headers, $runtime);
    }

    /**
     * @param QueryInvoiceRelationCountHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return QueryInvoiceRelationCountResponse
     */
    public function queryInvoiceRelationCountWithOptions($headers, $runtime)
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

        return QueryInvoiceRelationCountResponse::fromMap($this->doROARequest('QueryInvoiceRelationCount', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', '/v1.0/bizfinance/invoices/relationReceipts/counts', 'json', $req, $runtime));
    }

    /**
     * @param QueryPermissionByUserIdRequest $request
     *
     * @return QueryPermissionByUserIdResponse
     */
    public function queryPermissionByUserId($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryPermissionByUserIdHeaders([]);

        return $this->queryPermissionByUserIdWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryPermissionByUserIdRequest $request
     * @param QueryPermissionByUserIdHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return QueryPermissionByUserIdResponse
     */
    public function queryPermissionByUserIdWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
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

        return QueryPermissionByUserIdResponse::fromMap($this->doROARequest('QueryPermissionByUserId', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', '/v1.0/bizfinance/permissions', 'json', $req, $runtime));
    }

    /**
     * @param QueryPermissionRoleMemberRequest $request
     *
     * @return QueryPermissionRoleMemberResponse
     */
    public function queryPermissionRoleMember($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryPermissionRoleMemberHeaders([]);

        return $this->queryPermissionRoleMemberWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryPermissionRoleMemberRequest $request
     * @param QueryPermissionRoleMemberHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return QueryPermissionRoleMemberResponse
     */
    public function queryPermissionRoleMemberWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->roleCodeList)) {
            @$body['roleCodeList'] = $request->roleCodeList;
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

        return QueryPermissionRoleMemberResponse::fromMap($this->doROARequest('QueryPermissionRoleMember', 'bizfinance_1.0', 'HTTP', 'POST', 'AK', '/v1.0/bizfinance/roles/members/query', 'json', $req, $runtime));
    }

    /**
     * @param QueryProductByPageRequest $request
     *
     * @return QueryProductByPageResponse
     */
    public function queryProductByPage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryProductByPageHeaders([]);

        return $this->queryProductByPageWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryProductByPageRequest $request
     * @param QueryProductByPageHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return QueryProductByPageResponse
     */
    public function queryProductByPageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
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

        return QueryProductByPageResponse::fromMap($this->doROARequest('QueryProductByPage', 'bizfinance_1.0', 'HTTP', 'POST', 'AK', '/v1.0/bizfinance/products/query', 'json', $req, $runtime));
    }

    /**
     * @param QueryProjectByPageRequest $request
     *
     * @return QueryProjectByPageResponse
     */
    public function queryProjectByPage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryProjectByPageHeaders([]);

        return $this->queryProjectByPageWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryProjectByPageRequest $request
     * @param QueryProjectByPageHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return QueryProjectByPageResponse
     */
    public function queryProjectByPageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
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

        return QueryProjectByPageResponse::fromMap($this->doROARequest('QueryProjectByPage', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', '/v1.0/bizfinance/projects/list', 'json', $req, $runtime));
    }

    /**
     * @param QueryReceiptForInvoiceRequest $request
     *
     * @return QueryReceiptForInvoiceResponse
     */
    public function queryReceiptForInvoice($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryReceiptForInvoiceHeaders([]);

        return $this->queryReceiptForInvoiceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryReceiptForInvoiceRequest $request
     * @param QueryReceiptForInvoiceHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return QueryReceiptForInvoiceResponse
     */
    public function queryReceiptForInvoiceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->applyStatusList)) {
            @$body['applyStatusList'] = $request->applyStatusList;
        }
        if (!Utils::isUnset($request->endTime)) {
            @$body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            @$body['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->receiptStatusList)) {
            @$body['receiptStatusList'] = $request->receiptStatusList;
        }
        if (!Utils::isUnset($request->startTime)) {
            @$body['startTime'] = $request->startTime;
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

        return QueryReceiptForInvoiceResponse::fromMap($this->doROARequest('QueryReceiptForInvoice', 'bizfinance_1.0', 'HTTP', 'POST', 'AK', '/v1.0/bizfinance/invoices/receipts/query', 'json', $req, $runtime));
    }

    /**
     * @param QueryReceiptsBaseInfoRequest $request
     *
     * @return QueryReceiptsBaseInfoResponse
     */
    public function queryReceiptsBaseInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryReceiptsBaseInfoHeaders([]);

        return $this->queryReceiptsBaseInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryReceiptsBaseInfoRequest $request
     * @param QueryReceiptsBaseInfoHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return QueryReceiptsBaseInfoResponse
     */
    public function queryReceiptsBaseInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->endTime)) {
            @$query['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            @$query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->startTime)) {
            @$query['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->timeFilterField)) {
            @$query['timeFilterField'] = $request->timeFilterField;
        }
        if (!Utils::isUnset($request->title)) {
            @$query['title'] = $request->title;
        }
        if (!Utils::isUnset($request->voucherStatus)) {
            @$query['voucherStatus'] = $request->voucherStatus;
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

        return QueryReceiptsBaseInfoResponse::fromMap($this->doROARequest('QueryReceiptsBaseInfo', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', '/v1.0/bizfinance/receipts/dataInfos', 'json', $req, $runtime));
    }

    /**
     * @param QueryReceiptsByPageRequest $request
     *
     * @return QueryReceiptsByPageResponse
     */
    public function queryReceiptsByPage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryReceiptsByPageHeaders([]);

        return $this->queryReceiptsByPageWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryReceiptsByPageRequest $request
     * @param QueryReceiptsByPageHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return QueryReceiptsByPageResponse
     */
    public function queryReceiptsByPageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->endTime)) {
            @$query['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->modelId)) {
            @$query['modelId'] = $request->modelId;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            @$query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->startTime)) {
            @$query['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->timeFilterField)) {
            @$query['timeFilterField'] = $request->timeFilterField;
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

        return QueryReceiptsByPageResponse::fromMap($this->doROARequest('QueryReceiptsByPage', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', '/v1.0/bizfinance/receipts', 'json', $req, $runtime));
    }

    /**
     * @param QuerySupplierByPageRequest $request
     *
     * @return QuerySupplierByPageResponse
     */
    public function querySupplierByPage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QuerySupplierByPageHeaders([]);

        return $this->querySupplierByPageWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QuerySupplierByPageRequest $request
     * @param QuerySupplierByPageHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return QuerySupplierByPageResponse
     */
    public function querySupplierByPageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
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

        return QuerySupplierByPageResponse::fromMap($this->doROARequest('QuerySupplierByPage', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', '/v1.0/bizfinance/suppliers', 'json', $req, $runtime));
    }

    /**
     * @param QueryUserRoleListRequest $request
     *
     * @return QueryUserRoleListResponse
     */
    public function queryUserRoleList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryUserRoleListHeaders([]);

        return $this->queryUserRoleListWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryUserRoleListRequest $request
     * @param QueryUserRoleListHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return QueryUserRoleListResponse
     */
    public function queryUserRoleListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
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

        return QueryUserRoleListResponse::fromMap($this->doROARequest('QueryUserRoleList', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', '/v1.0/bizfinance/users/roles', 'json', $req, $runtime));
    }

    /**
     * @param UnbindApplyReceiptAndInvoiceRelatedRequest $request
     *
     * @return UnbindApplyReceiptAndInvoiceRelatedResponse
     */
    public function unbindApplyReceiptAndInvoiceRelated($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UnbindApplyReceiptAndInvoiceRelatedHeaders([]);

        return $this->unbindApplyReceiptAndInvoiceRelatedWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UnbindApplyReceiptAndInvoiceRelatedRequest $request
     * @param UnbindApplyReceiptAndInvoiceRelatedHeaders $headers
     * @param RuntimeOptions                             $runtime
     *
     * @return UnbindApplyReceiptAndInvoiceRelatedResponse
     */
    public function unbindApplyReceiptAndInvoiceRelatedWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->instanceId)) {
            @$body['instanceId'] = $request->instanceId;
        }
        if (!Utils::isUnset($request->invoiceKeyVOList)) {
            @$body['invoiceKeyVOList'] = $request->invoiceKeyVOList;
        }
        if (!Utils::isUnset($request->operator)) {
            @$body['operator'] = $request->operator;
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

        return UnbindApplyReceiptAndInvoiceRelatedResponse::fromMap($this->doROARequest('UnbindApplyReceiptAndInvoiceRelated', 'bizfinance_1.0', 'HTTP', 'POST', 'AK', '/v1.0/bizfinance/invoices/unbind', 'json', $req, $runtime));
    }

    /**
     * @param UpdateApplyReceiptAndInvoiceRelatedRequest $request
     *
     * @return UpdateApplyReceiptAndInvoiceRelatedResponse
     */
    public function updateApplyReceiptAndInvoiceRelated($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateApplyReceiptAndInvoiceRelatedHeaders([]);

        return $this->updateApplyReceiptAndInvoiceRelatedWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateApplyReceiptAndInvoiceRelatedRequest $request
     * @param UpdateApplyReceiptAndInvoiceRelatedHeaders $headers
     * @param RuntimeOptions                             $runtime
     *
     * @return UpdateApplyReceiptAndInvoiceRelatedResponse
     */
    public function updateApplyReceiptAndInvoiceRelatedWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->generalInvoiceVOList)) {
            @$body['generalInvoiceVOList'] = $request->generalInvoiceVOList;
        }
        if (!Utils::isUnset($request->instanceId)) {
            @$body['instanceId'] = $request->instanceId;
        }
        if (!Utils::isUnset($request->operator)) {
            @$body['operator'] = $request->operator;
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

        return UpdateApplyReceiptAndInvoiceRelatedResponse::fromMap($this->doROARequest('UpdateApplyReceiptAndInvoiceRelated', 'bizfinance_1.0', 'HTTP', 'POST', 'AK', '/v1.0/bizfinance/invoices/applyReceipts/relate', 'json', $req, $runtime));
    }

    /**
     * @param UpdateDigitalInvoiceOrgInfoRequest $request
     *
     * @return UpdateDigitalInvoiceOrgInfoResponse
     */
    public function updateDigitalInvoiceOrgInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateDigitalInvoiceOrgInfoHeaders([]);

        return $this->updateDigitalInvoiceOrgInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateDigitalInvoiceOrgInfoRequest $request
     * @param UpdateDigitalInvoiceOrgInfoHeaders $headers
     * @param RuntimeOptions                     $runtime
     *
     * @return UpdateDigitalInvoiceOrgInfoResponse
     */
    public function updateDigitalInvoiceOrgInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->digitalInvoiceType)) {
            @$body['digitalInvoiceType'] = $request->digitalInvoiceType;
        }
        if (!Utils::isUnset($request->isDigitalOrg)) {
            @$body['isDigitalOrg'] = $request->isDigitalOrg;
        }
        if (!Utils::isUnset($request->location)) {
            @$body['location'] = $request->location;
        }
        if (!Utils::isUnset($request->operator)) {
            @$body['operator'] = $request->operator;
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

        return UpdateDigitalInvoiceOrgInfoResponse::fromMap($this->doROARequest('UpdateDigitalInvoiceOrgInfo', 'bizfinance_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/bizfinance/invoices/organizationInfos', 'json', $req, $runtime));
    }

    /**
     * @param UpdateFinanceCompanyInfoRequest $request
     *
     * @return UpdateFinanceCompanyInfoResponse
     */
    public function updateFinanceCompanyInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateFinanceCompanyInfoHeaders([]);

        return $this->updateFinanceCompanyInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateFinanceCompanyInfoRequest $request
     * @param UpdateFinanceCompanyInfoHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return UpdateFinanceCompanyInfoResponse
     */
    public function updateFinanceCompanyInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->companyName)) {
            @$query['companyName'] = $request->companyName;
        }
        if (!Utils::isUnset($request->taxNature)) {
            @$query['taxNature'] = $request->taxNature;
        }
        if (!Utils::isUnset($request->taxNo)) {
            @$query['taxNo'] = $request->taxNo;
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

        return UpdateFinanceCompanyInfoResponse::fromMap($this->doROARequest('UpdateFinanceCompanyInfo', 'bizfinance_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/bizfinance/companies', 'json', $req, $runtime));
    }

    /**
     * @param UpdateInvoiceAbandonStatusRequest $request
     *
     * @return UpdateInvoiceAbandonStatusResponse
     */
    public function updateInvoiceAbandonStatus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateInvoiceAbandonStatusHeaders([]);

        return $this->updateInvoiceAbandonStatusWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateInvoiceAbandonStatusRequest $request
     * @param UpdateInvoiceAbandonStatusHeaders $headers
     * @param RuntimeOptions                    $runtime
     *
     * @return UpdateInvoiceAbandonStatusResponse
     */
    public function updateInvoiceAbandonStatusWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->blueGeneralInvoiceVO)) {
            @$body['blueGeneralInvoiceVO'] = $request->blueGeneralInvoiceVO;
        }
        if (!Utils::isUnset($request->blueInvoiceCode)) {
            @$body['blueInvoiceCode'] = $request->blueInvoiceCode;
        }
        if (!Utils::isUnset($request->blueInvoiceNo)) {
            @$body['blueInvoiceNo'] = $request->blueInvoiceNo;
        }
        if (!Utils::isUnset($request->blueInvoiceStatus)) {
            @$body['blueInvoiceStatus'] = $request->blueInvoiceStatus;
        }
        if (!Utils::isUnset($request->operator)) {
            @$body['operator'] = $request->operator;
        }
        if (!Utils::isUnset($request->redGeneralInvoiceVO)) {
            @$body['redGeneralInvoiceVO'] = $request->redGeneralInvoiceVO;
        }
        if (!Utils::isUnset($request->redInvoiceCode)) {
            @$body['redInvoiceCode'] = $request->redInvoiceCode;
        }
        if (!Utils::isUnset($request->redInvoiceNo)) {
            @$body['redInvoiceNo'] = $request->redInvoiceNo;
        }
        if (!Utils::isUnset($request->redInvoiceStatus)) {
            @$body['redInvoiceStatus'] = $request->redInvoiceStatus;
        }
        if (!Utils::isUnset($request->targetInvoice)) {
            @$body['targetInvoice'] = $request->targetInvoice;
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

        return UpdateInvoiceAbandonStatusResponse::fromMap($this->doROARequest('UpdateInvoiceAbandonStatus', 'bizfinance_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/bizfinance/invoices/abandonStatus', 'json', $req, $runtime));
    }

    /**
     * @param UpdateInvoiceAccountPeriodRequest $request
     *
     * @return UpdateInvoiceAccountPeriodResponse
     */
    public function updateInvoiceAccountPeriod($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateInvoiceAccountPeriodHeaders([]);

        return $this->updateInvoiceAccountPeriodWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateInvoiceAccountPeriodRequest $request
     * @param UpdateInvoiceAccountPeriodHeaders $headers
     * @param RuntimeOptions                    $runtime
     *
     * @return UpdateInvoiceAccountPeriodResponse
     */
    public function updateInvoiceAccountPeriodWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->accountPeriod)) {
            @$body['accountPeriod'] = $request->accountPeriod;
        }
        if (!Utils::isUnset($request->generalInvoiceVOList)) {
            @$body['generalInvoiceVOList'] = $request->generalInvoiceVOList;
        }
        if (!Utils::isUnset($request->invoiceKeyVOList)) {
            @$body['invoiceKeyVOList'] = $request->invoiceKeyVOList;
        }
        if (!Utils::isUnset($request->operator)) {
            @$body['operator'] = $request->operator;
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

        return UpdateInvoiceAccountPeriodResponse::fromMap($this->doROARequest('UpdateInvoiceAccountPeriod', 'bizfinance_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/bizfinance/invoices/accountPeriods', 'json', $req, $runtime));
    }

    /**
     * @param UpdateInvoiceAccountingPeriodDateRequest $request
     *
     * @return UpdateInvoiceAccountingPeriodDateResponse
     */
    public function updateInvoiceAccountingPeriodDate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateInvoiceAccountingPeriodDateHeaders([]);

        return $this->updateInvoiceAccountingPeriodDateWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateInvoiceAccountingPeriodDateRequest $request
     * @param UpdateInvoiceAccountingPeriodDateHeaders $headers
     * @param RuntimeOptions                           $runtime
     *
     * @return UpdateInvoiceAccountingPeriodDateResponse
     */
    public function updateInvoiceAccountingPeriodDateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->invoiceFinanceInfoVOList)) {
            @$body['invoiceFinanceInfoVOList'] = $request->invoiceFinanceInfoVOList;
        }
        if (!Utils::isUnset($request->operator)) {
            @$body['operator'] = $request->operator;
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

        return UpdateInvoiceAccountingPeriodDateResponse::fromMap($this->doROARequest('UpdateInvoiceAccountingPeriodDate', 'bizfinance_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/bizfinance/invoices/accounts/periodDates', 'json', $req, $runtime));
    }

    /**
     * @param UpdateInvoiceAccountingStatusRequest $request
     *
     * @return UpdateInvoiceAccountingStatusResponse
     */
    public function updateInvoiceAccountingStatus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateInvoiceAccountingStatusHeaders([]);

        return $this->updateInvoiceAccountingStatusWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateInvoiceAccountingStatusRequest $request
     * @param UpdateInvoiceAccountingStatusHeaders $headers
     * @param RuntimeOptions                       $runtime
     *
     * @return UpdateInvoiceAccountingStatusResponse
     */
    public function updateInvoiceAccountingStatusWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->invoiceFinanceInfoVOList)) {
            @$body['invoiceFinanceInfoVOList'] = $request->invoiceFinanceInfoVOList;
        }
        if (!Utils::isUnset($request->operator)) {
            @$body['operator'] = $request->operator;
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

        return UpdateInvoiceAccountingStatusResponse::fromMap($this->doROARequest('UpdateInvoiceAccountingStatus', 'bizfinance_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/bizfinance/invoices/accounts/statuses', 'json', $req, $runtime));
    }

    /**
     * @param UpdateInvoiceAndReceiptRelatedRequest $request
     *
     * @return UpdateInvoiceAndReceiptRelatedResponse
     */
    public function updateInvoiceAndReceiptRelated($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateInvoiceAndReceiptRelatedHeaders([]);

        return $this->updateInvoiceAndReceiptRelatedWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateInvoiceAndReceiptRelatedRequest $request
     * @param UpdateInvoiceAndReceiptRelatedHeaders $headers
     * @param RuntimeOptions                        $runtime
     *
     * @return UpdateInvoiceAndReceiptRelatedResponse
     */
    public function updateInvoiceAndReceiptRelatedWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->generalInvoiceVO)) {
            @$body['generalInvoiceVO'] = $request->generalInvoiceVO;
        }
        if (!Utils::isUnset($request->invoiceCode)) {
            @$body['invoiceCode'] = $request->invoiceCode;
        }
        if (!Utils::isUnset($request->invoiceNo)) {
            @$body['invoiceNo'] = $request->invoiceNo;
        }
        if (!Utils::isUnset($request->operator)) {
            @$body['operator'] = $request->operator;
        }
        if (!Utils::isUnset($request->receiptCode)) {
            @$body['receiptCode'] = $request->receiptCode;
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

        return UpdateInvoiceAndReceiptRelatedResponse::fromMap($this->doROARequest('UpdateInvoiceAndReceiptRelated', 'bizfinance_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/bizfinance/invoices/approvalReceipts', 'json', $req, $runtime));
    }

    /**
     * @param UpdateInvoiceIgnoreStatusRequest $request
     *
     * @return UpdateInvoiceIgnoreStatusResponse
     */
    public function updateInvoiceIgnoreStatus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateInvoiceIgnoreStatusHeaders([]);

        return $this->updateInvoiceIgnoreStatusWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateInvoiceIgnoreStatusRequest $request
     * @param UpdateInvoiceIgnoreStatusHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return UpdateInvoiceIgnoreStatusResponse
     */
    public function updateInvoiceIgnoreStatusWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->instanceId)) {
            @$query['instanceId'] = $request->instanceId;
        }
        if (!Utils::isUnset($request->operator)) {
            @$query['operator'] = $request->operator;
        }
        if (!Utils::isUnset($request->status)) {
            @$query['status'] = $request->status;
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

        return UpdateInvoiceIgnoreStatusResponse::fromMap($this->doROARequest('UpdateInvoiceIgnoreStatus', 'bizfinance_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/bizfinance/invoices/ignoreStatus', 'json', $req, $runtime));
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
        if (!Utils::isUnset($request->deductStatus)) {
            @$body['deductStatus'] = $request->deductStatus;
        }
        if (!Utils::isUnset($request->generalInvoiceVOList)) {
            @$body['generalInvoiceVOList'] = $request->generalInvoiceVOList;
        }
        if (!Utils::isUnset($request->invoiceKeyVOList)) {
            @$body['invoiceKeyVOList'] = $request->invoiceKeyVOList;
        }
        if (!Utils::isUnset($request->operator)) {
            @$body['operator'] = $request->operator;
        }
        if (!Utils::isUnset($request->verifyStatus)) {
            @$body['verifyStatus'] = $request->verifyStatus;
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

        return UpdateInvoiceVerifyStatusResponse::fromMap($this->doROARequest('UpdateInvoiceVerifyStatus', 'bizfinance_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/bizfinance/invoices/verifyStatus', 'json', $req, $runtime));
    }

    /**
     * @param UpdateInvoiceVoucherStatusRequest $request
     *
     * @return UpdateInvoiceVoucherStatusResponse
     */
    public function updateInvoiceVoucherStatus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateInvoiceVoucherStatusHeaders([]);

        return $this->updateInvoiceVoucherStatusWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateInvoiceVoucherStatusRequest $request
     * @param UpdateInvoiceVoucherStatusHeaders $headers
     * @param RuntimeOptions                    $runtime
     *
     * @return UpdateInvoiceVoucherStatusResponse
     */
    public function updateInvoiceVoucherStatusWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->actionType)) {
            @$body['actionType'] = $request->actionType;
        }
        if (!Utils::isUnset($request->invoiceCode)) {
            @$body['invoiceCode'] = $request->invoiceCode;
        }
        if (!Utils::isUnset($request->invoiceNo)) {
            @$body['invoiceNo'] = $request->invoiceNo;
        }
        if (!Utils::isUnset($request->operator)) {
            @$body['operator'] = $request->operator;
        }
        if (!Utils::isUnset($request->voucherId)) {
            @$body['voucherId'] = $request->voucherId;
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

        return UpdateInvoiceVoucherStatusResponse::fromMap($this->doROARequest('UpdateInvoiceVoucherStatus', 'bizfinance_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/bizfinance/invoices/vouchers/states', 'json', $req, $runtime));
    }

    /**
     * @param UpdateReceiptRequest $request
     *
     * @return UpdateReceiptResponse
     */
    public function updateReceipt($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateReceiptHeaders([]);

        return $this->updateReceiptWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateReceiptRequest $request
     * @param UpdateReceiptHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return UpdateReceiptResponse
     */
    public function updateReceiptWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->receipts)) {
            @$body['receipts'] = $request->receipts;
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

        return UpdateReceiptResponse::fromMap($this->doROARequest('UpdateReceipt', 'bizfinance_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/bizfinance/receipts', 'json', $req, $runtime));
    }

    /**
     * @param UpdateReceiptVoucherStatusRequest $request
     *
     * @return UpdateReceiptVoucherStatusResponse
     */
    public function updateReceiptVoucherStatus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateReceiptVoucherStatusHeaders([]);

        return $this->updateReceiptVoucherStatusWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateReceiptVoucherStatusRequest $request
     * @param UpdateReceiptVoucherStatusHeaders $headers
     * @param RuntimeOptions                    $runtime
     *
     * @return UpdateReceiptVoucherStatusResponse
     */
    public function updateReceiptVoucherStatusWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->accountPeriod)) {
            @$body['accountPeriod'] = $request->accountPeriod;
        }
        if (!Utils::isUnset($request->actionType)) {
            @$body['actionType'] = $request->actionType;
        }
        if (!Utils::isUnset($request->operatorId)) {
            @$body['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->receiptId)) {
            @$body['receiptId'] = $request->receiptId;
        }
        if (!Utils::isUnset($request->voucherCode)) {
            @$body['voucherCode'] = $request->voucherCode;
        }
        if (!Utils::isUnset($request->voucherId)) {
            @$body['voucherId'] = $request->voucherId;
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

        return UpdateReceiptVoucherStatusResponse::fromMap($this->doROARequest('UpdateReceiptVoucherStatus', 'bizfinance_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/bizfinance/vouchers/recepits', 'json', $req, $runtime));
    }
}
