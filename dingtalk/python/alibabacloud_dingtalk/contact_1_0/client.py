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
            body['body'] = request.body
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
            body['body'] = request.body
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
