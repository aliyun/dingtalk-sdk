# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.agoal_1_0 import models as dingtalkagoal__1__0_models
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

    def agoal_create_progress_with_options(
        self,
        request: dingtalkagoal__1__0_models.AgoalCreateProgressRequest,
        headers: dingtalkagoal__1__0_models.AgoalCreateProgressHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.AgoalCreateProgressResponse:
        """
        @summary 创建目标进展
        
        @param request: AgoalCreateProgressRequest
        @param headers: AgoalCreateProgressHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AgoalCreateProgressResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.kr_id):
            body['krId'] = request.kr_id
        if not UtilClient.is_unset(request.merge_into_latest_progress):
            body['mergeIntoLatestProgress'] = request.merge_into_latest_progress
        if not UtilClient.is_unset(request.objective_id):
            body['objectiveId'] = request.objective_id
        if not UtilClient.is_unset(request.plain_text):
            body['plainText'] = request.plain_text
        if not UtilClient.is_unset(request.progress):
            body['progress'] = request.progress
        if not UtilClient.is_unset(request.progress_merge_period):
            body['progressMergePeriod'] = request.progress_merge_period
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
            action='AgoalCreateProgress',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/objectives/progresses',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.AgoalCreateProgressResponse(),
            self.execute(params, req, runtime)
        )

    async def agoal_create_progress_with_options_async(
        self,
        request: dingtalkagoal__1__0_models.AgoalCreateProgressRequest,
        headers: dingtalkagoal__1__0_models.AgoalCreateProgressHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.AgoalCreateProgressResponse:
        """
        @summary 创建目标进展
        
        @param request: AgoalCreateProgressRequest
        @param headers: AgoalCreateProgressHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AgoalCreateProgressResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.kr_id):
            body['krId'] = request.kr_id
        if not UtilClient.is_unset(request.merge_into_latest_progress):
            body['mergeIntoLatestProgress'] = request.merge_into_latest_progress
        if not UtilClient.is_unset(request.objective_id):
            body['objectiveId'] = request.objective_id
        if not UtilClient.is_unset(request.plain_text):
            body['plainText'] = request.plain_text
        if not UtilClient.is_unset(request.progress):
            body['progress'] = request.progress
        if not UtilClient.is_unset(request.progress_merge_period):
            body['progressMergePeriod'] = request.progress_merge_period
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
            action='AgoalCreateProgress',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/objectives/progresses',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.AgoalCreateProgressResponse(),
            await self.execute_async(params, req, runtime)
        )

    def agoal_create_progress(
        self,
        request: dingtalkagoal__1__0_models.AgoalCreateProgressRequest,
    ) -> dingtalkagoal__1__0_models.AgoalCreateProgressResponse:
        """
        @summary 创建目标进展
        
        @param request: AgoalCreateProgressRequest
        @return: AgoalCreateProgressResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.AgoalCreateProgressHeaders()
        return self.agoal_create_progress_with_options(request, headers, runtime)

    async def agoal_create_progress_async(
        self,
        request: dingtalkagoal__1__0_models.AgoalCreateProgressRequest,
    ) -> dingtalkagoal__1__0_models.AgoalCreateProgressResponse:
        """
        @summary 创建目标进展
        
        @param request: AgoalCreateProgressRequest
        @return: AgoalCreateProgressResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.AgoalCreateProgressHeaders()
        return await self.agoal_create_progress_with_options_async(request, headers, runtime)

    def agoal_entity_create_with_options(
        self,
        request: dingtalkagoal__1__0_models.AgoalEntityCreateRequest,
        headers: dingtalkagoal__1__0_models.AgoalEntityCreateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.AgoalEntityCreateResponse:
        """
        @summary 创建业务实体
        
        @param request: AgoalEntityCreateRequest
        @param headers: AgoalEntityCreateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AgoalEntityCreateResponse
        """
        UtilClient.validate_model(request)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=UtilClient.to_array(request.body)
        )
        params = open_api_models.Params(
            action='AgoalEntityCreate',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/entities',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.AgoalEntityCreateResponse(),
            self.execute(params, req, runtime)
        )

    async def agoal_entity_create_with_options_async(
        self,
        request: dingtalkagoal__1__0_models.AgoalEntityCreateRequest,
        headers: dingtalkagoal__1__0_models.AgoalEntityCreateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.AgoalEntityCreateResponse:
        """
        @summary 创建业务实体
        
        @param request: AgoalEntityCreateRequest
        @param headers: AgoalEntityCreateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AgoalEntityCreateResponse
        """
        UtilClient.validate_model(request)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=UtilClient.to_array(request.body)
        )
        params = open_api_models.Params(
            action='AgoalEntityCreate',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/entities',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.AgoalEntityCreateResponse(),
            await self.execute_async(params, req, runtime)
        )

    def agoal_entity_create(
        self,
        request: dingtalkagoal__1__0_models.AgoalEntityCreateRequest,
    ) -> dingtalkagoal__1__0_models.AgoalEntityCreateResponse:
        """
        @summary 创建业务实体
        
        @param request: AgoalEntityCreateRequest
        @return: AgoalEntityCreateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.AgoalEntityCreateHeaders()
        return self.agoal_entity_create_with_options(request, headers, runtime)

    async def agoal_entity_create_async(
        self,
        request: dingtalkagoal__1__0_models.AgoalEntityCreateRequest,
    ) -> dingtalkagoal__1__0_models.AgoalEntityCreateResponse:
        """
        @summary 创建业务实体
        
        @param request: AgoalEntityCreateRequest
        @return: AgoalEntityCreateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.AgoalEntityCreateHeaders()
        return await self.agoal_entity_create_with_options_async(request, headers, runtime)

    def agoal_entity_update_with_options(
        self,
        request: dingtalkagoal__1__0_models.AgoalEntityUpdateRequest,
        headers: dingtalkagoal__1__0_models.AgoalEntityUpdateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.AgoalEntityUpdateResponse:
        """
        @summary 更新业务实体
        
        @param request: AgoalEntityUpdateRequest
        @param headers: AgoalEntityUpdateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AgoalEntityUpdateResponse
        """
        UtilClient.validate_model(request)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=UtilClient.to_array(request.body)
        )
        params = open_api_models.Params(
            action='AgoalEntityUpdate',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/entities',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.AgoalEntityUpdateResponse(),
            self.execute(params, req, runtime)
        )

    async def agoal_entity_update_with_options_async(
        self,
        request: dingtalkagoal__1__0_models.AgoalEntityUpdateRequest,
        headers: dingtalkagoal__1__0_models.AgoalEntityUpdateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.AgoalEntityUpdateResponse:
        """
        @summary 更新业务实体
        
        @param request: AgoalEntityUpdateRequest
        @param headers: AgoalEntityUpdateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AgoalEntityUpdateResponse
        """
        UtilClient.validate_model(request)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=UtilClient.to_array(request.body)
        )
        params = open_api_models.Params(
            action='AgoalEntityUpdate',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/entities',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.AgoalEntityUpdateResponse(),
            await self.execute_async(params, req, runtime)
        )

    def agoal_entity_update(
        self,
        request: dingtalkagoal__1__0_models.AgoalEntityUpdateRequest,
    ) -> dingtalkagoal__1__0_models.AgoalEntityUpdateResponse:
        """
        @summary 更新业务实体
        
        @param request: AgoalEntityUpdateRequest
        @return: AgoalEntityUpdateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.AgoalEntityUpdateHeaders()
        return self.agoal_entity_update_with_options(request, headers, runtime)

    async def agoal_entity_update_async(
        self,
        request: dingtalkagoal__1__0_models.AgoalEntityUpdateRequest,
    ) -> dingtalkagoal__1__0_models.AgoalEntityUpdateResponse:
        """
        @summary 更新业务实体
        
        @param request: AgoalEntityUpdateRequest
        @return: AgoalEntityUpdateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.AgoalEntityUpdateHeaders()
        return await self.agoal_entity_update_with_options_async(request, headers, runtime)

    def agoal_field_update_with_options(
        self,
        tmp_req: dingtalkagoal__1__0_models.AgoalFieldUpdateRequest,
        headers: dingtalkagoal__1__0_models.AgoalFieldUpdateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.AgoalFieldUpdateResponse:
        """
        @summary 更新 Agoal 字段值
        
        @param tmp_req: AgoalFieldUpdateRequest
        @param headers: AgoalFieldUpdateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AgoalFieldUpdateResponse
        """
        UtilClient.validate_model(tmp_req)
        request = dingtalkagoal__1__0_models.AgoalFieldUpdateShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.body):
            request.body_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.body, 'body', 'json')
        query = {}
        if not UtilClient.is_unset(request.body_shrink):
            query['body'] = request.body_shrink
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
            action='AgoalFieldUpdate',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/fields',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.AgoalFieldUpdateResponse(),
            self.execute(params, req, runtime)
        )

    async def agoal_field_update_with_options_async(
        self,
        tmp_req: dingtalkagoal__1__0_models.AgoalFieldUpdateRequest,
        headers: dingtalkagoal__1__0_models.AgoalFieldUpdateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.AgoalFieldUpdateResponse:
        """
        @summary 更新 Agoal 字段值
        
        @param tmp_req: AgoalFieldUpdateRequest
        @param headers: AgoalFieldUpdateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AgoalFieldUpdateResponse
        """
        UtilClient.validate_model(tmp_req)
        request = dingtalkagoal__1__0_models.AgoalFieldUpdateShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.body):
            request.body_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.body, 'body', 'json')
        query = {}
        if not UtilClient.is_unset(request.body_shrink):
            query['body'] = request.body_shrink
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
            action='AgoalFieldUpdate',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/fields',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.AgoalFieldUpdateResponse(),
            await self.execute_async(params, req, runtime)
        )

    def agoal_field_update(
        self,
        request: dingtalkagoal__1__0_models.AgoalFieldUpdateRequest,
    ) -> dingtalkagoal__1__0_models.AgoalFieldUpdateResponse:
        """
        @summary 更新 Agoal 字段值
        
        @param request: AgoalFieldUpdateRequest
        @return: AgoalFieldUpdateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.AgoalFieldUpdateHeaders()
        return self.agoal_field_update_with_options(request, headers, runtime)

    async def agoal_field_update_async(
        self,
        request: dingtalkagoal__1__0_models.AgoalFieldUpdateRequest,
    ) -> dingtalkagoal__1__0_models.AgoalFieldUpdateResponse:
        """
        @summary 更新 Agoal 字段值
        
        @param request: AgoalFieldUpdateRequest
        @return: AgoalFieldUpdateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.AgoalFieldUpdateHeaders()
        return await self.agoal_field_update_with_options_async(request, headers, runtime)

    def agoal_indicator_batch_query_with_options(
        self,
        tmp_req: dingtalkagoal__1__0_models.AgoalIndicatorBatchQueryRequest,
        headers: dingtalkagoal__1__0_models.AgoalIndicatorBatchQueryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.AgoalIndicatorBatchQueryResponse:
        """
        @summary 通过指标编码批量查询指标列表
        
        @param tmp_req: AgoalIndicatorBatchQueryRequest
        @param headers: AgoalIndicatorBatchQueryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AgoalIndicatorBatchQueryResponse
        """
        UtilClient.validate_model(tmp_req)
        request = dingtalkagoal__1__0_models.AgoalIndicatorBatchQueryShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.code_list):
            request.code_list_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.code_list, 'codeList', 'json')
        query = {}
        if not UtilClient.is_unset(request.code_list_shrink):
            query['codeList'] = request.code_list_shrink
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
            action='AgoalIndicatorBatchQuery',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/indicator/batch/query',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.AgoalIndicatorBatchQueryResponse(),
            self.execute(params, req, runtime)
        )

    async def agoal_indicator_batch_query_with_options_async(
        self,
        tmp_req: dingtalkagoal__1__0_models.AgoalIndicatorBatchQueryRequest,
        headers: dingtalkagoal__1__0_models.AgoalIndicatorBatchQueryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.AgoalIndicatorBatchQueryResponse:
        """
        @summary 通过指标编码批量查询指标列表
        
        @param tmp_req: AgoalIndicatorBatchQueryRequest
        @param headers: AgoalIndicatorBatchQueryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AgoalIndicatorBatchQueryResponse
        """
        UtilClient.validate_model(tmp_req)
        request = dingtalkagoal__1__0_models.AgoalIndicatorBatchQueryShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.code_list):
            request.code_list_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.code_list, 'codeList', 'json')
        query = {}
        if not UtilClient.is_unset(request.code_list_shrink):
            query['codeList'] = request.code_list_shrink
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
            action='AgoalIndicatorBatchQuery',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/indicator/batch/query',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.AgoalIndicatorBatchQueryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def agoal_indicator_batch_query(
        self,
        request: dingtalkagoal__1__0_models.AgoalIndicatorBatchQueryRequest,
    ) -> dingtalkagoal__1__0_models.AgoalIndicatorBatchQueryResponse:
        """
        @summary 通过指标编码批量查询指标列表
        
        @param request: AgoalIndicatorBatchQueryRequest
        @return: AgoalIndicatorBatchQueryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.AgoalIndicatorBatchQueryHeaders()
        return self.agoal_indicator_batch_query_with_options(request, headers, runtime)

    async def agoal_indicator_batch_query_async(
        self,
        request: dingtalkagoal__1__0_models.AgoalIndicatorBatchQueryRequest,
    ) -> dingtalkagoal__1__0_models.AgoalIndicatorBatchQueryResponse:
        """
        @summary 通过指标编码批量查询指标列表
        
        @param request: AgoalIndicatorBatchQueryRequest
        @return: AgoalIndicatorBatchQueryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.AgoalIndicatorBatchQueryHeaders()
        return await self.agoal_indicator_batch_query_with_options_async(request, headers, runtime)

    def agoal_indicator_data_push_with_options(
        self,
        request: dingtalkagoal__1__0_models.AgoalIndicatorDataPushRequest,
        headers: dingtalkagoal__1__0_models.AgoalIndicatorDataPushHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.AgoalIndicatorDataPushResponse:
        """
        @summary 通过指标编码推送指标时间维度数据
        
        @param request: AgoalIndicatorDataPushRequest
        @param headers: AgoalIndicatorDataPushHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AgoalIndicatorDataPushResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.code):
            body['code'] = request.code
        if not UtilClient.is_unset(request.data):
            body['data'] = request.data
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
            action='AgoalIndicatorDataPush',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/indicator/data/push',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.AgoalIndicatorDataPushResponse(),
            self.execute(params, req, runtime)
        )

    async def agoal_indicator_data_push_with_options_async(
        self,
        request: dingtalkagoal__1__0_models.AgoalIndicatorDataPushRequest,
        headers: dingtalkagoal__1__0_models.AgoalIndicatorDataPushHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.AgoalIndicatorDataPushResponse:
        """
        @summary 通过指标编码推送指标时间维度数据
        
        @param request: AgoalIndicatorDataPushRequest
        @param headers: AgoalIndicatorDataPushHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AgoalIndicatorDataPushResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.code):
            body['code'] = request.code
        if not UtilClient.is_unset(request.data):
            body['data'] = request.data
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
            action='AgoalIndicatorDataPush',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/indicator/data/push',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.AgoalIndicatorDataPushResponse(),
            await self.execute_async(params, req, runtime)
        )

    def agoal_indicator_data_push(
        self,
        request: dingtalkagoal__1__0_models.AgoalIndicatorDataPushRequest,
    ) -> dingtalkagoal__1__0_models.AgoalIndicatorDataPushResponse:
        """
        @summary 通过指标编码推送指标时间维度数据
        
        @param request: AgoalIndicatorDataPushRequest
        @return: AgoalIndicatorDataPushResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.AgoalIndicatorDataPushHeaders()
        return self.agoal_indicator_data_push_with_options(request, headers, runtime)

    async def agoal_indicator_data_push_async(
        self,
        request: dingtalkagoal__1__0_models.AgoalIndicatorDataPushRequest,
    ) -> dingtalkagoal__1__0_models.AgoalIndicatorDataPushResponse:
        """
        @summary 通过指标编码推送指标时间维度数据
        
        @param request: AgoalIndicatorDataPushRequest
        @return: AgoalIndicatorDataPushResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.AgoalIndicatorDataPushHeaders()
        return await self.agoal_indicator_data_push_with_options_async(request, headers, runtime)

    def agoal_objective_key_action_list_with_options(
        self,
        request: dingtalkagoal__1__0_models.AgoalObjectiveKeyActionListRequest,
        headers: dingtalkagoal__1__0_models.AgoalObjectiveKeyActionListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.AgoalObjectiveKeyActionListResponse:
        """
        @summary 获取Agoal指定目标或者关键结果关联的关键行动
        
        @param request: AgoalObjectiveKeyActionListRequest
        @param headers: AgoalObjectiveKeyActionListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AgoalObjectiveKeyActionListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.ding_user_id):
            query['dingUserId'] = request.ding_user_id
        if not UtilClient.is_unset(request.key_result_id):
            query['keyResultId'] = request.key_result_id
        if not UtilClient.is_unset(request.objective_id):
            query['objectiveId'] = request.objective_id
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
            action='AgoalObjectiveKeyActionList',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/objectives/keyActionLists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.AgoalObjectiveKeyActionListResponse(),
            self.execute(params, req, runtime)
        )

    async def agoal_objective_key_action_list_with_options_async(
        self,
        request: dingtalkagoal__1__0_models.AgoalObjectiveKeyActionListRequest,
        headers: dingtalkagoal__1__0_models.AgoalObjectiveKeyActionListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.AgoalObjectiveKeyActionListResponse:
        """
        @summary 获取Agoal指定目标或者关键结果关联的关键行动
        
        @param request: AgoalObjectiveKeyActionListRequest
        @param headers: AgoalObjectiveKeyActionListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AgoalObjectiveKeyActionListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.ding_user_id):
            query['dingUserId'] = request.ding_user_id
        if not UtilClient.is_unset(request.key_result_id):
            query['keyResultId'] = request.key_result_id
        if not UtilClient.is_unset(request.objective_id):
            query['objectiveId'] = request.objective_id
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
            action='AgoalObjectiveKeyActionList',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/objectives/keyActionLists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.AgoalObjectiveKeyActionListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def agoal_objective_key_action_list(
        self,
        request: dingtalkagoal__1__0_models.AgoalObjectiveKeyActionListRequest,
    ) -> dingtalkagoal__1__0_models.AgoalObjectiveKeyActionListResponse:
        """
        @summary 获取Agoal指定目标或者关键结果关联的关键行动
        
        @param request: AgoalObjectiveKeyActionListRequest
        @return: AgoalObjectiveKeyActionListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.AgoalObjectiveKeyActionListHeaders()
        return self.agoal_objective_key_action_list_with_options(request, headers, runtime)

    async def agoal_objective_key_action_list_async(
        self,
        request: dingtalkagoal__1__0_models.AgoalObjectiveKeyActionListRequest,
    ) -> dingtalkagoal__1__0_models.AgoalObjectiveKeyActionListResponse:
        """
        @summary 获取Agoal指定目标或者关键结果关联的关键行动
        
        @param request: AgoalObjectiveKeyActionListRequest
        @return: AgoalObjectiveKeyActionListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.AgoalObjectiveKeyActionListHeaders()
        return await self.agoal_objective_key_action_list_with_options_async(request, headers, runtime)

    def agoal_objective_progress_list_with_options(
        self,
        request: dingtalkagoal__1__0_models.AgoalObjectiveProgressListRequest,
        headers: dingtalkagoal__1__0_models.AgoalObjectiveProgressListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.AgoalObjectiveProgressListResponse:
        """
        @summary 查询企业下指定个人目标的所有进展
        
        @param request: AgoalObjectiveProgressListRequest
        @param headers: AgoalObjectiveProgressListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AgoalObjectiveProgressListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.objective_id):
            query['objectiveId'] = request.objective_id
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
            action='AgoalObjectiveProgressList',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/objectives/progresses/lists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.AgoalObjectiveProgressListResponse(),
            self.execute(params, req, runtime)
        )

    async def agoal_objective_progress_list_with_options_async(
        self,
        request: dingtalkagoal__1__0_models.AgoalObjectiveProgressListRequest,
        headers: dingtalkagoal__1__0_models.AgoalObjectiveProgressListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.AgoalObjectiveProgressListResponse:
        """
        @summary 查询企业下指定个人目标的所有进展
        
        @param request: AgoalObjectiveProgressListRequest
        @param headers: AgoalObjectiveProgressListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AgoalObjectiveProgressListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.objective_id):
            query['objectiveId'] = request.objective_id
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
            action='AgoalObjectiveProgressList',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/objectives/progresses/lists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.AgoalObjectiveProgressListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def agoal_objective_progress_list(
        self,
        request: dingtalkagoal__1__0_models.AgoalObjectiveProgressListRequest,
    ) -> dingtalkagoal__1__0_models.AgoalObjectiveProgressListResponse:
        """
        @summary 查询企业下指定个人目标的所有进展
        
        @param request: AgoalObjectiveProgressListRequest
        @return: AgoalObjectiveProgressListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.AgoalObjectiveProgressListHeaders()
        return self.agoal_objective_progress_list_with_options(request, headers, runtime)

    async def agoal_objective_progress_list_async(
        self,
        request: dingtalkagoal__1__0_models.AgoalObjectiveProgressListRequest,
    ) -> dingtalkagoal__1__0_models.AgoalObjectiveProgressListResponse:
        """
        @summary 查询企业下指定个人目标的所有进展
        
        @param request: AgoalObjectiveProgressListRequest
        @return: AgoalObjectiveProgressListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.AgoalObjectiveProgressListHeaders()
        return await self.agoal_objective_progress_list_with_options_async(request, headers, runtime)

    def agoal_objective_rule_list_with_options(
        self,
        request: dingtalkagoal__1__0_models.AgoalObjectiveRuleListRequest,
        headers: dingtalkagoal__1__0_models.AgoalObjectiveRuleListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.AgoalObjectiveRuleListResponse:
        """
        @summary 查询企业下目标规则列表
        
        @param request: AgoalObjectiveRuleListRequest
        @param headers: AgoalObjectiveRuleListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AgoalObjectiveRuleListResponse
        """
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
        params = open_api_models.Params(
            action='AgoalObjectiveRuleList',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/objectiveRuleLists/query',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.AgoalObjectiveRuleListResponse(),
            self.execute(params, req, runtime)
        )

    async def agoal_objective_rule_list_with_options_async(
        self,
        request: dingtalkagoal__1__0_models.AgoalObjectiveRuleListRequest,
        headers: dingtalkagoal__1__0_models.AgoalObjectiveRuleListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.AgoalObjectiveRuleListResponse:
        """
        @summary 查询企业下目标规则列表
        
        @param request: AgoalObjectiveRuleListRequest
        @param headers: AgoalObjectiveRuleListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AgoalObjectiveRuleListResponse
        """
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
        params = open_api_models.Params(
            action='AgoalObjectiveRuleList',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/objectiveRuleLists/query',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.AgoalObjectiveRuleListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def agoal_objective_rule_list(
        self,
        request: dingtalkagoal__1__0_models.AgoalObjectiveRuleListRequest,
    ) -> dingtalkagoal__1__0_models.AgoalObjectiveRuleListResponse:
        """
        @summary 查询企业下目标规则列表
        
        @param request: AgoalObjectiveRuleListRequest
        @return: AgoalObjectiveRuleListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.AgoalObjectiveRuleListHeaders()
        return self.agoal_objective_rule_list_with_options(request, headers, runtime)

    async def agoal_objective_rule_list_async(
        self,
        request: dingtalkagoal__1__0_models.AgoalObjectiveRuleListRequest,
    ) -> dingtalkagoal__1__0_models.AgoalObjectiveRuleListResponse:
        """
        @summary 查询企业下目标规则列表
        
        @param request: AgoalObjectiveRuleListRequest
        @return: AgoalObjectiveRuleListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.AgoalObjectiveRuleListHeaders()
        return await self.agoal_objective_rule_list_with_options_async(request, headers, runtime)

    def agoal_objective_rule_period_list_with_options(
        self,
        request: dingtalkagoal__1__0_models.AgoalObjectiveRulePeriodListRequest,
        headers: dingtalkagoal__1__0_models.AgoalObjectiveRulePeriodListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.AgoalObjectiveRulePeriodListResponse:
        """
        @summary 获取Agoal目标规则下的周期列表
        
        @param request: AgoalObjectiveRulePeriodListRequest
        @param headers: AgoalObjectiveRulePeriodListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AgoalObjectiveRulePeriodListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.objective_rule_id):
            query['objectiveRuleId'] = request.objective_rule_id
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
            action='AgoalObjectiveRulePeriodList',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/objectiveRules/periodLists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.AgoalObjectiveRulePeriodListResponse(),
            self.execute(params, req, runtime)
        )

    async def agoal_objective_rule_period_list_with_options_async(
        self,
        request: dingtalkagoal__1__0_models.AgoalObjectiveRulePeriodListRequest,
        headers: dingtalkagoal__1__0_models.AgoalObjectiveRulePeriodListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.AgoalObjectiveRulePeriodListResponse:
        """
        @summary 获取Agoal目标规则下的周期列表
        
        @param request: AgoalObjectiveRulePeriodListRequest
        @param headers: AgoalObjectiveRulePeriodListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AgoalObjectiveRulePeriodListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.objective_rule_id):
            query['objectiveRuleId'] = request.objective_rule_id
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
            action='AgoalObjectiveRulePeriodList',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/objectiveRules/periodLists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.AgoalObjectiveRulePeriodListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def agoal_objective_rule_period_list(
        self,
        request: dingtalkagoal__1__0_models.AgoalObjectiveRulePeriodListRequest,
    ) -> dingtalkagoal__1__0_models.AgoalObjectiveRulePeriodListResponse:
        """
        @summary 获取Agoal目标规则下的周期列表
        
        @param request: AgoalObjectiveRulePeriodListRequest
        @return: AgoalObjectiveRulePeriodListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.AgoalObjectiveRulePeriodListHeaders()
        return self.agoal_objective_rule_period_list_with_options(request, headers, runtime)

    async def agoal_objective_rule_period_list_async(
        self,
        request: dingtalkagoal__1__0_models.AgoalObjectiveRulePeriodListRequest,
    ) -> dingtalkagoal__1__0_models.AgoalObjectiveRulePeriodListResponse:
        """
        @summary 获取Agoal目标规则下的周期列表
        
        @param request: AgoalObjectiveRulePeriodListRequest
        @return: AgoalObjectiveRulePeriodListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.AgoalObjectiveRulePeriodListHeaders()
        return await self.agoal_objective_rule_period_list_with_options_async(request, headers, runtime)

    def agoal_org_objective_list_with_options(
        self,
        request: dingtalkagoal__1__0_models.AgoalOrgObjectiveListRequest,
        headers: dingtalkagoal__1__0_models.AgoalOrgObjectiveListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.AgoalOrgObjectiveListResponse:
        """
        @summary 获取 Agoal 组织目标列表
        
        @param request: AgoalOrgObjectiveListRequest
        @param headers: AgoalOrgObjectiveListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AgoalOrgObjectiveListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.ding_team_id):
            query['dingTeamId'] = request.ding_team_id
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.period_id):
            query['periodId'] = request.period_id
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
            action='AgoalOrgObjectiveList',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/orgObjectives/list',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.AgoalOrgObjectiveListResponse(),
            self.execute(params, req, runtime)
        )

    async def agoal_org_objective_list_with_options_async(
        self,
        request: dingtalkagoal__1__0_models.AgoalOrgObjectiveListRequest,
        headers: dingtalkagoal__1__0_models.AgoalOrgObjectiveListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.AgoalOrgObjectiveListResponse:
        """
        @summary 获取 Agoal 组织目标列表
        
        @param request: AgoalOrgObjectiveListRequest
        @param headers: AgoalOrgObjectiveListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AgoalOrgObjectiveListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.ding_team_id):
            query['dingTeamId'] = request.ding_team_id
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.period_id):
            query['periodId'] = request.period_id
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
            action='AgoalOrgObjectiveList',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/orgObjectives/list',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.AgoalOrgObjectiveListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def agoal_org_objective_list(
        self,
        request: dingtalkagoal__1__0_models.AgoalOrgObjectiveListRequest,
    ) -> dingtalkagoal__1__0_models.AgoalOrgObjectiveListResponse:
        """
        @summary 获取 Agoal 组织目标列表
        
        @param request: AgoalOrgObjectiveListRequest
        @return: AgoalOrgObjectiveListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.AgoalOrgObjectiveListHeaders()
        return self.agoal_org_objective_list_with_options(request, headers, runtime)

    async def agoal_org_objective_list_async(
        self,
        request: dingtalkagoal__1__0_models.AgoalOrgObjectiveListRequest,
    ) -> dingtalkagoal__1__0_models.AgoalOrgObjectiveListResponse:
        """
        @summary 获取 Agoal 组织目标列表
        
        @param request: AgoalOrgObjectiveListRequest
        @return: AgoalOrgObjectiveListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.AgoalOrgObjectiveListHeaders()
        return await self.agoal_org_objective_list_with_options_async(request, headers, runtime)

    def agoal_org_objective_query_with_options(
        self,
        request: dingtalkagoal__1__0_models.AgoalOrgObjectiveQueryRequest,
        headers: dingtalkagoal__1__0_models.AgoalOrgObjectiveQueryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.AgoalOrgObjectiveQueryResponse:
        """
        @summary 查询组织目标详情
        
        @param request: AgoalOrgObjectiveQueryRequest
        @param headers: AgoalOrgObjectiveQueryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AgoalOrgObjectiveQueryResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.objective_id):
            query['objectiveId'] = request.objective_id
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
            action='AgoalOrgObjectiveQuery',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/orgObjectives',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.AgoalOrgObjectiveQueryResponse(),
            self.execute(params, req, runtime)
        )

    async def agoal_org_objective_query_with_options_async(
        self,
        request: dingtalkagoal__1__0_models.AgoalOrgObjectiveQueryRequest,
        headers: dingtalkagoal__1__0_models.AgoalOrgObjectiveQueryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.AgoalOrgObjectiveQueryResponse:
        """
        @summary 查询组织目标详情
        
        @param request: AgoalOrgObjectiveQueryRequest
        @param headers: AgoalOrgObjectiveQueryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AgoalOrgObjectiveQueryResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.objective_id):
            query['objectiveId'] = request.objective_id
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
            action='AgoalOrgObjectiveQuery',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/orgObjectives',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.AgoalOrgObjectiveQueryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def agoal_org_objective_query(
        self,
        request: dingtalkagoal__1__0_models.AgoalOrgObjectiveQueryRequest,
    ) -> dingtalkagoal__1__0_models.AgoalOrgObjectiveQueryResponse:
        """
        @summary 查询组织目标详情
        
        @param request: AgoalOrgObjectiveQueryRequest
        @return: AgoalOrgObjectiveQueryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.AgoalOrgObjectiveQueryHeaders()
        return self.agoal_org_objective_query_with_options(request, headers, runtime)

    async def agoal_org_objective_query_async(
        self,
        request: dingtalkagoal__1__0_models.AgoalOrgObjectiveQueryRequest,
    ) -> dingtalkagoal__1__0_models.AgoalOrgObjectiveQueryResponse:
        """
        @summary 查询组织目标详情
        
        @param request: AgoalOrgObjectiveQueryRequest
        @return: AgoalOrgObjectiveQueryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.AgoalOrgObjectiveQueryHeaders()
        return await self.agoal_org_objective_query_with_options_async(request, headers, runtime)

    def agoal_org_objective_rule_list_with_options(
        self,
        headers: dingtalkagoal__1__0_models.AgoalOrgObjectiveRuleListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.AgoalOrgObjectiveRuleListResponse:
        """
        @summary 获取Agoal目标规则列表
        
        @param headers: AgoalOrgObjectiveRuleListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AgoalOrgObjectiveRuleListResponse
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
            action='AgoalOrgObjectiveRuleList',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/objectiveRules/lists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.AgoalOrgObjectiveRuleListResponse(),
            self.execute(params, req, runtime)
        )

    async def agoal_org_objective_rule_list_with_options_async(
        self,
        headers: dingtalkagoal__1__0_models.AgoalOrgObjectiveRuleListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.AgoalOrgObjectiveRuleListResponse:
        """
        @summary 获取Agoal目标规则列表
        
        @param headers: AgoalOrgObjectiveRuleListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AgoalOrgObjectiveRuleListResponse
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
            action='AgoalOrgObjectiveRuleList',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/objectiveRules/lists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.AgoalOrgObjectiveRuleListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def agoal_org_objective_rule_list(self) -> dingtalkagoal__1__0_models.AgoalOrgObjectiveRuleListResponse:
        """
        @summary 获取Agoal目标规则列表
        
        @return: AgoalOrgObjectiveRuleListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.AgoalOrgObjectiveRuleListHeaders()
        return self.agoal_org_objective_rule_list_with_options(headers, runtime)

    async def agoal_org_objective_rule_list_async(self) -> dingtalkagoal__1__0_models.AgoalOrgObjectiveRuleListResponse:
        """
        @summary 获取Agoal目标规则列表
        
        @return: AgoalOrgObjectiveRuleListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.AgoalOrgObjectiveRuleListHeaders()
        return await self.agoal_org_objective_rule_list_with_options_async(headers, runtime)

    def agoal_org_perf_doc_query_with_options(
        self,
        request: dingtalkagoal__1__0_models.AgoalOrgPerfDocQueryRequest,
        headers: dingtalkagoal__1__0_models.AgoalOrgPerfDocQueryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.AgoalOrgPerfDocQueryResponse:
        """
        @summary 查询某个考核计划的部门得分
        
        @param request: AgoalOrgPerfDocQueryRequest
        @param headers: AgoalOrgPerfDocQueryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AgoalOrgPerfDocQueryResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.plan_id):
            query['planId'] = request.plan_id
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
            action='AgoalOrgPerfDocQuery',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/org_perf/documents/query',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.AgoalOrgPerfDocQueryResponse(),
            self.execute(params, req, runtime)
        )

    async def agoal_org_perf_doc_query_with_options_async(
        self,
        request: dingtalkagoal__1__0_models.AgoalOrgPerfDocQueryRequest,
        headers: dingtalkagoal__1__0_models.AgoalOrgPerfDocQueryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.AgoalOrgPerfDocQueryResponse:
        """
        @summary 查询某个考核计划的部门得分
        
        @param request: AgoalOrgPerfDocQueryRequest
        @param headers: AgoalOrgPerfDocQueryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AgoalOrgPerfDocQueryResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.plan_id):
            query['planId'] = request.plan_id
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
            action='AgoalOrgPerfDocQuery',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/org_perf/documents/query',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.AgoalOrgPerfDocQueryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def agoal_org_perf_doc_query(
        self,
        request: dingtalkagoal__1__0_models.AgoalOrgPerfDocQueryRequest,
    ) -> dingtalkagoal__1__0_models.AgoalOrgPerfDocQueryResponse:
        """
        @summary 查询某个考核计划的部门得分
        
        @param request: AgoalOrgPerfDocQueryRequest
        @return: AgoalOrgPerfDocQueryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.AgoalOrgPerfDocQueryHeaders()
        return self.agoal_org_perf_doc_query_with_options(request, headers, runtime)

    async def agoal_org_perf_doc_query_async(
        self,
        request: dingtalkagoal__1__0_models.AgoalOrgPerfDocQueryRequest,
    ) -> dingtalkagoal__1__0_models.AgoalOrgPerfDocQueryResponse:
        """
        @summary 查询某个考核计划的部门得分
        
        @param request: AgoalOrgPerfDocQueryRequest
        @return: AgoalOrgPerfDocQueryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.AgoalOrgPerfDocQueryHeaders()
        return await self.agoal_org_perf_doc_query_with_options_async(request, headers, runtime)

    def agoal_org_perf_plan_query_with_options(
        self,
        request: dingtalkagoal__1__0_models.AgoalOrgPerfPlanQueryRequest,
        headers: dingtalkagoal__1__0_models.AgoalOrgPerfPlanQueryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.AgoalOrgPerfPlanQueryResponse:
        """
        @summary 查询企业下的所有考核计划
        
        @param request: AgoalOrgPerfPlanQueryRequest
        @param headers: AgoalOrgPerfPlanQueryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AgoalOrgPerfPlanQueryResponse
        """
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
        params = open_api_models.Params(
            action='AgoalOrgPerfPlanQuery',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/org_perf/plans/query',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.AgoalOrgPerfPlanQueryResponse(),
            self.execute(params, req, runtime)
        )

    async def agoal_org_perf_plan_query_with_options_async(
        self,
        request: dingtalkagoal__1__0_models.AgoalOrgPerfPlanQueryRequest,
        headers: dingtalkagoal__1__0_models.AgoalOrgPerfPlanQueryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.AgoalOrgPerfPlanQueryResponse:
        """
        @summary 查询企业下的所有考核计划
        
        @param request: AgoalOrgPerfPlanQueryRequest
        @param headers: AgoalOrgPerfPlanQueryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AgoalOrgPerfPlanQueryResponse
        """
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
        params = open_api_models.Params(
            action='AgoalOrgPerfPlanQuery',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/org_perf/plans/query',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.AgoalOrgPerfPlanQueryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def agoal_org_perf_plan_query(
        self,
        request: dingtalkagoal__1__0_models.AgoalOrgPerfPlanQueryRequest,
    ) -> dingtalkagoal__1__0_models.AgoalOrgPerfPlanQueryResponse:
        """
        @summary 查询企业下的所有考核计划
        
        @param request: AgoalOrgPerfPlanQueryRequest
        @return: AgoalOrgPerfPlanQueryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.AgoalOrgPerfPlanQueryHeaders()
        return self.agoal_org_perf_plan_query_with_options(request, headers, runtime)

    async def agoal_org_perf_plan_query_async(
        self,
        request: dingtalkagoal__1__0_models.AgoalOrgPerfPlanQueryRequest,
    ) -> dingtalkagoal__1__0_models.AgoalOrgPerfPlanQueryResponse:
        """
        @summary 查询企业下的所有考核计划
        
        @param request: AgoalOrgPerfPlanQueryRequest
        @return: AgoalOrgPerfPlanQueryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.AgoalOrgPerfPlanQueryHeaders()
        return await self.agoal_org_perf_plan_query_with_options_async(request, headers, runtime)

    def agoal_perf_task_create_with_options(
        self,
        request: dingtalkagoal__1__0_models.AgoalPerfTaskCreateRequest,
        headers: dingtalkagoal__1__0_models.AgoalPerfTaskCreateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.AgoalPerfTaskCreateResponse:
        """
        @summary 创建考核任务
        
        @param request: AgoalPerfTaskCreateRequest
        @param headers: AgoalPerfTaskCreateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AgoalPerfTaskCreateResponse
        """
        UtilClient.validate_model(request)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=UtilClient.to_array(request.body)
        )
        params = open_api_models.Params(
            action='AgoalPerfTaskCreate',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/perfTasks',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.AgoalPerfTaskCreateResponse(),
            self.execute(params, req, runtime)
        )

    async def agoal_perf_task_create_with_options_async(
        self,
        request: dingtalkagoal__1__0_models.AgoalPerfTaskCreateRequest,
        headers: dingtalkagoal__1__0_models.AgoalPerfTaskCreateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.AgoalPerfTaskCreateResponse:
        """
        @summary 创建考核任务
        
        @param request: AgoalPerfTaskCreateRequest
        @param headers: AgoalPerfTaskCreateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AgoalPerfTaskCreateResponse
        """
        UtilClient.validate_model(request)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=UtilClient.to_array(request.body)
        )
        params = open_api_models.Params(
            action='AgoalPerfTaskCreate',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/perfTasks',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.AgoalPerfTaskCreateResponse(),
            await self.execute_async(params, req, runtime)
        )

    def agoal_perf_task_create(
        self,
        request: dingtalkagoal__1__0_models.AgoalPerfTaskCreateRequest,
    ) -> dingtalkagoal__1__0_models.AgoalPerfTaskCreateResponse:
        """
        @summary 创建考核任务
        
        @param request: AgoalPerfTaskCreateRequest
        @return: AgoalPerfTaskCreateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.AgoalPerfTaskCreateHeaders()
        return self.agoal_perf_task_create_with_options(request, headers, runtime)

    async def agoal_perf_task_create_async(
        self,
        request: dingtalkagoal__1__0_models.AgoalPerfTaskCreateRequest,
    ) -> dingtalkagoal__1__0_models.AgoalPerfTaskCreateResponse:
        """
        @summary 创建考核任务
        
        @param request: AgoalPerfTaskCreateRequest
        @return: AgoalPerfTaskCreateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.AgoalPerfTaskCreateHeaders()
        return await self.agoal_perf_task_create_with_options_async(request, headers, runtime)

    def agoal_perf_task_update_with_options(
        self,
        request: dingtalkagoal__1__0_models.AgoalPerfTaskUpdateRequest,
        headers: dingtalkagoal__1__0_models.AgoalPerfTaskUpdateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.AgoalPerfTaskUpdateResponse:
        """
        @summary 更新考核任务
        
        @param request: AgoalPerfTaskUpdateRequest
        @param headers: AgoalPerfTaskUpdateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AgoalPerfTaskUpdateResponse
        """
        UtilClient.validate_model(request)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=UtilClient.to_array(request.body)
        )
        params = open_api_models.Params(
            action='AgoalPerfTaskUpdate',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/perfTasks',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.AgoalPerfTaskUpdateResponse(),
            self.execute(params, req, runtime)
        )

    async def agoal_perf_task_update_with_options_async(
        self,
        request: dingtalkagoal__1__0_models.AgoalPerfTaskUpdateRequest,
        headers: dingtalkagoal__1__0_models.AgoalPerfTaskUpdateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.AgoalPerfTaskUpdateResponse:
        """
        @summary 更新考核任务
        
        @param request: AgoalPerfTaskUpdateRequest
        @param headers: AgoalPerfTaskUpdateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AgoalPerfTaskUpdateResponse
        """
        UtilClient.validate_model(request)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=UtilClient.to_array(request.body)
        )
        params = open_api_models.Params(
            action='AgoalPerfTaskUpdate',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/perfTasks',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.AgoalPerfTaskUpdateResponse(),
            await self.execute_async(params, req, runtime)
        )

    def agoal_perf_task_update(
        self,
        request: dingtalkagoal__1__0_models.AgoalPerfTaskUpdateRequest,
    ) -> dingtalkagoal__1__0_models.AgoalPerfTaskUpdateResponse:
        """
        @summary 更新考核任务
        
        @param request: AgoalPerfTaskUpdateRequest
        @return: AgoalPerfTaskUpdateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.AgoalPerfTaskUpdateHeaders()
        return self.agoal_perf_task_update_with_options(request, headers, runtime)

    async def agoal_perf_task_update_async(
        self,
        request: dingtalkagoal__1__0_models.AgoalPerfTaskUpdateRequest,
    ) -> dingtalkagoal__1__0_models.AgoalPerfTaskUpdateResponse:
        """
        @summary 更新考核任务
        
        @param request: AgoalPerfTaskUpdateRequest
        @return: AgoalPerfTaskUpdateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.AgoalPerfTaskUpdateHeaders()
        return await self.agoal_perf_task_update_with_options_async(request, headers, runtime)

    def agoal_period_list_with_options(
        self,
        tmp_req: dingtalkagoal__1__0_models.AgoalPeriodListRequest,
        headers: dingtalkagoal__1__0_models.AgoalPeriodListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.AgoalPeriodListResponse:
        """
        @summary 获取 Agoal 周期列表
        
        @param tmp_req: AgoalPeriodListRequest
        @param headers: AgoalPeriodListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AgoalPeriodListResponse
        """
        UtilClient.validate_model(tmp_req)
        request = dingtalkagoal__1__0_models.AgoalPeriodListShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.body):
            request.body_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.body, 'body', 'json')
        query = {}
        if not UtilClient.is_unset(request.body_shrink):
            query['body'] = request.body_shrink
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
            action='AgoalPeriodList',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/periods/list',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.AgoalPeriodListResponse(),
            self.execute(params, req, runtime)
        )

    async def agoal_period_list_with_options_async(
        self,
        tmp_req: dingtalkagoal__1__0_models.AgoalPeriodListRequest,
        headers: dingtalkagoal__1__0_models.AgoalPeriodListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.AgoalPeriodListResponse:
        """
        @summary 获取 Agoal 周期列表
        
        @param tmp_req: AgoalPeriodListRequest
        @param headers: AgoalPeriodListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AgoalPeriodListResponse
        """
        UtilClient.validate_model(tmp_req)
        request = dingtalkagoal__1__0_models.AgoalPeriodListShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.body):
            request.body_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.body, 'body', 'json')
        query = {}
        if not UtilClient.is_unset(request.body_shrink):
            query['body'] = request.body_shrink
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
            action='AgoalPeriodList',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/periods/list',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.AgoalPeriodListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def agoal_period_list(
        self,
        request: dingtalkagoal__1__0_models.AgoalPeriodListRequest,
    ) -> dingtalkagoal__1__0_models.AgoalPeriodListResponse:
        """
        @summary 获取 Agoal 周期列表
        
        @param request: AgoalPeriodListRequest
        @return: AgoalPeriodListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.AgoalPeriodListHeaders()
        return self.agoal_period_list_with_options(request, headers, runtime)

    async def agoal_period_list_async(
        self,
        request: dingtalkagoal__1__0_models.AgoalPeriodListRequest,
    ) -> dingtalkagoal__1__0_models.AgoalPeriodListResponse:
        """
        @summary 获取 Agoal 周期列表
        
        @param request: AgoalPeriodListRequest
        @return: AgoalPeriodListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.AgoalPeriodListHeaders()
        return await self.agoal_period_list_with_options_async(request, headers, runtime)

    def agoal_send_message_with_options(
        self,
        request: dingtalkagoal__1__0_models.AgoalSendMessageRequest,
        headers: dingtalkagoal__1__0_models.AgoalSendMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.AgoalSendMessageResponse:
        """
        @summary Agoal消息发送
        
        @param request: AgoalSendMessageRequest
        @param headers: AgoalSendMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AgoalSendMessageResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.mobile_url):
            body['mobileUrl'] = request.mobile_url
        if not UtilClient.is_unset(request.params):
            body['params'] = request.params
        if not UtilClient.is_unset(request.pc_url):
            body['pcUrl'] = request.pc_url
        if not UtilClient.is_unset(request.source_ding_user_id):
            body['sourceDingUserId'] = request.source_ding_user_id
        if not UtilClient.is_unset(request.target_ding_user_ids):
            body['targetDingUserIds'] = request.target_ding_user_ids
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
            action='AgoalSendMessage',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/messages/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.AgoalSendMessageResponse(),
            self.execute(params, req, runtime)
        )

    async def agoal_send_message_with_options_async(
        self,
        request: dingtalkagoal__1__0_models.AgoalSendMessageRequest,
        headers: dingtalkagoal__1__0_models.AgoalSendMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.AgoalSendMessageResponse:
        """
        @summary Agoal消息发送
        
        @param request: AgoalSendMessageRequest
        @param headers: AgoalSendMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AgoalSendMessageResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.mobile_url):
            body['mobileUrl'] = request.mobile_url
        if not UtilClient.is_unset(request.params):
            body['params'] = request.params
        if not UtilClient.is_unset(request.pc_url):
            body['pcUrl'] = request.pc_url
        if not UtilClient.is_unset(request.source_ding_user_id):
            body['sourceDingUserId'] = request.source_ding_user_id
        if not UtilClient.is_unset(request.target_ding_user_ids):
            body['targetDingUserIds'] = request.target_ding_user_ids
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
            action='AgoalSendMessage',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/messages/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.AgoalSendMessageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def agoal_send_message(
        self,
        request: dingtalkagoal__1__0_models.AgoalSendMessageRequest,
    ) -> dingtalkagoal__1__0_models.AgoalSendMessageResponse:
        """
        @summary Agoal消息发送
        
        @param request: AgoalSendMessageRequest
        @return: AgoalSendMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.AgoalSendMessageHeaders()
        return self.agoal_send_message_with_options(request, headers, runtime)

    async def agoal_send_message_async(
        self,
        request: dingtalkagoal__1__0_models.AgoalSendMessageRequest,
    ) -> dingtalkagoal__1__0_models.AgoalSendMessageResponse:
        """
        @summary Agoal消息发送
        
        @param request: AgoalSendMessageRequest
        @return: AgoalSendMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.AgoalSendMessageHeaders()
        return await self.agoal_send_message_with_options_async(request, headers, runtime)

    def agoal_user_admin_list_with_options(
        self,
        headers: dingtalkagoal__1__0_models.AgoalUserAdminListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.AgoalUserAdminListResponse:
        """
        @summary 获取Agoal管理员列表
        
        @param headers: AgoalUserAdminListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AgoalUserAdminListResponse
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
            action='AgoalUserAdminList',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/administrators/lists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.AgoalUserAdminListResponse(),
            self.execute(params, req, runtime)
        )

    async def agoal_user_admin_list_with_options_async(
        self,
        headers: dingtalkagoal__1__0_models.AgoalUserAdminListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.AgoalUserAdminListResponse:
        """
        @summary 获取Agoal管理员列表
        
        @param headers: AgoalUserAdminListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AgoalUserAdminListResponse
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
            action='AgoalUserAdminList',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/administrators/lists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.AgoalUserAdminListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def agoal_user_admin_list(self) -> dingtalkagoal__1__0_models.AgoalUserAdminListResponse:
        """
        @summary 获取Agoal管理员列表
        
        @return: AgoalUserAdminListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.AgoalUserAdminListHeaders()
        return self.agoal_user_admin_list_with_options(headers, runtime)

    async def agoal_user_admin_list_async(self) -> dingtalkagoal__1__0_models.AgoalUserAdminListResponse:
        """
        @summary 获取Agoal管理员列表
        
        @return: AgoalUserAdminListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.AgoalUserAdminListHeaders()
        return await self.agoal_user_admin_list_with_options_async(headers, runtime)

    def agoal_user_objective_list_with_options(
        self,
        request: dingtalkagoal__1__0_models.AgoalUserObjectiveListRequest,
        headers: dingtalkagoal__1__0_models.AgoalUserObjectiveListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.AgoalUserObjectiveListResponse:
        """
        @summary Agoal用户目标列表
        
        @param request: AgoalUserObjectiveListRequest
        @param headers: AgoalUserObjectiveListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AgoalUserObjectiveListResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.ding_user_id):
            body['dingUserId'] = request.ding_user_id
        if not UtilClient.is_unset(request.objective_rule_id):
            body['objectiveRuleId'] = request.objective_rule_id
        if not UtilClient.is_unset(request.period_ids):
            body['periodIds'] = request.period_ids
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
            action='AgoalUserObjectiveList',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/users/objectiveLists/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.AgoalUserObjectiveListResponse(),
            self.execute(params, req, runtime)
        )

    async def agoal_user_objective_list_with_options_async(
        self,
        request: dingtalkagoal__1__0_models.AgoalUserObjectiveListRequest,
        headers: dingtalkagoal__1__0_models.AgoalUserObjectiveListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.AgoalUserObjectiveListResponse:
        """
        @summary Agoal用户目标列表
        
        @param request: AgoalUserObjectiveListRequest
        @param headers: AgoalUserObjectiveListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AgoalUserObjectiveListResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.ding_user_id):
            body['dingUserId'] = request.ding_user_id
        if not UtilClient.is_unset(request.objective_rule_id):
            body['objectiveRuleId'] = request.objective_rule_id
        if not UtilClient.is_unset(request.period_ids):
            body['periodIds'] = request.period_ids
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
            action='AgoalUserObjectiveList',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/users/objectiveLists/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.AgoalUserObjectiveListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def agoal_user_objective_list(
        self,
        request: dingtalkagoal__1__0_models.AgoalUserObjectiveListRequest,
    ) -> dingtalkagoal__1__0_models.AgoalUserObjectiveListResponse:
        """
        @summary Agoal用户目标列表
        
        @param request: AgoalUserObjectiveListRequest
        @return: AgoalUserObjectiveListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.AgoalUserObjectiveListHeaders()
        return self.agoal_user_objective_list_with_options(request, headers, runtime)

    async def agoal_user_objective_list_async(
        self,
        request: dingtalkagoal__1__0_models.AgoalUserObjectiveListRequest,
    ) -> dingtalkagoal__1__0_models.AgoalUserObjectiveListResponse:
        """
        @summary Agoal用户目标列表
        
        @param request: AgoalUserObjectiveListRequest
        @return: AgoalUserObjectiveListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.AgoalUserObjectiveListHeaders()
        return await self.agoal_user_objective_list_with_options_async(request, headers, runtime)

    def agoal_user_sub_admin_list_with_options(
        self,
        request: dingtalkagoal__1__0_models.AgoalUserSubAdminListRequest,
        headers: dingtalkagoal__1__0_models.AgoalUserSubAdminListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.AgoalUserSubAdminListResponse:
        """
        @summary 获取Agoal子管理员列表
        
        @param request: AgoalUserSubAdminListRequest
        @param headers: AgoalUserSubAdminListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AgoalUserSubAdminListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.func_permission_group):
            query['funcPermissionGroup'] = request.func_permission_group
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
            action='AgoalUserSubAdminList',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/administrators/sub/lists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.AgoalUserSubAdminListResponse(),
            self.execute(params, req, runtime)
        )

    async def agoal_user_sub_admin_list_with_options_async(
        self,
        request: dingtalkagoal__1__0_models.AgoalUserSubAdminListRequest,
        headers: dingtalkagoal__1__0_models.AgoalUserSubAdminListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.AgoalUserSubAdminListResponse:
        """
        @summary 获取Agoal子管理员列表
        
        @param request: AgoalUserSubAdminListRequest
        @param headers: AgoalUserSubAdminListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AgoalUserSubAdminListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.func_permission_group):
            query['funcPermissionGroup'] = request.func_permission_group
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
            action='AgoalUserSubAdminList',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/administrators/sub/lists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.AgoalUserSubAdminListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def agoal_user_sub_admin_list(
        self,
        request: dingtalkagoal__1__0_models.AgoalUserSubAdminListRequest,
    ) -> dingtalkagoal__1__0_models.AgoalUserSubAdminListResponse:
        """
        @summary 获取Agoal子管理员列表
        
        @param request: AgoalUserSubAdminListRequest
        @return: AgoalUserSubAdminListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.AgoalUserSubAdminListHeaders()
        return self.agoal_user_sub_admin_list_with_options(request, headers, runtime)

    async def agoal_user_sub_admin_list_async(
        self,
        request: dingtalkagoal__1__0_models.AgoalUserSubAdminListRequest,
    ) -> dingtalkagoal__1__0_models.AgoalUserSubAdminListResponse:
        """
        @summary 获取Agoal子管理员列表
        
        @param request: AgoalUserSubAdminListRequest
        @return: AgoalUserSubAdminListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.AgoalUserSubAdminListHeaders()
        return await self.agoal_user_sub_admin_list_with_options_async(request, headers, runtime)

    def get_dept_score_card_indicator_with_options(
        self,
        request: dingtalkagoal__1__0_models.GetDeptScoreCardIndicatorRequest,
        headers: dingtalkagoal__1__0_models.GetDeptScoreCardIndicatorHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.GetDeptScoreCardIndicatorResponse:
        """
        @summary 获取部门下的维度和指标id
        
        @param request: GetDeptScoreCardIndicatorRequest
        @param headers: GetDeptScoreCardIndicatorHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetDeptScoreCardIndicatorResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.ding_team_id):
            query['dingTeamId'] = request.ding_team_id
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
            action='GetDeptScoreCardIndicator',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/scorecards/departments/indicators',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.GetDeptScoreCardIndicatorResponse(),
            self.execute(params, req, runtime)
        )

    async def get_dept_score_card_indicator_with_options_async(
        self,
        request: dingtalkagoal__1__0_models.GetDeptScoreCardIndicatorRequest,
        headers: dingtalkagoal__1__0_models.GetDeptScoreCardIndicatorHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.GetDeptScoreCardIndicatorResponse:
        """
        @summary 获取部门下的维度和指标id
        
        @param request: GetDeptScoreCardIndicatorRequest
        @param headers: GetDeptScoreCardIndicatorHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetDeptScoreCardIndicatorResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.ding_team_id):
            query['dingTeamId'] = request.ding_team_id
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
            action='GetDeptScoreCardIndicator',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/scorecards/departments/indicators',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.GetDeptScoreCardIndicatorResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_dept_score_card_indicator(
        self,
        request: dingtalkagoal__1__0_models.GetDeptScoreCardIndicatorRequest,
    ) -> dingtalkagoal__1__0_models.GetDeptScoreCardIndicatorResponse:
        """
        @summary 获取部门下的维度和指标id
        
        @param request: GetDeptScoreCardIndicatorRequest
        @return: GetDeptScoreCardIndicatorResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.GetDeptScoreCardIndicatorHeaders()
        return self.get_dept_score_card_indicator_with_options(request, headers, runtime)

    async def get_dept_score_card_indicator_async(
        self,
        request: dingtalkagoal__1__0_models.GetDeptScoreCardIndicatorRequest,
    ) -> dingtalkagoal__1__0_models.GetDeptScoreCardIndicatorResponse:
        """
        @summary 获取部门下的维度和指标id
        
        @param request: GetDeptScoreCardIndicatorRequest
        @return: GetDeptScoreCardIndicatorResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.GetDeptScoreCardIndicatorHeaders()
        return await self.get_dept_score_card_indicator_with_options_async(request, headers, runtime)

    def get_indicator_detail_with_options(
        self,
        request: dingtalkagoal__1__0_models.GetIndicatorDetailRequest,
        headers: dingtalkagoal__1__0_models.GetIndicatorDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.GetIndicatorDetailResponse:
        """
        @summary 获取指标详情
        
        @param request: GetIndicatorDetailRequest
        @param headers: GetIndicatorDetailHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetIndicatorDetailResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.indicator_id):
            query['indicatorId'] = request.indicator_id
        if not UtilClient.is_unset(request.month_num):
            query['monthNum'] = request.month_num
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
            action='GetIndicatorDetail',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/scorecards/indicators/details',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.GetIndicatorDetailResponse(),
            self.execute(params, req, runtime)
        )

    async def get_indicator_detail_with_options_async(
        self,
        request: dingtalkagoal__1__0_models.GetIndicatorDetailRequest,
        headers: dingtalkagoal__1__0_models.GetIndicatorDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.GetIndicatorDetailResponse:
        """
        @summary 获取指标详情
        
        @param request: GetIndicatorDetailRequest
        @param headers: GetIndicatorDetailHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetIndicatorDetailResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.indicator_id):
            query['indicatorId'] = request.indicator_id
        if not UtilClient.is_unset(request.month_num):
            query['monthNum'] = request.month_num
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
            action='GetIndicatorDetail',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/scorecards/indicators/details',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.GetIndicatorDetailResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_indicator_detail(
        self,
        request: dingtalkagoal__1__0_models.GetIndicatorDetailRequest,
    ) -> dingtalkagoal__1__0_models.GetIndicatorDetailResponse:
        """
        @summary 获取指标详情
        
        @param request: GetIndicatorDetailRequest
        @return: GetIndicatorDetailResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.GetIndicatorDetailHeaders()
        return self.get_indicator_detail_with_options(request, headers, runtime)

    async def get_indicator_detail_async(
        self,
        request: dingtalkagoal__1__0_models.GetIndicatorDetailRequest,
    ) -> dingtalkagoal__1__0_models.GetIndicatorDetailResponse:
        """
        @summary 获取指标详情
        
        @param request: GetIndicatorDetailRequest
        @return: GetIndicatorDetailResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.GetIndicatorDetailHeaders()
        return await self.get_indicator_detail_with_options_async(request, headers, runtime)

    def get_objective_detail_with_options(
        self,
        request: dingtalkagoal__1__0_models.GetObjectiveDetailRequest,
        headers: dingtalkagoal__1__0_models.GetObjectiveDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.GetObjectiveDetailResponse:
        """
        @summary 查询企业下个人目标详情
        
        @param request: GetObjectiveDetailRequest
        @param headers: GetObjectiveDetailHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetObjectiveDetailResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.objective_id):
            query['objectiveId'] = request.objective_id
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
            action='GetObjectiveDetail',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/objectives/details',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.GetObjectiveDetailResponse(),
            self.execute(params, req, runtime)
        )

    async def get_objective_detail_with_options_async(
        self,
        request: dingtalkagoal__1__0_models.GetObjectiveDetailRequest,
        headers: dingtalkagoal__1__0_models.GetObjectiveDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.GetObjectiveDetailResponse:
        """
        @summary 查询企业下个人目标详情
        
        @param request: GetObjectiveDetailRequest
        @param headers: GetObjectiveDetailHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetObjectiveDetailResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.objective_id):
            query['objectiveId'] = request.objective_id
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
            action='GetObjectiveDetail',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/objectives/details',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.GetObjectiveDetailResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_objective_detail(
        self,
        request: dingtalkagoal__1__0_models.GetObjectiveDetailRequest,
    ) -> dingtalkagoal__1__0_models.GetObjectiveDetailResponse:
        """
        @summary 查询企业下个人目标详情
        
        @param request: GetObjectiveDetailRequest
        @return: GetObjectiveDetailResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.GetObjectiveDetailHeaders()
        return self.get_objective_detail_with_options(request, headers, runtime)

    async def get_objective_detail_async(
        self,
        request: dingtalkagoal__1__0_models.GetObjectiveDetailRequest,
    ) -> dingtalkagoal__1__0_models.GetObjectiveDetailResponse:
        """
        @summary 查询企业下个人目标详情
        
        @param request: GetObjectiveDetailRequest
        @return: GetObjectiveDetailResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.GetObjectiveDetailHeaders()
        return await self.get_objective_detail_with_options_async(request, headers, runtime)

    def get_objective_rule_detail_with_options(
        self,
        request: dingtalkagoal__1__0_models.GetObjectiveRuleDetailRequest,
        headers: dingtalkagoal__1__0_models.GetObjectiveRuleDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.GetObjectiveRuleDetailResponse:
        """
        @summary 查询企业下单个目标规则详情
        
        @param request: GetObjectiveRuleDetailRequest
        @param headers: GetObjectiveRuleDetailHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetObjectiveRuleDetailResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.objective_rule_id):
            query['objectiveRuleId'] = request.objective_rule_id
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
            action='GetObjectiveRuleDetail',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/objectiveRules/details',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.GetObjectiveRuleDetailResponse(),
            self.execute(params, req, runtime)
        )

    async def get_objective_rule_detail_with_options_async(
        self,
        request: dingtalkagoal__1__0_models.GetObjectiveRuleDetailRequest,
        headers: dingtalkagoal__1__0_models.GetObjectiveRuleDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.GetObjectiveRuleDetailResponse:
        """
        @summary 查询企业下单个目标规则详情
        
        @param request: GetObjectiveRuleDetailRequest
        @param headers: GetObjectiveRuleDetailHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetObjectiveRuleDetailResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.objective_rule_id):
            query['objectiveRuleId'] = request.objective_rule_id
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
            action='GetObjectiveRuleDetail',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/objectiveRules/details',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.GetObjectiveRuleDetailResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_objective_rule_detail(
        self,
        request: dingtalkagoal__1__0_models.GetObjectiveRuleDetailRequest,
    ) -> dingtalkagoal__1__0_models.GetObjectiveRuleDetailResponse:
        """
        @summary 查询企业下单个目标规则详情
        
        @param request: GetObjectiveRuleDetailRequest
        @return: GetObjectiveRuleDetailResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.GetObjectiveRuleDetailHeaders()
        return self.get_objective_rule_detail_with_options(request, headers, runtime)

    async def get_objective_rule_detail_async(
        self,
        request: dingtalkagoal__1__0_models.GetObjectiveRuleDetailRequest,
    ) -> dingtalkagoal__1__0_models.GetObjectiveRuleDetailResponse:
        """
        @summary 查询企业下单个目标规则详情
        
        @param request: GetObjectiveRuleDetailRequest
        @return: GetObjectiveRuleDetailResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.GetObjectiveRuleDetailHeaders()
        return await self.get_objective_rule_detail_with_options_async(request, headers, runtime)
