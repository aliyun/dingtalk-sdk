# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.edu_1_0 import models as dingtalkedu__1__0_models
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

    def query_statistics_data(
        self,
        request: dingtalkedu__1__0_models.QueryStatisticsDataRequest,
    ) -> dingtalkedu__1__0_models.QueryStatisticsDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryStatisticsDataHeaders()
        return self.query_statistics_data_with_options(request, headers, runtime)

    async def query_statistics_data_async(
        self,
        request: dingtalkedu__1__0_models.QueryStatisticsDataRequest,
    ) -> dingtalkedu__1__0_models.QueryStatisticsDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryStatisticsDataHeaders()
        return await self.query_statistics_data_with_options_async(request, headers, runtime)

    def query_statistics_data_with_options(
        self,
        request: dingtalkedu__1__0_models.QueryStatisticsDataRequest,
        headers: dingtalkedu__1__0_models.QueryStatisticsDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryStatisticsDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.start_time):
            query['startTime'] = request.start_time
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.section_index_list):
            body['sectionIndexList'] = request.section_index_list
        if not UtilClient.is_unset(request.teacher_user_ids):
            body['teacherUserIds'] = request.teacher_user_ids
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryStatisticsDataResponse(),
            self.do_roarequest('QueryStatisticsData', 'edu_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/edu/classes/schedules/statisticData/query', 'json', req, runtime)
        )

    async def query_statistics_data_with_options_async(
        self,
        request: dingtalkedu__1__0_models.QueryStatisticsDataRequest,
        headers: dingtalkedu__1__0_models.QueryStatisticsDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryStatisticsDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.start_time):
            query['startTime'] = request.start_time
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.section_index_list):
            body['sectionIndexList'] = request.section_index_list
        if not UtilClient.is_unset(request.teacher_user_ids):
            body['teacherUserIds'] = request.teacher_user_ids
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryStatisticsDataResponse(),
            await self.do_roarequest_async('QueryStatisticsData', 'edu_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/edu/classes/schedules/statisticData/query', 'json', req, runtime)
        )

    def query_class_schedule_config(
        self,
        request: dingtalkedu__1__0_models.QueryClassScheduleConfigRequest,
    ) -> dingtalkedu__1__0_models.QueryClassScheduleConfigResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryClassScheduleConfigHeaders()
        return self.query_class_schedule_config_with_options(request, headers, runtime)

    async def query_class_schedule_config_async(
        self,
        request: dingtalkedu__1__0_models.QueryClassScheduleConfigRequest,
    ) -> dingtalkedu__1__0_models.QueryClassScheduleConfigResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryClassScheduleConfigHeaders()
        return await self.query_class_schedule_config_with_options_async(request, headers, runtime)

    def query_class_schedule_config_with_options(
        self,
        tmp_req: dingtalkedu__1__0_models.QueryClassScheduleConfigRequest,
        headers: dingtalkedu__1__0_models.QueryClassScheduleConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryClassScheduleConfigResponse:
        UtilClient.validate_model(tmp_req)
        request = dingtalkedu__1__0_models.QueryClassScheduleConfigShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.class_ids):
            request.class_ids_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.class_ids, 'classIds', 'json')
        query = {}
        if not UtilClient.is_unset(request.class_ids_shrink):
            query['classIds'] = request.class_ids_shrink
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryClassScheduleConfigResponse(),
            self.do_roarequest('QueryClassScheduleConfig', 'edu_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/edu/schedules/configs', 'json', req, runtime)
        )

    async def query_class_schedule_config_with_options_async(
        self,
        tmp_req: dingtalkedu__1__0_models.QueryClassScheduleConfigRequest,
        headers: dingtalkedu__1__0_models.QueryClassScheduleConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryClassScheduleConfigResponse:
        UtilClient.validate_model(tmp_req)
        request = dingtalkedu__1__0_models.QueryClassScheduleConfigShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.class_ids):
            request.class_ids_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.class_ids, 'classIds', 'json')
        query = {}
        if not UtilClient.is_unset(request.class_ids_shrink):
            query['classIds'] = request.class_ids_shrink
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryClassScheduleConfigResponse(),
            await self.do_roarequest_async('QueryClassScheduleConfig', 'edu_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/edu/schedules/configs', 'json', req, runtime)
        )

    def get_default_child(self) -> dingtalkedu__1__0_models.GetDefaultChildResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetDefaultChildHeaders()
        return self.get_default_child_with_options(headers, runtime)

    async def get_default_child_async(self) -> dingtalkedu__1__0_models.GetDefaultChildResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetDefaultChildHeaders()
        return await self.get_default_child_with_options_async(headers, runtime)

    def get_default_child_with_options(
        self,
        headers: dingtalkedu__1__0_models.GetDefaultChildHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetDefaultChildResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetDefaultChildResponse(),
            self.do_roarequest('GetDefaultChild', 'edu_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/edu/defaultChildren', 'json', req, runtime)
        )

    async def get_default_child_with_options_async(
        self,
        headers: dingtalkedu__1__0_models.GetDefaultChildHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetDefaultChildResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetDefaultChildResponse(),
            await self.do_roarequest_async('GetDefaultChild', 'edu_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/edu/defaultChildren', 'json', req, runtime)
        )

    def get_open_courses(
        self,
        request: dingtalkedu__1__0_models.GetOpenCoursesRequest,
    ) -> dingtalkedu__1__0_models.GetOpenCoursesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetOpenCoursesHeaders()
        return self.get_open_courses_with_options(request, headers, runtime)

    async def get_open_courses_async(
        self,
        request: dingtalkedu__1__0_models.GetOpenCoursesRequest,
    ) -> dingtalkedu__1__0_models.GetOpenCoursesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetOpenCoursesHeaders()
        return await self.get_open_courses_with_options_async(request, headers, runtime)

    def get_open_courses_with_options(
        self,
        request: dingtalkedu__1__0_models.GetOpenCoursesRequest,
        headers: dingtalkedu__1__0_models.GetOpenCoursesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetOpenCoursesResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetOpenCoursesResponse(),
            self.do_roarequest('GetOpenCourses', 'edu_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/edu/openCourses', 'json', req, runtime)
        )

    async def get_open_courses_with_options_async(
        self,
        request: dingtalkedu__1__0_models.GetOpenCoursesRequest,
        headers: dingtalkedu__1__0_models.GetOpenCoursesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetOpenCoursesResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetOpenCoursesResponse(),
            await self.do_roarequest_async('GetOpenCourses', 'edu_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/edu/openCourses', 'json', req, runtime)
        )

    def create_university_student(
        self,
        request: dingtalkedu__1__0_models.CreateUniversityStudentRequest,
    ) -> dingtalkedu__1__0_models.CreateUniversityStudentResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateUniversityStudentHeaders()
        return self.create_university_student_with_options(request, headers, runtime)

    async def create_university_student_async(
        self,
        request: dingtalkedu__1__0_models.CreateUniversityStudentRequest,
    ) -> dingtalkedu__1__0_models.CreateUniversityStudentResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateUniversityStudentHeaders()
        return await self.create_university_student_with_options_async(request, headers, runtime)

    def create_university_student_with_options(
        self,
        request: dingtalkedu__1__0_models.CreateUniversityStudentRequest,
        headers: dingtalkedu__1__0_models.CreateUniversityStudentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateUniversityStudentResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.student_number):
            body['studentNumber'] = request.student_number
        if not UtilClient.is_unset(request.class_id):
            body['classId'] = request.class_id
        if not UtilClient.is_unset(request.gender):
            body['gender'] = request.gender
        if not UtilClient.is_unset(request.mobile):
            body['mobile'] = request.mobile
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.identity_number):
            body['identityNumber'] = request.identity_number
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateUniversityStudentResponse(),
            self.do_roarequest('CreateUniversityStudent', 'edu_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/edu/universities/students', 'json', req, runtime)
        )

    async def create_university_student_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CreateUniversityStudentRequest,
        headers: dingtalkedu__1__0_models.CreateUniversityStudentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateUniversityStudentResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.student_number):
            body['studentNumber'] = request.student_number
        if not UtilClient.is_unset(request.class_id):
            body['classId'] = request.class_id
        if not UtilClient.is_unset(request.gender):
            body['gender'] = request.gender
        if not UtilClient.is_unset(request.mobile):
            body['mobile'] = request.mobile
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.identity_number):
            body['identityNumber'] = request.identity_number
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateUniversityStudentResponse(),
            await self.do_roarequest_async('CreateUniversityStudent', 'edu_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/edu/universities/students', 'json', req, runtime)
        )

    def batch_create(
        self,
        request: dingtalkedu__1__0_models.BatchCreateRequest,
    ) -> dingtalkedu__1__0_models.BatchCreateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.BatchCreateHeaders()
        return self.batch_create_with_options(request, headers, runtime)

    async def batch_create_async(
        self,
        request: dingtalkedu__1__0_models.BatchCreateRequest,
    ) -> dingtalkedu__1__0_models.BatchCreateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.BatchCreateHeaders()
        return await self.batch_create_with_options_async(request, headers, runtime)

    def batch_create_with_options(
        self,
        request: dingtalkedu__1__0_models.BatchCreateRequest,
        headers: dingtalkedu__1__0_models.BatchCreateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.BatchCreateResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.card_biz_code):
            body['cardBizCode'] = request.card_biz_code
        if not UtilClient.is_unset(request.data):
            body['data'] = request.data
        if not UtilClient.is_unset(request.identifier):
            body['identifier'] = request.identifier
        if not UtilClient.is_unset(request.source_type):
            body['sourceType'] = request.source_type
        if not UtilClient.is_unset(request.userid):
            body['userid'] = request.userid
        if not UtilClient.is_unset(request.ding_corp_id):
            body['dingCorpId'] = request.ding_corp_id
        if not UtilClient.is_unset(request.js_version):
            body['jsVersion'] = request.js_version
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.BatchCreateResponse(),
            self.do_roarequest('BatchCreate', 'edu_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/edu/cards', 'json', req, runtime)
        )

    async def batch_create_with_options_async(
        self,
        request: dingtalkedu__1__0_models.BatchCreateRequest,
        headers: dingtalkedu__1__0_models.BatchCreateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.BatchCreateResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.card_biz_code):
            body['cardBizCode'] = request.card_biz_code
        if not UtilClient.is_unset(request.data):
            body['data'] = request.data
        if not UtilClient.is_unset(request.identifier):
            body['identifier'] = request.identifier
        if not UtilClient.is_unset(request.source_type):
            body['sourceType'] = request.source_type
        if not UtilClient.is_unset(request.userid):
            body['userid'] = request.userid
        if not UtilClient.is_unset(request.ding_corp_id):
            body['dingCorpId'] = request.ding_corp_id
        if not UtilClient.is_unset(request.js_version):
            body['jsVersion'] = request.js_version
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.BatchCreateResponse(),
            await self.do_roarequest_async('BatchCreate', 'edu_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/edu/cards', 'json', req, runtime)
        )

    def init_courses_of_class(
        self,
        class_id: str,
        request: dingtalkedu__1__0_models.InitCoursesOfClassRequest,
    ) -> dingtalkedu__1__0_models.InitCoursesOfClassResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.InitCoursesOfClassHeaders()
        return self.init_courses_of_class_with_options(class_id, request, headers, runtime)

    async def init_courses_of_class_async(
        self,
        class_id: str,
        request: dingtalkedu__1__0_models.InitCoursesOfClassRequest,
    ) -> dingtalkedu__1__0_models.InitCoursesOfClassResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.InitCoursesOfClassHeaders()
        return await self.init_courses_of_class_with_options_async(class_id, request, headers, runtime)

    def init_courses_of_class_with_options(
        self,
        class_id: str,
        request: dingtalkedu__1__0_models.InitCoursesOfClassRequest,
        headers: dingtalkedu__1__0_models.InitCoursesOfClassHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.InitCoursesOfClassResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.courses):
            body['courses'] = request.courses
        if not UtilClient.is_unset(request.section_config):
            body['sectionConfig'] = request.section_config
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.InitCoursesOfClassResponse(),
            self.do_roarequest('InitCoursesOfClass', 'edu_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/edu/classes/{class_id}/courses/init', 'json', req, runtime)
        )

    async def init_courses_of_class_with_options_async(
        self,
        class_id: str,
        request: dingtalkedu__1__0_models.InitCoursesOfClassRequest,
        headers: dingtalkedu__1__0_models.InitCoursesOfClassHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.InitCoursesOfClassResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.courses):
            body['courses'] = request.courses
        if not UtilClient.is_unset(request.section_config):
            body['sectionConfig'] = request.section_config
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.InitCoursesOfClassResponse(),
            await self.do_roarequest_async('InitCoursesOfClass', 'edu_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/edu/classes/{class_id}/courses/init', 'json', req, runtime)
        )

    def create_invite_url(
        self,
        request: dingtalkedu__1__0_models.CreateInviteUrlRequest,
    ) -> dingtalkedu__1__0_models.CreateInviteUrlResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateInviteUrlHeaders()
        return self.create_invite_url_with_options(request, headers, runtime)

    async def create_invite_url_async(
        self,
        request: dingtalkedu__1__0_models.CreateInviteUrlRequest,
    ) -> dingtalkedu__1__0_models.CreateInviteUrlResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateInviteUrlHeaders()
        return await self.create_invite_url_with_options_async(request, headers, runtime)

    def create_invite_url_with_options(
        self,
        request: dingtalkedu__1__0_models.CreateInviteUrlRequest,
        headers: dingtalkedu__1__0_models.CreateInviteUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateInviteUrlResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.ding_corp_id):
            body['dingCorpId'] = request.ding_corp_id
        if not UtilClient.is_unset(request.ding_suite_key):
            body['dingSuiteKey'] = request.ding_suite_key
        if not UtilClient.is_unset(request.ding_token_grant_type):
            body['dingTokenGrantType'] = request.ding_token_grant_type
        if not UtilClient.is_unset(request.ding_oauth_app_id):
            body['dingOauthAppId'] = request.ding_oauth_app_id
        if not UtilClient.is_unset(request.target_corp_id):
            body['targetCorpId'] = request.target_corp_id
        if not UtilClient.is_unset(request.auth_code):
            body['authCode'] = request.auth_code
        if not UtilClient.is_unset(request.target_operator):
            body['targetOperator'] = request.target_operator
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateInviteUrlResponse(),
            self.do_roarequest('CreateInviteUrl', 'edu_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/edu/remoteClasses/orgRelations/inviteUrls', 'json', req, runtime)
        )

    async def create_invite_url_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CreateInviteUrlRequest,
        headers: dingtalkedu__1__0_models.CreateInviteUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateInviteUrlResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.ding_corp_id):
            body['dingCorpId'] = request.ding_corp_id
        if not UtilClient.is_unset(request.ding_suite_key):
            body['dingSuiteKey'] = request.ding_suite_key
        if not UtilClient.is_unset(request.ding_token_grant_type):
            body['dingTokenGrantType'] = request.ding_token_grant_type
        if not UtilClient.is_unset(request.ding_oauth_app_id):
            body['dingOauthAppId'] = request.ding_oauth_app_id
        if not UtilClient.is_unset(request.target_corp_id):
            body['targetCorpId'] = request.target_corp_id
        if not UtilClient.is_unset(request.auth_code):
            body['authCode'] = request.auth_code
        if not UtilClient.is_unset(request.target_operator):
            body['targetOperator'] = request.target_operator
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateInviteUrlResponse(),
            await self.do_roarequest_async('CreateInviteUrl', 'edu_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/edu/remoteClasses/orgRelations/inviteUrls', 'json', req, runtime)
        )

    def polling_confirm_status(
        self,
        request: dingtalkedu__1__0_models.PollingConfirmStatusRequest,
    ) -> dingtalkedu__1__0_models.PollingConfirmStatusResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.PollingConfirmStatusHeaders()
        return self.polling_confirm_status_with_options(request, headers, runtime)

    async def polling_confirm_status_async(
        self,
        request: dingtalkedu__1__0_models.PollingConfirmStatusRequest,
    ) -> dingtalkedu__1__0_models.PollingConfirmStatusResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.PollingConfirmStatusHeaders()
        return await self.polling_confirm_status_with_options_async(request, headers, runtime)

    def polling_confirm_status_with_options(
        self,
        request: dingtalkedu__1__0_models.PollingConfirmStatusRequest,
        headers: dingtalkedu__1__0_models.PollingConfirmStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.PollingConfirmStatusResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.ext):
            query['ext'] = request.ext
        if not UtilClient.is_unset(request.isv_code):
            query['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.course_code):
            query['courseCode'] = request.course_code
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.PollingConfirmStatusResponse(),
            self.do_roarequest('PollingConfirmStatus', 'edu_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/edu/universities/courses/pollingConfirmStatus', 'json', req, runtime)
        )

    async def polling_confirm_status_with_options_async(
        self,
        request: dingtalkedu__1__0_models.PollingConfirmStatusRequest,
        headers: dingtalkedu__1__0_models.PollingConfirmStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.PollingConfirmStatusResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.ext):
            query['ext'] = request.ext
        if not UtilClient.is_unset(request.isv_code):
            query['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.course_code):
            query['courseCode'] = request.course_code
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.PollingConfirmStatusResponse(),
            await self.do_roarequest_async('PollingConfirmStatus', 'edu_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/edu/universities/courses/pollingConfirmStatus', 'json', req, runtime)
        )

    def create_edu_asset_space(
        self,
        request: dingtalkedu__1__0_models.CreateEduAssetSpaceRequest,
    ) -> dingtalkedu__1__0_models.CreateEduAssetSpaceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateEduAssetSpaceHeaders()
        return self.create_edu_asset_space_with_options(request, headers, runtime)

    async def create_edu_asset_space_async(
        self,
        request: dingtalkedu__1__0_models.CreateEduAssetSpaceRequest,
    ) -> dingtalkedu__1__0_models.CreateEduAssetSpaceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateEduAssetSpaceHeaders()
        return await self.create_edu_asset_space_with_options_async(request, headers, runtime)

    def create_edu_asset_space_with_options(
        self,
        request: dingtalkedu__1__0_models.CreateEduAssetSpaceRequest,
        headers: dingtalkedu__1__0_models.CreateEduAssetSpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateEduAssetSpaceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.space_name):
            body['spaceName'] = request.space_name
        if not UtilClient.is_unset(request.space_desc):
            body['spaceDesc'] = request.space_desc
        if not UtilClient.is_unset(request.space_icon):
            body['spaceIcon'] = request.space_icon
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.biz_code):
            body['bizCode'] = request.biz_code
        if not UtilClient.is_unset(request.ding_corp_id):
            body['dingCorpId'] = request.ding_corp_id
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateEduAssetSpaceResponse(),
            self.do_roarequest('CreateEduAssetSpace', 'edu_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/edu/assets/spaces', 'json', req, runtime)
        )

    async def create_edu_asset_space_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CreateEduAssetSpaceRequest,
        headers: dingtalkedu__1__0_models.CreateEduAssetSpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateEduAssetSpaceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.space_name):
            body['spaceName'] = request.space_name
        if not UtilClient.is_unset(request.space_desc):
            body['spaceDesc'] = request.space_desc
        if not UtilClient.is_unset(request.space_icon):
            body['spaceIcon'] = request.space_icon
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.biz_code):
            body['bizCode'] = request.biz_code
        if not UtilClient.is_unset(request.ding_corp_id):
            body['dingCorpId'] = request.ding_corp_id
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateEduAssetSpaceResponse(),
            await self.do_roarequest_async('CreateEduAssetSpace', 'edu_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/edu/assets/spaces', 'json', req, runtime)
        )

    def delete_teacher(
        self,
        class_id: str,
        user_id: str,
        request: dingtalkedu__1__0_models.DeleteTeacherRequest,
    ) -> dingtalkedu__1__0_models.DeleteTeacherResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteTeacherHeaders()
        return self.delete_teacher_with_options(class_id, user_id, request, headers, runtime)

    async def delete_teacher_async(
        self,
        class_id: str,
        user_id: str,
        request: dingtalkedu__1__0_models.DeleteTeacherRequest,
    ) -> dingtalkedu__1__0_models.DeleteTeacherResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteTeacherHeaders()
        return await self.delete_teacher_with_options_async(class_id, user_id, request, headers, runtime)

    def delete_teacher_with_options(
        self,
        class_id: str,
        user_id: str,
        request: dingtalkedu__1__0_models.DeleteTeacherRequest,
        headers: dingtalkedu__1__0_models.DeleteTeacherHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteTeacherResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.adviser):
            query['adviser'] = request.adviser
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteTeacherResponse(),
            self.do_roarequest('DeleteTeacher', 'edu_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/edu/classes/{class_id}/teachers/{user_id}', 'json', req, runtime)
        )

    async def delete_teacher_with_options_async(
        self,
        class_id: str,
        user_id: str,
        request: dingtalkedu__1__0_models.DeleteTeacherRequest,
        headers: dingtalkedu__1__0_models.DeleteTeacherHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteTeacherResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.adviser):
            query['adviser'] = request.adviser
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteTeacherResponse(),
            await self.do_roarequest_async('DeleteTeacher', 'edu_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/edu/classes/{class_id}/teachers/{user_id}', 'json', req, runtime)
        )

    def delete_university_teacher(
        self,
        request: dingtalkedu__1__0_models.DeleteUniversityTeacherRequest,
    ) -> dingtalkedu__1__0_models.DeleteUniversityTeacherResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteUniversityTeacherHeaders()
        return self.delete_university_teacher_with_options(request, headers, runtime)

    async def delete_university_teacher_async(
        self,
        request: dingtalkedu__1__0_models.DeleteUniversityTeacherRequest,
    ) -> dingtalkedu__1__0_models.DeleteUniversityTeacherResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteUniversityTeacherHeaders()
        return await self.delete_university_teacher_with_options_async(request, headers, runtime)

    def delete_university_teacher_with_options(
        self,
        request: dingtalkedu__1__0_models.DeleteUniversityTeacherRequest,
        headers: dingtalkedu__1__0_models.DeleteUniversityTeacherHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteUniversityTeacherResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.class_id):
            query['classId'] = request.class_id
        if not UtilClient.is_unset(request.role):
            query['role'] = request.role
        if not UtilClient.is_unset(request.teacher_user_id):
            query['teacherUserId'] = request.teacher_user_id
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteUniversityTeacherResponse(),
            self.do_roarequest('DeleteUniversityTeacher', 'edu_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/edu/universities/teachers', 'json', req, runtime)
        )

    async def delete_university_teacher_with_options_async(
        self,
        request: dingtalkedu__1__0_models.DeleteUniversityTeacherRequest,
        headers: dingtalkedu__1__0_models.DeleteUniversityTeacherHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteUniversityTeacherResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.class_id):
            query['classId'] = request.class_id
        if not UtilClient.is_unset(request.role):
            query['role'] = request.role
        if not UtilClient.is_unset(request.teacher_user_id):
            query['teacherUserId'] = request.teacher_user_id
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteUniversityTeacherResponse(),
            await self.do_roarequest_async('DeleteUniversityTeacher', 'edu_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/edu/universities/teachers', 'json', req, runtime)
        )

    def delete_device_org(
        self,
        request: dingtalkedu__1__0_models.DeleteDeviceOrgRequest,
    ) -> dingtalkedu__1__0_models.DeleteDeviceOrgResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteDeviceOrgHeaders()
        return self.delete_device_org_with_options(request, headers, runtime)

    async def delete_device_org_async(
        self,
        request: dingtalkedu__1__0_models.DeleteDeviceOrgRequest,
    ) -> dingtalkedu__1__0_models.DeleteDeviceOrgResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteDeviceOrgHeaders()
        return await self.delete_device_org_with_options_async(request, headers, runtime)

    def delete_device_org_with_options(
        self,
        request: dingtalkedu__1__0_models.DeleteDeviceOrgRequest,
        headers: dingtalkedu__1__0_models.DeleteDeviceOrgHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteDeviceOrgResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.device_code):
            query['deviceCode'] = request.device_code
        if not UtilClient.is_unset(request.auth_code):
            query['authCode'] = request.auth_code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteDeviceOrgResponse(),
            self.do_roarequest('DeleteDeviceOrg', 'edu_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/edu/remoteClasses/deviceOrgs', 'json', req, runtime)
        )

    async def delete_device_org_with_options_async(
        self,
        request: dingtalkedu__1__0_models.DeleteDeviceOrgRequest,
        headers: dingtalkedu__1__0_models.DeleteDeviceOrgHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteDeviceOrgResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.device_code):
            query['deviceCode'] = request.device_code
        if not UtilClient.is_unset(request.auth_code):
            query['authCode'] = request.auth_code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteDeviceOrgResponse(),
            await self.do_roarequest_async('DeleteDeviceOrg', 'edu_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/edu/remoteClasses/deviceOrgs', 'json', req, runtime)
        )

    def delete_remote_class_course(
        self,
        course_code: str,
        request: dingtalkedu__1__0_models.DeleteRemoteClassCourseRequest,
    ) -> dingtalkedu__1__0_models.DeleteRemoteClassCourseResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteRemoteClassCourseHeaders()
        return self.delete_remote_class_course_with_options(course_code, request, headers, runtime)

    async def delete_remote_class_course_async(
        self,
        course_code: str,
        request: dingtalkedu__1__0_models.DeleteRemoteClassCourseRequest,
    ) -> dingtalkedu__1__0_models.DeleteRemoteClassCourseResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteRemoteClassCourseHeaders()
        return await self.delete_remote_class_course_with_options_async(course_code, request, headers, runtime)

    def delete_remote_class_course_with_options(
        self,
        course_code: str,
        request: dingtalkedu__1__0_models.DeleteRemoteClassCourseRequest,
        headers: dingtalkedu__1__0_models.DeleteRemoteClassCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteRemoteClassCourseResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.auth_code):
            query['authCode'] = request.auth_code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteRemoteClassCourseResponse(),
            self.do_roarequest('DeleteRemoteClassCourse', 'edu_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/edu/remoteClasses/courses/{course_code}', 'json', req, runtime)
        )

    async def delete_remote_class_course_with_options_async(
        self,
        course_code: str,
        request: dingtalkedu__1__0_models.DeleteRemoteClassCourseRequest,
        headers: dingtalkedu__1__0_models.DeleteRemoteClassCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteRemoteClassCourseResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.auth_code):
            query['authCode'] = request.auth_code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteRemoteClassCourseResponse(),
            await self.do_roarequest_async('DeleteRemoteClassCourse', 'edu_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/edu/remoteClasses/courses/{course_code}', 'json', req, runtime)
        )

    def get_open_course_detail(
        self,
        course_id: str,
    ) -> dingtalkedu__1__0_models.GetOpenCourseDetailResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetOpenCourseDetailHeaders()
        return self.get_open_course_detail_with_options(course_id, headers, runtime)

    async def get_open_course_detail_async(
        self,
        course_id: str,
    ) -> dingtalkedu__1__0_models.GetOpenCourseDetailResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetOpenCourseDetailHeaders()
        return await self.get_open_course_detail_with_options_async(course_id, headers, runtime)

    def get_open_course_detail_with_options(
        self,
        course_id: str,
        headers: dingtalkedu__1__0_models.GetOpenCourseDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetOpenCourseDetailResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetOpenCourseDetailResponse(),
            self.do_roarequest('GetOpenCourseDetail', 'edu_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/edu/openCourse/{course_id}', 'json', req, runtime)
        )

    async def get_open_course_detail_with_options_async(
        self,
        course_id: str,
        headers: dingtalkedu__1__0_models.GetOpenCourseDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetOpenCourseDetailResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetOpenCourseDetailResponse(),
            await self.do_roarequest_async('GetOpenCourseDetail', 'edu_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/edu/openCourse/{course_id}', 'json', req, runtime)
        )

    def delete_student(
        self,
        class_id: str,
        user_id: str,
        request: dingtalkedu__1__0_models.DeleteStudentRequest,
    ) -> dingtalkedu__1__0_models.DeleteStudentResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteStudentHeaders()
        return self.delete_student_with_options(class_id, user_id, request, headers, runtime)

    async def delete_student_async(
        self,
        class_id: str,
        user_id: str,
        request: dingtalkedu__1__0_models.DeleteStudentRequest,
    ) -> dingtalkedu__1__0_models.DeleteStudentResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteStudentHeaders()
        return await self.delete_student_with_options_async(class_id, user_id, request, headers, runtime)

    def delete_student_with_options(
        self,
        class_id: str,
        user_id: str,
        request: dingtalkedu__1__0_models.DeleteStudentRequest,
        headers: dingtalkedu__1__0_models.DeleteStudentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteStudentResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteStudentResponse(),
            self.do_roarequest('DeleteStudent', 'edu_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/edu/classes/{class_id}/students/{user_id}', 'json', req, runtime)
        )

    async def delete_student_with_options_async(
        self,
        class_id: str,
        user_id: str,
        request: dingtalkedu__1__0_models.DeleteStudentRequest,
        headers: dingtalkedu__1__0_models.DeleteStudentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteStudentResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteStudentResponse(),
            await self.do_roarequest_async('DeleteStudent', 'edu_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/edu/classes/{class_id}/students/{user_id}', 'json', req, runtime)
        )

    def update_courses_of_class(
        self,
        class_id: str,
        request: dingtalkedu__1__0_models.UpdateCoursesOfClassRequest,
    ) -> dingtalkedu__1__0_models.UpdateCoursesOfClassResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.UpdateCoursesOfClassHeaders()
        return self.update_courses_of_class_with_options(class_id, request, headers, runtime)

    async def update_courses_of_class_async(
        self,
        class_id: str,
        request: dingtalkedu__1__0_models.UpdateCoursesOfClassRequest,
    ) -> dingtalkedu__1__0_models.UpdateCoursesOfClassResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.UpdateCoursesOfClassHeaders()
        return await self.update_courses_of_class_with_options_async(class_id, request, headers, runtime)

    def update_courses_of_class_with_options(
        self,
        class_id: str,
        request: dingtalkedu__1__0_models.UpdateCoursesOfClassRequest,
        headers: dingtalkedu__1__0_models.UpdateCoursesOfClassHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.UpdateCoursesOfClassResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.courses):
            body['courses'] = request.courses
        if not UtilClient.is_unset(request.section_config):
            body['sectionConfig'] = request.section_config
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.UpdateCoursesOfClassResponse(),
            self.do_roarequest('UpdateCoursesOfClass', 'edu_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/edu/classes/{class_id}/courses/schedules', 'json', req, runtime)
        )

    async def update_courses_of_class_with_options_async(
        self,
        class_id: str,
        request: dingtalkedu__1__0_models.UpdateCoursesOfClassRequest,
        headers: dingtalkedu__1__0_models.UpdateCoursesOfClassHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.UpdateCoursesOfClassResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.courses):
            body['courses'] = request.courses
        if not UtilClient.is_unset(request.section_config):
            body['sectionConfig'] = request.section_config
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.UpdateCoursesOfClassResponse(),
            await self.do_roarequest_async('UpdateCoursesOfClass', 'edu_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/edu/classes/{class_id}/courses/schedules', 'json', req, runtime)
        )

    def create_section_config(
        self,
        request: dingtalkedu__1__0_models.CreateSectionConfigRequest,
    ) -> dingtalkedu__1__0_models.CreateSectionConfigResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateSectionConfigHeaders()
        return self.create_section_config_with_options(request, headers, runtime)

    async def create_section_config_async(
        self,
        request: dingtalkedu__1__0_models.CreateSectionConfigRequest,
    ) -> dingtalkedu__1__0_models.CreateSectionConfigResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateSectionConfigHeaders()
        return await self.create_section_config_with_options_async(request, headers, runtime)

    def create_section_config_with_options(
        self,
        request: dingtalkedu__1__0_models.CreateSectionConfigRequest,
        headers: dingtalkedu__1__0_models.CreateSectionConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateSectionConfigResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.ext):
            body['ext'] = request.ext
        if not UtilClient.is_unset(request.section_configs):
            body['sectionConfigs'] = request.section_configs
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateSectionConfigResponse(),
            self.do_roarequest('CreateSectionConfig', 'edu_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/edu/universities/sectionConfigs', 'json', req, runtime)
        )

    async def create_section_config_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CreateSectionConfigRequest,
        headers: dingtalkedu__1__0_models.CreateSectionConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateSectionConfigResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.ext):
            body['ext'] = request.ext
        if not UtilClient.is_unset(request.section_configs):
            body['sectionConfigs'] = request.section_configs
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateSectionConfigResponse(),
            await self.do_roarequest_async('CreateSectionConfig', 'edu_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/edu/universities/sectionConfigs', 'json', req, runtime)
        )

    def query_subject_teachers(
        self,
        request: dingtalkedu__1__0_models.QuerySubjectTeachersRequest,
    ) -> dingtalkedu__1__0_models.QuerySubjectTeachersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QuerySubjectTeachersHeaders()
        return self.query_subject_teachers_with_options(request, headers, runtime)

    async def query_subject_teachers_async(
        self,
        request: dingtalkedu__1__0_models.QuerySubjectTeachersRequest,
    ) -> dingtalkedu__1__0_models.QuerySubjectTeachersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QuerySubjectTeachersHeaders()
        return await self.query_subject_teachers_with_options_async(request, headers, runtime)

    def query_subject_teachers_with_options(
        self,
        request: dingtalkedu__1__0_models.QuerySubjectTeachersRequest,
        headers: dingtalkedu__1__0_models.QuerySubjectTeachersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QuerySubjectTeachersResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.class_ids):
            query['classIds'] = request.class_ids
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.subject_code):
            query['subjectCode'] = request.subject_code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QuerySubjectTeachersResponse(),
            self.do_roarequest('QuerySubjectTeachers', 'edu_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/edu/subjects/teachers', 'json', req, runtime)
        )

    async def query_subject_teachers_with_options_async(
        self,
        request: dingtalkedu__1__0_models.QuerySubjectTeachersRequest,
        headers: dingtalkedu__1__0_models.QuerySubjectTeachersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QuerySubjectTeachersResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.class_ids):
            query['classIds'] = request.class_ids
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.subject_code):
            query['subjectCode'] = request.subject_code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QuerySubjectTeachersResponse(),
            await self.do_roarequest_async('QuerySubjectTeachers', 'edu_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/edu/subjects/teachers', 'json', req, runtime)
        )

    def query_remote_class_course(
        self,
        request: dingtalkedu__1__0_models.QueryRemoteClassCourseRequest,
    ) -> dingtalkedu__1__0_models.QueryRemoteClassCourseResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryRemoteClassCourseHeaders()
        return self.query_remote_class_course_with_options(request, headers, runtime)

    async def query_remote_class_course_async(
        self,
        request: dingtalkedu__1__0_models.QueryRemoteClassCourseRequest,
    ) -> dingtalkedu__1__0_models.QueryRemoteClassCourseResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryRemoteClassCourseHeaders()
        return await self.query_remote_class_course_with_options_async(request, headers, runtime)

    def query_remote_class_course_with_options(
        self,
        request: dingtalkedu__1__0_models.QueryRemoteClassCourseRequest,
        headers: dingtalkedu__1__0_models.QueryRemoteClassCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryRemoteClassCourseResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
        if not UtilClient.is_unset(request.start_time):
            query['startTime'] = request.start_time
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryRemoteClassCourseResponse(),
            self.do_roarequest('QueryRemoteClassCourse', 'edu_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/edu/remoteClasses/courses', 'json', req, runtime)
        )

    async def query_remote_class_course_with_options_async(
        self,
        request: dingtalkedu__1__0_models.QueryRemoteClassCourseRequest,
        headers: dingtalkedu__1__0_models.QueryRemoteClassCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryRemoteClassCourseResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
        if not UtilClient.is_unset(request.start_time):
            query['startTime'] = request.start_time
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryRemoteClassCourseResponse(),
            await self.do_roarequest_async('QueryRemoteClassCourse', 'edu_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/edu/remoteClasses/courses', 'json', req, runtime)
        )

    def create_physical_classroom(
        self,
        request: dingtalkedu__1__0_models.CreatePhysicalClassroomRequest,
    ) -> dingtalkedu__1__0_models.CreatePhysicalClassroomResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreatePhysicalClassroomHeaders()
        return self.create_physical_classroom_with_options(request, headers, runtime)

    async def create_physical_classroom_async(
        self,
        request: dingtalkedu__1__0_models.CreatePhysicalClassroomRequest,
    ) -> dingtalkedu__1__0_models.CreatePhysicalClassroomResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreatePhysicalClassroomHeaders()
        return await self.create_physical_classroom_with_options_async(request, headers, runtime)

    def create_physical_classroom_with_options(
        self,
        request: dingtalkedu__1__0_models.CreatePhysicalClassroomRequest,
        headers: dingtalkedu__1__0_models.CreatePhysicalClassroomHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreatePhysicalClassroomResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.classroom_floor):
            body['classroomFloor'] = request.classroom_floor
        if not UtilClient.is_unset(request.ext):
            body['ext'] = request.ext
        if not UtilClient.is_unset(request.classroom_building):
            body['classroomBuilding'] = request.classroom_building
        if not UtilClient.is_unset(request.direct_broadcast):
            body['directBroadcast'] = request.direct_broadcast
        if not UtilClient.is_unset(request.classroom_name):
            body['classroomName'] = request.classroom_name
        if not UtilClient.is_unset(request.classroom_campus):
            body['classroomCampus'] = request.classroom_campus
        if not UtilClient.is_unset(request.classroom_number):
            body['classroomNumber'] = request.classroom_number
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreatePhysicalClassroomResponse(),
            self.do_roarequest('CreatePhysicalClassroom', 'edu_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/edu/physicalClassrooms', 'json', req, runtime)
        )

    async def create_physical_classroom_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CreatePhysicalClassroomRequest,
        headers: dingtalkedu__1__0_models.CreatePhysicalClassroomHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreatePhysicalClassroomResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.classroom_floor):
            body['classroomFloor'] = request.classroom_floor
        if not UtilClient.is_unset(request.ext):
            body['ext'] = request.ext
        if not UtilClient.is_unset(request.classroom_building):
            body['classroomBuilding'] = request.classroom_building
        if not UtilClient.is_unset(request.direct_broadcast):
            body['directBroadcast'] = request.direct_broadcast
        if not UtilClient.is_unset(request.classroom_name):
            body['classroomName'] = request.classroom_name
        if not UtilClient.is_unset(request.classroom_campus):
            body['classroomCampus'] = request.classroom_campus
        if not UtilClient.is_unset(request.classroom_number):
            body['classroomNumber'] = request.classroom_number
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreatePhysicalClassroomResponse(),
            await self.do_roarequest_async('CreatePhysicalClassroom', 'edu_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/edu/physicalClassrooms', 'json', req, runtime)
        )

    def query_class_schedule(
        self,
        request: dingtalkedu__1__0_models.QueryClassScheduleRequest,
    ) -> dingtalkedu__1__0_models.QueryClassScheduleResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryClassScheduleHeaders()
        return self.query_class_schedule_with_options(request, headers, runtime)

    async def query_class_schedule_async(
        self,
        request: dingtalkedu__1__0_models.QueryClassScheduleRequest,
    ) -> dingtalkedu__1__0_models.QueryClassScheduleResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryClassScheduleHeaders()
        return await self.query_class_schedule_with_options_async(request, headers, runtime)

    def query_class_schedule_with_options(
        self,
        request: dingtalkedu__1__0_models.QueryClassScheduleRequest,
        headers: dingtalkedu__1__0_models.QueryClassScheduleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryClassScheduleResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.subscriber_type):
            query['subscriberType'] = request.subscriber_type
        if not UtilClient.is_unset(request.start_time):
            query['startTime'] = request.start_time
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.subscriber_ids):
            body['subscriberIds'] = request.subscriber_ids
        if not UtilClient.is_unset(request.section_index_list):
            body['sectionIndexList'] = request.section_index_list
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryClassScheduleResponse(),
            self.do_roarequest('QueryClassSchedule', 'edu_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/edu/classes/schedules/query', 'json', req, runtime)
        )

    async def query_class_schedule_with_options_async(
        self,
        request: dingtalkedu__1__0_models.QueryClassScheduleRequest,
        headers: dingtalkedu__1__0_models.QueryClassScheduleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryClassScheduleResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.subscriber_type):
            query['subscriberType'] = request.subscriber_type
        if not UtilClient.is_unset(request.start_time):
            query['startTime'] = request.start_time
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.subscriber_ids):
            body['subscriberIds'] = request.subscriber_ids
        if not UtilClient.is_unset(request.section_index_list):
            body['sectionIndexList'] = request.section_index_list
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryClassScheduleResponse(),
            await self.do_roarequest_async('QueryClassSchedule', 'edu_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/edu/classes/schedules/query', 'json', req, runtime)
        )

    def create_remote_class_course(
        self,
        request: dingtalkedu__1__0_models.CreateRemoteClassCourseRequest,
    ) -> dingtalkedu__1__0_models.CreateRemoteClassCourseResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateRemoteClassCourseHeaders()
        return self.create_remote_class_course_with_options(request, headers, runtime)

    async def create_remote_class_course_async(
        self,
        request: dingtalkedu__1__0_models.CreateRemoteClassCourseRequest,
    ) -> dingtalkedu__1__0_models.CreateRemoteClassCourseResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateRemoteClassCourseHeaders()
        return await self.create_remote_class_course_with_options_async(request, headers, runtime)

    def create_remote_class_course_with_options(
        self,
        request: dingtalkedu__1__0_models.CreateRemoteClassCourseRequest,
        headers: dingtalkedu__1__0_models.CreateRemoteClassCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateRemoteClassCourseResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.course_name):
            body['courseName'] = request.course_name
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.teaching_participant):
            body['teachingParticipant'] = request.teaching_participant
        if not UtilClient.is_unset(request.attend_participants):
            body['attendParticipants'] = request.attend_participants
        if not UtilClient.is_unset(request.auth_code):
            body['authCode'] = request.auth_code
        if not UtilClient.is_unset(request.ding_client_id):
            body['dingClientId'] = request.ding_client_id
        if not UtilClient.is_unset(request.ding_suite_key):
            body['dingSuiteKey'] = request.ding_suite_key
        if not UtilClient.is_unset(request.ding_token_grant_type):
            body['dingTokenGrantType'] = request.ding_token_grant_type
        if not UtilClient.is_unset(request.ding_oauth_app_id):
            body['dingOauthAppId'] = request.ding_oauth_app_id
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
        if not UtilClient.is_unset(request.ding_corp_id):
            body['dingCorpId'] = request.ding_corp_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateRemoteClassCourseResponse(),
            self.do_roarequest('CreateRemoteClassCourse', 'edu_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/edu/remoteClasses/courses', 'json', req, runtime)
        )

    async def create_remote_class_course_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CreateRemoteClassCourseRequest,
        headers: dingtalkedu__1__0_models.CreateRemoteClassCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateRemoteClassCourseResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.course_name):
            body['courseName'] = request.course_name
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.teaching_participant):
            body['teachingParticipant'] = request.teaching_participant
        if not UtilClient.is_unset(request.attend_participants):
            body['attendParticipants'] = request.attend_participants
        if not UtilClient.is_unset(request.auth_code):
            body['authCode'] = request.auth_code
        if not UtilClient.is_unset(request.ding_client_id):
            body['dingClientId'] = request.ding_client_id
        if not UtilClient.is_unset(request.ding_suite_key):
            body['dingSuiteKey'] = request.ding_suite_key
        if not UtilClient.is_unset(request.ding_token_grant_type):
            body['dingTokenGrantType'] = request.ding_token_grant_type
        if not UtilClient.is_unset(request.ding_oauth_app_id):
            body['dingOauthAppId'] = request.ding_oauth_app_id
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
        if not UtilClient.is_unset(request.ding_corp_id):
            body['dingCorpId'] = request.ding_corp_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateRemoteClassCourseResponse(),
            await self.do_roarequest_async('CreateRemoteClassCourse', 'edu_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/edu/remoteClasses/courses', 'json', req, runtime)
        )

    def create_custom_class(
        self,
        request: dingtalkedu__1__0_models.CreateCustomClassRequest,
    ) -> dingtalkedu__1__0_models.CreateCustomClassResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateCustomClassHeaders()
        return self.create_custom_class_with_options(request, headers, runtime)

    async def create_custom_class_async(
        self,
        request: dingtalkedu__1__0_models.CreateCustomClassRequest,
    ) -> dingtalkedu__1__0_models.CreateCustomClassResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateCustomClassHeaders()
        return await self.create_custom_class_with_options_async(request, headers, runtime)

    def create_custom_class_with_options(
        self,
        request: dingtalkedu__1__0_models.CreateCustomClassRequest,
        headers: dingtalkedu__1__0_models.CreateCustomClassHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateCustomClassResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.custom_class):
            body['customClass'] = request.custom_class
        if not UtilClient.is_unset(request.super_id):
            body['superId'] = request.super_id
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
        if not UtilClient.is_unset(request.ding_corp_id):
            body['dingCorpId'] = request.ding_corp_id
        if not UtilClient.is_unset(request.ding_oauth_app_id):
            body['dingOauthAppId'] = request.ding_oauth_app_id
        if not UtilClient.is_unset(request.ding_suite_key):
            body['dingSuiteKey'] = request.ding_suite_key
        if not UtilClient.is_unset(request.ding_token_grant_type):
            body['dingTokenGrantType'] = request.ding_token_grant_type
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateCustomClassResponse(),
            self.do_roarequest('CreateCustomClass', 'edu_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/edu/customClasses', 'json', req, runtime)
        )

    async def create_custom_class_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CreateCustomClassRequest,
        headers: dingtalkedu__1__0_models.CreateCustomClassHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateCustomClassResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.custom_class):
            body['customClass'] = request.custom_class
        if not UtilClient.is_unset(request.super_id):
            body['superId'] = request.super_id
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
        if not UtilClient.is_unset(request.ding_corp_id):
            body['dingCorpId'] = request.ding_corp_id
        if not UtilClient.is_unset(request.ding_oauth_app_id):
            body['dingOauthAppId'] = request.ding_oauth_app_id
        if not UtilClient.is_unset(request.ding_suite_key):
            body['dingSuiteKey'] = request.ding_suite_key
        if not UtilClient.is_unset(request.ding_token_grant_type):
            body['dingTokenGrantType'] = request.ding_token_grant_type
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateCustomClassResponse(),
            await self.do_roarequest_async('CreateCustomClass', 'edu_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/edu/customClasses', 'json', req, runtime)
        )

    def update_physical_classroom(
        self,
        request: dingtalkedu__1__0_models.UpdatePhysicalClassroomRequest,
    ) -> dingtalkedu__1__0_models.UpdatePhysicalClassroomResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.UpdatePhysicalClassroomHeaders()
        return self.update_physical_classroom_with_options(request, headers, runtime)

    async def update_physical_classroom_async(
        self,
        request: dingtalkedu__1__0_models.UpdatePhysicalClassroomRequest,
    ) -> dingtalkedu__1__0_models.UpdatePhysicalClassroomResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.UpdatePhysicalClassroomHeaders()
        return await self.update_physical_classroom_with_options_async(request, headers, runtime)

    def update_physical_classroom_with_options(
        self,
        request: dingtalkedu__1__0_models.UpdatePhysicalClassroomRequest,
        headers: dingtalkedu__1__0_models.UpdatePhysicalClassroomHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.UpdatePhysicalClassroomResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.classroom_floor):
            body['classroomFloor'] = request.classroom_floor
        if not UtilClient.is_unset(request.ext):
            body['ext'] = request.ext
        if not UtilClient.is_unset(request.classroom_building):
            body['classroomBuilding'] = request.classroom_building
        if not UtilClient.is_unset(request.direct_broadcast):
            body['directBroadcast'] = request.direct_broadcast
        if not UtilClient.is_unset(request.classroom_name):
            body['classroomName'] = request.classroom_name
        if not UtilClient.is_unset(request.classroom_campus):
            body['classroomCampus'] = request.classroom_campus
        if not UtilClient.is_unset(request.classroom_number):
            body['classroomNumber'] = request.classroom_number
        if not UtilClient.is_unset(request.classroom_id):
            body['classroomId'] = request.classroom_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.UpdatePhysicalClassroomResponse(),
            self.do_roarequest('UpdatePhysicalClassroom', 'edu_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/edu/physicalClassrooms', 'json', req, runtime)
        )

    async def update_physical_classroom_with_options_async(
        self,
        request: dingtalkedu__1__0_models.UpdatePhysicalClassroomRequest,
        headers: dingtalkedu__1__0_models.UpdatePhysicalClassroomHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.UpdatePhysicalClassroomResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.classroom_floor):
            body['classroomFloor'] = request.classroom_floor
        if not UtilClient.is_unset(request.ext):
            body['ext'] = request.ext
        if not UtilClient.is_unset(request.classroom_building):
            body['classroomBuilding'] = request.classroom_building
        if not UtilClient.is_unset(request.direct_broadcast):
            body['directBroadcast'] = request.direct_broadcast
        if not UtilClient.is_unset(request.classroom_name):
            body['classroomName'] = request.classroom_name
        if not UtilClient.is_unset(request.classroom_campus):
            body['classroomCampus'] = request.classroom_campus
        if not UtilClient.is_unset(request.classroom_number):
            body['classroomNumber'] = request.classroom_number
        if not UtilClient.is_unset(request.classroom_id):
            body['classroomId'] = request.classroom_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.UpdatePhysicalClassroomResponse(),
            await self.do_roarequest_async('UpdatePhysicalClassroom', 'edu_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/edu/physicalClassrooms', 'json', req, runtime)
        )

    def move_student(
        self,
        request: dingtalkedu__1__0_models.MoveStudentRequest,
    ) -> dingtalkedu__1__0_models.MoveStudentResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.MoveStudentHeaders()
        return self.move_student_with_options(request, headers, runtime)

    async def move_student_async(
        self,
        request: dingtalkedu__1__0_models.MoveStudentRequest,
    ) -> dingtalkedu__1__0_models.MoveStudentResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.MoveStudentHeaders()
        return await self.move_student_with_options_async(request, headers, runtime)

    def move_student_with_options(
        self,
        request: dingtalkedu__1__0_models.MoveStudentRequest,
        headers: dingtalkedu__1__0_models.MoveStudentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.MoveStudentResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
        if not UtilClient.is_unset(request.ding_corp_id):
            body['dingCorpId'] = request.ding_corp_id
        if not UtilClient.is_unset(request.ding_oauth_app_id):
            body['dingOauthAppId'] = request.ding_oauth_app_id
        if not UtilClient.is_unset(request.ding_suite_key):
            body['dingSuiteKey'] = request.ding_suite_key
        if not UtilClient.is_unset(request.ding_token_grant_type):
            body['dingTokenGrantType'] = request.ding_token_grant_type
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.origin_class_id):
            body['originClassId'] = request.origin_class_id
        if not UtilClient.is_unset(request.target_class_id):
            body['targetClassId'] = request.target_class_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.MoveStudentResponse(),
            self.do_roarequest('MoveStudent', 'edu_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/edu/students/move', 'json', req, runtime)
        )

    async def move_student_with_options_async(
        self,
        request: dingtalkedu__1__0_models.MoveStudentRequest,
        headers: dingtalkedu__1__0_models.MoveStudentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.MoveStudentResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
        if not UtilClient.is_unset(request.ding_corp_id):
            body['dingCorpId'] = request.ding_corp_id
        if not UtilClient.is_unset(request.ding_oauth_app_id):
            body['dingOauthAppId'] = request.ding_oauth_app_id
        if not UtilClient.is_unset(request.ding_suite_key):
            body['dingSuiteKey'] = request.ding_suite_key
        if not UtilClient.is_unset(request.ding_token_grant_type):
            body['dingTokenGrantType'] = request.ding_token_grant_type
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.origin_class_id):
            body['originClassId'] = request.origin_class_id
        if not UtilClient.is_unset(request.target_class_id):
            body['targetClassId'] = request.target_class_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.MoveStudentResponse(),
            await self.do_roarequest_async('MoveStudent', 'edu_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/edu/students/move', 'json', req, runtime)
        )

    def query_edu_asset_spaces(
        self,
        request: dingtalkedu__1__0_models.QueryEduAssetSpacesRequest,
    ) -> dingtalkedu__1__0_models.QueryEduAssetSpacesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryEduAssetSpacesHeaders()
        return self.query_edu_asset_spaces_with_options(request, headers, runtime)

    async def query_edu_asset_spaces_async(
        self,
        request: dingtalkedu__1__0_models.QueryEduAssetSpacesRequest,
    ) -> dingtalkedu__1__0_models.QueryEduAssetSpacesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryEduAssetSpacesHeaders()
        return await self.query_edu_asset_spaces_with_options_async(request, headers, runtime)

    def query_edu_asset_spaces_with_options(
        self,
        request: dingtalkedu__1__0_models.QueryEduAssetSpacesRequest,
        headers: dingtalkedu__1__0_models.QueryEduAssetSpacesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryEduAssetSpacesResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.biz_code):
            query['bizCode'] = request.biz_code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryEduAssetSpacesResponse(),
            self.do_roarequest('QueryEduAssetSpaces', 'edu_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/edu/assets/spaces', 'json', req, runtime)
        )

    async def query_edu_asset_spaces_with_options_async(
        self,
        request: dingtalkedu__1__0_models.QueryEduAssetSpacesRequest,
        headers: dingtalkedu__1__0_models.QueryEduAssetSpacesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryEduAssetSpacesResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.biz_code):
            query['bizCode'] = request.biz_code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryEduAssetSpacesResponse(),
            await self.do_roarequest_async('QueryEduAssetSpaces', 'edu_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/edu/assets/spaces', 'json', req, runtime)
        )

    def create_university_course_group(
        self,
        request: dingtalkedu__1__0_models.CreateUniversityCourseGroupRequest,
    ) -> dingtalkedu__1__0_models.CreateUniversityCourseGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateUniversityCourseGroupHeaders()
        return self.create_university_course_group_with_options(request, headers, runtime)

    async def create_university_course_group_async(
        self,
        request: dingtalkedu__1__0_models.CreateUniversityCourseGroupRequest,
    ) -> dingtalkedu__1__0_models.CreateUniversityCourseGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateUniversityCourseGroupHeaders()
        return await self.create_university_course_group_with_options_async(request, headers, runtime)

    def create_university_course_group_with_options(
        self,
        request: dingtalkedu__1__0_models.CreateUniversityCourseGroupRequest,
        headers: dingtalkedu__1__0_models.CreateUniversityCourseGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateUniversityCourseGroupResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.isv_course_group_code):
            body['isvCourseGroupCode'] = request.isv_course_group_code
        if not UtilClient.is_unset(request.ext):
            body['ext'] = request.ext
        if not UtilClient.is_unset(request.course_group_introduce):
            body['courseGroupIntroduce'] = request.course_group_introduce
        if not UtilClient.is_unset(request.semester):
            body['semester'] = request.semester
        if not UtilClient.is_unset(request.subject_name):
            body['subjectName'] = request.subject_name
        if not UtilClient.is_unset(request.course_group_name):
            body['courseGroupName'] = request.course_group_name
        if not UtilClient.is_unset(request.school_year):
            body['schoolYear'] = request.school_year
        if not UtilClient.is_unset(request.period_code):
            body['periodCode'] = request.period_code
        if not UtilClient.is_unset(request.teacher_infos):
            body['teacherInfos'] = request.teacher_infos
        if not UtilClient.is_unset(request.courser_group_item_models):
            body['courserGroupItemModels'] = request.courser_group_item_models
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateUniversityCourseGroupResponse(),
            self.do_roarequest('CreateUniversityCourseGroup', 'edu_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/edu/universities/courseGroups', 'json', req, runtime)
        )

    async def create_university_course_group_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CreateUniversityCourseGroupRequest,
        headers: dingtalkedu__1__0_models.CreateUniversityCourseGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateUniversityCourseGroupResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.isv_course_group_code):
            body['isvCourseGroupCode'] = request.isv_course_group_code
        if not UtilClient.is_unset(request.ext):
            body['ext'] = request.ext
        if not UtilClient.is_unset(request.course_group_introduce):
            body['courseGroupIntroduce'] = request.course_group_introduce
        if not UtilClient.is_unset(request.semester):
            body['semester'] = request.semester
        if not UtilClient.is_unset(request.subject_name):
            body['subjectName'] = request.subject_name
        if not UtilClient.is_unset(request.course_group_name):
            body['courseGroupName'] = request.course_group_name
        if not UtilClient.is_unset(request.school_year):
            body['schoolYear'] = request.school_year
        if not UtilClient.is_unset(request.period_code):
            body['periodCode'] = request.period_code
        if not UtilClient.is_unset(request.teacher_infos):
            body['teacherInfos'] = request.teacher_infos
        if not UtilClient.is_unset(request.courser_group_item_models):
            body['courserGroupItemModels'] = request.courser_group_item_models
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateUniversityCourseGroupResponse(),
            await self.do_roarequest_async('CreateUniversityCourseGroup', 'edu_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/edu/universities/courseGroups', 'json', req, runtime)
        )

    def get_remote_class_course(
        self,
        course_code: str,
        request: dingtalkedu__1__0_models.GetRemoteClassCourseRequest,
    ) -> dingtalkedu__1__0_models.GetRemoteClassCourseResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetRemoteClassCourseHeaders()
        return self.get_remote_class_course_with_options(course_code, request, headers, runtime)

    async def get_remote_class_course_async(
        self,
        course_code: str,
        request: dingtalkedu__1__0_models.GetRemoteClassCourseRequest,
    ) -> dingtalkedu__1__0_models.GetRemoteClassCourseResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetRemoteClassCourseHeaders()
        return await self.get_remote_class_course_with_options_async(course_code, request, headers, runtime)

    def get_remote_class_course_with_options(
        self,
        course_code: str,
        request: dingtalkedu__1__0_models.GetRemoteClassCourseRequest,
        headers: dingtalkedu__1__0_models.GetRemoteClassCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetRemoteClassCourseResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetRemoteClassCourseResponse(),
            self.do_roarequest('GetRemoteClassCourse', 'edu_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/edu/remoteClasses/courses/{course_code}', 'json', req, runtime)
        )

    async def get_remote_class_course_with_options_async(
        self,
        course_code: str,
        request: dingtalkedu__1__0_models.GetRemoteClassCourseRequest,
        headers: dingtalkedu__1__0_models.GetRemoteClassCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetRemoteClassCourseResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetRemoteClassCourseResponse(),
            await self.do_roarequest_async('GetRemoteClassCourse', 'edu_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/edu/remoteClasses/courses/{course_code}', 'json', req, runtime)
        )

    def query_university_course_group(
        self,
        request: dingtalkedu__1__0_models.QueryUniversityCourseGroupRequest,
    ) -> dingtalkedu__1__0_models.QueryUniversityCourseGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryUniversityCourseGroupHeaders()
        return self.query_university_course_group_with_options(request, headers, runtime)

    async def query_university_course_group_async(
        self,
        request: dingtalkedu__1__0_models.QueryUniversityCourseGroupRequest,
    ) -> dingtalkedu__1__0_models.QueryUniversityCourseGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryUniversityCourseGroupHeaders()
        return await self.query_university_course_group_with_options_async(request, headers, runtime)

    def query_university_course_group_with_options(
        self,
        request: dingtalkedu__1__0_models.QueryUniversityCourseGroupRequest,
        headers: dingtalkedu__1__0_models.QueryUniversityCourseGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryUniversityCourseGroupResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.course_group_code):
            query['courseGroupCode'] = request.course_group_code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryUniversityCourseGroupResponse(),
            self.do_roarequest('QueryUniversityCourseGroup', 'edu_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/edu/universities/courseGroups', 'json', req, runtime)
        )

    async def query_university_course_group_with_options_async(
        self,
        request: dingtalkedu__1__0_models.QueryUniversityCourseGroupRequest,
        headers: dingtalkedu__1__0_models.QueryUniversityCourseGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryUniversityCourseGroupResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.course_group_code):
            query['courseGroupCode'] = request.course_group_code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryUniversityCourseGroupResponse(),
            await self.do_roarequest_async('QueryUniversityCourseGroup', 'edu_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/edu/universities/courseGroups', 'json', req, runtime)
        )

    def query_all_subjects_from_class_schedule(
        self,
        request: dingtalkedu__1__0_models.QueryAllSubjectsFromClassScheduleRequest,
    ) -> dingtalkedu__1__0_models.QueryAllSubjectsFromClassScheduleResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryAllSubjectsFromClassScheduleHeaders()
        return self.query_all_subjects_from_class_schedule_with_options(request, headers, runtime)

    async def query_all_subjects_from_class_schedule_async(
        self,
        request: dingtalkedu__1__0_models.QueryAllSubjectsFromClassScheduleRequest,
    ) -> dingtalkedu__1__0_models.QueryAllSubjectsFromClassScheduleResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryAllSubjectsFromClassScheduleHeaders()
        return await self.query_all_subjects_from_class_schedule_with_options_async(request, headers, runtime)

    def query_all_subjects_from_class_schedule_with_options(
        self,
        tmp_req: dingtalkedu__1__0_models.QueryAllSubjectsFromClassScheduleRequest,
        headers: dingtalkedu__1__0_models.QueryAllSubjectsFromClassScheduleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryAllSubjectsFromClassScheduleResponse:
        UtilClient.validate_model(tmp_req)
        request = dingtalkedu__1__0_models.QueryAllSubjectsFromClassScheduleShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.class_ids):
            request.class_ids_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.class_ids, 'classIds', 'json')
        query = {}
        if not UtilClient.is_unset(request.class_ids_shrink):
            query['classIds'] = request.class_ids_shrink
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.period_code):
            query['periodCode'] = request.period_code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryAllSubjectsFromClassScheduleResponse(),
            self.do_roarequest('QueryAllSubjectsFromClassSchedule', 'edu_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/edu/subjects/instances', 'json', req, runtime)
        )

    async def query_all_subjects_from_class_schedule_with_options_async(
        self,
        tmp_req: dingtalkedu__1__0_models.QueryAllSubjectsFromClassScheduleRequest,
        headers: dingtalkedu__1__0_models.QueryAllSubjectsFromClassScheduleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryAllSubjectsFromClassScheduleResponse:
        UtilClient.validate_model(tmp_req)
        request = dingtalkedu__1__0_models.QueryAllSubjectsFromClassScheduleShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.class_ids):
            request.class_ids_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.class_ids, 'classIds', 'json')
        query = {}
        if not UtilClient.is_unset(request.class_ids_shrink):
            query['classIds'] = request.class_ids_shrink
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.period_code):
            query['periodCode'] = request.period_code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryAllSubjectsFromClassScheduleResponse(),
            await self.do_roarequest_async('QueryAllSubjectsFromClassSchedule', 'edu_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/edu/subjects/instances', 'json', req, runtime)
        )

    def course_scheduling_compliment_notice(
        self,
        request: dingtalkedu__1__0_models.CourseSchedulingComplimentNoticeRequest,
    ) -> dingtalkedu__1__0_models.CourseSchedulingComplimentNoticeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CourseSchedulingComplimentNoticeHeaders()
        return self.course_scheduling_compliment_notice_with_options(request, headers, runtime)

    async def course_scheduling_compliment_notice_async(
        self,
        request: dingtalkedu__1__0_models.CourseSchedulingComplimentNoticeRequest,
    ) -> dingtalkedu__1__0_models.CourseSchedulingComplimentNoticeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CourseSchedulingComplimentNoticeHeaders()
        return await self.course_scheduling_compliment_notice_with_options_async(request, headers, runtime)

    def course_scheduling_compliment_notice_with_options(
        self,
        request: dingtalkedu__1__0_models.CourseSchedulingComplimentNoticeRequest,
        headers: dingtalkedu__1__0_models.CourseSchedulingComplimentNoticeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CourseSchedulingComplimentNoticeResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CourseSchedulingComplimentNoticeResponse(),
            self.do_roarequest('CourseSchedulingComplimentNotice', 'edu_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/edu/schedules/finishNotify', 'json', req, runtime)
        )

    async def course_scheduling_compliment_notice_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CourseSchedulingComplimentNoticeRequest,
        headers: dingtalkedu__1__0_models.CourseSchedulingComplimentNoticeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CourseSchedulingComplimentNoticeResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CourseSchedulingComplimentNoticeResponse(),
            await self.do_roarequest_async('CourseSchedulingComplimentNotice', 'edu_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/edu/schedules/finishNotify', 'json', req, runtime)
        )

    def delete_university_course_group(
        self,
        request: dingtalkedu__1__0_models.DeleteUniversityCourseGroupRequest,
    ) -> dingtalkedu__1__0_models.DeleteUniversityCourseGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteUniversityCourseGroupHeaders()
        return self.delete_university_course_group_with_options(request, headers, runtime)

    async def delete_university_course_group_async(
        self,
        request: dingtalkedu__1__0_models.DeleteUniversityCourseGroupRequest,
    ) -> dingtalkedu__1__0_models.DeleteUniversityCourseGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteUniversityCourseGroupHeaders()
        return await self.delete_university_course_group_with_options_async(request, headers, runtime)

    def delete_university_course_group_with_options(
        self,
        request: dingtalkedu__1__0_models.DeleteUniversityCourseGroupRequest,
        headers: dingtalkedu__1__0_models.DeleteUniversityCourseGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteUniversityCourseGroupResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.course_group_code):
            query['courseGroupCode'] = request.course_group_code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteUniversityCourseGroupResponse(),
            self.do_roarequest('DeleteUniversityCourseGroup', 'edu_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/edu/universities/courseGroups', 'json', req, runtime)
        )

    async def delete_university_course_group_with_options_async(
        self,
        request: dingtalkedu__1__0_models.DeleteUniversityCourseGroupRequest,
        headers: dingtalkedu__1__0_models.DeleteUniversityCourseGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteUniversityCourseGroupResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.course_group_code):
            query['courseGroupCode'] = request.course_group_code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteUniversityCourseGroupResponse(),
            await self.do_roarequest_async('DeleteUniversityCourseGroup', 'edu_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/edu/universities/courseGroups', 'json', req, runtime)
        )

    def delete_dept(
        self,
        dept_id: str,
        request: dingtalkedu__1__0_models.DeleteDeptRequest,
    ) -> dingtalkedu__1__0_models.DeleteDeptResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteDeptHeaders()
        return self.delete_dept_with_options(dept_id, request, headers, runtime)

    async def delete_dept_async(
        self,
        dept_id: str,
        request: dingtalkedu__1__0_models.DeleteDeptRequest,
    ) -> dingtalkedu__1__0_models.DeleteDeptResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteDeptHeaders()
        return await self.delete_dept_with_options_async(dept_id, request, headers, runtime)

    def delete_dept_with_options(
        self,
        dept_id: str,
        request: dingtalkedu__1__0_models.DeleteDeptRequest,
        headers: dingtalkedu__1__0_models.DeleteDeptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteDeptResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteDeptResponse(),
            self.do_roarequest('DeleteDept', 'edu_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/edu/depts/{dept_id}', 'json', req, runtime)
        )

    async def delete_dept_with_options_async(
        self,
        dept_id: str,
        request: dingtalkedu__1__0_models.DeleteDeptRequest,
        headers: dingtalkedu__1__0_models.DeleteDeptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteDeptResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteDeptResponse(),
            await self.do_roarequest_async('DeleteDept', 'edu_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/edu/depts/{dept_id}', 'json', req, runtime)
        )

    def delete_guardian(
        self,
        class_id: str,
        user_id: str,
        request: dingtalkedu__1__0_models.DeleteGuardianRequest,
    ) -> dingtalkedu__1__0_models.DeleteGuardianResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteGuardianHeaders()
        return self.delete_guardian_with_options(class_id, user_id, request, headers, runtime)

    async def delete_guardian_async(
        self,
        class_id: str,
        user_id: str,
        request: dingtalkedu__1__0_models.DeleteGuardianRequest,
    ) -> dingtalkedu__1__0_models.DeleteGuardianResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteGuardianHeaders()
        return await self.delete_guardian_with_options_async(class_id, user_id, request, headers, runtime)

    def delete_guardian_with_options(
        self,
        class_id: str,
        user_id: str,
        request: dingtalkedu__1__0_models.DeleteGuardianRequest,
        headers: dingtalkedu__1__0_models.DeleteGuardianHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteGuardianResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stu_id):
            query['stuId'] = request.stu_id
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteGuardianResponse(),
            self.do_roarequest('DeleteGuardian', 'edu_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/edu/classes/{class_id}/guardians/{user_id}', 'json', req, runtime)
        )

    async def delete_guardian_with_options_async(
        self,
        class_id: str,
        user_id: str,
        request: dingtalkedu__1__0_models.DeleteGuardianRequest,
        headers: dingtalkedu__1__0_models.DeleteGuardianHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteGuardianResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stu_id):
            query['stuId'] = request.stu_id
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteGuardianResponse(),
            await self.do_roarequest_async('DeleteGuardian', 'edu_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/edu/classes/{class_id}/guardians/{user_id}', 'json', req, runtime)
        )

    def insert_section_config(
        self,
        request: dingtalkedu__1__0_models.InsertSectionConfigRequest,
    ) -> dingtalkedu__1__0_models.InsertSectionConfigResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.InsertSectionConfigHeaders()
        return self.insert_section_config_with_options(request, headers, runtime)

    async def insert_section_config_async(
        self,
        request: dingtalkedu__1__0_models.InsertSectionConfigRequest,
    ) -> dingtalkedu__1__0_models.InsertSectionConfigResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.InsertSectionConfigHeaders()
        return await self.insert_section_config_with_options_async(request, headers, runtime)

    def insert_section_config_with_options(
        self,
        request: dingtalkedu__1__0_models.InsertSectionConfigRequest,
        headers: dingtalkedu__1__0_models.InsertSectionConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.InsertSectionConfigResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.section_models):
            body['sectionModels'] = request.section_models
        if not UtilClient.is_unset(request.start):
            body['start'] = request.start
        if not UtilClient.is_unset(request.end):
            body['end'] = request.end
        if not UtilClient.is_unset(request.schedule_name):
            body['scheduleName'] = request.schedule_name
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.InsertSectionConfigResponse(),
            self.do_roarequest('InsertSectionConfig', 'edu_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/edu/schedules/configs', 'json', req, runtime)
        )

    async def insert_section_config_with_options_async(
        self,
        request: dingtalkedu__1__0_models.InsertSectionConfigRequest,
        headers: dingtalkedu__1__0_models.InsertSectionConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.InsertSectionConfigResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.section_models):
            body['sectionModels'] = request.section_models
        if not UtilClient.is_unset(request.start):
            body['start'] = request.start
        if not UtilClient.is_unset(request.end):
            body['end'] = request.end
        if not UtilClient.is_unset(request.schedule_name):
            body['scheduleName'] = request.schedule_name
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.InsertSectionConfigResponse(),
            await self.do_roarequest_async('InsertSectionConfig', 'edu_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/edu/schedules/configs', 'json', req, runtime)
        )

    def query_device_list_by_corp_id(
        self,
        request: dingtalkedu__1__0_models.QueryDeviceListByCorpIdRequest,
    ) -> dingtalkedu__1__0_models.QueryDeviceListByCorpIdResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryDeviceListByCorpIdHeaders()
        return self.query_device_list_by_corp_id_with_options(request, headers, runtime)

    async def query_device_list_by_corp_id_async(
        self,
        request: dingtalkedu__1__0_models.QueryDeviceListByCorpIdRequest,
    ) -> dingtalkedu__1__0_models.QueryDeviceListByCorpIdResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryDeviceListByCorpIdHeaders()
        return await self.query_device_list_by_corp_id_with_options_async(request, headers, runtime)

    def query_device_list_by_corp_id_with_options(
        self,
        request: dingtalkedu__1__0_models.QueryDeviceListByCorpIdRequest,
        headers: dingtalkedu__1__0_models.QueryDeviceListByCorpIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryDeviceListByCorpIdResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryDeviceListByCorpIdResponse(),
            self.do_roarequest('QueryDeviceListByCorpId', 'edu_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/edu/remoteClasses/devices', 'json', req, runtime)
        )

    async def query_device_list_by_corp_id_with_options_async(
        self,
        request: dingtalkedu__1__0_models.QueryDeviceListByCorpIdRequest,
        headers: dingtalkedu__1__0_models.QueryDeviceListByCorpIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryDeviceListByCorpIdResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryDeviceListByCorpIdResponse(),
            await self.do_roarequest_async('QueryDeviceListByCorpId', 'edu_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/edu/remoteClasses/devices', 'json', req, runtime)
        )

    def update_university_course_group(
        self,
        request: dingtalkedu__1__0_models.UpdateUniversityCourseGroupRequest,
    ) -> dingtalkedu__1__0_models.UpdateUniversityCourseGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.UpdateUniversityCourseGroupHeaders()
        return self.update_university_course_group_with_options(request, headers, runtime)

    async def update_university_course_group_async(
        self,
        request: dingtalkedu__1__0_models.UpdateUniversityCourseGroupRequest,
    ) -> dingtalkedu__1__0_models.UpdateUniversityCourseGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.UpdateUniversityCourseGroupHeaders()
        return await self.update_university_course_group_with_options_async(request, headers, runtime)

    def update_university_course_group_with_options(
        self,
        request: dingtalkedu__1__0_models.UpdateUniversityCourseGroupRequest,
        headers: dingtalkedu__1__0_models.UpdateUniversityCourseGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.UpdateUniversityCourseGroupResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.ext):
            body['ext'] = request.ext
        if not UtilClient.is_unset(request.course_group_code):
            body['courseGroupCode'] = request.course_group_code
        if not UtilClient.is_unset(request.course_group_introduce):
            body['courseGroupIntroduce'] = request.course_group_introduce
        if not UtilClient.is_unset(request.course_group_name):
            body['courseGroupName'] = request.course_group_name
        if not UtilClient.is_unset(request.courser_group_item_models):
            body['courserGroupItemModels'] = request.courser_group_item_models
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.UpdateUniversityCourseGroupResponse(),
            self.do_roarequest('UpdateUniversityCourseGroup', 'edu_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/edu/universities/courseGroups', 'json', req, runtime)
        )

    async def update_university_course_group_with_options_async(
        self,
        request: dingtalkedu__1__0_models.UpdateUniversityCourseGroupRequest,
        headers: dingtalkedu__1__0_models.UpdateUniversityCourseGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.UpdateUniversityCourseGroupResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.ext):
            body['ext'] = request.ext
        if not UtilClient.is_unset(request.course_group_code):
            body['courseGroupCode'] = request.course_group_code
        if not UtilClient.is_unset(request.course_group_introduce):
            body['courseGroupIntroduce'] = request.course_group_introduce
        if not UtilClient.is_unset(request.course_group_name):
            body['courseGroupName'] = request.course_group_name
        if not UtilClient.is_unset(request.courser_group_item_models):
            body['courserGroupItemModels'] = request.courser_group_item_models
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.UpdateUniversityCourseGroupResponse(),
            await self.do_roarequest_async('UpdateUniversityCourseGroup', 'edu_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/edu/universities/courseGroups', 'json', req, runtime)
        )

    def batch_org_create_hw(
        self,
        request: dingtalkedu__1__0_models.BatchOrgCreateHWRequest,
    ) -> dingtalkedu__1__0_models.BatchOrgCreateHWResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.BatchOrgCreateHWHeaders()
        return self.batch_org_create_hwwith_options(request, headers, runtime)

    async def batch_org_create_hw_async(
        self,
        request: dingtalkedu__1__0_models.BatchOrgCreateHWRequest,
    ) -> dingtalkedu__1__0_models.BatchOrgCreateHWResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.BatchOrgCreateHWHeaders()
        return await self.batch_org_create_hwwith_options_async(request, headers, runtime)

    def batch_org_create_hwwith_options(
        self,
        request: dingtalkedu__1__0_models.BatchOrgCreateHWRequest,
        headers: dingtalkedu__1__0_models.BatchOrgCreateHWHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.BatchOrgCreateHWResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.hw_media):
            body['hwMedia'] = request.hw_media
        if not UtilClient.is_unset(request.hw_content):
            body['hwContent'] = request.hw_content
        if not UtilClient.is_unset(request.hw_title):
            body['hwTitle'] = request.hw_title
        if not UtilClient.is_unset(request.course_name):
            body['courseName'] = request.course_name
        if not UtilClient.is_unset(request.hw_photo):
            body['hwPhoto'] = request.hw_photo
        if not UtilClient.is_unset(request.hw_video):
            body['hwVideo'] = request.hw_video
        if not UtilClient.is_unset(request.teacher_name):
            body['teacherName'] = request.teacher_name
        if not UtilClient.is_unset(request.teacher_user_id):
            body['teacherUserId'] = request.teacher_user_id
        if not UtilClient.is_unset(request.identifier):
            body['identifier'] = request.identifier
        if not UtilClient.is_unset(request.attributes):
            body['attributes'] = request.attributes
        if not UtilClient.is_unset(request.target_role):
            body['targetRole'] = request.target_role
        if not UtilClient.is_unset(request.biz_code):
            body['bizCode'] = request.biz_code
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
        if not UtilClient.is_unset(request.scheduled_release):
            body['scheduledRelease'] = request.scheduled_release
        if not UtilClient.is_unset(request.scheduled_time):
            body['scheduledTime'] = request.scheduled_time
        if not UtilClient.is_unset(request.hw_deadline_open):
            body['hwDeadlineOpen'] = request.hw_deadline_open
        if not UtilClient.is_unset(request.hw_deadline):
            body['hwDeadline'] = request.hw_deadline
        if not UtilClient.is_unset(request.hw_type):
            body['hwType'] = request.hw_type
        if not UtilClient.is_unset(request.open_select_item_list):
            body['openSelectItemList'] = request.open_select_item_list
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.BatchOrgCreateHWResponse(),
            self.do_roarequest('BatchOrgCreateHW', 'edu_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/edu/homeworks', 'json', req, runtime)
        )

    async def batch_org_create_hwwith_options_async(
        self,
        request: dingtalkedu__1__0_models.BatchOrgCreateHWRequest,
        headers: dingtalkedu__1__0_models.BatchOrgCreateHWHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.BatchOrgCreateHWResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.hw_media):
            body['hwMedia'] = request.hw_media
        if not UtilClient.is_unset(request.hw_content):
            body['hwContent'] = request.hw_content
        if not UtilClient.is_unset(request.hw_title):
            body['hwTitle'] = request.hw_title
        if not UtilClient.is_unset(request.course_name):
            body['courseName'] = request.course_name
        if not UtilClient.is_unset(request.hw_photo):
            body['hwPhoto'] = request.hw_photo
        if not UtilClient.is_unset(request.hw_video):
            body['hwVideo'] = request.hw_video
        if not UtilClient.is_unset(request.teacher_name):
            body['teacherName'] = request.teacher_name
        if not UtilClient.is_unset(request.teacher_user_id):
            body['teacherUserId'] = request.teacher_user_id
        if not UtilClient.is_unset(request.identifier):
            body['identifier'] = request.identifier
        if not UtilClient.is_unset(request.attributes):
            body['attributes'] = request.attributes
        if not UtilClient.is_unset(request.target_role):
            body['targetRole'] = request.target_role
        if not UtilClient.is_unset(request.biz_code):
            body['bizCode'] = request.biz_code
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
        if not UtilClient.is_unset(request.scheduled_release):
            body['scheduledRelease'] = request.scheduled_release
        if not UtilClient.is_unset(request.scheduled_time):
            body['scheduledTime'] = request.scheduled_time
        if not UtilClient.is_unset(request.hw_deadline_open):
            body['hwDeadlineOpen'] = request.hw_deadline_open
        if not UtilClient.is_unset(request.hw_deadline):
            body['hwDeadline'] = request.hw_deadline
        if not UtilClient.is_unset(request.hw_type):
            body['hwType'] = request.hw_type
        if not UtilClient.is_unset(request.open_select_item_list):
            body['openSelectItemList'] = request.open_select_item_list
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.BatchOrgCreateHWResponse(),
            await self.do_roarequest_async('BatchOrgCreateHW', 'edu_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/edu/homeworks', 'json', req, runtime)
        )

    def create_custom_dept(
        self,
        request: dingtalkedu__1__0_models.CreateCustomDeptRequest,
    ) -> dingtalkedu__1__0_models.CreateCustomDeptResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateCustomDeptHeaders()
        return self.create_custom_dept_with_options(request, headers, runtime)

    async def create_custom_dept_async(
        self,
        request: dingtalkedu__1__0_models.CreateCustomDeptRequest,
    ) -> dingtalkedu__1__0_models.CreateCustomDeptResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateCustomDeptHeaders()
        return await self.create_custom_dept_with_options_async(request, headers, runtime)

    def create_custom_dept_with_options(
        self,
        request: dingtalkedu__1__0_models.CreateCustomDeptRequest,
        headers: dingtalkedu__1__0_models.CreateCustomDeptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateCustomDeptResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.custom_dept):
            body['customDept'] = request.custom_dept
        if not UtilClient.is_unset(request.super_id):
            body['superId'] = request.super_id
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
        if not UtilClient.is_unset(request.ding_token_grant_type):
            body['dingTokenGrantType'] = request.ding_token_grant_type
        if not UtilClient.is_unset(request.ding_suite_key):
            body['dingSuiteKey'] = request.ding_suite_key
        if not UtilClient.is_unset(request.ding_oauth_app_id):
            body['dingOauthAppId'] = request.ding_oauth_app_id
        if not UtilClient.is_unset(request.ding_corp_id):
            body['dingCorpId'] = request.ding_corp_id
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateCustomDeptResponse(),
            self.do_roarequest('CreateCustomDept', 'edu_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/edu/customDepts', 'json', req, runtime)
        )

    async def create_custom_dept_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CreateCustomDeptRequest,
        headers: dingtalkedu__1__0_models.CreateCustomDeptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateCustomDeptResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.custom_dept):
            body['customDept'] = request.custom_dept
        if not UtilClient.is_unset(request.super_id):
            body['superId'] = request.super_id
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
        if not UtilClient.is_unset(request.ding_token_grant_type):
            body['dingTokenGrantType'] = request.ding_token_grant_type
        if not UtilClient.is_unset(request.ding_suite_key):
            body['dingSuiteKey'] = request.ding_suite_key
        if not UtilClient.is_unset(request.ding_oauth_app_id):
            body['dingOauthAppId'] = request.ding_oauth_app_id
        if not UtilClient.is_unset(request.ding_corp_id):
            body['dingCorpId'] = request.ding_corp_id
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateCustomDeptResponse(),
            await self.do_roarequest_async('CreateCustomDept', 'edu_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/edu/customDepts', 'json', req, runtime)
        )

    def start_course_prepare(
        self,
        request: dingtalkedu__1__0_models.StartCoursePrepareRequest,
    ) -> dingtalkedu__1__0_models.StartCoursePrepareResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.StartCoursePrepareHeaders()
        return self.start_course_prepare_with_options(request, headers, runtime)

    async def start_course_prepare_async(
        self,
        request: dingtalkedu__1__0_models.StartCoursePrepareRequest,
    ) -> dingtalkedu__1__0_models.StartCoursePrepareResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.StartCoursePrepareHeaders()
        return await self.start_course_prepare_with_options_async(request, headers, runtime)

    def start_course_prepare_with_options(
        self,
        request: dingtalkedu__1__0_models.StartCoursePrepareRequest,
        headers: dingtalkedu__1__0_models.StartCoursePrepareHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.StartCoursePrepareResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.ext):
            body['ext'] = request.ext
        if not UtilClient.is_unset(request.course_group_code):
            body['courseGroupCode'] = request.course_group_code
        if not UtilClient.is_unset(request.section_index):
            body['sectionIndex'] = request.section_index
        if not UtilClient.is_unset(request.device_id):
            body['deviceId'] = request.device_id
        if not UtilClient.is_unset(request.live_cover_image):
            body['liveCoverImage'] = request.live_cover_image
        if not UtilClient.is_unset(request.course_date):
            body['courseDate'] = request.course_date
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.StartCoursePrepareResponse(),
            self.do_roarequest('StartCoursePrepare', 'edu_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/edu/universities/courses/prepare', 'json', req, runtime)
        )

    async def start_course_prepare_with_options_async(
        self,
        request: dingtalkedu__1__0_models.StartCoursePrepareRequest,
        headers: dingtalkedu__1__0_models.StartCoursePrepareHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.StartCoursePrepareResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.ext):
            body['ext'] = request.ext
        if not UtilClient.is_unset(request.course_group_code):
            body['courseGroupCode'] = request.course_group_code
        if not UtilClient.is_unset(request.section_index):
            body['sectionIndex'] = request.section_index
        if not UtilClient.is_unset(request.device_id):
            body['deviceId'] = request.device_id
        if not UtilClient.is_unset(request.live_cover_image):
            body['liveCoverImage'] = request.live_cover_image
        if not UtilClient.is_unset(request.course_date):
            body['courseDate'] = request.course_date
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.StartCoursePrepareResponse(),
            await self.do_roarequest_async('StartCoursePrepare', 'edu_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/edu/universities/courses/prepare', 'json', req, runtime)
        )

    def query_class_schedule_by_time_school(
        self,
        request: dingtalkedu__1__0_models.QueryClassScheduleByTimeSchoolRequest,
    ) -> dingtalkedu__1__0_models.QueryClassScheduleByTimeSchoolResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryClassScheduleByTimeSchoolHeaders()
        return self.query_class_schedule_by_time_school_with_options(request, headers, runtime)

    async def query_class_schedule_by_time_school_async(
        self,
        request: dingtalkedu__1__0_models.QueryClassScheduleByTimeSchoolRequest,
    ) -> dingtalkedu__1__0_models.QueryClassScheduleByTimeSchoolResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryClassScheduleByTimeSchoolHeaders()
        return await self.query_class_schedule_by_time_school_with_options_async(request, headers, runtime)

    def query_class_schedule_by_time_school_with_options(
        self,
        request: dingtalkedu__1__0_models.QueryClassScheduleByTimeSchoolRequest,
        headers: dingtalkedu__1__0_models.QueryClassScheduleByTimeSchoolHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryClassScheduleByTimeSchoolResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.start_time):
            query['startTime'] = request.start_time
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryClassScheduleByTimeSchoolResponse(),
            self.do_roarequest('QueryClassScheduleByTimeSchool', 'edu_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/edu/schools/classes/courses ', 'json', req, runtime)
        )

    async def query_class_schedule_by_time_school_with_options_async(
        self,
        request: dingtalkedu__1__0_models.QueryClassScheduleByTimeSchoolRequest,
        headers: dingtalkedu__1__0_models.QueryClassScheduleByTimeSchoolHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryClassScheduleByTimeSchoolResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.start_time):
            query['startTime'] = request.start_time
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryClassScheduleByTimeSchoolResponse(),
            await self.do_roarequest_async('QueryClassScheduleByTimeSchool', 'edu_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/edu/schools/classes/courses ', 'json', req, runtime)
        )

    def query_teach_subjects(
        self,
        request: dingtalkedu__1__0_models.QueryTeachSubjectsRequest,
    ) -> dingtalkedu__1__0_models.QueryTeachSubjectsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryTeachSubjectsHeaders()
        return self.query_teach_subjects_with_options(request, headers, runtime)

    async def query_teach_subjects_async(
        self,
        request: dingtalkedu__1__0_models.QueryTeachSubjectsRequest,
    ) -> dingtalkedu__1__0_models.QueryTeachSubjectsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryTeachSubjectsHeaders()
        return await self.query_teach_subjects_with_options_async(request, headers, runtime)

    def query_teach_subjects_with_options(
        self,
        request: dingtalkedu__1__0_models.QueryTeachSubjectsRequest,
        headers: dingtalkedu__1__0_models.QueryTeachSubjectsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryTeachSubjectsResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.class_ids):
            query['classIds'] = request.class_ids
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryTeachSubjectsResponse(),
            self.do_roarequest('QueryTeachSubjects', 'edu_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/edu/teachers/subjects', 'json', req, runtime)
        )

    async def query_teach_subjects_with_options_async(
        self,
        request: dingtalkedu__1__0_models.QueryTeachSubjectsRequest,
        headers: dingtalkedu__1__0_models.QueryTeachSubjectsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryTeachSubjectsResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.class_ids):
            query['classIds'] = request.class_ids
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryTeachSubjectsResponse(),
            await self.do_roarequest_async('QueryTeachSubjects', 'edu_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/edu/teachers/subjects', 'json', req, runtime)
        )

    def get_share_roles(self) -> dingtalkedu__1__0_models.GetShareRolesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetShareRolesHeaders()
        return self.get_share_roles_with_options(headers, runtime)

    async def get_share_roles_async(self) -> dingtalkedu__1__0_models.GetShareRolesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetShareRolesHeaders()
        return await self.get_share_roles_with_options_async(headers, runtime)

    def get_share_roles_with_options(
        self,
        headers: dingtalkedu__1__0_models.GetShareRolesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetShareRolesResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetShareRolesResponse(),
            self.do_roarequest('GetShareRoles', 'edu_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/edu/shareRoles', 'json', req, runtime)
        )

    async def get_share_roles_with_options_async(
        self,
        headers: dingtalkedu__1__0_models.GetShareRolesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetShareRolesResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetShareRolesResponse(),
            await self.do_roarequest_async('GetShareRoles', 'edu_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/edu/shareRoles', 'json', req, runtime)
        )

    def subscribe_university_course_group(
        self,
        request: dingtalkedu__1__0_models.SubscribeUniversityCourseGroupRequest,
    ) -> dingtalkedu__1__0_models.SubscribeUniversityCourseGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.SubscribeUniversityCourseGroupHeaders()
        return self.subscribe_university_course_group_with_options(request, headers, runtime)

    async def subscribe_university_course_group_async(
        self,
        request: dingtalkedu__1__0_models.SubscribeUniversityCourseGroupRequest,
    ) -> dingtalkedu__1__0_models.SubscribeUniversityCourseGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.SubscribeUniversityCourseGroupHeaders()
        return await self.subscribe_university_course_group_with_options_async(request, headers, runtime)

    def subscribe_university_course_group_with_options(
        self,
        request: dingtalkedu__1__0_models.SubscribeUniversityCourseGroupRequest,
        headers: dingtalkedu__1__0_models.SubscribeUniversityCourseGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.SubscribeUniversityCourseGroupResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.course_group_code):
            body['courseGroupCode'] = request.course_group_code
        if not UtilClient.is_unset(request.student_user_ids):
            body['studentUserIds'] = request.student_user_ids
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.SubscribeUniversityCourseGroupResponse(),
            self.do_roarequest('SubscribeUniversityCourseGroup', 'edu_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/edu/universities/courseGroups/subscribe', 'json', req, runtime)
        )

    async def subscribe_university_course_group_with_options_async(
        self,
        request: dingtalkedu__1__0_models.SubscribeUniversityCourseGroupRequest,
        headers: dingtalkedu__1__0_models.SubscribeUniversityCourseGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.SubscribeUniversityCourseGroupResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.course_group_code):
            body['courseGroupCode'] = request.course_group_code
        if not UtilClient.is_unset(request.student_user_ids):
            body['studentUserIds'] = request.student_user_ids
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.SubscribeUniversityCourseGroupResponse(),
            await self.do_roarequest_async('SubscribeUniversityCourseGroup', 'edu_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/edu/universities/courseGroups/subscribe', 'json', req, runtime)
        )

    def delete_org_relation(
        self,
        request: dingtalkedu__1__0_models.DeleteOrgRelationRequest,
    ) -> dingtalkedu__1__0_models.DeleteOrgRelationResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteOrgRelationHeaders()
        return self.delete_org_relation_with_options(request, headers, runtime)

    async def delete_org_relation_async(
        self,
        request: dingtalkedu__1__0_models.DeleteOrgRelationRequest,
    ) -> dingtalkedu__1__0_models.DeleteOrgRelationResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteOrgRelationHeaders()
        return await self.delete_org_relation_with_options_async(request, headers, runtime)

    def delete_org_relation_with_options(
        self,
        request: dingtalkedu__1__0_models.DeleteOrgRelationRequest,
        headers: dingtalkedu__1__0_models.DeleteOrgRelationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteOrgRelationResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.target_corp_id):
            query['targetCorpId'] = request.target_corp_id
        if not UtilClient.is_unset(request.auth_code):
            query['authCode'] = request.auth_code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteOrgRelationResponse(),
            self.do_roarequest('DeleteOrgRelation', 'edu_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/edu/remoteClasses/orgRelations', 'json', req, runtime)
        )

    async def delete_org_relation_with_options_async(
        self,
        request: dingtalkedu__1__0_models.DeleteOrgRelationRequest,
        headers: dingtalkedu__1__0_models.DeleteOrgRelationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteOrgRelationResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.target_corp_id):
            query['targetCorpId'] = request.target_corp_id
        if not UtilClient.is_unset(request.auth_code):
            query['authCode'] = request.auth_code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteOrgRelationResponse(),
            await self.do_roarequest_async('DeleteOrgRelation', 'edu_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/edu/remoteClasses/orgRelations', 'json', req, runtime)
        )

    def start_course(
        self,
        request: dingtalkedu__1__0_models.StartCourseRequest,
    ) -> dingtalkedu__1__0_models.StartCourseResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.StartCourseHeaders()
        return self.start_course_with_options(request, headers, runtime)

    async def start_course_async(
        self,
        request: dingtalkedu__1__0_models.StartCourseRequest,
    ) -> dingtalkedu__1__0_models.StartCourseResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.StartCourseHeaders()
        return await self.start_course_with_options_async(request, headers, runtime)

    def start_course_with_options(
        self,
        request: dingtalkedu__1__0_models.StartCourseRequest,
        headers: dingtalkedu__1__0_models.StartCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.StartCourseResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.ext):
            body['ext'] = request.ext
        if not UtilClient.is_unset(request.course_code):
            body['courseCode'] = request.course_code
        if not UtilClient.is_unset(request.live_play_info_list):
            body['livePlayInfoList'] = request.live_play_info_list
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.StartCourseResponse(),
            self.do_roarequest('StartCourse', 'edu_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/edu/universities/courses/start', 'json', req, runtime)
        )

    async def start_course_with_options_async(
        self,
        request: dingtalkedu__1__0_models.StartCourseRequest,
        headers: dingtalkedu__1__0_models.StartCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.StartCourseResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.ext):
            body['ext'] = request.ext
        if not UtilClient.is_unset(request.course_code):
            body['courseCode'] = request.course_code
        if not UtilClient.is_unset(request.live_play_info_list):
            body['livePlayInfoList'] = request.live_play_info_list
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.StartCourseResponse(),
            await self.do_roarequest_async('StartCourse', 'edu_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/edu/universities/courses/start', 'json', req, runtime)
        )

    def query_physical_classroom(
        self,
        request: dingtalkedu__1__0_models.QueryPhysicalClassroomRequest,
    ) -> dingtalkedu__1__0_models.QueryPhysicalClassroomResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryPhysicalClassroomHeaders()
        return self.query_physical_classroom_with_options(request, headers, runtime)

    async def query_physical_classroom_async(
        self,
        request: dingtalkedu__1__0_models.QueryPhysicalClassroomRequest,
    ) -> dingtalkedu__1__0_models.QueryPhysicalClassroomResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryPhysicalClassroomHeaders()
        return await self.query_physical_classroom_with_options_async(request, headers, runtime)

    def query_physical_classroom_with_options(
        self,
        request: dingtalkedu__1__0_models.QueryPhysicalClassroomRequest,
        headers: dingtalkedu__1__0_models.QueryPhysicalClassroomHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryPhysicalClassroomResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.classroom_id):
            query['classroomId'] = request.classroom_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryPhysicalClassroomResponse(),
            self.do_roarequest('QueryPhysicalClassroom', 'edu_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/edu/physicalClassrooms', 'json', req, runtime)
        )

    async def query_physical_classroom_with_options_async(
        self,
        request: dingtalkedu__1__0_models.QueryPhysicalClassroomRequest,
        headers: dingtalkedu__1__0_models.QueryPhysicalClassroomHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryPhysicalClassroomResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.classroom_id):
            query['classroomId'] = request.classroom_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryPhysicalClassroomResponse(),
            await self.do_roarequest_async('QueryPhysicalClassroom', 'edu_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/edu/physicalClassrooms', 'json', req, runtime)
        )

    def update_remote_class_course(
        self,
        request: dingtalkedu__1__0_models.UpdateRemoteClassCourseRequest,
    ) -> dingtalkedu__1__0_models.UpdateRemoteClassCourseResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.UpdateRemoteClassCourseHeaders()
        return self.update_remote_class_course_with_options(request, headers, runtime)

    async def update_remote_class_course_async(
        self,
        request: dingtalkedu__1__0_models.UpdateRemoteClassCourseRequest,
    ) -> dingtalkedu__1__0_models.UpdateRemoteClassCourseResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.UpdateRemoteClassCourseHeaders()
        return await self.update_remote_class_course_with_options_async(request, headers, runtime)

    def update_remote_class_course_with_options(
        self,
        request: dingtalkedu__1__0_models.UpdateRemoteClassCourseRequest,
        headers: dingtalkedu__1__0_models.UpdateRemoteClassCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.UpdateRemoteClassCourseResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.course_name):
            body['courseName'] = request.course_name
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.teaching_participant):
            body['teachingParticipant'] = request.teaching_participant
        if not UtilClient.is_unset(request.attend_participants):
            body['attendParticipants'] = request.attend_participants
        if not UtilClient.is_unset(request.course_code):
            body['courseCode'] = request.course_code
        if not UtilClient.is_unset(request.ding_client_id):
            body['dingClientId'] = request.ding_client_id
        if not UtilClient.is_unset(request.ding_suite_key):
            body['dingSuiteKey'] = request.ding_suite_key
        if not UtilClient.is_unset(request.ding_token_grant_type):
            body['dingTokenGrantType'] = request.ding_token_grant_type
        if not UtilClient.is_unset(request.ding_oauth_app_id):
            body['dingOauthAppId'] = request.ding_oauth_app_id
        if not UtilClient.is_unset(request.ding_corp_id):
            body['dingCorpId'] = request.ding_corp_id
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
        if not UtilClient.is_unset(request.auth_code):
            body['authCode'] = request.auth_code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.UpdateRemoteClassCourseResponse(),
            self.do_roarequest('UpdateRemoteClassCourse', 'edu_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/edu/remoteClasses/courses', 'json', req, runtime)
        )

    async def update_remote_class_course_with_options_async(
        self,
        request: dingtalkedu__1__0_models.UpdateRemoteClassCourseRequest,
        headers: dingtalkedu__1__0_models.UpdateRemoteClassCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.UpdateRemoteClassCourseResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.course_name):
            body['courseName'] = request.course_name
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.teaching_participant):
            body['teachingParticipant'] = request.teaching_participant
        if not UtilClient.is_unset(request.attend_participants):
            body['attendParticipants'] = request.attend_participants
        if not UtilClient.is_unset(request.course_code):
            body['courseCode'] = request.course_code
        if not UtilClient.is_unset(request.ding_client_id):
            body['dingClientId'] = request.ding_client_id
        if not UtilClient.is_unset(request.ding_suite_key):
            body['dingSuiteKey'] = request.ding_suite_key
        if not UtilClient.is_unset(request.ding_token_grant_type):
            body['dingTokenGrantType'] = request.ding_token_grant_type
        if not UtilClient.is_unset(request.ding_oauth_app_id):
            body['dingOauthAppId'] = request.ding_oauth_app_id
        if not UtilClient.is_unset(request.ding_corp_id):
            body['dingCorpId'] = request.ding_corp_id
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
        if not UtilClient.is_unset(request.auth_code):
            body['authCode'] = request.auth_code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.UpdateRemoteClassCourseResponse(),
            await self.do_roarequest_async('UpdateRemoteClassCourse', 'edu_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/edu/remoteClasses/courses', 'json', req, runtime)
        )

    def unsubscribe_university_course_group(
        self,
        request: dingtalkedu__1__0_models.UnsubscribeUniversityCourseGroupRequest,
    ) -> dingtalkedu__1__0_models.UnsubscribeUniversityCourseGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.UnsubscribeUniversityCourseGroupHeaders()
        return self.unsubscribe_university_course_group_with_options(request, headers, runtime)

    async def unsubscribe_university_course_group_async(
        self,
        request: dingtalkedu__1__0_models.UnsubscribeUniversityCourseGroupRequest,
    ) -> dingtalkedu__1__0_models.UnsubscribeUniversityCourseGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.UnsubscribeUniversityCourseGroupHeaders()
        return await self.unsubscribe_university_course_group_with_options_async(request, headers, runtime)

    def unsubscribe_university_course_group_with_options(
        self,
        request: dingtalkedu__1__0_models.UnsubscribeUniversityCourseGroupRequest,
        headers: dingtalkedu__1__0_models.UnsubscribeUniversityCourseGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.UnsubscribeUniversityCourseGroupResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.course_group_code):
            body['courseGroupCode'] = request.course_group_code
        if not UtilClient.is_unset(request.student_user_ids):
            body['studentUserIds'] = request.student_user_ids
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.UnsubscribeUniversityCourseGroupResponse(),
            self.do_roarequest('UnsubscribeUniversityCourseGroup', 'edu_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/edu/universities/courseGroups/unsubscribe', 'json', req, runtime)
        )

    async def unsubscribe_university_course_group_with_options_async(
        self,
        request: dingtalkedu__1__0_models.UnsubscribeUniversityCourseGroupRequest,
        headers: dingtalkedu__1__0_models.UnsubscribeUniversityCourseGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.UnsubscribeUniversityCourseGroupResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.course_group_code):
            body['courseGroupCode'] = request.course_group_code
        if not UtilClient.is_unset(request.student_user_ids):
            body['studentUserIds'] = request.student_user_ids
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.UnsubscribeUniversityCourseGroupResponse(),
            await self.do_roarequest_async('UnsubscribeUniversityCourseGroup', 'edu_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/edu/universities/courseGroups/unsubscribe', 'json', req, runtime)
        )

    def query_org_secret_key(
        self,
        request: dingtalkedu__1__0_models.QueryOrgSecretKeyRequest,
    ) -> dingtalkedu__1__0_models.QueryOrgSecretKeyResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryOrgSecretKeyHeaders()
        return self.query_org_secret_key_with_options(request, headers, runtime)

    async def query_org_secret_key_async(
        self,
        request: dingtalkedu__1__0_models.QueryOrgSecretKeyRequest,
    ) -> dingtalkedu__1__0_models.QueryOrgSecretKeyResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryOrgSecretKeyHeaders()
        return await self.query_org_secret_key_with_options_async(request, headers, runtime)

    def query_org_secret_key_with_options(
        self,
        request: dingtalkedu__1__0_models.QueryOrgSecretKeyRequest,
        headers: dingtalkedu__1__0_models.QueryOrgSecretKeyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryOrgSecretKeyResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.isv_code):
            query['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryOrgSecretKeyResponse(),
            self.do_roarequest('QueryOrgSecretKey', 'edu_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/edu/universities/secretKeys', 'json', req, runtime)
        )

    async def query_org_secret_key_with_options_async(
        self,
        request: dingtalkedu__1__0_models.QueryOrgSecretKeyRequest,
        headers: dingtalkedu__1__0_models.QueryOrgSecretKeyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryOrgSecretKeyResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.isv_code):
            query['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryOrgSecretKeyResponse(),
            await self.do_roarequest_async('QueryOrgSecretKey', 'edu_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/edu/universities/secretKeys', 'json', req, runtime)
        )

    def search_teachers(
        self,
        request: dingtalkedu__1__0_models.SearchTeachersRequest,
    ) -> dingtalkedu__1__0_models.SearchTeachersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.SearchTeachersHeaders()
        return self.search_teachers_with_options(request, headers, runtime)

    async def search_teachers_async(
        self,
        request: dingtalkedu__1__0_models.SearchTeachersRequest,
    ) -> dingtalkedu__1__0_models.SearchTeachersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.SearchTeachersHeaders()
        return await self.search_teachers_with_options_async(request, headers, runtime)

    def search_teachers_with_options(
        self,
        request: dingtalkedu__1__0_models.SearchTeachersRequest,
        headers: dingtalkedu__1__0_models.SearchTeachersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.SearchTeachersResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.name_keyword):
            query['nameKeyword'] = request.name_keyword
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.SearchTeachersResponse(),
            self.do_roarequest('SearchTeachers', 'edu_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/edu/teachers/search', 'json', req, runtime)
        )

    async def search_teachers_with_options_async(
        self,
        request: dingtalkedu__1__0_models.SearchTeachersRequest,
        headers: dingtalkedu__1__0_models.SearchTeachersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.SearchTeachersResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.name_keyword):
            query['nameKeyword'] = request.name_keyword
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.SearchTeachersResponse(),
            await self.do_roarequest_async('SearchTeachers', 'edu_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/edu/teachers/search', 'json', req, runtime)
        )

    def delete_physical_classroom(
        self,
        request: dingtalkedu__1__0_models.DeletePhysicalClassroomRequest,
    ) -> dingtalkedu__1__0_models.DeletePhysicalClassroomResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeletePhysicalClassroomHeaders()
        return self.delete_physical_classroom_with_options(request, headers, runtime)

    async def delete_physical_classroom_async(
        self,
        request: dingtalkedu__1__0_models.DeletePhysicalClassroomRequest,
    ) -> dingtalkedu__1__0_models.DeletePhysicalClassroomResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeletePhysicalClassroomHeaders()
        return await self.delete_physical_classroom_with_options_async(request, headers, runtime)

    def delete_physical_classroom_with_options(
        self,
        request: dingtalkedu__1__0_models.DeletePhysicalClassroomRequest,
        headers: dingtalkedu__1__0_models.DeletePhysicalClassroomHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeletePhysicalClassroomResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.classroom_id):
            query['classroomId'] = request.classroom_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeletePhysicalClassroomResponse(),
            self.do_roarequest('DeletePhysicalClassroom', 'edu_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/edu/physicalClassrooms', 'json', req, runtime)
        )

    async def delete_physical_classroom_with_options_async(
        self,
        request: dingtalkedu__1__0_models.DeletePhysicalClassroomRequest,
        headers: dingtalkedu__1__0_models.DeletePhysicalClassroomHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeletePhysicalClassroomResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.classroom_id):
            query['classroomId'] = request.classroom_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeletePhysicalClassroomResponse(),
            await self.do_roarequest_async('DeletePhysicalClassroom', 'edu_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/edu/physicalClassrooms', 'json', req, runtime)
        )

    def query_org_relation_list(
        self,
        request: dingtalkedu__1__0_models.QueryOrgRelationListRequest,
    ) -> dingtalkedu__1__0_models.QueryOrgRelationListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryOrgRelationListHeaders()
        return self.query_org_relation_list_with_options(request, headers, runtime)

    async def query_org_relation_list_async(
        self,
        request: dingtalkedu__1__0_models.QueryOrgRelationListRequest,
    ) -> dingtalkedu__1__0_models.QueryOrgRelationListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryOrgRelationListHeaders()
        return await self.query_org_relation_list_with_options_async(request, headers, runtime)

    def query_org_relation_list_with_options(
        self,
        request: dingtalkedu__1__0_models.QueryOrgRelationListRequest,
        headers: dingtalkedu__1__0_models.QueryOrgRelationListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryOrgRelationListResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryOrgRelationListResponse(),
            self.do_roarequest('QueryOrgRelationList', 'edu_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/edu/remoteClasses/orgRelations', 'json', req, runtime)
        )

    async def query_org_relation_list_with_options_async(
        self,
        request: dingtalkedu__1__0_models.QueryOrgRelationListRequest,
        headers: dingtalkedu__1__0_models.QueryOrgRelationListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryOrgRelationListResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryOrgRelationListResponse(),
            await self.do_roarequest_async('QueryOrgRelationList', 'edu_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/edu/remoteClasses/orgRelations', 'json', req, runtime)
        )

    def query_org_type(self) -> dingtalkedu__1__0_models.QueryOrgTypeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryOrgTypeHeaders()
        return self.query_org_type_with_options(headers, runtime)

    async def query_org_type_async(self) -> dingtalkedu__1__0_models.QueryOrgTypeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryOrgTypeHeaders()
        return await self.query_org_type_with_options_async(headers, runtime)

    def query_org_type_with_options(
        self,
        headers: dingtalkedu__1__0_models.QueryOrgTypeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryOrgTypeResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryOrgTypeResponse(),
            self.do_roarequest('QueryOrgType', 'edu_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/edu/orgTypes', 'json', req, runtime)
        )

    async def query_org_type_with_options_async(
        self,
        headers: dingtalkedu__1__0_models.QueryOrgTypeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryOrgTypeResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryOrgTypeResponse(),
            await self.do_roarequest_async('QueryOrgType', 'edu_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/edu/orgTypes', 'json', req, runtime)
        )

    def delete_university_student(
        self,
        request: dingtalkedu__1__0_models.DeleteUniversityStudentRequest,
    ) -> dingtalkedu__1__0_models.DeleteUniversityStudentResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteUniversityStudentHeaders()
        return self.delete_university_student_with_options(request, headers, runtime)

    async def delete_university_student_async(
        self,
        request: dingtalkedu__1__0_models.DeleteUniversityStudentRequest,
    ) -> dingtalkedu__1__0_models.DeleteUniversityStudentResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteUniversityStudentHeaders()
        return await self.delete_university_student_with_options_async(request, headers, runtime)

    def delete_university_student_with_options(
        self,
        request: dingtalkedu__1__0_models.DeleteUniversityStudentRequest,
        headers: dingtalkedu__1__0_models.DeleteUniversityStudentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteUniversityStudentResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.class_id):
            query['classId'] = request.class_id
        if not UtilClient.is_unset(request.student_user_id):
            query['studentUserId'] = request.student_user_id
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteUniversityStudentResponse(),
            self.do_roarequest('DeleteUniversityStudent', 'edu_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/edu/universities/students', 'json', req, runtime)
        )

    async def delete_university_student_with_options_async(
        self,
        request: dingtalkedu__1__0_models.DeleteUniversityStudentRequest,
        headers: dingtalkedu__1__0_models.DeleteUniversityStudentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteUniversityStudentResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.class_id):
            query['classId'] = request.class_id
        if not UtilClient.is_unset(request.student_user_id):
            query['studentUserId'] = request.student_user_id
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteUniversityStudentResponse(),
            await self.do_roarequest_async('DeleteUniversityStudent', 'edu_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/edu/universities/students', 'json', req, runtime)
        )

    def end_course(
        self,
        request: dingtalkedu__1__0_models.EndCourseRequest,
    ) -> dingtalkedu__1__0_models.EndCourseResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.EndCourseHeaders()
        return self.end_course_with_options(request, headers, runtime)

    async def end_course_async(
        self,
        request: dingtalkedu__1__0_models.EndCourseRequest,
    ) -> dingtalkedu__1__0_models.EndCourseResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.EndCourseHeaders()
        return await self.end_course_with_options_async(request, headers, runtime)

    def end_course_with_options(
        self,
        request: dingtalkedu__1__0_models.EndCourseRequest,
        headers: dingtalkedu__1__0_models.EndCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.EndCourseResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.ext):
            body['ext'] = request.ext
        if not UtilClient.is_unset(request.course_code):
            body['courseCode'] = request.course_code
        if not UtilClient.is_unset(request.live_play_info_list):
            body['livePlayInfoList'] = request.live_play_info_list
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.EndCourseResponse(),
            self.do_roarequest('EndCourse', 'edu_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/edu/universities/courses/end', 'json', req, runtime)
        )

    async def end_course_with_options_async(
        self,
        request: dingtalkedu__1__0_models.EndCourseRequest,
        headers: dingtalkedu__1__0_models.EndCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.EndCourseResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.ext):
            body['ext'] = request.ext
        if not UtilClient.is_unset(request.course_code):
            body['courseCode'] = request.course_code
        if not UtilClient.is_unset(request.live_play_info_list):
            body['livePlayInfoList'] = request.live_play_info_list
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.EndCourseResponse(),
            await self.do_roarequest_async('EndCourse', 'edu_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/edu/universities/courses/end', 'json', req, runtime)
        )

    def get_share_role_members(
        self,
        share_role_code: str,
    ) -> dingtalkedu__1__0_models.GetShareRoleMembersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetShareRoleMembersHeaders()
        return self.get_share_role_members_with_options(share_role_code, headers, runtime)

    async def get_share_role_members_async(
        self,
        share_role_code: str,
    ) -> dingtalkedu__1__0_models.GetShareRoleMembersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetShareRoleMembersHeaders()
        return await self.get_share_role_members_with_options_async(share_role_code, headers, runtime)

    def get_share_role_members_with_options(
        self,
        share_role_code: str,
        headers: dingtalkedu__1__0_models.GetShareRoleMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetShareRoleMembersResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetShareRoleMembersResponse(),
            self.do_roarequest('GetShareRoleMembers', 'edu_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/edu/shareRoles/{share_role_code}/members', 'json', req, runtime)
        )

    async def get_share_role_members_with_options_async(
        self,
        share_role_code: str,
        headers: dingtalkedu__1__0_models.GetShareRoleMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetShareRoleMembersResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetShareRoleMembersResponse(),
            await self.do_roarequest_async('GetShareRoleMembers', 'edu_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/edu/shareRoles/{share_role_code}/members', 'json', req, runtime)
        )

    def create_university_teacher(
        self,
        request: dingtalkedu__1__0_models.CreateUniversityTeacherRequest,
    ) -> dingtalkedu__1__0_models.CreateUniversityTeacherResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateUniversityTeacherHeaders()
        return self.create_university_teacher_with_options(request, headers, runtime)

    async def create_university_teacher_async(
        self,
        request: dingtalkedu__1__0_models.CreateUniversityTeacherRequest,
    ) -> dingtalkedu__1__0_models.CreateUniversityTeacherResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateUniversityTeacherHeaders()
        return await self.create_university_teacher_with_options_async(request, headers, runtime)

    def create_university_teacher_with_options(
        self,
        request: dingtalkedu__1__0_models.CreateUniversityTeacherRequest,
        headers: dingtalkedu__1__0_models.CreateUniversityTeacherHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateUniversityTeacherResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
        if not UtilClient.is_unset(request.class_id):
            body['classId'] = request.class_id
        if not UtilClient.is_unset(request.role):
            body['role'] = request.role
        if not UtilClient.is_unset(request.teacher_user_id):
            body['teacherUserId'] = request.teacher_user_id
        if not UtilClient.is_unset(request.ding_suite_key):
            body['dingSuiteKey'] = request.ding_suite_key
        if not UtilClient.is_unset(request.op_user_id):
            body['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateUniversityTeacherResponse(),
            self.do_roarequest('CreateUniversityTeacher', 'edu_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/edu/universities/teachers', 'json', req, runtime)
        )

    async def create_university_teacher_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CreateUniversityTeacherRequest,
        headers: dingtalkedu__1__0_models.CreateUniversityTeacherHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateUniversityTeacherResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
        if not UtilClient.is_unset(request.class_id):
            body['classId'] = request.class_id
        if not UtilClient.is_unset(request.role):
            body['role'] = request.role
        if not UtilClient.is_unset(request.teacher_user_id):
            body['teacherUserId'] = request.teacher_user_id
        if not UtilClient.is_unset(request.ding_suite_key):
            body['dingSuiteKey'] = request.ding_suite_key
        if not UtilClient.is_unset(request.op_user_id):
            body['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateUniversityTeacherResponse(),
            await self.do_roarequest_async('CreateUniversityTeacher', 'edu_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/edu/universities/teachers', 'json', req, runtime)
        )
