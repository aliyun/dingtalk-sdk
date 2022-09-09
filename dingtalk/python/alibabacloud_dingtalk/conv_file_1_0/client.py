# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.conv_file_1_0 import models as dingtalkconv_file__1__0_models
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

    def send_by_app(
        self,
        request: dingtalkconv_file__1__0_models.SendByAppRequest,
    ) -> dingtalkconv_file__1__0_models.SendByAppResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconv_file__1__0_models.SendByAppHeaders()
        return self.send_by_app_with_options(request, headers, runtime)

    async def send_by_app_async(
        self,
        request: dingtalkconv_file__1__0_models.SendByAppRequest,
    ) -> dingtalkconv_file__1__0_models.SendByAppResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconv_file__1__0_models.SendByAppHeaders()
        return await self.send_by_app_with_options_async(request, headers, runtime)

    def send_by_app_with_options(
        self,
        request: dingtalkconv_file__1__0_models.SendByAppRequest,
        headers: dingtalkconv_file__1__0_models.SendByAppHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconv_file__1__0_models.SendByAppResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.dentry_id):
            body['dentryId'] = request.dentry_id
        if not UtilClient.is_unset(request.space_id):
            body['spaceId'] = request.space_id
        if not UtilClient.is_unset(request.target_union_id):
            body['targetUnionId'] = request.target_union_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkconv_file__1__0_models.SendByAppResponse(),
            self.do_roarequest('SendByApp', 'convFile_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/convFile/apps/conversations/files/send', 'json', req, runtime)
        )

    async def send_by_app_with_options_async(
        self,
        request: dingtalkconv_file__1__0_models.SendByAppRequest,
        headers: dingtalkconv_file__1__0_models.SendByAppHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconv_file__1__0_models.SendByAppResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.dentry_id):
            body['dentryId'] = request.dentry_id
        if not UtilClient.is_unset(request.space_id):
            body['spaceId'] = request.space_id
        if not UtilClient.is_unset(request.target_union_id):
            body['targetUnionId'] = request.target_union_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkconv_file__1__0_models.SendByAppResponse(),
            await self.do_roarequest_async('SendByApp', 'convFile_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/convFile/apps/conversations/files/send', 'json', req, runtime)
        )
