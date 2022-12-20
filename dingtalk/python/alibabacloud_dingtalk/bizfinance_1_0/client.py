# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.bizfinance_1_0 import models as dingtalkbizfinance__1__0_models
from alibabacloud_tea_util import models as util_models
from alibabacloud_openapi_util.client import Client as OpenApiUtilClient


class Client(OpenApiClient):
    """
    *\
    """
    def __init__(
        self, 
        config: open_api_models.Config,
    ):
        super().__init__(config)
        self._endpoint_rule = ''
        if UtilClient.empty(self._endpoint):
            self._endpoint = 'api.dingtalk.com'

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

    def batch_add_invoice_with_options(
        self,
        request: dingtalkbizfinance__1__0_models.BatchAddInvoiceRequest,
        headers: dingtalkbizfinance__1__0_models.BatchAddInvoiceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.BatchAddInvoiceResponse:
        UtilClient.validate_model(request)
        body = {}
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.BatchAddInvoiceResponse(),
            self.do_roarequest('BatchAddInvoice', 'bizfinance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/bizfinance/invoices/batch', 'json', req, runtime)
        )

    async def batch_add_invoice_with_options_async(
        self,
        request: dingtalkbizfinance__1__0_models.BatchAddInvoiceRequest,
        headers: dingtalkbizfinance__1__0_models.BatchAddInvoiceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.BatchAddInvoiceResponse:
        UtilClient.validate_model(request)
        body = {}
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.BatchAddInvoiceResponse(),
            await self.do_roarequest_async('BatchAddInvoice', 'bizfinance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/bizfinance/invoices/batch', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.BatchCreateCustomerResponse(),
            self.do_roarequest('BatchCreateCustomer', 'bizfinance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/bizfinance/auxiliaries/batch', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.BatchCreateCustomerResponse(),
            await self.do_roarequest_async('BatchCreateCustomer', 'bizfinance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/bizfinance/auxiliaries/batch', 'json', req, runtime)
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

    def check_voucher_status_with_options(
        self,
        request: dingtalkbizfinance__1__0_models.CheckVoucherStatusRequest,
        headers: dingtalkbizfinance__1__0_models.CheckVoucherStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.CheckVoucherStatusResponse:
        UtilClient.validate_model(request)
        body = {}
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.CheckVoucherStatusResponse(),
            self.do_roarequest('CheckVoucherStatus', 'bizfinance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/bizfinance/invoices/checkVoucherStatus/query', 'json', req, runtime)
        )

    async def check_voucher_status_with_options_async(
        self,
        request: dingtalkbizfinance__1__0_models.CheckVoucherStatusRequest,
        headers: dingtalkbizfinance__1__0_models.CheckVoucherStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.CheckVoucherStatusResponse:
        UtilClient.validate_model(request)
        body = {}
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.CheckVoucherStatusResponse(),
            await self.do_roarequest_async('CheckVoucherStatus', 'bizfinance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/bizfinance/invoices/checkVoucherStatus/query', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.CreateCustomerResponse(),
            self.do_roarequest('CreateCustomer', 'bizfinance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/bizfinance/auxiliaries/customers', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.CreateCustomerResponse(),
            await self.do_roarequest_async('CreateCustomer', 'bizfinance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/bizfinance/auxiliaries/customers', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.CreateReceiptResponse(),
            self.do_roarequest('CreateReceipt', 'bizfinance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/bizfinance/receipts', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.CreateReceiptResponse(),
            await self.do_roarequest_async('CreateReceipt', 'bizfinance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/bizfinance/receipts', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.DeleteReceiptResponse(),
            self.do_roarequest('DeleteReceipt', 'bizfinance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/bizfinance/receipts/remove', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.DeleteReceiptResponse(),
            await self.do_roarequest_async('DeleteReceipt', 'bizfinance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/bizfinance/receipts/remove', 'json', req, runtime)
        )

    def get_bookkeeping_user_list(self) -> dingtalkbizfinance__1__0_models.GetBookkeepingUserListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.GetBookkeepingUserListHeaders()
        return self.get_bookkeeping_user_list_with_options(headers, runtime)

    async def get_bookkeeping_user_list_async(self) -> dingtalkbizfinance__1__0_models.GetBookkeepingUserListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.GetBookkeepingUserListHeaders()
        return await self.get_bookkeeping_user_list_with_options_async(headers, runtime)

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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.GetBookkeepingUserListResponse(),
            self.do_roarequest('GetBookkeepingUserList', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/bizfinance/bookkeeping/users', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.GetBookkeepingUserListResponse(),
            await self.do_roarequest_async('GetBookkeepingUserList', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/bizfinance/bookkeeping/users', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.GetCategoryResponse(),
            self.do_roarequest('GetCategory', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/bizfinance/categories/get', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.GetCategoryResponse(),
            await self.do_roarequest_async('GetCategory', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/bizfinance/categories/get', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.GetCustomerResponse(),
            self.do_roarequest('GetCustomer', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/bizfinance/customers/details', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.GetCustomerResponse(),
            await self.do_roarequest_async('GetCustomer', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/bizfinance/customers/details', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.GetFinanceAccountResponse(),
            self.do_roarequest('GetFinanceAccount', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/bizfinance/financeAccounts/get', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.GetFinanceAccountResponse(),
            await self.do_roarequest_async('GetFinanceAccount', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/bizfinance/financeAccounts/get', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.GetInvoiceByPageResponse(),
            self.do_roarequest('GetInvoiceByPage', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/bizfinance/invoices', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.GetInvoiceByPageResponse(),
            await self.do_roarequest_async('GetInvoiceByPage', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/bizfinance/invoices', 'json', req, runtime)
        )

    def get_is_new_version(self) -> dingtalkbizfinance__1__0_models.GetIsNewVersionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.GetIsNewVersionHeaders()
        return self.get_is_new_version_with_options(headers, runtime)

    async def get_is_new_version_async(self) -> dingtalkbizfinance__1__0_models.GetIsNewVersionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.GetIsNewVersionHeaders()
        return await self.get_is_new_version_with_options_async(headers, runtime)

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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.GetIsNewVersionResponse(),
            self.do_roarequest('GetIsNewVersion', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/bizfinance/accounts/uses', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.GetIsNewVersionResponse(),
            await self.do_roarequest_async('GetIsNewVersion', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/bizfinance/accounts/uses', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.GetProjectResponse(),
            self.do_roarequest('GetProject', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/bizfinance/projects/get', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.GetProjectResponse(),
            await self.do_roarequest_async('GetProject', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/bizfinance/projects/get', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.GetReceiptResponse(),
            self.do_roarequest('GetReceipt', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/bizfinance/receipts/details', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.GetReceiptResponse(),
            await self.do_roarequest_async('GetReceipt', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/bizfinance/receipts/details', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.GetSupplierResponse(),
            self.do_roarequest('GetSupplier', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/bizfinance/suppliers/details', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.GetSupplierResponse(),
            await self.do_roarequest_async('GetSupplier', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/bizfinance/suppliers/details', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.ProfessionBenefitConsumeResponse(),
            self.do_roarequest('ProfessionBenefitConsume', 'bizfinance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/bizfinance/professions/benefits/consume', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.ProfessionBenefitConsumeResponse(),
            await self.do_roarequest_async('ProfessionBenefitConsume', 'bizfinance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/bizfinance/professions/benefits/consume', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryCategoryByPageResponse(),
            self.do_roarequest('QueryCategoryByPage', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/bizfinance/categories/list', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryCategoryByPageResponse(),
            await self.do_roarequest_async('QueryCategoryByPage', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/bizfinance/categories/list', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryCustomerByPageResponse(),
            self.do_roarequest('QueryCustomerByPage', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/bizfinance/customers', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryCustomerByPageResponse(),
            await self.do_roarequest_async('QueryCustomerByPage', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/bizfinance/customers', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryCustomerInfoResponse(),
            self.do_roarequest('QueryCustomerInfo', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/bizfinance/auxiliaries/customers', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryCustomerInfoResponse(),
            await self.do_roarequest_async('QueryCustomerInfo', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/bizfinance/auxiliaries/customers', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryEnterpriseAccountByPageResponse(),
            self.do_roarequest('QueryEnterpriseAccountByPage', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/bizfinance/financeAccounts/list', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryEnterpriseAccountByPageResponse(),
            await self.do_roarequest_async('QueryEnterpriseAccountByPage', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/bizfinance/financeAccounts/list', 'json', req, runtime)
        )

    def query_finance_company_info(self) -> dingtalkbizfinance__1__0_models.QueryFinanceCompanyInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.QueryFinanceCompanyInfoHeaders()
        return self.query_finance_company_info_with_options(headers, runtime)

    async def query_finance_company_info_async(self) -> dingtalkbizfinance__1__0_models.QueryFinanceCompanyInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.QueryFinanceCompanyInfoHeaders()
        return await self.query_finance_company_info_with_options_async(headers, runtime)

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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryFinanceCompanyInfoResponse(),
            self.do_roarequest('QueryFinanceCompanyInfo', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/bizfinance/companies', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryFinanceCompanyInfoResponse(),
            await self.do_roarequest_async('QueryFinanceCompanyInfo', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/bizfinance/companies', 'json', req, runtime)
        )

    def query_invoice_relation_count(self) -> dingtalkbizfinance__1__0_models.QueryInvoiceRelationCountResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.QueryInvoiceRelationCountHeaders()
        return self.query_invoice_relation_count_with_options(headers, runtime)

    async def query_invoice_relation_count_async(self) -> dingtalkbizfinance__1__0_models.QueryInvoiceRelationCountResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.QueryInvoiceRelationCountHeaders()
        return await self.query_invoice_relation_count_with_options_async(headers, runtime)

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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryInvoiceRelationCountResponse(),
            self.do_roarequest('QueryInvoiceRelationCount', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/bizfinance/invoices/relationReceipts/counts', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryInvoiceRelationCountResponse(),
            await self.do_roarequest_async('QueryInvoiceRelationCount', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/bizfinance/invoices/relationReceipts/counts', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryPermissionByUserIdResponse(),
            self.do_roarequest('QueryPermissionByUserId', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/bizfinance/permissions', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryPermissionByUserIdResponse(),
            await self.do_roarequest_async('QueryPermissionByUserId', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/bizfinance/permissions', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryPermissionRoleMemberResponse(),
            self.do_roarequest('QueryPermissionRoleMember', 'bizfinance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/bizfinance/roles/members/query', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryPermissionRoleMemberResponse(),
            await self.do_roarequest_async('QueryPermissionRoleMember', 'bizfinance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/bizfinance/roles/members/query', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryProjectByPageResponse(),
            self.do_roarequest('QueryProjectByPage', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/bizfinance/projects/list', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryProjectByPageResponse(),
            await self.do_roarequest_async('QueryProjectByPage', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/bizfinance/projects/list', 'json', req, runtime)
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

    def query_receipt_for_invoice_with_options(
        self,
        request: dingtalkbizfinance__1__0_models.QueryReceiptForInvoiceRequest,
        headers: dingtalkbizfinance__1__0_models.QueryReceiptForInvoiceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.QueryReceiptForInvoiceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.apply_status_list):
            body['applyStatusList'] = request.apply_status_list
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.receipt_status_list):
            body['receiptStatusList'] = request.receipt_status_list
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryReceiptForInvoiceResponse(),
            self.do_roarequest('QueryReceiptForInvoice', 'bizfinance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/bizfinance/invoices/receipts/query', 'json', req, runtime)
        )

    async def query_receipt_for_invoice_with_options_async(
        self,
        request: dingtalkbizfinance__1__0_models.QueryReceiptForInvoiceRequest,
        headers: dingtalkbizfinance__1__0_models.QueryReceiptForInvoiceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.QueryReceiptForInvoiceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.apply_status_list):
            body['applyStatusList'] = request.apply_status_list
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.receipt_status_list):
            body['receiptStatusList'] = request.receipt_status_list
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryReceiptForInvoiceResponse(),
            await self.do_roarequest_async('QueryReceiptForInvoice', 'bizfinance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/bizfinance/invoices/receipts/query', 'json', req, runtime)
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

    def query_receipts_base_info_with_options(
        self,
        request: dingtalkbizfinance__1__0_models.QueryReceiptsBaseInfoRequest,
        headers: dingtalkbizfinance__1__0_models.QueryReceiptsBaseInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.QueryReceiptsBaseInfoResponse:
        UtilClient.validate_model(request)
        query = {}
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryReceiptsBaseInfoResponse(),
            self.do_roarequest('QueryReceiptsBaseInfo', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/bizfinance/receipts/dataInfos', 'json', req, runtime)
        )

    async def query_receipts_base_info_with_options_async(
        self,
        request: dingtalkbizfinance__1__0_models.QueryReceiptsBaseInfoRequest,
        headers: dingtalkbizfinance__1__0_models.QueryReceiptsBaseInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.QueryReceiptsBaseInfoResponse:
        UtilClient.validate_model(request)
        query = {}
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryReceiptsBaseInfoResponse(),
            await self.do_roarequest_async('QueryReceiptsBaseInfo', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/bizfinance/receipts/dataInfos', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryReceiptsByPageResponse(),
            self.do_roarequest('QueryReceiptsByPage', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/bizfinance/receipts', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryReceiptsByPageResponse(),
            await self.do_roarequest_async('QueryReceiptsByPage', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/bizfinance/receipts', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QuerySupplierByPageResponse(),
            self.do_roarequest('QuerySupplierByPage', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/bizfinance/suppliers', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QuerySupplierByPageResponse(),
            await self.do_roarequest_async('QuerySupplierByPage', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/bizfinance/suppliers', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.UnbindApplyReceiptAndInvoiceRelatedResponse(),
            self.do_roarequest('UnbindApplyReceiptAndInvoiceRelated', 'bizfinance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/bizfinance/invoices/unbind', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.UnbindApplyReceiptAndInvoiceRelatedResponse(),
            await self.do_roarequest_async('UnbindApplyReceiptAndInvoiceRelated', 'bizfinance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/bizfinance/invoices/unbind', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.UpdateApplyReceiptAndInvoiceRelatedResponse(),
            self.do_roarequest('UpdateApplyReceiptAndInvoiceRelated', 'bizfinance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/bizfinance/invoices/applyReceipts/relate', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.UpdateApplyReceiptAndInvoiceRelatedResponse(),
            await self.do_roarequest_async('UpdateApplyReceiptAndInvoiceRelated', 'bizfinance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/bizfinance/invoices/applyReceipts/relate', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.UpdateFinanceCompanyInfoResponse(),
            self.do_roarequest('UpdateFinanceCompanyInfo', 'bizfinance_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/bizfinance/companies', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.UpdateFinanceCompanyInfoResponse(),
            await self.do_roarequest_async('UpdateFinanceCompanyInfo', 'bizfinance_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/bizfinance/companies', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.UpdateInvoiceAbandonStatusResponse(),
            self.do_roarequest('UpdateInvoiceAbandonStatus', 'bizfinance_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/bizfinance/invoices/abandonStatus', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.UpdateInvoiceAbandonStatusResponse(),
            await self.do_roarequest_async('UpdateInvoiceAbandonStatus', 'bizfinance_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/bizfinance/invoices/abandonStatus', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.UpdateInvoiceAccountPeriodResponse(),
            self.do_roarequest('UpdateInvoiceAccountPeriod', 'bizfinance_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/bizfinance/invoices/accountPeriods', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.UpdateInvoiceAccountPeriodResponse(),
            await self.do_roarequest_async('UpdateInvoiceAccountPeriod', 'bizfinance_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/bizfinance/invoices/accountPeriods', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.UpdateInvoiceAndReceiptRelatedResponse(),
            self.do_roarequest('UpdateInvoiceAndReceiptRelated', 'bizfinance_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/bizfinance/invoices/approvalReceipts', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.UpdateInvoiceAndReceiptRelatedResponse(),
            await self.do_roarequest_async('UpdateInvoiceAndReceiptRelated', 'bizfinance_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/bizfinance/invoices/approvalReceipts', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.UpdateInvoiceIgnoreStatusResponse(),
            self.do_roarequest('UpdateInvoiceIgnoreStatus', 'bizfinance_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/bizfinance/invoices/ignoreStatus', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.UpdateInvoiceIgnoreStatusResponse(),
            await self.do_roarequest_async('UpdateInvoiceIgnoreStatus', 'bizfinance_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/bizfinance/invoices/ignoreStatus', 'json', req, runtime)
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

    def update_invoice_verify_status_with_options(
        self,
        request: dingtalkbizfinance__1__0_models.UpdateInvoiceVerifyStatusRequest,
        headers: dingtalkbizfinance__1__0_models.UpdateInvoiceVerifyStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.UpdateInvoiceVerifyStatusResponse:
        UtilClient.validate_model(request)
        body = {}
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.UpdateInvoiceVerifyStatusResponse(),
            self.do_roarequest('UpdateInvoiceVerifyStatus', 'bizfinance_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/bizfinance/invoices/verifyStatus', 'json', req, runtime)
        )

    async def update_invoice_verify_status_with_options_async(
        self,
        request: dingtalkbizfinance__1__0_models.UpdateInvoiceVerifyStatusRequest,
        headers: dingtalkbizfinance__1__0_models.UpdateInvoiceVerifyStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.UpdateInvoiceVerifyStatusResponse:
        UtilClient.validate_model(request)
        body = {}
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.UpdateInvoiceVerifyStatusResponse(),
            await self.do_roarequest_async('UpdateInvoiceVerifyStatus', 'bizfinance_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/bizfinance/invoices/verifyStatus', 'json', req, runtime)
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

    def update_invoice_voucher_status_with_options(
        self,
        request: dingtalkbizfinance__1__0_models.UpdateInvoiceVoucherStatusRequest,
        headers: dingtalkbizfinance__1__0_models.UpdateInvoiceVoucherStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.UpdateInvoiceVoucherStatusResponse:
        UtilClient.validate_model(request)
        body = {}
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.UpdateInvoiceVoucherStatusResponse(),
            self.do_roarequest('UpdateInvoiceVoucherStatus', 'bizfinance_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/bizfinance/invoices/vouchers/states', 'json', req, runtime)
        )

    async def update_invoice_voucher_status_with_options_async(
        self,
        request: dingtalkbizfinance__1__0_models.UpdateInvoiceVoucherStatusRequest,
        headers: dingtalkbizfinance__1__0_models.UpdateInvoiceVoucherStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.UpdateInvoiceVoucherStatusResponse:
        UtilClient.validate_model(request)
        body = {}
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.UpdateInvoiceVoucherStatusResponse(),
            await self.do_roarequest_async('UpdateInvoiceVoucherStatus', 'bizfinance_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/bizfinance/invoices/vouchers/states', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.UpdateReceiptResponse(),
            self.do_roarequest('UpdateReceipt', 'bizfinance_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/bizfinance/receipts', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.UpdateReceiptResponse(),
            await self.do_roarequest_async('UpdateReceipt', 'bizfinance_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/bizfinance/receipts', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.UpdateReceiptVoucherStatusResponse(),
            self.do_roarequest('UpdateReceiptVoucherStatus', 'bizfinance_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/bizfinance/vouchers/recepits', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.UpdateReceiptVoucherStatusResponse(),
            await self.do_roarequest_async('UpdateReceiptVoucherStatus', 'bizfinance_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/bizfinance/vouchers/recepits', 'json', req, runtime)
        )
