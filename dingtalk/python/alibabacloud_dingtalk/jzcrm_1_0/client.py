# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.jzcrm_1_0 import models as dingtalkjzcrm__1__0_models
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

    def edit_contact_with_options(
        self,
        request: dingtalkjzcrm__1__0_models.EditContactRequest,
        headers: dingtalkjzcrm__1__0_models.EditContactHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkjzcrm__1__0_models.EditContactResponse:
        """
        @summary 编辑联系人数据
        
        @param request: EditContactRequest
        @param headers: EditContactHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: EditContactResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.data):
            body['data'] = request.data
        if not UtilClient.is_unset(request.datatype):
            body['datatype'] = request.datatype
        if not UtilClient.is_unset(request.msgid):
            body['msgid'] = request.msgid
        if not UtilClient.is_unset(request.stamp):
            body['stamp'] = request.stamp
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
            action='EditContact',
            version='jzcrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/jzcrm/contacts',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkjzcrm__1__0_models.EditContactResponse(),
            self.execute(params, req, runtime)
        )

    async def edit_contact_with_options_async(
        self,
        request: dingtalkjzcrm__1__0_models.EditContactRequest,
        headers: dingtalkjzcrm__1__0_models.EditContactHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkjzcrm__1__0_models.EditContactResponse:
        """
        @summary 编辑联系人数据
        
        @param request: EditContactRequest
        @param headers: EditContactHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: EditContactResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.data):
            body['data'] = request.data
        if not UtilClient.is_unset(request.datatype):
            body['datatype'] = request.datatype
        if not UtilClient.is_unset(request.msgid):
            body['msgid'] = request.msgid
        if not UtilClient.is_unset(request.stamp):
            body['stamp'] = request.stamp
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
            action='EditContact',
            version='jzcrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/jzcrm/contacts',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkjzcrm__1__0_models.EditContactResponse(),
            await self.execute_async(params, req, runtime)
        )

    def edit_contact(
        self,
        request: dingtalkjzcrm__1__0_models.EditContactRequest,
    ) -> dingtalkjzcrm__1__0_models.EditContactResponse:
        """
        @summary 编辑联系人数据
        
        @param request: EditContactRequest
        @return: EditContactResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkjzcrm__1__0_models.EditContactHeaders()
        return self.edit_contact_with_options(request, headers, runtime)

    async def edit_contact_async(
        self,
        request: dingtalkjzcrm__1__0_models.EditContactRequest,
    ) -> dingtalkjzcrm__1__0_models.EditContactResponse:
        """
        @summary 编辑联系人数据
        
        @param request: EditContactRequest
        @return: EditContactResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkjzcrm__1__0_models.EditContactHeaders()
        return await self.edit_contact_with_options_async(request, headers, runtime)

    def edit_customer_with_options(
        self,
        request: dingtalkjzcrm__1__0_models.EditCustomerRequest,
        headers: dingtalkjzcrm__1__0_models.EditCustomerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkjzcrm__1__0_models.EditCustomerResponse:
        """
        @summary 编辑客户数据
        
        @param request: EditCustomerRequest
        @param headers: EditCustomerHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: EditCustomerResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.data):
            body['data'] = request.data
        if not UtilClient.is_unset(request.datatype):
            body['datatype'] = request.datatype
        if not UtilClient.is_unset(request.msgid):
            body['msgid'] = request.msgid
        if not UtilClient.is_unset(request.stamp):
            body['stamp'] = request.stamp
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
            action='EditCustomer',
            version='jzcrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/jzcrm/customers',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkjzcrm__1__0_models.EditCustomerResponse(),
            self.execute(params, req, runtime)
        )

    async def edit_customer_with_options_async(
        self,
        request: dingtalkjzcrm__1__0_models.EditCustomerRequest,
        headers: dingtalkjzcrm__1__0_models.EditCustomerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkjzcrm__1__0_models.EditCustomerResponse:
        """
        @summary 编辑客户数据
        
        @param request: EditCustomerRequest
        @param headers: EditCustomerHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: EditCustomerResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.data):
            body['data'] = request.data
        if not UtilClient.is_unset(request.datatype):
            body['datatype'] = request.datatype
        if not UtilClient.is_unset(request.msgid):
            body['msgid'] = request.msgid
        if not UtilClient.is_unset(request.stamp):
            body['stamp'] = request.stamp
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
            action='EditCustomer',
            version='jzcrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/jzcrm/customers',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkjzcrm__1__0_models.EditCustomerResponse(),
            await self.execute_async(params, req, runtime)
        )

    def edit_customer(
        self,
        request: dingtalkjzcrm__1__0_models.EditCustomerRequest,
    ) -> dingtalkjzcrm__1__0_models.EditCustomerResponse:
        """
        @summary 编辑客户数据
        
        @param request: EditCustomerRequest
        @return: EditCustomerResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkjzcrm__1__0_models.EditCustomerHeaders()
        return self.edit_customer_with_options(request, headers, runtime)

    async def edit_customer_async(
        self,
        request: dingtalkjzcrm__1__0_models.EditCustomerRequest,
    ) -> dingtalkjzcrm__1__0_models.EditCustomerResponse:
        """
        @summary 编辑客户数据
        
        @param request: EditCustomerRequest
        @return: EditCustomerResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkjzcrm__1__0_models.EditCustomerHeaders()
        return await self.edit_customer_with_options_async(request, headers, runtime)

    def edit_customer_pool_with_options(
        self,
        request: dingtalkjzcrm__1__0_models.EditCustomerPoolRequest,
        headers: dingtalkjzcrm__1__0_models.EditCustomerPoolHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkjzcrm__1__0_models.EditCustomerPoolResponse:
        """
        @summary 编辑客户公共池数据
        
        @param request: EditCustomerPoolRequest
        @param headers: EditCustomerPoolHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: EditCustomerPoolResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.data):
            body['data'] = request.data
        if not UtilClient.is_unset(request.datatype):
            body['datatype'] = request.datatype
        if not UtilClient.is_unset(request.msgid):
            body['msgid'] = request.msgid
        if not UtilClient.is_unset(request.stamp):
            body['stamp'] = request.stamp
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
            action='EditCustomerPool',
            version='jzcrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/jzcrm/customerPools',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkjzcrm__1__0_models.EditCustomerPoolResponse(),
            self.execute(params, req, runtime)
        )

    async def edit_customer_pool_with_options_async(
        self,
        request: dingtalkjzcrm__1__0_models.EditCustomerPoolRequest,
        headers: dingtalkjzcrm__1__0_models.EditCustomerPoolHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkjzcrm__1__0_models.EditCustomerPoolResponse:
        """
        @summary 编辑客户公共池数据
        
        @param request: EditCustomerPoolRequest
        @param headers: EditCustomerPoolHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: EditCustomerPoolResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.data):
            body['data'] = request.data
        if not UtilClient.is_unset(request.datatype):
            body['datatype'] = request.datatype
        if not UtilClient.is_unset(request.msgid):
            body['msgid'] = request.msgid
        if not UtilClient.is_unset(request.stamp):
            body['stamp'] = request.stamp
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
            action='EditCustomerPool',
            version='jzcrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/jzcrm/customerPools',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkjzcrm__1__0_models.EditCustomerPoolResponse(),
            await self.execute_async(params, req, runtime)
        )

    def edit_customer_pool(
        self,
        request: dingtalkjzcrm__1__0_models.EditCustomerPoolRequest,
    ) -> dingtalkjzcrm__1__0_models.EditCustomerPoolResponse:
        """
        @summary 编辑客户公共池数据
        
        @param request: EditCustomerPoolRequest
        @return: EditCustomerPoolResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkjzcrm__1__0_models.EditCustomerPoolHeaders()
        return self.edit_customer_pool_with_options(request, headers, runtime)

    async def edit_customer_pool_async(
        self,
        request: dingtalkjzcrm__1__0_models.EditCustomerPoolRequest,
    ) -> dingtalkjzcrm__1__0_models.EditCustomerPoolResponse:
        """
        @summary 编辑客户公共池数据
        
        @param request: EditCustomerPoolRequest
        @return: EditCustomerPoolResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkjzcrm__1__0_models.EditCustomerPoolHeaders()
        return await self.edit_customer_pool_with_options_async(request, headers, runtime)

    def edit_exchange_with_options(
        self,
        request: dingtalkjzcrm__1__0_models.EditExchangeRequest,
        headers: dingtalkjzcrm__1__0_models.EditExchangeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkjzcrm__1__0_models.EditExchangeResponse:
        """
        @summary 编辑销售换货单数据
        
        @param request: EditExchangeRequest
        @param headers: EditExchangeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: EditExchangeResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.data):
            body['data'] = request.data
        if not UtilClient.is_unset(request.datatype):
            body['datatype'] = request.datatype
        if not UtilClient.is_unset(request.msgid):
            body['msgid'] = request.msgid
        if not UtilClient.is_unset(request.stamp):
            body['stamp'] = request.stamp
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
            action='EditExchange',
            version='jzcrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/jzcrm/exchanges',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkjzcrm__1__0_models.EditExchangeResponse(),
            self.execute(params, req, runtime)
        )

    async def edit_exchange_with_options_async(
        self,
        request: dingtalkjzcrm__1__0_models.EditExchangeRequest,
        headers: dingtalkjzcrm__1__0_models.EditExchangeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkjzcrm__1__0_models.EditExchangeResponse:
        """
        @summary 编辑销售换货单数据
        
        @param request: EditExchangeRequest
        @param headers: EditExchangeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: EditExchangeResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.data):
            body['data'] = request.data
        if not UtilClient.is_unset(request.datatype):
            body['datatype'] = request.datatype
        if not UtilClient.is_unset(request.msgid):
            body['msgid'] = request.msgid
        if not UtilClient.is_unset(request.stamp):
            body['stamp'] = request.stamp
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
            action='EditExchange',
            version='jzcrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/jzcrm/exchanges',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkjzcrm__1__0_models.EditExchangeResponse(),
            await self.execute_async(params, req, runtime)
        )

    def edit_exchange(
        self,
        request: dingtalkjzcrm__1__0_models.EditExchangeRequest,
    ) -> dingtalkjzcrm__1__0_models.EditExchangeResponse:
        """
        @summary 编辑销售换货单数据
        
        @param request: EditExchangeRequest
        @return: EditExchangeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkjzcrm__1__0_models.EditExchangeHeaders()
        return self.edit_exchange_with_options(request, headers, runtime)

    async def edit_exchange_async(
        self,
        request: dingtalkjzcrm__1__0_models.EditExchangeRequest,
    ) -> dingtalkjzcrm__1__0_models.EditExchangeResponse:
        """
        @summary 编辑销售换货单数据
        
        @param request: EditExchangeRequest
        @return: EditExchangeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkjzcrm__1__0_models.EditExchangeHeaders()
        return await self.edit_exchange_with_options_async(request, headers, runtime)

    def edit_goods_with_options(
        self,
        request: dingtalkjzcrm__1__0_models.EditGoodsRequest,
        headers: dingtalkjzcrm__1__0_models.EditGoodsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkjzcrm__1__0_models.EditGoodsResponse:
        """
        @summary 编辑产品数据
        
        @param request: EditGoodsRequest
        @param headers: EditGoodsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: EditGoodsResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.data):
            body['data'] = request.data
        if not UtilClient.is_unset(request.datatype):
            body['datatype'] = request.datatype
        if not UtilClient.is_unset(request.msgid):
            body['msgid'] = request.msgid
        if not UtilClient.is_unset(request.stamp):
            body['stamp'] = request.stamp
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
            action='EditGoods',
            version='jzcrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/jzcrm/goods',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkjzcrm__1__0_models.EditGoodsResponse(),
            self.execute(params, req, runtime)
        )

    async def edit_goods_with_options_async(
        self,
        request: dingtalkjzcrm__1__0_models.EditGoodsRequest,
        headers: dingtalkjzcrm__1__0_models.EditGoodsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkjzcrm__1__0_models.EditGoodsResponse:
        """
        @summary 编辑产品数据
        
        @param request: EditGoodsRequest
        @param headers: EditGoodsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: EditGoodsResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.data):
            body['data'] = request.data
        if not UtilClient.is_unset(request.datatype):
            body['datatype'] = request.datatype
        if not UtilClient.is_unset(request.msgid):
            body['msgid'] = request.msgid
        if not UtilClient.is_unset(request.stamp):
            body['stamp'] = request.stamp
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
            action='EditGoods',
            version='jzcrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/jzcrm/goods',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkjzcrm__1__0_models.EditGoodsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def edit_goods(
        self,
        request: dingtalkjzcrm__1__0_models.EditGoodsRequest,
    ) -> dingtalkjzcrm__1__0_models.EditGoodsResponse:
        """
        @summary 编辑产品数据
        
        @param request: EditGoodsRequest
        @return: EditGoodsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkjzcrm__1__0_models.EditGoodsHeaders()
        return self.edit_goods_with_options(request, headers, runtime)

    async def edit_goods_async(
        self,
        request: dingtalkjzcrm__1__0_models.EditGoodsRequest,
    ) -> dingtalkjzcrm__1__0_models.EditGoodsResponse:
        """
        @summary 编辑产品数据
        
        @param request: EditGoodsRequest
        @return: EditGoodsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkjzcrm__1__0_models.EditGoodsHeaders()
        return await self.edit_goods_with_options_async(request, headers, runtime)

    def edit_intostock_with_options(
        self,
        request: dingtalkjzcrm__1__0_models.EditIntostockRequest,
        headers: dingtalkjzcrm__1__0_models.EditIntostockHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkjzcrm__1__0_models.EditIntostockResponse:
        """
        @summary 编辑入库单数据
        
        @param request: EditIntostockRequest
        @param headers: EditIntostockHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: EditIntostockResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.data):
            body['data'] = request.data
        if not UtilClient.is_unset(request.datatype):
            body['datatype'] = request.datatype
        if not UtilClient.is_unset(request.msgid):
            body['msgid'] = request.msgid
        if not UtilClient.is_unset(request.stamp):
            body['stamp'] = request.stamp
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
            action='EditIntostock',
            version='jzcrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/jzcrm/intostocks',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkjzcrm__1__0_models.EditIntostockResponse(),
            self.execute(params, req, runtime)
        )

    async def edit_intostock_with_options_async(
        self,
        request: dingtalkjzcrm__1__0_models.EditIntostockRequest,
        headers: dingtalkjzcrm__1__0_models.EditIntostockHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkjzcrm__1__0_models.EditIntostockResponse:
        """
        @summary 编辑入库单数据
        
        @param request: EditIntostockRequest
        @param headers: EditIntostockHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: EditIntostockResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.data):
            body['data'] = request.data
        if not UtilClient.is_unset(request.datatype):
            body['datatype'] = request.datatype
        if not UtilClient.is_unset(request.msgid):
            body['msgid'] = request.msgid
        if not UtilClient.is_unset(request.stamp):
            body['stamp'] = request.stamp
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
            action='EditIntostock',
            version='jzcrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/jzcrm/intostocks',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkjzcrm__1__0_models.EditIntostockResponse(),
            await self.execute_async(params, req, runtime)
        )

    def edit_intostock(
        self,
        request: dingtalkjzcrm__1__0_models.EditIntostockRequest,
    ) -> dingtalkjzcrm__1__0_models.EditIntostockResponse:
        """
        @summary 编辑入库单数据
        
        @param request: EditIntostockRequest
        @return: EditIntostockResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkjzcrm__1__0_models.EditIntostockHeaders()
        return self.edit_intostock_with_options(request, headers, runtime)

    async def edit_intostock_async(
        self,
        request: dingtalkjzcrm__1__0_models.EditIntostockRequest,
    ) -> dingtalkjzcrm__1__0_models.EditIntostockResponse:
        """
        @summary 编辑入库单数据
        
        @param request: EditIntostockRequest
        @return: EditIntostockResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkjzcrm__1__0_models.EditIntostockHeaders()
        return await self.edit_intostock_with_options_async(request, headers, runtime)

    def edit_invoice_with_options(
        self,
        request: dingtalkjzcrm__1__0_models.EditInvoiceRequest,
        headers: dingtalkjzcrm__1__0_models.EditInvoiceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkjzcrm__1__0_models.EditInvoiceResponse:
        """
        @summary 编辑发货单数据
        
        @param request: EditInvoiceRequest
        @param headers: EditInvoiceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: EditInvoiceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.data):
            body['data'] = request.data
        if not UtilClient.is_unset(request.datatype):
            body['datatype'] = request.datatype
        if not UtilClient.is_unset(request.msgid):
            body['msgid'] = request.msgid
        if not UtilClient.is_unset(request.stamp):
            body['stamp'] = request.stamp
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
            action='EditInvoice',
            version='jzcrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/jzcrm/invoices',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkjzcrm__1__0_models.EditInvoiceResponse(),
            self.execute(params, req, runtime)
        )

    async def edit_invoice_with_options_async(
        self,
        request: dingtalkjzcrm__1__0_models.EditInvoiceRequest,
        headers: dingtalkjzcrm__1__0_models.EditInvoiceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkjzcrm__1__0_models.EditInvoiceResponse:
        """
        @summary 编辑发货单数据
        
        @param request: EditInvoiceRequest
        @param headers: EditInvoiceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: EditInvoiceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.data):
            body['data'] = request.data
        if not UtilClient.is_unset(request.datatype):
            body['datatype'] = request.datatype
        if not UtilClient.is_unset(request.msgid):
            body['msgid'] = request.msgid
        if not UtilClient.is_unset(request.stamp):
            body['stamp'] = request.stamp
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
            action='EditInvoice',
            version='jzcrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/jzcrm/invoices',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkjzcrm__1__0_models.EditInvoiceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def edit_invoice(
        self,
        request: dingtalkjzcrm__1__0_models.EditInvoiceRequest,
    ) -> dingtalkjzcrm__1__0_models.EditInvoiceResponse:
        """
        @summary 编辑发货单数据
        
        @param request: EditInvoiceRequest
        @return: EditInvoiceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkjzcrm__1__0_models.EditInvoiceHeaders()
        return self.edit_invoice_with_options(request, headers, runtime)

    async def edit_invoice_async(
        self,
        request: dingtalkjzcrm__1__0_models.EditInvoiceRequest,
    ) -> dingtalkjzcrm__1__0_models.EditInvoiceResponse:
        """
        @summary 编辑发货单数据
        
        @param request: EditInvoiceRequest
        @return: EditInvoiceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkjzcrm__1__0_models.EditInvoiceHeaders()
        return await self.edit_invoice_with_options_async(request, headers, runtime)

    def edit_order_with_options(
        self,
        request: dingtalkjzcrm__1__0_models.EditOrderRequest,
        headers: dingtalkjzcrm__1__0_models.EditOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkjzcrm__1__0_models.EditOrderResponse:
        """
        @summary 编辑合同订单数据
        
        @param request: EditOrderRequest
        @param headers: EditOrderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: EditOrderResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.data):
            body['data'] = request.data
        if not UtilClient.is_unset(request.datatype):
            body['datatype'] = request.datatype
        if not UtilClient.is_unset(request.msgid):
            body['msgid'] = request.msgid
        if not UtilClient.is_unset(request.stamp):
            body['stamp'] = request.stamp
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
            action='EditOrder',
            version='jzcrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/jzcrm/orders',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkjzcrm__1__0_models.EditOrderResponse(),
            self.execute(params, req, runtime)
        )

    async def edit_order_with_options_async(
        self,
        request: dingtalkjzcrm__1__0_models.EditOrderRequest,
        headers: dingtalkjzcrm__1__0_models.EditOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkjzcrm__1__0_models.EditOrderResponse:
        """
        @summary 编辑合同订单数据
        
        @param request: EditOrderRequest
        @param headers: EditOrderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: EditOrderResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.data):
            body['data'] = request.data
        if not UtilClient.is_unset(request.datatype):
            body['datatype'] = request.datatype
        if not UtilClient.is_unset(request.msgid):
            body['msgid'] = request.msgid
        if not UtilClient.is_unset(request.stamp):
            body['stamp'] = request.stamp
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
            action='EditOrder',
            version='jzcrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/jzcrm/orders',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkjzcrm__1__0_models.EditOrderResponse(),
            await self.execute_async(params, req, runtime)
        )

    def edit_order(
        self,
        request: dingtalkjzcrm__1__0_models.EditOrderRequest,
    ) -> dingtalkjzcrm__1__0_models.EditOrderResponse:
        """
        @summary 编辑合同订单数据
        
        @param request: EditOrderRequest
        @return: EditOrderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkjzcrm__1__0_models.EditOrderHeaders()
        return self.edit_order_with_options(request, headers, runtime)

    async def edit_order_async(
        self,
        request: dingtalkjzcrm__1__0_models.EditOrderRequest,
    ) -> dingtalkjzcrm__1__0_models.EditOrderResponse:
        """
        @summary 编辑合同订单数据
        
        @param request: EditOrderRequest
        @return: EditOrderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkjzcrm__1__0_models.EditOrderHeaders()
        return await self.edit_order_with_options_async(request, headers, runtime)

    def edit_outstock_with_options(
        self,
        request: dingtalkjzcrm__1__0_models.EditOutstockRequest,
        headers: dingtalkjzcrm__1__0_models.EditOutstockHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkjzcrm__1__0_models.EditOutstockResponse:
        """
        @summary 编辑出库单信息
        
        @param request: EditOutstockRequest
        @param headers: EditOutstockHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: EditOutstockResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.data):
            body['data'] = request.data
        if not UtilClient.is_unset(request.datatype):
            body['datatype'] = request.datatype
        if not UtilClient.is_unset(request.msgid):
            body['msgid'] = request.msgid
        if not UtilClient.is_unset(request.stamp):
            body['stamp'] = request.stamp
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
            action='EditOutstock',
            version='jzcrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/jzcrm/outstocks',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkjzcrm__1__0_models.EditOutstockResponse(),
            self.execute(params, req, runtime)
        )

    async def edit_outstock_with_options_async(
        self,
        request: dingtalkjzcrm__1__0_models.EditOutstockRequest,
        headers: dingtalkjzcrm__1__0_models.EditOutstockHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkjzcrm__1__0_models.EditOutstockResponse:
        """
        @summary 编辑出库单信息
        
        @param request: EditOutstockRequest
        @param headers: EditOutstockHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: EditOutstockResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.data):
            body['data'] = request.data
        if not UtilClient.is_unset(request.datatype):
            body['datatype'] = request.datatype
        if not UtilClient.is_unset(request.msgid):
            body['msgid'] = request.msgid
        if not UtilClient.is_unset(request.stamp):
            body['stamp'] = request.stamp
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
            action='EditOutstock',
            version='jzcrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/jzcrm/outstocks',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkjzcrm__1__0_models.EditOutstockResponse(),
            await self.execute_async(params, req, runtime)
        )

    def edit_outstock(
        self,
        request: dingtalkjzcrm__1__0_models.EditOutstockRequest,
    ) -> dingtalkjzcrm__1__0_models.EditOutstockResponse:
        """
        @summary 编辑出库单信息
        
        @param request: EditOutstockRequest
        @return: EditOutstockResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkjzcrm__1__0_models.EditOutstockHeaders()
        return self.edit_outstock_with_options(request, headers, runtime)

    async def edit_outstock_async(
        self,
        request: dingtalkjzcrm__1__0_models.EditOutstockRequest,
    ) -> dingtalkjzcrm__1__0_models.EditOutstockResponse:
        """
        @summary 编辑出库单信息
        
        @param request: EditOutstockRequest
        @return: EditOutstockResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkjzcrm__1__0_models.EditOutstockHeaders()
        return await self.edit_outstock_with_options_async(request, headers, runtime)

    def edit_production_with_options(
        self,
        request: dingtalkjzcrm__1__0_models.EditProductionRequest,
        headers: dingtalkjzcrm__1__0_models.EditProductionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkjzcrm__1__0_models.EditProductionResponse:
        """
        @summary 编辑生产单数据
        
        @param request: EditProductionRequest
        @param headers: EditProductionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: EditProductionResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.data):
            body['data'] = request.data
        if not UtilClient.is_unset(request.datatype):
            body['datatype'] = request.datatype
        if not UtilClient.is_unset(request.msgid):
            body['msgid'] = request.msgid
        if not UtilClient.is_unset(request.stamp):
            body['stamp'] = request.stamp
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
            action='EditProduction',
            version='jzcrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/jzcrm/productions',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkjzcrm__1__0_models.EditProductionResponse(),
            self.execute(params, req, runtime)
        )

    async def edit_production_with_options_async(
        self,
        request: dingtalkjzcrm__1__0_models.EditProductionRequest,
        headers: dingtalkjzcrm__1__0_models.EditProductionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkjzcrm__1__0_models.EditProductionResponse:
        """
        @summary 编辑生产单数据
        
        @param request: EditProductionRequest
        @param headers: EditProductionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: EditProductionResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.data):
            body['data'] = request.data
        if not UtilClient.is_unset(request.datatype):
            body['datatype'] = request.datatype
        if not UtilClient.is_unset(request.msgid):
            body['msgid'] = request.msgid
        if not UtilClient.is_unset(request.stamp):
            body['stamp'] = request.stamp
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
            action='EditProduction',
            version='jzcrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/jzcrm/productions',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkjzcrm__1__0_models.EditProductionResponse(),
            await self.execute_async(params, req, runtime)
        )

    def edit_production(
        self,
        request: dingtalkjzcrm__1__0_models.EditProductionRequest,
    ) -> dingtalkjzcrm__1__0_models.EditProductionResponse:
        """
        @summary 编辑生产单数据
        
        @param request: EditProductionRequest
        @return: EditProductionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkjzcrm__1__0_models.EditProductionHeaders()
        return self.edit_production_with_options(request, headers, runtime)

    async def edit_production_async(
        self,
        request: dingtalkjzcrm__1__0_models.EditProductionRequest,
    ) -> dingtalkjzcrm__1__0_models.EditProductionResponse:
        """
        @summary 编辑生产单数据
        
        @param request: EditProductionRequest
        @return: EditProductionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkjzcrm__1__0_models.EditProductionHeaders()
        return await self.edit_production_with_options_async(request, headers, runtime)

    def edit_purchase_with_options(
        self,
        request: dingtalkjzcrm__1__0_models.EditPurchaseRequest,
        headers: dingtalkjzcrm__1__0_models.EditPurchaseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkjzcrm__1__0_models.EditPurchaseResponse:
        """
        @summary 编辑采购单数据
        
        @param request: EditPurchaseRequest
        @param headers: EditPurchaseHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: EditPurchaseResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.data):
            body['data'] = request.data
        if not UtilClient.is_unset(request.datatype):
            body['datatype'] = request.datatype
        if not UtilClient.is_unset(request.msgid):
            body['msgid'] = request.msgid
        if not UtilClient.is_unset(request.stamp):
            body['stamp'] = request.stamp
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
            action='EditPurchase',
            version='jzcrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/jzcrm/purchases',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkjzcrm__1__0_models.EditPurchaseResponse(),
            self.execute(params, req, runtime)
        )

    async def edit_purchase_with_options_async(
        self,
        request: dingtalkjzcrm__1__0_models.EditPurchaseRequest,
        headers: dingtalkjzcrm__1__0_models.EditPurchaseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkjzcrm__1__0_models.EditPurchaseResponse:
        """
        @summary 编辑采购单数据
        
        @param request: EditPurchaseRequest
        @param headers: EditPurchaseHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: EditPurchaseResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.data):
            body['data'] = request.data
        if not UtilClient.is_unset(request.datatype):
            body['datatype'] = request.datatype
        if not UtilClient.is_unset(request.msgid):
            body['msgid'] = request.msgid
        if not UtilClient.is_unset(request.stamp):
            body['stamp'] = request.stamp
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
            action='EditPurchase',
            version='jzcrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/jzcrm/purchases',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkjzcrm__1__0_models.EditPurchaseResponse(),
            await self.execute_async(params, req, runtime)
        )

    def edit_purchase(
        self,
        request: dingtalkjzcrm__1__0_models.EditPurchaseRequest,
    ) -> dingtalkjzcrm__1__0_models.EditPurchaseResponse:
        """
        @summary 编辑采购单数据
        
        @param request: EditPurchaseRequest
        @return: EditPurchaseResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkjzcrm__1__0_models.EditPurchaseHeaders()
        return self.edit_purchase_with_options(request, headers, runtime)

    async def edit_purchase_async(
        self,
        request: dingtalkjzcrm__1__0_models.EditPurchaseRequest,
    ) -> dingtalkjzcrm__1__0_models.EditPurchaseResponse:
        """
        @summary 编辑采购单数据
        
        @param request: EditPurchaseRequest
        @return: EditPurchaseResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkjzcrm__1__0_models.EditPurchaseHeaders()
        return await self.edit_purchase_with_options_async(request, headers, runtime)

    def edit_quotation_record_with_options(
        self,
        request: dingtalkjzcrm__1__0_models.EditQuotationRecordRequest,
        headers: dingtalkjzcrm__1__0_models.EditQuotationRecordHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkjzcrm__1__0_models.EditQuotationRecordResponse:
        """
        @summary 编辑报价记录数据
        
        @param request: EditQuotationRecordRequest
        @param headers: EditQuotationRecordHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: EditQuotationRecordResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.data):
            body['data'] = request.data
        if not UtilClient.is_unset(request.datatype):
            body['datatype'] = request.datatype
        if not UtilClient.is_unset(request.msgid):
            body['msgid'] = request.msgid
        if not UtilClient.is_unset(request.stamp):
            body['stamp'] = request.stamp
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
            action='EditQuotationRecord',
            version='jzcrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/jzcrm/quotationRecords',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkjzcrm__1__0_models.EditQuotationRecordResponse(),
            self.execute(params, req, runtime)
        )

    async def edit_quotation_record_with_options_async(
        self,
        request: dingtalkjzcrm__1__0_models.EditQuotationRecordRequest,
        headers: dingtalkjzcrm__1__0_models.EditQuotationRecordHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkjzcrm__1__0_models.EditQuotationRecordResponse:
        """
        @summary 编辑报价记录数据
        
        @param request: EditQuotationRecordRequest
        @param headers: EditQuotationRecordHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: EditQuotationRecordResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.data):
            body['data'] = request.data
        if not UtilClient.is_unset(request.datatype):
            body['datatype'] = request.datatype
        if not UtilClient.is_unset(request.msgid):
            body['msgid'] = request.msgid
        if not UtilClient.is_unset(request.stamp):
            body['stamp'] = request.stamp
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
            action='EditQuotationRecord',
            version='jzcrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/jzcrm/quotationRecords',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkjzcrm__1__0_models.EditQuotationRecordResponse(),
            await self.execute_async(params, req, runtime)
        )

    def edit_quotation_record(
        self,
        request: dingtalkjzcrm__1__0_models.EditQuotationRecordRequest,
    ) -> dingtalkjzcrm__1__0_models.EditQuotationRecordResponse:
        """
        @summary 编辑报价记录数据
        
        @param request: EditQuotationRecordRequest
        @return: EditQuotationRecordResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkjzcrm__1__0_models.EditQuotationRecordHeaders()
        return self.edit_quotation_record_with_options(request, headers, runtime)

    async def edit_quotation_record_async(
        self,
        request: dingtalkjzcrm__1__0_models.EditQuotationRecordRequest,
    ) -> dingtalkjzcrm__1__0_models.EditQuotationRecordResponse:
        """
        @summary 编辑报价记录数据
        
        @param request: EditQuotationRecordRequest
        @return: EditQuotationRecordResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkjzcrm__1__0_models.EditQuotationRecordHeaders()
        return await self.edit_quotation_record_with_options_async(request, headers, runtime)

    def edit_sales_with_options(
        self,
        request: dingtalkjzcrm__1__0_models.EditSalesRequest,
        headers: dingtalkjzcrm__1__0_models.EditSalesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkjzcrm__1__0_models.EditSalesResponse:
        """
        @summary 编辑销售机会数据
        
        @param request: EditSalesRequest
        @param headers: EditSalesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: EditSalesResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.data):
            body['data'] = request.data
        if not UtilClient.is_unset(request.datatype):
            body['datatype'] = request.datatype
        if not UtilClient.is_unset(request.msgid):
            body['msgid'] = request.msgid
        if not UtilClient.is_unset(request.stamp):
            body['stamp'] = request.stamp
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
            action='EditSales',
            version='jzcrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/jzcrm/sales',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkjzcrm__1__0_models.EditSalesResponse(),
            self.execute(params, req, runtime)
        )

    async def edit_sales_with_options_async(
        self,
        request: dingtalkjzcrm__1__0_models.EditSalesRequest,
        headers: dingtalkjzcrm__1__0_models.EditSalesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkjzcrm__1__0_models.EditSalesResponse:
        """
        @summary 编辑销售机会数据
        
        @param request: EditSalesRequest
        @param headers: EditSalesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: EditSalesResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.data):
            body['data'] = request.data
        if not UtilClient.is_unset(request.datatype):
            body['datatype'] = request.datatype
        if not UtilClient.is_unset(request.msgid):
            body['msgid'] = request.msgid
        if not UtilClient.is_unset(request.stamp):
            body['stamp'] = request.stamp
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
            action='EditSales',
            version='jzcrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/jzcrm/sales',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkjzcrm__1__0_models.EditSalesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def edit_sales(
        self,
        request: dingtalkjzcrm__1__0_models.EditSalesRequest,
    ) -> dingtalkjzcrm__1__0_models.EditSalesResponse:
        """
        @summary 编辑销售机会数据
        
        @param request: EditSalesRequest
        @return: EditSalesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkjzcrm__1__0_models.EditSalesHeaders()
        return self.edit_sales_with_options(request, headers, runtime)

    async def edit_sales_async(
        self,
        request: dingtalkjzcrm__1__0_models.EditSalesRequest,
    ) -> dingtalkjzcrm__1__0_models.EditSalesResponse:
        """
        @summary 编辑销售机会数据
        
        @param request: EditSalesRequest
        @return: EditSalesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkjzcrm__1__0_models.EditSalesHeaders()
        return await self.edit_sales_with_options_async(request, headers, runtime)

    def get_data_list_with_options(
        self,
        request: dingtalkjzcrm__1__0_models.GetDataListRequest,
        headers: dingtalkjzcrm__1__0_models.GetDataListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkjzcrm__1__0_models.GetDataListResponse:
        """
        @summary 获取数据列表
        
        @param request: GetDataListRequest
        @param headers: GetDataListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetDataListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.datatype):
            query['datatype'] = request.datatype
        if not UtilClient.is_unset(request.page):
            query['page'] = request.page
        if not UtilClient.is_unset(request.pagesize):
            query['pagesize'] = request.pagesize
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
            action='GetDataList',
            version='jzcrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/jzcrm/data',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkjzcrm__1__0_models.GetDataListResponse(),
            self.execute(params, req, runtime)
        )

    async def get_data_list_with_options_async(
        self,
        request: dingtalkjzcrm__1__0_models.GetDataListRequest,
        headers: dingtalkjzcrm__1__0_models.GetDataListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkjzcrm__1__0_models.GetDataListResponse:
        """
        @summary 获取数据列表
        
        @param request: GetDataListRequest
        @param headers: GetDataListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetDataListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.datatype):
            query['datatype'] = request.datatype
        if not UtilClient.is_unset(request.page):
            query['page'] = request.page
        if not UtilClient.is_unset(request.pagesize):
            query['pagesize'] = request.pagesize
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
            action='GetDataList',
            version='jzcrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/jzcrm/data',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkjzcrm__1__0_models.GetDataListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_data_list(
        self,
        request: dingtalkjzcrm__1__0_models.GetDataListRequest,
    ) -> dingtalkjzcrm__1__0_models.GetDataListResponse:
        """
        @summary 获取数据列表
        
        @param request: GetDataListRequest
        @return: GetDataListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkjzcrm__1__0_models.GetDataListHeaders()
        return self.get_data_list_with_options(request, headers, runtime)

    async def get_data_list_async(
        self,
        request: dingtalkjzcrm__1__0_models.GetDataListRequest,
    ) -> dingtalkjzcrm__1__0_models.GetDataListResponse:
        """
        @summary 获取数据列表
        
        @param request: GetDataListRequest
        @return: GetDataListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkjzcrm__1__0_models.GetDataListHeaders()
        return await self.get_data_list_with_options_async(request, headers, runtime)

    def get_data_view_with_options(
        self,
        request: dingtalkjzcrm__1__0_models.GetDataViewRequest,
        headers: dingtalkjzcrm__1__0_models.GetDataViewHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkjzcrm__1__0_models.GetDataViewResponse:
        """
        @summary 获取数据详情
        
        @param request: GetDataViewRequest
        @param headers: GetDataViewHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetDataViewResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.datatype):
            query['datatype'] = request.datatype
        if not UtilClient.is_unset(request.msgid):
            query['msgid'] = request.msgid
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
            action='GetDataView',
            version='jzcrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/jzcrm/dataView',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkjzcrm__1__0_models.GetDataViewResponse(),
            self.execute(params, req, runtime)
        )

    async def get_data_view_with_options_async(
        self,
        request: dingtalkjzcrm__1__0_models.GetDataViewRequest,
        headers: dingtalkjzcrm__1__0_models.GetDataViewHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkjzcrm__1__0_models.GetDataViewResponse:
        """
        @summary 获取数据详情
        
        @param request: GetDataViewRequest
        @param headers: GetDataViewHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetDataViewResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.datatype):
            query['datatype'] = request.datatype
        if not UtilClient.is_unset(request.msgid):
            query['msgid'] = request.msgid
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
            action='GetDataView',
            version='jzcrm_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/jzcrm/dataView',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkjzcrm__1__0_models.GetDataViewResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_data_view(
        self,
        request: dingtalkjzcrm__1__0_models.GetDataViewRequest,
    ) -> dingtalkjzcrm__1__0_models.GetDataViewResponse:
        """
        @summary 获取数据详情
        
        @param request: GetDataViewRequest
        @return: GetDataViewResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkjzcrm__1__0_models.GetDataViewHeaders()
        return self.get_data_view_with_options(request, headers, runtime)

    async def get_data_view_async(
        self,
        request: dingtalkjzcrm__1__0_models.GetDataViewRequest,
    ) -> dingtalkjzcrm__1__0_models.GetDataViewResponse:
        """
        @summary 获取数据详情
        
        @param request: GetDataViewRequest
        @return: GetDataViewResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkjzcrm__1__0_models.GetDataViewHeaders()
        return await self.get_data_view_with_options_async(request, headers, runtime)
