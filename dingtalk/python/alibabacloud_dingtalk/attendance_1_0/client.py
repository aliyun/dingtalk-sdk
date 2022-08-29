# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.attendance_1_0 import models as dingtalkattendance__1__0_models
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

    def add_leave_type(
        self,
        request: dingtalkattendance__1__0_models.AddLeaveTypeRequest,
    ) -> dingtalkattendance__1__0_models.AddLeaveTypeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.AddLeaveTypeHeaders()
        return self.add_leave_type_with_options(request, headers, runtime)

    async def add_leave_type_async(
        self,
        request: dingtalkattendance__1__0_models.AddLeaveTypeRequest,
    ) -> dingtalkattendance__1__0_models.AddLeaveTypeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.AddLeaveTypeHeaders()
        return await self.add_leave_type_with_options_async(request, headers, runtime)

    def add_leave_type_with_options(
        self,
        request: dingtalkattendance__1__0_models.AddLeaveTypeRequest,
        headers: dingtalkattendance__1__0_models.AddLeaveTypeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.AddLeaveTypeResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.biz_type):
            body['bizType'] = request.biz_type
        if not UtilClient.is_unset(request.extras):
            body['extras'] = request.extras
        if not UtilClient.is_unset(request.hours_in_per_day):
            body['hoursInPerDay'] = request.hours_in_per_day
        if not UtilClient.is_unset(request.leave_certificate):
            body['leaveCertificate'] = request.leave_certificate
        if not UtilClient.is_unset(request.leave_name):
            body['leaveName'] = request.leave_name
        if not UtilClient.is_unset(request.leave_view_unit):
            body['leaveViewUnit'] = request.leave_view_unit
        if not UtilClient.is_unset(request.natural_day_leave):
            body['naturalDayLeave'] = request.natural_day_leave
        if not UtilClient.is_unset(request.submit_time_rule):
            body['submitTimeRule'] = request.submit_time_rule
        if not UtilClient.is_unset(request.visibility_rules):
            body['visibilityRules'] = request.visibility_rules
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
            dingtalkattendance__1__0_models.AddLeaveTypeResponse(),
            self.do_roarequest('AddLeaveType', 'attendance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/attendance/leaves/types', 'json', req, runtime)
        )

    async def add_leave_type_with_options_async(
        self,
        request: dingtalkattendance__1__0_models.AddLeaveTypeRequest,
        headers: dingtalkattendance__1__0_models.AddLeaveTypeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.AddLeaveTypeResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.biz_type):
            body['bizType'] = request.biz_type
        if not UtilClient.is_unset(request.extras):
            body['extras'] = request.extras
        if not UtilClient.is_unset(request.hours_in_per_day):
            body['hoursInPerDay'] = request.hours_in_per_day
        if not UtilClient.is_unset(request.leave_certificate):
            body['leaveCertificate'] = request.leave_certificate
        if not UtilClient.is_unset(request.leave_name):
            body['leaveName'] = request.leave_name
        if not UtilClient.is_unset(request.leave_view_unit):
            body['leaveViewUnit'] = request.leave_view_unit
        if not UtilClient.is_unset(request.natural_day_leave):
            body['naturalDayLeave'] = request.natural_day_leave
        if not UtilClient.is_unset(request.submit_time_rule):
            body['submitTimeRule'] = request.submit_time_rule
        if not UtilClient.is_unset(request.visibility_rules):
            body['visibilityRules'] = request.visibility_rules
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
            dingtalkattendance__1__0_models.AddLeaveTypeResponse(),
            await self.do_roarequest_async('AddLeaveType', 'attendance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/attendance/leaves/types', 'json', req, runtime)
        )

    def attendance_ble_devices_add(
        self,
        request: dingtalkattendance__1__0_models.AttendanceBleDevicesAddRequest,
    ) -> dingtalkattendance__1__0_models.AttendanceBleDevicesAddResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.AttendanceBleDevicesAddHeaders()
        return self.attendance_ble_devices_add_with_options(request, headers, runtime)

    async def attendance_ble_devices_add_async(
        self,
        request: dingtalkattendance__1__0_models.AttendanceBleDevicesAddRequest,
    ) -> dingtalkattendance__1__0_models.AttendanceBleDevicesAddResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.AttendanceBleDevicesAddHeaders()
        return await self.attendance_ble_devices_add_with_options_async(request, headers, runtime)

    def attendance_ble_devices_add_with_options(
        self,
        request: dingtalkattendance__1__0_models.AttendanceBleDevicesAddRequest,
        headers: dingtalkattendance__1__0_models.AttendanceBleDevicesAddHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.AttendanceBleDevicesAddResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.device_id_list):
            body['deviceIdList'] = request.device_id_list
        if not UtilClient.is_unset(request.group_key):
            body['groupKey'] = request.group_key
        if not UtilClient.is_unset(request.op_user_id):
            body['opUserId'] = request.op_user_id
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
            dingtalkattendance__1__0_models.AttendanceBleDevicesAddResponse(),
            self.do_roarequest('AttendanceBleDevicesAdd', 'attendance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/attendance/group/bledevices', 'json', req, runtime)
        )

    async def attendance_ble_devices_add_with_options_async(
        self,
        request: dingtalkattendance__1__0_models.AttendanceBleDevicesAddRequest,
        headers: dingtalkattendance__1__0_models.AttendanceBleDevicesAddHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.AttendanceBleDevicesAddResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.device_id_list):
            body['deviceIdList'] = request.device_id_list
        if not UtilClient.is_unset(request.group_key):
            body['groupKey'] = request.group_key
        if not UtilClient.is_unset(request.op_user_id):
            body['opUserId'] = request.op_user_id
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
            dingtalkattendance__1__0_models.AttendanceBleDevicesAddResponse(),
            await self.do_roarequest_async('AttendanceBleDevicesAdd', 'attendance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/attendance/group/bledevices', 'json', req, runtime)
        )

    def attendance_ble_devices_query(
        self,
        request: dingtalkattendance__1__0_models.AttendanceBleDevicesQueryRequest,
    ) -> dingtalkattendance__1__0_models.AttendanceBleDevicesQueryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.AttendanceBleDevicesQueryHeaders()
        return self.attendance_ble_devices_query_with_options(request, headers, runtime)

    async def attendance_ble_devices_query_async(
        self,
        request: dingtalkattendance__1__0_models.AttendanceBleDevicesQueryRequest,
    ) -> dingtalkattendance__1__0_models.AttendanceBleDevicesQueryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.AttendanceBleDevicesQueryHeaders()
        return await self.attendance_ble_devices_query_with_options_async(request, headers, runtime)

    def attendance_ble_devices_query_with_options(
        self,
        request: dingtalkattendance__1__0_models.AttendanceBleDevicesQueryRequest,
        headers: dingtalkattendance__1__0_models.AttendanceBleDevicesQueryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.AttendanceBleDevicesQueryResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.group_key):
            body['groupKey'] = request.group_key
        if not UtilClient.is_unset(request.op_user_id):
            body['opUserId'] = request.op_user_id
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
            dingtalkattendance__1__0_models.AttendanceBleDevicesQueryResponse(),
            self.do_roarequest_with_form('AttendanceBleDevicesQuery', 'attendance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/attendance/group/bledevices/query', 'json', req, runtime)
        )

    async def attendance_ble_devices_query_with_options_async(
        self,
        request: dingtalkattendance__1__0_models.AttendanceBleDevicesQueryRequest,
        headers: dingtalkattendance__1__0_models.AttendanceBleDevicesQueryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.AttendanceBleDevicesQueryResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.group_key):
            body['groupKey'] = request.group_key
        if not UtilClient.is_unset(request.op_user_id):
            body['opUserId'] = request.op_user_id
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
            dingtalkattendance__1__0_models.AttendanceBleDevicesQueryResponse(),
            await self.do_roarequest_with_form_async('AttendanceBleDevicesQuery', 'attendance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/attendance/group/bledevices/query', 'json', req, runtime)
        )

    def attendance_ble_devices_remove(
        self,
        request: dingtalkattendance__1__0_models.AttendanceBleDevicesRemoveRequest,
    ) -> dingtalkattendance__1__0_models.AttendanceBleDevicesRemoveResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.AttendanceBleDevicesRemoveHeaders()
        return self.attendance_ble_devices_remove_with_options(request, headers, runtime)

    async def attendance_ble_devices_remove_async(
        self,
        request: dingtalkattendance__1__0_models.AttendanceBleDevicesRemoveRequest,
    ) -> dingtalkattendance__1__0_models.AttendanceBleDevicesRemoveResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.AttendanceBleDevicesRemoveHeaders()
        return await self.attendance_ble_devices_remove_with_options_async(request, headers, runtime)

    def attendance_ble_devices_remove_with_options(
        self,
        request: dingtalkattendance__1__0_models.AttendanceBleDevicesRemoveRequest,
        headers: dingtalkattendance__1__0_models.AttendanceBleDevicesRemoveHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.AttendanceBleDevicesRemoveResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.device_id_list):
            body['deviceIdList'] = request.device_id_list
        if not UtilClient.is_unset(request.group_key):
            body['groupKey'] = request.group_key
        if not UtilClient.is_unset(request.op_user_id):
            body['opUserId'] = request.op_user_id
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
            dingtalkattendance__1__0_models.AttendanceBleDevicesRemoveResponse(),
            self.do_roarequest('AttendanceBleDevicesRemove', 'attendance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/attendance/group/bledevices/remove', 'json', req, runtime)
        )

    async def attendance_ble_devices_remove_with_options_async(
        self,
        request: dingtalkattendance__1__0_models.AttendanceBleDevicesRemoveRequest,
        headers: dingtalkattendance__1__0_models.AttendanceBleDevicesRemoveHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.AttendanceBleDevicesRemoveResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.device_id_list):
            body['deviceIdList'] = request.device_id_list
        if not UtilClient.is_unset(request.group_key):
            body['groupKey'] = request.group_key
        if not UtilClient.is_unset(request.op_user_id):
            body['opUserId'] = request.op_user_id
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
            dingtalkattendance__1__0_models.AttendanceBleDevicesRemoveResponse(),
            await self.do_roarequest_async('AttendanceBleDevicesRemove', 'attendance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/attendance/group/bledevices/remove', 'json', req, runtime)
        )

    def check_closing_account(
        self,
        request: dingtalkattendance__1__0_models.CheckClosingAccountRequest,
    ) -> dingtalkattendance__1__0_models.CheckClosingAccountResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.CheckClosingAccountHeaders()
        return self.check_closing_account_with_options(request, headers, runtime)

    async def check_closing_account_async(
        self,
        request: dingtalkattendance__1__0_models.CheckClosingAccountRequest,
    ) -> dingtalkattendance__1__0_models.CheckClosingAccountResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.CheckClosingAccountHeaders()
        return await self.check_closing_account_with_options_async(request, headers, runtime)

    def check_closing_account_with_options(
        self,
        request: dingtalkattendance__1__0_models.CheckClosingAccountRequest,
        headers: dingtalkattendance__1__0_models.CheckClosingAccountHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.CheckClosingAccountResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_code):
            body['bizCode'] = request.biz_code
        if not UtilClient.is_unset(request.user_ids):
            body['userIds'] = request.user_ids
        if not UtilClient.is_unset(request.user_time_range):
            body['userTimeRange'] = request.user_time_range
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
            dingtalkattendance__1__0_models.CheckClosingAccountResponse(),
            self.do_roarequest('CheckClosingAccount', 'attendance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/attendance/closingAccounts/status/query', 'json', req, runtime)
        )

    async def check_closing_account_with_options_async(
        self,
        request: dingtalkattendance__1__0_models.CheckClosingAccountRequest,
        headers: dingtalkattendance__1__0_models.CheckClosingAccountHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.CheckClosingAccountResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_code):
            body['bizCode'] = request.biz_code
        if not UtilClient.is_unset(request.user_ids):
            body['userIds'] = request.user_ids
        if not UtilClient.is_unset(request.user_time_range):
            body['userTimeRange'] = request.user_time_range
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
            dingtalkattendance__1__0_models.CheckClosingAccountResponse(),
            await self.do_roarequest_async('CheckClosingAccount', 'attendance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/attendance/closingAccounts/status/query', 'json', req, runtime)
        )

    def check_write_permission(
        self,
        request: dingtalkattendance__1__0_models.CheckWritePermissionRequest,
    ) -> dingtalkattendance__1__0_models.CheckWritePermissionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.CheckWritePermissionHeaders()
        return self.check_write_permission_with_options(request, headers, runtime)

    async def check_write_permission_async(
        self,
        request: dingtalkattendance__1__0_models.CheckWritePermissionRequest,
    ) -> dingtalkattendance__1__0_models.CheckWritePermissionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.CheckWritePermissionHeaders()
        return await self.check_write_permission_with_options_async(request, headers, runtime)

    def check_write_permission_with_options(
        self,
        request: dingtalkattendance__1__0_models.CheckWritePermissionRequest,
        headers: dingtalkattendance__1__0_models.CheckWritePermissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.CheckWritePermissionResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.category):
            body['category'] = request.category
        if not UtilClient.is_unset(request.entity_ids):
            body['entityIds'] = request.entity_ids
        if not UtilClient.is_unset(request.op_user_id):
            body['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.resource_key):
            body['resourceKey'] = request.resource_key
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
            dingtalkattendance__1__0_models.CheckWritePermissionResponse(),
            self.do_roarequest('CheckWritePermission', 'attendance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/attendance/writePermissions/query', 'json', req, runtime)
        )

    async def check_write_permission_with_options_async(
        self,
        request: dingtalkattendance__1__0_models.CheckWritePermissionRequest,
        headers: dingtalkattendance__1__0_models.CheckWritePermissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.CheckWritePermissionResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.category):
            body['category'] = request.category
        if not UtilClient.is_unset(request.entity_ids):
            body['entityIds'] = request.entity_ids
        if not UtilClient.is_unset(request.op_user_id):
            body['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.resource_key):
            body['resourceKey'] = request.resource_key
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
            dingtalkattendance__1__0_models.CheckWritePermissionResponse(),
            await self.do_roarequest_async('CheckWritePermission', 'attendance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/attendance/writePermissions/query', 'json', req, runtime)
        )

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
        if not UtilClient.is_unset(request.approve_id):
            body['approveId'] = request.approve_id
        if not UtilClient.is_unset(request.op_userid):
            body['opUserid'] = request.op_userid
        if not UtilClient.is_unset(request.punch_param):
            body['punchParam'] = request.punch_param
        if not UtilClient.is_unset(request.sub_type):
            body['subType'] = request.sub_type
        if not UtilClient.is_unset(request.tag_name):
            body['tagName'] = request.tag_name
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
        if not UtilClient.is_unset(request.approve_id):
            body['approveId'] = request.approve_id
        if not UtilClient.is_unset(request.op_userid):
            body['opUserid'] = request.op_userid
        if not UtilClient.is_unset(request.punch_param):
            body['punchParam'] = request.punch_param
        if not UtilClient.is_unset(request.sub_type):
            body['subType'] = request.sub_type
        if not UtilClient.is_unset(request.tag_name):
            body['tagName'] = request.tag_name
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
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.CreateApproveResponse(),
            await self.do_roarequest_async('CreateApprove', 'attendance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/attendance/approves', 'json', req, runtime)
        )

    def delete_water_mark_template(
        self,
        request: dingtalkattendance__1__0_models.DeleteWaterMarkTemplateRequest,
    ) -> dingtalkattendance__1__0_models.DeleteWaterMarkTemplateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.DeleteWaterMarkTemplateHeaders()
        return self.delete_water_mark_template_with_options(request, headers, runtime)

    async def delete_water_mark_template_async(
        self,
        request: dingtalkattendance__1__0_models.DeleteWaterMarkTemplateRequest,
    ) -> dingtalkattendance__1__0_models.DeleteWaterMarkTemplateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.DeleteWaterMarkTemplateHeaders()
        return await self.delete_water_mark_template_with_options_async(request, headers, runtime)

    def delete_water_mark_template_with_options(
        self,
        request: dingtalkattendance__1__0_models.DeleteWaterMarkTemplateRequest,
        headers: dingtalkattendance__1__0_models.DeleteWaterMarkTemplateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.DeleteWaterMarkTemplateResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.form_code):
            query['formCode'] = request.form_code
        if not UtilClient.is_unset(request.form_content):
            query['formContent'] = request.form_content
        if not UtilClient.is_unset(request.open_conversation_id):
            query['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.system_template):
            query['systemTemplate'] = request.system_template
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
            dingtalkattendance__1__0_models.DeleteWaterMarkTemplateResponse(),
            self.do_roarequest('DeleteWaterMarkTemplate', 'attendance_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/attendance/watermarks/templates', 'json', req, runtime)
        )

    async def delete_water_mark_template_with_options_async(
        self,
        request: dingtalkattendance__1__0_models.DeleteWaterMarkTemplateRequest,
        headers: dingtalkattendance__1__0_models.DeleteWaterMarkTemplateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.DeleteWaterMarkTemplateResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.form_code):
            query['formCode'] = request.form_code
        if not UtilClient.is_unset(request.form_content):
            query['formContent'] = request.form_content
        if not UtilClient.is_unset(request.open_conversation_id):
            query['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.system_template):
            query['systemTemplate'] = request.system_template
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
            dingtalkattendance__1__0_models.DeleteWaterMarkTemplateResponse(),
            await self.do_roarequest_async('DeleteWaterMarkTemplate', 'attendance_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/attendance/watermarks/templates', 'json', req, runtime)
        )

    def ding_talk_security_check(
        self,
        request: dingtalkattendance__1__0_models.DingTalkSecurityCheckRequest,
    ) -> dingtalkattendance__1__0_models.DingTalkSecurityCheckResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.DingTalkSecurityCheckHeaders()
        return self.ding_talk_security_check_with_options(request, headers, runtime)

    async def ding_talk_security_check_async(
        self,
        request: dingtalkattendance__1__0_models.DingTalkSecurityCheckRequest,
    ) -> dingtalkattendance__1__0_models.DingTalkSecurityCheckResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.DingTalkSecurityCheckHeaders()
        return await self.ding_talk_security_check_with_options_async(request, headers, runtime)

    def ding_talk_security_check_with_options(
        self,
        request: dingtalkattendance__1__0_models.DingTalkSecurityCheckRequest,
        headers: dingtalkattendance__1__0_models.DingTalkSecurityCheckHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.DingTalkSecurityCheckResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.client_ver):
            body['clientVer'] = request.client_ver
        if not UtilClient.is_unset(request.platform):
            body['platform'] = request.platform
        if not UtilClient.is_unset(request.platform_ver):
            body['platformVer'] = request.platform_ver
        if not UtilClient.is_unset(request.sec):
            body['sec'] = request.sec
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
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.DingTalkSecurityCheckResponse(),
            self.do_roarequest('DingTalkSecurityCheck', 'attendance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/attendance/securities/check', 'json', req, runtime)
        )

    async def ding_talk_security_check_with_options_async(
        self,
        request: dingtalkattendance__1__0_models.DingTalkSecurityCheckRequest,
        headers: dingtalkattendance__1__0_models.DingTalkSecurityCheckHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.DingTalkSecurityCheckResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.client_ver):
            body['clientVer'] = request.client_ver
        if not UtilClient.is_unset(request.platform):
            body['platform'] = request.platform
        if not UtilClient.is_unset(request.platform_ver):
            body['platformVer'] = request.platform_ver
        if not UtilClient.is_unset(request.sec):
            body['sec'] = request.sec
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
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.DingTalkSecurityCheckResponse(),
            await self.do_roarequest_async('DingTalkSecurityCheck', 'attendance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/attendance/securities/check', 'json', req, runtime)
        )

    def get_atmanage_scope(
        self,
        request: dingtalkattendance__1__0_models.GetATManageScopeRequest,
    ) -> dingtalkattendance__1__0_models.GetATManageScopeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.GetATManageScopeHeaders()
        return self.get_atmanage_scope_with_options(request, headers, runtime)

    async def get_atmanage_scope_async(
        self,
        request: dingtalkattendance__1__0_models.GetATManageScopeRequest,
    ) -> dingtalkattendance__1__0_models.GetATManageScopeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.GetATManageScopeHeaders()
        return await self.get_atmanage_scope_with_options_async(request, headers, runtime)

    def get_atmanage_scope_with_options(
        self,
        request: dingtalkattendance__1__0_models.GetATManageScopeRequest,
        headers: dingtalkattendance__1__0_models.GetATManageScopeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.GetATManageScopeResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
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
            dingtalkattendance__1__0_models.GetATManageScopeResponse(),
            self.do_roarequest('GetATManageScope', 'attendance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/attendance/manageScopes', 'json', req, runtime)
        )

    async def get_atmanage_scope_with_options_async(
        self,
        request: dingtalkattendance__1__0_models.GetATManageScopeRequest,
        headers: dingtalkattendance__1__0_models.GetATManageScopeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.GetATManageScopeResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
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
            dingtalkattendance__1__0_models.GetATManageScopeResponse(),
            await self.do_roarequest_async('GetATManageScope', 'attendance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/attendance/manageScopes', 'json', req, runtime)
        )

    def get_adjustments(
        self,
        request: dingtalkattendance__1__0_models.GetAdjustmentsRequest,
    ) -> dingtalkattendance__1__0_models.GetAdjustmentsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.GetAdjustmentsHeaders()
        return self.get_adjustments_with_options(request, headers, runtime)

    async def get_adjustments_async(
        self,
        request: dingtalkattendance__1__0_models.GetAdjustmentsRequest,
    ) -> dingtalkattendance__1__0_models.GetAdjustmentsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.GetAdjustmentsHeaders()
        return await self.get_adjustments_with_options_async(request, headers, runtime)

    def get_adjustments_with_options(
        self,
        request: dingtalkattendance__1__0_models.GetAdjustmentsRequest,
        headers: dingtalkattendance__1__0_models.GetAdjustmentsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.GetAdjustmentsResponse:
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
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.GetAdjustmentsResponse(),
            self.do_roarequest('GetAdjustments', 'attendance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/attendance/adjustments', 'json', req, runtime)
        )

    async def get_adjustments_with_options_async(
        self,
        request: dingtalkattendance__1__0_models.GetAdjustmentsRequest,
        headers: dingtalkattendance__1__0_models.GetAdjustmentsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.GetAdjustmentsResponse:
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
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.GetAdjustmentsResponse(),
            await self.do_roarequest_async('GetAdjustments', 'attendance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/attendance/adjustments', 'json', req, runtime)
        )

    def get_check_in_schema_template(
        self,
        request: dingtalkattendance__1__0_models.GetCheckInSchemaTemplateRequest,
    ) -> dingtalkattendance__1__0_models.GetCheckInSchemaTemplateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.GetCheckInSchemaTemplateHeaders()
        return self.get_check_in_schema_template_with_options(request, headers, runtime)

    async def get_check_in_schema_template_async(
        self,
        request: dingtalkattendance__1__0_models.GetCheckInSchemaTemplateRequest,
    ) -> dingtalkattendance__1__0_models.GetCheckInSchemaTemplateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.GetCheckInSchemaTemplateHeaders()
        return await self.get_check_in_schema_template_with_options_async(request, headers, runtime)

    def get_check_in_schema_template_with_options(
        self,
        request: dingtalkattendance__1__0_models.GetCheckInSchemaTemplateRequest,
        headers: dingtalkattendance__1__0_models.GetCheckInSchemaTemplateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.GetCheckInSchemaTemplateResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.biz_code):
            query['bizCode'] = request.biz_code
        if not UtilClient.is_unset(request.open_conversation_id):
            query['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.scene_code):
            query['sceneCode'] = request.scene_code
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
            dingtalkattendance__1__0_models.GetCheckInSchemaTemplateResponse(),
            self.do_roarequest('GetCheckInSchemaTemplate', 'attendance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/attendance/watermarks/templates', 'json', req, runtime)
        )

    async def get_check_in_schema_template_with_options_async(
        self,
        request: dingtalkattendance__1__0_models.GetCheckInSchemaTemplateRequest,
        headers: dingtalkattendance__1__0_models.GetCheckInSchemaTemplateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.GetCheckInSchemaTemplateResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.biz_code):
            query['bizCode'] = request.biz_code
        if not UtilClient.is_unset(request.open_conversation_id):
            query['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.scene_code):
            query['sceneCode'] = request.scene_code
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
            dingtalkattendance__1__0_models.GetCheckInSchemaTemplateResponse(),
            await self.do_roarequest_async('GetCheckInSchemaTemplate', 'attendance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/attendance/watermarks/templates', 'json', req, runtime)
        )

    def get_closing_accounts(
        self,
        request: dingtalkattendance__1__0_models.GetClosingAccountsRequest,
    ) -> dingtalkattendance__1__0_models.GetClosingAccountsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.GetClosingAccountsHeaders()
        return self.get_closing_accounts_with_options(request, headers, runtime)

    async def get_closing_accounts_async(
        self,
        request: dingtalkattendance__1__0_models.GetClosingAccountsRequest,
    ) -> dingtalkattendance__1__0_models.GetClosingAccountsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.GetClosingAccountsHeaders()
        return await self.get_closing_accounts_with_options_async(request, headers, runtime)

    def get_closing_accounts_with_options(
        self,
        request: dingtalkattendance__1__0_models.GetClosingAccountsRequest,
        headers: dingtalkattendance__1__0_models.GetClosingAccountsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.GetClosingAccountsResponse:
        UtilClient.validate_model(request)
        body = {}
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
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.GetClosingAccountsResponse(),
            self.do_roarequest('GetClosingAccounts', 'attendance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/attendance/closingAccounts/rules/query', 'json', req, runtime)
        )

    async def get_closing_accounts_with_options_async(
        self,
        request: dingtalkattendance__1__0_models.GetClosingAccountsRequest,
        headers: dingtalkattendance__1__0_models.GetClosingAccountsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.GetClosingAccountsResponse:
        UtilClient.validate_model(request)
        body = {}
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
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.GetClosingAccountsResponse(),
            await self.do_roarequest_async('GetClosingAccounts', 'attendance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/attendance/closingAccounts/rules/query', 'json', req, runtime)
        )

    def get_leave_type(
        self,
        request: dingtalkattendance__1__0_models.GetLeaveTypeRequest,
    ) -> dingtalkattendance__1__0_models.GetLeaveTypeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.GetLeaveTypeHeaders()
        return self.get_leave_type_with_options(request, headers, runtime)

    async def get_leave_type_async(
        self,
        request: dingtalkattendance__1__0_models.GetLeaveTypeRequest,
    ) -> dingtalkattendance__1__0_models.GetLeaveTypeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.GetLeaveTypeHeaders()
        return await self.get_leave_type_with_options_async(request, headers, runtime)

    def get_leave_type_with_options(
        self,
        request: dingtalkattendance__1__0_models.GetLeaveTypeRequest,
        headers: dingtalkattendance__1__0_models.GetLeaveTypeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.GetLeaveTypeResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.vacation_source):
            query['vacationSource'] = request.vacation_source
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
            dingtalkattendance__1__0_models.GetLeaveTypeResponse(),
            self.do_roarequest('GetLeaveType', 'attendance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/attendance/leaves/types', 'json', req, runtime)
        )

    async def get_leave_type_with_options_async(
        self,
        request: dingtalkattendance__1__0_models.GetLeaveTypeRequest,
        headers: dingtalkattendance__1__0_models.GetLeaveTypeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.GetLeaveTypeResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.vacation_source):
            query['vacationSource'] = request.vacation_source
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
            dingtalkattendance__1__0_models.GetLeaveTypeResponse(),
            await self.do_roarequest_async('GetLeaveType', 'attendance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/attendance/leaves/types', 'json', req, runtime)
        )

    def get_machine(
        self,
        dev_id: str,
    ) -> dingtalkattendance__1__0_models.GetMachineResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.GetMachineHeaders()
        return self.get_machine_with_options(dev_id, headers, runtime)

    async def get_machine_async(
        self,
        dev_id: str,
    ) -> dingtalkattendance__1__0_models.GetMachineResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.GetMachineHeaders()
        return await self.get_machine_with_options_async(dev_id, headers, runtime)

    def get_machine_with_options(
        self,
        dev_id: str,
        headers: dingtalkattendance__1__0_models.GetMachineHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.GetMachineResponse:
        dev_id = OpenApiUtilClient.get_encode_param(dev_id)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.GetMachineResponse(),
            self.do_roarequest('GetMachine', 'attendance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/attendance/machines/{dev_id}', 'json', req, runtime)
        )

    async def get_machine_with_options_async(
        self,
        dev_id: str,
        headers: dingtalkattendance__1__0_models.GetMachineHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.GetMachineResponse:
        dev_id = OpenApiUtilClient.get_encode_param(dev_id)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.GetMachineResponse(),
            await self.do_roarequest_async('GetMachine', 'attendance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/attendance/machines/{dev_id}', 'json', req, runtime)
        )

    def get_machine_user(
        self,
        dev_id: str,
        request: dingtalkattendance__1__0_models.GetMachineUserRequest,
    ) -> dingtalkattendance__1__0_models.GetMachineUserResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.GetMachineUserHeaders()
        return self.get_machine_user_with_options(dev_id, request, headers, runtime)

    async def get_machine_user_async(
        self,
        dev_id: str,
        request: dingtalkattendance__1__0_models.GetMachineUserRequest,
    ) -> dingtalkattendance__1__0_models.GetMachineUserResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.GetMachineUserHeaders()
        return await self.get_machine_user_with_options_async(dev_id, request, headers, runtime)

    def get_machine_user_with_options(
        self,
        dev_id: str,
        request: dingtalkattendance__1__0_models.GetMachineUserRequest,
        headers: dingtalkattendance__1__0_models.GetMachineUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.GetMachineUserResponse:
        UtilClient.validate_model(request)
        dev_id = OpenApiUtilClient.get_encode_param(dev_id)
        query = {}
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
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.GetMachineUserResponse(),
            self.do_roarequest('GetMachineUser', 'attendance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/attendance/machines/getUser/{dev_id}', 'json', req, runtime)
        )

    async def get_machine_user_with_options_async(
        self,
        dev_id: str,
        request: dingtalkattendance__1__0_models.GetMachineUserRequest,
        headers: dingtalkattendance__1__0_models.GetMachineUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.GetMachineUserResponse:
        UtilClient.validate_model(request)
        dev_id = OpenApiUtilClient.get_encode_param(dev_id)
        query = {}
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
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.GetMachineUserResponse(),
            await self.do_roarequest_async('GetMachineUser', 'attendance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/attendance/machines/getUser/{dev_id}', 'json', req, runtime)
        )

    def get_overtime_setting(
        self,
        request: dingtalkattendance__1__0_models.GetOvertimeSettingRequest,
    ) -> dingtalkattendance__1__0_models.GetOvertimeSettingResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.GetOvertimeSettingHeaders()
        return self.get_overtime_setting_with_options(request, headers, runtime)

    async def get_overtime_setting_async(
        self,
        request: dingtalkattendance__1__0_models.GetOvertimeSettingRequest,
    ) -> dingtalkattendance__1__0_models.GetOvertimeSettingResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.GetOvertimeSettingHeaders()
        return await self.get_overtime_setting_with_options_async(request, headers, runtime)

    def get_overtime_setting_with_options(
        self,
        request: dingtalkattendance__1__0_models.GetOvertimeSettingRequest,
        headers: dingtalkattendance__1__0_models.GetOvertimeSettingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.GetOvertimeSettingResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.overtime_setting_ids):
            body['overtimeSettingIds'] = request.overtime_setting_ids
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
            dingtalkattendance__1__0_models.GetOvertimeSettingResponse(),
            self.do_roarequest('GetOvertimeSetting', 'attendance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/attendance/overtimeSettings/query', 'json', req, runtime)
        )

    async def get_overtime_setting_with_options_async(
        self,
        request: dingtalkattendance__1__0_models.GetOvertimeSettingRequest,
        headers: dingtalkattendance__1__0_models.GetOvertimeSettingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.GetOvertimeSettingResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.overtime_setting_ids):
            body['overtimeSettingIds'] = request.overtime_setting_ids
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
            dingtalkattendance__1__0_models.GetOvertimeSettingResponse(),
            await self.do_roarequest_async('GetOvertimeSetting', 'attendance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/attendance/overtimeSettings/query', 'json', req, runtime)
        )

    def get_simple_overtime_setting(
        self,
        request: dingtalkattendance__1__0_models.GetSimpleOvertimeSettingRequest,
    ) -> dingtalkattendance__1__0_models.GetSimpleOvertimeSettingResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.GetSimpleOvertimeSettingHeaders()
        return self.get_simple_overtime_setting_with_options(request, headers, runtime)

    async def get_simple_overtime_setting_async(
        self,
        request: dingtalkattendance__1__0_models.GetSimpleOvertimeSettingRequest,
    ) -> dingtalkattendance__1__0_models.GetSimpleOvertimeSettingResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.GetSimpleOvertimeSettingHeaders()
        return await self.get_simple_overtime_setting_with_options_async(request, headers, runtime)

    def get_simple_overtime_setting_with_options(
        self,
        request: dingtalkattendance__1__0_models.GetSimpleOvertimeSettingRequest,
        headers: dingtalkattendance__1__0_models.GetSimpleOvertimeSettingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.GetSimpleOvertimeSettingResponse:
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
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.GetSimpleOvertimeSettingResponse(),
            self.do_roarequest('GetSimpleOvertimeSetting', 'attendance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/attendance/overtimeSettings', 'json', req, runtime)
        )

    async def get_simple_overtime_setting_with_options_async(
        self,
        request: dingtalkattendance__1__0_models.GetSimpleOvertimeSettingRequest,
        headers: dingtalkattendance__1__0_models.GetSimpleOvertimeSettingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.GetSimpleOvertimeSettingResponse:
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
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.GetSimpleOvertimeSettingResponse(),
            await self.do_roarequest_async('GetSimpleOvertimeSetting', 'attendance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/attendance/overtimeSettings', 'json', req, runtime)
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
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
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
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.GetUserHolidaysResponse(),
            await self.do_roarequest_async('GetUserHolidays', 'attendance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/attendance/holidays', 'json', req, runtime)
        )

    def group_add(
        self,
        request: dingtalkattendance__1__0_models.GroupAddRequest,
    ) -> dingtalkattendance__1__0_models.GroupAddResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.GroupAddHeaders()
        return self.group_add_with_options(request, headers, runtime)

    async def group_add_async(
        self,
        request: dingtalkattendance__1__0_models.GroupAddRequest,
    ) -> dingtalkattendance__1__0_models.GroupAddResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.GroupAddHeaders()
        return await self.group_add_with_options_async(request, headers, runtime)

    def group_add_with_options(
        self,
        request: dingtalkattendance__1__0_models.GroupAddRequest,
        headers: dingtalkattendance__1__0_models.GroupAddHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.GroupAddResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.adjustment_setting_id):
            body['adjustmentSettingId'] = request.adjustment_setting_id
        if not UtilClient.is_unset(request.ble_device_list):
            body['bleDeviceList'] = request.ble_device_list
        if not UtilClient.is_unset(request.check_need_healthy_code):
            body['checkNeedHealthyCode'] = request.check_need_healthy_code
        if not UtilClient.is_unset(request.default_class_id):
            body['defaultClassId'] = request.default_class_id
        if not UtilClient.is_unset(request.disable_check_when_rest):
            body['disableCheckWhenRest'] = request.disable_check_when_rest
        if not UtilClient.is_unset(request.disable_check_without_schedule):
            body['disableCheckWithoutSchedule'] = request.disable_check_without_schedule
        if not UtilClient.is_unset(request.enable_camera_check):
            body['enableCameraCheck'] = request.enable_camera_check
        if not UtilClient.is_unset(request.enable_emp_select_class):
            body['enableEmpSelectClass'] = request.enable_emp_select_class
        if not UtilClient.is_unset(request.enable_face_check):
            body['enableFaceCheck'] = request.enable_face_check
        if not UtilClient.is_unset(request.enable_face_strict_mode):
            body['enableFaceStrictMode'] = request.enable_face_strict_mode
        if not UtilClient.is_unset(request.enable_next_day):
            body['enableNextDay'] = request.enable_next_day
        if not UtilClient.is_unset(request.enable_out_side_update_normal_check):
            body['enableOutSideUpdateNormalCheck'] = request.enable_out_side_update_normal_check
        if not UtilClient.is_unset(request.enable_outside_apply):
            body['enableOutsideApply'] = request.enable_outside_apply
        if not UtilClient.is_unset(request.enable_outside_camera_check):
            body['enableOutsideCameraCheck'] = request.enable_outside_camera_check
        if not UtilClient.is_unset(request.enable_outside_check):
            body['enableOutsideCheck'] = request.enable_outside_check
        if not UtilClient.is_unset(request.enable_outside_remark):
            body['enableOutsideRemark'] = request.enable_outside_remark
        if not UtilClient.is_unset(request.enable_position_ble):
            body['enablePositionBle'] = request.enable_position_ble
        if not UtilClient.is_unset(request.enable_trim_distance):
            body['enableTrimDistance'] = request.enable_trim_distance
        if not UtilClient.is_unset(request.forbid_hide_out_side_address):
            body['forbidHideOutSideAddress'] = request.forbid_hide_out_side_address
        if not UtilClient.is_unset(request.free_check_setting):
            body['freeCheckSetting'] = request.free_check_setting
        if not UtilClient.is_unset(request.free_check_type_id):
            body['freeCheckTypeId'] = request.free_check_type_id
        if not UtilClient.is_unset(request.freecheck_day_start_min_offset):
            body['freecheckDayStartMinOffset'] = request.freecheck_day_start_min_offset
        if not UtilClient.is_unset(request.freecheck_work_days):
            body['freecheckWorkDays'] = request.freecheck_work_days
        if not UtilClient.is_unset(request.group_id):
            body['groupId'] = request.group_id
        if not UtilClient.is_unset(request.group_name):
            body['groupName'] = request.group_name
        if not UtilClient.is_unset(request.manager_list):
            body['managerList'] = request.manager_list
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        if not UtilClient.is_unset(request.modify_member):
            body['modifyMember'] = request.modify_member
        if not UtilClient.is_unset(request.offset):
            body['offset'] = request.offset
        if not UtilClient.is_unset(request.open_face_check):
            body['openFaceCheck'] = request.open_face_check
        if not UtilClient.is_unset(request.outside_check_approve_mode_id):
            body['outsideCheckApproveModeId'] = request.outside_check_approve_mode_id
        if not UtilClient.is_unset(request.overtime_setting_id):
            body['overtimeSettingId'] = request.overtime_setting_id
        if not UtilClient.is_unset(request.owner):
            body['owner'] = request.owner
        if not UtilClient.is_unset(request.positions):
            body['positions'] = request.positions
        if not UtilClient.is_unset(request.resource_permission_map):
            body['resourcePermissionMap'] = request.resource_permission_map
        if not UtilClient.is_unset(request.shift_volist):
            body['shiftVOList'] = request.shift_volist
        if not UtilClient.is_unset(request.skip_holidays):
            body['skipHolidays'] = request.skip_holidays
        if not UtilClient.is_unset(request.special_days):
            body['specialDays'] = request.special_days
        if not UtilClient.is_unset(request.trim_distance):
            body['trimDistance'] = request.trim_distance
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
        if not UtilClient.is_unset(request.wifis):
            body['wifis'] = request.wifis
        if not UtilClient.is_unset(request.workday_class_list):
            body['workdayClassList'] = request.workday_class_list
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
            dingtalkattendance__1__0_models.GroupAddResponse(),
            self.do_roarequest('GroupAdd', 'attendance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/attendance/groups', 'json', req, runtime)
        )

    async def group_add_with_options_async(
        self,
        request: dingtalkattendance__1__0_models.GroupAddRequest,
        headers: dingtalkattendance__1__0_models.GroupAddHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.GroupAddResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.adjustment_setting_id):
            body['adjustmentSettingId'] = request.adjustment_setting_id
        if not UtilClient.is_unset(request.ble_device_list):
            body['bleDeviceList'] = request.ble_device_list
        if not UtilClient.is_unset(request.check_need_healthy_code):
            body['checkNeedHealthyCode'] = request.check_need_healthy_code
        if not UtilClient.is_unset(request.default_class_id):
            body['defaultClassId'] = request.default_class_id
        if not UtilClient.is_unset(request.disable_check_when_rest):
            body['disableCheckWhenRest'] = request.disable_check_when_rest
        if not UtilClient.is_unset(request.disable_check_without_schedule):
            body['disableCheckWithoutSchedule'] = request.disable_check_without_schedule
        if not UtilClient.is_unset(request.enable_camera_check):
            body['enableCameraCheck'] = request.enable_camera_check
        if not UtilClient.is_unset(request.enable_emp_select_class):
            body['enableEmpSelectClass'] = request.enable_emp_select_class
        if not UtilClient.is_unset(request.enable_face_check):
            body['enableFaceCheck'] = request.enable_face_check
        if not UtilClient.is_unset(request.enable_face_strict_mode):
            body['enableFaceStrictMode'] = request.enable_face_strict_mode
        if not UtilClient.is_unset(request.enable_next_day):
            body['enableNextDay'] = request.enable_next_day
        if not UtilClient.is_unset(request.enable_out_side_update_normal_check):
            body['enableOutSideUpdateNormalCheck'] = request.enable_out_side_update_normal_check
        if not UtilClient.is_unset(request.enable_outside_apply):
            body['enableOutsideApply'] = request.enable_outside_apply
        if not UtilClient.is_unset(request.enable_outside_camera_check):
            body['enableOutsideCameraCheck'] = request.enable_outside_camera_check
        if not UtilClient.is_unset(request.enable_outside_check):
            body['enableOutsideCheck'] = request.enable_outside_check
        if not UtilClient.is_unset(request.enable_outside_remark):
            body['enableOutsideRemark'] = request.enable_outside_remark
        if not UtilClient.is_unset(request.enable_position_ble):
            body['enablePositionBle'] = request.enable_position_ble
        if not UtilClient.is_unset(request.enable_trim_distance):
            body['enableTrimDistance'] = request.enable_trim_distance
        if not UtilClient.is_unset(request.forbid_hide_out_side_address):
            body['forbidHideOutSideAddress'] = request.forbid_hide_out_side_address
        if not UtilClient.is_unset(request.free_check_setting):
            body['freeCheckSetting'] = request.free_check_setting
        if not UtilClient.is_unset(request.free_check_type_id):
            body['freeCheckTypeId'] = request.free_check_type_id
        if not UtilClient.is_unset(request.freecheck_day_start_min_offset):
            body['freecheckDayStartMinOffset'] = request.freecheck_day_start_min_offset
        if not UtilClient.is_unset(request.freecheck_work_days):
            body['freecheckWorkDays'] = request.freecheck_work_days
        if not UtilClient.is_unset(request.group_id):
            body['groupId'] = request.group_id
        if not UtilClient.is_unset(request.group_name):
            body['groupName'] = request.group_name
        if not UtilClient.is_unset(request.manager_list):
            body['managerList'] = request.manager_list
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        if not UtilClient.is_unset(request.modify_member):
            body['modifyMember'] = request.modify_member
        if not UtilClient.is_unset(request.offset):
            body['offset'] = request.offset
        if not UtilClient.is_unset(request.open_face_check):
            body['openFaceCheck'] = request.open_face_check
        if not UtilClient.is_unset(request.outside_check_approve_mode_id):
            body['outsideCheckApproveModeId'] = request.outside_check_approve_mode_id
        if not UtilClient.is_unset(request.overtime_setting_id):
            body['overtimeSettingId'] = request.overtime_setting_id
        if not UtilClient.is_unset(request.owner):
            body['owner'] = request.owner
        if not UtilClient.is_unset(request.positions):
            body['positions'] = request.positions
        if not UtilClient.is_unset(request.resource_permission_map):
            body['resourcePermissionMap'] = request.resource_permission_map
        if not UtilClient.is_unset(request.shift_volist):
            body['shiftVOList'] = request.shift_volist
        if not UtilClient.is_unset(request.skip_holidays):
            body['skipHolidays'] = request.skip_holidays
        if not UtilClient.is_unset(request.special_days):
            body['specialDays'] = request.special_days
        if not UtilClient.is_unset(request.trim_distance):
            body['trimDistance'] = request.trim_distance
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
        if not UtilClient.is_unset(request.wifis):
            body['wifis'] = request.wifis
        if not UtilClient.is_unset(request.workday_class_list):
            body['workdayClassList'] = request.workday_class_list
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
            dingtalkattendance__1__0_models.GroupAddResponse(),
            await self.do_roarequest_async('GroupAdd', 'attendance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/attendance/groups', 'json', req, runtime)
        )

    def group_update(
        self,
        request: dingtalkattendance__1__0_models.GroupUpdateRequest,
    ) -> dingtalkattendance__1__0_models.GroupUpdateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.GroupUpdateHeaders()
        return self.group_update_with_options(request, headers, runtime)

    async def group_update_async(
        self,
        request: dingtalkattendance__1__0_models.GroupUpdateRequest,
    ) -> dingtalkattendance__1__0_models.GroupUpdateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.GroupUpdateHeaders()
        return await self.group_update_with_options_async(request, headers, runtime)

    def group_update_with_options(
        self,
        request: dingtalkattendance__1__0_models.GroupUpdateRequest,
        headers: dingtalkattendance__1__0_models.GroupUpdateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.GroupUpdateResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.adjustment_setting_id):
            body['adjustmentSettingId'] = request.adjustment_setting_id
        if not UtilClient.is_unset(request.disable_check_when_rest):
            body['disableCheckWhenRest'] = request.disable_check_when_rest
        if not UtilClient.is_unset(request.disable_check_without_schedule):
            body['disableCheckWithoutSchedule'] = request.disable_check_without_schedule
        if not UtilClient.is_unset(request.enable_camera_check):
            body['enableCameraCheck'] = request.enable_camera_check
        if not UtilClient.is_unset(request.enable_emp_select_class):
            body['enableEmpSelectClass'] = request.enable_emp_select_class
        if not UtilClient.is_unset(request.enable_face_check):
            body['enableFaceCheck'] = request.enable_face_check
        if not UtilClient.is_unset(request.enable_face_strict_mode):
            body['enableFaceStrictMode'] = request.enable_face_strict_mode
        if not UtilClient.is_unset(request.enable_out_side_update_normal_check):
            body['enableOutSideUpdateNormalCheck'] = request.enable_out_side_update_normal_check
        if not UtilClient.is_unset(request.enable_outside_apply):
            body['enableOutsideApply'] = request.enable_outside_apply
        if not UtilClient.is_unset(request.enable_outside_check):
            body['enableOutsideCheck'] = request.enable_outside_check
        if not UtilClient.is_unset(request.enable_outside_remark):
            body['enableOutsideRemark'] = request.enable_outside_remark
        if not UtilClient.is_unset(request.enable_trim_distance):
            body['enableTrimDistance'] = request.enable_trim_distance
        if not UtilClient.is_unset(request.forbid_hide_out_side_address):
            body['forbidHideOutSideAddress'] = request.forbid_hide_out_side_address
        if not UtilClient.is_unset(request.free_check_setting):
            body['freeCheckSetting'] = request.free_check_setting
        if not UtilClient.is_unset(request.free_check_type_id):
            body['freeCheckTypeId'] = request.free_check_type_id
        if not UtilClient.is_unset(request.group_id):
            body['groupId'] = request.group_id
        if not UtilClient.is_unset(request.group_name):
            body['groupName'] = request.group_name
        if not UtilClient.is_unset(request.manager_list):
            body['managerList'] = request.manager_list
        if not UtilClient.is_unset(request.offset):
            body['offset'] = request.offset
        if not UtilClient.is_unset(request.open_face_check):
            body['openFaceCheck'] = request.open_face_check
        if not UtilClient.is_unset(request.outside_check_approve_mode_id):
            body['outsideCheckApproveModeId'] = request.outside_check_approve_mode_id
        if not UtilClient.is_unset(request.overtime_setting_id):
            body['overtimeSettingId'] = request.overtime_setting_id
        if not UtilClient.is_unset(request.owner):
            body['owner'] = request.owner
        if not UtilClient.is_unset(request.positions):
            body['positions'] = request.positions
        if not UtilClient.is_unset(request.resource_permission_map):
            body['resourcePermissionMap'] = request.resource_permission_map
        if not UtilClient.is_unset(request.shift_volist):
            body['shiftVOList'] = request.shift_volist
        if not UtilClient.is_unset(request.skip_holidays):
            body['skipHolidays'] = request.skip_holidays
        if not UtilClient.is_unset(request.trim_distance):
            body['trimDistance'] = request.trim_distance
        if not UtilClient.is_unset(request.workday_class_list):
            body['workdayClassList'] = request.workday_class_list
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
            dingtalkattendance__1__0_models.GroupUpdateResponse(),
            self.do_roarequest('GroupUpdate', 'attendance_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/attendance/groups', 'json', req, runtime)
        )

    async def group_update_with_options_async(
        self,
        request: dingtalkattendance__1__0_models.GroupUpdateRequest,
        headers: dingtalkattendance__1__0_models.GroupUpdateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.GroupUpdateResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.adjustment_setting_id):
            body['adjustmentSettingId'] = request.adjustment_setting_id
        if not UtilClient.is_unset(request.disable_check_when_rest):
            body['disableCheckWhenRest'] = request.disable_check_when_rest
        if not UtilClient.is_unset(request.disable_check_without_schedule):
            body['disableCheckWithoutSchedule'] = request.disable_check_without_schedule
        if not UtilClient.is_unset(request.enable_camera_check):
            body['enableCameraCheck'] = request.enable_camera_check
        if not UtilClient.is_unset(request.enable_emp_select_class):
            body['enableEmpSelectClass'] = request.enable_emp_select_class
        if not UtilClient.is_unset(request.enable_face_check):
            body['enableFaceCheck'] = request.enable_face_check
        if not UtilClient.is_unset(request.enable_face_strict_mode):
            body['enableFaceStrictMode'] = request.enable_face_strict_mode
        if not UtilClient.is_unset(request.enable_out_side_update_normal_check):
            body['enableOutSideUpdateNormalCheck'] = request.enable_out_side_update_normal_check
        if not UtilClient.is_unset(request.enable_outside_apply):
            body['enableOutsideApply'] = request.enable_outside_apply
        if not UtilClient.is_unset(request.enable_outside_check):
            body['enableOutsideCheck'] = request.enable_outside_check
        if not UtilClient.is_unset(request.enable_outside_remark):
            body['enableOutsideRemark'] = request.enable_outside_remark
        if not UtilClient.is_unset(request.enable_trim_distance):
            body['enableTrimDistance'] = request.enable_trim_distance
        if not UtilClient.is_unset(request.forbid_hide_out_side_address):
            body['forbidHideOutSideAddress'] = request.forbid_hide_out_side_address
        if not UtilClient.is_unset(request.free_check_setting):
            body['freeCheckSetting'] = request.free_check_setting
        if not UtilClient.is_unset(request.free_check_type_id):
            body['freeCheckTypeId'] = request.free_check_type_id
        if not UtilClient.is_unset(request.group_id):
            body['groupId'] = request.group_id
        if not UtilClient.is_unset(request.group_name):
            body['groupName'] = request.group_name
        if not UtilClient.is_unset(request.manager_list):
            body['managerList'] = request.manager_list
        if not UtilClient.is_unset(request.offset):
            body['offset'] = request.offset
        if not UtilClient.is_unset(request.open_face_check):
            body['openFaceCheck'] = request.open_face_check
        if not UtilClient.is_unset(request.outside_check_approve_mode_id):
            body['outsideCheckApproveModeId'] = request.outside_check_approve_mode_id
        if not UtilClient.is_unset(request.overtime_setting_id):
            body['overtimeSettingId'] = request.overtime_setting_id
        if not UtilClient.is_unset(request.owner):
            body['owner'] = request.owner
        if not UtilClient.is_unset(request.positions):
            body['positions'] = request.positions
        if not UtilClient.is_unset(request.resource_permission_map):
            body['resourcePermissionMap'] = request.resource_permission_map
        if not UtilClient.is_unset(request.shift_volist):
            body['shiftVOList'] = request.shift_volist
        if not UtilClient.is_unset(request.skip_holidays):
            body['skipHolidays'] = request.skip_holidays
        if not UtilClient.is_unset(request.trim_distance):
            body['trimDistance'] = request.trim_distance
        if not UtilClient.is_unset(request.workday_class_list):
            body['workdayClassList'] = request.workday_class_list
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
            dingtalkattendance__1__0_models.GroupUpdateResponse(),
            await self.do_roarequest_async('GroupUpdate', 'attendance_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/attendance/groups', 'json', req, runtime)
        )

    def init_and_get_leave_allocation_quotas(
        self,
        request: dingtalkattendance__1__0_models.InitAndGetLeaveALlocationQuotasRequest,
    ) -> dingtalkattendance__1__0_models.InitAndGetLeaveALlocationQuotasResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.InitAndGetLeaveALlocationQuotasHeaders()
        return self.init_and_get_leave_allocation_quotas_with_options(request, headers, runtime)

    async def init_and_get_leave_allocation_quotas_async(
        self,
        request: dingtalkattendance__1__0_models.InitAndGetLeaveALlocationQuotasRequest,
    ) -> dingtalkattendance__1__0_models.InitAndGetLeaveALlocationQuotasResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.InitAndGetLeaveALlocationQuotasHeaders()
        return await self.init_and_get_leave_allocation_quotas_with_options_async(request, headers, runtime)

    def init_and_get_leave_allocation_quotas_with_options(
        self,
        request: dingtalkattendance__1__0_models.InitAndGetLeaveALlocationQuotasRequest,
        headers: dingtalkattendance__1__0_models.InitAndGetLeaveALlocationQuotasHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.InitAndGetLeaveALlocationQuotasResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.leave_code):
            query['leaveCode'] = request.leave_code
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
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
            dingtalkattendance__1__0_models.InitAndGetLeaveALlocationQuotasResponse(),
            self.do_roarequest('InitAndGetLeaveALlocationQuotas', 'attendance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/attendance/leaves/initializations/balances', 'json', req, runtime)
        )

    async def init_and_get_leave_allocation_quotas_with_options_async(
        self,
        request: dingtalkattendance__1__0_models.InitAndGetLeaveALlocationQuotasRequest,
        headers: dingtalkattendance__1__0_models.InitAndGetLeaveALlocationQuotasHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.InitAndGetLeaveALlocationQuotasResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.leave_code):
            query['leaveCode'] = request.leave_code
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
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
            dingtalkattendance__1__0_models.InitAndGetLeaveALlocationQuotasResponse(),
            await self.do_roarequest_async('InitAndGetLeaveALlocationQuotas', 'attendance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/attendance/leaves/initializations/balances', 'json', req, runtime)
        )

    def modify_water_mark_template(
        self,
        request: dingtalkattendance__1__0_models.ModifyWaterMarkTemplateRequest,
    ) -> dingtalkattendance__1__0_models.ModifyWaterMarkTemplateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.ModifyWaterMarkTemplateHeaders()
        return self.modify_water_mark_template_with_options(request, headers, runtime)

    async def modify_water_mark_template_async(
        self,
        request: dingtalkattendance__1__0_models.ModifyWaterMarkTemplateRequest,
    ) -> dingtalkattendance__1__0_models.ModifyWaterMarkTemplateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.ModifyWaterMarkTemplateHeaders()
        return await self.modify_water_mark_template_with_options_async(request, headers, runtime)

    def modify_water_mark_template_with_options(
        self,
        request: dingtalkattendance__1__0_models.ModifyWaterMarkTemplateRequest,
        headers: dingtalkattendance__1__0_models.ModifyWaterMarkTemplateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.ModifyWaterMarkTemplateResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            query['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        body = {}
        if not UtilClient.is_unset(request.form_code):
            body['formCode'] = request.form_code
        if not UtilClient.is_unset(request.icon):
            body['icon'] = request.icon
        if not UtilClient.is_unset(request.layout_design_id):
            body['layoutDesignId'] = request.layout_design_id
        if not UtilClient.is_unset(request.schema_content):
            body['schemaContent'] = request.schema_content
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        if not UtilClient.is_unset(request.water_mark_id):
            body['waterMarkId'] = request.water_mark_id
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
            dingtalkattendance__1__0_models.ModifyWaterMarkTemplateResponse(),
            self.do_roarequest('ModifyWaterMarkTemplate', 'attendance_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/attendance/watermarks/templates', 'json', req, runtime)
        )

    async def modify_water_mark_template_with_options_async(
        self,
        request: dingtalkattendance__1__0_models.ModifyWaterMarkTemplateRequest,
        headers: dingtalkattendance__1__0_models.ModifyWaterMarkTemplateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.ModifyWaterMarkTemplateResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            query['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        body = {}
        if not UtilClient.is_unset(request.form_code):
            body['formCode'] = request.form_code
        if not UtilClient.is_unset(request.icon):
            body['icon'] = request.icon
        if not UtilClient.is_unset(request.layout_design_id):
            body['layoutDesignId'] = request.layout_design_id
        if not UtilClient.is_unset(request.schema_content):
            body['schemaContent'] = request.schema_content
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        if not UtilClient.is_unset(request.water_mark_id):
            body['waterMarkId'] = request.water_mark_id
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
            dingtalkattendance__1__0_models.ModifyWaterMarkTemplateResponse(),
            await self.do_roarequest_async('ModifyWaterMarkTemplate', 'attendance_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/attendance/watermarks/templates', 'json', req, runtime)
        )

    def process_approve_create(
        self,
        request: dingtalkattendance__1__0_models.ProcessApproveCreateRequest,
    ) -> dingtalkattendance__1__0_models.ProcessApproveCreateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.ProcessApproveCreateHeaders()
        return self.process_approve_create_with_options(request, headers, runtime)

    async def process_approve_create_async(
        self,
        request: dingtalkattendance__1__0_models.ProcessApproveCreateRequest,
    ) -> dingtalkattendance__1__0_models.ProcessApproveCreateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.ProcessApproveCreateHeaders()
        return await self.process_approve_create_with_options_async(request, headers, runtime)

    def process_approve_create_with_options(
        self,
        request: dingtalkattendance__1__0_models.ProcessApproveCreateRequest,
        headers: dingtalkattendance__1__0_models.ProcessApproveCreateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.ProcessApproveCreateResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.approve_id):
            body['approveId'] = request.approve_id
        if not UtilClient.is_unset(request.op_user_id):
            body['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.punch_param):
            body['punchParam'] = request.punch_param
        if not UtilClient.is_unset(request.sub_type):
            body['subType'] = request.sub_type
        if not UtilClient.is_unset(request.tag_name):
            body['tagName'] = request.tag_name
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
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.ProcessApproveCreateResponse(),
            self.do_roarequest('ProcessApproveCreate', 'attendance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/attendance/workflows/checkInForms', 'json', req, runtime)
        )

    async def process_approve_create_with_options_async(
        self,
        request: dingtalkattendance__1__0_models.ProcessApproveCreateRequest,
        headers: dingtalkattendance__1__0_models.ProcessApproveCreateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.ProcessApproveCreateResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.approve_id):
            body['approveId'] = request.approve_id
        if not UtilClient.is_unset(request.op_user_id):
            body['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.punch_param):
            body['punchParam'] = request.punch_param
        if not UtilClient.is_unset(request.sub_type):
            body['subType'] = request.sub_type
        if not UtilClient.is_unset(request.tag_name):
            body['tagName'] = request.tag_name
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
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.ProcessApproveCreateResponse(),
            await self.do_roarequest_async('ProcessApproveCreate', 'attendance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/attendance/workflows/checkInForms', 'json', req, runtime)
        )

    def save_custom_water_mark_template(
        self,
        request: dingtalkattendance__1__0_models.SaveCustomWaterMarkTemplateRequest,
    ) -> dingtalkattendance__1__0_models.SaveCustomWaterMarkTemplateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.SaveCustomWaterMarkTemplateHeaders()
        return self.save_custom_water_mark_template_with_options(request, headers, runtime)

    async def save_custom_water_mark_template_async(
        self,
        request: dingtalkattendance__1__0_models.SaveCustomWaterMarkTemplateRequest,
    ) -> dingtalkattendance__1__0_models.SaveCustomWaterMarkTemplateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.SaveCustomWaterMarkTemplateHeaders()
        return await self.save_custom_water_mark_template_with_options_async(request, headers, runtime)

    def save_custom_water_mark_template_with_options(
        self,
        request: dingtalkattendance__1__0_models.SaveCustomWaterMarkTemplateRequest,
        headers: dingtalkattendance__1__0_models.SaveCustomWaterMarkTemplateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.SaveCustomWaterMarkTemplateResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            query['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        body = {}
        if not UtilClient.is_unset(request.biz_code):
            body['bizCode'] = request.biz_code
        if not UtilClient.is_unset(request.icon):
            body['icon'] = request.icon
        if not UtilClient.is_unset(request.layout_design_id):
            body['layoutDesignId'] = request.layout_design_id
        if not UtilClient.is_unset(request.scene_code):
            body['sceneCode'] = request.scene_code
        if not UtilClient.is_unset(request.schema_content):
            body['schemaContent'] = request.schema_content
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
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
            dingtalkattendance__1__0_models.SaveCustomWaterMarkTemplateResponse(),
            self.do_roarequest('SaveCustomWaterMarkTemplate', 'attendance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/attendance/watermarks/templates', 'json', req, runtime)
        )

    async def save_custom_water_mark_template_with_options_async(
        self,
        request: dingtalkattendance__1__0_models.SaveCustomWaterMarkTemplateRequest,
        headers: dingtalkattendance__1__0_models.SaveCustomWaterMarkTemplateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.SaveCustomWaterMarkTemplateResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            query['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        body = {}
        if not UtilClient.is_unset(request.biz_code):
            body['bizCode'] = request.biz_code
        if not UtilClient.is_unset(request.icon):
            body['icon'] = request.icon
        if not UtilClient.is_unset(request.layout_design_id):
            body['layoutDesignId'] = request.layout_design_id
        if not UtilClient.is_unset(request.scene_code):
            body['sceneCode'] = request.scene_code
        if not UtilClient.is_unset(request.schema_content):
            body['schemaContent'] = request.schema_content
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
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
            dingtalkattendance__1__0_models.SaveCustomWaterMarkTemplateResponse(),
            await self.do_roarequest_async('SaveCustomWaterMarkTemplate', 'attendance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/attendance/watermarks/templates', 'json', req, runtime)
        )

    def sync_schedule_info(
        self,
        request: dingtalkattendance__1__0_models.SyncScheduleInfoRequest,
    ) -> dingtalkattendance__1__0_models.SyncScheduleInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.SyncScheduleInfoHeaders()
        return self.sync_schedule_info_with_options(request, headers, runtime)

    async def sync_schedule_info_async(
        self,
        request: dingtalkattendance__1__0_models.SyncScheduleInfoRequest,
    ) -> dingtalkattendance__1__0_models.SyncScheduleInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.SyncScheduleInfoHeaders()
        return await self.sync_schedule_info_with_options_async(request, headers, runtime)

    def sync_schedule_info_with_options(
        self,
        request: dingtalkattendance__1__0_models.SyncScheduleInfoRequest,
        headers: dingtalkattendance__1__0_models.SyncScheduleInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.SyncScheduleInfoResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.op_user_id):
            body['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.schedule_infos):
            body['scheduleInfos'] = request.schedule_infos
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
            dingtalkattendance__1__0_models.SyncScheduleInfoResponse(),
            self.do_roarequest('SyncScheduleInfo', 'attendance_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/attendance/schedules/additionalInfo', 'none', req, runtime)
        )

    async def sync_schedule_info_with_options_async(
        self,
        request: dingtalkattendance__1__0_models.SyncScheduleInfoRequest,
        headers: dingtalkattendance__1__0_models.SyncScheduleInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.SyncScheduleInfoResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.op_user_id):
            body['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.schedule_infos):
            body['scheduleInfos'] = request.schedule_infos
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
            dingtalkattendance__1__0_models.SyncScheduleInfoResponse(),
            await self.do_roarequest_async('SyncScheduleInfo', 'attendance_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/attendance/schedules/additionalInfo', 'none', req, runtime)
        )

    def update_leave_type(
        self,
        request: dingtalkattendance__1__0_models.UpdateLeaveTypeRequest,
    ) -> dingtalkattendance__1__0_models.UpdateLeaveTypeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.UpdateLeaveTypeHeaders()
        return self.update_leave_type_with_options(request, headers, runtime)

    async def update_leave_type_async(
        self,
        request: dingtalkattendance__1__0_models.UpdateLeaveTypeRequest,
    ) -> dingtalkattendance__1__0_models.UpdateLeaveTypeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.UpdateLeaveTypeHeaders()
        return await self.update_leave_type_with_options_async(request, headers, runtime)

    def update_leave_type_with_options(
        self,
        request: dingtalkattendance__1__0_models.UpdateLeaveTypeRequest,
        headers: dingtalkattendance__1__0_models.UpdateLeaveTypeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.UpdateLeaveTypeResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.biz_type):
            body['bizType'] = request.biz_type
        if not UtilClient.is_unset(request.extras):
            body['extras'] = request.extras
        if not UtilClient.is_unset(request.hours_in_per_day):
            body['hoursInPerDay'] = request.hours_in_per_day
        if not UtilClient.is_unset(request.leave_certificate):
            body['leaveCertificate'] = request.leave_certificate
        if not UtilClient.is_unset(request.leave_code):
            body['leaveCode'] = request.leave_code
        if not UtilClient.is_unset(request.leave_name):
            body['leaveName'] = request.leave_name
        if not UtilClient.is_unset(request.leave_view_unit):
            body['leaveViewUnit'] = request.leave_view_unit
        if not UtilClient.is_unset(request.natural_day_leave):
            body['naturalDayLeave'] = request.natural_day_leave
        if not UtilClient.is_unset(request.submit_time_rule):
            body['submitTimeRule'] = request.submit_time_rule
        if not UtilClient.is_unset(request.visibility_rules):
            body['visibilityRules'] = request.visibility_rules
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
            dingtalkattendance__1__0_models.UpdateLeaveTypeResponse(),
            self.do_roarequest('UpdateLeaveType', 'attendance_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/attendance/leaves/types', 'json', req, runtime)
        )

    async def update_leave_type_with_options_async(
        self,
        request: dingtalkattendance__1__0_models.UpdateLeaveTypeRequest,
        headers: dingtalkattendance__1__0_models.UpdateLeaveTypeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.UpdateLeaveTypeResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.biz_type):
            body['bizType'] = request.biz_type
        if not UtilClient.is_unset(request.extras):
            body['extras'] = request.extras
        if not UtilClient.is_unset(request.hours_in_per_day):
            body['hoursInPerDay'] = request.hours_in_per_day
        if not UtilClient.is_unset(request.leave_certificate):
            body['leaveCertificate'] = request.leave_certificate
        if not UtilClient.is_unset(request.leave_code):
            body['leaveCode'] = request.leave_code
        if not UtilClient.is_unset(request.leave_name):
            body['leaveName'] = request.leave_name
        if not UtilClient.is_unset(request.leave_view_unit):
            body['leaveViewUnit'] = request.leave_view_unit
        if not UtilClient.is_unset(request.natural_day_leave):
            body['naturalDayLeave'] = request.natural_day_leave
        if not UtilClient.is_unset(request.submit_time_rule):
            body['submitTimeRule'] = request.submit_time_rule
        if not UtilClient.is_unset(request.visibility_rules):
            body['visibilityRules'] = request.visibility_rules
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
            dingtalkattendance__1__0_models.UpdateLeaveTypeResponse(),
            await self.do_roarequest_async('UpdateLeaveType', 'attendance_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/attendance/leaves/types', 'json', req, runtime)
        )
