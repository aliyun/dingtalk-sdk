# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.okr_1_0 import models as dingtalkokr__1__0_models
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

    def align_objective_with_options(
        self,
        objective_id: str,
        request: dingtalkokr__1__0_models.AlignObjectiveRequest,
        headers: dingtalkokr__1__0_models.AlignObjectiveHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkokr__1__0_models.AlignObjectiveResponse:
        """
        @summary 增加对齐目标
        
        @param request: AlignObjectiveRequest
        @param headers: AlignObjectiveHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AlignObjectiveResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        body = {}
        if not UtilClient.is_unset(request.period_id):
            body['periodId'] = request.period_id
        if not UtilClient.is_unset(request.target_id):
            body['targetId'] = request.target_id
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
            action='AlignObjective',
            version='okr_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/okr/objectives/{objective_id}/alignments',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkokr__1__0_models.AlignObjectiveResponse(),
            self.execute(params, req, runtime)
        )

    async def align_objective_with_options_async(
        self,
        objective_id: str,
        request: dingtalkokr__1__0_models.AlignObjectiveRequest,
        headers: dingtalkokr__1__0_models.AlignObjectiveHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkokr__1__0_models.AlignObjectiveResponse:
        """
        @summary 增加对齐目标
        
        @param request: AlignObjectiveRequest
        @param headers: AlignObjectiveHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AlignObjectiveResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        body = {}
        if not UtilClient.is_unset(request.period_id):
            body['periodId'] = request.period_id
        if not UtilClient.is_unset(request.target_id):
            body['targetId'] = request.target_id
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
            action='AlignObjective',
            version='okr_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/okr/objectives/{objective_id}/alignments',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkokr__1__0_models.AlignObjectiveResponse(),
            await self.execute_async(params, req, runtime)
        )

    def align_objective(
        self,
        objective_id: str,
        request: dingtalkokr__1__0_models.AlignObjectiveRequest,
    ) -> dingtalkokr__1__0_models.AlignObjectiveResponse:
        """
        @summary 增加对齐目标
        
        @param request: AlignObjectiveRequest
        @return: AlignObjectiveResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkokr__1__0_models.AlignObjectiveHeaders()
        return self.align_objective_with_options(objective_id, request, headers, runtime)

    async def align_objective_async(
        self,
        objective_id: str,
        request: dingtalkokr__1__0_models.AlignObjectiveRequest,
    ) -> dingtalkokr__1__0_models.AlignObjectiveResponse:
        """
        @summary 增加对齐目标
        
        @param request: AlignObjectiveRequest
        @return: AlignObjectiveResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkokr__1__0_models.AlignObjectiveHeaders()
        return await self.align_objective_with_options_async(objective_id, request, headers, runtime)

    def batch_add_permission_with_options(
        self,
        request: dingtalkokr__1__0_models.BatchAddPermissionRequest,
        headers: dingtalkokr__1__0_models.BatchAddPermissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkokr__1__0_models.BatchAddPermissionResponse:
        """
        @summary  批量添加权限信息
        
        @param request: BatchAddPermissionRequest
        @param headers: BatchAddPermissionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchAddPermissionResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        body = {}
        if not UtilClient.is_unset(request.list):
            body['list'] = request.list
        if not UtilClient.is_unset(request.target_id):
            body['targetId'] = request.target_id
        if not UtilClient.is_unset(request.target_type):
            body['targetType'] = request.target_type
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
            action='BatchAddPermission',
            version='okr_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/okr/permissions/batch',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkokr__1__0_models.BatchAddPermissionResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_add_permission_with_options_async(
        self,
        request: dingtalkokr__1__0_models.BatchAddPermissionRequest,
        headers: dingtalkokr__1__0_models.BatchAddPermissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkokr__1__0_models.BatchAddPermissionResponse:
        """
        @summary  批量添加权限信息
        
        @param request: BatchAddPermissionRequest
        @param headers: BatchAddPermissionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchAddPermissionResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        body = {}
        if not UtilClient.is_unset(request.list):
            body['list'] = request.list
        if not UtilClient.is_unset(request.target_id):
            body['targetId'] = request.target_id
        if not UtilClient.is_unset(request.target_type):
            body['targetType'] = request.target_type
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
            action='BatchAddPermission',
            version='okr_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/okr/permissions/batch',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkokr__1__0_models.BatchAddPermissionResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch_add_permission(
        self,
        request: dingtalkokr__1__0_models.BatchAddPermissionRequest,
    ) -> dingtalkokr__1__0_models.BatchAddPermissionResponse:
        """
        @summary  批量添加权限信息
        
        @param request: BatchAddPermissionRequest
        @return: BatchAddPermissionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkokr__1__0_models.BatchAddPermissionHeaders()
        return self.batch_add_permission_with_options(request, headers, runtime)

    async def batch_add_permission_async(
        self,
        request: dingtalkokr__1__0_models.BatchAddPermissionRequest,
    ) -> dingtalkokr__1__0_models.BatchAddPermissionResponse:
        """
        @summary  批量添加权限信息
        
        @param request: BatchAddPermissionRequest
        @return: BatchAddPermissionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkokr__1__0_models.BatchAddPermissionHeaders()
        return await self.batch_add_permission_with_options_async(request, headers, runtime)

    def batch_query_objective_with_options(
        self,
        request: dingtalkokr__1__0_models.BatchQueryObjectiveRequest,
        headers: dingtalkokr__1__0_models.BatchQueryObjectiveHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkokr__1__0_models.BatchQueryObjectiveResponse:
        """
        @summary 批量查询目标
        
        @param request: BatchQueryObjectiveRequest
        @param headers: BatchQueryObjectiveHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchQueryObjectiveResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        body = {}
        if not UtilClient.is_unset(request.objective_ids):
            body['objectiveIds'] = request.objective_ids
        if not UtilClient.is_unset(request.period_id):
            body['periodId'] = request.period_id
        if not UtilClient.is_unset(request.with_align):
            body['withAlign'] = request.with_align
        if not UtilClient.is_unset(request.with_kr):
            body['withKr'] = request.with_kr
        if not UtilClient.is_unset(request.with_progress):
            body['withProgress'] = request.with_progress
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
            action='BatchQueryObjective',
            version='okr_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/okr/objectives/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkokr__1__0_models.BatchQueryObjectiveResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_query_objective_with_options_async(
        self,
        request: dingtalkokr__1__0_models.BatchQueryObjectiveRequest,
        headers: dingtalkokr__1__0_models.BatchQueryObjectiveHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkokr__1__0_models.BatchQueryObjectiveResponse:
        """
        @summary 批量查询目标
        
        @param request: BatchQueryObjectiveRequest
        @param headers: BatchQueryObjectiveHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchQueryObjectiveResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        body = {}
        if not UtilClient.is_unset(request.objective_ids):
            body['objectiveIds'] = request.objective_ids
        if not UtilClient.is_unset(request.period_id):
            body['periodId'] = request.period_id
        if not UtilClient.is_unset(request.with_align):
            body['withAlign'] = request.with_align
        if not UtilClient.is_unset(request.with_kr):
            body['withKr'] = request.with_kr
        if not UtilClient.is_unset(request.with_progress):
            body['withProgress'] = request.with_progress
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
            action='BatchQueryObjective',
            version='okr_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/okr/objectives/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkokr__1__0_models.BatchQueryObjectiveResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch_query_objective(
        self,
        request: dingtalkokr__1__0_models.BatchQueryObjectiveRequest,
    ) -> dingtalkokr__1__0_models.BatchQueryObjectiveResponse:
        """
        @summary 批量查询目标
        
        @param request: BatchQueryObjectiveRequest
        @return: BatchQueryObjectiveResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkokr__1__0_models.BatchQueryObjectiveHeaders()
        return self.batch_query_objective_with_options(request, headers, runtime)

    async def batch_query_objective_async(
        self,
        request: dingtalkokr__1__0_models.BatchQueryObjectiveRequest,
    ) -> dingtalkokr__1__0_models.BatchQueryObjectiveResponse:
        """
        @summary 批量查询目标
        
        @param request: BatchQueryObjectiveRequest
        @return: BatchQueryObjectiveResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkokr__1__0_models.BatchQueryObjectiveHeaders()
        return await self.batch_query_objective_with_options_async(request, headers, runtime)

    def batch_query_user_with_options(
        self,
        request: dingtalkokr__1__0_models.BatchQueryUserRequest,
        headers: dingtalkokr__1__0_models.BatchQueryUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkokr__1__0_models.BatchQueryUserResponse:
        """
        @summary 批量查询用户信息
        
        @param request: BatchQueryUserRequest
        @param headers: BatchQueryUserHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchQueryUserResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.okr_user_ids):
            body['okrUserIds'] = request.okr_user_ids
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
            action='BatchQueryUser',
            version='okr_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/okr/users/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkokr__1__0_models.BatchQueryUserResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_query_user_with_options_async(
        self,
        request: dingtalkokr__1__0_models.BatchQueryUserRequest,
        headers: dingtalkokr__1__0_models.BatchQueryUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkokr__1__0_models.BatchQueryUserResponse:
        """
        @summary 批量查询用户信息
        
        @param request: BatchQueryUserRequest
        @param headers: BatchQueryUserHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchQueryUserResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.okr_user_ids):
            body['okrUserIds'] = request.okr_user_ids
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
            action='BatchQueryUser',
            version='okr_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/okr/users/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkokr__1__0_models.BatchQueryUserResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch_query_user(
        self,
        request: dingtalkokr__1__0_models.BatchQueryUserRequest,
    ) -> dingtalkokr__1__0_models.BatchQueryUserResponse:
        """
        @summary 批量查询用户信息
        
        @param request: BatchQueryUserRequest
        @return: BatchQueryUserResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkokr__1__0_models.BatchQueryUserHeaders()
        return self.batch_query_user_with_options(request, headers, runtime)

    async def batch_query_user_async(
        self,
        request: dingtalkokr__1__0_models.BatchQueryUserRequest,
    ) -> dingtalkokr__1__0_models.BatchQueryUserResponse:
        """
        @summary 批量查询用户信息
        
        @param request: BatchQueryUserRequest
        @return: BatchQueryUserResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkokr__1__0_models.BatchQueryUserHeaders()
        return await self.batch_query_user_with_options_async(request, headers, runtime)

    def create_key_result_with_options(
        self,
        request: dingtalkokr__1__0_models.CreateKeyResultRequest,
        headers: dingtalkokr__1__0_models.CreateKeyResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkokr__1__0_models.CreateKeyResultResponse:
        """
        @summary 创建keyResult
        
        @param request: CreateKeyResultRequest
        @param headers: CreateKeyResultHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateKeyResultResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.objective_id):
            body['objectiveId'] = request.objective_id
        if not UtilClient.is_unset(request.period_id):
            body['periodId'] = request.period_id
        if not UtilClient.is_unset(request.prev_position):
            body['prevPosition'] = request.prev_position
        if not UtilClient.is_unset(request.weight):
            body['weight'] = request.weight
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
            action='CreateKeyResult',
            version='okr_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/okr/keyResults',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkokr__1__0_models.CreateKeyResultResponse(),
            self.execute(params, req, runtime)
        )

    async def create_key_result_with_options_async(
        self,
        request: dingtalkokr__1__0_models.CreateKeyResultRequest,
        headers: dingtalkokr__1__0_models.CreateKeyResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkokr__1__0_models.CreateKeyResultResponse:
        """
        @summary 创建keyResult
        
        @param request: CreateKeyResultRequest
        @param headers: CreateKeyResultHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateKeyResultResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.objective_id):
            body['objectiveId'] = request.objective_id
        if not UtilClient.is_unset(request.period_id):
            body['periodId'] = request.period_id
        if not UtilClient.is_unset(request.prev_position):
            body['prevPosition'] = request.prev_position
        if not UtilClient.is_unset(request.weight):
            body['weight'] = request.weight
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
            action='CreateKeyResult',
            version='okr_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/okr/keyResults',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkokr__1__0_models.CreateKeyResultResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_key_result(
        self,
        request: dingtalkokr__1__0_models.CreateKeyResultRequest,
    ) -> dingtalkokr__1__0_models.CreateKeyResultResponse:
        """
        @summary 创建keyResult
        
        @param request: CreateKeyResultRequest
        @return: CreateKeyResultResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkokr__1__0_models.CreateKeyResultHeaders()
        return self.create_key_result_with_options(request, headers, runtime)

    async def create_key_result_async(
        self,
        request: dingtalkokr__1__0_models.CreateKeyResultRequest,
    ) -> dingtalkokr__1__0_models.CreateKeyResultResponse:
        """
        @summary 创建keyResult
        
        @param request: CreateKeyResultRequest
        @return: CreateKeyResultResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkokr__1__0_models.CreateKeyResultHeaders()
        return await self.create_key_result_with_options_async(request, headers, runtime)

    def create_objective_with_options(
        self,
        request: dingtalkokr__1__0_models.CreateObjectiveRequest,
        headers: dingtalkokr__1__0_models.CreateObjectiveHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkokr__1__0_models.CreateObjectiveResponse:
        """
        @summary 创建目标
        
        @param request: CreateObjectiveRequest
        @param headers: CreateObjectiveHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateObjectiveResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.period_id):
            body['periodId'] = request.period_id
        if not UtilClient.is_unset(request.prev_position):
            body['prevPosition'] = request.prev_position
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
            action='CreateObjective',
            version='okr_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/okr/objectives',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkokr__1__0_models.CreateObjectiveResponse(),
            self.execute(params, req, runtime)
        )

    async def create_objective_with_options_async(
        self,
        request: dingtalkokr__1__0_models.CreateObjectiveRequest,
        headers: dingtalkokr__1__0_models.CreateObjectiveHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkokr__1__0_models.CreateObjectiveResponse:
        """
        @summary 创建目标
        
        @param request: CreateObjectiveRequest
        @param headers: CreateObjectiveHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateObjectiveResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.period_id):
            body['periodId'] = request.period_id
        if not UtilClient.is_unset(request.prev_position):
            body['prevPosition'] = request.prev_position
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
            action='CreateObjective',
            version='okr_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/okr/objectives',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkokr__1__0_models.CreateObjectiveResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_objective(
        self,
        request: dingtalkokr__1__0_models.CreateObjectiveRequest,
    ) -> dingtalkokr__1__0_models.CreateObjectiveResponse:
        """
        @summary 创建目标
        
        @param request: CreateObjectiveRequest
        @return: CreateObjectiveResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkokr__1__0_models.CreateObjectiveHeaders()
        return self.create_objective_with_options(request, headers, runtime)

    async def create_objective_async(
        self,
        request: dingtalkokr__1__0_models.CreateObjectiveRequest,
    ) -> dingtalkokr__1__0_models.CreateObjectiveResponse:
        """
        @summary 创建目标
        
        @param request: CreateObjectiveRequest
        @return: CreateObjectiveResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkokr__1__0_models.CreateObjectiveHeaders()
        return await self.create_objective_with_options_async(request, headers, runtime)

    def delete_key_result_with_options(
        self,
        request: dingtalkokr__1__0_models.DeleteKeyResultRequest,
        headers: dingtalkokr__1__0_models.DeleteKeyResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkokr__1__0_models.DeleteKeyResultResponse:
        """
        @summary 删除keyresult的方法
        
        @param request: DeleteKeyResultRequest
        @param headers: DeleteKeyResultHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteKeyResultResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.kr_id):
            query['krId'] = request.kr_id
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
            action='DeleteKeyResult',
            version='okr_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/okr/keyResults',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkokr__1__0_models.DeleteKeyResultResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_key_result_with_options_async(
        self,
        request: dingtalkokr__1__0_models.DeleteKeyResultRequest,
        headers: dingtalkokr__1__0_models.DeleteKeyResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkokr__1__0_models.DeleteKeyResultResponse:
        """
        @summary 删除keyresult的方法
        
        @param request: DeleteKeyResultRequest
        @param headers: DeleteKeyResultHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteKeyResultResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.kr_id):
            query['krId'] = request.kr_id
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
            action='DeleteKeyResult',
            version='okr_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/okr/keyResults',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkokr__1__0_models.DeleteKeyResultResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_key_result(
        self,
        request: dingtalkokr__1__0_models.DeleteKeyResultRequest,
    ) -> dingtalkokr__1__0_models.DeleteKeyResultResponse:
        """
        @summary 删除keyresult的方法
        
        @param request: DeleteKeyResultRequest
        @return: DeleteKeyResultResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkokr__1__0_models.DeleteKeyResultHeaders()
        return self.delete_key_result_with_options(request, headers, runtime)

    async def delete_key_result_async(
        self,
        request: dingtalkokr__1__0_models.DeleteKeyResultRequest,
    ) -> dingtalkokr__1__0_models.DeleteKeyResultResponse:
        """
        @summary 删除keyresult的方法
        
        @param request: DeleteKeyResultRequest
        @return: DeleteKeyResultResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkokr__1__0_models.DeleteKeyResultHeaders()
        return await self.delete_key_result_with_options_async(request, headers, runtime)

    def delete_objective_with_options(
        self,
        objective_id: str,
        request: dingtalkokr__1__0_models.DeleteObjectiveRequest,
        headers: dingtalkokr__1__0_models.DeleteObjectiveHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkokr__1__0_models.DeleteObjectiveResponse:
        """
        @summary 删除目标
        
        @param request: DeleteObjectiveRequest
        @param headers: DeleteObjectiveHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteObjectiveResponse
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
            action='DeleteObjective',
            version='okr_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/okr/objectives/{objective_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkokr__1__0_models.DeleteObjectiveResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_objective_with_options_async(
        self,
        objective_id: str,
        request: dingtalkokr__1__0_models.DeleteObjectiveRequest,
        headers: dingtalkokr__1__0_models.DeleteObjectiveHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkokr__1__0_models.DeleteObjectiveResponse:
        """
        @summary 删除目标
        
        @param request: DeleteObjectiveRequest
        @param headers: DeleteObjectiveHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteObjectiveResponse
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
            action='DeleteObjective',
            version='okr_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/okr/objectives/{objective_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkokr__1__0_models.DeleteObjectiveResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_objective(
        self,
        objective_id: str,
        request: dingtalkokr__1__0_models.DeleteObjectiveRequest,
    ) -> dingtalkokr__1__0_models.DeleteObjectiveResponse:
        """
        @summary 删除目标
        
        @param request: DeleteObjectiveRequest
        @return: DeleteObjectiveResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkokr__1__0_models.DeleteObjectiveHeaders()
        return self.delete_objective_with_options(objective_id, request, headers, runtime)

    async def delete_objective_async(
        self,
        objective_id: str,
        request: dingtalkokr__1__0_models.DeleteObjectiveRequest,
    ) -> dingtalkokr__1__0_models.DeleteObjectiveResponse:
        """
        @summary 删除目标
        
        @param request: DeleteObjectiveRequest
        @return: DeleteObjectiveResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkokr__1__0_models.DeleteObjectiveHeaders()
        return await self.delete_objective_with_options_async(objective_id, request, headers, runtime)

    def delete_permission_with_options(
        self,
        request: dingtalkokr__1__0_models.DeletePermissionRequest,
        headers: dingtalkokr__1__0_models.DeletePermissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkokr__1__0_models.DeletePermissionResponse:
        """
        @summary  删除权限信息
        
        @param request: DeletePermissionRequest
        @param headers: DeletePermissionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeletePermissionResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.id):
            query['id'] = request.id
        if not UtilClient.is_unset(request.policy_type):
            query['policyType'] = request.policy_type
        if not UtilClient.is_unset(request.target_id):
            query['targetId'] = request.target_id
        if not UtilClient.is_unset(request.target_type):
            query['targetType'] = request.target_type
        if not UtilClient.is_unset(request.type):
            query['type'] = request.type
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
            action='DeletePermission',
            version='okr_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/okr/permissions/delete',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkokr__1__0_models.DeletePermissionResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_permission_with_options_async(
        self,
        request: dingtalkokr__1__0_models.DeletePermissionRequest,
        headers: dingtalkokr__1__0_models.DeletePermissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkokr__1__0_models.DeletePermissionResponse:
        """
        @summary  删除权限信息
        
        @param request: DeletePermissionRequest
        @param headers: DeletePermissionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeletePermissionResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.id):
            query['id'] = request.id
        if not UtilClient.is_unset(request.policy_type):
            query['policyType'] = request.policy_type
        if not UtilClient.is_unset(request.target_id):
            query['targetId'] = request.target_id
        if not UtilClient.is_unset(request.target_type):
            query['targetType'] = request.target_type
        if not UtilClient.is_unset(request.type):
            query['type'] = request.type
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
            action='DeletePermission',
            version='okr_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/okr/permissions/delete',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkokr__1__0_models.DeletePermissionResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_permission(
        self,
        request: dingtalkokr__1__0_models.DeletePermissionRequest,
    ) -> dingtalkokr__1__0_models.DeletePermissionResponse:
        """
        @summary  删除权限信息
        
        @param request: DeletePermissionRequest
        @return: DeletePermissionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkokr__1__0_models.DeletePermissionHeaders()
        return self.delete_permission_with_options(request, headers, runtime)

    async def delete_permission_async(
        self,
        request: dingtalkokr__1__0_models.DeletePermissionRequest,
    ) -> dingtalkokr__1__0_models.DeletePermissionResponse:
        """
        @summary  删除权限信息
        
        @param request: DeletePermissionRequest
        @return: DeletePermissionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkokr__1__0_models.DeletePermissionHeaders()
        return await self.delete_permission_with_options_async(request, headers, runtime)

    def get_period_list_with_options(
        self,
        headers: dingtalkokr__1__0_models.GetPeriodListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkokr__1__0_models.GetPeriodListResponse:
        """
        @summary 获取周期列表
        
        @param headers: GetPeriodListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetPeriodListResponse
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
            action='GetPeriodList',
            version='okr_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/okr/periods',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkokr__1__0_models.GetPeriodListResponse(),
            self.execute(params, req, runtime)
        )

    async def get_period_list_with_options_async(
        self,
        headers: dingtalkokr__1__0_models.GetPeriodListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkokr__1__0_models.GetPeriodListResponse:
        """
        @summary 获取周期列表
        
        @param headers: GetPeriodListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetPeriodListResponse
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
            action='GetPeriodList',
            version='okr_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/okr/periods',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkokr__1__0_models.GetPeriodListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_period_list(self) -> dingtalkokr__1__0_models.GetPeriodListResponse:
        """
        @summary 获取周期列表
        
        @return: GetPeriodListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkokr__1__0_models.GetPeriodListHeaders()
        return self.get_period_list_with_options(headers, runtime)

    async def get_period_list_async(self) -> dingtalkokr__1__0_models.GetPeriodListResponse:
        """
        @summary 获取周期列表
        
        @return: GetPeriodListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkokr__1__0_models.GetPeriodListHeaders()
        return await self.get_period_list_with_options_async(headers, runtime)

    def get_permission_with_options(
        self,
        request: dingtalkokr__1__0_models.GetPermissionRequest,
        headers: dingtalkokr__1__0_models.GetPermissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkokr__1__0_models.GetPermissionResponse:
        """
        @summary 获取权限信息
        
        @param request: GetPermissionRequest
        @param headers: GetPermissionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetPermissionResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.target_id):
            query['targetId'] = request.target_id
        if not UtilClient.is_unset(request.target_type):
            query['targetType'] = request.target_type
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        if not UtilClient.is_unset(request.with_kr):
            query['withKr'] = request.with_kr
        if not UtilClient.is_unset(request.with_objective):
            query['withObjective'] = request.with_objective
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
            action='GetPermission',
            version='okr_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/okr/permissions',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkokr__1__0_models.GetPermissionResponse(),
            self.execute(params, req, runtime)
        )

    async def get_permission_with_options_async(
        self,
        request: dingtalkokr__1__0_models.GetPermissionRequest,
        headers: dingtalkokr__1__0_models.GetPermissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkokr__1__0_models.GetPermissionResponse:
        """
        @summary 获取权限信息
        
        @param request: GetPermissionRequest
        @param headers: GetPermissionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetPermissionResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.target_id):
            query['targetId'] = request.target_id
        if not UtilClient.is_unset(request.target_type):
            query['targetType'] = request.target_type
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        if not UtilClient.is_unset(request.with_kr):
            query['withKr'] = request.with_kr
        if not UtilClient.is_unset(request.with_objective):
            query['withObjective'] = request.with_objective
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
            action='GetPermission',
            version='okr_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/okr/permissions',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkokr__1__0_models.GetPermissionResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_permission(
        self,
        request: dingtalkokr__1__0_models.GetPermissionRequest,
    ) -> dingtalkokr__1__0_models.GetPermissionResponse:
        """
        @summary 获取权限信息
        
        @param request: GetPermissionRequest
        @return: GetPermissionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkokr__1__0_models.GetPermissionHeaders()
        return self.get_permission_with_options(request, headers, runtime)

    async def get_permission_async(
        self,
        request: dingtalkokr__1__0_models.GetPermissionRequest,
    ) -> dingtalkokr__1__0_models.GetPermissionResponse:
        """
        @summary 获取权限信息
        
        @param request: GetPermissionRequest
        @return: GetPermissionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkokr__1__0_models.GetPermissionHeaders()
        return await self.get_permission_with_options_async(request, headers, runtime)

    def get_user_okr_with_options(
        self,
        request: dingtalkokr__1__0_models.GetUserOkrRequest,
        headers: dingtalkokr__1__0_models.GetUserOkrHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkokr__1__0_models.GetUserOkrResponse:
        """
        @summary  获取用户当前周期下的全部 OKR 内容
        
        @param request: GetUserOkrRequest
        @param headers: GetUserOkrHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetUserOkrResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.period_id):
            query['periodId'] = request.period_id
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
            action='GetUserOkr',
            version='okr_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/okr/users/okrs',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkokr__1__0_models.GetUserOkrResponse(),
            self.execute(params, req, runtime)
        )

    async def get_user_okr_with_options_async(
        self,
        request: dingtalkokr__1__0_models.GetUserOkrRequest,
        headers: dingtalkokr__1__0_models.GetUserOkrHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkokr__1__0_models.GetUserOkrResponse:
        """
        @summary  获取用户当前周期下的全部 OKR 内容
        
        @param request: GetUserOkrRequest
        @param headers: GetUserOkrHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetUserOkrResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.period_id):
            query['periodId'] = request.period_id
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
            action='GetUserOkr',
            version='okr_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/okr/users/okrs',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkokr__1__0_models.GetUserOkrResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_user_okr(
        self,
        request: dingtalkokr__1__0_models.GetUserOkrRequest,
    ) -> dingtalkokr__1__0_models.GetUserOkrResponse:
        """
        @summary  获取用户当前周期下的全部 OKR 内容
        
        @param request: GetUserOkrRequest
        @return: GetUserOkrResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkokr__1__0_models.GetUserOkrHeaders()
        return self.get_user_okr_with_options(request, headers, runtime)

    async def get_user_okr_async(
        self,
        request: dingtalkokr__1__0_models.GetUserOkrRequest,
    ) -> dingtalkokr__1__0_models.GetUserOkrResponse:
        """
        @summary  获取用户当前周期下的全部 OKR 内容
        
        @param request: GetUserOkrRequest
        @return: GetUserOkrResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkokr__1__0_models.GetUserOkrHeaders()
        return await self.get_user_okr_with_options_async(request, headers, runtime)

    def okr_objectives_batch_with_options(
        self,
        request: dingtalkokr__1__0_models.OkrObjectivesBatchRequest,
        headers: dingtalkokr__1__0_models.OkrObjectivesBatchHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkokr__1__0_models.OkrObjectivesBatchResponse:
        """
        @summary 批量查询OKR
        
        @param request: OkrObjectivesBatchRequest
        @param headers: OkrObjectivesBatchHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: OkrObjectivesBatchResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.goods_code):
            body['goodsCode'] = request.goods_code
        if not UtilClient.is_unset(request.objective_ids):
            body['objectiveIds'] = request.objective_ids
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='OkrObjectivesBatch',
            version='okr_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/okr/pro/objectives/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkokr__1__0_models.OkrObjectivesBatchResponse(),
            self.execute(params, req, runtime)
        )

    async def okr_objectives_batch_with_options_async(
        self,
        request: dingtalkokr__1__0_models.OkrObjectivesBatchRequest,
        headers: dingtalkokr__1__0_models.OkrObjectivesBatchHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkokr__1__0_models.OkrObjectivesBatchResponse:
        """
        @summary 批量查询OKR
        
        @param request: OkrObjectivesBatchRequest
        @param headers: OkrObjectivesBatchHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: OkrObjectivesBatchResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.goods_code):
            body['goodsCode'] = request.goods_code
        if not UtilClient.is_unset(request.objective_ids):
            body['objectiveIds'] = request.objective_ids
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='OkrObjectivesBatch',
            version='okr_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/okr/pro/objectives/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkokr__1__0_models.OkrObjectivesBatchResponse(),
            await self.execute_async(params, req, runtime)
        )

    def okr_objectives_batch(
        self,
        request: dingtalkokr__1__0_models.OkrObjectivesBatchRequest,
    ) -> dingtalkokr__1__0_models.OkrObjectivesBatchResponse:
        """
        @summary 批量查询OKR
        
        @param request: OkrObjectivesBatchRequest
        @return: OkrObjectivesBatchResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkokr__1__0_models.OkrObjectivesBatchHeaders()
        return self.okr_objectives_batch_with_options(request, headers, runtime)

    async def okr_objectives_batch_async(
        self,
        request: dingtalkokr__1__0_models.OkrObjectivesBatchRequest,
    ) -> dingtalkokr__1__0_models.OkrObjectivesBatchResponse:
        """
        @summary 批量查询OKR
        
        @param request: OkrObjectivesBatchRequest
        @return: OkrObjectivesBatchResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkokr__1__0_models.OkrObjectivesBatchHeaders()
        return await self.okr_objectives_batch_with_options_async(request, headers, runtime)

    def okr_objectives_by_user_with_options(
        self,
        ding_user_id: str,
        request: dingtalkokr__1__0_models.OkrObjectivesByUserRequest,
        headers: dingtalkokr__1__0_models.OkrObjectivesByUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkokr__1__0_models.OkrObjectivesByUserResponse:
        """
        @summary 查询单个用户的OKR
        
        @param request: OkrObjectivesByUserRequest
        @param headers: OkrObjectivesByUserHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: OkrObjectivesByUserResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.goods_code):
            query['goodsCode'] = request.goods_code
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
            action='OkrObjectivesByUser',
            version='okr_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/okr/pro/users/{ding_user_id}/objectives',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkokr__1__0_models.OkrObjectivesByUserResponse(),
            self.execute(params, req, runtime)
        )

    async def okr_objectives_by_user_with_options_async(
        self,
        ding_user_id: str,
        request: dingtalkokr__1__0_models.OkrObjectivesByUserRequest,
        headers: dingtalkokr__1__0_models.OkrObjectivesByUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkokr__1__0_models.OkrObjectivesByUserResponse:
        """
        @summary 查询单个用户的OKR
        
        @param request: OkrObjectivesByUserRequest
        @param headers: OkrObjectivesByUserHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: OkrObjectivesByUserResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.goods_code):
            query['goodsCode'] = request.goods_code
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
            action='OkrObjectivesByUser',
            version='okr_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/okr/pro/users/{ding_user_id}/objectives',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkokr__1__0_models.OkrObjectivesByUserResponse(),
            await self.execute_async(params, req, runtime)
        )

    def okr_objectives_by_user(
        self,
        ding_user_id: str,
        request: dingtalkokr__1__0_models.OkrObjectivesByUserRequest,
    ) -> dingtalkokr__1__0_models.OkrObjectivesByUserResponse:
        """
        @summary 查询单个用户的OKR
        
        @param request: OkrObjectivesByUserRequest
        @return: OkrObjectivesByUserResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkokr__1__0_models.OkrObjectivesByUserHeaders()
        return self.okr_objectives_by_user_with_options(ding_user_id, request, headers, runtime)

    async def okr_objectives_by_user_async(
        self,
        ding_user_id: str,
        request: dingtalkokr__1__0_models.OkrObjectivesByUserRequest,
    ) -> dingtalkokr__1__0_models.OkrObjectivesByUserResponse:
        """
        @summary 查询单个用户的OKR
        
        @param request: OkrObjectivesByUserRequest
        @return: OkrObjectivesByUserResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkokr__1__0_models.OkrObjectivesByUserHeaders()
        return await self.okr_objectives_by_user_with_options_async(ding_user_id, request, headers, runtime)

    def okr_periods_with_options(
        self,
        request: dingtalkokr__1__0_models.OkrPeriodsRequest,
        headers: dingtalkokr__1__0_models.OkrPeriodsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkokr__1__0_models.OkrPeriodsResponse:
        """
        @summary 获取 OKR 周期
        
        @param request: OkrPeriodsRequest
        @param headers: OkrPeriodsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: OkrPeriodsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.goods_code):
            query['goodsCode'] = request.goods_code
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
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
            action='OkrPeriods',
            version='okr_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/okr/pro/periods',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkokr__1__0_models.OkrPeriodsResponse(),
            self.execute(params, req, runtime)
        )

    async def okr_periods_with_options_async(
        self,
        request: dingtalkokr__1__0_models.OkrPeriodsRequest,
        headers: dingtalkokr__1__0_models.OkrPeriodsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkokr__1__0_models.OkrPeriodsResponse:
        """
        @summary 获取 OKR 周期
        
        @param request: OkrPeriodsRequest
        @param headers: OkrPeriodsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: OkrPeriodsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.goods_code):
            query['goodsCode'] = request.goods_code
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
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
            action='OkrPeriods',
            version='okr_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/okr/pro/periods',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkokr__1__0_models.OkrPeriodsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def okr_periods(
        self,
        request: dingtalkokr__1__0_models.OkrPeriodsRequest,
    ) -> dingtalkokr__1__0_models.OkrPeriodsResponse:
        """
        @summary 获取 OKR 周期
        
        @param request: OkrPeriodsRequest
        @return: OkrPeriodsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkokr__1__0_models.OkrPeriodsHeaders()
        return self.okr_periods_with_options(request, headers, runtime)

    async def okr_periods_async(
        self,
        request: dingtalkokr__1__0_models.OkrPeriodsRequest,
    ) -> dingtalkokr__1__0_models.OkrPeriodsResponse:
        """
        @summary 获取 OKR 周期
        
        @param request: OkrPeriodsRequest
        @return: OkrPeriodsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkokr__1__0_models.OkrPeriodsHeaders()
        return await self.okr_periods_with_options_async(request, headers, runtime)

    def un_align_objective_with_options(
        self,
        objective_id: str,
        request: dingtalkokr__1__0_models.UnAlignObjectiveRequest,
        headers: dingtalkokr__1__0_models.UnAlignObjectiveHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkokr__1__0_models.UnAlignObjectiveResponse:
        """
        @summary  取消对齐Objective
        
        @param request: UnAlignObjectiveRequest
        @param headers: UnAlignObjectiveHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UnAlignObjectiveResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        body = {}
        if not UtilClient.is_unset(request.period_id):
            body['periodId'] = request.period_id
        if not UtilClient.is_unset(request.target_id):
            body['targetId'] = request.target_id
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
            action='UnAlignObjective',
            version='okr_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/okr/objectives/{objective_id}/alignments/cancel',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkokr__1__0_models.UnAlignObjectiveResponse(),
            self.execute(params, req, runtime)
        )

    async def un_align_objective_with_options_async(
        self,
        objective_id: str,
        request: dingtalkokr__1__0_models.UnAlignObjectiveRequest,
        headers: dingtalkokr__1__0_models.UnAlignObjectiveHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkokr__1__0_models.UnAlignObjectiveResponse:
        """
        @summary  取消对齐Objective
        
        @param request: UnAlignObjectiveRequest
        @param headers: UnAlignObjectiveHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UnAlignObjectiveResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        body = {}
        if not UtilClient.is_unset(request.period_id):
            body['periodId'] = request.period_id
        if not UtilClient.is_unset(request.target_id):
            body['targetId'] = request.target_id
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
            action='UnAlignObjective',
            version='okr_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/okr/objectives/{objective_id}/alignments/cancel',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkokr__1__0_models.UnAlignObjectiveResponse(),
            await self.execute_async(params, req, runtime)
        )

    def un_align_objective(
        self,
        objective_id: str,
        request: dingtalkokr__1__0_models.UnAlignObjectiveRequest,
    ) -> dingtalkokr__1__0_models.UnAlignObjectiveResponse:
        """
        @summary  取消对齐Objective
        
        @param request: UnAlignObjectiveRequest
        @return: UnAlignObjectiveResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkokr__1__0_models.UnAlignObjectiveHeaders()
        return self.un_align_objective_with_options(objective_id, request, headers, runtime)

    async def un_align_objective_async(
        self,
        objective_id: str,
        request: dingtalkokr__1__0_models.UnAlignObjectiveRequest,
    ) -> dingtalkokr__1__0_models.UnAlignObjectiveResponse:
        """
        @summary  取消对齐Objective
        
        @param request: UnAlignObjectiveRequest
        @return: UnAlignObjectiveResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkokr__1__0_models.UnAlignObjectiveHeaders()
        return await self.un_align_objective_with_options_async(objective_id, request, headers, runtime)

    def update_krof_content_with_options(
        self,
        request: dingtalkokr__1__0_models.UpdateKROfContentRequest,
        headers: dingtalkokr__1__0_models.UpdateKROfContentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkokr__1__0_models.UpdateKROfContentResponse:
        """
        @summary 更改KR内容
        
        @param request: UpdateKROfContentRequest
        @param headers: UpdateKROfContentHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateKROfContentResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.kr_id):
            query['krId'] = request.kr_id
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.update_quote_list):
            body['updateQuoteList'] = request.update_quote_list
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
            action='UpdateKROfContent',
            version='okr_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/okr/keyResults/contents',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkokr__1__0_models.UpdateKROfContentResponse(),
            self.execute(params, req, runtime)
        )

    async def update_krof_content_with_options_async(
        self,
        request: dingtalkokr__1__0_models.UpdateKROfContentRequest,
        headers: dingtalkokr__1__0_models.UpdateKROfContentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkokr__1__0_models.UpdateKROfContentResponse:
        """
        @summary 更改KR内容
        
        @param request: UpdateKROfContentRequest
        @param headers: UpdateKROfContentHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateKROfContentResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.kr_id):
            query['krId'] = request.kr_id
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.update_quote_list):
            body['updateQuoteList'] = request.update_quote_list
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
            action='UpdateKROfContent',
            version='okr_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/okr/keyResults/contents',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkokr__1__0_models.UpdateKROfContentResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_krof_content(
        self,
        request: dingtalkokr__1__0_models.UpdateKROfContentRequest,
    ) -> dingtalkokr__1__0_models.UpdateKROfContentResponse:
        """
        @summary 更改KR内容
        
        @param request: UpdateKROfContentRequest
        @return: UpdateKROfContentResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkokr__1__0_models.UpdateKROfContentHeaders()
        return self.update_krof_content_with_options(request, headers, runtime)

    async def update_krof_content_async(
        self,
        request: dingtalkokr__1__0_models.UpdateKROfContentRequest,
    ) -> dingtalkokr__1__0_models.UpdateKROfContentResponse:
        """
        @summary 更改KR内容
        
        @param request: UpdateKROfContentRequest
        @return: UpdateKROfContentResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkokr__1__0_models.UpdateKROfContentHeaders()
        return await self.update_krof_content_with_options_async(request, headers, runtime)

    def update_krof_score_with_options(
        self,
        request: dingtalkokr__1__0_models.UpdateKROfScoreRequest,
        headers: dingtalkokr__1__0_models.UpdateKROfScoreHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkokr__1__0_models.UpdateKROfScoreResponse:
        """
        @summary 更改KR分数
        
        @param request: UpdateKROfScoreRequest
        @param headers: UpdateKROfScoreHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateKROfScoreResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.kr_id):
            query['krId'] = request.kr_id
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        body = {}
        if not UtilClient.is_unset(request.score):
            body['score'] = request.score
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
            action='UpdateKROfScore',
            version='okr_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/okr/keyResults/scores',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkokr__1__0_models.UpdateKROfScoreResponse(),
            self.execute(params, req, runtime)
        )

    async def update_krof_score_with_options_async(
        self,
        request: dingtalkokr__1__0_models.UpdateKROfScoreRequest,
        headers: dingtalkokr__1__0_models.UpdateKROfScoreHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkokr__1__0_models.UpdateKROfScoreResponse:
        """
        @summary 更改KR分数
        
        @param request: UpdateKROfScoreRequest
        @param headers: UpdateKROfScoreHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateKROfScoreResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.kr_id):
            query['krId'] = request.kr_id
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        body = {}
        if not UtilClient.is_unset(request.score):
            body['score'] = request.score
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
            action='UpdateKROfScore',
            version='okr_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/okr/keyResults/scores',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkokr__1__0_models.UpdateKROfScoreResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_krof_score(
        self,
        request: dingtalkokr__1__0_models.UpdateKROfScoreRequest,
    ) -> dingtalkokr__1__0_models.UpdateKROfScoreResponse:
        """
        @summary 更改KR分数
        
        @param request: UpdateKROfScoreRequest
        @return: UpdateKROfScoreResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkokr__1__0_models.UpdateKROfScoreHeaders()
        return self.update_krof_score_with_options(request, headers, runtime)

    async def update_krof_score_async(
        self,
        request: dingtalkokr__1__0_models.UpdateKROfScoreRequest,
    ) -> dingtalkokr__1__0_models.UpdateKROfScoreResponse:
        """
        @summary 更改KR分数
        
        @param request: UpdateKROfScoreRequest
        @return: UpdateKROfScoreResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkokr__1__0_models.UpdateKROfScoreHeaders()
        return await self.update_krof_score_with_options_async(request, headers, runtime)

    def update_krof_weight_with_options(
        self,
        request: dingtalkokr__1__0_models.UpdateKROfWeightRequest,
        headers: dingtalkokr__1__0_models.UpdateKROfWeightHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkokr__1__0_models.UpdateKROfWeightResponse:
        """
        @summary 更改 KR 权重
        
        @param request: UpdateKROfWeightRequest
        @param headers: UpdateKROfWeightHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateKROfWeightResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.kr_id):
            query['krId'] = request.kr_id
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        body = {}
        if not UtilClient.is_unset(request.weight):
            body['weight'] = request.weight
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
            action='UpdateKROfWeight',
            version='okr_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/okr/keyResults/weights',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkokr__1__0_models.UpdateKROfWeightResponse(),
            self.execute(params, req, runtime)
        )

    async def update_krof_weight_with_options_async(
        self,
        request: dingtalkokr__1__0_models.UpdateKROfWeightRequest,
        headers: dingtalkokr__1__0_models.UpdateKROfWeightHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkokr__1__0_models.UpdateKROfWeightResponse:
        """
        @summary 更改 KR 权重
        
        @param request: UpdateKROfWeightRequest
        @param headers: UpdateKROfWeightHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateKROfWeightResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.kr_id):
            query['krId'] = request.kr_id
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        body = {}
        if not UtilClient.is_unset(request.weight):
            body['weight'] = request.weight
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
            action='UpdateKROfWeight',
            version='okr_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/okr/keyResults/weights',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkokr__1__0_models.UpdateKROfWeightResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_krof_weight(
        self,
        request: dingtalkokr__1__0_models.UpdateKROfWeightRequest,
    ) -> dingtalkokr__1__0_models.UpdateKROfWeightResponse:
        """
        @summary 更改 KR 权重
        
        @param request: UpdateKROfWeightRequest
        @return: UpdateKROfWeightResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkokr__1__0_models.UpdateKROfWeightHeaders()
        return self.update_krof_weight_with_options(request, headers, runtime)

    async def update_krof_weight_async(
        self,
        request: dingtalkokr__1__0_models.UpdateKROfWeightRequest,
    ) -> dingtalkokr__1__0_models.UpdateKROfWeightResponse:
        """
        @summary 更改 KR 权重
        
        @param request: UpdateKROfWeightRequest
        @return: UpdateKROfWeightResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkokr__1__0_models.UpdateKROfWeightHeaders()
        return await self.update_krof_weight_with_options_async(request, headers, runtime)

    def update_objective_with_options(
        self,
        objective_id: str,
        request: dingtalkokr__1__0_models.UpdateObjectiveRequest,
        headers: dingtalkokr__1__0_models.UpdateObjectiveHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkokr__1__0_models.UpdateObjectiveResponse:
        """
        @summary 更新目标
        
        @param request: UpdateObjectiveRequest
        @param headers: UpdateObjectiveHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateObjectiveResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
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
            action='UpdateObjective',
            version='okr_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/okr/objectives/{objective_id}',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkokr__1__0_models.UpdateObjectiveResponse(),
            self.execute(params, req, runtime)
        )

    async def update_objective_with_options_async(
        self,
        objective_id: str,
        request: dingtalkokr__1__0_models.UpdateObjectiveRequest,
        headers: dingtalkokr__1__0_models.UpdateObjectiveHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkokr__1__0_models.UpdateObjectiveResponse:
        """
        @summary 更新目标
        
        @param request: UpdateObjectiveRequest
        @param headers: UpdateObjectiveHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateObjectiveResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
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
            action='UpdateObjective',
            version='okr_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/okr/objectives/{objective_id}',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkokr__1__0_models.UpdateObjectiveResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_objective(
        self,
        objective_id: str,
        request: dingtalkokr__1__0_models.UpdateObjectiveRequest,
    ) -> dingtalkokr__1__0_models.UpdateObjectiveResponse:
        """
        @summary 更新目标
        
        @param request: UpdateObjectiveRequest
        @return: UpdateObjectiveResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkokr__1__0_models.UpdateObjectiveHeaders()
        return self.update_objective_with_options(objective_id, request, headers, runtime)

    async def update_objective_async(
        self,
        objective_id: str,
        request: dingtalkokr__1__0_models.UpdateObjectiveRequest,
    ) -> dingtalkokr__1__0_models.UpdateObjectiveResponse:
        """
        @summary 更新目标
        
        @param request: UpdateObjectiveRequest
        @return: UpdateObjectiveResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkokr__1__0_models.UpdateObjectiveHeaders()
        return await self.update_objective_with_options_async(objective_id, request, headers, runtime)

    def update_privacy_with_options(
        self,
        request: dingtalkokr__1__0_models.UpdatePrivacyRequest,
        headers: dingtalkokr__1__0_models.UpdatePrivacyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkokr__1__0_models.UpdatePrivacyResponse:
        """
        @summary 更新资源隐私策略
        
        @param request: UpdatePrivacyRequest
        @param headers: UpdatePrivacyHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdatePrivacyResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        body = {}
        if not UtilClient.is_unset(request.privacy):
            body['privacy'] = request.privacy
        if not UtilClient.is_unset(request.target_id):
            body['targetId'] = request.target_id
        if not UtilClient.is_unset(request.target_type):
            body['targetType'] = request.target_type
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
            action='UpdatePrivacy',
            version='okr_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/okr/permissions/privacies',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkokr__1__0_models.UpdatePrivacyResponse(),
            self.execute(params, req, runtime)
        )

    async def update_privacy_with_options_async(
        self,
        request: dingtalkokr__1__0_models.UpdatePrivacyRequest,
        headers: dingtalkokr__1__0_models.UpdatePrivacyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkokr__1__0_models.UpdatePrivacyResponse:
        """
        @summary 更新资源隐私策略
        
        @param request: UpdatePrivacyRequest
        @param headers: UpdatePrivacyHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdatePrivacyResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        body = {}
        if not UtilClient.is_unset(request.privacy):
            body['privacy'] = request.privacy
        if not UtilClient.is_unset(request.target_id):
            body['targetId'] = request.target_id
        if not UtilClient.is_unset(request.target_type):
            body['targetType'] = request.target_type
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
            action='UpdatePrivacy',
            version='okr_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/okr/permissions/privacies',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkokr__1__0_models.UpdatePrivacyResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_privacy(
        self,
        request: dingtalkokr__1__0_models.UpdatePrivacyRequest,
    ) -> dingtalkokr__1__0_models.UpdatePrivacyResponse:
        """
        @summary 更新资源隐私策略
        
        @param request: UpdatePrivacyRequest
        @return: UpdatePrivacyResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkokr__1__0_models.UpdatePrivacyHeaders()
        return self.update_privacy_with_options(request, headers, runtime)

    async def update_privacy_async(
        self,
        request: dingtalkokr__1__0_models.UpdatePrivacyRequest,
    ) -> dingtalkokr__1__0_models.UpdatePrivacyResponse:
        """
        @summary 更新资源隐私策略
        
        @param request: UpdatePrivacyRequest
        @return: UpdatePrivacyResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkokr__1__0_models.UpdatePrivacyHeaders()
        return await self.update_privacy_with_options_async(request, headers, runtime)
