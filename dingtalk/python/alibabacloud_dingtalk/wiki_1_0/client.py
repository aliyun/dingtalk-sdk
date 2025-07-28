# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.wiki_1_0 import models as dingtalkwiki__1__0_models
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

    def wiki_words_detail_with_options(
        self,
        request: dingtalkwiki__1__0_models.WikiWordsDetailRequest,
        headers: dingtalkwiki__1__0_models.WikiWordsDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkwiki__1__0_models.WikiWordsDetailResponse:
        """
        @summary 根据词条名称获取该词条释义
        
        @param request: WikiWordsDetailRequest
        @param headers: WikiWordsDetailHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: WikiWordsDetailResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.word_name):
            query['wordName'] = request.word_name
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
            action='WikiWordsDetail',
            version='wiki_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/wiki/words/details',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkwiki__1__0_models.WikiWordsDetailResponse(),
            self.execute(params, req, runtime)
        )

    async def wiki_words_detail_with_options_async(
        self,
        request: dingtalkwiki__1__0_models.WikiWordsDetailRequest,
        headers: dingtalkwiki__1__0_models.WikiWordsDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkwiki__1__0_models.WikiWordsDetailResponse:
        """
        @summary 根据词条名称获取该词条释义
        
        @param request: WikiWordsDetailRequest
        @param headers: WikiWordsDetailHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: WikiWordsDetailResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.word_name):
            query['wordName'] = request.word_name
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
            action='WikiWordsDetail',
            version='wiki_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/wiki/words/details',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkwiki__1__0_models.WikiWordsDetailResponse(),
            await self.execute_async(params, req, runtime)
        )

    def wiki_words_detail(
        self,
        request: dingtalkwiki__1__0_models.WikiWordsDetailRequest,
    ) -> dingtalkwiki__1__0_models.WikiWordsDetailResponse:
        """
        @summary 根据词条名称获取该词条释义
        
        @param request: WikiWordsDetailRequest
        @return: WikiWordsDetailResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkwiki__1__0_models.WikiWordsDetailHeaders()
        return self.wiki_words_detail_with_options(request, headers, runtime)

    async def wiki_words_detail_async(
        self,
        request: dingtalkwiki__1__0_models.WikiWordsDetailRequest,
    ) -> dingtalkwiki__1__0_models.WikiWordsDetailResponse:
        """
        @summary 根据词条名称获取该词条释义
        
        @param request: WikiWordsDetailRequest
        @return: WikiWordsDetailResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkwiki__1__0_models.WikiWordsDetailHeaders()
        return await self.wiki_words_detail_with_options_async(request, headers, runtime)

    def wiki_words_parse_with_options(
        self,
        request: dingtalkwiki__1__0_models.WikiWordsParseRequest,
        headers: dingtalkwiki__1__0_models.WikiWordsParseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkwiki__1__0_models.WikiWordsParseResponse:
        """
        @summary 外部传递过来的消息根据百科词库分词
        
        @param request: WikiWordsParseRequest
        @param headers: WikiWordsParseHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: WikiWordsParseResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
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
            action='WikiWordsParse',
            version='wiki_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/wiki/words/parse',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkwiki__1__0_models.WikiWordsParseResponse(),
            self.execute(params, req, runtime)
        )

    async def wiki_words_parse_with_options_async(
        self,
        request: dingtalkwiki__1__0_models.WikiWordsParseRequest,
        headers: dingtalkwiki__1__0_models.WikiWordsParseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkwiki__1__0_models.WikiWordsParseResponse:
        """
        @summary 外部传递过来的消息根据百科词库分词
        
        @param request: WikiWordsParseRequest
        @param headers: WikiWordsParseHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: WikiWordsParseResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
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
            action='WikiWordsParse',
            version='wiki_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/wiki/words/parse',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkwiki__1__0_models.WikiWordsParseResponse(),
            await self.execute_async(params, req, runtime)
        )

    def wiki_words_parse(
        self,
        request: dingtalkwiki__1__0_models.WikiWordsParseRequest,
    ) -> dingtalkwiki__1__0_models.WikiWordsParseResponse:
        """
        @summary 外部传递过来的消息根据百科词库分词
        
        @param request: WikiWordsParseRequest
        @return: WikiWordsParseResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkwiki__1__0_models.WikiWordsParseHeaders()
        return self.wiki_words_parse_with_options(request, headers, runtime)

    async def wiki_words_parse_async(
        self,
        request: dingtalkwiki__1__0_models.WikiWordsParseRequest,
    ) -> dingtalkwiki__1__0_models.WikiWordsParseResponse:
        """
        @summary 外部传递过来的消息根据百科词库分词
        
        @param request: WikiWordsParseRequest
        @return: WikiWordsParseResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkwiki__1__0_models.WikiWordsParseHeaders()
        return await self.wiki_words_parse_with_options_async(request, headers, runtime)
