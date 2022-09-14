# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.doc_2_0 import models as dingtalkdoc__2__0_models
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

    def copy_dentry(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkdoc__2__0_models.CopyDentryRequest,
    ) -> dingtalkdoc__2__0_models.CopyDentryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.CopyDentryHeaders()
        return self.copy_dentry_with_options(space_id, dentry_id, request, headers, runtime)

    async def copy_dentry_async(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkdoc__2__0_models.CopyDentryRequest,
    ) -> dingtalkdoc__2__0_models.CopyDentryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.CopyDentryHeaders()
        return await self.copy_dentry_with_options_async(space_id, dentry_id, request, headers, runtime)

    def copy_dentry_with_options(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkdoc__2__0_models.CopyDentryRequest,
        headers: dingtalkdoc__2__0_models.CopyDentryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.CopyDentryResponse:
        UtilClient.validate_model(request)
        space_id = OpenApiUtilClient.get_encode_param(space_id)
        dentry_id = OpenApiUtilClient.get_encode_param(dentry_id)
        body = {}
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.target_space_id):
            body['targetSpaceId'] = request.target_space_id
        if not UtilClient.is_unset(request.to_next_dentry_id):
            body['toNextDentryId'] = request.to_next_dentry_id
        if not UtilClient.is_unset(request.to_parent_dentry_id):
            body['toParentDentryId'] = request.to_parent_dentry_id
        if not UtilClient.is_unset(request.to_prev_dentry_id):
            body['toPrevDentryId'] = request.to_prev_dentry_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.CopyDentryResponse(),
            self.do_roarequest('CopyDentry', 'doc_2.0', 'HTTP', 'POST', 'AK', f'/v2.0/doc/spaces/{space_id}/dentries/{dentry_id}/copy', 'json', req, runtime)
        )

    async def copy_dentry_with_options_async(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkdoc__2__0_models.CopyDentryRequest,
        headers: dingtalkdoc__2__0_models.CopyDentryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.CopyDentryResponse:
        UtilClient.validate_model(request)
        space_id = OpenApiUtilClient.get_encode_param(space_id)
        dentry_id = OpenApiUtilClient.get_encode_param(dentry_id)
        body = {}
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.target_space_id):
            body['targetSpaceId'] = request.target_space_id
        if not UtilClient.is_unset(request.to_next_dentry_id):
            body['toNextDentryId'] = request.to_next_dentry_id
        if not UtilClient.is_unset(request.to_parent_dentry_id):
            body['toParentDentryId'] = request.to_parent_dentry_id
        if not UtilClient.is_unset(request.to_prev_dentry_id):
            body['toPrevDentryId'] = request.to_prev_dentry_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.CopyDentryResponse(),
            await self.do_roarequest_async('CopyDentry', 'doc_2.0', 'HTTP', 'POST', 'AK', f'/v2.0/doc/spaces/{space_id}/dentries/{dentry_id}/copy', 'json', req, runtime)
        )

    def create_dentry(
        self,
        space_id: str,
        request: dingtalkdoc__2__0_models.CreateDentryRequest,
    ) -> dingtalkdoc__2__0_models.CreateDentryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.CreateDentryHeaders()
        return self.create_dentry_with_options(space_id, request, headers, runtime)

    async def create_dentry_async(
        self,
        space_id: str,
        request: dingtalkdoc__2__0_models.CreateDentryRequest,
    ) -> dingtalkdoc__2__0_models.CreateDentryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.CreateDentryHeaders()
        return await self.create_dentry_with_options_async(space_id, request, headers, runtime)

    def create_dentry_with_options(
        self,
        space_id: str,
        request: dingtalkdoc__2__0_models.CreateDentryRequest,
        headers: dingtalkdoc__2__0_models.CreateDentryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.CreateDentryResponse:
        UtilClient.validate_model(request)
        space_id = OpenApiUtilClient.get_encode_param(space_id)
        body = {}
        if not UtilClient.is_unset(request.dentry_type):
            body['dentryType'] = request.dentry_type
        if not UtilClient.is_unset(request.document_type):
            body['documentType'] = request.document_type
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.parent_dentry_id):
            body['parentDentryId'] = request.parent_dentry_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.CreateDentryResponse(),
            self.do_roarequest('CreateDentry', 'doc_2.0', 'HTTP', 'POST', 'AK', f'/v2.0/doc/spaces/{space_id}/dentries', 'json', req, runtime)
        )

    async def create_dentry_with_options_async(
        self,
        space_id: str,
        request: dingtalkdoc__2__0_models.CreateDentryRequest,
        headers: dingtalkdoc__2__0_models.CreateDentryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.CreateDentryResponse:
        UtilClient.validate_model(request)
        space_id = OpenApiUtilClient.get_encode_param(space_id)
        body = {}
        if not UtilClient.is_unset(request.dentry_type):
            body['dentryType'] = request.dentry_type
        if not UtilClient.is_unset(request.document_type):
            body['documentType'] = request.document_type
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.parent_dentry_id):
            body['parentDentryId'] = request.parent_dentry_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.CreateDentryResponse(),
            await self.do_roarequest_async('CreateDentry', 'doc_2.0', 'HTTP', 'POST', 'AK', f'/v2.0/doc/spaces/{space_id}/dentries', 'json', req, runtime)
        )

    def create_space(
        self,
        request: dingtalkdoc__2__0_models.CreateSpaceRequest,
    ) -> dingtalkdoc__2__0_models.CreateSpaceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.CreateSpaceHeaders()
        return self.create_space_with_options(request, headers, runtime)

    async def create_space_async(
        self,
        request: dingtalkdoc__2__0_models.CreateSpaceRequest,
    ) -> dingtalkdoc__2__0_models.CreateSpaceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.CreateSpaceHeaders()
        return await self.create_space_with_options_async(request, headers, runtime)

    def create_space_with_options(
        self,
        request: dingtalkdoc__2__0_models.CreateSpaceRequest,
        headers: dingtalkdoc__2__0_models.CreateSpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.CreateSpaceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.icon):
            body['icon'] = request.icon
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.section_id):
            body['sectionId'] = request.section_id
        if not UtilClient.is_unset(request.share_scope):
            body['shareScope'] = request.share_scope
        if not UtilClient.is_unset(request.team_id):
            body['teamId'] = request.team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.CreateSpaceResponse(),
            self.do_roarequest('CreateSpace', 'doc_2.0', 'HTTP', 'POST', 'AK', f'/v2.0/doc/spaces', 'json', req, runtime)
        )

    async def create_space_with_options_async(
        self,
        request: dingtalkdoc__2__0_models.CreateSpaceRequest,
        headers: dingtalkdoc__2__0_models.CreateSpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.CreateSpaceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.icon):
            body['icon'] = request.icon
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.section_id):
            body['sectionId'] = request.section_id
        if not UtilClient.is_unset(request.share_scope):
            body['shareScope'] = request.share_scope
        if not UtilClient.is_unset(request.team_id):
            body['teamId'] = request.team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.CreateSpaceResponse(),
            await self.do_roarequest_async('CreateSpace', 'doc_2.0', 'HTTP', 'POST', 'AK', f'/v2.0/doc/spaces', 'json', req, runtime)
        )

    def create_team(
        self,
        request: dingtalkdoc__2__0_models.CreateTeamRequest,
    ) -> dingtalkdoc__2__0_models.CreateTeamResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.CreateTeamHeaders()
        return self.create_team_with_options(request, headers, runtime)

    async def create_team_async(
        self,
        request: dingtalkdoc__2__0_models.CreateTeamRequest,
    ) -> dingtalkdoc__2__0_models.CreateTeamResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.CreateTeamHeaders()
        return await self.create_team_with_options_async(request, headers, runtime)

    def create_team_with_options(
        self,
        request: dingtalkdoc__2__0_models.CreateTeamRequest,
        headers: dingtalkdoc__2__0_models.CreateTeamHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.CreateTeamResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.cover):
            body['cover'] = request.cover
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.icon):
            body['icon'] = request.icon
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.team_type):
            body['teamType'] = request.team_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.CreateTeamResponse(),
            self.do_roarequest('CreateTeam', 'doc_2.0', 'HTTP', 'POST', 'AK', f'/v2.0/doc/teams', 'json', req, runtime)
        )

    async def create_team_with_options_async(
        self,
        request: dingtalkdoc__2__0_models.CreateTeamRequest,
        headers: dingtalkdoc__2__0_models.CreateTeamHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.CreateTeamResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.cover):
            body['cover'] = request.cover
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.icon):
            body['icon'] = request.icon
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.team_type):
            body['teamType'] = request.team_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.CreateTeamResponse(),
            await self.do_roarequest_async('CreateTeam', 'doc_2.0', 'HTTP', 'POST', 'AK', f'/v2.0/doc/teams', 'json', req, runtime)
        )

    def delete_team(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.DeleteTeamRequest,
    ) -> dingtalkdoc__2__0_models.DeleteTeamResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.DeleteTeamHeaders()
        return self.delete_team_with_options(team_id, request, headers, runtime)

    async def delete_team_async(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.DeleteTeamRequest,
    ) -> dingtalkdoc__2__0_models.DeleteTeamResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.DeleteTeamHeaders()
        return await self.delete_team_with_options_async(team_id, request, headers, runtime)

    def delete_team_with_options(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.DeleteTeamRequest,
        headers: dingtalkdoc__2__0_models.DeleteTeamHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.DeleteTeamResponse:
        UtilClient.validate_model(request)
        team_id = OpenApiUtilClient.get_encode_param(team_id)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.DeleteTeamResponse(),
            self.do_roarequest('DeleteTeam', 'doc_2.0', 'HTTP', 'DELETE', 'AK', f'/v2.0/doc/teams/{team_id}', 'json', req, runtime)
        )

    async def delete_team_with_options_async(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.DeleteTeamRequest,
        headers: dingtalkdoc__2__0_models.DeleteTeamHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.DeleteTeamResponse:
        UtilClient.validate_model(request)
        team_id = OpenApiUtilClient.get_encode_param(team_id)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.DeleteTeamResponse(),
            await self.do_roarequest_async('DeleteTeam', 'doc_2.0', 'HTTP', 'DELETE', 'AK', f'/v2.0/doc/teams/{team_id}', 'json', req, runtime)
        )

    def get_schema(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.GetSchemaRequest,
    ) -> dingtalkdoc__2__0_models.GetSchemaResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.GetSchemaHeaders()
        return self.get_schema_with_options(team_id, request, headers, runtime)

    async def get_schema_async(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.GetSchemaRequest,
    ) -> dingtalkdoc__2__0_models.GetSchemaResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.GetSchemaHeaders()
        return await self.get_schema_with_options_async(team_id, request, headers, runtime)

    def get_schema_with_options(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.GetSchemaRequest,
        headers: dingtalkdoc__2__0_models.GetSchemaHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.GetSchemaResponse:
        UtilClient.validate_model(request)
        team_id = OpenApiUtilClient.get_encode_param(team_id)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.GetSchemaResponse(),
            self.do_roarequest('GetSchema', 'doc_2.0', 'HTTP', 'GET', 'AK', f'/v2.0/doc/teams/{team_id}/schemas', 'json', req, runtime)
        )

    async def get_schema_with_options_async(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.GetSchemaRequest,
        headers: dingtalkdoc__2__0_models.GetSchemaHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.GetSchemaResponse:
        UtilClient.validate_model(request)
        team_id = OpenApiUtilClient.get_encode_param(team_id)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.GetSchemaResponse(),
            await self.do_roarequest_async('GetSchema', 'doc_2.0', 'HTTP', 'GET', 'AK', f'/v2.0/doc/teams/{team_id}/schemas', 'json', req, runtime)
        )

    def get_space_directories(
        self,
        space_id: str,
        request: dingtalkdoc__2__0_models.GetSpaceDirectoriesRequest,
    ) -> dingtalkdoc__2__0_models.GetSpaceDirectoriesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.GetSpaceDirectoriesHeaders()
        return self.get_space_directories_with_options(space_id, request, headers, runtime)

    async def get_space_directories_async(
        self,
        space_id: str,
        request: dingtalkdoc__2__0_models.GetSpaceDirectoriesRequest,
    ) -> dingtalkdoc__2__0_models.GetSpaceDirectoriesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.GetSpaceDirectoriesHeaders()
        return await self.get_space_directories_with_options_async(space_id, request, headers, runtime)

    def get_space_directories_with_options(
        self,
        space_id: str,
        request: dingtalkdoc__2__0_models.GetSpaceDirectoriesRequest,
        headers: dingtalkdoc__2__0_models.GetSpaceDirectoriesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.GetSpaceDirectoriesResponse:
        UtilClient.validate_model(request)
        space_id = OpenApiUtilClient.get_encode_param(space_id)
        query = {}
        if not UtilClient.is_unset(request.dentry_id):
            query['dentryId'] = request.dentry_id
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.GetSpaceDirectoriesResponse(),
            self.do_roarequest('GetSpaceDirectories', 'doc_2.0', 'HTTP', 'GET', 'AK', f'/v2.0/doc/spaces/{space_id}/directories', 'json', req, runtime)
        )

    async def get_space_directories_with_options_async(
        self,
        space_id: str,
        request: dingtalkdoc__2__0_models.GetSpaceDirectoriesRequest,
        headers: dingtalkdoc__2__0_models.GetSpaceDirectoriesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.GetSpaceDirectoriesResponse:
        UtilClient.validate_model(request)
        space_id = OpenApiUtilClient.get_encode_param(space_id)
        query = {}
        if not UtilClient.is_unset(request.dentry_id):
            query['dentryId'] = request.dentry_id
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.GetSpaceDirectoriesResponse(),
            await self.do_roarequest_async('GetSpaceDirectories', 'doc_2.0', 'HTTP', 'GET', 'AK', f'/v2.0/doc/spaces/{space_id}/directories', 'json', req, runtime)
        )

    def get_team(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.GetTeamRequest,
    ) -> dingtalkdoc__2__0_models.GetTeamResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.GetTeamHeaders()
        return self.get_team_with_options(team_id, request, headers, runtime)

    async def get_team_async(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.GetTeamRequest,
    ) -> dingtalkdoc__2__0_models.GetTeamResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.GetTeamHeaders()
        return await self.get_team_with_options_async(team_id, request, headers, runtime)

    def get_team_with_options(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.GetTeamRequest,
        headers: dingtalkdoc__2__0_models.GetTeamHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.GetTeamResponse:
        UtilClient.validate_model(request)
        team_id = OpenApiUtilClient.get_encode_param(team_id)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.GetTeamResponse(),
            self.do_roarequest('GetTeam', 'doc_2.0', 'HTTP', 'GET', 'AK', f'/v2.0/doc/teams/{team_id}', 'json', req, runtime)
        )

    async def get_team_with_options_async(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.GetTeamRequest,
        headers: dingtalkdoc__2__0_models.GetTeamHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.GetTeamResponse:
        UtilClient.validate_model(request)
        team_id = OpenApiUtilClient.get_encode_param(team_id)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.GetTeamResponse(),
            await self.do_roarequest_async('GetTeam', 'doc_2.0', 'HTTP', 'GET', 'AK', f'/v2.0/doc/teams/{team_id}', 'json', req, runtime)
        )

    def get_total_number_of_dentries(
        self,
        request: dingtalkdoc__2__0_models.GetTotalNumberOfDentriesRequest,
    ) -> dingtalkdoc__2__0_models.GetTotalNumberOfDentriesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.GetTotalNumberOfDentriesHeaders()
        return self.get_total_number_of_dentries_with_options(request, headers, runtime)

    async def get_total_number_of_dentries_async(
        self,
        request: dingtalkdoc__2__0_models.GetTotalNumberOfDentriesRequest,
    ) -> dingtalkdoc__2__0_models.GetTotalNumberOfDentriesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.GetTotalNumberOfDentriesHeaders()
        return await self.get_total_number_of_dentries_with_options_async(request, headers, runtime)

    def get_total_number_of_dentries_with_options(
        self,
        request: dingtalkdoc__2__0_models.GetTotalNumberOfDentriesRequest,
        headers: dingtalkdoc__2__0_models.GetTotalNumberOfDentriesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.GetTotalNumberOfDentriesResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.include_folder):
            query['includeFolder'] = request.include_folder
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.space_types):
            query['spaceTypes'] = request.space_types
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.GetTotalNumberOfDentriesResponse(),
            self.do_roarequest('GetTotalNumberOfDentries', 'doc_2.0', 'HTTP', 'GET', 'AK', f'/v2.0/doc/spaces/statistics/dentryCounts', 'json', req, runtime)
        )

    async def get_total_number_of_dentries_with_options_async(
        self,
        request: dingtalkdoc__2__0_models.GetTotalNumberOfDentriesRequest,
        headers: dingtalkdoc__2__0_models.GetTotalNumberOfDentriesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.GetTotalNumberOfDentriesResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.include_folder):
            query['includeFolder'] = request.include_folder
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.space_types):
            query['spaceTypes'] = request.space_types
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.GetTotalNumberOfDentriesResponse(),
            await self.do_roarequest_async('GetTotalNumberOfDentries', 'doc_2.0', 'HTTP', 'GET', 'AK', f'/v2.0/doc/spaces/statistics/dentryCounts', 'json', req, runtime)
        )

    def get_total_number_of_spaces(
        self,
        request: dingtalkdoc__2__0_models.GetTotalNumberOfSpacesRequest,
    ) -> dingtalkdoc__2__0_models.GetTotalNumberOfSpacesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.GetTotalNumberOfSpacesHeaders()
        return self.get_total_number_of_spaces_with_options(request, headers, runtime)

    async def get_total_number_of_spaces_async(
        self,
        request: dingtalkdoc__2__0_models.GetTotalNumberOfSpacesRequest,
    ) -> dingtalkdoc__2__0_models.GetTotalNumberOfSpacesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.GetTotalNumberOfSpacesHeaders()
        return await self.get_total_number_of_spaces_with_options_async(request, headers, runtime)

    def get_total_number_of_spaces_with_options(
        self,
        request: dingtalkdoc__2__0_models.GetTotalNumberOfSpacesRequest,
        headers: dingtalkdoc__2__0_models.GetTotalNumberOfSpacesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.GetTotalNumberOfSpacesResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.GetTotalNumberOfSpacesResponse(),
            self.do_roarequest('GetTotalNumberOfSpaces', 'doc_2.0', 'HTTP', 'GET', 'AK', f'/v2.0/doc/spaces/statistics/spaceCounts', 'json', req, runtime)
        )

    async def get_total_number_of_spaces_with_options_async(
        self,
        request: dingtalkdoc__2__0_models.GetTotalNumberOfSpacesRequest,
        headers: dingtalkdoc__2__0_models.GetTotalNumberOfSpacesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.GetTotalNumberOfSpacesResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.GetTotalNumberOfSpacesResponse(),
            await self.do_roarequest_async('GetTotalNumberOfSpaces', 'doc_2.0', 'HTTP', 'GET', 'AK', f'/v2.0/doc/spaces/statistics/spaceCounts', 'json', req, runtime)
        )

    def get_user_info_by_open_token(
        self,
        request: dingtalkdoc__2__0_models.GetUserInfoByOpenTokenRequest,
    ) -> dingtalkdoc__2__0_models.GetUserInfoByOpenTokenResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.GetUserInfoByOpenTokenHeaders()
        return self.get_user_info_by_open_token_with_options(request, headers, runtime)

    async def get_user_info_by_open_token_async(
        self,
        request: dingtalkdoc__2__0_models.GetUserInfoByOpenTokenRequest,
    ) -> dingtalkdoc__2__0_models.GetUserInfoByOpenTokenResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.GetUserInfoByOpenTokenHeaders()
        return await self.get_user_info_by_open_token_with_options_async(request, headers, runtime)

    def get_user_info_by_open_token_with_options(
        self,
        request: dingtalkdoc__2__0_models.GetUserInfoByOpenTokenRequest,
        headers: dingtalkdoc__2__0_models.GetUserInfoByOpenTokenHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.GetUserInfoByOpenTokenResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.doc_key):
            query['docKey'] = request.doc_key
        if not UtilClient.is_unset(request.open_token):
            query['openToken'] = request.open_token
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.GetUserInfoByOpenTokenResponse(),
            self.do_roarequest('GetUserInfoByOpenToken', 'doc_2.0', 'HTTP', 'GET', 'AK', f'/v2.0/doc/userInfos', 'json', req, runtime)
        )

    async def get_user_info_by_open_token_with_options_async(
        self,
        request: dingtalkdoc__2__0_models.GetUserInfoByOpenTokenRequest,
        headers: dingtalkdoc__2__0_models.GetUserInfoByOpenTokenHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.GetUserInfoByOpenTokenResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.doc_key):
            query['docKey'] = request.doc_key
        if not UtilClient.is_unset(request.open_token):
            query['openToken'] = request.open_token
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.GetUserInfoByOpenTokenResponse(),
            await self.do_roarequest_async('GetUserInfoByOpenToken', 'doc_2.0', 'HTTP', 'GET', 'AK', f'/v2.0/doc/userInfos', 'json', req, runtime)
        )

    def list_feeds(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.ListFeedsRequest,
    ) -> dingtalkdoc__2__0_models.ListFeedsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.ListFeedsHeaders()
        return self.list_feeds_with_options(team_id, request, headers, runtime)

    async def list_feeds_async(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.ListFeedsRequest,
    ) -> dingtalkdoc__2__0_models.ListFeedsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.ListFeedsHeaders()
        return await self.list_feeds_with_options_async(team_id, request, headers, runtime)

    def list_feeds_with_options(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.ListFeedsRequest,
        headers: dingtalkdoc__2__0_models.ListFeedsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.ListFeedsResponse:
        UtilClient.validate_model(request)
        team_id = OpenApiUtilClient.get_encode_param(team_id)
        query = {}
        if not UtilClient.is_unset(request.exclude_file):
            query['excludeFile'] = request.exclude_file
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.ListFeedsResponse(),
            self.do_roarequest('ListFeeds', 'doc_2.0', 'HTTP', 'GET', 'AK', f'/v2.0/doc/teams/{team_id}/feeds', 'json', req, runtime)
        )

    async def list_feeds_with_options_async(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.ListFeedsRequest,
        headers: dingtalkdoc__2__0_models.ListFeedsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.ListFeedsResponse:
        UtilClient.validate_model(request)
        team_id = OpenApiUtilClient.get_encode_param(team_id)
        query = {}
        if not UtilClient.is_unset(request.exclude_file):
            query['excludeFile'] = request.exclude_file
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.ListFeedsResponse(),
            await self.do_roarequest_async('ListFeeds', 'doc_2.0', 'HTTP', 'GET', 'AK', f'/v2.0/doc/teams/{team_id}/feeds', 'json', req, runtime)
        )

    def list_hot_docs(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.ListHotDocsRequest,
    ) -> dingtalkdoc__2__0_models.ListHotDocsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.ListHotDocsHeaders()
        return self.list_hot_docs_with_options(team_id, request, headers, runtime)

    async def list_hot_docs_async(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.ListHotDocsRequest,
    ) -> dingtalkdoc__2__0_models.ListHotDocsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.ListHotDocsHeaders()
        return await self.list_hot_docs_with_options_async(team_id, request, headers, runtime)

    def list_hot_docs_with_options(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.ListHotDocsRequest,
        headers: dingtalkdoc__2__0_models.ListHotDocsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.ListHotDocsResponse:
        UtilClient.validate_model(request)
        team_id = OpenApiUtilClient.get_encode_param(team_id)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.ListHotDocsResponse(),
            self.do_roarequest('ListHotDocs', 'doc_2.0', 'HTTP', 'GET', 'AK', f'/v2.0/doc/teams/{team_id}/hotDocs', 'json', req, runtime)
        )

    async def list_hot_docs_with_options_async(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.ListHotDocsRequest,
        headers: dingtalkdoc__2__0_models.ListHotDocsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.ListHotDocsResponse:
        UtilClient.validate_model(request)
        team_id = OpenApiUtilClient.get_encode_param(team_id)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.ListHotDocsResponse(),
            await self.do_roarequest_async('ListHotDocs', 'doc_2.0', 'HTTP', 'GET', 'AK', f'/v2.0/doc/teams/{team_id}/hotDocs', 'json', req, runtime)
        )

    def list_related_space_teams(
        self,
        request: dingtalkdoc__2__0_models.ListRelatedSpaceTeamsRequest,
    ) -> dingtalkdoc__2__0_models.ListRelatedSpaceTeamsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.ListRelatedSpaceTeamsHeaders()
        return self.list_related_space_teams_with_options(request, headers, runtime)

    async def list_related_space_teams_async(
        self,
        request: dingtalkdoc__2__0_models.ListRelatedSpaceTeamsRequest,
    ) -> dingtalkdoc__2__0_models.ListRelatedSpaceTeamsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.ListRelatedSpaceTeamsHeaders()
        return await self.list_related_space_teams_with_options_async(request, headers, runtime)

    def list_related_space_teams_with_options(
        self,
        request: dingtalkdoc__2__0_models.ListRelatedSpaceTeamsRequest,
        headers: dingtalkdoc__2__0_models.ListRelatedSpaceTeamsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.ListRelatedSpaceTeamsResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.type):
            query['type'] = request.type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.ListRelatedSpaceTeamsResponse(),
            self.do_roarequest('ListRelatedSpaceTeams', 'doc_2.0', 'HTTP', 'GET', 'AK', f'/v2.0/doc/teams/relations/spaceTeams', 'json', req, runtime)
        )

    async def list_related_space_teams_with_options_async(
        self,
        request: dingtalkdoc__2__0_models.ListRelatedSpaceTeamsRequest,
        headers: dingtalkdoc__2__0_models.ListRelatedSpaceTeamsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.ListRelatedSpaceTeamsResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.type):
            query['type'] = request.type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.ListRelatedSpaceTeamsResponse(),
            await self.do_roarequest_async('ListRelatedSpaceTeams', 'doc_2.0', 'HTTP', 'GET', 'AK', f'/v2.0/doc/teams/relations/spaceTeams', 'json', req, runtime)
        )

    def list_related_teams(
        self,
        request: dingtalkdoc__2__0_models.ListRelatedTeamsRequest,
    ) -> dingtalkdoc__2__0_models.ListRelatedTeamsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.ListRelatedTeamsHeaders()
        return self.list_related_teams_with_options(request, headers, runtime)

    async def list_related_teams_async(
        self,
        request: dingtalkdoc__2__0_models.ListRelatedTeamsRequest,
    ) -> dingtalkdoc__2__0_models.ListRelatedTeamsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.ListRelatedTeamsHeaders()
        return await self.list_related_teams_with_options_async(request, headers, runtime)

    def list_related_teams_with_options(
        self,
        request: dingtalkdoc__2__0_models.ListRelatedTeamsRequest,
        headers: dingtalkdoc__2__0_models.ListRelatedTeamsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.ListRelatedTeamsResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.type):
            query['type'] = request.type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.ListRelatedTeamsResponse(),
            self.do_roarequest('ListRelatedTeams', 'doc_2.0', 'HTTP', 'GET', 'AK', f'/v2.0/doc/teams', 'json', req, runtime)
        )

    async def list_related_teams_with_options_async(
        self,
        request: dingtalkdoc__2__0_models.ListRelatedTeamsRequest,
        headers: dingtalkdoc__2__0_models.ListRelatedTeamsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.ListRelatedTeamsResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.type):
            query['type'] = request.type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.ListRelatedTeamsResponse(),
            await self.do_roarequest_async('ListRelatedTeams', 'doc_2.0', 'HTTP', 'GET', 'AK', f'/v2.0/doc/teams', 'json', req, runtime)
        )

    def list_space_sections(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.ListSpaceSectionsRequest,
    ) -> dingtalkdoc__2__0_models.ListSpaceSectionsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.ListSpaceSectionsHeaders()
        return self.list_space_sections_with_options(team_id, request, headers, runtime)

    async def list_space_sections_async(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.ListSpaceSectionsRequest,
    ) -> dingtalkdoc__2__0_models.ListSpaceSectionsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.ListSpaceSectionsHeaders()
        return await self.list_space_sections_with_options_async(team_id, request, headers, runtime)

    def list_space_sections_with_options(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.ListSpaceSectionsRequest,
        headers: dingtalkdoc__2__0_models.ListSpaceSectionsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.ListSpaceSectionsResponse:
        UtilClient.validate_model(request)
        team_id = OpenApiUtilClient.get_encode_param(team_id)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.ListSpaceSectionsResponse(),
            self.do_roarequest('ListSpaceSections', 'doc_2.0', 'HTTP', 'GET', 'AK', f'/v2.0/doc/teams/{team_id}/spaceSections', 'json', req, runtime)
        )

    async def list_space_sections_with_options_async(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.ListSpaceSectionsRequest,
        headers: dingtalkdoc__2__0_models.ListSpaceSectionsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.ListSpaceSectionsResponse:
        UtilClient.validate_model(request)
        team_id = OpenApiUtilClient.get_encode_param(team_id)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.ListSpaceSectionsResponse(),
            await self.do_roarequest_async('ListSpaceSections', 'doc_2.0', 'HTTP', 'GET', 'AK', f'/v2.0/doc/teams/{team_id}/spaceSections', 'json', req, runtime)
        )

    def list_team_members(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.ListTeamMembersRequest,
    ) -> dingtalkdoc__2__0_models.ListTeamMembersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.ListTeamMembersHeaders()
        return self.list_team_members_with_options(team_id, request, headers, runtime)

    async def list_team_members_async(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.ListTeamMembersRequest,
    ) -> dingtalkdoc__2__0_models.ListTeamMembersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.ListTeamMembersHeaders()
        return await self.list_team_members_with_options_async(team_id, request, headers, runtime)

    def list_team_members_with_options(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.ListTeamMembersRequest,
        headers: dingtalkdoc__2__0_models.ListTeamMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.ListTeamMembersResponse:
        UtilClient.validate_model(request)
        team_id = OpenApiUtilClient.get_encode_param(team_id)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.ListTeamMembersResponse(),
            self.do_roarequest('ListTeamMembers', 'doc_2.0', 'HTTP', 'GET', 'AK', f'/v2.0/doc/teams/{team_id}/members', 'json', req, runtime)
        )

    async def list_team_members_with_options_async(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.ListTeamMembersRequest,
        headers: dingtalkdoc__2__0_models.ListTeamMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.ListTeamMembersResponse:
        UtilClient.validate_model(request)
        team_id = OpenApiUtilClient.get_encode_param(team_id)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.ListTeamMembersResponse(),
            await self.do_roarequest_async('ListTeamMembers', 'doc_2.0', 'HTTP', 'GET', 'AK', f'/v2.0/doc/teams/{team_id}/members', 'json', req, runtime)
        )

    def move_dentry(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkdoc__2__0_models.MoveDentryRequest,
    ) -> dingtalkdoc__2__0_models.MoveDentryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.MoveDentryHeaders()
        return self.move_dentry_with_options(space_id, dentry_id, request, headers, runtime)

    async def move_dentry_async(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkdoc__2__0_models.MoveDentryRequest,
    ) -> dingtalkdoc__2__0_models.MoveDentryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.MoveDentryHeaders()
        return await self.move_dentry_with_options_async(space_id, dentry_id, request, headers, runtime)

    def move_dentry_with_options(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkdoc__2__0_models.MoveDentryRequest,
        headers: dingtalkdoc__2__0_models.MoveDentryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.MoveDentryResponse:
        UtilClient.validate_model(request)
        space_id = OpenApiUtilClient.get_encode_param(space_id)
        dentry_id = OpenApiUtilClient.get_encode_param(dentry_id)
        body = {}
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.target_space_id):
            body['targetSpaceId'] = request.target_space_id
        if not UtilClient.is_unset(request.to_next_dentry_id):
            body['toNextDentryId'] = request.to_next_dentry_id
        if not UtilClient.is_unset(request.to_parent_dentry_id):
            body['toParentDentryId'] = request.to_parent_dentry_id
        if not UtilClient.is_unset(request.to_prev_dentry_id):
            body['toPrevDentryId'] = request.to_prev_dentry_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.MoveDentryResponse(),
            self.do_roarequest('MoveDentry', 'doc_2.0', 'HTTP', 'POST', 'AK', f'/v2.0/doc/spaces/{space_id}/dentries/{dentry_id}/move', 'json', req, runtime)
        )

    async def move_dentry_with_options_async(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkdoc__2__0_models.MoveDentryRequest,
        headers: dingtalkdoc__2__0_models.MoveDentryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.MoveDentryResponse:
        UtilClient.validate_model(request)
        space_id = OpenApiUtilClient.get_encode_param(space_id)
        dentry_id = OpenApiUtilClient.get_encode_param(dentry_id)
        body = {}
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.target_space_id):
            body['targetSpaceId'] = request.target_space_id
        if not UtilClient.is_unset(request.to_next_dentry_id):
            body['toNextDentryId'] = request.to_next_dentry_id
        if not UtilClient.is_unset(request.to_parent_dentry_id):
            body['toParentDentryId'] = request.to_parent_dentry_id
        if not UtilClient.is_unset(request.to_prev_dentry_id):
            body['toPrevDentryId'] = request.to_prev_dentry_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.MoveDentryResponse(),
            await self.do_roarequest_async('MoveDentry', 'doc_2.0', 'HTTP', 'POST', 'AK', f'/v2.0/doc/spaces/{space_id}/dentries/{dentry_id}/move', 'json', req, runtime)
        )

    def query_dentry(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkdoc__2__0_models.QueryDentryRequest,
    ) -> dingtalkdoc__2__0_models.QueryDentryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.QueryDentryHeaders()
        return self.query_dentry_with_options(space_id, dentry_id, request, headers, runtime)

    async def query_dentry_async(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkdoc__2__0_models.QueryDentryRequest,
    ) -> dingtalkdoc__2__0_models.QueryDentryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.QueryDentryHeaders()
        return await self.query_dentry_with_options_async(space_id, dentry_id, request, headers, runtime)

    def query_dentry_with_options(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkdoc__2__0_models.QueryDentryRequest,
        headers: dingtalkdoc__2__0_models.QueryDentryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.QueryDentryResponse:
        UtilClient.validate_model(request)
        space_id = OpenApiUtilClient.get_encode_param(space_id)
        dentry_id = OpenApiUtilClient.get_encode_param(dentry_id)
        query = {}
        if not UtilClient.is_unset(request.include_space):
            query['includeSpace'] = request.include_space
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.QueryDentryResponse(),
            self.do_roarequest('QueryDentry', 'doc_2.0', 'HTTP', 'GET', 'AK', f'/v2.0/doc/spaces/{space_id}/dentries/{dentry_id}', 'json', req, runtime)
        )

    async def query_dentry_with_options_async(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkdoc__2__0_models.QueryDentryRequest,
        headers: dingtalkdoc__2__0_models.QueryDentryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.QueryDentryResponse:
        UtilClient.validate_model(request)
        space_id = OpenApiUtilClient.get_encode_param(space_id)
        dentry_id = OpenApiUtilClient.get_encode_param(dentry_id)
        query = {}
        if not UtilClient.is_unset(request.include_space):
            query['includeSpace'] = request.include_space
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.QueryDentryResponse(),
            await self.do_roarequest_async('QueryDentry', 'doc_2.0', 'HTTP', 'GET', 'AK', f'/v2.0/doc/spaces/{space_id}/dentries/{dentry_id}', 'json', req, runtime)
        )

    def query_mine_space(
        self,
        union_id: str,
    ) -> dingtalkdoc__2__0_models.QueryMineSpaceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.QueryMineSpaceHeaders()
        return self.query_mine_space_with_options(union_id, headers, runtime)

    async def query_mine_space_async(
        self,
        union_id: str,
    ) -> dingtalkdoc__2__0_models.QueryMineSpaceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.QueryMineSpaceHeaders()
        return await self.query_mine_space_with_options_async(union_id, headers, runtime)

    def query_mine_space_with_options(
        self,
        union_id: str,
        headers: dingtalkdoc__2__0_models.QueryMineSpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.QueryMineSpaceResponse:
        union_id = OpenApiUtilClient.get_encode_param(union_id)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.QueryMineSpaceResponse(),
            self.do_roarequest('QueryMineSpace', 'doc_2.0', 'HTTP', 'GET', 'AK', f'/v2.0/doc/spaces/users/{union_id}/mine', 'json', req, runtime)
        )

    async def query_mine_space_with_options_async(
        self,
        union_id: str,
        headers: dingtalkdoc__2__0_models.QueryMineSpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.QueryMineSpaceResponse:
        union_id = OpenApiUtilClient.get_encode_param(union_id)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.QueryMineSpaceResponse(),
            await self.do_roarequest_async('QueryMineSpace', 'doc_2.0', 'HTTP', 'GET', 'AK', f'/v2.0/doc/spaces/users/{union_id}/mine', 'json', req, runtime)
        )

    def query_recent_list(
        self,
        request: dingtalkdoc__2__0_models.QueryRecentListRequest,
    ) -> dingtalkdoc__2__0_models.QueryRecentListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.QueryRecentListHeaders()
        return self.query_recent_list_with_options(request, headers, runtime)

    async def query_recent_list_async(
        self,
        request: dingtalkdoc__2__0_models.QueryRecentListRequest,
    ) -> dingtalkdoc__2__0_models.QueryRecentListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.QueryRecentListHeaders()
        return await self.query_recent_list_with_options_async(request, headers, runtime)

    def query_recent_list_with_options(
        self,
        request: dingtalkdoc__2__0_models.QueryRecentListRequest,
        headers: dingtalkdoc__2__0_models.QueryRecentListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.QueryRecentListResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.creator_type):
            query['creatorType'] = request.creator_type
        if not UtilClient.is_unset(request.file_type):
            query['fileType'] = request.file_type
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.recent_type):
            query['recentType'] = request.recent_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.QueryRecentListResponse(),
            self.do_roarequest('QueryRecentList', 'doc_2.0', 'HTTP', 'GET', 'AK', f'/v2.0/doc/spaces/docs/recent', 'json', req, runtime)
        )

    async def query_recent_list_with_options_async(
        self,
        request: dingtalkdoc__2__0_models.QueryRecentListRequest,
        headers: dingtalkdoc__2__0_models.QueryRecentListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.QueryRecentListResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.creator_type):
            query['creatorType'] = request.creator_type
        if not UtilClient.is_unset(request.file_type):
            query['fileType'] = request.file_type
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.recent_type):
            query['recentType'] = request.recent_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.QueryRecentListResponse(),
            await self.do_roarequest_async('QueryRecentList', 'doc_2.0', 'HTTP', 'GET', 'AK', f'/v2.0/doc/spaces/docs/recent', 'json', req, runtime)
        )

    def query_space(
        self,
        space_id: str,
        request: dingtalkdoc__2__0_models.QuerySpaceRequest,
    ) -> dingtalkdoc__2__0_models.QuerySpaceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.QuerySpaceHeaders()
        return self.query_space_with_options(space_id, request, headers, runtime)

    async def query_space_async(
        self,
        space_id: str,
        request: dingtalkdoc__2__0_models.QuerySpaceRequest,
    ) -> dingtalkdoc__2__0_models.QuerySpaceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.QuerySpaceHeaders()
        return await self.query_space_with_options_async(space_id, request, headers, runtime)

    def query_space_with_options(
        self,
        space_id: str,
        request: dingtalkdoc__2__0_models.QuerySpaceRequest,
        headers: dingtalkdoc__2__0_models.QuerySpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.QuerySpaceResponse:
        UtilClient.validate_model(request)
        space_id = OpenApiUtilClient.get_encode_param(space_id)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.QuerySpaceResponse(),
            self.do_roarequest('QuerySpace', 'doc_2.0', 'HTTP', 'GET', 'AK', f'/v2.0/doc/spaces/{space_id}', 'json', req, runtime)
        )

    async def query_space_with_options_async(
        self,
        space_id: str,
        request: dingtalkdoc__2__0_models.QuerySpaceRequest,
        headers: dingtalkdoc__2__0_models.QuerySpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.QuerySpaceResponse:
        UtilClient.validate_model(request)
        space_id = OpenApiUtilClient.get_encode_param(space_id)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.QuerySpaceResponse(),
            await self.do_roarequest_async('QuerySpace', 'doc_2.0', 'HTTP', 'GET', 'AK', f'/v2.0/doc/spaces/{space_id}', 'json', req, runtime)
        )

    def related_spaces(
        self,
        request: dingtalkdoc__2__0_models.RelatedSpacesRequest,
    ) -> dingtalkdoc__2__0_models.RelatedSpacesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.RelatedSpacesHeaders()
        return self.related_spaces_with_options(request, headers, runtime)

    async def related_spaces_async(
        self,
        request: dingtalkdoc__2__0_models.RelatedSpacesRequest,
    ) -> dingtalkdoc__2__0_models.RelatedSpacesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.RelatedSpacesHeaders()
        return await self.related_spaces_with_options_async(request, headers, runtime)

    def related_spaces_with_options(
        self,
        request: dingtalkdoc__2__0_models.RelatedSpacesRequest,
        headers: dingtalkdoc__2__0_models.RelatedSpacesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.RelatedSpacesResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.team_id):
            query['teamId'] = request.team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.RelatedSpacesResponse(),
            self.do_roarequest('RelatedSpaces', 'doc_2.0', 'HTTP', 'GET', 'AK', f'/v2.0/doc/relations/spaces', 'json', req, runtime)
        )

    async def related_spaces_with_options_async(
        self,
        request: dingtalkdoc__2__0_models.RelatedSpacesRequest,
        headers: dingtalkdoc__2__0_models.RelatedSpacesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.RelatedSpacesResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.team_id):
            query['teamId'] = request.team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.RelatedSpacesResponse(),
            await self.do_roarequest_async('RelatedSpaces', 'doc_2.0', 'HTTP', 'GET', 'AK', f'/v2.0/doc/relations/spaces', 'json', req, runtime)
        )

    def remove_team_members(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.RemoveTeamMembersRequest,
    ) -> dingtalkdoc__2__0_models.RemoveTeamMembersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.RemoveTeamMembersHeaders()
        return self.remove_team_members_with_options(team_id, request, headers, runtime)

    async def remove_team_members_async(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.RemoveTeamMembersRequest,
    ) -> dingtalkdoc__2__0_models.RemoveTeamMembersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.RemoveTeamMembersHeaders()
        return await self.remove_team_members_with_options_async(team_id, request, headers, runtime)

    def remove_team_members_with_options(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.RemoveTeamMembersRequest,
        headers: dingtalkdoc__2__0_models.RemoveTeamMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.RemoveTeamMembersResponse:
        UtilClient.validate_model(request)
        team_id = OpenApiUtilClient.get_encode_param(team_id)
        body = {}
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        if not UtilClient.is_unset(request.notify):
            body['notify'] = request.notify
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.RemoveTeamMembersResponse(),
            self.do_roarequest('RemoveTeamMembers', 'doc_2.0', 'HTTP', 'PUT', 'AK', f'/v2.0/doc/teams/{team_id}/members/remove', 'json', req, runtime)
        )

    async def remove_team_members_with_options_async(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.RemoveTeamMembersRequest,
        headers: dingtalkdoc__2__0_models.RemoveTeamMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.RemoveTeamMembersResponse:
        UtilClient.validate_model(request)
        team_id = OpenApiUtilClient.get_encode_param(team_id)
        body = {}
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        if not UtilClient.is_unset(request.notify):
            body['notify'] = request.notify
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.RemoveTeamMembersResponse(),
            await self.do_roarequest_async('RemoveTeamMembers', 'doc_2.0', 'HTTP', 'PUT', 'AK', f'/v2.0/doc/teams/{team_id}/members/remove', 'json', req, runtime)
        )

    def rename_dentry(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkdoc__2__0_models.RenameDentryRequest,
    ) -> dingtalkdoc__2__0_models.RenameDentryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.RenameDentryHeaders()
        return self.rename_dentry_with_options(space_id, dentry_id, request, headers, runtime)

    async def rename_dentry_async(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkdoc__2__0_models.RenameDentryRequest,
    ) -> dingtalkdoc__2__0_models.RenameDentryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.RenameDentryHeaders()
        return await self.rename_dentry_with_options_async(space_id, dentry_id, request, headers, runtime)

    def rename_dentry_with_options(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkdoc__2__0_models.RenameDentryRequest,
        headers: dingtalkdoc__2__0_models.RenameDentryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.RenameDentryResponse:
        UtilClient.validate_model(request)
        space_id = OpenApiUtilClient.get_encode_param(space_id)
        dentry_id = OpenApiUtilClient.get_encode_param(dentry_id)
        query = {}
        if not UtilClient.is_unset(request.name):
            query['name'] = request.name
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.RenameDentryResponse(),
            self.do_roarequest('RenameDentry', 'doc_2.0', 'HTTP', 'POST', 'AK', f'/v2.0/doc/spaces/{space_id}/dentries/{dentry_id}/rename', 'json', req, runtime)
        )

    async def rename_dentry_with_options_async(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkdoc__2__0_models.RenameDentryRequest,
        headers: dingtalkdoc__2__0_models.RenameDentryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.RenameDentryResponse:
        UtilClient.validate_model(request)
        space_id = OpenApiUtilClient.get_encode_param(space_id)
        dentry_id = OpenApiUtilClient.get_encode_param(dentry_id)
        query = {}
        if not UtilClient.is_unset(request.name):
            query['name'] = request.name
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.RenameDentryResponse(),
            await self.do_roarequest_async('RenameDentry', 'doc_2.0', 'HTTP', 'POST', 'AK', f'/v2.0/doc/spaces/{space_id}/dentries/{dentry_id}/rename', 'json', req, runtime)
        )

    def save_team_members(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.SaveTeamMembersRequest,
    ) -> dingtalkdoc__2__0_models.SaveTeamMembersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.SaveTeamMembersHeaders()
        return self.save_team_members_with_options(team_id, request, headers, runtime)

    async def save_team_members_async(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.SaveTeamMembersRequest,
    ) -> dingtalkdoc__2__0_models.SaveTeamMembersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.SaveTeamMembersHeaders()
        return await self.save_team_members_with_options_async(team_id, request, headers, runtime)

    def save_team_members_with_options(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.SaveTeamMembersRequest,
        headers: dingtalkdoc__2__0_models.SaveTeamMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.SaveTeamMembersResponse:
        UtilClient.validate_model(request)
        team_id = OpenApiUtilClient.get_encode_param(team_id)
        body = {}
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        if not UtilClient.is_unset(request.notify):
            body['notify'] = request.notify
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.SaveTeamMembersResponse(),
            self.do_roarequest('SaveTeamMembers', 'doc_2.0', 'HTTP', 'PUT', 'AK', f'/v2.0/doc/teams/{team_id}/members', 'json', req, runtime)
        )

    async def save_team_members_with_options_async(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.SaveTeamMembersRequest,
        headers: dingtalkdoc__2__0_models.SaveTeamMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.SaveTeamMembersResponse:
        UtilClient.validate_model(request)
        team_id = OpenApiUtilClient.get_encode_param(team_id)
        body = {}
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        if not UtilClient.is_unset(request.notify):
            body['notify'] = request.notify
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.SaveTeamMembersResponse(),
            await self.do_roarequest_async('SaveTeamMembers', 'doc_2.0', 'HTTP', 'PUT', 'AK', f'/v2.0/doc/teams/{team_id}/members', 'json', req, runtime)
        )

    def search(
        self,
        request: dingtalkdoc__2__0_models.SearchRequest,
    ) -> dingtalkdoc__2__0_models.SearchResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.SearchHeaders()
        return self.search_with_options(request, headers, runtime)

    async def search_async(
        self,
        request: dingtalkdoc__2__0_models.SearchRequest,
    ) -> dingtalkdoc__2__0_models.SearchResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.SearchHeaders()
        return await self.search_with_options_async(request, headers, runtime)

    def search_with_options(
        self,
        request: dingtalkdoc__2__0_models.SearchRequest,
        headers: dingtalkdoc__2__0_models.SearchHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.SearchResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dentry_request):
            body['dentryRequest'] = request.dentry_request
        if not UtilClient.is_unset(request.keyword):
            body['keyword'] = request.keyword
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.space_request):
            body['spaceRequest'] = request.space_request
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.SearchResponse(),
            self.do_roarequest('Search', 'doc_2.0', 'HTTP', 'POST', 'AK', f'/v2.0/doc/search', 'json', req, runtime)
        )

    async def search_with_options_async(
        self,
        request: dingtalkdoc__2__0_models.SearchRequest,
        headers: dingtalkdoc__2__0_models.SearchHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.SearchResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dentry_request):
            body['dentryRequest'] = request.dentry_request
        if not UtilClient.is_unset(request.keyword):
            body['keyword'] = request.keyword
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.space_request):
            body['spaceRequest'] = request.space_request
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.SearchResponse(),
            await self.do_roarequest_async('Search', 'doc_2.0', 'HTTP', 'POST', 'AK', f'/v2.0/doc/search', 'json', req, runtime)
        )

    def update_team(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.UpdateTeamRequest,
    ) -> dingtalkdoc__2__0_models.UpdateTeamResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.UpdateTeamHeaders()
        return self.update_team_with_options(team_id, request, headers, runtime)

    async def update_team_async(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.UpdateTeamRequest,
    ) -> dingtalkdoc__2__0_models.UpdateTeamResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.UpdateTeamHeaders()
        return await self.update_team_with_options_async(team_id, request, headers, runtime)

    def update_team_with_options(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.UpdateTeamRequest,
        headers: dingtalkdoc__2__0_models.UpdateTeamHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.UpdateTeamResponse:
        UtilClient.validate_model(request)
        team_id = OpenApiUtilClient.get_encode_param(team_id)
        body = {}
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.UpdateTeamResponse(),
            self.do_roarequest('UpdateTeam', 'doc_2.0', 'HTTP', 'PUT', 'AK', f'/v2.0/doc/teams/{team_id}', 'json', req, runtime)
        )

    async def update_team_with_options_async(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.UpdateTeamRequest,
        headers: dingtalkdoc__2__0_models.UpdateTeamHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.UpdateTeamResponse:
        UtilClient.validate_model(request)
        team_id = OpenApiUtilClient.get_encode_param(team_id)
        body = {}
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.UpdateTeamResponse(),
            await self.do_roarequest_async('UpdateTeam', 'doc_2.0', 'HTTP', 'PUT', 'AK', f'/v2.0/doc/teams/{team_id}', 'json', req, runtime)
        )
