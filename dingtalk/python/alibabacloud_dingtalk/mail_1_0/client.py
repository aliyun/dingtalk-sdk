# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.mail_1_0 import models as dingtalkmail__1__0_models
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

    def create_mail_folder_with_options(
        self,
        email: str,
        request: dingtalkmail__1__0_models.CreateMailFolderRequest,
        headers: dingtalkmail__1__0_models.CreateMailFolderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmail__1__0_models.CreateMailFolderResponse:
        """
        @summary 创建邮件文件夹
        
        @param request: CreateMailFolderRequest
        @param headers: CreateMailFolderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateMailFolderResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.display_name):
            body['displayName'] = request.display_name
        if not UtilClient.is_unset(request.extensions):
            body['extensions'] = request.extensions
        if not UtilClient.is_unset(request.foler_id):
            body['folerId'] = request.foler_id
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
            action='CreateMailFolder',
            version='mail_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/mail/users/{email}/mailFolders',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmail__1__0_models.CreateMailFolderResponse(),
            self.execute(params, req, runtime)
        )

    async def create_mail_folder_with_options_async(
        self,
        email: str,
        request: dingtalkmail__1__0_models.CreateMailFolderRequest,
        headers: dingtalkmail__1__0_models.CreateMailFolderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmail__1__0_models.CreateMailFolderResponse:
        """
        @summary 创建邮件文件夹
        
        @param request: CreateMailFolderRequest
        @param headers: CreateMailFolderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateMailFolderResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.display_name):
            body['displayName'] = request.display_name
        if not UtilClient.is_unset(request.extensions):
            body['extensions'] = request.extensions
        if not UtilClient.is_unset(request.foler_id):
            body['folerId'] = request.foler_id
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
            action='CreateMailFolder',
            version='mail_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/mail/users/{email}/mailFolders',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmail__1__0_models.CreateMailFolderResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_mail_folder(
        self,
        email: str,
        request: dingtalkmail__1__0_models.CreateMailFolderRequest,
    ) -> dingtalkmail__1__0_models.CreateMailFolderResponse:
        """
        @summary 创建邮件文件夹
        
        @param request: CreateMailFolderRequest
        @return: CreateMailFolderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmail__1__0_models.CreateMailFolderHeaders()
        return self.create_mail_folder_with_options(email, request, headers, runtime)

    async def create_mail_folder_async(
        self,
        email: str,
        request: dingtalkmail__1__0_models.CreateMailFolderRequest,
    ) -> dingtalkmail__1__0_models.CreateMailFolderResponse:
        """
        @summary 创建邮件文件夹
        
        @param request: CreateMailFolderRequest
        @return: CreateMailFolderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmail__1__0_models.CreateMailFolderHeaders()
        return await self.create_mail_folder_with_options_async(email, request, headers, runtime)

    def create_message_with_options(
        self,
        email: str,
        request: dingtalkmail__1__0_models.CreateMessageRequest,
        headers: dingtalkmail__1__0_models.CreateMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmail__1__0_models.CreateMessageResponse:
        """
        @summary 创建草稿
        
        @param request: CreateMessageRequest
        @param headers: CreateMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateMessageResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.message):
            body['message'] = request.message
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
            action='CreateMessage',
            version='mail_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/mail/users/{email}/messages',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmail__1__0_models.CreateMessageResponse(),
            self.execute(params, req, runtime)
        )

    async def create_message_with_options_async(
        self,
        email: str,
        request: dingtalkmail__1__0_models.CreateMessageRequest,
        headers: dingtalkmail__1__0_models.CreateMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmail__1__0_models.CreateMessageResponse:
        """
        @summary 创建草稿
        
        @param request: CreateMessageRequest
        @param headers: CreateMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateMessageResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.message):
            body['message'] = request.message
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
            action='CreateMessage',
            version='mail_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/mail/users/{email}/messages',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmail__1__0_models.CreateMessageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_message(
        self,
        email: str,
        request: dingtalkmail__1__0_models.CreateMessageRequest,
    ) -> dingtalkmail__1__0_models.CreateMessageResponse:
        """
        @summary 创建草稿
        
        @param request: CreateMessageRequest
        @return: CreateMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmail__1__0_models.CreateMessageHeaders()
        return self.create_message_with_options(email, request, headers, runtime)

    async def create_message_async(
        self,
        email: str,
        request: dingtalkmail__1__0_models.CreateMessageRequest,
    ) -> dingtalkmail__1__0_models.CreateMessageResponse:
        """
        @summary 创建草稿
        
        @param request: CreateMessageRequest
        @return: CreateMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmail__1__0_models.CreateMessageHeaders()
        return await self.create_message_with_options_async(email, request, headers, runtime)

    def create_user_with_options(
        self,
        request: dingtalkmail__1__0_models.CreateUserRequest,
        headers: dingtalkmail__1__0_models.CreateUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmail__1__0_models.CreateUserResponse:
        """
        @summary 创建企业邮箱用户
        
        @param request: CreateUserRequest
        @param headers: CreateUserHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateUserResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.email):
            body['email'] = request.email
        if not UtilClient.is_unset(request.employee_type):
            body['employeeType'] = request.employee_type
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.password):
            body['password'] = request.password
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
            action='CreateUser',
            version='mail_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/mail/users',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmail__1__0_models.CreateUserResponse(),
            self.execute(params, req, runtime)
        )

    async def create_user_with_options_async(
        self,
        request: dingtalkmail__1__0_models.CreateUserRequest,
        headers: dingtalkmail__1__0_models.CreateUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmail__1__0_models.CreateUserResponse:
        """
        @summary 创建企业邮箱用户
        
        @param request: CreateUserRequest
        @param headers: CreateUserHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateUserResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.email):
            body['email'] = request.email
        if not UtilClient.is_unset(request.employee_type):
            body['employeeType'] = request.employee_type
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.password):
            body['password'] = request.password
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
            action='CreateUser',
            version='mail_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/mail/users',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmail__1__0_models.CreateUserResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_user(
        self,
        request: dingtalkmail__1__0_models.CreateUserRequest,
    ) -> dingtalkmail__1__0_models.CreateUserResponse:
        """
        @summary 创建企业邮箱用户
        
        @param request: CreateUserRequest
        @return: CreateUserResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmail__1__0_models.CreateUserHeaders()
        return self.create_user_with_options(request, headers, runtime)

    async def create_user_async(
        self,
        request: dingtalkmail__1__0_models.CreateUserRequest,
    ) -> dingtalkmail__1__0_models.CreateUserResponse:
        """
        @summary 创建企业邮箱用户
        
        @param request: CreateUserRequest
        @return: CreateUserResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmail__1__0_models.CreateUserHeaders()
        return await self.create_user_with_options_async(request, headers, runtime)

    def delete_mail_folder_with_options(
        self,
        email: str,
        id: str,
        headers: dingtalkmail__1__0_models.DeleteMailFolderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmail__1__0_models.DeleteMailFolderResponse:
        """
        @summary 删除文件夹
        
        @param headers: DeleteMailFolderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteMailFolderResponse
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
            action='DeleteMailFolder',
            version='mail_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/mail/users/{email}/mailFolders/{id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmail__1__0_models.DeleteMailFolderResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_mail_folder_with_options_async(
        self,
        email: str,
        id: str,
        headers: dingtalkmail__1__0_models.DeleteMailFolderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmail__1__0_models.DeleteMailFolderResponse:
        """
        @summary 删除文件夹
        
        @param headers: DeleteMailFolderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteMailFolderResponse
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
            action='DeleteMailFolder',
            version='mail_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/mail/users/{email}/mailFolders/{id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmail__1__0_models.DeleteMailFolderResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_mail_folder(
        self,
        email: str,
        id: str,
    ) -> dingtalkmail__1__0_models.DeleteMailFolderResponse:
        """
        @summary 删除文件夹
        
        @return: DeleteMailFolderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmail__1__0_models.DeleteMailFolderHeaders()
        return self.delete_mail_folder_with_options(email, id, headers, runtime)

    async def delete_mail_folder_async(
        self,
        email: str,
        id: str,
    ) -> dingtalkmail__1__0_models.DeleteMailFolderResponse:
        """
        @summary 删除文件夹
        
        @return: DeleteMailFolderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmail__1__0_models.DeleteMailFolderHeaders()
        return await self.delete_mail_folder_with_options_async(email, id, headers, runtime)

    def delete_messages_with_options(
        self,
        email: str,
        request: dingtalkmail__1__0_models.DeleteMessagesRequest,
        headers: dingtalkmail__1__0_models.DeleteMessagesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmail__1__0_models.DeleteMessagesResponse:
        """
        @summary 批量删除邮件
        
        @param request: DeleteMessagesRequest
        @param headers: DeleteMessagesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteMessagesResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.delete_type):
            body['deleteType'] = request.delete_type
        if not UtilClient.is_unset(request.ids):
            body['ids'] = request.ids
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
            action='DeleteMessages',
            version='mail_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/mail/users/{email}/messages/batchDelete',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmail__1__0_models.DeleteMessagesResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_messages_with_options_async(
        self,
        email: str,
        request: dingtalkmail__1__0_models.DeleteMessagesRequest,
        headers: dingtalkmail__1__0_models.DeleteMessagesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmail__1__0_models.DeleteMessagesResponse:
        """
        @summary 批量删除邮件
        
        @param request: DeleteMessagesRequest
        @param headers: DeleteMessagesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteMessagesResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.delete_type):
            body['deleteType'] = request.delete_type
        if not UtilClient.is_unset(request.ids):
            body['ids'] = request.ids
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
            action='DeleteMessages',
            version='mail_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/mail/users/{email}/messages/batchDelete',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmail__1__0_models.DeleteMessagesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_messages(
        self,
        email: str,
        request: dingtalkmail__1__0_models.DeleteMessagesRequest,
    ) -> dingtalkmail__1__0_models.DeleteMessagesResponse:
        """
        @summary 批量删除邮件
        
        @param request: DeleteMessagesRequest
        @return: DeleteMessagesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmail__1__0_models.DeleteMessagesHeaders()
        return self.delete_messages_with_options(email, request, headers, runtime)

    async def delete_messages_async(
        self,
        email: str,
        request: dingtalkmail__1__0_models.DeleteMessagesRequest,
    ) -> dingtalkmail__1__0_models.DeleteMessagesResponse:
        """
        @summary 批量删除邮件
        
        @param request: DeleteMessagesRequest
        @return: DeleteMessagesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmail__1__0_models.DeleteMessagesHeaders()
        return await self.delete_messages_with_options_async(email, request, headers, runtime)

    def get_message_with_options(
        self,
        email: str,
        id: str,
        request: dingtalkmail__1__0_models.GetMessageRequest,
        headers: dingtalkmail__1__0_models.GetMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmail__1__0_models.GetMessageResponse:
        """
        @summary 获取邮件元数据
        
        @param request: GetMessageRequest
        @param headers: GetMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetMessageResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.select_fields):
            query['selectFields'] = request.select_fields
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
            action='GetMessage',
            version='mail_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/mail/users/{email}/messages/{id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmail__1__0_models.GetMessageResponse(),
            self.execute(params, req, runtime)
        )

    async def get_message_with_options_async(
        self,
        email: str,
        id: str,
        request: dingtalkmail__1__0_models.GetMessageRequest,
        headers: dingtalkmail__1__0_models.GetMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmail__1__0_models.GetMessageResponse:
        """
        @summary 获取邮件元数据
        
        @param request: GetMessageRequest
        @param headers: GetMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetMessageResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.select_fields):
            query['selectFields'] = request.select_fields
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
            action='GetMessage',
            version='mail_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/mail/users/{email}/messages/{id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmail__1__0_models.GetMessageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_message(
        self,
        email: str,
        id: str,
        request: dingtalkmail__1__0_models.GetMessageRequest,
    ) -> dingtalkmail__1__0_models.GetMessageResponse:
        """
        @summary 获取邮件元数据
        
        @param request: GetMessageRequest
        @return: GetMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmail__1__0_models.GetMessageHeaders()
        return self.get_message_with_options(email, id, request, headers, runtime)

    async def get_message_async(
        self,
        email: str,
        id: str,
        request: dingtalkmail__1__0_models.GetMessageRequest,
    ) -> dingtalkmail__1__0_models.GetMessageResponse:
        """
        @summary 获取邮件元数据
        
        @param request: GetMessageRequest
        @return: GetMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmail__1__0_models.GetMessageHeaders()
        return await self.get_message_with_options_async(email, id, request, headers, runtime)

    def list_mail_folders_with_options(
        self,
        email: str,
        request: dingtalkmail__1__0_models.ListMailFoldersRequest,
        headers: dingtalkmail__1__0_models.ListMailFoldersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmail__1__0_models.ListMailFoldersResponse:
        """
        @summary 获取指定文件夹的子文件夹列表
        
        @param request: ListMailFoldersRequest
        @param headers: ListMailFoldersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListMailFoldersResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.folder_id):
            query['folderId'] = request.folder_id
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
            action='ListMailFolders',
            version='mail_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/mail/users/{email}/mailFolders',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmail__1__0_models.ListMailFoldersResponse(),
            self.execute(params, req, runtime)
        )

    async def list_mail_folders_with_options_async(
        self,
        email: str,
        request: dingtalkmail__1__0_models.ListMailFoldersRequest,
        headers: dingtalkmail__1__0_models.ListMailFoldersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmail__1__0_models.ListMailFoldersResponse:
        """
        @summary 获取指定文件夹的子文件夹列表
        
        @param request: ListMailFoldersRequest
        @param headers: ListMailFoldersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListMailFoldersResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.folder_id):
            query['folderId'] = request.folder_id
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
            action='ListMailFolders',
            version='mail_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/mail/users/{email}/mailFolders',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmail__1__0_models.ListMailFoldersResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_mail_folders(
        self,
        email: str,
        request: dingtalkmail__1__0_models.ListMailFoldersRequest,
    ) -> dingtalkmail__1__0_models.ListMailFoldersResponse:
        """
        @summary 获取指定文件夹的子文件夹列表
        
        @param request: ListMailFoldersRequest
        @return: ListMailFoldersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmail__1__0_models.ListMailFoldersHeaders()
        return self.list_mail_folders_with_options(email, request, headers, runtime)

    async def list_mail_folders_async(
        self,
        email: str,
        request: dingtalkmail__1__0_models.ListMailFoldersRequest,
    ) -> dingtalkmail__1__0_models.ListMailFoldersResponse:
        """
        @summary 获取指定文件夹的子文件夹列表
        
        @param request: ListMailFoldersRequest
        @return: ListMailFoldersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmail__1__0_models.ListMailFoldersHeaders()
        return await self.list_mail_folders_with_options_async(email, request, headers, runtime)

    def list_messages_with_options(
        self,
        email: str,
        folder_id: str,
        request: dingtalkmail__1__0_models.ListMessagesRequest,
        headers: dingtalkmail__1__0_models.ListMessagesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmail__1__0_models.ListMessagesResponse:
        """
        @summary 获取邮件列表
        
        @param request: ListMessagesRequest
        @param headers: ListMessagesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListMessagesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.select_fields):
            query['selectFields'] = request.select_fields
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
            action='ListMessages',
            version='mail_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/mail/users/{email}/mailFolders/{folder_id}/messages',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmail__1__0_models.ListMessagesResponse(),
            self.execute(params, req, runtime)
        )

    async def list_messages_with_options_async(
        self,
        email: str,
        folder_id: str,
        request: dingtalkmail__1__0_models.ListMessagesRequest,
        headers: dingtalkmail__1__0_models.ListMessagesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmail__1__0_models.ListMessagesResponse:
        """
        @summary 获取邮件列表
        
        @param request: ListMessagesRequest
        @param headers: ListMessagesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListMessagesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.select_fields):
            query['selectFields'] = request.select_fields
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
            action='ListMessages',
            version='mail_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/mail/users/{email}/mailFolders/{folder_id}/messages',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmail__1__0_models.ListMessagesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_messages(
        self,
        email: str,
        folder_id: str,
        request: dingtalkmail__1__0_models.ListMessagesRequest,
    ) -> dingtalkmail__1__0_models.ListMessagesResponse:
        """
        @summary 获取邮件列表
        
        @param request: ListMessagesRequest
        @return: ListMessagesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmail__1__0_models.ListMessagesHeaders()
        return self.list_messages_with_options(email, folder_id, request, headers, runtime)

    async def list_messages_async(
        self,
        email: str,
        folder_id: str,
        request: dingtalkmail__1__0_models.ListMessagesRequest,
    ) -> dingtalkmail__1__0_models.ListMessagesResponse:
        """
        @summary 获取邮件列表
        
        @param request: ListMessagesRequest
        @return: ListMessagesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmail__1__0_models.ListMessagesHeaders()
        return await self.list_messages_with_options_async(email, folder_id, request, headers, runtime)

    def move_mail_folder_with_options(
        self,
        email: str,
        id: str,
        request: dingtalkmail__1__0_models.MoveMailFolderRequest,
        headers: dingtalkmail__1__0_models.MoveMailFolderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmail__1__0_models.MoveMailFolderResponse:
        """
        @summary 移动文件夹
        
        @param request: MoveMailFolderRequest
        @param headers: MoveMailFolderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: MoveMailFolderResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.destination_folder_id):
            body['destinationFolderId'] = request.destination_folder_id
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
            action='MoveMailFolder',
            version='mail_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/mail/users/{email}/mailFolders/{id}/move',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmail__1__0_models.MoveMailFolderResponse(),
            self.execute(params, req, runtime)
        )

    async def move_mail_folder_with_options_async(
        self,
        email: str,
        id: str,
        request: dingtalkmail__1__0_models.MoveMailFolderRequest,
        headers: dingtalkmail__1__0_models.MoveMailFolderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmail__1__0_models.MoveMailFolderResponse:
        """
        @summary 移动文件夹
        
        @param request: MoveMailFolderRequest
        @param headers: MoveMailFolderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: MoveMailFolderResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.destination_folder_id):
            body['destinationFolderId'] = request.destination_folder_id
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
            action='MoveMailFolder',
            version='mail_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/mail/users/{email}/mailFolders/{id}/move',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmail__1__0_models.MoveMailFolderResponse(),
            await self.execute_async(params, req, runtime)
        )

    def move_mail_folder(
        self,
        email: str,
        id: str,
        request: dingtalkmail__1__0_models.MoveMailFolderRequest,
    ) -> dingtalkmail__1__0_models.MoveMailFolderResponse:
        """
        @summary 移动文件夹
        
        @param request: MoveMailFolderRequest
        @return: MoveMailFolderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmail__1__0_models.MoveMailFolderHeaders()
        return self.move_mail_folder_with_options(email, id, request, headers, runtime)

    async def move_mail_folder_async(
        self,
        email: str,
        id: str,
        request: dingtalkmail__1__0_models.MoveMailFolderRequest,
    ) -> dingtalkmail__1__0_models.MoveMailFolderResponse:
        """
        @summary 移动文件夹
        
        @param request: MoveMailFolderRequest
        @return: MoveMailFolderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmail__1__0_models.MoveMailFolderHeaders()
        return await self.move_mail_folder_with_options_async(email, id, request, headers, runtime)

    def send_message_with_options(
        self,
        email: str,
        id: str,
        request: dingtalkmail__1__0_models.SendMessageRequest,
        headers: dingtalkmail__1__0_models.SendMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmail__1__0_models.SendMessageResponse:
        """
        @summary 发送邮件
        
        @param request: SendMessageRequest
        @param headers: SendMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SendMessageResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.save_to_sent_items):
            body['saveToSentItems'] = request.save_to_sent_items
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
            action='SendMessage',
            version='mail_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/mail/users/{email}/messages/{id}/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmail__1__0_models.SendMessageResponse(),
            self.execute(params, req, runtime)
        )

    async def send_message_with_options_async(
        self,
        email: str,
        id: str,
        request: dingtalkmail__1__0_models.SendMessageRequest,
        headers: dingtalkmail__1__0_models.SendMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmail__1__0_models.SendMessageResponse:
        """
        @summary 发送邮件
        
        @param request: SendMessageRequest
        @param headers: SendMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SendMessageResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.save_to_sent_items):
            body['saveToSentItems'] = request.save_to_sent_items
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
            action='SendMessage',
            version='mail_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/mail/users/{email}/messages/{id}/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmail__1__0_models.SendMessageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def send_message(
        self,
        email: str,
        id: str,
        request: dingtalkmail__1__0_models.SendMessageRequest,
    ) -> dingtalkmail__1__0_models.SendMessageResponse:
        """
        @summary 发送邮件
        
        @param request: SendMessageRequest
        @return: SendMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmail__1__0_models.SendMessageHeaders()
        return self.send_message_with_options(email, id, request, headers, runtime)

    async def send_message_async(
        self,
        email: str,
        id: str,
        request: dingtalkmail__1__0_models.SendMessageRequest,
    ) -> dingtalkmail__1__0_models.SendMessageResponse:
        """
        @summary 发送邮件
        
        @param request: SendMessageRequest
        @return: SendMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmail__1__0_models.SendMessageHeaders()
        return await self.send_message_with_options_async(email, id, request, headers, runtime)

    def update_mail_folder_with_options(
        self,
        email: str,
        id: str,
        request: dingtalkmail__1__0_models.UpdateMailFolderRequest,
        headers: dingtalkmail__1__0_models.UpdateMailFolderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmail__1__0_models.UpdateMailFolderResponse:
        """
        @summary 修改文件夹信息
        
        @param request: UpdateMailFolderRequest
        @param headers: UpdateMailFolderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateMailFolderResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.display_name):
            body['displayName'] = request.display_name
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
            action='UpdateMailFolder',
            version='mail_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/mail/users/{email}/mailFolders/{id}/update',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmail__1__0_models.UpdateMailFolderResponse(),
            self.execute(params, req, runtime)
        )

    async def update_mail_folder_with_options_async(
        self,
        email: str,
        id: str,
        request: dingtalkmail__1__0_models.UpdateMailFolderRequest,
        headers: dingtalkmail__1__0_models.UpdateMailFolderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmail__1__0_models.UpdateMailFolderResponse:
        """
        @summary 修改文件夹信息
        
        @param request: UpdateMailFolderRequest
        @param headers: UpdateMailFolderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateMailFolderResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.display_name):
            body['displayName'] = request.display_name
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
            action='UpdateMailFolder',
            version='mail_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/mail/users/{email}/mailFolders/{id}/update',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmail__1__0_models.UpdateMailFolderResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_mail_folder(
        self,
        email: str,
        id: str,
        request: dingtalkmail__1__0_models.UpdateMailFolderRequest,
    ) -> dingtalkmail__1__0_models.UpdateMailFolderResponse:
        """
        @summary 修改文件夹信息
        
        @param request: UpdateMailFolderRequest
        @return: UpdateMailFolderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmail__1__0_models.UpdateMailFolderHeaders()
        return self.update_mail_folder_with_options(email, id, request, headers, runtime)

    async def update_mail_folder_async(
        self,
        email: str,
        id: str,
        request: dingtalkmail__1__0_models.UpdateMailFolderRequest,
    ) -> dingtalkmail__1__0_models.UpdateMailFolderResponse:
        """
        @summary 修改文件夹信息
        
        @param request: UpdateMailFolderRequest
        @return: UpdateMailFolderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmail__1__0_models.UpdateMailFolderHeaders()
        return await self.update_mail_folder_with_options_async(email, id, request, headers, runtime)

    def update_message_with_options(
        self,
        email: str,
        id: str,
        request: dingtalkmail__1__0_models.UpdateMessageRequest,
        headers: dingtalkmail__1__0_models.UpdateMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmail__1__0_models.UpdateMessageResponse:
        """
        @summary 修改草稿
        
        @param request: UpdateMessageRequest
        @param headers: UpdateMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateMessageResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.message):
            body['message'] = request.message
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
            action='UpdateMessage',
            version='mail_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/mail/users/{email}/messages/{id}/update',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmail__1__0_models.UpdateMessageResponse(),
            self.execute(params, req, runtime)
        )

    async def update_message_with_options_async(
        self,
        email: str,
        id: str,
        request: dingtalkmail__1__0_models.UpdateMessageRequest,
        headers: dingtalkmail__1__0_models.UpdateMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmail__1__0_models.UpdateMessageResponse:
        """
        @summary 修改草稿
        
        @param request: UpdateMessageRequest
        @param headers: UpdateMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateMessageResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.message):
            body['message'] = request.message
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
            action='UpdateMessage',
            version='mail_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/mail/users/{email}/messages/{id}/update',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmail__1__0_models.UpdateMessageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_message(
        self,
        email: str,
        id: str,
        request: dingtalkmail__1__0_models.UpdateMessageRequest,
    ) -> dingtalkmail__1__0_models.UpdateMessageResponse:
        """
        @summary 修改草稿
        
        @param request: UpdateMessageRequest
        @return: UpdateMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmail__1__0_models.UpdateMessageHeaders()
        return self.update_message_with_options(email, id, request, headers, runtime)

    async def update_message_async(
        self,
        email: str,
        id: str,
        request: dingtalkmail__1__0_models.UpdateMessageRequest,
    ) -> dingtalkmail__1__0_models.UpdateMessageResponse:
        """
        @summary 修改草稿
        
        @param request: UpdateMessageRequest
        @return: UpdateMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmail__1__0_models.UpdateMessageHeaders()
        return await self.update_message_with_options_async(email, id, request, headers, runtime)
