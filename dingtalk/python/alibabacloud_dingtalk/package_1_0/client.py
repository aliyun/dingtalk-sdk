# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.package_1_0 import models as dingtalkpackage__1__0_models
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

    def get_upload_token(
        self,
        request: dingtalkpackage__1__0_models.GetUploadTokenRequest,
    ) -> dingtalkpackage__1__0_models.GetUploadTokenResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkpackage__1__0_models.GetUploadTokenHeaders()
        return self.get_upload_token_with_options(request, headers, runtime)

    async def get_upload_token_async(
        self,
        request: dingtalkpackage__1__0_models.GetUploadTokenRequest,
    ) -> dingtalkpackage__1__0_models.GetUploadTokenResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkpackage__1__0_models.GetUploadTokenHeaders()
        return await self.get_upload_token_with_options_async(request, headers, runtime)

    def get_upload_token_with_options(
        self,
        request: dingtalkpackage__1__0_models.GetUploadTokenRequest,
        headers: dingtalkpackage__1__0_models.GetUploadTokenHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkpackage__1__0_models.GetUploadTokenResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.mini_app_id):
            query['miniAppId'] = request.mini_app_id
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
            dingtalkpackage__1__0_models.GetUploadTokenResponse(),
            self.do_roarequest('GetUploadToken', 'package_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/package/uploadTokens', 'json', req, runtime)
        )

    async def get_upload_token_with_options_async(
        self,
        request: dingtalkpackage__1__0_models.GetUploadTokenRequest,
        headers: dingtalkpackage__1__0_models.GetUploadTokenHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkpackage__1__0_models.GetUploadTokenResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.mini_app_id):
            query['miniAppId'] = request.mini_app_id
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
            dingtalkpackage__1__0_models.GetUploadTokenResponse(),
            await self.do_roarequest_async('GetUploadToken', 'package_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/package/uploadTokens', 'json', req, runtime)
        )

    def h_publish_package(
        self,
        request: dingtalkpackage__1__0_models.HPublishPackageRequest,
    ) -> dingtalkpackage__1__0_models.HPublishPackageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkpackage__1__0_models.HPublishPackageHeaders()
        return self.h_publish_package_with_options(request, headers, runtime)

    async def h_publish_package_async(
        self,
        request: dingtalkpackage__1__0_models.HPublishPackageRequest,
    ) -> dingtalkpackage__1__0_models.HPublishPackageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkpackage__1__0_models.HPublishPackageHeaders()
        return await self.h_publish_package_with_options_async(request, headers, runtime)

    def h_publish_package_with_options(
        self,
        request: dingtalkpackage__1__0_models.HPublishPackageRequest,
        headers: dingtalkpackage__1__0_models.HPublishPackageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkpackage__1__0_models.HPublishPackageResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.mini_app_id):
            body['miniAppId'] = request.mini_app_id
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
            dingtalkpackage__1__0_models.HPublishPackageResponse(),
            self.do_roarequest('HPublishPackage', 'package_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/package/h5/publish', 'json', req, runtime)
        )

    async def h_publish_package_with_options_async(
        self,
        request: dingtalkpackage__1__0_models.HPublishPackageRequest,
        headers: dingtalkpackage__1__0_models.HPublishPackageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkpackage__1__0_models.HPublishPackageResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.mini_app_id):
            body['miniAppId'] = request.mini_app_id
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
            dingtalkpackage__1__0_models.HPublishPackageResponse(),
            await self.do_roarequest_async('HPublishPackage', 'package_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/package/h5/publish', 'json', req, runtime)
        )

    def h_upload_package(
        self,
        request: dingtalkpackage__1__0_models.HUploadPackageRequest,
    ) -> dingtalkpackage__1__0_models.HUploadPackageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkpackage__1__0_models.HUploadPackageHeaders()
        return self.h_upload_package_with_options(request, headers, runtime)

    async def h_upload_package_async(
        self,
        request: dingtalkpackage__1__0_models.HUploadPackageRequest,
    ) -> dingtalkpackage__1__0_models.HUploadPackageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkpackage__1__0_models.HUploadPackageHeaders()
        return await self.h_upload_package_with_options_async(request, headers, runtime)

    def h_upload_package_with_options(
        self,
        request: dingtalkpackage__1__0_models.HUploadPackageRequest,
        headers: dingtalkpackage__1__0_models.HUploadPackageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkpackage__1__0_models.HUploadPackageResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.mini_app_id):
            body['miniAppId'] = request.mini_app_id
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
            dingtalkpackage__1__0_models.HUploadPackageResponse(),
            self.do_roarequest('HUploadPackage', 'package_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/package/h5/asyncUpload', 'json', req, runtime)
        )

    async def h_upload_package_with_options_async(
        self,
        request: dingtalkpackage__1__0_models.HUploadPackageRequest,
        headers: dingtalkpackage__1__0_models.HUploadPackageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkpackage__1__0_models.HUploadPackageResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.mini_app_id):
            body['miniAppId'] = request.mini_app_id
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
            dingtalkpackage__1__0_models.HUploadPackageResponse(),
            await self.do_roarequest_async('HUploadPackage', 'package_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/package/h5/asyncUpload', 'json', req, runtime)
        )

    def h_upload_package_status(
        self,
        request: dingtalkpackage__1__0_models.HUploadPackageStatusRequest,
    ) -> dingtalkpackage__1__0_models.HUploadPackageStatusResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkpackage__1__0_models.HUploadPackageStatusHeaders()
        return self.h_upload_package_status_with_options(request, headers, runtime)

    async def h_upload_package_status_async(
        self,
        request: dingtalkpackage__1__0_models.HUploadPackageStatusRequest,
    ) -> dingtalkpackage__1__0_models.HUploadPackageStatusResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkpackage__1__0_models.HUploadPackageStatusHeaders()
        return await self.h_upload_package_status_with_options_async(request, headers, runtime)

    def h_upload_package_status_with_options(
        self,
        request: dingtalkpackage__1__0_models.HUploadPackageStatusRequest,
        headers: dingtalkpackage__1__0_models.HUploadPackageStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkpackage__1__0_models.HUploadPackageStatusResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.mini_app_id):
            query['miniAppId'] = request.mini_app_id
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
            dingtalkpackage__1__0_models.HUploadPackageStatusResponse(),
            self.do_roarequest('HUploadPackageStatus', 'package_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/package/h5/uploadStatus', 'json', req, runtime)
        )

    async def h_upload_package_status_with_options_async(
        self,
        request: dingtalkpackage__1__0_models.HUploadPackageStatusRequest,
        headers: dingtalkpackage__1__0_models.HUploadPackageStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkpackage__1__0_models.HUploadPackageStatusResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.mini_app_id):
            query['miniAppId'] = request.mini_app_id
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
            dingtalkpackage__1__0_models.HUploadPackageStatusResponse(),
            await self.do_roarequest_async('HUploadPackageStatus', 'package_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/package/h5/uploadStatus', 'json', req, runtime)
        )
