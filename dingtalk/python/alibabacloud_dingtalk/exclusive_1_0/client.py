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
