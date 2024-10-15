# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.wms_1_0 import models as dingtalkwms__1__0_models
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

    def query_goods_list_with_options(
        self,
        request: dingtalkwms__1__0_models.QueryGoodsListRequest,
        headers: dingtalkwms__1__0_models.QueryGoodsListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkwms__1__0_models.QueryGoodsListResponse:
        """
        @summary 获取物料列表
        
        @param request: QueryGoodsListRequest
        @param headers: QueryGoodsListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryGoodsListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.end_time_in_mills):
            query['endTimeInMills'] = request.end_time_in_mills
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.start_time_in_mills):
            query['startTimeInMills'] = request.start_time_in_mills
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
            action='QueryGoodsList',
            version='wms_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/wms/goods',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkwms__1__0_models.QueryGoodsListResponse(),
            self.execute(params, req, runtime)
        )

    async def query_goods_list_with_options_async(
        self,
        request: dingtalkwms__1__0_models.QueryGoodsListRequest,
        headers: dingtalkwms__1__0_models.QueryGoodsListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkwms__1__0_models.QueryGoodsListResponse:
        """
        @summary 获取物料列表
        
        @param request: QueryGoodsListRequest
        @param headers: QueryGoodsListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryGoodsListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.end_time_in_mills):
            query['endTimeInMills'] = request.end_time_in_mills
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.start_time_in_mills):
            query['startTimeInMills'] = request.start_time_in_mills
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
            action='QueryGoodsList',
            version='wms_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/wms/goods',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkwms__1__0_models.QueryGoodsListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_goods_list(
        self,
        request: dingtalkwms__1__0_models.QueryGoodsListRequest,
    ) -> dingtalkwms__1__0_models.QueryGoodsListResponse:
        """
        @summary 获取物料列表
        
        @param request: QueryGoodsListRequest
        @return: QueryGoodsListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkwms__1__0_models.QueryGoodsListHeaders()
        return self.query_goods_list_with_options(request, headers, runtime)

    async def query_goods_list_async(
        self,
        request: dingtalkwms__1__0_models.QueryGoodsListRequest,
    ) -> dingtalkwms__1__0_models.QueryGoodsListResponse:
        """
        @summary 获取物料列表
        
        @param request: QueryGoodsListRequest
        @return: QueryGoodsListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkwms__1__0_models.QueryGoodsListHeaders()
        return await self.query_goods_list_with_options_async(request, headers, runtime)
