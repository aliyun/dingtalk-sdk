# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.flashmeeting_1_0 import models as dingtalkflashmeeting__1__0_models
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

    def create_flash_meeting_with_options(
        self,
        request: dingtalkflashmeeting__1__0_models.CreateFlashMeetingRequest,
        headers: dingtalkflashmeeting__1__0_models.CreateFlashMeetingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkflashmeeting__1__0_models.CreateFlashMeetingResponse:
        """
        @summary 创建钉闪会并绑定日程
        
        @param request: CreateFlashMeetingRequest
        @param headers: CreateFlashMeetingHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateFlashMeetingResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.creator):
            body['creator'] = request.creator
        if not UtilClient.is_unset(request.event_id):
            body['eventId'] = request.event_id
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
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
            action='CreateFlashMeeting',
            version='flashmeeting_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/flashmeeting/meetings',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkflashmeeting__1__0_models.CreateFlashMeetingResponse(),
            self.execute(params, req, runtime)
        )

    async def create_flash_meeting_with_options_async(
        self,
        request: dingtalkflashmeeting__1__0_models.CreateFlashMeetingRequest,
        headers: dingtalkflashmeeting__1__0_models.CreateFlashMeetingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkflashmeeting__1__0_models.CreateFlashMeetingResponse:
        """
        @summary 创建钉闪会并绑定日程
        
        @param request: CreateFlashMeetingRequest
        @param headers: CreateFlashMeetingHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateFlashMeetingResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.creator):
            body['creator'] = request.creator
        if not UtilClient.is_unset(request.event_id):
            body['eventId'] = request.event_id
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
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
            action='CreateFlashMeeting',
            version='flashmeeting_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/flashmeeting/meetings',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkflashmeeting__1__0_models.CreateFlashMeetingResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_flash_meeting(
        self,
        request: dingtalkflashmeeting__1__0_models.CreateFlashMeetingRequest,
    ) -> dingtalkflashmeeting__1__0_models.CreateFlashMeetingResponse:
        """
        @summary 创建钉闪会并绑定日程
        
        @param request: CreateFlashMeetingRequest
        @return: CreateFlashMeetingResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkflashmeeting__1__0_models.CreateFlashMeetingHeaders()
        return self.create_flash_meeting_with_options(request, headers, runtime)

    async def create_flash_meeting_async(
        self,
        request: dingtalkflashmeeting__1__0_models.CreateFlashMeetingRequest,
    ) -> dingtalkflashmeeting__1__0_models.CreateFlashMeetingResponse:
        """
        @summary 创建钉闪会并绑定日程
        
        @param request: CreateFlashMeetingRequest
        @return: CreateFlashMeetingResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkflashmeeting__1__0_models.CreateFlashMeetingHeaders()
        return await self.create_flash_meeting_with_options_async(request, headers, runtime)

    def export_shanhui_to_doc_with_options(
        self,
        request: dingtalkflashmeeting__1__0_models.ExportShanhuiToDocRequest,
        headers: dingtalkflashmeeting__1__0_models.ExportShanhuiToDocHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkflashmeeting__1__0_models.ExportShanhuiToDocResponse:
        """
        @summary 将闪会导出到文档
        
        @param request: ExportShanhuiToDocRequest
        @param headers: ExportShanhuiToDocHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ExportShanhuiToDocResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.content_enums):
            body['contentEnums'] = request.content_enums
        if not UtilClient.is_unset(request.parent_node_key):
            body['parentNodeKey'] = request.parent_node_key
        if not UtilClient.is_unset(request.shanhui_key):
            body['shanhuiKey'] = request.shanhui_key
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.workspace_key):
            body['workspaceKey'] = request.workspace_key
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
            action='ExportShanhuiToDoc',
            version='flashmeeting_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/flashmeeting/meetings/export',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkflashmeeting__1__0_models.ExportShanhuiToDocResponse(),
            self.execute(params, req, runtime)
        )

    async def export_shanhui_to_doc_with_options_async(
        self,
        request: dingtalkflashmeeting__1__0_models.ExportShanhuiToDocRequest,
        headers: dingtalkflashmeeting__1__0_models.ExportShanhuiToDocHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkflashmeeting__1__0_models.ExportShanhuiToDocResponse:
        """
        @summary 将闪会导出到文档
        
        @param request: ExportShanhuiToDocRequest
        @param headers: ExportShanhuiToDocHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ExportShanhuiToDocResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.content_enums):
            body['contentEnums'] = request.content_enums
        if not UtilClient.is_unset(request.parent_node_key):
            body['parentNodeKey'] = request.parent_node_key
        if not UtilClient.is_unset(request.shanhui_key):
            body['shanhuiKey'] = request.shanhui_key
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.workspace_key):
            body['workspaceKey'] = request.workspace_key
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
            action='ExportShanhuiToDoc',
            version='flashmeeting_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/flashmeeting/meetings/export',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkflashmeeting__1__0_models.ExportShanhuiToDocResponse(),
            await self.execute_async(params, req, runtime)
        )

    def export_shanhui_to_doc(
        self,
        request: dingtalkflashmeeting__1__0_models.ExportShanhuiToDocRequest,
    ) -> dingtalkflashmeeting__1__0_models.ExportShanhuiToDocResponse:
        """
        @summary 将闪会导出到文档
        
        @param request: ExportShanhuiToDocRequest
        @return: ExportShanhuiToDocResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkflashmeeting__1__0_models.ExportShanhuiToDocHeaders()
        return self.export_shanhui_to_doc_with_options(request, headers, runtime)

    async def export_shanhui_to_doc_async(
        self,
        request: dingtalkflashmeeting__1__0_models.ExportShanhuiToDocRequest,
    ) -> dingtalkflashmeeting__1__0_models.ExportShanhuiToDocResponse:
        """
        @summary 将闪会导出到文档
        
        @param request: ExportShanhuiToDocRequest
        @return: ExportShanhuiToDocResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkflashmeeting__1__0_models.ExportShanhuiToDocHeaders()
        return await self.export_shanhui_to_doc_with_options_async(request, headers, runtime)

    def get_shanhui_by_calendar_with_options(
        self,
        request: dingtalkflashmeeting__1__0_models.GetShanhuiByCalendarRequest,
        headers: dingtalkflashmeeting__1__0_models.GetShanhuiByCalendarHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkflashmeeting__1__0_models.GetShanhuiByCalendarResponse:
        """
        @summary 根据日程获取闪会的信息
        
        @param request: GetShanhuiByCalendarRequest
        @param headers: GetShanhuiByCalendarHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetShanhuiByCalendarResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.event_id):
            query['eventId'] = request.event_id
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
            action='GetShanhuiByCalendar',
            version='flashmeeting_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/flashmeeting/calendars/meeting',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkflashmeeting__1__0_models.GetShanhuiByCalendarResponse(),
            self.execute(params, req, runtime)
        )

    async def get_shanhui_by_calendar_with_options_async(
        self,
        request: dingtalkflashmeeting__1__0_models.GetShanhuiByCalendarRequest,
        headers: dingtalkflashmeeting__1__0_models.GetShanhuiByCalendarHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkflashmeeting__1__0_models.GetShanhuiByCalendarResponse:
        """
        @summary 根据日程获取闪会的信息
        
        @param request: GetShanhuiByCalendarRequest
        @param headers: GetShanhuiByCalendarHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetShanhuiByCalendarResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.event_id):
            query['eventId'] = request.event_id
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
            action='GetShanhuiByCalendar',
            version='flashmeeting_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/flashmeeting/calendars/meeting',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkflashmeeting__1__0_models.GetShanhuiByCalendarResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_shanhui_by_calendar(
        self,
        request: dingtalkflashmeeting__1__0_models.GetShanhuiByCalendarRequest,
    ) -> dingtalkflashmeeting__1__0_models.GetShanhuiByCalendarResponse:
        """
        @summary 根据日程获取闪会的信息
        
        @param request: GetShanhuiByCalendarRequest
        @return: GetShanhuiByCalendarResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkflashmeeting__1__0_models.GetShanhuiByCalendarHeaders()
        return self.get_shanhui_by_calendar_with_options(request, headers, runtime)

    async def get_shanhui_by_calendar_async(
        self,
        request: dingtalkflashmeeting__1__0_models.GetShanhuiByCalendarRequest,
    ) -> dingtalkflashmeeting__1__0_models.GetShanhuiByCalendarResponse:
        """
        @summary 根据日程获取闪会的信息
        
        @param request: GetShanhuiByCalendarRequest
        @return: GetShanhuiByCalendarResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkflashmeeting__1__0_models.GetShanhuiByCalendarHeaders()
        return await self.get_shanhui_by_calendar_with_options_async(request, headers, runtime)

    def get_shanhui_by_shanhui_key_with_options(
        self,
        flashmeeting_key: str,
        headers: dingtalkflashmeeting__1__0_models.GetShanhuiByShanhuiKeyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkflashmeeting__1__0_models.GetShanhuiByShanhuiKeyResponse:
        """
        @summary 根据闪会key来闪会的信息，包含关联的日程、会议时间、议题等
        
        @param headers: GetShanhuiByShanhuiKeyHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetShanhuiByShanhuiKeyResponse
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
            action='GetShanhuiByShanhuiKey',
            version='flashmeeting_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/flashmeeting/meetings/keys/{flashmeeting_key}/infos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkflashmeeting__1__0_models.GetShanhuiByShanhuiKeyResponse(),
            self.execute(params, req, runtime)
        )

    async def get_shanhui_by_shanhui_key_with_options_async(
        self,
        flashmeeting_key: str,
        headers: dingtalkflashmeeting__1__0_models.GetShanhuiByShanhuiKeyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkflashmeeting__1__0_models.GetShanhuiByShanhuiKeyResponse:
        """
        @summary 根据闪会key来闪会的信息，包含关联的日程、会议时间、议题等
        
        @param headers: GetShanhuiByShanhuiKeyHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetShanhuiByShanhuiKeyResponse
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
            action='GetShanhuiByShanhuiKey',
            version='flashmeeting_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/flashmeeting/meetings/keys/{flashmeeting_key}/infos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkflashmeeting__1__0_models.GetShanhuiByShanhuiKeyResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_shanhui_by_shanhui_key(
        self,
        flashmeeting_key: str,
    ) -> dingtalkflashmeeting__1__0_models.GetShanhuiByShanhuiKeyResponse:
        """
        @summary 根据闪会key来闪会的信息，包含关联的日程、会议时间、议题等
        
        @return: GetShanhuiByShanhuiKeyResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkflashmeeting__1__0_models.GetShanhuiByShanhuiKeyHeaders()
        return self.get_shanhui_by_shanhui_key_with_options(flashmeeting_key, headers, runtime)

    async def get_shanhui_by_shanhui_key_async(
        self,
        flashmeeting_key: str,
    ) -> dingtalkflashmeeting__1__0_models.GetShanhuiByShanhuiKeyResponse:
        """
        @summary 根据闪会key来闪会的信息，包含关联的日程、会议时间、议题等
        
        @return: GetShanhuiByShanhuiKeyResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkflashmeeting__1__0_models.GetShanhuiByShanhuiKeyHeaders()
        return await self.get_shanhui_by_shanhui_key_with_options_async(flashmeeting_key, headers, runtime)

    def get_task_from_shanhui_doc_with_options(
        self,
        request: dingtalkflashmeeting__1__0_models.GetTaskFromShanhuiDocRequest,
        headers: dingtalkflashmeeting__1__0_models.GetTaskFromShanhuiDocHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkflashmeeting__1__0_models.GetTaskFromShanhuiDocResponse:
        """
        @summary 根据闪会文档id获取待办任务
        
        @param request: GetTaskFromShanhuiDocRequest
        @param headers: GetTaskFromShanhuiDocHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetTaskFromShanhuiDocResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.doc_key):
            query['docKey'] = request.doc_key
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
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
            action='GetTaskFromShanhuiDoc',
            version='flashmeeting_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/flashmeeting/meetings/tasks',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkflashmeeting__1__0_models.GetTaskFromShanhuiDocResponse(),
            self.execute(params, req, runtime)
        )

    async def get_task_from_shanhui_doc_with_options_async(
        self,
        request: dingtalkflashmeeting__1__0_models.GetTaskFromShanhuiDocRequest,
        headers: dingtalkflashmeeting__1__0_models.GetTaskFromShanhuiDocHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkflashmeeting__1__0_models.GetTaskFromShanhuiDocResponse:
        """
        @summary 根据闪会文档id获取待办任务
        
        @param request: GetTaskFromShanhuiDocRequest
        @param headers: GetTaskFromShanhuiDocHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetTaskFromShanhuiDocResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.doc_key):
            query['docKey'] = request.doc_key
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
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
            action='GetTaskFromShanhuiDoc',
            version='flashmeeting_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/flashmeeting/meetings/tasks',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkflashmeeting__1__0_models.GetTaskFromShanhuiDocResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_task_from_shanhui_doc(
        self,
        request: dingtalkflashmeeting__1__0_models.GetTaskFromShanhuiDocRequest,
    ) -> dingtalkflashmeeting__1__0_models.GetTaskFromShanhuiDocResponse:
        """
        @summary 根据闪会文档id获取待办任务
        
        @param request: GetTaskFromShanhuiDocRequest
        @return: GetTaskFromShanhuiDocResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkflashmeeting__1__0_models.GetTaskFromShanhuiDocHeaders()
        return self.get_task_from_shanhui_doc_with_options(request, headers, runtime)

    async def get_task_from_shanhui_doc_async(
        self,
        request: dingtalkflashmeeting__1__0_models.GetTaskFromShanhuiDocRequest,
    ) -> dingtalkflashmeeting__1__0_models.GetTaskFromShanhuiDocResponse:
        """
        @summary 根据闪会文档id获取待办任务
        
        @param request: GetTaskFromShanhuiDocRequest
        @return: GetTaskFromShanhuiDocResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkflashmeeting__1__0_models.GetTaskFromShanhuiDocHeaders()
        return await self.get_task_from_shanhui_doc_with_options_async(request, headers, runtime)
