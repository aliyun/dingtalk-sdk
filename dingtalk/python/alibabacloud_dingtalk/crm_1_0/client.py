# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

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
    def __init__(
        self, 
        config: open_api_models.Config,
    ):
        super().__init__(config)
        gateway_client = GatewayClientClient()
        self._spi = gateway_client
        self._endpoint_rule = ''
        if UtilClient.empty(self._endpoint):
            self._endpoint = 'api.dingtalk.com'

    def abandon_customer_with_options(
        self,
        request: dingtalkcrm__1__0_models.AbandonCustomerRequest,
        headers: dingtalkcrm__1__0_models.AbandonCustomerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.AbandonCustomerResponse:
        """
        @summary 从私海放弃客户（退回公海）
        
        @param request: AbandonCustomerRequest
        @param headers: AbandonCustomerHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AbandonCustomerResponse
        """
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
        """
        @summary 从私海放弃客户（退回公海）
        
        @param request: AbandonCustomerRequest
        @param headers: AbandonCustomerHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AbandonCustomerResponse
        """
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
        """
        @summary 从私海放弃客户（退回公海）
        
        @param request: AbandonCustomerRequest
        @return: AbandonCustomerResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.AbandonCustomerHeaders()
        return self.abandon_customer_with_options(request, headers, runtime)

    async def abandon_customer_async(
        self,
        request: dingtalkcrm__1__0_models.AbandonCustomerRequest,
    ) -> dingtalkcrm__1__0_models.AbandonCustomerResponse:
        """
        @summary 从私海放弃客户（退回公海）
        
        @param request: AbandonCustomerRequest
        @return: AbandonCustomerResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.AbandonCustomerHeaders()
        return await self.abandon_customer_with_options_async(request, headers, runtime)

    def add_crm_personal_customer_with_options(
        self,
        request: dingtalkcrm__1__0_models.AddCrmPersonalCustomerRequest,
        headers: dingtalkcrm__1__0_models.AddCrmPersonalCustomerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.AddCrmPersonalCustomerResponse:
        """
        @summary 添加crm个人客户（或企业客户）
        
        @param request: AddCrmPersonalCustomerRequest
        @param headers: AddCrmPersonalCustomerHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddCrmPersonalCustomerResponse
        """
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
        """
        @summary 添加crm个人客户（或企业客户）
        
        @param request: AddCrmPersonalCustomerRequest
        @param headers: AddCrmPersonalCustomerHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddCrmPersonalCustomerResponse
        """
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
        """
        @summary 添加crm个人客户（或企业客户）
        
        @param request: AddCrmPersonalCustomerRequest
        @return: AddCrmPersonalCustomerResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.AddCrmPersonalCustomerHeaders()
        return self.add_crm_personal_customer_with_options(request, headers, runtime)

    async def add_crm_personal_customer_async(
        self,
        request: dingtalkcrm__1__0_models.AddCrmPersonalCustomerRequest,
    ) -> dingtalkcrm__1__0_models.AddCrmPersonalCustomerResponse:
        """
        @summary 添加crm个人客户（或企业客户）
        
        @param request: AddCrmPersonalCustomerRequest
        @return: AddCrmPersonalCustomerResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.AddCrmPersonalCustomerHeaders()
        return await self.add_crm_personal_customer_with_options_async(request, headers, runtime)

    def add_customer_track_with_options(
        self,
        request: dingtalkcrm__1__0_models.AddCustomerTrackRequest,
        headers: dingtalkcrm__1__0_models.AddCustomerTrackHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.AddCustomerTrackResponse:
        """
        @summary 新增动态
        
        @param request: AddCustomerTrackRequest
        @param headers: AddCustomerTrackHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddCustomerTrackResponse
        """
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
        """
        @summary 新增动态
        
        @param request: AddCustomerTrackRequest
        @param headers: AddCustomerTrackHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddCustomerTrackResponse
        """
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
        """
        @summary 新增动态
        
        @param request: AddCustomerTrackRequest
        @return: AddCustomerTrackResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.AddCustomerTrackHeaders()
        return self.add_customer_track_with_options(request, headers, runtime)

    async def add_customer_track_async(
        self,
        request: dingtalkcrm__1__0_models.AddCustomerTrackRequest,
    ) -> dingtalkcrm__1__0_models.AddCustomerTrackResponse:
        """
        @summary 新增动态
        
        @param request: AddCustomerTrackRequest
        @return: AddCustomerTrackResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.AddCustomerTrackHeaders()
        return await self.add_customer_track_with_options_async(request, headers, runtime)

    def add_leads_with_options(
        self,
        request: dingtalkcrm__1__0_models.AddLeadsRequest,
        headers: dingtalkcrm__1__0_models.AddLeadsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.AddLeadsResponse:
        """
        @summary 添加线索
        
        @param request: AddLeadsRequest
        @param headers: AddLeadsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddLeadsResponse
        """
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
        """
        @summary 添加线索
        
        @param request: AddLeadsRequest
        @param headers: AddLeadsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddLeadsResponse
        """
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
        """
        @summary 添加线索
        
        @param request: AddLeadsRequest
        @return: AddLeadsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.AddLeadsHeaders()
        return self.add_leads_with_options(request, headers, runtime)

    async def add_leads_async(
        self,
        request: dingtalkcrm__1__0_models.AddLeadsRequest,
    ) -> dingtalkcrm__1__0_models.AddLeadsResponse:
        """
        @summary 添加线索
        
        @param request: AddLeadsRequest
        @return: AddLeadsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.AddLeadsHeaders()
        return await self.add_leads_with_options_async(request, headers, runtime)

    def add_meta_model_field_with_options(
        self,
        request: dingtalkcrm__1__0_models.AddMetaModelFieldRequest,
        headers: dingtalkcrm__1__0_models.AddMetaModelFieldHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.AddMetaModelFieldResponse:
        """
        @summary 模型表结构增加字段
        
        @param request: AddMetaModelFieldRequest
        @param headers: AddMetaModelFieldHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddMetaModelFieldResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_type):
            body['bizType'] = request.biz_type
        if not UtilClient.is_unset(request.field_dtolist):
            body['fieldDTOList'] = request.field_dtolist
        if not UtilClient.is_unset(request.operator_user_id):
            body['operatorUserId'] = request.operator_user_id
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
            action='AddMetaModelField',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/metas/models/fields',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.AddMetaModelFieldResponse(),
            self.execute(params, req, runtime)
        )

    async def add_meta_model_field_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.AddMetaModelFieldRequest,
        headers: dingtalkcrm__1__0_models.AddMetaModelFieldHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.AddMetaModelFieldResponse:
        """
        @summary 模型表结构增加字段
        
        @param request: AddMetaModelFieldRequest
        @param headers: AddMetaModelFieldHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddMetaModelFieldResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_type):
            body['bizType'] = request.biz_type
        if not UtilClient.is_unset(request.field_dtolist):
            body['fieldDTOList'] = request.field_dtolist
        if not UtilClient.is_unset(request.operator_user_id):
            body['operatorUserId'] = request.operator_user_id
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
            action='AddMetaModelField',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/metas/models/fields',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.AddMetaModelFieldResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_meta_model_field(
        self,
        request: dingtalkcrm__1__0_models.AddMetaModelFieldRequest,
    ) -> dingtalkcrm__1__0_models.AddMetaModelFieldResponse:
        """
        @summary 模型表结构增加字段
        
        @param request: AddMetaModelFieldRequest
        @return: AddMetaModelFieldResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.AddMetaModelFieldHeaders()
        return self.add_meta_model_field_with_options(request, headers, runtime)

    async def add_meta_model_field_async(
        self,
        request: dingtalkcrm__1__0_models.AddMetaModelFieldRequest,
    ) -> dingtalkcrm__1__0_models.AddMetaModelFieldResponse:
        """
        @summary 模型表结构增加字段
        
        @param request: AddMetaModelFieldRequest
        @return: AddMetaModelFieldResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.AddMetaModelFieldHeaders()
        return await self.add_meta_model_field_with_options_async(request, headers, runtime)

    def add_relation_meta_field_with_options(
        self,
        request: dingtalkcrm__1__0_models.AddRelationMetaFieldRequest,
        headers: dingtalkcrm__1__0_models.AddRelationMetaFieldHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.AddRelationMetaFieldResponse:
        """
        @summary 关系模型表结构增加字段
        
        @param request: AddRelationMetaFieldRequest
        @param headers: AddRelationMetaFieldHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddRelationMetaFieldResponse
        """
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
        """
        @summary 关系模型表结构增加字段
        
        @param request: AddRelationMetaFieldRequest
        @param headers: AddRelationMetaFieldHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddRelationMetaFieldResponse
        """
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
        """
        @summary 关系模型表结构增加字段
        
        @param request: AddRelationMetaFieldRequest
        @return: AddRelationMetaFieldResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.AddRelationMetaFieldHeaders()
        return self.add_relation_meta_field_with_options(request, headers, runtime)

    async def add_relation_meta_field_async(
        self,
        request: dingtalkcrm__1__0_models.AddRelationMetaFieldRequest,
    ) -> dingtalkcrm__1__0_models.AddRelationMetaFieldResponse:
        """
        @summary 关系模型表结构增加字段
        
        @param request: AddRelationMetaFieldRequest
        @return: AddRelationMetaFieldResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.AddRelationMetaFieldHeaders()
        return await self.add_relation_meta_field_with_options_async(request, headers, runtime)

    def append_customer_data_auth_with_options(
        self,
        request: dingtalkcrm__1__0_models.AppendCustomerDataAuthRequest,
        headers: dingtalkcrm__1__0_models.AppendCustomerDataAuthHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.AppendCustomerDataAuthResponse:
        """
        @summary 追加客户数据权限
        
        @param request: AppendCustomerDataAuthRequest
        @param headers: AppendCustomerDataAuthHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AppendCustomerDataAuthResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.customer_ids):
            body['customerIds'] = request.customer_ids
        if not UtilClient.is_unset(request.data_auth_user_ids):
            body['dataAuthUserIds'] = request.data_auth_user_ids
        if not UtilClient.is_unset(request.form_code):
            body['formCode'] = request.form_code
        if not UtilClient.is_unset(request.operate_user_id):
            body['operateUserId'] = request.operate_user_id
        if not UtilClient.is_unset(request.relation_type):
            body['relationType'] = request.relation_type
        if not UtilClient.is_unset(request.role_type):
            body['roleType'] = request.role_type
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
            action='AppendCustomerDataAuth',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/customers/dataAuth/append',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.AppendCustomerDataAuthResponse(),
            self.execute(params, req, runtime)
        )

    async def append_customer_data_auth_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.AppendCustomerDataAuthRequest,
        headers: dingtalkcrm__1__0_models.AppendCustomerDataAuthHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.AppendCustomerDataAuthResponse:
        """
        @summary 追加客户数据权限
        
        @param request: AppendCustomerDataAuthRequest
        @param headers: AppendCustomerDataAuthHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AppendCustomerDataAuthResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.customer_ids):
            body['customerIds'] = request.customer_ids
        if not UtilClient.is_unset(request.data_auth_user_ids):
            body['dataAuthUserIds'] = request.data_auth_user_ids
        if not UtilClient.is_unset(request.form_code):
            body['formCode'] = request.form_code
        if not UtilClient.is_unset(request.operate_user_id):
            body['operateUserId'] = request.operate_user_id
        if not UtilClient.is_unset(request.relation_type):
            body['relationType'] = request.relation_type
        if not UtilClient.is_unset(request.role_type):
            body['roleType'] = request.role_type
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
            action='AppendCustomerDataAuth',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/customers/dataAuth/append',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.AppendCustomerDataAuthResponse(),
            await self.execute_async(params, req, runtime)
        )

    def append_customer_data_auth(
        self,
        request: dingtalkcrm__1__0_models.AppendCustomerDataAuthRequest,
    ) -> dingtalkcrm__1__0_models.AppendCustomerDataAuthResponse:
        """
        @summary 追加客户数据权限
        
        @param request: AppendCustomerDataAuthRequest
        @return: AppendCustomerDataAuthResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.AppendCustomerDataAuthHeaders()
        return self.append_customer_data_auth_with_options(request, headers, runtime)

    async def append_customer_data_auth_async(
        self,
        request: dingtalkcrm__1__0_models.AppendCustomerDataAuthRequest,
    ) -> dingtalkcrm__1__0_models.AppendCustomerDataAuthResponse:
        """
        @summary 追加客户数据权限
        
        @param request: AppendCustomerDataAuthRequest
        @return: AppendCustomerDataAuthResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.AppendCustomerDataAuthHeaders()
        return await self.append_customer_data_auth_with_options_async(request, headers, runtime)

    def batch_add_contacts_with_options(
        self,
        request: dingtalkcrm__1__0_models.BatchAddContactsRequest,
        headers: dingtalkcrm__1__0_models.BatchAddContactsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.BatchAddContactsResponse:
        """
        @summary 批量新增联系人
        
        @param request: BatchAddContactsRequest
        @param headers: BatchAddContactsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchAddContactsResponse
        """
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
        """
        @summary 批量新增联系人
        
        @param request: BatchAddContactsRequest
        @param headers: BatchAddContactsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchAddContactsResponse
        """
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
        """
        @summary 批量新增联系人
        
        @param request: BatchAddContactsRequest
        @return: BatchAddContactsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.BatchAddContactsHeaders()
        return self.batch_add_contacts_with_options(request, headers, runtime)

    async def batch_add_contacts_async(
        self,
        request: dingtalkcrm__1__0_models.BatchAddContactsRequest,
    ) -> dingtalkcrm__1__0_models.BatchAddContactsResponse:
        """
        @summary 批量新增联系人
        
        @param request: BatchAddContactsRequest
        @return: BatchAddContactsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.BatchAddContactsHeaders()
        return await self.batch_add_contacts_with_options_async(request, headers, runtime)

    def batch_add_follow_records_with_options(
        self,
        request: dingtalkcrm__1__0_models.BatchAddFollowRecordsRequest,
        headers: dingtalkcrm__1__0_models.BatchAddFollowRecordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.BatchAddFollowRecordsResponse:
        """
        @summary 批量新增跟进记录
        
        @param request: BatchAddFollowRecordsRequest
        @param headers: BatchAddFollowRecordsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchAddFollowRecordsResponse
        """
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
        """
        @summary 批量新增跟进记录
        
        @param request: BatchAddFollowRecordsRequest
        @param headers: BatchAddFollowRecordsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchAddFollowRecordsResponse
        """
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
        """
        @summary 批量新增跟进记录
        
        @param request: BatchAddFollowRecordsRequest
        @return: BatchAddFollowRecordsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.BatchAddFollowRecordsHeaders()
        return self.batch_add_follow_records_with_options(request, headers, runtime)

    async def batch_add_follow_records_async(
        self,
        request: dingtalkcrm__1__0_models.BatchAddFollowRecordsRequest,
    ) -> dingtalkcrm__1__0_models.BatchAddFollowRecordsResponse:
        """
        @summary 批量新增跟进记录
        
        @param request: BatchAddFollowRecordsRequest
        @return: BatchAddFollowRecordsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.BatchAddFollowRecordsHeaders()
        return await self.batch_add_follow_records_with_options_async(request, headers, runtime)

    def batch_add_relation_datas_with_options(
        self,
        request: dingtalkcrm__1__0_models.BatchAddRelationDatasRequest,
        headers: dingtalkcrm__1__0_models.BatchAddRelationDatasHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.BatchAddRelationDatasResponse:
        """
        @summary 批量新增关系数据
        
        @param request: BatchAddRelationDatasRequest
        @param headers: BatchAddRelationDatasHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchAddRelationDatasResponse
        """
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
        """
        @summary 批量新增关系数据
        
        @param request: BatchAddRelationDatasRequest
        @param headers: BatchAddRelationDatasHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchAddRelationDatasResponse
        """
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
        """
        @summary 批量新增关系数据
        
        @param request: BatchAddRelationDatasRequest
        @return: BatchAddRelationDatasResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.BatchAddRelationDatasHeaders()
        return self.batch_add_relation_datas_with_options(request, headers, runtime)

    async def batch_add_relation_datas_async(
        self,
        request: dingtalkcrm__1__0_models.BatchAddRelationDatasRequest,
    ) -> dingtalkcrm__1__0_models.BatchAddRelationDatasResponse:
        """
        @summary 批量新增关系数据
        
        @param request: BatchAddRelationDatasRequest
        @return: BatchAddRelationDatasResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.BatchAddRelationDatasHeaders()
        return await self.batch_add_relation_datas_with_options_async(request, headers, runtime)

    def batch_create_clue_data_with_options(
        self,
        request: dingtalkcrm__1__0_models.BatchCreateClueDataRequest,
        headers: dingtalkcrm__1__0_models.BatchCreateClueDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.BatchCreateClueDataResponse:
        """
        @summary 批量创建线索数据
        
        @param request: BatchCreateClueDataRequest
        @param headers: BatchCreateClueDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchCreateClueDataResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.data_list):
            body['dataList'] = request.data_list
        if not UtilClient.is_unset(request.private_seas):
            body['privateSeas'] = request.private_seas
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='BatchCreateClueData',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/clues/datas/batch',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.BatchCreateClueDataResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_create_clue_data_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.BatchCreateClueDataRequest,
        headers: dingtalkcrm__1__0_models.BatchCreateClueDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.BatchCreateClueDataResponse:
        """
        @summary 批量创建线索数据
        
        @param request: BatchCreateClueDataRequest
        @param headers: BatchCreateClueDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchCreateClueDataResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.data_list):
            body['dataList'] = request.data_list
        if not UtilClient.is_unset(request.private_seas):
            body['privateSeas'] = request.private_seas
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='BatchCreateClueData',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/clues/datas/batch',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.BatchCreateClueDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch_create_clue_data(
        self,
        request: dingtalkcrm__1__0_models.BatchCreateClueDataRequest,
    ) -> dingtalkcrm__1__0_models.BatchCreateClueDataResponse:
        """
        @summary 批量创建线索数据
        
        @param request: BatchCreateClueDataRequest
        @return: BatchCreateClueDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.BatchCreateClueDataHeaders()
        return self.batch_create_clue_data_with_options(request, headers, runtime)

    async def batch_create_clue_data_async(
        self,
        request: dingtalkcrm__1__0_models.BatchCreateClueDataRequest,
    ) -> dingtalkcrm__1__0_models.BatchCreateClueDataResponse:
        """
        @summary 批量创建线索数据
        
        @param request: BatchCreateClueDataRequest
        @return: BatchCreateClueDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.BatchCreateClueDataHeaders()
        return await self.batch_create_clue_data_with_options_async(request, headers, runtime)

    def batch_remove_follow_records_with_options(
        self,
        request: dingtalkcrm__1__0_models.BatchRemoveFollowRecordsRequest,
        headers: dingtalkcrm__1__0_models.BatchRemoveFollowRecordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.BatchRemoveFollowRecordsResponse:
        """
        @summary 批量删除跟进记录
        
        @param request: BatchRemoveFollowRecordsRequest
        @param headers: BatchRemoveFollowRecordsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchRemoveFollowRecordsResponse
        """
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
        """
        @summary 批量删除跟进记录
        
        @param request: BatchRemoveFollowRecordsRequest
        @param headers: BatchRemoveFollowRecordsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchRemoveFollowRecordsResponse
        """
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
        """
        @summary 批量删除跟进记录
        
        @param request: BatchRemoveFollowRecordsRequest
        @return: BatchRemoveFollowRecordsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.BatchRemoveFollowRecordsHeaders()
        return self.batch_remove_follow_records_with_options(request, headers, runtime)

    async def batch_remove_follow_records_async(
        self,
        request: dingtalkcrm__1__0_models.BatchRemoveFollowRecordsRequest,
    ) -> dingtalkcrm__1__0_models.BatchRemoveFollowRecordsResponse:
        """
        @summary 批量删除跟进记录
        
        @param request: BatchRemoveFollowRecordsRequest
        @return: BatchRemoveFollowRecordsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.BatchRemoveFollowRecordsHeaders()
        return await self.batch_remove_follow_records_with_options_async(request, headers, runtime)

    def batch_send_official_account_otomessage_with_options(
        self,
        request: dingtalkcrm__1__0_models.BatchSendOfficialAccountOTOMessageRequest,
        headers: dingtalkcrm__1__0_models.BatchSendOfficialAccountOTOMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.BatchSendOfficialAccountOTOMessageResponse:
        """
        @summary 服务窗消息群发
        
        @param request: BatchSendOfficialAccountOTOMessageRequest
        @param headers: BatchSendOfficialAccountOTOMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchSendOfficialAccountOTOMessageResponse
        """
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
        """
        @summary 服务窗消息群发
        
        @param request: BatchSendOfficialAccountOTOMessageRequest
        @param headers: BatchSendOfficialAccountOTOMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchSendOfficialAccountOTOMessageResponse
        """
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
        """
        @summary 服务窗消息群发
        
        @param request: BatchSendOfficialAccountOTOMessageRequest
        @return: BatchSendOfficialAccountOTOMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.BatchSendOfficialAccountOTOMessageHeaders()
        return self.batch_send_official_account_otomessage_with_options(request, headers, runtime)

    async def batch_send_official_account_otomessage_async(
        self,
        request: dingtalkcrm__1__0_models.BatchSendOfficialAccountOTOMessageRequest,
    ) -> dingtalkcrm__1__0_models.BatchSendOfficialAccountOTOMessageResponse:
        """
        @summary 服务窗消息群发
        
        @param request: BatchSendOfficialAccountOTOMessageRequest
        @return: BatchSendOfficialAccountOTOMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.BatchSendOfficialAccountOTOMessageHeaders()
        return await self.batch_send_official_account_otomessage_with_options_async(request, headers, runtime)

    def batch_update_contacts_with_options(
        self,
        request: dingtalkcrm__1__0_models.BatchUpdateContactsRequest,
        headers: dingtalkcrm__1__0_models.BatchUpdateContactsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.BatchUpdateContactsResponse:
        """
        @summary 批量修改联系人
        
        @param request: BatchUpdateContactsRequest
        @param headers: BatchUpdateContactsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchUpdateContactsResponse
        """
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
        """
        @summary 批量修改联系人
        
        @param request: BatchUpdateContactsRequest
        @param headers: BatchUpdateContactsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchUpdateContactsResponse
        """
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
        """
        @summary 批量修改联系人
        
        @param request: BatchUpdateContactsRequest
        @return: BatchUpdateContactsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.BatchUpdateContactsHeaders()
        return self.batch_update_contacts_with_options(request, headers, runtime)

    async def batch_update_contacts_async(
        self,
        request: dingtalkcrm__1__0_models.BatchUpdateContactsRequest,
    ) -> dingtalkcrm__1__0_models.BatchUpdateContactsResponse:
        """
        @summary 批量修改联系人
        
        @param request: BatchUpdateContactsRequest
        @return: BatchUpdateContactsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.BatchUpdateContactsHeaders()
        return await self.batch_update_contacts_with_options_async(request, headers, runtime)

    def batch_update_follow_records_with_options(
        self,
        request: dingtalkcrm__1__0_models.BatchUpdateFollowRecordsRequest,
        headers: dingtalkcrm__1__0_models.BatchUpdateFollowRecordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.BatchUpdateFollowRecordsResponse:
        """
        @summary 批量修改跟进记录
        
        @param request: BatchUpdateFollowRecordsRequest
        @param headers: BatchUpdateFollowRecordsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchUpdateFollowRecordsResponse
        """
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
        """
        @summary 批量修改跟进记录
        
        @param request: BatchUpdateFollowRecordsRequest
        @param headers: BatchUpdateFollowRecordsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchUpdateFollowRecordsResponse
        """
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
        """
        @summary 批量修改跟进记录
        
        @param request: BatchUpdateFollowRecordsRequest
        @return: BatchUpdateFollowRecordsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.BatchUpdateFollowRecordsHeaders()
        return self.batch_update_follow_records_with_options(request, headers, runtime)

    async def batch_update_follow_records_async(
        self,
        request: dingtalkcrm__1__0_models.BatchUpdateFollowRecordsRequest,
    ) -> dingtalkcrm__1__0_models.BatchUpdateFollowRecordsResponse:
        """
        @summary 批量修改跟进记录
        
        @param request: BatchUpdateFollowRecordsRequest
        @return: BatchUpdateFollowRecordsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.BatchUpdateFollowRecordsHeaders()
        return await self.batch_update_follow_records_with_options_async(request, headers, runtime)

    def batch_update_relation_datas_with_options(
        self,
        request: dingtalkcrm__1__0_models.BatchUpdateRelationDatasRequest,
        headers: dingtalkcrm__1__0_models.BatchUpdateRelationDatasHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.BatchUpdateRelationDatasResponse:
        """
        @summary 批量修改关系数据
        
        @param request: BatchUpdateRelationDatasRequest
        @param headers: BatchUpdateRelationDatasHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchUpdateRelationDatasResponse
        """
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
        """
        @summary 批量修改关系数据
        
        @param request: BatchUpdateRelationDatasRequest
        @param headers: BatchUpdateRelationDatasHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchUpdateRelationDatasResponse
        """
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
        """
        @summary 批量修改关系数据
        
        @param request: BatchUpdateRelationDatasRequest
        @return: BatchUpdateRelationDatasResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.BatchUpdateRelationDatasHeaders()
        return self.batch_update_relation_datas_with_options(request, headers, runtime)

    async def batch_update_relation_datas_async(
        self,
        request: dingtalkcrm__1__0_models.BatchUpdateRelationDatasRequest,
    ) -> dingtalkcrm__1__0_models.BatchUpdateRelationDatasResponse:
        """
        @summary 批量修改关系数据
        
        @param request: BatchUpdateRelationDatasRequest
        @return: BatchUpdateRelationDatasResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.BatchUpdateRelationDatasHeaders()
        return await self.batch_update_relation_datas_with_options_async(request, headers, runtime)

    def consume_benefit_inventory_with_options(
        self,
        request: dingtalkcrm__1__0_models.ConsumeBenefitInventoryRequest,
        headers: dingtalkcrm__1__0_models.ConsumeBenefitInventoryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.ConsumeBenefitInventoryResponse:
        """
        @summary 核销权益库存
        
        @param request: ConsumeBenefitInventoryRequest
        @param headers: ConsumeBenefitInventoryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ConsumeBenefitInventoryResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.benefit_code):
            body['benefitCode'] = request.benefit_code
        if not UtilClient.is_unset(request.biz_request_id):
            body['bizRequestId'] = request.biz_request_id
        if not UtilClient.is_unset(request.consume_quota):
            body['consumeQuota'] = request.consume_quota
        if not UtilClient.is_unset(request.opt_user_id):
            body['optUserId'] = request.opt_user_id
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
            action='ConsumeBenefitInventory',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/benefitInventories/consume',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.ConsumeBenefitInventoryResponse(),
            self.execute(params, req, runtime)
        )

    async def consume_benefit_inventory_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.ConsumeBenefitInventoryRequest,
        headers: dingtalkcrm__1__0_models.ConsumeBenefitInventoryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.ConsumeBenefitInventoryResponse:
        """
        @summary 核销权益库存
        
        @param request: ConsumeBenefitInventoryRequest
        @param headers: ConsumeBenefitInventoryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ConsumeBenefitInventoryResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.benefit_code):
            body['benefitCode'] = request.benefit_code
        if not UtilClient.is_unset(request.biz_request_id):
            body['bizRequestId'] = request.biz_request_id
        if not UtilClient.is_unset(request.consume_quota):
            body['consumeQuota'] = request.consume_quota
        if not UtilClient.is_unset(request.opt_user_id):
            body['optUserId'] = request.opt_user_id
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
            action='ConsumeBenefitInventory',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/benefitInventories/consume',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.ConsumeBenefitInventoryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def consume_benefit_inventory(
        self,
        request: dingtalkcrm__1__0_models.ConsumeBenefitInventoryRequest,
    ) -> dingtalkcrm__1__0_models.ConsumeBenefitInventoryResponse:
        """
        @summary 核销权益库存
        
        @param request: ConsumeBenefitInventoryRequest
        @return: ConsumeBenefitInventoryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.ConsumeBenefitInventoryHeaders()
        return self.consume_benefit_inventory_with_options(request, headers, runtime)

    async def consume_benefit_inventory_async(
        self,
        request: dingtalkcrm__1__0_models.ConsumeBenefitInventoryRequest,
    ) -> dingtalkcrm__1__0_models.ConsumeBenefitInventoryResponse:
        """
        @summary 核销权益库存
        
        @param request: ConsumeBenefitInventoryRequest
        @return: ConsumeBenefitInventoryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.ConsumeBenefitInventoryHeaders()
        return await self.consume_benefit_inventory_with_options_async(request, headers, runtime)

    def create_customer_with_options(
        self,
        request: dingtalkcrm__1__0_models.CreateCustomerRequest,
        headers: dingtalkcrm__1__0_models.CreateCustomerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.CreateCustomerResponse:
        """
        @summary CRM客户通讯录数据写入接口，支持客户&联系人数据合并写入
        
        @param request: CreateCustomerRequest
        @param headers: CreateCustomerHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateCustomerResponse
        """
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
        """
        @summary CRM客户通讯录数据写入接口，支持客户&联系人数据合并写入
        
        @param request: CreateCustomerRequest
        @param headers: CreateCustomerHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateCustomerResponse
        """
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
        """
        @summary CRM客户通讯录数据写入接口，支持客户&联系人数据合并写入
        
        @param request: CreateCustomerRequest
        @return: CreateCustomerResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.CreateCustomerHeaders()
        return self.create_customer_with_options(request, headers, runtime)

    async def create_customer_async(
        self,
        request: dingtalkcrm__1__0_models.CreateCustomerRequest,
    ) -> dingtalkcrm__1__0_models.CreateCustomerResponse:
        """
        @summary CRM客户通讯录数据写入接口，支持客户&联系人数据合并写入
        
        @param request: CreateCustomerRequest
        @return: CreateCustomerResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.CreateCustomerHeaders()
        return await self.create_customer_with_options_async(request, headers, runtime)

    def create_group_with_options(
        self,
        request: dingtalkcrm__1__0_models.CreateGroupRequest,
        headers: dingtalkcrm__1__0_models.CreateGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.CreateGroupResponse:
        """
        @summary 创建客户群
        
        @param request: CreateGroupRequest
        @param headers: CreateGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateGroupResponse
        """
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
        """
        @summary 创建客户群
        
        @param request: CreateGroupRequest
        @param headers: CreateGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateGroupResponse
        """
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
        """
        @summary 创建客户群
        
        @param request: CreateGroupRequest
        @return: CreateGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.CreateGroupHeaders()
        return self.create_group_with_options(request, headers, runtime)

    async def create_group_async(
        self,
        request: dingtalkcrm__1__0_models.CreateGroupRequest,
    ) -> dingtalkcrm__1__0_models.CreateGroupResponse:
        """
        @summary 创建客户群
        
        @param request: CreateGroupRequest
        @return: CreateGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.CreateGroupHeaders()
        return await self.create_group_with_options_async(request, headers, runtime)

    def create_group_set_with_options(
        self,
        request: dingtalkcrm__1__0_models.CreateGroupSetRequest,
        headers: dingtalkcrm__1__0_models.CreateGroupSetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.CreateGroupSetResponse:
        """
        @summary 创建群组
        
        @param request: CreateGroupSetRequest
        @param headers: CreateGroupSetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateGroupSetResponse
        """
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
        """
        @summary 创建群组
        
        @param request: CreateGroupSetRequest
        @param headers: CreateGroupSetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateGroupSetResponse
        """
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
        """
        @summary 创建群组
        
        @param request: CreateGroupSetRequest
        @return: CreateGroupSetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.CreateGroupSetHeaders()
        return self.create_group_set_with_options(request, headers, runtime)

    async def create_group_set_async(
        self,
        request: dingtalkcrm__1__0_models.CreateGroupSetRequest,
    ) -> dingtalkcrm__1__0_models.CreateGroupSetResponse:
        """
        @summary 创建群组
        
        @param request: CreateGroupSetRequest
        @return: CreateGroupSetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.CreateGroupSetHeaders()
        return await self.create_group_set_with_options_async(request, headers, runtime)

    def create_relation_meta_with_options(
        self,
        request: dingtalkcrm__1__0_models.CreateRelationMetaRequest,
        headers: dingtalkcrm__1__0_models.CreateRelationMetaHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.CreateRelationMetaResponse:
        """
        @summary 创建关系模型表结构
        
        @param request: CreateRelationMetaRequest
        @param headers: CreateRelationMetaHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateRelationMetaResponse
        """
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
        """
        @summary 创建关系模型表结构
        
        @param request: CreateRelationMetaRequest
        @param headers: CreateRelationMetaHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateRelationMetaResponse
        """
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
        """
        @summary 创建关系模型表结构
        
        @param request: CreateRelationMetaRequest
        @return: CreateRelationMetaResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.CreateRelationMetaHeaders()
        return self.create_relation_meta_with_options(request, headers, runtime)

    async def create_relation_meta_async(
        self,
        request: dingtalkcrm__1__0_models.CreateRelationMetaRequest,
    ) -> dingtalkcrm__1__0_models.CreateRelationMetaResponse:
        """
        @summary 创建关系模型表结构
        
        @param request: CreateRelationMetaRequest
        @return: CreateRelationMetaResponse
        """
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
        """
        @summary 删除CRM自定义对象数据
        
        @param request: DeleteCrmCustomObjectDataRequest
        @param headers: DeleteCrmCustomObjectDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteCrmCustomObjectDataResponse
        """
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
        """
        @summary 删除CRM自定义对象数据
        
        @param request: DeleteCrmCustomObjectDataRequest
        @param headers: DeleteCrmCustomObjectDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteCrmCustomObjectDataResponse
        """
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
        """
        @summary 删除CRM自定义对象数据
        
        @param request: DeleteCrmCustomObjectDataRequest
        @return: DeleteCrmCustomObjectDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.DeleteCrmCustomObjectDataHeaders()
        return self.delete_crm_custom_object_data_with_options(instance_id, request, headers, runtime)

    async def delete_crm_custom_object_data_async(
        self,
        instance_id: str,
        request: dingtalkcrm__1__0_models.DeleteCrmCustomObjectDataRequest,
    ) -> dingtalkcrm__1__0_models.DeleteCrmCustomObjectDataResponse:
        """
        @summary 删除CRM自定义对象数据
        
        @param request: DeleteCrmCustomObjectDataRequest
        @return: DeleteCrmCustomObjectDataResponse
        """
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
        """
        @summary crm自定义表单数据删除接口
        
        @param request: DeleteCrmFormInstanceRequest
        @param headers: DeleteCrmFormInstanceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteCrmFormInstanceResponse
        """
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
        """
        @summary crm自定义表单数据删除接口
        
        @param request: DeleteCrmFormInstanceRequest
        @param headers: DeleteCrmFormInstanceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteCrmFormInstanceResponse
        """
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
        """
        @summary crm自定义表单数据删除接口
        
        @param request: DeleteCrmFormInstanceRequest
        @return: DeleteCrmFormInstanceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.DeleteCrmFormInstanceHeaders()
        return self.delete_crm_form_instance_with_options(instance_id, request, headers, runtime)

    async def delete_crm_form_instance_async(
        self,
        instance_id: str,
        request: dingtalkcrm__1__0_models.DeleteCrmFormInstanceRequest,
    ) -> dingtalkcrm__1__0_models.DeleteCrmFormInstanceResponse:
        """
        @summary crm自定义表单数据删除接口
        
        @param request: DeleteCrmFormInstanceRequest
        @return: DeleteCrmFormInstanceResponse
        """
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
        """
        @summary 删除crm个人客户（或企业客户）
        
        @param request: DeleteCrmPersonalCustomerRequest
        @param headers: DeleteCrmPersonalCustomerHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteCrmPersonalCustomerResponse
        """
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
        """
        @summary 删除crm个人客户（或企业客户）
        
        @param request: DeleteCrmPersonalCustomerRequest
        @param headers: DeleteCrmPersonalCustomerHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteCrmPersonalCustomerResponse
        """
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
        """
        @summary 删除crm个人客户（或企业客户）
        
        @param request: DeleteCrmPersonalCustomerRequest
        @return: DeleteCrmPersonalCustomerResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.DeleteCrmPersonalCustomerHeaders()
        return self.delete_crm_personal_customer_with_options(data_id, request, headers, runtime)

    async def delete_crm_personal_customer_async(
        self,
        data_id: str,
        request: dingtalkcrm__1__0_models.DeleteCrmPersonalCustomerRequest,
    ) -> dingtalkcrm__1__0_models.DeleteCrmPersonalCustomerResponse:
        """
        @summary 删除crm个人客户（或企业客户）
        
        @param request: DeleteCrmPersonalCustomerRequest
        @return: DeleteCrmPersonalCustomerResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.DeleteCrmPersonalCustomerHeaders()
        return await self.delete_crm_personal_customer_with_options_async(data_id, request, headers, runtime)

    def delete_leads_with_options(
        self,
        request: dingtalkcrm__1__0_models.DeleteLeadsRequest,
        headers: dingtalkcrm__1__0_models.DeleteLeadsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.DeleteLeadsResponse:
        """
        @summary 删除线索
        
        @param request: DeleteLeadsRequest
        @param headers: DeleteLeadsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteLeadsResponse
        """
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
        """
        @summary 删除线索
        
        @param request: DeleteLeadsRequest
        @param headers: DeleteLeadsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteLeadsResponse
        """
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
        """
        @summary 删除线索
        
        @param request: DeleteLeadsRequest
        @return: DeleteLeadsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.DeleteLeadsHeaders()
        return self.delete_leads_with_options(request, headers, runtime)

    async def delete_leads_async(
        self,
        request: dingtalkcrm__1__0_models.DeleteLeadsRequest,
    ) -> dingtalkcrm__1__0_models.DeleteLeadsResponse:
        """
        @summary 删除线索
        
        @param request: DeleteLeadsRequest
        @return: DeleteLeadsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.DeleteLeadsHeaders()
        return await self.delete_leads_with_options_async(request, headers, runtime)

    def delete_relation_meta_field_with_options(
        self,
        request: dingtalkcrm__1__0_models.DeleteRelationMetaFieldRequest,
        headers: dingtalkcrm__1__0_models.DeleteRelationMetaFieldHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.DeleteRelationMetaFieldResponse:
        """
        @summary 关系模型表结构删除字段
        
        @param request: DeleteRelationMetaFieldRequest
        @param headers: DeleteRelationMetaFieldHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteRelationMetaFieldResponse
        """
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
        """
        @summary 关系模型表结构删除字段
        
        @param request: DeleteRelationMetaFieldRequest
        @param headers: DeleteRelationMetaFieldHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteRelationMetaFieldResponse
        """
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
        """
        @summary 关系模型表结构删除字段
        
        @param request: DeleteRelationMetaFieldRequest
        @return: DeleteRelationMetaFieldResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.DeleteRelationMetaFieldHeaders()
        return self.delete_relation_meta_field_with_options(request, headers, runtime)

    async def delete_relation_meta_field_async(
        self,
        request: dingtalkcrm__1__0_models.DeleteRelationMetaFieldRequest,
    ) -> dingtalkcrm__1__0_models.DeleteRelationMetaFieldResponse:
        """
        @summary 关系模型表结构删除字段
        
        @param request: DeleteRelationMetaFieldRequest
        @return: DeleteRelationMetaFieldResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.DeleteRelationMetaFieldHeaders()
        return await self.delete_relation_meta_field_with_options_async(request, headers, runtime)

    def describe_crm_personal_customer_object_meta_with_options(
        self,
        request: dingtalkcrm__1__0_models.DescribeCrmPersonalCustomerObjectMetaRequest,
        headers: dingtalkcrm__1__0_models.DescribeCrmPersonalCustomerObjectMetaHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.DescribeCrmPersonalCustomerObjectMetaResponse:
        """
        @summary 获取CRM客户对象的元数据描述
        
        @param request: DescribeCrmPersonalCustomerObjectMetaRequest
        @param headers: DescribeCrmPersonalCustomerObjectMetaHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DescribeCrmPersonalCustomerObjectMetaResponse
        """
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
        """
        @summary 获取CRM客户对象的元数据描述
        
        @param request: DescribeCrmPersonalCustomerObjectMetaRequest
        @param headers: DescribeCrmPersonalCustomerObjectMetaHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DescribeCrmPersonalCustomerObjectMetaResponse
        """
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
        """
        @summary 获取CRM客户对象的元数据描述
        
        @param request: DescribeCrmPersonalCustomerObjectMetaRequest
        @return: DescribeCrmPersonalCustomerObjectMetaResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.DescribeCrmPersonalCustomerObjectMetaHeaders()
        return self.describe_crm_personal_customer_object_meta_with_options(request, headers, runtime)

    async def describe_crm_personal_customer_object_meta_async(
        self,
        request: dingtalkcrm__1__0_models.DescribeCrmPersonalCustomerObjectMetaRequest,
    ) -> dingtalkcrm__1__0_models.DescribeCrmPersonalCustomerObjectMetaResponse:
        """
        @summary 获取CRM客户对象的元数据描述
        
        @param request: DescribeCrmPersonalCustomerObjectMetaRequest
        @return: DescribeCrmPersonalCustomerObjectMetaResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.DescribeCrmPersonalCustomerObjectMetaHeaders()
        return await self.describe_crm_personal_customer_object_meta_with_options_async(request, headers, runtime)

    def describe_meta_model_with_options(
        self,
        request: dingtalkcrm__1__0_models.DescribeMetaModelRequest,
        headers: dingtalkcrm__1__0_models.DescribeMetaModelHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.DescribeMetaModelResponse:
        """
        @summary 查询模型表结构
        
        @param request: DescribeMetaModelRequest
        @param headers: DescribeMetaModelHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DescribeMetaModelResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_types):
            body['bizTypes'] = request.biz_types
        if not UtilClient.is_unset(request.operator_user_id):
            body['operatorUserId'] = request.operator_user_id
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
            action='DescribeMetaModel',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/metas/models/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.DescribeMetaModelResponse(),
            self.execute(params, req, runtime)
        )

    async def describe_meta_model_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.DescribeMetaModelRequest,
        headers: dingtalkcrm__1__0_models.DescribeMetaModelHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.DescribeMetaModelResponse:
        """
        @summary 查询模型表结构
        
        @param request: DescribeMetaModelRequest
        @param headers: DescribeMetaModelHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DescribeMetaModelResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_types):
            body['bizTypes'] = request.biz_types
        if not UtilClient.is_unset(request.operator_user_id):
            body['operatorUserId'] = request.operator_user_id
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
            action='DescribeMetaModel',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/metas/models/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.DescribeMetaModelResponse(),
            await self.execute_async(params, req, runtime)
        )

    def describe_meta_model(
        self,
        request: dingtalkcrm__1__0_models.DescribeMetaModelRequest,
    ) -> dingtalkcrm__1__0_models.DescribeMetaModelResponse:
        """
        @summary 查询模型表结构
        
        @param request: DescribeMetaModelRequest
        @return: DescribeMetaModelResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.DescribeMetaModelHeaders()
        return self.describe_meta_model_with_options(request, headers, runtime)

    async def describe_meta_model_async(
        self,
        request: dingtalkcrm__1__0_models.DescribeMetaModelRequest,
    ) -> dingtalkcrm__1__0_models.DescribeMetaModelResponse:
        """
        @summary 查询模型表结构
        
        @param request: DescribeMetaModelRequest
        @return: DescribeMetaModelResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.DescribeMetaModelHeaders()
        return await self.describe_meta_model_with_options_async(request, headers, runtime)

    def describe_relation_meta_with_options(
        self,
        request: dingtalkcrm__1__0_models.DescribeRelationMetaRequest,
        headers: dingtalkcrm__1__0_models.DescribeRelationMetaHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.DescribeRelationMetaResponse:
        """
        @summary 查询关系模型表结构
        
        @param request: DescribeRelationMetaRequest
        @param headers: DescribeRelationMetaHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DescribeRelationMetaResponse
        """
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
        """
        @summary 查询关系模型表结构
        
        @param request: DescribeRelationMetaRequest
        @param headers: DescribeRelationMetaHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DescribeRelationMetaResponse
        """
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
        """
        @summary 查询关系模型表结构
        
        @param request: DescribeRelationMetaRequest
        @return: DescribeRelationMetaResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.DescribeRelationMetaHeaders()
        return self.describe_relation_meta_with_options(request, headers, runtime)

    async def describe_relation_meta_async(
        self,
        request: dingtalkcrm__1__0_models.DescribeRelationMetaRequest,
    ) -> dingtalkcrm__1__0_models.DescribeRelationMetaResponse:
        """
        @summary 查询关系模型表结构
        
        @param request: DescribeRelationMetaRequest
        @return: DescribeRelationMetaResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.DescribeRelationMetaHeaders()
        return await self.describe_relation_meta_with_options_async(request, headers, runtime)

    def find_target_related_follow_records_with_options(
        self,
        request: dingtalkcrm__1__0_models.FindTargetRelatedFollowRecordsRequest,
        headers: dingtalkcrm__1__0_models.FindTargetRelatedFollowRecordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.FindTargetRelatedFollowRecordsResponse:
        """
        @summary 分页获取关联对象的跟进记录列表
        
        @param request: FindTargetRelatedFollowRecordsRequest
        @param headers: FindTargetRelatedFollowRecordsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: FindTargetRelatedFollowRecordsResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.follow_target_data_id):
            body['followTargetDataId'] = request.follow_target_data_id
        if not UtilClient.is_unset(request.follow_target_type):
            body['followTargetType'] = request.follow_target_type
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
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
            action='FindTargetRelatedFollowRecords',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/targetFollowRecords/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.FindTargetRelatedFollowRecordsResponse(),
            self.execute(params, req, runtime)
        )

    async def find_target_related_follow_records_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.FindTargetRelatedFollowRecordsRequest,
        headers: dingtalkcrm__1__0_models.FindTargetRelatedFollowRecordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.FindTargetRelatedFollowRecordsResponse:
        """
        @summary 分页获取关联对象的跟进记录列表
        
        @param request: FindTargetRelatedFollowRecordsRequest
        @param headers: FindTargetRelatedFollowRecordsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: FindTargetRelatedFollowRecordsResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.follow_target_data_id):
            body['followTargetDataId'] = request.follow_target_data_id
        if not UtilClient.is_unset(request.follow_target_type):
            body['followTargetType'] = request.follow_target_type
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
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
            action='FindTargetRelatedFollowRecords',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/targetFollowRecords/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.FindTargetRelatedFollowRecordsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def find_target_related_follow_records(
        self,
        request: dingtalkcrm__1__0_models.FindTargetRelatedFollowRecordsRequest,
    ) -> dingtalkcrm__1__0_models.FindTargetRelatedFollowRecordsResponse:
        """
        @summary 分页获取关联对象的跟进记录列表
        
        @param request: FindTargetRelatedFollowRecordsRequest
        @return: FindTargetRelatedFollowRecordsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.FindTargetRelatedFollowRecordsHeaders()
        return self.find_target_related_follow_records_with_options(request, headers, runtime)

    async def find_target_related_follow_records_async(
        self,
        request: dingtalkcrm__1__0_models.FindTargetRelatedFollowRecordsRequest,
    ) -> dingtalkcrm__1__0_models.FindTargetRelatedFollowRecordsResponse:
        """
        @summary 分页获取关联对象的跟进记录列表
        
        @param request: FindTargetRelatedFollowRecordsRequest
        @return: FindTargetRelatedFollowRecordsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.FindTargetRelatedFollowRecordsHeaders()
        return await self.find_target_related_follow_records_with_options_async(request, headers, runtime)

    def get_all_customer_recycles_with_options(
        self,
        request: dingtalkcrm__1__0_models.GetAllCustomerRecyclesRequest,
        headers: dingtalkcrm__1__0_models.GetAllCustomerRecyclesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.GetAllCustomerRecyclesResponse:
        """
        @summary 分页获取所有客户的掉保时间数据
        
        @param request: GetAllCustomerRecyclesRequest
        @param headers: GetAllCustomerRecyclesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAllCustomerRecyclesResponse
        """
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
        """
        @summary 分页获取所有客户的掉保时间数据
        
        @param request: GetAllCustomerRecyclesRequest
        @param headers: GetAllCustomerRecyclesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAllCustomerRecyclesResponse
        """
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
        """
        @summary 分页获取所有客户的掉保时间数据
        
        @param request: GetAllCustomerRecyclesRequest
        @return: GetAllCustomerRecyclesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.GetAllCustomerRecyclesHeaders()
        return self.get_all_customer_recycles_with_options(request, headers, runtime)

    async def get_all_customer_recycles_async(
        self,
        request: dingtalkcrm__1__0_models.GetAllCustomerRecyclesRequest,
    ) -> dingtalkcrm__1__0_models.GetAllCustomerRecyclesResponse:
        """
        @summary 分页获取所有客户的掉保时间数据
        
        @param request: GetAllCustomerRecyclesRequest
        @return: GetAllCustomerRecyclesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.GetAllCustomerRecyclesHeaders()
        return await self.get_all_customer_recycles_with_options_async(request, headers, runtime)

    def get_contacts_with_options(
        self,
        request: dingtalkcrm__1__0_models.GetContactsRequest,
        headers: dingtalkcrm__1__0_models.GetContactsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.GetContactsResponse:
        """
        @summary 根据指定条件查询联系人数据
        
        @param request: GetContactsRequest
        @param headers: GetContactsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetContactsResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.current_operator_user_id):
            body['currentOperatorUserId'] = request.current_operator_user_id
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.object_type):
            body['objectType'] = request.object_type
        if not UtilClient.is_unset(request.provider_corp_id):
            body['providerCorpId'] = request.provider_corp_id
        if not UtilClient.is_unset(request.query_dsl):
            body['queryDsl'] = request.query_dsl
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
            action='GetContacts',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/customObjects/contacts/datas/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.GetContactsResponse(),
            self.execute(params, req, runtime)
        )

    async def get_contacts_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.GetContactsRequest,
        headers: dingtalkcrm__1__0_models.GetContactsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.GetContactsResponse:
        """
        @summary 根据指定条件查询联系人数据
        
        @param request: GetContactsRequest
        @param headers: GetContactsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetContactsResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.current_operator_user_id):
            body['currentOperatorUserId'] = request.current_operator_user_id
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.object_type):
            body['objectType'] = request.object_type
        if not UtilClient.is_unset(request.provider_corp_id):
            body['providerCorpId'] = request.provider_corp_id
        if not UtilClient.is_unset(request.query_dsl):
            body['queryDsl'] = request.query_dsl
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
            action='GetContacts',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/customObjects/contacts/datas/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.GetContactsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_contacts(
        self,
        request: dingtalkcrm__1__0_models.GetContactsRequest,
    ) -> dingtalkcrm__1__0_models.GetContactsResponse:
        """
        @summary 根据指定条件查询联系人数据
        
        @param request: GetContactsRequest
        @return: GetContactsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.GetContactsHeaders()
        return self.get_contacts_with_options(request, headers, runtime)

    async def get_contacts_async(
        self,
        request: dingtalkcrm__1__0_models.GetContactsRequest,
    ) -> dingtalkcrm__1__0_models.GetContactsResponse:
        """
        @summary 根据指定条件查询联系人数据
        
        @param request: GetContactsRequest
        @return: GetContactsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.GetContactsHeaders()
        return await self.get_contacts_with_options_async(request, headers, runtime)

    def get_crm_group_chat_with_options(
        self,
        open_conversation_id: str,
        headers: dingtalkcrm__1__0_models.GetCrmGroupChatHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.GetCrmGroupChatResponse:
        """
        @summary 获取单个客户群
        
        @param headers: GetCrmGroupChatHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetCrmGroupChatResponse
        """
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
        """
        @summary 获取单个客户群
        
        @param headers: GetCrmGroupChatHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetCrmGroupChatResponse
        """
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
        """
        @summary 获取单个客户群
        
        @return: GetCrmGroupChatResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.GetCrmGroupChatHeaders()
        return self.get_crm_group_chat_with_options(open_conversation_id, headers, runtime)

    async def get_crm_group_chat_async(
        self,
        open_conversation_id: str,
    ) -> dingtalkcrm__1__0_models.GetCrmGroupChatResponse:
        """
        @summary 获取单个客户群
        
        @return: GetCrmGroupChatResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.GetCrmGroupChatHeaders()
        return await self.get_crm_group_chat_with_options_async(open_conversation_id, headers, runtime)

    def get_crm_group_chat_multi_with_options(
        self,
        request: dingtalkcrm__1__0_models.GetCrmGroupChatMultiRequest,
        headers: dingtalkcrm__1__0_models.GetCrmGroupChatMultiHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.GetCrmGroupChatMultiResponse:
        """
        @summary 批量获取多个客户群
        
        @param request: GetCrmGroupChatMultiRequest
        @param headers: GetCrmGroupChatMultiHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetCrmGroupChatMultiResponse
        """
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
        """
        @summary 批量获取多个客户群
        
        @param request: GetCrmGroupChatMultiRequest
        @param headers: GetCrmGroupChatMultiHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetCrmGroupChatMultiResponse
        """
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
        """
        @summary 批量获取多个客户群
        
        @param request: GetCrmGroupChatMultiRequest
        @return: GetCrmGroupChatMultiResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.GetCrmGroupChatMultiHeaders()
        return self.get_crm_group_chat_multi_with_options(request, headers, runtime)

    async def get_crm_group_chat_multi_async(
        self,
        request: dingtalkcrm__1__0_models.GetCrmGroupChatMultiRequest,
    ) -> dingtalkcrm__1__0_models.GetCrmGroupChatMultiResponse:
        """
        @summary 批量获取多个客户群
        
        @param request: GetCrmGroupChatMultiRequest
        @return: GetCrmGroupChatMultiResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.GetCrmGroupChatMultiHeaders()
        return await self.get_crm_group_chat_multi_with_options_async(request, headers, runtime)

    def get_crm_group_chat_single_with_options(
        self,
        request: dingtalkcrm__1__0_models.GetCrmGroupChatSingleRequest,
        headers: dingtalkcrm__1__0_models.GetCrmGroupChatSingleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.GetCrmGroupChatSingleResponse:
        """
        @summary 获取单个客户群
        
        @param request: GetCrmGroupChatSingleRequest
        @param headers: GetCrmGroupChatSingleHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetCrmGroupChatSingleResponse
        """
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
        """
        @summary 获取单个客户群
        
        @param request: GetCrmGroupChatSingleRequest
        @param headers: GetCrmGroupChatSingleHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetCrmGroupChatSingleResponse
        """
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
        """
        @summary 获取单个客户群
        
        @param request: GetCrmGroupChatSingleRequest
        @return: GetCrmGroupChatSingleResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.GetCrmGroupChatSingleHeaders()
        return self.get_crm_group_chat_single_with_options(request, headers, runtime)

    async def get_crm_group_chat_single_async(
        self,
        request: dingtalkcrm__1__0_models.GetCrmGroupChatSingleRequest,
    ) -> dingtalkcrm__1__0_models.GetCrmGroupChatSingleResponse:
        """
        @summary 获取单个客户群
        
        @param request: GetCrmGroupChatSingleRequest
        @return: GetCrmGroupChatSingleResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.GetCrmGroupChatSingleHeaders()
        return await self.get_crm_group_chat_single_with_options_async(request, headers, runtime)

    def get_crm_role_permission_with_options(
        self,
        request: dingtalkcrm__1__0_models.GetCrmRolePermissionRequest,
        headers: dingtalkcrm__1__0_models.GetCrmRolePermissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.GetCrmRolePermissionResponse:
        """
        @summary 获取CRM表单权限配置
        
        @param request: GetCrmRolePermissionRequest
        @param headers: GetCrmRolePermissionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetCrmRolePermissionResponse
        """
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
        """
        @summary 获取CRM表单权限配置
        
        @param request: GetCrmRolePermissionRequest
        @param headers: GetCrmRolePermissionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetCrmRolePermissionResponse
        """
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
        """
        @summary 获取CRM表单权限配置
        
        @param request: GetCrmRolePermissionRequest
        @return: GetCrmRolePermissionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.GetCrmRolePermissionHeaders()
        return self.get_crm_role_permission_with_options(request, headers, runtime)

    async def get_crm_role_permission_async(
        self,
        request: dingtalkcrm__1__0_models.GetCrmRolePermissionRequest,
    ) -> dingtalkcrm__1__0_models.GetCrmRolePermissionResponse:
        """
        @summary 获取CRM表单权限配置
        
        @param request: GetCrmRolePermissionRequest
        @return: GetCrmRolePermissionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.GetCrmRolePermissionHeaders()
        return await self.get_crm_role_permission_with_options_async(request, headers, runtime)

    def get_customer_tracks_by_relation_id_with_options(
        self,
        request: dingtalkcrm__1__0_models.GetCustomerTracksByRelationIdRequest,
        headers: dingtalkcrm__1__0_models.GetCustomerTracksByRelationIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.GetCustomerTracksByRelationIdResponse:
        """
        @summary 分页获取某个客户的客户动态
        
        @param request: GetCustomerTracksByRelationIdRequest
        @param headers: GetCustomerTracksByRelationIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetCustomerTracksByRelationIdResponse
        """
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
        """
        @summary 分页获取某个客户的客户动态
        
        @param request: GetCustomerTracksByRelationIdRequest
        @param headers: GetCustomerTracksByRelationIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetCustomerTracksByRelationIdResponse
        """
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
        """
        @summary 分页获取某个客户的客户动态
        
        @param request: GetCustomerTracksByRelationIdRequest
        @return: GetCustomerTracksByRelationIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.GetCustomerTracksByRelationIdHeaders()
        return self.get_customer_tracks_by_relation_id_with_options(request, headers, runtime)

    async def get_customer_tracks_by_relation_id_async(
        self,
        request: dingtalkcrm__1__0_models.GetCustomerTracksByRelationIdRequest,
    ) -> dingtalkcrm__1__0_models.GetCustomerTracksByRelationIdResponse:
        """
        @summary 分页获取某个客户的客户动态
        
        @param request: GetCustomerTracksByRelationIdRequest
        @return: GetCustomerTracksByRelationIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.GetCustomerTracksByRelationIdHeaders()
        return await self.get_customer_tracks_by_relation_id_with_options_async(request, headers, runtime)

    def get_group_set_with_options(
        self,
        request: dingtalkcrm__1__0_models.GetGroupSetRequest,
        headers: dingtalkcrm__1__0_models.GetGroupSetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.GetGroupSetResponse:
        """
        @summary 查询群组
        
        @param request: GetGroupSetRequest
        @param headers: GetGroupSetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetGroupSetResponse
        """
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
        """
        @summary 查询群组
        
        @param request: GetGroupSetRequest
        @param headers: GetGroupSetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetGroupSetResponse
        """
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
        """
        @summary 查询群组
        
        @param request: GetGroupSetRequest
        @return: GetGroupSetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.GetGroupSetHeaders()
        return self.get_group_set_with_options(request, headers, runtime)

    async def get_group_set_async(
        self,
        request: dingtalkcrm__1__0_models.GetGroupSetRequest,
    ) -> dingtalkcrm__1__0_models.GetGroupSetResponse:
        """
        @summary 查询群组
        
        @param request: GetGroupSetRequest
        @return: GetGroupSetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.GetGroupSetHeaders()
        return await self.get_group_set_with_options_async(request, headers, runtime)

    def get_in_app_purchase_goods_with_options(
        self,
        request: dingtalkcrm__1__0_models.GetInAppPurchaseGoodsRequest,
        headers: dingtalkcrm__1__0_models.GetInAppPurchaseGoodsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.GetInAppPurchaseGoodsResponse:
        """
        @summary 获取内购商品信息
        
        @param request: GetInAppPurchaseGoodsRequest
        @param headers: GetInAppPurchaseGoodsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetInAppPurchaseGoodsResponse
        """
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
            action='GetInAppPurchaseGoods',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/inAppPurchaseGoods/infos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.GetInAppPurchaseGoodsResponse(),
            self.execute(params, req, runtime)
        )

    async def get_in_app_purchase_goods_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.GetInAppPurchaseGoodsRequest,
        headers: dingtalkcrm__1__0_models.GetInAppPurchaseGoodsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.GetInAppPurchaseGoodsResponse:
        """
        @summary 获取内购商品信息
        
        @param request: GetInAppPurchaseGoodsRequest
        @param headers: GetInAppPurchaseGoodsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetInAppPurchaseGoodsResponse
        """
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
            action='GetInAppPurchaseGoods',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/inAppPurchaseGoods/infos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.GetInAppPurchaseGoodsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_in_app_purchase_goods(
        self,
        request: dingtalkcrm__1__0_models.GetInAppPurchaseGoodsRequest,
    ) -> dingtalkcrm__1__0_models.GetInAppPurchaseGoodsResponse:
        """
        @summary 获取内购商品信息
        
        @param request: GetInAppPurchaseGoodsRequest
        @return: GetInAppPurchaseGoodsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.GetInAppPurchaseGoodsHeaders()
        return self.get_in_app_purchase_goods_with_options(request, headers, runtime)

    async def get_in_app_purchase_goods_async(
        self,
        request: dingtalkcrm__1__0_models.GetInAppPurchaseGoodsRequest,
    ) -> dingtalkcrm__1__0_models.GetInAppPurchaseGoodsResponse:
        """
        @summary 获取内购商品信息
        
        @param request: GetInAppPurchaseGoodsRequest
        @return: GetInAppPurchaseGoodsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.GetInAppPurchaseGoodsHeaders()
        return await self.get_in_app_purchase_goods_with_options_async(request, headers, runtime)

    def get_navigation_catalog_with_options(
        self,
        request: dingtalkcrm__1__0_models.GetNavigationCatalogRequest,
        headers: dingtalkcrm__1__0_models.GetNavigationCatalogHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.GetNavigationCatalogResponse:
        """
        @summary 获取自定义导航挂靠节点结构
        
        @param request: GetNavigationCatalogRequest
        @param headers: GetNavigationCatalogHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetNavigationCatalogResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.biz_trace_id):
            query['bizTraceId'] = request.biz_trace_id
        if not UtilClient.is_unset(request.module):
            query['module'] = request.module
        if not UtilClient.is_unset(request.operator_user_id):
            query['operatorUserId'] = request.operator_user_id
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
            action='GetNavigationCatalog',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/navigations/catalogs',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.GetNavigationCatalogResponse(),
            self.execute(params, req, runtime)
        )

    async def get_navigation_catalog_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.GetNavigationCatalogRequest,
        headers: dingtalkcrm__1__0_models.GetNavigationCatalogHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.GetNavigationCatalogResponse:
        """
        @summary 获取自定义导航挂靠节点结构
        
        @param request: GetNavigationCatalogRequest
        @param headers: GetNavigationCatalogHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetNavigationCatalogResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.biz_trace_id):
            query['bizTraceId'] = request.biz_trace_id
        if not UtilClient.is_unset(request.module):
            query['module'] = request.module
        if not UtilClient.is_unset(request.operator_user_id):
            query['operatorUserId'] = request.operator_user_id
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
            action='GetNavigationCatalog',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/navigations/catalogs',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.GetNavigationCatalogResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_navigation_catalog(
        self,
        request: dingtalkcrm__1__0_models.GetNavigationCatalogRequest,
    ) -> dingtalkcrm__1__0_models.GetNavigationCatalogResponse:
        """
        @summary 获取自定义导航挂靠节点结构
        
        @param request: GetNavigationCatalogRequest
        @return: GetNavigationCatalogResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.GetNavigationCatalogHeaders()
        return self.get_navigation_catalog_with_options(request, headers, runtime)

    async def get_navigation_catalog_async(
        self,
        request: dingtalkcrm__1__0_models.GetNavigationCatalogRequest,
    ) -> dingtalkcrm__1__0_models.GetNavigationCatalogResponse:
        """
        @summary 获取自定义导航挂靠节点结构
        
        @param request: GetNavigationCatalogRequest
        @return: GetNavigationCatalogResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.GetNavigationCatalogHeaders()
        return await self.get_navigation_catalog_with_options_async(request, headers, runtime)

    def get_object_data_with_options(
        self,
        request: dingtalkcrm__1__0_models.GetObjectDataRequest,
        headers: dingtalkcrm__1__0_models.GetObjectDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.GetObjectDataResponse:
        """
        @summary 根据指定条件查询自定义对象数据
        
        @param request: GetObjectDataRequest
        @param headers: GetObjectDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetObjectDataResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.current_operator_user_id):
            body['currentOperatorUserId'] = request.current_operator_user_id
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.query_dsl):
            body['queryDsl'] = request.query_dsl
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
            action='GetObjectData',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/customObjects/datas/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.GetObjectDataResponse(),
            self.execute(params, req, runtime)
        )

    async def get_object_data_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.GetObjectDataRequest,
        headers: dingtalkcrm__1__0_models.GetObjectDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.GetObjectDataResponse:
        """
        @summary 根据指定条件查询自定义对象数据
        
        @param request: GetObjectDataRequest
        @param headers: GetObjectDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetObjectDataResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.current_operator_user_id):
            body['currentOperatorUserId'] = request.current_operator_user_id
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.query_dsl):
            body['queryDsl'] = request.query_dsl
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
            action='GetObjectData',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/customObjects/datas/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.GetObjectDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_object_data(
        self,
        request: dingtalkcrm__1__0_models.GetObjectDataRequest,
    ) -> dingtalkcrm__1__0_models.GetObjectDataResponse:
        """
        @summary 根据指定条件查询自定义对象数据
        
        @param request: GetObjectDataRequest
        @return: GetObjectDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.GetObjectDataHeaders()
        return self.get_object_data_with_options(request, headers, runtime)

    async def get_object_data_async(
        self,
        request: dingtalkcrm__1__0_models.GetObjectDataRequest,
    ) -> dingtalkcrm__1__0_models.GetObjectDataResponse:
        """
        @summary 根据指定条件查询自定义对象数据
        
        @param request: GetObjectDataRequest
        @return: GetObjectDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.GetObjectDataHeaders()
        return await self.get_object_data_with_options_async(request, headers, runtime)

    def get_official_account_contact_info_with_options(
        self,
        user_id: str,
        headers: dingtalkcrm__1__0_models.GetOfficialAccountContactInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.GetOfficialAccountContactInfoResponse:
        """
        @summary 获取关注服务窗的联系人信息，包括手机号、主企业等字段，调用前先进行用户授权
        
        @param headers: GetOfficialAccountContactInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetOfficialAccountContactInfoResponse
        """
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
        """
        @summary 获取关注服务窗的联系人信息，包括手机号、主企业等字段，调用前先进行用户授权
        
        @param headers: GetOfficialAccountContactInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetOfficialAccountContactInfoResponse
        """
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
        """
        @summary 获取关注服务窗的联系人信息，包括手机号、主企业等字段，调用前先进行用户授权
        
        @return: GetOfficialAccountContactInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.GetOfficialAccountContactInfoHeaders()
        return self.get_official_account_contact_info_with_options(user_id, headers, runtime)

    async def get_official_account_contact_info_async(
        self,
        user_id: str,
    ) -> dingtalkcrm__1__0_models.GetOfficialAccountContactInfoResponse:
        """
        @summary 获取关注服务窗的联系人信息，包括手机号、主企业等字段，调用前先进行用户授权
        
        @return: GetOfficialAccountContactInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.GetOfficialAccountContactInfoHeaders()
        return await self.get_official_account_contact_info_with_options_async(user_id, headers, runtime)

    def get_official_account_contacts_with_options(
        self,
        request: dingtalkcrm__1__0_models.GetOfficialAccountContactsRequest,
        headers: dingtalkcrm__1__0_models.GetOfficialAccountContactsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.GetOfficialAccountContactsResponse:
        """
        @summary 分页获取服务窗联系人信息
        
        @param request: GetOfficialAccountContactsRequest
        @param headers: GetOfficialAccountContactsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetOfficialAccountContactsResponse
        """
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
        """
        @summary 分页获取服务窗联系人信息
        
        @param request: GetOfficialAccountContactsRequest
        @param headers: GetOfficialAccountContactsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetOfficialAccountContactsResponse
        """
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
        """
        @summary 分页获取服务窗联系人信息
        
        @param request: GetOfficialAccountContactsRequest
        @return: GetOfficialAccountContactsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.GetOfficialAccountContactsHeaders()
        return self.get_official_account_contacts_with_options(request, headers, runtime)

    async def get_official_account_contacts_async(
        self,
        request: dingtalkcrm__1__0_models.GetOfficialAccountContactsRequest,
    ) -> dingtalkcrm__1__0_models.GetOfficialAccountContactsResponse:
        """
        @summary 分页获取服务窗联系人信息
        
        @param request: GetOfficialAccountContactsRequest
        @return: GetOfficialAccountContactsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.GetOfficialAccountContactsHeaders()
        return await self.get_official_account_contacts_with_options_async(request, headers, runtime)

    def get_official_account_otomessage_result_with_options(
        self,
        request: dingtalkcrm__1__0_models.GetOfficialAccountOTOMessageResultRequest,
        headers: dingtalkcrm__1__0_models.GetOfficialAccountOTOMessageResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.GetOfficialAccountOTOMessageResultResponse:
        """
        @summary 获取服务窗消息发送的结果
        
        @param request: GetOfficialAccountOTOMessageResultRequest
        @param headers: GetOfficialAccountOTOMessageResultHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetOfficialAccountOTOMessageResultResponse
        """
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
        """
        @summary 获取服务窗消息发送的结果
        
        @param request: GetOfficialAccountOTOMessageResultRequest
        @param headers: GetOfficialAccountOTOMessageResultHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetOfficialAccountOTOMessageResultResponse
        """
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
        """
        @summary 获取服务窗消息发送的结果
        
        @param request: GetOfficialAccountOTOMessageResultRequest
        @return: GetOfficialAccountOTOMessageResultResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.GetOfficialAccountOTOMessageResultHeaders()
        return self.get_official_account_otomessage_result_with_options(request, headers, runtime)

    async def get_official_account_otomessage_result_async(
        self,
        request: dingtalkcrm__1__0_models.GetOfficialAccountOTOMessageResultRequest,
    ) -> dingtalkcrm__1__0_models.GetOfficialAccountOTOMessageResultResponse:
        """
        @summary 获取服务窗消息发送的结果
        
        @param request: GetOfficialAccountOTOMessageResultRequest
        @return: GetOfficialAccountOTOMessageResultResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.GetOfficialAccountOTOMessageResultHeaders()
        return await self.get_official_account_otomessage_result_with_options_async(request, headers, runtime)

    def get_related_view_tab_data_with_options(
        self,
        request: dingtalkcrm__1__0_models.GetRelatedViewTabDataRequest,
        headers: dingtalkcrm__1__0_models.GetRelatedViewTabDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.GetRelatedViewTabDataResponse:
        """
        @summary 获取某个和oa关联的表单的具体数据
        
        @param request: GetRelatedViewTabDataRequest
        @param headers: GetRelatedViewTabDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetRelatedViewTabDataResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.form_code):
            body['formCode'] = request.form_code
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.related_field):
            body['relatedField'] = request.related_field
        if not UtilClient.is_unset(request.related_inst_id):
            body['relatedInstId'] = request.related_inst_id
        if not UtilClient.is_unset(request.view_user_id):
            body['viewUserId'] = request.view_user_id
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
            action='GetRelatedViewTabData',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/formRelatedTabs/datas/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.GetRelatedViewTabDataResponse(),
            self.execute(params, req, runtime)
        )

    async def get_related_view_tab_data_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.GetRelatedViewTabDataRequest,
        headers: dingtalkcrm__1__0_models.GetRelatedViewTabDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.GetRelatedViewTabDataResponse:
        """
        @summary 获取某个和oa关联的表单的具体数据
        
        @param request: GetRelatedViewTabDataRequest
        @param headers: GetRelatedViewTabDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetRelatedViewTabDataResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.form_code):
            body['formCode'] = request.form_code
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.related_field):
            body['relatedField'] = request.related_field
        if not UtilClient.is_unset(request.related_inst_id):
            body['relatedInstId'] = request.related_inst_id
        if not UtilClient.is_unset(request.view_user_id):
            body['viewUserId'] = request.view_user_id
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
            action='GetRelatedViewTabData',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/formRelatedTabs/datas/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.GetRelatedViewTabDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_related_view_tab_data(
        self,
        request: dingtalkcrm__1__0_models.GetRelatedViewTabDataRequest,
    ) -> dingtalkcrm__1__0_models.GetRelatedViewTabDataResponse:
        """
        @summary 获取某个和oa关联的表单的具体数据
        
        @param request: GetRelatedViewTabDataRequest
        @return: GetRelatedViewTabDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.GetRelatedViewTabDataHeaders()
        return self.get_related_view_tab_data_with_options(request, headers, runtime)

    async def get_related_view_tab_data_async(
        self,
        request: dingtalkcrm__1__0_models.GetRelatedViewTabDataRequest,
    ) -> dingtalkcrm__1__0_models.GetRelatedViewTabDataResponse:
        """
        @summary 获取某个和oa关联的表单的具体数据
        
        @param request: GetRelatedViewTabDataRequest
        @return: GetRelatedViewTabDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.GetRelatedViewTabDataHeaders()
        return await self.get_related_view_tab_data_with_options_async(request, headers, runtime)

    def get_related_view_tab_meta_with_options(
        self,
        request: dingtalkcrm__1__0_models.GetRelatedViewTabMetaRequest,
        headers: dingtalkcrm__1__0_models.GetRelatedViewTabMetaHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.GetRelatedViewTabMetaResponse:
        """
        @summary 获取和oa关联的表单tab信息
        
        @param request: GetRelatedViewTabMetaRequest
        @param headers: GetRelatedViewTabMetaHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetRelatedViewTabMetaResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.form_code):
            body['formCode'] = request.form_code
        if not UtilClient.is_unset(request.view_user_id):
            body['viewUserId'] = request.view_user_id
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
            action='GetRelatedViewTabMeta',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/formRelatedTabs/meta/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.GetRelatedViewTabMetaResponse(),
            self.execute(params, req, runtime)
        )

    async def get_related_view_tab_meta_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.GetRelatedViewTabMetaRequest,
        headers: dingtalkcrm__1__0_models.GetRelatedViewTabMetaHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.GetRelatedViewTabMetaResponse:
        """
        @summary 获取和oa关联的表单tab信息
        
        @param request: GetRelatedViewTabMetaRequest
        @param headers: GetRelatedViewTabMetaHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetRelatedViewTabMetaResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.form_code):
            body['formCode'] = request.form_code
        if not UtilClient.is_unset(request.view_user_id):
            body['viewUserId'] = request.view_user_id
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
            action='GetRelatedViewTabMeta',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/formRelatedTabs/meta/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.GetRelatedViewTabMetaResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_related_view_tab_meta(
        self,
        request: dingtalkcrm__1__0_models.GetRelatedViewTabMetaRequest,
    ) -> dingtalkcrm__1__0_models.GetRelatedViewTabMetaResponse:
        """
        @summary 获取和oa关联的表单tab信息
        
        @param request: GetRelatedViewTabMetaRequest
        @return: GetRelatedViewTabMetaResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.GetRelatedViewTabMetaHeaders()
        return self.get_related_view_tab_meta_with_options(request, headers, runtime)

    async def get_related_view_tab_meta_async(
        self,
        request: dingtalkcrm__1__0_models.GetRelatedViewTabMetaRequest,
    ) -> dingtalkcrm__1__0_models.GetRelatedViewTabMetaResponse:
        """
        @summary 获取和oa关联的表单tab信息
        
        @param request: GetRelatedViewTabMetaRequest
        @return: GetRelatedViewTabMetaResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.GetRelatedViewTabMetaHeaders()
        return await self.get_related_view_tab_meta_with_options_async(request, headers, runtime)

    def get_relation_uk_setting_with_options(
        self,
        request: dingtalkcrm__1__0_models.GetRelationUkSettingRequest,
        headers: dingtalkcrm__1__0_models.GetRelationUkSettingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.GetRelationUkSettingResponse:
        """
        @summary 获取关系数据查重规则
        
        @param request: GetRelationUkSettingRequest
        @param headers: GetRelationUkSettingHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetRelationUkSettingResponse
        """
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
        """
        @summary 获取关系数据查重规则
        
        @param request: GetRelationUkSettingRequest
        @param headers: GetRelationUkSettingHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetRelationUkSettingResponse
        """
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
        """
        @summary 获取关系数据查重规则
        
        @param request: GetRelationUkSettingRequest
        @return: GetRelationUkSettingResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.GetRelationUkSettingHeaders()
        return self.get_relation_uk_setting_with_options(request, headers, runtime)

    async def get_relation_uk_setting_async(
        self,
        request: dingtalkcrm__1__0_models.GetRelationUkSettingRequest,
    ) -> dingtalkcrm__1__0_models.GetRelationUkSettingResponse:
        """
        @summary 获取关系数据查重规则
        
        @param request: GetRelationUkSettingRequest
        @return: GetRelationUkSettingResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.GetRelationUkSettingHeaders()
        return await self.get_relation_uk_setting_with_options_async(request, headers, runtime)

    def join_group_set_with_options(
        self,
        request: dingtalkcrm__1__0_models.JoinGroupSetRequest,
        headers: dingtalkcrm__1__0_models.JoinGroupSetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.JoinGroupSetResponse:
        """
        @summary 加入群组
        
        @param request: JoinGroupSetRequest
        @param headers: JoinGroupSetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: JoinGroupSetResponse
        """
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
        """
        @summary 加入群组
        
        @param request: JoinGroupSetRequest
        @param headers: JoinGroupSetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: JoinGroupSetResponse
        """
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
        """
        @summary 加入群组
        
        @param request: JoinGroupSetRequest
        @return: JoinGroupSetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.JoinGroupSetHeaders()
        return self.join_group_set_with_options(request, headers, runtime)

    async def join_group_set_async(
        self,
        request: dingtalkcrm__1__0_models.JoinGroupSetRequest,
    ) -> dingtalkcrm__1__0_models.JoinGroupSetResponse:
        """
        @summary 加入群组
        
        @param request: JoinGroupSetRequest
        @return: JoinGroupSetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.JoinGroupSetHeaders()
        return await self.join_group_set_with_options_async(request, headers, runtime)

    def list_available_benefit_with_options(
        self,
        request: dingtalkcrm__1__0_models.ListAvailableBenefitRequest,
        headers: dingtalkcrm__1__0_models.ListAvailableBenefitHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.ListAvailableBenefitResponse:
        """
        @summary  批量查询可用权益
        
        @param request: ListAvailableBenefitRequest
        @param headers: ListAvailableBenefitHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListAvailableBenefitResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.benefit_code_list):
            body['benefitCodeList'] = request.benefit_code_list
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
            action='ListAvailableBenefit',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/benefits/lists/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.ListAvailableBenefitResponse(),
            self.execute(params, req, runtime)
        )

    async def list_available_benefit_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.ListAvailableBenefitRequest,
        headers: dingtalkcrm__1__0_models.ListAvailableBenefitHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.ListAvailableBenefitResponse:
        """
        @summary  批量查询可用权益
        
        @param request: ListAvailableBenefitRequest
        @param headers: ListAvailableBenefitHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListAvailableBenefitResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.benefit_code_list):
            body['benefitCodeList'] = request.benefit_code_list
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
            action='ListAvailableBenefit',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/benefits/lists/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.ListAvailableBenefitResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_available_benefit(
        self,
        request: dingtalkcrm__1__0_models.ListAvailableBenefitRequest,
    ) -> dingtalkcrm__1__0_models.ListAvailableBenefitResponse:
        """
        @summary  批量查询可用权益
        
        @param request: ListAvailableBenefitRequest
        @return: ListAvailableBenefitResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.ListAvailableBenefitHeaders()
        return self.list_available_benefit_with_options(request, headers, runtime)

    async def list_available_benefit_async(
        self,
        request: dingtalkcrm__1__0_models.ListAvailableBenefitRequest,
    ) -> dingtalkcrm__1__0_models.ListAvailableBenefitResponse:
        """
        @summary  批量查询可用权益
        
        @param request: ListAvailableBenefitRequest
        @return: ListAvailableBenefitResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.ListAvailableBenefitHeaders()
        return await self.list_available_benefit_with_options_async(request, headers, runtime)

    def list_benefit_license_with_options(
        self,
        request: dingtalkcrm__1__0_models.ListBenefitLicenseRequest,
        headers: dingtalkcrm__1__0_models.ListBenefitLicenseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.ListBenefitLicenseResponse:
        """
        @summary 批量查询license
        
        @param request: ListBenefitLicenseRequest
        @param headers: ListBenefitLicenseHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListBenefitLicenseResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.domains):
            body['domains'] = request.domains
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
            action='ListBenefitLicense',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/benefitLicenses/lists/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.ListBenefitLicenseResponse(),
            self.execute(params, req, runtime)
        )

    async def list_benefit_license_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.ListBenefitLicenseRequest,
        headers: dingtalkcrm__1__0_models.ListBenefitLicenseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.ListBenefitLicenseResponse:
        """
        @summary 批量查询license
        
        @param request: ListBenefitLicenseRequest
        @param headers: ListBenefitLicenseHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListBenefitLicenseResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.domains):
            body['domains'] = request.domains
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
            action='ListBenefitLicense',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/benefitLicenses/lists/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.ListBenefitLicenseResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_benefit_license(
        self,
        request: dingtalkcrm__1__0_models.ListBenefitLicenseRequest,
    ) -> dingtalkcrm__1__0_models.ListBenefitLicenseResponse:
        """
        @summary 批量查询license
        
        @param request: ListBenefitLicenseRequest
        @return: ListBenefitLicenseResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.ListBenefitLicenseHeaders()
        return self.list_benefit_license_with_options(request, headers, runtime)

    async def list_benefit_license_async(
        self,
        request: dingtalkcrm__1__0_models.ListBenefitLicenseRequest,
    ) -> dingtalkcrm__1__0_models.ListBenefitLicenseResponse:
        """
        @summary 批量查询license
        
        @param request: ListBenefitLicenseRequest
        @return: ListBenefitLicenseResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.ListBenefitLicenseHeaders()
        return await self.list_benefit_license_with_options_async(request, headers, runtime)

    def list_clue_tag_with_options(
        self,
        headers: dingtalkcrm__1__0_models.ListClueTagHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.ListClueTagResponse:
        """
        @summary 获取线索标签列表
        
        @param headers: ListClueTagHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListClueTagResponse
        """
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='ListClueTag',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/clues/tags',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.ListClueTagResponse(),
            self.execute(params, req, runtime)
        )

    async def list_clue_tag_with_options_async(
        self,
        headers: dingtalkcrm__1__0_models.ListClueTagHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.ListClueTagResponse:
        """
        @summary 获取线索标签列表
        
        @param headers: ListClueTagHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListClueTagResponse
        """
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='ListClueTag',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/clues/tags',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.ListClueTagResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_clue_tag(self) -> dingtalkcrm__1__0_models.ListClueTagResponse:
        """
        @summary 获取线索标签列表
        
        @return: ListClueTagResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.ListClueTagHeaders()
        return self.list_clue_tag_with_options(headers, runtime)

    async def list_clue_tag_async(self) -> dingtalkcrm__1__0_models.ListClueTagResponse:
        """
        @summary 获取线索标签列表
        
        @return: ListClueTagResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.ListClueTagHeaders()
        return await self.list_clue_tag_with_options_async(headers, runtime)

    def list_crm_personal_customers_with_options(
        self,
        request: dingtalkcrm__1__0_models.ListCrmPersonalCustomersRequest,
        headers: dingtalkcrm__1__0_models.ListCrmPersonalCustomersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.ListCrmPersonalCustomersResponse:
        """
        @summary 批量获取crm个人客户
        
        @param request: ListCrmPersonalCustomersRequest
        @param headers: ListCrmPersonalCustomersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListCrmPersonalCustomersResponse
        """
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
        """
        @summary 批量获取crm个人客户
        
        @param request: ListCrmPersonalCustomersRequest
        @param headers: ListCrmPersonalCustomersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListCrmPersonalCustomersResponse
        """
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
        """
        @summary 批量获取crm个人客户
        
        @param request: ListCrmPersonalCustomersRequest
        @return: ListCrmPersonalCustomersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.ListCrmPersonalCustomersHeaders()
        return self.list_crm_personal_customers_with_options(request, headers, runtime)

    async def list_crm_personal_customers_async(
        self,
        request: dingtalkcrm__1__0_models.ListCrmPersonalCustomersRequest,
    ) -> dingtalkcrm__1__0_models.ListCrmPersonalCustomersResponse:
        """
        @summary 批量获取crm个人客户
        
        @param request: ListCrmPersonalCustomersRequest
        @return: ListCrmPersonalCustomersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.ListCrmPersonalCustomersHeaders()
        return await self.list_crm_personal_customers_with_options_async(request, headers, runtime)

    def list_group_set_with_options(
        self,
        request: dingtalkcrm__1__0_models.ListGroupSetRequest,
        headers: dingtalkcrm__1__0_models.ListGroupSetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.ListGroupSetResponse:
        """
        @summary 查询群组列表
        
        @param request: ListGroupSetRequest
        @param headers: ListGroupSetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListGroupSetResponse
        """
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
        """
        @summary 查询群组列表
        
        @param request: ListGroupSetRequest
        @param headers: ListGroupSetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListGroupSetResponse
        """
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
        """
        @summary 查询群组列表
        
        @param request: ListGroupSetRequest
        @return: ListGroupSetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.ListGroupSetHeaders()
        return self.list_group_set_with_options(request, headers, runtime)

    async def list_group_set_async(
        self,
        request: dingtalkcrm__1__0_models.ListGroupSetRequest,
    ) -> dingtalkcrm__1__0_models.ListGroupSetResponse:
        """
        @summary 查询群组列表
        
        @param request: ListGroupSetRequest
        @return: ListGroupSetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.ListGroupSetHeaders()
        return await self.list_group_set_with_options_async(request, headers, runtime)

    def override_update_customer_data_auth_with_options(
        self,
        request: dingtalkcrm__1__0_models.OverrideUpdateCustomerDataAuthRequest,
        headers: dingtalkcrm__1__0_models.OverrideUpdateCustomerDataAuthHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.OverrideUpdateCustomerDataAuthResponse:
        """
        @summary 覆盖更新客户数据权限
        
        @param request: OverrideUpdateCustomerDataAuthRequest
        @param headers: OverrideUpdateCustomerDataAuthHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: OverrideUpdateCustomerDataAuthResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.customer_ids):
            body['customerIds'] = request.customer_ids
        if not UtilClient.is_unset(request.data_auth_user_ids):
            body['dataAuthUserIds'] = request.data_auth_user_ids
        if not UtilClient.is_unset(request.form_code):
            body['formCode'] = request.form_code
        if not UtilClient.is_unset(request.operate_user_id):
            body['operateUserId'] = request.operate_user_id
        if not UtilClient.is_unset(request.relation_type):
            body['relationType'] = request.relation_type
        if not UtilClient.is_unset(request.role_type):
            body['roleType'] = request.role_type
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
            action='OverrideUpdateCustomerDataAuth',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/customers/dataAuth/overrideUpdate',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.OverrideUpdateCustomerDataAuthResponse(),
            self.execute(params, req, runtime)
        )

    async def override_update_customer_data_auth_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.OverrideUpdateCustomerDataAuthRequest,
        headers: dingtalkcrm__1__0_models.OverrideUpdateCustomerDataAuthHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.OverrideUpdateCustomerDataAuthResponse:
        """
        @summary 覆盖更新客户数据权限
        
        @param request: OverrideUpdateCustomerDataAuthRequest
        @param headers: OverrideUpdateCustomerDataAuthHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: OverrideUpdateCustomerDataAuthResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.customer_ids):
            body['customerIds'] = request.customer_ids
        if not UtilClient.is_unset(request.data_auth_user_ids):
            body['dataAuthUserIds'] = request.data_auth_user_ids
        if not UtilClient.is_unset(request.form_code):
            body['formCode'] = request.form_code
        if not UtilClient.is_unset(request.operate_user_id):
            body['operateUserId'] = request.operate_user_id
        if not UtilClient.is_unset(request.relation_type):
            body['relationType'] = request.relation_type
        if not UtilClient.is_unset(request.role_type):
            body['roleType'] = request.role_type
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
            action='OverrideUpdateCustomerDataAuth',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/customers/dataAuth/overrideUpdate',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.OverrideUpdateCustomerDataAuthResponse(),
            await self.execute_async(params, req, runtime)
        )

    def override_update_customer_data_auth(
        self,
        request: dingtalkcrm__1__0_models.OverrideUpdateCustomerDataAuthRequest,
    ) -> dingtalkcrm__1__0_models.OverrideUpdateCustomerDataAuthResponse:
        """
        @summary 覆盖更新客户数据权限
        
        @param request: OverrideUpdateCustomerDataAuthRequest
        @return: OverrideUpdateCustomerDataAuthResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.OverrideUpdateCustomerDataAuthHeaders()
        return self.override_update_customer_data_auth_with_options(request, headers, runtime)

    async def override_update_customer_data_auth_async(
        self,
        request: dingtalkcrm__1__0_models.OverrideUpdateCustomerDataAuthRequest,
    ) -> dingtalkcrm__1__0_models.OverrideUpdateCustomerDataAuthResponse:
        """
        @summary 覆盖更新客户数据权限
        
        @param request: OverrideUpdateCustomerDataAuthRequest
        @return: OverrideUpdateCustomerDataAuthResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.OverrideUpdateCustomerDataAuthHeaders()
        return await self.override_update_customer_data_auth_with_options_async(request, headers, runtime)

    def query_all_customer_with_options(
        self,
        request: dingtalkcrm__1__0_models.QueryAllCustomerRequest,
        headers: dingtalkcrm__1__0_models.QueryAllCustomerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.QueryAllCustomerResponse:
        """
        @summary 分页获取全量客户数据，根据不同的类型可以获取私海个人客户、企业客户，以及公海个人客户、企业客户，最多一次可获取100条数据
        
        @param request: QueryAllCustomerRequest
        @param headers: QueryAllCustomerHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryAllCustomerResponse
        """
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
        """
        @summary 分页获取全量客户数据，根据不同的类型可以获取私海个人客户、企业客户，以及公海个人客户、企业客户，最多一次可获取100条数据
        
        @param request: QueryAllCustomerRequest
        @param headers: QueryAllCustomerHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryAllCustomerResponse
        """
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
        """
        @summary 分页获取全量客户数据，根据不同的类型可以获取私海个人客户、企业客户，以及公海个人客户、企业客户，最多一次可获取100条数据
        
        @param request: QueryAllCustomerRequest
        @return: QueryAllCustomerResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.QueryAllCustomerHeaders()
        return self.query_all_customer_with_options(request, headers, runtime)

    async def query_all_customer_async(
        self,
        request: dingtalkcrm__1__0_models.QueryAllCustomerRequest,
    ) -> dingtalkcrm__1__0_models.QueryAllCustomerResponse:
        """
        @summary 分页获取全量客户数据，根据不同的类型可以获取私海个人客户、企业客户，以及公海个人客户、企业客户，最多一次可获取100条数据
        
        @param request: QueryAllCustomerRequest
        @return: QueryAllCustomerResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.QueryAllCustomerHeaders()
        return await self.query_all_customer_with_options_async(request, headers, runtime)

    def query_all_tracks_with_options(
        self,
        request: dingtalkcrm__1__0_models.QueryAllTracksRequest,
        headers: dingtalkcrm__1__0_models.QueryAllTracksHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.QueryAllTracksResponse:
        """
        @summary 批量查询企业客户动态
        
        @param request: QueryAllTracksRequest
        @param headers: QueryAllTracksHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryAllTracksResponse
        """
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
        """
        @summary 批量查询企业客户动态
        
        @param request: QueryAllTracksRequest
        @param headers: QueryAllTracksHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryAllTracksResponse
        """
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
        """
        @summary 批量查询企业客户动态
        
        @param request: QueryAllTracksRequest
        @return: QueryAllTracksResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.QueryAllTracksHeaders()
        return self.query_all_tracks_with_options(request, headers, runtime)

    async def query_all_tracks_async(
        self,
        request: dingtalkcrm__1__0_models.QueryAllTracksRequest,
    ) -> dingtalkcrm__1__0_models.QueryAllTracksResponse:
        """
        @summary 批量查询企业客户动态
        
        @param request: QueryAllTracksRequest
        @return: QueryAllTracksResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.QueryAllTracksHeaders()
        return await self.query_all_tracks_with_options_async(request, headers, runtime)

    def query_app_manager_with_options(
        self,
        request: dingtalkcrm__1__0_models.QueryAppManagerRequest,
        headers: dingtalkcrm__1__0_models.QueryAppManagerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.QueryAppManagerResponse:
        """
        @summary 查询客户管理应用管理员
        
        @param request: QueryAppManagerRequest
        @param headers: QueryAppManagerHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryAppManagerResponse
        """
        UtilClient.validate_model(request)
        body = {}
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
            action='QueryAppManager',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/apps/managers/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.QueryAppManagerResponse(),
            self.execute(params, req, runtime)
        )

    async def query_app_manager_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.QueryAppManagerRequest,
        headers: dingtalkcrm__1__0_models.QueryAppManagerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.QueryAppManagerResponse:
        """
        @summary 查询客户管理应用管理员
        
        @param request: QueryAppManagerRequest
        @param headers: QueryAppManagerHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryAppManagerResponse
        """
        UtilClient.validate_model(request)
        body = {}
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
            action='QueryAppManager',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/apps/managers/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.QueryAppManagerResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_app_manager(
        self,
        request: dingtalkcrm__1__0_models.QueryAppManagerRequest,
    ) -> dingtalkcrm__1__0_models.QueryAppManagerResponse:
        """
        @summary 查询客户管理应用管理员
        
        @param request: QueryAppManagerRequest
        @return: QueryAppManagerResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.QueryAppManagerHeaders()
        return self.query_app_manager_with_options(request, headers, runtime)

    async def query_app_manager_async(
        self,
        request: dingtalkcrm__1__0_models.QueryAppManagerRequest,
    ) -> dingtalkcrm__1__0_models.QueryAppManagerResponse:
        """
        @summary 查询客户管理应用管理员
        
        @param request: QueryAppManagerRequest
        @return: QueryAppManagerResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.QueryAppManagerHeaders()
        return await self.query_app_manager_with_options_async(request, headers, runtime)

    def query_benefit_inventory_with_options(
        self,
        request: dingtalkcrm__1__0_models.QueryBenefitInventoryRequest,
        headers: dingtalkcrm__1__0_models.QueryBenefitInventoryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.QueryBenefitInventoryResponse:
        """
        @summary 查询权益库存
        
        @param request: QueryBenefitInventoryRequest
        @param headers: QueryBenefitInventoryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryBenefitInventoryResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.benefit_code):
            body['benefitCode'] = request.benefit_code
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
            action='QueryBenefitInventory',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/benefitInventories/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.QueryBenefitInventoryResponse(),
            self.execute(params, req, runtime)
        )

    async def query_benefit_inventory_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.QueryBenefitInventoryRequest,
        headers: dingtalkcrm__1__0_models.QueryBenefitInventoryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.QueryBenefitInventoryResponse:
        """
        @summary 查询权益库存
        
        @param request: QueryBenefitInventoryRequest
        @param headers: QueryBenefitInventoryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryBenefitInventoryResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.benefit_code):
            body['benefitCode'] = request.benefit_code
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
            action='QueryBenefitInventory',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/benefitInventories/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.QueryBenefitInventoryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_benefit_inventory(
        self,
        request: dingtalkcrm__1__0_models.QueryBenefitInventoryRequest,
    ) -> dingtalkcrm__1__0_models.QueryBenefitInventoryResponse:
        """
        @summary 查询权益库存
        
        @param request: QueryBenefitInventoryRequest
        @return: QueryBenefitInventoryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.QueryBenefitInventoryHeaders()
        return self.query_benefit_inventory_with_options(request, headers, runtime)

    async def query_benefit_inventory_async(
        self,
        request: dingtalkcrm__1__0_models.QueryBenefitInventoryRequest,
    ) -> dingtalkcrm__1__0_models.QueryBenefitInventoryResponse:
        """
        @summary 查询权益库存
        
        @param request: QueryBenefitInventoryRequest
        @return: QueryBenefitInventoryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.QueryBenefitInventoryHeaders()
        return await self.query_benefit_inventory_with_options_async(request, headers, runtime)

    def query_clue_follow_status_with_options(
        self,
        request: dingtalkcrm__1__0_models.QueryClueFollowStatusRequest,
        headers: dingtalkcrm__1__0_models.QueryClueFollowStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.QueryClueFollowStatusResponse:
        """
        @summary 查询线索跟进状态
        
        @param request: QueryClueFollowStatusRequest
        @param headers: QueryClueFollowStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryClueFollowStatusResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.clue_id):
            query['clueId'] = request.clue_id
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
            action='QueryClueFollowStatus',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/clues/followStatuses',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.QueryClueFollowStatusResponse(),
            self.execute(params, req, runtime)
        )

    async def query_clue_follow_status_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.QueryClueFollowStatusRequest,
        headers: dingtalkcrm__1__0_models.QueryClueFollowStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.QueryClueFollowStatusResponse:
        """
        @summary 查询线索跟进状态
        
        @param request: QueryClueFollowStatusRequest
        @param headers: QueryClueFollowStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryClueFollowStatusResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.clue_id):
            query['clueId'] = request.clue_id
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
            action='QueryClueFollowStatus',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/clues/followStatuses',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.QueryClueFollowStatusResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_clue_follow_status(
        self,
        request: dingtalkcrm__1__0_models.QueryClueFollowStatusRequest,
    ) -> dingtalkcrm__1__0_models.QueryClueFollowStatusResponse:
        """
        @summary 查询线索跟进状态
        
        @param request: QueryClueFollowStatusRequest
        @return: QueryClueFollowStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.QueryClueFollowStatusHeaders()
        return self.query_clue_follow_status_with_options(request, headers, runtime)

    async def query_clue_follow_status_async(
        self,
        request: dingtalkcrm__1__0_models.QueryClueFollowStatusRequest,
    ) -> dingtalkcrm__1__0_models.QueryClueFollowStatusResponse:
        """
        @summary 查询线索跟进状态
        
        @param request: QueryClueFollowStatusRequest
        @return: QueryClueFollowStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.QueryClueFollowStatusHeaders()
        return await self.query_clue_follow_status_with_options_async(request, headers, runtime)

    def query_crm_group_chats_with_options(
        self,
        request: dingtalkcrm__1__0_models.QueryCrmGroupChatsRequest,
        headers: dingtalkcrm__1__0_models.QueryCrmGroupChatsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.QueryCrmGroupChatsResponse:
        """
        @summary 查询客户群
        
        @param request: QueryCrmGroupChatsRequest
        @param headers: QueryCrmGroupChatsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryCrmGroupChatsResponse
        """
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
        """
        @summary 查询客户群
        
        @param request: QueryCrmGroupChatsRequest
        @param headers: QueryCrmGroupChatsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryCrmGroupChatsResponse
        """
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
        """
        @summary 查询客户群
        
        @param request: QueryCrmGroupChatsRequest
        @return: QueryCrmGroupChatsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.QueryCrmGroupChatsHeaders()
        return self.query_crm_group_chats_with_options(request, headers, runtime)

    async def query_crm_group_chats_async(
        self,
        request: dingtalkcrm__1__0_models.QueryCrmGroupChatsRequest,
    ) -> dingtalkcrm__1__0_models.QueryCrmGroupChatsResponse:
        """
        @summary 查询客户群
        
        @param request: QueryCrmGroupChatsRequest
        @return: QueryCrmGroupChatsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.QueryCrmGroupChatsHeaders()
        return await self.query_crm_group_chats_with_options_async(request, headers, runtime)

    def query_crm_personal_customer_with_options(
        self,
        request: dingtalkcrm__1__0_models.QueryCrmPersonalCustomerRequest,
        headers: dingtalkcrm__1__0_models.QueryCrmPersonalCustomerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.QueryCrmPersonalCustomerResponse:
        """
        @summary 根据指定查询条件批量获取客户数据
        
        @param request: QueryCrmPersonalCustomerRequest
        @param headers: QueryCrmPersonalCustomerHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryCrmPersonalCustomerResponse
        """
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
        """
        @summary 根据指定查询条件批量获取客户数据
        
        @param request: QueryCrmPersonalCustomerRequest
        @param headers: QueryCrmPersonalCustomerHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryCrmPersonalCustomerResponse
        """
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
        """
        @summary 根据指定查询条件批量获取客户数据
        
        @param request: QueryCrmPersonalCustomerRequest
        @return: QueryCrmPersonalCustomerResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.QueryCrmPersonalCustomerHeaders()
        return self.query_crm_personal_customer_with_options(request, headers, runtime)

    async def query_crm_personal_customer_async(
        self,
        request: dingtalkcrm__1__0_models.QueryCrmPersonalCustomerRequest,
    ) -> dingtalkcrm__1__0_models.QueryCrmPersonalCustomerResponse:
        """
        @summary 根据指定查询条件批量获取客户数据
        
        @param request: QueryCrmPersonalCustomerRequest
        @return: QueryCrmPersonalCustomerResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.QueryCrmPersonalCustomerHeaders()
        return await self.query_crm_personal_customer_with_options_async(request, headers, runtime)

    def query_customer_biz_type_with_options(
        self,
        request: dingtalkcrm__1__0_models.QueryCustomerBizTypeRequest,
        headers: dingtalkcrm__1__0_models.QueryCustomerBizTypeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.QueryCustomerBizTypeResponse:
        """
        @summary 查询客户模板启用类型
        
        @param request: QueryCustomerBizTypeRequest
        @param headers: QueryCustomerBizTypeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryCustomerBizTypeResponse
        """
        UtilClient.validate_model(request)
        body = {}
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
            action='QueryCustomerBizType',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/orgSettings/templates/customerBizTypes/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.QueryCustomerBizTypeResponse(),
            self.execute(params, req, runtime)
        )

    async def query_customer_biz_type_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.QueryCustomerBizTypeRequest,
        headers: dingtalkcrm__1__0_models.QueryCustomerBizTypeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.QueryCustomerBizTypeResponse:
        """
        @summary 查询客户模板启用类型
        
        @param request: QueryCustomerBizTypeRequest
        @param headers: QueryCustomerBizTypeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryCustomerBizTypeResponse
        """
        UtilClient.validate_model(request)
        body = {}
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
            action='QueryCustomerBizType',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/orgSettings/templates/customerBizTypes/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.QueryCustomerBizTypeResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_customer_biz_type(
        self,
        request: dingtalkcrm__1__0_models.QueryCustomerBizTypeRequest,
    ) -> dingtalkcrm__1__0_models.QueryCustomerBizTypeResponse:
        """
        @summary 查询客户模板启用类型
        
        @param request: QueryCustomerBizTypeRequest
        @return: QueryCustomerBizTypeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.QueryCustomerBizTypeHeaders()
        return self.query_customer_biz_type_with_options(request, headers, runtime)

    async def query_customer_biz_type_async(
        self,
        request: dingtalkcrm__1__0_models.QueryCustomerBizTypeRequest,
    ) -> dingtalkcrm__1__0_models.QueryCustomerBizTypeResponse:
        """
        @summary 查询客户模板启用类型
        
        @param request: QueryCustomerBizTypeRequest
        @return: QueryCustomerBizTypeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.QueryCustomerBizTypeHeaders()
        return await self.query_customer_biz_type_with_options_async(request, headers, runtime)

    def query_global_info_with_options(
        self,
        request: dingtalkcrm__1__0_models.QueryGlobalInfoRequest,
        headers: dingtalkcrm__1__0_models.QueryGlobalInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.QueryGlobalInfoResponse:
        """
        @summary 营销服融合三方全局信息
        
        @param request: QueryGlobalInfoRequest
        @param headers: QueryGlobalInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryGlobalInfoResponse
        """
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
        """
        @summary 营销服融合三方全局信息
        
        @param request: QueryGlobalInfoRequest
        @param headers: QueryGlobalInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryGlobalInfoResponse
        """
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
        """
        @summary 营销服融合三方全局信息
        
        @param request: QueryGlobalInfoRequest
        @return: QueryGlobalInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.QueryGlobalInfoHeaders()
        return self.query_global_info_with_options(request, headers, runtime)

    async def query_global_info_async(
        self,
        request: dingtalkcrm__1__0_models.QueryGlobalInfoRequest,
    ) -> dingtalkcrm__1__0_models.QueryGlobalInfoResponse:
        """
        @summary 营销服融合三方全局信息
        
        @param request: QueryGlobalInfoRequest
        @return: QueryGlobalInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.QueryGlobalInfoHeaders()
        return await self.query_global_info_with_options_async(request, headers, runtime)

    def query_has_app_permission_with_options(
        self,
        request: dingtalkcrm__1__0_models.QueryHasAppPermissionRequest,
        headers: dingtalkcrm__1__0_models.QueryHasAppPermissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.QueryHasAppPermissionResponse:
        """
        @summary 查询用户是否有应用管理员权限
        
        @param request: QueryHasAppPermissionRequest
        @param headers: QueryHasAppPermissionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryHasAppPermissionResponse
        """
        UtilClient.validate_model(request)
        body = {}
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
            action='QueryHasAppPermission',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/apps/adminPermissions/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.QueryHasAppPermissionResponse(),
            self.execute(params, req, runtime)
        )

    async def query_has_app_permission_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.QueryHasAppPermissionRequest,
        headers: dingtalkcrm__1__0_models.QueryHasAppPermissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.QueryHasAppPermissionResponse:
        """
        @summary 查询用户是否有应用管理员权限
        
        @param request: QueryHasAppPermissionRequest
        @param headers: QueryHasAppPermissionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryHasAppPermissionResponse
        """
        UtilClient.validate_model(request)
        body = {}
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
            action='QueryHasAppPermission',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/apps/adminPermissions/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.QueryHasAppPermissionResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_has_app_permission(
        self,
        request: dingtalkcrm__1__0_models.QueryHasAppPermissionRequest,
    ) -> dingtalkcrm__1__0_models.QueryHasAppPermissionResponse:
        """
        @summary 查询用户是否有应用管理员权限
        
        @param request: QueryHasAppPermissionRequest
        @return: QueryHasAppPermissionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.QueryHasAppPermissionHeaders()
        return self.query_has_app_permission_with_options(request, headers, runtime)

    async def query_has_app_permission_async(
        self,
        request: dingtalkcrm__1__0_models.QueryHasAppPermissionRequest,
    ) -> dingtalkcrm__1__0_models.QueryHasAppPermissionResponse:
        """
        @summary 查询用户是否有应用管理员权限
        
        @param request: QueryHasAppPermissionRequest
        @return: QueryHasAppPermissionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.QueryHasAppPermissionHeaders()
        return await self.query_has_app_permission_with_options_async(request, headers, runtime)

    def query_official_account_user_basic_info_with_options(
        self,
        request: dingtalkcrm__1__0_models.QueryOfficialAccountUserBasicInfoRequest,
        headers: dingtalkcrm__1__0_models.QueryOfficialAccountUserBasicInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.QueryOfficialAccountUserBasicInfoResponse:
        """
        @summary 查询服务窗用户基础信息
        
        @param request: QueryOfficialAccountUserBasicInfoRequest
        @param headers: QueryOfficialAccountUserBasicInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryOfficialAccountUserBasicInfoResponse
        """
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
        """
        @summary 查询服务窗用户基础信息
        
        @param request: QueryOfficialAccountUserBasicInfoRequest
        @param headers: QueryOfficialAccountUserBasicInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryOfficialAccountUserBasicInfoResponse
        """
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
        """
        @summary 查询服务窗用户基础信息
        
        @param request: QueryOfficialAccountUserBasicInfoRequest
        @return: QueryOfficialAccountUserBasicInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.QueryOfficialAccountUserBasicInfoHeaders()
        return self.query_official_account_user_basic_info_with_options(request, headers, runtime)

    async def query_official_account_user_basic_info_async(
        self,
        request: dingtalkcrm__1__0_models.QueryOfficialAccountUserBasicInfoRequest,
    ) -> dingtalkcrm__1__0_models.QueryOfficialAccountUserBasicInfoResponse:
        """
        @summary 查询服务窗用户基础信息
        
        @param request: QueryOfficialAccountUserBasicInfoRequest
        @return: QueryOfficialAccountUserBasicInfoResponse
        """
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
        """
        @summary 根据targetId查询关系数据
        
        @param request: QueryRelationDatasByTargetIdRequest
        @param headers: QueryRelationDatasByTargetIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryRelationDatasByTargetIdResponse
        """
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
        """
        @summary 根据targetId查询关系数据
        
        @param request: QueryRelationDatasByTargetIdRequest
        @param headers: QueryRelationDatasByTargetIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryRelationDatasByTargetIdResponse
        """
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
        """
        @summary 根据targetId查询关系数据
        
        @param request: QueryRelationDatasByTargetIdRequest
        @return: QueryRelationDatasByTargetIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.QueryRelationDatasByTargetIdHeaders()
        return self.query_relation_datas_by_target_id_with_options(target_id, request, headers, runtime)

    async def query_relation_datas_by_target_id_async(
        self,
        target_id: str,
        request: dingtalkcrm__1__0_models.QueryRelationDatasByTargetIdRequest,
    ) -> dingtalkcrm__1__0_models.QueryRelationDatasByTargetIdResponse:
        """
        @summary 根据targetId查询关系数据
        
        @param request: QueryRelationDatasByTargetIdRequest
        @return: QueryRelationDatasByTargetIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.QueryRelationDatasByTargetIdHeaders()
        return await self.query_relation_datas_by_target_id_with_options_async(target_id, request, headers, runtime)

    def recall_official_account_otomessage_with_options(
        self,
        request: dingtalkcrm__1__0_models.RecallOfficialAccountOTOMessageRequest,
        headers: dingtalkcrm__1__0_models.RecallOfficialAccountOTOMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.RecallOfficialAccountOTOMessageResponse:
        """
        @summary 服务窗消息撤回
        
        @param request: RecallOfficialAccountOTOMessageRequest
        @param headers: RecallOfficialAccountOTOMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RecallOfficialAccountOTOMessageResponse
        """
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
        """
        @summary 服务窗消息撤回
        
        @param request: RecallOfficialAccountOTOMessageRequest
        @param headers: RecallOfficialAccountOTOMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RecallOfficialAccountOTOMessageResponse
        """
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
        """
        @summary 服务窗消息撤回
        
        @param request: RecallOfficialAccountOTOMessageRequest
        @return: RecallOfficialAccountOTOMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.RecallOfficialAccountOTOMessageHeaders()
        return self.recall_official_account_otomessage_with_options(request, headers, runtime)

    async def recall_official_account_otomessage_async(
        self,
        request: dingtalkcrm__1__0_models.RecallOfficialAccountOTOMessageRequest,
    ) -> dingtalkcrm__1__0_models.RecallOfficialAccountOTOMessageResponse:
        """
        @summary 服务窗消息撤回
        
        @param request: RecallOfficialAccountOTOMessageRequest
        @return: RecallOfficialAccountOTOMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.RecallOfficialAccountOTOMessageHeaders()
        return await self.recall_official_account_otomessage_with_options_async(request, headers, runtime)

    def save_benefit_license_with_options(
        self,
        request: dingtalkcrm__1__0_models.SaveBenefitLicenseRequest,
        headers: dingtalkcrm__1__0_models.SaveBenefitLicenseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.SaveBenefitLicenseResponse:
        """
        @summary 保存license
        
        @param request: SaveBenefitLicenseRequest
        @param headers: SaveBenefitLicenseHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SaveBenefitLicenseResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.domain):
            body['domain'] = request.domain
        if not UtilClient.is_unset(request.licenses):
            body['licenses'] = request.licenses
        if not UtilClient.is_unset(request.save_user_id):
            body['saveUserId'] = request.save_user_id
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
            action='SaveBenefitLicense',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/benefitLicenses/save',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.SaveBenefitLicenseResponse(),
            self.execute(params, req, runtime)
        )

    async def save_benefit_license_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.SaveBenefitLicenseRequest,
        headers: dingtalkcrm__1__0_models.SaveBenefitLicenseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.SaveBenefitLicenseResponse:
        """
        @summary 保存license
        
        @param request: SaveBenefitLicenseRequest
        @param headers: SaveBenefitLicenseHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SaveBenefitLicenseResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.domain):
            body['domain'] = request.domain
        if not UtilClient.is_unset(request.licenses):
            body['licenses'] = request.licenses
        if not UtilClient.is_unset(request.save_user_id):
            body['saveUserId'] = request.save_user_id
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
            action='SaveBenefitLicense',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/benefitLicenses/save',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.SaveBenefitLicenseResponse(),
            await self.execute_async(params, req, runtime)
        )

    def save_benefit_license(
        self,
        request: dingtalkcrm__1__0_models.SaveBenefitLicenseRequest,
    ) -> dingtalkcrm__1__0_models.SaveBenefitLicenseResponse:
        """
        @summary 保存license
        
        @param request: SaveBenefitLicenseRequest
        @return: SaveBenefitLicenseResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.SaveBenefitLicenseHeaders()
        return self.save_benefit_license_with_options(request, headers, runtime)

    async def save_benefit_license_async(
        self,
        request: dingtalkcrm__1__0_models.SaveBenefitLicenseRequest,
    ) -> dingtalkcrm__1__0_models.SaveBenefitLicenseResponse:
        """
        @summary 保存license
        
        @param request: SaveBenefitLicenseRequest
        @return: SaveBenefitLicenseResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.SaveBenefitLicenseHeaders()
        return await self.save_benefit_license_with_options_async(request, headers, runtime)

    def send_official_account_otomessage_with_options(
        self,
        request: dingtalkcrm__1__0_models.SendOfficialAccountOTOMessageRequest,
        headers: dingtalkcrm__1__0_models.SendOfficialAccountOTOMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.SendOfficialAccountOTOMessageResponse:
        """
        @summary 服务窗单发接口，指定消息接收人发送
        
        @param request: SendOfficialAccountOTOMessageRequest
        @param headers: SendOfficialAccountOTOMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SendOfficialAccountOTOMessageResponse
        """
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
        """
        @summary 服务窗单发接口，指定消息接收人发送
        
        @param request: SendOfficialAccountOTOMessageRequest
        @param headers: SendOfficialAccountOTOMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SendOfficialAccountOTOMessageResponse
        """
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
        """
        @summary 服务窗单发接口，指定消息接收人发送
        
        @param request: SendOfficialAccountOTOMessageRequest
        @return: SendOfficialAccountOTOMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.SendOfficialAccountOTOMessageHeaders()
        return self.send_official_account_otomessage_with_options(request, headers, runtime)

    async def send_official_account_otomessage_async(
        self,
        request: dingtalkcrm__1__0_models.SendOfficialAccountOTOMessageRequest,
    ) -> dingtalkcrm__1__0_models.SendOfficialAccountOTOMessageResponse:
        """
        @summary 服务窗单发接口，指定消息接收人发送
        
        @param request: SendOfficialAccountOTOMessageRequest
        @return: SendOfficialAccountOTOMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.SendOfficialAccountOTOMessageHeaders()
        return await self.send_official_account_otomessage_with_options_async(request, headers, runtime)

    def send_official_account_snsmessage_with_options(
        self,
        request: dingtalkcrm__1__0_models.SendOfficialAccountSNSMessageRequest,
        headers: dingtalkcrm__1__0_models.SendOfficialAccountSNSMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.SendOfficialAccountSNSMessageResponse:
        """
        @summary 个人应用发送服务窗消息
        
        @param request: SendOfficialAccountSNSMessageRequest
        @param headers: SendOfficialAccountSNSMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SendOfficialAccountSNSMessageResponse
        """
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
        """
        @summary 个人应用发送服务窗消息
        
        @param request: SendOfficialAccountSNSMessageRequest
        @param headers: SendOfficialAccountSNSMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SendOfficialAccountSNSMessageResponse
        """
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
        """
        @summary 个人应用发送服务窗消息
        
        @param request: SendOfficialAccountSNSMessageRequest
        @return: SendOfficialAccountSNSMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.SendOfficialAccountSNSMessageHeaders()
        return self.send_official_account_snsmessage_with_options(request, headers, runtime)

    async def send_official_account_snsmessage_async(
        self,
        request: dingtalkcrm__1__0_models.SendOfficialAccountSNSMessageRequest,
    ) -> dingtalkcrm__1__0_models.SendOfficialAccountSNSMessageResponse:
        """
        @summary 个人应用发送服务窗消息
        
        @param request: SendOfficialAccountSNSMessageRequest
        @return: SendOfficialAccountSNSMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.SendOfficialAccountSNSMessageHeaders()
        return await self.send_official_account_snsmessage_with_options_async(request, headers, runtime)

    def service_window_message_batch_push_with_options(
        self,
        request: dingtalkcrm__1__0_models.ServiceWindowMessageBatchPushRequest,
        headers: dingtalkcrm__1__0_models.ServiceWindowMessageBatchPushHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.ServiceWindowMessageBatchPushResponse:
        """
        @summary 服务窗消息群发
        
        @param request: ServiceWindowMessageBatchPushRequest
        @param headers: ServiceWindowMessageBatchPushHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ServiceWindowMessageBatchPushResponse
        """
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
        """
        @summary 服务窗消息群发
        
        @param request: ServiceWindowMessageBatchPushRequest
        @param headers: ServiceWindowMessageBatchPushHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ServiceWindowMessageBatchPushResponse
        """
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
        """
        @summary 服务窗消息群发
        
        @param request: ServiceWindowMessageBatchPushRequest
        @return: ServiceWindowMessageBatchPushResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.ServiceWindowMessageBatchPushHeaders()
        return self.service_window_message_batch_push_with_options(request, headers, runtime)

    async def service_window_message_batch_push_async(
        self,
        request: dingtalkcrm__1__0_models.ServiceWindowMessageBatchPushRequest,
    ) -> dingtalkcrm__1__0_models.ServiceWindowMessageBatchPushResponse:
        """
        @summary 服务窗消息群发
        
        @param request: ServiceWindowMessageBatchPushRequest
        @return: ServiceWindowMessageBatchPushResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.ServiceWindowMessageBatchPushHeaders()
        return await self.service_window_message_batch_push_with_options_async(request, headers, runtime)

    def two_phase_commit_inventory_with_options(
        self,
        request: dingtalkcrm__1__0_models.TwoPhaseCommitInventoryRequest,
        headers: dingtalkcrm__1__0_models.TwoPhaseCommitInventoryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.TwoPhaseCommitInventoryResponse:
        """
        @summary 二阶段提交权益库存结果
        
        @param request: TwoPhaseCommitInventoryRequest
        @param headers: TwoPhaseCommitInventoryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TwoPhaseCommitInventoryResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.benefit_code):
            body['benefitCode'] = request.benefit_code
        if not UtilClient.is_unset(request.biz_request_id):
            body['bizRequestId'] = request.biz_request_id
        if not UtilClient.is_unset(request.execute_result):
            body['executeResult'] = request.execute_result
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
            action='TwoPhaseCommitInventory',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/benefitInventories/twoPhases/commit',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.TwoPhaseCommitInventoryResponse(),
            self.execute(params, req, runtime)
        )

    async def two_phase_commit_inventory_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.TwoPhaseCommitInventoryRequest,
        headers: dingtalkcrm__1__0_models.TwoPhaseCommitInventoryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.TwoPhaseCommitInventoryResponse:
        """
        @summary 二阶段提交权益库存结果
        
        @param request: TwoPhaseCommitInventoryRequest
        @param headers: TwoPhaseCommitInventoryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TwoPhaseCommitInventoryResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.benefit_code):
            body['benefitCode'] = request.benefit_code
        if not UtilClient.is_unset(request.biz_request_id):
            body['bizRequestId'] = request.biz_request_id
        if not UtilClient.is_unset(request.execute_result):
            body['executeResult'] = request.execute_result
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
            action='TwoPhaseCommitInventory',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/benefitInventories/twoPhases/commit',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.TwoPhaseCommitInventoryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def two_phase_commit_inventory(
        self,
        request: dingtalkcrm__1__0_models.TwoPhaseCommitInventoryRequest,
    ) -> dingtalkcrm__1__0_models.TwoPhaseCommitInventoryResponse:
        """
        @summary 二阶段提交权益库存结果
        
        @param request: TwoPhaseCommitInventoryRequest
        @return: TwoPhaseCommitInventoryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.TwoPhaseCommitInventoryHeaders()
        return self.two_phase_commit_inventory_with_options(request, headers, runtime)

    async def two_phase_commit_inventory_async(
        self,
        request: dingtalkcrm__1__0_models.TwoPhaseCommitInventoryRequest,
    ) -> dingtalkcrm__1__0_models.TwoPhaseCommitInventoryResponse:
        """
        @summary 二阶段提交权益库存结果
        
        @param request: TwoPhaseCommitInventoryRequest
        @return: TwoPhaseCommitInventoryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.TwoPhaseCommitInventoryHeaders()
        return await self.two_phase_commit_inventory_with_options_async(request, headers, runtime)

    def update_crm_personal_customer_with_options(
        self,
        request: dingtalkcrm__1__0_models.UpdateCrmPersonalCustomerRequest,
        headers: dingtalkcrm__1__0_models.UpdateCrmPersonalCustomerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.UpdateCrmPersonalCustomerResponse:
        """
        @summary 更新crm个人客户（或企业客户）
        
        @param request: UpdateCrmPersonalCustomerRequest
        @param headers: UpdateCrmPersonalCustomerHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateCrmPersonalCustomerResponse
        """
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
        """
        @summary 更新crm个人客户（或企业客户）
        
        @param request: UpdateCrmPersonalCustomerRequest
        @param headers: UpdateCrmPersonalCustomerHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateCrmPersonalCustomerResponse
        """
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
        """
        @summary 更新crm个人客户（或企业客户）
        
        @param request: UpdateCrmPersonalCustomerRequest
        @return: UpdateCrmPersonalCustomerResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.UpdateCrmPersonalCustomerHeaders()
        return self.update_crm_personal_customer_with_options(request, headers, runtime)

    async def update_crm_personal_customer_async(
        self,
        request: dingtalkcrm__1__0_models.UpdateCrmPersonalCustomerRequest,
    ) -> dingtalkcrm__1__0_models.UpdateCrmPersonalCustomerResponse:
        """
        @summary 更新crm个人客户（或企业客户）
        
        @param request: UpdateCrmPersonalCustomerRequest
        @return: UpdateCrmPersonalCustomerResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.UpdateCrmPersonalCustomerHeaders()
        return await self.update_crm_personal_customer_with_options_async(request, headers, runtime)

    def update_customer_biz_type_with_options(
        self,
        request: dingtalkcrm__1__0_models.UpdateCustomerBizTypeRequest,
        headers: dingtalkcrm__1__0_models.UpdateCustomerBizTypeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.UpdateCustomerBizTypeResponse:
        """
        @summary 更新客户模板类型
        
        @param request: UpdateCustomerBizTypeRequest
        @param headers: UpdateCustomerBizTypeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateCustomerBizTypeResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.customer_biz_type):
            body['customerBizType'] = request.customer_biz_type
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
            action='UpdateCustomerBizType',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/orgSettings/templates/customerBizTypes',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.UpdateCustomerBizTypeResponse(),
            self.execute(params, req, runtime)
        )

    async def update_customer_biz_type_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.UpdateCustomerBizTypeRequest,
        headers: dingtalkcrm__1__0_models.UpdateCustomerBizTypeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.UpdateCustomerBizTypeResponse:
        """
        @summary 更新客户模板类型
        
        @param request: UpdateCustomerBizTypeRequest
        @param headers: UpdateCustomerBizTypeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateCustomerBizTypeResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.customer_biz_type):
            body['customerBizType'] = request.customer_biz_type
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
            action='UpdateCustomerBizType',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/orgSettings/templates/customerBizTypes',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.UpdateCustomerBizTypeResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_customer_biz_type(
        self,
        request: dingtalkcrm__1__0_models.UpdateCustomerBizTypeRequest,
    ) -> dingtalkcrm__1__0_models.UpdateCustomerBizTypeResponse:
        """
        @summary 更新客户模板类型
        
        @param request: UpdateCustomerBizTypeRequest
        @return: UpdateCustomerBizTypeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.UpdateCustomerBizTypeHeaders()
        return self.update_customer_biz_type_with_options(request, headers, runtime)

    async def update_customer_biz_type_async(
        self,
        request: dingtalkcrm__1__0_models.UpdateCustomerBizTypeRequest,
    ) -> dingtalkcrm__1__0_models.UpdateCustomerBizTypeResponse:
        """
        @summary 更新客户模板类型
        
        @param request: UpdateCustomerBizTypeRequest
        @return: UpdateCustomerBizTypeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.UpdateCustomerBizTypeHeaders()
        return await self.update_customer_biz_type_with_options_async(request, headers, runtime)

    def update_group_set_with_options(
        self,
        request: dingtalkcrm__1__0_models.UpdateGroupSetRequest,
        headers: dingtalkcrm__1__0_models.UpdateGroupSetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.UpdateGroupSetResponse:
        """
        @summary 更新群组
        
        @param request: UpdateGroupSetRequest
        @param headers: UpdateGroupSetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateGroupSetResponse
        """
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
        """
        @summary 更新群组
        
        @param request: UpdateGroupSetRequest
        @param headers: UpdateGroupSetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateGroupSetResponse
        """
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
        """
        @summary 更新群组
        
        @param request: UpdateGroupSetRequest
        @return: UpdateGroupSetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.UpdateGroupSetHeaders()
        return self.update_group_set_with_options(request, headers, runtime)

    async def update_group_set_async(
        self,
        request: dingtalkcrm__1__0_models.UpdateGroupSetRequest,
    ) -> dingtalkcrm__1__0_models.UpdateGroupSetResponse:
        """
        @summary 更新群组
        
        @param request: UpdateGroupSetRequest
        @return: UpdateGroupSetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.UpdateGroupSetHeaders()
        return await self.update_group_set_with_options_async(request, headers, runtime)

    def update_menu_data_with_options(
        self,
        request: dingtalkcrm__1__0_models.UpdateMenuDataRequest,
        headers: dingtalkcrm__1__0_models.UpdateMenuDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.UpdateMenuDataResponse:
        """
        @summary 增量同步导航数据
        
        @param request: UpdateMenuDataRequest
        @param headers: UpdateMenuDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateMenuDataResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.attr):
            body['attr'] = request.attr
        if not UtilClient.is_unset(request.biz_trace_id):
            body['bizTraceId'] = request.biz_trace_id
        if not UtilClient.is_unset(request.module):
            body['module'] = request.module
        if not UtilClient.is_unset(request.nav_data):
            body['navData'] = request.nav_data
        if not UtilClient.is_unset(request.operate_type):
            body['operateType'] = request.operate_type
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
            action='UpdateMenuData',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/navigations/menus/sync',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.UpdateMenuDataResponse(),
            self.execute(params, req, runtime)
        )

    async def update_menu_data_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.UpdateMenuDataRequest,
        headers: dingtalkcrm__1__0_models.UpdateMenuDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.UpdateMenuDataResponse:
        """
        @summary 增量同步导航数据
        
        @param request: UpdateMenuDataRequest
        @param headers: UpdateMenuDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateMenuDataResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.attr):
            body['attr'] = request.attr
        if not UtilClient.is_unset(request.biz_trace_id):
            body['bizTraceId'] = request.biz_trace_id
        if not UtilClient.is_unset(request.module):
            body['module'] = request.module
        if not UtilClient.is_unset(request.nav_data):
            body['navData'] = request.nav_data
        if not UtilClient.is_unset(request.operate_type):
            body['operateType'] = request.operate_type
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
            action='UpdateMenuData',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/navigations/menus/sync',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.UpdateMenuDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_menu_data(
        self,
        request: dingtalkcrm__1__0_models.UpdateMenuDataRequest,
    ) -> dingtalkcrm__1__0_models.UpdateMenuDataResponse:
        """
        @summary 增量同步导航数据
        
        @param request: UpdateMenuDataRequest
        @return: UpdateMenuDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.UpdateMenuDataHeaders()
        return self.update_menu_data_with_options(request, headers, runtime)

    async def update_menu_data_async(
        self,
        request: dingtalkcrm__1__0_models.UpdateMenuDataRequest,
    ) -> dingtalkcrm__1__0_models.UpdateMenuDataResponse:
        """
        @summary 增量同步导航数据
        
        @param request: UpdateMenuDataRequest
        @return: UpdateMenuDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.UpdateMenuDataHeaders()
        return await self.update_menu_data_with_options_async(request, headers, runtime)

    def update_meta_model_field_with_options(
        self,
        request: dingtalkcrm__1__0_models.UpdateMetaModelFieldRequest,
        headers: dingtalkcrm__1__0_models.UpdateMetaModelFieldHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.UpdateMetaModelFieldResponse:
        """
        @summary 模型表结构更新字段
        
        @param request: UpdateMetaModelFieldRequest
        @param headers: UpdateMetaModelFieldHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateMetaModelFieldResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_type):
            body['bizType'] = request.biz_type
        if not UtilClient.is_unset(request.field_dtolist):
            body['fieldDTOList'] = request.field_dtolist
        if not UtilClient.is_unset(request.operator_user_id):
            body['operatorUserId'] = request.operator_user_id
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
            action='UpdateMetaModelField',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/metas/models/fields',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.UpdateMetaModelFieldResponse(),
            self.execute(params, req, runtime)
        )

    async def update_meta_model_field_with_options_async(
        self,
        request: dingtalkcrm__1__0_models.UpdateMetaModelFieldRequest,
        headers: dingtalkcrm__1__0_models.UpdateMetaModelFieldHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.UpdateMetaModelFieldResponse:
        """
        @summary 模型表结构更新字段
        
        @param request: UpdateMetaModelFieldRequest
        @param headers: UpdateMetaModelFieldHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateMetaModelFieldResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_type):
            body['bizType'] = request.biz_type
        if not UtilClient.is_unset(request.field_dtolist):
            body['fieldDTOList'] = request.field_dtolist
        if not UtilClient.is_unset(request.operator_user_id):
            body['operatorUserId'] = request.operator_user_id
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
            action='UpdateMetaModelField',
            version='crm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/crm/metas/models/fields',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__1__0_models.UpdateMetaModelFieldResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_meta_model_field(
        self,
        request: dingtalkcrm__1__0_models.UpdateMetaModelFieldRequest,
    ) -> dingtalkcrm__1__0_models.UpdateMetaModelFieldResponse:
        """
        @summary 模型表结构更新字段
        
        @param request: UpdateMetaModelFieldRequest
        @return: UpdateMetaModelFieldResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.UpdateMetaModelFieldHeaders()
        return self.update_meta_model_field_with_options(request, headers, runtime)

    async def update_meta_model_field_async(
        self,
        request: dingtalkcrm__1__0_models.UpdateMetaModelFieldRequest,
    ) -> dingtalkcrm__1__0_models.UpdateMetaModelFieldResponse:
        """
        @summary 模型表结构更新字段
        
        @param request: UpdateMetaModelFieldRequest
        @return: UpdateMetaModelFieldResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.UpdateMetaModelFieldHeaders()
        return await self.update_meta_model_field_with_options_async(request, headers, runtime)

    def update_relation_meta_field_with_options(
        self,
        request: dingtalkcrm__1__0_models.UpdateRelationMetaFieldRequest,
        headers: dingtalkcrm__1__0_models.UpdateRelationMetaFieldHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__1__0_models.UpdateRelationMetaFieldResponse:
        """
        @summary 关系模型表结构更新字段
        
        @param request: UpdateRelationMetaFieldRequest
        @param headers: UpdateRelationMetaFieldHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateRelationMetaFieldResponse
        """
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
        """
        @summary 关系模型表结构更新字段
        
        @param request: UpdateRelationMetaFieldRequest
        @param headers: UpdateRelationMetaFieldHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateRelationMetaFieldResponse
        """
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
        """
        @summary 关系模型表结构更新字段
        
        @param request: UpdateRelationMetaFieldRequest
        @return: UpdateRelationMetaFieldResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.UpdateRelationMetaFieldHeaders()
        return self.update_relation_meta_field_with_options(request, headers, runtime)

    async def update_relation_meta_field_async(
        self,
        request: dingtalkcrm__1__0_models.UpdateRelationMetaFieldRequest,
    ) -> dingtalkcrm__1__0_models.UpdateRelationMetaFieldResponse:
        """
        @summary 关系模型表结构更新字段
        
        @param request: UpdateRelationMetaFieldRequest
        @return: UpdateRelationMetaFieldResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__1__0_models.UpdateRelationMetaFieldHeaders()
        return await self.update_relation_meta_field_with_options_async(request, headers, runtime)
