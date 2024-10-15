# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
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
        gateway_client = GatewayClientClient()
        self._spi = gateway_client
        self._endpoint_rule = ''
        if UtilClient.empty(self._endpoint):
            self._endpoint = 'api.dingtalk.com'

    def append_space_with_options(
        self,
        request: dingtalkcard__1__0_models.AppendSpaceRequest,
        headers: dingtalkcard__1__0_models.AppendSpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcard__1__0_models.AppendSpaceResponse:
        """
        @summary 新增或更新卡片的场域信息
        
        @param request: AppendSpaceRequest
        @param headers: AppendSpaceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AppendSpaceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.co_feed_open_space_model):
            body['coFeedOpenSpaceModel'] = request.co_feed_open_space_model
        if not UtilClient.is_unset(request.im_group_open_space_model):
            body['imGroupOpenSpaceModel'] = request.im_group_open_space_model
        if not UtilClient.is_unset(request.im_robot_open_space_model):
            body['imRobotOpenSpaceModel'] = request.im_robot_open_space_model
        if not UtilClient.is_unset(request.out_track_id):
            body['outTrackId'] = request.out_track_id
        if not UtilClient.is_unset(request.top_open_space_model):
            body['topOpenSpaceModel'] = request.top_open_space_model
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
            action='AppendSpace',
            version='card_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/card/instances/spaces',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcard__1__0_models.AppendSpaceResponse(),
            self.execute(params, req, runtime)
        )

    async def append_space_with_options_async(
        self,
        request: dingtalkcard__1__0_models.AppendSpaceRequest,
        headers: dingtalkcard__1__0_models.AppendSpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcard__1__0_models.AppendSpaceResponse:
        """
        @summary 新增或更新卡片的场域信息
        
        @param request: AppendSpaceRequest
        @param headers: AppendSpaceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AppendSpaceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.co_feed_open_space_model):
            body['coFeedOpenSpaceModel'] = request.co_feed_open_space_model
        if not UtilClient.is_unset(request.im_group_open_space_model):
            body['imGroupOpenSpaceModel'] = request.im_group_open_space_model
        if not UtilClient.is_unset(request.im_robot_open_space_model):
            body['imRobotOpenSpaceModel'] = request.im_robot_open_space_model
        if not UtilClient.is_unset(request.out_track_id):
            body['outTrackId'] = request.out_track_id
        if not UtilClient.is_unset(request.top_open_space_model):
            body['topOpenSpaceModel'] = request.top_open_space_model
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
            action='AppendSpace',
            version='card_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/card/instances/spaces',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcard__1__0_models.AppendSpaceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def append_space(
        self,
        request: dingtalkcard__1__0_models.AppendSpaceRequest,
    ) -> dingtalkcard__1__0_models.AppendSpaceResponse:
        """
        @summary 新增或更新卡片的场域信息
        
        @param request: AppendSpaceRequest
        @return: AppendSpaceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcard__1__0_models.AppendSpaceHeaders()
        return self.append_space_with_options(request, headers, runtime)

    async def append_space_async(
        self,
        request: dingtalkcard__1__0_models.AppendSpaceRequest,
    ) -> dingtalkcard__1__0_models.AppendSpaceResponse:
        """
        @summary 新增或更新卡片的场域信息
        
        @param request: AppendSpaceRequest
        @return: AppendSpaceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcard__1__0_models.AppendSpaceHeaders()
        return await self.append_space_with_options_async(request, headers, runtime)

    def append_space_with_delegate_with_options(
        self,
        request: dingtalkcard__1__0_models.AppendSpaceWithDelegateRequest,
        headers: dingtalkcard__1__0_models.AppendSpaceWithDelegateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcard__1__0_models.AppendSpaceWithDelegateResponse:
        """
        @summary 新增或更新卡片的场域信息
        
        @param request: AppendSpaceWithDelegateRequest
        @param headers: AppendSpaceWithDelegateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AppendSpaceWithDelegateResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.co_feed_open_space_model):
            body['coFeedOpenSpaceModel'] = request.co_feed_open_space_model
        if not UtilClient.is_unset(request.im_group_open_space_model):
            body['imGroupOpenSpaceModel'] = request.im_group_open_space_model
        if not UtilClient.is_unset(request.im_robot_open_space_model):
            body['imRobotOpenSpaceModel'] = request.im_robot_open_space_model
        if not UtilClient.is_unset(request.out_track_id):
            body['outTrackId'] = request.out_track_id
        if not UtilClient.is_unset(request.top_open_space_model):
            body['topOpenSpaceModel'] = request.top_open_space_model
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
            action='AppendSpaceWithDelegate',
            version='card_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/card/me/instances/spaces',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcard__1__0_models.AppendSpaceWithDelegateResponse(),
            self.execute(params, req, runtime)
        )

    async def append_space_with_delegate_with_options_async(
        self,
        request: dingtalkcard__1__0_models.AppendSpaceWithDelegateRequest,
        headers: dingtalkcard__1__0_models.AppendSpaceWithDelegateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcard__1__0_models.AppendSpaceWithDelegateResponse:
        """
        @summary 新增或更新卡片的场域信息
        
        @param request: AppendSpaceWithDelegateRequest
        @param headers: AppendSpaceWithDelegateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AppendSpaceWithDelegateResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.co_feed_open_space_model):
            body['coFeedOpenSpaceModel'] = request.co_feed_open_space_model
        if not UtilClient.is_unset(request.im_group_open_space_model):
            body['imGroupOpenSpaceModel'] = request.im_group_open_space_model
        if not UtilClient.is_unset(request.im_robot_open_space_model):
            body['imRobotOpenSpaceModel'] = request.im_robot_open_space_model
        if not UtilClient.is_unset(request.out_track_id):
            body['outTrackId'] = request.out_track_id
        if not UtilClient.is_unset(request.top_open_space_model):
            body['topOpenSpaceModel'] = request.top_open_space_model
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
            action='AppendSpaceWithDelegate',
            version='card_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/card/me/instances/spaces',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcard__1__0_models.AppendSpaceWithDelegateResponse(),
            await self.execute_async(params, req, runtime)
        )

    def append_space_with_delegate(
        self,
        request: dingtalkcard__1__0_models.AppendSpaceWithDelegateRequest,
    ) -> dingtalkcard__1__0_models.AppendSpaceWithDelegateResponse:
        """
        @summary 新增或更新卡片的场域信息
        
        @param request: AppendSpaceWithDelegateRequest
        @return: AppendSpaceWithDelegateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcard__1__0_models.AppendSpaceWithDelegateHeaders()
        return self.append_space_with_delegate_with_options(request, headers, runtime)

    async def append_space_with_delegate_async(
        self,
        request: dingtalkcard__1__0_models.AppendSpaceWithDelegateRequest,
    ) -> dingtalkcard__1__0_models.AppendSpaceWithDelegateResponse:
        """
        @summary 新增或更新卡片的场域信息
        
        @param request: AppendSpaceWithDelegateRequest
        @return: AppendSpaceWithDelegateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcard__1__0_models.AppendSpaceWithDelegateHeaders()
        return await self.append_space_with_delegate_with_options_async(request, headers, runtime)

    def copy_template_with_options(
        self,
        request: dingtalkcard__1__0_models.CopyTemplateRequest,
        headers: dingtalkcard__1__0_models.CopyTemplateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcard__1__0_models.CopyTemplateResponse:
        """
        @summary 复制模板
        
        @param request: CopyTemplateRequest
        @param headers: CopyTemplateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CopyTemplateResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.template_id):
            body['templateId'] = request.template_id
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
            action='CopyTemplate',
            version='card_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/card/templates/copy',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcard__1__0_models.CopyTemplateResponse(),
            self.execute(params, req, runtime)
        )

    async def copy_template_with_options_async(
        self,
        request: dingtalkcard__1__0_models.CopyTemplateRequest,
        headers: dingtalkcard__1__0_models.CopyTemplateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcard__1__0_models.CopyTemplateResponse:
        """
        @summary 复制模板
        
        @param request: CopyTemplateRequest
        @param headers: CopyTemplateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CopyTemplateResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.template_id):
            body['templateId'] = request.template_id
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
            action='CopyTemplate',
            version='card_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/card/templates/copy',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcard__1__0_models.CopyTemplateResponse(),
            await self.execute_async(params, req, runtime)
        )

    def copy_template(
        self,
        request: dingtalkcard__1__0_models.CopyTemplateRequest,
    ) -> dingtalkcard__1__0_models.CopyTemplateResponse:
        """
        @summary 复制模板
        
        @param request: CopyTemplateRequest
        @return: CopyTemplateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcard__1__0_models.CopyTemplateHeaders()
        return self.copy_template_with_options(request, headers, runtime)

    async def copy_template_async(
        self,
        request: dingtalkcard__1__0_models.CopyTemplateRequest,
    ) -> dingtalkcard__1__0_models.CopyTemplateResponse:
        """
        @summary 复制模板
        
        @param request: CopyTemplateRequest
        @return: CopyTemplateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcard__1__0_models.CopyTemplateHeaders()
        return await self.copy_template_with_options_async(request, headers, runtime)

    def create_and_deliver_with_options(
        self,
        request: dingtalkcard__1__0_models.CreateAndDeliverRequest,
        headers: dingtalkcard__1__0_models.CreateAndDeliverHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcard__1__0_models.CreateAndDeliverResponse:
        """
        @summary 创建并投放卡片
        
        @param request: CreateAndDeliverRequest
        @param headers: CreateAndDeliverHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateAndDeliverResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.callback_route_key):
            body['callbackRouteKey'] = request.callback_route_key
        if not UtilClient.is_unset(request.callback_type):
            body['callbackType'] = request.callback_type
        if not UtilClient.is_unset(request.card_data):
            body['cardData'] = request.card_data
        if not UtilClient.is_unset(request.card_template_id):
            body['cardTemplateId'] = request.card_template_id
        if not UtilClient.is_unset(request.co_feed_open_deliver_model):
            body['coFeedOpenDeliverModel'] = request.co_feed_open_deliver_model
        if not UtilClient.is_unset(request.co_feed_open_space_model):
            body['coFeedOpenSpaceModel'] = request.co_feed_open_space_model
        if not UtilClient.is_unset(request.doc_open_deliver_model):
            body['docOpenDeliverModel'] = request.doc_open_deliver_model
        if not UtilClient.is_unset(request.im_group_open_deliver_model):
            body['imGroupOpenDeliverModel'] = request.im_group_open_deliver_model
        if not UtilClient.is_unset(request.im_group_open_space_model):
            body['imGroupOpenSpaceModel'] = request.im_group_open_space_model
        if not UtilClient.is_unset(request.im_robot_open_deliver_model):
            body['imRobotOpenDeliverModel'] = request.im_robot_open_deliver_model
        if not UtilClient.is_unset(request.im_robot_open_space_model):
            body['imRobotOpenSpaceModel'] = request.im_robot_open_space_model
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
            action='CreateAndDeliver',
            version='card_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/card/instances/createAndDeliver',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcard__1__0_models.CreateAndDeliverResponse(),
            self.execute(params, req, runtime)
        )

    async def create_and_deliver_with_options_async(
        self,
        request: dingtalkcard__1__0_models.CreateAndDeliverRequest,
        headers: dingtalkcard__1__0_models.CreateAndDeliverHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcard__1__0_models.CreateAndDeliverResponse:
        """
        @summary 创建并投放卡片
        
        @param request: CreateAndDeliverRequest
        @param headers: CreateAndDeliverHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateAndDeliverResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.callback_route_key):
            body['callbackRouteKey'] = request.callback_route_key
        if not UtilClient.is_unset(request.callback_type):
            body['callbackType'] = request.callback_type
        if not UtilClient.is_unset(request.card_data):
            body['cardData'] = request.card_data
        if not UtilClient.is_unset(request.card_template_id):
            body['cardTemplateId'] = request.card_template_id
        if not UtilClient.is_unset(request.co_feed_open_deliver_model):
            body['coFeedOpenDeliverModel'] = request.co_feed_open_deliver_model
        if not UtilClient.is_unset(request.co_feed_open_space_model):
            body['coFeedOpenSpaceModel'] = request.co_feed_open_space_model
        if not UtilClient.is_unset(request.doc_open_deliver_model):
            body['docOpenDeliverModel'] = request.doc_open_deliver_model
        if not UtilClient.is_unset(request.im_group_open_deliver_model):
            body['imGroupOpenDeliverModel'] = request.im_group_open_deliver_model
        if not UtilClient.is_unset(request.im_group_open_space_model):
            body['imGroupOpenSpaceModel'] = request.im_group_open_space_model
        if not UtilClient.is_unset(request.im_robot_open_deliver_model):
            body['imRobotOpenDeliverModel'] = request.im_robot_open_deliver_model
        if not UtilClient.is_unset(request.im_robot_open_space_model):
            body['imRobotOpenSpaceModel'] = request.im_robot_open_space_model
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
            action='CreateAndDeliver',
            version='card_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/card/instances/createAndDeliver',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcard__1__0_models.CreateAndDeliverResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_and_deliver(
        self,
        request: dingtalkcard__1__0_models.CreateAndDeliverRequest,
    ) -> dingtalkcard__1__0_models.CreateAndDeliverResponse:
        """
        @summary 创建并投放卡片
        
        @param request: CreateAndDeliverRequest
        @return: CreateAndDeliverResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcard__1__0_models.CreateAndDeliverHeaders()
        return self.create_and_deliver_with_options(request, headers, runtime)

    async def create_and_deliver_async(
        self,
        request: dingtalkcard__1__0_models.CreateAndDeliverRequest,
    ) -> dingtalkcard__1__0_models.CreateAndDeliverResponse:
        """
        @summary 创建并投放卡片
        
        @param request: CreateAndDeliverRequest
        @return: CreateAndDeliverResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcard__1__0_models.CreateAndDeliverHeaders()
        return await self.create_and_deliver_with_options_async(request, headers, runtime)

    def create_and_deliver_with_delegate_with_options(
        self,
        request: dingtalkcard__1__0_models.CreateAndDeliverWithDelegateRequest,
        headers: dingtalkcard__1__0_models.CreateAndDeliverWithDelegateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcard__1__0_models.CreateAndDeliverWithDelegateResponse:
        """
        @summary 创建并投放卡片
        
        @param request: CreateAndDeliverWithDelegateRequest
        @param headers: CreateAndDeliverWithDelegateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateAndDeliverWithDelegateResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.callback_route_key):
            body['callbackRouteKey'] = request.callback_route_key
        if not UtilClient.is_unset(request.callback_type):
            body['callbackType'] = request.callback_type
        if not UtilClient.is_unset(request.card_data):
            body['cardData'] = request.card_data
        if not UtilClient.is_unset(request.card_template_id):
            body['cardTemplateId'] = request.card_template_id
        if not UtilClient.is_unset(request.co_feed_open_deliver_model):
            body['coFeedOpenDeliverModel'] = request.co_feed_open_deliver_model
        if not UtilClient.is_unset(request.co_feed_open_space_model):
            body['coFeedOpenSpaceModel'] = request.co_feed_open_space_model
        if not UtilClient.is_unset(request.doc_open_deliver_model):
            body['docOpenDeliverModel'] = request.doc_open_deliver_model
        if not UtilClient.is_unset(request.im_group_open_deliver_model):
            body['imGroupOpenDeliverModel'] = request.im_group_open_deliver_model
        if not UtilClient.is_unset(request.im_group_open_space_model):
            body['imGroupOpenSpaceModel'] = request.im_group_open_space_model
        if not UtilClient.is_unset(request.im_robot_open_deliver_model):
            body['imRobotOpenDeliverModel'] = request.im_robot_open_deliver_model
        if not UtilClient.is_unset(request.im_robot_open_space_model):
            body['imRobotOpenSpaceModel'] = request.im_robot_open_space_model
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
            action='CreateAndDeliverWithDelegate',
            version='card_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/card/me/instances/createAndDeliver',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcard__1__0_models.CreateAndDeliverWithDelegateResponse(),
            self.execute(params, req, runtime)
        )

    async def create_and_deliver_with_delegate_with_options_async(
        self,
        request: dingtalkcard__1__0_models.CreateAndDeliverWithDelegateRequest,
        headers: dingtalkcard__1__0_models.CreateAndDeliverWithDelegateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcard__1__0_models.CreateAndDeliverWithDelegateResponse:
        """
        @summary 创建并投放卡片
        
        @param request: CreateAndDeliverWithDelegateRequest
        @param headers: CreateAndDeliverWithDelegateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateAndDeliverWithDelegateResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.callback_route_key):
            body['callbackRouteKey'] = request.callback_route_key
        if not UtilClient.is_unset(request.callback_type):
            body['callbackType'] = request.callback_type
        if not UtilClient.is_unset(request.card_data):
            body['cardData'] = request.card_data
        if not UtilClient.is_unset(request.card_template_id):
            body['cardTemplateId'] = request.card_template_id
        if not UtilClient.is_unset(request.co_feed_open_deliver_model):
            body['coFeedOpenDeliverModel'] = request.co_feed_open_deliver_model
        if not UtilClient.is_unset(request.co_feed_open_space_model):
            body['coFeedOpenSpaceModel'] = request.co_feed_open_space_model
        if not UtilClient.is_unset(request.doc_open_deliver_model):
            body['docOpenDeliverModel'] = request.doc_open_deliver_model
        if not UtilClient.is_unset(request.im_group_open_deliver_model):
            body['imGroupOpenDeliverModel'] = request.im_group_open_deliver_model
        if not UtilClient.is_unset(request.im_group_open_space_model):
            body['imGroupOpenSpaceModel'] = request.im_group_open_space_model
        if not UtilClient.is_unset(request.im_robot_open_deliver_model):
            body['imRobotOpenDeliverModel'] = request.im_robot_open_deliver_model
        if not UtilClient.is_unset(request.im_robot_open_space_model):
            body['imRobotOpenSpaceModel'] = request.im_robot_open_space_model
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
            action='CreateAndDeliverWithDelegate',
            version='card_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/card/me/instances/createAndDeliver',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcard__1__0_models.CreateAndDeliverWithDelegateResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_and_deliver_with_delegate(
        self,
        request: dingtalkcard__1__0_models.CreateAndDeliverWithDelegateRequest,
    ) -> dingtalkcard__1__0_models.CreateAndDeliverWithDelegateResponse:
        """
        @summary 创建并投放卡片
        
        @param request: CreateAndDeliverWithDelegateRequest
        @return: CreateAndDeliverWithDelegateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcard__1__0_models.CreateAndDeliverWithDelegateHeaders()
        return self.create_and_deliver_with_delegate_with_options(request, headers, runtime)

    async def create_and_deliver_with_delegate_async(
        self,
        request: dingtalkcard__1__0_models.CreateAndDeliverWithDelegateRequest,
    ) -> dingtalkcard__1__0_models.CreateAndDeliverWithDelegateResponse:
        """
        @summary 创建并投放卡片
        
        @param request: CreateAndDeliverWithDelegateRequest
        @return: CreateAndDeliverWithDelegateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcard__1__0_models.CreateAndDeliverWithDelegateHeaders()
        return await self.create_and_deliver_with_delegate_with_options_async(request, headers, runtime)

    def create_card_with_options(
        self,
        request: dingtalkcard__1__0_models.CreateCardRequest,
        headers: dingtalkcard__1__0_models.CreateCardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcard__1__0_models.CreateCardResponse:
        """
        @summary 创建卡片
        
        @param request: CreateCardRequest
        @param headers: CreateCardHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateCardResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.callback_route_key):
            body['callbackRouteKey'] = request.callback_route_key
        if not UtilClient.is_unset(request.callback_type):
            body['callbackType'] = request.callback_type
        if not UtilClient.is_unset(request.card_data):
            body['cardData'] = request.card_data
        if not UtilClient.is_unset(request.card_template_id):
            body['cardTemplateId'] = request.card_template_id
        if not UtilClient.is_unset(request.co_feed_open_space_model):
            body['coFeedOpenSpaceModel'] = request.co_feed_open_space_model
        if not UtilClient.is_unset(request.im_group_open_space_model):
            body['imGroupOpenSpaceModel'] = request.im_group_open_space_model
        if not UtilClient.is_unset(request.im_robot_open_space_model):
            body['imRobotOpenSpaceModel'] = request.im_robot_open_space_model
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
            action='CreateCard',
            version='card_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/card/instances',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcard__1__0_models.CreateCardResponse(),
            self.execute(params, req, runtime)
        )

    async def create_card_with_options_async(
        self,
        request: dingtalkcard__1__0_models.CreateCardRequest,
        headers: dingtalkcard__1__0_models.CreateCardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcard__1__0_models.CreateCardResponse:
        """
        @summary 创建卡片
        
        @param request: CreateCardRequest
        @param headers: CreateCardHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateCardResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.callback_route_key):
            body['callbackRouteKey'] = request.callback_route_key
        if not UtilClient.is_unset(request.callback_type):
            body['callbackType'] = request.callback_type
        if not UtilClient.is_unset(request.card_data):
            body['cardData'] = request.card_data
        if not UtilClient.is_unset(request.card_template_id):
            body['cardTemplateId'] = request.card_template_id
        if not UtilClient.is_unset(request.co_feed_open_space_model):
            body['coFeedOpenSpaceModel'] = request.co_feed_open_space_model
        if not UtilClient.is_unset(request.im_group_open_space_model):
            body['imGroupOpenSpaceModel'] = request.im_group_open_space_model
        if not UtilClient.is_unset(request.im_robot_open_space_model):
            body['imRobotOpenSpaceModel'] = request.im_robot_open_space_model
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
            action='CreateCard',
            version='card_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/card/instances',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcard__1__0_models.CreateCardResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_card(
        self,
        request: dingtalkcard__1__0_models.CreateCardRequest,
    ) -> dingtalkcard__1__0_models.CreateCardResponse:
        """
        @summary 创建卡片
        
        @param request: CreateCardRequest
        @return: CreateCardResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcard__1__0_models.CreateCardHeaders()
        return self.create_card_with_options(request, headers, runtime)

    async def create_card_async(
        self,
        request: dingtalkcard__1__0_models.CreateCardRequest,
    ) -> dingtalkcard__1__0_models.CreateCardResponse:
        """
        @summary 创建卡片
        
        @param request: CreateCardRequest
        @return: CreateCardResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcard__1__0_models.CreateCardHeaders()
        return await self.create_card_with_options_async(request, headers, runtime)

    def create_card_with_delegate_with_options(
        self,
        request: dingtalkcard__1__0_models.CreateCardWithDelegateRequest,
        headers: dingtalkcard__1__0_models.CreateCardWithDelegateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcard__1__0_models.CreateCardWithDelegateResponse:
        """
        @summary 创建卡片
        
        @param request: CreateCardWithDelegateRequest
        @param headers: CreateCardWithDelegateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateCardWithDelegateResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.callback_route_key):
            body['callbackRouteKey'] = request.callback_route_key
        if not UtilClient.is_unset(request.callback_type):
            body['callbackType'] = request.callback_type
        if not UtilClient.is_unset(request.card_data):
            body['cardData'] = request.card_data
        if not UtilClient.is_unset(request.card_template_id):
            body['cardTemplateId'] = request.card_template_id
        if not UtilClient.is_unset(request.co_feed_open_space_model):
            body['coFeedOpenSpaceModel'] = request.co_feed_open_space_model
        if not UtilClient.is_unset(request.im_group_open_space_model):
            body['imGroupOpenSpaceModel'] = request.im_group_open_space_model
        if not UtilClient.is_unset(request.im_robot_open_space_model):
            body['imRobotOpenSpaceModel'] = request.im_robot_open_space_model
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
            action='CreateCardWithDelegate',
            version='card_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/card/me/instances',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcard__1__0_models.CreateCardWithDelegateResponse(),
            self.execute(params, req, runtime)
        )

    async def create_card_with_delegate_with_options_async(
        self,
        request: dingtalkcard__1__0_models.CreateCardWithDelegateRequest,
        headers: dingtalkcard__1__0_models.CreateCardWithDelegateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcard__1__0_models.CreateCardWithDelegateResponse:
        """
        @summary 创建卡片
        
        @param request: CreateCardWithDelegateRequest
        @param headers: CreateCardWithDelegateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateCardWithDelegateResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.callback_route_key):
            body['callbackRouteKey'] = request.callback_route_key
        if not UtilClient.is_unset(request.callback_type):
            body['callbackType'] = request.callback_type
        if not UtilClient.is_unset(request.card_data):
            body['cardData'] = request.card_data
        if not UtilClient.is_unset(request.card_template_id):
            body['cardTemplateId'] = request.card_template_id
        if not UtilClient.is_unset(request.co_feed_open_space_model):
            body['coFeedOpenSpaceModel'] = request.co_feed_open_space_model
        if not UtilClient.is_unset(request.im_group_open_space_model):
            body['imGroupOpenSpaceModel'] = request.im_group_open_space_model
        if not UtilClient.is_unset(request.im_robot_open_space_model):
            body['imRobotOpenSpaceModel'] = request.im_robot_open_space_model
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
            action='CreateCardWithDelegate',
            version='card_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/card/me/instances',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcard__1__0_models.CreateCardWithDelegateResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_card_with_delegate(
        self,
        request: dingtalkcard__1__0_models.CreateCardWithDelegateRequest,
    ) -> dingtalkcard__1__0_models.CreateCardWithDelegateResponse:
        """
        @summary 创建卡片
        
        @param request: CreateCardWithDelegateRequest
        @return: CreateCardWithDelegateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcard__1__0_models.CreateCardWithDelegateHeaders()
        return self.create_card_with_delegate_with_options(request, headers, runtime)

    async def create_card_with_delegate_async(
        self,
        request: dingtalkcard__1__0_models.CreateCardWithDelegateRequest,
    ) -> dingtalkcard__1__0_models.CreateCardWithDelegateResponse:
        """
        @summary 创建卡片
        
        @param request: CreateCardWithDelegateRequest
        @return: CreateCardWithDelegateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcard__1__0_models.CreateCardWithDelegateHeaders()
        return await self.create_card_with_delegate_with_options_async(request, headers, runtime)

    def create_template_with_options(
        self,
        request: dingtalkcard__1__0_models.CreateTemplateRequest,
        headers: dingtalkcard__1__0_models.CreateTemplateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcard__1__0_models.CreateTemplateResponse:
        """
        @summary 创建模板
        
        @param request: CreateTemplateRequest
        @param headers: CreateTemplateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateTemplateResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_id):
            body['appId'] = request.app_id
        if not UtilClient.is_unset(request.creator_id):
            body['creatorId'] = request.creator_id
        if not UtilClient.is_unset(request.extend_type):
            body['extendType'] = request.extend_type
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
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
            action='CreateTemplate',
            version='card_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/card/templates',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcard__1__0_models.CreateTemplateResponse(),
            self.execute(params, req, runtime)
        )

    async def create_template_with_options_async(
        self,
        request: dingtalkcard__1__0_models.CreateTemplateRequest,
        headers: dingtalkcard__1__0_models.CreateTemplateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcard__1__0_models.CreateTemplateResponse:
        """
        @summary 创建模板
        
        @param request: CreateTemplateRequest
        @param headers: CreateTemplateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateTemplateResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_id):
            body['appId'] = request.app_id
        if not UtilClient.is_unset(request.creator_id):
            body['creatorId'] = request.creator_id
        if not UtilClient.is_unset(request.extend_type):
            body['extendType'] = request.extend_type
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
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
            action='CreateTemplate',
            version='card_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/card/templates',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcard__1__0_models.CreateTemplateResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_template(
        self,
        request: dingtalkcard__1__0_models.CreateTemplateRequest,
    ) -> dingtalkcard__1__0_models.CreateTemplateResponse:
        """
        @summary 创建模板
        
        @param request: CreateTemplateRequest
        @return: CreateTemplateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcard__1__0_models.CreateTemplateHeaders()
        return self.create_template_with_options(request, headers, runtime)

    async def create_template_async(
        self,
        request: dingtalkcard__1__0_models.CreateTemplateRequest,
    ) -> dingtalkcard__1__0_models.CreateTemplateResponse:
        """
        @summary 创建模板
        
        @param request: CreateTemplateRequest
        @return: CreateTemplateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcard__1__0_models.CreateTemplateHeaders()
        return await self.create_template_with_options_async(request, headers, runtime)

    def delete_template_with_options(
        self,
        request: dingtalkcard__1__0_models.DeleteTemplateRequest,
        headers: dingtalkcard__1__0_models.DeleteTemplateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcard__1__0_models.DeleteTemplateResponse:
        """
        @summary 删除模板
        
        @param request: DeleteTemplateRequest
        @param headers: DeleteTemplateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteTemplateResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.template_id):
            body['templateId'] = request.template_id
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
            action='DeleteTemplate',
            version='card_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/card/templates/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcard__1__0_models.DeleteTemplateResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_template_with_options_async(
        self,
        request: dingtalkcard__1__0_models.DeleteTemplateRequest,
        headers: dingtalkcard__1__0_models.DeleteTemplateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcard__1__0_models.DeleteTemplateResponse:
        """
        @summary 删除模板
        
        @param request: DeleteTemplateRequest
        @param headers: DeleteTemplateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteTemplateResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.template_id):
            body['templateId'] = request.template_id
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
            action='DeleteTemplate',
            version='card_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/card/templates/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcard__1__0_models.DeleteTemplateResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_template(
        self,
        request: dingtalkcard__1__0_models.DeleteTemplateRequest,
    ) -> dingtalkcard__1__0_models.DeleteTemplateResponse:
        """
        @summary 删除模板
        
        @param request: DeleteTemplateRequest
        @return: DeleteTemplateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcard__1__0_models.DeleteTemplateHeaders()
        return self.delete_template_with_options(request, headers, runtime)

    async def delete_template_async(
        self,
        request: dingtalkcard__1__0_models.DeleteTemplateRequest,
    ) -> dingtalkcard__1__0_models.DeleteTemplateResponse:
        """
        @summary 删除模板
        
        @param request: DeleteTemplateRequest
        @return: DeleteTemplateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcard__1__0_models.DeleteTemplateHeaders()
        return await self.delete_template_with_options_async(request, headers, runtime)

    def deliver_card_with_options(
        self,
        request: dingtalkcard__1__0_models.DeliverCardRequest,
        headers: dingtalkcard__1__0_models.DeliverCardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcard__1__0_models.DeliverCardResponse:
        """
        @summary 投放卡片
        
        @param request: DeliverCardRequest
        @param headers: DeliverCardHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeliverCardResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.co_feed_open_deliver_model):
            body['coFeedOpenDeliverModel'] = request.co_feed_open_deliver_model
        if not UtilClient.is_unset(request.doc_open_deliver_model):
            body['docOpenDeliverModel'] = request.doc_open_deliver_model
        if not UtilClient.is_unset(request.im_group_open_deliver_model):
            body['imGroupOpenDeliverModel'] = request.im_group_open_deliver_model
        if not UtilClient.is_unset(request.im_robot_open_deliver_model):
            body['imRobotOpenDeliverModel'] = request.im_robot_open_deliver_model
        if not UtilClient.is_unset(request.im_single_open_deliver_model):
            body['imSingleOpenDeliverModel'] = request.im_single_open_deliver_model
        if not UtilClient.is_unset(request.open_space_id):
            body['openSpaceId'] = request.open_space_id
        if not UtilClient.is_unset(request.out_track_id):
            body['outTrackId'] = request.out_track_id
        if not UtilClient.is_unset(request.top_open_deliver_model):
            body['topOpenDeliverModel'] = request.top_open_deliver_model
        if not UtilClient.is_unset(request.user_id_type):
            body['userIdType'] = request.user_id_type
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
            action='DeliverCard',
            version='card_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/card/instances/deliver',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcard__1__0_models.DeliverCardResponse(),
            self.execute(params, req, runtime)
        )

    async def deliver_card_with_options_async(
        self,
        request: dingtalkcard__1__0_models.DeliverCardRequest,
        headers: dingtalkcard__1__0_models.DeliverCardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcard__1__0_models.DeliverCardResponse:
        """
        @summary 投放卡片
        
        @param request: DeliverCardRequest
        @param headers: DeliverCardHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeliverCardResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.co_feed_open_deliver_model):
            body['coFeedOpenDeliverModel'] = request.co_feed_open_deliver_model
        if not UtilClient.is_unset(request.doc_open_deliver_model):
            body['docOpenDeliverModel'] = request.doc_open_deliver_model
        if not UtilClient.is_unset(request.im_group_open_deliver_model):
            body['imGroupOpenDeliverModel'] = request.im_group_open_deliver_model
        if not UtilClient.is_unset(request.im_robot_open_deliver_model):
            body['imRobotOpenDeliverModel'] = request.im_robot_open_deliver_model
        if not UtilClient.is_unset(request.im_single_open_deliver_model):
            body['imSingleOpenDeliverModel'] = request.im_single_open_deliver_model
        if not UtilClient.is_unset(request.open_space_id):
            body['openSpaceId'] = request.open_space_id
        if not UtilClient.is_unset(request.out_track_id):
            body['outTrackId'] = request.out_track_id
        if not UtilClient.is_unset(request.top_open_deliver_model):
            body['topOpenDeliverModel'] = request.top_open_deliver_model
        if not UtilClient.is_unset(request.user_id_type):
            body['userIdType'] = request.user_id_type
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
            action='DeliverCard',
            version='card_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/card/instances/deliver',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcard__1__0_models.DeliverCardResponse(),
            await self.execute_async(params, req, runtime)
        )

    def deliver_card(
        self,
        request: dingtalkcard__1__0_models.DeliverCardRequest,
    ) -> dingtalkcard__1__0_models.DeliverCardResponse:
        """
        @summary 投放卡片
        
        @param request: DeliverCardRequest
        @return: DeliverCardResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcard__1__0_models.DeliverCardHeaders()
        return self.deliver_card_with_options(request, headers, runtime)

    async def deliver_card_async(
        self,
        request: dingtalkcard__1__0_models.DeliverCardRequest,
    ) -> dingtalkcard__1__0_models.DeliverCardResponse:
        """
        @summary 投放卡片
        
        @param request: DeliverCardRequest
        @return: DeliverCardResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcard__1__0_models.DeliverCardHeaders()
        return await self.deliver_card_with_options_async(request, headers, runtime)

    def deliver_card_with_delegate_with_options(
        self,
        request: dingtalkcard__1__0_models.DeliverCardWithDelegateRequest,
        headers: dingtalkcard__1__0_models.DeliverCardWithDelegateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcard__1__0_models.DeliverCardWithDelegateResponse:
        """
        @summary 投放卡片
        
        @param request: DeliverCardWithDelegateRequest
        @param headers: DeliverCardWithDelegateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeliverCardWithDelegateResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.co_feed_open_deliver_model):
            body['coFeedOpenDeliverModel'] = request.co_feed_open_deliver_model
        if not UtilClient.is_unset(request.doc_open_deliver_model):
            body['docOpenDeliverModel'] = request.doc_open_deliver_model
        if not UtilClient.is_unset(request.im_group_open_deliver_model):
            body['imGroupOpenDeliverModel'] = request.im_group_open_deliver_model
        if not UtilClient.is_unset(request.im_robot_open_deliver_model):
            body['imRobotOpenDeliverModel'] = request.im_robot_open_deliver_model
        if not UtilClient.is_unset(request.im_single_open_deliver_model):
            body['imSingleOpenDeliverModel'] = request.im_single_open_deliver_model
        if not UtilClient.is_unset(request.open_space_id):
            body['openSpaceId'] = request.open_space_id
        if not UtilClient.is_unset(request.out_track_id):
            body['outTrackId'] = request.out_track_id
        if not UtilClient.is_unset(request.top_open_deliver_model):
            body['topOpenDeliverModel'] = request.top_open_deliver_model
        if not UtilClient.is_unset(request.user_id_type):
            body['userIdType'] = request.user_id_type
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
            action='DeliverCardWithDelegate',
            version='card_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/card/me/instances/deliver',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcard__1__0_models.DeliverCardWithDelegateResponse(),
            self.execute(params, req, runtime)
        )

    async def deliver_card_with_delegate_with_options_async(
        self,
        request: dingtalkcard__1__0_models.DeliverCardWithDelegateRequest,
        headers: dingtalkcard__1__0_models.DeliverCardWithDelegateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcard__1__0_models.DeliverCardWithDelegateResponse:
        """
        @summary 投放卡片
        
        @param request: DeliverCardWithDelegateRequest
        @param headers: DeliverCardWithDelegateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeliverCardWithDelegateResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.co_feed_open_deliver_model):
            body['coFeedOpenDeliverModel'] = request.co_feed_open_deliver_model
        if not UtilClient.is_unset(request.doc_open_deliver_model):
            body['docOpenDeliverModel'] = request.doc_open_deliver_model
        if not UtilClient.is_unset(request.im_group_open_deliver_model):
            body['imGroupOpenDeliverModel'] = request.im_group_open_deliver_model
        if not UtilClient.is_unset(request.im_robot_open_deliver_model):
            body['imRobotOpenDeliverModel'] = request.im_robot_open_deliver_model
        if not UtilClient.is_unset(request.im_single_open_deliver_model):
            body['imSingleOpenDeliverModel'] = request.im_single_open_deliver_model
        if not UtilClient.is_unset(request.open_space_id):
            body['openSpaceId'] = request.open_space_id
        if not UtilClient.is_unset(request.out_track_id):
            body['outTrackId'] = request.out_track_id
        if not UtilClient.is_unset(request.top_open_deliver_model):
            body['topOpenDeliverModel'] = request.top_open_deliver_model
        if not UtilClient.is_unset(request.user_id_type):
            body['userIdType'] = request.user_id_type
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
            action='DeliverCardWithDelegate',
            version='card_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/card/me/instances/deliver',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcard__1__0_models.DeliverCardWithDelegateResponse(),
            await self.execute_async(params, req, runtime)
        )

    def deliver_card_with_delegate(
        self,
        request: dingtalkcard__1__0_models.DeliverCardWithDelegateRequest,
    ) -> dingtalkcard__1__0_models.DeliverCardWithDelegateResponse:
        """
        @summary 投放卡片
        
        @param request: DeliverCardWithDelegateRequest
        @return: DeliverCardWithDelegateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcard__1__0_models.DeliverCardWithDelegateHeaders()
        return self.deliver_card_with_delegate_with_options(request, headers, runtime)

    async def deliver_card_with_delegate_async(
        self,
        request: dingtalkcard__1__0_models.DeliverCardWithDelegateRequest,
    ) -> dingtalkcard__1__0_models.DeliverCardWithDelegateResponse:
        """
        @summary 投放卡片
        
        @param request: DeliverCardWithDelegateRequest
        @return: DeliverCardWithDelegateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcard__1__0_models.DeliverCardWithDelegateHeaders()
        return await self.deliver_card_with_delegate_with_options_async(request, headers, runtime)

    def get_template_with_options(
        self,
        request: dingtalkcard__1__0_models.GetTemplateRequest,
        headers: dingtalkcard__1__0_models.GetTemplateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcard__1__0_models.GetTemplateResponse:
        """
        @summary 获取模板信息
        
        @param request: GetTemplateRequest
        @param headers: GetTemplateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetTemplateResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.template_id):
            query['templateId'] = request.template_id
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
            action='GetTemplate',
            version='card_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/card/templates',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcard__1__0_models.GetTemplateResponse(),
            self.execute(params, req, runtime)
        )

    async def get_template_with_options_async(
        self,
        request: dingtalkcard__1__0_models.GetTemplateRequest,
        headers: dingtalkcard__1__0_models.GetTemplateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcard__1__0_models.GetTemplateResponse:
        """
        @summary 获取模板信息
        
        @param request: GetTemplateRequest
        @param headers: GetTemplateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetTemplateResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.template_id):
            query['templateId'] = request.template_id
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
            action='GetTemplate',
            version='card_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/card/templates',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcard__1__0_models.GetTemplateResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_template(
        self,
        request: dingtalkcard__1__0_models.GetTemplateRequest,
    ) -> dingtalkcard__1__0_models.GetTemplateResponse:
        """
        @summary 获取模板信息
        
        @param request: GetTemplateRequest
        @return: GetTemplateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcard__1__0_models.GetTemplateHeaders()
        return self.get_template_with_options(request, headers, runtime)

    async def get_template_async(
        self,
        request: dingtalkcard__1__0_models.GetTemplateRequest,
    ) -> dingtalkcard__1__0_models.GetTemplateResponse:
        """
        @summary 获取模板信息
        
        @param request: GetTemplateRequest
        @return: GetTemplateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcard__1__0_models.GetTemplateHeaders()
        return await self.get_template_with_options_async(request, headers, runtime)

    def publish_template_with_options(
        self,
        request: dingtalkcard__1__0_models.PublishTemplateRequest,
        headers: dingtalkcard__1__0_models.PublishTemplateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcard__1__0_models.PublishTemplateResponse:
        """
        @summary 发布模板
        
        @param request: PublishTemplateRequest
        @param headers: PublishTemplateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PublishTemplateResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.template_id):
            body['templateId'] = request.template_id
        if not UtilClient.is_unset(request.template_source):
            body['templateSource'] = request.template_source
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
            action='PublishTemplate',
            version='card_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/card/templates/publish',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcard__1__0_models.PublishTemplateResponse(),
            self.execute(params, req, runtime)
        )

    async def publish_template_with_options_async(
        self,
        request: dingtalkcard__1__0_models.PublishTemplateRequest,
        headers: dingtalkcard__1__0_models.PublishTemplateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcard__1__0_models.PublishTemplateResponse:
        """
        @summary 发布模板
        
        @param request: PublishTemplateRequest
        @param headers: PublishTemplateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PublishTemplateResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.template_id):
            body['templateId'] = request.template_id
        if not UtilClient.is_unset(request.template_source):
            body['templateSource'] = request.template_source
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
            action='PublishTemplate',
            version='card_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/card/templates/publish',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcard__1__0_models.PublishTemplateResponse(),
            await self.execute_async(params, req, runtime)
        )

    def publish_template(
        self,
        request: dingtalkcard__1__0_models.PublishTemplateRequest,
    ) -> dingtalkcard__1__0_models.PublishTemplateResponse:
        """
        @summary 发布模板
        
        @param request: PublishTemplateRequest
        @return: PublishTemplateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcard__1__0_models.PublishTemplateHeaders()
        return self.publish_template_with_options(request, headers, runtime)

    async def publish_template_async(
        self,
        request: dingtalkcard__1__0_models.PublishTemplateRequest,
    ) -> dingtalkcard__1__0_models.PublishTemplateResponse:
        """
        @summary 发布模板
        
        @param request: PublishTemplateRequest
        @return: PublishTemplateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcard__1__0_models.PublishTemplateHeaders()
        return await self.publish_template_with_options_async(request, headers, runtime)

    def register_callback_with_options(
        self,
        request: dingtalkcard__1__0_models.RegisterCallbackRequest,
        headers: dingtalkcard__1__0_models.RegisterCallbackHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcard__1__0_models.RegisterCallbackResponse:
        """
        @summary 注册卡片回调地址
        
        @param request: RegisterCallbackRequest
        @param headers: RegisterCallbackHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RegisterCallbackResponse
        """
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
        params = open_api_models.Params(
            action='RegisterCallback',
            version='card_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/card/callbacks/register',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcard__1__0_models.RegisterCallbackResponse(),
            self.execute(params, req, runtime)
        )

    async def register_callback_with_options_async(
        self,
        request: dingtalkcard__1__0_models.RegisterCallbackRequest,
        headers: dingtalkcard__1__0_models.RegisterCallbackHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcard__1__0_models.RegisterCallbackResponse:
        """
        @summary 注册卡片回调地址
        
        @param request: RegisterCallbackRequest
        @param headers: RegisterCallbackHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RegisterCallbackResponse
        """
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
        params = open_api_models.Params(
            action='RegisterCallback',
            version='card_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/card/callbacks/register',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcard__1__0_models.RegisterCallbackResponse(),
            await self.execute_async(params, req, runtime)
        )

    def register_callback(
        self,
        request: dingtalkcard__1__0_models.RegisterCallbackRequest,
    ) -> dingtalkcard__1__0_models.RegisterCallbackResponse:
        """
        @summary 注册卡片回调地址
        
        @param request: RegisterCallbackRequest
        @return: RegisterCallbackResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcard__1__0_models.RegisterCallbackHeaders()
        return self.register_callback_with_options(request, headers, runtime)

    async def register_callback_async(
        self,
        request: dingtalkcard__1__0_models.RegisterCallbackRequest,
    ) -> dingtalkcard__1__0_models.RegisterCallbackResponse:
        """
        @summary 注册卡片回调地址
        
        @param request: RegisterCallbackRequest
        @return: RegisterCallbackResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcard__1__0_models.RegisterCallbackHeaders()
        return await self.register_callback_with_options_async(request, headers, runtime)

    def register_callback_with_delegate_with_options(
        self,
        request: dingtalkcard__1__0_models.RegisterCallbackWithDelegateRequest,
        headers: dingtalkcard__1__0_models.RegisterCallbackWithDelegateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcard__1__0_models.RegisterCallbackWithDelegateResponse:
        """
        @summary 注册卡片回调地址
        
        @param request: RegisterCallbackWithDelegateRequest
        @param headers: RegisterCallbackWithDelegateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RegisterCallbackWithDelegateResponse
        """
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
        params = open_api_models.Params(
            action='RegisterCallbackWithDelegate',
            version='card_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/card/me/callbacks/register',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcard__1__0_models.RegisterCallbackWithDelegateResponse(),
            self.execute(params, req, runtime)
        )

    async def register_callback_with_delegate_with_options_async(
        self,
        request: dingtalkcard__1__0_models.RegisterCallbackWithDelegateRequest,
        headers: dingtalkcard__1__0_models.RegisterCallbackWithDelegateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcard__1__0_models.RegisterCallbackWithDelegateResponse:
        """
        @summary 注册卡片回调地址
        
        @param request: RegisterCallbackWithDelegateRequest
        @param headers: RegisterCallbackWithDelegateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RegisterCallbackWithDelegateResponse
        """
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
        params = open_api_models.Params(
            action='RegisterCallbackWithDelegate',
            version='card_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/card/me/callbacks/register',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcard__1__0_models.RegisterCallbackWithDelegateResponse(),
            await self.execute_async(params, req, runtime)
        )

    def register_callback_with_delegate(
        self,
        request: dingtalkcard__1__0_models.RegisterCallbackWithDelegateRequest,
    ) -> dingtalkcard__1__0_models.RegisterCallbackWithDelegateResponse:
        """
        @summary 注册卡片回调地址
        
        @param request: RegisterCallbackWithDelegateRequest
        @return: RegisterCallbackWithDelegateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcard__1__0_models.RegisterCallbackWithDelegateHeaders()
        return self.register_callback_with_delegate_with_options(request, headers, runtime)

    async def register_callback_with_delegate_async(
        self,
        request: dingtalkcard__1__0_models.RegisterCallbackWithDelegateRequest,
    ) -> dingtalkcard__1__0_models.RegisterCallbackWithDelegateResponse:
        """
        @summary 注册卡片回调地址
        
        @param request: RegisterCallbackWithDelegateRequest
        @return: RegisterCallbackWithDelegateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcard__1__0_models.RegisterCallbackWithDelegateHeaders()
        return await self.register_callback_with_delegate_with_options_async(request, headers, runtime)

    def save_template_with_options(
        self,
        request: dingtalkcard__1__0_models.SaveTemplateRequest,
        headers: dingtalkcard__1__0_models.SaveTemplateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcard__1__0_models.SaveTemplateResponse:
        """
        @summary 保存模板
        
        @param request: SaveTemplateRequest
        @param headers: SaveTemplateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SaveTemplateResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.template_id):
            body['templateId'] = request.template_id
        if not UtilClient.is_unset(request.template_source):
            body['templateSource'] = request.template_source
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
            action='SaveTemplate',
            version='card_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/card/templates/save',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcard__1__0_models.SaveTemplateResponse(),
            self.execute(params, req, runtime)
        )

    async def save_template_with_options_async(
        self,
        request: dingtalkcard__1__0_models.SaveTemplateRequest,
        headers: dingtalkcard__1__0_models.SaveTemplateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcard__1__0_models.SaveTemplateResponse:
        """
        @summary 保存模板
        
        @param request: SaveTemplateRequest
        @param headers: SaveTemplateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SaveTemplateResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.template_id):
            body['templateId'] = request.template_id
        if not UtilClient.is_unset(request.template_source):
            body['templateSource'] = request.template_source
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
            action='SaveTemplate',
            version='card_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/card/templates/save',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcard__1__0_models.SaveTemplateResponse(),
            await self.execute_async(params, req, runtime)
        )

    def save_template(
        self,
        request: dingtalkcard__1__0_models.SaveTemplateRequest,
    ) -> dingtalkcard__1__0_models.SaveTemplateResponse:
        """
        @summary 保存模板
        
        @param request: SaveTemplateRequest
        @return: SaveTemplateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcard__1__0_models.SaveTemplateHeaders()
        return self.save_template_with_options(request, headers, runtime)

    async def save_template_async(
        self,
        request: dingtalkcard__1__0_models.SaveTemplateRequest,
    ) -> dingtalkcard__1__0_models.SaveTemplateResponse:
        """
        @summary 保存模板
        
        @param request: SaveTemplateRequest
        @return: SaveTemplateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcard__1__0_models.SaveTemplateHeaders()
        return await self.save_template_with_options_async(request, headers, runtime)

    def streaming_update_with_options(
        self,
        request: dingtalkcard__1__0_models.StreamingUpdateRequest,
        headers: dingtalkcard__1__0_models.StreamingUpdateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcard__1__0_models.StreamingUpdateResponse:
        """
        @summary AI互动卡片流式更新
        
        @param request: StreamingUpdateRequest
        @param headers: StreamingUpdateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: StreamingUpdateResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.guid):
            body['guid'] = request.guid
        if not UtilClient.is_unset(request.is_error):
            body['isError'] = request.is_error
        if not UtilClient.is_unset(request.is_finalize):
            body['isFinalize'] = request.is_finalize
        if not UtilClient.is_unset(request.is_full):
            body['isFull'] = request.is_full
        if not UtilClient.is_unset(request.key):
            body['key'] = request.key
        if not UtilClient.is_unset(request.out_track_id):
            body['outTrackId'] = request.out_track_id
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
            action='StreamingUpdate',
            version='card_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/card/streaming',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcard__1__0_models.StreamingUpdateResponse(),
            self.execute(params, req, runtime)
        )

    async def streaming_update_with_options_async(
        self,
        request: dingtalkcard__1__0_models.StreamingUpdateRequest,
        headers: dingtalkcard__1__0_models.StreamingUpdateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcard__1__0_models.StreamingUpdateResponse:
        """
        @summary AI互动卡片流式更新
        
        @param request: StreamingUpdateRequest
        @param headers: StreamingUpdateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: StreamingUpdateResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.guid):
            body['guid'] = request.guid
        if not UtilClient.is_unset(request.is_error):
            body['isError'] = request.is_error
        if not UtilClient.is_unset(request.is_finalize):
            body['isFinalize'] = request.is_finalize
        if not UtilClient.is_unset(request.is_full):
            body['isFull'] = request.is_full
        if not UtilClient.is_unset(request.key):
            body['key'] = request.key
        if not UtilClient.is_unset(request.out_track_id):
            body['outTrackId'] = request.out_track_id
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
            action='StreamingUpdate',
            version='card_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/card/streaming',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcard__1__0_models.StreamingUpdateResponse(),
            await self.execute_async(params, req, runtime)
        )

    def streaming_update(
        self,
        request: dingtalkcard__1__0_models.StreamingUpdateRequest,
    ) -> dingtalkcard__1__0_models.StreamingUpdateResponse:
        """
        @summary AI互动卡片流式更新
        
        @param request: StreamingUpdateRequest
        @return: StreamingUpdateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcard__1__0_models.StreamingUpdateHeaders()
        return self.streaming_update_with_options(request, headers, runtime)

    async def streaming_update_async(
        self,
        request: dingtalkcard__1__0_models.StreamingUpdateRequest,
    ) -> dingtalkcard__1__0_models.StreamingUpdateResponse:
        """
        @summary AI互动卡片流式更新
        
        @param request: StreamingUpdateRequest
        @return: StreamingUpdateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcard__1__0_models.StreamingUpdateHeaders()
        return await self.streaming_update_with_options_async(request, headers, runtime)

    def update_card_with_options(
        self,
        request: dingtalkcard__1__0_models.UpdateCardRequest,
        headers: dingtalkcard__1__0_models.UpdateCardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcard__1__0_models.UpdateCardResponse:
        """
        @summary 更新卡片
        
        @param request: UpdateCardRequest
        @param headers: UpdateCardHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateCardResponse
        """
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
        if not UtilClient.is_unset(request.user_id_type):
            body['userIdType'] = request.user_id_type
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
            action='UpdateCard',
            version='card_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/card/instances',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcard__1__0_models.UpdateCardResponse(),
            self.execute(params, req, runtime)
        )

    async def update_card_with_options_async(
        self,
        request: dingtalkcard__1__0_models.UpdateCardRequest,
        headers: dingtalkcard__1__0_models.UpdateCardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcard__1__0_models.UpdateCardResponse:
        """
        @summary 更新卡片
        
        @param request: UpdateCardRequest
        @param headers: UpdateCardHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateCardResponse
        """
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
        if not UtilClient.is_unset(request.user_id_type):
            body['userIdType'] = request.user_id_type
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
            action='UpdateCard',
            version='card_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/card/instances',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcard__1__0_models.UpdateCardResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_card(
        self,
        request: dingtalkcard__1__0_models.UpdateCardRequest,
    ) -> dingtalkcard__1__0_models.UpdateCardResponse:
        """
        @summary 更新卡片
        
        @param request: UpdateCardRequest
        @return: UpdateCardResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcard__1__0_models.UpdateCardHeaders()
        return self.update_card_with_options(request, headers, runtime)

    async def update_card_async(
        self,
        request: dingtalkcard__1__0_models.UpdateCardRequest,
    ) -> dingtalkcard__1__0_models.UpdateCardResponse:
        """
        @summary 更新卡片
        
        @param request: UpdateCardRequest
        @return: UpdateCardResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcard__1__0_models.UpdateCardHeaders()
        return await self.update_card_with_options_async(request, headers, runtime)

    def update_card_with_delegate_with_options(
        self,
        request: dingtalkcard__1__0_models.UpdateCardWithDelegateRequest,
        headers: dingtalkcard__1__0_models.UpdateCardWithDelegateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcard__1__0_models.UpdateCardWithDelegateResponse:
        """
        @summary 更新卡片
        
        @param request: UpdateCardWithDelegateRequest
        @param headers: UpdateCardWithDelegateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateCardWithDelegateResponse
        """
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
        if not UtilClient.is_unset(request.user_id_type):
            body['userIdType'] = request.user_id_type
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
            action='UpdateCardWithDelegate',
            version='card_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/card/me/instances',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcard__1__0_models.UpdateCardWithDelegateResponse(),
            self.execute(params, req, runtime)
        )

    async def update_card_with_delegate_with_options_async(
        self,
        request: dingtalkcard__1__0_models.UpdateCardWithDelegateRequest,
        headers: dingtalkcard__1__0_models.UpdateCardWithDelegateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcard__1__0_models.UpdateCardWithDelegateResponse:
        """
        @summary 更新卡片
        
        @param request: UpdateCardWithDelegateRequest
        @param headers: UpdateCardWithDelegateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateCardWithDelegateResponse
        """
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
        if not UtilClient.is_unset(request.user_id_type):
            body['userIdType'] = request.user_id_type
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
            action='UpdateCardWithDelegate',
            version='card_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/card/me/instances',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcard__1__0_models.UpdateCardWithDelegateResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_card_with_delegate(
        self,
        request: dingtalkcard__1__0_models.UpdateCardWithDelegateRequest,
    ) -> dingtalkcard__1__0_models.UpdateCardWithDelegateResponse:
        """
        @summary 更新卡片
        
        @param request: UpdateCardWithDelegateRequest
        @return: UpdateCardWithDelegateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcard__1__0_models.UpdateCardWithDelegateHeaders()
        return self.update_card_with_delegate_with_options(request, headers, runtime)

    async def update_card_with_delegate_async(
        self,
        request: dingtalkcard__1__0_models.UpdateCardWithDelegateRequest,
    ) -> dingtalkcard__1__0_models.UpdateCardWithDelegateResponse:
        """
        @summary 更新卡片
        
        @param request: UpdateCardWithDelegateRequest
        @return: UpdateCardWithDelegateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcard__1__0_models.UpdateCardWithDelegateHeaders()
        return await self.update_card_with_delegate_with_options_async(request, headers, runtime)
