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

    def cancel_review_order_with_options(
        self,
        request: dingtalkcontract__1__0_models.CancelReviewOrderRequest,
        headers: dingtalkcontract__1__0_models.CancelReviewOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontract__1__0_models.CancelReviewOrderResponse:
        """
        @summary 取消审查工单接口
        
        @param request: CancelReviewOrderRequest
        @param headers: CancelReviewOrderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CancelReviewOrderResponse
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
            action='CancelReviewOrder',
            version='contract_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contract/reviews/cancel',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontract__1__0_models.CancelReviewOrderResponse(),
            self.execute(params, req, runtime)
        )

    async def cancel_review_order_with_options_async(
        self,
        request: dingtalkcontract__1__0_models.CancelReviewOrderRequest,
        headers: dingtalkcontract__1__0_models.CancelReviewOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontract__1__0_models.CancelReviewOrderResponse:
        """
        @summary 取消审查工单接口
        
        @param request: CancelReviewOrderRequest
        @param headers: CancelReviewOrderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CancelReviewOrderResponse
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
            action='CancelReviewOrder',
            version='contract_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contract/reviews/cancel',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontract__1__0_models.CancelReviewOrderResponse(),
            await self.execute_async(params, req, runtime)
        )

    def cancel_review_order(
        self,
        request: dingtalkcontract__1__0_models.CancelReviewOrderRequest,
    ) -> dingtalkcontract__1__0_models.CancelReviewOrderResponse:
        """
        @summary 取消审查工单接口
        
        @param request: CancelReviewOrderRequest
        @return: CancelReviewOrderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontract__1__0_models.CancelReviewOrderHeaders()
        return self.cancel_review_order_with_options(request, headers, runtime)

    async def cancel_review_order_async(
        self,
        request: dingtalkcontract__1__0_models.CancelReviewOrderRequest,
    ) -> dingtalkcontract__1__0_models.CancelReviewOrderResponse:
        """
        @summary 取消审查工单接口
        
        @param request: CancelReviewOrderRequest
        @return: CancelReviewOrderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontract__1__0_models.CancelReviewOrderHeaders()
        return await self.cancel_review_order_with_options_async(request, headers, runtime)

    def check_esign_file_with_options(
        self,
        request: dingtalkcontract__1__0_models.CheckEsignFileRequest,
        headers: dingtalkcontract__1__0_models.CheckEsignFileHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontract__1__0_models.CheckEsignFileResponse:
        """
        @summary 查询esign文件是否正常
        
        @param request: CheckEsignFileRequest
        @param headers: CheckEsignFileHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CheckEsignFileResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.file_id):
            body['fileId'] = request.file_id
        if not UtilClient.is_unset(request.space_id):
            body['spaceId'] = request.space_id
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
            action='CheckEsignFile',
            version='contract_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contract/esignFiles/check',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontract__1__0_models.CheckEsignFileResponse(),
            self.execute(params, req, runtime)
        )

    async def check_esign_file_with_options_async(
        self,
        request: dingtalkcontract__1__0_models.CheckEsignFileRequest,
        headers: dingtalkcontract__1__0_models.CheckEsignFileHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontract__1__0_models.CheckEsignFileResponse:
        """
        @summary 查询esign文件是否正常
        
        @param request: CheckEsignFileRequest
        @param headers: CheckEsignFileHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CheckEsignFileResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.file_id):
            body['fileId'] = request.file_id
        if not UtilClient.is_unset(request.space_id):
            body['spaceId'] = request.space_id
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
            action='CheckEsignFile',
            version='contract_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contract/esignFiles/check',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontract__1__0_models.CheckEsignFileResponse(),
            await self.execute_async(params, req, runtime)
        )

    def check_esign_file(
        self,
        request: dingtalkcontract__1__0_models.CheckEsignFileRequest,
    ) -> dingtalkcontract__1__0_models.CheckEsignFileResponse:
        """
        @summary 查询esign文件是否正常
        
        @param request: CheckEsignFileRequest
        @return: CheckEsignFileResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontract__1__0_models.CheckEsignFileHeaders()
        return self.check_esign_file_with_options(request, headers, runtime)

    async def check_esign_file_async(
        self,
        request: dingtalkcontract__1__0_models.CheckEsignFileRequest,
    ) -> dingtalkcontract__1__0_models.CheckEsignFileResponse:
        """
        @summary 查询esign文件是否正常
        
        @param request: CheckEsignFileRequest
        @return: CheckEsignFileResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontract__1__0_models.CheckEsignFileHeaders()
        return await self.check_esign_file_with_options_async(request, headers, runtime)

    def contract_ai_review_result_notify_with_options(
        self,
        request: dingtalkcontract__1__0_models.ContractAiReviewResultNotifyRequest,
        headers: dingtalkcontract__1__0_models.ContractAiReviewResultNotifyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontract__1__0_models.ContractAiReviewResultNotifyResponse:
        """
        @summary ai合同审查结果回调
        
        @param request: ContractAiReviewResultNotifyRequest
        @param headers: ContractAiReviewResultNotifyHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ContractAiReviewResultNotifyResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.annotations):
            body['annotations'] = request.annotations
        if not UtilClient.is_unset(request.contract_ai_review_corp_id):
            body['contractAiReviewCorpId'] = request.contract_ai_review_corp_id
        if not UtilClient.is_unset(request.contract_ai_review_id):
            body['contractAiReviewId'] = request.contract_ai_review_id
        if not UtilClient.is_unset(request.error_code):
            body['errorCode'] = request.error_code
        if not UtilClient.is_unset(request.error_msg):
            body['errorMsg'] = request.error_msg
        if not UtilClient.is_unset(request.extension):
            body['extension'] = request.extension
        if not UtilClient.is_unset(request.success):
            body['success'] = request.success
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
            action='ContractAiReviewResultNotify',
            version='contract_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contract/aiReviews/results/notify',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontract__1__0_models.ContractAiReviewResultNotifyResponse(),
            self.execute(params, req, runtime)
        )

    async def contract_ai_review_result_notify_with_options_async(
        self,
        request: dingtalkcontract__1__0_models.ContractAiReviewResultNotifyRequest,
        headers: dingtalkcontract__1__0_models.ContractAiReviewResultNotifyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontract__1__0_models.ContractAiReviewResultNotifyResponse:
        """
        @summary ai合同审查结果回调
        
        @param request: ContractAiReviewResultNotifyRequest
        @param headers: ContractAiReviewResultNotifyHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ContractAiReviewResultNotifyResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.annotations):
            body['annotations'] = request.annotations
        if not UtilClient.is_unset(request.contract_ai_review_corp_id):
            body['contractAiReviewCorpId'] = request.contract_ai_review_corp_id
        if not UtilClient.is_unset(request.contract_ai_review_id):
            body['contractAiReviewId'] = request.contract_ai_review_id
        if not UtilClient.is_unset(request.error_code):
            body['errorCode'] = request.error_code
        if not UtilClient.is_unset(request.error_msg):
            body['errorMsg'] = request.error_msg
        if not UtilClient.is_unset(request.extension):
            body['extension'] = request.extension
        if not UtilClient.is_unset(request.success):
            body['success'] = request.success
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
            action='ContractAiReviewResultNotify',
            version='contract_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contract/aiReviews/results/notify',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontract__1__0_models.ContractAiReviewResultNotifyResponse(),
            await self.execute_async(params, req, runtime)
        )

    def contract_ai_review_result_notify(
        self,
        request: dingtalkcontract__1__0_models.ContractAiReviewResultNotifyRequest,
    ) -> dingtalkcontract__1__0_models.ContractAiReviewResultNotifyResponse:
        """
        @summary ai合同审查结果回调
        
        @param request: ContractAiReviewResultNotifyRequest
        @return: ContractAiReviewResultNotifyResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontract__1__0_models.ContractAiReviewResultNotifyHeaders()
        return self.contract_ai_review_result_notify_with_options(request, headers, runtime)

    async def contract_ai_review_result_notify_async(
        self,
        request: dingtalkcontract__1__0_models.ContractAiReviewResultNotifyRequest,
    ) -> dingtalkcontract__1__0_models.ContractAiReviewResultNotifyResponse:
        """
        @summary ai合同审查结果回调
        
        @param request: ContractAiReviewResultNotifyRequest
        @return: ContractAiReviewResultNotifyResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontract__1__0_models.ContractAiReviewResultNotifyHeaders()
        return await self.contract_ai_review_result_notify_with_options_async(request, headers, runtime)

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

    def create_contract_apps_compare_task_with_options(
        self,
        request: dingtalkcontract__1__0_models.CreateContractAppsCompareTaskRequest,
        headers: dingtalkcontract__1__0_models.CreateContractAppsCompareTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontract__1__0_models.CreateContractAppsCompareTaskResponse:
        """
        @summary 创建合同比对任务
        
        @param request: CreateContractAppsCompareTaskRequest
        @param headers: CreateContractAppsCompareTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateContractAppsCompareTaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.comparative_file):
            body['comparativeFile'] = request.comparative_file
        if not UtilClient.is_unset(request.comparative_file_download_url):
            body['comparativeFileDownloadUrl'] = request.comparative_file_download_url
        if not UtilClient.is_unset(request.comparative_file_name):
            body['comparativeFileName'] = request.comparative_file_name
        if not UtilClient.is_unset(request.file_source):
            body['fileSource'] = request.file_source
        if not UtilClient.is_unset(request.request_id):
            body['requestId'] = request.request_id
        if not UtilClient.is_unset(request.standard_file):
            body['standardFile'] = request.standard_file
        if not UtilClient.is_unset(request.standard_file_download_url):
            body['standardFileDownloadUrl'] = request.standard_file_download_url
        if not UtilClient.is_unset(request.standard_file_name):
            body['standardFileName'] = request.standard_file_name
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
            action='CreateContractAppsCompareTask',
            version='contract_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contract/apps/comparisonTasks',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontract__1__0_models.CreateContractAppsCompareTaskResponse(),
            self.execute(params, req, runtime)
        )

    async def create_contract_apps_compare_task_with_options_async(
        self,
        request: dingtalkcontract__1__0_models.CreateContractAppsCompareTaskRequest,
        headers: dingtalkcontract__1__0_models.CreateContractAppsCompareTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontract__1__0_models.CreateContractAppsCompareTaskResponse:
        """
        @summary 创建合同比对任务
        
        @param request: CreateContractAppsCompareTaskRequest
        @param headers: CreateContractAppsCompareTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateContractAppsCompareTaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.comparative_file):
            body['comparativeFile'] = request.comparative_file
        if not UtilClient.is_unset(request.comparative_file_download_url):
            body['comparativeFileDownloadUrl'] = request.comparative_file_download_url
        if not UtilClient.is_unset(request.comparative_file_name):
            body['comparativeFileName'] = request.comparative_file_name
        if not UtilClient.is_unset(request.file_source):
            body['fileSource'] = request.file_source
        if not UtilClient.is_unset(request.request_id):
            body['requestId'] = request.request_id
        if not UtilClient.is_unset(request.standard_file):
            body['standardFile'] = request.standard_file
        if not UtilClient.is_unset(request.standard_file_download_url):
            body['standardFileDownloadUrl'] = request.standard_file_download_url
        if not UtilClient.is_unset(request.standard_file_name):
            body['standardFileName'] = request.standard_file_name
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
            action='CreateContractAppsCompareTask',
            version='contract_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contract/apps/comparisonTasks',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontract__1__0_models.CreateContractAppsCompareTaskResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_contract_apps_compare_task(
        self,
        request: dingtalkcontract__1__0_models.CreateContractAppsCompareTaskRequest,
    ) -> dingtalkcontract__1__0_models.CreateContractAppsCompareTaskResponse:
        """
        @summary 创建合同比对任务
        
        @param request: CreateContractAppsCompareTaskRequest
        @return: CreateContractAppsCompareTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontract__1__0_models.CreateContractAppsCompareTaskHeaders()
        return self.create_contract_apps_compare_task_with_options(request, headers, runtime)

    async def create_contract_apps_compare_task_async(
        self,
        request: dingtalkcontract__1__0_models.CreateContractAppsCompareTaskRequest,
    ) -> dingtalkcontract__1__0_models.CreateContractAppsCompareTaskResponse:
        """
        @summary 创建合同比对任务
        
        @param request: CreateContractAppsCompareTaskRequest
        @return: CreateContractAppsCompareTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontract__1__0_models.CreateContractAppsCompareTaskHeaders()
        return await self.create_contract_apps_compare_task_with_options_async(request, headers, runtime)

    def create_contract_apps_extract_task_with_options(
        self,
        request: dingtalkcontract__1__0_models.CreateContractAppsExtractTaskRequest,
        headers: dingtalkcontract__1__0_models.CreateContractAppsExtractTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontract__1__0_models.CreateContractAppsExtractTaskResponse:
        """
        @summary 创建合同提取任务
        
        @param request: CreateContractAppsExtractTaskRequest
        @param headers: CreateContractAppsExtractTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateContractAppsExtractTaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.contract_file):
            body['contractFile'] = request.contract_file
        if not UtilClient.is_unset(request.contract_file_download_url):
            body['contractFileDownloadUrl'] = request.contract_file_download_url
        if not UtilClient.is_unset(request.contract_file_name):
            body['contractFileName'] = request.contract_file_name
        if not UtilClient.is_unset(request.extract_keys):
            body['extractKeys'] = request.extract_keys
        if not UtilClient.is_unset(request.file_source):
            body['fileSource'] = request.file_source
        if not UtilClient.is_unset(request.request_id):
            body['requestId'] = request.request_id
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
            action='CreateContractAppsExtractTask',
            version='contract_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contract/apps/extractTasks',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontract__1__0_models.CreateContractAppsExtractTaskResponse(),
            self.execute(params, req, runtime)
        )

    async def create_contract_apps_extract_task_with_options_async(
        self,
        request: dingtalkcontract__1__0_models.CreateContractAppsExtractTaskRequest,
        headers: dingtalkcontract__1__0_models.CreateContractAppsExtractTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontract__1__0_models.CreateContractAppsExtractTaskResponse:
        """
        @summary 创建合同提取任务
        
        @param request: CreateContractAppsExtractTaskRequest
        @param headers: CreateContractAppsExtractTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateContractAppsExtractTaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.contract_file):
            body['contractFile'] = request.contract_file
        if not UtilClient.is_unset(request.contract_file_download_url):
            body['contractFileDownloadUrl'] = request.contract_file_download_url
        if not UtilClient.is_unset(request.contract_file_name):
            body['contractFileName'] = request.contract_file_name
        if not UtilClient.is_unset(request.extract_keys):
            body['extractKeys'] = request.extract_keys
        if not UtilClient.is_unset(request.file_source):
            body['fileSource'] = request.file_source
        if not UtilClient.is_unset(request.request_id):
            body['requestId'] = request.request_id
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
            action='CreateContractAppsExtractTask',
            version='contract_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contract/apps/extractTasks',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontract__1__0_models.CreateContractAppsExtractTaskResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_contract_apps_extract_task(
        self,
        request: dingtalkcontract__1__0_models.CreateContractAppsExtractTaskRequest,
    ) -> dingtalkcontract__1__0_models.CreateContractAppsExtractTaskResponse:
        """
        @summary 创建合同提取任务
        
        @param request: CreateContractAppsExtractTaskRequest
        @return: CreateContractAppsExtractTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontract__1__0_models.CreateContractAppsExtractTaskHeaders()
        return self.create_contract_apps_extract_task_with_options(request, headers, runtime)

    async def create_contract_apps_extract_task_async(
        self,
        request: dingtalkcontract__1__0_models.CreateContractAppsExtractTaskRequest,
    ) -> dingtalkcontract__1__0_models.CreateContractAppsExtractTaskResponse:
        """
        @summary 创建合同提取任务
        
        @param request: CreateContractAppsExtractTaskRequest
        @return: CreateContractAppsExtractTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontract__1__0_models.CreateContractAppsExtractTaskHeaders()
        return await self.create_contract_apps_extract_task_with_options_async(request, headers, runtime)

    def create_contract_apps_review_task_with_options(
        self,
        request: dingtalkcontract__1__0_models.CreateContractAppsReviewTaskRequest,
        headers: dingtalkcontract__1__0_models.CreateContractAppsReviewTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontract__1__0_models.CreateContractAppsReviewTaskResponse:
        """
        @summary 创建合同审查任务
        
        @param request: CreateContractAppsReviewTaskRequest
        @param headers: CreateContractAppsReviewTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateContractAppsReviewTaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.contract_file):
            body['contractFile'] = request.contract_file
        if not UtilClient.is_unset(request.contract_file_download_url):
            body['contractFileDownloadUrl'] = request.contract_file_download_url
        if not UtilClient.is_unset(request.contract_file_name):
            body['contractFileName'] = request.contract_file_name
        if not UtilClient.is_unset(request.file_source):
            body['fileSource'] = request.file_source
        if not UtilClient.is_unset(request.request_id):
            body['requestId'] = request.request_id
        if not UtilClient.is_unset(request.review_custom_rules):
            body['reviewCustomRules'] = request.review_custom_rules
        if not UtilClient.is_unset(request.rule_type):
            body['ruleType'] = request.rule_type
        if not UtilClient.is_unset(request.standpoint):
            body['standpoint'] = request.standpoint
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
            action='CreateContractAppsReviewTask',
            version='contract_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contract/apps/reviewTasks',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontract__1__0_models.CreateContractAppsReviewTaskResponse(),
            self.execute(params, req, runtime)
        )

    async def create_contract_apps_review_task_with_options_async(
        self,
        request: dingtalkcontract__1__0_models.CreateContractAppsReviewTaskRequest,
        headers: dingtalkcontract__1__0_models.CreateContractAppsReviewTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontract__1__0_models.CreateContractAppsReviewTaskResponse:
        """
        @summary 创建合同审查任务
        
        @param request: CreateContractAppsReviewTaskRequest
        @param headers: CreateContractAppsReviewTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateContractAppsReviewTaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.contract_file):
            body['contractFile'] = request.contract_file
        if not UtilClient.is_unset(request.contract_file_download_url):
            body['contractFileDownloadUrl'] = request.contract_file_download_url
        if not UtilClient.is_unset(request.contract_file_name):
            body['contractFileName'] = request.contract_file_name
        if not UtilClient.is_unset(request.file_source):
            body['fileSource'] = request.file_source
        if not UtilClient.is_unset(request.request_id):
            body['requestId'] = request.request_id
        if not UtilClient.is_unset(request.review_custom_rules):
            body['reviewCustomRules'] = request.review_custom_rules
        if not UtilClient.is_unset(request.rule_type):
            body['ruleType'] = request.rule_type
        if not UtilClient.is_unset(request.standpoint):
            body['standpoint'] = request.standpoint
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
            action='CreateContractAppsReviewTask',
            version='contract_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contract/apps/reviewTasks',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontract__1__0_models.CreateContractAppsReviewTaskResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_contract_apps_review_task(
        self,
        request: dingtalkcontract__1__0_models.CreateContractAppsReviewTaskRequest,
    ) -> dingtalkcontract__1__0_models.CreateContractAppsReviewTaskResponse:
        """
        @summary 创建合同审查任务
        
        @param request: CreateContractAppsReviewTaskRequest
        @return: CreateContractAppsReviewTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontract__1__0_models.CreateContractAppsReviewTaskHeaders()
        return self.create_contract_apps_review_task_with_options(request, headers, runtime)

    async def create_contract_apps_review_task_async(
        self,
        request: dingtalkcontract__1__0_models.CreateContractAppsReviewTaskRequest,
    ) -> dingtalkcontract__1__0_models.CreateContractAppsReviewTaskResponse:
        """
        @summary 创建合同审查任务
        
        @param request: CreateContractAppsReviewTaskRequest
        @return: CreateContractAppsReviewTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontract__1__0_models.CreateContractAppsReviewTaskHeaders()
        return await self.create_contract_apps_review_task_with_options_async(request, headers, runtime)

    def create_contract_apps_terms_extract_eask_with_options(
        self,
        request: dingtalkcontract__1__0_models.CreateContractAppsTermsExtractEaskRequest,
        headers: dingtalkcontract__1__0_models.CreateContractAppsTermsExtractEaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontract__1__0_models.CreateContractAppsTermsExtractEaskResponse:
        """
        @summary 创建合同条款抽取任务
        
        @param request: CreateContractAppsTermsExtractEaskRequest
        @param headers: CreateContractAppsTermsExtractEaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateContractAppsTermsExtractEaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.contract_file):
            body['contractFile'] = request.contract_file
        if not UtilClient.is_unset(request.contract_file_download_url):
            body['contractFileDownloadUrl'] = request.contract_file_download_url
        if not UtilClient.is_unset(request.contract_file_name):
            body['contractFileName'] = request.contract_file_name
        if not UtilClient.is_unset(request.extract_rules):
            body['extractRules'] = request.extract_rules
        if not UtilClient.is_unset(request.file_source):
            body['fileSource'] = request.file_source
        if not UtilClient.is_unset(request.request_id):
            body['requestId'] = request.request_id
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
            action='CreateContractAppsTermsExtractEask',
            version='contract_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contract/apps/termsExtractTasks',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontract__1__0_models.CreateContractAppsTermsExtractEaskResponse(),
            self.execute(params, req, runtime)
        )

    async def create_contract_apps_terms_extract_eask_with_options_async(
        self,
        request: dingtalkcontract__1__0_models.CreateContractAppsTermsExtractEaskRequest,
        headers: dingtalkcontract__1__0_models.CreateContractAppsTermsExtractEaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontract__1__0_models.CreateContractAppsTermsExtractEaskResponse:
        """
        @summary 创建合同条款抽取任务
        
        @param request: CreateContractAppsTermsExtractEaskRequest
        @param headers: CreateContractAppsTermsExtractEaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateContractAppsTermsExtractEaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.contract_file):
            body['contractFile'] = request.contract_file
        if not UtilClient.is_unset(request.contract_file_download_url):
            body['contractFileDownloadUrl'] = request.contract_file_download_url
        if not UtilClient.is_unset(request.contract_file_name):
            body['contractFileName'] = request.contract_file_name
        if not UtilClient.is_unset(request.extract_rules):
            body['extractRules'] = request.extract_rules
        if not UtilClient.is_unset(request.file_source):
            body['fileSource'] = request.file_source
        if not UtilClient.is_unset(request.request_id):
            body['requestId'] = request.request_id
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
            action='CreateContractAppsTermsExtractEask',
            version='contract_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contract/apps/termsExtractTasks',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontract__1__0_models.CreateContractAppsTermsExtractEaskResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_contract_apps_terms_extract_eask(
        self,
        request: dingtalkcontract__1__0_models.CreateContractAppsTermsExtractEaskRequest,
    ) -> dingtalkcontract__1__0_models.CreateContractAppsTermsExtractEaskResponse:
        """
        @summary 创建合同条款抽取任务
        
        @param request: CreateContractAppsTermsExtractEaskRequest
        @return: CreateContractAppsTermsExtractEaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontract__1__0_models.CreateContractAppsTermsExtractEaskHeaders()
        return self.create_contract_apps_terms_extract_eask_with_options(request, headers, runtime)

    async def create_contract_apps_terms_extract_eask_async(
        self,
        request: dingtalkcontract__1__0_models.CreateContractAppsTermsExtractEaskRequest,
    ) -> dingtalkcontract__1__0_models.CreateContractAppsTermsExtractEaskResponse:
        """
        @summary 创建合同条款抽取任务
        
        @param request: CreateContractAppsTermsExtractEaskRequest
        @return: CreateContractAppsTermsExtractEaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontract__1__0_models.CreateContractAppsTermsExtractEaskHeaders()
        return await self.create_contract_apps_terms_extract_eask_with_options_async(request, headers, runtime)

    def create_contract_compare_task_with_options(
        self,
        request: dingtalkcontract__1__0_models.CreateContractCompareTaskRequest,
        headers: dingtalkcontract__1__0_models.CreateContractCompareTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontract__1__0_models.CreateContractCompareTaskResponse:
        """
        @summary 创建合同比对任务
        
        @param request: CreateContractCompareTaskRequest
        @param headers: CreateContractCompareTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateContractCompareTaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.comparative_file):
            body['comparativeFile'] = request.comparative_file
        if not UtilClient.is_unset(request.comparative_file_download_url):
            body['comparativeFileDownloadUrl'] = request.comparative_file_download_url
        if not UtilClient.is_unset(request.comparative_file_name):
            body['comparativeFileName'] = request.comparative_file_name
        if not UtilClient.is_unset(request.file_source):
            body['fileSource'] = request.file_source
        if not UtilClient.is_unset(request.request_id):
            body['requestId'] = request.request_id
        if not UtilClient.is_unset(request.standard_file):
            body['standardFile'] = request.standard_file
        if not UtilClient.is_unset(request.standard_file_download_url):
            body['standardFileDownloadUrl'] = request.standard_file_download_url
        if not UtilClient.is_unset(request.standard_file_name):
            body['standardFileName'] = request.standard_file_name
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
            action='CreateContractCompareTask',
            version='contract_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contract/comparisonTasks',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontract__1__0_models.CreateContractCompareTaskResponse(),
            self.execute(params, req, runtime)
        )

    async def create_contract_compare_task_with_options_async(
        self,
        request: dingtalkcontract__1__0_models.CreateContractCompareTaskRequest,
        headers: dingtalkcontract__1__0_models.CreateContractCompareTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontract__1__0_models.CreateContractCompareTaskResponse:
        """
        @summary 创建合同比对任务
        
        @param request: CreateContractCompareTaskRequest
        @param headers: CreateContractCompareTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateContractCompareTaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.comparative_file):
            body['comparativeFile'] = request.comparative_file
        if not UtilClient.is_unset(request.comparative_file_download_url):
            body['comparativeFileDownloadUrl'] = request.comparative_file_download_url
        if not UtilClient.is_unset(request.comparative_file_name):
            body['comparativeFileName'] = request.comparative_file_name
        if not UtilClient.is_unset(request.file_source):
            body['fileSource'] = request.file_source
        if not UtilClient.is_unset(request.request_id):
            body['requestId'] = request.request_id
        if not UtilClient.is_unset(request.standard_file):
            body['standardFile'] = request.standard_file
        if not UtilClient.is_unset(request.standard_file_download_url):
            body['standardFileDownloadUrl'] = request.standard_file_download_url
        if not UtilClient.is_unset(request.standard_file_name):
            body['standardFileName'] = request.standard_file_name
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
            action='CreateContractCompareTask',
            version='contract_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contract/comparisonTasks',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontract__1__0_models.CreateContractCompareTaskResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_contract_compare_task(
        self,
        request: dingtalkcontract__1__0_models.CreateContractCompareTaskRequest,
    ) -> dingtalkcontract__1__0_models.CreateContractCompareTaskResponse:
        """
        @summary 创建合同比对任务
        
        @param request: CreateContractCompareTaskRequest
        @return: CreateContractCompareTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontract__1__0_models.CreateContractCompareTaskHeaders()
        return self.create_contract_compare_task_with_options(request, headers, runtime)

    async def create_contract_compare_task_async(
        self,
        request: dingtalkcontract__1__0_models.CreateContractCompareTaskRequest,
    ) -> dingtalkcontract__1__0_models.CreateContractCompareTaskResponse:
        """
        @summary 创建合同比对任务
        
        @param request: CreateContractCompareTaskRequest
        @return: CreateContractCompareTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontract__1__0_models.CreateContractCompareTaskHeaders()
        return await self.create_contract_compare_task_with_options_async(request, headers, runtime)

    def create_contract_extract_task_with_options(
        self,
        request: dingtalkcontract__1__0_models.CreateContractExtractTaskRequest,
        headers: dingtalkcontract__1__0_models.CreateContractExtractTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontract__1__0_models.CreateContractExtractTaskResponse:
        """
        @summary 创建合同提取任务
        
        @param request: CreateContractExtractTaskRequest
        @param headers: CreateContractExtractTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateContractExtractTaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.contract_file):
            body['contractFile'] = request.contract_file
        if not UtilClient.is_unset(request.contract_file_download_url):
            body['contractFileDownloadUrl'] = request.contract_file_download_url
        if not UtilClient.is_unset(request.contract_file_name):
            body['contractFileName'] = request.contract_file_name
        if not UtilClient.is_unset(request.extract_keys):
            body['extractKeys'] = request.extract_keys
        if not UtilClient.is_unset(request.file_source):
            body['fileSource'] = request.file_source
        if not UtilClient.is_unset(request.request_id):
            body['requestId'] = request.request_id
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
            action='CreateContractExtractTask',
            version='contract_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contract/extractTasks',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontract__1__0_models.CreateContractExtractTaskResponse(),
            self.execute(params, req, runtime)
        )

    async def create_contract_extract_task_with_options_async(
        self,
        request: dingtalkcontract__1__0_models.CreateContractExtractTaskRequest,
        headers: dingtalkcontract__1__0_models.CreateContractExtractTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontract__1__0_models.CreateContractExtractTaskResponse:
        """
        @summary 创建合同提取任务
        
        @param request: CreateContractExtractTaskRequest
        @param headers: CreateContractExtractTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateContractExtractTaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.contract_file):
            body['contractFile'] = request.contract_file
        if not UtilClient.is_unset(request.contract_file_download_url):
            body['contractFileDownloadUrl'] = request.contract_file_download_url
        if not UtilClient.is_unset(request.contract_file_name):
            body['contractFileName'] = request.contract_file_name
        if not UtilClient.is_unset(request.extract_keys):
            body['extractKeys'] = request.extract_keys
        if not UtilClient.is_unset(request.file_source):
            body['fileSource'] = request.file_source
        if not UtilClient.is_unset(request.request_id):
            body['requestId'] = request.request_id
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
            action='CreateContractExtractTask',
            version='contract_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contract/extractTasks',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontract__1__0_models.CreateContractExtractTaskResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_contract_extract_task(
        self,
        request: dingtalkcontract__1__0_models.CreateContractExtractTaskRequest,
    ) -> dingtalkcontract__1__0_models.CreateContractExtractTaskResponse:
        """
        @summary 创建合同提取任务
        
        @param request: CreateContractExtractTaskRequest
        @return: CreateContractExtractTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontract__1__0_models.CreateContractExtractTaskHeaders()
        return self.create_contract_extract_task_with_options(request, headers, runtime)

    async def create_contract_extract_task_async(
        self,
        request: dingtalkcontract__1__0_models.CreateContractExtractTaskRequest,
    ) -> dingtalkcontract__1__0_models.CreateContractExtractTaskResponse:
        """
        @summary 创建合同提取任务
        
        @param request: CreateContractExtractTaskRequest
        @return: CreateContractExtractTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontract__1__0_models.CreateContractExtractTaskHeaders()
        return await self.create_contract_extract_task_with_options_async(request, headers, runtime)

    def create_contract_review_task_with_options(
        self,
        request: dingtalkcontract__1__0_models.CreateContractReviewTaskRequest,
        headers: dingtalkcontract__1__0_models.CreateContractReviewTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontract__1__0_models.CreateContractReviewTaskResponse:
        """
        @summary 创建合同审查任务
        
        @param request: CreateContractReviewTaskRequest
        @param headers: CreateContractReviewTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateContractReviewTaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.contract_file):
            body['contractFile'] = request.contract_file
        if not UtilClient.is_unset(request.contract_file_download_url):
            body['contractFileDownloadUrl'] = request.contract_file_download_url
        if not UtilClient.is_unset(request.contract_file_name):
            body['contractFileName'] = request.contract_file_name
        if not UtilClient.is_unset(request.file_source):
            body['fileSource'] = request.file_source
        if not UtilClient.is_unset(request.request_id):
            body['requestId'] = request.request_id
        if not UtilClient.is_unset(request.review_custom_rules):
            body['reviewCustomRules'] = request.review_custom_rules
        if not UtilClient.is_unset(request.rule_type):
            body['ruleType'] = request.rule_type
        if not UtilClient.is_unset(request.standpoint):
            body['standpoint'] = request.standpoint
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
            action='CreateContractReviewTask',
            version='contract_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contract/reviewTasks',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontract__1__0_models.CreateContractReviewTaskResponse(),
            self.execute(params, req, runtime)
        )

    async def create_contract_review_task_with_options_async(
        self,
        request: dingtalkcontract__1__0_models.CreateContractReviewTaskRequest,
        headers: dingtalkcontract__1__0_models.CreateContractReviewTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontract__1__0_models.CreateContractReviewTaskResponse:
        """
        @summary 创建合同审查任务
        
        @param request: CreateContractReviewTaskRequest
        @param headers: CreateContractReviewTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateContractReviewTaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.contract_file):
            body['contractFile'] = request.contract_file
        if not UtilClient.is_unset(request.contract_file_download_url):
            body['contractFileDownloadUrl'] = request.contract_file_download_url
        if not UtilClient.is_unset(request.contract_file_name):
            body['contractFileName'] = request.contract_file_name
        if not UtilClient.is_unset(request.file_source):
            body['fileSource'] = request.file_source
        if not UtilClient.is_unset(request.request_id):
            body['requestId'] = request.request_id
        if not UtilClient.is_unset(request.review_custom_rules):
            body['reviewCustomRules'] = request.review_custom_rules
        if not UtilClient.is_unset(request.rule_type):
            body['ruleType'] = request.rule_type
        if not UtilClient.is_unset(request.standpoint):
            body['standpoint'] = request.standpoint
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
            action='CreateContractReviewTask',
            version='contract_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contract/reviewTasks',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontract__1__0_models.CreateContractReviewTaskResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_contract_review_task(
        self,
        request: dingtalkcontract__1__0_models.CreateContractReviewTaskRequest,
    ) -> dingtalkcontract__1__0_models.CreateContractReviewTaskResponse:
        """
        @summary 创建合同审查任务
        
        @param request: CreateContractReviewTaskRequest
        @return: CreateContractReviewTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontract__1__0_models.CreateContractReviewTaskHeaders()
        return self.create_contract_review_task_with_options(request, headers, runtime)

    async def create_contract_review_task_async(
        self,
        request: dingtalkcontract__1__0_models.CreateContractReviewTaskRequest,
    ) -> dingtalkcontract__1__0_models.CreateContractReviewTaskResponse:
        """
        @summary 创建合同审查任务
        
        @param request: CreateContractReviewTaskRequest
        @return: CreateContractReviewTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontract__1__0_models.CreateContractReviewTaskHeaders()
        return await self.create_contract_review_task_with_options_async(request, headers, runtime)

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

    def query_contract_apps_compare_result_with_options(
        self,
        request: dingtalkcontract__1__0_models.QueryContractAppsCompareResultRequest,
        headers: dingtalkcontract__1__0_models.QueryContractAppsCompareResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontract__1__0_models.QueryContractAppsCompareResultResponse:
        """
        @summary 查询合同比对结果
        
        @param request: QueryContractAppsCompareResultRequest
        @param headers: QueryContractAppsCompareResultHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryContractAppsCompareResultResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.compare_task_id):
            body['compareTaskId'] = request.compare_task_id
        if not UtilClient.is_unset(request.request_id):
            body['requestId'] = request.request_id
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
            action='QueryContractAppsCompareResult',
            version='contract_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contract/apps/comparisonResults/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontract__1__0_models.QueryContractAppsCompareResultResponse(),
            self.execute(params, req, runtime)
        )

    async def query_contract_apps_compare_result_with_options_async(
        self,
        request: dingtalkcontract__1__0_models.QueryContractAppsCompareResultRequest,
        headers: dingtalkcontract__1__0_models.QueryContractAppsCompareResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontract__1__0_models.QueryContractAppsCompareResultResponse:
        """
        @summary 查询合同比对结果
        
        @param request: QueryContractAppsCompareResultRequest
        @param headers: QueryContractAppsCompareResultHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryContractAppsCompareResultResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.compare_task_id):
            body['compareTaskId'] = request.compare_task_id
        if not UtilClient.is_unset(request.request_id):
            body['requestId'] = request.request_id
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
            action='QueryContractAppsCompareResult',
            version='contract_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contract/apps/comparisonResults/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontract__1__0_models.QueryContractAppsCompareResultResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_contract_apps_compare_result(
        self,
        request: dingtalkcontract__1__0_models.QueryContractAppsCompareResultRequest,
    ) -> dingtalkcontract__1__0_models.QueryContractAppsCompareResultResponse:
        """
        @summary 查询合同比对结果
        
        @param request: QueryContractAppsCompareResultRequest
        @return: QueryContractAppsCompareResultResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontract__1__0_models.QueryContractAppsCompareResultHeaders()
        return self.query_contract_apps_compare_result_with_options(request, headers, runtime)

    async def query_contract_apps_compare_result_async(
        self,
        request: dingtalkcontract__1__0_models.QueryContractAppsCompareResultRequest,
    ) -> dingtalkcontract__1__0_models.QueryContractAppsCompareResultResponse:
        """
        @summary 查询合同比对结果
        
        @param request: QueryContractAppsCompareResultRequest
        @return: QueryContractAppsCompareResultResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontract__1__0_models.QueryContractAppsCompareResultHeaders()
        return await self.query_contract_apps_compare_result_with_options_async(request, headers, runtime)

    def query_contract_apps_extract_result_with_options(
        self,
        request: dingtalkcontract__1__0_models.QueryContractAppsExtractResultRequest,
        headers: dingtalkcontract__1__0_models.QueryContractAppsExtractResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontract__1__0_models.QueryContractAppsExtractResultResponse:
        """
        @summary 查询合同提取结果
        
        @param request: QueryContractAppsExtractResultRequest
        @param headers: QueryContractAppsExtractResultHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryContractAppsExtractResultResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.extract_task_id):
            body['extractTaskId'] = request.extract_task_id
        if not UtilClient.is_unset(request.request_id):
            body['requestId'] = request.request_id
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
            action='QueryContractAppsExtractResult',
            version='contract_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contract/apps/extractResults/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontract__1__0_models.QueryContractAppsExtractResultResponse(),
            self.execute(params, req, runtime)
        )

    async def query_contract_apps_extract_result_with_options_async(
        self,
        request: dingtalkcontract__1__0_models.QueryContractAppsExtractResultRequest,
        headers: dingtalkcontract__1__0_models.QueryContractAppsExtractResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontract__1__0_models.QueryContractAppsExtractResultResponse:
        """
        @summary 查询合同提取结果
        
        @param request: QueryContractAppsExtractResultRequest
        @param headers: QueryContractAppsExtractResultHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryContractAppsExtractResultResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.extract_task_id):
            body['extractTaskId'] = request.extract_task_id
        if not UtilClient.is_unset(request.request_id):
            body['requestId'] = request.request_id
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
            action='QueryContractAppsExtractResult',
            version='contract_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contract/apps/extractResults/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontract__1__0_models.QueryContractAppsExtractResultResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_contract_apps_extract_result(
        self,
        request: dingtalkcontract__1__0_models.QueryContractAppsExtractResultRequest,
    ) -> dingtalkcontract__1__0_models.QueryContractAppsExtractResultResponse:
        """
        @summary 查询合同提取结果
        
        @param request: QueryContractAppsExtractResultRequest
        @return: QueryContractAppsExtractResultResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontract__1__0_models.QueryContractAppsExtractResultHeaders()
        return self.query_contract_apps_extract_result_with_options(request, headers, runtime)

    async def query_contract_apps_extract_result_async(
        self,
        request: dingtalkcontract__1__0_models.QueryContractAppsExtractResultRequest,
    ) -> dingtalkcontract__1__0_models.QueryContractAppsExtractResultResponse:
        """
        @summary 查询合同提取结果
        
        @param request: QueryContractAppsExtractResultRequest
        @return: QueryContractAppsExtractResultResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontract__1__0_models.QueryContractAppsExtractResultHeaders()
        return await self.query_contract_apps_extract_result_with_options_async(request, headers, runtime)

    def query_contract_apps_review_result_with_options(
        self,
        request: dingtalkcontract__1__0_models.QueryContractAppsReviewResultRequest,
        headers: dingtalkcontract__1__0_models.QueryContractAppsReviewResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontract__1__0_models.QueryContractAppsReviewResultResponse:
        """
        @summary 查询合同审查结果
        
        @param request: QueryContractAppsReviewResultRequest
        @param headers: QueryContractAppsReviewResultHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryContractAppsReviewResultResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.request_id):
            body['requestId'] = request.request_id
        if not UtilClient.is_unset(request.review_task_id):
            body['reviewTaskId'] = request.review_task_id
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
            action='QueryContractAppsReviewResult',
            version='contract_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contract/apps/reviewResults/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontract__1__0_models.QueryContractAppsReviewResultResponse(),
            self.execute(params, req, runtime)
        )

    async def query_contract_apps_review_result_with_options_async(
        self,
        request: dingtalkcontract__1__0_models.QueryContractAppsReviewResultRequest,
        headers: dingtalkcontract__1__0_models.QueryContractAppsReviewResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontract__1__0_models.QueryContractAppsReviewResultResponse:
        """
        @summary 查询合同审查结果
        
        @param request: QueryContractAppsReviewResultRequest
        @param headers: QueryContractAppsReviewResultHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryContractAppsReviewResultResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.request_id):
            body['requestId'] = request.request_id
        if not UtilClient.is_unset(request.review_task_id):
            body['reviewTaskId'] = request.review_task_id
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
            action='QueryContractAppsReviewResult',
            version='contract_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contract/apps/reviewResults/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontract__1__0_models.QueryContractAppsReviewResultResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_contract_apps_review_result(
        self,
        request: dingtalkcontract__1__0_models.QueryContractAppsReviewResultRequest,
    ) -> dingtalkcontract__1__0_models.QueryContractAppsReviewResultResponse:
        """
        @summary 查询合同审查结果
        
        @param request: QueryContractAppsReviewResultRequest
        @return: QueryContractAppsReviewResultResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontract__1__0_models.QueryContractAppsReviewResultHeaders()
        return self.query_contract_apps_review_result_with_options(request, headers, runtime)

    async def query_contract_apps_review_result_async(
        self,
        request: dingtalkcontract__1__0_models.QueryContractAppsReviewResultRequest,
    ) -> dingtalkcontract__1__0_models.QueryContractAppsReviewResultResponse:
        """
        @summary 查询合同审查结果
        
        @param request: QueryContractAppsReviewResultRequest
        @return: QueryContractAppsReviewResultResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontract__1__0_models.QueryContractAppsReviewResultHeaders()
        return await self.query_contract_apps_review_result_with_options_async(request, headers, runtime)

    def query_contract_apps_terms_extract_result_with_options(
        self,
        request: dingtalkcontract__1__0_models.QueryContractAppsTermsExtractResultRequest,
        headers: dingtalkcontract__1__0_models.QueryContractAppsTermsExtractResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontract__1__0_models.QueryContractAppsTermsExtractResultResponse:
        """
        @summary 查询合同条款抽取结果
        
        @param request: QueryContractAppsTermsExtractResultRequest
        @param headers: QueryContractAppsTermsExtractResultHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryContractAppsTermsExtractResultResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.extract_task_id):
            body['extractTaskId'] = request.extract_task_id
        if not UtilClient.is_unset(request.request_id):
            body['requestId'] = request.request_id
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
            action='QueryContractAppsTermsExtractResult',
            version='contract_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contract/apps/termsExtractResults/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontract__1__0_models.QueryContractAppsTermsExtractResultResponse(),
            self.execute(params, req, runtime)
        )

    async def query_contract_apps_terms_extract_result_with_options_async(
        self,
        request: dingtalkcontract__1__0_models.QueryContractAppsTermsExtractResultRequest,
        headers: dingtalkcontract__1__0_models.QueryContractAppsTermsExtractResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontract__1__0_models.QueryContractAppsTermsExtractResultResponse:
        """
        @summary 查询合同条款抽取结果
        
        @param request: QueryContractAppsTermsExtractResultRequest
        @param headers: QueryContractAppsTermsExtractResultHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryContractAppsTermsExtractResultResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.extract_task_id):
            body['extractTaskId'] = request.extract_task_id
        if not UtilClient.is_unset(request.request_id):
            body['requestId'] = request.request_id
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
            action='QueryContractAppsTermsExtractResult',
            version='contract_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contract/apps/termsExtractResults/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontract__1__0_models.QueryContractAppsTermsExtractResultResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_contract_apps_terms_extract_result(
        self,
        request: dingtalkcontract__1__0_models.QueryContractAppsTermsExtractResultRequest,
    ) -> dingtalkcontract__1__0_models.QueryContractAppsTermsExtractResultResponse:
        """
        @summary 查询合同条款抽取结果
        
        @param request: QueryContractAppsTermsExtractResultRequest
        @return: QueryContractAppsTermsExtractResultResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontract__1__0_models.QueryContractAppsTermsExtractResultHeaders()
        return self.query_contract_apps_terms_extract_result_with_options(request, headers, runtime)

    async def query_contract_apps_terms_extract_result_async(
        self,
        request: dingtalkcontract__1__0_models.QueryContractAppsTermsExtractResultRequest,
    ) -> dingtalkcontract__1__0_models.QueryContractAppsTermsExtractResultResponse:
        """
        @summary 查询合同条款抽取结果
        
        @param request: QueryContractAppsTermsExtractResultRequest
        @return: QueryContractAppsTermsExtractResultResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontract__1__0_models.QueryContractAppsTermsExtractResultHeaders()
        return await self.query_contract_apps_terms_extract_result_with_options_async(request, headers, runtime)

    def query_contract_compare_result_with_options(
        self,
        request: dingtalkcontract__1__0_models.QueryContractCompareResultRequest,
        headers: dingtalkcontract__1__0_models.QueryContractCompareResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontract__1__0_models.QueryContractCompareResultResponse:
        """
        @summary 查询合同比对结果
        
        @param request: QueryContractCompareResultRequest
        @param headers: QueryContractCompareResultHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryContractCompareResultResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.compare_task_id):
            body['compareTaskId'] = request.compare_task_id
        if not UtilClient.is_unset(request.request_id):
            body['requestId'] = request.request_id
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
            action='QueryContractCompareResult',
            version='contract_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contract/comparisonResults/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontract__1__0_models.QueryContractCompareResultResponse(),
            self.execute(params, req, runtime)
        )

    async def query_contract_compare_result_with_options_async(
        self,
        request: dingtalkcontract__1__0_models.QueryContractCompareResultRequest,
        headers: dingtalkcontract__1__0_models.QueryContractCompareResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontract__1__0_models.QueryContractCompareResultResponse:
        """
        @summary 查询合同比对结果
        
        @param request: QueryContractCompareResultRequest
        @param headers: QueryContractCompareResultHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryContractCompareResultResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.compare_task_id):
            body['compareTaskId'] = request.compare_task_id
        if not UtilClient.is_unset(request.request_id):
            body['requestId'] = request.request_id
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
            action='QueryContractCompareResult',
            version='contract_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contract/comparisonResults/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontract__1__0_models.QueryContractCompareResultResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_contract_compare_result(
        self,
        request: dingtalkcontract__1__0_models.QueryContractCompareResultRequest,
    ) -> dingtalkcontract__1__0_models.QueryContractCompareResultResponse:
        """
        @summary 查询合同比对结果
        
        @param request: QueryContractCompareResultRequest
        @return: QueryContractCompareResultResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontract__1__0_models.QueryContractCompareResultHeaders()
        return self.query_contract_compare_result_with_options(request, headers, runtime)

    async def query_contract_compare_result_async(
        self,
        request: dingtalkcontract__1__0_models.QueryContractCompareResultRequest,
    ) -> dingtalkcontract__1__0_models.QueryContractCompareResultResponse:
        """
        @summary 查询合同比对结果
        
        @param request: QueryContractCompareResultRequest
        @return: QueryContractCompareResultResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontract__1__0_models.QueryContractCompareResultHeaders()
        return await self.query_contract_compare_result_with_options_async(request, headers, runtime)

    def query_contract_extract_result_with_options(
        self,
        request: dingtalkcontract__1__0_models.QueryContractExtractResultRequest,
        headers: dingtalkcontract__1__0_models.QueryContractExtractResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontract__1__0_models.QueryContractExtractResultResponse:
        """
        @summary 查询合同提取结果
        
        @param request: QueryContractExtractResultRequest
        @param headers: QueryContractExtractResultHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryContractExtractResultResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.extract_task_id):
            body['extractTaskId'] = request.extract_task_id
        if not UtilClient.is_unset(request.request_id):
            body['requestId'] = request.request_id
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
            action='QueryContractExtractResult',
            version='contract_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contract/extractResults/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontract__1__0_models.QueryContractExtractResultResponse(),
            self.execute(params, req, runtime)
        )

    async def query_contract_extract_result_with_options_async(
        self,
        request: dingtalkcontract__1__0_models.QueryContractExtractResultRequest,
        headers: dingtalkcontract__1__0_models.QueryContractExtractResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontract__1__0_models.QueryContractExtractResultResponse:
        """
        @summary 查询合同提取结果
        
        @param request: QueryContractExtractResultRequest
        @param headers: QueryContractExtractResultHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryContractExtractResultResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.extract_task_id):
            body['extractTaskId'] = request.extract_task_id
        if not UtilClient.is_unset(request.request_id):
            body['requestId'] = request.request_id
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
            action='QueryContractExtractResult',
            version='contract_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contract/extractResults/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontract__1__0_models.QueryContractExtractResultResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_contract_extract_result(
        self,
        request: dingtalkcontract__1__0_models.QueryContractExtractResultRequest,
    ) -> dingtalkcontract__1__0_models.QueryContractExtractResultResponse:
        """
        @summary 查询合同提取结果
        
        @param request: QueryContractExtractResultRequest
        @return: QueryContractExtractResultResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontract__1__0_models.QueryContractExtractResultHeaders()
        return self.query_contract_extract_result_with_options(request, headers, runtime)

    async def query_contract_extract_result_async(
        self,
        request: dingtalkcontract__1__0_models.QueryContractExtractResultRequest,
    ) -> dingtalkcontract__1__0_models.QueryContractExtractResultResponse:
        """
        @summary 查询合同提取结果
        
        @param request: QueryContractExtractResultRequest
        @return: QueryContractExtractResultResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontract__1__0_models.QueryContractExtractResultHeaders()
        return await self.query_contract_extract_result_with_options_async(request, headers, runtime)

    def query_contract_review_result_with_options(
        self,
        request: dingtalkcontract__1__0_models.QueryContractReviewResultRequest,
        headers: dingtalkcontract__1__0_models.QueryContractReviewResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontract__1__0_models.QueryContractReviewResultResponse:
        """
        @summary 查询合同审查结果
        
        @param request: QueryContractReviewResultRequest
        @param headers: QueryContractReviewResultHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryContractReviewResultResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.request_id):
            body['requestId'] = request.request_id
        if not UtilClient.is_unset(request.review_task_id):
            body['reviewTaskId'] = request.review_task_id
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
            action='QueryContractReviewResult',
            version='contract_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contract/reviewResults/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontract__1__0_models.QueryContractReviewResultResponse(),
            self.execute(params, req, runtime)
        )

    async def query_contract_review_result_with_options_async(
        self,
        request: dingtalkcontract__1__0_models.QueryContractReviewResultRequest,
        headers: dingtalkcontract__1__0_models.QueryContractReviewResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontract__1__0_models.QueryContractReviewResultResponse:
        """
        @summary 查询合同审查结果
        
        @param request: QueryContractReviewResultRequest
        @param headers: QueryContractReviewResultHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryContractReviewResultResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.request_id):
            body['requestId'] = request.request_id
        if not UtilClient.is_unset(request.review_task_id):
            body['reviewTaskId'] = request.review_task_id
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
            action='QueryContractReviewResult',
            version='contract_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contract/reviewResults/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontract__1__0_models.QueryContractReviewResultResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_contract_review_result(
        self,
        request: dingtalkcontract__1__0_models.QueryContractReviewResultRequest,
    ) -> dingtalkcontract__1__0_models.QueryContractReviewResultResponse:
        """
        @summary 查询合同审查结果
        
        @param request: QueryContractReviewResultRequest
        @return: QueryContractReviewResultResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontract__1__0_models.QueryContractReviewResultHeaders()
        return self.query_contract_review_result_with_options(request, headers, runtime)

    async def query_contract_review_result_async(
        self,
        request: dingtalkcontract__1__0_models.QueryContractReviewResultRequest,
    ) -> dingtalkcontract__1__0_models.QueryContractReviewResultResponse:
        """
        @summary 查询合同审查结果
        
        @param request: QueryContractReviewResultRequest
        @return: QueryContractReviewResultResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontract__1__0_models.QueryContractReviewResultHeaders()
        return await self.query_contract_review_result_with_options_async(request, headers, runtime)

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
