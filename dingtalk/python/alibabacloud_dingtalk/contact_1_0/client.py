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
        setting_id = OpenApiUtilClient.get_encode_param(setting_id)
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
        setting_id = OpenApiUtilClient.get_encode_param(setting_id)
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

    def list_senior_settings(
        self,
        request: dingtalkcontact__1__0_models.ListSeniorSettingsRequest,
    ) -> dingtalkcontact__1__0_models.ListSeniorSettingsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.ListSeniorSettingsHeaders()
        return self.list_senior_settings_with_options(request, headers, runtime)

    async def list_senior_settings_async(
        self,
        request: dingtalkcontact__1__0_models.ListSeniorSettingsRequest,
    ) -> dingtalkcontact__1__0_models.ListSeniorSettingsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.ListSeniorSettingsHeaders()
        return await self.list_senior_settings_with_options_async(request, headers, runtime)

    def list_senior_settings_with_options(
        self,
        request: dingtalkcontact__1__0_models.ListSeniorSettingsRequest,
        headers: dingtalkcontact__1__0_models.ListSeniorSettingsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.ListSeniorSettingsResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.senior_staff_id):
            query['seniorStaffId'] = request.senior_staff_id
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
            dingtalkcontact__1__0_models.ListSeniorSettingsResponse(),
            self.do_roarequest('ListSeniorSettings', 'contact_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/contact/seniorSettings', 'json', req, runtime)
        )

    async def list_senior_settings_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.ListSeniorSettingsRequest,
        headers: dingtalkcontact__1__0_models.ListSeniorSettingsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.ListSeniorSettingsResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.senior_staff_id):
            query['seniorStaffId'] = request.senior_staff_id
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
            dingtalkcontact__1__0_models.ListSeniorSettingsResponse(),
            await self.do_roarequest_async('ListSeniorSettings', 'contact_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/contact/seniorSettings', 'json', req, runtime)
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

    def get_translate_file_job_result(
        self,
        request: dingtalkcontact__1__0_models.GetTranslateFileJobResultRequest,
    ) -> dingtalkcontact__1__0_models.GetTranslateFileJobResultResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.GetTranslateFileJobResultHeaders()
        return self.get_translate_file_job_result_with_options(request, headers, runtime)

    async def get_translate_file_job_result_async(
        self,
        request: dingtalkcontact__1__0_models.GetTranslateFileJobResultRequest,
    ) -> dingtalkcontact__1__0_models.GetTranslateFileJobResultResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.GetTranslateFileJobResultHeaders()
        return await self.get_translate_file_job_result_with_options_async(request, headers, runtime)

    def get_translate_file_job_result_with_options(
        self,
        request: dingtalkcontact__1__0_models.GetTranslateFileJobResultRequest,
        headers: dingtalkcontact__1__0_models.GetTranslateFileJobResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.GetTranslateFileJobResultResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.job_id):
            query['jobId'] = request.job_id
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
            dingtalkcontact__1__0_models.GetTranslateFileJobResultResponse(),
            self.do_roarequest('GetTranslateFileJobResult', 'contact_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/contact/files/translateResults', 'json', req, runtime)
        )

    async def get_translate_file_job_result_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.GetTranslateFileJobResultRequest,
        headers: dingtalkcontact__1__0_models.GetTranslateFileJobResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.GetTranslateFileJobResultResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.job_id):
            query['jobId'] = request.job_id
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
            dingtalkcontact__1__0_models.GetTranslateFileJobResultResponse(),
            await self.do_roarequest_async('GetTranslateFileJobResult', 'contact_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/contact/files/translateResults', 'json', req, runtime)
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
        user_id = OpenApiUtilClient.get_encode_param(user_id)
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
        user_id = OpenApiUtilClient.get_encode_param(user_id)
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
        user_id = OpenApiUtilClient.get_encode_param(user_id)
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
        user_id = OpenApiUtilClient.get_encode_param(user_id)
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

    def get_migration_union_id_by_union_id(
        self,
        request: dingtalkcontact__1__0_models.GetMigrationUnionIdByUnionIdRequest,
    ) -> dingtalkcontact__1__0_models.GetMigrationUnionIdByUnionIdResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.GetMigrationUnionIdByUnionIdHeaders()
        return self.get_migration_union_id_by_union_id_with_options(request, headers, runtime)

    async def get_migration_union_id_by_union_id_async(
        self,
        request: dingtalkcontact__1__0_models.GetMigrationUnionIdByUnionIdRequest,
    ) -> dingtalkcontact__1__0_models.GetMigrationUnionIdByUnionIdResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.GetMigrationUnionIdByUnionIdHeaders()
        return await self.get_migration_union_id_by_union_id_with_options_async(request, headers, runtime)

    def get_migration_union_id_by_union_id_with_options(
        self,
        request: dingtalkcontact__1__0_models.GetMigrationUnionIdByUnionIdRequest,
        headers: dingtalkcontact__1__0_models.GetMigrationUnionIdByUnionIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.GetMigrationUnionIdByUnionIdResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
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
            dingtalkcontact__1__0_models.GetMigrationUnionIdByUnionIdResponse(),
            self.do_roarequest('GetMigrationUnionIdByUnionId', 'contact_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/contact/orgAccount/getMigrationUnionIdByUnionIds', 'json', req, runtime)
        )

    async def get_migration_union_id_by_union_id_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.GetMigrationUnionIdByUnionIdRequest,
        headers: dingtalkcontact__1__0_models.GetMigrationUnionIdByUnionIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.GetMigrationUnionIdByUnionIdResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
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
            dingtalkcontact__1__0_models.GetMigrationUnionIdByUnionIdResponse(),
            await self.do_roarequest_async('GetMigrationUnionIdByUnionId', 'contact_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/contact/orgAccount/getMigrationUnionIdByUnionIds', 'json', req, runtime)
        )

    def get_ding_id_by_migration_ding_id(
        self,
        request: dingtalkcontact__1__0_models.GetDingIdByMigrationDingIdRequest,
    ) -> dingtalkcontact__1__0_models.GetDingIdByMigrationDingIdResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.GetDingIdByMigrationDingIdHeaders()
        return self.get_ding_id_by_migration_ding_id_with_options(request, headers, runtime)

    async def get_ding_id_by_migration_ding_id_async(
        self,
        request: dingtalkcontact__1__0_models.GetDingIdByMigrationDingIdRequest,
    ) -> dingtalkcontact__1__0_models.GetDingIdByMigrationDingIdResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.GetDingIdByMigrationDingIdHeaders()
        return await self.get_ding_id_by_migration_ding_id_with_options_async(request, headers, runtime)

    def get_ding_id_by_migration_ding_id_with_options(
        self,
        request: dingtalkcontact__1__0_models.GetDingIdByMigrationDingIdRequest,
        headers: dingtalkcontact__1__0_models.GetDingIdByMigrationDingIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.GetDingIdByMigrationDingIdResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.migration_ding_id):
            query['migrationDingId'] = request.migration_ding_id
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
            dingtalkcontact__1__0_models.GetDingIdByMigrationDingIdResponse(),
            self.do_roarequest('GetDingIdByMigrationDingId', 'contact_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/contact/orgAccount/getDingIdByMigrationDingIds', 'json', req, runtime)
        )

    async def get_ding_id_by_migration_ding_id_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.GetDingIdByMigrationDingIdRequest,
        headers: dingtalkcontact__1__0_models.GetDingIdByMigrationDingIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.GetDingIdByMigrationDingIdResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.migration_ding_id):
            query['migrationDingId'] = request.migration_ding_id
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
            dingtalkcontact__1__0_models.GetDingIdByMigrationDingIdResponse(),
            await self.do_roarequest_async('GetDingIdByMigrationDingId', 'contact_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/contact/orgAccount/getDingIdByMigrationDingIds', 'json', req, runtime)
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
        cooperate_corp_id = OpenApiUtilClient.get_encode_param(cooperate_corp_id)
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
        cooperate_corp_id = OpenApiUtilClient.get_encode_param(cooperate_corp_id)
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
        group_id = OpenApiUtilClient.get_encode_param(group_id)
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
        group_id = OpenApiUtilClient.get_encode_param(group_id)
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
        union_id = OpenApiUtilClient.get_encode_param(union_id)
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
        union_id = OpenApiUtilClient.get_encode_param(union_id)
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
        resource_id = OpenApiUtilClient.get_encode_param(resource_id)
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
        resource_id = OpenApiUtilClient.get_encode_param(resource_id)
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

    def translate_file(
        self,
        request: dingtalkcontact__1__0_models.TranslateFileRequest,
    ) -> dingtalkcontact__1__0_models.TranslateFileResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.TranslateFileHeaders()
        return self.translate_file_with_options(request, headers, runtime)

    async def translate_file_async(
        self,
        request: dingtalkcontact__1__0_models.TranslateFileRequest,
    ) -> dingtalkcontact__1__0_models.TranslateFileResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.TranslateFileHeaders()
        return await self.translate_file_with_options_async(request, headers, runtime)

    def translate_file_with_options(
        self,
        request: dingtalkcontact__1__0_models.TranslateFileRequest,
        headers: dingtalkcontact__1__0_models.TranslateFileHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.TranslateFileResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.ding_token_grant_type):
            body['dingTokenGrantType'] = request.ding_token_grant_type
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
        if not UtilClient.is_unset(request.ding_suite_key):
            body['dingSuiteKey'] = request.ding_suite_key
        if not UtilClient.is_unset(request.media_id):
            body['mediaId'] = request.media_id
        if not UtilClient.is_unset(request.output_file_name):
            body['outputFileName'] = request.output_file_name
        if not UtilClient.is_unset(request.union_id):
            body['unionId'] = request.union_id
        if not UtilClient.is_unset(request.request_id):
            body['RequestId'] = request.request_id
        if not UtilClient.is_unset(request.eagle_eye_trace_id):
            body['eagleEyeTraceId'] = request.eagle_eye_trace_id
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
            dingtalkcontact__1__0_models.TranslateFileResponse(),
            self.do_roarequest('TranslateFile', 'contact_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/contact/files/translate', 'json', req, runtime)
        )

    async def translate_file_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.TranslateFileRequest,
        headers: dingtalkcontact__1__0_models.TranslateFileHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.TranslateFileResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.ding_token_grant_type):
            body['dingTokenGrantType'] = request.ding_token_grant_type
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
        if not UtilClient.is_unset(request.ding_suite_key):
            body['dingSuiteKey'] = request.ding_suite_key
        if not UtilClient.is_unset(request.media_id):
            body['mediaId'] = request.media_id
        if not UtilClient.is_unset(request.output_file_name):
            body['outputFileName'] = request.output_file_name
        if not UtilClient.is_unset(request.union_id):
            body['unionId'] = request.union_id
        if not UtilClient.is_unset(request.request_id):
            body['RequestId'] = request.request_id
        if not UtilClient.is_unset(request.eagle_eye_trace_id):
            body['eagleEyeTraceId'] = request.eagle_eye_trace_id
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
            dingtalkcontact__1__0_models.TranslateFileResponse(),
            await self.do_roarequest_async('TranslateFile', 'contact_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/contact/files/translate', 'json', req, runtime)
        )

    def update_senior_setting(
        self,
        request: dingtalkcontact__1__0_models.UpdateSeniorSettingRequest,
    ) -> dingtalkcontact__1__0_models.UpdateSeniorSettingResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.UpdateSeniorSettingHeaders()
        return self.update_senior_setting_with_options(request, headers, runtime)

    async def update_senior_setting_async(
        self,
        request: dingtalkcontact__1__0_models.UpdateSeniorSettingRequest,
    ) -> dingtalkcontact__1__0_models.UpdateSeniorSettingResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.UpdateSeniorSettingHeaders()
        return await self.update_senior_setting_with_options_async(request, headers, runtime)

    def update_senior_setting_with_options(
        self,
        request: dingtalkcontact__1__0_models.UpdateSeniorSettingRequest,
        headers: dingtalkcontact__1__0_models.UpdateSeniorSettingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.UpdateSeniorSettingResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.senior_staff_id):
            body['seniorStaffId'] = request.senior_staff_id
        if not UtilClient.is_unset(request.open):
            body['open'] = request.open
        if not UtilClient.is_unset(request.permit_staff_ids):
            body['permitStaffIds'] = request.permit_staff_ids
        if not UtilClient.is_unset(request.permit_dept_ids):
            body['permitDeptIds'] = request.permit_dept_ids
        if not UtilClient.is_unset(request.permit_tag_ids):
            body['permitTagIds'] = request.permit_tag_ids
        if not UtilClient.is_unset(request.protect_scenes):
            body['protectScenes'] = request.protect_scenes
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
            dingtalkcontact__1__0_models.UpdateSeniorSettingResponse(),
            self.do_roarequest('UpdateSeniorSetting', 'contact_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/contact/seniorSettings', 'none', req, runtime)
        )

    async def update_senior_setting_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.UpdateSeniorSettingRequest,
        headers: dingtalkcontact__1__0_models.UpdateSeniorSettingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.UpdateSeniorSettingResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.senior_staff_id):
            body['seniorStaffId'] = request.senior_staff_id
        if not UtilClient.is_unset(request.open):
            body['open'] = request.open
        if not UtilClient.is_unset(request.permit_staff_ids):
            body['permitStaffIds'] = request.permit_staff_ids
        if not UtilClient.is_unset(request.permit_dept_ids):
            body['permitDeptIds'] = request.permit_dept_ids
        if not UtilClient.is_unset(request.permit_tag_ids):
            body['permitTagIds'] = request.permit_tag_ids
        if not UtilClient.is_unset(request.protect_scenes):
            body['protectScenes'] = request.protect_scenes
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
            dingtalkcontact__1__0_models.UpdateSeniorSettingResponse(),
            await self.do_roarequest_async('UpdateSeniorSetting', 'contact_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/contact/seniorSettings', 'none', req, runtime)
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

    def get_migration_ding_id_by_ding_id(
        self,
        request: dingtalkcontact__1__0_models.GetMigrationDingIdByDingIdRequest,
    ) -> dingtalkcontact__1__0_models.GetMigrationDingIdByDingIdResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.GetMigrationDingIdByDingIdHeaders()
        return self.get_migration_ding_id_by_ding_id_with_options(request, headers, runtime)

    async def get_migration_ding_id_by_ding_id_async(
        self,
        request: dingtalkcontact__1__0_models.GetMigrationDingIdByDingIdRequest,
    ) -> dingtalkcontact__1__0_models.GetMigrationDingIdByDingIdResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.GetMigrationDingIdByDingIdHeaders()
        return await self.get_migration_ding_id_by_ding_id_with_options_async(request, headers, runtime)

    def get_migration_ding_id_by_ding_id_with_options(
        self,
        request: dingtalkcontact__1__0_models.GetMigrationDingIdByDingIdRequest,
        headers: dingtalkcontact__1__0_models.GetMigrationDingIdByDingIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.GetMigrationDingIdByDingIdResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.ding_id):
            query['dingId'] = request.ding_id
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
            dingtalkcontact__1__0_models.GetMigrationDingIdByDingIdResponse(),
            self.do_roarequest('GetMigrationDingIdByDingId', 'contact_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/contact/orgAccount/getMigrationDingIdByDingIds', 'json', req, runtime)
        )

    async def get_migration_ding_id_by_ding_id_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.GetMigrationDingIdByDingIdRequest,
        headers: dingtalkcontact__1__0_models.GetMigrationDingIdByDingIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.GetMigrationDingIdByDingIdResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.ding_id):
            query['dingId'] = request.ding_id
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
            dingtalkcontact__1__0_models.GetMigrationDingIdByDingIdResponse(),
            await self.do_roarequest_async('GetMigrationDingIdByDingId', 'contact_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/contact/orgAccount/getMigrationDingIdByDingIds', 'json', req, runtime)
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
        group_id = OpenApiUtilClient.get_encode_param(group_id)
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
        group_id = OpenApiUtilClient.get_encode_param(group_id)
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

    def transform_to_exclusive_account(
        self,
        request: dingtalkcontact__1__0_models.TransformToExclusiveAccountRequest,
    ) -> dingtalkcontact__1__0_models.TransformToExclusiveAccountResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.TransformToExclusiveAccountHeaders()
        return self.transform_to_exclusive_account_with_options(request, headers, runtime)

    async def transform_to_exclusive_account_async(
        self,
        request: dingtalkcontact__1__0_models.TransformToExclusiveAccountRequest,
    ) -> dingtalkcontact__1__0_models.TransformToExclusiveAccountResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.TransformToExclusiveAccountHeaders()
        return await self.transform_to_exclusive_account_with_options_async(request, headers, runtime)

    def transform_to_exclusive_account_with_options(
        self,
        request: dingtalkcontact__1__0_models.TransformToExclusiveAccountRequest,
        headers: dingtalkcontact__1__0_models.TransformToExclusiveAccountHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.TransformToExclusiveAccountResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.transform_type):
            body['transformType'] = request.transform_type
        if not UtilClient.is_unset(request.idp_ding_talk):
            body['idpDingTalk'] = request.idp_ding_talk
        if not UtilClient.is_unset(request.login_id):
            body['loginId'] = request.login_id
        if not UtilClient.is_unset(request.init_password):
            body['initPassword'] = request.init_password
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            dingtalkcontact__1__0_models.TransformToExclusiveAccountResponse(),
            self.do_roarequest('TransformToExclusiveAccount', 'contact_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/contact/orgAccount/transformToExclusiveAccounts', 'none', req, runtime)
        )

    async def transform_to_exclusive_account_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.TransformToExclusiveAccountRequest,
        headers: dingtalkcontact__1__0_models.TransformToExclusiveAccountHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.TransformToExclusiveAccountResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.transform_type):
            body['transformType'] = request.transform_type
        if not UtilClient.is_unset(request.idp_ding_talk):
            body['idpDingTalk'] = request.idp_ding_talk
        if not UtilClient.is_unset(request.login_id):
            body['loginId'] = request.login_id
        if not UtilClient.is_unset(request.init_password):
            body['initPassword'] = request.init_password
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            dingtalkcontact__1__0_models.TransformToExclusiveAccountResponse(),
            await self.do_roarequest_async('TransformToExclusiveAccount', 'contact_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/contact/orgAccount/transformToExclusiveAccounts', 'none', req, runtime)
        )

    def get_union_id_by_migration_union_id(
        self,
        request: dingtalkcontact__1__0_models.GetUnionIdByMigrationUnionIdRequest,
    ) -> dingtalkcontact__1__0_models.GetUnionIdByMigrationUnionIdResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.GetUnionIdByMigrationUnionIdHeaders()
        return self.get_union_id_by_migration_union_id_with_options(request, headers, runtime)

    async def get_union_id_by_migration_union_id_async(
        self,
        request: dingtalkcontact__1__0_models.GetUnionIdByMigrationUnionIdRequest,
    ) -> dingtalkcontact__1__0_models.GetUnionIdByMigrationUnionIdResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.GetUnionIdByMigrationUnionIdHeaders()
        return await self.get_union_id_by_migration_union_id_with_options_async(request, headers, runtime)

    def get_union_id_by_migration_union_id_with_options(
        self,
        request: dingtalkcontact__1__0_models.GetUnionIdByMigrationUnionIdRequest,
        headers: dingtalkcontact__1__0_models.GetUnionIdByMigrationUnionIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.GetUnionIdByMigrationUnionIdResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.migration_union_id):
            query['migrationUnionId'] = request.migration_union_id
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
            dingtalkcontact__1__0_models.GetUnionIdByMigrationUnionIdResponse(),
            self.do_roarequest('GetUnionIdByMigrationUnionId', 'contact_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/contact/orgAccount/getUnionIdByMigrationUnionIds', 'json', req, runtime)
        )

    async def get_union_id_by_migration_union_id_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.GetUnionIdByMigrationUnionIdRequest,
        headers: dingtalkcontact__1__0_models.GetUnionIdByMigrationUnionIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.GetUnionIdByMigrationUnionIdResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.migration_union_id):
            query['migrationUnionId'] = request.migration_union_id
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
            dingtalkcontact__1__0_models.GetUnionIdByMigrationUnionIdResponse(),
            await self.do_roarequest_async('GetUnionIdByMigrationUnionId', 'contact_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/contact/orgAccount/getUnionIdByMigrationUnionIds', 'json', req, runtime)
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
