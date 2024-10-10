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
        self._product_id = 'dingtalk'
        gateway_client = GatewayClientClient()
        self._spi = gateway_client
        self._endpoint_rule = ''
        if UtilClient.empty(self._endpoint):
            self._endpoint = 'api.dingtalk.com'

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
