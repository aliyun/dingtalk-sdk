# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

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
        return TeaCore.from_map(
            dingtalkapp_market__1__0_models.UserTaskReportResponse(),
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
        return TeaCore.from_map(
            dingtalkapp_market__1__0_models.UserTaskReportResponse(),
            await self.do_roarequest_async('UserTaskReport', 'appMarket_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/appMarket/tasks', 'boolean', req, runtime)
        )

    def get_personal_experience_info(
        self,
        request: dingtalkapp_market__1__0_models.GetPersonalExperienceInfoRequest,
    ) -> dingtalkapp_market__1__0_models.GetPersonalExperienceInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkapp_market__1__0_models.GetPersonalExperienceInfoHeaders()
        return self.get_personal_experience_info_with_options(request, headers, runtime)

    async def get_personal_experience_info_async(
        self,
        request: dingtalkapp_market__1__0_models.GetPersonalExperienceInfoRequest,
    ) -> dingtalkapp_market__1__0_models.GetPersonalExperienceInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkapp_market__1__0_models.GetPersonalExperienceInfoHeaders()
        return await self.get_personal_experience_info_with_options_async(request, headers, runtime)

    def get_personal_experience_info_with_options(
        self,
        request: dingtalkapp_market__1__0_models.GetPersonalExperienceInfoRequest,
        headers: dingtalkapp_market__1__0_models.GetPersonalExperienceInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkapp_market__1__0_models.GetPersonalExperienceInfoResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
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
            dingtalkapp_market__1__0_models.GetPersonalExperienceInfoResponse(),
            self.do_roarequest('GetPersonalExperienceInfo', 'appMarket_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/appMarket/personalExperiences', 'json', req, runtime)
        )

    async def get_personal_experience_info_with_options_async(
        self,
        request: dingtalkapp_market__1__0_models.GetPersonalExperienceInfoRequest,
        headers: dingtalkapp_market__1__0_models.GetPersonalExperienceInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkapp_market__1__0_models.GetPersonalExperienceInfoResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
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
            dingtalkapp_market__1__0_models.GetPersonalExperienceInfoResponse(),
            await self.do_roarequest_async('GetPersonalExperienceInfo', 'appMarket_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/appMarket/personalExperiences', 'json', req, runtime)
        )
