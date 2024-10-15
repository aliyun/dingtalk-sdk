# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.app_market_1_0 import models as dingtalkapp_market__1__0_models
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

    def create_app_goods_service_conversation_with_options(
        self,
        request: dingtalkapp_market__1__0_models.CreateAppGoodsServiceConversationRequest,
        headers: dingtalkapp_market__1__0_models.CreateAppGoodsServiceConversationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkapp_market__1__0_models.CreateAppGoodsServiceConversationResponse:
        """
        @summary 创建应用商品服务群
        
        @param request: CreateAppGoodsServiceConversationRequest
        @param headers: CreateAppGoodsServiceConversationHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateAppGoodsServiceConversationResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.isv_user_id):
            body['isvUserId'] = request.isv_user_id
        if not UtilClient.is_unset(request.order_id):
            body['orderId'] = request.order_id
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
            action='CreateAppGoodsServiceConversation',
            version='appMarket_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/appMarket/orders/serviceGroups',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkapp_market__1__0_models.CreateAppGoodsServiceConversationResponse(),
            self.execute(params, req, runtime)
        )

    async def create_app_goods_service_conversation_with_options_async(
        self,
        request: dingtalkapp_market__1__0_models.CreateAppGoodsServiceConversationRequest,
        headers: dingtalkapp_market__1__0_models.CreateAppGoodsServiceConversationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkapp_market__1__0_models.CreateAppGoodsServiceConversationResponse:
        """
        @summary 创建应用商品服务群
        
        @param request: CreateAppGoodsServiceConversationRequest
        @param headers: CreateAppGoodsServiceConversationHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateAppGoodsServiceConversationResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.isv_user_id):
            body['isvUserId'] = request.isv_user_id
        if not UtilClient.is_unset(request.order_id):
            body['orderId'] = request.order_id
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
            action='CreateAppGoodsServiceConversation',
            version='appMarket_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/appMarket/orders/serviceGroups',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkapp_market__1__0_models.CreateAppGoodsServiceConversationResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_app_goods_service_conversation(
        self,
        request: dingtalkapp_market__1__0_models.CreateAppGoodsServiceConversationRequest,
    ) -> dingtalkapp_market__1__0_models.CreateAppGoodsServiceConversationResponse:
        """
        @summary 创建应用商品服务群
        
        @param request: CreateAppGoodsServiceConversationRequest
        @return: CreateAppGoodsServiceConversationResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkapp_market__1__0_models.CreateAppGoodsServiceConversationHeaders()
        return self.create_app_goods_service_conversation_with_options(request, headers, runtime)

    async def create_app_goods_service_conversation_async(
        self,
        request: dingtalkapp_market__1__0_models.CreateAppGoodsServiceConversationRequest,
    ) -> dingtalkapp_market__1__0_models.CreateAppGoodsServiceConversationResponse:
        """
        @summary 创建应用商品服务群
        
        @param request: CreateAppGoodsServiceConversationRequest
        @return: CreateAppGoodsServiceConversationResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkapp_market__1__0_models.CreateAppGoodsServiceConversationHeaders()
        return await self.create_app_goods_service_conversation_with_options_async(request, headers, runtime)

    def get_cool_app_access_status_with_options(
        self,
        request: dingtalkapp_market__1__0_models.GetCoolAppAccessStatusRequest,
        headers: dingtalkapp_market__1__0_models.GetCoolAppAccessStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkapp_market__1__0_models.GetCoolAppAccessStatusResponse:
        """
        @summary 获取酷应用访问状态
        
        @param request: GetCoolAppAccessStatusRequest
        @param headers: GetCoolAppAccessStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetCoolAppAccessStatusResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.auth_code):
            body['authCode'] = request.auth_code
        if not UtilClient.is_unset(request.cool_app_code):
            body['coolAppCode'] = request.cool_app_code
        if not UtilClient.is_unset(request.enc_field_biz_code):
            body['encFieldBizCode'] = request.enc_field_biz_code
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
            action='GetCoolAppAccessStatus',
            version='appMarket_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/appMarket/coolApps/accessions/statuses/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkapp_market__1__0_models.GetCoolAppAccessStatusResponse(),
            self.execute(params, req, runtime)
        )

    async def get_cool_app_access_status_with_options_async(
        self,
        request: dingtalkapp_market__1__0_models.GetCoolAppAccessStatusRequest,
        headers: dingtalkapp_market__1__0_models.GetCoolAppAccessStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkapp_market__1__0_models.GetCoolAppAccessStatusResponse:
        """
        @summary 获取酷应用访问状态
        
        @param request: GetCoolAppAccessStatusRequest
        @param headers: GetCoolAppAccessStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetCoolAppAccessStatusResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.auth_code):
            body['authCode'] = request.auth_code
        if not UtilClient.is_unset(request.cool_app_code):
            body['coolAppCode'] = request.cool_app_code
        if not UtilClient.is_unset(request.enc_field_biz_code):
            body['encFieldBizCode'] = request.enc_field_biz_code
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
            action='GetCoolAppAccessStatus',
            version='appMarket_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/appMarket/coolApps/accessions/statuses/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkapp_market__1__0_models.GetCoolAppAccessStatusResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_cool_app_access_status(
        self,
        request: dingtalkapp_market__1__0_models.GetCoolAppAccessStatusRequest,
    ) -> dingtalkapp_market__1__0_models.GetCoolAppAccessStatusResponse:
        """
        @summary 获取酷应用访问状态
        
        @param request: GetCoolAppAccessStatusRequest
        @return: GetCoolAppAccessStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkapp_market__1__0_models.GetCoolAppAccessStatusHeaders()
        return self.get_cool_app_access_status_with_options(request, headers, runtime)

    async def get_cool_app_access_status_async(
        self,
        request: dingtalkapp_market__1__0_models.GetCoolAppAccessStatusRequest,
    ) -> dingtalkapp_market__1__0_models.GetCoolAppAccessStatusResponse:
        """
        @summary 获取酷应用访问状态
        
        @param request: GetCoolAppAccessStatusRequest
        @return: GetCoolAppAccessStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkapp_market__1__0_models.GetCoolAppAccessStatusHeaders()
        return await self.get_cool_app_access_status_with_options_async(request, headers, runtime)

    def get_in_app_sku_url_with_options(
        self,
        request: dingtalkapp_market__1__0_models.GetInAppSkuUrlRequest,
        headers: dingtalkapp_market__1__0_models.GetInAppSkuUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkapp_market__1__0_models.GetInAppSkuUrlResponse:
        """
        @summary 获取内购商品SKU页面地址
        
        @param request: GetInAppSkuUrlRequest
        @param headers: GetInAppSkuUrlHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetInAppSkuUrlResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.callback_page):
            body['callbackPage'] = request.callback_page
        if not UtilClient.is_unset(request.extend_param):
            body['extendParam'] = request.extend_param
        if not UtilClient.is_unset(request.goods_code):
            body['goodsCode'] = request.goods_code
        if not UtilClient.is_unset(request.item_code):
            body['itemCode'] = request.item_code
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
            action='GetInAppSkuUrl',
            version='appMarket_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/appMarket/internals/skuPages/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkapp_market__1__0_models.GetInAppSkuUrlResponse(),
            self.execute(params, req, runtime)
        )

    async def get_in_app_sku_url_with_options_async(
        self,
        request: dingtalkapp_market__1__0_models.GetInAppSkuUrlRequest,
        headers: dingtalkapp_market__1__0_models.GetInAppSkuUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkapp_market__1__0_models.GetInAppSkuUrlResponse:
        """
        @summary 获取内购商品SKU页面地址
        
        @param request: GetInAppSkuUrlRequest
        @param headers: GetInAppSkuUrlHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetInAppSkuUrlResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.callback_page):
            body['callbackPage'] = request.callback_page
        if not UtilClient.is_unset(request.extend_param):
            body['extendParam'] = request.extend_param
        if not UtilClient.is_unset(request.goods_code):
            body['goodsCode'] = request.goods_code
        if not UtilClient.is_unset(request.item_code):
            body['itemCode'] = request.item_code
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
            action='GetInAppSkuUrl',
            version='appMarket_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/appMarket/internals/skuPages/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkapp_market__1__0_models.GetInAppSkuUrlResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_in_app_sku_url(
        self,
        request: dingtalkapp_market__1__0_models.GetInAppSkuUrlRequest,
    ) -> dingtalkapp_market__1__0_models.GetInAppSkuUrlResponse:
        """
        @summary 获取内购商品SKU页面地址
        
        @param request: GetInAppSkuUrlRequest
        @return: GetInAppSkuUrlResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkapp_market__1__0_models.GetInAppSkuUrlHeaders()
        return self.get_in_app_sku_url_with_options(request, headers, runtime)

    async def get_in_app_sku_url_async(
        self,
        request: dingtalkapp_market__1__0_models.GetInAppSkuUrlRequest,
    ) -> dingtalkapp_market__1__0_models.GetInAppSkuUrlResponse:
        """
        @summary 获取内购商品SKU页面地址
        
        @param request: GetInAppSkuUrlRequest
        @return: GetInAppSkuUrlResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkapp_market__1__0_models.GetInAppSkuUrlHeaders()
        return await self.get_in_app_sku_url_with_options_async(request, headers, runtime)

    def get_personal_experience_info_with_options(
        self,
        request: dingtalkapp_market__1__0_models.GetPersonalExperienceInfoRequest,
        headers: dingtalkapp_market__1__0_models.GetPersonalExperienceInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkapp_market__1__0_models.GetPersonalExperienceInfoResponse:
        """
        @summary 获取个人体验相关信息
        
        @param request: GetPersonalExperienceInfoRequest
        @param headers: GetPersonalExperienceInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetPersonalExperienceInfoResponse
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
            action='GetPersonalExperienceInfo',
            version='appMarket_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/appMarket/personalExperiences',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkapp_market__1__0_models.GetPersonalExperienceInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def get_personal_experience_info_with_options_async(
        self,
        request: dingtalkapp_market__1__0_models.GetPersonalExperienceInfoRequest,
        headers: dingtalkapp_market__1__0_models.GetPersonalExperienceInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkapp_market__1__0_models.GetPersonalExperienceInfoResponse:
        """
        @summary 获取个人体验相关信息
        
        @param request: GetPersonalExperienceInfoRequest
        @param headers: GetPersonalExperienceInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetPersonalExperienceInfoResponse
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
            action='GetPersonalExperienceInfo',
            version='appMarket_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/appMarket/personalExperiences',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkapp_market__1__0_models.GetPersonalExperienceInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_personal_experience_info(
        self,
        request: dingtalkapp_market__1__0_models.GetPersonalExperienceInfoRequest,
    ) -> dingtalkapp_market__1__0_models.GetPersonalExperienceInfoResponse:
        """
        @summary 获取个人体验相关信息
        
        @param request: GetPersonalExperienceInfoRequest
        @return: GetPersonalExperienceInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkapp_market__1__0_models.GetPersonalExperienceInfoHeaders()
        return self.get_personal_experience_info_with_options(request, headers, runtime)

    async def get_personal_experience_info_async(
        self,
        request: dingtalkapp_market__1__0_models.GetPersonalExperienceInfoRequest,
    ) -> dingtalkapp_market__1__0_models.GetPersonalExperienceInfoResponse:
        """
        @summary 获取个人体验相关信息
        
        @param request: GetPersonalExperienceInfoRequest
        @return: GetPersonalExperienceInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkapp_market__1__0_models.GetPersonalExperienceInfoHeaders()
        return await self.get_personal_experience_info_with_options_async(request, headers, runtime)

    def query_market_order_with_options(
        self,
        order_id: str,
        headers: dingtalkapp_market__1__0_models.QueryMarketOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkapp_market__1__0_models.QueryMarketOrderResponse:
        """
        @summary 应用市场订单查询
        
        @param headers: QueryMarketOrderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryMarketOrderResponse
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
            action='QueryMarketOrder',
            version='appMarket_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/appMarket/orders/{order_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkapp_market__1__0_models.QueryMarketOrderResponse(),
            self.execute(params, req, runtime)
        )

    async def query_market_order_with_options_async(
        self,
        order_id: str,
        headers: dingtalkapp_market__1__0_models.QueryMarketOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkapp_market__1__0_models.QueryMarketOrderResponse:
        """
        @summary 应用市场订单查询
        
        @param headers: QueryMarketOrderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryMarketOrderResponse
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
            action='QueryMarketOrder',
            version='appMarket_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/appMarket/orders/{order_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkapp_market__1__0_models.QueryMarketOrderResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_market_order(
        self,
        order_id: str,
    ) -> dingtalkapp_market__1__0_models.QueryMarketOrderResponse:
        """
        @summary 应用市场订单查询
        
        @return: QueryMarketOrderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkapp_market__1__0_models.QueryMarketOrderHeaders()
        return self.query_market_order_with_options(order_id, headers, runtime)

    async def query_market_order_async(
        self,
        order_id: str,
    ) -> dingtalkapp_market__1__0_models.QueryMarketOrderResponse:
        """
        @summary 应用市场订单查询
        
        @return: QueryMarketOrderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkapp_market__1__0_models.QueryMarketOrderHeaders()
        return await self.query_market_order_with_options_async(order_id, headers, runtime)

    def user_task_report_with_options(
        self,
        request: dingtalkapp_market__1__0_models.UserTaskReportRequest,
        headers: dingtalkapp_market__1__0_models.UserTaskReportHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkapp_market__1__0_models.UserTaskReportResponse:
        """
        @summary app内用户操作任务同步
        
        @param request: UserTaskReportRequest
        @param headers: UserTaskReportHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UserTaskReportResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_no):
            body['bizNo'] = request.biz_no
        if not UtilClient.is_unset(request.operate_date):
            body['operateDate'] = request.operate_date
        if not UtilClient.is_unset(request.task_tag):
            body['taskTag'] = request.task_tag
        if not UtilClient.is_unset(request.userid):
            body['userid'] = request.userid
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
            action='UserTaskReport',
            version='appMarket_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/appMarket/tasks',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='boolean'
        )
        return TeaCore.from_map(
            dingtalkapp_market__1__0_models.UserTaskReportResponse(),
            self.execute(params, req, runtime)
        )

    async def user_task_report_with_options_async(
        self,
        request: dingtalkapp_market__1__0_models.UserTaskReportRequest,
        headers: dingtalkapp_market__1__0_models.UserTaskReportHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkapp_market__1__0_models.UserTaskReportResponse:
        """
        @summary app内用户操作任务同步
        
        @param request: UserTaskReportRequest
        @param headers: UserTaskReportHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UserTaskReportResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_no):
            body['bizNo'] = request.biz_no
        if not UtilClient.is_unset(request.operate_date):
            body['operateDate'] = request.operate_date
        if not UtilClient.is_unset(request.task_tag):
            body['taskTag'] = request.task_tag
        if not UtilClient.is_unset(request.userid):
            body['userid'] = request.userid
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
            action='UserTaskReport',
            version='appMarket_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/appMarket/tasks',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='boolean'
        )
        return TeaCore.from_map(
            dingtalkapp_market__1__0_models.UserTaskReportResponse(),
            await self.execute_async(params, req, runtime)
        )

    def user_task_report(
        self,
        request: dingtalkapp_market__1__0_models.UserTaskReportRequest,
    ) -> dingtalkapp_market__1__0_models.UserTaskReportResponse:
        """
        @summary app内用户操作任务同步
        
        @param request: UserTaskReportRequest
        @return: UserTaskReportResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkapp_market__1__0_models.UserTaskReportHeaders()
        return self.user_task_report_with_options(request, headers, runtime)

    async def user_task_report_async(
        self,
        request: dingtalkapp_market__1__0_models.UserTaskReportRequest,
    ) -> dingtalkapp_market__1__0_models.UserTaskReportResponse:
        """
        @summary app内用户操作任务同步
        
        @param request: UserTaskReportRequest
        @return: UserTaskReportResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkapp_market__1__0_models.UserTaskReportHeaders()
        return await self.user_task_report_with_options_async(request, headers, runtime)
