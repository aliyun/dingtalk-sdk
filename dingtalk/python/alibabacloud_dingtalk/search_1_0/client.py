# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.search_1_0 import models as dingtalksearch__1__0_models
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

    def batch_insert_search_item_with_options(
        self,
        tab_id: str,
        request: dingtalksearch__1__0_models.BatchInsertSearchItemRequest,
        headers: dingtalksearch__1__0_models.BatchInsertSearchItemHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksearch__1__0_models.BatchInsertSearchItemResponse:
        """
        @summary 为指定的数据源批量添加数据项
        
        @param request: BatchInsertSearchItemRequest
        @param headers: BatchInsertSearchItemHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchInsertSearchItemResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.search_item_models):
            body['searchItemModels'] = request.search_item_models
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
            action='BatchInsertSearchItem',
            version='search_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/search/tabs/{tab_id}/items/batch',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalksearch__1__0_models.BatchInsertSearchItemResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_insert_search_item_with_options_async(
        self,
        tab_id: str,
        request: dingtalksearch__1__0_models.BatchInsertSearchItemRequest,
        headers: dingtalksearch__1__0_models.BatchInsertSearchItemHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksearch__1__0_models.BatchInsertSearchItemResponse:
        """
        @summary 为指定的数据源批量添加数据项
        
        @param request: BatchInsertSearchItemRequest
        @param headers: BatchInsertSearchItemHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchInsertSearchItemResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.search_item_models):
            body['searchItemModels'] = request.search_item_models
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
            action='BatchInsertSearchItem',
            version='search_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/search/tabs/{tab_id}/items/batch',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalksearch__1__0_models.BatchInsertSearchItemResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch_insert_search_item(
        self,
        tab_id: str,
        request: dingtalksearch__1__0_models.BatchInsertSearchItemRequest,
    ) -> dingtalksearch__1__0_models.BatchInsertSearchItemResponse:
        """
        @summary 为指定的数据源批量添加数据项
        
        @param request: BatchInsertSearchItemRequest
        @return: BatchInsertSearchItemResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksearch__1__0_models.BatchInsertSearchItemHeaders()
        return self.batch_insert_search_item_with_options(tab_id, request, headers, runtime)

    async def batch_insert_search_item_async(
        self,
        tab_id: str,
        request: dingtalksearch__1__0_models.BatchInsertSearchItemRequest,
    ) -> dingtalksearch__1__0_models.BatchInsertSearchItemResponse:
        """
        @summary 为指定的数据源批量添加数据项
        
        @param request: BatchInsertSearchItemRequest
        @return: BatchInsertSearchItemResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksearch__1__0_models.BatchInsertSearchItemHeaders()
        return await self.batch_insert_search_item_with_options_async(tab_id, request, headers, runtime)

    def create_search_tab_with_options(
        self,
        request: dingtalksearch__1__0_models.CreateSearchTabRequest,
        headers: dingtalksearch__1__0_models.CreateSearchTabHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksearch__1__0_models.CreateSearchTabResponse:
        """
        @summary 创建搜索数据源
        
        @param request: CreateSearchTabRequest
        @param headers: CreateSearchTabHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateSearchTabResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dark_icon):
            body['darkIcon'] = request.dark_icon
        if not UtilClient.is_unset(request.icon):
            body['icon'] = request.icon
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.priority):
            body['priority'] = request.priority
        if not UtilClient.is_unset(request.source):
            body['source'] = request.source
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
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
            action='CreateSearchTab',
            version='search_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/search/tabs',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalksearch__1__0_models.CreateSearchTabResponse(),
            self.execute(params, req, runtime)
        )

    async def create_search_tab_with_options_async(
        self,
        request: dingtalksearch__1__0_models.CreateSearchTabRequest,
        headers: dingtalksearch__1__0_models.CreateSearchTabHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksearch__1__0_models.CreateSearchTabResponse:
        """
        @summary 创建搜索数据源
        
        @param request: CreateSearchTabRequest
        @param headers: CreateSearchTabHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateSearchTabResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dark_icon):
            body['darkIcon'] = request.dark_icon
        if not UtilClient.is_unset(request.icon):
            body['icon'] = request.icon
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.priority):
            body['priority'] = request.priority
        if not UtilClient.is_unset(request.source):
            body['source'] = request.source
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
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
            action='CreateSearchTab',
            version='search_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/search/tabs',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalksearch__1__0_models.CreateSearchTabResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_search_tab(
        self,
        request: dingtalksearch__1__0_models.CreateSearchTabRequest,
    ) -> dingtalksearch__1__0_models.CreateSearchTabResponse:
        """
        @summary 创建搜索数据源
        
        @param request: CreateSearchTabRequest
        @return: CreateSearchTabResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksearch__1__0_models.CreateSearchTabHeaders()
        return self.create_search_tab_with_options(request, headers, runtime)

    async def create_search_tab_async(
        self,
        request: dingtalksearch__1__0_models.CreateSearchTabRequest,
    ) -> dingtalksearch__1__0_models.CreateSearchTabResponse:
        """
        @summary 创建搜索数据源
        
        @param request: CreateSearchTabRequest
        @return: CreateSearchTabResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksearch__1__0_models.CreateSearchTabHeaders()
        return await self.create_search_tab_with_options_async(request, headers, runtime)

    def delete_search_item_with_options(
        self,
        tab_id: str,
        item_id: str,
        headers: dingtalksearch__1__0_models.DeleteSearchItemHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksearch__1__0_models.DeleteSearchItemResponse:
        """
        @summary 从指定的数据源中删除一条数据项
        
        @param headers: DeleteSearchItemHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteSearchItemResponse
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
            action='DeleteSearchItem',
            version='search_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/search/tabs/{tab_id}/items/{item_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalksearch__1__0_models.DeleteSearchItemResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_search_item_with_options_async(
        self,
        tab_id: str,
        item_id: str,
        headers: dingtalksearch__1__0_models.DeleteSearchItemHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksearch__1__0_models.DeleteSearchItemResponse:
        """
        @summary 从指定的数据源中删除一条数据项
        
        @param headers: DeleteSearchItemHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteSearchItemResponse
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
            action='DeleteSearchItem',
            version='search_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/search/tabs/{tab_id}/items/{item_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalksearch__1__0_models.DeleteSearchItemResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_search_item(
        self,
        tab_id: str,
        item_id: str,
    ) -> dingtalksearch__1__0_models.DeleteSearchItemResponse:
        """
        @summary 从指定的数据源中删除一条数据项
        
        @return: DeleteSearchItemResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksearch__1__0_models.DeleteSearchItemHeaders()
        return self.delete_search_item_with_options(tab_id, item_id, headers, runtime)

    async def delete_search_item_async(
        self,
        tab_id: str,
        item_id: str,
    ) -> dingtalksearch__1__0_models.DeleteSearchItemResponse:
        """
        @summary 从指定的数据源中删除一条数据项
        
        @return: DeleteSearchItemResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksearch__1__0_models.DeleteSearchItemHeaders()
        return await self.delete_search_item_with_options_async(tab_id, item_id, headers, runtime)

    def delete_search_tab_with_options(
        self,
        tab_id: str,
        headers: dingtalksearch__1__0_models.DeleteSearchTabHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksearch__1__0_models.DeleteSearchTabResponse:
        """
        @summary 删除搜索数据源
        
        @param headers: DeleteSearchTabHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteSearchTabResponse
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
            action='DeleteSearchTab',
            version='search_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/search/tabs/{tab_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalksearch__1__0_models.DeleteSearchTabResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_search_tab_with_options_async(
        self,
        tab_id: str,
        headers: dingtalksearch__1__0_models.DeleteSearchTabHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksearch__1__0_models.DeleteSearchTabResponse:
        """
        @summary 删除搜索数据源
        
        @param headers: DeleteSearchTabHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteSearchTabResponse
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
            action='DeleteSearchTab',
            version='search_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/search/tabs/{tab_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalksearch__1__0_models.DeleteSearchTabResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_search_tab(
        self,
        tab_id: str,
    ) -> dingtalksearch__1__0_models.DeleteSearchTabResponse:
        """
        @summary 删除搜索数据源
        
        @return: DeleteSearchTabResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksearch__1__0_models.DeleteSearchTabHeaders()
        return self.delete_search_tab_with_options(tab_id, headers, runtime)

    async def delete_search_tab_async(
        self,
        tab_id: str,
    ) -> dingtalksearch__1__0_models.DeleteSearchTabResponse:
        """
        @summary 删除搜索数据源
        
        @return: DeleteSearchTabResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksearch__1__0_models.DeleteSearchTabHeaders()
        return await self.delete_search_tab_with_options_async(tab_id, headers, runtime)

    def get_search_item_with_options(
        self,
        tab_id: str,
        item_id: str,
        headers: dingtalksearch__1__0_models.GetSearchItemHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksearch__1__0_models.GetSearchItemResponse:
        """
        @summary 获取指定数据源中的一条数据项
        
        @param headers: GetSearchItemHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSearchItemResponse
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
            action='GetSearchItem',
            version='search_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/search/tabs/{tab_id}/items/{item_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalksearch__1__0_models.GetSearchItemResponse(),
            self.execute(params, req, runtime)
        )

    async def get_search_item_with_options_async(
        self,
        tab_id: str,
        item_id: str,
        headers: dingtalksearch__1__0_models.GetSearchItemHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksearch__1__0_models.GetSearchItemResponse:
        """
        @summary 获取指定数据源中的一条数据项
        
        @param headers: GetSearchItemHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSearchItemResponse
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
            action='GetSearchItem',
            version='search_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/search/tabs/{tab_id}/items/{item_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalksearch__1__0_models.GetSearchItemResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_search_item(
        self,
        tab_id: str,
        item_id: str,
    ) -> dingtalksearch__1__0_models.GetSearchItemResponse:
        """
        @summary 获取指定数据源中的一条数据项
        
        @return: GetSearchItemResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksearch__1__0_models.GetSearchItemHeaders()
        return self.get_search_item_with_options(tab_id, item_id, headers, runtime)

    async def get_search_item_async(
        self,
        tab_id: str,
        item_id: str,
    ) -> dingtalksearch__1__0_models.GetSearchItemResponse:
        """
        @summary 获取指定数据源中的一条数据项
        
        @return: GetSearchItemResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksearch__1__0_models.GetSearchItemHeaders()
        return await self.get_search_item_with_options_async(tab_id, item_id, headers, runtime)

    def get_search_items_by_key_word_with_options(
        self,
        tab_id: str,
        request: dingtalksearch__1__0_models.GetSearchItemsByKeyWordRequest,
        headers: dingtalksearch__1__0_models.GetSearchItemsByKeyWordHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksearch__1__0_models.GetSearchItemsByKeyWordResponse:
        """
        @summary 根据搜索关键词获取相关数据项
        
        @param request: GetSearchItemsByKeyWordRequest
        @param headers: GetSearchItemsByKeyWordHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSearchItemsByKeyWordResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.key_word):
            query['keyWord'] = request.key_word
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
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
            action='GetSearchItemsByKeyWord',
            version='search_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/search/tabs/{tab_id}/items',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalksearch__1__0_models.GetSearchItemsByKeyWordResponse(),
            self.execute(params, req, runtime)
        )

    async def get_search_items_by_key_word_with_options_async(
        self,
        tab_id: str,
        request: dingtalksearch__1__0_models.GetSearchItemsByKeyWordRequest,
        headers: dingtalksearch__1__0_models.GetSearchItemsByKeyWordHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksearch__1__0_models.GetSearchItemsByKeyWordResponse:
        """
        @summary 根据搜索关键词获取相关数据项
        
        @param request: GetSearchItemsByKeyWordRequest
        @param headers: GetSearchItemsByKeyWordHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSearchItemsByKeyWordResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.key_word):
            query['keyWord'] = request.key_word
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
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
            action='GetSearchItemsByKeyWord',
            version='search_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/search/tabs/{tab_id}/items',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalksearch__1__0_models.GetSearchItemsByKeyWordResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_search_items_by_key_word(
        self,
        tab_id: str,
        request: dingtalksearch__1__0_models.GetSearchItemsByKeyWordRequest,
    ) -> dingtalksearch__1__0_models.GetSearchItemsByKeyWordResponse:
        """
        @summary 根据搜索关键词获取相关数据项
        
        @param request: GetSearchItemsByKeyWordRequest
        @return: GetSearchItemsByKeyWordResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksearch__1__0_models.GetSearchItemsByKeyWordHeaders()
        return self.get_search_items_by_key_word_with_options(tab_id, request, headers, runtime)

    async def get_search_items_by_key_word_async(
        self,
        tab_id: str,
        request: dingtalksearch__1__0_models.GetSearchItemsByKeyWordRequest,
    ) -> dingtalksearch__1__0_models.GetSearchItemsByKeyWordResponse:
        """
        @summary 根据搜索关键词获取相关数据项
        
        @param request: GetSearchItemsByKeyWordRequest
        @return: GetSearchItemsByKeyWordResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksearch__1__0_models.GetSearchItemsByKeyWordHeaders()
        return await self.get_search_items_by_key_word_with_options_async(tab_id, request, headers, runtime)

    def get_search_tab_with_options(
        self,
        tab_id: str,
        headers: dingtalksearch__1__0_models.GetSearchTabHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksearch__1__0_models.GetSearchTabResponse:
        """
        @summary 获取搜索数据源
        
        @param headers: GetSearchTabHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSearchTabResponse
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
            action='GetSearchTab',
            version='search_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/search/tabs/{tab_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalksearch__1__0_models.GetSearchTabResponse(),
            self.execute(params, req, runtime)
        )

    async def get_search_tab_with_options_async(
        self,
        tab_id: str,
        headers: dingtalksearch__1__0_models.GetSearchTabHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksearch__1__0_models.GetSearchTabResponse:
        """
        @summary 获取搜索数据源
        
        @param headers: GetSearchTabHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSearchTabResponse
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
            action='GetSearchTab',
            version='search_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/search/tabs/{tab_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalksearch__1__0_models.GetSearchTabResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_search_tab(
        self,
        tab_id: str,
    ) -> dingtalksearch__1__0_models.GetSearchTabResponse:
        """
        @summary 获取搜索数据源
        
        @return: GetSearchTabResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksearch__1__0_models.GetSearchTabHeaders()
        return self.get_search_tab_with_options(tab_id, headers, runtime)

    async def get_search_tab_async(
        self,
        tab_id: str,
    ) -> dingtalksearch__1__0_models.GetSearchTabResponse:
        """
        @summary 获取搜索数据源
        
        @return: GetSearchTabResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksearch__1__0_models.GetSearchTabHeaders()
        return await self.get_search_tab_with_options_async(tab_id, headers, runtime)

    def insert_search_item_with_options(
        self,
        tab_id: str,
        request: dingtalksearch__1__0_models.InsertSearchItemRequest,
        headers: dingtalksearch__1__0_models.InsertSearchItemHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksearch__1__0_models.InsertSearchItemResponse:
        """
        @summary 为指定的数据源添加一条数据项
        
        @param request: InsertSearchItemRequest
        @param headers: InsertSearchItemHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: InsertSearchItemResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.footer):
            body['footer'] = request.footer
        if not UtilClient.is_unset(request.icon):
            body['icon'] = request.icon
        if not UtilClient.is_unset(request.item_id):
            body['itemId'] = request.item_id
        if not UtilClient.is_unset(request.mobile_url):
            body['mobileUrl'] = request.mobile_url
        if not UtilClient.is_unset(request.pc_url):
            body['pcUrl'] = request.pc_url
        if not UtilClient.is_unset(request.summary):
            body['summary'] = request.summary
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        if not UtilClient.is_unset(request.url):
            body['url'] = request.url
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
            action='InsertSearchItem',
            version='search_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/search/tabs/{tab_id}/items',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalksearch__1__0_models.InsertSearchItemResponse(),
            self.execute(params, req, runtime)
        )

    async def insert_search_item_with_options_async(
        self,
        tab_id: str,
        request: dingtalksearch__1__0_models.InsertSearchItemRequest,
        headers: dingtalksearch__1__0_models.InsertSearchItemHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksearch__1__0_models.InsertSearchItemResponse:
        """
        @summary 为指定的数据源添加一条数据项
        
        @param request: InsertSearchItemRequest
        @param headers: InsertSearchItemHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: InsertSearchItemResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.footer):
            body['footer'] = request.footer
        if not UtilClient.is_unset(request.icon):
            body['icon'] = request.icon
        if not UtilClient.is_unset(request.item_id):
            body['itemId'] = request.item_id
        if not UtilClient.is_unset(request.mobile_url):
            body['mobileUrl'] = request.mobile_url
        if not UtilClient.is_unset(request.pc_url):
            body['pcUrl'] = request.pc_url
        if not UtilClient.is_unset(request.summary):
            body['summary'] = request.summary
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        if not UtilClient.is_unset(request.url):
            body['url'] = request.url
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
            action='InsertSearchItem',
            version='search_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/search/tabs/{tab_id}/items',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalksearch__1__0_models.InsertSearchItemResponse(),
            await self.execute_async(params, req, runtime)
        )

    def insert_search_item(
        self,
        tab_id: str,
        request: dingtalksearch__1__0_models.InsertSearchItemRequest,
    ) -> dingtalksearch__1__0_models.InsertSearchItemResponse:
        """
        @summary 为指定的数据源添加一条数据项
        
        @param request: InsertSearchItemRequest
        @return: InsertSearchItemResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksearch__1__0_models.InsertSearchItemHeaders()
        return self.insert_search_item_with_options(tab_id, request, headers, runtime)

    async def insert_search_item_async(
        self,
        tab_id: str,
        request: dingtalksearch__1__0_models.InsertSearchItemRequest,
    ) -> dingtalksearch__1__0_models.InsertSearchItemResponse:
        """
        @summary 为指定的数据源添加一条数据项
        
        @param request: InsertSearchItemRequest
        @return: InsertSearchItemResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksearch__1__0_models.InsertSearchItemHeaders()
        return await self.insert_search_item_with_options_async(tab_id, request, headers, runtime)

    def list_search_tabs_by_org_id_with_options(
        self,
        headers: dingtalksearch__1__0_models.ListSearchTabsByOrgIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksearch__1__0_models.ListSearchTabsByOrgIdResponse:
        """
        @summary 列出企业所有的搜索数据源
        
        @param headers: ListSearchTabsByOrgIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListSearchTabsByOrgIdResponse
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
            action='ListSearchTabsByOrgId',
            version='search_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/search/tabs',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalksearch__1__0_models.ListSearchTabsByOrgIdResponse(),
            self.execute(params, req, runtime)
        )

    async def list_search_tabs_by_org_id_with_options_async(
        self,
        headers: dingtalksearch__1__0_models.ListSearchTabsByOrgIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksearch__1__0_models.ListSearchTabsByOrgIdResponse:
        """
        @summary 列出企业所有的搜索数据源
        
        @param headers: ListSearchTabsByOrgIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListSearchTabsByOrgIdResponse
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
            action='ListSearchTabsByOrgId',
            version='search_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/search/tabs',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalksearch__1__0_models.ListSearchTabsByOrgIdResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_search_tabs_by_org_id(self) -> dingtalksearch__1__0_models.ListSearchTabsByOrgIdResponse:
        """
        @summary 列出企业所有的搜索数据源
        
        @return: ListSearchTabsByOrgIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksearch__1__0_models.ListSearchTabsByOrgIdHeaders()
        return self.list_search_tabs_by_org_id_with_options(headers, runtime)

    async def list_search_tabs_by_org_id_async(self) -> dingtalksearch__1__0_models.ListSearchTabsByOrgIdResponse:
        """
        @summary 列出企业所有的搜索数据源
        
        @return: ListSearchTabsByOrgIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksearch__1__0_models.ListSearchTabsByOrgIdHeaders()
        return await self.list_search_tabs_by_org_id_with_options_async(headers, runtime)

    def update_search_tab_with_options(
        self,
        tab_id: str,
        request: dingtalksearch__1__0_models.UpdateSearchTabRequest,
        headers: dingtalksearch__1__0_models.UpdateSearchTabHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksearch__1__0_models.UpdateSearchTabResponse:
        """
        @summary 更新搜索数据源
        
        @param request: UpdateSearchTabRequest
        @param headers: UpdateSearchTabHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateSearchTabResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dark_icon):
            body['darkIcon'] = request.dark_icon
        if not UtilClient.is_unset(request.icon):
            body['icon'] = request.icon
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.priority):
            body['priority'] = request.priority
        if not UtilClient.is_unset(request.source):
            body['source'] = request.source
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
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
            action='UpdateSearchTab',
            version='search_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/search/tabs/{tab_id}',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalksearch__1__0_models.UpdateSearchTabResponse(),
            self.execute(params, req, runtime)
        )

    async def update_search_tab_with_options_async(
        self,
        tab_id: str,
        request: dingtalksearch__1__0_models.UpdateSearchTabRequest,
        headers: dingtalksearch__1__0_models.UpdateSearchTabHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksearch__1__0_models.UpdateSearchTabResponse:
        """
        @summary 更新搜索数据源
        
        @param request: UpdateSearchTabRequest
        @param headers: UpdateSearchTabHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateSearchTabResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dark_icon):
            body['darkIcon'] = request.dark_icon
        if not UtilClient.is_unset(request.icon):
            body['icon'] = request.icon
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.priority):
            body['priority'] = request.priority
        if not UtilClient.is_unset(request.source):
            body['source'] = request.source
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
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
            action='UpdateSearchTab',
            version='search_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/search/tabs/{tab_id}',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalksearch__1__0_models.UpdateSearchTabResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_search_tab(
        self,
        tab_id: str,
        request: dingtalksearch__1__0_models.UpdateSearchTabRequest,
    ) -> dingtalksearch__1__0_models.UpdateSearchTabResponse:
        """
        @summary 更新搜索数据源
        
        @param request: UpdateSearchTabRequest
        @return: UpdateSearchTabResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksearch__1__0_models.UpdateSearchTabHeaders()
        return self.update_search_tab_with_options(tab_id, request, headers, runtime)

    async def update_search_tab_async(
        self,
        tab_id: str,
        request: dingtalksearch__1__0_models.UpdateSearchTabRequest,
    ) -> dingtalksearch__1__0_models.UpdateSearchTabResponse:
        """
        @summary 更新搜索数据源
        
        @param request: UpdateSearchTabRequest
        @return: UpdateSearchTabResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksearch__1__0_models.UpdateSearchTabHeaders()
        return await self.update_search_tab_with_options_async(tab_id, request, headers, runtime)
