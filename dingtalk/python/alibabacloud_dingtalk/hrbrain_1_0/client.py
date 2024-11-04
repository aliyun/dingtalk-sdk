# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.hrbrain_1_0 import models as dingtalkhrbrain__1__0_models
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

    def hrbrain_delete_award_records_with_options(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainDeleteAwardRecordsRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainDeleteAwardRecordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainDeleteAwardRecordsResponse:
        """
        @summary 删除奖励记录
        
        @param request: HrbrainDeleteAwardRecordsRequest
        @param headers: HrbrainDeleteAwardRecordsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrbrainDeleteAwardRecordsResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.params):
            body['params'] = request.params
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
            action='HrbrainDeleteAwardRecords',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/awardRecords/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.HrbrainDeleteAwardRecordsResponse(),
            self.execute(params, req, runtime)
        )

    async def hrbrain_delete_award_records_with_options_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainDeleteAwardRecordsRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainDeleteAwardRecordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainDeleteAwardRecordsResponse:
        """
        @summary 删除奖励记录
        
        @param request: HrbrainDeleteAwardRecordsRequest
        @param headers: HrbrainDeleteAwardRecordsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrbrainDeleteAwardRecordsResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.params):
            body['params'] = request.params
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
            action='HrbrainDeleteAwardRecords',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/awardRecords/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.HrbrainDeleteAwardRecordsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def hrbrain_delete_award_records(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainDeleteAwardRecordsRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainDeleteAwardRecordsResponse:
        """
        @summary 删除奖励记录
        
        @param request: HrbrainDeleteAwardRecordsRequest
        @return: HrbrainDeleteAwardRecordsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainDeleteAwardRecordsHeaders()
        return self.hrbrain_delete_award_records_with_options(request, headers, runtime)

    async def hrbrain_delete_award_records_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainDeleteAwardRecordsRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainDeleteAwardRecordsResponse:
        """
        @summary 删除奖励记录
        
        @param request: HrbrainDeleteAwardRecordsRequest
        @return: HrbrainDeleteAwardRecordsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainDeleteAwardRecordsHeaders()
        return await self.hrbrain_delete_award_records_with_options_async(request, headers, runtime)

    def hrbrain_delete_dimission_with_options(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainDeleteDimissionRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainDeleteDimissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainDeleteDimissionResponse:
        """
        @summary 删除离职记录
        
        @param request: HrbrainDeleteDimissionRequest
        @param headers: HrbrainDeleteDimissionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrbrainDeleteDimissionResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.params):
            body['params'] = request.params
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
            action='HrbrainDeleteDimission',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/dimissionInfos/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.HrbrainDeleteDimissionResponse(),
            self.execute(params, req, runtime)
        )

    async def hrbrain_delete_dimission_with_options_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainDeleteDimissionRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainDeleteDimissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainDeleteDimissionResponse:
        """
        @summary 删除离职记录
        
        @param request: HrbrainDeleteDimissionRequest
        @param headers: HrbrainDeleteDimissionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrbrainDeleteDimissionResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.params):
            body['params'] = request.params
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
            action='HrbrainDeleteDimission',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/dimissionInfos/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.HrbrainDeleteDimissionResponse(),
            await self.execute_async(params, req, runtime)
        )

    def hrbrain_delete_dimission(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainDeleteDimissionRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainDeleteDimissionResponse:
        """
        @summary 删除离职记录
        
        @param request: HrbrainDeleteDimissionRequest
        @return: HrbrainDeleteDimissionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainDeleteDimissionHeaders()
        return self.hrbrain_delete_dimission_with_options(request, headers, runtime)

    async def hrbrain_delete_dimission_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainDeleteDimissionRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainDeleteDimissionResponse:
        """
        @summary 删除离职记录
        
        @param request: HrbrainDeleteDimissionRequest
        @return: HrbrainDeleteDimissionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainDeleteDimissionHeaders()
        return await self.hrbrain_delete_dimission_with_options_async(request, headers, runtime)

    def hrbrain_delete_edu_exp_with_options(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainDeleteEduExpRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainDeleteEduExpHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainDeleteEduExpResponse:
        """
        @summary 删除教育经历
        
        @param request: HrbrainDeleteEduExpRequest
        @param headers: HrbrainDeleteEduExpHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrbrainDeleteEduExpResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.params):
            body['params'] = request.params
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
            action='HrbrainDeleteEduExp',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/eduExperiences/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.HrbrainDeleteEduExpResponse(),
            self.execute(params, req, runtime)
        )

    async def hrbrain_delete_edu_exp_with_options_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainDeleteEduExpRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainDeleteEduExpHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainDeleteEduExpResponse:
        """
        @summary 删除教育经历
        
        @param request: HrbrainDeleteEduExpRequest
        @param headers: HrbrainDeleteEduExpHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrbrainDeleteEduExpResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.params):
            body['params'] = request.params
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
            action='HrbrainDeleteEduExp',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/eduExperiences/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.HrbrainDeleteEduExpResponse(),
            await self.execute_async(params, req, runtime)
        )

    def hrbrain_delete_edu_exp(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainDeleteEduExpRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainDeleteEduExpResponse:
        """
        @summary 删除教育经历
        
        @param request: HrbrainDeleteEduExpRequest
        @return: HrbrainDeleteEduExpResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainDeleteEduExpHeaders()
        return self.hrbrain_delete_edu_exp_with_options(request, headers, runtime)

    async def hrbrain_delete_edu_exp_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainDeleteEduExpRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainDeleteEduExpResponse:
        """
        @summary 删除教育经历
        
        @param request: HrbrainDeleteEduExpRequest
        @return: HrbrainDeleteEduExpResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainDeleteEduExpHeaders()
        return await self.hrbrain_delete_edu_exp_with_options_async(request, headers, runtime)

    def hrbrain_delete_emp_info_with_options(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainDeleteEmpInfoRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainDeleteEmpInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainDeleteEmpInfoResponse:
        """
        @summary 删除人员信息
        
        @param request: HrbrainDeleteEmpInfoRequest
        @param headers: HrbrainDeleteEmpInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrbrainDeleteEmpInfoResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.params):
            body['params'] = request.params
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
            action='HrbrainDeleteEmpInfo',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/empInfos/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.HrbrainDeleteEmpInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def hrbrain_delete_emp_info_with_options_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainDeleteEmpInfoRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainDeleteEmpInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainDeleteEmpInfoResponse:
        """
        @summary 删除人员信息
        
        @param request: HrbrainDeleteEmpInfoRequest
        @param headers: HrbrainDeleteEmpInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrbrainDeleteEmpInfoResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.params):
            body['params'] = request.params
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
            action='HrbrainDeleteEmpInfo',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/empInfos/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.HrbrainDeleteEmpInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def hrbrain_delete_emp_info(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainDeleteEmpInfoRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainDeleteEmpInfoResponse:
        """
        @summary 删除人员信息
        
        @param request: HrbrainDeleteEmpInfoRequest
        @return: HrbrainDeleteEmpInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainDeleteEmpInfoHeaders()
        return self.hrbrain_delete_emp_info_with_options(request, headers, runtime)

    async def hrbrain_delete_emp_info_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainDeleteEmpInfoRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainDeleteEmpInfoResponse:
        """
        @summary 删除人员信息
        
        @param request: HrbrainDeleteEmpInfoRequest
        @return: HrbrainDeleteEmpInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainDeleteEmpInfoHeaders()
        return await self.hrbrain_delete_emp_info_with_options_async(request, headers, runtime)

    def hrbrain_delete_label_industry_with_options(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainDeleteLabelIndustryRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainDeleteLabelIndustryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainDeleteLabelIndustryResponse:
        """
        @summary 删除领域经验
        
        @param request: HrbrainDeleteLabelIndustryRequest
        @param headers: HrbrainDeleteLabelIndustryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrbrainDeleteLabelIndustryResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.params):
            body['params'] = request.params
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
            action='HrbrainDeleteLabelIndustry',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/industries/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.HrbrainDeleteLabelIndustryResponse(),
            self.execute(params, req, runtime)
        )

    async def hrbrain_delete_label_industry_with_options_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainDeleteLabelIndustryRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainDeleteLabelIndustryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainDeleteLabelIndustryResponse:
        """
        @summary 删除领域经验
        
        @param request: HrbrainDeleteLabelIndustryRequest
        @param headers: HrbrainDeleteLabelIndustryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrbrainDeleteLabelIndustryResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.params):
            body['params'] = request.params
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
            action='HrbrainDeleteLabelIndustry',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/industries/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.HrbrainDeleteLabelIndustryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def hrbrain_delete_label_industry(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainDeleteLabelIndustryRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainDeleteLabelIndustryResponse:
        """
        @summary 删除领域经验
        
        @param request: HrbrainDeleteLabelIndustryRequest
        @return: HrbrainDeleteLabelIndustryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainDeleteLabelIndustryHeaders()
        return self.hrbrain_delete_label_industry_with_options(request, headers, runtime)

    async def hrbrain_delete_label_industry_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainDeleteLabelIndustryRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainDeleteLabelIndustryResponse:
        """
        @summary 删除领域经验
        
        @param request: HrbrainDeleteLabelIndustryRequest
        @return: HrbrainDeleteLabelIndustryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainDeleteLabelIndustryHeaders()
        return await self.hrbrain_delete_label_industry_with_options_async(request, headers, runtime)

    def hrbrain_delete_label_inventory_with_options(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainDeleteLabelInventoryRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainDeleteLabelInventoryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainDeleteLabelInventoryResponse:
        """
        @summary 删除盘点数据
        
        @param request: HrbrainDeleteLabelInventoryRequest
        @param headers: HrbrainDeleteLabelInventoryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrbrainDeleteLabelInventoryResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.params):
            body['params'] = request.params
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
            action='HrbrainDeleteLabelInventory',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/inventories/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.HrbrainDeleteLabelInventoryResponse(),
            self.execute(params, req, runtime)
        )

    async def hrbrain_delete_label_inventory_with_options_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainDeleteLabelInventoryRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainDeleteLabelInventoryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainDeleteLabelInventoryResponse:
        """
        @summary 删除盘点数据
        
        @param request: HrbrainDeleteLabelInventoryRequest
        @param headers: HrbrainDeleteLabelInventoryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrbrainDeleteLabelInventoryResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.params):
            body['params'] = request.params
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
            action='HrbrainDeleteLabelInventory',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/inventories/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.HrbrainDeleteLabelInventoryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def hrbrain_delete_label_inventory(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainDeleteLabelInventoryRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainDeleteLabelInventoryResponse:
        """
        @summary 删除盘点数据
        
        @param request: HrbrainDeleteLabelInventoryRequest
        @return: HrbrainDeleteLabelInventoryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainDeleteLabelInventoryHeaders()
        return self.hrbrain_delete_label_inventory_with_options(request, headers, runtime)

    async def hrbrain_delete_label_inventory_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainDeleteLabelInventoryRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainDeleteLabelInventoryResponse:
        """
        @summary 删除盘点数据
        
        @param request: HrbrainDeleteLabelInventoryRequest
        @return: HrbrainDeleteLabelInventoryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainDeleteLabelInventoryHeaders()
        return await self.hrbrain_delete_label_inventory_with_options_async(request, headers, runtime)

    def hrbrain_delete_label_prof_skill_with_options(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainDeleteLabelProfSkillRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainDeleteLabelProfSkillHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainDeleteLabelProfSkillResponse:
        """
        @summary 删除专业技能
        
        @param request: HrbrainDeleteLabelProfSkillRequest
        @param headers: HrbrainDeleteLabelProfSkillHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrbrainDeleteLabelProfSkillResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.params):
            body['params'] = request.params
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
            action='HrbrainDeleteLabelProfSkill',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/profSkills/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.HrbrainDeleteLabelProfSkillResponse(),
            self.execute(params, req, runtime)
        )

    async def hrbrain_delete_label_prof_skill_with_options_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainDeleteLabelProfSkillRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainDeleteLabelProfSkillHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainDeleteLabelProfSkillResponse:
        """
        @summary 删除专业技能
        
        @param request: HrbrainDeleteLabelProfSkillRequest
        @param headers: HrbrainDeleteLabelProfSkillHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrbrainDeleteLabelProfSkillResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.params):
            body['params'] = request.params
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
            action='HrbrainDeleteLabelProfSkill',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/profSkills/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.HrbrainDeleteLabelProfSkillResponse(),
            await self.execute_async(params, req, runtime)
        )

    def hrbrain_delete_label_prof_skill(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainDeleteLabelProfSkillRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainDeleteLabelProfSkillResponse:
        """
        @summary 删除专业技能
        
        @param request: HrbrainDeleteLabelProfSkillRequest
        @return: HrbrainDeleteLabelProfSkillResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainDeleteLabelProfSkillHeaders()
        return self.hrbrain_delete_label_prof_skill_with_options(request, headers, runtime)

    async def hrbrain_delete_label_prof_skill_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainDeleteLabelProfSkillRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainDeleteLabelProfSkillResponse:
        """
        @summary 删除专业技能
        
        @param request: HrbrainDeleteLabelProfSkillRequest
        @return: HrbrainDeleteLabelProfSkillResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainDeleteLabelProfSkillHeaders()
        return await self.hrbrain_delete_label_prof_skill_with_options_async(request, headers, runtime)

    def hrbrain_delete_perf_eval_with_options(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainDeletePerfEvalRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainDeletePerfEvalHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainDeletePerfEvalResponse:
        """
        @summary 删除绩效记录
        
        @param request: HrbrainDeletePerfEvalRequest
        @param headers: HrbrainDeletePerfEvalHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrbrainDeletePerfEvalResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.params):
            body['params'] = request.params
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
            action='HrbrainDeletePerfEval',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/perfRecords/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.HrbrainDeletePerfEvalResponse(),
            self.execute(params, req, runtime)
        )

    async def hrbrain_delete_perf_eval_with_options_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainDeletePerfEvalRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainDeletePerfEvalHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainDeletePerfEvalResponse:
        """
        @summary 删除绩效记录
        
        @param request: HrbrainDeletePerfEvalRequest
        @param headers: HrbrainDeletePerfEvalHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrbrainDeletePerfEvalResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.params):
            body['params'] = request.params
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
            action='HrbrainDeletePerfEval',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/perfRecords/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.HrbrainDeletePerfEvalResponse(),
            await self.execute_async(params, req, runtime)
        )

    def hrbrain_delete_perf_eval(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainDeletePerfEvalRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainDeletePerfEvalResponse:
        """
        @summary 删除绩效记录
        
        @param request: HrbrainDeletePerfEvalRequest
        @return: HrbrainDeletePerfEvalResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainDeletePerfEvalHeaders()
        return self.hrbrain_delete_perf_eval_with_options(request, headers, runtime)

    async def hrbrain_delete_perf_eval_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainDeletePerfEvalRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainDeletePerfEvalResponse:
        """
        @summary 删除绩效记录
        
        @param request: HrbrainDeletePerfEvalRequest
        @return: HrbrainDeletePerfEvalResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainDeletePerfEvalHeaders()
        return await self.hrbrain_delete_perf_eval_with_options_async(request, headers, runtime)

    def hrbrain_delete_prom_records_with_options(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainDeletePromRecordsRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainDeletePromRecordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainDeletePromRecordsResponse:
        """
        @summary 数据集成晋升记录删除
        
        @param request: HrbrainDeletePromRecordsRequest
        @param headers: HrbrainDeletePromRecordsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrbrainDeletePromRecordsResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.params):
            body['params'] = request.params
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
            action='HrbrainDeletePromRecords',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/promEvals/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.HrbrainDeletePromRecordsResponse(),
            self.execute(params, req, runtime)
        )

    async def hrbrain_delete_prom_records_with_options_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainDeletePromRecordsRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainDeletePromRecordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainDeletePromRecordsResponse:
        """
        @summary 数据集成晋升记录删除
        
        @param request: HrbrainDeletePromRecordsRequest
        @param headers: HrbrainDeletePromRecordsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrbrainDeletePromRecordsResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.params):
            body['params'] = request.params
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
            action='HrbrainDeletePromRecords',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/promEvals/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.HrbrainDeletePromRecordsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def hrbrain_delete_prom_records(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainDeletePromRecordsRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainDeletePromRecordsResponse:
        """
        @summary 数据集成晋升记录删除
        
        @param request: HrbrainDeletePromRecordsRequest
        @return: HrbrainDeletePromRecordsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainDeletePromRecordsHeaders()
        return self.hrbrain_delete_prom_records_with_options(request, headers, runtime)

    async def hrbrain_delete_prom_records_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainDeletePromRecordsRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainDeletePromRecordsResponse:
        """
        @summary 数据集成晋升记录删除
        
        @param request: HrbrainDeletePromRecordsRequest
        @return: HrbrainDeletePromRecordsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainDeletePromRecordsHeaders()
        return await self.hrbrain_delete_prom_records_with_options_async(request, headers, runtime)

    def hrbrain_delete_pun_detail_with_options(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainDeletePunDetailRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainDeletePunDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainDeletePunDetailResponse:
        """
        @summary 删除处分记录
        
        @param request: HrbrainDeletePunDetailRequest
        @param headers: HrbrainDeletePunDetailHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrbrainDeletePunDetailResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.params):
            body['params'] = request.params
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
            action='HrbrainDeletePunDetail',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/punDetails/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.HrbrainDeletePunDetailResponse(),
            self.execute(params, req, runtime)
        )

    async def hrbrain_delete_pun_detail_with_options_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainDeletePunDetailRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainDeletePunDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainDeletePunDetailResponse:
        """
        @summary 删除处分记录
        
        @param request: HrbrainDeletePunDetailRequest
        @param headers: HrbrainDeletePunDetailHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrbrainDeletePunDetailResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.params):
            body['params'] = request.params
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
            action='HrbrainDeletePunDetail',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/punDetails/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.HrbrainDeletePunDetailResponse(),
            await self.execute_async(params, req, runtime)
        )

    def hrbrain_delete_pun_detail(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainDeletePunDetailRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainDeletePunDetailResponse:
        """
        @summary 删除处分记录
        
        @param request: HrbrainDeletePunDetailRequest
        @return: HrbrainDeletePunDetailResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainDeletePunDetailHeaders()
        return self.hrbrain_delete_pun_detail_with_options(request, headers, runtime)

    async def hrbrain_delete_pun_detail_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainDeletePunDetailRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainDeletePunDetailResponse:
        """
        @summary 删除处分记录
        
        @param request: HrbrainDeletePunDetailRequest
        @return: HrbrainDeletePunDetailResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainDeletePunDetailHeaders()
        return await self.hrbrain_delete_pun_detail_with_options_async(request, headers, runtime)

    def hrbrain_delete_regist_with_options(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainDeleteRegistRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainDeleteRegistHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainDeleteRegistResponse:
        """
        @summary 删除入职记录
        
        @param request: HrbrainDeleteRegistRequest
        @param headers: HrbrainDeleteRegistHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrbrainDeleteRegistResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.params):
            body['params'] = request.params
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
            action='HrbrainDeleteRegist',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/registerInfos/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.HrbrainDeleteRegistResponse(),
            self.execute(params, req, runtime)
        )

    async def hrbrain_delete_regist_with_options_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainDeleteRegistRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainDeleteRegistHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainDeleteRegistResponse:
        """
        @summary 删除入职记录
        
        @param request: HrbrainDeleteRegistRequest
        @param headers: HrbrainDeleteRegistHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrbrainDeleteRegistResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.params):
            body['params'] = request.params
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
            action='HrbrainDeleteRegist',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/registerInfos/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.HrbrainDeleteRegistResponse(),
            await self.execute_async(params, req, runtime)
        )

    def hrbrain_delete_regist(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainDeleteRegistRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainDeleteRegistResponse:
        """
        @summary 删除入职记录
        
        @param request: HrbrainDeleteRegistRequest
        @return: HrbrainDeleteRegistResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainDeleteRegistHeaders()
        return self.hrbrain_delete_regist_with_options(request, headers, runtime)

    async def hrbrain_delete_regist_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainDeleteRegistRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainDeleteRegistResponse:
        """
        @summary 删除入职记录
        
        @param request: HrbrainDeleteRegistRequest
        @return: HrbrainDeleteRegistResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainDeleteRegistHeaders()
        return await self.hrbrain_delete_regist_with_options_async(request, headers, runtime)

    def hrbrain_delete_transfer_eval_with_options(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainDeleteTransferEvalRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainDeleteTransferEvalHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainDeleteTransferEvalResponse:
        """
        @summary 删除调岗记录
        
        @param request: HrbrainDeleteTransferEvalRequest
        @param headers: HrbrainDeleteTransferEvalHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrbrainDeleteTransferEvalResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.params):
            body['params'] = request.params
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
            action='HrbrainDeleteTransferEval',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/changeRecords/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.HrbrainDeleteTransferEvalResponse(),
            self.execute(params, req, runtime)
        )

    async def hrbrain_delete_transfer_eval_with_options_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainDeleteTransferEvalRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainDeleteTransferEvalHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainDeleteTransferEvalResponse:
        """
        @summary 删除调岗记录
        
        @param request: HrbrainDeleteTransferEvalRequest
        @param headers: HrbrainDeleteTransferEvalHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrbrainDeleteTransferEvalResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.params):
            body['params'] = request.params
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
            action='HrbrainDeleteTransferEval',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/changeRecords/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.HrbrainDeleteTransferEvalResponse(),
            await self.execute_async(params, req, runtime)
        )

    def hrbrain_delete_transfer_eval(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainDeleteTransferEvalRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainDeleteTransferEvalResponse:
        """
        @summary 删除调岗记录
        
        @param request: HrbrainDeleteTransferEvalRequest
        @return: HrbrainDeleteTransferEvalResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainDeleteTransferEvalHeaders()
        return self.hrbrain_delete_transfer_eval_with_options(request, headers, runtime)

    async def hrbrain_delete_transfer_eval_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainDeleteTransferEvalRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainDeleteTransferEvalResponse:
        """
        @summary 删除调岗记录
        
        @param request: HrbrainDeleteTransferEvalRequest
        @return: HrbrainDeleteTransferEvalResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainDeleteTransferEvalHeaders()
        return await self.hrbrain_delete_transfer_eval_with_options_async(request, headers, runtime)

    def hrbrain_delete_work_exp_with_options(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainDeleteWorkExpRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainDeleteWorkExpHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainDeleteWorkExpResponse:
        """
        @summary 删除工作经历
        
        @param request: HrbrainDeleteWorkExpRequest
        @param headers: HrbrainDeleteWorkExpHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrbrainDeleteWorkExpResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.params):
            body['params'] = request.params
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
            action='HrbrainDeleteWorkExp',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/workExperiences/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.HrbrainDeleteWorkExpResponse(),
            self.execute(params, req, runtime)
        )

    async def hrbrain_delete_work_exp_with_options_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainDeleteWorkExpRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainDeleteWorkExpHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainDeleteWorkExpResponse:
        """
        @summary 删除工作经历
        
        @param request: HrbrainDeleteWorkExpRequest
        @param headers: HrbrainDeleteWorkExpHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrbrainDeleteWorkExpResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.params):
            body['params'] = request.params
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
            action='HrbrainDeleteWorkExp',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/workExperiences/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.HrbrainDeleteWorkExpResponse(),
            await self.execute_async(params, req, runtime)
        )

    def hrbrain_delete_work_exp(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainDeleteWorkExpRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainDeleteWorkExpResponse:
        """
        @summary 删除工作经历
        
        @param request: HrbrainDeleteWorkExpRequest
        @return: HrbrainDeleteWorkExpResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainDeleteWorkExpHeaders()
        return self.hrbrain_delete_work_exp_with_options(request, headers, runtime)

    async def hrbrain_delete_work_exp_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainDeleteWorkExpRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainDeleteWorkExpResponse:
        """
        @summary 删除工作经历
        
        @param request: HrbrainDeleteWorkExpRequest
        @return: HrbrainDeleteWorkExpResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainDeleteWorkExpHeaders()
        return await self.hrbrain_delete_work_exp_with_options_async(request, headers, runtime)

    def hrbrain_deletet_label_base_with_options(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainDeletetLabelBaseRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainDeletetLabelBaseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainDeletetLabelBaseResponse:
        """
        @summary 删除标签数据
        
        @param request: HrbrainDeletetLabelBaseRequest
        @param headers: HrbrainDeletetLabelBaseHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrbrainDeletetLabelBaseResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.params):
            body['params'] = request.params
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
            action='HrbrainDeletetLabelBase',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/baseLabels/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.HrbrainDeletetLabelBaseResponse(),
            self.execute(params, req, runtime)
        )

    async def hrbrain_deletet_label_base_with_options_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainDeletetLabelBaseRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainDeletetLabelBaseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainDeletetLabelBaseResponse:
        """
        @summary 删除标签数据
        
        @param request: HrbrainDeletetLabelBaseRequest
        @param headers: HrbrainDeletetLabelBaseHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrbrainDeletetLabelBaseResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.params):
            body['params'] = request.params
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
            action='HrbrainDeletetLabelBase',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/baseLabels/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.HrbrainDeletetLabelBaseResponse(),
            await self.execute_async(params, req, runtime)
        )

    def hrbrain_deletet_label_base(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainDeletetLabelBaseRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainDeletetLabelBaseResponse:
        """
        @summary 删除标签数据
        
        @param request: HrbrainDeletetLabelBaseRequest
        @return: HrbrainDeletetLabelBaseResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainDeletetLabelBaseHeaders()
        return self.hrbrain_deletet_label_base_with_options(request, headers, runtime)

    async def hrbrain_deletet_label_base_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainDeletetLabelBaseRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainDeletetLabelBaseResponse:
        """
        @summary 删除标签数据
        
        @param request: HrbrainDeletetLabelBaseRequest
        @return: HrbrainDeletetLabelBaseResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainDeletetLabelBaseHeaders()
        return await self.hrbrain_deletet_label_base_with_options_async(request, headers, runtime)

    def hrbrain_import_award_detail_with_options(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportAwardDetailRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainImportAwardDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportAwardDetailResponse:
        """
        @summary 集成奖励记录
        
        @param request: HrbrainImportAwardDetailRequest
        @param headers: HrbrainImportAwardDetailHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrbrainImportAwardDetailResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=UtilClient.to_array(request.body)
        )
        params = open_api_models.Params(
            action='HrbrainImportAwardDetail',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/awardDetails/import',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.HrbrainImportAwardDetailResponse(),
            self.execute(params, req, runtime)
        )

    async def hrbrain_import_award_detail_with_options_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportAwardDetailRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainImportAwardDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportAwardDetailResponse:
        """
        @summary 集成奖励记录
        
        @param request: HrbrainImportAwardDetailRequest
        @param headers: HrbrainImportAwardDetailHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrbrainImportAwardDetailResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=UtilClient.to_array(request.body)
        )
        params = open_api_models.Params(
            action='HrbrainImportAwardDetail',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/awardDetails/import',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.HrbrainImportAwardDetailResponse(),
            await self.execute_async(params, req, runtime)
        )

    def hrbrain_import_award_detail(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportAwardDetailRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportAwardDetailResponse:
        """
        @summary 集成奖励记录
        
        @param request: HrbrainImportAwardDetailRequest
        @return: HrbrainImportAwardDetailResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportAwardDetailHeaders()
        return self.hrbrain_import_award_detail_with_options(request, headers, runtime)

    async def hrbrain_import_award_detail_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportAwardDetailRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportAwardDetailResponse:
        """
        @summary 集成奖励记录
        
        @param request: HrbrainImportAwardDetailRequest
        @return: HrbrainImportAwardDetailResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportAwardDetailHeaders()
        return await self.hrbrain_import_award_detail_with_options_async(request, headers, runtime)

    def hrbrain_import_dept_info_with_options(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportDeptInfoRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainImportDeptInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportDeptInfoResponse:
        """
        @summary 集成组织架构
        
        @param request: HrbrainImportDeptInfoRequest
        @param headers: HrbrainImportDeptInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrbrainImportDeptInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=UtilClient.to_array(request.body)
        )
        params = open_api_models.Params(
            action='HrbrainImportDeptInfo',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/deptInfos/import',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.HrbrainImportDeptInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def hrbrain_import_dept_info_with_options_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportDeptInfoRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainImportDeptInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportDeptInfoResponse:
        """
        @summary 集成组织架构
        
        @param request: HrbrainImportDeptInfoRequest
        @param headers: HrbrainImportDeptInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrbrainImportDeptInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=UtilClient.to_array(request.body)
        )
        params = open_api_models.Params(
            action='HrbrainImportDeptInfo',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/deptInfos/import',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.HrbrainImportDeptInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def hrbrain_import_dept_info(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportDeptInfoRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportDeptInfoResponse:
        """
        @summary 集成组织架构
        
        @param request: HrbrainImportDeptInfoRequest
        @return: HrbrainImportDeptInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportDeptInfoHeaders()
        return self.hrbrain_import_dept_info_with_options(request, headers, runtime)

    async def hrbrain_import_dept_info_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportDeptInfoRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportDeptInfoResponse:
        """
        @summary 集成组织架构
        
        @param request: HrbrainImportDeptInfoRequest
        @return: HrbrainImportDeptInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportDeptInfoHeaders()
        return await self.hrbrain_import_dept_info_with_options_async(request, headers, runtime)

    def hrbrain_import_dimission_with_options(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportDimissionRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainImportDimissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportDimissionResponse:
        """
        @summary 集成离职信息
        
        @param request: HrbrainImportDimissionRequest
        @param headers: HrbrainImportDimissionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrbrainImportDimissionResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=UtilClient.to_array(request.body)
        )
        params = open_api_models.Params(
            action='HrbrainImportDimission',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/dimissionInfos/import',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.HrbrainImportDimissionResponse(),
            self.execute(params, req, runtime)
        )

    async def hrbrain_import_dimission_with_options_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportDimissionRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainImportDimissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportDimissionResponse:
        """
        @summary 集成离职信息
        
        @param request: HrbrainImportDimissionRequest
        @param headers: HrbrainImportDimissionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrbrainImportDimissionResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=UtilClient.to_array(request.body)
        )
        params = open_api_models.Params(
            action='HrbrainImportDimission',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/dimissionInfos/import',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.HrbrainImportDimissionResponse(),
            await self.execute_async(params, req, runtime)
        )

    def hrbrain_import_dimission(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportDimissionRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportDimissionResponse:
        """
        @summary 集成离职信息
        
        @param request: HrbrainImportDimissionRequest
        @return: HrbrainImportDimissionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportDimissionHeaders()
        return self.hrbrain_import_dimission_with_options(request, headers, runtime)

    async def hrbrain_import_dimission_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportDimissionRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportDimissionResponse:
        """
        @summary 集成离职信息
        
        @param request: HrbrainImportDimissionRequest
        @return: HrbrainImportDimissionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportDimissionHeaders()
        return await self.hrbrain_import_dimission_with_options_async(request, headers, runtime)

    def hrbrain_import_edu_exp_with_options(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportEduExpRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainImportEduExpHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportEduExpResponse:
        """
        @summary 集成教育经历
        
        @param request: HrbrainImportEduExpRequest
        @param headers: HrbrainImportEduExpHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrbrainImportEduExpResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=UtilClient.to_array(request.body)
        )
        params = open_api_models.Params(
            action='HrbrainImportEduExp',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/eduExperiences/import',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.HrbrainImportEduExpResponse(),
            self.execute(params, req, runtime)
        )

    async def hrbrain_import_edu_exp_with_options_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportEduExpRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainImportEduExpHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportEduExpResponse:
        """
        @summary 集成教育经历
        
        @param request: HrbrainImportEduExpRequest
        @param headers: HrbrainImportEduExpHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrbrainImportEduExpResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=UtilClient.to_array(request.body)
        )
        params = open_api_models.Params(
            action='HrbrainImportEduExp',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/eduExperiences/import',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.HrbrainImportEduExpResponse(),
            await self.execute_async(params, req, runtime)
        )

    def hrbrain_import_edu_exp(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportEduExpRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportEduExpResponse:
        """
        @summary 集成教育经历
        
        @param request: HrbrainImportEduExpRequest
        @return: HrbrainImportEduExpResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportEduExpHeaders()
        return self.hrbrain_import_edu_exp_with_options(request, headers, runtime)

    async def hrbrain_import_edu_exp_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportEduExpRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportEduExpResponse:
        """
        @summary 集成教育经历
        
        @param request: HrbrainImportEduExpRequest
        @return: HrbrainImportEduExpResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportEduExpHeaders()
        return await self.hrbrain_import_edu_exp_with_options_async(request, headers, runtime)

    def hrbrain_import_emp_info_with_options(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportEmpInfoRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainImportEmpInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportEmpInfoResponse:
        """
        @summary 集成人员信息
        
        @param request: HrbrainImportEmpInfoRequest
        @param headers: HrbrainImportEmpInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrbrainImportEmpInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=UtilClient.to_array(request.body)
        )
        params = open_api_models.Params(
            action='HrbrainImportEmpInfo',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/empInfos/import',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.HrbrainImportEmpInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def hrbrain_import_emp_info_with_options_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportEmpInfoRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainImportEmpInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportEmpInfoResponse:
        """
        @summary 集成人员信息
        
        @param request: HrbrainImportEmpInfoRequest
        @param headers: HrbrainImportEmpInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrbrainImportEmpInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=UtilClient.to_array(request.body)
        )
        params = open_api_models.Params(
            action='HrbrainImportEmpInfo',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/empInfos/import',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.HrbrainImportEmpInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def hrbrain_import_emp_info(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportEmpInfoRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportEmpInfoResponse:
        """
        @summary 集成人员信息
        
        @param request: HrbrainImportEmpInfoRequest
        @return: HrbrainImportEmpInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportEmpInfoHeaders()
        return self.hrbrain_import_emp_info_with_options(request, headers, runtime)

    async def hrbrain_import_emp_info_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportEmpInfoRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportEmpInfoResponse:
        """
        @summary 集成人员信息
        
        @param request: HrbrainImportEmpInfoRequest
        @return: HrbrainImportEmpInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportEmpInfoHeaders()
        return await self.hrbrain_import_emp_info_with_options_async(request, headers, runtime)

    def hrbrain_import_label_base_with_options(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportLabelBaseRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainImportLabelBaseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportLabelBaseResponse:
        """
        @summary 集成基础标签
        
        @param request: HrbrainImportLabelBaseRequest
        @param headers: HrbrainImportLabelBaseHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrbrainImportLabelBaseResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=UtilClient.to_array(request.body)
        )
        params = open_api_models.Params(
            action='HrbrainImportLabelBase',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/baseLabels/import',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.HrbrainImportLabelBaseResponse(),
            self.execute(params, req, runtime)
        )

    async def hrbrain_import_label_base_with_options_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportLabelBaseRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainImportLabelBaseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportLabelBaseResponse:
        """
        @summary 集成基础标签
        
        @param request: HrbrainImportLabelBaseRequest
        @param headers: HrbrainImportLabelBaseHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrbrainImportLabelBaseResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=UtilClient.to_array(request.body)
        )
        params = open_api_models.Params(
            action='HrbrainImportLabelBase',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/baseLabels/import',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.HrbrainImportLabelBaseResponse(),
            await self.execute_async(params, req, runtime)
        )

    def hrbrain_import_label_base(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportLabelBaseRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportLabelBaseResponse:
        """
        @summary 集成基础标签
        
        @param request: HrbrainImportLabelBaseRequest
        @return: HrbrainImportLabelBaseResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportLabelBaseHeaders()
        return self.hrbrain_import_label_base_with_options(request, headers, runtime)

    async def hrbrain_import_label_base_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportLabelBaseRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportLabelBaseResponse:
        """
        @summary 集成基础标签
        
        @param request: HrbrainImportLabelBaseRequest
        @return: HrbrainImportLabelBaseResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportLabelBaseHeaders()
        return await self.hrbrain_import_label_base_with_options_async(request, headers, runtime)

    def hrbrain_import_label_custom_with_options(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportLabelCustomRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainImportLabelCustomHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportLabelCustomResponse:
        """
        @summary 集成自定义标签
        
        @param request: HrbrainImportLabelCustomRequest
        @param headers: HrbrainImportLabelCustomHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrbrainImportLabelCustomResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=UtilClient.to_array(request.body)
        )
        params = open_api_models.Params(
            action='HrbrainImportLabelCustom',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/customLabels/import',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.HrbrainImportLabelCustomResponse(),
            self.execute(params, req, runtime)
        )

    async def hrbrain_import_label_custom_with_options_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportLabelCustomRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainImportLabelCustomHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportLabelCustomResponse:
        """
        @summary 集成自定义标签
        
        @param request: HrbrainImportLabelCustomRequest
        @param headers: HrbrainImportLabelCustomHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrbrainImportLabelCustomResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=UtilClient.to_array(request.body)
        )
        params = open_api_models.Params(
            action='HrbrainImportLabelCustom',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/customLabels/import',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.HrbrainImportLabelCustomResponse(),
            await self.execute_async(params, req, runtime)
        )

    def hrbrain_import_label_custom(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportLabelCustomRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportLabelCustomResponse:
        """
        @summary 集成自定义标签
        
        @param request: HrbrainImportLabelCustomRequest
        @return: HrbrainImportLabelCustomResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportLabelCustomHeaders()
        return self.hrbrain_import_label_custom_with_options(request, headers, runtime)

    async def hrbrain_import_label_custom_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportLabelCustomRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportLabelCustomResponse:
        """
        @summary 集成自定义标签
        
        @param request: HrbrainImportLabelCustomRequest
        @return: HrbrainImportLabelCustomResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportLabelCustomHeaders()
        return await self.hrbrain_import_label_custom_with_options_async(request, headers, runtime)

    def hrbrain_import_label_industry_with_options(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportLabelIndustryRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainImportLabelIndustryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportLabelIndustryResponse:
        """
        @summary 集成领域经验
        
        @param request: HrbrainImportLabelIndustryRequest
        @param headers: HrbrainImportLabelIndustryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrbrainImportLabelIndustryResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=UtilClient.to_array(request.body)
        )
        params = open_api_models.Params(
            action='HrbrainImportLabelIndustry',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/industries/import',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.HrbrainImportLabelIndustryResponse(),
            self.execute(params, req, runtime)
        )

    async def hrbrain_import_label_industry_with_options_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportLabelIndustryRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainImportLabelIndustryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportLabelIndustryResponse:
        """
        @summary 集成领域经验
        
        @param request: HrbrainImportLabelIndustryRequest
        @param headers: HrbrainImportLabelIndustryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrbrainImportLabelIndustryResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=UtilClient.to_array(request.body)
        )
        params = open_api_models.Params(
            action='HrbrainImportLabelIndustry',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/industries/import',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.HrbrainImportLabelIndustryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def hrbrain_import_label_industry(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportLabelIndustryRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportLabelIndustryResponse:
        """
        @summary 集成领域经验
        
        @param request: HrbrainImportLabelIndustryRequest
        @return: HrbrainImportLabelIndustryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportLabelIndustryHeaders()
        return self.hrbrain_import_label_industry_with_options(request, headers, runtime)

    async def hrbrain_import_label_industry_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportLabelIndustryRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportLabelIndustryResponse:
        """
        @summary 集成领域经验
        
        @param request: HrbrainImportLabelIndustryRequest
        @return: HrbrainImportLabelIndustryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportLabelIndustryHeaders()
        return await self.hrbrain_import_label_industry_with_options_async(request, headers, runtime)

    def hrbrain_import_label_inventory_with_options(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportLabelInventoryRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainImportLabelInventoryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportLabelInventoryResponse:
        """
        @summary 集成盘点数据
        
        @param request: HrbrainImportLabelInventoryRequest
        @param headers: HrbrainImportLabelInventoryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrbrainImportLabelInventoryResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=UtilClient.to_array(request.body)
        )
        params = open_api_models.Params(
            action='HrbrainImportLabelInventory',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/inventories/import',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.HrbrainImportLabelInventoryResponse(),
            self.execute(params, req, runtime)
        )

    async def hrbrain_import_label_inventory_with_options_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportLabelInventoryRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainImportLabelInventoryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportLabelInventoryResponse:
        """
        @summary 集成盘点数据
        
        @param request: HrbrainImportLabelInventoryRequest
        @param headers: HrbrainImportLabelInventoryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrbrainImportLabelInventoryResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=UtilClient.to_array(request.body)
        )
        params = open_api_models.Params(
            action='HrbrainImportLabelInventory',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/inventories/import',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.HrbrainImportLabelInventoryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def hrbrain_import_label_inventory(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportLabelInventoryRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportLabelInventoryResponse:
        """
        @summary 集成盘点数据
        
        @param request: HrbrainImportLabelInventoryRequest
        @return: HrbrainImportLabelInventoryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportLabelInventoryHeaders()
        return self.hrbrain_import_label_inventory_with_options(request, headers, runtime)

    async def hrbrain_import_label_inventory_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportLabelInventoryRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportLabelInventoryResponse:
        """
        @summary 集成盘点数据
        
        @param request: HrbrainImportLabelInventoryRequest
        @return: HrbrainImportLabelInventoryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportLabelInventoryHeaders()
        return await self.hrbrain_import_label_inventory_with_options_async(request, headers, runtime)

    def hrbrain_import_label_prof_skill_with_options(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportLabelProfSkillRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainImportLabelProfSkillHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportLabelProfSkillResponse:
        """
        @summary 集成专业技能
        
        @param request: HrbrainImportLabelProfSkillRequest
        @param headers: HrbrainImportLabelProfSkillHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrbrainImportLabelProfSkillResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=UtilClient.to_array(request.body)
        )
        params = open_api_models.Params(
            action='HrbrainImportLabelProfSkill',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/profSkills/import',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.HrbrainImportLabelProfSkillResponse(),
            self.execute(params, req, runtime)
        )

    async def hrbrain_import_label_prof_skill_with_options_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportLabelProfSkillRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainImportLabelProfSkillHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportLabelProfSkillResponse:
        """
        @summary 集成专业技能
        
        @param request: HrbrainImportLabelProfSkillRequest
        @param headers: HrbrainImportLabelProfSkillHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrbrainImportLabelProfSkillResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=UtilClient.to_array(request.body)
        )
        params = open_api_models.Params(
            action='HrbrainImportLabelProfSkill',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/profSkills/import',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.HrbrainImportLabelProfSkillResponse(),
            await self.execute_async(params, req, runtime)
        )

    def hrbrain_import_label_prof_skill(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportLabelProfSkillRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportLabelProfSkillResponse:
        """
        @summary 集成专业技能
        
        @param request: HrbrainImportLabelProfSkillRequest
        @return: HrbrainImportLabelProfSkillResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportLabelProfSkillHeaders()
        return self.hrbrain_import_label_prof_skill_with_options(request, headers, runtime)

    async def hrbrain_import_label_prof_skill_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportLabelProfSkillRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportLabelProfSkillResponse:
        """
        @summary 集成专业技能
        
        @param request: HrbrainImportLabelProfSkillRequest
        @return: HrbrainImportLabelProfSkillResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportLabelProfSkillHeaders()
        return await self.hrbrain_import_label_prof_skill_with_options_async(request, headers, runtime)

    def hrbrain_import_perf_eval_with_options(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportPerfEvalRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainImportPerfEvalHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportPerfEvalResponse:
        """
        @summary 集成绩效记录
        
        @param request: HrbrainImportPerfEvalRequest
        @param headers: HrbrainImportPerfEvalHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrbrainImportPerfEvalResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=UtilClient.to_array(request.body)
        )
        params = open_api_models.Params(
            action='HrbrainImportPerfEval',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/perfRecords/import',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.HrbrainImportPerfEvalResponse(),
            self.execute(params, req, runtime)
        )

    async def hrbrain_import_perf_eval_with_options_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportPerfEvalRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainImportPerfEvalHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportPerfEvalResponse:
        """
        @summary 集成绩效记录
        
        @param request: HrbrainImportPerfEvalRequest
        @param headers: HrbrainImportPerfEvalHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrbrainImportPerfEvalResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=UtilClient.to_array(request.body)
        )
        params = open_api_models.Params(
            action='HrbrainImportPerfEval',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/perfRecords/import',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.HrbrainImportPerfEvalResponse(),
            await self.execute_async(params, req, runtime)
        )

    def hrbrain_import_perf_eval(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportPerfEvalRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportPerfEvalResponse:
        """
        @summary 集成绩效记录
        
        @param request: HrbrainImportPerfEvalRequest
        @return: HrbrainImportPerfEvalResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportPerfEvalHeaders()
        return self.hrbrain_import_perf_eval_with_options(request, headers, runtime)

    async def hrbrain_import_perf_eval_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportPerfEvalRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportPerfEvalResponse:
        """
        @summary 集成绩效记录
        
        @param request: HrbrainImportPerfEvalRequest
        @return: HrbrainImportPerfEvalResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportPerfEvalHeaders()
        return await self.hrbrain_import_perf_eval_with_options_async(request, headers, runtime)

    def hrbrain_import_prom_eval_with_options(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportPromEvalRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainImportPromEvalHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportPromEvalResponse:
        """
        @summary 集成晋升记录
        
        @param request: HrbrainImportPromEvalRequest
        @param headers: HrbrainImportPromEvalHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrbrainImportPromEvalResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=UtilClient.to_array(request.body)
        )
        params = open_api_models.Params(
            action='HrbrainImportPromEval',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/promRecords/import',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.HrbrainImportPromEvalResponse(),
            self.execute(params, req, runtime)
        )

    async def hrbrain_import_prom_eval_with_options_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportPromEvalRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainImportPromEvalHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportPromEvalResponse:
        """
        @summary 集成晋升记录
        
        @param request: HrbrainImportPromEvalRequest
        @param headers: HrbrainImportPromEvalHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrbrainImportPromEvalResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=UtilClient.to_array(request.body)
        )
        params = open_api_models.Params(
            action='HrbrainImportPromEval',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/promRecords/import',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.HrbrainImportPromEvalResponse(),
            await self.execute_async(params, req, runtime)
        )

    def hrbrain_import_prom_eval(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportPromEvalRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportPromEvalResponse:
        """
        @summary 集成晋升记录
        
        @param request: HrbrainImportPromEvalRequest
        @return: HrbrainImportPromEvalResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportPromEvalHeaders()
        return self.hrbrain_import_prom_eval_with_options(request, headers, runtime)

    async def hrbrain_import_prom_eval_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportPromEvalRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportPromEvalResponse:
        """
        @summary 集成晋升记录
        
        @param request: HrbrainImportPromEvalRequest
        @return: HrbrainImportPromEvalResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportPromEvalHeaders()
        return await self.hrbrain_import_prom_eval_with_options_async(request, headers, runtime)

    def hrbrain_import_pun_detail_with_options(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportPunDetailRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainImportPunDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportPunDetailResponse:
        """
        @summary 集成处分记录
        
        @param request: HrbrainImportPunDetailRequest
        @param headers: HrbrainImportPunDetailHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrbrainImportPunDetailResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=UtilClient.to_array(request.body)
        )
        params = open_api_models.Params(
            action='HrbrainImportPunDetail',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/punDetails/import',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.HrbrainImportPunDetailResponse(),
            self.execute(params, req, runtime)
        )

    async def hrbrain_import_pun_detail_with_options_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportPunDetailRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainImportPunDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportPunDetailResponse:
        """
        @summary 集成处分记录
        
        @param request: HrbrainImportPunDetailRequest
        @param headers: HrbrainImportPunDetailHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrbrainImportPunDetailResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=UtilClient.to_array(request.body)
        )
        params = open_api_models.Params(
            action='HrbrainImportPunDetail',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/punDetails/import',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.HrbrainImportPunDetailResponse(),
            await self.execute_async(params, req, runtime)
        )

    def hrbrain_import_pun_detail(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportPunDetailRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportPunDetailResponse:
        """
        @summary 集成处分记录
        
        @param request: HrbrainImportPunDetailRequest
        @return: HrbrainImportPunDetailResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportPunDetailHeaders()
        return self.hrbrain_import_pun_detail_with_options(request, headers, runtime)

    async def hrbrain_import_pun_detail_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportPunDetailRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportPunDetailResponse:
        """
        @summary 集成处分记录
        
        @param request: HrbrainImportPunDetailRequest
        @return: HrbrainImportPunDetailResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportPunDetailHeaders()
        return await self.hrbrain_import_pun_detail_with_options_async(request, headers, runtime)

    def hrbrain_import_regist_with_options(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportRegistRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainImportRegistHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportRegistResponse:
        """
        @summary 集成入职信息
        
        @param request: HrbrainImportRegistRequest
        @param headers: HrbrainImportRegistHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrbrainImportRegistResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=UtilClient.to_array(request.body)
        )
        params = open_api_models.Params(
            action='HrbrainImportRegist',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/registerInfos/import',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.HrbrainImportRegistResponse(),
            self.execute(params, req, runtime)
        )

    async def hrbrain_import_regist_with_options_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportRegistRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainImportRegistHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportRegistResponse:
        """
        @summary 集成入职信息
        
        @param request: HrbrainImportRegistRequest
        @param headers: HrbrainImportRegistHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrbrainImportRegistResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=UtilClient.to_array(request.body)
        )
        params = open_api_models.Params(
            action='HrbrainImportRegist',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/registerInfos/import',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.HrbrainImportRegistResponse(),
            await self.execute_async(params, req, runtime)
        )

    def hrbrain_import_regist(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportRegistRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportRegistResponse:
        """
        @summary 集成入职信息
        
        @param request: HrbrainImportRegistRequest
        @return: HrbrainImportRegistResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportRegistHeaders()
        return self.hrbrain_import_regist_with_options(request, headers, runtime)

    async def hrbrain_import_regist_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportRegistRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportRegistResponse:
        """
        @summary 集成入职信息
        
        @param request: HrbrainImportRegistRequest
        @return: HrbrainImportRegistResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportRegistHeaders()
        return await self.hrbrain_import_regist_with_options_async(request, headers, runtime)

    def hrbrain_import_transfer_eval_with_options(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportTransferEvalRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainImportTransferEvalHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportTransferEvalResponse:
        """
        @summary 集成异动记录
        
        @param request: HrbrainImportTransferEvalRequest
        @param headers: HrbrainImportTransferEvalHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrbrainImportTransferEvalResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=UtilClient.to_array(request.body)
        )
        params = open_api_models.Params(
            action='HrbrainImportTransferEval',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/changeRecords/import',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.HrbrainImportTransferEvalResponse(),
            self.execute(params, req, runtime)
        )

    async def hrbrain_import_transfer_eval_with_options_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportTransferEvalRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainImportTransferEvalHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportTransferEvalResponse:
        """
        @summary 集成异动记录
        
        @param request: HrbrainImportTransferEvalRequest
        @param headers: HrbrainImportTransferEvalHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrbrainImportTransferEvalResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=UtilClient.to_array(request.body)
        )
        params = open_api_models.Params(
            action='HrbrainImportTransferEval',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/changeRecords/import',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.HrbrainImportTransferEvalResponse(),
            await self.execute_async(params, req, runtime)
        )

    def hrbrain_import_transfer_eval(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportTransferEvalRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportTransferEvalResponse:
        """
        @summary 集成异动记录
        
        @param request: HrbrainImportTransferEvalRequest
        @return: HrbrainImportTransferEvalResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportTransferEvalHeaders()
        return self.hrbrain_import_transfer_eval_with_options(request, headers, runtime)

    async def hrbrain_import_transfer_eval_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportTransferEvalRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportTransferEvalResponse:
        """
        @summary 集成异动记录
        
        @param request: HrbrainImportTransferEvalRequest
        @return: HrbrainImportTransferEvalResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportTransferEvalHeaders()
        return await self.hrbrain_import_transfer_eval_with_options_async(request, headers, runtime)

    def hrbrain_import_work_exp_with_options(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportWorkExpRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainImportWorkExpHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportWorkExpResponse:
        """
        @summary 集成工作经历
        
        @param request: HrbrainImportWorkExpRequest
        @param headers: HrbrainImportWorkExpHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrbrainImportWorkExpResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=UtilClient.to_array(request.body)
        )
        params = open_api_models.Params(
            action='HrbrainImportWorkExp',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/workExperiences/import',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.HrbrainImportWorkExpResponse(),
            self.execute(params, req, runtime)
        )

    async def hrbrain_import_work_exp_with_options_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportWorkExpRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainImportWorkExpHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportWorkExpResponse:
        """
        @summary 集成工作经历
        
        @param request: HrbrainImportWorkExpRequest
        @param headers: HrbrainImportWorkExpHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HrbrainImportWorkExpResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=UtilClient.to_array(request.body)
        )
        params = open_api_models.Params(
            action='HrbrainImportWorkExp',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/workExperiences/import',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.HrbrainImportWorkExpResponse(),
            await self.execute_async(params, req, runtime)
        )

    def hrbrain_import_work_exp(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportWorkExpRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportWorkExpResponse:
        """
        @summary 集成工作经历
        
        @param request: HrbrainImportWorkExpRequest
        @return: HrbrainImportWorkExpResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportWorkExpHeaders()
        return self.hrbrain_import_work_exp_with_options(request, headers, runtime)

    async def hrbrain_import_work_exp_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportWorkExpRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportWorkExpResponse:
        """
        @summary 集成工作经历
        
        @param request: HrbrainImportWorkExpRequest
        @return: HrbrainImportWorkExpResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportWorkExpHeaders()
        return await self.hrbrain_import_work_exp_with_options_async(request, headers, runtime)

    def staff_label_records_query_with_options(
        self,
        request: dingtalkhrbrain__1__0_models.StaffLabelRecordsQueryRequest,
        headers: dingtalkhrbrain__1__0_models.StaffLabelRecordsQueryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.StaffLabelRecordsQueryResponse:
        """
        @summary 人员标签查询
        
        @param request: StaffLabelRecordsQueryRequest
        @param headers: StaffLabelRecordsQueryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: StaffLabelRecordsQueryResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.ding_corp_id):
            query['dingCorpId'] = request.ding_corp_id
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=UtilClient.to_array(request.body)
        )
        params = open_api_models.Params(
            action='StaffLabelRecordsQuery',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/labelRecords/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.StaffLabelRecordsQueryResponse(),
            self.execute(params, req, runtime)
        )

    async def staff_label_records_query_with_options_async(
        self,
        request: dingtalkhrbrain__1__0_models.StaffLabelRecordsQueryRequest,
        headers: dingtalkhrbrain__1__0_models.StaffLabelRecordsQueryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.StaffLabelRecordsQueryResponse:
        """
        @summary 人员标签查询
        
        @param request: StaffLabelRecordsQueryRequest
        @param headers: StaffLabelRecordsQueryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: StaffLabelRecordsQueryResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.ding_corp_id):
            query['dingCorpId'] = request.ding_corp_id
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=UtilClient.to_array(request.body)
        )
        params = open_api_models.Params(
            action='StaffLabelRecordsQuery',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas/labelRecords/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.StaffLabelRecordsQueryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def staff_label_records_query(
        self,
        request: dingtalkhrbrain__1__0_models.StaffLabelRecordsQueryRequest,
    ) -> dingtalkhrbrain__1__0_models.StaffLabelRecordsQueryResponse:
        """
        @summary 人员标签查询
        
        @param request: StaffLabelRecordsQueryRequest
        @return: StaffLabelRecordsQueryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.StaffLabelRecordsQueryHeaders()
        return self.staff_label_records_query_with_options(request, headers, runtime)

    async def staff_label_records_query_async(
        self,
        request: dingtalkhrbrain__1__0_models.StaffLabelRecordsQueryRequest,
    ) -> dingtalkhrbrain__1__0_models.StaffLabelRecordsQueryResponse:
        """
        @summary 人员标签查询
        
        @param request: StaffLabelRecordsQueryRequest
        @return: StaffLabelRecordsQueryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.StaffLabelRecordsQueryHeaders()
        return await self.staff_label_records_query_with_options_async(request, headers, runtime)

    def sync_data_with_options(
        self,
        request: dingtalkhrbrain__1__0_models.SyncDataRequest,
        headers: dingtalkhrbrain__1__0_models.SyncDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.SyncDataResponse:
        """
        @summary 同步统计基础数据
        
        @param request: SyncDataRequest
        @param headers: SyncDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SyncDataResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.data_id):
            body['dataId'] = request.data_id
        if not UtilClient.is_unset(request.etl_time):
            body['etlTime'] = request.etl_time
        if not UtilClient.is_unset(request.project_id):
            body['projectId'] = request.project_id
        if not UtilClient.is_unset(request.schema_id):
            body['schemaId'] = request.schema_id
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
            action='SyncData',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.SyncDataResponse(),
            self.execute(params, req, runtime)
        )

    async def sync_data_with_options_async(
        self,
        request: dingtalkhrbrain__1__0_models.SyncDataRequest,
        headers: dingtalkhrbrain__1__0_models.SyncDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.SyncDataResponse:
        """
        @summary 同步统计基础数据
        
        @param request: SyncDataRequest
        @param headers: SyncDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SyncDataResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.data_id):
            body['dataId'] = request.data_id
        if not UtilClient.is_unset(request.etl_time):
            body['etlTime'] = request.etl_time
        if not UtilClient.is_unset(request.project_id):
            body['projectId'] = request.project_id
        if not UtilClient.is_unset(request.schema_id):
            body['schemaId'] = request.schema_id
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
            action='SyncData',
            version='hrbrain_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/hrbrain/datas',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkhrbrain__1__0_models.SyncDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def sync_data(
        self,
        request: dingtalkhrbrain__1__0_models.SyncDataRequest,
    ) -> dingtalkhrbrain__1__0_models.SyncDataResponse:
        """
        @summary 同步统计基础数据
        
        @param request: SyncDataRequest
        @return: SyncDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.SyncDataHeaders()
        return self.sync_data_with_options(request, headers, runtime)

    async def sync_data_async(
        self,
        request: dingtalkhrbrain__1__0_models.SyncDataRequest,
    ) -> dingtalkhrbrain__1__0_models.SyncDataResponse:
        """
        @summary 同步统计基础数据
        
        @param request: SyncDataRequest
        @return: SyncDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.SyncDataHeaders()
        return await self.sync_data_with_options_async(request, headers, runtime)
