# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.crm_1_0 import models as dingtalkcrm__1__0_models
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
        request: dingtalkcrm__1__0_models.GetOfficialAccountContactsRequest,
        headers: dingtalkcrm__1__0_models.GetOfficialAccountContactsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.GetOfficialAccountContactsResponse:
        UtilClient.validate_model(request)
        query = {}
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
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.GetOfficialAccountContactsResponse(),
            self.do_roarequest('GetOfficialAccountContacts', 'crm_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/crm/officialAccounts/contacts', 'json', req, runtime)
        )

    async def get_official_account_contacts_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.GetOfficialAccountContactsRequest,
        headers: dingtalkcrm__1__0_models.GetOfficialAccountContactsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.GetOfficialAccountContactsResponse:
        UtilClient.validate_model(request)
        query = {}
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
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.GetOfficialAccountContactsResponse(),
            await self.do_roarequest_async('GetOfficialAccountContacts', 'crm_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/crm/officialAccounts/contacts', 'json', req, runtime)
        )

    def service_window_message_batch_push(
        self,
        request: dingtalkcrm__1__0_models.ServiceWindowMessageBatchPushRequest,
    ) -> dingtalkcrm__1__0_models.ServiceWindowMessageBatchPushResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.ServiceWindowMessageBatchPushHeaders()
        return self.service_window_message_batch_push_with_options(request, headers, runtime)

    async def service_window_message_batch_push_async(
        self,
        request: dingtalkcrm__1__0_models.ServiceWindowMessageBatchPushRequest,
    ) -> dingtalkcrm__1__0_models.ServiceWindowMessageBatchPushResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.ServiceWindowMessageBatchPushHeaders()
        return await self.service_window_message_batch_push_with_options_async(request, headers, runtime)

    def service_window_message_batch_push_with_options(
        self,
        request: dingtalkcrm__1__0_models.ServiceWindowMessageBatchPushRequest,
        headers: dingtalkcrm__1__0_models.ServiceWindowMessageBatchPushHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.ServiceWindowMessageBatchPushResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.detail):
            body['detail'] = request.detail
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
        if not UtilClient.is_unset(request.ding_token_grant_type):
            body['dingTokenGrantType'] = request.ding_token_grant_type
        if not UtilClient.is_unset(request.ding_suite_key):
            body['dingSuiteKey'] = request.ding_suite_key
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.ServiceWindowMessageBatchPushResponse(),
            self.do_roarequest('ServiceWindowMessageBatchPush', 'crm_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/crm/messages/batchSend', 'json', req, runtime)
        )

    async def service_window_message_batch_push_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.ServiceWindowMessageBatchPushRequest,
        headers: dingtalkcrm__1__0_models.ServiceWindowMessageBatchPushHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.ServiceWindowMessageBatchPushResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.detail):
            body['detail'] = request.detail
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
        if not UtilClient.is_unset(request.ding_token_grant_type):
            body['dingTokenGrantType'] = request.ding_token_grant_type
        if not UtilClient.is_unset(request.ding_suite_key):
            body['dingSuiteKey'] = request.ding_suite_key
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.ServiceWindowMessageBatchPushResponse(),
            await self.do_roarequest_async('ServiceWindowMessageBatchPush', 'crm_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/crm/messages/batchSend', 'json', req, runtime)
        )

    def delete_crm_form_instance(
        self,
        instance_id: str,
        request: dingtalkcrm__1__0_models.DeleteCrmFormInstanceRequest,
    ) -> dingtalkcrm__1__0_models.DeleteCrmFormInstanceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.DeleteCrmFormInstanceHeaders()
        return self.delete_crm_form_instance_with_options(instance_id, request, headers, runtime)

    async def delete_crm_form_instance_async(
        self,
        instance_id: str,
        request: dingtalkcrm__1__0_models.DeleteCrmFormInstanceRequest,
    ) -> dingtalkcrm__1__0_models.DeleteCrmFormInstanceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.DeleteCrmFormInstanceHeaders()
        return await self.delete_crm_form_instance_with_options_async(instance_id, request, headers, runtime)

    def delete_crm_form_instance_with_options(
        self,
        instance_id: str,
        request: dingtalkcrm__1__0_models.DeleteCrmFormInstanceRequest,
        headers: dingtalkcrm__1__0_models.DeleteCrmFormInstanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.DeleteCrmFormInstanceResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.current_operator_user_id):
            query['currentOperatorUserId'] = request.current_operator_user_id
        if not UtilClient.is_unset(request.name):
            query['name'] = request.name
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.DeleteCrmFormInstanceResponse(),
            self.do_roarequest('DeleteCrmFormInstance', 'crm_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/crm/formInstances/{instance_id}', 'json', req, runtime)
        )

    async def delete_crm_form_instance_with_options_async(
        self,
        instance_id: str,
        request: dingtalkcrm__1__0_models.DeleteCrmFormInstanceRequest,
        headers: dingtalkcrm__1__0_models.DeleteCrmFormInstanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.DeleteCrmFormInstanceResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.current_operator_user_id):
            query['currentOperatorUserId'] = request.current_operator_user_id
        if not UtilClient.is_unset(request.name):
            query['name'] = request.name
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.DeleteCrmFormInstanceResponse(),
            await self.do_roarequest_async('DeleteCrmFormInstance', 'crm_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/crm/formInstances/{instance_id}', 'json', req, runtime)
        )

    def get_crm_role_permission(
        self,
        request: dingtalkcrm__1__0_models.GetCrmRolePermissionRequest,
    ) -> dingtalkcrm__1__0_models.GetCrmRolePermissionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.GetCrmRolePermissionHeaders()
        return self.get_crm_role_permission_with_options(request, headers, runtime)

    async def get_crm_role_permission_async(
        self,
        request: dingtalkcrm__1__0_models.GetCrmRolePermissionRequest,
    ) -> dingtalkcrm__1__0_models.GetCrmRolePermissionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.GetCrmRolePermissionHeaders()
        return await self.get_crm_role_permission_with_options_async(request, headers, runtime)

    def get_crm_role_permission_with_options(
        self,
        request: dingtalkcrm__1__0_models.GetCrmRolePermissionRequest,
        headers: dingtalkcrm__1__0_models.GetCrmRolePermissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.GetCrmRolePermissionResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.form_code):
            query['formCode'] = request.form_code
        if not UtilClient.is_unset(request.biz_type):
            query['bizType'] = request.biz_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.GetCrmRolePermissionResponse(),
            self.do_roarequest('GetCrmRolePermission', 'crm_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/crm/permissions', 'json', req, runtime)
        )

    async def get_crm_role_permission_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.GetCrmRolePermissionRequest,
        headers: dingtalkcrm__1__0_models.GetCrmRolePermissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.GetCrmRolePermissionResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.form_code):
            query['formCode'] = request.form_code
        if not UtilClient.is_unset(request.biz_type):
            query['bizType'] = request.biz_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.GetCrmRolePermissionResponse(),
            await self.do_roarequest_async('GetCrmRolePermission', 'crm_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/crm/permissions', 'json', req, runtime)
        )

    def batch_send_official_account_otomessage(
        self,
        request: dingtalkcrm__1__0_models.BatchSendOfficialAccountOTOMessageRequest,
    ) -> dingtalkcrm__1__0_models.BatchSendOfficialAccountOTOMessageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.BatchSendOfficialAccountOTOMessageHeaders()
        return self.batch_send_official_account_otomessage_with_options(request, headers, runtime)

    async def batch_send_official_account_otomessage_async(
        self,
        request: dingtalkcrm__1__0_models.BatchSendOfficialAccountOTOMessageRequest,
    ) -> dingtalkcrm__1__0_models.BatchSendOfficialAccountOTOMessageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.BatchSendOfficialAccountOTOMessageHeaders()
        return await self.batch_send_official_account_otomessage_with_options_async(request, headers, runtime)

    def batch_send_official_account_otomessage_with_options(
        self,
        request: dingtalkcrm__1__0_models.BatchSendOfficialAccountOTOMessageRequest,
        headers: dingtalkcrm__1__0_models.BatchSendOfficialAccountOTOMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.BatchSendOfficialAccountOTOMessageResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.detail):
            body['detail'] = request.detail
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.account_id):
            body['accountId'] = request.account_id
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
        if not UtilClient.is_unset(request.ding_token_grant_type):
            body['dingTokenGrantType'] = request.ding_token_grant_type
        if not UtilClient.is_unset(request.ding_suite_key):
            body['dingSuiteKey'] = request.ding_suite_key
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.BatchSendOfficialAccountOTOMessageResponse(),
            self.do_roarequest('BatchSendOfficialAccountOTOMessage', 'crm_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/crm/officialAccounts/oToMessages/batchSend', 'json', req, runtime)
        )

    async def batch_send_official_account_otomessage_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.BatchSendOfficialAccountOTOMessageRequest,
        headers: dingtalkcrm__1__0_models.BatchSendOfficialAccountOTOMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.BatchSendOfficialAccountOTOMessageResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.detail):
            body['detail'] = request.detail
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.account_id):
            body['accountId'] = request.account_id
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
        if not UtilClient.is_unset(request.ding_token_grant_type):
            body['dingTokenGrantType'] = request.ding_token_grant_type
        if not UtilClient.is_unset(request.ding_suite_key):
            body['dingSuiteKey'] = request.ding_suite_key
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.BatchSendOfficialAccountOTOMessageResponse(),
            await self.do_roarequest_async('BatchSendOfficialAccountOTOMessage', 'crm_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/crm/officialAccounts/oToMessages/batchSend', 'json', req, runtime)
        )

    def get_official_account_contact_info(
        self,
        user_id: str,
    ) -> dingtalkcrm__1__0_models.GetOfficialAccountContactInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.GetOfficialAccountContactInfoHeaders()
        return self.get_official_account_contact_info_with_options(user_id, headers, runtime)

    async def get_official_account_contact_info_async(
        self,
        user_id: str,
    ) -> dingtalkcrm__1__0_models.GetOfficialAccountContactInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.GetOfficialAccountContactInfoHeaders()
        return await self.get_official_account_contact_info_with_options_async(user_id, headers, runtime)

    def get_official_account_contact_info_with_options(
        self,
        user_id: str,
        headers: dingtalkcrm__1__0_models.GetOfficialAccountContactInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.GetOfficialAccountContactInfoResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.GetOfficialAccountContactInfoResponse(),
            self.do_roarequest('GetOfficialAccountContactInfo', 'crm_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/crm/officialAccounts/contacts/{user_id}', 'json', req, runtime)
        )

    async def get_official_account_contact_info_with_options_async(
        self,
        user_id: str,
        headers: dingtalkcrm__1__0_models.GetOfficialAccountContactInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.GetOfficialAccountContactInfoResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.GetOfficialAccountContactInfoResponse(),
            await self.do_roarequest_async('GetOfficialAccountContactInfo', 'crm_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/crm/officialAccounts/contacts/{user_id}', 'json', req, runtime)
        )

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
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.QueryAllCustomerResponse(),
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
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.QueryAllCustomerResponse(),
            await self.do_roarequest_async('QueryAllCustomer', 'crm_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/crm/customerInstances', 'json', req, runtime)
        )

    def update_relation_meta_field(
        self,
        request: dingtalkcrm__1__0_models.UpdateRelationMetaFieldRequest,
    ) -> dingtalkcrm__1__0_models.UpdateRelationMetaFieldResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.UpdateRelationMetaFieldHeaders()
        return self.update_relation_meta_field_with_options(request, headers, runtime)

    async def update_relation_meta_field_async(
        self,
        request: dingtalkcrm__1__0_models.UpdateRelationMetaFieldRequest,
    ) -> dingtalkcrm__1__0_models.UpdateRelationMetaFieldResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.UpdateRelationMetaFieldHeaders()
        return await self.update_relation_meta_field_with_options_async(request, headers, runtime)

    def update_relation_meta_field_with_options(
        self,
        request: dingtalkcrm__1__0_models.UpdateRelationMetaFieldRequest,
        headers: dingtalkcrm__1__0_models.UpdateRelationMetaFieldHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.UpdateRelationMetaFieldResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.tenant):
            body['tenant'] = request.tenant
        if not UtilClient.is_unset(request.operator_user_id):
            body['operatorUserId'] = request.operator_user_id
        if not UtilClient.is_unset(request.relation_type):
            body['relationType'] = request.relation_type
        if not UtilClient.is_unset(request.field_dtolist):
            body['fieldDTOList'] = request.field_dtolist
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.UpdateRelationMetaFieldResponse(),
            self.do_roarequest('UpdateRelationMetaField', 'crm_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/crm/relations/metas/fields', 'json', req, runtime)
        )

    async def update_relation_meta_field_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.UpdateRelationMetaFieldRequest,
        headers: dingtalkcrm__1__0_models.UpdateRelationMetaFieldHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.UpdateRelationMetaFieldResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.tenant):
            body['tenant'] = request.tenant
        if not UtilClient.is_unset(request.operator_user_id):
            body['operatorUserId'] = request.operator_user_id
        if not UtilClient.is_unset(request.relation_type):
            body['relationType'] = request.relation_type
        if not UtilClient.is_unset(request.field_dtolist):
            body['fieldDTOList'] = request.field_dtolist
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.UpdateRelationMetaFieldResponse(),
            await self.do_roarequest_async('UpdateRelationMetaField', 'crm_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/crm/relations/metas/fields', 'json', req, runtime)
        )

    def send_official_account_otomessage(
        self,
        request: dingtalkcrm__1__0_models.SendOfficialAccountOTOMessageRequest,
    ) -> dingtalkcrm__1__0_models.SendOfficialAccountOTOMessageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.SendOfficialAccountOTOMessageHeaders()
        return self.send_official_account_otomessage_with_options(request, headers, runtime)

    async def send_official_account_otomessage_async(
        self,
        request: dingtalkcrm__1__0_models.SendOfficialAccountOTOMessageRequest,
    ) -> dingtalkcrm__1__0_models.SendOfficialAccountOTOMessageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.SendOfficialAccountOTOMessageHeaders()
        return await self.send_official_account_otomessage_with_options_async(request, headers, runtime)

    def send_official_account_otomessage_with_options(
        self,
        request: dingtalkcrm__1__0_models.SendOfficialAccountOTOMessageRequest,
        headers: dingtalkcrm__1__0_models.SendOfficialAccountOTOMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.SendOfficialAccountOTOMessageResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.detail):
            body['detail'] = request.detail
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.ding_token_grant_type):
            body['dingTokenGrantType'] = request.ding_token_grant_type
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
        if not UtilClient.is_unset(request.ding_suite_key):
            body['dingSuiteKey'] = request.ding_suite_key
        if not UtilClient.is_unset(request.account_id):
            body['accountId'] = request.account_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.SendOfficialAccountOTOMessageResponse(),
            self.do_roarequest('SendOfficialAccountOTOMessage', 'crm_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/crm/officialAccounts/oToMessages/send', 'json', req, runtime)
        )

    async def send_official_account_otomessage_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.SendOfficialAccountOTOMessageRequest,
        headers: dingtalkcrm__1__0_models.SendOfficialAccountOTOMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.SendOfficialAccountOTOMessageResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.detail):
            body['detail'] = request.detail
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.ding_token_grant_type):
            body['dingTokenGrantType'] = request.ding_token_grant_type
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
        if not UtilClient.is_unset(request.ding_suite_key):
            body['dingSuiteKey'] = request.ding_suite_key
        if not UtilClient.is_unset(request.account_id):
            body['accountId'] = request.account_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.SendOfficialAccountOTOMessageResponse(),
            await self.do_roarequest_async('SendOfficialAccountOTOMessage', 'crm_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/crm/officialAccounts/oToMessages/send', 'json', req, runtime)
        )

    def get_official_account_otomessage_result(
        self,
        request: dingtalkcrm__1__0_models.GetOfficialAccountOTOMessageResultRequest,
    ) -> dingtalkcrm__1__0_models.GetOfficialAccountOTOMessageResultResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.GetOfficialAccountOTOMessageResultHeaders()
        return self.get_official_account_otomessage_result_with_options(request, headers, runtime)

    async def get_official_account_otomessage_result_async(
        self,
        request: dingtalkcrm__1__0_models.GetOfficialAccountOTOMessageResultRequest,
    ) -> dingtalkcrm__1__0_models.GetOfficialAccountOTOMessageResultResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.GetOfficialAccountOTOMessageResultHeaders()
        return await self.get_official_account_otomessage_result_with_options_async(request, headers, runtime)

    def get_official_account_otomessage_result_with_options(
        self,
        request: dingtalkcrm__1__0_models.GetOfficialAccountOTOMessageResultRequest,
        headers: dingtalkcrm__1__0_models.GetOfficialAccountOTOMessageResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.GetOfficialAccountOTOMessageResultResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.open_push_id):
            query['openPushId'] = request.open_push_id
        if not UtilClient.is_unset(request.account_id):
            query['accountId'] = request.account_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.GetOfficialAccountOTOMessageResultResponse(),
            self.do_roarequest('GetOfficialAccountOTOMessageResult', 'crm_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/crm/officialAccounts/oToMessages/sendResults', 'json', req, runtime)
        )

    async def get_official_account_otomessage_result_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.GetOfficialAccountOTOMessageResultRequest,
        headers: dingtalkcrm__1__0_models.GetOfficialAccountOTOMessageResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.GetOfficialAccountOTOMessageResultResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.open_push_id):
            query['openPushId'] = request.open_push_id
        if not UtilClient.is_unset(request.account_id):
            query['accountId'] = request.account_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.GetOfficialAccountOTOMessageResultResponse(),
            await self.do_roarequest_async('GetOfficialAccountOTOMessageResult', 'crm_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/crm/officialAccounts/oToMessages/sendResults', 'json', req, runtime)
        )

    def describe_relation_meta(
        self,
        request: dingtalkcrm__1__0_models.DescribeRelationMetaRequest,
    ) -> dingtalkcrm__1__0_models.DescribeRelationMetaResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.DescribeRelationMetaHeaders()
        return self.describe_relation_meta_with_options(request, headers, runtime)

    async def describe_relation_meta_async(
        self,
        request: dingtalkcrm__1__0_models.DescribeRelationMetaRequest,
    ) -> dingtalkcrm__1__0_models.DescribeRelationMetaResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.DescribeRelationMetaHeaders()
        return await self.describe_relation_meta_with_options_async(request, headers, runtime)

    def describe_relation_meta_with_options(
        self,
        request: dingtalkcrm__1__0_models.DescribeRelationMetaRequest,
        headers: dingtalkcrm__1__0_models.DescribeRelationMetaHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.DescribeRelationMetaResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.tenant):
            body['tenant'] = request.tenant
        if not UtilClient.is_unset(request.operator_user_id):
            body['operatorUserId'] = request.operator_user_id
        if not UtilClient.is_unset(request.relation_types):
            body['relationTypes'] = request.relation_types
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.DescribeRelationMetaResponse(),
            self.do_roarequest('DescribeRelationMeta', 'crm_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/crm/relations/metas/query', 'json', req, runtime)
        )

    async def describe_relation_meta_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.DescribeRelationMetaRequest,
        headers: dingtalkcrm__1__0_models.DescribeRelationMetaHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.DescribeRelationMetaResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.tenant):
            body['tenant'] = request.tenant
        if not UtilClient.is_unset(request.operator_user_id):
            body['operatorUserId'] = request.operator_user_id
        if not UtilClient.is_unset(request.relation_types):
            body['relationTypes'] = request.relation_types
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.DescribeRelationMetaResponse(),
            await self.do_roarequest_async('DescribeRelationMeta', 'crm_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/crm/relations/metas/query', 'json', req, runtime)
        )

    def add_crm_personal_customer(
        self,
        request: dingtalkcrm__1__0_models.AddCrmPersonalCustomerRequest,
    ) -> dingtalkcrm__1__0_models.AddCrmPersonalCustomerResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.AddCrmPersonalCustomerHeaders()
        return self.add_crm_personal_customer_with_options(request, headers, runtime)

    async def add_crm_personal_customer_async(
        self,
        request: dingtalkcrm__1__0_models.AddCrmPersonalCustomerRequest,
    ) -> dingtalkcrm__1__0_models.AddCrmPersonalCustomerResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.AddCrmPersonalCustomerHeaders()
        return await self.add_crm_personal_customer_with_options_async(request, headers, runtime)

    def add_crm_personal_customer_with_options(
        self,
        request: dingtalkcrm__1__0_models.AddCrmPersonalCustomerRequest,
        headers: dingtalkcrm__1__0_models.AddCrmPersonalCustomerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.AddCrmPersonalCustomerResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.creator_user_id):
            body['creatorUserId'] = request.creator_user_id
        if not UtilClient.is_unset(request.creator_nick):
            body['creatorNick'] = request.creator_nick
        if not UtilClient.is_unset(request.data):
            body['data'] = request.data
        if not UtilClient.is_unset(request.extend_data):
            body['extendData'] = request.extend_data
        if not UtilClient.is_unset(request.permission):
            body['permission'] = request.permission
        if not UtilClient.is_unset(request.skip_duplicate_check):
            body['skipDuplicateCheck'] = request.skip_duplicate_check
        if not UtilClient.is_unset(request.action):
            body['action'] = request.action
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.AddCrmPersonalCustomerResponse(),
            self.do_roarequest('AddCrmPersonalCustomer', 'crm_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/crm/personalCustomers', 'json', req, runtime)
        )

    async def add_crm_personal_customer_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.AddCrmPersonalCustomerRequest,
        headers: dingtalkcrm__1__0_models.AddCrmPersonalCustomerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.AddCrmPersonalCustomerResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.creator_user_id):
            body['creatorUserId'] = request.creator_user_id
        if not UtilClient.is_unset(request.creator_nick):
            body['creatorNick'] = request.creator_nick
        if not UtilClient.is_unset(request.data):
            body['data'] = request.data
        if not UtilClient.is_unset(request.extend_data):
            body['extendData'] = request.extend_data
        if not UtilClient.is_unset(request.permission):
            body['permission'] = request.permission
        if not UtilClient.is_unset(request.skip_duplicate_check):
            body['skipDuplicateCheck'] = request.skip_duplicate_check
        if not UtilClient.is_unset(request.action):
            body['action'] = request.action
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.AddCrmPersonalCustomerResponse(),
            await self.do_roarequest_async('AddCrmPersonalCustomer', 'crm_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/crm/personalCustomers', 'json', req, runtime)
        )

    def recall_official_account_otomessage(
        self,
        request: dingtalkcrm__1__0_models.RecallOfficialAccountOTOMessageRequest,
    ) -> dingtalkcrm__1__0_models.RecallOfficialAccountOTOMessageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.RecallOfficialAccountOTOMessageHeaders()
        return self.recall_official_account_otomessage_with_options(request, headers, runtime)

    async def recall_official_account_otomessage_async(
        self,
        request: dingtalkcrm__1__0_models.RecallOfficialAccountOTOMessageRequest,
    ) -> dingtalkcrm__1__0_models.RecallOfficialAccountOTOMessageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.RecallOfficialAccountOTOMessageHeaders()
        return await self.recall_official_account_otomessage_with_options_async(request, headers, runtime)

    def recall_official_account_otomessage_with_options(
        self,
        request: dingtalkcrm__1__0_models.RecallOfficialAccountOTOMessageRequest,
        headers: dingtalkcrm__1__0_models.RecallOfficialAccountOTOMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.RecallOfficialAccountOTOMessageResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.ding_suite_key):
            body['dingSuiteKey'] = request.ding_suite_key
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
        if not UtilClient.is_unset(request.ding_token_grant_type):
            body['dingTokenGrantType'] = request.ding_token_grant_type
        if not UtilClient.is_unset(request.account_id):
            body['accountId'] = request.account_id
        if not UtilClient.is_unset(request.open_push_id):
            body['openPushId'] = request.open_push_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.RecallOfficialAccountOTOMessageResponse(),
            self.do_roarequest('RecallOfficialAccountOTOMessage', 'crm_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/crm/officialAccounts/oToMessages/recall', 'json', req, runtime)
        )

    async def recall_official_account_otomessage_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.RecallOfficialAccountOTOMessageRequest,
        headers: dingtalkcrm__1__0_models.RecallOfficialAccountOTOMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.RecallOfficialAccountOTOMessageResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.ding_suite_key):
            body['dingSuiteKey'] = request.ding_suite_key
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
        if not UtilClient.is_unset(request.ding_token_grant_type):
            body['dingTokenGrantType'] = request.ding_token_grant_type
        if not UtilClient.is_unset(request.account_id):
            body['accountId'] = request.account_id
        if not UtilClient.is_unset(request.open_push_id):
            body['openPushId'] = request.open_push_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.RecallOfficialAccountOTOMessageResponse(),
            await self.do_roarequest_async('RecallOfficialAccountOTOMessage', 'crm_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/crm/officialAccounts/oToMessages/recall', 'json', req, runtime)
        )

    def describe_crm_personal_customer_object_meta(self) -> dingtalkcrm__1__0_models.DescribeCrmPersonalCustomerObjectMetaResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.DescribeCrmPersonalCustomerObjectMetaHeaders()
        return self.describe_crm_personal_customer_object_meta_with_options(headers, runtime)

    async def describe_crm_personal_customer_object_meta_async(self) -> dingtalkcrm__1__0_models.DescribeCrmPersonalCustomerObjectMetaResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.DescribeCrmPersonalCustomerObjectMetaHeaders()
        return await self.describe_crm_personal_customer_object_meta_with_options_async(headers, runtime)

    def describe_crm_personal_customer_object_meta_with_options(
        self,
        headers: dingtalkcrm__1__0_models.DescribeCrmPersonalCustomerObjectMetaHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.DescribeCrmPersonalCustomerObjectMetaResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.DescribeCrmPersonalCustomerObjectMetaResponse(),
            self.do_roarequest('DescribeCrmPersonalCustomerObjectMeta', 'crm_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/crm/personalCustomers/objectMeta', 'json', req, runtime)
        )

    async def describe_crm_personal_customer_object_meta_with_options_async(
        self,
        headers: dingtalkcrm__1__0_models.DescribeCrmPersonalCustomerObjectMetaHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.DescribeCrmPersonalCustomerObjectMetaResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.DescribeCrmPersonalCustomerObjectMetaResponse(),
            await self.do_roarequest_async('DescribeCrmPersonalCustomerObjectMeta', 'crm_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/crm/personalCustomers/objectMeta', 'json', req, runtime)
        )

    def delete_crm_personal_customer(
        self,
        data_id: str,
        request: dingtalkcrm__1__0_models.DeleteCrmPersonalCustomerRequest,
    ) -> dingtalkcrm__1__0_models.DeleteCrmPersonalCustomerResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.DeleteCrmPersonalCustomerHeaders()
        return self.delete_crm_personal_customer_with_options(data_id, request, headers, runtime)

    async def delete_crm_personal_customer_async(
        self,
        data_id: str,
        request: dingtalkcrm__1__0_models.DeleteCrmPersonalCustomerRequest,
    ) -> dingtalkcrm__1__0_models.DeleteCrmPersonalCustomerResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.DeleteCrmPersonalCustomerHeaders()
        return await self.delete_crm_personal_customer_with_options_async(data_id, request, headers, runtime)

    def delete_crm_personal_customer_with_options(
        self,
        data_id: str,
        request: dingtalkcrm__1__0_models.DeleteCrmPersonalCustomerRequest,
        headers: dingtalkcrm__1__0_models.DeleteCrmPersonalCustomerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.DeleteCrmPersonalCustomerResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.current_operator_user_id):
            query['currentOperatorUserId'] = request.current_operator_user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.DeleteCrmPersonalCustomerResponse(),
            self.do_roarequest('DeleteCrmPersonalCustomer', 'crm_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/crm/personalCustomers/{data_id}', 'json', req, runtime)
        )

    async def delete_crm_personal_customer_with_options_async(
        self,
        data_id: str,
        request: dingtalkcrm__1__0_models.DeleteCrmPersonalCustomerRequest,
        headers: dingtalkcrm__1__0_models.DeleteCrmPersonalCustomerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.DeleteCrmPersonalCustomerResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.current_operator_user_id):
            query['currentOperatorUserId'] = request.current_operator_user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.DeleteCrmPersonalCustomerResponse(),
            await self.do_roarequest_async('DeleteCrmPersonalCustomer', 'crm_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/crm/personalCustomers/{data_id}', 'json', req, runtime)
        )

    def abandon_customer(
        self,
        request: dingtalkcrm__1__0_models.AbandonCustomerRequest,
    ) -> dingtalkcrm__1__0_models.AbandonCustomerResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.AbandonCustomerHeaders()
        return self.abandon_customer_with_options(request, headers, runtime)

    async def abandon_customer_async(
        self,
        request: dingtalkcrm__1__0_models.AbandonCustomerRequest,
    ) -> dingtalkcrm__1__0_models.AbandonCustomerResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.AbandonCustomerHeaders()
        return await self.abandon_customer_with_options_async(request, headers, runtime)

    def abandon_customer_with_options(
        self,
        request: dingtalkcrm__1__0_models.AbandonCustomerRequest,
        headers: dingtalkcrm__1__0_models.AbandonCustomerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.AbandonCustomerResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.operator_user_id):
            body['operatorUserId'] = request.operator_user_id
        if not UtilClient.is_unset(request.instance_id_list):
            body['instanceIdList'] = request.instance_id_list
        if not UtilClient.is_unset(request.custom_track_desc):
            body['customTrackDesc'] = request.custom_track_desc
        if not UtilClient.is_unset(request.opt_type):
            body['optType'] = request.opt_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.AbandonCustomerResponse(),
            self.do_roarequest('AbandonCustomer', 'crm_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/crm/customers/abandon', 'json', req, runtime)
        )

    async def abandon_customer_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.AbandonCustomerRequest,
        headers: dingtalkcrm__1__0_models.AbandonCustomerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.AbandonCustomerResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.operator_user_id):
            body['operatorUserId'] = request.operator_user_id
        if not UtilClient.is_unset(request.instance_id_list):
            body['instanceIdList'] = request.instance_id_list
        if not UtilClient.is_unset(request.custom_track_desc):
            body['customTrackDesc'] = request.custom_track_desc
        if not UtilClient.is_unset(request.opt_type):
            body['optType'] = request.opt_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.AbandonCustomerResponse(),
            await self.do_roarequest_async('AbandonCustomer', 'crm_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/crm/customers/abandon', 'json', req, runtime)
        )

    def send_official_account_snsmessage(
        self,
        request: dingtalkcrm__1__0_models.SendOfficialAccountSNSMessageRequest,
    ) -> dingtalkcrm__1__0_models.SendOfficialAccountSNSMessageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.SendOfficialAccountSNSMessageHeaders()
        return self.send_official_account_snsmessage_with_options(request, headers, runtime)

    async def send_official_account_snsmessage_async(
        self,
        request: dingtalkcrm__1__0_models.SendOfficialAccountSNSMessageRequest,
    ) -> dingtalkcrm__1__0_models.SendOfficialAccountSNSMessageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.SendOfficialAccountSNSMessageHeaders()
        return await self.send_official_account_snsmessage_with_options_async(request, headers, runtime)

    def send_official_account_snsmessage_with_options(
        self,
        request: dingtalkcrm__1__0_models.SendOfficialAccountSNSMessageRequest,
        headers: dingtalkcrm__1__0_models.SendOfficialAccountSNSMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.SendOfficialAccountSNSMessageResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.detail):
            body['detail'] = request.detail
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.ding_token_grant_type):
            body['dingTokenGrantType'] = request.ding_token_grant_type
        if not UtilClient.is_unset(request.ding_client_id):
            body['dingClientId'] = request.ding_client_id
        if not UtilClient.is_unset(request.binding_token):
            body['bindingToken'] = request.binding_token
        if not UtilClient.is_unset(request.ding_uid):
            body['dingUid'] = request.ding_uid
        if not UtilClient.is_unset(request.ding_open_app_org_id):
            body['dingOpenAppOrgId'] = request.ding_open_app_org_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.SendOfficialAccountSNSMessageResponse(),
            self.do_roarequest('SendOfficialAccountSNSMessage', 'crm_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/crm/officialAccounts/snsMessages/send', 'json', req, runtime)
        )

    async def send_official_account_snsmessage_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.SendOfficialAccountSNSMessageRequest,
        headers: dingtalkcrm__1__0_models.SendOfficialAccountSNSMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.SendOfficialAccountSNSMessageResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.detail):
            body['detail'] = request.detail
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.ding_token_grant_type):
            body['dingTokenGrantType'] = request.ding_token_grant_type
        if not UtilClient.is_unset(request.ding_client_id):
            body['dingClientId'] = request.ding_client_id
        if not UtilClient.is_unset(request.binding_token):
            body['bindingToken'] = request.binding_token
        if not UtilClient.is_unset(request.ding_uid):
            body['dingUid'] = request.ding_uid
        if not UtilClient.is_unset(request.ding_open_app_org_id):
            body['dingOpenAppOrgId'] = request.ding_open_app_org_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.SendOfficialAccountSNSMessageResponse(),
            await self.do_roarequest_async('SendOfficialAccountSNSMessage', 'crm_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/crm/officialAccounts/snsMessages/send', 'json', req, runtime)
        )

    def update_crm_personal_customer(
        self,
        request: dingtalkcrm__1__0_models.UpdateCrmPersonalCustomerRequest,
    ) -> dingtalkcrm__1__0_models.UpdateCrmPersonalCustomerResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.UpdateCrmPersonalCustomerHeaders()
        return self.update_crm_personal_customer_with_options(request, headers, runtime)

    async def update_crm_personal_customer_async(
        self,
        request: dingtalkcrm__1__0_models.UpdateCrmPersonalCustomerRequest,
    ) -> dingtalkcrm__1__0_models.UpdateCrmPersonalCustomerResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.UpdateCrmPersonalCustomerHeaders()
        return await self.update_crm_personal_customer_with_options_async(request, headers, runtime)

    def update_crm_personal_customer_with_options(
        self,
        request: dingtalkcrm__1__0_models.UpdateCrmPersonalCustomerRequest,
        headers: dingtalkcrm__1__0_models.UpdateCrmPersonalCustomerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.UpdateCrmPersonalCustomerResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.instance_id):
            body['instanceId'] = request.instance_id
        if not UtilClient.is_unset(request.modifier_user_id):
            body['modifierUserId'] = request.modifier_user_id
        if not UtilClient.is_unset(request.modifier_nick):
            body['modifierNick'] = request.modifier_nick
        if not UtilClient.is_unset(request.data):
            body['data'] = request.data
        if not UtilClient.is_unset(request.extend_data):
            body['extendData'] = request.extend_data
        if not UtilClient.is_unset(request.permission):
            body['permission'] = request.permission
        if not UtilClient.is_unset(request.skip_duplicate_check):
            body['skipDuplicateCheck'] = request.skip_duplicate_check
        if not UtilClient.is_unset(request.action):
            body['action'] = request.action
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.UpdateCrmPersonalCustomerResponse(),
            self.do_roarequest('UpdateCrmPersonalCustomer', 'crm_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/crm/personalCustomers', 'json', req, runtime)
        )

    async def update_crm_personal_customer_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.UpdateCrmPersonalCustomerRequest,
        headers: dingtalkcrm__1__0_models.UpdateCrmPersonalCustomerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.UpdateCrmPersonalCustomerResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.instance_id):
            body['instanceId'] = request.instance_id
        if not UtilClient.is_unset(request.modifier_user_id):
            body['modifierUserId'] = request.modifier_user_id
        if not UtilClient.is_unset(request.modifier_nick):
            body['modifierNick'] = request.modifier_nick
        if not UtilClient.is_unset(request.data):
            body['data'] = request.data
        if not UtilClient.is_unset(request.extend_data):
            body['extendData'] = request.extend_data
        if not UtilClient.is_unset(request.permission):
            body['permission'] = request.permission
        if not UtilClient.is_unset(request.skip_duplicate_check):
            body['skipDuplicateCheck'] = request.skip_duplicate_check
        if not UtilClient.is_unset(request.action):
            body['action'] = request.action
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.UpdateCrmPersonalCustomerResponse(),
            await self.do_roarequest_async('UpdateCrmPersonalCustomer', 'crm_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/crm/personalCustomers', 'json', req, runtime)
        )

    def query_crm_personal_customer(
        self,
        request: dingtalkcrm__1__0_models.QueryCrmPersonalCustomerRequest,
    ) -> dingtalkcrm__1__0_models.QueryCrmPersonalCustomerResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.QueryCrmPersonalCustomerHeaders()
        return self.query_crm_personal_customer_with_options(request, headers, runtime)

    async def query_crm_personal_customer_async(
        self,
        request: dingtalkcrm__1__0_models.QueryCrmPersonalCustomerRequest,
    ) -> dingtalkcrm__1__0_models.QueryCrmPersonalCustomerResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.QueryCrmPersonalCustomerHeaders()
        return await self.query_crm_personal_customer_with_options_async(request, headers, runtime)

    def query_crm_personal_customer_with_options(
        self,
        request: dingtalkcrm__1__0_models.QueryCrmPersonalCustomerRequest,
        headers: dingtalkcrm__1__0_models.QueryCrmPersonalCustomerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.QueryCrmPersonalCustomerResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.current_operator_user_id):
            query['currentOperatorUserId'] = request.current_operator_user_id
        if not UtilClient.is_unset(request.relation_type):
            query['relationType'] = request.relation_type
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.query_dsl):
            query['queryDsl'] = request.query_dsl
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.QueryCrmPersonalCustomerResponse(),
            self.do_roarequest('QueryCrmPersonalCustomer', 'crm_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/crm/personalCustomers', 'json', req, runtime)
        )

    async def query_crm_personal_customer_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.QueryCrmPersonalCustomerRequest,
        headers: dingtalkcrm__1__0_models.QueryCrmPersonalCustomerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.QueryCrmPersonalCustomerResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.current_operator_user_id):
            query['currentOperatorUserId'] = request.current_operator_user_id
        if not UtilClient.is_unset(request.relation_type):
            query['relationType'] = request.relation_type
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.query_dsl):
            query['queryDsl'] = request.query_dsl
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.QueryCrmPersonalCustomerResponse(),
            await self.do_roarequest_async('QueryCrmPersonalCustomer', 'crm_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/crm/personalCustomers', 'json', req, runtime)
        )

    def list_crm_personal_customers(
        self,
        request: dingtalkcrm__1__0_models.ListCrmPersonalCustomersRequest,
    ) -> dingtalkcrm__1__0_models.ListCrmPersonalCustomersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.ListCrmPersonalCustomersHeaders()
        return self.list_crm_personal_customers_with_options(request, headers, runtime)

    async def list_crm_personal_customers_async(
        self,
        request: dingtalkcrm__1__0_models.ListCrmPersonalCustomersRequest,
    ) -> dingtalkcrm__1__0_models.ListCrmPersonalCustomersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.ListCrmPersonalCustomersHeaders()
        return await self.list_crm_personal_customers_with_options_async(request, headers, runtime)

    def list_crm_personal_customers_with_options(
        self,
        request: dingtalkcrm__1__0_models.ListCrmPersonalCustomersRequest,
        headers: dingtalkcrm__1__0_models.ListCrmPersonalCustomersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.ListCrmPersonalCustomersResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.current_operator_user_id):
            query['currentOperatorUserId'] = request.current_operator_user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=request.body
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.ListCrmPersonalCustomersResponse(),
            self.do_roarequest('ListCrmPersonalCustomers', 'crm_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/crm/personalCustomers/batchQuery', 'json', req, runtime)
        )

    async def list_crm_personal_customers_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.ListCrmPersonalCustomersRequest,
        headers: dingtalkcrm__1__0_models.ListCrmPersonalCustomersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.ListCrmPersonalCustomersResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.current_operator_user_id):
            query['currentOperatorUserId'] = request.current_operator_user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=request.body
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.ListCrmPersonalCustomersResponse(),
            await self.do_roarequest_async('ListCrmPersonalCustomers', 'crm_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/crm/personalCustomers/batchQuery', 'json', req, runtime)
        )

    def create_customer(
        self,
        request: dingtalkcrm__1__0_models.CreateCustomerRequest,
    ) -> dingtalkcrm__1__0_models.CreateCustomerResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.CreateCustomerHeaders()
        return self.create_customer_with_options(request, headers, runtime)

    async def create_customer_async(
        self,
        request: dingtalkcrm__1__0_models.CreateCustomerRequest,
    ) -> dingtalkcrm__1__0_models.CreateCustomerResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.CreateCustomerHeaders()
        return await self.create_customer_with_options_async(request, headers, runtime)

    def create_customer_with_options(
        self,
        request: dingtalkcrm__1__0_models.CreateCustomerRequest,
        headers: dingtalkcrm__1__0_models.CreateCustomerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.CreateCustomerResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.object_type):
            body['objectType'] = request.object_type
        if not UtilClient.is_unset(request.instance_id):
            body['instanceId'] = request.instance_id
        if not UtilClient.is_unset(request.creator_user_id):
            body['creatorUserId'] = request.creator_user_id
        if not UtilClient.is_unset(request.data):
            body['data'] = request.data
        if not UtilClient.is_unset(request.extend_data):
            body['extendData'] = request.extend_data
        if not UtilClient.is_unset(request.contacts):
            body['contacts'] = request.contacts
        if not UtilClient.is_unset(request.permission):
            body['permission'] = request.permission
        if not UtilClient.is_unset(request.save_option):
            body['saveOption'] = request.save_option
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.CreateCustomerResponse(),
            self.do_roarequest('CreateCustomer', 'crm_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/crm/customers', 'json', req, runtime)
        )

    async def create_customer_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.CreateCustomerRequest,
        headers: dingtalkcrm__1__0_models.CreateCustomerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.CreateCustomerResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.object_type):
            body['objectType'] = request.object_type
        if not UtilClient.is_unset(request.instance_id):
            body['instanceId'] = request.instance_id
        if not UtilClient.is_unset(request.creator_user_id):
            body['creatorUserId'] = request.creator_user_id
        if not UtilClient.is_unset(request.data):
            body['data'] = request.data
        if not UtilClient.is_unset(request.extend_data):
            body['extendData'] = request.extend_data
        if not UtilClient.is_unset(request.contacts):
            body['contacts'] = request.contacts
        if not UtilClient.is_unset(request.permission):
            body['permission'] = request.permission
        if not UtilClient.is_unset(request.save_option):
            body['saveOption'] = request.save_option
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.CreateCustomerResponse(),
            await self.do_roarequest_async('CreateCustomer', 'crm_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/crm/customers', 'json', req, runtime)
        )

    def query_all_tracks(
        self,
        request: dingtalkcrm__1__0_models.QueryAllTracksRequest,
    ) -> dingtalkcrm__1__0_models.QueryAllTracksResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.QueryAllTracksHeaders()
        return self.query_all_tracks_with_options(request, headers, runtime)

    async def query_all_tracks_async(
        self,
        request: dingtalkcrm__1__0_models.QueryAllTracksRequest,
    ) -> dingtalkcrm__1__0_models.QueryAllTracksResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.QueryAllTracksHeaders()
        return await self.query_all_tracks_with_options_async(request, headers, runtime)

    def query_all_tracks_with_options(
        self,
        request: dingtalkcrm__1__0_models.QueryAllTracksRequest,
        headers: dingtalkcrm__1__0_models.QueryAllTracksHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.QueryAllTracksResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.order):
            query['order'] = request.order
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.QueryAllTracksResponse(),
            self.do_roarequest('QueryAllTracks', 'crm_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/crm/customers/tracks', 'json', req, runtime)
        )

    async def query_all_tracks_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.QueryAllTracksRequest,
        headers: dingtalkcrm__1__0_models.QueryAllTracksHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.QueryAllTracksResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.order):
            query['order'] = request.order
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.QueryAllTracksResponse(),
            await self.do_roarequest_async('QueryAllTracks', 'crm_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/crm/customers/tracks', 'json', req, runtime)
        )
