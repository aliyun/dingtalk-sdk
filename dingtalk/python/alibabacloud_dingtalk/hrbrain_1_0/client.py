# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_gateway_spi.client import Client as SPIClient
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

    def hrbrain_import_award_detail_with_options(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportAwardDetailRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainImportAwardDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportAwardDetailResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportAwardDetailHeaders()
        return self.hrbrain_import_award_detail_with_options(request, headers, runtime)

    async def hrbrain_import_award_detail_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportAwardDetailRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportAwardDetailResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportAwardDetailHeaders()
        return await self.hrbrain_import_award_detail_with_options_async(request, headers, runtime)

    def hrbrain_import_dept_info_with_options(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportDeptInfoRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainImportDeptInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportDeptInfoResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportDeptInfoHeaders()
        return self.hrbrain_import_dept_info_with_options(request, headers, runtime)

    async def hrbrain_import_dept_info_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportDeptInfoRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportDeptInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportDeptInfoHeaders()
        return await self.hrbrain_import_dept_info_with_options_async(request, headers, runtime)

    def hrbrain_import_dimission_with_options(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportDimissionRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainImportDimissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportDimissionResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportDimissionHeaders()
        return self.hrbrain_import_dimission_with_options(request, headers, runtime)

    async def hrbrain_import_dimission_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportDimissionRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportDimissionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportDimissionHeaders()
        return await self.hrbrain_import_dimission_with_options_async(request, headers, runtime)

    def hrbrain_import_edu_exp_with_options(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportEduExpRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainImportEduExpHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportEduExpResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportEduExpHeaders()
        return self.hrbrain_import_edu_exp_with_options(request, headers, runtime)

    async def hrbrain_import_edu_exp_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportEduExpRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportEduExpResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportEduExpHeaders()
        return await self.hrbrain_import_edu_exp_with_options_async(request, headers, runtime)

    def hrbrain_import_emp_info_with_options(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportEmpInfoRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainImportEmpInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportEmpInfoResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportEmpInfoHeaders()
        return self.hrbrain_import_emp_info_with_options(request, headers, runtime)

    async def hrbrain_import_emp_info_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportEmpInfoRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportEmpInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportEmpInfoHeaders()
        return await self.hrbrain_import_emp_info_with_options_async(request, headers, runtime)

    def hrbrain_import_label_base_with_options(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportLabelBaseRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainImportLabelBaseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportLabelBaseResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportLabelBaseHeaders()
        return self.hrbrain_import_label_base_with_options(request, headers, runtime)

    async def hrbrain_import_label_base_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportLabelBaseRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportLabelBaseResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportLabelBaseHeaders()
        return await self.hrbrain_import_label_base_with_options_async(request, headers, runtime)

    def hrbrain_import_label_custom_with_options(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportLabelCustomRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainImportLabelCustomHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportLabelCustomResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportLabelCustomHeaders()
        return self.hrbrain_import_label_custom_with_options(request, headers, runtime)

    async def hrbrain_import_label_custom_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportLabelCustomRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportLabelCustomResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportLabelCustomHeaders()
        return await self.hrbrain_import_label_custom_with_options_async(request, headers, runtime)

    def hrbrain_import_label_industry_with_options(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportLabelIndustryRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainImportLabelIndustryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportLabelIndustryResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportLabelIndustryHeaders()
        return self.hrbrain_import_label_industry_with_options(request, headers, runtime)

    async def hrbrain_import_label_industry_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportLabelIndustryRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportLabelIndustryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportLabelIndustryHeaders()
        return await self.hrbrain_import_label_industry_with_options_async(request, headers, runtime)

    def hrbrain_import_label_inventory_with_options(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportLabelInventoryRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainImportLabelInventoryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportLabelInventoryResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportLabelInventoryHeaders()
        return self.hrbrain_import_label_inventory_with_options(request, headers, runtime)

    async def hrbrain_import_label_inventory_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportLabelInventoryRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportLabelInventoryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportLabelInventoryHeaders()
        return await self.hrbrain_import_label_inventory_with_options_async(request, headers, runtime)

    def hrbrain_import_label_prof_skill_with_options(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportLabelProfSkillRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainImportLabelProfSkillHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportLabelProfSkillResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportLabelProfSkillHeaders()
        return self.hrbrain_import_label_prof_skill_with_options(request, headers, runtime)

    async def hrbrain_import_label_prof_skill_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportLabelProfSkillRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportLabelProfSkillResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportLabelProfSkillHeaders()
        return await self.hrbrain_import_label_prof_skill_with_options_async(request, headers, runtime)

    def hrbrain_import_perf_eval_with_options(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportPerfEvalRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainImportPerfEvalHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportPerfEvalResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportPerfEvalHeaders()
        return self.hrbrain_import_perf_eval_with_options(request, headers, runtime)

    async def hrbrain_import_perf_eval_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportPerfEvalRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportPerfEvalResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportPerfEvalHeaders()
        return await self.hrbrain_import_perf_eval_with_options_async(request, headers, runtime)

    def hrbrain_import_prom_eval_with_options(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportPromEvalRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainImportPromEvalHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportPromEvalResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportPromEvalHeaders()
        return self.hrbrain_import_prom_eval_with_options(request, headers, runtime)

    async def hrbrain_import_prom_eval_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportPromEvalRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportPromEvalResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportPromEvalHeaders()
        return await self.hrbrain_import_prom_eval_with_options_async(request, headers, runtime)

    def hrbrain_import_pun_detail_with_options(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportPunDetailRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainImportPunDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportPunDetailResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportPunDetailHeaders()
        return self.hrbrain_import_pun_detail_with_options(request, headers, runtime)

    async def hrbrain_import_pun_detail_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportPunDetailRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportPunDetailResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportPunDetailHeaders()
        return await self.hrbrain_import_pun_detail_with_options_async(request, headers, runtime)

    def hrbrain_import_regist_with_options(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportRegistRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainImportRegistHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportRegistResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportRegistHeaders()
        return self.hrbrain_import_regist_with_options(request, headers, runtime)

    async def hrbrain_import_regist_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportRegistRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportRegistResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportRegistHeaders()
        return await self.hrbrain_import_regist_with_options_async(request, headers, runtime)

    def hrbrain_import_transfer_eval_with_options(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportTransferEvalRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainImportTransferEvalHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportTransferEvalResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportTransferEvalHeaders()
        return self.hrbrain_import_transfer_eval_with_options(request, headers, runtime)

    async def hrbrain_import_transfer_eval_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportTransferEvalRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportTransferEvalResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportTransferEvalHeaders()
        return await self.hrbrain_import_transfer_eval_with_options_async(request, headers, runtime)

    def hrbrain_import_work_exp_with_options(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportWorkExpRequest,
        headers: dingtalkhrbrain__1__0_models.HrbrainImportWorkExpHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportWorkExpResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportWorkExpHeaders()
        return self.hrbrain_import_work_exp_with_options(request, headers, runtime)

    async def hrbrain_import_work_exp_async(
        self,
        request: dingtalkhrbrain__1__0_models.HrbrainImportWorkExpRequest,
    ) -> dingtalkhrbrain__1__0_models.HrbrainImportWorkExpResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.HrbrainImportWorkExpHeaders()
        return await self.hrbrain_import_work_exp_with_options_async(request, headers, runtime)

    def sync_data_with_options(
        self,
        request: dingtalkhrbrain__1__0_models.SyncDataRequest,
        headers: dingtalkhrbrain__1__0_models.SyncDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrbrain__1__0_models.SyncDataResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.SyncDataHeaders()
        return self.sync_data_with_options(request, headers, runtime)

    async def sync_data_async(
        self,
        request: dingtalkhrbrain__1__0_models.SyncDataRequest,
    ) -> dingtalkhrbrain__1__0_models.SyncDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrbrain__1__0_models.SyncDataHeaders()
        return await self.sync_data_with_options_async(request, headers, runtime)
