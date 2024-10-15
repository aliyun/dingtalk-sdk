# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore
from typing import Dict

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.miniapp_1_0 import models as dingtalkminiapp__1__0_models
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

    def create_mini_app_with_options(
        self,
        request: dingtalkminiapp__1__0_models.CreateMiniAppRequest,
        headers: dingtalkminiapp__1__0_models.CreateMiniAppHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminiapp__1__0_models.CreateMiniAppResponse:
        """
        @summary 创建小程序
        
        @param request: CreateMiniAppRequest
        @param headers: CreateMiniAppHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateMiniAppResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.biz_type):
            body['bizType'] = request.biz_type
        if not UtilClient.is_unset(request.bundle_id):
            body['bundleId'] = request.bundle_id
        if not UtilClient.is_unset(request.desc):
            body['desc'] = request.desc
        if not UtilClient.is_unset(request.icon):
            body['icon'] = request.icon
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
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
            action='CreateMiniApp',
            version='miniapp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/miniapp/apps',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminiapp__1__0_models.CreateMiniAppResponse(),
            self.execute(params, req, runtime)
        )

    async def create_mini_app_with_options_async(
        self,
        request: dingtalkminiapp__1__0_models.CreateMiniAppRequest,
        headers: dingtalkminiapp__1__0_models.CreateMiniAppHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminiapp__1__0_models.CreateMiniAppResponse:
        """
        @summary 创建小程序
        
        @param request: CreateMiniAppRequest
        @param headers: CreateMiniAppHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateMiniAppResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.biz_type):
            body['bizType'] = request.biz_type
        if not UtilClient.is_unset(request.bundle_id):
            body['bundleId'] = request.bundle_id
        if not UtilClient.is_unset(request.desc):
            body['desc'] = request.desc
        if not UtilClient.is_unset(request.icon):
            body['icon'] = request.icon
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
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
            action='CreateMiniApp',
            version='miniapp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/miniapp/apps',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminiapp__1__0_models.CreateMiniAppResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_mini_app(
        self,
        request: dingtalkminiapp__1__0_models.CreateMiniAppRequest,
    ) -> dingtalkminiapp__1__0_models.CreateMiniAppResponse:
        """
        @summary 创建小程序
        
        @param request: CreateMiniAppRequest
        @return: CreateMiniAppResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminiapp__1__0_models.CreateMiniAppHeaders()
        return self.create_mini_app_with_options(request, headers, runtime)

    async def create_mini_app_async(
        self,
        request: dingtalkminiapp__1__0_models.CreateMiniAppRequest,
    ) -> dingtalkminiapp__1__0_models.CreateMiniAppResponse:
        """
        @summary 创建小程序
        
        @param request: CreateMiniAppRequest
        @return: CreateMiniAppResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminiapp__1__0_models.CreateMiniAppHeaders()
        return await self.create_mini_app_with_options_async(request, headers, runtime)

    def create_mini_app_plugin_with_options(
        self,
        request: dingtalkminiapp__1__0_models.CreateMiniAppPluginRequest,
        headers: dingtalkminiapp__1__0_models.CreateMiniAppPluginHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminiapp__1__0_models.CreateMiniAppPluginResponse:
        """
        @summary 创建小程序组件
        
        @param request: CreateMiniAppPluginRequest
        @param headers: CreateMiniAppPluginHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateMiniAppPluginResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.biz_type):
            body['bizType'] = request.biz_type
        if not UtilClient.is_unset(request.bundle_id):
            body['bundleId'] = request.bundle_id
        if not UtilClient.is_unset(request.desc):
            body['desc'] = request.desc
        if not UtilClient.is_unset(request.icon):
            body['icon'] = request.icon
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
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
            action='CreateMiniAppPlugin',
            version='miniapp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/miniapp/plugins',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminiapp__1__0_models.CreateMiniAppPluginResponse(),
            self.execute(params, req, runtime)
        )

    async def create_mini_app_plugin_with_options_async(
        self,
        request: dingtalkminiapp__1__0_models.CreateMiniAppPluginRequest,
        headers: dingtalkminiapp__1__0_models.CreateMiniAppPluginHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminiapp__1__0_models.CreateMiniAppPluginResponse:
        """
        @summary 创建小程序组件
        
        @param request: CreateMiniAppPluginRequest
        @param headers: CreateMiniAppPluginHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateMiniAppPluginResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.biz_type):
            body['bizType'] = request.biz_type
        if not UtilClient.is_unset(request.bundle_id):
            body['bundleId'] = request.bundle_id
        if not UtilClient.is_unset(request.desc):
            body['desc'] = request.desc
        if not UtilClient.is_unset(request.icon):
            body['icon'] = request.icon
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
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
            action='CreateMiniAppPlugin',
            version='miniapp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/miniapp/plugins',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminiapp__1__0_models.CreateMiniAppPluginResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_mini_app_plugin(
        self,
        request: dingtalkminiapp__1__0_models.CreateMiniAppPluginRequest,
    ) -> dingtalkminiapp__1__0_models.CreateMiniAppPluginResponse:
        """
        @summary 创建小程序组件
        
        @param request: CreateMiniAppPluginRequest
        @return: CreateMiniAppPluginResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminiapp__1__0_models.CreateMiniAppPluginHeaders()
        return self.create_mini_app_plugin_with_options(request, headers, runtime)

    async def create_mini_app_plugin_async(
        self,
        request: dingtalkminiapp__1__0_models.CreateMiniAppPluginRequest,
    ) -> dingtalkminiapp__1__0_models.CreateMiniAppPluginResponse:
        """
        @summary 创建小程序组件
        
        @param request: CreateMiniAppPluginRequest
        @return: CreateMiniAppPluginResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminiapp__1__0_models.CreateMiniAppPluginHeaders()
        return await self.create_mini_app_plugin_with_options_async(request, headers, runtime)

    def create_version_across_bundle_with_options(
        self,
        request: dingtalkminiapp__1__0_models.CreateVersionAcrossBundleRequest,
        headers: dingtalkminiapp__1__0_models.CreateVersionAcrossBundleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminiapp__1__0_models.CreateVersionAcrossBundleResponse:
        """
        @summary 小程序多端发布版本
        
        @param request: CreateVersionAcrossBundleRequest
        @param headers: CreateVersionAcrossBundleHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateVersionAcrossBundleResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.bundle_id):
            body['bundleId'] = request.bundle_id
        if not UtilClient.is_unset(request.mini_app_id):
            body['miniAppId'] = request.mini_app_id
        if not UtilClient.is_unset(request.source_bundle_id):
            body['sourceBundleId'] = request.source_bundle_id
        if not UtilClient.is_unset(request.source_version):
            body['sourceVersion'] = request.source_version
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
        params = open_api_models.Params(
            action='CreateVersionAcrossBundle',
            version='miniapp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/miniapp/versions/createAcrossBundle',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminiapp__1__0_models.CreateVersionAcrossBundleResponse(),
            self.execute(params, req, runtime)
        )

    async def create_version_across_bundle_with_options_async(
        self,
        request: dingtalkminiapp__1__0_models.CreateVersionAcrossBundleRequest,
        headers: dingtalkminiapp__1__0_models.CreateVersionAcrossBundleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminiapp__1__0_models.CreateVersionAcrossBundleResponse:
        """
        @summary 小程序多端发布版本
        
        @param request: CreateVersionAcrossBundleRequest
        @param headers: CreateVersionAcrossBundleHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateVersionAcrossBundleResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.bundle_id):
            body['bundleId'] = request.bundle_id
        if not UtilClient.is_unset(request.mini_app_id):
            body['miniAppId'] = request.mini_app_id
        if not UtilClient.is_unset(request.source_bundle_id):
            body['sourceBundleId'] = request.source_bundle_id
        if not UtilClient.is_unset(request.source_version):
            body['sourceVersion'] = request.source_version
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
        params = open_api_models.Params(
            action='CreateVersionAcrossBundle',
            version='miniapp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/miniapp/versions/createAcrossBundle',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminiapp__1__0_models.CreateVersionAcrossBundleResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_version_across_bundle(
        self,
        request: dingtalkminiapp__1__0_models.CreateVersionAcrossBundleRequest,
    ) -> dingtalkminiapp__1__0_models.CreateVersionAcrossBundleResponse:
        """
        @summary 小程序多端发布版本
        
        @param request: CreateVersionAcrossBundleRequest
        @return: CreateVersionAcrossBundleResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminiapp__1__0_models.CreateVersionAcrossBundleHeaders()
        return self.create_version_across_bundle_with_options(request, headers, runtime)

    async def create_version_across_bundle_async(
        self,
        request: dingtalkminiapp__1__0_models.CreateVersionAcrossBundleRequest,
    ) -> dingtalkminiapp__1__0_models.CreateVersionAcrossBundleResponse:
        """
        @summary 小程序多端发布版本
        
        @param request: CreateVersionAcrossBundleRequest
        @return: CreateVersionAcrossBundleResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminiapp__1__0_models.CreateVersionAcrossBundleHeaders()
        return await self.create_version_across_bundle_with_options_async(request, headers, runtime)

    def get_max_version_with_options(
        self,
        request: dingtalkminiapp__1__0_models.GetMaxVersionRequest,
        headers: dingtalkminiapp__1__0_models.GetMaxVersionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminiapp__1__0_models.GetMaxVersionResponse:
        """
        @summary 获取小程序最大的构建版本
        
        @param request: GetMaxVersionRequest
        @param headers: GetMaxVersionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetMaxVersionResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.bundle_id):
            query['bundleId'] = request.bundle_id
        if not UtilClient.is_unset(request.mini_app_id):
            query['miniAppId'] = request.mini_app_id
        if not UtilClient.is_unset(request.version):
            query['version'] = request.version
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
            action='GetMaxVersion',
            version='miniapp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/miniapp/apps/maxVersions',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminiapp__1__0_models.GetMaxVersionResponse(),
            self.execute(params, req, runtime)
        )

    async def get_max_version_with_options_async(
        self,
        request: dingtalkminiapp__1__0_models.GetMaxVersionRequest,
        headers: dingtalkminiapp__1__0_models.GetMaxVersionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminiapp__1__0_models.GetMaxVersionResponse:
        """
        @summary 获取小程序最大的构建版本
        
        @param request: GetMaxVersionRequest
        @param headers: GetMaxVersionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetMaxVersionResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.bundle_id):
            query['bundleId'] = request.bundle_id
        if not UtilClient.is_unset(request.mini_app_id):
            query['miniAppId'] = request.mini_app_id
        if not UtilClient.is_unset(request.version):
            query['version'] = request.version
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
            action='GetMaxVersion',
            version='miniapp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/miniapp/apps/maxVersions',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminiapp__1__0_models.GetMaxVersionResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_max_version(
        self,
        request: dingtalkminiapp__1__0_models.GetMaxVersionRequest,
    ) -> dingtalkminiapp__1__0_models.GetMaxVersionResponse:
        """
        @summary 获取小程序最大的构建版本
        
        @param request: GetMaxVersionRequest
        @return: GetMaxVersionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminiapp__1__0_models.GetMaxVersionHeaders()
        return self.get_max_version_with_options(request, headers, runtime)

    async def get_max_version_async(
        self,
        request: dingtalkminiapp__1__0_models.GetMaxVersionRequest,
    ) -> dingtalkminiapp__1__0_models.GetMaxVersionResponse:
        """
        @summary 获取小程序最大的构建版本
        
        @param request: GetMaxVersionRequest
        @return: GetMaxVersionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminiapp__1__0_models.GetMaxVersionHeaders()
        return await self.get_max_version_with_options_async(request, headers, runtime)

    def get_mini_app_meta_data_with_options(
        self,
        request: dingtalkminiapp__1__0_models.GetMiniAppMetaDataRequest,
        headers: dingtalkminiapp__1__0_models.GetMiniAppMetaDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminiapp__1__0_models.GetMiniAppMetaDataResponse:
        """
        @summary 同步小程序元数据
        
        @param request: GetMiniAppMetaDataRequest
        @param headers: GetMiniAppMetaDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetMiniAppMetaDataResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.bundle_id):
            body['bundleId'] = request.bundle_id
        if not UtilClient.is_unset(request.bundle_id_table_gmt_modified):
            body['bundleIdTableGmtModified'] = request.bundle_id_table_gmt_modified
        if not UtilClient.is_unset(request.from_app_name):
            body['fromAppName'] = request.from_app_name
        if not UtilClient.is_unset(request.mini_app_id_table_gmt_modified):
            body['miniAppIdTableGmtModified'] = request.mini_app_id_table_gmt_modified
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
            action='GetMiniAppMetaData',
            version='miniapp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/miniapp/apps/metadata',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminiapp__1__0_models.GetMiniAppMetaDataResponse(),
            self.execute(params, req, runtime)
        )

    async def get_mini_app_meta_data_with_options_async(
        self,
        request: dingtalkminiapp__1__0_models.GetMiniAppMetaDataRequest,
        headers: dingtalkminiapp__1__0_models.GetMiniAppMetaDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminiapp__1__0_models.GetMiniAppMetaDataResponse:
        """
        @summary 同步小程序元数据
        
        @param request: GetMiniAppMetaDataRequest
        @param headers: GetMiniAppMetaDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetMiniAppMetaDataResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.bundle_id):
            body['bundleId'] = request.bundle_id
        if not UtilClient.is_unset(request.bundle_id_table_gmt_modified):
            body['bundleIdTableGmtModified'] = request.bundle_id_table_gmt_modified
        if not UtilClient.is_unset(request.from_app_name):
            body['fromAppName'] = request.from_app_name
        if not UtilClient.is_unset(request.mini_app_id_table_gmt_modified):
            body['miniAppIdTableGmtModified'] = request.mini_app_id_table_gmt_modified
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
            action='GetMiniAppMetaData',
            version='miniapp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/miniapp/apps/metadata',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminiapp__1__0_models.GetMiniAppMetaDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_mini_app_meta_data(
        self,
        request: dingtalkminiapp__1__0_models.GetMiniAppMetaDataRequest,
    ) -> dingtalkminiapp__1__0_models.GetMiniAppMetaDataResponse:
        """
        @summary 同步小程序元数据
        
        @param request: GetMiniAppMetaDataRequest
        @return: GetMiniAppMetaDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminiapp__1__0_models.GetMiniAppMetaDataHeaders()
        return self.get_mini_app_meta_data_with_options(request, headers, runtime)

    async def get_mini_app_meta_data_async(
        self,
        request: dingtalkminiapp__1__0_models.GetMiniAppMetaDataRequest,
    ) -> dingtalkminiapp__1__0_models.GetMiniAppMetaDataResponse:
        """
        @summary 同步小程序元数据
        
        @param request: GetMiniAppMetaDataRequest
        @return: GetMiniAppMetaDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminiapp__1__0_models.GetMiniAppMetaDataHeaders()
        return await self.get_mini_app_meta_data_with_options_async(request, headers, runtime)

    def get_setting_by_mini_app_id_with_options(
        self,
        mini_app_id: str,
        headers: dingtalkminiapp__1__0_models.GetSettingByMiniAppIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminiapp__1__0_models.GetSettingByMiniAppIdResponse:
        """
        @summary 查询小程序配置
        
        @param headers: GetSettingByMiniAppIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSettingByMiniAppIdResponse
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
            action='GetSettingByMiniAppId',
            version='miniapp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/miniapp/apps/settings',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminiapp__1__0_models.GetSettingByMiniAppIdResponse(),
            self.execute(params, req, runtime)
        )

    async def get_setting_by_mini_app_id_with_options_async(
        self,
        mini_app_id: str,
        headers: dingtalkminiapp__1__0_models.GetSettingByMiniAppIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminiapp__1__0_models.GetSettingByMiniAppIdResponse:
        """
        @summary 查询小程序配置
        
        @param headers: GetSettingByMiniAppIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSettingByMiniAppIdResponse
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
            action='GetSettingByMiniAppId',
            version='miniapp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/miniapp/apps/settings',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminiapp__1__0_models.GetSettingByMiniAppIdResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_setting_by_mini_app_id(
        self,
        mini_app_id: str,
    ) -> dingtalkminiapp__1__0_models.GetSettingByMiniAppIdResponse:
        """
        @summary 查询小程序配置
        
        @return: GetSettingByMiniAppIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminiapp__1__0_models.GetSettingByMiniAppIdHeaders()
        return self.get_setting_by_mini_app_id_with_options(mini_app_id, headers, runtime)

    async def get_setting_by_mini_app_id_async(
        self,
        mini_app_id: str,
    ) -> dingtalkminiapp__1__0_models.GetSettingByMiniAppIdResponse:
        """
        @summary 查询小程序配置
        
        @return: GetSettingByMiniAppIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminiapp__1__0_models.GetSettingByMiniAppIdHeaders()
        return await self.get_setting_by_mini_app_id_with_options_async(mini_app_id, headers, runtime)

    def invoke_html_bundle_build_with_options(
        self,
        request: dingtalkminiapp__1__0_models.InvokeHtmlBundleBuildRequest,
        headers: dingtalkminiapp__1__0_models.InvokeHtmlBundleBuildHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminiapp__1__0_models.InvokeHtmlBundleBuildResponse:
        """
        @summary 构建H5Bundle
        
        @param request: InvokeHtmlBundleBuildRequest
        @param headers: InvokeHtmlBundleBuildHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: InvokeHtmlBundleBuildResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.bundle_id):
            body['bundleId'] = request.bundle_id
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
        params = open_api_models.Params(
            action='InvokeHtmlBundleBuild',
            version='miniapp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/miniapp/h5Bundles/build',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminiapp__1__0_models.InvokeHtmlBundleBuildResponse(),
            self.execute(params, req, runtime)
        )

    async def invoke_html_bundle_build_with_options_async(
        self,
        request: dingtalkminiapp__1__0_models.InvokeHtmlBundleBuildRequest,
        headers: dingtalkminiapp__1__0_models.InvokeHtmlBundleBuildHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminiapp__1__0_models.InvokeHtmlBundleBuildResponse:
        """
        @summary 构建H5Bundle
        
        @param request: InvokeHtmlBundleBuildRequest
        @param headers: InvokeHtmlBundleBuildHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: InvokeHtmlBundleBuildResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.bundle_id):
            body['bundleId'] = request.bundle_id
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
        params = open_api_models.Params(
            action='InvokeHtmlBundleBuild',
            version='miniapp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/miniapp/h5Bundles/build',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminiapp__1__0_models.InvokeHtmlBundleBuildResponse(),
            await self.execute_async(params, req, runtime)
        )

    def invoke_html_bundle_build(
        self,
        request: dingtalkminiapp__1__0_models.InvokeHtmlBundleBuildRequest,
    ) -> dingtalkminiapp__1__0_models.InvokeHtmlBundleBuildResponse:
        """
        @summary 构建H5Bundle
        
        @param request: InvokeHtmlBundleBuildRequest
        @return: InvokeHtmlBundleBuildResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminiapp__1__0_models.InvokeHtmlBundleBuildHeaders()
        return self.invoke_html_bundle_build_with_options(request, headers, runtime)

    async def invoke_html_bundle_build_async(
        self,
        request: dingtalkminiapp__1__0_models.InvokeHtmlBundleBuildRequest,
    ) -> dingtalkminiapp__1__0_models.InvokeHtmlBundleBuildResponse:
        """
        @summary 构建H5Bundle
        
        @param request: InvokeHtmlBundleBuildRequest
        @return: InvokeHtmlBundleBuildResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminiapp__1__0_models.InvokeHtmlBundleBuildHeaders()
        return await self.invoke_html_bundle_build_with_options_async(request, headers, runtime)

    def list_avaiable_version_with_options(
        self,
        request: dingtalkminiapp__1__0_models.ListAvaiableVersionRequest,
        headers: dingtalkminiapp__1__0_models.ListAvaiableVersionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminiapp__1__0_models.ListAvaiableVersionResponse:
        """
        @summary 获取小程序版本列表
        
        @param request: ListAvaiableVersionRequest
        @param headers: ListAvaiableVersionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListAvaiableVersionResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.bundle_id):
            body['bundleId'] = request.bundle_id
        if not UtilClient.is_unset(request.mini_app_id):
            body['miniAppId'] = request.mini_app_id
        if not UtilClient.is_unset(request.page_num):
            body['pageNum'] = request.page_num
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.version_type_set):
            body['versionTypeSet'] = request.version_type_set
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
            action='ListAvaiableVersion',
            version='miniapp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/miniapp/apps/versions/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminiapp__1__0_models.ListAvaiableVersionResponse(),
            self.execute(params, req, runtime)
        )

    async def list_avaiable_version_with_options_async(
        self,
        request: dingtalkminiapp__1__0_models.ListAvaiableVersionRequest,
        headers: dingtalkminiapp__1__0_models.ListAvaiableVersionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminiapp__1__0_models.ListAvaiableVersionResponse:
        """
        @summary 获取小程序版本列表
        
        @param request: ListAvaiableVersionRequest
        @param headers: ListAvaiableVersionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListAvaiableVersionResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.bundle_id):
            body['bundleId'] = request.bundle_id
        if not UtilClient.is_unset(request.mini_app_id):
            body['miniAppId'] = request.mini_app_id
        if not UtilClient.is_unset(request.page_num):
            body['pageNum'] = request.page_num
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.version_type_set):
            body['versionTypeSet'] = request.version_type_set
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
            action='ListAvaiableVersion',
            version='miniapp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/miniapp/apps/versions/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminiapp__1__0_models.ListAvaiableVersionResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_avaiable_version(
        self,
        request: dingtalkminiapp__1__0_models.ListAvaiableVersionRequest,
    ) -> dingtalkminiapp__1__0_models.ListAvaiableVersionResponse:
        """
        @summary 获取小程序版本列表
        
        @param request: ListAvaiableVersionRequest
        @return: ListAvaiableVersionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminiapp__1__0_models.ListAvaiableVersionHeaders()
        return self.list_avaiable_version_with_options(request, headers, runtime)

    async def list_avaiable_version_async(
        self,
        request: dingtalkminiapp__1__0_models.ListAvaiableVersionRequest,
    ) -> dingtalkminiapp__1__0_models.ListAvaiableVersionResponse:
        """
        @summary 获取小程序版本列表
        
        @param request: ListAvaiableVersionRequest
        @return: ListAvaiableVersionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminiapp__1__0_models.ListAvaiableVersionHeaders()
        return await self.list_avaiable_version_with_options_async(request, headers, runtime)

    def query_html_bundle_build_with_options(
        self,
        request: dingtalkminiapp__1__0_models.QueryHtmlBundleBuildRequest,
        headers: dingtalkminiapp__1__0_models.QueryHtmlBundleBuildHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminiapp__1__0_models.QueryHtmlBundleBuildResponse:
        """
        @summary 查询H5构建结果
        
        @param request: QueryHtmlBundleBuildRequest
        @param headers: QueryHtmlBundleBuildHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryHtmlBundleBuildResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.bundle_id):
            query['bundleId'] = request.bundle_id
        if not UtilClient.is_unset(request.mini_app_id):
            query['miniAppId'] = request.mini_app_id
        if not UtilClient.is_unset(request.version):
            query['version'] = request.version
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
            action='QueryHtmlBundleBuild',
            version='miniapp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/miniapp/h5Bundles/buildResults',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminiapp__1__0_models.QueryHtmlBundleBuildResponse(),
            self.execute(params, req, runtime)
        )

    async def query_html_bundle_build_with_options_async(
        self,
        request: dingtalkminiapp__1__0_models.QueryHtmlBundleBuildRequest,
        headers: dingtalkminiapp__1__0_models.QueryHtmlBundleBuildHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminiapp__1__0_models.QueryHtmlBundleBuildResponse:
        """
        @summary 查询H5构建结果
        
        @param request: QueryHtmlBundleBuildRequest
        @param headers: QueryHtmlBundleBuildHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryHtmlBundleBuildResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.bundle_id):
            query['bundleId'] = request.bundle_id
        if not UtilClient.is_unset(request.mini_app_id):
            query['miniAppId'] = request.mini_app_id
        if not UtilClient.is_unset(request.version):
            query['version'] = request.version
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
            action='QueryHtmlBundleBuild',
            version='miniapp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/miniapp/h5Bundles/buildResults',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminiapp__1__0_models.QueryHtmlBundleBuildResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_html_bundle_build(
        self,
        request: dingtalkminiapp__1__0_models.QueryHtmlBundleBuildRequest,
    ) -> dingtalkminiapp__1__0_models.QueryHtmlBundleBuildResponse:
        """
        @summary 查询H5构建结果
        
        @param request: QueryHtmlBundleBuildRequest
        @return: QueryHtmlBundleBuildResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminiapp__1__0_models.QueryHtmlBundleBuildHeaders()
        return self.query_html_bundle_build_with_options(request, headers, runtime)

    async def query_html_bundle_build_async(
        self,
        request: dingtalkminiapp__1__0_models.QueryHtmlBundleBuildRequest,
    ) -> dingtalkminiapp__1__0_models.QueryHtmlBundleBuildResponse:
        """
        @summary 查询H5构建结果
        
        @param request: QueryHtmlBundleBuildRequest
        @return: QueryHtmlBundleBuildResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminiapp__1__0_models.QueryHtmlBundleBuildHeaders()
        return await self.query_html_bundle_build_with_options_async(request, headers, runtime)

    def roll_back_version_with_options(
        self,
        request: dingtalkminiapp__1__0_models.RollBackVersionRequest,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminiapp__1__0_models.RollBackVersionResponse:
        """
        @summary 回滚版本
        
        @param request: RollBackVersionRequest
        @param headers: map
        @param runtime: runtime options for this request RuntimeOptions
        @return: RollBackVersionResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.bundle_id):
            body['bundleId'] = request.bundle_id
        if not UtilClient.is_unset(request.mini_app_id):
            body['miniAppId'] = request.mini_app_id
        if not UtilClient.is_unset(request.rollback_version):
            body['rollbackVersion'] = request.rollback_version
        if not UtilClient.is_unset(request.target_version):
            body['targetVersion'] = request.target_version
        req = open_api_models.OpenApiRequest(
            headers=headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='RollBackVersion',
            version='miniapp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/miniapp/versions/rollback',
            method='POST',
            auth_type='Anonymous',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminiapp__1__0_models.RollBackVersionResponse(),
            self.execute(params, req, runtime)
        )

    async def roll_back_version_with_options_async(
        self,
        request: dingtalkminiapp__1__0_models.RollBackVersionRequest,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminiapp__1__0_models.RollBackVersionResponse:
        """
        @summary 回滚版本
        
        @param request: RollBackVersionRequest
        @param headers: map
        @param runtime: runtime options for this request RuntimeOptions
        @return: RollBackVersionResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.bundle_id):
            body['bundleId'] = request.bundle_id
        if not UtilClient.is_unset(request.mini_app_id):
            body['miniAppId'] = request.mini_app_id
        if not UtilClient.is_unset(request.rollback_version):
            body['rollbackVersion'] = request.rollback_version
        if not UtilClient.is_unset(request.target_version):
            body['targetVersion'] = request.target_version
        req = open_api_models.OpenApiRequest(
            headers=headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='RollBackVersion',
            version='miniapp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/miniapp/versions/rollback',
            method='POST',
            auth_type='Anonymous',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminiapp__1__0_models.RollBackVersionResponse(),
            await self.execute_async(params, req, runtime)
        )

    def roll_back_version(
        self,
        request: dingtalkminiapp__1__0_models.RollBackVersionRequest,
    ) -> dingtalkminiapp__1__0_models.RollBackVersionResponse:
        """
        @summary 回滚版本
        
        @param request: RollBackVersionRequest
        @return: RollBackVersionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = {}
        return self.roll_back_version_with_options(request, headers, runtime)

    async def roll_back_version_async(
        self,
        request: dingtalkminiapp__1__0_models.RollBackVersionRequest,
    ) -> dingtalkminiapp__1__0_models.RollBackVersionResponse:
        """
        @summary 回滚版本
        
        @param request: RollBackVersionRequest
        @return: RollBackVersionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = {}
        return await self.roll_back_version_with_options_async(request, headers, runtime)

    def set_extend_setting_with_options(
        self,
        request: dingtalkminiapp__1__0_models.SetExtendSettingRequest,
        headers: dingtalkminiapp__1__0_models.SetExtendSettingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminiapp__1__0_models.SetExtendSettingResponse:
        """
        @summary 修改小程序配置
        
        @param request: SetExtendSettingRequest
        @param headers: SetExtendSettingHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SetExtendSettingResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.build_h5bundle):
            body['buildH5Bundle'] = request.build_h5bundle
        if not UtilClient.is_unset(request.mini_app_id):
            body['miniAppId'] = request.mini_app_id
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
            action='SetExtendSetting',
            version='miniapp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/miniapp/apps/settings',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminiapp__1__0_models.SetExtendSettingResponse(),
            self.execute(params, req, runtime)
        )

    async def set_extend_setting_with_options_async(
        self,
        request: dingtalkminiapp__1__0_models.SetExtendSettingRequest,
        headers: dingtalkminiapp__1__0_models.SetExtendSettingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminiapp__1__0_models.SetExtendSettingResponse:
        """
        @summary 修改小程序配置
        
        @param request: SetExtendSettingRequest
        @param headers: SetExtendSettingHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SetExtendSettingResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.build_h5bundle):
            body['buildH5Bundle'] = request.build_h5bundle
        if not UtilClient.is_unset(request.mini_app_id):
            body['miniAppId'] = request.mini_app_id
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
            action='SetExtendSetting',
            version='miniapp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/miniapp/apps/settings',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminiapp__1__0_models.SetExtendSettingResponse(),
            await self.execute_async(params, req, runtime)
        )

    def set_extend_setting(
        self,
        request: dingtalkminiapp__1__0_models.SetExtendSettingRequest,
    ) -> dingtalkminiapp__1__0_models.SetExtendSettingResponse:
        """
        @summary 修改小程序配置
        
        @param request: SetExtendSettingRequest
        @return: SetExtendSettingResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminiapp__1__0_models.SetExtendSettingHeaders()
        return self.set_extend_setting_with_options(request, headers, runtime)

    async def set_extend_setting_async(
        self,
        request: dingtalkminiapp__1__0_models.SetExtendSettingRequest,
    ) -> dingtalkminiapp__1__0_models.SetExtendSettingResponse:
        """
        @summary 修改小程序配置
        
        @param request: SetExtendSettingRequest
        @return: SetExtendSettingResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminiapp__1__0_models.SetExtendSettingHeaders()
        return await self.set_extend_setting_with_options_async(request, headers, runtime)

    def update_version_status_with_options(
        self,
        request: dingtalkminiapp__1__0_models.UpdateVersionStatusRequest,
        headers: dingtalkminiapp__1__0_models.UpdateVersionStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminiapp__1__0_models.UpdateVersionStatusResponse:
        """
        @summary 发布版本
        
        @param request: UpdateVersionStatusRequest
        @param headers: UpdateVersionStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateVersionStatusResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.bundle_id):
            body['bundleId'] = request.bundle_id
        if not UtilClient.is_unset(request.mini_app_id):
            body['miniAppId'] = request.mini_app_id
        if not UtilClient.is_unset(request.version):
            body['version'] = request.version
        if not UtilClient.is_unset(request.version_type):
            body['versionType'] = request.version_type
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
            action='UpdateVersionStatus',
            version='miniapp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/miniapp/versions/status',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminiapp__1__0_models.UpdateVersionStatusResponse(),
            self.execute(params, req, runtime)
        )

    async def update_version_status_with_options_async(
        self,
        request: dingtalkminiapp__1__0_models.UpdateVersionStatusRequest,
        headers: dingtalkminiapp__1__0_models.UpdateVersionStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminiapp__1__0_models.UpdateVersionStatusResponse:
        """
        @summary 发布版本
        
        @param request: UpdateVersionStatusRequest
        @param headers: UpdateVersionStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateVersionStatusResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.bundle_id):
            body['bundleId'] = request.bundle_id
        if not UtilClient.is_unset(request.mini_app_id):
            body['miniAppId'] = request.mini_app_id
        if not UtilClient.is_unset(request.version):
            body['version'] = request.version
        if not UtilClient.is_unset(request.version_type):
            body['versionType'] = request.version_type
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
            action='UpdateVersionStatus',
            version='miniapp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/miniapp/versions/status',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminiapp__1__0_models.UpdateVersionStatusResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_version_status(
        self,
        request: dingtalkminiapp__1__0_models.UpdateVersionStatusRequest,
    ) -> dingtalkminiapp__1__0_models.UpdateVersionStatusResponse:
        """
        @summary 发布版本
        
        @param request: UpdateVersionStatusRequest
        @return: UpdateVersionStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminiapp__1__0_models.UpdateVersionStatusHeaders()
        return self.update_version_status_with_options(request, headers, runtime)

    async def update_version_status_async(
        self,
        request: dingtalkminiapp__1__0_models.UpdateVersionStatusRequest,
    ) -> dingtalkminiapp__1__0_models.UpdateVersionStatusResponse:
        """
        @summary 发布版本
        
        @param request: UpdateVersionStatusRequest
        @return: UpdateVersionStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminiapp__1__0_models.UpdateVersionStatusHeaders()
        return await self.update_version_status_with_options_async(request, headers, runtime)
