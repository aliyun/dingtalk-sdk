# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalkattendance_1_0 import models as dingtalkattendance__1__0_models
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

    def create_approve(
        self,
        request: dingtalkattendance__1__0_models.CreateApproveRequest,
    ) -> dingtalkattendance__1__0_models.CreateApproveResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.CreateApproveHeaders()
        return self.create_approve_with_options(request, headers, runtime)

    async def create_approve_async(
        self,
        request: dingtalkattendance__1__0_models.CreateApproveRequest,
    ) -> dingtalkattendance__1__0_models.CreateApproveResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.CreateApproveHeaders()
        return await self.create_approve_with_options_async(request, headers, runtime)

    def create_approve_with_options(
        self,
        request: dingtalkattendance__1__0_models.CreateApproveRequest,
        headers: dingtalkattendance__1__0_models.CreateApproveHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.CreateApproveResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.userid):
            body['userid'] = request.userid
        if not UtilClient.is_unset(request.tag_name):
            body['tagName'] = request.tag_name
        if not UtilClient.is_unset(request.sub_type):
            body['subType'] = request.sub_type
        if not UtilClient.is_unset(request.punch_param):
            body['punchParam'] = request.punch_param
        if not UtilClient.is_unset(request.approve_id):
            body['approveId'] = request.approve_id
        if not UtilClient.is_unset(request.op_userid):
            body['opUserid'] = request.op_userid
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
            dingtalkattendance__1__0_models.CreateApproveResponse(),
            self.do_roarequest('CreateApprove', 'attendance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/attendance/approves', 'json', req, runtime)
        )

    async def create_approve_with_options_async(
        self,
        request: dingtalkattendance__1__0_models.CreateApproveRequest,
        headers: dingtalkattendance__1__0_models.CreateApproveHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.CreateApproveResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.userid):
            body['userid'] = request.userid
        if not UtilClient.is_unset(request.tag_name):
            body['tagName'] = request.tag_name
        if not UtilClient.is_unset(request.sub_type):
            body['subType'] = request.sub_type
        if not UtilClient.is_unset(request.punch_param):
            body['punchParam'] = request.punch_param
        if not UtilClient.is_unset(request.approve_id):
            body['approveId'] = request.approve_id
        if not UtilClient.is_unset(request.op_userid):
            body['opUserid'] = request.op_userid
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
            dingtalkattendance__1__0_models.CreateApproveResponse(),
            await self.do_roarequest_async('CreateApprove', 'attendance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/attendance/approves', 'json', req, runtime)
        )

    def get_user_holidays(
        self,
        request: dingtalkattendance__1__0_models.GetUserHolidaysRequest,
    ) -> dingtalkattendance__1__0_models.GetUserHolidaysResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.GetUserHolidaysHeaders()
        return self.get_user_holidays_with_options(request, headers, runtime)

    async def get_user_holidays_async(
        self,
        request: dingtalkattendance__1__0_models.GetUserHolidaysRequest,
    ) -> dingtalkattendance__1__0_models.GetUserHolidaysResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.GetUserHolidaysHeaders()
        return await self.get_user_holidays_with_options_async(request, headers, runtime)

    def get_user_holidays_with_options(
        self,
        request: dingtalkattendance__1__0_models.GetUserHolidaysRequest,
        headers: dingtalkattendance__1__0_models.GetUserHolidaysHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.GetUserHolidaysResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.user_ids):
            body['userIds'] = request.user_ids
        if not UtilClient.is_unset(request.work_date_from):
            body['workDateFrom'] = request.work_date_from
        if not UtilClient.is_unset(request.work_date_to):
            body['workDateTo'] = request.work_date_to
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
            dingtalkattendance__1__0_models.GetUserHolidaysResponse(),
            self.do_roarequest('GetUserHolidays', 'attendance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/attendance/holidays', 'json', req, runtime)
        )

    async def get_user_holidays_with_options_async(
        self,
        request: dingtalkattendance__1__0_models.GetUserHolidaysRequest,
        headers: dingtalkattendance__1__0_models.GetUserHolidaysHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.GetUserHolidaysResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.user_ids):
            body['userIds'] = request.user_ids
        if not UtilClient.is_unset(request.work_date_from):
            body['workDateFrom'] = request.work_date_from
        if not UtilClient.is_unset(request.work_date_to):
            body['workDateTo'] = request.work_date_to
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
            dingtalkattendance__1__0_models.GetUserHolidaysResponse(),
            await self.do_roarequest_async('GetUserHolidays', 'attendance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/attendance/holidays', 'json', req, runtime)
        )
