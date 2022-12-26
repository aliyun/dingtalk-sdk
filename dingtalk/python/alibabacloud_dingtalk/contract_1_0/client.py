# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.contract_1_0 import models as dingtalkcontract__1__0_models
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

    def send_contract_card(
        self,
        request: dingtalkcontract__1__0_models.SendContractCardRequest,
    ) -> dingtalkcontract__1__0_models.SendContractCardResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontract__1__0_models.SendContractCardHeaders()
        return self.send_contract_card_with_options(request, headers, runtime)

    async def send_contract_card_async(
        self,
        request: dingtalkcontract__1__0_models.SendContractCardRequest,
    ) -> dingtalkcontract__1__0_models.SendContractCardResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontract__1__0_models.SendContractCardHeaders()
        return await self.send_contract_card_with_options_async(request, headers, runtime)

    def send_contract_card_with_options(
        self,
        request: dingtalkcontract__1__0_models.SendContractCardRequest,
        headers: dingtalkcontract__1__0_models.SendContractCardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontract__1__0_models.SendContractCardResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.card_type):
            body['cardType'] = request.card_type
        if not UtilClient.is_unset(request.contract_info):
            body['contractInfo'] = request.contract_info
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.extension):
            body['extension'] = request.extension
        if not UtilClient.is_unset(request.process_instance_id):
            body['processInstanceId'] = request.process_instance_id
        if not UtilClient.is_unset(request.receive_groups):
            body['receiveGroups'] = request.receive_groups
        if not UtilClient.is_unset(request.receivers):
            body['receivers'] = request.receivers
        if not UtilClient.is_unset(request.sender):
            body['sender'] = request.sender
        if not UtilClient.is_unset(request.sync_single_chat):
            body['syncSingleChat'] = request.sync_single_chat
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
            dingtalkcontract__1__0_models.SendContractCardResponse(),
            self.do_roarequest('SendContractCard', 'contract_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/contract/cards/send', 'json', req, runtime)
        )

    async def send_contract_card_with_options_async(
        self,
        request: dingtalkcontract__1__0_models.SendContractCardRequest,
        headers: dingtalkcontract__1__0_models.SendContractCardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontract__1__0_models.SendContractCardResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.card_type):
            body['cardType'] = request.card_type
        if not UtilClient.is_unset(request.contract_info):
            body['contractInfo'] = request.contract_info
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.extension):
            body['extension'] = request.extension
        if not UtilClient.is_unset(request.process_instance_id):
            body['processInstanceId'] = request.process_instance_id
        if not UtilClient.is_unset(request.receive_groups):
            body['receiveGroups'] = request.receive_groups
        if not UtilClient.is_unset(request.receivers):
            body['receivers'] = request.receivers
        if not UtilClient.is_unset(request.sender):
            body['sender'] = request.sender
        if not UtilClient.is_unset(request.sync_single_chat):
            body['syncSingleChat'] = request.sync_single_chat
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
            dingtalkcontract__1__0_models.SendContractCardResponse(),
            await self.do_roarequest_async('SendContractCard', 'contract_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/contract/cards/send', 'json', req, runtime)
        )
