# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.contact_1_0 import models as dingtalkcontact__1__0_models
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

    def sort_user(
        self,
        request: dingtalkcontact__1__0_models.SortUserRequest,
    ) -> dingtalkcontact__1__0_models.SortUserResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.SortUserHeaders()
        return self.sort_user_with_options(request, headers, runtime)

    async def sort_user_async(
        self,
        request: dingtalkcontact__1__0_models.SortUserRequest,
    ) -> dingtalkcontact__1__0_models.SortUserResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.SortUserHeaders()
        return await self.sort_user_with_options_async(request, headers, runtime)

    def sort_user_with_options(
        self,
        request: dingtalkcontact__1__0_models.SortUserRequest,
        headers: dingtalkcontact__1__0_models.SortUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.SortUserResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
        if not UtilClient.is_unset(request.user_id_list):
            body['userIdList'] = request.user_id_list
        if not UtilClient.is_unset(request.sort_type):
            body['sortType'] = request.sort_type
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
            dingtalkcontact__1__0_models.SortUserResponse(),
            self.do_roarequest('SortUser', 'contact_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/contact/users/sort', 'json', req, runtime)
        )

    async def sort_user_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.SortUserRequest,
        headers: dingtalkcontact__1__0_models.SortUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.SortUserResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
        if not UtilClient.is_unset(request.user_id_list):
            body['userIdList'] = request.user_id_list
        if not UtilClient.is_unset(request.sort_type):
            body['sortType'] = request.sort_type
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
            dingtalkcontact__1__0_models.SortUserResponse(),
            await self.do_roarequest_async('SortUser', 'contact_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/contact/users/sort', 'json', req, runtime)
        )

    def update_emp_attrbute_visibility_setting(
        self,
        request: dingtalkcontact__1__0_models.UpdateEmpAttrbuteVisibilitySettingRequest,
    ) -> dingtalkcontact__1__0_models.UpdateEmpAttrbuteVisibilitySettingResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.UpdateEmpAttrbuteVisibilitySettingHeaders()
        return self.update_emp_attrbute_visibility_setting_with_options(request, headers, runtime)

    async def update_emp_attrbute_visibility_setting_async(
        self,
        request: dingtalkcontact__1__0_models.UpdateEmpAttrbuteVisibilitySettingRequest,
    ) -> dingtalkcontact__1__0_models.UpdateEmpAttrbuteVisibilitySettingResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.UpdateEmpAttrbuteVisibilitySettingHeaders()
        return await self.update_emp_attrbute_visibility_setting_with_options_async(request, headers, runtime)

    def update_emp_attrbute_visibility_setting_with_options(
        self,
        request: dingtalkcontact__1__0_models.UpdateEmpAttrbuteVisibilitySettingRequest,
        headers: dingtalkcontact__1__0_models.UpdateEmpAttrbuteVisibilitySettingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.UpdateEmpAttrbuteVisibilitySettingResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.id):
            body['id'] = request.id
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.object_staff_ids):
            body['objectStaffIds'] = request.object_staff_ids
        if not UtilClient.is_unset(request.object_dept_ids):
            body['objectDeptIds'] = request.object_dept_ids
        if not UtilClient.is_unset(request.object_tag_ids):
            body['objectTagIds'] = request.object_tag_ids
        if not UtilClient.is_unset(request.hide_fields):
            body['hideFields'] = request.hide_fields
        if not UtilClient.is_unset(request.exclude_staff_ids):
            body['excludeStaffIds'] = request.exclude_staff_ids
        if not UtilClient.is_unset(request.exclude_dept_ids):
            body['excludeDeptIds'] = request.exclude_dept_ids
        if not UtilClient.is_unset(request.exclude_tag_ids):
            body['excludeTagIds'] = request.exclude_tag_ids
        if not UtilClient.is_unset(request.active):
            body['active'] = request.active
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
            dingtalkcontact__1__0_models.UpdateEmpAttrbuteVisibilitySettingResponse(),
            self.do_roarequest('UpdateEmpAttrbuteVisibilitySetting', 'contact_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/contact/staffAttributes/visibilitySettings', 'json', req, runtime)
        )

    async def update_emp_attrbute_visibility_setting_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.UpdateEmpAttrbuteVisibilitySettingRequest,
        headers: dingtalkcontact__1__0_models.UpdateEmpAttrbuteVisibilitySettingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.UpdateEmpAttrbuteVisibilitySettingResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.id):
            body['id'] = request.id
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.object_staff_ids):
            body['objectStaffIds'] = request.object_staff_ids
        if not UtilClient.is_unset(request.object_dept_ids):
            body['objectDeptIds'] = request.object_dept_ids
        if not UtilClient.is_unset(request.object_tag_ids):
            body['objectTagIds'] = request.object_tag_ids
        if not UtilClient.is_unset(request.hide_fields):
            body['hideFields'] = request.hide_fields
        if not UtilClient.is_unset(request.exclude_staff_ids):
            body['excludeStaffIds'] = request.exclude_staff_ids
        if not UtilClient.is_unset(request.exclude_dept_ids):
            body['excludeDeptIds'] = request.exclude_dept_ids
        if not UtilClient.is_unset(request.exclude_tag_ids):
            body['excludeTagIds'] = request.exclude_tag_ids
        if not UtilClient.is_unset(request.active):
            body['active'] = request.active
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
            dingtalkcontact__1__0_models.UpdateEmpAttrbuteVisibilitySettingResponse(),
            await self.do_roarequest_async('UpdateEmpAttrbuteVisibilitySetting', 'contact_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/contact/staffAttributes/visibilitySettings', 'json', req, runtime)
        )

    def delete_emp_attribute_visibility(
        self,
        setting_id: str,
    ) -> dingtalkcontact__1__0_models.DeleteEmpAttributeVisibilityResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.DeleteEmpAttributeVisibilityHeaders()
        return self.delete_emp_attribute_visibility_with_options(setting_id, headers, runtime)

    async def delete_emp_attribute_visibility_async(
        self,
        setting_id: str,
    ) -> dingtalkcontact__1__0_models.DeleteEmpAttributeVisibilityResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.DeleteEmpAttributeVisibilityHeaders()
        return await self.delete_emp_attribute_visibility_with_options_async(setting_id, headers, runtime)

    def delete_emp_attribute_visibility_with_options(
        self,
        setting_id: str,
        headers: dingtalkcontact__1__0_models.DeleteEmpAttributeVisibilityHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.DeleteEmpAttributeVisibilityResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.DeleteEmpAttributeVisibilityResponse(),
            self.do_roarequest('DeleteEmpAttributeVisibility', 'contact_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/contact/staffAttributes/visibilitySettings/{setting_id}', 'none', req, runtime)
        )

    async def delete_emp_attribute_visibility_with_options_async(
        self,
        setting_id: str,
        headers: dingtalkcontact__1__0_models.DeleteEmpAttributeVisibilityHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.DeleteEmpAttributeVisibilityResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.DeleteEmpAttributeVisibilityResponse(),
            await self.do_roarequest_async('DeleteEmpAttributeVisibility', 'contact_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/contact/staffAttributes/visibilitySettings/{setting_id}', 'none', req, runtime)
        )

    def search_department(
        self,
        request: dingtalkcontact__1__0_models.SearchDepartmentRequest,
    ) -> dingtalkcontact__1__0_models.SearchDepartmentResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.SearchDepartmentHeaders()
        return self.search_department_with_options(request, headers, runtime)

    async def search_department_async(
        self,
        request: dingtalkcontact__1__0_models.SearchDepartmentRequest,
    ) -> dingtalkcontact__1__0_models.SearchDepartmentResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.SearchDepartmentHeaders()
        return await self.search_department_with_options_async(request, headers, runtime)

    def search_department_with_options(
        self,
        request: dingtalkcontact__1__0_models.SearchDepartmentRequest,
        headers: dingtalkcontact__1__0_models.SearchDepartmentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.SearchDepartmentResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
        if not UtilClient.is_unset(request.query_word):
            body['queryWord'] = request.query_word
        if not UtilClient.is_unset(request.offset):
            body['offset'] = request.offset
        if not UtilClient.is_unset(request.size):
            body['size'] = request.size
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
            dingtalkcontact__1__0_models.SearchDepartmentResponse(),
            self.do_roarequest('SearchDepartment', 'contact_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/contact/departments/search', 'json', req, runtime)
        )

    async def search_department_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.SearchDepartmentRequest,
        headers: dingtalkcontact__1__0_models.SearchDepartmentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.SearchDepartmentResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
        if not UtilClient.is_unset(request.query_word):
            body['queryWord'] = request.query_word
        if not UtilClient.is_unset(request.offset):
            body['offset'] = request.offset
        if not UtilClient.is_unset(request.size):
            body['size'] = request.size
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
            dingtalkcontact__1__0_models.SearchDepartmentResponse(),
            await self.do_roarequest_async('SearchDepartment', 'contact_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/contact/departments/search', 'json', req, runtime)
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

    def list_emp_attribute_visibility(
        self,
        request: dingtalkcontact__1__0_models.ListEmpAttributeVisibilityRequest,
    ) -> dingtalkcontact__1__0_models.ListEmpAttributeVisibilityResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.ListEmpAttributeVisibilityHeaders()
        return self.list_emp_attribute_visibility_with_options(request, headers, runtime)

    async def list_emp_attribute_visibility_async(
        self,
        request: dingtalkcontact__1__0_models.ListEmpAttributeVisibilityRequest,
    ) -> dingtalkcontact__1__0_models.ListEmpAttributeVisibilityResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.ListEmpAttributeVisibilityHeaders()
        return await self.list_emp_attribute_visibility_with_options_async(request, headers, runtime)

    def list_emp_attribute_visibility_with_options(
        self,
        request: dingtalkcontact__1__0_models.ListEmpAttributeVisibilityRequest,
        headers: dingtalkcontact__1__0_models.ListEmpAttributeVisibilityHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.ListEmpAttributeVisibilityResponse:
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
            dingtalkcontact__1__0_models.ListEmpAttributeVisibilityResponse(),
            self.do_roarequest('ListEmpAttributeVisibility', 'contact_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/contact/staffAttributes/visibilitySettings', 'json', req, runtime)
        )

    async def list_emp_attribute_visibility_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.ListEmpAttributeVisibilityRequest,
        headers: dingtalkcontact__1__0_models.ListEmpAttributeVisibilityHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.ListEmpAttributeVisibilityResponse:
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
            dingtalkcontact__1__0_models.ListEmpAttributeVisibilityResponse(),
            await self.do_roarequest_async('ListEmpAttributeVisibility', 'contact_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/contact/staffAttributes/visibilitySettings', 'json', req, runtime)
        )

    def search_user(
        self,
        request: dingtalkcontact__1__0_models.SearchUserRequest,
    ) -> dingtalkcontact__1__0_models.SearchUserResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.SearchUserHeaders()
        return self.search_user_with_options(request, headers, runtime)

    async def search_user_async(
        self,
        request: dingtalkcontact__1__0_models.SearchUserRequest,
    ) -> dingtalkcontact__1__0_models.SearchUserResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.SearchUserHeaders()
        return await self.search_user_with_options_async(request, headers, runtime)

    def search_user_with_options(
        self,
        request: dingtalkcontact__1__0_models.SearchUserRequest,
        headers: dingtalkcontact__1__0_models.SearchUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.SearchUserResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
        if not UtilClient.is_unset(request.query_word):
            body['queryWord'] = request.query_word
        if not UtilClient.is_unset(request.offset):
            body['offset'] = request.offset
        if not UtilClient.is_unset(request.size):
            body['size'] = request.size
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
            dingtalkcontact__1__0_models.SearchUserResponse(),
            self.do_roarequest('SearchUser', 'contact_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/contact/users/search', 'json', req, runtime)
        )

    async def search_user_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.SearchUserRequest,
        headers: dingtalkcontact__1__0_models.SearchUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.SearchUserResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
        if not UtilClient.is_unset(request.query_word):
            body['queryWord'] = request.query_word
        if not UtilClient.is_unset(request.offset):
            body['offset'] = request.offset
        if not UtilClient.is_unset(request.size):
            body['size'] = request.size
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
            dingtalkcontact__1__0_models.SearchUserResponse(),
            await self.do_roarequest_async('SearchUser', 'contact_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/contact/users/search', 'json', req, runtime)
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

    def create_cooperate_org(
        self,
        request: dingtalkcontact__1__0_models.CreateCooperateOrgRequest,
    ) -> dingtalkcontact__1__0_models.CreateCooperateOrgResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.CreateCooperateOrgHeaders()
        return self.create_cooperate_org_with_options(request, headers, runtime)

    async def create_cooperate_org_async(
        self,
        request: dingtalkcontact__1__0_models.CreateCooperateOrgRequest,
    ) -> dingtalkcontact__1__0_models.CreateCooperateOrgResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.CreateCooperateOrgHeaders()
        return await self.create_cooperate_org_with_options_async(request, headers, runtime)

    def create_cooperate_org_with_options(
        self,
        request: dingtalkcontact__1__0_models.CreateCooperateOrgRequest,
        headers: dingtalkcontact__1__0_models.CreateCooperateOrgHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.CreateCooperateOrgResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.org_name):
            body['orgName'] = request.org_name
        if not UtilClient.is_unset(request.logo_media_id):
            body['logoMediaId'] = request.logo_media_id
        if not UtilClient.is_unset(request.industry_code):
            body['industryCode'] = request.industry_code
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
            dingtalkcontact__1__0_models.CreateCooperateOrgResponse(),
            self.do_roarequest('CreateCooperateOrg', 'contact_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/contact/cooperateCorps', 'json', req, runtime)
        )

    async def create_cooperate_org_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.CreateCooperateOrgRequest,
        headers: dingtalkcontact__1__0_models.CreateCooperateOrgHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.CreateCooperateOrgResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.org_name):
            body['orgName'] = request.org_name
        if not UtilClient.is_unset(request.logo_media_id):
            body['logoMediaId'] = request.logo_media_id
        if not UtilClient.is_unset(request.industry_code):
            body['industryCode'] = request.industry_code
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
            dingtalkcontact__1__0_models.CreateCooperateOrgResponse(),
            await self.do_roarequest_async('CreateCooperateOrg', 'contact_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/contact/cooperateCorps', 'json', req, runtime)
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

    def update_user_ownness(
        self,
        user_id: str,
        request: dingtalkcontact__1__0_models.UpdateUserOwnnessRequest,
    ) -> dingtalkcontact__1__0_models.UpdateUserOwnnessResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.UpdateUserOwnnessHeaders()
        return self.update_user_ownness_with_options(user_id, request, headers, runtime)

    async def update_user_ownness_async(
        self,
        user_id: str,
        request: dingtalkcontact__1__0_models.UpdateUserOwnnessRequest,
    ) -> dingtalkcontact__1__0_models.UpdateUserOwnnessResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.UpdateUserOwnnessHeaders()
        return await self.update_user_ownness_with_options_async(user_id, request, headers, runtime)

    def update_user_ownness_with_options(
        self,
        user_id: str,
        request: dingtalkcontact__1__0_models.UpdateUserOwnnessRequest,
        headers: dingtalkcontact__1__0_models.UpdateUserOwnnessHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.UpdateUserOwnnessResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.ownenss_type):
            body['ownenssType'] = request.ownenss_type
        if not UtilClient.is_unset(request.id):
            body['id'] = request.id
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.deleted_flag):
            body['deletedFlag'] = request.deleted_flag
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
            dingtalkcontact__1__0_models.UpdateUserOwnnessResponse(),
            self.do_roarequest('UpdateUserOwnness', 'contact_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/contact/user/{user_id}/ownness', 'json', req, runtime)
        )

    async def update_user_ownness_with_options_async(
        self,
        user_id: str,
        request: dingtalkcontact__1__0_models.UpdateUserOwnnessRequest,
        headers: dingtalkcontact__1__0_models.UpdateUserOwnnessHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.UpdateUserOwnnessResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.ownenss_type):
            body['ownenssType'] = request.ownenss_type
        if not UtilClient.is_unset(request.id):
            body['id'] = request.id
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.deleted_flag):
            body['deletedFlag'] = request.deleted_flag
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
            dingtalkcontact__1__0_models.UpdateUserOwnnessResponse(),
            await self.do_roarequest_async('UpdateUserOwnness', 'contact_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/contact/user/{user_id}/ownness', 'json', req, runtime)
        )

    def get_cooperate_org_invite_info(
        self,
        cooperate_corp_id: str,
    ) -> dingtalkcontact__1__0_models.GetCooperateOrgInviteInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.GetCooperateOrgInviteInfoHeaders()
        return self.get_cooperate_org_invite_info_with_options(cooperate_corp_id, headers, runtime)

    async def get_cooperate_org_invite_info_async(
        self,
        cooperate_corp_id: str,
    ) -> dingtalkcontact__1__0_models.GetCooperateOrgInviteInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.GetCooperateOrgInviteInfoHeaders()
        return await self.get_cooperate_org_invite_info_with_options_async(cooperate_corp_id, headers, runtime)

    def get_cooperate_org_invite_info_with_options(
        self,
        cooperate_corp_id: str,
        headers: dingtalkcontact__1__0_models.GetCooperateOrgInviteInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.GetCooperateOrgInviteInfoResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.GetCooperateOrgInviteInfoResponse(),
            self.do_roarequest('GetCooperateOrgInviteInfo', 'contact_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/contact/cooperateCorps/{cooperate_corp_id}/inviteInfos', 'json', req, runtime)
        )

    async def get_cooperate_org_invite_info_with_options_async(
        self,
        cooperate_corp_id: str,
        headers: dingtalkcontact__1__0_models.GetCooperateOrgInviteInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.GetCooperateOrgInviteInfoResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.GetCooperateOrgInviteInfoResponse(),
            await self.do_roarequest_async('GetCooperateOrgInviteInfo', 'contact_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/contact/cooperateCorps/{cooperate_corp_id}/inviteInfos', 'json', req, runtime)
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

    def update_management_group(
        self,
        group_id: str,
        request: dingtalkcontact__1__0_models.UpdateManagementGroupRequest,
    ) -> dingtalkcontact__1__0_models.UpdateManagementGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.UpdateManagementGroupHeaders()
        return self.update_management_group_with_options(group_id, request, headers, runtime)

    async def update_management_group_async(
        self,
        group_id: str,
        request: dingtalkcontact__1__0_models.UpdateManagementGroupRequest,
    ) -> dingtalkcontact__1__0_models.UpdateManagementGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.UpdateManagementGroupHeaders()
        return await self.update_management_group_with_options_async(group_id, request, headers, runtime)

    def update_management_group_with_options(
        self,
        group_id: str,
        request: dingtalkcontact__1__0_models.UpdateManagementGroupRequest,
        headers: dingtalkcontact__1__0_models.UpdateManagementGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.UpdateManagementGroupResponse:
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
            dingtalkcontact__1__0_models.UpdateManagementGroupResponse(),
            self.do_roarequest('UpdateManagementGroup', 'contact_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/contact/managementGroups/{group_id}', 'none', req, runtime)
        )

    async def update_management_group_with_options_async(
        self,
        group_id: str,
        request: dingtalkcontact__1__0_models.UpdateManagementGroupRequest,
        headers: dingtalkcontact__1__0_models.UpdateManagementGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.UpdateManagementGroupResponse:
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
            dingtalkcontact__1__0_models.UpdateManagementGroupResponse(),
            await self.do_roarequest_async('UpdateManagementGroup', 'contact_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/contact/managementGroups/{group_id}', 'none', req, runtime)
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
