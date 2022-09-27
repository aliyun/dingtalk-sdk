# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.h5package_1_0 import models as dingtalkh_5package__1__0_models
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

    def create_package(
        self,
        request: dingtalkh_5package__1__0_models.CreatePackageRequest,
    ) -> dingtalkh_5package__1__0_models.CreatePackageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkh_5package__1__0_models.CreatePackageHeaders()
        return self.create_package_with_options(request, headers, runtime)

    async def create_package_async(
        self,
        request: dingtalkh_5package__1__0_models.CreatePackageRequest,
    ) -> dingtalkh_5package__1__0_models.CreatePackageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkh_5package__1__0_models.CreatePackageHeaders()
        return await self.create_package_with_options_async(request, headers, runtime)

    def create_package_with_options(
        self,
        request: dingtalkh_5package__1__0_models.CreatePackageRequest,
        headers: dingtalkh_5package__1__0_models.CreatePackageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkh_5package__1__0_models.CreatePackageResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.agent_id):
            body['agentId'] = request.agent_id
        if not UtilClient.is_unset(request.app_id):
            body['appId'] = request.app_id
        if not UtilClient.is_unset(request.oss_object_key):
            body['ossObjectKey'] = request.oss_object_key
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkh_5package__1__0_models.CreatePackageResponse(),
            self.do_roarequest('CreatePackage', 'h5package_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/h5package/asyncUpload', 'json', req, runtime)
        )

    async def create_package_with_options_async(
        self,
        request: dingtalkh_5package__1__0_models.CreatePackageRequest,
        headers: dingtalkh_5package__1__0_models.CreatePackageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkh_5package__1__0_models.CreatePackageResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.agent_id):
            body['agentId'] = request.agent_id
        if not UtilClient.is_unset(request.app_id):
            body['appId'] = request.app_id
        if not UtilClient.is_unset(request.oss_object_key):
            body['ossObjectKey'] = request.oss_object_key
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkh_5package__1__0_models.CreatePackageResponse(),
            await self.do_roarequest_async('CreatePackage', 'h5package_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/h5package/asyncUpload', 'json', req, runtime)
        )

    def get_access_token(
        self,
        request: dingtalkh_5package__1__0_models.GetAccessTokenRequest,
    ) -> dingtalkh_5package__1__0_models.GetAccessTokenResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkh_5package__1__0_models.GetAccessTokenHeaders()
        return self.get_access_token_with_options(request, headers, runtime)

    async def get_access_token_async(
        self,
        request: dingtalkh_5package__1__0_models.GetAccessTokenRequest,
    ) -> dingtalkh_5package__1__0_models.GetAccessTokenResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkh_5package__1__0_models.GetAccessTokenHeaders()
        return await self.get_access_token_with_options_async(request, headers, runtime)

    def get_access_token_with_options(
        self,
        request: dingtalkh_5package__1__0_models.GetAccessTokenRequest,
        headers: dingtalkh_5package__1__0_models.GetAccessTokenHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkh_5package__1__0_models.GetAccessTokenResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.agent_id):
            query['agentId'] = request.agent_id
        if not UtilClient.is_unset(request.app_id):
            query['appId'] = request.app_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkh_5package__1__0_models.GetAccessTokenResponse(),
            self.do_roarequest('GetAccessToken', 'h5package_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/h5package/uploadTokens', 'json', req, runtime)
        )

    async def get_access_token_with_options_async(
        self,
        request: dingtalkh_5package__1__0_models.GetAccessTokenRequest,
        headers: dingtalkh_5package__1__0_models.GetAccessTokenHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkh_5package__1__0_models.GetAccessTokenResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.agent_id):
            query['agentId'] = request.agent_id
        if not UtilClient.is_unset(request.app_id):
            query['appId'] = request.app_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkh_5package__1__0_models.GetAccessTokenResponse(),
            await self.do_roarequest_async('GetAccessToken', 'h5package_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/h5package/uploadTokens', 'json', req, runtime)
        )

    def get_create_status(
        self,
        request: dingtalkh_5package__1__0_models.GetCreateStatusRequest,
    ) -> dingtalkh_5package__1__0_models.GetCreateStatusResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkh_5package__1__0_models.GetCreateStatusHeaders()
        return self.get_create_status_with_options(request, headers, runtime)

    async def get_create_status_async(
        self,
        request: dingtalkh_5package__1__0_models.GetCreateStatusRequest,
    ) -> dingtalkh_5package__1__0_models.GetCreateStatusResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkh_5package__1__0_models.GetCreateStatusHeaders()
        return await self.get_create_status_with_options_async(request, headers, runtime)

    def get_create_status_with_options(
        self,
        request: dingtalkh_5package__1__0_models.GetCreateStatusRequest,
        headers: dingtalkh_5package__1__0_models.GetCreateStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkh_5package__1__0_models.GetCreateStatusResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.task_id):
            query['taskId'] = request.task_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkh_5package__1__0_models.GetCreateStatusResponse(),
            self.do_roarequest('GetCreateStatus', 'h5package_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/h5package/uploadStatus', 'json', req, runtime)
        )

    async def get_create_status_with_options_async(
        self,
        request: dingtalkh_5package__1__0_models.GetCreateStatusRequest,
        headers: dingtalkh_5package__1__0_models.GetCreateStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkh_5package__1__0_models.GetCreateStatusResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.task_id):
            query['taskId'] = request.task_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkh_5package__1__0_models.GetCreateStatusResponse(),
            await self.do_roarequest_async('GetCreateStatus', 'h5package_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/h5package/uploadStatus', 'json', req, runtime)
        )

    def publish_package(
        self,
        request: dingtalkh_5package__1__0_models.PublishPackageRequest,
    ) -> dingtalkh_5package__1__0_models.PublishPackageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkh_5package__1__0_models.PublishPackageHeaders()
        return self.publish_package_with_options(request, headers, runtime)

    async def publish_package_async(
        self,
        request: dingtalkh_5package__1__0_models.PublishPackageRequest,
    ) -> dingtalkh_5package__1__0_models.PublishPackageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkh_5package__1__0_models.PublishPackageHeaders()
        return await self.publish_package_with_options_async(request, headers, runtime)

    def publish_package_with_options(
        self,
        request: dingtalkh_5package__1__0_models.PublishPackageRequest,
        headers: dingtalkh_5package__1__0_models.PublishPackageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkh_5package__1__0_models.PublishPackageResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.agent_id):
            body['agentId'] = request.agent_id
        if not UtilClient.is_unset(request.app_id):
            body['appId'] = request.app_id
        if not UtilClient.is_unset(request.version):
            body['version'] = request.version
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkh_5package__1__0_models.PublishPackageResponse(),
            self.do_roarequest('PublishPackage', 'h5package_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/h5package/publish', 'json', req, runtime)
        )

    async def publish_package_with_options_async(
        self,
        request: dingtalkh_5package__1__0_models.PublishPackageRequest,
        headers: dingtalkh_5package__1__0_models.PublishPackageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkh_5package__1__0_models.PublishPackageResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.agent_id):
            body['agentId'] = request.agent_id
        if not UtilClient.is_unset(request.app_id):
            body['appId'] = request.app_id
        if not UtilClient.is_unset(request.version):
            body['version'] = request.version
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkh_5package__1__0_models.PublishPackageResponse(),
            await self.do_roarequest_async('PublishPackage', 'h5package_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/h5package/publish', 'json', req, runtime)
        )
