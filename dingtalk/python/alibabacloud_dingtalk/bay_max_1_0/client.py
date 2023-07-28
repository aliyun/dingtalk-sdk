# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_gateway_spi.client import Client as SPIClient
from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.bay_max_1_0 import models as dingtalkbay_max__1__0_models
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

    def query_baymax_skill_log_with_options(
        self,
        request: dingtalkbay_max__1__0_models.QueryBaymaxSkillLogRequest,
        headers: dingtalkbay_max__1__0_models.QueryBaymaxSkillLogHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbay_max__1__0_models.QueryBaymaxSkillLogResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.from_):
            query['from'] = request.from_
        if not UtilClient.is_unset(request.skill_execute_id):
            query['skillExecuteId'] = request.skill_execute_id
        if not UtilClient.is_unset(request.to):
            query['to'] = request.to
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
            action='QueryBaymaxSkillLog',
            version='bayMax_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bayMax/skills/logs',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbay_max__1__0_models.QueryBaymaxSkillLogResponse(),
            self.execute(params, req, runtime)
        )

    async def query_baymax_skill_log_with_options_async(
        self,
        request: dingtalkbay_max__1__0_models.QueryBaymaxSkillLogRequest,
        headers: dingtalkbay_max__1__0_models.QueryBaymaxSkillLogHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbay_max__1__0_models.QueryBaymaxSkillLogResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.from_):
            query['from'] = request.from_
        if not UtilClient.is_unset(request.skill_execute_id):
            query['skillExecuteId'] = request.skill_execute_id
        if not UtilClient.is_unset(request.to):
            query['to'] = request.to
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
            action='QueryBaymaxSkillLog',
            version='bayMax_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/bayMax/skills/logs',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbay_max__1__0_models.QueryBaymaxSkillLogResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_baymax_skill_log(
        self,
        request: dingtalkbay_max__1__0_models.QueryBaymaxSkillLogRequest,
    ) -> dingtalkbay_max__1__0_models.QueryBaymaxSkillLogResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbay_max__1__0_models.QueryBaymaxSkillLogHeaders()
        return self.query_baymax_skill_log_with_options(request, headers, runtime)

    async def query_baymax_skill_log_async(
        self,
        request: dingtalkbay_max__1__0_models.QueryBaymaxSkillLogRequest,
    ) -> dingtalkbay_max__1__0_models.QueryBaymaxSkillLogResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbay_max__1__0_models.QueryBaymaxSkillLogHeaders()
        return await self.query_baymax_skill_log_with_options_async(request, headers, runtime)
