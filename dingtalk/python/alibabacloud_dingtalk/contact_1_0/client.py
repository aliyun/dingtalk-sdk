# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalkcontact_1_0 import models as dingtalkcontact__1__0_models
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

    def query_resource_management_members(
        self,
        resource_id: str,
    ) -> dingtalkcontact__1__0_models.QueryResourceManagementMembersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.QueryResourceManagementMembersHeaders()
        return self.query_resource_management_members_with_options(resource_id, headers, runtime)

    async def query_resource_management_members_async(
        self,
        resource_id: str,
    ) -> dingtalkcontact__1__0_models.QueryResourceManagementMembersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.QueryResourceManagementMembersHeaders()
        return await self.query_resource_management_members_with_options_async(resource_id, headers, runtime)

    def query_resource_management_members_with_options(
        self,
        resource_id: str,
        headers: dingtalkcontact__1__0_models.QueryResourceManagementMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.QueryResourceManagementMembersResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.QueryResourceManagementMembersResponse(),
            self.do_roarequest('QueryResourceManagementMembers', 'contact_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/contact/resources/{resource_id}/managementMembers', 'json', req, runtime)
        )

    async def query_resource_management_members_with_options_async(
        self,
        resource_id: str,
        headers: dingtalkcontact__1__0_models.QueryResourceManagementMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.QueryResourceManagementMembersResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.QueryResourceManagementMembersResponse(),
            await self.do_roarequest_async('QueryResourceManagementMembers', 'contact_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/contact/resources/{resource_id}/managementMembers', 'json', req, runtime)
        )

    def query_user_management_resources(
        self,
        user_id: str,
    ) -> dingtalkcontact__1__0_models.QueryUserManagementResourcesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.QueryUserManagementResourcesHeaders()
        return self.query_user_management_resources_with_options(user_id, headers, runtime)

    async def query_user_management_resources_async(
        self,
        user_id: str,
    ) -> dingtalkcontact__1__0_models.QueryUserManagementResourcesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.QueryUserManagementResourcesHeaders()
        return await self.query_user_management_resources_with_options_async(user_id, headers, runtime)

    def query_user_management_resources_with_options(
        self,
        user_id: str,
        headers: dingtalkcontact__1__0_models.QueryUserManagementResourcesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.QueryUserManagementResourcesResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.QueryUserManagementResourcesResponse(),
            self.do_roarequest('QueryUserManagementResources', 'contact_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/contact/users/{user_id}/managemementResources', 'json', req, runtime)
        )

    async def query_user_management_resources_with_options_async(
        self,
        user_id: str,
        headers: dingtalkcontact__1__0_models.QueryUserManagementResourcesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.QueryUserManagementResourcesResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.QueryUserManagementResourcesResponse(),
            await self.do_roarequest_async('QueryUserManagementResources', 'contact_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/contact/users/{user_id}/managemementResources', 'json', req, runtime)
        )

    def list_management_groups(
        self,
        request: dingtalkcontact__1__0_models.ListManagementGroupsRequest,
    ) -> dingtalkcontact__1__0_models.ListManagementGroupsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.ListManagementGroupsHeaders()
        return self.list_management_groups_with_options(request, headers, runtime)

    async def list_management_groups_async(
        self,
        request: dingtalkcontact__1__0_models.ListManagementGroupsRequest,
    ) -> dingtalkcontact__1__0_models.ListManagementGroupsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.ListManagementGroupsHeaders()
        return await self.list_management_groups_with_options_async(request, headers, runtime)

    def list_management_groups_with_options(
        self,
        request: dingtalkcontact__1__0_models.ListManagementGroupsRequest,
        headers: dingtalkcontact__1__0_models.ListManagementGroupsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.ListManagementGroupsResponse:
        UtilClient.validate_model(request)
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
            dingtalkcontact__1__0_models.ListManagementGroupsResponse(),
            self.do_roarequest('ListManagementGroups', 'contact_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/contact/managementGroups', 'json', req, runtime)
        )

    async def list_management_groups_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.ListManagementGroupsRequest,
        headers: dingtalkcontact__1__0_models.ListManagementGroupsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.ListManagementGroupsResponse:
        UtilClient.validate_model(request)
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
            dingtalkcontact__1__0_models.ListManagementGroupsResponse(),
            await self.do_roarequest_async('ListManagementGroups', 'contact_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/contact/managementGroups', 'json', req, runtime)
        )

    def create_management_group(
        self,
        request: dingtalkcontact__1__0_models.CreateManagementGroupRequest,
    ) -> dingtalkcontact__1__0_models.CreateManagementGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.CreateManagementGroupHeaders()
        return self.create_management_group_with_options(request, headers, runtime)

    async def create_management_group_async(
        self,
        request: dingtalkcontact__1__0_models.CreateManagementGroupRequest,
    ) -> dingtalkcontact__1__0_models.CreateManagementGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.CreateManagementGroupHeaders()
        return await self.create_management_group_with_options_async(request, headers, runtime)

    def create_management_group_with_options(
        self,
        request: dingtalkcontact__1__0_models.CreateManagementGroupRequest,
        headers: dingtalkcontact__1__0_models.CreateManagementGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.CreateManagementGroupResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.group_name):
            body['groupName'] = request.group_name
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        if not UtilClient.is_unset(request.scope):
            body['scope'] = request.scope
        if not UtilClient.is_unset(request.resource_ids):
            body['resourceIds'] = request.resource_ids
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
            dingtalkcontact__1__0_models.CreateManagementGroupResponse(),
            self.do_roarequest('CreateManagementGroup', 'contact_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/contact/managementGroups', 'json', req, runtime)
        )

    async def create_management_group_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.CreateManagementGroupRequest,
        headers: dingtalkcontact__1__0_models.CreateManagementGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.CreateManagementGroupResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.group_name):
            body['groupName'] = request.group_name
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        if not UtilClient.is_unset(request.scope):
            body['scope'] = request.scope
        if not UtilClient.is_unset(request.resource_ids):
            body['resourceIds'] = request.resource_ids
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
            dingtalkcontact__1__0_models.CreateManagementGroupResponse(),
            await self.do_roarequest_async('CreateManagementGroup', 'contact_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/contact/managementGroups', 'json', req, runtime)
        )

    def delete_management_group(
        self,
        group_id: str,
    ) -> dingtalkcontact__1__0_models.DeleteManagementGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.DeleteManagementGroupHeaders()
        return self.delete_management_group_with_options(group_id, headers, runtime)

    async def delete_management_group_async(
        self,
        group_id: str,
    ) -> dingtalkcontact__1__0_models.DeleteManagementGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.DeleteManagementGroupHeaders()
        return await self.delete_management_group_with_options_async(group_id, headers, runtime)

    def delete_management_group_with_options(
        self,
        group_id: str,
        headers: dingtalkcontact__1__0_models.DeleteManagementGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.DeleteManagementGroupResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.DeleteManagementGroupResponse(),
            self.do_roarequest('DeleteManagementGroup', 'contact_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/contact/managementGroups/{group_id}', 'none', req, runtime)
        )

    async def delete_management_group_with_options_async(
        self,
        group_id: str,
        headers: dingtalkcontact__1__0_models.DeleteManagementGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.DeleteManagementGroupResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.DeleteManagementGroupResponse(),
            await self.do_roarequest_async('DeleteManagementGroup', 'contact_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/contact/managementGroups/{group_id}', 'none', req, runtime)
        )

    def get_apply_invite_info(
        self,
        request: dingtalkcontact__1__0_models.GetApplyInviteInfoRequest,
    ) -> dingtalkcontact__1__0_models.GetApplyInviteInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.GetApplyInviteInfoHeaders()
        return self.get_apply_invite_info_with_options(request, headers, runtime)

    async def get_apply_invite_info_async(
        self,
        request: dingtalkcontact__1__0_models.GetApplyInviteInfoRequest,
    ) -> dingtalkcontact__1__0_models.GetApplyInviteInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.GetApplyInviteInfoHeaders()
        return await self.get_apply_invite_info_with_options_async(request, headers, runtime)

    def get_apply_invite_info_with_options(
        self,
        request: dingtalkcontact__1__0_models.GetApplyInviteInfoRequest,
        headers: dingtalkcontact__1__0_models.GetApplyInviteInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.GetApplyInviteInfoResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.inviter_user_id):
            query['inviterUserId'] = request.inviter_user_id
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
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
            dingtalkcontact__1__0_models.GetApplyInviteInfoResponse(),
            self.do_roarequest('GetApplyInviteInfo', 'contact_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/contact/invites/infos', 'json', req, runtime)
        )

    async def get_apply_invite_info_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.GetApplyInviteInfoRequest,
        headers: dingtalkcontact__1__0_models.GetApplyInviteInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.GetApplyInviteInfoResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.inviter_user_id):
            query['inviterUserId'] = request.inviter_user_id
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
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
            dingtalkcontact__1__0_models.GetApplyInviteInfoResponse(),
            await self.do_roarequest_async('GetApplyInviteInfo', 'contact_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/contact/invites/infos', 'json', req, runtime)
        )

    def get_branch_auth_data(
        self,
        request: dingtalkcontact__1__0_models.GetBranchAuthDataRequest,
    ) -> dingtalkcontact__1__0_models.GetBranchAuthDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.GetBranchAuthDataHeaders()
        return self.get_branch_auth_data_with_options(request, headers, runtime)

    async def get_branch_auth_data_async(
        self,
        request: dingtalkcontact__1__0_models.GetBranchAuthDataRequest,
    ) -> dingtalkcontact__1__0_models.GetBranchAuthDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.GetBranchAuthDataHeaders()
        return await self.get_branch_auth_data_with_options_async(request, headers, runtime)

    def get_branch_auth_data_with_options(
        self,
        request: dingtalkcontact__1__0_models.GetBranchAuthDataRequest,
        headers: dingtalkcontact__1__0_models.GetBranchAuthDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.GetBranchAuthDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.branch_corp_id):
            query['branchCorpId'] = request.branch_corp_id
        if not UtilClient.is_unset(request.code):
            query['code'] = request.code
        body = {}
        if not UtilClient.is_unset(request.body):
            body = request.body
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.GetBranchAuthDataResponse(),
            self.do_roarequest('GetBranchAuthData', 'contact_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/contact/branchAuthDatas/search', 'json', req, runtime)
        )

    async def get_branch_auth_data_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.GetBranchAuthDataRequest,
        headers: dingtalkcontact__1__0_models.GetBranchAuthDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.GetBranchAuthDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.branch_corp_id):
            query['branchCorpId'] = request.branch_corp_id
        if not UtilClient.is_unset(request.code):
            query['code'] = request.code
        body = {}
        if not UtilClient.is_unset(request.body):
            body = request.body
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.GetBranchAuthDataResponse(),
            await self.do_roarequest_async('GetBranchAuthData', 'contact_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/contact/branchAuthDatas/search', 'json', req, runtime)
        )

    def get_latest_ding_index(self) -> dingtalkcontact__1__0_models.GetLatestDingIndexResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.GetLatestDingIndexHeaders()
        return self.get_latest_ding_index_with_options(headers, runtime)

    async def get_latest_ding_index_async(self) -> dingtalkcontact__1__0_models.GetLatestDingIndexResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.GetLatestDingIndexHeaders()
        return await self.get_latest_ding_index_with_options_async(headers, runtime)

    def get_latest_ding_index_with_options(
        self,
        headers: dingtalkcontact__1__0_models.GetLatestDingIndexHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.GetLatestDingIndexResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.GetLatestDingIndexResponse(),
            self.do_roarequest('GetLatestDingIndex', 'contact_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/contact/dingIndexs', 'json', req, runtime)
        )

    async def get_latest_ding_index_with_options_async(
        self,
        headers: dingtalkcontact__1__0_models.GetLatestDingIndexHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.GetLatestDingIndexResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.GetLatestDingIndexResponse(),
            await self.do_roarequest_async('GetLatestDingIndex', 'contact_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/contact/dingIndexs', 'json', req, runtime)
        )

    def get_user(
        self,
        union_id: str,
    ) -> dingtalkcontact__1__0_models.GetUserResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.GetUserHeaders()
        return self.get_user_with_options(union_id, headers, runtime)

    async def get_user_async(
        self,
        union_id: str,
    ) -> dingtalkcontact__1__0_models.GetUserResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.GetUserHeaders()
        return await self.get_user_with_options_async(union_id, headers, runtime)

    def get_user_with_options(
        self,
        union_id: str,
        headers: dingtalkcontact__1__0_models.GetUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.GetUserResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.GetUserResponse(),
            self.do_roarequest('GetUser', 'contact_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/contact/users/{union_id}', 'json', req, runtime)
        )

    async def get_user_with_options_async(
        self,
        union_id: str,
        headers: dingtalkcontact__1__0_models.GetUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.GetUserResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.GetUserResponse(),
            await self.do_roarequest_async('GetUser', 'contact_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/contact/users/{union_id}', 'json', req, runtime)
        )
