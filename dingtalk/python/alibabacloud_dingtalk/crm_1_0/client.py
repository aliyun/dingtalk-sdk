# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalkcrm_1_0 import models as dingtalkcrm__1__0_models
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

    def query_all_customer(
        self,
        request: dingtalkcrm__1__0_models.QueryAllCustomerRequest,
    ) -> dingtalkcrm__1__0_models.QueryAllCustomerResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.QueryAllCustomerHeaders()
        return self.query_all_customer_with_options(request, headers, runtime)

    async def query_all_customer_async(
        self,
        request: dingtalkcrm__1__0_models.QueryAllCustomerRequest,
    ) -> dingtalkcrm__1__0_models.QueryAllCustomerResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.QueryAllCustomerHeaders()
        return await self.query_all_customer_with_options_async(request, headers, runtime)

    def query_all_customer_with_options(
        self,
        request: dingtalkcrm__1__0_models.QueryAllCustomerRequest,
        headers: dingtalkcrm__1__0_models.QueryAllCustomerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.QueryAllCustomerResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
        if not UtilClient.is_unset(request.ding_token_grant_type):
            body['dingTokenGrantType'] = request.ding_token_grant_type
        if not UtilClient.is_unset(request.ding_corp_id):
            body['dingCorpId'] = request.ding_corp_id
        if not UtilClient.is_unset(request.ding_suite_key):
            body['dingSuiteKey'] = request.ding_suite_key
        if not UtilClient.is_unset(request.operator_user_id):
            body['operatorUserId'] = request.operator_user_id
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.object_type):
            body['objectType'] = request.object_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return dingtalkcrm__1__0_models.QueryAllCustomerResponse().from_map(
            self.do_roarequest('QueryAllCustomer', 'crm_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/crm/customerInstances', 'json', req, runtime)
        )

    async def query_all_customer_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.QueryAllCustomerRequest,
        headers: dingtalkcrm__1__0_models.QueryAllCustomerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.QueryAllCustomerResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
        if not UtilClient.is_unset(request.ding_token_grant_type):
            body['dingTokenGrantType'] = request.ding_token_grant_type
        if not UtilClient.is_unset(request.ding_corp_id):
            body['dingCorpId'] = request.ding_corp_id
        if not UtilClient.is_unset(request.ding_suite_key):
            body['dingSuiteKey'] = request.ding_suite_key
        if not UtilClient.is_unset(request.operator_user_id):
            body['operatorUserId'] = request.operator_user_id
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.object_type):
            body['objectType'] = request.object_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return dingtalkcrm__1__0_models.QueryAllCustomerResponse().from_map(
            await self.do_roarequest_async('QueryAllCustomer', 'crm_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/crm/customerInstances', 'json', req, runtime)
        )

    def get_official_account_contacts(
        self,
        request: dingtalkcrm__1__0_models.GetOfficialAccountContactsRequest,
    ) -> dingtalkcrm__1__0_models.GetOfficialAccountContactsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.GetOfficialAccountContactsHeaders()
        return self.get_official_account_contacts_with_options(request, headers, runtime)

    async def get_official_account_contacts_async(
        self,
        request: dingtalkcrm__1__0_models.GetOfficialAccountContactsRequest,
    ) -> dingtalkcrm__1__0_models.GetOfficialAccountContactsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.GetOfficialAccountContactsHeaders()
        return await self.get_official_account_contacts_with_options_async(request, headers, runtime)

    def get_official_account_contacts_with_options(
        self,
        tmp_req: dingtalkcrm__1__0_models.GetOfficialAccountContactsRequest,
        headers: dingtalkcrm__1__0_models.GetOfficialAccountContactsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.GetOfficialAccountContactsResponse:
        UtilClient.validate_model(tmp_req)
        request = dingtalkcrm__1__0_models.GetOfficialAccountContactsShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.context):
            request.context_shrink = OpenApiUtilClient.array_to_string_with_specified_style(TeaCore.to_map(tmp_req.context), 'context', 'json')
        query = {}
        if not UtilClient.is_unset(request.context_shrink):
            query['context'] = request.context_shrink
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return dingtalkcrm__1__0_models.GetOfficialAccountContactsResponse().from_map(
            self.do_roarequest('GetOfficialAccountContacts', 'crm_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/crm/officialAccounts/contacts', 'json', req, runtime)
        )

    async def get_official_account_contacts_with_options_async(
        self,
        tmp_req: dingtalkcrm__1__0_models.GetOfficialAccountContactsRequest,
        headers: dingtalkcrm__1__0_models.GetOfficialAccountContactsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.GetOfficialAccountContactsResponse:
        UtilClient.validate_model(tmp_req)
        request = dingtalkcrm__1__0_models.GetOfficialAccountContactsShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.context):
            request.context_shrink = OpenApiUtilClient.array_to_string_with_specified_style(TeaCore.to_map(tmp_req.context), 'context', 'json')
        query = {}
        if not UtilClient.is_unset(request.context_shrink):
            query['context'] = request.context_shrink
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return dingtalkcrm__1__0_models.GetOfficialAccountContactsResponse().from_map(
            await self.do_roarequest_async('GetOfficialAccountContacts', 'crm_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/crm/officialAccounts/contacts', 'json', req, runtime)
        )

    def get_official_account_contact_info(
        self,
        user_id: str,
        request: dingtalkcrm__1__0_models.GetOfficialAccountContactInfoRequest,
    ) -> dingtalkcrm__1__0_models.GetOfficialAccountContactInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.GetOfficialAccountContactInfoHeaders()
        return self.get_official_account_contact_info_with_options(user_id, request, headers, runtime)

    async def get_official_account_contact_info_async(
        self,
        user_id: str,
        request: dingtalkcrm__1__0_models.GetOfficialAccountContactInfoRequest,
    ) -> dingtalkcrm__1__0_models.GetOfficialAccountContactInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.GetOfficialAccountContactInfoHeaders()
        return await self.get_official_account_contact_info_with_options_async(user_id, request, headers, runtime)

    def get_official_account_contact_info_with_options(
        self,
        user_id: str,
        tmp_req: dingtalkcrm__1__0_models.GetOfficialAccountContactInfoRequest,
        headers: dingtalkcrm__1__0_models.GetOfficialAccountContactInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.GetOfficialAccountContactInfoResponse:
        UtilClient.validate_model(tmp_req)
        request = dingtalkcrm__1__0_models.GetOfficialAccountContactInfoShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.context):
            request.context_shrink = OpenApiUtilClient.array_to_string_with_specified_style(TeaCore.to_map(tmp_req.context), 'context', 'json')
        query = {}
        if not UtilClient.is_unset(request.context_shrink):
            query['context'] = request.context_shrink
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return dingtalkcrm__1__0_models.GetOfficialAccountContactInfoResponse().from_map(
            self.do_roarequest('GetOfficialAccountContactInfo', 'crm_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/crm/officialAccounts/contacts/{user_id}', 'json', req, runtime)
        )

    async def get_official_account_contact_info_with_options_async(
        self,
        user_id: str,
        tmp_req: dingtalkcrm__1__0_models.GetOfficialAccountContactInfoRequest,
        headers: dingtalkcrm__1__0_models.GetOfficialAccountContactInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.GetOfficialAccountContactInfoResponse:
        UtilClient.validate_model(tmp_req)
        request = dingtalkcrm__1__0_models.GetOfficialAccountContactInfoShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.context):
            request.context_shrink = OpenApiUtilClient.array_to_string_with_specified_style(TeaCore.to_map(tmp_req.context), 'context', 'json')
        query = {}
        if not UtilClient.is_unset(request.context_shrink):
            query['context'] = request.context_shrink
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return dingtalkcrm__1__0_models.GetOfficialAccountContactInfoResponse().from_map(
            await self.do_roarequest_async('GetOfficialAccountContactInfo', 'crm_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/crm/officialAccounts/contacts/{user_id}', 'json', req, runtime)
        )
