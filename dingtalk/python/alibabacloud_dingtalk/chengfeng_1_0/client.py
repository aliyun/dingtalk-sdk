# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
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
        self._endpoint_rule = ''
        if UtilClient.empty(self._endpoint):
            self._endpoint = 'api.dingtalk.com'

    def get_all_job_level(self) -> dingtalkchengfeng__1__0_models.GetAllJobLevelResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.GetAllJobLevelHeaders()
        return self.get_all_job_level_with_options(headers, runtime)

    async def get_all_job_level_async(self) -> dingtalkchengfeng__1__0_models.GetAllJobLevelResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.GetAllJobLevelHeaders()
        return await self.get_all_job_level_with_options_async(headers, runtime)

    def get_all_job_level_with_options(
        self,
        headers: dingtalkchengfeng__1__0_models.GetAllJobLevelHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.GetAllJobLevelResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.GetAllJobLevelResponse(),
            self.do_roarequest('GetAllJobLevel', 'chengfeng_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/chengfeng/jobLevels', 'json', req, runtime)
        )

    async def get_all_job_level_with_options_async(
        self,
        headers: dingtalkchengfeng__1__0_models.GetAllJobLevelHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.GetAllJobLevelResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.GetAllJobLevelResponse(),
            await self.do_roarequest_async('GetAllJobLevel', 'chengfeng_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/chengfeng/jobLevels', 'json', req, runtime)
        )

    def get_all_job_position(self) -> dingtalkchengfeng__1__0_models.GetAllJobPositionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.GetAllJobPositionHeaders()
        return self.get_all_job_position_with_options(headers, runtime)

    async def get_all_job_position_async(self) -> dingtalkchengfeng__1__0_models.GetAllJobPositionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.GetAllJobPositionHeaders()
        return await self.get_all_job_position_with_options_async(headers, runtime)

    def get_all_job_position_with_options(
        self,
        headers: dingtalkchengfeng__1__0_models.GetAllJobPositionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.GetAllJobPositionResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.GetAllJobPositionResponse(),
            self.do_roarequest('GetAllJobPosition', 'chengfeng_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/chengfeng/jobPositions', 'json', req, runtime)
        )

    async def get_all_job_position_with_options_async(
        self,
        headers: dingtalkchengfeng__1__0_models.GetAllJobPositionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.GetAllJobPositionResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.GetAllJobPositionResponse(),
            await self.do_roarequest_async('GetAllJobPosition', 'chengfeng_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/chengfeng/jobPositions', 'json', req, runtime)
        )

    def get_all_job_post(self) -> dingtalkchengfeng__1__0_models.GetAllJobPostResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.GetAllJobPostHeaders()
        return self.get_all_job_post_with_options(headers, runtime)

    async def get_all_job_post_async(self) -> dingtalkchengfeng__1__0_models.GetAllJobPostResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.GetAllJobPostHeaders()
        return await self.get_all_job_post_with_options_async(headers, runtime)

    def get_all_job_post_with_options(
        self,
        headers: dingtalkchengfeng__1__0_models.GetAllJobPostHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.GetAllJobPostResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.GetAllJobPostResponse(),
            self.do_roarequest('GetAllJobPost', 'chengfeng_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/chengfeng/jobPosts', 'json', req, runtime)
        )

    async def get_all_job_post_with_options_async(
        self,
        headers: dingtalkchengfeng__1__0_models.GetAllJobPostHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.GetAllJobPostResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.GetAllJobPostResponse(),
            await self.do_roarequest_async('GetAllJobPost', 'chengfeng_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/chengfeng/jobPosts', 'json', req, runtime)
        )

    def get_analyze_data(
        self,
        request: dingtalkchengfeng__1__0_models.GetAnalyzeDataRequest,
    ) -> dingtalkchengfeng__1__0_models.GetAnalyzeDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.GetAnalyzeDataHeaders()
        return self.get_analyze_data_with_options(request, headers, runtime)

    async def get_analyze_data_async(
        self,
        request: dingtalkchengfeng__1__0_models.GetAnalyzeDataRequest,
    ) -> dingtalkchengfeng__1__0_models.GetAnalyzeDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.GetAnalyzeDataHeaders()
        return await self.get_analyze_data_with_options_async(request, headers, runtime)

    def get_analyze_data_with_options(
        self,
        request: dingtalkchengfeng__1__0_models.GetAnalyzeDataRequest,
        headers: dingtalkchengfeng__1__0_models.GetAnalyzeDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.GetAnalyzeDataResponse:
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
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.GetAnalyzeDataResponse(),
            self.do_roarequest('GetAnalyzeData', 'chengfeng_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/chengfeng/okr/analyses/datas/query', 'json', req, runtime)
        )

    async def get_analyze_data_with_options_async(
        self,
        request: dingtalkchengfeng__1__0_models.GetAnalyzeDataRequest,
        headers: dingtalkchengfeng__1__0_models.GetAnalyzeDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.GetAnalyzeDataResponse:
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
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.GetAnalyzeDataResponse(),
            await self.do_roarequest_async('GetAnalyzeData', 'chengfeng_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/chengfeng/okr/analyses/datas/query', 'json', req, runtime)
        )

    def get_child_org_list(
        self,
        request: dingtalkchengfeng__1__0_models.GetChildOrgListRequest,
    ) -> dingtalkchengfeng__1__0_models.GetChildOrgListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.GetChildOrgListHeaders()
        return self.get_child_org_list_with_options(request, headers, runtime)

    async def get_child_org_list_async(
        self,
        request: dingtalkchengfeng__1__0_models.GetChildOrgListRequest,
    ) -> dingtalkchengfeng__1__0_models.GetChildOrgListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.GetChildOrgListHeaders()
        return await self.get_child_org_list_with_options_async(request, headers, runtime)

    def get_child_org_list_with_options(
        self,
        request: dingtalkchengfeng__1__0_models.GetChildOrgListRequest,
        headers: dingtalkchengfeng__1__0_models.GetChildOrgListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.GetChildOrgListResponse:
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
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.GetChildOrgListResponse(),
            self.do_roarequest('GetChildOrgList', 'chengfeng_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/chengfeng/organizations', 'json', req, runtime)
        )

    async def get_child_org_list_with_options_async(
        self,
        request: dingtalkchengfeng__1__0_models.GetChildOrgListRequest,
        headers: dingtalkchengfeng__1__0_models.GetChildOrgListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.GetChildOrgListResponse:
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
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.GetChildOrgListResponse(),
            await self.do_roarequest_async('GetChildOrgList', 'chengfeng_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/chengfeng/organizations', 'json', req, runtime)
        )

    def get_employee_info_by_work_no(
        self,
        request: dingtalkchengfeng__1__0_models.GetEmployeeInfoByWorkNoRequest,
    ) -> dingtalkchengfeng__1__0_models.GetEmployeeInfoByWorkNoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.GetEmployeeInfoByWorkNoHeaders()
        return self.get_employee_info_by_work_no_with_options(request, headers, runtime)

    async def get_employee_info_by_work_no_async(
        self,
        request: dingtalkchengfeng__1__0_models.GetEmployeeInfoByWorkNoRequest,
    ) -> dingtalkchengfeng__1__0_models.GetEmployeeInfoByWorkNoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.GetEmployeeInfoByWorkNoHeaders()
        return await self.get_employee_info_by_work_no_with_options_async(request, headers, runtime)

    def get_employee_info_by_work_no_with_options(
        self,
        request: dingtalkchengfeng__1__0_models.GetEmployeeInfoByWorkNoRequest,
        headers: dingtalkchengfeng__1__0_models.GetEmployeeInfoByWorkNoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.GetEmployeeInfoByWorkNoResponse:
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
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.GetEmployeeInfoByWorkNoResponse(),
            self.do_roarequest('GetEmployeeInfoByWorkNo', 'chengfeng_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/chengfeng/workNumbers/employees', 'json', req, runtime)
        )

    async def get_employee_info_by_work_no_with_options_async(
        self,
        request: dingtalkchengfeng__1__0_models.GetEmployeeInfoByWorkNoRequest,
        headers: dingtalkchengfeng__1__0_models.GetEmployeeInfoByWorkNoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.GetEmployeeInfoByWorkNoResponse:
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
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.GetEmployeeInfoByWorkNoResponse(),
            await self.do_roarequest_async('GetEmployeeInfoByWorkNo', 'chengfeng_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/chengfeng/workNumbers/employees', 'json', req, runtime)
        )

    def get_employment_record_by_work_no(
        self,
        work_numbers: str,
    ) -> dingtalkchengfeng__1__0_models.GetEmploymentRecordByWorkNoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.GetEmploymentRecordByWorkNoHeaders()
        return self.get_employment_record_by_work_no_with_options(work_numbers, headers, runtime)

    async def get_employment_record_by_work_no_async(
        self,
        work_numbers: str,
    ) -> dingtalkchengfeng__1__0_models.GetEmploymentRecordByWorkNoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.GetEmploymentRecordByWorkNoHeaders()
        return await self.get_employment_record_by_work_no_with_options_async(work_numbers, headers, runtime)

    def get_employment_record_by_work_no_with_options(
        self,
        work_numbers: str,
        headers: dingtalkchengfeng__1__0_models.GetEmploymentRecordByWorkNoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.GetEmploymentRecordByWorkNoResponse:
        work_numbers = OpenApiUtilClient.get_encode_param(work_numbers)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.GetEmploymentRecordByWorkNoResponse(),
            self.do_roarequest('GetEmploymentRecordByWorkNo', 'chengfeng_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/chengfeng/users/workNumber/{work_numbers}employmentRecords', 'json', req, runtime)
        )

    async def get_employment_record_by_work_no_with_options_async(
        self,
        work_numbers: str,
        headers: dingtalkchengfeng__1__0_models.GetEmploymentRecordByWorkNoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.GetEmploymentRecordByWorkNoResponse:
        work_numbers = OpenApiUtilClient.get_encode_param(work_numbers)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.GetEmploymentRecordByWorkNoResponse(),
            await self.do_roarequest_async('GetEmploymentRecordByWorkNo', 'chengfeng_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/chengfeng/users/workNumber/{work_numbers}employmentRecords', 'json', req, runtime)
        )

    def get_job_position(
        self,
        request: dingtalkchengfeng__1__0_models.GetJobPositionRequest,
    ) -> dingtalkchengfeng__1__0_models.GetJobPositionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.GetJobPositionHeaders()
        return self.get_job_position_with_options(request, headers, runtime)

    async def get_job_position_async(
        self,
        request: dingtalkchengfeng__1__0_models.GetJobPositionRequest,
    ) -> dingtalkchengfeng__1__0_models.GetJobPositionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.GetJobPositionHeaders()
        return await self.get_job_position_with_options_async(request, headers, runtime)

    def get_job_position_with_options(
        self,
        request: dingtalkchengfeng__1__0_models.GetJobPositionRequest,
        headers: dingtalkchengfeng__1__0_models.GetJobPositionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.GetJobPositionResponse:
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
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.GetJobPositionResponse(),
            self.do_roarequest('GetJobPosition', 'chengfeng_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/chengfeng/jobPositions/infos', 'json', req, runtime)
        )

    async def get_job_position_with_options_async(
        self,
        request: dingtalkchengfeng__1__0_models.GetJobPositionRequest,
        headers: dingtalkchengfeng__1__0_models.GetJobPositionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.GetJobPositionResponse:
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
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.GetJobPositionResponse(),
            await self.do_roarequest_async('GetJobPosition', 'chengfeng_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/chengfeng/jobPositions/infos', 'json', req, runtime)
        )

    def get_job_post(
        self,
        request: dingtalkchengfeng__1__0_models.GetJobPostRequest,
    ) -> dingtalkchengfeng__1__0_models.GetJobPostResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.GetJobPostHeaders()
        return self.get_job_post_with_options(request, headers, runtime)

    async def get_job_post_async(
        self,
        request: dingtalkchengfeng__1__0_models.GetJobPostRequest,
    ) -> dingtalkchengfeng__1__0_models.GetJobPostResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.GetJobPostHeaders()
        return await self.get_job_post_with_options_async(request, headers, runtime)

    def get_job_post_with_options(
        self,
        request: dingtalkchengfeng__1__0_models.GetJobPostRequest,
        headers: dingtalkchengfeng__1__0_models.GetJobPostHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.GetJobPostResponse:
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
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.GetJobPostResponse(),
            self.do_roarequest('GetJobPost', 'chengfeng_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/chengfeng/jobPosts/infos', 'json', req, runtime)
        )

    async def get_job_post_with_options_async(
        self,
        request: dingtalkchengfeng__1__0_models.GetJobPostRequest,
        headers: dingtalkchengfeng__1__0_models.GetJobPostHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.GetJobPostResponse:
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
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.GetJobPostResponse(),
            await self.do_roarequest_async('GetJobPost', 'chengfeng_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/chengfeng/jobPosts/infos', 'json', req, runtime)
        )

    def get_org_info(
        self,
        request: dingtalkchengfeng__1__0_models.GetOrgInfoRequest,
    ) -> dingtalkchengfeng__1__0_models.GetOrgInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.GetOrgInfoHeaders()
        return self.get_org_info_with_options(request, headers, runtime)

    async def get_org_info_async(
        self,
        request: dingtalkchengfeng__1__0_models.GetOrgInfoRequest,
    ) -> dingtalkchengfeng__1__0_models.GetOrgInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.GetOrgInfoHeaders()
        return await self.get_org_info_with_options_async(request, headers, runtime)

    def get_org_info_with_options(
        self,
        request: dingtalkchengfeng__1__0_models.GetOrgInfoRequest,
        headers: dingtalkchengfeng__1__0_models.GetOrgInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.GetOrgInfoResponse:
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
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.GetOrgInfoResponse(),
            self.do_roarequest('GetOrgInfo', 'chengfeng_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/chengfeng/organizations/infos', 'json', req, runtime)
        )

    async def get_org_info_with_options_async(
        self,
        request: dingtalkchengfeng__1__0_models.GetOrgInfoRequest,
        headers: dingtalkchengfeng__1__0_models.GetOrgInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.GetOrgInfoResponse:
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
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.GetOrgInfoResponse(),
            await self.do_roarequest_async('GetOrgInfo', 'chengfeng_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/chengfeng/organizations/infos', 'json', req, runtime)
        )

    def get_staff_info_by_work_no(
        self,
        request: dingtalkchengfeng__1__0_models.GetStaffInfoByWorkNoRequest,
    ) -> dingtalkchengfeng__1__0_models.GetStaffInfoByWorkNoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.GetStaffInfoByWorkNoHeaders()
        return self.get_staff_info_by_work_no_with_options(request, headers, runtime)

    async def get_staff_info_by_work_no_async(
        self,
        request: dingtalkchengfeng__1__0_models.GetStaffInfoByWorkNoRequest,
    ) -> dingtalkchengfeng__1__0_models.GetStaffInfoByWorkNoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.GetStaffInfoByWorkNoHeaders()
        return await self.get_staff_info_by_work_no_with_options_async(request, headers, runtime)

    def get_staff_info_by_work_no_with_options(
        self,
        request: dingtalkchengfeng__1__0_models.GetStaffInfoByWorkNoRequest,
        headers: dingtalkchengfeng__1__0_models.GetStaffInfoByWorkNoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.GetStaffInfoByWorkNoResponse:
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
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.GetStaffInfoByWorkNoResponse(),
            self.do_roarequest('GetStaffInfoByWorkNo', 'chengfeng_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/chengfeng/users', 'json', req, runtime)
        )

    async def get_staff_info_by_work_no_with_options_async(
        self,
        request: dingtalkchengfeng__1__0_models.GetStaffInfoByWorkNoRequest,
        headers: dingtalkchengfeng__1__0_models.GetStaffInfoByWorkNoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.GetStaffInfoByWorkNoResponse:
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
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.GetStaffInfoByWorkNoResponse(),
            await self.do_roarequest_async('GetStaffInfoByWorkNo', 'chengfeng_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/chengfeng/users', 'json', req, runtime)
        )

    def get_staff_page_query(
        self,
        request: dingtalkchengfeng__1__0_models.GetStaffPageQueryRequest,
    ) -> dingtalkchengfeng__1__0_models.GetStaffPageQueryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.GetStaffPageQueryHeaders()
        return self.get_staff_page_query_with_options(request, headers, runtime)

    async def get_staff_page_query_async(
        self,
        request: dingtalkchengfeng__1__0_models.GetStaffPageQueryRequest,
    ) -> dingtalkchengfeng__1__0_models.GetStaffPageQueryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.GetStaffPageQueryHeaders()
        return await self.get_staff_page_query_with_options_async(request, headers, runtime)

    def get_staff_page_query_with_options(
        self,
        request: dingtalkchengfeng__1__0_models.GetStaffPageQueryRequest,
        headers: dingtalkchengfeng__1__0_models.GetStaffPageQueryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.GetStaffPageQueryResponse:
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
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.GetStaffPageQueryResponse(),
            self.do_roarequest('GetStaffPageQuery', 'chengfeng_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/chengfeng/users/query', 'json', req, runtime)
        )

    async def get_staff_page_query_with_options_async(
        self,
        request: dingtalkchengfeng__1__0_models.GetStaffPageQueryRequest,
        headers: dingtalkchengfeng__1__0_models.GetStaffPageQueryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.GetStaffPageQueryResponse:
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
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.GetStaffPageQueryResponse(),
            await self.do_roarequest_async('GetStaffPageQuery', 'chengfeng_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/chengfeng/users/query', 'json', req, runtime)
        )

    def get_user(
        self,
        request: dingtalkchengfeng__1__0_models.GetUserRequest,
    ) -> dingtalkchengfeng__1__0_models.GetUserResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.GetUserHeaders()
        return self.get_user_with_options(request, headers, runtime)

    async def get_user_async(
        self,
        request: dingtalkchengfeng__1__0_models.GetUserRequest,
    ) -> dingtalkchengfeng__1__0_models.GetUserResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.GetUserHeaders()
        return await self.get_user_with_options_async(request, headers, runtime)

    def get_user_with_options(
        self,
        request: dingtalkchengfeng__1__0_models.GetUserRequest,
        headers: dingtalkchengfeng__1__0_models.GetUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.GetUserResponse:
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
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.GetUserResponse(),
            self.do_roarequest('GetUser', 'chengfeng_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/chengfeng/okr/users', 'json', req, runtime)
        )

    async def get_user_with_options_async(
        self,
        request: dingtalkchengfeng__1__0_models.GetUserRequest,
        headers: dingtalkchengfeng__1__0_models.GetUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.GetUserResponse:
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
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.GetUserResponse(),
            await self.do_roarequest_async('GetUser', 'chengfeng_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/chengfeng/okr/users', 'json', req, runtime)
        )

    def list_analyze_periods(self) -> dingtalkchengfeng__1__0_models.ListAnalyzePeriodsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.ListAnalyzePeriodsHeaders()
        return self.list_analyze_periods_with_options(headers, runtime)

    async def list_analyze_periods_async(self) -> dingtalkchengfeng__1__0_models.ListAnalyzePeriodsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.ListAnalyzePeriodsHeaders()
        return await self.list_analyze_periods_with_options_async(headers, runtime)

    def list_analyze_periods_with_options(
        self,
        headers: dingtalkchengfeng__1__0_models.ListAnalyzePeriodsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.ListAnalyzePeriodsResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.ListAnalyzePeriodsResponse(),
            self.do_roarequest('ListAnalyzePeriods', 'chengfeng_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/chengfeng/okr/analyses/periods', 'json', req, runtime)
        )

    async def list_analyze_periods_with_options_async(
        self,
        headers: dingtalkchengfeng__1__0_models.ListAnalyzePeriodsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.ListAnalyzePeriodsResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.ListAnalyzePeriodsResponse(),
            await self.do_roarequest_async('ListAnalyzePeriods', 'chengfeng_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/chengfeng/okr/analyses/periods', 'json', req, runtime)
        )

    def list_objective_by_ids(
        self,
        request: dingtalkchengfeng__1__0_models.ListObjectiveByIdsRequest,
    ) -> dingtalkchengfeng__1__0_models.ListObjectiveByIdsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.ListObjectiveByIdsHeaders()
        return self.list_objective_by_ids_with_options(request, headers, runtime)

    async def list_objective_by_ids_async(
        self,
        request: dingtalkchengfeng__1__0_models.ListObjectiveByIdsRequest,
    ) -> dingtalkchengfeng__1__0_models.ListObjectiveByIdsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.ListObjectiveByIdsHeaders()
        return await self.list_objective_by_ids_with_options_async(request, headers, runtime)

    def list_objective_by_ids_with_options(
        self,
        request: dingtalkchengfeng__1__0_models.ListObjectiveByIdsRequest,
        headers: dingtalkchengfeng__1__0_models.ListObjectiveByIdsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.ListObjectiveByIdsResponse:
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
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.ListObjectiveByIdsResponse(),
            self.do_roarequest('ListObjectiveByIds', 'chengfeng_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/chengfeng/okr/objectives/query', 'json', req, runtime)
        )

    async def list_objective_by_ids_with_options_async(
        self,
        request: dingtalkchengfeng__1__0_models.ListObjectiveByIdsRequest,
        headers: dingtalkchengfeng__1__0_models.ListObjectiveByIdsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.ListObjectiveByIdsResponse:
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
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.ListObjectiveByIdsResponse(),
            await self.do_roarequest_async('ListObjectiveByIds', 'chengfeng_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/chengfeng/okr/objectives/query', 'json', req, runtime)
        )

    def list_objective_by_user(
        self,
        request: dingtalkchengfeng__1__0_models.ListObjectiveByUserRequest,
    ) -> dingtalkchengfeng__1__0_models.ListObjectiveByUserResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.ListObjectiveByUserHeaders()
        return self.list_objective_by_user_with_options(request, headers, runtime)

    async def list_objective_by_user_async(
        self,
        request: dingtalkchengfeng__1__0_models.ListObjectiveByUserRequest,
    ) -> dingtalkchengfeng__1__0_models.ListObjectiveByUserResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.ListObjectiveByUserHeaders()
        return await self.list_objective_by_user_with_options_async(request, headers, runtime)

    def list_objective_by_user_with_options(
        self,
        request: dingtalkchengfeng__1__0_models.ListObjectiveByUserRequest,
        headers: dingtalkchengfeng__1__0_models.ListObjectiveByUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.ListObjectiveByUserResponse:
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
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.ListObjectiveByUserResponse(),
            self.do_roarequest('ListObjectiveByUser', 'chengfeng_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/chengfeng/okr/users/objectives', 'json', req, runtime)
        )

    async def list_objective_by_user_with_options_async(
        self,
        request: dingtalkchengfeng__1__0_models.ListObjectiveByUserRequest,
        headers: dingtalkchengfeng__1__0_models.ListObjectiveByUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.ListObjectiveByUserResponse:
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
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.ListObjectiveByUserResponse(),
            await self.do_roarequest_async('ListObjectiveByUser', 'chengfeng_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/chengfeng/okr/users/objectives', 'json', req, runtime)
        )

    def list_progress_by_ids(
        self,
        request: dingtalkchengfeng__1__0_models.ListProgressByIdsRequest,
    ) -> dingtalkchengfeng__1__0_models.ListProgressByIdsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.ListProgressByIdsHeaders()
        return self.list_progress_by_ids_with_options(request, headers, runtime)

    async def list_progress_by_ids_async(
        self,
        request: dingtalkchengfeng__1__0_models.ListProgressByIdsRequest,
    ) -> dingtalkchengfeng__1__0_models.ListProgressByIdsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.ListProgressByIdsHeaders()
        return await self.list_progress_by_ids_with_options_async(request, headers, runtime)

    def list_progress_by_ids_with_options(
        self,
        request: dingtalkchengfeng__1__0_models.ListProgressByIdsRequest,
        headers: dingtalkchengfeng__1__0_models.ListProgressByIdsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.ListProgressByIdsResponse:
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
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.ListProgressByIdsResponse(),
            self.do_roarequest('ListProgressByIds', 'chengfeng_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/chengfeng/okr/objectives/progresses/query', 'json', req, runtime)
        )

    async def list_progress_by_ids_with_options_async(
        self,
        request: dingtalkchengfeng__1__0_models.ListProgressByIdsRequest,
        headers: dingtalkchengfeng__1__0_models.ListProgressByIdsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.ListProgressByIdsResponse:
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
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.ListProgressByIdsResponse(),
            await self.do_roarequest_async('ListProgressByIds', 'chengfeng_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/chengfeng/okr/objectives/progresses/query', 'json', req, runtime)
        )

    def page_list_objective_progress(
        self,
        request: dingtalkchengfeng__1__0_models.PageListObjectiveProgressRequest,
    ) -> dingtalkchengfeng__1__0_models.PageListObjectiveProgressResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.PageListObjectiveProgressHeaders()
        return self.page_list_objective_progress_with_options(request, headers, runtime)

    async def page_list_objective_progress_async(
        self,
        request: dingtalkchengfeng__1__0_models.PageListObjectiveProgressRequest,
    ) -> dingtalkchengfeng__1__0_models.PageListObjectiveProgressResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.PageListObjectiveProgressHeaders()
        return await self.page_list_objective_progress_with_options_async(request, headers, runtime)

    def page_list_objective_progress_with_options(
        self,
        request: dingtalkchengfeng__1__0_models.PageListObjectiveProgressRequest,
        headers: dingtalkchengfeng__1__0_models.PageListObjectiveProgressHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.PageListObjectiveProgressResponse:
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
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.PageListObjectiveProgressResponse(),
            self.do_roarequest('PageListObjectiveProgress', 'chengfeng_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/chengfeng/okr/objectives/progresses/records', 'json', req, runtime)
        )

    async def page_list_objective_progress_with_options_async(
        self,
        request: dingtalkchengfeng__1__0_models.PageListObjectiveProgressRequest,
        headers: dingtalkchengfeng__1__0_models.PageListObjectiveProgressHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.PageListObjectiveProgressResponse:
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
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.PageListObjectiveProgressResponse(),
            await self.do_roarequest_async('PageListObjectiveProgress', 'chengfeng_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/chengfeng/okr/objectives/progresses/records', 'json', req, runtime)
        )

    def transfer_user_objective(
        self,
        request: dingtalkchengfeng__1__0_models.TransferUserObjectiveRequest,
    ) -> dingtalkchengfeng__1__0_models.TransferUserObjectiveResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.TransferUserObjectiveHeaders()
        return self.transfer_user_objective_with_options(request, headers, runtime)

    async def transfer_user_objective_async(
        self,
        request: dingtalkchengfeng__1__0_models.TransferUserObjectiveRequest,
    ) -> dingtalkchengfeng__1__0_models.TransferUserObjectiveResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkchengfeng__1__0_models.TransferUserObjectiveHeaders()
        return await self.transfer_user_objective_with_options_async(request, headers, runtime)

    def transfer_user_objective_with_options(
        self,
        request: dingtalkchengfeng__1__0_models.TransferUserObjectiveRequest,
        headers: dingtalkchengfeng__1__0_models.TransferUserObjectiveHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.TransferUserObjectiveResponse:
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
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.TransferUserObjectiveResponse(),
            self.do_roarequest('TransferUserObjective', 'chengfeng_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/chengfeng/okr/objectives/transfer', 'json', req, runtime)
        )

    async def transfer_user_objective_with_options_async(
        self,
        request: dingtalkchengfeng__1__0_models.TransferUserObjectiveRequest,
        headers: dingtalkchengfeng__1__0_models.TransferUserObjectiveHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkchengfeng__1__0_models.TransferUserObjectiveResponse:
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
        return TeaCore.from_map(
            dingtalkchengfeng__1__0_models.TransferUserObjectiveResponse(),
            await self.do_roarequest_async('TransferUserObjective', 'chengfeng_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/chengfeng/okr/objectives/transfer', 'json', req, runtime)
        )
