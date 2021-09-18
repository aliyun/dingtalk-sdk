# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.exclusive_1_0 import models as dingtalkexclusive__1__0_models
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

    def get_conference_detail(
        self,
        conference_id: str,
    ) -> dingtalkexclusive__1__0_models.GetConferenceDetailResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetConferenceDetailHeaders()
        return self.get_conference_detail_with_options(conference_id, headers, runtime)

    async def get_conference_detail_async(
        self,
        conference_id: str,
    ) -> dingtalkexclusive__1__0_models.GetConferenceDetailResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetConferenceDetailHeaders()
        return await self.get_conference_detail_with_options_async(conference_id, headers, runtime)

    def get_conference_detail_with_options(
        self,
        conference_id: str,
        headers: dingtalkexclusive__1__0_models.GetConferenceDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetConferenceDetailResponse:
        conference_id = OpenApiUtilClient.get_encode_param(conference_id)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetConferenceDetailResponse(),
            self.do_roarequest('GetConferenceDetail', 'exclusive_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/exclusive/data/conferences/{conference_id}', 'json', req, runtime)
        )

    async def get_conference_detail_with_options_async(
        self,
        conference_id: str,
        headers: dingtalkexclusive__1__0_models.GetConferenceDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetConferenceDetailResponse:
        conference_id = OpenApiUtilClient.get_encode_param(conference_id)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetConferenceDetailResponse(),
            await self.do_roarequest_async('GetConferenceDetail', 'exclusive_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/exclusive/data/conferences/{conference_id}', 'json', req, runtime)
        )

    def get_user_app_version_summary(
        self,
        data_id: str,
        request: dingtalkexclusive__1__0_models.GetUserAppVersionSummaryRequest,
    ) -> dingtalkexclusive__1__0_models.GetUserAppVersionSummaryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetUserAppVersionSummaryHeaders()
        return self.get_user_app_version_summary_with_options(data_id, request, headers, runtime)

    async def get_user_app_version_summary_async(
        self,
        data_id: str,
        request: dingtalkexclusive__1__0_models.GetUserAppVersionSummaryRequest,
    ) -> dingtalkexclusive__1__0_models.GetUserAppVersionSummaryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetUserAppVersionSummaryHeaders()
        return await self.get_user_app_version_summary_with_options_async(data_id, request, headers, runtime)

    def get_user_app_version_summary_with_options(
        self,
        data_id: str,
        request: dingtalkexclusive__1__0_models.GetUserAppVersionSummaryRequest,
        headers: dingtalkexclusive__1__0_models.GetUserAppVersionSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetUserAppVersionSummaryResponse:
        UtilClient.validate_model(request)
        data_id = OpenApiUtilClient.get_encode_param(data_id)
        query = {}
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
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
            dingtalkexclusive__1__0_models.GetUserAppVersionSummaryResponse(),
            self.do_roarequest('GetUserAppVersionSummary', 'exclusive_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/exclusive/data/appVersion/org/{data_id}', 'json', req, runtime)
        )

    async def get_user_app_version_summary_with_options_async(
        self,
        data_id: str,
        request: dingtalkexclusive__1__0_models.GetUserAppVersionSummaryRequest,
        headers: dingtalkexclusive__1__0_models.GetUserAppVersionSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetUserAppVersionSummaryResponse:
        UtilClient.validate_model(request)
        data_id = OpenApiUtilClient.get_encode_param(data_id)
        query = {}
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
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
            dingtalkexclusive__1__0_models.GetUserAppVersionSummaryResponse(),
            await self.do_roarequest_async('GetUserAppVersionSummary', 'exclusive_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/exclusive/data/appVersion/org/{data_id}', 'json', req, runtime)
        )

    def delete_comment(
        self,
        publisher_id: str,
        comment_id: str,
    ) -> dingtalkexclusive__1__0_models.DeleteCommentResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.DeleteCommentHeaders()
        return self.delete_comment_with_options(publisher_id, comment_id, headers, runtime)

    async def delete_comment_async(
        self,
        publisher_id: str,
        comment_id: str,
    ) -> dingtalkexclusive__1__0_models.DeleteCommentResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.DeleteCommentHeaders()
        return await self.delete_comment_with_options_async(publisher_id, comment_id, headers, runtime)

    def delete_comment_with_options(
        self,
        publisher_id: str,
        comment_id: str,
        headers: dingtalkexclusive__1__0_models.DeleteCommentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.DeleteCommentResponse:
        publisher_id = OpenApiUtilClient.get_encode_param(publisher_id)
        comment_id = OpenApiUtilClient.get_encode_param(comment_id)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.DeleteCommentResponse(),
            self.do_roarequest('DeleteComment', 'exclusive_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/exclusive/publishers/{publisher_id}/comments/{comment_id}', 'boolean', req, runtime)
        )

    async def delete_comment_with_options_async(
        self,
        publisher_id: str,
        comment_id: str,
        headers: dingtalkexclusive__1__0_models.DeleteCommentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.DeleteCommentResponse:
        publisher_id = OpenApiUtilClient.get_encode_param(publisher_id)
        comment_id = OpenApiUtilClient.get_encode_param(comment_id)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.DeleteCommentResponse(),
            await self.do_roarequest_async('DeleteComment', 'exclusive_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/exclusive/publishers/{publisher_id}/comments/{comment_id}', 'boolean', req, runtime)
        )

    def get_all_labelable_depts(self) -> dingtalkexclusive__1__0_models.GetAllLabelableDeptsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetAllLabelableDeptsHeaders()
        return self.get_all_labelable_depts_with_options(headers, runtime)

    async def get_all_labelable_depts_async(self) -> dingtalkexclusive__1__0_models.GetAllLabelableDeptsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetAllLabelableDeptsHeaders()
        return await self.get_all_labelable_depts_with_options_async(headers, runtime)

    def get_all_labelable_depts_with_options(
        self,
        headers: dingtalkexclusive__1__0_models.GetAllLabelableDeptsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetAllLabelableDeptsResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetAllLabelableDeptsResponse(),
            self.do_roarequest('GetAllLabelableDepts', 'exclusive_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/exclusive/partnerDepartments', 'json', req, runtime)
        )

    async def get_all_labelable_depts_with_options_async(
        self,
        headers: dingtalkexclusive__1__0_models.GetAllLabelableDeptsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetAllLabelableDeptsResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetAllLabelableDeptsResponse(),
            await self.do_roarequest_async('GetAllLabelableDepts', 'exclusive_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/exclusive/partnerDepartments', 'json', req, runtime)
        )

    def get_publisher_summary(
        self,
        data_id: str,
        request: dingtalkexclusive__1__0_models.GetPublisherSummaryRequest,
    ) -> dingtalkexclusive__1__0_models.GetPublisherSummaryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetPublisherSummaryHeaders()
        return self.get_publisher_summary_with_options(data_id, request, headers, runtime)

    async def get_publisher_summary_async(
        self,
        data_id: str,
        request: dingtalkexclusive__1__0_models.GetPublisherSummaryRequest,
    ) -> dingtalkexclusive__1__0_models.GetPublisherSummaryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetPublisherSummaryHeaders()
        return await self.get_publisher_summary_with_options_async(data_id, request, headers, runtime)

    def get_publisher_summary_with_options(
        self,
        data_id: str,
        request: dingtalkexclusive__1__0_models.GetPublisherSummaryRequest,
        headers: dingtalkexclusive__1__0_models.GetPublisherSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetPublisherSummaryResponse:
        UtilClient.validate_model(request)
        data_id = OpenApiUtilClient.get_encode_param(data_id)
        query = {}
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
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
            dingtalkexclusive__1__0_models.GetPublisherSummaryResponse(),
            self.do_roarequest('GetPublisherSummary', 'exclusive_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/exclusive/data/publisher/{data_id}', 'json', req, runtime)
        )

    async def get_publisher_summary_with_options_async(
        self,
        data_id: str,
        request: dingtalkexclusive__1__0_models.GetPublisherSummaryRequest,
        headers: dingtalkexclusive__1__0_models.GetPublisherSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetPublisherSummaryResponse:
        UtilClient.validate_model(request)
        data_id = OpenApiUtilClient.get_encode_param(data_id)
        query = {}
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
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
            dingtalkexclusive__1__0_models.GetPublisherSummaryResponse(),
            await self.do_roarequest_async('GetPublisherSummary', 'exclusive_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/exclusive/data/publisher/{data_id}', 'json', req, runtime)
        )

    def get_doc_created_dept_summary(
        self,
        data_id: str,
        request: dingtalkexclusive__1__0_models.GetDocCreatedDeptSummaryRequest,
    ) -> dingtalkexclusive__1__0_models.GetDocCreatedDeptSummaryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetDocCreatedDeptSummaryHeaders()
        return self.get_doc_created_dept_summary_with_options(data_id, request, headers, runtime)

    async def get_doc_created_dept_summary_async(
        self,
        data_id: str,
        request: dingtalkexclusive__1__0_models.GetDocCreatedDeptSummaryRequest,
    ) -> dingtalkexclusive__1__0_models.GetDocCreatedDeptSummaryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetDocCreatedDeptSummaryHeaders()
        return await self.get_doc_created_dept_summary_with_options_async(data_id, request, headers, runtime)

    def get_doc_created_dept_summary_with_options(
        self,
        data_id: str,
        request: dingtalkexclusive__1__0_models.GetDocCreatedDeptSummaryRequest,
        headers: dingtalkexclusive__1__0_models.GetDocCreatedDeptSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetDocCreatedDeptSummaryResponse:
        UtilClient.validate_model(request)
        data_id = OpenApiUtilClient.get_encode_param(data_id)
        query = {}
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
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
            dingtalkexclusive__1__0_models.GetDocCreatedDeptSummaryResponse(),
            self.do_roarequest('GetDocCreatedDeptSummary', 'exclusive_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/exclusive/data/doc/dept/{data_id}', 'json', req, runtime)
        )

    async def get_doc_created_dept_summary_with_options_async(
        self,
        data_id: str,
        request: dingtalkexclusive__1__0_models.GetDocCreatedDeptSummaryRequest,
        headers: dingtalkexclusive__1__0_models.GetDocCreatedDeptSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetDocCreatedDeptSummaryResponse:
        UtilClient.validate_model(request)
        data_id = OpenApiUtilClient.get_encode_param(data_id)
        query = {}
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
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
            dingtalkexclusive__1__0_models.GetDocCreatedDeptSummaryResponse(),
            await self.do_roarequest_async('GetDocCreatedDeptSummary', 'exclusive_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/exclusive/data/doc/dept/{data_id}', 'json', req, runtime)
        )

    def get_general_form_created_summary(
        self,
        data_id: str,
    ) -> dingtalkexclusive__1__0_models.GetGeneralFormCreatedSummaryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetGeneralFormCreatedSummaryHeaders()
        return self.get_general_form_created_summary_with_options(data_id, headers, runtime)

    async def get_general_form_created_summary_async(
        self,
        data_id: str,
    ) -> dingtalkexclusive__1__0_models.GetGeneralFormCreatedSummaryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetGeneralFormCreatedSummaryHeaders()
        return await self.get_general_form_created_summary_with_options_async(data_id, headers, runtime)

    def get_general_form_created_summary_with_options(
        self,
        data_id: str,
        headers: dingtalkexclusive__1__0_models.GetGeneralFormCreatedSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetGeneralFormCreatedSummaryResponse:
        data_id = OpenApiUtilClient.get_encode_param(data_id)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetGeneralFormCreatedSummaryResponse(),
            self.do_roarequest('GetGeneralFormCreatedSummary', 'exclusive_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/exclusive/data/generalForm/org/{data_id}', 'json', req, runtime)
        )

    async def get_general_form_created_summary_with_options_async(
        self,
        data_id: str,
        headers: dingtalkexclusive__1__0_models.GetGeneralFormCreatedSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetGeneralFormCreatedSummaryResponse:
        data_id = OpenApiUtilClient.get_encode_param(data_id)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetGeneralFormCreatedSummaryResponse(),
            await self.do_roarequest_async('GetGeneralFormCreatedSummary', 'exclusive_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/exclusive/data/generalForm/org/{data_id}', 'json', req, runtime)
        )

    def create_trusted_device(
        self,
        request: dingtalkexclusive__1__0_models.CreateTrustedDeviceRequest,
    ) -> dingtalkexclusive__1__0_models.CreateTrustedDeviceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.CreateTrustedDeviceHeaders()
        return self.create_trusted_device_with_options(request, headers, runtime)

    async def create_trusted_device_async(
        self,
        request: dingtalkexclusive__1__0_models.CreateTrustedDeviceRequest,
    ) -> dingtalkexclusive__1__0_models.CreateTrustedDeviceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.CreateTrustedDeviceHeaders()
        return await self.create_trusted_device_with_options_async(request, headers, runtime)

    def create_trusted_device_with_options(
        self,
        request: dingtalkexclusive__1__0_models.CreateTrustedDeviceRequest,
        headers: dingtalkexclusive__1__0_models.CreateTrustedDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.CreateTrustedDeviceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.platform):
            body['platform'] = request.platform
        if not UtilClient.is_unset(request.mac_address):
            body['macAddress'] = request.mac_address
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
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
            dingtalkexclusive__1__0_models.CreateTrustedDeviceResponse(),
            self.do_roarequest('CreateTrustedDevice', 'exclusive_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/exclusive/trustedDevices', 'json', req, runtime)
        )

    async def create_trusted_device_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.CreateTrustedDeviceRequest,
        headers: dingtalkexclusive__1__0_models.CreateTrustedDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.CreateTrustedDeviceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.platform):
            body['platform'] = request.platform
        if not UtilClient.is_unset(request.mac_address):
            body['macAddress'] = request.mac_address
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
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
            dingtalkexclusive__1__0_models.CreateTrustedDeviceResponse(),
            await self.do_roarequest_async('CreateTrustedDevice', 'exclusive_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/exclusive/trustedDevices', 'json', req, runtime)
        )

    def get_doc_created_summary(
        self,
        data_id: str,
    ) -> dingtalkexclusive__1__0_models.GetDocCreatedSummaryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetDocCreatedSummaryHeaders()
        return self.get_doc_created_summary_with_options(data_id, headers, runtime)

    async def get_doc_created_summary_async(
        self,
        data_id: str,
    ) -> dingtalkexclusive__1__0_models.GetDocCreatedSummaryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetDocCreatedSummaryHeaders()
        return await self.get_doc_created_summary_with_options_async(data_id, headers, runtime)

    def get_doc_created_summary_with_options(
        self,
        data_id: str,
        headers: dingtalkexclusive__1__0_models.GetDocCreatedSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetDocCreatedSummaryResponse:
        data_id = OpenApiUtilClient.get_encode_param(data_id)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetDocCreatedSummaryResponse(),
            self.do_roarequest('GetDocCreatedSummary', 'exclusive_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/exclusive/data/doc/org/{data_id}', 'json', req, runtime)
        )

    async def get_doc_created_summary_with_options_async(
        self,
        data_id: str,
        headers: dingtalkexclusive__1__0_models.GetDocCreatedSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetDocCreatedSummaryResponse:
        data_id = OpenApiUtilClient.get_encode_param(data_id)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetDocCreatedSummaryResponse(),
            await self.do_roarequest_async('GetDocCreatedSummary', 'exclusive_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/exclusive/data/doc/org/{data_id}', 'json', req, runtime)
        )

    def get_partner_type_by_parent_id(
        self,
        parent_id: str,
    ) -> dingtalkexclusive__1__0_models.GetPartnerTypeByParentIdResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetPartnerTypeByParentIdHeaders()
        return self.get_partner_type_by_parent_id_with_options(parent_id, headers, runtime)

    async def get_partner_type_by_parent_id_async(
        self,
        parent_id: str,
    ) -> dingtalkexclusive__1__0_models.GetPartnerTypeByParentIdResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetPartnerTypeByParentIdHeaders()
        return await self.get_partner_type_by_parent_id_with_options_async(parent_id, headers, runtime)

    def get_partner_type_by_parent_id_with_options(
        self,
        parent_id: str,
        headers: dingtalkexclusive__1__0_models.GetPartnerTypeByParentIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetPartnerTypeByParentIdResponse:
        parent_id = OpenApiUtilClient.get_encode_param(parent_id)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetPartnerTypeByParentIdResponse(),
            self.do_roarequest('GetPartnerTypeByParentId', 'exclusive_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/exclusive/partnerLabels/{parent_id}', 'json', req, runtime)
        )

    async def get_partner_type_by_parent_id_with_options_async(
        self,
        parent_id: str,
        headers: dingtalkexclusive__1__0_models.GetPartnerTypeByParentIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetPartnerTypeByParentIdResponse:
        parent_id = OpenApiUtilClient.get_encode_param(parent_id)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetPartnerTypeByParentIdResponse(),
            await self.do_roarequest_async('GetPartnerTypeByParentId', 'exclusive_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/exclusive/partnerLabels/{parent_id}', 'json', req, runtime)
        )

    def set_dept_partner_type_and_num(
        self,
        request: dingtalkexclusive__1__0_models.SetDeptPartnerTypeAndNumRequest,
    ) -> dingtalkexclusive__1__0_models.SetDeptPartnerTypeAndNumResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.SetDeptPartnerTypeAndNumHeaders()
        return self.set_dept_partner_type_and_num_with_options(request, headers, runtime)

    async def set_dept_partner_type_and_num_async(
        self,
        request: dingtalkexclusive__1__0_models.SetDeptPartnerTypeAndNumRequest,
    ) -> dingtalkexclusive__1__0_models.SetDeptPartnerTypeAndNumResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.SetDeptPartnerTypeAndNumHeaders()
        return await self.set_dept_partner_type_and_num_with_options_async(request, headers, runtime)

    def set_dept_partner_type_and_num_with_options(
        self,
        request: dingtalkexclusive__1__0_models.SetDeptPartnerTypeAndNumRequest,
        headers: dingtalkexclusive__1__0_models.SetDeptPartnerTypeAndNumHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.SetDeptPartnerTypeAndNumResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dept_id):
            body['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.partner_num):
            body['partnerNum'] = request.partner_num
        if not UtilClient.is_unset(request.label_ids):
            body['labelIds'] = request.label_ids
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
            dingtalkexclusive__1__0_models.SetDeptPartnerTypeAndNumResponse(),
            self.do_roarequest('SetDeptPartnerTypeAndNum', 'exclusive_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/exclusive/partnerDepartments', 'none', req, runtime)
        )

    async def set_dept_partner_type_and_num_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.SetDeptPartnerTypeAndNumRequest,
        headers: dingtalkexclusive__1__0_models.SetDeptPartnerTypeAndNumHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.SetDeptPartnerTypeAndNumResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dept_id):
            body['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.partner_num):
            body['partnerNum'] = request.partner_num
        if not UtilClient.is_unset(request.label_ids):
            body['labelIds'] = request.label_ids
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
            dingtalkexclusive__1__0_models.SetDeptPartnerTypeAndNumResponse(),
            await self.do_roarequest_async('SetDeptPartnerTypeAndNum', 'exclusive_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/exclusive/partnerDepartments', 'none', req, runtime)
        )

    def get_active_user_summary(
        self,
        data_id: str,
    ) -> dingtalkexclusive__1__0_models.GetActiveUserSummaryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetActiveUserSummaryHeaders()
        return self.get_active_user_summary_with_options(data_id, headers, runtime)

    async def get_active_user_summary_async(
        self,
        data_id: str,
    ) -> dingtalkexclusive__1__0_models.GetActiveUserSummaryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetActiveUserSummaryHeaders()
        return await self.get_active_user_summary_with_options_async(data_id, headers, runtime)

    def get_active_user_summary_with_options(
        self,
        data_id: str,
        headers: dingtalkexclusive__1__0_models.GetActiveUserSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetActiveUserSummaryResponse:
        data_id = OpenApiUtilClient.get_encode_param(data_id)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetActiveUserSummaryResponse(),
            self.do_roarequest('GetActiveUserSummary', 'exclusive_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/exclusive/data/dau/org/{data_id}', 'json', req, runtime)
        )

    async def get_active_user_summary_with_options_async(
        self,
        data_id: str,
        headers: dingtalkexclusive__1__0_models.GetActiveUserSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetActiveUserSummaryResponse:
        data_id = OpenApiUtilClient.get_encode_param(data_id)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetActiveUserSummaryResponse(),
            await self.do_roarequest_async('GetActiveUserSummary', 'exclusive_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/exclusive/data/dau/org/{data_id}', 'json', req, runtime)
        )

    def get_oa_operator_log_list(
        self,
        request: dingtalkexclusive__1__0_models.GetOaOperatorLogListRequest,
    ) -> dingtalkexclusive__1__0_models.GetOaOperatorLogListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetOaOperatorLogListHeaders()
        return self.get_oa_operator_log_list_with_options(request, headers, runtime)

    async def get_oa_operator_log_list_async(
        self,
        request: dingtalkexclusive__1__0_models.GetOaOperatorLogListRequest,
    ) -> dingtalkexclusive__1__0_models.GetOaOperatorLogListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetOaOperatorLogListHeaders()
        return await self.get_oa_operator_log_list_with_options_async(request, headers, runtime)

    def get_oa_operator_log_list_with_options(
        self,
        request: dingtalkexclusive__1__0_models.GetOaOperatorLogListRequest,
        headers: dingtalkexclusive__1__0_models.GetOaOperatorLogListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetOaOperatorLogListResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.op_user_id):
            body['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.category_list):
            body['categoryList'] = request.category_list
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
            dingtalkexclusive__1__0_models.GetOaOperatorLogListResponse(),
            self.do_roarequest('GetOaOperatorLogList', 'exclusive_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/exclusive/oaOperatorLogs/query', 'json', req, runtime)
        )

    async def get_oa_operator_log_list_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.GetOaOperatorLogListRequest,
        headers: dingtalkexclusive__1__0_models.GetOaOperatorLogListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetOaOperatorLogListResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.op_user_id):
            body['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.category_list):
            body['categoryList'] = request.category_list
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
            dingtalkexclusive__1__0_models.GetOaOperatorLogListResponse(),
            await self.do_roarequest_async('GetOaOperatorLogList', 'exclusive_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/exclusive/oaOperatorLogs/query', 'json', req, runtime)
        )

    def get_ding_report_dept_summary(
        self,
        data_id: str,
        request: dingtalkexclusive__1__0_models.GetDingReportDeptSummaryRequest,
    ) -> dingtalkexclusive__1__0_models.GetDingReportDeptSummaryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetDingReportDeptSummaryHeaders()
        return self.get_ding_report_dept_summary_with_options(data_id, request, headers, runtime)

    async def get_ding_report_dept_summary_async(
        self,
        data_id: str,
        request: dingtalkexclusive__1__0_models.GetDingReportDeptSummaryRequest,
    ) -> dingtalkexclusive__1__0_models.GetDingReportDeptSummaryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetDingReportDeptSummaryHeaders()
        return await self.get_ding_report_dept_summary_with_options_async(data_id, request, headers, runtime)

    def get_ding_report_dept_summary_with_options(
        self,
        data_id: str,
        request: dingtalkexclusive__1__0_models.GetDingReportDeptSummaryRequest,
        headers: dingtalkexclusive__1__0_models.GetDingReportDeptSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetDingReportDeptSummaryResponse:
        UtilClient.validate_model(request)
        data_id = OpenApiUtilClient.get_encode_param(data_id)
        query = {}
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
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
            dingtalkexclusive__1__0_models.GetDingReportDeptSummaryResponse(),
            self.do_roarequest('GetDingReportDeptSummary', 'exclusive_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/exclusive/data/report/dept/{data_id}', 'json', req, runtime)
        )

    async def get_ding_report_dept_summary_with_options_async(
        self,
        data_id: str,
        request: dingtalkexclusive__1__0_models.GetDingReportDeptSummaryRequest,
        headers: dingtalkexclusive__1__0_models.GetDingReportDeptSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetDingReportDeptSummaryResponse:
        UtilClient.validate_model(request)
        data_id = OpenApiUtilClient.get_encode_param(data_id)
        query = {}
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
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
            dingtalkexclusive__1__0_models.GetDingReportDeptSummaryResponse(),
            await self.do_roarequest_async('GetDingReportDeptSummary', 'exclusive_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/exclusive/data/report/dept/{data_id}', 'json', req, runtime)
        )

    def get_trust_device_list(
        self,
        request: dingtalkexclusive__1__0_models.GetTrustDeviceListRequest,
    ) -> dingtalkexclusive__1__0_models.GetTrustDeviceListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetTrustDeviceListHeaders()
        return self.get_trust_device_list_with_options(request, headers, runtime)

    async def get_trust_device_list_async(
        self,
        request: dingtalkexclusive__1__0_models.GetTrustDeviceListRequest,
    ) -> dingtalkexclusive__1__0_models.GetTrustDeviceListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetTrustDeviceListHeaders()
        return await self.get_trust_device_list_with_options_async(request, headers, runtime)

    def get_trust_device_list_with_options(
        self,
        request: dingtalkexclusive__1__0_models.GetTrustDeviceListRequest,
        headers: dingtalkexclusive__1__0_models.GetTrustDeviceListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetTrustDeviceListResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.user_ids):
            body['userIds'] = request.user_ids
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
            dingtalkexclusive__1__0_models.GetTrustDeviceListResponse(),
            self.do_roarequest('GetTrustDeviceList', 'exclusive_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/exclusive/trustedDevices/query', 'json', req, runtime)
        )

    async def get_trust_device_list_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.GetTrustDeviceListRequest,
        headers: dingtalkexclusive__1__0_models.GetTrustDeviceListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetTrustDeviceListResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.user_ids):
            body['userIds'] = request.user_ids
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
            dingtalkexclusive__1__0_models.GetTrustDeviceListResponse(),
            await self.do_roarequest_async('GetTrustDeviceList', 'exclusive_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/exclusive/trustedDevices/query', 'json', req, runtime)
        )

    def get_general_form_created_dept_summary(
        self,
        data_id: str,
        request: dingtalkexclusive__1__0_models.GetGeneralFormCreatedDeptSummaryRequest,
    ) -> dingtalkexclusive__1__0_models.GetGeneralFormCreatedDeptSummaryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetGeneralFormCreatedDeptSummaryHeaders()
        return self.get_general_form_created_dept_summary_with_options(data_id, request, headers, runtime)

    async def get_general_form_created_dept_summary_async(
        self,
        data_id: str,
        request: dingtalkexclusive__1__0_models.GetGeneralFormCreatedDeptSummaryRequest,
    ) -> dingtalkexclusive__1__0_models.GetGeneralFormCreatedDeptSummaryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetGeneralFormCreatedDeptSummaryHeaders()
        return await self.get_general_form_created_dept_summary_with_options_async(data_id, request, headers, runtime)

    def get_general_form_created_dept_summary_with_options(
        self,
        data_id: str,
        request: dingtalkexclusive__1__0_models.GetGeneralFormCreatedDeptSummaryRequest,
        headers: dingtalkexclusive__1__0_models.GetGeneralFormCreatedDeptSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetGeneralFormCreatedDeptSummaryResponse:
        UtilClient.validate_model(request)
        data_id = OpenApiUtilClient.get_encode_param(data_id)
        query = {}
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
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
            dingtalkexclusive__1__0_models.GetGeneralFormCreatedDeptSummaryResponse(),
            self.do_roarequest('GetGeneralFormCreatedDeptSummary', 'exclusive_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/exclusive/data/generalForm/dept/{data_id}', 'json', req, runtime)
        )

    async def get_general_form_created_dept_summary_with_options_async(
        self,
        data_id: str,
        request: dingtalkexclusive__1__0_models.GetGeneralFormCreatedDeptSummaryRequest,
        headers: dingtalkexclusive__1__0_models.GetGeneralFormCreatedDeptSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetGeneralFormCreatedDeptSummaryResponse:
        UtilClient.validate_model(request)
        data_id = OpenApiUtilClient.get_encode_param(data_id)
        query = {}
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
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
            dingtalkexclusive__1__0_models.GetGeneralFormCreatedDeptSummaryResponse(),
            await self.do_roarequest_async('GetGeneralFormCreatedDeptSummary', 'exclusive_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/exclusive/data/generalForm/dept/{data_id}', 'json', req, runtime)
        )

    def search_org_inner_group_info(
        self,
        request: dingtalkexclusive__1__0_models.SearchOrgInnerGroupInfoRequest,
    ) -> dingtalkexclusive__1__0_models.SearchOrgInnerGroupInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.SearchOrgInnerGroupInfoHeaders()
        return self.search_org_inner_group_info_with_options(request, headers, runtime)

    async def search_org_inner_group_info_async(
        self,
        request: dingtalkexclusive__1__0_models.SearchOrgInnerGroupInfoRequest,
    ) -> dingtalkexclusive__1__0_models.SearchOrgInnerGroupInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.SearchOrgInnerGroupInfoHeaders()
        return await self.search_org_inner_group_info_with_options_async(request, headers, runtime)

    def search_org_inner_group_info_with_options(
        self,
        request: dingtalkexclusive__1__0_models.SearchOrgInnerGroupInfoRequest,
        headers: dingtalkexclusive__1__0_models.SearchOrgInnerGroupInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.SearchOrgInnerGroupInfoResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.group_members_count_end):
            query['groupMembersCountEnd'] = request.group_members_count_end
        if not UtilClient.is_unset(request.sync_to_dingpan):
            query['syncToDingpan'] = request.sync_to_dingpan
        if not UtilClient.is_unset(request.group_owner):
            query['groupOwner'] = request.group_owner
        if not UtilClient.is_unset(request.create_time_end):
            query['createTimeEnd'] = request.create_time_end
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.create_time_start):
            query['createTimeStart'] = request.create_time_start
        if not UtilClient.is_unset(request.uuid):
            query['uuid'] = request.uuid
        if not UtilClient.is_unset(request.group_members_count_start):
            query['groupMembersCountStart'] = request.group_members_count_start
        if not UtilClient.is_unset(request.last_active_time_end):
            query['lastActiveTimeEnd'] = request.last_active_time_end
        if not UtilClient.is_unset(request.operator_user_id):
            query['operatorUserId'] = request.operator_user_id
        if not UtilClient.is_unset(request.group_name):
            query['groupName'] = request.group_name
        if not UtilClient.is_unset(request.page_start):
            query['pageStart'] = request.page_start
        if not UtilClient.is_unset(request.last_active_time_start):
            query['lastActiveTimeStart'] = request.last_active_time_start
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
            dingtalkexclusive__1__0_models.SearchOrgInnerGroupInfoResponse(),
            self.do_roarequest('SearchOrgInnerGroupInfo', 'exclusive_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/exclusive/securities/orgGroupInfos', 'json', req, runtime)
        )

    async def search_org_inner_group_info_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.SearchOrgInnerGroupInfoRequest,
        headers: dingtalkexclusive__1__0_models.SearchOrgInnerGroupInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.SearchOrgInnerGroupInfoResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.group_members_count_end):
            query['groupMembersCountEnd'] = request.group_members_count_end
        if not UtilClient.is_unset(request.sync_to_dingpan):
            query['syncToDingpan'] = request.sync_to_dingpan
        if not UtilClient.is_unset(request.group_owner):
            query['groupOwner'] = request.group_owner
        if not UtilClient.is_unset(request.create_time_end):
            query['createTimeEnd'] = request.create_time_end
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.create_time_start):
            query['createTimeStart'] = request.create_time_start
        if not UtilClient.is_unset(request.uuid):
            query['uuid'] = request.uuid
        if not UtilClient.is_unset(request.group_members_count_start):
            query['groupMembersCountStart'] = request.group_members_count_start
        if not UtilClient.is_unset(request.last_active_time_end):
            query['lastActiveTimeEnd'] = request.last_active_time_end
        if not UtilClient.is_unset(request.operator_user_id):
            query['operatorUserId'] = request.operator_user_id
        if not UtilClient.is_unset(request.group_name):
            query['groupName'] = request.group_name
        if not UtilClient.is_unset(request.page_start):
            query['pageStart'] = request.page_start
        if not UtilClient.is_unset(request.last_active_time_start):
            query['lastActiveTimeStart'] = request.last_active_time_start
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
            dingtalkexclusive__1__0_models.SearchOrgInnerGroupInfoResponse(),
            await self.do_roarequest_async('SearchOrgInnerGroupInfo', 'exclusive_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/exclusive/securities/orgGroupInfos', 'json', req, runtime)
        )

    def get_calender_summary(
        self,
        data_id: str,
    ) -> dingtalkexclusive__1__0_models.GetCalenderSummaryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetCalenderSummaryHeaders()
        return self.get_calender_summary_with_options(data_id, headers, runtime)

    async def get_calender_summary_async(
        self,
        data_id: str,
    ) -> dingtalkexclusive__1__0_models.GetCalenderSummaryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetCalenderSummaryHeaders()
        return await self.get_calender_summary_with_options_async(data_id, headers, runtime)

    def get_calender_summary_with_options(
        self,
        data_id: str,
        headers: dingtalkexclusive__1__0_models.GetCalenderSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetCalenderSummaryResponse:
        data_id = OpenApiUtilClient.get_encode_param(data_id)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetCalenderSummaryResponse(),
            self.do_roarequest('GetCalenderSummary', 'exclusive_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/exclusive/data/calendar/org/{data_id}', 'json', req, runtime)
        )

    async def get_calender_summary_with_options_async(
        self,
        data_id: str,
        headers: dingtalkexclusive__1__0_models.GetCalenderSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetCalenderSummaryResponse:
        data_id = OpenApiUtilClient.get_encode_param(data_id)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetCalenderSummaryResponse(),
            await self.do_roarequest_async('GetCalenderSummary', 'exclusive_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/exclusive/data/calendar/org/{data_id}', 'json', req, runtime)
        )

    def get_group_active_info(
        self,
        request: dingtalkexclusive__1__0_models.GetGroupActiveInfoRequest,
    ) -> dingtalkexclusive__1__0_models.GetGroupActiveInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetGroupActiveInfoHeaders()
        return self.get_group_active_info_with_options(request, headers, runtime)

    async def get_group_active_info_async(
        self,
        request: dingtalkexclusive__1__0_models.GetGroupActiveInfoRequest,
    ) -> dingtalkexclusive__1__0_models.GetGroupActiveInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetGroupActiveInfoHeaders()
        return await self.get_group_active_info_with_options_async(request, headers, runtime)

    def get_group_active_info_with_options(
        self,
        request: dingtalkexclusive__1__0_models.GetGroupActiveInfoRequest,
        headers: dingtalkexclusive__1__0_models.GetGroupActiveInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetGroupActiveInfoResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
        if not UtilClient.is_unset(request.ding_group_id):
            query['dingGroupId'] = request.ding_group_id
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
            dingtalkexclusive__1__0_models.GetGroupActiveInfoResponse(),
            self.do_roarequest('GetGroupActiveInfo', 'exclusive_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/exclusive/data/activeGroups', 'json', req, runtime)
        )

    async def get_group_active_info_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.GetGroupActiveInfoRequest,
        headers: dingtalkexclusive__1__0_models.GetGroupActiveInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetGroupActiveInfoResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
        if not UtilClient.is_unset(request.ding_group_id):
            query['dingGroupId'] = request.ding_group_id
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
            dingtalkexclusive__1__0_models.GetGroupActiveInfoResponse(),
            await self.do_roarequest_async('GetGroupActiveInfo', 'exclusive_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/exclusive/data/activeGroups', 'json', req, runtime)
        )

    def get_comment_list(
        self,
        publisher_id: str,
        request: dingtalkexclusive__1__0_models.GetCommentListRequest,
    ) -> dingtalkexclusive__1__0_models.GetCommentListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetCommentListHeaders()
        return self.get_comment_list_with_options(publisher_id, request, headers, runtime)

    async def get_comment_list_async(
        self,
        publisher_id: str,
        request: dingtalkexclusive__1__0_models.GetCommentListRequest,
    ) -> dingtalkexclusive__1__0_models.GetCommentListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetCommentListHeaders()
        return await self.get_comment_list_with_options_async(publisher_id, request, headers, runtime)

    def get_comment_list_with_options(
        self,
        publisher_id: str,
        request: dingtalkexclusive__1__0_models.GetCommentListRequest,
        headers: dingtalkexclusive__1__0_models.GetCommentListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetCommentListResponse:
        UtilClient.validate_model(request)
        publisher_id = OpenApiUtilClient.get_encode_param(publisher_id)
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
            dingtalkexclusive__1__0_models.GetCommentListResponse(),
            self.do_roarequest('GetCommentList', 'exclusive_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/exclusive/publishers/{publisher_id}/comments/list', 'json', req, runtime)
        )

    async def get_comment_list_with_options_async(
        self,
        publisher_id: str,
        request: dingtalkexclusive__1__0_models.GetCommentListRequest,
        headers: dingtalkexclusive__1__0_models.GetCommentListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetCommentListResponse:
        UtilClient.validate_model(request)
        publisher_id = OpenApiUtilClient.get_encode_param(publisher_id)
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
            dingtalkexclusive__1__0_models.GetCommentListResponse(),
            await self.do_roarequest_async('GetCommentList', 'exclusive_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/exclusive/publishers/{publisher_id}/comments/list', 'json', req, runtime)
        )
