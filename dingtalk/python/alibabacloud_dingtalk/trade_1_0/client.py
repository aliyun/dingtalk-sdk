# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.trade_1_0 import models as dingtalktrade__1__0_models
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

    def check_opportunity_result_with_options(
        self,
        request: dingtalktrade__1__0_models.CheckOpportunityResultRequest,
        headers: dingtalktrade__1__0_models.CheckOpportunityResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktrade__1__0_models.CheckOpportunityResultResponse:
        """
        @summary isv检查商机创建是否符合预期
        
        @param request: CheckOpportunityResultRequest
        @param headers: CheckOpportunityResultHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CheckOpportunityResultResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.belong_to_phone_num):
            query['belongToPhoneNum'] = request.belong_to_phone_num
        if not UtilClient.is_unset(request.contact_phone_num):
            query['contactPhoneNum'] = request.contact_phone_num
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.market_code):
            query['marketCode'] = request.market_code
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
            action='CheckOpportunityResult',
            version='trade_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/trade/opportunity/check',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktrade__1__0_models.CheckOpportunityResultResponse(),
            self.execute(params, req, runtime)
        )

    async def check_opportunity_result_with_options_async(
        self,
        request: dingtalktrade__1__0_models.CheckOpportunityResultRequest,
        headers: dingtalktrade__1__0_models.CheckOpportunityResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktrade__1__0_models.CheckOpportunityResultResponse:
        """
        @summary isv检查商机创建是否符合预期
        
        @param request: CheckOpportunityResultRequest
        @param headers: CheckOpportunityResultHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CheckOpportunityResultResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.belong_to_phone_num):
            query['belongToPhoneNum'] = request.belong_to_phone_num
        if not UtilClient.is_unset(request.contact_phone_num):
            query['contactPhoneNum'] = request.contact_phone_num
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.market_code):
            query['marketCode'] = request.market_code
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
            action='CheckOpportunityResult',
            version='trade_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/trade/opportunity/check',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktrade__1__0_models.CheckOpportunityResultResponse(),
            await self.execute_async(params, req, runtime)
        )

    def check_opportunity_result(
        self,
        request: dingtalktrade__1__0_models.CheckOpportunityResultRequest,
    ) -> dingtalktrade__1__0_models.CheckOpportunityResultResponse:
        """
        @summary isv检查商机创建是否符合预期
        
        @param request: CheckOpportunityResultRequest
        @return: CheckOpportunityResultResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktrade__1__0_models.CheckOpportunityResultHeaders()
        return self.check_opportunity_result_with_options(request, headers, runtime)

    async def check_opportunity_result_async(
        self,
        request: dingtalktrade__1__0_models.CheckOpportunityResultRequest,
    ) -> dingtalktrade__1__0_models.CheckOpportunityResultResponse:
        """
        @summary isv检查商机创建是否符合预期
        
        @param request: CheckOpportunityResultRequest
        @return: CheckOpportunityResultResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktrade__1__0_models.CheckOpportunityResultHeaders()
        return await self.check_opportunity_result_with_options_async(request, headers, runtime)

    def create_clue_temp_with_options(
        self,
        request: dingtalktrade__1__0_models.CreateClueTempRequest,
        headers: dingtalktrade__1__0_models.CreateClueTempHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktrade__1__0_models.CreateClueTempResponse:
        """
        @summary 用于客户跟进线索创建
        
        @param request: CreateClueTempRequest
        @param headers: CreateClueTempHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateClueTempResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.address):
            body['address'] = request.address
        if not UtilClient.is_unset(request.contact_name):
            body['contactName'] = request.contact_name
        if not UtilClient.is_unset(request.dept_id):
            body['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.ext):
            body['ext'] = request.ext
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.phone_num):
            body['phoneNum'] = request.phone_num
        if not UtilClient.is_unset(request.position):
            body['position'] = request.position
        if not UtilClient.is_unset(request.product_code):
            body['productCode'] = request.product_code
        if not UtilClient.is_unset(request.sales_id):
            body['salesId'] = request.sales_id
        if not UtilClient.is_unset(request.source):
            body['source'] = request.source
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
            action='CreateClueTemp',
            version='trade_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/trade/clueTemps',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktrade__1__0_models.CreateClueTempResponse(),
            self.execute(params, req, runtime)
        )

    async def create_clue_temp_with_options_async(
        self,
        request: dingtalktrade__1__0_models.CreateClueTempRequest,
        headers: dingtalktrade__1__0_models.CreateClueTempHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktrade__1__0_models.CreateClueTempResponse:
        """
        @summary 用于客户跟进线索创建
        
        @param request: CreateClueTempRequest
        @param headers: CreateClueTempHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateClueTempResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.address):
            body['address'] = request.address
        if not UtilClient.is_unset(request.contact_name):
            body['contactName'] = request.contact_name
        if not UtilClient.is_unset(request.dept_id):
            body['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.ext):
            body['ext'] = request.ext
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.phone_num):
            body['phoneNum'] = request.phone_num
        if not UtilClient.is_unset(request.position):
            body['position'] = request.position
        if not UtilClient.is_unset(request.product_code):
            body['productCode'] = request.product_code
        if not UtilClient.is_unset(request.sales_id):
            body['salesId'] = request.sales_id
        if not UtilClient.is_unset(request.source):
            body['source'] = request.source
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
            action='CreateClueTemp',
            version='trade_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/trade/clueTemps',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktrade__1__0_models.CreateClueTempResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_clue_temp(
        self,
        request: dingtalktrade__1__0_models.CreateClueTempRequest,
    ) -> dingtalktrade__1__0_models.CreateClueTempResponse:
        """
        @summary 用于客户跟进线索创建
        
        @param request: CreateClueTempRequest
        @return: CreateClueTempResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktrade__1__0_models.CreateClueTempHeaders()
        return self.create_clue_temp_with_options(request, headers, runtime)

    async def create_clue_temp_async(
        self,
        request: dingtalktrade__1__0_models.CreateClueTempRequest,
    ) -> dingtalktrade__1__0_models.CreateClueTempResponse:
        """
        @summary 用于客户跟进线索创建
        
        @param request: CreateClueTempRequest
        @return: CreateClueTempResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktrade__1__0_models.CreateClueTempHeaders()
        return await self.create_clue_temp_with_options_async(request, headers, runtime)

    def create_note_for_isv_with_options(
        self,
        request: dingtalktrade__1__0_models.CreateNoteForIsvRequest,
        headers: dingtalktrade__1__0_models.CreateNoteForIsvHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktrade__1__0_models.CreateNoteForIsvResponse:
        """
        @summary 创建小记
        
        @param request: CreateNoteForIsvRequest
        @param headers: CreateNoteForIsvHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateNoteForIsvResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.contact_name):
            body['contactName'] = request.contact_name
        if not UtilClient.is_unset(request.contact_phone_num):
            body['contactPhoneNum'] = request.contact_phone_num
        if not UtilClient.is_unset(request.contact_title):
            body['contactTitle'] = request.contact_title
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.input_phone_num):
            body['inputPhoneNum'] = request.input_phone_num
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
            action='CreateNoteForIsv',
            version='trade_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/trade/notes',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktrade__1__0_models.CreateNoteForIsvResponse(),
            self.execute(params, req, runtime)
        )

    async def create_note_for_isv_with_options_async(
        self,
        request: dingtalktrade__1__0_models.CreateNoteForIsvRequest,
        headers: dingtalktrade__1__0_models.CreateNoteForIsvHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktrade__1__0_models.CreateNoteForIsvResponse:
        """
        @summary 创建小记
        
        @param request: CreateNoteForIsvRequest
        @param headers: CreateNoteForIsvHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateNoteForIsvResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.contact_name):
            body['contactName'] = request.contact_name
        if not UtilClient.is_unset(request.contact_phone_num):
            body['contactPhoneNum'] = request.contact_phone_num
        if not UtilClient.is_unset(request.contact_title):
            body['contactTitle'] = request.contact_title
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.input_phone_num):
            body['inputPhoneNum'] = request.input_phone_num
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
            action='CreateNoteForIsv',
            version='trade_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/trade/notes',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktrade__1__0_models.CreateNoteForIsvResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_note_for_isv(
        self,
        request: dingtalktrade__1__0_models.CreateNoteForIsvRequest,
    ) -> dingtalktrade__1__0_models.CreateNoteForIsvResponse:
        """
        @summary 创建小记
        
        @param request: CreateNoteForIsvRequest
        @return: CreateNoteForIsvResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktrade__1__0_models.CreateNoteForIsvHeaders()
        return self.create_note_for_isv_with_options(request, headers, runtime)

    async def create_note_for_isv_async(
        self,
        request: dingtalktrade__1__0_models.CreateNoteForIsvRequest,
    ) -> dingtalktrade__1__0_models.CreateNoteForIsvResponse:
        """
        @summary 创建小记
        
        @param request: CreateNoteForIsvRequest
        @return: CreateNoteForIsvResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktrade__1__0_models.CreateNoteForIsvHeaders()
        return await self.create_note_for_isv_with_options_async(request, headers, runtime)

    def create_opportunity_with_options(
        self,
        request: dingtalktrade__1__0_models.CreateOpportunityRequest,
        headers: dingtalktrade__1__0_models.CreateOpportunityHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktrade__1__0_models.CreateOpportunityResponse:
        """
        @summary isv创建商机
        
        @param request: CreateOpportunityRequest
        @param headers: CreateOpportunityHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateOpportunityResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.belong_to_phone_num):
            body['belongToPhoneNum'] = request.belong_to_phone_num
        if not UtilClient.is_unset(request.contact_phone_num):
            body['contactPhoneNum'] = request.contact_phone_num
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.dept_id):
            body['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.market_code):
            body['marketCode'] = request.market_code
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
            action='CreateOpportunity',
            version='trade_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/trade/opportunities',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktrade__1__0_models.CreateOpportunityResponse(),
            self.execute(params, req, runtime)
        )

    async def create_opportunity_with_options_async(
        self,
        request: dingtalktrade__1__0_models.CreateOpportunityRequest,
        headers: dingtalktrade__1__0_models.CreateOpportunityHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktrade__1__0_models.CreateOpportunityResponse:
        """
        @summary isv创建商机
        
        @param request: CreateOpportunityRequest
        @param headers: CreateOpportunityHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateOpportunityResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.belong_to_phone_num):
            body['belongToPhoneNum'] = request.belong_to_phone_num
        if not UtilClient.is_unset(request.contact_phone_num):
            body['contactPhoneNum'] = request.contact_phone_num
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.dept_id):
            body['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.market_code):
            body['marketCode'] = request.market_code
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
            action='CreateOpportunity',
            version='trade_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/trade/opportunities',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktrade__1__0_models.CreateOpportunityResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_opportunity(
        self,
        request: dingtalktrade__1__0_models.CreateOpportunityRequest,
    ) -> dingtalktrade__1__0_models.CreateOpportunityResponse:
        """
        @summary isv创建商机
        
        @param request: CreateOpportunityRequest
        @return: CreateOpportunityResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktrade__1__0_models.CreateOpportunityHeaders()
        return self.create_opportunity_with_options(request, headers, runtime)

    async def create_opportunity_async(
        self,
        request: dingtalktrade__1__0_models.CreateOpportunityRequest,
    ) -> dingtalktrade__1__0_models.CreateOpportunityResponse:
        """
        @summary isv创建商机
        
        @param request: CreateOpportunityRequest
        @return: CreateOpportunityResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktrade__1__0_models.CreateOpportunityHeaders()
        return await self.create_opportunity_with_options_async(request, headers, runtime)

    def query_trade_order_with_options(
        self,
        request: dingtalktrade__1__0_models.QueryTradeOrderRequest,
        headers: dingtalktrade__1__0_models.QueryTradeOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktrade__1__0_models.QueryTradeOrderResponse:
        """
        @summary 查询订单信息
        
        @param request: QueryTradeOrderRequest
        @param headers: QueryTradeOrderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryTradeOrderResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.order_id):
            body['orderId'] = request.order_id
        if not UtilClient.is_unset(request.outer_order_id):
            body['outerOrderId'] = request.outer_order_id
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
            action='QueryTradeOrder',
            version='trade_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/trade/orders/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktrade__1__0_models.QueryTradeOrderResponse(),
            self.execute(params, req, runtime)
        )

    async def query_trade_order_with_options_async(
        self,
        request: dingtalktrade__1__0_models.QueryTradeOrderRequest,
        headers: dingtalktrade__1__0_models.QueryTradeOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktrade__1__0_models.QueryTradeOrderResponse:
        """
        @summary 查询订单信息
        
        @param request: QueryTradeOrderRequest
        @param headers: QueryTradeOrderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryTradeOrderResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.order_id):
            body['orderId'] = request.order_id
        if not UtilClient.is_unset(request.outer_order_id):
            body['outerOrderId'] = request.outer_order_id
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
            action='QueryTradeOrder',
            version='trade_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/trade/orders/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktrade__1__0_models.QueryTradeOrderResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_trade_order(
        self,
        request: dingtalktrade__1__0_models.QueryTradeOrderRequest,
    ) -> dingtalktrade__1__0_models.QueryTradeOrderResponse:
        """
        @summary 查询订单信息
        
        @param request: QueryTradeOrderRequest
        @return: QueryTradeOrderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktrade__1__0_models.QueryTradeOrderHeaders()
        return self.query_trade_order_with_options(request, headers, runtime)

    async def query_trade_order_async(
        self,
        request: dingtalktrade__1__0_models.QueryTradeOrderRequest,
    ) -> dingtalktrade__1__0_models.QueryTradeOrderResponse:
        """
        @summary 查询订单信息
        
        @param request: QueryTradeOrderRequest
        @return: QueryTradeOrderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktrade__1__0_models.QueryTradeOrderHeaders()
        return await self.query_trade_order_with_options_async(request, headers, runtime)
