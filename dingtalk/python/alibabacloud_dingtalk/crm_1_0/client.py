# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_gateway_spi.client import Client as SPIClient
from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.crm_1_0 import models as dingtalkcrm__1__0_models
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

    def abandon_customer_with_options(
        self,
        request: dingtalkcrm__1__0_models.AbandonCustomerRequest,
        headers: dingtalkcrm__1__0_models.AbandonCustomerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.AbandonCustomerResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.custom_track_desc):
            body['customTrackDesc'] = request.custom_track_desc
        if not UtilClient.is_unset(request.instance_id_list):
            body['instanceIdList'] = request.instance_id_list
        if not UtilClient.is_unset(request.operator_user_id):
            body['operatorUserId'] = request.operator_user_id
        if not UtilClient.is_unset(request.opt_type):
            body['optType'] = request.opt_type
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
            action='AbandonCustomer',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/customers/abandon',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.AbandonCustomerResponse(),
            self.execute(params, req, runtime)
        )

    async def abandon_customer_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.AbandonCustomerRequest,
        headers: dingtalkcrm__1__0_models.AbandonCustomerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.AbandonCustomerResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.custom_track_desc):
            body['customTrackDesc'] = request.custom_track_desc
        if not UtilClient.is_unset(request.instance_id_list):
            body['instanceIdList'] = request.instance_id_list
        if not UtilClient.is_unset(request.operator_user_id):
            body['operatorUserId'] = request.operator_user_id
        if not UtilClient.is_unset(request.opt_type):
            body['optType'] = request.opt_type
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
            action='AbandonCustomer',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/customers/abandon',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.AbandonCustomerResponse(),
            await self.execute_async(params, req, runtime)
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

    def add_crm_personal_customer_with_options(
        self,
        request: dingtalkcrm__1__0_models.AddCrmPersonalCustomerRequest,
        headers: dingtalkcrm__1__0_models.AddCrmPersonalCustomerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.AddCrmPersonalCustomerResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action):
            body['action'] = request.action
        if not UtilClient.is_unset(request.creator_nick):
            body['creatorNick'] = request.creator_nick
        if not UtilClient.is_unset(request.creator_user_id):
            body['creatorUserId'] = request.creator_user_id
        if not UtilClient.is_unset(request.data):
            body['data'] = request.data
        if not UtilClient.is_unset(request.extend_data):
            body['extendData'] = request.extend_data
        if not UtilClient.is_unset(request.permission):
            body['permission'] = request.permission
        if not UtilClient.is_unset(request.relation_type):
            body['relationType'] = request.relation_type
        if not UtilClient.is_unset(request.skip_duplicate_check):
            body['skipDuplicateCheck'] = request.skip_duplicate_check
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
            action='AddCrmPersonalCustomer',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/personalCustomers',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.AddCrmPersonalCustomerResponse(),
            self.execute(params, req, runtime)
        )

    async def add_crm_personal_customer_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.AddCrmPersonalCustomerRequest,
        headers: dingtalkcrm__1__0_models.AddCrmPersonalCustomerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.AddCrmPersonalCustomerResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action):
            body['action'] = request.action
        if not UtilClient.is_unset(request.creator_nick):
            body['creatorNick'] = request.creator_nick
        if not UtilClient.is_unset(request.creator_user_id):
            body['creatorUserId'] = request.creator_user_id
        if not UtilClient.is_unset(request.data):
            body['data'] = request.data
        if not UtilClient.is_unset(request.extend_data):
            body['extendData'] = request.extend_data
        if not UtilClient.is_unset(request.permission):
            body['permission'] = request.permission
        if not UtilClient.is_unset(request.relation_type):
            body['relationType'] = request.relation_type
        if not UtilClient.is_unset(request.skip_duplicate_check):
            body['skipDuplicateCheck'] = request.skip_duplicate_check
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
            action='AddCrmPersonalCustomer',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/personalCustomers',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.AddCrmPersonalCustomerResponse(),
            await self.execute_async(params, req, runtime)
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

    def add_customer_track_with_options(
        self,
        request: dingtalkcrm__1__0_models.AddCustomerTrackRequest,
        headers: dingtalkcrm__1__0_models.AddCustomerTrackHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.AddCustomerTrackResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.customer_id):
            body['customerId'] = request.customer_id
        if not UtilClient.is_unset(request.extra_biz_info):
            body['extraBizInfo'] = request.extra_biz_info
        if not UtilClient.is_unset(request.idempotent_key):
            body['idempotentKey'] = request.idempotent_key
        if not UtilClient.is_unset(request.masked_content):
            body['maskedContent'] = request.masked_content
        if not UtilClient.is_unset(request.operator_user_id):
            body['operatorUserId'] = request.operator_user_id
        if not UtilClient.is_unset(request.relation_type):
            body['relationType'] = request.relation_type
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
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
            action='AddCustomerTrack',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/customerTracks',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.AddCustomerTrackResponse(),
            self.execute(params, req, runtime)
        )

    async def add_customer_track_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.AddCustomerTrackRequest,
        headers: dingtalkcrm__1__0_models.AddCustomerTrackHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.AddCustomerTrackResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.customer_id):
            body['customerId'] = request.customer_id
        if not UtilClient.is_unset(request.extra_biz_info):
            body['extraBizInfo'] = request.extra_biz_info
        if not UtilClient.is_unset(request.idempotent_key):
            body['idempotentKey'] = request.idempotent_key
        if not UtilClient.is_unset(request.masked_content):
            body['maskedContent'] = request.masked_content
        if not UtilClient.is_unset(request.operator_user_id):
            body['operatorUserId'] = request.operator_user_id
        if not UtilClient.is_unset(request.relation_type):
            body['relationType'] = request.relation_type
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
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
            action='AddCustomerTrack',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/customerTracks',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.AddCustomerTrackResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_customer_track(
        self,
        request: dingtalkcrm__1__0_models.AddCustomerTrackRequest,
    ) -> dingtalkcrm__1__0_models.AddCustomerTrackResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.AddCustomerTrackHeaders()
        return self.add_customer_track_with_options(request, headers, runtime)

    async def add_customer_track_async(
        self,
        request: dingtalkcrm__1__0_models.AddCustomerTrackRequest,
    ) -> dingtalkcrm__1__0_models.AddCustomerTrackResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.AddCustomerTrackHeaders()
        return await self.add_customer_track_with_options_async(request, headers, runtime)

    def add_leads_with_options(
        self,
        request: dingtalkcrm__1__0_models.AddLeadsRequest,
        headers: dingtalkcrm__1__0_models.AddLeadsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.AddLeadsResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.assign_timestamp):
            body['assignTimestamp'] = request.assign_timestamp
        if not UtilClient.is_unset(request.assign_user_id):
            body['assignUserId'] = request.assign_user_id
        if not UtilClient.is_unset(request.assigned_user_id):
            body['assignedUserId'] = request.assigned_user_id
        if not UtilClient.is_unset(request.leads):
            body['leads'] = request.leads
        if not UtilClient.is_unset(request.out_task_id):
            body['outTaskId'] = request.out_task_id
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
            action='AddLeads',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/leads',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.AddLeadsResponse(),
            self.execute(params, req, runtime)
        )

    async def add_leads_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.AddLeadsRequest,
        headers: dingtalkcrm__1__0_models.AddLeadsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.AddLeadsResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.assign_timestamp):
            body['assignTimestamp'] = request.assign_timestamp
        if not UtilClient.is_unset(request.assign_user_id):
            body['assignUserId'] = request.assign_user_id
        if not UtilClient.is_unset(request.assigned_user_id):
            body['assignedUserId'] = request.assigned_user_id
        if not UtilClient.is_unset(request.leads):
            body['leads'] = request.leads
        if not UtilClient.is_unset(request.out_task_id):
            body['outTaskId'] = request.out_task_id
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
            action='AddLeads',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/leads',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.AddLeadsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_leads(
        self,
        request: dingtalkcrm__1__0_models.AddLeadsRequest,
    ) -> dingtalkcrm__1__0_models.AddLeadsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.AddLeadsHeaders()
        return self.add_leads_with_options(request, headers, runtime)

    async def add_leads_async(
        self,
        request: dingtalkcrm__1__0_models.AddLeadsRequest,
    ) -> dingtalkcrm__1__0_models.AddLeadsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.AddLeadsHeaders()
        return await self.add_leads_with_options_async(request, headers, runtime)

    def add_relation_meta_field_with_options(
        self,
        request: dingtalkcrm__1__0_models.AddRelationMetaFieldRequest,
        headers: dingtalkcrm__1__0_models.AddRelationMetaFieldHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.AddRelationMetaFieldResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.field_dtolist):
            body['fieldDTOList'] = request.field_dtolist
        if not UtilClient.is_unset(request.operator_user_id):
            body['operatorUserId'] = request.operator_user_id
        if not UtilClient.is_unset(request.relation_type):
            body['relationType'] = request.relation_type
        if not UtilClient.is_unset(request.tenant):
            body['tenant'] = request.tenant
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
            action='AddRelationMetaField',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/relations/metas/fields',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.AddRelationMetaFieldResponse(),
            self.execute(params, req, runtime)
        )

    async def add_relation_meta_field_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.AddRelationMetaFieldRequest,
        headers: dingtalkcrm__1__0_models.AddRelationMetaFieldHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.AddRelationMetaFieldResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.field_dtolist):
            body['fieldDTOList'] = request.field_dtolist
        if not UtilClient.is_unset(request.operator_user_id):
            body['operatorUserId'] = request.operator_user_id
        if not UtilClient.is_unset(request.relation_type):
            body['relationType'] = request.relation_type
        if not UtilClient.is_unset(request.tenant):
            body['tenant'] = request.tenant
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
            action='AddRelationMetaField',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/relations/metas/fields',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.AddRelationMetaFieldResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_relation_meta_field(
        self,
        request: dingtalkcrm__1__0_models.AddRelationMetaFieldRequest,
    ) -> dingtalkcrm__1__0_models.AddRelationMetaFieldResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.AddRelationMetaFieldHeaders()
        return self.add_relation_meta_field_with_options(request, headers, runtime)

    async def add_relation_meta_field_async(
        self,
        request: dingtalkcrm__1__0_models.AddRelationMetaFieldRequest,
    ) -> dingtalkcrm__1__0_models.AddRelationMetaFieldResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.AddRelationMetaFieldHeaders()
        return await self.add_relation_meta_field_with_options_async(request, headers, runtime)

    def batch_add_contacts_with_options(
        self,
        request: dingtalkcrm__1__0_models.BatchAddContactsRequest,
        headers: dingtalkcrm__1__0_models.BatchAddContactsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.BatchAddContactsResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.operator_user_id):
            body['operatorUserId'] = request.operator_user_id
        if not UtilClient.is_unset(request.relation_list):
            body['relationList'] = request.relation_list
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
            action='BatchAddContacts',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/contacts/batch',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.BatchAddContactsResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_add_contacts_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.BatchAddContactsRequest,
        headers: dingtalkcrm__1__0_models.BatchAddContactsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.BatchAddContactsResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.operator_user_id):
            body['operatorUserId'] = request.operator_user_id
        if not UtilClient.is_unset(request.relation_list):
            body['relationList'] = request.relation_list
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
            action='BatchAddContacts',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/contacts/batch',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.BatchAddContactsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch_add_contacts(
        self,
        request: dingtalkcrm__1__0_models.BatchAddContactsRequest,
    ) -> dingtalkcrm__1__0_models.BatchAddContactsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.BatchAddContactsHeaders()
        return self.batch_add_contacts_with_options(request, headers, runtime)

    async def batch_add_contacts_async(
        self,
        request: dingtalkcrm__1__0_models.BatchAddContactsRequest,
    ) -> dingtalkcrm__1__0_models.BatchAddContactsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.BatchAddContactsHeaders()
        return await self.batch_add_contacts_with_options_async(request, headers, runtime)

    def batch_add_follow_records_with_options(
        self,
        request: dingtalkcrm__1__0_models.BatchAddFollowRecordsRequest,
        headers: dingtalkcrm__1__0_models.BatchAddFollowRecordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.BatchAddFollowRecordsResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.instance_list):
            body['instanceList'] = request.instance_list
        if not UtilClient.is_unset(request.operator_user_id):
            body['operatorUserId'] = request.operator_user_id
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
            action='BatchAddFollowRecords',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/followRecords/batch',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.BatchAddFollowRecordsResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_add_follow_records_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.BatchAddFollowRecordsRequest,
        headers: dingtalkcrm__1__0_models.BatchAddFollowRecordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.BatchAddFollowRecordsResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.instance_list):
            body['instanceList'] = request.instance_list
        if not UtilClient.is_unset(request.operator_user_id):
            body['operatorUserId'] = request.operator_user_id
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
            action='BatchAddFollowRecords',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/followRecords/batch',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.BatchAddFollowRecordsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch_add_follow_records(
        self,
        request: dingtalkcrm__1__0_models.BatchAddFollowRecordsRequest,
    ) -> dingtalkcrm__1__0_models.BatchAddFollowRecordsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.BatchAddFollowRecordsHeaders()
        return self.batch_add_follow_records_with_options(request, headers, runtime)

    async def batch_add_follow_records_async(
        self,
        request: dingtalkcrm__1__0_models.BatchAddFollowRecordsRequest,
    ) -> dingtalkcrm__1__0_models.BatchAddFollowRecordsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.BatchAddFollowRecordsHeaders()
        return await self.batch_add_follow_records_with_options_async(request, headers, runtime)

    def batch_add_relation_datas_with_options(
        self,
        request: dingtalkcrm__1__0_models.BatchAddRelationDatasRequest,
        headers: dingtalkcrm__1__0_models.BatchAddRelationDatasHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.BatchAddRelationDatasResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.operator_user_id):
            body['operatorUserId'] = request.operator_user_id
        if not UtilClient.is_unset(request.relation_list):
            body['relationList'] = request.relation_list
        if not UtilClient.is_unset(request.relation_type):
            body['relationType'] = request.relation_type
        if not UtilClient.is_unset(request.skip_duplicate_check):
            body['skipDuplicateCheck'] = request.skip_duplicate_check
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
            action='BatchAddRelationDatas',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/relationDatas/batch',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.BatchAddRelationDatasResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_add_relation_datas_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.BatchAddRelationDatasRequest,
        headers: dingtalkcrm__1__0_models.BatchAddRelationDatasHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.BatchAddRelationDatasResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.operator_user_id):
            body['operatorUserId'] = request.operator_user_id
        if not UtilClient.is_unset(request.relation_list):
            body['relationList'] = request.relation_list
        if not UtilClient.is_unset(request.relation_type):
            body['relationType'] = request.relation_type
        if not UtilClient.is_unset(request.skip_duplicate_check):
            body['skipDuplicateCheck'] = request.skip_duplicate_check
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
            action='BatchAddRelationDatas',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/relationDatas/batch',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.BatchAddRelationDatasResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch_add_relation_datas(
        self,
        request: dingtalkcrm__1__0_models.BatchAddRelationDatasRequest,
    ) -> dingtalkcrm__1__0_models.BatchAddRelationDatasResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.BatchAddRelationDatasHeaders()
        return self.batch_add_relation_datas_with_options(request, headers, runtime)

    async def batch_add_relation_datas_async(
        self,
        request: dingtalkcrm__1__0_models.BatchAddRelationDatasRequest,
    ) -> dingtalkcrm__1__0_models.BatchAddRelationDatasResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.BatchAddRelationDatasHeaders()
        return await self.batch_add_relation_datas_with_options_async(request, headers, runtime)

    def batch_remove_follow_records_with_options(
        self,
        request: dingtalkcrm__1__0_models.BatchRemoveFollowRecordsRequest,
        headers: dingtalkcrm__1__0_models.BatchRemoveFollowRecordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.BatchRemoveFollowRecordsResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.instance_ids):
            body['instanceIds'] = request.instance_ids
        if not UtilClient.is_unset(request.operator_user_id):
            body['operatorUserId'] = request.operator_user_id
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
            action='BatchRemoveFollowRecords',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/followRecords/batchRemove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.BatchRemoveFollowRecordsResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_remove_follow_records_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.BatchRemoveFollowRecordsRequest,
        headers: dingtalkcrm__1__0_models.BatchRemoveFollowRecordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.BatchRemoveFollowRecordsResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.instance_ids):
            body['instanceIds'] = request.instance_ids
        if not UtilClient.is_unset(request.operator_user_id):
            body['operatorUserId'] = request.operator_user_id
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
            action='BatchRemoveFollowRecords',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/followRecords/batchRemove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.BatchRemoveFollowRecordsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch_remove_follow_records(
        self,
        request: dingtalkcrm__1__0_models.BatchRemoveFollowRecordsRequest,
    ) -> dingtalkcrm__1__0_models.BatchRemoveFollowRecordsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.BatchRemoveFollowRecordsHeaders()
        return self.batch_remove_follow_records_with_options(request, headers, runtime)

    async def batch_remove_follow_records_async(
        self,
        request: dingtalkcrm__1__0_models.BatchRemoveFollowRecordsRequest,
    ) -> dingtalkcrm__1__0_models.BatchRemoveFollowRecordsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.BatchRemoveFollowRecordsHeaders()
        return await self.batch_remove_follow_records_with_options_async(request, headers, runtime)

    def batch_send_official_account_otomessage_with_options(
        self,
        request: dingtalkcrm__1__0_models.BatchSendOfficialAccountOTOMessageRequest,
        headers: dingtalkcrm__1__0_models.BatchSendOfficialAccountOTOMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.BatchSendOfficialAccountOTOMessageResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.account_id):
            body['accountId'] = request.account_id
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.detail):
            body['detail'] = request.detail
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
            action='BatchSendOfficialAccountOTOMessage',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/officialAccounts/oToMessages/batchSend',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.BatchSendOfficialAccountOTOMessageResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_send_official_account_otomessage_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.BatchSendOfficialAccountOTOMessageRequest,
        headers: dingtalkcrm__1__0_models.BatchSendOfficialAccountOTOMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.BatchSendOfficialAccountOTOMessageResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.account_id):
            body['accountId'] = request.account_id
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.detail):
            body['detail'] = request.detail
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
            action='BatchSendOfficialAccountOTOMessage',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/officialAccounts/oToMessages/batchSend',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.BatchSendOfficialAccountOTOMessageResponse(),
            await self.execute_async(params, req, runtime)
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

    def batch_update_contacts_with_options(
        self,
        request: dingtalkcrm__1__0_models.BatchUpdateContactsRequest,
        headers: dingtalkcrm__1__0_models.BatchUpdateContactsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.BatchUpdateContactsResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.operator_user_id):
            body['operatorUserId'] = request.operator_user_id
        if not UtilClient.is_unset(request.relation_list):
            body['relationList'] = request.relation_list
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
            action='BatchUpdateContacts',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/contacts/batch',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.BatchUpdateContactsResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_update_contacts_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.BatchUpdateContactsRequest,
        headers: dingtalkcrm__1__0_models.BatchUpdateContactsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.BatchUpdateContactsResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.operator_user_id):
            body['operatorUserId'] = request.operator_user_id
        if not UtilClient.is_unset(request.relation_list):
            body['relationList'] = request.relation_list
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
            action='BatchUpdateContacts',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/contacts/batch',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.BatchUpdateContactsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch_update_contacts(
        self,
        request: dingtalkcrm__1__0_models.BatchUpdateContactsRequest,
    ) -> dingtalkcrm__1__0_models.BatchUpdateContactsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.BatchUpdateContactsHeaders()
        return self.batch_update_contacts_with_options(request, headers, runtime)

    async def batch_update_contacts_async(
        self,
        request: dingtalkcrm__1__0_models.BatchUpdateContactsRequest,
    ) -> dingtalkcrm__1__0_models.BatchUpdateContactsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.BatchUpdateContactsHeaders()
        return await self.batch_update_contacts_with_options_async(request, headers, runtime)

    def batch_update_follow_records_with_options(
        self,
        request: dingtalkcrm__1__0_models.BatchUpdateFollowRecordsRequest,
        headers: dingtalkcrm__1__0_models.BatchUpdateFollowRecordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.BatchUpdateFollowRecordsResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.instance_list):
            body['instanceList'] = request.instance_list
        if not UtilClient.is_unset(request.operator_user_id):
            body['operatorUserId'] = request.operator_user_id
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
            action='BatchUpdateFollowRecords',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/followRecords/batch',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.BatchUpdateFollowRecordsResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_update_follow_records_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.BatchUpdateFollowRecordsRequest,
        headers: dingtalkcrm__1__0_models.BatchUpdateFollowRecordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.BatchUpdateFollowRecordsResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.instance_list):
            body['instanceList'] = request.instance_list
        if not UtilClient.is_unset(request.operator_user_id):
            body['operatorUserId'] = request.operator_user_id
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
            action='BatchUpdateFollowRecords',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/followRecords/batch',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.BatchUpdateFollowRecordsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch_update_follow_records(
        self,
        request: dingtalkcrm__1__0_models.BatchUpdateFollowRecordsRequest,
    ) -> dingtalkcrm__1__0_models.BatchUpdateFollowRecordsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.BatchUpdateFollowRecordsHeaders()
        return self.batch_update_follow_records_with_options(request, headers, runtime)

    async def batch_update_follow_records_async(
        self,
        request: dingtalkcrm__1__0_models.BatchUpdateFollowRecordsRequest,
    ) -> dingtalkcrm__1__0_models.BatchUpdateFollowRecordsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.BatchUpdateFollowRecordsHeaders()
        return await self.batch_update_follow_records_with_options_async(request, headers, runtime)

    def batch_update_relation_datas_with_options(
        self,
        request: dingtalkcrm__1__0_models.BatchUpdateRelationDatasRequest,
        headers: dingtalkcrm__1__0_models.BatchUpdateRelationDatasHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.BatchUpdateRelationDatasResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.operator_user_id):
            body['operatorUserId'] = request.operator_user_id
        if not UtilClient.is_unset(request.relation_list):
            body['relationList'] = request.relation_list
        if not UtilClient.is_unset(request.relation_type):
            body['relationType'] = request.relation_type
        if not UtilClient.is_unset(request.skip_duplicate_check):
            body['skipDuplicateCheck'] = request.skip_duplicate_check
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
            action='BatchUpdateRelationDatas',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/relationDatas/batch',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.BatchUpdateRelationDatasResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_update_relation_datas_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.BatchUpdateRelationDatasRequest,
        headers: dingtalkcrm__1__0_models.BatchUpdateRelationDatasHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.BatchUpdateRelationDatasResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.operator_user_id):
            body['operatorUserId'] = request.operator_user_id
        if not UtilClient.is_unset(request.relation_list):
            body['relationList'] = request.relation_list
        if not UtilClient.is_unset(request.relation_type):
            body['relationType'] = request.relation_type
        if not UtilClient.is_unset(request.skip_duplicate_check):
            body['skipDuplicateCheck'] = request.skip_duplicate_check
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
            action='BatchUpdateRelationDatas',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/relationDatas/batch',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.BatchUpdateRelationDatasResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch_update_relation_datas(
        self,
        request: dingtalkcrm__1__0_models.BatchUpdateRelationDatasRequest,
    ) -> dingtalkcrm__1__0_models.BatchUpdateRelationDatasResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.BatchUpdateRelationDatasHeaders()
        return self.batch_update_relation_datas_with_options(request, headers, runtime)

    async def batch_update_relation_datas_async(
        self,
        request: dingtalkcrm__1__0_models.BatchUpdateRelationDatasRequest,
    ) -> dingtalkcrm__1__0_models.BatchUpdateRelationDatasResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.BatchUpdateRelationDatasHeaders()
        return await self.batch_update_relation_datas_with_options_async(request, headers, runtime)

    def create_customer_with_options(
        self,
        request: dingtalkcrm__1__0_models.CreateCustomerRequest,
        headers: dingtalkcrm__1__0_models.CreateCustomerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.CreateCustomerResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.contacts):
            body['contacts'] = request.contacts
        if not UtilClient.is_unset(request.creator_user_id):
            body['creatorUserId'] = request.creator_user_id
        if not UtilClient.is_unset(request.data):
            body['data'] = request.data
        if not UtilClient.is_unset(request.extend_data):
            body['extendData'] = request.extend_data
        if not UtilClient.is_unset(request.instance_id):
            body['instanceId'] = request.instance_id
        if not UtilClient.is_unset(request.object_type):
            body['objectType'] = request.object_type
        if not UtilClient.is_unset(request.permission):
            body['permission'] = request.permission
        if not UtilClient.is_unset(request.save_option):
            body['saveOption'] = request.save_option
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
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/customers',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.CreateCustomerResponse(),
            self.execute(params, req, runtime)
        )

    async def create_customer_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.CreateCustomerRequest,
        headers: dingtalkcrm__1__0_models.CreateCustomerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.CreateCustomerResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.contacts):
            body['contacts'] = request.contacts
        if not UtilClient.is_unset(request.creator_user_id):
            body['creatorUserId'] = request.creator_user_id
        if not UtilClient.is_unset(request.data):
            body['data'] = request.data
        if not UtilClient.is_unset(request.extend_data):
            body['extendData'] = request.extend_data
        if not UtilClient.is_unset(request.instance_id):
            body['instanceId'] = request.instance_id
        if not UtilClient.is_unset(request.object_type):
            body['objectType'] = request.object_type
        if not UtilClient.is_unset(request.permission):
            body['permission'] = request.permission
        if not UtilClient.is_unset(request.save_option):
            body['saveOption'] = request.save_option
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
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/customers',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.CreateCustomerResponse(),
            await self.execute_async(params, req, runtime)
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

    def create_group_with_options(
        self,
        request: dingtalkcrm__1__0_models.CreateGroupRequest,
        headers: dingtalkcrm__1__0_models.CreateGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.CreateGroupResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.group_name):
            body['groupName'] = request.group_name
        if not UtilClient.is_unset(request.member_user_ids):
            body['memberUserIds'] = request.member_user_ids
        if not UtilClient.is_unset(request.owner_user_id):
            body['ownerUserId'] = request.owner_user_id
        if not UtilClient.is_unset(request.relation_type):
            body['relationType'] = request.relation_type
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
            action='CreateGroup',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/groups',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.CreateGroupResponse(),
            self.execute(params, req, runtime)
        )

    async def create_group_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.CreateGroupRequest,
        headers: dingtalkcrm__1__0_models.CreateGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.CreateGroupResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.group_name):
            body['groupName'] = request.group_name
        if not UtilClient.is_unset(request.member_user_ids):
            body['memberUserIds'] = request.member_user_ids
        if not UtilClient.is_unset(request.owner_user_id):
            body['ownerUserId'] = request.owner_user_id
        if not UtilClient.is_unset(request.relation_type):
            body['relationType'] = request.relation_type
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
            action='CreateGroup',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/groups',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.CreateGroupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_group(
        self,
        request: dingtalkcrm__1__0_models.CreateGroupRequest,
    ) -> dingtalkcrm__1__0_models.CreateGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.CreateGroupHeaders()
        return self.create_group_with_options(request, headers, runtime)

    async def create_group_async(
        self,
        request: dingtalkcrm__1__0_models.CreateGroupRequest,
    ) -> dingtalkcrm__1__0_models.CreateGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.CreateGroupHeaders()
        return await self.create_group_with_options_async(request, headers, runtime)

    def create_group_set_with_options(
        self,
        request: dingtalkcrm__1__0_models.CreateGroupSetRequest,
        headers: dingtalkcrm__1__0_models.CreateGroupSetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.CreateGroupSetResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.creator_user_id):
            body['creatorUserId'] = request.creator_user_id
        if not UtilClient.is_unset(request.manager_user_ids):
            body['managerUserIds'] = request.manager_user_ids
        if not UtilClient.is_unset(request.member_quota):
            body['memberQuota'] = request.member_quota
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.notice):
            body['notice'] = request.notice
        if not UtilClient.is_unset(request.notice_toped):
            body['noticeToped'] = request.notice_toped
        if not UtilClient.is_unset(request.owner_user_id):
            body['ownerUserId'] = request.owner_user_id
        if not UtilClient.is_unset(request.relation_type):
            body['relationType'] = request.relation_type
        if not UtilClient.is_unset(request.template_id):
            body['templateId'] = request.template_id
        if not UtilClient.is_unset(request.welcome):
            body['welcome'] = request.welcome
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
            action='CreateGroupSet',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/groupSets',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.CreateGroupSetResponse(),
            self.execute(params, req, runtime)
        )

    async def create_group_set_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.CreateGroupSetRequest,
        headers: dingtalkcrm__1__0_models.CreateGroupSetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.CreateGroupSetResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.creator_user_id):
            body['creatorUserId'] = request.creator_user_id
        if not UtilClient.is_unset(request.manager_user_ids):
            body['managerUserIds'] = request.manager_user_ids
        if not UtilClient.is_unset(request.member_quota):
            body['memberQuota'] = request.member_quota
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.notice):
            body['notice'] = request.notice
        if not UtilClient.is_unset(request.notice_toped):
            body['noticeToped'] = request.notice_toped
        if not UtilClient.is_unset(request.owner_user_id):
            body['ownerUserId'] = request.owner_user_id
        if not UtilClient.is_unset(request.relation_type):
            body['relationType'] = request.relation_type
        if not UtilClient.is_unset(request.template_id):
            body['templateId'] = request.template_id
        if not UtilClient.is_unset(request.welcome):
            body['welcome'] = request.welcome
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
            action='CreateGroupSet',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/groupSets',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.CreateGroupSetResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_group_set(
        self,
        request: dingtalkcrm__1__0_models.CreateGroupSetRequest,
    ) -> dingtalkcrm__1__0_models.CreateGroupSetResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.CreateGroupSetHeaders()
        return self.create_group_set_with_options(request, headers, runtime)

    async def create_group_set_async(
        self,
        request: dingtalkcrm__1__0_models.CreateGroupSetRequest,
    ) -> dingtalkcrm__1__0_models.CreateGroupSetResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.CreateGroupSetHeaders()
        return await self.create_group_set_with_options_async(request, headers, runtime)

    def create_relation_meta_with_options(
        self,
        request: dingtalkcrm__1__0_models.CreateRelationMetaRequest,
        headers: dingtalkcrm__1__0_models.CreateRelationMetaHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.CreateRelationMetaResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.operator_user_id):
            body['operatorUserId'] = request.operator_user_id
        if not UtilClient.is_unset(request.relation_meta_dto):
            body['relationMetaDTO'] = request.relation_meta_dto
        if not UtilClient.is_unset(request.tenant):
            body['tenant'] = request.tenant
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
            action='CreateRelationMeta',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/relations/metas/create',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.CreateRelationMetaResponse(),
            self.execute(params, req, runtime)
        )

    async def create_relation_meta_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.CreateRelationMetaRequest,
        headers: dingtalkcrm__1__0_models.CreateRelationMetaHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.CreateRelationMetaResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.operator_user_id):
            body['operatorUserId'] = request.operator_user_id
        if not UtilClient.is_unset(request.relation_meta_dto):
            body['relationMetaDTO'] = request.relation_meta_dto
        if not UtilClient.is_unset(request.tenant):
            body['tenant'] = request.tenant
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
            action='CreateRelationMeta',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/relations/metas/create',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.CreateRelationMetaResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_relation_meta(
        self,
        request: dingtalkcrm__1__0_models.CreateRelationMetaRequest,
    ) -> dingtalkcrm__1__0_models.CreateRelationMetaResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.CreateRelationMetaHeaders()
        return self.create_relation_meta_with_options(request, headers, runtime)

    async def create_relation_meta_async(
        self,
        request: dingtalkcrm__1__0_models.CreateRelationMetaRequest,
    ) -> dingtalkcrm__1__0_models.CreateRelationMetaResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.CreateRelationMetaHeaders()
        return await self.create_relation_meta_with_options_async(request, headers, runtime)

    def delete_crm_custom_object_data_with_options(
        self,
        instance_id: str,
        request: dingtalkcrm__1__0_models.DeleteCrmCustomObjectDataRequest,
        headers: dingtalkcrm__1__0_models.DeleteCrmCustomObjectDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.DeleteCrmCustomObjectDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.form_code):
            query['formCode'] = request.form_code
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
            action='DeleteCrmCustomObjectData',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/customObjectDatas/instances/{instance_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.DeleteCrmCustomObjectDataResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_crm_custom_object_data_with_options_async(
        self,
        instance_id: str,
        request: dingtalkcrm__1__0_models.DeleteCrmCustomObjectDataRequest,
        headers: dingtalkcrm__1__0_models.DeleteCrmCustomObjectDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.DeleteCrmCustomObjectDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.form_code):
            query['formCode'] = request.form_code
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
            action='DeleteCrmCustomObjectData',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/customObjectDatas/instances/{instance_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.DeleteCrmCustomObjectDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_crm_custom_object_data(
        self,
        instance_id: str,
        request: dingtalkcrm__1__0_models.DeleteCrmCustomObjectDataRequest,
    ) -> dingtalkcrm__1__0_models.DeleteCrmCustomObjectDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.DeleteCrmCustomObjectDataHeaders()
        return self.delete_crm_custom_object_data_with_options(instance_id, request, headers, runtime)

    async def delete_crm_custom_object_data_async(
        self,
        instance_id: str,
        request: dingtalkcrm__1__0_models.DeleteCrmCustomObjectDataRequest,
    ) -> dingtalkcrm__1__0_models.DeleteCrmCustomObjectDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.DeleteCrmCustomObjectDataHeaders()
        return await self.delete_crm_custom_object_data_with_options_async(instance_id, request, headers, runtime)

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
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='DeleteCrmFormInstance',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/formInstances/{instance_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.DeleteCrmFormInstanceResponse(),
            self.execute(params, req, runtime)
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
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='DeleteCrmFormInstance',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/formInstances/{instance_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.DeleteCrmFormInstanceResponse(),
            await self.execute_async(params, req, runtime)
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
        if not UtilClient.is_unset(request.relation_type):
            query['relationType'] = request.relation_type
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
            action='DeleteCrmPersonalCustomer',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/personalCustomers/{data_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.DeleteCrmPersonalCustomerResponse(),
            self.execute(params, req, runtime)
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
        if not UtilClient.is_unset(request.relation_type):
            query['relationType'] = request.relation_type
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
            action='DeleteCrmPersonalCustomer',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/personalCustomers/{data_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.DeleteCrmPersonalCustomerResponse(),
            await self.execute_async(params, req, runtime)
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

    def delete_leads_with_options(
        self,
        request: dingtalkcrm__1__0_models.DeleteLeadsRequest,
        headers: dingtalkcrm__1__0_models.DeleteLeadsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.DeleteLeadsResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.out_leads_ids):
            body['outLeadsIds'] = request.out_leads_ids
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
            action='DeleteLeads',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/leads/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.DeleteLeadsResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_leads_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.DeleteLeadsRequest,
        headers: dingtalkcrm__1__0_models.DeleteLeadsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.DeleteLeadsResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.out_leads_ids):
            body['outLeadsIds'] = request.out_leads_ids
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
            action='DeleteLeads',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/leads/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.DeleteLeadsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_leads(
        self,
        request: dingtalkcrm__1__0_models.DeleteLeadsRequest,
    ) -> dingtalkcrm__1__0_models.DeleteLeadsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.DeleteLeadsHeaders()
        return self.delete_leads_with_options(request, headers, runtime)

    async def delete_leads_async(
        self,
        request: dingtalkcrm__1__0_models.DeleteLeadsRequest,
    ) -> dingtalkcrm__1__0_models.DeleteLeadsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.DeleteLeadsHeaders()
        return await self.delete_leads_with_options_async(request, headers, runtime)

    def delete_relation_meta_field_with_options(
        self,
        request: dingtalkcrm__1__0_models.DeleteRelationMetaFieldRequest,
        headers: dingtalkcrm__1__0_models.DeleteRelationMetaFieldHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.DeleteRelationMetaFieldResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.field_id_list):
            body['fieldIdList'] = request.field_id_list
        if not UtilClient.is_unset(request.operator_user_id):
            body['operatorUserId'] = request.operator_user_id
        if not UtilClient.is_unset(request.relation_type):
            body['relationType'] = request.relation_type
        if not UtilClient.is_unset(request.tenant):
            body['tenant'] = request.tenant
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
            action='DeleteRelationMetaField',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/relations/metas/fields/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.DeleteRelationMetaFieldResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_relation_meta_field_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.DeleteRelationMetaFieldRequest,
        headers: dingtalkcrm__1__0_models.DeleteRelationMetaFieldHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.DeleteRelationMetaFieldResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.field_id_list):
            body['fieldIdList'] = request.field_id_list
        if not UtilClient.is_unset(request.operator_user_id):
            body['operatorUserId'] = request.operator_user_id
        if not UtilClient.is_unset(request.relation_type):
            body['relationType'] = request.relation_type
        if not UtilClient.is_unset(request.tenant):
            body['tenant'] = request.tenant
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
            action='DeleteRelationMetaField',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/relations/metas/fields/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.DeleteRelationMetaFieldResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_relation_meta_field(
        self,
        request: dingtalkcrm__1__0_models.DeleteRelationMetaFieldRequest,
    ) -> dingtalkcrm__1__0_models.DeleteRelationMetaFieldResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.DeleteRelationMetaFieldHeaders()
        return self.delete_relation_meta_field_with_options(request, headers, runtime)

    async def delete_relation_meta_field_async(
        self,
        request: dingtalkcrm__1__0_models.DeleteRelationMetaFieldRequest,
    ) -> dingtalkcrm__1__0_models.DeleteRelationMetaFieldResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.DeleteRelationMetaFieldHeaders()
        return await self.delete_relation_meta_field_with_options_async(request, headers, runtime)

    def describe_crm_personal_customer_object_meta_with_options(
        self,
        request: dingtalkcrm__1__0_models.DescribeCrmPersonalCustomerObjectMetaRequest,
        headers: dingtalkcrm__1__0_models.DescribeCrmPersonalCustomerObjectMetaHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.DescribeCrmPersonalCustomerObjectMetaResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.relation_type):
            query['relationType'] = request.relation_type
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
            action='DescribeCrmPersonalCustomerObjectMeta',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/personalCustomers/objectMeta',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.DescribeCrmPersonalCustomerObjectMetaResponse(),
            self.execute(params, req, runtime)
        )

    async def describe_crm_personal_customer_object_meta_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.DescribeCrmPersonalCustomerObjectMetaRequest,
        headers: dingtalkcrm__1__0_models.DescribeCrmPersonalCustomerObjectMetaHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.DescribeCrmPersonalCustomerObjectMetaResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.relation_type):
            query['relationType'] = request.relation_type
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
            action='DescribeCrmPersonalCustomerObjectMeta',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/personalCustomers/objectMeta',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.DescribeCrmPersonalCustomerObjectMetaResponse(),
            await self.execute_async(params, req, runtime)
        )

    def describe_crm_personal_customer_object_meta(
        self,
        request: dingtalkcrm__1__0_models.DescribeCrmPersonalCustomerObjectMetaRequest,
    ) -> dingtalkcrm__1__0_models.DescribeCrmPersonalCustomerObjectMetaResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.DescribeCrmPersonalCustomerObjectMetaHeaders()
        return self.describe_crm_personal_customer_object_meta_with_options(request, headers, runtime)

    async def describe_crm_personal_customer_object_meta_async(
        self,
        request: dingtalkcrm__1__0_models.DescribeCrmPersonalCustomerObjectMetaRequest,
    ) -> dingtalkcrm__1__0_models.DescribeCrmPersonalCustomerObjectMetaResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.DescribeCrmPersonalCustomerObjectMetaHeaders()
        return await self.describe_crm_personal_customer_object_meta_with_options_async(request, headers, runtime)

    def describe_relation_meta_with_options(
        self,
        request: dingtalkcrm__1__0_models.DescribeRelationMetaRequest,
        headers: dingtalkcrm__1__0_models.DescribeRelationMetaHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.DescribeRelationMetaResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.operator_user_id):
            body['operatorUserId'] = request.operator_user_id
        if not UtilClient.is_unset(request.relation_types):
            body['relationTypes'] = request.relation_types
        if not UtilClient.is_unset(request.tenant):
            body['tenant'] = request.tenant
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
            action='DescribeRelationMeta',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/relations/metas/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.DescribeRelationMetaResponse(),
            self.execute(params, req, runtime)
        )

    async def describe_relation_meta_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.DescribeRelationMetaRequest,
        headers: dingtalkcrm__1__0_models.DescribeRelationMetaHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.DescribeRelationMetaResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.operator_user_id):
            body['operatorUserId'] = request.operator_user_id
        if not UtilClient.is_unset(request.relation_types):
            body['relationTypes'] = request.relation_types
        if not UtilClient.is_unset(request.tenant):
            body['tenant'] = request.tenant
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
            action='DescribeRelationMeta',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/relations/metas/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.DescribeRelationMetaResponse(),
            await self.execute_async(params, req, runtime)
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

    def get_all_customer_recycles_with_options(
        self,
        request: dingtalkcrm__1__0_models.GetAllCustomerRecyclesRequest,
        headers: dingtalkcrm__1__0_models.GetAllCustomerRecyclesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.GetAllCustomerRecyclesResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
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
            action='GetAllCustomerRecycles',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/customerRecycles',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.GetAllCustomerRecyclesResponse(),
            self.execute(params, req, runtime)
        )

    async def get_all_customer_recycles_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.GetAllCustomerRecyclesRequest,
        headers: dingtalkcrm__1__0_models.GetAllCustomerRecyclesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.GetAllCustomerRecyclesResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
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
            action='GetAllCustomerRecycles',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/customerRecycles',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.GetAllCustomerRecyclesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_all_customer_recycles(
        self,
        request: dingtalkcrm__1__0_models.GetAllCustomerRecyclesRequest,
    ) -> dingtalkcrm__1__0_models.GetAllCustomerRecyclesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.GetAllCustomerRecyclesHeaders()
        return self.get_all_customer_recycles_with_options(request, headers, runtime)

    async def get_all_customer_recycles_async(
        self,
        request: dingtalkcrm__1__0_models.GetAllCustomerRecyclesRequest,
    ) -> dingtalkcrm__1__0_models.GetAllCustomerRecyclesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.GetAllCustomerRecyclesHeaders()
        return await self.get_all_customer_recycles_with_options_async(request, headers, runtime)

    def get_crm_group_chat_with_options(
        self,
        open_conversation_id: str,
        headers: dingtalkcrm__1__0_models.GetCrmGroupChatHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.GetCrmGroupChatResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetCrmGroupChat',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/crmGroupChats/{open_conversation_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.GetCrmGroupChatResponse(),
            self.execute(params, req, runtime)
        )

    async def get_crm_group_chat_with_options_async(
        self,
        open_conversation_id: str,
        headers: dingtalkcrm__1__0_models.GetCrmGroupChatHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.GetCrmGroupChatResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetCrmGroupChat',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/crmGroupChats/{open_conversation_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.GetCrmGroupChatResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_crm_group_chat(
        self,
        open_conversation_id: str,
    ) -> dingtalkcrm__1__0_models.GetCrmGroupChatResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.GetCrmGroupChatHeaders()
        return self.get_crm_group_chat_with_options(open_conversation_id, headers, runtime)

    async def get_crm_group_chat_async(
        self,
        open_conversation_id: str,
    ) -> dingtalkcrm__1__0_models.GetCrmGroupChatResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.GetCrmGroupChatHeaders()
        return await self.get_crm_group_chat_with_options_async(open_conversation_id, headers, runtime)

    def get_crm_group_chat_multi_with_options(
        self,
        request: dingtalkcrm__1__0_models.GetCrmGroupChatMultiRequest,
        headers: dingtalkcrm__1__0_models.GetCrmGroupChatMultiHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.GetCrmGroupChatMultiResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_ids):
            body['openConversationIds'] = request.open_conversation_ids
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
            action='GetCrmGroupChatMulti',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/crmGroupChats/batchQuery',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.GetCrmGroupChatMultiResponse(),
            self.execute(params, req, runtime)
        )

    async def get_crm_group_chat_multi_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.GetCrmGroupChatMultiRequest,
        headers: dingtalkcrm__1__0_models.GetCrmGroupChatMultiHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.GetCrmGroupChatMultiResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_ids):
            body['openConversationIds'] = request.open_conversation_ids
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
            action='GetCrmGroupChatMulti',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/crmGroupChats/batchQuery',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.GetCrmGroupChatMultiResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_crm_group_chat_multi(
        self,
        request: dingtalkcrm__1__0_models.GetCrmGroupChatMultiRequest,
    ) -> dingtalkcrm__1__0_models.GetCrmGroupChatMultiResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.GetCrmGroupChatMultiHeaders()
        return self.get_crm_group_chat_multi_with_options(request, headers, runtime)

    async def get_crm_group_chat_multi_async(
        self,
        request: dingtalkcrm__1__0_models.GetCrmGroupChatMultiRequest,
    ) -> dingtalkcrm__1__0_models.GetCrmGroupChatMultiResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.GetCrmGroupChatMultiHeaders()
        return await self.get_crm_group_chat_multi_with_options_async(request, headers, runtime)

    def get_crm_group_chat_single_with_options(
        self,
        request: dingtalkcrm__1__0_models.GetCrmGroupChatSingleRequest,
        headers: dingtalkcrm__1__0_models.GetCrmGroupChatSingleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.GetCrmGroupChatSingleResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            query['openConversationId'] = request.open_conversation_id
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
            action='GetCrmGroupChatSingle',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/crmGroupChats/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.GetCrmGroupChatSingleResponse(),
            self.execute(params, req, runtime)
        )

    async def get_crm_group_chat_single_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.GetCrmGroupChatSingleRequest,
        headers: dingtalkcrm__1__0_models.GetCrmGroupChatSingleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.GetCrmGroupChatSingleResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            query['openConversationId'] = request.open_conversation_id
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
            action='GetCrmGroupChatSingle',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/crmGroupChats/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.GetCrmGroupChatSingleResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_crm_group_chat_single(
        self,
        request: dingtalkcrm__1__0_models.GetCrmGroupChatSingleRequest,
    ) -> dingtalkcrm__1__0_models.GetCrmGroupChatSingleResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.GetCrmGroupChatSingleHeaders()
        return self.get_crm_group_chat_single_with_options(request, headers, runtime)

    async def get_crm_group_chat_single_async(
        self,
        request: dingtalkcrm__1__0_models.GetCrmGroupChatSingleRequest,
    ) -> dingtalkcrm__1__0_models.GetCrmGroupChatSingleResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.GetCrmGroupChatSingleHeaders()
        return await self.get_crm_group_chat_single_with_options_async(request, headers, runtime)

    def get_crm_role_permission_with_options(
        self,
        request: dingtalkcrm__1__0_models.GetCrmRolePermissionRequest,
        headers: dingtalkcrm__1__0_models.GetCrmRolePermissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.GetCrmRolePermissionResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.biz_type):
            query['bizType'] = request.biz_type
        if not UtilClient.is_unset(request.resource_id):
            query['resourceId'] = request.resource_id
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
            action='GetCrmRolePermission',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/permissions',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.GetCrmRolePermissionResponse(),
            self.execute(params, req, runtime)
        )

    async def get_crm_role_permission_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.GetCrmRolePermissionRequest,
        headers: dingtalkcrm__1__0_models.GetCrmRolePermissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.GetCrmRolePermissionResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.biz_type):
            query['bizType'] = request.biz_type
        if not UtilClient.is_unset(request.resource_id):
            query['resourceId'] = request.resource_id
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
            action='GetCrmRolePermission',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/permissions',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.GetCrmRolePermissionResponse(),
            await self.execute_async(params, req, runtime)
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

    def get_customer_tracks_by_relation_id_with_options(
        self,
        request: dingtalkcrm__1__0_models.GetCustomerTracksByRelationIdRequest,
        headers: dingtalkcrm__1__0_models.GetCustomerTracksByRelationIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.GetCustomerTracksByRelationIdResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.relation_id):
            query['relationId'] = request.relation_id
        if not UtilClient.is_unset(request.type_group):
            query['typeGroup'] = request.type_group
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
            action='GetCustomerTracksByRelationId',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/customerTracks',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.GetCustomerTracksByRelationIdResponse(),
            self.execute(params, req, runtime)
        )

    async def get_customer_tracks_by_relation_id_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.GetCustomerTracksByRelationIdRequest,
        headers: dingtalkcrm__1__0_models.GetCustomerTracksByRelationIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.GetCustomerTracksByRelationIdResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.relation_id):
            query['relationId'] = request.relation_id
        if not UtilClient.is_unset(request.type_group):
            query['typeGroup'] = request.type_group
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
            action='GetCustomerTracksByRelationId',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/customerTracks',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.GetCustomerTracksByRelationIdResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_customer_tracks_by_relation_id(
        self,
        request: dingtalkcrm__1__0_models.GetCustomerTracksByRelationIdRequest,
    ) -> dingtalkcrm__1__0_models.GetCustomerTracksByRelationIdResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.GetCustomerTracksByRelationIdHeaders()
        return self.get_customer_tracks_by_relation_id_with_options(request, headers, runtime)

    async def get_customer_tracks_by_relation_id_async(
        self,
        request: dingtalkcrm__1__0_models.GetCustomerTracksByRelationIdRequest,
    ) -> dingtalkcrm__1__0_models.GetCustomerTracksByRelationIdResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.GetCustomerTracksByRelationIdHeaders()
        return await self.get_customer_tracks_by_relation_id_with_options_async(request, headers, runtime)

    def get_group_set_with_options(
        self,
        request: dingtalkcrm__1__0_models.GetGroupSetRequest,
        headers: dingtalkcrm__1__0_models.GetGroupSetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.GetGroupSetResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.open_group_set_id):
            query['openGroupSetId'] = request.open_group_set_id
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
            action='GetGroupSet',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/groupSets',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.GetGroupSetResponse(),
            self.execute(params, req, runtime)
        )

    async def get_group_set_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.GetGroupSetRequest,
        headers: dingtalkcrm__1__0_models.GetGroupSetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.GetGroupSetResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.open_group_set_id):
            query['openGroupSetId'] = request.open_group_set_id
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
            action='GetGroupSet',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/groupSets',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.GetGroupSetResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_group_set(
        self,
        request: dingtalkcrm__1__0_models.GetGroupSetRequest,
    ) -> dingtalkcrm__1__0_models.GetGroupSetResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.GetGroupSetHeaders()
        return self.get_group_set_with_options(request, headers, runtime)

    async def get_group_set_async(
        self,
        request: dingtalkcrm__1__0_models.GetGroupSetRequest,
    ) -> dingtalkcrm__1__0_models.GetGroupSetResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.GetGroupSetHeaders()
        return await self.get_group_set_with_options_async(request, headers, runtime)

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
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetOfficialAccountContactInfo',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/officialAccounts/contacts/{user_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.GetOfficialAccountContactInfoResponse(),
            self.execute(params, req, runtime)
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
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetOfficialAccountContactInfo',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/officialAccounts/contacts/{user_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.GetOfficialAccountContactInfoResponse(),
            await self.execute_async(params, req, runtime)
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

    def get_official_account_contacts_with_options(
        self,
        request: dingtalkcrm__1__0_models.GetOfficialAccountContactsRequest,
        headers: dingtalkcrm__1__0_models.GetOfficialAccountContactsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.GetOfficialAccountContactsResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
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
            action='GetOfficialAccountContacts',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/officialAccounts/contacts',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.GetOfficialAccountContactsResponse(),
            self.execute(params, req, runtime)
        )

    async def get_official_account_contacts_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.GetOfficialAccountContactsRequest,
        headers: dingtalkcrm__1__0_models.GetOfficialAccountContactsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.GetOfficialAccountContactsResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
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
            action='GetOfficialAccountContacts',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/officialAccounts/contacts',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.GetOfficialAccountContactsResponse(),
            await self.execute_async(params, req, runtime)
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

    def get_official_account_otomessage_result_with_options(
        self,
        request: dingtalkcrm__1__0_models.GetOfficialAccountOTOMessageResultRequest,
        headers: dingtalkcrm__1__0_models.GetOfficialAccountOTOMessageResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.GetOfficialAccountOTOMessageResultResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.account_id):
            query['accountId'] = request.account_id
        if not UtilClient.is_unset(request.open_push_id):
            query['openPushId'] = request.open_push_id
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
            action='GetOfficialAccountOTOMessageResult',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/officialAccounts/oToMessages/sendResults',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.GetOfficialAccountOTOMessageResultResponse(),
            self.execute(params, req, runtime)
        )

    async def get_official_account_otomessage_result_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.GetOfficialAccountOTOMessageResultRequest,
        headers: dingtalkcrm__1__0_models.GetOfficialAccountOTOMessageResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.GetOfficialAccountOTOMessageResultResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.account_id):
            query['accountId'] = request.account_id
        if not UtilClient.is_unset(request.open_push_id):
            query['openPushId'] = request.open_push_id
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
            action='GetOfficialAccountOTOMessageResult',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/officialAccounts/oToMessages/sendResults',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.GetOfficialAccountOTOMessageResultResponse(),
            await self.execute_async(params, req, runtime)
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

    def get_relation_uk_setting_with_options(
        self,
        request: dingtalkcrm__1__0_models.GetRelationUkSettingRequest,
        headers: dingtalkcrm__1__0_models.GetRelationUkSettingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.GetRelationUkSettingResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.relation_type):
            query['relationType'] = request.relation_type
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
            action='GetRelationUkSetting',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/relationUkSettings',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.GetRelationUkSettingResponse(),
            self.execute(params, req, runtime)
        )

    async def get_relation_uk_setting_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.GetRelationUkSettingRequest,
        headers: dingtalkcrm__1__0_models.GetRelationUkSettingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.GetRelationUkSettingResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.relation_type):
            query['relationType'] = request.relation_type
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
            action='GetRelationUkSetting',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/relationUkSettings',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.GetRelationUkSettingResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_relation_uk_setting(
        self,
        request: dingtalkcrm__1__0_models.GetRelationUkSettingRequest,
    ) -> dingtalkcrm__1__0_models.GetRelationUkSettingResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.GetRelationUkSettingHeaders()
        return self.get_relation_uk_setting_with_options(request, headers, runtime)

    async def get_relation_uk_setting_async(
        self,
        request: dingtalkcrm__1__0_models.GetRelationUkSettingRequest,
    ) -> dingtalkcrm__1__0_models.GetRelationUkSettingResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.GetRelationUkSettingHeaders()
        return await self.get_relation_uk_setting_with_options_async(request, headers, runtime)

    def join_group_set_with_options(
        self,
        request: dingtalkcrm__1__0_models.JoinGroupSetRequest,
        headers: dingtalkcrm__1__0_models.JoinGroupSetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.JoinGroupSetResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_data_list):
            body['bizDataList'] = request.biz_data_list
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.open_group_set_id):
            body['openGroupSetId'] = request.open_group_set_id
        if not UtilClient.is_unset(request.union_id):
            body['unionId'] = request.union_id
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
            action='JoinGroupSet',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/groupSets/join',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.JoinGroupSetResponse(),
            self.execute(params, req, runtime)
        )

    async def join_group_set_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.JoinGroupSetRequest,
        headers: dingtalkcrm__1__0_models.JoinGroupSetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.JoinGroupSetResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_data_list):
            body['bizDataList'] = request.biz_data_list
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.open_group_set_id):
            body['openGroupSetId'] = request.open_group_set_id
        if not UtilClient.is_unset(request.union_id):
            body['unionId'] = request.union_id
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
            action='JoinGroupSet',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/groupSets/join',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.JoinGroupSetResponse(),
            await self.execute_async(params, req, runtime)
        )

    def join_group_set(
        self,
        request: dingtalkcrm__1__0_models.JoinGroupSetRequest,
    ) -> dingtalkcrm__1__0_models.JoinGroupSetResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.JoinGroupSetHeaders()
        return self.join_group_set_with_options(request, headers, runtime)

    async def join_group_set_async(
        self,
        request: dingtalkcrm__1__0_models.JoinGroupSetRequest,
    ) -> dingtalkcrm__1__0_models.JoinGroupSetResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.JoinGroupSetHeaders()
        return await self.join_group_set_with_options_async(request, headers, runtime)

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
        if not UtilClient.is_unset(request.relation_type):
            query['relationType'] = request.relation_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=request.body
        )
        params = open_api_models.Params(
            action='ListCrmPersonalCustomers',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/personalCustomers/batchQuery',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.ListCrmPersonalCustomersResponse(),
            self.execute(params, req, runtime)
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
        if not UtilClient.is_unset(request.relation_type):
            query['relationType'] = request.relation_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=request.body
        )
        params = open_api_models.Params(
            action='ListCrmPersonalCustomers',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/personalCustomers/batchQuery',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.ListCrmPersonalCustomersResponse(),
            await self.execute_async(params, req, runtime)
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

    def list_group_set_with_options(
        self,
        request: dingtalkcrm__1__0_models.ListGroupSetRequest,
        headers: dingtalkcrm__1__0_models.ListGroupSetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.ListGroupSetResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.query_dsl):
            query['queryDsl'] = request.query_dsl
        if not UtilClient.is_unset(request.relation_type):
            query['relationType'] = request.relation_type
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
            action='ListGroupSet',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/groupSets/lists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.ListGroupSetResponse(),
            self.execute(params, req, runtime)
        )

    async def list_group_set_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.ListGroupSetRequest,
        headers: dingtalkcrm__1__0_models.ListGroupSetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.ListGroupSetResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.query_dsl):
            query['queryDsl'] = request.query_dsl
        if not UtilClient.is_unset(request.relation_type):
            query['relationType'] = request.relation_type
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
            action='ListGroupSet',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/groupSets/lists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.ListGroupSetResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_group_set(
        self,
        request: dingtalkcrm__1__0_models.ListGroupSetRequest,
    ) -> dingtalkcrm__1__0_models.ListGroupSetResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.ListGroupSetHeaders()
        return self.list_group_set_with_options(request, headers, runtime)

    async def list_group_set_async(
        self,
        request: dingtalkcrm__1__0_models.ListGroupSetRequest,
    ) -> dingtalkcrm__1__0_models.ListGroupSetResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.ListGroupSetHeaders()
        return await self.list_group_set_with_options_async(request, headers, runtime)

    def query_all_customer_with_options(
        self,
        request: dingtalkcrm__1__0_models.QueryAllCustomerRequest,
        headers: dingtalkcrm__1__0_models.QueryAllCustomerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.QueryAllCustomerResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.object_type):
            body['objectType'] = request.object_type
        if not UtilClient.is_unset(request.operator_user_id):
            body['operatorUserId'] = request.operator_user_id
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
            action='QueryAllCustomer',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/customerInstances',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.QueryAllCustomerResponse(),
            self.execute(params, req, runtime)
        )

    async def query_all_customer_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.QueryAllCustomerRequest,
        headers: dingtalkcrm__1__0_models.QueryAllCustomerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.QueryAllCustomerResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.object_type):
            body['objectType'] = request.object_type
        if not UtilClient.is_unset(request.operator_user_id):
            body['operatorUserId'] = request.operator_user_id
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
            action='QueryAllCustomer',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/customerInstances',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.QueryAllCustomerResponse(),
            await self.execute_async(params, req, runtime)
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

    def query_all_tracks_with_options(
        self,
        request: dingtalkcrm__1__0_models.QueryAllTracksRequest,
        headers: dingtalkcrm__1__0_models.QueryAllTracksHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.QueryAllTracksResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.order):
            query['order'] = request.order
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
            action='QueryAllTracks',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/customers/tracks',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.QueryAllTracksResponse(),
            self.execute(params, req, runtime)
        )

    async def query_all_tracks_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.QueryAllTracksRequest,
        headers: dingtalkcrm__1__0_models.QueryAllTracksHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.QueryAllTracksResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.order):
            query['order'] = request.order
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
            action='QueryAllTracks',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/customers/tracks',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.QueryAllTracksResponse(),
            await self.execute_async(params, req, runtime)
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

    def query_crm_group_chats_with_options(
        self,
        request: dingtalkcrm__1__0_models.QueryCrmGroupChatsRequest,
        headers: dingtalkcrm__1__0_models.QueryCrmGroupChatsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.QueryCrmGroupChatsResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.query_dsl):
            query['queryDsl'] = request.query_dsl
        if not UtilClient.is_unset(request.relation_type):
            query['relationType'] = request.relation_type
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
            action='QueryCrmGroupChats',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/crmGroupChats',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.QueryCrmGroupChatsResponse(),
            self.execute(params, req, runtime)
        )

    async def query_crm_group_chats_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.QueryCrmGroupChatsRequest,
        headers: dingtalkcrm__1__0_models.QueryCrmGroupChatsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.QueryCrmGroupChatsResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.query_dsl):
            query['queryDsl'] = request.query_dsl
        if not UtilClient.is_unset(request.relation_type):
            query['relationType'] = request.relation_type
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
            action='QueryCrmGroupChats',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/crmGroupChats',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.QueryCrmGroupChatsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_crm_group_chats(
        self,
        request: dingtalkcrm__1__0_models.QueryCrmGroupChatsRequest,
    ) -> dingtalkcrm__1__0_models.QueryCrmGroupChatsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.QueryCrmGroupChatsHeaders()
        return self.query_crm_group_chats_with_options(request, headers, runtime)

    async def query_crm_group_chats_async(
        self,
        request: dingtalkcrm__1__0_models.QueryCrmGroupChatsRequest,
    ) -> dingtalkcrm__1__0_models.QueryCrmGroupChatsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.QueryCrmGroupChatsHeaders()
        return await self.query_crm_group_chats_with_options_async(request, headers, runtime)

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
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.query_dsl):
            query['queryDsl'] = request.query_dsl
        if not UtilClient.is_unset(request.relation_type):
            query['relationType'] = request.relation_type
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
            action='QueryCrmPersonalCustomer',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/personalCustomers',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.QueryCrmPersonalCustomerResponse(),
            self.execute(params, req, runtime)
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
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.query_dsl):
            query['queryDsl'] = request.query_dsl
        if not UtilClient.is_unset(request.relation_type):
            query['relationType'] = request.relation_type
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
            action='QueryCrmPersonalCustomer',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/personalCustomers',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.QueryCrmPersonalCustomerResponse(),
            await self.execute_async(params, req, runtime)
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

    def query_global_info_with_options(
        self,
        request: dingtalkcrm__1__0_models.QueryGlobalInfoRequest,
        headers: dingtalkcrm__1__0_models.QueryGlobalInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.QueryGlobalInfoResponse:
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
            action='QueryGlobalInfo',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/globalInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.QueryGlobalInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def query_global_info_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.QueryGlobalInfoRequest,
        headers: dingtalkcrm__1__0_models.QueryGlobalInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.QueryGlobalInfoResponse:
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
            action='QueryGlobalInfo',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/globalInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.QueryGlobalInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_global_info(
        self,
        request: dingtalkcrm__1__0_models.QueryGlobalInfoRequest,
    ) -> dingtalkcrm__1__0_models.QueryGlobalInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.QueryGlobalInfoHeaders()
        return self.query_global_info_with_options(request, headers, runtime)

    async def query_global_info_async(
        self,
        request: dingtalkcrm__1__0_models.QueryGlobalInfoRequest,
    ) -> dingtalkcrm__1__0_models.QueryGlobalInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.QueryGlobalInfoHeaders()
        return await self.query_global_info_with_options_async(request, headers, runtime)

    def query_official_account_user_basic_info_with_options(
        self,
        request: dingtalkcrm__1__0_models.QueryOfficialAccountUserBasicInfoRequest,
        headers: dingtalkcrm__1__0_models.QueryOfficialAccountUserBasicInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.QueryOfficialAccountUserBasicInfoResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.binding_token):
            query['bindingToken'] = request.binding_token
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
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
            action='QueryOfficialAccountUserBasicInfo',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/officialAccounts/basics/users',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.QueryOfficialAccountUserBasicInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def query_official_account_user_basic_info_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.QueryOfficialAccountUserBasicInfoRequest,
        headers: dingtalkcrm__1__0_models.QueryOfficialAccountUserBasicInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.QueryOfficialAccountUserBasicInfoResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.binding_token):
            query['bindingToken'] = request.binding_token
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
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
            action='QueryOfficialAccountUserBasicInfo',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/officialAccounts/basics/users',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.QueryOfficialAccountUserBasicInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_official_account_user_basic_info(
        self,
        request: dingtalkcrm__1__0_models.QueryOfficialAccountUserBasicInfoRequest,
    ) -> dingtalkcrm__1__0_models.QueryOfficialAccountUserBasicInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.QueryOfficialAccountUserBasicInfoHeaders()
        return self.query_official_account_user_basic_info_with_options(request, headers, runtime)

    async def query_official_account_user_basic_info_async(
        self,
        request: dingtalkcrm__1__0_models.QueryOfficialAccountUserBasicInfoRequest,
    ) -> dingtalkcrm__1__0_models.QueryOfficialAccountUserBasicInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.QueryOfficialAccountUserBasicInfoHeaders()
        return await self.query_official_account_user_basic_info_with_options_async(request, headers, runtime)

    def query_relation_datas_by_target_id_with_options(
        self,
        target_id: str,
        request: dingtalkcrm__1__0_models.QueryRelationDatasByTargetIdRequest,
        headers: dingtalkcrm__1__0_models.QueryRelationDatasByTargetIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.QueryRelationDatasByTargetIdResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.relation_type):
            query['relationType'] = request.relation_type
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
            action='QueryRelationDatasByTargetId',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/relations/datas/targets/{target_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.QueryRelationDatasByTargetIdResponse(),
            self.execute(params, req, runtime)
        )

    async def query_relation_datas_by_target_id_with_options_async(
        self,
        target_id: str,
        request: dingtalkcrm__1__0_models.QueryRelationDatasByTargetIdRequest,
        headers: dingtalkcrm__1__0_models.QueryRelationDatasByTargetIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.QueryRelationDatasByTargetIdResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.relation_type):
            query['relationType'] = request.relation_type
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
            action='QueryRelationDatasByTargetId',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/relations/datas/targets/{target_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.QueryRelationDatasByTargetIdResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_relation_datas_by_target_id(
        self,
        target_id: str,
        request: dingtalkcrm__1__0_models.QueryRelationDatasByTargetIdRequest,
    ) -> dingtalkcrm__1__0_models.QueryRelationDatasByTargetIdResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.QueryRelationDatasByTargetIdHeaders()
        return self.query_relation_datas_by_target_id_with_options(target_id, request, headers, runtime)

    async def query_relation_datas_by_target_id_async(
        self,
        target_id: str,
        request: dingtalkcrm__1__0_models.QueryRelationDatasByTargetIdRequest,
    ) -> dingtalkcrm__1__0_models.QueryRelationDatasByTargetIdResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.QueryRelationDatasByTargetIdHeaders()
        return await self.query_relation_datas_by_target_id_with_options_async(target_id, request, headers, runtime)

    def recall_official_account_otomessage_with_options(
        self,
        request: dingtalkcrm__1__0_models.RecallOfficialAccountOTOMessageRequest,
        headers: dingtalkcrm__1__0_models.RecallOfficialAccountOTOMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.RecallOfficialAccountOTOMessageResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.account_id):
            body['accountId'] = request.account_id
        if not UtilClient.is_unset(request.open_push_id):
            body['openPushId'] = request.open_push_id
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
            action='RecallOfficialAccountOTOMessage',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/officialAccounts/oToMessages/recall',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.RecallOfficialAccountOTOMessageResponse(),
            self.execute(params, req, runtime)
        )

    async def recall_official_account_otomessage_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.RecallOfficialAccountOTOMessageRequest,
        headers: dingtalkcrm__1__0_models.RecallOfficialAccountOTOMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.RecallOfficialAccountOTOMessageResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.account_id):
            body['accountId'] = request.account_id
        if not UtilClient.is_unset(request.open_push_id):
            body['openPushId'] = request.open_push_id
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
            action='RecallOfficialAccountOTOMessage',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/officialAccounts/oToMessages/recall',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.RecallOfficialAccountOTOMessageResponse(),
            await self.execute_async(params, req, runtime)
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

    def send_official_account_otomessage_with_options(
        self,
        request: dingtalkcrm__1__0_models.SendOfficialAccountOTOMessageRequest,
        headers: dingtalkcrm__1__0_models.SendOfficialAccountOTOMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.SendOfficialAccountOTOMessageResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.account_id):
            body['accountId'] = request.account_id
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.detail):
            body['detail'] = request.detail
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
            action='SendOfficialAccountOTOMessage',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/officialAccounts/oToMessages/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.SendOfficialAccountOTOMessageResponse(),
            self.execute(params, req, runtime)
        )

    async def send_official_account_otomessage_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.SendOfficialAccountOTOMessageRequest,
        headers: dingtalkcrm__1__0_models.SendOfficialAccountOTOMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.SendOfficialAccountOTOMessageResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.account_id):
            body['accountId'] = request.account_id
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.detail):
            body['detail'] = request.detail
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
            action='SendOfficialAccountOTOMessage',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/officialAccounts/oToMessages/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.SendOfficialAccountOTOMessageResponse(),
            await self.execute_async(params, req, runtime)
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

    def send_official_account_snsmessage_with_options(
        self,
        request: dingtalkcrm__1__0_models.SendOfficialAccountSNSMessageRequest,
        headers: dingtalkcrm__1__0_models.SendOfficialAccountSNSMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.SendOfficialAccountSNSMessageResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.binding_token):
            body['bindingToken'] = request.binding_token
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.detail):
            body['detail'] = request.detail
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
            action='SendOfficialAccountSNSMessage',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/officialAccounts/snsMessages/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.SendOfficialAccountSNSMessageResponse(),
            self.execute(params, req, runtime)
        )

    async def send_official_account_snsmessage_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.SendOfficialAccountSNSMessageRequest,
        headers: dingtalkcrm__1__0_models.SendOfficialAccountSNSMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.SendOfficialAccountSNSMessageResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.binding_token):
            body['bindingToken'] = request.binding_token
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.detail):
            body['detail'] = request.detail
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
            action='SendOfficialAccountSNSMessage',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/officialAccounts/snsMessages/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.SendOfficialAccountSNSMessageResponse(),
            await self.execute_async(params, req, runtime)
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

    def service_window_message_batch_push_with_options(
        self,
        request: dingtalkcrm__1__0_models.ServiceWindowMessageBatchPushRequest,
        headers: dingtalkcrm__1__0_models.ServiceWindowMessageBatchPushHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.ServiceWindowMessageBatchPushResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.detail):
            body['detail'] = request.detail
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
            action='ServiceWindowMessageBatchPush',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/messages/batchSend',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.ServiceWindowMessageBatchPushResponse(),
            self.execute(params, req, runtime)
        )

    async def service_window_message_batch_push_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.ServiceWindowMessageBatchPushRequest,
        headers: dingtalkcrm__1__0_models.ServiceWindowMessageBatchPushHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.ServiceWindowMessageBatchPushResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.detail):
            body['detail'] = request.detail
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
            action='ServiceWindowMessageBatchPush',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/messages/batchSend',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.ServiceWindowMessageBatchPushResponse(),
            await self.execute_async(params, req, runtime)
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

    def update_crm_personal_customer_with_options(
        self,
        request: dingtalkcrm__1__0_models.UpdateCrmPersonalCustomerRequest,
        headers: dingtalkcrm__1__0_models.UpdateCrmPersonalCustomerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.UpdateCrmPersonalCustomerResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action):
            body['action'] = request.action
        if not UtilClient.is_unset(request.data):
            body['data'] = request.data
        if not UtilClient.is_unset(request.extend_data):
            body['extendData'] = request.extend_data
        if not UtilClient.is_unset(request.instance_id):
            body['instanceId'] = request.instance_id
        if not UtilClient.is_unset(request.modifier_nick):
            body['modifierNick'] = request.modifier_nick
        if not UtilClient.is_unset(request.modifier_user_id):
            body['modifierUserId'] = request.modifier_user_id
        if not UtilClient.is_unset(request.permission):
            body['permission'] = request.permission
        if not UtilClient.is_unset(request.relation_type):
            body['relationType'] = request.relation_type
        if not UtilClient.is_unset(request.skip_duplicate_check):
            body['skipDuplicateCheck'] = request.skip_duplicate_check
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
            action='UpdateCrmPersonalCustomer',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/personalCustomers',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.UpdateCrmPersonalCustomerResponse(),
            self.execute(params, req, runtime)
        )

    async def update_crm_personal_customer_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.UpdateCrmPersonalCustomerRequest,
        headers: dingtalkcrm__1__0_models.UpdateCrmPersonalCustomerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.UpdateCrmPersonalCustomerResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action):
            body['action'] = request.action
        if not UtilClient.is_unset(request.data):
            body['data'] = request.data
        if not UtilClient.is_unset(request.extend_data):
            body['extendData'] = request.extend_data
        if not UtilClient.is_unset(request.instance_id):
            body['instanceId'] = request.instance_id
        if not UtilClient.is_unset(request.modifier_nick):
            body['modifierNick'] = request.modifier_nick
        if not UtilClient.is_unset(request.modifier_user_id):
            body['modifierUserId'] = request.modifier_user_id
        if not UtilClient.is_unset(request.permission):
            body['permission'] = request.permission
        if not UtilClient.is_unset(request.relation_type):
            body['relationType'] = request.relation_type
        if not UtilClient.is_unset(request.skip_duplicate_check):
            body['skipDuplicateCheck'] = request.skip_duplicate_check
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
            action='UpdateCrmPersonalCustomer',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/personalCustomers',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.UpdateCrmPersonalCustomerResponse(),
            await self.execute_async(params, req, runtime)
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

    def update_group_set_with_options(
        self,
        request: dingtalkcrm__1__0_models.UpdateGroupSetRequest,
        headers: dingtalkcrm__1__0_models.UpdateGroupSetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.UpdateGroupSetResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.manager_user_ids):
            body['managerUserIds'] = request.manager_user_ids
        if not UtilClient.is_unset(request.member_quota):
            body['memberQuota'] = request.member_quota
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.notice):
            body['notice'] = request.notice
        if not UtilClient.is_unset(request.notice_toped):
            body['noticeToped'] = request.notice_toped
        if not UtilClient.is_unset(request.open_group_set_id):
            body['openGroupSetId'] = request.open_group_set_id
        if not UtilClient.is_unset(request.owner_user_id):
            body['ownerUserId'] = request.owner_user_id
        if not UtilClient.is_unset(request.template_id):
            body['templateId'] = request.template_id
        if not UtilClient.is_unset(request.welcome):
            body['welcome'] = request.welcome
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
            action='UpdateGroupSet',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/groupSets/set',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='boolean'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.UpdateGroupSetResponse(),
            self.execute(params, req, runtime)
        )

    async def update_group_set_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.UpdateGroupSetRequest,
        headers: dingtalkcrm__1__0_models.UpdateGroupSetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.UpdateGroupSetResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.manager_user_ids):
            body['managerUserIds'] = request.manager_user_ids
        if not UtilClient.is_unset(request.member_quota):
            body['memberQuota'] = request.member_quota
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.notice):
            body['notice'] = request.notice
        if not UtilClient.is_unset(request.notice_toped):
            body['noticeToped'] = request.notice_toped
        if not UtilClient.is_unset(request.open_group_set_id):
            body['openGroupSetId'] = request.open_group_set_id
        if not UtilClient.is_unset(request.owner_user_id):
            body['ownerUserId'] = request.owner_user_id
        if not UtilClient.is_unset(request.template_id):
            body['templateId'] = request.template_id
        if not UtilClient.is_unset(request.welcome):
            body['welcome'] = request.welcome
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
            action='UpdateGroupSet',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/groupSets/set',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='boolean'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.UpdateGroupSetResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_group_set(
        self,
        request: dingtalkcrm__1__0_models.UpdateGroupSetRequest,
    ) -> dingtalkcrm__1__0_models.UpdateGroupSetResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.UpdateGroupSetHeaders()
        return self.update_group_set_with_options(request, headers, runtime)

    async def update_group_set_async(
        self,
        request: dingtalkcrm__1__0_models.UpdateGroupSetRequest,
    ) -> dingtalkcrm__1__0_models.UpdateGroupSetResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.UpdateGroupSetHeaders()
        return await self.update_group_set_with_options_async(request, headers, runtime)

    def update_relation_meta_field_with_options(
        self,
        request: dingtalkcrm__1__0_models.UpdateRelationMetaFieldRequest,
        headers: dingtalkcrm__1__0_models.UpdateRelationMetaFieldHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.UpdateRelationMetaFieldResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.field_dtolist):
            body['fieldDTOList'] = request.field_dtolist
        if not UtilClient.is_unset(request.operator_user_id):
            body['operatorUserId'] = request.operator_user_id
        if not UtilClient.is_unset(request.relation_type):
            body['relationType'] = request.relation_type
        if not UtilClient.is_unset(request.tenant):
            body['tenant'] = request.tenant
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
            action='UpdateRelationMetaField',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/relations/metas/fields',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.UpdateRelationMetaFieldResponse(),
            self.execute(params, req, runtime)
        )

    async def update_relation_meta_field_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.UpdateRelationMetaFieldRequest,
        headers: dingtalkcrm__1__0_models.UpdateRelationMetaFieldHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.UpdateRelationMetaFieldResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.field_dtolist):
            body['fieldDTOList'] = request.field_dtolist
        if not UtilClient.is_unset(request.operator_user_id):
            body['operatorUserId'] = request.operator_user_id
        if not UtilClient.is_unset(request.relation_type):
            body['relationType'] = request.relation_type
        if not UtilClient.is_unset(request.tenant):
            body['tenant'] = request.tenant
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
            action='UpdateRelationMetaField',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/relations/metas/fields',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.UpdateRelationMetaFieldResponse(),
            await self.execute_async(params, req, runtime)
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
