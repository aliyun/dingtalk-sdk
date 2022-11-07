# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.card_1_0 import models as dingtalkcard__1__0_models
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

    def append_space(
        self,
        request: dingtalkcard__1__0_models.AppendSpaceRequest,
    ) -> dingtalkcard__1__0_models.AppendSpaceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcard__1__0_models.AppendSpaceHeaders()
        return self.append_space_with_options(request, headers, runtime)

    async def append_space_async(
        self,
        request: dingtalkcard__1__0_models.AppendSpaceRequest,
    ) -> dingtalkcard__1__0_models.AppendSpaceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcard__1__0_models.AppendSpaceHeaders()
        return await self.append_space_with_options_async(request, headers, runtime)

    def append_space_with_options(
        self,
        request: dingtalkcard__1__0_models.AppendSpaceRequest,
        headers: dingtalkcard__1__0_models.AppendSpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcard__1__0_models.AppendSpaceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.co_feed_open_space_model):
            body['coFeedOpenSpaceModel'] = request.co_feed_open_space_model
        if not UtilClient.is_unset(request.im_group_open_space_model):
            body['imGroupOpenSpaceModel'] = request.im_group_open_space_model
        if not UtilClient.is_unset(request.im_single_open_space_model):
            body['imSingleOpenSpaceModel'] = request.im_single_open_space_model
        if not UtilClient.is_unset(request.out_track_id):
            body['outTrackId'] = request.out_track_id
        if not UtilClient.is_unset(request.top_open_space_model):
            body['topOpenSpaceModel'] = request.top_open_space_model
        if not UtilClient.is_unset(request.work_bench_open_space_model):
            body['workBenchOpenSpaceModel'] = request.work_bench_open_space_model
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkcard__1__0_models.AppendSpaceResponse(),
            self.do_roarequest('AppendSpace', 'card_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/card/instances/spaces', 'json', req, runtime)
        )

    async def append_space_with_options_async(
        self,
        request: dingtalkcard__1__0_models.AppendSpaceRequest,
        headers: dingtalkcard__1__0_models.AppendSpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcard__1__0_models.AppendSpaceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.co_feed_open_space_model):
            body['coFeedOpenSpaceModel'] = request.co_feed_open_space_model
        if not UtilClient.is_unset(request.im_group_open_space_model):
            body['imGroupOpenSpaceModel'] = request.im_group_open_space_model
        if not UtilClient.is_unset(request.im_single_open_space_model):
            body['imSingleOpenSpaceModel'] = request.im_single_open_space_model
        if not UtilClient.is_unset(request.out_track_id):
            body['outTrackId'] = request.out_track_id
        if not UtilClient.is_unset(request.top_open_space_model):
            body['topOpenSpaceModel'] = request.top_open_space_model
        if not UtilClient.is_unset(request.work_bench_open_space_model):
            body['workBenchOpenSpaceModel'] = request.work_bench_open_space_model
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkcard__1__0_models.AppendSpaceResponse(),
            await self.do_roarequest_async('AppendSpace', 'card_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/card/instances/spaces', 'json', req, runtime)
        )

    def create_and_deliver(
        self,
        request: dingtalkcard__1__0_models.CreateAndDeliverRequest,
    ) -> dingtalkcard__1__0_models.CreateAndDeliverResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcard__1__0_models.CreateAndDeliverHeaders()
        return self.create_and_deliver_with_options(request, headers, runtime)

    async def create_and_deliver_async(
        self,
        request: dingtalkcard__1__0_models.CreateAndDeliverRequest,
    ) -> dingtalkcard__1__0_models.CreateAndDeliverResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcard__1__0_models.CreateAndDeliverHeaders()
        return await self.create_and_deliver_with_options_async(request, headers, runtime)

    def create_and_deliver_with_options(
        self,
        request: dingtalkcard__1__0_models.CreateAndDeliverRequest,
        headers: dingtalkcard__1__0_models.CreateAndDeliverHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcard__1__0_models.CreateAndDeliverResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.callback_route_key):
            body['callbackRouteKey'] = request.callback_route_key
        if not UtilClient.is_unset(request.card_at_user_ids):
            body['cardAtUserIds'] = request.card_at_user_ids
        if not UtilClient.is_unset(request.card_data):
            body['cardData'] = request.card_data
        if not UtilClient.is_unset(request.card_template_id):
            body['cardTemplateId'] = request.card_template_id
        if not UtilClient.is_unset(request.co_feed_open_deliver_model):
            body['coFeedOpenDeliverModel'] = request.co_feed_open_deliver_model
        if not UtilClient.is_unset(request.co_feed_open_space_model):
            body['coFeedOpenSpaceModel'] = request.co_feed_open_space_model
        if not UtilClient.is_unset(request.im_group_open_deliver_model):
            body['imGroupOpenDeliverModel'] = request.im_group_open_deliver_model
        if not UtilClient.is_unset(request.im_group_open_space_model):
            body['imGroupOpenSpaceModel'] = request.im_group_open_space_model
        if not UtilClient.is_unset(request.im_single_open_deliver_model):
            body['imSingleOpenDeliverModel'] = request.im_single_open_deliver_model
        if not UtilClient.is_unset(request.im_single_open_space_model):
            body['imSingleOpenSpaceModel'] = request.im_single_open_space_model
        if not UtilClient.is_unset(request.open_dynamic_data_config):
            body['openDynamicDataConfig'] = request.open_dynamic_data_config
        if not UtilClient.is_unset(request.open_space_id):
            body['openSpaceId'] = request.open_space_id
        if not UtilClient.is_unset(request.out_track_id):
            body['outTrackId'] = request.out_track_id
        if not UtilClient.is_unset(request.private_data):
            body['privateData'] = request.private_data
        if not UtilClient.is_unset(request.top_open_deliver_model):
            body['topOpenDeliverModel'] = request.top_open_deliver_model
        if not UtilClient.is_unset(request.top_open_space_model):
            body['topOpenSpaceModel'] = request.top_open_space_model
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.user_id_type):
            body['userIdType'] = request.user_id_type
        if not UtilClient.is_unset(request.work_bench_open_deliver_model):
            body['workBenchOpenDeliverModel'] = request.work_bench_open_deliver_model
        if not UtilClient.is_unset(request.work_bench_open_space_model):
            body['workBenchOpenSpaceModel'] = request.work_bench_open_space_model
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkcard__1__0_models.CreateAndDeliverResponse(),
            self.do_roarequest('CreateAndDeliver', 'card_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/card/instances/createAndDeliver', 'json', req, runtime)
        )

    async def create_and_deliver_with_options_async(
        self,
        request: dingtalkcard__1__0_models.CreateAndDeliverRequest,
        headers: dingtalkcard__1__0_models.CreateAndDeliverHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcard__1__0_models.CreateAndDeliverResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.callback_route_key):
            body['callbackRouteKey'] = request.callback_route_key
        if not UtilClient.is_unset(request.card_at_user_ids):
            body['cardAtUserIds'] = request.card_at_user_ids
        if not UtilClient.is_unset(request.card_data):
            body['cardData'] = request.card_data
        if not UtilClient.is_unset(request.card_template_id):
            body['cardTemplateId'] = request.card_template_id
        if not UtilClient.is_unset(request.co_feed_open_deliver_model):
            body['coFeedOpenDeliverModel'] = request.co_feed_open_deliver_model
        if not UtilClient.is_unset(request.co_feed_open_space_model):
            body['coFeedOpenSpaceModel'] = request.co_feed_open_space_model
        if not UtilClient.is_unset(request.im_group_open_deliver_model):
            body['imGroupOpenDeliverModel'] = request.im_group_open_deliver_model
        if not UtilClient.is_unset(request.im_group_open_space_model):
            body['imGroupOpenSpaceModel'] = request.im_group_open_space_model
        if not UtilClient.is_unset(request.im_single_open_deliver_model):
            body['imSingleOpenDeliverModel'] = request.im_single_open_deliver_model
        if not UtilClient.is_unset(request.im_single_open_space_model):
            body['imSingleOpenSpaceModel'] = request.im_single_open_space_model
        if not UtilClient.is_unset(request.open_dynamic_data_config):
            body['openDynamicDataConfig'] = request.open_dynamic_data_config
        if not UtilClient.is_unset(request.open_space_id):
            body['openSpaceId'] = request.open_space_id
        if not UtilClient.is_unset(request.out_track_id):
            body['outTrackId'] = request.out_track_id
        if not UtilClient.is_unset(request.private_data):
            body['privateData'] = request.private_data
        if not UtilClient.is_unset(request.top_open_deliver_model):
            body['topOpenDeliverModel'] = request.top_open_deliver_model
        if not UtilClient.is_unset(request.top_open_space_model):
            body['topOpenSpaceModel'] = request.top_open_space_model
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.user_id_type):
            body['userIdType'] = request.user_id_type
        if not UtilClient.is_unset(request.work_bench_open_deliver_model):
            body['workBenchOpenDeliverModel'] = request.work_bench_open_deliver_model
        if not UtilClient.is_unset(request.work_bench_open_space_model):
            body['workBenchOpenSpaceModel'] = request.work_bench_open_space_model
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkcard__1__0_models.CreateAndDeliverResponse(),
            await self.do_roarequest_async('CreateAndDeliver', 'card_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/card/instances/createAndDeliver', 'json', req, runtime)
        )

    def create_card(
        self,
        request: dingtalkcard__1__0_models.CreateCardRequest,
    ) -> dingtalkcard__1__0_models.CreateCardResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcard__1__0_models.CreateCardHeaders()
        return self.create_card_with_options(request, headers, runtime)

    async def create_card_async(
        self,
        request: dingtalkcard__1__0_models.CreateCardRequest,
    ) -> dingtalkcard__1__0_models.CreateCardResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcard__1__0_models.CreateCardHeaders()
        return await self.create_card_with_options_async(request, headers, runtime)

    def create_card_with_options(
        self,
        request: dingtalkcard__1__0_models.CreateCardRequest,
        headers: dingtalkcard__1__0_models.CreateCardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcard__1__0_models.CreateCardResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.callback_route_key):
            body['callbackRouteKey'] = request.callback_route_key
        if not UtilClient.is_unset(request.card_at_user_ids):
            body['cardAtUserIds'] = request.card_at_user_ids
        if not UtilClient.is_unset(request.card_data):
            body['cardData'] = request.card_data
        if not UtilClient.is_unset(request.card_template_id):
            body['cardTemplateId'] = request.card_template_id
        if not UtilClient.is_unset(request.co_feed_open_space_model):
            body['coFeedOpenSpaceModel'] = request.co_feed_open_space_model
        if not UtilClient.is_unset(request.im_group_open_space_model):
            body['imGroupOpenSpaceModel'] = request.im_group_open_space_model
        if not UtilClient.is_unset(request.im_single_open_space_model):
            body['imSingleOpenSpaceModel'] = request.im_single_open_space_model
        if not UtilClient.is_unset(request.open_dynamic_data_config):
            body['openDynamicDataConfig'] = request.open_dynamic_data_config
        if not UtilClient.is_unset(request.out_track_id):
            body['outTrackId'] = request.out_track_id
        if not UtilClient.is_unset(request.private_data):
            body['privateData'] = request.private_data
        if not UtilClient.is_unset(request.top_open_space_model):
            body['topOpenSpaceModel'] = request.top_open_space_model
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.user_id_type):
            body['userIdType'] = request.user_id_type
        if not UtilClient.is_unset(request.work_bench_open_space_model):
            body['workBenchOpenSpaceModel'] = request.work_bench_open_space_model
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkcard__1__0_models.CreateCardResponse(),
            self.do_roarequest('CreateCard', 'card_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/card/instances', 'json', req, runtime)
        )

    async def create_card_with_options_async(
        self,
        request: dingtalkcard__1__0_models.CreateCardRequest,
        headers: dingtalkcard__1__0_models.CreateCardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcard__1__0_models.CreateCardResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.callback_route_key):
            body['callbackRouteKey'] = request.callback_route_key
        if not UtilClient.is_unset(request.card_at_user_ids):
            body['cardAtUserIds'] = request.card_at_user_ids
        if not UtilClient.is_unset(request.card_data):
            body['cardData'] = request.card_data
        if not UtilClient.is_unset(request.card_template_id):
            body['cardTemplateId'] = request.card_template_id
        if not UtilClient.is_unset(request.co_feed_open_space_model):
            body['coFeedOpenSpaceModel'] = request.co_feed_open_space_model
        if not UtilClient.is_unset(request.im_group_open_space_model):
            body['imGroupOpenSpaceModel'] = request.im_group_open_space_model
        if not UtilClient.is_unset(request.im_single_open_space_model):
            body['imSingleOpenSpaceModel'] = request.im_single_open_space_model
        if not UtilClient.is_unset(request.open_dynamic_data_config):
            body['openDynamicDataConfig'] = request.open_dynamic_data_config
        if not UtilClient.is_unset(request.out_track_id):
            body['outTrackId'] = request.out_track_id
        if not UtilClient.is_unset(request.private_data):
            body['privateData'] = request.private_data
        if not UtilClient.is_unset(request.top_open_space_model):
            body['topOpenSpaceModel'] = request.top_open_space_model
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.user_id_type):
            body['userIdType'] = request.user_id_type
        if not UtilClient.is_unset(request.work_bench_open_space_model):
            body['workBenchOpenSpaceModel'] = request.work_bench_open_space_model
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkcard__1__0_models.CreateCardResponse(),
            await self.do_roarequest_async('CreateCard', 'card_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/card/instances', 'json', req, runtime)
        )

    def deliver_card(
        self,
        request: dingtalkcard__1__0_models.DeliverCardRequest,
    ) -> dingtalkcard__1__0_models.DeliverCardResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcard__1__0_models.DeliverCardHeaders()
        return self.deliver_card_with_options(request, headers, runtime)

    async def deliver_card_async(
        self,
        request: dingtalkcard__1__0_models.DeliverCardRequest,
    ) -> dingtalkcard__1__0_models.DeliverCardResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcard__1__0_models.DeliverCardHeaders()
        return await self.deliver_card_with_options_async(request, headers, runtime)

    def deliver_card_with_options(
        self,
        request: dingtalkcard__1__0_models.DeliverCardRequest,
        headers: dingtalkcard__1__0_models.DeliverCardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcard__1__0_models.DeliverCardResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.co_feed_open_deliver_model):
            body['coFeedOpenDeliverModel'] = request.co_feed_open_deliver_model
        if not UtilClient.is_unset(request.im_group_open_deliver_model):
            body['imGroupOpenDeliverModel'] = request.im_group_open_deliver_model
        if not UtilClient.is_unset(request.im_single_open_deliver_model):
            body['imSingleOpenDeliverModel'] = request.im_single_open_deliver_model
        if not UtilClient.is_unset(request.open_space_id):
            body['openSpaceId'] = request.open_space_id
        if not UtilClient.is_unset(request.out_track_id):
            body['outTrackId'] = request.out_track_id
        if not UtilClient.is_unset(request.top_open_deliver_model):
            body['topOpenDeliverModel'] = request.top_open_deliver_model
        if not UtilClient.is_unset(request.work_bench_open_deliver_model):
            body['workBenchOpenDeliverModel'] = request.work_bench_open_deliver_model
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkcard__1__0_models.DeliverCardResponse(),
            self.do_roarequest('DeliverCard', 'card_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/card/instances/deliver', 'json', req, runtime)
        )

    async def deliver_card_with_options_async(
        self,
        request: dingtalkcard__1__0_models.DeliverCardRequest,
        headers: dingtalkcard__1__0_models.DeliverCardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcard__1__0_models.DeliverCardResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.co_feed_open_deliver_model):
            body['coFeedOpenDeliverModel'] = request.co_feed_open_deliver_model
        if not UtilClient.is_unset(request.im_group_open_deliver_model):
            body['imGroupOpenDeliverModel'] = request.im_group_open_deliver_model
        if not UtilClient.is_unset(request.im_single_open_deliver_model):
            body['imSingleOpenDeliverModel'] = request.im_single_open_deliver_model
        if not UtilClient.is_unset(request.open_space_id):
            body['openSpaceId'] = request.open_space_id
        if not UtilClient.is_unset(request.out_track_id):
            body['outTrackId'] = request.out_track_id
        if not UtilClient.is_unset(request.top_open_deliver_model):
            body['topOpenDeliverModel'] = request.top_open_deliver_model
        if not UtilClient.is_unset(request.work_bench_open_deliver_model):
            body['workBenchOpenDeliverModel'] = request.work_bench_open_deliver_model
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkcard__1__0_models.DeliverCardResponse(),
            await self.do_roarequest_async('DeliverCard', 'card_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/card/instances/deliver', 'json', req, runtime)
        )

    def register_callback(
        self,
        request: dingtalkcard__1__0_models.RegisterCallbackRequest,
    ) -> dingtalkcard__1__0_models.RegisterCallbackResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcard__1__0_models.RegisterCallbackHeaders()
        return self.register_callback_with_options(request, headers, runtime)

    async def register_callback_async(
        self,
        request: dingtalkcard__1__0_models.RegisterCallbackRequest,
    ) -> dingtalkcard__1__0_models.RegisterCallbackResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcard__1__0_models.RegisterCallbackHeaders()
        return await self.register_callback_with_options_async(request, headers, runtime)

    def register_callback_with_options(
        self,
        request: dingtalkcard__1__0_models.RegisterCallbackRequest,
        headers: dingtalkcard__1__0_models.RegisterCallbackHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcard__1__0_models.RegisterCallbackResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.api_secret):
            body['apiSecret'] = request.api_secret
        if not UtilClient.is_unset(request.callback_route_key):
            body['callbackRouteKey'] = request.callback_route_key
        if not UtilClient.is_unset(request.callback_url):
            body['callbackUrl'] = request.callback_url
        if not UtilClient.is_unset(request.force_update):
            body['forceUpdate'] = request.force_update
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkcard__1__0_models.RegisterCallbackResponse(),
            self.do_roarequest('RegisterCallback', 'card_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/card/callbacks/register', 'json', req, runtime)
        )

    async def register_callback_with_options_async(
        self,
        request: dingtalkcard__1__0_models.RegisterCallbackRequest,
        headers: dingtalkcard__1__0_models.RegisterCallbackHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcard__1__0_models.RegisterCallbackResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.api_secret):
            body['apiSecret'] = request.api_secret
        if not UtilClient.is_unset(request.callback_route_key):
            body['callbackRouteKey'] = request.callback_route_key
        if not UtilClient.is_unset(request.callback_url):
            body['callbackUrl'] = request.callback_url
        if not UtilClient.is_unset(request.force_update):
            body['forceUpdate'] = request.force_update
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkcard__1__0_models.RegisterCallbackResponse(),
            await self.do_roarequest_async('RegisterCallback', 'card_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/card/callbacks/register', 'json', req, runtime)
        )

    def update_card(
        self,
        request: dingtalkcard__1__0_models.UpdateCardRequest,
    ) -> dingtalkcard__1__0_models.UpdateCardResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcard__1__0_models.UpdateCardHeaders()
        return self.update_card_with_options(request, headers, runtime)

    async def update_card_async(
        self,
        request: dingtalkcard__1__0_models.UpdateCardRequest,
    ) -> dingtalkcard__1__0_models.UpdateCardResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcard__1__0_models.UpdateCardHeaders()
        return await self.update_card_with_options_async(request, headers, runtime)

    def update_card_with_options(
        self,
        request: dingtalkcard__1__0_models.UpdateCardRequest,
        headers: dingtalkcard__1__0_models.UpdateCardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcard__1__0_models.UpdateCardResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.card_data):
            body['cardData'] = request.card_data
        if not UtilClient.is_unset(request.card_update_options):
            body['cardUpdateOptions'] = request.card_update_options
        if not UtilClient.is_unset(request.out_track_id):
            body['outTrackId'] = request.out_track_id
        if not UtilClient.is_unset(request.private_data):
            body['privateData'] = request.private_data
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkcard__1__0_models.UpdateCardResponse(),
            self.do_roarequest('UpdateCard', 'card_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/card/instances', 'json', req, runtime)
        )

    async def update_card_with_options_async(
        self,
        request: dingtalkcard__1__0_models.UpdateCardRequest,
        headers: dingtalkcard__1__0_models.UpdateCardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcard__1__0_models.UpdateCardResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.card_data):
            body['cardData'] = request.card_data
        if not UtilClient.is_unset(request.card_update_options):
            body['cardUpdateOptions'] = request.card_update_options
        if not UtilClient.is_unset(request.out_track_id):
            body['outTrackId'] = request.out_track_id
        if not UtilClient.is_unset(request.private_data):
            body['privateData'] = request.private_data
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkcard__1__0_models.UpdateCardResponse(),
            await self.do_roarequest_async('UpdateCard', 'card_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/card/instances', 'json', req, runtime)
        )
