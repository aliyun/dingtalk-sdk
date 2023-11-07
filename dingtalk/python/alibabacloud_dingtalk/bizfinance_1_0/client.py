# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_gateway_spi.client import Client as SPIClient
from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.bizfinance_1_0 import models as dingtalkbizfinance__1__0_models
from alibabacloud_tea_util import models as util_models
from alibabacloud_openapi_util.client import Client as OpenApiUtilClient


class Client(OpenApiClient):
    """
    *\
    """
    _client: SPIClient = None

    def __init__(
        self, 
        config: open_api_models.Config,
    ):
        super().__init__(config)
        self._client = GatewayClientClient()
        self._spi = self._client
        self._endpoint_rule = ''
        if UtilClient.empty(self._endpoint):
            self._endpoint = 'api.dingtalk.com'

    def append_role_permission_with_options(
        self,
        tmp_req: dingtalkbizfinance__1__0_models.AppendRolePermissionRequest,
        headers: dingtalkbizfinance__1__0_models.AppendRolePermissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.AppendRolePermissionResponse:
        UtilClient.validate_model(tmp_req)
        request = dingtalkbizfinance__1__0_models.AppendRolePermissionShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.role_permission_item_list):
            request.role_permission_item_list_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.role_permission_item_list, 'rolePermissionItemList', 'json')
        query = {}
        if not UtilClient.is_unset(request.role_permission_item_list_shrink):
            query['rolePermissionItemList'] = request.role_permission_item_list_shrink
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='AppendRolePermission',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/roles/permissions',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.AppendRolePermissionResponse(),
            self.execute(params, req, runtime)
        )

    async def append_role_permission_with_options_async(
        self,
        tmp_req: dingtalkbizfinance__1__0_models.AppendRolePermissionRequest,
        headers: dingtalkbizfinance__1__0_models.AppendRolePermissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.AppendRolePermissionResponse:
        UtilClient.validate_model(tmp_req)
        request = dingtalkbizfinance__1__0_models.AppendRolePermissionShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.role_permission_item_list):
            request.role_permission_item_list_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.role_permission_item_list, 'rolePermissionItemList', 'json')
        query = {}
        if not UtilClient.is_unset(request.role_permission_item_list_shrink):
            query['rolePermissionItemList'] = request.role_permission_item_list_shrink
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='AppendRolePermission',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/roles/permissions',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.AppendRolePermissionResponse(),
            await self.execute_async(params, req, runtime)
        )

    def append_role_permission(
        self,
        request: dingtalkbizfinance__1__0_models.AppendRolePermissionRequest,
    ) -> dingtalkbizfinance__1__0_models.AppendRolePermissionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.AppendRolePermissionHeaders()
        return self.append_role_permission_with_options(request, headers, runtime)

    async def append_role_permission_async(
        self,
        request: dingtalkbizfinance__1__0_models.AppendRolePermissionRequest,
    ) -> dingtalkbizfinance__1__0_models.AppendRolePermissionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.AppendRolePermissionHeaders()
        return await self.append_role_permission_with_options_async(request, headers, runtime)

    def batch_add_invoice_with_options(
        self,
        request: dingtalkbizfinance__1__0_models.BatchAddInvoiceRequest,
        headers: dingtalkbizfinance__1__0_models.BatchAddInvoiceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.BatchAddInvoiceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.company_code):
            body['companyCode'] = request.company_code
        if not UtilClient.is_unset(request.general_invoice_volist):
            body['generalInvoiceVOList'] = request.general_invoice_volist
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='BatchAddInvoice',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/invoices/batch',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.BatchAddInvoiceResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_add_invoice_with_options_async(
        self,
        request: dingtalkbizfinance__1__0_models.BatchAddInvoiceRequest,
        headers: dingtalkbizfinance__1__0_models.BatchAddInvoiceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.BatchAddInvoiceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.company_code):
            body['companyCode'] = request.company_code
        if not UtilClient.is_unset(request.general_invoice_volist):
            body['generalInvoiceVOList'] = request.general_invoice_volist
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='BatchAddInvoice',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/invoices/batch',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.BatchAddInvoiceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch_add_invoice(
        self,
        request: dingtalkbizfinance__1__0_models.BatchAddInvoiceRequest,
    ) -> dingtalkbizfinance__1__0_models.BatchAddInvoiceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.BatchAddInvoiceHeaders()
        return self.batch_add_invoice_with_options(request, headers, runtime)

    async def batch_add_invoice_async(
        self,
        request: dingtalkbizfinance__1__0_models.BatchAddInvoiceRequest,
    ) -> dingtalkbizfinance__1__0_models.BatchAddInvoiceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.BatchAddInvoiceHeaders()
        return await self.batch_add_invoice_with_options_async(request, headers, runtime)

    def batch_create_customer_with_options(
        self,
        request: dingtalkbizfinance__1__0_models.BatchCreateCustomerRequest,
        headers: dingtalkbizfinance__1__0_models.BatchCreateCustomerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.BatchCreateCustomerResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.create_customer_request_list):
            body['createCustomerRequestList'] = request.create_customer_request_list
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='BatchCreateCustomer',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/auxiliaries/batch',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.BatchCreateCustomerResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_create_customer_with_options_async(
        self,
        request: dingtalkbizfinance__1__0_models.BatchCreateCustomerRequest,
        headers: dingtalkbizfinance__1__0_models.BatchCreateCustomerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.BatchCreateCustomerResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.create_customer_request_list):
            body['createCustomerRequestList'] = request.create_customer_request_list
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='BatchCreateCustomer',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/auxiliaries/batch',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.BatchCreateCustomerResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch_create_customer(
        self,
        request: dingtalkbizfinance__1__0_models.BatchCreateCustomerRequest,
    ) -> dingtalkbizfinance__1__0_models.BatchCreateCustomerResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.BatchCreateCustomerHeaders()
        return self.batch_create_customer_with_options(request, headers, runtime)

    async def batch_create_customer_async(
        self,
        request: dingtalkbizfinance__1__0_models.BatchCreateCustomerRequest,
    ) -> dingtalkbizfinance__1__0_models.BatchCreateCustomerResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.BatchCreateCustomerHeaders()
        return await self.batch_create_customer_with_options_async(request, headers, runtime)

    def bind_company_accountant_book_with_options(
        self,
        request: dingtalkbizfinance__1__0_models.BindCompanyAccountantBookRequest,
        headers: dingtalkbizfinance__1__0_models.BindCompanyAccountantBookHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.BindCompanyAccountantBookResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.accountant_book_id):
            query['accountantBookId'] = request.accountant_book_id
        if not UtilClient.is_unset(request.company_code):
            query['companyCode'] = request.company_code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='BindCompanyAccountantBook',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/companies/accountantBooks/bind',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.BindCompanyAccountantBookResponse(),
            self.execute(params, req, runtime)
        )

    async def bind_company_accountant_book_with_options_async(
        self,
        request: dingtalkbizfinance__1__0_models.BindCompanyAccountantBookRequest,
        headers: dingtalkbizfinance__1__0_models.BindCompanyAccountantBookHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.BindCompanyAccountantBookResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.accountant_book_id):
            query['accountantBookId'] = request.accountant_book_id
        if not UtilClient.is_unset(request.company_code):
            query['companyCode'] = request.company_code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='BindCompanyAccountantBook',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/companies/accountantBooks/bind',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.BindCompanyAccountantBookResponse(),
            await self.execute_async(params, req, runtime)
        )

    def bind_company_accountant_book(
        self,
        request: dingtalkbizfinance__1__0_models.BindCompanyAccountantBookRequest,
    ) -> dingtalkbizfinance__1__0_models.BindCompanyAccountantBookResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.BindCompanyAccountantBookHeaders()
        return self.bind_company_accountant_book_with_options(request, headers, runtime)

    async def bind_company_accountant_book_async(
        self,
        request: dingtalkbizfinance__1__0_models.BindCompanyAccountantBookRequest,
    ) -> dingtalkbizfinance__1__0_models.BindCompanyAccountantBookResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.BindCompanyAccountantBookHeaders()
        return await self.bind_company_accountant_book_with_options_async(request, headers, runtime)

    def check_voucher_status_with_options(
        self,
        request: dingtalkbizfinance__1__0_models.CheckVoucherStatusRequest,
        headers: dingtalkbizfinance__1__0_models.CheckVoucherStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.CheckVoucherStatusResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.company_code):
            body['companyCode'] = request.company_code
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.finance_type):
            body['financeType'] = request.finance_type
        if not UtilClient.is_unset(request.invoice_code):
            body['invoiceCode'] = request.invoice_code
        if not UtilClient.is_unset(request.invoice_no):
            body['invoiceNo'] = request.invoice_no
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.tax_no):
            body['taxNo'] = request.tax_no
        if not UtilClient.is_unset(request.verify_status):
            body['verifyStatus'] = request.verify_status
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CheckVoucherStatus',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/invoices/checkVoucherStatus/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.CheckVoucherStatusResponse(),
            self.execute(params, req, runtime)
        )

    async def check_voucher_status_with_options_async(
        self,
        request: dingtalkbizfinance__1__0_models.CheckVoucherStatusRequest,
        headers: dingtalkbizfinance__1__0_models.CheckVoucherStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.CheckVoucherStatusResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.company_code):
            body['companyCode'] = request.company_code
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.finance_type):
            body['financeType'] = request.finance_type
        if not UtilClient.is_unset(request.invoice_code):
            body['invoiceCode'] = request.invoice_code
        if not UtilClient.is_unset(request.invoice_no):
            body['invoiceNo'] = request.invoice_no
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.tax_no):
            body['taxNo'] = request.tax_no
        if not UtilClient.is_unset(request.verify_status):
            body['verifyStatus'] = request.verify_status
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CheckVoucherStatus',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/invoices/checkVoucherStatus/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.CheckVoucherStatusResponse(),
            await self.execute_async(params, req, runtime)
        )

    def check_voucher_status(
        self,
        request: dingtalkbizfinance__1__0_models.CheckVoucherStatusRequest,
    ) -> dingtalkbizfinance__1__0_models.CheckVoucherStatusResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.CheckVoucherStatusHeaders()
        return self.check_voucher_status_with_options(request, headers, runtime)

    async def check_voucher_status_async(
        self,
        request: dingtalkbizfinance__1__0_models.CheckVoucherStatusRequest,
    ) -> dingtalkbizfinance__1__0_models.CheckVoucherStatusResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.CheckVoucherStatusHeaders()
        return await self.check_voucher_status_with_options_async(request, headers, runtime)

    def create_customer_with_options(
        self,
        request: dingtalkbizfinance__1__0_models.CreateCustomerRequest,
        headers: dingtalkbizfinance__1__0_models.CreateCustomerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.CreateCustomerResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.creator):
            body['creator'] = request.creator
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.drawer_email):
            body['drawerEmail'] = request.drawer_email
        if not UtilClient.is_unset(request.drawer_telephone):
            body['drawerTelephone'] = request.drawer_telephone
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.purchaser_account):
            body['purchaserAccount'] = request.purchaser_account
        if not UtilClient.is_unset(request.purchaser_address):
            body['purchaserAddress'] = request.purchaser_address
        if not UtilClient.is_unset(request.purchaser_bank_name):
            body['purchaserBankName'] = request.purchaser_bank_name
        if not UtilClient.is_unset(request.purchaser_name):
            body['purchaserName'] = request.purchaser_name
        if not UtilClient.is_unset(request.purchaser_tax_no):
            body['purchaserTaxNo'] = request.purchaser_tax_no
        if not UtilClient.is_unset(request.purchaser_tel):
            body['purchaserTel'] = request.purchaser_tel
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateCustomer',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/auxiliaries/customers',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.CreateCustomerResponse(),
            self.execute(params, req, runtime)
        )

    async def create_customer_with_options_async(
        self,
        request: dingtalkbizfinance__1__0_models.CreateCustomerRequest,
        headers: dingtalkbizfinance__1__0_models.CreateCustomerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.CreateCustomerResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.creator):
            body['creator'] = request.creator
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.drawer_email):
            body['drawerEmail'] = request.drawer_email
        if not UtilClient.is_unset(request.drawer_telephone):
            body['drawerTelephone'] = request.drawer_telephone
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.purchaser_account):
            body['purchaserAccount'] = request.purchaser_account
        if not UtilClient.is_unset(request.purchaser_address):
            body['purchaserAddress'] = request.purchaser_address
        if not UtilClient.is_unset(request.purchaser_bank_name):
            body['purchaserBankName'] = request.purchaser_bank_name
        if not UtilClient.is_unset(request.purchaser_name):
            body['purchaserName'] = request.purchaser_name
        if not UtilClient.is_unset(request.purchaser_tax_no):
            body['purchaserTaxNo'] = request.purchaser_tax_no
        if not UtilClient.is_unset(request.purchaser_tel):
            body['purchaserTel'] = request.purchaser_tel
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateCustomer',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/auxiliaries/customers',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.CreateCustomerResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_customer(
        self,
        request: dingtalkbizfinance__1__0_models.CreateCustomerRequest,
    ) -> dingtalkbizfinance__1__0_models.CreateCustomerResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.CreateCustomerHeaders()
        return self.create_customer_with_options(request, headers, runtime)

    async def create_customer_async(
        self,
        request: dingtalkbizfinance__1__0_models.CreateCustomerRequest,
    ) -> dingtalkbizfinance__1__0_models.CreateCustomerResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.CreateCustomerHeaders()
        return await self.create_customer_with_options_async(request, headers, runtime)

    def create_receipt_with_options(
        self,
        request: dingtalkbizfinance__1__0_models.CreateReceiptRequest,
        headers: dingtalkbizfinance__1__0_models.CreateReceiptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.CreateReceiptResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.receipts):
            body['receipts'] = request.receipts
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateReceipt',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/receipts',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.CreateReceiptResponse(),
            self.execute(params, req, runtime)
        )

    async def create_receipt_with_options_async(
        self,
        request: dingtalkbizfinance__1__0_models.CreateReceiptRequest,
        headers: dingtalkbizfinance__1__0_models.CreateReceiptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.CreateReceiptResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.receipts):
            body['receipts'] = request.receipts
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateReceipt',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/receipts',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.CreateReceiptResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_receipt(
        self,
        request: dingtalkbizfinance__1__0_models.CreateReceiptRequest,
    ) -> dingtalkbizfinance__1__0_models.CreateReceiptResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.CreateReceiptHeaders()
        return self.create_receipt_with_options(request, headers, runtime)

    async def create_receipt_async(
        self,
        request: dingtalkbizfinance__1__0_models.CreateReceiptRequest,
    ) -> dingtalkbizfinance__1__0_models.CreateReceiptResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.CreateReceiptHeaders()
        return await self.create_receipt_with_options_async(request, headers, runtime)

    def delete_receipt_with_options(
        self,
        request: dingtalkbizfinance__1__0_models.DeleteReceiptRequest,
        headers: dingtalkbizfinance__1__0_models.DeleteReceiptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.DeleteReceiptResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.receipts):
            body['receipts'] = request.receipts
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='DeleteReceipt',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/receipts/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.DeleteReceiptResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_receipt_with_options_async(
        self,
        request: dingtalkbizfinance__1__0_models.DeleteReceiptRequest,
        headers: dingtalkbizfinance__1__0_models.DeleteReceiptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.DeleteReceiptResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.receipts):
            body['receipts'] = request.receipts
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='DeleteReceipt',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/receipts/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.DeleteReceiptResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_receipt(
        self,
        request: dingtalkbizfinance__1__0_models.DeleteReceiptRequest,
    ) -> dingtalkbizfinance__1__0_models.DeleteReceiptResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.DeleteReceiptHeaders()
        return self.delete_receipt_with_options(request, headers, runtime)

    async def delete_receipt_async(
        self,
        request: dingtalkbizfinance__1__0_models.DeleteReceiptRequest,
    ) -> dingtalkbizfinance__1__0_models.DeleteReceiptResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.DeleteReceiptHeaders()
        return await self.delete_receipt_with_options_async(request, headers, runtime)

    def get_bookkeeping_user_list_with_options(
        self,
        headers: dingtalkbizfinance__1__0_models.GetBookkeepingUserListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.GetBookkeepingUserListResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetBookkeepingUserList',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/bookkeeping/users',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.GetBookkeepingUserListResponse(),
            self.execute(params, req, runtime)
        )

    async def get_bookkeeping_user_list_with_options_async(
        self,
        headers: dingtalkbizfinance__1__0_models.GetBookkeepingUserListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.GetBookkeepingUserListResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetBookkeepingUserList',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/bookkeeping/users',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.GetBookkeepingUserListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_bookkeeping_user_list(self) -> dingtalkbizfinance__1__0_models.GetBookkeepingUserListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.GetBookkeepingUserListHeaders()
        return self.get_bookkeeping_user_list_with_options(headers, runtime)

    async def get_bookkeeping_user_list_async(self) -> dingtalkbizfinance__1__0_models.GetBookkeepingUserListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.GetBookkeepingUserListHeaders()
        return await self.get_bookkeeping_user_list_with_options_async(headers, runtime)

    def get_category_with_options(
        self,
        request: dingtalkbizfinance__1__0_models.GetCategoryRequest,
        headers: dingtalkbizfinance__1__0_models.GetCategoryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.GetCategoryResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.code):
            query['code'] = request.code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetCategory',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/categories/get',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.GetCategoryResponse(),
            self.execute(params, req, runtime)
        )

    async def get_category_with_options_async(
        self,
        request: dingtalkbizfinance__1__0_models.GetCategoryRequest,
        headers: dingtalkbizfinance__1__0_models.GetCategoryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.GetCategoryResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.code):
            query['code'] = request.code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetCategory',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/categories/get',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.GetCategoryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_category(
        self,
        request: dingtalkbizfinance__1__0_models.GetCategoryRequest,
    ) -> dingtalkbizfinance__1__0_models.GetCategoryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.GetCategoryHeaders()
        return self.get_category_with_options(request, headers, runtime)

    async def get_category_async(
        self,
        request: dingtalkbizfinance__1__0_models.GetCategoryRequest,
    ) -> dingtalkbizfinance__1__0_models.GetCategoryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.GetCategoryHeaders()
        return await self.get_category_with_options_async(request, headers, runtime)

    def get_customer_with_options(
        self,
        request: dingtalkbizfinance__1__0_models.GetCustomerRequest,
        headers: dingtalkbizfinance__1__0_models.GetCustomerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.GetCustomerResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.code):
            query['code'] = request.code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetCustomer',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/customers/details',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.GetCustomerResponse(),
            self.execute(params, req, runtime)
        )

    async def get_customer_with_options_async(
        self,
        request: dingtalkbizfinance__1__0_models.GetCustomerRequest,
        headers: dingtalkbizfinance__1__0_models.GetCustomerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.GetCustomerResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.code):
            query['code'] = request.code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetCustomer',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/customers/details',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.GetCustomerResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_customer(
        self,
        request: dingtalkbizfinance__1__0_models.GetCustomerRequest,
    ) -> dingtalkbizfinance__1__0_models.GetCustomerResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.GetCustomerHeaders()
        return self.get_customer_with_options(request, headers, runtime)

    async def get_customer_async(
        self,
        request: dingtalkbizfinance__1__0_models.GetCustomerRequest,
    ) -> dingtalkbizfinance__1__0_models.GetCustomerResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.GetCustomerHeaders()
        return await self.get_customer_with_options_async(request, headers, runtime)

    def get_finance_account_with_options(
        self,
        request: dingtalkbizfinance__1__0_models.GetFinanceAccountRequest,
        headers: dingtalkbizfinance__1__0_models.GetFinanceAccountHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.GetFinanceAccountResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.account_code):
            query['accountCode'] = request.account_code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetFinanceAccount',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/financeAccounts/get',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.GetFinanceAccountResponse(),
            self.execute(params, req, runtime)
        )

    async def get_finance_account_with_options_async(
        self,
        request: dingtalkbizfinance__1__0_models.GetFinanceAccountRequest,
        headers: dingtalkbizfinance__1__0_models.GetFinanceAccountHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.GetFinanceAccountResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.account_code):
            query['accountCode'] = request.account_code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetFinanceAccount',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/financeAccounts/get',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.GetFinanceAccountResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_finance_account(
        self,
        request: dingtalkbizfinance__1__0_models.GetFinanceAccountRequest,
    ) -> dingtalkbizfinance__1__0_models.GetFinanceAccountResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.GetFinanceAccountHeaders()
        return self.get_finance_account_with_options(request, headers, runtime)

    async def get_finance_account_async(
        self,
        request: dingtalkbizfinance__1__0_models.GetFinanceAccountRequest,
    ) -> dingtalkbizfinance__1__0_models.GetFinanceAccountResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.GetFinanceAccountHeaders()
        return await self.get_finance_account_with_options_async(request, headers, runtime)

    def get_invoice_by_page_with_options(
        self,
        tmp_req: dingtalkbizfinance__1__0_models.GetInvoiceByPageRequest,
        headers: dingtalkbizfinance__1__0_models.GetInvoiceByPageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.GetInvoiceByPageResponse:
        UtilClient.validate_model(tmp_req)
        request = dingtalkbizfinance__1__0_models.GetInvoiceByPageShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.request):
            request.request_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.request, 'request', 'json')
        query = {}
        if not UtilClient.is_unset(request.request_shrink):
            query['request'] = request.request_shrink
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetInvoiceByPage',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/invoices',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.GetInvoiceByPageResponse(),
            self.execute(params, req, runtime)
        )

    async def get_invoice_by_page_with_options_async(
        self,
        tmp_req: dingtalkbizfinance__1__0_models.GetInvoiceByPageRequest,
        headers: dingtalkbizfinance__1__0_models.GetInvoiceByPageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.GetInvoiceByPageResponse:
        UtilClient.validate_model(tmp_req)
        request = dingtalkbizfinance__1__0_models.GetInvoiceByPageShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.request):
            request.request_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.request, 'request', 'json')
        query = {}
        if not UtilClient.is_unset(request.request_shrink):
            query['request'] = request.request_shrink
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetInvoiceByPage',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/invoices',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.GetInvoiceByPageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_invoice_by_page(
        self,
        request: dingtalkbizfinance__1__0_models.GetInvoiceByPageRequest,
    ) -> dingtalkbizfinance__1__0_models.GetInvoiceByPageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.GetInvoiceByPageHeaders()
        return self.get_invoice_by_page_with_options(request, headers, runtime)

    async def get_invoice_by_page_async(
        self,
        request: dingtalkbizfinance__1__0_models.GetInvoiceByPageRequest,
    ) -> dingtalkbizfinance__1__0_models.GetInvoiceByPageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.GetInvoiceByPageHeaders()
        return await self.get_invoice_by_page_with_options_async(request, headers, runtime)

    def get_is_new_version_with_options(
        self,
        headers: dingtalkbizfinance__1__0_models.GetIsNewVersionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.GetIsNewVersionResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetIsNewVersion',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/accounts/uses',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.GetIsNewVersionResponse(),
            self.execute(params, req, runtime)
        )

    async def get_is_new_version_with_options_async(
        self,
        headers: dingtalkbizfinance__1__0_models.GetIsNewVersionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.GetIsNewVersionResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetIsNewVersion',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/accounts/uses',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.GetIsNewVersionResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_is_new_version(self) -> dingtalkbizfinance__1__0_models.GetIsNewVersionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.GetIsNewVersionHeaders()
        return self.get_is_new_version_with_options(headers, runtime)

    async def get_is_new_version_async(self) -> dingtalkbizfinance__1__0_models.GetIsNewVersionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.GetIsNewVersionHeaders()
        return await self.get_is_new_version_with_options_async(headers, runtime)

    def get_multi_company_info_by_code_with_options(
        self,
        company_code: str,
        headers: dingtalkbizfinance__1__0_models.GetMultiCompanyInfoByCodeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.GetMultiCompanyInfoByCodeResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetMultiCompanyInfoByCode',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/multiCompanies/{company_code}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.GetMultiCompanyInfoByCodeResponse(),
            self.execute(params, req, runtime)
        )

    async def get_multi_company_info_by_code_with_options_async(
        self,
        company_code: str,
        headers: dingtalkbizfinance__1__0_models.GetMultiCompanyInfoByCodeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.GetMultiCompanyInfoByCodeResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetMultiCompanyInfoByCode',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/multiCompanies/{company_code}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.GetMultiCompanyInfoByCodeResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_multi_company_info_by_code(
        self,
        company_code: str,
    ) -> dingtalkbizfinance__1__0_models.GetMultiCompanyInfoByCodeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.GetMultiCompanyInfoByCodeHeaders()
        return self.get_multi_company_info_by_code_with_options(company_code, headers, runtime)

    async def get_multi_company_info_by_code_async(
        self,
        company_code: str,
    ) -> dingtalkbizfinance__1__0_models.GetMultiCompanyInfoByCodeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.GetMultiCompanyInfoByCodeHeaders()
        return await self.get_multi_company_info_by_code_with_options_async(company_code, headers, runtime)

    def get_product_with_options(
        self,
        request: dingtalkbizfinance__1__0_models.GetProductRequest,
        headers: dingtalkbizfinance__1__0_models.GetProductHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.GetProductResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.code):
            query['code'] = request.code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetProduct',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/products',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.GetProductResponse(),
            self.execute(params, req, runtime)
        )

    async def get_product_with_options_async(
        self,
        request: dingtalkbizfinance__1__0_models.GetProductRequest,
        headers: dingtalkbizfinance__1__0_models.GetProductHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.GetProductResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.code):
            query['code'] = request.code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetProduct',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/products',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.GetProductResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_product(
        self,
        request: dingtalkbizfinance__1__0_models.GetProductRequest,
    ) -> dingtalkbizfinance__1__0_models.GetProductResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.GetProductHeaders()
        return self.get_product_with_options(request, headers, runtime)

    async def get_product_async(
        self,
        request: dingtalkbizfinance__1__0_models.GetProductRequest,
    ) -> dingtalkbizfinance__1__0_models.GetProductResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.GetProductHeaders()
        return await self.get_product_with_options_async(request, headers, runtime)

    def get_project_with_options(
        self,
        request: dingtalkbizfinance__1__0_models.GetProjectRequest,
        headers: dingtalkbizfinance__1__0_models.GetProjectHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.GetProjectResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.code):
            query['code'] = request.code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetProject',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/projects/get',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.GetProjectResponse(),
            self.execute(params, req, runtime)
        )

    async def get_project_with_options_async(
        self,
        request: dingtalkbizfinance__1__0_models.GetProjectRequest,
        headers: dingtalkbizfinance__1__0_models.GetProjectHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.GetProjectResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.code):
            query['code'] = request.code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetProject',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/projects/get',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.GetProjectResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_project(
        self,
        request: dingtalkbizfinance__1__0_models.GetProjectRequest,
    ) -> dingtalkbizfinance__1__0_models.GetProjectResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.GetProjectHeaders()
        return self.get_project_with_options(request, headers, runtime)

    async def get_project_async(
        self,
        request: dingtalkbizfinance__1__0_models.GetProjectRequest,
    ) -> dingtalkbizfinance__1__0_models.GetProjectResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.GetProjectHeaders()
        return await self.get_project_with_options_async(request, headers, runtime)

    def get_receipt_with_options(
        self,
        request: dingtalkbizfinance__1__0_models.GetReceiptRequest,
        headers: dingtalkbizfinance__1__0_models.GetReceiptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.GetReceiptResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.code):
            query['code'] = request.code
        if not UtilClient.is_unset(request.model_id):
            query['modelId'] = request.model_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetReceipt',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/receipts/details',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.GetReceiptResponse(),
            self.execute(params, req, runtime)
        )

    async def get_receipt_with_options_async(
        self,
        request: dingtalkbizfinance__1__0_models.GetReceiptRequest,
        headers: dingtalkbizfinance__1__0_models.GetReceiptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.GetReceiptResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.code):
            query['code'] = request.code
        if not UtilClient.is_unset(request.model_id):
            query['modelId'] = request.model_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetReceipt',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/receipts/details',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.GetReceiptResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_receipt(
        self,
        request: dingtalkbizfinance__1__0_models.GetReceiptRequest,
    ) -> dingtalkbizfinance__1__0_models.GetReceiptResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.GetReceiptHeaders()
        return self.get_receipt_with_options(request, headers, runtime)

    async def get_receipt_async(
        self,
        request: dingtalkbizfinance__1__0_models.GetReceiptRequest,
    ) -> dingtalkbizfinance__1__0_models.GetReceiptResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.GetReceiptHeaders()
        return await self.get_receipt_with_options_async(request, headers, runtime)

    def get_supplier_with_options(
        self,
        request: dingtalkbizfinance__1__0_models.GetSupplierRequest,
        headers: dingtalkbizfinance__1__0_models.GetSupplierHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.GetSupplierResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.code):
            query['code'] = request.code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetSupplier',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/suppliers/details',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.GetSupplierResponse(),
            self.execute(params, req, runtime)
        )

    async def get_supplier_with_options_async(
        self,
        request: dingtalkbizfinance__1__0_models.GetSupplierRequest,
        headers: dingtalkbizfinance__1__0_models.GetSupplierHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.GetSupplierResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.code):
            query['code'] = request.code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetSupplier',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/suppliers/details',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.GetSupplierResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_supplier(
        self,
        request: dingtalkbizfinance__1__0_models.GetSupplierRequest,
    ) -> dingtalkbizfinance__1__0_models.GetSupplierResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.GetSupplierHeaders()
        return self.get_supplier_with_options(request, headers, runtime)

    async def get_supplier_async(
        self,
        request: dingtalkbizfinance__1__0_models.GetSupplierRequest,
    ) -> dingtalkbizfinance__1__0_models.GetSupplierResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.GetSupplierHeaders()
        return await self.get_supplier_with_options_async(request, headers, runtime)

    def get_yong_you_open_api_token_with_options(
        self,
        request: dingtalkbizfinance__1__0_models.GetYongYouOpenApiTokenRequest,
        headers: dingtalkbizfinance__1__0_models.GetYongYouOpenApiTokenHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.GetYongYouOpenApiTokenResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetYongYouOpenApiToken',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/yongyou/token',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.GetYongYouOpenApiTokenResponse(),
            self.execute(params, req, runtime)
        )

    async def get_yong_you_open_api_token_with_options_async(
        self,
        request: dingtalkbizfinance__1__0_models.GetYongYouOpenApiTokenRequest,
        headers: dingtalkbizfinance__1__0_models.GetYongYouOpenApiTokenHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.GetYongYouOpenApiTokenResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetYongYouOpenApiToken',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/yongyou/token',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.GetYongYouOpenApiTokenResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_yong_you_open_api_token(
        self,
        request: dingtalkbizfinance__1__0_models.GetYongYouOpenApiTokenRequest,
    ) -> dingtalkbizfinance__1__0_models.GetYongYouOpenApiTokenResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.GetYongYouOpenApiTokenHeaders()
        return self.get_yong_you_open_api_token_with_options(request, headers, runtime)

    async def get_yong_you_open_api_token_async(
        self,
        request: dingtalkbizfinance__1__0_models.GetYongYouOpenApiTokenRequest,
    ) -> dingtalkbizfinance__1__0_models.GetYongYouOpenApiTokenResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.GetYongYouOpenApiTokenHeaders()
        return await self.get_yong_you_open_api_token_with_options_async(request, headers, runtime)

    def get_yong_you_org_relation_with_options(
        self,
        headers: dingtalkbizfinance__1__0_models.GetYongYouOrgRelationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.GetYongYouOrgRelationResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetYongYouOrgRelation',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/yongyou/relations',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.GetYongYouOrgRelationResponse(),
            self.execute(params, req, runtime)
        )

    async def get_yong_you_org_relation_with_options_async(
        self,
        headers: dingtalkbizfinance__1__0_models.GetYongYouOrgRelationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.GetYongYouOrgRelationResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetYongYouOrgRelation',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/yongyou/relations',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.GetYongYouOrgRelationResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_yong_you_org_relation(self) -> dingtalkbizfinance__1__0_models.GetYongYouOrgRelationResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.GetYongYouOrgRelationHeaders()
        return self.get_yong_you_org_relation_with_options(headers, runtime)

    async def get_yong_you_org_relation_async(self) -> dingtalkbizfinance__1__0_models.GetYongYouOrgRelationResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.GetYongYouOrgRelationHeaders()
        return await self.get_yong_you_org_relation_with_options_async(headers, runtime)

    def profession_benefit_consume_with_options(
        self,
        request: dingtalkbizfinance__1__0_models.ProfessionBenefitConsumeRequest,
        headers: dingtalkbizfinance__1__0_models.ProfessionBenefitConsumeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.ProfessionBenefitConsumeResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.benefit_code):
            body['benefitCode'] = request.benefit_code
        if not UtilClient.is_unset(request.biz_request_id):
            body['bizRequestId'] = request.biz_request_id
        if not UtilClient.is_unset(request.quota):
            body['quota'] = request.quota
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='ProfessionBenefitConsume',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/professions/benefits/consume',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.ProfessionBenefitConsumeResponse(),
            self.execute(params, req, runtime)
        )

    async def profession_benefit_consume_with_options_async(
        self,
        request: dingtalkbizfinance__1__0_models.ProfessionBenefitConsumeRequest,
        headers: dingtalkbizfinance__1__0_models.ProfessionBenefitConsumeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.ProfessionBenefitConsumeResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.benefit_code):
            body['benefitCode'] = request.benefit_code
        if not UtilClient.is_unset(request.biz_request_id):
            body['bizRequestId'] = request.biz_request_id
        if not UtilClient.is_unset(request.quota):
            body['quota'] = request.quota
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='ProfessionBenefitConsume',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/professions/benefits/consume',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.ProfessionBenefitConsumeResponse(),
            await self.execute_async(params, req, runtime)
        )

    def profession_benefit_consume(
        self,
        request: dingtalkbizfinance__1__0_models.ProfessionBenefitConsumeRequest,
    ) -> dingtalkbizfinance__1__0_models.ProfessionBenefitConsumeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.ProfessionBenefitConsumeHeaders()
        return self.profession_benefit_consume_with_options(request, headers, runtime)

    async def profession_benefit_consume_async(
        self,
        request: dingtalkbizfinance__1__0_models.ProfessionBenefitConsumeRequest,
    ) -> dingtalkbizfinance__1__0_models.ProfessionBenefitConsumeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.ProfessionBenefitConsumeHeaders()
        return await self.profession_benefit_consume_with_options_async(request, headers, runtime)

    def query_category_by_page_with_options(
        self,
        request: dingtalkbizfinance__1__0_models.QueryCategoryByPageRequest,
        headers: dingtalkbizfinance__1__0_models.QueryCategoryByPageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.QueryCategoryByPageResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.type):
            query['type'] = request.type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryCategoryByPage',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/categories/list',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryCategoryByPageResponse(),
            self.execute(params, req, runtime)
        )

    async def query_category_by_page_with_options_async(
        self,
        request: dingtalkbizfinance__1__0_models.QueryCategoryByPageRequest,
        headers: dingtalkbizfinance__1__0_models.QueryCategoryByPageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.QueryCategoryByPageResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.type):
            query['type'] = request.type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryCategoryByPage',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/categories/list',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryCategoryByPageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_category_by_page(
        self,
        request: dingtalkbizfinance__1__0_models.QueryCategoryByPageRequest,
    ) -> dingtalkbizfinance__1__0_models.QueryCategoryByPageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.QueryCategoryByPageHeaders()
        return self.query_category_by_page_with_options(request, headers, runtime)

    async def query_category_by_page_async(
        self,
        request: dingtalkbizfinance__1__0_models.QueryCategoryByPageRequest,
    ) -> dingtalkbizfinance__1__0_models.QueryCategoryByPageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.QueryCategoryByPageHeaders()
        return await self.query_category_by_page_with_options_async(request, headers, runtime)

    def query_company_invoice_relation_count_with_options(
        self,
        request: dingtalkbizfinance__1__0_models.QueryCompanyInvoiceRelationCountRequest,
        headers: dingtalkbizfinance__1__0_models.QueryCompanyInvoiceRelationCountHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.QueryCompanyInvoiceRelationCountResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.company_code):
            query['companyCode'] = request.company_code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryCompanyInvoiceRelationCount',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/invoices/companyRelationReceipts/counts',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryCompanyInvoiceRelationCountResponse(),
            self.execute(params, req, runtime)
        )

    async def query_company_invoice_relation_count_with_options_async(
        self,
        request: dingtalkbizfinance__1__0_models.QueryCompanyInvoiceRelationCountRequest,
        headers: dingtalkbizfinance__1__0_models.QueryCompanyInvoiceRelationCountHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.QueryCompanyInvoiceRelationCountResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.company_code):
            query['companyCode'] = request.company_code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryCompanyInvoiceRelationCount',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/invoices/companyRelationReceipts/counts',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryCompanyInvoiceRelationCountResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_company_invoice_relation_count(
        self,
        request: dingtalkbizfinance__1__0_models.QueryCompanyInvoiceRelationCountRequest,
    ) -> dingtalkbizfinance__1__0_models.QueryCompanyInvoiceRelationCountResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.QueryCompanyInvoiceRelationCountHeaders()
        return self.query_company_invoice_relation_count_with_options(request, headers, runtime)

    async def query_company_invoice_relation_count_async(
        self,
        request: dingtalkbizfinance__1__0_models.QueryCompanyInvoiceRelationCountRequest,
    ) -> dingtalkbizfinance__1__0_models.QueryCompanyInvoiceRelationCountResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.QueryCompanyInvoiceRelationCountHeaders()
        return await self.query_company_invoice_relation_count_with_options_async(request, headers, runtime)

    def query_customer_by_page_with_options(
        self,
        request: dingtalkbizfinance__1__0_models.QueryCustomerByPageRequest,
        headers: dingtalkbizfinance__1__0_models.QueryCustomerByPageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.QueryCustomerByPageResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryCustomerByPage',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/customers',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryCustomerByPageResponse(),
            self.execute(params, req, runtime)
        )

    async def query_customer_by_page_with_options_async(
        self,
        request: dingtalkbizfinance__1__0_models.QueryCustomerByPageRequest,
        headers: dingtalkbizfinance__1__0_models.QueryCustomerByPageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.QueryCustomerByPageResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryCustomerByPage',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/customers',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryCustomerByPageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_customer_by_page(
        self,
        request: dingtalkbizfinance__1__0_models.QueryCustomerByPageRequest,
    ) -> dingtalkbizfinance__1__0_models.QueryCustomerByPageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.QueryCustomerByPageHeaders()
        return self.query_customer_by_page_with_options(request, headers, runtime)

    async def query_customer_by_page_async(
        self,
        request: dingtalkbizfinance__1__0_models.QueryCustomerByPageRequest,
    ) -> dingtalkbizfinance__1__0_models.QueryCustomerByPageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.QueryCustomerByPageHeaders()
        return await self.query_customer_by_page_with_options_async(request, headers, runtime)

    def query_customer_info_with_options(
        self,
        request: dingtalkbizfinance__1__0_models.QueryCustomerInfoRequest,
        headers: dingtalkbizfinance__1__0_models.QueryCustomerInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.QueryCustomerInfoResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.keyword):
            query['keyword'] = request.keyword
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryCustomerInfo',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/auxiliaries/customers',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryCustomerInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def query_customer_info_with_options_async(
        self,
        request: dingtalkbizfinance__1__0_models.QueryCustomerInfoRequest,
        headers: dingtalkbizfinance__1__0_models.QueryCustomerInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.QueryCustomerInfoResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.keyword):
            query['keyword'] = request.keyword
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryCustomerInfo',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/auxiliaries/customers',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryCustomerInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_customer_info(
        self,
        request: dingtalkbizfinance__1__0_models.QueryCustomerInfoRequest,
    ) -> dingtalkbizfinance__1__0_models.QueryCustomerInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.QueryCustomerInfoHeaders()
        return self.query_customer_info_with_options(request, headers, runtime)

    async def query_customer_info_async(
        self,
        request: dingtalkbizfinance__1__0_models.QueryCustomerInfoRequest,
    ) -> dingtalkbizfinance__1__0_models.QueryCustomerInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.QueryCustomerInfoHeaders()
        return await self.query_customer_info_with_options_async(request, headers, runtime)

    def query_enterprise_account_by_page_with_options(
        self,
        request: dingtalkbizfinance__1__0_models.QueryEnterpriseAccountByPageRequest,
        headers: dingtalkbizfinance__1__0_models.QueryEnterpriseAccountByPageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.QueryEnterpriseAccountByPageResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryEnterpriseAccountByPage',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/financeAccounts/list',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryEnterpriseAccountByPageResponse(),
            self.execute(params, req, runtime)
        )

    async def query_enterprise_account_by_page_with_options_async(
        self,
        request: dingtalkbizfinance__1__0_models.QueryEnterpriseAccountByPageRequest,
        headers: dingtalkbizfinance__1__0_models.QueryEnterpriseAccountByPageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.QueryEnterpriseAccountByPageResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryEnterpriseAccountByPage',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/financeAccounts/list',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryEnterpriseAccountByPageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_enterprise_account_by_page(
        self,
        request: dingtalkbizfinance__1__0_models.QueryEnterpriseAccountByPageRequest,
    ) -> dingtalkbizfinance__1__0_models.QueryEnterpriseAccountByPageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.QueryEnterpriseAccountByPageHeaders()
        return self.query_enterprise_account_by_page_with_options(request, headers, runtime)

    async def query_enterprise_account_by_page_async(
        self,
        request: dingtalkbizfinance__1__0_models.QueryEnterpriseAccountByPageRequest,
    ) -> dingtalkbizfinance__1__0_models.QueryEnterpriseAccountByPageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.QueryEnterpriseAccountByPageHeaders()
        return await self.query_enterprise_account_by_page_with_options_async(request, headers, runtime)

    def query_finance_company_info_with_options(
        self,
        headers: dingtalkbizfinance__1__0_models.QueryFinanceCompanyInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.QueryFinanceCompanyInfoResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='QueryFinanceCompanyInfo',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/companies',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryFinanceCompanyInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def query_finance_company_info_with_options_async(
        self,
        headers: dingtalkbizfinance__1__0_models.QueryFinanceCompanyInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.QueryFinanceCompanyInfoResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='QueryFinanceCompanyInfo',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/companies',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryFinanceCompanyInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_finance_company_info(self) -> dingtalkbizfinance__1__0_models.QueryFinanceCompanyInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.QueryFinanceCompanyInfoHeaders()
        return self.query_finance_company_info_with_options(headers, runtime)

    async def query_finance_company_info_async(self) -> dingtalkbizfinance__1__0_models.QueryFinanceCompanyInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.QueryFinanceCompanyInfoHeaders()
        return await self.query_finance_company_info_with_options_async(headers, runtime)

    def query_invoice_relation_count_with_options(
        self,
        headers: dingtalkbizfinance__1__0_models.QueryInvoiceRelationCountHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.QueryInvoiceRelationCountResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='QueryInvoiceRelationCount',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/invoices/relationReceipts/counts',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryInvoiceRelationCountResponse(),
            self.execute(params, req, runtime)
        )

    async def query_invoice_relation_count_with_options_async(
        self,
        headers: dingtalkbizfinance__1__0_models.QueryInvoiceRelationCountHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.QueryInvoiceRelationCountResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='QueryInvoiceRelationCount',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/invoices/relationReceipts/counts',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryInvoiceRelationCountResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_invoice_relation_count(self) -> dingtalkbizfinance__1__0_models.QueryInvoiceRelationCountResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.QueryInvoiceRelationCountHeaders()
        return self.query_invoice_relation_count_with_options(headers, runtime)

    async def query_invoice_relation_count_async(self) -> dingtalkbizfinance__1__0_models.QueryInvoiceRelationCountResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.QueryInvoiceRelationCountHeaders()
        return await self.query_invoice_relation_count_with_options_async(headers, runtime)

    def query_multi_company_info_with_options(
        self,
        headers: dingtalkbizfinance__1__0_models.QueryMultiCompanyInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.QueryMultiCompanyInfoResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='QueryMultiCompanyInfo',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/multiCompanies',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryMultiCompanyInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def query_multi_company_info_with_options_async(
        self,
        headers: dingtalkbizfinance__1__0_models.QueryMultiCompanyInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.QueryMultiCompanyInfoResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='QueryMultiCompanyInfo',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/multiCompanies',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryMultiCompanyInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_multi_company_info(self) -> dingtalkbizfinance__1__0_models.QueryMultiCompanyInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.QueryMultiCompanyInfoHeaders()
        return self.query_multi_company_info_with_options(headers, runtime)

    async def query_multi_company_info_async(self) -> dingtalkbizfinance__1__0_models.QueryMultiCompanyInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.QueryMultiCompanyInfoHeaders()
        return await self.query_multi_company_info_with_options_async(headers, runtime)

    def query_permission_by_user_id_with_options(
        self,
        request: dingtalkbizfinance__1__0_models.QueryPermissionByUserIdRequest,
        headers: dingtalkbizfinance__1__0_models.QueryPermissionByUserIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.QueryPermissionByUserIdResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryPermissionByUserId',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/permissions',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryPermissionByUserIdResponse(),
            self.execute(params, req, runtime)
        )

    async def query_permission_by_user_id_with_options_async(
        self,
        request: dingtalkbizfinance__1__0_models.QueryPermissionByUserIdRequest,
        headers: dingtalkbizfinance__1__0_models.QueryPermissionByUserIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.QueryPermissionByUserIdResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryPermissionByUserId',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/permissions',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryPermissionByUserIdResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_permission_by_user_id(
        self,
        request: dingtalkbizfinance__1__0_models.QueryPermissionByUserIdRequest,
    ) -> dingtalkbizfinance__1__0_models.QueryPermissionByUserIdResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.QueryPermissionByUserIdHeaders()
        return self.query_permission_by_user_id_with_options(request, headers, runtime)

    async def query_permission_by_user_id_async(
        self,
        request: dingtalkbizfinance__1__0_models.QueryPermissionByUserIdRequest,
    ) -> dingtalkbizfinance__1__0_models.QueryPermissionByUserIdResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.QueryPermissionByUserIdHeaders()
        return await self.query_permission_by_user_id_with_options_async(request, headers, runtime)

    def query_permission_role_member_with_options(
        self,
        request: dingtalkbizfinance__1__0_models.QueryPermissionRoleMemberRequest,
        headers: dingtalkbizfinance__1__0_models.QueryPermissionRoleMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.QueryPermissionRoleMemberResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.role_code_list):
            body['roleCodeList'] = request.role_code_list
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='QueryPermissionRoleMember',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/roles/members/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryPermissionRoleMemberResponse(),
            self.execute(params, req, runtime)
        )

    async def query_permission_role_member_with_options_async(
        self,
        request: dingtalkbizfinance__1__0_models.QueryPermissionRoleMemberRequest,
        headers: dingtalkbizfinance__1__0_models.QueryPermissionRoleMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.QueryPermissionRoleMemberResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.role_code_list):
            body['roleCodeList'] = request.role_code_list
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='QueryPermissionRoleMember',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/roles/members/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryPermissionRoleMemberResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_permission_role_member(
        self,
        request: dingtalkbizfinance__1__0_models.QueryPermissionRoleMemberRequest,
    ) -> dingtalkbizfinance__1__0_models.QueryPermissionRoleMemberResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.QueryPermissionRoleMemberHeaders()
        return self.query_permission_role_member_with_options(request, headers, runtime)

    async def query_permission_role_member_async(
        self,
        request: dingtalkbizfinance__1__0_models.QueryPermissionRoleMemberRequest,
    ) -> dingtalkbizfinance__1__0_models.QueryPermissionRoleMemberResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.QueryPermissionRoleMemberHeaders()
        return await self.query_permission_role_member_with_options_async(request, headers, runtime)

    def query_product_by_page_with_options(
        self,
        request: dingtalkbizfinance__1__0_models.QueryProductByPageRequest,
        headers: dingtalkbizfinance__1__0_models.QueryProductByPageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.QueryProductByPageResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryProductByPage',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/products/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryProductByPageResponse(),
            self.execute(params, req, runtime)
        )

    async def query_product_by_page_with_options_async(
        self,
        request: dingtalkbizfinance__1__0_models.QueryProductByPageRequest,
        headers: dingtalkbizfinance__1__0_models.QueryProductByPageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.QueryProductByPageResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryProductByPage',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/products/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryProductByPageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_product_by_page(
        self,
        request: dingtalkbizfinance__1__0_models.QueryProductByPageRequest,
    ) -> dingtalkbizfinance__1__0_models.QueryProductByPageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.QueryProductByPageHeaders()
        return self.query_product_by_page_with_options(request, headers, runtime)

    async def query_product_by_page_async(
        self,
        request: dingtalkbizfinance__1__0_models.QueryProductByPageRequest,
    ) -> dingtalkbizfinance__1__0_models.QueryProductByPageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.QueryProductByPageHeaders()
        return await self.query_product_by_page_with_options_async(request, headers, runtime)

    def query_project_by_page_with_options(
        self,
        request: dingtalkbizfinance__1__0_models.QueryProjectByPageRequest,
        headers: dingtalkbizfinance__1__0_models.QueryProjectByPageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.QueryProjectByPageResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryProjectByPage',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/projects/list',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryProjectByPageResponse(),
            self.execute(params, req, runtime)
        )

    async def query_project_by_page_with_options_async(
        self,
        request: dingtalkbizfinance__1__0_models.QueryProjectByPageRequest,
        headers: dingtalkbizfinance__1__0_models.QueryProjectByPageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.QueryProjectByPageResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryProjectByPage',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/projects/list',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryProjectByPageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_project_by_page(
        self,
        request: dingtalkbizfinance__1__0_models.QueryProjectByPageRequest,
    ) -> dingtalkbizfinance__1__0_models.QueryProjectByPageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.QueryProjectByPageHeaders()
        return self.query_project_by_page_with_options(request, headers, runtime)

    async def query_project_by_page_async(
        self,
        request: dingtalkbizfinance__1__0_models.QueryProjectByPageRequest,
    ) -> dingtalkbizfinance__1__0_models.QueryProjectByPageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.QueryProjectByPageHeaders()
        return await self.query_project_by_page_with_options_async(request, headers, runtime)

    def query_receipt_detail_for_invoice_with_options(
        self,
        request: dingtalkbizfinance__1__0_models.QueryReceiptDetailForInvoiceRequest,
        headers: dingtalkbizfinance__1__0_models.QueryReceiptDetailForInvoiceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.QueryReceiptDetailForInvoiceResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.instance_id):
            query['instanceId'] = request.instance_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryReceiptDetailForInvoice',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/invoices/receipts/details',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryReceiptDetailForInvoiceResponse(),
            self.execute(params, req, runtime)
        )

    async def query_receipt_detail_for_invoice_with_options_async(
        self,
        request: dingtalkbizfinance__1__0_models.QueryReceiptDetailForInvoiceRequest,
        headers: dingtalkbizfinance__1__0_models.QueryReceiptDetailForInvoiceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.QueryReceiptDetailForInvoiceResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.instance_id):
            query['instanceId'] = request.instance_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryReceiptDetailForInvoice',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/invoices/receipts/details',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryReceiptDetailForInvoiceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_receipt_detail_for_invoice(
        self,
        request: dingtalkbizfinance__1__0_models.QueryReceiptDetailForInvoiceRequest,
    ) -> dingtalkbizfinance__1__0_models.QueryReceiptDetailForInvoiceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.QueryReceiptDetailForInvoiceHeaders()
        return self.query_receipt_detail_for_invoice_with_options(request, headers, runtime)

    async def query_receipt_detail_for_invoice_async(
        self,
        request: dingtalkbizfinance__1__0_models.QueryReceiptDetailForInvoiceRequest,
    ) -> dingtalkbizfinance__1__0_models.QueryReceiptDetailForInvoiceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.QueryReceiptDetailForInvoiceHeaders()
        return await self.query_receipt_detail_for_invoice_with_options_async(request, headers, runtime)

    def query_receipt_for_invoice_with_options(
        self,
        request: dingtalkbizfinance__1__0_models.QueryReceiptForInvoiceRequest,
        headers: dingtalkbizfinance__1__0_models.QueryReceiptForInvoiceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.QueryReceiptForInvoiceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.accountant_book_id):
            body['accountantBookId'] = request.accountant_book_id
        if not UtilClient.is_unset(request.apply_status_list):
            body['applyStatusList'] = request.apply_status_list
        if not UtilClient.is_unset(request.biz_status_list):
            body['bizStatusList'] = request.biz_status_list
        if not UtilClient.is_unset(request.company_code):
            body['companyCode'] = request.company_code
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.receipt_status_list):
            body['receiptStatusList'] = request.receipt_status_list
        if not UtilClient.is_unset(request.search_params):
            body['searchParams'] = request.search_params
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='QueryReceiptForInvoice',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/invoices/receipts/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryReceiptForInvoiceResponse(),
            self.execute(params, req, runtime)
        )

    async def query_receipt_for_invoice_with_options_async(
        self,
        request: dingtalkbizfinance__1__0_models.QueryReceiptForInvoiceRequest,
        headers: dingtalkbizfinance__1__0_models.QueryReceiptForInvoiceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.QueryReceiptForInvoiceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.accountant_book_id):
            body['accountantBookId'] = request.accountant_book_id
        if not UtilClient.is_unset(request.apply_status_list):
            body['applyStatusList'] = request.apply_status_list
        if not UtilClient.is_unset(request.biz_status_list):
            body['bizStatusList'] = request.biz_status_list
        if not UtilClient.is_unset(request.company_code):
            body['companyCode'] = request.company_code
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.receipt_status_list):
            body['receiptStatusList'] = request.receipt_status_list
        if not UtilClient.is_unset(request.search_params):
            body['searchParams'] = request.search_params
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='QueryReceiptForInvoice',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/invoices/receipts/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryReceiptForInvoiceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_receipt_for_invoice(
        self,
        request: dingtalkbizfinance__1__0_models.QueryReceiptForInvoiceRequest,
    ) -> dingtalkbizfinance__1__0_models.QueryReceiptForInvoiceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.QueryReceiptForInvoiceHeaders()
        return self.query_receipt_for_invoice_with_options(request, headers, runtime)

    async def query_receipt_for_invoice_async(
        self,
        request: dingtalkbizfinance__1__0_models.QueryReceiptForInvoiceRequest,
    ) -> dingtalkbizfinance__1__0_models.QueryReceiptForInvoiceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.QueryReceiptForInvoiceHeaders()
        return await self.query_receipt_for_invoice_with_options_async(request, headers, runtime)

    def query_receipts_base_info_with_options(
        self,
        request: dingtalkbizfinance__1__0_models.QueryReceiptsBaseInfoRequest,
        headers: dingtalkbizfinance__1__0_models.QueryReceiptsBaseInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.QueryReceiptsBaseInfoResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.accountant_book_id):
            query['accountantBookId'] = request.accountant_book_id
        if not UtilClient.is_unset(request.company_code):
            query['companyCode'] = request.company_code
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.start_time):
            query['startTime'] = request.start_time
        if not UtilClient.is_unset(request.time_filter_field):
            query['timeFilterField'] = request.time_filter_field
        if not UtilClient.is_unset(request.title):
            query['title'] = request.title
        if not UtilClient.is_unset(request.voucher_status):
            query['voucherStatus'] = request.voucher_status
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryReceiptsBaseInfo',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/receipts/dataInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryReceiptsBaseInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def query_receipts_base_info_with_options_async(
        self,
        request: dingtalkbizfinance__1__0_models.QueryReceiptsBaseInfoRequest,
        headers: dingtalkbizfinance__1__0_models.QueryReceiptsBaseInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.QueryReceiptsBaseInfoResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.accountant_book_id):
            query['accountantBookId'] = request.accountant_book_id
        if not UtilClient.is_unset(request.company_code):
            query['companyCode'] = request.company_code
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.start_time):
            query['startTime'] = request.start_time
        if not UtilClient.is_unset(request.time_filter_field):
            query['timeFilterField'] = request.time_filter_field
        if not UtilClient.is_unset(request.title):
            query['title'] = request.title
        if not UtilClient.is_unset(request.voucher_status):
            query['voucherStatus'] = request.voucher_status
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryReceiptsBaseInfo',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/receipts/dataInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryReceiptsBaseInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_receipts_base_info(
        self,
        request: dingtalkbizfinance__1__0_models.QueryReceiptsBaseInfoRequest,
    ) -> dingtalkbizfinance__1__0_models.QueryReceiptsBaseInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.QueryReceiptsBaseInfoHeaders()
        return self.query_receipts_base_info_with_options(request, headers, runtime)

    async def query_receipts_base_info_async(
        self,
        request: dingtalkbizfinance__1__0_models.QueryReceiptsBaseInfoRequest,
    ) -> dingtalkbizfinance__1__0_models.QueryReceiptsBaseInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.QueryReceiptsBaseInfoHeaders()
        return await self.query_receipts_base_info_with_options_async(request, headers, runtime)

    def query_receipts_by_page_with_options(
        self,
        request: dingtalkbizfinance__1__0_models.QueryReceiptsByPageRequest,
        headers: dingtalkbizfinance__1__0_models.QueryReceiptsByPageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.QueryReceiptsByPageResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
        if not UtilClient.is_unset(request.model_id):
            query['modelId'] = request.model_id
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.start_time):
            query['startTime'] = request.start_time
        if not UtilClient.is_unset(request.time_filter_field):
            query['timeFilterField'] = request.time_filter_field
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryReceiptsByPage',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/receipts',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryReceiptsByPageResponse(),
            self.execute(params, req, runtime)
        )

    async def query_receipts_by_page_with_options_async(
        self,
        request: dingtalkbizfinance__1__0_models.QueryReceiptsByPageRequest,
        headers: dingtalkbizfinance__1__0_models.QueryReceiptsByPageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.QueryReceiptsByPageResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
        if not UtilClient.is_unset(request.model_id):
            query['modelId'] = request.model_id
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.start_time):
            query['startTime'] = request.start_time
        if not UtilClient.is_unset(request.time_filter_field):
            query['timeFilterField'] = request.time_filter_field
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryReceiptsByPage',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/receipts',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryReceiptsByPageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_receipts_by_page(
        self,
        request: dingtalkbizfinance__1__0_models.QueryReceiptsByPageRequest,
    ) -> dingtalkbizfinance__1__0_models.QueryReceiptsByPageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.QueryReceiptsByPageHeaders()
        return self.query_receipts_by_page_with_options(request, headers, runtime)

    async def query_receipts_by_page_async(
        self,
        request: dingtalkbizfinance__1__0_models.QueryReceiptsByPageRequest,
    ) -> dingtalkbizfinance__1__0_models.QueryReceiptsByPageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.QueryReceiptsByPageHeaders()
        return await self.query_receipts_by_page_with_options_async(request, headers, runtime)

    def query_role_member_by_page_with_options(
        self,
        request: dingtalkbizfinance__1__0_models.QueryRoleMemberByPageRequest,
        headers: dingtalkbizfinance__1__0_models.QueryRoleMemberByPageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.QueryRoleMemberByPageResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.role_code):
            query['roleCode'] = request.role_code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryRoleMemberByPage',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/roles/members',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryRoleMemberByPageResponse(),
            self.execute(params, req, runtime)
        )

    async def query_role_member_by_page_with_options_async(
        self,
        request: dingtalkbizfinance__1__0_models.QueryRoleMemberByPageRequest,
        headers: dingtalkbizfinance__1__0_models.QueryRoleMemberByPageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.QueryRoleMemberByPageResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.role_code):
            query['roleCode'] = request.role_code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryRoleMemberByPage',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/roles/members',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryRoleMemberByPageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_role_member_by_page(
        self,
        request: dingtalkbizfinance__1__0_models.QueryRoleMemberByPageRequest,
    ) -> dingtalkbizfinance__1__0_models.QueryRoleMemberByPageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.QueryRoleMemberByPageHeaders()
        return self.query_role_member_by_page_with_options(request, headers, runtime)

    async def query_role_member_by_page_async(
        self,
        request: dingtalkbizfinance__1__0_models.QueryRoleMemberByPageRequest,
    ) -> dingtalkbizfinance__1__0_models.QueryRoleMemberByPageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.QueryRoleMemberByPageHeaders()
        return await self.query_role_member_by_page_with_options_async(request, headers, runtime)

    def query_supplier_by_page_with_options(
        self,
        request: dingtalkbizfinance__1__0_models.QuerySupplierByPageRequest,
        headers: dingtalkbizfinance__1__0_models.QuerySupplierByPageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.QuerySupplierByPageResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QuerySupplierByPage',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/suppliers',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QuerySupplierByPageResponse(),
            self.execute(params, req, runtime)
        )

    async def query_supplier_by_page_with_options_async(
        self,
        request: dingtalkbizfinance__1__0_models.QuerySupplierByPageRequest,
        headers: dingtalkbizfinance__1__0_models.QuerySupplierByPageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.QuerySupplierByPageResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QuerySupplierByPage',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/suppliers',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QuerySupplierByPageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_supplier_by_page(
        self,
        request: dingtalkbizfinance__1__0_models.QuerySupplierByPageRequest,
    ) -> dingtalkbizfinance__1__0_models.QuerySupplierByPageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.QuerySupplierByPageHeaders()
        return self.query_supplier_by_page_with_options(request, headers, runtime)

    async def query_supplier_by_page_async(
        self,
        request: dingtalkbizfinance__1__0_models.QuerySupplierByPageRequest,
    ) -> dingtalkbizfinance__1__0_models.QuerySupplierByPageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.QuerySupplierByPageHeaders()
        return await self.query_supplier_by_page_with_options_async(request, headers, runtime)

    def query_user_role_list_with_options(
        self,
        request: dingtalkbizfinance__1__0_models.QueryUserRoleListRequest,
        headers: dingtalkbizfinance__1__0_models.QueryUserRoleListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.QueryUserRoleListResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryUserRoleList',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/users/roles',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryUserRoleListResponse(),
            self.execute(params, req, runtime)
        )

    async def query_user_role_list_with_options_async(
        self,
        request: dingtalkbizfinance__1__0_models.QueryUserRoleListRequest,
        headers: dingtalkbizfinance__1__0_models.QueryUserRoleListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.QueryUserRoleListResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryUserRoleList',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/users/roles',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryUserRoleListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_user_role_list(
        self,
        request: dingtalkbizfinance__1__0_models.QueryUserRoleListRequest,
    ) -> dingtalkbizfinance__1__0_models.QueryUserRoleListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.QueryUserRoleListHeaders()
        return self.query_user_role_list_with_options(request, headers, runtime)

    async def query_user_role_list_async(
        self,
        request: dingtalkbizfinance__1__0_models.QueryUserRoleListRequest,
    ) -> dingtalkbizfinance__1__0_models.QueryUserRoleListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.QueryUserRoleListHeaders()
        return await self.query_user_role_list_with_options_async(request, headers, runtime)

    def unbind_apply_receipt_and_invoice_related_with_options(
        self,
        request: dingtalkbizfinance__1__0_models.UnbindApplyReceiptAndInvoiceRelatedRequest,
        headers: dingtalkbizfinance__1__0_models.UnbindApplyReceiptAndInvoiceRelatedHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.UnbindApplyReceiptAndInvoiceRelatedResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.instance_id):
            body['instanceId'] = request.instance_id
        if not UtilClient.is_unset(request.invoice_key_volist):
            body['invoiceKeyVOList'] = request.invoice_key_volist
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UnbindApplyReceiptAndInvoiceRelated',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/invoices/unbind',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.UnbindApplyReceiptAndInvoiceRelatedResponse(),
            self.execute(params, req, runtime)
        )

    async def unbind_apply_receipt_and_invoice_related_with_options_async(
        self,
        request: dingtalkbizfinance__1__0_models.UnbindApplyReceiptAndInvoiceRelatedRequest,
        headers: dingtalkbizfinance__1__0_models.UnbindApplyReceiptAndInvoiceRelatedHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.UnbindApplyReceiptAndInvoiceRelatedResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.instance_id):
            body['instanceId'] = request.instance_id
        if not UtilClient.is_unset(request.invoice_key_volist):
            body['invoiceKeyVOList'] = request.invoice_key_volist
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UnbindApplyReceiptAndInvoiceRelated',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/invoices/unbind',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.UnbindApplyReceiptAndInvoiceRelatedResponse(),
            await self.execute_async(params, req, runtime)
        )

    def unbind_apply_receipt_and_invoice_related(
        self,
        request: dingtalkbizfinance__1__0_models.UnbindApplyReceiptAndInvoiceRelatedRequest,
    ) -> dingtalkbizfinance__1__0_models.UnbindApplyReceiptAndInvoiceRelatedResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.UnbindApplyReceiptAndInvoiceRelatedHeaders()
        return self.unbind_apply_receipt_and_invoice_related_with_options(request, headers, runtime)

    async def unbind_apply_receipt_and_invoice_related_async(
        self,
        request: dingtalkbizfinance__1__0_models.UnbindApplyReceiptAndInvoiceRelatedRequest,
    ) -> dingtalkbizfinance__1__0_models.UnbindApplyReceiptAndInvoiceRelatedResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.UnbindApplyReceiptAndInvoiceRelatedHeaders()
        return await self.unbind_apply_receipt_and_invoice_related_with_options_async(request, headers, runtime)

    def update_apply_receipt_and_invoice_related_with_options(
        self,
        request: dingtalkbizfinance__1__0_models.UpdateApplyReceiptAndInvoiceRelatedRequest,
        headers: dingtalkbizfinance__1__0_models.UpdateApplyReceiptAndInvoiceRelatedHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.UpdateApplyReceiptAndInvoiceRelatedResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.general_invoice_volist):
            body['generalInvoiceVOList'] = request.general_invoice_volist
        if not UtilClient.is_unset(request.instance_id):
            body['instanceId'] = request.instance_id
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateApplyReceiptAndInvoiceRelated',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/invoices/applyReceipts/relate',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.UpdateApplyReceiptAndInvoiceRelatedResponse(),
            self.execute(params, req, runtime)
        )

    async def update_apply_receipt_and_invoice_related_with_options_async(
        self,
        request: dingtalkbizfinance__1__0_models.UpdateApplyReceiptAndInvoiceRelatedRequest,
        headers: dingtalkbizfinance__1__0_models.UpdateApplyReceiptAndInvoiceRelatedHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.UpdateApplyReceiptAndInvoiceRelatedResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.general_invoice_volist):
            body['generalInvoiceVOList'] = request.general_invoice_volist
        if not UtilClient.is_unset(request.instance_id):
            body['instanceId'] = request.instance_id
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateApplyReceiptAndInvoiceRelated',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/invoices/applyReceipts/relate',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.UpdateApplyReceiptAndInvoiceRelatedResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_apply_receipt_and_invoice_related(
        self,
        request: dingtalkbizfinance__1__0_models.UpdateApplyReceiptAndInvoiceRelatedRequest,
    ) -> dingtalkbizfinance__1__0_models.UpdateApplyReceiptAndInvoiceRelatedResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.UpdateApplyReceiptAndInvoiceRelatedHeaders()
        return self.update_apply_receipt_and_invoice_related_with_options(request, headers, runtime)

    async def update_apply_receipt_and_invoice_related_async(
        self,
        request: dingtalkbizfinance__1__0_models.UpdateApplyReceiptAndInvoiceRelatedRequest,
    ) -> dingtalkbizfinance__1__0_models.UpdateApplyReceiptAndInvoiceRelatedResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.UpdateApplyReceiptAndInvoiceRelatedHeaders()
        return await self.update_apply_receipt_and_invoice_related_with_options_async(request, headers, runtime)

    def update_digital_invoice_org_info_with_options(
        self,
        request: dingtalkbizfinance__1__0_models.UpdateDigitalInvoiceOrgInfoRequest,
        headers: dingtalkbizfinance__1__0_models.UpdateDigitalInvoiceOrgInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.UpdateDigitalInvoiceOrgInfoResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.digital_invoice_type):
            body['digitalInvoiceType'] = request.digital_invoice_type
        if not UtilClient.is_unset(request.is_digital_org):
            body['isDigitalOrg'] = request.is_digital_org
        if not UtilClient.is_unset(request.location):
            body['location'] = request.location
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateDigitalInvoiceOrgInfo',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/invoices/organizationInfos',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.UpdateDigitalInvoiceOrgInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def update_digital_invoice_org_info_with_options_async(
        self,
        request: dingtalkbizfinance__1__0_models.UpdateDigitalInvoiceOrgInfoRequest,
        headers: dingtalkbizfinance__1__0_models.UpdateDigitalInvoiceOrgInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.UpdateDigitalInvoiceOrgInfoResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.digital_invoice_type):
            body['digitalInvoiceType'] = request.digital_invoice_type
        if not UtilClient.is_unset(request.is_digital_org):
            body['isDigitalOrg'] = request.is_digital_org
        if not UtilClient.is_unset(request.location):
            body['location'] = request.location
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateDigitalInvoiceOrgInfo',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/invoices/organizationInfos',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.UpdateDigitalInvoiceOrgInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_digital_invoice_org_info(
        self,
        request: dingtalkbizfinance__1__0_models.UpdateDigitalInvoiceOrgInfoRequest,
    ) -> dingtalkbizfinance__1__0_models.UpdateDigitalInvoiceOrgInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.UpdateDigitalInvoiceOrgInfoHeaders()
        return self.update_digital_invoice_org_info_with_options(request, headers, runtime)

    async def update_digital_invoice_org_info_async(
        self,
        request: dingtalkbizfinance__1__0_models.UpdateDigitalInvoiceOrgInfoRequest,
    ) -> dingtalkbizfinance__1__0_models.UpdateDigitalInvoiceOrgInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.UpdateDigitalInvoiceOrgInfoHeaders()
        return await self.update_digital_invoice_org_info_with_options_async(request, headers, runtime)

    def update_finance_company_info_with_options(
        self,
        request: dingtalkbizfinance__1__0_models.UpdateFinanceCompanyInfoRequest,
        headers: dingtalkbizfinance__1__0_models.UpdateFinanceCompanyInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.UpdateFinanceCompanyInfoResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.company_name):
            query['companyName'] = request.company_name
        if not UtilClient.is_unset(request.tax_nature):
            query['taxNature'] = request.tax_nature
        if not UtilClient.is_unset(request.tax_no):
            query['taxNo'] = request.tax_no
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='UpdateFinanceCompanyInfo',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/companies',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.UpdateFinanceCompanyInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def update_finance_company_info_with_options_async(
        self,
        request: dingtalkbizfinance__1__0_models.UpdateFinanceCompanyInfoRequest,
        headers: dingtalkbizfinance__1__0_models.UpdateFinanceCompanyInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.UpdateFinanceCompanyInfoResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.company_name):
            query['companyName'] = request.company_name
        if not UtilClient.is_unset(request.tax_nature):
            query['taxNature'] = request.tax_nature
        if not UtilClient.is_unset(request.tax_no):
            query['taxNo'] = request.tax_no
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='UpdateFinanceCompanyInfo',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/companies',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.UpdateFinanceCompanyInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_finance_company_info(
        self,
        request: dingtalkbizfinance__1__0_models.UpdateFinanceCompanyInfoRequest,
    ) -> dingtalkbizfinance__1__0_models.UpdateFinanceCompanyInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.UpdateFinanceCompanyInfoHeaders()
        return self.update_finance_company_info_with_options(request, headers, runtime)

    async def update_finance_company_info_async(
        self,
        request: dingtalkbizfinance__1__0_models.UpdateFinanceCompanyInfoRequest,
    ) -> dingtalkbizfinance__1__0_models.UpdateFinanceCompanyInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.UpdateFinanceCompanyInfoHeaders()
        return await self.update_finance_company_info_with_options_async(request, headers, runtime)

    def update_finance_multi_company_info_with_options(
        self,
        request: dingtalkbizfinance__1__0_models.UpdateFinanceMultiCompanyInfoRequest,
        headers: dingtalkbizfinance__1__0_models.UpdateFinanceMultiCompanyInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.UpdateFinanceMultiCompanyInfoResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.company_code):
            query['companyCode'] = request.company_code
        if not UtilClient.is_unset(request.company_name):
            query['companyName'] = request.company_name
        if not UtilClient.is_unset(request.tax_nature):
            query['taxNature'] = request.tax_nature
        if not UtilClient.is_unset(request.tax_no):
            query['taxNo'] = request.tax_no
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='UpdateFinanceMultiCompanyInfo',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/multiCompanies',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.UpdateFinanceMultiCompanyInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def update_finance_multi_company_info_with_options_async(
        self,
        request: dingtalkbizfinance__1__0_models.UpdateFinanceMultiCompanyInfoRequest,
        headers: dingtalkbizfinance__1__0_models.UpdateFinanceMultiCompanyInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.UpdateFinanceMultiCompanyInfoResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.company_code):
            query['companyCode'] = request.company_code
        if not UtilClient.is_unset(request.company_name):
            query['companyName'] = request.company_name
        if not UtilClient.is_unset(request.tax_nature):
            query['taxNature'] = request.tax_nature
        if not UtilClient.is_unset(request.tax_no):
            query['taxNo'] = request.tax_no
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='UpdateFinanceMultiCompanyInfo',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/multiCompanies',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.UpdateFinanceMultiCompanyInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_finance_multi_company_info(
        self,
        request: dingtalkbizfinance__1__0_models.UpdateFinanceMultiCompanyInfoRequest,
    ) -> dingtalkbizfinance__1__0_models.UpdateFinanceMultiCompanyInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.UpdateFinanceMultiCompanyInfoHeaders()
        return self.update_finance_multi_company_info_with_options(request, headers, runtime)

    async def update_finance_multi_company_info_async(
        self,
        request: dingtalkbizfinance__1__0_models.UpdateFinanceMultiCompanyInfoRequest,
    ) -> dingtalkbizfinance__1__0_models.UpdateFinanceMultiCompanyInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.UpdateFinanceMultiCompanyInfoHeaders()
        return await self.update_finance_multi_company_info_with_options_async(request, headers, runtime)

    def update_invoice_abandon_status_with_options(
        self,
        request: dingtalkbizfinance__1__0_models.UpdateInvoiceAbandonStatusRequest,
        headers: dingtalkbizfinance__1__0_models.UpdateInvoiceAbandonStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.UpdateInvoiceAbandonStatusResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.blue_general_invoice_vo):
            body['blueGeneralInvoiceVO'] = request.blue_general_invoice_vo
        if not UtilClient.is_unset(request.blue_invoice_code):
            body['blueInvoiceCode'] = request.blue_invoice_code
        if not UtilClient.is_unset(request.blue_invoice_no):
            body['blueInvoiceNo'] = request.blue_invoice_no
        if not UtilClient.is_unset(request.blue_invoice_status):
            body['blueInvoiceStatus'] = request.blue_invoice_status
        if not UtilClient.is_unset(request.company_code):
            body['companyCode'] = request.company_code
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        if not UtilClient.is_unset(request.red_general_invoice_vo):
            body['redGeneralInvoiceVO'] = request.red_general_invoice_vo
        if not UtilClient.is_unset(request.red_invoice_code):
            body['redInvoiceCode'] = request.red_invoice_code
        if not UtilClient.is_unset(request.red_invoice_no):
            body['redInvoiceNo'] = request.red_invoice_no
        if not UtilClient.is_unset(request.red_invoice_status):
            body['redInvoiceStatus'] = request.red_invoice_status
        if not UtilClient.is_unset(request.target_invoice):
            body['targetInvoice'] = request.target_invoice
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateInvoiceAbandonStatus',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/invoices/abandonStatus',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.UpdateInvoiceAbandonStatusResponse(),
            self.execute(params, req, runtime)
        )

    async def update_invoice_abandon_status_with_options_async(
        self,
        request: dingtalkbizfinance__1__0_models.UpdateInvoiceAbandonStatusRequest,
        headers: dingtalkbizfinance__1__0_models.UpdateInvoiceAbandonStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.UpdateInvoiceAbandonStatusResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.blue_general_invoice_vo):
            body['blueGeneralInvoiceVO'] = request.blue_general_invoice_vo
        if not UtilClient.is_unset(request.blue_invoice_code):
            body['blueInvoiceCode'] = request.blue_invoice_code
        if not UtilClient.is_unset(request.blue_invoice_no):
            body['blueInvoiceNo'] = request.blue_invoice_no
        if not UtilClient.is_unset(request.blue_invoice_status):
            body['blueInvoiceStatus'] = request.blue_invoice_status
        if not UtilClient.is_unset(request.company_code):
            body['companyCode'] = request.company_code
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        if not UtilClient.is_unset(request.red_general_invoice_vo):
            body['redGeneralInvoiceVO'] = request.red_general_invoice_vo
        if not UtilClient.is_unset(request.red_invoice_code):
            body['redInvoiceCode'] = request.red_invoice_code
        if not UtilClient.is_unset(request.red_invoice_no):
            body['redInvoiceNo'] = request.red_invoice_no
        if not UtilClient.is_unset(request.red_invoice_status):
            body['redInvoiceStatus'] = request.red_invoice_status
        if not UtilClient.is_unset(request.target_invoice):
            body['targetInvoice'] = request.target_invoice
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateInvoiceAbandonStatus',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/invoices/abandonStatus',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.UpdateInvoiceAbandonStatusResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_invoice_abandon_status(
        self,
        request: dingtalkbizfinance__1__0_models.UpdateInvoiceAbandonStatusRequest,
    ) -> dingtalkbizfinance__1__0_models.UpdateInvoiceAbandonStatusResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.UpdateInvoiceAbandonStatusHeaders()
        return self.update_invoice_abandon_status_with_options(request, headers, runtime)

    async def update_invoice_abandon_status_async(
        self,
        request: dingtalkbizfinance__1__0_models.UpdateInvoiceAbandonStatusRequest,
    ) -> dingtalkbizfinance__1__0_models.UpdateInvoiceAbandonStatusResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.UpdateInvoiceAbandonStatusHeaders()
        return await self.update_invoice_abandon_status_with_options_async(request, headers, runtime)

    def update_invoice_account_period_with_options(
        self,
        request: dingtalkbizfinance__1__0_models.UpdateInvoiceAccountPeriodRequest,
        headers: dingtalkbizfinance__1__0_models.UpdateInvoiceAccountPeriodHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.UpdateInvoiceAccountPeriodResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.account_period):
            body['accountPeriod'] = request.account_period
        if not UtilClient.is_unset(request.company_code):
            body['companyCode'] = request.company_code
        if not UtilClient.is_unset(request.general_invoice_volist):
            body['generalInvoiceVOList'] = request.general_invoice_volist
        if not UtilClient.is_unset(request.invoice_key_volist):
            body['invoiceKeyVOList'] = request.invoice_key_volist
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateInvoiceAccountPeriod',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/invoices/accountPeriods',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.UpdateInvoiceAccountPeriodResponse(),
            self.execute(params, req, runtime)
        )

    async def update_invoice_account_period_with_options_async(
        self,
        request: dingtalkbizfinance__1__0_models.UpdateInvoiceAccountPeriodRequest,
        headers: dingtalkbizfinance__1__0_models.UpdateInvoiceAccountPeriodHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.UpdateInvoiceAccountPeriodResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.account_period):
            body['accountPeriod'] = request.account_period
        if not UtilClient.is_unset(request.company_code):
            body['companyCode'] = request.company_code
        if not UtilClient.is_unset(request.general_invoice_volist):
            body['generalInvoiceVOList'] = request.general_invoice_volist
        if not UtilClient.is_unset(request.invoice_key_volist):
            body['invoiceKeyVOList'] = request.invoice_key_volist
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateInvoiceAccountPeriod',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/invoices/accountPeriods',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.UpdateInvoiceAccountPeriodResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_invoice_account_period(
        self,
        request: dingtalkbizfinance__1__0_models.UpdateInvoiceAccountPeriodRequest,
    ) -> dingtalkbizfinance__1__0_models.UpdateInvoiceAccountPeriodResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.UpdateInvoiceAccountPeriodHeaders()
        return self.update_invoice_account_period_with_options(request, headers, runtime)

    async def update_invoice_account_period_async(
        self,
        request: dingtalkbizfinance__1__0_models.UpdateInvoiceAccountPeriodRequest,
    ) -> dingtalkbizfinance__1__0_models.UpdateInvoiceAccountPeriodResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.UpdateInvoiceAccountPeriodHeaders()
        return await self.update_invoice_account_period_with_options_async(request, headers, runtime)

    def update_invoice_accounting_period_date_with_options(
        self,
        request: dingtalkbizfinance__1__0_models.UpdateInvoiceAccountingPeriodDateRequest,
        headers: dingtalkbizfinance__1__0_models.UpdateInvoiceAccountingPeriodDateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.UpdateInvoiceAccountingPeriodDateResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.company_code):
            body['companyCode'] = request.company_code
        if not UtilClient.is_unset(request.invoice_finance_info_volist):
            body['invoiceFinanceInfoVOList'] = request.invoice_finance_info_volist
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateInvoiceAccountingPeriodDate',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/invoices/accounts/periodDates',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.UpdateInvoiceAccountingPeriodDateResponse(),
            self.execute(params, req, runtime)
        )

    async def update_invoice_accounting_period_date_with_options_async(
        self,
        request: dingtalkbizfinance__1__0_models.UpdateInvoiceAccountingPeriodDateRequest,
        headers: dingtalkbizfinance__1__0_models.UpdateInvoiceAccountingPeriodDateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.UpdateInvoiceAccountingPeriodDateResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.company_code):
            body['companyCode'] = request.company_code
        if not UtilClient.is_unset(request.invoice_finance_info_volist):
            body['invoiceFinanceInfoVOList'] = request.invoice_finance_info_volist
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateInvoiceAccountingPeriodDate',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/invoices/accounts/periodDates',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.UpdateInvoiceAccountingPeriodDateResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_invoice_accounting_period_date(
        self,
        request: dingtalkbizfinance__1__0_models.UpdateInvoiceAccountingPeriodDateRequest,
    ) -> dingtalkbizfinance__1__0_models.UpdateInvoiceAccountingPeriodDateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.UpdateInvoiceAccountingPeriodDateHeaders()
        return self.update_invoice_accounting_period_date_with_options(request, headers, runtime)

    async def update_invoice_accounting_period_date_async(
        self,
        request: dingtalkbizfinance__1__0_models.UpdateInvoiceAccountingPeriodDateRequest,
    ) -> dingtalkbizfinance__1__0_models.UpdateInvoiceAccountingPeriodDateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.UpdateInvoiceAccountingPeriodDateHeaders()
        return await self.update_invoice_accounting_period_date_with_options_async(request, headers, runtime)

    def update_invoice_accounting_status_with_options(
        self,
        request: dingtalkbizfinance__1__0_models.UpdateInvoiceAccountingStatusRequest,
        headers: dingtalkbizfinance__1__0_models.UpdateInvoiceAccountingStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.UpdateInvoiceAccountingStatusResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.company_code):
            body['companyCode'] = request.company_code
        if not UtilClient.is_unset(request.invoice_finance_info_volist):
            body['invoiceFinanceInfoVOList'] = request.invoice_finance_info_volist
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateInvoiceAccountingStatus',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/invoices/accounts/statuses',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.UpdateInvoiceAccountingStatusResponse(),
            self.execute(params, req, runtime)
        )

    async def update_invoice_accounting_status_with_options_async(
        self,
        request: dingtalkbizfinance__1__0_models.UpdateInvoiceAccountingStatusRequest,
        headers: dingtalkbizfinance__1__0_models.UpdateInvoiceAccountingStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.UpdateInvoiceAccountingStatusResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.company_code):
            body['companyCode'] = request.company_code
        if not UtilClient.is_unset(request.invoice_finance_info_volist):
            body['invoiceFinanceInfoVOList'] = request.invoice_finance_info_volist
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateInvoiceAccountingStatus',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/invoices/accounts/statuses',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.UpdateInvoiceAccountingStatusResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_invoice_accounting_status(
        self,
        request: dingtalkbizfinance__1__0_models.UpdateInvoiceAccountingStatusRequest,
    ) -> dingtalkbizfinance__1__0_models.UpdateInvoiceAccountingStatusResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.UpdateInvoiceAccountingStatusHeaders()
        return self.update_invoice_accounting_status_with_options(request, headers, runtime)

    async def update_invoice_accounting_status_async(
        self,
        request: dingtalkbizfinance__1__0_models.UpdateInvoiceAccountingStatusRequest,
    ) -> dingtalkbizfinance__1__0_models.UpdateInvoiceAccountingStatusResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.UpdateInvoiceAccountingStatusHeaders()
        return await self.update_invoice_accounting_status_with_options_async(request, headers, runtime)

    def update_invoice_and_receipt_related_with_options(
        self,
        request: dingtalkbizfinance__1__0_models.UpdateInvoiceAndReceiptRelatedRequest,
        headers: dingtalkbizfinance__1__0_models.UpdateInvoiceAndReceiptRelatedHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.UpdateInvoiceAndReceiptRelatedResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.general_invoice_vo):
            body['generalInvoiceVO'] = request.general_invoice_vo
        if not UtilClient.is_unset(request.invoice_code):
            body['invoiceCode'] = request.invoice_code
        if not UtilClient.is_unset(request.invoice_no):
            body['invoiceNo'] = request.invoice_no
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        if not UtilClient.is_unset(request.receipt_code):
            body['receiptCode'] = request.receipt_code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateInvoiceAndReceiptRelated',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/invoices/approvalReceipts',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.UpdateInvoiceAndReceiptRelatedResponse(),
            self.execute(params, req, runtime)
        )

    async def update_invoice_and_receipt_related_with_options_async(
        self,
        request: dingtalkbizfinance__1__0_models.UpdateInvoiceAndReceiptRelatedRequest,
        headers: dingtalkbizfinance__1__0_models.UpdateInvoiceAndReceiptRelatedHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.UpdateInvoiceAndReceiptRelatedResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.general_invoice_vo):
            body['generalInvoiceVO'] = request.general_invoice_vo
        if not UtilClient.is_unset(request.invoice_code):
            body['invoiceCode'] = request.invoice_code
        if not UtilClient.is_unset(request.invoice_no):
            body['invoiceNo'] = request.invoice_no
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        if not UtilClient.is_unset(request.receipt_code):
            body['receiptCode'] = request.receipt_code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateInvoiceAndReceiptRelated',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/invoices/approvalReceipts',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.UpdateInvoiceAndReceiptRelatedResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_invoice_and_receipt_related(
        self,
        request: dingtalkbizfinance__1__0_models.UpdateInvoiceAndReceiptRelatedRequest,
    ) -> dingtalkbizfinance__1__0_models.UpdateInvoiceAndReceiptRelatedResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.UpdateInvoiceAndReceiptRelatedHeaders()
        return self.update_invoice_and_receipt_related_with_options(request, headers, runtime)

    async def update_invoice_and_receipt_related_async(
        self,
        request: dingtalkbizfinance__1__0_models.UpdateInvoiceAndReceiptRelatedRequest,
    ) -> dingtalkbizfinance__1__0_models.UpdateInvoiceAndReceiptRelatedResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.UpdateInvoiceAndReceiptRelatedHeaders()
        return await self.update_invoice_and_receipt_related_with_options_async(request, headers, runtime)

    def update_invoice_ignore_status_with_options(
        self,
        request: dingtalkbizfinance__1__0_models.UpdateInvoiceIgnoreStatusRequest,
        headers: dingtalkbizfinance__1__0_models.UpdateInvoiceIgnoreStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.UpdateInvoiceIgnoreStatusResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.instance_id):
            query['instanceId'] = request.instance_id
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
        if not UtilClient.is_unset(request.status):
            query['status'] = request.status
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='UpdateInvoiceIgnoreStatus',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/invoices/ignoreStatus',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.UpdateInvoiceIgnoreStatusResponse(),
            self.execute(params, req, runtime)
        )

    async def update_invoice_ignore_status_with_options_async(
        self,
        request: dingtalkbizfinance__1__0_models.UpdateInvoiceIgnoreStatusRequest,
        headers: dingtalkbizfinance__1__0_models.UpdateInvoiceIgnoreStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.UpdateInvoiceIgnoreStatusResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.instance_id):
            query['instanceId'] = request.instance_id
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
        if not UtilClient.is_unset(request.status):
            query['status'] = request.status
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='UpdateInvoiceIgnoreStatus',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/invoices/ignoreStatus',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.UpdateInvoiceIgnoreStatusResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_invoice_ignore_status(
        self,
        request: dingtalkbizfinance__1__0_models.UpdateInvoiceIgnoreStatusRequest,
    ) -> dingtalkbizfinance__1__0_models.UpdateInvoiceIgnoreStatusResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.UpdateInvoiceIgnoreStatusHeaders()
        return self.update_invoice_ignore_status_with_options(request, headers, runtime)

    async def update_invoice_ignore_status_async(
        self,
        request: dingtalkbizfinance__1__0_models.UpdateInvoiceIgnoreStatusRequest,
    ) -> dingtalkbizfinance__1__0_models.UpdateInvoiceIgnoreStatusResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.UpdateInvoiceIgnoreStatusHeaders()
        return await self.update_invoice_ignore_status_with_options_async(request, headers, runtime)

    def update_invoice_verify_status_with_options(
        self,
        request: dingtalkbizfinance__1__0_models.UpdateInvoiceVerifyStatusRequest,
        headers: dingtalkbizfinance__1__0_models.UpdateInvoiceVerifyStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.UpdateInvoiceVerifyStatusResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.company_code):
            body['companyCode'] = request.company_code
        if not UtilClient.is_unset(request.deduct_status):
            body['deductStatus'] = request.deduct_status
        if not UtilClient.is_unset(request.general_invoice_volist):
            body['generalInvoiceVOList'] = request.general_invoice_volist
        if not UtilClient.is_unset(request.invoice_key_volist):
            body['invoiceKeyVOList'] = request.invoice_key_volist
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        if not UtilClient.is_unset(request.verify_status):
            body['verifyStatus'] = request.verify_status
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateInvoiceVerifyStatus',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/invoices/verifyStatus',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.UpdateInvoiceVerifyStatusResponse(),
            self.execute(params, req, runtime)
        )

    async def update_invoice_verify_status_with_options_async(
        self,
        request: dingtalkbizfinance__1__0_models.UpdateInvoiceVerifyStatusRequest,
        headers: dingtalkbizfinance__1__0_models.UpdateInvoiceVerifyStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.UpdateInvoiceVerifyStatusResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.company_code):
            body['companyCode'] = request.company_code
        if not UtilClient.is_unset(request.deduct_status):
            body['deductStatus'] = request.deduct_status
        if not UtilClient.is_unset(request.general_invoice_volist):
            body['generalInvoiceVOList'] = request.general_invoice_volist
        if not UtilClient.is_unset(request.invoice_key_volist):
            body['invoiceKeyVOList'] = request.invoice_key_volist
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        if not UtilClient.is_unset(request.verify_status):
            body['verifyStatus'] = request.verify_status
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateInvoiceVerifyStatus',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/invoices/verifyStatus',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.UpdateInvoiceVerifyStatusResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_invoice_verify_status(
        self,
        request: dingtalkbizfinance__1__0_models.UpdateInvoiceVerifyStatusRequest,
    ) -> dingtalkbizfinance__1__0_models.UpdateInvoiceVerifyStatusResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.UpdateInvoiceVerifyStatusHeaders()
        return self.update_invoice_verify_status_with_options(request, headers, runtime)

    async def update_invoice_verify_status_async(
        self,
        request: dingtalkbizfinance__1__0_models.UpdateInvoiceVerifyStatusRequest,
    ) -> dingtalkbizfinance__1__0_models.UpdateInvoiceVerifyStatusResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.UpdateInvoiceVerifyStatusHeaders()
        return await self.update_invoice_verify_status_with_options_async(request, headers, runtime)

    def update_invoice_voucher_status_with_options(
        self,
        request: dingtalkbizfinance__1__0_models.UpdateInvoiceVoucherStatusRequest,
        headers: dingtalkbizfinance__1__0_models.UpdateInvoiceVoucherStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.UpdateInvoiceVoucherStatusResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.accountant_book_id):
            body['accountantBookId'] = request.accountant_book_id
        if not UtilClient.is_unset(request.action_type):
            body['actionType'] = request.action_type
        if not UtilClient.is_unset(request.invoice_code):
            body['invoiceCode'] = request.invoice_code
        if not UtilClient.is_unset(request.invoice_no):
            body['invoiceNo'] = request.invoice_no
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        if not UtilClient.is_unset(request.voucher_id):
            body['voucherId'] = request.voucher_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateInvoiceVoucherStatus',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/invoices/vouchers/states',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.UpdateInvoiceVoucherStatusResponse(),
            self.execute(params, req, runtime)
        )

    async def update_invoice_voucher_status_with_options_async(
        self,
        request: dingtalkbizfinance__1__0_models.UpdateInvoiceVoucherStatusRequest,
        headers: dingtalkbizfinance__1__0_models.UpdateInvoiceVoucherStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.UpdateInvoiceVoucherStatusResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.accountant_book_id):
            body['accountantBookId'] = request.accountant_book_id
        if not UtilClient.is_unset(request.action_type):
            body['actionType'] = request.action_type
        if not UtilClient.is_unset(request.invoice_code):
            body['invoiceCode'] = request.invoice_code
        if not UtilClient.is_unset(request.invoice_no):
            body['invoiceNo'] = request.invoice_no
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        if not UtilClient.is_unset(request.voucher_id):
            body['voucherId'] = request.voucher_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateInvoiceVoucherStatus',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/invoices/vouchers/states',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.UpdateInvoiceVoucherStatusResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_invoice_voucher_status(
        self,
        request: dingtalkbizfinance__1__0_models.UpdateInvoiceVoucherStatusRequest,
    ) -> dingtalkbizfinance__1__0_models.UpdateInvoiceVoucherStatusResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.UpdateInvoiceVoucherStatusHeaders()
        return self.update_invoice_voucher_status_with_options(request, headers, runtime)

    async def update_invoice_voucher_status_async(
        self,
        request: dingtalkbizfinance__1__0_models.UpdateInvoiceVoucherStatusRequest,
    ) -> dingtalkbizfinance__1__0_models.UpdateInvoiceVoucherStatusResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.UpdateInvoiceVoucherStatusHeaders()
        return await self.update_invoice_voucher_status_with_options_async(request, headers, runtime)

    def update_receipt_with_options(
        self,
        request: dingtalkbizfinance__1__0_models.UpdateReceiptRequest,
        headers: dingtalkbizfinance__1__0_models.UpdateReceiptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.UpdateReceiptResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.receipts):
            body['receipts'] = request.receipts
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateReceipt',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/receipts',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.UpdateReceiptResponse(),
            self.execute(params, req, runtime)
        )

    async def update_receipt_with_options_async(
        self,
        request: dingtalkbizfinance__1__0_models.UpdateReceiptRequest,
        headers: dingtalkbizfinance__1__0_models.UpdateReceiptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.UpdateReceiptResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.receipts):
            body['receipts'] = request.receipts
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateReceipt',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/receipts',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.UpdateReceiptResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_receipt(
        self,
        request: dingtalkbizfinance__1__0_models.UpdateReceiptRequest,
    ) -> dingtalkbizfinance__1__0_models.UpdateReceiptResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.UpdateReceiptHeaders()
        return self.update_receipt_with_options(request, headers, runtime)

    async def update_receipt_async(
        self,
        request: dingtalkbizfinance__1__0_models.UpdateReceiptRequest,
    ) -> dingtalkbizfinance__1__0_models.UpdateReceiptResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.UpdateReceiptHeaders()
        return await self.update_receipt_with_options_async(request, headers, runtime)

    def update_receipt_voucher_status_with_options(
        self,
        request: dingtalkbizfinance__1__0_models.UpdateReceiptVoucherStatusRequest,
        headers: dingtalkbizfinance__1__0_models.UpdateReceiptVoucherStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.UpdateReceiptVoucherStatusResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.account_period):
            body['accountPeriod'] = request.account_period
        if not UtilClient.is_unset(request.action_type):
            body['actionType'] = request.action_type
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.receipt_id):
            body['receiptId'] = request.receipt_id
        if not UtilClient.is_unset(request.voucher_code):
            body['voucherCode'] = request.voucher_code
        if not UtilClient.is_unset(request.voucher_id):
            body['voucherId'] = request.voucher_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateReceiptVoucherStatus',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/vouchers/recepits',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.UpdateReceiptVoucherStatusResponse(),
            self.execute(params, req, runtime)
        )

    async def update_receipt_voucher_status_with_options_async(
        self,
        request: dingtalkbizfinance__1__0_models.UpdateReceiptVoucherStatusRequest,
        headers: dingtalkbizfinance__1__0_models.UpdateReceiptVoucherStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.UpdateReceiptVoucherStatusResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.account_period):
            body['accountPeriod'] = request.account_period
        if not UtilClient.is_unset(request.action_type):
            body['actionType'] = request.action_type
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.receipt_id):
            body['receiptId'] = request.receipt_id
        if not UtilClient.is_unset(request.voucher_code):
            body['voucherCode'] = request.voucher_code
        if not UtilClient.is_unset(request.voucher_id):
            body['voucherId'] = request.voucher_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateReceiptVoucherStatus',
            version='bizfinance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bizfinance/vouchers/recepits',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.UpdateReceiptVoucherStatusResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_receipt_voucher_status(
        self,
        request: dingtalkbizfinance__1__0_models.UpdateReceiptVoucherStatusRequest,
    ) -> dingtalkbizfinance__1__0_models.UpdateReceiptVoucherStatusResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.UpdateReceiptVoucherStatusHeaders()
        return self.update_receipt_voucher_status_with_options(request, headers, runtime)

    async def update_receipt_voucher_status_async(
        self,
        request: dingtalkbizfinance__1__0_models.UpdateReceiptVoucherStatusRequest,
    ) -> dingtalkbizfinance__1__0_models.UpdateReceiptVoucherStatusResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.UpdateReceiptVoucherStatusHeaders()
        return await self.update_receipt_voucher_status_with_options_async(request, headers, runtime)
