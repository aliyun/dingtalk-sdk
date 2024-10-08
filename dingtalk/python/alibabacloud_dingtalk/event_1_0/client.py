# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore
from typing import Dict

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.event_1_0 import models as dingtalkevent__1__0_models
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
        self._product_id = 'dingtalk'
        gateway_client = GatewayClientClient()
        self._spi = gateway_client
        self._endpoint_rule = ''
        if UtilClient.empty(self._endpoint):
            self._endpoint = 'api.dingtalk.com'

    def get_call_back_faile_result_with_options(
        self,
        request: dingtalkevent__1__0_models.GetCallBackFaileResultRequest,
        headers: dingtalkevent__1__0_models.GetCallBackFaileResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkevent__1__0_models.GetCallBackFaileResultResponse:
        """
        @summary 调用本获取推送失败的变更事件。
        
        @param request: GetCallBackFaileResultRequest
        @param headers: GetCallBackFaileResultHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetCallBackFaileResultResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.begin_time):
            query['beginTime'] = request.begin_time
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
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
            action='GetCallBackFaileResult',
            version='event_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/event/callbacks/failedResults',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkevent__1__0_models.GetCallBackFaileResultResponse(),
            self.execute(params, req, runtime)
        )

    async def get_call_back_faile_result_with_options_async(
        self,
        request: dingtalkevent__1__0_models.GetCallBackFaileResultRequest,
        headers: dingtalkevent__1__0_models.GetCallBackFaileResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkevent__1__0_models.GetCallBackFaileResultResponse:
        """
        @summary 调用本获取推送失败的变更事件。
        
        @param request: GetCallBackFaileResultRequest
        @param headers: GetCallBackFaileResultHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetCallBackFaileResultResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.begin_time):
            query['beginTime'] = request.begin_time
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
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
            action='GetCallBackFaileResult',
            version='event_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/event/callbacks/failedResults',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkevent__1__0_models.GetCallBackFaileResultResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_call_back_faile_result(
        self,
        request: dingtalkevent__1__0_models.GetCallBackFaileResultRequest,
    ) -> dingtalkevent__1__0_models.GetCallBackFaileResultResponse:
        """
        @summary 调用本获取推送失败的变更事件。
        
        @param request: GetCallBackFaileResultRequest
        @return: GetCallBackFaileResultResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkevent__1__0_models.GetCallBackFaileResultHeaders()
        return self.get_call_back_faile_result_with_options(request, headers, runtime)

    async def get_call_back_faile_result_async(
        self,
        request: dingtalkevent__1__0_models.GetCallBackFaileResultRequest,
    ) -> dingtalkevent__1__0_models.GetCallBackFaileResultResponse:
        """
        @summary 调用本获取推送失败的变更事件。
        
        @param request: GetCallBackFaileResultRequest
        @return: GetCallBackFaileResultResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkevent__1__0_models.GetCallBackFaileResultHeaders()
        return await self.get_call_back_faile_result_with_options_async(request, headers, runtime)

    def install_app_with_options(
        self,
        request: dingtalkevent__1__0_models.InstallAppRequest,
        headers: dingtalkevent__1__0_models.InstallAppHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkevent__1__0_models.InstallAppResponse:
        """
        @summary 安装一方应用
        
        @param request: InstallAppRequest
        @param headers: InstallAppHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: InstallAppResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_id):
            query['appId'] = request.app_id
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.ding_user_id):
            query['dingUserId'] = request.ding_user_id
        if not UtilClient.is_unset(request.suite_id):
            query['suiteId'] = request.suite_id
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
            action='InstallApp',
            version='event_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/event/elm/apps/install',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkevent__1__0_models.InstallAppResponse(),
            self.execute(params, req, runtime)
        )

    async def install_app_with_options_async(
        self,
        request: dingtalkevent__1__0_models.InstallAppRequest,
        headers: dingtalkevent__1__0_models.InstallAppHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkevent__1__0_models.InstallAppResponse:
        """
        @summary 安装一方应用
        
        @param request: InstallAppRequest
        @param headers: InstallAppHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: InstallAppResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_id):
            query['appId'] = request.app_id
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.ding_user_id):
            query['dingUserId'] = request.ding_user_id
        if not UtilClient.is_unset(request.suite_id):
            query['suiteId'] = request.suite_id
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
            action='InstallApp',
            version='event_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/event/elm/apps/install',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkevent__1__0_models.InstallAppResponse(),
            await self.execute_async(params, req, runtime)
        )

    def install_app(
        self,
        request: dingtalkevent__1__0_models.InstallAppRequest,
    ) -> dingtalkevent__1__0_models.InstallAppResponse:
        """
        @summary 安装一方应用
        
        @param request: InstallAppRequest
        @return: InstallAppResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkevent__1__0_models.InstallAppHeaders()
        return self.install_app_with_options(request, headers, runtime)

    async def install_app_async(
        self,
        request: dingtalkevent__1__0_models.InstallAppRequest,
    ) -> dingtalkevent__1__0_models.InstallAppResponse:
        """
        @summary 安装一方应用
        
        @param request: InstallAppRequest
        @return: InstallAppResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkevent__1__0_models.InstallAppHeaders()
        return await self.install_app_with_options_async(request, headers, runtime)

    def install_cool_app_with_options(
        self,
        tmp_req: dingtalkevent__1__0_models.InstallCoolAppRequest,
        headers: dingtalkevent__1__0_models.InstallCoolAppHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkevent__1__0_models.InstallCoolAppResponse:
        """
        @summary 安装酷应用
        
        @param tmp_req: InstallCoolAppRequest
        @param headers: InstallCoolAppHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: InstallCoolAppResponse
        """
        UtilClient.validate_model(tmp_req)
        request = dingtalkevent__1__0_models.InstallCoolAppShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.feature):
            request.feature_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.feature, 'feature', 'json')
        if not UtilClient.is_unset(tmp_req.options):
            request.options_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.options, 'options', 'json')
        query = {}
        if not UtilClient.is_unset(request.app_id):
            query['appId'] = request.app_id
        if not UtilClient.is_unset(request.cool_app_code):
            query['coolAppCode'] = request.cool_app_code
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.feature_shrink):
            query['feature'] = request.feature_shrink
        if not UtilClient.is_unset(request.install_uid):
            query['installUid'] = request.install_uid
        if not UtilClient.is_unset(request.open_conversation_id):
            query['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.options_shrink):
            query['options'] = request.options_shrink
        if not UtilClient.is_unset(request.suite_id):
            query['suiteId'] = request.suite_id
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
            action='InstallCoolApp',
            version='event_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/event/elm/coolApps/install',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkevent__1__0_models.InstallCoolAppResponse(),
            self.execute(params, req, runtime)
        )

    async def install_cool_app_with_options_async(
        self,
        tmp_req: dingtalkevent__1__0_models.InstallCoolAppRequest,
        headers: dingtalkevent__1__0_models.InstallCoolAppHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkevent__1__0_models.InstallCoolAppResponse:
        """
        @summary 安装酷应用
        
        @param tmp_req: InstallCoolAppRequest
        @param headers: InstallCoolAppHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: InstallCoolAppResponse
        """
        UtilClient.validate_model(tmp_req)
        request = dingtalkevent__1__0_models.InstallCoolAppShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.feature):
            request.feature_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.feature, 'feature', 'json')
        if not UtilClient.is_unset(tmp_req.options):
            request.options_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.options, 'options', 'json')
        query = {}
        if not UtilClient.is_unset(request.app_id):
            query['appId'] = request.app_id
        if not UtilClient.is_unset(request.cool_app_code):
            query['coolAppCode'] = request.cool_app_code
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.feature_shrink):
            query['feature'] = request.feature_shrink
        if not UtilClient.is_unset(request.install_uid):
            query['installUid'] = request.install_uid
        if not UtilClient.is_unset(request.open_conversation_id):
            query['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.options_shrink):
            query['options'] = request.options_shrink
        if not UtilClient.is_unset(request.suite_id):
            query['suiteId'] = request.suite_id
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
            action='InstallCoolApp',
            version='event_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/event/elm/coolApps/install',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkevent__1__0_models.InstallCoolAppResponse(),
            await self.execute_async(params, req, runtime)
        )

    def install_cool_app(
        self,
        request: dingtalkevent__1__0_models.InstallCoolAppRequest,
    ) -> dingtalkevent__1__0_models.InstallCoolAppResponse:
        """
        @summary 安装酷应用
        
        @param request: InstallCoolAppRequest
        @return: InstallCoolAppResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkevent__1__0_models.InstallCoolAppHeaders()
        return self.install_cool_app_with_options(request, headers, runtime)

    async def install_cool_app_async(
        self,
        request: dingtalkevent__1__0_models.InstallCoolAppRequest,
    ) -> dingtalkevent__1__0_models.InstallCoolAppResponse:
        """
        @summary 安装酷应用
        
        @param request: InstallCoolAppRequest
        @return: InstallCoolAppResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkevent__1__0_models.InstallCoolAppHeaders()
        return await self.install_cool_app_with_options_async(request, headers, runtime)

    def re_push_suite_ticket_with_options(
        self,
        request: dingtalkevent__1__0_models.RePushSuiteTicketRequest,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkevent__1__0_models.RePushSuiteTicketResponse:
        """
        @summary 重新获取suiteTicket
        
        @param request: RePushSuiteTicketRequest
        @param headers: map
        @param runtime: runtime options for this request RuntimeOptions
        @return: RePushSuiteTicketResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.suite_id):
            query['suiteId'] = request.suite_id
        if not UtilClient.is_unset(request.suite_secret):
            query['suiteSecret'] = request.suite_secret
        req = open_api_models.OpenApiRequest(
            headers=headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='RePushSuiteTicket',
            version='event_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/event/suiteTicket/rePush',
            method='POST',
            auth_type='Anonymous',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkevent__1__0_models.RePushSuiteTicketResponse(),
            self.do_roarequest_with_form(params.action, params.version, params.protocol, params.method, params.auth_type, params.pathname, params.body_type, req, runtime)
        )

    async def re_push_suite_ticket_with_options_async(
        self,
        request: dingtalkevent__1__0_models.RePushSuiteTicketRequest,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkevent__1__0_models.RePushSuiteTicketResponse:
        """
        @summary 重新获取suiteTicket
        
        @param request: RePushSuiteTicketRequest
        @param headers: map
        @param runtime: runtime options for this request RuntimeOptions
        @return: RePushSuiteTicketResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.suite_id):
            query['suiteId'] = request.suite_id
        if not UtilClient.is_unset(request.suite_secret):
            query['suiteSecret'] = request.suite_secret
        req = open_api_models.OpenApiRequest(
            headers=headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='RePushSuiteTicket',
            version='event_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/event/suiteTicket/rePush',
            method='POST',
            auth_type='Anonymous',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkevent__1__0_models.RePushSuiteTicketResponse(),
            await self.do_roarequest_with_form_async(params.action, params.version, params.protocol, params.method, params.auth_type, params.pathname, params.body_type, req, runtime)
        )

    def re_push_suite_ticket(
        self,
        request: dingtalkevent__1__0_models.RePushSuiteTicketRequest,
    ) -> dingtalkevent__1__0_models.RePushSuiteTicketResponse:
        """
        @summary 重新获取suiteTicket
        
        @param request: RePushSuiteTicketRequest
        @return: RePushSuiteTicketResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = {}
        return self.re_push_suite_ticket_with_options(request, headers, runtime)

    async def re_push_suite_ticket_async(
        self,
        request: dingtalkevent__1__0_models.RePushSuiteTicketRequest,
    ) -> dingtalkevent__1__0_models.RePushSuiteTicketResponse:
        """
        @summary 重新获取suiteTicket
        
        @param request: RePushSuiteTicketRequest
        @return: RePushSuiteTicketResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = {}
        return await self.re_push_suite_ticket_with_options_async(request, headers, runtime)
