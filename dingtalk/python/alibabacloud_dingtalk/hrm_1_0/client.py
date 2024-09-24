# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore
from typing import Dict

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.hrm_1_0 import models as dingtalkhrm__1__0_models
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
        self._signature_algorithm = 'v2'
        self._endpoint_rule = ''
        if UtilClient.empty(self._endpoint):
            self._endpoint = 'api.dingtalk.com'

    def add_hrm_legal_entity_with_options(
        self,
        request: dingtalkhrm__1__0_models.AddHrmLegalEntityRequest,
        headers: dingtalkhrm__1__0_models.AddHrmLegalEntityHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.AddHrmLegalEntityResponse:
        """
        @summary 新增法人公司
        
        @param request: AddHrmLegalEntityRequest
        @param headers: AddHrmLegalEntityHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddHrmLegalEntityResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.ding_tenant_id):
            query['dingTenantId'] = request.ding_tenant_id
        body = {}
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.create_user_id):
            body['createUserId'] = request.create_user_id
        if not UtilClient.is_unset(request.ext):
            body['ext'] = request.ext
        if not UtilClient.is_unset(request.legal_entity_name):
            body['legalEntityName'] = request.legal_entity_name
        if not UtilClient.is_unset(request.legal_entity_short_name):
            body['legalEntityShortName'] = request.legal_entity_short_name
        if not UtilClient.is_unset(request.legal_entity_status):
            body['legalEntityStatus'] = request.legal_entity_status
        if not UtilClient.is_unset(request.legal_person_name):
            body['legalPersonName'] = request.legal_person_name
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='AddHrmLegalEntity',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/masters/legalEntities/companies',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.AddHrmLegalEntityResponse(),
            self.execute(params, req, runtime)
        )

    async def add_hrm_legal_entity_with_options_async(
        self,
        request: dingtalkhrm__1__0_models.AddHrmLegalEntityRequest,
        headers: dingtalkhrm__1__0_models.AddHrmLegalEntityHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.AddHrmLegalEntityResponse:
        """
        @summary 新增法人公司
        
        @param request: AddHrmLegalEntityRequest
        @param headers: AddHrmLegalEntityHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddHrmLegalEntityResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.ding_tenant_id):
            query['dingTenantId'] = request.ding_tenant_id
        body = {}
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.create_user_id):
            body['createUserId'] = request.create_user_id
        if not UtilClient.is_unset(request.ext):
            body['ext'] = request.ext
        if not UtilClient.is_unset(request.legal_entity_name):
            body['legalEntityName'] = request.legal_entity_name
        if not UtilClient.is_unset(request.legal_entity_short_name):
            body['legalEntityShortName'] = request.legal_entity_short_name
        if not UtilClient.is_unset(request.legal_entity_status):
            body['legalEntityStatus'] = request.legal_entity_status
        if not UtilClient.is_unset(request.legal_person_name):
            body['legalPersonName'] = request.legal_person_name
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='AddHrmLegalEntity',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/masters/legalEntities/companies',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.AddHrmLegalEntityResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_hrm_legal_entity(
        self,
        request: dingtalkhrm__1__0_models.AddHrmLegalEntityRequest,
    ) -> dingtalkhrm__1__0_models.AddHrmLegalEntityResponse:
        """
        @summary 新增法人公司
        
        @param request: AddHrmLegalEntityRequest
        @return: AddHrmLegalEntityResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.AddHrmLegalEntityHeaders()
        return self.add_hrm_legal_entity_with_options(request, headers, runtime)

    async def add_hrm_legal_entity_async(
        self,
        request: dingtalkhrm__1__0_models.AddHrmLegalEntityRequest,
    ) -> dingtalkhrm__1__0_models.AddHrmLegalEntityResponse:
        """
        @summary 新增法人公司
        
        @param request: AddHrmLegalEntityRequest
        @return: AddHrmLegalEntityResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.AddHrmLegalEntityHeaders()
        return await self.add_hrm_legal_entity_with_options_async(request, headers, runtime)

    def add_hrm_preentry_with_options(
        self,
        request: dingtalkhrm__1__0_models.AddHrmPreentryRequest,
        headers: dingtalkhrm__1__0_models.AddHrmPreentryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.AddHrmPreentryResponse:
        """
        @summary 智能人事添加待入职员工信息(支持花名册数据和分组明细更新)
        
        @param request: AddHrmPreentryRequest
        @param headers: AddHrmPreentryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddHrmPreentryResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.agent_id):
            body['agentId'] = request.agent_id
        if not UtilClient.is_unset(request.groups):
            body['groups'] = request.groups
        if not UtilClient.is_unset(request.mobile):
            body['mobile'] = request.mobile
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.need_send_pre_entry_msg):
            body['needSendPreEntryMsg'] = request.need_send_pre_entry_msg
        if not UtilClient.is_unset(request.pre_entry_time):
            body['preEntryTime'] = request.pre_entry_time
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
            action='AddHrmPreentry',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/preentries',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.AddHrmPreentryResponse(),
            self.execute(params, req, runtime)
        )

    async def add_hrm_preentry_with_options_async(
        self,
        request: dingtalkhrm__1__0_models.AddHrmPreentryRequest,
        headers: dingtalkhrm__1__0_models.AddHrmPreentryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.AddHrmPreentryResponse:
        """
        @summary 智能人事添加待入职员工信息(支持花名册数据和分组明细更新)
        
        @param request: AddHrmPreentryRequest
        @param headers: AddHrmPreentryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddHrmPreentryResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.agent_id):
            body['agentId'] = request.agent_id
        if not UtilClient.is_unset(request.groups):
            body['groups'] = request.groups
        if not UtilClient.is_unset(request.mobile):
            body['mobile'] = request.mobile
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.need_send_pre_entry_msg):
            body['needSendPreEntryMsg'] = request.need_send_pre_entry_msg
        if not UtilClient.is_unset(request.pre_entry_time):
            body['preEntryTime'] = request.pre_entry_time
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
            action='AddHrmPreentry',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/preentries',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.AddHrmPreentryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_hrm_preentry(
        self,
        request: dingtalkhrm__1__0_models.AddHrmPreentryRequest,
    ) -> dingtalkhrm__1__0_models.AddHrmPreentryResponse:
        """
        @summary 智能人事添加待入职员工信息(支持花名册数据和分组明细更新)
        
        @param request: AddHrmPreentryRequest
        @return: AddHrmPreentryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.AddHrmPreentryHeaders()
        return self.add_hrm_preentry_with_options(request, headers, runtime)

    async def add_hrm_preentry_async(
        self,
        request: dingtalkhrm__1__0_models.AddHrmPreentryRequest,
    ) -> dingtalkhrm__1__0_models.AddHrmPreentryResponse:
        """
        @summary 智能人事添加待入职员工信息(支持花名册数据和分组明细更新)
        
        @param request: AddHrmPreentryRequest
        @return: AddHrmPreentryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.AddHrmPreentryHeaders()
        return await self.add_hrm_preentry_with_options_async(request, headers, runtime)

    def create_record_with_options(
        self,
        request: dingtalkhrm__1__0_models.CreateRecordRequest,
        headers: dingtalkhrm__1__0_models.CreateRecordHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.CreateRecordResponse:
        """
        @summary 创建电子签签署记录
        
        @param request: CreateRecordRequest
        @param headers: CreateRecordHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateRecordResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.attachment_list):
            body['attachmentList'] = request.attachment_list
        if not UtilClient.is_unset(request.dept_id):
            body['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.field_list):
            body['fieldList'] = request.field_list
        if not UtilClient.is_unset(request.group_list):
            body['groupList'] = request.group_list
        if not UtilClient.is_unset(request.remark):
            body['remark'] = request.remark
        if not UtilClient.is_unset(request.sign_last_legal_entity_name):
            body['signLastLegalEntityName'] = request.sign_last_legal_entity_name
        if not UtilClient.is_unset(request.sign_legal_entity_name):
            body['signLegalEntityName'] = request.sign_legal_entity_name
        if not UtilClient.is_unset(request.sign_source):
            body['signSource'] = request.sign_source
        if not UtilClient.is_unset(request.sign_start_user_id):
            body['signStartUserId'] = request.sign_start_user_id
        if not UtilClient.is_unset(request.sign_user_id):
            body['signUserId'] = request.sign_user_id
        if not UtilClient.is_unset(request.template_id):
            body['templateId'] = request.template_id
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
            action='CreateRecord',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/masters/signCenters/records',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.CreateRecordResponse(),
            self.execute(params, req, runtime)
        )

    async def create_record_with_options_async(
        self,
        request: dingtalkhrm__1__0_models.CreateRecordRequest,
        headers: dingtalkhrm__1__0_models.CreateRecordHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.CreateRecordResponse:
        """
        @summary 创建电子签签署记录
        
        @param request: CreateRecordRequest
        @param headers: CreateRecordHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateRecordResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.attachment_list):
            body['attachmentList'] = request.attachment_list
        if not UtilClient.is_unset(request.dept_id):
            body['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.field_list):
            body['fieldList'] = request.field_list
        if not UtilClient.is_unset(request.group_list):
            body['groupList'] = request.group_list
        if not UtilClient.is_unset(request.remark):
            body['remark'] = request.remark
        if not UtilClient.is_unset(request.sign_last_legal_entity_name):
            body['signLastLegalEntityName'] = request.sign_last_legal_entity_name
        if not UtilClient.is_unset(request.sign_legal_entity_name):
            body['signLegalEntityName'] = request.sign_legal_entity_name
        if not UtilClient.is_unset(request.sign_source):
            body['signSource'] = request.sign_source
        if not UtilClient.is_unset(request.sign_start_user_id):
            body['signStartUserId'] = request.sign_start_user_id
        if not UtilClient.is_unset(request.sign_user_id):
            body['signUserId'] = request.sign_user_id
        if not UtilClient.is_unset(request.template_id):
            body['templateId'] = request.template_id
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
            action='CreateRecord',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/masters/signCenters/records',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.CreateRecordResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_record(
        self,
        request: dingtalkhrm__1__0_models.CreateRecordRequest,
    ) -> dingtalkhrm__1__0_models.CreateRecordResponse:
        """
        @summary 创建电子签签署记录
        
        @param request: CreateRecordRequest
        @return: CreateRecordResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.CreateRecordHeaders()
        return self.create_record_with_options(request, headers, runtime)

    async def create_record_async(
        self,
        request: dingtalkhrm__1__0_models.CreateRecordRequest,
    ) -> dingtalkhrm__1__0_models.CreateRecordResponse:
        """
        @summary 创建电子签签署记录
        
        @param request: CreateRecordRequest
        @return: CreateRecordResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.CreateRecordHeaders()
        return await self.create_record_with_options_async(request, headers, runtime)

    def device_market_manager_with_options(
        self,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.DeviceMarketManagerResponse:
        """
        @summary 智能人事设备市场管理
        
        @param headers: map
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeviceMarketManagerResponse
        """
        req = open_api_models.OpenApiRequest(
            headers=headers
        )
        params = open_api_models.Params(
            action='DeviceMarketManager',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/device/market/manager',
            method='GET',
            auth_type='Anonymous',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.DeviceMarketManagerResponse(),
            self.execute(params, req, runtime)
        )

    async def device_market_manager_with_options_async(
        self,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.DeviceMarketManagerResponse:
        """
        @summary 智能人事设备市场管理
        
        @param headers: map
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeviceMarketManagerResponse
        """
        req = open_api_models.OpenApiRequest(
            headers=headers
        )
        params = open_api_models.Params(
            action='DeviceMarketManager',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/device/market/manager',
            method='GET',
            auth_type='Anonymous',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.DeviceMarketManagerResponse(),
            await self.execute_async(params, req, runtime)
        )

    def device_market_manager(self) -> dingtalkhrm__1__0_models.DeviceMarketManagerResponse:
        """
        @summary 智能人事设备市场管理
        
        @return: DeviceMarketManagerResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = {}
        return self.device_market_manager_with_options(headers, runtime)

    async def device_market_manager_async(self) -> dingtalkhrm__1__0_models.DeviceMarketManagerResponse:
        """
        @summary 智能人事设备市场管理
        
        @return: DeviceMarketManagerResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = {}
        return await self.device_market_manager_with_options_async(headers, runtime)

    def device_market_order_manager_with_options(
        self,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.DeviceMarketOrderManagerResponse:
        """
        @summary 智能人事设备定向管理接口
        
        @param headers: map
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeviceMarketOrderManagerResponse
        """
        req = open_api_models.OpenApiRequest(
            headers=headers
        )
        params = open_api_models.Params(
            action='DeviceMarketOrderManager',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/device/market/order/manager',
            method='GET',
            auth_type='Anonymous',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.DeviceMarketOrderManagerResponse(),
            self.execute(params, req, runtime)
        )

    async def device_market_order_manager_with_options_async(
        self,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.DeviceMarketOrderManagerResponse:
        """
        @summary 智能人事设备定向管理接口
        
        @param headers: map
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeviceMarketOrderManagerResponse
        """
        req = open_api_models.OpenApiRequest(
            headers=headers
        )
        params = open_api_models.Params(
            action='DeviceMarketOrderManager',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/device/market/order/manager',
            method='GET',
            auth_type='Anonymous',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.DeviceMarketOrderManagerResponse(),
            await self.execute_async(params, req, runtime)
        )

    def device_market_order_manager(self) -> dingtalkhrm__1__0_models.DeviceMarketOrderManagerResponse:
        """
        @summary 智能人事设备定向管理接口
        
        @return: DeviceMarketOrderManagerResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = {}
        return self.device_market_order_manager_with_options(headers, runtime)

    async def device_market_order_manager_async(self) -> dingtalkhrm__1__0_models.DeviceMarketOrderManagerResponse:
        """
        @summary 智能人事设备定向管理接口
        
        @return: DeviceMarketOrderManagerResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = {}
        return await self.device_market_order_manager_with_options_async(headers, runtime)

    def e_cert_query_with_options(
        self,
        request: dingtalkhrm__1__0_models.ECertQueryRequest,
        headers: dingtalkhrm__1__0_models.ECertQueryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.ECertQueryResponse:
        """
        @summary e签宝专有查询证件接口
        
        @param request: ECertQueryRequest
        @param headers: ECertQueryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ECertQueryResponse
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
            action='ECertQuery',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/eCerts',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.ECertQueryResponse(),
            self.execute(params, req, runtime)
        )

    async def e_cert_query_with_options_async(
        self,
        request: dingtalkhrm__1__0_models.ECertQueryRequest,
        headers: dingtalkhrm__1__0_models.ECertQueryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.ECertQueryResponse:
        """
        @summary e签宝专有查询证件接口
        
        @param request: ECertQueryRequest
        @param headers: ECertQueryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ECertQueryResponse
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
            action='ECertQuery',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/eCerts',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.ECertQueryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def e_cert_query(
        self,
        request: dingtalkhrm__1__0_models.ECertQueryRequest,
    ) -> dingtalkhrm__1__0_models.ECertQueryResponse:
        """
        @summary e签宝专有查询证件接口
        
        @param request: ECertQueryRequest
        @return: ECertQueryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.ECertQueryHeaders()
        return self.e_cert_query_with_options(request, headers, runtime)

    async def e_cert_query_async(
        self,
        request: dingtalkhrm__1__0_models.ECertQueryRequest,
    ) -> dingtalkhrm__1__0_models.ECertQueryResponse:
        """
        @summary e签宝专有查询证件接口
        
        @param request: ECertQueryRequest
        @return: ECertQueryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.ECertQueryHeaders()
        return await self.e_cert_query_with_options_async(request, headers, runtime)

    def employee_attachment_update_with_options(
        self,
        request: dingtalkhrm__1__0_models.EmployeeAttachmentUpdateRequest,
        headers: dingtalkhrm__1__0_models.EmployeeAttachmentUpdateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.EmployeeAttachmentUpdateResponse:
        """
        @summary 智能人事员工档案附件更新
        
        @param request: EmployeeAttachmentUpdateRequest
        @param headers: EmployeeAttachmentUpdateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: EmployeeAttachmentUpdateResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_agent_id):
            query['appAgentId'] = request.app_agent_id
        body = {}
        if not UtilClient.is_unset(request.field_code):
            body['fieldCode'] = request.field_code
        if not UtilClient.is_unset(request.file_suffix):
            body['fileSuffix'] = request.file_suffix
        if not UtilClient.is_unset(request.media_id):
            body['mediaId'] = request.media_id
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='EmployeeAttachmentUpdate',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/employees/attachments',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.EmployeeAttachmentUpdateResponse(),
            self.execute(params, req, runtime)
        )

    async def employee_attachment_update_with_options_async(
        self,
        request: dingtalkhrm__1__0_models.EmployeeAttachmentUpdateRequest,
        headers: dingtalkhrm__1__0_models.EmployeeAttachmentUpdateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.EmployeeAttachmentUpdateResponse:
        """
        @summary 智能人事员工档案附件更新
        
        @param request: EmployeeAttachmentUpdateRequest
        @param headers: EmployeeAttachmentUpdateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: EmployeeAttachmentUpdateResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_agent_id):
            query['appAgentId'] = request.app_agent_id
        body = {}
        if not UtilClient.is_unset(request.field_code):
            body['fieldCode'] = request.field_code
        if not UtilClient.is_unset(request.file_suffix):
            body['fileSuffix'] = request.file_suffix
        if not UtilClient.is_unset(request.media_id):
            body['mediaId'] = request.media_id
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='EmployeeAttachmentUpdate',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/employees/attachments',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.EmployeeAttachmentUpdateResponse(),
            await self.execute_async(params, req, runtime)
        )

    def employee_attachment_update(
        self,
        request: dingtalkhrm__1__0_models.EmployeeAttachmentUpdateRequest,
    ) -> dingtalkhrm__1__0_models.EmployeeAttachmentUpdateResponse:
        """
        @summary 智能人事员工档案附件更新
        
        @param request: EmployeeAttachmentUpdateRequest
        @return: EmployeeAttachmentUpdateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.EmployeeAttachmentUpdateHeaders()
        return self.employee_attachment_update_with_options(request, headers, runtime)

    async def employee_attachment_update_async(
        self,
        request: dingtalkhrm__1__0_models.EmployeeAttachmentUpdateRequest,
    ) -> dingtalkhrm__1__0_models.EmployeeAttachmentUpdateResponse:
        """
        @summary 智能人事员工档案附件更新
        
        @param request: EmployeeAttachmentUpdateRequest
        @return: EmployeeAttachmentUpdateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.EmployeeAttachmentUpdateHeaders()
        return await self.employee_attachment_update_with_options_async(request, headers, runtime)

    def esign_rollback_with_options(
        self,
        request: dingtalkhrm__1__0_models.EsignRollbackRequest,
        headers: dingtalkhrm__1__0_models.EsignRollbackHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.EsignRollbackResponse:
        """
        @summary 人事高级合同管理回退
        
        @param request: EsignRollbackRequest
        @param headers: EsignRollbackHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: EsignRollbackResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.opt_user_id):
            query['optUserId'] = request.opt_user_id
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
            action='EsignRollback',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/contracts/esign/rollback',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.EsignRollbackResponse(),
            self.execute(params, req, runtime)
        )

    async def esign_rollback_with_options_async(
        self,
        request: dingtalkhrm__1__0_models.EsignRollbackRequest,
        headers: dingtalkhrm__1__0_models.EsignRollbackHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.EsignRollbackResponse:
        """
        @summary 人事高级合同管理回退
        
        @param request: EsignRollbackRequest
        @param headers: EsignRollbackHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: EsignRollbackResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.opt_user_id):
            query['optUserId'] = request.opt_user_id
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
            action='EsignRollback',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/contracts/esign/rollback',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.EsignRollbackResponse(),
            await self.execute_async(params, req, runtime)
        )

    def esign_rollback(
        self,
        request: dingtalkhrm__1__0_models.EsignRollbackRequest,
    ) -> dingtalkhrm__1__0_models.EsignRollbackResponse:
        """
        @summary 人事高级合同管理回退
        
        @param request: EsignRollbackRequest
        @return: EsignRollbackResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.EsignRollbackHeaders()
        return self.esign_rollback_with_options(request, headers, runtime)

    async def esign_rollback_async(
        self,
        request: dingtalkhrm__1__0_models.EsignRollbackRequest,
    ) -> dingtalkhrm__1__0_models.EsignRollbackResponse:
        """
        @summary 人事高级合同管理回退
        
        @param request: EsignRollbackRequest
        @return: EsignRollbackResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.EsignRollbackHeaders()
        return await self.esign_rollback_with_options_async(request, headers, runtime)

    def get_employee_roster_by_field_with_options(
        self,
        request: dingtalkhrm__1__0_models.GetEmployeeRosterByFieldRequest,
        headers: dingtalkhrm__1__0_models.GetEmployeeRosterByFieldHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.GetEmployeeRosterByFieldResponse:
        """
        @summary 获取员工花名册指定字段的信息，支持明细分组字段
        
        @param request: GetEmployeeRosterByFieldRequest
        @param headers: GetEmployeeRosterByFieldHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetEmployeeRosterByFieldResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_agent_id):
            body['appAgentId'] = request.app_agent_id
        if not UtilClient.is_unset(request.field_filter_list):
            body['fieldFilterList'] = request.field_filter_list
        if not UtilClient.is_unset(request.text_2select_convert):
            body['text2SelectConvert'] = request.text_2select_convert
        if not UtilClient.is_unset(request.user_id_list):
            body['userIdList'] = request.user_id_list
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
            action='GetEmployeeRosterByField',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/rosters/lists/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.GetEmployeeRosterByFieldResponse(),
            self.execute(params, req, runtime)
        )

    async def get_employee_roster_by_field_with_options_async(
        self,
        request: dingtalkhrm__1__0_models.GetEmployeeRosterByFieldRequest,
        headers: dingtalkhrm__1__0_models.GetEmployeeRosterByFieldHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.GetEmployeeRosterByFieldResponse:
        """
        @summary 获取员工花名册指定字段的信息，支持明细分组字段
        
        @param request: GetEmployeeRosterByFieldRequest
        @param headers: GetEmployeeRosterByFieldHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetEmployeeRosterByFieldResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_agent_id):
            body['appAgentId'] = request.app_agent_id
        if not UtilClient.is_unset(request.field_filter_list):
            body['fieldFilterList'] = request.field_filter_list
        if not UtilClient.is_unset(request.text_2select_convert):
            body['text2SelectConvert'] = request.text_2select_convert
        if not UtilClient.is_unset(request.user_id_list):
            body['userIdList'] = request.user_id_list
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
            action='GetEmployeeRosterByField',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/rosters/lists/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.GetEmployeeRosterByFieldResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_employee_roster_by_field(
        self,
        request: dingtalkhrm__1__0_models.GetEmployeeRosterByFieldRequest,
    ) -> dingtalkhrm__1__0_models.GetEmployeeRosterByFieldResponse:
        """
        @summary 获取员工花名册指定字段的信息，支持明细分组字段
        
        @param request: GetEmployeeRosterByFieldRequest
        @return: GetEmployeeRosterByFieldResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.GetEmployeeRosterByFieldHeaders()
        return self.get_employee_roster_by_field_with_options(request, headers, runtime)

    async def get_employee_roster_by_field_async(
        self,
        request: dingtalkhrm__1__0_models.GetEmployeeRosterByFieldRequest,
    ) -> dingtalkhrm__1__0_models.GetEmployeeRosterByFieldResponse:
        """
        @summary 获取员工花名册指定字段的信息，支持明细分组字段
        
        @param request: GetEmployeeRosterByFieldRequest
        @return: GetEmployeeRosterByFieldResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.GetEmployeeRosterByFieldHeaders()
        return await self.get_employee_roster_by_field_with_options_async(request, headers, runtime)

    def get_file_template_list_with_options(
        self,
        request: dingtalkhrm__1__0_models.GetFileTemplateListRequest,
        headers: dingtalkhrm__1__0_models.GetFileTemplateListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.GetFileTemplateListResponse:
        """
        @summary 查询文件模板列表及文件模板内花名册字段
        
        @param request: GetFileTemplateListRequest
        @param headers: GetFileTemplateListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetFileTemplateListResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.sign_source):
            body['signSource'] = request.sign_source
        if not UtilClient.is_unset(request.template_status):
            body['templateStatus'] = request.template_status
        if not UtilClient.is_unset(request.template_type_list):
            body['templateTypeList'] = request.template_type_list
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
            action='GetFileTemplateList',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/masters/fileTemplates/lists/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.GetFileTemplateListResponse(),
            self.execute(params, req, runtime)
        )

    async def get_file_template_list_with_options_async(
        self,
        request: dingtalkhrm__1__0_models.GetFileTemplateListRequest,
        headers: dingtalkhrm__1__0_models.GetFileTemplateListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.GetFileTemplateListResponse:
        """
        @summary 查询文件模板列表及文件模板内花名册字段
        
        @param request: GetFileTemplateListRequest
        @param headers: GetFileTemplateListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetFileTemplateListResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.sign_source):
            body['signSource'] = request.sign_source
        if not UtilClient.is_unset(request.template_status):
            body['templateStatus'] = request.template_status
        if not UtilClient.is_unset(request.template_type_list):
            body['templateTypeList'] = request.template_type_list
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
            action='GetFileTemplateList',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/masters/fileTemplates/lists/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.GetFileTemplateListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_file_template_list(
        self,
        request: dingtalkhrm__1__0_models.GetFileTemplateListRequest,
    ) -> dingtalkhrm__1__0_models.GetFileTemplateListResponse:
        """
        @summary 查询文件模板列表及文件模板内花名册字段
        
        @param request: GetFileTemplateListRequest
        @return: GetFileTemplateListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.GetFileTemplateListHeaders()
        return self.get_file_template_list_with_options(request, headers, runtime)

    async def get_file_template_list_async(
        self,
        request: dingtalkhrm__1__0_models.GetFileTemplateListRequest,
    ) -> dingtalkhrm__1__0_models.GetFileTemplateListResponse:
        """
        @summary 查询文件模板列表及文件模板内花名册字段
        
        @param request: GetFileTemplateListRequest
        @return: GetFileTemplateListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.GetFileTemplateListHeaders()
        return await self.get_file_template_list_with_options_async(request, headers, runtime)

    def get_sign_record_by_id_with_options(
        self,
        request: dingtalkhrm__1__0_models.GetSignRecordByIdRequest,
        headers: dingtalkhrm__1__0_models.GetSignRecordByIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.GetSignRecordByIdResponse:
        """
        @summary 通过签署记录id查询指定的电子签署记录
        
        @param request: GetSignRecordByIdRequest
        @param headers: GetSignRecordByIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSignRecordByIdResponse
        """
        UtilClient.validate_model(request)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=request.body
        )
        params = open_api_models.Params(
            action='GetSignRecordById',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/masters/signCenters/records/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.GetSignRecordByIdResponse(),
            self.execute(params, req, runtime)
        )

    async def get_sign_record_by_id_with_options_async(
        self,
        request: dingtalkhrm__1__0_models.GetSignRecordByIdRequest,
        headers: dingtalkhrm__1__0_models.GetSignRecordByIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.GetSignRecordByIdResponse:
        """
        @summary 通过签署记录id查询指定的电子签署记录
        
        @param request: GetSignRecordByIdRequest
        @param headers: GetSignRecordByIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSignRecordByIdResponse
        """
        UtilClient.validate_model(request)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=request.body
        )
        params = open_api_models.Params(
            action='GetSignRecordById',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/masters/signCenters/records/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.GetSignRecordByIdResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_sign_record_by_id(
        self,
        request: dingtalkhrm__1__0_models.GetSignRecordByIdRequest,
    ) -> dingtalkhrm__1__0_models.GetSignRecordByIdResponse:
        """
        @summary 通过签署记录id查询指定的电子签署记录
        
        @param request: GetSignRecordByIdRequest
        @return: GetSignRecordByIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.GetSignRecordByIdHeaders()
        return self.get_sign_record_by_id_with_options(request, headers, runtime)

    async def get_sign_record_by_id_async(
        self,
        request: dingtalkhrm__1__0_models.GetSignRecordByIdRequest,
    ) -> dingtalkhrm__1__0_models.GetSignRecordByIdResponse:
        """
        @summary 通过签署记录id查询指定的电子签署记录
        
        @param request: GetSignRecordByIdRequest
        @return: GetSignRecordByIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.GetSignRecordByIdHeaders()
        return await self.get_sign_record_by_id_with_options_async(request, headers, runtime)

    def get_sign_record_by_user_id_with_options(
        self,
        request: dingtalkhrm__1__0_models.GetSignRecordByUserIdRequest,
        headers: dingtalkhrm__1__0_models.GetSignRecordByUserIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.GetSignRecordByUserIdResponse:
        """
        @summary 查询指定用户的电子签署记录，并返回签署记录的基本数据及已签署完成的文件预览地址
        
        @param request: GetSignRecordByUserIdRequest
        @param headers: GetSignRecordByUserIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSignRecordByUserIdResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.sign_status):
            body['signStatus'] = request.sign_status
        if not UtilClient.is_unset(request.sign_user_id):
            body['signUserId'] = request.sign_user_id
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
            action='GetSignRecordByUserId',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/masters/signCenters/users/records/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.GetSignRecordByUserIdResponse(),
            self.execute(params, req, runtime)
        )

    async def get_sign_record_by_user_id_with_options_async(
        self,
        request: dingtalkhrm__1__0_models.GetSignRecordByUserIdRequest,
        headers: dingtalkhrm__1__0_models.GetSignRecordByUserIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.GetSignRecordByUserIdResponse:
        """
        @summary 查询指定用户的电子签署记录，并返回签署记录的基本数据及已签署完成的文件预览地址
        
        @param request: GetSignRecordByUserIdRequest
        @param headers: GetSignRecordByUserIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSignRecordByUserIdResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.sign_status):
            body['signStatus'] = request.sign_status
        if not UtilClient.is_unset(request.sign_user_id):
            body['signUserId'] = request.sign_user_id
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
            action='GetSignRecordByUserId',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/masters/signCenters/users/records/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.GetSignRecordByUserIdResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_sign_record_by_user_id(
        self,
        request: dingtalkhrm__1__0_models.GetSignRecordByUserIdRequest,
    ) -> dingtalkhrm__1__0_models.GetSignRecordByUserIdResponse:
        """
        @summary 查询指定用户的电子签署记录，并返回签署记录的基本数据及已签署完成的文件预览地址
        
        @param request: GetSignRecordByUserIdRequest
        @return: GetSignRecordByUserIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.GetSignRecordByUserIdHeaders()
        return self.get_sign_record_by_user_id_with_options(request, headers, runtime)

    async def get_sign_record_by_user_id_async(
        self,
        request: dingtalkhrm__1__0_models.GetSignRecordByUserIdRequest,
    ) -> dingtalkhrm__1__0_models.GetSignRecordByUserIdResponse:
        """
        @summary 查询指定用户的电子签署记录，并返回签署记录的基本数据及已签署完成的文件预览地址
        
        @param request: GetSignRecordByUserIdRequest
        @return: GetSignRecordByUserIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.GetSignRecordByUserIdHeaders()
        return await self.get_sign_record_by_user_id_with_options_async(request, headers, runtime)

    def hrm_auth_resources_query_with_options(
        self,
        request: dingtalkhrm__1__0_models.HrmAuthResourcesQueryRequest,
        headers: dingtalkhrm__1__0_models.HrmAuthResourcesQueryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.HrmAuthResourcesQueryResponse:
        """
        @summary 智能人事权限查询
        
        @param request: HrmAuthResourcesQueryRequest
        @param headers: HrmAuthResourcesQueryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrmAuthResourcesQueryResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.auth_resource_ids):
            body['authResourceIds'] = request.auth_resource_ids
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
            action='HrmAuthResourcesQuery',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/authResources/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.HrmAuthResourcesQueryResponse(),
            self.execute(params, req, runtime)
        )

    async def hrm_auth_resources_query_with_options_async(
        self,
        request: dingtalkhrm__1__0_models.HrmAuthResourcesQueryRequest,
        headers: dingtalkhrm__1__0_models.HrmAuthResourcesQueryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.HrmAuthResourcesQueryResponse:
        """
        @summary 智能人事权限查询
        
        @param request: HrmAuthResourcesQueryRequest
        @param headers: HrmAuthResourcesQueryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrmAuthResourcesQueryResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.auth_resource_ids):
            body['authResourceIds'] = request.auth_resource_ids
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
            action='HrmAuthResourcesQuery',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/authResources/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.HrmAuthResourcesQueryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def hrm_auth_resources_query(
        self,
        request: dingtalkhrm__1__0_models.HrmAuthResourcesQueryRequest,
    ) -> dingtalkhrm__1__0_models.HrmAuthResourcesQueryResponse:
        """
        @summary 智能人事权限查询
        
        @param request: HrmAuthResourcesQueryRequest
        @return: HrmAuthResourcesQueryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.HrmAuthResourcesQueryHeaders()
        return self.hrm_auth_resources_query_with_options(request, headers, runtime)

    async def hrm_auth_resources_query_async(
        self,
        request: dingtalkhrm__1__0_models.HrmAuthResourcesQueryRequest,
    ) -> dingtalkhrm__1__0_models.HrmAuthResourcesQueryResponse:
        """
        @summary 智能人事权限查询
        
        @param request: HrmAuthResourcesQueryRequest
        @return: HrmAuthResourcesQueryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.HrmAuthResourcesQueryHeaders()
        return await self.hrm_auth_resources_query_with_options_async(request, headers, runtime)

    def hrm_benefit_query_with_options(
        self,
        request: dingtalkhrm__1__0_models.HrmBenefitQueryRequest,
        headers: dingtalkhrm__1__0_models.HrmBenefitQueryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.HrmBenefitQueryResponse:
        """
        @summary 智能人事权益查询
        
        @param request: HrmBenefitQueryRequest
        @param headers: HrmBenefitQueryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrmBenefitQueryResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.benefit_codes):
            body['benefitCodes'] = request.benefit_codes
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
            action='HrmBenefitQuery',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/benefits/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.HrmBenefitQueryResponse(),
            self.execute(params, req, runtime)
        )

    async def hrm_benefit_query_with_options_async(
        self,
        request: dingtalkhrm__1__0_models.HrmBenefitQueryRequest,
        headers: dingtalkhrm__1__0_models.HrmBenefitQueryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.HrmBenefitQueryResponse:
        """
        @summary 智能人事权益查询
        
        @param request: HrmBenefitQueryRequest
        @param headers: HrmBenefitQueryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrmBenefitQueryResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.benefit_codes):
            body['benefitCodes'] = request.benefit_codes
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
            action='HrmBenefitQuery',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/benefits/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.HrmBenefitQueryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def hrm_benefit_query(
        self,
        request: dingtalkhrm__1__0_models.HrmBenefitQueryRequest,
    ) -> dingtalkhrm__1__0_models.HrmBenefitQueryResponse:
        """
        @summary 智能人事权益查询
        
        @param request: HrmBenefitQueryRequest
        @return: HrmBenefitQueryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.HrmBenefitQueryHeaders()
        return self.hrm_benefit_query_with_options(request, headers, runtime)

    async def hrm_benefit_query_async(
        self,
        request: dingtalkhrm__1__0_models.HrmBenefitQueryRequest,
    ) -> dingtalkhrm__1__0_models.HrmBenefitQueryResponse:
        """
        @summary 智能人事权益查询
        
        @param request: HrmBenefitQueryRequest
        @return: HrmBenefitQueryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.HrmBenefitQueryHeaders()
        return await self.hrm_benefit_query_with_options_async(request, headers, runtime)

    def hrm_corp_config_query_with_options(
        self,
        request: dingtalkhrm__1__0_models.HrmCorpConfigQueryRequest,
        headers: dingtalkhrm__1__0_models.HrmCorpConfigQueryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.HrmCorpConfigQueryResponse:
        """
        @summary 查询企业配置信息
        
        @param request: HrmCorpConfigQueryRequest
        @param headers: HrmCorpConfigQueryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrmCorpConfigQueryResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.sub_type):
            body['subType'] = request.sub_type
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
            action='HrmCorpConfigQuery',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/corp/configs/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.HrmCorpConfigQueryResponse(),
            self.execute(params, req, runtime)
        )

    async def hrm_corp_config_query_with_options_async(
        self,
        request: dingtalkhrm__1__0_models.HrmCorpConfigQueryRequest,
        headers: dingtalkhrm__1__0_models.HrmCorpConfigQueryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.HrmCorpConfigQueryResponse:
        """
        @summary 查询企业配置信息
        
        @param request: HrmCorpConfigQueryRequest
        @param headers: HrmCorpConfigQueryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrmCorpConfigQueryResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.sub_type):
            body['subType'] = request.sub_type
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
            action='HrmCorpConfigQuery',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/corp/configs/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.HrmCorpConfigQueryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def hrm_corp_config_query(
        self,
        request: dingtalkhrm__1__0_models.HrmCorpConfigQueryRequest,
    ) -> dingtalkhrm__1__0_models.HrmCorpConfigQueryResponse:
        """
        @summary 查询企业配置信息
        
        @param request: HrmCorpConfigQueryRequest
        @return: HrmCorpConfigQueryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.HrmCorpConfigQueryHeaders()
        return self.hrm_corp_config_query_with_options(request, headers, runtime)

    async def hrm_corp_config_query_async(
        self,
        request: dingtalkhrm__1__0_models.HrmCorpConfigQueryRequest,
    ) -> dingtalkhrm__1__0_models.HrmCorpConfigQueryResponse:
        """
        @summary 查询企业配置信息
        
        @param request: HrmCorpConfigQueryRequest
        @return: HrmCorpConfigQueryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.HrmCorpConfigQueryHeaders()
        return await self.hrm_corp_config_query_with_options_async(request, headers, runtime)

    def hrm_mail_send_with_options(
        self,
        request: dingtalkhrm__1__0_models.HrmMailSendRequest,
        headers: dingtalkhrm__1__0_models.HrmMailSendHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.HrmMailSendResponse:
        """
        @summary 智能人事邮件发送
        
        @param request: HrmMailSendRequest
        @param headers: HrmMailSendHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrmMailSendResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.mail):
            body['mail'] = request.mail
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
            action='HrmMailSend',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/mails/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.HrmMailSendResponse(),
            self.execute(params, req, runtime)
        )

    async def hrm_mail_send_with_options_async(
        self,
        request: dingtalkhrm__1__0_models.HrmMailSendRequest,
        headers: dingtalkhrm__1__0_models.HrmMailSendHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.HrmMailSendResponse:
        """
        @summary 智能人事邮件发送
        
        @param request: HrmMailSendRequest
        @param headers: HrmMailSendHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrmMailSendResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.mail):
            body['mail'] = request.mail
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
            action='HrmMailSend',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/mails/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.HrmMailSendResponse(),
            await self.execute_async(params, req, runtime)
        )

    def hrm_mail_send(
        self,
        request: dingtalkhrm__1__0_models.HrmMailSendRequest,
    ) -> dingtalkhrm__1__0_models.HrmMailSendResponse:
        """
        @summary 智能人事邮件发送
        
        @param request: HrmMailSendRequest
        @return: HrmMailSendResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.HrmMailSendHeaders()
        return self.hrm_mail_send_with_options(request, headers, runtime)

    async def hrm_mail_send_async(
        self,
        request: dingtalkhrm__1__0_models.HrmMailSendRequest,
    ) -> dingtalkhrm__1__0_models.HrmMailSendResponse:
        """
        @summary 智能人事邮件发送
        
        @param request: HrmMailSendRequest
        @return: HrmMailSendResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.HrmMailSendHeaders()
        return await self.hrm_mail_send_with_options_async(request, headers, runtime)

    def hrm_moka_event_with_options(
        self,
        request: dingtalkhrm__1__0_models.HrmMokaEventRequest,
        headers: dingtalkhrm__1__0_models.HrmMokaEventHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.HrmMokaEventResponse:
        """
        @summary 人事2.0支持Moka事件转发
        
        @param request: HrmMokaEventRequest
        @param headers: HrmMokaEventHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrmMokaEventResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
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
            action='HrmMokaEvent',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/moka/events/forward',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.HrmMokaEventResponse(),
            self.execute(params, req, runtime)
        )

    async def hrm_moka_event_with_options_async(
        self,
        request: dingtalkhrm__1__0_models.HrmMokaEventRequest,
        headers: dingtalkhrm__1__0_models.HrmMokaEventHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.HrmMokaEventResponse:
        """
        @summary 人事2.0支持Moka事件转发
        
        @param request: HrmMokaEventRequest
        @param headers: HrmMokaEventHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrmMokaEventResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
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
            action='HrmMokaEvent',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/moka/events/forward',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.HrmMokaEventResponse(),
            await self.execute_async(params, req, runtime)
        )

    def hrm_moka_event(
        self,
        request: dingtalkhrm__1__0_models.HrmMokaEventRequest,
    ) -> dingtalkhrm__1__0_models.HrmMokaEventResponse:
        """
        @summary 人事2.0支持Moka事件转发
        
        @param request: HrmMokaEventRequest
        @return: HrmMokaEventResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.HrmMokaEventHeaders()
        return self.hrm_moka_event_with_options(request, headers, runtime)

    async def hrm_moka_event_async(
        self,
        request: dingtalkhrm__1__0_models.HrmMokaEventRequest,
    ) -> dingtalkhrm__1__0_models.HrmMokaEventResponse:
        """
        @summary 人事2.0支持Moka事件转发
        
        @param request: HrmMokaEventRequest
        @return: HrmMokaEventResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.HrmMokaEventHeaders()
        return await self.hrm_moka_event_with_options_async(request, headers, runtime)

    def hrm_moka_oapi_with_options(
        self,
        request: dingtalkhrm__1__0_models.HrmMokaOapiRequest,
        headers: dingtalkhrm__1__0_models.HrmMokaOapiHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.HrmMokaOapiResponse:
        """
        @summary 人事2.0支持Moka接口转发
        
        @param request: HrmMokaOapiRequest
        @param headers: HrmMokaOapiHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrmMokaOapiResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.api_code):
            body['apiCode'] = request.api_code
        if not UtilClient.is_unset(request.params):
            body['params'] = request.params
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
            action='HrmMokaOapi',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/moka/forward',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.HrmMokaOapiResponse(),
            self.execute(params, req, runtime)
        )

    async def hrm_moka_oapi_with_options_async(
        self,
        request: dingtalkhrm__1__0_models.HrmMokaOapiRequest,
        headers: dingtalkhrm__1__0_models.HrmMokaOapiHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.HrmMokaOapiResponse:
        """
        @summary 人事2.0支持Moka接口转发
        
        @param request: HrmMokaOapiRequest
        @param headers: HrmMokaOapiHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrmMokaOapiResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.api_code):
            body['apiCode'] = request.api_code
        if not UtilClient.is_unset(request.params):
            body['params'] = request.params
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
            action='HrmMokaOapi',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/moka/forward',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.HrmMokaOapiResponse(),
            await self.execute_async(params, req, runtime)
        )

    def hrm_moka_oapi(
        self,
        request: dingtalkhrm__1__0_models.HrmMokaOapiRequest,
    ) -> dingtalkhrm__1__0_models.HrmMokaOapiResponse:
        """
        @summary 人事2.0支持Moka接口转发
        
        @param request: HrmMokaOapiRequest
        @return: HrmMokaOapiResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.HrmMokaOapiHeaders()
        return self.hrm_moka_oapi_with_options(request, headers, runtime)

    async def hrm_moka_oapi_async(
        self,
        request: dingtalkhrm__1__0_models.HrmMokaOapiRequest,
    ) -> dingtalkhrm__1__0_models.HrmMokaOapiResponse:
        """
        @summary 人事2.0支持Moka接口转发
        
        @param request: HrmMokaOapiRequest
        @return: HrmMokaOapiResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.HrmMokaOapiHeaders()
        return await self.hrm_moka_oapi_with_options_async(request, headers, runtime)

    def hrm_process_regular_with_options(
        self,
        request: dingtalkhrm__1__0_models.HrmProcessRegularRequest,
        headers: dingtalkhrm__1__0_models.HrmProcessRegularHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.HrmProcessRegularResponse:
        """
        @summary 智能人事转正接口
        
        @param request: HrmProcessRegularRequest
        @param headers: HrmProcessRegularHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrmProcessRegularResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.operation_id):
            body['operationId'] = request.operation_id
        if not UtilClient.is_unset(request.regular_date):
            body['regularDate'] = request.regular_date
        if not UtilClient.is_unset(request.remark):
            body['remark'] = request.remark
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
            action='HrmProcessRegular',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/processes/regulars/become',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.HrmProcessRegularResponse(),
            self.execute(params, req, runtime)
        )

    async def hrm_process_regular_with_options_async(
        self,
        request: dingtalkhrm__1__0_models.HrmProcessRegularRequest,
        headers: dingtalkhrm__1__0_models.HrmProcessRegularHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.HrmProcessRegularResponse:
        """
        @summary 智能人事转正接口
        
        @param request: HrmProcessRegularRequest
        @param headers: HrmProcessRegularHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrmProcessRegularResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.operation_id):
            body['operationId'] = request.operation_id
        if not UtilClient.is_unset(request.regular_date):
            body['regularDate'] = request.regular_date
        if not UtilClient.is_unset(request.remark):
            body['remark'] = request.remark
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
            action='HrmProcessRegular',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/processes/regulars/become',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.HrmProcessRegularResponse(),
            await self.execute_async(params, req, runtime)
        )

    def hrm_process_regular(
        self,
        request: dingtalkhrm__1__0_models.HrmProcessRegularRequest,
    ) -> dingtalkhrm__1__0_models.HrmProcessRegularResponse:
        """
        @summary 智能人事转正接口
        
        @param request: HrmProcessRegularRequest
        @return: HrmProcessRegularResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.HrmProcessRegularHeaders()
        return self.hrm_process_regular_with_options(request, headers, runtime)

    async def hrm_process_regular_async(
        self,
        request: dingtalkhrm__1__0_models.HrmProcessRegularRequest,
    ) -> dingtalkhrm__1__0_models.HrmProcessRegularResponse:
        """
        @summary 智能人事转正接口
        
        @param request: HrmProcessRegularRequest
        @return: HrmProcessRegularResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.HrmProcessRegularHeaders()
        return await self.hrm_process_regular_with_options_async(request, headers, runtime)

    def hrm_process_termination_and_handover_with_options(
        self,
        request: dingtalkhrm__1__0_models.HrmProcessTerminationAndHandoverRequest,
        headers: dingtalkhrm__1__0_models.HrmProcessTerminationAndHandoverHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.HrmProcessTerminationAndHandoverResponse:
        """
        @summary 智能人事离职和交接接口
        
        @param request: HrmProcessTerminationAndHandoverRequest
        @param headers: HrmProcessTerminationAndHandoverHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrmProcessTerminationAndHandoverResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.aflow_hand_over_user_id):
            body['aflowHandOverUserId'] = request.aflow_hand_over_user_id
        if not UtilClient.is_unset(request.ding_pan_handover_user_id):
            body['dingPanHandoverUserId'] = request.ding_pan_handover_user_id
        if not UtilClient.is_unset(request.direct_subordinates_handover_user_id):
            body['directSubordinatesHandoverUserId'] = request.direct_subordinates_handover_user_id
        if not UtilClient.is_unset(request.dismission_memo):
            body['dismissionMemo'] = request.dismission_memo
        if not UtilClient.is_unset(request.dismission_reason):
            body['dismissionReason'] = request.dismission_reason
        if not UtilClient.is_unset(request.doc_note_handover_user_id):
            body['docNoteHandoverUserId'] = request.doc_note_handover_user_id
        if not UtilClient.is_unset(request.last_work_date):
            body['lastWorkDate'] = request.last_work_date
        if not UtilClient.is_unset(request.opt_user_id):
            body['optUserId'] = request.opt_user_id
        if not UtilClient.is_unset(request.permission_handover_user_id):
            body['permissionHandoverUserId'] = request.permission_handover_user_id
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
            action='HrmProcessTerminationAndHandover',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/processes/terminateAndHandOver',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.HrmProcessTerminationAndHandoverResponse(),
            self.execute(params, req, runtime)
        )

    async def hrm_process_termination_and_handover_with_options_async(
        self,
        request: dingtalkhrm__1__0_models.HrmProcessTerminationAndHandoverRequest,
        headers: dingtalkhrm__1__0_models.HrmProcessTerminationAndHandoverHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.HrmProcessTerminationAndHandoverResponse:
        """
        @summary 智能人事离职和交接接口
        
        @param request: HrmProcessTerminationAndHandoverRequest
        @param headers: HrmProcessTerminationAndHandoverHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrmProcessTerminationAndHandoverResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.aflow_hand_over_user_id):
            body['aflowHandOverUserId'] = request.aflow_hand_over_user_id
        if not UtilClient.is_unset(request.ding_pan_handover_user_id):
            body['dingPanHandoverUserId'] = request.ding_pan_handover_user_id
        if not UtilClient.is_unset(request.direct_subordinates_handover_user_id):
            body['directSubordinatesHandoverUserId'] = request.direct_subordinates_handover_user_id
        if not UtilClient.is_unset(request.dismission_memo):
            body['dismissionMemo'] = request.dismission_memo
        if not UtilClient.is_unset(request.dismission_reason):
            body['dismissionReason'] = request.dismission_reason
        if not UtilClient.is_unset(request.doc_note_handover_user_id):
            body['docNoteHandoverUserId'] = request.doc_note_handover_user_id
        if not UtilClient.is_unset(request.last_work_date):
            body['lastWorkDate'] = request.last_work_date
        if not UtilClient.is_unset(request.opt_user_id):
            body['optUserId'] = request.opt_user_id
        if not UtilClient.is_unset(request.permission_handover_user_id):
            body['permissionHandoverUserId'] = request.permission_handover_user_id
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
            action='HrmProcessTerminationAndHandover',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/processes/terminateAndHandOver',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.HrmProcessTerminationAndHandoverResponse(),
            await self.execute_async(params, req, runtime)
        )

    def hrm_process_termination_and_handover(
        self,
        request: dingtalkhrm__1__0_models.HrmProcessTerminationAndHandoverRequest,
    ) -> dingtalkhrm__1__0_models.HrmProcessTerminationAndHandoverResponse:
        """
        @summary 智能人事离职和交接接口
        
        @param request: HrmProcessTerminationAndHandoverRequest
        @return: HrmProcessTerminationAndHandoverResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.HrmProcessTerminationAndHandoverHeaders()
        return self.hrm_process_termination_and_handover_with_options(request, headers, runtime)

    async def hrm_process_termination_and_handover_async(
        self,
        request: dingtalkhrm__1__0_models.HrmProcessTerminationAndHandoverRequest,
    ) -> dingtalkhrm__1__0_models.HrmProcessTerminationAndHandoverResponse:
        """
        @summary 智能人事离职和交接接口
        
        @param request: HrmProcessTerminationAndHandoverRequest
        @return: HrmProcessTerminationAndHandoverResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.HrmProcessTerminationAndHandoverHeaders()
        return await self.hrm_process_termination_and_handover_with_options_async(request, headers, runtime)

    def hrm_process_transfer_with_options(
        self,
        request: dingtalkhrm__1__0_models.HrmProcessTransferRequest,
        headers: dingtalkhrm__1__0_models.HrmProcessTransferHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.HrmProcessTransferResponse:
        """
        @summary 智能人事调岗接口
        
        @param request: HrmProcessTransferRequest
        @param headers: HrmProcessTransferHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrmProcessTransferResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dept_ids_after_transfer):
            body['deptIdsAfterTransfer'] = request.dept_ids_after_transfer
        if not UtilClient.is_unset(request.job_id_after_transfer):
            body['jobIdAfterTransfer'] = request.job_id_after_transfer
        if not UtilClient.is_unset(request.main_dept_id_after_transfer):
            body['mainDeptIdAfterTransfer'] = request.main_dept_id_after_transfer
        if not UtilClient.is_unset(request.operate_user_id):
            body['operateUserId'] = request.operate_user_id
        if not UtilClient.is_unset(request.position_id_after_transfer):
            body['positionIdAfterTransfer'] = request.position_id_after_transfer
        if not UtilClient.is_unset(request.position_level_after_transfer):
            body['positionLevelAfterTransfer'] = request.position_level_after_transfer
        if not UtilClient.is_unset(request.position_name_after_transfer):
            body['positionNameAfterTransfer'] = request.position_name_after_transfer
        if not UtilClient.is_unset(request.rank_id_after_transfer):
            body['rankIdAfterTransfer'] = request.rank_id_after_transfer
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
            action='HrmProcessTransfer',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/processes/transfer',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.HrmProcessTransferResponse(),
            self.execute(params, req, runtime)
        )

    async def hrm_process_transfer_with_options_async(
        self,
        request: dingtalkhrm__1__0_models.HrmProcessTransferRequest,
        headers: dingtalkhrm__1__0_models.HrmProcessTransferHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.HrmProcessTransferResponse:
        """
        @summary 智能人事调岗接口
        
        @param request: HrmProcessTransferRequest
        @param headers: HrmProcessTransferHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrmProcessTransferResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dept_ids_after_transfer):
            body['deptIdsAfterTransfer'] = request.dept_ids_after_transfer
        if not UtilClient.is_unset(request.job_id_after_transfer):
            body['jobIdAfterTransfer'] = request.job_id_after_transfer
        if not UtilClient.is_unset(request.main_dept_id_after_transfer):
            body['mainDeptIdAfterTransfer'] = request.main_dept_id_after_transfer
        if not UtilClient.is_unset(request.operate_user_id):
            body['operateUserId'] = request.operate_user_id
        if not UtilClient.is_unset(request.position_id_after_transfer):
            body['positionIdAfterTransfer'] = request.position_id_after_transfer
        if not UtilClient.is_unset(request.position_level_after_transfer):
            body['positionLevelAfterTransfer'] = request.position_level_after_transfer
        if not UtilClient.is_unset(request.position_name_after_transfer):
            body['positionNameAfterTransfer'] = request.position_name_after_transfer
        if not UtilClient.is_unset(request.rank_id_after_transfer):
            body['rankIdAfterTransfer'] = request.rank_id_after_transfer
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
            action='HrmProcessTransfer',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/processes/transfer',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.HrmProcessTransferResponse(),
            await self.execute_async(params, req, runtime)
        )

    def hrm_process_transfer(
        self,
        request: dingtalkhrm__1__0_models.HrmProcessTransferRequest,
    ) -> dingtalkhrm__1__0_models.HrmProcessTransferResponse:
        """
        @summary 智能人事调岗接口
        
        @param request: HrmProcessTransferRequest
        @return: HrmProcessTransferResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.HrmProcessTransferHeaders()
        return self.hrm_process_transfer_with_options(request, headers, runtime)

    async def hrm_process_transfer_async(
        self,
        request: dingtalkhrm__1__0_models.HrmProcessTransferRequest,
    ) -> dingtalkhrm__1__0_models.HrmProcessTransferResponse:
        """
        @summary 智能人事调岗接口
        
        @param request: HrmProcessTransferRequest
        @return: HrmProcessTransferResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.HrmProcessTransferHeaders()
        return await self.hrm_process_transfer_with_options_async(request, headers, runtime)

    def hrm_process_update_termination_info_with_options(
        self,
        request: dingtalkhrm__1__0_models.HrmProcessUpdateTerminationInfoRequest,
        headers: dingtalkhrm__1__0_models.HrmProcessUpdateTerminationInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.HrmProcessUpdateTerminationInfoResponse:
        """
        @summary 修改员工最后一次离职信息
        
        @param request: HrmProcessUpdateTerminationInfoRequest
        @param headers: HrmProcessUpdateTerminationInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrmProcessUpdateTerminationInfoResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dismission_memo):
            body['dismissionMemo'] = request.dismission_memo
        if not UtilClient.is_unset(request.last_work_date):
            body['lastWorkDate'] = request.last_work_date
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
            action='HrmProcessUpdateTerminationInfo',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/processes/employees/terminations',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.HrmProcessUpdateTerminationInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def hrm_process_update_termination_info_with_options_async(
        self,
        request: dingtalkhrm__1__0_models.HrmProcessUpdateTerminationInfoRequest,
        headers: dingtalkhrm__1__0_models.HrmProcessUpdateTerminationInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.HrmProcessUpdateTerminationInfoResponse:
        """
        @summary 修改员工最后一次离职信息
        
        @param request: HrmProcessUpdateTerminationInfoRequest
        @param headers: HrmProcessUpdateTerminationInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrmProcessUpdateTerminationInfoResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dismission_memo):
            body['dismissionMemo'] = request.dismission_memo
        if not UtilClient.is_unset(request.last_work_date):
            body['lastWorkDate'] = request.last_work_date
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
            action='HrmProcessUpdateTerminationInfo',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/processes/employees/terminations',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.HrmProcessUpdateTerminationInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def hrm_process_update_termination_info(
        self,
        request: dingtalkhrm__1__0_models.HrmProcessUpdateTerminationInfoRequest,
    ) -> dingtalkhrm__1__0_models.HrmProcessUpdateTerminationInfoResponse:
        """
        @summary 修改员工最后一次离职信息
        
        @param request: HrmProcessUpdateTerminationInfoRequest
        @return: HrmProcessUpdateTerminationInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.HrmProcessUpdateTerminationInfoHeaders()
        return self.hrm_process_update_termination_info_with_options(request, headers, runtime)

    async def hrm_process_update_termination_info_async(
        self,
        request: dingtalkhrm__1__0_models.HrmProcessUpdateTerminationInfoRequest,
    ) -> dingtalkhrm__1__0_models.HrmProcessUpdateTerminationInfoResponse:
        """
        @summary 修改员工最后一次离职信息
        
        @param request: HrmProcessUpdateTerminationInfoRequest
        @return: HrmProcessUpdateTerminationInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.HrmProcessUpdateTerminationInfoHeaders()
        return await self.hrm_process_update_termination_info_with_options_async(request, headers, runtime)

    def hrm_pts_service_with_options(
        self,
        request: dingtalkhrm__1__0_models.HrmPtsServiceRequest,
        headers: dingtalkhrm__1__0_models.HrmPtsServiceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.HrmPtsServiceResponse:
        """
        @summary 智能人事pts能力调用
        
        @param request: HrmPtsServiceRequest
        @param headers: HrmPtsServiceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrmPtsServiceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.env):
            body['env'] = request.env
        if not UtilClient.is_unset(request.method):
            body['method'] = request.method
        if not UtilClient.is_unset(request.outer_id):
            body['outerId'] = request.outer_id
        if not UtilClient.is_unset(request.params):
            body['params'] = request.params
        if not UtilClient.is_unset(request.path):
            body['path'] = request.path
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
            action='HrmPtsService',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/pts/request',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.HrmPtsServiceResponse(),
            self.execute(params, req, runtime)
        )

    async def hrm_pts_service_with_options_async(
        self,
        request: dingtalkhrm__1__0_models.HrmPtsServiceRequest,
        headers: dingtalkhrm__1__0_models.HrmPtsServiceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.HrmPtsServiceResponse:
        """
        @summary 智能人事pts能力调用
        
        @param request: HrmPtsServiceRequest
        @param headers: HrmPtsServiceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrmPtsServiceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.env):
            body['env'] = request.env
        if not UtilClient.is_unset(request.method):
            body['method'] = request.method
        if not UtilClient.is_unset(request.outer_id):
            body['outerId'] = request.outer_id
        if not UtilClient.is_unset(request.params):
            body['params'] = request.params
        if not UtilClient.is_unset(request.path):
            body['path'] = request.path
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
            action='HrmPtsService',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/pts/request',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.HrmPtsServiceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def hrm_pts_service(
        self,
        request: dingtalkhrm__1__0_models.HrmPtsServiceRequest,
    ) -> dingtalkhrm__1__0_models.HrmPtsServiceResponse:
        """
        @summary 智能人事pts能力调用
        
        @param request: HrmPtsServiceRequest
        @return: HrmPtsServiceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.HrmPtsServiceHeaders()
        return self.hrm_pts_service_with_options(request, headers, runtime)

    async def hrm_pts_service_async(
        self,
        request: dingtalkhrm__1__0_models.HrmPtsServiceRequest,
    ) -> dingtalkhrm__1__0_models.HrmPtsServiceResponse:
        """
        @summary 智能人事pts能力调用
        
        @param request: HrmPtsServiceRequest
        @return: HrmPtsServiceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.HrmPtsServiceHeaders()
        return await self.hrm_pts_service_with_options_async(request, headers, runtime)

    def invalid_sign_records_with_options(
        self,
        request: dingtalkhrm__1__0_models.InvalidSignRecordsRequest,
        headers: dingtalkhrm__1__0_models.InvalidSignRecordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.InvalidSignRecordsResponse:
        """
        @summary 作废签署记录
        
        @param request: InvalidSignRecordsRequest
        @param headers: InvalidSignRecordsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: InvalidSignRecordsResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.invalid_user_id):
            body['invalidUserId'] = request.invalid_user_id
        if not UtilClient.is_unset(request.sign_record_ids):
            body['signRecordIds'] = request.sign_record_ids
        if not UtilClient.is_unset(request.status_remark):
            body['statusRemark'] = request.status_remark
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
            action='InvalidSignRecords',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/masters/signCenters/records/invalid',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.InvalidSignRecordsResponse(),
            self.execute(params, req, runtime)
        )

    async def invalid_sign_records_with_options_async(
        self,
        request: dingtalkhrm__1__0_models.InvalidSignRecordsRequest,
        headers: dingtalkhrm__1__0_models.InvalidSignRecordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.InvalidSignRecordsResponse:
        """
        @summary 作废签署记录
        
        @param request: InvalidSignRecordsRequest
        @param headers: InvalidSignRecordsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: InvalidSignRecordsResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.invalid_user_id):
            body['invalidUserId'] = request.invalid_user_id
        if not UtilClient.is_unset(request.sign_record_ids):
            body['signRecordIds'] = request.sign_record_ids
        if not UtilClient.is_unset(request.status_remark):
            body['statusRemark'] = request.status_remark
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
            action='InvalidSignRecords',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/masters/signCenters/records/invalid',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.InvalidSignRecordsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def invalid_sign_records(
        self,
        request: dingtalkhrm__1__0_models.InvalidSignRecordsRequest,
    ) -> dingtalkhrm__1__0_models.InvalidSignRecordsResponse:
        """
        @summary 作废签署记录
        
        @param request: InvalidSignRecordsRequest
        @return: InvalidSignRecordsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.InvalidSignRecordsHeaders()
        return self.invalid_sign_records_with_options(request, headers, runtime)

    async def invalid_sign_records_async(
        self,
        request: dingtalkhrm__1__0_models.InvalidSignRecordsRequest,
    ) -> dingtalkhrm__1__0_models.InvalidSignRecordsResponse:
        """
        @summary 作废签署记录
        
        @param request: InvalidSignRecordsRequest
        @return: InvalidSignRecordsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.InvalidSignRecordsHeaders()
        return await self.invalid_sign_records_with_options_async(request, headers, runtime)

    def master_data_delete_with_options(
        self,
        request: dingtalkhrm__1__0_models.MasterDataDeleteRequest,
        headers: dingtalkhrm__1__0_models.MasterDataDeleteHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.MasterDataDeleteResponse:
        """
        @summary 智能人事主数据删除服务
        
        @param request: MasterDataDeleteRequest
        @param headers: MasterDataDeleteHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: MasterDataDeleteResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.tenant_id):
            query['tenantId'] = request.tenant_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=UtilClient.to_array(request.body)
        )
        params = open_api_models.Params(
            action='MasterDataDelete',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/masters/datas/batchRemove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.MasterDataDeleteResponse(),
            self.execute(params, req, runtime)
        )

    async def master_data_delete_with_options_async(
        self,
        request: dingtalkhrm__1__0_models.MasterDataDeleteRequest,
        headers: dingtalkhrm__1__0_models.MasterDataDeleteHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.MasterDataDeleteResponse:
        """
        @summary 智能人事主数据删除服务
        
        @param request: MasterDataDeleteRequest
        @param headers: MasterDataDeleteHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: MasterDataDeleteResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.tenant_id):
            query['tenantId'] = request.tenant_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=UtilClient.to_array(request.body)
        )
        params = open_api_models.Params(
            action='MasterDataDelete',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/masters/datas/batchRemove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.MasterDataDeleteResponse(),
            await self.execute_async(params, req, runtime)
        )

    def master_data_delete(
        self,
        request: dingtalkhrm__1__0_models.MasterDataDeleteRequest,
    ) -> dingtalkhrm__1__0_models.MasterDataDeleteResponse:
        """
        @summary 智能人事主数据删除服务
        
        @param request: MasterDataDeleteRequest
        @return: MasterDataDeleteResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.MasterDataDeleteHeaders()
        return self.master_data_delete_with_options(request, headers, runtime)

    async def master_data_delete_async(
        self,
        request: dingtalkhrm__1__0_models.MasterDataDeleteRequest,
    ) -> dingtalkhrm__1__0_models.MasterDataDeleteResponse:
        """
        @summary 智能人事主数据删除服务
        
        @param request: MasterDataDeleteRequest
        @return: MasterDataDeleteResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.MasterDataDeleteHeaders()
        return await self.master_data_delete_with_options_async(request, headers, runtime)

    def master_data_query_with_options(
        self,
        request: dingtalkhrm__1__0_models.MasterDataQueryRequest,
        headers: dingtalkhrm__1__0_models.MasterDataQueryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.MasterDataQueryResponse:
        """
        @summary 智能人事主数据查询服务
        
        @param request: MasterDataQueryRequest
        @param headers: MasterDataQueryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: MasterDataQueryResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_uk):
            body['bizUK'] = request.biz_uk
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.opt_user_id):
            body['optUserId'] = request.opt_user_id
        if not UtilClient.is_unset(request.query_params):
            body['queryParams'] = request.query_params
        if not UtilClient.is_unset(request.relation_ids):
            body['relationIds'] = request.relation_ids
        if not UtilClient.is_unset(request.scope_code):
            body['scopeCode'] = request.scope_code
        if not UtilClient.is_unset(request.tenant_id):
            body['tenantId'] = request.tenant_id
        if not UtilClient.is_unset(request.view_entity_code):
            body['viewEntityCode'] = request.view_entity_code
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
            action='MasterDataQuery',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/masters/datas/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.MasterDataQueryResponse(),
            self.execute(params, req, runtime)
        )

    async def master_data_query_with_options_async(
        self,
        request: dingtalkhrm__1__0_models.MasterDataQueryRequest,
        headers: dingtalkhrm__1__0_models.MasterDataQueryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.MasterDataQueryResponse:
        """
        @summary 智能人事主数据查询服务
        
        @param request: MasterDataQueryRequest
        @param headers: MasterDataQueryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: MasterDataQueryResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_uk):
            body['bizUK'] = request.biz_uk
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.opt_user_id):
            body['optUserId'] = request.opt_user_id
        if not UtilClient.is_unset(request.query_params):
            body['queryParams'] = request.query_params
        if not UtilClient.is_unset(request.relation_ids):
            body['relationIds'] = request.relation_ids
        if not UtilClient.is_unset(request.scope_code):
            body['scopeCode'] = request.scope_code
        if not UtilClient.is_unset(request.tenant_id):
            body['tenantId'] = request.tenant_id
        if not UtilClient.is_unset(request.view_entity_code):
            body['viewEntityCode'] = request.view_entity_code
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
            action='MasterDataQuery',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/masters/datas/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.MasterDataQueryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def master_data_query(
        self,
        request: dingtalkhrm__1__0_models.MasterDataQueryRequest,
    ) -> dingtalkhrm__1__0_models.MasterDataQueryResponse:
        """
        @summary 智能人事主数据查询服务
        
        @param request: MasterDataQueryRequest
        @return: MasterDataQueryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.MasterDataQueryHeaders()
        return self.master_data_query_with_options(request, headers, runtime)

    async def master_data_query_async(
        self,
        request: dingtalkhrm__1__0_models.MasterDataQueryRequest,
    ) -> dingtalkhrm__1__0_models.MasterDataQueryResponse:
        """
        @summary 智能人事主数据查询服务
        
        @param request: MasterDataQueryRequest
        @return: MasterDataQueryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.MasterDataQueryHeaders()
        return await self.master_data_query_with_options_async(request, headers, runtime)

    def master_data_save_with_options(
        self,
        request: dingtalkhrm__1__0_models.MasterDataSaveRequest,
        headers: dingtalkhrm__1__0_models.MasterDataSaveHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.MasterDataSaveResponse:
        """
        @summary 智能人事主数据保存服务
        
        @param request: MasterDataSaveRequest
        @param headers: MasterDataSaveHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: MasterDataSaveResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.tenant_id):
            query['tenantId'] = request.tenant_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=UtilClient.to_array(request.body)
        )
        params = open_api_models.Params(
            action='MasterDataSave',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/masters/datas/save',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.MasterDataSaveResponse(),
            self.execute(params, req, runtime)
        )

    async def master_data_save_with_options_async(
        self,
        request: dingtalkhrm__1__0_models.MasterDataSaveRequest,
        headers: dingtalkhrm__1__0_models.MasterDataSaveHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.MasterDataSaveResponse:
        """
        @summary 智能人事主数据保存服务
        
        @param request: MasterDataSaveRequest
        @param headers: MasterDataSaveHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: MasterDataSaveResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.tenant_id):
            query['tenantId'] = request.tenant_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=UtilClient.to_array(request.body)
        )
        params = open_api_models.Params(
            action='MasterDataSave',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/masters/datas/save',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.MasterDataSaveResponse(),
            await self.execute_async(params, req, runtime)
        )

    def master_data_save(
        self,
        request: dingtalkhrm__1__0_models.MasterDataSaveRequest,
    ) -> dingtalkhrm__1__0_models.MasterDataSaveResponse:
        """
        @summary 智能人事主数据保存服务
        
        @param request: MasterDataSaveRequest
        @return: MasterDataSaveResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.MasterDataSaveHeaders()
        return self.master_data_save_with_options(request, headers, runtime)

    async def master_data_save_async(
        self,
        request: dingtalkhrm__1__0_models.MasterDataSaveRequest,
    ) -> dingtalkhrm__1__0_models.MasterDataSaveResponse:
        """
        @summary 智能人事主数据保存服务
        
        @param request: MasterDataSaveRequest
        @return: MasterDataSaveResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.MasterDataSaveHeaders()
        return await self.master_data_save_with_options_async(request, headers, runtime)

    def master_data_tenant_quey_with_options(
        self,
        request: dingtalkhrm__1__0_models.MasterDataTenantQueyRequest,
        headers: dingtalkhrm__1__0_models.MasterDataTenantQueyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.MasterDataTenantQueyResponse:
        """
        @summary 主数据中拥有某个领域数据的租户信息查询
        
        @param request: MasterDataTenantQueyRequest
        @param headers: MasterDataTenantQueyHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: MasterDataTenantQueyResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.entity_code):
            query['entityCode'] = request.entity_code
        if not UtilClient.is_unset(request.scope_code):
            query['scopeCode'] = request.scope_code
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
            action='MasterDataTenantQuey',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/masters/tenants',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.MasterDataTenantQueyResponse(),
            self.execute(params, req, runtime)
        )

    async def master_data_tenant_quey_with_options_async(
        self,
        request: dingtalkhrm__1__0_models.MasterDataTenantQueyRequest,
        headers: dingtalkhrm__1__0_models.MasterDataTenantQueyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.MasterDataTenantQueyResponse:
        """
        @summary 主数据中拥有某个领域数据的租户信息查询
        
        @param request: MasterDataTenantQueyRequest
        @param headers: MasterDataTenantQueyHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: MasterDataTenantQueyResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.entity_code):
            query['entityCode'] = request.entity_code
        if not UtilClient.is_unset(request.scope_code):
            query['scopeCode'] = request.scope_code
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
            action='MasterDataTenantQuey',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/masters/tenants',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.MasterDataTenantQueyResponse(),
            await self.execute_async(params, req, runtime)
        )

    def master_data_tenant_quey(
        self,
        request: dingtalkhrm__1__0_models.MasterDataTenantQueyRequest,
    ) -> dingtalkhrm__1__0_models.MasterDataTenantQueyResponse:
        """
        @summary 主数据中拥有某个领域数据的租户信息查询
        
        @param request: MasterDataTenantQueyRequest
        @return: MasterDataTenantQueyResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.MasterDataTenantQueyHeaders()
        return self.master_data_tenant_quey_with_options(request, headers, runtime)

    async def master_data_tenant_quey_async(
        self,
        request: dingtalkhrm__1__0_models.MasterDataTenantQueyRequest,
    ) -> dingtalkhrm__1__0_models.MasterDataTenantQueyResponse:
        """
        @summary 主数据中拥有某个领域数据的租户信息查询
        
        @param request: MasterDataTenantQueyRequest
        @return: MasterDataTenantQueyResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.MasterDataTenantQueyHeaders()
        return await self.master_data_tenant_quey_with_options_async(request, headers, runtime)

    def master_datas_get_with_options(
        self,
        request: dingtalkhrm__1__0_models.MasterDatasGetRequest,
        headers: dingtalkhrm__1__0_models.MasterDatasGetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.MasterDatasGetResponse:
        """
        @summary 智能人事主数据根据ID获取
        
        @param request: MasterDatasGetRequest
        @param headers: MasterDatasGetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: MasterDatasGetResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.obj_id):
            body['objId'] = request.obj_id
        if not UtilClient.is_unset(request.scope_code):
            body['scopeCode'] = request.scope_code
        if not UtilClient.is_unset(request.tenant_id):
            body['tenantId'] = request.tenant_id
        if not UtilClient.is_unset(request.view_entity_code):
            body['viewEntityCode'] = request.view_entity_code
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
            action='MasterDatasGet',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/masterDatas/objects/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.MasterDatasGetResponse(),
            self.execute(params, req, runtime)
        )

    async def master_datas_get_with_options_async(
        self,
        request: dingtalkhrm__1__0_models.MasterDatasGetRequest,
        headers: dingtalkhrm__1__0_models.MasterDatasGetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.MasterDatasGetResponse:
        """
        @summary 智能人事主数据根据ID获取
        
        @param request: MasterDatasGetRequest
        @param headers: MasterDatasGetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: MasterDatasGetResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.obj_id):
            body['objId'] = request.obj_id
        if not UtilClient.is_unset(request.scope_code):
            body['scopeCode'] = request.scope_code
        if not UtilClient.is_unset(request.tenant_id):
            body['tenantId'] = request.tenant_id
        if not UtilClient.is_unset(request.view_entity_code):
            body['viewEntityCode'] = request.view_entity_code
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
            action='MasterDatasGet',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/masterDatas/objects/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.MasterDatasGetResponse(),
            await self.execute_async(params, req, runtime)
        )

    def master_datas_get(
        self,
        request: dingtalkhrm__1__0_models.MasterDatasGetRequest,
    ) -> dingtalkhrm__1__0_models.MasterDatasGetResponse:
        """
        @summary 智能人事主数据根据ID获取
        
        @param request: MasterDatasGetRequest
        @return: MasterDatasGetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.MasterDatasGetHeaders()
        return self.master_datas_get_with_options(request, headers, runtime)

    async def master_datas_get_async(
        self,
        request: dingtalkhrm__1__0_models.MasterDatasGetRequest,
    ) -> dingtalkhrm__1__0_models.MasterDatasGetResponse:
        """
        @summary 智能人事主数据根据ID获取
        
        @param request: MasterDatasGetRequest
        @return: MasterDatasGetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.MasterDatasGetHeaders()
        return await self.master_datas_get_with_options_async(request, headers, runtime)

    def master_datas_query_with_options(
        self,
        request: dingtalkhrm__1__0_models.MasterDatasQueryRequest,
        headers: dingtalkhrm__1__0_models.MasterDatasQueryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.MasterDatasQueryResponse:
        """
        @summary 智能人事主数据查询服务
        
        @param request: MasterDatasQueryRequest
        @param headers: MasterDatasQueryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: MasterDatasQueryResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_uk):
            body['bizUK'] = request.biz_uk
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.query_params):
            body['queryParams'] = request.query_params
        if not UtilClient.is_unset(request.relation_ids):
            body['relationIds'] = request.relation_ids
        if not UtilClient.is_unset(request.scope_code):
            body['scopeCode'] = request.scope_code
        if not UtilClient.is_unset(request.tenant_id):
            body['tenantId'] = request.tenant_id
        if not UtilClient.is_unset(request.view_entity_code):
            body['viewEntityCode'] = request.view_entity_code
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
            action='MasterDatasQuery',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/masterDatas/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.MasterDatasQueryResponse(),
            self.execute(params, req, runtime)
        )

    async def master_datas_query_with_options_async(
        self,
        request: dingtalkhrm__1__0_models.MasterDatasQueryRequest,
        headers: dingtalkhrm__1__0_models.MasterDatasQueryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.MasterDatasQueryResponse:
        """
        @summary 智能人事主数据查询服务
        
        @param request: MasterDatasQueryRequest
        @param headers: MasterDatasQueryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: MasterDatasQueryResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_uk):
            body['bizUK'] = request.biz_uk
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.query_params):
            body['queryParams'] = request.query_params
        if not UtilClient.is_unset(request.relation_ids):
            body['relationIds'] = request.relation_ids
        if not UtilClient.is_unset(request.scope_code):
            body['scopeCode'] = request.scope_code
        if not UtilClient.is_unset(request.tenant_id):
            body['tenantId'] = request.tenant_id
        if not UtilClient.is_unset(request.view_entity_code):
            body['viewEntityCode'] = request.view_entity_code
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
            action='MasterDatasQuery',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/masterDatas/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.MasterDatasQueryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def master_datas_query(
        self,
        request: dingtalkhrm__1__0_models.MasterDatasQueryRequest,
    ) -> dingtalkhrm__1__0_models.MasterDatasQueryResponse:
        """
        @summary 智能人事主数据查询服务
        
        @param request: MasterDatasQueryRequest
        @return: MasterDatasQueryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.MasterDatasQueryHeaders()
        return self.master_datas_query_with_options(request, headers, runtime)

    async def master_datas_query_async(
        self,
        request: dingtalkhrm__1__0_models.MasterDatasQueryRequest,
    ) -> dingtalkhrm__1__0_models.MasterDatasQueryResponse:
        """
        @summary 智能人事主数据查询服务
        
        @param request: MasterDatasQueryRequest
        @return: MasterDatasQueryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.MasterDatasQueryHeaders()
        return await self.master_datas_query_with_options_async(request, headers, runtime)

    def open_oem_micro_app_with_options(
        self,
        request: dingtalkhrm__1__0_models.OpenOemMicroAppRequest,
        headers: dingtalkhrm__1__0_models.OpenOemMicroAppHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.OpenOemMicroAppResponse:
        """
        @summary oem 老用户数据迁移时，开通oem 应用
        
        @param request: OpenOemMicroAppRequest
        @param headers: OpenOemMicroAppHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: OpenOemMicroAppResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.tenant_id):
            query['tenantId'] = request.tenant_id
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
            action='OpenOemMicroApp',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/oem/microApps/open',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.OpenOemMicroAppResponse(),
            self.execute(params, req, runtime)
        )

    async def open_oem_micro_app_with_options_async(
        self,
        request: dingtalkhrm__1__0_models.OpenOemMicroAppRequest,
        headers: dingtalkhrm__1__0_models.OpenOemMicroAppHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.OpenOemMicroAppResponse:
        """
        @summary oem 老用户数据迁移时，开通oem 应用
        
        @param request: OpenOemMicroAppRequest
        @param headers: OpenOemMicroAppHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: OpenOemMicroAppResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.tenant_id):
            query['tenantId'] = request.tenant_id
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
            action='OpenOemMicroApp',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/oem/microApps/open',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.OpenOemMicroAppResponse(),
            await self.execute_async(params, req, runtime)
        )

    def open_oem_micro_app(
        self,
        request: dingtalkhrm__1__0_models.OpenOemMicroAppRequest,
    ) -> dingtalkhrm__1__0_models.OpenOemMicroAppResponse:
        """
        @summary oem 老用户数据迁移时，开通oem 应用
        
        @param request: OpenOemMicroAppRequest
        @return: OpenOemMicroAppResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.OpenOemMicroAppHeaders()
        return self.open_oem_micro_app_with_options(request, headers, runtime)

    async def open_oem_micro_app_async(
        self,
        request: dingtalkhrm__1__0_models.OpenOemMicroAppRequest,
    ) -> dingtalkhrm__1__0_models.OpenOemMicroAppResponse:
        """
        @summary oem 老用户数据迁移时，开通oem 应用
        
        @param request: OpenOemMicroAppRequest
        @return: OpenOemMicroAppResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.OpenOemMicroAppHeaders()
        return await self.open_oem_micro_app_with_options_async(request, headers, runtime)

    def query_custom_entry_processes_with_options(
        self,
        request: dingtalkhrm__1__0_models.QueryCustomEntryProcessesRequest,
        headers: dingtalkhrm__1__0_models.QueryCustomEntryProcessesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.QueryCustomEntryProcessesResponse:
        """
        @summary 自定义入职流程数据查询
        
        @param request: QueryCustomEntryProcessesRequest
        @param headers: QueryCustomEntryProcessesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryCustomEntryProcessesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.operate_user_id):
            query['operateUserId'] = request.operate_user_id
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
            action='QueryCustomEntryProcesses',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/customEntryProcesses',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.QueryCustomEntryProcessesResponse(),
            self.execute(params, req, runtime)
        )

    async def query_custom_entry_processes_with_options_async(
        self,
        request: dingtalkhrm__1__0_models.QueryCustomEntryProcessesRequest,
        headers: dingtalkhrm__1__0_models.QueryCustomEntryProcessesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.QueryCustomEntryProcessesResponse:
        """
        @summary 自定义入职流程数据查询
        
        @param request: QueryCustomEntryProcessesRequest
        @param headers: QueryCustomEntryProcessesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryCustomEntryProcessesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.operate_user_id):
            query['operateUserId'] = request.operate_user_id
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
            action='QueryCustomEntryProcesses',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/customEntryProcesses',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.QueryCustomEntryProcessesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_custom_entry_processes(
        self,
        request: dingtalkhrm__1__0_models.QueryCustomEntryProcessesRequest,
    ) -> dingtalkhrm__1__0_models.QueryCustomEntryProcessesResponse:
        """
        @summary 自定义入职流程数据查询
        
        @param request: QueryCustomEntryProcessesRequest
        @return: QueryCustomEntryProcessesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.QueryCustomEntryProcessesHeaders()
        return self.query_custom_entry_processes_with_options(request, headers, runtime)

    async def query_custom_entry_processes_async(
        self,
        request: dingtalkhrm__1__0_models.QueryCustomEntryProcessesRequest,
    ) -> dingtalkhrm__1__0_models.QueryCustomEntryProcessesResponse:
        """
        @summary 自定义入职流程数据查询
        
        @param request: QueryCustomEntryProcessesRequest
        @return: QueryCustomEntryProcessesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.QueryCustomEntryProcessesHeaders()
        return await self.query_custom_entry_processes_with_options_async(request, headers, runtime)

    def query_dismission_staff_id_list_with_options(
        self,
        request: dingtalkhrm__1__0_models.QueryDismissionStaffIdListRequest,
        headers: dingtalkhrm__1__0_models.QueryDismissionStaffIdListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.QueryDismissionStaffIdListResponse:
        """
        @summary 查询企业已离职员工列表
        
        @param request: QueryDismissionStaffIdListRequest
        @param headers: QueryDismissionStaffIdListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryDismissionStaffIdListResponse
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
            action='QueryDismissionStaffIdList',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/employees/dismissions',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.QueryDismissionStaffIdListResponse(),
            self.execute(params, req, runtime)
        )

    async def query_dismission_staff_id_list_with_options_async(
        self,
        request: dingtalkhrm__1__0_models.QueryDismissionStaffIdListRequest,
        headers: dingtalkhrm__1__0_models.QueryDismissionStaffIdListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.QueryDismissionStaffIdListResponse:
        """
        @summary 查询企业已离职员工列表
        
        @param request: QueryDismissionStaffIdListRequest
        @param headers: QueryDismissionStaffIdListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryDismissionStaffIdListResponse
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
            action='QueryDismissionStaffIdList',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/employees/dismissions',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.QueryDismissionStaffIdListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_dismission_staff_id_list(
        self,
        request: dingtalkhrm__1__0_models.QueryDismissionStaffIdListRequest,
    ) -> dingtalkhrm__1__0_models.QueryDismissionStaffIdListResponse:
        """
        @summary 查询企业已离职员工列表
        
        @param request: QueryDismissionStaffIdListRequest
        @return: QueryDismissionStaffIdListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.QueryDismissionStaffIdListHeaders()
        return self.query_dismission_staff_id_list_with_options(request, headers, runtime)

    async def query_dismission_staff_id_list_async(
        self,
        request: dingtalkhrm__1__0_models.QueryDismissionStaffIdListRequest,
    ) -> dingtalkhrm__1__0_models.QueryDismissionStaffIdListResponse:
        """
        @summary 查询企业已离职员工列表
        
        @param request: QueryDismissionStaffIdListRequest
        @return: QueryDismissionStaffIdListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.QueryDismissionStaffIdListHeaders()
        return await self.query_dismission_staff_id_list_with_options_async(request, headers, runtime)

    def query_hrm_employee_dismission_info_with_options(
        self,
        tmp_req: dingtalkhrm__1__0_models.QueryHrmEmployeeDismissionInfoRequest,
        headers: dingtalkhrm__1__0_models.QueryHrmEmployeeDismissionInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.QueryHrmEmployeeDismissionInfoResponse:
        """
        @summary 根据传入的staffId列表，批量查询员工的离职信息
        
        @param tmp_req: QueryHrmEmployeeDismissionInfoRequest
        @param headers: QueryHrmEmployeeDismissionInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryHrmEmployeeDismissionInfoResponse
        """
        UtilClient.validate_model(tmp_req)
        request = dingtalkhrm__1__0_models.QueryHrmEmployeeDismissionInfoShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.user_id_list):
            request.user_id_list_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.user_id_list, 'userIdList', 'json')
        query = {}
        if not UtilClient.is_unset(request.user_id_list_shrink):
            query['userIdList'] = request.user_id_list_shrink
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
            action='QueryHrmEmployeeDismissionInfo',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/employees/dimissionInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.QueryHrmEmployeeDismissionInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def query_hrm_employee_dismission_info_with_options_async(
        self,
        tmp_req: dingtalkhrm__1__0_models.QueryHrmEmployeeDismissionInfoRequest,
        headers: dingtalkhrm__1__0_models.QueryHrmEmployeeDismissionInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.QueryHrmEmployeeDismissionInfoResponse:
        """
        @summary 根据传入的staffId列表，批量查询员工的离职信息
        
        @param tmp_req: QueryHrmEmployeeDismissionInfoRequest
        @param headers: QueryHrmEmployeeDismissionInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryHrmEmployeeDismissionInfoResponse
        """
        UtilClient.validate_model(tmp_req)
        request = dingtalkhrm__1__0_models.QueryHrmEmployeeDismissionInfoShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.user_id_list):
            request.user_id_list_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.user_id_list, 'userIdList', 'json')
        query = {}
        if not UtilClient.is_unset(request.user_id_list_shrink):
            query['userIdList'] = request.user_id_list_shrink
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
            action='QueryHrmEmployeeDismissionInfo',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/employees/dimissionInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.QueryHrmEmployeeDismissionInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_hrm_employee_dismission_info(
        self,
        request: dingtalkhrm__1__0_models.QueryHrmEmployeeDismissionInfoRequest,
    ) -> dingtalkhrm__1__0_models.QueryHrmEmployeeDismissionInfoResponse:
        """
        @summary 根据传入的staffId列表，批量查询员工的离职信息
        
        @param request: QueryHrmEmployeeDismissionInfoRequest
        @return: QueryHrmEmployeeDismissionInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.QueryHrmEmployeeDismissionInfoHeaders()
        return self.query_hrm_employee_dismission_info_with_options(request, headers, runtime)

    async def query_hrm_employee_dismission_info_async(
        self,
        request: dingtalkhrm__1__0_models.QueryHrmEmployeeDismissionInfoRequest,
    ) -> dingtalkhrm__1__0_models.QueryHrmEmployeeDismissionInfoResponse:
        """
        @summary 根据传入的staffId列表，批量查询员工的离职信息
        
        @param request: QueryHrmEmployeeDismissionInfoRequest
        @return: QueryHrmEmployeeDismissionInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.QueryHrmEmployeeDismissionInfoHeaders()
        return await self.query_hrm_employee_dismission_info_with_options_async(request, headers, runtime)

    def query_job_ranks_with_options(
        self,
        request: dingtalkhrm__1__0_models.QueryJobRanksRequest,
        headers: dingtalkhrm__1__0_models.QueryJobRanksHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.QueryJobRanksResponse:
        """
        @summary 分页查询企业的职级信息
        
        @param request: QueryJobRanksRequest
        @param headers: QueryJobRanksHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryJobRanksResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.rank_category_id):
            query['rankCategoryId'] = request.rank_category_id
        if not UtilClient.is_unset(request.rank_code):
            query['rankCode'] = request.rank_code
        if not UtilClient.is_unset(request.rank_name):
            query['rankName'] = request.rank_name
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
            action='QueryJobRanks',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/jobRanks',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.QueryJobRanksResponse(),
            self.execute(params, req, runtime)
        )

    async def query_job_ranks_with_options_async(
        self,
        request: dingtalkhrm__1__0_models.QueryJobRanksRequest,
        headers: dingtalkhrm__1__0_models.QueryJobRanksHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.QueryJobRanksResponse:
        """
        @summary 分页查询企业的职级信息
        
        @param request: QueryJobRanksRequest
        @param headers: QueryJobRanksHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryJobRanksResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.rank_category_id):
            query['rankCategoryId'] = request.rank_category_id
        if not UtilClient.is_unset(request.rank_code):
            query['rankCode'] = request.rank_code
        if not UtilClient.is_unset(request.rank_name):
            query['rankName'] = request.rank_name
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
            action='QueryJobRanks',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/jobRanks',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.QueryJobRanksResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_job_ranks(
        self,
        request: dingtalkhrm__1__0_models.QueryJobRanksRequest,
    ) -> dingtalkhrm__1__0_models.QueryJobRanksResponse:
        """
        @summary 分页查询企业的职级信息
        
        @param request: QueryJobRanksRequest
        @return: QueryJobRanksResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.QueryJobRanksHeaders()
        return self.query_job_ranks_with_options(request, headers, runtime)

    async def query_job_ranks_async(
        self,
        request: dingtalkhrm__1__0_models.QueryJobRanksRequest,
    ) -> dingtalkhrm__1__0_models.QueryJobRanksResponse:
        """
        @summary 分页查询企业的职级信息
        
        @param request: QueryJobRanksRequest
        @return: QueryJobRanksResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.QueryJobRanksHeaders()
        return await self.query_job_ranks_with_options_async(request, headers, runtime)

    def query_jobs_with_options(
        self,
        request: dingtalkhrm__1__0_models.QueryJobsRequest,
        headers: dingtalkhrm__1__0_models.QueryJobsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.QueryJobsResponse:
        """
        @summary 分页查询企业职务信息
        
        @param request: QueryJobsRequest
        @param headers: QueryJobsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryJobsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.job_name):
            query['jobName'] = request.job_name
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
            action='QueryJobs',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/jobs',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.QueryJobsResponse(),
            self.execute(params, req, runtime)
        )

    async def query_jobs_with_options_async(
        self,
        request: dingtalkhrm__1__0_models.QueryJobsRequest,
        headers: dingtalkhrm__1__0_models.QueryJobsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.QueryJobsResponse:
        """
        @summary 分页查询企业职务信息
        
        @param request: QueryJobsRequest
        @param headers: QueryJobsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryJobsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.job_name):
            query['jobName'] = request.job_name
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
            action='QueryJobs',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/jobs',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.QueryJobsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_jobs(
        self,
        request: dingtalkhrm__1__0_models.QueryJobsRequest,
    ) -> dingtalkhrm__1__0_models.QueryJobsResponse:
        """
        @summary 分页查询企业职务信息
        
        @param request: QueryJobsRequest
        @return: QueryJobsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.QueryJobsHeaders()
        return self.query_jobs_with_options(request, headers, runtime)

    async def query_jobs_async(
        self,
        request: dingtalkhrm__1__0_models.QueryJobsRequest,
    ) -> dingtalkhrm__1__0_models.QueryJobsResponse:
        """
        @summary 分页查询企业职务信息
        
        @param request: QueryJobsRequest
        @return: QueryJobsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.QueryJobsHeaders()
        return await self.query_jobs_with_options_async(request, headers, runtime)

    def query_micro_app_status_with_options(
        self,
        request: dingtalkhrm__1__0_models.QueryMicroAppStatusRequest,
        headers: dingtalkhrm__1__0_models.QueryMicroAppStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.QueryMicroAppStatusResponse:
        """
        @summary 智能人事查询微应用状态
        
        @param request: QueryMicroAppStatusRequest
        @param headers: QueryMicroAppStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryMicroAppStatusResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.tenant_id_list):
            body['tenantIdList'] = request.tenant_id_list
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
            action='QueryMicroAppStatus',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/microApps/statuses/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.QueryMicroAppStatusResponse(),
            self.execute(params, req, runtime)
        )

    async def query_micro_app_status_with_options_async(
        self,
        request: dingtalkhrm__1__0_models.QueryMicroAppStatusRequest,
        headers: dingtalkhrm__1__0_models.QueryMicroAppStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.QueryMicroAppStatusResponse:
        """
        @summary 智能人事查询微应用状态
        
        @param request: QueryMicroAppStatusRequest
        @param headers: QueryMicroAppStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryMicroAppStatusResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.tenant_id_list):
            body['tenantIdList'] = request.tenant_id_list
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
            action='QueryMicroAppStatus',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/microApps/statuses/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.QueryMicroAppStatusResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_micro_app_status(
        self,
        request: dingtalkhrm__1__0_models.QueryMicroAppStatusRequest,
    ) -> dingtalkhrm__1__0_models.QueryMicroAppStatusResponse:
        """
        @summary 智能人事查询微应用状态
        
        @param request: QueryMicroAppStatusRequest
        @return: QueryMicroAppStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.QueryMicroAppStatusHeaders()
        return self.query_micro_app_status_with_options(request, headers, runtime)

    async def query_micro_app_status_async(
        self,
        request: dingtalkhrm__1__0_models.QueryMicroAppStatusRequest,
    ) -> dingtalkhrm__1__0_models.QueryMicroAppStatusResponse:
        """
        @summary 智能人事查询微应用状态
        
        @param request: QueryMicroAppStatusRequest
        @return: QueryMicroAppStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.QueryMicroAppStatusHeaders()
        return await self.query_micro_app_status_with_options_async(request, headers, runtime)

    def query_micro_app_view_with_options(
        self,
        request: dingtalkhrm__1__0_models.QueryMicroAppViewRequest,
        headers: dingtalkhrm__1__0_models.QueryMicroAppViewHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.QueryMicroAppViewResponse:
        """
        @summary 智能人事查询微应用可见性
        
        @param request: QueryMicroAppViewRequest
        @param headers: QueryMicroAppViewHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryMicroAppViewResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.tenant_id_list):
            body['tenantIdList'] = request.tenant_id_list
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
            action='QueryMicroAppView',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/microApps/visibilities/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.QueryMicroAppViewResponse(),
            self.execute(params, req, runtime)
        )

    async def query_micro_app_view_with_options_async(
        self,
        request: dingtalkhrm__1__0_models.QueryMicroAppViewRequest,
        headers: dingtalkhrm__1__0_models.QueryMicroAppViewHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.QueryMicroAppViewResponse:
        """
        @summary 智能人事查询微应用可见性
        
        @param request: QueryMicroAppViewRequest
        @param headers: QueryMicroAppViewHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryMicroAppViewResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.tenant_id_list):
            body['tenantIdList'] = request.tenant_id_list
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
            action='QueryMicroAppView',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/microApps/visibilities/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.QueryMicroAppViewResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_micro_app_view(
        self,
        request: dingtalkhrm__1__0_models.QueryMicroAppViewRequest,
    ) -> dingtalkhrm__1__0_models.QueryMicroAppViewResponse:
        """
        @summary 智能人事查询微应用可见性
        
        @param request: QueryMicroAppViewRequest
        @return: QueryMicroAppViewResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.QueryMicroAppViewHeaders()
        return self.query_micro_app_view_with_options(request, headers, runtime)

    async def query_micro_app_view_async(
        self,
        request: dingtalkhrm__1__0_models.QueryMicroAppViewRequest,
    ) -> dingtalkhrm__1__0_models.QueryMicroAppViewResponse:
        """
        @summary 智能人事查询微应用可见性
        
        @param request: QueryMicroAppViewRequest
        @return: QueryMicroAppViewResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.QueryMicroAppViewHeaders()
        return await self.query_micro_app_view_with_options_async(request, headers, runtime)

    def query_positions_with_options(
        self,
        request: dingtalkhrm__1__0_models.QueryPositionsRequest,
        headers: dingtalkhrm__1__0_models.QueryPositionsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.QueryPositionsResponse:
        """
        @summary 分页查询企业职位信息
        
        @param request: QueryPositionsRequest
        @param headers: QueryPositionsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryPositionsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        body = {}
        if not UtilClient.is_unset(request.dept_id):
            body['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.in_category_ids):
            body['inCategoryIds'] = request.in_category_ids
        if not UtilClient.is_unset(request.in_position_ids):
            body['inPositionIds'] = request.in_position_ids
        if not UtilClient.is_unset(request.position_name):
            body['positionName'] = request.position_name
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='QueryPositions',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/positions/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.QueryPositionsResponse(),
            self.execute(params, req, runtime)
        )

    async def query_positions_with_options_async(
        self,
        request: dingtalkhrm__1__0_models.QueryPositionsRequest,
        headers: dingtalkhrm__1__0_models.QueryPositionsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.QueryPositionsResponse:
        """
        @summary 分页查询企业职位信息
        
        @param request: QueryPositionsRequest
        @param headers: QueryPositionsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryPositionsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        body = {}
        if not UtilClient.is_unset(request.dept_id):
            body['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.in_category_ids):
            body['inCategoryIds'] = request.in_category_ids
        if not UtilClient.is_unset(request.in_position_ids):
            body['inPositionIds'] = request.in_position_ids
        if not UtilClient.is_unset(request.position_name):
            body['positionName'] = request.position_name
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='QueryPositions',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/positions/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.QueryPositionsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_positions(
        self,
        request: dingtalkhrm__1__0_models.QueryPositionsRequest,
    ) -> dingtalkhrm__1__0_models.QueryPositionsResponse:
        """
        @summary 分页查询企业职位信息
        
        @param request: QueryPositionsRequest
        @return: QueryPositionsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.QueryPositionsHeaders()
        return self.query_positions_with_options(request, headers, runtime)

    async def query_positions_async(
        self,
        request: dingtalkhrm__1__0_models.QueryPositionsRequest,
    ) -> dingtalkhrm__1__0_models.QueryPositionsResponse:
        """
        @summary 分页查询企业职位信息
        
        @param request: QueryPositionsRequest
        @return: QueryPositionsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.QueryPositionsHeaders()
        return await self.query_positions_with_options_async(request, headers, runtime)

    def revoke_sign_records_with_options(
        self,
        request: dingtalkhrm__1__0_models.RevokeSignRecordsRequest,
        headers: dingtalkhrm__1__0_models.RevokeSignRecordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.RevokeSignRecordsResponse:
        """
        @summary 撤回电子签署中的签署记录
        
        @param request: RevokeSignRecordsRequest
        @param headers: RevokeSignRecordsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RevokeSignRecordsResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.revoke_user_id):
            body['revokeUserId'] = request.revoke_user_id
        if not UtilClient.is_unset(request.sign_record_ids):
            body['signRecordIds'] = request.sign_record_ids
        if not UtilClient.is_unset(request.status_remark):
            body['statusRemark'] = request.status_remark
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
            action='RevokeSignRecords',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/masters/signCenters/records/revoke',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.RevokeSignRecordsResponse(),
            self.execute(params, req, runtime)
        )

    async def revoke_sign_records_with_options_async(
        self,
        request: dingtalkhrm__1__0_models.RevokeSignRecordsRequest,
        headers: dingtalkhrm__1__0_models.RevokeSignRecordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.RevokeSignRecordsResponse:
        """
        @summary 撤回电子签署中的签署记录
        
        @param request: RevokeSignRecordsRequest
        @param headers: RevokeSignRecordsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RevokeSignRecordsResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.revoke_user_id):
            body['revokeUserId'] = request.revoke_user_id
        if not UtilClient.is_unset(request.sign_record_ids):
            body['signRecordIds'] = request.sign_record_ids
        if not UtilClient.is_unset(request.status_remark):
            body['statusRemark'] = request.status_remark
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
            action='RevokeSignRecords',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/masters/signCenters/records/revoke',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.RevokeSignRecordsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def revoke_sign_records(
        self,
        request: dingtalkhrm__1__0_models.RevokeSignRecordsRequest,
    ) -> dingtalkhrm__1__0_models.RevokeSignRecordsResponse:
        """
        @summary 撤回电子签署中的签署记录
        
        @param request: RevokeSignRecordsRequest
        @return: RevokeSignRecordsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.RevokeSignRecordsHeaders()
        return self.revoke_sign_records_with_options(request, headers, runtime)

    async def revoke_sign_records_async(
        self,
        request: dingtalkhrm__1__0_models.RevokeSignRecordsRequest,
    ) -> dingtalkhrm__1__0_models.RevokeSignRecordsResponse:
        """
        @summary 撤回电子签署中的签署记录
        
        @param request: RevokeSignRecordsRequest
        @return: RevokeSignRecordsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.RevokeSignRecordsHeaders()
        return await self.revoke_sign_records_with_options_async(request, headers, runtime)

    def roster_meta_available_field_list_with_options(
        self,
        request: dingtalkhrm__1__0_models.RosterMetaAvailableFieldListRequest,
        headers: dingtalkhrm__1__0_models.RosterMetaAvailableFieldListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.RosterMetaAvailableFieldListResponse:
        """
        @summary 查询花名册中有权限的字段列表
        
        @param request: RosterMetaAvailableFieldListRequest
        @param headers: RosterMetaAvailableFieldListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RosterMetaAvailableFieldListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_agent_id):
            query['appAgentId'] = request.app_agent_id
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
            action='RosterMetaAvailableFieldList',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/rosters/meta/authorities/fields',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.RosterMetaAvailableFieldListResponse(),
            self.execute(params, req, runtime)
        )

    async def roster_meta_available_field_list_with_options_async(
        self,
        request: dingtalkhrm__1__0_models.RosterMetaAvailableFieldListRequest,
        headers: dingtalkhrm__1__0_models.RosterMetaAvailableFieldListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.RosterMetaAvailableFieldListResponse:
        """
        @summary 查询花名册中有权限的字段列表
        
        @param request: RosterMetaAvailableFieldListRequest
        @param headers: RosterMetaAvailableFieldListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RosterMetaAvailableFieldListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_agent_id):
            query['appAgentId'] = request.app_agent_id
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
            action='RosterMetaAvailableFieldList',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/rosters/meta/authorities/fields',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.RosterMetaAvailableFieldListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def roster_meta_available_field_list(
        self,
        request: dingtalkhrm__1__0_models.RosterMetaAvailableFieldListRequest,
    ) -> dingtalkhrm__1__0_models.RosterMetaAvailableFieldListResponse:
        """
        @summary 查询花名册中有权限的字段列表
        
        @param request: RosterMetaAvailableFieldListRequest
        @return: RosterMetaAvailableFieldListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.RosterMetaAvailableFieldListHeaders()
        return self.roster_meta_available_field_list_with_options(request, headers, runtime)

    async def roster_meta_available_field_list_async(
        self,
        request: dingtalkhrm__1__0_models.RosterMetaAvailableFieldListRequest,
    ) -> dingtalkhrm__1__0_models.RosterMetaAvailableFieldListResponse:
        """
        @summary 查询花名册中有权限的字段列表
        
        @param request: RosterMetaAvailableFieldListRequest
        @return: RosterMetaAvailableFieldListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.RosterMetaAvailableFieldListHeaders()
        return await self.roster_meta_available_field_list_with_options_async(request, headers, runtime)

    def roster_meta_field_options_update_with_options(
        self,
        request: dingtalkhrm__1__0_models.RosterMetaFieldOptionsUpdateRequest,
        headers: dingtalkhrm__1__0_models.RosterMetaFieldOptionsUpdateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.RosterMetaFieldOptionsUpdateResponse:
        """
        @summary 智能人事花名册字段选项修改
        
        @param request: RosterMetaFieldOptionsUpdateRequest
        @param headers: RosterMetaFieldOptionsUpdateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RosterMetaFieldOptionsUpdateResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_agent_id):
            query['appAgentId'] = request.app_agent_id
        body = {}
        if not UtilClient.is_unset(request.field_code):
            body['fieldCode'] = request.field_code
        if not UtilClient.is_unset(request.group_id):
            body['groupId'] = request.group_id
        if not UtilClient.is_unset(request.labels):
            body['labels'] = request.labels
        if not UtilClient.is_unset(request.modify_type):
            body['modifyType'] = request.modify_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='RosterMetaFieldOptionsUpdate',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/rosters/meta/fields/options',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.RosterMetaFieldOptionsUpdateResponse(),
            self.execute(params, req, runtime)
        )

    async def roster_meta_field_options_update_with_options_async(
        self,
        request: dingtalkhrm__1__0_models.RosterMetaFieldOptionsUpdateRequest,
        headers: dingtalkhrm__1__0_models.RosterMetaFieldOptionsUpdateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.RosterMetaFieldOptionsUpdateResponse:
        """
        @summary 智能人事花名册字段选项修改
        
        @param request: RosterMetaFieldOptionsUpdateRequest
        @param headers: RosterMetaFieldOptionsUpdateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RosterMetaFieldOptionsUpdateResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_agent_id):
            query['appAgentId'] = request.app_agent_id
        body = {}
        if not UtilClient.is_unset(request.field_code):
            body['fieldCode'] = request.field_code
        if not UtilClient.is_unset(request.group_id):
            body['groupId'] = request.group_id
        if not UtilClient.is_unset(request.labels):
            body['labels'] = request.labels
        if not UtilClient.is_unset(request.modify_type):
            body['modifyType'] = request.modify_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='RosterMetaFieldOptionsUpdate',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/rosters/meta/fields/options',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.RosterMetaFieldOptionsUpdateResponse(),
            await self.execute_async(params, req, runtime)
        )

    def roster_meta_field_options_update(
        self,
        request: dingtalkhrm__1__0_models.RosterMetaFieldOptionsUpdateRequest,
    ) -> dingtalkhrm__1__0_models.RosterMetaFieldOptionsUpdateResponse:
        """
        @summary 智能人事花名册字段选项修改
        
        @param request: RosterMetaFieldOptionsUpdateRequest
        @return: RosterMetaFieldOptionsUpdateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.RosterMetaFieldOptionsUpdateHeaders()
        return self.roster_meta_field_options_update_with_options(request, headers, runtime)

    async def roster_meta_field_options_update_async(
        self,
        request: dingtalkhrm__1__0_models.RosterMetaFieldOptionsUpdateRequest,
    ) -> dingtalkhrm__1__0_models.RosterMetaFieldOptionsUpdateResponse:
        """
        @summary 智能人事花名册字段选项修改
        
        @param request: RosterMetaFieldOptionsUpdateRequest
        @return: RosterMetaFieldOptionsUpdateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.RosterMetaFieldOptionsUpdateHeaders()
        return await self.roster_meta_field_options_update_with_options_async(request, headers, runtime)

    def send_isv_card_message_with_options(
        self,
        request: dingtalkhrm__1__0_models.SendIsvCardMessageRequest,
        headers: dingtalkhrm__1__0_models.SendIsvCardMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.SendIsvCardMessageResponse:
        """
        @summary ISV发送卡片消息
        
        @param request: SendIsvCardMessageRequest
        @param headers: SendIsvCardMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SendIsvCardMessageResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.agent_id):
            query['agentId'] = request.agent_id
        body = {}
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.message_type):
            body['messageType'] = request.message_type
        if not UtilClient.is_unset(request.receiver_user_ids):
            body['receiverUserIds'] = request.receiver_user_ids
        if not UtilClient.is_unset(request.scene_type):
            body['sceneType'] = request.scene_type
        if not UtilClient.is_unset(request.scope):
            body['scope'] = request.scope
        if not UtilClient.is_unset(request.sender_user_id):
            body['senderUserId'] = request.sender_user_id
        if not UtilClient.is_unset(request.value_map):
            body['valueMap'] = request.value_map
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SendIsvCardMessage',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/cardMessages/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.SendIsvCardMessageResponse(),
            self.execute(params, req, runtime)
        )

    async def send_isv_card_message_with_options_async(
        self,
        request: dingtalkhrm__1__0_models.SendIsvCardMessageRequest,
        headers: dingtalkhrm__1__0_models.SendIsvCardMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.SendIsvCardMessageResponse:
        """
        @summary ISV发送卡片消息
        
        @param request: SendIsvCardMessageRequest
        @param headers: SendIsvCardMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SendIsvCardMessageResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.agent_id):
            query['agentId'] = request.agent_id
        body = {}
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.message_type):
            body['messageType'] = request.message_type
        if not UtilClient.is_unset(request.receiver_user_ids):
            body['receiverUserIds'] = request.receiver_user_ids
        if not UtilClient.is_unset(request.scene_type):
            body['sceneType'] = request.scene_type
        if not UtilClient.is_unset(request.scope):
            body['scope'] = request.scope
        if not UtilClient.is_unset(request.sender_user_id):
            body['senderUserId'] = request.sender_user_id
        if not UtilClient.is_unset(request.value_map):
            body['valueMap'] = request.value_map
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SendIsvCardMessage',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/cardMessages/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.SendIsvCardMessageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def send_isv_card_message(
        self,
        request: dingtalkhrm__1__0_models.SendIsvCardMessageRequest,
    ) -> dingtalkhrm__1__0_models.SendIsvCardMessageResponse:
        """
        @summary ISV发送卡片消息
        
        @param request: SendIsvCardMessageRequest
        @return: SendIsvCardMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.SendIsvCardMessageHeaders()
        return self.send_isv_card_message_with_options(request, headers, runtime)

    async def send_isv_card_message_async(
        self,
        request: dingtalkhrm__1__0_models.SendIsvCardMessageRequest,
    ) -> dingtalkhrm__1__0_models.SendIsvCardMessageResponse:
        """
        @summary ISV发送卡片消息
        
        @param request: SendIsvCardMessageRequest
        @return: SendIsvCardMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.SendIsvCardMessageHeaders()
        return await self.send_isv_card_message_with_options_async(request, headers, runtime)

    def solution_task_init_with_options(
        self,
        request: dingtalkhrm__1__0_models.SolutionTaskInitRequest,
        headers: dingtalkhrm__1__0_models.SolutionTaskInitHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.SolutionTaskInitResponse:
        """
        @summary 初始化解决方案任务
        
        @param request: SolutionTaskInitRequest
        @param headers: SolutionTaskInitHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SolutionTaskInitResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.solution_type):
            query['solutionType'] = request.solution_type
        body = {}
        if not UtilClient.is_unset(request.category):
            body['category'] = request.category
        if not UtilClient.is_unset(request.claim_time):
            body['claimTime'] = request.claim_time
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.finish_time):
            body['finishTime'] = request.finish_time
        if not UtilClient.is_unset(request.outer_id):
            body['outerId'] = request.outer_id
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SolutionTaskInit',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/solutions/tasks/init',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.SolutionTaskInitResponse(),
            self.execute(params, req, runtime)
        )

    async def solution_task_init_with_options_async(
        self,
        request: dingtalkhrm__1__0_models.SolutionTaskInitRequest,
        headers: dingtalkhrm__1__0_models.SolutionTaskInitHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.SolutionTaskInitResponse:
        """
        @summary 初始化解决方案任务
        
        @param request: SolutionTaskInitRequest
        @param headers: SolutionTaskInitHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SolutionTaskInitResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.solution_type):
            query['solutionType'] = request.solution_type
        body = {}
        if not UtilClient.is_unset(request.category):
            body['category'] = request.category
        if not UtilClient.is_unset(request.claim_time):
            body['claimTime'] = request.claim_time
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.finish_time):
            body['finishTime'] = request.finish_time
        if not UtilClient.is_unset(request.outer_id):
            body['outerId'] = request.outer_id
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SolutionTaskInit',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/solutions/tasks/init',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.SolutionTaskInitResponse(),
            await self.execute_async(params, req, runtime)
        )

    def solution_task_init(
        self,
        request: dingtalkhrm__1__0_models.SolutionTaskInitRequest,
    ) -> dingtalkhrm__1__0_models.SolutionTaskInitResponse:
        """
        @summary 初始化解决方案任务
        
        @param request: SolutionTaskInitRequest
        @return: SolutionTaskInitResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.SolutionTaskInitHeaders()
        return self.solution_task_init_with_options(request, headers, runtime)

    async def solution_task_init_async(
        self,
        request: dingtalkhrm__1__0_models.SolutionTaskInitRequest,
    ) -> dingtalkhrm__1__0_models.SolutionTaskInitResponse:
        """
        @summary 初始化解决方案任务
        
        @param request: SolutionTaskInitRequest
        @return: SolutionTaskInitResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.SolutionTaskInitHeaders()
        return await self.solution_task_init_with_options_async(request, headers, runtime)

    def solution_task_save_with_options(
        self,
        request: dingtalkhrm__1__0_models.SolutionTaskSaveRequest,
        headers: dingtalkhrm__1__0_models.SolutionTaskSaveHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.SolutionTaskSaveResponse:
        """
        @summary 保存解决方案任务
        
        @param request: SolutionTaskSaveRequest
        @param headers: SolutionTaskSaveHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SolutionTaskSaveResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.solution_type):
            query['solutionType'] = request.solution_type
        body = {}
        if not UtilClient.is_unset(request.claim_time):
            body['claimTime'] = request.claim_time
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.finish_time):
            body['finishTime'] = request.finish_time
        if not UtilClient.is_unset(request.outer_id):
            body['outerId'] = request.outer_id
        if not UtilClient.is_unset(request.solution_instance_id):
            body['solutionInstanceId'] = request.solution_instance_id
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
        if not UtilClient.is_unset(request.task_type):
            body['taskType'] = request.task_type
        if not UtilClient.is_unset(request.template_outer_id):
            body['templateOuterId'] = request.template_outer_id
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SolutionTaskSave',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/solutions/tasks/save',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.SolutionTaskSaveResponse(),
            self.execute(params, req, runtime)
        )

    async def solution_task_save_with_options_async(
        self,
        request: dingtalkhrm__1__0_models.SolutionTaskSaveRequest,
        headers: dingtalkhrm__1__0_models.SolutionTaskSaveHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.SolutionTaskSaveResponse:
        """
        @summary 保存解决方案任务
        
        @param request: SolutionTaskSaveRequest
        @param headers: SolutionTaskSaveHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SolutionTaskSaveResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.solution_type):
            query['solutionType'] = request.solution_type
        body = {}
        if not UtilClient.is_unset(request.claim_time):
            body['claimTime'] = request.claim_time
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.finish_time):
            body['finishTime'] = request.finish_time
        if not UtilClient.is_unset(request.outer_id):
            body['outerId'] = request.outer_id
        if not UtilClient.is_unset(request.solution_instance_id):
            body['solutionInstanceId'] = request.solution_instance_id
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
        if not UtilClient.is_unset(request.task_type):
            body['taskType'] = request.task_type
        if not UtilClient.is_unset(request.template_outer_id):
            body['templateOuterId'] = request.template_outer_id
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SolutionTaskSave',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/solutions/tasks/save',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.SolutionTaskSaveResponse(),
            await self.execute_async(params, req, runtime)
        )

    def solution_task_save(
        self,
        request: dingtalkhrm__1__0_models.SolutionTaskSaveRequest,
    ) -> dingtalkhrm__1__0_models.SolutionTaskSaveResponse:
        """
        @summary 保存解决方案任务
        
        @param request: SolutionTaskSaveRequest
        @return: SolutionTaskSaveResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.SolutionTaskSaveHeaders()
        return self.solution_task_save_with_options(request, headers, runtime)

    async def solution_task_save_async(
        self,
        request: dingtalkhrm__1__0_models.SolutionTaskSaveRequest,
    ) -> dingtalkhrm__1__0_models.SolutionTaskSaveResponse:
        """
        @summary 保存解决方案任务
        
        @param request: SolutionTaskSaveRequest
        @return: SolutionTaskSaveResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.SolutionTaskSaveHeaders()
        return await self.solution_task_save_with_options_async(request, headers, runtime)

    def sync_solution_status_with_options(
        self,
        request: dingtalkhrm__1__0_models.SyncSolutionStatusRequest,
        headers: dingtalkhrm__1__0_models.SyncSolutionStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.SyncSolutionStatusResponse:
        """
        @summary 同步解决方案状态
        
        @param request: SyncSolutionStatusRequest
        @param headers: SyncSolutionStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SyncSolutionStatusResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.solution_status):
            body['solutionStatus'] = request.solution_status
        if not UtilClient.is_unset(request.solution_type):
            body['solutionType'] = request.solution_type
        if not UtilClient.is_unset(request.tenant_id):
            body['tenantId'] = request.tenant_id
        if not UtilClient.is_unset(request.user_ids):
            body['userIds'] = request.user_ids
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
            action='SyncSolutionStatus',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/solutions/statuses/sync',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.SyncSolutionStatusResponse(),
            self.execute(params, req, runtime)
        )

    async def sync_solution_status_with_options_async(
        self,
        request: dingtalkhrm__1__0_models.SyncSolutionStatusRequest,
        headers: dingtalkhrm__1__0_models.SyncSolutionStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.SyncSolutionStatusResponse:
        """
        @summary 同步解决方案状态
        
        @param request: SyncSolutionStatusRequest
        @param headers: SyncSolutionStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SyncSolutionStatusResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.solution_status):
            body['solutionStatus'] = request.solution_status
        if not UtilClient.is_unset(request.solution_type):
            body['solutionType'] = request.solution_type
        if not UtilClient.is_unset(request.tenant_id):
            body['tenantId'] = request.tenant_id
        if not UtilClient.is_unset(request.user_ids):
            body['userIds'] = request.user_ids
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
            action='SyncSolutionStatus',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/solutions/statuses/sync',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.SyncSolutionStatusResponse(),
            await self.execute_async(params, req, runtime)
        )

    def sync_solution_status(
        self,
        request: dingtalkhrm__1__0_models.SyncSolutionStatusRequest,
    ) -> dingtalkhrm__1__0_models.SyncSolutionStatusResponse:
        """
        @summary 同步解决方案状态
        
        @param request: SyncSolutionStatusRequest
        @return: SyncSolutionStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.SyncSolutionStatusHeaders()
        return self.sync_solution_status_with_options(request, headers, runtime)

    async def sync_solution_status_async(
        self,
        request: dingtalkhrm__1__0_models.SyncSolutionStatusRequest,
    ) -> dingtalkhrm__1__0_models.SyncSolutionStatusResponse:
        """
        @summary 同步解决方案状态
        
        @param request: SyncSolutionStatusRequest
        @return: SyncSolutionStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.SyncSolutionStatusHeaders()
        return await self.sync_solution_status_with_options_async(request, headers, runtime)

    def sync_task_template_with_options(
        self,
        request: dingtalkhrm__1__0_models.SyncTaskTemplateRequest,
        headers: dingtalkhrm__1__0_models.SyncTaskTemplateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.SyncTaskTemplateResponse:
        """
        @summary 同步解决方案任务模版
        
        @param request: SyncTaskTemplateRequest
        @param headers: SyncTaskTemplateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SyncTaskTemplateResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.solution_type):
            query['solutionType'] = request.solution_type
        body = {}
        if not UtilClient.is_unset(request.delete):
            body['delete'] = request.delete
        if not UtilClient.is_unset(request.des):
            body['des'] = request.des
        if not UtilClient.is_unset(request.ext):
            body['ext'] = request.ext
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.opt_user_id):
            body['optUserId'] = request.opt_user_id
        if not UtilClient.is_unset(request.outer_id):
            body['outerId'] = request.outer_id
        if not UtilClient.is_unset(request.task_scope_vo):
            body['taskScopeVO'] = request.task_scope_vo
        if not UtilClient.is_unset(request.task_type):
            body['taskType'] = request.task_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SyncTaskTemplate',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/solutions/tasks/templates/sync',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.SyncTaskTemplateResponse(),
            self.execute(params, req, runtime)
        )

    async def sync_task_template_with_options_async(
        self,
        request: dingtalkhrm__1__0_models.SyncTaskTemplateRequest,
        headers: dingtalkhrm__1__0_models.SyncTaskTemplateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.SyncTaskTemplateResponse:
        """
        @summary 同步解决方案任务模版
        
        @param request: SyncTaskTemplateRequest
        @param headers: SyncTaskTemplateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SyncTaskTemplateResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.solution_type):
            query['solutionType'] = request.solution_type
        body = {}
        if not UtilClient.is_unset(request.delete):
            body['delete'] = request.delete
        if not UtilClient.is_unset(request.des):
            body['des'] = request.des
        if not UtilClient.is_unset(request.ext):
            body['ext'] = request.ext
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.opt_user_id):
            body['optUserId'] = request.opt_user_id
        if not UtilClient.is_unset(request.outer_id):
            body['outerId'] = request.outer_id
        if not UtilClient.is_unset(request.task_scope_vo):
            body['taskScopeVO'] = request.task_scope_vo
        if not UtilClient.is_unset(request.task_type):
            body['taskType'] = request.task_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SyncTaskTemplate',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/solutions/tasks/templates/sync',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.SyncTaskTemplateResponse(),
            await self.execute_async(params, req, runtime)
        )

    def sync_task_template(
        self,
        request: dingtalkhrm__1__0_models.SyncTaskTemplateRequest,
    ) -> dingtalkhrm__1__0_models.SyncTaskTemplateResponse:
        """
        @summary 同步解决方案任务模版
        
        @param request: SyncTaskTemplateRequest
        @return: SyncTaskTemplateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.SyncTaskTemplateHeaders()
        return self.sync_task_template_with_options(request, headers, runtime)

    async def sync_task_template_async(
        self,
        request: dingtalkhrm__1__0_models.SyncTaskTemplateRequest,
    ) -> dingtalkhrm__1__0_models.SyncTaskTemplateResponse:
        """
        @summary 同步解决方案任务模版
        
        @param request: SyncTaskTemplateRequest
        @return: SyncTaskTemplateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.SyncTaskTemplateHeaders()
        return await self.sync_task_template_with_options_async(request, headers, runtime)

    def update_hrm_legal_entity_name_with_options(
        self,
        request: dingtalkhrm__1__0_models.UpdateHrmLegalEntityNameRequest,
        headers: dingtalkhrm__1__0_models.UpdateHrmLegalEntityNameHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.UpdateHrmLegalEntityNameResponse:
        """
        @summary 更新法人公司名称
        
        @param request: UpdateHrmLegalEntityNameRequest
        @param headers: UpdateHrmLegalEntityNameHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateHrmLegalEntityNameResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.ding_tenant_id):
            query['dingTenantId'] = request.ding_tenant_id
        if not UtilClient.is_unset(request.legal_entity_name):
            query['legalEntityName'] = request.legal_entity_name
        if not UtilClient.is_unset(request.origin_legal_entity_name):
            query['originLegalEntityName'] = request.origin_legal_entity_name
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
            action='UpdateHrmLegalEntityName',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/masters/legalEntities/companyNames',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.UpdateHrmLegalEntityNameResponse(),
            self.execute(params, req, runtime)
        )

    async def update_hrm_legal_entity_name_with_options_async(
        self,
        request: dingtalkhrm__1__0_models.UpdateHrmLegalEntityNameRequest,
        headers: dingtalkhrm__1__0_models.UpdateHrmLegalEntityNameHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.UpdateHrmLegalEntityNameResponse:
        """
        @summary 更新法人公司名称
        
        @param request: UpdateHrmLegalEntityNameRequest
        @param headers: UpdateHrmLegalEntityNameHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateHrmLegalEntityNameResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.ding_tenant_id):
            query['dingTenantId'] = request.ding_tenant_id
        if not UtilClient.is_unset(request.legal_entity_name):
            query['legalEntityName'] = request.legal_entity_name
        if not UtilClient.is_unset(request.origin_legal_entity_name):
            query['originLegalEntityName'] = request.origin_legal_entity_name
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
            action='UpdateHrmLegalEntityName',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/masters/legalEntities/companyNames',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.UpdateHrmLegalEntityNameResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_hrm_legal_entity_name(
        self,
        request: dingtalkhrm__1__0_models.UpdateHrmLegalEntityNameRequest,
    ) -> dingtalkhrm__1__0_models.UpdateHrmLegalEntityNameResponse:
        """
        @summary 更新法人公司名称
        
        @param request: UpdateHrmLegalEntityNameRequest
        @return: UpdateHrmLegalEntityNameResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.UpdateHrmLegalEntityNameHeaders()
        return self.update_hrm_legal_entity_name_with_options(request, headers, runtime)

    async def update_hrm_legal_entity_name_async(
        self,
        request: dingtalkhrm__1__0_models.UpdateHrmLegalEntityNameRequest,
    ) -> dingtalkhrm__1__0_models.UpdateHrmLegalEntityNameResponse:
        """
        @summary 更新法人公司名称
        
        @param request: UpdateHrmLegalEntityNameRequest
        @return: UpdateHrmLegalEntityNameResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.UpdateHrmLegalEntityNameHeaders()
        return await self.update_hrm_legal_entity_name_with_options_async(request, headers, runtime)

    def update_hrm_legal_entity_without_name_with_options(
        self,
        request: dingtalkhrm__1__0_models.UpdateHrmLegalEntityWithoutNameRequest,
        headers: dingtalkhrm__1__0_models.UpdateHrmLegalEntityWithoutNameHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.UpdateHrmLegalEntityWithoutNameResponse:
        """
        @summary 更新法人公司
        
        @param request: UpdateHrmLegalEntityWithoutNameRequest
        @param headers: UpdateHrmLegalEntityWithoutNameHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateHrmLegalEntityWithoutNameResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.ding_tenant_id):
            query['dingTenantId'] = request.ding_tenant_id
        body = {}
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.create_user_id):
            body['createUserId'] = request.create_user_id
        if not UtilClient.is_unset(request.ext):
            body['ext'] = request.ext
        if not UtilClient.is_unset(request.legal_entity_name):
            body['legalEntityName'] = request.legal_entity_name
        if not UtilClient.is_unset(request.legal_entity_short_name):
            body['legalEntityShortName'] = request.legal_entity_short_name
        if not UtilClient.is_unset(request.legal_entity_status):
            body['legalEntityStatus'] = request.legal_entity_status
        if not UtilClient.is_unset(request.legal_person_name):
            body['legalPersonName'] = request.legal_person_name
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateHrmLegalEntityWithoutName',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/masters/legalEntities/companies',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.UpdateHrmLegalEntityWithoutNameResponse(),
            self.execute(params, req, runtime)
        )

    async def update_hrm_legal_entity_without_name_with_options_async(
        self,
        request: dingtalkhrm__1__0_models.UpdateHrmLegalEntityWithoutNameRequest,
        headers: dingtalkhrm__1__0_models.UpdateHrmLegalEntityWithoutNameHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.UpdateHrmLegalEntityWithoutNameResponse:
        """
        @summary 更新法人公司
        
        @param request: UpdateHrmLegalEntityWithoutNameRequest
        @param headers: UpdateHrmLegalEntityWithoutNameHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateHrmLegalEntityWithoutNameResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.ding_tenant_id):
            query['dingTenantId'] = request.ding_tenant_id
        body = {}
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.create_user_id):
            body['createUserId'] = request.create_user_id
        if not UtilClient.is_unset(request.ext):
            body['ext'] = request.ext
        if not UtilClient.is_unset(request.legal_entity_name):
            body['legalEntityName'] = request.legal_entity_name
        if not UtilClient.is_unset(request.legal_entity_short_name):
            body['legalEntityShortName'] = request.legal_entity_short_name
        if not UtilClient.is_unset(request.legal_entity_status):
            body['legalEntityStatus'] = request.legal_entity_status
        if not UtilClient.is_unset(request.legal_person_name):
            body['legalPersonName'] = request.legal_person_name
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateHrmLegalEntityWithoutName',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/masters/legalEntities/companies',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.UpdateHrmLegalEntityWithoutNameResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_hrm_legal_entity_without_name(
        self,
        request: dingtalkhrm__1__0_models.UpdateHrmLegalEntityWithoutNameRequest,
    ) -> dingtalkhrm__1__0_models.UpdateHrmLegalEntityWithoutNameResponse:
        """
        @summary 更新法人公司
        
        @param request: UpdateHrmLegalEntityWithoutNameRequest
        @return: UpdateHrmLegalEntityWithoutNameResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.UpdateHrmLegalEntityWithoutNameHeaders()
        return self.update_hrm_legal_entity_without_name_with_options(request, headers, runtime)

    async def update_hrm_legal_entity_without_name_async(
        self,
        request: dingtalkhrm__1__0_models.UpdateHrmLegalEntityWithoutNameRequest,
    ) -> dingtalkhrm__1__0_models.UpdateHrmLegalEntityWithoutNameResponse:
        """
        @summary 更新法人公司
        
        @param request: UpdateHrmLegalEntityWithoutNameRequest
        @return: UpdateHrmLegalEntityWithoutNameResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.UpdateHrmLegalEntityWithoutNameHeaders()
        return await self.update_hrm_legal_entity_without_name_with_options_async(request, headers, runtime)

    def update_hrm_version_roll_back_status_with_options(
        self,
        request: dingtalkhrm__1__0_models.UpdateHrmVersionRollBackStatusRequest,
        headers: dingtalkhrm__1__0_models.UpdateHrmVersionRollBackStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.UpdateHrmVersionRollBackStatusResponse:
        """
        @summary 智能人事更新版本回退按钮状态
        
        @param request: UpdateHrmVersionRollBackStatusRequest
        @param headers: UpdateHrmVersionRollBackStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateHrmVersionRollBackStatusResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.config_value):
            body['configValue'] = request.config_value
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
            action='UpdateHrmVersionRollBackStatus',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/versions/rollbackButtons/statuses',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.UpdateHrmVersionRollBackStatusResponse(),
            self.execute(params, req, runtime)
        )

    async def update_hrm_version_roll_back_status_with_options_async(
        self,
        request: dingtalkhrm__1__0_models.UpdateHrmVersionRollBackStatusRequest,
        headers: dingtalkhrm__1__0_models.UpdateHrmVersionRollBackStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.UpdateHrmVersionRollBackStatusResponse:
        """
        @summary 智能人事更新版本回退按钮状态
        
        @param request: UpdateHrmVersionRollBackStatusRequest
        @param headers: UpdateHrmVersionRollBackStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateHrmVersionRollBackStatusResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.config_value):
            body['configValue'] = request.config_value
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
            action='UpdateHrmVersionRollBackStatus',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/versions/rollbackButtons/statuses',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.UpdateHrmVersionRollBackStatusResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_hrm_version_roll_back_status(
        self,
        request: dingtalkhrm__1__0_models.UpdateHrmVersionRollBackStatusRequest,
    ) -> dingtalkhrm__1__0_models.UpdateHrmVersionRollBackStatusResponse:
        """
        @summary 智能人事更新版本回退按钮状态
        
        @param request: UpdateHrmVersionRollBackStatusRequest
        @return: UpdateHrmVersionRollBackStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.UpdateHrmVersionRollBackStatusHeaders()
        return self.update_hrm_version_roll_back_status_with_options(request, headers, runtime)

    async def update_hrm_version_roll_back_status_async(
        self,
        request: dingtalkhrm__1__0_models.UpdateHrmVersionRollBackStatusRequest,
    ) -> dingtalkhrm__1__0_models.UpdateHrmVersionRollBackStatusResponse:
        """
        @summary 智能人事更新版本回退按钮状态
        
        @param request: UpdateHrmVersionRollBackStatusRequest
        @return: UpdateHrmVersionRollBackStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.UpdateHrmVersionRollBackStatusHeaders()
        return await self.update_hrm_version_roll_back_status_with_options_async(request, headers, runtime)

    def update_isv_card_message_with_options(
        self,
        request: dingtalkhrm__1__0_models.UpdateIsvCardMessageRequest,
        headers: dingtalkhrm__1__0_models.UpdateIsvCardMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.UpdateIsvCardMessageResponse:
        """
        @summary ISV更新卡片消息
        
        @param request: UpdateIsvCardMessageRequest
        @param headers: UpdateIsvCardMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateIsvCardMessageResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.agent_id):
            query['agentId'] = request.agent_id
        body = {}
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.message_type):
            body['messageType'] = request.message_type
        if not UtilClient.is_unset(request.scene_type):
            body['sceneType'] = request.scene_type
        if not UtilClient.is_unset(request.scope):
            body['scope'] = request.scope
        if not UtilClient.is_unset(request.value_map):
            body['valueMap'] = request.value_map
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateIsvCardMessage',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/cardMessages',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.UpdateIsvCardMessageResponse(),
            self.execute(params, req, runtime)
        )

    async def update_isv_card_message_with_options_async(
        self,
        request: dingtalkhrm__1__0_models.UpdateIsvCardMessageRequest,
        headers: dingtalkhrm__1__0_models.UpdateIsvCardMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.UpdateIsvCardMessageResponse:
        """
        @summary ISV更新卡片消息
        
        @param request: UpdateIsvCardMessageRequest
        @param headers: UpdateIsvCardMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateIsvCardMessageResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.agent_id):
            query['agentId'] = request.agent_id
        body = {}
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.message_type):
            body['messageType'] = request.message_type
        if not UtilClient.is_unset(request.scene_type):
            body['sceneType'] = request.scene_type
        if not UtilClient.is_unset(request.scope):
            body['scope'] = request.scope
        if not UtilClient.is_unset(request.value_map):
            body['valueMap'] = request.value_map
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateIsvCardMessage',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/cardMessages',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.UpdateIsvCardMessageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_isv_card_message(
        self,
        request: dingtalkhrm__1__0_models.UpdateIsvCardMessageRequest,
    ) -> dingtalkhrm__1__0_models.UpdateIsvCardMessageResponse:
        """
        @summary ISV更新卡片消息
        
        @param request: UpdateIsvCardMessageRequest
        @return: UpdateIsvCardMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.UpdateIsvCardMessageHeaders()
        return self.update_isv_card_message_with_options(request, headers, runtime)

    async def update_isv_card_message_async(
        self,
        request: dingtalkhrm__1__0_models.UpdateIsvCardMessageRequest,
    ) -> dingtalkhrm__1__0_models.UpdateIsvCardMessageResponse:
        """
        @summary ISV更新卡片消息
        
        @param request: UpdateIsvCardMessageRequest
        @return: UpdateIsvCardMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.UpdateIsvCardMessageHeaders()
        return await self.update_isv_card_message_with_options_async(request, headers, runtime)

    def upload_attachment_with_options(
        self,
        request: dingtalkhrm__1__0_models.UploadAttachmentRequest,
        headers: dingtalkhrm__1__0_models.UploadAttachmentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.UploadAttachmentResponse:
        """
        @summary 上传附件材料
        
        @param request: UploadAttachmentRequest
        @param headers: UploadAttachmentHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UploadAttachmentResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.media_id):
            body['mediaId'] = request.media_id
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
            action='UploadAttachment',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/attachments/upload',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.UploadAttachmentResponse(),
            self.execute(params, req, runtime)
        )

    async def upload_attachment_with_options_async(
        self,
        request: dingtalkhrm__1__0_models.UploadAttachmentRequest,
        headers: dingtalkhrm__1__0_models.UploadAttachmentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.UploadAttachmentResponse:
        """
        @summary 上传附件材料
        
        @param request: UploadAttachmentRequest
        @param headers: UploadAttachmentHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UploadAttachmentResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.media_id):
            body['mediaId'] = request.media_id
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
            action='UploadAttachment',
            version='hrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrm/attachments/upload',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrm__1__0_models.UploadAttachmentResponse(),
            await self.execute_async(params, req, runtime)
        )

    def upload_attachment(
        self,
        request: dingtalkhrm__1__0_models.UploadAttachmentRequest,
    ) -> dingtalkhrm__1__0_models.UploadAttachmentResponse:
        """
        @summary 上传附件材料
        
        @param request: UploadAttachmentRequest
        @return: UploadAttachmentResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.UploadAttachmentHeaders()
        return self.upload_attachment_with_options(request, headers, runtime)

    async def upload_attachment_async(
        self,
        request: dingtalkhrm__1__0_models.UploadAttachmentRequest,
    ) -> dingtalkhrm__1__0_models.UploadAttachmentResponse:
        """
        @summary 上传附件材料
        
        @param request: UploadAttachmentRequest
        @return: UploadAttachmentResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.UploadAttachmentHeaders()
        return await self.upload_attachment_with_options_async(request, headers, runtime)
