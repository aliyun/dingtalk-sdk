# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
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
        gateway_client = GatewayClientClient()
        self._spi = gateway_client
        self._endpoint_rule = ''
        if UtilClient.empty(self._endpoint):
            self._endpoint = 'api.dingtalk.com'

    def contract_benefit_consume_with_options(
        self,
        request: dingtalkcontract__1__0_models.ContractBenefitConsumeRequest,
        headers: dingtalkcontract__1__0_models.ContractBenefitConsumeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontract__1__0_models.ContractBenefitConsumeResponse:
        """
        @summary 合同权益核销
        
        @param request: ContractBenefitConsumeRequest
        @param headers: ContractBenefitConsumeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ContractBenefitConsumeResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.benefit_point):
            body['benefitPoint'] = request.benefit_point
        if not UtilClient.is_unset(request.biz_request_id):
            body['bizRequestId'] = request.biz_request_id
        if not UtilClient.is_unset(request.consume_quota):
            body['consumeQuota'] = request.consume_quota
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.ext_params):
            body['extParams'] = request.ext_params
        if not UtilClient.is_unset(request.isv_corp_id):
            body['isvCorpId'] = request.isv_corp_id
        if not UtilClient.is_unset(request.opt_union_id):
            body['optUnionId'] = request.opt_union_id
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
            action='ContractBenefitConsume',
            version='contract_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contract/benefits/consume',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontract__1__0_models.ContractBenefitConsumeResponse(),
            self.execute(params, req, runtime)
        )

    async def contract_benefit_consume_with_options_async(
        self,
        request: dingtalkcontract__1__0_models.ContractBenefitConsumeRequest,
        headers: dingtalkcontract__1__0_models.ContractBenefitConsumeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontract__1__0_models.ContractBenefitConsumeResponse:
        """
        @summary 合同权益核销
        
        @param request: ContractBenefitConsumeRequest
        @param headers: ContractBenefitConsumeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ContractBenefitConsumeResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.benefit_point):
            body['benefitPoint'] = request.benefit_point
        if not UtilClient.is_unset(request.biz_request_id):
            body['bizRequestId'] = request.biz_request_id
        if not UtilClient.is_unset(request.consume_quota):
            body['consumeQuota'] = request.consume_quota
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.ext_params):
            body['extParams'] = request.ext_params
        if not UtilClient.is_unset(request.isv_corp_id):
            body['isvCorpId'] = request.isv_corp_id
        if not UtilClient.is_unset(request.opt_union_id):
            body['optUnionId'] = request.opt_union_id
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
            action='ContractBenefitConsume',
            version='contract_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contract/benefits/consume',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontract__1__0_models.ContractBenefitConsumeResponse(),
            await self.execute_async(params, req, runtime)
        )

    def contract_benefit_consume(
        self,
        request: dingtalkcontract__1__0_models.ContractBenefitConsumeRequest,
    ) -> dingtalkcontract__1__0_models.ContractBenefitConsumeResponse:
        """
        @summary 合同权益核销
        
        @param request: ContractBenefitConsumeRequest
        @return: ContractBenefitConsumeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontract__1__0_models.ContractBenefitConsumeHeaders()
        return self.contract_benefit_consume_with_options(request, headers, runtime)

    async def contract_benefit_consume_async(
        self,
        request: dingtalkcontract__1__0_models.ContractBenefitConsumeRequest,
    ) -> dingtalkcontract__1__0_models.ContractBenefitConsumeResponse:
        """
        @summary 合同权益核销
        
        @param request: ContractBenefitConsumeRequest
        @return: ContractBenefitConsumeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontract__1__0_models.ContractBenefitConsumeHeaders()
        return await self.contract_benefit_consume_with_options_async(request, headers, runtime)

    def esign_query_approval_info_with_options(
        self,
        request: dingtalkcontract__1__0_models.EsignQueryApprovalInfoRequest,
        headers: dingtalkcontract__1__0_models.EsignQueryApprovalInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontract__1__0_models.EsignQueryApprovalInfoResponse:
        """
        @summary 天谷侧查询审批单
        
        @param request: EsignQueryApprovalInfoRequest
        @param headers: EsignQueryApprovalInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: EsignQueryApprovalInfoResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.esign_flow_id):
            body['esignFlowId'] = request.esign_flow_id
        if not UtilClient.is_unset(request.union_id):
            body['unionId'] = request.union_id
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
            action='EsignQueryApprovalInfo',
            version='contract_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contract/esign/approvalInfos/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontract__1__0_models.EsignQueryApprovalInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def esign_query_approval_info_with_options_async(
        self,
        request: dingtalkcontract__1__0_models.EsignQueryApprovalInfoRequest,
        headers: dingtalkcontract__1__0_models.EsignQueryApprovalInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontract__1__0_models.EsignQueryApprovalInfoResponse:
        """
        @summary 天谷侧查询审批单
        
        @param request: EsignQueryApprovalInfoRequest
        @param headers: EsignQueryApprovalInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: EsignQueryApprovalInfoResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.esign_flow_id):
            body['esignFlowId'] = request.esign_flow_id
        if not UtilClient.is_unset(request.union_id):
            body['unionId'] = request.union_id
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
            action='EsignQueryApprovalInfo',
            version='contract_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contract/esign/approvalInfos/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontract__1__0_models.EsignQueryApprovalInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def esign_query_approval_info(
        self,
        request: dingtalkcontract__1__0_models.EsignQueryApprovalInfoRequest,
    ) -> dingtalkcontract__1__0_models.EsignQueryApprovalInfoResponse:
        """
        @summary 天谷侧查询审批单
        
        @param request: EsignQueryApprovalInfoRequest
        @return: EsignQueryApprovalInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontract__1__0_models.EsignQueryApprovalInfoHeaders()
        return self.esign_query_approval_info_with_options(request, headers, runtime)

    async def esign_query_approval_info_async(
        self,
        request: dingtalkcontract__1__0_models.EsignQueryApprovalInfoRequest,
    ) -> dingtalkcontract__1__0_models.EsignQueryApprovalInfoResponse:
        """
        @summary 天谷侧查询审批单
        
        @param request: EsignQueryApprovalInfoRequest
        @return: EsignQueryApprovalInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontract__1__0_models.EsignQueryApprovalInfoHeaders()
        return await self.esign_query_approval_info_with_options_async(request, headers, runtime)

    def esign_query_grant_info_with_options(
        self,
        request: dingtalkcontract__1__0_models.EsignQueryGrantInfoRequest,
        headers: dingtalkcontract__1__0_models.EsignQueryGrantInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontract__1__0_models.EsignQueryGrantInfoResponse:
        """
        @summary 天谷侧查询授权信息接口
        
        @param request: EsignQueryGrantInfoRequest
        @param headers: EsignQueryGrantInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: EsignQueryGrantInfoResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.extension):
            body['extension'] = request.extension
        if not UtilClient.is_unset(request.union_id):
            body['unionId'] = request.union_id
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
            action='EsignQueryGrantInfo',
            version='contract_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contract/esign/anthInfos/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontract__1__0_models.EsignQueryGrantInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def esign_query_grant_info_with_options_async(
        self,
        request: dingtalkcontract__1__0_models.EsignQueryGrantInfoRequest,
        headers: dingtalkcontract__1__0_models.EsignQueryGrantInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontract__1__0_models.EsignQueryGrantInfoResponse:
        """
        @summary 天谷侧查询授权信息接口
        
        @param request: EsignQueryGrantInfoRequest
        @param headers: EsignQueryGrantInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: EsignQueryGrantInfoResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.extension):
            body['extension'] = request.extension
        if not UtilClient.is_unset(request.union_id):
            body['unionId'] = request.union_id
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
            action='EsignQueryGrantInfo',
            version='contract_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contract/esign/anthInfos/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontract__1__0_models.EsignQueryGrantInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def esign_query_grant_info(
        self,
        request: dingtalkcontract__1__0_models.EsignQueryGrantInfoRequest,
    ) -> dingtalkcontract__1__0_models.EsignQueryGrantInfoResponse:
        """
        @summary 天谷侧查询授权信息接口
        
        @param request: EsignQueryGrantInfoRequest
        @return: EsignQueryGrantInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontract__1__0_models.EsignQueryGrantInfoHeaders()
        return self.esign_query_grant_info_with_options(request, headers, runtime)

    async def esign_query_grant_info_async(
        self,
        request: dingtalkcontract__1__0_models.EsignQueryGrantInfoRequest,
    ) -> dingtalkcontract__1__0_models.EsignQueryGrantInfoResponse:
        """
        @summary 天谷侧查询授权信息接口
        
        @param request: EsignQueryGrantInfoRequest
        @return: EsignQueryGrantInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontract__1__0_models.EsignQueryGrantInfoHeaders()
        return await self.esign_query_grant_info_with_options_async(request, headers, runtime)

    def esign_query_identity_by_ticket_with_options(
        self,
        request: dingtalkcontract__1__0_models.EsignQueryIdentityByTicketRequest,
        headers: dingtalkcontract__1__0_models.EsignQueryIdentityByTicketHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontract__1__0_models.EsignQueryIdentityByTicketResponse:
        """
        @summary 天谷侧查询获取免登信息
        
        @param request: EsignQueryIdentityByTicketRequest
        @param headers: EsignQueryIdentityByTicketHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: EsignQueryIdentityByTicketResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.extension):
            body['extension'] = request.extension
        if not UtilClient.is_unset(request.ticket):
            body['ticket'] = request.ticket
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
            action='EsignQueryIdentityByTicket',
            version='contract_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contract/esign/tickets/identities/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontract__1__0_models.EsignQueryIdentityByTicketResponse(),
            self.execute(params, req, runtime)
        )

    async def esign_query_identity_by_ticket_with_options_async(
        self,
        request: dingtalkcontract__1__0_models.EsignQueryIdentityByTicketRequest,
        headers: dingtalkcontract__1__0_models.EsignQueryIdentityByTicketHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontract__1__0_models.EsignQueryIdentityByTicketResponse:
        """
        @summary 天谷侧查询获取免登信息
        
        @param request: EsignQueryIdentityByTicketRequest
        @param headers: EsignQueryIdentityByTicketHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: EsignQueryIdentityByTicketResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.extension):
            body['extension'] = request.extension
        if not UtilClient.is_unset(request.ticket):
            body['ticket'] = request.ticket
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
            action='EsignQueryIdentityByTicket',
            version='contract_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contract/esign/tickets/identities/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontract__1__0_models.EsignQueryIdentityByTicketResponse(),
            await self.execute_async(params, req, runtime)
        )

    def esign_query_identity_by_ticket(
        self,
        request: dingtalkcontract__1__0_models.EsignQueryIdentityByTicketRequest,
    ) -> dingtalkcontract__1__0_models.EsignQueryIdentityByTicketResponse:
        """
        @summary 天谷侧查询获取免登信息
        
        @param request: EsignQueryIdentityByTicketRequest
        @return: EsignQueryIdentityByTicketResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontract__1__0_models.EsignQueryIdentityByTicketHeaders()
        return self.esign_query_identity_by_ticket_with_options(request, headers, runtime)

    async def esign_query_identity_by_ticket_async(
        self,
        request: dingtalkcontract__1__0_models.EsignQueryIdentityByTicketRequest,
    ) -> dingtalkcontract__1__0_models.EsignQueryIdentityByTicketResponse:
        """
        @summary 天谷侧查询获取免登信息
        
        @param request: EsignQueryIdentityByTicketRequest
        @return: EsignQueryIdentityByTicketResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontract__1__0_models.EsignQueryIdentityByTicketHeaders()
        return await self.esign_query_identity_by_ticket_with_options_async(request, headers, runtime)

    def esign_sync_event_with_options(
        self,
        request: dingtalkcontract__1__0_models.EsignSyncEventRequest,
        headers: dingtalkcontract__1__0_models.EsignSyncEventHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontract__1__0_models.EsignSyncEventResponse:
        """
        @summary e签宝电子签事件同步回传接口
        
        @param request: EsignSyncEventRequest
        @param headers: EsignSyncEventHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: EsignSyncEventResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action):
            body['action'] = request.action
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.esign_data):
            body['esignData'] = request.esign_data
        if not UtilClient.is_unset(request.extension):
            body['extension'] = request.extension
        if not UtilClient.is_unset(request.union_id):
            body['unionId'] = request.union_id
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
            action='EsignSyncEvent',
            version='contract_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contract/esign/events/sync',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontract__1__0_models.EsignSyncEventResponse(),
            self.execute(params, req, runtime)
        )

    async def esign_sync_event_with_options_async(
        self,
        request: dingtalkcontract__1__0_models.EsignSyncEventRequest,
        headers: dingtalkcontract__1__0_models.EsignSyncEventHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontract__1__0_models.EsignSyncEventResponse:
        """
        @summary e签宝电子签事件同步回传接口
        
        @param request: EsignSyncEventRequest
        @param headers: EsignSyncEventHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: EsignSyncEventResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action):
            body['action'] = request.action
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.esign_data):
            body['esignData'] = request.esign_data
        if not UtilClient.is_unset(request.extension):
            body['extension'] = request.extension
        if not UtilClient.is_unset(request.union_id):
            body['unionId'] = request.union_id
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
            action='EsignSyncEvent',
            version='contract_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contract/esign/events/sync',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontract__1__0_models.EsignSyncEventResponse(),
            await self.execute_async(params, req, runtime)
        )

    def esign_sync_event(
        self,
        request: dingtalkcontract__1__0_models.EsignSyncEventRequest,
    ) -> dingtalkcontract__1__0_models.EsignSyncEventResponse:
        """
        @summary e签宝电子签事件同步回传接口
        
        @param request: EsignSyncEventRequest
        @return: EsignSyncEventResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontract__1__0_models.EsignSyncEventHeaders()
        return self.esign_sync_event_with_options(request, headers, runtime)

    async def esign_sync_event_async(
        self,
        request: dingtalkcontract__1__0_models.EsignSyncEventRequest,
    ) -> dingtalkcontract__1__0_models.EsignSyncEventResponse:
        """
        @summary e签宝电子签事件同步回传接口
        
        @param request: EsignSyncEventRequest
        @return: EsignSyncEventResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontract__1__0_models.EsignSyncEventHeaders()
        return await self.esign_sync_event_with_options_async(request, headers, runtime)

    def esign_user_verify_with_options(
        self,
        request: dingtalkcontract__1__0_models.EsignUserVerifyRequest,
        headers: dingtalkcontract__1__0_models.EsignUserVerifyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontract__1__0_models.EsignUserVerifyResponse:
        """
        @summary 校验钉钉用户能否访问e签宝页面接口
        
        @param request: EsignUserVerifyRequest
        @param headers: EsignUserVerifyHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: EsignUserVerifyResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.union_id):
            body['unionId'] = request.union_id
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
            action='EsignUserVerify',
            version='contract_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contract/esign/user/verify',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontract__1__0_models.EsignUserVerifyResponse(),
            self.execute(params, req, runtime)
        )

    async def esign_user_verify_with_options_async(
        self,
        request: dingtalkcontract__1__0_models.EsignUserVerifyRequest,
        headers: dingtalkcontract__1__0_models.EsignUserVerifyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontract__1__0_models.EsignUserVerifyResponse:
        """
        @summary 校验钉钉用户能否访问e签宝页面接口
        
        @param request: EsignUserVerifyRequest
        @param headers: EsignUserVerifyHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: EsignUserVerifyResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.union_id):
            body['unionId'] = request.union_id
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
            action='EsignUserVerify',
            version='contract_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contract/esign/user/verify',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontract__1__0_models.EsignUserVerifyResponse(),
            await self.execute_async(params, req, runtime)
        )

    def esign_user_verify(
        self,
        request: dingtalkcontract__1__0_models.EsignUserVerifyRequest,
    ) -> dingtalkcontract__1__0_models.EsignUserVerifyResponse:
        """
        @summary 校验钉钉用户能否访问e签宝页面接口
        
        @param request: EsignUserVerifyRequest
        @return: EsignUserVerifyResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontract__1__0_models.EsignUserVerifyHeaders()
        return self.esign_user_verify_with_options(request, headers, runtime)

    async def esign_user_verify_async(
        self,
        request: dingtalkcontract__1__0_models.EsignUserVerifyRequest,
    ) -> dingtalkcontract__1__0_models.EsignUserVerifyResponse:
        """
        @summary 校验钉钉用户能否访问e签宝页面接口
        
        @param request: EsignUserVerifyRequest
        @return: EsignUserVerifyResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontract__1__0_models.EsignUserVerifyHeaders()
        return await self.esign_user_verify_with_options_async(request, headers, runtime)

    def finish_review_order_with_options(
        self,
        request: dingtalkcontract__1__0_models.FinishReviewOrderRequest,
        headers: dingtalkcontract__1__0_models.FinishReviewOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontract__1__0_models.FinishReviewOrderResponse:
        """
        @summary 完成工单审查接口
        
        @param request: FinishReviewOrderRequest
        @param headers: FinishReviewOrderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: FinishReviewOrderResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.end_files):
            body['endFiles'] = request.end_files
        if not UtilClient.is_unset(request.extension):
            body['extension'] = request.extension
        if not UtilClient.is_unset(request.order_id):
            body['orderId'] = request.order_id
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
            action='FinishReviewOrder',
            version='contract_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contract/reviews/finish',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontract__1__0_models.FinishReviewOrderResponse(),
            self.execute(params, req, runtime)
        )

    async def finish_review_order_with_options_async(
        self,
        request: dingtalkcontract__1__0_models.FinishReviewOrderRequest,
        headers: dingtalkcontract__1__0_models.FinishReviewOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontract__1__0_models.FinishReviewOrderResponse:
        """
        @summary 完成工单审查接口
        
        @param request: FinishReviewOrderRequest
        @param headers: FinishReviewOrderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: FinishReviewOrderResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.end_files):
            body['endFiles'] = request.end_files
        if not UtilClient.is_unset(request.extension):
            body['extension'] = request.extension
        if not UtilClient.is_unset(request.order_id):
            body['orderId'] = request.order_id
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
            action='FinishReviewOrder',
            version='contract_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contract/reviews/finish',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontract__1__0_models.FinishReviewOrderResponse(),
            await self.execute_async(params, req, runtime)
        )

    def finish_review_order(
        self,
        request: dingtalkcontract__1__0_models.FinishReviewOrderRequest,
    ) -> dingtalkcontract__1__0_models.FinishReviewOrderResponse:
        """
        @summary 完成工单审查接口
        
        @param request: FinishReviewOrderRequest
        @return: FinishReviewOrderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontract__1__0_models.FinishReviewOrderHeaders()
        return self.finish_review_order_with_options(request, headers, runtime)

    async def finish_review_order_async(
        self,
        request: dingtalkcontract__1__0_models.FinishReviewOrderRequest,
    ) -> dingtalkcontract__1__0_models.FinishReviewOrderResponse:
        """
        @summary 完成工单审查接口
        
        @param request: FinishReviewOrderRequest
        @return: FinishReviewOrderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontract__1__0_models.FinishReviewOrderHeaders()
        return await self.finish_review_order_with_options_async(request, headers, runtime)

    def query_advanced_contract_version_with_options(
        self,
        request: dingtalkcontract__1__0_models.QueryAdvancedContractVersionRequest,
        headers: dingtalkcontract__1__0_models.QueryAdvancedContractVersionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontract__1__0_models.QueryAdvancedContractVersionResponse:
        """
        @summary e签宝查询智能合同版本接口
        
        @param request: QueryAdvancedContractVersionRequest
        @param headers: QueryAdvancedContractVersionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryAdvancedContractVersionResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.extension):
            body['extension'] = request.extension
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
            action='QueryAdvancedContractVersion',
            version='contract_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contract/versions/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontract__1__0_models.QueryAdvancedContractVersionResponse(),
            self.execute(params, req, runtime)
        )

    async def query_advanced_contract_version_with_options_async(
        self,
        request: dingtalkcontract__1__0_models.QueryAdvancedContractVersionRequest,
        headers: dingtalkcontract__1__0_models.QueryAdvancedContractVersionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontract__1__0_models.QueryAdvancedContractVersionResponse:
        """
        @summary e签宝查询智能合同版本接口
        
        @param request: QueryAdvancedContractVersionRequest
        @param headers: QueryAdvancedContractVersionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryAdvancedContractVersionResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.extension):
            body['extension'] = request.extension
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
            action='QueryAdvancedContractVersion',
            version='contract_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contract/versions/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontract__1__0_models.QueryAdvancedContractVersionResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_advanced_contract_version(
        self,
        request: dingtalkcontract__1__0_models.QueryAdvancedContractVersionRequest,
    ) -> dingtalkcontract__1__0_models.QueryAdvancedContractVersionResponse:
        """
        @summary e签宝查询智能合同版本接口
        
        @param request: QueryAdvancedContractVersionRequest
        @return: QueryAdvancedContractVersionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontract__1__0_models.QueryAdvancedContractVersionHeaders()
        return self.query_advanced_contract_version_with_options(request, headers, runtime)

    async def query_advanced_contract_version_async(
        self,
        request: dingtalkcontract__1__0_models.QueryAdvancedContractVersionRequest,
    ) -> dingtalkcontract__1__0_models.QueryAdvancedContractVersionResponse:
        """
        @summary e签宝查询智能合同版本接口
        
        @param request: QueryAdvancedContractVersionRequest
        @return: QueryAdvancedContractVersionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontract__1__0_models.QueryAdvancedContractVersionHeaders()
        return await self.query_advanced_contract_version_with_options_async(request, headers, runtime)

    def send_contract_card_with_options(
        self,
        request: dingtalkcontract__1__0_models.SendContractCardRequest,
        headers: dingtalkcontract__1__0_models.SendContractCardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontract__1__0_models.SendContractCardResponse:
        """
        @summary 发送合同相关卡片
        
        @param request: SendContractCardRequest
        @param headers: SendContractCardHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SendContractCardResponse
        """
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
        params = open_api_models.Params(
            action='SendContractCard',
            version='contract_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contract/cards/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontract__1__0_models.SendContractCardResponse(),
            self.execute(params, req, runtime)
        )

    async def send_contract_card_with_options_async(
        self,
        request: dingtalkcontract__1__0_models.SendContractCardRequest,
        headers: dingtalkcontract__1__0_models.SendContractCardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontract__1__0_models.SendContractCardResponse:
        """
        @summary 发送合同相关卡片
        
        @param request: SendContractCardRequest
        @param headers: SendContractCardHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SendContractCardResponse
        """
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
        params = open_api_models.Params(
            action='SendContractCard',
            version='contract_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contract/cards/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontract__1__0_models.SendContractCardResponse(),
            await self.execute_async(params, req, runtime)
        )

    def send_contract_card(
        self,
        request: dingtalkcontract__1__0_models.SendContractCardRequest,
    ) -> dingtalkcontract__1__0_models.SendContractCardResponse:
        """
        @summary 发送合同相关卡片
        
        @param request: SendContractCardRequest
        @return: SendContractCardResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontract__1__0_models.SendContractCardHeaders()
        return self.send_contract_card_with_options(request, headers, runtime)

    async def send_contract_card_async(
        self,
        request: dingtalkcontract__1__0_models.SendContractCardRequest,
    ) -> dingtalkcontract__1__0_models.SendContractCardResponse:
        """
        @summary 发送合同相关卡片
        
        @param request: SendContractCardRequest
        @return: SendContractCardResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontract__1__0_models.SendContractCardHeaders()
        return await self.send_contract_card_with_options_async(request, headers, runtime)
