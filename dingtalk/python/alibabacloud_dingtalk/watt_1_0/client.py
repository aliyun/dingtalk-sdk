# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from typing import Dict
from Tea.core import TeaCore

from alibabacloud_gateway_spi.client import Client as SPIClient
from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.watt_1_0 import models as dingtalkwatt__1__0_models
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
        self._signature_algorithm = 'v2'
        self._endpoint_rule = ''
        if UtilClient.empty(self._endpoint):
            self._endpoint = 'api.dingtalk.com'

    def check_in_crowds_by_mobile_with_options(
        self,
        request: dingtalkwatt__1__0_models.CheckInCrowdsByMobileRequest,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkwatt__1__0_models.CheckInCrowdsByMobileResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.crowd_ids):
            query['crowdIds'] = request.crowd_ids
        if not UtilClient.is_unset(request.mobile):
            query['mobile'] = request.mobile
        req = open_api_models.OpenApiRequest(
            headers=headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CheckInCrowdsByMobile',
            version='watt_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/watt/crowdIdentifications/query',
            method='POST',
            auth_type='Anonymous',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkwatt__1__0_models.CheckInCrowdsByMobileResponse(),
            self.execute(params, req, runtime)
        )

    async def check_in_crowds_by_mobile_with_options_async(
        self,
        request: dingtalkwatt__1__0_models.CheckInCrowdsByMobileRequest,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkwatt__1__0_models.CheckInCrowdsByMobileResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.crowd_ids):
            query['crowdIds'] = request.crowd_ids
        if not UtilClient.is_unset(request.mobile):
            query['mobile'] = request.mobile
        req = open_api_models.OpenApiRequest(
            headers=headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CheckInCrowdsByMobile',
            version='watt_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/watt/crowdIdentifications/query',
            method='POST',
            auth_type='Anonymous',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkwatt__1__0_models.CheckInCrowdsByMobileResponse(),
            await self.execute_async(params, req, runtime)
        )

    def check_in_crowds_by_mobile(
        self,
        request: dingtalkwatt__1__0_models.CheckInCrowdsByMobileRequest,
    ) -> dingtalkwatt__1__0_models.CheckInCrowdsByMobileResponse:
        runtime = util_models.RuntimeOptions()
        headers = {}
        return self.check_in_crowds_by_mobile_with_options(request, headers, runtime)

    async def check_in_crowds_by_mobile_async(
        self,
        request: dingtalkwatt__1__0_models.CheckInCrowdsByMobileRequest,
    ) -> dingtalkwatt__1__0_models.CheckInCrowdsByMobileResponse:
        runtime = util_models.RuntimeOptions()
        headers = {}
        return await self.check_in_crowds_by_mobile_with_options_async(request, headers, runtime)

    def send_banner_with_options(
        self,
        request: dingtalkwatt__1__0_models.SendBannerRequest,
        headers: dingtalkwatt__1__0_models.SendBannerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkwatt__1__0_models.SendBannerResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='SendBanner',
            version='watt_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/watt/banners/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkwatt__1__0_models.SendBannerResponse(),
            self.execute(params, req, runtime)
        )

    async def send_banner_with_options_async(
        self,
        request: dingtalkwatt__1__0_models.SendBannerRequest,
        headers: dingtalkwatt__1__0_models.SendBannerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkwatt__1__0_models.SendBannerResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='SendBanner',
            version='watt_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/watt/banners/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkwatt__1__0_models.SendBannerResponse(),
            await self.execute_async(params, req, runtime)
        )

    def send_banner(
        self,
        request: dingtalkwatt__1__0_models.SendBannerRequest,
    ) -> dingtalkwatt__1__0_models.SendBannerResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkwatt__1__0_models.SendBannerHeaders()
        return self.send_banner_with_options(request, headers, runtime)

    async def send_banner_async(
        self,
        request: dingtalkwatt__1__0_models.SendBannerRequest,
    ) -> dingtalkwatt__1__0_models.SendBannerResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkwatt__1__0_models.SendBannerHeaders()
        return await self.send_banner_with_options_async(request, headers, runtime)

    def send_popup_with_options(
        self,
        request: dingtalkwatt__1__0_models.SendPopupRequest,
        headers: dingtalkwatt__1__0_models.SendPopupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkwatt__1__0_models.SendPopupResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='SendPopup',
            version='watt_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/watt/popups/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkwatt__1__0_models.SendPopupResponse(),
            self.execute(params, req, runtime)
        )

    async def send_popup_with_options_async(
        self,
        request: dingtalkwatt__1__0_models.SendPopupRequest,
        headers: dingtalkwatt__1__0_models.SendPopupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkwatt__1__0_models.SendPopupResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='SendPopup',
            version='watt_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/watt/popups/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkwatt__1__0_models.SendPopupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def send_popup(
        self,
        request: dingtalkwatt__1__0_models.SendPopupRequest,
    ) -> dingtalkwatt__1__0_models.SendPopupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkwatt__1__0_models.SendPopupHeaders()
        return self.send_popup_with_options(request, headers, runtime)

    async def send_popup_async(
        self,
        request: dingtalkwatt__1__0_models.SendPopupRequest,
    ) -> dingtalkwatt__1__0_models.SendPopupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkwatt__1__0_models.SendPopupHeaders()
        return await self.send_popup_with_options_async(request, headers, runtime)

    def send_search_shade_with_options(
        self,
        request: dingtalkwatt__1__0_models.SendSearchShadeRequest,
        headers: dingtalkwatt__1__0_models.SendSearchShadeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkwatt__1__0_models.SendSearchShadeResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='SendSearchShade',
            version='watt_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/watt/searchShades/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkwatt__1__0_models.SendSearchShadeResponse(),
            self.execute(params, req, runtime)
        )

    async def send_search_shade_with_options_async(
        self,
        request: dingtalkwatt__1__0_models.SendSearchShadeRequest,
        headers: dingtalkwatt__1__0_models.SendSearchShadeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkwatt__1__0_models.SendSearchShadeResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='SendSearchShade',
            version='watt_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/watt/searchShades/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkwatt__1__0_models.SendSearchShadeResponse(),
            await self.execute_async(params, req, runtime)
        )

    def send_search_shade(
        self,
        request: dingtalkwatt__1__0_models.SendSearchShadeRequest,
    ) -> dingtalkwatt__1__0_models.SendSearchShadeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkwatt__1__0_models.SendSearchShadeHeaders()
        return self.send_search_shade_with_options(request, headers, runtime)

    async def send_search_shade_async(
        self,
        request: dingtalkwatt__1__0_models.SendSearchShadeRequest,
    ) -> dingtalkwatt__1__0_models.SendSearchShadeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkwatt__1__0_models.SendSearchShadeHeaders()
        return await self.send_search_shade_with_options_async(request, headers, runtime)
