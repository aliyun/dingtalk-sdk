# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.chengfeng_1_0 import models as dingtalkchengfeng__1__0_models
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

    def get_all_job_level_with_options(
        self,
        headers: dingtalkchengfeng__1__0_models.GetAllJobLevelHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.GetAllJobLevelResponse:
        """
        @summary 获取组织下的全部职级
        
        @param headers: GetAllJobLevelHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAllJobLevelResponse
        """
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetAllJobLevel',
            version='chengfeng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/chengfeng/jobLevels',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.GetAllJobLevelResponse(),
            self.execute(params, req, runtime)
        )

    async def get_all_job_level_with_options_async(
        self,
        headers: dingtalkchengfeng__1__0_models.GetAllJobLevelHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.GetAllJobLevelResponse:
        """
        @summary 获取组织下的全部职级
        
        @param headers: GetAllJobLevelHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAllJobLevelResponse
        """
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetAllJobLevel',
            version='chengfeng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/chengfeng/jobLevels',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.GetAllJobLevelResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_all_job_level(self) -> dingtalkchengfeng__1__0_models.GetAllJobLevelResponse:
        """
        @summary 获取组织下的全部职级
        
        @return: GetAllJobLevelResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.GetAllJobLevelHeaders()
        return self.get_all_job_level_with_options(headers, runtime)

    async def get_all_job_level_async(self) -> dingtalkchengfeng__1__0_models.GetAllJobLevelResponse:
        """
        @summary 获取组织下的全部职级
        
        @return: GetAllJobLevelResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.GetAllJobLevelHeaders()
        return await self.get_all_job_level_with_options_async(headers, runtime)

    def get_all_job_position_with_options(
        self,
        headers: dingtalkchengfeng__1__0_models.GetAllJobPositionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.GetAllJobPositionResponse:
        """
        @summary 获取公司全部职位
        
        @param headers: GetAllJobPositionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAllJobPositionResponse
        """
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetAllJobPosition',
            version='chengfeng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/chengfeng/jobPositions',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.GetAllJobPositionResponse(),
            self.execute(params, req, runtime)
        )

    async def get_all_job_position_with_options_async(
        self,
        headers: dingtalkchengfeng__1__0_models.GetAllJobPositionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.GetAllJobPositionResponse:
        """
        @summary 获取公司全部职位
        
        @param headers: GetAllJobPositionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAllJobPositionResponse
        """
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetAllJobPosition',
            version='chengfeng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/chengfeng/jobPositions',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.GetAllJobPositionResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_all_job_position(self) -> dingtalkchengfeng__1__0_models.GetAllJobPositionResponse:
        """
        @summary 获取公司全部职位
        
        @return: GetAllJobPositionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.GetAllJobPositionHeaders()
        return self.get_all_job_position_with_options(headers, runtime)

    async def get_all_job_position_async(self) -> dingtalkchengfeng__1__0_models.GetAllJobPositionResponse:
        """
        @summary 获取公司全部职位
        
        @return: GetAllJobPositionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.GetAllJobPositionHeaders()
        return await self.get_all_job_position_with_options_async(headers, runtime)

    def get_all_job_post_with_options(
        self,
        headers: dingtalkchengfeng__1__0_models.GetAllJobPostHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.GetAllJobPostResponse:
        """
        @summary 获取组织下的所有职务
        
        @param headers: GetAllJobPostHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAllJobPostResponse
        """
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetAllJobPost',
            version='chengfeng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/chengfeng/jobPosts',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.GetAllJobPostResponse(),
            self.execute(params, req, runtime)
        )

    async def get_all_job_post_with_options_async(
        self,
        headers: dingtalkchengfeng__1__0_models.GetAllJobPostHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.GetAllJobPostResponse:
        """
        @summary 获取组织下的所有职务
        
        @param headers: GetAllJobPostHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAllJobPostResponse
        """
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetAllJobPost',
            version='chengfeng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/chengfeng/jobPosts',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.GetAllJobPostResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_all_job_post(self) -> dingtalkchengfeng__1__0_models.GetAllJobPostResponse:
        """
        @summary 获取组织下的所有职务
        
        @return: GetAllJobPostResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.GetAllJobPostHeaders()
        return self.get_all_job_post_with_options(headers, runtime)

    async def get_all_job_post_async(self) -> dingtalkchengfeng__1__0_models.GetAllJobPostResponse:
        """
        @summary 获取组织下的所有职务
        
        @return: GetAllJobPostResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.GetAllJobPostHeaders()
        return await self.get_all_job_post_with_options_async(headers, runtime)

    def get_analyze_data_with_options(
        self,
        request: dingtalkchengfeng__1__0_models.GetAnalyzeDataRequest,
        headers: dingtalkchengfeng__1__0_models.GetAnalyzeDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.GetAnalyzeDataResponse:
        """
        @summary 获取分析运营数据
        
        @param request: GetAnalyzeDataRequest
        @param headers: GetAnalyzeDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAnalyzeDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
        body = {}
        if not UtilClient.is_unset(request.period_ids):
            body['periodIds'] = request.period_ids
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='GetAnalyzeData',
            version='chengfeng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/chengfeng/okr/analyses/datas/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.GetAnalyzeDataResponse(),
            self.execute(params, req, runtime)
        )

    async def get_analyze_data_with_options_async(
        self,
        request: dingtalkchengfeng__1__0_models.GetAnalyzeDataRequest,
        headers: dingtalkchengfeng__1__0_models.GetAnalyzeDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.GetAnalyzeDataResponse:
        """
        @summary 获取分析运营数据
        
        @param request: GetAnalyzeDataRequest
        @param headers: GetAnalyzeDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAnalyzeDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
        body = {}
        if not UtilClient.is_unset(request.period_ids):
            body['periodIds'] = request.period_ids
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='GetAnalyzeData',
            version='chengfeng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/chengfeng/okr/analyses/datas/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.GetAnalyzeDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_analyze_data(
        self,
        request: dingtalkchengfeng__1__0_models.GetAnalyzeDataRequest,
    ) -> dingtalkchengfeng__1__0_models.GetAnalyzeDataResponse:
        """
        @summary 获取分析运营数据
        
        @param request: GetAnalyzeDataRequest
        @return: GetAnalyzeDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.GetAnalyzeDataHeaders()
        return self.get_analyze_data_with_options(request, headers, runtime)

    async def get_analyze_data_async(
        self,
        request: dingtalkchengfeng__1__0_models.GetAnalyzeDataRequest,
    ) -> dingtalkchengfeng__1__0_models.GetAnalyzeDataResponse:
        """
        @summary 获取分析运营数据
        
        @param request: GetAnalyzeDataRequest
        @return: GetAnalyzeDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.GetAnalyzeDataHeaders()
        return await self.get_analyze_data_with_options_async(request, headers, runtime)

    def get_child_org_list_with_options(
        self,
        request: dingtalkchengfeng__1__0_models.GetChildOrgListRequest,
        headers: dingtalkchengfeng__1__0_models.GetChildOrgListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.GetChildOrgListResponse:
        """
        @summary 根据部门编码查询下组织列表
        
        @param request: GetChildOrgListRequest
        @param headers: GetChildOrgListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetChildOrgListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_code):
            query['deptCode'] = request.dept_code
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
            action='GetChildOrgList',
            version='chengfeng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/chengfeng/organizations',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.GetChildOrgListResponse(),
            self.execute(params, req, runtime)
        )

    async def get_child_org_list_with_options_async(
        self,
        request: dingtalkchengfeng__1__0_models.GetChildOrgListRequest,
        headers: dingtalkchengfeng__1__0_models.GetChildOrgListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.GetChildOrgListResponse:
        """
        @summary 根据部门编码查询下组织列表
        
        @param request: GetChildOrgListRequest
        @param headers: GetChildOrgListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetChildOrgListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_code):
            query['deptCode'] = request.dept_code
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
            action='GetChildOrgList',
            version='chengfeng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/chengfeng/organizations',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.GetChildOrgListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_child_org_list(
        self,
        request: dingtalkchengfeng__1__0_models.GetChildOrgListRequest,
    ) -> dingtalkchengfeng__1__0_models.GetChildOrgListResponse:
        """
        @summary 根据部门编码查询下组织列表
        
        @param request: GetChildOrgListRequest
        @return: GetChildOrgListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.GetChildOrgListHeaders()
        return self.get_child_org_list_with_options(request, headers, runtime)

    async def get_child_org_list_async(
        self,
        request: dingtalkchengfeng__1__0_models.GetChildOrgListRequest,
    ) -> dingtalkchengfeng__1__0_models.GetChildOrgListResponse:
        """
        @summary 根据部门编码查询下组织列表
        
        @param request: GetChildOrgListRequest
        @return: GetChildOrgListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.GetChildOrgListHeaders()
        return await self.get_child_org_list_with_options_async(request, headers, runtime)

    def get_employee_info_by_work_no_with_options(
        self,
        request: dingtalkchengfeng__1__0_models.GetEmployeeInfoByWorkNoRequest,
        headers: dingtalkchengfeng__1__0_models.GetEmployeeInfoByWorkNoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.GetEmployeeInfoByWorkNoResponse:
        """
        @summary 根据工号查询员工基础信息
        
        @param request: GetEmployeeInfoByWorkNoRequest
        @param headers: GetEmployeeInfoByWorkNoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetEmployeeInfoByWorkNoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.work_no):
            query['workNo'] = request.work_no
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
            action='GetEmployeeInfoByWorkNo',
            version='chengfeng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/chengfeng/workNumbers/employees',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.GetEmployeeInfoByWorkNoResponse(),
            self.execute(params, req, runtime)
        )

    async def get_employee_info_by_work_no_with_options_async(
        self,
        request: dingtalkchengfeng__1__0_models.GetEmployeeInfoByWorkNoRequest,
        headers: dingtalkchengfeng__1__0_models.GetEmployeeInfoByWorkNoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.GetEmployeeInfoByWorkNoResponse:
        """
        @summary 根据工号查询员工基础信息
        
        @param request: GetEmployeeInfoByWorkNoRequest
        @param headers: GetEmployeeInfoByWorkNoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetEmployeeInfoByWorkNoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.work_no):
            query['workNo'] = request.work_no
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
            action='GetEmployeeInfoByWorkNo',
            version='chengfeng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/chengfeng/workNumbers/employees',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.GetEmployeeInfoByWorkNoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_employee_info_by_work_no(
        self,
        request: dingtalkchengfeng__1__0_models.GetEmployeeInfoByWorkNoRequest,
    ) -> dingtalkchengfeng__1__0_models.GetEmployeeInfoByWorkNoResponse:
        """
        @summary 根据工号查询员工基础信息
        
        @param request: GetEmployeeInfoByWorkNoRequest
        @return: GetEmployeeInfoByWorkNoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.GetEmployeeInfoByWorkNoHeaders()
        return self.get_employee_info_by_work_no_with_options(request, headers, runtime)

    async def get_employee_info_by_work_no_async(
        self,
        request: dingtalkchengfeng__1__0_models.GetEmployeeInfoByWorkNoRequest,
    ) -> dingtalkchengfeng__1__0_models.GetEmployeeInfoByWorkNoResponse:
        """
        @summary 根据工号查询员工基础信息
        
        @param request: GetEmployeeInfoByWorkNoRequest
        @return: GetEmployeeInfoByWorkNoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.GetEmployeeInfoByWorkNoHeaders()
        return await self.get_employee_info_by_work_no_with_options_async(request, headers, runtime)

    def get_employment_record_by_work_no_with_options(
        self,
        work_numbers: str,
        headers: dingtalkchengfeng__1__0_models.GetEmploymentRecordByWorkNoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.GetEmploymentRecordByWorkNoResponse:
        """
        @summary 根据人员工号查询人员任职记录
        
        @param headers: GetEmploymentRecordByWorkNoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetEmploymentRecordByWorkNoResponse
        """
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetEmploymentRecordByWorkNo',
            version='chengfeng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/chengfeng/users/workNumber/{work_numbers}employmentRecords',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.GetEmploymentRecordByWorkNoResponse(),
            self.execute(params, req, runtime)
        )

    async def get_employment_record_by_work_no_with_options_async(
        self,
        work_numbers: str,
        headers: dingtalkchengfeng__1__0_models.GetEmploymentRecordByWorkNoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.GetEmploymentRecordByWorkNoResponse:
        """
        @summary 根据人员工号查询人员任职记录
        
        @param headers: GetEmploymentRecordByWorkNoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetEmploymentRecordByWorkNoResponse
        """
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetEmploymentRecordByWorkNo',
            version='chengfeng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/chengfeng/users/workNumber/{work_numbers}employmentRecords',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.GetEmploymentRecordByWorkNoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_employment_record_by_work_no(
        self,
        work_numbers: str,
    ) -> dingtalkchengfeng__1__0_models.GetEmploymentRecordByWorkNoResponse:
        """
        @summary 根据人员工号查询人员任职记录
        
        @return: GetEmploymentRecordByWorkNoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.GetEmploymentRecordByWorkNoHeaders()
        return self.get_employment_record_by_work_no_with_options(work_numbers, headers, runtime)

    async def get_employment_record_by_work_no_async(
        self,
        work_numbers: str,
    ) -> dingtalkchengfeng__1__0_models.GetEmploymentRecordByWorkNoResponse:
        """
        @summary 根据人员工号查询人员任职记录
        
        @return: GetEmploymentRecordByWorkNoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.GetEmploymentRecordByWorkNoHeaders()
        return await self.get_employment_record_by_work_no_with_options_async(work_numbers, headers, runtime)

    def get_job_position_with_options(
        self,
        request: dingtalkchengfeng__1__0_models.GetJobPositionRequest,
        headers: dingtalkchengfeng__1__0_models.GetJobPositionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.GetJobPositionResponse:
        """
        @summary 获取职位详情
        
        @param request: GetJobPositionRequest
        @param headers: GetJobPositionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetJobPositionResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.job_position_code):
            query['jobPositionCode'] = request.job_position_code
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
            action='GetJobPosition',
            version='chengfeng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/chengfeng/jobPositions/infos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.GetJobPositionResponse(),
            self.execute(params, req, runtime)
        )

    async def get_job_position_with_options_async(
        self,
        request: dingtalkchengfeng__1__0_models.GetJobPositionRequest,
        headers: dingtalkchengfeng__1__0_models.GetJobPositionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.GetJobPositionResponse:
        """
        @summary 获取职位详情
        
        @param request: GetJobPositionRequest
        @param headers: GetJobPositionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetJobPositionResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.job_position_code):
            query['jobPositionCode'] = request.job_position_code
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
            action='GetJobPosition',
            version='chengfeng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/chengfeng/jobPositions/infos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.GetJobPositionResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_job_position(
        self,
        request: dingtalkchengfeng__1__0_models.GetJobPositionRequest,
    ) -> dingtalkchengfeng__1__0_models.GetJobPositionResponse:
        """
        @summary 获取职位详情
        
        @param request: GetJobPositionRequest
        @return: GetJobPositionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.GetJobPositionHeaders()
        return self.get_job_position_with_options(request, headers, runtime)

    async def get_job_position_async(
        self,
        request: dingtalkchengfeng__1__0_models.GetJobPositionRequest,
    ) -> dingtalkchengfeng__1__0_models.GetJobPositionResponse:
        """
        @summary 获取职位详情
        
        @param request: GetJobPositionRequest
        @return: GetJobPositionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.GetJobPositionHeaders()
        return await self.get_job_position_with_options_async(request, headers, runtime)

    def get_job_post_with_options(
        self,
        request: dingtalkchengfeng__1__0_models.GetJobPostRequest,
        headers: dingtalkchengfeng__1__0_models.GetJobPostHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.GetJobPostResponse:
        """
        @summary 根据编码获取职位详情
        
        @param request: GetJobPostRequest
        @param headers: GetJobPostHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetJobPostResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.job_post_code):
            query['jobPostCode'] = request.job_post_code
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
            action='GetJobPost',
            version='chengfeng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/chengfeng/jobPosts/infos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.GetJobPostResponse(),
            self.execute(params, req, runtime)
        )

    async def get_job_post_with_options_async(
        self,
        request: dingtalkchengfeng__1__0_models.GetJobPostRequest,
        headers: dingtalkchengfeng__1__0_models.GetJobPostHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.GetJobPostResponse:
        """
        @summary 根据编码获取职位详情
        
        @param request: GetJobPostRequest
        @param headers: GetJobPostHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetJobPostResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.job_post_code):
            query['jobPostCode'] = request.job_post_code
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
            action='GetJobPost',
            version='chengfeng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/chengfeng/jobPosts/infos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.GetJobPostResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_job_post(
        self,
        request: dingtalkchengfeng__1__0_models.GetJobPostRequest,
    ) -> dingtalkchengfeng__1__0_models.GetJobPostResponse:
        """
        @summary 根据编码获取职位详情
        
        @param request: GetJobPostRequest
        @return: GetJobPostResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.GetJobPostHeaders()
        return self.get_job_post_with_options(request, headers, runtime)

    async def get_job_post_async(
        self,
        request: dingtalkchengfeng__1__0_models.GetJobPostRequest,
    ) -> dingtalkchengfeng__1__0_models.GetJobPostResponse:
        """
        @summary 根据编码获取职位详情
        
        @param request: GetJobPostRequest
        @return: GetJobPostResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.GetJobPostHeaders()
        return await self.get_job_post_with_options_async(request, headers, runtime)

    def get_org_info_with_options(
        self,
        request: dingtalkchengfeng__1__0_models.GetOrgInfoRequest,
        headers: dingtalkchengfeng__1__0_models.GetOrgInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.GetOrgInfoResponse:
        """
        @summary 获取组织详情
        
        @param request: GetOrgInfoRequest
        @param headers: GetOrgInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetOrgInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_code):
            query['deptCode'] = request.dept_code
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
            action='GetOrgInfo',
            version='chengfeng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/chengfeng/organizations/infos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.GetOrgInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def get_org_info_with_options_async(
        self,
        request: dingtalkchengfeng__1__0_models.GetOrgInfoRequest,
        headers: dingtalkchengfeng__1__0_models.GetOrgInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.GetOrgInfoResponse:
        """
        @summary 获取组织详情
        
        @param request: GetOrgInfoRequest
        @param headers: GetOrgInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetOrgInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_code):
            query['deptCode'] = request.dept_code
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
            action='GetOrgInfo',
            version='chengfeng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/chengfeng/organizations/infos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.GetOrgInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_org_info(
        self,
        request: dingtalkchengfeng__1__0_models.GetOrgInfoRequest,
    ) -> dingtalkchengfeng__1__0_models.GetOrgInfoResponse:
        """
        @summary 获取组织详情
        
        @param request: GetOrgInfoRequest
        @return: GetOrgInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.GetOrgInfoHeaders()
        return self.get_org_info_with_options(request, headers, runtime)

    async def get_org_info_async(
        self,
        request: dingtalkchengfeng__1__0_models.GetOrgInfoRequest,
    ) -> dingtalkchengfeng__1__0_models.GetOrgInfoResponse:
        """
        @summary 获取组织详情
        
        @param request: GetOrgInfoRequest
        @return: GetOrgInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.GetOrgInfoHeaders()
        return await self.get_org_info_with_options_async(request, headers, runtime)

    def get_staff_info_by_work_no_with_options(
        self,
        request: dingtalkchengfeng__1__0_models.GetStaffInfoByWorkNoRequest,
        headers: dingtalkchengfeng__1__0_models.GetStaffInfoByWorkNoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.GetStaffInfoByWorkNoResponse:
        """
        @summary 根据员工工号获取员工的基本信息
        
        @param request: GetStaffInfoByWorkNoRequest
        @param headers: GetStaffInfoByWorkNoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetStaffInfoByWorkNoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.work_numbers):
            query['workNumbers'] = request.work_numbers
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
            action='GetStaffInfoByWorkNo',
            version='chengfeng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/chengfeng/users',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.GetStaffInfoByWorkNoResponse(),
            self.execute(params, req, runtime)
        )

    async def get_staff_info_by_work_no_with_options_async(
        self,
        request: dingtalkchengfeng__1__0_models.GetStaffInfoByWorkNoRequest,
        headers: dingtalkchengfeng__1__0_models.GetStaffInfoByWorkNoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.GetStaffInfoByWorkNoResponse:
        """
        @summary 根据员工工号获取员工的基本信息
        
        @param request: GetStaffInfoByWorkNoRequest
        @param headers: GetStaffInfoByWorkNoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetStaffInfoByWorkNoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.work_numbers):
            query['workNumbers'] = request.work_numbers
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
            action='GetStaffInfoByWorkNo',
            version='chengfeng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/chengfeng/users',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.GetStaffInfoByWorkNoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_staff_info_by_work_no(
        self,
        request: dingtalkchengfeng__1__0_models.GetStaffInfoByWorkNoRequest,
    ) -> dingtalkchengfeng__1__0_models.GetStaffInfoByWorkNoResponse:
        """
        @summary 根据员工工号获取员工的基本信息
        
        @param request: GetStaffInfoByWorkNoRequest
        @return: GetStaffInfoByWorkNoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.GetStaffInfoByWorkNoHeaders()
        return self.get_staff_info_by_work_no_with_options(request, headers, runtime)

    async def get_staff_info_by_work_no_async(
        self,
        request: dingtalkchengfeng__1__0_models.GetStaffInfoByWorkNoRequest,
    ) -> dingtalkchengfeng__1__0_models.GetStaffInfoByWorkNoResponse:
        """
        @summary 根据员工工号获取员工的基本信息
        
        @param request: GetStaffInfoByWorkNoRequest
        @return: GetStaffInfoByWorkNoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.GetStaffInfoByWorkNoHeaders()
        return await self.get_staff_info_by_work_no_with_options_async(request, headers, runtime)

    def get_staff_page_query_with_options(
        self,
        request: dingtalkchengfeng__1__0_models.GetStaffPageQueryRequest,
        headers: dingtalkchengfeng__1__0_models.GetStaffPageQueryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.GetStaffPageQueryResponse:
        """
        @summary 分页查询员工信息
        
        @param request: GetStaffPageQueryRequest
        @param headers: GetStaffPageQueryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetStaffPageQueryResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_code):
            query['deptCode'] = request.dept_code
        if not UtilClient.is_unset(request.name):
            query['name'] = request.name
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.work_no):
            query['workNo'] = request.work_no
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
            action='GetStaffPageQuery',
            version='chengfeng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/chengfeng/users/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.GetStaffPageQueryResponse(),
            self.execute(params, req, runtime)
        )

    async def get_staff_page_query_with_options_async(
        self,
        request: dingtalkchengfeng__1__0_models.GetStaffPageQueryRequest,
        headers: dingtalkchengfeng__1__0_models.GetStaffPageQueryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.GetStaffPageQueryResponse:
        """
        @summary 分页查询员工信息
        
        @param request: GetStaffPageQueryRequest
        @param headers: GetStaffPageQueryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetStaffPageQueryResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_code):
            query['deptCode'] = request.dept_code
        if not UtilClient.is_unset(request.name):
            query['name'] = request.name
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.work_no):
            query['workNo'] = request.work_no
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
            action='GetStaffPageQuery',
            version='chengfeng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/chengfeng/users/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.GetStaffPageQueryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_staff_page_query(
        self,
        request: dingtalkchengfeng__1__0_models.GetStaffPageQueryRequest,
    ) -> dingtalkchengfeng__1__0_models.GetStaffPageQueryResponse:
        """
        @summary 分页查询员工信息
        
        @param request: GetStaffPageQueryRequest
        @return: GetStaffPageQueryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.GetStaffPageQueryHeaders()
        return self.get_staff_page_query_with_options(request, headers, runtime)

    async def get_staff_page_query_async(
        self,
        request: dingtalkchengfeng__1__0_models.GetStaffPageQueryRequest,
    ) -> dingtalkchengfeng__1__0_models.GetStaffPageQueryResponse:
        """
        @summary 分页查询员工信息
        
        @param request: GetStaffPageQueryRequest
        @return: GetStaffPageQueryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.GetStaffPageQueryHeaders()
        return await self.get_staff_page_query_with_options_async(request, headers, runtime)

    def get_user_with_options(
        self,
        request: dingtalkchengfeng__1__0_models.GetUserRequest,
        headers: dingtalkchengfeng__1__0_models.GetUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.GetUserResponse:
        """
        @summary 获取用户信息
        
        @param request: GetUserRequest
        @param headers: GetUserHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetUserResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.okr_user_id):
            query['okrUserId'] = request.okr_user_id
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
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
            action='GetUser',
            version='chengfeng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/chengfeng/okr/users',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.GetUserResponse(),
            self.execute(params, req, runtime)
        )

    async def get_user_with_options_async(
        self,
        request: dingtalkchengfeng__1__0_models.GetUserRequest,
        headers: dingtalkchengfeng__1__0_models.GetUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.GetUserResponse:
        """
        @summary 获取用户信息
        
        @param request: GetUserRequest
        @param headers: GetUserHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetUserResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.okr_user_id):
            query['okrUserId'] = request.okr_user_id
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
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
            action='GetUser',
            version='chengfeng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/chengfeng/okr/users',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.GetUserResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_user(
        self,
        request: dingtalkchengfeng__1__0_models.GetUserRequest,
    ) -> dingtalkchengfeng__1__0_models.GetUserResponse:
        """
        @summary 获取用户信息
        
        @param request: GetUserRequest
        @return: GetUserResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.GetUserHeaders()
        return self.get_user_with_options(request, headers, runtime)

    async def get_user_async(
        self,
        request: dingtalkchengfeng__1__0_models.GetUserRequest,
    ) -> dingtalkchengfeng__1__0_models.GetUserResponse:
        """
        @summary 获取用户信息
        
        @param request: GetUserRequest
        @return: GetUserResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.GetUserHeaders()
        return await self.get_user_with_options_async(request, headers, runtime)

    def list_analyze_periods_with_options(
        self,
        headers: dingtalkchengfeng__1__0_models.ListAnalyzePeriodsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.ListAnalyzePeriodsResponse:
        """
        @summary 运营数据分析下的周期列表
        
        @param headers: ListAnalyzePeriodsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListAnalyzePeriodsResponse
        """
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='ListAnalyzePeriods',
            version='chengfeng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/chengfeng/okr/analyses/periods',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.ListAnalyzePeriodsResponse(),
            self.execute(params, req, runtime)
        )

    async def list_analyze_periods_with_options_async(
        self,
        headers: dingtalkchengfeng__1__0_models.ListAnalyzePeriodsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.ListAnalyzePeriodsResponse:
        """
        @summary 运营数据分析下的周期列表
        
        @param headers: ListAnalyzePeriodsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListAnalyzePeriodsResponse
        """
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='ListAnalyzePeriods',
            version='chengfeng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/chengfeng/okr/analyses/periods',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.ListAnalyzePeriodsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_analyze_periods(self) -> dingtalkchengfeng__1__0_models.ListAnalyzePeriodsResponse:
        """
        @summary 运营数据分析下的周期列表
        
        @return: ListAnalyzePeriodsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.ListAnalyzePeriodsHeaders()
        return self.list_analyze_periods_with_options(headers, runtime)

    async def list_analyze_periods_async(self) -> dingtalkchengfeng__1__0_models.ListAnalyzePeriodsResponse:
        """
        @summary 运营数据分析下的周期列表
        
        @return: ListAnalyzePeriodsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.ListAnalyzePeriodsHeaders()
        return await self.list_analyze_periods_with_options_async(headers, runtime)

    def list_objective_by_ids_with_options(
        self,
        request: dingtalkchengfeng__1__0_models.ListObjectiveByIdsRequest,
        headers: dingtalkchengfeng__1__0_models.ListObjectiveByIdsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.ListObjectiveByIdsResponse:
        """
        @summary 根据目标id批量获取目标列表
        
        @param request: ListObjectiveByIdsRequest
        @param headers: ListObjectiveByIdsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListObjectiveByIdsResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.objective_ids):
            body['objectiveIds'] = request.objective_ids
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
            action='ListObjectiveByIds',
            version='chengfeng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/chengfeng/okr/objectives/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.ListObjectiveByIdsResponse(),
            self.execute(params, req, runtime)
        )

    async def list_objective_by_ids_with_options_async(
        self,
        request: dingtalkchengfeng__1__0_models.ListObjectiveByIdsRequest,
        headers: dingtalkchengfeng__1__0_models.ListObjectiveByIdsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.ListObjectiveByIdsResponse:
        """
        @summary 根据目标id批量获取目标列表
        
        @param request: ListObjectiveByIdsRequest
        @param headers: ListObjectiveByIdsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListObjectiveByIdsResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.objective_ids):
            body['objectiveIds'] = request.objective_ids
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
            action='ListObjectiveByIds',
            version='chengfeng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/chengfeng/okr/objectives/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.ListObjectiveByIdsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_objective_by_ids(
        self,
        request: dingtalkchengfeng__1__0_models.ListObjectiveByIdsRequest,
    ) -> dingtalkchengfeng__1__0_models.ListObjectiveByIdsResponse:
        """
        @summary 根据目标id批量获取目标列表
        
        @param request: ListObjectiveByIdsRequest
        @return: ListObjectiveByIdsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.ListObjectiveByIdsHeaders()
        return self.list_objective_by_ids_with_options(request, headers, runtime)

    async def list_objective_by_ids_async(
        self,
        request: dingtalkchengfeng__1__0_models.ListObjectiveByIdsRequest,
    ) -> dingtalkchengfeng__1__0_models.ListObjectiveByIdsResponse:
        """
        @summary 根据目标id批量获取目标列表
        
        @param request: ListObjectiveByIdsRequest
        @return: ListObjectiveByIdsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.ListObjectiveByIdsHeaders()
        return await self.list_objective_by_ids_with_options_async(request, headers, runtime)

    def list_objective_by_user_with_options(
        self,
        request: dingtalkchengfeng__1__0_models.ListObjectiveByUserRequest,
        headers: dingtalkchengfeng__1__0_models.ListObjectiveByUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.ListObjectiveByUserResponse:
        """
        @summary 获取用户的 OKR 列表
        
        @param request: ListObjectiveByUserRequest
        @param headers: ListObjectiveByUserHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListObjectiveByUserResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
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
            action='ListObjectiveByUser',
            version='chengfeng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/chengfeng/okr/users/objectives',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.ListObjectiveByUserResponse(),
            self.execute(params, req, runtime)
        )

    async def list_objective_by_user_with_options_async(
        self,
        request: dingtalkchengfeng__1__0_models.ListObjectiveByUserRequest,
        headers: dingtalkchengfeng__1__0_models.ListObjectiveByUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.ListObjectiveByUserResponse:
        """
        @summary 获取用户的 OKR 列表
        
        @param request: ListObjectiveByUserRequest
        @param headers: ListObjectiveByUserHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListObjectiveByUserResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
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
            action='ListObjectiveByUser',
            version='chengfeng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/chengfeng/okr/users/objectives',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.ListObjectiveByUserResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_objective_by_user(
        self,
        request: dingtalkchengfeng__1__0_models.ListObjectiveByUserRequest,
    ) -> dingtalkchengfeng__1__0_models.ListObjectiveByUserResponse:
        """
        @summary 获取用户的 OKR 列表
        
        @param request: ListObjectiveByUserRequest
        @return: ListObjectiveByUserResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.ListObjectiveByUserHeaders()
        return self.list_objective_by_user_with_options(request, headers, runtime)

    async def list_objective_by_user_async(
        self,
        request: dingtalkchengfeng__1__0_models.ListObjectiveByUserRequest,
    ) -> dingtalkchengfeng__1__0_models.ListObjectiveByUserResponse:
        """
        @summary 获取用户的 OKR 列表
        
        @param request: ListObjectiveByUserRequest
        @return: ListObjectiveByUserResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.ListObjectiveByUserHeaders()
        return await self.list_objective_by_user_with_options_async(request, headers, runtime)

    def list_progress_by_ids_with_options(
        self,
        request: dingtalkchengfeng__1__0_models.ListProgressByIdsRequest,
        headers: dingtalkchengfeng__1__0_models.ListProgressByIdsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.ListProgressByIdsResponse:
        """
        @summary 根据进展id获取进展列表
        
        @param request: ListProgressByIdsRequest
        @param headers: ListProgressByIdsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListProgressByIdsResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.progress_ids):
            body['progressIds'] = request.progress_ids
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
            action='ListProgressByIds',
            version='chengfeng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/chengfeng/okr/objectives/progresses/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.ListProgressByIdsResponse(),
            self.execute(params, req, runtime)
        )

    async def list_progress_by_ids_with_options_async(
        self,
        request: dingtalkchengfeng__1__0_models.ListProgressByIdsRequest,
        headers: dingtalkchengfeng__1__0_models.ListProgressByIdsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.ListProgressByIdsResponse:
        """
        @summary 根据进展id获取进展列表
        
        @param request: ListProgressByIdsRequest
        @param headers: ListProgressByIdsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListProgressByIdsResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.progress_ids):
            body['progressIds'] = request.progress_ids
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
            action='ListProgressByIds',
            version='chengfeng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/chengfeng/okr/objectives/progresses/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.ListProgressByIdsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_progress_by_ids(
        self,
        request: dingtalkchengfeng__1__0_models.ListProgressByIdsRequest,
    ) -> dingtalkchengfeng__1__0_models.ListProgressByIdsResponse:
        """
        @summary 根据进展id获取进展列表
        
        @param request: ListProgressByIdsRequest
        @return: ListProgressByIdsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.ListProgressByIdsHeaders()
        return self.list_progress_by_ids_with_options(request, headers, runtime)

    async def list_progress_by_ids_async(
        self,
        request: dingtalkchengfeng__1__0_models.ListProgressByIdsRequest,
    ) -> dingtalkchengfeng__1__0_models.ListProgressByIdsResponse:
        """
        @summary 根据进展id获取进展列表
        
        @param request: ListProgressByIdsRequest
        @return: ListProgressByIdsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.ListProgressByIdsHeaders()
        return await self.list_progress_by_ids_with_options_async(request, headers, runtime)

    def list_sls_log_with_options(
        self,
        request: dingtalkchengfeng__1__0_models.ListSlsLogRequest,
        headers: dingtalkchengfeng__1__0_models.ListSlsLogHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.ListSlsLogResponse:
        """
        @summary 获取组织下的日志数据
        
        @param request: ListSlsLogRequest
        @param headers: ListSlsLogHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListSlsLogResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_code):
            query['appCode'] = request.app_code
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.start_time):
            query['startTime'] = request.start_time
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
            action='ListSlsLog',
            version='chengfeng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/chengfeng/organizations/slsLogDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.ListSlsLogResponse(),
            self.execute(params, req, runtime)
        )

    async def list_sls_log_with_options_async(
        self,
        request: dingtalkchengfeng__1__0_models.ListSlsLogRequest,
        headers: dingtalkchengfeng__1__0_models.ListSlsLogHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.ListSlsLogResponse:
        """
        @summary 获取组织下的日志数据
        
        @param request: ListSlsLogRequest
        @param headers: ListSlsLogHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListSlsLogResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_code):
            query['appCode'] = request.app_code
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.start_time):
            query['startTime'] = request.start_time
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
            action='ListSlsLog',
            version='chengfeng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/chengfeng/organizations/slsLogDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.ListSlsLogResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_sls_log(
        self,
        request: dingtalkchengfeng__1__0_models.ListSlsLogRequest,
    ) -> dingtalkchengfeng__1__0_models.ListSlsLogResponse:
        """
        @summary 获取组织下的日志数据
        
        @param request: ListSlsLogRequest
        @return: ListSlsLogResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.ListSlsLogHeaders()
        return self.list_sls_log_with_options(request, headers, runtime)

    async def list_sls_log_async(
        self,
        request: dingtalkchengfeng__1__0_models.ListSlsLogRequest,
    ) -> dingtalkchengfeng__1__0_models.ListSlsLogResponse:
        """
        @summary 获取组织下的日志数据
        
        @param request: ListSlsLogRequest
        @return: ListSlsLogResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.ListSlsLogHeaders()
        return await self.list_sls_log_with_options_async(request, headers, runtime)

    def page_list_objective_progress_with_options(
        self,
        request: dingtalkchengfeng__1__0_models.PageListObjectiveProgressRequest,
        headers: dingtalkchengfeng__1__0_models.PageListObjectiveProgressHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.PageListObjectiveProgressResponse:
        """
        @summary 分页获取目标进展记录
        
        @param request: PageListObjectiveProgressRequest
        @param headers: PageListObjectiveProgressHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PageListObjectiveProgressResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.objective_id):
            query['objectiveId'] = request.objective_id
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
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
            action='PageListObjectiveProgress',
            version='chengfeng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/chengfeng/okr/objectives/progresses/records',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.PageListObjectiveProgressResponse(),
            self.execute(params, req, runtime)
        )

    async def page_list_objective_progress_with_options_async(
        self,
        request: dingtalkchengfeng__1__0_models.PageListObjectiveProgressRequest,
        headers: dingtalkchengfeng__1__0_models.PageListObjectiveProgressHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.PageListObjectiveProgressResponse:
        """
        @summary 分页获取目标进展记录
        
        @param request: PageListObjectiveProgressRequest
        @param headers: PageListObjectiveProgressHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PageListObjectiveProgressResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.objective_id):
            query['objectiveId'] = request.objective_id
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
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
            action='PageListObjectiveProgress',
            version='chengfeng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/chengfeng/okr/objectives/progresses/records',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.PageListObjectiveProgressResponse(),
            await self.execute_async(params, req, runtime)
        )

    def page_list_objective_progress(
        self,
        request: dingtalkchengfeng__1__0_models.PageListObjectiveProgressRequest,
    ) -> dingtalkchengfeng__1__0_models.PageListObjectiveProgressResponse:
        """
        @summary 分页获取目标进展记录
        
        @param request: PageListObjectiveProgressRequest
        @return: PageListObjectiveProgressResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.PageListObjectiveProgressHeaders()
        return self.page_list_objective_progress_with_options(request, headers, runtime)

    async def page_list_objective_progress_async(
        self,
        request: dingtalkchengfeng__1__0_models.PageListObjectiveProgressRequest,
    ) -> dingtalkchengfeng__1__0_models.PageListObjectiveProgressResponse:
        """
        @summary 分页获取目标进展记录
        
        @param request: PageListObjectiveProgressRequest
        @return: PageListObjectiveProgressResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.PageListObjectiveProgressHeaders()
        return await self.page_list_objective_progress_with_options_async(request, headers, runtime)

    def transfer_user_objective_with_options(
        self,
        request: dingtalkchengfeng__1__0_models.TransferUserObjectiveRequest,
        headers: dingtalkchengfeng__1__0_models.TransferUserObjectiveHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.TransferUserObjectiveResponse:
        """
        @summary 转交目标OKR
        
        @param request: TransferUserObjectiveRequest
        @param headers: TransferUserObjectiveHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TransferUserObjectiveResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.objective_id):
            query['objectiveId'] = request.objective_id
        if not UtilClient.is_unset(request.target_user_id):
            query['targetUserId'] = request.target_user_id
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
            action='TransferUserObjective',
            version='chengfeng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/chengfeng/okr/objectives/transfer',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.TransferUserObjectiveResponse(),
            self.execute(params, req, runtime)
        )

    async def transfer_user_objective_with_options_async(
        self,
        request: dingtalkchengfeng__1__0_models.TransferUserObjectiveRequest,
        headers: dingtalkchengfeng__1__0_models.TransferUserObjectiveHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.TransferUserObjectiveResponse:
        """
        @summary 转交目标OKR
        
        @param request: TransferUserObjectiveRequest
        @param headers: TransferUserObjectiveHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TransferUserObjectiveResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.objective_id):
            query['objectiveId'] = request.objective_id
        if not UtilClient.is_unset(request.target_user_id):
            query['targetUserId'] = request.target_user_id
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
            action='TransferUserObjective',
            version='chengfeng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/chengfeng/okr/objectives/transfer',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.TransferUserObjectiveResponse(),
            await self.execute_async(params, req, runtime)
        )

    def transfer_user_objective(
        self,
        request: dingtalkchengfeng__1__0_models.TransferUserObjectiveRequest,
    ) -> dingtalkchengfeng__1__0_models.TransferUserObjectiveResponse:
        """
        @summary 转交目标OKR
        
        @param request: TransferUserObjectiveRequest
        @return: TransferUserObjectiveResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.TransferUserObjectiveHeaders()
        return self.transfer_user_objective_with_options(request, headers, runtime)

    async def transfer_user_objective_async(
        self,
        request: dingtalkchengfeng__1__0_models.TransferUserObjectiveRequest,
    ) -> dingtalkchengfeng__1__0_models.TransferUserObjectiveResponse:
        """
        @summary 转交目标OKR
        
        @param request: TransferUserObjectiveRequest
        @return: TransferUserObjectiveResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.TransferUserObjectiveHeaders()
        return await self.transfer_user_objective_with_options_async(request, headers, runtime)
