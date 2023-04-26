# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_gateway_spi.client import Client as SPIClient
from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.crm_2_0 import models as dingtalkcrm__2__0_models
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

    def get_relation_uk_setting_with_options(
        self,
        request: dingtalkcrm__2__0_models.GetRelationUkSettingRequest,
        headers: dingtalkcrm__2__0_models.GetRelationUkSettingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__2__0_models.GetRelationUkSettingResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.relation_type):
            query['relationType'] = request.relation_type
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
            action='GetRelationUkSetting',
            version='crm_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/crm/relationUkSettings',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__2__0_models.GetRelationUkSettingResponse(),
            self.execute(params, req, runtime)
        )

    async def get_relation_uk_setting_with_options_async(
        self,
        request: dingtalkcrm__2__0_models.GetRelationUkSettingRequest,
        headers: dingtalkcrm__2__0_models.GetRelationUkSettingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcrm__2__0_models.GetRelationUkSettingResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.relation_type):
            query['relationType'] = request.relation_type
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
            action='GetRelationUkSetting',
            version='crm_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/crm/relationUkSettings',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcrm__2__0_models.GetRelationUkSettingResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_relation_uk_setting(
        self,
        request: dingtalkcrm__2__0_models.GetRelationUkSettingRequest,
    ) -> dingtalkcrm__2__0_models.GetRelationUkSettingResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__2__0_models.GetRelationUkSettingHeaders()
        return self.get_relation_uk_setting_with_options(request, headers, runtime)

    async def get_relation_uk_setting_async(
        self,
        request: dingtalkcrm__2__0_models.GetRelationUkSettingRequest,
    ) -> dingtalkcrm__2__0_models.GetRelationUkSettingResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcrm__2__0_models.GetRelationUkSettingHeaders()
        return await self.get_relation_uk_setting_with_options_async(request, headers, runtime)
