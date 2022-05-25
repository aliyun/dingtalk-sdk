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
