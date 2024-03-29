# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore
from typing import Dict

from alibabacloud_gateway_spi.client import Client as SPIClient
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
    _client: SPIClient = None

    def __init__(
        self, 
        config: open_api_models.Config,
    ):
        super().__init__(config)
        self._client = GatewayClientClient()
        self._spi = self._client
        self._signature_algorithm = 'v2'
        self._endpoint_rule = ''
        if UtilClient.empty(self._endpoint):
            self._endpoint = 'api.dingtalk.com'

    def add_hrm_preentry_with_options(
        self,
        request: dingtalkhrm__1__0_models.AddHrmPreentryRequest,
        headers: dingtalkhrm__1__0_models.AddHrmPreentryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.AddHrmPreentryResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.AddHrmPreentryHeaders()
        return self.add_hrm_preentry_with_options(request, headers, runtime)

    async def add_hrm_preentry_async(
        self,
        request: dingtalkhrm__1__0_models.AddHrmPreentryRequest,
    ) -> dingtalkhrm__1__0_models.AddHrmPreentryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.AddHrmPreentryHeaders()
        return await self.add_hrm_preentry_with_options_async(request, headers, runtime)

    def device_market_manager_with_options(
        self,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.DeviceMarketManagerResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = {}
        return self.device_market_manager_with_options(headers, runtime)

    async def device_market_manager_async(self) -> dingtalkhrm__1__0_models.DeviceMarketManagerResponse:
        runtime = util_models.RuntimeOptions()
        headers = {}
        return await self.device_market_manager_with_options_async(headers, runtime)

    def device_market_order_manager_with_options(
        self,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.DeviceMarketOrderManagerResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = {}
        return self.device_market_order_manager_with_options(headers, runtime)

    async def device_market_order_manager_async(self) -> dingtalkhrm__1__0_models.DeviceMarketOrderManagerResponse:
        runtime = util_models.RuntimeOptions()
        headers = {}
        return await self.device_market_order_manager_with_options_async(headers, runtime)

    def e_cert_query_with_options(
        self,
        request: dingtalkhrm__1__0_models.ECertQueryRequest,
        headers: dingtalkhrm__1__0_models.ECertQueryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.ECertQueryResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.ECertQueryHeaders()
        return self.e_cert_query_with_options(request, headers, runtime)

    async def e_cert_query_async(
        self,
        request: dingtalkhrm__1__0_models.ECertQueryRequest,
    ) -> dingtalkhrm__1__0_models.ECertQueryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.ECertQueryHeaders()
        return await self.e_cert_query_with_options_async(request, headers, runtime)

    def employee_attachment_update_with_options(
        self,
        request: dingtalkhrm__1__0_models.EmployeeAttachmentUpdateRequest,
        headers: dingtalkhrm__1__0_models.EmployeeAttachmentUpdateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.EmployeeAttachmentUpdateResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.EmployeeAttachmentUpdateHeaders()
        return self.employee_attachment_update_with_options(request, headers, runtime)

    async def employee_attachment_update_async(
        self,
        request: dingtalkhrm__1__0_models.EmployeeAttachmentUpdateRequest,
    ) -> dingtalkhrm__1__0_models.EmployeeAttachmentUpdateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.EmployeeAttachmentUpdateHeaders()
        return await self.employee_attachment_update_with_options_async(request, headers, runtime)

    def esign_rollback_with_options(
        self,
        request: dingtalkhrm__1__0_models.EsignRollbackRequest,
        headers: dingtalkhrm__1__0_models.EsignRollbackHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.EsignRollbackResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.EsignRollbackHeaders()
        return self.esign_rollback_with_options(request, headers, runtime)

    async def esign_rollback_async(
        self,
        request: dingtalkhrm__1__0_models.EsignRollbackRequest,
    ) -> dingtalkhrm__1__0_models.EsignRollbackResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.EsignRollbackHeaders()
        return await self.esign_rollback_with_options_async(request, headers, runtime)

    def hrm_mail_send_with_options(
        self,
        request: dingtalkhrm__1__0_models.HrmMailSendRequest,
        headers: dingtalkhrm__1__0_models.HrmMailSendHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.HrmMailSendResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.HrmMailSendHeaders()
        return self.hrm_mail_send_with_options(request, headers, runtime)

    async def hrm_mail_send_async(
        self,
        request: dingtalkhrm__1__0_models.HrmMailSendRequest,
    ) -> dingtalkhrm__1__0_models.HrmMailSendResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.HrmMailSendHeaders()
        return await self.hrm_mail_send_with_options_async(request, headers, runtime)

    def hrm_moka_event_with_options(
        self,
        request: dingtalkhrm__1__0_models.HrmMokaEventRequest,
        headers: dingtalkhrm__1__0_models.HrmMokaEventHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.HrmMokaEventResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.HrmMokaEventHeaders()
        return self.hrm_moka_event_with_options(request, headers, runtime)

    async def hrm_moka_event_async(
        self,
        request: dingtalkhrm__1__0_models.HrmMokaEventRequest,
    ) -> dingtalkhrm__1__0_models.HrmMokaEventResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.HrmMokaEventHeaders()
        return await self.hrm_moka_event_with_options_async(request, headers, runtime)

    def hrm_moka_oapi_with_options(
        self,
        request: dingtalkhrm__1__0_models.HrmMokaOapiRequest,
        headers: dingtalkhrm__1__0_models.HrmMokaOapiHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.HrmMokaOapiResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.HrmMokaOapiHeaders()
        return self.hrm_moka_oapi_with_options(request, headers, runtime)

    async def hrm_moka_oapi_async(
        self,
        request: dingtalkhrm__1__0_models.HrmMokaOapiRequest,
    ) -> dingtalkhrm__1__0_models.HrmMokaOapiResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.HrmMokaOapiHeaders()
        return await self.hrm_moka_oapi_with_options_async(request, headers, runtime)

    def hrm_process_regular_with_options(
        self,
        request: dingtalkhrm__1__0_models.HrmProcessRegularRequest,
        headers: dingtalkhrm__1__0_models.HrmProcessRegularHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.HrmProcessRegularResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.HrmProcessRegularHeaders()
        return self.hrm_process_regular_with_options(request, headers, runtime)

    async def hrm_process_regular_async(
        self,
        request: dingtalkhrm__1__0_models.HrmProcessRegularRequest,
    ) -> dingtalkhrm__1__0_models.HrmProcessRegularResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.HrmProcessRegularHeaders()
        return await self.hrm_process_regular_with_options_async(request, headers, runtime)

    def hrm_process_transfer_with_options(
        self,
        request: dingtalkhrm__1__0_models.HrmProcessTransferRequest,
        headers: dingtalkhrm__1__0_models.HrmProcessTransferHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.HrmProcessTransferResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.HrmProcessTransferHeaders()
        return self.hrm_process_transfer_with_options(request, headers, runtime)

    async def hrm_process_transfer_async(
        self,
        request: dingtalkhrm__1__0_models.HrmProcessTransferRequest,
    ) -> dingtalkhrm__1__0_models.HrmProcessTransferResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.HrmProcessTransferHeaders()
        return await self.hrm_process_transfer_with_options_async(request, headers, runtime)

    def hrm_process_update_termination_info_with_options(
        self,
        request: dingtalkhrm__1__0_models.HrmProcessUpdateTerminationInfoRequest,
        headers: dingtalkhrm__1__0_models.HrmProcessUpdateTerminationInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.HrmProcessUpdateTerminationInfoResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.HrmProcessUpdateTerminationInfoHeaders()
        return self.hrm_process_update_termination_info_with_options(request, headers, runtime)

    async def hrm_process_update_termination_info_async(
        self,
        request: dingtalkhrm__1__0_models.HrmProcessUpdateTerminationInfoRequest,
    ) -> dingtalkhrm__1__0_models.HrmProcessUpdateTerminationInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.HrmProcessUpdateTerminationInfoHeaders()
        return await self.hrm_process_update_termination_info_with_options_async(request, headers, runtime)

    def hrm_pts_service_with_options(
        self,
        request: dingtalkhrm__1__0_models.HrmPtsServiceRequest,
        headers: dingtalkhrm__1__0_models.HrmPtsServiceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.HrmPtsServiceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.env):
            body['env'] = request.env
        if not UtilClient.is_unset(request.method):
            body['method'] = request.method
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
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.env):
            body['env'] = request.env
        if not UtilClient.is_unset(request.method):
            body['method'] = request.method
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.HrmPtsServiceHeaders()
        return self.hrm_pts_service_with_options(request, headers, runtime)

    async def hrm_pts_service_async(
        self,
        request: dingtalkhrm__1__0_models.HrmPtsServiceRequest,
    ) -> dingtalkhrm__1__0_models.HrmPtsServiceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.HrmPtsServiceHeaders()
        return await self.hrm_pts_service_with_options_async(request, headers, runtime)

    def master_data_delete_with_options(
        self,
        request: dingtalkhrm__1__0_models.MasterDataDeleteRequest,
        headers: dingtalkhrm__1__0_models.MasterDataDeleteHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.MasterDataDeleteResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.MasterDataDeleteHeaders()
        return self.master_data_delete_with_options(request, headers, runtime)

    async def master_data_delete_async(
        self,
        request: dingtalkhrm__1__0_models.MasterDataDeleteRequest,
    ) -> dingtalkhrm__1__0_models.MasterDataDeleteResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.MasterDataDeleteHeaders()
        return await self.master_data_delete_with_options_async(request, headers, runtime)

    def master_data_query_with_options(
        self,
        request: dingtalkhrm__1__0_models.MasterDataQueryRequest,
        headers: dingtalkhrm__1__0_models.MasterDataQueryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.MasterDataQueryResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.MasterDataQueryHeaders()
        return self.master_data_query_with_options(request, headers, runtime)

    async def master_data_query_async(
        self,
        request: dingtalkhrm__1__0_models.MasterDataQueryRequest,
    ) -> dingtalkhrm__1__0_models.MasterDataQueryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.MasterDataQueryHeaders()
        return await self.master_data_query_with_options_async(request, headers, runtime)

    def master_data_save_with_options(
        self,
        request: dingtalkhrm__1__0_models.MasterDataSaveRequest,
        headers: dingtalkhrm__1__0_models.MasterDataSaveHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.MasterDataSaveResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.MasterDataSaveHeaders()
        return self.master_data_save_with_options(request, headers, runtime)

    async def master_data_save_async(
        self,
        request: dingtalkhrm__1__0_models.MasterDataSaveRequest,
    ) -> dingtalkhrm__1__0_models.MasterDataSaveResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.MasterDataSaveHeaders()
        return await self.master_data_save_with_options_async(request, headers, runtime)

    def master_data_tenant_quey_with_options(
        self,
        request: dingtalkhrm__1__0_models.MasterDataTenantQueyRequest,
        headers: dingtalkhrm__1__0_models.MasterDataTenantQueyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.MasterDataTenantQueyResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.MasterDataTenantQueyHeaders()
        return self.master_data_tenant_quey_with_options(request, headers, runtime)

    async def master_data_tenant_quey_async(
        self,
        request: dingtalkhrm__1__0_models.MasterDataTenantQueyRequest,
    ) -> dingtalkhrm__1__0_models.MasterDataTenantQueyResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.MasterDataTenantQueyHeaders()
        return await self.master_data_tenant_quey_with_options_async(request, headers, runtime)

    def master_datas_query_with_options(
        self,
        request: dingtalkhrm__1__0_models.MasterDatasQueryRequest,
        headers: dingtalkhrm__1__0_models.MasterDatasQueryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.MasterDatasQueryResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.MasterDatasQueryHeaders()
        return self.master_datas_query_with_options(request, headers, runtime)

    async def master_datas_query_async(
        self,
        request: dingtalkhrm__1__0_models.MasterDatasQueryRequest,
    ) -> dingtalkhrm__1__0_models.MasterDatasQueryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.MasterDatasQueryHeaders()
        return await self.master_datas_query_with_options_async(request, headers, runtime)

    def query_custom_entry_processes_with_options(
        self,
        request: dingtalkhrm__1__0_models.QueryCustomEntryProcessesRequest,
        headers: dingtalkhrm__1__0_models.QueryCustomEntryProcessesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.QueryCustomEntryProcessesResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.QueryCustomEntryProcessesHeaders()
        return self.query_custom_entry_processes_with_options(request, headers, runtime)

    async def query_custom_entry_processes_async(
        self,
        request: dingtalkhrm__1__0_models.QueryCustomEntryProcessesRequest,
    ) -> dingtalkhrm__1__0_models.QueryCustomEntryProcessesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.QueryCustomEntryProcessesHeaders()
        return await self.query_custom_entry_processes_with_options_async(request, headers, runtime)

    def query_dismission_staff_id_list_with_options(
        self,
        request: dingtalkhrm__1__0_models.QueryDismissionStaffIdListRequest,
        headers: dingtalkhrm__1__0_models.QueryDismissionStaffIdListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.QueryDismissionStaffIdListResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.QueryDismissionStaffIdListHeaders()
        return self.query_dismission_staff_id_list_with_options(request, headers, runtime)

    async def query_dismission_staff_id_list_async(
        self,
        request: dingtalkhrm__1__0_models.QueryDismissionStaffIdListRequest,
    ) -> dingtalkhrm__1__0_models.QueryDismissionStaffIdListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.QueryDismissionStaffIdListHeaders()
        return await self.query_dismission_staff_id_list_with_options_async(request, headers, runtime)

    def query_hrm_employee_dismission_info_with_options(
        self,
        tmp_req: dingtalkhrm__1__0_models.QueryHrmEmployeeDismissionInfoRequest,
        headers: dingtalkhrm__1__0_models.QueryHrmEmployeeDismissionInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.QueryHrmEmployeeDismissionInfoResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.QueryHrmEmployeeDismissionInfoHeaders()
        return self.query_hrm_employee_dismission_info_with_options(request, headers, runtime)

    async def query_hrm_employee_dismission_info_async(
        self,
        request: dingtalkhrm__1__0_models.QueryHrmEmployeeDismissionInfoRequest,
    ) -> dingtalkhrm__1__0_models.QueryHrmEmployeeDismissionInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.QueryHrmEmployeeDismissionInfoHeaders()
        return await self.query_hrm_employee_dismission_info_with_options_async(request, headers, runtime)

    def query_job_ranks_with_options(
        self,
        request: dingtalkhrm__1__0_models.QueryJobRanksRequest,
        headers: dingtalkhrm__1__0_models.QueryJobRanksHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.QueryJobRanksResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.QueryJobRanksHeaders()
        return self.query_job_ranks_with_options(request, headers, runtime)

    async def query_job_ranks_async(
        self,
        request: dingtalkhrm__1__0_models.QueryJobRanksRequest,
    ) -> dingtalkhrm__1__0_models.QueryJobRanksResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.QueryJobRanksHeaders()
        return await self.query_job_ranks_with_options_async(request, headers, runtime)

    def query_jobs_with_options(
        self,
        request: dingtalkhrm__1__0_models.QueryJobsRequest,
        headers: dingtalkhrm__1__0_models.QueryJobsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.QueryJobsResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.QueryJobsHeaders()
        return self.query_jobs_with_options(request, headers, runtime)

    async def query_jobs_async(
        self,
        request: dingtalkhrm__1__0_models.QueryJobsRequest,
    ) -> dingtalkhrm__1__0_models.QueryJobsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.QueryJobsHeaders()
        return await self.query_jobs_with_options_async(request, headers, runtime)

    def query_positions_with_options(
        self,
        request: dingtalkhrm__1__0_models.QueryPositionsRequest,
        headers: dingtalkhrm__1__0_models.QueryPositionsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.QueryPositionsResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.QueryPositionsHeaders()
        return self.query_positions_with_options(request, headers, runtime)

    async def query_positions_async(
        self,
        request: dingtalkhrm__1__0_models.QueryPositionsRequest,
    ) -> dingtalkhrm__1__0_models.QueryPositionsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.QueryPositionsHeaders()
        return await self.query_positions_with_options_async(request, headers, runtime)

    def roster_meta_available_field_list_with_options(
        self,
        request: dingtalkhrm__1__0_models.RosterMetaAvailableFieldListRequest,
        headers: dingtalkhrm__1__0_models.RosterMetaAvailableFieldListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.RosterMetaAvailableFieldListResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.RosterMetaAvailableFieldListHeaders()
        return self.roster_meta_available_field_list_with_options(request, headers, runtime)

    async def roster_meta_available_field_list_async(
        self,
        request: dingtalkhrm__1__0_models.RosterMetaAvailableFieldListRequest,
    ) -> dingtalkhrm__1__0_models.RosterMetaAvailableFieldListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.RosterMetaAvailableFieldListHeaders()
        return await self.roster_meta_available_field_list_with_options_async(request, headers, runtime)

    def roster_meta_field_options_update_with_options(
        self,
        request: dingtalkhrm__1__0_models.RosterMetaFieldOptionsUpdateRequest,
        headers: dingtalkhrm__1__0_models.RosterMetaFieldOptionsUpdateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.RosterMetaFieldOptionsUpdateResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.RosterMetaFieldOptionsUpdateHeaders()
        return self.roster_meta_field_options_update_with_options(request, headers, runtime)

    async def roster_meta_field_options_update_async(
        self,
        request: dingtalkhrm__1__0_models.RosterMetaFieldOptionsUpdateRequest,
    ) -> dingtalkhrm__1__0_models.RosterMetaFieldOptionsUpdateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.RosterMetaFieldOptionsUpdateHeaders()
        return await self.roster_meta_field_options_update_with_options_async(request, headers, runtime)

    def send_isv_card_message_with_options(
        self,
        request: dingtalkhrm__1__0_models.SendIsvCardMessageRequest,
        headers: dingtalkhrm__1__0_models.SendIsvCardMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.SendIsvCardMessageResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.SendIsvCardMessageHeaders()
        return self.send_isv_card_message_with_options(request, headers, runtime)

    async def send_isv_card_message_async(
        self,
        request: dingtalkhrm__1__0_models.SendIsvCardMessageRequest,
    ) -> dingtalkhrm__1__0_models.SendIsvCardMessageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.SendIsvCardMessageHeaders()
        return await self.send_isv_card_message_with_options_async(request, headers, runtime)

    def solution_task_init_with_options(
        self,
        request: dingtalkhrm__1__0_models.SolutionTaskInitRequest,
        headers: dingtalkhrm__1__0_models.SolutionTaskInitHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.SolutionTaskInitResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.SolutionTaskInitHeaders()
        return self.solution_task_init_with_options(request, headers, runtime)

    async def solution_task_init_async(
        self,
        request: dingtalkhrm__1__0_models.SolutionTaskInitRequest,
    ) -> dingtalkhrm__1__0_models.SolutionTaskInitResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.SolutionTaskInitHeaders()
        return await self.solution_task_init_with_options_async(request, headers, runtime)

    def solution_task_save_with_options(
        self,
        request: dingtalkhrm__1__0_models.SolutionTaskSaveRequest,
        headers: dingtalkhrm__1__0_models.SolutionTaskSaveHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.SolutionTaskSaveResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.SolutionTaskSaveHeaders()
        return self.solution_task_save_with_options(request, headers, runtime)

    async def solution_task_save_async(
        self,
        request: dingtalkhrm__1__0_models.SolutionTaskSaveRequest,
    ) -> dingtalkhrm__1__0_models.SolutionTaskSaveResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.SolutionTaskSaveHeaders()
        return await self.solution_task_save_with_options_async(request, headers, runtime)

    def sync_task_template_with_options(
        self,
        request: dingtalkhrm__1__0_models.SyncTaskTemplateRequest,
        headers: dingtalkhrm__1__0_models.SyncTaskTemplateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.SyncTaskTemplateResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.SyncTaskTemplateHeaders()
        return self.sync_task_template_with_options(request, headers, runtime)

    async def sync_task_template_async(
        self,
        request: dingtalkhrm__1__0_models.SyncTaskTemplateRequest,
    ) -> dingtalkhrm__1__0_models.SyncTaskTemplateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.SyncTaskTemplateHeaders()
        return await self.sync_task_template_with_options_async(request, headers, runtime)

    def update_isv_card_message_with_options(
        self,
        request: dingtalkhrm__1__0_models.UpdateIsvCardMessageRequest,
        headers: dingtalkhrm__1__0_models.UpdateIsvCardMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.UpdateIsvCardMessageResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.UpdateIsvCardMessageHeaders()
        return self.update_isv_card_message_with_options(request, headers, runtime)

    async def update_isv_card_message_async(
        self,
        request: dingtalkhrm__1__0_models.UpdateIsvCardMessageRequest,
    ) -> dingtalkhrm__1__0_models.UpdateIsvCardMessageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.UpdateIsvCardMessageHeaders()
        return await self.update_isv_card_message_with_options_async(request, headers, runtime)
