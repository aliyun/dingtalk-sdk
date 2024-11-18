# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
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
        gateway_client = GatewayClientClient()
        self._spi = gateway_client
        self._endpoint_rule = ''
        if UtilClient.empty(self._endpoint):
            self._endpoint = 'api.dingtalk.com'

    def activate_device_with_options(
        self,
        request: dingtalkedu__1__0_models.ActivateDeviceRequest,
        headers: dingtalkedu__1__0_models.ActivateDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.ActivateDeviceResponse:
        """
        @summary 视讯paas机具激活
        
        @param request: ActivateDeviceRequest
        @param headers: ActivateDeviceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ActivateDeviceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.license_key):
            body['licenseKey'] = request.license_key
        if not UtilClient.is_unset(request.model):
            body['model'] = request.model
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
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
            action='ActivateDevice',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/vpaas/devices/activate',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.ActivateDeviceResponse(),
            self.execute(params, req, runtime)
        )

    async def activate_device_with_options_async(
        self,
        request: dingtalkedu__1__0_models.ActivateDeviceRequest,
        headers: dingtalkedu__1__0_models.ActivateDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.ActivateDeviceResponse:
        """
        @summary 视讯paas机具激活
        
        @param request: ActivateDeviceRequest
        @param headers: ActivateDeviceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ActivateDeviceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.license_key):
            body['licenseKey'] = request.license_key
        if not UtilClient.is_unset(request.model):
            body['model'] = request.model
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
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
            action='ActivateDevice',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/vpaas/devices/activate',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.ActivateDeviceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def activate_device(
        self,
        request: dingtalkedu__1__0_models.ActivateDeviceRequest,
    ) -> dingtalkedu__1__0_models.ActivateDeviceResponse:
        """
        @summary 视讯paas机具激活
        
        @param request: ActivateDeviceRequest
        @return: ActivateDeviceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.ActivateDeviceHeaders()
        return self.activate_device_with_options(request, headers, runtime)

    async def activate_device_async(
        self,
        request: dingtalkedu__1__0_models.ActivateDeviceRequest,
    ) -> dingtalkedu__1__0_models.ActivateDeviceResponse:
        """
        @summary 视讯paas机具激活
        
        @param request: ActivateDeviceRequest
        @return: ActivateDeviceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.ActivateDeviceHeaders()
        return await self.activate_device_with_options_async(request, headers, runtime)

    def add_college_alumni_depts_with_options(
        self,
        request: dingtalkedu__1__0_models.AddCollegeAlumniDeptsRequest,
        headers: dingtalkedu__1__0_models.AddCollegeAlumniDeptsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.AddCollegeAlumniDeptsResponse:
        """
        @summary 高校校友会批量创建部门
        
        @param request: AddCollegeAlumniDeptsRequest
        @param headers: AddCollegeAlumniDeptsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddCollegeAlumniDeptsResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.depts):
            body['depts'] = request.depts
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
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
            action='AddCollegeAlumniDepts',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/collegeAlumni/depts/batch',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.AddCollegeAlumniDeptsResponse(),
            self.execute(params, req, runtime)
        )

    async def add_college_alumni_depts_with_options_async(
        self,
        request: dingtalkedu__1__0_models.AddCollegeAlumniDeptsRequest,
        headers: dingtalkedu__1__0_models.AddCollegeAlumniDeptsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.AddCollegeAlumniDeptsResponse:
        """
        @summary 高校校友会批量创建部门
        
        @param request: AddCollegeAlumniDeptsRequest
        @param headers: AddCollegeAlumniDeptsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddCollegeAlumniDeptsResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.depts):
            body['depts'] = request.depts
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
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
            action='AddCollegeAlumniDepts',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/collegeAlumni/depts/batch',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.AddCollegeAlumniDeptsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_college_alumni_depts(
        self,
        request: dingtalkedu__1__0_models.AddCollegeAlumniDeptsRequest,
    ) -> dingtalkedu__1__0_models.AddCollegeAlumniDeptsResponse:
        """
        @summary 高校校友会批量创建部门
        
        @param request: AddCollegeAlumniDeptsRequest
        @return: AddCollegeAlumniDeptsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.AddCollegeAlumniDeptsHeaders()
        return self.add_college_alumni_depts_with_options(request, headers, runtime)

    async def add_college_alumni_depts_async(
        self,
        request: dingtalkedu__1__0_models.AddCollegeAlumniDeptsRequest,
    ) -> dingtalkedu__1__0_models.AddCollegeAlumniDeptsResponse:
        """
        @summary 高校校友会批量创建部门
        
        @param request: AddCollegeAlumniDeptsRequest
        @return: AddCollegeAlumniDeptsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.AddCollegeAlumniDeptsHeaders()
        return await self.add_college_alumni_depts_with_options_async(request, headers, runtime)

    def add_college_alumni_user_info_with_options(
        self,
        request: dingtalkedu__1__0_models.AddCollegeAlumniUserInfoRequest,
        headers: dingtalkedu__1__0_models.AddCollegeAlumniUserInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.AddCollegeAlumniUserInfoResponse:
        """
        @summary 高校校友会新增校友信息
        
        @param request: AddCollegeAlumniUserInfoRequest
        @param headers: AddCollegeAlumniUserInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddCollegeAlumniUserInfoResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.address):
            body['address'] = request.address
        if not UtilClient.is_unset(request.dept_ids):
            body['deptIds'] = request.dept_ids
        if not UtilClient.is_unset(request.email):
            body['email'] = request.email
        if not UtilClient.is_unset(request.intake):
            body['intake'] = request.intake
        if not UtilClient.is_unset(request.mobile):
            body['mobile'] = request.mobile
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        if not UtilClient.is_unset(request.outtake):
            body['outtake'] = request.outtake
        if not UtilClient.is_unset(request.student_number):
            body['studentNumber'] = request.student_number
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
            action='AddCollegeAlumniUserInfo',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/collegeAlumni/userInfos',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.AddCollegeAlumniUserInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def add_college_alumni_user_info_with_options_async(
        self,
        request: dingtalkedu__1__0_models.AddCollegeAlumniUserInfoRequest,
        headers: dingtalkedu__1__0_models.AddCollegeAlumniUserInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.AddCollegeAlumniUserInfoResponse:
        """
        @summary 高校校友会新增校友信息
        
        @param request: AddCollegeAlumniUserInfoRequest
        @param headers: AddCollegeAlumniUserInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddCollegeAlumniUserInfoResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.address):
            body['address'] = request.address
        if not UtilClient.is_unset(request.dept_ids):
            body['deptIds'] = request.dept_ids
        if not UtilClient.is_unset(request.email):
            body['email'] = request.email
        if not UtilClient.is_unset(request.intake):
            body['intake'] = request.intake
        if not UtilClient.is_unset(request.mobile):
            body['mobile'] = request.mobile
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        if not UtilClient.is_unset(request.outtake):
            body['outtake'] = request.outtake
        if not UtilClient.is_unset(request.student_number):
            body['studentNumber'] = request.student_number
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
            action='AddCollegeAlumniUserInfo',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/collegeAlumni/userInfos',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.AddCollegeAlumniUserInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_college_alumni_user_info(
        self,
        request: dingtalkedu__1__0_models.AddCollegeAlumniUserInfoRequest,
    ) -> dingtalkedu__1__0_models.AddCollegeAlumniUserInfoResponse:
        """
        @summary 高校校友会新增校友信息
        
        @param request: AddCollegeAlumniUserInfoRequest
        @return: AddCollegeAlumniUserInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.AddCollegeAlumniUserInfoHeaders()
        return self.add_college_alumni_user_info_with_options(request, headers, runtime)

    async def add_college_alumni_user_info_async(
        self,
        request: dingtalkedu__1__0_models.AddCollegeAlumniUserInfoRequest,
    ) -> dingtalkedu__1__0_models.AddCollegeAlumniUserInfoResponse:
        """
        @summary 高校校友会新增校友信息
        
        @param request: AddCollegeAlumniUserInfoRequest
        @return: AddCollegeAlumniUserInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.AddCollegeAlumniUserInfoHeaders()
        return await self.add_college_alumni_user_info_with_options_async(request, headers, runtime)

    def add_college_contact_exclusive_with_options(
        self,
        request: dingtalkedu__1__0_models.AddCollegeContactExclusiveRequest,
        headers: dingtalkedu__1__0_models.AddCollegeContactExclusiveHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.AddCollegeContactExclusiveResponse:
        """
        @summary 创建高校账号用户
        
        @param request: AddCollegeContactExclusiveRequest
        @param headers: AddCollegeContactExclusiveHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddCollegeContactExclusiveResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.avatar_media_id):
            body['avatarMediaId'] = request.avatar_media_id
        if not UtilClient.is_unset(request.dept_id_list):
            body['deptIdList'] = request.dept_id_list
        if not UtilClient.is_unset(request.dept_order_list):
            body['deptOrderList'] = request.dept_order_list
        if not UtilClient.is_unset(request.dept_title_list):
            body['deptTitleList'] = request.dept_title_list
        if not UtilClient.is_unset(request.email):
            body['email'] = request.email
        if not UtilClient.is_unset(request.emp_type):
            body['empType'] = request.emp_type
        if not UtilClient.is_unset(request.exclusive_account):
            body['exclusiveAccount'] = request.exclusive_account
        if not UtilClient.is_unset(request.exclusive_account_type):
            body['exclusiveAccountType'] = request.exclusive_account_type
        if not UtilClient.is_unset(request.extension):
            body['extension'] = request.extension
        if not UtilClient.is_unset(request.hired_date):
            body['hiredDate'] = request.hired_date
        if not UtilClient.is_unset(request.init_password):
            body['initPassword'] = request.init_password
        if not UtilClient.is_unset(request.job_number):
            body['jobNumber'] = request.job_number
        if not UtilClient.is_unset(request.login_id_type):
            body['loginIdType'] = request.login_id_type
        if not UtilClient.is_unset(request.main_dept_id):
            body['mainDeptId'] = request.main_dept_id
        if not UtilClient.is_unset(request.manager_userid):
            body['managerUserid'] = request.manager_userid
        if not UtilClient.is_unset(request.mobile):
            body['mobile'] = request.mobile
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.nickname):
            body['nickname'] = request.nickname
        if not UtilClient.is_unset(request.org_email):
            body['orgEmail'] = request.org_email
        if not UtilClient.is_unset(request.org_email_type):
            body['orgEmailType'] = request.org_email_type
        if not UtilClient.is_unset(request.remark):
            body['remark'] = request.remark
        if not UtilClient.is_unset(request.send_active_sms):
            body['sendActiveSms'] = request.send_active_sms
        if not UtilClient.is_unset(request.senior_mode):
            body['seniorMode'] = request.senior_mode
        if not UtilClient.is_unset(request.telephone):
            body['telephone'] = request.telephone
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        if not UtilClient.is_unset(request.userid):
            body['userid'] = request.userid
        if not UtilClient.is_unset(request.work_place):
            body['workPlace'] = request.work_place
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
            action='AddCollegeContactExclusive',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/collegeContact/exclusiveAccounts/users',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.AddCollegeContactExclusiveResponse(),
            self.execute(params, req, runtime)
        )

    async def add_college_contact_exclusive_with_options_async(
        self,
        request: dingtalkedu__1__0_models.AddCollegeContactExclusiveRequest,
        headers: dingtalkedu__1__0_models.AddCollegeContactExclusiveHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.AddCollegeContactExclusiveResponse:
        """
        @summary 创建高校账号用户
        
        @param request: AddCollegeContactExclusiveRequest
        @param headers: AddCollegeContactExclusiveHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddCollegeContactExclusiveResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.avatar_media_id):
            body['avatarMediaId'] = request.avatar_media_id
        if not UtilClient.is_unset(request.dept_id_list):
            body['deptIdList'] = request.dept_id_list
        if not UtilClient.is_unset(request.dept_order_list):
            body['deptOrderList'] = request.dept_order_list
        if not UtilClient.is_unset(request.dept_title_list):
            body['deptTitleList'] = request.dept_title_list
        if not UtilClient.is_unset(request.email):
            body['email'] = request.email
        if not UtilClient.is_unset(request.emp_type):
            body['empType'] = request.emp_type
        if not UtilClient.is_unset(request.exclusive_account):
            body['exclusiveAccount'] = request.exclusive_account
        if not UtilClient.is_unset(request.exclusive_account_type):
            body['exclusiveAccountType'] = request.exclusive_account_type
        if not UtilClient.is_unset(request.extension):
            body['extension'] = request.extension
        if not UtilClient.is_unset(request.hired_date):
            body['hiredDate'] = request.hired_date
        if not UtilClient.is_unset(request.init_password):
            body['initPassword'] = request.init_password
        if not UtilClient.is_unset(request.job_number):
            body['jobNumber'] = request.job_number
        if not UtilClient.is_unset(request.login_id_type):
            body['loginIdType'] = request.login_id_type
        if not UtilClient.is_unset(request.main_dept_id):
            body['mainDeptId'] = request.main_dept_id
        if not UtilClient.is_unset(request.manager_userid):
            body['managerUserid'] = request.manager_userid
        if not UtilClient.is_unset(request.mobile):
            body['mobile'] = request.mobile
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.nickname):
            body['nickname'] = request.nickname
        if not UtilClient.is_unset(request.org_email):
            body['orgEmail'] = request.org_email
        if not UtilClient.is_unset(request.org_email_type):
            body['orgEmailType'] = request.org_email_type
        if not UtilClient.is_unset(request.remark):
            body['remark'] = request.remark
        if not UtilClient.is_unset(request.send_active_sms):
            body['sendActiveSms'] = request.send_active_sms
        if not UtilClient.is_unset(request.senior_mode):
            body['seniorMode'] = request.senior_mode
        if not UtilClient.is_unset(request.telephone):
            body['telephone'] = request.telephone
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        if not UtilClient.is_unset(request.userid):
            body['userid'] = request.userid
        if not UtilClient.is_unset(request.work_place):
            body['workPlace'] = request.work_place
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
            action='AddCollegeContactExclusive',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/collegeContact/exclusiveAccounts/users',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.AddCollegeContactExclusiveResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_college_contact_exclusive(
        self,
        request: dingtalkedu__1__0_models.AddCollegeContactExclusiveRequest,
    ) -> dingtalkedu__1__0_models.AddCollegeContactExclusiveResponse:
        """
        @summary 创建高校账号用户
        
        @param request: AddCollegeContactExclusiveRequest
        @return: AddCollegeContactExclusiveResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.AddCollegeContactExclusiveHeaders()
        return self.add_college_contact_exclusive_with_options(request, headers, runtime)

    async def add_college_contact_exclusive_async(
        self,
        request: dingtalkedu__1__0_models.AddCollegeContactExclusiveRequest,
    ) -> dingtalkedu__1__0_models.AddCollegeContactExclusiveResponse:
        """
        @summary 创建高校账号用户
        
        @param request: AddCollegeContactExclusiveRequest
        @return: AddCollegeContactExclusiveResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.AddCollegeContactExclusiveHeaders()
        return await self.add_college_contact_exclusive_with_options_async(request, headers, runtime)

    def add_college_contact_user_with_options(
        self,
        request: dingtalkedu__1__0_models.AddCollegeContactUserRequest,
        headers: dingtalkedu__1__0_models.AddCollegeContactUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.AddCollegeContactUserResponse:
        """
        @summary 创建个人账号用户
        
        @param request: AddCollegeContactUserRequest
        @param headers: AddCollegeContactUserHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddCollegeContactUserResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dept_id_list):
            body['deptIdList'] = request.dept_id_list
        if not UtilClient.is_unset(request.dept_order_list):
            body['deptOrderList'] = request.dept_order_list
        if not UtilClient.is_unset(request.dept_title_list):
            body['deptTitleList'] = request.dept_title_list
        if not UtilClient.is_unset(request.email):
            body['email'] = request.email
        if not UtilClient.is_unset(request.emp_type):
            body['empType'] = request.emp_type
        if not UtilClient.is_unset(request.extension):
            body['extension'] = request.extension
        if not UtilClient.is_unset(request.hide_mobile):
            body['hideMobile'] = request.hide_mobile
        if not UtilClient.is_unset(request.hired_date):
            body['hiredDate'] = request.hired_date
        if not UtilClient.is_unset(request.job_number):
            body['jobNumber'] = request.job_number
        if not UtilClient.is_unset(request.login_email):
            body['loginEmail'] = request.login_email
        if not UtilClient.is_unset(request.main_dept_id):
            body['mainDeptId'] = request.main_dept_id
        if not UtilClient.is_unset(request.manager_userid):
            body['managerUserid'] = request.manager_userid
        if not UtilClient.is_unset(request.mobile):
            body['mobile'] = request.mobile
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.org_email):
            body['orgEmail'] = request.org_email
        if not UtilClient.is_unset(request.org_email_type):
            body['orgEmailType'] = request.org_email_type
        if not UtilClient.is_unset(request.remark):
            body['remark'] = request.remark
        if not UtilClient.is_unset(request.send_active_sms):
            body['sendActiveSms'] = request.send_active_sms
        if not UtilClient.is_unset(request.senior_mode):
            body['seniorMode'] = request.senior_mode
        if not UtilClient.is_unset(request.telephone):
            body['telephone'] = request.telephone
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        if not UtilClient.is_unset(request.userid):
            body['userid'] = request.userid
        if not UtilClient.is_unset(request.work_place):
            body['workPlace'] = request.work_place
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
            action='AddCollegeContactUser',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/collegeContact/personalAccounts/users',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.AddCollegeContactUserResponse(),
            self.execute(params, req, runtime)
        )

    async def add_college_contact_user_with_options_async(
        self,
        request: dingtalkedu__1__0_models.AddCollegeContactUserRequest,
        headers: dingtalkedu__1__0_models.AddCollegeContactUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.AddCollegeContactUserResponse:
        """
        @summary 创建个人账号用户
        
        @param request: AddCollegeContactUserRequest
        @param headers: AddCollegeContactUserHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddCollegeContactUserResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dept_id_list):
            body['deptIdList'] = request.dept_id_list
        if not UtilClient.is_unset(request.dept_order_list):
            body['deptOrderList'] = request.dept_order_list
        if not UtilClient.is_unset(request.dept_title_list):
            body['deptTitleList'] = request.dept_title_list
        if not UtilClient.is_unset(request.email):
            body['email'] = request.email
        if not UtilClient.is_unset(request.emp_type):
            body['empType'] = request.emp_type
        if not UtilClient.is_unset(request.extension):
            body['extension'] = request.extension
        if not UtilClient.is_unset(request.hide_mobile):
            body['hideMobile'] = request.hide_mobile
        if not UtilClient.is_unset(request.hired_date):
            body['hiredDate'] = request.hired_date
        if not UtilClient.is_unset(request.job_number):
            body['jobNumber'] = request.job_number
        if not UtilClient.is_unset(request.login_email):
            body['loginEmail'] = request.login_email
        if not UtilClient.is_unset(request.main_dept_id):
            body['mainDeptId'] = request.main_dept_id
        if not UtilClient.is_unset(request.manager_userid):
            body['managerUserid'] = request.manager_userid
        if not UtilClient.is_unset(request.mobile):
            body['mobile'] = request.mobile
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.org_email):
            body['orgEmail'] = request.org_email
        if not UtilClient.is_unset(request.org_email_type):
            body['orgEmailType'] = request.org_email_type
        if not UtilClient.is_unset(request.remark):
            body['remark'] = request.remark
        if not UtilClient.is_unset(request.send_active_sms):
            body['sendActiveSms'] = request.send_active_sms
        if not UtilClient.is_unset(request.senior_mode):
            body['seniorMode'] = request.senior_mode
        if not UtilClient.is_unset(request.telephone):
            body['telephone'] = request.telephone
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        if not UtilClient.is_unset(request.userid):
            body['userid'] = request.userid
        if not UtilClient.is_unset(request.work_place):
            body['workPlace'] = request.work_place
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
            action='AddCollegeContactUser',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/collegeContact/personalAccounts/users',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.AddCollegeContactUserResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_college_contact_user(
        self,
        request: dingtalkedu__1__0_models.AddCollegeContactUserRequest,
    ) -> dingtalkedu__1__0_models.AddCollegeContactUserResponse:
        """
        @summary 创建个人账号用户
        
        @param request: AddCollegeContactUserRequest
        @return: AddCollegeContactUserResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.AddCollegeContactUserHeaders()
        return self.add_college_contact_user_with_options(request, headers, runtime)

    async def add_college_contact_user_async(
        self,
        request: dingtalkedu__1__0_models.AddCollegeContactUserRequest,
    ) -> dingtalkedu__1__0_models.AddCollegeContactUserResponse:
        """
        @summary 创建个人账号用户
        
        @param request: AddCollegeContactUserRequest
        @return: AddCollegeContactUserResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.AddCollegeContactUserHeaders()
        return await self.add_college_contact_user_with_options_async(request, headers, runtime)

    def add_competition_record_with_options(
        self,
        request: dingtalkedu__1__0_models.AddCompetitionRecordRequest,
        headers: dingtalkedu__1__0_models.AddCompetitionRecordHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.AddCompetitionRecordResponse:
        """
        @summary 增加赛事记录
        
        @param request: AddCompetitionRecordRequest
        @param headers: AddCompetitionRecordHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddCompetitionRecordResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.competition_code):
            body['competitionCode'] = request.competition_code
        if not UtilClient.is_unset(request.group_template_code):
            body['groupTemplateCode'] = request.group_template_code
        if not UtilClient.is_unset(request.join_group):
            body['joinGroup'] = request.join_group
        if not UtilClient.is_unset(request.participant_name):
            body['participantName'] = request.participant_name
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
            action='AddCompetitionRecord',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/competitions/records',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.AddCompetitionRecordResponse(),
            self.execute(params, req, runtime)
        )

    async def add_competition_record_with_options_async(
        self,
        request: dingtalkedu__1__0_models.AddCompetitionRecordRequest,
        headers: dingtalkedu__1__0_models.AddCompetitionRecordHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.AddCompetitionRecordResponse:
        """
        @summary 增加赛事记录
        
        @param request: AddCompetitionRecordRequest
        @param headers: AddCompetitionRecordHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddCompetitionRecordResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.competition_code):
            body['competitionCode'] = request.competition_code
        if not UtilClient.is_unset(request.group_template_code):
            body['groupTemplateCode'] = request.group_template_code
        if not UtilClient.is_unset(request.join_group):
            body['joinGroup'] = request.join_group
        if not UtilClient.is_unset(request.participant_name):
            body['participantName'] = request.participant_name
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
            action='AddCompetitionRecord',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/competitions/records',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.AddCompetitionRecordResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_competition_record(
        self,
        request: dingtalkedu__1__0_models.AddCompetitionRecordRequest,
    ) -> dingtalkedu__1__0_models.AddCompetitionRecordResponse:
        """
        @summary 增加赛事记录
        
        @param request: AddCompetitionRecordRequest
        @return: AddCompetitionRecordResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.AddCompetitionRecordHeaders()
        return self.add_competition_record_with_options(request, headers, runtime)

    async def add_competition_record_async(
        self,
        request: dingtalkedu__1__0_models.AddCompetitionRecordRequest,
    ) -> dingtalkedu__1__0_models.AddCompetitionRecordResponse:
        """
        @summary 增加赛事记录
        
        @param request: AddCompetitionRecordRequest
        @return: AddCompetitionRecordResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.AddCompetitionRecordHeaders()
        return await self.add_competition_record_with_options_async(request, headers, runtime)

    def add_device_with_options(
        self,
        request: dingtalkedu__1__0_models.AddDeviceRequest,
        headers: dingtalkedu__1__0_models.AddDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.AddDeviceResponse:
        """
        @summary 添加设备
        
        @param request: AddDeviceRequest
        @param headers: AddDeviceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddDeviceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.merchant_id):
            body['merchantId'] = request.merchant_id
        if not UtilClient.is_unset(request.model):
            body['model'] = request.model
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.scene):
            body['scene'] = request.scene
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
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
            action='AddDevice',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/devices',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.AddDeviceResponse(),
            self.execute(params, req, runtime)
        )

    async def add_device_with_options_async(
        self,
        request: dingtalkedu__1__0_models.AddDeviceRequest,
        headers: dingtalkedu__1__0_models.AddDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.AddDeviceResponse:
        """
        @summary 添加设备
        
        @param request: AddDeviceRequest
        @param headers: AddDeviceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddDeviceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.merchant_id):
            body['merchantId'] = request.merchant_id
        if not UtilClient.is_unset(request.model):
            body['model'] = request.model
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.scene):
            body['scene'] = request.scene
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
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
            action='AddDevice',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/devices',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.AddDeviceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_device(
        self,
        request: dingtalkedu__1__0_models.AddDeviceRequest,
    ) -> dingtalkedu__1__0_models.AddDeviceResponse:
        """
        @summary 添加设备
        
        @param request: AddDeviceRequest
        @return: AddDeviceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.AddDeviceHeaders()
        return self.add_device_with_options(request, headers, runtime)

    async def add_device_async(
        self,
        request: dingtalkedu__1__0_models.AddDeviceRequest,
    ) -> dingtalkedu__1__0_models.AddDeviceResponse:
        """
        @summary 添加设备
        
        @param request: AddDeviceRequest
        @return: AddDeviceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.AddDeviceHeaders()
        return await self.add_device_with_options_async(request, headers, runtime)

    def add_school_config_with_options(
        self,
        request: dingtalkedu__1__0_models.AddSchoolConfigRequest,
        headers: dingtalkedu__1__0_models.AddSchoolConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.AddSchoolConfigResponse:
        """
        @summary 添加学校配置
        
        @param request: AddSchoolConfigRequest
        @param headers: AddSchoolConfigHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddSchoolConfigResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.operator_name):
            body['operatorName'] = request.operator_name
        if not UtilClient.is_unset(request.temperature_up_limit):
            body['temperatureUpLimit'] = request.temperature_up_limit
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
            action='AddSchoolConfig',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/schools/configurations',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.AddSchoolConfigResponse(),
            self.execute(params, req, runtime)
        )

    async def add_school_config_with_options_async(
        self,
        request: dingtalkedu__1__0_models.AddSchoolConfigRequest,
        headers: dingtalkedu__1__0_models.AddSchoolConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.AddSchoolConfigResponse:
        """
        @summary 添加学校配置
        
        @param request: AddSchoolConfigRequest
        @param headers: AddSchoolConfigHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddSchoolConfigResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.operator_name):
            body['operatorName'] = request.operator_name
        if not UtilClient.is_unset(request.temperature_up_limit):
            body['temperatureUpLimit'] = request.temperature_up_limit
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
            action='AddSchoolConfig',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/schools/configurations',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.AddSchoolConfigResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_school_config(
        self,
        request: dingtalkedu__1__0_models.AddSchoolConfigRequest,
    ) -> dingtalkedu__1__0_models.AddSchoolConfigResponse:
        """
        @summary 添加学校配置
        
        @param request: AddSchoolConfigRequest
        @return: AddSchoolConfigResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.AddSchoolConfigHeaders()
        return self.add_school_config_with_options(request, headers, runtime)

    async def add_school_config_async(
        self,
        request: dingtalkedu__1__0_models.AddSchoolConfigRequest,
    ) -> dingtalkedu__1__0_models.AddSchoolConfigResponse:
        """
        @summary 添加学校配置
        
        @param request: AddSchoolConfigRequest
        @return: AddSchoolConfigResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.AddSchoolConfigHeaders()
        return await self.add_school_config_with_options_async(request, headers, runtime)

    def adjust_course_with_options(
        self,
        request: dingtalkedu__1__0_models.AdjustCourseRequest,
        headers: dingtalkedu__1__0_models.AdjustCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.AdjustCourseResponse:
        """
        @summary 修改课程
        
        @param request: AdjustCourseRequest
        @param headers: AdjustCourseHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AdjustCourseResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.attributes):
            body['attributes'] = request.attributes
        if not UtilClient.is_unset(request.class_name):
            body['className'] = request.class_name
        if not UtilClient.is_unset(request.class_room_id):
            body['classRoomId'] = request.class_room_id
        if not UtilClient.is_unset(request.class_room_name):
            body['classRoomName'] = request.class_room_name
        if not UtilClient.is_unset(request.class_type):
            body['classType'] = request.class_type
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.course_code):
            body['courseCode'] = request.course_code
        if not UtilClient.is_unset(request.course_date):
            body['courseDate'] = request.course_date
        if not UtilClient.is_unset(request.course_name):
            body['courseName'] = request.course_name
        if not UtilClient.is_unset(request.course_week):
            body['courseWeek'] = request.course_week
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.isv_course_id):
            body['isvCourseId'] = request.isv_course_id
        if not UtilClient.is_unset(request.memo):
            body['memo'] = request.memo
        if not UtilClient.is_unset(request.school_year):
            body['schoolYear'] = request.school_year
        if not UtilClient.is_unset(request.semester):
            body['semester'] = request.semester
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
        if not UtilClient.is_unset(request.teach_week):
            body['teachWeek'] = request.teach_week
        if not UtilClient.is_unset(request.timeslot_name):
            body['timeslotName'] = request.timeslot_name
        if not UtilClient.is_unset(request.timeslot_num):
            body['timeslotNum'] = request.timeslot_num
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
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
            action='AdjustCourse',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/kits/courses/adjust',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.AdjustCourseResponse(),
            self.execute(params, req, runtime)
        )

    async def adjust_course_with_options_async(
        self,
        request: dingtalkedu__1__0_models.AdjustCourseRequest,
        headers: dingtalkedu__1__0_models.AdjustCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.AdjustCourseResponse:
        """
        @summary 修改课程
        
        @param request: AdjustCourseRequest
        @param headers: AdjustCourseHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AdjustCourseResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.attributes):
            body['attributes'] = request.attributes
        if not UtilClient.is_unset(request.class_name):
            body['className'] = request.class_name
        if not UtilClient.is_unset(request.class_room_id):
            body['classRoomId'] = request.class_room_id
        if not UtilClient.is_unset(request.class_room_name):
            body['classRoomName'] = request.class_room_name
        if not UtilClient.is_unset(request.class_type):
            body['classType'] = request.class_type
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.course_code):
            body['courseCode'] = request.course_code
        if not UtilClient.is_unset(request.course_date):
            body['courseDate'] = request.course_date
        if not UtilClient.is_unset(request.course_name):
            body['courseName'] = request.course_name
        if not UtilClient.is_unset(request.course_week):
            body['courseWeek'] = request.course_week
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.isv_course_id):
            body['isvCourseId'] = request.isv_course_id
        if not UtilClient.is_unset(request.memo):
            body['memo'] = request.memo
        if not UtilClient.is_unset(request.school_year):
            body['schoolYear'] = request.school_year
        if not UtilClient.is_unset(request.semester):
            body['semester'] = request.semester
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
        if not UtilClient.is_unset(request.teach_week):
            body['teachWeek'] = request.teach_week
        if not UtilClient.is_unset(request.timeslot_name):
            body['timeslotName'] = request.timeslot_name
        if not UtilClient.is_unset(request.timeslot_num):
            body['timeslotNum'] = request.timeslot_num
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
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
            action='AdjustCourse',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/kits/courses/adjust',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.AdjustCourseResponse(),
            await self.execute_async(params, req, runtime)
        )

    def adjust_course(
        self,
        request: dingtalkedu__1__0_models.AdjustCourseRequest,
    ) -> dingtalkedu__1__0_models.AdjustCourseResponse:
        """
        @summary 修改课程
        
        @param request: AdjustCourseRequest
        @return: AdjustCourseResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.AdjustCourseHeaders()
        return self.adjust_course_with_options(request, headers, runtime)

    async def adjust_course_async(
        self,
        request: dingtalkedu__1__0_models.AdjustCourseRequest,
    ) -> dingtalkedu__1__0_models.AdjustCourseResponse:
        """
        @summary 修改课程
        
        @param request: AdjustCourseRequest
        @return: AdjustCourseResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.AdjustCourseHeaders()
        return await self.adjust_course_with_options_async(request, headers, runtime)

    def adjust_kit_with_options(
        self,
        request: dingtalkedu__1__0_models.AdjustKitRequest,
        headers: dingtalkedu__1__0_models.AdjustKitHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.AdjustKitResponse:
        """
        @summary 修改教育套件
        
        @param request: AdjustKitRequest
        @param headers: AdjustKitHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AdjustKitResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.attributes):
            body['attributes'] = request.attributes
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.isv_product_scene):
            body['isvProductScene'] = request.isv_product_scene
        if not UtilClient.is_unset(request.open_end_time):
            body['openEndTime'] = request.open_end_time
        if not UtilClient.is_unset(request.open_start_time):
            body['openStartTime'] = request.open_start_time
        if not UtilClient.is_unset(request.open_user_id):
            body['openUserId'] = request.open_user_id
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
            action='AdjustKit',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/kits/records/adjust',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.AdjustKitResponse(),
            self.execute(params, req, runtime)
        )

    async def adjust_kit_with_options_async(
        self,
        request: dingtalkedu__1__0_models.AdjustKitRequest,
        headers: dingtalkedu__1__0_models.AdjustKitHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.AdjustKitResponse:
        """
        @summary 修改教育套件
        
        @param request: AdjustKitRequest
        @param headers: AdjustKitHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AdjustKitResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.attributes):
            body['attributes'] = request.attributes
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.isv_product_scene):
            body['isvProductScene'] = request.isv_product_scene
        if not UtilClient.is_unset(request.open_end_time):
            body['openEndTime'] = request.open_end_time
        if not UtilClient.is_unset(request.open_start_time):
            body['openStartTime'] = request.open_start_time
        if not UtilClient.is_unset(request.open_user_id):
            body['openUserId'] = request.open_user_id
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
            action='AdjustKit',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/kits/records/adjust',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.AdjustKitResponse(),
            await self.execute_async(params, req, runtime)
        )

    def adjust_kit(
        self,
        request: dingtalkedu__1__0_models.AdjustKitRequest,
    ) -> dingtalkedu__1__0_models.AdjustKitResponse:
        """
        @summary 修改教育套件
        
        @param request: AdjustKitRequest
        @return: AdjustKitResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.AdjustKitHeaders()
        return self.adjust_kit_with_options(request, headers, runtime)

    async def adjust_kit_async(
        self,
        request: dingtalkedu__1__0_models.AdjustKitRequest,
    ) -> dingtalkedu__1__0_models.AdjustKitResponse:
        """
        @summary 修改教育套件
        
        @param request: AdjustKitRequest
        @return: AdjustKitResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.AdjustKitHeaders()
        return await self.adjust_kit_with_options_async(request, headers, runtime)

    def assign_class_with_options(
        self,
        request: dingtalkedu__1__0_models.AssignClassRequest,
        headers: dingtalkedu__1__0_models.AssignClassHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.AssignClassResponse:
        """
        @summary 进行分班
        
        @param request: AssignClassRequest
        @param headers: AssignClassHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AssignClassResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.class_id):
            body['classId'] = request.class_id
        if not UtilClient.is_unset(request.is_finish):
            body['isFinish'] = request.is_finish
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        if not UtilClient.is_unset(request.student_id):
            body['studentId'] = request.student_id
        if not UtilClient.is_unset(request.task_id):
            body['taskId'] = request.task_id
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
            action='AssignClass',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/newGrades/tasks/students/classes/assign',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.AssignClassResponse(),
            self.execute(params, req, runtime)
        )

    async def assign_class_with_options_async(
        self,
        request: dingtalkedu__1__0_models.AssignClassRequest,
        headers: dingtalkedu__1__0_models.AssignClassHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.AssignClassResponse:
        """
        @summary 进行分班
        
        @param request: AssignClassRequest
        @param headers: AssignClassHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AssignClassResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.class_id):
            body['classId'] = request.class_id
        if not UtilClient.is_unset(request.is_finish):
            body['isFinish'] = request.is_finish
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        if not UtilClient.is_unset(request.student_id):
            body['studentId'] = request.student_id
        if not UtilClient.is_unset(request.task_id):
            body['taskId'] = request.task_id
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
            action='AssignClass',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/newGrades/tasks/students/classes/assign',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.AssignClassResponse(),
            await self.execute_async(params, req, runtime)
        )

    def assign_class(
        self,
        request: dingtalkedu__1__0_models.AssignClassRequest,
    ) -> dingtalkedu__1__0_models.AssignClassResponse:
        """
        @summary 进行分班
        
        @param request: AssignClassRequest
        @return: AssignClassResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.AssignClassHeaders()
        return self.assign_class_with_options(request, headers, runtime)

    async def assign_class_async(
        self,
        request: dingtalkedu__1__0_models.AssignClassRequest,
    ) -> dingtalkedu__1__0_models.AssignClassResponse:
        """
        @summary 进行分班
        
        @param request: AssignClassRequest
        @return: AssignClassResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.AssignClassHeaders()
        return await self.assign_class_with_options_async(request, headers, runtime)

    def batch_create_with_options(
        self,
        request: dingtalkedu__1__0_models.BatchCreateRequest,
        headers: dingtalkedu__1__0_models.BatchCreateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.BatchCreateResponse:
        """
        @summary 批量创建打卡
        
        @param request: BatchCreateRequest
        @param headers: BatchCreateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchCreateResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.card_biz_code):
            body['cardBizCode'] = request.card_biz_code
        if not UtilClient.is_unset(request.data):
            body['data'] = request.data
        if not UtilClient.is_unset(request.identifier):
            body['identifier'] = request.identifier
        if not UtilClient.is_unset(request.js_version):
            body['jsVersion'] = request.js_version
        if not UtilClient.is_unset(request.source_type):
            body['sourceType'] = request.source_type
        if not UtilClient.is_unset(request.userid):
            body['userid'] = request.userid
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
            action='BatchCreate',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/cards',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.BatchCreateResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_create_with_options_async(
        self,
        request: dingtalkedu__1__0_models.BatchCreateRequest,
        headers: dingtalkedu__1__0_models.BatchCreateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.BatchCreateResponse:
        """
        @summary 批量创建打卡
        
        @param request: BatchCreateRequest
        @param headers: BatchCreateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchCreateResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.card_biz_code):
            body['cardBizCode'] = request.card_biz_code
        if not UtilClient.is_unset(request.data):
            body['data'] = request.data
        if not UtilClient.is_unset(request.identifier):
            body['identifier'] = request.identifier
        if not UtilClient.is_unset(request.js_version):
            body['jsVersion'] = request.js_version
        if not UtilClient.is_unset(request.source_type):
            body['sourceType'] = request.source_type
        if not UtilClient.is_unset(request.userid):
            body['userid'] = request.userid
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
            action='BatchCreate',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/cards',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.BatchCreateResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch_create(
        self,
        request: dingtalkedu__1__0_models.BatchCreateRequest,
    ) -> dingtalkedu__1__0_models.BatchCreateResponse:
        """
        @summary 批量创建打卡
        
        @param request: BatchCreateRequest
        @return: BatchCreateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.BatchCreateHeaders()
        return self.batch_create_with_options(request, headers, runtime)

    async def batch_create_async(
        self,
        request: dingtalkedu__1__0_models.BatchCreateRequest,
    ) -> dingtalkedu__1__0_models.BatchCreateResponse:
        """
        @summary 批量创建打卡
        
        @param request: BatchCreateRequest
        @return: BatchCreateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.BatchCreateHeaders()
        return await self.batch_create_with_options_async(request, headers, runtime)

    def batch_create_course_with_options(
        self,
        request: dingtalkedu__1__0_models.BatchCreateCourseRequest,
        headers: dingtalkedu__1__0_models.BatchCreateCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.BatchCreateCourseResponse:
        """
        @summary 批量创建课程
        
        @param request: BatchCreateCourseRequest
        @param headers: BatchCreateCourseHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchCreateCourseResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.class_id):
            body['classId'] = request.class_id
        if not UtilClient.is_unset(request.class_name):
            body['className'] = request.class_name
        if not UtilClient.is_unset(request.class_type):
            body['classType'] = request.class_type
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.course_detail_item_list):
            body['courseDetailItemList'] = request.course_detail_item_list
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.school_year):
            body['schoolYear'] = request.school_year
        if not UtilClient.is_unset(request.semester):
            body['semester'] = request.semester
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
            action='BatchCreateCourse',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/kits/courses/batchCreate',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.BatchCreateCourseResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_create_course_with_options_async(
        self,
        request: dingtalkedu__1__0_models.BatchCreateCourseRequest,
        headers: dingtalkedu__1__0_models.BatchCreateCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.BatchCreateCourseResponse:
        """
        @summary 批量创建课程
        
        @param request: BatchCreateCourseRequest
        @param headers: BatchCreateCourseHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchCreateCourseResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.class_id):
            body['classId'] = request.class_id
        if not UtilClient.is_unset(request.class_name):
            body['className'] = request.class_name
        if not UtilClient.is_unset(request.class_type):
            body['classType'] = request.class_type
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.course_detail_item_list):
            body['courseDetailItemList'] = request.course_detail_item_list
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.school_year):
            body['schoolYear'] = request.school_year
        if not UtilClient.is_unset(request.semester):
            body['semester'] = request.semester
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
            action='BatchCreateCourse',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/kits/courses/batchCreate',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.BatchCreateCourseResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch_create_course(
        self,
        request: dingtalkedu__1__0_models.BatchCreateCourseRequest,
    ) -> dingtalkedu__1__0_models.BatchCreateCourseResponse:
        """
        @summary 批量创建课程
        
        @param request: BatchCreateCourseRequest
        @return: BatchCreateCourseResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.BatchCreateCourseHeaders()
        return self.batch_create_course_with_options(request, headers, runtime)

    async def batch_create_course_async(
        self,
        request: dingtalkedu__1__0_models.BatchCreateCourseRequest,
    ) -> dingtalkedu__1__0_models.BatchCreateCourseResponse:
        """
        @summary 批量创建课程
        
        @param request: BatchCreateCourseRequest
        @return: BatchCreateCourseResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.BatchCreateCourseHeaders()
        return await self.batch_create_course_with_options_async(request, headers, runtime)

    def batch_create_student_class_with_options(
        self,
        request: dingtalkedu__1__0_models.BatchCreateStudentClassRequest,
        headers: dingtalkedu__1__0_models.BatchCreateStudentClassHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.BatchCreateStudentClassResponse:
        """
        @summary 批量创建学生班级
        
        @param request: BatchCreateStudentClassRequest
        @param headers: BatchCreateStudentClassHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchCreateStudentClassResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.class_id):
            body['classId'] = request.class_id
        if not UtilClient.is_unset(request.class_name):
            body['className'] = request.class_name
        if not UtilClient.is_unset(request.class_type):
            body['classType'] = request.class_type
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.student_list):
            body['studentList'] = request.student_list
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
            action='BatchCreateStudentClass',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/kits/students/classes/batchCreate',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.BatchCreateStudentClassResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_create_student_class_with_options_async(
        self,
        request: dingtalkedu__1__0_models.BatchCreateStudentClassRequest,
        headers: dingtalkedu__1__0_models.BatchCreateStudentClassHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.BatchCreateStudentClassResponse:
        """
        @summary 批量创建学生班级
        
        @param request: BatchCreateStudentClassRequest
        @param headers: BatchCreateStudentClassHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchCreateStudentClassResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.class_id):
            body['classId'] = request.class_id
        if not UtilClient.is_unset(request.class_name):
            body['className'] = request.class_name
        if not UtilClient.is_unset(request.class_type):
            body['classType'] = request.class_type
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.student_list):
            body['studentList'] = request.student_list
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
            action='BatchCreateStudentClass',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/kits/students/classes/batchCreate',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.BatchCreateStudentClassResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch_create_student_class(
        self,
        request: dingtalkedu__1__0_models.BatchCreateStudentClassRequest,
    ) -> dingtalkedu__1__0_models.BatchCreateStudentClassResponse:
        """
        @summary 批量创建学生班级
        
        @param request: BatchCreateStudentClassRequest
        @return: BatchCreateStudentClassResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.BatchCreateStudentClassHeaders()
        return self.batch_create_student_class_with_options(request, headers, runtime)

    async def batch_create_student_class_async(
        self,
        request: dingtalkedu__1__0_models.BatchCreateStudentClassRequest,
    ) -> dingtalkedu__1__0_models.BatchCreateStudentClassResponse:
        """
        @summary 批量创建学生班级
        
        @param request: BatchCreateStudentClassRequest
        @return: BatchCreateStudentClassResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.BatchCreateStudentClassHeaders()
        return await self.batch_create_student_class_with_options_async(request, headers, runtime)

    def batch_create_teacher_course_with_options(
        self,
        request: dingtalkedu__1__0_models.BatchCreateTeacherCourseRequest,
        headers: dingtalkedu__1__0_models.BatchCreateTeacherCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.BatchCreateTeacherCourseResponse:
        """
        @summary 批量创建老师课程
        
        @param request: BatchCreateTeacherCourseRequest
        @param headers: BatchCreateTeacherCourseHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchCreateTeacherCourseResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.teacher_course_detail_item_list):
            body['teacherCourseDetailItemList'] = request.teacher_course_detail_item_list
        if not UtilClient.is_unset(request.teacher_name):
            body['teacherName'] = request.teacher_name
        if not UtilClient.is_unset(request.teacher_user_id):
            body['teacherUserId'] = request.teacher_user_id
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
            action='BatchCreateTeacherCourse',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/kits/teachers/courses/batchCreate',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.BatchCreateTeacherCourseResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_create_teacher_course_with_options_async(
        self,
        request: dingtalkedu__1__0_models.BatchCreateTeacherCourseRequest,
        headers: dingtalkedu__1__0_models.BatchCreateTeacherCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.BatchCreateTeacherCourseResponse:
        """
        @summary 批量创建老师课程
        
        @param request: BatchCreateTeacherCourseRequest
        @param headers: BatchCreateTeacherCourseHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchCreateTeacherCourseResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.teacher_course_detail_item_list):
            body['teacherCourseDetailItemList'] = request.teacher_course_detail_item_list
        if not UtilClient.is_unset(request.teacher_name):
            body['teacherName'] = request.teacher_name
        if not UtilClient.is_unset(request.teacher_user_id):
            body['teacherUserId'] = request.teacher_user_id
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
            action='BatchCreateTeacherCourse',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/kits/teachers/courses/batchCreate',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.BatchCreateTeacherCourseResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch_create_teacher_course(
        self,
        request: dingtalkedu__1__0_models.BatchCreateTeacherCourseRequest,
    ) -> dingtalkedu__1__0_models.BatchCreateTeacherCourseResponse:
        """
        @summary 批量创建老师课程
        
        @param request: BatchCreateTeacherCourseRequest
        @return: BatchCreateTeacherCourseResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.BatchCreateTeacherCourseHeaders()
        return self.batch_create_teacher_course_with_options(request, headers, runtime)

    async def batch_create_teacher_course_async(
        self,
        request: dingtalkedu__1__0_models.BatchCreateTeacherCourseRequest,
    ) -> dingtalkedu__1__0_models.BatchCreateTeacherCourseResponse:
        """
        @summary 批量创建老师课程
        
        @param request: BatchCreateTeacherCourseRequest
        @return: BatchCreateTeacherCourseResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.BatchCreateTeacherCourseHeaders()
        return await self.batch_create_teacher_course_with_options_async(request, headers, runtime)

    def batch_invalid_course_with_options(
        self,
        request: dingtalkedu__1__0_models.BatchInvalidCourseRequest,
        headers: dingtalkedu__1__0_models.BatchInvalidCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.BatchInvalidCourseResponse:
        """
        @summary 批量失效课程
        
        @param request: BatchInvalidCourseRequest
        @param headers: BatchInvalidCourseHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchInvalidCourseResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.class_id):
            body['classId'] = request.class_id
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.isv_course_id):
            body['isvCourseId'] = request.isv_course_id
        if not UtilClient.is_unset(request.isv_course_ids):
            body['isvCourseIds'] = request.isv_course_ids
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
            action='BatchInvalidCourse',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/kits/courses/batchInvalid',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.BatchInvalidCourseResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_invalid_course_with_options_async(
        self,
        request: dingtalkedu__1__0_models.BatchInvalidCourseRequest,
        headers: dingtalkedu__1__0_models.BatchInvalidCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.BatchInvalidCourseResponse:
        """
        @summary 批量失效课程
        
        @param request: BatchInvalidCourseRequest
        @param headers: BatchInvalidCourseHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchInvalidCourseResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.class_id):
            body['classId'] = request.class_id
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.isv_course_id):
            body['isvCourseId'] = request.isv_course_id
        if not UtilClient.is_unset(request.isv_course_ids):
            body['isvCourseIds'] = request.isv_course_ids
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
            action='BatchInvalidCourse',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/kits/courses/batchInvalid',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.BatchInvalidCourseResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch_invalid_course(
        self,
        request: dingtalkedu__1__0_models.BatchInvalidCourseRequest,
    ) -> dingtalkedu__1__0_models.BatchInvalidCourseResponse:
        """
        @summary 批量失效课程
        
        @param request: BatchInvalidCourseRequest
        @return: BatchInvalidCourseResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.BatchInvalidCourseHeaders()
        return self.batch_invalid_course_with_options(request, headers, runtime)

    async def batch_invalid_course_async(
        self,
        request: dingtalkedu__1__0_models.BatchInvalidCourseRequest,
    ) -> dingtalkedu__1__0_models.BatchInvalidCourseResponse:
        """
        @summary 批量失效课程
        
        @param request: BatchInvalidCourseRequest
        @return: BatchInvalidCourseResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.BatchInvalidCourseHeaders()
        return await self.batch_invalid_course_with_options_async(request, headers, runtime)

    def batch_org_create_hwwith_options(
        self,
        request: dingtalkedu__1__0_models.BatchOrgCreateHWRequest,
        headers: dingtalkedu__1__0_models.BatchOrgCreateHWHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.BatchOrgCreateHWResponse:
        """
        @summary 跨组织-批量创建作业
        
        @param request: BatchOrgCreateHWRequest
        @param headers: BatchOrgCreateHWHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchOrgCreateHWResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.attributes):
            body['attributes'] = request.attributes
        if not UtilClient.is_unset(request.biz_code):
            body['bizCode'] = request.biz_code
        if not UtilClient.is_unset(request.course_name):
            body['courseName'] = request.course_name
        if not UtilClient.is_unset(request.hw_content):
            body['hwContent'] = request.hw_content
        if not UtilClient.is_unset(request.hw_deadline):
            body['hwDeadline'] = request.hw_deadline
        if not UtilClient.is_unset(request.hw_deadline_open):
            body['hwDeadlineOpen'] = request.hw_deadline_open
        if not UtilClient.is_unset(request.hw_media):
            body['hwMedia'] = request.hw_media
        if not UtilClient.is_unset(request.hw_photo):
            body['hwPhoto'] = request.hw_photo
        if not UtilClient.is_unset(request.hw_title):
            body['hwTitle'] = request.hw_title
        if not UtilClient.is_unset(request.hw_type):
            body['hwType'] = request.hw_type
        if not UtilClient.is_unset(request.hw_video):
            body['hwVideo'] = request.hw_video
        if not UtilClient.is_unset(request.identifier):
            body['identifier'] = request.identifier
        if not UtilClient.is_unset(request.open_select_item_list):
            body['openSelectItemList'] = request.open_select_item_list
        if not UtilClient.is_unset(request.scheduled_release):
            body['scheduledRelease'] = request.scheduled_release
        if not UtilClient.is_unset(request.scheduled_time):
            body['scheduledTime'] = request.scheduled_time
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
        if not UtilClient.is_unset(request.target_role):
            body['targetRole'] = request.target_role
        if not UtilClient.is_unset(request.teacher_name):
            body['teacherName'] = request.teacher_name
        if not UtilClient.is_unset(request.teacher_user_id):
            body['teacherUserId'] = request.teacher_user_id
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
            action='BatchOrgCreateHW',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/homeworks',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.BatchOrgCreateHWResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_org_create_hwwith_options_async(
        self,
        request: dingtalkedu__1__0_models.BatchOrgCreateHWRequest,
        headers: dingtalkedu__1__0_models.BatchOrgCreateHWHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.BatchOrgCreateHWResponse:
        """
        @summary 跨组织-批量创建作业
        
        @param request: BatchOrgCreateHWRequest
        @param headers: BatchOrgCreateHWHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchOrgCreateHWResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.attributes):
            body['attributes'] = request.attributes
        if not UtilClient.is_unset(request.biz_code):
            body['bizCode'] = request.biz_code
        if not UtilClient.is_unset(request.course_name):
            body['courseName'] = request.course_name
        if not UtilClient.is_unset(request.hw_content):
            body['hwContent'] = request.hw_content
        if not UtilClient.is_unset(request.hw_deadline):
            body['hwDeadline'] = request.hw_deadline
        if not UtilClient.is_unset(request.hw_deadline_open):
            body['hwDeadlineOpen'] = request.hw_deadline_open
        if not UtilClient.is_unset(request.hw_media):
            body['hwMedia'] = request.hw_media
        if not UtilClient.is_unset(request.hw_photo):
            body['hwPhoto'] = request.hw_photo
        if not UtilClient.is_unset(request.hw_title):
            body['hwTitle'] = request.hw_title
        if not UtilClient.is_unset(request.hw_type):
            body['hwType'] = request.hw_type
        if not UtilClient.is_unset(request.hw_video):
            body['hwVideo'] = request.hw_video
        if not UtilClient.is_unset(request.identifier):
            body['identifier'] = request.identifier
        if not UtilClient.is_unset(request.open_select_item_list):
            body['openSelectItemList'] = request.open_select_item_list
        if not UtilClient.is_unset(request.scheduled_release):
            body['scheduledRelease'] = request.scheduled_release
        if not UtilClient.is_unset(request.scheduled_time):
            body['scheduledTime'] = request.scheduled_time
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
        if not UtilClient.is_unset(request.target_role):
            body['targetRole'] = request.target_role
        if not UtilClient.is_unset(request.teacher_name):
            body['teacherName'] = request.teacher_name
        if not UtilClient.is_unset(request.teacher_user_id):
            body['teacherUserId'] = request.teacher_user_id
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
            action='BatchOrgCreateHW',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/homeworks',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.BatchOrgCreateHWResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch_org_create_hw(
        self,
        request: dingtalkedu__1__0_models.BatchOrgCreateHWRequest,
    ) -> dingtalkedu__1__0_models.BatchOrgCreateHWResponse:
        """
        @summary 跨组织-批量创建作业
        
        @param request: BatchOrgCreateHWRequest
        @return: BatchOrgCreateHWResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.BatchOrgCreateHWHeaders()
        return self.batch_org_create_hwwith_options(request, headers, runtime)

    async def batch_org_create_hw_async(
        self,
        request: dingtalkedu__1__0_models.BatchOrgCreateHWRequest,
    ) -> dingtalkedu__1__0_models.BatchOrgCreateHWResponse:
        """
        @summary 跨组织-批量创建作业
        
        @param request: BatchOrgCreateHWRequest
        @return: BatchOrgCreateHWResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.BatchOrgCreateHWHeaders()
        return await self.batch_org_create_hwwith_options_async(request, headers, runtime)

    def cancel_order_with_options(
        self,
        request: dingtalkedu__1__0_models.CancelOrderRequest,
        headers: dingtalkedu__1__0_models.CancelOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CancelOrderResponse:
        """
        @summary 撤销订单
        
        @param request: CancelOrderRequest
        @param headers: CancelOrderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CancelOrderResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.face_id):
            body['faceId'] = request.face_id
        if not UtilClient.is_unset(request.order_no):
            body['orderNo'] = request.order_no
        if not UtilClient.is_unset(request.signature):
            body['signature'] = request.signature
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
        if not UtilClient.is_unset(request.timestamp):
            body['timestamp'] = request.timestamp
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
            action='CancelOrder',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/orders/cancel',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CancelOrderResponse(),
            self.execute(params, req, runtime)
        )

    async def cancel_order_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CancelOrderRequest,
        headers: dingtalkedu__1__0_models.CancelOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CancelOrderResponse:
        """
        @summary 撤销订单
        
        @param request: CancelOrderRequest
        @param headers: CancelOrderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CancelOrderResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.face_id):
            body['faceId'] = request.face_id
        if not UtilClient.is_unset(request.order_no):
            body['orderNo'] = request.order_no
        if not UtilClient.is_unset(request.signature):
            body['signature'] = request.signature
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
        if not UtilClient.is_unset(request.timestamp):
            body['timestamp'] = request.timestamp
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
            action='CancelOrder',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/orders/cancel',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CancelOrderResponse(),
            await self.execute_async(params, req, runtime)
        )

    def cancel_order(
        self,
        request: dingtalkedu__1__0_models.CancelOrderRequest,
    ) -> dingtalkedu__1__0_models.CancelOrderResponse:
        """
        @summary 撤销订单
        
        @param request: CancelOrderRequest
        @return: CancelOrderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CancelOrderHeaders()
        return self.cancel_order_with_options(request, headers, runtime)

    async def cancel_order_async(
        self,
        request: dingtalkedu__1__0_models.CancelOrderRequest,
    ) -> dingtalkedu__1__0_models.CancelOrderResponse:
        """
        @summary 撤销订单
        
        @param request: CancelOrderRequest
        @return: CancelOrderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CancelOrderHeaders()
        return await self.cancel_order_with_options_async(request, headers, runtime)

    def cancel_sns_order_with_options(
        self,
        request: dingtalkedu__1__0_models.CancelSnsOrderRequest,
        headers: dingtalkedu__1__0_models.CancelSnsOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CancelSnsOrderResponse:
        """
        @summary 个人应用撤销订单
        
        @param request: CancelSnsOrderRequest
        @param headers: CancelSnsOrderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CancelSnsOrderResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.alipay_app_id):
            body['alipayAppId'] = request.alipay_app_id
        if not UtilClient.is_unset(request.merchant_id):
            body['merchantId'] = request.merchant_id
        if not UtilClient.is_unset(request.order_no):
            body['orderNo'] = request.order_no
        if not UtilClient.is_unset(request.signature):
            body['signature'] = request.signature
        if not UtilClient.is_unset(request.timestamp):
            body['timestamp'] = request.timestamp
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
            action='CancelSnsOrder',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/snsUserOrders/cancel',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CancelSnsOrderResponse(),
            self.execute(params, req, runtime)
        )

    async def cancel_sns_order_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CancelSnsOrderRequest,
        headers: dingtalkedu__1__0_models.CancelSnsOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CancelSnsOrderResponse:
        """
        @summary 个人应用撤销订单
        
        @param request: CancelSnsOrderRequest
        @param headers: CancelSnsOrderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CancelSnsOrderResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.alipay_app_id):
            body['alipayAppId'] = request.alipay_app_id
        if not UtilClient.is_unset(request.merchant_id):
            body['merchantId'] = request.merchant_id
        if not UtilClient.is_unset(request.order_no):
            body['orderNo'] = request.order_no
        if not UtilClient.is_unset(request.signature):
            body['signature'] = request.signature
        if not UtilClient.is_unset(request.timestamp):
            body['timestamp'] = request.timestamp
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
            action='CancelSnsOrder',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/snsUserOrders/cancel',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CancelSnsOrderResponse(),
            await self.execute_async(params, req, runtime)
        )

    def cancel_sns_order(
        self,
        request: dingtalkedu__1__0_models.CancelSnsOrderRequest,
    ) -> dingtalkedu__1__0_models.CancelSnsOrderResponse:
        """
        @summary 个人应用撤销订单
        
        @param request: CancelSnsOrderRequest
        @return: CancelSnsOrderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CancelSnsOrderHeaders()
        return self.cancel_sns_order_with_options(request, headers, runtime)

    async def cancel_sns_order_async(
        self,
        request: dingtalkedu__1__0_models.CancelSnsOrderRequest,
    ) -> dingtalkedu__1__0_models.CancelSnsOrderResponse:
        """
        @summary 个人应用撤销订单
        
        @param request: CancelSnsOrderRequest
        @return: CancelSnsOrderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CancelSnsOrderHeaders()
        return await self.cancel_sns_order_with_options_async(request, headers, runtime)

    def cancel_user_order_with_options(
        self,
        request: dingtalkedu__1__0_models.CancelUserOrderRequest,
        headers: dingtalkedu__1__0_models.CancelUserOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CancelUserOrderResponse:
        """
        @summary 取消订单
        
        @param request: CancelUserOrderRequest
        @param headers: CancelUserOrderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CancelUserOrderResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.alipay_app_id):
            body['alipayAppId'] = request.alipay_app_id
        if not UtilClient.is_unset(request.merchant_id):
            body['merchantId'] = request.merchant_id
        if not UtilClient.is_unset(request.order_no):
            body['orderNo'] = request.order_no
        if not UtilClient.is_unset(request.signature):
            body['signature'] = request.signature
        if not UtilClient.is_unset(request.timestamp):
            body['timestamp'] = request.timestamp
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
            action='CancelUserOrder',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/userOrders/cancel',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CancelUserOrderResponse(),
            self.execute(params, req, runtime)
        )

    async def cancel_user_order_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CancelUserOrderRequest,
        headers: dingtalkedu__1__0_models.CancelUserOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CancelUserOrderResponse:
        """
        @summary 取消订单
        
        @param request: CancelUserOrderRequest
        @param headers: CancelUserOrderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CancelUserOrderResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.alipay_app_id):
            body['alipayAppId'] = request.alipay_app_id
        if not UtilClient.is_unset(request.merchant_id):
            body['merchantId'] = request.merchant_id
        if not UtilClient.is_unset(request.order_no):
            body['orderNo'] = request.order_no
        if not UtilClient.is_unset(request.signature):
            body['signature'] = request.signature
        if not UtilClient.is_unset(request.timestamp):
            body['timestamp'] = request.timestamp
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
            action='CancelUserOrder',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/userOrders/cancel',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CancelUserOrderResponse(),
            await self.execute_async(params, req, runtime)
        )

    def cancel_user_order(
        self,
        request: dingtalkedu__1__0_models.CancelUserOrderRequest,
    ) -> dingtalkedu__1__0_models.CancelUserOrderResponse:
        """
        @summary 取消订单
        
        @param request: CancelUserOrderRequest
        @return: CancelUserOrderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CancelUserOrderHeaders()
        return self.cancel_user_order_with_options(request, headers, runtime)

    async def cancel_user_order_async(
        self,
        request: dingtalkedu__1__0_models.CancelUserOrderRequest,
    ) -> dingtalkedu__1__0_models.CancelUserOrderResponse:
        """
        @summary 取消订单
        
        @param request: CancelUserOrderRequest
        @return: CancelUserOrderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CancelUserOrderHeaders()
        return await self.cancel_user_order_with_options_async(request, headers, runtime)

    def card_batch_query_cards_with_options(
        self,
        request: dingtalkedu__1__0_models.CardBatchQueryCardsRequest,
        headers: dingtalkedu__1__0_models.CardBatchQueryCardsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CardBatchQueryCardsResponse:
        """
        @summary 批量查询打卡任务
        
        @param request: CardBatchQueryCardsRequest
        @param headers: CardBatchQueryCardsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CardBatchQueryCardsResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.card_biz_code):
            body['cardBizCode'] = request.card_biz_code
        if not UtilClient.is_unset(request.card_ids):
            body['cardIds'] = request.card_ids
        if not UtilClient.is_unset(request.source_type):
            body['sourceType'] = request.source_type
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
            action='CardBatchQueryCards',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/cards/tasks/batch',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CardBatchQueryCardsResponse(),
            self.execute(params, req, runtime)
        )

    async def card_batch_query_cards_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CardBatchQueryCardsRequest,
        headers: dingtalkedu__1__0_models.CardBatchQueryCardsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CardBatchQueryCardsResponse:
        """
        @summary 批量查询打卡任务
        
        @param request: CardBatchQueryCardsRequest
        @param headers: CardBatchQueryCardsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CardBatchQueryCardsResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.card_biz_code):
            body['cardBizCode'] = request.card_biz_code
        if not UtilClient.is_unset(request.card_ids):
            body['cardIds'] = request.card_ids
        if not UtilClient.is_unset(request.source_type):
            body['sourceType'] = request.source_type
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
            action='CardBatchQueryCards',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/cards/tasks/batch',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CardBatchQueryCardsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def card_batch_query_cards(
        self,
        request: dingtalkedu__1__0_models.CardBatchQueryCardsRequest,
    ) -> dingtalkedu__1__0_models.CardBatchQueryCardsResponse:
        """
        @summary 批量查询打卡任务
        
        @param request: CardBatchQueryCardsRequest
        @return: CardBatchQueryCardsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CardBatchQueryCardsHeaders()
        return self.card_batch_query_cards_with_options(request, headers, runtime)

    async def card_batch_query_cards_async(
        self,
        request: dingtalkedu__1__0_models.CardBatchQueryCardsRequest,
    ) -> dingtalkedu__1__0_models.CardBatchQueryCardsResponse:
        """
        @summary 批量查询打卡任务
        
        @param request: CardBatchQueryCardsRequest
        @return: CardBatchQueryCardsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CardBatchQueryCardsHeaders()
        return await self.card_batch_query_cards_with_options_async(request, headers, runtime)

    def card_delete_card_with_options(
        self,
        request: dingtalkedu__1__0_models.CardDeleteCardRequest,
        headers: dingtalkedu__1__0_models.CardDeleteCardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CardDeleteCardResponse:
        """
        @summary 删除打卡
        
        @param request: CardDeleteCardRequest
        @param headers: CardDeleteCardHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CardDeleteCardResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.card_biz_code):
            query['cardBizCode'] = request.card_biz_code
        if not UtilClient.is_unset(request.card_biz_id):
            query['cardBizId'] = request.card_biz_id
        if not UtilClient.is_unset(request.card_id):
            query['cardId'] = request.card_id
        if not UtilClient.is_unset(request.source_type):
            query['sourceType'] = request.source_type
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
            action='CardDeleteCard',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/cards',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CardDeleteCardResponse(),
            self.execute(params, req, runtime)
        )

    async def card_delete_card_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CardDeleteCardRequest,
        headers: dingtalkedu__1__0_models.CardDeleteCardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CardDeleteCardResponse:
        """
        @summary 删除打卡
        
        @param request: CardDeleteCardRequest
        @param headers: CardDeleteCardHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CardDeleteCardResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.card_biz_code):
            query['cardBizCode'] = request.card_biz_code
        if not UtilClient.is_unset(request.card_biz_id):
            query['cardBizId'] = request.card_biz_id
        if not UtilClient.is_unset(request.card_id):
            query['cardId'] = request.card_id
        if not UtilClient.is_unset(request.source_type):
            query['sourceType'] = request.source_type
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
            action='CardDeleteCard',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/cards',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CardDeleteCardResponse(),
            await self.execute_async(params, req, runtime)
        )

    def card_delete_card(
        self,
        request: dingtalkedu__1__0_models.CardDeleteCardRequest,
    ) -> dingtalkedu__1__0_models.CardDeleteCardResponse:
        """
        @summary 删除打卡
        
        @param request: CardDeleteCardRequest
        @return: CardDeleteCardResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CardDeleteCardHeaders()
        return self.card_delete_card_with_options(request, headers, runtime)

    async def card_delete_card_async(
        self,
        request: dingtalkedu__1__0_models.CardDeleteCardRequest,
    ) -> dingtalkedu__1__0_models.CardDeleteCardResponse:
        """
        @summary 删除打卡
        
        @param request: CardDeleteCardRequest
        @return: CardDeleteCardResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CardDeleteCardHeaders()
        return await self.card_delete_card_with_options_async(request, headers, runtime)

    def card_end_card_with_options(
        self,
        request: dingtalkedu__1__0_models.CardEndCardRequest,
        headers: dingtalkedu__1__0_models.CardEndCardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CardEndCardResponse:
        """
        @summary 打卡-结束打卡
        
        @param request: CardEndCardRequest
        @param headers: CardEndCardHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CardEndCardResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.card_biz_code):
            body['cardBizCode'] = request.card_biz_code
        if not UtilClient.is_unset(request.card_biz_id):
            body['cardBizId'] = request.card_biz_id
        if not UtilClient.is_unset(request.card_id):
            body['cardId'] = request.card_id
        if not UtilClient.is_unset(request.source_type):
            body['sourceType'] = request.source_type
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
            action='CardEndCard',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/cards/finish',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CardEndCardResponse(),
            self.execute(params, req, runtime)
        )

    async def card_end_card_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CardEndCardRequest,
        headers: dingtalkedu__1__0_models.CardEndCardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CardEndCardResponse:
        """
        @summary 打卡-结束打卡
        
        @param request: CardEndCardRequest
        @param headers: CardEndCardHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CardEndCardResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.card_biz_code):
            body['cardBizCode'] = request.card_biz_code
        if not UtilClient.is_unset(request.card_biz_id):
            body['cardBizId'] = request.card_biz_id
        if not UtilClient.is_unset(request.card_id):
            body['cardId'] = request.card_id
        if not UtilClient.is_unset(request.source_type):
            body['sourceType'] = request.source_type
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
            action='CardEndCard',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/cards/finish',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CardEndCardResponse(),
            await self.execute_async(params, req, runtime)
        )

    def card_end_card(
        self,
        request: dingtalkedu__1__0_models.CardEndCardRequest,
    ) -> dingtalkedu__1__0_models.CardEndCardResponse:
        """
        @summary 打卡-结束打卡
        
        @param request: CardEndCardRequest
        @return: CardEndCardResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CardEndCardHeaders()
        return self.card_end_card_with_options(request, headers, runtime)

    async def card_end_card_async(
        self,
        request: dingtalkedu__1__0_models.CardEndCardRequest,
    ) -> dingtalkedu__1__0_models.CardEndCardResponse:
        """
        @summary 打卡-结束打卡
        
        @param request: CardEndCardRequest
        @return: CardEndCardResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CardEndCardHeaders()
        return await self.card_end_card_with_options_async(request, headers, runtime)

    def card_get_card_with_options(
        self,
        request: dingtalkedu__1__0_models.CardGetCardRequest,
        headers: dingtalkedu__1__0_models.CardGetCardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CardGetCardResponse:
        """
        @summary 查询打卡任务
        
        @param request: CardGetCardRequest
        @param headers: CardGetCardHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CardGetCardResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.card_id):
            query['cardId'] = request.card_id
        if not UtilClient.is_unset(request.source_type):
            query['sourceType'] = request.source_type
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
            action='CardGetCard',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/cards/tasks',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CardGetCardResponse(),
            self.execute(params, req, runtime)
        )

    async def card_get_card_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CardGetCardRequest,
        headers: dingtalkedu__1__0_models.CardGetCardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CardGetCardResponse:
        """
        @summary 查询打卡任务
        
        @param request: CardGetCardRequest
        @param headers: CardGetCardHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CardGetCardResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.card_id):
            query['cardId'] = request.card_id
        if not UtilClient.is_unset(request.source_type):
            query['sourceType'] = request.source_type
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
            action='CardGetCard',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/cards/tasks',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CardGetCardResponse(),
            await self.execute_async(params, req, runtime)
        )

    def card_get_card(
        self,
        request: dingtalkedu__1__0_models.CardGetCardRequest,
    ) -> dingtalkedu__1__0_models.CardGetCardResponse:
        """
        @summary 查询打卡任务
        
        @param request: CardGetCardRequest
        @return: CardGetCardResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CardGetCardHeaders()
        return self.card_get_card_with_options(request, headers, runtime)

    async def card_get_card_async(
        self,
        request: dingtalkedu__1__0_models.CardGetCardRequest,
    ) -> dingtalkedu__1__0_models.CardGetCardResponse:
        """
        @summary 查询打卡任务
        
        @param request: CardGetCardRequest
        @return: CardGetCardResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CardGetCardHeaders()
        return await self.card_get_card_with_options_async(request, headers, runtime)

    def card_get_card_finish_progress_with_options(
        self,
        request: dingtalkedu__1__0_models.CardGetCardFinishProgressRequest,
        headers: dingtalkedu__1__0_models.CardGetCardFinishProgressHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CardGetCardFinishProgressResponse:
        """
        @summary 获取打卡任务完成进度
        
        @param request: CardGetCardFinishProgressRequest
        @param headers: CardGetCardFinishProgressHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CardGetCardFinishProgressResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.card_biz_code):
            query['cardBizCode'] = request.card_biz_code
        if not UtilClient.is_unset(request.card_biz_id):
            query['cardBizId'] = request.card_biz_id
        if not UtilClient.is_unset(request.card_id):
            query['cardId'] = request.card_id
        if not UtilClient.is_unset(request.source_type):
            query['sourceType'] = request.source_type
        if not UtilClient.is_unset(request.student_id):
            query['studentId'] = request.student_id
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
            action='CardGetCardFinishProgress',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/cards/completionProgress',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CardGetCardFinishProgressResponse(),
            self.execute(params, req, runtime)
        )

    async def card_get_card_finish_progress_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CardGetCardFinishProgressRequest,
        headers: dingtalkedu__1__0_models.CardGetCardFinishProgressHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CardGetCardFinishProgressResponse:
        """
        @summary 获取打卡任务完成进度
        
        @param request: CardGetCardFinishProgressRequest
        @param headers: CardGetCardFinishProgressHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CardGetCardFinishProgressResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.card_biz_code):
            query['cardBizCode'] = request.card_biz_code
        if not UtilClient.is_unset(request.card_biz_id):
            query['cardBizId'] = request.card_biz_id
        if not UtilClient.is_unset(request.card_id):
            query['cardId'] = request.card_id
        if not UtilClient.is_unset(request.source_type):
            query['sourceType'] = request.source_type
        if not UtilClient.is_unset(request.student_id):
            query['studentId'] = request.student_id
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
            action='CardGetCardFinishProgress',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/cards/completionProgress',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CardGetCardFinishProgressResponse(),
            await self.execute_async(params, req, runtime)
        )

    def card_get_card_finish_progress(
        self,
        request: dingtalkedu__1__0_models.CardGetCardFinishProgressRequest,
    ) -> dingtalkedu__1__0_models.CardGetCardFinishProgressResponse:
        """
        @summary 获取打卡任务完成进度
        
        @param request: CardGetCardFinishProgressRequest
        @return: CardGetCardFinishProgressResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CardGetCardFinishProgressHeaders()
        return self.card_get_card_finish_progress_with_options(request, headers, runtime)

    async def card_get_card_finish_progress_async(
        self,
        request: dingtalkedu__1__0_models.CardGetCardFinishProgressRequest,
    ) -> dingtalkedu__1__0_models.CardGetCardFinishProgressResponse:
        """
        @summary 获取打卡任务完成进度
        
        @param request: CardGetCardFinishProgressRequest
        @return: CardGetCardFinishProgressResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CardGetCardFinishProgressHeaders()
        return await self.card_get_card_finish_progress_with_options_async(request, headers, runtime)

    def card_query_card_feeds_with_options(
        self,
        request: dingtalkedu__1__0_models.CardQueryCardFeedsRequest,
        headers: dingtalkedu__1__0_models.CardQueryCardFeedsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CardQueryCardFeedsResponse:
        """
        @summary 查询打卡Feed流
        
        @param request: CardQueryCardFeedsRequest
        @param headers: CardQueryCardFeedsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CardQueryCardFeedsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.biz_type):
            query['bizType'] = request.biz_type
        if not UtilClient.is_unset(request.card_biz_code):
            query['cardBizCode'] = request.card_biz_code
        if not UtilClient.is_unset(request.card_biz_id):
            query['cardBizId'] = request.card_biz_id
        if not UtilClient.is_unset(request.card_id):
            query['cardId'] = request.card_id
        if not UtilClient.is_unset(request.count):
            query['count'] = request.count
        if not UtilClient.is_unset(request.cursor):
            query['cursor'] = request.cursor
        if not UtilClient.is_unset(request.feed_type):
            query['feedType'] = request.feed_type
        if not UtilClient.is_unset(request.need_finish_process):
            query['needFinishProcess'] = request.need_finish_process
        if not UtilClient.is_unset(request.source_type):
            query['sourceType'] = request.source_type
        if not UtilClient.is_unset(request.student_id):
            query['studentId'] = request.student_id
        if not UtilClient.is_unset(request.sub_biz_id):
            query['subBizId'] = request.sub_biz_id
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
            action='CardQueryCardFeeds',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/cards/feeds',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CardQueryCardFeedsResponse(),
            self.execute(params, req, runtime)
        )

    async def card_query_card_feeds_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CardQueryCardFeedsRequest,
        headers: dingtalkedu__1__0_models.CardQueryCardFeedsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CardQueryCardFeedsResponse:
        """
        @summary 查询打卡Feed流
        
        @param request: CardQueryCardFeedsRequest
        @param headers: CardQueryCardFeedsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CardQueryCardFeedsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.biz_type):
            query['bizType'] = request.biz_type
        if not UtilClient.is_unset(request.card_biz_code):
            query['cardBizCode'] = request.card_biz_code
        if not UtilClient.is_unset(request.card_biz_id):
            query['cardBizId'] = request.card_biz_id
        if not UtilClient.is_unset(request.card_id):
            query['cardId'] = request.card_id
        if not UtilClient.is_unset(request.count):
            query['count'] = request.count
        if not UtilClient.is_unset(request.cursor):
            query['cursor'] = request.cursor
        if not UtilClient.is_unset(request.feed_type):
            query['feedType'] = request.feed_type
        if not UtilClient.is_unset(request.need_finish_process):
            query['needFinishProcess'] = request.need_finish_process
        if not UtilClient.is_unset(request.source_type):
            query['sourceType'] = request.source_type
        if not UtilClient.is_unset(request.student_id):
            query['studentId'] = request.student_id
        if not UtilClient.is_unset(request.sub_biz_id):
            query['subBizId'] = request.sub_biz_id
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
            action='CardQueryCardFeeds',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/cards/feeds',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CardQueryCardFeedsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def card_query_card_feeds(
        self,
        request: dingtalkedu__1__0_models.CardQueryCardFeedsRequest,
    ) -> dingtalkedu__1__0_models.CardQueryCardFeedsResponse:
        """
        @summary 查询打卡Feed流
        
        @param request: CardQueryCardFeedsRequest
        @return: CardQueryCardFeedsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CardQueryCardFeedsHeaders()
        return self.card_query_card_feeds_with_options(request, headers, runtime)

    async def card_query_card_feeds_async(
        self,
        request: dingtalkedu__1__0_models.CardQueryCardFeedsRequest,
    ) -> dingtalkedu__1__0_models.CardQueryCardFeedsResponse:
        """
        @summary 查询打卡Feed流
        
        @param request: CardQueryCardFeedsRequest
        @return: CardQueryCardFeedsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CardQueryCardFeedsHeaders()
        return await self.card_query_card_feeds_with_options_async(request, headers, runtime)

    def check_restriction_with_options(
        self,
        request: dingtalkedu__1__0_models.CheckRestrictionRequest,
        headers: dingtalkedu__1__0_models.CheckRestrictionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CheckRestrictionResponse:
        """
        @summary 支付校验
        
        @param request: CheckRestrictionRequest
        @param headers: CheckRestrictionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CheckRestrictionResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.actual_amount):
            body['actualAmount'] = request.actual_amount
        if not UtilClient.is_unset(request.face_id):
            body['faceId'] = request.face_id
        if not UtilClient.is_unset(request.scene):
            body['scene'] = request.scene
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
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
            action='CheckRestriction',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/restrictions/check',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CheckRestrictionResponse(),
            self.execute(params, req, runtime)
        )

    async def check_restriction_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CheckRestrictionRequest,
        headers: dingtalkedu__1__0_models.CheckRestrictionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CheckRestrictionResponse:
        """
        @summary 支付校验
        
        @param request: CheckRestrictionRequest
        @param headers: CheckRestrictionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CheckRestrictionResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.actual_amount):
            body['actualAmount'] = request.actual_amount
        if not UtilClient.is_unset(request.face_id):
            body['faceId'] = request.face_id
        if not UtilClient.is_unset(request.scene):
            body['scene'] = request.scene
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
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
            action='CheckRestriction',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/restrictions/check',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CheckRestrictionResponse(),
            await self.execute_async(params, req, runtime)
        )

    def check_restriction(
        self,
        request: dingtalkedu__1__0_models.CheckRestrictionRequest,
    ) -> dingtalkedu__1__0_models.CheckRestrictionResponse:
        """
        @summary 支付校验
        
        @param request: CheckRestrictionRequest
        @return: CheckRestrictionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CheckRestrictionHeaders()
        return self.check_restriction_with_options(request, headers, runtime)

    async def check_restriction_async(
        self,
        request: dingtalkedu__1__0_models.CheckRestrictionRequest,
    ) -> dingtalkedu__1__0_models.CheckRestrictionResponse:
        """
        @summary 支付校验
        
        @param request: CheckRestrictionRequest
        @return: CheckRestrictionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CheckRestrictionHeaders()
        return await self.check_restriction_with_options_async(request, headers, runtime)

    def consume_point_with_options(
        self,
        request: dingtalkedu__1__0_models.ConsumePointRequest,
        headers: dingtalkedu__1__0_models.ConsumePointHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.ConsumePointResponse:
        """
        @summary 积分兑换
        
        @param request: ConsumePointRequest
        @param headers: ConsumePointHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ConsumePointResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.amount):
            body['amount'] = request.amount
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.product_code):
            body['productCode'] = request.product_code
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
            action='ConsumePoint',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/poins/consume',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.ConsumePointResponse(),
            self.execute(params, req, runtime)
        )

    async def consume_point_with_options_async(
        self,
        request: dingtalkedu__1__0_models.ConsumePointRequest,
        headers: dingtalkedu__1__0_models.ConsumePointHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.ConsumePointResponse:
        """
        @summary 积分兑换
        
        @param request: ConsumePointRequest
        @param headers: ConsumePointHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ConsumePointResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.amount):
            body['amount'] = request.amount
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.product_code):
            body['productCode'] = request.product_code
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
            action='ConsumePoint',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/poins/consume',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.ConsumePointResponse(),
            await self.execute_async(params, req, runtime)
        )

    def consume_point(
        self,
        request: dingtalkedu__1__0_models.ConsumePointRequest,
    ) -> dingtalkedu__1__0_models.ConsumePointResponse:
        """
        @summary 积分兑换
        
        @param request: ConsumePointRequest
        @return: ConsumePointResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.ConsumePointHeaders()
        return self.consume_point_with_options(request, headers, runtime)

    async def consume_point_async(
        self,
        request: dingtalkedu__1__0_models.ConsumePointRequest,
    ) -> dingtalkedu__1__0_models.ConsumePointResponse:
        """
        @summary 积分兑换
        
        @param request: ConsumePointRequest
        @return: ConsumePointResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.ConsumePointHeaders()
        return await self.consume_point_with_options_async(request, headers, runtime)

    def course_scheduling_compliment_notice_with_options(
        self,
        request: dingtalkedu__1__0_models.CourseSchedulingComplimentNoticeRequest,
        headers: dingtalkedu__1__0_models.CourseSchedulingComplimentNoticeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CourseSchedulingComplimentNoticeResponse:
        """
        @summary 全校排课结束通知
        
        @param request: CourseSchedulingComplimentNoticeRequest
        @param headers: CourseSchedulingComplimentNoticeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CourseSchedulingComplimentNoticeResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
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
            action='CourseSchedulingComplimentNotice',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/schedules/finishNotify',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CourseSchedulingComplimentNoticeResponse(),
            self.execute(params, req, runtime)
        )

    async def course_scheduling_compliment_notice_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CourseSchedulingComplimentNoticeRequest,
        headers: dingtalkedu__1__0_models.CourseSchedulingComplimentNoticeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CourseSchedulingComplimentNoticeResponse:
        """
        @summary 全校排课结束通知
        
        @param request: CourseSchedulingComplimentNoticeRequest
        @param headers: CourseSchedulingComplimentNoticeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CourseSchedulingComplimentNoticeResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
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
            action='CourseSchedulingComplimentNotice',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/schedules/finishNotify',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CourseSchedulingComplimentNoticeResponse(),
            await self.execute_async(params, req, runtime)
        )

    def course_scheduling_compliment_notice(
        self,
        request: dingtalkedu__1__0_models.CourseSchedulingComplimentNoticeRequest,
    ) -> dingtalkedu__1__0_models.CourseSchedulingComplimentNoticeResponse:
        """
        @summary 全校排课结束通知
        
        @param request: CourseSchedulingComplimentNoticeRequest
        @return: CourseSchedulingComplimentNoticeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CourseSchedulingComplimentNoticeHeaders()
        return self.course_scheduling_compliment_notice_with_options(request, headers, runtime)

    async def course_scheduling_compliment_notice_async(
        self,
        request: dingtalkedu__1__0_models.CourseSchedulingComplimentNoticeRequest,
    ) -> dingtalkedu__1__0_models.CourseSchedulingComplimentNoticeResponse:
        """
        @summary 全校排课结束通知
        
        @param request: CourseSchedulingComplimentNoticeRequest
        @return: CourseSchedulingComplimentNoticeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CourseSchedulingComplimentNoticeHeaders()
        return await self.course_scheduling_compliment_notice_with_options_async(request, headers, runtime)

    def create_app_order_with_options(
        self,
        request: dingtalkedu__1__0_models.CreateAppOrderRequest,
        headers: dingtalkedu__1__0_models.CreateAppOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateAppOrderResponse:
        """
        @summary 创建App支付订单
        
        @param request: CreateAppOrderRequest
        @param headers: CreateAppOrderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateAppOrderResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.actual_amount):
            body['actualAmount'] = request.actual_amount
        if not UtilClient.is_unset(request.alipay_app_id):
            body['alipayAppId'] = request.alipay_app_id
        if not UtilClient.is_unset(request.biz_code):
            body['bizCode'] = request.biz_code
        if not UtilClient.is_unset(request.detail_list):
            body['detailList'] = request.detail_list
        if not UtilClient.is_unset(request.label_amount):
            body['labelAmount'] = request.label_amount
        if not UtilClient.is_unset(request.merchant_id):
            body['merchantId'] = request.merchant_id
        if not UtilClient.is_unset(request.merchant_order_no):
            body['merchantOrderNo'] = request.merchant_order_no
        if not UtilClient.is_unset(request.outer_user_id):
            body['outerUserId'] = request.outer_user_id
        if not UtilClient.is_unset(request.signature):
            body['signature'] = request.signature
        if not UtilClient.is_unset(request.subject):
            body['subject'] = request.subject
        if not UtilClient.is_unset(request.timestamp):
            body['timestamp'] = request.timestamp
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
            action='CreateAppOrder',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/appOrders',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateAppOrderResponse(),
            self.execute(params, req, runtime)
        )

    async def create_app_order_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CreateAppOrderRequest,
        headers: dingtalkedu__1__0_models.CreateAppOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateAppOrderResponse:
        """
        @summary 创建App支付订单
        
        @param request: CreateAppOrderRequest
        @param headers: CreateAppOrderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateAppOrderResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.actual_amount):
            body['actualAmount'] = request.actual_amount
        if not UtilClient.is_unset(request.alipay_app_id):
            body['alipayAppId'] = request.alipay_app_id
        if not UtilClient.is_unset(request.biz_code):
            body['bizCode'] = request.biz_code
        if not UtilClient.is_unset(request.detail_list):
            body['detailList'] = request.detail_list
        if not UtilClient.is_unset(request.label_amount):
            body['labelAmount'] = request.label_amount
        if not UtilClient.is_unset(request.merchant_id):
            body['merchantId'] = request.merchant_id
        if not UtilClient.is_unset(request.merchant_order_no):
            body['merchantOrderNo'] = request.merchant_order_no
        if not UtilClient.is_unset(request.outer_user_id):
            body['outerUserId'] = request.outer_user_id
        if not UtilClient.is_unset(request.signature):
            body['signature'] = request.signature
        if not UtilClient.is_unset(request.subject):
            body['subject'] = request.subject
        if not UtilClient.is_unset(request.timestamp):
            body['timestamp'] = request.timestamp
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
            action='CreateAppOrder',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/appOrders',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateAppOrderResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_app_order(
        self,
        request: dingtalkedu__1__0_models.CreateAppOrderRequest,
    ) -> dingtalkedu__1__0_models.CreateAppOrderResponse:
        """
        @summary 创建App支付订单
        
        @param request: CreateAppOrderRequest
        @return: CreateAppOrderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateAppOrderHeaders()
        return self.create_app_order_with_options(request, headers, runtime)

    async def create_app_order_async(
        self,
        request: dingtalkedu__1__0_models.CreateAppOrderRequest,
    ) -> dingtalkedu__1__0_models.CreateAppOrderResponse:
        """
        @summary 创建App支付订单
        
        @param request: CreateAppOrderRequest
        @return: CreateAppOrderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateAppOrderHeaders()
        return await self.create_app_order_with_options_async(request, headers, runtime)

    def create_college_contact_dept_with_options(
        self,
        request: dingtalkedu__1__0_models.CreateCollegeContactDeptRequest,
        headers: dingtalkedu__1__0_models.CreateCollegeContactDeptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateCollegeContactDeptResponse:
        """
        @summary 创建高校通讯录组织单元
        
        @param request: CreateCollegeContactDeptRequest
        @param headers: CreateCollegeContactDeptHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateCollegeContactDeptResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.auto_approve_apply):
            body['autoApproveApply'] = request.auto_approve_apply
        if not UtilClient.is_unset(request.brief):
            body['brief'] = request.brief
        if not UtilClient.is_unset(request.code):
            body['code'] = request.code
        if not UtilClient.is_unset(request.create_dept_group):
            body['createDeptGroup'] = request.create_dept_group
        if not UtilClient.is_unset(request.dept_code):
            body['deptCode'] = request.dept_code
        if not UtilClient.is_unset(request.dept_permits):
            body['deptPermits'] = request.dept_permits
        if not UtilClient.is_unset(request.dept_type):
            body['deptType'] = request.dept_type
        if not UtilClient.is_unset(request.emp_apply_join_dept):
            body['empApplyJoinDept'] = request.emp_apply_join_dept
        if not UtilClient.is_unset(request.extension):
            body['extension'] = request.extension
        if not UtilClient.is_unset(request.hide_dept):
            body['hideDept'] = request.hide_dept
        if not UtilClient.is_unset(request.hide_scene_config):
            body['hideSceneConfig'] = request.hide_scene_config
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.order):
            body['order'] = request.order
        if not UtilClient.is_unset(request.outer_dept):
            body['outerDept'] = request.outer_dept
        if not UtilClient.is_unset(request.outer_dept_only_self):
            body['outerDeptOnlySelf'] = request.outer_dept_only_self
        if not UtilClient.is_unset(request.outer_permit_depts):
            body['outerPermitDepts'] = request.outer_permit_depts
        if not UtilClient.is_unset(request.outer_permit_users):
            body['outerPermitUsers'] = request.outer_permit_users
        if not UtilClient.is_unset(request.outer_scene_config):
            body['outerSceneConfig'] = request.outer_scene_config
        if not UtilClient.is_unset(request.parent_id):
            body['parentId'] = request.parent_id
        if not UtilClient.is_unset(request.source_identifier):
            body['sourceIdentifier'] = request.source_identifier
        if not UtilClient.is_unset(request.stru_id):
            body['struId'] = request.stru_id
        if not UtilClient.is_unset(request.telephone):
            body['telephone'] = request.telephone
        if not UtilClient.is_unset(request.user_permits):
            body['userPermits'] = request.user_permits
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
            action='CreateCollegeContactDept',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/collegeContact/depts',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateCollegeContactDeptResponse(),
            self.execute(params, req, runtime)
        )

    async def create_college_contact_dept_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CreateCollegeContactDeptRequest,
        headers: dingtalkedu__1__0_models.CreateCollegeContactDeptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateCollegeContactDeptResponse:
        """
        @summary 创建高校通讯录组织单元
        
        @param request: CreateCollegeContactDeptRequest
        @param headers: CreateCollegeContactDeptHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateCollegeContactDeptResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.auto_approve_apply):
            body['autoApproveApply'] = request.auto_approve_apply
        if not UtilClient.is_unset(request.brief):
            body['brief'] = request.brief
        if not UtilClient.is_unset(request.code):
            body['code'] = request.code
        if not UtilClient.is_unset(request.create_dept_group):
            body['createDeptGroup'] = request.create_dept_group
        if not UtilClient.is_unset(request.dept_code):
            body['deptCode'] = request.dept_code
        if not UtilClient.is_unset(request.dept_permits):
            body['deptPermits'] = request.dept_permits
        if not UtilClient.is_unset(request.dept_type):
            body['deptType'] = request.dept_type
        if not UtilClient.is_unset(request.emp_apply_join_dept):
            body['empApplyJoinDept'] = request.emp_apply_join_dept
        if not UtilClient.is_unset(request.extension):
            body['extension'] = request.extension
        if not UtilClient.is_unset(request.hide_dept):
            body['hideDept'] = request.hide_dept
        if not UtilClient.is_unset(request.hide_scene_config):
            body['hideSceneConfig'] = request.hide_scene_config
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.order):
            body['order'] = request.order
        if not UtilClient.is_unset(request.outer_dept):
            body['outerDept'] = request.outer_dept
        if not UtilClient.is_unset(request.outer_dept_only_self):
            body['outerDeptOnlySelf'] = request.outer_dept_only_self
        if not UtilClient.is_unset(request.outer_permit_depts):
            body['outerPermitDepts'] = request.outer_permit_depts
        if not UtilClient.is_unset(request.outer_permit_users):
            body['outerPermitUsers'] = request.outer_permit_users
        if not UtilClient.is_unset(request.outer_scene_config):
            body['outerSceneConfig'] = request.outer_scene_config
        if not UtilClient.is_unset(request.parent_id):
            body['parentId'] = request.parent_id
        if not UtilClient.is_unset(request.source_identifier):
            body['sourceIdentifier'] = request.source_identifier
        if not UtilClient.is_unset(request.stru_id):
            body['struId'] = request.stru_id
        if not UtilClient.is_unset(request.telephone):
            body['telephone'] = request.telephone
        if not UtilClient.is_unset(request.user_permits):
            body['userPermits'] = request.user_permits
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
            action='CreateCollegeContactDept',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/collegeContact/depts',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateCollegeContactDeptResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_college_contact_dept(
        self,
        request: dingtalkedu__1__0_models.CreateCollegeContactDeptRequest,
    ) -> dingtalkedu__1__0_models.CreateCollegeContactDeptResponse:
        """
        @summary 创建高校通讯录组织单元
        
        @param request: CreateCollegeContactDeptRequest
        @return: CreateCollegeContactDeptResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateCollegeContactDeptHeaders()
        return self.create_college_contact_dept_with_options(request, headers, runtime)

    async def create_college_contact_dept_async(
        self,
        request: dingtalkedu__1__0_models.CreateCollegeContactDeptRequest,
    ) -> dingtalkedu__1__0_models.CreateCollegeContactDeptResponse:
        """
        @summary 创建高校通讯录组织单元
        
        @param request: CreateCollegeContactDeptRequest
        @return: CreateCollegeContactDeptResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateCollegeContactDeptHeaders()
        return await self.create_college_contact_dept_with_options_async(request, headers, runtime)

    def create_course_with_options(
        self,
        request: dingtalkedu__1__0_models.CreateCourseRequest,
        headers: dingtalkedu__1__0_models.CreateCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateCourseResponse:
        """
        @summary 创建课程
        
        @param request: CreateCourseRequest
        @param headers: CreateCourseHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateCourseResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.attributes):
            body['attributes'] = request.attributes
        if not UtilClient.is_unset(request.class_id):
            body['classId'] = request.class_id
        if not UtilClient.is_unset(request.class_name):
            body['className'] = request.class_name
        if not UtilClient.is_unset(request.class_room_id):
            body['classRoomId'] = request.class_room_id
        if not UtilClient.is_unset(request.class_room_name):
            body['classRoomName'] = request.class_room_name
        if not UtilClient.is_unset(request.class_type):
            body['classType'] = request.class_type
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.course_code):
            body['courseCode'] = request.course_code
        if not UtilClient.is_unset(request.course_date):
            body['courseDate'] = request.course_date
        if not UtilClient.is_unset(request.course_name):
            body['courseName'] = request.course_name
        if not UtilClient.is_unset(request.course_week):
            body['courseWeek'] = request.course_week
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.isv_course_id):
            body['isvCourseId'] = request.isv_course_id
        if not UtilClient.is_unset(request.memo):
            body['memo'] = request.memo
        if not UtilClient.is_unset(request.school_year):
            body['schoolYear'] = request.school_year
        if not UtilClient.is_unset(request.semester):
            body['semester'] = request.semester
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
        if not UtilClient.is_unset(request.teach_week):
            body['teachWeek'] = request.teach_week
        if not UtilClient.is_unset(request.teacher_list):
            body['teacherList'] = request.teacher_list
        if not UtilClient.is_unset(request.timeslot_name):
            body['timeslotName'] = request.timeslot_name
        if not UtilClient.is_unset(request.timeslot_num):
            body['timeslotNum'] = request.timeslot_num
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
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
            action='CreateCourse',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/kits/courses',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateCourseResponse(),
            self.execute(params, req, runtime)
        )

    async def create_course_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CreateCourseRequest,
        headers: dingtalkedu__1__0_models.CreateCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateCourseResponse:
        """
        @summary 创建课程
        
        @param request: CreateCourseRequest
        @param headers: CreateCourseHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateCourseResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.attributes):
            body['attributes'] = request.attributes
        if not UtilClient.is_unset(request.class_id):
            body['classId'] = request.class_id
        if not UtilClient.is_unset(request.class_name):
            body['className'] = request.class_name
        if not UtilClient.is_unset(request.class_room_id):
            body['classRoomId'] = request.class_room_id
        if not UtilClient.is_unset(request.class_room_name):
            body['classRoomName'] = request.class_room_name
        if not UtilClient.is_unset(request.class_type):
            body['classType'] = request.class_type
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.course_code):
            body['courseCode'] = request.course_code
        if not UtilClient.is_unset(request.course_date):
            body['courseDate'] = request.course_date
        if not UtilClient.is_unset(request.course_name):
            body['courseName'] = request.course_name
        if not UtilClient.is_unset(request.course_week):
            body['courseWeek'] = request.course_week
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.isv_course_id):
            body['isvCourseId'] = request.isv_course_id
        if not UtilClient.is_unset(request.memo):
            body['memo'] = request.memo
        if not UtilClient.is_unset(request.school_year):
            body['schoolYear'] = request.school_year
        if not UtilClient.is_unset(request.semester):
            body['semester'] = request.semester
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
        if not UtilClient.is_unset(request.teach_week):
            body['teachWeek'] = request.teach_week
        if not UtilClient.is_unset(request.teacher_list):
            body['teacherList'] = request.teacher_list
        if not UtilClient.is_unset(request.timeslot_name):
            body['timeslotName'] = request.timeslot_name
        if not UtilClient.is_unset(request.timeslot_num):
            body['timeslotNum'] = request.timeslot_num
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
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
            action='CreateCourse',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/kits/courses',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateCourseResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_course(
        self,
        request: dingtalkedu__1__0_models.CreateCourseRequest,
    ) -> dingtalkedu__1__0_models.CreateCourseResponse:
        """
        @summary 创建课程
        
        @param request: CreateCourseRequest
        @return: CreateCourseResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateCourseHeaders()
        return self.create_course_with_options(request, headers, runtime)

    async def create_course_async(
        self,
        request: dingtalkedu__1__0_models.CreateCourseRequest,
    ) -> dingtalkedu__1__0_models.CreateCourseResponse:
        """
        @summary 创建课程
        
        @param request: CreateCourseRequest
        @return: CreateCourseResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateCourseHeaders()
        return await self.create_course_with_options_async(request, headers, runtime)

    def create_custom_class_with_options(
        self,
        request: dingtalkedu__1__0_models.CreateCustomClassRequest,
        headers: dingtalkedu__1__0_models.CreateCustomClassHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateCustomClassResponse:
        """
        @summary 创建自定义部门下班级
        
        @param request: CreateCustomClassRequest
        @param headers: CreateCustomClassHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateCustomClassResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.custom_class):
            body['customClass'] = request.custom_class
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        if not UtilClient.is_unset(request.super_id):
            body['superId'] = request.super_id
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
            action='CreateCustomClass',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/customClasses',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateCustomClassResponse(),
            self.execute(params, req, runtime)
        )

    async def create_custom_class_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CreateCustomClassRequest,
        headers: dingtalkedu__1__0_models.CreateCustomClassHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateCustomClassResponse:
        """
        @summary 创建自定义部门下班级
        
        @param request: CreateCustomClassRequest
        @param headers: CreateCustomClassHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateCustomClassResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.custom_class):
            body['customClass'] = request.custom_class
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        if not UtilClient.is_unset(request.super_id):
            body['superId'] = request.super_id
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
            action='CreateCustomClass',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/customClasses',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateCustomClassResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_custom_class(
        self,
        request: dingtalkedu__1__0_models.CreateCustomClassRequest,
    ) -> dingtalkedu__1__0_models.CreateCustomClassResponse:
        """
        @summary 创建自定义部门下班级
        
        @param request: CreateCustomClassRequest
        @return: CreateCustomClassResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateCustomClassHeaders()
        return self.create_custom_class_with_options(request, headers, runtime)

    async def create_custom_class_async(
        self,
        request: dingtalkedu__1__0_models.CreateCustomClassRequest,
    ) -> dingtalkedu__1__0_models.CreateCustomClassResponse:
        """
        @summary 创建自定义部门下班级
        
        @param request: CreateCustomClassRequest
        @return: CreateCustomClassResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateCustomClassHeaders()
        return await self.create_custom_class_with_options_async(request, headers, runtime)

    def create_custom_dept_with_options(
        self,
        request: dingtalkedu__1__0_models.CreateCustomDeptRequest,
        headers: dingtalkedu__1__0_models.CreateCustomDeptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateCustomDeptResponse:
        """
        @summary 创建自定义校区或部门
        
        @param request: CreateCustomDeptRequest
        @param headers: CreateCustomDeptHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateCustomDeptResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.custom_dept):
            body['customDept'] = request.custom_dept
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        if not UtilClient.is_unset(request.super_id):
            body['superId'] = request.super_id
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
            action='CreateCustomDept',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/customDepts',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateCustomDeptResponse(),
            self.execute(params, req, runtime)
        )

    async def create_custom_dept_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CreateCustomDeptRequest,
        headers: dingtalkedu__1__0_models.CreateCustomDeptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateCustomDeptResponse:
        """
        @summary 创建自定义校区或部门
        
        @param request: CreateCustomDeptRequest
        @param headers: CreateCustomDeptHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateCustomDeptResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.custom_dept):
            body['customDept'] = request.custom_dept
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        if not UtilClient.is_unset(request.super_id):
            body['superId'] = request.super_id
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
            action='CreateCustomDept',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/customDepts',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateCustomDeptResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_custom_dept(
        self,
        request: dingtalkedu__1__0_models.CreateCustomDeptRequest,
    ) -> dingtalkedu__1__0_models.CreateCustomDeptResponse:
        """
        @summary 创建自定义校区或部门
        
        @param request: CreateCustomDeptRequest
        @return: CreateCustomDeptResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateCustomDeptHeaders()
        return self.create_custom_dept_with_options(request, headers, runtime)

    async def create_custom_dept_async(
        self,
        request: dingtalkedu__1__0_models.CreateCustomDeptRequest,
    ) -> dingtalkedu__1__0_models.CreateCustomDeptResponse:
        """
        @summary 创建自定义校区或部门
        
        @param request: CreateCustomDeptRequest
        @return: CreateCustomDeptResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateCustomDeptHeaders()
        return await self.create_custom_dept_with_options_async(request, headers, runtime)

    def create_edu_asset_space_with_options(
        self,
        request: dingtalkedu__1__0_models.CreateEduAssetSpaceRequest,
        headers: dingtalkedu__1__0_models.CreateEduAssetSpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateEduAssetSpaceResponse:
        """
        @summary 教学资源库创建space
        
        @param request: CreateEduAssetSpaceRequest
        @param headers: CreateEduAssetSpaceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateEduAssetSpaceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_code):
            body['bizCode'] = request.biz_code
        if not UtilClient.is_unset(request.space_desc):
            body['spaceDesc'] = request.space_desc
        if not UtilClient.is_unset(request.space_icon):
            body['spaceIcon'] = request.space_icon
        if not UtilClient.is_unset(request.space_name):
            body['spaceName'] = request.space_name
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
            action='CreateEduAssetSpace',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/assets/spaces',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateEduAssetSpaceResponse(),
            self.execute(params, req, runtime)
        )

    async def create_edu_asset_space_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CreateEduAssetSpaceRequest,
        headers: dingtalkedu__1__0_models.CreateEduAssetSpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateEduAssetSpaceResponse:
        """
        @summary 教学资源库创建space
        
        @param request: CreateEduAssetSpaceRequest
        @param headers: CreateEduAssetSpaceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateEduAssetSpaceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_code):
            body['bizCode'] = request.biz_code
        if not UtilClient.is_unset(request.space_desc):
            body['spaceDesc'] = request.space_desc
        if not UtilClient.is_unset(request.space_icon):
            body['spaceIcon'] = request.space_icon
        if not UtilClient.is_unset(request.space_name):
            body['spaceName'] = request.space_name
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
            action='CreateEduAssetSpace',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/assets/spaces',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateEduAssetSpaceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_edu_asset_space(
        self,
        request: dingtalkedu__1__0_models.CreateEduAssetSpaceRequest,
    ) -> dingtalkedu__1__0_models.CreateEduAssetSpaceResponse:
        """
        @summary 教学资源库创建space
        
        @param request: CreateEduAssetSpaceRequest
        @return: CreateEduAssetSpaceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateEduAssetSpaceHeaders()
        return self.create_edu_asset_space_with_options(request, headers, runtime)

    async def create_edu_asset_space_async(
        self,
        request: dingtalkedu__1__0_models.CreateEduAssetSpaceRequest,
    ) -> dingtalkedu__1__0_models.CreateEduAssetSpaceResponse:
        """
        @summary 教学资源库创建space
        
        @param request: CreateEduAssetSpaceRequest
        @return: CreateEduAssetSpaceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateEduAssetSpaceHeaders()
        return await self.create_edu_asset_space_with_options_async(request, headers, runtime)

    def create_fulfil_record_with_options(
        self,
        request: dingtalkedu__1__0_models.CreateFulfilRecordRequest,
        headers: dingtalkedu__1__0_models.CreateFulfilRecordHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateFulfilRecordResponse:
        """
        @summary 创建设备履约记录，亲情通话、考勤数据同步
        
        @param request: CreateFulfilRecordRequest
        @param headers: CreateFulfilRecordHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateFulfilRecordResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_time):
            body['bizTime'] = request.biz_time
        if not UtilClient.is_unset(request.ext_info):
            body['extInfo'] = request.ext_info
        if not UtilClient.is_unset(request.face_id):
            body['faceId'] = request.face_id
        if not UtilClient.is_unset(request.scene):
            body['scene'] = request.scene
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
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
            action='CreateFulfilRecord',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/fulfilRecords',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateFulfilRecordResponse(),
            self.execute(params, req, runtime)
        )

    async def create_fulfil_record_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CreateFulfilRecordRequest,
        headers: dingtalkedu__1__0_models.CreateFulfilRecordHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateFulfilRecordResponse:
        """
        @summary 创建设备履约记录，亲情通话、考勤数据同步
        
        @param request: CreateFulfilRecordRequest
        @param headers: CreateFulfilRecordHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateFulfilRecordResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_time):
            body['bizTime'] = request.biz_time
        if not UtilClient.is_unset(request.ext_info):
            body['extInfo'] = request.ext_info
        if not UtilClient.is_unset(request.face_id):
            body['faceId'] = request.face_id
        if not UtilClient.is_unset(request.scene):
            body['scene'] = request.scene
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
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
            action='CreateFulfilRecord',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/fulfilRecords',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateFulfilRecordResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_fulfil_record(
        self,
        request: dingtalkedu__1__0_models.CreateFulfilRecordRequest,
    ) -> dingtalkedu__1__0_models.CreateFulfilRecordResponse:
        """
        @summary 创建设备履约记录，亲情通话、考勤数据同步
        
        @param request: CreateFulfilRecordRequest
        @return: CreateFulfilRecordResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateFulfilRecordHeaders()
        return self.create_fulfil_record_with_options(request, headers, runtime)

    async def create_fulfil_record_async(
        self,
        request: dingtalkedu__1__0_models.CreateFulfilRecordRequest,
    ) -> dingtalkedu__1__0_models.CreateFulfilRecordResponse:
        """
        @summary 创建设备履约记录，亲情通话、考勤数据同步
        
        @param request: CreateFulfilRecordRequest
        @return: CreateFulfilRecordResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateFulfilRecordHeaders()
        return await self.create_fulfil_record_with_options_async(request, headers, runtime)

    def create_invite_url_with_options(
        self,
        request: dingtalkedu__1__0_models.CreateInviteUrlRequest,
        headers: dingtalkedu__1__0_models.CreateInviteUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateInviteUrlResponse:
        """
        @summary 查询某个组织下面的设备列表
        
        @param request: CreateInviteUrlRequest
        @param headers: CreateInviteUrlHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateInviteUrlResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.auth_code):
            body['authCode'] = request.auth_code
        if not UtilClient.is_unset(request.target_corp_id):
            body['targetCorpId'] = request.target_corp_id
        if not UtilClient.is_unset(request.target_operator):
            body['targetOperator'] = request.target_operator
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
            action='CreateInviteUrl',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/remoteClasses/orgRelations/inviteUrls',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateInviteUrlResponse(),
            self.execute(params, req, runtime)
        )

    async def create_invite_url_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CreateInviteUrlRequest,
        headers: dingtalkedu__1__0_models.CreateInviteUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateInviteUrlResponse:
        """
        @summary 查询某个组织下面的设备列表
        
        @param request: CreateInviteUrlRequest
        @param headers: CreateInviteUrlHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateInviteUrlResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.auth_code):
            body['authCode'] = request.auth_code
        if not UtilClient.is_unset(request.target_corp_id):
            body['targetCorpId'] = request.target_corp_id
        if not UtilClient.is_unset(request.target_operator):
            body['targetOperator'] = request.target_operator
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
            action='CreateInviteUrl',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/remoteClasses/orgRelations/inviteUrls',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateInviteUrlResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_invite_url(
        self,
        request: dingtalkedu__1__0_models.CreateInviteUrlRequest,
    ) -> dingtalkedu__1__0_models.CreateInviteUrlResponse:
        """
        @summary 查询某个组织下面的设备列表
        
        @param request: CreateInviteUrlRequest
        @return: CreateInviteUrlResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateInviteUrlHeaders()
        return self.create_invite_url_with_options(request, headers, runtime)

    async def create_invite_url_async(
        self,
        request: dingtalkedu__1__0_models.CreateInviteUrlRequest,
    ) -> dingtalkedu__1__0_models.CreateInviteUrlResponse:
        """
        @summary 查询某个组织下面的设备列表
        
        @param request: CreateInviteUrlRequest
        @return: CreateInviteUrlResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateInviteUrlHeaders()
        return await self.create_invite_url_with_options_async(request, headers, runtime)

    def create_item_with_options(
        self,
        request: dingtalkedu__1__0_models.CreateItemRequest,
        headers: dingtalkedu__1__0_models.CreateItemHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateItemResponse:
        """
        @summary 创建商品
        
        @param request: CreateItemRequest
        @param headers: CreateItemHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateItemResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.effect_type):
            body['effectType'] = request.effect_type
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.merchant_id):
            body['merchantId'] = request.merchant_id
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.opt_user):
            body['optUser'] = request.opt_user
        if not UtilClient.is_unset(request.period_type):
            body['periodType'] = request.period_type
        if not UtilClient.is_unset(request.price):
            body['price'] = request.price
        if not UtilClient.is_unset(request.scene):
            body['scene'] = request.scene
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
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
            action='CreateItem',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/items',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateItemResponse(),
            self.execute(params, req, runtime)
        )

    async def create_item_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CreateItemRequest,
        headers: dingtalkedu__1__0_models.CreateItemHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateItemResponse:
        """
        @summary 创建商品
        
        @param request: CreateItemRequest
        @param headers: CreateItemHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateItemResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.effect_type):
            body['effectType'] = request.effect_type
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.merchant_id):
            body['merchantId'] = request.merchant_id
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.opt_user):
            body['optUser'] = request.opt_user
        if not UtilClient.is_unset(request.period_type):
            body['periodType'] = request.period_type
        if not UtilClient.is_unset(request.price):
            body['price'] = request.price
        if not UtilClient.is_unset(request.scene):
            body['scene'] = request.scene
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
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
            action='CreateItem',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/items',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateItemResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_item(
        self,
        request: dingtalkedu__1__0_models.CreateItemRequest,
    ) -> dingtalkedu__1__0_models.CreateItemResponse:
        """
        @summary 创建商品
        
        @param request: CreateItemRequest
        @return: CreateItemResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateItemHeaders()
        return self.create_item_with_options(request, headers, runtime)

    async def create_item_async(
        self,
        request: dingtalkedu__1__0_models.CreateItemRequest,
    ) -> dingtalkedu__1__0_models.CreateItemResponse:
        """
        @summary 创建商品
        
        @param request: CreateItemRequest
        @return: CreateItemResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateItemHeaders()
        return await self.create_item_with_options_async(request, headers, runtime)

    def create_order_with_options(
        self,
        request: dingtalkedu__1__0_models.CreateOrderRequest,
        headers: dingtalkedu__1__0_models.CreateOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateOrderResponse:
        """
        @summary 创建订单信息
        
        @param request: CreateOrderRequest
        @param headers: CreateOrderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateOrderResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.actual_amount):
            body['actualAmount'] = request.actual_amount
        if not UtilClient.is_unset(request.create_time):
            body['createTime'] = request.create_time
        if not UtilClient.is_unset(request.detail_list):
            body['detailList'] = request.detail_list
        if not UtilClient.is_unset(request.face_id):
            body['faceId'] = request.face_id
        if not UtilClient.is_unset(request.ftoken):
            body['ftoken'] = request.ftoken
        if not UtilClient.is_unset(request.signature):
            body['signature'] = request.signature
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
        if not UtilClient.is_unset(request.terminal_params):
            body['terminalParams'] = request.terminal_params
        if not UtilClient.is_unset(request.timestamp):
            body['timestamp'] = request.timestamp
        if not UtilClient.is_unset(request.total_amount):
            body['totalAmount'] = request.total_amount
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.version):
            body['version'] = request.version
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
            action='CreateOrder',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/orders',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateOrderResponse(),
            self.execute(params, req, runtime)
        )

    async def create_order_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CreateOrderRequest,
        headers: dingtalkedu__1__0_models.CreateOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateOrderResponse:
        """
        @summary 创建订单信息
        
        @param request: CreateOrderRequest
        @param headers: CreateOrderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateOrderResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.actual_amount):
            body['actualAmount'] = request.actual_amount
        if not UtilClient.is_unset(request.create_time):
            body['createTime'] = request.create_time
        if not UtilClient.is_unset(request.detail_list):
            body['detailList'] = request.detail_list
        if not UtilClient.is_unset(request.face_id):
            body['faceId'] = request.face_id
        if not UtilClient.is_unset(request.ftoken):
            body['ftoken'] = request.ftoken
        if not UtilClient.is_unset(request.signature):
            body['signature'] = request.signature
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
        if not UtilClient.is_unset(request.terminal_params):
            body['terminalParams'] = request.terminal_params
        if not UtilClient.is_unset(request.timestamp):
            body['timestamp'] = request.timestamp
        if not UtilClient.is_unset(request.total_amount):
            body['totalAmount'] = request.total_amount
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.version):
            body['version'] = request.version
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
            action='CreateOrder',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/orders',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateOrderResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_order(
        self,
        request: dingtalkedu__1__0_models.CreateOrderRequest,
    ) -> dingtalkedu__1__0_models.CreateOrderResponse:
        """
        @summary 创建订单信息
        
        @param request: CreateOrderRequest
        @return: CreateOrderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateOrderHeaders()
        return self.create_order_with_options(request, headers, runtime)

    async def create_order_async(
        self,
        request: dingtalkedu__1__0_models.CreateOrderRequest,
    ) -> dingtalkedu__1__0_models.CreateOrderResponse:
        """
        @summary 创建订单信息
        
        @param request: CreateOrderRequest
        @return: CreateOrderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateOrderHeaders()
        return await self.create_order_with_options_async(request, headers, runtime)

    def create_order_flow_with_options(
        self,
        request: dingtalkedu__1__0_models.CreateOrderFlowRequest,
        headers: dingtalkedu__1__0_models.CreateOrderFlowHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateOrderFlowResponse:
        """
        @summary 创建开单流水
        
        @param request: CreateOrderFlowRequest
        @param headers: CreateOrderFlowHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateOrderFlowResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.actual_amount):
            body['actualAmount'] = request.actual_amount
        if not UtilClient.is_unset(request.alipay_uid):
            body['alipayUid'] = request.alipay_uid
        if not UtilClient.is_unset(request.create_time):
            body['createTime'] = request.create_time
        if not UtilClient.is_unset(request.detail_list):
            body['detailList'] = request.detail_list
        if not UtilClient.is_unset(request.face_id):
            body['faceId'] = request.face_id
        if not UtilClient.is_unset(request.guardian_user_id):
            body['guardianUserId'] = request.guardian_user_id
        if not UtilClient.is_unset(request.merchant_id):
            body['merchantId'] = request.merchant_id
        if not UtilClient.is_unset(request.order_no):
            body['orderNo'] = request.order_no
        if not UtilClient.is_unset(request.signature):
            body['signature'] = request.signature
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
        if not UtilClient.is_unset(request.timestamp):
            body['timestamp'] = request.timestamp
        if not UtilClient.is_unset(request.total_amount):
            body['totalAmount'] = request.total_amount
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
            action='CreateOrderFlow',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/orders/flows',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateOrderFlowResponse(),
            self.execute(params, req, runtime)
        )

    async def create_order_flow_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CreateOrderFlowRequest,
        headers: dingtalkedu__1__0_models.CreateOrderFlowHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateOrderFlowResponse:
        """
        @summary 创建开单流水
        
        @param request: CreateOrderFlowRequest
        @param headers: CreateOrderFlowHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateOrderFlowResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.actual_amount):
            body['actualAmount'] = request.actual_amount
        if not UtilClient.is_unset(request.alipay_uid):
            body['alipayUid'] = request.alipay_uid
        if not UtilClient.is_unset(request.create_time):
            body['createTime'] = request.create_time
        if not UtilClient.is_unset(request.detail_list):
            body['detailList'] = request.detail_list
        if not UtilClient.is_unset(request.face_id):
            body['faceId'] = request.face_id
        if not UtilClient.is_unset(request.guardian_user_id):
            body['guardianUserId'] = request.guardian_user_id
        if not UtilClient.is_unset(request.merchant_id):
            body['merchantId'] = request.merchant_id
        if not UtilClient.is_unset(request.order_no):
            body['orderNo'] = request.order_no
        if not UtilClient.is_unset(request.signature):
            body['signature'] = request.signature
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
        if not UtilClient.is_unset(request.timestamp):
            body['timestamp'] = request.timestamp
        if not UtilClient.is_unset(request.total_amount):
            body['totalAmount'] = request.total_amount
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
            action='CreateOrderFlow',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/orders/flows',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateOrderFlowResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_order_flow(
        self,
        request: dingtalkedu__1__0_models.CreateOrderFlowRequest,
    ) -> dingtalkedu__1__0_models.CreateOrderFlowResponse:
        """
        @summary 创建开单流水
        
        @param request: CreateOrderFlowRequest
        @return: CreateOrderFlowResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateOrderFlowHeaders()
        return self.create_order_flow_with_options(request, headers, runtime)

    async def create_order_flow_async(
        self,
        request: dingtalkedu__1__0_models.CreateOrderFlowRequest,
    ) -> dingtalkedu__1__0_models.CreateOrderFlowResponse:
        """
        @summary 创建开单流水
        
        @param request: CreateOrderFlowRequest
        @return: CreateOrderFlowResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateOrderFlowHeaders()
        return await self.create_order_flow_with_options_async(request, headers, runtime)

    def create_physical_classroom_with_options(
        self,
        request: dingtalkedu__1__0_models.CreatePhysicalClassroomRequest,
        headers: dingtalkedu__1__0_models.CreatePhysicalClassroomHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreatePhysicalClassroomResponse:
        """
        @summary 添加物理教室信息
        
        @param request: CreatePhysicalClassroomRequest
        @param headers: CreatePhysicalClassroomHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreatePhysicalClassroomResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.classroom_building):
            body['classroomBuilding'] = request.classroom_building
        if not UtilClient.is_unset(request.classroom_campus):
            body['classroomCampus'] = request.classroom_campus
        if not UtilClient.is_unset(request.classroom_floor):
            body['classroomFloor'] = request.classroom_floor
        if not UtilClient.is_unset(request.classroom_name):
            body['classroomName'] = request.classroom_name
        if not UtilClient.is_unset(request.classroom_number):
            body['classroomNumber'] = request.classroom_number
        if not UtilClient.is_unset(request.direct_broadcast):
            body['directBroadcast'] = request.direct_broadcast
        if not UtilClient.is_unset(request.ext):
            body['ext'] = request.ext
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
            action='CreatePhysicalClassroom',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/physicalClassrooms',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreatePhysicalClassroomResponse(),
            self.execute(params, req, runtime)
        )

    async def create_physical_classroom_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CreatePhysicalClassroomRequest,
        headers: dingtalkedu__1__0_models.CreatePhysicalClassroomHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreatePhysicalClassroomResponse:
        """
        @summary 添加物理教室信息
        
        @param request: CreatePhysicalClassroomRequest
        @param headers: CreatePhysicalClassroomHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreatePhysicalClassroomResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.classroom_building):
            body['classroomBuilding'] = request.classroom_building
        if not UtilClient.is_unset(request.classroom_campus):
            body['classroomCampus'] = request.classroom_campus
        if not UtilClient.is_unset(request.classroom_floor):
            body['classroomFloor'] = request.classroom_floor
        if not UtilClient.is_unset(request.classroom_name):
            body['classroomName'] = request.classroom_name
        if not UtilClient.is_unset(request.classroom_number):
            body['classroomNumber'] = request.classroom_number
        if not UtilClient.is_unset(request.direct_broadcast):
            body['directBroadcast'] = request.direct_broadcast
        if not UtilClient.is_unset(request.ext):
            body['ext'] = request.ext
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
            action='CreatePhysicalClassroom',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/physicalClassrooms',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreatePhysicalClassroomResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_physical_classroom(
        self,
        request: dingtalkedu__1__0_models.CreatePhysicalClassroomRequest,
    ) -> dingtalkedu__1__0_models.CreatePhysicalClassroomResponse:
        """
        @summary 添加物理教室信息
        
        @param request: CreatePhysicalClassroomRequest
        @return: CreatePhysicalClassroomResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreatePhysicalClassroomHeaders()
        return self.create_physical_classroom_with_options(request, headers, runtime)

    async def create_physical_classroom_async(
        self,
        request: dingtalkedu__1__0_models.CreatePhysicalClassroomRequest,
    ) -> dingtalkedu__1__0_models.CreatePhysicalClassroomResponse:
        """
        @summary 添加物理教室信息
        
        @param request: CreatePhysicalClassroomRequest
        @return: CreatePhysicalClassroomResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreatePhysicalClassroomHeaders()
        return await self.create_physical_classroom_with_options_async(request, headers, runtime)

    def create_refund_flow_with_options(
        self,
        request: dingtalkedu__1__0_models.CreateRefundFlowRequest,
        headers: dingtalkedu__1__0_models.CreateRefundFlowHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateRefundFlowResponse:
        """
        @summary 创建退款流水
        
        @param request: CreateRefundFlowRequest
        @param headers: CreateRefundFlowHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateRefundFlowResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.face_id):
            body['faceId'] = request.face_id
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.operator_name):
            body['operatorName'] = request.operator_name
        if not UtilClient.is_unset(request.order_no):
            body['orderNo'] = request.order_no
        if not UtilClient.is_unset(request.signature):
            body['signature'] = request.signature
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
        if not UtilClient.is_unset(request.timestamp):
            body['timestamp'] = request.timestamp
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
            action='CreateRefundFlow',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/refunds/flows',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateRefundFlowResponse(),
            self.execute(params, req, runtime)
        )

    async def create_refund_flow_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CreateRefundFlowRequest,
        headers: dingtalkedu__1__0_models.CreateRefundFlowHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateRefundFlowResponse:
        """
        @summary 创建退款流水
        
        @param request: CreateRefundFlowRequest
        @param headers: CreateRefundFlowHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateRefundFlowResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.face_id):
            body['faceId'] = request.face_id
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.operator_name):
            body['operatorName'] = request.operator_name
        if not UtilClient.is_unset(request.order_no):
            body['orderNo'] = request.order_no
        if not UtilClient.is_unset(request.signature):
            body['signature'] = request.signature
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
        if not UtilClient.is_unset(request.timestamp):
            body['timestamp'] = request.timestamp
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
            action='CreateRefundFlow',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/refunds/flows',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateRefundFlowResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_refund_flow(
        self,
        request: dingtalkedu__1__0_models.CreateRefundFlowRequest,
    ) -> dingtalkedu__1__0_models.CreateRefundFlowResponse:
        """
        @summary 创建退款流水
        
        @param request: CreateRefundFlowRequest
        @return: CreateRefundFlowResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateRefundFlowHeaders()
        return self.create_refund_flow_with_options(request, headers, runtime)

    async def create_refund_flow_async(
        self,
        request: dingtalkedu__1__0_models.CreateRefundFlowRequest,
    ) -> dingtalkedu__1__0_models.CreateRefundFlowResponse:
        """
        @summary 创建退款流水
        
        @param request: CreateRefundFlowRequest
        @return: CreateRefundFlowResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateRefundFlowHeaders()
        return await self.create_refund_flow_with_options_async(request, headers, runtime)

    def create_remote_class_course_with_options(
        self,
        request: dingtalkedu__1__0_models.CreateRemoteClassCourseRequest,
        headers: dingtalkedu__1__0_models.CreateRemoteClassCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateRemoteClassCourseResponse:
        """
        @summary 创建预约类型的专递课堂
        
        @param request: CreateRemoteClassCourseRequest
        @param headers: CreateRemoteClassCourseHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateRemoteClassCourseResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.attend_participants):
            body['attendParticipants'] = request.attend_participants
        if not UtilClient.is_unset(request.auth_code):
            body['authCode'] = request.auth_code
        if not UtilClient.is_unset(request.course_name):
            body['courseName'] = request.course_name
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.teaching_participant):
            body['teachingParticipant'] = request.teaching_participant
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
            action='CreateRemoteClassCourse',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/remoteClasses/courses',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateRemoteClassCourseResponse(),
            self.execute(params, req, runtime)
        )

    async def create_remote_class_course_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CreateRemoteClassCourseRequest,
        headers: dingtalkedu__1__0_models.CreateRemoteClassCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateRemoteClassCourseResponse:
        """
        @summary 创建预约类型的专递课堂
        
        @param request: CreateRemoteClassCourseRequest
        @param headers: CreateRemoteClassCourseHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateRemoteClassCourseResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.attend_participants):
            body['attendParticipants'] = request.attend_participants
        if not UtilClient.is_unset(request.auth_code):
            body['authCode'] = request.auth_code
        if not UtilClient.is_unset(request.course_name):
            body['courseName'] = request.course_name
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.teaching_participant):
            body['teachingParticipant'] = request.teaching_participant
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
            action='CreateRemoteClassCourse',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/remoteClasses/courses',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateRemoteClassCourseResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_remote_class_course(
        self,
        request: dingtalkedu__1__0_models.CreateRemoteClassCourseRequest,
    ) -> dingtalkedu__1__0_models.CreateRemoteClassCourseResponse:
        """
        @summary 创建预约类型的专递课堂
        
        @param request: CreateRemoteClassCourseRequest
        @return: CreateRemoteClassCourseResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateRemoteClassCourseHeaders()
        return self.create_remote_class_course_with_options(request, headers, runtime)

    async def create_remote_class_course_async(
        self,
        request: dingtalkedu__1__0_models.CreateRemoteClassCourseRequest,
    ) -> dingtalkedu__1__0_models.CreateRemoteClassCourseResponse:
        """
        @summary 创建预约类型的专递课堂
        
        @param request: CreateRemoteClassCourseRequest
        @return: CreateRemoteClassCourseResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateRemoteClassCourseHeaders()
        return await self.create_remote_class_course_with_options_async(request, headers, runtime)

    def create_section_config_with_options(
        self,
        request: dingtalkedu__1__0_models.CreateSectionConfigRequest,
        headers: dingtalkedu__1__0_models.CreateSectionConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateSectionConfigResponse:
        """
        @summary 按学期创建课表模板
        
        @param request: CreateSectionConfigRequest
        @param headers: CreateSectionConfigHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateSectionConfigResponse
        """
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
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateSectionConfig',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/sectionConfigs',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateSectionConfigResponse(),
            self.execute(params, req, runtime)
        )

    async def create_section_config_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CreateSectionConfigRequest,
        headers: dingtalkedu__1__0_models.CreateSectionConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateSectionConfigResponse:
        """
        @summary 按学期创建课表模板
        
        @param request: CreateSectionConfigRequest
        @param headers: CreateSectionConfigHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateSectionConfigResponse
        """
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
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateSectionConfig',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/sectionConfigs',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateSectionConfigResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_section_config(
        self,
        request: dingtalkedu__1__0_models.CreateSectionConfigRequest,
    ) -> dingtalkedu__1__0_models.CreateSectionConfigResponse:
        """
        @summary 按学期创建课表模板
        
        @param request: CreateSectionConfigRequest
        @return: CreateSectionConfigResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateSectionConfigHeaders()
        return self.create_section_config_with_options(request, headers, runtime)

    async def create_section_config_async(
        self,
        request: dingtalkedu__1__0_models.CreateSectionConfigRequest,
    ) -> dingtalkedu__1__0_models.CreateSectionConfigResponse:
        """
        @summary 按学期创建课表模板
        
        @param request: CreateSectionConfigRequest
        @return: CreateSectionConfigResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateSectionConfigHeaders()
        return await self.create_section_config_with_options_async(request, headers, runtime)

    def create_sns_app_order_with_options(
        self,
        request: dingtalkedu__1__0_models.CreateSnsAppOrderRequest,
        headers: dingtalkedu__1__0_models.CreateSnsAppOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateSnsAppOrderResponse:
        """
        @summary 个人应用创建APP订单
        
        @param request: CreateSnsAppOrderRequest
        @param headers: CreateSnsAppOrderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateSnsAppOrderResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.actual_amount):
            body['actualAmount'] = request.actual_amount
        if not UtilClient.is_unset(request.alipay_app_id):
            body['alipayAppId'] = request.alipay_app_id
        if not UtilClient.is_unset(request.biz_code):
            body['bizCode'] = request.biz_code
        if not UtilClient.is_unset(request.detail_list):
            body['detailList'] = request.detail_list
        if not UtilClient.is_unset(request.label_amount):
            body['labelAmount'] = request.label_amount
        if not UtilClient.is_unset(request.merchant_id):
            body['merchantId'] = request.merchant_id
        if not UtilClient.is_unset(request.merchant_order_no):
            body['merchantOrderNo'] = request.merchant_order_no
        if not UtilClient.is_unset(request.signature):
            body['signature'] = request.signature
        if not UtilClient.is_unset(request.subject):
            body['subject'] = request.subject
        if not UtilClient.is_unset(request.timestamp):
            body['timestamp'] = request.timestamp
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
            action='CreateSnsAppOrder',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/snsAppOrders',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateSnsAppOrderResponse(),
            self.execute(params, req, runtime)
        )

    async def create_sns_app_order_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CreateSnsAppOrderRequest,
        headers: dingtalkedu__1__0_models.CreateSnsAppOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateSnsAppOrderResponse:
        """
        @summary 个人应用创建APP订单
        
        @param request: CreateSnsAppOrderRequest
        @param headers: CreateSnsAppOrderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateSnsAppOrderResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.actual_amount):
            body['actualAmount'] = request.actual_amount
        if not UtilClient.is_unset(request.alipay_app_id):
            body['alipayAppId'] = request.alipay_app_id
        if not UtilClient.is_unset(request.biz_code):
            body['bizCode'] = request.biz_code
        if not UtilClient.is_unset(request.detail_list):
            body['detailList'] = request.detail_list
        if not UtilClient.is_unset(request.label_amount):
            body['labelAmount'] = request.label_amount
        if not UtilClient.is_unset(request.merchant_id):
            body['merchantId'] = request.merchant_id
        if not UtilClient.is_unset(request.merchant_order_no):
            body['merchantOrderNo'] = request.merchant_order_no
        if not UtilClient.is_unset(request.signature):
            body['signature'] = request.signature
        if not UtilClient.is_unset(request.subject):
            body['subject'] = request.subject
        if not UtilClient.is_unset(request.timestamp):
            body['timestamp'] = request.timestamp
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
            action='CreateSnsAppOrder',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/snsAppOrders',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateSnsAppOrderResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_sns_app_order(
        self,
        request: dingtalkedu__1__0_models.CreateSnsAppOrderRequest,
    ) -> dingtalkedu__1__0_models.CreateSnsAppOrderResponse:
        """
        @summary 个人应用创建APP订单
        
        @param request: CreateSnsAppOrderRequest
        @return: CreateSnsAppOrderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateSnsAppOrderHeaders()
        return self.create_sns_app_order_with_options(request, headers, runtime)

    async def create_sns_app_order_async(
        self,
        request: dingtalkedu__1__0_models.CreateSnsAppOrderRequest,
    ) -> dingtalkedu__1__0_models.CreateSnsAppOrderResponse:
        """
        @summary 个人应用创建APP订单
        
        @param request: CreateSnsAppOrderRequest
        @return: CreateSnsAppOrderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateSnsAppOrderHeaders()
        return await self.create_sns_app_order_with_options_async(request, headers, runtime)

    def create_sts_token_with_options(
        self,
        request: dingtalkedu__1__0_models.CreateStsTokenRequest,
        headers: dingtalkedu__1__0_models.CreateStsTokenHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateStsTokenResponse:
        """
        @summary 创建ststoken
        
        @param request: CreateStsTokenRequest
        @param headers: CreateStsTokenHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateStsTokenResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.device_sn):
            body['deviceSn'] = request.device_sn
        if not UtilClient.is_unset(request.sts_type):
            body['stsType'] = request.sts_type
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
            action='CreateStsToken',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/vpaas/ststoken',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateStsTokenResponse(),
            self.execute(params, req, runtime)
        )

    async def create_sts_token_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CreateStsTokenRequest,
        headers: dingtalkedu__1__0_models.CreateStsTokenHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateStsTokenResponse:
        """
        @summary 创建ststoken
        
        @param request: CreateStsTokenRequest
        @param headers: CreateStsTokenHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateStsTokenResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.device_sn):
            body['deviceSn'] = request.device_sn
        if not UtilClient.is_unset(request.sts_type):
            body['stsType'] = request.sts_type
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
            action='CreateStsToken',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/vpaas/ststoken',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateStsTokenResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_sts_token(
        self,
        request: dingtalkedu__1__0_models.CreateStsTokenRequest,
    ) -> dingtalkedu__1__0_models.CreateStsTokenResponse:
        """
        @summary 创建ststoken
        
        @param request: CreateStsTokenRequest
        @return: CreateStsTokenResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateStsTokenHeaders()
        return self.create_sts_token_with_options(request, headers, runtime)

    async def create_sts_token_async(
        self,
        request: dingtalkedu__1__0_models.CreateStsTokenRequest,
    ) -> dingtalkedu__1__0_models.CreateStsTokenResponse:
        """
        @summary 创建ststoken
        
        @param request: CreateStsTokenRequest
        @return: CreateStsTokenResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateStsTokenHeaders()
        return await self.create_sts_token_with_options_async(request, headers, runtime)

    def create_student_class_with_options(
        self,
        request: dingtalkedu__1__0_models.CreateStudentClassRequest,
        headers: dingtalkedu__1__0_models.CreateStudentClassHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateStudentClassResponse:
        """
        @summary 创建学生班级
        
        @param request: CreateStudentClassRequest
        @param headers: CreateStudentClassHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateStudentClassResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.attributes):
            body['attributes'] = request.attributes
        if not UtilClient.is_unset(request.class_id):
            body['classId'] = request.class_id
        if not UtilClient.is_unset(request.class_name):
            body['className'] = request.class_name
        if not UtilClient.is_unset(request.class_type):
            body['classType'] = request.class_type
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.student_name):
            body['studentName'] = request.student_name
        if not UtilClient.is_unset(request.student_user_id):
            body['studentUserId'] = request.student_user_id
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
            action='CreateStudentClass',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/kits/students/classes',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateStudentClassResponse(),
            self.execute(params, req, runtime)
        )

    async def create_student_class_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CreateStudentClassRequest,
        headers: dingtalkedu__1__0_models.CreateStudentClassHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateStudentClassResponse:
        """
        @summary 创建学生班级
        
        @param request: CreateStudentClassRequest
        @param headers: CreateStudentClassHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateStudentClassResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.attributes):
            body['attributes'] = request.attributes
        if not UtilClient.is_unset(request.class_id):
            body['classId'] = request.class_id
        if not UtilClient.is_unset(request.class_name):
            body['className'] = request.class_name
        if not UtilClient.is_unset(request.class_type):
            body['classType'] = request.class_type
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.student_name):
            body['studentName'] = request.student_name
        if not UtilClient.is_unset(request.student_user_id):
            body['studentUserId'] = request.student_user_id
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
            action='CreateStudentClass',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/kits/students/classes',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateStudentClassResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_student_class(
        self,
        request: dingtalkedu__1__0_models.CreateStudentClassRequest,
    ) -> dingtalkedu__1__0_models.CreateStudentClassResponse:
        """
        @summary 创建学生班级
        
        @param request: CreateStudentClassRequest
        @return: CreateStudentClassResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateStudentClassHeaders()
        return self.create_student_class_with_options(request, headers, runtime)

    async def create_student_class_async(
        self,
        request: dingtalkedu__1__0_models.CreateStudentClassRequest,
    ) -> dingtalkedu__1__0_models.CreateStudentClassResponse:
        """
        @summary 创建学生班级
        
        @param request: CreateStudentClassRequest
        @return: CreateStudentClassResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateStudentClassHeaders()
        return await self.create_student_class_with_options_async(request, headers, runtime)

    def create_teacher_course_with_options(
        self,
        request: dingtalkedu__1__0_models.CreateTeacherCourseRequest,
        headers: dingtalkedu__1__0_models.CreateTeacherCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateTeacherCourseResponse:
        """
        @summary 创建老师课程
        
        @param request: CreateTeacherCourseRequest
        @param headers: CreateTeacherCourseHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateTeacherCourseResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.attributes):
            body['attributes'] = request.attributes
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.isv_course_id):
            body['isvCourseId'] = request.isv_course_id
        if not UtilClient.is_unset(request.teacher_name):
            body['teacherName'] = request.teacher_name
        if not UtilClient.is_unset(request.teacher_user_id):
            body['teacherUserId'] = request.teacher_user_id
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
            action='CreateTeacherCourse',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/kits/teachers/courses',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateTeacherCourseResponse(),
            self.execute(params, req, runtime)
        )

    async def create_teacher_course_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CreateTeacherCourseRequest,
        headers: dingtalkedu__1__0_models.CreateTeacherCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateTeacherCourseResponse:
        """
        @summary 创建老师课程
        
        @param request: CreateTeacherCourseRequest
        @param headers: CreateTeacherCourseHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateTeacherCourseResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.attributes):
            body['attributes'] = request.attributes
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.isv_course_id):
            body['isvCourseId'] = request.isv_course_id
        if not UtilClient.is_unset(request.teacher_name):
            body['teacherName'] = request.teacher_name
        if not UtilClient.is_unset(request.teacher_user_id):
            body['teacherUserId'] = request.teacher_user_id
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
            action='CreateTeacherCourse',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/kits/teachers/courses',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateTeacherCourseResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_teacher_course(
        self,
        request: dingtalkedu__1__0_models.CreateTeacherCourseRequest,
    ) -> dingtalkedu__1__0_models.CreateTeacherCourseResponse:
        """
        @summary 创建老师课程
        
        @param request: CreateTeacherCourseRequest
        @return: CreateTeacherCourseResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateTeacherCourseHeaders()
        return self.create_teacher_course_with_options(request, headers, runtime)

    async def create_teacher_course_async(
        self,
        request: dingtalkedu__1__0_models.CreateTeacherCourseRequest,
    ) -> dingtalkedu__1__0_models.CreateTeacherCourseResponse:
        """
        @summary 创建老师课程
        
        @param request: CreateTeacherCourseRequest
        @return: CreateTeacherCourseResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateTeacherCourseHeaders()
        return await self.create_teacher_course_with_options_async(request, headers, runtime)

    def create_timer_card_with_options(
        self,
        request: dingtalkedu__1__0_models.CreateTimerCardRequest,
        headers: dingtalkedu__1__0_models.CreateTimerCardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateTimerCardResponse:
        """
        @summary 套件-创建定时卡片
        
        @param request: CreateTimerCardRequest
        @param headers: CreateTimerCardHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateTimerCardResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action_time):
            body['actionTime'] = request.action_time
        if not UtilClient.is_unset(request.biz_data):
            body['bizData'] = request.biz_data
        if not UtilClient.is_unset(request.biz_type):
            body['bizType'] = request.biz_type
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.identifier):
            body['identifier'] = request.identifier
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.memo):
            body['memo'] = request.memo
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
            action='CreateTimerCard',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/kits/timerCards',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateTimerCardResponse(),
            self.execute(params, req, runtime)
        )

    async def create_timer_card_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CreateTimerCardRequest,
        headers: dingtalkedu__1__0_models.CreateTimerCardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateTimerCardResponse:
        """
        @summary 套件-创建定时卡片
        
        @param request: CreateTimerCardRequest
        @param headers: CreateTimerCardHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateTimerCardResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action_time):
            body['actionTime'] = request.action_time
        if not UtilClient.is_unset(request.biz_data):
            body['bizData'] = request.biz_data
        if not UtilClient.is_unset(request.biz_type):
            body['bizType'] = request.biz_type
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.identifier):
            body['identifier'] = request.identifier
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.memo):
            body['memo'] = request.memo
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
            action='CreateTimerCard',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/kits/timerCards',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateTimerCardResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_timer_card(
        self,
        request: dingtalkedu__1__0_models.CreateTimerCardRequest,
    ) -> dingtalkedu__1__0_models.CreateTimerCardResponse:
        """
        @summary 套件-创建定时卡片
        
        @param request: CreateTimerCardRequest
        @return: CreateTimerCardResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateTimerCardHeaders()
        return self.create_timer_card_with_options(request, headers, runtime)

    async def create_timer_card_async(
        self,
        request: dingtalkedu__1__0_models.CreateTimerCardRequest,
    ) -> dingtalkedu__1__0_models.CreateTimerCardResponse:
        """
        @summary 套件-创建定时卡片
        
        @param request: CreateTimerCardRequest
        @return: CreateTimerCardResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateTimerCardHeaders()
        return await self.create_timer_card_with_options_async(request, headers, runtime)

    def create_token_with_options(
        self,
        request: dingtalkedu__1__0_models.CreateTokenRequest,
        headers: dingtalkedu__1__0_models.CreateTokenHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateTokenResponse:
        """
        @summary 创建授权token
        
        @param request: CreateTokenRequest
        @param headers: CreateTokenHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateTokenResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
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
            action='CreateToken',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/tokens',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateTokenResponse(),
            self.execute(params, req, runtime)
        )

    async def create_token_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CreateTokenRequest,
        headers: dingtalkedu__1__0_models.CreateTokenHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateTokenResponse:
        """
        @summary 创建授权token
        
        @param request: CreateTokenRequest
        @param headers: CreateTokenHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateTokenResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
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
            action='CreateToken',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/tokens',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateTokenResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_token(
        self,
        request: dingtalkedu__1__0_models.CreateTokenRequest,
    ) -> dingtalkedu__1__0_models.CreateTokenResponse:
        """
        @summary 创建授权token
        
        @param request: CreateTokenRequest
        @return: CreateTokenResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateTokenHeaders()
        return self.create_token_with_options(request, headers, runtime)

    async def create_token_async(
        self,
        request: dingtalkedu__1__0_models.CreateTokenRequest,
    ) -> dingtalkedu__1__0_models.CreateTokenResponse:
        """
        @summary 创建授权token
        
        @param request: CreateTokenRequest
        @return: CreateTokenResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateTokenHeaders()
        return await self.create_token_with_options_async(request, headers, runtime)

    def create_transfer_record_with_options(
        self,
        request: dingtalkedu__1__0_models.CreateTransferRecordRequest,
        headers: dingtalkedu__1__0_models.CreateTransferRecordHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateTransferRecordResponse:
        """
        @summary 创建调代课记录
        
        @param request: CreateTransferRecordRequest
        @param headers: CreateTransferRecordHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateTransferRecordResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.attributes):
            body['attributes'] = request.attributes
        if not UtilClient.is_unset(request.class_id):
            body['classId'] = request.class_id
        if not UtilClient.is_unset(request.class_name):
            body['className'] = request.class_name
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.isv_record_id):
            body['isvRecordId'] = request.isv_record_id
        if not UtilClient.is_unset(request.src_course_code):
            body['srcCourseCode'] = request.src_course_code
        if not UtilClient.is_unset(request.src_course_date):
            body['srcCourseDate'] = request.src_course_date
        if not UtilClient.is_unset(request.src_course_name):
            body['srcCourseName'] = request.src_course_name
        if not UtilClient.is_unset(request.src_isv_course_id):
            body['srcIsvCourseId'] = request.src_isv_course_id
        if not UtilClient.is_unset(request.src_timeslot_name):
            body['srcTimeslotName'] = request.src_timeslot_name
        if not UtilClient.is_unset(request.src_timeslot_num):
            body['srcTimeslotNum'] = request.src_timeslot_num
        if not UtilClient.is_unset(request.tar_course_code):
            body['tarCourseCode'] = request.tar_course_code
        if not UtilClient.is_unset(request.tar_course_date):
            body['tarCourseDate'] = request.tar_course_date
        if not UtilClient.is_unset(request.tar_course_name):
            body['tarCourseName'] = request.tar_course_name
        if not UtilClient.is_unset(request.tar_isv_course_id):
            body['tarIsvCourseId'] = request.tar_isv_course_id
        if not UtilClient.is_unset(request.tar_timeslot_name):
            body['tarTimeslotName'] = request.tar_timeslot_name
        if not UtilClient.is_unset(request.tar_timeslot_num):
            body['tarTimeslotNum'] = request.tar_timeslot_num
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
            action='CreateTransferRecord',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/kits/transferRecords',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateTransferRecordResponse(),
            self.execute(params, req, runtime)
        )

    async def create_transfer_record_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CreateTransferRecordRequest,
        headers: dingtalkedu__1__0_models.CreateTransferRecordHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateTransferRecordResponse:
        """
        @summary 创建调代课记录
        
        @param request: CreateTransferRecordRequest
        @param headers: CreateTransferRecordHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateTransferRecordResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.attributes):
            body['attributes'] = request.attributes
        if not UtilClient.is_unset(request.class_id):
            body['classId'] = request.class_id
        if not UtilClient.is_unset(request.class_name):
            body['className'] = request.class_name
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.isv_record_id):
            body['isvRecordId'] = request.isv_record_id
        if not UtilClient.is_unset(request.src_course_code):
            body['srcCourseCode'] = request.src_course_code
        if not UtilClient.is_unset(request.src_course_date):
            body['srcCourseDate'] = request.src_course_date
        if not UtilClient.is_unset(request.src_course_name):
            body['srcCourseName'] = request.src_course_name
        if not UtilClient.is_unset(request.src_isv_course_id):
            body['srcIsvCourseId'] = request.src_isv_course_id
        if not UtilClient.is_unset(request.src_timeslot_name):
            body['srcTimeslotName'] = request.src_timeslot_name
        if not UtilClient.is_unset(request.src_timeslot_num):
            body['srcTimeslotNum'] = request.src_timeslot_num
        if not UtilClient.is_unset(request.tar_course_code):
            body['tarCourseCode'] = request.tar_course_code
        if not UtilClient.is_unset(request.tar_course_date):
            body['tarCourseDate'] = request.tar_course_date
        if not UtilClient.is_unset(request.tar_course_name):
            body['tarCourseName'] = request.tar_course_name
        if not UtilClient.is_unset(request.tar_isv_course_id):
            body['tarIsvCourseId'] = request.tar_isv_course_id
        if not UtilClient.is_unset(request.tar_timeslot_name):
            body['tarTimeslotName'] = request.tar_timeslot_name
        if not UtilClient.is_unset(request.tar_timeslot_num):
            body['tarTimeslotNum'] = request.tar_timeslot_num
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
            action='CreateTransferRecord',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/kits/transferRecords',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateTransferRecordResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_transfer_record(
        self,
        request: dingtalkedu__1__0_models.CreateTransferRecordRequest,
    ) -> dingtalkedu__1__0_models.CreateTransferRecordResponse:
        """
        @summary 创建调代课记录
        
        @param request: CreateTransferRecordRequest
        @return: CreateTransferRecordResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateTransferRecordHeaders()
        return self.create_transfer_record_with_options(request, headers, runtime)

    async def create_transfer_record_async(
        self,
        request: dingtalkedu__1__0_models.CreateTransferRecordRequest,
    ) -> dingtalkedu__1__0_models.CreateTransferRecordResponse:
        """
        @summary 创建调代课记录
        
        @param request: CreateTransferRecordRequest
        @return: CreateTransferRecordResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateTransferRecordHeaders()
        return await self.create_transfer_record_with_options_async(request, headers, runtime)

    def create_university_course_group_with_options(
        self,
        request: dingtalkedu__1__0_models.CreateUniversityCourseGroupRequest,
        headers: dingtalkedu__1__0_models.CreateUniversityCourseGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateUniversityCourseGroupResponse:
        """
        @summary 大学创建课程组
        
        @param request: CreateUniversityCourseGroupRequest
        @param headers: CreateUniversityCourseGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateUniversityCourseGroupResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.course_group_introduce):
            body['courseGroupIntroduce'] = request.course_group_introduce
        if not UtilClient.is_unset(request.course_group_name):
            body['courseGroupName'] = request.course_group_name
        if not UtilClient.is_unset(request.courser_group_item_models):
            body['courserGroupItemModels'] = request.courser_group_item_models
        if not UtilClient.is_unset(request.ext):
            body['ext'] = request.ext
        if not UtilClient.is_unset(request.isv_course_group_code):
            body['isvCourseGroupCode'] = request.isv_course_group_code
        if not UtilClient.is_unset(request.period_code):
            body['periodCode'] = request.period_code
        if not UtilClient.is_unset(request.school_year):
            body['schoolYear'] = request.school_year
        if not UtilClient.is_unset(request.semester):
            body['semester'] = request.semester
        if not UtilClient.is_unset(request.subject_name):
            body['subjectName'] = request.subject_name
        if not UtilClient.is_unset(request.teacher_infos):
            body['teacherInfos'] = request.teacher_infos
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
            action='CreateUniversityCourseGroup',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/courseGroups',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateUniversityCourseGroupResponse(),
            self.execute(params, req, runtime)
        )

    async def create_university_course_group_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CreateUniversityCourseGroupRequest,
        headers: dingtalkedu__1__0_models.CreateUniversityCourseGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateUniversityCourseGroupResponse:
        """
        @summary 大学创建课程组
        
        @param request: CreateUniversityCourseGroupRequest
        @param headers: CreateUniversityCourseGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateUniversityCourseGroupResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.course_group_introduce):
            body['courseGroupIntroduce'] = request.course_group_introduce
        if not UtilClient.is_unset(request.course_group_name):
            body['courseGroupName'] = request.course_group_name
        if not UtilClient.is_unset(request.courser_group_item_models):
            body['courserGroupItemModels'] = request.courser_group_item_models
        if not UtilClient.is_unset(request.ext):
            body['ext'] = request.ext
        if not UtilClient.is_unset(request.isv_course_group_code):
            body['isvCourseGroupCode'] = request.isv_course_group_code
        if not UtilClient.is_unset(request.period_code):
            body['periodCode'] = request.period_code
        if not UtilClient.is_unset(request.school_year):
            body['schoolYear'] = request.school_year
        if not UtilClient.is_unset(request.semester):
            body['semester'] = request.semester
        if not UtilClient.is_unset(request.subject_name):
            body['subjectName'] = request.subject_name
        if not UtilClient.is_unset(request.teacher_infos):
            body['teacherInfos'] = request.teacher_infos
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
            action='CreateUniversityCourseGroup',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/courseGroups',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateUniversityCourseGroupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_university_course_group(
        self,
        request: dingtalkedu__1__0_models.CreateUniversityCourseGroupRequest,
    ) -> dingtalkedu__1__0_models.CreateUniversityCourseGroupResponse:
        """
        @summary 大学创建课程组
        
        @param request: CreateUniversityCourseGroupRequest
        @return: CreateUniversityCourseGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateUniversityCourseGroupHeaders()
        return self.create_university_course_group_with_options(request, headers, runtime)

    async def create_university_course_group_async(
        self,
        request: dingtalkedu__1__0_models.CreateUniversityCourseGroupRequest,
    ) -> dingtalkedu__1__0_models.CreateUniversityCourseGroupResponse:
        """
        @summary 大学创建课程组
        
        @param request: CreateUniversityCourseGroupRequest
        @return: CreateUniversityCourseGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateUniversityCourseGroupHeaders()
        return await self.create_university_course_group_with_options_async(request, headers, runtime)

    def create_university_student_with_options(
        self,
        request: dingtalkedu__1__0_models.CreateUniversityStudentRequest,
        headers: dingtalkedu__1__0_models.CreateUniversityStudentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateUniversityStudentResponse:
        """
        @summary 大学增加学生
        
        @param request: CreateUniversityStudentRequest
        @param headers: CreateUniversityStudentHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateUniversityStudentResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.class_id):
            body['classId'] = request.class_id
        if not UtilClient.is_unset(request.gender):
            body['gender'] = request.gender
        if not UtilClient.is_unset(request.identity_number):
            body['identityNumber'] = request.identity_number
        if not UtilClient.is_unset(request.mobile):
            body['mobile'] = request.mobile
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.student_number):
            body['studentNumber'] = request.student_number
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
            action='CreateUniversityStudent',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/students',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateUniversityStudentResponse(),
            self.execute(params, req, runtime)
        )

    async def create_university_student_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CreateUniversityStudentRequest,
        headers: dingtalkedu__1__0_models.CreateUniversityStudentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateUniversityStudentResponse:
        """
        @summary 大学增加学生
        
        @param request: CreateUniversityStudentRequest
        @param headers: CreateUniversityStudentHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateUniversityStudentResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.class_id):
            body['classId'] = request.class_id
        if not UtilClient.is_unset(request.gender):
            body['gender'] = request.gender
        if not UtilClient.is_unset(request.identity_number):
            body['identityNumber'] = request.identity_number
        if not UtilClient.is_unset(request.mobile):
            body['mobile'] = request.mobile
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.student_number):
            body['studentNumber'] = request.student_number
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
            action='CreateUniversityStudent',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/students',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateUniversityStudentResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_university_student(
        self,
        request: dingtalkedu__1__0_models.CreateUniversityStudentRequest,
    ) -> dingtalkedu__1__0_models.CreateUniversityStudentResponse:
        """
        @summary 大学增加学生
        
        @param request: CreateUniversityStudentRequest
        @return: CreateUniversityStudentResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateUniversityStudentHeaders()
        return self.create_university_student_with_options(request, headers, runtime)

    async def create_university_student_async(
        self,
        request: dingtalkedu__1__0_models.CreateUniversityStudentRequest,
    ) -> dingtalkedu__1__0_models.CreateUniversityStudentResponse:
        """
        @summary 大学增加学生
        
        @param request: CreateUniversityStudentRequest
        @return: CreateUniversityStudentResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateUniversityStudentHeaders()
        return await self.create_university_student_with_options_async(request, headers, runtime)

    def create_university_teacher_with_options(
        self,
        request: dingtalkedu__1__0_models.CreateUniversityTeacherRequest,
        headers: dingtalkedu__1__0_models.CreateUniversityTeacherHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateUniversityTeacherResponse:
        """
        @summary 大学添加老师
        
        @param request: CreateUniversityTeacherRequest
        @param headers: CreateUniversityTeacherHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateUniversityTeacherResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.class_id):
            body['classId'] = request.class_id
        if not UtilClient.is_unset(request.op_user_id):
            body['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.role):
            body['role'] = request.role
        if not UtilClient.is_unset(request.teacher_user_id):
            body['teacherUserId'] = request.teacher_user_id
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
            action='CreateUniversityTeacher',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/teachers',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateUniversityTeacherResponse(),
            self.execute(params, req, runtime)
        )

    async def create_university_teacher_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CreateUniversityTeacherRequest,
        headers: dingtalkedu__1__0_models.CreateUniversityTeacherHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateUniversityTeacherResponse:
        """
        @summary 大学添加老师
        
        @param request: CreateUniversityTeacherRequest
        @param headers: CreateUniversityTeacherHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateUniversityTeacherResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.class_id):
            body['classId'] = request.class_id
        if not UtilClient.is_unset(request.op_user_id):
            body['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.role):
            body['role'] = request.role
        if not UtilClient.is_unset(request.teacher_user_id):
            body['teacherUserId'] = request.teacher_user_id
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
            action='CreateUniversityTeacher',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/teachers',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateUniversityTeacherResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_university_teacher(
        self,
        request: dingtalkedu__1__0_models.CreateUniversityTeacherRequest,
    ) -> dingtalkedu__1__0_models.CreateUniversityTeacherResponse:
        """
        @summary 大学添加老师
        
        @param request: CreateUniversityTeacherRequest
        @return: CreateUniversityTeacherResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateUniversityTeacherHeaders()
        return self.create_university_teacher_with_options(request, headers, runtime)

    async def create_university_teacher_async(
        self,
        request: dingtalkedu__1__0_models.CreateUniversityTeacherRequest,
    ) -> dingtalkedu__1__0_models.CreateUniversityTeacherResponse:
        """
        @summary 大学添加老师
        
        @param request: CreateUniversityTeacherRequest
        @return: CreateUniversityTeacherResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateUniversityTeacherHeaders()
        return await self.create_university_teacher_with_options_async(request, headers, runtime)

    def deactivate_device_with_options(
        self,
        request: dingtalkedu__1__0_models.DeactivateDeviceRequest,
        headers: dingtalkedu__1__0_models.DeactivateDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeactivateDeviceResponse:
        """
        @summary 视讯paas机具取消激活
        
        @param request: DeactivateDeviceRequest
        @param headers: DeactivateDeviceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeactivateDeviceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.model):
            body['model'] = request.model
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
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
            action='DeactivateDevice',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/vpaas/devices/deactivate',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeactivateDeviceResponse(),
            self.execute(params, req, runtime)
        )

    async def deactivate_device_with_options_async(
        self,
        request: dingtalkedu__1__0_models.DeactivateDeviceRequest,
        headers: dingtalkedu__1__0_models.DeactivateDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeactivateDeviceResponse:
        """
        @summary 视讯paas机具取消激活
        
        @param request: DeactivateDeviceRequest
        @param headers: DeactivateDeviceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeactivateDeviceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.model):
            body['model'] = request.model
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
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
            action='DeactivateDevice',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/vpaas/devices/deactivate',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeactivateDeviceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def deactivate_device(
        self,
        request: dingtalkedu__1__0_models.DeactivateDeviceRequest,
    ) -> dingtalkedu__1__0_models.DeactivateDeviceResponse:
        """
        @summary 视讯paas机具取消激活
        
        @param request: DeactivateDeviceRequest
        @return: DeactivateDeviceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeactivateDeviceHeaders()
        return self.deactivate_device_with_options(request, headers, runtime)

    async def deactivate_device_async(
        self,
        request: dingtalkedu__1__0_models.DeactivateDeviceRequest,
    ) -> dingtalkedu__1__0_models.DeactivateDeviceResponse:
        """
        @summary 视讯paas机具取消激活
        
        @param request: DeactivateDeviceRequest
        @return: DeactivateDeviceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeactivateDeviceHeaders()
        return await self.deactivate_device_with_options_async(request, headers, runtime)

    def deduct_point_with_options(
        self,
        request: dingtalkedu__1__0_models.DeductPointRequest,
        headers: dingtalkedu__1__0_models.DeductPointHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeductPointResponse:
        """
        @summary 扣减教育积分
        
        @param request: DeductPointRequest
        @param headers: DeductPointHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeductPointResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.deduct_desc):
            body['deductDesc'] = request.deduct_desc
        if not UtilClient.is_unset(request.deduct_detail_url):
            body['deductDetailUrl'] = request.deduct_detail_url
        if not UtilClient.is_unset(request.deduct_num):
            body['deductNum'] = request.deduct_num
        if not UtilClient.is_unset(request.point_type):
            body['pointType'] = request.point_type
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
            action='DeductPoint',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/points/deduct',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeductPointResponse(),
            self.execute(params, req, runtime)
        )

    async def deduct_point_with_options_async(
        self,
        request: dingtalkedu__1__0_models.DeductPointRequest,
        headers: dingtalkedu__1__0_models.DeductPointHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeductPointResponse:
        """
        @summary 扣减教育积分
        
        @param request: DeductPointRequest
        @param headers: DeductPointHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeductPointResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.deduct_desc):
            body['deductDesc'] = request.deduct_desc
        if not UtilClient.is_unset(request.deduct_detail_url):
            body['deductDetailUrl'] = request.deduct_detail_url
        if not UtilClient.is_unset(request.deduct_num):
            body['deductNum'] = request.deduct_num
        if not UtilClient.is_unset(request.point_type):
            body['pointType'] = request.point_type
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
            action='DeductPoint',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/points/deduct',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeductPointResponse(),
            await self.execute_async(params, req, runtime)
        )

    def deduct_point(
        self,
        request: dingtalkedu__1__0_models.DeductPointRequest,
    ) -> dingtalkedu__1__0_models.DeductPointResponse:
        """
        @summary 扣减教育积分
        
        @param request: DeductPointRequest
        @return: DeductPointResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeductPointHeaders()
        return self.deduct_point_with_options(request, headers, runtime)

    async def deduct_point_async(
        self,
        request: dingtalkedu__1__0_models.DeductPointRequest,
    ) -> dingtalkedu__1__0_models.DeductPointResponse:
        """
        @summary 扣减教育积分
        
        @param request: DeductPointRequest
        @return: DeductPointResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeductPointHeaders()
        return await self.deduct_point_with_options_async(request, headers, runtime)

    def delete_college_alumni_dept_with_options(
        self,
        request: dingtalkedu__1__0_models.DeleteCollegeAlumniDeptRequest,
        headers: dingtalkedu__1__0_models.DeleteCollegeAlumniDeptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteCollegeAlumniDeptResponse:
        """
        @summary 高校校友会删除当前部门
        
        @param request: DeleteCollegeAlumniDeptRequest
        @param headers: DeleteCollegeAlumniDeptHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteCollegeAlumniDeptResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
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
            action='DeleteCollegeAlumniDept',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/collegeAlumni/depts',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteCollegeAlumniDeptResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_college_alumni_dept_with_options_async(
        self,
        request: dingtalkedu__1__0_models.DeleteCollegeAlumniDeptRequest,
        headers: dingtalkedu__1__0_models.DeleteCollegeAlumniDeptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteCollegeAlumniDeptResponse:
        """
        @summary 高校校友会删除当前部门
        
        @param request: DeleteCollegeAlumniDeptRequest
        @param headers: DeleteCollegeAlumniDeptHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteCollegeAlumniDeptResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
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
            action='DeleteCollegeAlumniDept',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/collegeAlumni/depts',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteCollegeAlumniDeptResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_college_alumni_dept(
        self,
        request: dingtalkedu__1__0_models.DeleteCollegeAlumniDeptRequest,
    ) -> dingtalkedu__1__0_models.DeleteCollegeAlumniDeptResponse:
        """
        @summary 高校校友会删除当前部门
        
        @param request: DeleteCollegeAlumniDeptRequest
        @return: DeleteCollegeAlumniDeptResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteCollegeAlumniDeptHeaders()
        return self.delete_college_alumni_dept_with_options(request, headers, runtime)

    async def delete_college_alumni_dept_async(
        self,
        request: dingtalkedu__1__0_models.DeleteCollegeAlumniDeptRequest,
    ) -> dingtalkedu__1__0_models.DeleteCollegeAlumniDeptResponse:
        """
        @summary 高校校友会删除当前部门
        
        @param request: DeleteCollegeAlumniDeptRequest
        @return: DeleteCollegeAlumniDeptResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteCollegeAlumniDeptHeaders()
        return await self.delete_college_alumni_dept_with_options_async(request, headers, runtime)

    def delete_college_alumni_user_info_with_options(
        self,
        request: dingtalkedu__1__0_models.DeleteCollegeAlumniUserInfoRequest,
        headers: dingtalkedu__1__0_models.DeleteCollegeAlumniUserInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteCollegeAlumniUserInfoResponse:
        """
        @summary 高校校友会删除校友信息
        
        @param request: DeleteCollegeAlumniUserInfoRequest
        @param headers: DeleteCollegeAlumniUserInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteCollegeAlumniUserInfoResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dept_id):
            body['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        if not UtilClient.is_unset(request.user_ids):
            body['userIds'] = request.user_ids
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
            action='DeleteCollegeAlumniUserInfo',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/collegeAlumni/userInfos/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteCollegeAlumniUserInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_college_alumni_user_info_with_options_async(
        self,
        request: dingtalkedu__1__0_models.DeleteCollegeAlumniUserInfoRequest,
        headers: dingtalkedu__1__0_models.DeleteCollegeAlumniUserInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteCollegeAlumniUserInfoResponse:
        """
        @summary 高校校友会删除校友信息
        
        @param request: DeleteCollegeAlumniUserInfoRequest
        @param headers: DeleteCollegeAlumniUserInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteCollegeAlumniUserInfoResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dept_id):
            body['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        if not UtilClient.is_unset(request.user_ids):
            body['userIds'] = request.user_ids
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
            action='DeleteCollegeAlumniUserInfo',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/collegeAlumni/userInfos/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteCollegeAlumniUserInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_college_alumni_user_info(
        self,
        request: dingtalkedu__1__0_models.DeleteCollegeAlumniUserInfoRequest,
    ) -> dingtalkedu__1__0_models.DeleteCollegeAlumniUserInfoResponse:
        """
        @summary 高校校友会删除校友信息
        
        @param request: DeleteCollegeAlumniUserInfoRequest
        @return: DeleteCollegeAlumniUserInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteCollegeAlumniUserInfoHeaders()
        return self.delete_college_alumni_user_info_with_options(request, headers, runtime)

    async def delete_college_alumni_user_info_async(
        self,
        request: dingtalkedu__1__0_models.DeleteCollegeAlumniUserInfoRequest,
    ) -> dingtalkedu__1__0_models.DeleteCollegeAlumniUserInfoResponse:
        """
        @summary 高校校友会删除校友信息
        
        @param request: DeleteCollegeAlumniUserInfoRequest
        @return: DeleteCollegeAlumniUserInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteCollegeAlumniUserInfoHeaders()
        return await self.delete_college_alumni_user_info_with_options_async(request, headers, runtime)

    def delete_dept_with_options(
        self,
        dept_id: str,
        request: dingtalkedu__1__0_models.DeleteDeptRequest,
        headers: dingtalkedu__1__0_models.DeleteDeptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteDeptResponse:
        """
        @summary 删除家校部门
        
        @param request: DeleteDeptRequest
        @param headers: DeleteDeptHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteDeptResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
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
            action='DeleteDept',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/depts/{dept_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteDeptResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_dept_with_options_async(
        self,
        dept_id: str,
        request: dingtalkedu__1__0_models.DeleteDeptRequest,
        headers: dingtalkedu__1__0_models.DeleteDeptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteDeptResponse:
        """
        @summary 删除家校部门
        
        @param request: DeleteDeptRequest
        @param headers: DeleteDeptHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteDeptResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
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
            action='DeleteDept',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/depts/{dept_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteDeptResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_dept(
        self,
        dept_id: str,
        request: dingtalkedu__1__0_models.DeleteDeptRequest,
    ) -> dingtalkedu__1__0_models.DeleteDeptResponse:
        """
        @summary 删除家校部门
        
        @param request: DeleteDeptRequest
        @return: DeleteDeptResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteDeptHeaders()
        return self.delete_dept_with_options(dept_id, request, headers, runtime)

    async def delete_dept_async(
        self,
        dept_id: str,
        request: dingtalkedu__1__0_models.DeleteDeptRequest,
    ) -> dingtalkedu__1__0_models.DeleteDeptResponse:
        """
        @summary 删除家校部门
        
        @param request: DeleteDeptRequest
        @return: DeleteDeptResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteDeptHeaders()
        return await self.delete_dept_with_options_async(dept_id, request, headers, runtime)

    def delete_device_with_options(
        self,
        request: dingtalkedu__1__0_models.DeleteDeviceRequest,
        headers: dingtalkedu__1__0_models.DeleteDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteDeviceResponse:
        """
        @summary 视讯paas机具删除
        
        @param request: DeleteDeviceRequest
        @param headers: DeleteDeviceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteDeviceResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.sn):
            query['sn'] = request.sn
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
            action='DeleteDevice',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/vpaas/devices',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteDeviceResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_device_with_options_async(
        self,
        request: dingtalkedu__1__0_models.DeleteDeviceRequest,
        headers: dingtalkedu__1__0_models.DeleteDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteDeviceResponse:
        """
        @summary 视讯paas机具删除
        
        @param request: DeleteDeviceRequest
        @param headers: DeleteDeviceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteDeviceResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.sn):
            query['sn'] = request.sn
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
            action='DeleteDevice',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/vpaas/devices',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteDeviceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_device(
        self,
        request: dingtalkedu__1__0_models.DeleteDeviceRequest,
    ) -> dingtalkedu__1__0_models.DeleteDeviceResponse:
        """
        @summary 视讯paas机具删除
        
        @param request: DeleteDeviceRequest
        @return: DeleteDeviceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteDeviceHeaders()
        return self.delete_device_with_options(request, headers, runtime)

    async def delete_device_async(
        self,
        request: dingtalkedu__1__0_models.DeleteDeviceRequest,
    ) -> dingtalkedu__1__0_models.DeleteDeviceResponse:
        """
        @summary 视讯paas机具删除
        
        @param request: DeleteDeviceRequest
        @return: DeleteDeviceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteDeviceHeaders()
        return await self.delete_device_with_options_async(request, headers, runtime)

    def delete_device_org_with_options(
        self,
        request: dingtalkedu__1__0_models.DeleteDeviceOrgRequest,
        headers: dingtalkedu__1__0_models.DeleteDeviceOrgHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteDeviceOrgResponse:
        """
        @summary 删除设备上面的组织
        
        @param request: DeleteDeviceOrgRequest
        @param headers: DeleteDeviceOrgHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteDeviceOrgResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.auth_code):
            query['authCode'] = request.auth_code
        if not UtilClient.is_unset(request.device_code):
            query['deviceCode'] = request.device_code
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
            action='DeleteDeviceOrg',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/remoteClasses/deviceOrgs',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteDeviceOrgResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_device_org_with_options_async(
        self,
        request: dingtalkedu__1__0_models.DeleteDeviceOrgRequest,
        headers: dingtalkedu__1__0_models.DeleteDeviceOrgHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteDeviceOrgResponse:
        """
        @summary 删除设备上面的组织
        
        @param request: DeleteDeviceOrgRequest
        @param headers: DeleteDeviceOrgHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteDeviceOrgResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.auth_code):
            query['authCode'] = request.auth_code
        if not UtilClient.is_unset(request.device_code):
            query['deviceCode'] = request.device_code
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
            action='DeleteDeviceOrg',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/remoteClasses/deviceOrgs',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteDeviceOrgResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_device_org(
        self,
        request: dingtalkedu__1__0_models.DeleteDeviceOrgRequest,
    ) -> dingtalkedu__1__0_models.DeleteDeviceOrgResponse:
        """
        @summary 删除设备上面的组织
        
        @param request: DeleteDeviceOrgRequest
        @return: DeleteDeviceOrgResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteDeviceOrgHeaders()
        return self.delete_device_org_with_options(request, headers, runtime)

    async def delete_device_org_async(
        self,
        request: dingtalkedu__1__0_models.DeleteDeviceOrgRequest,
    ) -> dingtalkedu__1__0_models.DeleteDeviceOrgResponse:
        """
        @summary 删除设备上面的组织
        
        @param request: DeleteDeviceOrgRequest
        @return: DeleteDeviceOrgResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteDeviceOrgHeaders()
        return await self.delete_device_org_with_options_async(request, headers, runtime)

    def delete_guardian_with_options(
        self,
        class_id: str,
        user_id: str,
        request: dingtalkedu__1__0_models.DeleteGuardianRequest,
        headers: dingtalkedu__1__0_models.DeleteGuardianHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteGuardianResponse:
        """
        @summary 删除家长
        
        @param request: DeleteGuardianRequest
        @param headers: DeleteGuardianHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteGuardianResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
        if not UtilClient.is_unset(request.stu_id):
            query['stuId'] = request.stu_id
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
            action='DeleteGuardian',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/classes/{class_id}/guardians/{user_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteGuardianResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_guardian_with_options_async(
        self,
        class_id: str,
        user_id: str,
        request: dingtalkedu__1__0_models.DeleteGuardianRequest,
        headers: dingtalkedu__1__0_models.DeleteGuardianHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteGuardianResponse:
        """
        @summary 删除家长
        
        @param request: DeleteGuardianRequest
        @param headers: DeleteGuardianHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteGuardianResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
        if not UtilClient.is_unset(request.stu_id):
            query['stuId'] = request.stu_id
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
            action='DeleteGuardian',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/classes/{class_id}/guardians/{user_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteGuardianResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_guardian(
        self,
        class_id: str,
        user_id: str,
        request: dingtalkedu__1__0_models.DeleteGuardianRequest,
    ) -> dingtalkedu__1__0_models.DeleteGuardianResponse:
        """
        @summary 删除家长
        
        @param request: DeleteGuardianRequest
        @return: DeleteGuardianResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteGuardianHeaders()
        return self.delete_guardian_with_options(class_id, user_id, request, headers, runtime)

    async def delete_guardian_async(
        self,
        class_id: str,
        user_id: str,
        request: dingtalkedu__1__0_models.DeleteGuardianRequest,
    ) -> dingtalkedu__1__0_models.DeleteGuardianResponse:
        """
        @summary 删除家长
        
        @param request: DeleteGuardianRequest
        @return: DeleteGuardianResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteGuardianHeaders()
        return await self.delete_guardian_with_options_async(class_id, user_id, request, headers, runtime)

    def delete_org_relation_with_options(
        self,
        request: dingtalkedu__1__0_models.DeleteOrgRelationRequest,
        headers: dingtalkedu__1__0_models.DeleteOrgRelationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteOrgRelationResponse:
        """
        @summary 删除组织的关联关系
        
        @param request: DeleteOrgRelationRequest
        @param headers: DeleteOrgRelationHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteOrgRelationResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.auth_code):
            query['authCode'] = request.auth_code
        if not UtilClient.is_unset(request.target_corp_id):
            query['targetCorpId'] = request.target_corp_id
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
            action='DeleteOrgRelation',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/remoteClasses/orgRelations',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteOrgRelationResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_org_relation_with_options_async(
        self,
        request: dingtalkedu__1__0_models.DeleteOrgRelationRequest,
        headers: dingtalkedu__1__0_models.DeleteOrgRelationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteOrgRelationResponse:
        """
        @summary 删除组织的关联关系
        
        @param request: DeleteOrgRelationRequest
        @param headers: DeleteOrgRelationHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteOrgRelationResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.auth_code):
            query['authCode'] = request.auth_code
        if not UtilClient.is_unset(request.target_corp_id):
            query['targetCorpId'] = request.target_corp_id
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
            action='DeleteOrgRelation',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/remoteClasses/orgRelations',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteOrgRelationResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_org_relation(
        self,
        request: dingtalkedu__1__0_models.DeleteOrgRelationRequest,
    ) -> dingtalkedu__1__0_models.DeleteOrgRelationResponse:
        """
        @summary 删除组织的关联关系
        
        @param request: DeleteOrgRelationRequest
        @return: DeleteOrgRelationResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteOrgRelationHeaders()
        return self.delete_org_relation_with_options(request, headers, runtime)

    async def delete_org_relation_async(
        self,
        request: dingtalkedu__1__0_models.DeleteOrgRelationRequest,
    ) -> dingtalkedu__1__0_models.DeleteOrgRelationResponse:
        """
        @summary 删除组织的关联关系
        
        @param request: DeleteOrgRelationRequest
        @return: DeleteOrgRelationResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteOrgRelationHeaders()
        return await self.delete_org_relation_with_options_async(request, headers, runtime)

    def delete_physical_classroom_with_options(
        self,
        request: dingtalkedu__1__0_models.DeletePhysicalClassroomRequest,
        headers: dingtalkedu__1__0_models.DeletePhysicalClassroomHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeletePhysicalClassroomResponse:
        """
        @summary 删除物理教室信息
        
        @param request: DeletePhysicalClassroomRequest
        @param headers: DeletePhysicalClassroomHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeletePhysicalClassroomResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.classroom_id):
            query['classroomId'] = request.classroom_id
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
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
            action='DeletePhysicalClassroom',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/physicalClassrooms',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeletePhysicalClassroomResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_physical_classroom_with_options_async(
        self,
        request: dingtalkedu__1__0_models.DeletePhysicalClassroomRequest,
        headers: dingtalkedu__1__0_models.DeletePhysicalClassroomHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeletePhysicalClassroomResponse:
        """
        @summary 删除物理教室信息
        
        @param request: DeletePhysicalClassroomRequest
        @param headers: DeletePhysicalClassroomHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeletePhysicalClassroomResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.classroom_id):
            query['classroomId'] = request.classroom_id
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
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
            action='DeletePhysicalClassroom',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/physicalClassrooms',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeletePhysicalClassroomResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_physical_classroom(
        self,
        request: dingtalkedu__1__0_models.DeletePhysicalClassroomRequest,
    ) -> dingtalkedu__1__0_models.DeletePhysicalClassroomResponse:
        """
        @summary 删除物理教室信息
        
        @param request: DeletePhysicalClassroomRequest
        @return: DeletePhysicalClassroomResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeletePhysicalClassroomHeaders()
        return self.delete_physical_classroom_with_options(request, headers, runtime)

    async def delete_physical_classroom_async(
        self,
        request: dingtalkedu__1__0_models.DeletePhysicalClassroomRequest,
    ) -> dingtalkedu__1__0_models.DeletePhysicalClassroomResponse:
        """
        @summary 删除物理教室信息
        
        @param request: DeletePhysicalClassroomRequest
        @return: DeletePhysicalClassroomResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeletePhysicalClassroomHeaders()
        return await self.delete_physical_classroom_with_options_async(request, headers, runtime)

    def delete_remote_class_course_with_options(
        self,
        course_code: str,
        request: dingtalkedu__1__0_models.DeleteRemoteClassCourseRequest,
        headers: dingtalkedu__1__0_models.DeleteRemoteClassCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteRemoteClassCourseResponse:
        """
        @summary 删除专递课堂课程
        
        @param request: DeleteRemoteClassCourseRequest
        @param headers: DeleteRemoteClassCourseHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteRemoteClassCourseResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.auth_code):
            query['authCode'] = request.auth_code
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
            action='DeleteRemoteClassCourse',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/remoteClasses/courses/{course_code}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteRemoteClassCourseResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_remote_class_course_with_options_async(
        self,
        course_code: str,
        request: dingtalkedu__1__0_models.DeleteRemoteClassCourseRequest,
        headers: dingtalkedu__1__0_models.DeleteRemoteClassCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteRemoteClassCourseResponse:
        """
        @summary 删除专递课堂课程
        
        @param request: DeleteRemoteClassCourseRequest
        @param headers: DeleteRemoteClassCourseHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteRemoteClassCourseResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.auth_code):
            query['authCode'] = request.auth_code
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
            action='DeleteRemoteClassCourse',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/remoteClasses/courses/{course_code}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteRemoteClassCourseResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_remote_class_course(
        self,
        course_code: str,
        request: dingtalkedu__1__0_models.DeleteRemoteClassCourseRequest,
    ) -> dingtalkedu__1__0_models.DeleteRemoteClassCourseResponse:
        """
        @summary 删除专递课堂课程
        
        @param request: DeleteRemoteClassCourseRequest
        @return: DeleteRemoteClassCourseResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteRemoteClassCourseHeaders()
        return self.delete_remote_class_course_with_options(course_code, request, headers, runtime)

    async def delete_remote_class_course_async(
        self,
        course_code: str,
        request: dingtalkedu__1__0_models.DeleteRemoteClassCourseRequest,
    ) -> dingtalkedu__1__0_models.DeleteRemoteClassCourseResponse:
        """
        @summary 删除专递课堂课程
        
        @param request: DeleteRemoteClassCourseRequest
        @return: DeleteRemoteClassCourseResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteRemoteClassCourseHeaders()
        return await self.delete_remote_class_course_with_options_async(course_code, request, headers, runtime)

    def delete_student_with_options(
        self,
        class_id: str,
        user_id: str,
        request: dingtalkedu__1__0_models.DeleteStudentRequest,
        headers: dingtalkedu__1__0_models.DeleteStudentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteStudentResponse:
        """
        @summary 删除学生
        
        @param request: DeleteStudentRequest
        @param headers: DeleteStudentHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteStudentResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
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
            action='DeleteStudent',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/classes/{class_id}/students/{user_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteStudentResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_student_with_options_async(
        self,
        class_id: str,
        user_id: str,
        request: dingtalkedu__1__0_models.DeleteStudentRequest,
        headers: dingtalkedu__1__0_models.DeleteStudentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteStudentResponse:
        """
        @summary 删除学生
        
        @param request: DeleteStudentRequest
        @param headers: DeleteStudentHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteStudentResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
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
            action='DeleteStudent',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/classes/{class_id}/students/{user_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteStudentResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_student(
        self,
        class_id: str,
        user_id: str,
        request: dingtalkedu__1__0_models.DeleteStudentRequest,
    ) -> dingtalkedu__1__0_models.DeleteStudentResponse:
        """
        @summary 删除学生
        
        @param request: DeleteStudentRequest
        @return: DeleteStudentResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteStudentHeaders()
        return self.delete_student_with_options(class_id, user_id, request, headers, runtime)

    async def delete_student_async(
        self,
        class_id: str,
        user_id: str,
        request: dingtalkedu__1__0_models.DeleteStudentRequest,
    ) -> dingtalkedu__1__0_models.DeleteStudentResponse:
        """
        @summary 删除学生
        
        @param request: DeleteStudentRequest
        @return: DeleteStudentResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteStudentHeaders()
        return await self.delete_student_with_options_async(class_id, user_id, request, headers, runtime)

    def delete_teacher_with_options(
        self,
        class_id: str,
        user_id: str,
        request: dingtalkedu__1__0_models.DeleteTeacherRequest,
        headers: dingtalkedu__1__0_models.DeleteTeacherHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteTeacherResponse:
        """
        @summary 删除老师
        
        @param request: DeleteTeacherRequest
        @param headers: DeleteTeacherHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteTeacherResponse
        """
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
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='DeleteTeacher',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/classes/{class_id}/teachers/{user_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteTeacherResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_teacher_with_options_async(
        self,
        class_id: str,
        user_id: str,
        request: dingtalkedu__1__0_models.DeleteTeacherRequest,
        headers: dingtalkedu__1__0_models.DeleteTeacherHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteTeacherResponse:
        """
        @summary 删除老师
        
        @param request: DeleteTeacherRequest
        @param headers: DeleteTeacherHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteTeacherResponse
        """
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
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='DeleteTeacher',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/classes/{class_id}/teachers/{user_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteTeacherResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_teacher(
        self,
        class_id: str,
        user_id: str,
        request: dingtalkedu__1__0_models.DeleteTeacherRequest,
    ) -> dingtalkedu__1__0_models.DeleteTeacherResponse:
        """
        @summary 删除老师
        
        @param request: DeleteTeacherRequest
        @return: DeleteTeacherResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteTeacherHeaders()
        return self.delete_teacher_with_options(class_id, user_id, request, headers, runtime)

    async def delete_teacher_async(
        self,
        class_id: str,
        user_id: str,
        request: dingtalkedu__1__0_models.DeleteTeacherRequest,
    ) -> dingtalkedu__1__0_models.DeleteTeacherResponse:
        """
        @summary 删除老师
        
        @param request: DeleteTeacherRequest
        @return: DeleteTeacherResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteTeacherHeaders()
        return await self.delete_teacher_with_options_async(class_id, user_id, request, headers, runtime)

    def delete_university_course_group_with_options(
        self,
        request: dingtalkedu__1__0_models.DeleteUniversityCourseGroupRequest,
        headers: dingtalkedu__1__0_models.DeleteUniversityCourseGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteUniversityCourseGroupResponse:
        """
        @summary 删除大学课程组
        
        @param request: DeleteUniversityCourseGroupRequest
        @param headers: DeleteUniversityCourseGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteUniversityCourseGroupResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.course_group_code):
            query['courseGroupCode'] = request.course_group_code
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
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
            action='DeleteUniversityCourseGroup',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/courseGroups',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteUniversityCourseGroupResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_university_course_group_with_options_async(
        self,
        request: dingtalkedu__1__0_models.DeleteUniversityCourseGroupRequest,
        headers: dingtalkedu__1__0_models.DeleteUniversityCourseGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteUniversityCourseGroupResponse:
        """
        @summary 删除大学课程组
        
        @param request: DeleteUniversityCourseGroupRequest
        @param headers: DeleteUniversityCourseGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteUniversityCourseGroupResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.course_group_code):
            query['courseGroupCode'] = request.course_group_code
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
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
            action='DeleteUniversityCourseGroup',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/courseGroups',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteUniversityCourseGroupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_university_course_group(
        self,
        request: dingtalkedu__1__0_models.DeleteUniversityCourseGroupRequest,
    ) -> dingtalkedu__1__0_models.DeleteUniversityCourseGroupResponse:
        """
        @summary 删除大学课程组
        
        @param request: DeleteUniversityCourseGroupRequest
        @return: DeleteUniversityCourseGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteUniversityCourseGroupHeaders()
        return self.delete_university_course_group_with_options(request, headers, runtime)

    async def delete_university_course_group_async(
        self,
        request: dingtalkedu__1__0_models.DeleteUniversityCourseGroupRequest,
    ) -> dingtalkedu__1__0_models.DeleteUniversityCourseGroupResponse:
        """
        @summary 删除大学课程组
        
        @param request: DeleteUniversityCourseGroupRequest
        @return: DeleteUniversityCourseGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteUniversityCourseGroupHeaders()
        return await self.delete_university_course_group_with_options_async(request, headers, runtime)

    def delete_university_student_with_options(
        self,
        request: dingtalkedu__1__0_models.DeleteUniversityStudentRequest,
        headers: dingtalkedu__1__0_models.DeleteUniversityStudentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteUniversityStudentResponse:
        """
        @summary 删除大学学生
        
        @param request: DeleteUniversityStudentRequest
        @param headers: DeleteUniversityStudentHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteUniversityStudentResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.class_id):
            query['classId'] = request.class_id
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.student_user_id):
            query['studentUserId'] = request.student_user_id
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
            action='DeleteUniversityStudent',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/students',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteUniversityStudentResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_university_student_with_options_async(
        self,
        request: dingtalkedu__1__0_models.DeleteUniversityStudentRequest,
        headers: dingtalkedu__1__0_models.DeleteUniversityStudentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteUniversityStudentResponse:
        """
        @summary 删除大学学生
        
        @param request: DeleteUniversityStudentRequest
        @param headers: DeleteUniversityStudentHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteUniversityStudentResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.class_id):
            query['classId'] = request.class_id
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.student_user_id):
            query['studentUserId'] = request.student_user_id
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
            action='DeleteUniversityStudent',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/students',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteUniversityStudentResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_university_student(
        self,
        request: dingtalkedu__1__0_models.DeleteUniversityStudentRequest,
    ) -> dingtalkedu__1__0_models.DeleteUniversityStudentResponse:
        """
        @summary 删除大学学生
        
        @param request: DeleteUniversityStudentRequest
        @return: DeleteUniversityStudentResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteUniversityStudentHeaders()
        return self.delete_university_student_with_options(request, headers, runtime)

    async def delete_university_student_async(
        self,
        request: dingtalkedu__1__0_models.DeleteUniversityStudentRequest,
    ) -> dingtalkedu__1__0_models.DeleteUniversityStudentResponse:
        """
        @summary 删除大学学生
        
        @param request: DeleteUniversityStudentRequest
        @return: DeleteUniversityStudentResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteUniversityStudentHeaders()
        return await self.delete_university_student_with_options_async(request, headers, runtime)

    def delete_university_teacher_with_options(
        self,
        request: dingtalkedu__1__0_models.DeleteUniversityTeacherRequest,
        headers: dingtalkedu__1__0_models.DeleteUniversityTeacherHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteUniversityTeacherResponse:
        """
        @summary 删除大学教师
        
        @param request: DeleteUniversityTeacherRequest
        @param headers: DeleteUniversityTeacherHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteUniversityTeacherResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.class_id):
            query['classId'] = request.class_id
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.role):
            query['role'] = request.role
        if not UtilClient.is_unset(request.teacher_user_id):
            query['teacherUserId'] = request.teacher_user_id
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
            action='DeleteUniversityTeacher',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/teachers',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteUniversityTeacherResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_university_teacher_with_options_async(
        self,
        request: dingtalkedu__1__0_models.DeleteUniversityTeacherRequest,
        headers: dingtalkedu__1__0_models.DeleteUniversityTeacherHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteUniversityTeacherResponse:
        """
        @summary 删除大学教师
        
        @param request: DeleteUniversityTeacherRequest
        @param headers: DeleteUniversityTeacherHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteUniversityTeacherResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.class_id):
            query['classId'] = request.class_id
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.role):
            query['role'] = request.role
        if not UtilClient.is_unset(request.teacher_user_id):
            query['teacherUserId'] = request.teacher_user_id
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
            action='DeleteUniversityTeacher',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/teachers',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteUniversityTeacherResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_university_teacher(
        self,
        request: dingtalkedu__1__0_models.DeleteUniversityTeacherRequest,
    ) -> dingtalkedu__1__0_models.DeleteUniversityTeacherResponse:
        """
        @summary 删除大学教师
        
        @param request: DeleteUniversityTeacherRequest
        @return: DeleteUniversityTeacherResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteUniversityTeacherHeaders()
        return self.delete_university_teacher_with_options(request, headers, runtime)

    async def delete_university_teacher_async(
        self,
        request: dingtalkedu__1__0_models.DeleteUniversityTeacherRequest,
    ) -> dingtalkedu__1__0_models.DeleteUniversityTeacherResponse:
        """
        @summary 删除大学教师
        
        @param request: DeleteUniversityTeacherRequest
        @return: DeleteUniversityTeacherResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteUniversityTeacherHeaders()
        return await self.delete_university_teacher_with_options_async(request, headers, runtime)

    def device_heartbeat_with_options(
        self,
        request: dingtalkedu__1__0_models.DeviceHeartbeatRequest,
        headers: dingtalkedu__1__0_models.DeviceHeartbeatHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeviceHeartbeatResponse:
        """
        @summary 设备心跳上报
        
        @param request: DeviceHeartbeatRequest
        @param headers: DeviceHeartbeatHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeviceHeartbeatResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.sn):
            query['sn'] = request.sn
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
            action='DeviceHeartbeat',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/heartbeats/report',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeviceHeartbeatResponse(),
            self.execute(params, req, runtime)
        )

    async def device_heartbeat_with_options_async(
        self,
        request: dingtalkedu__1__0_models.DeviceHeartbeatRequest,
        headers: dingtalkedu__1__0_models.DeviceHeartbeatHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeviceHeartbeatResponse:
        """
        @summary 设备心跳上报
        
        @param request: DeviceHeartbeatRequest
        @param headers: DeviceHeartbeatHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeviceHeartbeatResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.sn):
            query['sn'] = request.sn
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
            action='DeviceHeartbeat',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/heartbeats/report',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeviceHeartbeatResponse(),
            await self.execute_async(params, req, runtime)
        )

    def device_heartbeat(
        self,
        request: dingtalkedu__1__0_models.DeviceHeartbeatRequest,
    ) -> dingtalkedu__1__0_models.DeviceHeartbeatResponse:
        """
        @summary 设备心跳上报
        
        @param request: DeviceHeartbeatRequest
        @return: DeviceHeartbeatResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeviceHeartbeatHeaders()
        return self.device_heartbeat_with_options(request, headers, runtime)

    async def device_heartbeat_async(
        self,
        request: dingtalkedu__1__0_models.DeviceHeartbeatRequest,
    ) -> dingtalkedu__1__0_models.DeviceHeartbeatResponse:
        """
        @summary 设备心跳上报
        
        @param request: DeviceHeartbeatRequest
        @return: DeviceHeartbeatResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeviceHeartbeatHeaders()
        return await self.device_heartbeat_with_options_async(request, headers, runtime)

    def edu_find_user_roles_by_user_id_with_options(
        self,
        request: dingtalkedu__1__0_models.EduFindUserRolesByUserIdRequest,
        headers: dingtalkedu__1__0_models.EduFindUserRolesByUserIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.EduFindUserRolesByUserIdResponse:
        """
        @summary 教育侧用户的所有角色
        
        @param request: EduFindUserRolesByUserIdRequest
        @param headers: EduFindUserRolesByUserIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: EduFindUserRolesByUserIdResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.class_id):
            query['classId'] = request.class_id
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.has_org_role):
            query['hasOrgRole'] = request.has_org_role
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
            action='EduFindUserRolesByUserId',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/users/allRoles',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.EduFindUserRolesByUserIdResponse(),
            self.execute(params, req, runtime)
        )

    async def edu_find_user_roles_by_user_id_with_options_async(
        self,
        request: dingtalkedu__1__0_models.EduFindUserRolesByUserIdRequest,
        headers: dingtalkedu__1__0_models.EduFindUserRolesByUserIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.EduFindUserRolesByUserIdResponse:
        """
        @summary 教育侧用户的所有角色
        
        @param request: EduFindUserRolesByUserIdRequest
        @param headers: EduFindUserRolesByUserIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: EduFindUserRolesByUserIdResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.class_id):
            query['classId'] = request.class_id
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.has_org_role):
            query['hasOrgRole'] = request.has_org_role
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
            action='EduFindUserRolesByUserId',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/users/allRoles',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.EduFindUserRolesByUserIdResponse(),
            await self.execute_async(params, req, runtime)
        )

    def edu_find_user_roles_by_user_id(
        self,
        request: dingtalkedu__1__0_models.EduFindUserRolesByUserIdRequest,
    ) -> dingtalkedu__1__0_models.EduFindUserRolesByUserIdResponse:
        """
        @summary 教育侧用户的所有角色
        
        @param request: EduFindUserRolesByUserIdRequest
        @return: EduFindUserRolesByUserIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.EduFindUserRolesByUserIdHeaders()
        return self.edu_find_user_roles_by_user_id_with_options(request, headers, runtime)

    async def edu_find_user_roles_by_user_id_async(
        self,
        request: dingtalkedu__1__0_models.EduFindUserRolesByUserIdRequest,
    ) -> dingtalkedu__1__0_models.EduFindUserRolesByUserIdResponse:
        """
        @summary 教育侧用户的所有角色
        
        @param request: EduFindUserRolesByUserIdRequest
        @return: EduFindUserRolesByUserIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.EduFindUserRolesByUserIdHeaders()
        return await self.edu_find_user_roles_by_user_id_with_options_async(request, headers, runtime)

    def edu_list_user_by_from_user_ids_with_options(
        self,
        request: dingtalkedu__1__0_models.EduListUserByFromUserIdsRequest,
        headers: dingtalkedu__1__0_models.EduListUserByFromUserIdsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.EduListUserByFromUserIdsResponse:
        """
        @summary 教育侧获取用户所有关系详情列表
        
        @param request: EduListUserByFromUserIdsRequest
        @param headers: EduListUserByFromUserIdsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: EduListUserByFromUserIdsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.class_id):
            query['classId'] = request.class_id
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.guardian_user_id):
            query['guardianUserId'] = request.guardian_user_id
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
            action='EduListUserByFromUserIds',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/users/allRelations/lists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.EduListUserByFromUserIdsResponse(),
            self.execute(params, req, runtime)
        )

    async def edu_list_user_by_from_user_ids_with_options_async(
        self,
        request: dingtalkedu__1__0_models.EduListUserByFromUserIdsRequest,
        headers: dingtalkedu__1__0_models.EduListUserByFromUserIdsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.EduListUserByFromUserIdsResponse:
        """
        @summary 教育侧获取用户所有关系详情列表
        
        @param request: EduListUserByFromUserIdsRequest
        @param headers: EduListUserByFromUserIdsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: EduListUserByFromUserIdsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.class_id):
            query['classId'] = request.class_id
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.guardian_user_id):
            query['guardianUserId'] = request.guardian_user_id
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
            action='EduListUserByFromUserIds',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/users/allRelations/lists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.EduListUserByFromUserIdsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def edu_list_user_by_from_user_ids(
        self,
        request: dingtalkedu__1__0_models.EduListUserByFromUserIdsRequest,
    ) -> dingtalkedu__1__0_models.EduListUserByFromUserIdsResponse:
        """
        @summary 教育侧获取用户所有关系详情列表
        
        @param request: EduListUserByFromUserIdsRequest
        @return: EduListUserByFromUserIdsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.EduListUserByFromUserIdsHeaders()
        return self.edu_list_user_by_from_user_ids_with_options(request, headers, runtime)

    async def edu_list_user_by_from_user_ids_async(
        self,
        request: dingtalkedu__1__0_models.EduListUserByFromUserIdsRequest,
    ) -> dingtalkedu__1__0_models.EduListUserByFromUserIdsResponse:
        """
        @summary 教育侧获取用户所有关系详情列表
        
        @param request: EduListUserByFromUserIdsRequest
        @return: EduListUserByFromUserIdsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.EduListUserByFromUserIdsHeaders()
        return await self.edu_list_user_by_from_user_ids_with_options_async(request, headers, runtime)

    def edu_teacher_list_with_options(
        self,
        request: dingtalkedu__1__0_models.EduTeacherListRequest,
        headers: dingtalkedu__1__0_models.EduTeacherListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.EduTeacherListResponse:
        """
        @summary 查询教师列表
        
        @param request: EduTeacherListRequest
        @param headers: EduTeacherListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: EduTeacherListResponse
        """
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
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='EduTeacherList',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/teachers',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.EduTeacherListResponse(),
            self.execute(params, req, runtime)
        )

    async def edu_teacher_list_with_options_async(
        self,
        request: dingtalkedu__1__0_models.EduTeacherListRequest,
        headers: dingtalkedu__1__0_models.EduTeacherListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.EduTeacherListResponse:
        """
        @summary 查询教师列表
        
        @param request: EduTeacherListRequest
        @param headers: EduTeacherListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: EduTeacherListResponse
        """
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
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='EduTeacherList',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/teachers',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.EduTeacherListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def edu_teacher_list(
        self,
        request: dingtalkedu__1__0_models.EduTeacherListRequest,
    ) -> dingtalkedu__1__0_models.EduTeacherListResponse:
        """
        @summary 查询教师列表
        
        @param request: EduTeacherListRequest
        @return: EduTeacherListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.EduTeacherListHeaders()
        return self.edu_teacher_list_with_options(request, headers, runtime)

    async def edu_teacher_list_async(
        self,
        request: dingtalkedu__1__0_models.EduTeacherListRequest,
    ) -> dingtalkedu__1__0_models.EduTeacherListResponse:
        """
        @summary 查询教师列表
        
        @param request: EduTeacherListRequest
        @return: EduTeacherListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.EduTeacherListHeaders()
        return await self.edu_teacher_list_with_options_async(request, headers, runtime)

    def end_course_with_options(
        self,
        request: dingtalkedu__1__0_models.EndCourseRequest,
        headers: dingtalkedu__1__0_models.EndCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.EndCourseResponse:
        """
        @summary 关闭课程
        
        @param request: EndCourseRequest
        @param headers: EndCourseHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: EndCourseResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.course_code):
            body['courseCode'] = request.course_code
        if not UtilClient.is_unset(request.ext):
            body['ext'] = request.ext
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.live_play_info_list):
            body['livePlayInfoList'] = request.live_play_info_list
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
            action='EndCourse',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/courses/end',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.EndCourseResponse(),
            self.execute(params, req, runtime)
        )

    async def end_course_with_options_async(
        self,
        request: dingtalkedu__1__0_models.EndCourseRequest,
        headers: dingtalkedu__1__0_models.EndCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.EndCourseResponse:
        """
        @summary 关闭课程
        
        @param request: EndCourseRequest
        @param headers: EndCourseHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: EndCourseResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.course_code):
            body['courseCode'] = request.course_code
        if not UtilClient.is_unset(request.ext):
            body['ext'] = request.ext
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.live_play_info_list):
            body['livePlayInfoList'] = request.live_play_info_list
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
            action='EndCourse',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/courses/end',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.EndCourseResponse(),
            await self.execute_async(params, req, runtime)
        )

    def end_course(
        self,
        request: dingtalkedu__1__0_models.EndCourseRequest,
    ) -> dingtalkedu__1__0_models.EndCourseResponse:
        """
        @summary 关闭课程
        
        @param request: EndCourseRequest
        @return: EndCourseResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.EndCourseHeaders()
        return self.end_course_with_options(request, headers, runtime)

    async def end_course_async(
        self,
        request: dingtalkedu__1__0_models.EndCourseRequest,
    ) -> dingtalkedu__1__0_models.EndCourseResponse:
        """
        @summary 关闭课程
        
        @param request: EndCourseRequest
        @return: EndCourseResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.EndCourseHeaders()
        return await self.end_course_with_options_async(request, headers, runtime)

    def get_bind_child_info_with_options(
        self,
        request: dingtalkedu__1__0_models.GetBindChildInfoRequest,
        headers: dingtalkedu__1__0_models.GetBindChildInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetBindChildInfoResponse:
        """
        @summary 获取绑定孩子信息
        
        @param request: GetBindChildInfoRequest
        @param headers: GetBindChildInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetBindChildInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.school_corp_id):
            query['schoolCorpId'] = request.school_corp_id
        if not UtilClient.is_unset(request.student_user_id):
            query['studentUserId'] = request.student_user_id
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
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
            action='GetBindChildInfo',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/families/childs/infos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetBindChildInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def get_bind_child_info_with_options_async(
        self,
        request: dingtalkedu__1__0_models.GetBindChildInfoRequest,
        headers: dingtalkedu__1__0_models.GetBindChildInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetBindChildInfoResponse:
        """
        @summary 获取绑定孩子信息
        
        @param request: GetBindChildInfoRequest
        @param headers: GetBindChildInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetBindChildInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.school_corp_id):
            query['schoolCorpId'] = request.school_corp_id
        if not UtilClient.is_unset(request.student_user_id):
            query['studentUserId'] = request.student_user_id
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
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
            action='GetBindChildInfo',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/families/childs/infos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetBindChildInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_bind_child_info(
        self,
        request: dingtalkedu__1__0_models.GetBindChildInfoRequest,
    ) -> dingtalkedu__1__0_models.GetBindChildInfoResponse:
        """
        @summary 获取绑定孩子信息
        
        @param request: GetBindChildInfoRequest
        @return: GetBindChildInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetBindChildInfoHeaders()
        return self.get_bind_child_info_with_options(request, headers, runtime)

    async def get_bind_child_info_async(
        self,
        request: dingtalkedu__1__0_models.GetBindChildInfoRequest,
    ) -> dingtalkedu__1__0_models.GetBindChildInfoResponse:
        """
        @summary 获取绑定孩子信息
        
        @param request: GetBindChildInfoRequest
        @return: GetBindChildInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetBindChildInfoHeaders()
        return await self.get_bind_child_info_with_options_async(request, headers, runtime)

    def get_college_alumni_depts_with_options(
        self,
        request: dingtalkedu__1__0_models.GetCollegeAlumniDeptsRequest,
        headers: dingtalkedu__1__0_models.GetCollegeAlumniDeptsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetCollegeAlumniDeptsResponse:
        """
        @summary 高校校友会获取当前部门的所有子部门
        
        @param request: GetCollegeAlumniDeptsRequest
        @param headers: GetCollegeAlumniDeptsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetCollegeAlumniDeptsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
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
            action='GetCollegeAlumniDepts',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/collegeAlumni/subDepts',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetCollegeAlumniDeptsResponse(),
            self.execute(params, req, runtime)
        )

    async def get_college_alumni_depts_with_options_async(
        self,
        request: dingtalkedu__1__0_models.GetCollegeAlumniDeptsRequest,
        headers: dingtalkedu__1__0_models.GetCollegeAlumniDeptsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetCollegeAlumniDeptsResponse:
        """
        @summary 高校校友会获取当前部门的所有子部门
        
        @param request: GetCollegeAlumniDeptsRequest
        @param headers: GetCollegeAlumniDeptsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetCollegeAlumniDeptsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
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
            action='GetCollegeAlumniDepts',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/collegeAlumni/subDepts',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetCollegeAlumniDeptsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_college_alumni_depts(
        self,
        request: dingtalkedu__1__0_models.GetCollegeAlumniDeptsRequest,
    ) -> dingtalkedu__1__0_models.GetCollegeAlumniDeptsResponse:
        """
        @summary 高校校友会获取当前部门的所有子部门
        
        @param request: GetCollegeAlumniDeptsRequest
        @return: GetCollegeAlumniDeptsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetCollegeAlumniDeptsHeaders()
        return self.get_college_alumni_depts_with_options(request, headers, runtime)

    async def get_college_alumni_depts_async(
        self,
        request: dingtalkedu__1__0_models.GetCollegeAlumniDeptsRequest,
    ) -> dingtalkedu__1__0_models.GetCollegeAlumniDeptsResponse:
        """
        @summary 高校校友会获取当前部门的所有子部门
        
        @param request: GetCollegeAlumniDeptsRequest
        @return: GetCollegeAlumniDeptsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetCollegeAlumniDeptsHeaders()
        return await self.get_college_alumni_depts_with_options_async(request, headers, runtime)

    def get_college_alumni_user_info_with_options(
        self,
        request: dingtalkedu__1__0_models.GetCollegeAlumniUserInfoRequest,
        headers: dingtalkedu__1__0_models.GetCollegeAlumniUserInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetCollegeAlumniUserInfoResponse:
        """
        @summary 高校校友会查询校友信息
        
        @param request: GetCollegeAlumniUserInfoRequest
        @param headers: GetCollegeAlumniUserInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetCollegeAlumniUserInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
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
            action='GetCollegeAlumniUserInfo',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/collegeAlumni/userInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetCollegeAlumniUserInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def get_college_alumni_user_info_with_options_async(
        self,
        request: dingtalkedu__1__0_models.GetCollegeAlumniUserInfoRequest,
        headers: dingtalkedu__1__0_models.GetCollegeAlumniUserInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetCollegeAlumniUserInfoResponse:
        """
        @summary 高校校友会查询校友信息
        
        @param request: GetCollegeAlumniUserInfoRequest
        @param headers: GetCollegeAlumniUserInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetCollegeAlumniUserInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
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
            action='GetCollegeAlumniUserInfo',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/collegeAlumni/userInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetCollegeAlumniUserInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_college_alumni_user_info(
        self,
        request: dingtalkedu__1__0_models.GetCollegeAlumniUserInfoRequest,
    ) -> dingtalkedu__1__0_models.GetCollegeAlumniUserInfoResponse:
        """
        @summary 高校校友会查询校友信息
        
        @param request: GetCollegeAlumniUserInfoRequest
        @return: GetCollegeAlumniUserInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetCollegeAlumniUserInfoHeaders()
        return self.get_college_alumni_user_info_with_options(request, headers, runtime)

    async def get_college_alumni_user_info_async(
        self,
        request: dingtalkedu__1__0_models.GetCollegeAlumniUserInfoRequest,
    ) -> dingtalkedu__1__0_models.GetCollegeAlumniUserInfoResponse:
        """
        @summary 高校校友会查询校友信息
        
        @param request: GetCollegeAlumniUserInfoRequest
        @return: GetCollegeAlumniUserInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetCollegeAlumniUserInfoHeaders()
        return await self.get_college_alumni_user_info_with_options_async(request, headers, runtime)

    def get_college_contact_dept_detail_with_options(
        self,
        request: dingtalkedu__1__0_models.GetCollegeContactDeptDetailRequest,
        headers: dingtalkedu__1__0_models.GetCollegeContactDeptDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetCollegeContactDeptDetailResponse:
        """
        @summary 获取高校通讯录组织单元详情
        
        @param request: GetCollegeContactDeptDetailRequest
        @param headers: GetCollegeContactDeptDetailHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetCollegeContactDeptDetailResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
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
            action='GetCollegeContactDeptDetail',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/collegeContact/depts',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetCollegeContactDeptDetailResponse(),
            self.execute(params, req, runtime)
        )

    async def get_college_contact_dept_detail_with_options_async(
        self,
        request: dingtalkedu__1__0_models.GetCollegeContactDeptDetailRequest,
        headers: dingtalkedu__1__0_models.GetCollegeContactDeptDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetCollegeContactDeptDetailResponse:
        """
        @summary 获取高校通讯录组织单元详情
        
        @param request: GetCollegeContactDeptDetailRequest
        @param headers: GetCollegeContactDeptDetailHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetCollegeContactDeptDetailResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
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
            action='GetCollegeContactDeptDetail',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/collegeContact/depts',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetCollegeContactDeptDetailResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_college_contact_dept_detail(
        self,
        request: dingtalkedu__1__0_models.GetCollegeContactDeptDetailRequest,
    ) -> dingtalkedu__1__0_models.GetCollegeContactDeptDetailResponse:
        """
        @summary 获取高校通讯录组织单元详情
        
        @param request: GetCollegeContactDeptDetailRequest
        @return: GetCollegeContactDeptDetailResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetCollegeContactDeptDetailHeaders()
        return self.get_college_contact_dept_detail_with_options(request, headers, runtime)

    async def get_college_contact_dept_detail_async(
        self,
        request: dingtalkedu__1__0_models.GetCollegeContactDeptDetailRequest,
    ) -> dingtalkedu__1__0_models.GetCollegeContactDeptDetailResponse:
        """
        @summary 获取高校通讯录组织单元详情
        
        @param request: GetCollegeContactDeptDetailRequest
        @return: GetCollegeContactDeptDetailResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetCollegeContactDeptDetailHeaders()
        return await self.get_college_contact_dept_detail_with_options_async(request, headers, runtime)

    def get_college_contact_standard_stru_dept_detail_with_options(
        self,
        request: dingtalkedu__1__0_models.GetCollegeContactStandardStruDeptDetailRequest,
        headers: dingtalkedu__1__0_models.GetCollegeContactStandardStruDeptDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetCollegeContactStandardStruDeptDetailResponse:
        """
        @summary 获取行政组织架构信息
        
        @param request: GetCollegeContactStandardStruDeptDetailRequest
        @param headers: GetCollegeContactStandardStruDeptDetailHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetCollegeContactStandardStruDeptDetailResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
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
            action='GetCollegeContactStandardStruDeptDetail',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/collegeContact/depts/structures/standards',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetCollegeContactStandardStruDeptDetailResponse(),
            self.execute(params, req, runtime)
        )

    async def get_college_contact_standard_stru_dept_detail_with_options_async(
        self,
        request: dingtalkedu__1__0_models.GetCollegeContactStandardStruDeptDetailRequest,
        headers: dingtalkedu__1__0_models.GetCollegeContactStandardStruDeptDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetCollegeContactStandardStruDeptDetailResponse:
        """
        @summary 获取行政组织架构信息
        
        @param request: GetCollegeContactStandardStruDeptDetailRequest
        @param headers: GetCollegeContactStandardStruDeptDetailHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetCollegeContactStandardStruDeptDetailResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
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
            action='GetCollegeContactStandardStruDeptDetail',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/collegeContact/depts/structures/standards',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetCollegeContactStandardStruDeptDetailResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_college_contact_standard_stru_dept_detail(
        self,
        request: dingtalkedu__1__0_models.GetCollegeContactStandardStruDeptDetailRequest,
    ) -> dingtalkedu__1__0_models.GetCollegeContactStandardStruDeptDetailResponse:
        """
        @summary 获取行政组织架构信息
        
        @param request: GetCollegeContactStandardStruDeptDetailRequest
        @return: GetCollegeContactStandardStruDeptDetailResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetCollegeContactStandardStruDeptDetailHeaders()
        return self.get_college_contact_standard_stru_dept_detail_with_options(request, headers, runtime)

    async def get_college_contact_standard_stru_dept_detail_async(
        self,
        request: dingtalkedu__1__0_models.GetCollegeContactStandardStruDeptDetailRequest,
    ) -> dingtalkedu__1__0_models.GetCollegeContactStandardStruDeptDetailResponse:
        """
        @summary 获取行政组织架构信息
        
        @param request: GetCollegeContactStandardStruDeptDetailRequest
        @return: GetCollegeContactStandardStruDeptDetailResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetCollegeContactStandardStruDeptDetailHeaders()
        return await self.get_college_contact_standard_stru_dept_detail_with_options_async(request, headers, runtime)

    def get_default_child_with_options(
        self,
        headers: dingtalkedu__1__0_models.GetDefaultChildHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetDefaultChildResponse:
        """
        @summary 获取默认孩子信息
        
        @param headers: GetDefaultChildHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetDefaultChildResponse
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
            action='GetDefaultChild',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/defaultChildren',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetDefaultChildResponse(),
            self.execute(params, req, runtime)
        )

    async def get_default_child_with_options_async(
        self,
        headers: dingtalkedu__1__0_models.GetDefaultChildHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetDefaultChildResponse:
        """
        @summary 获取默认孩子信息
        
        @param headers: GetDefaultChildHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetDefaultChildResponse
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
            action='GetDefaultChild',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/defaultChildren',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetDefaultChildResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_default_child(self) -> dingtalkedu__1__0_models.GetDefaultChildResponse:
        """
        @summary 获取默认孩子信息
        
        @return: GetDefaultChildResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetDefaultChildHeaders()
        return self.get_default_child_with_options(headers, runtime)

    async def get_default_child_async(self) -> dingtalkedu__1__0_models.GetDefaultChildResponse:
        """
        @summary 获取默认孩子信息
        
        @return: GetDefaultChildResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetDefaultChildHeaders()
        return await self.get_default_child_with_options_async(headers, runtime)

    def get_edu_user_identity_with_options(
        self,
        request: dingtalkedu__1__0_models.GetEduUserIdentityRequest,
        headers: dingtalkedu__1__0_models.GetEduUserIdentityHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetEduUserIdentityResponse:
        """
        @summary 阿里云盘教师节活动获取用户身份
        
        @param request: GetEduUserIdentityRequest
        @param headers: GetEduUserIdentityHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetEduUserIdentityResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
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
            action='GetEduUserIdentity',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/apollos/activities/userIdentities',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetEduUserIdentityResponse(),
            self.execute(params, req, runtime)
        )

    async def get_edu_user_identity_with_options_async(
        self,
        request: dingtalkedu__1__0_models.GetEduUserIdentityRequest,
        headers: dingtalkedu__1__0_models.GetEduUserIdentityHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetEduUserIdentityResponse:
        """
        @summary 阿里云盘教师节活动获取用户身份
        
        @param request: GetEduUserIdentityRequest
        @param headers: GetEduUserIdentityHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetEduUserIdentityResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
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
            action='GetEduUserIdentity',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/apollos/activities/userIdentities',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetEduUserIdentityResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_edu_user_identity(
        self,
        request: dingtalkedu__1__0_models.GetEduUserIdentityRequest,
    ) -> dingtalkedu__1__0_models.GetEduUserIdentityResponse:
        """
        @summary 阿里云盘教师节活动获取用户身份
        
        @param request: GetEduUserIdentityRequest
        @return: GetEduUserIdentityResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetEduUserIdentityHeaders()
        return self.get_edu_user_identity_with_options(request, headers, runtime)

    async def get_edu_user_identity_async(
        self,
        request: dingtalkedu__1__0_models.GetEduUserIdentityRequest,
    ) -> dingtalkedu__1__0_models.GetEduUserIdentityResponse:
        """
        @summary 阿里云盘教师节活动获取用户身份
        
        @param request: GetEduUserIdentityRequest
        @return: GetEduUserIdentityResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetEduUserIdentityHeaders()
        return await self.get_edu_user_identity_with_options_async(request, headers, runtime)

    def get_file_download_info_with_options(
        self,
        request: dingtalkedu__1__0_models.GetFileDownloadInfoRequest,
        headers: dingtalkedu__1__0_models.GetFileDownloadInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetFileDownloadInfoResponse:
        """
        @summary 获取文件下载信息
        
        @param request: GetFileDownloadInfoRequest
        @param headers: GetFileDownloadInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetFileDownloadInfoResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.file_id_list):
            body['fileIdList'] = request.file_id_list
        if not UtilClient.is_unset(request.space_id):
            body['spaceId'] = request.space_id
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
            action='GetFileDownloadInfo',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/files/downloadInfos/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetFileDownloadInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def get_file_download_info_with_options_async(
        self,
        request: dingtalkedu__1__0_models.GetFileDownloadInfoRequest,
        headers: dingtalkedu__1__0_models.GetFileDownloadInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetFileDownloadInfoResponse:
        """
        @summary 获取文件下载信息
        
        @param request: GetFileDownloadInfoRequest
        @param headers: GetFileDownloadInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetFileDownloadInfoResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.file_id_list):
            body['fileIdList'] = request.file_id_list
        if not UtilClient.is_unset(request.space_id):
            body['spaceId'] = request.space_id
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
            action='GetFileDownloadInfo',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/files/downloadInfos/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetFileDownloadInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_file_download_info(
        self,
        request: dingtalkedu__1__0_models.GetFileDownloadInfoRequest,
    ) -> dingtalkedu__1__0_models.GetFileDownloadInfoResponse:
        """
        @summary 获取文件下载信息
        
        @param request: GetFileDownloadInfoRequest
        @return: GetFileDownloadInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetFileDownloadInfoHeaders()
        return self.get_file_download_info_with_options(request, headers, runtime)

    async def get_file_download_info_async(
        self,
        request: dingtalkedu__1__0_models.GetFileDownloadInfoRequest,
    ) -> dingtalkedu__1__0_models.GetFileDownloadInfoResponse:
        """
        @summary 获取文件下载信息
        
        @param request: GetFileDownloadInfoRequest
        @return: GetFileDownloadInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetFileDownloadInfoHeaders()
        return await self.get_file_download_info_with_options_async(request, headers, runtime)

    def get_image_temp_download_url_with_options(
        self,
        request: dingtalkedu__1__0_models.GetImageTempDownloadUrlRequest,
        headers: dingtalkedu__1__0_models.GetImageTempDownloadUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetImageTempDownloadUrlResponse:
        """
        @summary 获取图片下载信息
        
        @param request: GetImageTempDownloadUrlRequest
        @param headers: GetImageTempDownloadUrlHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetImageTempDownloadUrlResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.media_id):
            body['mediaId'] = request.media_id
        if not UtilClient.is_unset(request.source_type):
            body['sourceType'] = request.source_type
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
            action='GetImageTempDownloadUrl',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/images/tempDownloadUrls/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetImageTempDownloadUrlResponse(),
            self.execute(params, req, runtime)
        )

    async def get_image_temp_download_url_with_options_async(
        self,
        request: dingtalkedu__1__0_models.GetImageTempDownloadUrlRequest,
        headers: dingtalkedu__1__0_models.GetImageTempDownloadUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetImageTempDownloadUrlResponse:
        """
        @summary 获取图片下载信息
        
        @param request: GetImageTempDownloadUrlRequest
        @param headers: GetImageTempDownloadUrlHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetImageTempDownloadUrlResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.media_id):
            body['mediaId'] = request.media_id
        if not UtilClient.is_unset(request.source_type):
            body['sourceType'] = request.source_type
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
            action='GetImageTempDownloadUrl',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/images/tempDownloadUrls/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetImageTempDownloadUrlResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_image_temp_download_url(
        self,
        request: dingtalkedu__1__0_models.GetImageTempDownloadUrlRequest,
    ) -> dingtalkedu__1__0_models.GetImageTempDownloadUrlResponse:
        """
        @summary 获取图片下载信息
        
        @param request: GetImageTempDownloadUrlRequest
        @return: GetImageTempDownloadUrlResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetImageTempDownloadUrlHeaders()
        return self.get_image_temp_download_url_with_options(request, headers, runtime)

    async def get_image_temp_download_url_async(
        self,
        request: dingtalkedu__1__0_models.GetImageTempDownloadUrlRequest,
    ) -> dingtalkedu__1__0_models.GetImageTempDownloadUrlResponse:
        """
        @summary 获取图片下载信息
        
        @param request: GetImageTempDownloadUrlRequest
        @return: GetImageTempDownloadUrlResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetImageTempDownloadUrlHeaders()
        return await self.get_image_temp_download_url_with_options_async(request, headers, runtime)

    def get_open_course_detail_with_options(
        self,
        course_id: str,
        headers: dingtalkedu__1__0_models.GetOpenCourseDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetOpenCourseDetailResponse:
        """
        @summary 获取公开课的课程详情
        
        @param headers: GetOpenCourseDetailHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetOpenCourseDetailResponse
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
            action='GetOpenCourseDetail',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/openCourse/{course_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetOpenCourseDetailResponse(),
            self.execute(params, req, runtime)
        )

    async def get_open_course_detail_with_options_async(
        self,
        course_id: str,
        headers: dingtalkedu__1__0_models.GetOpenCourseDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetOpenCourseDetailResponse:
        """
        @summary 获取公开课的课程详情
        
        @param headers: GetOpenCourseDetailHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetOpenCourseDetailResponse
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
            action='GetOpenCourseDetail',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/openCourse/{course_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetOpenCourseDetailResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_open_course_detail(
        self,
        course_id: str,
    ) -> dingtalkedu__1__0_models.GetOpenCourseDetailResponse:
        """
        @summary 获取公开课的课程详情
        
        @return: GetOpenCourseDetailResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetOpenCourseDetailHeaders()
        return self.get_open_course_detail_with_options(course_id, headers, runtime)

    async def get_open_course_detail_async(
        self,
        course_id: str,
    ) -> dingtalkedu__1__0_models.GetOpenCourseDetailResponse:
        """
        @summary 获取公开课的课程详情
        
        @return: GetOpenCourseDetailResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetOpenCourseDetailHeaders()
        return await self.get_open_course_detail_with_options_async(course_id, headers, runtime)

    def get_open_courses_with_options(
        self,
        request: dingtalkedu__1__0_models.GetOpenCoursesRequest,
        headers: dingtalkedu__1__0_models.GetOpenCoursesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetOpenCoursesResponse:
        """
        @summary 获取通过审核的课程列表
        
        @param request: GetOpenCoursesRequest
        @param headers: GetOpenCoursesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetOpenCoursesResponse
        """
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
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetOpenCourses',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/openCourses',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetOpenCoursesResponse(),
            self.execute(params, req, runtime)
        )

    async def get_open_courses_with_options_async(
        self,
        request: dingtalkedu__1__0_models.GetOpenCoursesRequest,
        headers: dingtalkedu__1__0_models.GetOpenCoursesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetOpenCoursesResponse:
        """
        @summary 获取通过审核的课程列表
        
        @param request: GetOpenCoursesRequest
        @param headers: GetOpenCoursesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetOpenCoursesResponse
        """
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
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetOpenCourses',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/openCourses',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetOpenCoursesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_open_courses(
        self,
        request: dingtalkedu__1__0_models.GetOpenCoursesRequest,
    ) -> dingtalkedu__1__0_models.GetOpenCoursesResponse:
        """
        @summary 获取通过审核的课程列表
        
        @param request: GetOpenCoursesRequest
        @return: GetOpenCoursesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetOpenCoursesHeaders()
        return self.get_open_courses_with_options(request, headers, runtime)

    async def get_open_courses_async(
        self,
        request: dingtalkedu__1__0_models.GetOpenCoursesRequest,
    ) -> dingtalkedu__1__0_models.GetOpenCoursesResponse:
        """
        @summary 获取通过审核的课程列表
        
        @param request: GetOpenCoursesRequest
        @return: GetOpenCoursesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetOpenCoursesHeaders()
        return await self.get_open_courses_with_options_async(request, headers, runtime)

    def get_point_action_record_with_options(
        self,
        tmp_req: dingtalkedu__1__0_models.GetPointActionRecordRequest,
        headers: dingtalkedu__1__0_models.GetPointActionRecordHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetPointActionRecordResponse:
        """
        @summary 查询教育积分流水记录
        
        @param tmp_req: GetPointActionRecordRequest
        @param headers: GetPointActionRecordHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetPointActionRecordResponse
        """
        UtilClient.validate_model(tmp_req)
        request = dingtalkedu__1__0_models.GetPointActionRecordShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.body):
            request.body_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.body, 'body', 'json')
        query = {}
        if not UtilClient.is_unset(request.body_shrink):
            query['body'] = request.body_shrink
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
            action='GetPointActionRecord',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/points/actionRecords',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetPointActionRecordResponse(),
            self.execute(params, req, runtime)
        )

    async def get_point_action_record_with_options_async(
        self,
        tmp_req: dingtalkedu__1__0_models.GetPointActionRecordRequest,
        headers: dingtalkedu__1__0_models.GetPointActionRecordHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetPointActionRecordResponse:
        """
        @summary 查询教育积分流水记录
        
        @param tmp_req: GetPointActionRecordRequest
        @param headers: GetPointActionRecordHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetPointActionRecordResponse
        """
        UtilClient.validate_model(tmp_req)
        request = dingtalkedu__1__0_models.GetPointActionRecordShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.body):
            request.body_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.body, 'body', 'json')
        query = {}
        if not UtilClient.is_unset(request.body_shrink):
            query['body'] = request.body_shrink
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
            action='GetPointActionRecord',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/points/actionRecords',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetPointActionRecordResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_point_action_record(
        self,
        request: dingtalkedu__1__0_models.GetPointActionRecordRequest,
    ) -> dingtalkedu__1__0_models.GetPointActionRecordResponse:
        """
        @summary 查询教育积分流水记录
        
        @param request: GetPointActionRecordRequest
        @return: GetPointActionRecordResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetPointActionRecordHeaders()
        return self.get_point_action_record_with_options(request, headers, runtime)

    async def get_point_action_record_async(
        self,
        request: dingtalkedu__1__0_models.GetPointActionRecordRequest,
    ) -> dingtalkedu__1__0_models.GetPointActionRecordResponse:
        """
        @summary 查询教育积分流水记录
        
        @param request: GetPointActionRecordRequest
        @return: GetPointActionRecordResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetPointActionRecordHeaders()
        return await self.get_point_action_record_with_options_async(request, headers, runtime)

    def get_point_info_with_options(
        self,
        request: dingtalkedu__1__0_models.GetPointInfoRequest,
        headers: dingtalkedu__1__0_models.GetPointInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetPointInfoResponse:
        """
        @summary 查询教育积分信息
        
        @param request: GetPointInfoRequest
        @param headers: GetPointInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetPointInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.point_type):
            query['pointType'] = request.point_type
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
            action='GetPointInfo',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/points/infos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetPointInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def get_point_info_with_options_async(
        self,
        request: dingtalkedu__1__0_models.GetPointInfoRequest,
        headers: dingtalkedu__1__0_models.GetPointInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetPointInfoResponse:
        """
        @summary 查询教育积分信息
        
        @param request: GetPointInfoRequest
        @param headers: GetPointInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetPointInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.point_type):
            query['pointType'] = request.point_type
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
            action='GetPointInfo',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/points/infos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetPointInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_point_info(
        self,
        request: dingtalkedu__1__0_models.GetPointInfoRequest,
    ) -> dingtalkedu__1__0_models.GetPointInfoResponse:
        """
        @summary 查询教育积分信息
        
        @param request: GetPointInfoRequest
        @return: GetPointInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetPointInfoHeaders()
        return self.get_point_info_with_options(request, headers, runtime)

    async def get_point_info_async(
        self,
        request: dingtalkedu__1__0_models.GetPointInfoRequest,
    ) -> dingtalkedu__1__0_models.GetPointInfoResponse:
        """
        @summary 查询教育积分信息
        
        @param request: GetPointInfoRequest
        @return: GetPointInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetPointInfoHeaders()
        return await self.get_point_info_with_options_async(request, headers, runtime)

    def get_remote_class_course_with_options(
        self,
        course_code: str,
        request: dingtalkedu__1__0_models.GetRemoteClassCourseRequest,
        headers: dingtalkedu__1__0_models.GetRemoteClassCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetRemoteClassCourseResponse:
        """
        @summary 查询专递课堂课程详情
        
        @param request: GetRemoteClassCourseRequest
        @param headers: GetRemoteClassCourseHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetRemoteClassCourseResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
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
            action='GetRemoteClassCourse',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/remoteClasses/courses/{course_code}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetRemoteClassCourseResponse(),
            self.execute(params, req, runtime)
        )

    async def get_remote_class_course_with_options_async(
        self,
        course_code: str,
        request: dingtalkedu__1__0_models.GetRemoteClassCourseRequest,
        headers: dingtalkedu__1__0_models.GetRemoteClassCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetRemoteClassCourseResponse:
        """
        @summary 查询专递课堂课程详情
        
        @param request: GetRemoteClassCourseRequest
        @param headers: GetRemoteClassCourseHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetRemoteClassCourseResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
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
            action='GetRemoteClassCourse',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/remoteClasses/courses/{course_code}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetRemoteClassCourseResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_remote_class_course(
        self,
        course_code: str,
        request: dingtalkedu__1__0_models.GetRemoteClassCourseRequest,
    ) -> dingtalkedu__1__0_models.GetRemoteClassCourseResponse:
        """
        @summary 查询专递课堂课程详情
        
        @param request: GetRemoteClassCourseRequest
        @return: GetRemoteClassCourseResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetRemoteClassCourseHeaders()
        return self.get_remote_class_course_with_options(course_code, request, headers, runtime)

    async def get_remote_class_course_async(
        self,
        course_code: str,
        request: dingtalkedu__1__0_models.GetRemoteClassCourseRequest,
    ) -> dingtalkedu__1__0_models.GetRemoteClassCourseResponse:
        """
        @summary 查询专递课堂课程详情
        
        @param request: GetRemoteClassCourseRequest
        @return: GetRemoteClassCourseResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetRemoteClassCourseHeaders()
        return await self.get_remote_class_course_with_options_async(course_code, request, headers, runtime)

    def get_share_role_members_with_options(
        self,
        share_role_code: str,
        headers: dingtalkedu__1__0_models.GetShareRoleMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetShareRoleMembersResponse:
        """
        @summary 获取共享角色成员
        
        @param headers: GetShareRoleMembersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetShareRoleMembersResponse
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
            action='GetShareRoleMembers',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/shareRoles/{share_role_code}/members',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetShareRoleMembersResponse(),
            self.execute(params, req, runtime)
        )

    async def get_share_role_members_with_options_async(
        self,
        share_role_code: str,
        headers: dingtalkedu__1__0_models.GetShareRoleMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetShareRoleMembersResponse:
        """
        @summary 获取共享角色成员
        
        @param headers: GetShareRoleMembersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetShareRoleMembersResponse
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
            action='GetShareRoleMembers',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/shareRoles/{share_role_code}/members',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetShareRoleMembersResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_share_role_members(
        self,
        share_role_code: str,
    ) -> dingtalkedu__1__0_models.GetShareRoleMembersResponse:
        """
        @summary 获取共享角色成员
        
        @return: GetShareRoleMembersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetShareRoleMembersHeaders()
        return self.get_share_role_members_with_options(share_role_code, headers, runtime)

    async def get_share_role_members_async(
        self,
        share_role_code: str,
    ) -> dingtalkedu__1__0_models.GetShareRoleMembersResponse:
        """
        @summary 获取共享角色成员
        
        @return: GetShareRoleMembersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetShareRoleMembersHeaders()
        return await self.get_share_role_members_with_options_async(share_role_code, headers, runtime)

    def get_share_roles_with_options(
        self,
        headers: dingtalkedu__1__0_models.GetShareRolesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetShareRolesResponse:
        """
        @summary 获取教育局的共享角色列表
        
        @param headers: GetShareRolesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetShareRolesResponse
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
            action='GetShareRoles',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/shareRoles',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetShareRolesResponse(),
            self.execute(params, req, runtime)
        )

    async def get_share_roles_with_options_async(
        self,
        headers: dingtalkedu__1__0_models.GetShareRolesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetShareRolesResponse:
        """
        @summary 获取教育局的共享角色列表
        
        @param headers: GetShareRolesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetShareRolesResponse
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
            action='GetShareRoles',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/shareRoles',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetShareRolesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_share_roles(self) -> dingtalkedu__1__0_models.GetShareRolesResponse:
        """
        @summary 获取教育局的共享角色列表
        
        @return: GetShareRolesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetShareRolesHeaders()
        return self.get_share_roles_with_options(headers, runtime)

    async def get_share_roles_async(self) -> dingtalkedu__1__0_models.GetShareRolesResponse:
        """
        @summary 获取教育局的共享角色列表
        
        @return: GetShareRolesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetShareRolesHeaders()
        return await self.get_share_roles_with_options_async(headers, runtime)

    def get_task_list_with_options(
        self,
        request: dingtalkedu__1__0_models.GetTaskListRequest,
        headers: dingtalkedu__1__0_models.GetTaskListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetTaskListResponse:
        """
        @summary 查询入学任务列表
        
        @param request: GetTaskListRequest
        @param headers: GetTaskListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetTaskListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.task_year):
            query['taskYear'] = request.task_year
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
            action='GetTaskList',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/newGrades/tasks/lists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetTaskListResponse(),
            self.execute(params, req, runtime)
        )

    async def get_task_list_with_options_async(
        self,
        request: dingtalkedu__1__0_models.GetTaskListRequest,
        headers: dingtalkedu__1__0_models.GetTaskListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetTaskListResponse:
        """
        @summary 查询入学任务列表
        
        @param request: GetTaskListRequest
        @param headers: GetTaskListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetTaskListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.task_year):
            query['taskYear'] = request.task_year
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
            action='GetTaskList',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/newGrades/tasks/lists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetTaskListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_task_list(
        self,
        request: dingtalkedu__1__0_models.GetTaskListRequest,
    ) -> dingtalkedu__1__0_models.GetTaskListResponse:
        """
        @summary 查询入学任务列表
        
        @param request: GetTaskListRequest
        @return: GetTaskListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetTaskListHeaders()
        return self.get_task_list_with_options(request, headers, runtime)

    async def get_task_list_async(
        self,
        request: dingtalkedu__1__0_models.GetTaskListRequest,
    ) -> dingtalkedu__1__0_models.GetTaskListResponse:
        """
        @summary 查询入学任务列表
        
        @param request: GetTaskListRequest
        @return: GetTaskListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetTaskListHeaders()
        return await self.get_task_list_with_options_async(request, headers, runtime)

    def get_task_student_list_with_options(
        self,
        request: dingtalkedu__1__0_models.GetTaskStudentListRequest,
        headers: dingtalkedu__1__0_models.GetTaskStudentListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetTaskStudentListResponse:
        """
        @summary 获取入学任务下的学生列表
        
        @param request: GetTaskStudentListRequest
        @param headers: GetTaskStudentListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetTaskStudentListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.task_id):
            query['taskId'] = request.task_id
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
            action='GetTaskStudentList',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/newGrades/tasks/students/lists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetTaskStudentListResponse(),
            self.execute(params, req, runtime)
        )

    async def get_task_student_list_with_options_async(
        self,
        request: dingtalkedu__1__0_models.GetTaskStudentListRequest,
        headers: dingtalkedu__1__0_models.GetTaskStudentListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetTaskStudentListResponse:
        """
        @summary 获取入学任务下的学生列表
        
        @param request: GetTaskStudentListRequest
        @param headers: GetTaskStudentListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetTaskStudentListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.task_id):
            query['taskId'] = request.task_id
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
            action='GetTaskStudentList',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/newGrades/tasks/students/lists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetTaskStudentListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_task_student_list(
        self,
        request: dingtalkedu__1__0_models.GetTaskStudentListRequest,
    ) -> dingtalkedu__1__0_models.GetTaskStudentListResponse:
        """
        @summary 获取入学任务下的学生列表
        
        @param request: GetTaskStudentListRequest
        @return: GetTaskStudentListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetTaskStudentListHeaders()
        return self.get_task_student_list_with_options(request, headers, runtime)

    async def get_task_student_list_async(
        self,
        request: dingtalkedu__1__0_models.GetTaskStudentListRequest,
    ) -> dingtalkedu__1__0_models.GetTaskStudentListResponse:
        """
        @summary 获取入学任务下的学生列表
        
        @param request: GetTaskStudentListRequest
        @return: GetTaskStudentListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetTaskStudentListHeaders()
        return await self.get_task_student_list_with_options_async(request, headers, runtime)

    def init_courses_of_class_with_options(
        self,
        class_id: str,
        request: dingtalkedu__1__0_models.InitCoursesOfClassRequest,
        headers: dingtalkedu__1__0_models.InitCoursesOfClassHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.InitCoursesOfClassResponse:
        """
        @summary 初始化班级课程表
        
        @param request: InitCoursesOfClassRequest
        @param headers: InitCoursesOfClassHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: InitCoursesOfClassResponse
        """
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
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='InitCoursesOfClass',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/classes/{class_id}/courses/init',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.InitCoursesOfClassResponse(),
            self.execute(params, req, runtime)
        )

    async def init_courses_of_class_with_options_async(
        self,
        class_id: str,
        request: dingtalkedu__1__0_models.InitCoursesOfClassRequest,
        headers: dingtalkedu__1__0_models.InitCoursesOfClassHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.InitCoursesOfClassResponse:
        """
        @summary 初始化班级课程表
        
        @param request: InitCoursesOfClassRequest
        @param headers: InitCoursesOfClassHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: InitCoursesOfClassResponse
        """
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
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='InitCoursesOfClass',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/classes/{class_id}/courses/init',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.InitCoursesOfClassResponse(),
            await self.execute_async(params, req, runtime)
        )

    def init_courses_of_class(
        self,
        class_id: str,
        request: dingtalkedu__1__0_models.InitCoursesOfClassRequest,
    ) -> dingtalkedu__1__0_models.InitCoursesOfClassResponse:
        """
        @summary 初始化班级课程表
        
        @param request: InitCoursesOfClassRequest
        @return: InitCoursesOfClassResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.InitCoursesOfClassHeaders()
        return self.init_courses_of_class_with_options(class_id, request, headers, runtime)

    async def init_courses_of_class_async(
        self,
        class_id: str,
        request: dingtalkedu__1__0_models.InitCoursesOfClassRequest,
    ) -> dingtalkedu__1__0_models.InitCoursesOfClassResponse:
        """
        @summary 初始化班级课程表
        
        @param request: InitCoursesOfClassRequest
        @return: InitCoursesOfClassResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.InitCoursesOfClassHeaders()
        return await self.init_courses_of_class_with_options_async(class_id, request, headers, runtime)

    def init_device_with_options(
        self,
        request: dingtalkedu__1__0_models.InitDeviceRequest,
        headers: dingtalkedu__1__0_models.InitDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.InitDeviceResponse:
        """
        @summary 设备启动注册
        
        @param request: InitDeviceRequest
        @param headers: InitDeviceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: InitDeviceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.encrypt_pub_key):
            body['encryptPubKey'] = request.encrypt_pub_key
        if not UtilClient.is_unset(request.signature):
            body['signature'] = request.signature
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
        if not UtilClient.is_unset(request.timestamp):
            body['timestamp'] = request.timestamp
        if not UtilClient.is_unset(request.version):
            body['version'] = request.version
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
            action='InitDevice',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/devices/init',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.InitDeviceResponse(),
            self.execute(params, req, runtime)
        )

    async def init_device_with_options_async(
        self,
        request: dingtalkedu__1__0_models.InitDeviceRequest,
        headers: dingtalkedu__1__0_models.InitDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.InitDeviceResponse:
        """
        @summary 设备启动注册
        
        @param request: InitDeviceRequest
        @param headers: InitDeviceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: InitDeviceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.encrypt_pub_key):
            body['encryptPubKey'] = request.encrypt_pub_key
        if not UtilClient.is_unset(request.signature):
            body['signature'] = request.signature
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
        if not UtilClient.is_unset(request.timestamp):
            body['timestamp'] = request.timestamp
        if not UtilClient.is_unset(request.version):
            body['version'] = request.version
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
            action='InitDevice',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/devices/init',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.InitDeviceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def init_device(
        self,
        request: dingtalkedu__1__0_models.InitDeviceRequest,
    ) -> dingtalkedu__1__0_models.InitDeviceResponse:
        """
        @summary 设备启动注册
        
        @param request: InitDeviceRequest
        @return: InitDeviceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.InitDeviceHeaders()
        return self.init_device_with_options(request, headers, runtime)

    async def init_device_async(
        self,
        request: dingtalkedu__1__0_models.InitDeviceRequest,
    ) -> dingtalkedu__1__0_models.InitDeviceResponse:
        """
        @summary 设备启动注册
        
        @param request: InitDeviceRequest
        @return: InitDeviceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.InitDeviceHeaders()
        return await self.init_device_with_options_async(request, headers, runtime)

    def init_vpaas_device_with_options(
        self,
        request: dingtalkedu__1__0_models.InitVPaasDeviceRequest,
        headers: dingtalkedu__1__0_models.InitVPaasDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.InitVPaasDeviceResponse:
        """
        @summary 视讯paas机具初始化
        
        @param request: InitVPaasDeviceRequest
        @param headers: InitVPaasDeviceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: InitVPaasDeviceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
        if not UtilClient.is_unset(request.timestamp):
            body['timestamp'] = request.timestamp
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
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
            action='InitVPaasDevice',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/vpaas/devices/init',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.InitVPaasDeviceResponse(),
            self.execute(params, req, runtime)
        )

    async def init_vpaas_device_with_options_async(
        self,
        request: dingtalkedu__1__0_models.InitVPaasDeviceRequest,
        headers: dingtalkedu__1__0_models.InitVPaasDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.InitVPaasDeviceResponse:
        """
        @summary 视讯paas机具初始化
        
        @param request: InitVPaasDeviceRequest
        @param headers: InitVPaasDeviceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: InitVPaasDeviceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
        if not UtilClient.is_unset(request.timestamp):
            body['timestamp'] = request.timestamp
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
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
            action='InitVPaasDevice',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/vpaas/devices/init',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.InitVPaasDeviceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def init_vpaas_device(
        self,
        request: dingtalkedu__1__0_models.InitVPaasDeviceRequest,
    ) -> dingtalkedu__1__0_models.InitVPaasDeviceResponse:
        """
        @summary 视讯paas机具初始化
        
        @param request: InitVPaasDeviceRequest
        @return: InitVPaasDeviceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.InitVPaasDeviceHeaders()
        return self.init_vpaas_device_with_options(request, headers, runtime)

    async def init_vpaas_device_async(
        self,
        request: dingtalkedu__1__0_models.InitVPaasDeviceRequest,
    ) -> dingtalkedu__1__0_models.InitVPaasDeviceResponse:
        """
        @summary 视讯paas机具初始化
        
        @param request: InitVPaasDeviceRequest
        @return: InitVPaasDeviceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.InitVPaasDeviceHeaders()
        return await self.init_vpaas_device_with_options_async(request, headers, runtime)

    def insert_section_config_with_options(
        self,
        request: dingtalkedu__1__0_models.InsertSectionConfigRequest,
        headers: dingtalkedu__1__0_models.InsertSectionConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.InsertSectionConfigResponse:
        """
        @summary 插入学校维度节次设置
        
        @param request: InsertSectionConfigRequest
        @param headers: InsertSectionConfigHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: InsertSectionConfigResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.end):
            body['end'] = request.end
        if not UtilClient.is_unset(request.schedule_name):
            body['scheduleName'] = request.schedule_name
        if not UtilClient.is_unset(request.section_models):
            body['sectionModels'] = request.section_models
        if not UtilClient.is_unset(request.start):
            body['start'] = request.start
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
            action='InsertSectionConfig',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/schedules/configs',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.InsertSectionConfigResponse(),
            self.execute(params, req, runtime)
        )

    async def insert_section_config_with_options_async(
        self,
        request: dingtalkedu__1__0_models.InsertSectionConfigRequest,
        headers: dingtalkedu__1__0_models.InsertSectionConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.InsertSectionConfigResponse:
        """
        @summary 插入学校维度节次设置
        
        @param request: InsertSectionConfigRequest
        @param headers: InsertSectionConfigHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: InsertSectionConfigResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.end):
            body['end'] = request.end
        if not UtilClient.is_unset(request.schedule_name):
            body['scheduleName'] = request.schedule_name
        if not UtilClient.is_unset(request.section_models):
            body['sectionModels'] = request.section_models
        if not UtilClient.is_unset(request.start):
            body['start'] = request.start
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
            action='InsertSectionConfig',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/schedules/configs',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.InsertSectionConfigResponse(),
            await self.execute_async(params, req, runtime)
        )

    def insert_section_config(
        self,
        request: dingtalkedu__1__0_models.InsertSectionConfigRequest,
    ) -> dingtalkedu__1__0_models.InsertSectionConfigResponse:
        """
        @summary 插入学校维度节次设置
        
        @param request: InsertSectionConfigRequest
        @return: InsertSectionConfigResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.InsertSectionConfigHeaders()
        return self.insert_section_config_with_options(request, headers, runtime)

    async def insert_section_config_async(
        self,
        request: dingtalkedu__1__0_models.InsertSectionConfigRequest,
    ) -> dingtalkedu__1__0_models.InsertSectionConfigResponse:
        """
        @summary 插入学校维度节次设置
        
        @param request: InsertSectionConfigRequest
        @return: InsertSectionConfigResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.InsertSectionConfigHeaders()
        return await self.insert_section_config_with_options_async(request, headers, runtime)

    def invalid_course_with_options(
        self,
        request: dingtalkedu__1__0_models.InvalidCourseRequest,
        headers: dingtalkedu__1__0_models.InvalidCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.InvalidCourseResponse:
        """
        @summary 失效课程
        
        @param request: InvalidCourseRequest
        @param headers: InvalidCourseHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: InvalidCourseResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.class_id):
            body['classId'] = request.class_id
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.isv_course_id):
            body['isvCourseId'] = request.isv_course_id
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
            action='InvalidCourse',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/kits/courses/invalid',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.InvalidCourseResponse(),
            self.execute(params, req, runtime)
        )

    async def invalid_course_with_options_async(
        self,
        request: dingtalkedu__1__0_models.InvalidCourseRequest,
        headers: dingtalkedu__1__0_models.InvalidCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.InvalidCourseResponse:
        """
        @summary 失效课程
        
        @param request: InvalidCourseRequest
        @param headers: InvalidCourseHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: InvalidCourseResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.class_id):
            body['classId'] = request.class_id
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.isv_course_id):
            body['isvCourseId'] = request.isv_course_id
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
            action='InvalidCourse',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/kits/courses/invalid',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.InvalidCourseResponse(),
            await self.execute_async(params, req, runtime)
        )

    def invalid_course(
        self,
        request: dingtalkedu__1__0_models.InvalidCourseRequest,
    ) -> dingtalkedu__1__0_models.InvalidCourseResponse:
        """
        @summary 失效课程
        
        @param request: InvalidCourseRequest
        @return: InvalidCourseResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.InvalidCourseHeaders()
        return self.invalid_course_with_options(request, headers, runtime)

    async def invalid_course_async(
        self,
        request: dingtalkedu__1__0_models.InvalidCourseRequest,
    ) -> dingtalkedu__1__0_models.InvalidCourseResponse:
        """
        @summary 失效课程
        
        @param request: InvalidCourseRequest
        @return: InvalidCourseResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.InvalidCourseHeaders()
        return await self.invalid_course_with_options_async(request, headers, runtime)

    def invalid_kit_with_options(
        self,
        request: dingtalkedu__1__0_models.InvalidKitRequest,
        headers: dingtalkedu__1__0_models.InvalidKitHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.InvalidKitResponse:
        """
        @summary 失效教育套件
        
        @param request: InvalidKitRequest
        @param headers: InvalidKitHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: InvalidKitResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.isv_product_scene):
            body['isvProductScene'] = request.isv_product_scene
        if not UtilClient.is_unset(request.open_user_id):
            body['openUserId'] = request.open_user_id
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
            action='InvalidKit',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/kits/records/invalid',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.InvalidKitResponse(),
            self.execute(params, req, runtime)
        )

    async def invalid_kit_with_options_async(
        self,
        request: dingtalkedu__1__0_models.InvalidKitRequest,
        headers: dingtalkedu__1__0_models.InvalidKitHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.InvalidKitResponse:
        """
        @summary 失效教育套件
        
        @param request: InvalidKitRequest
        @param headers: InvalidKitHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: InvalidKitResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.isv_product_scene):
            body['isvProductScene'] = request.isv_product_scene
        if not UtilClient.is_unset(request.open_user_id):
            body['openUserId'] = request.open_user_id
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
            action='InvalidKit',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/kits/records/invalid',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.InvalidKitResponse(),
            await self.execute_async(params, req, runtime)
        )

    def invalid_kit(
        self,
        request: dingtalkedu__1__0_models.InvalidKitRequest,
    ) -> dingtalkedu__1__0_models.InvalidKitResponse:
        """
        @summary 失效教育套件
        
        @param request: InvalidKitRequest
        @return: InvalidKitResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.InvalidKitHeaders()
        return self.invalid_kit_with_options(request, headers, runtime)

    async def invalid_kit_async(
        self,
        request: dingtalkedu__1__0_models.InvalidKitRequest,
    ) -> dingtalkedu__1__0_models.InvalidKitResponse:
        """
        @summary 失效教育套件
        
        @param request: InvalidKitRequest
        @return: InvalidKitResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.InvalidKitHeaders()
        return await self.invalid_kit_with_options_async(request, headers, runtime)

    def invalid_student_class_with_options(
        self,
        request: dingtalkedu__1__0_models.InvalidStudentClassRequest,
        headers: dingtalkedu__1__0_models.InvalidStudentClassHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.InvalidStudentClassResponse:
        """
        @summary 删除学生班级
        
        @param request: InvalidStudentClassRequest
        @param headers: InvalidStudentClassHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: InvalidStudentClassResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.class_id):
            body['classId'] = request.class_id
        if not UtilClient.is_unset(request.class_type):
            body['classType'] = request.class_type
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.student_user_ids):
            body['studentUserIds'] = request.student_user_ids
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
            action='InvalidStudentClass',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/kits/students/classes/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.InvalidStudentClassResponse(),
            self.execute(params, req, runtime)
        )

    async def invalid_student_class_with_options_async(
        self,
        request: dingtalkedu__1__0_models.InvalidStudentClassRequest,
        headers: dingtalkedu__1__0_models.InvalidStudentClassHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.InvalidStudentClassResponse:
        """
        @summary 删除学生班级
        
        @param request: InvalidStudentClassRequest
        @param headers: InvalidStudentClassHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: InvalidStudentClassResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.class_id):
            body['classId'] = request.class_id
        if not UtilClient.is_unset(request.class_type):
            body['classType'] = request.class_type
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.student_user_ids):
            body['studentUserIds'] = request.student_user_ids
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
            action='InvalidStudentClass',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/kits/students/classes/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.InvalidStudentClassResponse(),
            await self.execute_async(params, req, runtime)
        )

    def invalid_student_class(
        self,
        request: dingtalkedu__1__0_models.InvalidStudentClassRequest,
    ) -> dingtalkedu__1__0_models.InvalidStudentClassResponse:
        """
        @summary 删除学生班级
        
        @param request: InvalidStudentClassRequest
        @return: InvalidStudentClassResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.InvalidStudentClassHeaders()
        return self.invalid_student_class_with_options(request, headers, runtime)

    async def invalid_student_class_async(
        self,
        request: dingtalkedu__1__0_models.InvalidStudentClassRequest,
    ) -> dingtalkedu__1__0_models.InvalidStudentClassResponse:
        """
        @summary 删除学生班级
        
        @param request: InvalidStudentClassRequest
        @return: InvalidStudentClassResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.InvalidStudentClassHeaders()
        return await self.invalid_student_class_with_options_async(request, headers, runtime)

    def invalid_teacher_course_with_options(
        self,
        request: dingtalkedu__1__0_models.InvalidTeacherCourseRequest,
        headers: dingtalkedu__1__0_models.InvalidTeacherCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.InvalidTeacherCourseResponse:
        """
        @summary 删除老师课程
        
        @param request: InvalidTeacherCourseRequest
        @param headers: InvalidTeacherCourseHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: InvalidTeacherCourseResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.need_delete_course_id_list):
            body['needDeleteCourseIdList'] = request.need_delete_course_id_list
        if not UtilClient.is_unset(request.teacher_user_id):
            body['teacherUserId'] = request.teacher_user_id
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
            action='InvalidTeacherCourse',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/kits/teachers/courses/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.InvalidTeacherCourseResponse(),
            self.execute(params, req, runtime)
        )

    async def invalid_teacher_course_with_options_async(
        self,
        request: dingtalkedu__1__0_models.InvalidTeacherCourseRequest,
        headers: dingtalkedu__1__0_models.InvalidTeacherCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.InvalidTeacherCourseResponse:
        """
        @summary 删除老师课程
        
        @param request: InvalidTeacherCourseRequest
        @param headers: InvalidTeacherCourseHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: InvalidTeacherCourseResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.need_delete_course_id_list):
            body['needDeleteCourseIdList'] = request.need_delete_course_id_list
        if not UtilClient.is_unset(request.teacher_user_id):
            body['teacherUserId'] = request.teacher_user_id
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
            action='InvalidTeacherCourse',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/kits/teachers/courses/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.InvalidTeacherCourseResponse(),
            await self.execute_async(params, req, runtime)
        )

    def invalid_teacher_course(
        self,
        request: dingtalkedu__1__0_models.InvalidTeacherCourseRequest,
    ) -> dingtalkedu__1__0_models.InvalidTeacherCourseResponse:
        """
        @summary 删除老师课程
        
        @param request: InvalidTeacherCourseRequest
        @return: InvalidTeacherCourseResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.InvalidTeacherCourseHeaders()
        return self.invalid_teacher_course_with_options(request, headers, runtime)

    async def invalid_teacher_course_async(
        self,
        request: dingtalkedu__1__0_models.InvalidTeacherCourseRequest,
    ) -> dingtalkedu__1__0_models.InvalidTeacherCourseResponse:
        """
        @summary 删除老师课程
        
        @param request: InvalidTeacherCourseRequest
        @return: InvalidTeacherCourseResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.InvalidTeacherCourseHeaders()
        return await self.invalid_teacher_course_with_options_async(request, headers, runtime)

    def isv_data_write_with_options(
        self,
        request: dingtalkedu__1__0_models.IsvDataWriteRequest,
        headers: dingtalkedu__1__0_models.IsvDataWriteHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.IsvDataWriteResponse:
        """
        @summary 第三方数据写入
        
        @param request: IsvDataWriteRequest
        @param headers: IsvDataWriteHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: IsvDataWriteResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.object_code):
            body['objectCode'] = request.object_code
        if not UtilClient.is_unset(request.row_value_list):
            body['rowValueList'] = request.row_value_list
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
            action='IsvDataWrite',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/datas/write',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.IsvDataWriteResponse(),
            self.execute(params, req, runtime)
        )

    async def isv_data_write_with_options_async(
        self,
        request: dingtalkedu__1__0_models.IsvDataWriteRequest,
        headers: dingtalkedu__1__0_models.IsvDataWriteHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.IsvDataWriteResponse:
        """
        @summary 第三方数据写入
        
        @param request: IsvDataWriteRequest
        @param headers: IsvDataWriteHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: IsvDataWriteResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.object_code):
            body['objectCode'] = request.object_code
        if not UtilClient.is_unset(request.row_value_list):
            body['rowValueList'] = request.row_value_list
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
            action='IsvDataWrite',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/datas/write',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.IsvDataWriteResponse(),
            await self.execute_async(params, req, runtime)
        )

    def isv_data_write(
        self,
        request: dingtalkedu__1__0_models.IsvDataWriteRequest,
    ) -> dingtalkedu__1__0_models.IsvDataWriteResponse:
        """
        @summary 第三方数据写入
        
        @param request: IsvDataWriteRequest
        @return: IsvDataWriteResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.IsvDataWriteHeaders()
        return self.isv_data_write_with_options(request, headers, runtime)

    async def isv_data_write_async(
        self,
        request: dingtalkedu__1__0_models.IsvDataWriteRequest,
    ) -> dingtalkedu__1__0_models.IsvDataWriteResponse:
        """
        @summary 第三方数据写入
        
        @param request: IsvDataWriteRequest
        @return: IsvDataWriteResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.IsvDataWriteHeaders()
        return await self.isv_data_write_with_options_async(request, headers, runtime)

    def isv_metadata_query_with_options(
        self,
        request: dingtalkedu__1__0_models.IsvMetadataQueryRequest,
        headers: dingtalkedu__1__0_models.IsvMetadataQueryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.IsvMetadataQueryResponse:
        """
        @summary Isv查询元数据信息
        
        @param request: IsvMetadataQueryRequest
        @param headers: IsvMetadataQueryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: IsvMetadataQueryResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.object_code):
            query['objectCode'] = request.object_code
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
            action='IsvMetadataQuery',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/datas/metadatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.IsvMetadataQueryResponse(),
            self.execute(params, req, runtime)
        )

    async def isv_metadata_query_with_options_async(
        self,
        request: dingtalkedu__1__0_models.IsvMetadataQueryRequest,
        headers: dingtalkedu__1__0_models.IsvMetadataQueryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.IsvMetadataQueryResponse:
        """
        @summary Isv查询元数据信息
        
        @param request: IsvMetadataQueryRequest
        @param headers: IsvMetadataQueryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: IsvMetadataQueryResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.object_code):
            query['objectCode'] = request.object_code
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
            action='IsvMetadataQuery',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/datas/metadatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.IsvMetadataQueryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def isv_metadata_query(
        self,
        request: dingtalkedu__1__0_models.IsvMetadataQueryRequest,
    ) -> dingtalkedu__1__0_models.IsvMetadataQueryResponse:
        """
        @summary Isv查询元数据信息
        
        @param request: IsvMetadataQueryRequest
        @return: IsvMetadataQueryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.IsvMetadataQueryHeaders()
        return self.isv_metadata_query_with_options(request, headers, runtime)

    async def isv_metadata_query_async(
        self,
        request: dingtalkedu__1__0_models.IsvMetadataQueryRequest,
    ) -> dingtalkedu__1__0_models.IsvMetadataQueryResponse:
        """
        @summary Isv查询元数据信息
        
        @param request: IsvMetadataQueryRequest
        @return: IsvMetadataQueryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.IsvMetadataQueryHeaders()
        return await self.isv_metadata_query_with_options_async(request, headers, runtime)

    def list_college_contact_dept_type_config_with_options(
        self,
        request: dingtalkedu__1__0_models.ListCollegeContactDeptTypeConfigRequest,
        headers: dingtalkedu__1__0_models.ListCollegeContactDeptTypeConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.ListCollegeContactDeptTypeConfigResponse:
        """
        @summary 获取高校组织单元类型
        
        @param request: ListCollegeContactDeptTypeConfigRequest
        @param headers: ListCollegeContactDeptTypeConfigHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListCollegeContactDeptTypeConfigResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
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
            action='ListCollegeContactDeptTypeConfig',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/collegeContact/configs/deptTypes',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.ListCollegeContactDeptTypeConfigResponse(),
            self.execute(params, req, runtime)
        )

    async def list_college_contact_dept_type_config_with_options_async(
        self,
        request: dingtalkedu__1__0_models.ListCollegeContactDeptTypeConfigRequest,
        headers: dingtalkedu__1__0_models.ListCollegeContactDeptTypeConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.ListCollegeContactDeptTypeConfigResponse:
        """
        @summary 获取高校组织单元类型
        
        @param request: ListCollegeContactDeptTypeConfigRequest
        @param headers: ListCollegeContactDeptTypeConfigHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListCollegeContactDeptTypeConfigResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
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
            action='ListCollegeContactDeptTypeConfig',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/collegeContact/configs/deptTypes',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.ListCollegeContactDeptTypeConfigResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_college_contact_dept_type_config(
        self,
        request: dingtalkedu__1__0_models.ListCollegeContactDeptTypeConfigRequest,
    ) -> dingtalkedu__1__0_models.ListCollegeContactDeptTypeConfigResponse:
        """
        @summary 获取高校组织单元类型
        
        @param request: ListCollegeContactDeptTypeConfigRequest
        @return: ListCollegeContactDeptTypeConfigResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.ListCollegeContactDeptTypeConfigHeaders()
        return self.list_college_contact_dept_type_config_with_options(request, headers, runtime)

    async def list_college_contact_dept_type_config_async(
        self,
        request: dingtalkedu__1__0_models.ListCollegeContactDeptTypeConfigRequest,
    ) -> dingtalkedu__1__0_models.ListCollegeContactDeptTypeConfigResponse:
        """
        @summary 获取高校组织单元类型
        
        @param request: ListCollegeContactDeptTypeConfigRequest
        @return: ListCollegeContactDeptTypeConfigResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.ListCollegeContactDeptTypeConfigHeaders()
        return await self.list_college_contact_dept_type_config_with_options_async(request, headers, runtime)

    def list_college_contact_sub_depts_with_options(
        self,
        request: dingtalkedu__1__0_models.ListCollegeContactSubDeptsRequest,
        headers: dingtalkedu__1__0_models.ListCollegeContactSubDeptsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.ListCollegeContactSubDeptsResponse:
        """
        @summary 获取高校通讯录子组织单元列表
        
        @param request: ListCollegeContactSubDeptsRequest
        @param headers: ListCollegeContactSubDeptsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListCollegeContactSubDeptsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
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
            action='ListCollegeContactSubDepts',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/collegeContact/subDepts',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.ListCollegeContactSubDeptsResponse(),
            self.execute(params, req, runtime)
        )

    async def list_college_contact_sub_depts_with_options_async(
        self,
        request: dingtalkedu__1__0_models.ListCollegeContactSubDeptsRequest,
        headers: dingtalkedu__1__0_models.ListCollegeContactSubDeptsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.ListCollegeContactSubDeptsResponse:
        """
        @summary 获取高校通讯录子组织单元列表
        
        @param request: ListCollegeContactSubDeptsRequest
        @param headers: ListCollegeContactSubDeptsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListCollegeContactSubDeptsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
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
            action='ListCollegeContactSubDepts',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/collegeContact/subDepts',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.ListCollegeContactSubDeptsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_college_contact_sub_depts(
        self,
        request: dingtalkedu__1__0_models.ListCollegeContactSubDeptsRequest,
    ) -> dingtalkedu__1__0_models.ListCollegeContactSubDeptsResponse:
        """
        @summary 获取高校通讯录子组织单元列表
        
        @param request: ListCollegeContactSubDeptsRequest
        @return: ListCollegeContactSubDeptsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.ListCollegeContactSubDeptsHeaders()
        return self.list_college_contact_sub_depts_with_options(request, headers, runtime)

    async def list_college_contact_sub_depts_async(
        self,
        request: dingtalkedu__1__0_models.ListCollegeContactSubDeptsRequest,
    ) -> dingtalkedu__1__0_models.ListCollegeContactSubDeptsResponse:
        """
        @summary 获取高校通讯录子组织单元列表
        
        @param request: ListCollegeContactSubDeptsRequest
        @return: ListCollegeContactSubDeptsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.ListCollegeContactSubDeptsHeaders()
        return await self.list_college_contact_sub_depts_with_options_async(request, headers, runtime)

    def list_order_with_options(
        self,
        request: dingtalkedu__1__0_models.ListOrderRequest,
        headers: dingtalkedu__1__0_models.ListOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.ListOrderResponse:
        """
        @summary 查询订单
        
        @param request: ListOrderRequest
        @param headers: ListOrderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListOrderResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.create_time_end):
            body['createTimeEnd'] = request.create_time_end
        if not UtilClient.is_unset(request.create_time_start):
            body['createTimeStart'] = request.create_time_start
        if not UtilClient.is_unset(request.merchant_id):
            body['merchantId'] = request.merchant_id
        if not UtilClient.is_unset(request.order_no):
            body['orderNo'] = request.order_no
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.scene):
            body['scene'] = request.scene
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
        if not UtilClient.is_unset(request.trade_no):
            body['tradeNo'] = request.trade_no
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
            action='ListOrder',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/orders/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.ListOrderResponse(),
            self.execute(params, req, runtime)
        )

    async def list_order_with_options_async(
        self,
        request: dingtalkedu__1__0_models.ListOrderRequest,
        headers: dingtalkedu__1__0_models.ListOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.ListOrderResponse:
        """
        @summary 查询订单
        
        @param request: ListOrderRequest
        @param headers: ListOrderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListOrderResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.create_time_end):
            body['createTimeEnd'] = request.create_time_end
        if not UtilClient.is_unset(request.create_time_start):
            body['createTimeStart'] = request.create_time_start
        if not UtilClient.is_unset(request.merchant_id):
            body['merchantId'] = request.merchant_id
        if not UtilClient.is_unset(request.order_no):
            body['orderNo'] = request.order_no
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.scene):
            body['scene'] = request.scene
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
        if not UtilClient.is_unset(request.trade_no):
            body['tradeNo'] = request.trade_no
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
            action='ListOrder',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/orders/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.ListOrderResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_order(
        self,
        request: dingtalkedu__1__0_models.ListOrderRequest,
    ) -> dingtalkedu__1__0_models.ListOrderResponse:
        """
        @summary 查询订单
        
        @param request: ListOrderRequest
        @return: ListOrderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.ListOrderHeaders()
        return self.list_order_with_options(request, headers, runtime)

    async def list_order_async(
        self,
        request: dingtalkedu__1__0_models.ListOrderRequest,
    ) -> dingtalkedu__1__0_models.ListOrderResponse:
        """
        @summary 查询订单
        
        @param request: ListOrderRequest
        @return: ListOrderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.ListOrderHeaders()
        return await self.list_order_with_options_async(request, headers, runtime)

    def move_student_with_options(
        self,
        request: dingtalkedu__1__0_models.MoveStudentRequest,
        headers: dingtalkedu__1__0_models.MoveStudentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.MoveStudentResponse:
        """
        @summary 学生调班，如果学生在本班有对应的家长，则家长也会跟同学生进行调整班级。
        
        @param request: MoveStudentRequest
        @param headers: MoveStudentHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: MoveStudentResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        if not UtilClient.is_unset(request.origin_class_id):
            body['originClassId'] = request.origin_class_id
        if not UtilClient.is_unset(request.target_class_id):
            body['targetClassId'] = request.target_class_id
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
            action='MoveStudent',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/students/move',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.MoveStudentResponse(),
            self.execute(params, req, runtime)
        )

    async def move_student_with_options_async(
        self,
        request: dingtalkedu__1__0_models.MoveStudentRequest,
        headers: dingtalkedu__1__0_models.MoveStudentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.MoveStudentResponse:
        """
        @summary 学生调班，如果学生在本班有对应的家长，则家长也会跟同学生进行调整班级。
        
        @param request: MoveStudentRequest
        @param headers: MoveStudentHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: MoveStudentResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        if not UtilClient.is_unset(request.origin_class_id):
            body['originClassId'] = request.origin_class_id
        if not UtilClient.is_unset(request.target_class_id):
            body['targetClassId'] = request.target_class_id
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
            action='MoveStudent',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/students/move',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.MoveStudentResponse(),
            await self.execute_async(params, req, runtime)
        )

    def move_student(
        self,
        request: dingtalkedu__1__0_models.MoveStudentRequest,
    ) -> dingtalkedu__1__0_models.MoveStudentResponse:
        """
        @summary 学生调班，如果学生在本班有对应的家长，则家长也会跟同学生进行调整班级。
        
        @param request: MoveStudentRequest
        @return: MoveStudentResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.MoveStudentHeaders()
        return self.move_student_with_options(request, headers, runtime)

    async def move_student_async(
        self,
        request: dingtalkedu__1__0_models.MoveStudentRequest,
    ) -> dingtalkedu__1__0_models.MoveStudentResponse:
        """
        @summary 学生调班，如果学生在本班有对应的家长，则家长也会跟同学生进行调整班级。
        
        @param request: MoveStudentRequest
        @return: MoveStudentResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.MoveStudentHeaders()
        return await self.move_student_with_options_async(request, headers, runtime)

    def open_kit_with_options(
        self,
        request: dingtalkedu__1__0_models.OpenKitRequest,
        headers: dingtalkedu__1__0_models.OpenKitHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.OpenKitResponse:
        """
        @summary 开通教育套件
        
        @param request: OpenKitRequest
        @param headers: OpenKitHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: OpenKitResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.attributes):
            body['attributes'] = request.attributes
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.isv_product_scene):
            body['isvProductScene'] = request.isv_product_scene
        if not UtilClient.is_unset(request.open_end_time):
            body['openEndTime'] = request.open_end_time
        if not UtilClient.is_unset(request.open_start_time):
            body['openStartTime'] = request.open_start_time
        if not UtilClient.is_unset(request.open_user_id):
            body['openUserId'] = request.open_user_id
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
            action='OpenKit',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/kits/records/open',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.OpenKitResponse(),
            self.execute(params, req, runtime)
        )

    async def open_kit_with_options_async(
        self,
        request: dingtalkedu__1__0_models.OpenKitRequest,
        headers: dingtalkedu__1__0_models.OpenKitHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.OpenKitResponse:
        """
        @summary 开通教育套件
        
        @param request: OpenKitRequest
        @param headers: OpenKitHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: OpenKitResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.attributes):
            body['attributes'] = request.attributes
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.isv_product_scene):
            body['isvProductScene'] = request.isv_product_scene
        if not UtilClient.is_unset(request.open_end_time):
            body['openEndTime'] = request.open_end_time
        if not UtilClient.is_unset(request.open_start_time):
            body['openStartTime'] = request.open_start_time
        if not UtilClient.is_unset(request.open_user_id):
            body['openUserId'] = request.open_user_id
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
            action='OpenKit',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/kits/records/open',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.OpenKitResponse(),
            await self.execute_async(params, req, runtime)
        )

    def open_kit(
        self,
        request: dingtalkedu__1__0_models.OpenKitRequest,
    ) -> dingtalkedu__1__0_models.OpenKitResponse:
        """
        @summary 开通教育套件
        
        @param request: OpenKitRequest
        @return: OpenKitResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.OpenKitHeaders()
        return self.open_kit_with_options(request, headers, runtime)

    async def open_kit_async(
        self,
        request: dingtalkedu__1__0_models.OpenKitRequest,
    ) -> dingtalkedu__1__0_models.OpenKitResponse:
        """
        @summary 开通教育套件
        
        @param request: OpenKitRequest
        @return: OpenKitResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.OpenKitHeaders()
        return await self.open_kit_with_options_async(request, headers, runtime)

    def order_info_with_options(
        self,
        request: dingtalkedu__1__0_models.OrderInfoRequest,
        headers: dingtalkedu__1__0_models.OrderInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.OrderInfoResponse:
        """
        @summary 查询订单信息
        
        @param request: OrderInfoRequest
        @param headers: OrderInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: OrderInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.order_no):
            query['orderNo'] = request.order_no
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
            action='OrderInfo',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/dingLifes/orders',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.OrderInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def order_info_with_options_async(
        self,
        request: dingtalkedu__1__0_models.OrderInfoRequest,
        headers: dingtalkedu__1__0_models.OrderInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.OrderInfoResponse:
        """
        @summary 查询订单信息
        
        @param request: OrderInfoRequest
        @param headers: OrderInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: OrderInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.order_no):
            query['orderNo'] = request.order_no
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
            action='OrderInfo',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/dingLifes/orders',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.OrderInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def order_info(
        self,
        request: dingtalkedu__1__0_models.OrderInfoRequest,
    ) -> dingtalkedu__1__0_models.OrderInfoResponse:
        """
        @summary 查询订单信息
        
        @param request: OrderInfoRequest
        @return: OrderInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.OrderInfoHeaders()
        return self.order_info_with_options(request, headers, runtime)

    async def order_info_async(
        self,
        request: dingtalkedu__1__0_models.OrderInfoRequest,
    ) -> dingtalkedu__1__0_models.OrderInfoResponse:
        """
        @summary 查询订单信息
        
        @param request: OrderInfoRequest
        @return: OrderInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.OrderInfoHeaders()
        return await self.order_info_with_options_async(request, headers, runtime)

    def page_query_class_course_with_options(
        self,
        request: dingtalkedu__1__0_models.PageQueryClassCourseRequest,
        headers: dingtalkedu__1__0_models.PageQueryClassCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.PageQueryClassCourseResponse:
        """
        @summary 批量查询班级课表
        
        @param request: PageQueryClassCourseRequest
        @param headers: PageQueryClassCourseHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PageQueryClassCourseResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.class_id):
            body['classId'] = request.class_id
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.end_course_date):
            body['endCourseDate'] = request.end_course_date
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.start_course_date):
            body['startCourseDate'] = request.start_course_date
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
            action='PageQueryClassCourse',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/kits/classes/courses/batchQuery',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.PageQueryClassCourseResponse(),
            self.execute(params, req, runtime)
        )

    async def page_query_class_course_with_options_async(
        self,
        request: dingtalkedu__1__0_models.PageQueryClassCourseRequest,
        headers: dingtalkedu__1__0_models.PageQueryClassCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.PageQueryClassCourseResponse:
        """
        @summary 批量查询班级课表
        
        @param request: PageQueryClassCourseRequest
        @param headers: PageQueryClassCourseHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PageQueryClassCourseResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.class_id):
            body['classId'] = request.class_id
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.end_course_date):
            body['endCourseDate'] = request.end_course_date
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.start_course_date):
            body['startCourseDate'] = request.start_course_date
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
            action='PageQueryClassCourse',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/kits/classes/courses/batchQuery',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.PageQueryClassCourseResponse(),
            await self.execute_async(params, req, runtime)
        )

    def page_query_class_course(
        self,
        request: dingtalkedu__1__0_models.PageQueryClassCourseRequest,
    ) -> dingtalkedu__1__0_models.PageQueryClassCourseResponse:
        """
        @summary 批量查询班级课表
        
        @param request: PageQueryClassCourseRequest
        @return: PageQueryClassCourseResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.PageQueryClassCourseHeaders()
        return self.page_query_class_course_with_options(request, headers, runtime)

    async def page_query_class_course_async(
        self,
        request: dingtalkedu__1__0_models.PageQueryClassCourseRequest,
    ) -> dingtalkedu__1__0_models.PageQueryClassCourseResponse:
        """
        @summary 批量查询班级课表
        
        @param request: PageQueryClassCourseRequest
        @return: PageQueryClassCourseResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.PageQueryClassCourseHeaders()
        return await self.page_query_class_course_with_options_async(request, headers, runtime)

    def page_query_devices_with_options(
        self,
        request: dingtalkedu__1__0_models.PageQueryDevicesRequest,
        headers: dingtalkedu__1__0_models.PageQueryDevicesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.PageQueryDevicesResponse:
        """
        @summary 分页查询设备列表
        
        @param request: PageQueryDevicesRequest
        @param headers: PageQueryDevicesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PageQueryDevicesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.type):
            query['type'] = request.type
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
            action='PageQueryDevices',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/vpaas/devices',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.PageQueryDevicesResponse(),
            self.execute(params, req, runtime)
        )

    async def page_query_devices_with_options_async(
        self,
        request: dingtalkedu__1__0_models.PageQueryDevicesRequest,
        headers: dingtalkedu__1__0_models.PageQueryDevicesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.PageQueryDevicesResponse:
        """
        @summary 分页查询设备列表
        
        @param request: PageQueryDevicesRequest
        @param headers: PageQueryDevicesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PageQueryDevicesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.type):
            query['type'] = request.type
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
            action='PageQueryDevices',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/vpaas/devices',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.PageQueryDevicesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def page_query_devices(
        self,
        request: dingtalkedu__1__0_models.PageQueryDevicesRequest,
    ) -> dingtalkedu__1__0_models.PageQueryDevicesResponse:
        """
        @summary 分页查询设备列表
        
        @param request: PageQueryDevicesRequest
        @return: PageQueryDevicesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.PageQueryDevicesHeaders()
        return self.page_query_devices_with_options(request, headers, runtime)

    async def page_query_devices_async(
        self,
        request: dingtalkedu__1__0_models.PageQueryDevicesRequest,
    ) -> dingtalkedu__1__0_models.PageQueryDevicesResponse:
        """
        @summary 分页查询设备列表
        
        @param request: PageQueryDevicesRequest
        @return: PageQueryDevicesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.PageQueryDevicesHeaders()
        return await self.page_query_devices_with_options_async(request, headers, runtime)

    def page_query_kit_open_record_with_options(
        self,
        request: dingtalkedu__1__0_models.PageQueryKitOpenRecordRequest,
        headers: dingtalkedu__1__0_models.PageQueryKitOpenRecordHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.PageQueryKitOpenRecordResponse:
        """
        @summary 批量查询套件开通记录
        
        @param request: PageQueryKitOpenRecordRequest
        @param headers: PageQueryKitOpenRecordHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PageQueryKitOpenRecordResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.isv_product_scene):
            body['isvProductScene'] = request.isv_product_scene
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
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
            action='PageQueryKitOpenRecord',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/kits/records/batchQuery',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.PageQueryKitOpenRecordResponse(),
            self.execute(params, req, runtime)
        )

    async def page_query_kit_open_record_with_options_async(
        self,
        request: dingtalkedu__1__0_models.PageQueryKitOpenRecordRequest,
        headers: dingtalkedu__1__0_models.PageQueryKitOpenRecordHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.PageQueryKitOpenRecordResponse:
        """
        @summary 批量查询套件开通记录
        
        @param request: PageQueryKitOpenRecordRequest
        @param headers: PageQueryKitOpenRecordHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PageQueryKitOpenRecordResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.isv_product_scene):
            body['isvProductScene'] = request.isv_product_scene
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
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
            action='PageQueryKitOpenRecord',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/kits/records/batchQuery',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.PageQueryKitOpenRecordResponse(),
            await self.execute_async(params, req, runtime)
        )

    def page_query_kit_open_record(
        self,
        request: dingtalkedu__1__0_models.PageQueryKitOpenRecordRequest,
    ) -> dingtalkedu__1__0_models.PageQueryKitOpenRecordResponse:
        """
        @summary 批量查询套件开通记录
        
        @param request: PageQueryKitOpenRecordRequest
        @return: PageQueryKitOpenRecordResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.PageQueryKitOpenRecordHeaders()
        return self.page_query_kit_open_record_with_options(request, headers, runtime)

    async def page_query_kit_open_record_async(
        self,
        request: dingtalkedu__1__0_models.PageQueryKitOpenRecordRequest,
    ) -> dingtalkedu__1__0_models.PageQueryKitOpenRecordResponse:
        """
        @summary 批量查询套件开通记录
        
        @param request: PageQueryKitOpenRecordRequest
        @return: PageQueryKitOpenRecordResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.PageQueryKitOpenRecordHeaders()
        return await self.page_query_kit_open_record_with_options_async(request, headers, runtime)

    def pay_order_with_options(
        self,
        request: dingtalkedu__1__0_models.PayOrderRequest,
        headers: dingtalkedu__1__0_models.PayOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.PayOrderResponse:
        """
        @summary 支付订单
        
        @param request: PayOrderRequest
        @param headers: PayOrderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PayOrderResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.face_id):
            body['faceId'] = request.face_id
        if not UtilClient.is_unset(request.order_no):
            body['orderNo'] = request.order_no
        if not UtilClient.is_unset(request.signature):
            body['signature'] = request.signature
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
        if not UtilClient.is_unset(request.timestamp):
            body['timestamp'] = request.timestamp
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.version):
            body['version'] = request.version
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
            action='PayOrder',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/orders/pay',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.PayOrderResponse(),
            self.execute(params, req, runtime)
        )

    async def pay_order_with_options_async(
        self,
        request: dingtalkedu__1__0_models.PayOrderRequest,
        headers: dingtalkedu__1__0_models.PayOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.PayOrderResponse:
        """
        @summary 支付订单
        
        @param request: PayOrderRequest
        @param headers: PayOrderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PayOrderResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.face_id):
            body['faceId'] = request.face_id
        if not UtilClient.is_unset(request.order_no):
            body['orderNo'] = request.order_no
        if not UtilClient.is_unset(request.signature):
            body['signature'] = request.signature
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
        if not UtilClient.is_unset(request.timestamp):
            body['timestamp'] = request.timestamp
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.version):
            body['version'] = request.version
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
            action='PayOrder',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/orders/pay',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.PayOrderResponse(),
            await self.execute_async(params, req, runtime)
        )

    def pay_order(
        self,
        request: dingtalkedu__1__0_models.PayOrderRequest,
    ) -> dingtalkedu__1__0_models.PayOrderResponse:
        """
        @summary 支付订单
        
        @param request: PayOrderRequest
        @return: PayOrderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.PayOrderHeaders()
        return self.pay_order_with_options(request, headers, runtime)

    async def pay_order_async(
        self,
        request: dingtalkedu__1__0_models.PayOrderRequest,
    ) -> dingtalkedu__1__0_models.PayOrderResponse:
        """
        @summary 支付订单
        
        @param request: PayOrderRequest
        @return: PayOrderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.PayOrderHeaders()
        return await self.pay_order_with_options_async(request, headers, runtime)

    def polling_confirm_status_with_options(
        self,
        request: dingtalkedu__1__0_models.PollingConfirmStatusRequest,
        headers: dingtalkedu__1__0_models.PollingConfirmStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.PollingConfirmStatusResponse:
        """
        @summary 轮询课程状态，确认教师是否已同意开课
        
        @param request: PollingConfirmStatusRequest
        @param headers: PollingConfirmStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PollingConfirmStatusResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.course_code):
            query['courseCode'] = request.course_code
        if not UtilClient.is_unset(request.ext):
            query['ext'] = request.ext
        if not UtilClient.is_unset(request.isv_code):
            query['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
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
            action='PollingConfirmStatus',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/courses/pollingConfirmStatus',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.PollingConfirmStatusResponse(),
            self.execute(params, req, runtime)
        )

    async def polling_confirm_status_with_options_async(
        self,
        request: dingtalkedu__1__0_models.PollingConfirmStatusRequest,
        headers: dingtalkedu__1__0_models.PollingConfirmStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.PollingConfirmStatusResponse:
        """
        @summary 轮询课程状态，确认教师是否已同意开课
        
        @param request: PollingConfirmStatusRequest
        @param headers: PollingConfirmStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PollingConfirmStatusResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.course_code):
            query['courseCode'] = request.course_code
        if not UtilClient.is_unset(request.ext):
            query['ext'] = request.ext
        if not UtilClient.is_unset(request.isv_code):
            query['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
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
            action='PollingConfirmStatus',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/courses/pollingConfirmStatus',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.PollingConfirmStatusResponse(),
            await self.execute_async(params, req, runtime)
        )

    def polling_confirm_status(
        self,
        request: dingtalkedu__1__0_models.PollingConfirmStatusRequest,
    ) -> dingtalkedu__1__0_models.PollingConfirmStatusResponse:
        """
        @summary 轮询课程状态，确认教师是否已同意开课
        
        @param request: PollingConfirmStatusRequest
        @return: PollingConfirmStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.PollingConfirmStatusHeaders()
        return self.polling_confirm_status_with_options(request, headers, runtime)

    async def polling_confirm_status_async(
        self,
        request: dingtalkedu__1__0_models.PollingConfirmStatusRequest,
    ) -> dingtalkedu__1__0_models.PollingConfirmStatusResponse:
        """
        @summary 轮询课程状态，确认教师是否已同意开课
        
        @param request: PollingConfirmStatusRequest
        @return: PollingConfirmStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.PollingConfirmStatusHeaders()
        return await self.polling_confirm_status_with_options_async(request, headers, runtime)

    def pre_dial_with_options(
        self,
        request: dingtalkedu__1__0_models.PreDialRequest,
        headers: dingtalkedu__1__0_models.PreDialHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.PreDialResponse:
        """
        @summary 视讯paas机具预拨号
        
        @param request: PreDialRequest
        @param headers: PreDialHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PreDialResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.caller_user_id):
            body['callerUserId'] = request.caller_user_id
        if not UtilClient.is_unset(request.receiver_user_id):
            body['receiverUserId'] = request.receiver_user_id
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
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
            action='PreDial',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/vpaas/devices/preDial',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.PreDialResponse(),
            self.execute(params, req, runtime)
        )

    async def pre_dial_with_options_async(
        self,
        request: dingtalkedu__1__0_models.PreDialRequest,
        headers: dingtalkedu__1__0_models.PreDialHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.PreDialResponse:
        """
        @summary 视讯paas机具预拨号
        
        @param request: PreDialRequest
        @param headers: PreDialHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PreDialResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.caller_user_id):
            body['callerUserId'] = request.caller_user_id
        if not UtilClient.is_unset(request.receiver_user_id):
            body['receiverUserId'] = request.receiver_user_id
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
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
            action='PreDial',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/vpaas/devices/preDial',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.PreDialResponse(),
            await self.execute_async(params, req, runtime)
        )

    def pre_dial(
        self,
        request: dingtalkedu__1__0_models.PreDialRequest,
    ) -> dingtalkedu__1__0_models.PreDialResponse:
        """
        @summary 视讯paas机具预拨号
        
        @param request: PreDialRequest
        @return: PreDialResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.PreDialHeaders()
        return self.pre_dial_with_options(request, headers, runtime)

    async def pre_dial_async(
        self,
        request: dingtalkedu__1__0_models.PreDialRequest,
    ) -> dingtalkedu__1__0_models.PreDialResponse:
        """
        @summary 视讯paas机具预拨号
        
        @param request: PreDialRequest
        @return: PreDialResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.PreDialHeaders()
        return await self.pre_dial_with_options_async(request, headers, runtime)

    def provide_point_with_options(
        self,
        request: dingtalkedu__1__0_models.ProvidePointRequest,
        headers: dingtalkedu__1__0_models.ProvidePointHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.ProvidePointResponse:
        """
        @summary 发放教育积分
        
        @param request: ProvidePointRequest
        @param headers: ProvidePointHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ProvidePointResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action_code):
            body['actionCode'] = request.action_code
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.point_type):
            body['pointType'] = request.point_type
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
            action='ProvidePoint',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/points/provide',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.ProvidePointResponse(),
            self.execute(params, req, runtime)
        )

    async def provide_point_with_options_async(
        self,
        request: dingtalkedu__1__0_models.ProvidePointRequest,
        headers: dingtalkedu__1__0_models.ProvidePointHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.ProvidePointResponse:
        """
        @summary 发放教育积分
        
        @param request: ProvidePointRequest
        @param headers: ProvidePointHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ProvidePointResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action_code):
            body['actionCode'] = request.action_code
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.point_type):
            body['pointType'] = request.point_type
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
            action='ProvidePoint',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/points/provide',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.ProvidePointResponse(),
            await self.execute_async(params, req, runtime)
        )

    def provide_point(
        self,
        request: dingtalkedu__1__0_models.ProvidePointRequest,
    ) -> dingtalkedu__1__0_models.ProvidePointResponse:
        """
        @summary 发放教育积分
        
        @param request: ProvidePointRequest
        @return: ProvidePointResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.ProvidePointHeaders()
        return self.provide_point_with_options(request, headers, runtime)

    async def provide_point_async(
        self,
        request: dingtalkedu__1__0_models.ProvidePointRequest,
    ) -> dingtalkedu__1__0_models.ProvidePointResponse:
        """
        @summary 发放教育积分
        
        @param request: ProvidePointRequest
        @return: ProvidePointResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.ProvidePointHeaders()
        return await self.provide_point_with_options_async(request, headers, runtime)

    def query_all_subjects_from_class_schedule_with_options(
        self,
        tmp_req: dingtalkedu__1__0_models.QueryAllSubjectsFromClassScheduleRequest,
        headers: dingtalkedu__1__0_models.QueryAllSubjectsFromClassScheduleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryAllSubjectsFromClassScheduleResponse:
        """
        @summary 查询全量学科实例列表
        
        @param tmp_req: QueryAllSubjectsFromClassScheduleRequest
        @param headers: QueryAllSubjectsFromClassScheduleHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryAllSubjectsFromClassScheduleResponse
        """
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
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryAllSubjectsFromClassSchedule',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/subjects/instances',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryAllSubjectsFromClassScheduleResponse(),
            self.execute(params, req, runtime)
        )

    async def query_all_subjects_from_class_schedule_with_options_async(
        self,
        tmp_req: dingtalkedu__1__0_models.QueryAllSubjectsFromClassScheduleRequest,
        headers: dingtalkedu__1__0_models.QueryAllSubjectsFromClassScheduleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryAllSubjectsFromClassScheduleResponse:
        """
        @summary 查询全量学科实例列表
        
        @param tmp_req: QueryAllSubjectsFromClassScheduleRequest
        @param headers: QueryAllSubjectsFromClassScheduleHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryAllSubjectsFromClassScheduleResponse
        """
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
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryAllSubjectsFromClassSchedule',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/subjects/instances',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryAllSubjectsFromClassScheduleResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_all_subjects_from_class_schedule(
        self,
        request: dingtalkedu__1__0_models.QueryAllSubjectsFromClassScheduleRequest,
    ) -> dingtalkedu__1__0_models.QueryAllSubjectsFromClassScheduleResponse:
        """
        @summary 查询全量学科实例列表
        
        @param request: QueryAllSubjectsFromClassScheduleRequest
        @return: QueryAllSubjectsFromClassScheduleResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryAllSubjectsFromClassScheduleHeaders()
        return self.query_all_subjects_from_class_schedule_with_options(request, headers, runtime)

    async def query_all_subjects_from_class_schedule_async(
        self,
        request: dingtalkedu__1__0_models.QueryAllSubjectsFromClassScheduleRequest,
    ) -> dingtalkedu__1__0_models.QueryAllSubjectsFromClassScheduleResponse:
        """
        @summary 查询全量学科实例列表
        
        @param request: QueryAllSubjectsFromClassScheduleRequest
        @return: QueryAllSubjectsFromClassScheduleResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryAllSubjectsFromClassScheduleHeaders()
        return await self.query_all_subjects_from_class_schedule_with_options_async(request, headers, runtime)

    def query_class_schedule_with_options(
        self,
        request: dingtalkedu__1__0_models.QueryClassScheduleRequest,
        headers: dingtalkedu__1__0_models.QueryClassScheduleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryClassScheduleResponse:
        """
        @summary 查询课程表
        
        @param request: QueryClassScheduleRequest
        @param headers: QueryClassScheduleHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryClassScheduleResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.start_time):
            query['startTime'] = request.start_time
        if not UtilClient.is_unset(request.subscriber_type):
            query['subscriberType'] = request.subscriber_type
        body = {}
        if not UtilClient.is_unset(request.section_index_list):
            body['sectionIndexList'] = request.section_index_list
        if not UtilClient.is_unset(request.subscriber_ids):
            body['subscriberIds'] = request.subscriber_ids
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
            action='QueryClassSchedule',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/classes/schedules/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryClassScheduleResponse(),
            self.execute(params, req, runtime)
        )

    async def query_class_schedule_with_options_async(
        self,
        request: dingtalkedu__1__0_models.QueryClassScheduleRequest,
        headers: dingtalkedu__1__0_models.QueryClassScheduleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryClassScheduleResponse:
        """
        @summary 查询课程表
        
        @param request: QueryClassScheduleRequest
        @param headers: QueryClassScheduleHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryClassScheduleResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.start_time):
            query['startTime'] = request.start_time
        if not UtilClient.is_unset(request.subscriber_type):
            query['subscriberType'] = request.subscriber_type
        body = {}
        if not UtilClient.is_unset(request.section_index_list):
            body['sectionIndexList'] = request.section_index_list
        if not UtilClient.is_unset(request.subscriber_ids):
            body['subscriberIds'] = request.subscriber_ids
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
            action='QueryClassSchedule',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/classes/schedules/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryClassScheduleResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_class_schedule(
        self,
        request: dingtalkedu__1__0_models.QueryClassScheduleRequest,
    ) -> dingtalkedu__1__0_models.QueryClassScheduleResponse:
        """
        @summary 查询课程表
        
        @param request: QueryClassScheduleRequest
        @return: QueryClassScheduleResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryClassScheduleHeaders()
        return self.query_class_schedule_with_options(request, headers, runtime)

    async def query_class_schedule_async(
        self,
        request: dingtalkedu__1__0_models.QueryClassScheduleRequest,
    ) -> dingtalkedu__1__0_models.QueryClassScheduleResponse:
        """
        @summary 查询课程表
        
        @param request: QueryClassScheduleRequest
        @return: QueryClassScheduleResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryClassScheduleHeaders()
        return await self.query_class_schedule_with_options_async(request, headers, runtime)

    def query_class_schedule_by_time_school_with_options(
        self,
        request: dingtalkedu__1__0_models.QueryClassScheduleByTimeSchoolRequest,
        headers: dingtalkedu__1__0_models.QueryClassScheduleByTimeSchoolHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryClassScheduleByTimeSchoolResponse:
        """
        @summary 按照学校和时间区间筛选课程
        
        @param request: QueryClassScheduleByTimeSchoolRequest
        @param headers: QueryClassScheduleByTimeSchoolHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryClassScheduleByTimeSchoolResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
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
            action='QueryClassScheduleByTimeSchool',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/schools/classes/courses ',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryClassScheduleByTimeSchoolResponse(),
            self.execute(params, req, runtime)
        )

    async def query_class_schedule_by_time_school_with_options_async(
        self,
        request: dingtalkedu__1__0_models.QueryClassScheduleByTimeSchoolRequest,
        headers: dingtalkedu__1__0_models.QueryClassScheduleByTimeSchoolHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryClassScheduleByTimeSchoolResponse:
        """
        @summary 按照学校和时间区间筛选课程
        
        @param request: QueryClassScheduleByTimeSchoolRequest
        @param headers: QueryClassScheduleByTimeSchoolHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryClassScheduleByTimeSchoolResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
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
            action='QueryClassScheduleByTimeSchool',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/schools/classes/courses ',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryClassScheduleByTimeSchoolResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_class_schedule_by_time_school(
        self,
        request: dingtalkedu__1__0_models.QueryClassScheduleByTimeSchoolRequest,
    ) -> dingtalkedu__1__0_models.QueryClassScheduleByTimeSchoolResponse:
        """
        @summary 按照学校和时间区间筛选课程
        
        @param request: QueryClassScheduleByTimeSchoolRequest
        @return: QueryClassScheduleByTimeSchoolResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryClassScheduleByTimeSchoolHeaders()
        return self.query_class_schedule_by_time_school_with_options(request, headers, runtime)

    async def query_class_schedule_by_time_school_async(
        self,
        request: dingtalkedu__1__0_models.QueryClassScheduleByTimeSchoolRequest,
    ) -> dingtalkedu__1__0_models.QueryClassScheduleByTimeSchoolResponse:
        """
        @summary 按照学校和时间区间筛选课程
        
        @param request: QueryClassScheduleByTimeSchoolRequest
        @return: QueryClassScheduleByTimeSchoolResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryClassScheduleByTimeSchoolHeaders()
        return await self.query_class_schedule_by_time_school_with_options_async(request, headers, runtime)

    def query_class_schedule_config_with_options(
        self,
        tmp_req: dingtalkedu__1__0_models.QueryClassScheduleConfigRequest,
        headers: dingtalkedu__1__0_models.QueryClassScheduleConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryClassScheduleConfigResponse:
        """
        @summary 获取课程表设置
        
        @param tmp_req: QueryClassScheduleConfigRequest
        @param headers: QueryClassScheduleConfigHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryClassScheduleConfigResponse
        """
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
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryClassScheduleConfig',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/schedules/configs',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryClassScheduleConfigResponse(),
            self.execute(params, req, runtime)
        )

    async def query_class_schedule_config_with_options_async(
        self,
        tmp_req: dingtalkedu__1__0_models.QueryClassScheduleConfigRequest,
        headers: dingtalkedu__1__0_models.QueryClassScheduleConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryClassScheduleConfigResponse:
        """
        @summary 获取课程表设置
        
        @param tmp_req: QueryClassScheduleConfigRequest
        @param headers: QueryClassScheduleConfigHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryClassScheduleConfigResponse
        """
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
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryClassScheduleConfig',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/schedules/configs',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryClassScheduleConfigResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_class_schedule_config(
        self,
        request: dingtalkedu__1__0_models.QueryClassScheduleConfigRequest,
    ) -> dingtalkedu__1__0_models.QueryClassScheduleConfigResponse:
        """
        @summary 获取课程表设置
        
        @param request: QueryClassScheduleConfigRequest
        @return: QueryClassScheduleConfigResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryClassScheduleConfigHeaders()
        return self.query_class_schedule_config_with_options(request, headers, runtime)

    async def query_class_schedule_config_async(
        self,
        request: dingtalkedu__1__0_models.QueryClassScheduleConfigRequest,
    ) -> dingtalkedu__1__0_models.QueryClassScheduleConfigResponse:
        """
        @summary 获取课程表设置
        
        @param request: QueryClassScheduleConfigRequest
        @return: QueryClassScheduleConfigResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryClassScheduleConfigHeaders()
        return await self.query_class_schedule_config_with_options_async(request, headers, runtime)

    def query_college_contact_user_detail_with_options(
        self,
        request: dingtalkedu__1__0_models.QueryCollegeContactUserDetailRequest,
        headers: dingtalkedu__1__0_models.QueryCollegeContactUserDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryCollegeContactUserDetailResponse:
        """
        @summary 获取用户详情(包含高校账号)
        
        @param request: QueryCollegeContactUserDetailRequest
        @param headers: QueryCollegeContactUserDetailHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryCollegeContactUserDetailResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.userid):
            query['userid'] = request.userid
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
            action='QueryCollegeContactUserDetail',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/collegeContact/users',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryCollegeContactUserDetailResponse(),
            self.execute(params, req, runtime)
        )

    async def query_college_contact_user_detail_with_options_async(
        self,
        request: dingtalkedu__1__0_models.QueryCollegeContactUserDetailRequest,
        headers: dingtalkedu__1__0_models.QueryCollegeContactUserDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryCollegeContactUserDetailResponse:
        """
        @summary 获取用户详情(包含高校账号)
        
        @param request: QueryCollegeContactUserDetailRequest
        @param headers: QueryCollegeContactUserDetailHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryCollegeContactUserDetailResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.userid):
            query['userid'] = request.userid
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
            action='QueryCollegeContactUserDetail',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/collegeContact/users',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryCollegeContactUserDetailResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_college_contact_user_detail(
        self,
        request: dingtalkedu__1__0_models.QueryCollegeContactUserDetailRequest,
    ) -> dingtalkedu__1__0_models.QueryCollegeContactUserDetailResponse:
        """
        @summary 获取用户详情(包含高校账号)
        
        @param request: QueryCollegeContactUserDetailRequest
        @return: QueryCollegeContactUserDetailResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryCollegeContactUserDetailHeaders()
        return self.query_college_contact_user_detail_with_options(request, headers, runtime)

    async def query_college_contact_user_detail_async(
        self,
        request: dingtalkedu__1__0_models.QueryCollegeContactUserDetailRequest,
    ) -> dingtalkedu__1__0_models.QueryCollegeContactUserDetailResponse:
        """
        @summary 获取用户详情(包含高校账号)
        
        @param request: QueryCollegeContactUserDetailRequest
        @return: QueryCollegeContactUserDetailResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryCollegeContactUserDetailHeaders()
        return await self.query_college_contact_user_detail_with_options_async(request, headers, runtime)

    def query_device_with_options(
        self,
        request: dingtalkedu__1__0_models.QueryDeviceRequest,
        headers: dingtalkedu__1__0_models.QueryDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryDeviceResponse:
        """
        @summary 查询单台视讯PAAS设备
        
        @param request: QueryDeviceRequest
        @param headers: QueryDeviceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryDeviceResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.sn):
            query['sn'] = request.sn
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
            action='QueryDevice',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/vpass/devices/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryDeviceResponse(),
            self.execute(params, req, runtime)
        )

    async def query_device_with_options_async(
        self,
        request: dingtalkedu__1__0_models.QueryDeviceRequest,
        headers: dingtalkedu__1__0_models.QueryDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryDeviceResponse:
        """
        @summary 查询单台视讯PAAS设备
        
        @param request: QueryDeviceRequest
        @param headers: QueryDeviceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryDeviceResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.sn):
            query['sn'] = request.sn
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
            action='QueryDevice',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/vpass/devices/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryDeviceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_device(
        self,
        request: dingtalkedu__1__0_models.QueryDeviceRequest,
    ) -> dingtalkedu__1__0_models.QueryDeviceResponse:
        """
        @summary 查询单台视讯PAAS设备
        
        @param request: QueryDeviceRequest
        @return: QueryDeviceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryDeviceHeaders()
        return self.query_device_with_options(request, headers, runtime)

    async def query_device_async(
        self,
        request: dingtalkedu__1__0_models.QueryDeviceRequest,
    ) -> dingtalkedu__1__0_models.QueryDeviceResponse:
        """
        @summary 查询单台视讯PAAS设备
        
        @param request: QueryDeviceRequest
        @return: QueryDeviceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryDeviceHeaders()
        return await self.query_device_with_options_async(request, headers, runtime)

    def query_device_list_by_corp_id_with_options(
        self,
        request: dingtalkedu__1__0_models.QueryDeviceListByCorpIdRequest,
        headers: dingtalkedu__1__0_models.QueryDeviceListByCorpIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryDeviceListByCorpIdResponse:
        """
        @summary 查询某个组织下面的设备列表
        
        @param request: QueryDeviceListByCorpIdRequest
        @param headers: QueryDeviceListByCorpIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryDeviceListByCorpIdResponse
        """
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
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryDeviceListByCorpId',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/remoteClasses/devices',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryDeviceListByCorpIdResponse(),
            self.execute(params, req, runtime)
        )

    async def query_device_list_by_corp_id_with_options_async(
        self,
        request: dingtalkedu__1__0_models.QueryDeviceListByCorpIdRequest,
        headers: dingtalkedu__1__0_models.QueryDeviceListByCorpIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryDeviceListByCorpIdResponse:
        """
        @summary 查询某个组织下面的设备列表
        
        @param request: QueryDeviceListByCorpIdRequest
        @param headers: QueryDeviceListByCorpIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryDeviceListByCorpIdResponse
        """
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
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryDeviceListByCorpId',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/remoteClasses/devices',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryDeviceListByCorpIdResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_device_list_by_corp_id(
        self,
        request: dingtalkedu__1__0_models.QueryDeviceListByCorpIdRequest,
    ) -> dingtalkedu__1__0_models.QueryDeviceListByCorpIdResponse:
        """
        @summary 查询某个组织下面的设备列表
        
        @param request: QueryDeviceListByCorpIdRequest
        @return: QueryDeviceListByCorpIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryDeviceListByCorpIdHeaders()
        return self.query_device_list_by_corp_id_with_options(request, headers, runtime)

    async def query_device_list_by_corp_id_async(
        self,
        request: dingtalkedu__1__0_models.QueryDeviceListByCorpIdRequest,
    ) -> dingtalkedu__1__0_models.QueryDeviceListByCorpIdResponse:
        """
        @summary 查询某个组织下面的设备列表
        
        @param request: QueryDeviceListByCorpIdRequest
        @return: QueryDeviceListByCorpIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryDeviceListByCorpIdHeaders()
        return await self.query_device_list_by_corp_id_with_options_async(request, headers, runtime)

    def query_edu_asset_spaces_with_options(
        self,
        request: dingtalkedu__1__0_models.QueryEduAssetSpacesRequest,
        headers: dingtalkedu__1__0_models.QueryEduAssetSpacesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryEduAssetSpacesResponse:
        """
        @summary 教学资源库查询space列表
        
        @param request: QueryEduAssetSpacesRequest
        @param headers: QueryEduAssetSpacesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryEduAssetSpacesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.biz_code):
            query['bizCode'] = request.biz_code
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
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryEduAssetSpaces',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/assets/spaces',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryEduAssetSpacesResponse(),
            self.execute(params, req, runtime)
        )

    async def query_edu_asset_spaces_with_options_async(
        self,
        request: dingtalkedu__1__0_models.QueryEduAssetSpacesRequest,
        headers: dingtalkedu__1__0_models.QueryEduAssetSpacesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryEduAssetSpacesResponse:
        """
        @summary 教学资源库查询space列表
        
        @param request: QueryEduAssetSpacesRequest
        @param headers: QueryEduAssetSpacesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryEduAssetSpacesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.biz_code):
            query['bizCode'] = request.biz_code
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
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryEduAssetSpaces',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/assets/spaces',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryEduAssetSpacesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_edu_asset_spaces(
        self,
        request: dingtalkedu__1__0_models.QueryEduAssetSpacesRequest,
    ) -> dingtalkedu__1__0_models.QueryEduAssetSpacesResponse:
        """
        @summary 教学资源库查询space列表
        
        @param request: QueryEduAssetSpacesRequest
        @return: QueryEduAssetSpacesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryEduAssetSpacesHeaders()
        return self.query_edu_asset_spaces_with_options(request, headers, runtime)

    async def query_edu_asset_spaces_async(
        self,
        request: dingtalkedu__1__0_models.QueryEduAssetSpacesRequest,
    ) -> dingtalkedu__1__0_models.QueryEduAssetSpacesResponse:
        """
        @summary 教学资源库查询space列表
        
        @param request: QueryEduAssetSpacesRequest
        @return: QueryEduAssetSpacesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryEduAssetSpacesHeaders()
        return await self.query_edu_asset_spaces_with_options_async(request, headers, runtime)

    def query_group_id_with_options(
        self,
        request: dingtalkedu__1__0_models.QueryGroupIdRequest,
        headers: dingtalkedu__1__0_models.QueryGroupIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryGroupIdResponse:
        """
        @summary 根据设备SN信息查询学校人脸库
        
        @param request: QueryGroupIdRequest
        @param headers: QueryGroupIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryGroupIdResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.sn):
            query['sn'] = request.sn
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
            action='QueryGroupId',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/faces/groups',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryGroupIdResponse(),
            self.execute(params, req, runtime)
        )

    async def query_group_id_with_options_async(
        self,
        request: dingtalkedu__1__0_models.QueryGroupIdRequest,
        headers: dingtalkedu__1__0_models.QueryGroupIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryGroupIdResponse:
        """
        @summary 根据设备SN信息查询学校人脸库
        
        @param request: QueryGroupIdRequest
        @param headers: QueryGroupIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryGroupIdResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.sn):
            query['sn'] = request.sn
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
            action='QueryGroupId',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/faces/groups',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryGroupIdResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_group_id(
        self,
        request: dingtalkedu__1__0_models.QueryGroupIdRequest,
    ) -> dingtalkedu__1__0_models.QueryGroupIdResponse:
        """
        @summary 根据设备SN信息查询学校人脸库
        
        @param request: QueryGroupIdRequest
        @return: QueryGroupIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryGroupIdHeaders()
        return self.query_group_id_with_options(request, headers, runtime)

    async def query_group_id_async(
        self,
        request: dingtalkedu__1__0_models.QueryGroupIdRequest,
    ) -> dingtalkedu__1__0_models.QueryGroupIdResponse:
        """
        @summary 根据设备SN信息查询学校人脸库
        
        @param request: QueryGroupIdRequest
        @return: QueryGroupIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryGroupIdHeaders()
        return await self.query_group_id_with_options_async(request, headers, runtime)

    def query_kit_open_record_with_options(
        self,
        request: dingtalkedu__1__0_models.QueryKitOpenRecordRequest,
        headers: dingtalkedu__1__0_models.QueryKitOpenRecordHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryKitOpenRecordResponse:
        """
        @summary 查询套件开通记录
        
        @param request: QueryKitOpenRecordRequest
        @param headers: QueryKitOpenRecordHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryKitOpenRecordResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.isv_product_scene):
            body['isvProductScene'] = request.isv_product_scene
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
            action='QueryKitOpenRecord',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/kits/records/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryKitOpenRecordResponse(),
            self.execute(params, req, runtime)
        )

    async def query_kit_open_record_with_options_async(
        self,
        request: dingtalkedu__1__0_models.QueryKitOpenRecordRequest,
        headers: dingtalkedu__1__0_models.QueryKitOpenRecordHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryKitOpenRecordResponse:
        """
        @summary 查询套件开通记录
        
        @param request: QueryKitOpenRecordRequest
        @param headers: QueryKitOpenRecordHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryKitOpenRecordResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.isv_product_scene):
            body['isvProductScene'] = request.isv_product_scene
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
            action='QueryKitOpenRecord',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/kits/records/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryKitOpenRecordResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_kit_open_record(
        self,
        request: dingtalkedu__1__0_models.QueryKitOpenRecordRequest,
    ) -> dingtalkedu__1__0_models.QueryKitOpenRecordResponse:
        """
        @summary 查询套件开通记录
        
        @param request: QueryKitOpenRecordRequest
        @return: QueryKitOpenRecordResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryKitOpenRecordHeaders()
        return self.query_kit_open_record_with_options(request, headers, runtime)

    async def query_kit_open_record_async(
        self,
        request: dingtalkedu__1__0_models.QueryKitOpenRecordRequest,
    ) -> dingtalkedu__1__0_models.QueryKitOpenRecordResponse:
        """
        @summary 查询套件开通记录
        
        @param request: QueryKitOpenRecordRequest
        @return: QueryKitOpenRecordResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryKitOpenRecordHeaders()
        return await self.query_kit_open_record_with_options_async(request, headers, runtime)

    def query_order_with_options(
        self,
        request: dingtalkedu__1__0_models.QueryOrderRequest,
        headers: dingtalkedu__1__0_models.QueryOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryOrderResponse:
        """
        @summary 查询订单信息
        
        @param request: QueryOrderRequest
        @param headers: QueryOrderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryOrderResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.alipay_app_id):
            query['alipayAppId'] = request.alipay_app_id
        if not UtilClient.is_unset(request.merchant_id):
            query['merchantId'] = request.merchant_id
        if not UtilClient.is_unset(request.order_no):
            query['orderNo'] = request.order_no
        if not UtilClient.is_unset(request.signature):
            query['signature'] = request.signature
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
            action='QueryOrder',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/orders',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryOrderResponse(),
            self.execute(params, req, runtime)
        )

    async def query_order_with_options_async(
        self,
        request: dingtalkedu__1__0_models.QueryOrderRequest,
        headers: dingtalkedu__1__0_models.QueryOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryOrderResponse:
        """
        @summary 查询订单信息
        
        @param request: QueryOrderRequest
        @param headers: QueryOrderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryOrderResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.alipay_app_id):
            query['alipayAppId'] = request.alipay_app_id
        if not UtilClient.is_unset(request.merchant_id):
            query['merchantId'] = request.merchant_id
        if not UtilClient.is_unset(request.order_no):
            query['orderNo'] = request.order_no
        if not UtilClient.is_unset(request.signature):
            query['signature'] = request.signature
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
            action='QueryOrder',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/orders',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryOrderResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_order(
        self,
        request: dingtalkedu__1__0_models.QueryOrderRequest,
    ) -> dingtalkedu__1__0_models.QueryOrderResponse:
        """
        @summary 查询订单信息
        
        @param request: QueryOrderRequest
        @return: QueryOrderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryOrderHeaders()
        return self.query_order_with_options(request, headers, runtime)

    async def query_order_async(
        self,
        request: dingtalkedu__1__0_models.QueryOrderRequest,
    ) -> dingtalkedu__1__0_models.QueryOrderResponse:
        """
        @summary 查询订单信息
        
        @param request: QueryOrderRequest
        @return: QueryOrderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryOrderHeaders()
        return await self.query_order_with_options_async(request, headers, runtime)

    def query_org_relation_list_with_options(
        self,
        request: dingtalkedu__1__0_models.QueryOrgRelationListRequest,
        headers: dingtalkedu__1__0_models.QueryOrgRelationListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryOrgRelationListResponse:
        """
        @summary 查询某个组织下面关联的组织列表
        
        @param request: QueryOrgRelationListRequest
        @param headers: QueryOrgRelationListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryOrgRelationListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
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
            action='QueryOrgRelationList',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/remoteClasses/orgRelations',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryOrgRelationListResponse(),
            self.execute(params, req, runtime)
        )

    async def query_org_relation_list_with_options_async(
        self,
        request: dingtalkedu__1__0_models.QueryOrgRelationListRequest,
        headers: dingtalkedu__1__0_models.QueryOrgRelationListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryOrgRelationListResponse:
        """
        @summary 查询某个组织下面关联的组织列表
        
        @param request: QueryOrgRelationListRequest
        @param headers: QueryOrgRelationListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryOrgRelationListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
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
            action='QueryOrgRelationList',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/remoteClasses/orgRelations',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryOrgRelationListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_org_relation_list(
        self,
        request: dingtalkedu__1__0_models.QueryOrgRelationListRequest,
    ) -> dingtalkedu__1__0_models.QueryOrgRelationListResponse:
        """
        @summary 查询某个组织下面关联的组织列表
        
        @param request: QueryOrgRelationListRequest
        @return: QueryOrgRelationListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryOrgRelationListHeaders()
        return self.query_org_relation_list_with_options(request, headers, runtime)

    async def query_org_relation_list_async(
        self,
        request: dingtalkedu__1__0_models.QueryOrgRelationListRequest,
    ) -> dingtalkedu__1__0_models.QueryOrgRelationListResponse:
        """
        @summary 查询某个组织下面关联的组织列表
        
        @param request: QueryOrgRelationListRequest
        @return: QueryOrgRelationListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryOrgRelationListHeaders()
        return await self.query_org_relation_list_with_options_async(request, headers, runtime)

    def query_org_secret_key_with_options(
        self,
        request: dingtalkedu__1__0_models.QueryOrgSecretKeyRequest,
        headers: dingtalkedu__1__0_models.QueryOrgSecretKeyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryOrgSecretKeyResponse:
        """
        @summary 获取组织秘钥
        
        @param request: QueryOrgSecretKeyRequest
        @param headers: QueryOrgSecretKeyHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryOrgSecretKeyResponse
        """
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
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryOrgSecretKey',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/secretKeys',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryOrgSecretKeyResponse(),
            self.execute(params, req, runtime)
        )

    async def query_org_secret_key_with_options_async(
        self,
        request: dingtalkedu__1__0_models.QueryOrgSecretKeyRequest,
        headers: dingtalkedu__1__0_models.QueryOrgSecretKeyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryOrgSecretKeyResponse:
        """
        @summary 获取组织秘钥
        
        @param request: QueryOrgSecretKeyRequest
        @param headers: QueryOrgSecretKeyHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryOrgSecretKeyResponse
        """
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
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryOrgSecretKey',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/secretKeys',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryOrgSecretKeyResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_org_secret_key(
        self,
        request: dingtalkedu__1__0_models.QueryOrgSecretKeyRequest,
    ) -> dingtalkedu__1__0_models.QueryOrgSecretKeyResponse:
        """
        @summary 获取组织秘钥
        
        @param request: QueryOrgSecretKeyRequest
        @return: QueryOrgSecretKeyResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryOrgSecretKeyHeaders()
        return self.query_org_secret_key_with_options(request, headers, runtime)

    async def query_org_secret_key_async(
        self,
        request: dingtalkedu__1__0_models.QueryOrgSecretKeyRequest,
    ) -> dingtalkedu__1__0_models.QueryOrgSecretKeyResponse:
        """
        @summary 获取组织秘钥
        
        @param request: QueryOrgSecretKeyRequest
        @return: QueryOrgSecretKeyResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryOrgSecretKeyHeaders()
        return await self.query_org_secret_key_with_options_async(request, headers, runtime)

    def query_org_type_with_options(
        self,
        headers: dingtalkedu__1__0_models.QueryOrgTypeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryOrgTypeResponse:
        """
        @summary 查询教育组织类型
        
        @param headers: QueryOrgTypeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryOrgTypeResponse
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
            action='QueryOrgType',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/orgTypes',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryOrgTypeResponse(),
            self.execute(params, req, runtime)
        )

    async def query_org_type_with_options_async(
        self,
        headers: dingtalkedu__1__0_models.QueryOrgTypeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryOrgTypeResponse:
        """
        @summary 查询教育组织类型
        
        @param headers: QueryOrgTypeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryOrgTypeResponse
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
            action='QueryOrgType',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/orgTypes',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryOrgTypeResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_org_type(self) -> dingtalkedu__1__0_models.QueryOrgTypeResponse:
        """
        @summary 查询教育组织类型
        
        @return: QueryOrgTypeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryOrgTypeHeaders()
        return self.query_org_type_with_options(headers, runtime)

    async def query_org_type_async(self) -> dingtalkedu__1__0_models.QueryOrgTypeResponse:
        """
        @summary 查询教育组织类型
        
        @return: QueryOrgTypeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryOrgTypeHeaders()
        return await self.query_org_type_with_options_async(headers, runtime)

    def query_pay_result_with_options(
        self,
        request: dingtalkedu__1__0_models.QueryPayResultRequest,
        headers: dingtalkedu__1__0_models.QueryPayResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryPayResultResponse:
        """
        @summary 查询支付结果
        
        @param request: QueryPayResultRequest
        @param headers: QueryPayResultHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryPayResultResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.face_id):
            body['faceId'] = request.face_id
        if not UtilClient.is_unset(request.order_no):
            body['orderNo'] = request.order_no
        if not UtilClient.is_unset(request.signature):
            body['signature'] = request.signature
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
        if not UtilClient.is_unset(request.timestamp):
            body['timestamp'] = request.timestamp
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.version):
            body['version'] = request.version
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
            action='QueryPayResult',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/payResults/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryPayResultResponse(),
            self.execute(params, req, runtime)
        )

    async def query_pay_result_with_options_async(
        self,
        request: dingtalkedu__1__0_models.QueryPayResultRequest,
        headers: dingtalkedu__1__0_models.QueryPayResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryPayResultResponse:
        """
        @summary 查询支付结果
        
        @param request: QueryPayResultRequest
        @param headers: QueryPayResultHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryPayResultResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.face_id):
            body['faceId'] = request.face_id
        if not UtilClient.is_unset(request.order_no):
            body['orderNo'] = request.order_no
        if not UtilClient.is_unset(request.signature):
            body['signature'] = request.signature
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
        if not UtilClient.is_unset(request.timestamp):
            body['timestamp'] = request.timestamp
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.version):
            body['version'] = request.version
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
            action='QueryPayResult',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/payResults/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryPayResultResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_pay_result(
        self,
        request: dingtalkedu__1__0_models.QueryPayResultRequest,
    ) -> dingtalkedu__1__0_models.QueryPayResultResponse:
        """
        @summary 查询支付结果
        
        @param request: QueryPayResultRequest
        @return: QueryPayResultResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryPayResultHeaders()
        return self.query_pay_result_with_options(request, headers, runtime)

    async def query_pay_result_async(
        self,
        request: dingtalkedu__1__0_models.QueryPayResultRequest,
    ) -> dingtalkedu__1__0_models.QueryPayResultResponse:
        """
        @summary 查询支付结果
        
        @param request: QueryPayResultRequest
        @return: QueryPayResultResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryPayResultHeaders()
        return await self.query_pay_result_with_options_async(request, headers, runtime)

    def query_physical_classroom_with_options(
        self,
        request: dingtalkedu__1__0_models.QueryPhysicalClassroomRequest,
        headers: dingtalkedu__1__0_models.QueryPhysicalClassroomHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryPhysicalClassroomResponse:
        """
        @summary 查询物理教室信息
        
        @param request: QueryPhysicalClassroomRequest
        @param headers: QueryPhysicalClassroomHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryPhysicalClassroomResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.classroom_id):
            query['classroomId'] = request.classroom_id
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
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
            action='QueryPhysicalClassroom',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/physicalClassrooms',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryPhysicalClassroomResponse(),
            self.execute(params, req, runtime)
        )

    async def query_physical_classroom_with_options_async(
        self,
        request: dingtalkedu__1__0_models.QueryPhysicalClassroomRequest,
        headers: dingtalkedu__1__0_models.QueryPhysicalClassroomHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryPhysicalClassroomResponse:
        """
        @summary 查询物理教室信息
        
        @param request: QueryPhysicalClassroomRequest
        @param headers: QueryPhysicalClassroomHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryPhysicalClassroomResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.classroom_id):
            query['classroomId'] = request.classroom_id
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
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
            action='QueryPhysicalClassroom',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/physicalClassrooms',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryPhysicalClassroomResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_physical_classroom(
        self,
        request: dingtalkedu__1__0_models.QueryPhysicalClassroomRequest,
    ) -> dingtalkedu__1__0_models.QueryPhysicalClassroomResponse:
        """
        @summary 查询物理教室信息
        
        @param request: QueryPhysicalClassroomRequest
        @return: QueryPhysicalClassroomResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryPhysicalClassroomHeaders()
        return self.query_physical_classroom_with_options(request, headers, runtime)

    async def query_physical_classroom_async(
        self,
        request: dingtalkedu__1__0_models.QueryPhysicalClassroomRequest,
    ) -> dingtalkedu__1__0_models.QueryPhysicalClassroomResponse:
        """
        @summary 查询物理教室信息
        
        @param request: QueryPhysicalClassroomRequest
        @return: QueryPhysicalClassroomResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryPhysicalClassroomHeaders()
        return await self.query_physical_classroom_with_options_async(request, headers, runtime)

    def query_purchase_info_with_options(
        self,
        request: dingtalkedu__1__0_models.QueryPurchaseInfoRequest,
        headers: dingtalkedu__1__0_models.QueryPurchaseInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryPurchaseInfoResponse:
        """
        @summary 查询用户订购服务状态
        
        @param request: QueryPurchaseInfoRequest
        @param headers: QueryPurchaseInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryPurchaseInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.merchant_id):
            query['merchantId'] = request.merchant_id
        if not UtilClient.is_unset(request.scene):
            query['scene'] = request.scene
        if not UtilClient.is_unset(request.sn):
            query['sn'] = request.sn
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
            action='QueryPurchaseInfo',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/users/purchases',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryPurchaseInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def query_purchase_info_with_options_async(
        self,
        request: dingtalkedu__1__0_models.QueryPurchaseInfoRequest,
        headers: dingtalkedu__1__0_models.QueryPurchaseInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryPurchaseInfoResponse:
        """
        @summary 查询用户订购服务状态
        
        @param request: QueryPurchaseInfoRequest
        @param headers: QueryPurchaseInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryPurchaseInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.merchant_id):
            query['merchantId'] = request.merchant_id
        if not UtilClient.is_unset(request.scene):
            query['scene'] = request.scene
        if not UtilClient.is_unset(request.sn):
            query['sn'] = request.sn
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
            action='QueryPurchaseInfo',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/users/purchases',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryPurchaseInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_purchase_info(
        self,
        request: dingtalkedu__1__0_models.QueryPurchaseInfoRequest,
    ) -> dingtalkedu__1__0_models.QueryPurchaseInfoResponse:
        """
        @summary 查询用户订购服务状态
        
        @param request: QueryPurchaseInfoRequest
        @return: QueryPurchaseInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryPurchaseInfoHeaders()
        return self.query_purchase_info_with_options(request, headers, runtime)

    async def query_purchase_info_async(
        self,
        request: dingtalkedu__1__0_models.QueryPurchaseInfoRequest,
    ) -> dingtalkedu__1__0_models.QueryPurchaseInfoResponse:
        """
        @summary 查询用户订购服务状态
        
        @param request: QueryPurchaseInfoRequest
        @return: QueryPurchaseInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryPurchaseInfoHeaders()
        return await self.query_purchase_info_with_options_async(request, headers, runtime)

    def query_remote_class_course_with_options(
        self,
        request: dingtalkedu__1__0_models.QueryRemoteClassCourseRequest,
        headers: dingtalkedu__1__0_models.QueryRemoteClassCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryRemoteClassCourseResponse:
        """
        @summary 查询课程列表
        
        @param request: QueryRemoteClassCourseRequest
        @param headers: QueryRemoteClassCourseHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryRemoteClassCourseResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
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
            action='QueryRemoteClassCourse',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/remoteClasses/courses',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryRemoteClassCourseResponse(),
            self.execute(params, req, runtime)
        )

    async def query_remote_class_course_with_options_async(
        self,
        request: dingtalkedu__1__0_models.QueryRemoteClassCourseRequest,
        headers: dingtalkedu__1__0_models.QueryRemoteClassCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryRemoteClassCourseResponse:
        """
        @summary 查询课程列表
        
        @param request: QueryRemoteClassCourseRequest
        @param headers: QueryRemoteClassCourseHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryRemoteClassCourseResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
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
            action='QueryRemoteClassCourse',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/remoteClasses/courses',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryRemoteClassCourseResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_remote_class_course(
        self,
        request: dingtalkedu__1__0_models.QueryRemoteClassCourseRequest,
    ) -> dingtalkedu__1__0_models.QueryRemoteClassCourseResponse:
        """
        @summary 查询课程列表
        
        @param request: QueryRemoteClassCourseRequest
        @return: QueryRemoteClassCourseResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryRemoteClassCourseHeaders()
        return self.query_remote_class_course_with_options(request, headers, runtime)

    async def query_remote_class_course_async(
        self,
        request: dingtalkedu__1__0_models.QueryRemoteClassCourseRequest,
    ) -> dingtalkedu__1__0_models.QueryRemoteClassCourseResponse:
        """
        @summary 查询课程列表
        
        @param request: QueryRemoteClassCourseRequest
        @return: QueryRemoteClassCourseResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryRemoteClassCourseHeaders()
        return await self.query_remote_class_course_with_options_async(request, headers, runtime)

    def query_school_user_face_with_options(
        self,
        request: dingtalkedu__1__0_models.QuerySchoolUserFaceRequest,
        headers: dingtalkedu__1__0_models.QuerySchoolUserFaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QuerySchoolUserFaceResponse:
        """
        @summary 分批查询学校人脸id
        
        @param request: QuerySchoolUserFaceRequest
        @param headers: QuerySchoolUserFaceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QuerySchoolUserFaceResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.sn):
            query['sn'] = request.sn
        if not UtilClient.is_unset(request.type):
            query['type'] = request.type
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
            action='QuerySchoolUserFace',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/schools/faces',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QuerySchoolUserFaceResponse(),
            self.execute(params, req, runtime)
        )

    async def query_school_user_face_with_options_async(
        self,
        request: dingtalkedu__1__0_models.QuerySchoolUserFaceRequest,
        headers: dingtalkedu__1__0_models.QuerySchoolUserFaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QuerySchoolUserFaceResponse:
        """
        @summary 分批查询学校人脸id
        
        @param request: QuerySchoolUserFaceRequest
        @param headers: QuerySchoolUserFaceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QuerySchoolUserFaceResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.sn):
            query['sn'] = request.sn
        if not UtilClient.is_unset(request.type):
            query['type'] = request.type
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
            action='QuerySchoolUserFace',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/schools/faces',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QuerySchoolUserFaceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_school_user_face(
        self,
        request: dingtalkedu__1__0_models.QuerySchoolUserFaceRequest,
    ) -> dingtalkedu__1__0_models.QuerySchoolUserFaceResponse:
        """
        @summary 分批查询学校人脸id
        
        @param request: QuerySchoolUserFaceRequest
        @return: QuerySchoolUserFaceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QuerySchoolUserFaceHeaders()
        return self.query_school_user_face_with_options(request, headers, runtime)

    async def query_school_user_face_async(
        self,
        request: dingtalkedu__1__0_models.QuerySchoolUserFaceRequest,
    ) -> dingtalkedu__1__0_models.QuerySchoolUserFaceResponse:
        """
        @summary 分批查询学校人脸id
        
        @param request: QuerySchoolUserFaceRequest
        @return: QuerySchoolUserFaceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QuerySchoolUserFaceHeaders()
        return await self.query_school_user_face_with_options_async(request, headers, runtime)

    def query_sns_order_with_options(
        self,
        request: dingtalkedu__1__0_models.QuerySnsOrderRequest,
        headers: dingtalkedu__1__0_models.QuerySnsOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QuerySnsOrderResponse:
        """
        @summary 个人应用查询订单信息
        
        @param request: QuerySnsOrderRequest
        @param headers: QuerySnsOrderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QuerySnsOrderResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.alipay_app_id):
            query['alipayAppId'] = request.alipay_app_id
        if not UtilClient.is_unset(request.merchant_id):
            query['merchantId'] = request.merchant_id
        if not UtilClient.is_unset(request.order_no):
            query['orderNo'] = request.order_no
        if not UtilClient.is_unset(request.signature):
            query['signature'] = request.signature
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
            action='QuerySnsOrder',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/snsOrders',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QuerySnsOrderResponse(),
            self.execute(params, req, runtime)
        )

    async def query_sns_order_with_options_async(
        self,
        request: dingtalkedu__1__0_models.QuerySnsOrderRequest,
        headers: dingtalkedu__1__0_models.QuerySnsOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QuerySnsOrderResponse:
        """
        @summary 个人应用查询订单信息
        
        @param request: QuerySnsOrderRequest
        @param headers: QuerySnsOrderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QuerySnsOrderResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.alipay_app_id):
            query['alipayAppId'] = request.alipay_app_id
        if not UtilClient.is_unset(request.merchant_id):
            query['merchantId'] = request.merchant_id
        if not UtilClient.is_unset(request.order_no):
            query['orderNo'] = request.order_no
        if not UtilClient.is_unset(request.signature):
            query['signature'] = request.signature
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
            action='QuerySnsOrder',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/snsOrders',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QuerySnsOrderResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_sns_order(
        self,
        request: dingtalkedu__1__0_models.QuerySnsOrderRequest,
    ) -> dingtalkedu__1__0_models.QuerySnsOrderResponse:
        """
        @summary 个人应用查询订单信息
        
        @param request: QuerySnsOrderRequest
        @return: QuerySnsOrderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QuerySnsOrderHeaders()
        return self.query_sns_order_with_options(request, headers, runtime)

    async def query_sns_order_async(
        self,
        request: dingtalkedu__1__0_models.QuerySnsOrderRequest,
    ) -> dingtalkedu__1__0_models.QuerySnsOrderResponse:
        """
        @summary 个人应用查询订单信息
        
        @param request: QuerySnsOrderRequest
        @return: QuerySnsOrderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QuerySnsOrderHeaders()
        return await self.query_sns_order_with_options_async(request, headers, runtime)

    def query_statistics_data_with_options(
        self,
        request: dingtalkedu__1__0_models.QueryStatisticsDataRequest,
        headers: dingtalkedu__1__0_models.QueryStatisticsDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryStatisticsDataResponse:
        """
        @summary 获得课程表详细信息
        
        @param request: QueryStatisticsDataRequest
        @param headers: QueryStatisticsDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryStatisticsDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.start_time):
            query['startTime'] = request.start_time
        body = {}
        if not UtilClient.is_unset(request.section_index_list):
            body['sectionIndexList'] = request.section_index_list
        if not UtilClient.is_unset(request.teacher_user_ids):
            body['teacherUserIds'] = request.teacher_user_ids
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
            action='QueryStatisticsData',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/classes/schedules/statisticData/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryStatisticsDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_statistics_data_with_options_async(
        self,
        request: dingtalkedu__1__0_models.QueryStatisticsDataRequest,
        headers: dingtalkedu__1__0_models.QueryStatisticsDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryStatisticsDataResponse:
        """
        @summary 获得课程表详细信息
        
        @param request: QueryStatisticsDataRequest
        @param headers: QueryStatisticsDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryStatisticsDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.start_time):
            query['startTime'] = request.start_time
        body = {}
        if not UtilClient.is_unset(request.section_index_list):
            body['sectionIndexList'] = request.section_index_list
        if not UtilClient.is_unset(request.teacher_user_ids):
            body['teacherUserIds'] = request.teacher_user_ids
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
            action='QueryStatisticsData',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/classes/schedules/statisticData/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryStatisticsDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_statistics_data(
        self,
        request: dingtalkedu__1__0_models.QueryStatisticsDataRequest,
    ) -> dingtalkedu__1__0_models.QueryStatisticsDataResponse:
        """
        @summary 获得课程表详细信息
        
        @param request: QueryStatisticsDataRequest
        @return: QueryStatisticsDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryStatisticsDataHeaders()
        return self.query_statistics_data_with_options(request, headers, runtime)

    async def query_statistics_data_async(
        self,
        request: dingtalkedu__1__0_models.QueryStatisticsDataRequest,
    ) -> dingtalkedu__1__0_models.QueryStatisticsDataResponse:
        """
        @summary 获得课程表详细信息
        
        @param request: QueryStatisticsDataRequest
        @return: QueryStatisticsDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryStatisticsDataHeaders()
        return await self.query_statistics_data_with_options_async(request, headers, runtime)

    def query_student_class_with_options(
        self,
        request: dingtalkedu__1__0_models.QueryStudentClassRequest,
        headers: dingtalkedu__1__0_models.QueryStudentClassHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryStudentClassResponse:
        """
        @summary 查询学生班级
        
        @param request: QueryStudentClassRequest
        @param headers: QueryStudentClassHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryStudentClassResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.class_id):
            body['classId'] = request.class_id
        if not UtilClient.is_unset(request.class_type):
            body['classType'] = request.class_type
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.student_user_ids):
            body['studentUserIds'] = request.student_user_ids
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
            action='QueryStudentClass',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/kits/students/classes/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryStudentClassResponse(),
            self.execute(params, req, runtime)
        )

    async def query_student_class_with_options_async(
        self,
        request: dingtalkedu__1__0_models.QueryStudentClassRequest,
        headers: dingtalkedu__1__0_models.QueryStudentClassHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryStudentClassResponse:
        """
        @summary 查询学生班级
        
        @param request: QueryStudentClassRequest
        @param headers: QueryStudentClassHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryStudentClassResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.class_id):
            body['classId'] = request.class_id
        if not UtilClient.is_unset(request.class_type):
            body['classType'] = request.class_type
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.student_user_ids):
            body['studentUserIds'] = request.student_user_ids
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
            action='QueryStudentClass',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/kits/students/classes/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryStudentClassResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_student_class(
        self,
        request: dingtalkedu__1__0_models.QueryStudentClassRequest,
    ) -> dingtalkedu__1__0_models.QueryStudentClassResponse:
        """
        @summary 查询学生班级
        
        @param request: QueryStudentClassRequest
        @return: QueryStudentClassResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryStudentClassHeaders()
        return self.query_student_class_with_options(request, headers, runtime)

    async def query_student_class_async(
        self,
        request: dingtalkedu__1__0_models.QueryStudentClassRequest,
    ) -> dingtalkedu__1__0_models.QueryStudentClassResponse:
        """
        @summary 查询学生班级
        
        @param request: QueryStudentClassRequest
        @return: QueryStudentClassResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryStudentClassHeaders()
        return await self.query_student_class_with_options_async(request, headers, runtime)

    def query_subject_teachers_with_options(
        self,
        request: dingtalkedu__1__0_models.QuerySubjectTeachersRequest,
        headers: dingtalkedu__1__0_models.QuerySubjectTeachersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QuerySubjectTeachersResponse:
        """
        @summary 查询教授某学科老师列表
        
        @param request: QuerySubjectTeachersRequest
        @param headers: QuerySubjectTeachersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QuerySubjectTeachersResponse
        """
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
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QuerySubjectTeachers',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/subjects/teachers',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QuerySubjectTeachersResponse(),
            self.execute(params, req, runtime)
        )

    async def query_subject_teachers_with_options_async(
        self,
        request: dingtalkedu__1__0_models.QuerySubjectTeachersRequest,
        headers: dingtalkedu__1__0_models.QuerySubjectTeachersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QuerySubjectTeachersResponse:
        """
        @summary 查询教授某学科老师列表
        
        @param request: QuerySubjectTeachersRequest
        @param headers: QuerySubjectTeachersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QuerySubjectTeachersResponse
        """
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
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QuerySubjectTeachers',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/subjects/teachers',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QuerySubjectTeachersResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_subject_teachers(
        self,
        request: dingtalkedu__1__0_models.QuerySubjectTeachersRequest,
    ) -> dingtalkedu__1__0_models.QuerySubjectTeachersResponse:
        """
        @summary 查询教授某学科老师列表
        
        @param request: QuerySubjectTeachersRequest
        @return: QuerySubjectTeachersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QuerySubjectTeachersHeaders()
        return self.query_subject_teachers_with_options(request, headers, runtime)

    async def query_subject_teachers_async(
        self,
        request: dingtalkedu__1__0_models.QuerySubjectTeachersRequest,
    ) -> dingtalkedu__1__0_models.QuerySubjectTeachersResponse:
        """
        @summary 查询教授某学科老师列表
        
        @param request: QuerySubjectTeachersRequest
        @return: QuerySubjectTeachersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QuerySubjectTeachersHeaders()
        return await self.query_subject_teachers_with_options_async(request, headers, runtime)

    def query_teach_subjects_with_options(
        self,
        request: dingtalkedu__1__0_models.QueryTeachSubjectsRequest,
        headers: dingtalkedu__1__0_models.QueryTeachSubjectsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryTeachSubjectsResponse:
        """
        @summary 查询老师教授学科列表
        
        @param request: QueryTeachSubjectsRequest
        @param headers: QueryTeachSubjectsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryTeachSubjectsResponse
        """
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
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryTeachSubjects',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/teachers/subjects',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryTeachSubjectsResponse(),
            self.execute(params, req, runtime)
        )

    async def query_teach_subjects_with_options_async(
        self,
        request: dingtalkedu__1__0_models.QueryTeachSubjectsRequest,
        headers: dingtalkedu__1__0_models.QueryTeachSubjectsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryTeachSubjectsResponse:
        """
        @summary 查询老师教授学科列表
        
        @param request: QueryTeachSubjectsRequest
        @param headers: QueryTeachSubjectsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryTeachSubjectsResponse
        """
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
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryTeachSubjects',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/teachers/subjects',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryTeachSubjectsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_teach_subjects(
        self,
        request: dingtalkedu__1__0_models.QueryTeachSubjectsRequest,
    ) -> dingtalkedu__1__0_models.QueryTeachSubjectsResponse:
        """
        @summary 查询老师教授学科列表
        
        @param request: QueryTeachSubjectsRequest
        @return: QueryTeachSubjectsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryTeachSubjectsHeaders()
        return self.query_teach_subjects_with_options(request, headers, runtime)

    async def query_teach_subjects_async(
        self,
        request: dingtalkedu__1__0_models.QueryTeachSubjectsRequest,
    ) -> dingtalkedu__1__0_models.QueryTeachSubjectsResponse:
        """
        @summary 查询老师教授学科列表
        
        @param request: QueryTeachSubjectsRequest
        @return: QueryTeachSubjectsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryTeachSubjectsHeaders()
        return await self.query_teach_subjects_with_options_async(request, headers, runtime)

    def query_teacher_course_with_options(
        self,
        request: dingtalkedu__1__0_models.QueryTeacherCourseRequest,
        headers: dingtalkedu__1__0_models.QueryTeacherCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryTeacherCourseResponse:
        """
        @summary 查询老师课程
        
        @param request: QueryTeacherCourseRequest
        @param headers: QueryTeacherCourseHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryTeacherCourseResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.isv_course_id_list):
            body['isvCourseIdList'] = request.isv_course_id_list
        if not UtilClient.is_unset(request.teacher_user_id):
            body['teacherUserId'] = request.teacher_user_id
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
            action='QueryTeacherCourse',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/kits/teachers/courses/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryTeacherCourseResponse(),
            self.execute(params, req, runtime)
        )

    async def query_teacher_course_with_options_async(
        self,
        request: dingtalkedu__1__0_models.QueryTeacherCourseRequest,
        headers: dingtalkedu__1__0_models.QueryTeacherCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryTeacherCourseResponse:
        """
        @summary 查询老师课程
        
        @param request: QueryTeacherCourseRequest
        @param headers: QueryTeacherCourseHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryTeacherCourseResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.isv_course_id_list):
            body['isvCourseIdList'] = request.isv_course_id_list
        if not UtilClient.is_unset(request.teacher_user_id):
            body['teacherUserId'] = request.teacher_user_id
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
            action='QueryTeacherCourse',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/kits/teachers/courses/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryTeacherCourseResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_teacher_course(
        self,
        request: dingtalkedu__1__0_models.QueryTeacherCourseRequest,
    ) -> dingtalkedu__1__0_models.QueryTeacherCourseResponse:
        """
        @summary 查询老师课程
        
        @param request: QueryTeacherCourseRequest
        @return: QueryTeacherCourseResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryTeacherCourseHeaders()
        return self.query_teacher_course_with_options(request, headers, runtime)

    async def query_teacher_course_async(
        self,
        request: dingtalkedu__1__0_models.QueryTeacherCourseRequest,
    ) -> dingtalkedu__1__0_models.QueryTeacherCourseResponse:
        """
        @summary 查询老师课程
        
        @param request: QueryTeacherCourseRequest
        @return: QueryTeacherCourseResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryTeacherCourseHeaders()
        return await self.query_teacher_course_with_options_async(request, headers, runtime)

    def query_transfer_course_with_options(
        self,
        request: dingtalkedu__1__0_models.QueryTransferCourseRequest,
        headers: dingtalkedu__1__0_models.QueryTransferCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryTransferCourseResponse:
        """
        @summary 查询调代课记录
        
        @param request: QueryTransferCourseRequest
        @param headers: QueryTransferCourseHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryTransferCourseResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.isv_record_id):
            body['isvRecordId'] = request.isv_record_id
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
            action='QueryTransferCourse',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/kits/transferRecords/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryTransferCourseResponse(),
            self.execute(params, req, runtime)
        )

    async def query_transfer_course_with_options_async(
        self,
        request: dingtalkedu__1__0_models.QueryTransferCourseRequest,
        headers: dingtalkedu__1__0_models.QueryTransferCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryTransferCourseResponse:
        """
        @summary 查询调代课记录
        
        @param request: QueryTransferCourseRequest
        @param headers: QueryTransferCourseHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryTransferCourseResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.isv_record_id):
            body['isvRecordId'] = request.isv_record_id
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
            action='QueryTransferCourse',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/kits/transferRecords/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryTransferCourseResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_transfer_course(
        self,
        request: dingtalkedu__1__0_models.QueryTransferCourseRequest,
    ) -> dingtalkedu__1__0_models.QueryTransferCourseResponse:
        """
        @summary 查询调代课记录
        
        @param request: QueryTransferCourseRequest
        @return: QueryTransferCourseResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryTransferCourseHeaders()
        return self.query_transfer_course_with_options(request, headers, runtime)

    async def query_transfer_course_async(
        self,
        request: dingtalkedu__1__0_models.QueryTransferCourseRequest,
    ) -> dingtalkedu__1__0_models.QueryTransferCourseResponse:
        """
        @summary 查询调代课记录
        
        @param request: QueryTransferCourseRequest
        @return: QueryTransferCourseResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryTransferCourseHeaders()
        return await self.query_transfer_course_with_options_async(request, headers, runtime)

    def query_university_course_group_with_options(
        self,
        request: dingtalkedu__1__0_models.QueryUniversityCourseGroupRequest,
        headers: dingtalkedu__1__0_models.QueryUniversityCourseGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryUniversityCourseGroupResponse:
        """
        @summary 查询大学课程组
        
        @param request: QueryUniversityCourseGroupRequest
        @param headers: QueryUniversityCourseGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryUniversityCourseGroupResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.course_group_code):
            query['courseGroupCode'] = request.course_group_code
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
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
            action='QueryUniversityCourseGroup',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/courseGroups',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryUniversityCourseGroupResponse(),
            self.execute(params, req, runtime)
        )

    async def query_university_course_group_with_options_async(
        self,
        request: dingtalkedu__1__0_models.QueryUniversityCourseGroupRequest,
        headers: dingtalkedu__1__0_models.QueryUniversityCourseGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryUniversityCourseGroupResponse:
        """
        @summary 查询大学课程组
        
        @param request: QueryUniversityCourseGroupRequest
        @param headers: QueryUniversityCourseGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryUniversityCourseGroupResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.course_group_code):
            query['courseGroupCode'] = request.course_group_code
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
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
            action='QueryUniversityCourseGroup',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/courseGroups',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryUniversityCourseGroupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_university_course_group(
        self,
        request: dingtalkedu__1__0_models.QueryUniversityCourseGroupRequest,
    ) -> dingtalkedu__1__0_models.QueryUniversityCourseGroupResponse:
        """
        @summary 查询大学课程组
        
        @param request: QueryUniversityCourseGroupRequest
        @return: QueryUniversityCourseGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryUniversityCourseGroupHeaders()
        return self.query_university_course_group_with_options(request, headers, runtime)

    async def query_university_course_group_async(
        self,
        request: dingtalkedu__1__0_models.QueryUniversityCourseGroupRequest,
    ) -> dingtalkedu__1__0_models.QueryUniversityCourseGroupResponse:
        """
        @summary 查询大学课程组
        
        @param request: QueryUniversityCourseGroupRequest
        @return: QueryUniversityCourseGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryUniversityCourseGroupHeaders()
        return await self.query_university_course_group_with_options_async(request, headers, runtime)

    def query_user_face_with_options(
        self,
        request: dingtalkedu__1__0_models.QueryUserFaceRequest,
        headers: dingtalkedu__1__0_models.QueryUserFaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryUserFaceResponse:
        """
        @summary 根据人脸id查询用户信息
        
        @param request: QueryUserFaceRequest
        @param headers: QueryUserFaceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryUserFaceResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.face_id):
            query['faceId'] = request.face_id
        if not UtilClient.is_unset(request.sn):
            query['sn'] = request.sn
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
            action='QueryUserFace',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/users/faces',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryUserFaceResponse(),
            self.execute(params, req, runtime)
        )

    async def query_user_face_with_options_async(
        self,
        request: dingtalkedu__1__0_models.QueryUserFaceRequest,
        headers: dingtalkedu__1__0_models.QueryUserFaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryUserFaceResponse:
        """
        @summary 根据人脸id查询用户信息
        
        @param request: QueryUserFaceRequest
        @param headers: QueryUserFaceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryUserFaceResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.face_id):
            query['faceId'] = request.face_id
        if not UtilClient.is_unset(request.sn):
            query['sn'] = request.sn
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
            action='QueryUserFace',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/users/faces',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryUserFaceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_user_face(
        self,
        request: dingtalkedu__1__0_models.QueryUserFaceRequest,
    ) -> dingtalkedu__1__0_models.QueryUserFaceResponse:
        """
        @summary 根据人脸id查询用户信息
        
        @param request: QueryUserFaceRequest
        @return: QueryUserFaceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryUserFaceHeaders()
        return self.query_user_face_with_options(request, headers, runtime)

    async def query_user_face_async(
        self,
        request: dingtalkedu__1__0_models.QueryUserFaceRequest,
    ) -> dingtalkedu__1__0_models.QueryUserFaceResponse:
        """
        @summary 根据人脸id查询用户信息
        
        @param request: QueryUserFaceRequest
        @return: QueryUserFaceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryUserFaceHeaders()
        return await self.query_user_face_with_options_async(request, headers, runtime)

    def query_user_pay_info_with_options(
        self,
        request: dingtalkedu__1__0_models.QueryUserPayInfoRequest,
        headers: dingtalkedu__1__0_models.QueryUserPayInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryUserPayInfoResponse:
        """
        @summary 查询用户支付信息
        
        @param request: QueryUserPayInfoRequest
        @param headers: QueryUserPayInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryUserPayInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.face_id):
            query['faceId'] = request.face_id
        if not UtilClient.is_unset(request.sn):
            query['sn'] = request.sn
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
            action='QueryUserPayInfo',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/orders/payInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryUserPayInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def query_user_pay_info_with_options_async(
        self,
        request: dingtalkedu__1__0_models.QueryUserPayInfoRequest,
        headers: dingtalkedu__1__0_models.QueryUserPayInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryUserPayInfoResponse:
        """
        @summary 查询用户支付信息
        
        @param request: QueryUserPayInfoRequest
        @param headers: QueryUserPayInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryUserPayInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.face_id):
            query['faceId'] = request.face_id
        if not UtilClient.is_unset(request.sn):
            query['sn'] = request.sn
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
            action='QueryUserPayInfo',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/orders/payInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryUserPayInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_user_pay_info(
        self,
        request: dingtalkedu__1__0_models.QueryUserPayInfoRequest,
    ) -> dingtalkedu__1__0_models.QueryUserPayInfoResponse:
        """
        @summary 查询用户支付信息
        
        @param request: QueryUserPayInfoRequest
        @return: QueryUserPayInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryUserPayInfoHeaders()
        return self.query_user_pay_info_with_options(request, headers, runtime)

    async def query_user_pay_info_async(
        self,
        request: dingtalkedu__1__0_models.QueryUserPayInfoRequest,
    ) -> dingtalkedu__1__0_models.QueryUserPayInfoResponse:
        """
        @summary 查询用户支付信息
        
        @param request: QueryUserPayInfoRequest
        @return: QueryUserPayInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryUserPayInfoHeaders()
        return await self.query_user_pay_info_with_options_async(request, headers, runtime)

    def remove_device_with_options(
        self,
        request: dingtalkedu__1__0_models.RemoveDeviceRequest,
        headers: dingtalkedu__1__0_models.RemoveDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.RemoveDeviceResponse:
        """
        @summary 移除设备
        
        @param request: RemoveDeviceRequest
        @param headers: RemoveDeviceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RemoveDeviceResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.merchant_id):
            query['merchantId'] = request.merchant_id
        if not UtilClient.is_unset(request.sn):
            query['sn'] = request.sn
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
            action='RemoveDevice',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/devices',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.RemoveDeviceResponse(),
            self.execute(params, req, runtime)
        )

    async def remove_device_with_options_async(
        self,
        request: dingtalkedu__1__0_models.RemoveDeviceRequest,
        headers: dingtalkedu__1__0_models.RemoveDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.RemoveDeviceResponse:
        """
        @summary 移除设备
        
        @param request: RemoveDeviceRequest
        @param headers: RemoveDeviceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RemoveDeviceResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.merchant_id):
            query['merchantId'] = request.merchant_id
        if not UtilClient.is_unset(request.sn):
            query['sn'] = request.sn
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
            action='RemoveDevice',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/devices',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.RemoveDeviceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def remove_device(
        self,
        request: dingtalkedu__1__0_models.RemoveDeviceRequest,
    ) -> dingtalkedu__1__0_models.RemoveDeviceResponse:
        """
        @summary 移除设备
        
        @param request: RemoveDeviceRequest
        @return: RemoveDeviceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.RemoveDeviceHeaders()
        return self.remove_device_with_options(request, headers, runtime)

    async def remove_device_async(
        self,
        request: dingtalkedu__1__0_models.RemoveDeviceRequest,
    ) -> dingtalkedu__1__0_models.RemoveDeviceResponse:
        """
        @summary 移除设备
        
        @param request: RemoveDeviceRequest
        @return: RemoveDeviceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.RemoveDeviceHeaders()
        return await self.remove_device_with_options_async(request, headers, runtime)

    def report_device_log_with_options(
        self,
        request: dingtalkedu__1__0_models.ReportDeviceLogRequest,
        headers: dingtalkedu__1__0_models.ReportDeviceLogHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.ReportDeviceLogResponse:
        """
        @summary 设备日志上报接口
        
        @param request: ReportDeviceLogRequest
        @param headers: ReportDeviceLogHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ReportDeviceLogResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.media_id):
            query['mediaId'] = request.media_id
        if not UtilClient.is_unset(request.sn):
            query['sn'] = request.sn
        if not UtilClient.is_unset(request.type):
            query['type'] = request.type
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
            action='ReportDeviceLog',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/deviceLogs/report',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.ReportDeviceLogResponse(),
            self.execute(params, req, runtime)
        )

    async def report_device_log_with_options_async(
        self,
        request: dingtalkedu__1__0_models.ReportDeviceLogRequest,
        headers: dingtalkedu__1__0_models.ReportDeviceLogHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.ReportDeviceLogResponse:
        """
        @summary 设备日志上报接口
        
        @param request: ReportDeviceLogRequest
        @param headers: ReportDeviceLogHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ReportDeviceLogResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.media_id):
            query['mediaId'] = request.media_id
        if not UtilClient.is_unset(request.sn):
            query['sn'] = request.sn
        if not UtilClient.is_unset(request.type):
            query['type'] = request.type
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
            action='ReportDeviceLog',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/deviceLogs/report',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.ReportDeviceLogResponse(),
            await self.execute_async(params, req, runtime)
        )

    def report_device_log(
        self,
        request: dingtalkedu__1__0_models.ReportDeviceLogRequest,
    ) -> dingtalkedu__1__0_models.ReportDeviceLogResponse:
        """
        @summary 设备日志上报接口
        
        @param request: ReportDeviceLogRequest
        @return: ReportDeviceLogResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.ReportDeviceLogHeaders()
        return self.report_device_log_with_options(request, headers, runtime)

    async def report_device_log_async(
        self,
        request: dingtalkedu__1__0_models.ReportDeviceLogRequest,
    ) -> dingtalkedu__1__0_models.ReportDeviceLogResponse:
        """
        @summary 设备日志上报接口
        
        @param request: ReportDeviceLogRequest
        @return: ReportDeviceLogResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.ReportDeviceLogHeaders()
        return await self.report_device_log_with_options_async(request, headers, runtime)

    def report_device_use_log_with_options(
        self,
        request: dingtalkedu__1__0_models.ReportDeviceUseLogRequest,
        headers: dingtalkedu__1__0_models.ReportDeviceUseLogHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.ReportDeviceUseLogResponse:
        """
        @summary 上传设备使用日志
        
        @param request: ReportDeviceUseLogRequest
        @param headers: ReportDeviceUseLogHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ReportDeviceUseLogResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action):
            body['action'] = request.action
        if not UtilClient.is_unset(request.order_no):
            body['orderNo'] = request.order_no
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
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
            action='ReportDeviceUseLog',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/deviceUseLogs/report',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.ReportDeviceUseLogResponse(),
            self.execute(params, req, runtime)
        )

    async def report_device_use_log_with_options_async(
        self,
        request: dingtalkedu__1__0_models.ReportDeviceUseLogRequest,
        headers: dingtalkedu__1__0_models.ReportDeviceUseLogHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.ReportDeviceUseLogResponse:
        """
        @summary 上传设备使用日志
        
        @param request: ReportDeviceUseLogRequest
        @param headers: ReportDeviceUseLogHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ReportDeviceUseLogResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action):
            body['action'] = request.action
        if not UtilClient.is_unset(request.order_no):
            body['orderNo'] = request.order_no
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
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
            action='ReportDeviceUseLog',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/deviceUseLogs/report',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.ReportDeviceUseLogResponse(),
            await self.execute_async(params, req, runtime)
        )

    def report_device_use_log(
        self,
        request: dingtalkedu__1__0_models.ReportDeviceUseLogRequest,
    ) -> dingtalkedu__1__0_models.ReportDeviceUseLogResponse:
        """
        @summary 上传设备使用日志
        
        @param request: ReportDeviceUseLogRequest
        @return: ReportDeviceUseLogResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.ReportDeviceUseLogHeaders()
        return self.report_device_use_log_with_options(request, headers, runtime)

    async def report_device_use_log_async(
        self,
        request: dingtalkedu__1__0_models.ReportDeviceUseLogRequest,
    ) -> dingtalkedu__1__0_models.ReportDeviceUseLogResponse:
        """
        @summary 上传设备使用日志
        
        @param request: ReportDeviceUseLogRequest
        @return: ReportDeviceUseLogResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.ReportDeviceUseLogHeaders()
        return await self.report_device_use_log_with_options_async(request, headers, runtime)

    def rollback_deduct_point_with_options(
        self,
        request: dingtalkedu__1__0_models.RollbackDeductPointRequest,
        headers: dingtalkedu__1__0_models.RollbackDeductPointHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.RollbackDeductPointResponse:
        """
        @summary 回滚教育积分扣减
        
        @param request: RollbackDeductPointRequest
        @param headers: RollbackDeductPointHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RollbackDeductPointResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.point_type):
            body['pointType'] = request.point_type
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
            action='RollbackDeductPoint',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/deductPoints/rollback',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.RollbackDeductPointResponse(),
            self.execute(params, req, runtime)
        )

    async def rollback_deduct_point_with_options_async(
        self,
        request: dingtalkedu__1__0_models.RollbackDeductPointRequest,
        headers: dingtalkedu__1__0_models.RollbackDeductPointHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.RollbackDeductPointResponse:
        """
        @summary 回滚教育积分扣减
        
        @param request: RollbackDeductPointRequest
        @param headers: RollbackDeductPointHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RollbackDeductPointResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.point_type):
            body['pointType'] = request.point_type
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
            action='RollbackDeductPoint',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/deductPoints/rollback',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.RollbackDeductPointResponse(),
            await self.execute_async(params, req, runtime)
        )

    def rollback_deduct_point(
        self,
        request: dingtalkedu__1__0_models.RollbackDeductPointRequest,
    ) -> dingtalkedu__1__0_models.RollbackDeductPointResponse:
        """
        @summary 回滚教育积分扣减
        
        @param request: RollbackDeductPointRequest
        @return: RollbackDeductPointResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.RollbackDeductPointHeaders()
        return self.rollback_deduct_point_with_options(request, headers, runtime)

    async def rollback_deduct_point_async(
        self,
        request: dingtalkedu__1__0_models.RollbackDeductPointRequest,
    ) -> dingtalkedu__1__0_models.RollbackDeductPointResponse:
        """
        @summary 回滚教育积分扣减
        
        @param request: RollbackDeductPointRequest
        @return: RollbackDeductPointResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.RollbackDeductPointHeaders()
        return await self.rollback_deduct_point_with_options_async(request, headers, runtime)

    def save_class_learning_data_with_options(
        self,
        request: dingtalkedu__1__0_models.SaveClassLearningDataRequest,
        headers: dingtalkedu__1__0_models.SaveClassLearningDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.SaveClassLearningDataResponse:
        """
        @summary 保存班级学情数据
        
        @param request: SaveClassLearningDataRequest
        @param headers: SaveClassLearningDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SaveClassLearningDataResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.assign_num):
            body['assignNum'] = request.assign_num
        if not UtilClient.is_unset(request.assign_student_user_ids):
            body['assignStudentUserIds'] = request.assign_student_user_ids
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.biz_type):
            body['bizType'] = request.biz_type
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.dept_id):
            body['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.file_suffix):
            body['fileSuffix'] = request.file_suffix
        if not UtilClient.is_unset(request.generated_time):
            body['generatedTime'] = request.generated_time
        if not UtilClient.is_unset(request.question_num):
            body['questionNum'] = request.question_num
        if not UtilClient.is_unset(request.question_picture_num):
            body['questionPictureNum'] = request.question_picture_num
        if not UtilClient.is_unset(request.standard_answer_picture_num):
            body['standardAnswerPictureNum'] = request.standard_answer_picture_num
        if not UtilClient.is_unset(request.subject_code):
            body['subjectCode'] = request.subject_code
        if not UtilClient.is_unset(request.teacher_user_id):
            body['teacherUserId'] = request.teacher_user_id
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
            action='SaveClassLearningData',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/classes/learnings/datas/save',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.SaveClassLearningDataResponse(),
            self.execute(params, req, runtime)
        )

    async def save_class_learning_data_with_options_async(
        self,
        request: dingtalkedu__1__0_models.SaveClassLearningDataRequest,
        headers: dingtalkedu__1__0_models.SaveClassLearningDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.SaveClassLearningDataResponse:
        """
        @summary 保存班级学情数据
        
        @param request: SaveClassLearningDataRequest
        @param headers: SaveClassLearningDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SaveClassLearningDataResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.assign_num):
            body['assignNum'] = request.assign_num
        if not UtilClient.is_unset(request.assign_student_user_ids):
            body['assignStudentUserIds'] = request.assign_student_user_ids
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.biz_type):
            body['bizType'] = request.biz_type
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.dept_id):
            body['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.file_suffix):
            body['fileSuffix'] = request.file_suffix
        if not UtilClient.is_unset(request.generated_time):
            body['generatedTime'] = request.generated_time
        if not UtilClient.is_unset(request.question_num):
            body['questionNum'] = request.question_num
        if not UtilClient.is_unset(request.question_picture_num):
            body['questionPictureNum'] = request.question_picture_num
        if not UtilClient.is_unset(request.standard_answer_picture_num):
            body['standardAnswerPictureNum'] = request.standard_answer_picture_num
        if not UtilClient.is_unset(request.subject_code):
            body['subjectCode'] = request.subject_code
        if not UtilClient.is_unset(request.teacher_user_id):
            body['teacherUserId'] = request.teacher_user_id
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
            action='SaveClassLearningData',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/classes/learnings/datas/save',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.SaveClassLearningDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def save_class_learning_data(
        self,
        request: dingtalkedu__1__0_models.SaveClassLearningDataRequest,
    ) -> dingtalkedu__1__0_models.SaveClassLearningDataResponse:
        """
        @summary 保存班级学情数据
        
        @param request: SaveClassLearningDataRequest
        @return: SaveClassLearningDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.SaveClassLearningDataHeaders()
        return self.save_class_learning_data_with_options(request, headers, runtime)

    async def save_class_learning_data_async(
        self,
        request: dingtalkedu__1__0_models.SaveClassLearningDataRequest,
    ) -> dingtalkedu__1__0_models.SaveClassLearningDataResponse:
        """
        @summary 保存班级学情数据
        
        @param request: SaveClassLearningDataRequest
        @return: SaveClassLearningDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.SaveClassLearningDataHeaders()
        return await self.save_class_learning_data_with_options_async(request, headers, runtime)

    def save_student_learning_data_with_options(
        self,
        request: dingtalkedu__1__0_models.SaveStudentLearningDataRequest,
        headers: dingtalkedu__1__0_models.SaveStudentLearningDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.SaveStudentLearningDataResponse:
        """
        @summary 保存学生学情数据
        
        @param request: SaveStudentLearningDataRequest
        @param headers: SaveStudentLearningDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SaveStudentLearningDataResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.assign_num):
            body['assignNum'] = request.assign_num
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.biz_type):
            body['bizType'] = request.biz_type
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.correct_num):
            body['correctNum'] = request.correct_num
        if not UtilClient.is_unset(request.dept_id):
            body['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.file_suffix):
            body['fileSuffix'] = request.file_suffix
        if not UtilClient.is_unset(request.generated_time):
            body['generatedTime'] = request.generated_time
        if not UtilClient.is_unset(request.question_num):
            body['questionNum'] = request.question_num
        if not UtilClient.is_unset(request.student_user_id):
            body['studentUserId'] = request.student_user_id
        if not UtilClient.is_unset(request.subject_code):
            body['subjectCode'] = request.subject_code
        if not UtilClient.is_unset(request.submit_num):
            body['submitNum'] = request.submit_num
        if not UtilClient.is_unset(request.wrong_questions):
            body['wrongQuestions'] = request.wrong_questions
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
            action='SaveStudentLearningData',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/students/learnings/datas/save',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.SaveStudentLearningDataResponse(),
            self.execute(params, req, runtime)
        )

    async def save_student_learning_data_with_options_async(
        self,
        request: dingtalkedu__1__0_models.SaveStudentLearningDataRequest,
        headers: dingtalkedu__1__0_models.SaveStudentLearningDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.SaveStudentLearningDataResponse:
        """
        @summary 保存学生学情数据
        
        @param request: SaveStudentLearningDataRequest
        @param headers: SaveStudentLearningDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SaveStudentLearningDataResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.assign_num):
            body['assignNum'] = request.assign_num
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.biz_type):
            body['bizType'] = request.biz_type
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.correct_num):
            body['correctNum'] = request.correct_num
        if not UtilClient.is_unset(request.dept_id):
            body['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.file_suffix):
            body['fileSuffix'] = request.file_suffix
        if not UtilClient.is_unset(request.generated_time):
            body['generatedTime'] = request.generated_time
        if not UtilClient.is_unset(request.question_num):
            body['questionNum'] = request.question_num
        if not UtilClient.is_unset(request.student_user_id):
            body['studentUserId'] = request.student_user_id
        if not UtilClient.is_unset(request.subject_code):
            body['subjectCode'] = request.subject_code
        if not UtilClient.is_unset(request.submit_num):
            body['submitNum'] = request.submit_num
        if not UtilClient.is_unset(request.wrong_questions):
            body['wrongQuestions'] = request.wrong_questions
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
            action='SaveStudentLearningData',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/students/learnings/datas/save',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.SaveStudentLearningDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def save_student_learning_data(
        self,
        request: dingtalkedu__1__0_models.SaveStudentLearningDataRequest,
    ) -> dingtalkedu__1__0_models.SaveStudentLearningDataResponse:
        """
        @summary 保存学生学情数据
        
        @param request: SaveStudentLearningDataRequest
        @return: SaveStudentLearningDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.SaveStudentLearningDataHeaders()
        return self.save_student_learning_data_with_options(request, headers, runtime)

    async def save_student_learning_data_async(
        self,
        request: dingtalkedu__1__0_models.SaveStudentLearningDataRequest,
    ) -> dingtalkedu__1__0_models.SaveStudentLearningDataResponse:
        """
        @summary 保存学生学情数据
        
        @param request: SaveStudentLearningDataRequest
        @return: SaveStudentLearningDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.SaveStudentLearningDataHeaders()
        return await self.save_student_learning_data_with_options_async(request, headers, runtime)

    def search_teachers_with_options(
        self,
        request: dingtalkedu__1__0_models.SearchTeachersRequest,
        headers: dingtalkedu__1__0_models.SearchTeachersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.SearchTeachersResponse:
        """
        @summary 按关键字搜索老师
        
        @param request: SearchTeachersRequest
        @param headers: SearchTeachersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SearchTeachersResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.name_keyword):
            query['nameKeyword'] = request.name_keyword
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
            action='SearchTeachers',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/teachers/search',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.SearchTeachersResponse(),
            self.execute(params, req, runtime)
        )

    async def search_teachers_with_options_async(
        self,
        request: dingtalkedu__1__0_models.SearchTeachersRequest,
        headers: dingtalkedu__1__0_models.SearchTeachersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.SearchTeachersResponse:
        """
        @summary 按关键字搜索老师
        
        @param request: SearchTeachersRequest
        @param headers: SearchTeachersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SearchTeachersResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.name_keyword):
            query['nameKeyword'] = request.name_keyword
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
            action='SearchTeachers',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/teachers/search',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.SearchTeachersResponse(),
            await self.execute_async(params, req, runtime)
        )

    def search_teachers(
        self,
        request: dingtalkedu__1__0_models.SearchTeachersRequest,
    ) -> dingtalkedu__1__0_models.SearchTeachersResponse:
        """
        @summary 按关键字搜索老师
        
        @param request: SearchTeachersRequest
        @return: SearchTeachersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.SearchTeachersHeaders()
        return self.search_teachers_with_options(request, headers, runtime)

    async def search_teachers_async(
        self,
        request: dingtalkedu__1__0_models.SearchTeachersRequest,
    ) -> dingtalkedu__1__0_models.SearchTeachersResponse:
        """
        @summary 按关键字搜索老师
        
        @param request: SearchTeachersRequest
        @return: SearchTeachersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.SearchTeachersHeaders()
        return await self.search_teachers_with_options_async(request, headers, runtime)

    def send_ai_card_with_options(
        self,
        request: dingtalkedu__1__0_models.SendAiCardRequest,
        headers: dingtalkedu__1__0_models.SendAiCardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.SendAiCardResponse:
        """
        @summary 套件-发送AI卡片
        
        @param request: SendAiCardRequest
        @param headers: SendAiCardHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SendAiCardResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action_type):
            body['actionType'] = request.action_type
        if not UtilClient.is_unset(request.biz_data):
            body['bizData'] = request.biz_data
        if not UtilClient.is_unset(request.card_channel):
            body['cardChannel'] = request.card_channel
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.identifier):
            body['identifier'] = request.identifier
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
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
            action='SendAiCard',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/kits/aiCards/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.SendAiCardResponse(),
            self.execute(params, req, runtime)
        )

    async def send_ai_card_with_options_async(
        self,
        request: dingtalkedu__1__0_models.SendAiCardRequest,
        headers: dingtalkedu__1__0_models.SendAiCardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.SendAiCardResponse:
        """
        @summary 套件-发送AI卡片
        
        @param request: SendAiCardRequest
        @param headers: SendAiCardHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SendAiCardResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action_type):
            body['actionType'] = request.action_type
        if not UtilClient.is_unset(request.biz_data):
            body['bizData'] = request.biz_data
        if not UtilClient.is_unset(request.card_channel):
            body['cardChannel'] = request.card_channel
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.identifier):
            body['identifier'] = request.identifier
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
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
            action='SendAiCard',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/kits/aiCards/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.SendAiCardResponse(),
            await self.execute_async(params, req, runtime)
        )

    def send_ai_card(
        self,
        request: dingtalkedu__1__0_models.SendAiCardRequest,
    ) -> dingtalkedu__1__0_models.SendAiCardResponse:
        """
        @summary 套件-发送AI卡片
        
        @param request: SendAiCardRequest
        @return: SendAiCardResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.SendAiCardHeaders()
        return self.send_ai_card_with_options(request, headers, runtime)

    async def send_ai_card_async(
        self,
        request: dingtalkedu__1__0_models.SendAiCardRequest,
    ) -> dingtalkedu__1__0_models.SendAiCardResponse:
        """
        @summary 套件-发送AI卡片
        
        @param request: SendAiCardRequest
        @return: SendAiCardResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.SendAiCardHeaders()
        return await self.send_ai_card_with_options_async(request, headers, runtime)

    def send_message_with_options(
        self,
        request: dingtalkedu__1__0_models.SendMessageRequest,
        headers: dingtalkedu__1__0_models.SendMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.SendMessageResponse:
        """
        @summary 亲情通话发消息
        
        @param request: SendMessageRequest
        @param headers: SendMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SendMessageResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.from_user_id):
            body['fromUserId'] = request.from_user_id
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
        if not UtilClient.is_unset(request.to_user_id_list):
            body['toUserIdList'] = request.to_user_id_list
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
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
            action='SendMessage',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/messages/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.SendMessageResponse(),
            self.execute(params, req, runtime)
        )

    async def send_message_with_options_async(
        self,
        request: dingtalkedu__1__0_models.SendMessageRequest,
        headers: dingtalkedu__1__0_models.SendMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.SendMessageResponse:
        """
        @summary 亲情通话发消息
        
        @param request: SendMessageRequest
        @param headers: SendMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SendMessageResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.from_user_id):
            body['fromUserId'] = request.from_user_id
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
        if not UtilClient.is_unset(request.to_user_id_list):
            body['toUserIdList'] = request.to_user_id_list
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
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
            action='SendMessage',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/messages/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.SendMessageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def send_message(
        self,
        request: dingtalkedu__1__0_models.SendMessageRequest,
    ) -> dingtalkedu__1__0_models.SendMessageResponse:
        """
        @summary 亲情通话发消息
        
        @param request: SendMessageRequest
        @return: SendMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.SendMessageHeaders()
        return self.send_message_with_options(request, headers, runtime)

    async def send_message_async(
        self,
        request: dingtalkedu__1__0_models.SendMessageRequest,
    ) -> dingtalkedu__1__0_models.SendMessageResponse:
        """
        @summary 亲情通话发消息
        
        @param request: SendMessageRequest
        @return: SendMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.SendMessageHeaders()
        return await self.send_message_with_options_async(request, headers, runtime)

    def start_course_with_options(
        self,
        request: dingtalkedu__1__0_models.StartCourseRequest,
        headers: dingtalkedu__1__0_models.StartCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.StartCourseResponse:
        """
        @summary 开始课程
        
        @param request: StartCourseRequest
        @param headers: StartCourseHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: StartCourseResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.course_code):
            body['courseCode'] = request.course_code
        if not UtilClient.is_unset(request.ext):
            body['ext'] = request.ext
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.live_play_info_list):
            body['livePlayInfoList'] = request.live_play_info_list
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
            action='StartCourse',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/courses/start',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.StartCourseResponse(),
            self.execute(params, req, runtime)
        )

    async def start_course_with_options_async(
        self,
        request: dingtalkedu__1__0_models.StartCourseRequest,
        headers: dingtalkedu__1__0_models.StartCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.StartCourseResponse:
        """
        @summary 开始课程
        
        @param request: StartCourseRequest
        @param headers: StartCourseHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: StartCourseResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.course_code):
            body['courseCode'] = request.course_code
        if not UtilClient.is_unset(request.ext):
            body['ext'] = request.ext
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.live_play_info_list):
            body['livePlayInfoList'] = request.live_play_info_list
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
            action='StartCourse',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/courses/start',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.StartCourseResponse(),
            await self.execute_async(params, req, runtime)
        )

    def start_course(
        self,
        request: dingtalkedu__1__0_models.StartCourseRequest,
    ) -> dingtalkedu__1__0_models.StartCourseResponse:
        """
        @summary 开始课程
        
        @param request: StartCourseRequest
        @return: StartCourseResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.StartCourseHeaders()
        return self.start_course_with_options(request, headers, runtime)

    async def start_course_async(
        self,
        request: dingtalkedu__1__0_models.StartCourseRequest,
    ) -> dingtalkedu__1__0_models.StartCourseResponse:
        """
        @summary 开始课程
        
        @param request: StartCourseRequest
        @return: StartCourseResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.StartCourseHeaders()
        return await self.start_course_with_options_async(request, headers, runtime)

    def start_course_prepare_with_options(
        self,
        request: dingtalkedu__1__0_models.StartCoursePrepareRequest,
        headers: dingtalkedu__1__0_models.StartCoursePrepareHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.StartCoursePrepareResponse:
        """
        @summary 预开课，发送开课提醒
        
        @param request: StartCoursePrepareRequest
        @param headers: StartCoursePrepareHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: StartCoursePrepareResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.course_date):
            body['courseDate'] = request.course_date
        if not UtilClient.is_unset(request.course_group_code):
            body['courseGroupCode'] = request.course_group_code
        if not UtilClient.is_unset(request.device_id):
            body['deviceId'] = request.device_id
        if not UtilClient.is_unset(request.ext):
            body['ext'] = request.ext
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.live_cover_image):
            body['liveCoverImage'] = request.live_cover_image
        if not UtilClient.is_unset(request.section_index):
            body['sectionIndex'] = request.section_index
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
            action='StartCoursePrepare',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/courses/prepare',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.StartCoursePrepareResponse(),
            self.execute(params, req, runtime)
        )

    async def start_course_prepare_with_options_async(
        self,
        request: dingtalkedu__1__0_models.StartCoursePrepareRequest,
        headers: dingtalkedu__1__0_models.StartCoursePrepareHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.StartCoursePrepareResponse:
        """
        @summary 预开课，发送开课提醒
        
        @param request: StartCoursePrepareRequest
        @param headers: StartCoursePrepareHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: StartCoursePrepareResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.course_date):
            body['courseDate'] = request.course_date
        if not UtilClient.is_unset(request.course_group_code):
            body['courseGroupCode'] = request.course_group_code
        if not UtilClient.is_unset(request.device_id):
            body['deviceId'] = request.device_id
        if not UtilClient.is_unset(request.ext):
            body['ext'] = request.ext
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.live_cover_image):
            body['liveCoverImage'] = request.live_cover_image
        if not UtilClient.is_unset(request.section_index):
            body['sectionIndex'] = request.section_index
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
            action='StartCoursePrepare',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/courses/prepare',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.StartCoursePrepareResponse(),
            await self.execute_async(params, req, runtime)
        )

    def start_course_prepare(
        self,
        request: dingtalkedu__1__0_models.StartCoursePrepareRequest,
    ) -> dingtalkedu__1__0_models.StartCoursePrepareResponse:
        """
        @summary 预开课，发送开课提醒
        
        @param request: StartCoursePrepareRequest
        @return: StartCoursePrepareResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.StartCoursePrepareHeaders()
        return self.start_course_prepare_with_options(request, headers, runtime)

    async def start_course_prepare_async(
        self,
        request: dingtalkedu__1__0_models.StartCoursePrepareRequest,
    ) -> dingtalkedu__1__0_models.StartCoursePrepareResponse:
        """
        @summary 预开课，发送开课提醒
        
        @param request: StartCoursePrepareRequest
        @return: StartCoursePrepareResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.StartCoursePrepareHeaders()
        return await self.start_course_prepare_with_options_async(request, headers, runtime)

    def subscribe_university_course_group_with_options(
        self,
        request: dingtalkedu__1__0_models.SubscribeUniversityCourseGroupRequest,
        headers: dingtalkedu__1__0_models.SubscribeUniversityCourseGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.SubscribeUniversityCourseGroupResponse:
        """
        @summary 订阅大学课程组
        
        @param request: SubscribeUniversityCourseGroupRequest
        @param headers: SubscribeUniversityCourseGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SubscribeUniversityCourseGroupResponse
        """
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
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SubscribeUniversityCourseGroup',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/courseGroups/subscribe',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.SubscribeUniversityCourseGroupResponse(),
            self.execute(params, req, runtime)
        )

    async def subscribe_university_course_group_with_options_async(
        self,
        request: dingtalkedu__1__0_models.SubscribeUniversityCourseGroupRequest,
        headers: dingtalkedu__1__0_models.SubscribeUniversityCourseGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.SubscribeUniversityCourseGroupResponse:
        """
        @summary 订阅大学课程组
        
        @param request: SubscribeUniversityCourseGroupRequest
        @param headers: SubscribeUniversityCourseGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SubscribeUniversityCourseGroupResponse
        """
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
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SubscribeUniversityCourseGroup',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/courseGroups/subscribe',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.SubscribeUniversityCourseGroupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def subscribe_university_course_group(
        self,
        request: dingtalkedu__1__0_models.SubscribeUniversityCourseGroupRequest,
    ) -> dingtalkedu__1__0_models.SubscribeUniversityCourseGroupResponse:
        """
        @summary 订阅大学课程组
        
        @param request: SubscribeUniversityCourseGroupRequest
        @return: SubscribeUniversityCourseGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.SubscribeUniversityCourseGroupHeaders()
        return self.subscribe_university_course_group_with_options(request, headers, runtime)

    async def subscribe_university_course_group_async(
        self,
        request: dingtalkedu__1__0_models.SubscribeUniversityCourseGroupRequest,
    ) -> dingtalkedu__1__0_models.SubscribeUniversityCourseGroupResponse:
        """
        @summary 订阅大学课程组
        
        @param request: SubscribeUniversityCourseGroupRequest
        @return: SubscribeUniversityCourseGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.SubscribeUniversityCourseGroupHeaders()
        return await self.subscribe_university_course_group_with_options_async(request, headers, runtime)

    def unsubscribe_university_course_group_with_options(
        self,
        request: dingtalkedu__1__0_models.UnsubscribeUniversityCourseGroupRequest,
        headers: dingtalkedu__1__0_models.UnsubscribeUniversityCourseGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.UnsubscribeUniversityCourseGroupResponse:
        """
        @summary 取消订阅大学课程组
        
        @param request: UnsubscribeUniversityCourseGroupRequest
        @param headers: UnsubscribeUniversityCourseGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UnsubscribeUniversityCourseGroupResponse
        """
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
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UnsubscribeUniversityCourseGroup',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/courseGroups/unsubscribe',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.UnsubscribeUniversityCourseGroupResponse(),
            self.execute(params, req, runtime)
        )

    async def unsubscribe_university_course_group_with_options_async(
        self,
        request: dingtalkedu__1__0_models.UnsubscribeUniversityCourseGroupRequest,
        headers: dingtalkedu__1__0_models.UnsubscribeUniversityCourseGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.UnsubscribeUniversityCourseGroupResponse:
        """
        @summary 取消订阅大学课程组
        
        @param request: UnsubscribeUniversityCourseGroupRequest
        @param headers: UnsubscribeUniversityCourseGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UnsubscribeUniversityCourseGroupResponse
        """
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
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UnsubscribeUniversityCourseGroup',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/courseGroups/unsubscribe',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.UnsubscribeUniversityCourseGroupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def unsubscribe_university_course_group(
        self,
        request: dingtalkedu__1__0_models.UnsubscribeUniversityCourseGroupRequest,
    ) -> dingtalkedu__1__0_models.UnsubscribeUniversityCourseGroupResponse:
        """
        @summary 取消订阅大学课程组
        
        @param request: UnsubscribeUniversityCourseGroupRequest
        @return: UnsubscribeUniversityCourseGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.UnsubscribeUniversityCourseGroupHeaders()
        return self.unsubscribe_university_course_group_with_options(request, headers, runtime)

    async def unsubscribe_university_course_group_async(
        self,
        request: dingtalkedu__1__0_models.UnsubscribeUniversityCourseGroupRequest,
    ) -> dingtalkedu__1__0_models.UnsubscribeUniversityCourseGroupResponse:
        """
        @summary 取消订阅大学课程组
        
        @param request: UnsubscribeUniversityCourseGroupRequest
        @return: UnsubscribeUniversityCourseGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.UnsubscribeUniversityCourseGroupHeaders()
        return await self.unsubscribe_university_course_group_with_options_async(request, headers, runtime)

    def update_college_alumni_user_info_with_options(
        self,
        request: dingtalkedu__1__0_models.UpdateCollegeAlumniUserInfoRequest,
        headers: dingtalkedu__1__0_models.UpdateCollegeAlumniUserInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.UpdateCollegeAlumniUserInfoResponse:
        """
        @summary 高校校友会更新校友信息
        
        @param request: UpdateCollegeAlumniUserInfoRequest
        @param headers: UpdateCollegeAlumniUserInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateCollegeAlumniUserInfoResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.address):
            body['address'] = request.address
        if not UtilClient.is_unset(request.dept_ids):
            body['deptIds'] = request.dept_ids
        if not UtilClient.is_unset(request.email):
            body['email'] = request.email
        if not UtilClient.is_unset(request.intake):
            body['intake'] = request.intake
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        if not UtilClient.is_unset(request.outtake):
            body['outtake'] = request.outtake
        if not UtilClient.is_unset(request.student_number):
            body['studentNumber'] = request.student_number
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
            action='UpdateCollegeAlumniUserInfo',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/collegeAlumni/userInfos',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.UpdateCollegeAlumniUserInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def update_college_alumni_user_info_with_options_async(
        self,
        request: dingtalkedu__1__0_models.UpdateCollegeAlumniUserInfoRequest,
        headers: dingtalkedu__1__0_models.UpdateCollegeAlumniUserInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.UpdateCollegeAlumniUserInfoResponse:
        """
        @summary 高校校友会更新校友信息
        
        @param request: UpdateCollegeAlumniUserInfoRequest
        @param headers: UpdateCollegeAlumniUserInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateCollegeAlumniUserInfoResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.address):
            body['address'] = request.address
        if not UtilClient.is_unset(request.dept_ids):
            body['deptIds'] = request.dept_ids
        if not UtilClient.is_unset(request.email):
            body['email'] = request.email
        if not UtilClient.is_unset(request.intake):
            body['intake'] = request.intake
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        if not UtilClient.is_unset(request.outtake):
            body['outtake'] = request.outtake
        if not UtilClient.is_unset(request.student_number):
            body['studentNumber'] = request.student_number
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
            action='UpdateCollegeAlumniUserInfo',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/collegeAlumni/userInfos',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.UpdateCollegeAlumniUserInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_college_alumni_user_info(
        self,
        request: dingtalkedu__1__0_models.UpdateCollegeAlumniUserInfoRequest,
    ) -> dingtalkedu__1__0_models.UpdateCollegeAlumniUserInfoResponse:
        """
        @summary 高校校友会更新校友信息
        
        @param request: UpdateCollegeAlumniUserInfoRequest
        @return: UpdateCollegeAlumniUserInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.UpdateCollegeAlumniUserInfoHeaders()
        return self.update_college_alumni_user_info_with_options(request, headers, runtime)

    async def update_college_alumni_user_info_async(
        self,
        request: dingtalkedu__1__0_models.UpdateCollegeAlumniUserInfoRequest,
    ) -> dingtalkedu__1__0_models.UpdateCollegeAlumniUserInfoResponse:
        """
        @summary 高校校友会更新校友信息
        
        @param request: UpdateCollegeAlumniUserInfoRequest
        @return: UpdateCollegeAlumniUserInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.UpdateCollegeAlumniUserInfoHeaders()
        return await self.update_college_alumni_user_info_with_options_async(request, headers, runtime)

    def update_college_contact_dept_with_options(
        self,
        request: dingtalkedu__1__0_models.UpdateCollegeContactDeptRequest,
        headers: dingtalkedu__1__0_models.UpdateCollegeContactDeptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.UpdateCollegeContactDeptResponse:
        """
        @summary 更新高校通讯录组织单元
        
        @param request: UpdateCollegeContactDeptRequest
        @param headers: UpdateCollegeContactDeptHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateCollegeContactDeptResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.auto_add_user):
            body['autoAddUser'] = request.auto_add_user
        if not UtilClient.is_unset(request.auto_approve_apply):
            body['autoApproveApply'] = request.auto_approve_apply
        if not UtilClient.is_unset(request.brief):
            body['brief'] = request.brief
        if not UtilClient.is_unset(request.code):
            body['code'] = request.code
        if not UtilClient.is_unset(request.create_dept_group):
            body['createDeptGroup'] = request.create_dept_group
        if not UtilClient.is_unset(request.dept_code):
            body['deptCode'] = request.dept_code
        if not UtilClient.is_unset(request.dept_id):
            body['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.dept_manager_userid_list):
            body['deptManagerUseridList'] = request.dept_manager_userid_list
        if not UtilClient.is_unset(request.dept_permits):
            body['deptPermits'] = request.dept_permits
        if not UtilClient.is_unset(request.dept_type):
            body['deptType'] = request.dept_type
        if not UtilClient.is_unset(request.emp_apply_join_dept):
            body['empApplyJoinDept'] = request.emp_apply_join_dept
        if not UtilClient.is_unset(request.extension):
            body['extension'] = request.extension
        if not UtilClient.is_unset(request.force_update_fields):
            body['forceUpdateFields'] = request.force_update_fields
        if not UtilClient.is_unset(request.group_contain_hidden_dept):
            body['groupContainHiddenDept'] = request.group_contain_hidden_dept
        if not UtilClient.is_unset(request.group_contain_outer_dept):
            body['groupContainOuterDept'] = request.group_contain_outer_dept
        if not UtilClient.is_unset(request.group_contain_sub_dept):
            body['groupContainSubDept'] = request.group_contain_sub_dept
        if not UtilClient.is_unset(request.hide_dept):
            body['hideDept'] = request.hide_dept
        if not UtilClient.is_unset(request.hide_scene_config):
            body['hideSceneConfig'] = request.hide_scene_config
        if not UtilClient.is_unset(request.language):
            body['language'] = request.language
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.order):
            body['order'] = request.order
        if not UtilClient.is_unset(request.org_dept_owner):
            body['orgDeptOwner'] = request.org_dept_owner
        if not UtilClient.is_unset(request.outer_dept):
            body['outerDept'] = request.outer_dept
        if not UtilClient.is_unset(request.outer_dept_only_self):
            body['outerDeptOnlySelf'] = request.outer_dept_only_self
        if not UtilClient.is_unset(request.outer_permit_depts):
            body['outerPermitDepts'] = request.outer_permit_depts
        if not UtilClient.is_unset(request.outer_permit_users):
            body['outerPermitUsers'] = request.outer_permit_users
        if not UtilClient.is_unset(request.outer_scene_config):
            body['outerSceneConfig'] = request.outer_scene_config
        if not UtilClient.is_unset(request.parent_id):
            body['parentId'] = request.parent_id
        if not UtilClient.is_unset(request.source_identifier):
            body['sourceIdentifier'] = request.source_identifier
        if not UtilClient.is_unset(request.telephone):
            body['telephone'] = request.telephone
        if not UtilClient.is_unset(request.user_permits):
            body['userPermits'] = request.user_permits
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
            action='UpdateCollegeContactDept',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/collegeContact/depts',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.UpdateCollegeContactDeptResponse(),
            self.execute(params, req, runtime)
        )

    async def update_college_contact_dept_with_options_async(
        self,
        request: dingtalkedu__1__0_models.UpdateCollegeContactDeptRequest,
        headers: dingtalkedu__1__0_models.UpdateCollegeContactDeptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.UpdateCollegeContactDeptResponse:
        """
        @summary 更新高校通讯录组织单元
        
        @param request: UpdateCollegeContactDeptRequest
        @param headers: UpdateCollegeContactDeptHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateCollegeContactDeptResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.auto_add_user):
            body['autoAddUser'] = request.auto_add_user
        if not UtilClient.is_unset(request.auto_approve_apply):
            body['autoApproveApply'] = request.auto_approve_apply
        if not UtilClient.is_unset(request.brief):
            body['brief'] = request.brief
        if not UtilClient.is_unset(request.code):
            body['code'] = request.code
        if not UtilClient.is_unset(request.create_dept_group):
            body['createDeptGroup'] = request.create_dept_group
        if not UtilClient.is_unset(request.dept_code):
            body['deptCode'] = request.dept_code
        if not UtilClient.is_unset(request.dept_id):
            body['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.dept_manager_userid_list):
            body['deptManagerUseridList'] = request.dept_manager_userid_list
        if not UtilClient.is_unset(request.dept_permits):
            body['deptPermits'] = request.dept_permits
        if not UtilClient.is_unset(request.dept_type):
            body['deptType'] = request.dept_type
        if not UtilClient.is_unset(request.emp_apply_join_dept):
            body['empApplyJoinDept'] = request.emp_apply_join_dept
        if not UtilClient.is_unset(request.extension):
            body['extension'] = request.extension
        if not UtilClient.is_unset(request.force_update_fields):
            body['forceUpdateFields'] = request.force_update_fields
        if not UtilClient.is_unset(request.group_contain_hidden_dept):
            body['groupContainHiddenDept'] = request.group_contain_hidden_dept
        if not UtilClient.is_unset(request.group_contain_outer_dept):
            body['groupContainOuterDept'] = request.group_contain_outer_dept
        if not UtilClient.is_unset(request.group_contain_sub_dept):
            body['groupContainSubDept'] = request.group_contain_sub_dept
        if not UtilClient.is_unset(request.hide_dept):
            body['hideDept'] = request.hide_dept
        if not UtilClient.is_unset(request.hide_scene_config):
            body['hideSceneConfig'] = request.hide_scene_config
        if not UtilClient.is_unset(request.language):
            body['language'] = request.language
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.order):
            body['order'] = request.order
        if not UtilClient.is_unset(request.org_dept_owner):
            body['orgDeptOwner'] = request.org_dept_owner
        if not UtilClient.is_unset(request.outer_dept):
            body['outerDept'] = request.outer_dept
        if not UtilClient.is_unset(request.outer_dept_only_self):
            body['outerDeptOnlySelf'] = request.outer_dept_only_self
        if not UtilClient.is_unset(request.outer_permit_depts):
            body['outerPermitDepts'] = request.outer_permit_depts
        if not UtilClient.is_unset(request.outer_permit_users):
            body['outerPermitUsers'] = request.outer_permit_users
        if not UtilClient.is_unset(request.outer_scene_config):
            body['outerSceneConfig'] = request.outer_scene_config
        if not UtilClient.is_unset(request.parent_id):
            body['parentId'] = request.parent_id
        if not UtilClient.is_unset(request.source_identifier):
            body['sourceIdentifier'] = request.source_identifier
        if not UtilClient.is_unset(request.telephone):
            body['telephone'] = request.telephone
        if not UtilClient.is_unset(request.user_permits):
            body['userPermits'] = request.user_permits
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
            action='UpdateCollegeContactDept',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/collegeContact/depts',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.UpdateCollegeContactDeptResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_college_contact_dept(
        self,
        request: dingtalkedu__1__0_models.UpdateCollegeContactDeptRequest,
    ) -> dingtalkedu__1__0_models.UpdateCollegeContactDeptResponse:
        """
        @summary 更新高校通讯录组织单元
        
        @param request: UpdateCollegeContactDeptRequest
        @return: UpdateCollegeContactDeptResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.UpdateCollegeContactDeptHeaders()
        return self.update_college_contact_dept_with_options(request, headers, runtime)

    async def update_college_contact_dept_async(
        self,
        request: dingtalkedu__1__0_models.UpdateCollegeContactDeptRequest,
    ) -> dingtalkedu__1__0_models.UpdateCollegeContactDeptResponse:
        """
        @summary 更新高校通讯录组织单元
        
        @param request: UpdateCollegeContactDeptRequest
        @return: UpdateCollegeContactDeptResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.UpdateCollegeContactDeptHeaders()
        return await self.update_college_contact_dept_with_options_async(request, headers, runtime)

    def update_college_contact_exclusive_with_options(
        self,
        request: dingtalkedu__1__0_models.UpdateCollegeContactExclusiveRequest,
        headers: dingtalkedu__1__0_models.UpdateCollegeContactExclusiveHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.UpdateCollegeContactExclusiveResponse:
        """
        @summary 更新高校账号用户
        
        @param request: UpdateCollegeContactExclusiveRequest
        @param headers: UpdateCollegeContactExclusiveHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateCollegeContactExclusiveResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.avatar_media_id):
            body['avatarMediaId'] = request.avatar_media_id
        if not UtilClient.is_unset(request.dept_id_list):
            body['deptIdList'] = request.dept_id_list
        if not UtilClient.is_unset(request.dept_order_list):
            body['deptOrderList'] = request.dept_order_list
        if not UtilClient.is_unset(request.dept_title_list):
            body['deptTitleList'] = request.dept_title_list
        if not UtilClient.is_unset(request.email):
            body['email'] = request.email
        if not UtilClient.is_unset(request.emp_type):
            body['empType'] = request.emp_type
        if not UtilClient.is_unset(request.extension):
            body['extension'] = request.extension
        if not UtilClient.is_unset(request.force_update_fields):
            body['forceUpdateFields'] = request.force_update_fields
        if not UtilClient.is_unset(request.hide_mobile):
            body['hideMobile'] = request.hide_mobile
        if not UtilClient.is_unset(request.hired_date):
            body['hiredDate'] = request.hired_date
        if not UtilClient.is_unset(request.job_number):
            body['jobNumber'] = request.job_number
        if not UtilClient.is_unset(request.language):
            body['language'] = request.language
        if not UtilClient.is_unset(request.login_id_type):
            body['loginIdType'] = request.login_id_type
        if not UtilClient.is_unset(request.main_dept_id):
            body['mainDeptId'] = request.main_dept_id
        if not UtilClient.is_unset(request.manager_userid):
            body['managerUserid'] = request.manager_userid
        if not UtilClient.is_unset(request.mobile):
            body['mobile'] = request.mobile
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.nickname):
            body['nickname'] = request.nickname
        if not UtilClient.is_unset(request.org_email):
            body['orgEmail'] = request.org_email
        if not UtilClient.is_unset(request.org_email_type):
            body['orgEmailType'] = request.org_email_type
        if not UtilClient.is_unset(request.remark):
            body['remark'] = request.remark
        if not UtilClient.is_unset(request.senior_mode):
            body['seniorMode'] = request.senior_mode
        if not UtilClient.is_unset(request.telephone):
            body['telephone'] = request.telephone
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        if not UtilClient.is_unset(request.userid):
            body['userid'] = request.userid
        if not UtilClient.is_unset(request.work_place):
            body['workPlace'] = request.work_place
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
            action='UpdateCollegeContactExclusive',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/collegeContact/exclusiveAccounts/users',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.UpdateCollegeContactExclusiveResponse(),
            self.execute(params, req, runtime)
        )

    async def update_college_contact_exclusive_with_options_async(
        self,
        request: dingtalkedu__1__0_models.UpdateCollegeContactExclusiveRequest,
        headers: dingtalkedu__1__0_models.UpdateCollegeContactExclusiveHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.UpdateCollegeContactExclusiveResponse:
        """
        @summary 更新高校账号用户
        
        @param request: UpdateCollegeContactExclusiveRequest
        @param headers: UpdateCollegeContactExclusiveHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateCollegeContactExclusiveResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.avatar_media_id):
            body['avatarMediaId'] = request.avatar_media_id
        if not UtilClient.is_unset(request.dept_id_list):
            body['deptIdList'] = request.dept_id_list
        if not UtilClient.is_unset(request.dept_order_list):
            body['deptOrderList'] = request.dept_order_list
        if not UtilClient.is_unset(request.dept_title_list):
            body['deptTitleList'] = request.dept_title_list
        if not UtilClient.is_unset(request.email):
            body['email'] = request.email
        if not UtilClient.is_unset(request.emp_type):
            body['empType'] = request.emp_type
        if not UtilClient.is_unset(request.extension):
            body['extension'] = request.extension
        if not UtilClient.is_unset(request.force_update_fields):
            body['forceUpdateFields'] = request.force_update_fields
        if not UtilClient.is_unset(request.hide_mobile):
            body['hideMobile'] = request.hide_mobile
        if not UtilClient.is_unset(request.hired_date):
            body['hiredDate'] = request.hired_date
        if not UtilClient.is_unset(request.job_number):
            body['jobNumber'] = request.job_number
        if not UtilClient.is_unset(request.language):
            body['language'] = request.language
        if not UtilClient.is_unset(request.login_id_type):
            body['loginIdType'] = request.login_id_type
        if not UtilClient.is_unset(request.main_dept_id):
            body['mainDeptId'] = request.main_dept_id
        if not UtilClient.is_unset(request.manager_userid):
            body['managerUserid'] = request.manager_userid
        if not UtilClient.is_unset(request.mobile):
            body['mobile'] = request.mobile
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.nickname):
            body['nickname'] = request.nickname
        if not UtilClient.is_unset(request.org_email):
            body['orgEmail'] = request.org_email
        if not UtilClient.is_unset(request.org_email_type):
            body['orgEmailType'] = request.org_email_type
        if not UtilClient.is_unset(request.remark):
            body['remark'] = request.remark
        if not UtilClient.is_unset(request.senior_mode):
            body['seniorMode'] = request.senior_mode
        if not UtilClient.is_unset(request.telephone):
            body['telephone'] = request.telephone
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        if not UtilClient.is_unset(request.userid):
            body['userid'] = request.userid
        if not UtilClient.is_unset(request.work_place):
            body['workPlace'] = request.work_place
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
            action='UpdateCollegeContactExclusive',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/collegeContact/exclusiveAccounts/users',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.UpdateCollegeContactExclusiveResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_college_contact_exclusive(
        self,
        request: dingtalkedu__1__0_models.UpdateCollegeContactExclusiveRequest,
    ) -> dingtalkedu__1__0_models.UpdateCollegeContactExclusiveResponse:
        """
        @summary 更新高校账号用户
        
        @param request: UpdateCollegeContactExclusiveRequest
        @return: UpdateCollegeContactExclusiveResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.UpdateCollegeContactExclusiveHeaders()
        return self.update_college_contact_exclusive_with_options(request, headers, runtime)

    async def update_college_contact_exclusive_async(
        self,
        request: dingtalkedu__1__0_models.UpdateCollegeContactExclusiveRequest,
    ) -> dingtalkedu__1__0_models.UpdateCollegeContactExclusiveResponse:
        """
        @summary 更新高校账号用户
        
        @param request: UpdateCollegeContactExclusiveRequest
        @return: UpdateCollegeContactExclusiveResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.UpdateCollegeContactExclusiveHeaders()
        return await self.update_college_contact_exclusive_with_options_async(request, headers, runtime)

    def update_college_contact_user_with_options(
        self,
        request: dingtalkedu__1__0_models.UpdateCollegeContactUserRequest,
        headers: dingtalkedu__1__0_models.UpdateCollegeContactUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.UpdateCollegeContactUserResponse:
        """
        @summary 更新个人账号用户
        
        @param request: UpdateCollegeContactUserRequest
        @param headers: UpdateCollegeContactUserHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateCollegeContactUserResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dept_id_list):
            body['deptIdList'] = request.dept_id_list
        if not UtilClient.is_unset(request.dept_order_list):
            body['deptOrderList'] = request.dept_order_list
        if not UtilClient.is_unset(request.dept_title_list):
            body['deptTitleList'] = request.dept_title_list
        if not UtilClient.is_unset(request.email):
            body['email'] = request.email
        if not UtilClient.is_unset(request.emp_type):
            body['empType'] = request.emp_type
        if not UtilClient.is_unset(request.extension):
            body['extension'] = request.extension
        if not UtilClient.is_unset(request.force_update_fields):
            body['forceUpdateFields'] = request.force_update_fields
        if not UtilClient.is_unset(request.hide_mobile):
            body['hideMobile'] = request.hide_mobile
        if not UtilClient.is_unset(request.hired_date):
            body['hiredDate'] = request.hired_date
        if not UtilClient.is_unset(request.job_number):
            body['jobNumber'] = request.job_number
        if not UtilClient.is_unset(request.language):
            body['language'] = request.language
        if not UtilClient.is_unset(request.main_dept_id):
            body['mainDeptId'] = request.main_dept_id
        if not UtilClient.is_unset(request.manager_userid):
            body['managerUserid'] = request.manager_userid
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.org_email):
            body['orgEmail'] = request.org_email
        if not UtilClient.is_unset(request.remark):
            body['remark'] = request.remark
        if not UtilClient.is_unset(request.senior_mode):
            body['seniorMode'] = request.senior_mode
        if not UtilClient.is_unset(request.telephone):
            body['telephone'] = request.telephone
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        if not UtilClient.is_unset(request.userid):
            body['userid'] = request.userid
        if not UtilClient.is_unset(request.work_place):
            body['workPlace'] = request.work_place
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
            action='UpdateCollegeContactUser',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/collegeContact/personalAccounts/users',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.UpdateCollegeContactUserResponse(),
            self.execute(params, req, runtime)
        )

    async def update_college_contact_user_with_options_async(
        self,
        request: dingtalkedu__1__0_models.UpdateCollegeContactUserRequest,
        headers: dingtalkedu__1__0_models.UpdateCollegeContactUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.UpdateCollegeContactUserResponse:
        """
        @summary 更新个人账号用户
        
        @param request: UpdateCollegeContactUserRequest
        @param headers: UpdateCollegeContactUserHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateCollegeContactUserResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dept_id_list):
            body['deptIdList'] = request.dept_id_list
        if not UtilClient.is_unset(request.dept_order_list):
            body['deptOrderList'] = request.dept_order_list
        if not UtilClient.is_unset(request.dept_title_list):
            body['deptTitleList'] = request.dept_title_list
        if not UtilClient.is_unset(request.email):
            body['email'] = request.email
        if not UtilClient.is_unset(request.emp_type):
            body['empType'] = request.emp_type
        if not UtilClient.is_unset(request.extension):
            body['extension'] = request.extension
        if not UtilClient.is_unset(request.force_update_fields):
            body['forceUpdateFields'] = request.force_update_fields
        if not UtilClient.is_unset(request.hide_mobile):
            body['hideMobile'] = request.hide_mobile
        if not UtilClient.is_unset(request.hired_date):
            body['hiredDate'] = request.hired_date
        if not UtilClient.is_unset(request.job_number):
            body['jobNumber'] = request.job_number
        if not UtilClient.is_unset(request.language):
            body['language'] = request.language
        if not UtilClient.is_unset(request.main_dept_id):
            body['mainDeptId'] = request.main_dept_id
        if not UtilClient.is_unset(request.manager_userid):
            body['managerUserid'] = request.manager_userid
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.org_email):
            body['orgEmail'] = request.org_email
        if not UtilClient.is_unset(request.remark):
            body['remark'] = request.remark
        if not UtilClient.is_unset(request.senior_mode):
            body['seniorMode'] = request.senior_mode
        if not UtilClient.is_unset(request.telephone):
            body['telephone'] = request.telephone
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        if not UtilClient.is_unset(request.userid):
            body['userid'] = request.userid
        if not UtilClient.is_unset(request.work_place):
            body['workPlace'] = request.work_place
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
            action='UpdateCollegeContactUser',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/collegeContact/personalAccounts/users',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.UpdateCollegeContactUserResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_college_contact_user(
        self,
        request: dingtalkedu__1__0_models.UpdateCollegeContactUserRequest,
    ) -> dingtalkedu__1__0_models.UpdateCollegeContactUserResponse:
        """
        @summary 更新个人账号用户
        
        @param request: UpdateCollegeContactUserRequest
        @return: UpdateCollegeContactUserResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.UpdateCollegeContactUserHeaders()
        return self.update_college_contact_user_with_options(request, headers, runtime)

    async def update_college_contact_user_async(
        self,
        request: dingtalkedu__1__0_models.UpdateCollegeContactUserRequest,
    ) -> dingtalkedu__1__0_models.UpdateCollegeContactUserResponse:
        """
        @summary 更新个人账号用户
        
        @param request: UpdateCollegeContactUserRequest
        @return: UpdateCollegeContactUserResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.UpdateCollegeContactUserHeaders()
        return await self.update_college_contact_user_with_options_async(request, headers, runtime)

    def update_college_user_emp_type_with_options(
        self,
        request: dingtalkedu__1__0_models.UpdateCollegeUserEmpTypeRequest,
        headers: dingtalkedu__1__0_models.UpdateCollegeUserEmpTypeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.UpdateCollegeUserEmpTypeResponse:
        """
        @summary 修改用户成员类型
        
        @param request: UpdateCollegeUserEmpTypeRequest
        @param headers: UpdateCollegeUserEmpTypeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateCollegeUserEmpTypeResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.emp_type):
            body['empType'] = request.emp_type
        if not UtilClient.is_unset(request.userid):
            body['userid'] = request.userid
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
            action='UpdateCollegeUserEmpType',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/collegeContact/empTypes/change',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.UpdateCollegeUserEmpTypeResponse(),
            self.execute(params, req, runtime)
        )

    async def update_college_user_emp_type_with_options_async(
        self,
        request: dingtalkedu__1__0_models.UpdateCollegeUserEmpTypeRequest,
        headers: dingtalkedu__1__0_models.UpdateCollegeUserEmpTypeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.UpdateCollegeUserEmpTypeResponse:
        """
        @summary 修改用户成员类型
        
        @param request: UpdateCollegeUserEmpTypeRequest
        @param headers: UpdateCollegeUserEmpTypeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateCollegeUserEmpTypeResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.emp_type):
            body['empType'] = request.emp_type
        if not UtilClient.is_unset(request.userid):
            body['userid'] = request.userid
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
            action='UpdateCollegeUserEmpType',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/collegeContact/empTypes/change',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.UpdateCollegeUserEmpTypeResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_college_user_emp_type(
        self,
        request: dingtalkedu__1__0_models.UpdateCollegeUserEmpTypeRequest,
    ) -> dingtalkedu__1__0_models.UpdateCollegeUserEmpTypeResponse:
        """
        @summary 修改用户成员类型
        
        @param request: UpdateCollegeUserEmpTypeRequest
        @return: UpdateCollegeUserEmpTypeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.UpdateCollegeUserEmpTypeHeaders()
        return self.update_college_user_emp_type_with_options(request, headers, runtime)

    async def update_college_user_emp_type_async(
        self,
        request: dingtalkedu__1__0_models.UpdateCollegeUserEmpTypeRequest,
    ) -> dingtalkedu__1__0_models.UpdateCollegeUserEmpTypeResponse:
        """
        @summary 修改用户成员类型
        
        @param request: UpdateCollegeUserEmpTypeRequest
        @return: UpdateCollegeUserEmpTypeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.UpdateCollegeUserEmpTypeHeaders()
        return await self.update_college_user_emp_type_with_options_async(request, headers, runtime)

    def update_courses_of_class_with_options(
        self,
        class_id: str,
        request: dingtalkedu__1__0_models.UpdateCoursesOfClassRequest,
        headers: dingtalkedu__1__0_models.UpdateCoursesOfClassHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.UpdateCoursesOfClassResponse:
        """
        @summary 更新班级课程表（调代课等微调场景）
        
        @param request: UpdateCoursesOfClassRequest
        @param headers: UpdateCoursesOfClassHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateCoursesOfClassResponse
        """
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
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateCoursesOfClass',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/classes/{class_id}/courses/schedules',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.UpdateCoursesOfClassResponse(),
            self.execute(params, req, runtime)
        )

    async def update_courses_of_class_with_options_async(
        self,
        class_id: str,
        request: dingtalkedu__1__0_models.UpdateCoursesOfClassRequest,
        headers: dingtalkedu__1__0_models.UpdateCoursesOfClassHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.UpdateCoursesOfClassResponse:
        """
        @summary 更新班级课程表（调代课等微调场景）
        
        @param request: UpdateCoursesOfClassRequest
        @param headers: UpdateCoursesOfClassHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateCoursesOfClassResponse
        """
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
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateCoursesOfClass',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/classes/{class_id}/courses/schedules',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.UpdateCoursesOfClassResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_courses_of_class(
        self,
        class_id: str,
        request: dingtalkedu__1__0_models.UpdateCoursesOfClassRequest,
    ) -> dingtalkedu__1__0_models.UpdateCoursesOfClassResponse:
        """
        @summary 更新班级课程表（调代课等微调场景）
        
        @param request: UpdateCoursesOfClassRequest
        @return: UpdateCoursesOfClassResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.UpdateCoursesOfClassHeaders()
        return self.update_courses_of_class_with_options(class_id, request, headers, runtime)

    async def update_courses_of_class_async(
        self,
        class_id: str,
        request: dingtalkedu__1__0_models.UpdateCoursesOfClassRequest,
    ) -> dingtalkedu__1__0_models.UpdateCoursesOfClassResponse:
        """
        @summary 更新班级课程表（调代课等微调场景）
        
        @param request: UpdateCoursesOfClassRequest
        @return: UpdateCoursesOfClassResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.UpdateCoursesOfClassHeaders()
        return await self.update_courses_of_class_with_options_async(class_id, request, headers, runtime)

    def update_physical_classroom_with_options(
        self,
        request: dingtalkedu__1__0_models.UpdatePhysicalClassroomRequest,
        headers: dingtalkedu__1__0_models.UpdatePhysicalClassroomHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.UpdatePhysicalClassroomResponse:
        """
        @summary 添加物理教室信息
        
        @param request: UpdatePhysicalClassroomRequest
        @param headers: UpdatePhysicalClassroomHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdatePhysicalClassroomResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.classroom_building):
            body['classroomBuilding'] = request.classroom_building
        if not UtilClient.is_unset(request.classroom_campus):
            body['classroomCampus'] = request.classroom_campus
        if not UtilClient.is_unset(request.classroom_floor):
            body['classroomFloor'] = request.classroom_floor
        if not UtilClient.is_unset(request.classroom_id):
            body['classroomId'] = request.classroom_id
        if not UtilClient.is_unset(request.classroom_name):
            body['classroomName'] = request.classroom_name
        if not UtilClient.is_unset(request.classroom_number):
            body['classroomNumber'] = request.classroom_number
        if not UtilClient.is_unset(request.direct_broadcast):
            body['directBroadcast'] = request.direct_broadcast
        if not UtilClient.is_unset(request.ext):
            body['ext'] = request.ext
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
            action='UpdatePhysicalClassroom',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/physicalClassrooms',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.UpdatePhysicalClassroomResponse(),
            self.execute(params, req, runtime)
        )

    async def update_physical_classroom_with_options_async(
        self,
        request: dingtalkedu__1__0_models.UpdatePhysicalClassroomRequest,
        headers: dingtalkedu__1__0_models.UpdatePhysicalClassroomHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.UpdatePhysicalClassroomResponse:
        """
        @summary 添加物理教室信息
        
        @param request: UpdatePhysicalClassroomRequest
        @param headers: UpdatePhysicalClassroomHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdatePhysicalClassroomResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.classroom_building):
            body['classroomBuilding'] = request.classroom_building
        if not UtilClient.is_unset(request.classroom_campus):
            body['classroomCampus'] = request.classroom_campus
        if not UtilClient.is_unset(request.classroom_floor):
            body['classroomFloor'] = request.classroom_floor
        if not UtilClient.is_unset(request.classroom_id):
            body['classroomId'] = request.classroom_id
        if not UtilClient.is_unset(request.classroom_name):
            body['classroomName'] = request.classroom_name
        if not UtilClient.is_unset(request.classroom_number):
            body['classroomNumber'] = request.classroom_number
        if not UtilClient.is_unset(request.direct_broadcast):
            body['directBroadcast'] = request.direct_broadcast
        if not UtilClient.is_unset(request.ext):
            body['ext'] = request.ext
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
            action='UpdatePhysicalClassroom',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/physicalClassrooms',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.UpdatePhysicalClassroomResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_physical_classroom(
        self,
        request: dingtalkedu__1__0_models.UpdatePhysicalClassroomRequest,
    ) -> dingtalkedu__1__0_models.UpdatePhysicalClassroomResponse:
        """
        @summary 添加物理教室信息
        
        @param request: UpdatePhysicalClassroomRequest
        @return: UpdatePhysicalClassroomResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.UpdatePhysicalClassroomHeaders()
        return self.update_physical_classroom_with_options(request, headers, runtime)

    async def update_physical_classroom_async(
        self,
        request: dingtalkedu__1__0_models.UpdatePhysicalClassroomRequest,
    ) -> dingtalkedu__1__0_models.UpdatePhysicalClassroomResponse:
        """
        @summary 添加物理教室信息
        
        @param request: UpdatePhysicalClassroomRequest
        @return: UpdatePhysicalClassroomResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.UpdatePhysicalClassroomHeaders()
        return await self.update_physical_classroom_with_options_async(request, headers, runtime)

    def update_remote_class_course_with_options(
        self,
        request: dingtalkedu__1__0_models.UpdateRemoteClassCourseRequest,
        headers: dingtalkedu__1__0_models.UpdateRemoteClassCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.UpdateRemoteClassCourseResponse:
        """
        @summary 更新专递课堂课程
        
        @param request: UpdateRemoteClassCourseRequest
        @param headers: UpdateRemoteClassCourseHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateRemoteClassCourseResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.attend_participants):
            body['attendParticipants'] = request.attend_participants
        if not UtilClient.is_unset(request.auth_code):
            body['authCode'] = request.auth_code
        if not UtilClient.is_unset(request.course_code):
            body['courseCode'] = request.course_code
        if not UtilClient.is_unset(request.course_name):
            body['courseName'] = request.course_name
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.teaching_participant):
            body['teachingParticipant'] = request.teaching_participant
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
            action='UpdateRemoteClassCourse',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/remoteClasses/courses',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.UpdateRemoteClassCourseResponse(),
            self.execute(params, req, runtime)
        )

    async def update_remote_class_course_with_options_async(
        self,
        request: dingtalkedu__1__0_models.UpdateRemoteClassCourseRequest,
        headers: dingtalkedu__1__0_models.UpdateRemoteClassCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.UpdateRemoteClassCourseResponse:
        """
        @summary 更新专递课堂课程
        
        @param request: UpdateRemoteClassCourseRequest
        @param headers: UpdateRemoteClassCourseHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateRemoteClassCourseResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.attend_participants):
            body['attendParticipants'] = request.attend_participants
        if not UtilClient.is_unset(request.auth_code):
            body['authCode'] = request.auth_code
        if not UtilClient.is_unset(request.course_code):
            body['courseCode'] = request.course_code
        if not UtilClient.is_unset(request.course_name):
            body['courseName'] = request.course_name
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.teaching_participant):
            body['teachingParticipant'] = request.teaching_participant
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
            action='UpdateRemoteClassCourse',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/remoteClasses/courses',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.UpdateRemoteClassCourseResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_remote_class_course(
        self,
        request: dingtalkedu__1__0_models.UpdateRemoteClassCourseRequest,
    ) -> dingtalkedu__1__0_models.UpdateRemoteClassCourseResponse:
        """
        @summary 更新专递课堂课程
        
        @param request: UpdateRemoteClassCourseRequest
        @return: UpdateRemoteClassCourseResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.UpdateRemoteClassCourseHeaders()
        return self.update_remote_class_course_with_options(request, headers, runtime)

    async def update_remote_class_course_async(
        self,
        request: dingtalkedu__1__0_models.UpdateRemoteClassCourseRequest,
    ) -> dingtalkedu__1__0_models.UpdateRemoteClassCourseResponse:
        """
        @summary 更新专递课堂课程
        
        @param request: UpdateRemoteClassCourseRequest
        @return: UpdateRemoteClassCourseResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.UpdateRemoteClassCourseHeaders()
        return await self.update_remote_class_course_with_options_async(request, headers, runtime)

    def update_remote_class_device_with_options(
        self,
        request: dingtalkedu__1__0_models.UpdateRemoteClassDeviceRequest,
        headers: dingtalkedu__1__0_models.UpdateRemoteClassDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.UpdateRemoteClassDeviceResponse:
        """
        @summary 更新设备名称
        
        @param request: UpdateRemoteClassDeviceRequest
        @param headers: UpdateRemoteClassDeviceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateRemoteClassDeviceResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.auth_code):
            query['authCode'] = request.auth_code
        if not UtilClient.is_unset(request.device_code):
            query['deviceCode'] = request.device_code
        if not UtilClient.is_unset(request.device_name):
            query['deviceName'] = request.device_name
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
            action='UpdateRemoteClassDevice',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/remoteClasses/deviceNames',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.UpdateRemoteClassDeviceResponse(),
            self.execute(params, req, runtime)
        )

    async def update_remote_class_device_with_options_async(
        self,
        request: dingtalkedu__1__0_models.UpdateRemoteClassDeviceRequest,
        headers: dingtalkedu__1__0_models.UpdateRemoteClassDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.UpdateRemoteClassDeviceResponse:
        """
        @summary 更新设备名称
        
        @param request: UpdateRemoteClassDeviceRequest
        @param headers: UpdateRemoteClassDeviceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateRemoteClassDeviceResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.auth_code):
            query['authCode'] = request.auth_code
        if not UtilClient.is_unset(request.device_code):
            query['deviceCode'] = request.device_code
        if not UtilClient.is_unset(request.device_name):
            query['deviceName'] = request.device_name
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
            action='UpdateRemoteClassDevice',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/remoteClasses/deviceNames',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.UpdateRemoteClassDeviceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_remote_class_device(
        self,
        request: dingtalkedu__1__0_models.UpdateRemoteClassDeviceRequest,
    ) -> dingtalkedu__1__0_models.UpdateRemoteClassDeviceResponse:
        """
        @summary 更新设备名称
        
        @param request: UpdateRemoteClassDeviceRequest
        @return: UpdateRemoteClassDeviceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.UpdateRemoteClassDeviceHeaders()
        return self.update_remote_class_device_with_options(request, headers, runtime)

    async def update_remote_class_device_async(
        self,
        request: dingtalkedu__1__0_models.UpdateRemoteClassDeviceRequest,
    ) -> dingtalkedu__1__0_models.UpdateRemoteClassDeviceResponse:
        """
        @summary 更新设备名称
        
        @param request: UpdateRemoteClassDeviceRequest
        @return: UpdateRemoteClassDeviceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.UpdateRemoteClassDeviceHeaders()
        return await self.update_remote_class_device_with_options_async(request, headers, runtime)

    def update_university_course_group_with_options(
        self,
        request: dingtalkedu__1__0_models.UpdateUniversityCourseGroupRequest,
        headers: dingtalkedu__1__0_models.UpdateUniversityCourseGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.UpdateUniversityCourseGroupResponse:
        """
        @summary 更新大学课程组
        
        @param request: UpdateUniversityCourseGroupRequest
        @param headers: UpdateUniversityCourseGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateUniversityCourseGroupResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.course_group_code):
            body['courseGroupCode'] = request.course_group_code
        if not UtilClient.is_unset(request.course_group_introduce):
            body['courseGroupIntroduce'] = request.course_group_introduce
        if not UtilClient.is_unset(request.course_group_name):
            body['courseGroupName'] = request.course_group_name
        if not UtilClient.is_unset(request.courser_group_item_models):
            body['courserGroupItemModels'] = request.courser_group_item_models
        if not UtilClient.is_unset(request.ext):
            body['ext'] = request.ext
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
            action='UpdateUniversityCourseGroup',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/courseGroups',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.UpdateUniversityCourseGroupResponse(),
            self.execute(params, req, runtime)
        )

    async def update_university_course_group_with_options_async(
        self,
        request: dingtalkedu__1__0_models.UpdateUniversityCourseGroupRequest,
        headers: dingtalkedu__1__0_models.UpdateUniversityCourseGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.UpdateUniversityCourseGroupResponse:
        """
        @summary 更新大学课程组
        
        @param request: UpdateUniversityCourseGroupRequest
        @param headers: UpdateUniversityCourseGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateUniversityCourseGroupResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.course_group_code):
            body['courseGroupCode'] = request.course_group_code
        if not UtilClient.is_unset(request.course_group_introduce):
            body['courseGroupIntroduce'] = request.course_group_introduce
        if not UtilClient.is_unset(request.course_group_name):
            body['courseGroupName'] = request.course_group_name
        if not UtilClient.is_unset(request.courser_group_item_models):
            body['courserGroupItemModels'] = request.courser_group_item_models
        if not UtilClient.is_unset(request.ext):
            body['ext'] = request.ext
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
            action='UpdateUniversityCourseGroup',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/courseGroups',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.UpdateUniversityCourseGroupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_university_course_group(
        self,
        request: dingtalkedu__1__0_models.UpdateUniversityCourseGroupRequest,
    ) -> dingtalkedu__1__0_models.UpdateUniversityCourseGroupResponse:
        """
        @summary 更新大学课程组
        
        @param request: UpdateUniversityCourseGroupRequest
        @return: UpdateUniversityCourseGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.UpdateUniversityCourseGroupHeaders()
        return self.update_university_course_group_with_options(request, headers, runtime)

    async def update_university_course_group_async(
        self,
        request: dingtalkedu__1__0_models.UpdateUniversityCourseGroupRequest,
    ) -> dingtalkedu__1__0_models.UpdateUniversityCourseGroupResponse:
        """
        @summary 更新大学课程组
        
        @param request: UpdateUniversityCourseGroupRequest
        @return: UpdateUniversityCourseGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.UpdateUniversityCourseGroupHeaders()
        return await self.update_university_course_group_with_options_async(request, headers, runtime)

    def upload_learning_data_callback_with_options(
        self,
        request: dingtalkedu__1__0_models.UploadLearningDataCallbackRequest,
        headers: dingtalkedu__1__0_models.UploadLearningDataCallbackHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.UploadLearningDataCallbackResponse:
        """
        @summary 上传学情图片回调
        
        @param request: UploadLearningDataCallbackRequest
        @param headers: UploadLearningDataCallbackHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UploadLearningDataCallbackResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.biz_type):
            body['bizType'] = request.biz_type
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.dept_id):
            body['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.generated_time):
            body['generatedTime'] = request.generated_time
        if not UtilClient.is_unset(request.student_user_id):
            body['studentUserId'] = request.student_user_id
        if not UtilClient.is_unset(request.subject_code):
            body['subjectCode'] = request.subject_code
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
            action='UploadLearningDataCallback',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/uploadLearnings/datas/callback',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.UploadLearningDataCallbackResponse(),
            self.execute(params, req, runtime)
        )

    async def upload_learning_data_callback_with_options_async(
        self,
        request: dingtalkedu__1__0_models.UploadLearningDataCallbackRequest,
        headers: dingtalkedu__1__0_models.UploadLearningDataCallbackHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.UploadLearningDataCallbackResponse:
        """
        @summary 上传学情图片回调
        
        @param request: UploadLearningDataCallbackRequest
        @param headers: UploadLearningDataCallbackHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UploadLearningDataCallbackResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.biz_type):
            body['bizType'] = request.biz_type
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.dept_id):
            body['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.generated_time):
            body['generatedTime'] = request.generated_time
        if not UtilClient.is_unset(request.student_user_id):
            body['studentUserId'] = request.student_user_id
        if not UtilClient.is_unset(request.subject_code):
            body['subjectCode'] = request.subject_code
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
            action='UploadLearningDataCallback',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/uploadLearnings/datas/callback',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.UploadLearningDataCallbackResponse(),
            await self.execute_async(params, req, runtime)
        )

    def upload_learning_data_callback(
        self,
        request: dingtalkedu__1__0_models.UploadLearningDataCallbackRequest,
    ) -> dingtalkedu__1__0_models.UploadLearningDataCallbackResponse:
        """
        @summary 上传学情图片回调
        
        @param request: UploadLearningDataCallbackRequest
        @return: UploadLearningDataCallbackResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.UploadLearningDataCallbackHeaders()
        return self.upload_learning_data_callback_with_options(request, headers, runtime)

    async def upload_learning_data_callback_async(
        self,
        request: dingtalkedu__1__0_models.UploadLearningDataCallbackRequest,
    ) -> dingtalkedu__1__0_models.UploadLearningDataCallbackResponse:
        """
        @summary 上传学情图片回调
        
        @param request: UploadLearningDataCallbackRequest
        @return: UploadLearningDataCallbackResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.UploadLearningDataCallbackHeaders()
        return await self.upload_learning_data_callback_with_options_async(request, headers, runtime)

    def v_paas_proxy_with_options(
        self,
        request: dingtalkedu__1__0_models.VPaasProxyRequest,
        headers: dingtalkedu__1__0_models.VPaasProxyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.VPaasProxyResponse:
        """
        @summary 视讯PAAS接口代理
        
        @param request: VPaasProxyRequest
        @param headers: VPaasProxyHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: VPaasProxyResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action_code):
            body['actionCode'] = request.action_code
        if not UtilClient.is_unset(request.params):
            body['params'] = request.params
        if not UtilClient.is_unset(request.public_key):
            body['publicKey'] = request.public_key
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
            action='VPaasProxy',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/vpaas/proxy',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.VPaasProxyResponse(),
            self.execute(params, req, runtime)
        )

    async def v_paas_proxy_with_options_async(
        self,
        request: dingtalkedu__1__0_models.VPaasProxyRequest,
        headers: dingtalkedu__1__0_models.VPaasProxyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.VPaasProxyResponse:
        """
        @summary 视讯PAAS接口代理
        
        @param request: VPaasProxyRequest
        @param headers: VPaasProxyHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: VPaasProxyResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action_code):
            body['actionCode'] = request.action_code
        if not UtilClient.is_unset(request.params):
            body['params'] = request.params
        if not UtilClient.is_unset(request.public_key):
            body['publicKey'] = request.public_key
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
            action='VPaasProxy',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/vpaas/proxy',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.VPaasProxyResponse(),
            await self.execute_async(params, req, runtime)
        )

    def v_paas_proxy(
        self,
        request: dingtalkedu__1__0_models.VPaasProxyRequest,
    ) -> dingtalkedu__1__0_models.VPaasProxyResponse:
        """
        @summary 视讯PAAS接口代理
        
        @param request: VPaasProxyRequest
        @return: VPaasProxyResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.VPaasProxyHeaders()
        return self.v_paas_proxy_with_options(request, headers, runtime)

    async def v_paas_proxy_async(
        self,
        request: dingtalkedu__1__0_models.VPaasProxyRequest,
    ) -> dingtalkedu__1__0_models.VPaasProxyResponse:
        """
        @summary 视讯PAAS接口代理
        
        @param request: VPaasProxyRequest
        @return: VPaasProxyResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.VPaasProxyHeaders()
        return await self.v_paas_proxy_with_options_async(request, headers, runtime)

    def validate_new_grade_manager_with_options(
        self,
        request: dingtalkedu__1__0_models.ValidateNewGradeManagerRequest,
        headers: dingtalkedu__1__0_models.ValidateNewGradeManagerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.ValidateNewGradeManagerResponse:
        """
        @summary 校验开学季任务是否完成
        
        @param request: ValidateNewGradeManagerRequest
        @param headers: ValidateNewGradeManagerHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ValidateNewGradeManagerResponse
        """
        UtilClient.validate_model(request)
        body = {}
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
            action='ValidateNewGradeManager',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/newGrades/tasks/validate',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.ValidateNewGradeManagerResponse(),
            self.execute(params, req, runtime)
        )

    async def validate_new_grade_manager_with_options_async(
        self,
        request: dingtalkedu__1__0_models.ValidateNewGradeManagerRequest,
        headers: dingtalkedu__1__0_models.ValidateNewGradeManagerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.ValidateNewGradeManagerResponse:
        """
        @summary 校验开学季任务是否完成
        
        @param request: ValidateNewGradeManagerRequest
        @param headers: ValidateNewGradeManagerHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ValidateNewGradeManagerResponse
        """
        UtilClient.validate_model(request)
        body = {}
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
            action='ValidateNewGradeManager',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/newGrades/tasks/validate',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.ValidateNewGradeManagerResponse(),
            await self.execute_async(params, req, runtime)
        )

    def validate_new_grade_manager(
        self,
        request: dingtalkedu__1__0_models.ValidateNewGradeManagerRequest,
    ) -> dingtalkedu__1__0_models.ValidateNewGradeManagerResponse:
        """
        @summary 校验开学季任务是否完成
        
        @param request: ValidateNewGradeManagerRequest
        @return: ValidateNewGradeManagerResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.ValidateNewGradeManagerHeaders()
        return self.validate_new_grade_manager_with_options(request, headers, runtime)

    async def validate_new_grade_manager_async(
        self,
        request: dingtalkedu__1__0_models.ValidateNewGradeManagerRequest,
    ) -> dingtalkedu__1__0_models.ValidateNewGradeManagerResponse:
        """
        @summary 校验开学季任务是否完成
        
        @param request: ValidateNewGradeManagerRequest
        @return: ValidateNewGradeManagerResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.ValidateNewGradeManagerHeaders()
        return await self.validate_new_grade_manager_with_options_async(request, headers, runtime)

    def validate_user_role_with_options(
        self,
        request: dingtalkedu__1__0_models.ValidateUserRoleRequest,
        headers: dingtalkedu__1__0_models.ValidateUserRoleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.ValidateUserRoleResponse:
        """
        @summary 校验用户的教育角色
        
        @param request: ValidateUserRoleRequest
        @param headers: ValidateUserRoleHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ValidateUserRoleResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.time_threshold):
            body['timeThreshold'] = request.time_threshold
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
            action='ValidateUserRole',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/users/roles/validate',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.ValidateUserRoleResponse(),
            self.execute(params, req, runtime)
        )

    async def validate_user_role_with_options_async(
        self,
        request: dingtalkedu__1__0_models.ValidateUserRoleRequest,
        headers: dingtalkedu__1__0_models.ValidateUserRoleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.ValidateUserRoleResponse:
        """
        @summary 校验用户的教育角色
        
        @param request: ValidateUserRoleRequest
        @param headers: ValidateUserRoleHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ValidateUserRoleResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.time_threshold):
            body['timeThreshold'] = request.time_threshold
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
            action='ValidateUserRole',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/users/roles/validate',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.ValidateUserRoleResponse(),
            await self.execute_async(params, req, runtime)
        )

    def validate_user_role(
        self,
        request: dingtalkedu__1__0_models.ValidateUserRoleRequest,
    ) -> dingtalkedu__1__0_models.ValidateUserRoleResponse:
        """
        @summary 校验用户的教育角色
        
        @param request: ValidateUserRoleRequest
        @return: ValidateUserRoleResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.ValidateUserRoleHeaders()
        return self.validate_user_role_with_options(request, headers, runtime)

    async def validate_user_role_async(
        self,
        request: dingtalkedu__1__0_models.ValidateUserRoleRequest,
    ) -> dingtalkedu__1__0_models.ValidateUserRoleResponse:
        """
        @summary 校验用户的教育角色
        
        @param request: ValidateUserRoleRequest
        @return: ValidateUserRoleResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.ValidateUserRoleHeaders()
        return await self.validate_user_role_with_options_async(request, headers, runtime)

    def query_class_course_with_options(
        self,
        request: dingtalkedu__1__0_models.QueryClassCourseRequest,
        headers: dingtalkedu__1__0_models.QueryClassCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryClassCourseResponse:
        """
        @summary 查询班级课程
        
        @param request: QueryClassCourseRequest
        @param headers: QueryClassCourseHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryClassCourseResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.class_id):
            body['classId'] = request.class_id
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.isv_course_id):
            body['isvCourseId'] = request.isv_course_id
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
            action='queryClassCourse',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/kits/classes/courses/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryClassCourseResponse(),
            self.execute(params, req, runtime)
        )

    async def query_class_course_with_options_async(
        self,
        request: dingtalkedu__1__0_models.QueryClassCourseRequest,
        headers: dingtalkedu__1__0_models.QueryClassCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryClassCourseResponse:
        """
        @summary 查询班级课程
        
        @param request: QueryClassCourseRequest
        @param headers: QueryClassCourseHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryClassCourseResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.class_id):
            body['classId'] = request.class_id
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.isv_course_id):
            body['isvCourseId'] = request.isv_course_id
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
            action='queryClassCourse',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/kits/classes/courses/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryClassCourseResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_class_course(
        self,
        request: dingtalkedu__1__0_models.QueryClassCourseRequest,
    ) -> dingtalkedu__1__0_models.QueryClassCourseResponse:
        """
        @summary 查询班级课程
        
        @param request: QueryClassCourseRequest
        @return: QueryClassCourseResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryClassCourseHeaders()
        return self.query_class_course_with_options(request, headers, runtime)

    async def query_class_course_async(
        self,
        request: dingtalkedu__1__0_models.QueryClassCourseRequest,
    ) -> dingtalkedu__1__0_models.QueryClassCourseResponse:
        """
        @summary 查询班级课程
        
        @param request: QueryClassCourseRequest
        @return: QueryClassCourseResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryClassCourseHeaders()
        return await self.query_class_course_with_options_async(request, headers, runtime)
