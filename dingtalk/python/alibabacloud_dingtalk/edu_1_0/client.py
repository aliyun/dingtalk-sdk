# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalkedu_1_0 import models as dingtalkedu__1__0_models
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
