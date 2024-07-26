<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\AppendRolePermissionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\AppendRolePermissionRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\AppendRolePermissionResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\AppendRolePermissionShrinkRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\BatchAddInvoiceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\BatchAddInvoiceRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\BatchAddInvoiceResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\BatchCreateCustomerHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\BatchCreateCustomerRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\BatchCreateCustomerResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\BeginConsumeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\BeginConsumeRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\BeginConsumeResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\BindCompanyAccountantBookHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\BindCompanyAccountantBookRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\BindCompanyAccountantBookResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\CancelConsumeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\CancelConsumeRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\CancelConsumeResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\CheckVoucherStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\CheckVoucherStatusRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\CheckVoucherStatusResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\CommitConsumeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\CommitConsumeRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\CommitConsumeResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\GetFormTemplateInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\GetFormTemplateInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\GetInvoiceByPageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\GetInvoiceByPageRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\GetInvoiceByPageResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\GetInvoiceByPageShrinkRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\GetIsNewVersionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\GetIsNewVersionResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\GetMultiCompanyInfoByCodeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\GetMultiCompanyInfoByCodeResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\GetYongYouOpenApiTokenHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\GetYongYouOpenApiTokenRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\GetYongYouOpenApiTokenResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\GetYongYouOrgRelationHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\GetYongYouOrgRelationResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\ProfessionBenefitConsumeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\ProfessionBenefitConsumeRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\ProfessionBenefitConsumeResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\PushHistoricalReceiptsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\PushHistoricalReceiptsRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\PushHistoricalReceiptsResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryBenefitHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryBenefitRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryBenefitResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryCategoryByPageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryCategoryByPageRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryCategoryByPageResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryCompanyInvoiceRelationCountHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryCompanyInvoiceRelationCountRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryCompanyInvoiceRelationCountResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryMultiCompanyInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryMultiCompanyInfoResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryReceiptDetailForInvoiceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryReceiptDetailForInvoiceRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryReceiptDetailForInvoiceResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryReceiptForInvoiceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryReceiptForInvoiceRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryReceiptForInvoiceResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryReceiptsBaseInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryReceiptsBaseInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryReceiptsBaseInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryReceiptsByPageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryReceiptsByPageRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryReceiptsByPageResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryRoleMemberByPageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryRoleMemberByPageRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryRoleMemberByPageResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateFinanceMultiCompanyInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateFinanceMultiCompanyInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateFinanceMultiCompanyInfoResponse;
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
use Darabonba\GatewayDingTalk\Client;
use Darabonba\OpenApi\Models\OpenApiRequest;
use Darabonba\OpenApi\Models\Params;
use Darabonba\OpenApi\OpenApiClient;

class Dingtalk extends OpenApiClient
{
    public function __construct($config)
    {
        parent::__construct($config);
        $gatewayClient       = new Client();
        $this->_spi          = $gatewayClient;
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @summary 追加角色权限点
     *  *
     * @param AppendRolePermissionRequest $tmpReq  AppendRolePermissionRequest
     * @param AppendRolePermissionHeaders $headers AppendRolePermissionHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return AppendRolePermissionResponse AppendRolePermissionResponse
     */
    public function appendRolePermissionWithOptions($tmpReq, $headers, $runtime)
    {
        Utils::validateModel($tmpReq);
        $request = new AppendRolePermissionShrinkRequest([]);
        OpenApiUtilClient::convert($tmpReq, $request);
        if (!Utils::isUnset($tmpReq->rolePermissionItemList)) {
            $request->rolePermissionItemListShrink = OpenApiUtilClient::arrayToStringWithSpecifiedStyle($tmpReq->rolePermissionItemList, 'rolePermissionItemList', 'json');
        }
        $query = [];
        if (!Utils::isUnset($request->rolePermissionItemListShrink)) {
            $query['rolePermissionItemList'] = $request->rolePermissionItemListShrink;
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
            'action'      => 'AppendRolePermission',
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/roles/permissions',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AppendRolePermissionResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 追加角色权限点
     *  *
     * @param AppendRolePermissionRequest $request AppendRolePermissionRequest
     *
     * @return AppendRolePermissionResponse AppendRolePermissionResponse
     */
    public function appendRolePermission($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AppendRolePermissionHeaders([]);

        return $this->appendRolePermissionWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 发票数据批量写入
     *  *
     * @param BatchAddInvoiceRequest $request BatchAddInvoiceRequest
     * @param BatchAddInvoiceHeaders $headers BatchAddInvoiceHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return BatchAddInvoiceResponse BatchAddInvoiceResponse
     */
    public function batchAddInvoiceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->companyCode)) {
            $body['companyCode'] = $request->companyCode;
        }
        if (!Utils::isUnset($request->generalInvoiceVOList)) {
            $body['generalInvoiceVOList'] = $request->generalInvoiceVOList;
        }
        if (!Utils::isUnset($request->operator)) {
            $body['operator'] = $request->operator;
        }
        if (!Utils::isUnset($request->source)) {
            $body['source'] = $request->source;
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
            'action'      => 'BatchAddInvoice',
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/invoices/batch',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BatchAddInvoiceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 发票数据批量写入
     *  *
     * @param BatchAddInvoiceRequest $request BatchAddInvoiceRequest
     *
     * @return BatchAddInvoiceResponse BatchAddInvoiceResponse
     */
    public function batchAddInvoice($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchAddInvoiceHeaders([]);

        return $this->batchAddInvoiceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量增加用户信息
     *  *
     * @param BatchCreateCustomerRequest $request BatchCreateCustomerRequest
     * @param BatchCreateCustomerHeaders $headers BatchCreateCustomerHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return BatchCreateCustomerResponse BatchCreateCustomerResponse
     */
    public function batchCreateCustomerWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->createCustomerRequestList)) {
            $body['createCustomerRequestList'] = $request->createCustomerRequestList;
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
            'action'      => 'BatchCreateCustomer',
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/auxiliaries/batch',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BatchCreateCustomerResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量增加用户信息
     *  *
     * @param BatchCreateCustomerRequest $request BatchCreateCustomerRequest
     *
     * @return BatchCreateCustomerResponse BatchCreateCustomerResponse
     */
    public function batchCreateCustomer($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchCreateCustomerHeaders([]);

        return $this->batchCreateCustomerWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 预核销智能财务的权益
     *  *
     * @param BeginConsumeRequest $request BeginConsumeRequest
     * @param BeginConsumeHeaders $headers BeginConsumeHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return BeginConsumeResponse BeginConsumeResponse
     */
    public function beginConsumeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->benefitCode)) {
            $query['benefitCode'] = $request->benefitCode;
        }
        if (!Utils::isUnset($request->bizRequestId)) {
            $query['bizRequestId'] = $request->bizRequestId;
        }
        if (!Utils::isUnset($request->quota)) {
            $query['quota'] = $request->quota;
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
            'action'      => 'BeginConsume',
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/consumedBenefits/prepare',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BeginConsumeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 预核销智能财务的权益
     *  *
     * @param BeginConsumeRequest $request BeginConsumeRequest
     *
     * @return BeginConsumeResponse BeginConsumeResponse
     */
    public function beginConsume($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BeginConsumeHeaders([]);

        return $this->beginConsumeWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 绑定钉钉智能财务企业主体的账套信息
     *  *
     * @param BindCompanyAccountantBookRequest $request BindCompanyAccountantBookRequest
     * @param BindCompanyAccountantBookHeaders $headers BindCompanyAccountantBookHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return BindCompanyAccountantBookResponse BindCompanyAccountantBookResponse
     */
    public function bindCompanyAccountantBookWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->accountantBookId)) {
            $query['accountantBookId'] = $request->accountantBookId;
        }
        if (!Utils::isUnset($request->companyCode)) {
            $query['companyCode'] = $request->companyCode;
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
            'action'      => 'BindCompanyAccountantBook',
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/companies/accountantBooks/bind',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BindCompanyAccountantBookResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 绑定钉钉智能财务企业主体的账套信息
     *  *
     * @param BindCompanyAccountantBookRequest $request BindCompanyAccountantBookRequest
     *
     * @return BindCompanyAccountantBookResponse BindCompanyAccountantBookResponse
     */
    public function bindCompanyAccountantBook($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BindCompanyAccountantBookHeaders([]);

        return $this->bindCompanyAccountantBookWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 取消核销智能财务的权益
     *  *
     * @param CancelConsumeRequest $request CancelConsumeRequest
     * @param CancelConsumeHeaders $headers CancelConsumeHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return CancelConsumeResponse CancelConsumeResponse
     */
    public function cancelConsumeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->benefitCode)) {
            $query['benefitCode'] = $request->benefitCode;
        }
        if (!Utils::isUnset($request->bizRequestId)) {
            $query['bizRequestId'] = $request->bizRequestId;
        }
        if (!Utils::isUnset($request->quota)) {
            $query['quota'] = $request->quota;
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
            'action'      => 'CancelConsume',
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/consumedBenefits/cancel',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CancelConsumeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 取消核销智能财务的权益
     *  *
     * @param CancelConsumeRequest $request CancelConsumeRequest
     *
     * @return CancelConsumeResponse CancelConsumeResponse
     */
    public function cancelConsume($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CancelConsumeHeaders([]);

        return $this->cancelConsumeWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查验发票是否生成凭证
     *  *
     * @param CheckVoucherStatusRequest $request CheckVoucherStatusRequest
     * @param CheckVoucherStatusHeaders $headers CheckVoucherStatusHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return CheckVoucherStatusResponse CheckVoucherStatusResponse
     */
    public function checkVoucherStatusWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->companyCode)) {
            $body['companyCode'] = $request->companyCode;
        }
        if (!Utils::isUnset($request->endTime)) {
            $body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->financeType)) {
            $body['financeType'] = $request->financeType;
        }
        if (!Utils::isUnset($request->invoiceCode)) {
            $body['invoiceCode'] = $request->invoiceCode;
        }
        if (!Utils::isUnset($request->invoiceNo)) {
            $body['invoiceNo'] = $request->invoiceNo;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $body['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->startTime)) {
            $body['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->taxNo)) {
            $body['taxNo'] = $request->taxNo;
        }
        if (!Utils::isUnset($request->verifyStatus)) {
            $body['verifyStatus'] = $request->verifyStatus;
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
            'action'      => 'CheckVoucherStatus',
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/invoices/checkVoucherStatus/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CheckVoucherStatusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查验发票是否生成凭证
     *  *
     * @param CheckVoucherStatusRequest $request CheckVoucherStatusRequest
     *
     * @return CheckVoucherStatusResponse CheckVoucherStatusResponse
     */
    public function checkVoucherStatus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CheckVoucherStatusHeaders([]);

        return $this->checkVoucherStatusWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 确认核销智能财务的权益
     *  *
     * @param CommitConsumeRequest $request CommitConsumeRequest
     * @param CommitConsumeHeaders $headers CommitConsumeHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return CommitConsumeResponse CommitConsumeResponse
     */
    public function commitConsumeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->benefitCode)) {
            $query['benefitCode'] = $request->benefitCode;
        }
        if (!Utils::isUnset($request->bizRequestId)) {
            $query['bizRequestId'] = $request->bizRequestId;
        }
        if (!Utils::isUnset($request->quota)) {
            $query['quota'] = $request->quota;
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
            'action'      => 'CommitConsume',
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/consumedBenefits/commit',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CommitConsumeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 确认核销智能财务的权益
     *  *
     * @param CommitConsumeRequest $request CommitConsumeRequest
     *
     * @return CommitConsumeResponse CommitConsumeResponse
     */
    public function commitConsume($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CommitConsumeHeaders([]);

        return $this->commitConsumeWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建智能财务的客户信息
     *  *
     * @param CreateCustomerRequest $request CreateCustomerRequest
     * @param CreateCustomerHeaders $headers CreateCustomerHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateCustomerResponse CreateCustomerResponse
     */
    public function createCustomerWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->creator)) {
            $body['creator'] = $request->creator;
        }
        if (!Utils::isUnset($request->description)) {
            $body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->drawerEmail)) {
            $body['drawerEmail'] = $request->drawerEmail;
        }
        if (!Utils::isUnset($request->drawerTelephone)) {
            $body['drawerTelephone'] = $request->drawerTelephone;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->purchaserAccount)) {
            $body['purchaserAccount'] = $request->purchaserAccount;
        }
        if (!Utils::isUnset($request->purchaserAddress)) {
            $body['purchaserAddress'] = $request->purchaserAddress;
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
            'action'      => 'CreateCustomer',
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/auxiliaries/customers',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateCustomerResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建智能财务的客户信息
     *  *
     * @param CreateCustomerRequest $request CreateCustomerRequest
     *
     * @return CreateCustomerResponse CreateCustomerResponse
     */
    public function createCustomer($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateCustomerHeaders([]);

        return $this->createCustomerWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建智能财务单据
     *  *
     * @param CreateReceiptRequest $request CreateReceiptRequest
     * @param CreateReceiptHeaders $headers CreateReceiptHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateReceiptResponse CreateReceiptResponse
     */
    public function createReceiptWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->receipts)) {
            $body['receipts'] = $request->receipts;
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
            'action'      => 'CreateReceipt',
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/receipts',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateReceiptResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建智能财务单据
     *  *
     * @param CreateReceiptRequest $request CreateReceiptRequest
     *
     * @return CreateReceiptResponse CreateReceiptResponse
     */
    public function createReceipt($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateReceiptHeaders([]);

        return $this->createReceiptWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除智能财务单据
     *  *
     * @param DeleteReceiptRequest $request DeleteReceiptRequest
     * @param DeleteReceiptHeaders $headers DeleteReceiptHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteReceiptResponse DeleteReceiptResponse
     */
    public function deleteReceiptWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->receipts)) {
            $body['receipts'] = $request->receipts;
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
            'action'      => 'DeleteReceipt',
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/receipts/remove',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return DeleteReceiptResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除智能财务单据
     *  *
     * @param DeleteReceiptRequest $request DeleteReceiptRequest
     *
     * @return DeleteReceiptResponse DeleteReceiptResponse
     */
    public function deleteReceipt($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteReceiptHeaders([]);

        return $this->deleteReceiptWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取可以查看账本的用户列表
     *  *
     * @param GetBookkeepingUserListHeaders $headers GetBookkeepingUserListHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return GetBookkeepingUserListResponse GetBookkeepingUserListResponse
     */
    public function getBookkeepingUserListWithOptions($headers, $runtime)
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
            'action'      => 'GetBookkeepingUserList',
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/bookkeeping/users',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetBookkeepingUserListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取可以查看账本的用户列表
     *  *
     * @return GetBookkeepingUserListResponse GetBookkeepingUserListResponse
     */
    public function getBookkeepingUserList()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetBookkeepingUserListHeaders([]);

        return $this->getBookkeepingUserListWithOptions($headers, $runtime);
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
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/categories/get',
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
     * @summary 获取智能财务应用内维护的客户信息
     *  *
     * @param GetCustomerRequest $request GetCustomerRequest
     * @param GetCustomerHeaders $headers GetCustomerHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return GetCustomerResponse GetCustomerResponse
     */
    public function getCustomerWithOptions($request, $headers, $runtime)
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
            'action'      => 'GetCustomer',
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/customers/details',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetCustomerResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取智能财务应用内维护的客户信息
     *  *
     * @param GetCustomerRequest $request GetCustomerRequest
     *
     * @return GetCustomerResponse GetCustomerResponse
     */
    public function getCustomer($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetCustomerHeaders([]);

        return $this->getCustomerWithOptions($request, $headers, $runtime);
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
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/financeAccounts/get',
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
     * @summary 获取智能财务套件模版信息
     *  *
     * @param GetFormTemplateInfoHeaders $headers GetFormTemplateInfoHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return GetFormTemplateInfoResponse GetFormTemplateInfoResponse
     */
    public function getFormTemplateInfoWithOptions($headers, $runtime)
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
            'action'      => 'GetFormTemplateInfo',
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/formTemplates/infos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetFormTemplateInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取智能财务套件模版信息
     *  *
     * @return GetFormTemplateInfoResponse GetFormTemplateInfoResponse
     */
    public function getFormTemplateInfo()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetFormTemplateInfoHeaders([]);

        return $this->getFormTemplateInfoWithOptions($headers, $runtime);
    }

    /**
     * @summary 发票分页查询接口
     *  *
     * @param GetInvoiceByPageRequest $tmpReq  GetInvoiceByPageRequest
     * @param GetInvoiceByPageHeaders $headers GetInvoiceByPageHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return GetInvoiceByPageResponse GetInvoiceByPageResponse
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
            $query['request'] = $request->requestShrink;
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
            'action'      => 'GetInvoiceByPage',
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/invoices',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetInvoiceByPageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 发票分页查询接口
     *  *
     * @param GetInvoiceByPageRequest $request GetInvoiceByPageRequest
     *
     * @return GetInvoiceByPageResponse GetInvoiceByPageResponse
     */
    public function getInvoiceByPage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetInvoiceByPageHeaders([]);

        return $this->getInvoiceByPageWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 用来给isv提供是否使用智能账本的判断接口
     *  *
     * @param GetIsNewVersionHeaders $headers GetIsNewVersionHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return GetIsNewVersionResponse GetIsNewVersionResponse
     */
    public function getIsNewVersionWithOptions($headers, $runtime)
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
            'action'      => 'GetIsNewVersion',
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/accounts/uses',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetIsNewVersionResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 用来给isv提供是否使用智能账本的判断接口
     *  *
     * @return GetIsNewVersionResponse GetIsNewVersionResponse
     */
    public function getIsNewVersion()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetIsNewVersionHeaders([]);

        return $this->getIsNewVersionWithOptions($headers, $runtime);
    }

    /**
     * @summary 根据comanyCode查询钉钉智能财务多主体信息
     *  *
     * @param string                           $companyCode
     * @param GetMultiCompanyInfoByCodeHeaders $headers     GetMultiCompanyInfoByCodeHeaders
     * @param RuntimeOptions                   $runtime     runtime options for this request RuntimeOptions
     *
     * @return GetMultiCompanyInfoByCodeResponse GetMultiCompanyInfoByCodeResponse
     */
    public function getMultiCompanyInfoByCodeWithOptions($companyCode, $headers, $runtime)
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
            'action'      => 'GetMultiCompanyInfoByCode',
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/multiCompanies/' . $companyCode . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetMultiCompanyInfoByCodeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据comanyCode查询钉钉智能财务多主体信息
     *  *
     * @param string $companyCode
     *
     * @return GetMultiCompanyInfoByCodeResponse GetMultiCompanyInfoByCodeResponse
     */
    public function getMultiCompanyInfoByCode($companyCode)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetMultiCompanyInfoByCodeHeaders([]);

        return $this->getMultiCompanyInfoByCodeWithOptions($companyCode, $headers, $runtime);
    }

    /**
     * @summary 获取商品信息
     *  *
     * @param GetProductRequest $request GetProductRequest
     * @param GetProductHeaders $headers GetProductHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return GetProductResponse GetProductResponse
     */
    public function getProductWithOptions($request, $headers, $runtime)
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
            'action'      => 'GetProduct',
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/products',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetProductResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取商品信息
     *  *
     * @param GetProductRequest $request GetProductRequest
     *
     * @return GetProductResponse GetProductResponse
     */
    public function getProduct($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetProductHeaders([]);

        return $this->getProductWithOptions($request, $headers, $runtime);
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
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/projects/get',
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
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/receipts/details',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
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
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/suppliers/details',
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
     * @summary 获取用友开放平台接口鉴权信息
     *  *
     * @param GetYongYouOpenApiTokenRequest $request GetYongYouOpenApiTokenRequest
     * @param GetYongYouOpenApiTokenHeaders $headers GetYongYouOpenApiTokenHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return GetYongYouOpenApiTokenResponse GetYongYouOpenApiTokenResponse
     */
    public function getYongYouOpenApiTokenWithOptions($request, $headers, $runtime)
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
            'action'      => 'GetYongYouOpenApiToken',
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/yongyou/token',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetYongYouOpenApiTokenResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取用友开放平台接口鉴权信息
     *  *
     * @param GetYongYouOpenApiTokenRequest $request GetYongYouOpenApiTokenRequest
     *
     * @return GetYongYouOpenApiTokenResponse GetYongYouOpenApiTokenResponse
     */
    public function getYongYouOpenApiToken($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetYongYouOpenApiTokenHeaders([]);

        return $this->getYongYouOpenApiTokenWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询钉钉组织绑定的畅捷通组织
     *  *
     * @param GetYongYouOrgRelationHeaders $headers GetYongYouOrgRelationHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return GetYongYouOrgRelationResponse GetYongYouOrgRelationResponse
     */
    public function getYongYouOrgRelationWithOptions($headers, $runtime)
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
            'action'      => 'GetYongYouOrgRelation',
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/yongyou/relations',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetYongYouOrgRelationResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询钉钉组织绑定的畅捷通组织
     *  *
     * @return GetYongYouOrgRelationResponse GetYongYouOrgRelationResponse
     */
    public function getYongYouOrgRelation()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetYongYouOrgRelationHeaders([]);

        return $this->getYongYouOrgRelationWithOptions($headers, $runtime);
    }

    /**
     * @summary 权益核销
     *  *
     * @param ProfessionBenefitConsumeRequest $request ProfessionBenefitConsumeRequest
     * @param ProfessionBenefitConsumeHeaders $headers ProfessionBenefitConsumeHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return ProfessionBenefitConsumeResponse ProfessionBenefitConsumeResponse
     */
    public function professionBenefitConsumeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->benefitCode)) {
            $body['benefitCode'] = $request->benefitCode;
        }
        if (!Utils::isUnset($request->bizRequestId)) {
            $body['bizRequestId'] = $request->bizRequestId;
        }
        if (!Utils::isUnset($request->quota)) {
            $body['quota'] = $request->quota;
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
            'action'      => 'ProfessionBenefitConsume',
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/professions/benefits/consume',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ProfessionBenefitConsumeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 权益核销
     *  *
     * @param ProfessionBenefitConsumeRequest $request ProfessionBenefitConsumeRequest
     *
     * @return ProfessionBenefitConsumeResponse ProfessionBenefitConsumeResponse
     */
    public function professionBenefitConsume($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ProfessionBenefitConsumeHeaders([]);

        return $this->professionBenefitConsumeWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 触发单据同步给有成
     *  *
     * @param PushHistoricalReceiptsRequest $request PushHistoricalReceiptsRequest
     * @param PushHistoricalReceiptsHeaders $headers PushHistoricalReceiptsHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return PushHistoricalReceiptsResponse PushHistoricalReceiptsResponse
     */
    public function pushHistoricalReceiptsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizId)) {
            $body['bizId'] = $request->bizId;
        }
        if (!Utils::isUnset($request->endTime)) {
            $body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->forcedIgnoreDup)) {
            $body['forcedIgnoreDup'] = $request->forcedIgnoreDup;
        }
        if (!Utils::isUnset($request->formCodeList)) {
            $body['formCodeList'] = $request->formCodeList;
        }
        if (!Utils::isUnset($request->startTime)) {
            $body['startTime'] = $request->startTime;
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
            'action'      => 'PushHistoricalReceipts',
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/budgets/historicalReceipts/push',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return PushHistoricalReceiptsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 触发单据同步给有成
     *  *
     * @param PushHistoricalReceiptsRequest $request PushHistoricalReceiptsRequest
     *
     * @return PushHistoricalReceiptsResponse PushHistoricalReceiptsResponse
     */
    public function pushHistoricalReceipts($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PushHistoricalReceiptsHeaders([]);

        return $this->pushHistoricalReceiptsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询智能财务计量型权益
     *  *
     * @param QueryBenefitRequest $request QueryBenefitRequest
     * @param QueryBenefitHeaders $headers QueryBenefitHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryBenefitResponse QueryBenefitResponse
     */
    public function queryBenefitWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->benefitCode)) {
            $query['benefitCode'] = $request->benefitCode;
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
            'action'      => 'QueryBenefit',
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/benefits',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryBenefitResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询智能财务计量型权益
     *  *
     * @param QueryBenefitRequest $request QueryBenefitRequest
     *
     * @return QueryBenefitResponse QueryBenefitResponse
     */
    public function queryBenefit($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryBenefitHeaders([]);

        return $this->queryBenefitWithOptions($request, $headers, $runtime);
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
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/categories/list',
            'method'      => 'GET',
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
     * @summary 查询某个主体的开票申请单的提单数量
     *  *
     * @param QueryCompanyInvoiceRelationCountRequest $request QueryCompanyInvoiceRelationCountRequest
     * @param QueryCompanyInvoiceRelationCountHeaders $headers QueryCompanyInvoiceRelationCountHeaders
     * @param RuntimeOptions                          $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryCompanyInvoiceRelationCountResponse QueryCompanyInvoiceRelationCountResponse
     */
    public function queryCompanyInvoiceRelationCountWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->companyCode)) {
            $query['companyCode'] = $request->companyCode;
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
            'action'      => 'QueryCompanyInvoiceRelationCount',
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/invoices/companyRelationReceipts/counts',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryCompanyInvoiceRelationCountResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询某个主体的开票申请单的提单数量
     *  *
     * @param QueryCompanyInvoiceRelationCountRequest $request QueryCompanyInvoiceRelationCountRequest
     *
     * @return QueryCompanyInvoiceRelationCountResponse QueryCompanyInvoiceRelationCountResponse
     */
    public function queryCompanyInvoiceRelationCount($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryCompanyInvoiceRelationCountHeaders([]);

        return $this->queryCompanyInvoiceRelationCountWithOptions($request, $headers, $runtime);
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
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/customers',
            'method'      => 'GET',
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
     * @summary 提供给合作伙伴，查询智能财务的客户配置信息
     *  *
     * @param QueryCustomerInfoRequest $request QueryCustomerInfoRequest
     * @param QueryCustomerInfoHeaders $headers QueryCustomerInfoHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryCustomerInfoResponse QueryCustomerInfoResponse
     */
    public function queryCustomerInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->keyword)) {
            $query['keyword'] = $request->keyword;
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
            'action'      => 'QueryCustomerInfo',
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/auxiliaries/customers',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryCustomerInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 提供给合作伙伴，查询智能财务的客户配置信息
     *  *
     * @param QueryCustomerInfoRequest $request QueryCustomerInfoRequest
     *
     * @return QueryCustomerInfoResponse QueryCustomerInfoResponse
     */
    public function queryCustomerInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryCustomerInfoHeaders([]);

        return $this->queryCustomerInfoWithOptions($request, $headers, $runtime);
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
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/financeAccounts/list',
            'method'      => 'GET',
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
     * @summary 查询智能财务配置的企业信息
     *  *
     * @param QueryFinanceCompanyInfoHeaders $headers QueryFinanceCompanyInfoHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryFinanceCompanyInfoResponse QueryFinanceCompanyInfoResponse
     */
    public function queryFinanceCompanyInfoWithOptions($headers, $runtime)
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
            'action'      => 'QueryFinanceCompanyInfo',
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/companies',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryFinanceCompanyInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询智能财务配置的企业信息
     *  *
     * @return QueryFinanceCompanyInfoResponse QueryFinanceCompanyInfoResponse
     */
    public function queryFinanceCompanyInfo()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryFinanceCompanyInfoHeaders([]);

        return $this->queryFinanceCompanyInfoWithOptions($headers, $runtime);
    }

    /**
     * @summary 查询开票申请单的提单数量
     *  *
     * @param QueryInvoiceRelationCountHeaders $headers QueryInvoiceRelationCountHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryInvoiceRelationCountResponse QueryInvoiceRelationCountResponse
     */
    public function queryInvoiceRelationCountWithOptions($headers, $runtime)
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
            'action'      => 'QueryInvoiceRelationCount',
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/invoices/relationReceipts/counts',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryInvoiceRelationCountResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询开票申请单的提单数量
     *  *
     * @return QueryInvoiceRelationCountResponse QueryInvoiceRelationCountResponse
     */
    public function queryInvoiceRelationCount()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryInvoiceRelationCountHeaders([]);

        return $this->queryInvoiceRelationCountWithOptions($headers, $runtime);
    }

    /**
     * @summary 查询钉钉智能财务多主体信息
     *  *
     * @param QueryMultiCompanyInfoHeaders $headers QueryMultiCompanyInfoHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryMultiCompanyInfoResponse QueryMultiCompanyInfoResponse
     */
    public function queryMultiCompanyInfoWithOptions($headers, $runtime)
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
            'action'      => 'QueryMultiCompanyInfo',
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/multiCompanies',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryMultiCompanyInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询钉钉智能财务多主体信息
     *  *
     * @return QueryMultiCompanyInfoResponse QueryMultiCompanyInfoResponse
     */
    public function queryMultiCompanyInfo()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryMultiCompanyInfoHeaders([]);

        return $this->queryMultiCompanyInfoWithOptions($headers, $runtime);
    }

    /**
     * @summary 提供给小望，查询当前用户所具有的的小望权限点信息
     *  *
     * @param QueryPermissionByUserIdRequest $request QueryPermissionByUserIdRequest
     * @param QueryPermissionByUserIdHeaders $headers QueryPermissionByUserIdHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryPermissionByUserIdResponse QueryPermissionByUserIdResponse
     */
    public function queryPermissionByUserIdWithOptions($request, $headers, $runtime)
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
            'action'      => 'QueryPermissionByUserId',
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/permissions',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryPermissionByUserIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 提供给小望，查询当前用户所具有的的小望权限点信息
     *  *
     * @param QueryPermissionByUserIdRequest $request QueryPermissionByUserIdRequest
     *
     * @return QueryPermissionByUserIdResponse QueryPermissionByUserIdResponse
     */
    public function queryPermissionByUserId($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryPermissionByUserIdHeaders([]);

        return $this->queryPermissionByUserIdWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询智能财务角色下的成员信息
     *  *
     * @param QueryPermissionRoleMemberRequest $request QueryPermissionRoleMemberRequest
     * @param QueryPermissionRoleMemberHeaders $headers QueryPermissionRoleMemberHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryPermissionRoleMemberResponse QueryPermissionRoleMemberResponse
     */
    public function queryPermissionRoleMemberWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->companyCode)) {
            $body['companyCode'] = $request->companyCode;
        }
        if (!Utils::isUnset($request->roleCodeList)) {
            $body['roleCodeList'] = $request->roleCodeList;
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
            'action'      => 'QueryPermissionRoleMember',
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/roles/members/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryPermissionRoleMemberResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询智能财务角色下的成员信息
     *  *
     * @param QueryPermissionRoleMemberRequest $request QueryPermissionRoleMemberRequest
     *
     * @return QueryPermissionRoleMemberResponse QueryPermissionRoleMemberResponse
     */
    public function queryPermissionRoleMember($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryPermissionRoleMemberHeaders([]);

        return $this->queryPermissionRoleMemberWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量获取商品信息
     *  *
     * @param QueryProductByPageRequest $request QueryProductByPageRequest
     * @param QueryProductByPageHeaders $headers QueryProductByPageHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryProductByPageResponse QueryProductByPageResponse
     */
    public function queryProductByPageWithOptions($request, $headers, $runtime)
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
            'action'      => 'QueryProductByPage',
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/products/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryProductByPageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量获取商品信息
     *  *
     * @param QueryProductByPageRequest $request QueryProductByPageRequest
     *
     * @return QueryProductByPageResponse QueryProductByPageResponse
     */
    public function queryProductByPage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryProductByPageHeaders([]);

        return $this->queryProductByPageWithOptions($request, $headers, $runtime);
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
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/projects/list',
            'method'      => 'GET',
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
     * @summary 查询开票申请单详情
     *  *
     * @param QueryReceiptDetailForInvoiceRequest $request QueryReceiptDetailForInvoiceRequest
     * @param QueryReceiptDetailForInvoiceHeaders $headers QueryReceiptDetailForInvoiceHeaders
     * @param RuntimeOptions                      $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryReceiptDetailForInvoiceResponse QueryReceiptDetailForInvoiceResponse
     */
    public function queryReceiptDetailForInvoiceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->instanceId)) {
            $query['instanceId'] = $request->instanceId;
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
            'action'      => 'QueryReceiptDetailForInvoice',
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/invoices/receipts/details',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryReceiptDetailForInvoiceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询开票申请单详情
     *  *
     * @param QueryReceiptDetailForInvoiceRequest $request QueryReceiptDetailForInvoiceRequest
     *
     * @return QueryReceiptDetailForInvoiceResponse QueryReceiptDetailForInvoiceResponse
     */
    public function queryReceiptDetailForInvoice($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryReceiptDetailForInvoiceHeaders([]);

        return $this->queryReceiptDetailForInvoiceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量查询智能财务单据主数据信息
     *  *
     * @param QueryReceiptForInvoiceRequest $request QueryReceiptForInvoiceRequest
     * @param QueryReceiptForInvoiceHeaders $headers QueryReceiptForInvoiceHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryReceiptForInvoiceResponse QueryReceiptForInvoiceResponse
     */
    public function queryReceiptForInvoiceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->accountantBookId)) {
            $body['accountantBookId'] = $request->accountantBookId;
        }
        if (!Utils::isUnset($request->applyStatusList)) {
            $body['applyStatusList'] = $request->applyStatusList;
        }
        if (!Utils::isUnset($request->bizStatusList)) {
            $body['bizStatusList'] = $request->bizStatusList;
        }
        if (!Utils::isUnset($request->companyCode)) {
            $body['companyCode'] = $request->companyCode;
        }
        if (!Utils::isUnset($request->endTime)) {
            $body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $body['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->receiptStatusList)) {
            $body['receiptStatusList'] = $request->receiptStatusList;
        }
        if (!Utils::isUnset($request->searchParams)) {
            $body['searchParams'] = $request->searchParams;
        }
        if (!Utils::isUnset($request->startTime)) {
            $body['startTime'] = $request->startTime;
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
            'action'      => 'QueryReceiptForInvoice',
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/invoices/receipts/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryReceiptForInvoiceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量查询智能财务单据主数据信息
     *  *
     * @param QueryReceiptForInvoiceRequest $request QueryReceiptForInvoiceRequest
     *
     * @return QueryReceiptForInvoiceResponse QueryReceiptForInvoiceResponse
     */
    public function queryReceiptForInvoice($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryReceiptForInvoiceHeaders([]);

        return $this->queryReceiptForInvoiceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量查询智能财务的单据主数据基本信息
     *  *
     * @param QueryReceiptsBaseInfoRequest $request QueryReceiptsBaseInfoRequest
     * @param QueryReceiptsBaseInfoHeaders $headers QueryReceiptsBaseInfoHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryReceiptsBaseInfoResponse QueryReceiptsBaseInfoResponse
     */
    public function queryReceiptsBaseInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->accountantBookId)) {
            $query['accountantBookId'] = $request->accountantBookId;
        }
        if (!Utils::isUnset($request->amountEnd)) {
            $query['amountEnd'] = $request->amountEnd;
        }
        if (!Utils::isUnset($request->amountStart)) {
            $query['amountStart'] = $request->amountStart;
        }
        if (!Utils::isUnset($request->companyCode)) {
            $query['companyCode'] = $request->companyCode;
        }
        if (!Utils::isUnset($request->endTime)) {
            $query['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->startTime)) {
            $query['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->timeFilterField)) {
            $query['timeFilterField'] = $request->timeFilterField;
        }
        if (!Utils::isUnset($request->title)) {
            $query['title'] = $request->title;
        }
        if (!Utils::isUnset($request->voucherStatus)) {
            $query['voucherStatus'] = $request->voucherStatus;
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
            'action'      => 'QueryReceiptsBaseInfo',
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/receipts/dataInfos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryReceiptsBaseInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量查询智能财务的单据主数据基本信息
     *  *
     * @param QueryReceiptsBaseInfoRequest $request QueryReceiptsBaseInfoRequest
     *
     * @return QueryReceiptsBaseInfoResponse QueryReceiptsBaseInfoResponse
     */
    public function queryReceiptsBaseInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryReceiptsBaseInfoHeaders([]);

        return $this->queryReceiptsBaseInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 分页获取智能财务单据详情列表
     *  *
     * @param QueryReceiptsByPageRequest $request QueryReceiptsByPageRequest
     * @param QueryReceiptsByPageHeaders $headers QueryReceiptsByPageHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryReceiptsByPageResponse QueryReceiptsByPageResponse
     */
    public function queryReceiptsByPageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->endTime)) {
            $query['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->modelId)) {
            $query['modelId'] = $request->modelId;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->startTime)) {
            $query['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->timeFilterField)) {
            $query['timeFilterField'] = $request->timeFilterField;
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
            'action'      => 'QueryReceiptsByPage',
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/receipts',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QueryReceiptsByPageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 分页获取智能财务单据详情列表
     *  *
     * @param QueryReceiptsByPageRequest $request QueryReceiptsByPageRequest
     *
     * @return QueryReceiptsByPageResponse QueryReceiptsByPageResponse
     */
    public function queryReceiptsByPage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryReceiptsByPageHeaders([]);

        return $this->queryReceiptsByPageWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 分页查询智能财务角色下的成员信息
     *  *
     * @param QueryRoleMemberByPageRequest $request QueryRoleMemberByPageRequest
     * @param QueryRoleMemberByPageHeaders $headers QueryRoleMemberByPageHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryRoleMemberByPageResponse QueryRoleMemberByPageResponse
     */
    public function queryRoleMemberByPageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->companyCode)) {
            $query['companyCode'] = $request->companyCode;
        }
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->roleCode)) {
            $query['roleCode'] = $request->roleCode;
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
            'action'      => 'QueryRoleMemberByPage',
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/roles/members',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryRoleMemberByPageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 分页查询智能财务角色下的成员信息
     *  *
     * @param QueryRoleMemberByPageRequest $request QueryRoleMemberByPageRequest
     *
     * @return QueryRoleMemberByPageResponse QueryRoleMemberByPageResponse
     */
    public function queryRoleMemberByPage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryRoleMemberByPageHeaders([]);

        return $this->queryRoleMemberByPageWithOptions($request, $headers, $runtime);
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
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/suppliers',
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
     * @summary 查询用户角色
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
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/users/roles',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryUserRoleListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询用户角色
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
     * @summary 解绑开票申请单关联的发票
     *  *
     * @param UnbindApplyReceiptAndInvoiceRelatedRequest $request UnbindApplyReceiptAndInvoiceRelatedRequest
     * @param UnbindApplyReceiptAndInvoiceRelatedHeaders $headers UnbindApplyReceiptAndInvoiceRelatedHeaders
     * @param RuntimeOptions                             $runtime runtime options for this request RuntimeOptions
     *
     * @return UnbindApplyReceiptAndInvoiceRelatedResponse UnbindApplyReceiptAndInvoiceRelatedResponse
     */
    public function unbindApplyReceiptAndInvoiceRelatedWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->instanceId)) {
            $body['instanceId'] = $request->instanceId;
        }
        if (!Utils::isUnset($request->invoiceKeyVOList)) {
            $body['invoiceKeyVOList'] = $request->invoiceKeyVOList;
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
            'action'      => 'UnbindApplyReceiptAndInvoiceRelated',
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/invoices/unbind',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UnbindApplyReceiptAndInvoiceRelatedResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 解绑开票申请单关联的发票
     *  *
     * @param UnbindApplyReceiptAndInvoiceRelatedRequest $request UnbindApplyReceiptAndInvoiceRelatedRequest
     *
     * @return UnbindApplyReceiptAndInvoiceRelatedResponse UnbindApplyReceiptAndInvoiceRelatedResponse
     */
    public function unbindApplyReceiptAndInvoiceRelated($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UnbindApplyReceiptAndInvoiceRelatedHeaders([]);

        return $this->unbindApplyReceiptAndInvoiceRelatedWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 开票申请单关联发票
     *  *
     * @param UpdateApplyReceiptAndInvoiceRelatedRequest $request UpdateApplyReceiptAndInvoiceRelatedRequest
     * @param UpdateApplyReceiptAndInvoiceRelatedHeaders $headers UpdateApplyReceiptAndInvoiceRelatedHeaders
     * @param RuntimeOptions                             $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateApplyReceiptAndInvoiceRelatedResponse UpdateApplyReceiptAndInvoiceRelatedResponse
     */
    public function updateApplyReceiptAndInvoiceRelatedWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->generalInvoiceVOList)) {
            $body['generalInvoiceVOList'] = $request->generalInvoiceVOList;
        }
        if (!Utils::isUnset($request->instanceId)) {
            $body['instanceId'] = $request->instanceId;
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
            'action'      => 'UpdateApplyReceiptAndInvoiceRelated',
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/invoices/applyReceipts/relate',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateApplyReceiptAndInvoiceRelatedResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 开票申请单关联发票
     *  *
     * @param UpdateApplyReceiptAndInvoiceRelatedRequest $request UpdateApplyReceiptAndInvoiceRelatedRequest
     *
     * @return UpdateApplyReceiptAndInvoiceRelatedResponse UpdateApplyReceiptAndInvoiceRelatedResponse
     */
    public function updateApplyReceiptAndInvoiceRelated($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateApplyReceiptAndInvoiceRelatedHeaders([]);

        return $this->updateApplyReceiptAndInvoiceRelatedWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新全电发票企业信息
     *  *
     * @param UpdateDigitalInvoiceOrgInfoRequest $request UpdateDigitalInvoiceOrgInfoRequest
     * @param UpdateDigitalInvoiceOrgInfoHeaders $headers UpdateDigitalInvoiceOrgInfoHeaders
     * @param RuntimeOptions                     $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateDigitalInvoiceOrgInfoResponse UpdateDigitalInvoiceOrgInfoResponse
     */
    public function updateDigitalInvoiceOrgInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->digitalInvoiceType)) {
            $body['digitalInvoiceType'] = $request->digitalInvoiceType;
        }
        if (!Utils::isUnset($request->isDigitalOrg)) {
            $body['isDigitalOrg'] = $request->isDigitalOrg;
        }
        if (!Utils::isUnset($request->location)) {
            $body['location'] = $request->location;
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
            'action'      => 'UpdateDigitalInvoiceOrgInfo',
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/invoices/organizationInfos',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateDigitalInvoiceOrgInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新全电发票企业信息
     *  *
     * @param UpdateDigitalInvoiceOrgInfoRequest $request UpdateDigitalInvoiceOrgInfoRequest
     *
     * @return UpdateDigitalInvoiceOrgInfoResponse UpdateDigitalInvoiceOrgInfoResponse
     */
    public function updateDigitalInvoiceOrgInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateDigitalInvoiceOrgInfoHeaders([]);

        return $this->updateDigitalInvoiceOrgInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新智能财务配置的企业信息
     *  *
     * @param UpdateFinanceCompanyInfoRequest $request UpdateFinanceCompanyInfoRequest
     * @param UpdateFinanceCompanyInfoHeaders $headers UpdateFinanceCompanyInfoHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateFinanceCompanyInfoResponse UpdateFinanceCompanyInfoResponse
     */
    public function updateFinanceCompanyInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->companyName)) {
            $query['companyName'] = $request->companyName;
        }
        if (!Utils::isUnset($request->taxNature)) {
            $query['taxNature'] = $request->taxNature;
        }
        if (!Utils::isUnset($request->taxNo)) {
            $query['taxNo'] = $request->taxNo;
        }
        if (!Utils::isUnset($request->taxOrInvoiceHasInit)) {
            $query['taxOrInvoiceHasInit'] = $request->taxOrInvoiceHasInit;
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
            'action'      => 'UpdateFinanceCompanyInfo',
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/companies',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateFinanceCompanyInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新智能财务配置的企业信息
     *  *
     * @param UpdateFinanceCompanyInfoRequest $request UpdateFinanceCompanyInfoRequest
     *
     * @return UpdateFinanceCompanyInfoResponse UpdateFinanceCompanyInfoResponse
     */
    public function updateFinanceCompanyInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateFinanceCompanyInfoHeaders([]);

        return $this->updateFinanceCompanyInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新钉钉智能财务多主体信息
     *  *
     * @param UpdateFinanceMultiCompanyInfoRequest $request UpdateFinanceMultiCompanyInfoRequest
     * @param UpdateFinanceMultiCompanyInfoHeaders $headers UpdateFinanceMultiCompanyInfoHeaders
     * @param RuntimeOptions                       $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateFinanceMultiCompanyInfoResponse UpdateFinanceMultiCompanyInfoResponse
     */
    public function updateFinanceMultiCompanyInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->companyCode)) {
            $query['companyCode'] = $request->companyCode;
        }
        if (!Utils::isUnset($request->companyName)) {
            $query['companyName'] = $request->companyName;
        }
        if (!Utils::isUnset($request->taxNature)) {
            $query['taxNature'] = $request->taxNature;
        }
        if (!Utils::isUnset($request->taxNo)) {
            $query['taxNo'] = $request->taxNo;
        }
        if (!Utils::isUnset($request->taxOrInvoiceHasInit)) {
            $query['taxOrInvoiceHasInit'] = $request->taxOrInvoiceHasInit;
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
            'action'      => 'UpdateFinanceMultiCompanyInfo',
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/multiCompanies',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateFinanceMultiCompanyInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新钉钉智能财务多主体信息
     *  *
     * @param UpdateFinanceMultiCompanyInfoRequest $request UpdateFinanceMultiCompanyInfoRequest
     *
     * @return UpdateFinanceMultiCompanyInfoResponse UpdateFinanceMultiCompanyInfoResponse
     */
    public function updateFinanceMultiCompanyInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateFinanceMultiCompanyInfoHeaders([]);

        return $this->updateFinanceMultiCompanyInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 发票红冲/废弃状态变更接口
     *  *
     * @param UpdateInvoiceAbandonStatusRequest $request UpdateInvoiceAbandonStatusRequest
     * @param UpdateInvoiceAbandonStatusHeaders $headers UpdateInvoiceAbandonStatusHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateInvoiceAbandonStatusResponse UpdateInvoiceAbandonStatusResponse
     */
    public function updateInvoiceAbandonStatusWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->blueGeneralInvoiceVO)) {
            $body['blueGeneralInvoiceVO'] = $request->blueGeneralInvoiceVO;
        }
        if (!Utils::isUnset($request->blueInvoiceCode)) {
            $body['blueInvoiceCode'] = $request->blueInvoiceCode;
        }
        if (!Utils::isUnset($request->blueInvoiceNo)) {
            $body['blueInvoiceNo'] = $request->blueInvoiceNo;
        }
        if (!Utils::isUnset($request->blueInvoiceStatus)) {
            $body['blueInvoiceStatus'] = $request->blueInvoiceStatus;
        }
        if (!Utils::isUnset($request->companyCode)) {
            $body['companyCode'] = $request->companyCode;
        }
        if (!Utils::isUnset($request->operator)) {
            $body['operator'] = $request->operator;
        }
        if (!Utils::isUnset($request->redGeneralInvoiceVO)) {
            $body['redGeneralInvoiceVO'] = $request->redGeneralInvoiceVO;
        }
        if (!Utils::isUnset($request->redInvoiceCode)) {
            $body['redInvoiceCode'] = $request->redInvoiceCode;
        }
        if (!Utils::isUnset($request->redInvoiceNo)) {
            $body['redInvoiceNo'] = $request->redInvoiceNo;
        }
        if (!Utils::isUnset($request->redInvoiceStatus)) {
            $body['redInvoiceStatus'] = $request->redInvoiceStatus;
        }
        if (!Utils::isUnset($request->targetInvoice)) {
            $body['targetInvoice'] = $request->targetInvoice;
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
            'action'      => 'UpdateInvoiceAbandonStatus',
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/invoices/abandonStatus',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateInvoiceAbandonStatusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 发票红冲/废弃状态变更接口
     *  *
     * @param UpdateInvoiceAbandonStatusRequest $request UpdateInvoiceAbandonStatusRequest
     *
     * @return UpdateInvoiceAbandonStatusResponse UpdateInvoiceAbandonStatusResponse
     */
    public function updateInvoiceAbandonStatus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateInvoiceAbandonStatusHeaders([]);

        return $this->updateInvoiceAbandonStatusWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新发票账期状态
     *  *
     * @param UpdateInvoiceAccountPeriodRequest $request UpdateInvoiceAccountPeriodRequest
     * @param UpdateInvoiceAccountPeriodHeaders $headers UpdateInvoiceAccountPeriodHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateInvoiceAccountPeriodResponse UpdateInvoiceAccountPeriodResponse
     */
    public function updateInvoiceAccountPeriodWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->accountPeriod)) {
            $body['accountPeriod'] = $request->accountPeriod;
        }
        if (!Utils::isUnset($request->companyCode)) {
            $body['companyCode'] = $request->companyCode;
        }
        if (!Utils::isUnset($request->generalInvoiceVOList)) {
            $body['generalInvoiceVOList'] = $request->generalInvoiceVOList;
        }
        if (!Utils::isUnset($request->invoiceKeyVOList)) {
            $body['invoiceKeyVOList'] = $request->invoiceKeyVOList;
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
            'action'      => 'UpdateInvoiceAccountPeriod',
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/invoices/accountPeriods',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateInvoiceAccountPeriodResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新发票账期状态
     *  *
     * @param UpdateInvoiceAccountPeriodRequest $request UpdateInvoiceAccountPeriodRequest
     *
     * @return UpdateInvoiceAccountPeriodResponse UpdateInvoiceAccountPeriodResponse
     */
    public function updateInvoiceAccountPeriod($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateInvoiceAccountPeriodHeaders([]);

        return $this->updateInvoiceAccountPeriodWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新全电企业入账时间
     *  *
     * @param UpdateInvoiceAccountingPeriodDateRequest $request UpdateInvoiceAccountingPeriodDateRequest
     * @param UpdateInvoiceAccountingPeriodDateHeaders $headers UpdateInvoiceAccountingPeriodDateHeaders
     * @param RuntimeOptions                           $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateInvoiceAccountingPeriodDateResponse UpdateInvoiceAccountingPeriodDateResponse
     */
    public function updateInvoiceAccountingPeriodDateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->companyCode)) {
            $body['companyCode'] = $request->companyCode;
        }
        if (!Utils::isUnset($request->invoiceFinanceInfoVOList)) {
            $body['invoiceFinanceInfoVOList'] = $request->invoiceFinanceInfoVOList;
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
            'action'      => 'UpdateInvoiceAccountingPeriodDate',
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/invoices/accounts/periodDates',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateInvoiceAccountingPeriodDateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新全电企业入账时间
     *  *
     * @param UpdateInvoiceAccountingPeriodDateRequest $request UpdateInvoiceAccountingPeriodDateRequest
     *
     * @return UpdateInvoiceAccountingPeriodDateResponse UpdateInvoiceAccountingPeriodDateResponse
     */
    public function updateInvoiceAccountingPeriodDate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateInvoiceAccountingPeriodDateHeaders([]);

        return $this->updateInvoiceAccountingPeriodDateWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新全电企业入账状态
     *  *
     * @param UpdateInvoiceAccountingStatusRequest $request UpdateInvoiceAccountingStatusRequest
     * @param UpdateInvoiceAccountingStatusHeaders $headers UpdateInvoiceAccountingStatusHeaders
     * @param RuntimeOptions                       $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateInvoiceAccountingStatusResponse UpdateInvoiceAccountingStatusResponse
     */
    public function updateInvoiceAccountingStatusWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->companyCode)) {
            $body['companyCode'] = $request->companyCode;
        }
        if (!Utils::isUnset($request->invoiceFinanceInfoVOList)) {
            $body['invoiceFinanceInfoVOList'] = $request->invoiceFinanceInfoVOList;
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
            'action'      => 'UpdateInvoiceAccountingStatus',
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/invoices/accounts/statuses',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateInvoiceAccountingStatusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新全电企业入账状态
     *  *
     * @param UpdateInvoiceAccountingStatusRequest $request UpdateInvoiceAccountingStatusRequest
     *
     * @return UpdateInvoiceAccountingStatusResponse UpdateInvoiceAccountingStatusResponse
     */
    public function updateInvoiceAccountingStatus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateInvoiceAccountingStatusHeaders([]);

        return $this->updateInvoiceAccountingStatusWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新发票关联审批单
     *  *
     * @param UpdateInvoiceAndReceiptRelatedRequest $request UpdateInvoiceAndReceiptRelatedRequest
     * @param UpdateInvoiceAndReceiptRelatedHeaders $headers UpdateInvoiceAndReceiptRelatedHeaders
     * @param RuntimeOptions                        $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateInvoiceAndReceiptRelatedResponse UpdateInvoiceAndReceiptRelatedResponse
     */
    public function updateInvoiceAndReceiptRelatedWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->generalInvoiceVO)) {
            $body['generalInvoiceVO'] = $request->generalInvoiceVO;
        }
        if (!Utils::isUnset($request->invoiceCode)) {
            $body['invoiceCode'] = $request->invoiceCode;
        }
        if (!Utils::isUnset($request->invoiceNo)) {
            $body['invoiceNo'] = $request->invoiceNo;
        }
        if (!Utils::isUnset($request->operator)) {
            $body['operator'] = $request->operator;
        }
        if (!Utils::isUnset($request->receiptCode)) {
            $body['receiptCode'] = $request->receiptCode;
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
            'action'      => 'UpdateInvoiceAndReceiptRelated',
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/invoices/approvalReceipts',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateInvoiceAndReceiptRelatedResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新发票关联审批单
     *  *
     * @param UpdateInvoiceAndReceiptRelatedRequest $request UpdateInvoiceAndReceiptRelatedRequest
     *
     * @return UpdateInvoiceAndReceiptRelatedResponse UpdateInvoiceAndReceiptRelatedResponse
     */
    public function updateInvoiceAndReceiptRelated($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateInvoiceAndReceiptRelatedHeaders([]);

        return $this->updateInvoiceAndReceiptRelatedWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新发票忽略状态
     *  *
     * @param UpdateInvoiceIgnoreStatusRequest $request UpdateInvoiceIgnoreStatusRequest
     * @param UpdateInvoiceIgnoreStatusHeaders $headers UpdateInvoiceIgnoreStatusHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateInvoiceIgnoreStatusResponse UpdateInvoiceIgnoreStatusResponse
     */
    public function updateInvoiceIgnoreStatusWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->instanceId)) {
            $query['instanceId'] = $request->instanceId;
        }
        if (!Utils::isUnset($request->operator)) {
            $query['operator'] = $request->operator;
        }
        if (!Utils::isUnset($request->status)) {
            $query['status'] = $request->status;
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
            'action'      => 'UpdateInvoiceIgnoreStatus',
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/invoices/ignoreStatus',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateInvoiceIgnoreStatusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新发票忽略状态
     *  *
     * @param UpdateInvoiceIgnoreStatusRequest $request UpdateInvoiceIgnoreStatusRequest
     *
     * @return UpdateInvoiceIgnoreStatusResponse UpdateInvoiceIgnoreStatusResponse
     */
    public function updateInvoiceIgnoreStatus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateInvoiceIgnoreStatusHeaders([]);

        return $this->updateInvoiceIgnoreStatusWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 发票认证状态变更接口
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
        if (!Utils::isUnset($request->companyCode)) {
            $body['companyCode'] = $request->companyCode;
        }
        if (!Utils::isUnset($request->deductStatus)) {
            $body['deductStatus'] = $request->deductStatus;
        }
        if (!Utils::isUnset($request->generalInvoiceVOList)) {
            $body['generalInvoiceVOList'] = $request->generalInvoiceVOList;
        }
        if (!Utils::isUnset($request->invoiceKeyVOList)) {
            $body['invoiceKeyVOList'] = $request->invoiceKeyVOList;
        }
        if (!Utils::isUnset($request->operator)) {
            $body['operator'] = $request->operator;
        }
        if (!Utils::isUnset($request->verifyStatus)) {
            $body['verifyStatus'] = $request->verifyStatus;
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
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/invoices/verifyStatus',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateInvoiceVerifyStatusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 发票认证状态变更接口
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
     * @summary 更新发票生成凭证状态
     *  *
     * @param UpdateInvoiceVoucherStatusRequest $request UpdateInvoiceVoucherStatusRequest
     * @param UpdateInvoiceVoucherStatusHeaders $headers UpdateInvoiceVoucherStatusHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateInvoiceVoucherStatusResponse UpdateInvoiceVoucherStatusResponse
     */
    public function updateInvoiceVoucherStatusWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->accountantBookId)) {
            $body['accountantBookId'] = $request->accountantBookId;
        }
        if (!Utils::isUnset($request->actionType)) {
            $body['actionType'] = $request->actionType;
        }
        if (!Utils::isUnset($request->invoiceCode)) {
            $body['invoiceCode'] = $request->invoiceCode;
        }
        if (!Utils::isUnset($request->invoiceNo)) {
            $body['invoiceNo'] = $request->invoiceNo;
        }
        if (!Utils::isUnset($request->operator)) {
            $body['operator'] = $request->operator;
        }
        if (!Utils::isUnset($request->voucherId)) {
            $body['voucherId'] = $request->voucherId;
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
            'action'      => 'UpdateInvoiceVoucherStatus',
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/invoices/vouchers/states',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateInvoiceVoucherStatusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新发票生成凭证状态
     *  *
     * @param UpdateInvoiceVoucherStatusRequest $request UpdateInvoiceVoucherStatusRequest
     *
     * @return UpdateInvoiceVoucherStatusResponse UpdateInvoiceVoucherStatusResponse
     */
    public function updateInvoiceVoucherStatus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateInvoiceVoucherStatusHeaders([]);

        return $this->updateInvoiceVoucherStatusWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新智能财务单据
     *  *
     * @param UpdateReceiptRequest $request UpdateReceiptRequest
     * @param UpdateReceiptHeaders $headers UpdateReceiptHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateReceiptResponse UpdateReceiptResponse
     */
    public function updateReceiptWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->receipts)) {
            $body['receipts'] = $request->receipts;
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
            'action'      => 'UpdateReceipt',
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/receipts',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return UpdateReceiptResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新智能财务单据
     *  *
     * @param UpdateReceiptRequest $request UpdateReceiptRequest
     *
     * @return UpdateReceiptResponse UpdateReceiptResponse
     */
    public function updateReceipt($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateReceiptHeaders([]);

        return $this->updateReceiptWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新智能财务审批单的凭证状态
     *  *
     * @param UpdateReceiptVoucherStatusRequest $request UpdateReceiptVoucherStatusRequest
     * @param UpdateReceiptVoucherStatusHeaders $headers UpdateReceiptVoucherStatusHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateReceiptVoucherStatusResponse UpdateReceiptVoucherStatusResponse
     */
    public function updateReceiptVoucherStatusWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->accountPeriod)) {
            $body['accountPeriod'] = $request->accountPeriod;
        }
        if (!Utils::isUnset($request->actionType)) {
            $body['actionType'] = $request->actionType;
        }
        if (!Utils::isUnset($request->operatorId)) {
            $body['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->receiptId)) {
            $body['receiptId'] = $request->receiptId;
        }
        if (!Utils::isUnset($request->voucherCode)) {
            $body['voucherCode'] = $request->voucherCode;
        }
        if (!Utils::isUnset($request->voucherId)) {
            $body['voucherId'] = $request->voucherId;
        }
        if (!Utils::isUnset($request->voucherNo)) {
            $body['voucherNo'] = $request->voucherNo;
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
            'action'      => 'UpdateReceiptVoucherStatus',
            'version'     => 'bizfinance_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/bizfinance/vouchers/recepits',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateReceiptVoucherStatusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新智能财务审批单的凭证状态
     *  *
     * @param UpdateReceiptVoucherStatusRequest $request UpdateReceiptVoucherStatusRequest
     *
     * @return UpdateReceiptVoucherStatusResponse UpdateReceiptVoucherStatusResponse
     */
    public function updateReceiptVoucherStatus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateReceiptVoucherStatusHeaders([]);

        return $this->updateReceiptVoucherStatusWithOptions($request, $headers, $runtime);
    }
}
