# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.datacenter_1_0 import models as dingtalkdatacenter__1__0_models
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

    def query_group_message_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryGroupMessageStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryGroupMessageStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryGroupMessageStatisticalDataHeaders()
        return self.query_group_message_statistical_data_with_options(request, headers, runtime)

    async def query_group_message_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryGroupMessageStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryGroupMessageStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryGroupMessageStatisticalDataHeaders()
        return await self.query_group_message_statistical_data_with_options_async(request, headers, runtime)

    def query_group_message_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryGroupMessageStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryGroupMessageStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryGroupMessageStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryGroupMessageStatisticalDataResponse(),
            self.do_roarequest('QueryGroupMessageStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/groupMessageData', 'json', req, runtime)
        )

    async def query_group_message_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryGroupMessageStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryGroupMessageStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryGroupMessageStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryGroupMessageStatisticalDataResponse(),
            await self.do_roarequest_async('QueryGroupMessageStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/groupMessageData', 'json', req, runtime)
        )

    def query_vedio_meeting_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryVedioMeetingStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryVedioMeetingStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryVedioMeetingStatisticalDataHeaders()
        return self.query_vedio_meeting_statistical_data_with_options(request, headers, runtime)

    async def query_vedio_meeting_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryVedioMeetingStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryVedioMeetingStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryVedioMeetingStatisticalDataHeaders()
        return await self.query_vedio_meeting_statistical_data_with_options_async(request, headers, runtime)

    def query_vedio_meeting_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryVedioMeetingStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryVedioMeetingStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryVedioMeetingStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryVedioMeetingStatisticalDataResponse(),
            self.do_roarequest('QueryVedioMeetingStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/vedioMeetingData', 'json', req, runtime)
        )

    async def query_vedio_meeting_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryVedioMeetingStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryVedioMeetingStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryVedioMeetingStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryVedioMeetingStatisticalDataResponse(),
            await self.do_roarequest_async('QueryVedioMeetingStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/vedioMeetingData', 'json', req, runtime)
        )

    def query_health_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryHealthStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryHealthStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryHealthStatisticalDataHeaders()
        return self.query_health_statistical_data_with_options(request, headers, runtime)

    async def query_health_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryHealthStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryHealthStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryHealthStatisticalDataHeaders()
        return await self.query_health_statistical_data_with_options_async(request, headers, runtime)

    def query_health_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryHealthStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryHealthStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryHealthStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryHealthStatisticalDataResponse(),
            self.do_roarequest('QueryHealthStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/healtheUserData', 'json', req, runtime)
        )

    async def query_health_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryHealthStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryHealthStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryHealthStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryHealthStatisticalDataResponse(),
            await self.do_roarequest_async('QueryHealthStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/healtheUserData', 'json', req, runtime)
        )

    def query_single_message_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QuerySingleMessageStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QuerySingleMessageStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QuerySingleMessageStatisticalDataHeaders()
        return self.query_single_message_statistical_data_with_options(request, headers, runtime)

    async def query_single_message_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QuerySingleMessageStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QuerySingleMessageStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QuerySingleMessageStatisticalDataHeaders()
        return await self.query_single_message_statistical_data_with_options_async(request, headers, runtime)

    def query_single_message_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QuerySingleMessageStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QuerySingleMessageStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QuerySingleMessageStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QuerySingleMessageStatisticalDataResponse(),
            self.do_roarequest('QuerySingleMessageStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/singleMessagerData', 'json', req, runtime)
        )

    async def query_single_message_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QuerySingleMessageStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QuerySingleMessageStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QuerySingleMessageStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QuerySingleMessageStatisticalDataResponse(),
            await self.do_roarequest_async('QuerySingleMessageStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/singleMessagerData', 'json', req, runtime)
        )

    def query_todo_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryTodoStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryTodoStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryTodoStatisticalDataHeaders()
        return self.query_todo_statistical_data_with_options(request, headers, runtime)

    async def query_todo_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryTodoStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryTodoStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryTodoStatisticalDataHeaders()
        return await self.query_todo_statistical_data_with_options_async(request, headers, runtime)

    def query_todo_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryTodoStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryTodoStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryTodoStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryTodoStatisticalDataResponse(),
            self.do_roarequest('QueryTodoStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/todoUserData', 'json', req, runtime)
        )

    async def query_todo_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryTodoStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryTodoStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryTodoStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryTodoStatisticalDataResponse(),
            await self.do_roarequest_async('QueryTodoStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/todoUserData', 'json', req, runtime)
        )

    def query_checkin_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryCheckinStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryCheckinStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryCheckinStatisticalDataHeaders()
        return self.query_checkin_statistical_data_with_options(request, headers, runtime)

    async def query_checkin_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryCheckinStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryCheckinStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryCheckinStatisticalDataHeaders()
        return await self.query_checkin_statistical_data_with_options_async(request, headers, runtime)

    def query_checkin_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryCheckinStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryCheckinStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryCheckinStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryCheckinStatisticalDataResponse(),
            self.do_roarequest('QueryCheckinStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/checkinData', 'json', req, runtime)
        )

    async def query_checkin_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryCheckinStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryCheckinStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryCheckinStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryCheckinStatisticalDataResponse(),
            await self.do_roarequest_async('QueryCheckinStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/checkinData', 'json', req, runtime)
        )

    def query_employee_type_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryEmployeeTypeStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryEmployeeTypeStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryEmployeeTypeStatisticalDataHeaders()
        return self.query_employee_type_statistical_data_with_options(request, headers, runtime)

    async def query_employee_type_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryEmployeeTypeStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryEmployeeTypeStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryEmployeeTypeStatisticalDataHeaders()
        return await self.query_employee_type_statistical_data_with_options_async(request, headers, runtime)

    def query_employee_type_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryEmployeeTypeStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryEmployeeTypeStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryEmployeeTypeStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryEmployeeTypeStatisticalDataResponse(),
            self.do_roarequest('QueryEmployeeTypeStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/employeeTypeData', 'json', req, runtime)
        )

    async def query_employee_type_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryEmployeeTypeStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryEmployeeTypeStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryEmployeeTypeStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryEmployeeTypeStatisticalDataResponse(),
            await self.do_roarequest_async('QueryEmployeeTypeStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/employeeTypeData', 'json', req, runtime)
        )

    def query_mail_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryMailStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryMailStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryMailStatisticalDataHeaders()
        return self.query_mail_statistical_data_with_options(request, headers, runtime)

    async def query_mail_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryMailStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryMailStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryMailStatisticalDataHeaders()
        return await self.query_mail_statistical_data_with_options_async(request, headers, runtime)

    def query_mail_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryMailStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryMailStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryMailStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryMailStatisticalDataResponse(),
            self.do_roarequest('QueryMailStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/mailData', 'json', req, runtime)
        )

    async def query_mail_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryMailStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryMailStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryMailStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryMailStatisticalDataResponse(),
            await self.do_roarequest_async('QueryMailStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/mailData', 'json', req, runtime)
        )

    def query_calendar_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryCalendarStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryCalendarStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryCalendarStatisticalDataHeaders()
        return self.query_calendar_statistical_data_with_options(request, headers, runtime)

    async def query_calendar_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryCalendarStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryCalendarStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryCalendarStatisticalDataHeaders()
        return await self.query_calendar_statistical_data_with_options_async(request, headers, runtime)

    def query_calendar_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryCalendarStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryCalendarStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryCalendarStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryCalendarStatisticalDataResponse(),
            self.do_roarequest('QueryCalendarStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/calendarData', 'json', req, runtime)
        )

    async def query_calendar_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryCalendarStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryCalendarStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryCalendarStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryCalendarStatisticalDataResponse(),
            await self.do_roarequest_async('QueryCalendarStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/calendarData', 'json', req, runtime)
        )

    def query_document_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryDocumentStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryDocumentStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryDocumentStatisticalDataHeaders()
        return self.query_document_statistical_data_with_options(request, headers, runtime)

    async def query_document_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryDocumentStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryDocumentStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryDocumentStatisticalDataHeaders()
        return await self.query_document_statistical_data_with_options_async(request, headers, runtime)

    def query_document_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryDocumentStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryDocumentStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryDocumentStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryDocumentStatisticalDataResponse(),
            self.do_roarequest('QueryDocumentStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/documentData', 'json', req, runtime)
        )

    async def query_document_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryDocumentStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryDocumentStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryDocumentStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryDocumentStatisticalDataResponse(),
            await self.do_roarequest_async('QueryDocumentStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/documentData', 'json', req, runtime)
        )

    def query_report_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryReportStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryReportStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryReportStatisticalDataHeaders()
        return self.query_report_statistical_data_with_options(request, headers, runtime)

    async def query_report_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryReportStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryReportStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryReportStatisticalDataHeaders()
        return await self.query_report_statistical_data_with_options_async(request, headers, runtime)

    def query_report_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryReportStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryReportStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryReportStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryReportStatisticalDataResponse(),
            self.do_roarequest('QueryReportStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/reportData', 'json', req, runtime)
        )

    async def query_report_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryReportStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryReportStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryReportStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryReportStatisticalDataResponse(),
            await self.do_roarequest_async('QueryReportStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/reportData', 'json', req, runtime)
        )

    def query_online_user_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryOnlineUserStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryOnlineUserStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryOnlineUserStatisticalDataHeaders()
        return self.query_online_user_statistical_data_with_options(request, headers, runtime)

    async def query_online_user_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryOnlineUserStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryOnlineUserStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryOnlineUserStatisticalDataHeaders()
        return await self.query_online_user_statistical_data_with_options_async(request, headers, runtime)

    def query_online_user_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryOnlineUserStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryOnlineUserStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryOnlineUserStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryOnlineUserStatisticalDataResponse(),
            self.do_roarequest('QueryOnlineUserStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/onlineUserData', 'json', req, runtime)
        )

    async def query_online_user_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryOnlineUserStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryOnlineUserStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryOnlineUserStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryOnlineUserStatisticalDataResponse(),
            await self.do_roarequest_async('QueryOnlineUserStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/onlineUserData', 'json', req, runtime)
        )

    def query_company_basic_info(
        self,
        request: dingtalkdatacenter__1__0_models.QueryCompanyBasicInfoRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryCompanyBasicInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryCompanyBasicInfoHeaders()
        return self.query_company_basic_info_with_options(request, headers, runtime)

    async def query_company_basic_info_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryCompanyBasicInfoRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryCompanyBasicInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryCompanyBasicInfoHeaders()
        return await self.query_company_basic_info_with_options_async(request, headers, runtime)

    def query_company_basic_info_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryCompanyBasicInfoRequest,
        headers: dingtalkdatacenter__1__0_models.QueryCompanyBasicInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryCompanyBasicInfoResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.keyword):
            query['keyword'] = request.keyword
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
            dingtalkdatacenter__1__0_models.QueryCompanyBasicInfoResponse(),
            self.do_roarequest('QueryCompanyBasicInfo', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/companies/basicInfo', 'json', req, runtime)
        )

    async def query_company_basic_info_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryCompanyBasicInfoRequest,
        headers: dingtalkdatacenter__1__0_models.QueryCompanyBasicInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryCompanyBasicInfoResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.keyword):
            query['keyword'] = request.keyword
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
            dingtalkdatacenter__1__0_models.QueryCompanyBasicInfoResponse(),
            await self.do_roarequest_async('QueryCompanyBasicInfo', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/companies/basicInfo', 'json', req, runtime)
        )

    def query_approval_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryApprovalStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryApprovalStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryApprovalStatisticalDataHeaders()
        return self.query_approval_statistical_data_with_options(request, headers, runtime)

    async def query_approval_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryApprovalStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryApprovalStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryApprovalStatisticalDataHeaders()
        return await self.query_approval_statistical_data_with_options_async(request, headers, runtime)

    def query_approval_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryApprovalStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryApprovalStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryApprovalStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryApprovalStatisticalDataResponse(),
            self.do_roarequest('QueryApprovalStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/approvalData', 'json', req, runtime)
        )

    async def query_approval_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryApprovalStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryApprovalStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryApprovalStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryApprovalStatisticalDataResponse(),
            await self.do_roarequest_async('QueryApprovalStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/approvalData', 'json', req, runtime)
        )

    def query_drive_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryDriveStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryDriveStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryDriveStatisticalDataHeaders()
        return self.query_drive_statistical_data_with_options(request, headers, runtime)

    async def query_drive_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryDriveStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryDriveStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryDriveStatisticalDataHeaders()
        return await self.query_drive_statistical_data_with_options_async(request, headers, runtime)

    def query_drive_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryDriveStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryDriveStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryDriveStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryDriveStatisticalDataResponse(),
            self.do_roarequest('QueryDriveStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/driveData', 'json', req, runtime)
        )

    async def query_drive_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryDriveStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryDriveStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryDriveStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryDriveStatisticalDataResponse(),
            await self.do_roarequest_async('QueryDriveStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/driveData', 'json', req, runtime)
        )

    def query_ding_send_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryDingSendStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryDingSendStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryDingSendStatisticalDataHeaders()
        return self.query_ding_send_statistical_data_with_options(request, headers, runtime)

    async def query_ding_send_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryDingSendStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryDingSendStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryDingSendStatisticalDataHeaders()
        return await self.query_ding_send_statistical_data_with_options_async(request, headers, runtime)

    def query_ding_send_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryDingSendStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryDingSendStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryDingSendStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryDingSendStatisticalDataResponse(),
            self.do_roarequest('QueryDingSendStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/dingSendData', 'json', req, runtime)
        )

    async def query_ding_send_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryDingSendStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryDingSendStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryDingSendStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryDingSendStatisticalDataResponse(),
            await self.do_roarequest_async('QueryDingSendStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/dingSendData', 'json', req, runtime)
        )

    def query_active_user_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryActiveUserStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryActiveUserStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryActiveUserStatisticalDataHeaders()
        return self.query_active_user_statistical_data_with_options(request, headers, runtime)

    async def query_active_user_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryActiveUserStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryActiveUserStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryActiveUserStatisticalDataHeaders()
        return await self.query_active_user_statistical_data_with_options_async(request, headers, runtime)

    def query_active_user_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryActiveUserStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryActiveUserStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryActiveUserStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryActiveUserStatisticalDataResponse(),
            self.do_roarequest('QueryActiveUserStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/activeUserData', 'json', req, runtime)
        )

    async def query_active_user_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryActiveUserStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryActiveUserStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryActiveUserStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryActiveUserStatisticalDataResponse(),
            await self.do_roarequest_async('QueryActiveUserStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/activeUserData', 'json', req, runtime)
        )

    def query_group_live_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryGroupLiveStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryGroupLiveStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryGroupLiveStatisticalDataHeaders()
        return self.query_group_live_statistical_data_with_options(request, headers, runtime)

    async def query_group_live_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryGroupLiveStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryGroupLiveStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryGroupLiveStatisticalDataHeaders()
        return await self.query_group_live_statistical_data_with_options_async(request, headers, runtime)

    def query_group_live_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryGroupLiveStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryGroupLiveStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryGroupLiveStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryGroupLiveStatisticalDataResponse(),
            self.do_roarequest('QueryGroupLiveStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/groupLiveData', 'json', req, runtime)
        )

    async def query_group_live_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryGroupLiveStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryGroupLiveStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryGroupLiveStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryGroupLiveStatisticalDataResponse(),
            await self.do_roarequest_async('QueryGroupLiveStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/groupLiveData', 'json', req, runtime)
        )

    def query_digital_district_org_info(
        self,
        request: dingtalkdatacenter__1__0_models.QueryDigitalDistrictOrgInfoRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryDigitalDistrictOrgInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryDigitalDistrictOrgInfoHeaders()
        return self.query_digital_district_org_info_with_options(request, headers, runtime)

    async def query_digital_district_org_info_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryDigitalDistrictOrgInfoRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryDigitalDistrictOrgInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryDigitalDistrictOrgInfoHeaders()
        return await self.query_digital_district_org_info_with_options_async(request, headers, runtime)

    def query_digital_district_org_info_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryDigitalDistrictOrgInfoRequest,
        headers: dingtalkdatacenter__1__0_models.QueryDigitalDistrictOrgInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryDigitalDistrictOrgInfoResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.kpi_group_id):
            body['kpiGroupId'] = request.kpi_group_id
        if not UtilClient.is_unset(request.stat_dates):
            body['statDates'] = request.stat_dates
        if not UtilClient.is_unset(request.corp_ids):
            body['corpIds'] = request.corp_ids
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
            dingtalkdatacenter__1__0_models.QueryDigitalDistrictOrgInfoResponse(),
            self.do_roarequest('QueryDigitalDistrictOrgInfo', 'datacenter_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/datacenter/digitalCounty/orgInfos/query', 'json', req, runtime)
        )

    async def query_digital_district_org_info_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryDigitalDistrictOrgInfoRequest,
        headers: dingtalkdatacenter__1__0_models.QueryDigitalDistrictOrgInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryDigitalDistrictOrgInfoResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.kpi_group_id):
            body['kpiGroupId'] = request.kpi_group_id
        if not UtilClient.is_unset(request.stat_dates):
            body['statDates'] = request.stat_dates
        if not UtilClient.is_unset(request.corp_ids):
            body['corpIds'] = request.corp_ids
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
            dingtalkdatacenter__1__0_models.QueryDigitalDistrictOrgInfoResponse(),
            await self.do_roarequest_async('QueryDigitalDistrictOrgInfo', 'datacenter_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/datacenter/digitalCounty/orgInfos/query', 'json', req, runtime)
        )

    def query_attendance_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryAttendanceStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryAttendanceStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryAttendanceStatisticalDataHeaders()
        return self.query_attendance_statistical_data_with_options(request, headers, runtime)

    async def query_attendance_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryAttendanceStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryAttendanceStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryAttendanceStatisticalDataHeaders()
        return await self.query_attendance_statistical_data_with_options_async(request, headers, runtime)

    def query_attendance_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryAttendanceStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryAttendanceStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryAttendanceStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryAttendanceStatisticalDataResponse(),
            self.do_roarequest('QueryAttendanceStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/attendanceData', 'json', req, runtime)
        )

    async def query_attendance_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryAttendanceStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryAttendanceStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryAttendanceStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryAttendanceStatisticalDataResponse(),
            await self.do_roarequest_async('QueryAttendanceStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/attendanceData', 'json', req, runtime)
        )

    def query_ding_recive_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryDingReciveStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryDingReciveStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryDingReciveStatisticalDataHeaders()
        return self.query_ding_recive_statistical_data_with_options(request, headers, runtime)

    async def query_ding_recive_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryDingReciveStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryDingReciveStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryDingReciveStatisticalDataHeaders()
        return await self.query_ding_recive_statistical_data_with_options_async(request, headers, runtime)

    def query_ding_recive_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryDingReciveStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryDingReciveStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryDingReciveStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryDingReciveStatisticalDataResponse(),
            self.do_roarequest('QueryDingReciveStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/dingReciveData', 'json', req, runtime)
        )

    async def query_ding_recive_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryDingReciveStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryDingReciveStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryDingReciveStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryDingReciveStatisticalDataResponse(),
            await self.do_roarequest_async('QueryDingReciveStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/dingReciveData', 'json', req, runtime)
        )

    def query_red_envelope_recive_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryRedEnvelopeReciveStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryRedEnvelopeReciveStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryRedEnvelopeReciveStatisticalDataHeaders()
        return self.query_red_envelope_recive_statistical_data_with_options(request, headers, runtime)

    async def query_red_envelope_recive_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryRedEnvelopeReciveStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryRedEnvelopeReciveStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryRedEnvelopeReciveStatisticalDataHeaders()
        return await self.query_red_envelope_recive_statistical_data_with_options_async(request, headers, runtime)

    def query_red_envelope_recive_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryRedEnvelopeReciveStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryRedEnvelopeReciveStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryRedEnvelopeReciveStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryRedEnvelopeReciveStatisticalDataResponse(),
            self.do_roarequest('QueryRedEnvelopeReciveStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/redEnvelopeReciveData', 'json', req, runtime)
        )

    async def query_red_envelope_recive_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryRedEnvelopeReciveStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryRedEnvelopeReciveStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryRedEnvelopeReciveStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryRedEnvelopeReciveStatisticalDataResponse(),
            await self.do_roarequest_async('QueryRedEnvelopeReciveStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/redEnvelopeReciveData', 'json', req, runtime)
        )

    def query_circle_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryCircleStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryCircleStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryCircleStatisticalDataHeaders()
        return self.query_circle_statistical_data_with_options(request, headers, runtime)

    async def query_circle_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryCircleStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryCircleStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryCircleStatisticalDataHeaders()
        return await self.query_circle_statistical_data_with_options_async(request, headers, runtime)

    def query_circle_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryCircleStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryCircleStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryCircleStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryCircleStatisticalDataResponse(),
            self.do_roarequest('QueryCircleStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/circleData', 'json', req, runtime)
        )

    async def query_circle_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryCircleStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryCircleStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryCircleStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryCircleStatisticalDataResponse(),
            await self.do_roarequest_async('QueryCircleStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/circleData', 'json', req, runtime)
        )

    def query_red_envelope_send_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryRedEnvelopeSendStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryRedEnvelopeSendStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryRedEnvelopeSendStatisticalDataHeaders()
        return self.query_red_envelope_send_statistical_data_with_options(request, headers, runtime)

    async def query_red_envelope_send_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryRedEnvelopeSendStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryRedEnvelopeSendStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryRedEnvelopeSendStatisticalDataHeaders()
        return await self.query_red_envelope_send_statistical_data_with_options_async(request, headers, runtime)

    def query_red_envelope_send_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryRedEnvelopeSendStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryRedEnvelopeSendStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryRedEnvelopeSendStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryRedEnvelopeSendStatisticalDataResponse(),
            self.do_roarequest('QueryRedEnvelopeSendStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/redEnvelopeSendData', 'json', req, runtime)
        )

    async def query_red_envelope_send_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryRedEnvelopeSendStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryRedEnvelopeSendStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryRedEnvelopeSendStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryRedEnvelopeSendStatisticalDataResponse(),
            await self.do_roarequest_async('QueryRedEnvelopeSendStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/redEnvelopeSendData', 'json', req, runtime)
        )

    def query_tel_meeting_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryTelMeetingStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryTelMeetingStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryTelMeetingStatisticalDataHeaders()
        return self.query_tel_meeting_statistical_data_with_options(request, headers, runtime)

    async def query_tel_meeting_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryTelMeetingStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryTelMeetingStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryTelMeetingStatisticalDataHeaders()
        return await self.query_tel_meeting_statistical_data_with_options_async(request, headers, runtime)

    def query_tel_meeting_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryTelMeetingStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryTelMeetingStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryTelMeetingStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryTelMeetingStatisticalDataResponse(),
            self.do_roarequest('QueryTelMeetingStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/telMeetingData', 'json', req, runtime)
        )

    async def query_tel_meeting_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryTelMeetingStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryTelMeetingStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryTelMeetingStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryTelMeetingStatisticalDataResponse(),
            await self.do_roarequest_async('QueryTelMeetingStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/telMeetingData', 'json', req, runtime)
        )

    def query_blackboard_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryBlackboardStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryBlackboardStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryBlackboardStatisticalDataHeaders()
        return self.query_blackboard_statistical_data_with_options(request, headers, runtime)

    async def query_blackboard_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryBlackboardStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryBlackboardStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryBlackboardStatisticalDataHeaders()
        return await self.query_blackboard_statistical_data_with_options_async(request, headers, runtime)

    def query_blackboard_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryBlackboardStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryBlackboardStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryBlackboardStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryBlackboardStatisticalDataResponse(),
            self.do_roarequest('QueryBlackboardStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/blackboardData', 'json', req, runtime)
        )

    async def query_blackboard_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryBlackboardStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryBlackboardStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryBlackboardStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryBlackboardStatisticalDataResponse(),
            await self.do_roarequest_async('QueryBlackboardStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/blackboardData', 'json', req, runtime)
        )
