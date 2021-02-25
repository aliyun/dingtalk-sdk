# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalkapp_market_1_0 import models as dingtalkapp_market__1__0_models
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

    def user_task_report(
        self,
        request: dingtalkapp_market__1__0_models.UserTaskReportRequest,
    ) -> dingtalkapp_market__1__0_models.UserTaskReportResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkapp_market__1__0_models.UserTaskReportHeaders()
        return self.user_task_report_with_options(request, headers, runtime)

    async def user_task_report_async(
        self,
        request: dingtalkapp_market__1__0_models.UserTaskReportRequest,
    ) -> dingtalkapp_market__1__0_models.UserTaskReportResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkapp_market__1__0_models.UserTaskReportHeaders()
        return await self.user_task_report_with_options_async(request, headers, runtime)

    def user_task_report_with_options(
        self,
        request: dingtalkapp_market__1__0_models.UserTaskReportRequest,
        headers: dingtalkapp_market__1__0_models.UserTaskReportHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkapp_market__1__0_models.UserTaskReportResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.ding_corp_id):
            body['dingCorpId'] = request.ding_corp_id
        if not UtilClient.is_unset(request.task_tag):
            body['taskTag'] = request.task_tag
        if not UtilClient.is_unset(request.operate_date):
            body['operateDate'] = request.operate_date
        if not UtilClient.is_unset(request.userid):
            body['userid'] = request.userid
        if not UtilClient.is_unset(request.biz_no):
            body['bizNo'] = request.biz_no
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return dingtalkapp_market__1__0_models.UserTaskReportResponse().from_map(
            self.do_roarequest('UserTaskReport', 'appMarket_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/appMarket/tasks', 'boolean', req, runtime)
        )

    async def user_task_report_with_options_async(
        self,
        request: dingtalkapp_market__1__0_models.UserTaskReportRequest,
        headers: dingtalkapp_market__1__0_models.UserTaskReportHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkapp_market__1__0_models.UserTaskReportResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.ding_corp_id):
            body['dingCorpId'] = request.ding_corp_id
        if not UtilClient.is_unset(request.task_tag):
            body['taskTag'] = request.task_tag
        if not UtilClient.is_unset(request.operate_date):
            body['operateDate'] = request.operate_date
        if not UtilClient.is_unset(request.userid):
            body['userid'] = request.userid
        if not UtilClient.is_unset(request.biz_no):
            body['bizNo'] = request.biz_no
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return dingtalkapp_market__1__0_models.UserTaskReportResponse().from_map(
            await self.do_roarequest_async('UserTaskReport', 'appMarket_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/appMarket/tasks', 'boolean', req, runtime)
        )
