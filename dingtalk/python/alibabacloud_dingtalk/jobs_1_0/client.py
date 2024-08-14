# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.jobs_1_0 import models as dingtalkjobs__1__0_models
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

    def create_resume_with_options(
        self,
        request: dingtalkjobs__1__0_models.CreateResumeRequest,
        headers: dingtalkjobs__1__0_models.CreateResumeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkjobs__1__0_models.CreateResumeResponse:
        """
        @summary 创建简历
        
        @param request: CreateResumeRequest
        @param headers: CreateResumeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateResumeResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_code):
            body['bizCode'] = request.biz_code
        if not UtilClient.is_unset(request.ext):
            body['ext'] = request.ext
        if not UtilClient.is_unset(request.resume_data_vo):
            body['resumeDataVO'] = request.resume_data_vo
        if not UtilClient.is_unset(request.scene):
            body['scene'] = request.scene
        if not UtilClient.is_unset(request.types):
            body['types'] = request.types
        if not UtilClient.is_unset(request.user_identify):
            body['userIdentify'] = request.user_identify
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
            action='CreateResume',
            version='jobs_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/jobs/resumes',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkjobs__1__0_models.CreateResumeResponse(),
            self.execute(params, req, runtime)
        )

    async def create_resume_with_options_async(
        self,
        request: dingtalkjobs__1__0_models.CreateResumeRequest,
        headers: dingtalkjobs__1__0_models.CreateResumeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkjobs__1__0_models.CreateResumeResponse:
        """
        @summary 创建简历
        
        @param request: CreateResumeRequest
        @param headers: CreateResumeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateResumeResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_code):
            body['bizCode'] = request.biz_code
        if not UtilClient.is_unset(request.ext):
            body['ext'] = request.ext
        if not UtilClient.is_unset(request.resume_data_vo):
            body['resumeDataVO'] = request.resume_data_vo
        if not UtilClient.is_unset(request.scene):
            body['scene'] = request.scene
        if not UtilClient.is_unset(request.types):
            body['types'] = request.types
        if not UtilClient.is_unset(request.user_identify):
            body['userIdentify'] = request.user_identify
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
            action='CreateResume',
            version='jobs_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/jobs/resumes',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkjobs__1__0_models.CreateResumeResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_resume(
        self,
        request: dingtalkjobs__1__0_models.CreateResumeRequest,
    ) -> dingtalkjobs__1__0_models.CreateResumeResponse:
        """
        @summary 创建简历
        
        @param request: CreateResumeRequest
        @return: CreateResumeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkjobs__1__0_models.CreateResumeHeaders()
        return self.create_resume_with_options(request, headers, runtime)

    async def create_resume_async(
        self,
        request: dingtalkjobs__1__0_models.CreateResumeRequest,
    ) -> dingtalkjobs__1__0_models.CreateResumeResponse:
        """
        @summary 创建简历
        
        @param request: CreateResumeRequest
        @return: CreateResumeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkjobs__1__0_models.CreateResumeHeaders()
        return await self.create_resume_with_options_async(request, headers, runtime)

    def post_resume_with_options(
        self,
        request: dingtalkjobs__1__0_models.PostResumeRequest,
        headers: dingtalkjobs__1__0_models.PostResumeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkjobs__1__0_models.PostResumeResponse:
        """
        @summary 投递简历
        
        @param request: PostResumeRequest
        @param headers: PostResumeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PostResumeResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.job_id):
            body['jobId'] = request.job_id
        if not UtilClient.is_unset(request.user_identify):
            body['userIdentify'] = request.user_identify
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
            action='PostResume',
            version='jobs_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/jobs/resumes/post',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkjobs__1__0_models.PostResumeResponse(),
            self.execute(params, req, runtime)
        )

    async def post_resume_with_options_async(
        self,
        request: dingtalkjobs__1__0_models.PostResumeRequest,
        headers: dingtalkjobs__1__0_models.PostResumeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkjobs__1__0_models.PostResumeResponse:
        """
        @summary 投递简历
        
        @param request: PostResumeRequest
        @param headers: PostResumeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PostResumeResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.job_id):
            body['jobId'] = request.job_id
        if not UtilClient.is_unset(request.user_identify):
            body['userIdentify'] = request.user_identify
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
            action='PostResume',
            version='jobs_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/jobs/resumes/post',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkjobs__1__0_models.PostResumeResponse(),
            await self.execute_async(params, req, runtime)
        )

    def post_resume(
        self,
        request: dingtalkjobs__1__0_models.PostResumeRequest,
    ) -> dingtalkjobs__1__0_models.PostResumeResponse:
        """
        @summary 投递简历
        
        @param request: PostResumeRequest
        @return: PostResumeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkjobs__1__0_models.PostResumeHeaders()
        return self.post_resume_with_options(request, headers, runtime)

    async def post_resume_async(
        self,
        request: dingtalkjobs__1__0_models.PostResumeRequest,
    ) -> dingtalkjobs__1__0_models.PostResumeResponse:
        """
        @summary 投递简历
        
        @param request: PostResumeRequest
        @return: PostResumeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkjobs__1__0_models.PostResumeHeaders()
        return await self.post_resume_with_options_async(request, headers, runtime)
