# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.credit_1_0 import models as dingtalkcredit__1__0_models
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

    def query_score_with_options(
        self,
        request: dingtalkcredit__1__0_models.QueryScoreRequest,
        headers: dingtalkcredit__1__0_models.QueryScoreHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcredit__1__0_models.QueryScoreResponse:
        """
        @summary 查询用户金融评分数据
        
        @param request: QueryScoreRequest
        @param headers: QueryScoreHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryScoreResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.encryption):
            query['encryption'] = request.encryption
        if not UtilClient.is_unset(request.full_name):
            query['fullName'] = request.full_name
        if not UtilClient.is_unset(request.id_card_code):
            query['idCardCode'] = request.id_card_code
        if not UtilClient.is_unset(request.mobile):
            query['mobile'] = request.mobile
        if not UtilClient.is_unset(request.org_name):
            query['orgName'] = request.org_name
        if not UtilClient.is_unset(request.uni_sc_code):
            query['uniScCode'] = request.uni_sc_code
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
            action='QueryScore',
            version='credit_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/credit/scores',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcredit__1__0_models.QueryScoreResponse(),
            self.execute(params, req, runtime)
        )

    async def query_score_with_options_async(
        self,
        request: dingtalkcredit__1__0_models.QueryScoreRequest,
        headers: dingtalkcredit__1__0_models.QueryScoreHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcredit__1__0_models.QueryScoreResponse:
        """
        @summary 查询用户金融评分数据
        
        @param request: QueryScoreRequest
        @param headers: QueryScoreHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryScoreResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.encryption):
            query['encryption'] = request.encryption
        if not UtilClient.is_unset(request.full_name):
            query['fullName'] = request.full_name
        if not UtilClient.is_unset(request.id_card_code):
            query['idCardCode'] = request.id_card_code
        if not UtilClient.is_unset(request.mobile):
            query['mobile'] = request.mobile
        if not UtilClient.is_unset(request.org_name):
            query['orgName'] = request.org_name
        if not UtilClient.is_unset(request.uni_sc_code):
            query['uniScCode'] = request.uni_sc_code
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
            action='QueryScore',
            version='credit_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/credit/scores',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcredit__1__0_models.QueryScoreResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_score(
        self,
        request: dingtalkcredit__1__0_models.QueryScoreRequest,
    ) -> dingtalkcredit__1__0_models.QueryScoreResponse:
        """
        @summary 查询用户金融评分数据
        
        @param request: QueryScoreRequest
        @return: QueryScoreResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcredit__1__0_models.QueryScoreHeaders()
        return self.query_score_with_options(request, headers, runtime)

    async def query_score_async(
        self,
        request: dingtalkcredit__1__0_models.QueryScoreRequest,
    ) -> dingtalkcredit__1__0_models.QueryScoreResponse:
        """
        @summary 查询用户金融评分数据
        
        @param request: QueryScoreRequest
        @return: QueryScoreResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcredit__1__0_models.QueryScoreHeaders()
        return await self.query_score_with_options_async(request, headers, runtime)
