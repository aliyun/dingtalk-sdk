# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.doc_1_0 import models as dingtalkdoc__1__0_models
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

    def add_comment_with_options(
        self,
        doc_id: str,
        request: dingtalkdoc__1__0_models.AddCommentRequest,
        headers: dingtalkdoc__1__0_models.AddCommentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.AddCommentResponse:
        """
        @summary 添加评论
        
        @param request: AddCommentRequest
        @param headers: AddCommentHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddCommentResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.comment_content):
            body['commentContent'] = request.comment_content
        if not UtilClient.is_unset(request.comment_type):
            body['commentType'] = request.comment_type
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='AddComment',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/docs/{doc_id}/comments',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.AddCommentResponse(),
            self.execute(params, req, runtime)
        )

    async def add_comment_with_options_async(
        self,
        doc_id: str,
        request: dingtalkdoc__1__0_models.AddCommentRequest,
        headers: dingtalkdoc__1__0_models.AddCommentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.AddCommentResponse:
        """
        @summary 添加评论
        
        @param request: AddCommentRequest
        @param headers: AddCommentHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddCommentResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.comment_content):
            body['commentContent'] = request.comment_content
        if not UtilClient.is_unset(request.comment_type):
            body['commentType'] = request.comment_type
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='AddComment',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/docs/{doc_id}/comments',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.AddCommentResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_comment(
        self,
        doc_id: str,
        request: dingtalkdoc__1__0_models.AddCommentRequest,
    ) -> dingtalkdoc__1__0_models.AddCommentResponse:
        """
        @summary 添加评论
        
        @param request: AddCommentRequest
        @return: AddCommentResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.AddCommentHeaders()
        return self.add_comment_with_options(doc_id, request, headers, runtime)

    async def add_comment_async(
        self,
        doc_id: str,
        request: dingtalkdoc__1__0_models.AddCommentRequest,
    ) -> dingtalkdoc__1__0_models.AddCommentResponse:
        """
        @summary 添加评论
        
        @param request: AddCommentRequest
        @return: AddCommentResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.AddCommentHeaders()
        return await self.add_comment_with_options_async(doc_id, request, headers, runtime)

    def add_workspace_doc_members_with_options(
        self,
        workspace_id: str,
        node_id: str,
        request: dingtalkdoc__1__0_models.AddWorkspaceDocMembersRequest,
        headers: dingtalkdoc__1__0_models.AddWorkspaceDocMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.AddWorkspaceDocMembersResponse:
        """
        @summary 添加知识库文档成员
        
        @param request: AddWorkspaceDocMembersRequest
        @param headers: AddWorkspaceDocMembersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddWorkspaceDocMembersResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
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
        params = open_api_models.Params(
            action='AddWorkspaceDocMembers',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workspaces/{workspace_id}/docs/{node_id}/members',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.AddWorkspaceDocMembersResponse(),
            self.execute(params, req, runtime)
        )

    async def add_workspace_doc_members_with_options_async(
        self,
        workspace_id: str,
        node_id: str,
        request: dingtalkdoc__1__0_models.AddWorkspaceDocMembersRequest,
        headers: dingtalkdoc__1__0_models.AddWorkspaceDocMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.AddWorkspaceDocMembersResponse:
        """
        @summary 添加知识库文档成员
        
        @param request: AddWorkspaceDocMembersRequest
        @param headers: AddWorkspaceDocMembersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddWorkspaceDocMembersResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
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
        params = open_api_models.Params(
            action='AddWorkspaceDocMembers',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workspaces/{workspace_id}/docs/{node_id}/members',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.AddWorkspaceDocMembersResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_workspace_doc_members(
        self,
        workspace_id: str,
        node_id: str,
        request: dingtalkdoc__1__0_models.AddWorkspaceDocMembersRequest,
    ) -> dingtalkdoc__1__0_models.AddWorkspaceDocMembersResponse:
        """
        @summary 添加知识库文档成员
        
        @param request: AddWorkspaceDocMembersRequest
        @return: AddWorkspaceDocMembersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.AddWorkspaceDocMembersHeaders()
        return self.add_workspace_doc_members_with_options(workspace_id, node_id, request, headers, runtime)

    async def add_workspace_doc_members_async(
        self,
        workspace_id: str,
        node_id: str,
        request: dingtalkdoc__1__0_models.AddWorkspaceDocMembersRequest,
    ) -> dingtalkdoc__1__0_models.AddWorkspaceDocMembersResponse:
        """
        @summary 添加知识库文档成员
        
        @param request: AddWorkspaceDocMembersRequest
        @return: AddWorkspaceDocMembersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.AddWorkspaceDocMembersHeaders()
        return await self.add_workspace_doc_members_with_options_async(workspace_id, node_id, request, headers, runtime)

    def add_workspace_members_with_options(
        self,
        workspace_id: str,
        request: dingtalkdoc__1__0_models.AddWorkspaceMembersRequest,
        headers: dingtalkdoc__1__0_models.AddWorkspaceMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.AddWorkspaceMembersResponse:
        """
        @summary 添加知识库成员
        
        @param request: AddWorkspaceMembersRequest
        @param headers: AddWorkspaceMembersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddWorkspaceMembersResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
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
        params = open_api_models.Params(
            action='AddWorkspaceMembers',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workspaces/{workspace_id}/members',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.AddWorkspaceMembersResponse(),
            self.execute(params, req, runtime)
        )

    async def add_workspace_members_with_options_async(
        self,
        workspace_id: str,
        request: dingtalkdoc__1__0_models.AddWorkspaceMembersRequest,
        headers: dingtalkdoc__1__0_models.AddWorkspaceMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.AddWorkspaceMembersResponse:
        """
        @summary 添加知识库成员
        
        @param request: AddWorkspaceMembersRequest
        @param headers: AddWorkspaceMembersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddWorkspaceMembersResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
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
        params = open_api_models.Params(
            action='AddWorkspaceMembers',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workspaces/{workspace_id}/members',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.AddWorkspaceMembersResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_workspace_members(
        self,
        workspace_id: str,
        request: dingtalkdoc__1__0_models.AddWorkspaceMembersRequest,
    ) -> dingtalkdoc__1__0_models.AddWorkspaceMembersResponse:
        """
        @summary 添加知识库成员
        
        @param request: AddWorkspaceMembersRequest
        @return: AddWorkspaceMembersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.AddWorkspaceMembersHeaders()
        return self.add_workspace_members_with_options(workspace_id, request, headers, runtime)

    async def add_workspace_members_async(
        self,
        workspace_id: str,
        request: dingtalkdoc__1__0_models.AddWorkspaceMembersRequest,
    ) -> dingtalkdoc__1__0_models.AddWorkspaceMembersResponse:
        """
        @summary 添加知识库成员
        
        @param request: AddWorkspaceMembersRequest
        @return: AddWorkspaceMembersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.AddWorkspaceMembersHeaders()
        return await self.add_workspace_members_with_options_async(workspace_id, request, headers, runtime)

    def append_rows_with_options(
        self,
        workbook_id: str,
        sheet_id: str,
        request: dingtalkdoc__1__0_models.AppendRowsRequest,
        headers: dingtalkdoc__1__0_models.AppendRowsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.AppendRowsResponse:
        """
        @summary 追加行
        
        @param request: AppendRowsRequest
        @param headers: AppendRowsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AppendRowsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.values):
            body['values'] = request.values
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='AppendRows',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/sheets/{sheet_id}/appendRows',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.AppendRowsResponse(),
            self.execute(params, req, runtime)
        )

    async def append_rows_with_options_async(
        self,
        workbook_id: str,
        sheet_id: str,
        request: dingtalkdoc__1__0_models.AppendRowsRequest,
        headers: dingtalkdoc__1__0_models.AppendRowsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.AppendRowsResponse:
        """
        @summary 追加行
        
        @param request: AppendRowsRequest
        @param headers: AppendRowsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AppendRowsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.values):
            body['values'] = request.values
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='AppendRows',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/sheets/{sheet_id}/appendRows',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.AppendRowsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def append_rows(
        self,
        workbook_id: str,
        sheet_id: str,
        request: dingtalkdoc__1__0_models.AppendRowsRequest,
    ) -> dingtalkdoc__1__0_models.AppendRowsResponse:
        """
        @summary 追加行
        
        @param request: AppendRowsRequest
        @return: AppendRowsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.AppendRowsHeaders()
        return self.append_rows_with_options(workbook_id, sheet_id, request, headers, runtime)

    async def append_rows_async(
        self,
        workbook_id: str,
        sheet_id: str,
        request: dingtalkdoc__1__0_models.AppendRowsRequest,
    ) -> dingtalkdoc__1__0_models.AppendRowsResponse:
        """
        @summary 追加行
        
        @param request: AppendRowsRequest
        @return: AppendRowsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.AppendRowsHeaders()
        return await self.append_rows_with_options_async(workbook_id, sheet_id, request, headers, runtime)

    def batch_with_options(
        self,
        workbook_id: str,
        request: dingtalkdoc__1__0_models.BatchRequest,
        headers: dingtalkdoc__1__0_models.BatchHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.BatchResponse:
        """
        @summary 批量执行表格操作
        
        @param request: BatchRequest
        @param headers: BatchHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.requests):
            body['requests'] = request.requests
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='Batch',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/batch',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.BatchResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_with_options_async(
        self,
        workbook_id: str,
        request: dingtalkdoc__1__0_models.BatchRequest,
        headers: dingtalkdoc__1__0_models.BatchHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.BatchResponse:
        """
        @summary 批量执行表格操作
        
        @param request: BatchRequest
        @param headers: BatchHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.requests):
            body['requests'] = request.requests
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='Batch',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/batch',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.BatchResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch(
        self,
        workbook_id: str,
        request: dingtalkdoc__1__0_models.BatchRequest,
    ) -> dingtalkdoc__1__0_models.BatchResponse:
        """
        @summary 批量执行表格操作
        
        @param request: BatchRequest
        @return: BatchResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.BatchHeaders()
        return self.batch_with_options(workbook_id, request, headers, runtime)

    async def batch_async(
        self,
        workbook_id: str,
        request: dingtalkdoc__1__0_models.BatchRequest,
    ) -> dingtalkdoc__1__0_models.BatchResponse:
        """
        @summary 批量执行表格操作
        
        @param request: BatchRequest
        @return: BatchResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.BatchHeaders()
        return await self.batch_with_options_async(workbook_id, request, headers, runtime)

    def batch_get_workspace_docs_with_options(
        self,
        request: dingtalkdoc__1__0_models.BatchGetWorkspaceDocsRequest,
        headers: dingtalkdoc__1__0_models.BatchGetWorkspaceDocsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.BatchGetWorkspaceDocsResponse:
        """
        @summary 批量查询知识库文档
        
        @param request: BatchGetWorkspaceDocsRequest
        @param headers: BatchGetWorkspaceDocsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchGetWorkspaceDocsResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.node_ids):
            body['nodeIds'] = request.node_ids
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
        params = open_api_models.Params(
            action='BatchGetWorkspaceDocs',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workspaces/docs/infos/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.BatchGetWorkspaceDocsResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_get_workspace_docs_with_options_async(
        self,
        request: dingtalkdoc__1__0_models.BatchGetWorkspaceDocsRequest,
        headers: dingtalkdoc__1__0_models.BatchGetWorkspaceDocsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.BatchGetWorkspaceDocsResponse:
        """
        @summary 批量查询知识库文档
        
        @param request: BatchGetWorkspaceDocsRequest
        @param headers: BatchGetWorkspaceDocsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchGetWorkspaceDocsResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.node_ids):
            body['nodeIds'] = request.node_ids
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
        params = open_api_models.Params(
            action='BatchGetWorkspaceDocs',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workspaces/docs/infos/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.BatchGetWorkspaceDocsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch_get_workspace_docs(
        self,
        request: dingtalkdoc__1__0_models.BatchGetWorkspaceDocsRequest,
    ) -> dingtalkdoc__1__0_models.BatchGetWorkspaceDocsResponse:
        """
        @summary 批量查询知识库文档
        
        @param request: BatchGetWorkspaceDocsRequest
        @return: BatchGetWorkspaceDocsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.BatchGetWorkspaceDocsHeaders()
        return self.batch_get_workspace_docs_with_options(request, headers, runtime)

    async def batch_get_workspace_docs_async(
        self,
        request: dingtalkdoc__1__0_models.BatchGetWorkspaceDocsRequest,
    ) -> dingtalkdoc__1__0_models.BatchGetWorkspaceDocsResponse:
        """
        @summary 批量查询知识库文档
        
        @param request: BatchGetWorkspaceDocsRequest
        @return: BatchGetWorkspaceDocsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.BatchGetWorkspaceDocsHeaders()
        return await self.batch_get_workspace_docs_with_options_async(request, headers, runtime)

    def batch_get_workspaces_with_options(
        self,
        request: dingtalkdoc__1__0_models.BatchGetWorkspacesRequest,
        headers: dingtalkdoc__1__0_models.BatchGetWorkspacesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.BatchGetWorkspacesResponse:
        """
        @summary 知识库批量查询
        
        @param request: BatchGetWorkspacesRequest
        @param headers: BatchGetWorkspacesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchGetWorkspacesResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.include_recent):
            body['includeRecent'] = request.include_recent
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.workspace_ids):
            body['workspaceIds'] = request.workspace_ids
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
            action='BatchGetWorkspaces',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workspaces/infos/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.BatchGetWorkspacesResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_get_workspaces_with_options_async(
        self,
        request: dingtalkdoc__1__0_models.BatchGetWorkspacesRequest,
        headers: dingtalkdoc__1__0_models.BatchGetWorkspacesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.BatchGetWorkspacesResponse:
        """
        @summary 知识库批量查询
        
        @param request: BatchGetWorkspacesRequest
        @param headers: BatchGetWorkspacesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchGetWorkspacesResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.include_recent):
            body['includeRecent'] = request.include_recent
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.workspace_ids):
            body['workspaceIds'] = request.workspace_ids
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
            action='BatchGetWorkspaces',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workspaces/infos/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.BatchGetWorkspacesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch_get_workspaces(
        self,
        request: dingtalkdoc__1__0_models.BatchGetWorkspacesRequest,
    ) -> dingtalkdoc__1__0_models.BatchGetWorkspacesResponse:
        """
        @summary 知识库批量查询
        
        @param request: BatchGetWorkspacesRequest
        @return: BatchGetWorkspacesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.BatchGetWorkspacesHeaders()
        return self.batch_get_workspaces_with_options(request, headers, runtime)

    async def batch_get_workspaces_async(
        self,
        request: dingtalkdoc__1__0_models.BatchGetWorkspacesRequest,
    ) -> dingtalkdoc__1__0_models.BatchGetWorkspacesResponse:
        """
        @summary 知识库批量查询
        
        @param request: BatchGetWorkspacesRequest
        @return: BatchGetWorkspacesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.BatchGetWorkspacesHeaders()
        return await self.batch_get_workspaces_with_options_async(request, headers, runtime)

    def bind_cool_app_to_sheet_with_options(
        self,
        workbook_id: str,
        request: dingtalkdoc__1__0_models.BindCoolAppToSheetRequest,
        headers: dingtalkdoc__1__0_models.BindCoolAppToSheetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.BindCoolAppToSheetResponse:
        """
        @summary 关联文档酷应用到表格
        
        @param request: BindCoolAppToSheetRequest
        @param headers: BindCoolAppToSheetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BindCoolAppToSheetResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.cool_app_code):
            body['coolAppCode'] = request.cool_app_code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='BindCoolAppToSheet',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/coolApps',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.BindCoolAppToSheetResponse(),
            self.execute(params, req, runtime)
        )

    async def bind_cool_app_to_sheet_with_options_async(
        self,
        workbook_id: str,
        request: dingtalkdoc__1__0_models.BindCoolAppToSheetRequest,
        headers: dingtalkdoc__1__0_models.BindCoolAppToSheetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.BindCoolAppToSheetResponse:
        """
        @summary 关联文档酷应用到表格
        
        @param request: BindCoolAppToSheetRequest
        @param headers: BindCoolAppToSheetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BindCoolAppToSheetResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.cool_app_code):
            body['coolAppCode'] = request.cool_app_code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='BindCoolAppToSheet',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/coolApps',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.BindCoolAppToSheetResponse(),
            await self.execute_async(params, req, runtime)
        )

    def bind_cool_app_to_sheet(
        self,
        workbook_id: str,
        request: dingtalkdoc__1__0_models.BindCoolAppToSheetRequest,
    ) -> dingtalkdoc__1__0_models.BindCoolAppToSheetResponse:
        """
        @summary 关联文档酷应用到表格
        
        @param request: BindCoolAppToSheetRequest
        @return: BindCoolAppToSheetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.BindCoolAppToSheetHeaders()
        return self.bind_cool_app_to_sheet_with_options(workbook_id, request, headers, runtime)

    async def bind_cool_app_to_sheet_async(
        self,
        workbook_id: str,
        request: dingtalkdoc__1__0_models.BindCoolAppToSheetRequest,
    ) -> dingtalkdoc__1__0_models.BindCoolAppToSheetResponse:
        """
        @summary 关联文档酷应用到表格
        
        @param request: BindCoolAppToSheetRequest
        @return: BindCoolAppToSheetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.BindCoolAppToSheetHeaders()
        return await self.bind_cool_app_to_sheet_with_options_async(workbook_id, request, headers, runtime)

    def clear_with_options(
        self,
        workbook_id: str,
        sheet_id: str,
        range_address: str,
        request: dingtalkdoc__1__0_models.ClearRequest,
        headers: dingtalkdoc__1__0_models.ClearHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.ClearResponse:
        """
        @summary 清除单元格区域内所有内容
        
        @param request: ClearRequest
        @param headers: ClearHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ClearResponse
        """
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
        params = open_api_models.Params(
            action='Clear',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/sheets/{sheet_id}/ranges/{range_address}/clear',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.ClearResponse(),
            self.execute(params, req, runtime)
        )

    async def clear_with_options_async(
        self,
        workbook_id: str,
        sheet_id: str,
        range_address: str,
        request: dingtalkdoc__1__0_models.ClearRequest,
        headers: dingtalkdoc__1__0_models.ClearHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.ClearResponse:
        """
        @summary 清除单元格区域内所有内容
        
        @param request: ClearRequest
        @param headers: ClearHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ClearResponse
        """
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
        params = open_api_models.Params(
            action='Clear',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/sheets/{sheet_id}/ranges/{range_address}/clear',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.ClearResponse(),
            await self.execute_async(params, req, runtime)
        )

    def clear(
        self,
        workbook_id: str,
        sheet_id: str,
        range_address: str,
        request: dingtalkdoc__1__0_models.ClearRequest,
    ) -> dingtalkdoc__1__0_models.ClearResponse:
        """
        @summary 清除单元格区域内所有内容
        
        @param request: ClearRequest
        @return: ClearResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.ClearHeaders()
        return self.clear_with_options(workbook_id, sheet_id, range_address, request, headers, runtime)

    async def clear_async(
        self,
        workbook_id: str,
        sheet_id: str,
        range_address: str,
        request: dingtalkdoc__1__0_models.ClearRequest,
    ) -> dingtalkdoc__1__0_models.ClearResponse:
        """
        @summary 清除单元格区域内所有内容
        
        @param request: ClearRequest
        @return: ClearResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.ClearHeaders()
        return await self.clear_with_options_async(workbook_id, sheet_id, range_address, request, headers, runtime)

    def clear_data_with_options(
        self,
        workbook_id: str,
        sheet_id: str,
        range_address: str,
        request: dingtalkdoc__1__0_models.ClearDataRequest,
        headers: dingtalkdoc__1__0_models.ClearDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.ClearDataResponse:
        """
        @summary 清除单元格区域内数据
        
        @param request: ClearDataRequest
        @param headers: ClearDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ClearDataResponse
        """
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
        params = open_api_models.Params(
            action='ClearData',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/sheets/{sheet_id}/ranges/{range_address}/clearData',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.ClearDataResponse(),
            self.execute(params, req, runtime)
        )

    async def clear_data_with_options_async(
        self,
        workbook_id: str,
        sheet_id: str,
        range_address: str,
        request: dingtalkdoc__1__0_models.ClearDataRequest,
        headers: dingtalkdoc__1__0_models.ClearDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.ClearDataResponse:
        """
        @summary 清除单元格区域内数据
        
        @param request: ClearDataRequest
        @param headers: ClearDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ClearDataResponse
        """
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
        params = open_api_models.Params(
            action='ClearData',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/sheets/{sheet_id}/ranges/{range_address}/clearData',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.ClearDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def clear_data(
        self,
        workbook_id: str,
        sheet_id: str,
        range_address: str,
        request: dingtalkdoc__1__0_models.ClearDataRequest,
    ) -> dingtalkdoc__1__0_models.ClearDataResponse:
        """
        @summary 清除单元格区域内数据
        
        @param request: ClearDataRequest
        @return: ClearDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.ClearDataHeaders()
        return self.clear_data_with_options(workbook_id, sheet_id, range_address, request, headers, runtime)

    async def clear_data_async(
        self,
        workbook_id: str,
        sheet_id: str,
        range_address: str,
        request: dingtalkdoc__1__0_models.ClearDataRequest,
    ) -> dingtalkdoc__1__0_models.ClearDataResponse:
        """
        @summary 清除单元格区域内数据
        
        @param request: ClearDataRequest
        @return: ClearDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.ClearDataHeaders()
        return await self.clear_data_with_options_async(workbook_id, sheet_id, range_address, request, headers, runtime)

    def create_conditional_formatting_rule_with_options(
        self,
        workbook_id: str,
        sheet_id: str,
        request: dingtalkdoc__1__0_models.CreateConditionalFormattingRuleRequest,
        headers: dingtalkdoc__1__0_models.CreateConditionalFormattingRuleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.CreateConditionalFormattingRuleResponse:
        """
        @summary 创建条件格式
        
        @param request: CreateConditionalFormattingRuleRequest
        @param headers: CreateConditionalFormattingRuleHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateConditionalFormattingRuleResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.cell_style):
            body['cellStyle'] = request.cell_style
        if not UtilClient.is_unset(request.duplicate_condition):
            body['duplicateCondition'] = request.duplicate_condition
        if not UtilClient.is_unset(request.ranges):
            body['ranges'] = request.ranges
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateConditionalFormattingRule',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/sheets/{sheet_id}/conditionalFormattingRules',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.CreateConditionalFormattingRuleResponse(),
            self.execute(params, req, runtime)
        )

    async def create_conditional_formatting_rule_with_options_async(
        self,
        workbook_id: str,
        sheet_id: str,
        request: dingtalkdoc__1__0_models.CreateConditionalFormattingRuleRequest,
        headers: dingtalkdoc__1__0_models.CreateConditionalFormattingRuleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.CreateConditionalFormattingRuleResponse:
        """
        @summary 创建条件格式
        
        @param request: CreateConditionalFormattingRuleRequest
        @param headers: CreateConditionalFormattingRuleHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateConditionalFormattingRuleResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.cell_style):
            body['cellStyle'] = request.cell_style
        if not UtilClient.is_unset(request.duplicate_condition):
            body['duplicateCondition'] = request.duplicate_condition
        if not UtilClient.is_unset(request.ranges):
            body['ranges'] = request.ranges
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateConditionalFormattingRule',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/sheets/{sheet_id}/conditionalFormattingRules',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.CreateConditionalFormattingRuleResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_conditional_formatting_rule(
        self,
        workbook_id: str,
        sheet_id: str,
        request: dingtalkdoc__1__0_models.CreateConditionalFormattingRuleRequest,
    ) -> dingtalkdoc__1__0_models.CreateConditionalFormattingRuleResponse:
        """
        @summary 创建条件格式
        
        @param request: CreateConditionalFormattingRuleRequest
        @return: CreateConditionalFormattingRuleResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.CreateConditionalFormattingRuleHeaders()
        return self.create_conditional_formatting_rule_with_options(workbook_id, sheet_id, request, headers, runtime)

    async def create_conditional_formatting_rule_async(
        self,
        workbook_id: str,
        sheet_id: str,
        request: dingtalkdoc__1__0_models.CreateConditionalFormattingRuleRequest,
    ) -> dingtalkdoc__1__0_models.CreateConditionalFormattingRuleResponse:
        """
        @summary 创建条件格式
        
        @param request: CreateConditionalFormattingRuleRequest
        @return: CreateConditionalFormattingRuleResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.CreateConditionalFormattingRuleHeaders()
        return await self.create_conditional_formatting_rule_with_options_async(workbook_id, sheet_id, request, headers, runtime)

    def create_developer_metadata_with_options(
        self,
        workbook_id: str,
        request: dingtalkdoc__1__0_models.CreateDeveloperMetadataRequest,
        headers: dingtalkdoc__1__0_models.CreateDeveloperMetadataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.CreateDeveloperMetadataResponse:
        """
        @summary 创建开发者元数据
        
        @param request: CreateDeveloperMetadataRequest
        @param headers: CreateDeveloperMetadataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateDeveloperMetadataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.associated_column):
            body['associatedColumn'] = request.associated_column
        if not UtilClient.is_unset(request.associated_row):
            body['associatedRow'] = request.associated_row
        if not UtilClient.is_unset(request.value):
            body['value'] = request.value
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateDeveloperMetadata',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/developerMetadatas',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.CreateDeveloperMetadataResponse(),
            self.execute(params, req, runtime)
        )

    async def create_developer_metadata_with_options_async(
        self,
        workbook_id: str,
        request: dingtalkdoc__1__0_models.CreateDeveloperMetadataRequest,
        headers: dingtalkdoc__1__0_models.CreateDeveloperMetadataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.CreateDeveloperMetadataResponse:
        """
        @summary 创建开发者元数据
        
        @param request: CreateDeveloperMetadataRequest
        @param headers: CreateDeveloperMetadataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateDeveloperMetadataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.associated_column):
            body['associatedColumn'] = request.associated_column
        if not UtilClient.is_unset(request.associated_row):
            body['associatedRow'] = request.associated_row
        if not UtilClient.is_unset(request.value):
            body['value'] = request.value
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateDeveloperMetadata',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/developerMetadatas',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.CreateDeveloperMetadataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_developer_metadata(
        self,
        workbook_id: str,
        request: dingtalkdoc__1__0_models.CreateDeveloperMetadataRequest,
    ) -> dingtalkdoc__1__0_models.CreateDeveloperMetadataResponse:
        """
        @summary 创建开发者元数据
        
        @param request: CreateDeveloperMetadataRequest
        @return: CreateDeveloperMetadataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.CreateDeveloperMetadataHeaders()
        return self.create_developer_metadata_with_options(workbook_id, request, headers, runtime)

    async def create_developer_metadata_async(
        self,
        workbook_id: str,
        request: dingtalkdoc__1__0_models.CreateDeveloperMetadataRequest,
    ) -> dingtalkdoc__1__0_models.CreateDeveloperMetadataResponse:
        """
        @summary 创建开发者元数据
        
        @param request: CreateDeveloperMetadataRequest
        @return: CreateDeveloperMetadataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.CreateDeveloperMetadataHeaders()
        return await self.create_developer_metadata_with_options_async(workbook_id, request, headers, runtime)

    def create_range_protection_with_options(
        self,
        workbook_id: str,
        sheet_id: str,
        range_address: str,
        request: dingtalkdoc__1__0_models.CreateRangeProtectionRequest,
        headers: dingtalkdoc__1__0_models.CreateRangeProtectionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.CreateRangeProtectionResponse:
        """
        @summary 创建单元格锁定
        
        @param request: CreateRangeProtectionRequest
        @param headers: CreateRangeProtectionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateRangeProtectionResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.editable_setting):
            body['editableSetting'] = request.editable_setting
        if not UtilClient.is_unset(request.other_user_permission):
            body['otherUserPermission'] = request.other_user_permission
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateRangeProtection',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/sheets/{sheet_id}/ranges/{range_address}/protections',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.CreateRangeProtectionResponse(),
            self.execute(params, req, runtime)
        )

    async def create_range_protection_with_options_async(
        self,
        workbook_id: str,
        sheet_id: str,
        range_address: str,
        request: dingtalkdoc__1__0_models.CreateRangeProtectionRequest,
        headers: dingtalkdoc__1__0_models.CreateRangeProtectionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.CreateRangeProtectionResponse:
        """
        @summary 创建单元格锁定
        
        @param request: CreateRangeProtectionRequest
        @param headers: CreateRangeProtectionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateRangeProtectionResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.editable_setting):
            body['editableSetting'] = request.editable_setting
        if not UtilClient.is_unset(request.other_user_permission):
            body['otherUserPermission'] = request.other_user_permission
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateRangeProtection',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/sheets/{sheet_id}/ranges/{range_address}/protections',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.CreateRangeProtectionResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_range_protection(
        self,
        workbook_id: str,
        sheet_id: str,
        range_address: str,
        request: dingtalkdoc__1__0_models.CreateRangeProtectionRequest,
    ) -> dingtalkdoc__1__0_models.CreateRangeProtectionResponse:
        """
        @summary 创建单元格锁定
        
        @param request: CreateRangeProtectionRequest
        @return: CreateRangeProtectionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.CreateRangeProtectionHeaders()
        return self.create_range_protection_with_options(workbook_id, sheet_id, range_address, request, headers, runtime)

    async def create_range_protection_async(
        self,
        workbook_id: str,
        sheet_id: str,
        range_address: str,
        request: dingtalkdoc__1__0_models.CreateRangeProtectionRequest,
    ) -> dingtalkdoc__1__0_models.CreateRangeProtectionResponse:
        """
        @summary 创建单元格锁定
        
        @param request: CreateRangeProtectionRequest
        @return: CreateRangeProtectionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.CreateRangeProtectionHeaders()
        return await self.create_range_protection_with_options_async(workbook_id, sheet_id, range_address, request, headers, runtime)

    def create_sheet_with_options(
        self,
        workbook_id: str,
        request: dingtalkdoc__1__0_models.CreateSheetRequest,
        headers: dingtalkdoc__1__0_models.CreateSheetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.CreateSheetResponse:
        """
        @summary 创建工作表
        
        @param request: CreateSheetRequest
        @param headers: CreateSheetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateSheetResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateSheet',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/sheets',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.CreateSheetResponse(),
            self.execute(params, req, runtime)
        )

    async def create_sheet_with_options_async(
        self,
        workbook_id: str,
        request: dingtalkdoc__1__0_models.CreateSheetRequest,
        headers: dingtalkdoc__1__0_models.CreateSheetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.CreateSheetResponse:
        """
        @summary 创建工作表
        
        @param request: CreateSheetRequest
        @param headers: CreateSheetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateSheetResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateSheet',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/sheets',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.CreateSheetResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_sheet(
        self,
        workbook_id: str,
        request: dingtalkdoc__1__0_models.CreateSheetRequest,
    ) -> dingtalkdoc__1__0_models.CreateSheetResponse:
        """
        @summary 创建工作表
        
        @param request: CreateSheetRequest
        @return: CreateSheetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.CreateSheetHeaders()
        return self.create_sheet_with_options(workbook_id, request, headers, runtime)

    async def create_sheet_async(
        self,
        workbook_id: str,
        request: dingtalkdoc__1__0_models.CreateSheetRequest,
    ) -> dingtalkdoc__1__0_models.CreateSheetResponse:
        """
        @summary 创建工作表
        
        @param request: CreateSheetRequest
        @return: CreateSheetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.CreateSheetHeaders()
        return await self.create_sheet_with_options_async(workbook_id, request, headers, runtime)

    def create_workspace_with_options(
        self,
        request: dingtalkdoc__1__0_models.CreateWorkspaceRequest,
        headers: dingtalkdoc__1__0_models.CreateWorkspaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.CreateWorkspaceResponse:
        """
        @summary 新建知识库
        
        @param request: CreateWorkspaceRequest
        @param headers: CreateWorkspaceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateWorkspaceResponse
        """
        UtilClient.validate_model(request)
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
        params = open_api_models.Params(
            action='CreateWorkspace',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workspaces',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.CreateWorkspaceResponse(),
            self.execute(params, req, runtime)
        )

    async def create_workspace_with_options_async(
        self,
        request: dingtalkdoc__1__0_models.CreateWorkspaceRequest,
        headers: dingtalkdoc__1__0_models.CreateWorkspaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.CreateWorkspaceResponse:
        """
        @summary 新建知识库
        
        @param request: CreateWorkspaceRequest
        @param headers: CreateWorkspaceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateWorkspaceResponse
        """
        UtilClient.validate_model(request)
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
        params = open_api_models.Params(
            action='CreateWorkspace',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workspaces',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.CreateWorkspaceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_workspace(
        self,
        request: dingtalkdoc__1__0_models.CreateWorkspaceRequest,
    ) -> dingtalkdoc__1__0_models.CreateWorkspaceResponse:
        """
        @summary 新建知识库
        
        @param request: CreateWorkspaceRequest
        @return: CreateWorkspaceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.CreateWorkspaceHeaders()
        return self.create_workspace_with_options(request, headers, runtime)

    async def create_workspace_async(
        self,
        request: dingtalkdoc__1__0_models.CreateWorkspaceRequest,
    ) -> dingtalkdoc__1__0_models.CreateWorkspaceResponse:
        """
        @summary 新建知识库
        
        @param request: CreateWorkspaceRequest
        @return: CreateWorkspaceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.CreateWorkspaceHeaders()
        return await self.create_workspace_with_options_async(request, headers, runtime)

    def create_workspace_doc_with_options(
        self,
        workspace_id: str,
        request: dingtalkdoc__1__0_models.CreateWorkspaceDocRequest,
        headers: dingtalkdoc__1__0_models.CreateWorkspaceDocHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.CreateWorkspaceDocResponse:
        """
        @summary 创建知识库文档
        
        @param request: CreateWorkspaceDocRequest
        @param headers: CreateWorkspaceDocHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateWorkspaceDocResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.doc_type):
            body['docType'] = request.doc_type
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.parent_node_id):
            body['parentNodeId'] = request.parent_node_id
        if not UtilClient.is_unset(request.template_id):
            body['templateId'] = request.template_id
        if not UtilClient.is_unset(request.template_type):
            body['templateType'] = request.template_type
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
            action='CreateWorkspaceDoc',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workspaces/{workspace_id}/docs',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.CreateWorkspaceDocResponse(),
            self.execute(params, req, runtime)
        )

    async def create_workspace_doc_with_options_async(
        self,
        workspace_id: str,
        request: dingtalkdoc__1__0_models.CreateWorkspaceDocRequest,
        headers: dingtalkdoc__1__0_models.CreateWorkspaceDocHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.CreateWorkspaceDocResponse:
        """
        @summary 创建知识库文档
        
        @param request: CreateWorkspaceDocRequest
        @param headers: CreateWorkspaceDocHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateWorkspaceDocResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.doc_type):
            body['docType'] = request.doc_type
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.parent_node_id):
            body['parentNodeId'] = request.parent_node_id
        if not UtilClient.is_unset(request.template_id):
            body['templateId'] = request.template_id
        if not UtilClient.is_unset(request.template_type):
            body['templateType'] = request.template_type
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
            action='CreateWorkspaceDoc',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workspaces/{workspace_id}/docs',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.CreateWorkspaceDocResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_workspace_doc(
        self,
        workspace_id: str,
        request: dingtalkdoc__1__0_models.CreateWorkspaceDocRequest,
    ) -> dingtalkdoc__1__0_models.CreateWorkspaceDocResponse:
        """
        @summary 创建知识库文档
        
        @param request: CreateWorkspaceDocRequest
        @return: CreateWorkspaceDocResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.CreateWorkspaceDocHeaders()
        return self.create_workspace_doc_with_options(workspace_id, request, headers, runtime)

    async def create_workspace_doc_async(
        self,
        workspace_id: str,
        request: dingtalkdoc__1__0_models.CreateWorkspaceDocRequest,
    ) -> dingtalkdoc__1__0_models.CreateWorkspaceDocResponse:
        """
        @summary 创建知识库文档
        
        @param request: CreateWorkspaceDocRequest
        @return: CreateWorkspaceDocResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.CreateWorkspaceDocHeaders()
        return await self.create_workspace_doc_with_options_async(workspace_id, request, headers, runtime)

    def delete_columns_with_options(
        self,
        workbook_id: str,
        sheet_id: str,
        request: dingtalkdoc__1__0_models.DeleteColumnsRequest,
        headers: dingtalkdoc__1__0_models.DeleteColumnsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.DeleteColumnsResponse:
        """
        @summary 删除列
        
        @param request: DeleteColumnsRequest
        @param headers: DeleteColumnsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteColumnsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.column):
            body['column'] = request.column
        if not UtilClient.is_unset(request.column_count):
            body['columnCount'] = request.column_count
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='DeleteColumns',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/sheets/{sheet_id}/deleteColumns',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.DeleteColumnsResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_columns_with_options_async(
        self,
        workbook_id: str,
        sheet_id: str,
        request: dingtalkdoc__1__0_models.DeleteColumnsRequest,
        headers: dingtalkdoc__1__0_models.DeleteColumnsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.DeleteColumnsResponse:
        """
        @summary 删除列
        
        @param request: DeleteColumnsRequest
        @param headers: DeleteColumnsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteColumnsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.column):
            body['column'] = request.column
        if not UtilClient.is_unset(request.column_count):
            body['columnCount'] = request.column_count
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='DeleteColumns',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/sheets/{sheet_id}/deleteColumns',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.DeleteColumnsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_columns(
        self,
        workbook_id: str,
        sheet_id: str,
        request: dingtalkdoc__1__0_models.DeleteColumnsRequest,
    ) -> dingtalkdoc__1__0_models.DeleteColumnsResponse:
        """
        @summary 删除列
        
        @param request: DeleteColumnsRequest
        @return: DeleteColumnsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.DeleteColumnsHeaders()
        return self.delete_columns_with_options(workbook_id, sheet_id, request, headers, runtime)

    async def delete_columns_async(
        self,
        workbook_id: str,
        sheet_id: str,
        request: dingtalkdoc__1__0_models.DeleteColumnsRequest,
    ) -> dingtalkdoc__1__0_models.DeleteColumnsResponse:
        """
        @summary 删除列
        
        @param request: DeleteColumnsRequest
        @return: DeleteColumnsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.DeleteColumnsHeaders()
        return await self.delete_columns_with_options_async(workbook_id, sheet_id, request, headers, runtime)

    def delete_dropdown_lists_with_options(
        self,
        workbook_id: str,
        sheet_id: str,
        range_address: str,
        request: dingtalkdoc__1__0_models.DeleteDropdownListsRequest,
        headers: dingtalkdoc__1__0_models.DeleteDropdownListsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.DeleteDropdownListsResponse:
        """
        @summary 删除下拉列表
        
        @param request: DeleteDropdownListsRequest
        @param headers: DeleteDropdownListsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteDropdownListsResponse
        """
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
        params = open_api_models.Params(
            action='DeleteDropdownLists',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/sheets/{sheet_id}/ranges/{range_address}/deleteDropdownLists',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.DeleteDropdownListsResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_dropdown_lists_with_options_async(
        self,
        workbook_id: str,
        sheet_id: str,
        range_address: str,
        request: dingtalkdoc__1__0_models.DeleteDropdownListsRequest,
        headers: dingtalkdoc__1__0_models.DeleteDropdownListsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.DeleteDropdownListsResponse:
        """
        @summary 删除下拉列表
        
        @param request: DeleteDropdownListsRequest
        @param headers: DeleteDropdownListsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteDropdownListsResponse
        """
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
        params = open_api_models.Params(
            action='DeleteDropdownLists',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/sheets/{sheet_id}/ranges/{range_address}/deleteDropdownLists',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.DeleteDropdownListsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_dropdown_lists(
        self,
        workbook_id: str,
        sheet_id: str,
        range_address: str,
        request: dingtalkdoc__1__0_models.DeleteDropdownListsRequest,
    ) -> dingtalkdoc__1__0_models.DeleteDropdownListsResponse:
        """
        @summary 删除下拉列表
        
        @param request: DeleteDropdownListsRequest
        @return: DeleteDropdownListsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.DeleteDropdownListsHeaders()
        return self.delete_dropdown_lists_with_options(workbook_id, sheet_id, range_address, request, headers, runtime)

    async def delete_dropdown_lists_async(
        self,
        workbook_id: str,
        sheet_id: str,
        range_address: str,
        request: dingtalkdoc__1__0_models.DeleteDropdownListsRequest,
    ) -> dingtalkdoc__1__0_models.DeleteDropdownListsResponse:
        """
        @summary 删除下拉列表
        
        @param request: DeleteDropdownListsRequest
        @return: DeleteDropdownListsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.DeleteDropdownListsHeaders()
        return await self.delete_dropdown_lists_with_options_async(workbook_id, sheet_id, range_address, request, headers, runtime)

    def delete_range_protection_with_options(
        self,
        workbook_id: str,
        sheet_id: str,
        range_address: str,
        protection_id: str,
        request: dingtalkdoc__1__0_models.DeleteRangeProtectionRequest,
        headers: dingtalkdoc__1__0_models.DeleteRangeProtectionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.DeleteRangeProtectionResponse:
        """
        @summary 删除单元格锁定
        
        @param request: DeleteRangeProtectionRequest
        @param headers: DeleteRangeProtectionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteRangeProtectionResponse
        """
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
        params = open_api_models.Params(
            action='DeleteRangeProtection',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/sheets/{sheet_id}/ranges/{range_address}/protections/{protection_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.DeleteRangeProtectionResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_range_protection_with_options_async(
        self,
        workbook_id: str,
        sheet_id: str,
        range_address: str,
        protection_id: str,
        request: dingtalkdoc__1__0_models.DeleteRangeProtectionRequest,
        headers: dingtalkdoc__1__0_models.DeleteRangeProtectionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.DeleteRangeProtectionResponse:
        """
        @summary 删除单元格锁定
        
        @param request: DeleteRangeProtectionRequest
        @param headers: DeleteRangeProtectionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteRangeProtectionResponse
        """
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
        params = open_api_models.Params(
            action='DeleteRangeProtection',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/sheets/{sheet_id}/ranges/{range_address}/protections/{protection_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.DeleteRangeProtectionResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_range_protection(
        self,
        workbook_id: str,
        sheet_id: str,
        range_address: str,
        protection_id: str,
        request: dingtalkdoc__1__0_models.DeleteRangeProtectionRequest,
    ) -> dingtalkdoc__1__0_models.DeleteRangeProtectionResponse:
        """
        @summary 删除单元格锁定
        
        @param request: DeleteRangeProtectionRequest
        @return: DeleteRangeProtectionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.DeleteRangeProtectionHeaders()
        return self.delete_range_protection_with_options(workbook_id, sheet_id, range_address, protection_id, request, headers, runtime)

    async def delete_range_protection_async(
        self,
        workbook_id: str,
        sheet_id: str,
        range_address: str,
        protection_id: str,
        request: dingtalkdoc__1__0_models.DeleteRangeProtectionRequest,
    ) -> dingtalkdoc__1__0_models.DeleteRangeProtectionResponse:
        """
        @summary 删除单元格锁定
        
        @param request: DeleteRangeProtectionRequest
        @return: DeleteRangeProtectionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.DeleteRangeProtectionHeaders()
        return await self.delete_range_protection_with_options_async(workbook_id, sheet_id, range_address, protection_id, request, headers, runtime)

    def delete_rows_with_options(
        self,
        workbook_id: str,
        sheet_id: str,
        request: dingtalkdoc__1__0_models.DeleteRowsRequest,
        headers: dingtalkdoc__1__0_models.DeleteRowsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.DeleteRowsResponse:
        """
        @summary 删除行
        
        @param request: DeleteRowsRequest
        @param headers: DeleteRowsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteRowsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.row):
            body['row'] = request.row
        if not UtilClient.is_unset(request.row_count):
            body['rowCount'] = request.row_count
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='DeleteRows',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/sheets/{sheet_id}/deleteRows',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.DeleteRowsResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_rows_with_options_async(
        self,
        workbook_id: str,
        sheet_id: str,
        request: dingtalkdoc__1__0_models.DeleteRowsRequest,
        headers: dingtalkdoc__1__0_models.DeleteRowsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.DeleteRowsResponse:
        """
        @summary 删除行
        
        @param request: DeleteRowsRequest
        @param headers: DeleteRowsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteRowsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.row):
            body['row'] = request.row
        if not UtilClient.is_unset(request.row_count):
            body['rowCount'] = request.row_count
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='DeleteRows',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/sheets/{sheet_id}/deleteRows',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.DeleteRowsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_rows(
        self,
        workbook_id: str,
        sheet_id: str,
        request: dingtalkdoc__1__0_models.DeleteRowsRequest,
    ) -> dingtalkdoc__1__0_models.DeleteRowsResponse:
        """
        @summary 删除行
        
        @param request: DeleteRowsRequest
        @return: DeleteRowsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.DeleteRowsHeaders()
        return self.delete_rows_with_options(workbook_id, sheet_id, request, headers, runtime)

    async def delete_rows_async(
        self,
        workbook_id: str,
        sheet_id: str,
        request: dingtalkdoc__1__0_models.DeleteRowsRequest,
    ) -> dingtalkdoc__1__0_models.DeleteRowsResponse:
        """
        @summary 删除行
        
        @param request: DeleteRowsRequest
        @return: DeleteRowsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.DeleteRowsHeaders()
        return await self.delete_rows_with_options_async(workbook_id, sheet_id, request, headers, runtime)

    def delete_sheet_with_options(
        self,
        workbook_id: str,
        sheet_id: str,
        request: dingtalkdoc__1__0_models.DeleteSheetRequest,
        headers: dingtalkdoc__1__0_models.DeleteSheetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.DeleteSheetResponse:
        """
        @summary 删除工作表
        
        @param request: DeleteSheetRequest
        @param headers: DeleteSheetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteSheetResponse
        """
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
        params = open_api_models.Params(
            action='DeleteSheet',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/sheets/{sheet_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.DeleteSheetResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_sheet_with_options_async(
        self,
        workbook_id: str,
        sheet_id: str,
        request: dingtalkdoc__1__0_models.DeleteSheetRequest,
        headers: dingtalkdoc__1__0_models.DeleteSheetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.DeleteSheetResponse:
        """
        @summary 删除工作表
        
        @param request: DeleteSheetRequest
        @param headers: DeleteSheetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteSheetResponse
        """
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
        params = open_api_models.Params(
            action='DeleteSheet',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/sheets/{sheet_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.DeleteSheetResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_sheet(
        self,
        workbook_id: str,
        sheet_id: str,
        request: dingtalkdoc__1__0_models.DeleteSheetRequest,
    ) -> dingtalkdoc__1__0_models.DeleteSheetResponse:
        """
        @summary 删除工作表
        
        @param request: DeleteSheetRequest
        @return: DeleteSheetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.DeleteSheetHeaders()
        return self.delete_sheet_with_options(workbook_id, sheet_id, request, headers, runtime)

    async def delete_sheet_async(
        self,
        workbook_id: str,
        sheet_id: str,
        request: dingtalkdoc__1__0_models.DeleteSheetRequest,
    ) -> dingtalkdoc__1__0_models.DeleteSheetResponse:
        """
        @summary 删除工作表
        
        @param request: DeleteSheetRequest
        @return: DeleteSheetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.DeleteSheetHeaders()
        return await self.delete_sheet_with_options_async(workbook_id, sheet_id, request, headers, runtime)

    def delete_workspace_doc_with_options(
        self,
        workspace_id: str,
        node_id: str,
        request: dingtalkdoc__1__0_models.DeleteWorkspaceDocRequest,
        headers: dingtalkdoc__1__0_models.DeleteWorkspaceDocHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.DeleteWorkspaceDocResponse:
        """
        @summary 删除知识库文档
        
        @param request: DeleteWorkspaceDocRequest
        @param headers: DeleteWorkspaceDocHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteWorkspaceDocResponse
        """
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
        params = open_api_models.Params(
            action='DeleteWorkspaceDoc',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workspaces/{workspace_id}/docs/{node_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.DeleteWorkspaceDocResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_workspace_doc_with_options_async(
        self,
        workspace_id: str,
        node_id: str,
        request: dingtalkdoc__1__0_models.DeleteWorkspaceDocRequest,
        headers: dingtalkdoc__1__0_models.DeleteWorkspaceDocHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.DeleteWorkspaceDocResponse:
        """
        @summary 删除知识库文档
        
        @param request: DeleteWorkspaceDocRequest
        @param headers: DeleteWorkspaceDocHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteWorkspaceDocResponse
        """
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
        params = open_api_models.Params(
            action='DeleteWorkspaceDoc',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workspaces/{workspace_id}/docs/{node_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.DeleteWorkspaceDocResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_workspace_doc(
        self,
        workspace_id: str,
        node_id: str,
        request: dingtalkdoc__1__0_models.DeleteWorkspaceDocRequest,
    ) -> dingtalkdoc__1__0_models.DeleteWorkspaceDocResponse:
        """
        @summary 删除知识库文档
        
        @param request: DeleteWorkspaceDocRequest
        @return: DeleteWorkspaceDocResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.DeleteWorkspaceDocHeaders()
        return self.delete_workspace_doc_with_options(workspace_id, node_id, request, headers, runtime)

    async def delete_workspace_doc_async(
        self,
        workspace_id: str,
        node_id: str,
        request: dingtalkdoc__1__0_models.DeleteWorkspaceDocRequest,
    ) -> dingtalkdoc__1__0_models.DeleteWorkspaceDocResponse:
        """
        @summary 删除知识库文档
        
        @param request: DeleteWorkspaceDocRequest
        @return: DeleteWorkspaceDocResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.DeleteWorkspaceDocHeaders()
        return await self.delete_workspace_doc_with_options_async(workspace_id, node_id, request, headers, runtime)

    def delete_workspace_doc_members_with_options(
        self,
        workspace_id: str,
        node_id: str,
        request: dingtalkdoc__1__0_models.DeleteWorkspaceDocMembersRequest,
        headers: dingtalkdoc__1__0_models.DeleteWorkspaceDocMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.DeleteWorkspaceDocMembersResponse:
        """
        @summary 删除知识库文档成员
        
        @param request: DeleteWorkspaceDocMembersRequest
        @param headers: DeleteWorkspaceDocMembersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteWorkspaceDocMembersResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
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
        params = open_api_models.Params(
            action='DeleteWorkspaceDocMembers',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workspaces/{workspace_id}/docs/{node_id}/members/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.DeleteWorkspaceDocMembersResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_workspace_doc_members_with_options_async(
        self,
        workspace_id: str,
        node_id: str,
        request: dingtalkdoc__1__0_models.DeleteWorkspaceDocMembersRequest,
        headers: dingtalkdoc__1__0_models.DeleteWorkspaceDocMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.DeleteWorkspaceDocMembersResponse:
        """
        @summary 删除知识库文档成员
        
        @param request: DeleteWorkspaceDocMembersRequest
        @param headers: DeleteWorkspaceDocMembersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteWorkspaceDocMembersResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
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
        params = open_api_models.Params(
            action='DeleteWorkspaceDocMembers',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workspaces/{workspace_id}/docs/{node_id}/members/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.DeleteWorkspaceDocMembersResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_workspace_doc_members(
        self,
        workspace_id: str,
        node_id: str,
        request: dingtalkdoc__1__0_models.DeleteWorkspaceDocMembersRequest,
    ) -> dingtalkdoc__1__0_models.DeleteWorkspaceDocMembersResponse:
        """
        @summary 删除知识库文档成员
        
        @param request: DeleteWorkspaceDocMembersRequest
        @return: DeleteWorkspaceDocMembersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.DeleteWorkspaceDocMembersHeaders()
        return self.delete_workspace_doc_members_with_options(workspace_id, node_id, request, headers, runtime)

    async def delete_workspace_doc_members_async(
        self,
        workspace_id: str,
        node_id: str,
        request: dingtalkdoc__1__0_models.DeleteWorkspaceDocMembersRequest,
    ) -> dingtalkdoc__1__0_models.DeleteWorkspaceDocMembersResponse:
        """
        @summary 删除知识库文档成员
        
        @param request: DeleteWorkspaceDocMembersRequest
        @return: DeleteWorkspaceDocMembersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.DeleteWorkspaceDocMembersHeaders()
        return await self.delete_workspace_doc_members_with_options_async(workspace_id, node_id, request, headers, runtime)

    def delete_workspace_members_with_options(
        self,
        workspace_id: str,
        request: dingtalkdoc__1__0_models.DeleteWorkspaceMembersRequest,
        headers: dingtalkdoc__1__0_models.DeleteWorkspaceMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.DeleteWorkspaceMembersResponse:
        """
        @summary 删除知识库成员
        
        @param request: DeleteWorkspaceMembersRequest
        @param headers: DeleteWorkspaceMembersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteWorkspaceMembersResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
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
        params = open_api_models.Params(
            action='DeleteWorkspaceMembers',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workspaces/{workspace_id}/members/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.DeleteWorkspaceMembersResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_workspace_members_with_options_async(
        self,
        workspace_id: str,
        request: dingtalkdoc__1__0_models.DeleteWorkspaceMembersRequest,
        headers: dingtalkdoc__1__0_models.DeleteWorkspaceMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.DeleteWorkspaceMembersResponse:
        """
        @summary 删除知识库成员
        
        @param request: DeleteWorkspaceMembersRequest
        @param headers: DeleteWorkspaceMembersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteWorkspaceMembersResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
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
        params = open_api_models.Params(
            action='DeleteWorkspaceMembers',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workspaces/{workspace_id}/members/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.DeleteWorkspaceMembersResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_workspace_members(
        self,
        workspace_id: str,
        request: dingtalkdoc__1__0_models.DeleteWorkspaceMembersRequest,
    ) -> dingtalkdoc__1__0_models.DeleteWorkspaceMembersResponse:
        """
        @summary 删除知识库成员
        
        @param request: DeleteWorkspaceMembersRequest
        @return: DeleteWorkspaceMembersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.DeleteWorkspaceMembersHeaders()
        return self.delete_workspace_members_with_options(workspace_id, request, headers, runtime)

    async def delete_workspace_members_async(
        self,
        workspace_id: str,
        request: dingtalkdoc__1__0_models.DeleteWorkspaceMembersRequest,
    ) -> dingtalkdoc__1__0_models.DeleteWorkspaceMembersResponse:
        """
        @summary 删除知识库成员
        
        @param request: DeleteWorkspaceMembersRequest
        @return: DeleteWorkspaceMembersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.DeleteWorkspaceMembersHeaders()
        return await self.delete_workspace_members_with_options_async(workspace_id, request, headers, runtime)

    def doc_append_paragraph_with_options(
        self,
        doc_key: str,
        block_id: str,
        request: dingtalkdoc__1__0_models.DocAppendParagraphRequest,
        headers: dingtalkdoc__1__0_models.DocAppendParagraphHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.DocAppendParagraphResponse:
        """
        @summary 追加指定段落元素
        
        @param request: DocAppendParagraphRequest
        @param headers: DocAppendParagraphHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DocAppendParagraphResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.element_type):
            body['elementType'] = request.element_type
        if not UtilClient.is_unset(request.properties):
            body['properties'] = request.properties
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='DocAppendParagraph',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/suites/documents/{doc_key}/blocks/{block_id}/paragraph/appendElement',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.DocAppendParagraphResponse(),
            self.execute(params, req, runtime)
        )

    async def doc_append_paragraph_with_options_async(
        self,
        doc_key: str,
        block_id: str,
        request: dingtalkdoc__1__0_models.DocAppendParagraphRequest,
        headers: dingtalkdoc__1__0_models.DocAppendParagraphHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.DocAppendParagraphResponse:
        """
        @summary 追加指定段落元素
        
        @param request: DocAppendParagraphRequest
        @param headers: DocAppendParagraphHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DocAppendParagraphResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.element_type):
            body['elementType'] = request.element_type
        if not UtilClient.is_unset(request.properties):
            body['properties'] = request.properties
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='DocAppendParagraph',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/suites/documents/{doc_key}/blocks/{block_id}/paragraph/appendElement',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.DocAppendParagraphResponse(),
            await self.execute_async(params, req, runtime)
        )

    def doc_append_paragraph(
        self,
        doc_key: str,
        block_id: str,
        request: dingtalkdoc__1__0_models.DocAppendParagraphRequest,
    ) -> dingtalkdoc__1__0_models.DocAppendParagraphResponse:
        """
        @summary 追加指定段落元素
        
        @param request: DocAppendParagraphRequest
        @return: DocAppendParagraphResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.DocAppendParagraphHeaders()
        return self.doc_append_paragraph_with_options(doc_key, block_id, request, headers, runtime)

    async def doc_append_paragraph_async(
        self,
        doc_key: str,
        block_id: str,
        request: dingtalkdoc__1__0_models.DocAppendParagraphRequest,
    ) -> dingtalkdoc__1__0_models.DocAppendParagraphResponse:
        """
        @summary 追加指定段落元素
        
        @param request: DocAppendParagraphRequest
        @return: DocAppendParagraphResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.DocAppendParagraphHeaders()
        return await self.doc_append_paragraph_with_options_async(doc_key, block_id, request, headers, runtime)

    def doc_append_text_with_options(
        self,
        doc_key: str,
        block_id: str,
        request: dingtalkdoc__1__0_models.DocAppendTextRequest,
        headers: dingtalkdoc__1__0_models.DocAppendTextHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.DocAppendTextResponse:
        """
        @summary 在段落后追加文本
        
        @param request: DocAppendTextRequest
        @param headers: DocAppendTextHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DocAppendTextResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.text):
            body['text'] = request.text
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='DocAppendText',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/suites/documents/{doc_key}/blocks/{block_id}/paragraph/appendText',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.DocAppendTextResponse(),
            self.execute(params, req, runtime)
        )

    async def doc_append_text_with_options_async(
        self,
        doc_key: str,
        block_id: str,
        request: dingtalkdoc__1__0_models.DocAppendTextRequest,
        headers: dingtalkdoc__1__0_models.DocAppendTextHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.DocAppendTextResponse:
        """
        @summary 在段落后追加文本
        
        @param request: DocAppendTextRequest
        @param headers: DocAppendTextHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DocAppendTextResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.text):
            body['text'] = request.text
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='DocAppendText',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/suites/documents/{doc_key}/blocks/{block_id}/paragraph/appendText',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.DocAppendTextResponse(),
            await self.execute_async(params, req, runtime)
        )

    def doc_append_text(
        self,
        doc_key: str,
        block_id: str,
        request: dingtalkdoc__1__0_models.DocAppendTextRequest,
    ) -> dingtalkdoc__1__0_models.DocAppendTextResponse:
        """
        @summary 在段落后追加文本
        
        @param request: DocAppendTextRequest
        @return: DocAppendTextResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.DocAppendTextHeaders()
        return self.doc_append_text_with_options(doc_key, block_id, request, headers, runtime)

    async def doc_append_text_async(
        self,
        doc_key: str,
        block_id: str,
        request: dingtalkdoc__1__0_models.DocAppendTextRequest,
    ) -> dingtalkdoc__1__0_models.DocAppendTextResponse:
        """
        @summary 在段落后追加文本
        
        @param request: DocAppendTextRequest
        @return: DocAppendTextResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.DocAppendTextHeaders()
        return await self.doc_append_text_with_options_async(doc_key, block_id, request, headers, runtime)

    def doc_blocks_query_with_options(
        self,
        doc_key: str,
        request: dingtalkdoc__1__0_models.DocBlocksQueryRequest,
        headers: dingtalkdoc__1__0_models.DocBlocksQueryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.DocBlocksQueryResponse:
        """
        @summary 查询指定Block元素
        
        @param request: DocBlocksQueryRequest
        @param headers: DocBlocksQueryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DocBlocksQueryResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.block_type):
            query['blockType'] = request.block_type
        if not UtilClient.is_unset(request.end_index):
            query['endIndex'] = request.end_index
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.start_index):
            query['startIndex'] = request.start_index
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
            action='DocBlocksQuery',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/suites/documents/{doc_key}/blocks',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.DocBlocksQueryResponse(),
            self.execute(params, req, runtime)
        )

    async def doc_blocks_query_with_options_async(
        self,
        doc_key: str,
        request: dingtalkdoc__1__0_models.DocBlocksQueryRequest,
        headers: dingtalkdoc__1__0_models.DocBlocksQueryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.DocBlocksQueryResponse:
        """
        @summary 查询指定Block元素
        
        @param request: DocBlocksQueryRequest
        @param headers: DocBlocksQueryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DocBlocksQueryResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.block_type):
            query['blockType'] = request.block_type
        if not UtilClient.is_unset(request.end_index):
            query['endIndex'] = request.end_index
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.start_index):
            query['startIndex'] = request.start_index
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
            action='DocBlocksQuery',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/suites/documents/{doc_key}/blocks',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.DocBlocksQueryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def doc_blocks_query(
        self,
        doc_key: str,
        request: dingtalkdoc__1__0_models.DocBlocksQueryRequest,
    ) -> dingtalkdoc__1__0_models.DocBlocksQueryResponse:
        """
        @summary 查询指定Block元素
        
        @param request: DocBlocksQueryRequest
        @return: DocBlocksQueryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.DocBlocksQueryHeaders()
        return self.doc_blocks_query_with_options(doc_key, request, headers, runtime)

    async def doc_blocks_query_async(
        self,
        doc_key: str,
        request: dingtalkdoc__1__0_models.DocBlocksQueryRequest,
    ) -> dingtalkdoc__1__0_models.DocBlocksQueryResponse:
        """
        @summary 查询指定Block元素
        
        @param request: DocBlocksQueryRequest
        @return: DocBlocksQueryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.DocBlocksQueryHeaders()
        return await self.doc_blocks_query_with_options_async(doc_key, request, headers, runtime)

    def doc_delete_block_with_options(
        self,
        doc_key: str,
        block_id: str,
        request: dingtalkdoc__1__0_models.DocDeleteBlockRequest,
        headers: dingtalkdoc__1__0_models.DocDeleteBlockHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.DocDeleteBlockResponse:
        """
        @summary 删除指定位置的 Block
        
        @param request: DocDeleteBlockRequest
        @param headers: DocDeleteBlockHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DocDeleteBlockResponse
        """
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
        params = open_api_models.Params(
            action='DocDeleteBlock',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/suites/documents/{doc_key}/blocks/{block_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.DocDeleteBlockResponse(),
            self.execute(params, req, runtime)
        )

    async def doc_delete_block_with_options_async(
        self,
        doc_key: str,
        block_id: str,
        request: dingtalkdoc__1__0_models.DocDeleteBlockRequest,
        headers: dingtalkdoc__1__0_models.DocDeleteBlockHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.DocDeleteBlockResponse:
        """
        @summary 删除指定位置的 Block
        
        @param request: DocDeleteBlockRequest
        @param headers: DocDeleteBlockHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DocDeleteBlockResponse
        """
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
        params = open_api_models.Params(
            action='DocDeleteBlock',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/suites/documents/{doc_key}/blocks/{block_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.DocDeleteBlockResponse(),
            await self.execute_async(params, req, runtime)
        )

    def doc_delete_block(
        self,
        doc_key: str,
        block_id: str,
        request: dingtalkdoc__1__0_models.DocDeleteBlockRequest,
    ) -> dingtalkdoc__1__0_models.DocDeleteBlockResponse:
        """
        @summary 删除指定位置的 Block
        
        @param request: DocDeleteBlockRequest
        @return: DocDeleteBlockResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.DocDeleteBlockHeaders()
        return self.doc_delete_block_with_options(doc_key, block_id, request, headers, runtime)

    async def doc_delete_block_async(
        self,
        doc_key: str,
        block_id: str,
        request: dingtalkdoc__1__0_models.DocDeleteBlockRequest,
    ) -> dingtalkdoc__1__0_models.DocDeleteBlockResponse:
        """
        @summary 删除指定位置的 Block
        
        @param request: DocDeleteBlockRequest
        @return: DocDeleteBlockResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.DocDeleteBlockHeaders()
        return await self.doc_delete_block_with_options_async(doc_key, block_id, request, headers, runtime)

    def doc_insert_blocks_with_options(
        self,
        doc_key: str,
        request: dingtalkdoc__1__0_models.DocInsertBlocksRequest,
        headers: dingtalkdoc__1__0_models.DocInsertBlocksHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.DocInsertBlocksResponse:
        """
        @summary 插入指定Block元素
        
        @param request: DocInsertBlocksRequest
        @param headers: DocInsertBlocksHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DocInsertBlocksResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.block_id):
            body['blockId'] = request.block_id
        if not UtilClient.is_unset(request.element):
            body['element'] = request.element
        if not UtilClient.is_unset(request.index):
            body['index'] = request.index
        if not UtilClient.is_unset(request.where):
            body['where'] = request.where
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='DocInsertBlocks',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/suites/documents/{doc_key}/blocks',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.DocInsertBlocksResponse(),
            self.execute(params, req, runtime)
        )

    async def doc_insert_blocks_with_options_async(
        self,
        doc_key: str,
        request: dingtalkdoc__1__0_models.DocInsertBlocksRequest,
        headers: dingtalkdoc__1__0_models.DocInsertBlocksHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.DocInsertBlocksResponse:
        """
        @summary 插入指定Block元素
        
        @param request: DocInsertBlocksRequest
        @param headers: DocInsertBlocksHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DocInsertBlocksResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.block_id):
            body['blockId'] = request.block_id
        if not UtilClient.is_unset(request.element):
            body['element'] = request.element
        if not UtilClient.is_unset(request.index):
            body['index'] = request.index
        if not UtilClient.is_unset(request.where):
            body['where'] = request.where
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='DocInsertBlocks',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/suites/documents/{doc_key}/blocks',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.DocInsertBlocksResponse(),
            await self.execute_async(params, req, runtime)
        )

    def doc_insert_blocks(
        self,
        doc_key: str,
        request: dingtalkdoc__1__0_models.DocInsertBlocksRequest,
    ) -> dingtalkdoc__1__0_models.DocInsertBlocksResponse:
        """
        @summary 插入指定Block元素
        
        @param request: DocInsertBlocksRequest
        @return: DocInsertBlocksResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.DocInsertBlocksHeaders()
        return self.doc_insert_blocks_with_options(doc_key, request, headers, runtime)

    async def doc_insert_blocks_async(
        self,
        doc_key: str,
        request: dingtalkdoc__1__0_models.DocInsertBlocksRequest,
    ) -> dingtalkdoc__1__0_models.DocInsertBlocksResponse:
        """
        @summary 插入指定Block元素
        
        @param request: DocInsertBlocksRequest
        @return: DocInsertBlocksResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.DocInsertBlocksHeaders()
        return await self.doc_insert_blocks_with_options_async(doc_key, request, headers, runtime)

    def doc_update_content_with_options(
        self,
        doc_key: str,
        request: dingtalkdoc__1__0_models.DocUpdateContentRequest,
        headers: dingtalkdoc__1__0_models.DocUpdateContentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.DocUpdateContentResponse:
        """
        @summary 覆写全文
        
        @param request: DocUpdateContentRequest
        @param headers: DocUpdateContentHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DocUpdateContentResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.data_type):
            body['dataType'] = request.data_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='DocUpdateContent',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/suites/documents/{doc_key}/overwriteContent',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.DocUpdateContentResponse(),
            self.execute(params, req, runtime)
        )

    async def doc_update_content_with_options_async(
        self,
        doc_key: str,
        request: dingtalkdoc__1__0_models.DocUpdateContentRequest,
        headers: dingtalkdoc__1__0_models.DocUpdateContentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.DocUpdateContentResponse:
        """
        @summary 覆写全文
        
        @param request: DocUpdateContentRequest
        @param headers: DocUpdateContentHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DocUpdateContentResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.data_type):
            body['dataType'] = request.data_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='DocUpdateContent',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/suites/documents/{doc_key}/overwriteContent',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.DocUpdateContentResponse(),
            await self.execute_async(params, req, runtime)
        )

    def doc_update_content(
        self,
        doc_key: str,
        request: dingtalkdoc__1__0_models.DocUpdateContentRequest,
    ) -> dingtalkdoc__1__0_models.DocUpdateContentResponse:
        """
        @summary 覆写全文
        
        @param request: DocUpdateContentRequest
        @return: DocUpdateContentResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.DocUpdateContentHeaders()
        return self.doc_update_content_with_options(doc_key, request, headers, runtime)

    async def doc_update_content_async(
        self,
        doc_key: str,
        request: dingtalkdoc__1__0_models.DocUpdateContentRequest,
    ) -> dingtalkdoc__1__0_models.DocUpdateContentResponse:
        """
        @summary 覆写全文
        
        @param request: DocUpdateContentRequest
        @return: DocUpdateContentResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.DocUpdateContentHeaders()
        return await self.doc_update_content_with_options_async(doc_key, request, headers, runtime)

    def get_all_sheets_with_options(
        self,
        workbook_id: str,
        request: dingtalkdoc__1__0_models.GetAllSheetsRequest,
        headers: dingtalkdoc__1__0_models.GetAllSheetsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.GetAllSheetsResponse:
        """
        @summary 获取所有工作表
        
        @param request: GetAllSheetsRequest
        @param headers: GetAllSheetsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAllSheetsResponse
        """
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
        params = open_api_models.Params(
            action='GetAllSheets',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/sheets',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.GetAllSheetsResponse(),
            self.execute(params, req, runtime)
        )

    async def get_all_sheets_with_options_async(
        self,
        workbook_id: str,
        request: dingtalkdoc__1__0_models.GetAllSheetsRequest,
        headers: dingtalkdoc__1__0_models.GetAllSheetsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.GetAllSheetsResponse:
        """
        @summary 获取所有工作表
        
        @param request: GetAllSheetsRequest
        @param headers: GetAllSheetsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAllSheetsResponse
        """
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
        params = open_api_models.Params(
            action='GetAllSheets',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/sheets',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.GetAllSheetsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_all_sheets(
        self,
        workbook_id: str,
        request: dingtalkdoc__1__0_models.GetAllSheetsRequest,
    ) -> dingtalkdoc__1__0_models.GetAllSheetsResponse:
        """
        @summary 获取所有工作表
        
        @param request: GetAllSheetsRequest
        @return: GetAllSheetsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.GetAllSheetsHeaders()
        return self.get_all_sheets_with_options(workbook_id, request, headers, runtime)

    async def get_all_sheets_async(
        self,
        workbook_id: str,
        request: dingtalkdoc__1__0_models.GetAllSheetsRequest,
    ) -> dingtalkdoc__1__0_models.GetAllSheetsResponse:
        """
        @summary 获取所有工作表
        
        @param request: GetAllSheetsRequest
        @return: GetAllSheetsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.GetAllSheetsHeaders()
        return await self.get_all_sheets_with_options_async(workbook_id, request, headers, runtime)

    def get_developer_metadata_with_options(
        self,
        workbook_id: str,
        developer_metadata_id: str,
        request: dingtalkdoc__1__0_models.GetDeveloperMetadataRequest,
        headers: dingtalkdoc__1__0_models.GetDeveloperMetadataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.GetDeveloperMetadataResponse:
        """
        @summary 获取开发者元数据
        
        @param request: GetDeveloperMetadataRequest
        @param headers: GetDeveloperMetadataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetDeveloperMetadataResponse
        """
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
        params = open_api_models.Params(
            action='GetDeveloperMetadata',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/developerMetadatas/{developer_metadata_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.GetDeveloperMetadataResponse(),
            self.execute(params, req, runtime)
        )

    async def get_developer_metadata_with_options_async(
        self,
        workbook_id: str,
        developer_metadata_id: str,
        request: dingtalkdoc__1__0_models.GetDeveloperMetadataRequest,
        headers: dingtalkdoc__1__0_models.GetDeveloperMetadataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.GetDeveloperMetadataResponse:
        """
        @summary 获取开发者元数据
        
        @param request: GetDeveloperMetadataRequest
        @param headers: GetDeveloperMetadataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetDeveloperMetadataResponse
        """
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
        params = open_api_models.Params(
            action='GetDeveloperMetadata',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/developerMetadatas/{developer_metadata_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.GetDeveloperMetadataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_developer_metadata(
        self,
        workbook_id: str,
        developer_metadata_id: str,
        request: dingtalkdoc__1__0_models.GetDeveloperMetadataRequest,
    ) -> dingtalkdoc__1__0_models.GetDeveloperMetadataResponse:
        """
        @summary 获取开发者元数据
        
        @param request: GetDeveloperMetadataRequest
        @return: GetDeveloperMetadataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.GetDeveloperMetadataHeaders()
        return self.get_developer_metadata_with_options(workbook_id, developer_metadata_id, request, headers, runtime)

    async def get_developer_metadata_async(
        self,
        workbook_id: str,
        developer_metadata_id: str,
        request: dingtalkdoc__1__0_models.GetDeveloperMetadataRequest,
    ) -> dingtalkdoc__1__0_models.GetDeveloperMetadataResponse:
        """
        @summary 获取开发者元数据
        
        @param request: GetDeveloperMetadataRequest
        @return: GetDeveloperMetadataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.GetDeveloperMetadataHeaders()
        return await self.get_developer_metadata_with_options_async(workbook_id, developer_metadata_id, request, headers, runtime)

    def get_range_with_options(
        self,
        workbook_id: str,
        sheet_id: str,
        range_address: str,
        request: dingtalkdoc__1__0_models.GetRangeRequest,
        headers: dingtalkdoc__1__0_models.GetRangeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.GetRangeResponse:
        """
        @summary 获取单元格区域
        
        @param request: GetRangeRequest
        @param headers: GetRangeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetRangeResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.select):
            query['select'] = request.select
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
            action='GetRange',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/sheets/{sheet_id}/ranges/{range_address}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.GetRangeResponse(),
            self.execute(params, req, runtime)
        )

    async def get_range_with_options_async(
        self,
        workbook_id: str,
        sheet_id: str,
        range_address: str,
        request: dingtalkdoc__1__0_models.GetRangeRequest,
        headers: dingtalkdoc__1__0_models.GetRangeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.GetRangeResponse:
        """
        @summary 获取单元格区域
        
        @param request: GetRangeRequest
        @param headers: GetRangeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetRangeResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.select):
            query['select'] = request.select
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
            action='GetRange',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/sheets/{sheet_id}/ranges/{range_address}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.GetRangeResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_range(
        self,
        workbook_id: str,
        sheet_id: str,
        range_address: str,
        request: dingtalkdoc__1__0_models.GetRangeRequest,
    ) -> dingtalkdoc__1__0_models.GetRangeResponse:
        """
        @summary 获取单元格区域
        
        @param request: GetRangeRequest
        @return: GetRangeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.GetRangeHeaders()
        return self.get_range_with_options(workbook_id, sheet_id, range_address, request, headers, runtime)

    async def get_range_async(
        self,
        workbook_id: str,
        sheet_id: str,
        range_address: str,
        request: dingtalkdoc__1__0_models.GetRangeRequest,
    ) -> dingtalkdoc__1__0_models.GetRangeResponse:
        """
        @summary 获取单元格区域
        
        @param request: GetRangeRequest
        @return: GetRangeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.GetRangeHeaders()
        return await self.get_range_with_options_async(workbook_id, sheet_id, range_address, request, headers, runtime)

    def get_recent_edit_docs_with_options(
        self,
        request: dingtalkdoc__1__0_models.GetRecentEditDocsRequest,
        headers: dingtalkdoc__1__0_models.GetRecentEditDocsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.GetRecentEditDocsResponse:
        """
        @summary 获取最近编辑文档
        
        @param request: GetRecentEditDocsRequest
        @param headers: GetRecentEditDocsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetRecentEditDocsResponse
        """
        UtilClient.validate_model(request)
        query = {}
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
        params = open_api_models.Params(
            action='GetRecentEditDocs',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workspaces/docs/recentEditDocs',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.GetRecentEditDocsResponse(),
            self.execute(params, req, runtime)
        )

    async def get_recent_edit_docs_with_options_async(
        self,
        request: dingtalkdoc__1__0_models.GetRecentEditDocsRequest,
        headers: dingtalkdoc__1__0_models.GetRecentEditDocsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.GetRecentEditDocsResponse:
        """
        @summary 获取最近编辑文档
        
        @param request: GetRecentEditDocsRequest
        @param headers: GetRecentEditDocsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetRecentEditDocsResponse
        """
        UtilClient.validate_model(request)
        query = {}
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
        params = open_api_models.Params(
            action='GetRecentEditDocs',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workspaces/docs/recentEditDocs',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.GetRecentEditDocsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_recent_edit_docs(
        self,
        request: dingtalkdoc__1__0_models.GetRecentEditDocsRequest,
    ) -> dingtalkdoc__1__0_models.GetRecentEditDocsResponse:
        """
        @summary 获取最近编辑文档
        
        @param request: GetRecentEditDocsRequest
        @return: GetRecentEditDocsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.GetRecentEditDocsHeaders()
        return self.get_recent_edit_docs_with_options(request, headers, runtime)

    async def get_recent_edit_docs_async(
        self,
        request: dingtalkdoc__1__0_models.GetRecentEditDocsRequest,
    ) -> dingtalkdoc__1__0_models.GetRecentEditDocsResponse:
        """
        @summary 获取最近编辑文档
        
        @param request: GetRecentEditDocsRequest
        @return: GetRecentEditDocsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.GetRecentEditDocsHeaders()
        return await self.get_recent_edit_docs_with_options_async(request, headers, runtime)

    def get_recent_open_docs_with_options(
        self,
        request: dingtalkdoc__1__0_models.GetRecentOpenDocsRequest,
        headers: dingtalkdoc__1__0_models.GetRecentOpenDocsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.GetRecentOpenDocsResponse:
        """
        @summary 获取最近打开文档
        
        @param request: GetRecentOpenDocsRequest
        @param headers: GetRecentOpenDocsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetRecentOpenDocsResponse
        """
        UtilClient.validate_model(request)
        query = {}
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
        params = open_api_models.Params(
            action='GetRecentOpenDocs',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workspaces/docs/recentOpenDocs',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.GetRecentOpenDocsResponse(),
            self.execute(params, req, runtime)
        )

    async def get_recent_open_docs_with_options_async(
        self,
        request: dingtalkdoc__1__0_models.GetRecentOpenDocsRequest,
        headers: dingtalkdoc__1__0_models.GetRecentOpenDocsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.GetRecentOpenDocsResponse:
        """
        @summary 获取最近打开文档
        
        @param request: GetRecentOpenDocsRequest
        @param headers: GetRecentOpenDocsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetRecentOpenDocsResponse
        """
        UtilClient.validate_model(request)
        query = {}
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
        params = open_api_models.Params(
            action='GetRecentOpenDocs',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workspaces/docs/recentOpenDocs',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.GetRecentOpenDocsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_recent_open_docs(
        self,
        request: dingtalkdoc__1__0_models.GetRecentOpenDocsRequest,
    ) -> dingtalkdoc__1__0_models.GetRecentOpenDocsResponse:
        """
        @summary 获取最近打开文档
        
        @param request: GetRecentOpenDocsRequest
        @return: GetRecentOpenDocsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.GetRecentOpenDocsHeaders()
        return self.get_recent_open_docs_with_options(request, headers, runtime)

    async def get_recent_open_docs_async(
        self,
        request: dingtalkdoc__1__0_models.GetRecentOpenDocsRequest,
    ) -> dingtalkdoc__1__0_models.GetRecentOpenDocsResponse:
        """
        @summary 获取最近打开文档
        
        @param request: GetRecentOpenDocsRequest
        @return: GetRecentOpenDocsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.GetRecentOpenDocsHeaders()
        return await self.get_recent_open_docs_with_options_async(request, headers, runtime)

    def get_related_workspaces_with_options(
        self,
        request: dingtalkdoc__1__0_models.GetRelatedWorkspacesRequest,
        headers: dingtalkdoc__1__0_models.GetRelatedWorkspacesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.GetRelatedWorkspacesResponse:
        """
        @summary 查询用户有权限的知识库
        
        @param request: GetRelatedWorkspacesRequest
        @param headers: GetRelatedWorkspacesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetRelatedWorkspacesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.include_recent):
            query['includeRecent'] = request.include_recent
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
        params = open_api_models.Params(
            action='GetRelatedWorkspaces',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workspaces',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.GetRelatedWorkspacesResponse(),
            self.execute(params, req, runtime)
        )

    async def get_related_workspaces_with_options_async(
        self,
        request: dingtalkdoc__1__0_models.GetRelatedWorkspacesRequest,
        headers: dingtalkdoc__1__0_models.GetRelatedWorkspacesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.GetRelatedWorkspacesResponse:
        """
        @summary 查询用户有权限的知识库
        
        @param request: GetRelatedWorkspacesRequest
        @param headers: GetRelatedWorkspacesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetRelatedWorkspacesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.include_recent):
            query['includeRecent'] = request.include_recent
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
        params = open_api_models.Params(
            action='GetRelatedWorkspaces',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workspaces',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.GetRelatedWorkspacesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_related_workspaces(
        self,
        request: dingtalkdoc__1__0_models.GetRelatedWorkspacesRequest,
    ) -> dingtalkdoc__1__0_models.GetRelatedWorkspacesResponse:
        """
        @summary 查询用户有权限的知识库
        
        @param request: GetRelatedWorkspacesRequest
        @return: GetRelatedWorkspacesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.GetRelatedWorkspacesHeaders()
        return self.get_related_workspaces_with_options(request, headers, runtime)

    async def get_related_workspaces_async(
        self,
        request: dingtalkdoc__1__0_models.GetRelatedWorkspacesRequest,
    ) -> dingtalkdoc__1__0_models.GetRelatedWorkspacesResponse:
        """
        @summary 查询用户有权限的知识库
        
        @param request: GetRelatedWorkspacesRequest
        @return: GetRelatedWorkspacesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.GetRelatedWorkspacesHeaders()
        return await self.get_related_workspaces_with_options_async(request, headers, runtime)

    def get_resource_upload_info_with_options(
        self,
        doc_id: str,
        request: dingtalkdoc__1__0_models.GetResourceUploadInfoRequest,
        headers: dingtalkdoc__1__0_models.GetResourceUploadInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.GetResourceUploadInfoResponse:
        """
        @summary 获取上传信息
        
        @param request: GetResourceUploadInfoRequest
        @param headers: GetResourceUploadInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetResourceUploadInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.media_type):
            body['mediaType'] = request.media_type
        if not UtilClient.is_unset(request.resource_name):
            body['resourceName'] = request.resource_name
        if not UtilClient.is_unset(request.size):
            body['size'] = request.size
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='GetResourceUploadInfo',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/docs/resources/{doc_id}/uploadInfos/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.GetResourceUploadInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def get_resource_upload_info_with_options_async(
        self,
        doc_id: str,
        request: dingtalkdoc__1__0_models.GetResourceUploadInfoRequest,
        headers: dingtalkdoc__1__0_models.GetResourceUploadInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.GetResourceUploadInfoResponse:
        """
        @summary 获取上传信息
        
        @param request: GetResourceUploadInfoRequest
        @param headers: GetResourceUploadInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetResourceUploadInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.media_type):
            body['mediaType'] = request.media_type
        if not UtilClient.is_unset(request.resource_name):
            body['resourceName'] = request.resource_name
        if not UtilClient.is_unset(request.size):
            body['size'] = request.size
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='GetResourceUploadInfo',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/docs/resources/{doc_id}/uploadInfos/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.GetResourceUploadInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_resource_upload_info(
        self,
        doc_id: str,
        request: dingtalkdoc__1__0_models.GetResourceUploadInfoRequest,
    ) -> dingtalkdoc__1__0_models.GetResourceUploadInfoResponse:
        """
        @summary 获取上传信息
        
        @param request: GetResourceUploadInfoRequest
        @return: GetResourceUploadInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.GetResourceUploadInfoHeaders()
        return self.get_resource_upload_info_with_options(doc_id, request, headers, runtime)

    async def get_resource_upload_info_async(
        self,
        doc_id: str,
        request: dingtalkdoc__1__0_models.GetResourceUploadInfoRequest,
    ) -> dingtalkdoc__1__0_models.GetResourceUploadInfoResponse:
        """
        @summary 获取上传信息
        
        @param request: GetResourceUploadInfoRequest
        @return: GetResourceUploadInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.GetResourceUploadInfoHeaders()
        return await self.get_resource_upload_info_with_options_async(doc_id, request, headers, runtime)

    def get_sheet_with_options(
        self,
        workbook_id: str,
        sheet_id: str,
        request: dingtalkdoc__1__0_models.GetSheetRequest,
        headers: dingtalkdoc__1__0_models.GetSheetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.GetSheetResponse:
        """
        @summary 获取工作表
        
        @param request: GetSheetRequest
        @param headers: GetSheetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSheetResponse
        """
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
        params = open_api_models.Params(
            action='GetSheet',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/sheets/{sheet_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.GetSheetResponse(),
            self.execute(params, req, runtime)
        )

    async def get_sheet_with_options_async(
        self,
        workbook_id: str,
        sheet_id: str,
        request: dingtalkdoc__1__0_models.GetSheetRequest,
        headers: dingtalkdoc__1__0_models.GetSheetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.GetSheetResponse:
        """
        @summary 获取工作表
        
        @param request: GetSheetRequest
        @param headers: GetSheetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSheetResponse
        """
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
        params = open_api_models.Params(
            action='GetSheet',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/sheets/{sheet_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.GetSheetResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_sheet(
        self,
        workbook_id: str,
        sheet_id: str,
        request: dingtalkdoc__1__0_models.GetSheetRequest,
    ) -> dingtalkdoc__1__0_models.GetSheetResponse:
        """
        @summary 获取工作表
        
        @param request: GetSheetRequest
        @return: GetSheetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.GetSheetHeaders()
        return self.get_sheet_with_options(workbook_id, sheet_id, request, headers, runtime)

    async def get_sheet_async(
        self,
        workbook_id: str,
        sheet_id: str,
        request: dingtalkdoc__1__0_models.GetSheetRequest,
    ) -> dingtalkdoc__1__0_models.GetSheetResponse:
        """
        @summary 获取工作表
        
        @param request: GetSheetRequest
        @return: GetSheetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.GetSheetHeaders()
        return await self.get_sheet_with_options_async(workbook_id, sheet_id, request, headers, runtime)

    def get_template_by_id_with_options(
        self,
        template_id: str,
        request: dingtalkdoc__1__0_models.GetTemplateByIdRequest,
        headers: dingtalkdoc__1__0_models.GetTemplateByIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.GetTemplateByIdResponse:
        """
        @summary 查询文档模版
        
        @param request: GetTemplateByIdRequest
        @param headers: GetTemplateByIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetTemplateByIdResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.belong):
            query['belong'] = request.belong
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
        params = open_api_models.Params(
            action='GetTemplateById',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/templates/{template_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.GetTemplateByIdResponse(),
            self.execute(params, req, runtime)
        )

    async def get_template_by_id_with_options_async(
        self,
        template_id: str,
        request: dingtalkdoc__1__0_models.GetTemplateByIdRequest,
        headers: dingtalkdoc__1__0_models.GetTemplateByIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.GetTemplateByIdResponse:
        """
        @summary 查询文档模版
        
        @param request: GetTemplateByIdRequest
        @param headers: GetTemplateByIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetTemplateByIdResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.belong):
            query['belong'] = request.belong
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
        params = open_api_models.Params(
            action='GetTemplateById',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/templates/{template_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.GetTemplateByIdResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_template_by_id(
        self,
        template_id: str,
        request: dingtalkdoc__1__0_models.GetTemplateByIdRequest,
    ) -> dingtalkdoc__1__0_models.GetTemplateByIdResponse:
        """
        @summary 查询文档模版
        
        @param request: GetTemplateByIdRequest
        @return: GetTemplateByIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.GetTemplateByIdHeaders()
        return self.get_template_by_id_with_options(template_id, request, headers, runtime)

    async def get_template_by_id_async(
        self,
        template_id: str,
        request: dingtalkdoc__1__0_models.GetTemplateByIdRequest,
    ) -> dingtalkdoc__1__0_models.GetTemplateByIdResponse:
        """
        @summary 查询文档模版
        
        @param request: GetTemplateByIdRequest
        @return: GetTemplateByIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.GetTemplateByIdHeaders()
        return await self.get_template_by_id_with_options_async(template_id, request, headers, runtime)

    def get_workspace_with_options(
        self,
        workspace_id: str,
        headers: dingtalkdoc__1__0_models.GetWorkspaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.GetWorkspaceResponse:
        """
        @summary 查询知识库信息
        
        @param headers: GetWorkspaceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetWorkspaceResponse
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
            action='GetWorkspace',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workspaces/{workspace_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.GetWorkspaceResponse(),
            self.execute(params, req, runtime)
        )

    async def get_workspace_with_options_async(
        self,
        workspace_id: str,
        headers: dingtalkdoc__1__0_models.GetWorkspaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.GetWorkspaceResponse:
        """
        @summary 查询知识库信息
        
        @param headers: GetWorkspaceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetWorkspaceResponse
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
            action='GetWorkspace',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workspaces/{workspace_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.GetWorkspaceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_workspace(
        self,
        workspace_id: str,
    ) -> dingtalkdoc__1__0_models.GetWorkspaceResponse:
        """
        @summary 查询知识库信息
        
        @return: GetWorkspaceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.GetWorkspaceHeaders()
        return self.get_workspace_with_options(workspace_id, headers, runtime)

    async def get_workspace_async(
        self,
        workspace_id: str,
    ) -> dingtalkdoc__1__0_models.GetWorkspaceResponse:
        """
        @summary 查询知识库信息
        
        @return: GetWorkspaceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.GetWorkspaceHeaders()
        return await self.get_workspace_with_options_async(workspace_id, headers, runtime)

    def get_workspace_node_with_options(
        self,
        workspace_id: str,
        node_id: str,
        request: dingtalkdoc__1__0_models.GetWorkspaceNodeRequest,
        headers: dingtalkdoc__1__0_models.GetWorkspaceNodeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.GetWorkspaceNodeResponse:
        """
        @summary 查询知识库文档
        
        @param request: GetWorkspaceNodeRequest
        @param headers: GetWorkspaceNodeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetWorkspaceNodeResponse
        """
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
        params = open_api_models.Params(
            action='GetWorkspaceNode',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workspaces/{workspace_id}/docs/{node_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.GetWorkspaceNodeResponse(),
            self.execute(params, req, runtime)
        )

    async def get_workspace_node_with_options_async(
        self,
        workspace_id: str,
        node_id: str,
        request: dingtalkdoc__1__0_models.GetWorkspaceNodeRequest,
        headers: dingtalkdoc__1__0_models.GetWorkspaceNodeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.GetWorkspaceNodeResponse:
        """
        @summary 查询知识库文档
        
        @param request: GetWorkspaceNodeRequest
        @param headers: GetWorkspaceNodeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetWorkspaceNodeResponse
        """
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
        params = open_api_models.Params(
            action='GetWorkspaceNode',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workspaces/{workspace_id}/docs/{node_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.GetWorkspaceNodeResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_workspace_node(
        self,
        workspace_id: str,
        node_id: str,
        request: dingtalkdoc__1__0_models.GetWorkspaceNodeRequest,
    ) -> dingtalkdoc__1__0_models.GetWorkspaceNodeResponse:
        """
        @summary 查询知识库文档
        
        @param request: GetWorkspaceNodeRequest
        @return: GetWorkspaceNodeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.GetWorkspaceNodeHeaders()
        return self.get_workspace_node_with_options(workspace_id, node_id, request, headers, runtime)

    async def get_workspace_node_async(
        self,
        workspace_id: str,
        node_id: str,
        request: dingtalkdoc__1__0_models.GetWorkspaceNodeRequest,
    ) -> dingtalkdoc__1__0_models.GetWorkspaceNodeResponse:
        """
        @summary 查询知识库文档
        
        @param request: GetWorkspaceNodeRequest
        @return: GetWorkspaceNodeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.GetWorkspaceNodeHeaders()
        return await self.get_workspace_node_with_options_async(workspace_id, node_id, request, headers, runtime)

    def init_document_with_options(
        self,
        doc_id: str,
        request: dingtalkdoc__1__0_models.InitDocumentRequest,
        headers: dingtalkdoc__1__0_models.InitDocumentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.InitDocumentResponse:
        """
        @summary 文档初始化
        
        @param request: InitDocumentRequest
        @param headers: InitDocumentHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: InitDocumentResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.attachments_key):
            body['attachmentsKey'] = request.attachments_key
        if not UtilClient.is_unset(request.attachments_map):
            body['attachmentsMap'] = request.attachments_map
        if not UtilClient.is_unset(request.import_type):
            body['importType'] = request.import_type
        if not UtilClient.is_unset(request.links_key):
            body['linksKey'] = request.links_key
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='InitDocument',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/docs/{doc_id}/init',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.InitDocumentResponse(),
            self.execute(params, req, runtime)
        )

    async def init_document_with_options_async(
        self,
        doc_id: str,
        request: dingtalkdoc__1__0_models.InitDocumentRequest,
        headers: dingtalkdoc__1__0_models.InitDocumentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.InitDocumentResponse:
        """
        @summary 文档初始化
        
        @param request: InitDocumentRequest
        @param headers: InitDocumentHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: InitDocumentResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.attachments_key):
            body['attachmentsKey'] = request.attachments_key
        if not UtilClient.is_unset(request.attachments_map):
            body['attachmentsMap'] = request.attachments_map
        if not UtilClient.is_unset(request.import_type):
            body['importType'] = request.import_type
        if not UtilClient.is_unset(request.links_key):
            body['linksKey'] = request.links_key
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='InitDocument',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/docs/{doc_id}/init',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.InitDocumentResponse(),
            await self.execute_async(params, req, runtime)
        )

    def init_document(
        self,
        doc_id: str,
        request: dingtalkdoc__1__0_models.InitDocumentRequest,
    ) -> dingtalkdoc__1__0_models.InitDocumentResponse:
        """
        @summary 文档初始化
        
        @param request: InitDocumentRequest
        @return: InitDocumentResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.InitDocumentHeaders()
        return self.init_document_with_options(doc_id, request, headers, runtime)

    async def init_document_async(
        self,
        doc_id: str,
        request: dingtalkdoc__1__0_models.InitDocumentRequest,
    ) -> dingtalkdoc__1__0_models.InitDocumentResponse:
        """
        @summary 文档初始化
        
        @param request: InitDocumentRequest
        @return: InitDocumentResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.InitDocumentHeaders()
        return await self.init_document_with_options_async(doc_id, request, headers, runtime)

    def insert_blocks_with_options(
        self,
        document_id: str,
        request: dingtalkdoc__1__0_models.InsertBlocksRequest,
        headers: dingtalkdoc__1__0_models.InsertBlocksHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.InsertBlocksResponse:
        """
        @summary 向文档内插入块级元素
        
        @param request: InsertBlocksRequest
        @param headers: InsertBlocksHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: InsertBlocksResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.blocks):
            body['blocks'] = request.blocks
        if not UtilClient.is_unset(request.location):
            body['location'] = request.location
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
        params = open_api_models.Params(
            action='InsertBlocks',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/documents/{document_id}/blocks',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.InsertBlocksResponse(),
            self.execute(params, req, runtime)
        )

    async def insert_blocks_with_options_async(
        self,
        document_id: str,
        request: dingtalkdoc__1__0_models.InsertBlocksRequest,
        headers: dingtalkdoc__1__0_models.InsertBlocksHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.InsertBlocksResponse:
        """
        @summary 向文档内插入块级元素
        
        @param request: InsertBlocksRequest
        @param headers: InsertBlocksHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: InsertBlocksResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.blocks):
            body['blocks'] = request.blocks
        if not UtilClient.is_unset(request.location):
            body['location'] = request.location
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
        params = open_api_models.Params(
            action='InsertBlocks',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/documents/{document_id}/blocks',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.InsertBlocksResponse(),
            await self.execute_async(params, req, runtime)
        )

    def insert_blocks(
        self,
        document_id: str,
        request: dingtalkdoc__1__0_models.InsertBlocksRequest,
    ) -> dingtalkdoc__1__0_models.InsertBlocksResponse:
        """
        @summary 向文档内插入块级元素
        
        @param request: InsertBlocksRequest
        @return: InsertBlocksResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.InsertBlocksHeaders()
        return self.insert_blocks_with_options(document_id, request, headers, runtime)

    async def insert_blocks_async(
        self,
        document_id: str,
        request: dingtalkdoc__1__0_models.InsertBlocksRequest,
    ) -> dingtalkdoc__1__0_models.InsertBlocksResponse:
        """
        @summary 向文档内插入块级元素
        
        @param request: InsertBlocksRequest
        @return: InsertBlocksResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.InsertBlocksHeaders()
        return await self.insert_blocks_with_options_async(document_id, request, headers, runtime)

    def insert_columns_before_with_options(
        self,
        workbook_id: str,
        sheet_id: str,
        request: dingtalkdoc__1__0_models.InsertColumnsBeforeRequest,
        headers: dingtalkdoc__1__0_models.InsertColumnsBeforeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.InsertColumnsBeforeResponse:
        """
        @summary 指定列左侧插入若干列
        
        @param request: InsertColumnsBeforeRequest
        @param headers: InsertColumnsBeforeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: InsertColumnsBeforeResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.column):
            body['column'] = request.column
        if not UtilClient.is_unset(request.column_count):
            body['columnCount'] = request.column_count
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='InsertColumnsBefore',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/sheets/{sheet_id}/insertColumnsBefore',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.InsertColumnsBeforeResponse(),
            self.execute(params, req, runtime)
        )

    async def insert_columns_before_with_options_async(
        self,
        workbook_id: str,
        sheet_id: str,
        request: dingtalkdoc__1__0_models.InsertColumnsBeforeRequest,
        headers: dingtalkdoc__1__0_models.InsertColumnsBeforeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.InsertColumnsBeforeResponse:
        """
        @summary 指定列左侧插入若干列
        
        @param request: InsertColumnsBeforeRequest
        @param headers: InsertColumnsBeforeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: InsertColumnsBeforeResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.column):
            body['column'] = request.column
        if not UtilClient.is_unset(request.column_count):
            body['columnCount'] = request.column_count
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='InsertColumnsBefore',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/sheets/{sheet_id}/insertColumnsBefore',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.InsertColumnsBeforeResponse(),
            await self.execute_async(params, req, runtime)
        )

    def insert_columns_before(
        self,
        workbook_id: str,
        sheet_id: str,
        request: dingtalkdoc__1__0_models.InsertColumnsBeforeRequest,
    ) -> dingtalkdoc__1__0_models.InsertColumnsBeforeResponse:
        """
        @summary 指定列左侧插入若干列
        
        @param request: InsertColumnsBeforeRequest
        @return: InsertColumnsBeforeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.InsertColumnsBeforeHeaders()
        return self.insert_columns_before_with_options(workbook_id, sheet_id, request, headers, runtime)

    async def insert_columns_before_async(
        self,
        workbook_id: str,
        sheet_id: str,
        request: dingtalkdoc__1__0_models.InsertColumnsBeforeRequest,
    ) -> dingtalkdoc__1__0_models.InsertColumnsBeforeResponse:
        """
        @summary 指定列左侧插入若干列
        
        @param request: InsertColumnsBeforeRequest
        @return: InsertColumnsBeforeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.InsertColumnsBeforeHeaders()
        return await self.insert_columns_before_with_options_async(workbook_id, sheet_id, request, headers, runtime)

    def insert_dropdown_lists_with_options(
        self,
        workbook_id: str,
        sheet_id: str,
        range_address: str,
        request: dingtalkdoc__1__0_models.InsertDropdownListsRequest,
        headers: dingtalkdoc__1__0_models.InsertDropdownListsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.InsertDropdownListsResponse:
        """
        @summary 插入下拉列表
        
        @param request: InsertDropdownListsRequest
        @param headers: InsertDropdownListsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: InsertDropdownListsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.options):
            body['options'] = request.options
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='InsertDropdownLists',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/sheets/{sheet_id}/ranges/{range_address}/insertDropdownLists',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.InsertDropdownListsResponse(),
            self.execute(params, req, runtime)
        )

    async def insert_dropdown_lists_with_options_async(
        self,
        workbook_id: str,
        sheet_id: str,
        range_address: str,
        request: dingtalkdoc__1__0_models.InsertDropdownListsRequest,
        headers: dingtalkdoc__1__0_models.InsertDropdownListsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.InsertDropdownListsResponse:
        """
        @summary 插入下拉列表
        
        @param request: InsertDropdownListsRequest
        @param headers: InsertDropdownListsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: InsertDropdownListsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.options):
            body['options'] = request.options
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='InsertDropdownLists',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/sheets/{sheet_id}/ranges/{range_address}/insertDropdownLists',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.InsertDropdownListsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def insert_dropdown_lists(
        self,
        workbook_id: str,
        sheet_id: str,
        range_address: str,
        request: dingtalkdoc__1__0_models.InsertDropdownListsRequest,
    ) -> dingtalkdoc__1__0_models.InsertDropdownListsResponse:
        """
        @summary 插入下拉列表
        
        @param request: InsertDropdownListsRequest
        @return: InsertDropdownListsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.InsertDropdownListsHeaders()
        return self.insert_dropdown_lists_with_options(workbook_id, sheet_id, range_address, request, headers, runtime)

    async def insert_dropdown_lists_async(
        self,
        workbook_id: str,
        sheet_id: str,
        range_address: str,
        request: dingtalkdoc__1__0_models.InsertDropdownListsRequest,
    ) -> dingtalkdoc__1__0_models.InsertDropdownListsResponse:
        """
        @summary 插入下拉列表
        
        @param request: InsertDropdownListsRequest
        @return: InsertDropdownListsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.InsertDropdownListsHeaders()
        return await self.insert_dropdown_lists_with_options_async(workbook_id, sheet_id, range_address, request, headers, runtime)

    def insert_rows_before_with_options(
        self,
        workbook_id: str,
        sheet_id: str,
        request: dingtalkdoc__1__0_models.InsertRowsBeforeRequest,
        headers: dingtalkdoc__1__0_models.InsertRowsBeforeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.InsertRowsBeforeResponse:
        """
        @summary 指定行上方插入若干行
        
        @param request: InsertRowsBeforeRequest
        @param headers: InsertRowsBeforeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: InsertRowsBeforeResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.row):
            body['row'] = request.row
        if not UtilClient.is_unset(request.row_count):
            body['rowCount'] = request.row_count
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='InsertRowsBefore',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/sheets/{sheet_id}/insertRowsBefore',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.InsertRowsBeforeResponse(),
            self.execute(params, req, runtime)
        )

    async def insert_rows_before_with_options_async(
        self,
        workbook_id: str,
        sheet_id: str,
        request: dingtalkdoc__1__0_models.InsertRowsBeforeRequest,
        headers: dingtalkdoc__1__0_models.InsertRowsBeforeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.InsertRowsBeforeResponse:
        """
        @summary 指定行上方插入若干行
        
        @param request: InsertRowsBeforeRequest
        @param headers: InsertRowsBeforeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: InsertRowsBeforeResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.row):
            body['row'] = request.row
        if not UtilClient.is_unset(request.row_count):
            body['rowCount'] = request.row_count
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='InsertRowsBefore',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/sheets/{sheet_id}/insertRowsBefore',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.InsertRowsBeforeResponse(),
            await self.execute_async(params, req, runtime)
        )

    def insert_rows_before(
        self,
        workbook_id: str,
        sheet_id: str,
        request: dingtalkdoc__1__0_models.InsertRowsBeforeRequest,
    ) -> dingtalkdoc__1__0_models.InsertRowsBeforeResponse:
        """
        @summary 指定行上方插入若干行
        
        @param request: InsertRowsBeforeRequest
        @return: InsertRowsBeforeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.InsertRowsBeforeHeaders()
        return self.insert_rows_before_with_options(workbook_id, sheet_id, request, headers, runtime)

    async def insert_rows_before_async(
        self,
        workbook_id: str,
        sheet_id: str,
        request: dingtalkdoc__1__0_models.InsertRowsBeforeRequest,
    ) -> dingtalkdoc__1__0_models.InsertRowsBeforeResponse:
        """
        @summary 指定行上方插入若干行
        
        @param request: InsertRowsBeforeRequest
        @return: InsertRowsBeforeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.InsertRowsBeforeHeaders()
        return await self.insert_rows_before_with_options_async(workbook_id, sheet_id, request, headers, runtime)

    def list_template_with_options(
        self,
        request: dingtalkdoc__1__0_models.ListTemplateRequest,
        headers: dingtalkdoc__1__0_models.ListTemplateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.ListTemplateResponse:
        """
        @summary 查询文档模版
        
        @param request: ListTemplateRequest
        @param headers: ListTemplateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListTemplateResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.template_type):
            query['templateType'] = request.template_type
        if not UtilClient.is_unset(request.workspace_id):
            query['workspaceId'] = request.workspace_id
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
            action='ListTemplate',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/templates',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.ListTemplateResponse(),
            self.execute(params, req, runtime)
        )

    async def list_template_with_options_async(
        self,
        request: dingtalkdoc__1__0_models.ListTemplateRequest,
        headers: dingtalkdoc__1__0_models.ListTemplateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.ListTemplateResponse:
        """
        @summary 查询文档模版
        
        @param request: ListTemplateRequest
        @param headers: ListTemplateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListTemplateResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.template_type):
            query['templateType'] = request.template_type
        if not UtilClient.is_unset(request.workspace_id):
            query['workspaceId'] = request.workspace_id
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
            action='ListTemplate',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/templates',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.ListTemplateResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_template(
        self,
        request: dingtalkdoc__1__0_models.ListTemplateRequest,
    ) -> dingtalkdoc__1__0_models.ListTemplateResponse:
        """
        @summary 查询文档模版
        
        @param request: ListTemplateRequest
        @return: ListTemplateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.ListTemplateHeaders()
        return self.list_template_with_options(request, headers, runtime)

    async def list_template_async(
        self,
        request: dingtalkdoc__1__0_models.ListTemplateRequest,
    ) -> dingtalkdoc__1__0_models.ListTemplateResponse:
        """
        @summary 查询文档模版
        
        @param request: ListTemplateRequest
        @return: ListTemplateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.ListTemplateHeaders()
        return await self.list_template_with_options_async(request, headers, runtime)

    def merge_range_with_options(
        self,
        workbook_id: str,
        sheet_id: str,
        range_address: str,
        request: dingtalkdoc__1__0_models.MergeRangeRequest,
        headers: dingtalkdoc__1__0_models.MergeRangeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.MergeRangeResponse:
        """
        @summary 合并单元格
        
        @param request: MergeRangeRequest
        @param headers: MergeRangeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: MergeRangeResponse
        """
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
        params = open_api_models.Params(
            action='MergeRange',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/sheets/{sheet_id}/ranges/{range_address}/merge',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.MergeRangeResponse(),
            self.execute(params, req, runtime)
        )

    async def merge_range_with_options_async(
        self,
        workbook_id: str,
        sheet_id: str,
        range_address: str,
        request: dingtalkdoc__1__0_models.MergeRangeRequest,
        headers: dingtalkdoc__1__0_models.MergeRangeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.MergeRangeResponse:
        """
        @summary 合并单元格
        
        @param request: MergeRangeRequest
        @param headers: MergeRangeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: MergeRangeResponse
        """
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
        params = open_api_models.Params(
            action='MergeRange',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/sheets/{sheet_id}/ranges/{range_address}/merge',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.MergeRangeResponse(),
            await self.execute_async(params, req, runtime)
        )

    def merge_range(
        self,
        workbook_id: str,
        sheet_id: str,
        range_address: str,
        request: dingtalkdoc__1__0_models.MergeRangeRequest,
    ) -> dingtalkdoc__1__0_models.MergeRangeResponse:
        """
        @summary 合并单元格
        
        @param request: MergeRangeRequest
        @return: MergeRangeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.MergeRangeHeaders()
        return self.merge_range_with_options(workbook_id, sheet_id, range_address, request, headers, runtime)

    async def merge_range_async(
        self,
        workbook_id: str,
        sheet_id: str,
        range_address: str,
        request: dingtalkdoc__1__0_models.MergeRangeRequest,
    ) -> dingtalkdoc__1__0_models.MergeRangeResponse:
        """
        @summary 合并单元格
        
        @param request: MergeRangeRequest
        @return: MergeRangeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.MergeRangeHeaders()
        return await self.merge_range_with_options_async(workbook_id, sheet_id, range_address, request, headers, runtime)

    def range_find_next_with_options(
        self,
        workbook_id: str,
        sheet_id: str,
        range_address: str,
        request: dingtalkdoc__1__0_models.RangeFindNextRequest,
        headers: dingtalkdoc__1__0_models.RangeFindNextHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.RangeFindNextResponse:
        """
        @summary 查找下一个符合条件的单元格
        
        @param request: RangeFindNextRequest
        @param headers: RangeFindNextHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RangeFindNextResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.find_options):
            body['findOptions'] = request.find_options
        if not UtilClient.is_unset(request.text):
            body['text'] = request.text
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='RangeFindNext',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/sheets/{sheet_id}/ranges/{range_address}/findNext',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.RangeFindNextResponse(),
            self.execute(params, req, runtime)
        )

    async def range_find_next_with_options_async(
        self,
        workbook_id: str,
        sheet_id: str,
        range_address: str,
        request: dingtalkdoc__1__0_models.RangeFindNextRequest,
        headers: dingtalkdoc__1__0_models.RangeFindNextHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.RangeFindNextResponse:
        """
        @summary 查找下一个符合条件的单元格
        
        @param request: RangeFindNextRequest
        @param headers: RangeFindNextHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RangeFindNextResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.find_options):
            body['findOptions'] = request.find_options
        if not UtilClient.is_unset(request.text):
            body['text'] = request.text
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='RangeFindNext',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/sheets/{sheet_id}/ranges/{range_address}/findNext',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.RangeFindNextResponse(),
            await self.execute_async(params, req, runtime)
        )

    def range_find_next(
        self,
        workbook_id: str,
        sheet_id: str,
        range_address: str,
        request: dingtalkdoc__1__0_models.RangeFindNextRequest,
    ) -> dingtalkdoc__1__0_models.RangeFindNextResponse:
        """
        @summary 查找下一个符合条件的单元格
        
        @param request: RangeFindNextRequest
        @return: RangeFindNextResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.RangeFindNextHeaders()
        return self.range_find_next_with_options(workbook_id, sheet_id, range_address, request, headers, runtime)

    async def range_find_next_async(
        self,
        workbook_id: str,
        sheet_id: str,
        range_address: str,
        request: dingtalkdoc__1__0_models.RangeFindNextRequest,
    ) -> dingtalkdoc__1__0_models.RangeFindNextResponse:
        """
        @summary 查找下一个符合条件的单元格
        
        @param request: RangeFindNextRequest
        @return: RangeFindNextResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.RangeFindNextHeaders()
        return await self.range_find_next_with_options_async(workbook_id, sheet_id, range_address, request, headers, runtime)

    def search_workspace_docs_with_options(
        self,
        request: dingtalkdoc__1__0_models.SearchWorkspaceDocsRequest,
        headers: dingtalkdoc__1__0_models.SearchWorkspaceDocsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.SearchWorkspaceDocsResponse:
        """
        @summary 搜索用户有权限的知识库文档
        
        @param request: SearchWorkspaceDocsRequest
        @param headers: SearchWorkspaceDocsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SearchWorkspaceDocsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.keyword):
            query['keyword'] = request.keyword
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.workspace_id):
            query['workspaceId'] = request.workspace_id
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
            action='SearchWorkspaceDocs',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/docs',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.SearchWorkspaceDocsResponse(),
            self.execute(params, req, runtime)
        )

    async def search_workspace_docs_with_options_async(
        self,
        request: dingtalkdoc__1__0_models.SearchWorkspaceDocsRequest,
        headers: dingtalkdoc__1__0_models.SearchWorkspaceDocsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.SearchWorkspaceDocsResponse:
        """
        @summary 搜索用户有权限的知识库文档
        
        @param request: SearchWorkspaceDocsRequest
        @param headers: SearchWorkspaceDocsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SearchWorkspaceDocsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.keyword):
            query['keyword'] = request.keyword
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.workspace_id):
            query['workspaceId'] = request.workspace_id
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
            action='SearchWorkspaceDocs',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/docs',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.SearchWorkspaceDocsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def search_workspace_docs(
        self,
        request: dingtalkdoc__1__0_models.SearchWorkspaceDocsRequest,
    ) -> dingtalkdoc__1__0_models.SearchWorkspaceDocsResponse:
        """
        @summary 搜索用户有权限的知识库文档
        
        @param request: SearchWorkspaceDocsRequest
        @return: SearchWorkspaceDocsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.SearchWorkspaceDocsHeaders()
        return self.search_workspace_docs_with_options(request, headers, runtime)

    async def search_workspace_docs_async(
        self,
        request: dingtalkdoc__1__0_models.SearchWorkspaceDocsRequest,
    ) -> dingtalkdoc__1__0_models.SearchWorkspaceDocsResponse:
        """
        @summary 搜索用户有权限的知识库文档
        
        @param request: SearchWorkspaceDocsRequest
        @return: SearchWorkspaceDocsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.SearchWorkspaceDocsHeaders()
        return await self.search_workspace_docs_with_options_async(request, headers, runtime)

    def set_column_width_with_options(
        self,
        workbook_id: str,
        sheet_id: str,
        request: dingtalkdoc__1__0_models.SetColumnWidthRequest,
        headers: dingtalkdoc__1__0_models.SetColumnWidthHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.SetColumnWidthResponse:
        """
        @summary 设置列宽
        
        @param request: SetColumnWidthRequest
        @param headers: SetColumnWidthHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SetColumnWidthResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.column):
            body['column'] = request.column
        if not UtilClient.is_unset(request.width):
            body['width'] = request.width
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SetColumnWidth',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/sheets/{sheet_id}/setColumnWidth',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.SetColumnWidthResponse(),
            self.execute(params, req, runtime)
        )

    async def set_column_width_with_options_async(
        self,
        workbook_id: str,
        sheet_id: str,
        request: dingtalkdoc__1__0_models.SetColumnWidthRequest,
        headers: dingtalkdoc__1__0_models.SetColumnWidthHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.SetColumnWidthResponse:
        """
        @summary 设置列宽
        
        @param request: SetColumnWidthRequest
        @param headers: SetColumnWidthHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SetColumnWidthResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.column):
            body['column'] = request.column
        if not UtilClient.is_unset(request.width):
            body['width'] = request.width
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SetColumnWidth',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/sheets/{sheet_id}/setColumnWidth',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.SetColumnWidthResponse(),
            await self.execute_async(params, req, runtime)
        )

    def set_column_width(
        self,
        workbook_id: str,
        sheet_id: str,
        request: dingtalkdoc__1__0_models.SetColumnWidthRequest,
    ) -> dingtalkdoc__1__0_models.SetColumnWidthResponse:
        """
        @summary 设置列宽
        
        @param request: SetColumnWidthRequest
        @return: SetColumnWidthResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.SetColumnWidthHeaders()
        return self.set_column_width_with_options(workbook_id, sheet_id, request, headers, runtime)

    async def set_column_width_async(
        self,
        workbook_id: str,
        sheet_id: str,
        request: dingtalkdoc__1__0_models.SetColumnWidthRequest,
    ) -> dingtalkdoc__1__0_models.SetColumnWidthResponse:
        """
        @summary 设置列宽
        
        @param request: SetColumnWidthRequest
        @return: SetColumnWidthResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.SetColumnWidthHeaders()
        return await self.set_column_width_with_options_async(workbook_id, sheet_id, request, headers, runtime)

    def set_columns_visibility_with_options(
        self,
        workbook_id: str,
        sheet_id: str,
        request: dingtalkdoc__1__0_models.SetColumnsVisibilityRequest,
        headers: dingtalkdoc__1__0_models.SetColumnsVisibilityHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.SetColumnsVisibilityResponse:
        """
        @summary 设置列隐藏或显示
        
        @param request: SetColumnsVisibilityRequest
        @param headers: SetColumnsVisibilityHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SetColumnsVisibilityResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.column):
            body['column'] = request.column
        if not UtilClient.is_unset(request.column_count):
            body['columnCount'] = request.column_count
        if not UtilClient.is_unset(request.visibility):
            body['visibility'] = request.visibility
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SetColumnsVisibility',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/sheets/{sheet_id}/setColumnsVisibility',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.SetColumnsVisibilityResponse(),
            self.execute(params, req, runtime)
        )

    async def set_columns_visibility_with_options_async(
        self,
        workbook_id: str,
        sheet_id: str,
        request: dingtalkdoc__1__0_models.SetColumnsVisibilityRequest,
        headers: dingtalkdoc__1__0_models.SetColumnsVisibilityHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.SetColumnsVisibilityResponse:
        """
        @summary 设置列隐藏或显示
        
        @param request: SetColumnsVisibilityRequest
        @param headers: SetColumnsVisibilityHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SetColumnsVisibilityResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.column):
            body['column'] = request.column
        if not UtilClient.is_unset(request.column_count):
            body['columnCount'] = request.column_count
        if not UtilClient.is_unset(request.visibility):
            body['visibility'] = request.visibility
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SetColumnsVisibility',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/sheets/{sheet_id}/setColumnsVisibility',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.SetColumnsVisibilityResponse(),
            await self.execute_async(params, req, runtime)
        )

    def set_columns_visibility(
        self,
        workbook_id: str,
        sheet_id: str,
        request: dingtalkdoc__1__0_models.SetColumnsVisibilityRequest,
    ) -> dingtalkdoc__1__0_models.SetColumnsVisibilityResponse:
        """
        @summary 设置列隐藏或显示
        
        @param request: SetColumnsVisibilityRequest
        @return: SetColumnsVisibilityResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.SetColumnsVisibilityHeaders()
        return self.set_columns_visibility_with_options(workbook_id, sheet_id, request, headers, runtime)

    async def set_columns_visibility_async(
        self,
        workbook_id: str,
        sheet_id: str,
        request: dingtalkdoc__1__0_models.SetColumnsVisibilityRequest,
    ) -> dingtalkdoc__1__0_models.SetColumnsVisibilityResponse:
        """
        @summary 设置列隐藏或显示
        
        @param request: SetColumnsVisibilityRequest
        @return: SetColumnsVisibilityResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.SetColumnsVisibilityHeaders()
        return await self.set_columns_visibility_with_options_async(workbook_id, sheet_id, request, headers, runtime)

    def set_row_height_with_options(
        self,
        workbook_id: str,
        sheet_id: str,
        request: dingtalkdoc__1__0_models.SetRowHeightRequest,
        headers: dingtalkdoc__1__0_models.SetRowHeightHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.SetRowHeightResponse:
        """
        @summary 设置行高
        
        @param request: SetRowHeightRequest
        @param headers: SetRowHeightHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SetRowHeightResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.height):
            body['height'] = request.height
        if not UtilClient.is_unset(request.row):
            body['row'] = request.row
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SetRowHeight',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/sheets/{sheet_id}/setRowHeight',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.SetRowHeightResponse(),
            self.execute(params, req, runtime)
        )

    async def set_row_height_with_options_async(
        self,
        workbook_id: str,
        sheet_id: str,
        request: dingtalkdoc__1__0_models.SetRowHeightRequest,
        headers: dingtalkdoc__1__0_models.SetRowHeightHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.SetRowHeightResponse:
        """
        @summary 设置行高
        
        @param request: SetRowHeightRequest
        @param headers: SetRowHeightHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SetRowHeightResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.height):
            body['height'] = request.height
        if not UtilClient.is_unset(request.row):
            body['row'] = request.row
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SetRowHeight',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/sheets/{sheet_id}/setRowHeight',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.SetRowHeightResponse(),
            await self.execute_async(params, req, runtime)
        )

    def set_row_height(
        self,
        workbook_id: str,
        sheet_id: str,
        request: dingtalkdoc__1__0_models.SetRowHeightRequest,
    ) -> dingtalkdoc__1__0_models.SetRowHeightResponse:
        """
        @summary 设置行高
        
        @param request: SetRowHeightRequest
        @return: SetRowHeightResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.SetRowHeightHeaders()
        return self.set_row_height_with_options(workbook_id, sheet_id, request, headers, runtime)

    async def set_row_height_async(
        self,
        workbook_id: str,
        sheet_id: str,
        request: dingtalkdoc__1__0_models.SetRowHeightRequest,
    ) -> dingtalkdoc__1__0_models.SetRowHeightResponse:
        """
        @summary 设置行高
        
        @param request: SetRowHeightRequest
        @return: SetRowHeightResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.SetRowHeightHeaders()
        return await self.set_row_height_with_options_async(workbook_id, sheet_id, request, headers, runtime)

    def set_rows_visibility_with_options(
        self,
        workbook_id: str,
        sheet_id: str,
        request: dingtalkdoc__1__0_models.SetRowsVisibilityRequest,
        headers: dingtalkdoc__1__0_models.SetRowsVisibilityHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.SetRowsVisibilityResponse:
        """
        @summary 设置行隐藏或显示
        
        @param request: SetRowsVisibilityRequest
        @param headers: SetRowsVisibilityHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SetRowsVisibilityResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.row):
            body['row'] = request.row
        if not UtilClient.is_unset(request.row_count):
            body['rowCount'] = request.row_count
        if not UtilClient.is_unset(request.visibility):
            body['visibility'] = request.visibility
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SetRowsVisibility',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/sheets/{sheet_id}/setRowsVisibility',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.SetRowsVisibilityResponse(),
            self.execute(params, req, runtime)
        )

    async def set_rows_visibility_with_options_async(
        self,
        workbook_id: str,
        sheet_id: str,
        request: dingtalkdoc__1__0_models.SetRowsVisibilityRequest,
        headers: dingtalkdoc__1__0_models.SetRowsVisibilityHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.SetRowsVisibilityResponse:
        """
        @summary 设置行隐藏或显示
        
        @param request: SetRowsVisibilityRequest
        @param headers: SetRowsVisibilityHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SetRowsVisibilityResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.row):
            body['row'] = request.row
        if not UtilClient.is_unset(request.row_count):
            body['rowCount'] = request.row_count
        if not UtilClient.is_unset(request.visibility):
            body['visibility'] = request.visibility
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SetRowsVisibility',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/sheets/{sheet_id}/setRowsVisibility',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.SetRowsVisibilityResponse(),
            await self.execute_async(params, req, runtime)
        )

    def set_rows_visibility(
        self,
        workbook_id: str,
        sheet_id: str,
        request: dingtalkdoc__1__0_models.SetRowsVisibilityRequest,
    ) -> dingtalkdoc__1__0_models.SetRowsVisibilityResponse:
        """
        @summary 设置行隐藏或显示
        
        @param request: SetRowsVisibilityRequest
        @return: SetRowsVisibilityResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.SetRowsVisibilityHeaders()
        return self.set_rows_visibility_with_options(workbook_id, sheet_id, request, headers, runtime)

    async def set_rows_visibility_async(
        self,
        workbook_id: str,
        sheet_id: str,
        request: dingtalkdoc__1__0_models.SetRowsVisibilityRequest,
    ) -> dingtalkdoc__1__0_models.SetRowsVisibilityResponse:
        """
        @summary 设置行隐藏或显示
        
        @param request: SetRowsVisibilityRequest
        @return: SetRowsVisibilityResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.SetRowsVisibilityHeaders()
        return await self.set_rows_visibility_with_options_async(workbook_id, sheet_id, request, headers, runtime)

    def sheet_autofit_rows_with_options(
        self,
        workbook_id: str,
        sheet_id: str,
        request: dingtalkdoc__1__0_models.SheetAutofitRowsRequest,
        headers: dingtalkdoc__1__0_models.SheetAutofitRowsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.SheetAutofitRowsResponse:
        """
        @summary SheetAutofitRows
        
        @param request: SheetAutofitRowsRequest
        @param headers: SheetAutofitRowsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SheetAutofitRowsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.font_width):
            body['fontWidth'] = request.font_width
        if not UtilClient.is_unset(request.row):
            body['row'] = request.row
        if not UtilClient.is_unset(request.row_count):
            body['rowCount'] = request.row_count
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SheetAutofitRows',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/sheets/{sheet_id}/autofitRows',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.SheetAutofitRowsResponse(),
            self.execute(params, req, runtime)
        )

    async def sheet_autofit_rows_with_options_async(
        self,
        workbook_id: str,
        sheet_id: str,
        request: dingtalkdoc__1__0_models.SheetAutofitRowsRequest,
        headers: dingtalkdoc__1__0_models.SheetAutofitRowsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.SheetAutofitRowsResponse:
        """
        @summary SheetAutofitRows
        
        @param request: SheetAutofitRowsRequest
        @param headers: SheetAutofitRowsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SheetAutofitRowsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.font_width):
            body['fontWidth'] = request.font_width
        if not UtilClient.is_unset(request.row):
            body['row'] = request.row
        if not UtilClient.is_unset(request.row_count):
            body['rowCount'] = request.row_count
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SheetAutofitRows',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/sheets/{sheet_id}/autofitRows',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.SheetAutofitRowsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def sheet_autofit_rows(
        self,
        workbook_id: str,
        sheet_id: str,
        request: dingtalkdoc__1__0_models.SheetAutofitRowsRequest,
    ) -> dingtalkdoc__1__0_models.SheetAutofitRowsResponse:
        """
        @summary SheetAutofitRows
        
        @param request: SheetAutofitRowsRequest
        @return: SheetAutofitRowsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.SheetAutofitRowsHeaders()
        return self.sheet_autofit_rows_with_options(workbook_id, sheet_id, request, headers, runtime)

    async def sheet_autofit_rows_async(
        self,
        workbook_id: str,
        sheet_id: str,
        request: dingtalkdoc__1__0_models.SheetAutofitRowsRequest,
    ) -> dingtalkdoc__1__0_models.SheetAutofitRowsResponse:
        """
        @summary SheetAutofitRows
        
        @param request: SheetAutofitRowsRequest
        @return: SheetAutofitRowsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.SheetAutofitRowsHeaders()
        return await self.sheet_autofit_rows_with_options_async(workbook_id, sheet_id, request, headers, runtime)

    def sheet_find_all_with_options(
        self,
        workbook_id: str,
        sheet_id: str,
        request: dingtalkdoc__1__0_models.SheetFindAllRequest,
        headers: dingtalkdoc__1__0_models.SheetFindAllHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.SheetFindAllResponse:
        """
        @summary 工作表上查找所有符合条件的单元格
        
        @param request: SheetFindAllRequest
        @param headers: SheetFindAllHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SheetFindAllResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.select):
            query['select'] = request.select
        body = {}
        if not UtilClient.is_unset(request.find_options):
            body['findOptions'] = request.find_options
        if not UtilClient.is_unset(request.text):
            body['text'] = request.text
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SheetFindAll',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/sheets/{sheet_id}/findAll',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.SheetFindAllResponse(),
            self.execute(params, req, runtime)
        )

    async def sheet_find_all_with_options_async(
        self,
        workbook_id: str,
        sheet_id: str,
        request: dingtalkdoc__1__0_models.SheetFindAllRequest,
        headers: dingtalkdoc__1__0_models.SheetFindAllHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.SheetFindAllResponse:
        """
        @summary 工作表上查找所有符合条件的单元格
        
        @param request: SheetFindAllRequest
        @param headers: SheetFindAllHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SheetFindAllResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.select):
            query['select'] = request.select
        body = {}
        if not UtilClient.is_unset(request.find_options):
            body['findOptions'] = request.find_options
        if not UtilClient.is_unset(request.text):
            body['text'] = request.text
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SheetFindAll',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/sheets/{sheet_id}/findAll',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.SheetFindAllResponse(),
            await self.execute_async(params, req, runtime)
        )

    def sheet_find_all(
        self,
        workbook_id: str,
        sheet_id: str,
        request: dingtalkdoc__1__0_models.SheetFindAllRequest,
    ) -> dingtalkdoc__1__0_models.SheetFindAllResponse:
        """
        @summary 工作表上查找所有符合条件的单元格
        
        @param request: SheetFindAllRequest
        @return: SheetFindAllResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.SheetFindAllHeaders()
        return self.sheet_find_all_with_options(workbook_id, sheet_id, request, headers, runtime)

    async def sheet_find_all_async(
        self,
        workbook_id: str,
        sheet_id: str,
        request: dingtalkdoc__1__0_models.SheetFindAllRequest,
    ) -> dingtalkdoc__1__0_models.SheetFindAllResponse:
        """
        @summary 工作表上查找所有符合条件的单元格
        
        @param request: SheetFindAllRequest
        @return: SheetFindAllResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.SheetFindAllHeaders()
        return await self.sheet_find_all_with_options_async(workbook_id, sheet_id, request, headers, runtime)

    def unbind_cool_app_to_sheet_with_options(
        self,
        workbook_id: str,
        request: dingtalkdoc__1__0_models.UnbindCoolAppToSheetRequest,
        headers: dingtalkdoc__1__0_models.UnbindCoolAppToSheetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.UnbindCoolAppToSheetResponse:
        """
        @summary 取消文档酷应用和表格的关联
        
        @param request: UnbindCoolAppToSheetRequest
        @param headers: UnbindCoolAppToSheetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UnbindCoolAppToSheetResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.cool_app_code):
            query['coolAppCode'] = request.cool_app_code
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
        params = open_api_models.Params(
            action='UnbindCoolAppToSheet',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/coolApps',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.UnbindCoolAppToSheetResponse(),
            self.execute(params, req, runtime)
        )

    async def unbind_cool_app_to_sheet_with_options_async(
        self,
        workbook_id: str,
        request: dingtalkdoc__1__0_models.UnbindCoolAppToSheetRequest,
        headers: dingtalkdoc__1__0_models.UnbindCoolAppToSheetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.UnbindCoolAppToSheetResponse:
        """
        @summary 取消文档酷应用和表格的关联
        
        @param request: UnbindCoolAppToSheetRequest
        @param headers: UnbindCoolAppToSheetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UnbindCoolAppToSheetResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.cool_app_code):
            query['coolAppCode'] = request.cool_app_code
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
        params = open_api_models.Params(
            action='UnbindCoolAppToSheet',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/coolApps',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.UnbindCoolAppToSheetResponse(),
            await self.execute_async(params, req, runtime)
        )

    def unbind_cool_app_to_sheet(
        self,
        workbook_id: str,
        request: dingtalkdoc__1__0_models.UnbindCoolAppToSheetRequest,
    ) -> dingtalkdoc__1__0_models.UnbindCoolAppToSheetResponse:
        """
        @summary 取消文档酷应用和表格的关联
        
        @param request: UnbindCoolAppToSheetRequest
        @return: UnbindCoolAppToSheetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.UnbindCoolAppToSheetHeaders()
        return self.unbind_cool_app_to_sheet_with_options(workbook_id, request, headers, runtime)

    async def unbind_cool_app_to_sheet_async(
        self,
        workbook_id: str,
        request: dingtalkdoc__1__0_models.UnbindCoolAppToSheetRequest,
    ) -> dingtalkdoc__1__0_models.UnbindCoolAppToSheetResponse:
        """
        @summary 取消文档酷应用和表格的关联
        
        @param request: UnbindCoolAppToSheetRequest
        @return: UnbindCoolAppToSheetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.UnbindCoolAppToSheetHeaders()
        return await self.unbind_cool_app_to_sheet_with_options_async(workbook_id, request, headers, runtime)

    def update_range_with_options(
        self,
        workbook_id: str,
        sheet_id: str,
        range_address: str,
        request: dingtalkdoc__1__0_models.UpdateRangeRequest,
        headers: dingtalkdoc__1__0_models.UpdateRangeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.UpdateRangeResponse:
        """
        @summary 更新单元格区域
        
        @param request: UpdateRangeRequest
        @param headers: UpdateRangeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateRangeResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.background_colors):
            body['backgroundColors'] = request.background_colors
        if not UtilClient.is_unset(request.font_sizes):
            body['fontSizes'] = request.font_sizes
        if not UtilClient.is_unset(request.font_weights):
            body['fontWeights'] = request.font_weights
        if not UtilClient.is_unset(request.horizontal_alignments):
            body['horizontalAlignments'] = request.horizontal_alignments
        if not UtilClient.is_unset(request.hyperlinks):
            body['hyperlinks'] = request.hyperlinks
        if not UtilClient.is_unset(request.number_format):
            body['numberFormat'] = request.number_format
        if not UtilClient.is_unset(request.values):
            body['values'] = request.values
        if not UtilClient.is_unset(request.vertical_alignments):
            body['verticalAlignments'] = request.vertical_alignments
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateRange',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/sheets/{sheet_id}/ranges/{range_address}',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.UpdateRangeResponse(),
            self.execute(params, req, runtime)
        )

    async def update_range_with_options_async(
        self,
        workbook_id: str,
        sheet_id: str,
        range_address: str,
        request: dingtalkdoc__1__0_models.UpdateRangeRequest,
        headers: dingtalkdoc__1__0_models.UpdateRangeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.UpdateRangeResponse:
        """
        @summary 更新单元格区域
        
        @param request: UpdateRangeRequest
        @param headers: UpdateRangeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateRangeResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.background_colors):
            body['backgroundColors'] = request.background_colors
        if not UtilClient.is_unset(request.font_sizes):
            body['fontSizes'] = request.font_sizes
        if not UtilClient.is_unset(request.font_weights):
            body['fontWeights'] = request.font_weights
        if not UtilClient.is_unset(request.horizontal_alignments):
            body['horizontalAlignments'] = request.horizontal_alignments
        if not UtilClient.is_unset(request.hyperlinks):
            body['hyperlinks'] = request.hyperlinks
        if not UtilClient.is_unset(request.number_format):
            body['numberFormat'] = request.number_format
        if not UtilClient.is_unset(request.values):
            body['values'] = request.values
        if not UtilClient.is_unset(request.vertical_alignments):
            body['verticalAlignments'] = request.vertical_alignments
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateRange',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/sheets/{sheet_id}/ranges/{range_address}',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.UpdateRangeResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_range(
        self,
        workbook_id: str,
        sheet_id: str,
        range_address: str,
        request: dingtalkdoc__1__0_models.UpdateRangeRequest,
    ) -> dingtalkdoc__1__0_models.UpdateRangeResponse:
        """
        @summary 更新单元格区域
        
        @param request: UpdateRangeRequest
        @return: UpdateRangeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.UpdateRangeHeaders()
        return self.update_range_with_options(workbook_id, sheet_id, range_address, request, headers, runtime)

    async def update_range_async(
        self,
        workbook_id: str,
        sheet_id: str,
        range_address: str,
        request: dingtalkdoc__1__0_models.UpdateRangeRequest,
    ) -> dingtalkdoc__1__0_models.UpdateRangeResponse:
        """
        @summary 更新单元格区域
        
        @param request: UpdateRangeRequest
        @return: UpdateRangeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.UpdateRangeHeaders()
        return await self.update_range_with_options_async(workbook_id, sheet_id, range_address, request, headers, runtime)

    def update_sheet_with_options(
        self,
        workbook_id: str,
        sheet_id: str,
        request: dingtalkdoc__1__0_models.UpdateSheetRequest,
        headers: dingtalkdoc__1__0_models.UpdateSheetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.UpdateSheetResponse:
        """
        @summary 更新工作表
        
        @param request: UpdateSheetRequest
        @param headers: UpdateSheetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateSheetResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.visibility):
            body['visibility'] = request.visibility
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateSheet',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/sheets/{sheet_id}',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.UpdateSheetResponse(),
            self.execute(params, req, runtime)
        )

    async def update_sheet_with_options_async(
        self,
        workbook_id: str,
        sheet_id: str,
        request: dingtalkdoc__1__0_models.UpdateSheetRequest,
        headers: dingtalkdoc__1__0_models.UpdateSheetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.UpdateSheetResponse:
        """
        @summary 更新工作表
        
        @param request: UpdateSheetRequest
        @param headers: UpdateSheetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateSheetResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.visibility):
            body['visibility'] = request.visibility
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateSheet',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workbooks/{workbook_id}/sheets/{sheet_id}',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.UpdateSheetResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_sheet(
        self,
        workbook_id: str,
        sheet_id: str,
        request: dingtalkdoc__1__0_models.UpdateSheetRequest,
    ) -> dingtalkdoc__1__0_models.UpdateSheetResponse:
        """
        @summary 更新工作表
        
        @param request: UpdateSheetRequest
        @return: UpdateSheetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.UpdateSheetHeaders()
        return self.update_sheet_with_options(workbook_id, sheet_id, request, headers, runtime)

    async def update_sheet_async(
        self,
        workbook_id: str,
        sheet_id: str,
        request: dingtalkdoc__1__0_models.UpdateSheetRequest,
    ) -> dingtalkdoc__1__0_models.UpdateSheetResponse:
        """
        @summary 更新工作表
        
        @param request: UpdateSheetRequest
        @return: UpdateSheetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.UpdateSheetHeaders()
        return await self.update_sheet_with_options_async(workbook_id, sheet_id, request, headers, runtime)

    def update_workspace_doc_members_with_options(
        self,
        workspace_id: str,
        node_id: str,
        request: dingtalkdoc__1__0_models.UpdateWorkspaceDocMembersRequest,
        headers: dingtalkdoc__1__0_models.UpdateWorkspaceDocMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.UpdateWorkspaceDocMembersResponse:
        """
        @summary 修改知识库文档成员
        
        @param request: UpdateWorkspaceDocMembersRequest
        @param headers: UpdateWorkspaceDocMembersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateWorkspaceDocMembersResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
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
        params = open_api_models.Params(
            action='UpdateWorkspaceDocMembers',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workspaces/{workspace_id}/docs/{node_id}/members',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.UpdateWorkspaceDocMembersResponse(),
            self.execute(params, req, runtime)
        )

    async def update_workspace_doc_members_with_options_async(
        self,
        workspace_id: str,
        node_id: str,
        request: dingtalkdoc__1__0_models.UpdateWorkspaceDocMembersRequest,
        headers: dingtalkdoc__1__0_models.UpdateWorkspaceDocMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.UpdateWorkspaceDocMembersResponse:
        """
        @summary 修改知识库文档成员
        
        @param request: UpdateWorkspaceDocMembersRequest
        @param headers: UpdateWorkspaceDocMembersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateWorkspaceDocMembersResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
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
        params = open_api_models.Params(
            action='UpdateWorkspaceDocMembers',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workspaces/{workspace_id}/docs/{node_id}/members',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.UpdateWorkspaceDocMembersResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_workspace_doc_members(
        self,
        workspace_id: str,
        node_id: str,
        request: dingtalkdoc__1__0_models.UpdateWorkspaceDocMembersRequest,
    ) -> dingtalkdoc__1__0_models.UpdateWorkspaceDocMembersResponse:
        """
        @summary 修改知识库文档成员
        
        @param request: UpdateWorkspaceDocMembersRequest
        @return: UpdateWorkspaceDocMembersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.UpdateWorkspaceDocMembersHeaders()
        return self.update_workspace_doc_members_with_options(workspace_id, node_id, request, headers, runtime)

    async def update_workspace_doc_members_async(
        self,
        workspace_id: str,
        node_id: str,
        request: dingtalkdoc__1__0_models.UpdateWorkspaceDocMembersRequest,
    ) -> dingtalkdoc__1__0_models.UpdateWorkspaceDocMembersResponse:
        """
        @summary 修改知识库文档成员
        
        @param request: UpdateWorkspaceDocMembersRequest
        @return: UpdateWorkspaceDocMembersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.UpdateWorkspaceDocMembersHeaders()
        return await self.update_workspace_doc_members_with_options_async(workspace_id, node_id, request, headers, runtime)

    def update_workspace_members_with_options(
        self,
        workspace_id: str,
        request: dingtalkdoc__1__0_models.UpdateWorkspaceMembersRequest,
        headers: dingtalkdoc__1__0_models.UpdateWorkspaceMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.UpdateWorkspaceMembersResponse:
        """
        @summary 更新知识库成员
        
        @param request: UpdateWorkspaceMembersRequest
        @param headers: UpdateWorkspaceMembersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateWorkspaceMembersResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
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
        params = open_api_models.Params(
            action='UpdateWorkspaceMembers',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workspaces/{workspace_id}/members',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.UpdateWorkspaceMembersResponse(),
            self.execute(params, req, runtime)
        )

    async def update_workspace_members_with_options_async(
        self,
        workspace_id: str,
        request: dingtalkdoc__1__0_models.UpdateWorkspaceMembersRequest,
        headers: dingtalkdoc__1__0_models.UpdateWorkspaceMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.UpdateWorkspaceMembersResponse:
        """
        @summary 更新知识库成员
        
        @param request: UpdateWorkspaceMembersRequest
        @param headers: UpdateWorkspaceMembersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateWorkspaceMembersResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
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
        params = open_api_models.Params(
            action='UpdateWorkspaceMembers',
            version='doc_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/doc/workspaces/{workspace_id}/members',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.UpdateWorkspaceMembersResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_workspace_members(
        self,
        workspace_id: str,
        request: dingtalkdoc__1__0_models.UpdateWorkspaceMembersRequest,
    ) -> dingtalkdoc__1__0_models.UpdateWorkspaceMembersResponse:
        """
        @summary 更新知识库成员
        
        @param request: UpdateWorkspaceMembersRequest
        @return: UpdateWorkspaceMembersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.UpdateWorkspaceMembersHeaders()
        return self.update_workspace_members_with_options(workspace_id, request, headers, runtime)

    async def update_workspace_members_async(
        self,
        workspace_id: str,
        request: dingtalkdoc__1__0_models.UpdateWorkspaceMembersRequest,
    ) -> dingtalkdoc__1__0_models.UpdateWorkspaceMembersResponse:
        """
        @summary 更新知识库成员
        
        @param request: UpdateWorkspaceMembersRequest
        @return: UpdateWorkspaceMembersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.UpdateWorkspaceMembersHeaders()
        return await self.update_workspace_members_with_options_async(workspace_id, request, headers, runtime)
