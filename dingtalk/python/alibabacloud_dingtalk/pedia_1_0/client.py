# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_gateway_spi.client import Client as SPIClient
from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.pedia_1_0 import models as dingtalkpedia__1__0_models
from alibabacloud_tea_util import models as util_models
from alibabacloud_openapi_util.client import Client as OpenApiUtilClient


class Client(OpenApiClient):
    """
    *\
    """
    _client: SPIClient = None

    def __init__(
        self, 
        config: open_api_models.Config,
    ):
        super().__init__(config)
        self._client = GatewayClientClient()
        self._spi = self._client
        self._endpoint_rule = ''
        if UtilClient.empty(self._endpoint):
            self._endpoint = 'api.dingtalk.com'

    def pedia_words_add_with_options(
        self,
        request: dingtalkpedia__1__0_models.PediaWordsAddRequest,
        headers: dingtalkpedia__1__0_models.PediaWordsAddHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkpedia__1__0_models.PediaWordsAddResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.contact_list):
            body['contactList'] = request.contact_list
        if not UtilClient.is_unset(request.high_light_word_alias):
            body['highLightWordAlias'] = request.high_light_word_alias
        if not UtilClient.is_unset(request.pic_list):
            body['picList'] = request.pic_list
        if not UtilClient.is_unset(request.related_doc):
            body['relatedDoc'] = request.related_doc
        if not UtilClient.is_unset(request.related_link):
            body['relatedLink'] = request.related_link
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.word_alias):
            body['wordAlias'] = request.word_alias
        if not UtilClient.is_unset(request.word_name):
            body['wordName'] = request.word_name
        if not UtilClient.is_unset(request.word_paraphrase):
            body['wordParaphrase'] = request.word_paraphrase
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
            action='PediaWordsAdd',
            version='pedia_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/pedia/words',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkpedia__1__0_models.PediaWordsAddResponse(),
            self.execute(params, req, runtime)
        )

    async def pedia_words_add_with_options_async(
        self,
        request: dingtalkpedia__1__0_models.PediaWordsAddRequest,
        headers: dingtalkpedia__1__0_models.PediaWordsAddHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkpedia__1__0_models.PediaWordsAddResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.contact_list):
            body['contactList'] = request.contact_list
        if not UtilClient.is_unset(request.high_light_word_alias):
            body['highLightWordAlias'] = request.high_light_word_alias
        if not UtilClient.is_unset(request.pic_list):
            body['picList'] = request.pic_list
        if not UtilClient.is_unset(request.related_doc):
            body['relatedDoc'] = request.related_doc
        if not UtilClient.is_unset(request.related_link):
            body['relatedLink'] = request.related_link
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.word_alias):
            body['wordAlias'] = request.word_alias
        if not UtilClient.is_unset(request.word_name):
            body['wordName'] = request.word_name
        if not UtilClient.is_unset(request.word_paraphrase):
            body['wordParaphrase'] = request.word_paraphrase
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
            action='PediaWordsAdd',
            version='pedia_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/pedia/words',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkpedia__1__0_models.PediaWordsAddResponse(),
            await self.execute_async(params, req, runtime)
        )

    def pedia_words_add(
        self,
        request: dingtalkpedia__1__0_models.PediaWordsAddRequest,
    ) -> dingtalkpedia__1__0_models.PediaWordsAddResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkpedia__1__0_models.PediaWordsAddHeaders()
        return self.pedia_words_add_with_options(request, headers, runtime)

    async def pedia_words_add_async(
        self,
        request: dingtalkpedia__1__0_models.PediaWordsAddRequest,
    ) -> dingtalkpedia__1__0_models.PediaWordsAddResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkpedia__1__0_models.PediaWordsAddHeaders()
        return await self.pedia_words_add_with_options_async(request, headers, runtime)

    def pedia_words_approve_with_options(
        self,
        request: dingtalkpedia__1__0_models.PediaWordsApproveRequest,
        headers: dingtalkpedia__1__0_models.PediaWordsApproveHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkpedia__1__0_models.PediaWordsApproveResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.approve_reason):
            body['approveReason'] = request.approve_reason
        if not UtilClient.is_unset(request.approve_status):
            body['approveStatus'] = request.approve_status
        if not UtilClient.is_unset(request.im_high_light):
            body['imHighLight'] = request.im_high_light
        if not UtilClient.is_unset(request.sim_high_light):
            body['simHighLight'] = request.sim_high_light
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.uuid):
            body['uuid'] = request.uuid
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
            action='PediaWordsApprove',
            version='pedia_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/pedia/words/approve',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkpedia__1__0_models.PediaWordsApproveResponse(),
            self.execute(params, req, runtime)
        )

    async def pedia_words_approve_with_options_async(
        self,
        request: dingtalkpedia__1__0_models.PediaWordsApproveRequest,
        headers: dingtalkpedia__1__0_models.PediaWordsApproveHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkpedia__1__0_models.PediaWordsApproveResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.approve_reason):
            body['approveReason'] = request.approve_reason
        if not UtilClient.is_unset(request.approve_status):
            body['approveStatus'] = request.approve_status
        if not UtilClient.is_unset(request.im_high_light):
            body['imHighLight'] = request.im_high_light
        if not UtilClient.is_unset(request.sim_high_light):
            body['simHighLight'] = request.sim_high_light
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.uuid):
            body['uuid'] = request.uuid
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
            action='PediaWordsApprove',
            version='pedia_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/pedia/words/approve',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkpedia__1__0_models.PediaWordsApproveResponse(),
            await self.execute_async(params, req, runtime)
        )

    def pedia_words_approve(
        self,
        request: dingtalkpedia__1__0_models.PediaWordsApproveRequest,
    ) -> dingtalkpedia__1__0_models.PediaWordsApproveResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkpedia__1__0_models.PediaWordsApproveHeaders()
        return self.pedia_words_approve_with_options(request, headers, runtime)

    async def pedia_words_approve_async(
        self,
        request: dingtalkpedia__1__0_models.PediaWordsApproveRequest,
    ) -> dingtalkpedia__1__0_models.PediaWordsApproveResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkpedia__1__0_models.PediaWordsApproveHeaders()
        return await self.pedia_words_approve_with_options_async(request, headers, runtime)

    def pedia_words_delete_with_options(
        self,
        request: dingtalkpedia__1__0_models.PediaWordsDeleteRequest,
        headers: dingtalkpedia__1__0_models.PediaWordsDeleteHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkpedia__1__0_models.PediaWordsDeleteResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        if not UtilClient.is_unset(request.uuid):
            query['uuid'] = request.uuid
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
            action='PediaWordsDelete',
            version='pedia_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/pedia/words',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkpedia__1__0_models.PediaWordsDeleteResponse(),
            self.execute(params, req, runtime)
        )

    async def pedia_words_delete_with_options_async(
        self,
        request: dingtalkpedia__1__0_models.PediaWordsDeleteRequest,
        headers: dingtalkpedia__1__0_models.PediaWordsDeleteHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkpedia__1__0_models.PediaWordsDeleteResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        if not UtilClient.is_unset(request.uuid):
            query['uuid'] = request.uuid
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
            action='PediaWordsDelete',
            version='pedia_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/pedia/words',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkpedia__1__0_models.PediaWordsDeleteResponse(),
            await self.execute_async(params, req, runtime)
        )

    def pedia_words_delete(
        self,
        request: dingtalkpedia__1__0_models.PediaWordsDeleteRequest,
    ) -> dingtalkpedia__1__0_models.PediaWordsDeleteResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkpedia__1__0_models.PediaWordsDeleteHeaders()
        return self.pedia_words_delete_with_options(request, headers, runtime)

    async def pedia_words_delete_async(
        self,
        request: dingtalkpedia__1__0_models.PediaWordsDeleteRequest,
    ) -> dingtalkpedia__1__0_models.PediaWordsDeleteResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkpedia__1__0_models.PediaWordsDeleteHeaders()
        return await self.pedia_words_delete_with_options_async(request, headers, runtime)

    def pedia_words_query_with_options(
        self,
        request: dingtalkpedia__1__0_models.PediaWordsQueryRequest,
        headers: dingtalkpedia__1__0_models.PediaWordsQueryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkpedia__1__0_models.PediaWordsQueryResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        if not UtilClient.is_unset(request.uuid):
            query['uuid'] = request.uuid
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
            action='PediaWordsQuery',
            version='pedia_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/pedia/words/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkpedia__1__0_models.PediaWordsQueryResponse(),
            self.execute(params, req, runtime)
        )

    async def pedia_words_query_with_options_async(
        self,
        request: dingtalkpedia__1__0_models.PediaWordsQueryRequest,
        headers: dingtalkpedia__1__0_models.PediaWordsQueryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkpedia__1__0_models.PediaWordsQueryResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        if not UtilClient.is_unset(request.uuid):
            query['uuid'] = request.uuid
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
            action='PediaWordsQuery',
            version='pedia_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/pedia/words/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkpedia__1__0_models.PediaWordsQueryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def pedia_words_query(
        self,
        request: dingtalkpedia__1__0_models.PediaWordsQueryRequest,
    ) -> dingtalkpedia__1__0_models.PediaWordsQueryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkpedia__1__0_models.PediaWordsQueryHeaders()
        return self.pedia_words_query_with_options(request, headers, runtime)

    async def pedia_words_query_async(
        self,
        request: dingtalkpedia__1__0_models.PediaWordsQueryRequest,
    ) -> dingtalkpedia__1__0_models.PediaWordsQueryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkpedia__1__0_models.PediaWordsQueryHeaders()
        return await self.pedia_words_query_with_options_async(request, headers, runtime)

    def pedia_words_search_with_options(
        self,
        request: dingtalkpedia__1__0_models.PediaWordsSearchRequest,
        headers: dingtalkpedia__1__0_models.PediaWordsSearchHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkpedia__1__0_models.PediaWordsSearchResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.word_name):
            body['wordName'] = request.word_name
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
            action='PediaWordsSearch',
            version='pedia_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/pedia/words/search',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkpedia__1__0_models.PediaWordsSearchResponse(),
            self.execute(params, req, runtime)
        )

    async def pedia_words_search_with_options_async(
        self,
        request: dingtalkpedia__1__0_models.PediaWordsSearchRequest,
        headers: dingtalkpedia__1__0_models.PediaWordsSearchHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkpedia__1__0_models.PediaWordsSearchResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.word_name):
            body['wordName'] = request.word_name
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
            action='PediaWordsSearch',
            version='pedia_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/pedia/words/search',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkpedia__1__0_models.PediaWordsSearchResponse(),
            await self.execute_async(params, req, runtime)
        )

    def pedia_words_search(
        self,
        request: dingtalkpedia__1__0_models.PediaWordsSearchRequest,
    ) -> dingtalkpedia__1__0_models.PediaWordsSearchResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkpedia__1__0_models.PediaWordsSearchHeaders()
        return self.pedia_words_search_with_options(request, headers, runtime)

    async def pedia_words_search_async(
        self,
        request: dingtalkpedia__1__0_models.PediaWordsSearchRequest,
    ) -> dingtalkpedia__1__0_models.PediaWordsSearchResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkpedia__1__0_models.PediaWordsSearchHeaders()
        return await self.pedia_words_search_with_options_async(request, headers, runtime)

    def pedia_words_update_with_options(
        self,
        request: dingtalkpedia__1__0_models.PediaWordsUpdateRequest,
        headers: dingtalkpedia__1__0_models.PediaWordsUpdateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkpedia__1__0_models.PediaWordsUpdateResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_link):
            body['appLink'] = request.app_link
        if not UtilClient.is_unset(request.contact_list):
            body['contactList'] = request.contact_list
        if not UtilClient.is_unset(request.high_light_word_alias):
            body['highLightWordAlias'] = request.high_light_word_alias
        if not UtilClient.is_unset(request.pic_list):
            body['picList'] = request.pic_list
        if not UtilClient.is_unset(request.related_doc):
            body['relatedDoc'] = request.related_doc
        if not UtilClient.is_unset(request.related_link):
            body['relatedLink'] = request.related_link
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.uuid):
            body['uuid'] = request.uuid
        if not UtilClient.is_unset(request.word_alias):
            body['wordAlias'] = request.word_alias
        if not UtilClient.is_unset(request.word_name):
            body['wordName'] = request.word_name
        if not UtilClient.is_unset(request.word_paraphrase):
            body['wordParaphrase'] = request.word_paraphrase
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
            action='PediaWordsUpdate',
            version='pedia_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/pedia/words',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkpedia__1__0_models.PediaWordsUpdateResponse(),
            self.execute(params, req, runtime)
        )

    async def pedia_words_update_with_options_async(
        self,
        request: dingtalkpedia__1__0_models.PediaWordsUpdateRequest,
        headers: dingtalkpedia__1__0_models.PediaWordsUpdateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkpedia__1__0_models.PediaWordsUpdateResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_link):
            body['appLink'] = request.app_link
        if not UtilClient.is_unset(request.contact_list):
            body['contactList'] = request.contact_list
        if not UtilClient.is_unset(request.high_light_word_alias):
            body['highLightWordAlias'] = request.high_light_word_alias
        if not UtilClient.is_unset(request.pic_list):
            body['picList'] = request.pic_list
        if not UtilClient.is_unset(request.related_doc):
            body['relatedDoc'] = request.related_doc
        if not UtilClient.is_unset(request.related_link):
            body['relatedLink'] = request.related_link
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.uuid):
            body['uuid'] = request.uuid
        if not UtilClient.is_unset(request.word_alias):
            body['wordAlias'] = request.word_alias
        if not UtilClient.is_unset(request.word_name):
            body['wordName'] = request.word_name
        if not UtilClient.is_unset(request.word_paraphrase):
            body['wordParaphrase'] = request.word_paraphrase
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
            action='PediaWordsUpdate',
            version='pedia_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/pedia/words',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkpedia__1__0_models.PediaWordsUpdateResponse(),
            await self.execute_async(params, req, runtime)
        )

    def pedia_words_update(
        self,
        request: dingtalkpedia__1__0_models.PediaWordsUpdateRequest,
    ) -> dingtalkpedia__1__0_models.PediaWordsUpdateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkpedia__1__0_models.PediaWordsUpdateHeaders()
        return self.pedia_words_update_with_options(request, headers, runtime)

    async def pedia_words_update_async(
        self,
        request: dingtalkpedia__1__0_models.PediaWordsUpdateRequest,
    ) -> dingtalkpedia__1__0_models.PediaWordsUpdateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkpedia__1__0_models.PediaWordsUpdateHeaders()
        return await self.pedia_words_update_with_options_async(request, headers, runtime)
