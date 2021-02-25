# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
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
        return dingtalkedu__1__0_models.BatchCreateResponse().from_map(
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
        return dingtalkedu__1__0_models.BatchCreateResponse().from_map(
            await self.do_roarequest_async('BatchCreate', 'edu_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/edu/cards', 'json', req, runtime)
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
        return dingtalkedu__1__0_models.BatchOrgCreateHWResponse().from_map(
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
        return dingtalkedu__1__0_models.BatchOrgCreateHWResponse().from_map(
            await self.do_roarequest_async('BatchOrgCreateHW', 'edu_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/edu/homeworks', 'json', req, runtime)
        )
