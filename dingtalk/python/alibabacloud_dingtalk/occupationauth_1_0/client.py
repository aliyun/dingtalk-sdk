# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.occupationauth_1_0 import models as dingtalkoccupationauth__1__0_models
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

    def check_user_task_status_with_options(
        self,
        request: dingtalkoccupationauth__1__0_models.CheckUserTaskStatusRequest,
        headers: dingtalkoccupationauth__1__0_models.CheckUserTaskStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkoccupationauth__1__0_models.CheckUserTaskStatusResponse:
        """
        @summary 检查用户任务状态
        
        @param request: CheckUserTaskStatusRequest
        @param headers: CheckUserTaskStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CheckUserTaskStatusResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.province_code):
            body['provinceCode'] = request.province_code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CheckUserTaskStatus',
            version='occupationauth_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/occupationauth/auths/userTasks',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkoccupationauth__1__0_models.CheckUserTaskStatusResponse(),
            self.execute(params, req, runtime)
        )

    async def check_user_task_status_with_options_async(
        self,
        request: dingtalkoccupationauth__1__0_models.CheckUserTaskStatusRequest,
        headers: dingtalkoccupationauth__1__0_models.CheckUserTaskStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkoccupationauth__1__0_models.CheckUserTaskStatusResponse:
        """
        @summary 检查用户任务状态
        
        @param request: CheckUserTaskStatusRequest
        @param headers: CheckUserTaskStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CheckUserTaskStatusResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.province_code):
            body['provinceCode'] = request.province_code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CheckUserTaskStatus',
            version='occupationauth_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/occupationauth/auths/userTasks',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkoccupationauth__1__0_models.CheckUserTaskStatusResponse(),
            await self.execute_async(params, req, runtime)
        )

    def check_user_task_status(
        self,
        request: dingtalkoccupationauth__1__0_models.CheckUserTaskStatusRequest,
    ) -> dingtalkoccupationauth__1__0_models.CheckUserTaskStatusResponse:
        """
        @summary 检查用户任务状态
        
        @param request: CheckUserTaskStatusRequest
        @return: CheckUserTaskStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkoccupationauth__1__0_models.CheckUserTaskStatusHeaders()
        return self.check_user_task_status_with_options(request, headers, runtime)

    async def check_user_task_status_async(
        self,
        request: dingtalkoccupationauth__1__0_models.CheckUserTaskStatusRequest,
    ) -> dingtalkoccupationauth__1__0_models.CheckUserTaskStatusResponse:
        """
        @summary 检查用户任务状态
        
        @param request: CheckUserTaskStatusRequest
        @return: CheckUserTaskStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkoccupationauth__1__0_models.CheckUserTaskStatusHeaders()
        return await self.check_user_task_status_with_options_async(request, headers, runtime)

    def check_user_tasks_status_with_options(
        self,
        request: dingtalkoccupationauth__1__0_models.CheckUserTasksStatusRequest,
        headers: dingtalkoccupationauth__1__0_models.CheckUserTasksStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkoccupationauth__1__0_models.CheckUserTasksStatusResponse:
        """
        @summary 检查用户任务状态
        
        @param request: CheckUserTasksStatusRequest
        @param headers: CheckUserTasksStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CheckUserTasksStatusResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.province_code):
            query['provinceCode'] = request.province_code
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
            action='CheckUserTasksStatus',
            version='occupationauth_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/occupationauth/userTasks/check',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkoccupationauth__1__0_models.CheckUserTasksStatusResponse(),
            self.execute(params, req, runtime)
        )

    async def check_user_tasks_status_with_options_async(
        self,
        request: dingtalkoccupationauth__1__0_models.CheckUserTasksStatusRequest,
        headers: dingtalkoccupationauth__1__0_models.CheckUserTasksStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkoccupationauth__1__0_models.CheckUserTasksStatusResponse:
        """
        @summary 检查用户任务状态
        
        @param request: CheckUserTasksStatusRequest
        @param headers: CheckUserTasksStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CheckUserTasksStatusResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.province_code):
            query['provinceCode'] = request.province_code
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
            action='CheckUserTasksStatus',
            version='occupationauth_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/occupationauth/userTasks/check',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkoccupationauth__1__0_models.CheckUserTasksStatusResponse(),
            await self.execute_async(params, req, runtime)
        )

    def check_user_tasks_status(
        self,
        request: dingtalkoccupationauth__1__0_models.CheckUserTasksStatusRequest,
    ) -> dingtalkoccupationauth__1__0_models.CheckUserTasksStatusResponse:
        """
        @summary 检查用户任务状态
        
        @param request: CheckUserTasksStatusRequest
        @return: CheckUserTasksStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkoccupationauth__1__0_models.CheckUserTasksStatusHeaders()
        return self.check_user_tasks_status_with_options(request, headers, runtime)

    async def check_user_tasks_status_async(
        self,
        request: dingtalkoccupationauth__1__0_models.CheckUserTasksStatusRequest,
    ) -> dingtalkoccupationauth__1__0_models.CheckUserTasksStatusResponse:
        """
        @summary 检查用户任务状态
        
        @param request: CheckUserTasksStatusRequest
        @return: CheckUserTasksStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkoccupationauth__1__0_models.CheckUserTasksStatusHeaders()
        return await self.check_user_tasks_status_with_options_async(request, headers, runtime)
