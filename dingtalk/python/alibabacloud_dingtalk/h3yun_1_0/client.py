# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.h3yun_1_0 import models as dingtalkh_3yun__1__0_models
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

    def batch_insert_biz_object_with_options(
        self,
        request: dingtalkh_3yun__1__0_models.BatchInsertBizObjectRequest,
        headers: dingtalkh_3yun__1__0_models.BatchInsertBizObjectHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkh_3yun__1__0_models.BatchInsertBizObjectResponse:
        """
        @summary 批量创建表单业务对象数据
        
        @param request: BatchInsertBizObjectRequest
        @param headers: BatchInsertBizObjectHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchInsertBizObjectResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_object_json_array):
            body['bizObjectJsonArray'] = request.biz_object_json_array
        if not UtilClient.is_unset(request.is_draft):
            body['isDraft'] = request.is_draft
        if not UtilClient.is_unset(request.op_user_id):
            body['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.schema_code):
            body['schemaCode'] = request.schema_code
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
            action='BatchInsertBizObject',
            version='h3yun_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/h3yun/forms/instances/batch',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkh_3yun__1__0_models.BatchInsertBizObjectResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_insert_biz_object_with_options_async(
        self,
        request: dingtalkh_3yun__1__0_models.BatchInsertBizObjectRequest,
        headers: dingtalkh_3yun__1__0_models.BatchInsertBizObjectHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkh_3yun__1__0_models.BatchInsertBizObjectResponse:
        """
        @summary 批量创建表单业务对象数据
        
        @param request: BatchInsertBizObjectRequest
        @param headers: BatchInsertBizObjectHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchInsertBizObjectResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_object_json_array):
            body['bizObjectJsonArray'] = request.biz_object_json_array
        if not UtilClient.is_unset(request.is_draft):
            body['isDraft'] = request.is_draft
        if not UtilClient.is_unset(request.op_user_id):
            body['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.schema_code):
            body['schemaCode'] = request.schema_code
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
            action='BatchInsertBizObject',
            version='h3yun_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/h3yun/forms/instances/batch',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkh_3yun__1__0_models.BatchInsertBizObjectResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch_insert_biz_object(
        self,
        request: dingtalkh_3yun__1__0_models.BatchInsertBizObjectRequest,
    ) -> dingtalkh_3yun__1__0_models.BatchInsertBizObjectResponse:
        """
        @summary 批量创建表单业务对象数据
        
        @param request: BatchInsertBizObjectRequest
        @return: BatchInsertBizObjectResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkh_3yun__1__0_models.BatchInsertBizObjectHeaders()
        return self.batch_insert_biz_object_with_options(request, headers, runtime)

    async def batch_insert_biz_object_async(
        self,
        request: dingtalkh_3yun__1__0_models.BatchInsertBizObjectRequest,
    ) -> dingtalkh_3yun__1__0_models.BatchInsertBizObjectResponse:
        """
        @summary 批量创建表单业务对象数据
        
        @param request: BatchInsertBizObjectRequest
        @return: BatchInsertBizObjectResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkh_3yun__1__0_models.BatchInsertBizObjectHeaders()
        return await self.batch_insert_biz_object_with_options_async(request, headers, runtime)

    def cancel_process_instance_with_options(
        self,
        request: dingtalkh_3yun__1__0_models.CancelProcessInstanceRequest,
        headers: dingtalkh_3yun__1__0_models.CancelProcessInstanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkh_3yun__1__0_models.CancelProcessInstanceResponse:
        """
        @summary 取消流程实例
        
        @param request: CancelProcessInstanceRequest
        @param headers: CancelProcessInstanceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CancelProcessInstanceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.process_instance_id):
            body['processInstanceId'] = request.process_instance_id
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
            action='CancelProcessInstance',
            version='h3yun_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/h3yun/processes/instances/cancel',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkh_3yun__1__0_models.CancelProcessInstanceResponse(),
            self.execute(params, req, runtime)
        )

    async def cancel_process_instance_with_options_async(
        self,
        request: dingtalkh_3yun__1__0_models.CancelProcessInstanceRequest,
        headers: dingtalkh_3yun__1__0_models.CancelProcessInstanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkh_3yun__1__0_models.CancelProcessInstanceResponse:
        """
        @summary 取消流程实例
        
        @param request: CancelProcessInstanceRequest
        @param headers: CancelProcessInstanceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CancelProcessInstanceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.process_instance_id):
            body['processInstanceId'] = request.process_instance_id
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
            action='CancelProcessInstance',
            version='h3yun_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/h3yun/processes/instances/cancel',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkh_3yun__1__0_models.CancelProcessInstanceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def cancel_process_instance(
        self,
        request: dingtalkh_3yun__1__0_models.CancelProcessInstanceRequest,
    ) -> dingtalkh_3yun__1__0_models.CancelProcessInstanceResponse:
        """
        @summary 取消流程实例
        
        @param request: CancelProcessInstanceRequest
        @return: CancelProcessInstanceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkh_3yun__1__0_models.CancelProcessInstanceHeaders()
        return self.cancel_process_instance_with_options(request, headers, runtime)

    async def cancel_process_instance_async(
        self,
        request: dingtalkh_3yun__1__0_models.CancelProcessInstanceRequest,
    ) -> dingtalkh_3yun__1__0_models.CancelProcessInstanceResponse:
        """
        @summary 取消流程实例
        
        @param request: CancelProcessInstanceRequest
        @return: CancelProcessInstanceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkh_3yun__1__0_models.CancelProcessInstanceHeaders()
        return await self.cancel_process_instance_with_options_async(request, headers, runtime)

    def create_biz_object_with_options(
        self,
        request: dingtalkh_3yun__1__0_models.CreateBizObjectRequest,
        headers: dingtalkh_3yun__1__0_models.CreateBizObjectHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkh_3yun__1__0_models.CreateBizObjectResponse:
        """
        @summary 创建单条表单业务对象实例
        
        @param request: CreateBizObjectRequest
        @param headers: CreateBizObjectHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateBizObjectResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_object_json):
            body['bizObjectJson'] = request.biz_object_json
        if not UtilClient.is_unset(request.is_draft):
            body['isDraft'] = request.is_draft
        if not UtilClient.is_unset(request.op_user_id):
            body['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.schema_code):
            body['schemaCode'] = request.schema_code
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
            action='CreateBizObject',
            version='h3yun_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/h3yun/forms/instances',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkh_3yun__1__0_models.CreateBizObjectResponse(),
            self.execute(params, req, runtime)
        )

    async def create_biz_object_with_options_async(
        self,
        request: dingtalkh_3yun__1__0_models.CreateBizObjectRequest,
        headers: dingtalkh_3yun__1__0_models.CreateBizObjectHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkh_3yun__1__0_models.CreateBizObjectResponse:
        """
        @summary 创建单条表单业务对象实例
        
        @param request: CreateBizObjectRequest
        @param headers: CreateBizObjectHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateBizObjectResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_object_json):
            body['bizObjectJson'] = request.biz_object_json
        if not UtilClient.is_unset(request.is_draft):
            body['isDraft'] = request.is_draft
        if not UtilClient.is_unset(request.op_user_id):
            body['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.schema_code):
            body['schemaCode'] = request.schema_code
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
            action='CreateBizObject',
            version='h3yun_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/h3yun/forms/instances',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkh_3yun__1__0_models.CreateBizObjectResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_biz_object(
        self,
        request: dingtalkh_3yun__1__0_models.CreateBizObjectRequest,
    ) -> dingtalkh_3yun__1__0_models.CreateBizObjectResponse:
        """
        @summary 创建单条表单业务对象实例
        
        @param request: CreateBizObjectRequest
        @return: CreateBizObjectResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkh_3yun__1__0_models.CreateBizObjectHeaders()
        return self.create_biz_object_with_options(request, headers, runtime)

    async def create_biz_object_async(
        self,
        request: dingtalkh_3yun__1__0_models.CreateBizObjectRequest,
    ) -> dingtalkh_3yun__1__0_models.CreateBizObjectResponse:
        """
        @summary 创建单条表单业务对象实例
        
        @param request: CreateBizObjectRequest
        @return: CreateBizObjectResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkh_3yun__1__0_models.CreateBizObjectHeaders()
        return await self.create_biz_object_with_options_async(request, headers, runtime)

    def create_processes_instance_with_options(
        self,
        request: dingtalkh_3yun__1__0_models.CreateProcessesInstanceRequest,
        headers: dingtalkh_3yun__1__0_models.CreateProcessesInstanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkh_3yun__1__0_models.CreateProcessesInstanceResponse:
        """
        @summary 创建流程实例
        
        @param request: CreateProcessesInstanceRequest
        @param headers: CreateProcessesInstanceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateProcessesInstanceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_object_id):
            body['bizObjectId'] = request.biz_object_id
        if not UtilClient.is_unset(request.op_user_id):
            body['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.schema_code):
            body['schemaCode'] = request.schema_code
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
            action='CreateProcessesInstance',
            version='h3yun_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/h3yun/processes/instances',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkh_3yun__1__0_models.CreateProcessesInstanceResponse(),
            self.execute(params, req, runtime)
        )

    async def create_processes_instance_with_options_async(
        self,
        request: dingtalkh_3yun__1__0_models.CreateProcessesInstanceRequest,
        headers: dingtalkh_3yun__1__0_models.CreateProcessesInstanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkh_3yun__1__0_models.CreateProcessesInstanceResponse:
        """
        @summary 创建流程实例
        
        @param request: CreateProcessesInstanceRequest
        @param headers: CreateProcessesInstanceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateProcessesInstanceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_object_id):
            body['bizObjectId'] = request.biz_object_id
        if not UtilClient.is_unset(request.op_user_id):
            body['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.schema_code):
            body['schemaCode'] = request.schema_code
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
            action='CreateProcessesInstance',
            version='h3yun_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/h3yun/processes/instances',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkh_3yun__1__0_models.CreateProcessesInstanceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_processes_instance(
        self,
        request: dingtalkh_3yun__1__0_models.CreateProcessesInstanceRequest,
    ) -> dingtalkh_3yun__1__0_models.CreateProcessesInstanceResponse:
        """
        @summary 创建流程实例
        
        @param request: CreateProcessesInstanceRequest
        @return: CreateProcessesInstanceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkh_3yun__1__0_models.CreateProcessesInstanceHeaders()
        return self.create_processes_instance_with_options(request, headers, runtime)

    async def create_processes_instance_async(
        self,
        request: dingtalkh_3yun__1__0_models.CreateProcessesInstanceRequest,
    ) -> dingtalkh_3yun__1__0_models.CreateProcessesInstanceResponse:
        """
        @summary 创建流程实例
        
        @param request: CreateProcessesInstanceRequest
        @return: CreateProcessesInstanceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkh_3yun__1__0_models.CreateProcessesInstanceHeaders()
        return await self.create_processes_instance_with_options_async(request, headers, runtime)

    def delete_biz_object_with_options(
        self,
        request: dingtalkh_3yun__1__0_models.DeleteBizObjectRequest,
        headers: dingtalkh_3yun__1__0_models.DeleteBizObjectHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkh_3yun__1__0_models.DeleteBizObjectResponse:
        """
        @summary 删除表单业务对象实例
        
        @param request: DeleteBizObjectRequest
        @param headers: DeleteBizObjectHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteBizObjectResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.biz_object_id):
            query['bizObjectId'] = request.biz_object_id
        if not UtilClient.is_unset(request.schema_code):
            query['schemaCode'] = request.schema_code
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
            action='DeleteBizObject',
            version='h3yun_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/h3yun/forms/instances',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkh_3yun__1__0_models.DeleteBizObjectResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_biz_object_with_options_async(
        self,
        request: dingtalkh_3yun__1__0_models.DeleteBizObjectRequest,
        headers: dingtalkh_3yun__1__0_models.DeleteBizObjectHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkh_3yun__1__0_models.DeleteBizObjectResponse:
        """
        @summary 删除表单业务对象实例
        
        @param request: DeleteBizObjectRequest
        @param headers: DeleteBizObjectHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteBizObjectResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.biz_object_id):
            query['bizObjectId'] = request.biz_object_id
        if not UtilClient.is_unset(request.schema_code):
            query['schemaCode'] = request.schema_code
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
            action='DeleteBizObject',
            version='h3yun_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/h3yun/forms/instances',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkh_3yun__1__0_models.DeleteBizObjectResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_biz_object(
        self,
        request: dingtalkh_3yun__1__0_models.DeleteBizObjectRequest,
    ) -> dingtalkh_3yun__1__0_models.DeleteBizObjectResponse:
        """
        @summary 删除表单业务对象实例
        
        @param request: DeleteBizObjectRequest
        @return: DeleteBizObjectResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkh_3yun__1__0_models.DeleteBizObjectHeaders()
        return self.delete_biz_object_with_options(request, headers, runtime)

    async def delete_biz_object_async(
        self,
        request: dingtalkh_3yun__1__0_models.DeleteBizObjectRequest,
    ) -> dingtalkh_3yun__1__0_models.DeleteBizObjectResponse:
        """
        @summary 删除表单业务对象实例
        
        @param request: DeleteBizObjectRequest
        @return: DeleteBizObjectResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkh_3yun__1__0_models.DeleteBizObjectHeaders()
        return await self.delete_biz_object_with_options_async(request, headers, runtime)

    def delete_processes_instance_with_options(
        self,
        request: dingtalkh_3yun__1__0_models.DeleteProcessesInstanceRequest,
        headers: dingtalkh_3yun__1__0_models.DeleteProcessesInstanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkh_3yun__1__0_models.DeleteProcessesInstanceResponse:
        """
        @summary 删除流程实例
        
        @param request: DeleteProcessesInstanceRequest
        @param headers: DeleteProcessesInstanceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteProcessesInstanceResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.is_auto_update_biz_object):
            query['isAutoUpdateBizObject'] = request.is_auto_update_biz_object
        if not UtilClient.is_unset(request.process_instance_id):
            query['processInstanceId'] = request.process_instance_id
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
            action='DeleteProcessesInstance',
            version='h3yun_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/h3yun/processes/instances',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkh_3yun__1__0_models.DeleteProcessesInstanceResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_processes_instance_with_options_async(
        self,
        request: dingtalkh_3yun__1__0_models.DeleteProcessesInstanceRequest,
        headers: dingtalkh_3yun__1__0_models.DeleteProcessesInstanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkh_3yun__1__0_models.DeleteProcessesInstanceResponse:
        """
        @summary 删除流程实例
        
        @param request: DeleteProcessesInstanceRequest
        @param headers: DeleteProcessesInstanceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteProcessesInstanceResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.is_auto_update_biz_object):
            query['isAutoUpdateBizObject'] = request.is_auto_update_biz_object
        if not UtilClient.is_unset(request.process_instance_id):
            query['processInstanceId'] = request.process_instance_id
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
            action='DeleteProcessesInstance',
            version='h3yun_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/h3yun/processes/instances',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkh_3yun__1__0_models.DeleteProcessesInstanceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_processes_instance(
        self,
        request: dingtalkh_3yun__1__0_models.DeleteProcessesInstanceRequest,
    ) -> dingtalkh_3yun__1__0_models.DeleteProcessesInstanceResponse:
        """
        @summary 删除流程实例
        
        @param request: DeleteProcessesInstanceRequest
        @return: DeleteProcessesInstanceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkh_3yun__1__0_models.DeleteProcessesInstanceHeaders()
        return self.delete_processes_instance_with_options(request, headers, runtime)

    async def delete_processes_instance_async(
        self,
        request: dingtalkh_3yun__1__0_models.DeleteProcessesInstanceRequest,
    ) -> dingtalkh_3yun__1__0_models.DeleteProcessesInstanceResponse:
        """
        @summary 删除流程实例
        
        @param request: DeleteProcessesInstanceRequest
        @return: DeleteProcessesInstanceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkh_3yun__1__0_models.DeleteProcessesInstanceHeaders()
        return await self.delete_processes_instance_with_options_async(request, headers, runtime)

    def get_apps_with_options(
        self,
        request: dingtalkh_3yun__1__0_models.GetAppsRequest,
        headers: dingtalkh_3yun__1__0_models.GetAppsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkh_3yun__1__0_models.GetAppsResponse:
        """
        @summary 获取应用数据
        
        @param request: GetAppsRequest
        @param headers: GetAppsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAppsResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.query_type):
            body['queryType'] = request.query_type
        if not UtilClient.is_unset(request.values):
            body['values'] = request.values
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
            action='GetApps',
            version='h3yun_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/h3yun/apps/search',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkh_3yun__1__0_models.GetAppsResponse(),
            self.execute(params, req, runtime)
        )

    async def get_apps_with_options_async(
        self,
        request: dingtalkh_3yun__1__0_models.GetAppsRequest,
        headers: dingtalkh_3yun__1__0_models.GetAppsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkh_3yun__1__0_models.GetAppsResponse:
        """
        @summary 获取应用数据
        
        @param request: GetAppsRequest
        @param headers: GetAppsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAppsResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.query_type):
            body['queryType'] = request.query_type
        if not UtilClient.is_unset(request.values):
            body['values'] = request.values
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
            action='GetApps',
            version='h3yun_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/h3yun/apps/search',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkh_3yun__1__0_models.GetAppsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_apps(
        self,
        request: dingtalkh_3yun__1__0_models.GetAppsRequest,
    ) -> dingtalkh_3yun__1__0_models.GetAppsResponse:
        """
        @summary 获取应用数据
        
        @param request: GetAppsRequest
        @return: GetAppsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkh_3yun__1__0_models.GetAppsHeaders()
        return self.get_apps_with_options(request, headers, runtime)

    async def get_apps_async(
        self,
        request: dingtalkh_3yun__1__0_models.GetAppsRequest,
    ) -> dingtalkh_3yun__1__0_models.GetAppsResponse:
        """
        @summary 获取应用数据
        
        @param request: GetAppsRequest
        @return: GetAppsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkh_3yun__1__0_models.GetAppsHeaders()
        return await self.get_apps_with_options_async(request, headers, runtime)

    def get_attachment_temporary_url_with_options(
        self,
        request: dingtalkh_3yun__1__0_models.GetAttachmentTemporaryUrlRequest,
        headers: dingtalkh_3yun__1__0_models.GetAttachmentTemporaryUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkh_3yun__1__0_models.GetAttachmentTemporaryUrlResponse:
        """
        @summary 获取附件临时免登地址
        
        @param request: GetAttachmentTemporaryUrlRequest
        @param headers: GetAttachmentTemporaryUrlHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAttachmentTemporaryUrlResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.attachment_id):
            query['attachmentId'] = request.attachment_id
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
            action='GetAttachmentTemporaryUrl',
            version='h3yun_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/h3yun/attachments/temporaryUrls',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkh_3yun__1__0_models.GetAttachmentTemporaryUrlResponse(),
            self.execute(params, req, runtime)
        )

    async def get_attachment_temporary_url_with_options_async(
        self,
        request: dingtalkh_3yun__1__0_models.GetAttachmentTemporaryUrlRequest,
        headers: dingtalkh_3yun__1__0_models.GetAttachmentTemporaryUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkh_3yun__1__0_models.GetAttachmentTemporaryUrlResponse:
        """
        @summary 获取附件临时免登地址
        
        @param request: GetAttachmentTemporaryUrlRequest
        @param headers: GetAttachmentTemporaryUrlHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAttachmentTemporaryUrlResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.attachment_id):
            query['attachmentId'] = request.attachment_id
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
            action='GetAttachmentTemporaryUrl',
            version='h3yun_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/h3yun/attachments/temporaryUrls',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkh_3yun__1__0_models.GetAttachmentTemporaryUrlResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_attachment_temporary_url(
        self,
        request: dingtalkh_3yun__1__0_models.GetAttachmentTemporaryUrlRequest,
    ) -> dingtalkh_3yun__1__0_models.GetAttachmentTemporaryUrlResponse:
        """
        @summary 获取附件临时免登地址
        
        @param request: GetAttachmentTemporaryUrlRequest
        @return: GetAttachmentTemporaryUrlResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkh_3yun__1__0_models.GetAttachmentTemporaryUrlHeaders()
        return self.get_attachment_temporary_url_with_options(request, headers, runtime)

    async def get_attachment_temporary_url_async(
        self,
        request: dingtalkh_3yun__1__0_models.GetAttachmentTemporaryUrlRequest,
    ) -> dingtalkh_3yun__1__0_models.GetAttachmentTemporaryUrlResponse:
        """
        @summary 获取附件临时免登地址
        
        @param request: GetAttachmentTemporaryUrlRequest
        @return: GetAttachmentTemporaryUrlResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkh_3yun__1__0_models.GetAttachmentTemporaryUrlHeaders()
        return await self.get_attachment_temporary_url_with_options_async(request, headers, runtime)

    def get_organizations_with_options(
        self,
        request: dingtalkh_3yun__1__0_models.GetOrganizationsRequest,
        headers: dingtalkh_3yun__1__0_models.GetOrganizationsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkh_3yun__1__0_models.GetOrganizationsResponse:
        """
        @summary 获取组织数据
        
        @param request: GetOrganizationsRequest
        @param headers: GetOrganizationsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetOrganizationsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.department_id):
            query['departmentId'] = request.department_id
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
            action='GetOrganizations',
            version='h3yun_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/h3yun/departments',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkh_3yun__1__0_models.GetOrganizationsResponse(),
            self.execute(params, req, runtime)
        )

    async def get_organizations_with_options_async(
        self,
        request: dingtalkh_3yun__1__0_models.GetOrganizationsRequest,
        headers: dingtalkh_3yun__1__0_models.GetOrganizationsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkh_3yun__1__0_models.GetOrganizationsResponse:
        """
        @summary 获取组织数据
        
        @param request: GetOrganizationsRequest
        @param headers: GetOrganizationsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetOrganizationsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.department_id):
            query['departmentId'] = request.department_id
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
            action='GetOrganizations',
            version='h3yun_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/h3yun/departments',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkh_3yun__1__0_models.GetOrganizationsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_organizations(
        self,
        request: dingtalkh_3yun__1__0_models.GetOrganizationsRequest,
    ) -> dingtalkh_3yun__1__0_models.GetOrganizationsResponse:
        """
        @summary 获取组织数据
        
        @param request: GetOrganizationsRequest
        @return: GetOrganizationsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkh_3yun__1__0_models.GetOrganizationsHeaders()
        return self.get_organizations_with_options(request, headers, runtime)

    async def get_organizations_async(
        self,
        request: dingtalkh_3yun__1__0_models.GetOrganizationsRequest,
    ) -> dingtalkh_3yun__1__0_models.GetOrganizationsResponse:
        """
        @summary 获取组织数据
        
        @param request: GetOrganizationsRequest
        @return: GetOrganizationsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkh_3yun__1__0_models.GetOrganizationsHeaders()
        return await self.get_organizations_with_options_async(request, headers, runtime)

    def get_role_users_with_options(
        self,
        request: dingtalkh_3yun__1__0_models.GetRoleUsersRequest,
        headers: dingtalkh_3yun__1__0_models.GetRoleUsersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkh_3yun__1__0_models.GetRoleUsersResponse:
        """
        @summary 获取角色用户信息
        
        @param request: GetRoleUsersRequest
        @param headers: GetRoleUsersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetRoleUsersResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.role_id):
            query['roleId'] = request.role_id
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
            action='GetRoleUsers',
            version='h3yun_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/h3yun/roles/roleUsers',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkh_3yun__1__0_models.GetRoleUsersResponse(),
            self.execute(params, req, runtime)
        )

    async def get_role_users_with_options_async(
        self,
        request: dingtalkh_3yun__1__0_models.GetRoleUsersRequest,
        headers: dingtalkh_3yun__1__0_models.GetRoleUsersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkh_3yun__1__0_models.GetRoleUsersResponse:
        """
        @summary 获取角色用户信息
        
        @param request: GetRoleUsersRequest
        @param headers: GetRoleUsersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetRoleUsersResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.role_id):
            query['roleId'] = request.role_id
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
            action='GetRoleUsers',
            version='h3yun_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/h3yun/roles/roleUsers',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkh_3yun__1__0_models.GetRoleUsersResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_role_users(
        self,
        request: dingtalkh_3yun__1__0_models.GetRoleUsersRequest,
    ) -> dingtalkh_3yun__1__0_models.GetRoleUsersResponse:
        """
        @summary 获取角色用户信息
        
        @param request: GetRoleUsersRequest
        @return: GetRoleUsersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkh_3yun__1__0_models.GetRoleUsersHeaders()
        return self.get_role_users_with_options(request, headers, runtime)

    async def get_role_users_async(
        self,
        request: dingtalkh_3yun__1__0_models.GetRoleUsersRequest,
    ) -> dingtalkh_3yun__1__0_models.GetRoleUsersResponse:
        """
        @summary 获取角色用户信息
        
        @param request: GetRoleUsersRequest
        @return: GetRoleUsersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkh_3yun__1__0_models.GetRoleUsersHeaders()
        return await self.get_role_users_with_options_async(request, headers, runtime)

    def get_roles_with_options(
        self,
        headers: dingtalkh_3yun__1__0_models.GetRolesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkh_3yun__1__0_models.GetRolesResponse:
        """
        @summary 获取角色数据
        
        @param headers: GetRolesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetRolesResponse
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
            action='GetRoles',
            version='h3yun_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/h3yun/roles',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkh_3yun__1__0_models.GetRolesResponse(),
            self.execute(params, req, runtime)
        )

    async def get_roles_with_options_async(
        self,
        headers: dingtalkh_3yun__1__0_models.GetRolesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkh_3yun__1__0_models.GetRolesResponse:
        """
        @summary 获取角色数据
        
        @param headers: GetRolesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetRolesResponse
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
            action='GetRoles',
            version='h3yun_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/h3yun/roles',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkh_3yun__1__0_models.GetRolesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_roles(self) -> dingtalkh_3yun__1__0_models.GetRolesResponse:
        """
        @summary 获取角色数据
        
        @return: GetRolesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkh_3yun__1__0_models.GetRolesHeaders()
        return self.get_roles_with_options(headers, runtime)

    async def get_roles_async(self) -> dingtalkh_3yun__1__0_models.GetRolesResponse:
        """
        @summary 获取角色数据
        
        @return: GetRolesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkh_3yun__1__0_models.GetRolesHeaders()
        return await self.get_roles_with_options_async(headers, runtime)

    def get_upload_url_with_options(
        self,
        request: dingtalkh_3yun__1__0_models.GetUploadUrlRequest,
        headers: dingtalkh_3yun__1__0_models.GetUploadUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkh_3yun__1__0_models.GetUploadUrlResponse:
        """
        @summary 获取文件上传地址
        
        @param request: GetUploadUrlRequest
        @param headers: GetUploadUrlHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetUploadUrlResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.biz_object_id):
            query['bizObjectId'] = request.biz_object_id
        if not UtilClient.is_unset(request.field_name):
            query['fieldName'] = request.field_name
        if not UtilClient.is_unset(request.is_overwrite):
            query['isOverwrite'] = request.is_overwrite
        if not UtilClient.is_unset(request.schema_code):
            query['schemaCode'] = request.schema_code
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
            action='GetUploadUrl',
            version='h3yun_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/h3yun/attachments/uploadUrls',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkh_3yun__1__0_models.GetUploadUrlResponse(),
            self.execute(params, req, runtime)
        )

    async def get_upload_url_with_options_async(
        self,
        request: dingtalkh_3yun__1__0_models.GetUploadUrlRequest,
        headers: dingtalkh_3yun__1__0_models.GetUploadUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkh_3yun__1__0_models.GetUploadUrlResponse:
        """
        @summary 获取文件上传地址
        
        @param request: GetUploadUrlRequest
        @param headers: GetUploadUrlHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetUploadUrlResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.biz_object_id):
            query['bizObjectId'] = request.biz_object_id
        if not UtilClient.is_unset(request.field_name):
            query['fieldName'] = request.field_name
        if not UtilClient.is_unset(request.is_overwrite):
            query['isOverwrite'] = request.is_overwrite
        if not UtilClient.is_unset(request.schema_code):
            query['schemaCode'] = request.schema_code
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
            action='GetUploadUrl',
            version='h3yun_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/h3yun/attachments/uploadUrls',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkh_3yun__1__0_models.GetUploadUrlResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_upload_url(
        self,
        request: dingtalkh_3yun__1__0_models.GetUploadUrlRequest,
    ) -> dingtalkh_3yun__1__0_models.GetUploadUrlResponse:
        """
        @summary 获取文件上传地址
        
        @param request: GetUploadUrlRequest
        @return: GetUploadUrlResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkh_3yun__1__0_models.GetUploadUrlHeaders()
        return self.get_upload_url_with_options(request, headers, runtime)

    async def get_upload_url_async(
        self,
        request: dingtalkh_3yun__1__0_models.GetUploadUrlRequest,
    ) -> dingtalkh_3yun__1__0_models.GetUploadUrlResponse:
        """
        @summary 获取文件上传地址
        
        @param request: GetUploadUrlRequest
        @return: GetUploadUrlResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkh_3yun__1__0_models.GetUploadUrlHeaders()
        return await self.get_upload_url_with_options_async(request, headers, runtime)

    def get_users_with_options(
        self,
        request: dingtalkh_3yun__1__0_models.GetUsersRequest,
        headers: dingtalkh_3yun__1__0_models.GetUsersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkh_3yun__1__0_models.GetUsersResponse:
        """
        @summary 获取用户数据
        
        @param request: GetUsersRequest
        @param headers: GetUsersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetUsersResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.department_id):
            query['departmentId'] = request.department_id
        if not UtilClient.is_unset(request.is_recursive):
            query['isRecursive'] = request.is_recursive
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
            action='GetUsers',
            version='h3yun_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/h3yun/users',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkh_3yun__1__0_models.GetUsersResponse(),
            self.execute(params, req, runtime)
        )

    async def get_users_with_options_async(
        self,
        request: dingtalkh_3yun__1__0_models.GetUsersRequest,
        headers: dingtalkh_3yun__1__0_models.GetUsersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkh_3yun__1__0_models.GetUsersResponse:
        """
        @summary 获取用户数据
        
        @param request: GetUsersRequest
        @param headers: GetUsersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetUsersResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.department_id):
            query['departmentId'] = request.department_id
        if not UtilClient.is_unset(request.is_recursive):
            query['isRecursive'] = request.is_recursive
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
            action='GetUsers',
            version='h3yun_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/h3yun/users',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkh_3yun__1__0_models.GetUsersResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_users(
        self,
        request: dingtalkh_3yun__1__0_models.GetUsersRequest,
    ) -> dingtalkh_3yun__1__0_models.GetUsersResponse:
        """
        @summary 获取用户数据
        
        @param request: GetUsersRequest
        @return: GetUsersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkh_3yun__1__0_models.GetUsersHeaders()
        return self.get_users_with_options(request, headers, runtime)

    async def get_users_async(
        self,
        request: dingtalkh_3yun__1__0_models.GetUsersRequest,
    ) -> dingtalkh_3yun__1__0_models.GetUsersResponse:
        """
        @summary 获取用户数据
        
        @param request: GetUsersRequest
        @return: GetUsersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkh_3yun__1__0_models.GetUsersHeaders()
        return await self.get_users_with_options_async(request, headers, runtime)

    def load_biz_fields_with_options(
        self,
        request: dingtalkh_3yun__1__0_models.LoadBizFieldsRequest,
        headers: dingtalkh_3yun__1__0_models.LoadBizFieldsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkh_3yun__1__0_models.LoadBizFieldsResponse:
        """
        @summary 获取表单业务字段信息
        
        @param request: LoadBizFieldsRequest
        @param headers: LoadBizFieldsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: LoadBizFieldsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.schema_code):
            query['schemaCode'] = request.schema_code
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
            action='LoadBizFields',
            version='h3yun_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/h3yun/forms/loadBizFields',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkh_3yun__1__0_models.LoadBizFieldsResponse(),
            self.execute(params, req, runtime)
        )

    async def load_biz_fields_with_options_async(
        self,
        request: dingtalkh_3yun__1__0_models.LoadBizFieldsRequest,
        headers: dingtalkh_3yun__1__0_models.LoadBizFieldsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkh_3yun__1__0_models.LoadBizFieldsResponse:
        """
        @summary 获取表单业务字段信息
        
        @param request: LoadBizFieldsRequest
        @param headers: LoadBizFieldsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: LoadBizFieldsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.schema_code):
            query['schemaCode'] = request.schema_code
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
            action='LoadBizFields',
            version='h3yun_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/h3yun/forms/loadBizFields',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkh_3yun__1__0_models.LoadBizFieldsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def load_biz_fields(
        self,
        request: dingtalkh_3yun__1__0_models.LoadBizFieldsRequest,
    ) -> dingtalkh_3yun__1__0_models.LoadBizFieldsResponse:
        """
        @summary 获取表单业务字段信息
        
        @param request: LoadBizFieldsRequest
        @return: LoadBizFieldsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkh_3yun__1__0_models.LoadBizFieldsHeaders()
        return self.load_biz_fields_with_options(request, headers, runtime)

    async def load_biz_fields_async(
        self,
        request: dingtalkh_3yun__1__0_models.LoadBizFieldsRequest,
    ) -> dingtalkh_3yun__1__0_models.LoadBizFieldsResponse:
        """
        @summary 获取表单业务字段信息
        
        @param request: LoadBizFieldsRequest
        @return: LoadBizFieldsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkh_3yun__1__0_models.LoadBizFieldsHeaders()
        return await self.load_biz_fields_with_options_async(request, headers, runtime)

    def load_biz_object_with_options(
        self,
        request: dingtalkh_3yun__1__0_models.LoadBizObjectRequest,
        headers: dingtalkh_3yun__1__0_models.LoadBizObjectHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkh_3yun__1__0_models.LoadBizObjectResponse:
        """
        @summary 获取单条表单业务对象实例
        
        @param request: LoadBizObjectRequest
        @param headers: LoadBizObjectHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: LoadBizObjectResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.biz_object_id):
            query['bizObjectId'] = request.biz_object_id
        if not UtilClient.is_unset(request.schema_code):
            query['schemaCode'] = request.schema_code
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
            action='LoadBizObject',
            version='h3yun_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/h3yun/forms/instances/loadInstances',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkh_3yun__1__0_models.LoadBizObjectResponse(),
            self.execute(params, req, runtime)
        )

    async def load_biz_object_with_options_async(
        self,
        request: dingtalkh_3yun__1__0_models.LoadBizObjectRequest,
        headers: dingtalkh_3yun__1__0_models.LoadBizObjectHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkh_3yun__1__0_models.LoadBizObjectResponse:
        """
        @summary 获取单条表单业务对象实例
        
        @param request: LoadBizObjectRequest
        @param headers: LoadBizObjectHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: LoadBizObjectResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.biz_object_id):
            query['bizObjectId'] = request.biz_object_id
        if not UtilClient.is_unset(request.schema_code):
            query['schemaCode'] = request.schema_code
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
            action='LoadBizObject',
            version='h3yun_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/h3yun/forms/instances/loadInstances',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkh_3yun__1__0_models.LoadBizObjectResponse(),
            await self.execute_async(params, req, runtime)
        )

    def load_biz_object(
        self,
        request: dingtalkh_3yun__1__0_models.LoadBizObjectRequest,
    ) -> dingtalkh_3yun__1__0_models.LoadBizObjectResponse:
        """
        @summary 获取单条表单业务对象实例
        
        @param request: LoadBizObjectRequest
        @return: LoadBizObjectResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkh_3yun__1__0_models.LoadBizObjectHeaders()
        return self.load_biz_object_with_options(request, headers, runtime)

    async def load_biz_object_async(
        self,
        request: dingtalkh_3yun__1__0_models.LoadBizObjectRequest,
    ) -> dingtalkh_3yun__1__0_models.LoadBizObjectResponse:
        """
        @summary 获取单条表单业务对象实例
        
        @param request: LoadBizObjectRequest
        @return: LoadBizObjectResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkh_3yun__1__0_models.LoadBizObjectHeaders()
        return await self.load_biz_object_with_options_async(request, headers, runtime)

    def load_biz_objects_with_options(
        self,
        request: dingtalkh_3yun__1__0_models.LoadBizObjectsRequest,
        headers: dingtalkh_3yun__1__0_models.LoadBizObjectsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkh_3yun__1__0_models.LoadBizObjectsResponse:
        """
        @summary 查询表单实例列表
        
        @param request: LoadBizObjectsRequest
        @param headers: LoadBizObjectsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: LoadBizObjectsResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.matcher_json):
            body['matcherJson'] = request.matcher_json
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.return_fields):
            body['returnFields'] = request.return_fields
        if not UtilClient.is_unset(request.schema_code):
            body['schemaCode'] = request.schema_code
        if not UtilClient.is_unset(request.sort_by_fields):
            body['sortByFields'] = request.sort_by_fields
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
            action='LoadBizObjects',
            version='h3yun_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/h3yun/forms/instances/search',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkh_3yun__1__0_models.LoadBizObjectsResponse(),
            self.execute(params, req, runtime)
        )

    async def load_biz_objects_with_options_async(
        self,
        request: dingtalkh_3yun__1__0_models.LoadBizObjectsRequest,
        headers: dingtalkh_3yun__1__0_models.LoadBizObjectsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkh_3yun__1__0_models.LoadBizObjectsResponse:
        """
        @summary 查询表单实例列表
        
        @param request: LoadBizObjectsRequest
        @param headers: LoadBizObjectsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: LoadBizObjectsResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.matcher_json):
            body['matcherJson'] = request.matcher_json
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.return_fields):
            body['returnFields'] = request.return_fields
        if not UtilClient.is_unset(request.schema_code):
            body['schemaCode'] = request.schema_code
        if not UtilClient.is_unset(request.sort_by_fields):
            body['sortByFields'] = request.sort_by_fields
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
            action='LoadBizObjects',
            version='h3yun_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/h3yun/forms/instances/search',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkh_3yun__1__0_models.LoadBizObjectsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def load_biz_objects(
        self,
        request: dingtalkh_3yun__1__0_models.LoadBizObjectsRequest,
    ) -> dingtalkh_3yun__1__0_models.LoadBizObjectsResponse:
        """
        @summary 查询表单实例列表
        
        @param request: LoadBizObjectsRequest
        @return: LoadBizObjectsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkh_3yun__1__0_models.LoadBizObjectsHeaders()
        return self.load_biz_objects_with_options(request, headers, runtime)

    async def load_biz_objects_async(
        self,
        request: dingtalkh_3yun__1__0_models.LoadBizObjectsRequest,
    ) -> dingtalkh_3yun__1__0_models.LoadBizObjectsResponse:
        """
        @summary 查询表单实例列表
        
        @param request: LoadBizObjectsRequest
        @return: LoadBizObjectsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkh_3yun__1__0_models.LoadBizObjectsHeaders()
        return await self.load_biz_objects_with_options_async(request, headers, runtime)

    def query_app_function_nodes_with_options(
        self,
        request: dingtalkh_3yun__1__0_models.QueryAppFunctionNodesRequest,
        headers: dingtalkh_3yun__1__0_models.QueryAppFunctionNodesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkh_3yun__1__0_models.QueryAppFunctionNodesResponse:
        """
        @summary 获取应用的功能节点信息
        
        @param request: QueryAppFunctionNodesRequest
        @param headers: QueryAppFunctionNodesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryAppFunctionNodesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_code):
            query['appCode'] = request.app_code
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
            action='QueryAppFunctionNodes',
            version='h3yun_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/h3yun/apps/functionNodes',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkh_3yun__1__0_models.QueryAppFunctionNodesResponse(),
            self.execute(params, req, runtime)
        )

    async def query_app_function_nodes_with_options_async(
        self,
        request: dingtalkh_3yun__1__0_models.QueryAppFunctionNodesRequest,
        headers: dingtalkh_3yun__1__0_models.QueryAppFunctionNodesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkh_3yun__1__0_models.QueryAppFunctionNodesResponse:
        """
        @summary 获取应用的功能节点信息
        
        @param request: QueryAppFunctionNodesRequest
        @param headers: QueryAppFunctionNodesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryAppFunctionNodesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_code):
            query['appCode'] = request.app_code
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
            action='QueryAppFunctionNodes',
            version='h3yun_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/h3yun/apps/functionNodes',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkh_3yun__1__0_models.QueryAppFunctionNodesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_app_function_nodes(
        self,
        request: dingtalkh_3yun__1__0_models.QueryAppFunctionNodesRequest,
    ) -> dingtalkh_3yun__1__0_models.QueryAppFunctionNodesResponse:
        """
        @summary 获取应用的功能节点信息
        
        @param request: QueryAppFunctionNodesRequest
        @return: QueryAppFunctionNodesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkh_3yun__1__0_models.QueryAppFunctionNodesHeaders()
        return self.query_app_function_nodes_with_options(request, headers, runtime)

    async def query_app_function_nodes_async(
        self,
        request: dingtalkh_3yun__1__0_models.QueryAppFunctionNodesRequest,
    ) -> dingtalkh_3yun__1__0_models.QueryAppFunctionNodesResponse:
        """
        @summary 获取应用的功能节点信息
        
        @param request: QueryAppFunctionNodesRequest
        @return: QueryAppFunctionNodesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkh_3yun__1__0_models.QueryAppFunctionNodesHeaders()
        return await self.query_app_function_nodes_with_options_async(request, headers, runtime)

    def query_processes_instance_with_options(
        self,
        request: dingtalkh_3yun__1__0_models.QueryProcessesInstanceRequest,
        headers: dingtalkh_3yun__1__0_models.QueryProcessesInstanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkh_3yun__1__0_models.QueryProcessesInstanceResponse:
        """
        @summary 获取流程实例
        
        @param request: QueryProcessesInstanceRequest
        @param headers: QueryProcessesInstanceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryProcessesInstanceResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.biz_object_id):
            query['bizObjectId'] = request.biz_object_id
        if not UtilClient.is_unset(request.schema_code):
            query['schemaCode'] = request.schema_code
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
            action='QueryProcessesInstance',
            version='h3yun_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/h3yun/processes/instances',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkh_3yun__1__0_models.QueryProcessesInstanceResponse(),
            self.execute(params, req, runtime)
        )

    async def query_processes_instance_with_options_async(
        self,
        request: dingtalkh_3yun__1__0_models.QueryProcessesInstanceRequest,
        headers: dingtalkh_3yun__1__0_models.QueryProcessesInstanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkh_3yun__1__0_models.QueryProcessesInstanceResponse:
        """
        @summary 获取流程实例
        
        @param request: QueryProcessesInstanceRequest
        @param headers: QueryProcessesInstanceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryProcessesInstanceResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.biz_object_id):
            query['bizObjectId'] = request.biz_object_id
        if not UtilClient.is_unset(request.schema_code):
            query['schemaCode'] = request.schema_code
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
            action='QueryProcessesInstance',
            version='h3yun_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/h3yun/processes/instances',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkh_3yun__1__0_models.QueryProcessesInstanceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_processes_instance(
        self,
        request: dingtalkh_3yun__1__0_models.QueryProcessesInstanceRequest,
    ) -> dingtalkh_3yun__1__0_models.QueryProcessesInstanceResponse:
        """
        @summary 获取流程实例
        
        @param request: QueryProcessesInstanceRequest
        @return: QueryProcessesInstanceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkh_3yun__1__0_models.QueryProcessesInstanceHeaders()
        return self.query_processes_instance_with_options(request, headers, runtime)

    async def query_processes_instance_async(
        self,
        request: dingtalkh_3yun__1__0_models.QueryProcessesInstanceRequest,
    ) -> dingtalkh_3yun__1__0_models.QueryProcessesInstanceResponse:
        """
        @summary 获取流程实例
        
        @param request: QueryProcessesInstanceRequest
        @return: QueryProcessesInstanceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkh_3yun__1__0_models.QueryProcessesInstanceHeaders()
        return await self.query_processes_instance_with_options_async(request, headers, runtime)

    def query_processes_work_items_with_options(
        self,
        request: dingtalkh_3yun__1__0_models.QueryProcessesWorkItemsRequest,
        headers: dingtalkh_3yun__1__0_models.QueryProcessesWorkItemsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkh_3yun__1__0_models.QueryProcessesWorkItemsResponse:
        """
        @summary 获取流程实例节点工作项
        
        @param request: QueryProcessesWorkItemsRequest
        @param headers: QueryProcessesWorkItemsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryProcessesWorkItemsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.process_instance_id):
            query['processInstanceId'] = request.process_instance_id
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
            action='QueryProcessesWorkItems',
            version='h3yun_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/h3yun/processes/workItems',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkh_3yun__1__0_models.QueryProcessesWorkItemsResponse(),
            self.execute(params, req, runtime)
        )

    async def query_processes_work_items_with_options_async(
        self,
        request: dingtalkh_3yun__1__0_models.QueryProcessesWorkItemsRequest,
        headers: dingtalkh_3yun__1__0_models.QueryProcessesWorkItemsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkh_3yun__1__0_models.QueryProcessesWorkItemsResponse:
        """
        @summary 获取流程实例节点工作项
        
        @param request: QueryProcessesWorkItemsRequest
        @param headers: QueryProcessesWorkItemsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryProcessesWorkItemsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.process_instance_id):
            query['processInstanceId'] = request.process_instance_id
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
            action='QueryProcessesWorkItems',
            version='h3yun_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/h3yun/processes/workItems',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkh_3yun__1__0_models.QueryProcessesWorkItemsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_processes_work_items(
        self,
        request: dingtalkh_3yun__1__0_models.QueryProcessesWorkItemsRequest,
    ) -> dingtalkh_3yun__1__0_models.QueryProcessesWorkItemsResponse:
        """
        @summary 获取流程实例节点工作项
        
        @param request: QueryProcessesWorkItemsRequest
        @return: QueryProcessesWorkItemsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkh_3yun__1__0_models.QueryProcessesWorkItemsHeaders()
        return self.query_processes_work_items_with_options(request, headers, runtime)

    async def query_processes_work_items_async(
        self,
        request: dingtalkh_3yun__1__0_models.QueryProcessesWorkItemsRequest,
    ) -> dingtalkh_3yun__1__0_models.QueryProcessesWorkItemsResponse:
        """
        @summary 获取流程实例节点工作项
        
        @param request: QueryProcessesWorkItemsRequest
        @return: QueryProcessesWorkItemsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkh_3yun__1__0_models.QueryProcessesWorkItemsHeaders()
        return await self.query_processes_work_items_with_options_async(request, headers, runtime)

    def update_biz_object_with_options(
        self,
        request: dingtalkh_3yun__1__0_models.UpdateBizObjectRequest,
        headers: dingtalkh_3yun__1__0_models.UpdateBizObjectHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkh_3yun__1__0_models.UpdateBizObjectResponse:
        """
        @summary 修改表单业务对象数据
        
        @param request: UpdateBizObjectRequest
        @param headers: UpdateBizObjectHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateBizObjectResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_object_id):
            body['bizObjectId'] = request.biz_object_id
        if not UtilClient.is_unset(request.biz_object_json):
            body['bizObjectJson'] = request.biz_object_json
        if not UtilClient.is_unset(request.schema_code):
            body['schemaCode'] = request.schema_code
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
            action='UpdateBizObject',
            version='h3yun_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/h3yun/forms/instances',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkh_3yun__1__0_models.UpdateBizObjectResponse(),
            self.execute(params, req, runtime)
        )

    async def update_biz_object_with_options_async(
        self,
        request: dingtalkh_3yun__1__0_models.UpdateBizObjectRequest,
        headers: dingtalkh_3yun__1__0_models.UpdateBizObjectHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkh_3yun__1__0_models.UpdateBizObjectResponse:
        """
        @summary 修改表单业务对象数据
        
        @param request: UpdateBizObjectRequest
        @param headers: UpdateBizObjectHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateBizObjectResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_object_id):
            body['bizObjectId'] = request.biz_object_id
        if not UtilClient.is_unset(request.biz_object_json):
            body['bizObjectJson'] = request.biz_object_json
        if not UtilClient.is_unset(request.schema_code):
            body['schemaCode'] = request.schema_code
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
            action='UpdateBizObject',
            version='h3yun_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/h3yun/forms/instances',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkh_3yun__1__0_models.UpdateBizObjectResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_biz_object(
        self,
        request: dingtalkh_3yun__1__0_models.UpdateBizObjectRequest,
    ) -> dingtalkh_3yun__1__0_models.UpdateBizObjectResponse:
        """
        @summary 修改表单业务对象数据
        
        @param request: UpdateBizObjectRequest
        @return: UpdateBizObjectResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkh_3yun__1__0_models.UpdateBizObjectHeaders()
        return self.update_biz_object_with_options(request, headers, runtime)

    async def update_biz_object_async(
        self,
        request: dingtalkh_3yun__1__0_models.UpdateBizObjectRequest,
    ) -> dingtalkh_3yun__1__0_models.UpdateBizObjectResponse:
        """
        @summary 修改表单业务对象数据
        
        @param request: UpdateBizObjectRequest
        @return: UpdateBizObjectResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkh_3yun__1__0_models.UpdateBizObjectHeaders()
        return await self.update_biz_object_with_options_async(request, headers, runtime)
