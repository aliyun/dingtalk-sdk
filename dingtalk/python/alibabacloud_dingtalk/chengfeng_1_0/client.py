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
