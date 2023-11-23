# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_gateway_spi.client import Client as SPIClient
from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.attendance_1_0 import models as dingtalkattendance__1__0_models
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
        if not UtilClient.is_unset(request.freedom_leave):
            body['freedomLeave'] = request.freedom_leave
        if not UtilClient.is_unset(request.hours_in_per_day):
            body['hoursInPerDay'] = request.hours_in_per_day
        if not UtilClient.is_unset(request.leave_certificate):
            body['leaveCertificate'] = request.leave_certificate
        if not UtilClient.is_unset(request.leave_hour_ceil):
            body['leaveHourCeil'] = request.leave_hour_ceil
        if not UtilClient.is_unset(request.leave_name):
            body['leaveName'] = request.leave_name
        if not UtilClient.is_unset(request.leave_time_ceil):
            body['leaveTimeCeil'] = request.leave_time_ceil
        if not UtilClient.is_unset(request.leave_time_ceil_min_unit):
            body['leaveTimeCeilMinUnit'] = request.leave_time_ceil_min_unit
        if not UtilClient.is_unset(request.leave_view_unit):
            body['leaveViewUnit'] = request.leave_view_unit
        if not UtilClient.is_unset(request.max_leave_time):
            body['maxLeaveTime'] = request.max_leave_time
        if not UtilClient.is_unset(request.min_leave_hour):
            body['minLeaveHour'] = request.min_leave_hour
        if not UtilClient.is_unset(request.natural_day_leave):
            body['naturalDayLeave'] = request.natural_day_leave
        if not UtilClient.is_unset(request.paid_leave):
            body['paidLeave'] = request.paid_leave
        if not UtilClient.is_unset(request.submit_time_rule):
            body['submitTimeRule'] = request.submit_time_rule
        if not UtilClient.is_unset(request.visibility_rules):
            body['visibilityRules'] = request.visibility_rules
        if not UtilClient.is_unset(request.when_can_leave):
            body['whenCanLeave'] = request.when_can_leave
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
            action='AddLeaveType',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/leaves/types',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.AddLeaveTypeResponse(),
            self.execute(params, req, runtime)
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
        if not UtilClient.is_unset(request.freedom_leave):
            body['freedomLeave'] = request.freedom_leave
        if not UtilClient.is_unset(request.hours_in_per_day):
            body['hoursInPerDay'] = request.hours_in_per_day
        if not UtilClient.is_unset(request.leave_certificate):
            body['leaveCertificate'] = request.leave_certificate
        if not UtilClient.is_unset(request.leave_hour_ceil):
            body['leaveHourCeil'] = request.leave_hour_ceil
        if not UtilClient.is_unset(request.leave_name):
            body['leaveName'] = request.leave_name
        if not UtilClient.is_unset(request.leave_time_ceil):
            body['leaveTimeCeil'] = request.leave_time_ceil
        if not UtilClient.is_unset(request.leave_time_ceil_min_unit):
            body['leaveTimeCeilMinUnit'] = request.leave_time_ceil_min_unit
        if not UtilClient.is_unset(request.leave_view_unit):
            body['leaveViewUnit'] = request.leave_view_unit
        if not UtilClient.is_unset(request.max_leave_time):
            body['maxLeaveTime'] = request.max_leave_time
        if not UtilClient.is_unset(request.min_leave_hour):
            body['minLeaveHour'] = request.min_leave_hour
        if not UtilClient.is_unset(request.natural_day_leave):
            body['naturalDayLeave'] = request.natural_day_leave
        if not UtilClient.is_unset(request.paid_leave):
            body['paidLeave'] = request.paid_leave
        if not UtilClient.is_unset(request.submit_time_rule):
            body['submitTimeRule'] = request.submit_time_rule
        if not UtilClient.is_unset(request.visibility_rules):
            body['visibilityRules'] = request.visibility_rules
        if not UtilClient.is_unset(request.when_can_leave):
            body['whenCanLeave'] = request.when_can_leave
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
            action='AddLeaveType',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/leaves/types',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.AddLeaveTypeResponse(),
            await self.execute_async(params, req, runtime)
        )

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
        params = open_api_models.Params(
            action='AttendanceBleDevicesAdd',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/group/bledevices',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.AttendanceBleDevicesAddResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='AttendanceBleDevicesAdd',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/group/bledevices',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.AttendanceBleDevicesAddResponse(),
            await self.execute_async(params, req, runtime)
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
        params = open_api_models.Params(
            action='AttendanceBleDevicesQuery',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/group/bledevices/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.AttendanceBleDevicesQueryResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='AttendanceBleDevicesQuery',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/group/bledevices/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.AttendanceBleDevicesQueryResponse(),
            await self.execute_async(params, req, runtime)
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
        params = open_api_models.Params(
            action='AttendanceBleDevicesRemove',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/group/bledevices/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.AttendanceBleDevicesRemoveResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='AttendanceBleDevicesRemove',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/group/bledevices/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.AttendanceBleDevicesRemoveResponse(),
            await self.execute_async(params, req, runtime)
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

    def batch_boss_check_with_options(
        self,
        request: dingtalkattendance__1__0_models.BatchBossCheckRequest,
        headers: dingtalkattendance__1__0_models.BatchBossCheckHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.BatchBossCheckResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.models):
            body['models'] = request.models
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
            action='BatchBossCheck',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/results/batch',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.BatchBossCheckResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_boss_check_with_options_async(
        self,
        request: dingtalkattendance__1__0_models.BatchBossCheckRequest,
        headers: dingtalkattendance__1__0_models.BatchBossCheckHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.BatchBossCheckResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.models):
            body['models'] = request.models
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
            action='BatchBossCheck',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/results/batch',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.BatchBossCheckResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch_boss_check(
        self,
        request: dingtalkattendance__1__0_models.BatchBossCheckRequest,
    ) -> dingtalkattendance__1__0_models.BatchBossCheckResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.BatchBossCheckHeaders()
        return self.batch_boss_check_with_options(request, headers, runtime)

    async def batch_boss_check_async(
        self,
        request: dingtalkattendance__1__0_models.BatchBossCheckRequest,
    ) -> dingtalkattendance__1__0_models.BatchBossCheckResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.BatchBossCheckHeaders()
        return await self.batch_boss_check_with_options_async(request, headers, runtime)

    def calculate_duration_with_options(
        self,
        request: dingtalkattendance__1__0_models.CalculateDurationRequest,
        headers: dingtalkattendance__1__0_models.CalculateDurationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.CalculateDurationResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        body = {}
        if not UtilClient.is_unset(request.biz_type):
            body['bizType'] = request.biz_type
        if not UtilClient.is_unset(request.calculate_model):
            body['calculateModel'] = request.calculate_model
        if not UtilClient.is_unset(request.duration_unit):
            body['durationUnit'] = request.duration_unit
        if not UtilClient.is_unset(request.from_time):
            body['fromTime'] = request.from_time
        if not UtilClient.is_unset(request.leave_code):
            body['leaveCode'] = request.leave_code
        if not UtilClient.is_unset(request.to_time):
            body['toTime'] = request.to_time
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
            action='CalculateDuration',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/approvals/durations/calculate',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.CalculateDurationResponse(),
            self.execute(params, req, runtime)
        )

    async def calculate_duration_with_options_async(
        self,
        request: dingtalkattendance__1__0_models.CalculateDurationRequest,
        headers: dingtalkattendance__1__0_models.CalculateDurationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.CalculateDurationResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        body = {}
        if not UtilClient.is_unset(request.biz_type):
            body['bizType'] = request.biz_type
        if not UtilClient.is_unset(request.calculate_model):
            body['calculateModel'] = request.calculate_model
        if not UtilClient.is_unset(request.duration_unit):
            body['durationUnit'] = request.duration_unit
        if not UtilClient.is_unset(request.from_time):
            body['fromTime'] = request.from_time
        if not UtilClient.is_unset(request.leave_code):
            body['leaveCode'] = request.leave_code
        if not UtilClient.is_unset(request.to_time):
            body['toTime'] = request.to_time
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
            action='CalculateDuration',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/approvals/durations/calculate',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.CalculateDurationResponse(),
            await self.execute_async(params, req, runtime)
        )

    def calculate_duration(
        self,
        request: dingtalkattendance__1__0_models.CalculateDurationRequest,
    ) -> dingtalkattendance__1__0_models.CalculateDurationResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.CalculateDurationHeaders()
        return self.calculate_duration_with_options(request, headers, runtime)

    async def calculate_duration_async(
        self,
        request: dingtalkattendance__1__0_models.CalculateDurationRequest,
    ) -> dingtalkattendance__1__0_models.CalculateDurationResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.CalculateDurationHeaders()
        return await self.calculate_duration_with_options_async(request, headers, runtime)

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
        params = open_api_models.Params(
            action='CheckClosingAccount',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/closingAccounts/status/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.CheckClosingAccountResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='CheckClosingAccount',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/closingAccounts/status/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.CheckClosingAccountResponse(),
            await self.execute_async(params, req, runtime)
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
        params = open_api_models.Params(
            action='CheckWritePermission',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/writePermissions/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.CheckWritePermissionResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='CheckWritePermission',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/writePermissions/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.CheckWritePermissionResponse(),
            await self.execute_async(params, req, runtime)
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
        params = open_api_models.Params(
            action='CreateApprove',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/approves',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.CreateApproveResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='CreateApprove',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/approves',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.CreateApproveResponse(),
            await self.execute_async(params, req, runtime)
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
        params = open_api_models.Params(
            action='DeleteWaterMarkTemplate',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/watermarks/templates',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.DeleteWaterMarkTemplateResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='DeleteWaterMarkTemplate',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/watermarks/templates',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.DeleteWaterMarkTemplateResponse(),
            await self.execute_async(params, req, runtime)
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
        params = open_api_models.Params(
            action='DingTalkSecurityCheck',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/securities/check',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.DingTalkSecurityCheckResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='DingTalkSecurityCheck',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/securities/check',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.DingTalkSecurityCheckResponse(),
            await self.execute_async(params, req, runtime)
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
        params = open_api_models.Params(
            action='GetATManageScope',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/manageScopes',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.GetATManageScopeResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='GetATManageScope',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/manageScopes',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.GetATManageScopeResponse(),
            await self.execute_async(params, req, runtime)
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
        params = open_api_models.Params(
            action='GetAdjustments',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/adjustments',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.GetAdjustmentsResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='GetAdjustments',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/adjustments',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.GetAdjustmentsResponse(),
            await self.execute_async(params, req, runtime)
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
        params = open_api_models.Params(
            action='GetCheckInSchemaTemplate',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/watermarks/templates',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.GetCheckInSchemaTemplateResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='GetCheckInSchemaTemplate',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/watermarks/templates',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.GetCheckInSchemaTemplateResponse(),
            await self.execute_async(params, req, runtime)
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

    def get_checkin_record_by_user_with_options(
        self,
        request: dingtalkattendance__1__0_models.GetCheckinRecordByUserRequest,
        headers: dingtalkattendance__1__0_models.GetCheckinRecordByUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.GetCheckinRecordByUserResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.operator_user_id):
            body['operatorUserId'] = request.operator_user_id
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.user_id_list):
            body['userIdList'] = request.user_id_list
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
            action='GetCheckinRecordByUser',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/checkin/records/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.GetCheckinRecordByUserResponse(),
            self.execute(params, req, runtime)
        )

    async def get_checkin_record_by_user_with_options_async(
        self,
        request: dingtalkattendance__1__0_models.GetCheckinRecordByUserRequest,
        headers: dingtalkattendance__1__0_models.GetCheckinRecordByUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.GetCheckinRecordByUserResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.operator_user_id):
            body['operatorUserId'] = request.operator_user_id
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.user_id_list):
            body['userIdList'] = request.user_id_list
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
            action='GetCheckinRecordByUser',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/checkin/records/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.GetCheckinRecordByUserResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_checkin_record_by_user(
        self,
        request: dingtalkattendance__1__0_models.GetCheckinRecordByUserRequest,
    ) -> dingtalkattendance__1__0_models.GetCheckinRecordByUserResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.GetCheckinRecordByUserHeaders()
        return self.get_checkin_record_by_user_with_options(request, headers, runtime)

    async def get_checkin_record_by_user_async(
        self,
        request: dingtalkattendance__1__0_models.GetCheckinRecordByUserRequest,
    ) -> dingtalkattendance__1__0_models.GetCheckinRecordByUserResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.GetCheckinRecordByUserHeaders()
        return await self.get_checkin_record_by_user_with_options_async(request, headers, runtime)

    def get_class_with_deleted_with_options(
        self,
        class_id: str,
        headers: dingtalkattendance__1__0_models.GetClassWithDeletedHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.GetClassWithDeletedResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetClassWithDeleted',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/classWithDeleted/{class_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.GetClassWithDeletedResponse(),
            self.execute(params, req, runtime)
        )

    async def get_class_with_deleted_with_options_async(
        self,
        class_id: str,
        headers: dingtalkattendance__1__0_models.GetClassWithDeletedHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.GetClassWithDeletedResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetClassWithDeleted',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/classWithDeleted/{class_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.GetClassWithDeletedResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_class_with_deleted(
        self,
        class_id: str,
    ) -> dingtalkattendance__1__0_models.GetClassWithDeletedResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.GetClassWithDeletedHeaders()
        return self.get_class_with_deleted_with_options(class_id, headers, runtime)

    async def get_class_with_deleted_async(
        self,
        class_id: str,
    ) -> dingtalkattendance__1__0_models.GetClassWithDeletedResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.GetClassWithDeletedHeaders()
        return await self.get_class_with_deleted_with_options_async(class_id, headers, runtime)

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
        params = open_api_models.Params(
            action='GetClosingAccounts',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/closingAccounts/rules/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.GetClosingAccountsResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='GetClosingAccounts',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/closingAccounts/rules/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.GetClosingAccountsResponse(),
            await self.execute_async(params, req, runtime)
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

    def get_leave_records_with_options(
        self,
        request: dingtalkattendance__1__0_models.GetLeaveRecordsRequest,
        headers: dingtalkattendance__1__0_models.GetLeaveRecordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.GetLeaveRecordsResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.leave_code):
            body['leaveCode'] = request.leave_code
        if not UtilClient.is_unset(request.op_user_id):
            body['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
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
            action='GetLeaveRecords',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/vacations/records/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.GetLeaveRecordsResponse(),
            self.execute(params, req, runtime)
        )

    async def get_leave_records_with_options_async(
        self,
        request: dingtalkattendance__1__0_models.GetLeaveRecordsRequest,
        headers: dingtalkattendance__1__0_models.GetLeaveRecordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.GetLeaveRecordsResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.leave_code):
            body['leaveCode'] = request.leave_code
        if not UtilClient.is_unset(request.op_user_id):
            body['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
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
            action='GetLeaveRecords',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/vacations/records/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.GetLeaveRecordsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_leave_records(
        self,
        request: dingtalkattendance__1__0_models.GetLeaveRecordsRequest,
    ) -> dingtalkattendance__1__0_models.GetLeaveRecordsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.GetLeaveRecordsHeaders()
        return self.get_leave_records_with_options(request, headers, runtime)

    async def get_leave_records_async(
        self,
        request: dingtalkattendance__1__0_models.GetLeaveRecordsRequest,
    ) -> dingtalkattendance__1__0_models.GetLeaveRecordsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.GetLeaveRecordsHeaders()
        return await self.get_leave_records_with_options_async(request, headers, runtime)

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
        params = open_api_models.Params(
            action='GetLeaveType',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/leaves/types',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.GetLeaveTypeResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='GetLeaveType',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/leaves/types',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.GetLeaveTypeResponse(),
            await self.execute_async(params, req, runtime)
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

    def get_machine_with_options(
        self,
        dev_id: str,
        headers: dingtalkattendance__1__0_models.GetMachineHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.GetMachineResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetMachine',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/machines/{dev_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.GetMachineResponse(),
            self.execute(params, req, runtime)
        )

    async def get_machine_with_options_async(
        self,
        dev_id: str,
        headers: dingtalkattendance__1__0_models.GetMachineHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.GetMachineResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetMachine',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/machines/{dev_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.GetMachineResponse(),
            await self.execute_async(params, req, runtime)
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

    def get_machine_user_with_options(
        self,
        dev_id: str,
        request: dingtalkattendance__1__0_models.GetMachineUserRequest,
        headers: dingtalkattendance__1__0_models.GetMachineUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.GetMachineUserResponse:
        UtilClient.validate_model(request)
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
        params = open_api_models.Params(
            action='GetMachineUser',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/machines/getUser/{dev_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.GetMachineUserResponse(),
            self.execute(params, req, runtime)
        )

    async def get_machine_user_with_options_async(
        self,
        dev_id: str,
        request: dingtalkattendance__1__0_models.GetMachineUserRequest,
        headers: dingtalkattendance__1__0_models.GetMachineUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.GetMachineUserResponse:
        UtilClient.validate_model(request)
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
        params = open_api_models.Params(
            action='GetMachineUser',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/machines/getUser/{dev_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.GetMachineUserResponse(),
            await self.execute_async(params, req, runtime)
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
        params = open_api_models.Params(
            action='GetOvertimeSetting',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/overtimeSettings/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.GetOvertimeSettingResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='GetOvertimeSetting',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/overtimeSettings/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.GetOvertimeSettingResponse(),
            await self.execute_async(params, req, runtime)
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

    def get_shift_with_options(
        self,
        request: dingtalkattendance__1__0_models.GetShiftRequest,
        headers: dingtalkattendance__1__0_models.GetShiftHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.GetShiftResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.shift_id):
            query['shiftId'] = request.shift_id
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
            action='GetShift',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/shifts',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.GetShiftResponse(),
            self.execute(params, req, runtime)
        )

    async def get_shift_with_options_async(
        self,
        request: dingtalkattendance__1__0_models.GetShiftRequest,
        headers: dingtalkattendance__1__0_models.GetShiftHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.GetShiftResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.shift_id):
            query['shiftId'] = request.shift_id
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
            action='GetShift',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/shifts',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.GetShiftResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_shift(
        self,
        request: dingtalkattendance__1__0_models.GetShiftRequest,
    ) -> dingtalkattendance__1__0_models.GetShiftResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.GetShiftHeaders()
        return self.get_shift_with_options(request, headers, runtime)

    async def get_shift_async(
        self,
        request: dingtalkattendance__1__0_models.GetShiftRequest,
    ) -> dingtalkattendance__1__0_models.GetShiftResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.GetShiftHeaders()
        return await self.get_shift_with_options_async(request, headers, runtime)

    def get_simple_groups_with_options(
        self,
        request: dingtalkattendance__1__0_models.GetSimpleGroupsRequest,
        headers: dingtalkattendance__1__0_models.GetSimpleGroupsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.GetSimpleGroupsResponse:
        UtilClient.validate_model(request)
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
        params = open_api_models.Params(
            action='GetSimpleGroups',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/groupDetails',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.GetSimpleGroupsResponse(),
            self.execute(params, req, runtime)
        )

    async def get_simple_groups_with_options_async(
        self,
        request: dingtalkattendance__1__0_models.GetSimpleGroupsRequest,
        headers: dingtalkattendance__1__0_models.GetSimpleGroupsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.GetSimpleGroupsResponse:
        UtilClient.validate_model(request)
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
        params = open_api_models.Params(
            action='GetSimpleGroups',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/groupDetails',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.GetSimpleGroupsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_simple_groups(
        self,
        request: dingtalkattendance__1__0_models.GetSimpleGroupsRequest,
    ) -> dingtalkattendance__1__0_models.GetSimpleGroupsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.GetSimpleGroupsHeaders()
        return self.get_simple_groups_with_options(request, headers, runtime)

    async def get_simple_groups_async(
        self,
        request: dingtalkattendance__1__0_models.GetSimpleGroupsRequest,
    ) -> dingtalkattendance__1__0_models.GetSimpleGroupsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.GetSimpleGroupsHeaders()
        return await self.get_simple_groups_with_options_async(request, headers, runtime)

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
        params = open_api_models.Params(
            action='GetSimpleOvertimeSetting',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/overtimeSettings',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.GetSimpleOvertimeSettingResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='GetSimpleOvertimeSetting',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/overtimeSettings',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.GetSimpleOvertimeSettingResponse(),
            await self.execute_async(params, req, runtime)
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
        params = open_api_models.Params(
            action='GetUserHolidays',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/holidays',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.GetUserHolidaysResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='GetUserHolidays',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/holidays',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.GetUserHolidaysResponse(),
            await self.execute_async(params, req, runtime)
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
        if not UtilClient.is_unset(request.open_camera_check):
            body['openCameraCheck'] = request.open_camera_check
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
        params = open_api_models.Params(
            action='GroupAdd',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/groups',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.GroupAddResponse(),
            self.execute(params, req, runtime)
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
        if not UtilClient.is_unset(request.open_camera_check):
            body['openCameraCheck'] = request.open_camera_check
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
        params = open_api_models.Params(
            action='GroupAdd',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/groups',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.GroupAddResponse(),
            await self.execute_async(params, req, runtime)
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
        if not UtilClient.is_unset(request.open_camera_check):
            body['openCameraCheck'] = request.open_camera_check
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
        params = open_api_models.Params(
            action='GroupUpdate',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/groups',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.GroupUpdateResponse(),
            self.execute(params, req, runtime)
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
        if not UtilClient.is_unset(request.open_camera_check):
            body['openCameraCheck'] = request.open_camera_check
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
        params = open_api_models.Params(
            action='GroupUpdate',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/groups',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.GroupUpdateResponse(),
            await self.execute_async(params, req, runtime)
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
        params = open_api_models.Params(
            action='InitAndGetLeaveALlocationQuotas',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/leaves/initializations/balances',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.InitAndGetLeaveALlocationQuotasResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='InitAndGetLeaveALlocationQuotas',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/leaves/initializations/balances',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.InitAndGetLeaveALlocationQuotasResponse(),
            await self.execute_async(params, req, runtime)
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

    def list_approve_by_users_with_options(
        self,
        request: dingtalkattendance__1__0_models.ListApproveByUsersRequest,
        headers: dingtalkattendance__1__0_models.ListApproveByUsersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.ListApproveByUsersResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_types):
            body['bizTypes'] = request.biz_types
        if not UtilClient.is_unset(request.from_date_time):
            body['fromDateTime'] = request.from_date_time
        if not UtilClient.is_unset(request.to_date_time):
            body['toDateTime'] = request.to_date_time
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
            action='ListApproveByUsers',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/approvals/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.ListApproveByUsersResponse(),
            self.execute(params, req, runtime)
        )

    async def list_approve_by_users_with_options_async(
        self,
        request: dingtalkattendance__1__0_models.ListApproveByUsersRequest,
        headers: dingtalkattendance__1__0_models.ListApproveByUsersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.ListApproveByUsersResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_types):
            body['bizTypes'] = request.biz_types
        if not UtilClient.is_unset(request.from_date_time):
            body['fromDateTime'] = request.from_date_time
        if not UtilClient.is_unset(request.to_date_time):
            body['toDateTime'] = request.to_date_time
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
            action='ListApproveByUsers',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/approvals/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.ListApproveByUsersResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_approve_by_users(
        self,
        request: dingtalkattendance__1__0_models.ListApproveByUsersRequest,
    ) -> dingtalkattendance__1__0_models.ListApproveByUsersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.ListApproveByUsersHeaders()
        return self.list_approve_by_users_with_options(request, headers, runtime)

    async def list_approve_by_users_async(
        self,
        request: dingtalkattendance__1__0_models.ListApproveByUsersRequest,
    ) -> dingtalkattendance__1__0_models.ListApproveByUsersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.ListApproveByUsersHeaders()
        return await self.list_approve_by_users_with_options_async(request, headers, runtime)

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
        params = open_api_models.Params(
            action='ModifyWaterMarkTemplate',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/watermarks/templates',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.ModifyWaterMarkTemplateResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='ModifyWaterMarkTemplate',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/watermarks/templates',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.ModifyWaterMarkTemplateResponse(),
            await self.execute_async(params, req, runtime)
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
        params = open_api_models.Params(
            action='ProcessApproveCreate',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/workflows/checkInForms',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.ProcessApproveCreateResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='ProcessApproveCreate',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/workflows/checkInForms',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.ProcessApproveCreateResponse(),
            await self.execute_async(params, req, runtime)
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

    def process_approve_finish_with_options(
        self,
        request: dingtalkattendance__1__0_models.ProcessApproveFinishRequest,
        headers: dingtalkattendance__1__0_models.ProcessApproveFinishHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.ProcessApproveFinishResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        body = {}
        if not UtilClient.is_unset(request.approve_id):
            body['approveId'] = request.approve_id
        if not UtilClient.is_unset(request.jump_url):
            body['jumpUrl'] = request.jump_url
        if not UtilClient.is_unset(request.over_time_to_more):
            body['overTimeToMore'] = request.over_time_to_more
        if not UtilClient.is_unset(request.overtime_duration):
            body['overtimeDuration'] = request.overtime_duration
        if not UtilClient.is_unset(request.sub_type):
            body['subType'] = request.sub_type
        if not UtilClient.is_unset(request.tag_name):
            body['tagName'] = request.tag_name
        if not UtilClient.is_unset(request.top_calculate_approve_duration_param):
            body['topCalculateApproveDurationParam'] = request.top_calculate_approve_duration_param
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
            action='ProcessApproveFinish',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/approvals/finish',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.ProcessApproveFinishResponse(),
            self.execute(params, req, runtime)
        )

    async def process_approve_finish_with_options_async(
        self,
        request: dingtalkattendance__1__0_models.ProcessApproveFinishRequest,
        headers: dingtalkattendance__1__0_models.ProcessApproveFinishHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.ProcessApproveFinishResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        body = {}
        if not UtilClient.is_unset(request.approve_id):
            body['approveId'] = request.approve_id
        if not UtilClient.is_unset(request.jump_url):
            body['jumpUrl'] = request.jump_url
        if not UtilClient.is_unset(request.over_time_to_more):
            body['overTimeToMore'] = request.over_time_to_more
        if not UtilClient.is_unset(request.overtime_duration):
            body['overtimeDuration'] = request.overtime_duration
        if not UtilClient.is_unset(request.sub_type):
            body['subType'] = request.sub_type
        if not UtilClient.is_unset(request.tag_name):
            body['tagName'] = request.tag_name
        if not UtilClient.is_unset(request.top_calculate_approve_duration_param):
            body['topCalculateApproveDurationParam'] = request.top_calculate_approve_duration_param
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
            action='ProcessApproveFinish',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/approvals/finish',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.ProcessApproveFinishResponse(),
            await self.execute_async(params, req, runtime)
        )

    def process_approve_finish(
        self,
        request: dingtalkattendance__1__0_models.ProcessApproveFinishRequest,
    ) -> dingtalkattendance__1__0_models.ProcessApproveFinishResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.ProcessApproveFinishHeaders()
        return self.process_approve_finish_with_options(request, headers, runtime)

    async def process_approve_finish_async(
        self,
        request: dingtalkattendance__1__0_models.ProcessApproveFinishRequest,
    ) -> dingtalkattendance__1__0_models.ProcessApproveFinishResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.ProcessApproveFinishHeaders()
        return await self.process_approve_finish_with_options_async(request, headers, runtime)

    def reduce_quota_with_leave_record_with_options(
        self,
        union_id: str,
        request: dingtalkattendance__1__0_models.ReduceQuotaWithLeaveRecordRequest,
        headers: dingtalkattendance__1__0_models.ReduceQuotaWithLeaveRecordHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.ReduceQuotaWithLeaveRecordResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.leave_code):
            body['leaveCode'] = request.leave_code
        if not UtilClient.is_unset(request.outer_id):
            body['outerId'] = request.outer_id
        if not UtilClient.is_unset(request.quota_num):
            body['quotaNum'] = request.quota_num
        if not UtilClient.is_unset(request.reason):
            body['reason'] = request.reason
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
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
            action='ReduceQuotaWithLeaveRecord',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/users/{union_id}/vacations/records/modify',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.ReduceQuotaWithLeaveRecordResponse(),
            self.execute(params, req, runtime)
        )

    async def reduce_quota_with_leave_record_with_options_async(
        self,
        union_id: str,
        request: dingtalkattendance__1__0_models.ReduceQuotaWithLeaveRecordRequest,
        headers: dingtalkattendance__1__0_models.ReduceQuotaWithLeaveRecordHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.ReduceQuotaWithLeaveRecordResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.leave_code):
            body['leaveCode'] = request.leave_code
        if not UtilClient.is_unset(request.outer_id):
            body['outerId'] = request.outer_id
        if not UtilClient.is_unset(request.quota_num):
            body['quotaNum'] = request.quota_num
        if not UtilClient.is_unset(request.reason):
            body['reason'] = request.reason
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
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
            action='ReduceQuotaWithLeaveRecord',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/users/{union_id}/vacations/records/modify',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.ReduceQuotaWithLeaveRecordResponse(),
            await self.execute_async(params, req, runtime)
        )

    def reduce_quota_with_leave_record(
        self,
        union_id: str,
        request: dingtalkattendance__1__0_models.ReduceQuotaWithLeaveRecordRequest,
    ) -> dingtalkattendance__1__0_models.ReduceQuotaWithLeaveRecordResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.ReduceQuotaWithLeaveRecordHeaders()
        return self.reduce_quota_with_leave_record_with_options(union_id, request, headers, runtime)

    async def reduce_quota_with_leave_record_async(
        self,
        union_id: str,
        request: dingtalkattendance__1__0_models.ReduceQuotaWithLeaveRecordRequest,
    ) -> dingtalkattendance__1__0_models.ReduceQuotaWithLeaveRecordResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.ReduceQuotaWithLeaveRecordHeaders()
        return await self.reduce_quota_with_leave_record_with_options_async(union_id, request, headers, runtime)

    def retain_leave_types_with_options(
        self,
        request: dingtalkattendance__1__0_models.RetainLeaveTypesRequest,
        headers: dingtalkattendance__1__0_models.RetainLeaveTypesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.RetainLeaveTypesResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.leave_codes):
            body['leaveCodes'] = request.leave_codes
        if not UtilClient.is_unset(request.op_user_id):
            body['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.source):
            body['source'] = request.source
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
            action='RetainLeaveTypes',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/vacations/types/change',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.RetainLeaveTypesResponse(),
            self.execute(params, req, runtime)
        )

    async def retain_leave_types_with_options_async(
        self,
        request: dingtalkattendance__1__0_models.RetainLeaveTypesRequest,
        headers: dingtalkattendance__1__0_models.RetainLeaveTypesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.RetainLeaveTypesResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.leave_codes):
            body['leaveCodes'] = request.leave_codes
        if not UtilClient.is_unset(request.op_user_id):
            body['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.source):
            body['source'] = request.source
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
            action='RetainLeaveTypes',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/vacations/types/change',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.RetainLeaveTypesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def retain_leave_types(
        self,
        request: dingtalkattendance__1__0_models.RetainLeaveTypesRequest,
    ) -> dingtalkattendance__1__0_models.RetainLeaveTypesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.RetainLeaveTypesHeaders()
        return self.retain_leave_types_with_options(request, headers, runtime)

    async def retain_leave_types_async(
        self,
        request: dingtalkattendance__1__0_models.RetainLeaveTypesRequest,
    ) -> dingtalkattendance__1__0_models.RetainLeaveTypesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.RetainLeaveTypesHeaders()
        return await self.retain_leave_types_with_options_async(request, headers, runtime)

    def reverse_trial_advanced_leave_with_options(
        self,
        request: dingtalkattendance__1__0_models.ReverseTrialAdvancedLeaveRequest,
        headers: dingtalkattendance__1__0_models.ReverseTrialAdvancedLeaveHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.ReverseTrialAdvancedLeaveResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.serv_code):
            query['servCode'] = request.serv_code
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
            action='ReverseTrialAdvancedLeave',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/leaves/reverse',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.ReverseTrialAdvancedLeaveResponse(),
            self.execute(params, req, runtime)
        )

    async def reverse_trial_advanced_leave_with_options_async(
        self,
        request: dingtalkattendance__1__0_models.ReverseTrialAdvancedLeaveRequest,
        headers: dingtalkattendance__1__0_models.ReverseTrialAdvancedLeaveHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkattendance__1__0_models.ReverseTrialAdvancedLeaveResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.serv_code):
            query['servCode'] = request.serv_code
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
            action='ReverseTrialAdvancedLeave',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/leaves/reverse',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.ReverseTrialAdvancedLeaveResponse(),
            await self.execute_async(params, req, runtime)
        )

    def reverse_trial_advanced_leave(
        self,
        request: dingtalkattendance__1__0_models.ReverseTrialAdvancedLeaveRequest,
    ) -> dingtalkattendance__1__0_models.ReverseTrialAdvancedLeaveResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.ReverseTrialAdvancedLeaveHeaders()
        return self.reverse_trial_advanced_leave_with_options(request, headers, runtime)

    async def reverse_trial_advanced_leave_async(
        self,
        request: dingtalkattendance__1__0_models.ReverseTrialAdvancedLeaveRequest,
    ) -> dingtalkattendance__1__0_models.ReverseTrialAdvancedLeaveResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkattendance__1__0_models.ReverseTrialAdvancedLeaveHeaders()
        return await self.reverse_trial_advanced_leave_with_options_async(request, headers, runtime)

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
        params = open_api_models.Params(
            action='SaveCustomWaterMarkTemplate',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/watermarks/templates',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.SaveCustomWaterMarkTemplateResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='SaveCustomWaterMarkTemplate',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/watermarks/templates',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.SaveCustomWaterMarkTemplateResponse(),
            await self.execute_async(params, req, runtime)
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
        params = open_api_models.Params(
            action='SyncScheduleInfo',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/schedules/additionalInfo',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.SyncScheduleInfoResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='SyncScheduleInfo',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/schedules/additionalInfo',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.SyncScheduleInfoResponse(),
            await self.execute_async(params, req, runtime)
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
        params = open_api_models.Params(
            action='UpdateLeaveType',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/leaves/types',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.UpdateLeaveTypeResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='UpdateLeaveType',
            version='attendance_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/attendance/leaves/types',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkattendance__1__0_models.UpdateLeaveTypeResponse(),
            await self.execute_async(params, req, runtime)
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
