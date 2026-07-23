# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.aiot_1_0 import models as dingtalkaiot__1__0_models
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

    def check_device_update_with_options(
        self,
        product_key: str,
        device_name: str,
        request: dingtalkaiot__1__0_models.CheckDeviceUpdateRequest,
        headers: dingtalkaiot__1__0_models.CheckDeviceUpdateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkaiot__1__0_models.CheckDeviceUpdateResponse:
        """
        @summary 检查指定设备的固件升级
        
        @param request: CheckDeviceUpdateRequest
        @param headers: CheckDeviceUpdateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CheckDeviceUpdateResponse
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
            action='CheckDeviceUpdate',
            version='aiot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiot/products/{product_key}/devices/{device_name}/firmware/checkUpdate',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkaiot__1__0_models.CheckDeviceUpdateResponse(),
            self.execute(params, req, runtime)
        )

    async def check_device_update_with_options_async(
        self,
        product_key: str,
        device_name: str,
        request: dingtalkaiot__1__0_models.CheckDeviceUpdateRequest,
        headers: dingtalkaiot__1__0_models.CheckDeviceUpdateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkaiot__1__0_models.CheckDeviceUpdateResponse:
        """
        @summary 检查指定设备的固件升级
        
        @param request: CheckDeviceUpdateRequest
        @param headers: CheckDeviceUpdateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CheckDeviceUpdateResponse
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
            action='CheckDeviceUpdate',
            version='aiot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiot/products/{product_key}/devices/{device_name}/firmware/checkUpdate',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkaiot__1__0_models.CheckDeviceUpdateResponse(),
            await self.execute_async(params, req, runtime)
        )

    def check_device_update(
        self,
        product_key: str,
        device_name: str,
        request: dingtalkaiot__1__0_models.CheckDeviceUpdateRequest,
    ) -> dingtalkaiot__1__0_models.CheckDeviceUpdateResponse:
        """
        @summary 检查指定设备的固件升级
        
        @param request: CheckDeviceUpdateRequest
        @return: CheckDeviceUpdateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkaiot__1__0_models.CheckDeviceUpdateHeaders()
        return self.check_device_update_with_options(product_key, device_name, request, headers, runtime)

    async def check_device_update_async(
        self,
        product_key: str,
        device_name: str,
        request: dingtalkaiot__1__0_models.CheckDeviceUpdateRequest,
    ) -> dingtalkaiot__1__0_models.CheckDeviceUpdateResponse:
        """
        @summary 检查指定设备的固件升级
        
        @param request: CheckDeviceUpdateRequest
        @return: CheckDeviceUpdateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkaiot__1__0_models.CheckDeviceUpdateHeaders()
        return await self.check_device_update_with_options_async(product_key, device_name, request, headers, runtime)

    def confirm_firmware_upgrade_with_options(
        self,
        product_key: str,
        device_name: str,
        request: dingtalkaiot__1__0_models.ConfirmFirmwareUpgradeRequest,
        headers: dingtalkaiot__1__0_models.ConfirmFirmwareUpgradeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkaiot__1__0_models.ConfirmFirmwareUpgradeResponse:
        """
        @summary 确认执行设备固件升级
        
        @param request: ConfirmFirmwareUpgradeRequest
        @param headers: ConfirmFirmwareUpgradeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ConfirmFirmwareUpgradeResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.module_name):
            query['moduleName'] = request.module_name
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
            action='ConfirmFirmwareUpgrade',
            version='aiot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiot/products/{product_key}/devices/{device_name}/firmware/confirmUpgrade',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkaiot__1__0_models.ConfirmFirmwareUpgradeResponse(),
            self.execute(params, req, runtime)
        )

    async def confirm_firmware_upgrade_with_options_async(
        self,
        product_key: str,
        device_name: str,
        request: dingtalkaiot__1__0_models.ConfirmFirmwareUpgradeRequest,
        headers: dingtalkaiot__1__0_models.ConfirmFirmwareUpgradeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkaiot__1__0_models.ConfirmFirmwareUpgradeResponse:
        """
        @summary 确认执行设备固件升级
        
        @param request: ConfirmFirmwareUpgradeRequest
        @param headers: ConfirmFirmwareUpgradeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ConfirmFirmwareUpgradeResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.module_name):
            query['moduleName'] = request.module_name
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
            action='ConfirmFirmwareUpgrade',
            version='aiot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiot/products/{product_key}/devices/{device_name}/firmware/confirmUpgrade',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkaiot__1__0_models.ConfirmFirmwareUpgradeResponse(),
            await self.execute_async(params, req, runtime)
        )

    def confirm_firmware_upgrade(
        self,
        product_key: str,
        device_name: str,
        request: dingtalkaiot__1__0_models.ConfirmFirmwareUpgradeRequest,
    ) -> dingtalkaiot__1__0_models.ConfirmFirmwareUpgradeResponse:
        """
        @summary 确认执行设备固件升级
        
        @param request: ConfirmFirmwareUpgradeRequest
        @return: ConfirmFirmwareUpgradeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkaiot__1__0_models.ConfirmFirmwareUpgradeHeaders()
        return self.confirm_firmware_upgrade_with_options(product_key, device_name, request, headers, runtime)

    async def confirm_firmware_upgrade_async(
        self,
        product_key: str,
        device_name: str,
        request: dingtalkaiot__1__0_models.ConfirmFirmwareUpgradeRequest,
    ) -> dingtalkaiot__1__0_models.ConfirmFirmwareUpgradeResponse:
        """
        @summary 确认执行设备固件升级
        
        @param request: ConfirmFirmwareUpgradeRequest
        @return: ConfirmFirmwareUpgradeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkaiot__1__0_models.ConfirmFirmwareUpgradeHeaders()
        return await self.confirm_firmware_upgrade_with_options_async(product_key, device_name, request, headers, runtime)

    def get_device_detail_with_options(
        self,
        request: dingtalkaiot__1__0_models.GetDeviceDetailRequest,
        headers: dingtalkaiot__1__0_models.GetDeviceDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkaiot__1__0_models.GetDeviceDetailResponse:
        """
        @summary 查询指定设备的详情
        
        @param request: GetDeviceDetailRequest
        @param headers: GetDeviceDetailHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetDeviceDetailResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.device_name):
            query['deviceName'] = request.device_name
        if not UtilClient.is_unset(request.product_key):
            query['productKey'] = request.product_key
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
            action='GetDeviceDetail',
            version='aiot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiot/products/deviceDetail',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkaiot__1__0_models.GetDeviceDetailResponse(),
            self.execute(params, req, runtime)
        )

    async def get_device_detail_with_options_async(
        self,
        request: dingtalkaiot__1__0_models.GetDeviceDetailRequest,
        headers: dingtalkaiot__1__0_models.GetDeviceDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkaiot__1__0_models.GetDeviceDetailResponse:
        """
        @summary 查询指定设备的详情
        
        @param request: GetDeviceDetailRequest
        @param headers: GetDeviceDetailHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetDeviceDetailResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.device_name):
            query['deviceName'] = request.device_name
        if not UtilClient.is_unset(request.product_key):
            query['productKey'] = request.product_key
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
            action='GetDeviceDetail',
            version='aiot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiot/products/deviceDetail',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkaiot__1__0_models.GetDeviceDetailResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_device_detail(
        self,
        request: dingtalkaiot__1__0_models.GetDeviceDetailRequest,
    ) -> dingtalkaiot__1__0_models.GetDeviceDetailResponse:
        """
        @summary 查询指定设备的详情
        
        @param request: GetDeviceDetailRequest
        @return: GetDeviceDetailResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkaiot__1__0_models.GetDeviceDetailHeaders()
        return self.get_device_detail_with_options(request, headers, runtime)

    async def get_device_detail_async(
        self,
        request: dingtalkaiot__1__0_models.GetDeviceDetailRequest,
    ) -> dingtalkaiot__1__0_models.GetDeviceDetailResponse:
        """
        @summary 查询指定设备的详情
        
        @param request: GetDeviceDetailRequest
        @return: GetDeviceDetailResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkaiot__1__0_models.GetDeviceDetailHeaders()
        return await self.get_device_detail_with_options_async(request, headers, runtime)

    def get_device_properties_with_options(
        self,
        product_key: str,
        device_name: str,
        request: dingtalkaiot__1__0_models.GetDevicePropertiesRequest,
        headers: dingtalkaiot__1__0_models.GetDevicePropertiesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkaiot__1__0_models.GetDevicePropertiesResponse:
        """
        @summary 读取指定设备的属性快照
        
        @param request: GetDevicePropertiesRequest
        @param headers: GetDevicePropertiesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetDevicePropertiesResponse
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
            action='GetDeviceProperties',
            version='aiot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiot/products/{product_key}/devices/{device_name}/properties/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkaiot__1__0_models.GetDevicePropertiesResponse(),
            self.execute(params, req, runtime)
        )

    async def get_device_properties_with_options_async(
        self,
        product_key: str,
        device_name: str,
        request: dingtalkaiot__1__0_models.GetDevicePropertiesRequest,
        headers: dingtalkaiot__1__0_models.GetDevicePropertiesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkaiot__1__0_models.GetDevicePropertiesResponse:
        """
        @summary 读取指定设备的属性快照
        
        @param request: GetDevicePropertiesRequest
        @param headers: GetDevicePropertiesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetDevicePropertiesResponse
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
            action='GetDeviceProperties',
            version='aiot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiot/products/{product_key}/devices/{device_name}/properties/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkaiot__1__0_models.GetDevicePropertiesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_device_properties(
        self,
        product_key: str,
        device_name: str,
        request: dingtalkaiot__1__0_models.GetDevicePropertiesRequest,
    ) -> dingtalkaiot__1__0_models.GetDevicePropertiesResponse:
        """
        @summary 读取指定设备的属性快照
        
        @param request: GetDevicePropertiesRequest
        @return: GetDevicePropertiesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkaiot__1__0_models.GetDevicePropertiesHeaders()
        return self.get_device_properties_with_options(product_key, device_name, request, headers, runtime)

    async def get_device_properties_async(
        self,
        product_key: str,
        device_name: str,
        request: dingtalkaiot__1__0_models.GetDevicePropertiesRequest,
    ) -> dingtalkaiot__1__0_models.GetDevicePropertiesResponse:
        """
        @summary 读取指定设备的属性快照
        
        @param request: GetDevicePropertiesRequest
        @return: GetDevicePropertiesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkaiot__1__0_models.GetDevicePropertiesHeaders()
        return await self.get_device_properties_with_options_async(product_key, device_name, request, headers, runtime)

    def get_service_invocation_with_options(
        self,
        request: dingtalkaiot__1__0_models.GetServiceInvocationRequest,
        headers: dingtalkaiot__1__0_models.GetServiceInvocationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkaiot__1__0_models.GetServiceInvocationResponse:
        """
        @summary 查询设备服务调用结果
        
        @param request: GetServiceInvocationRequest
        @param headers: GetServiceInvocationHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetServiceInvocationResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.invocation_id):
            query['invocationId'] = request.invocation_id
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
            action='GetServiceInvocation',
            version='aiot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiot/serviceInvocations',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkaiot__1__0_models.GetServiceInvocationResponse(),
            self.execute(params, req, runtime)
        )

    async def get_service_invocation_with_options_async(
        self,
        request: dingtalkaiot__1__0_models.GetServiceInvocationRequest,
        headers: dingtalkaiot__1__0_models.GetServiceInvocationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkaiot__1__0_models.GetServiceInvocationResponse:
        """
        @summary 查询设备服务调用结果
        
        @param request: GetServiceInvocationRequest
        @param headers: GetServiceInvocationHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetServiceInvocationResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.invocation_id):
            query['invocationId'] = request.invocation_id
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
            action='GetServiceInvocation',
            version='aiot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiot/serviceInvocations',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkaiot__1__0_models.GetServiceInvocationResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_service_invocation(
        self,
        request: dingtalkaiot__1__0_models.GetServiceInvocationRequest,
    ) -> dingtalkaiot__1__0_models.GetServiceInvocationResponse:
        """
        @summary 查询设备服务调用结果
        
        @param request: GetServiceInvocationRequest
        @return: GetServiceInvocationResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkaiot__1__0_models.GetServiceInvocationHeaders()
        return self.get_service_invocation_with_options(request, headers, runtime)

    async def get_service_invocation_async(
        self,
        request: dingtalkaiot__1__0_models.GetServiceInvocationRequest,
    ) -> dingtalkaiot__1__0_models.GetServiceInvocationResponse:
        """
        @summary 查询设备服务调用结果
        
        @param request: GetServiceInvocationRequest
        @return: GetServiceInvocationResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkaiot__1__0_models.GetServiceInvocationHeaders()
        return await self.get_service_invocation_with_options_async(request, headers, runtime)

    def invoke_device_service_with_options(
        self,
        product_key: str,
        device_name: str,
        service_identifier: str,
        request: dingtalkaiot__1__0_models.InvokeDeviceServiceRequest,
        headers: dingtalkaiot__1__0_models.InvokeDeviceServiceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkaiot__1__0_models.InvokeDeviceServiceResponse:
        """
        @summary 调用指定设备的物模型服务
        
        @param request: InvokeDeviceServiceRequest
        @param headers: InvokeDeviceServiceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: InvokeDeviceServiceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.args):
            body['args'] = request.args
        if not UtilClient.is_unset(request.timeout_seconds):
            body['timeoutSeconds'] = request.timeout_seconds
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
            action='InvokeDeviceService',
            version='aiot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiot/products/{product_key}/devices/{device_name}/services/{service_identifier}/invoke',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkaiot__1__0_models.InvokeDeviceServiceResponse(),
            self.execute(params, req, runtime)
        )

    async def invoke_device_service_with_options_async(
        self,
        product_key: str,
        device_name: str,
        service_identifier: str,
        request: dingtalkaiot__1__0_models.InvokeDeviceServiceRequest,
        headers: dingtalkaiot__1__0_models.InvokeDeviceServiceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkaiot__1__0_models.InvokeDeviceServiceResponse:
        """
        @summary 调用指定设备的物模型服务
        
        @param request: InvokeDeviceServiceRequest
        @param headers: InvokeDeviceServiceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: InvokeDeviceServiceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.args):
            body['args'] = request.args
        if not UtilClient.is_unset(request.timeout_seconds):
            body['timeoutSeconds'] = request.timeout_seconds
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
            action='InvokeDeviceService',
            version='aiot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiot/products/{product_key}/devices/{device_name}/services/{service_identifier}/invoke',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkaiot__1__0_models.InvokeDeviceServiceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def invoke_device_service(
        self,
        product_key: str,
        device_name: str,
        service_identifier: str,
        request: dingtalkaiot__1__0_models.InvokeDeviceServiceRequest,
    ) -> dingtalkaiot__1__0_models.InvokeDeviceServiceResponse:
        """
        @summary 调用指定设备的物模型服务
        
        @param request: InvokeDeviceServiceRequest
        @return: InvokeDeviceServiceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkaiot__1__0_models.InvokeDeviceServiceHeaders()
        return self.invoke_device_service_with_options(product_key, device_name, service_identifier, request, headers, runtime)

    async def invoke_device_service_async(
        self,
        product_key: str,
        device_name: str,
        service_identifier: str,
        request: dingtalkaiot__1__0_models.InvokeDeviceServiceRequest,
    ) -> dingtalkaiot__1__0_models.InvokeDeviceServiceResponse:
        """
        @summary 调用指定设备的物模型服务
        
        @param request: InvokeDeviceServiceRequest
        @return: InvokeDeviceServiceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkaiot__1__0_models.InvokeDeviceServiceHeaders()
        return await self.invoke_device_service_with_options_async(product_key, device_name, service_identifier, request, headers, runtime)

    def set_device_properties_with_options(
        self,
        product_key: str,
        device_name: str,
        request: dingtalkaiot__1__0_models.SetDevicePropertiesRequest,
        headers: dingtalkaiot__1__0_models.SetDevicePropertiesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkaiot__1__0_models.SetDevicePropertiesResponse:
        """
        @summary 设置指定设备的属性
        
        @param request: SetDevicePropertiesRequest
        @param headers: SetDevicePropertiesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SetDevicePropertiesResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.body):
            body['body'] = request.body
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
            action='SetDeviceProperties',
            version='aiot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiot/products/{product_key}/devices/{device_name}/properties',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkaiot__1__0_models.SetDevicePropertiesResponse(),
            self.execute(params, req, runtime)
        )

    async def set_device_properties_with_options_async(
        self,
        product_key: str,
        device_name: str,
        request: dingtalkaiot__1__0_models.SetDevicePropertiesRequest,
        headers: dingtalkaiot__1__0_models.SetDevicePropertiesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkaiot__1__0_models.SetDevicePropertiesResponse:
        """
        @summary 设置指定设备的属性
        
        @param request: SetDevicePropertiesRequest
        @param headers: SetDevicePropertiesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SetDevicePropertiesResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.body):
            body['body'] = request.body
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
            action='SetDeviceProperties',
            version='aiot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiot/products/{product_key}/devices/{device_name}/properties',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkaiot__1__0_models.SetDevicePropertiesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def set_device_properties(
        self,
        product_key: str,
        device_name: str,
        request: dingtalkaiot__1__0_models.SetDevicePropertiesRequest,
    ) -> dingtalkaiot__1__0_models.SetDevicePropertiesResponse:
        """
        @summary 设置指定设备的属性
        
        @param request: SetDevicePropertiesRequest
        @return: SetDevicePropertiesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkaiot__1__0_models.SetDevicePropertiesHeaders()
        return self.set_device_properties_with_options(product_key, device_name, request, headers, runtime)

    async def set_device_properties_async(
        self,
        product_key: str,
        device_name: str,
        request: dingtalkaiot__1__0_models.SetDevicePropertiesRequest,
    ) -> dingtalkaiot__1__0_models.SetDevicePropertiesResponse:
        """
        @summary 设置指定设备的属性
        
        @param request: SetDevicePropertiesRequest
        @return: SetDevicePropertiesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkaiot__1__0_models.SetDevicePropertiesHeaders()
        return await self.set_device_properties_with_options_async(product_key, device_name, request, headers, runtime)
