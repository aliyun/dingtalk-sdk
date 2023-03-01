# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.blackboard_1_0 import models as dingtalkblackboard__1__0_models
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
        self._endpoint_rule = ''
        if UtilClient.empty(self._endpoint):
            self._endpoint = 'api.dingtalk.com'

    def query_blackboard_space(
        self,
        request: dingtalkblackboard__1__0_models.QueryBlackboardSpaceRequest,
    ) -> dingtalkblackboard__1__0_models.QueryBlackboardSpaceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkblackboard__1__0_models.QueryBlackboardSpaceHeaders()
        return self.query_blackboard_space_with_options(request, headers, runtime)

    async def query_blackboard_space_async(
        self,
        request: dingtalkblackboard__1__0_models.QueryBlackboardSpaceRequest,
    ) -> dingtalkblackboard__1__0_models.QueryBlackboardSpaceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkblackboard__1__0_models.QueryBlackboardSpaceHeaders()
        return await self.query_blackboard_space_with_options_async(request, headers, runtime)

    def query_blackboard_space_with_options(
        self,
        request: dingtalkblackboard__1__0_models.QueryBlackboardSpaceRequest,
        headers: dingtalkblackboard__1__0_models.QueryBlackboardSpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkblackboard__1__0_models.QueryBlackboardSpaceResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operation_user_id):
            query['operationUserId'] = request.operation_user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkblackboard__1__0_models.QueryBlackboardSpaceResponse(),
            self.do_roarequest('QueryBlackboardSpace', 'blackboard_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/blackboard/spaces', 'json', req, runtime)
        )

    async def query_blackboard_space_with_options_async(
        self,
        request: dingtalkblackboard__1__0_models.QueryBlackboardSpaceRequest,
        headers: dingtalkblackboard__1__0_models.QueryBlackboardSpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkblackboard__1__0_models.QueryBlackboardSpaceResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operation_user_id):
            query['operationUserId'] = request.operation_user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkblackboard__1__0_models.QueryBlackboardSpaceResponse(),
            await self.do_roarequest_async('QueryBlackboardSpace', 'blackboard_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/blackboard/spaces', 'json', req, runtime)
        )
