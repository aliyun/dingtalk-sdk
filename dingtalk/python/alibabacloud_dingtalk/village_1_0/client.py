# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_gateway_spi.client import Client as SPIClient
from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.village_1_0 import models as dingtalkvillage__1__0_models
from alibabacloud_tea_util import models as util_models
from alibabacloud_openapi_util.client import Client as OpenApiUtilClient


class Client(OpenApiClient):
    """
    *\
    """
    _client: SPIClient = None

    def __init__(
        self, 
        config: open_api_models.Config,
    ):
        super().__init__(config)
        self._client = GatewayClientClient()
        self._spi = self._client
        self._endpoint_rule = ''
        if UtilClient.empty(self._endpoint):
            self._endpoint = 'api.dingtalk.com'

    def get_dept_with_options(
        self,
        department_id: str,
        request: dingtalkvillage__1__0_models.GetDeptRequest,
        headers: dingtalkvillage__1__0_models.GetDeptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkvillage__1__0_models.GetDeptResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.sub_corp_id):
            query['subCorpId'] = request.sub_corp_id
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
            action='GetDept',
            version='village_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/village/deptartments/{department_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkvillage__1__0_models.GetDeptResponse(),
            self.execute(params, req, runtime)
        )

    async def get_dept_with_options_async(
        self,
        department_id: str,
        request: dingtalkvillage__1__0_models.GetDeptRequest,
        headers: dingtalkvillage__1__0_models.GetDeptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkvillage__1__0_models.GetDeptResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.sub_corp_id):
            query['subCorpId'] = request.sub_corp_id
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
            action='GetDept',
            version='village_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/village/deptartments/{department_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkvillage__1__0_models.GetDeptResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_dept(
        self,
        department_id: str,
        request: dingtalkvillage__1__0_models.GetDeptRequest,
    ) -> dingtalkvillage__1__0_models.GetDeptResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkvillage__1__0_models.GetDeptHeaders()
        return self.get_dept_with_options(department_id, request, headers, runtime)

    async def get_dept_async(
        self,
        department_id: str,
        request: dingtalkvillage__1__0_models.GetDeptRequest,
    ) -> dingtalkvillage__1__0_models.GetDeptResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkvillage__1__0_models.GetDeptHeaders()
        return await self.get_dept_with_options_async(department_id, request, headers, runtime)

    def get_resident_dept_with_options(
        self,
        department_id: str,
        request: dingtalkvillage__1__0_models.GetResidentDeptRequest,
        headers: dingtalkvillage__1__0_models.GetResidentDeptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkvillage__1__0_models.GetResidentDeptResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.sub_corp_id):
            query['subCorpId'] = request.sub_corp_id
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
            action='GetResidentDept',
            version='village_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/village/residentDepartments/departments/{department_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkvillage__1__0_models.GetResidentDeptResponse(),
            self.execute(params, req, runtime)
        )

    async def get_resident_dept_with_options_async(
        self,
        department_id: str,
        request: dingtalkvillage__1__0_models.GetResidentDeptRequest,
        headers: dingtalkvillage__1__0_models.GetResidentDeptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkvillage__1__0_models.GetResidentDeptResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.sub_corp_id):
            query['subCorpId'] = request.sub_corp_id
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
            action='GetResidentDept',
            version='village_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/village/residentDepartments/departments/{department_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkvillage__1__0_models.GetResidentDeptResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_resident_dept(
        self,
        department_id: str,
        request: dingtalkvillage__1__0_models.GetResidentDeptRequest,
    ) -> dingtalkvillage__1__0_models.GetResidentDeptResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkvillage__1__0_models.GetResidentDeptHeaders()
        return self.get_resident_dept_with_options(department_id, request, headers, runtime)

    async def get_resident_dept_async(
        self,
        department_id: str,
        request: dingtalkvillage__1__0_models.GetResidentDeptRequest,
    ) -> dingtalkvillage__1__0_models.GetResidentDeptResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkvillage__1__0_models.GetResidentDeptHeaders()
        return await self.get_resident_dept_with_options_async(department_id, request, headers, runtime)

    def get_resident_user_info_with_options(
        self,
        department_id: str,
        user_id: str,
        request: dingtalkvillage__1__0_models.GetResidentUserInfoRequest,
        headers: dingtalkvillage__1__0_models.GetResidentUserInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkvillage__1__0_models.GetResidentUserInfoResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.sub_corp_id):
            query['subCorpId'] = request.sub_corp_id
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
            action='GetResidentUserInfo',
            version='village_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/village/residentDepartments/{department_id}/users/{user_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkvillage__1__0_models.GetResidentUserInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def get_resident_user_info_with_options_async(
        self,
        department_id: str,
        user_id: str,
        request: dingtalkvillage__1__0_models.GetResidentUserInfoRequest,
        headers: dingtalkvillage__1__0_models.GetResidentUserInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkvillage__1__0_models.GetResidentUserInfoResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.sub_corp_id):
            query['subCorpId'] = request.sub_corp_id
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
            action='GetResidentUserInfo',
            version='village_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/village/residentDepartments/{department_id}/users/{user_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkvillage__1__0_models.GetResidentUserInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_resident_user_info(
        self,
        department_id: str,
        user_id: str,
        request: dingtalkvillage__1__0_models.GetResidentUserInfoRequest,
    ) -> dingtalkvillage__1__0_models.GetResidentUserInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkvillage__1__0_models.GetResidentUserInfoHeaders()
        return self.get_resident_user_info_with_options(department_id, user_id, request, headers, runtime)

    async def get_resident_user_info_async(
        self,
        department_id: str,
        user_id: str,
        request: dingtalkvillage__1__0_models.GetResidentUserInfoRequest,
    ) -> dingtalkvillage__1__0_models.GetResidentUserInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkvillage__1__0_models.GetResidentUserInfoHeaders()
        return await self.get_resident_user_info_with_options_async(department_id, user_id, request, headers, runtime)

    def get_user_with_options(
        self,
        user_id: str,
        request: dingtalkvillage__1__0_models.GetUserRequest,
        headers: dingtalkvillage__1__0_models.GetUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkvillage__1__0_models.GetUserResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.sub_corp_id):
            query['subCorpId'] = request.sub_corp_id
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
            action='GetUser',
            version='village_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/village/users/getByUserId',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkvillage__1__0_models.GetUserResponse(),
            self.execute(params, req, runtime)
        )

    async def get_user_with_options_async(
        self,
        user_id: str,
        request: dingtalkvillage__1__0_models.GetUserRequest,
        headers: dingtalkvillage__1__0_models.GetUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkvillage__1__0_models.GetUserResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.sub_corp_id):
            query['subCorpId'] = request.sub_corp_id
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
            action='GetUser',
            version='village_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/village/users/getByUserId',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkvillage__1__0_models.GetUserResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_user(
        self,
        user_id: str,
        request: dingtalkvillage__1__0_models.GetUserRequest,
    ) -> dingtalkvillage__1__0_models.GetUserResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkvillage__1__0_models.GetUserHeaders()
        return self.get_user_with_options(user_id, request, headers, runtime)

    async def get_user_async(
        self,
        user_id: str,
        request: dingtalkvillage__1__0_models.GetUserRequest,
    ) -> dingtalkvillage__1__0_models.GetUserResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkvillage__1__0_models.GetUserHeaders()
        return await self.get_user_with_options_async(user_id, request, headers, runtime)

    def get_user_by_union_id_with_options(
        self,
        request: dingtalkvillage__1__0_models.GetUserByUnionIdRequest,
        headers: dingtalkvillage__1__0_models.GetUserByUnionIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkvillage__1__0_models.GetUserByUnionIdResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.sub_corp_id):
            query['subCorpId'] = request.sub_corp_id
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
            action='GetUserByUnionId',
            version='village_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/village/users/getByUnionId',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkvillage__1__0_models.GetUserByUnionIdResponse(),
            self.execute(params, req, runtime)
        )

    async def get_user_by_union_id_with_options_async(
        self,
        request: dingtalkvillage__1__0_models.GetUserByUnionIdRequest,
        headers: dingtalkvillage__1__0_models.GetUserByUnionIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkvillage__1__0_models.GetUserByUnionIdResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.sub_corp_id):
            query['subCorpId'] = request.sub_corp_id
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
            action='GetUserByUnionId',
            version='village_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/village/users/getByUnionId',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkvillage__1__0_models.GetUserByUnionIdResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_user_by_union_id(
        self,
        request: dingtalkvillage__1__0_models.GetUserByUnionIdRequest,
    ) -> dingtalkvillage__1__0_models.GetUserByUnionIdResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkvillage__1__0_models.GetUserByUnionIdHeaders()
        return self.get_user_by_union_id_with_options(request, headers, runtime)

    async def get_user_by_union_id_async(
        self,
        request: dingtalkvillage__1__0_models.GetUserByUnionIdRequest,
    ) -> dingtalkvillage__1__0_models.GetUserByUnionIdResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkvillage__1__0_models.GetUserByUnionIdHeaders()
        return await self.get_user_by_union_id_with_options_async(request, headers, runtime)

    def get_village_org_info_with_options(
        self,
        sub_corp_id: str,
        headers: dingtalkvillage__1__0_models.GetVillageOrgInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkvillage__1__0_models.GetVillageOrgInfoResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetVillageOrgInfo',
            version='village_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/village/corps/{sub_corp_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkvillage__1__0_models.GetVillageOrgInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def get_village_org_info_with_options_async(
        self,
        sub_corp_id: str,
        headers: dingtalkvillage__1__0_models.GetVillageOrgInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkvillage__1__0_models.GetVillageOrgInfoResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetVillageOrgInfo',
            version='village_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/village/corps/{sub_corp_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkvillage__1__0_models.GetVillageOrgInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_village_org_info(
        self,
        sub_corp_id: str,
    ) -> dingtalkvillage__1__0_models.GetVillageOrgInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkvillage__1__0_models.GetVillageOrgInfoHeaders()
        return self.get_village_org_info_with_options(sub_corp_id, headers, runtime)

    async def get_village_org_info_async(
        self,
        sub_corp_id: str,
    ) -> dingtalkvillage__1__0_models.GetVillageOrgInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkvillage__1__0_models.GetVillageOrgInfoHeaders()
        return await self.get_village_org_info_with_options_async(sub_corp_id, headers, runtime)

    def list_dept_simple_users_with_options(
        self,
        department_id: str,
        request: dingtalkvillage__1__0_models.ListDeptSimpleUsersRequest,
        headers: dingtalkvillage__1__0_models.ListDeptSimpleUsersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkvillage__1__0_models.ListDeptSimpleUsersResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.contain_access_limit):
            query['containAccessLimit'] = request.contain_access_limit
        if not UtilClient.is_unset(request.cursor):
            query['cursor'] = request.cursor
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.order_field):
            query['orderField'] = request.order_field
        if not UtilClient.is_unset(request.size):
            query['size'] = request.size
        if not UtilClient.is_unset(request.sub_corp_id):
            query['subCorpId'] = request.sub_corp_id
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
            action='ListDeptSimpleUsers',
            version='village_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/village/departments/{department_id}/simpleUsers',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkvillage__1__0_models.ListDeptSimpleUsersResponse(),
            self.execute(params, req, runtime)
        )

    async def list_dept_simple_users_with_options_async(
        self,
        department_id: str,
        request: dingtalkvillage__1__0_models.ListDeptSimpleUsersRequest,
        headers: dingtalkvillage__1__0_models.ListDeptSimpleUsersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkvillage__1__0_models.ListDeptSimpleUsersResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.contain_access_limit):
            query['containAccessLimit'] = request.contain_access_limit
        if not UtilClient.is_unset(request.cursor):
            query['cursor'] = request.cursor
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.order_field):
            query['orderField'] = request.order_field
        if not UtilClient.is_unset(request.size):
            query['size'] = request.size
        if not UtilClient.is_unset(request.sub_corp_id):
            query['subCorpId'] = request.sub_corp_id
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
            action='ListDeptSimpleUsers',
            version='village_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/village/departments/{department_id}/simpleUsers',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkvillage__1__0_models.ListDeptSimpleUsersResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_dept_simple_users(
        self,
        department_id: str,
        request: dingtalkvillage__1__0_models.ListDeptSimpleUsersRequest,
    ) -> dingtalkvillage__1__0_models.ListDeptSimpleUsersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkvillage__1__0_models.ListDeptSimpleUsersHeaders()
        return self.list_dept_simple_users_with_options(department_id, request, headers, runtime)

    async def list_dept_simple_users_async(
        self,
        department_id: str,
        request: dingtalkvillage__1__0_models.ListDeptSimpleUsersRequest,
    ) -> dingtalkvillage__1__0_models.ListDeptSimpleUsersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkvillage__1__0_models.ListDeptSimpleUsersHeaders()
        return await self.list_dept_simple_users_with_options_async(department_id, request, headers, runtime)

    def list_dept_user_ids_with_options(
        self,
        department_id: str,
        request: dingtalkvillage__1__0_models.ListDeptUserIdsRequest,
        headers: dingtalkvillage__1__0_models.ListDeptUserIdsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkvillage__1__0_models.ListDeptUserIdsResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.sub_corp_id):
            query['subCorpId'] = request.sub_corp_id
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
            action='ListDeptUserIds',
            version='village_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/village/departments/{department_id}/userIds',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkvillage__1__0_models.ListDeptUserIdsResponse(),
            self.execute(params, req, runtime)
        )

    async def list_dept_user_ids_with_options_async(
        self,
        department_id: str,
        request: dingtalkvillage__1__0_models.ListDeptUserIdsRequest,
        headers: dingtalkvillage__1__0_models.ListDeptUserIdsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkvillage__1__0_models.ListDeptUserIdsResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.sub_corp_id):
            query['subCorpId'] = request.sub_corp_id
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
            action='ListDeptUserIds',
            version='village_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/village/departments/{department_id}/userIds',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkvillage__1__0_models.ListDeptUserIdsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_dept_user_ids(
        self,
        department_id: str,
        request: dingtalkvillage__1__0_models.ListDeptUserIdsRequest,
    ) -> dingtalkvillage__1__0_models.ListDeptUserIdsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkvillage__1__0_models.ListDeptUserIdsHeaders()
        return self.list_dept_user_ids_with_options(department_id, request, headers, runtime)

    async def list_dept_user_ids_async(
        self,
        department_id: str,
        request: dingtalkvillage__1__0_models.ListDeptUserIdsRequest,
    ) -> dingtalkvillage__1__0_models.ListDeptUserIdsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkvillage__1__0_models.ListDeptUserIdsHeaders()
        return await self.list_dept_user_ids_with_options_async(department_id, request, headers, runtime)

    def list_dept_users_with_options(
        self,
        department_id: str,
        request: dingtalkvillage__1__0_models.ListDeptUsersRequest,
        headers: dingtalkvillage__1__0_models.ListDeptUsersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkvillage__1__0_models.ListDeptUsersResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.contain_access_limit):
            query['containAccessLimit'] = request.contain_access_limit
        if not UtilClient.is_unset(request.cursor):
            query['cursor'] = request.cursor
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.order_field):
            query['orderField'] = request.order_field
        if not UtilClient.is_unset(request.size):
            query['size'] = request.size
        if not UtilClient.is_unset(request.sub_corp_id):
            query['subCorpId'] = request.sub_corp_id
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
            action='ListDeptUsers',
            version='village_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/village/departments/{department_id}/users',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkvillage__1__0_models.ListDeptUsersResponse(),
            self.execute(params, req, runtime)
        )

    async def list_dept_users_with_options_async(
        self,
        department_id: str,
        request: dingtalkvillage__1__0_models.ListDeptUsersRequest,
        headers: dingtalkvillage__1__0_models.ListDeptUsersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkvillage__1__0_models.ListDeptUsersResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.contain_access_limit):
            query['containAccessLimit'] = request.contain_access_limit
        if not UtilClient.is_unset(request.cursor):
            query['cursor'] = request.cursor
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.order_field):
            query['orderField'] = request.order_field
        if not UtilClient.is_unset(request.size):
            query['size'] = request.size
        if not UtilClient.is_unset(request.sub_corp_id):
            query['subCorpId'] = request.sub_corp_id
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
            action='ListDeptUsers',
            version='village_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/village/departments/{department_id}/users',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkvillage__1__0_models.ListDeptUsersResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_dept_users(
        self,
        department_id: str,
        request: dingtalkvillage__1__0_models.ListDeptUsersRequest,
    ) -> dingtalkvillage__1__0_models.ListDeptUsersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkvillage__1__0_models.ListDeptUsersHeaders()
        return self.list_dept_users_with_options(department_id, request, headers, runtime)

    async def list_dept_users_async(
        self,
        department_id: str,
        request: dingtalkvillage__1__0_models.ListDeptUsersRequest,
    ) -> dingtalkvillage__1__0_models.ListDeptUsersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkvillage__1__0_models.ListDeptUsersHeaders()
        return await self.list_dept_users_with_options_async(department_id, request, headers, runtime)

    def list_parent_by_dept_with_options(
        self,
        request: dingtalkvillage__1__0_models.ListParentByDeptRequest,
        headers: dingtalkvillage__1__0_models.ListParentByDeptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkvillage__1__0_models.ListParentByDeptResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.department_id):
            query['departmentId'] = request.department_id
        if not UtilClient.is_unset(request.sub_corp_id):
            query['subCorpId'] = request.sub_corp_id
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
            action='ListParentByDept',
            version='village_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/village/departments/listParentByDepartment',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkvillage__1__0_models.ListParentByDeptResponse(),
            self.execute(params, req, runtime)
        )

    async def list_parent_by_dept_with_options_async(
        self,
        request: dingtalkvillage__1__0_models.ListParentByDeptRequest,
        headers: dingtalkvillage__1__0_models.ListParentByDeptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkvillage__1__0_models.ListParentByDeptResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.department_id):
            query['departmentId'] = request.department_id
        if not UtilClient.is_unset(request.sub_corp_id):
            query['subCorpId'] = request.sub_corp_id
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
            action='ListParentByDept',
            version='village_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/village/departments/listParentByDepartment',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkvillage__1__0_models.ListParentByDeptResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_parent_by_dept(
        self,
        request: dingtalkvillage__1__0_models.ListParentByDeptRequest,
    ) -> dingtalkvillage__1__0_models.ListParentByDeptResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkvillage__1__0_models.ListParentByDeptHeaders()
        return self.list_parent_by_dept_with_options(request, headers, runtime)

    async def list_parent_by_dept_async(
        self,
        request: dingtalkvillage__1__0_models.ListParentByDeptRequest,
    ) -> dingtalkvillage__1__0_models.ListParentByDeptResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkvillage__1__0_models.ListParentByDeptHeaders()
        return await self.list_parent_by_dept_with_options_async(request, headers, runtime)

    def list_parent_by_user_with_options(
        self,
        request: dingtalkvillage__1__0_models.ListParentByUserRequest,
        headers: dingtalkvillage__1__0_models.ListParentByUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkvillage__1__0_models.ListParentByUserResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.sub_corp_id):
            query['subCorpId'] = request.sub_corp_id
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
            action='ListParentByUser',
            version='village_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/village/departments/listParentByUser',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkvillage__1__0_models.ListParentByUserResponse(),
            self.execute(params, req, runtime)
        )

    async def list_parent_by_user_with_options_async(
        self,
        request: dingtalkvillage__1__0_models.ListParentByUserRequest,
        headers: dingtalkvillage__1__0_models.ListParentByUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkvillage__1__0_models.ListParentByUserResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.sub_corp_id):
            query['subCorpId'] = request.sub_corp_id
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
            action='ListParentByUser',
            version='village_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/village/departments/listParentByUser',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkvillage__1__0_models.ListParentByUserResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_parent_by_user(
        self,
        request: dingtalkvillage__1__0_models.ListParentByUserRequest,
    ) -> dingtalkvillage__1__0_models.ListParentByUserResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkvillage__1__0_models.ListParentByUserHeaders()
        return self.list_parent_by_user_with_options(request, headers, runtime)

    async def list_parent_by_user_async(
        self,
        request: dingtalkvillage__1__0_models.ListParentByUserRequest,
    ) -> dingtalkvillage__1__0_models.ListParentByUserResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkvillage__1__0_models.ListParentByUserHeaders()
        return await self.list_parent_by_user_with_options_async(request, headers, runtime)

    def list_resident_dept_users_with_options(
        self,
        department_id: str,
        request: dingtalkvillage__1__0_models.ListResidentDeptUsersRequest,
        headers: dingtalkvillage__1__0_models.ListResidentDeptUsersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkvillage__1__0_models.ListResidentDeptUsersResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.cursor):
            query['cursor'] = request.cursor
        if not UtilClient.is_unset(request.role):
            query['role'] = request.role
        if not UtilClient.is_unset(request.size):
            query['size'] = request.size
        if not UtilClient.is_unset(request.sub_corp_id):
            query['subCorpId'] = request.sub_corp_id
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
            action='ListResidentDeptUsers',
            version='village_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/village/residentDepartments/{department_id}/users',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkvillage__1__0_models.ListResidentDeptUsersResponse(),
            self.execute(params, req, runtime)
        )

    async def list_resident_dept_users_with_options_async(
        self,
        department_id: str,
        request: dingtalkvillage__1__0_models.ListResidentDeptUsersRequest,
        headers: dingtalkvillage__1__0_models.ListResidentDeptUsersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkvillage__1__0_models.ListResidentDeptUsersResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.cursor):
            query['cursor'] = request.cursor
        if not UtilClient.is_unset(request.role):
            query['role'] = request.role
        if not UtilClient.is_unset(request.size):
            query['size'] = request.size
        if not UtilClient.is_unset(request.sub_corp_id):
            query['subCorpId'] = request.sub_corp_id
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
            action='ListResidentDeptUsers',
            version='village_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/village/residentDepartments/{department_id}/users',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkvillage__1__0_models.ListResidentDeptUsersResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_resident_dept_users(
        self,
        department_id: str,
        request: dingtalkvillage__1__0_models.ListResidentDeptUsersRequest,
    ) -> dingtalkvillage__1__0_models.ListResidentDeptUsersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkvillage__1__0_models.ListResidentDeptUsersHeaders()
        return self.list_resident_dept_users_with_options(department_id, request, headers, runtime)

    async def list_resident_dept_users_async(
        self,
        department_id: str,
        request: dingtalkvillage__1__0_models.ListResidentDeptUsersRequest,
    ) -> dingtalkvillage__1__0_models.ListResidentDeptUsersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkvillage__1__0_models.ListResidentDeptUsersHeaders()
        return await self.list_resident_dept_users_with_options_async(department_id, request, headers, runtime)

    def list_resident_sub_depts_with_options(
        self,
        department_id: str,
        request: dingtalkvillage__1__0_models.ListResidentSubDeptsRequest,
        headers: dingtalkvillage__1__0_models.ListResidentSubDeptsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkvillage__1__0_models.ListResidentSubDeptsResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.cursor):
            query['cursor'] = request.cursor
        if not UtilClient.is_unset(request.size):
            query['size'] = request.size
        if not UtilClient.is_unset(request.sub_corp_id):
            query['subCorpId'] = request.sub_corp_id
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
            action='ListResidentSubDepts',
            version='village_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/village/residentDepartments/{department_id}/subDepartments',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkvillage__1__0_models.ListResidentSubDeptsResponse(),
            self.execute(params, req, runtime)
        )

    async def list_resident_sub_depts_with_options_async(
        self,
        department_id: str,
        request: dingtalkvillage__1__0_models.ListResidentSubDeptsRequest,
        headers: dingtalkvillage__1__0_models.ListResidentSubDeptsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkvillage__1__0_models.ListResidentSubDeptsResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.cursor):
            query['cursor'] = request.cursor
        if not UtilClient.is_unset(request.size):
            query['size'] = request.size
        if not UtilClient.is_unset(request.sub_corp_id):
            query['subCorpId'] = request.sub_corp_id
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
            action='ListResidentSubDepts',
            version='village_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/village/residentDepartments/{department_id}/subDepartments',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkvillage__1__0_models.ListResidentSubDeptsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_resident_sub_depts(
        self,
        department_id: str,
        request: dingtalkvillage__1__0_models.ListResidentSubDeptsRequest,
    ) -> dingtalkvillage__1__0_models.ListResidentSubDeptsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkvillage__1__0_models.ListResidentSubDeptsHeaders()
        return self.list_resident_sub_depts_with_options(department_id, request, headers, runtime)

    async def list_resident_sub_depts_async(
        self,
        department_id: str,
        request: dingtalkvillage__1__0_models.ListResidentSubDeptsRequest,
    ) -> dingtalkvillage__1__0_models.ListResidentSubDeptsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkvillage__1__0_models.ListResidentSubDeptsHeaders()
        return await self.list_resident_sub_depts_with_options_async(department_id, request, headers, runtime)

    def list_resident_user_infos_with_options(
        self,
        tmp_req: dingtalkvillage__1__0_models.ListResidentUserInfosRequest,
        headers: dingtalkvillage__1__0_models.ListResidentUserInfosHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkvillage__1__0_models.ListResidentUserInfosResponse:
        UtilClient.validate_model(tmp_req)
        request = dingtalkvillage__1__0_models.ListResidentUserInfosShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.user_ids):
            request.user_ids_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.user_ids, 'userIds', 'json')
        query = {}
        if not UtilClient.is_unset(request.sub_corp_id):
            query['subCorpId'] = request.sub_corp_id
        if not UtilClient.is_unset(request.user_ids_shrink):
            query['userIds'] = request.user_ids_shrink
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
            action='ListResidentUserInfos',
            version='village_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/village/residentUsers/getByUserIds',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkvillage__1__0_models.ListResidentUserInfosResponse(),
            self.execute(params, req, runtime)
        )

    async def list_resident_user_infos_with_options_async(
        self,
        tmp_req: dingtalkvillage__1__0_models.ListResidentUserInfosRequest,
        headers: dingtalkvillage__1__0_models.ListResidentUserInfosHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkvillage__1__0_models.ListResidentUserInfosResponse:
        UtilClient.validate_model(tmp_req)
        request = dingtalkvillage__1__0_models.ListResidentUserInfosShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.user_ids):
            request.user_ids_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.user_ids, 'userIds', 'json')
        query = {}
        if not UtilClient.is_unset(request.sub_corp_id):
            query['subCorpId'] = request.sub_corp_id
        if not UtilClient.is_unset(request.user_ids_shrink):
            query['userIds'] = request.user_ids_shrink
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
            action='ListResidentUserInfos',
            version='village_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/village/residentUsers/getByUserIds',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkvillage__1__0_models.ListResidentUserInfosResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_resident_user_infos(
        self,
        request: dingtalkvillage__1__0_models.ListResidentUserInfosRequest,
    ) -> dingtalkvillage__1__0_models.ListResidentUserInfosResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkvillage__1__0_models.ListResidentUserInfosHeaders()
        return self.list_resident_user_infos_with_options(request, headers, runtime)

    async def list_resident_user_infos_async(
        self,
        request: dingtalkvillage__1__0_models.ListResidentUserInfosRequest,
    ) -> dingtalkvillage__1__0_models.ListResidentUserInfosResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkvillage__1__0_models.ListResidentUserInfosHeaders()
        return await self.list_resident_user_infos_with_options_async(request, headers, runtime)

    def list_simple_users_by_role_with_options(
        self,
        request: dingtalkvillage__1__0_models.ListSimpleUsersByRoleRequest,
        headers: dingtalkvillage__1__0_models.ListSimpleUsersByRoleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkvillage__1__0_models.ListSimpleUsersByRoleResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.offset):
            query['offset'] = request.offset
        if not UtilClient.is_unset(request.role_id):
            query['roleId'] = request.role_id
        if not UtilClient.is_unset(request.size):
            query['size'] = request.size
        if not UtilClient.is_unset(request.sub_corp_id):
            query['subCorpId'] = request.sub_corp_id
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
            action='ListSimpleUsersByRole',
            version='village_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/village/users/listByRole',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkvillage__1__0_models.ListSimpleUsersByRoleResponse(),
            self.execute(params, req, runtime)
        )

    async def list_simple_users_by_role_with_options_async(
        self,
        request: dingtalkvillage__1__0_models.ListSimpleUsersByRoleRequest,
        headers: dingtalkvillage__1__0_models.ListSimpleUsersByRoleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkvillage__1__0_models.ListSimpleUsersByRoleResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.offset):
            query['offset'] = request.offset
        if not UtilClient.is_unset(request.role_id):
            query['roleId'] = request.role_id
        if not UtilClient.is_unset(request.size):
            query['size'] = request.size
        if not UtilClient.is_unset(request.sub_corp_id):
            query['subCorpId'] = request.sub_corp_id
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
            action='ListSimpleUsersByRole',
            version='village_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/village/users/listByRole',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkvillage__1__0_models.ListSimpleUsersByRoleResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_simple_users_by_role(
        self,
        request: dingtalkvillage__1__0_models.ListSimpleUsersByRoleRequest,
    ) -> dingtalkvillage__1__0_models.ListSimpleUsersByRoleResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkvillage__1__0_models.ListSimpleUsersByRoleHeaders()
        return self.list_simple_users_by_role_with_options(request, headers, runtime)

    async def list_simple_users_by_role_async(
        self,
        request: dingtalkvillage__1__0_models.ListSimpleUsersByRoleRequest,
    ) -> dingtalkvillage__1__0_models.ListSimpleUsersByRoleResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkvillage__1__0_models.ListSimpleUsersByRoleHeaders()
        return await self.list_simple_users_by_role_with_options_async(request, headers, runtime)

    def list_sub_corps_with_options(
        self,
        request: dingtalkvillage__1__0_models.ListSubCorpsRequest,
        headers: dingtalkvillage__1__0_models.ListSubCorpsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkvillage__1__0_models.ListSubCorpsResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.is_only_direct):
            query['isOnlyDirect'] = request.is_only_direct
        if not UtilClient.is_unset(request.sub_corp_id):
            query['subCorpId'] = request.sub_corp_id
        if not UtilClient.is_unset(request.types):
            query['types'] = request.types
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
            action='ListSubCorps',
            version='village_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/village/corps/subCorps',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkvillage__1__0_models.ListSubCorpsResponse(),
            self.execute(params, req, runtime)
        )

    async def list_sub_corps_with_options_async(
        self,
        request: dingtalkvillage__1__0_models.ListSubCorpsRequest,
        headers: dingtalkvillage__1__0_models.ListSubCorpsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkvillage__1__0_models.ListSubCorpsResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.is_only_direct):
            query['isOnlyDirect'] = request.is_only_direct
        if not UtilClient.is_unset(request.sub_corp_id):
            query['subCorpId'] = request.sub_corp_id
        if not UtilClient.is_unset(request.types):
            query['types'] = request.types
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
            action='ListSubCorps',
            version='village_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/village/corps/subCorps',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkvillage__1__0_models.ListSubCorpsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_sub_corps(
        self,
        request: dingtalkvillage__1__0_models.ListSubCorpsRequest,
    ) -> dingtalkvillage__1__0_models.ListSubCorpsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkvillage__1__0_models.ListSubCorpsHeaders()
        return self.list_sub_corps_with_options(request, headers, runtime)

    async def list_sub_corps_async(
        self,
        request: dingtalkvillage__1__0_models.ListSubCorpsRequest,
    ) -> dingtalkvillage__1__0_models.ListSubCorpsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkvillage__1__0_models.ListSubCorpsHeaders()
        return await self.list_sub_corps_with_options_async(request, headers, runtime)

    def list_sub_dept_with_options(
        self,
        department_id: str,
        request: dingtalkvillage__1__0_models.ListSubDeptRequest,
        headers: dingtalkvillage__1__0_models.ListSubDeptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkvillage__1__0_models.ListSubDeptResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.sub_corp_id):
            query['subCorpId'] = request.sub_corp_id
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
            action='ListSubDept',
            version='village_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/village/departments/{department_id}/subDepartments',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkvillage__1__0_models.ListSubDeptResponse(),
            self.execute(params, req, runtime)
        )

    async def list_sub_dept_with_options_async(
        self,
        department_id: str,
        request: dingtalkvillage__1__0_models.ListSubDeptRequest,
        headers: dingtalkvillage__1__0_models.ListSubDeptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkvillage__1__0_models.ListSubDeptResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.sub_corp_id):
            query['subCorpId'] = request.sub_corp_id
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
            action='ListSubDept',
            version='village_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/village/departments/{department_id}/subDepartments',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkvillage__1__0_models.ListSubDeptResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_sub_dept(
        self,
        department_id: str,
        request: dingtalkvillage__1__0_models.ListSubDeptRequest,
    ) -> dingtalkvillage__1__0_models.ListSubDeptResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkvillage__1__0_models.ListSubDeptHeaders()
        return self.list_sub_dept_with_options(department_id, request, headers, runtime)

    async def list_sub_dept_async(
        self,
        department_id: str,
        request: dingtalkvillage__1__0_models.ListSubDeptRequest,
    ) -> dingtalkvillage__1__0_models.ListSubDeptResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkvillage__1__0_models.ListSubDeptHeaders()
        return await self.list_sub_dept_with_options_async(department_id, request, headers, runtime)

    def list_sub_dept_ids_with_options(
        self,
        department_id: str,
        request: dingtalkvillage__1__0_models.ListSubDeptIdsRequest,
        headers: dingtalkvillage__1__0_models.ListSubDeptIdsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkvillage__1__0_models.ListSubDeptIdsResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.sub_corp_id):
            query['subCorpId'] = request.sub_corp_id
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
            action='ListSubDeptIds',
            version='village_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/village/departments/{department_id}/subDepartmentIds',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkvillage__1__0_models.ListSubDeptIdsResponse(),
            self.execute(params, req, runtime)
        )

    async def list_sub_dept_ids_with_options_async(
        self,
        department_id: str,
        request: dingtalkvillage__1__0_models.ListSubDeptIdsRequest,
        headers: dingtalkvillage__1__0_models.ListSubDeptIdsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkvillage__1__0_models.ListSubDeptIdsResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.sub_corp_id):
            query['subCorpId'] = request.sub_corp_id
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
            action='ListSubDeptIds',
            version='village_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/village/departments/{department_id}/subDepartmentIds',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkvillage__1__0_models.ListSubDeptIdsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_sub_dept_ids(
        self,
        department_id: str,
        request: dingtalkvillage__1__0_models.ListSubDeptIdsRequest,
    ) -> dingtalkvillage__1__0_models.ListSubDeptIdsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkvillage__1__0_models.ListSubDeptIdsHeaders()
        return self.list_sub_dept_ids_with_options(department_id, request, headers, runtime)

    async def list_sub_dept_ids_async(
        self,
        department_id: str,
        request: dingtalkvillage__1__0_models.ListSubDeptIdsRequest,
    ) -> dingtalkvillage__1__0_models.ListSubDeptIdsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkvillage__1__0_models.ListSubDeptIdsHeaders()
        return await self.list_sub_dept_ids_with_options_async(department_id, request, headers, runtime)
