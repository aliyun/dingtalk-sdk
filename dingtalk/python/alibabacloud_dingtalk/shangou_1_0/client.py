# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.shangou_1_0 import models as dingtalkshangou__1__0_models
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

    def add_catering_comment_with_options(
        self,
        request: dingtalkshangou__1__0_models.AddCateringCommentRequest,
        headers: dingtalkshangou__1__0_models.AddCateringCommentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkshangou__1__0_models.AddCateringCommentResponse:
        """
        @summary 新增餐饮评价数据
        
        @param request: AddCateringCommentRequest
        @param headers: AddCateringCommentHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddCateringCommentResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.comment_id):
            body['commentId'] = request.comment_id
        if not UtilClient.is_unset(request.order_id):
            body['orderId'] = request.order_id
        if not UtilClient.is_unset(request.rate_content):
            body['rateContent'] = request.rate_content
        if not UtilClient.is_unset(request.rated_at):
            body['ratedAt'] = request.rated_at
        if not UtilClient.is_unset(request.rating):
            body['rating'] = request.rating
        if not UtilClient.is_unset(request.shop_id):
            body['shopId'] = request.shop_id
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
            action='AddCateringComment',
            version='shangou_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/shangou/comment/create',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkshangou__1__0_models.AddCateringCommentResponse(),
            self.execute(params, req, runtime)
        )

    async def add_catering_comment_with_options_async(
        self,
        request: dingtalkshangou__1__0_models.AddCateringCommentRequest,
        headers: dingtalkshangou__1__0_models.AddCateringCommentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkshangou__1__0_models.AddCateringCommentResponse:
        """
        @summary 新增餐饮评价数据
        
        @param request: AddCateringCommentRequest
        @param headers: AddCateringCommentHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddCateringCommentResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.comment_id):
            body['commentId'] = request.comment_id
        if not UtilClient.is_unset(request.order_id):
            body['orderId'] = request.order_id
        if not UtilClient.is_unset(request.rate_content):
            body['rateContent'] = request.rate_content
        if not UtilClient.is_unset(request.rated_at):
            body['ratedAt'] = request.rated_at
        if not UtilClient.is_unset(request.rating):
            body['rating'] = request.rating
        if not UtilClient.is_unset(request.shop_id):
            body['shopId'] = request.shop_id
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
            action='AddCateringComment',
            version='shangou_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/shangou/comment/create',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkshangou__1__0_models.AddCateringCommentResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_catering_comment(
        self,
        request: dingtalkshangou__1__0_models.AddCateringCommentRequest,
    ) -> dingtalkshangou__1__0_models.AddCateringCommentResponse:
        """
        @summary 新增餐饮评价数据
        
        @param request: AddCateringCommentRequest
        @return: AddCateringCommentResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkshangou__1__0_models.AddCateringCommentHeaders()
        return self.add_catering_comment_with_options(request, headers, runtime)

    async def add_catering_comment_async(
        self,
        request: dingtalkshangou__1__0_models.AddCateringCommentRequest,
    ) -> dingtalkshangou__1__0_models.AddCateringCommentResponse:
        """
        @summary 新增餐饮评价数据
        
        @param request: AddCateringCommentRequest
        @return: AddCateringCommentResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkshangou__1__0_models.AddCateringCommentHeaders()
        return await self.add_catering_comment_with_options_async(request, headers, runtime)
