# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.esign_1_0 import models as dingtalkesign__1__0_models
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

    def auth_url_with_options(
        self,
        request: dingtalkesign__1__0_models.AuthUrlRequest,
        headers: dingtalkesign__1__0_models.AuthUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkesign__1__0_models.AuthUrlResponse:
        """
        @summary 获取授权的页面地址
        
        @param request: AuthUrlRequest
        @param headers: AuthUrlHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AuthUrlResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.redirect_url):
            body['redirectUrl'] = request.redirect_url
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
            action='AuthUrl',
            version='esign_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/esign/auths/url',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkesign__1__0_models.AuthUrlResponse(),
            self.execute(params, req, runtime)
        )

    async def auth_url_with_options_async(
        self,
        request: dingtalkesign__1__0_models.AuthUrlRequest,
        headers: dingtalkesign__1__0_models.AuthUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkesign__1__0_models.AuthUrlResponse:
        """
        @summary 获取授权的页面地址
        
        @param request: AuthUrlRequest
        @param headers: AuthUrlHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AuthUrlResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.redirect_url):
            body['redirectUrl'] = request.redirect_url
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
            action='AuthUrl',
            version='esign_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/esign/auths/url',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkesign__1__0_models.AuthUrlResponse(),
            await self.execute_async(params, req, runtime)
        )

    def auth_url(
        self,
        request: dingtalkesign__1__0_models.AuthUrlRequest,
    ) -> dingtalkesign__1__0_models.AuthUrlResponse:
        """
        @summary 获取授权的页面地址
        
        @param request: AuthUrlRequest
        @return: AuthUrlResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkesign__1__0_models.AuthUrlHeaders()
        return self.auth_url_with_options(request, headers, runtime)

    async def auth_url_async(
        self,
        request: dingtalkesign__1__0_models.AuthUrlRequest,
    ) -> dingtalkesign__1__0_models.AuthUrlResponse:
        """
        @summary 获取授权的页面地址
        
        @param request: AuthUrlRequest
        @return: AuthUrlResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkesign__1__0_models.AuthUrlHeaders()
        return await self.auth_url_with_options_async(request, headers, runtime)

    def cancel_corp_auth_with_options(
        self,
        headers: dingtalkesign__1__0_models.CancelCorpAuthHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkesign__1__0_models.CancelCorpAuthResponse:
        """
        @summary 取消企业的授权
        
        @param headers: CancelCorpAuthHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CancelCorpAuthResponse
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
            action='CancelCorpAuth',
            version='esign_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/esign/corps/auth/cancel',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkesign__1__0_models.CancelCorpAuthResponse(),
            self.execute(params, req, runtime)
        )

    async def cancel_corp_auth_with_options_async(
        self,
        headers: dingtalkesign__1__0_models.CancelCorpAuthHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkesign__1__0_models.CancelCorpAuthResponse:
        """
        @summary 取消企业的授权
        
        @param headers: CancelCorpAuthHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CancelCorpAuthResponse
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
            action='CancelCorpAuth',
            version='esign_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/esign/corps/auth/cancel',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkesign__1__0_models.CancelCorpAuthResponse(),
            await self.execute_async(params, req, runtime)
        )

    def cancel_corp_auth(self) -> dingtalkesign__1__0_models.CancelCorpAuthResponse:
        """
        @summary 取消企业的授权
        
        @return: CancelCorpAuthResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkesign__1__0_models.CancelCorpAuthHeaders()
        return self.cancel_corp_auth_with_options(headers, runtime)

    async def cancel_corp_auth_async(self) -> dingtalkesign__1__0_models.CancelCorpAuthResponse:
        """
        @summary 取消企业的授权
        
        @return: CancelCorpAuthResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkesign__1__0_models.CancelCorpAuthHeaders()
        return await self.cancel_corp_auth_with_options_async(headers, runtime)

    def channel_order_with_options(
        self,
        request: dingtalkesign__1__0_models.ChannelOrderRequest,
        headers: dingtalkesign__1__0_models.ChannelOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkesign__1__0_models.ChannelOrderResponse:
        """
        @summary 套餐转售1（分润模式）
        
        @param request: ChannelOrderRequest
        @param headers: ChannelOrderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ChannelOrderResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.item_code):
            body['itemCode'] = request.item_code
        if not UtilClient.is_unset(request.item_name):
            body['itemName'] = request.item_name
        if not UtilClient.is_unset(request.order_create_time):
            body['orderCreateTime'] = request.order_create_time
        if not UtilClient.is_unset(request.order_id):
            body['orderId'] = request.order_id
        if not UtilClient.is_unset(request.pay_fee):
            body['payFee'] = request.pay_fee
        if not UtilClient.is_unset(request.quantity):
            body['quantity'] = request.quantity
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
            action='ChannelOrder',
            version='esign_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/esign/orders/channel',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkesign__1__0_models.ChannelOrderResponse(),
            self.execute(params, req, runtime)
        )

    async def channel_order_with_options_async(
        self,
        request: dingtalkesign__1__0_models.ChannelOrderRequest,
        headers: dingtalkesign__1__0_models.ChannelOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkesign__1__0_models.ChannelOrderResponse:
        """
        @summary 套餐转售1（分润模式）
        
        @param request: ChannelOrderRequest
        @param headers: ChannelOrderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ChannelOrderResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.item_code):
            body['itemCode'] = request.item_code
        if not UtilClient.is_unset(request.item_name):
            body['itemName'] = request.item_name
        if not UtilClient.is_unset(request.order_create_time):
            body['orderCreateTime'] = request.order_create_time
        if not UtilClient.is_unset(request.order_id):
            body['orderId'] = request.order_id
        if not UtilClient.is_unset(request.pay_fee):
            body['payFee'] = request.pay_fee
        if not UtilClient.is_unset(request.quantity):
            body['quantity'] = request.quantity
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
            action='ChannelOrder',
            version='esign_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/esign/orders/channel',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkesign__1__0_models.ChannelOrderResponse(),
            await self.execute_async(params, req, runtime)
        )

    def channel_order(
        self,
        request: dingtalkesign__1__0_models.ChannelOrderRequest,
    ) -> dingtalkesign__1__0_models.ChannelOrderResponse:
        """
        @summary 套餐转售1（分润模式）
        
        @param request: ChannelOrderRequest
        @return: ChannelOrderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkesign__1__0_models.ChannelOrderHeaders()
        return self.channel_order_with_options(request, headers, runtime)

    async def channel_order_async(
        self,
        request: dingtalkesign__1__0_models.ChannelOrderRequest,
    ) -> dingtalkesign__1__0_models.ChannelOrderResponse:
        """
        @summary 套餐转售1（分润模式）
        
        @param request: ChannelOrderRequest
        @return: ChannelOrderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkesign__1__0_models.ChannelOrderHeaders()
        return await self.channel_order_with_options_async(request, headers, runtime)

    def contract_margin_with_options(
        self,
        headers: dingtalkesign__1__0_models.ContractMarginHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkesign__1__0_models.ContractMarginResponse:
        """
        @summary 查询套餐余量
        
        @param headers: ContractMarginHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ContractMarginResponse
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
            action='ContractMargin',
            version='esign_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/esign/contracts/margin',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkesign__1__0_models.ContractMarginResponse(),
            self.execute(params, req, runtime)
        )

    async def contract_margin_with_options_async(
        self,
        headers: dingtalkesign__1__0_models.ContractMarginHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkesign__1__0_models.ContractMarginResponse:
        """
        @summary 查询套餐余量
        
        @param headers: ContractMarginHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ContractMarginResponse
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
            action='ContractMargin',
            version='esign_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/esign/contracts/margin',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkesign__1__0_models.ContractMarginResponse(),
            await self.execute_async(params, req, runtime)
        )

    def contract_margin(self) -> dingtalkesign__1__0_models.ContractMarginResponse:
        """
        @summary 查询套餐余量
        
        @return: ContractMarginResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkesign__1__0_models.ContractMarginHeaders()
        return self.contract_margin_with_options(headers, runtime)

    async def contract_margin_async(self) -> dingtalkesign__1__0_models.ContractMarginResponse:
        """
        @summary 查询套餐余量
        
        @return: ContractMarginResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkesign__1__0_models.ContractMarginHeaders()
        return await self.contract_margin_with_options_async(headers, runtime)

    def corp_console_with_options(
        self,
        headers: dingtalkesign__1__0_models.CorpConsoleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkesign__1__0_models.CorpConsoleResponse:
        """
        @summary 查询个人信息
        
        @param headers: CorpConsoleHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CorpConsoleResponse
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
            action='CorpConsole',
            version='esign_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/esign/corps/console',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkesign__1__0_models.CorpConsoleResponse(),
            self.execute(params, req, runtime)
        )

    async def corp_console_with_options_async(
        self,
        headers: dingtalkesign__1__0_models.CorpConsoleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkesign__1__0_models.CorpConsoleResponse:
        """
        @summary 查询个人信息
        
        @param headers: CorpConsoleHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CorpConsoleResponse
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
            action='CorpConsole',
            version='esign_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/esign/corps/console',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkesign__1__0_models.CorpConsoleResponse(),
            await self.execute_async(params, req, runtime)
        )

    def corp_console(self) -> dingtalkesign__1__0_models.CorpConsoleResponse:
        """
        @summary 查询个人信息
        
        @return: CorpConsoleResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkesign__1__0_models.CorpConsoleHeaders()
        return self.corp_console_with_options(headers, runtime)

    async def corp_console_async(self) -> dingtalkesign__1__0_models.CorpConsoleResponse:
        """
        @summary 查询个人信息
        
        @return: CorpConsoleResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkesign__1__0_models.CorpConsoleHeaders()
        return await self.corp_console_with_options_async(headers, runtime)

    def corp_info_with_options(
        self,
        headers: dingtalkesign__1__0_models.CorpInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkesign__1__0_models.CorpInfoResponse:
        """
        @summary 查询企业信息
        
        @param headers: CorpInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CorpInfoResponse
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
            action='CorpInfo',
            version='esign_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/esign/corps/info',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkesign__1__0_models.CorpInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def corp_info_with_options_async(
        self,
        headers: dingtalkesign__1__0_models.CorpInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkesign__1__0_models.CorpInfoResponse:
        """
        @summary 查询企业信息
        
        @param headers: CorpInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CorpInfoResponse
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
            action='CorpInfo',
            version='esign_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/esign/corps/info',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkesign__1__0_models.CorpInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def corp_info(self) -> dingtalkesign__1__0_models.CorpInfoResponse:
        """
        @summary 查询企业信息
        
        @return: CorpInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkesign__1__0_models.CorpInfoHeaders()
        return self.corp_info_with_options(headers, runtime)

    async def corp_info_async(self) -> dingtalkesign__1__0_models.CorpInfoResponse:
        """
        @summary 查询企业信息
        
        @return: CorpInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkesign__1__0_models.CorpInfoHeaders()
        return await self.corp_info_with_options_async(headers, runtime)

    def create_developer_with_options(
        self,
        request: dingtalkesign__1__0_models.CreateDeveloperRequest,
        headers: dingtalkesign__1__0_models.CreateDeveloperHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkesign__1__0_models.CreateDeveloperResponse:
        """
        @summary 钉钉ISV服务商的数据初始化
        
        @param request: CreateDeveloperRequest
        @param headers: CreateDeveloperHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateDeveloperResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.redirect_url):
            body['redirectUrl'] = request.redirect_url
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
            action='CreateDeveloper',
            version='esign_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/esign/developers/create',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkesign__1__0_models.CreateDeveloperResponse(),
            self.execute(params, req, runtime)
        )

    async def create_developer_with_options_async(
        self,
        request: dingtalkesign__1__0_models.CreateDeveloperRequest,
        headers: dingtalkesign__1__0_models.CreateDeveloperHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkesign__1__0_models.CreateDeveloperResponse:
        """
        @summary 钉钉ISV服务商的数据初始化
        
        @param request: CreateDeveloperRequest
        @param headers: CreateDeveloperHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateDeveloperResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.redirect_url):
            body['redirectUrl'] = request.redirect_url
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
            action='CreateDeveloper',
            version='esign_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/esign/developers/create',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkesign__1__0_models.CreateDeveloperResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_developer(
        self,
        request: dingtalkesign__1__0_models.CreateDeveloperRequest,
    ) -> dingtalkesign__1__0_models.CreateDeveloperResponse:
        """
        @summary 钉钉ISV服务商的数据初始化
        
        @param request: CreateDeveloperRequest
        @return: CreateDeveloperResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkesign__1__0_models.CreateDeveloperHeaders()
        return self.create_developer_with_options(request, headers, runtime)

    async def create_developer_async(
        self,
        request: dingtalkesign__1__0_models.CreateDeveloperRequest,
    ) -> dingtalkesign__1__0_models.CreateDeveloperResponse:
        """
        @summary 钉钉ISV服务商的数据初始化
        
        @param request: CreateDeveloperRequest
        @return: CreateDeveloperResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkesign__1__0_models.CreateDeveloperHeaders()
        return await self.create_developer_with_options_async(request, headers, runtime)

    def get_corp_realname_url_with_options(
        self,
        request: dingtalkesign__1__0_models.GetCorpRealnameUrlRequest,
        headers: dingtalkesign__1__0_models.GetCorpRealnameUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkesign__1__0_models.GetCorpRealnameUrlResponse:
        """
        @summary 获取跳转到个人实名的地址
        
        @param request: GetCorpRealnameUrlRequest
        @param headers: GetCorpRealnameUrlHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetCorpRealnameUrlResponse
        """
        UtilClient.validate_model(request)
        body = {}
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
            action='GetCorpRealnameUrl',
            version='esign_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/esign/corps/realname',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkesign__1__0_models.GetCorpRealnameUrlResponse(),
            self.execute(params, req, runtime)
        )

    async def get_corp_realname_url_with_options_async(
        self,
        request: dingtalkesign__1__0_models.GetCorpRealnameUrlRequest,
        headers: dingtalkesign__1__0_models.GetCorpRealnameUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkesign__1__0_models.GetCorpRealnameUrlResponse:
        """
        @summary 获取跳转到个人实名的地址
        
        @param request: GetCorpRealnameUrlRequest
        @param headers: GetCorpRealnameUrlHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetCorpRealnameUrlResponse
        """
        UtilClient.validate_model(request)
        body = {}
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
            action='GetCorpRealnameUrl',
            version='esign_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/esign/corps/realname',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkesign__1__0_models.GetCorpRealnameUrlResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_corp_realname_url(
        self,
        request: dingtalkesign__1__0_models.GetCorpRealnameUrlRequest,
    ) -> dingtalkesign__1__0_models.GetCorpRealnameUrlResponse:
        """
        @summary 获取跳转到个人实名的地址
        
        @param request: GetCorpRealnameUrlRequest
        @return: GetCorpRealnameUrlResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkesign__1__0_models.GetCorpRealnameUrlHeaders()
        return self.get_corp_realname_url_with_options(request, headers, runtime)

    async def get_corp_realname_url_async(
        self,
        request: dingtalkesign__1__0_models.GetCorpRealnameUrlRequest,
    ) -> dingtalkesign__1__0_models.GetCorpRealnameUrlResponse:
        """
        @summary 获取跳转到个人实名的地址
        
        @param request: GetCorpRealnameUrlRequest
        @return: GetCorpRealnameUrlResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkesign__1__0_models.GetCorpRealnameUrlHeaders()
        return await self.get_corp_realname_url_with_options_async(request, headers, runtime)

    def get_crop_status_with_options(
        self,
        headers: dingtalkesign__1__0_models.GetCropStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkesign__1__0_models.GetCropStatusResponse:
        """
        @summary 获取企业e签宝微应用状态
        
        @param headers: GetCropStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetCropStatusResponse
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
            action='GetCropStatus',
            version='esign_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/esign/corps/statuses',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkesign__1__0_models.GetCropStatusResponse(),
            self.execute(params, req, runtime)
        )

    async def get_crop_status_with_options_async(
        self,
        headers: dingtalkesign__1__0_models.GetCropStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkesign__1__0_models.GetCropStatusResponse:
        """
        @summary 获取企业e签宝微应用状态
        
        @param headers: GetCropStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetCropStatusResponse
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
            action='GetCropStatus',
            version='esign_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/esign/corps/statuses',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkesign__1__0_models.GetCropStatusResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_crop_status(self) -> dingtalkesign__1__0_models.GetCropStatusResponse:
        """
        @summary 获取企业e签宝微应用状态
        
        @return: GetCropStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkesign__1__0_models.GetCropStatusHeaders()
        return self.get_crop_status_with_options(headers, runtime)

    async def get_crop_status_async(self) -> dingtalkesign__1__0_models.GetCropStatusResponse:
        """
        @summary 获取企业e签宝微应用状态
        
        @return: GetCropStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkesign__1__0_models.GetCropStatusHeaders()
        return await self.get_crop_status_with_options_async(headers, runtime)

    def get_file_with_options(
        self,
        file_id: str,
        headers: dingtalkesign__1__0_models.GetFileHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkesign__1__0_models.GetFileResponse:
        """
        @summary 查询文件详情/下载文件
        
        @param headers: GetFileHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetFileResponse
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
            action='GetFile',
            version='esign_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/esign/files/{file_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkesign__1__0_models.GetFileResponse(),
            self.execute(params, req, runtime)
        )

    async def get_file_with_options_async(
        self,
        file_id: str,
        headers: dingtalkesign__1__0_models.GetFileHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkesign__1__0_models.GetFileResponse:
        """
        @summary 查询文件详情/下载文件
        
        @param headers: GetFileHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetFileResponse
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
            action='GetFile',
            version='esign_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/esign/files/{file_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkesign__1__0_models.GetFileResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_file(
        self,
        file_id: str,
    ) -> dingtalkesign__1__0_models.GetFileResponse:
        """
        @summary 查询文件详情/下载文件
        
        @return: GetFileResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkesign__1__0_models.GetFileHeaders()
        return self.get_file_with_options(file_id, headers, runtime)

    async def get_file_async(
        self,
        file_id: str,
    ) -> dingtalkesign__1__0_models.GetFileResponse:
        """
        @summary 查询文件详情/下载文件
        
        @return: GetFileResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkesign__1__0_models.GetFileHeaders()
        return await self.get_file_with_options_async(file_id, headers, runtime)

    def get_flow_detail_with_options(
        self,
        request: dingtalkesign__1__0_models.GetFlowDetailRequest,
        headers: dingtalkesign__1__0_models.GetFlowDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkesign__1__0_models.GetFlowDetailResponse:
        """
        @summary 获取对应流程任务详情
        
        @param request: GetFlowDetailRequest
        @param headers: GetFlowDetailHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetFlowDetailResponse
        """
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
        params = open_api_models.Params(
            action='GetFlowDetail',
            version='esign_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/esign/flows/detail',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkesign__1__0_models.GetFlowDetailResponse(),
            self.execute(params, req, runtime)
        )

    async def get_flow_detail_with_options_async(
        self,
        request: dingtalkesign__1__0_models.GetFlowDetailRequest,
        headers: dingtalkesign__1__0_models.GetFlowDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkesign__1__0_models.GetFlowDetailResponse:
        """
        @summary 获取对应流程任务详情
        
        @param request: GetFlowDetailRequest
        @param headers: GetFlowDetailHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetFlowDetailResponse
        """
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
        params = open_api_models.Params(
            action='GetFlowDetail',
            version='esign_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/esign/flows/detail',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkesign__1__0_models.GetFlowDetailResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_flow_detail(
        self,
        request: dingtalkesign__1__0_models.GetFlowDetailRequest,
    ) -> dingtalkesign__1__0_models.GetFlowDetailResponse:
        """
        @summary 获取对应流程任务详情
        
        @param request: GetFlowDetailRequest
        @return: GetFlowDetailResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkesign__1__0_models.GetFlowDetailHeaders()
        return self.get_flow_detail_with_options(request, headers, runtime)

    async def get_flow_detail_async(
        self,
        request: dingtalkesign__1__0_models.GetFlowDetailRequest,
    ) -> dingtalkesign__1__0_models.GetFlowDetailResponse:
        """
        @summary 获取对应流程任务详情
        
        @param request: GetFlowDetailRequest
        @return: GetFlowDetailResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkesign__1__0_models.GetFlowDetailHeaders()
        return await self.get_flow_detail_with_options_async(request, headers, runtime)

    def get_flow_sign_detail_with_options(
        self,
        request: dingtalkesign__1__0_models.GetFlowSignDetailRequest,
        headers: dingtalkesign__1__0_models.GetFlowSignDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkesign__1__0_models.GetFlowSignDetailResponse:
        """
        @summary 获取对应流程任务详情
        
        @param request: GetFlowSignDetailRequest
        @param headers: GetFlowSignDetailHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetFlowSignDetailResponse
        """
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
        params = open_api_models.Params(
            action='GetFlowSignDetail',
            version='esign_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/esign/flows/sign/detail',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkesign__1__0_models.GetFlowSignDetailResponse(),
            self.execute(params, req, runtime)
        )

    async def get_flow_sign_detail_with_options_async(
        self,
        request: dingtalkesign__1__0_models.GetFlowSignDetailRequest,
        headers: dingtalkesign__1__0_models.GetFlowSignDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkesign__1__0_models.GetFlowSignDetailResponse:
        """
        @summary 获取对应流程任务详情
        
        @param request: GetFlowSignDetailRequest
        @param headers: GetFlowSignDetailHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetFlowSignDetailResponse
        """
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
        params = open_api_models.Params(
            action='GetFlowSignDetail',
            version='esign_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/esign/flows/sign/detail',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkesign__1__0_models.GetFlowSignDetailResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_flow_sign_detail(
        self,
        request: dingtalkesign__1__0_models.GetFlowSignDetailRequest,
    ) -> dingtalkesign__1__0_models.GetFlowSignDetailResponse:
        """
        @summary 获取对应流程任务详情
        
        @param request: GetFlowSignDetailRequest
        @return: GetFlowSignDetailResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkesign__1__0_models.GetFlowSignDetailHeaders()
        return self.get_flow_sign_detail_with_options(request, headers, runtime)

    async def get_flow_sign_detail_async(
        self,
        request: dingtalkesign__1__0_models.GetFlowSignDetailRequest,
    ) -> dingtalkesign__1__0_models.GetFlowSignDetailResponse:
        """
        @summary 获取对应流程任务详情
        
        @param request: GetFlowSignDetailRequest
        @return: GetFlowSignDetailResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkesign__1__0_models.GetFlowSignDetailHeaders()
        return await self.get_flow_sign_detail_with_options_async(request, headers, runtime)

    def get_process_start_url_with_options(
        self,
        request: dingtalkesign__1__0_models.GetProcessStartUrlRequest,
        headers: dingtalkesign__1__0_models.GetProcessStartUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkesign__1__0_models.GetProcessStartUrlResponse:
        """
        @summary 发起签署的地址
        
        @param request: GetProcessStartUrlRequest
        @param headers: GetProcessStartUrlHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetProcessStartUrlResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.ccs):
            body['ccs'] = request.ccs
        if not UtilClient.is_unset(request.files):
            body['files'] = request.files
        if not UtilClient.is_unset(request.initiator_user_id):
            body['initiatorUserId'] = request.initiator_user_id
        if not UtilClient.is_unset(request.participants):
            body['participants'] = request.participants
        if not UtilClient.is_unset(request.redirect_url):
            body['redirectUrl'] = request.redirect_url
        if not UtilClient.is_unset(request.source_info):
            body['sourceInfo'] = request.source_info
        if not UtilClient.is_unset(request.task_name):
            body['taskName'] = request.task_name
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
            action='GetProcessStartUrl',
            version='esign_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/esign/process/start',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkesign__1__0_models.GetProcessStartUrlResponse(),
            self.execute(params, req, runtime)
        )

    async def get_process_start_url_with_options_async(
        self,
        request: dingtalkesign__1__0_models.GetProcessStartUrlRequest,
        headers: dingtalkesign__1__0_models.GetProcessStartUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkesign__1__0_models.GetProcessStartUrlResponse:
        """
        @summary 发起签署的地址
        
        @param request: GetProcessStartUrlRequest
        @param headers: GetProcessStartUrlHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetProcessStartUrlResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.ccs):
            body['ccs'] = request.ccs
        if not UtilClient.is_unset(request.files):
            body['files'] = request.files
        if not UtilClient.is_unset(request.initiator_user_id):
            body['initiatorUserId'] = request.initiator_user_id
        if not UtilClient.is_unset(request.participants):
            body['participants'] = request.participants
        if not UtilClient.is_unset(request.redirect_url):
            body['redirectUrl'] = request.redirect_url
        if not UtilClient.is_unset(request.source_info):
            body['sourceInfo'] = request.source_info
        if not UtilClient.is_unset(request.task_name):
            body['taskName'] = request.task_name
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
            action='GetProcessStartUrl',
            version='esign_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/esign/process/start',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkesign__1__0_models.GetProcessStartUrlResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_process_start_url(
        self,
        request: dingtalkesign__1__0_models.GetProcessStartUrlRequest,
    ) -> dingtalkesign__1__0_models.GetProcessStartUrlResponse:
        """
        @summary 发起签署的地址
        
        @param request: GetProcessStartUrlRequest
        @return: GetProcessStartUrlResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkesign__1__0_models.GetProcessStartUrlHeaders()
        return self.get_process_start_url_with_options(request, headers, runtime)

    async def get_process_start_url_async(
        self,
        request: dingtalkesign__1__0_models.GetProcessStartUrlRequest,
    ) -> dingtalkesign__1__0_models.GetProcessStartUrlResponse:
        """
        @summary 发起签署的地址
        
        @param request: GetProcessStartUrlRequest
        @return: GetProcessStartUrlResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkesign__1__0_models.GetProcessStartUrlHeaders()
        return await self.get_process_start_url_with_options_async(request, headers, runtime)

    def get_sign_notice_url_with_options(
        self,
        request: dingtalkesign__1__0_models.GetSignNoticeUrlRequest,
        headers: dingtalkesign__1__0_models.GetSignNoticeUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkesign__1__0_models.GetSignNoticeUrlResponse:
        """
        @summary 获取签署人签署地址
        
        @param request: GetSignNoticeUrlRequest
        @param headers: GetSignNoticeUrlHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSignNoticeUrlResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.task_id):
            body['taskId'] = request.task_id
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
            action='GetSignNoticeUrl',
            version='esign_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/esign/signs/notice/url',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkesign__1__0_models.GetSignNoticeUrlResponse(),
            self.execute(params, req, runtime)
        )

    async def get_sign_notice_url_with_options_async(
        self,
        request: dingtalkesign__1__0_models.GetSignNoticeUrlRequest,
        headers: dingtalkesign__1__0_models.GetSignNoticeUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkesign__1__0_models.GetSignNoticeUrlResponse:
        """
        @summary 获取签署人签署地址
        
        @param request: GetSignNoticeUrlRequest
        @param headers: GetSignNoticeUrlHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSignNoticeUrlResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.task_id):
            body['taskId'] = request.task_id
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
            action='GetSignNoticeUrl',
            version='esign_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/esign/signs/notice/url',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkesign__1__0_models.GetSignNoticeUrlResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_sign_notice_url(
        self,
        request: dingtalkesign__1__0_models.GetSignNoticeUrlRequest,
    ) -> dingtalkesign__1__0_models.GetSignNoticeUrlResponse:
        """
        @summary 获取签署人签署地址
        
        @param request: GetSignNoticeUrlRequest
        @return: GetSignNoticeUrlResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkesign__1__0_models.GetSignNoticeUrlHeaders()
        return self.get_sign_notice_url_with_options(request, headers, runtime)

    async def get_sign_notice_url_async(
        self,
        request: dingtalkesign__1__0_models.GetSignNoticeUrlRequest,
    ) -> dingtalkesign__1__0_models.GetSignNoticeUrlResponse:
        """
        @summary 获取签署人签署地址
        
        @param request: GetSignNoticeUrlRequest
        @return: GetSignNoticeUrlResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkesign__1__0_models.GetSignNoticeUrlHeaders()
        return await self.get_sign_notice_url_with_options_async(request, headers, runtime)

    def get_upload_url_with_options(
        self,
        request: dingtalkesign__1__0_models.GetUploadUrlRequest,
        headers: dingtalkesign__1__0_models.GetUploadUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkesign__1__0_models.GetUploadUrlResponse:
        """
        @summary 通过上传方式创建文件
        
        @param request: GetUploadUrlRequest
        @param headers: GetUploadUrlHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetUploadUrlResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.content_md_5):
            body['contentMd5'] = request.content_md_5
        if not UtilClient.is_unset(request.content_type):
            body['contentType'] = request.content_type
        if not UtilClient.is_unset(request.convert_2pdf):
            body['convert2Pdf'] = request.convert_2pdf
        if not UtilClient.is_unset(request.file_name):
            body['fileName'] = request.file_name
        if not UtilClient.is_unset(request.file_size):
            body['fileSize'] = request.file_size
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
            action='GetUploadUrl',
            version='esign_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/esign/files/getUploadUrl',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkesign__1__0_models.GetUploadUrlResponse(),
            self.execute(params, req, runtime)
        )

    async def get_upload_url_with_options_async(
        self,
        request: dingtalkesign__1__0_models.GetUploadUrlRequest,
        headers: dingtalkesign__1__0_models.GetUploadUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkesign__1__0_models.GetUploadUrlResponse:
        """
        @summary 通过上传方式创建文件
        
        @param request: GetUploadUrlRequest
        @param headers: GetUploadUrlHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetUploadUrlResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.content_md_5):
            body['contentMd5'] = request.content_md_5
        if not UtilClient.is_unset(request.content_type):
            body['contentType'] = request.content_type
        if not UtilClient.is_unset(request.convert_2pdf):
            body['convert2Pdf'] = request.convert_2pdf
        if not UtilClient.is_unset(request.file_name):
            body['fileName'] = request.file_name
        if not UtilClient.is_unset(request.file_size):
            body['fileSize'] = request.file_size
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
            action='GetUploadUrl',
            version='esign_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/esign/files/getUploadUrl',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkesign__1__0_models.GetUploadUrlResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_upload_url(
        self,
        request: dingtalkesign__1__0_models.GetUploadUrlRequest,
    ) -> dingtalkesign__1__0_models.GetUploadUrlResponse:
        """
        @summary 通过上传方式创建文件
        
        @param request: GetUploadUrlRequest
        @return: GetUploadUrlResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkesign__1__0_models.GetUploadUrlHeaders()
        return self.get_upload_url_with_options(request, headers, runtime)

    async def get_upload_url_async(
        self,
        request: dingtalkesign__1__0_models.GetUploadUrlRequest,
    ) -> dingtalkesign__1__0_models.GetUploadUrlResponse:
        """
        @summary 通过上传方式创建文件
        
        @param request: GetUploadUrlRequest
        @return: GetUploadUrlResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkesign__1__0_models.GetUploadUrlHeaders()
        return await self.get_upload_url_with_options_async(request, headers, runtime)

    def get_user_info_with_options(
        self,
        user_id: str,
        headers: dingtalkesign__1__0_models.GetUserInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkesign__1__0_models.GetUserInfoResponse:
        """
        @summary 查询个人信息
        
        @param headers: GetUserInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetUserInfoResponse
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
            action='GetUserInfo',
            version='esign_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/esign/users/{user_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkesign__1__0_models.GetUserInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def get_user_info_with_options_async(
        self,
        user_id: str,
        headers: dingtalkesign__1__0_models.GetUserInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkesign__1__0_models.GetUserInfoResponse:
        """
        @summary 查询个人信息
        
        @param headers: GetUserInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetUserInfoResponse
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
            action='GetUserInfo',
            version='esign_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/esign/users/{user_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkesign__1__0_models.GetUserInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_user_info(
        self,
        user_id: str,
    ) -> dingtalkesign__1__0_models.GetUserInfoResponse:
        """
        @summary 查询个人信息
        
        @return: GetUserInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkesign__1__0_models.GetUserInfoHeaders()
        return self.get_user_info_with_options(user_id, headers, runtime)

    async def get_user_info_async(
        self,
        user_id: str,
    ) -> dingtalkesign__1__0_models.GetUserInfoResponse:
        """
        @summary 查询个人信息
        
        @return: GetUserInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkesign__1__0_models.GetUserInfoHeaders()
        return await self.get_user_info_with_options_async(user_id, headers, runtime)

    def get_user_realname_url_with_options(
        self,
        request: dingtalkesign__1__0_models.GetUserRealnameUrlRequest,
        headers: dingtalkesign__1__0_models.GetUserRealnameUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkesign__1__0_models.GetUserRealnameUrlResponse:
        """
        @summary 获取跳转到个人实名的地址
        
        @param request: GetUserRealnameUrlRequest
        @param headers: GetUserRealnameUrlHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetUserRealnameUrlResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.redirect_url):
            body['redirectUrl'] = request.redirect_url
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
            action='GetUserRealnameUrl',
            version='esign_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/esign/users/realname',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkesign__1__0_models.GetUserRealnameUrlResponse(),
            self.execute(params, req, runtime)
        )

    async def get_user_realname_url_with_options_async(
        self,
        request: dingtalkesign__1__0_models.GetUserRealnameUrlRequest,
        headers: dingtalkesign__1__0_models.GetUserRealnameUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkesign__1__0_models.GetUserRealnameUrlResponse:
        """
        @summary 获取跳转到个人实名的地址
        
        @param request: GetUserRealnameUrlRequest
        @param headers: GetUserRealnameUrlHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetUserRealnameUrlResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.redirect_url):
            body['redirectUrl'] = request.redirect_url
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
            action='GetUserRealnameUrl',
            version='esign_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/esign/users/realname',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkesign__1__0_models.GetUserRealnameUrlResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_user_realname_url(
        self,
        request: dingtalkesign__1__0_models.GetUserRealnameUrlRequest,
    ) -> dingtalkesign__1__0_models.GetUserRealnameUrlResponse:
        """
        @summary 获取跳转到个人实名的地址
        
        @param request: GetUserRealnameUrlRequest
        @return: GetUserRealnameUrlResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkesign__1__0_models.GetUserRealnameUrlHeaders()
        return self.get_user_realname_url_with_options(request, headers, runtime)

    async def get_user_realname_url_async(
        self,
        request: dingtalkesign__1__0_models.GetUserRealnameUrlRequest,
    ) -> dingtalkesign__1__0_models.GetUserRealnameUrlResponse:
        """
        @summary 获取跳转到个人实名的地址
        
        @param request: GetUserRealnameUrlRequest
        @return: GetUserRealnameUrlResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkesign__1__0_models.GetUserRealnameUrlHeaders()
        return await self.get_user_realname_url_with_options_async(request, headers, runtime)

    def list_flow_docs_with_options(
        self,
        request: dingtalkesign__1__0_models.ListFlowDocsRequest,
        headers: dingtalkesign__1__0_models.ListFlowDocsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkesign__1__0_models.ListFlowDocsResponse:
        """
        @summary 获取流程任务合同列表
        
        @param request: ListFlowDocsRequest
        @param headers: ListFlowDocsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListFlowDocsResponse
        """
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
        params = open_api_models.Params(
            action='ListFlowDocs',
            version='esign_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/esign/flows/docs',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkesign__1__0_models.ListFlowDocsResponse(),
            self.execute(params, req, runtime)
        )

    async def list_flow_docs_with_options_async(
        self,
        request: dingtalkesign__1__0_models.ListFlowDocsRequest,
        headers: dingtalkesign__1__0_models.ListFlowDocsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkesign__1__0_models.ListFlowDocsResponse:
        """
        @summary 获取流程任务合同列表
        
        @param request: ListFlowDocsRequest
        @param headers: ListFlowDocsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListFlowDocsResponse
        """
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
        params = open_api_models.Params(
            action='ListFlowDocs',
            version='esign_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/esign/flows/docs',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkesign__1__0_models.ListFlowDocsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_flow_docs(
        self,
        request: dingtalkesign__1__0_models.ListFlowDocsRequest,
    ) -> dingtalkesign__1__0_models.ListFlowDocsResponse:
        """
        @summary 获取流程任务合同列表
        
        @param request: ListFlowDocsRequest
        @return: ListFlowDocsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkesign__1__0_models.ListFlowDocsHeaders()
        return self.list_flow_docs_with_options(request, headers, runtime)

    async def list_flow_docs_async(
        self,
        request: dingtalkesign__1__0_models.ListFlowDocsRequest,
    ) -> dingtalkesign__1__0_models.ListFlowDocsResponse:
        """
        @summary 获取流程任务合同列表
        
        @param request: ListFlowDocsRequest
        @return: ListFlowDocsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkesign__1__0_models.ListFlowDocsHeaders()
        return await self.list_flow_docs_with_options_async(request, headers, runtime)

    def list_seal_approval_with_options(
        self,
        request: dingtalkesign__1__0_models.ListSealApprovalRequest,
        headers: dingtalkesign__1__0_models.ListSealApprovalHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkesign__1__0_models.ListSealApprovalResponse:
        """
        @summary 获取流程任务用印审批列表
        
        @param request: ListSealApprovalRequest
        @param headers: ListSealApprovalHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListSealApprovalResponse
        """
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
        params = open_api_models.Params(
            action='ListSealApproval',
            version='esign_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/esign/seals/approval/list',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkesign__1__0_models.ListSealApprovalResponse(),
            self.execute(params, req, runtime)
        )

    async def list_seal_approval_with_options_async(
        self,
        request: dingtalkesign__1__0_models.ListSealApprovalRequest,
        headers: dingtalkesign__1__0_models.ListSealApprovalHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkesign__1__0_models.ListSealApprovalResponse:
        """
        @summary 获取流程任务用印审批列表
        
        @param request: ListSealApprovalRequest
        @param headers: ListSealApprovalHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListSealApprovalResponse
        """
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
        params = open_api_models.Params(
            action='ListSealApproval',
            version='esign_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/esign/seals/approval/list',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkesign__1__0_models.ListSealApprovalResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_seal_approval(
        self,
        request: dingtalkesign__1__0_models.ListSealApprovalRequest,
    ) -> dingtalkesign__1__0_models.ListSealApprovalResponse:
        """
        @summary 获取流程任务用印审批列表
        
        @param request: ListSealApprovalRequest
        @return: ListSealApprovalResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkesign__1__0_models.ListSealApprovalHeaders()
        return self.list_seal_approval_with_options(request, headers, runtime)

    async def list_seal_approval_async(
        self,
        request: dingtalkesign__1__0_models.ListSealApprovalRequest,
    ) -> dingtalkesign__1__0_models.ListSealApprovalResponse:
        """
        @summary 获取流程任务用印审批列表
        
        @param request: ListSealApprovalRequest
        @return: ListSealApprovalResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkesign__1__0_models.ListSealApprovalHeaders()
        return await self.list_seal_approval_with_options_async(request, headers, runtime)

    def order_resale_with_options(
        self,
        request: dingtalkesign__1__0_models.OrderResaleRequest,
        headers: dingtalkesign__1__0_models.OrderResaleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkesign__1__0_models.OrderResaleResponse:
        """
        @summary 套餐转售2（底价结算模式）
        
        @param request: OrderResaleRequest
        @param headers: OrderResaleHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: OrderResaleResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.order_create_time):
            body['orderCreateTime'] = request.order_create_time
        if not UtilClient.is_unset(request.order_id):
            body['orderId'] = request.order_id
        if not UtilClient.is_unset(request.quantity):
            body['quantity'] = request.quantity
        if not UtilClient.is_unset(request.service_start_time):
            body['serviceStartTime'] = request.service_start_time
        if not UtilClient.is_unset(request.service_stop_time):
            body['serviceStopTime'] = request.service_stop_time
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
            action='OrderResale',
            version='esign_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/esign/orders/resale',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkesign__1__0_models.OrderResaleResponse(),
            self.execute(params, req, runtime)
        )

    async def order_resale_with_options_async(
        self,
        request: dingtalkesign__1__0_models.OrderResaleRequest,
        headers: dingtalkesign__1__0_models.OrderResaleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkesign__1__0_models.OrderResaleResponse:
        """
        @summary 套餐转售2（底价结算模式）
        
        @param request: OrderResaleRequest
        @param headers: OrderResaleHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: OrderResaleResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.order_create_time):
            body['orderCreateTime'] = request.order_create_time
        if not UtilClient.is_unset(request.order_id):
            body['orderId'] = request.order_id
        if not UtilClient.is_unset(request.quantity):
            body['quantity'] = request.quantity
        if not UtilClient.is_unset(request.service_start_time):
            body['serviceStartTime'] = request.service_start_time
        if not UtilClient.is_unset(request.service_stop_time):
            body['serviceStopTime'] = request.service_stop_time
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
            action='OrderResale',
            version='esign_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/esign/orders/resale',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkesign__1__0_models.OrderResaleResponse(),
            await self.execute_async(params, req, runtime)
        )

    def order_resale(
        self,
        request: dingtalkesign__1__0_models.OrderResaleRequest,
    ) -> dingtalkesign__1__0_models.OrderResaleResponse:
        """
        @summary 套餐转售2（底价结算模式）
        
        @param request: OrderResaleRequest
        @return: OrderResaleResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkesign__1__0_models.OrderResaleHeaders()
        return self.order_resale_with_options(request, headers, runtime)

    async def order_resale_async(
        self,
        request: dingtalkesign__1__0_models.OrderResaleRequest,
    ) -> dingtalkesign__1__0_models.OrderResaleResponse:
        """
        @summary 套餐转售2（底价结算模式）
        
        @param request: OrderResaleRequest
        @return: OrderResaleResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkesign__1__0_models.OrderResaleHeaders()
        return await self.order_resale_with_options_async(request, headers, runtime)
