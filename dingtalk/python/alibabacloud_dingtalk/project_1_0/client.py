# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalkproject_1_0 import models as dingtalkproject__1__0_models
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

    def get_tb_project_source(self) -> dingtalkproject__1__0_models.GetTbProjectSourceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.GetTbProjectSourceHeaders()
        return self.get_tb_project_source_with_options(headers, runtime)

    async def get_tb_project_source_async(self) -> dingtalkproject__1__0_models.GetTbProjectSourceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.GetTbProjectSourceHeaders()
        return await self.get_tb_project_source_with_options_async(headers, runtime)

    def get_tb_project_source_with_options(
        self,
        headers: dingtalkproject__1__0_models.GetTbProjectSourceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.GetTbProjectSourceResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.ding_org_id):
            real_headers['dingOrgId'] = headers.ding_org_id
        if not UtilClient.is_unset(headers.ding_isv_org_id):
            real_headers['dingIsvOrgId'] = headers.ding_isv_org_id
        if not UtilClient.is_unset(headers.ding_corp_id):
            real_headers['dingCorpId'] = headers.ding_corp_id
        if not UtilClient.is_unset(headers.ding_suite_key):
            real_headers['dingSuiteKey'] = headers.ding_suite_key
        if not UtilClient.is_unset(headers.ding_access_token_type):
            real_headers['dingAccessTokenType'] = headers.ding_access_token_type
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.GetTbProjectSourceResponse(),
            self.do_roarequest('GetTbProjectSource', 'project_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/project/projects/source', 'json', req, runtime)
        )

    async def get_tb_project_source_with_options_async(
        self,
        headers: dingtalkproject__1__0_models.GetTbProjectSourceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.GetTbProjectSourceResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.ding_org_id):
            real_headers['dingOrgId'] = headers.ding_org_id
        if not UtilClient.is_unset(headers.ding_isv_org_id):
            real_headers['dingIsvOrgId'] = headers.ding_isv_org_id
        if not UtilClient.is_unset(headers.ding_corp_id):
            real_headers['dingCorpId'] = headers.ding_corp_id
        if not UtilClient.is_unset(headers.ding_suite_key):
            real_headers['dingSuiteKey'] = headers.ding_suite_key
        if not UtilClient.is_unset(headers.ding_access_token_type):
            real_headers['dingAccessTokenType'] = headers.ding_access_token_type
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.GetTbProjectSourceResponse(),
            await self.do_roarequest_async('GetTbProjectSource', 'project_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/project/projects/source', 'json', req, runtime)
        )

    def get_tb_project_gray(
        self,
        request: dingtalkproject__1__0_models.GetTbProjectGrayRequest,
    ) -> dingtalkproject__1__0_models.GetTbProjectGrayResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.GetTbProjectGrayHeaders()
        return self.get_tb_project_gray_with_options(request, headers, runtime)

    async def get_tb_project_gray_async(
        self,
        request: dingtalkproject__1__0_models.GetTbProjectGrayRequest,
    ) -> dingtalkproject__1__0_models.GetTbProjectGrayResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.GetTbProjectGrayHeaders()
        return await self.get_tb_project_gray_with_options_async(request, headers, runtime)

    def get_tb_project_gray_with_options(
        self,
        request: dingtalkproject__1__0_models.GetTbProjectGrayRequest,
        headers: dingtalkproject__1__0_models.GetTbProjectGrayHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.GetTbProjectGrayResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.label):
            body['label'] = request.label
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.ding_access_token_type):
            real_headers['dingAccessTokenType'] = headers.ding_access_token_type
        if not UtilClient.is_unset(headers.ding_suite_key):
            real_headers['dingSuiteKey'] = headers.ding_suite_key
        if not UtilClient.is_unset(headers.ding_isv_org_id):
            real_headers['dingIsvOrgId'] = headers.ding_isv_org_id
        if not UtilClient.is_unset(headers.ding_org_id):
            real_headers['dingOrgId'] = headers.ding_org_id
        if not UtilClient.is_unset(headers.ding_corp_id):
            real_headers['dingCorpId'] = headers.ding_corp_id
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.GetTbProjectGrayResponse(),
            self.do_roarequest('GetTbProjectGray', 'project_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/project/projects/gray', 'json', req, runtime)
        )

    async def get_tb_project_gray_with_options_async(
        self,
        request: dingtalkproject__1__0_models.GetTbProjectGrayRequest,
        headers: dingtalkproject__1__0_models.GetTbProjectGrayHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.GetTbProjectGrayResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.label):
            body['label'] = request.label
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.ding_access_token_type):
            real_headers['dingAccessTokenType'] = headers.ding_access_token_type
        if not UtilClient.is_unset(headers.ding_suite_key):
            real_headers['dingSuiteKey'] = headers.ding_suite_key
        if not UtilClient.is_unset(headers.ding_isv_org_id):
            real_headers['dingIsvOrgId'] = headers.ding_isv_org_id
        if not UtilClient.is_unset(headers.ding_org_id):
            real_headers['dingOrgId'] = headers.ding_org_id
        if not UtilClient.is_unset(headers.ding_corp_id):
            real_headers['dingCorpId'] = headers.ding_corp_id
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.GetTbProjectGrayResponse(),
            await self.do_roarequest_async('GetTbProjectGray', 'project_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/project/projects/gray', 'json', req, runtime)
        )
